using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YKT.RubberTraceSystem.Windows.Reporting
{
    public partial class ReportingForm : BaseForm
    {
        public ReportingForm()
        {
            InitializeComponent();
            
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            胶料入库BindingSource.DataSource = from m in ddc.胶料入库s where m.删除 == false select m;
            this.reportViewer1.RefreshReport();
        }
    }
}
