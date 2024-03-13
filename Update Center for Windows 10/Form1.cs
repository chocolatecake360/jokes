using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update_Center_for_Windows_10
{
    public partial class Form1 : Form
    {
        Form2 nextpage;
        public Form1(
            
            )
        {
            InitializeComponent();
            this.ControlBox = false;
            nextpage = new Form2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide(); 
            nextpage.Show();
        }
    }
}
