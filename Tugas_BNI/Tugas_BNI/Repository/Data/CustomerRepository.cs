using API.Context;
using API.Handler;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace API.Repository.Data
{
    public class CustomerRepository : GeneralRepository<MyContext, Customer, string>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        private readonly SendEmail sendEmail = new SendEmail();
        public CustomerRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }
        public RegisterVM Register(RegisterVM register)
        {
            var _customer = new GeneralDapperRepository<RegisterVM>(_configuration);
            _parameters.Add("@Name", register.Name);
            _parameters.Add("@Email", register.Email);
            var result = _customer.Query("SP_Register", _parameters);
            var email = result.Email;
            var fullname = result.Name;
            var Password = result.Password;
            sendEmail.SendRegister(email, fullname, Password);
            return result;
        }
    }
}
