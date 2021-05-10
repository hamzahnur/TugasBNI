using API.Base.Controllers;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : BaseController<Item, ItemRepository, string>
    {
        private readonly ItemRepository _itemRepository;
        public ItemController(ItemRepository itemRepository) : base(itemRepository)
        {
            _itemRepository = itemRepository;
        }
        [HttpPost("Insert")]
        public IActionResult Insert(InsertItemsVM insert)
        {
            var result = _itemRepository.Insert(insert);
            if (result == null)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Berhasil Membuat Data Baru" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result = "", message = "Gagal Membuat Data Baru" });
            }
        }
        [HttpGet("GetItem")]
        public ActionResult<GetItemVM> GetItem()
        {
            var result = _itemRepository.GetItem();
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Ditemukan" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result, message = "Terjadi Kesalahan" }); ;
            }
        }
    }
}
