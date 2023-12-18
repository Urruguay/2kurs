using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14._12._23.T13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Иванов", 3);
            st1.ShowInfo();

            Student st2 = new Student("", -7);
            st2.ShowInfo();

            Read();
        }
    }
}
