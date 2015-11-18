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
    public partial class VidPochvy : Form
    {
        public VidPochvy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
            aConn.Open();
            SqlCommand bComm = new SqlCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Vid ([Название]) VALUES ('" + textBox1.Text.ToString()+"')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
            aConn.Close();
            this.vidTableAdapter.Fill(this.aRM_AGRONOMDataSet11.Vid);
        }

        private void VidPochvy_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet11.Vid". При необходимости она может быть перемещена или удалена.
            this.vidTableAdapter.Fill(this.aRM_AGRONOMDataSet11.Vid);

        }
    }
}
