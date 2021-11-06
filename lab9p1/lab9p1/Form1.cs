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


namespace lab9p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//2.	Заданий рядок, що містить декілька слів,
         //розділених пробілами. Необхідно надрукувати усі слова, що розпочинаються
         //з гласної букви.
            textBox2.Clear();
            string input = textBox1.Text;
            const string filter = "aeioyuAEIOYU";
            string[] wordsOf = input.Split(' ');
            for (int i = 0; i < wordsOf.Length; i++)
            {
                foreach (var filt in filter)
                {
                    if (wordsOf[i][0] == filt)
                    {
                        textBox2.Text+=wordsOf[i]+" ";
                        break;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Завдання: \n"+
                "2.	Заданий рядок, що містить декілька слів, розділених пробілами.\n" +
                " Необхідно надрукувати усі слова, що розпочинаються з гласної букви.";
            label7.Text = "2.	В якому з них більше слів, що містять цифри?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] mass = new int[3];
            string str1 = richTextBox1.Lines[0];
            string str2 = richTextBox1.Lines[1];
            string str3 = richTextBox1.Lines[2];
            foreach (string i in str1.Split(new char[] { ' ' })) mass[0] = prohod(i);
            foreach (string i in str2.Split(new char[] { ' ' })) mass[1] = prohod(i);
            foreach (string i in str3.Split(new char[] { ' ' })) mass[2] = prohod(i);
            textBox3.Text = Convert.ToString(Array.IndexOf(mass, mass.Max()) + 1) + " рядок";
        }
        public int prohod(string i)
        {
            const string filter = "0123456789";
            int output = 0;
            foreach (var filt in filter)
            {
                if (i.Contains(filt))
                {
                    output++;
                    break;
                }
            }
            return output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lorem Ip2sum i3s sim4ply dummy text" +
                "\nI3t has surv2ived nost on34ly fidve ce1nturies" +
                "\nAl3dus PageMak1er inc2luding versions of Lorem Ipsum";
        }
    }
}
