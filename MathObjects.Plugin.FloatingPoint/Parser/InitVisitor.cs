﻿using System;
using MathObjects.Framework;
using MathObjects.Framework.Registry;
using MathObjects.Framework.Parser;
using System.Collections.Generic;

namespace MathObjects.Plugin.FloatingPoint
{
    public class InitVisitor : FloatingPointBaseVisitor<bool>
    {
        readonly IMathObjectStack stack;

        readonly FactoryRegistry registry;

        readonly IDictionary<FloatingPointParser.FuncCallContext, IMathFunction> map =
            new Dictionary<FloatingPointParser.FuncCallContext, IMathFunction>();

        public InitVisitor(
            FactoryRegistry registry, 
            IMathObjectStack stack)
        {
            this.registry = registry;
            this.stack = stack;
        }

        public IDictionary<FloatingPointParser.FuncCallContext, IMathFunction> Map 
        {
            get { return this.map; }
        }

        public override bool VisitFuncCall(
            FloatingPointParser.FuncCallContext context)
        {
            var factoryContext = new FactoryContext();
             
            string name = context.ID().GetText();

            var factory = this.registry.GetFunctionFactory(name);

            var f = factory.Create(factoryContext) as IMathFunction;

            f.Init(new FunctionContext(this.stack));

            map[context] = f;

            return true;
        }
    }
}

