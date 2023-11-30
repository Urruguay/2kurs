using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

    /// <summary>
    /// Класс Person представляющий человека
    /// </summary>
    class Person
    {
    /// <summary>
    /// Поле описывающее имя
    /// </summary>
        public string name;
    /// <summary>
    /// Поле описывающее фамилию
    /// </summary>
        public string surname;
    /// <summary>
    /// Поле описывающее возраст
    /// </summary>
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
