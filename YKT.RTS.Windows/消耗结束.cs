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

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 消耗结束 : BaseForm
    {
        public 消耗结束()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTypeNo.Text.Length > 38)
                {
                    if (DialogResult.Yes == MessageBox.Show("是否确定已经消耗结束？", "注意", MessageBoxButtons.YesNo))
                    {
                        string temp = tbTypeNo.Text;
                        if (temp.StartsWith(TableType.FI.ToString()))
                        {
                            var m = ddc.帘布入库s.First(x => x.Id == Utilizity.DecodeQRCode(temp));
                            m.消耗结束 = true;
                        }
                        if (temp.StartsWith(TableType.RI.ToString()))
                        {
                            var m = ddc.胶料入库s.First(x => x.Id == Utilizity.DecodeQRCode(temp));
                            m.消耗结束 = true;

                        }
                        if (temp.StartsWith(TableType.RC.ToString()))
                        {
                            var m = ddc.橡胶薄片s.First(x => x.Id == Utilizity.DecodeQRCode(temp));
                            m.消耗结束 = true;

                        }
                        if (temp.StartsWith(TableType.FC.ToString()))
                        {
                            var m = ddc.帘布流转s.First(x => x.Id == Utilizity.DecodeQRCode(temp));
                            m.消耗结束 = true;
                        }
                        ddc.SubmitChanges();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("输入错误");
            }
            
        }

        private void tbTypeNo_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
