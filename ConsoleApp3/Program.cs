using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //if9
            int a;
            int b;
            int c;
            Console.WriteLine("a=");
            string tA = Console.ReadLine();
            a = int.Parse(tA);
            Console.WriteLine("b=");
            string tB = Console.ReadLine();
            b = int.Parse(tB);
       
            if(a>b)
            {
                c = a ;
                a = b;
                b = c;
                Console.WriteLine("a="+a + "b= " + b);
            }
            else
            {
                Console.WriteLine("a="+a + "b= " + b);

            }




            ////if8
            //int a;
            //int b;
            //Console.WriteLine("a=");

            //string t = Console.ReadLine();
            //Console.WriteLine("b=");
            //string g = Console.ReadLine();
            //a = int.Parse(t);
            //b = int.Parse(g);
            //if (a < b)
            //{
            //    Console.WriteLine(b + " " + a);
            //}
            //else if (b < a)
            //{
            //    Console.WriteLine(a + " " + b);

            //}

            //else Console.WriteLine("числа равны");





            ////if4
            //int a;
            //int b;
            //int c;
            //int N;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);
            //Console.WriteLine("c=");
            //string tC = Console.ReadLine();
            //c = int.Parse(tC);
            //N = 0;
            //if (a > 0) ++ N;
            //if (b > 0) ++ N;
            //if (c > 0) ++ N;
            //Console.WriteLine("колличество положительных чисел " + N);





            ////if3
            //int a;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //if (a > 0)
            //{

            //    Console.WriteLine("положительное"+(a+1));
            //}
            //else if(a<0)
            //{
            //    Console.WriteLine("отрицательное"+(a-2));
            //}
            //else 
            //{
            //    Console.WriteLine("нулевое "+(a=10));
            //}


            ////boolean4
            //int a;
            //int b;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);
            //if (a>2&b<=3)
            //{
            //    Console.WriteLine("верно");

            //}
            //else
            //{
            //    Console.WriteLine("неверно");
            //}




            ////Boolean2
            //int A;

            //Console.WriteLine("A =");
            //string tA = Console.ReadLine();
            //A = int.Parse(tA);

            //if (A % 2 > 0)
            //{
            //    Console.WriteLine("nechetnoe");

            //}
            //else
            //{
            //    Console.WriteLine("chetnoe");
            //}




            ////integer 7
            //int a;
            //int D;
            //int E;
            //int S;
            //int P;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //D = a / 10;
            //E = a % 10;
            //S = D + E;
            //P = D * E;
            //Console.WriteLine("сумма =" + S + "  " + "произведение=" + P);



            ////integer 6
            //int a;
            //int D;
            //int E;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //D = a / 10;
            //E = a % 10;
            //Console.WriteLine("desyatki="+D +"  "+ "edinitsi"+E);






            ////integer4
            //int a;
            //int b;
            //int O;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);
            //O = a / b;
            //Console.WriteLine(O);





            ////integer3
            //int a;
            //int S;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //S = a / 1024;
            //Console.WriteLine(S);


            ////begin 10;
            //double a;
            //double b;
            //int S;
            //int R;
            //int P;
            //int cH;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = double.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = double.Parse(tB);
            //a = Math.Pow(a, 2);
            //b = Math.Pow(b, 2);
            //S = (int)(a + b);
            //R = (int)(a - b);
            //P = (int)(a * b);
            //cH = (int)(a / b);
            //Console.WriteLine("symma=" + S);
            //Console.WriteLine("raznost=" + R);
            //Console.WriteLine("proizvedenie=" + P);
            //Console.WriteLine("chastnoe=" + cH);



            ////begin 9
            //double a;
            //double b;
            //double M;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = double.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = double.Parse(tB);
            //M = Math.Sqrt(a * b);
            //Console.WriteLine("среднее геометрическое="+M);


            ////begin 6
            //int a;
            //int b;
            //int c;
            //int V;
            //int S;
            //Console.WriteLine("a=");
            //string tA = Console.ReadLine();
            //a = int.Parse(tA);
            //Console.WriteLine("b=");
            //string tB = Console.ReadLine();
            //b = int.Parse(tB);
            //Console.WriteLine("c=");
            //string tC = Console.ReadLine();
            //c = int.Parse(tC);
            //V = a * b * c;
            //S = 2 * (a * b + b * c + a * c);
            //Console.WriteLine("V объем =" + V);
            //Console.WriteLine("S площадь поверхности =" + S);




            ////begin 4
            //double d;
            //double PI = 3.14;
            //double L;
            //Console.WriteLine("d=");
            //string t = Console.ReadLine();
            //d = double.Parse(t);

            //L = PI * d;
            //Console.WriteLine("длина=" + L);


            Console.ReadKey();

        }
    }
}
