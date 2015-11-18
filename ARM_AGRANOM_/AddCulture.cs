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
    public partial class AddCulture : Form
    {
        public AddCulture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
            aConn.Open();
            SqlCommand bComm = new SqlCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Kulture ([Название]) VALUES ('" + textBox1.Text.ToString() + "')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
            aConn.Close();
            this.kultureTableAdapter.Fill(this.aRM_AGRONOMDataSet.Kulture);
        }

        private void AddCulture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Kulture". При необходимости она может быть перемещена или удалена.
            this.kultureTableAdapter.Fill(this.aRM_AGRONOMDataSet.Kulture);

        }
    }
}
