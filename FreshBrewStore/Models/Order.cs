using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshBrewStore.Models
{
    public class Order
    {
        public int ID { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
