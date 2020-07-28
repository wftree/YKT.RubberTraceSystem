using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Utilizities;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 胶料出片 : BaseForm
    {
        //private ScanerHook listener = new ScanerHook();
        public 胶料出片()
        {
            InitializeComponent();
            //listener.ScanerEvent += Listener_ScanerEvent; ;
        }

        private void Listener_ScanerEvent(ScanerHook.ScanerCodes codes)
        {
            string temp = codes.Result;
            if (!temp.StartsWith(TableType.RI.ToString()))
            {
                MessageBox.Show("错误代码。请检查后输入");
                return;
            }
            tbTypeNo.Text = Utilizity.DecodeQRCode(temp).ToString();
            SetGridViewSelected(dgOutRubber, tbTypeNo.Text);
            //dgOutRubber_SelectionChanged(null, null);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Guid typeno = new Guid();
            if(!CheckInput(tbTypeNo,"请输入胶料批号",ref typeno))
            {
                return;
            }
            int counter =0;
            if (!CheckInput(tbCounter, "请输入要生成标签数量", ref counter))
            {
                return;
            }
            float width = 0;
            if (!CheckInput(tbWidth, "请输入要生成胶片宽度", ref width))
            {
                return;
            }
            float thick = 0;
            if (!CheckInput(tbThick, "请输入要生成胶片厚度", ref thick))
            {
                return;
            }
            float num = 0;
            if (!CheckInput(tbNum, "请输入要生成胶片数量", ref num))
            {
                return;
            }
            float consume = 0;
            if (!CheckInput(tbNum, "请输入要生成胶片消耗数量", ref consume))
            {
                return;
            }
            List<橡胶薄片> all = new List<橡胶薄片>();
            using (TransactionScope scope = new TransactionScope())
            {
                
                for (int i = 0; i < counter; i++)
                {
                    橡胶薄片 temp = new 橡胶薄片();
                    temp.Id = Guid.NewGuid();
                    temp.胶料批号 = typeno;
                    temp.厚度 = thick;
                    temp.宽度 = width;
                    temp.数量 = num;
                    temp.消耗重量 = consume;
                    temp.生产序号 = i;
                    temp.生产时间 = DateTime.Now;
                    temp.登记时间 = DateTime.Now;
                    temp.出库时间 = DateTime.Now;
                    ddc.橡胶薄片s.InsertOnSubmit(temp);
                    all.Add(temp);
                }
                
                //if(DialogResult.Yes == MessageBox.Show("是否已经用完本垛胶料？","询问", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                //{
                //    if (DialogResult.Yes == MessageBox.Show("以用完本垛胶料将？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                //}

                ddc.SubmitChanges();
                scope.Complete();
            }
            if (DialogResult.Yes == MessageBox.Show("你需要立即打印吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                foreach (var item in all)
                {
                    var t = ddc.橡胶薄片s.Single(x => x.Id == item.Id && x.删除 == false);
                    var n = ddc.胶料入库s.Single(x => x.Id == item.胶料批号 && x.删除 == false);
                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.RC, item.Id.ToString()),n.胶料牌号+n.登记时间.ToShortDateString()))
                    {
                        MessageBox.Show("打印错误，请重新生成胶片代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            dgOutRubber_SelectionChanged(null, null);
        }

        private void dgOutRubber_SelectionChanged(object sender, EventArgs e)
        {
            if(dgOutRubber.SelectedRows.Count>0)
            {
                tbTypeNo.Text = dgOutRubber.SelectedRows[0].Cells[0].Value.ToString();
                var temp = from m in ddc.橡胶薄片s where m.删除 == false && m.消耗结束 == false && m.胶料批号 == new Guid(tbTypeNo.Text) select m;
                橡胶薄片BindingSource.DataSource = temp;

            }
        }

        private void 胶料出片_Load(object sender, EventArgs e)
        {
            LoadData();
            //listener.Start();

        }
        private void LoadData()
        {
            var users = from m in ddc.胶料入库s where m.删除 == false && m.消耗结束 == false select m;
            胶料入库BindingSource.DataSource = users;
        }

        private void 胶料出片_FormClosing(object sender, FormClosingEventArgs e)
        {
            //listener.Stop();
        }

        private void 胶料出片_Activated(object sender, EventArgs e)
        {
            //listener.Start();
        }

        private void 胶料出片_Deactivate(object sender, EventArgs e)
        {
            //listener.Stop();
        }

        private void tbTypeNo_TextChanged(object sender, EventArgs e)
        {
            if (tbTypeNo.Text.Length > 38)
            {
                string temp = tbTypeNo.Text;
                if (!temp.StartsWith(TableType.RI.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbTypeNo.Focus();
                    tbTypeNo.Text = "";
                    return;
                }
                tbTypeNo.Text = Utilizity.DecodeQRCode(temp).ToString();
                SetGridViewSelected(dgOutRubber, tbTypeNo.Text);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgRubberChips.SelectedRows.Count>0)
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                //打印二维码
                foreach (DataGridViewRow item in dgRubberChips.SelectedRows)
                {
                    var t = ddc.橡胶薄片s.Single(x => x.Id == new Guid(item.Cells[0].Value.ToString()) && x.删除 == false);
                    var n = ddc.胶料入库s.Single(x => x.Id == new Guid(item.Cells[4].Value.ToString()) && x.删除 == false);
                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.RC, t.Id.ToString()), n.胶料牌号 + n.登记时间.ToShortDateString()))
                    {
                        MessageBox.Show("打印错误，请重新生成胶片代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
            }
            
        }

        private void dgRubberChips_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRubberChips.SelectedRows.Count > 0)
            {
                this.tbThick.Text = dgRubberChips.SelectedRows[0].Cells[2].Value.ToString();
                this.tbWidth.Text = dgRubberChips.SelectedRows[0].Cells[1].Value.ToString();
                this.tbNum.Text = dgRubberChips.SelectedRows[0].Cells[3].Value.ToString();
            }
            else
            {
                this.tbThick.Text = "";
                this.tbWidth.Text = "";
                this.tbNum.Text = "";
            }
        }
        private DateTime _dt = DateTime.Now;  //定义一个成员函数用于保存每次的时间点
        private void 胶料出片_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DateTime tempDt = DateTime.Now;          //保存按键按下时刻的时间点           

            //TimeSpan ts = tempDt.Subtract(_dt);     //获取时间间隔           
            ////判断时间间隔  
            //if (ts.Milliseconds < 50)
            //    e.Handled = true;
            //    //textBox1.Text = "";           
            //_dt = tempDt;
            //e.KeyChar == keycha
        }

        private void 胶料出片_KeyDown(object sender, KeyEventArgs e)
        {
            //DateTime tempDt = DateTime.Now;          //保存按键按下时刻的时间点           

            //TimeSpan ts = tempDt.Subtract(_dt);     //获取时间间隔           
            ////判断时间间隔  
            //if (ts.Milliseconds < 50 && e.KeyCode == Keys.Enter)
            //    e.Handled = true;
        }
    }
}
