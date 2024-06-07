using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SISUPEL.Models
{
    using Config;
    using System.Collections;

    internal class PendudukCls
    {
        private string kode_penduduk;
        private string kode_kelurahan;
        private string kode_tps;
        private string nama_penduduk;
        private string nik;
        private string alamat_penduduk;

        LayananCls server;
        DataTable temp;
        string Query;

        public PendudukCls()
        {
            server = new LayananCls();
            temp = new DataTable();
            kode_penduduk = "";
            kode_kelurahan = "";
            kode_tps = "";
            nama_penduduk = "";
            nik = "";
            alamat_penduduk = "";
        }

        public string setkode_penduduk
        {
            set
            {
                kode_penduduk = value;
            }
        }

        public string setnama_penduduk
        {
            set
            {
                nama_penduduk = value;
            }
        }

        public string setnik
        {
            set
            {
                nik = value;
            }
        }

        public string setalamat_penduduk
        {
            set
            {
                alamat_penduduk = value;
            }
        }

        public string setkode_tps
        {
            set
            {
                kode_tps = value;
            }
        }

        public string setkode_kelurahan
        {
            set
            {
                kode_kelurahan = value;
            }
        }

        public DataTable getallpenduduk()
        {
            Query =  "SELECT p.kode_penduduk, p.nama_penduduk, p.nik, p.alamat_penduduk,k.nama_kelurahan, t.nama_tps FROM penduduk p " +
                     "JOIN kelurahan k ON p.kode_kelurahan = k.kode_kelurahan JOIN tps t ON p.kode_tps = t.kode_tps";

            return server.eksekusiQuery(Query);
        }

        public bool Apakahada(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM penduduk WHERE kode_penduduk='" + kode + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int savedata()
        {
            int result = -1;
            Query = "Insert INTO penduduk values('" + kode_penduduk + "','" + nama_penduduk + "','" + nik + "','" + alamat_penduduk + "','" 
                + kode_kelurahan + "','" + kode_tps + "')";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan");
                }
            }
            catch (Exception e) { }
            return result;
        }

        public int updatedata(string kode)
        {
            int result = -1;
            Query = "UPDATE penduduk SET nama_penduduk = '" + nama_penduduk + "' , nik = '" + nik + "' , alamat_penduduk = '" + alamat_penduduk + "'," +
                " kode_kelurahan = '" + kode_kelurahan + "', kode_tps = '" + kode_tps + "'  WHERE kode_penduduk = '" + kode + "'";
            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan");
                }
            }
            catch (Exception e) { }
            return result;
        }

        public int hapusdata(string kode)
        {
            int result = -1;
            Query = "DELETE FROM penduduk WHERE kode_penduduk='" + kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menghapus");
                }
            }
            catch (Exception e) { }
            return result;
        }

        public string buatkode()
        {
            string kode = "";
            int nilai = 0;

            Query = "SELECT IFNULL(MAX(kode_penduduk),0) + 1 AS kode FROM penduduk";
            temp = server.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "0" + nilai.ToString();
                }
                else if (nilai >= 10 && nilai < 100)
                {
                    kode = nilai.ToString();
                }
            }
            return kode;
        }

        public DataTable searchdata(string nama, string kode, string tps)
        {
            Query = "SELECT p.kode_penduduk, p.nama_penduduk, p.nik, p.alamat_penduduk, k.nama_kelurahan, t.nama_tps FROM penduduk p " +
                    "JOIN kelurahan k ON p.kode_kelurahan = k.kode_kelurahan JOIN tps t ON p.kode_tps = t.kode_tps " +
                    "WHERE p.nama_penduduk LIKE '%" + nama + "%' OR k.nama_kelurahan LIKE '%" + kode + "%' OR t.nama_tps LIKE '%" +tps+ "%'";

            return server.eksekusiQuery(Query);
        }
    }
} 
