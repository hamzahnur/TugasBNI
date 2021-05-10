using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class TransactionController : GeneralController<Customer, string>
    {
        public IActionResult purchase()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            if (ViewBag.Role == "Customer")
            {
                return View();
            }

            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
        public async Task<IActionResult> EmpProfile()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.IdCustomer = HttpContext.Session.GetString("IdCustomer");
            var header = HttpContext.Session.GetString("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var id = ViewBag.IdCustomer;
            var response = await httpClient.GetAsync("Customer/" + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ResponseVM<Customer>>(apiResponse);
            return new JsonResult(data);
        }
        [HttpPost]
        [Route("Transaction/Insert")]
        public async Task<JsonResult> Insert(InsertTransactionVM insert)
        {
            ViewBag.IdCustomer = HttpContext.Session.GetString("IdCustomer");
            var id = ViewBag.IdCustomer;
            insert.IdCustomer = id;
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            StringContent content = new StringContent(JsonConvert.SerializeObject(insert), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Transcation/Insert", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<InsertTransactionVM>>(apiResponse);
            return new JsonResult(result);
        }
        public IActionResult History()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            if (ViewBag.Role == "Customer")
            {
                return View();
            }

            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpGet]
        [Route("Transaction/GetTransaction")]
        public async Task<IActionResult> GetTransaction()
        {
            ViewBag.IdCustomer = HttpContext.Session.GetString("IdCustomer");
            var id = ViewBag.IdCustomer;
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var respone = await httpClient.GetAsync("Transcation/GetTransaction/" + id);
            string apiResponse = await respone.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<GetTransactionVM>>>(apiResponse);
            return Json(data);
        }
        [HttpPost]
        [Route("Transaction/Deletes")]
        public async Task<JsonResult> Deletes(string idTransaction)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            using var response = await httpClient.DeleteAsync("Transcation/Deletes/" + idTransaction);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return Json(apiResponse);
        }
    }
}
