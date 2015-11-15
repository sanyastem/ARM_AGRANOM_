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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {   if(){
            AdminWindow mainform = new AdminWindow();
            mainform.Show();
        }
        }     
    }
}
