﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface IPricingStrategy
    {
        double CalculatePrice(double price);
    }
}