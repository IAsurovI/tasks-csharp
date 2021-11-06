using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod1p1z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 20;
            Random rand = new Random();
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = 1;
            int []a=new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(0, 10);
            }
            Sort(a, n);

            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[1].Cells[i].Value = a[i];
                dataGridView1.Columns[i].Width = 30;
            }
            //
            textBox1.Text = Convert.ToString(sovp(a, n));
        }
        public int[] Sort(int[] a,int n)
        {
            
            for (var i = 1; i < n; i++)
            {
                for (var j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }

            return a;
        }
        public int sovp(int[] a, int n)
        {
            int ravno = 0, vrem = 0;
            for (int j = 1; j < n; ++j)
                if (a[j] == a[j - 1])
                {
                    ++vrem;
                    if (vrem > ravno)
                    {
                        ravno = vrem;
                    }
                }
                else vrem = 1;
            return ravno;
        }

    }
}
