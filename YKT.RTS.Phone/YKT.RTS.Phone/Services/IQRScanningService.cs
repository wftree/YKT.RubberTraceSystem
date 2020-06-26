using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YKT.RubberTraceSystem.Phone.Services
{
    interface IQRScanningService
    {
        Task<string> ScanAsync();
    }
}
