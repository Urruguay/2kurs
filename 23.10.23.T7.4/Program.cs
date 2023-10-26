using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _23._10._23.T7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.      Разработать программу с использованием класса StringBuilder, которая для заданной строки s:
            //Вариант 1.      вставляет символ x после каждого вхождения символа y

            //Write("Введите строку  -  ");
            //StringBuilder s = new StringBuilder(ReadLine());
            //WriteLine("Ваша строка  -  " + s);
            //Write("Введите символ X  -  ");
            //char x = Convert.ToChar(ReadLine());
            //Write("Введите символ Y  -  ");
            //char y = Convert.ToChar(ReadLine());
            //for (int i = 0; i < s.Length; i++)
            //    if (s[i] == y)
            //    {
            //        s.Insert(i + 1, x);
            //        i++;
            //    }
            //WriteLine(s);

            //...........................................//

            //Задание 2.      Дана строка, в которой содержится осмысленное текстовое сообщение. Слова сообщения разделяются пробелами и знаками препинания.
            //Вариант 1.      Вывести только те слова сообщения, которые содержат не более чем n букв.

            Write("Введите предложение  -  ");
            string soo = ReadLine();
            Write("Кол-во букв в слове  -  ");
            int n = int.Parse(ReadLine());
            var mass = soo.Split(new char[] { ' ', ',', '.', '!', '?', '-', '\\' }).Where(x => x.Length > 1);
            mass = mass.Where(x => x.Length <= n);
            foreach (var item in mass)
                WriteLine(item);

            ReadKey();
        }
    }
}
