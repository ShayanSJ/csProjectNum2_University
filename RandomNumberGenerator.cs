using secondProjectMrAmani1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondProjectMrAmani
{
    public partial class RandomNumberGenerator : Form
    {
        public RandomNumberGenerator()
        {
            InitializeComponent();
            PerCal percal = new PerCal();
            liveDate.Text = percal.Get();
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void quadraticEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuadraticEquation form2 = new QuadraticEquation();
            form2.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            form1.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewRand newRand = new NewRand();
            try
            {
                int min = int.Parse(textBoxMin.Text);
                int max = int.Parse(textBoxMax.Text);


                if(min > max)
                {
                    int mem;
                    mem = max; max = min; min = mem;
                    textBoxMax.Text = max.ToString();
                    textBoxMin.Text = min.ToString();
                }

                if (max > 0 && min > 0) { textBoxResult.Text = newRand.Next(min, max).ToString(); }
                else if (max > 0 && min <= 0) { textBoxResult.Text = newRand.Next(max).ToString(); }
                else { textBoxResult.Text = newRand.Next().ToString(); }

            }
            catch { textBoxResult.Text = "Input Error!"; }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
