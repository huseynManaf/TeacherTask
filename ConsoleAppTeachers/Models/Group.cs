using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeachers.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher[] Teachers { get; set; } = new Teacher[50];

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
