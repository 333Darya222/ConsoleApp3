using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            double X;
            N = int.Parse(textBox1.Text);
            X = double.Parse(textBox2.Text);

            for22(N,X);
        }


        static void for22(int N, double X)
        {
            double factorial = 1;

            double step;
            double sum = 0;


            for (double i = 1; i <= N; i++)
            {
                factorial *= i;
                step = Math.Pow(X, i);
                sum += (step / factorial);
                double d = 1 + sum;
                MessageBox.Show(d.ToString());
            }
        }


        
        static void for7(int a, int b)
        {

            int S = 0;
            for (int i = a; i <= b; i++)
            {
                S += i;
                MessageBox.Show(S.ToString());
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a;
            int b;


            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox3.Text);

            for7(a, b);
        }
    }
}
