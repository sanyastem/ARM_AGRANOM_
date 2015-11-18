using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_AGRANOM_
{
    public partial class MainWindow : Form
    {


        ShowingForm formsShowing = new ShowingForm();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {   
            AdminWindow mainform = new AdminWindow();
            mainform.Show();
            this.Hide();
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing1 = new ShowingForm(3);
            formsShowing1.ShowDialog();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing2 = new ShowingForm(4);
            formsShowing2.ShowDialog();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing3 = new ShowingForm(1);
            formsShowing3.ShowDialog();
      
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing4 = new ShowingForm(2);
            formsShowing4.ShowDialog();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing5 = new ShowingForm(6);
            formsShowing5.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowingForm formsShowing6 = new ShowingForm(5);
            formsShowing6.ShowDialog();
            
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            ShowingForm formsShowing = new ShowingForm();
            formsShowing.ShowDialog();
            formsShowing.ShowDataTabele(4);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
