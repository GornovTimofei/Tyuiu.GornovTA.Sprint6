﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GornovTA.Sprint6.Task0.V26.Lib
{
    public class DataService : ISprint6Task0V26
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow((double)x, 2) + 1) / (3 * x + 4);
            return Math.Round(res, 3);
        }
    }
}