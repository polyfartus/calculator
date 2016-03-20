﻿using System;

namespace MathObjects.Framework.Parser.Tests
{
    public class TestUniraryOperation : IMathOperation 
    {
        public IMathObject Perform(IMathObject[] target)
        {
            return new TestObject("(" + target[0].GetString() + ")");
        }

        public string Symbol { get { return "unirary"; } }

        public int NumberOfParameters {  get { return 1; } }
    }
}

