using SimpleClinic_View.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Users
{
    public partial class frmLoginUser : Form
    {
        ApiResult<bool> user;

        public frmLoginUser()
        {
            InitializeComponent();
            user = new ApiResult<bool>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            user = await UserService.CheckCredentials(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user.Result)
            {

                if (chkRemeberMe.Checked)
                {
                    //store username and password
                    Global.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    Global.RememberUsernameAndPassword("", "");

                }



                // clsGlobal.CurrentUser = user;
                this.Hide();
                //frmMain frm = new frmMain(this);
                //frm.ShowDialog();


            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (Global.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRemeberMe.Checked = true;
            }
            else
                chkRemeberMe.Checked = false;
        }
    }
}
