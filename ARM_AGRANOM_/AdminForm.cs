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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataBase db = new DataBase();
            dataGridView1.DataSource = db.SetAll();
            dataGridView1.Refresh();
        }
    }
}
