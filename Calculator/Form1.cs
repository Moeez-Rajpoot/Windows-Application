using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a + b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }
    }
}
