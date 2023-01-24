using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeachers.Models
{
    internal class teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];

    }
}
