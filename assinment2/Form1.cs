using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace assinment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void V_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = u.Text;
                double height = double.Parse(h.Text);
                double length = double.Parse(l.Text);
                double width = double.Parse(w.Text);
                double volume = height * length * width;
                label4.Text = "volume = " + volume + input + "^3";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void w_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input = u.Text;
                double height = double.Parse(h.Text);
                double length = double.Parse(l.Text);
                double width = double.Parse(w.Text);
                double sa = 2 * (length * height + length * width + width * height);
                label5.Text = "Sufrace area = " + sa + input + "^2";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string unit = u2.Text;
                double radius = double.Parse(r.Text);
                double S_volume = 4 * 3.14159 * radius * radius * radius / 3;
                label9.Text = "Volume = " + S_volume + unit + "^3";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string unit = u2.Text;
                double radius = double.Parse(r.Text);
                double S_sa = 4 * 3.14159 * radius * radius;
                label10.Text = "Surface area = " + S_sa + unit + "^2";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "Volume = ";
            label5.Text = "Surface area = ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = "Volume = ";
            label10.Text = "Surface area = ";
        }

        private void u76_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string unit = u3.Text;
                double C_radius = double.Parse(r2.Text);
                double C_height = double.Parse(h2.Text);
                double C_volume = 1*3.14159*C_radius*C_radius*C_height/3;
                label13.Text = "Volume = " + C_volume + unit + "^3";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string unit = u3.Text;
                double C_radius = double.Parse(r2.Text);
                double C_height = double.Parse(h2.Text);
                double C_sa = 3.14159 * C_radius *( C_radius + Math.Sqrt(C_radius * C_radius + C_height * C_height));
                label14.Text = "Surface area = " + C_sa + unit + "^2";
            }
            catch
            {
                MessageBox.Show("!ERROR! what did you think was going to happen?");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label13.Text = "Volume = ";
            label14.Text = "Surface area = ";
        }
    }
}
