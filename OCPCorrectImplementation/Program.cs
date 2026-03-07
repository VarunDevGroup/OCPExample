using OCPCorrectImplementation.Services;

namespace OCPCorrectImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessOrder processFirstOrder = new ProcessOrder(new OnlineOrder());
            Console.WriteLine(processFirstOrder.Process());

            ProcessOrder processSecondOrder = new ProcessOrder(new InStoreOrder());
            Console.WriteLine(processSecondOrder.Process());



            Console.ReadLine();
        }
    }
}
