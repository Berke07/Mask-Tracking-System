﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public long NationalIdentity { get; set; }
        public int BornYear { get; set; }
    }
}
