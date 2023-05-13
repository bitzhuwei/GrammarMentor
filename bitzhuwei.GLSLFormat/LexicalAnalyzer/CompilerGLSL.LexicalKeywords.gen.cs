using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        /// <summary>
        /// ' '
        /// </summary>
        const char space = (char)32; // ' ';
        /// <summary>
        /// '\t' = '\u0009'
        /// </summary>
        const char HorizontalTab = '\t';
        /// <summary>
        /// '\n' = '\u000A'
        /// </summary>
        const char NewLine = '\n';
        /// <summary>
        /// '\r' = '\u000D'
        /// </summary>
        const char CarriageReturn = '\r';
        /// <summary>
        /// '\''
        /// </summary>
        const char quot = '\'';
        /// <summary>
        /// '\"'
        /// </summary>
        const char doubleQuot = '\"';

        /// <summary>
        /// true
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @truekeyword = "true";
        /// <summary>
        /// false
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @falsekeyword = "false";
        /// <summary>
        /// void
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @voidkeyword = "void";
        /// <summary>
        /// precision
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @precisionkeyword = "precision";
        /// <summary>
        /// invariant
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @invariantkeyword = "invariant";
        /// <summary>
        /// smooth
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @smoothkeyword = "smooth";
        /// <summary>
        /// flat
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @flatkeyword = "flat";
        /// <summary>
        /// noperspective
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @noperspectivekeyword = "noperspective";
        /// <summary>
        /// layout
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @layoutkeyword = "layout";
        /// <summary>
        /// precise
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @precisekeyword = "precise";
        /// <summary>
        /// const
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @constkeyword = "const";
        /// <summary>
        /// inout
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @inoutkeyword = "inout";
        /// <summary>
        /// in
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @inkeyword = "in";
        /// <summary>
        /// out
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @outkeyword = "out";
        /// <summary>
        /// centroid
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @centroidkeyword = "centroid";
        /// <summary>
        /// patch
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @patchkeyword = "patch";
        /// <summary>
        /// sample
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplekeyword = "sample";
        /// <summary>
        /// uniform
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uniformkeyword = "uniform";
        /// <summary>
        /// buffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @bufferkeyword = "buffer";
        /// <summary>
        /// shared
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sharedkeyword = "shared";
        /// <summary>
        /// coherent
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @coherentkeyword = "coherent";
        /// <summary>
        /// volatile
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @volatilekeyword = "volatile";
        /// <summary>
        /// restrict
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @restrictkeyword = "restrict";
        /// <summary>
        /// readonly
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @readonlykeyword = "readonly";
        /// <summary>
        /// writeonly
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @writeonlykeyword = "writeonly";
        /// <summary>
        /// subroutine
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @subroutinekeyword = "subroutine";
        /// <summary>
        /// userDefinedType
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @userDefinedTypekeyword = "userDefinedType";
        /// <summary>
        /// float
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @floatkeyword = "float";
        /// <summary>
        /// double
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @doublekeyword = "double";
        /// <summary>
        /// int
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @intkeyword = "int";
        /// <summary>
        /// uint
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uintkeyword = "uint";
        /// <summary>
        /// bool
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @boolkeyword = "bool";
        /// <summary>
        /// vec2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @vec2keyword = "vec2";
        /// <summary>
        /// vec3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @vec3keyword = "vec3";
        /// <summary>
        /// vec4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @vec4keyword = "vec4";
        /// <summary>
        /// dvec2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dvec2keyword = "dvec2";
        /// <summary>
        /// dvec3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dvec3keyword = "dvec3";
        /// <summary>
        /// dvec4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dvec4keyword = "dvec4";
        /// <summary>
        /// bvec2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @bvec2keyword = "bvec2";
        /// <summary>
        /// bvec3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @bvec3keyword = "bvec3";
        /// <summary>
        /// bvec4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @bvec4keyword = "bvec4";
        /// <summary>
        /// ivec2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @ivec2keyword = "ivec2";
        /// <summary>
        /// ivec3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @ivec3keyword = "ivec3";
        /// <summary>
        /// ivec4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @ivec4keyword = "ivec4";
        /// <summary>
        /// uvec2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uvec2keyword = "uvec2";
        /// <summary>
        /// uvec3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uvec3keyword = "uvec3";
        /// <summary>
        /// uvec4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uvec4keyword = "uvec4";
        /// <summary>
        /// mat2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat2keyword = "mat2";
        /// <summary>
        /// mat3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat3keyword = "mat3";
        /// <summary>
        /// mat4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat4keyword = "mat4";
        /// <summary>
        /// mat2x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat2x2keyword = "mat2x2";
        /// <summary>
        /// mat2x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat2x3keyword = "mat2x3";
        /// <summary>
        /// mat2x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat2x4keyword = "mat2x4";
        /// <summary>
        /// mat3x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat3x2keyword = "mat3x2";
        /// <summary>
        /// mat3x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat3x3keyword = "mat3x3";
        /// <summary>
        /// mat3x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat3x4keyword = "mat3x4";
        /// <summary>
        /// mat4x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat4x2keyword = "mat4x2";
        /// <summary>
        /// mat4x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat4x3keyword = "mat4x3";
        /// <summary>
        /// mat4x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @mat4x4keyword = "mat4x4";
        /// <summary>
        /// dmat2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat2keyword = "dmat2";
        /// <summary>
        /// dmat3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat3keyword = "dmat3";
        /// <summary>
        /// dmat4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat4keyword = "dmat4";
        /// <summary>
        /// dmat2x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat2x2keyword = "dmat2x2";
        /// <summary>
        /// dmat2x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat2x3keyword = "dmat2x3";
        /// <summary>
        /// dmat2x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat2x4keyword = "dmat2x4";
        /// <summary>
        /// dmat3x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat3x2keyword = "dmat3x2";
        /// <summary>
        /// dmat3x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat3x3keyword = "dmat3x3";
        /// <summary>
        /// dmat3x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat3x4keyword = "dmat3x4";
        /// <summary>
        /// dmat4x2
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat4x2keyword = "dmat4x2";
        /// <summary>
        /// dmat4x3
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat4x3keyword = "dmat4x3";
        /// <summary>
        /// dmat4x4
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dmat4x4keyword = "dmat4x4";
        /// <summary>
        /// atomic_uint
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @atomic_uintkeyword = "atomic_uint";
        /// <summary>
        /// sampler1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler1Dkeyword = "sampler1D";
        /// <summary>
        /// sampler2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2Dkeyword = "sampler2D";
        /// <summary>
        /// sampler3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler3Dkeyword = "sampler3D";
        /// <summary>
        /// samplerCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplerCubekeyword = "samplerCube";
        /// <summary>
        /// sampler1DShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler1DShadowkeyword = "sampler1DShadow";
        /// <summary>
        /// sampler2DShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DShadowkeyword = "sampler2DShadow";
        /// <summary>
        /// samplerCubeShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplerCubeShadowkeyword = "samplerCubeShadow";
        /// <summary>
        /// sampler1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler1DArraykeyword = "sampler1DArray";
        /// <summary>
        /// sampler2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DArraykeyword = "sampler2DArray";
        /// <summary>
        /// sampler1DArrayShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler1DArrayShadowkeyword = "sampler1DArrayShadow";
        /// <summary>
        /// sampler2DArrayShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DArrayShadowkeyword = "sampler2DArrayShadow";
        /// <summary>
        /// samplerCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplerCubeArraykeyword = "samplerCubeArray";
        /// <summary>
        /// samplerCubeArrayShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplerCubeArrayShadowkeyword = "samplerCubeArrayShadow";
        /// <summary>
        /// isampler1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler1Dkeyword = "isampler1D";
        /// <summary>
        /// isampler2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler2Dkeyword = "isampler2D";
        /// <summary>
        /// isampler3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler3Dkeyword = "isampler3D";
        /// <summary>
        /// isamplerCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isamplerCubekeyword = "isamplerCube";
        /// <summary>
        /// isampler1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler1DArraykeyword = "isampler1DArray";
        /// <summary>
        /// isampler2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler2DArraykeyword = "isampler2DArray";
        /// <summary>
        /// isamplerCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isamplerCubeArraykeyword = "isamplerCubeArray";
        /// <summary>
        /// usampler1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler1Dkeyword = "usampler1D";
        /// <summary>
        /// usampler2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler2Dkeyword = "usampler2D";
        /// <summary>
        /// usampler3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler3Dkeyword = "usampler3D";
        /// <summary>
        /// usamplerCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usamplerCubekeyword = "usamplerCube";
        /// <summary>
        /// usampler1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler1DArraykeyword = "usampler1DArray";
        /// <summary>
        /// usampler2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler2DArraykeyword = "usampler2DArray";
        /// <summary>
        /// usamplerCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usamplerCubeArraykeyword = "usamplerCubeArray";
        /// <summary>
        /// sampler2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DRectkeyword = "sampler2DRect";
        /// <summary>
        /// sampler2DRectShadow
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DRectShadowkeyword = "sampler2DRectShadow";
        /// <summary>
        /// isampler2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler2DRectkeyword = "isampler2DRect";
        /// <summary>
        /// usampler2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler2DRectkeyword = "usampler2DRect";
        /// <summary>
        /// samplerBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @samplerBufferkeyword = "samplerBuffer";
        /// <summary>
        /// isamplerBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isamplerBufferkeyword = "isamplerBuffer";
        /// <summary>
        /// usamplerBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usamplerBufferkeyword = "usamplerBuffer";
        /// <summary>
        /// sampler2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DMSkeyword = "sampler2DMS";
        /// <summary>
        /// isampler2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler2DMSkeyword = "isampler2DMS";
        /// <summary>
        /// usampler2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler2DMSkeyword = "usampler2DMS";
        /// <summary>
        /// sampler2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @sampler2DMSArraykeyword = "sampler2DMSArray";
        /// <summary>
        /// isampler2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @isampler2DMSArraykeyword = "isampler2DMSArray";
        /// <summary>
        /// usampler2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @usampler2DMSArraykeyword = "usampler2DMSArray";
        /// <summary>
        /// image1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image1Dkeyword = "image1D";
        /// <summary>
        /// iimage1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage1Dkeyword = "iimage1D";
        /// <summary>
        /// uimage1D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage1Dkeyword = "uimage1D";
        /// <summary>
        /// image2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image2Dkeyword = "image2D";
        /// <summary>
        /// iimage2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage2Dkeyword = "iimage2D";
        /// <summary>
        /// uimage2D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage2Dkeyword = "uimage2D";
        /// <summary>
        /// image3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image3Dkeyword = "image3D";
        /// <summary>
        /// iimage3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage3Dkeyword = "iimage3D";
        /// <summary>
        /// uimage3D
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage3Dkeyword = "uimage3D";
        /// <summary>
        /// image2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image2DRectkeyword = "image2DRect";
        /// <summary>
        /// iimage2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage2DRectkeyword = "iimage2DRect";
        /// <summary>
        /// uimage2DRect
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage2DRectkeyword = "uimage2DRect";
        /// <summary>
        /// imageCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @imageCubekeyword = "imageCube";
        /// <summary>
        /// iimageCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimageCubekeyword = "iimageCube";
        /// <summary>
        /// uimageCube
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimageCubekeyword = "uimageCube";
        /// <summary>
        /// imageBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @imageBufferkeyword = "imageBuffer";
        /// <summary>
        /// iimageBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimageBufferkeyword = "iimageBuffer";
        /// <summary>
        /// uimageBuffer
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimageBufferkeyword = "uimageBuffer";
        /// <summary>
        /// image1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image1DArraykeyword = "image1DArray";
        /// <summary>
        /// iimage1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage1DArraykeyword = "iimage1DArray";
        /// <summary>
        /// uimage1DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage1DArraykeyword = "uimage1DArray";
        /// <summary>
        /// image2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image2DArraykeyword = "image2DArray";
        /// <summary>
        /// iimage2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage2DArraykeyword = "iimage2DArray";
        /// <summary>
        /// uimage2DArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage2DArraykeyword = "uimage2DArray";
        /// <summary>
        /// imageCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @imageCubeArraykeyword = "imageCubeArray";
        /// <summary>
        /// iimageCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimageCubeArraykeyword = "iimageCubeArray";
        /// <summary>
        /// uimageCubeArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimageCubeArraykeyword = "uimageCubeArray";
        /// <summary>
        /// image2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image2DMSkeyword = "image2DMS";
        /// <summary>
        /// iimage2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage2DMSkeyword = "iimage2DMS";
        /// <summary>
        /// uimage2DMS
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage2DMSkeyword = "uimage2DMS";
        /// <summary>
        /// image2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @image2DMSArraykeyword = "image2DMSArray";
        /// <summary>
        /// iimage2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @iimage2DMSArraykeyword = "iimage2DMSArray";
        /// <summary>
        /// uimage2DMSArray
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @uimage2DMSArraykeyword = "uimage2DMSArray";
        /// <summary>
        /// high_precision
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @high_precisionkeyword = "high_precision";
        /// <summary>
        /// medium_precision
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @medium_precisionkeyword = "medium_precision";
        /// <summary>
        /// low_precision
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @low_precisionkeyword = "low_precision";
        /// <summary>
        /// struct
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @structkeyword = "struct";
        /// <summary>
        /// if
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @ifkeyword = "if";
        /// <summary>
        /// else
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @elsekeyword = "else";
        /// <summary>
        /// switch
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @switchkeyword = "switch";
        /// <summary>
        /// case
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @casekeyword = "case";
        /// <summary>
        /// default
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @defaultkeyword = "default";
        /// <summary>
        /// while
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @whilekeyword = "while";
        /// <summary>
        /// do
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dokeyword = "do";
        /// <summary>
        /// for
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @forkeyword = "for";
        /// <summary>
        /// continue
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @continuekeyword = "continue";
        /// <summary>
        /// break
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @breakkeyword = "break";
        /// <summary>
        /// return
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @returnkeyword = "return";
        /// <summary>
        /// discard
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @discardkeyword = "discard";


        /// <summary>
        /// if <paramref name="token"/> is a keyword, assign correspond type and return true.
        /// <para>otherwise, return false.</para>
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static bool CheckKeyword(Token token) {
            bool isKeyword;
            switch (token.value) {
            //case @emptykeyword: token.type = EType.@empty; isKeyword = true; break;
            case @truekeyword: token.type = EType.@true; isKeyword = true; break;
            case @falsekeyword: token.type = EType.@false; isKeyword = true; break;
            case @voidkeyword: token.type = EType.@void; isKeyword = true; break;
            case @precisionkeyword: token.type = EType.@precision; isKeyword = true; break;
            case @invariantkeyword: token.type = EType.@invariant; isKeyword = true; break;
            case @smoothkeyword: token.type = EType.@smooth; isKeyword = true; break;
            case @flatkeyword: token.type = EType.@flat; isKeyword = true; break;
            case @noperspectivekeyword: token.type = EType.@noperspective; isKeyword = true; break;
            case @layoutkeyword: token.type = EType.@layout; isKeyword = true; break;
            case @precisekeyword: token.type = EType.@precise; isKeyword = true; break;
            case @constkeyword: token.type = EType.@const; isKeyword = true; break;
            case @inoutkeyword: token.type = EType.@inout; isKeyword = true; break;
            case @inkeyword: token.type = EType.@in; isKeyword = true; break;
            case @outkeyword: token.type = EType.@out; isKeyword = true; break;
            case @centroidkeyword: token.type = EType.@centroid; isKeyword = true; break;
            case @patchkeyword: token.type = EType.@patch; isKeyword = true; break;
            case @samplekeyword: token.type = EType.@sample; isKeyword = true; break;
            case @uniformkeyword: token.type = EType.@uniform; isKeyword = true; break;
            case @bufferkeyword: token.type = EType.@buffer; isKeyword = true; break;
            case @sharedkeyword: token.type = EType.@shared; isKeyword = true; break;
            case @coherentkeyword: token.type = EType.@coherent; isKeyword = true; break;
            case @volatilekeyword: token.type = EType.@volatile; isKeyword = true; break;
            case @restrictkeyword: token.type = EType.@restrict; isKeyword = true; break;
            case @readonlykeyword: token.type = EType.@readonly; isKeyword = true; break;
            case @writeonlykeyword: token.type = EType.@writeonly; isKeyword = true; break;
            case @subroutinekeyword: token.type = EType.@subroutine; isKeyword = true; break;
            case @userDefinedTypekeyword: token.type = EType.@userDefinedType; isKeyword = true; break;
            case @floatkeyword: token.type = EType.@float; isKeyword = true; break;
            case @doublekeyword: token.type = EType.@double; isKeyword = true; break;
            case @intkeyword: token.type = EType.@int; isKeyword = true; break;
            case @uintkeyword: token.type = EType.@uint; isKeyword = true; break;
            case @boolkeyword: token.type = EType.@bool; isKeyword = true; break;
            case @vec2keyword: token.type = EType.@vec2; isKeyword = true; break;
            case @vec3keyword: token.type = EType.@vec3; isKeyword = true; break;
            case @vec4keyword: token.type = EType.@vec4; isKeyword = true; break;
            case @dvec2keyword: token.type = EType.@dvec2; isKeyword = true; break;
            case @dvec3keyword: token.type = EType.@dvec3; isKeyword = true; break;
            case @dvec4keyword: token.type = EType.@dvec4; isKeyword = true; break;
            case @bvec2keyword: token.type = EType.@bvec2; isKeyword = true; break;
            case @bvec3keyword: token.type = EType.@bvec3; isKeyword = true; break;
            case @bvec4keyword: token.type = EType.@bvec4; isKeyword = true; break;
            case @ivec2keyword: token.type = EType.@ivec2; isKeyword = true; break;
            case @ivec3keyword: token.type = EType.@ivec3; isKeyword = true; break;
            case @ivec4keyword: token.type = EType.@ivec4; isKeyword = true; break;
            case @uvec2keyword: token.type = EType.@uvec2; isKeyword = true; break;
            case @uvec3keyword: token.type = EType.@uvec3; isKeyword = true; break;
            case @uvec4keyword: token.type = EType.@uvec4; isKeyword = true; break;
            case @mat2keyword: token.type = EType.@mat2; isKeyword = true; break;
            case @mat3keyword: token.type = EType.@mat3; isKeyword = true; break;
            case @mat4keyword: token.type = EType.@mat4; isKeyword = true; break;
            case @mat2x2keyword: token.type = EType.@mat2x2; isKeyword = true; break;
            case @mat2x3keyword: token.type = EType.@mat2x3; isKeyword = true; break;
            case @mat2x4keyword: token.type = EType.@mat2x4; isKeyword = true; break;
            case @mat3x2keyword: token.type = EType.@mat3x2; isKeyword = true; break;
            case @mat3x3keyword: token.type = EType.@mat3x3; isKeyword = true; break;
            case @mat3x4keyword: token.type = EType.@mat3x4; isKeyword = true; break;
            case @mat4x2keyword: token.type = EType.@mat4x2; isKeyword = true; break;
            case @mat4x3keyword: token.type = EType.@mat4x3; isKeyword = true; break;
            case @mat4x4keyword: token.type = EType.@mat4x4; isKeyword = true; break;
            case @dmat2keyword: token.type = EType.@dmat2; isKeyword = true; break;
            case @dmat3keyword: token.type = EType.@dmat3; isKeyword = true; break;
            case @dmat4keyword: token.type = EType.@dmat4; isKeyword = true; break;
            case @dmat2x2keyword: token.type = EType.@dmat2x2; isKeyword = true; break;
            case @dmat2x3keyword: token.type = EType.@dmat2x3; isKeyword = true; break;
            case @dmat2x4keyword: token.type = EType.@dmat2x4; isKeyword = true; break;
            case @dmat3x2keyword: token.type = EType.@dmat3x2; isKeyword = true; break;
            case @dmat3x3keyword: token.type = EType.@dmat3x3; isKeyword = true; break;
            case @dmat3x4keyword: token.type = EType.@dmat3x4; isKeyword = true; break;
            case @dmat4x2keyword: token.type = EType.@dmat4x2; isKeyword = true; break;
            case @dmat4x3keyword: token.type = EType.@dmat4x3; isKeyword = true; break;
            case @dmat4x4keyword: token.type = EType.@dmat4x4; isKeyword = true; break;
            case @atomic_uintkeyword: token.type = EType.@atomic_uint; isKeyword = true; break;
            case @sampler1Dkeyword: token.type = EType.@sampler1D; isKeyword = true; break;
            case @sampler2Dkeyword: token.type = EType.@sampler2D; isKeyword = true; break;
            case @sampler3Dkeyword: token.type = EType.@sampler3D; isKeyword = true; break;
            case @samplerCubekeyword: token.type = EType.@samplerCube; isKeyword = true; break;
            case @sampler1DShadowkeyword: token.type = EType.@sampler1DShadow; isKeyword = true; break;
            case @sampler2DShadowkeyword: token.type = EType.@sampler2DShadow; isKeyword = true; break;
            case @samplerCubeShadowkeyword: token.type = EType.@samplerCubeShadow; isKeyword = true; break;
            case @sampler1DArraykeyword: token.type = EType.@sampler1DArray; isKeyword = true; break;
            case @sampler2DArraykeyword: token.type = EType.@sampler2DArray; isKeyword = true; break;
            case @sampler1DArrayShadowkeyword: token.type = EType.@sampler1DArrayShadow; isKeyword = true; break;
            case @sampler2DArrayShadowkeyword: token.type = EType.@sampler2DArrayShadow; isKeyword = true; break;
            case @samplerCubeArraykeyword: token.type = EType.@samplerCubeArray; isKeyword = true; break;
            case @samplerCubeArrayShadowkeyword: token.type = EType.@samplerCubeArrayShadow; isKeyword = true; break;
            case @isampler1Dkeyword: token.type = EType.@isampler1D; isKeyword = true; break;
            case @isampler2Dkeyword: token.type = EType.@isampler2D; isKeyword = true; break;
            case @isampler3Dkeyword: token.type = EType.@isampler3D; isKeyword = true; break;
            case @isamplerCubekeyword: token.type = EType.@isamplerCube; isKeyword = true; break;
            case @isampler1DArraykeyword: token.type = EType.@isampler1DArray; isKeyword = true; break;
            case @isampler2DArraykeyword: token.type = EType.@isampler2DArray; isKeyword = true; break;
            case @isamplerCubeArraykeyword: token.type = EType.@isamplerCubeArray; isKeyword = true; break;
            case @usampler1Dkeyword: token.type = EType.@usampler1D; isKeyword = true; break;
            case @usampler2Dkeyword: token.type = EType.@usampler2D; isKeyword = true; break;
            case @usampler3Dkeyword: token.type = EType.@usampler3D; isKeyword = true; break;
            case @usamplerCubekeyword: token.type = EType.@usamplerCube; isKeyword = true; break;
            case @usampler1DArraykeyword: token.type = EType.@usampler1DArray; isKeyword = true; break;
            case @usampler2DArraykeyword: token.type = EType.@usampler2DArray; isKeyword = true; break;
            case @usamplerCubeArraykeyword: token.type = EType.@usamplerCubeArray; isKeyword = true; break;
            case @sampler2DRectkeyword: token.type = EType.@sampler2DRect; isKeyword = true; break;
            case @sampler2DRectShadowkeyword: token.type = EType.@sampler2DRectShadow; isKeyword = true; break;
            case @isampler2DRectkeyword: token.type = EType.@isampler2DRect; isKeyword = true; break;
            case @usampler2DRectkeyword: token.type = EType.@usampler2DRect; isKeyword = true; break;
            case @samplerBufferkeyword: token.type = EType.@samplerBuffer; isKeyword = true; break;
            case @isamplerBufferkeyword: token.type = EType.@isamplerBuffer; isKeyword = true; break;
            case @usamplerBufferkeyword: token.type = EType.@usamplerBuffer; isKeyword = true; break;
            case @sampler2DMSkeyword: token.type = EType.@sampler2DMS; isKeyword = true; break;
            case @isampler2DMSkeyword: token.type = EType.@isampler2DMS; isKeyword = true; break;
            case @usampler2DMSkeyword: token.type = EType.@usampler2DMS; isKeyword = true; break;
            case @sampler2DMSArraykeyword: token.type = EType.@sampler2DMSArray; isKeyword = true; break;
            case @isampler2DMSArraykeyword: token.type = EType.@isampler2DMSArray; isKeyword = true; break;
            case @usampler2DMSArraykeyword: token.type = EType.@usampler2DMSArray; isKeyword = true; break;
            case @image1Dkeyword: token.type = EType.@image1D; isKeyword = true; break;
            case @iimage1Dkeyword: token.type = EType.@iimage1D; isKeyword = true; break;
            case @uimage1Dkeyword: token.type = EType.@uimage1D; isKeyword = true; break;
            case @image2Dkeyword: token.type = EType.@image2D; isKeyword = true; break;
            case @iimage2Dkeyword: token.type = EType.@iimage2D; isKeyword = true; break;
            case @uimage2Dkeyword: token.type = EType.@uimage2D; isKeyword = true; break;
            case @image3Dkeyword: token.type = EType.@image3D; isKeyword = true; break;
            case @iimage3Dkeyword: token.type = EType.@iimage3D; isKeyword = true; break;
            case @uimage3Dkeyword: token.type = EType.@uimage3D; isKeyword = true; break;
            case @image2DRectkeyword: token.type = EType.@image2DRect; isKeyword = true; break;
            case @iimage2DRectkeyword: token.type = EType.@iimage2DRect; isKeyword = true; break;
            case @uimage2DRectkeyword: token.type = EType.@uimage2DRect; isKeyword = true; break;
            case @imageCubekeyword: token.type = EType.@imageCube; isKeyword = true; break;
            case @iimageCubekeyword: token.type = EType.@iimageCube; isKeyword = true; break;
            case @uimageCubekeyword: token.type = EType.@uimageCube; isKeyword = true; break;
            case @imageBufferkeyword: token.type = EType.@imageBuffer; isKeyword = true; break;
            case @iimageBufferkeyword: token.type = EType.@iimageBuffer; isKeyword = true; break;
            case @uimageBufferkeyword: token.type = EType.@uimageBuffer; isKeyword = true; break;
            case @image1DArraykeyword: token.type = EType.@image1DArray; isKeyword = true; break;
            case @iimage1DArraykeyword: token.type = EType.@iimage1DArray; isKeyword = true; break;
            case @uimage1DArraykeyword: token.type = EType.@uimage1DArray; isKeyword = true; break;
            case @image2DArraykeyword: token.type = EType.@image2DArray; isKeyword = true; break;
            case @iimage2DArraykeyword: token.type = EType.@iimage2DArray; isKeyword = true; break;
            case @uimage2DArraykeyword: token.type = EType.@uimage2DArray; isKeyword = true; break;
            case @imageCubeArraykeyword: token.type = EType.@imageCubeArray; isKeyword = true; break;
            case @iimageCubeArraykeyword: token.type = EType.@iimageCubeArray; isKeyword = true; break;
            case @uimageCubeArraykeyword: token.type = EType.@uimageCubeArray; isKeyword = true; break;
            case @image2DMSkeyword: token.type = EType.@image2DMS; isKeyword = true; break;
            case @iimage2DMSkeyword: token.type = EType.@iimage2DMS; isKeyword = true; break;
            case @uimage2DMSkeyword: token.type = EType.@uimage2DMS; isKeyword = true; break;
            case @image2DMSArraykeyword: token.type = EType.@image2DMSArray; isKeyword = true; break;
            case @iimage2DMSArraykeyword: token.type = EType.@iimage2DMSArray; isKeyword = true; break;
            case @uimage2DMSArraykeyword: token.type = EType.@uimage2DMSArray; isKeyword = true; break;
            case @high_precisionkeyword: token.type = EType.@high_precision; isKeyword = true; break;
            case @medium_precisionkeyword: token.type = EType.@medium_precision; isKeyword = true; break;
            case @low_precisionkeyword: token.type = EType.@low_precision; isKeyword = true; break;
            case @structkeyword: token.type = EType.@struct; isKeyword = true; break;
            case @ifkeyword: token.type = EType.@if; isKeyword = true; break;
            case @elsekeyword: token.type = EType.@else; isKeyword = true; break;
            case @switchkeyword: token.type = EType.@switch; isKeyword = true; break;
            case @casekeyword: token.type = EType.@case; isKeyword = true; break;
            case @defaultkeyword: token.type = EType.@default; isKeyword = true; break;
            case @whilekeyword: token.type = EType.@while; isKeyword = true; break;
            case @dokeyword: token.type = EType.@do; isKeyword = true; break;
            case @forkeyword: token.type = EType.@for; isKeyword = true; break;
            case @continuekeyword: token.type = EType.@continue; isKeyword = true; break;
            case @breakkeyword: token.type = EType.@break; isKeyword = true; break;
            case @returnkeyword: token.type = EType.@return; isKeyword = true; break;
            case @discardkeyword: token.type = EType.@discard; isKeyword = true; break;

            default: isKeyword = false; break;
            }

            return isKeyword;
        }
    }
}
