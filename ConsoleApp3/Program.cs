using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        static void if9()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("a=" + a + "b= " + b);
            }
            else
            {
                Console.WriteLine("a=" + a + "b= " + b);

            }
        }

        static void if8()
        {
            int a;
            int b;
            Console.WriteLine("a=");

            string t = Console.ReadLine();
            Console.WriteLine("b=");
            string g = Console.ReadLine();
            a = int.Parse(t);
            b = int.Parse(g);
            if (a < b)
            {
                Console.WriteLine(b + " " + a);
            }
            else if (b < a)
            {
                Console.WriteLine(a + " " + b);

            }

            else Console.WriteLine("числа равны");
        }

        static void if4()
        {
            int a;
            int b;
            int c;
            int N;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
            Console.WriteLine("c=");
            string tC = Console.ReadLine();
            c = int.Parse(tC);
            N = 0;
            if (a > 0) ++N;
            if (b > 0) ++N;
            if (c > 0) ++N;
            Console.WriteLine("колличество положительных чисел " + N);
        }

        static void if3()
        {
            int a;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            if (a > 0)
            {

                Console.WriteLine("положительное" + (a + 1));
            }
            else if (a < 0)
            {
                Console.WriteLine("отрицательное" + (a - 2));
            }
            else
            {
                Console.WriteLine("нулевое " + (a = 10));
            }
        }

        static void boolean4()
        {
            int a;
            int b;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
            if (a > 2 & b <= 3)
            {
                Console.WriteLine("верно");

            }
            else
            {
                Console.WriteLine("неверно");
            }
        }
        static void Boolean2()
        {
            int A;

            Console.WriteLine("A =");
            string tA = Console.ReadLine();
            A = int.Parse(tA);

            if (A % 2 > 0)
            {
                Console.WriteLine("nechetnoe");

            }
            else
            {
                Console.WriteLine("chetnoe");
            }
        }

        static void integer7()
        {
            int a;
            int D;
            int E;
            int S;
            int P;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            D = a / 10;
            E = a % 10;
            S = D + E;
            P = D * E;
            Console.WriteLine("сумма =" + S + "  " + "произведение=" + P);

        }

        static void integer6()
        {
            int a;
            int D;
            int E;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            D = a / 10;
            E = a % 10;
            Console.WriteLine("desyatki=" + D + "  " + "edinitsi" + E);


        }

        static void integer4()
        {
            int a;
            int b;
            int O;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
            O = a / b;
            Console.WriteLine(O);

        }

        static void integer3()
        {
            int a;
            int S;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            S = a / 1024;
            Console.WriteLine(S);

        }

        static void begin10()
        {
            double a;
            double b;
            int S;
            int R;
            int P;
            int cH;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = double.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = double.Parse(tB);
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            S = (int)(a + b);
            R = (int)(a - b);
            P = (int)(a * b);
            cH = (int)(a / b);
            Console.WriteLine("symma=" + S);
            Console.WriteLine("raznost=" + R);
            Console.WriteLine("proizvedenie=" + P);
            Console.WriteLine("chastnoe=" + cH);
        }

        static void begin9()
        {
            double a;
            double b;
            double M;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = double.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = double.Parse(tB);
            M = Math.Sqrt(a * b);
            Console.WriteLine("среднее геометрическое=" + M);
        }

        static void begin6()
        {

            int a;
            int b;
            int c;
            int V;
            int S;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
            Console.WriteLine("c=");
            string tC = Console.ReadLine();
            c = int.Parse(tC);
            V = a * b * c;
            S = 2 * (a * b + b * c + a * c);
            Console.WriteLine("V объем =" + V);
            Console.WriteLine("S площадь поверхности =" + S);
        }

        static void begin4()
        {
            double d;
            double PI = 3.14;
            double L;
            Console.WriteLine("d=");
            string t = Console.ReadLine();
            d = double.Parse(t);

            L = PI * d;
            Console.WriteLine("длина=" + L);
        }

        static void For1()
        {
            int a;



            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            for (int i = 1; i <= 10; i = i + 1)
            {

                Console.WriteLine(i * a);
            }
        }

        static void IF12()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
            Console.WriteLine("c=");
            string tC = Console.ReadLine();
            c = int.Parse(tC);

            if (a < b && a < c)
            {
                Console.WriteLine("a наменьшее");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("b наименьшеее");
            }
            else
            {
                Console.WriteLine("числа равны");
            }

        }

        static void cl()
        {
            int n;
            int k;

            Console.WriteLine("n=");
            string tA = Console.ReadLine();
            n = int.Parse(tA);
            Console.WriteLine("k=");
            string tB = Console.ReadLine();
            k = int.Parse(tB);
            for (int i = 0; i < n; i = i + 1)
            {
                Console.WriteLine(k);
            }
        }
        static void Main(string[] args)
        {
            For1();
            //begin4();
            //begin6();
            //begin9();
            //begin10();
            //integer3();
            //integer4();
            //cl();
            //IF12();
            //integer6();
            //integer7();
            //boolean4();
            //Boolean2();
            //if3();
            //if4();
            //if8();
            //if9();








            //int a;
            //int b;
            //int c;

            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);
            //Console.WriteLine("c=");
            //string tC = Console.ReadLine();
            //c = int.Parse(tC);

            //if (a>b && a>c )
            //{
            //    if (b > c) ;
            //    Console.WriteLine($"max {a}");
            //    Console.WriteLine($"min {c}");
            //    if (b < c) ;
            //    Console.WriteLine($"max {a}");
            //    Console.WriteLine($"min {b}");
            //}

            //else if (b>a && b>c)
            //{
            //    if (a > c) ;
            //    Console.WriteLine("max="+b);
            //    Console.WriteLine("min="+c);
            //    if (a < c) ;
            //    Console.WriteLine("max="+b);
            //    Console.WriteLine("min=" + a);
            //}
            //else if (c>a&&c>b)
            //{
            //    if (a < b) ;
            //    Console.WriteLine("max+"+b);
            //    Console.WriteLine("min")
            //}

            //int a;
            //int b;
            //int c;
            //Console.WriteLine("a=");

            //string t = Console.ReadLine();
            //Console.WriteLine("b=");
            //string g = Console.ReadLine();
            //a = int.Parse(t);
            //b = int.Parse(g);
            //if (a!=b)
            //{
            //    c = a;
            //    a = a + b;

            //    b = c + b;

            //}
            //else
            //{
            //}
            //Console.WriteLine("A=" + (a) + "B=" + (b));

            //int a;
            //int d;
            //Console.WriteLine("введи a");

            //string t = Console.ReadLine();
            //Console.WriteLine("ввести d");
            //string g = Console.ReadLine();
            //a = int.Parse(t);
            //d = int.Parse(g);
            //if (a < d) {
            //    Console.WriteLine($" число d {d} больше");
            //} else if (d < a) {
            //    Console.WriteLine($" число a {a}  больше");
            //} else Console.WriteLine("числа равны"); 


            //int a;

            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if( a > 0) {
            //    a = a + 1;
            //    Console.WriteLine($"Число a {a} положительное");
            //} else if( a == 0 ) {
            //    Console.WriteLine("a равно нулю");
            //} else { //все остальные случаи
            //    Console.WriteLine("a отрицательное");
            //}




            //int a;
            //int b;
            //int S;
            //int P;

            //Console.WriteLine("Привет, считаем S прямоугольника, введите значение сторон");
            //string tmpA = Console.ReadLine();
            //string tmpB = Console.ReadLine();
            //a = int.Parse(tmpA);
            //b = int.Parse(tmpB);
            //Console.WriteLine($"S={a*b}, P={2*(a+b)}");

            //Console.WriteLine("S= " +a*b + " ,P= " + 2*(a+b));



            //Console.WriteLine("введите сторону квадрата");
            //int a;
            //string t = Console.ReadLine();
            //a = int.Parse(t);

            //Console.WriteLine("P="+a*4);



            //int age;
            //string name;

            //Console.WriteLine("Привет, как тебя зовут!");
            //name = Console.ReadLine();

            //Console.WriteLine("Сколько тебе лет");
            //string tmp = Console.ReadLine();
            //age = int.Parse(tmp);

            //Console.WriteLine("Привет " + name + " тебе " + age + " лет");
            Console.ReadKey();
        }
    }
}