using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKT.RubberTraceSystem.Windows
{
    public class QRPrinterFactory
    {
        static IQRPrinter printer;
        public static IQRPrinter GetQRPrinter()
        {
            if(printer == null )
            {
                printer = new ArgoxQRPrinter();
            }
            return printer;
        }
    }
}
