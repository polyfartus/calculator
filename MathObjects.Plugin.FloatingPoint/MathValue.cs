﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.FloatingPoint
{
    public class MathValue : AbstractMathObject, IMathValue
    {
        readonly double value;

        public MathValue(double value)
        {
            this.value = value;
        }

        public object Value
        {
            get { return this.value; }
        }

        public bool IsDefinded 
        { 
            get { return true; } 
        }

        public override string ToString()
        {
            return "" + value;
        }
    }
}

