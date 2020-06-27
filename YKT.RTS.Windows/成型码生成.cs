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
    public partial class 成型码生成 : BaseForm
    {
        public 成型码生成()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbTypeNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入产品型号");
                return;
            }
            if (tbNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入要生成数量");
                return;
            }
            int num;
            try
            {
                num = Convert.ToInt32(tbNum.Text);
            }
            catch 
            {
                MessageBox.Show("请输入正确数字");
                return;
            }
            if(dgOutRubber.SelectedRows.Count<0)
            {
                MessageBox.Show("请选择胶料");
                return;
            }
            if (dgFabric.SelectedRows.Count < 0)
            {
                MessageBox.Show("请选择帘布卷");
                return;
            }

            using (TransactionScope scope = new TransactionScope())
            {
                List<Guid> all = new List<Guid>();
                for (int i = 0; i < num; i++)
                {
                    皮囊成型 temp = new 皮囊成型();
                    temp.Id = Guid.NewGuid();
                    temp.外胶片批号 = new Guid(dgOutRubber.SelectedRows[0].Cells["Id"].Value.ToString());
                    temp.帘布批号 = new Guid(this.dgFabric.SelectedRows[0].Cells["Id"].Value.ToString());
                    temp.内胶片批号 = new Guid(dgInnerRubber.SelectedRows[0].Cells["Id"].Value.ToString());
                    temp.登记时间 = DateTime.Now;
                    ddc.皮囊成型s.InsertOnSubmit(temp);
                    all.Add(temp.Id);
                }
                //打印二维码
                IQRPrinter printer = QRPrinterFactory.GetQRPrinter();
                foreach (var item in all)
                {
                    
                    if(!printer.PrintQRCode(Utilizity.CreateQRCodeStr(TableType.NP, item.ToString())))
                    {
                        MessageBox.Show("打印错误，请重新生成成品代码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                ddc.SubmitChanges();
                scope.Complete();
            }
            //LoadData();
        }
        
        private void 成型码生成_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var rubberchips = from m in ddc.橡胶薄片s where m.删除 == false select m;
            外橡胶薄片BindingSource.DataSource = rubberchips;
            var farbic = from m in ddc.帘布流转s where m.删除 == false select m;
            帘布流转BindingSource.DataSource = farbic;
            var innerrubberchips = from m in ddc.橡胶薄片s where m.删除 == false select m;
            内橡胶薄片BindingSource.DataSource = innerrubberchips;
        }
    }
}
