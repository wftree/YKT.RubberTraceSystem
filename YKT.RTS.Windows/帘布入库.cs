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

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 帘布入库 : BaseForm
    {
        public 帘布入库()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string typeno = "";
            if (!CheckInput(tbTypeNo, "请输入橡胶牌号", ref typeno))
            {
                return;
            }
            string fabric = "";
            if (!CheckInput(tbFabricType, "请输入帘布代号", ref fabric))
            {
                return;
            }
            string length = "";
            float dlength;
            if (!CheckInput(tbLength, "请输入长度", ref length))
            {
                
                return;
            }
            try
            {
                dlength = Convert.ToSingle(length);
            }
            catch (Exception)
            {
                MessageBox.Show("长度输入无效");
                return;
            }
            string sno = "";
            float dsno;
            if (!CheckInput(tbSerialNo, "请输入批次号", ref sno))
            {
                return;
            }
            try
            {
                dsno = Convert.ToSingle(sno);
            }
            catch (Exception)
            {
                MessageBox.Show("生产序号输入无效");
                return;
            }
            float weight = 0;
            if (!CheckInput(tbWeight, "请输入重量", ref weight))
            {
                return;
            }
            Data.帘布入库 temp;
            using (TransactionScope scope = new TransactionScope())
            {

                temp = new Data.帘布入库();
                temp.Id = Guid.NewGuid();
                temp.胶料 = typeno;
                temp.帘布代号 = fabric;
                temp.帘布长度 = dlength;
                temp.生产日期 = dtpPDate.Value;
                temp.有效日期 = dtpVDate.Value;
                temp.生产序号 = dsno;
                temp.重量 = weight;
                temp.出库时间 = DateTime.Now;
                temp.登记时间 = DateTime.Now;
                ddc.帘布入库s.InsertOnSubmit(temp);

                ddc.SubmitChanges();
                scope.Complete();
            }
            if (DialogResult.Yes == MessageBox.Show("你需要立即打印吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();

                if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FI, temp.Id.ToString()), temp.帘布代号 + temp.生产日期.Date.ToShortDateString()))
                {
                    MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            LoadData();
        }

        private void 帘布入库_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.帘布入库s where m.删除 == false && m.消耗结束==false orderby m.登记时间 select m;
            this.帘布入库BindingSource.DataSource = users;
        }

        private void dgFabircInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFabircInventory.SelectedRows.Count > 0)
            {
                Data.帘布入库 temp = ddc.帘布入库s.Single(x => x.Id == new Guid(dgFabircInventory.SelectedRows[0].Cells[0].Value.ToString()) && x.删除 == false);
                tbTypeNo.Text = temp.胶料;
                tbFabricType.Text = temp.帘布代号;
                tbLength.Text = temp.帘布长度.ToString();
                dtpPDate.Value = temp.生产日期;
                dtpVDate.Value = temp.有效日期;
                tbSerialNo.Text = temp.生产序号.ToString();
                tbWeight.Text = temp.重量.ToString();
                checkBox1.Checked = temp.删除;
                pictureBox1.Image = CreateQRCode(TableType.FI, dgFabircInventory.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string typeno = "";
            if (!CheckInput(tbTypeNo, "请输入橡胶牌号", ref typeno))
            {
                return;
            }
            string fabric = "";
            if (!CheckInput(tbFabricType, "请输入帘布代号", ref fabric))
            {
                return;
            }
            string length = "";
            float dlength;
            if (!CheckInput(tbLength, "请输入长度", ref length))
            {

                return;
            }
            try
            {
                dlength = Convert.ToSingle(length);
            }
            catch (Exception)
            {
                MessageBox.Show("长度输入无效");
                return;
            }
            string sno = "";
            float dsno;
            if (!CheckInput(tbSerialNo, "请输入批次号", ref sno))
            {
                return;
            }
            try
            {
                dsno = Convert.ToSingle(sno);
            }
            catch (Exception)
            {
                MessageBox.Show("生产序号输入无效");
                return;
            }
            float weight = 0;
            if (!CheckInput(tbWeight, "请输入重量", ref weight))
            {
                return;
            }
            Data.帘布入库 temp;
            using (TransactionScope scope = new TransactionScope())
            {

                temp = ddc.帘布入库s.Single(x => x.Id == new Guid(dgFabircInventory.SelectedRows[0].Cells[0].Value.ToString()) && x.删除 == false);
                temp.胶料 = typeno;
                temp.帘布代号 = fabric;
                temp.帘布长度 = dlength;
                temp.生产日期 = dtpPDate.Value;
                temp.有效日期 = dtpVDate.Value;
                temp.生产序号 = dsno;
                temp.重量 = weight;
                temp.登记时间 = DateTime.Now;
                temp.删除 = checkBox1.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            if (DialogResult.Yes == MessageBox.Show("你需要立即打印吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();

                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FI, temp.Id.ToString()),temp.帘布代号+temp.生产日期.Date.ToShortDateString()))
                    {
                        MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                
            }
            LoadData();
        }

        private void btnStaffPrintQR_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FI, dgFabircInventory.SelectedRows[0].Cells[0].Value.ToString()), dgFabircInventory.SelectedRows[0].Cells[1].Value.ToString() + Convert.ToDateTime(dgFabircInventory.SelectedRows[0].Cells[5].Value).ToShortDateString()))
            {
                MessageBox.Show("打印错误，请检查打印机", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
