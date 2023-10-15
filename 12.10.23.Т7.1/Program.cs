using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Т7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Соответствие номера из таблицы Unicode символу

            //for (int i = 0; i <= 256; i++)
            //{
            // WriteLine($"Код {i} соответствует символу - {(char)i}");
            //}

            //Задача 2. Дан символ. Вывести его код

            //Write("Введите символ: ");
            //Char ch = Convert.ToChar(ReadLine());
            //WriteLine($"Символ {ch} имеет код - {(int)ch}");

            //Задача 3.Дан символ.Вывести символ, который в кодовой таблице ASCII следует за этим символом

            //Write("Введите символ: ");
            //Char simbol = Convert.ToChar(ReadLine());
            //WriteLine($"Символ {simbol} имеет код - {(int)simbol}");
            //WriteLine($"Следующий символ - {simbol}");


            char c = '9';
            int a = (int)c;
            a += 1;
            c = Convert.ToChar(a);
            Console.WriteLine(c);

            //Задача 4.Дан символ.Вывести два символа, стоящие перед ним в кодовой таблице ASCII

            //Write("Введите символ: ");
            //Char simbol1 = Convert.ToChar(ReadLine());

            //Задача 6.Дано название футбольного клуба.Напечатать его на экране «столбиком»

            //Write("Введите название фут.клуба: ");
            //string ch = ReadLine();
            //char[] omas = ch.ToCharArray();
            //for (int i = 0; i < omas.Length; i++)
            //{
            // WriteLine(omas[i]);
            //}

            // Задача 7. Составить программу, которая печатает заданное слово, начиная с последней буквы

            //Write("Введите Ваше слово: ");
            //string ch = ReadLine();
            //char[] omas = ch.ToCharArray();
            //for (int i = omas.Length - 1; i >= 0; i--)
            //{
            // WriteLine(omas[i]);
            //}


            //Задача 8. Преобразовать символы в строке из строчных в прописные и обратно

            //Write("Введите слово - ");
            //string str = ReadLine();
            //char[] sim = str.ToCharArray();
            //for (int i = 0; i < sim.Length; i++)
            //{
            //    Write(char.ToUpper(sim[i]));
            //}
            //WriteLine();
            //for (int i = 0; i < sim.Length; i++)
            //{
            //    Write(char.ToLower(sim[i]));
            //}



            ReadKey();

        }
    }
}
