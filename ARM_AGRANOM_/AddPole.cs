﻿using System;
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
    public partial class AddPole : Form
    {
        public AddPole()
        {
            InitializeComponent();
        }

        private void AddPole_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Pole". При необходимости она может быть перемещена или удалена.
            this.poleTableAdapter.Fill(this.aRM_AGRONOMDataSet.Pole);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Vid". При необходимости она может быть перемещена или удалена.
            this.vidTableAdapter.Fill(this.aRM_AGRONOMDataSet.Vid);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet.Naseln". При необходимости она может быть перемещена или удалена.
            this.naselnTableAdapter.Fill(this.aRM_AGRONOMDataSet.Naseln);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            SqlConnection aConn = new SqlConnection("Data Source=STEM;Initial Catalog=ARM_AGRONOM;Integrated Security=True");
            aConn.Open();
            SqlCommand bComm = new SqlCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Pole ([Название],[Размер],[id_nasel],[id_vid]) VALUES ('" + textBox1.Text.ToString() + "','"+textBox2.Text.ToString()+"','"+(comboBox1.SelectedIndex+1)+"','"+(comboBox2.SelectedIndex+1) +"')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
            aConn.Close();
            this.poleTableAdapter.Fill(this.aRM_AGRONOMDataSet.Pole);
        }
    }
}
