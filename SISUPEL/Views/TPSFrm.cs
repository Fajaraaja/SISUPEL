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
    public partial class TPSFrm : Form
    {
        TPSCls tps = new TPSCls();
        kelurahanCls kelurahan = new kelurahanCls();

        public TPSFrm()
        {
            InitializeComponent();
        }

        void isicombo()
        {
            DataTable dt = new DataTable();
            dt = kelurahan.tampildata();
            if(dt.Rows.Count > 0 )
            {
                NakelCmb.Items.Clear();
                foreach(DataRow dr in dt.Rows)
                {
                    NakelCmb.Items.Add(dr[1].ToString());
                }
            }
        }

        void tampilgrid()
        {
            if (searchTxt.Text == "")
            {
                TPSDgv.DataSource = tps.tampildata();
            }
            else
            {
                TPSDgv.DataSource = tps.searchdata(searchTxt.Text);
            }

        }

        void clear()
        {
            kodtpsTxt.Text = tps.buatkode();
            natpsTxt.Clear();
            natpsTxt.Select();
        }

        private void TPSFrm_Load(object sender, EventArgs e)
        {
            isicombo();
            tampilgrid();
            clear();

            // Style for header DataGridView
            TPSDgv.EnableHeadersVisualStyles = false;
            TPSDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 48);
            TPSDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TPSDgv.ColumnHeadersDefaultCellStyle.Font = new Font("poppins", 9, FontStyle.Bold);
            TPSDgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {

            if (!tps.apakahada(kodtpsTxt.Text))
            {
                tps.setkode_tps = kodtpsTxt.Text;
                tps.setnama_tps = natpsTxt.Text;
                tps.setkode_kelurahan = kelurahan.ambilkodeDgnama(NakelCmb.Text);
                if (tps.tambahdata() > 0)
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
                    tps.setkode_tps = kodtpsTxt.Text;
                    tps.setnama_tps = natpsTxt.Text;
                    tps.setkode_kelurahan = kelurahan.ambilkodeDgnama(NakelCmb.Text);
                    if (tps.updatedata(kodtpsTxt.Text) > 0)
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

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (tps.apakahada(kodtpsTxt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tps.hapusdata(kodtpsTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus,",
                          "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        tampilgrid();
                    }
                }
            }
        }

        private void TPSDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.TPSDgv.Rows[e.RowIndex];
            kodtpsTxt.Text = baris.Cells[0].Value.ToString();
            natpsTxt.Text = baris.Cells[1].Value.ToString();
            NakelCmb.Text = baris.Cells[2].Value.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            tampilgrid();
        }
    }
}
