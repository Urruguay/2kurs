using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _02._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            //Title = "Программа #1(Шурдук)";
            //WriteLine("Введите пять слов");
            //Write("Введите первое слово - ");
            //string word1 = ReadLine();
            //Write("Введите второе слово - ");
            //string word2 = ReadLine();
            //Write("Введите третье слово - ");
            //string word3 = ReadLine();
            //Write("Введите четвертое слово - ");
            //string word4 = ReadLine();
            //Write("Введите пятое слово - ");
            //string word5 = ReadLine();
            //WriteLine($"{word1}{"!"}{word1}{"!"}{word3}{"!"}{word3}{"!"}{word5}{"!"}{word5}{"!"}" +
            //    $"{word2}{"!"}{word2}{"!"}{word2}{"!"}{word4}{"!"}{word4}{"!"}{word4}");

            //Задание 2

            //Title = "Программа #1(Шурдук)";
            //WriteLine("Введите пять слов");
            //Write("Введите первое слово - ");
            //string word1 = ReadLine();
            //Write("Введите второе слово - ");
            //string word2 = ReadLine();
            //Write("Введите третье слово - ");
            //string word3 = ReadLine();
            //Write("Введите четвертое слово - ");
            //string word4 = ReadLine();
            //Write("Введите пятое слово - ");
            //string word5 = ReadLine();
            //Write($"{word1}\n{word2}\n");
            //WriteLine($"{word3}\n{word4}");
            //WriteLine($"{word5}");

            //Задание 3

            CursorVisible = false;
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            Title = "Вика";
            Beep(622, 90);
            Write("Как вас зовут?   -   ");
            string name = ReadLine();
            WriteLine($"Приветствую Вас - {name} !");
            Beep(264, 125);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(125);
            Beep(297, 500);
            Thread.Sleep(125);
            Beep(264, 500);
            Thread.Sleep(125);
            Beep(352, 500);
            Thread.Sleep(125);
            Beep(330, 1000);
            Thread.Sleep(250);

            Console.WriteLine("Caps Lock    -     " + (CapsLock ? "On" : "Off"));
            Console.WriteLine("Num Lock    -    " + (NumberLock ? "On" : "Off"));

            
            ReadKey();
        }
    }
}
