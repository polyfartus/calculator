﻿using System;
using System.Collections.Generic;
using MathObjects.Framework;
using MathObjects.Framework.Registry;

namespace MathObjects.UI.Mediator
{
    class CalcMediator : IMediator
    {
        public event EventHandler<MediatorArgs> CurrentNumberChaned;

        public event EventHandler<MediatorArgs> NumberStackChaned;

        readonly FactoryRegistry registry;

        readonly Stack<IMathObject> numbers = new Stack<IMathObject>();

        readonly IMathObjectFactory objectFactory;

        readonly IMathOperationFactory multiplyFactory;

        readonly IMathOperationFactory2 inverseFactory2;

        string currentNumber;

        public CalcMediator(FactoryRegistry registry)
        {
            this.registry = registry;

            objectFactory = registry.GetObjectFactory(FactoryRegistry.OBJECT);

            if (registry.OperationDictionary.ContainsKey(FactoryRegistry.MULTIPLY))
            {
                multiplyFactory = registry.GetOperationFactory(FactoryRegistry.MULTIPLY);
            }

            if (registry.OperationDictionary.ContainsKey(FactoryRegistry.INVERSE))
            {
                inverseFactory2 = registry.GetOperationFactory2(FactoryRegistry.INVERSE);
            }
        }

        public FactoryRegistry Registry
        {
            get { return this.registry; }
        }

        public string CurrentNumber
        {
            get { return currentNumber; }
            set { currentNumber = value; }
        }

        public Stack<IMathObject> Numbers
        {
            get { return numbers; }
        }

        public void InsertNumber(object digit)
        {
            var value = digit as IHasValue;
            if (value != null)
            {
                currentNumber += "" + value.Value;
            }

            var output = digit as IHasOutput;
            if (output != null)
            {
                currentNumber += "" + output;
            }

            var tuple = digit as IHasTuple;
            if (tuple != null)
            {
                currentNumber += "" + tuple.Tuple.Item1;
            }

            var hasParse = digit as IHasParseValue;
            if (hasParse != null)
            {
                currentNumber += hasParse.ParseValue;
            }

            FireCurrentNumberChanged();
        }

        public void Enter()
        {
            var obj = this.objectFactory.Create(this.currentNumber);
            if (obj != null)
            {
                numbers.Push(obj);

                this.currentNumber = "";

                FireCurrentNumberChanged();
                FireNumberStackChaned();
                ErrorHandler.ResetError(this);
            }
        }

        public void Clear()
        {
            this.currentNumber = "";

            this.numbers.Clear();

            FireCurrentNumberChanged();
            FireNumberStackChaned();
        }

        public void Pop()
        {
            if (this.numbers.Count > 0)
            {
                this.numbers.Pop();

                FireNumberStackChaned();
            }
        }

        public void Perform(IBinaryOperation op)
        {
            if (this.numbers.Count < 2)
            {
                return;
            }

            var wrapper = new OperationWrapper(
                this.numbers.Pop(), 
                this.numbers.Pop(), op);

            numbers.Push(wrapper);

            this.currentNumber = "";

            FireCurrentNumberChanged();
            FireNumberStackChaned();
        }

        public void Perform(IMathOperation op)
        {
            if (this.numbers.Count < 1)
            {
                return;
            }

            var wrapper = new OperationWrapper2(
                this.numbers.Pop(), op);

            numbers.Push(wrapper);

            this.currentNumber = "";

            FireCurrentNumberChanged();
            FireNumberStackChaned();
        }

        public void Multiply()
        {
            if (this.numbers.Count < 2)
            {
                return;
            }

            var obj = this.multiplyFactory.Create(null);

            var wrapper = new OperationWrapper(
                this.numbers.Pop(), 
                this.numbers.Pop(),
                obj);

            numbers.Push(wrapper);

            this.currentNumber = "";

            FireCurrentNumberChanged();
            FireNumberStackChaned();
        }

        public void Inverse()
        {
            if (this.numbers.Count < 1)
            {
                return;
            }

            var obj = this.inverseFactory2.Create(null);

            var wrapper = new OperationWrapper2(
                this.numbers.Pop(), 
                obj);

            numbers.Push(wrapper);

            FireNumberStackChaned();
        }

        public string Calc()
        {
            string result = "";

            foreach (var i in numbers)
            {
                if (result.Length > 0)
                {
                    result += ", ";
                }

                var v = (i as IHasValue).Value;
                result += "" + v;
            }

            return result;
        }

        void FireCurrentNumberChanged()
        {
            if (CurrentNumberChaned != null)
            {
                var args = new MediatorArgs();
                args.Mediator = this;
                CurrentNumberChaned(this, args);
            }
        }

        void FireNumberStackChaned()
        {
            if (NumberStackChaned != null)
            {
                var args = new MediatorArgs();
                args.Mediator = this;
                NumberStackChaned(this, args);
            }
        }
    }
}

