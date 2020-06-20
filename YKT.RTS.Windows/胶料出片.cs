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
    public partial class 胶料出片 : BaseForm
    {
        public 胶料出片()
        {
            InitializeComponent();
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

            using (TransactionScope scope = new TransactionScope())
            {
                List<Guid> all = new List<Guid>();
                for (int i = 0; i < counter; i++)
                {
                    橡胶薄片 temp = new 橡胶薄片();
                    temp.Id = Guid.NewGuid();
                    temp.胶料批号 = typeno;
                    temp.厚度 = thick;
                    temp.宽度 = width;
                    temp.数量 = 0;
                    temp.生产序号 = i;
                    temp.登记时间 = DateTime.Now;
                    ddc.橡胶薄片s.InsertOnSubmit(temp);
                    all.Add(temp.Id);
                }
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                //打印二维码
                foreach (var item in all)
                {
                    
                    if (!printer.PrintQRCode(120, 120, 6, Utilizity.CreateQRCodeStr(TableType.NP, item.ToString())))
                    {
                        MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //if(DialogResult.Yes == MessageBox.Show("是否已经用完本垛胶料？","询问", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                //{
                //    if (DialogResult.Yes == MessageBox.Show("以用完本垛胶料将？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                //}

                ddc.SubmitChanges();
                scope.Complete();
            }
        }

        private void dgOutRubber_SelectionChanged(object sender, EventArgs e)
        {
            if(dgOutRubber.SelectedRows.Count>0)
            {
                tbTypeNo.Text = dgOutRubber.SelectedRows[0].Cells["Id"].Value.ToString();
            }
        }

        private void 胶料出片_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.胶料入库s where m.删除 == false select m;
            胶料入库BindingSource.DataSource = users;
        }
    }
}
