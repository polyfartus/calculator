﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.Integers
{
    public class FunctionFactory : IMathObjectFactory
    {
        readonly Type functionClass;

        public FunctionFactory(Type functionClass)
        {
            this.functionClass = functionClass;
        }

        public IMathObject Create(IMathObjectFactoryContext context)
        {
            var c = functionClass.GetConstructor(new Type[]{ });

            return c.Invoke(new object[]{ }) as IMathObject;
        }
    }
}

