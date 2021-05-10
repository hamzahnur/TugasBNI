using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class GetItemVM
    {
        public string IdItem { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
    }
}
