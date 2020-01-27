using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // this is for a series circuit with 2 resistors 
            double R1, R2;
            //i have added a try/catch in order to notify the user that a pice of information is missing 
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R2");
                R2 = 0.0;
            }

            double resistance = R1 + R2;
            textBox3.Text = "Rt=" + resistance+"Ω";
            // this part works out the total resistance for the circuit and displayes the answer with units 






    }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // this is to calculate the total resistance for a series circuit with 3 resistors 
            double R1, R2, R3;
            //i have added a try/catch in order to notify the user that a pice of information is missing 
            try
            {
                R1 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R2");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R3");
                R3 = 0.0;
            }  // this part works out the total resistance for the circuit and displayes the answer with units



            double resistance = R1 + R2 + R3;
            textBox7.Text = "Rt=" + resistance + "Ω";
        }

        private void Button3_Click(object sender, EventArgs e)
        {   //this works out the total resistance fort a parralel circuit with 2 resisters 
            double R1, R2;
            //i have added a try/catch in order to notify the user that a pice of information is missing 
            try
            {
                R1 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R2");
                R2 = 0.0;
            }

            double resistance = 1 / ((1 / R1) + (1 / R2));
            textBox10.Text = "Rt=" + resistance + "Ω";
            // this part works out the total resistance for the circuit and displayes the answer with units
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        { // this is for a parralel circuit with 3 resistorse 
                        double R1, R2, R3;
            //i have added a try/catch in order to notify the user that a pice of information is missing 
            try
            {
                R1 = double.Parse(textBox11.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox12.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R2");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox13.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input R3");
                R3 = 0.0;
            }
            double resistance = 1 / ((1 / R1) + (1 / R2) + (1/R3));
            textBox14.Text = "Rt=" + resistance+ "Ω";
            // this part works out the total resistance for the circuit and displayes the answer with units

        }
    }
}
