using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace _07._12._23.T12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            Task1 dek = new Task1();
            dek.num1 = 31.3;
            dek.num2 = 4;
            dek.Info();
            WriteLine($"{dek.Funk()}");

            Task1 dek1 = new Task1(12.3, 3);
            dek1.Info();
            WriteLine($"{dek1.Funk()}");

            Write("\n Введите число 1: ");
            double num1 = Convert.ToDouble(ReadLine());
            Write(" Введите число 2: ");
            double num2 = Convert.ToDouble(ReadLine());
            Task1 dek2 = new Task1(num1, num2);
            dek2.Info();
            WriteLine($"{dek2.Funk()}");

            //Задача 2



            Read();
        }
    }
}
