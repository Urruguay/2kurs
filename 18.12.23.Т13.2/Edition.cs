using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18._12._23.Т13._2
{
    internal class Edition
    {
        private string name;
        private string fam;
        private int year;

        public string Name
        {
            get
            {
                return (name!="")?name:"Неизвестное произведение";
            }
            set
            {
                name = value;
            }
        }
        public string Fam
        {
            get
            {
                return (fam!="")?fam :"Неизвестный автор";
            }
            set
            {
                fam = value;
            }
        }
        public int Year
        {
            get
            {
                return year < 1800 || year > 2023 ? 0:year;
            }
            set
            {
                year = value;
            }
        }

        public Edition() { }
        public Edition(string name, string fam, int year)
        {
            this.Name = name;
            this.Fam = fam;
            this.Year = year;
        }
        public void VaryYear()
        {
            Write("Введите количество лет для изменения - ");
            int num = int.Parse(ReadLine());
            year += num;
            WriteLine($"Изменный год - {year}");

            if (year > 1800 && year < 2023)
            {
                WriteLine($"Год {year} попадает в заданный интервал");
            }
            else
            {
                WriteLine($"Год {year} не попадает в заданный интервал");
            }
        }
        public void Info()
        {
            WriteLine($"\nНазвание издания - {Name}\nФамилия автора - {Fam}\nГод издания - {Year}");
        }
    }
}
