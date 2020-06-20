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
    public partial class Main : BaseForm
    {
        public Main()
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
            printer.PrintQRCode(120, 120, 6, Utilizity.CreateQRCodeStr(TableType.UR, dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
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
    }
}
