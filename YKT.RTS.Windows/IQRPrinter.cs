﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKT.RubberTraceSystem.Windows
{
    public interface IQRPrinter
    {
        bool PrintQRCode(int x, int y, int scarl, string data);
    }
}
