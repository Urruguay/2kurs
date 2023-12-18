using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18._12._23.Т13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edition ed1 = new Edition("МуМу", "Тургеньев", 1854);
            ed1.Info();
            ed1.VaryYear();
            Edition ed2 = new Edition();
            ed2.Name = "";
            ed2.Fam = "";
            ed2.Year = 1670;
            ed2.Info();
            Read();
        }
    }
}
