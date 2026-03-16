using System;
using System.Collections.Generic;
using System.Text;

namespace OCPCorrectImplementation.Services
{
    internal class WordProcessor : IDocumentProcess
    {
        public string ProcessDocument()
        {
            return "Processing Word Document.";
        }
    }
}
