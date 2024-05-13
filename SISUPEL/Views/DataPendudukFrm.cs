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
    public partial class DataPendudukFrm : Form
    {

        PendudukCls penduduk = new PendudukCls();

        public DataPendudukFrm()
        {
            InitializeComponent();
        }

        void tampilgrid()
        {
           
            if (searchTxt.Text == "")
            {
                PendudukDgv.DataSource = penduduk.getallpenduduk();
            }
            else
            {
                PendudukDgv.DataSource = penduduk.searchdata(searchTxt.Text, searchTxt.Text, searchTxt.Text);
            }
        }

        private void DataPendudukFrm_Load(object sender, EventArgs e)
        {
            tampilgrid();

            // Style for header DataGridView
            PendudukDgv.EnableHeadersVisualStyles = false;
            PendudukDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 48);
            PendudukDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            PendudukDgv.ColumnHeadersDefaultCellStyle.Font = new Font("poppins", 10, FontStyle.Bold);
            PendudukDgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            PendudukDgv.DefaultCellStyle.Font = new Font("poppins", 9); // Menetapkan font dan ukuran font untuk sel-sel
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            tampilgrid();
        }
    }
}
