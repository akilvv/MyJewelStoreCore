using MyJewelStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.BusinessServices
{
    public interface IPrintEstimationService
    {
        //print on Screen is handled by FrontEnd
        //We are building the string just for representational purpose
        void PrintOnScreen(PriceModel priceModel, out string result);

        void PrintToPaper(PriceModel priceModel, out string result);
    }
}
