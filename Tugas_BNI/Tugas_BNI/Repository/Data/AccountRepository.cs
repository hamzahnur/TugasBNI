using API.Context;
using API.Handler;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class AccountRepository : GeneralRepository<MyContext, Account, string>
    {
        private readonly MyContext myContext;
        public IConfiguration _configuration;
        private readonly SendEmail sendEmail = new SendEmail();
        readonly DynamicParameters _parameters = new DynamicParameters();
        public AccountRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            myContext.Set<Account>();
            this.myContext = myContext;
            _configuration = configuration;
        }
        public LoginVM Login(LoginVM loginVM)
        {
            var _customerRepository = new GeneralDapperRepository<LoginVM>(_configuration);
            _parameters.Add("@Email", loginVM.Email);
            _parameters.Add("@Password", loginVM.Password);
            var result = _customerRepository.Query("SP_Login", _parameters);
            return result;
        }
        public int ResetPassword(string email)
        {
            string resetCode = Guid.NewGuid().ToString("N").Substring(0, 8);
            var time24 = DateTime.Now.ToString("HH:mm:ss");
            var getuser = myContext.Customers.Include(customer => customer.Account).Where(customer => customer.Email == email).FirstOrDefault();
            var userAccount = myContext.Accounts.Where(account => account.IdCustomer == getuser.IdCustomer).FirstOrDefault();
            var name = getuser.Name;
            if (getuser == null)
            {
                return 0;
            }
            else
            {
                var password = resetCode;
                userAccount.Password = password;
                var result = myContext.SaveChanges();
                sendEmail.SendForgotPassword(name, resetCode, email);
                return result;
            }
        }
        public int ChangePassword(ChangePassword changePasswordVM)
        {
            var _userRepository = new GeneralDapperRepository<ChangePassword>(_configuration);
            _parameters.Add("@IdCustomer", changePasswordVM.IdCustomer);
            _parameters.Add("@OldPassword", changePasswordVM.OldPassword);
            _parameters.Add("@NewPassword", changePasswordVM.NewPassword);
            var result = _userRepository.Update("SP_UpdatePassword", _parameters);
            return result;
        }
    }
}
