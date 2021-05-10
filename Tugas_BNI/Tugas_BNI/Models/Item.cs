
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models
{
    [Table("Tb_M_Item")]
    public class Item
    {
        [Key]
        public string IdItem { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        [JsonIgnore]
        public virtual ICollection<Transcation> Transcations { get; set; }
    }
}
