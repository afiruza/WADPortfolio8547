using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FreshBrewStore.Models
{
    public class Product
    {
        public int CategoryID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

    }
}
