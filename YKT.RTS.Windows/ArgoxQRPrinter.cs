using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YKT.RubberTraceSystem.Windows.Properties;

namespace YKT.RubberTraceSystem.Windows
{
    public class ArgoxQRPrinter: IQRPrinter
    {
        const uint IMAGE_BITMAP = 0;
        const uint LR_LOADFROMFILE = 16;
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr LoadImage(IntPtr hinst, string lpszName, uint uType,
           int cxDesired, int cyDesired, uint fuLoad);
        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int DeleteObject(IntPtr ho);
        const string szSavePath = "C:\\Argox";
        const string szSaveFile = "C:\\Argox\\PPLB_Example.Prn";
        const string sznop1 = "nop_front\r\n";
        const string sznop2 = "nop_middle\r\n";
        [DllImport("Winpplb.dll")]
        private static extern int B_Bar2d_Maxi(int x, int y, int cl, int cc, int pc, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Bar2d_PDF417(int x, int y, int w, int v, int s, int c, int px,
            int py, int r, int l, int t, int o, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Bar2d_PDF417_N(int x, int y, int w, int h, string pParameter, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Bar2d_DataMatrix(int x, int y, int r, int l, int h, int v, string data);
        [DllImport("Winpplb.dll")]
        private static extern void B_ClosePrn();
        [DllImport("Winpplb.dll")]
        private static extern int B_CreatePrn(int selection, string filename);
        [DllImport("Winpplb.dll")]
        private static extern int B_Del_Form(string formname);
        [DllImport("Winpplb.dll")]
        private static extern int B_Del_Pcx(string pcxname);
        [DllImport("Winpplb.dll")]
        private static extern int B_Draw_Box(int x, int y, int thickness, int hor_dots,
            int ver_dots);
        [DllImport("Winpplb.dll")]
        private static extern int B_Draw_Line(char mode, int x, int y, int hor_dots, int ver_dots);
        [DllImport("Winpplb.dll")]
        private static extern int B_Error_Reporting(char option);
        [DllImport("Winpplb.dll")]
        private static extern IntPtr B_Get_DLL_Version(int nShowMessage);
        [DllImport("Winpplb.dll")]
        private static extern int B_Get_DLL_VersionA(int nShowMessage);
        [DllImport("Winpplb.dll")]
        private static extern int B_Get_Graphic_ColorBMP(int x, int y, string filename);
        [DllImport("Winpplb.dll")]
        private static extern int B_Get_Graphic_ColorBMPEx(int x, int y, int nWidth, int nHeight,
            int rotate, string id_name, string filename);
        [DllImport("Winpplb.dll")]
        private static extern int B_Get_Graphic_ColorBMP_HBitmap(int x, int y, int nWidth, int nHeight,
           int rotate, string id_name, IntPtr hbm);
        [DllImport("Winpplb.dll")]
        private static extern int B_Get_Pcx(int x, int y, string filename);
        [DllImport("Winpplb.dll")]
        private static extern int B_Initial_Setting(int Type, string Source);
        [DllImport("Winpplb.dll")]
        private static extern int B_WriteData(int IsImmediate, byte[] pbuf, int length);
        [DllImport("Winpplb.dll")]
        private static extern int B_ReadData(byte[] pbuf, int length, int dwTimeoutms);
        [DllImport("Winpplb.dll")]
        private static extern int B_Load_Pcx(int x, int y, string pcxname);
        [DllImport("Winpplb.dll")]
        private static extern int B_Open_ChineseFont(string path);
        [DllImport("Winpplb.dll")]
        private static extern int B_Print_Form(int labset, int copies, string form_out, string var);
        [DllImport("Winpplb.dll")]
        private static extern int B_Print_MCopy(int labset, int copies);
        [DllImport("Winpplb.dll")]
        private static extern int B_Print_Out(int labset);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Barcode(int x, int y, int ori, string type, int narrow,
            int width, int height, char human, string data);
        [DllImport("Winpplb.dll")]
        private static extern void B_Prn_Configuration();
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text(int x, int y, int ori, int font, int hor_factor,
            int ver_factor, char mode, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text_Chinese(int x, int y, int fonttype, string id_name,
            string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text_TrueType(int x, int y, int FSize, string FType,
            int Fspin, int FWeight, int FItalic, int FUnline, int FStrikeOut, string id_name,
            string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text_TrueType_W(int x, int y, int FHeight, int FWidth,
            string FType, int Fspin, int FWeight, int FItalic, int FUnline, int FStrikeOut,
            string id_name, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_Select_Option(int option);
        [DllImport("Winpplb.dll")]
        private static extern int B_Select_Option2(int option, int p);
        [DllImport("Winpplb.dll")]
        private static extern int B_Select_Symbol(int num_bit, int symbol, int country);
        [DllImport("Winpplb.dll")]
        private static extern int B_Select_Symbol2(int num_bit, string csymbol, int country);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Backfeed(char option);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Backfeed_Offset(int offset);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_CutPeel_Offset(int offset);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_BMPSave(int nSave, string strBMPFName);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Darkness(int darkness);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_DebugDialog(int nEnable);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Direction(char direction);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Form(string formfile);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Labgap(int lablength, int gaplength);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Labwidth(int labwidth);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Originpoint(int hor, int ver);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Prncomport(int baud, char parity, int data, int stop);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Prncomport_PC(int nBaudRate, int nByteSize, int nParity,
            int nStopBits, int nDsr, int nCts, int nXonXoff);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_Speed(int speed);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_ProcessDlg(int nShow);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_ErrorDlg(int nShow);
        [DllImport("Winpplb.dll")]
        private static extern int B_GetUSBBufferLen();
        [DllImport("Winpplb.dll")]
        private static extern int B_EnumUSB(byte[] buf);
        [DllImport("Winpplb.dll")]
        private static extern int B_CreateUSBPort(int nPort);
        [DllImport("Winpplb.dll")]
        private static extern int B_ResetPrinter();
        [DllImport("Winpplb.dll")]
        private static extern int B_GetPrinterResponse(byte[] buf, int nMax);
        [DllImport("Winpplb.dll")]
        private static extern int B_TFeedMode(int nMode);
        [DllImport("Winpplb.dll")]
        private static extern int B_TFeedTest();
        [DllImport("Winpplb.dll")]
        private static extern int B_CreatePort(int nPortType, int nPort, string filename);
        [DllImport("Winpplb.dll")]
        private static extern int B_Execute_Form(string form_out, string var);
        [DllImport("Winpplb.dll")]
        private static extern int B_Bar2d_QR(int x, int y, int model, int scl, char error,
            char dinput, int c, int d, int p, string data);
        [DllImport("Winpplb.dll")]
        private static extern int B_GetNetPrinterBufferLen();
        [DllImport("Winpplb.dll")]
        private static extern int B_EnumNetPrinter(byte[] buf);
        [DllImport("Winpplb.dll")]
        private static extern int B_CreateNetPort(int nPort);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text_TrueType_Uni(int x, int y, int FSize, string FType,
            int Fspin, int FWeight, int FItalic, int FUnline, int FStrikeOut, string id_name,
            byte[] data, int format);
        [DllImport("Winpplb.dll")]
        private static extern int B_Prn_Text_TrueType_UniB(int x, int y, int FSize, string FType,
            int Fspin, int FWeight, int FItalic, int FUnline, int FStrikeOut, string id_name,
            byte[] data, int format);
        [DllImport("Winpplb.dll")]
        private static extern int B_GetUSBDeviceInfo(int nPort, byte[] pDeviceName,
            out int pDeviceNameLen, byte[] pDevicePath, out int pDevicePathLen);
        [DllImport("Winpplb.dll")]
        private static extern int B_Set_EncryptionKey(string encryptionKey);
        [DllImport("Winpplb.dll")]
        private static extern int B_Check_EncryptionKey(string decodeKey, string encryptionKey,
            int dwTimeoutms);

        public bool PrintQRCode(int x, int y, int scarl, string data,string data1)
        {
            // open port.
            int nLen, ret, sw;
            byte[] pbuf = new byte[128];
            string strmsg;
            IntPtr ver;
            System.Text.Encoding encAscII = System.Text.Encoding.ASCII;
            System.Text.Encoding encUnicode = System.Text.Encoding.Unicode;

            // dll version.
            ver = B_Get_DLL_Version(0);

            // search port.
            nLen = B_GetUSBBufferLen() + 1;
            strmsg = "DLL ";
            strmsg += Marshal.PtrToStringAnsi(ver);
            strmsg += "\r\n";
            if (nLen > 1)
            {
                byte[] buf1, buf2;
                int len1 = 128, len2 = 128;
                buf1 = new byte[len1];
                buf2 = new byte[len2];
                B_EnumUSB(pbuf);
                B_GetUSBDeviceInfo(1, buf1, out len1, buf2, out len2);
                sw = 1;
                if (1 == sw)
                {
                    ret = B_CreatePrn(12, encAscII.GetString(buf2, 0, len2));// open usb.
                }
                else
                {
                    ret = B_CreateUSBPort(1);// must call B_GetUSBBufferLen() function fisrt.
                }
                if (0 != ret)
                {
                    strmsg += "Open USB fail!";
                }
                else
                {
                    strmsg += "Open USB:\r\nDevice name: ";
                    strmsg += encAscII.GetString(buf1, 0, len1);
                    strmsg += "\r\nDevice path: ";
                    strmsg += encAscII.GetString(buf2, 0, len2);
                    //sw = 2;
                    if (2 == sw)
                    {
                        //Immediate Error Report.
                        B_WriteData(1, encAscII.GetBytes("^ee\r\n"), 5);//^ee
                        ret = B_ReadData(pbuf, 4, 1000);
                    }
                }
            }
            else
            {
                //System.IO.Directory.CreateDirectory(szSavePath);
                //ret = B_CreatePrn(0, szSaveFile);// open file.
                //strmsg += "Open ";
                //strmsg += szSaveFile;
                //if (0 != ret)
                //{
                //    strmsg += " file fail!";
                //}
                //else
                //{
                //    strmsg += " file succeed!";
                //}
                return false;
            }
            //MessageBox.Show(strmsg);
            if (0 != ret)
                return false;

            // sample setting.
            B_Set_DebugDialog(1);
            B_Set_Originpoint(0, 0);
            B_Select_Option(2);
            B_Set_Darkness(8);
            B_Del_Pcx("*");// delete all picture.
            B_WriteData(0, encAscII.GetBytes(sznop2), sznop2.Length);
            B_WriteData(1, encAscII.GetBytes(sznop1), sznop1.Length);

            ////draw box.
            //B_Draw_Box(20, 20, 4, 760, 560);
            //B_Draw_Line('O', 400, 20, 4, 540);

            ////print text, true type text.
            B_Prn_Text(x, y+scarl*50, 0, 3, 1, 2, 'N', data);
            B_Prn_Text(x + 40 + scarl * 30, y + scarl * 10, 0, 3, 2, 2, 'N', data1);
            //B_Prn_Text_TrueType(30,100,30,"Arial",1,400,0,0,0,"AA","TrueType Font");//save in printer.
            //B_Prn_Text_TrueType_W(30,160,20,20,"Times New Roman",1,400,0,0,0,"AB","TT_W: 多字元測試");
            //B_Prn_Text_TrueType_Uni(30,220,30,"Times New Roman",1,400,0,0,0,"AC",Encoding.Unicode.GetBytes("TT_Uni: 多字元測試"),1);//UTF-16
            //   encUnicode.GetBytes("\xFEFF", 0, 1, pbuf, 0);//UTF-16.//pbuf[0]=0xFF,pbuf[1]=0xFE;
            //   encUnicode.GetBytes("TT_UniB: 多字元測試", 0, 14, pbuf, 2);//copy mutil byte.
            //   encUnicode.GetBytes("\x0000", 0, 1, pbuf, 30);//null.//pbuf[30]=0x00,pbuf[31]=0x00;
            //B_Prn_Text_TrueType_UniB(30,280,30,"Times New Roman",1,400,0,0,0,"AD",pbuf,0);//Byte Order Mark.

            //barcode.
            //B_Prn_Barcode(80, 20, 0, "3", 2, 3, 40, 'B', "1234<+1>");//have a counter
            B_Bar2d_QR(x, y, 2, scarl, 'H', 'A', 0, 0, 0, data);

            ////picture.
            //   B_Get_Graphic_ColorBMP(420, 280, "bb.bmp");// Color bmp file.
            //   B_Get_Graphic_ColorBMPEx(420, 320, 200, 150, 2, "bb1", "bb.bmp");//180 angle.
            //   IntPtr himage = LoadImage(IntPtr.Zero, "bb.bmp", IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE);
            //   B_Get_Graphic_ColorBMP_HBitmap(630, 280, 250, 80, 1, "bb2", himage);//90 angle.
            //   if (IntPtr.Zero != himage)
            //       DeleteObject(himage);

            // output.
            B_Print_Out(1);// copy 2.

            // close port.
            B_ClosePrn();

            return true;
        }

        public bool PrintQRCode(int x, int y, int scarl, string data)
        {
            // open port.
            int nLen, ret, sw;
            byte[] pbuf = new byte[128];
            string strmsg;
            IntPtr ver;
            System.Text.Encoding encAscII = System.Text.Encoding.ASCII;
            System.Text.Encoding encUnicode = System.Text.Encoding.Unicode;

            // dll version.
            ver = B_Get_DLL_Version(0);

            // search port.
            nLen = B_GetUSBBufferLen() + 1;
            strmsg = "DLL ";
            strmsg += Marshal.PtrToStringAnsi(ver);
            strmsg += "\r\n";
            if (nLen > 1)
            {
                byte[] buf1, buf2;
                int len1 = 128, len2 = 128;
                buf1 = new byte[len1];
                buf2 = new byte[len2];
                B_EnumUSB(pbuf);
                B_GetUSBDeviceInfo(1, buf1, out len1, buf2, out len2);
                sw = 1;
                if (1 == sw)
                {
                    ret = B_CreatePrn(12, encAscII.GetString(buf2, 0, len2));// open usb.
                }
                else
                {
                    ret = B_CreateUSBPort(1);// must call B_GetUSBBufferLen() function fisrt.
                }
                if (0 != ret)
                {
                    strmsg += "Open USB fail!";
                }
                else
                {
                    strmsg += "Open USB:\r\nDevice name: ";
                    strmsg += encAscII.GetString(buf1, 0, len1);
                    strmsg += "\r\nDevice path: ";
                    strmsg += encAscII.GetString(buf2, 0, len2);
                    //sw = 2;
                    if (2 == sw)
                    {
                        //Immediate Error Report.
                        B_WriteData(1, encAscII.GetBytes("^ee\r\n"), 5);//^ee
                        ret = B_ReadData(pbuf, 4, 1000);
                    }
                }
            }
            else
            {
                //System.IO.Directory.CreateDirectory(szSavePath);
                //ret = B_CreatePrn(0, szSaveFile);// open file.
                //strmsg += "Open ";
                //strmsg += szSaveFile;
                //if (0 != ret)
                //{
                //    strmsg += " file fail!";
                //}
                //else
                //{
                //    strmsg += " file succeed!";
                //}
                return false;
            }
            //MessageBox.Show(strmsg);
            if (0 != ret)
                return false;

            // sample setting.
            B_Set_DebugDialog(1);
            B_Set_Originpoint(0, 0);
            B_Select_Option(2);
            B_Set_Darkness(8);
            B_Del_Pcx("*");// delete all picture.
            B_WriteData(0, encAscII.GetBytes(sznop2), sznop2.Length);
            B_WriteData(1, encAscII.GetBytes(sznop1), sznop1.Length);

            ////draw box.
            //B_Draw_Box(20, 20, 4, 760, 560);
            //B_Draw_Line('O', 400, 20, 4, 540);

            ////print text, true type text.
            //B_Prn_Text(x + 15 + scarl * 30, y + scarl * 5, 0, 2, 1, 1, 'N', data);
            //B_Prn_Text(x + 15 + scarl * 30, y + scarl * 10, 0, 2, 1, 1, 'N', data1);
            //B_Prn_Text_TrueType(30,100,30,"Arial",1,400,0,0,0,"AA","TrueType Font");//save in printer.
            //B_Prn_Text_TrueType_W(30,160,20,20,"Times New Roman",1,400,0,0,0,"AB","TT_W: 多字元測試");
            //B_Prn_Text_TrueType_Uni(30,220,30,"Times New Roman",1,400,0,0,0,"AC",Encoding.Unicode.GetBytes("TT_Uni: 多字元測試"),1);//UTF-16
            //   encUnicode.GetBytes("\xFEFF", 0, 1, pbuf, 0);//UTF-16.//pbuf[0]=0xFF,pbuf[1]=0xFE;
            //   encUnicode.GetBytes("TT_UniB: 多字元測試", 0, 14, pbuf, 2);//copy mutil byte.
            //   encUnicode.GetBytes("\x0000", 0, 1, pbuf, 30);//null.//pbuf[30]=0x00,pbuf[31]=0x00;
            //B_Prn_Text_TrueType_UniB(30,280,30,"Times New Roman",1,400,0,0,0,"AD",pbuf,0);//Byte Order Mark.

            //barcode.
            //B_Prn_Barcode(80, 20, 0, "3", 2, 3, 40, 'B', "1234<+1>");//have a counter
            B_Bar2d_QR(x, y, 2, scarl, 'H', 'A', 0, 0, 0, data);

            ////picture.
            //   B_Get_Graphic_ColorBMP(420, 280, "bb.bmp");// Color bmp file.
            //   B_Get_Graphic_ColorBMPEx(420, 320, 200, 150, 2, "bb1", "bb.bmp");//180 angle.
            //   IntPtr himage = LoadImage(IntPtr.Zero, "bb.bmp", IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE);
            //   B_Get_Graphic_ColorBMP_HBitmap(630, 280, 250, 80, 1, "bb2", himage);//90 angle.
            //   if (IntPtr.Zero != himage)
            //       DeleteObject(himage);

            // output.
            B_Print_Out(1);// copy 2.

            // close port.
            B_ClosePrn();

            return true;
        }

        public bool PrintQRCode(int x, int y, int scarl,int offset, string[] data)
        {
            // open port.
            int nLen, ret, sw;
            byte[] pbuf = new byte[128];
            string strmsg;
            IntPtr ver;
            System.Text.Encoding encAscII = System.Text.Encoding.ASCII;
            System.Text.Encoding encUnicode = System.Text.Encoding.Unicode;

            // dll version.
            ver = B_Get_DLL_Version(0);

            // search port.
            nLen = B_GetUSBBufferLen() + 1;
            strmsg = "DLL ";
            strmsg += Marshal.PtrToStringAnsi(ver);
            strmsg += "\r\n";
            if (nLen > 1)
            {
                byte[] buf1, buf2;
                int len1 = 128, len2 = 128;
                buf1 = new byte[len1];
                buf2 = new byte[len2];
                B_EnumUSB(pbuf);
                B_GetUSBDeviceInfo(1, buf1, out len1, buf2, out len2);
                sw = 1;
                if (1 == sw)
                {
                    ret = B_CreatePrn(12, encAscII.GetString(buf2, 0, len2));// open usb.
                }
                else
                {
                    ret = B_CreateUSBPort(1);// must call B_GetUSBBufferLen() function fisrt.
                }
                if (0 != ret)
                {
                    strmsg += "Open USB fail!";
                }
                else
                {
                    strmsg += "Open USB:\r\nDevice name: ";
                    strmsg += encAscII.GetString(buf1, 0, len1);
                    strmsg += "\r\nDevice path: ";
                    strmsg += encAscII.GetString(buf2, 0, len2);
                    //sw = 2;
                    if (2 == sw)
                    {
                        //Immediate Error Report.
                        B_WriteData(1, encAscII.GetBytes("^ee\r\n"), 5);//^ee
                        ret = B_ReadData(pbuf, 4, 1000);
                    }
                }
            }
            else
            {
                return false;
            }
            //MessageBox.Show(strmsg);
            if (0 != ret)
                return false;

            // sample setting.
            B_Set_DebugDialog(1);
            B_Set_Originpoint(0, 0);
            B_Select_Option(2);
            B_Set_Darkness(8);
            B_Del_Pcx("*");// delete all picture.
            B_WriteData(0, encAscII.GetBytes(sznop2), sznop2.Length);
            B_WriteData(1, encAscII.GetBytes(sznop1), sznop1.Length);

            //barcode.
            //B_Prn_Barcode(80, 20, 0, "3", 2, 3, 40, 'B', "1234<+1>");//have a counter
            for (int i = 0; i < data.Length; i++)
            {
                B_Bar2d_QR(x+(i*offset), y, 2, scarl, 'H', 'A', 0, 0, 0, data[0]);

            }
            

            // output.
            B_Print_Out(1);// copy 2.

            // close port.
            B_ClosePrn();

            return true;
        }

        public bool PrintQRCode(string data)
        {
            return PrintQRCode(Settings.Default.CQRL, Settings.Default.CQRH, Settings.Default.CSCALE, data);
        }
        public bool PrintQRCode(string data,string data1)
        {
            return PrintQRCode(Settings.Default.QRL, Settings.Default.QRH, Settings.Default.SCALE, data,data1);
        }

        public bool PrintQRCode(string[] data)
        {
            return PrintQRCode(Settings.Default.CQRL, Settings.Default.CQRH, Settings.Default.CSCALE,Settings.Default.COFFSET, data);
        }
    }
}
