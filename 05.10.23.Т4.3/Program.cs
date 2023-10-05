using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05._10._23.Т4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №8
            //Запросить у пользователя 5 слов, после чего вывести эти слова в одну строку,
            //каждое через промежуток несколько символов от предыдущего. Использовать 5 функций вывода.

            Title = "Программа№3 (Шурдук)";     // Даём окну консоли название «Программа №3 (Ваша_фамилия)»
            WriteLine("Пожалуйста, введите пять слов:");     //Просим пользователя ввести 5 слов
            Write("Введите первое слово - ");           //Пользователь введёт первое слово
            string word1 = ReadLine();
            Write("Введите второе слово - ");           //Пользователь введёт второе слово
            string word2 = ReadLine();
            Write("Введите третье слово - ");           //Пользователь введёт третье слово
            string word3 = ReadLine();
            Write("Введите четвертое слово - ");        //Пользователь введёт четвертое слово
            string word4 = ReadLine();
            Write("Введите пятое слово - ");            //Пользователь введёт пятое слово
            string word5 = ReadLine();
            Write($"{word1}\t");           //Выводим слово которое ввёл пользователь через некоторый промежуток символов,
            Write($"{word2}\t");           //используя 5 ф-ций вывода
            Write($"{word3}\t");
            Write($"{word4}\t");
            Write($"{word5}\t");
        }
    }
};
            
