using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ChangePassword
    {
        public string IdCustomer { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
