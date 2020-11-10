using Strategy_Pattern_Using_different_shipping_providers.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_Using_different_shipping_providers.Business.Strategies.Shipping
{
    public interface IShippingStrategy
    {
        void Ship(Order order);
    }

}
