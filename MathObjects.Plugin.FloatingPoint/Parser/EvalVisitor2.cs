﻿using System;
using System.Linq;
using System.Collections.Generic;
using MathObjects.Framework;
using MathObjects.Framework.Registry;
using MathObjects.Framework.Parser;
using MathObjects.Core.DecoratableObject;
using System.Diagnostics;

namespace MathObjects.Plugin.FloatingPoint
{
    public class EvalVisitor2 : FloatingPointBaseVisitor<IMathObject>
    {
        readonly IMathObjectStack stack;

        readonly IMathScope scope;

        readonly InitVisitor init;

        public EvalVisitor2(
            IMathObjectStack stack,
            IMathScope scope,
            InitVisitor init)
        {
            this.stack = stack;
            this.scope = scope;
            this.init = init;

            Debug.WriteLine("");
        }

        public override IMathObject VisitPrintExpr(
            FloatingPointParser.PrintExprContext context)
        {
            Debug.WriteLine("Start VisitPrintExpr []");

            var result = Visit(context.expr());

            result = result.CopyByValue();

            this.stack.Pop();
            this.stack.Push(result);

            Debug.WriteLine("End VisitPrintExpr []");

            return result;
        }

        public override IMathObject VisitVariable(
            FloatingPointParser.VariableContext context)
        {
            var name = context.ID().GetText();

            Debug.WriteLine("Start VisitVariable [" + name + "]");

            IMathObject value = new Ref(this.scope, name);

            stack.Push(value);

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("End VisitVariable [" + 
                name + "=" + value.GetDouble() + "]");

            return result;
        }

        public override IMathObject VisitAssignment(
            FloatingPointParser.AssignmentContext context)
        {
            var left = context.ID().GetText();

            Debug.WriteLine("Start VisitAssignment [" + left + "]");

            Visit(context.expr());

            var value = this.stack.Pop();

            this.scope.Put(left, value);

            Debug.WriteLine("End VisitAssignment [" + 
                left + "=" + value + "] ["+ left + "=" + value.GetDouble() + "]");

            return value;
        }

        public override IMathObject VisitNegative(
            FloatingPointParser.NegativeContext context)
        {
            Visit(context.expr());

            stack.Push(new Negative());

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("VisitNegative");

            return result;
        }

        public override IMathObject VisitExponent(
            FloatingPointParser.ExponentContext context)
        {
            var left = Visit(context.GetChild(2));
            var right = Visit(context.GetChild(0));

            stack.Push(new ExponentOperation());

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("VisitExponent []");

            return result;
        }

        public override IMathObject VisitExprList(
            FloatingPointParser.ExprListContext context)
        {
            var list = new List<IMathObject>();

            foreach (var e in context.expr())
            {
                var obj = Visit(e);
                list.Add(obj);
            }

            Debug.WriteLine("VisitExprList []");

            return new ArrayObject(list.ToArray());
        }

        public override IMathObject VisitFuncCall(
            FloatingPointParser.FuncCallContext context)
        {
            Debug.WriteLine("Start VisitFuncCall []");

            if (!this.init.Map.ContainsKey(context))
            {
                var error = new ErrorObject(
                    "function not found: " + 
                    context.ID().GetText());
                
                stack.Push(error);

                Debug.WriteLine("End VisitFuncCall [" + 
                    context.ID().GetText() + "]");

                return error;
            }
            
            var f = this.init.Map[context];

            var functionContext = new FunctionContext(this.stack);

            if (context.exprList() != null)
            {
                VisitExprList(context.exprList());
            }

            var operation = f.Perform(functionContext);

            operation.SetObjectDecoration("name", context.ID().GetText());

            if (stack.Size < operation.NumberOfParameters)
            {
                var error = new ErrorObject("not enough parameters");
                stack.Push(error);
                return error;
            }

            var paramList = stack.Peek(operation.NumberOfParameters);

            stack.Push(operation);

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("End VisitFuncCall [" + operation + "]");
            
            return result;
        }

        public override IMathObject VisitFloat(
            FloatingPointParser.FloatContext context)
        {
            double temp;
            double.TryParse(context.FLOAT().GetText(), out temp);
            var result = new MathObject(temp);
            stack.Push(result);

            Debug.WriteLine("VisitFloat [" + result + "]");

            return result;
        }

        public override IMathObject VisitInt(
            FloatingPointParser.IntContext context)
        {
            double temp;
            double.TryParse(context.INT().GetText(), out temp);
            var result = new MathObject(temp);
            stack.Push(result);

            Debug.WriteLine("VisitInt [" + result + "]");

            return result;
        }

        public override IMathObject VisitValue(
            FloatingPointParser.ValueContext context)
        {
            double temp;
            double.TryParse(context.INT().GetText(), out temp);
            var result = new MathObject(temp);
            stack.Push(result);

            Debug.WriteLine("VisitValue [" + result + "]");

            return result;
        }

        public override IMathObject VisitParens(
            FloatingPointParser.ParensContext context)
        {
            Debug.WriteLine("Start VisitParens");

            var result = Visit(context.expr());
            
            Debug.WriteLine("End VisitParens");

            return result; 
        }

        public override IMathObject VisitAddSub(
            FloatingPointParser.AddSubContext context)
        {
            Debug.WriteLine("Start VisitAddSub []");

            var left = Visit(context.GetChild(2));
            var right = Visit(context.GetChild(0));

            IMathOperation op = null;

            if (context.op.Type == FloatingPointParser.ADD)
            {
                op = new Add();
            }
            else
            {
                op = new Subtract();
            }

            stack.Push(op);

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("End VisitAddSub [" + 
                left + "+" + right + "] [" + result.GetDouble() + "]");

            return result;
        }

        public override IMathObject VisitMulDiv(
            FloatingPointParser.MulDivContext context)
        {
            Debug.WriteLine("Start VisitMulDiv []");

            var left = Visit(context.GetChild(2));
            var right = Visit(context.GetChild(0));

            IMathOperation op = null;

            if (context.op.Type == FloatingPointParser.MUL)
            {
                op = new Multiply();
            }
            else
            {
                op = new Divide();
            }

            stack.Push(op);

            IMathObject result = stack.Peek(1)[0];

            Debug.WriteLine("End VisitMulDiv [" + 
                left + "+" + right + "] [" + result.GetDouble() + "]");

            return result;
        }
    }
}

