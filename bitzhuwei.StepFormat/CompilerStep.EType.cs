using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        /// <summary>
        /// Vt types are used both for lexical analyzing and syntax parsing.
        /// <para>Vt is quoted in ''.</para>
        /// <para>Vn types are only for syntax parsing.</para>
        /// <para>Vn is not quoted in ''.</para>
        /// </summary>
        public static class EType
        {
            // We don't need explict NotYet any more.
            ///// <summary>
            ///// syntax parsing for this <see cref="Node"/> is not finished yet.
            ///// <para>This must be set to 0, so that we don't need to "this.type = ENode.NotYet;" in the <see cref="Node"/> class.</para>
            ///// </summary>
            //public const string NotYet = "'？'";
            // Vt
            /// <summary>
            /// Something wrong within the source code.
            /// </summary>
            public const string Error = "'×'";
            /// <summary>
            /// 多行注释 /**/
            /// </summary>
            public const string MultipleLineComment = "/**/";
            /// <summary>
            /// 单行注释 //
            /// </summary>
            public const string SingleLineComment = "//";
            // TODO: lexical analyzer generation for comment here.
            /// <summary>
            /// ISO-nnn-nnn;
            /// </summary>
            public const string STEP = "'STEP'";
            /// <summary>
            /// ';'
            /// </summary>
            public const string Semicolon = "';'";
            /// <summary>
            /// 'HEADER'
            /// </summary>
            public const string HEADER = "'HEADER'";
            /// <summary>
            /// 'ENDSEC'
            /// </summary>
            public const string ENDSEC = "'ENDSEC'";
            /// <summary>
            /// 'DATA'
            /// </summary>
            public const string DATA = "'DATA'";
            /// <summary>
            /// END-ISO-nnn-nnn
            /// </summary>
            public const string ENDSTEP = "'ENDSTEP'";
            /// <summary>
            /// #nnn followed by = ...
            /// </summary>
            public const string EntityId = "'EntityId'";
            /// <summary>
            /// '='
            /// </summary>
            public const string Equal = "'='";
            /// <summary>
            /// 'SCOPE'
            /// </summary>
            public const string SCOPE = "'SCOPE'";
            /// <summary>
            /// 'ENDSCOPE'
            /// </summary>
            public const string ENDSCOPE = "'ENDSCOPE'";
            /// <summary>
            /// '/'
            /// </summary>
            public const string Slash = "'/'";
            /// <summary>
            /// ','
            /// </summary>
            public const string Comma = "','";
            /// <summary>
            /// #nnn, ... or #nnn) ...
            /// </summary>
            public const string Identity = "'Identity'";
            /// <summary>
            /// '('
            /// </summary>
            public const string LeftParenthesis = "'('";
            /// <summary>
            /// ')'
            /// </summary>
            public const string RightParenthesis = "')'";
            /// <summary>
            /// CARTESIAN_POINT, DIRECTION, VECTOR, ORIENTED_EDGE, FACE_BOUND, ...
            /// </summary>
            public const string TypeName = "'TypeName'";
            /// <summary>
            /// '$'
            /// </summary>
            public const string Dollar = "'$'";
            /// <summary>
            /// '*'
            /// </summary>
            public const string Asterisk = "'*'";
            /// <summary>
            /// 'xxx' followed by , or 'xxx' followed by )
            /// </summary>
            public const string String = "'String'";
            /// <summary>
            /// nn
            /// </summary>
            public const string Integer = "'Integer'";
            /// <summary>
            /// .nn or nn. or nn.nn or .nnEnn or nn.Enn or nn.nnEnn
            /// </summary>
            public const string Float = "'Float'";
            /// <summary>
            /// ["][0-9A-F]+["]
            /// </summary>
            public const string Hexadecimal = "'Hexadecimal'";
            /// <summary>
            /// .XXX. or .nnn. or .???.
            /// </summary>
            public const string Enum = "'Enum'";

            /// <summary>
            /// end of token list.
            /// </summary>
            public const string EndOfTokenList = "'￥'";
            /// <summary>
            /// in coding. Lexical analyzing for this character is not done yet.
            /// <para>remove this when all compiling system is done.</para>
            /// </summary>
            public const string Coding = "'。。。'";
            // Vn
            /// <summary>
            /// StepFile
            /// <para>Start node.</para>
            /// </summary>
            public const string StepFile = "StepFile";
            /// <summary>
            /// Model
            /// <para>1 or more <see cref="Entity"/>.</para>
            /// </summary>
            public const string Model = "Model";
            /// <summary>
            /// Entity
            /// <para>#nnn = XXX(...);</para>
            /// </summary>
            public const string Entity = "Entity";
            /// <summary>
            /// ScopeBlock
            /// <para>SCOPE [Model] ENDSCOPE / Identity, Identity, ... /</para>
            /// </summary>
            public const string ScopeBlock = "ScopeBlock";
            /// <summary>
            /// IdList
            /// <para>#nnn, #nnn, #nnn</para>
            /// </summary>
            public const string IdList = "IdList";
            /// <summary>
            /// EntityBody
            /// <para>XXX( <see cref="Arg"/>, <see cref="Arg"/>, ... )</para>
            /// <para>or ( XXX( ... ) XXX( ... ) ... )</para>
            /// </summary>
            public const string EntityBody = "EntityBody";
            /// <summary>
            /// TypeObj
            /// <para>XXX( <see cref="Arg"/>, <see cref="Arg"/>, ... )</para>
            /// </summary>
            public const string TypeObj = "TypeObj";
            /// <summary>
            /// Complex
            /// <para>1 or more XXX( Arg, Arg, ... )</para>
            /// </summary>
            public const string Complex = "Complex";
            /// <summary>
            /// HeadLine
            /// <para>1 or more XXX( Arg, Arg, ... );</para>
            /// </summary>
            public const string HeadLine = "HeadLine";
            /// <summary>
            /// LArgsJ
            /// <para>()</para>
            /// <para>or ( Arg, Arg, ... )</para>
            /// </summary>
            public const string LArgsJ = "LArgsJ";
            /// <summary>
            /// Args
            /// <para>Arg, Arg, ...</para>
            /// </summary>
            public const string Args = "Args";
            /// <summary>
            /// Arg
            /// <para>#nnn followed by ',' or followed by ')'</para>
            /// </summary>
            public const string Arg = "Arg";

        }
    }
}
