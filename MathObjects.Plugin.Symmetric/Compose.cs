﻿using System;
using MathObjects.Framework;
using MathObjects.Core.Matrix;
using MathObjects.Core.Matrix.Permutation;
using MathObjects.Core.DecoratableObject;

namespace MathObjects.Plugin.Symmetric
{
    class Compose : AbstractMathOperation
    {
        public override int NumberOfParameters { get { return 2; } }

        public override string Symbol { get { return "compose"; } }

        public override IMathObject Perform(IMathObject[] objs)
        {
            IntegerMatrix leftValue = null;
            IntegerMatrix rightValue = null;

            if (objs[0] is IHasMatrix)
            {
                leftValue = (objs[0] as IHasMatrix).Matrix;
            }
            else if (objs[0] is IHasOutput)
            {
                var temp = (objs[0] as IHasOutput).Output;
                leftValue = (temp as IHasMatrix).Matrix;
            }

            if (objs[1] is IHasMatrix)
            {
                rightValue = (objs[1] as IHasMatrix).Matrix;
            }
            else if (objs[1] is IHasOutput)
            {
                var temp = (objs[1] as IHasOutput).Output;
                rightValue = (temp as IHasMatrix).Matrix;
            }

            if (leftValue.Height > rightValue.Height)
            {
                uint v = (uint)(leftValue.Height - rightValue.Height);
                rightValue = rightValue.Expand(v);
            }

            if (rightValue.Height > leftValue.Height)
            {
                uint v = (uint)(rightValue.Height - leftValue.Height);
                leftValue = leftValue.Expand(v);
            }

            var result = leftValue.MultiplyBy(rightValue);

            var returnObj = new MathObject(new PermutationMatix(result));

            DecorationManager.SetObjectDecoration(
                returnObj, "name", "+");

            return returnObj;
        }

        public class Factory : IMathOperationFactory, IHasName
        {
            public string Name
            {
                get { return "Compose"; }
            }

            public IMathOperation Create(object parm)
            {
                return new Compose();
            }
        }
    }
}

