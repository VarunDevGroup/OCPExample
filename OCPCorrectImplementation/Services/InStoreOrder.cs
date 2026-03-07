using System;
using System.Collections.Generic;
using System.Text;

namespace OCPCorrectImplementation.Services
{
    internal class InStoreOrder : IOrderProcessMethod
    {
        public string ProcessOrder()
        {
            return "Processing in-store order.";
        }
    }
}
