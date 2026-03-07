using System;
using System.Collections.Generic;
using System.Text;

namespace OCPCorrectImplementation.Services
{
    internal class OnlineOrder : IOrderProcessMethod
    {
        public string ProcessOrder()
        {
            return "Processing Online order.";
        }
    }
}
