﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Task.Models
{
    internal class Stage2:Block
    {
        public string FamilyName { get; set;  }
        public override void Which()
        {
            Console.WriteLine($"This is Stage2. Family: {FamilyName}");

        }
    }
}
