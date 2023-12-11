using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11._12._23.T12._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figures figure1 = new Figures();
            figure1.name = "Прямоугольник";
            figure1.side1 = 12;
            figure1.side2 = 10;
            figure1.ShowInfo();
            figure1.Func();

            Figures figure2 = new Figures("Квадрат", 12, 12);
            figure2.ShowInfo();
            figure2.Func();

            Figures figure3 = new Figures("Треугольник", 2, 3, 4);
            figure3.ShowInfo();
            figure3.Funrtr();

            Figures figure4 = new Figures();
            figure4.name = "Треугольник";
            figure4.side1 = 3;
            figure4.side2 = 4;
            figure4.side3 = 5;
            figure4.ShowInfo();
            figure4.Funrtr();

            Read();
        }
    }
}
