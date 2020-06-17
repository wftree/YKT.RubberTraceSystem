using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKT.RubberTraceSystem.Data
{
    public class Utilizity
    {
        public static Bitmap  CreateQRCode(string value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
        public static Bitmap CreateQRCode(TableType type, string value)
        {
            
            return CreateQRCode(type.ToString()+":"+value);
        }
        public static Guid? DecodeQRCode(string qr)
        {
            string[] temp = qr.Split(new char[1] { ':' });
            if(temp.Length>2)
            {
                return new Guid(temp[1]);
            }
            else
            {
                return null;
            }
        }

        public static TableType? GetTableType(string qr)
        {
            string[] temp = qr.Split(new char[1] { ':' });
            if (temp.Length > 2)
            {
                return (TableType)Enum.Parse(typeof(TableType), temp[0]);
            }
            else
            {
                return null;
            }
        }
    }
    /// <summary>
    /// 表类别
    /// </summary>
    public enum TableType
    {
        /// <summary>
        /// 用户
        /// </summary>
        UR,
        /// <summary>
        /// 机台
        /// </summary>
        MC,
        /// <summary>
        /// 橡胶库存
        /// </summary>
       RI,
       /// <summary>
       /// 帘布库存
       /// </summary>
       FI,
       /// <summary>
       /// 胶片
       /// </summary>
       RC,
       /// <summary>
       /// 帘布片
       /// </summary>
       FC,
       /// <summary>
       /// 未硫化成品
       /// </summary>
       NP,
       /// <summary>
       /// 硫化成品
       /// </summary>
       CP,
       /// <summary>
       /// 检验产品
       /// </summary>
       CC
    }
}
