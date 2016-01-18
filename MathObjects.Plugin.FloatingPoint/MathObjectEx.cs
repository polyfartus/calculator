﻿using System;
using MathObjects.Framework;

namespace MathObjects.Plugin.FloatingPoint
{
    public static class MathObjectEx
    {
        public static double GetDouble(this IMathObject obj)
        {
            var hasOutput = obj as IHasOutput;
            if (hasOutput != null)
            {
                var output = hasOutput.Output;
                if (output is double)
                {
                    return (double)output;
                }

                var has2 = hasOutput.Output as IHasOutput;
                return (double)has2.Output;
            }

            throw new Exception();
        }
    }
}
