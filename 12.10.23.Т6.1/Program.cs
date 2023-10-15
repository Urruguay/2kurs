using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _12._10._23.Т6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Вывести на экран в столбик целые числа из интервала от 1 до n
            //(для решения задачи использовать операторы циклов: for, while, do -while).
            // for //
            //Write("Введите целое число n  -  ");
            //int fn = Convert.ToInt32(ReadLine());
            //for(int i = 1; i <= fn; i++)
            //{
            //    WriteLine(i);
            //}

            // do...while //

            //Write("Введите целое число n  -  ");
            //int dwn = Convert.ToInt32(ReadLine());
            //int k = 1;
            //do
            //{

            //    WriteLine(k);
            //    k++;
            //}
            //while(k <= dwn);

            // while //

            //Write("Введите целое число n  -  ");
            //int wn = Convert.ToInt32(ReadLine());
            //int l = 1;
            //while (l <= wn)
            //{
            //    WriteLine(l);
            //    l++;
            //}

            //.....................................//

            //Задача 2.Вывести четные двузначные числа и подсчитать их количество.

            //int num = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if(i%2==0)
            //    {
            //        num++;
            //        WriteLine(i);
            //    }
            //}
            //WriteLine($"Количество чётных двузначных чисел равно  -  {num}");

            //.....................................//

            //Задача 3.Составьте таблицу значений функции y = 2х2 + 4x - 5 на отрезке[-5; 5] с шагом h = 0,2
            //(для решения задачи использовать операторы циклов: for, while, do -while).
            // for //

            //double Xmin = -5, Xmax = 5, h = 0.2;
            //WriteLine("X \t Y");
            //for(double x = Xmin; x <= Xmax; x+=h)
            //{
            //    WriteLine($"{x:f2} \t {2 * Math.Pow(x,2) + 4 * x - 5:f2}");
            //}

            // do...while //

            //double Xmin = -5, Xmax = 5, h = 0.2, x = Xmin;
            //WriteLine("X \t Y");
            //do
            //{
            //    WriteLine($"{x:f2} \t {2 * Math.Pow(x, 2) + 4 * x - 5:f2}");
            //    x += h;

            //}
            //while (x <= Xmax);

            // while //

            //double Xmin = -5, Xmax = 5, h = 0.2, x = Xmin;
            //WriteLine("X \t Y");
            //while (x <= Xmax)
            //{
            //    WriteLine($"{x:f2} \t {2 * Math.Pow(x, 2) + 4 * x - 5:f2}");
            //    x += h;
            //}

            //.....................................//

            //Задача 4.Найти сумму чисел, кратных 5, в пределах от 0 до 1000.

            //int cou = 0, d = 0;
            //WriteLine("Все числа кратные пяти   -   \n");
            //while (d <= 1000)             
            //{
            //    if (d % 5 == 0)        
            //    {
            //        Write($"{d};\t");
            //        cou += d;        
            //    }
            //    d++;
            //}
            //WriteLine($"\n\n Сумма всех чисел кратных пяти  -  {cou}");

            //.....................................//

            //Задача 5. Определить количество цифр заданного числа.

            Write("Введите целое число  -  ");
            int number = Convert.ToInt32(ReadLine());
            int n = 0;
            do
            {
                number /= 10;
                n++;
            }
            while (number != 0);
            WriteLine($"Количество цифр данного числа равно  -  {n}");

            //.........................................//
            //Write("Введите целое число  -  ");
            //int number = Convert.ToInt32(ReadLine());
            //WriteLine((int)Math.Log10(number) + 1);
            //.........................................//

            ReadKey();

        }
    }
}
