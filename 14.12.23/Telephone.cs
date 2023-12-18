using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14._12._23
{
    /// <summary>
    /// Класс о телефоне
    /// </summary>
    internal class Telephone
    {
        /// <summary>
        /// Поле владельца
        /// </summary>
        public string owner;
        /// <summary>
        /// Поле о названии модели
        /// </summary>
        public string model;
        /// <summary>
        /// Поле о цене телефона
        /// </summary>
        public int price;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Telephone() { }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        public Telephone(string owner)
        {
            this.owner = owner;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        public Telephone(string owner, string model) : this(owner)
        {
            this.model = model;
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        public Telephone(string owner, string model, int price) : this(owner, model)
        {
            this.price = price;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            WriteLine($"\nВладелец - {owner}\nМодель телефона - {model}\nЦена телефона(RUP) - {price} рублей ПМР");
        }
    }
}
