using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilizities;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows.Reporting
{
    public partial class 皮囊追溯 : BaseForm
    {
        public 皮囊追溯()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            tvTrace.Nodes.Clear();
            Guid typeno = new Guid();
            if (!CheckInput(tbId, "请输入成品号", ref typeno))
            {
                return;
            }
            皮囊硫化 cp = null;
            IQueryable< 检验修边> cc=null;
            try
            {
                cp = ddc.皮囊硫化s.Single(m => m.删除 == false && m.成型皮囊 == typeno);
                if(cp!=null)
                {
                    cc = from m in ddc.检验修边s
                         where m.删除 == false && m.硫化皮囊 == cp.Id
                         select m;
                }
            }
            catch (Exception)
            {

                //throw;
            }
           
            
            皮囊成型 np;
            try
            {
                np = ddc.皮囊成型s.Single(m => m.删除 == false && m.Id == typeno);
            }
            catch (Exception)
            {

                return;
            }
            
            var irc = ddc.橡胶薄片s.Single(m=> m.删除 == false && m.Id == np.内胶片批号 );
            var orc = ddc.橡胶薄片s.Single(m => m.删除 == false && m.Id == np.外胶片批号);
            var fc = ddc.帘布流转s.Single(m => m.删除 == false && m.Id == np.帘布批号);
            var iri = ddc.胶料入库s.Single(m => m.删除 == false && m.Id == irc.胶料批号);
            var ori = ddc.胶料入库s.Single(m => m.删除 == false && m.Id == orc.胶料批号);
            var fi = ddc.帘布入库s.Single(m => m.删除 == false && m.Id == fc.帘布批号);

            TreeNode cptn = null;
            if (cp!=null)
            {
                cptn = new TreeNode("硫化码：" + Utilizity.CreateQRCodeStr(TableType.CP, cp.Id.ToString()));
                cptn.Nodes.Add("产品型号：" + cp.产品型号.ToString());
                cptn.Nodes.Add("生产时间："+cp.生产时间.ToString());
                cptn.Nodes.Add("硫化时间："+cp.硫化时间.ToString());
                cptn.Nodes.Add("硫化温度：" + cp.硫化温度.ToString());
                cptn.Nodes.Add("作业员：" + ddc.员工s.Single(m=>m.Id==cp.作业员).姓名);
                cptn.Nodes.Add("生产机台：" + ddc.机台s.Single(m => m.Id == cp.生产机台).机台名称);
                //tvTrace.Nodes.Add(cptn);

                if(cc.Count()>0)
                {
                    TreeNode crtn = new TreeNode("检测结果");
                    foreach (var item in cc)
                    {
                        TreeNode cctn = new TreeNode();
                        cctn.Text = item.结果?"合格":"不合格";
                        cctn.Nodes.Add("检验时间："+item.登记时间.ToString());
                        cctn.Nodes.Add("检验员：" + ddc.员工s.Single(m => m.Id == item.检验员).姓名);
                        if(item.处理方法!=null)
                            cctn.Nodes.Add("处理方法：" + ddc.处理方法s.Single(m => m.Id == item.处理方法 && m.删除== false).处理方法1);
                        crtn.Nodes.Add(cctn);
                    }
                    cptn.Nodes.Add(crtn);
                }
            }
            TreeNode nptn = new TreeNode();
            nptn.Text = "成型码："+ Utilizity.CreateQRCodeStr(TableType.NP, np.Id.ToString());
            nptn.Nodes.Add("产品型号：" + np.产品型号.ToString());
            nptn.Nodes.Add("生产时间：" + np.生产时间.ToString());
            if(np.作业员 != null)
                nptn.Nodes.Add("作业员：" + ddc.员工s.First(m => m.Id == np.作业员).姓名);
            if (np.生产机台 != null)
                nptn.Nodes.Add("生产机台：" + ddc.机台s.First(m => m.Id == np.生产机台).机台名称);

            TreeNode irctn = new TreeNode();
            irctn.Text = "内层胶料：" + Utilizity.CreateQRCodeStr(TableType.RC,irc.胶料批号.ToString());
            irctn.Nodes.Add("生产时间：" + irc.生产时间.ToString());
            irctn.Nodes.Add("宽度：" + irc.宽度);
            irctn.Nodes.Add("厚度：" + irc.厚度);
            if (irc.作业员 != null)
                irctn.Nodes.Add("作业员：" +  ddc.员工s.Single(m => m.Id == irc.作业员).姓名);
            nptn.Nodes.Add(irctn);

            TreeNode orctn = new TreeNode();
            orctn.Text = "外层胶料："+Utilizity.CreateQRCodeStr(TableType.RC, orc.胶料批号.ToString());
            orctn.Nodes.Add("生产时间：" +  orc.生产时间.ToString());
            orctn.Nodes.Add("宽度：" + orc.宽度);
            orctn.Nodes.Add("厚度：" + orc.厚度);
            if (orc.作业员 != null)
                orctn.Nodes.Add("作业员：" +  ddc.员工s.Single(m => m.Id == orc.作业员).姓名);
            nptn.Nodes.Add(orctn);

            TreeNode fctn = new TreeNode();
            fctn.Text = "帘布卷：" + Utilizity.CreateQRCodeStr(TableType.FC, fc.帘布批号.ToString());
            fctn.Nodes.Add("生产时间：" + fc.生产时间.ToString());
            fctn.Nodes.Add("宽度：" + fc.宽度);
            fctn.Nodes.Add("厚度：" + fc.厚度);
            fctn.Nodes.Add("角度：" + fc.角度);
            if (fc.作业员 != null)
                fctn.Nodes.Add("作业员：" +  ddc.员工s.Single(m => m.Id == fc.作业员).姓名);
            nptn.Nodes.Add(fctn);

            TreeNode oritn = new TreeNode();
            oritn.Text = "外层胶料：" + Utilizity.CreateQRCodeStr(TableType.RI, ori.Id.ToString());
            oritn.Nodes.Add("胶料牌号：" + ori.胶料牌号);
            oritn.Nodes.Add("生产时间：" + ori.生产日期.ToString());
            oritn.Nodes.Add("批次号：" + ori.批次号);
            orctn.Nodes.Add(oritn);

            TreeNode iritn = new TreeNode();
            iritn.Text = "内层胶料：" + Utilizity.CreateQRCodeStr(TableType.RI, iri.Id.ToString());
            oritn.Nodes.Add("胶料牌号：" + iri.胶料牌号);
            iritn.Nodes.Add("生产时间：" + iri.生产日期.ToString());
            iritn.Nodes.Add("批次号：" + iri.批次号);
            irctn.Nodes.Add(iritn);

            TreeNode fitn = new TreeNode();
            fitn.Text = "帘布：" + Utilizity.CreateQRCodeStr(TableType.FI, fi.Id.ToString());
            fitn.Nodes.Add("帘布代号：" + fi.帘布代号);
            fitn.Nodes.Add("生产时间：" + fi.生产日期);
            fitn.Nodes.Add("批次号：" + fi.生产序号);
            fitn.Nodes.Add("帘布长度：" + fi.帘布长度);
            fctn.Nodes.Add(fitn);

            if(cptn!=null)
            {
                cptn.Nodes.Add(nptn);
                tvTrace.Nodes.Add(cptn);

            }
            else
            {
                tvTrace.Nodes.Add(nptn);
            }
            tvTrace.ExpandAll();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (tbId.Text.Length > 38)
            {
                string temp = tbId.Text;
                if (!temp.StartsWith(TableType.NP.ToString()))
                {
                    MessageBox.Show("错误代码。请检查后输入");
                    tbId.Focus();
                    tbId.Text = "";
                    return;
                }
                tbId.Text = Utilizity.DecodeQRCode(temp).ToString();
            }
        }
    }
}
