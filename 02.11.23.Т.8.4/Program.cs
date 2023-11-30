using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02._11._23.Т._8._4
{
    internal class Program
    {
        //Задача 1. Составить программу,
        //в результате которой величина а меняется значением с величиной b,
        //а величина b — с величиной c. Определить метод, осуществляющий обмен значениями двух переменных величин.
        /*public static void Main(string[] args)
        {
            Write("Введите число a - ");
            char a = Convert.ToChar(ReadLine());
            Write("Введите число b - ");
            char b = Convert.ToChar(ReadLine());
            Write("Введите число c - ");
            char c = Convert.ToChar(ReadLine());


            WriteLine($"a = {a}; b = {b}; c = {c}");
            Exchange(ref a, ref b, ref c);
            WriteLine($"a = {a}; b = {b}; c = {c}");
            Read();
        }
        public static void Exchange(ref char a, ref char b, ref char c)
        {
            char d = a;
            a = b;
            b = d;
            d = c;
            c = a;
            a = d;
 
        }*/


        //Задача 2. Ввести три целых числа и вывести их в порядке возрастания значений.

        /*public static void Main(string[] args)
        {
            Write("Введите число a - ");
            int a = Convert.ToInt32(ReadLine());
            Write("Введите число b - ");
            int b = Convert.ToInt32(ReadLine());
            Write("Введите число c - ");
            int c = Convert.ToInt32(ReadLine());


            WriteLine($"a = {a}; b = {b}; c = {c}");
            Increment(ref a, ref b, ref c);
            Read();

        }
        public static void Increment(ref int a, ref int b, ref int c)
        {
            int[] nums = { a, b, c };
            Array.Sort(nums);
            foreach (int num in nums) WriteLine(num);
        }*/


        //Задача 3. Создать метод, который будет вычислять площадь круга и длину окружности.
        //Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса,
        //площади круга и длины окружности.
        
        static void Main()
        {
            // Пример вызова метода для вычисления площади круга и длины окружности
            double radius = 5.0; // радиус круга

            // вызываем метод для вычисления площади круга и длины окружности
            CalculateCircleInfo(radius);
            Read();
        }

        static void CalculateCircleInfo(double radius)
        {
            double area = Math.PI * radius * radius; // вычисляем площадь круга
            double circumference = 2 * Math.PI * radius; // вычисляем длину окружности

            // выводим значения на консоль
            Console.WriteLine($"Радиус круга: {radius}");
            Console.WriteLine($"Площадь круга: {area}");
            Console.WriteLine($"Длина окружности: {circumference}");
        }
    }

}

