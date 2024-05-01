using SISUPEL.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISUPEL.Models
{
    using Config;
    internal class LoginCls
    {
        LayananCls server;
        DataTable temp; string Query;

        public LoginCls()
        {
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        public bool ApakahAda(string uid, string pwd)
        {
            bool cek = false;
            Query = "SELECT * FROM pengguna WHERE user_id='" + uid + "' and " + "password='" + pwd + "'";
            temp = server.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string GetRole(string uid)
        {
            string role = string.Empty;
            Query = "SELECT role FROM pengguna WHERE user_id='" + uid + "'";
            temp = server.eksekusiQuery(Query);

            try
            {
                if (temp.Rows.Count > 0)
                {
                    // Mengambil role dari baris pertama (indeks 0)
                    role = temp.Rows[0]["role"].ToString();
                }
                else
                {
                    throw new Exception("Role tidak ditemukan untuk pengguna dengan ID " + uid);
                }
            }
            catch (Exception ex)
            {
                // Tangkap exception dan lakukan penanganan khusus di sini
                Console.WriteLine("Error: " + ex.Message);
            }
            return role;
        }
    }
}
