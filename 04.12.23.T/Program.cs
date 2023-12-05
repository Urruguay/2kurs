using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04._12._23.T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();

            dom1.name = "Квартира";
            dom1.area = 150;
            dom1.kvo = 5;
            dom1.Showinfo();

            Build dom2 = new Build("Дача", 200, 8);
            dom2.Showinfo();
            
            Write("\n Введите имя строения (дом 3): ");
            string name =Console.ReadLine();
            Write(" Введите площадь строения: ");
            double area = Convert.ToDouble(ReadLine());
            Write(" Введите количество жильцов: ");
            int kvo = Convert.ToInt32(ReadLine());
            Build dom3=new Build(name, area, kvo);


            Read();
        }
    }
}
