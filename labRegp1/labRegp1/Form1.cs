using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRegp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = Regex.Replace(textBox1.Text, @"\W+", "");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Задание: \n2. Дана строка вида «dafd#$245243564@#243$yet12&». \nНаписать программу, которая выводит на экран строку из цифр и латинских букв.";
            textBox1.Text = "dafd#$245243564@#243$yet12&";

        }
    }
    }
