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
        public DashboardFrm()
        {
            InitializeComponent();
        }

        public void menuset(bool mn1, bool mn2,bool mn3,bool mn4)
        {
            KelurahanToolStripMenuItem.Visible = mn1;
            TPSToolStripMenuItem.Visible = mn2;
            PendudukToolStripMenuItem.Visible = mn3;
            logOutToolStripMenuItem.Visible = mn4;

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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm login= new Loginfrm();
            login.Show();
            Close();
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
    }
}
