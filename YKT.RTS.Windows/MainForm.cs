using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using YKT.RubberTraceSystem.Windows.Reporting;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class MainForm : BaseForm
    {
        BaseForm baseForm = null;
        public MainForm(BaseForm baseForm)
        {
            InitializeComponent();
            this.baseForm = baseForm;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseForm.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(Auth.User == null)
            {
                Close();
            }
            switch (Auth.User.Category.Name.Trim())
            {
                case "planer":
                    仓库ToolStripMenuItem.Visible = false;
                    基础资料ToolStripMenuItem.Visible = false;
                    break;
                case "storehouse":
                    生产过程ToolStripMenuItem.Visible = false;
                    基础资料ToolStripMenuItem.Visible = false;
                    break;
                case "inspector":
                    仓库ToolStripMenuItem.Visible = false;
                    基础资料ToolStripMenuItem.Visible = false;
                    break;
                case "directlabor":
                    return;

                default:
                    break;
            }
        }

        private void 基础资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 基础资料编辑));
        }

        void ShowForm(Type formtype)
        {
            Type[] types = new Type[0];
            if (formdict.ContainsKey(formtype.FullName))
            {
                if (formdict[formtype.FullName].IsDisposed)
                {
                    formdict[formtype.FullName] = null;
                    ConstructorInfo ci = formtype.GetConstructor(types);

                    BaseForm o = (BaseForm)ci.Invoke(null);
                    formdict[formtype.FullName] = o;
                    o.MdiParent = this;
                    o.Show();
                }
                formdict[formtype.FullName].Activate();
            }
            else
            {
                ConstructorInfo ci = formtype.GetConstructor(types);
                BaseForm o = (BaseForm)ci.Invoke(null);
                o.MdiParent = this;
                o.Show();
                formdict.Add(formtype.FullName, o);
            }

        }
        Dictionary<string, BaseForm> formdict = new Dictionary<string, BaseForm>();
        private void 胶料入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 胶料入库));
        }

        private void 帘布入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 帘布入库));
        }

        private void 胶料出片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 胶料出片));
        }

        private void 帘布剪裁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 帘布裁切));
        }

        private void 工件成型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof( 成型码生成));
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void 打印工件码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(成品码打印));
        }

        private void 产品追踪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(皮囊追溯));
        }

        private void 生产报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(ReportingForm));
        }
    }
}
