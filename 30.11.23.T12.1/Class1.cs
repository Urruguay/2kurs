using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30._11._23.T12._1
{
    /// <summary>
    /// Класс Person представляющий человека
    /// </summary>
    class Person
    {
        public string name;
        public string surname;
        public int age;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        /// <summary>
        /// Метод Getinfo который выводит все данные на консоль
        /// </summary>
        public void Getinfo()
        {
            WriteLine($"name - {name}\n surname - {surname}\n age - {age}");
        }
    }
}
