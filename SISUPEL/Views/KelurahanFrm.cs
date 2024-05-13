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
    using Models;
    public partial class KelurahanFrm : Form
    {

        kelurahanCls kelurahan = new kelurahanCls();

        public KelurahanFrm()
        {
            InitializeComponent();
        }

        void tampilgrid()
        {
            if (searchTxt.Text == "")
            {
                kelurahanDgv.DataSource = kelurahan.tampildata();
            }
            else
            {
                kelurahanDgv.DataSource = kelurahan.searchdata(searchTxt.Text);
            }
        }

        void clear()
        {
            kodekelTxt.Text = kelurahan.buatkode();
            nakelTxt.Clear();
            nakelTxt.Select();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (!kelurahan.apakahada(kodekelTxt.Text))
            {
                kelurahan.setkode_kelurahan = kodekelTxt.Text;
                kelurahan.setnama_kelurahan = nakelTxt.Text;
                if (kelurahan.tambahdata() > 0)
                {
                    MessageBox.Show("Data Berhasil Disimpan,",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    tampilgrid();
                }
                else
                {
                    MessageBox.Show("Data Gagal Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    tampilgrid();

                }

            }
            else
            {
                if (MessageBox.Show("Apakah Data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kelurahan.setnama_kelurahan = nakelTxt.Text;
                    if (kelurahan.updatedata(kodekelTxt.Text, nakelTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil Disimpan,",
                       "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        tampilgrid();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                        tampilgrid();
                    }
                }
            }
        }

        private void KelurahanFrm_Load(object sender, EventArgs e)
        {
            tampilgrid();
            clear();

            // Style for header DataGridView
            kelurahanDgv.EnableHeadersVisualStyles = false;
            kelurahanDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 48);
            kelurahanDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            kelurahanDgv.ColumnHeadersDefaultCellStyle.Font = new Font("poppins", 10, FontStyle.Bold);
            kelurahanDgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            kelurahanDgv.DefaultCellStyle.Font = new Font("poppins", 9); // Menetapkan font dan ukuran font untuk sel-sel
        }

        private void kelurahanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.kelurahanDgv.Rows[e.RowIndex];
            kodekelTxt.Text = baris.Cells[0].Value.ToString();
            nakelTxt.Text = baris.Cells[1].Value.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (kelurahan.apakahada(kodekelTxt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (kelurahan.hapusdata(kodekelTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus,",
                          "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        tampilgrid();
                    }
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            tampilgrid();
        }
    }
}
