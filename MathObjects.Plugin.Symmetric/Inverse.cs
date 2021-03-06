﻿using System;
using MathObjects.Framework;
using MathObjects.Framework.Registry;

namespace MathObjects.Plugin.Symmetric
{
    class Inverse : AbstractMathOperation
    {
        public override int NumberOfParameters { get { return 1; } }

        public override string Symbol { get { return "inverse"; } }

        public override IMathObject Perform(IMathObject[] target)
        {
            var hasMatrix = target[0] as IHasMatrix;
            if (hasMatrix != null)
            {
                return new InverseObject(hasMatrix);
            }

            var hasOutput = target[0] as IHasOutput;
            if (hasOutput != null)
            {
                return new InverseObject(hasOutput.Output as IHasMatrix);
            }

            throw new Exception();
        }

        public class Factory : IMathOperationFactory, IHasName
        {
            public string Name
            {
                get { return "Inverse"; }
            }

            public IMathOperation Create(object param)
            {
                return new Inverse();
            }
        }
    }
}

