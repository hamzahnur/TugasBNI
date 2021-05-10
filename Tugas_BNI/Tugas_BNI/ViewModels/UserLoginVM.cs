using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class UserLoginVM
    {
        public DataLogin Result { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string Status { get; set; }
    }
    public class DataLogin
    {
        public string IdCustomer { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
    }
}
