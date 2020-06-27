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
        public 帘布裁切()
        {
            InitializeComponent();
        }

        private void 帘布裁切_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.帘布入库s where m.删除 == false select m;
            this.帘布入库BindingSource.DataSource = users;
        }
        private void dgFabric_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFabric.SelectedRows.Count > 0)
            {
                tbTypeNo.Text = dgFabric.SelectedRows[0].Cells["Id"].Value.ToString();
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

            using (TransactionScope scope = new TransactionScope())
            {
                List<Guid> all = new List<Guid>();
                for (int i = 0; i < counter; i++)
                {
                    帘布流转 temp = new 帘布流转();
                    temp.Id = Guid.NewGuid();
                    temp.帘布批号 = typeno;
                    temp.厚度 = thick;
                    temp.宽度 = width;
                    temp.角度 = ang;
                    temp.产品编号 = pno;
                    temp.使用期限 = DateTime.Now.AddDays(5);
                    temp.登记时间 = DateTime.Now;
                    ddc.帘布流转s.InsertOnSubmit(temp);
                    all.Add(temp.Id);
                }
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                //打印二维码
                foreach (var item in all)
                {

                    if (!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.FC, item.ToString())))
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
    }
}
