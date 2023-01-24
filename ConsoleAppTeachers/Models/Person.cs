using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeachers.Models
{
    internal class Person : Entity
    {
        internal string Firstname { get; set; }
        internal string Lastname { get; set; }
        internal string FatherName { get; set; }
        internal int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} {FatherName}";
        }
    }
}
