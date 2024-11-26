using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public byte[] Image { get; set; }
    }
}
