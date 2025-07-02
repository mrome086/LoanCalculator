using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmt = Convert.ToDouble(textBox1.Text);
            double months = Convert.ToDouble(textBox2.Text); 
            double interest = Convert.ToDouble(textBox3.Text);

            double monthly_Rate = (interest / 100) / 12;
            double month_Payment = (monthly_Rate * loanAmt) / (1 - Math.Pow((1 + monthly_Rate), -60));
            double roundedDouble = Math.Round(month_Payment, 2);
            label5.Text = roundedDouble.ToString();
        }

       private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            label5.Text = "0.00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
