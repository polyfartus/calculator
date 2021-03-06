﻿using System;
using MathObjects.Framework.Registry;
using MathObjects.Core.Plugin;
using MathObjects.Framework.Parser;

namespace MathObjects.UI
{
    static public class PluginEx
    {
        public static IParser GetParser(this IPlugin plugin)
        {
            var hasParser = plugin as IHasParser;

            if (hasParser == null)
            {
                return null;
            }

            return hasParser.Parser;
        }
    }
}

