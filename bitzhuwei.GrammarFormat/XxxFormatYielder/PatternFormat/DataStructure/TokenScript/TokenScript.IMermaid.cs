//using bitzhuwei.GrammarFormat;
//using System;
//using System.IO;

//namespace bitzhuwei.PatternFormat {
//    public partial class TokenScript /*: IMermaid*/ {

//        public void ToMermaid(TextWriter w/*, object context*/) {
//            switch (this.type) {
//            case ETokenScriptType.AcceptPrevious:
//            w.Write($"Previous {this.Vt}");
//            break;
//            case ETokenScriptType.CheckToken:
//            w.Write($"Check {this.Vt}");
//            break;
//            case ETokenScriptType.BeginToken:
//            w.Write($"Begin {this.Vt}");
//            break;
//            case ETokenScriptType.ExtendToken:
//            w.Write($"End {this.Vt}");
//            break;
//            case ETokenScriptType.AcceptToken:
//            w.Write($"Accept {this.Vt}");
//            break;
//            default:
//            throw new NotImplementedException();
//            //break;
//            }
//        }
//    }
//}