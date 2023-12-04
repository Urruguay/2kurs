using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04._12._23.T
{
    /// <summary>
    /// Класс Build описывающий проект строения
    /// </summary>
    internal class Build
    {
        /// <summary>
        /// Поле описывающие имя строения
        /// </summary>
        public string name;
        /// <summary>
        /// Поле описывающее площадь строения
        /// </summary>
        public double area;
        /// <summary>
        /// Поле описывающе кол-во жильцов
        /// </summary>
        public int kvo;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Build() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Build(string name, double area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        /// <summary>
        /// Метод выводящий информацию о строении и вычисляет площадь на одного жильца
        /// </summary>
        public void Showinfo()
        {
            WriteLine($"\n Название строения - {name}\n Площадь строения - {area}\n Кол-во жильцов - {kvo}\n Площадь на одного жильца - {area/kvo}");
        }
    }
}
