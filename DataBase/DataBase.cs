using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataBase
{
    public class DataBase
    {
        public SqlConnection connect = null;
        private string connectionString = "Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True";
        public void OpenConnection()
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public void Deletel(int id)
        {
            string sql = string.Format("DELETE FROM Grups WHERE id_grups = '{0}'",id);
            using (SqlCommand cmd = new SqlCommand(sql,this.connect))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ошибка!","ERROR!!!");
                }
            }
        }
        public DataTable SelectOcenciFiltr(string value1, string value2)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Grups.Name, Discipliny.Vid_discipline, [Type].Naimenovanie, Specialnost.Vid_specialnosti, Osnavnaya.Otmetka,Students.FIO " +
                          " FROM Osnavnaya, Grups, Discipliny, Specialnost, [Type],Students" +
                          " WHERE Osnavnaya.Id_discep = Discipliny.Id_discep AND Osnavnaya.id_students = Students.id_students AND Osnavnaya.id_specialnost = Specialnost.Id_specialnost AND Osnavnaya.id_tip = [Type].id_tip AND Grups.id_grups = '" + value1 + "' AND Discipliny.id_discep = '" + value2 + "'");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }

        public DataTable SetOKR(string a, string value2)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Students.FIO,Grups.Name, Discipliny.Vid_discipline, [Type].Naimenovanie, Osnavnaya.Otmetka"
 + " FROM Students, Osnavnaya, Grups, Discipliny, [Type] "
 + " WHERE Osnavnaya.Id_discep = Discipliny.Id_discep AND Osnavnaya.id_students = Students.id_students AND Osnavnaya.id_tip = [Type].id_tip AND Students.id_grups = Grups.id_grups"
 + " AND Grups.Name = '" + a + "' AND Discipliny.Vid_discipline = '" + value2 + "' AND [Type].Naimenovanie = 'ОКР'");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SetLr(int value1, int value2)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Students.FIO,Grups.Name, Discipliny.Vid_discipline, [Type].Naimenovanie, Osnavnaya.Otmetka"
 + " FROM Students, Osnavnaya, Grups, Discipliny, [Type] "
 + " WHERE Osnavnaya.Id_discep = Discipliny.Id_discep AND Osnavnaya.id_students = Students.id_students AND Osnavnaya.id_tip = [Type].id_tip AND Students.id_grups = Grups.id_grups"
 + " AND Grups.id_grups = '" + value1 + "' AND Discipliny.id_discep = '" + value2 + "' AND [Type].Naimenovanie = 'Л.Р.'");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SetOtmetka(int value1, int value2)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Students.FIO,Grups.Name, Discipliny.Vid_discipline, [Type].Naimenovanie, Osnavnaya.Otmetka"
 + " FROM Students, Osnavnaya, Grups, Discipliny, [Type] "
 + " WHERE Osnavnaya.Id_discep = Discipliny.Id_discep AND Osnavnaya.id_students = Students.id_students AND Osnavnaya.id_tip = [Type].id_tip AND Students.id_grups = Grups.id_grups"
 + " AND Grups.id_grups = '" + value1 + "' AND Discipliny.id_discep = '" + value2 + "' AND [Type].Naimenovanie = 'Оценка'");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SetPraktiche(int value1, int value2)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Students.FIO,Grups.Name, Discipliny.Vid_discipline, [Type].Naimenovanie, Osnavnaya.Otmetka"
 + " FROM Students, Osnavnaya, Grups, Discipliny, [Type] "
 + " WHERE Osnavnaya.Id_discep = Discipliny.Id_discep AND Osnavnaya.id_students = Students.id_students AND Osnavnaya.id_tip = [Type].id_tip AND Students.id_grups = Grups.id_grups"
 + " AND Grups.id_grups = '" + value1 + "' AND Discipliny.id_discep = '" + value2 + "' AND [Type].Naimenovanie = 'Практическая'");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }

    
    }
}
