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
    public partial class DashboardFrm : Form
    {
        string userrole;
        
        public DashboardFrm(string role)
        {
            InitializeComponent();
            userrole = role;
        }

        public void menuset(bool mn1, bool mn2,bool mn3,bool mn4,bool m5)
        {
            KelurahanToolStripMenuItem.Visible = mn1;
            TPSToolStripMenuItem.Visible = mn2;
            PendudukToolStripMenuItem.Visible = mn3;
            PersuratanToolStripMenuItem.Visible = mn4;
            logOutToolStripMenuItem1.Visible = m5;
        }

        private void KelurahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KelurahanFrm kelurahan = new KelurahanFrm();
            kelurahan.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(kelurahan);
            kelurahan.Dock = DockStyle.Fill;
            kelurahan.Show();
        }

        

        private void TPSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TPSFrm tps = new TPSFrm();
            panel1.Controls.Clear();
            tps.TopLevel = false;
            panel1.Controls.Add(tps);
            tps.Dock = DockStyle.Fill;
            tps.Show();
        }

        private void PendudukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendudukFrm penduduk = new PendudukFrm();
            panel1.Controls.Clear();
            penduduk.TopLevel = false;
            panel1.Controls.Add(penduduk);
            penduduk.Dock = DockStyle.Fill;
            penduduk.Show();
        }



        private void DashboardFrm_Load(object sender, EventArgs e)
        {
            WelcomeFrm welcome = new WelcomeFrm();
            panel1.Controls.Clear();
            welcome.TopLevel = false;
            panel1.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Loginfrm login = new Loginfrm();
                login.Show();
                this.Close();
            }
        }

        private void PersuratanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuratFrm surat = new SuratFrm();
            panel1.Controls.Clear();
            surat.TopLevel = false;
            panel1.Controls.Add(surat);
            surat.Dock = DockStyle.Fill;
            surat.Show();
            if (userrole != "admin")
            {
                surat.Isvisible();
            }
            surat.Show();
        }
    }
}
