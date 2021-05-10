using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InsertTransactionVM
    {
        public string IdCustomer { get; set; }
        public string IdItem { get; set; }
        public int TotalCost { get; set; }
        public int Qty { get; set; }
    }
}
