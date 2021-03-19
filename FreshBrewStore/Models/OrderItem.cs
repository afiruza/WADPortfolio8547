using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FreshBrewStore.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
    }
}
