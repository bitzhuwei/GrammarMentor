using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => ('A'/*'\u0041'(65)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/)
            || (currentChar == '_'/*'\u005F'(95)*/),
            context => {
                BeginToken(context, EType.@identifier);
                ExtendToken(context);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == '+'/*'\u002B'(43)*/,
            context => {
                BeginToken(context, EType.@number, EType.@PlusPlus, EType.@Plus, EType.@PlusEqual);
                ExtendToken(context);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => {
                BeginToken(context, EType.@number, EType.@DashDash, EType.@Dash, EType.@DashEqual);
                ExtendToken(context);
                return lexicalState3;
            }),
            new LexicalRule(
            currentChar => currentChar == '('/*'\u0028'(40)*/,
            context => {
                BeginToken(context, EType.@LeftParenthesis);
                ExtendToken(context);
                return lexicalState4;
            }),
            new LexicalRule(
            currentChar => currentChar == ')'/*'\u0029'(41)*/,
            context => {
                BeginToken(context, EType.@RightParenthesis);
                ExtendToken(context);
                return lexicalState5;
            }),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => {
                BeginToken(context, EType.@true);
                return lexicalState6;
            }),
            new LexicalRule(
            currentChar => currentChar == 'f'/*'\u0066'(102)*/,
            context => {
                BeginToken(context, EType.@false, EType.@flat, EType.@float, EType.@for);
                return lexicalState7;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                BeginToken(context, EType.@LeftBracket);
                ExtendToken(context);
                return lexicalState8;
            }),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                BeginToken(context, EType.@RightBracket);
                ExtendToken(context);
                return lexicalState9;
            }),
            new LexicalRule(
            currentChar => currentChar == '.'/*'\u002E'(46)*/,
            context => {
                BeginToken(context, EType.@Dot);
                ExtendToken(context);
                return lexicalState10;
            }),
            new LexicalRule(
            currentChar => currentChar == 'v'/*'\u0076'(118)*/,
            context => {
                BeginToken(context, EType.@void, EType.@volatile, EType.@vec2, EType.@vec3, EType.@vec4);
                return lexicalState11;
            }),
            new LexicalRule(
            currentChar => currentChar == ','/*'\u002C'(44)*/,
            context => {
                BeginToken(context, EType.@Comma);
                ExtendToken(context);
                return lexicalState12;
            }),
            new LexicalRule(
            currentChar => currentChar == '!'/*'\u0021'(33)*/,
            context => {
                BeginToken(context, EType.@Bang, EType.@BangEqual);
                ExtendToken(context);
                return lexicalState13;
            }),
            new LexicalRule(
            currentChar => currentChar == '~'/*'\u007E'(126)*/,
            context => {
                BeginToken(context, EType.@Tilde);
                ExtendToken(context);
                return lexicalState14;
            }),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => {
                BeginToken(context, EType.@Asterisk, EType.@AsteriskEqual);
                ExtendToken(context);
                return lexicalState15;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@Slash, EType.@SlashEqual);
                ExtendToken(context);
                return lexicalState16;
            }),
            new LexicalRule(
            currentChar => currentChar == '%'/*'\u0025'(37)*/,
            context => {
                BeginToken(context, EType.@Percent, EType.@PercentEqual);
                ExtendToken(context);
                return lexicalState17;
            }),
            new LexicalRule(
            currentChar => currentChar == '<'/*'\u003C'(60)*/,
            context => {
                BeginToken(context, EType.@LeftAngleLeftAngle, EType.@LeftAngle, EType.@LeftAngleEqual, EType.@LeftAngleLeftAngleEqual);
                ExtendToken(context);
                return lexicalState18;
            }),
            new LexicalRule(
            currentChar => currentChar == '>'/*'\u003E'(62)*/,
            context => {
                BeginToken(context, EType.@RightAngleRightAngle, EType.@RightAngle, EType.@RightAngleEqual, EType.@RightAngleRightAngleEqual);
                ExtendToken(context);
                return lexicalState19;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                BeginToken(context, EType.@EqualEqual, EType.@Equal);
                ExtendToken(context);
                return lexicalState20;
            }),
            new LexicalRule(
            currentChar => currentChar == '&'/*'\u0026'(38)*/,
            context => {
                BeginToken(context, EType.@And, EType.@AndAnd, EType.@AndEqual);
                ExtendToken(context);
                return lexicalState21;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                BeginToken(context, EType.@Caret, EType.@CaretCaret, EType.@CaretEqual);
                ExtendToken(context);
                return lexicalState22;
            }),
            new LexicalRule(
            currentChar => currentChar == '|'/*'\u007C'(124)*/,
            context => {
                BeginToken(context, EType.@Pipe, EType.@PipePipe, EType.@PipeEqual);
                ExtendToken(context);
                return lexicalState23;
            }),
            new LexicalRule(
            currentChar => currentChar == '?'/*'\u003F'(63)*/,
            context => {
                BeginToken(context, EType.@Question);
                ExtendToken(context);
                return lexicalState24;
            }),
            new LexicalRule(
            currentChar => currentChar == ':'/*'\u003A'(58)*/,
            context => {
                BeginToken(context, EType.@Colon);
                ExtendToken(context);
                return lexicalState25;
            }),
            new LexicalRule(
            currentChar => currentChar == ';'/*'\u003B'(59)*/,
            context => {
                BeginToken(context, EType.@Semicolon);
                ExtendToken(context);
                return lexicalState26;
            }),
            new LexicalRule(
            currentChar => currentChar == 'p'/*'\u0070'(112)*/,
            context => {
                BeginToken(context, EType.@precision, EType.@precise, EType.@patch);
                return lexicalState27;
            }),
            new LexicalRule(
            currentChar => currentChar == '{'/*'\u007B'(123)*/,
            context => {
                BeginToken(context, EType.@LeftBrace);
                ExtendToken(context);
                return lexicalState28;
            }),
            new LexicalRule(
            currentChar => currentChar == '}'/*'\u007D'(125)*/,
            context => {
                BeginToken(context, EType.@RightBrace);
                ExtendToken(context);
                return lexicalState29;
            }),
            new LexicalRule(
            currentChar => currentChar == 'i'/*'\u0069'(105)*/,
            context => {
                BeginToken(context, EType.@invariant, EType.@inout, EType.@in, EType.@int, EType.@ivec2, EType.@ivec3, EType.@ivec4, EType.@isampler1D, EType.@isampler2D, EType.@isampler3D, EType.@isamplerCube, EType.@isampler1DArray, EType.@isampler2DArray, EType.@isamplerCubeArray, EType.@isampler2DRect, EType.@isamplerBuffer, EType.@isampler2DMS, EType.@isampler2DMSArray, EType.@image1D, EType.@iimage1D, EType.@image2D, EType.@iimage2D, EType.@image3D, EType.@iimage3D, EType.@image2DRect, EType.@iimage2DRect, EType.@imageCube, EType.@iimageCube, EType.@imageBuffer, EType.@iimageBuffer, EType.@image1DArray, EType.@iimage1DArray, EType.@image2DArray, EType.@iimage2DArray, EType.@imageCubeArray, EType.@iimageCubeArray, EType.@image2DMS, EType.@iimage2DMS, EType.@image2DMSArray, EType.@iimage2DMSArray, EType.@if);
                return lexicalState30;
            }),
            new LexicalRule(
            currentChar => currentChar == 's'/*'\u0073'(115)*/,
            context => {
                BeginToken(context, EType.@smooth, EType.@sample, EType.@shared, EType.@subroutine, EType.@sampler1D, EType.@sampler2D, EType.@sampler3D, EType.@samplerCube, EType.@sampler1DShadow, EType.@sampler2DShadow, EType.@samplerCubeShadow, EType.@sampler1DArray, EType.@sampler2DArray, EType.@sampler1DArrayShadow, EType.@sampler2DArrayShadow, EType.@samplerCubeArray, EType.@samplerCubeArrayShadow, EType.@sampler2DRect, EType.@sampler2DRectShadow, EType.@samplerBuffer, EType.@sampler2DMS, EType.@sampler2DMSArray, EType.@struct, EType.@switch);
                return lexicalState31;
            }),
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => {
                BeginToken(context, EType.@noperspective);
                return lexicalState32;
            }),
            new LexicalRule(
            currentChar => currentChar == 'l'/*'\u006C'(108)*/,
            context => {
                BeginToken(context, EType.@layout, EType.@low_precision);
                return lexicalState33;
            }),
            new LexicalRule(
            currentChar => currentChar == 'c'/*'\u0063'(99)*/,
            context => {
                BeginToken(context, EType.@const, EType.@centroid, EType.@coherent, EType.@case, EType.@continue);
                return lexicalState34;
            }),
            new LexicalRule(
            currentChar => currentChar == 'o'/*'\u006F'(111)*/,
            context => {
                BeginToken(context, EType.@out);
                return lexicalState35;
            }),
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => {
                BeginToken(context, EType.@uniform, EType.@userDefinedType, EType.@uint, EType.@uvec2, EType.@uvec3, EType.@uvec4, EType.@usampler1D, EType.@usampler2D, EType.@usampler3D, EType.@usamplerCube, EType.@usampler1DArray, EType.@usampler2DArray, EType.@usamplerCubeArray, EType.@usampler2DRect, EType.@usamplerBuffer, EType.@usampler2DMS, EType.@usampler2DMSArray, EType.@uimage1D, EType.@uimage2D, EType.@uimage3D, EType.@uimage2DRect, EType.@uimageCube, EType.@uimageBuffer, EType.@uimage1DArray, EType.@uimage2DArray, EType.@uimageCubeArray, EType.@uimage2DMS, EType.@uimage2DMSArray);
                return lexicalState36;
            }),
            new LexicalRule(
            currentChar => currentChar == 'b'/*'\u0062'(98)*/,
            context => {
                BeginToken(context, EType.@buffer, EType.@bool, EType.@bvec2, EType.@bvec3, EType.@bvec4, EType.@break);
                return lexicalState37;
            }),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => {
                BeginToken(context, EType.@restrict, EType.@readonly, EType.@return);
                return lexicalState38;
            }),
            new LexicalRule(
            currentChar => currentChar == 'w'/*'\u0077'(119)*/,
            context => {
                BeginToken(context, EType.@writeonly, EType.@while);
                return lexicalState39;
            }),
            new LexicalRule(
            currentChar => currentChar == 'd'/*'\u0064'(100)*/,
            context => {
                BeginToken(context, EType.@double, EType.@dvec2, EType.@dvec3, EType.@dvec4, EType.@dmat2, EType.@dmat3, EType.@dmat4, EType.@dmat2x2, EType.@dmat2x3, EType.@dmat2x4, EType.@dmat3x2, EType.@dmat3x3, EType.@dmat3x4, EType.@dmat4x2, EType.@dmat4x3, EType.@dmat4x4, EType.@default, EType.@do, EType.@discard);
                return lexicalState40;
            }),
            new LexicalRule(
            currentChar => currentChar == 'm'/*'\u006D'(109)*/,
            context => {
                BeginToken(context, EType.@mat2, EType.@mat3, EType.@mat4, EType.@mat2x2, EType.@mat2x3, EType.@mat2x4, EType.@mat3x2, EType.@mat3x3, EType.@mat3x4, EType.@mat4x2, EType.@mat4x3, EType.@mat4x4, EType.@medium_precision);
                return lexicalState41;
            }),
            new LexicalRule(
            currentChar => currentChar == 'a'/*'\u0061'(97)*/,
            context => {
                BeginToken(context, EType.@atomic_uint);
                return lexicalState42;
            }),
            new LexicalRule(
            currentChar => currentChar == 'h'/*'\u0068'(104)*/,
            context => {
                BeginToken(context, EType.@high_precision);
                return lexicalState43;
            }),
            new LexicalRule(
            currentChar => currentChar == 'e'/*'\u0065'(101)*/,
            context => {
                BeginToken(context, EType.@else);
                return lexicalState44;
            }),
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                BeginToken(context, EType.@number);
                ExtendToken(context);
                return lexicalState45;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                char c = context.CurrentChar;
                if (c == ' ' || c == '\r' || c == '\n' || c == '\t' || c == '\0') { return lexicalState0; }
                // default handler: unexpected char.
                context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(context.analyzingToken);
                context.checkpoint = context.Cursor + 1;
                context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index);
                context.analyzingToken.type = EType.Error;
                context.result.errorDict.Add(context.analyzingToken, new TokenErrorInfo(context.analyzingToken, $"Unexpected char {c}"));
                return lexicalState0;
            })

        );
    }
}

