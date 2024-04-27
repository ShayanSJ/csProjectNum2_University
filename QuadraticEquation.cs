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
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
            PerCal percal = new PerCal();
            liveDate.Text = percal.Get();
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textA = textBoxA.Text;
            string textB = textBoxB.Text;
            string textC = textBoxC.Text;

            try
            {
                double doubleA = Double.Parse(textA);
                double doubleB = Double.Parse(textB);
                double doubleC = Double.Parse(textC);
                double doubleX = (((-doubleB) + (Math.Sqrt(doubleB * doubleB - ((doubleA * doubleC) * 4)))) / ((doubleA) * 2));
                textBox4.Text = double.IsNaN(doubleX) ? "Not an Quatric Equation!" : doubleX.ToString();

            }
            catch
            {
                textBox4.Text = "Input Error!";
            }




            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            form1.Show();
            this.Close();
        }

        private void randomNumberGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator form3 = new RandomNumberGenerator();
            form3.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            liveClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
