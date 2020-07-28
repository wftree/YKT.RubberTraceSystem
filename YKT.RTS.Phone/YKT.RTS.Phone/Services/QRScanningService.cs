using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZXing.Mobile;

namespace YKT.RubberTraceSystem.Phone.Services
{
    class QRScanningService : IQRScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();
            var mbs = MobileBarcodeScanningOptions.Default;
            mbs.AssumeGS1 = true;
            mbs.AutoRotate = true;
            mbs.DisableAutofocus = false;
            mbs.PureBarcode = false;
            mbs.TryInverted = true;
            mbs.TryHarder = true;
            mbs.UseCode39ExtendedMode = true;
            mbs.UseFrontCameraIfAvailable = false;
            mbs.UseNativeScanning = true;
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "扫描二维码",
                BottomText = "请稍后……",
            };

            var scanResult = await scanner.Scan(mbs);
            return scanResult.Text;
        }
    }
}
