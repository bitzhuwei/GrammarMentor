using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        /// <summary>
        /// Vt types are used both for lexical analyzing and syntax parsing.
        /// <para>Vt is quoted in ''.</para>
        /// <para>Vn types are only for syntax parsing.</para>
        /// <para>Vn is not quoted in ''.</para>
        /// </summary>
        public static class EType
        {
            // Vt
            /// <summary>
            /// Something wrong within the source code.
            /// </summary>
            public const string Error = "'×'";
            ///// <summary>
            ///// 多行注释 /**/
            ///// </summary>
            //public const string MultipleLineComment="/**/";
            /// <summary>
            /// 单行注释 //
            /// </summary>
            public const string SingleLineComment = "//";
            /// <summary>
            /// 'Separator'
            /// </summary>
            public const string Separator = "'Separator'";
            /// <summary>
            /// {
            /// </summary>
            public const string LeftBrace = "'{'";
            /// <summary>
            /// }
            /// </summary>
            public const string RightBrace = "'}'";
            /// <summary>
            /// [
            /// </summary>
            public const string LeftBracket = "'['";
            /// <summary>
            /// ]
            /// </summary>
            public const string RightBracket = "']'";
            /// <summary>
            /// ,
            /// </summary>
            public const string Comma = "','";
            /// <summary>
            /// [a-zA-Z_][a-zA-Z0-9_]*
            /// </summary>
            public const string identifier = "'identifier'";
            /// <summary>
            /// 'ambientColor'
            /// </summary>
            public const string ambientColor = "'ambientColor'";
            /// <summary>
            /// diffuseColor
            /// </summary>
            public const string diffuseColor = "'diffuseColor'";
            /// <summary>
            /// emissiveColor
            /// </summary>
            public const string emissiveColor = "'emissiveColor'";
            /// <summary>
            /// specularColor
            /// </summary>
            public const string specularColor = "'specularColor'";
            /// <summary>
            /// shininess
            /// </summary>
            public const string shininess = "'shininess'";
            /// <summary>
            /// transparency
            /// </summary>
            public const string transparency = "'transparency'";
            /// <summary>
            /// point
            /// </summary>
            public const string point = "'point'";
            /// <summary>
            /// coordIndex
            /// </summary>
            public const string coordIndex = "'coordIndex'";
            /// <summary>
            /// nn
            /// </summary>
            public const string Integer = "'Integer'";
            /// <summary>
            /// nn.nn
            /// </summary>
            public const string Float = "'Float'";
            /// <summary>
            /// end of token list.
            /// <para>Only used for syntax parsing.</para>
            /// </summary>
            public const string EndOfTokenList = "'￥'";
            /// <summary>
            /// in coding. Lexical analyzing for this character is not done yet.
            /// <para>remove this when all compiling system is done.</para>
            /// </summary>
            public const string Coding = "'。。。'";
            // Vn
            /// <summary>
            /// a Vn
            /// </summary>
            public const string SeparatorStart = "SeparatorStart";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string PropertyGroupList = "PropertyGroupList";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string PropertyGroup = "PropertyGroup";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string GroupName = "GroupName";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string PropertyList = "PropertyList";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string Property = "Property";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string PointList = "PointList";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string Point = "Point";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string CoordIndexList = "CoordIndexList";
            /// <summary>
            /// a Vn
            /// </summary>
            public const string CoordIndex = "CoordIndex";
        }
    }
}

