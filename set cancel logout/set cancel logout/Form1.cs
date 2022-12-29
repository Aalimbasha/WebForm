using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace set_cancel_logout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lbl.Text = "Welcome to windows";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            lbl.Text = "Cancelled Successfully";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            lbl.Text = "Log Out Successfully";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            lbl.Text = "Hello World";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
