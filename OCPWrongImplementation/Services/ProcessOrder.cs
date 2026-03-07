using System;
using System.Collections.Generic;
using System.Text;

namespace OCPWrongImplementation.Services
{
    public class ProcessOrder
    {

        public string Process(string orderType)
        {
            if (orderType == "Online")
            {
                return "Processing online order.";
            }
            else if (orderType == "InStore")
            {
                return "Processing in-store order.";
            }
            else
            {
                throw new ArgumentException("Invalid order type.");
            }
        }
    }
}
