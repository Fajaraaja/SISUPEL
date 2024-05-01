using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SISUPEL.Models
{
    using Config;
    internal class kelurahanCls
    {
        private string kode_kelurahan;
        private string nama_kelurahan;

        LayananCls server;
        DataTable temp;
        string Query;

        public kelurahanCls()
        {
            kode_kelurahan = "";
            nama_kelurahan = "";
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        public string setkode_kelurahan
        {
            set
            {
                kode_kelurahan = value;
            }
        }

        public string setnama_kelurahan
        {
            set
            {
                nama_kelurahan = value;
            }
        }

        public DataTable tampildata()
        {
            Query = "SELECT * FROM kelurahan";
            return server.eksekusiQuery(Query);
        }

        public bool apakahada(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM kelurahan WHERE kode_kelurahan='" + kode + "'";
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

            Query = "SELECT IFNULL(MAX(kode_kelurahan),0) + 1 AS kode FROM kelurahan";
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
            Query = "Insert INTO kelurahan values('" + kode_kelurahan + "','" + nama_kelurahan + "')";

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
            Query = "DELETE FROM kelurahan WHERE kode_kelurahan='" + kode + "'";

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

        public int updatedata(string kode, string nama)
        {
            int result = -1;
            Query = "UPDATE kelurahan SET nama_kelurahan='" + nama + "' where kode_kelurahan='" + kode + "'";

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

        public DataTable searchdata(string nama)
        {

            Query = "SELECT * FROM kelurahan WHERE nama_kelurahan LIKE'%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public string ambilkodeDgnama(string nama)
        {
            string kode = "";

            Query = "SELECT kode_kelurahan FROM kelurahan WHERE " + " nama_kelurahan='" + nama + "'";
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

    }


}
