﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethodOverloading
{
    // C# Code
    // Overloaded Add() method
    public static class AddOperations
    {
        // Overloaded Add() method
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
