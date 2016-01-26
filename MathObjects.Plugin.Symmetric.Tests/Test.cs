﻿using NUnit.Framework;
using System;
using MathObjects.Framework.Registry;
using MathObjects.Framework;
using MathObjects.Framework.Parser;
using MathObjects.Core.Matrix.Permutation;

namespace MathObjects.Plugin.Symmetric.Tests
{
    [TestFixture]
    public class Test
    {
        FactoryRegistry reg = new FactoryRegistry();

        Plugin plugin = new Plugin();

        IParser parser;

        [SetUp]
        public void Setup()
        {
            plugin.Init(reg);

            parser = (plugin as IHasParser).Parser;
        }

        [Test]
        public void TestCase()
        {
            var stack = new MathObjectStack();

            parser.Parse("(1,2,3,4)", stack);

            var cycle = CycleList.Create(new int[] {1,2,3,4});
            Assert.AreEqual(cycle, stack.Top.GetCycleList());
        }

        [Test]
        public void TestCase2()
        {
            var stack = new MathObjectStack();

            parser.Parse("(1,2,3)(1,2,3)(1,2,3)", stack);

            var cycle = CycleList.Create(new int[] {});
            Assert.AreEqual(cycle, stack.Top.GetCycleList());
        }

        [Test]
        public void TestCase3()
        {
            var stack = new MathObjectStack();

            parser.Parse("(1,2)(1,2)", stack);

            var cycle = CycleList.Create(new int[] {});
            Assert.AreEqual(cycle, stack.Top.GetCycleList());
        }
    }
}

