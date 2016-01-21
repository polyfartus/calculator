﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.FloatingPoint
{
    class ConstantObject : IHasOutput, IMathFunction, IHasDisplayValue
    {
        readonly double value;

        public ConstantObject(double value)
        {
            this.value = value;
        }

        public object Output
        {
            get { return value; }
        }

        public string DisplayValue 
        { 
            get { return "" + this.value; } 
        }

        public void Perform(IMathFunctionContext context)
        {
        }
    }
}
