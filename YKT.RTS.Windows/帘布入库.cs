using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                Data.胶料入库 temp = new Data.胶料入库();
                temp.Id = Guid.NewGuid();
                temp.胶料牌号 = typeno;
                temp.箱号 = boxno;
                temp.生产线号 = assline;
                temp.生产日期 = dtpPDate.Value.ToString();
                temp.批次号 = sno;
                temp.重量 = weight;
                temp.供应商产品代号 = tbSupplyNo.Text;
                temp.登记时间 = DateTime.Now;
                ddc.胶料入库s.InsertOnSubmit(temp);

                ddc.SubmitChanges();
                scope.Complete();
            }
        }

        private void 帘布入库_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var users = from m in ddc.帘布入库s where m.删除 == false orderby m.登记时间 select m;
            this.帘布入库BindingSource.DataSource = users;
        }
    }
}
