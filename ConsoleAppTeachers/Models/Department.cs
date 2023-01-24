﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeachers.Models
{
    internal class Department : Entity
    {
        internal Teacher[] Teachers { get; set; } = new Teacher[10];
        internal Person Leader { get; set; }

        public override string ToString()
        {
            string printInfo = "";

            foreach (var item in Teachers)
            {
                if (item == null)
                    continue;

                printInfo += item.ToString() + "\n";
            }

            return $"{Leader} \n Teachers:\n{printInfo}";
        }
    }
}

