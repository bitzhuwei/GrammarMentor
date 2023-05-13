using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// FIRST( <see cref="Node.type"/> <see cref="Node.type"/> .. ) = { <see cref="Node.type"/>, <see cref="Node.type"/>, ... }
    /// <para>All possible first Vt nodes in ( .. )</para>
    /// <para>{ ... } may contains <see cref="CompilerGrammar.keywordEmpty"/></para>
    /// <para>If ( .. ) can refer to <see cref="CompilerGrammar.keywordEmpty"/>,</para>
    /// <para>then FIRST( ..) contains <see cref="CompilerGrammar.keywordEmpty"/></para>
    /// </summary>
    public class FIRST {
        ///// <summary>
        ///// Make key for <see cref="Node.type"/>
        ///// <para>so that we can find the <see cref="FIRST"/> object in a <see cref="Dictionary{String, FIRST}"/></para>
        ///// </summary>
        ///// <param name="node"><see cref="Node.type"/></param>
        ///// <returns></returns>
        //public static string MakeKey(string/*Node.type*/ node)
        //{
        //    return node;
        //}

        /// <summary>
        /// Make key for <see cref="Node.type"/> <see cref="Node.type"/> ...
        /// <para>so that we can find the <see cref="FIRST"/> object in a <see cref="Dictionary{String, FIRST}"/></para>
        /// </summary>
        /// <param name="nodes"><see cref="Node.type"/> <see cref="Node.type"/> ...</param>
        /// <returns></returns>
        public static string MakeKey(IReadOnlyList<string/*Node.type*/> nodes) {
            var count = nodes.Count;
            var b = new StringBuilder();
            for (int index = 0; index + 1 < count; index++) {
                var item = nodes[index];
                b.Append(item); b.Append(' ');
            }
            if (count > 0) {
                var item = nodes[count - 1];
                b.Append(item);
            }

            // should not do this.
            //if (index == 0) // nodes.Count() == 0
            //{
            //    b.Append(CompilerGrammar.keywordnull);
            //}

            return b.ToString();
        }

        /// <summary>
        /// FIRST( <see cref="Node.type"/> <see cref="Node.type"/> .. ) = { <see cref="Node.type"/>, <see cref="Node.type"/>, ... }
        /// <para>All possible first Vt nodes in ( .. )</para>
        /// <para>{ ... } may contains <see cref="CompilerGrammar.keywordEmpty"/></para>
        /// <para>If ( .. ) can refer to <see cref="CompilerGrammar.keywordEmpty"/>,</para>
        /// <para>then FIRST( ..) contains <see cref="CompilerGrammar.keywordEmpty"/></para>
        /// </summary>
        /// <param name="key"><see cref="Node.type"/><see cref="Node.type"/></param>
        /// <param name="values"><see cref="Node.type"/>, <see cref="Node.type"/>, ...</param>
        public FIRST(string/*Node.type*/ key, params string/*Node.type*/[] values) {
            this.key = new string[] { key };
            this.keyString = key;// MakeKey(key);
            if (values != null) {
                foreach (var item in values) {
                    this.m_Values.TryInsert(item);
                }
            }
        }

        /// <summary>
        /// FIRST( <see cref="Node.type"/> <see cref="Node.type"/> .. ) = { <see cref="Node.type"/>, <see cref="Node.type"/>, ... }
        /// <para>All possible first Vt nodes in ( .. )</para>
        /// <para>{ ... } may contains <see cref="CompilerGrammar.keywordEmpty"/></para>
        /// <para>If ( .. ) can refer to <see cref="CompilerGrammar.keywordEmpty"/>,</para>
        /// <para>then FIRST( ..) contains <see cref="CompilerGrammar.keywordEmpty"/></para>
        /// </summary>
        /// <param name="key"><see cref="Node.type"/> <see cref="Node.type"/> ...</param>
        /// <param name="values"><see cref="Node.type"/>, <see cref="Node.type"/>, ...</param>
        public FIRST(IReadOnlyList<string/*Node.type*/> key, params string/*Node.type*/[] values) {
            int count = key.Count; var keyArray = new string[count];
            for (int i = 0; i < count; i++) { keyArray[i] = key[i]; }
            this.key = keyArray;
            this.keyString = FIRST.MakeKey(key);
            if (values != null) {
                foreach (var item in values) {
                    this.m_Values.TryInsert(item);
                }
            }
        }

        /// <summary>
        /// <see cref="FIRST.key"/> in string form.
        /// </summary>
        public readonly string keyString;
        public readonly string/*Node.type*/[] key;
        // no need. too much designed.
        //public IReadOnlyList<string/*Node.type*/> Key { get { return this.m_Key; } }
        //public string/*Node.type*/ GetNode(int index)
        //{
        //    return this.m_Key[index];
        //}

        //TODO: maybe no need to use CoupleList here. Yes, it does. to make sure not repeated items in it.
        private CoupleList<string/*Node.type*/> m_Values = new CoupleList<string/*Node.type*/>();
        /// <summary>
        /// collection of (Vt or <see cref="CompilerGrammar.keywordEmpty"/>)
        /// </summary>
        public IReadOnlyList<string/*Node.type*/> Values { get { return this.m_Values; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryInsert(string/*Node.type*/ value) {
            bool inserted = this.m_Values.TryInsert(value);

            return inserted;
        }

        public void Print(System.IO.TextWriter stream) {
            stream.Write("FIRST( "); stream.Write(this.keyString); stream.Write(" ) = { ");
            int count = this.m_Values.Count;
            for (int i = 0; i < count; i++) {
                var value = this.m_Values[i];
                stream.Write(value);
                stream.Write(" ");
            }
            stream.Write("}");
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }
    }
}
