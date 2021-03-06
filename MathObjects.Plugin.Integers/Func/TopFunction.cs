﻿using System;
using MathObjects.Framework;
using MathObjects.Framework.Parser;

namespace MathObjects.Plugin.Integers.Func
{
    class TopFunction : AbstractMathObject, IMathOperationFactory2
    {
        IMathObject top;

        IMathObjectStack stack;

        public void Init(IMathOperationFactoryContext context)
        {
            stack = (context as IHasMathObjectStack).Stack;
            top = stack.Top;
        }

        public IMathOperation Perform(IMathOperationFactoryContext context)
        {
            return new TopOperation(stack, top);
        }
    }
}

