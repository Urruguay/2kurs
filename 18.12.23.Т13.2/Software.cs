using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._23.Т13._2
{
    internal class Software
    {
        private string name;
        private string manufacturer;
        private string paid;

        public string Name
        {
            get
            {
                return (name != "") ? name : "Неизвестное ПО";
            }
            set
            {
                name = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return (manufacturer != "") ? manufacturer : "Неизвестный производитель ПО";
            }
            set
            {
                manufacturer = value;
            }
        }
        public string Paid
        {
            get
            {
                return paid;
            }
            set
            {
                paid = value;
            }
        }
    }
}
