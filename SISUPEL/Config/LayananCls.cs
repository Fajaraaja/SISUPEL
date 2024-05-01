using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using ClassLibrary1;
using System.Data;

namespace SISUPEL.Config
{
    internal class LayananCls:ConfigCls
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdp;


        //Constractor
        public LayananCls()
        {
            mCon = new MySqlConnection(Bacafile.ambildata("konfig.txt"));
            mCom = new MySqlCommand();
            mAdp = new MySqlDataAdapter();
        }


        void bukakoneksi()
        {
            try
            {
                if (mCon.State == ConnectionState.Closed)
                {
                    mCon.Open();
                }
            }
            catch (Exception e)
            {

            }
        }

        void tutupkoneksi()
        {
            mCon.Close();
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();

            try
            {
                bukakoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                mAdp.Fill(result);
            }
            catch (Exception e) { }
            finally
            {
                tutupkoneksi();
            }
            return result;
        }

        public override int eksekusiNonQuery(string query)
        {
            int result = -1;

            try
            {
                bukakoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                result = mCom.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                tutupkoneksi();
            }
            return result;
        }
    }
}
