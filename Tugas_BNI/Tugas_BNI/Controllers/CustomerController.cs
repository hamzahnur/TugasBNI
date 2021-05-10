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
    public class CustomerController : BaseController<Customer, CustomerRepository, string>
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerController(CustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterVM register)
        {
            var result = _customerRepository.Register(register);
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Berhasil Membuat Data Baru" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result = "", message = "Gagal Membuat Data Baru" });
            }
        }
       
    }
}
