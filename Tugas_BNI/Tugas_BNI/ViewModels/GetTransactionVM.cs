using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class GetTransactionVM
    {
        public string IdTransaction { get; set; }
        public string IdItem { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateTranscation { get; set; }
        public int Qty { get; set; }
        public int TotalCost { get; set; }
    }
}
