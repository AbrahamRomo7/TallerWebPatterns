﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Car : Vehicle
    {
        public override int Tires { get => 4; }
        private int Year;

        public Car(string color, string brand, string model) : base(color, brand, model, year)
        {
            Year = Year;
        }
    }
}
