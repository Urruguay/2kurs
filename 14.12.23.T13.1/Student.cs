using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14._12._23.T13._1
{
    internal class Student
    {
        private string fam;
        private int kurs;


        public string Fam
        {
            get
            {
                return (fam!="")?fam:"Неизвестный";
            }
            set
            {
                fam = value.ToUpper();
            }
        }

        public int Kurs
        {
            get
            {
                return kurs < 1 || kurs > 4 ? 0:kurs;
            }
            set
            {
                kurs = value;
            }
        }

        public Student(string fam, int kurs)
        {
            this.Fam = fam;
            this.Kurs = kurs;
        }

        public void ShowInfo()
        {
            WriteLine($"\nФамилия - {Fam}\nКурс - {Kurs}");
        }

        public string name;
        public int age;

        public Student(string fam, int kurs, string Fam, int Kurs, string name, int age) : this(fam, kurs)
        {
            Fam = fam;
            Kurs = kurs;
            this.name = name;
            this.age = age;
        }
    }
}
