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
    public partial class Form2 : Form
    {
        public Form2()


        {
            InitializeComponent();

            this.ControlBox = false;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 3000; // Update every 3 seconds
            timer1.Tick += timer1_Tick;

            // Set up the progress bar
            progressBar1.Maximum = 100; // Assuming 100% completion
            progressBar1.Minimum = 0;

            this.KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxValue = progressBar1.Maximum;
            int incrementPerTick = maxValue / 100;

            // Update the progress bar value dynamically
            progressBar1.Value += incrementPerTick;

            // Check if the progress is complete
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop(); // Stop the timer when complete
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Start the timer in the form load
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
