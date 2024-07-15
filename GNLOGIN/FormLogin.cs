using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNLOGIN
{
    public partial class FormLogin : Form
    {
        string username = "Witsanukon";
        string password = "TUNna4465";
        string username1 = "admin";
        string password1 = "admin";
        string logUsername;
        string logPassword;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void picView_MouseDown(object sender, MouseEventArgs e)
        {
            tPwd.UseSystemPasswordChar = false;
        }

        private void picView_MouseUp(object sender, MouseEventArgs e)
        {
            tPwd.UseSystemPasswordChar = true;
        }

        private void tPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
                logUsername = tUser.Text;
                logPassword = tPwd.Text;
            if ((username == logUsername) && (password == logPassword))
            {
                FromUser fromuser = new FromUser();
                fromuser.Show();
                this.Hide();
            }
            else if ((username1 == logUsername) && (password1 == logPassword))
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("ชื่อและรหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //ข้อความในช่องจะหายไป
                tPwd.Text = string.Empty;
                tUser.Select();
            }
            
        }
    }
}
