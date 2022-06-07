using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Введите размерность матрицы!", "STOP!");
            else
            {
                int n = 0;
                try
                {
                    n = int.Parse(textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите числовое значение!", "STOP!");
                    return;
                }


                int[,] a = new int[n, n];
                int[,] b = new int[n, n];
                int[,] c = new int[n, n];
                Random r = new Random();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                int k = 0;
                int i = 0;
                int j = 0;
                int s = 0;
                string s1 = "";
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        a[i, j] = r.Next(0, 9);
                for (i = 0; i < n; i++)
                {
                    s1 = "";
                    for (j = 0; j < n; j++)
                        s1 += a[i, j].ToString() + " ";
                    listBox1.Items.Add(s1);
                }
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        b[i, j] = r.Next(0, 9);
                for (i = 0; i < n; i++)
                {
                    s1 = "";
                    for (j = 0; j < n; j++)
                        s1 += b[i, j].ToString() + " ";
                    listBox2.Items.Add(s1);
                }
                for (i = 0; i < n; i++)
                {
                    s1 = "";
                    for (j = 0; j < n; j++)
                    {
                        s = 0;
                        for (k = 0; k < n; k++)
                            s += a[i, k] * b[k, j];
                        c[i, j] = s;
                        s1 += s.ToString("d4") + " ";
                    }
                    listBox3.Items.Add(s1);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}