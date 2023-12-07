using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _07._12._23.T12._3
{
    /// <summary>
    /// класс с указанными двумя полями
    /// </summary>
    class Task1
    {
        /// <summary>
        /// поле 1 вещественного типа
        /// </summary>
        public double num1;
        /// <summary>
        /// поле 2 вещественного типа
        /// </summary>
        public double num2;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Task1() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
         public Task1(double num1)
        {
            this.num1 = num1;
        }
        //public Task1(double num1, double num2)
        //{
        //    this.num1 = num1;
        //    this.num2 = num2;
        //}
        public Task1(double num1, double num2): this(num1)
        {
            this.num2 = num2;
        }
        /// <summary>
        /// Метод Funk обрабатывающий значение полей
        /// </summary>
        public double Funk()
        {
            return Math.Sqrt(num1 * num2);
        }
        /// <summary>
        /// Метод с информацией об объекте
        /// </summary>
        public void Info()
        {
            WriteLine($"\n число 1 - {num1}\n число 2 - {num2}\n вычисление - {Funk():f2}");
        }
    }
}
