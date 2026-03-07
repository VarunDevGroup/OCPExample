using OCPWrongImplementation.Services;

namespace OCPWrongImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ProcessOrder processOrder = new ProcessOrder();
            Console.WriteLine("Order 1 :" + processOrder.Process("Online"));

            Console.WriteLine("Order 2 :" + processOrder.Process("InStore"));

            Console.ReadLine();
        }
    }
}
