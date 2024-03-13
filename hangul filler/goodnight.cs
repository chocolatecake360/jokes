using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangul_filler
{
    public partial class goodnight : Form
    {
        public goodnight()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enough enough = new enough();
            enough.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
