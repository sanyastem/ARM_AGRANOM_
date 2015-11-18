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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
                aConn.Open();
                SqlCommand bComm = new SqlCommand();
                bComm.Connection = aConn;
                bComm.CommandText = "INSERT INTO Admins ([Admin],[Password]) VALUES ('" + textBox3.Text + "','" + textBox1.Text + "')";
                bComm.ExecuteNonQuery();
                bComm.Connection = aConn;
                aConn.Close();
                //this.adminsTableAdapter.Fill(this.teacherProjectDataSet.Admins);

                MessageBox.Show("Вы зарегистрировались!", "Успешно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароль не совпадает!", "ERROR!!!");
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
