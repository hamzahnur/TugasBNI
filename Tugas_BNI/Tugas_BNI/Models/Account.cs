using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_M_Account")]
    public class Account
    {
        [Key]
        public string IdCustomer { get; set; }
        public string Password { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
