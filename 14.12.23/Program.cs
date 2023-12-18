using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telephone tel1 = new Telephone();
            tel1.owner = "Lenovo";
            tel1.model = "K5 Pro";
            tel1.price = 2350;
            tel1.Info();

            Telephone tel2 = new Telephone("Apple", "iPhone 15+", 21896);
            tel2.Info();

            Write("\nВладелец телефона - ");
            string owner = ReadLine();
            Write("Модель телефона - ");
            string model = ReadLine();
            Write("Цена телефона - ");
            int price = Convert.ToInt32(ReadLine());
            Telephone tel3 = new Telephone(owner, model, price);
            tel3.Info();

            Read();
        }
    }
}
