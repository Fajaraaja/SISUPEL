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
    public partial class DashboardUserFrm : Form
    {
        public DashboardUserFrm()
        {
            InitializeComponent();
        }

    

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm login = new Loginfrm();
            login.Show();
            Close();
        }

        private void PendudukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendudukFrm penduduk = new PendudukFrm();
            penduduk.TopLevel = false;
            panel1.Controls.Add( penduduk );
            penduduk.Dock = DockStyle.Fill;
            penduduk.Show();
        }
    }
}
