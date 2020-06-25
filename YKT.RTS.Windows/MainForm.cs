using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            createform(new 基础资料编辑());
        }

        private void createform(BaseForm bf)
        {
            bf.MdiParent = this;
            bf.Show();
        }

        private void 胶料入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createform(new 胶料入库());
        }

        private void 帘布入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createform(new 帘布入库());
        }

        private void 胶料出片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createform(new 胶料出片());
        }

        private void 帘布剪裁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createform(new 帘布裁切());
        }

        private void 工件成型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createform(new 成型码生成());
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
