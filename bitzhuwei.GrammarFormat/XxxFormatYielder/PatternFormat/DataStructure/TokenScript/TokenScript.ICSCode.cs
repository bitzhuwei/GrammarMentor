//using bitzhuwei.GrammarFormat;
//using System;
//using System.IO;

//namespace bitzhuwei.PatternFormat {
//    public partial class TokenScript /* ToCSCode(TextWriter w, CSCodeContext context) */{
//        public void ToCSCode(TextWriter w, CSCodeContext c) {
//            if (c == null) { throw new ArgumentNullException($"{nameof(c)}"); }
//            switch (this.type) {
//            case ETokenScriptType.beginToken:
//            w.WriteLine($"// {this.Vt}: {this.type}");
//            w.PrintLine(c.Tab, "if (context.analyzingToken == null || context.analyzingToken.type != Token.NotYet) {");
//            c.IncreaseTab();
//            w.PrintLine(c.Tab, "context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);");
//            w.PrintLine(c.Tab, "context.result.Add(context.analyzingToken);");
//            c.DecreaseTab();
//            w.PrintLine(c.Tab, "}");
//            break;
//            case ETokenScriptType.extendToken:
//            w.WriteLine($"// {this.Vt}: {this.type}");
//            w.PrintLine(c.Tab, $"context.checkpoint = context.Cursor + 1;");
//            break;
//            case ETokenScriptType.checkToken:
//            w.WriteLine($"// {this.Vt}: {this.type}");
//            //w.PrintLine(c.Tab, $"context.checkpoint = context.Cursor{(attached2Edge ? add1 : string.Empty)};");
//            w.PrintLine(c.Tab, $"context.postRegex = true;");
//            break;
//            case ETokenScriptType.acceptToken:
//            w.WriteLine($"// {this.Vt}: {this.type}");
//            w.PrintLine(c.Tab, $"context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index);");
//            w.PrintLine(c.Tab, $"if (!CheckKeyword(context.analyzingToken)) {{ context.analyzingToken.type = EType.{Vt.Vt2Name()}; }}");
//            w.PrintLine(c.Tab, $"var backStep = context.Cursor - context.checkpoint + 1;");
//            w.PrintLine(c.Tab, "if (backStep > 0) { context.MoveBack(backStep); }");
//            w.PrintLine(c.Tab, $"context.postRegex = false;");
//            break;
//            default:
//            throw new NotImplementedException();
//            //break;
//            }
//        }
//    }
//}