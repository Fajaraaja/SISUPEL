using SISUPEL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISUPEL.Views
{
    public partial class Loginfrm : Form
    {
        LoginCls login = new LoginCls();
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserTxt.Text) || string.IsNullOrEmpty(PassTxt.Text))
            {
                MessageBox.Show("Username atau password tidak boleh kosong.",
                    "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserTxt.Focus();
            }
            else if (login.ApakahAda(UserTxt.Text, PassTxt.Text))
            {
                string role = login.GetRole(UserTxt.Text);
                DashboardFrm dashboard = new DashboardFrm(role);
                if (role == "admin")
                {
                    dashboard.menuset(true, true, true, true, true);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    dashboard.menuset(false, false, true, false, true);
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Maaf User ID / Password Salah.",
                    "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserTxt.SelectAll();
                UserTxt.Focus();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PassTxt.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
