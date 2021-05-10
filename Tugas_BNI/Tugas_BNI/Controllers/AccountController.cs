
using API.Base.Controllers;
using API.Models;
using API.Repository.Data;
using API.Service;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository _accountRepository;
        private readonly IConfiguration _configuration;
        public AccountController(AccountRepository accountRepository, IConfiguration configuration) : base(accountRepository)
        {
            _accountRepository = accountRepository;
            _configuration = configuration;
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginVM login)
        {
            var result = _accountRepository.Login(login);
            if (result != null)
            {
                 var jwt = new JwtServices(_configuration);
                  var token = jwt.GenerateSecurityToken(result);
                return Ok(new { Status = HttpStatusCode.OK, result, Message = "You have successfully Sign In", Token = token });
            }
            else
            {
                return Unauthorized(new
                {
                    Status = HttpStatusCode.Unauthorized,
                    result,
                    Message = "Unauthorized Access",
                    Token = ""
                });
            }
        }
        [HttpPut("ResetPassword")]
        public ActionResult ResetPassword(ResetPassword resetPasswordVM)
        {
            if (resetPasswordVM == null)
            {
                return BadRequest(new { status = HttpStatusCode.BadRequest, message = "Data Yang Di-Input Salah / Tidak Lengkap" });
            }
            var data = _accountRepository.ResetPassword(resetPasswordVM.Email);
            return (data > 0) ? (ActionResult)Ok(new { message = "Email has been Sent, password changed", result = " ", status = "Ok" }) :
                NotFound(new { message = "Data not exist in our database, please register first", status = 404 });
        }

        [HttpPut("ChangePassword")]
        public IActionResult ChangePassword(ChangePassword changePasswordVM)
        {
            if (changePasswordVM == null)
            {
                return BadRequest(new { status = HttpStatusCode.BadRequest, message = "Data Yang Di-Input Salah / Tidak Lengkap" });
            }
            var result = _accountRepository.ChangePassword(changePasswordVM);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = " ", message = "Berhasil Update Data" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Gagal Update Data" });
            }
        }
    }
}
