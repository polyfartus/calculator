﻿using System;
using MathObjects.Core.Plugin;
using MathObjects.Framework;
using MathObjects.Framework.Registry;
using MathObjects.Framework.Parser;

namespace MathObjects.Plugin.FloatingPoint
{
    [Plugin]
    public class Plugin : IPlugin, IHasInit, IHasName, IHasParser
    {
        IParser parser;

        public string Name
        {
            get { return "FloatingPoint"; }
        }

        public IParser Parser
        {
            get { return parser; }
        }
            
        public void Startup(IPluginLoader loader)
        {
        }

        public void Init(FactoryRegistry registry)
        {
            this.parser = new Parser(registry);

            registry.RegisterObjectFactory(
                FactoryRegistry.OBJECT, 
                new MathObject.Factory());
            
            registry.RegisterBinaryOperationFactory(
                FactoryRegistry.ADD, 
                new Add.Factory());
            
            registry.RegisterBinaryOperationFactory(
                FactoryRegistry.SUBTRACT, 
                new Subtract.Factory());

            registry.RegisterBinaryOperationFactory(
                FactoryRegistry.MULTIPLY, 
                new Multiply.Factory());
            
            registry.RegisterBinaryOperationFactory(
                FactoryRegistry.DIVIDE, 
                new Divide.Factory());

            registry.RegisterFunctionFactory(
                "pi", new ConstantObjectFactory(Math.PI));
            
            registry.RegisterFunctionFactory(
                "top", new FunctionFactory(typeof(TopFunction)));
            
            registry.RegisterFunctionFactory(
                "cos", new FunctionFactory(typeof(CosineFunction)));
        }
    }
}

