using QRCoder;
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
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class 基础资料编辑 : BaseForm
    {
        public 基础资料编辑()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                pictureBox1.Image = Utilizity.CreateQRCode(TableType.UR, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                tbName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cbClassType.SelectedValue = new Guid(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());

            }
            
        }

        private void btnStaffPrintQR_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.UR, dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var users = from m in ddc.员工s where m.删除 == false select m;
            员工BindingSource.DataSource = users;
            var classtype = from m in ddc.班别s where m.删除 == false select m;
            班别BindingSource.DataSource = classtype;
            var clff = from m in ddc.处理方法s where m.删除 == false select m;
            处理方法BindingSource.DataSource = clff;
            var jt = from m in ddc.机台s where m.删除 == false select m;
            机台BindingSource.DataSource = jt;
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                员工 temp = new 员工();
                temp.Id = Guid.NewGuid();
                temp.姓名 = tbName.Text;
                temp.班别 = new Guid(cbClassType.SelectedValue.ToString());
                temp.登记时间 = DateTime.Now;
                ddc.员工s.InsertOnSubmit(temp);
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var user = (from m in ddc.员工s where m.Id == new Guid(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) select m).First();
                user.姓名 = tbName.Text;
                user.班别 = new Guid(cbClassType.SelectedValue.ToString());
                user.登记时间 = DateTime.Now;
                user.删除 = cbDel.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_BBEdit_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var bb = (from m in ddc.班别s where m.Id == new Guid(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()) select m).First();
                bb.班别1 = tb_BB.Text;
                bb.登记时间 = DateTime.Now;
                bb.删除 = cb_BBDel.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_BBAdd_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                班别 temp = new 班别();
                temp.Id = Guid.NewGuid();
                temp.班别1 = tb_BB.Text;
                temp.登记时间 = DateTime.Now;
                ddc.班别s.InsertOnSubmit(temp);
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_CLFFEdit_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var clff = (from m in ddc.处理方法s where m.Id == new Guid(dataGridView3.SelectedRows[0].Cells[0].Value.ToString()) select m).First();
                clff.处理方法1 = tb_CLFF.Text;
                clff.附件 = tb_CLFFFJ.Text;
                clff.登记时间 = DateTime.Now;
                clff.删除 = cb_CLFFDel.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_CLFFAdd_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                处理方法 temp = new 处理方法();
                temp.Id = Guid.NewGuid();
                temp.处理方法1 = tb_CLFF.Text;
                temp.附件 = tb_CLFFFJ.Text;
                temp.登记时间 = DateTime.Now;
                ddc.处理方法s.InsertOnSubmit(temp);
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_JTEdit_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var jt = (from m in ddc.机台s where m.Id == new Guid(dataGridView3.SelectedRows[0].Cells[0].Value.ToString()) select m).First();
                jt.机台编号 = tb_JTJTBH.Text;
                jt.机台名称 = tb_JTJTMC.Text;
                jt.机台描述 = tb_JTJTMS.Text;
                jt.登记时间 = DateTime.Now;
                jt.删除 = cb_JTDel.Checked;
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void btn_JTAdd_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                机台 temp = new 机台();
                temp.Id = Guid.NewGuid();
                temp.机台编号 = tb_JTJTBH.Text;
                temp.机台名称 = tb_JTJTMC.Text;
                temp.机台描述 = tb_JTJTMS.Text;
                temp.登记时间 = DateTime.Now;
                ddc.机台s.InsertOnSubmit(temp);
                ddc.SubmitChanges();
                scope.Complete();
            }
            LoadData();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                pictureBox2.Image = Utilizity.CreateQRCode(TableType.CT, dataGridView2.SelectedRows[0].Cells[0].Value.ToString());

                tb_BB.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                pictureBox3.Image = Utilizity.CreateQRCode(TableType.MT, dataGridView3.SelectedRows[0].Cells[0].Value.ToString());

                tb_CLFF.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                tb_CLFFFJ.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                pictureBox4.Image = Utilizity.CreateQRCode(TableType.MC, dataGridView4.SelectedRows[0].Cells[0].Value.ToString());

                tb_JTJTBH.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                tb_JTJTMC.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
                tb_JTJTMS.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btnCTPrintQR_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.CT, dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void btnMTPrintQR_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.MT, dataGridView3.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void btnMCPrintQR_Click(object sender, EventArgs e)
        {
            IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
            printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.MC, dataGridView4.SelectedRows[0].Cells[0].Value.ToString()));
        }
    }
}
