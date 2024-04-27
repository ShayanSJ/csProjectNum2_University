using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using secondProjectMrAmani1;

namespace secondProjectMrAmani
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            PerCal percal = new PerCal();
            liveDate.Text = percal.Get();
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuadraticEquation form2 = new QuadraticEquation();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator form3 = new RandomNumberGenerator();
            form3.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quadraticEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuadraticEquation form2 = new QuadraticEquation();
            this.Hide();
            form2.Show();
        }

        private void randomNumberGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator form3 = new RandomNumberGenerator();
            this.Hide();
            form3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
