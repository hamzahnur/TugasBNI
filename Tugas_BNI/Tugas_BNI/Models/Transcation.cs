using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_T_Transcation")]
    public class Transcation
    {
        [Key]
        public string IdTransaction { get; set; }
        public string IdCustomer { get; set; }
        public virtual Customer Customer { get; set; }
        public string IdItem { get; set; }
        public virtual Item Item { get; set; }
        public DateTime DateTranscation { get; set; }
        public int TotalCost { get; set; }
        public int Qty { get; set; }
    }
}
