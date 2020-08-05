using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Utilizities;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 成型码生成 : BaseForm
    {
        public 成型码生成()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cbTypeNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入产品型号");
                return;
            }
            int num =0;
            if (!CheckInput(tbNum, "请输入要生成的数量", ref num))
            {
                return;
            }
            float outrubberconsume=0;
            if (!CheckInput(tbOutRubberConsume, "请输入要消耗的外层胶数量", ref outrubberconsume))
            {
                return;
            }
            float innerrubberconsume =0;
            if (!CheckInput(tbInnerRubberConsume, "请输入要消耗的内层胶数量", ref innerrubberconsume))
            {
                return;
            }
            float fabricconsume =0;
            if (!CheckInput(tbFabricConsume, "请输入要消耗的帘布数量", ref fabricconsume))
            {
                return;
            }
            if (dgOutRubber.SelectedRows.Count<0)
            {
                MessageBox.Show("请选择胶料");
                return;
            }
            if (dgFabric.SelectedRows.Count < 0)
            {
                MessageBox.Show("请选择帘布卷");
                return;
            }
            
            List<string> all = new List<string>();
            using (TransactionScope scope = new TransactionScope())
            {
                产品消耗 consume = null;
                if(cbTypeNo.SelectedValue == null)
                {
                    consume = null;
                    consume = new 产品消耗();
                    consume.Id = Guid.NewGuid();
                    consume.产品名称 = cbTypeNo.Text;
                    consume.内层胶消耗量 = innerrubberconsume;
                    consume.外层胶消耗量 = outrubberconsume;
                    consume.帘布消耗量 = fabricconsume;
                    consume.加入日期 = DateTime.Now;
                    ddc.产品消耗s.InsertOnSubmit(consume);
                }
                
                if (cbTypeNo.SelectedValue != null)
                {
                    consume = ddc.产品消耗s.First(x => x.Id == new Guid(cbTypeNo.SelectedValue.ToString()));
                    consume.内层胶消耗量 = innerrubberconsume;
                    consume.外层胶消耗量 = outrubberconsume;
                    consume.帘布消耗量 = fabricconsume;
                }
                for (int i = 0; i < num; i++)
                {
                    皮囊成型 temp = new 皮囊成型();
                    temp.Id = Guid.NewGuid();
                    temp.产品型号 = cbTypeNo.Text;
                    temp.外胶片批号 = new Guid(dgOutRubber.SelectedRows[0].Cells[0].Value.ToString());
                    temp.帘布批号 = new Guid(this.dgFabric.SelectedRows[0].Cells[0].Value.ToString());
                    temp.内胶片批号 = new Guid(dgInnerRubber.SelectedRows[0].Cells[0].Value.ToString());
                    temp.产品消耗 = consume.Id;
                    temp.登记时间 = DateTime.Now;
                    ddc.皮囊成型s.InsertOnSubmit(temp);
                    

                    HashTable hash = new HashTable();
                    hash.Id = temp.Id;
                    hash.Table = "NP";
                    hash.Hash = Utilizity.GetCRC32Str(temp.Id.ToString());
                    ddc.HashTables.InsertOnSubmit(hash);
                    all.Add(hash.Hash);
                }
                ddc.SubmitChanges();
                scope.Complete();
                
                
                
            }
            //LoadData();
            //打印二维码
            if (DialogResult.Yes == MessageBox.Show("你需要立即打印吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
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
            LoadData();
        }
        
        private void 成型码生成_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var rubberchips = from m in ddc.橡胶薄片s where m.删除 == false && m.消耗结束==false select m;
            外橡胶薄片BindingSource.DataSource = rubberchips;
            var farbic = from m in ddc.帘布流转s where m.删除 == false && m.消耗结束==false select m;
            帘布流转BindingSource.DataSource = farbic;
            var innerrubberchips = from m in ddc.橡胶薄片s where m.删除 == false && m.消耗结束==false select m;
            内橡胶薄片BindingSource.DataSource = innerrubberchips;
            var consume = from m in ddc.产品消耗s orderby m.加入日期 select m;
            产品消耗BindingSource.DataSource = consume;
        }
        //private DateTime _dt = DateTime.Now;  //定义一个成员函数用于保存每次的时间点
        //string ScanResult = "";
        private void 成型码生成_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //DateTime tempDt = DateTime.Now;          //保存按键按下时刻的时间点           

            //TimeSpan ts = tempDt.Subtract(_dt);     //获取时间间隔           
            ////判断时间间隔  
            //if (ts.Milliseconds < 50)
            //{
            //    ScanResult += e.KeyChar;
            //    e.Handled = true;

            //}
            //else if (ScanResult == "")
            //{
            //    ScanResult += e.KeyChar;
            //}
            ////textBox1.Text = "";           
            //_dt = tempDt;
        }

        private void tbOutRubber_TextChanged(object sender, EventArgs e)
        {
            
            if (tbOutRubber.Text.Length > 38)
            {
                string temp = tbOutRubber.Text;
                if (!temp.StartsWith(TableType.RC.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbOutRubber.Focus();
                    tbOutRubber.Text = "";
                    return;
                }
                tbOutRubber.Text = Utilizity.DecodeQRCode(temp).ToString();
                SetGridViewSelected(dgOutRubber, tbOutRubber.Text);
            }
        }

        private void tbInnerRubber_TextChanged(object sender, EventArgs e)
        {
            
            
            if (tbInnerRubber.Text.Length>38)
            {
                string temp = tbInnerRubber.Text;
                if (!temp.StartsWith(TableType.RC.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbInnerRubber.Focus();
                    tbInnerRubber.Text = "";
                    return;
                }
                tbInnerRubber.Text = Utilizity.DecodeQRCode(temp).ToString();
                SetGridViewSelected(dgInnerRubber, tbInnerRubber.Text);
            }
            
        }

        private void tbFabric_TextChanged(object sender, EventArgs e)
        {
            if (tbFabric.Text.Length > 38)
            {
                string temp = tbFabric.Text;
                if (!temp.StartsWith(TableType.FC.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbFabric.Focus();
                    tbFabric.Text = "";
                    return;
                }
                tbFabric.Text = Utilizity.DecodeQRCode(temp).ToString();
                SetGridViewSelected(dgFabric, tbFabric.Text);
            }

        }

        private void dgInnerRubber_SelectionChanged(object sender, EventArgs e)
        {
            if (dgInnerRubber.SelectedRows.Count > 0)
            {
                this.tbInnerRubber.Text = dgInnerRubber.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgFabric_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFabric.SelectedRows.Count > 0)
            {
                this.tbFabric.Text = dgFabric.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgOutRubber_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOutRubber.SelectedRows.Count > 0)
            {
                this.tbOutRubber.Text = dgOutRubber.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbTypeNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            产品消耗 consume = null;
            consume = ddc.产品消耗s.First(x => x.Id == new Guid(cbTypeNo.SelectedValue.ToString()));
            tbInnerRubberConsume.Text = consume.内层胶消耗量.ToString();
            tbOutRubberConsume.Text = consume.外层胶消耗量.ToString();
            tbFabricConsume.Text = consume.帘布消耗量.ToString();
        }
    }
}
