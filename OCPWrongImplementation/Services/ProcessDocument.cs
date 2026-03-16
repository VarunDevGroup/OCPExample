using System;
using System.Collections.Generic;
using System.Text;

namespace OCPWrongImplementation.Services
{
    public class ProcessDocument
    {

        public string Process(string documentType)
        {
            if (documentType == "WORD")
            {
                return "Processing Word Document.";
            }
            else if (documentType == "PDF")
            {
                return "Processing PDF Documnet.";
            }
            else
            {
                return "Invalid Document Type";
            }
        }
    }
}
