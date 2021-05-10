using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ItemController : GeneralController<Item, string>
    {
        public IActionResult List()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            if (ViewBag.Role == "Admin")
            {
                return View();
            }

            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [Route("Item/Insert")]
        public async Task<JsonResult> Insert(InsertItemsVM insert)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            StringContent content = new StringContent(JsonConvert.SerializeObject(insert), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Item/Insert", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<InsertItemsVM>>(apiResponse);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("Item/GetItem")]
        public async Task<IActionResult> GetItem()
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var respone = await httpClient.GetAsync("Item/GetItem");
            string apiResponse = await respone.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<GetItemVM>>>(apiResponse);
            return Json(data);
        }
    }
}
