using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class LoginVM
    {
        public string IdCustomer { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string RoleName { set; get; }
    }
}
