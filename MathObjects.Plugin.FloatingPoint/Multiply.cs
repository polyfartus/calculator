﻿using System;
using MathObjects.Framework;
using MathObjects.Framework.Registry;

namespace MathObjects.Plugin.FloatingPoint
{
    public class Multiply : IMathOperation, IHasName
    {
        public int NumberOfParameters { get { return 2; } }

        public string Name
        {
            get { return "*"; }
        }

        public IMathObject Perform(IMathObject[] objs)
        {
            var leftValue = objs[0].GetDouble();
            var rightValue = objs[1].GetDouble();

            return new MultiplyObject(leftValue, rightValue);
        }

        public class Factory : IMathOperationFactory
        {
            public IMathOperation Create(object parm)
            {
                return new Multiply();
            }
        }
    }
}

