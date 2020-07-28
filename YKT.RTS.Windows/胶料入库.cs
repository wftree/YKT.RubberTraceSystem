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
    public partial class 胶料入库 : BaseForm
    {
        public 胶料入库()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string typeno ="";
            if (!CheckInput(tbTypeNo, "请输入橡胶牌号", ref typeno))
            {
                return;
            }
            string boxno = "";
            if (!CheckInput(tbBox, "请输入箱号", ref boxno))
            {
                return;
            }
            string assline = "";
            if (!CheckInput(tbAssLine, "请输入生产线号", ref assline))
            {
                return;
            }
            string sno = "";
            if (!CheckInput(tbSNo, "请输入批次号", ref sno))
            {
                return;
            }
            float weight = 0;
            if (!CheckInput(tbWeight, "请输入重量", ref weight))
            {
                return;
            }
            Data.胶料入库 temp;
            using (TransactionScope scope = new TransactionScope())
            {

                temp = new Data.胶料入库();
                temp.Id = Guid.NewGuid();
                temp.胶料牌号 = typeno;
                temp.箱号 = boxno;
                temp.生产线号 = assline;
                temp.生产日期 = dtpPDate.Value;
                temp.批次号 = sno;
                temp.重量 = weight;
                temp.供应商产品代号 = tbSupplyNo.Text;
                temp.出库时间 = DateTime.Now;
                temp.登记时间 = DateTime.Now;
                ddc.胶料入库s.InsertOnSubmit(temp);

                ddc.SubmitChanges();
                scope.Complete();
            }
            if (DialogResult.Yes == MessageBox.Show("你需要立即打印吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();

                if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.RI, temp.Id.ToString()), temp.胶料牌号 + temp.生产日期.ToShortDateString()))
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
            if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.RI, dgRubberInventory.SelectedRows[0].Cells[0].Value.ToString()),
                    dgRubberInventory.SelectedRows[0].Cells[1].Value.ToString()+ Convert.ToDateTime(dgRubberInventory.SelectedRows[0].Cells[5].Value).ToShortDateString()))
            {
                MessageBox.Show("打印错误，请检查打印机", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void 胶料入库_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.胶料入库s where m.删除 == false && m.消耗结束==false orderby m.登记时间 descending select m;
            胶料入库BindingSource.DataSource = users;
        }

        private void dgRubberInventory_SelectionChanged(object sender, EventArgs e)
        {
            //是否允许修改？？需要后定。
            if (dgRubberInventory.SelectedRows.Count > 0)
            {
                Data.胶料入库 temp = ddc.胶料入库s.Single(x => x.Id == new Guid(dgRubberInventory.SelectedRows[0].Cells[0].Value.ToString()) && x.删除 == false);
                tbTypeNo.Text = temp.胶料牌号;
                tbBox.Text = temp.箱号;
                tbAssLine.Text = temp.生产线号;
                dtpPDate.Value = temp.生产日期;
                tbSNo.Text = temp.批次号;
                tbWeight.Text = temp.重量.ToString();
                tbSupplyNo.Text = temp.供应商产品代号;
                checkBox1.Checked = temp.删除;

                pictureBox1.Image = CreateQRCode(TableType.RI, dgRubberInventory.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string typeno = "";
            if (!CheckInput(tbTypeNo, "请输入橡胶牌号", ref typeno))
            {
                return;
            }
            string boxno = "";
            if (!CheckInput(tbBox, "请输入箱号", ref boxno))
            {
                return;
            }
            string assline = "";
            if (!CheckInput(tbAssLine, "请输入生产线号", ref assline))
            {
                return;
            }
            string sno = "";
            if (!CheckInput(tbAssLine, "请输入批次号", ref sno))
            {
                return;
            }
            float weight = 0;
            if (!CheckInput(tbWeight, "请输入重量", ref weight))
            {
                return;
            }

            using (TransactionScope scope = new TransactionScope())
            {

                Data.胶料入库 temp = ddc.胶料入库s.Single(x => x.Id == new Guid(dgRubberInventory.SelectedRows[0].Cells[0].Value.ToString()) && x.删除 == false);
                temp.胶料牌号 = typeno;
                temp.箱号 = boxno;
                temp.生产线号 = assline;
                temp.生产日期 = dtpPDate.Value;
                temp.批次号 = sno;
                temp.重量 = weight;
                temp.供应商产品代号 = tbSupplyNo.Text;
                temp.登记时间 = DateTime.Now;
                temp.删除 = checkBox1.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void dgRubberInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
