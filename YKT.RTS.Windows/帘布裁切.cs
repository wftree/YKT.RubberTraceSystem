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
    public partial class 帘布裁切 : BaseForm
    {
        //private ScanerHook listener = new ScanerHook();
        public 帘布裁切()
        {
            InitializeComponent();
            //listener.ScanerEvent += Listener_ScanerEvent; ;
        }
        private void Listener_ScanerEvent(ScanerHook.ScanerCodes codes)
        {
            string temp = codes.Result;
            if (!temp.StartsWith(TableType.FI.ToString()))
            {
                MessageBox.Show("错误代码。请检查后输入");
                return;
            }
            tbTypeNo.Text = Utilizity.DecodeQRCode(temp).ToString();
            SetGridViewSelected(dgFabric, tbTypeNo.Text);
            //dgOutRubber_SelectionChanged(null, null);
        }
        private void 帘布裁切_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.帘布入库s where m.删除 == false && m.消耗结束==false select m;
            this.帘布入库BindingSource.DataSource = users;
        }
        private void dgFabric_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFabric.SelectedRows.Count > 0)
            {
                tbTypeNo.Text = dgFabric.SelectedRows[0].Cells[0].Value.ToString();
                var temp = from m in ddc.帘布流转s where m.删除 == false && m.消耗结束 == false && m.帘布批号 == new Guid(tbTypeNo.Text) select m;
                帘布流转BindingSource.DataSource = temp;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Guid typeno = new Guid();
            if (!CheckInput(tbTypeNo, "请输入帘布批号", ref typeno))
            {
                return;
            }
            int counter = 0;
            if (!CheckInput(tbCounter, "请输入要生成标签数量", ref counter))
            {
                return;
            }
            float width = 0;
            if (!CheckInput(tbWidth, "请输入要生成帘布宽度", ref width))
            {
                return;
            }
            float thick = 0;
            if (!CheckInput(tbThick, "请输入要生成帘布厚度", ref thick))
            {
                return;
            }
            float num = 0;
            if (!CheckInput(tbNum, "请输入要生成每卷帘布长度", ref num))
            {
                return;
            }
            float consume = 0;
            if (!CheckInput(tbConsume, "请输入要生成每卷帘布消耗的数量", ref consume))
            {
                return;
            }
            float ang = 0;
            if (!CheckInput(tbAng, "请输入要生成帘布角度", ref ang))
            {
                return;
            }
            string pno = "";
            if(!CheckInput(tbPNo,"请输入对应产品型号",ref pno))
            {
                return;
            }
            List<帘布流转> all = new List<帘布流转>();
            using (TransactionScope scope = new TransactionScope())
            {
                for (int i = 0; i < counter; i++)
                {
                    帘布流转 temp = new 帘布流转();
                    temp.Id = Guid.NewGuid();
                    temp.帘布批号 = typeno;
                    temp.厚度 = thick;
                    temp.宽度 = width;
                    temp.角度 = ang;
                    temp.数量 = num;
                    temp.消耗数量 = consume;
                    temp.产品编号 = pno;
                    temp.使用期限 = DateTime.Now.AddDays(5);
                    temp.登记时间 = DateTime.Now;
                    temp.出库时间 = DateTime.Now;
                    temp.生产时间 = DateTime.Now;
                    ddc.帘布流转s.InsertOnSubmit(temp);
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

                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FC, item.Id.ToString()),item.产品编号+item.登记时间.ToShortDateString()))
                    {
                        MessageBox.Show("打印错误，请重新生成帘布代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            dgFabric_SelectionChanged(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            //打印二维码
            foreach (DataGridViewRow item in dgFabricCut.SelectedRows)
            {

                if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FC, item.Cells[0].Value.ToString()),item.Cells[1].Value.ToString()+Convert.ToDateTime(item.Cells[5].Value).ToShortDateString()))
                {
                    MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void 帘布裁切_Activated(object sender, EventArgs e)
        {
            //listener.Start();
        }

        private void 帘布裁切_Deactivate(object sender, EventArgs e)
        {
            //listener.Stop();
        }

        private void 帘布裁切_FormClosing(object sender, FormClosingEventArgs e)
        {
            //listener.Stop();
        }

        private void tbTypeNo_TextChanged(object sender, EventArgs e)
        {
            if (tbTypeNo.Text.Length > 38)
            {
                string temp = tbTypeNo.Text;
                if (!temp.StartsWith(TableType.FI.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbTypeNo.Focus();
                    tbTypeNo.Text = "";
                    return;
                }
                tbTypeNo.Text = Utilizity.DecodeQRCode(temp).ToString();
                SetGridViewSelected(dgFabric, tbTypeNo.Text);
            }
        }

        private void dgFabricCut_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFabricCut.SelectedRows.Count > 0)
            {
                this.tbPNo.Text = dgFabricCut.SelectedRows[0].Cells[1].Value.ToString();
                this.tbThick.Text = dgFabricCut.SelectedRows[0].Cells[3].Value.ToString();
                this.tbWidth.Text = dgFabricCut.SelectedRows[0].Cells[2].Value.ToString();
                this.tbAng.Text = dgFabricCut.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                this.tbPNo.Text = "";
                this.tbThick.Text = "";
                this.tbWidth.Text = "";
                this.tbAng.Text = "";
            }
        }
    }
}
