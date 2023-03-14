using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulexx.CommonUI
{
    public partial class Config_Form : Form
    {
        public Config_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Properties.Settings.Default.user = TxBx1.Text;
            //    Properties.Settings.Default.password = TxBx2.Text;
            //    Properties.Settings.Default.server = TxBx3.Text;
            //    Schulexx.Properties.Settings.Default.Save();
            //    MessageBox.Show("Connection settings Updated", "SchulEx.");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error >> " + ex.Message, "SchulEx.");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, " Are you sure you wish to close the config form?", "SchulEx.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new LoginForm().Show();
            }
        }

        private void Config_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            new LoginForm().Show();
        }
        private void Config_Form_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    TxBx1.Text = Properties.Settings.Default.user;
            //    TxBx2.Text = Properties.Settings.Default.password;
            //    TxBx3.Text = Properties.Settings.Default.server;
            //}
            //catch { }
        }
    }
}
