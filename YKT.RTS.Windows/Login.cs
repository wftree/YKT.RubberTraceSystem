using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
            var categorys = from n in ddc.Categories select n;
            if(categorys.Count()==0)
            {
                ddc.Categories.InsertOnSubmit(new Category()
                {

                    Name = "admin"
                }) ;
                ddc.Categories.InsertOnSubmit(new Category()
                {

                    Name = "storehouse"
                });
                ddc.Categories.InsertOnSubmit(new Category()
                {

                    Name = "inspector"
                });
                ddc.Categories.InsertOnSubmit(new Category()
                {

                    Name = "planer"
                });
                ddc.Categories.InsertOnSubmit(new Category()
                {
                    Name = "directlabor"
                });
                ddc.SubmitChanges();
            }
            var users = from m in ddc.Users select m;
            if(users.Count()==0)
            {
                ddc.Users.InsertOnSubmit(new User()
                {
                    CategoryId = ddc.Categories.Single(x => x.Name == "admin").Id,
                    Name = "管理员"
                });
                ddc.Users.InsertOnSubmit(new User()
                {
                    CategoryId = ddc.Categories.Single(x => x.Name == "storehouse").Id,
                    Name = "仓库"
                });
                ddc.Users.InsertOnSubmit(new User()
                {
                    CategoryId = ddc.Categories.Single(x => x.Name == "inspector").Id,
                    Name = "检验"
                });
                ddc.Users.InsertOnSubmit(new User()
                {
                    CategoryId = ddc.Categories.Single(x => x.Name == "planer").Id,
                    Name = "生产主管"
                });
                ddc.SubmitChanges();
            }
            userBindingSource.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw = "";
            if (!CheckInput(mtbPassword, "密码不可为空", ref pw))
            {
                return;
            }
            try
            {
                User u = ddc.Users.Single(x => x.Id == Convert.ToInt32(comboBox1.SelectedValue));
                if (u.MD5 == null)
                {
                    MessageBox.Show("第一次登录");
                    u.MD5 = GetMD5();
                    ddc.SubmitChanges();
                }
                else if(u.MD5 != GetMD5())
                {
                    MessageBox.Show("密码错误");
                    return;
                }
                Auth.User = u;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            BaseForm form = new MainForm(this);
            form.Show();
            this.Hide();
            
        }

        private string GetMD5()
        {
            byte[] result = Encoding.Default.GetBytes(this.mtbPassword.Text.Trim());  //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
