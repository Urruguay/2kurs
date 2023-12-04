using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30._11._23.T12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            /*Person person = new Person();
            Person person1 = new Person("Виктория","Шурдук",16);
            person1.Getinfo();
            Read();*/

            //Задание 2

            Point point = new Point();
            Point point1 = new Point(3, 4);
            WriteLine("");
            point.Vyvod();
            point1.Calculation();
            Read();
        }
    }
}
