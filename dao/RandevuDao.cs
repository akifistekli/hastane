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
    class RandevuDao : GenericDao
    {
        static NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["hastane_oto"].ConnectionString);

        //public static DataTable getAll(string table)
        //{
        //    try
        //    {
        //        DataSet dSet = new DataSet();
        //        DataTable dTable = new DataTable();

        //        conn.Open();
        //        string SQL = "SELECT * FROM " + table + ";";
        //        NpgsqlDataAdapter dAdapter = new NpgsqlDataAdapter(SQL, conn);
        //        dAdapter.Fill(dSet);
        //        dTable = dSet.Tables[0];
        //        return dTable;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        public static DataTable insert(HastaneOto.model.Randevu randevu)
        {
            try
            {
                conn.Open();

                string sql = "INSERT INTO public.randevu VALUES (@id, @tc, @adi, @telefon, @hastane, @bolum, @doktor, @tarih);";
                NpgsqlCommand akf = new NpgsqlCommand(sql, conn);
                akf.Parameters.AddWithValue("@id", randevu.ID);
                akf.Parameters.AddWithValue("@tc", randevu.hastaTC);
                akf.Parameters.AddWithValue("@adi", randevu.hastaAdi);
                akf.Parameters.AddWithValue("@telefon", randevu.hastaTel);
                akf.Parameters.AddWithValue("@hastane", randevu.hastane);
                akf.Parameters.AddWithValue("@bolum", randevu.bolum);
                akf.Parameters.AddWithValue("@doktor", randevu.doktor);
                akf.Parameters.AddWithValue("@tarih", Convert.ToDateTime(randevu.tarih));
                akf.ExecuteNonQuery();

                MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.");

                return getAll("randevu");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt Ekleme Başarısız!" + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getById(int id)
        {
            try
            {
                DataSet dSet = new DataSet();
                DataTable dTable = new DataTable();

                conn.Open();
                string SQL = "SELECT * FROM "  + ";";
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
