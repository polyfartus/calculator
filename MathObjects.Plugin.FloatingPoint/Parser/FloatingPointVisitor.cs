//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FloatingPoint.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="FloatingPointParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IFloatingPointVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="FloatingPointParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFile([NotNull] FloatingPointParser.FileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="FloatingPointParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintExpr([NotNull] FloatingPointParser.PrintExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="FloatingPointParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] FloatingPointParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>empty</c>
	/// labeled alternative in <see cref="FloatingPointParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmpty([NotNull] FloatingPointParser.EmptyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloat([NotNull] FloatingPointParser.FloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExponent([NotNull] FloatingPointParser.ExponentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParens([NotNull] FloatingPointParser.ParensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] FloatingPointParser.VariableContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StackParam</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStackParam([NotNull] FloatingPointParser.StackParamContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSub([NotNull] FloatingPointParser.AddSubContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncCall</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncCall([NotNull] FloatingPointParser.FuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] FloatingPointParser.IntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulDiv([NotNull] FloatingPointParser.MulDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Negative</c>
	/// labeled alternative in <see cref="FloatingPointParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegative([NotNull] FloatingPointParser.NegativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FloatingPointParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprList([NotNull] FloatingPointParser.ExprListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FloatingPointParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] FloatingPointParser.ValueContext context);
}
