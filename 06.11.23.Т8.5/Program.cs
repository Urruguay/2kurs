using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06._11._23.Sh
{
    internal class Program
    {
        //Вариант 1 (Уровень А)
        //1
        /*static void Main(string[] args)
        {
            Write("Введите значение x  -  ");
            int x = Convert.ToInt32(ReadLine());
            Write("Введите значение y  -  ");
            int y = Convert.ToInt32(ReadLine());
            double z = Znach(x,y) + Znach(x, y) + Znach(x, y);
            WriteLine(z);
            Read();
        }
        static double Znach(double x, double y) 
        {
            return (x + Math.Sin(x))/y;
        }*/

        //.....................//

        //2

        /*static void Main(string[] args)
        {
            Write("Введите часы  -  ");
            int h = int.Parse(ReadLine());
            Write("Введите минуты  -  ");
            int m = int.Parse(ReadLine());
            Write("Введите секунды  -  ");
            int s = int.Parse(ReadLine());
            WriteLine(Seconds(h, m, s));
            Read();
        }
        static int Seconds(int h, int m, int s)
        {
            return (h * 60 * 60) + (m * 60) + s;
        }*/

        //.....................//

        //Вариант 5 (Уровень В)
        //1
        /*static void Main(string[] args)
        {
            Write("Введите a -  ");
            int a = int.Parse(ReadLine());
            Write("Введите b  -  ");
            int b = int.Parse(ReadLine());
            double x = Znach(a, b) + Znach(a, b) + Znach(a, b);
            WriteLine(x);
            Read();
        }
        static double Znach(double a, double b)
        {
            return (a + Math.Sqrt(a))/ (b + Math.Sqrt(b));
        }*/

        //2
        /*static void Main(string[] args)
        {
            Write("Введите n -  ");
            int n = int.Parse(ReadLine()); 
            Numbers(n);
            Read();
        }
        static void Numbers(int n)
        {
             for(int i = 2; i < n; i++)
                if (i % 2 == 0)
                    WriteLine(i);
        }*/

        //Задание с треугольником

        static void Main(string[] args)
        {
            int[] A = { 3, 7 };
            int[] B = { 5, 6 };
            int[] C = { 2, 4 };
            double a = Exist(A, C);
            double b = Exist(A, B);
            double c = Exist(B, C);
            if (Proverka(a, b, c))
            {
                double P_ = P(a, b, c);
                WriteLine($"Периметр равен  -  {P_}");
                WriteLine($"Площадь равна  -   {S(a, b, c, P_)}");
            }
            else
            {
                WriteLine("Абонент не абонент позвоните позже.");
            }
            Read();
        }
        static double Exist(int[] A, int[] B)
        {
           return Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2));   
        }
        static bool Proverka(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }
        static double P(double a, double b, double c)
        {
            return a + b + c;
        }
        static double S(double a, double b, double c, double P)
        {
            double P_ = P / 2;
            return Math.Sqrt(P_*(P_ - a)*(P_ - b)*(P_ - c));
        }

    }
}
