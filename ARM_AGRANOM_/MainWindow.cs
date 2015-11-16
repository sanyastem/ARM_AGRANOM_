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
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            formsShowing.ShowDialog();
        }     
    }
}
