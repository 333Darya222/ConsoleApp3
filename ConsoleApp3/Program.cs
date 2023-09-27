using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program

    {
        static void Main(string[] args)
        {

            //int a;
            //int b;

            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);

            //int N;
            //double X;
            //Console.WriteLine("N=");
            //string t = Console.ReadLine();
            //N = int.Parse(t);
            //Console.WriteLine("X=");
            //string tX = Console.ReadLine();
            //X = int.Parse(tX);

            //for24(N, X);
            //Console.WriteLine("X=");
            //tX = Console.ReadLine();
            //X = int.Parse(tX);
            //Console.WriteLine("N=");
            //tN = Console.ReadLine();
            //N = int.Parse(tN);

            //for22(N,X);
            //for22(20,3);
            //for20();
            //forfor2();
            //forfor1();
            //for7(a,b);
            //for7(2, 3) ;
            //for6();
            //for5();
            //IFIF();
            //IF();
            //For1();
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

            Console.ReadKey();
        }

        static void for24(int N, double X)
        {
            double factorial = 1;

            double step;
            double sum = 0;

            for(double i=1; i<=N*2; i++)
            {
                factorial *= i;
                step = Math.Pow(X, (i * 2));
                sum += ((Math.Pow(-1, i) * step) / (factorial * 2));
                double itog = 1 + sum;
                Console.WriteLine(itog);
            }


        }

        static void for22(int N, double X)
        {
            double factorial = 1;
            
            double step ;
            double sum=0;
          

            for (double i = 1; i <= N; i++)
            {
                factorial *= i;
                step = Math.Pow(X,i);
                sum +=( step / factorial);
                double d = 1 + sum;
                Console.WriteLine(d);
            }
        }
        static void for21()
        {
            int N;
            Console.WriteLine("N=");
            string t = Console.ReadLine();
            N = int.Parse(t);
            double s = 1;
            
            double m = 0;
            double f;

            for (double i = 1; i <= N; i++)
            {
                s *= i;
                m += 1 / (s);
                
                f = 1 + m;
                Console.WriteLine(f);
            }
            
            
        }

        static void for20()
        {
            int N;
            Console.WriteLine("N=");
            string t = Console.ReadLine();
            N = int.Parse(t);
            int s = 1;
            int g=0;

            for (int i = 1; i <= N; s*=i)
            {
                i++;
                g+=s;
                
                Console.WriteLine(g);
            }
        }
        static void forfor2()
        {
            int a;
            Console.WriteLine("a=");
            string t = Console.ReadLine();
            a = int.Parse(t);
            int s = 1;

            for(int i = 1; i <= a; i++)
            {
                s *= i;
                Console.WriteLine(s);
            }
        }

        static void forfor1()
        {
            
            for (int i = 1; i <= 50; i++)
                if(i%3==0)
                {
                
                 Console.WriteLine(i);
                }
        }


        static void for7(int a,int b)
        {
           
            int S = 0;
            for (int i = a; i<= b;i++)
            {
                S += i;
                Console.WriteLine(S);
            }


        }
        
        static void for6()
        {
            double a;
            Console.WriteLine(" ценa за кг= ");
            string t = Console.ReadLine();
            a = double.Parse(t);

            for (double i = 1.2; i <= 2; i = i + 0.2)
            {
                double s = i * a;
                Console.WriteLine("Цена за " + (i.ToString("0.0")) + " кг " + (s.ToString("0.0")) );
            }
        }

        static void for5()
        {
            double a;
            Console.WriteLine(" ценa за кг= ");
            string t = Console.ReadLine();
            a = double.Parse(t);

            for (double i = 0.1; i <= 1; i = i + 0.1)
            {
                double s = i * a;
                Console.WriteLine("Цена за " + (i.ToString("0.0")) + " кг " + (s.ToString("0.0")));
            }
        }

        static void IFIF()
        {
            int a;
            Console.WriteLine("a=");
            string t = Console.ReadLine();
            a = int.Parse(t);

            if (a/100==a%10)
            {
                Console.WriteLine("это палиндром");
            }
            else
            {
                Console.WriteLine("это не палиндром");
            }

        }

        static void IF()
        {
            int a;
            Console.WriteLine("a=");
            string t = Console.ReadLine();
            a = int.Parse(t);

            string r = "рублей";
            string s = "рубль";
            string p = "рубля";

            if ((a / 10 % 10 > 1 & a / 10 % 10 < 10) & a % 10 == 1)
            {
                Console.WriteLine(a + s);
            }
            else if (((a / 10 % 10 >= 2 & a / 10 % 10 < 10) ) & (a % 10 >= 2 & a % 10 <= 4))
            {
                Console.WriteLine(a+ p);
            }
            else if (( a / 10 % 10 == 1)&(a%10>=1&a%10<=9))
            {
                Console.WriteLine(a + r);
            }
            else
            {
                Console.WriteLine(a + r);
            }
           
        }

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
      
    }
}