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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlCommand selectCommand =
                new SqlCommand(
                    "SELECT * FROM Admins WHERE Admin='" + textBox1.Text + "' and Password='" + textBox2.Text +
                    "'", myConn);
            SqlDataReader reader;
            myConn.Open();
            toolStrip1.Text = "Подключенно!!!";
            reader = selectCommand.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Вход выполнен!", "Выполнено!");
                toolStrip1.Text = "Логин и пароль верные";
                AdminForm fr = new AdminForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                toolStrip1.Text = "Логин и пароль неверные";
            }

            myConn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm a = new RegistrationForm();
            a.ShowDialog();
        }
    }
}
