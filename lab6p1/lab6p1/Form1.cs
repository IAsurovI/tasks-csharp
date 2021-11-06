using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[][] A;
            int[][] B;
            int n;
            n = Convert.ToInt32(textBox1.Text);
            A = new int[n][];
            for (int i = 0; i < n; i++)
            {
                A[i] = new int[n];
                for (int j = 0; j < n; j++) A[i][j] = rand.Next(n) + 1;

                if (A[i][0] > A[i][n - 1])
                {
                    int a = A[i][0];
                    A[i][0] = A[i][n - 1];
                    A[i][n - 1] = a;
                }
            }
            Data1(A, n);
            B = new int[n][];
            int kolSt;
            for (int i = 0; i < n; i++)
            {
                kolSt = A[i][n - 1] - A[i][0] + 1;
                B[i] = new int[kolSt];
                for (int j = 0; j < kolSt; j++) B[i][j] = A[i][A[i][0] - 1 + j];
            }
            dataGridView2.ColumnCount = n;
            dataGridView2.RowCount = n;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B[i].Length; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = B[i][j];
                    dataGridView2.Columns[i].Width = 20;
                    dataGridView2.Columns[i].Name = $"B{i}";
                }
                }
            for (int i = 0; i < n; i++) Array.Sort(A[i]);
            Data3(A, n);
        }
        public void Data1(int[][] A, int n)
        {
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = A[i][j];
                    dataGridView1.Columns[i].Width = 20;
                    dataGridView1.Columns[i].Name = $"A{i}";
                }           
            }
        }
        public void Data3(int[][] A, int n)
        {
            dataGridView3.ColumnCount = n;
            dataGridView3.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = A[i][j];
                    dataGridView3.Columns[i].Width = 20;
                    dataGridView3.Columns[i].Name = $"A{i}";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            label5.Text = "Завдання №3: Кожен рядок матриці A на першій і останній позиції містить індекси відповідно початку і кінця діапазону елементів рядка,\n які необхідно переписати у відповідний рядок матриці B. Створити матрицю B з необхідною кількістю стовпчиків у кожному рядку та переписати\n до неї вказані елементи з матриці A. Відсортувати кожен рядок матриці A за зростанням ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
        }
    }
}
