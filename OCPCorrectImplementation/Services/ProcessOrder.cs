using System;
using System.Collections.Generic;
using System.Text;

namespace OCPCorrectImplementation.Services
{
    public class ProcessOrder
    {
        private readonly IOrderProcessMethod _orderProcessMethod;
        public ProcessOrder(IOrderProcessMethod orderProcessMethod)
        {
            _orderProcessMethod = orderProcessMethod;
        }
        public string Process()
        {
            return _orderProcessMethod.ProcessOrder();
        }
    }
}
