using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMart
{
    public partial class Form1 : Form
    {
        int items = 0;
        int totalprice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                items++;
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                items++;
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                
                numericUpDown2.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                items++;
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                items++;
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {

               
                numericUpDown4.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                items++;
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                items++;
                numericUpDown6.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                
                numericUpDown6.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(items >0)
            {
                panel1.Visible = true;
                if (checkBox1.Checked)
                {
                    label7.Visible = true;
                    label7.Text = "Apple";
                    label13.Visible = true;
                    label13.Text = numericUpDown1.Value.ToString();
                    label19.Visible = true;
                    label19.Text = comboBox1.Text;
                    totalprice = (int)(totalprice + (numericUpDown1.Value * int.Parse(comboBox1.Text)));
                }
                if (checkBox2.Checked)
                {
                    label8.Visible = true;
                    label8.Text = "Orange";
                    label14.Visible = true;
                    label14.Text = numericUpDown2.Value.ToString();
                    label20.Visible = true;
                    label20.Text = comboBox2.Text;
                    totalprice = (int)(totalprice + (numericUpDown2.Value * int.Parse(comboBox2.Text)));
                }
                if (checkBox3.Checked)
                {
                    label9.Visible = true;
                    label9.Text = "Mango";
                    label15.Visible = true;
                    label15.Text = numericUpDown3.Value.ToString();
                    label21.Visible = true;
                    label21.Text = comboBox3.Text;
                    totalprice = (int)(totalprice + (numericUpDown3.Value * int.Parse(comboBox3.Text)));
                }
                if (checkBox4.Checked)
                {
                    label10.Visible = true;
                    label10.Text = "Peach";
                    label16.Visible = true;
                    label16.Text = numericUpDown4.Value.ToString();
                    label22.Visible = true;
                    label22.Text = comboBox4.Text;
                    totalprice = (int)(totalprice + (numericUpDown4.Value * int.Parse(comboBox4.Text)));
                }
                if (checkBox5.Checked)
                {
                    label11.Visible = true;
                    label11.Text = "PineApple";
                    label17.Visible = true;
                    label17.Text = numericUpDown5.Value.ToString();
                    label23.Visible = true;
                    label23.Text = comboBox5.Text;
                    totalprice = (int)(totalprice + (numericUpDown5.Value * int.Parse(comboBox5.Text)));
                }
                if (checkBox6.Checked)
                {
                    label12.Visible = true;
                    label12.Text = "Strawberry";
                    label18.Visible = true;
                    label18.Text = numericUpDown6.Value.ToString();
                    label24.Visible = true;
                    label24.Text = comboBox6.Text;
                    totalprice = (int)(totalprice + (numericUpDown6.Value * int.Parse(comboBox6.Text)));
                }
                if (radioButton1.Checked)
                {
                    label25.Visible = true;
                    label25.Text = "Bag";
                    label26.Visible = true;
                    label26.Text = "1";
                    label27.Visible = true;
                    label27.Text = "20";
                    totalprice = totalprice + 20;
                }
                if(radioButton2.Checked)
                {
                    //nothing;
                }

                label29.Text= totalprice.ToString();
                label31.Text= DateTime.Now.ToString();
                totalprice = 0;


            }
            else
            {
                MessageBox.Show("No Item Selected !");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            panel1.Enabled = false;
            panel1.Visible = false;
            radioButton1.Checked =false;
            radioButton2.Checked = false;
            items = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 5;
            numericUpDown1.Minimum=1;
            numericUpDown1.Increment = 2;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 5;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Increment = 2;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = 5;
            numericUpDown3.Minimum = 1;
            numericUpDown3.Increment = 2;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Maximum = 5;
            numericUpDown4.Minimum = 1;
            numericUpDown4.Increment = 2;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.Maximum = 5;
            numericUpDown5.Minimum = 1;
            numericUpDown5.Increment = 2;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown6.Maximum = 5;
            numericUpDown6.Minimum = 1;
            numericUpDown6.Increment = 2;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
