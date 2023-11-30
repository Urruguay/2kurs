using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30._10._23.Т8._3
{
    internal class Program
    {
        //Задание 1. 
        //5. Ввести на экран 4 горизонтальные строки,
        //каждая из которых состоит из 7 символов,
        //отделенных друг от друга пустыми строками

        //static void Main(string[] args)
        //{
        //    Cicle();
        //    Read();
        //}
        //public static void Cicle()
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 7; j++)
        //        {
        //            Write("!");
        //        }
        //        WriteLine();
        //        for (int j = 0; j < 7; j++)
        //        {
        //            Write(" ");
        //        }
        //        WriteLine();
        //    }
        //}

        //..................................//

        //Задание 2.
        //5.

        //static void Main(string[] args)
        //{
        //    Treug();
        //    Read();
        //}
        //public static void Treug()
        //{
        //    int indent = 4;
        //    int count = 12;
        //    for (int i = indent + 1; i <= count + indent; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (j < indent) Write(" ");
        //            else Write("!");
        //        }
        //        WriteLine();
        //    }
        //}

        //..................................//

        //Задание 3. Вычислить значение выражения,
        //определив и использовав дополнительный метод
        //5.

        //static void Main()
        //{
        //    WriteLine($"{Func(13,7) + Func(15,12) + Func(32,21)}");
        //    Read();
        //}
        //static double Func(double x, double y) => (x + Math.Sqrt(y)) / (Math.Sqrt(x) + y);

        //..................................//

        //Задание 4
        //5.

        static void Main(string[] args)
        {

            int indent = 5;
            int count = 18;
            //for (int i = indent + 1; i <= count + indent; i++)
            //{
            //    if (count < indent) { Write(" "); }
            //    else { WriteLine("!"); }

            //    WriteLine();
            //}
            //Min();

            for (int i = 1; i <= 23; i++)
            {
                if (i != indent)
                { Write(" "); }
                else { WriteLine("!"); }
            }
            Read();
        }
        static void Min()
        {
            //Write("Введите число a - ");
            //double a = double.Parse(ReadLine());
            //Write("Введите число b - ");
            //double b = double.Parse(ReadLine());  //double a = 2, b = 4;
            //double y = (Math.Min(2 * a, b + a)), x = (Math.Min(2 * a - b, b));
            //WriteLine($"Число z = {x + y}");      //4
        }



    }
}
