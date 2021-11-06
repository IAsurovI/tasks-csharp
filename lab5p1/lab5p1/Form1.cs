using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5p1
{
    
    public partial class Form1 : Form
    {
        int[] Mas = new int [15];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {listBox1.Items.Clear();
            for (int i = 0; i < 15; i++) 
            {

                //Mas[i] = rand.NextDouble()*50;
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "]=" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();             
                int max = Mas[0];
                int maxIndex = 0;
                for (int i = 1; i < 15; i++)
                {
                    if (Mas[i] > max)
                    {
                        maxIndex = i;
                        max = Mas[i];
                    }
                }
                //listBox2.Items.Add(maxIndex);
                int temp = Mas[14];
                Mas[14] = Mas[maxIndex];
                Mas[maxIndex ]= temp;
            for(int i=0;i<15;i++)listBox2.Items.Add("Mas[" + i.ToString() + "]=" + Mas[i].ToString());
            
                

            }
        }
        }
      
    
