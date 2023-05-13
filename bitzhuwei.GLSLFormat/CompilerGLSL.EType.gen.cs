using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        /// <summary>
        /// Vt types are used both for lexical analyzing and syntax parsing.
        /// <para>Vt is quoted in ''.</para>
        /// <para>Vn types are only for syntax parsing.</para>
        /// <para>Vn is not quoted in ''.</para>
        /// </summary>
        public static class EType {
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
            /// <summary>
            /// 'identifier'
            /// </summary>
            public const string @identifier = "'identifier'";
            /// <summary>
            /// 'number'
            /// </summary>
            public const string @number = "'number'";
            /// <summary>
            /// '('
            /// </summary>
            public const string @LeftParenthesis = "'('";
            /// <summary>
            /// ')'
            /// </summary>
            public const string @RightParenthesis = "')'";
            /// <summary>
            /// 'true'
            /// </summary>
            public const string @true = "'true'";
            /// <summary>
            /// 'false'
            /// </summary>
            public const string @false = "'false'";
            /// <summary>
            /// '['
            /// </summary>
            public const string @LeftBracket = "'['";
            /// <summary>
            /// ']'
            /// </summary>
            public const string @RightBracket = "']'";
            /// <summary>
            /// '.'
            /// </summary>
            public const string @Dot = "'.'";
            /// <summary>
            /// '++'
            /// </summary>
            public const string @PlusPlus = "'++'";
            /// <summary>
            /// '--'
            /// </summary>
            public const string @DashDash = "'--'";
            /// <summary>
            /// 'void'
            /// </summary>
            public const string @void = "'void'";
            /// <summary>
            /// ','
            /// </summary>
            public const string @Comma = "','";
            /// <summary>
            /// '+'
            /// </summary>
            public const string @Plus = "'+'";
            /// <summary>
            /// '-'
            /// </summary>
            public const string @Dash = "'-'";
            /// <summary>
            /// '!'
            /// </summary>
            public const string @Bang = "'!'";
            /// <summary>
            /// '~'
            /// </summary>
            public const string @Tilde = "'~'";
            /// <summary>
            /// '*'
            /// </summary>
            public const string @Asterisk = "'*'";
            /// <summary>
            /// '/'
            /// </summary>
            public const string @Slash = "'/'";
            /// <summary>
            /// '%'
            /// </summary>
            public const string @Percent = "'%'";
            /// <summary>
            /// '<<'
            /// </summary>
            public const string @LeftAngleLeftAngle = "'<<'";
            /// <summary>
            /// '>>'
            /// </summary>
            public const string @RightAngleRightAngle = "'>>'";
            /// <summary>
            /// '<'
            /// </summary>
            public const string @LeftAngle = "'<'";
            /// <summary>
            /// '>'
            /// </summary>
            public const string @RightAngle = "'>'";
            /// <summary>
            /// '<='
            /// </summary>
            public const string @LeftAngleEqual = "'<='";
            /// <summary>
            /// '>='
            /// </summary>
            public const string @RightAngleEqual = "'>='";
            /// <summary>
            /// '=='
            /// </summary>
            public const string @EqualEqual = "'=='";
            /// <summary>
            /// '!='
            /// </summary>
            public const string @BangEqual = "'!='";
            /// <summary>
            /// '&'
            /// </summary>
            public const string @And = "'&'";
            /// <summary>
            /// '^'
            /// </summary>
            public const string @Caret = "'^'";
            /// <summary>
            /// '|'
            /// </summary>
            public const string @Pipe = "'|'";
            /// <summary>
            /// '&&'
            /// </summary>
            public const string @AndAnd = "'&&'";
            /// <summary>
            /// '^^'
            /// </summary>
            public const string @CaretCaret = "'^^'";
            /// <summary>
            /// '||'
            /// </summary>
            public const string @PipePipe = "'||'";
            /// <summary>
            /// '?'
            /// </summary>
            public const string @Question = "'?'";
            /// <summary>
            /// ':'
            /// </summary>
            public const string @Colon = "':'";
            /// <summary>
            /// '='
            /// </summary>
            public const string @Equal = "'='";
            /// <summary>
            /// '*='
            /// </summary>
            public const string @AsteriskEqual = "'*='";
            /// <summary>
            /// '/='
            /// </summary>
            public const string @SlashEqual = "'/='";
            /// <summary>
            /// '%='
            /// </summary>
            public const string @PercentEqual = "'%='";
            /// <summary>
            /// '+='
            /// </summary>
            public const string @PlusEqual = "'+='";
            /// <summary>
            /// '-='
            /// </summary>
            public const string @DashEqual = "'-='";
            /// <summary>
            /// '<<='
            /// </summary>
            public const string @LeftAngleLeftAngleEqual = "'<<='";
            /// <summary>
            /// '>>='
            /// </summary>
            public const string @RightAngleRightAngleEqual = "'>>='";
            /// <summary>
            /// '&='
            /// </summary>
            public const string @AndEqual = "'&='";
            /// <summary>
            /// '^='
            /// </summary>
            public const string @CaretEqual = "'^='";
            /// <summary>
            /// '|='
            /// </summary>
            public const string @PipeEqual = "'|='";
            /// <summary>
            /// ';'
            /// </summary>
            public const string @Semicolon = "';'";
            /// <summary>
            /// 'precision'
            /// </summary>
            public const string @precision = "'precision'";
            /// <summary>
            /// '{'
            /// </summary>
            public const string @LeftBrace = "'{'";
            /// <summary>
            /// '}'
            /// </summary>
            public const string @RightBrace = "'}'";
            /// <summary>
            /// 'invariant'
            /// </summary>
            public const string @invariant = "'invariant'";
            /// <summary>
            /// 'smooth'
            /// </summary>
            public const string @smooth = "'smooth'";
            /// <summary>
            /// 'flat'
            /// </summary>
            public const string @flat = "'flat'";
            /// <summary>
            /// 'noperspective'
            /// </summary>
            public const string @noperspective = "'noperspective'";
            /// <summary>
            /// 'layout'
            /// </summary>
            public const string @layout = "'layout'";
            /// <summary>
            /// 'precise'
            /// </summary>
            public const string @precise = "'precise'";
            /// <summary>
            /// 'const'
            /// </summary>
            public const string @const = "'const'";
            /// <summary>
            /// 'inout'
            /// </summary>
            public const string @inout = "'inout'";
            /// <summary>
            /// 'in'
            /// </summary>
            public const string @in = "'in'";
            /// <summary>
            /// 'out'
            /// </summary>
            public const string @out = "'out'";
            /// <summary>
            /// 'centroid'
            /// </summary>
            public const string @centroid = "'centroid'";
            /// <summary>
            /// 'patch'
            /// </summary>
            public const string @patch = "'patch'";
            /// <summary>
            /// 'sample'
            /// </summary>
            public const string @sample = "'sample'";
            /// <summary>
            /// 'uniform'
            /// </summary>
            public const string @uniform = "'uniform'";
            /// <summary>
            /// 'buffer'
            /// </summary>
            public const string @buffer = "'buffer'";
            /// <summary>
            /// 'shared'
            /// </summary>
            public const string @shared = "'shared'";
            /// <summary>
            /// 'coherent'
            /// </summary>
            public const string @coherent = "'coherent'";
            /// <summary>
            /// 'volatile'
            /// </summary>
            public const string @volatile = "'volatile'";
            /// <summary>
            /// 'restrict'
            /// </summary>
            public const string @restrict = "'restrict'";
            /// <summary>
            /// 'readonly'
            /// </summary>
            public const string @readonly = "'readonly'";
            /// <summary>
            /// 'writeonly'
            /// </summary>
            public const string @writeonly = "'writeonly'";
            /// <summary>
            /// 'subroutine'
            /// </summary>
            public const string @subroutine = "'subroutine'";
            /// <summary>
            /// 'userDefinedType'
            /// </summary>
            public const string @userDefinedType = "'userDefinedType'";
            /// <summary>
            /// 'float'
            /// </summary>
            public const string @float = "'float'";
            /// <summary>
            /// 'double'
            /// </summary>
            public const string @double = "'double'";
            /// <summary>
            /// 'int'
            /// </summary>
            public const string @int = "'int'";
            /// <summary>
            /// 'uint'
            /// </summary>
            public const string @uint = "'uint'";
            /// <summary>
            /// 'bool'
            /// </summary>
            public const string @bool = "'bool'";
            /// <summary>
            /// 'vec2'
            /// </summary>
            public const string @vec2 = "'vec2'";
            /// <summary>
            /// 'vec3'
            /// </summary>
            public const string @vec3 = "'vec3'";
            /// <summary>
            /// 'vec4'
            /// </summary>
            public const string @vec4 = "'vec4'";
            /// <summary>
            /// 'dvec2'
            /// </summary>
            public const string @dvec2 = "'dvec2'";
            /// <summary>
            /// 'dvec3'
            /// </summary>
            public const string @dvec3 = "'dvec3'";
            /// <summary>
            /// 'dvec4'
            /// </summary>
            public const string @dvec4 = "'dvec4'";
            /// <summary>
            /// 'bvec2'
            /// </summary>
            public const string @bvec2 = "'bvec2'";
            /// <summary>
            /// 'bvec3'
            /// </summary>
            public const string @bvec3 = "'bvec3'";
            /// <summary>
            /// 'bvec4'
            /// </summary>
            public const string @bvec4 = "'bvec4'";
            /// <summary>
            /// 'ivec2'
            /// </summary>
            public const string @ivec2 = "'ivec2'";
            /// <summary>
            /// 'ivec3'
            /// </summary>
            public const string @ivec3 = "'ivec3'";
            /// <summary>
            /// 'ivec4'
            /// </summary>
            public const string @ivec4 = "'ivec4'";
            /// <summary>
            /// 'uvec2'
            /// </summary>
            public const string @uvec2 = "'uvec2'";
            /// <summary>
            /// 'uvec3'
            /// </summary>
            public const string @uvec3 = "'uvec3'";
            /// <summary>
            /// 'uvec4'
            /// </summary>
            public const string @uvec4 = "'uvec4'";
            /// <summary>
            /// 'mat2'
            /// </summary>
            public const string @mat2 = "'mat2'";
            /// <summary>
            /// 'mat3'
            /// </summary>
            public const string @mat3 = "'mat3'";
            /// <summary>
            /// 'mat4'
            /// </summary>
            public const string @mat4 = "'mat4'";
            /// <summary>
            /// 'mat2x2'
            /// </summary>
            public const string @mat2x2 = "'mat2x2'";
            /// <summary>
            /// 'mat2x3'
            /// </summary>
            public const string @mat2x3 = "'mat2x3'";
            /// <summary>
            /// 'mat2x4'
            /// </summary>
            public const string @mat2x4 = "'mat2x4'";
            /// <summary>
            /// 'mat3x2'
            /// </summary>
            public const string @mat3x2 = "'mat3x2'";
            /// <summary>
            /// 'mat3x3'
            /// </summary>
            public const string @mat3x3 = "'mat3x3'";
            /// <summary>
            /// 'mat3x4'
            /// </summary>
            public const string @mat3x4 = "'mat3x4'";
            /// <summary>
            /// 'mat4x2'
            /// </summary>
            public const string @mat4x2 = "'mat4x2'";
            /// <summary>
            /// 'mat4x3'
            /// </summary>
            public const string @mat4x3 = "'mat4x3'";
            /// <summary>
            /// 'mat4x4'
            /// </summary>
            public const string @mat4x4 = "'mat4x4'";
            /// <summary>
            /// 'dmat2'
            /// </summary>
            public const string @dmat2 = "'dmat2'";
            /// <summary>
            /// 'dmat3'
            /// </summary>
            public const string @dmat3 = "'dmat3'";
            /// <summary>
            /// 'dmat4'
            /// </summary>
            public const string @dmat4 = "'dmat4'";
            /// <summary>
            /// 'dmat2x2'
            /// </summary>
            public const string @dmat2x2 = "'dmat2x2'";
            /// <summary>
            /// 'dmat2x3'
            /// </summary>
            public const string @dmat2x3 = "'dmat2x3'";
            /// <summary>
            /// 'dmat2x4'
            /// </summary>
            public const string @dmat2x4 = "'dmat2x4'";
            /// <summary>
            /// 'dmat3x2'
            /// </summary>
            public const string @dmat3x2 = "'dmat3x2'";
            /// <summary>
            /// 'dmat3x3'
            /// </summary>
            public const string @dmat3x3 = "'dmat3x3'";
            /// <summary>
            /// 'dmat3x4'
            /// </summary>
            public const string @dmat3x4 = "'dmat3x4'";
            /// <summary>
            /// 'dmat4x2'
            /// </summary>
            public const string @dmat4x2 = "'dmat4x2'";
            /// <summary>
            /// 'dmat4x3'
            /// </summary>
            public const string @dmat4x3 = "'dmat4x3'";
            /// <summary>
            /// 'dmat4x4'
            /// </summary>
            public const string @dmat4x4 = "'dmat4x4'";
            /// <summary>
            /// 'atomic_uint'
            /// </summary>
            public const string @atomic_uint = "'atomic_uint'";
            /// <summary>
            /// 'sampler1D'
            /// </summary>
            public const string @sampler1D = "'sampler1D'";
            /// <summary>
            /// 'sampler2D'
            /// </summary>
            public const string @sampler2D = "'sampler2D'";
            /// <summary>
            /// 'sampler3D'
            /// </summary>
            public const string @sampler3D = "'sampler3D'";
            /// <summary>
            /// 'samplerCube'
            /// </summary>
            public const string @samplerCube = "'samplerCube'";
            /// <summary>
            /// 'sampler1DShadow'
            /// </summary>
            public const string @sampler1DShadow = "'sampler1DShadow'";
            /// <summary>
            /// 'sampler2DShadow'
            /// </summary>
            public const string @sampler2DShadow = "'sampler2DShadow'";
            /// <summary>
            /// 'samplerCubeShadow'
            /// </summary>
            public const string @samplerCubeShadow = "'samplerCubeShadow'";
            /// <summary>
            /// 'sampler1DArray'
            /// </summary>
            public const string @sampler1DArray = "'sampler1DArray'";
            /// <summary>
            /// 'sampler2DArray'
            /// </summary>
            public const string @sampler2DArray = "'sampler2DArray'";
            /// <summary>
            /// 'sampler1DArrayShadow'
            /// </summary>
            public const string @sampler1DArrayShadow = "'sampler1DArrayShadow'";
            /// <summary>
            /// 'sampler2DArrayShadow'
            /// </summary>
            public const string @sampler2DArrayShadow = "'sampler2DArrayShadow'";
            /// <summary>
            /// 'samplerCubeArray'
            /// </summary>
            public const string @samplerCubeArray = "'samplerCubeArray'";
            /// <summary>
            /// 'samplerCubeArrayShadow'
            /// </summary>
            public const string @samplerCubeArrayShadow = "'samplerCubeArrayShadow'";
            /// <summary>
            /// 'isampler1D'
            /// </summary>
            public const string @isampler1D = "'isampler1D'";
            /// <summary>
            /// 'isampler2D'
            /// </summary>
            public const string @isampler2D = "'isampler2D'";
            /// <summary>
            /// 'isampler3D'
            /// </summary>
            public const string @isampler3D = "'isampler3D'";
            /// <summary>
            /// 'isamplerCube'
            /// </summary>
            public const string @isamplerCube = "'isamplerCube'";
            /// <summary>
            /// 'isampler1DArray'
            /// </summary>
            public const string @isampler1DArray = "'isampler1DArray'";
            /// <summary>
            /// 'isampler2DArray'
            /// </summary>
            public const string @isampler2DArray = "'isampler2DArray'";
            /// <summary>
            /// 'isamplerCubeArray'
            /// </summary>
            public const string @isamplerCubeArray = "'isamplerCubeArray'";
            /// <summary>
            /// 'usampler1D'
            /// </summary>
            public const string @usampler1D = "'usampler1D'";
            /// <summary>
            /// 'usampler2D'
            /// </summary>
            public const string @usampler2D = "'usampler2D'";
            /// <summary>
            /// 'usampler3D'
            /// </summary>
            public const string @usampler3D = "'usampler3D'";
            /// <summary>
            /// 'usamplerCube'
            /// </summary>
            public const string @usamplerCube = "'usamplerCube'";
            /// <summary>
            /// 'usampler1DArray'
            /// </summary>
            public const string @usampler1DArray = "'usampler1DArray'";
            /// <summary>
            /// 'usampler2DArray'
            /// </summary>
            public const string @usampler2DArray = "'usampler2DArray'";
            /// <summary>
            /// 'usamplerCubeArray'
            /// </summary>
            public const string @usamplerCubeArray = "'usamplerCubeArray'";
            /// <summary>
            /// 'sampler2DRect'
            /// </summary>
            public const string @sampler2DRect = "'sampler2DRect'";
            /// <summary>
            /// 'sampler2DRectShadow'
            /// </summary>
            public const string @sampler2DRectShadow = "'sampler2DRectShadow'";
            /// <summary>
            /// 'isampler2DRect'
            /// </summary>
            public const string @isampler2DRect = "'isampler2DRect'";
            /// <summary>
            /// 'usampler2DRect'
            /// </summary>
            public const string @usampler2DRect = "'usampler2DRect'";
            /// <summary>
            /// 'samplerBuffer'
            /// </summary>
            public const string @samplerBuffer = "'samplerBuffer'";
            /// <summary>
            /// 'isamplerBuffer'
            /// </summary>
            public const string @isamplerBuffer = "'isamplerBuffer'";
            /// <summary>
            /// 'usamplerBuffer'
            /// </summary>
            public const string @usamplerBuffer = "'usamplerBuffer'";
            /// <summary>
            /// 'sampler2DMS'
            /// </summary>
            public const string @sampler2DMS = "'sampler2DMS'";
            /// <summary>
            /// 'isampler2DMS'
            /// </summary>
            public const string @isampler2DMS = "'isampler2DMS'";
            /// <summary>
            /// 'usampler2DMS'
            /// </summary>
            public const string @usampler2DMS = "'usampler2DMS'";
            /// <summary>
            /// 'sampler2DMSArray'
            /// </summary>
            public const string @sampler2DMSArray = "'sampler2DMSArray'";
            /// <summary>
            /// 'isampler2DMSArray'
            /// </summary>
            public const string @isampler2DMSArray = "'isampler2DMSArray'";
            /// <summary>
            /// 'usampler2DMSArray'
            /// </summary>
            public const string @usampler2DMSArray = "'usampler2DMSArray'";
            /// <summary>
            /// 'image1D'
            /// </summary>
            public const string @image1D = "'image1D'";
            /// <summary>
            /// 'iimage1D'
            /// </summary>
            public const string @iimage1D = "'iimage1D'";
            /// <summary>
            /// 'uimage1D'
            /// </summary>
            public const string @uimage1D = "'uimage1D'";
            /// <summary>
            /// 'image2D'
            /// </summary>
            public const string @image2D = "'image2D'";
            /// <summary>
            /// 'iimage2D'
            /// </summary>
            public const string @iimage2D = "'iimage2D'";
            /// <summary>
            /// 'uimage2D'
            /// </summary>
            public const string @uimage2D = "'uimage2D'";
            /// <summary>
            /// 'image3D'
            /// </summary>
            public const string @image3D = "'image3D'";
            /// <summary>
            /// 'iimage3D'
            /// </summary>
            public const string @iimage3D = "'iimage3D'";
            /// <summary>
            /// 'uimage3D'
            /// </summary>
            public const string @uimage3D = "'uimage3D'";
            /// <summary>
            /// 'image2DRect'
            /// </summary>
            public const string @image2DRect = "'image2DRect'";
            /// <summary>
            /// 'iimage2DRect'
            /// </summary>
            public const string @iimage2DRect = "'iimage2DRect'";
            /// <summary>
            /// 'uimage2DRect'
            /// </summary>
            public const string @uimage2DRect = "'uimage2DRect'";
            /// <summary>
            /// 'imageCube'
            /// </summary>
            public const string @imageCube = "'imageCube'";
            /// <summary>
            /// 'iimageCube'
            /// </summary>
            public const string @iimageCube = "'iimageCube'";
            /// <summary>
            /// 'uimageCube'
            /// </summary>
            public const string @uimageCube = "'uimageCube'";
            /// <summary>
            /// 'imageBuffer'
            /// </summary>
            public const string @imageBuffer = "'imageBuffer'";
            /// <summary>
            /// 'iimageBuffer'
            /// </summary>
            public const string @iimageBuffer = "'iimageBuffer'";
            /// <summary>
            /// 'uimageBuffer'
            /// </summary>
            public const string @uimageBuffer = "'uimageBuffer'";
            /// <summary>
            /// 'image1DArray'
            /// </summary>
            public const string @image1DArray = "'image1DArray'";
            /// <summary>
            /// 'iimage1DArray'
            /// </summary>
            public const string @iimage1DArray = "'iimage1DArray'";
            /// <summary>
            /// 'uimage1DArray'
            /// </summary>
            public const string @uimage1DArray = "'uimage1DArray'";
            /// <summary>
            /// 'image2DArray'
            /// </summary>
            public const string @image2DArray = "'image2DArray'";
            /// <summary>
            /// 'iimage2DArray'
            /// </summary>
            public const string @iimage2DArray = "'iimage2DArray'";
            /// <summary>
            /// 'uimage2DArray'
            /// </summary>
            public const string @uimage2DArray = "'uimage2DArray'";
            /// <summary>
            /// 'imageCubeArray'
            /// </summary>
            public const string @imageCubeArray = "'imageCubeArray'";
            /// <summary>
            /// 'iimageCubeArray'
            /// </summary>
            public const string @iimageCubeArray = "'iimageCubeArray'";
            /// <summary>
            /// 'uimageCubeArray'
            /// </summary>
            public const string @uimageCubeArray = "'uimageCubeArray'";
            /// <summary>
            /// 'image2DMS'
            /// </summary>
            public const string @image2DMS = "'image2DMS'";
            /// <summary>
            /// 'iimage2DMS'
            /// </summary>
            public const string @iimage2DMS = "'iimage2DMS'";
            /// <summary>
            /// 'uimage2DMS'
            /// </summary>
            public const string @uimage2DMS = "'uimage2DMS'";
            /// <summary>
            /// 'image2DMSArray'
            /// </summary>
            public const string @image2DMSArray = "'image2DMSArray'";
            /// <summary>
            /// 'iimage2DMSArray'
            /// </summary>
            public const string @iimage2DMSArray = "'iimage2DMSArray'";
            /// <summary>
            /// 'uimage2DMSArray'
            /// </summary>
            public const string @uimage2DMSArray = "'uimage2DMSArray'";
            /// <summary>
            /// 'high_precision'
            /// </summary>
            public const string @high_precision = "'high_precision'";
            /// <summary>
            /// 'medium_precision'
            /// </summary>
            public const string @medium_precision = "'medium_precision'";
            /// <summary>
            /// 'low_precision'
            /// </summary>
            public const string @low_precision = "'low_precision'";
            /// <summary>
            /// 'struct'
            /// </summary>
            public const string @struct = "'struct'";
            /// <summary>
            /// 'if'
            /// </summary>
            public const string @if = "'if'";
            /// <summary>
            /// 'else'
            /// </summary>
            public const string @else = "'else'";
            /// <summary>
            /// 'switch'
            /// </summary>
            public const string @switch = "'switch'";
            /// <summary>
            /// 'case'
            /// </summary>
            public const string @case = "'case'";
            /// <summary>
            /// 'default'
            /// </summary>
            public const string @default = "'default'";
            /// <summary>
            /// 'while'
            /// </summary>
            public const string @while = "'while'";
            /// <summary>
            /// 'do'
            /// </summary>
            public const string @do = "'do'";
            /// <summary>
            /// 'for'
            /// </summary>
            public const string @for = "'for'";
            /// <summary>
            /// 'continue'
            /// </summary>
            public const string @continue = "'continue'";
            /// <summary>
            /// 'break'
            /// </summary>
            public const string @break = "'break'";
            /// <summary>
            /// 'return'
            /// </summary>
            public const string @return = "'return'";
            /// <summary>
            /// 'discard'
            /// </summary>
            public const string @discard = "'discard'";

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
            /// translation_unit
            /// </summary>
            public const string translation_unit = "translation_unit";
            /// <summary>
            /// external_declaration
            /// </summary>
            public const string external_declaration = "external_declaration";
            /// <summary>
            /// function_definition
            /// </summary>
            public const string function_definition = "function_definition";
            /// <summary>
            /// variable_identifier
            /// </summary>
            public const string variable_identifier = "variable_identifier";
            /// <summary>
            /// primary_expression
            /// </summary>
            public const string primary_expression = "primary_expression";
            /// <summary>
            /// BOOLCONSTANT
            /// </summary>
            public const string BOOLCONSTANT = "BOOLCONSTANT";
            /// <summary>
            /// postfix_expression
            /// </summary>
            public const string postfix_expression = "postfix_expression";
            /// <summary>
            /// FIELD_SELECTION
            /// </summary>
            public const string FIELD_SELECTION = "FIELD_SELECTION";
            /// <summary>
            /// integer_expression
            /// </summary>
            public const string integer_expression = "integer_expression";
            /// <summary>
            /// function_call
            /// </summary>
            public const string function_call = "function_call";
            /// <summary>
            /// function_call_or_method
            /// </summary>
            public const string function_call_or_method = "function_call_or_method";
            /// <summary>
            /// function_call_generic
            /// </summary>
            public const string function_call_generic = "function_call_generic";
            /// <summary>
            /// function_call_header_no_parameters
            /// </summary>
            public const string function_call_header_no_parameters = "function_call_header_no_parameters";
            /// <summary>
            /// function_call_header_with_parameters
            /// </summary>
            public const string function_call_header_with_parameters = "function_call_header_with_parameters";
            /// <summary>
            /// function_call_header
            /// </summary>
            public const string function_call_header = "function_call_header";
            /// <summary>
            /// function_identifier
            /// </summary>
            public const string function_identifier = "function_identifier";
            /// <summary>
            /// unary_expression
            /// </summary>
            public const string unary_expression = "unary_expression";
            /// <summary>
            /// unary_operator
            /// </summary>
            public const string unary_operator = "unary_operator";
            /// <summary>
            /// multiplicative_expression
            /// </summary>
            public const string multiplicative_expression = "multiplicative_expression";
            /// <summary>
            /// additive_expression
            /// </summary>
            public const string additive_expression = "additive_expression";
            /// <summary>
            /// shift_expression
            /// </summary>
            public const string shift_expression = "shift_expression";
            /// <summary>
            /// relational_expression
            /// </summary>
            public const string relational_expression = "relational_expression";
            /// <summary>
            /// equality_expression
            /// </summary>
            public const string equality_expression = "equality_expression";
            /// <summary>
            /// and_expression
            /// </summary>
            public const string and_expression = "and_expression";
            /// <summary>
            /// exclusive_or_expression
            /// </summary>
            public const string exclusive_or_expression = "exclusive_or_expression";
            /// <summary>
            /// inclusive_or_expression
            /// </summary>
            public const string inclusive_or_expression = "inclusive_or_expression";
            /// <summary>
            /// logical_and_expression
            /// </summary>
            public const string logical_and_expression = "logical_and_expression";
            /// <summary>
            /// logical_xor_expression
            /// </summary>
            public const string logical_xor_expression = "logical_xor_expression";
            /// <summary>
            /// logical_or_expression
            /// </summary>
            public const string logical_or_expression = "logical_or_expression";
            /// <summary>
            /// conditional_expression
            /// </summary>
            public const string conditional_expression = "conditional_expression";
            /// <summary>
            /// assignment_expression
            /// </summary>
            public const string assignment_expression = "assignment_expression";
            /// <summary>
            /// assignment_operator
            /// </summary>
            public const string assignment_operator = "assignment_operator";
            /// <summary>
            /// expression
            /// </summary>
            public const string expression = "expression";
            /// <summary>
            /// constant_expression
            /// </summary>
            public const string constant_expression = "constant_expression";
            /// <summary>
            /// declaration
            /// </summary>
            public const string declaration = "declaration";
            /// <summary>
            /// identifier_list
            /// </summary>
            public const string identifier_list = "identifier_list";
            /// <summary>
            /// function_prototype
            /// </summary>
            public const string function_prototype = "function_prototype";
            /// <summary>
            /// function_declarator
            /// </summary>
            public const string function_declarator = "function_declarator";
            /// <summary>
            /// function_header_with_parameters
            /// </summary>
            public const string function_header_with_parameters = "function_header_with_parameters";
            /// <summary>
            /// function_header
            /// </summary>
            public const string function_header = "function_header";
            /// <summary>
            /// parameter_declarator
            /// </summary>
            public const string parameter_declarator = "parameter_declarator";
            /// <summary>
            /// parameter_declaration
            /// </summary>
            public const string parameter_declaration = "parameter_declaration";
            /// <summary>
            /// parameter_type_specifier
            /// </summary>
            public const string parameter_type_specifier = "parameter_type_specifier";
            /// <summary>
            /// init_declarator_list
            /// </summary>
            public const string init_declarator_list = "init_declarator_list";
            /// <summary>
            /// single_declaration
            /// </summary>
            public const string single_declaration = "single_declaration";
            /// <summary>
            /// fully_specified_type
            /// </summary>
            public const string fully_specified_type = "fully_specified_type";
            /// <summary>
            /// invariant_qualifier
            /// </summary>
            public const string invariant_qualifier = "invariant_qualifier";
            /// <summary>
            /// interpolation_qualifier
            /// </summary>
            public const string interpolation_qualifier = "interpolation_qualifier";
            /// <summary>
            /// layout_qualifier
            /// </summary>
            public const string layout_qualifier = "layout_qualifier";
            /// <summary>
            /// layout_qualifier_id_list
            /// </summary>
            public const string layout_qualifier_id_list = "layout_qualifier_id_list";
            /// <summary>
            /// layout_qualifier_id
            /// </summary>
            public const string layout_qualifier_id = "layout_qualifier_id";
            /// <summary>
            /// precise_qualifier
            /// </summary>
            public const string precise_qualifier = "precise_qualifier";
            /// <summary>
            /// type_qualifier
            /// </summary>
            public const string type_qualifier = "type_qualifier";
            /// <summary>
            /// single_type_qualifier
            /// </summary>
            public const string single_type_qualifier = "single_type_qualifier";
            /// <summary>
            /// storage_qualifier
            /// </summary>
            public const string storage_qualifier = "storage_qualifier";
            /// <summary>
            /// type_name_list
            /// </summary>
            public const string type_name_list = "type_name_list";
            /// <summary>
            /// type_specifier
            /// </summary>
            public const string type_specifier = "type_specifier";
            /// <summary>
            /// array_specifier
            /// </summary>
            public const string array_specifier = "array_specifier";
            /// <summary>
            /// type_specifier_nonarray
            /// </summary>
            public const string type_specifier_nonarray = "type_specifier_nonarray";
            /// <summary>
            /// precision_qualifier
            /// </summary>
            public const string precision_qualifier = "precision_qualifier";
            /// <summary>
            /// struct_specifier
            /// </summary>
            public const string struct_specifier = "struct_specifier";
            /// <summary>
            /// type_name
            /// </summary>
            public const string type_name = "type_name";
            /// <summary>
            /// struct_declaration_list
            /// </summary>
            public const string struct_declaration_list = "struct_declaration_list";
            /// <summary>
            /// struct_declaration
            /// </summary>
            public const string struct_declaration = "struct_declaration";
            /// <summary>
            /// struct_declarator_list
            /// </summary>
            public const string struct_declarator_list = "struct_declarator_list";
            /// <summary>
            /// struct_declarator
            /// </summary>
            public const string struct_declarator = "struct_declarator";
            /// <summary>
            /// initializer
            /// </summary>
            public const string initializer = "initializer";
            /// <summary>
            /// initializer_list
            /// </summary>
            public const string initializer_list = "initializer_list";
            /// <summary>
            /// declaration_statement
            /// </summary>
            public const string declaration_statement = "declaration_statement";
            /// <summary>
            /// statement
            /// </summary>
            public const string statement = "statement";
            /// <summary>
            /// simple_statement
            /// </summary>
            public const string simple_statement = "simple_statement";
            /// <summary>
            /// compound_statement
            /// </summary>
            public const string compound_statement = "compound_statement";
            /// <summary>
            /// statement_no_new_scope
            /// </summary>
            public const string statement_no_new_scope = "statement_no_new_scope";
            /// <summary>
            /// compound_statement_no_new_scope
            /// </summary>
            public const string compound_statement_no_new_scope = "compound_statement_no_new_scope";
            /// <summary>
            /// statement_list
            /// </summary>
            public const string statement_list = "statement_list";
            /// <summary>
            /// expression_statement
            /// </summary>
            public const string expression_statement = "expression_statement";
            /// <summary>
            /// selection_statement
            /// </summary>
            public const string selection_statement = "selection_statement";
            /// <summary>
            /// selection_rest_statement
            /// </summary>
            public const string selection_rest_statement = "selection_rest_statement";
            /// <summary>
            /// condition
            /// </summary>
            public const string condition = "condition";
            /// <summary>
            /// switch_statement
            /// </summary>
            public const string switch_statement = "switch_statement";
            /// <summary>
            /// switch_statement_list
            /// </summary>
            public const string switch_statement_list = "switch_statement_list";
            /// <summary>
            /// case_label
            /// </summary>
            public const string case_label = "case_label";
            /// <summary>
            /// iteration_statement
            /// </summary>
            public const string iteration_statement = "iteration_statement";
            /// <summary>
            /// for_init_statement
            /// </summary>
            public const string for_init_statement = "for_init_statement";
            /// <summary>
            /// conditionopt
            /// </summary>
            public const string conditionopt = "conditionopt";
            /// <summary>
            /// for_rest_statement
            /// </summary>
            public const string for_rest_statement = "for_rest_statement";
            /// <summary>
            /// jump_statement
            /// </summary>
            public const string jump_statement = "jump_statement";

        }
    }
}
