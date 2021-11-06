using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod1p1z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            textBox4.Text = Convert.ToString(NZD3(a, b, c));

        } 
        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox6.Text);
            textBox5.Text = Convert.ToString(NZD4(a, b, c,d));
        }
        public int NZD3(int a, int b, int c)
        {
            int Nzd =Math.Min(a, Math.Min(b,c));
            for (; Nzd > 1; Nzd--)
            {
                if (a % Nzd == 0 && b % Nzd == 0 && c % Nzd == 0)
                    break;
            }
            return Nzd;
        }
        public int NZD4(int a, int b, int c,int d)
        {
            int Nzd = Math.Min(a, Math.Min(b, Math.Min(c,d)));
            for (; Nzd > 1; Nzd--)
            {
                if (a % Nzd == 0 && b % Nzd == 0 && c % Nzd == 0 && d % Nzd == 0)
                    break;
            }
            return Nzd;
        }

       
    }
}
