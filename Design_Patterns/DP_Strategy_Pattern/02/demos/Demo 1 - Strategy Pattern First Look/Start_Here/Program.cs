using Strategy_Pattern_First_Look.Business.Models;
using Strategy_Pattern_First_Look.Business.Strategies.SalesTax;
using System;

namespace Strategy_Pattern_First_Look
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails 
                { 
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();

            //SET the interface to new instance of the tax classes
           // if(destination == "sweden") { order.SalesTaxStrategy = new SweedenSalesTaxStrategy(); }
           // else if(destination == "us") { order.SalesTaxStrategy = new USAStateSalesTaxStrategy(); }

            //Alternately
            
            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            //pass into tax method
            Console.WriteLine(order.GetTax(new SweedenSalesTaxStrategy()));
        }
    }
}
