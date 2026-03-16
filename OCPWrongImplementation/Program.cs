using OCPWrongImplementation.Services;

namespace OCPWrongImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ProcessDocument processDocument = new ProcessDocument();
            Console.WriteLine("Doc 1 :" + processDocument.Process("WORD"));

            Console.WriteLine("Doc 2 :" + processDocument.Process("PDF"));

            Console.ReadLine();
        }
    }
}
