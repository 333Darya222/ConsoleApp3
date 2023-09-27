﻿using System;
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
            N = int.Parse(textBox2.Text);
            X = double.Parse(textBox1.Text);

            for24(N,X);
        }


        static void for24(int N, double X)
        {
            double factorial = 1;

            double step;
            double sum = 0;


            for (double i = 1; i <= N; i++)
            {
                factorial *= i;
               
                step = Math.Pow(X, (i*2));
                sum += ((Math.Pow(-1, i) * step) / (factorial*2));
                double itog = 1 + sum;
                

                MessageBox.Show(itog.ToString());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            double d;
            double f;
            a = double.Parse(textBox9.Text);
            b = double.Parse(textBox13.Text);
            c= double.Parse(textBox12.Text);
            d = double.Parse(textBox11.Text);
            f = double.Parse(textBox10.Text);


            zad2(a,b,c,d,f);
        }
        static void zad2(double a, double b, double c, double d, double f)
        {
            double srar = (a + b + c + d + f)/5;
            MessageBox.Show(srar.ToString("0.000"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
           
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            c = double.Parse(textBox7.Text);
            


            zad3(a, b, c);
        }
        static void zad3(double a, double b, double c)
        {
            if (a>0||b>0||c>0)
            {
                MessageBox.Show(.ToString("0.000"));
            }

        }
    }
}
