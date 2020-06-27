using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilizities;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class BaseForm : Form
    {
        public static Bitmap CreateQRCode(string value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
        public static Bitmap CreateQRCode(TableType type, string value)
        {

            return CreateQRCode(type.ToString() + ":" + value);
        }
        public string GetValue(object value)
        {
            return value == null ? "" : value.ToString();
        }
        public DataDataContext ddc = new DataDataContext();
        public BaseForm()
        {
            InitializeComponent();
        }
        protected bool CheckInput(TextBox tb,string message, ref float num)
        {
            if (tb.Text.Trim() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            try
            {
                num = Convert.ToSingle(tb.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确数字");
                return false;
            }
            return true;
        }

        protected bool CheckInput(TextBox tb, string message, ref int num)
        {
            if (tb.Text.Trim() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            try
            {
                num = Convert.ToInt32(tb.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确数字");
                return false;
            }
            return true;
        }

        protected bool CheckInput(TextBox tb, string message, ref Guid id)
        {
            if (tb.Text.Trim() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            try
            {

                Guid? temp = Utilizity.DecodeQRCode(tb.Text);
                if(id == null)
                {
                    return false;
                }
                else
                {
                    id = (Guid)temp;
                }
            }
            catch
            {
                MessageBox.Show("请输入32位代码");
                return false;
            }
            return true;
        }

        protected bool CheckInput(TextBox tb, string message, ref string str)
        {
            if (tb.Text.Trim() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            str = tb.Text.Trim();
            return true;
        }

        protected bool CheckInput(MaskedTextBox tb, string message, ref string str)
        {
            if (tb.Text.Trim() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            str = tb.Text.Trim();
            return true;
        }
    }
}
