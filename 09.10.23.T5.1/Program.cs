using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задача 1. Определить, является или нет текущий год високосным? Год ввести с клавиатуры

            //WriteLine("Введите год: ");
            //int year = Convert.ToInt32(ReadLine());
            //if (year % 4 == 0)
            //{
            //    WriteLine("Год високосный");
            //}
            //else
            //{
            //    WriteLine("Год не високосный");
            //}
            //ReadKey();

            ////Задача 2.Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс.р.

            //Write("Введите цену ноутбука (т.р) : ");
            //int price = Convert.ToInt32(ReadLine());
            //if (price >= 20 & price <= 30)
            //{
            //    WriteLine("Цена входит в диапазон от 20 до 30т.р");
            //}
            //else
            //{
            //    WriteLine("Цена не входит в диапазон от 20 до 30т.р");
            //}
            //ReadKey();

            ////Задача 2.Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс.р. с помощью теранрного оператора

            //Write("Введите цену ноутбука (т.р) : ");
            //int price = Convert.ToInt32(ReadLine());
            //string a = price >= 20 & price <= 30 ? ("Цена входит в диапазон от 20 до 30т.р") : ("Цена не входит в диапазон от 20 до 30т.р");
            //WriteLine(a);
            //ReadKey();

            ////Задача 3.Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице:

            //Write("Введите баллы: ");
            //int points = Convert.ToInt32(ReadLine());
            //if (points >= 0 & points <= 59)
            //{
            //    WriteLine("Неудовлетворительно");
            //}
            //else if (points >= 60 & points <= 74)
            //{
            //    WriteLine("Удовлетворительно");
            //}
            //else if (points >= 75 & points <= 89)
            //{
            //    WriteLine("Хорошо");
            //}
            //else if (points >= 90 & points <= 100)
            //{
            //    WriteLine("Отлично");
            //}
            //ReadLine();

            ////Задача 4. Светофор закодирован тремя состояниями: 1 – красный, 2 – желтый, 3 – зеленый.
            ////В зависимости от состояния определить цвет светофора.

            //Random rnd = new Random();
            //int color = rnd.Next(0, 3);
            //switch (color)
            //{
            //    case 1:
            //        WriteLine("Красный");
            //        break;
            //    case 2:
            //        WriteLine("Желтый");
            //        break;
            //    case 3:
            //        WriteLine("Зеленый");
            //        break;
            //    default:
            //        WriteLine("Нет такого цвета");
            //        break;
            //}
            //ReadLine();

            ////Задача 5. Проверка знака случайного числа и его чётности.

            //Write("Введите число: ");
            //double a = Convert.ToDouble(ReadLine());
            //if (a < 0 & a % 2 == 0)
            //{
            //    WriteLine("Отрицательное, четное");
            //}
            //else if (a > 0 & a % 2 == 0)
            //{
            //    WriteLine("Положительное, четное");
            //}
            //else if (a < 0 & a % 2 != 0)
            //{
            //    WriteLine("Отрицательное, не четное");
            //}
            //else if (a > 0 & a % 2 != 0)
            //{
            //    WriteLine("Положительное, не четное");
            //}
            //else if (a == 0)
            //{
            //    WriteLine("Ноль");
            //}
            //ReadLine();

            ////Задача 6.Выбор дня недели.

            //Write("Введите день недели: ");
            //byte day = byte.Parse(ReadLine());
            //switch (day)
            //{
            //    case 1: WriteLine("Понедельник"); break;
            //    case 2: WriteLine("Вторник"); break;
            //    case 3: WriteLine("Среда"); break;
            //    case 4: WriteLine("Четверг"); break;
            //    case 5: WriteLine("Пятница"); break;
            //    case 6: WriteLine("Суббота"); break;
            //    case 7: WriteLine("Воскресенье"); break;

            //    default: WriteLine("Error"); break;
            //}
            //ReadKey();

            ////Задача 7.Проверка логина и пароля, введенных с клавиатуры.
        }
    }
}
