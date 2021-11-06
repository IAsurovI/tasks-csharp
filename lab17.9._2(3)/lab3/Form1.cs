using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double fx = 0;
            double b = 0;
            int rbu = 0;
            if (radioButton1.Checked) { fx = Math.Sinh(x); rbu = 1; }
            else if (radioButton2.Checked) { fx = Math.Pow(x, 2); rbu = 2; }
            else if (radioButton3.Checked) { fx = Math.Exp(x); rbu = 3; } 
            
            if (x / y > 0) b = Math.Log(fx) + Math.Pow((Math.Pow(fx, 2) + y), 3);
            else if (x / y < 0) b = Math.Log(Math.Abs(fx) / y) + Math.Pow((fx + y), 3);
            else if (x == 0) b = Math.Pow((Math.Pow(fx, 2) + y), 3);
            else if (y == 0) b = 0;

            textBox3.Text += Environment.NewLine + "Результаты работы программы:";
            textBox3.Text += Environment.NewLine + "Выбран: radioButton " + rbu;
            textBox3.Text += Environment.NewLine + "При Х= " + x;
            textBox3.Text += Environment.NewLine + "При Y= " + y;
            textBox3.Text += Environment.NewLine + "b= " + b;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
