using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;
using System.Data;
using System.Windows.Forms;


namespace HastaneOto.dao
{
    class HastaDao : GenericDao
    {
        static NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["hastane_oto"].ConnectionString);

        //public static DataTable getAll(string table)
        //{
        //    try
        //    {
        //        DataSet dSet = new DataSet();
        //        DataTable dTable = new DataTable();

        //        if (conn == null)
        //        {
        //            conn.Open();
        //        }
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

        public static DataTable insert(HastaneOto.model.Hasta hasta)
        {
            try
            {
                conn.Open();
                string sorgu = "INSERT INTO public.hasta VALUES (@tckn, @adi, @soyadi, @cinsiyet, @dogunyeri, @dogumtarihi, @telefon, @eposta, @parola);";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, conn);
                komut.Parameters.AddWithValue("@tckn", hasta.TCKN);
                komut.Parameters.AddWithValue("@adi", hasta.adi);
                komut.Parameters.AddWithValue("@soyadi", hasta.soyadi);
                komut.Parameters.AddWithValue("@cinsiyet", hasta.cinsiyet);
                komut.Parameters.AddWithValue("@dogunyeri", hasta.dogumYeri);
                komut.Parameters.AddWithValue("@dogumtarihi", Convert.ToDateTime(hasta.dogumTarihi));
                komut.Parameters.AddWithValue("@telefon", hasta.telefon);
                komut.Parameters.AddWithValue("@eposta", hasta.eposta);
                komut.Parameters.AddWithValue("@parola", hasta.parola);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.");

                return getAll("hasta");
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
    }
}
