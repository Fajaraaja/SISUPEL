using SISUPEL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISUPEL
{
    public partial class Splashscreenfrm : Form
    {

        byte count = 0;
        public Splashscreenfrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 6)
            {
                timer1.Enabled = false;
                Loginfrm loginfrm = new Loginfrm();
                loginfrm.Show();
                this.Hide();
            }
        }
    }
}
