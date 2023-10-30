using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _26._10._23.Т8._1
{
    internal class Program
    {

        //1.1. Вызов пустого метода Func без возвращения значений для вычисления функции y=x^2
        //and
        //1.2. Преобразуйте программу так, чтобы метод Func вызывался n раз.

        //static void Main(string[] args)
        //{
        //    Write("Введине n - ");
        //    int n = Convert.ToInt32(ReadLine());
        //    for(int i=0; i<n; i++) 
        //    {
        //        Func();
        //    }
        //    Read();
        //}
        //public static void Func()
        //{
        //    Write("Введите х - ");
        //    int x = Convert.ToInt32(ReadLine());
        //    int y = x * x;
        //    Write(y);
        //}

        //....................................//

        //1.3. Преобразуйте программу так, чтобы метод Func вычислял значение выражения:

        //static void Main(string[] args)
        //{
        //    Func();
        //    Read();
        //}
        //public static void Func()
        //{
        //    Write("Введите х - ");
        //    double x = Convert.ToInt32(ReadLine());
        //    double y = (3*Math.Pow(x, 2)+8*x-10)/15;
        //    Write(y);
        //}

        //....................................//

        //Задача 2. Нахождение суммы двух чисел с использованием метода сложения двух чисел.

        //static void Main(string[] args)
        //{
        //    Write("Введите х - ");
        //    int x = Convert.ToInt32(ReadLine());
        //    Write("Введите y - ");
        //    int y = Convert.ToInt32(ReadLine());
        //    Write(Sum(x,y));
        //    Read();
        //}
        //public static int Sum(int x,int y)
        //{
        //   return x + y;
        //}

        //....................................//

        //Задача 3. Вызов метода Func для вычисления функции y=x2,
        //в который будет передаваться значение х от a до b с шагом h, а сам метод возвращал значение y.

        //static void Main(string[] args) 
        //{
        //    Func();
        //    Read();
        //}
        //public static void Func() 
        //{
        //    Write("Введите x - ");
        //    int x=Convert.ToInt32(ReadLine());
        //    Write("Введите a - ");
        //    int a = Convert.ToInt32(ReadLine());
        //    Write("Введите b - ");
        //    int b = Convert.ToInt32(ReadLine());
        //    Write("Введите h - ");
        //    int h = Convert.ToInt32(ReadLine());
        //    for(int i=a;i<=b;i+=h) 
        //    {
        //        if (a<=x&& x<= b) 
        //        {
        //            double y = Math.Pow(x, 2);
        //            WriteLine($"y={y},x={x}");
        //            x += h;
        //        }
        //        else
        //        {
        //            WriteLine("x не в ходит в диапазон от a до b");
        //        }
        //    }

        //}

        //....................................//

        //Задача 4. Составьте таблицу значений функции y = 5x² - 2x +1 на отрезке [-5; 5] с шагом h = 2 с использованием дополнительного метода.

        //static void Main(string[] args)
        //{
        //    Func();
        //    Read();
        //}
        //public static void Func()
        //{
        //    Write("Введите x  -  ");
        //    int x = Convert.ToInt32(ReadLine());
        //    for (int i = -5; i <= 5; i ++)
        //    {
        //        if (-5 <= x && x <= 5)
        //        {
        //            double y = 5*Math.Pow(x, 2)-2*x+1;
        //            WriteLine($"y={y},x={x}");
        //            x += 2;
        //        }
        //    }

        //}

        //....................................//

        //Задача 5. Напишите дополнительный метод для вычисления функции:

        //static void Main(string[] args) 
        //{
        //    Write("Введите x  -  ");
        //    int x=Convert.ToInt32(Console.ReadLine());
        //    Func(x);
        //    Read();
        //}
        //public static void Func(int x)
        //{
        //    double y;
        //    if (x < 5)
        //    {
        //        y = (4 * Math.Pow(x, 2) + 1) / x - 5;
        //    }
        //    else
        //    {
        //        y =3 * Math.Pow(x, 2) - 2;
        //    }
        //    WriteLine(y);
        //}

        //....................................//

        //Задача 6. Создайте приложение, которое выводит сумму, вычитание, умножение и деление двух параметров входных данных.

        //static void Main(string[] args)
        //{
        //    Write("Введите x  -  ");
        //    int x = Convert.ToInt32(ReadLine());
        //    Write("Введите y  -  ");
        //    int y = Convert.ToInt32(ReadLine());
        //    int sum = Add(x, y);
        //    int dif = Dif(x, y);
        //    int mult = Mult(x, y);
        //    double delay = Delay(x, y);
        //    WriteLine($"Сумма = {sum}\n Разность = {dif}\n Произведение = {mult}\n Деление = {delay}");
        //    Read();
        //}
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Dif(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int Mult(int x, int y)
        //{
        //    return x * y;
        //}
        //public static double Delay(int x, int y)
        //{
        //    return (double)x / y;
        //}

        //....................................//


        // Домашнее задание.


        //1. Нахождение максимальной величины из двух целых переменных a, b.

        //static void Main(string[] args)
        //{
        //    Maximum();
        //    ReadLine();
        //}
        //static void Maximum()
        //{

        //    WriteLine("Введите ваши числа  -  ");
        //    int[] mass = new int[3];
        //    int i;
        //    for (i = 0; i < mass.Length; i++)
        //    {
        //        int a = Convert.ToInt32(ReadLine());
        //        mass[i] = a;
        //    }

        //    double sum = 0;
        //    for (int b = 0; b < mass.Length; b++)
        //    {
        //        sum += mass[b];
        //    }
        //    double cr = sum / mass.Length;
        //    WriteLine(cr);
        //}

        //................//

        //2. Вычислить среднее арифметическое трех действительных чисел.

        //static void Main(string[] args)
        //{
        //    Arifm();
        //    ReadKey();
        //}
        //static void Arifm()
        //{
        //    Write("Введите a  -  ");
        //    double a = Convert.ToDouble(ReadLine());
        //    Write("Введите b  -  ");
        //    double b = Convert.ToDouble(ReadLine());
        //    Write("Введите c  -  ");
        //    double c = Convert.ToDouble(ReadLine());
        //    WriteLine("Среднее арифметич.  -  "+ (a + b + c)/3);
        //}

        //................//

        //3. Составьте таблицу значений функции y = 4x² + 5x - 10 на отрезке [-9; 9] с шагом h = 3.

        static void Main(string[] args)
        {
            Func();
            Read();
        }
        public static void Func()
        {
            Write("Введите x  -  ");
            int x = Convert.ToInt32(ReadLine());
            for (int i = -9; i <= 9; i++)
            {
                if (-9 <= x && x <= 9)
                {
                    double y = 4 * Math.Pow(x, 2) + 5 * x - 10;
                    WriteLine($"y  -  {y}\t x  -  {x}");
                    x += 3;
                }
            }

        }
    }
}
