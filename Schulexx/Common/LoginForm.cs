using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Data;
using Schulexx.ErrorHandling;
using System.Net;
using System.Net.Sockets;
using Schulexx.Utility;

namespace Schulexx.CommonUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Txt_user.Text = "template";
            //Txt_pass.Text = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uid = Txt_user.Text;
            string pwd = Txt_pass.Text;
            if (uid.Length == 0 || pwd.Length == 0)
            {
                ErrorHelper.ShowWarning(this, "Please provide Username and Password" , "Invalid Inputs");
                return;
            }
            //if (Txt_user.Text == "pass" && Txt_pass.Text == "pass")
            //{
            //    this.Hide();
            //    new holdme_Class().stry();
            //    new Config_Form().Show();

            //}
            //else
            //{
               
            //}
            login(uid, pwd);
            Txt_user.Clear();
            Txt_pass.Clear();
            Txt_user.Select();

        }

        /*public void login()
        {//singleval(string table, string attribute, string where)
            string access_level = new Connectoperations().singleval("users", "user_id", "where username='" + Txt_user.Text + "' and password='" + Txt_pass.Text + "'");
            string uname = new Connectoperations().singleval("users", "username", "where username='" + Txt_user.Text + "' and password='" + Txt_pass.Text + "'");
            string userStatus = new Connectoperations().singleval("users", "userStatus", "where username='" + Txt_user.Text + "' and password='" + Txt_pass.Text + "'");
            // MessageBox.Show(""+role,"");
            if (access_level != "" && userStatus == "Active")
            {
                string x = new Connectoperations().singleval("access_levels", "access_level", "where user_id='" + access_level + "'");
                if (x == "Admin")
                {
                    this.Hide();
                    new Form1(uname, x).ShowDialog();
                }
                else if (x == "User")
                {
                    this.Hide();
                    new Form1(uname, x).ShowDialog();
                }
            }
        }
            else if (userStatus == "Inactive")
            {
                MessageBox.Show("Your account has been blocked, please contact your system administrator", "Account is Blocked", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Invalid Inputs");
            }
        }*/


        public void login(string user_name, string pwd)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var pwdHash = CryptoLib.PasswordHelper.GetHash(pwd, user_name);

                using (var db = new schulex_dbEntities())
                {
                    var user = db.users.FirstOrDefault(x => x.username == user_name && x.password == pwdHash);
                    if (user == null)
                    {
                        ErrorHelper.ShowWarning(this, "Invalid Username and/or Password", "Invalid Inputs");
                        return;
                    }

                    if (user.userStatus == "Inactive")
                    {
                        ErrorHelper.ShowInfo(this, "Your account has been blocked, please contact your system administrator", "Account is Blocked");
                        return;
                    }

                    var access_settings = user.access_levels.access_level_menu.Select(a => a.menu_master.menu_name).ToList();

                    Hide();
                    AppHelper.user_id = user.user_id;
                    AppHelper.user_name = user.username;
                    AppHelper.user_role = user.access_levels.access_level;
                    new frmMain(access_settings).ShowDialog();

                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowError(this, ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

    }
}
