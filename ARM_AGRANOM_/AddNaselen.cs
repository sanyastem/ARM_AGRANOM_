using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_AGRANOM_
{
    public partial class AddNaselen : Form
    {
        public AddNaselen()
        {
            InitializeComponent();
        }

        private void AddNaselen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet11.Naseln". При необходимости она может быть перемещена или удалена.
            this.naselnTableAdapter.Fill(this.aRM_AGRONOMDataSet11.Naseln);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet2.Oblast". При необходимости она может быть перемещена или удалена.
            this.oblastTableAdapter.Fill(this.aRM_AGRONOMDataSet2.Oblast);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
            aConn.Open();
            SqlCommand bComm = new SqlCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Naseln ([Название],[id_oblast]) VALUES ('" + textBox1.Text.ToString() + "','" +
                                comboBox1.SelectedIndex+7 + "')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
            aConn.Close();
            this.naselnTableAdapter.Fill(this.aRM_AGRONOMDataSet11.Naseln);
        }
    }
}
