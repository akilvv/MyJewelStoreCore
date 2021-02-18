using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.Models
{
    public class PriceModel
    {
        public float price { get; set; }
        public float weight { get; set; }
        public float discount { get; set; }
        public float finalPrice { get; set; }
    }
}
