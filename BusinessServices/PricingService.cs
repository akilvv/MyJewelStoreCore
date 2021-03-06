﻿using MyJewelStoreCore.Context.Enum;
using MyJewelStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJewelStoreCore.BusinessServices
{
    public class PricingService: IPricingService
    {
        private IPrintEstimationService _printEstimationService;
        public PricingService(IPrintEstimationService printEstimationService)
        {
            this._printEstimationService = printEstimationService;
        }

        public void EstimatePrice(PriceModel priceModel, out float finalPrice)
        {
            float final = float.MinValue;
            try
            {
                final = (priceModel.price * priceModel.weight) - priceModel.discount;
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            finalPrice = final;
        }

        public string EstimatePrice(PriceModel priceModel, PrintType pType)
        {
            string result = string.Empty;
            try
            {
                switch (pType)
                {
                    case PrintType.printOnScreen:
                        _printEstimationService.PrintOnScreen(priceModel, out result);
                        break;
                    case PrintType.printToPaper:
                        _printEstimationService.PrintToPaper(priceModel, out result);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return result;
        }
    }
}
