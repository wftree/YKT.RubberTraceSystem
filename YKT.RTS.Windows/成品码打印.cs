using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilizities;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 成品码打印 : BaseForm
    {
        public 成品码打印()
        {
            InitializeComponent();
        }

        private void 成品码打印_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var temp = from m in ddc.皮囊成型s where m.删除 == false && m.登记时间.Date == dateTimePicker1.Value.Date && m.产品型号 == comboBox1.SelectedText select m;
            皮囊成型BindingSource.DataSource = temp;

            var temp2 = (from m in ddc.皮囊成型s where m.删除 == false select m.产品型号).Distinct();
            comboBox1.DataSource = temp2;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgProductCodes.SelectedRows.Count > 0)
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                //打印二维码
                foreach (DataGridViewRow item in dgProductCodes.SelectedRows)
                {

                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.NP, item.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("打印错误，请重新打印", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var temp = from m in ddc.皮囊成型s where m.删除 == false && m.登记时间.Date == dateTimePicker1.Value.Date && m.产品型号 == comboBox1.Text select m;
            皮囊成型BindingSource.DataSource = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = from m in ddc.皮囊成型s where m.删除 == false && m.登记时间.Date == dateTimePicker1.Value.Date && m.产品型号 == comboBox1.Text select m;
            皮囊成型BindingSource.DataSource = temp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = from m in ddc.皮囊成型s where m.删除 == false && m.登记时间.Date == dateTimePicker1.Value.Date && m.产品型号==comboBox1.Text select m;//
            皮囊成型BindingSource.DataSource = temp;
        }
    }
}
