using MyJewelStoreCore.Context.Enum;
using MyJewelStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.BusinessServices
{
    public interface IPricingService
    {
        void EstimatePrice(PriceModel priceModel, out float finalPrice);
        string EstimatePrice(PriceModel priceModel, PrintType pType);
    }
}
