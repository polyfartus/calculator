﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.Rational
{
    public class Multiply : IBinaryOperation
    {
        public IMathObject Perform(IMathObject left, IMathObject right)
        {
            var leftValue = GetTuple(left);
            var rightValue = GetTuple(right);

            var op = new TupleMultiply(leftValue, rightValue);

            return new MathObject(op.Output);
        }

        Tuple<int, int> GetTuple(IMathObject obj)
        {
            var hasTuple = obj as IHasTuple;
            if (hasTuple != null)
            {
                return hasTuple.Tuple;
            }

            var hasOutput = obj as IHasOutput;
            if (hasOutput != null)
            {
                var has2 = hasOutput.Output as IHasTuple;
                return has2.Tuple;
            }

            throw new Exception();
        }

        public class Factory : IMathOperationFactory, IMathOperationMeta
        {
            public string Name
            {
                get { return "Multiply"; }
            }

            public IBinaryOperation Create(object parm)
            {
                return new Multiply();
            }
        }
    }
}

