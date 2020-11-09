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
            try//This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string input = u.Text;//This takes the units inputted by the user into the text box 'u' as a string and creates a variable 'input'. 
                double height = double.Parse(h.Text);//Here I am creating a variable 'height' from what the user inputs into the textbox 'h' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double length = double.Parse(l.Text);//Here I am creating a variable 'length' from what the user inputs into the textbox 'l' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double width = double.Parse(w.Text);//Here I am creating a variable 'width' from what the user inputs into the textbox 'w' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double volume = height * length * width;//Here I am creating a variable 'volume' which consists of the calculation for volume of a cuboid using the variables 'height', 'length', and 'width'. 
                label4.Text = "Volume = " + volume + input + "^3";//Here I am editing the text in label4 so that it displays 'Volume =' and the variable 'volume' which will be the answer to the volume using the users variabels and the units also inputted by the user and '^3' to show that it is the units cubed to show it is volume.  
            }
            catch//This catches the error and displays an error message and stops the code from crashing. 
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying '!ERROR! enter a number into the mesurements and letters in the units?'.
                label4.Text = "Answer = Sintax Error";//This changes the text in label 4 to 'Answer = Sintax Error'. 
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
            try//This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string input = u.Text;//This takes the units inputted by the user into the text box 'u' as a string and creates a variable 'input'.
                double height = double.Parse(h.Text);//Here I am creating a variable 'height' from what the user inputs into the textbox 'h' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double length = double.Parse(l.Text);//Here I am creating a variable 'length' from what the user inputs into the textbox 'l' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double width = double.Parse(w.Text);//Here I am creating a variable 'width' from what the user inputs into the textbox 'w' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double sa = 2 * (length * height + length * width + width * height);//Here I am creating a variable 'sa'(Surface area) which consists of the calculation for surface area of a cuboid using the variables 'height', 'length', and 'width' and regular unchainging numbers.
                label4.Text = "Sufrace area = " + sa + input + "^2";//Here I am editing the text in label4 so that it displays 'Surface area =' and the variable 'sa' which will be the answer to the surface area using the users variabels and the units also inputted by the user and '^2' to show that it is the units squared to show it is area.
            }
            catch//This catches the error and displays an error message and stops the code from crashing.
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying "!ERROR! enter a number into the mesurements and letters in the units?".
                label4.Text = "Answer = Sintax Error";//This changes the text in label 4 to 'Answer = Sintax Error'.
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try//This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string unit = u2.Text;//This takes the units inputted by the user into the text box 'u2' as a string and creates a variable 'unit'.
                double radius = double.Parse(r.Text);//Here I am creating a variable 'radius' from what the user inputs into the textbox 'r' and converts it into a number so that a calculation can be proformed using the user inputted values.
                double S_volume = 4 * 3.14159 * radius * radius * radius / 3;//Here I am creating a variable 'S_volume' (sphere volume) which consists of the calculation for volume of a sphere using the variable 'radius' and regular unchainging numbers.
                label9.Text = "Volume = " + S_volume + unit + "^3";//Here I am editing the text in label9 so that it displays 'Volume =' and the variable 'S_volume' which will be the answer to the volume using the users variable and the units also inputted by the user and '^3' to show that it is the units cubed to show it is volume.
            }
            catch//This catches the error and displays an error message and stops the code from crashing.
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying "!ERROR! enter a number into the mesurements and letters in the units?".
                label9.Text = "Answer = Sintx Error";//This changes the text in label 4 to 'Answer = Sintax Error'.
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try// This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string unit = u2.Text;//This takes the units inputted by the user into the text box 'u2' as a string and creates a variable 'unit'.
                double radius = double.Parse(r.Text);//Here I am creating a variable 'radius' from what the user inputs into the textbox 'r' and converts it into a number so that a calculation can be proformed using the user inputted values.
                double S_sa = 4 * 3.14159 * radius * radius;//Here I am creating a variable 'S_sa' (sphere surface area) which consists of the calculation for the surface area of a sphere using the variable 'radius' and regular unchainging numbers.
                label9.Text = "Surface area = " + S_sa + unit + "^2";//Here I am editing the text in label9 so that it displays 'Surface area =' and the variable 'S_sa' which will be the answer to the surface area using the users variabel and the units also inputted by the user and '^2' to show that it is the units squared to show it is area.
            }
            catch//This catches the error and displays an error message and stops the code from crashing.
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying "!ERROR! enter a number into the mesurements and letters in the units?".
                label9.Text = "Answer = Sintx Error";//This changes the text in label 4 to 'Answer = Sintax Error'.
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "Answer = ";
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = "Answer = ";
                    }

        private void u76_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try// This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string unit = u3.Text;//This takes the units inputted by the user into the text box 'u3' as a string and creates a variable 'unit'.
                double C_radius = double.Parse(r2.Text);//Here I am creating a variable 'C_radius' (cone radius) from what the user inputs into the textbox 'r2' and converts it into a number so that a calculation can be proformed using the user inputted values.
                double C_height = double.Parse(h2.Text);//Here I am creating a variable 'C_height' (cone height) from what the user inputs into the textbox 'h2' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double C_volume = 1*3.14159*C_radius*C_radius*C_height/3;//Here I am creating a variable 'C_volume' (cone volume) which consists of the calculation for volume of a cone using the variables 'C_radius' and 'C_height' and regular unchainging numbers.
                label13.Text = "Volume = " + C_volume + unit + "^3";//Here I am editing the text in label13 so that it displays 'Volume =' and the variable 'C_volume' which will be the answer to the volume using the users variabels and the units also inputted by the user and '^3' to show that it is the units cubed to show it is volume.
            }
            catch//This catches the error and displays an error message and stops the code from crashing.
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying "!ERROR! enter a number into the mesurements and letters in the units?".
                label13.Text = "Answer = Sintx Error";//This changes the text in label 4 to 'Answer = Sintax Error'.
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try// This tries the code and if there is a mistake it catches later and diplays an error message stopping the code from crashing.
            {
                string unit = u3.Text;//This takes the units inputted by the user into the text box 'u3' as a string and creates a variable 'unit'.
                double C_radius = double.Parse(r2.Text);//Here I am creating a variable 'C_radius' (cone radius) from what the user inputs into the textbox 'r2' and converts it into a number so that a calculation can be proformed using the user inputted values.
                double C_height = double.Parse(h2.Text);//Here I am creating a variable 'C_height' (cone height) from what the user inputs into the textbox 'h2' and converts it into a number so that a calculation can be proformed using the user inputted value.
                double C_sa = 3.14159 * C_radius *( C_radius + Math.Sqrt(C_radius * C_radius + C_height * C_height));//Here I am creating a variable 'C_sa' (cone surface area) which consists of the calculation for the surface area of a cone using the variables 'C_radius' and 'C_height' and regular unchainging numbers.
                label13.Text = "Surface area = " + C_sa + unit + "^2";//Here I am editing the text in label9 so that it displays 'Surface area =' and the variable 'C_sa' which will be the answer to the surface area using the users variabels and the units also inputted by the user and '^2' to show that it is the units squared to show it is area.
            }
            catch//This catches the error and displays an error message and stops the code from crashing.
            {
                MessageBox.Show("!ERROR! enter a number into the mesurements and letters in the units?");//This displays an error message saying "!ERROR! enter a number into the mesurements and letters in the units?".
                label13.Text = "Answer = Sintx Error";//This changes the text in label 4 to 'Answer = Sintax Error'.
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label13.Text = "Answer = ";
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
