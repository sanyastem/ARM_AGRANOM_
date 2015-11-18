using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Yore
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
        public DataTable SelectGrodno()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+" FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+" Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='7' AND Pole.id_nasel=Naseln.id_nasel AND Vid.id_vid=Pole.id_vid "
+" AND Pole.id_pole=Osnovnoe.id_pole AND Kulture.id_kult=Osnovnoe.id_kultr");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }

        public DataTable SelectMinsk()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+" FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+" Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='8' AND Pole.id_vid=Vid.id_vid AND Pole.id_nasel=Naseln.id_nasel AND Osnovnoe.id_kultr=Kulture.id_kult"
+" AND Osnovnoe.id_pole=Pole.id_pole");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SelectBrest()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+ " FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+ " Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='9' AND Pole.id_nasel=Naseln.id_nasel AND Vid.id_vid=Pole.id_vid "
+ " AND Pole.id_pole=Osnovnoe.id_pole AND Kulture.id_kult=Osnovnoe.id_kultr");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SelectGomel()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+ " FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+ " Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='10' AND Pole.id_nasel=Naseln.id_nasel AND Vid.id_vid=Pole.id_vid "
+ " AND Pole.id_pole=Osnovnoe.id_pole AND Kulture.id_kult=Osnovnoe.id_kultr");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SelectVitebsk()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+ " FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+ " Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='11' AND Pole.id_nasel=Naseln.id_nasel AND Vid.id_vid=Pole.id_vid "
+ " AND Pole.id_pole=Osnovnoe.id_pole AND Kulture.id_kult=Osnovnoe.id_kultr");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SelectMogilev()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+ " FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe"
+ " Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast='12' AND Pole.id_nasel=Naseln.id_nasel AND Vid.id_vid=Pole.id_vid "
+ " AND Pole.id_pole=Osnovnoe.id_pole AND Kulture.id_kult=Osnovnoe.id_kultr");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            CloseConnection();
            return dt;
        }
        public DataTable SetAll()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string sql = ("SELECT Oblast.Название,Naseln.Название,Pole.Название,Vid.Название,Pole.Размер,Kulture.Название,Osnovnoe.Урожай,Osnovnoe.God"
+" FROM Oblast,Naseln,Pole,Vid,Kulture,Osnovnoe "
+" Where Oblast.id_oblast=Naseln.id_oblast AND Naseln.id_oblast=Oblast.id_oblast AND Pole.id_vid=Vid.id_vid AND Pole.id_nasel=Naseln.id_nasel AND Osnovnoe.id_kultr=Kulture.id_kult"
+" AND Osnovnoe.id_pole=Pole.id_pole");
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
