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
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rate1 = 0.20, rate2 = 0.30, rate3 = 0.40, rate4 = 0.50, price = 99, packes, discount,netdiscount;
            double NumPackages;
            if (double.TryParse(textBox1.Text, out NumPackages))
            {
                if(NumPackages>=10 && NumPackages<=19)
                {
                    packes = NumPackages * price;
                    discount = packes * rate1;
                    netdiscount = packes - discount;
                    label3.Text = packes.ToString();
                    label5.Text =rate1.ToString(); 
                    label7.Text =netdiscount.ToString();
                    
                  

                }
                else if (NumPackages >= 20 && NumPackages <= 49)
                {
                    packes = NumPackages * price;
                    discount = packes * rate2;
                    netdiscount = packes - discount;
                    label3.Text = packes.ToString();
                    label5.Text = rate2.ToString();
                    label7.Text = netdiscount.ToString();



                }
                else if (NumPackages >= 50 && NumPackages <= 99)
                {
                    packes = NumPackages * price;
                    discount = packes * rate3;
                    netdiscount = packes - discount;
                    label3.Text = packes.ToString();
                    label5.Text = rate3.ToString();
                    label7.Text = netdiscount.ToString();



                }
                else if (NumPackages >= 100)
                {
                    packes = NumPackages * price;
                    discount = packes * rate4;
                    netdiscount = packes - discount;
                    label3.Text = packes.ToString();
                    label5.Text = rate4.ToString();
                    label7.Text = netdiscount.ToString();



                }
                else
                {
                    textBox1.Clear();
                    label3.Text="";
                    label5.Text = "";
                    label7.Text = "";
                    MessageBox.Show("Error");
                }
            }
            
            

        


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
            label5.Text = "";
            label7.Text = "";
        }

        private void quiz_Load(object sender, EventArgs e)
        {

        }
    }
}
