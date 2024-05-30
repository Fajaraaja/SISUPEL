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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISUPEL.Views
{
    public partial class PendudukFrm : Form
    {

        PendudukCls penduduk = new PendudukCls();
        TPSCls tps = new TPSCls();
        kelurahanCls kelurahan = new kelurahanCls();

        public PendudukFrm()
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

        private void PendudukFrm_Load(object sender, EventArgs e)
        {
            clear();
            tampilgrid();
            combokelurahan();

            // Style for header DataGridView
            PendudukDgv.EnableHeadersVisualStyles = false;
            PendudukDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 48);
            PendudukDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            PendudukDgv.ColumnHeadersDefaultCellStyle.Font = new Font("poppins", 10, FontStyle.Bold);
            PendudukDgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            PendudukDgv.DefaultCellStyle.Font = new Font("poppins", 9); // Menetapkan font dan ukuran font untuk sel-sel
        }

        void combokelurahan()
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

        void combotps(string selectedKelurahan)
        {
            DataTable dt = new DataTable();
            dt = tps.tampildata(); 
            if (dt.Rows.Count > 0)
            {
                NaTpsCmb.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["nama_kelurahan"].ToString() == selectedKelurahan)
                    {
                       
                        NaTpsCmb.Items.Add(dr["nama_tps"].ToString());
                    }
                }
            }
        }

        void clear()
        {
            KodpenTxt.Text = penduduk.buatkode();
            NapenTxt.Clear();
            NikTxt.Clear();
            AlamatTxt.Clear();
            NapenTxt.Select();
            NakelCmb.ResetText();
            NaTpsCmb.ResetText();
        }

        private void NakelCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKelurahan = NakelCmb.SelectedItem.ToString();
            combotps(selectedKelurahan);
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            // Periksa apakah data penduduk sudah ada
            if (!penduduk.Apakahada(KodpenTxt.Text))
            {
                // Set data penduduk dari input
                penduduk.setkode_penduduk = KodpenTxt.Text;
                penduduk.setnama_penduduk = NapenTxt.Text;
                penduduk.setnik = NikTxt.Text;
                penduduk.setalamat_penduduk = AlamatTxt.Text;
                penduduk.setkode_kelurahan = kelurahan.ambilkodeDgnama(NakelCmb.Text);
                penduduk.setkode_tps = tps.ambilkodeDgnama(NaTpsCmb.Text);

                try
                {
                    string kod = NikTxt.Text.Substring(10, 2);
                    int tahunSekarang = DateTime.Now.Year;
                    string tahus = tahunSekarang.ToString().Substring(2,2);
                    int tahuns = int.Parse(tahus);
                    int kodInt = int.Parse(kod);

                    if (kodInt <= tahuns)
                    {
                        kodInt += 2000;
                    }
                    else
                    {
                        kodInt += 1900;
                    }

                    int tahunLahir = kodInt;
                    int umur = tahunSekarang - tahunLahir;

                    // Validasi umur
                    if (umur < 17)
                    {
                        MessageBox.Show("Pencoblos Belum Cukup Umur", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                        tampilgrid();
                    }
                    else
                    {
                        // Simpan data penduduk
                        if (penduduk.savedata() > 0)
                        {
                            MessageBox.Show("Data Berhasil Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Apakah Data akan diubah?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Set data penduduk dari input
                    penduduk.setkode_penduduk = KodpenTxt.Text;
                    penduduk.setnama_penduduk = NapenTxt.Text;
                    penduduk.setnik = NikTxt.Text;
                    penduduk.setalamat_penduduk = AlamatTxt.Text;
                    penduduk.setkode_kelurahan = kelurahan.ambilkodeDgnama(NakelCmb.Text);
                    penduduk.setkode_tps = tps.ambilkodeDgnama(NaTpsCmb.Text);

                    // Perbarui data penduduk
                    if (penduduk.updatedata(KodpenTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (penduduk.Apakahada(KodpenTxt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (penduduk.hapusdata(KodpenTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus,",
                          "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        tampilgrid();
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void PendudukDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.PendudukDgv.Rows[e.RowIndex];
            KodpenTxt.Text = baris.Cells[0].Value.ToString();
            NapenTxt.Text = baris.Cells[1].Value.ToString();
            NikTxt.Text = baris.Cells[2].Value.ToString();
            AlamatTxt.Text = baris.Cells[3].Value.ToString();
            NakelCmb.Text = baris.Cells[4].Value.ToString();
            NaTpsCmb.Text = baris.Cells[5].Value.ToString();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            tampilgrid();
        }

        private void CetakBtn_Click(object sender, EventArgs e)
        {
            CetakpendudukFrm penduduk = new CetakpendudukFrm();
            penduduk.kode = KodpenTxt.Text;
            penduduk.ShowDialog();
        }
    }
}
