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
    public class TranscationController :  BaseController<Transcation, TranscationRepository, string>
    {
        private readonly TranscationRepository _transcationRepository;
        public TranscationController(TranscationRepository transcationRepository) : base(transcationRepository)
        {
            _transcationRepository = transcationRepository;
        }
        [HttpPost("Insert")]
        public IActionResult Insert(InsertTransactionVM insert)
        {
            var result = _transcationRepository.Insert(insert);
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Berhasil Membuat Data Baru" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result = "", message = "Gagal Membuat Data Baru" });
            }
        }
        [HttpGet("GetTransaction/{idTransaction}")]
        public ActionResult<GetTransactionVM> GetTransaction(string idTransaction)
        {
            var result = _transcationRepository.GetTransaction(idTransaction);
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Ditemukan" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result, message = "Terjadi Kesalahan" }); ;
            }
        }

        [HttpDelete("Deletes/{idTransaction}")]
        public ActionResult Deletes(string idTransaction)
        {
            var result = _transcationRepository.Deletes(idTransaction);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = " ", message = "Berhasil Menghapus Data Baru" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Gagal Menghapus Data Baru" });
            }
        }
    }
}
