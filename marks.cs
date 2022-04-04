using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function1
{

  
    public partial class marks : Form
    {
        public marks()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double Number;
            if (double.TryParse(textBox1.Text, out Number))

            { 

                 if (Number >= 90 && Number <= 100)
                {
                    label1.Text = "A";


                }
                else if (Number >= 80 && Number <90)
                {
                    label1.Text = "B";
                }
                else if (Number >= 70 && Number <80)
                {
                    label1.Text = "c";
                }
                else if (Number >= 60 && Number <70)
                {
                    label1.Text = "D";
                }
                else if (Number >= 0 && Number <60)
                {
                    label1.Text = "f";
                }

                else
                {
                    textBox1.Clear();
                   
                   label1.Text = "?";
                    MessageBox.Show("Error");
                }
            }
            else
            {
                label1.Text = "?";
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double Number;
            if (double.TryParse(textBox2.Text, out Number))

            {

                if (Number >= 90 && Number <= 100)
                {
                    label2.Text = "A";


                }
                else if (Number >= 80 && Number <90)
                {
                    label2.Text = "B";
                }
                else if (Number >= 70 && Number <80)
                {
                    label2.Text = "c";
                }
                else if (Number >= 60 && Number <70)
                {
                    label2.Text = "D";
                }
                else if (Number >= 0 && Number <60)
                {
                    label2.Text = "f";
                }

                else
                {
                    textBox2.Clear();

                    label2.Text = "?";
                    MessageBox.Show("Error");
                }
            }
            else
            {
                label2.Text = "?";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double Number;
            if (double.TryParse(textBox4.Text, out Number))

            {

                if (Number >= 90 && Number <= 100)
                {
                    label4.Text = "A";


                }
                else if (Number >= 80 && Number <90)
                {
                    label4.Text = "B";
                }
                else if (Number >= 70 && Number <80)
                {
                    label4.Text = "c";
                }
                else if (Number >= 60 && Number <70)
                {
                    label4.Text = "D";
                }
                else if (Number >= 0 && Number <60)
                {
                    label4.Text = "f";
                }

                else
                {
                    textBox4.Clear();

                    label4.Text = "?";
                    MessageBox.Show("Error");
                }
            }
            else
            {
                label4.Text = "?";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double Number;
            if (double.TryParse(textBox3.Text, out Number))

            {

                if (Number >= 90 && Number <= 100)
                {
                    label3.Text = "A";


                }
                else if (Number >= 80 && Number <90)
                {
                    label3.Text = "B";
                }
                else if (Number >= 70 && Number <80)
                {
                    label3.Text = "c";
                }
                else if (Number >= 60 && Number <70)
                {
                    label3.Text = "D";
                }
                else if (Number >= 0 && Number <60)
                {
                    label3.Text = "f";
                }

                else
                {
                    textBox4.Clear();

                    label3.Text = "?";
                    MessageBox.Show("Error");
                }
            }
            else
            {
                label3.Text = "?";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double Number;
            if (double.TryParse(textBox6.Text, out Number))

            {

                if (Number >= 90 && Number <= 100)
                {
                    label5.Text = "A";


                }
                else if (Number >= 80 && Number <90)
                {
                    label5.Text = "B";
                }
                else if (Number >= 70 && Number <80)
                {
                    label5.Text = "c";
                }
                else if (Number >= 60 && Number <70)
                {
                    label5.Text = "D";
                }
                else if (Number >= 0 && Number <60)
                {
                    label5.Text = "f";
                }

                else
                {
                    textBox6.Clear();

                    label5.Text = "?";
                    MessageBox.Show("Error");
                }
                
            }
            else
            {
                label5.Text="?";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Total, average;
            
            Total = double.Parse(textBox1.Text) + double.Parse(textBox2.Text)
                + double.Parse(textBox3.Text)
                + double.Parse(textBox4.Text) + double.Parse(textBox6.Text);
              calculateTotal.Text =Total.ToString();
            average = Total / 5;
            calculateAverage.Text=average.ToString();
            if(average>=90 && average<=100)
            {
                CalculateGrade.Text = "A";
            }
            else if (average >= 80 && average <90)
            {
                CalculateGrade.Text = "B";
            }
            else if (average >= 70 && average <90)
            {
                CalculateGrade.Text = "C";
            }
            else if (average >= 60 && average <70)
            {
                CalculateGrade.Text = "D";
            }
            else if (average >= 0 && average <60)
            {
                CalculateGrade.Text = "F";
            }



        }
    }
}

