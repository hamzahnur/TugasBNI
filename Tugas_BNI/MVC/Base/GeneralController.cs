using API.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace MVC.Base
{
    public class GeneralController<Entity, Key> : Controller
    {
        protected readonly HttpClient httpClient;

        public GeneralController()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(URL.BaseUrl)
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> Get()
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var response = await httpClient.GetAsync(typeof(Entity).Name);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var entities = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<Entity>>>(apiResponse);
            return Json(entities);
        }

        public async Task<JsonResult> GetById(Key key)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var response = await httpClient.GetAsync(typeof(Entity).Name + "/" + key);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var entity = JsonConvert.DeserializeObject<ResponseVM<Entity>>(apiResponse);
            return Json(entity);
        }

        [HttpPost]
        public async Task<JsonResult> Post(Entity entity)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var response = await httpClient.PostAsJsonAsync(typeof(Entity).Name, entity);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Entity>(apiResponse);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(Key key)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            using var response = await httpClient.DeleteAsync(typeof(Entity).Name + '/' + key);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return Json(apiResponse);
        }

        [HttpPut]
        public async Task<JsonResult> Put(Entity entity)
        {
            var header = Request.Headers["Authorization"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var response = await httpClient.PutAsJsonAsync(typeof(Entity).Name, entity);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return Json(apiResponse);
        }
    }
}
