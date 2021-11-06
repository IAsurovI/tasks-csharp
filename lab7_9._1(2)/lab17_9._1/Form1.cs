using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab17_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text += Environment.NewLine + "Лаб. раб. N1. Марков";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X= " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y= " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z= " + z.ToString();
            //double a1 = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), 1 / 3);
            //double a2= Math.Pow(x,2)+Math.Pow(y,2)+2;
            //double a3= Math.Exp(Math.Abs(x-y));
            //double a4=Math.Pow(((Math.Pow(Math.Tan(z),2))+1),x);
            //double u = (a1 / a2) - (a3 * a4);
            double a1 = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), 1 / 3);
            double a2 = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;

            double a3 = Math.Exp(Math.Abs(x - y));
            double a4 = Math.Pow(((Math.Pow(Math.Tan(z), 2)) + 1), x);

            double u = (a1 / a2) - (a3 * a4);

            textBox4.Text += Environment.NewLine + "U= " + u.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double x = -4.5;
            double y = 0.75 * Math.Pow(10, -4);
            double z = 0.845 * Math.Pow(10, 2);
            textBox1.Text += Environment.NewLine + x.ToString();
            textBox2.Text += Environment.NewLine + y.ToString();
            textBox3.Text += Environment.NewLine + z.ToString();
        }
    }
}
