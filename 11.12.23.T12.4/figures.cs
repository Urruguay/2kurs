using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11._12._23.T12._4
{
    /// <summary>
    /// Класс с фигурами
    /// </summary>
    internal class Figures
    {
        /// <summary>
        /// Поле с названием фигуры
        /// </summary>
        public string name;
        /// <summary>
        /// Поле одной стороны
        /// </summary>
        public int side1;
        /// <summary>
        /// Поле второй стороны
        /// </summary>
        public int side2;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Figures() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Figures(string name, int side1, int side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Метод для вычисления периметра и площади
        /// </summary>
        public void Func()
        {
            int P = 2 * (side1 + side2);
            int S = side1 * side2;
            WriteLine($"Периметр = {P}\nПлощадь = {S}");
        }
        public void Funrtr()
        {
            int P = side1 + side2 + side3;
            WriteLine($"Периметр = {P}");
        }
        /// <summary>
        /// Метод с информацией о какой-либо фигуре
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"\nНазвание фигуры - {name}\nСторона 1 - {side1}см\nСторона 2 - {side2}см\nСторона 3 - {side3}см");
        }
        /// <summary>
        /// Добавляем 3 поле
        /// </summary>
        public int side3;

        public Figures(string name, int side1, int side2, int side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
    }
}
