﻿using System;
using MathObjects.Core.Plugin;
using MathObjects.Framework;
using MathObjects.Framework.Registry;

namespace MathObjects.Plugin.Integers
{
    [Plugin]
    public class Plugin : IPlugin, IHasInit, IHasName
    {
        public string Name
        {
            get { return "Integers"; }
        }

        public void Startup(IPluginLoader loader)
        {
        }

        public void Init(FactoryRegistry registry)
        {
            registry.RegisterObjectFactory(
                FactoryRegistry.OBJECT, 
                new MathObject.Factory());

            registry.RegisterOperationFactory(
                FactoryRegistry.ADD, 
                new Add.Factory());

            registry.RegisterOperationFactory(
                FactoryRegistry.MULTIPLY, 
                new Multiplication.Factory());
        }
    }
}
