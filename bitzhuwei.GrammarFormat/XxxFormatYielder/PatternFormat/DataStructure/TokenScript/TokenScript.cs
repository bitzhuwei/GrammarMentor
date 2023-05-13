using bitzhuwei.GrammarFormat;
using System;
using System.IO;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// new <see cref="bitzhuwei.Compiler.Token"/>
    /// <para>end <see cref="bitzhuwei.Compiler.Token"/></para>
    /// <para>accept <see cref="bitzhuwei.Compiler.Token"/></para>
    /// </summary>
    public partial class TokenScript /*: ICloneable*/ {
        ///// <summary>
        ///// <see cref="bitzhuwei.Compiler.Token.type"/>
        ///// </summary>
        /// <summary>
        /// 'xxx'
        /// <para><see cref="bitzhuwei.Compiler.Node.type"/></para>
        /// <para><see cref="bitzhuwei.Compiler.Token.type"/></para>
        /// </summary>
        public readonly string Vt;

        public readonly ETokenScriptType type;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Vt"></param>
        /// <param name="type"></param>
        public TokenScript(string Vt, ETokenScriptType type) {
            this.Vt = Vt;
            this.type = type;
        }

        //public object Clone() {
        //    return new TokenDraft(this.Vt, this.statement);
        //}

        public override string ToString() {
            return $"{this.Vt}: {this.type}";
        }
    }

    /// <summary>
    /// The order of items is important! Don't change it!
    /// </summary>
    public enum ETokenScriptType {
        /// <summary>
        /// 
        /// </summary>
        AcceptPrevious,
        // 需检测：Token是否满足/后缀。
        /// <summary>
        /// context.postRegex = true;
        /// </summary>
        CheckToken,
        /// <summary>
        /// var token = new Token(..)
        /// context.result.Add(token)
        /// </summary>
        BeginToken,
        /// <summary>
        /// context.checkpoint = context.Cursor + 1;
        /// </summary>
        ExtendToken,
        // 完成检测：Token满足/后缀。
        /// <summary>
        /// token.value = ..
        /// token.type = ..
        /// context.MoveBack(..);
        /// context.postRegex = false;
        /// </summary>
        AcceptToken,
    }
}