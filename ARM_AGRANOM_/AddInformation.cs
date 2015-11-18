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
    public partial class AddInformation : Form
    {
        public AddInformation()
        {
            InitializeComponent();
        }

        private void AddInformation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Osnovnoe". При необходимости она может быть перемещена или удалена.
            this.osnovnoeTableAdapter.Fill(this.aRM_AGRONOMDataSet.Osnovnoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Kulture". При необходимости она может быть перемещена или удалена.
            this.kultureTableAdapter.Fill(this.aRM_AGRONOMDataSet.Kulture);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Pole". При необходимости она может быть перемещена или удалена.
            this.poleTableAdapter.Fill(this.aRM_AGRONOMDataSet.Pole);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
            aConn.Open();
            SqlCommand bComm = new SqlCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Osnovnoe ([Урожай],[id_pole],[id_kultr],[God]) VALUES ('" + textBox1.Text.ToString() +"','"+(comboBox1.SelectedIndex+1)+"','"+(comboBox2.SelectedIndex+1)+"','"+dateTimePicker1.Value.ToShortDateString().ToString()+"')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
            aConn.Close();
            this.osnovnoeTableAdapter.Fill(this.aRM_AGRONOMDataSet.Osnovnoe);
        }
    }
}
