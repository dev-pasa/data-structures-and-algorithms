﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public abstract class Animal
    {
        public object Value { get; set; }
        public Animal Next { get; set; }
    }
}
