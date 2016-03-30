﻿using System;
using MathObjects.Framework;
using MathObjects.Framework.Parser;

namespace MathObjects.Plugin.FloatingPoint.Func
{
    class TopOperationFactory : AbstractMathObject, IMathOperationFactory2
    {
        IMathObjectStack stack;

        public void Init(IMathFunctionContext context)
        {
            stack = (context as IHasMathObjectStack).Stack;
        }

        public IMathOperation Perform(IMathFunctionContext context)
        {
            return new TopOperation(stack);
        }
    }
}
