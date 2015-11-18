using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yore;

namespace ARM_AGRANOM_
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_AGRONOMDataSet2.Oblast". При необходимости она может быть перемещена или удалена.
            this.oblastTableAdapter.Fill(this.aRM_AGRONOMDataSet2.Oblast);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataBase db = new DataBase();
            dataGridView1.DataSource = db.SetAll();
            dataGridView1.Refresh();
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            dataGridView1.DataSource = db.SetAdminAll(comboBox2.SelectedIndex+7);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNaselen a = new AddNaselen();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VidPochvy a = new VidPochvy();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPole a = new AddPole();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCulture a = new AddCulture();
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddInformation a = new AddInformation();
            a.ShowDialog();
        }
    }
}
