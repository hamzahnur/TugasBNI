using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class CustomerController :  GeneralController<Customer, string>
    {
        public IActionResult Profile()
    {
            //  return View();
            ViewBag.Role = HttpContext.Session.GetString("Role");
            if (ViewBag.Role == "Customer")
            {
                return View();
            }
            if (ViewBag.Role == "Admin")
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
        [HttpPut]
        [Route("Account/ChangePassword")]
        public async Task<JsonResult> ChangePassword(ChangePassword changePasswordVM)
        {
            ViewBag.IdCustomer = HttpContext.Session.GetString("IdCustomer");
            var header = HttpContext.Session.GetString("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var id = ViewBag.IdCustomer;
            changePasswordVM.IdCustomer = id;
            var definition = new { Status = "", Message = "" };
            var response = await httpClient.PutAsJsonAsync("Account/ChangePassword", changePasswordVM);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeAnonymousType(apiResponse, definition);
            return Json(result);
        }
    }
}
