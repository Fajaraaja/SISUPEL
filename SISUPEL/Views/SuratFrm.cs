using SISUPEL.Models;
using SISUPEL.Report;
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
    public partial class SuratFrm : Form
    {
        PendudukCls pendudukCls = new PendudukCls();
        public SuratFrm()
        {
            InitializeComponent();
        }

        void tampilgrid()
        {
            if (searchTxt.Text == "")
            {
                PendudukDgv.DataSource = pendudukCls.getpendudukover17();
            }
            else
            {
                PendudukDgv.DataSource = pendudukCls.searchdata(searchTxt.Text,searchTxt.Text,searchTxt.Text);
            }
        }

        private void CetakBtn_Click(object sender, EventArgs e)
        {
            PrintFrm printFrm = new PrintFrm();
            printFrm.kode = KodpenTxt.Text;
            printFrm.Show();
        }

        public void Isvisible()
        {
            CetakBtn.Visible = false;
        }

        private void PendudukDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.PendudukDgv.Rows[e.RowIndex];
            KodpenTxt.Text = baris.Cells[0].Value.ToString();
            NapenTxt.Text = baris.Cells[1].Value.ToString();
            NikTxt.Text = baris.Cells[2].Value.ToString();
            AlamatTxt.Text = baris.Cells[4].Value.ToString();
            NakelCmb.Text = baris.Cells[5].Value.ToString();
            NaTpsCmb.Text = baris.Cells[6].Value.ToString();
        }

        private void SuratFrm_Load(object sender, EventArgs e)
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
