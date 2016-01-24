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
[System.CLSCompliant(false)]
public partial class FloatingPointParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, INT=5, FLOAT=6, DIGIT=7, LETTER=8, ID=9, 
		PI=10, TOP=11, MUL=12, DIV=13, ADD=14, SUB=15, WS=16;
	public const int
		RULE_stat = 0, RULE_expr = 1, RULE_exprList = 2, RULE_value = 3;
	public static readonly string[] ruleNames = {
		"stat", "expr", "exprList", "value"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'^'", "','", null, null, null, null, null, "'pi'", 
		"'top'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "INT", "FLOAT", "DIGIT", "LETTER", "ID", 
		"PI", "TOP", "MUL", "DIV", "ADD", "SUB", "WS"
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
			State = 8; expr(0);
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
	public partial class FuncCallContext : ExprContext {
		public ITerminalNode ID() { return GetToken(FloatingPointParser.ID, 0); }
		public ExprListContext exprList() {
			return GetRuleContext<ExprListContext>(0);
		}
		public FuncCallContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFuncCall(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FloatContext : ExprContext {
		public ITerminalNode FLOAT() { return GetToken(FloatingPointParser.FLOAT, 0); }
		public FloatContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFloat(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NegativeContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public NegativeContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNegative(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TOPContext : ExprContext {
		public ITerminalNode TOP() { return GetToken(FloatingPointParser.TOP, 0); }
		public TOPContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTOP(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExponentContext : ExprContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExponentContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExponent(this);
			else return visitor.VisitChildren(this);
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
	public partial class PIContext : ExprContext {
		public ITerminalNode PI() { return GetToken(FloatingPointParser.PI, 0); }
		public PIContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPI(this);
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
			State = 27;
			switch (TokenStream.La(1)) {
			case SUB:
				{
				_localctx = new NegativeContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 11; Match(SUB);
				State = 12; expr(8);
				}
				break;
			case ID:
				{
				_localctx = new FuncCallContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 13; Match(ID);
				State = 14; Match(T__0);
				State = 16;
				_la = TokenStream.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << INT) | (1L << FLOAT) | (1L << ID) | (1L << PI) | (1L << TOP) | (1L << SUB))) != 0)) {
					{
					State = 15; exprList();
					}
				}

				State = 18; Match(T__1);
				}
				break;
			case INT:
				{
				_localctx = new IntContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 19; Match(INT);
				}
				break;
			case FLOAT:
				{
				_localctx = new FloatContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 20; Match(FLOAT);
				}
				break;
			case PI:
				{
				_localctx = new PIContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 21; Match(PI);
				}
				break;
			case TOP:
				{
				_localctx = new TOPContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 22; Match(TOP);
				}
				break;
			case T__0:
				{
				_localctx = new ParensContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 23; Match(T__0);
				State = 24; expr(0);
				State = 25; Match(T__1);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 40;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 38;
					switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
					case 1:
						{
						_localctx = new ExponentContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 29;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 30; Match(T__2);
						State = 31; expr(9);
						}
						break;
					case 2:
						{
						_localctx = new MulDivContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 32;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 33;
						((MulDivContext)_localctx).op = TokenStream.Lt(1);
						_la = TokenStream.La(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((MulDivContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 34; expr(8);
						}
						break;
					case 3:
						{
						_localctx = new AddSubContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 35;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 36;
						((AddSubContext)_localctx).op = TokenStream.Lt(1);
						_la = TokenStream.La(1);
						if ( !(_la==ADD || _la==SUB) ) {
							((AddSubContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 37; expr(7);
						}
						break;
					}
					} 
				}
				State = 42;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
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

	public partial class ExprListContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprList; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFloatingPointVisitor<TResult> typedVisitor = visitor as IFloatingPointVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprListContext exprList() {
		ExprListContext _localctx = new ExprListContext(Context, State);
		EnterRule(_localctx, 4, RULE_exprList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; expr(0);
			State = 48;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==T__3) {
				{
				{
				State = 44; Match(T__3);
				State = 45; expr(0);
				}
				}
				State = 50;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
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
		EnterRule(_localctx, 6, RULE_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51; Match(INT);
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
		case 0: return Precpred(Context, 9);
		case 1: return Precpred(Context, 7);
		case 2: return Precpred(Context, 6);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x12\x38\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x5\x3\x13\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x5\x3\x1E\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\a\x3)\n\x3\f\x3\xE\x3,\v\x3\x3\x4\x3\x4\x3\x4\a\x4\x31"+
		"\n\x4\f\x4\xE\x4\x34\v\x4\x3\x5\x3\x5\x3\x5\x2\x3\x4\x6\x2\x4\x6\b\x2"+
		"\x4\x3\x2\xE\xF\x3\x2\x10\x11>\x2\n\x3\x2\x2\x2\x4\x1D\x3\x2\x2\x2\x6"+
		"-\x3\x2\x2\x2\b\x35\x3\x2\x2\x2\n\v\x5\x4\x3\x2\v\x3\x3\x2\x2\x2\f\r\b"+
		"\x3\x1\x2\r\xE\a\x11\x2\x2\xE\x1E\x5\x4\x3\n\xF\x10\a\v\x2\x2\x10\x12"+
		"\a\x3\x2\x2\x11\x13\x5\x6\x4\x2\x12\x11\x3\x2\x2\x2\x12\x13\x3\x2\x2\x2"+
		"\x13\x14\x3\x2\x2\x2\x14\x1E\a\x4\x2\x2\x15\x1E\a\a\x2\x2\x16\x1E\a\b"+
		"\x2\x2\x17\x1E\a\f\x2\x2\x18\x1E\a\r\x2\x2\x19\x1A\a\x3\x2\x2\x1A\x1B"+
		"\x5\x4\x3\x2\x1B\x1C\a\x4\x2\x2\x1C\x1E\x3\x2\x2\x2\x1D\f\x3\x2\x2\x2"+
		"\x1D\xF\x3\x2\x2\x2\x1D\x15\x3\x2\x2\x2\x1D\x16\x3\x2\x2\x2\x1D\x17\x3"+
		"\x2\x2\x2\x1D\x18\x3\x2\x2\x2\x1D\x19\x3\x2\x2\x2\x1E*\x3\x2\x2\x2\x1F"+
		" \f\v\x2\x2 !\a\x5\x2\x2!)\x5\x4\x3\v\"#\f\t\x2\x2#$\t\x2\x2\x2$)\x5\x4"+
		"\x3\n%&\f\b\x2\x2&\'\t\x3\x2\x2\')\x5\x4\x3\t(\x1F\x3\x2\x2\x2(\"\x3\x2"+
		"\x2\x2(%\x3\x2\x2\x2),\x3\x2\x2\x2*(\x3\x2\x2\x2*+\x3\x2\x2\x2+\x5\x3"+
		"\x2\x2\x2,*\x3\x2\x2\x2-\x32\x5\x4\x3\x2./\a\x6\x2\x2/\x31\x5\x4\x3\x2"+
		"\x30.\x3\x2\x2\x2\x31\x34\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2\x32\x33\x3\x2"+
		"\x2\x2\x33\a\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x35\x36\a\a\x2\x2\x36\t\x3"+
		"\x2\x2\x2\a\x12\x1D(*\x32";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
