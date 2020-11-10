using Strategy_Pattern_Using_different_shipping_providers.Business.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy_Pattern_Using_different_shipping_providers.Business.Strategies.Shipping
{
    public class DHLShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using(var client = new HttpClient())
            {

                Console.WriteLine("Order is shipped with DHL");
            }
        }
    }
}
