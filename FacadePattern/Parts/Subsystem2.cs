﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Parts
{
    public enum EnumSubsystem2 { Enum1 = 0, Enum2 = 1, Enum3 = 2 }

    public class Subsystem2
    {
        public EnumSubsystem2 EnumSubsystem2;
        public int Field1;
        public int Field2;
        public int Field3;
        public int Field4;
    }
}
