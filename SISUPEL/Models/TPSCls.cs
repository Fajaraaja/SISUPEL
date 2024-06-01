using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SISUPEL.Models
{

    using Config;
    internal class TPSCls
    {
        private string kode_tps;
        private string kode_kelurahan;
        private string nama_tps;
        private string alamat_tps;

        LayananCls server;
        DataTable temp;
        string Query;

        public TPSCls()
        {
            kode_tps = "";
            kode_kelurahan = "";
            nama_tps = "";
            alamat_tps = "";
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
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

        public string setnama_tps
        {
            set
            {
                nama_tps = value;
            }
        }

        public string setalamat_tps
        {
            set
            {
                alamat_tps = value;
            }
        }

        public DataTable tampildata()
        {
            Query = "SELECT a.kode_tps, a.nama_tps, a.alamat_tps, b.nama_kelurahan FROM tps a, kelurahan b WHERE a.kode_kelurahan = b.kode_kelurahan";
            return server.eksekusiQuery(Query);
        }

        public bool apakahada(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM tps WHERE kode_tps='" + kode + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string buatkode()
        {
            string kode = "";
            int nilai = 0;

            Query = "SELECT IFNULL(MAX(kode_tps),0) + 1 AS kode FROM tps";
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

        public int tambahdata()
        {
            int result = -1;
            Query = "Insert INTO tps values('" + kode_tps + "','" + nama_tps + "','" + alamat_tps + "','" +kode_kelurahan + "')";

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
            Query = "UPDATE tps SET nama_tps = '" + nama_tps + "' , alamat_tps = '" + alamat_tps + "', kode_kelurahan = '" + kode_kelurahan + "'  WHERE kode_tps = '" + kode + "'";

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
            Query = "DELETE FROM tps WHERE kode_tps='" + kode + "'";

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

        public string ambilkodeDgnama(string nama)
        {
            string kode = "";

            Query = "SELECT kode_tps FROM tps WHERE " + " nama_tps='" + nama + "'";
            temp = server.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    kode = data[0].ToString();
                }
            }
            return kode;
        }
        public DataTable searchdata(string nama, string kelurahan)
        {

            Query = "SELECT t.kode_tps, t.nama_tps, k.nama_kelurahan FROM tps t JOIN kelurahan k " +
                    "ON t.kode_kelurahan = k.kode_kelurahan WHERE t.nama_tps LIKE '%" + nama + "%' OR k.nama_kelurahan " +
                    "LIKE '%" + kelurahan + "%'";
            return server.eksekusiQuery(Query);
        }
    }
}
