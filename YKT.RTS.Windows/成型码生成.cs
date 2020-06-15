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
    public partial class 成型码生成 : Form
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
        }
    }
}
