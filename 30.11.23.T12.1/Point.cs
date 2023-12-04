using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30._11._23.T12._1
{
    /// <summary>
    /// Класс Point производящий расчеты
    /// </summary>
     class Point
    {
        public int x;
        public int y;
        /// <summary>
        /// Конструктор создающий экземпляр класса с нулевыми координатами
        /// </summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        /// <summary>
        /// Конструктор создающий экземпляр класса с заданными параметрами
        /// </summary>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Vyvod()
        {
            WriteLine($"X = {x}\n Y = {y}");
        }
        public double Calculation()
        {
            return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
        }
     }
}
