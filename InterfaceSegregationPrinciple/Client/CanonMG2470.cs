using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Client
{
    class CanonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
    }
}
