using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class SweedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            var origin = order.ShippingDetails.OriginCountry.ToLowerInvariant();

            if (destination == origin)
            {
                return order.TotalPrice * 0.25m;
            }
            return 0;
        }
    }
}
