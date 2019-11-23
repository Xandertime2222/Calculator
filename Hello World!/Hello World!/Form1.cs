using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Hello_World_
{
   
    public partial class Form1 : Form
    {
        string wert1 = "0";
        string wert2 = "0";
        int bol = 1;
        string rechenart = "";

        public Form1()
        {
            

            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rechenart = "div";
            bol = 2;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 8;

            }
            else
            {
                wert2 = wert2 + 8;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 9;

            }
            else
            {
                wert2 = wert2 + 9;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 4;

            }
            else
            {
                wert2 = wert2 + 4;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 5;

            }
            else
            {
                wert2 = wert2 + 5;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 6;

            }
            else
            {
                wert2 = wert2 + 6;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 1;

            }
            else
            {
                wert2 = wert2 + 1;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 2;

            }
            else
            {
                wert2 = wert2 + 2;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 3;

            }
            else
            {
                wert2 = wert2 + 3;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            rechenart =  "plus";
            bol = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            rechenart = "minus";
            bol = 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            rechenart = "mal";
            bol = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (bol == 1)
            {
                wert1 = wert1 + 7;

            }
            else
            {
                wert2 = wert2 + 7;
                
            }

            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (rechenart == "plus")
            {

                int number1;
                bool res = int.TryParse(wert1, out number1);

                int number2;
                bool res1 = int.TryParse(wert2, out number2);

                int ergbnis = number1 + number2;

                string ergebnisstring = Convert.ToString(ergbnis);
                textBox1.Text = (ergebnisstring);

            }
            else if (rechenart == "minus")
            {
                int number1;
                bool res = int.TryParse(wert1, out number1);

                int number2;
                bool res1 = int.TryParse(wert2, out number2);

                int ergbnis = number1 - number2;

                string ergebnisstring = Convert.ToString(ergbnis);
                textBox1.Text = (ergebnisstring);
            }
            else if (rechenart == "mal")
            {
                int number1;
                bool res = int.TryParse(wert1, out number1);

                int number2;
                bool res1 = int.TryParse(wert2, out number2);

                int ergbnis = number1 * number2;

                string ergebnisstring = Convert.ToString(ergbnis);
                textBox1.Text = (ergebnisstring);
            }
            else if (rechenart == "div")
            {
                int number1;
                bool res = int.TryParse(wert1, out number1);
                     
                int number2;
                bool res1 = int.TryParse(wert2, out number2);

                int ergbnis = number1 / number2;

                string ergebnisstring = Convert.ToString(ergbnis);
                textBox1.Text = (ergebnisstring);
              
            }
            wert1 = "0";
            wert2 = "0";
            bol = 1;
            rechenart = "";



        }
    }
}
