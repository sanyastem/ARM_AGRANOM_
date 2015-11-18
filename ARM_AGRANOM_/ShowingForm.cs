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
    public partial class ShowingForm : Form
    {
        public ShowingForm()
        {
            InitializeComponent();
        }
        public ShowingForm(int i)
        {
            InitializeComponent();
            DataBase a = new DataBase();
            switch (i)
            {
                case 1:
                    DataBase db = new DataBase();
                    dataGridView1.DataSource = db.SelectGrodno();
                    dataGridView1.Refresh();
                    break;
                case 2: 
                    DataBase db1 = new DataBase();
                    dataGridView1.DataSource = db1.SelectMinsk();
                    dataGridView1.Refresh();
                    break;
                case 3:
                    DataBase db2 = new DataBase();
                    dataGridView1.DataSource = db2.SelectMogilev();
                    dataGridView1.Refresh();
                    
                    break;
                case 4:
                    DataBase db3 = new DataBase();
                    dataGridView1.DataSource = db3.SelectVitebsk();
                    dataGridView1.Refresh();
                    
                    break;
                case 5:
                    DataBase db4 = new DataBase();
                    dataGridView1.DataSource = db4.SelectGomel();
                    dataGridView1.Refresh();
                    
                    break;
                case 6:
                    DataBase db5 = new DataBase();
                    dataGridView1.DataSource = db5.SelectBrest();
                    dataGridView1.Refresh();
                    
                    break;
            }
        }
        private void ShowingForm_Load(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ShowDataTabele(int i)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
