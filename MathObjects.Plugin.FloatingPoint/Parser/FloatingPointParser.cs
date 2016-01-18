//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FloatingPoint.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
public partial class FloatingPointParser : Parser {
	public const int
		T__0=1, T__1=2, INT=3, MUL=4, DIV=5, ADD=6, SUB=7, WS=8;
	public const int
		RULE_stat = 0, RULE_expr = 1, RULE_value = 2;
	public static readonly string[] ruleNames = {
		"stat", "expr", "value"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", null, "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "INT", "MUL", "DIV", "ADD", "SUB", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "FloatingPoint.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public FloatingPointParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class StatContext : ParserRuleContext {
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat; } }
	 
		public StatContext() { }
		public virtual void CopyFrom(StatContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class PrintExprContext : StatContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public PrintExprContext(StatContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrintExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(Context, State);
		EnterRule(_localctx, 0, RULE_stat);
		try {
			_localctx = new PrintExprContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MulDivContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public MulDivContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMulDiv(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddSubContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public AddSubContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddSub(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParensContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ParensContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParens(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntContext : ExprContext {
		public ITerminalNode INT() { return GetToken(FloatingPointParser.INT, 0); }
		public IntContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			switch (TokenStream.La(1)) {
			case INT:
				{
				_localctx = new IntContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 9; Match(INT);
				}
				break;
			case T__0:
				{
				_localctx = new ParensContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 10; Match(T__0);
				State = 11; expr(0);
				State = 12; Match(T__1);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 24;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 22;
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new MulDivContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 16;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 17;
						((MulDivContext)_localctx).op = TokenStream.Lt(1);
						_la = TokenStream.La(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((MulDivContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 18; expr(5);
						}
						break;
					case 2:
						{
						_localctx = new AddSubContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 19;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 20;
						((AddSubContext)_localctx).op = TokenStream.Lt(1);
						_la = TokenStream.La(1);
						if ( !(_la==ADD || _la==SUB) ) {
							((AddSubContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 21; expr(4);
						}
						break;
					}
					} 
				}
				State = 26;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(FloatingPointParser.INT, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 4, RULE_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; Match(INT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\n \x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5"+
		"\x3\x11\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x19\n\x3\f\x3\xE"+
		"\x3\x1C\v\x3\x3\x4\x3\x4\x3\x4\x2\x3\x4\x5\x2\x4\x6\x2\x4\x3\x2\x6\a\x3"+
		"\x2\b\t\x1F\x2\b\x3\x2\x2\x2\x4\x10\x3\x2\x2\x2\x6\x1D\x3\x2\x2\x2\b\t"+
		"\x5\x4\x3\x2\t\x3\x3\x2\x2\x2\n\v\b\x3\x1\x2\v\x11\a\x5\x2\x2\f\r\a\x3"+
		"\x2\x2\r\xE\x5\x4\x3\x2\xE\xF\a\x4\x2\x2\xF\x11\x3\x2\x2\x2\x10\n\x3\x2"+
		"\x2\x2\x10\f\x3\x2\x2\x2\x11\x1A\x3\x2\x2\x2\x12\x13\f\x6\x2\x2\x13\x14"+
		"\t\x2\x2\x2\x14\x19\x5\x4\x3\a\x15\x16\f\x5\x2\x2\x16\x17\t\x3\x2\x2\x17"+
		"\x19\x5\x4\x3\x6\x18\x12\x3\x2\x2\x2\x18\x15\x3\x2\x2\x2\x19\x1C\x3\x2"+
		"\x2\x2\x1A\x18\x3\x2\x2\x2\x1A\x1B\x3\x2\x2\x2\x1B\x5\x3\x2\x2\x2\x1C"+
		"\x1A\x3\x2\x2\x2\x1D\x1E\a\x5\x2\x2\x1E\a\x3\x2\x2\x2\x5\x10\x18\x1A";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}