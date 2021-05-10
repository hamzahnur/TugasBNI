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
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AccountController : GeneralController<Account, string>
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Account/Login")]
        public async Task<JsonResult> Login(LoginVM loginVM)
        {
            var response = await httpClient.PostAsJsonAsync("Account/Login", loginVM);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<UserLoginVM>(apiResponse);

            if (result.Status == "200")
            {
                HttpContext.Session.SetString("Status", result.Status);
                HttpContext.Session.SetString("Token", result.Token);
                HttpContext.Session.SetString("IdCustomer", result.Result.IdCustomer);
                HttpContext.Session.SetString("Name", result.Result.Name);
                HttpContext.Session.SetString("Email", result.Result.Email);
                HttpContext.Session.SetString("Role", result.Result.RoleName);
                ViewBag.Role = HttpContext.Session.GetString("Role");

                return Json(result);
            }
            else
            {
                return Json(result);
            }
        }
        [HttpPut]
        [Route("Account/ResetPassword")]
        public async Task<JsonResult> ResetPassword(ResetPassword resetPasswordVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(resetPasswordVM), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("Account/ResetPassword", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResetPassword>(apiResponse);
            return new JsonResult(result);
        }
        [HttpPost]
        [Route("Account/Logout")]
        public IActionResult Logout()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);

            }
            return RedirectToAction("Index", "Account");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Account/Register")]
        public async Task<JsonResult> Register(RegisterVM register)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(register), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Customer/Register", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<RegisterVM>>(apiResponse);
            return new JsonResult(result);
        }
    }
}
