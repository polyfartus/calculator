﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.FloatingPoint.MathFunc
{
    delegate double MathHandler(double input);

    class MathOperation : IMathOperation
    {
        readonly MathHandler handler;

        public int NumberOfParameters { get { return 1; } }

        public MathOperation(MathHandler handler)
        {
            this.handler = handler;
        }

        public IMathObject Perform(IMathObject[] target)
        {
            return new MathObject(handler(target[0].GetDouble()));
        }

        public class Factory : IMathOperationFactory, IHasName
        {
            readonly string name;

            readonly MathHandler handler;

            public Factory(string name, MathHandler handler)
            {
                this.name = name;
                this.handler = handler;
            }

            public string Name
            {
                get { return name; }
            }

            public IMathOperation Create(object param)
            {
                return new MathOperation(handler);
            }
        }
    }
}

