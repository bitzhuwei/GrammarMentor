using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        /// <summary>
        /// all kinds of token scripts show their talents.
        /// </summary>
        /// <param name="tokenScripts"></param>
        /// <param name="w"></param>
        /// <param name="c"></param>
        private static void WriteMiniDFATokenScripts(CoupleList<TokenScript> tokenScripts, TextWriter w, CSCodeContext c) {
            var query = from tokenScript in tokenScripts
                        group tokenScript by tokenScript.type into g
                        /* The order of items is important! Don't change it! */
                        orderby g.Key ascending
                        select g;
            foreach (var g in query) {
                var statement = g.Key;
                //w.Print(c.Tab, $"// {statement}: "); foreach (var item in g) { w.Write(item.Vt); w.Write(' '); }
                //w.WriteLine();
                switch (statement) {
                case ETokenScriptType.AcceptPrevious:
                w.Print(c.Tab, "AcceptPrevious(context");
                foreach (var tokenScript in g) {
                    var Vt = tokenScript.Vt; var name = Vt.Vt2Name();
                    w.Write($", EType.{name}");
                }
                w.WriteLine(");");
                break;
                case ETokenScriptType.CheckToken:
                w.Print(c.Tab, "CheckToken(context");
                foreach (var tokenScript in g) {
                    var Vt = tokenScript.Vt; var name = Vt.Vt2Name();
                    w.Write($", EType.{name}");
                }
                w.WriteLine(");");
                break;
                case ETokenScriptType.BeginToken:
                w.Print(c.Tab, "BeginToken(context");
                foreach (var tokenScript in g) {
                    var Vt = tokenScript.Vt; var name = Vt.Vt2Name();
                    w.Write($", EType.{name}");
                }
                w.WriteLine(");");
                break;
                case ETokenScriptType.ExtendToken:
                w.Print(c.Tab, "ExtendToken(context");
                w.WriteLine(");");
                break;
                case ETokenScriptType.AcceptToken:
                w.Print(c.Tab, "AcceptToken(context");
                foreach (var tokenScript in g) {
                    var Vt = tokenScript.Vt; var name = Vt.Vt2Name();
                    w.Write($", EType.{name}");
                }
                w.WriteLine(");");
                break;
                default:
                throw new NotImplementedException();
                }
            }
        }
    }
}