﻿using System;
using MathObjects.Framework;
using MathObjects.Core.DecoratableObject;

namespace MathObjects.Plugin.FloatingPoint
{
    [ClassDecoration("name", "^")]
    class ExponentObject : IHasOutput, IMathObject, IHasDisplayValue
    {
        readonly double tuple1;

        readonly double tuple2;

        public ExponentObject(double tuple1, double tuple2)
        {
            this.tuple1 = tuple1;
            this.tuple2 = tuple2;
        }

        public object Output
        {
            get { return (Math.Pow(tuple1, tuple2)); }
        }

        public string DisplayValue 
        { 
            get { return this.Output.ToString(); }
        }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}

