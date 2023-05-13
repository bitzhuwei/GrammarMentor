using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        /// <summary>
        /// currentChar => true
        /// </summary>
        private static readonly Func<char, bool> acceptAll = currentChar => true;

        /// <summary>
        /// accept previous <see cref="Token"/>
        /// <para>set <see cref="Token.type"/> and neutralize the last LexicalContext.MoveForward()</para>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vt"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void AcceptPrevious(LexicalContext context, string Vt) {
            context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index + 1);
            var typeSet = CheckKeyword(context.analyzingToken);
            if (!typeSet) {
                if (context.typeCandidates.Contains(Vt)) {
                    context.analyzingToken.type = Vt;
                    typeSet = true;
                }
            }
            if (!typeSet) { throw new NotImplementedException(); }

            context.checkerDict.TryUncheck(Vt);

            var backStep = context.Cursor - context.checkpoint - 1;
            if (backStep > 0) { context.MoveBack(backStep); }
        }

        /// <summary>
        /// accept previous <see cref="Token"/>
        /// <para>set <see cref="Token.type"/> and neutralize the last LexicalContext.MoveForward()</para>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vts"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void AcceptPrevious(LexicalContext context, params string[] Vts) {
            context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index + 1);
            var typeSet = CheckKeyword(context.analyzingToken);
            if (!typeSet) {
                foreach (var Vt in Vts) {
                    if (context.typeCandidates.Contains(Vt)) {
                        context.analyzingToken.type = Vt;
                        typeSet = true;
                        break;
                    }
                }
            }
            if (!typeSet) { throw new NotImplementedException(); }

            foreach (var Vt in Vts) {
                context.checkerDict.TryUncheck(Vt);
            }

            var backStep = context.Cursor - context.checkpoint - 1;
            if (backStep > 0) { context.MoveBack(backStep); }
        }

        /// <summary>
        /// this is where post-regex starts.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vt"></param>
        private static void CheckToken(LexicalContext context, string Vt) {
            if (context.analyzingToken != null && context.analyzingToken.type == Token.NotYet) {
                context.checkerDict.Check(Vt);
            }
        }

        /// <summary>
        /// this is where post-regex starts.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vts"></param>
        private static void CheckToken(LexicalContext context, params string[] Vts) {
            if (context.analyzingToken != null && context.analyzingToken.type == Token.NotYet) {
                foreach (var Vt in Vts) {
                    context.checkerDict.Check(Vt);
                }
            }
        }

        /// <summary>
        /// this is where new <see cref="Token"/> starts.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vt"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private static void BeginToken(LexicalContext context, string Vt) {
            if (context.checkerDict.IsEmpty) {
                if (context.analyzingToken == null || context.analyzingToken.type != Token.NotYet) {
                    context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                    context.result.Add(context.analyzingToken);
                    context.typeCandidates.Clear();
                    context.typeCandidates.Add(Vt);
                }
            }
        }

        /// <summary>
        /// this is where new <see cref="Token"/> starts.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vts"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private static void BeginToken(LexicalContext context, params string[] Vts) {
            if (context.checkerDict.IsEmpty) {
                if (context.analyzingToken == null || context.analyzingToken.type != Token.NotYet) {
                    context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                    context.result.Add(context.analyzingToken);
                    context.typeCandidates.Clear();
                    if (Vts == null) { throw new ArgumentNullException($"{nameof(Vts)}"); }
                    context.typeCandidates.AddRange(Vts);
                }
            }
        }

        /// <summary>
        /// extend value of current token(<see cref="LexicalContext.analyzingToken"/>)
        /// </summary>
        /// <param name="context"></param>
        private static void ExtendToken(LexicalContext context) {
            if (context.checkerDict.IsEmpty) {
                context.checkpoint = context.Cursor;
            }
        }

        /// <summary>
        /// accept current <see cref="Token"/>(<see cref="LexicalContext.analyzingToken"/>)
        /// <para>set <see cref="Token.type"/> and neutralize the last LexicalContext.MoveForward()</para>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vts"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void AcceptToken(LexicalContext context, string Vt) {
            context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index + 1);
            var typeSet = CheckKeyword(context.analyzingToken);
            if (!typeSet) {
                if (context.typeCandidates.Contains(Vt)) {
                    context.analyzingToken.type = Vt;
                    typeSet = true;
                }
            }
            if (!typeSet) { throw new NotImplementedException(); }

            context.checkerDict.TryUncheck(Vt);

            var backStep = context.Cursor - context.checkpoint;
            if (backStep > 0) { context.MoveBack(backStep); }
        }

        /// <summary>
        /// accept current <see cref="Token"/>(<see cref="LexicalContext.analyzingToken"/>)
        /// <para>set <see cref="Token.type"/> and neutralize the last LexicalContext.MoveForward()</para>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Vts"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void AcceptToken(LexicalContext context, params string[] Vts) {
            context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index + 1);
            var typeSet = CheckKeyword(context.analyzingToken);
            if (!typeSet) {
                foreach (var Vt in Vts) {
                    if (context.typeCandidates.Contains(Vt)) {
                        context.analyzingToken.type = Vt;
                        typeSet = true;
                        break;
                    }
                }
            }
            if (!typeSet) { throw new NotImplementedException(); }

            foreach (var Vt in Vts) {
                context.checkerDict.TryUncheck(Vt);
            }

            var backStep = context.Cursor - context.checkpoint;
            if (backStep > 0) { context.MoveBack(backStep); }
        }
    }
}
