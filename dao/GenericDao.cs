using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOto.dao
{
    class GenericDao
    {
        static NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["hastane_oto"].ConnectionString);

        public static DataTable getAll(string table)
        {
            try
            {
                DataSet dSet = new DataSet();
                DataTable dTable = new DataTable();

                conn.Open();
                string SQL = "SELECT * FROM " + table + ";";
                NpgsqlDataAdapter dAdapter = new NpgsqlDataAdapter(SQL, conn);
                dAdapter.Fill(dSet);
                dTable = dSet.Tables[0];
                return dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
