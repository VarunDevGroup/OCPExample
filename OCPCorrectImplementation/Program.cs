using OCPCorrectImplementation.Services;

namespace OCPCorrectImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentParser processPDF = new DocumentParser(new PDFProcessor());
            Console.WriteLine(processPDF.Process());

            DocumentParser processWord = new DocumentParser(new WordProcessor());
            Console.WriteLine(processWord.Process());



            Console.ReadLine();
        }
    }
}
