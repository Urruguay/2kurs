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
            
            Build dom3 = new Build();
            Write("\n Введите имя строения (дом 3): ");
            dom3.name = ReadLine();
            Write(" Введите площадь строения: ");
            dom3.area = Convert.ToDouble(ReadLine());
            Write(" Введите количество жильцов: ");
            dom3.kvo = Convert.ToInt32(ReadLine());
            dom3.Showinfo();
            Read();
        }
    }
}
