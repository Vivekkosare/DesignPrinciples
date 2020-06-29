using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Client
{
    //public class HPLaserJet : IPrintTasks
    //{
    //    public bool FaxContent(string content)
    //    {
    //        Console.WriteLine("Fax done");
    //        return true;
    //    }

    //    public bool PhotoCopyContent(string content)
    //    {
    //        Console.WriteLine("PhotoCopy done");
    //        return true;
    //    }

    //    public bool PrintContent(string content)
    //    {
    //        Console.WriteLine("Print done");
    //        return true;
    //    }

    //    public bool PrintDuplexContent(string content)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool ScanContent(string content)
    //    {
    //        Console.WriteLine("Scan done");
    //        return true;
    //    }
    //}
    public class HPLaserJet : IPrintScanContent, IPrintDuplex, IFaxContent
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax done");
            return true;
        }

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

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
    }
}
