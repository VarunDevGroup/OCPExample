using System;
using System.Collections.Generic;
using System.Text;

namespace OCPCorrectImplementation.Services
{
    public class DocumentParser
    {
        private readonly IDocumentProcess _documnetProcessMethod;
        public DocumentParser(IDocumentProcess documentProcessMethod)
        {
            _documnetProcessMethod = documentProcessMethod;
        }
        public string Process()
        {
            return _documnetProcessMethod.ProcessDocument();
        }
    }
}
