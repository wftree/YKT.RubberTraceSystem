using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilizities;
using YKT.RubberTraceSystem.Data;

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
                List<string> all = new List<string>();
                //打印二维码
                foreach (DataGridViewRow item in dgProductCodes.SelectedRows)
                {
                    HashTable ht = ddc.HashTables.First(x => x.Id == new Guid(item.Cells[0].Value.ToString()));
                    all.Add(ht.Hash);
                }
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();

                List<List<string>> ArrayList = all.Select((x, i) => new { Index = i, Value = x }).GroupBy(x => x.Index / 3).Select(x => x.Select(v => v.Value).ToList()).ToList();

                foreach (var items in ArrayList)
                {
                    string[] datas = new string[items.Count];
                    for (int i = 0; i < items.Count; i++)
                    {
                        datas[i] = Utilizity.CreateQRCodeStr(TableType.NP, items[0].ToString());
                    }

                    if (!printer.PrintQRCode(datas))
                    {
                        MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
