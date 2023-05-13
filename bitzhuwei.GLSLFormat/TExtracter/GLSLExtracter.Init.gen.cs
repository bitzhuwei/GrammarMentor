using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.GLSLFormat {
    public partial class CompilerGLSL {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{ShaderModel}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<ShaderModel>>> shaderModelExtracterDict = new Dictionary<string, Action<Node, TContext<ShaderModel>>>();

        private static readonly Action<Node, TContext<ShaderModel>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeShaderModelExtracterDict() {
            var extracterDict = shaderModelExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, context) => {
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, context) => {
            // not needed.
            //});
            extracterDict.Add(EType.@identifier, VtHandler);
            extracterDict.Add(EType.@number, VtHandler);
            extracterDict.Add(EType.@LeftParenthesis, VtHandler);
            extracterDict.Add(EType.@RightParenthesis, VtHandler);
            extracterDict.Add(EType.@true, VtHandler);
            extracterDict.Add(EType.@false, VtHandler);
            extracterDict.Add(EType.@LeftBracket, VtHandler);
            extracterDict.Add(EType.@RightBracket, VtHandler);
            extracterDict.Add(EType.@Dot, VtHandler);
            extracterDict.Add(EType.@PlusPlus, VtHandler);
            extracterDict.Add(EType.@DashDash, VtHandler);
            extracterDict.Add(EType.@void, VtHandler);
            extracterDict.Add(EType.@Comma, VtHandler);
            extracterDict.Add(EType.@Plus, VtHandler);
            extracterDict.Add(EType.@Dash, VtHandler);
            extracterDict.Add(EType.@Bang, VtHandler);
            extracterDict.Add(EType.@Tilde, VtHandler);
            extracterDict.Add(EType.@Asterisk, VtHandler);
            extracterDict.Add(EType.@Slash, VtHandler);
            extracterDict.Add(EType.@Percent, VtHandler);
            extracterDict.Add(EType.@LeftAngleLeftAngle, VtHandler);
            extracterDict.Add(EType.@RightAngleRightAngle, VtHandler);
            extracterDict.Add(EType.@LeftAngle, VtHandler);
            extracterDict.Add(EType.@RightAngle, VtHandler);
            extracterDict.Add(EType.@LeftAngleEqual, VtHandler);
            extracterDict.Add(EType.@RightAngleEqual, VtHandler);
            extracterDict.Add(EType.@EqualEqual, VtHandler);
            extracterDict.Add(EType.@BangEqual, VtHandler);
            extracterDict.Add(EType.@And, VtHandler);
            extracterDict.Add(EType.@Caret, VtHandler);
            extracterDict.Add(EType.@Pipe, VtHandler);
            extracterDict.Add(EType.@AndAnd, VtHandler);
            extracterDict.Add(EType.@CaretCaret, VtHandler);
            extracterDict.Add(EType.@PipePipe, VtHandler);
            extracterDict.Add(EType.@Question, VtHandler);
            extracterDict.Add(EType.@Colon, VtHandler);
            extracterDict.Add(EType.@Equal, VtHandler);
            extracterDict.Add(EType.@AsteriskEqual, VtHandler);
            extracterDict.Add(EType.@SlashEqual, VtHandler);
            extracterDict.Add(EType.@PercentEqual, VtHandler);
            extracterDict.Add(EType.@PlusEqual, VtHandler);
            extracterDict.Add(EType.@DashEqual, VtHandler);
            extracterDict.Add(EType.@LeftAngleLeftAngleEqual, VtHandler);
            extracterDict.Add(EType.@RightAngleRightAngleEqual, VtHandler);
            extracterDict.Add(EType.@AndEqual, VtHandler);
            extracterDict.Add(EType.@CaretEqual, VtHandler);
            extracterDict.Add(EType.@PipeEqual, VtHandler);
            extracterDict.Add(EType.@Semicolon, VtHandler);
            extracterDict.Add(EType.@precision, VtHandler);
            extracterDict.Add(EType.@LeftBrace, VtHandler);
            extracterDict.Add(EType.@RightBrace, VtHandler);
            extracterDict.Add(EType.@invariant, VtHandler);
            extracterDict.Add(EType.@smooth, VtHandler);
            extracterDict.Add(EType.@flat, VtHandler);
            extracterDict.Add(EType.@noperspective, VtHandler);
            extracterDict.Add(EType.@layout, VtHandler);
            extracterDict.Add(EType.@precise, VtHandler);
            extracterDict.Add(EType.@const, VtHandler);
            extracterDict.Add(EType.@inout, VtHandler);
            extracterDict.Add(EType.@in, VtHandler);
            extracterDict.Add(EType.@out, VtHandler);
            extracterDict.Add(EType.@centroid, VtHandler);
            extracterDict.Add(EType.@patch, VtHandler);
            extracterDict.Add(EType.@sample, VtHandler);
            extracterDict.Add(EType.@uniform, VtHandler);
            extracterDict.Add(EType.@buffer, VtHandler);
            extracterDict.Add(EType.@shared, VtHandler);
            extracterDict.Add(EType.@coherent, VtHandler);
            extracterDict.Add(EType.@volatile, VtHandler);
            extracterDict.Add(EType.@restrict, VtHandler);
            extracterDict.Add(EType.@readonly, VtHandler);
            extracterDict.Add(EType.@writeonly, VtHandler);
            extracterDict.Add(EType.@subroutine, VtHandler);
            extracterDict.Add(EType.@userDefinedType, VtHandler);
            extracterDict.Add(EType.@float, VtHandler);
            extracterDict.Add(EType.@double, VtHandler);
            extracterDict.Add(EType.@int, VtHandler);
            extracterDict.Add(EType.@uint, VtHandler);
            extracterDict.Add(EType.@bool, VtHandler);
            extracterDict.Add(EType.@vec2, VtHandler);
            extracterDict.Add(EType.@vec3, VtHandler);
            extracterDict.Add(EType.@vec4, VtHandler);
            extracterDict.Add(EType.@dvec2, VtHandler);
            extracterDict.Add(EType.@dvec3, VtHandler);
            extracterDict.Add(EType.@dvec4, VtHandler);
            extracterDict.Add(EType.@bvec2, VtHandler);
            extracterDict.Add(EType.@bvec3, VtHandler);
            extracterDict.Add(EType.@bvec4, VtHandler);
            extracterDict.Add(EType.@ivec2, VtHandler);
            extracterDict.Add(EType.@ivec3, VtHandler);
            extracterDict.Add(EType.@ivec4, VtHandler);
            extracterDict.Add(EType.@uvec2, VtHandler);
            extracterDict.Add(EType.@uvec3, VtHandler);
            extracterDict.Add(EType.@uvec4, VtHandler);
            extracterDict.Add(EType.@mat2, VtHandler);
            extracterDict.Add(EType.@mat3, VtHandler);
            extracterDict.Add(EType.@mat4, VtHandler);
            extracterDict.Add(EType.@mat2x2, VtHandler);
            extracterDict.Add(EType.@mat2x3, VtHandler);
            extracterDict.Add(EType.@mat2x4, VtHandler);
            extracterDict.Add(EType.@mat3x2, VtHandler);
            extracterDict.Add(EType.@mat3x3, VtHandler);
            extracterDict.Add(EType.@mat3x4, VtHandler);
            extracterDict.Add(EType.@mat4x2, VtHandler);
            extracterDict.Add(EType.@mat4x3, VtHandler);
            extracterDict.Add(EType.@mat4x4, VtHandler);
            extracterDict.Add(EType.@dmat2, VtHandler);
            extracterDict.Add(EType.@dmat3, VtHandler);
            extracterDict.Add(EType.@dmat4, VtHandler);
            extracterDict.Add(EType.@dmat2x2, VtHandler);
            extracterDict.Add(EType.@dmat2x3, VtHandler);
            extracterDict.Add(EType.@dmat2x4, VtHandler);
            extracterDict.Add(EType.@dmat3x2, VtHandler);
            extracterDict.Add(EType.@dmat3x3, VtHandler);
            extracterDict.Add(EType.@dmat3x4, VtHandler);
            extracterDict.Add(EType.@dmat4x2, VtHandler);
            extracterDict.Add(EType.@dmat4x3, VtHandler);
            extracterDict.Add(EType.@dmat4x4, VtHandler);
            extracterDict.Add(EType.@atomic_uint, VtHandler);
            extracterDict.Add(EType.@sampler1D, VtHandler);
            extracterDict.Add(EType.@sampler2D, VtHandler);
            extracterDict.Add(EType.@sampler3D, VtHandler);
            extracterDict.Add(EType.@samplerCube, VtHandler);
            extracterDict.Add(EType.@sampler1DShadow, VtHandler);
            extracterDict.Add(EType.@sampler2DShadow, VtHandler);
            extracterDict.Add(EType.@samplerCubeShadow, VtHandler);
            extracterDict.Add(EType.@sampler1DArray, VtHandler);
            extracterDict.Add(EType.@sampler2DArray, VtHandler);
            extracterDict.Add(EType.@sampler1DArrayShadow, VtHandler);
            extracterDict.Add(EType.@sampler2DArrayShadow, VtHandler);
            extracterDict.Add(EType.@samplerCubeArray, VtHandler);
            extracterDict.Add(EType.@samplerCubeArrayShadow, VtHandler);
            extracterDict.Add(EType.@isampler1D, VtHandler);
            extracterDict.Add(EType.@isampler2D, VtHandler);
            extracterDict.Add(EType.@isampler3D, VtHandler);
            extracterDict.Add(EType.@isamplerCube, VtHandler);
            extracterDict.Add(EType.@isampler1DArray, VtHandler);
            extracterDict.Add(EType.@isampler2DArray, VtHandler);
            extracterDict.Add(EType.@isamplerCubeArray, VtHandler);
            extracterDict.Add(EType.@usampler1D, VtHandler);
            extracterDict.Add(EType.@usampler2D, VtHandler);
            extracterDict.Add(EType.@usampler3D, VtHandler);
            extracterDict.Add(EType.@usamplerCube, VtHandler);
            extracterDict.Add(EType.@usampler1DArray, VtHandler);
            extracterDict.Add(EType.@usampler2DArray, VtHandler);
            extracterDict.Add(EType.@usamplerCubeArray, VtHandler);
            extracterDict.Add(EType.@sampler2DRect, VtHandler);
            extracterDict.Add(EType.@sampler2DRectShadow, VtHandler);
            extracterDict.Add(EType.@isampler2DRect, VtHandler);
            extracterDict.Add(EType.@usampler2DRect, VtHandler);
            extracterDict.Add(EType.@samplerBuffer, VtHandler);
            extracterDict.Add(EType.@isamplerBuffer, VtHandler);
            extracterDict.Add(EType.@usamplerBuffer, VtHandler);
            extracterDict.Add(EType.@sampler2DMS, VtHandler);
            extracterDict.Add(EType.@isampler2DMS, VtHandler);
            extracterDict.Add(EType.@usampler2DMS, VtHandler);
            extracterDict.Add(EType.@sampler2DMSArray, VtHandler);
            extracterDict.Add(EType.@isampler2DMSArray, VtHandler);
            extracterDict.Add(EType.@usampler2DMSArray, VtHandler);
            extracterDict.Add(EType.@image1D, VtHandler);
            extracterDict.Add(EType.@iimage1D, VtHandler);
            extracterDict.Add(EType.@uimage1D, VtHandler);
            extracterDict.Add(EType.@image2D, VtHandler);
            extracterDict.Add(EType.@iimage2D, VtHandler);
            extracterDict.Add(EType.@uimage2D, VtHandler);
            extracterDict.Add(EType.@image3D, VtHandler);
            extracterDict.Add(EType.@iimage3D, VtHandler);
            extracterDict.Add(EType.@uimage3D, VtHandler);
            extracterDict.Add(EType.@image2DRect, VtHandler);
            extracterDict.Add(EType.@iimage2DRect, VtHandler);
            extracterDict.Add(EType.@uimage2DRect, VtHandler);
            extracterDict.Add(EType.@imageCube, VtHandler);
            extracterDict.Add(EType.@iimageCube, VtHandler);
            extracterDict.Add(EType.@uimageCube, VtHandler);
            extracterDict.Add(EType.@imageBuffer, VtHandler);
            extracterDict.Add(EType.@iimageBuffer, VtHandler);
            extracterDict.Add(EType.@uimageBuffer, VtHandler);
            extracterDict.Add(EType.@image1DArray, VtHandler);
            extracterDict.Add(EType.@iimage1DArray, VtHandler);
            extracterDict.Add(EType.@uimage1DArray, VtHandler);
            extracterDict.Add(EType.@image2DArray, VtHandler);
            extracterDict.Add(EType.@iimage2DArray, VtHandler);
            extracterDict.Add(EType.@uimage2DArray, VtHandler);
            extracterDict.Add(EType.@imageCubeArray, VtHandler);
            extracterDict.Add(EType.@iimageCubeArray, VtHandler);
            extracterDict.Add(EType.@uimageCubeArray, VtHandler);
            extracterDict.Add(EType.@image2DMS, VtHandler);
            extracterDict.Add(EType.@iimage2DMS, VtHandler);
            extracterDict.Add(EType.@uimage2DMS, VtHandler);
            extracterDict.Add(EType.@image2DMSArray, VtHandler);
            extracterDict.Add(EType.@iimage2DMSArray, VtHandler);
            extracterDict.Add(EType.@uimage2DMSArray, VtHandler);
            extracterDict.Add(EType.@high_precision, VtHandler);
            extracterDict.Add(EType.@medium_precision, VtHandler);
            extracterDict.Add(EType.@low_precision, VtHandler);
            extracterDict.Add(EType.@struct, VtHandler);
            extracterDict.Add(EType.@if, VtHandler);
            extracterDict.Add(EType.@else, VtHandler);
            extracterDict.Add(EType.@switch, VtHandler);
            extracterDict.Add(EType.@case, VtHandler);
            extracterDict.Add(EType.@default, VtHandler);
            extracterDict.Add(EType.@while, VtHandler);
            extracterDict.Add(EType.@do, VtHandler);
            extracterDict.Add(EType.@for, VtHandler);
            extracterDict.Add(EType.@continue, VtHandler);
            extracterDict.Add(EType.@break, VtHandler);
            extracterDict.Add(EType.@return, VtHandler);
            extracterDict.Add(EType.@discard, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: ShaderModel> : translation_unit ;
                var translation_unit = context.objStack.Pop() as translation_unit;
                var shaderModel = new ShaderModel(/*translation_unit*/);
                context.result = shaderModel; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.translation_unit,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[0]) {
                    // 0: translation_unit : external_declaration ;
                    var external_declaration0 = context.objStack.Pop() as external_declaration;
                    var translation_unit = new translation_unit(/*external_declaration0*/);
                    context.objStack.Push(translation_unit);
                }
                else if (node.regulation == CompilerGLSL.regulations[1]) {
                    // 1: translation_unit : translation_unit external_declaration ;
                    var external_declaration0 = context.objStack.Pop() as external_declaration;
                    var translation_unit1 = context.objStack.Pop() as translation_unit;
                    var translation_unit = new translation_unit(/*translation_unit1, external_declaration0*/);
                    context.objStack.Push(translation_unit);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.external_declaration,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[2]) {
                    // 2: external_declaration : function_definition ;
                    var function_definition0 = context.objStack.Pop() as function_definition;
                    var external_declaration = new external_declaration(/*function_definition0*/);
                    context.objStack.Push(external_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[3]) {
                    // 3: external_declaration : declaration ;
                    var declaration0 = context.objStack.Pop() as declaration;
                    var external_declaration = new external_declaration(/*declaration0*/);
                    context.objStack.Push(external_declaration);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_definition,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[4]) {
                    // 4: function_definition : function_prototype compound_statement_no_new_scope ;
                    var compound_statement_no_new_scope0 = context.objStack.Pop() as compound_statement_no_new_scope;
                    var function_prototype1 = context.objStack.Pop() as function_prototype;
                    var function_definition = new function_definition(/*function_prototype1, compound_statement_no_new_scope0*/);
                    context.objStack.Push(function_definition);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.variable_identifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[5]) {
                    // 5: variable_identifier : 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var variable_identifier = new variable_identifier(/*@identifier0*/);
                    context.objStack.Push(variable_identifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.primary_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[6]) {
                    // 6: primary_expression : variable_identifier ;
                    var variable_identifier0 = context.objStack.Pop() as variable_identifier;
                    var primary_expression = new primary_expression(/*variable_identifier0*/);
                    context.objStack.Push(primary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[7]) {
                    // 7: primary_expression : 'number' ;
                    var @number0 = context.objStack.Pop() as Token;
                    var primary_expression = new primary_expression(/*@number0*/);
                    context.objStack.Push(primary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[8]) {
                    // 8: primary_expression : BOOLCONSTANT ;
                    var bOOLCONSTANT0 = context.objStack.Pop() as BOOLCONSTANT;
                    var primary_expression = new primary_expression(/*bOOLCONSTANT0*/);
                    context.objStack.Push(primary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[9]) {
                    // 9: primary_expression : '(' expression ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var expression1 = context.objStack.Pop() as expression;
                    var @LeftParenthesis2 = context.objStack.Pop() as Token;
                    var primary_expression = new primary_expression(/*@LeftParenthesis2, expression1, @RightParenthesis0*/);
                    context.objStack.Push(primary_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.BOOLCONSTANT,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[10]) {
                    // 10: BOOLCONSTANT : 'true' ;
                    var @true0 = context.objStack.Pop() as Token;
                    var bOOLCONSTANT = new BOOLCONSTANT(/*@true0*/);
                    context.objStack.Push(bOOLCONSTANT);
                }
                else if (node.regulation == CompilerGLSL.regulations[11]) {
                    // 11: BOOLCONSTANT : 'false' ;
                    var @false0 = context.objStack.Pop() as Token;
                    var bOOLCONSTANT = new BOOLCONSTANT(/*@false0*/);
                    context.objStack.Push(bOOLCONSTANT);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.postfix_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[12]) {
                    // 12: postfix_expression : primary_expression ;
                    var primary_expression0 = context.objStack.Pop() as primary_expression;
                    var postfix_expression = new postfix_expression(/*primary_expression0*/);
                    context.objStack.Push(postfix_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[13]) {
                    // 13: postfix_expression : postfix_expression '[' integer_expression ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var integer_expression1 = context.objStack.Pop() as integer_expression;
                    var @LeftBracket2 = context.objStack.Pop() as Token;
                    var postfix_expression3 = context.objStack.Pop() as postfix_expression;
                    var postfix_expression = new postfix_expression(/*postfix_expression3, @LeftBracket2, integer_expression1, @RightBracket0*/);
                    context.objStack.Push(postfix_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[14]) {
                    // 14: postfix_expression : function_call ;
                    var function_call0 = context.objStack.Pop() as function_call;
                    var postfix_expression = new postfix_expression(/*function_call0*/);
                    context.objStack.Push(postfix_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[15]) {
                    // 15: postfix_expression : postfix_expression '.' FIELD_SELECTION ;
                    var fIELD_SELECTION0 = context.objStack.Pop() as FIELD_SELECTION;
                    var @Dot1 = context.objStack.Pop() as Token;
                    var postfix_expression2 = context.objStack.Pop() as postfix_expression;
                    var postfix_expression = new postfix_expression(/*postfix_expression2, @Dot1, fIELD_SELECTION0*/);
                    context.objStack.Push(postfix_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[16]) {
                    // 16: postfix_expression : postfix_expression '++' ;
                    var @PlusPlus0 = context.objStack.Pop() as Token;
                    var postfix_expression1 = context.objStack.Pop() as postfix_expression;
                    var postfix_expression = new postfix_expression(/*postfix_expression1, @PlusPlus0*/);
                    context.objStack.Push(postfix_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[17]) {
                    // 17: postfix_expression : postfix_expression '--' ;
                    var @DashDash0 = context.objStack.Pop() as Token;
                    var postfix_expression1 = context.objStack.Pop() as postfix_expression;
                    var postfix_expression = new postfix_expression(/*postfix_expression1, @DashDash0*/);
                    context.objStack.Push(postfix_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.FIELD_SELECTION,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[18]) {
                    // 18: FIELD_SELECTION : 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var fIELD_SELECTION = new FIELD_SELECTION(/*@identifier0*/);
                    context.objStack.Push(fIELD_SELECTION);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.integer_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[19]) {
                    // 19: integer_expression : expression ;
                    var expression0 = context.objStack.Pop() as expression;
                    var integer_expression = new integer_expression(/*expression0*/);
                    context.objStack.Push(integer_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[20]) {
                    // 20: function_call : function_call_or_method ;
                    var function_call_or_method0 = context.objStack.Pop() as function_call_or_method;
                    var function_call = new function_call(/*function_call_or_method0*/);
                    context.objStack.Push(function_call);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call_or_method,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[21]) {
                    // 21: function_call_or_method : function_call_generic ;
                    var function_call_generic0 = context.objStack.Pop() as function_call_generic;
                    var function_call_or_method = new function_call_or_method(/*function_call_generic0*/);
                    context.objStack.Push(function_call_or_method);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call_generic,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[22]) {
                    // 22: function_call_generic : function_call_header_with_parameters ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var function_call_header_with_parameters1 = context.objStack.Pop() as function_call_header_with_parameters;
                    var function_call_generic = new function_call_generic(/*function_call_header_with_parameters1, @RightParenthesis0*/);
                    context.objStack.Push(function_call_generic);
                }
                else if (node.regulation == CompilerGLSL.regulations[23]) {
                    // 23: function_call_generic : function_call_header_no_parameters ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var function_call_header_no_parameters1 = context.objStack.Pop() as function_call_header_no_parameters;
                    var function_call_generic = new function_call_generic(/*function_call_header_no_parameters1, @RightParenthesis0*/);
                    context.objStack.Push(function_call_generic);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call_header_no_parameters,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[24]) {
                    // 24: function_call_header_no_parameters : function_call_header 'void' ;
                    var @void0 = context.objStack.Pop() as Token;
                    var function_call_header1 = context.objStack.Pop() as function_call_header;
                    var function_call_header_no_parameters = new function_call_header_no_parameters(/*function_call_header1, @void0*/);
                    context.objStack.Push(function_call_header_no_parameters);
                }
                else if (node.regulation == CompilerGLSL.regulations[25]) {
                    // 25: function_call_header_no_parameters : function_call_header ;
                    var function_call_header0 = context.objStack.Pop() as function_call_header;
                    var function_call_header_no_parameters = new function_call_header_no_parameters(/*function_call_header0*/);
                    context.objStack.Push(function_call_header_no_parameters);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call_header_with_parameters,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[26]) {
                    // 26: function_call_header_with_parameters : function_call_header assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var function_call_header1 = context.objStack.Pop() as function_call_header;
                    var function_call_header_with_parameters = new function_call_header_with_parameters(/*function_call_header1, assignment_expression0*/);
                    context.objStack.Push(function_call_header_with_parameters);
                }
                else if (node.regulation == CompilerGLSL.regulations[27]) {
                    // 27: function_call_header_with_parameters : function_call_header_with_parameters ',' assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var function_call_header_with_parameters2 = context.objStack.Pop() as function_call_header_with_parameters;
                    var function_call_header_with_parameters = new function_call_header_with_parameters(/*function_call_header_with_parameters2, @Comma1, assignment_expression0*/);
                    context.objStack.Push(function_call_header_with_parameters);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_call_header,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[28]) {
                    // 28: function_call_header : function_identifier '(' ;
                    var @LeftParenthesis0 = context.objStack.Pop() as Token;
                    var function_identifier1 = context.objStack.Pop() as function_identifier;
                    var function_call_header = new function_call_header(/*function_identifier1, @LeftParenthesis0*/);
                    context.objStack.Push(function_call_header);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_identifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[29]) {
                    // 29: function_identifier : type_specifier ;
                    var type_specifier0 = context.objStack.Pop() as type_specifier;
                    var function_identifier = new function_identifier(/*type_specifier0*/);
                    context.objStack.Push(function_identifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[30]) {
                    // 30: function_identifier : postfix_expression ;
                    var postfix_expression0 = context.objStack.Pop() as postfix_expression;
                    var function_identifier = new function_identifier(/*postfix_expression0*/);
                    context.objStack.Push(function_identifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.unary_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[31]) {
                    // 31: unary_expression : postfix_expression ;
                    var postfix_expression0 = context.objStack.Pop() as postfix_expression;
                    var unary_expression = new unary_expression(/*postfix_expression0*/);
                    context.objStack.Push(unary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[32]) {
                    // 32: unary_expression : '++' unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var @PlusPlus1 = context.objStack.Pop() as Token;
                    var unary_expression = new unary_expression(/*@PlusPlus1, unary_expression0*/);
                    context.objStack.Push(unary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[33]) {
                    // 33: unary_expression : '--' unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var @DashDash1 = context.objStack.Pop() as Token;
                    var unary_expression = new unary_expression(/*@DashDash1, unary_expression0*/);
                    context.objStack.Push(unary_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[34]) {
                    // 34: unary_expression : unary_operator unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var unary_operator1 = context.objStack.Pop() as unary_operator;
                    var unary_expression = new unary_expression(/*unary_operator1, unary_expression0*/);
                    context.objStack.Push(unary_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.unary_operator,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[35]) {
                    // 35: unary_operator : '+' ;
                    var @Plus0 = context.objStack.Pop() as Token;
                    var unary_operator = new unary_operator(/*@Plus0*/);
                    context.objStack.Push(unary_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[36]) {
                    // 36: unary_operator : '-' ;
                    var @Dash0 = context.objStack.Pop() as Token;
                    var unary_operator = new unary_operator(/*@Dash0*/);
                    context.objStack.Push(unary_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[37]) {
                    // 37: unary_operator : '!' ;
                    var @Bang0 = context.objStack.Pop() as Token;
                    var unary_operator = new unary_operator(/*@Bang0*/);
                    context.objStack.Push(unary_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[38]) {
                    // 38: unary_operator : '~' ;
                    var @Tilde0 = context.objStack.Pop() as Token;
                    var unary_operator = new unary_operator(/*@Tilde0*/);
                    context.objStack.Push(unary_operator);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.multiplicative_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[39]) {
                    // 39: multiplicative_expression : unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var multiplicative_expression = new multiplicative_expression(/*unary_expression0*/);
                    context.objStack.Push(multiplicative_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[40]) {
                    // 40: multiplicative_expression : multiplicative_expression '*' unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var @Asterisk1 = context.objStack.Pop() as Token;
                    var multiplicative_expression2 = context.objStack.Pop() as multiplicative_expression;
                    var multiplicative_expression = new multiplicative_expression(/*multiplicative_expression2, @Asterisk1, unary_expression0*/);
                    context.objStack.Push(multiplicative_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[41]) {
                    // 41: multiplicative_expression : multiplicative_expression '/' unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var @Slash1 = context.objStack.Pop() as Token;
                    var multiplicative_expression2 = context.objStack.Pop() as multiplicative_expression;
                    var multiplicative_expression = new multiplicative_expression(/*multiplicative_expression2, @Slash1, unary_expression0*/);
                    context.objStack.Push(multiplicative_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[42]) {
                    // 42: multiplicative_expression : multiplicative_expression '%' unary_expression ;
                    var unary_expression0 = context.objStack.Pop() as unary_expression;
                    var @Percent1 = context.objStack.Pop() as Token;
                    var multiplicative_expression2 = context.objStack.Pop() as multiplicative_expression;
                    var multiplicative_expression = new multiplicative_expression(/*multiplicative_expression2, @Percent1, unary_expression0*/);
                    context.objStack.Push(multiplicative_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.additive_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[43]) {
                    // 43: additive_expression : multiplicative_expression ;
                    var multiplicative_expression0 = context.objStack.Pop() as multiplicative_expression;
                    var additive_expression = new additive_expression(/*multiplicative_expression0*/);
                    context.objStack.Push(additive_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[44]) {
                    // 44: additive_expression : additive_expression '+' multiplicative_expression ;
                    var multiplicative_expression0 = context.objStack.Pop() as multiplicative_expression;
                    var @Plus1 = context.objStack.Pop() as Token;
                    var additive_expression2 = context.objStack.Pop() as additive_expression;
                    var additive_expression = new additive_expression(/*additive_expression2, @Plus1, multiplicative_expression0*/);
                    context.objStack.Push(additive_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[45]) {
                    // 45: additive_expression : additive_expression '-' multiplicative_expression ;
                    var multiplicative_expression0 = context.objStack.Pop() as multiplicative_expression;
                    var @Dash1 = context.objStack.Pop() as Token;
                    var additive_expression2 = context.objStack.Pop() as additive_expression;
                    var additive_expression = new additive_expression(/*additive_expression2, @Dash1, multiplicative_expression0*/);
                    context.objStack.Push(additive_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.shift_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[46]) {
                    // 46: shift_expression : additive_expression ;
                    var additive_expression0 = context.objStack.Pop() as additive_expression;
                    var shift_expression = new shift_expression(/*additive_expression0*/);
                    context.objStack.Push(shift_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[47]) {
                    // 47: shift_expression : shift_expression '<<' additive_expression ;
                    var additive_expression0 = context.objStack.Pop() as additive_expression;
                    var @LeftAngleLeftAngle1 = context.objStack.Pop() as Token;
                    var shift_expression2 = context.objStack.Pop() as shift_expression;
                    var shift_expression = new shift_expression(/*shift_expression2, @LeftAngleLeftAngle1, additive_expression0*/);
                    context.objStack.Push(shift_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[48]) {
                    // 48: shift_expression : shift_expression '>>' additive_expression ;
                    var additive_expression0 = context.objStack.Pop() as additive_expression;
                    var @RightAngleRightAngle1 = context.objStack.Pop() as Token;
                    var shift_expression2 = context.objStack.Pop() as shift_expression;
                    var shift_expression = new shift_expression(/*shift_expression2, @RightAngleRightAngle1, additive_expression0*/);
                    context.objStack.Push(shift_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.relational_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[49]) {
                    // 49: relational_expression : shift_expression ;
                    var shift_expression0 = context.objStack.Pop() as shift_expression;
                    var relational_expression = new relational_expression(/*shift_expression0*/);
                    context.objStack.Push(relational_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[50]) {
                    // 50: relational_expression : relational_expression '<' shift_expression ;
                    var shift_expression0 = context.objStack.Pop() as shift_expression;
                    var @LeftAngle1 = context.objStack.Pop() as Token;
                    var relational_expression2 = context.objStack.Pop() as relational_expression;
                    var relational_expression = new relational_expression(/*relational_expression2, @LeftAngle1, shift_expression0*/);
                    context.objStack.Push(relational_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[51]) {
                    // 51: relational_expression : relational_expression '>' shift_expression ;
                    var shift_expression0 = context.objStack.Pop() as shift_expression;
                    var @RightAngle1 = context.objStack.Pop() as Token;
                    var relational_expression2 = context.objStack.Pop() as relational_expression;
                    var relational_expression = new relational_expression(/*relational_expression2, @RightAngle1, shift_expression0*/);
                    context.objStack.Push(relational_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[52]) {
                    // 52: relational_expression : relational_expression '<=' shift_expression ;
                    var shift_expression0 = context.objStack.Pop() as shift_expression;
                    var @LeftAngleEqual1 = context.objStack.Pop() as Token;
                    var relational_expression2 = context.objStack.Pop() as relational_expression;
                    var relational_expression = new relational_expression(/*relational_expression2, @LeftAngleEqual1, shift_expression0*/);
                    context.objStack.Push(relational_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[53]) {
                    // 53: relational_expression : relational_expression '>=' shift_expression ;
                    var shift_expression0 = context.objStack.Pop() as shift_expression;
                    var @RightAngleEqual1 = context.objStack.Pop() as Token;
                    var relational_expression2 = context.objStack.Pop() as relational_expression;
                    var relational_expression = new relational_expression(/*relational_expression2, @RightAngleEqual1, shift_expression0*/);
                    context.objStack.Push(relational_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.equality_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[54]) {
                    // 54: equality_expression : relational_expression ;
                    var relational_expression0 = context.objStack.Pop() as relational_expression;
                    var equality_expression = new equality_expression(/*relational_expression0*/);
                    context.objStack.Push(equality_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[55]) {
                    // 55: equality_expression : equality_expression '==' relational_expression ;
                    var relational_expression0 = context.objStack.Pop() as relational_expression;
                    var @EqualEqual1 = context.objStack.Pop() as Token;
                    var equality_expression2 = context.objStack.Pop() as equality_expression;
                    var equality_expression = new equality_expression(/*equality_expression2, @EqualEqual1, relational_expression0*/);
                    context.objStack.Push(equality_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[56]) {
                    // 56: equality_expression : equality_expression '!=' relational_expression ;
                    var relational_expression0 = context.objStack.Pop() as relational_expression;
                    var @BangEqual1 = context.objStack.Pop() as Token;
                    var equality_expression2 = context.objStack.Pop() as equality_expression;
                    var equality_expression = new equality_expression(/*equality_expression2, @BangEqual1, relational_expression0*/);
                    context.objStack.Push(equality_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.and_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[57]) {
                    // 57: and_expression : equality_expression ;
                    var equality_expression0 = context.objStack.Pop() as equality_expression;
                    var and_expression = new and_expression(/*equality_expression0*/);
                    context.objStack.Push(and_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[58]) {
                    // 58: and_expression : and_expression '&' equality_expression ;
                    var equality_expression0 = context.objStack.Pop() as equality_expression;
                    var @And1 = context.objStack.Pop() as Token;
                    var and_expression2 = context.objStack.Pop() as and_expression;
                    var and_expression = new and_expression(/*and_expression2, @And1, equality_expression0*/);
                    context.objStack.Push(and_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.exclusive_or_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[59]) {
                    // 59: exclusive_or_expression : and_expression ;
                    var and_expression0 = context.objStack.Pop() as and_expression;
                    var exclusive_or_expression = new exclusive_or_expression(/*and_expression0*/);
                    context.objStack.Push(exclusive_or_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[60]) {
                    // 60: exclusive_or_expression : exclusive_or_expression '^' and_expression ;
                    var and_expression0 = context.objStack.Pop() as and_expression;
                    var @Caret1 = context.objStack.Pop() as Token;
                    var exclusive_or_expression2 = context.objStack.Pop() as exclusive_or_expression;
                    var exclusive_or_expression = new exclusive_or_expression(/*exclusive_or_expression2, @Caret1, and_expression0*/);
                    context.objStack.Push(exclusive_or_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.inclusive_or_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[61]) {
                    // 61: inclusive_or_expression : exclusive_or_expression ;
                    var exclusive_or_expression0 = context.objStack.Pop() as exclusive_or_expression;
                    var inclusive_or_expression = new inclusive_or_expression(/*exclusive_or_expression0*/);
                    context.objStack.Push(inclusive_or_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[62]) {
                    // 62: inclusive_or_expression : inclusive_or_expression '|' exclusive_or_expression ;
                    var exclusive_or_expression0 = context.objStack.Pop() as exclusive_or_expression;
                    var @Pipe1 = context.objStack.Pop() as Token;
                    var inclusive_or_expression2 = context.objStack.Pop() as inclusive_or_expression;
                    var inclusive_or_expression = new inclusive_or_expression(/*inclusive_or_expression2, @Pipe1, exclusive_or_expression0*/);
                    context.objStack.Push(inclusive_or_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.logical_and_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[63]) {
                    // 63: logical_and_expression : inclusive_or_expression ;
                    var inclusive_or_expression0 = context.objStack.Pop() as inclusive_or_expression;
                    var logical_and_expression = new logical_and_expression(/*inclusive_or_expression0*/);
                    context.objStack.Push(logical_and_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[64]) {
                    // 64: logical_and_expression : logical_and_expression '&&' inclusive_or_expression ;
                    var inclusive_or_expression0 = context.objStack.Pop() as inclusive_or_expression;
                    var @AndAnd1 = context.objStack.Pop() as Token;
                    var logical_and_expression2 = context.objStack.Pop() as logical_and_expression;
                    var logical_and_expression = new logical_and_expression(/*logical_and_expression2, @AndAnd1, inclusive_or_expression0*/);
                    context.objStack.Push(logical_and_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.logical_xor_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[65]) {
                    // 65: logical_xor_expression : logical_and_expression ;
                    var logical_and_expression0 = context.objStack.Pop() as logical_and_expression;
                    var logical_xor_expression = new logical_xor_expression(/*logical_and_expression0*/);
                    context.objStack.Push(logical_xor_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[66]) {
                    // 66: logical_xor_expression : logical_xor_expression '^^' logical_and_expression ;
                    var logical_and_expression0 = context.objStack.Pop() as logical_and_expression;
                    var @CaretCaret1 = context.objStack.Pop() as Token;
                    var logical_xor_expression2 = context.objStack.Pop() as logical_xor_expression;
                    var logical_xor_expression = new logical_xor_expression(/*logical_xor_expression2, @CaretCaret1, logical_and_expression0*/);
                    context.objStack.Push(logical_xor_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.logical_or_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[67]) {
                    // 67: logical_or_expression : logical_xor_expression ;
                    var logical_xor_expression0 = context.objStack.Pop() as logical_xor_expression;
                    var logical_or_expression = new logical_or_expression(/*logical_xor_expression0*/);
                    context.objStack.Push(logical_or_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[68]) {
                    // 68: logical_or_expression : logical_or_expression '||' logical_xor_expression ;
                    var logical_xor_expression0 = context.objStack.Pop() as logical_xor_expression;
                    var @PipePipe1 = context.objStack.Pop() as Token;
                    var logical_or_expression2 = context.objStack.Pop() as logical_or_expression;
                    var logical_or_expression = new logical_or_expression(/*logical_or_expression2, @PipePipe1, logical_xor_expression0*/);
                    context.objStack.Push(logical_or_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.conditional_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[69]) {
                    // 69: conditional_expression : logical_or_expression ;
                    var logical_or_expression0 = context.objStack.Pop() as logical_or_expression;
                    var conditional_expression = new conditional_expression(/*logical_or_expression0*/);
                    context.objStack.Push(conditional_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[70]) {
                    // 70: conditional_expression : logical_or_expression '?' expression ':' assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var @Colon1 = context.objStack.Pop() as Token;
                    var expression2 = context.objStack.Pop() as expression;
                    var @Question3 = context.objStack.Pop() as Token;
                    var logical_or_expression4 = context.objStack.Pop() as logical_or_expression;
                    var conditional_expression = new conditional_expression(/*logical_or_expression4, @Question3, expression2, @Colon1, assignment_expression0*/);
                    context.objStack.Push(conditional_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.assignment_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[71]) {
                    // 71: assignment_expression : conditional_expression ;
                    var conditional_expression0 = context.objStack.Pop() as conditional_expression;
                    var assignment_expression = new assignment_expression(/*conditional_expression0*/);
                    context.objStack.Push(assignment_expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[72]) {
                    // 72: assignment_expression : unary_expression assignment_operator assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var assignment_operator1 = context.objStack.Pop() as assignment_operator;
                    var unary_expression2 = context.objStack.Pop() as unary_expression;
                    var assignment_expression = new assignment_expression(/*unary_expression2, assignment_operator1, assignment_expression0*/);
                    context.objStack.Push(assignment_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.assignment_operator,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[73]) {
                    // 73: assignment_operator : '=' ;
                    var @Equal0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@Equal0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[74]) {
                    // 74: assignment_operator : '*=' ;
                    var @AsteriskEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@AsteriskEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[75]) {
                    // 75: assignment_operator : '/=' ;
                    var @SlashEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@SlashEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[76]) {
                    // 76: assignment_operator : '%=' ;
                    var @PercentEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@PercentEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[77]) {
                    // 77: assignment_operator : '+=' ;
                    var @PlusEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@PlusEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[78]) {
                    // 78: assignment_operator : '-=' ;
                    var @DashEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@DashEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[79]) {
                    // 79: assignment_operator : '<<=' ;
                    var @LeftAngleLeftAngleEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@LeftAngleLeftAngleEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[80]) {
                    // 80: assignment_operator : '>>=' ;
                    var @RightAngleRightAngleEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@RightAngleRightAngleEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[81]) {
                    // 81: assignment_operator : '&=' ;
                    var @AndEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@AndEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[82]) {
                    // 82: assignment_operator : '^=' ;
                    var @CaretEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@CaretEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else if (node.regulation == CompilerGLSL.regulations[83]) {
                    // 83: assignment_operator : '|=' ;
                    var @PipeEqual0 = context.objStack.Pop() as Token;
                    var assignment_operator = new assignment_operator(/*@PipeEqual0*/);
                    context.objStack.Push(assignment_operator);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[84]) {
                    // 84: expression : assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var expression = new expression(/*assignment_expression0*/);
                    context.objStack.Push(expression);
                }
                else if (node.regulation == CompilerGLSL.regulations[85]) {
                    // 85: expression : expression ',' assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var expression2 = context.objStack.Pop() as expression;
                    var expression = new expression(/*expression2, @Comma1, assignment_expression0*/);
                    context.objStack.Push(expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.constant_expression,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[86]) {
                    // 86: constant_expression : conditional_expression ;
                    var conditional_expression0 = context.objStack.Pop() as conditional_expression;
                    var constant_expression = new constant_expression(/*conditional_expression0*/);
                    context.objStack.Push(constant_expression);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.declaration,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[87]) {
                    // 87: declaration : function_prototype ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var function_prototype1 = context.objStack.Pop() as function_prototype;
                    var declaration = new declaration(/*function_prototype1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[88]) {
                    // 88: declaration : init_declarator_list ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var init_declarator_list1 = context.objStack.Pop() as init_declarator_list;
                    var declaration = new declaration(/*init_declarator_list1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[89]) {
                    // 89: declaration : 'precision' precision_qualifier type_specifier ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var type_specifier1 = context.objStack.Pop() as type_specifier;
                    var precision_qualifier2 = context.objStack.Pop() as precision_qualifier;
                    var @precision3 = context.objStack.Pop() as Token;
                    var declaration = new declaration(/*@precision3, precision_qualifier2, type_specifier1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[90]) {
                    // 90: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @RightBrace1 = context.objStack.Pop() as Token;
                    var struct_declaration_list2 = context.objStack.Pop() as struct_declaration_list;
                    var @LeftBrace3 = context.objStack.Pop() as Token;
                    var @identifier4 = context.objStack.Pop() as Token;
                    var type_qualifier5 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier5, @identifier4, @LeftBrace3, struct_declaration_list2, @RightBrace1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[91]) {
                    // 91: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' 'identifier' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var @RightBrace2 = context.objStack.Pop() as Token;
                    var struct_declaration_list3 = context.objStack.Pop() as struct_declaration_list;
                    var @LeftBrace4 = context.objStack.Pop() as Token;
                    var @identifier5 = context.objStack.Pop() as Token;
                    var type_qualifier6 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier6, @identifier5, @LeftBrace4, struct_declaration_list3, @RightBrace2, @identifier1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[92]) {
                    // 92: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' 'identifier' array_specifier ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var array_specifier1 = context.objStack.Pop() as array_specifier;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var @RightBrace3 = context.objStack.Pop() as Token;
                    var struct_declaration_list4 = context.objStack.Pop() as struct_declaration_list;
                    var @LeftBrace5 = context.objStack.Pop() as Token;
                    var @identifier6 = context.objStack.Pop() as Token;
                    var type_qualifier7 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier7, @identifier6, @LeftBrace5, struct_declaration_list4, @RightBrace3, @identifier2, array_specifier1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[93]) {
                    // 93: declaration : type_qualifier ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var type_qualifier1 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[94]) {
                    // 94: declaration : type_qualifier 'identifier' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var type_qualifier2 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier2, @identifier1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[95]) {
                    // 95: declaration : type_qualifier 'identifier' identifier_list ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var identifier_list1 = context.objStack.Pop() as identifier_list;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var type_qualifier3 = context.objStack.Pop() as type_qualifier;
                    var declaration = new declaration(/*type_qualifier3, @identifier2, identifier_list1, @Semicolon0*/);
                    context.objStack.Push(declaration);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.identifier_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[96]) {
                    // 96: identifier_list : ',' 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var identifier_list = new identifier_list(/*@Comma1, @identifier0*/);
                    context.objStack.Push(identifier_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[97]) {
                    // 97: identifier_list : identifier_list ',' 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var identifier_list2 = context.objStack.Pop() as identifier_list;
                    var identifier_list = new identifier_list(/*identifier_list2, @Comma1, @identifier0*/);
                    context.objStack.Push(identifier_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_prototype,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[98]) {
                    // 98: function_prototype : function_declarator ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var function_declarator1 = context.objStack.Pop() as function_declarator;
                    var function_prototype = new function_prototype(/*function_declarator1, @RightParenthesis0*/);
                    context.objStack.Push(function_prototype);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_declarator,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[99]) {
                    // 99: function_declarator : function_header ;
                    var function_header0 = context.objStack.Pop() as function_header;
                    var function_declarator = new function_declarator(/*function_header0*/);
                    context.objStack.Push(function_declarator);
                }
                else if (node.regulation == CompilerGLSL.regulations[100]) {
                    // 100: function_declarator : function_header_with_parameters ;
                    var function_header_with_parameters0 = context.objStack.Pop() as function_header_with_parameters;
                    var function_declarator = new function_declarator(/*function_header_with_parameters0*/);
                    context.objStack.Push(function_declarator);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_header_with_parameters,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[101]) {
                    // 101: function_header_with_parameters : function_header parameter_declaration ;
                    var parameter_declaration0 = context.objStack.Pop() as parameter_declaration;
                    var function_header1 = context.objStack.Pop() as function_header;
                    var function_header_with_parameters = new function_header_with_parameters(/*function_header1, parameter_declaration0*/);
                    context.objStack.Push(function_header_with_parameters);
                }
                else if (node.regulation == CompilerGLSL.regulations[102]) {
                    // 102: function_header_with_parameters : function_header_with_parameters ',' parameter_declaration ;
                    var parameter_declaration0 = context.objStack.Pop() as parameter_declaration;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var function_header_with_parameters2 = context.objStack.Pop() as function_header_with_parameters;
                    var function_header_with_parameters = new function_header_with_parameters(/*function_header_with_parameters2, @Comma1, parameter_declaration0*/);
                    context.objStack.Push(function_header_with_parameters);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.function_header,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[103]) {
                    // 103: function_header : fully_specified_type 'identifier' '(' ;
                    var @LeftParenthesis0 = context.objStack.Pop() as Token;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var fully_specified_type2 = context.objStack.Pop() as fully_specified_type;
                    var function_header = new function_header(/*fully_specified_type2, @identifier1, @LeftParenthesis0*/);
                    context.objStack.Push(function_header);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.parameter_declarator,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[104]) {
                    // 104: parameter_declarator : type_specifier 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var type_specifier1 = context.objStack.Pop() as type_specifier;
                    var parameter_declarator = new parameter_declarator(/*type_specifier1, @identifier0*/);
                    context.objStack.Push(parameter_declarator);
                }
                else if (node.regulation == CompilerGLSL.regulations[105]) {
                    // 105: parameter_declarator : type_specifier 'identifier' array_specifier ;
                    var array_specifier0 = context.objStack.Pop() as array_specifier;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var type_specifier2 = context.objStack.Pop() as type_specifier;
                    var parameter_declarator = new parameter_declarator(/*type_specifier2, @identifier1, array_specifier0*/);
                    context.objStack.Push(parameter_declarator);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.parameter_declaration,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[106]) {
                    // 106: parameter_declaration : type_qualifier parameter_declarator ;
                    var parameter_declarator0 = context.objStack.Pop() as parameter_declarator;
                    var type_qualifier1 = context.objStack.Pop() as type_qualifier;
                    var parameter_declaration = new parameter_declaration(/*type_qualifier1, parameter_declarator0*/);
                    context.objStack.Push(parameter_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[107]) {
                    // 107: parameter_declaration : parameter_declarator ;
                    var parameter_declarator0 = context.objStack.Pop() as parameter_declarator;
                    var parameter_declaration = new parameter_declaration(/*parameter_declarator0*/);
                    context.objStack.Push(parameter_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[108]) {
                    // 108: parameter_declaration : type_qualifier parameter_type_specifier ;
                    var parameter_type_specifier0 = context.objStack.Pop() as parameter_type_specifier;
                    var type_qualifier1 = context.objStack.Pop() as type_qualifier;
                    var parameter_declaration = new parameter_declaration(/*type_qualifier1, parameter_type_specifier0*/);
                    context.objStack.Push(parameter_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[109]) {
                    // 109: parameter_declaration : parameter_type_specifier ;
                    var parameter_type_specifier0 = context.objStack.Pop() as parameter_type_specifier;
                    var parameter_declaration = new parameter_declaration(/*parameter_type_specifier0*/);
                    context.objStack.Push(parameter_declaration);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.parameter_type_specifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[110]) {
                    // 110: parameter_type_specifier : type_specifier ;
                    var type_specifier0 = context.objStack.Pop() as type_specifier;
                    var parameter_type_specifier = new parameter_type_specifier(/*type_specifier0*/);
                    context.objStack.Push(parameter_type_specifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.init_declarator_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[111]) {
                    // 111: init_declarator_list : single_declaration ;
                    var single_declaration0 = context.objStack.Pop() as single_declaration;
                    var init_declarator_list = new init_declarator_list(/*single_declaration0*/);
                    context.objStack.Push(init_declarator_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[112]) {
                    // 112: init_declarator_list : init_declarator_list ',' 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var init_declarator_list2 = context.objStack.Pop() as init_declarator_list;
                    var init_declarator_list = new init_declarator_list(/*init_declarator_list2, @Comma1, @identifier0*/);
                    context.objStack.Push(init_declarator_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[113]) {
                    // 113: init_declarator_list : init_declarator_list ',' 'identifier' array_specifier ;
                    var array_specifier0 = context.objStack.Pop() as array_specifier;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var @Comma2 = context.objStack.Pop() as Token;
                    var init_declarator_list3 = context.objStack.Pop() as init_declarator_list;
                    var init_declarator_list = new init_declarator_list(/*init_declarator_list3, @Comma2, @identifier1, array_specifier0*/);
                    context.objStack.Push(init_declarator_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[114]) {
                    // 114: init_declarator_list : init_declarator_list ',' 'identifier' array_specifier '=' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var array_specifier2 = context.objStack.Pop() as array_specifier;
                    var @identifier3 = context.objStack.Pop() as Token;
                    var @Comma4 = context.objStack.Pop() as Token;
                    var init_declarator_list5 = context.objStack.Pop() as init_declarator_list;
                    var init_declarator_list = new init_declarator_list(/*init_declarator_list5, @Comma4, @identifier3, array_specifier2, @Equal1, initializer0*/);
                    context.objStack.Push(init_declarator_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[115]) {
                    // 115: init_declarator_list : init_declarator_list ',' 'identifier' '=' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var @Comma3 = context.objStack.Pop() as Token;
                    var init_declarator_list4 = context.objStack.Pop() as init_declarator_list;
                    var init_declarator_list = new init_declarator_list(/*init_declarator_list4, @Comma3, @identifier2, @Equal1, initializer0*/);
                    context.objStack.Push(init_declarator_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.single_declaration,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[116]) {
                    // 116: single_declaration : fully_specified_type ;
                    var fully_specified_type0 = context.objStack.Pop() as fully_specified_type;
                    var single_declaration = new single_declaration(/*fully_specified_type0*/);
                    context.objStack.Push(single_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[117]) {
                    // 117: single_declaration : fully_specified_type 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var fully_specified_type1 = context.objStack.Pop() as fully_specified_type;
                    var single_declaration = new single_declaration(/*fully_specified_type1, @identifier0*/);
                    context.objStack.Push(single_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[118]) {
                    // 118: single_declaration : fully_specified_type 'identifier' array_specifier ;
                    var array_specifier0 = context.objStack.Pop() as array_specifier;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var fully_specified_type2 = context.objStack.Pop() as fully_specified_type;
                    var single_declaration = new single_declaration(/*fully_specified_type2, @identifier1, array_specifier0*/);
                    context.objStack.Push(single_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[119]) {
                    // 119: single_declaration : fully_specified_type 'identifier' array_specifier '=' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var array_specifier2 = context.objStack.Pop() as array_specifier;
                    var @identifier3 = context.objStack.Pop() as Token;
                    var fully_specified_type4 = context.objStack.Pop() as fully_specified_type;
                    var single_declaration = new single_declaration(/*fully_specified_type4, @identifier3, array_specifier2, @Equal1, initializer0*/);
                    context.objStack.Push(single_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[120]) {
                    // 120: single_declaration : fully_specified_type 'identifier' '=' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var fully_specified_type3 = context.objStack.Pop() as fully_specified_type;
                    var single_declaration = new single_declaration(/*fully_specified_type3, @identifier2, @Equal1, initializer0*/);
                    context.objStack.Push(single_declaration);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.fully_specified_type,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[121]) {
                    // 121: fully_specified_type : type_specifier ;
                    var type_specifier0 = context.objStack.Pop() as type_specifier;
                    var fully_specified_type = new fully_specified_type(/*type_specifier0*/);
                    context.objStack.Push(fully_specified_type);
                }
                else if (node.regulation == CompilerGLSL.regulations[122]) {
                    // 122: fully_specified_type : type_qualifier type_specifier ;
                    var type_specifier0 = context.objStack.Pop() as type_specifier;
                    var type_qualifier1 = context.objStack.Pop() as type_qualifier;
                    var fully_specified_type = new fully_specified_type(/*type_qualifier1, type_specifier0*/);
                    context.objStack.Push(fully_specified_type);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.invariant_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[123]) {
                    // 123: invariant_qualifier : 'invariant' ;
                    var @invariant0 = context.objStack.Pop() as Token;
                    var invariant_qualifier = new invariant_qualifier(/*@invariant0*/);
                    context.objStack.Push(invariant_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.interpolation_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[124]) {
                    // 124: interpolation_qualifier : 'smooth' ;
                    var @smooth0 = context.objStack.Pop() as Token;
                    var interpolation_qualifier = new interpolation_qualifier(/*@smooth0*/);
                    context.objStack.Push(interpolation_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[125]) {
                    // 125: interpolation_qualifier : 'flat' ;
                    var @flat0 = context.objStack.Pop() as Token;
                    var interpolation_qualifier = new interpolation_qualifier(/*@flat0*/);
                    context.objStack.Push(interpolation_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[126]) {
                    // 126: interpolation_qualifier : 'noperspective' ;
                    var @noperspective0 = context.objStack.Pop() as Token;
                    var interpolation_qualifier = new interpolation_qualifier(/*@noperspective0*/);
                    context.objStack.Push(interpolation_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.layout_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[127]) {
                    // 127: layout_qualifier : 'layout' '(' layout_qualifier_id_list ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var layout_qualifier_id_list1 = context.objStack.Pop() as layout_qualifier_id_list;
                    var @LeftParenthesis2 = context.objStack.Pop() as Token;
                    var @layout3 = context.objStack.Pop() as Token;
                    var layout_qualifier = new layout_qualifier(/*@layout3, @LeftParenthesis2, layout_qualifier_id_list1, @RightParenthesis0*/);
                    context.objStack.Push(layout_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.layout_qualifier_id_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[128]) {
                    // 128: layout_qualifier_id_list : layout_qualifier_id ;
                    var layout_qualifier_id0 = context.objStack.Pop() as layout_qualifier_id;
                    var layout_qualifier_id_list = new layout_qualifier_id_list(/*layout_qualifier_id0*/);
                    context.objStack.Push(layout_qualifier_id_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[129]) {
                    // 129: layout_qualifier_id_list : layout_qualifier_id_list ',' layout_qualifier_id ;
                    var layout_qualifier_id0 = context.objStack.Pop() as layout_qualifier_id;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var layout_qualifier_id_list2 = context.objStack.Pop() as layout_qualifier_id_list;
                    var layout_qualifier_id_list = new layout_qualifier_id_list(/*layout_qualifier_id_list2, @Comma1, layout_qualifier_id0*/);
                    context.objStack.Push(layout_qualifier_id_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.layout_qualifier_id,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[130]) {
                    // 130: layout_qualifier_id : 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var layout_qualifier_id = new layout_qualifier_id(/*@identifier0*/);
                    context.objStack.Push(layout_qualifier_id);
                }
                else if (node.regulation == CompilerGLSL.regulations[131]) {
                    // 131: layout_qualifier_id : 'identifier' '=' 'number' ;
                    var @number0 = context.objStack.Pop() as Token;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var layout_qualifier_id = new layout_qualifier_id(/*@identifier2, @Equal1, @number0*/);
                    context.objStack.Push(layout_qualifier_id);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.precise_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[132]) {
                    // 132: precise_qualifier : 'precise' ;
                    var @precise0 = context.objStack.Pop() as Token;
                    var precise_qualifier = new precise_qualifier(/*@precise0*/);
                    context.objStack.Push(precise_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.type_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[133]) {
                    // 133: type_qualifier : single_type_qualifier ;
                    var single_type_qualifier0 = context.objStack.Pop() as single_type_qualifier;
                    var type_qualifier = new type_qualifier(/*single_type_qualifier0*/);
                    context.objStack.Push(type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[134]) {
                    // 134: type_qualifier : type_qualifier single_type_qualifier ;
                    var single_type_qualifier0 = context.objStack.Pop() as single_type_qualifier;
                    var type_qualifier1 = context.objStack.Pop() as type_qualifier;
                    var type_qualifier = new type_qualifier(/*type_qualifier1, single_type_qualifier0*/);
                    context.objStack.Push(type_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.single_type_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[135]) {
                    // 135: single_type_qualifier : storage_qualifier ;
                    var storage_qualifier0 = context.objStack.Pop() as storage_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*storage_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[136]) {
                    // 136: single_type_qualifier : layout_qualifier ;
                    var layout_qualifier0 = context.objStack.Pop() as layout_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*layout_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[137]) {
                    // 137: single_type_qualifier : precision_qualifier ;
                    var precision_qualifier0 = context.objStack.Pop() as precision_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*precision_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[138]) {
                    // 138: single_type_qualifier : interpolation_qualifier ;
                    var interpolation_qualifier0 = context.objStack.Pop() as interpolation_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*interpolation_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[139]) {
                    // 139: single_type_qualifier : invariant_qualifier ;
                    var invariant_qualifier0 = context.objStack.Pop() as invariant_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*invariant_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[140]) {
                    // 140: single_type_qualifier : precise_qualifier ;
                    var precise_qualifier0 = context.objStack.Pop() as precise_qualifier;
                    var single_type_qualifier = new single_type_qualifier(/*precise_qualifier0*/);
                    context.objStack.Push(single_type_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.storage_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[141]) {
                    // 141: storage_qualifier : 'const' ;
                    var @const0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@const0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[142]) {
                    // 142: storage_qualifier : 'inout' ;
                    var @inout0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@inout0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[143]) {
                    // 143: storage_qualifier : 'in' ;
                    var @in0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@in0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[144]) {
                    // 144: storage_qualifier : 'out' ;
                    var @out0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@out0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[145]) {
                    // 145: storage_qualifier : 'centroid' ;
                    var @centroid0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@centroid0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[146]) {
                    // 146: storage_qualifier : 'patch' ;
                    var @patch0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@patch0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[147]) {
                    // 147: storage_qualifier : 'sample' ;
                    var @sample0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@sample0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[148]) {
                    // 148: storage_qualifier : 'uniform' ;
                    var @uniform0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@uniform0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[149]) {
                    // 149: storage_qualifier : 'buffer' ;
                    var @buffer0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@buffer0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[150]) {
                    // 150: storage_qualifier : 'shared' ;
                    var @shared0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@shared0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[151]) {
                    // 151: storage_qualifier : 'coherent' ;
                    var @coherent0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@coherent0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[152]) {
                    // 152: storage_qualifier : 'volatile' ;
                    var @volatile0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@volatile0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[153]) {
                    // 153: storage_qualifier : 'restrict' ;
                    var @restrict0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@restrict0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[154]) {
                    // 154: storage_qualifier : 'readonly' ;
                    var @readonly0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@readonly0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[155]) {
                    // 155: storage_qualifier : 'writeonly' ;
                    var @writeonly0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@writeonly0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[156]) {
                    // 156: storage_qualifier : 'subroutine' ;
                    var @subroutine0 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@subroutine0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[157]) {
                    // 157: storage_qualifier : 'subroutine' '(' type_name_list ')' ;
                    var @RightParenthesis0 = context.objStack.Pop() as Token;
                    var type_name_list1 = context.objStack.Pop() as type_name_list;
                    var @LeftParenthesis2 = context.objStack.Pop() as Token;
                    var @subroutine3 = context.objStack.Pop() as Token;
                    var storage_qualifier = new storage_qualifier(/*@subroutine3, @LeftParenthesis2, type_name_list1, @RightParenthesis0*/);
                    context.objStack.Push(storage_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.type_name_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[158]) {
                    // 158: type_name_list : 'userDefinedType' ;
                    var @userDefinedType0 = context.objStack.Pop() as Token;
                    var type_name_list = new type_name_list(/*@userDefinedType0*/);
                    context.objStack.Push(type_name_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[159]) {
                    // 159: type_name_list : type_name_list ',' 'userDefinedType' ;
                    var @userDefinedType0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var type_name_list2 = context.objStack.Pop() as type_name_list;
                    var type_name_list = new type_name_list(/*type_name_list2, @Comma1, @userDefinedType0*/);
                    context.objStack.Push(type_name_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.type_specifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[160]) {
                    // 160: type_specifier : type_specifier_nonarray ;
                    var type_specifier_nonarray0 = context.objStack.Pop() as type_specifier_nonarray;
                    var type_specifier = new type_specifier(/*type_specifier_nonarray0*/);
                    context.objStack.Push(type_specifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[161]) {
                    // 161: type_specifier : type_specifier_nonarray array_specifier ;
                    var array_specifier0 = context.objStack.Pop() as array_specifier;
                    var type_specifier_nonarray1 = context.objStack.Pop() as type_specifier_nonarray;
                    var type_specifier = new type_specifier(/*type_specifier_nonarray1, array_specifier0*/);
                    context.objStack.Push(type_specifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.array_specifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[162]) {
                    // 162: array_specifier : '[' ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var @LeftBracket1 = context.objStack.Pop() as Token;
                    var array_specifier = new array_specifier(/*@LeftBracket1, @RightBracket0*/);
                    context.objStack.Push(array_specifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[163]) {
                    // 163: array_specifier : '[' constant_expression ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var constant_expression1 = context.objStack.Pop() as constant_expression;
                    var @LeftBracket2 = context.objStack.Pop() as Token;
                    var array_specifier = new array_specifier(/*@LeftBracket2, constant_expression1, @RightBracket0*/);
                    context.objStack.Push(array_specifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[164]) {
                    // 164: array_specifier : array_specifier '[' ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var @LeftBracket1 = context.objStack.Pop() as Token;
                    var array_specifier2 = context.objStack.Pop() as array_specifier;
                    var array_specifier = new array_specifier(/*array_specifier2, @LeftBracket1, @RightBracket0*/);
                    context.objStack.Push(array_specifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[165]) {
                    // 165: array_specifier : array_specifier '[' constant_expression ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var constant_expression1 = context.objStack.Pop() as constant_expression;
                    var @LeftBracket2 = context.objStack.Pop() as Token;
                    var array_specifier3 = context.objStack.Pop() as array_specifier;
                    var array_specifier = new array_specifier(/*array_specifier3, @LeftBracket2, constant_expression1, @RightBracket0*/);
                    context.objStack.Push(array_specifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.type_specifier_nonarray,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[166]) {
                    // 166: type_specifier_nonarray : 'void' ;
                    var @void0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@void0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[167]) {
                    // 167: type_specifier_nonarray : 'float' ;
                    var @float0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@float0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[168]) {
                    // 168: type_specifier_nonarray : 'double' ;
                    var @double0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@double0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[169]) {
                    // 169: type_specifier_nonarray : 'int' ;
                    var @int0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@int0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[170]) {
                    // 170: type_specifier_nonarray : 'uint' ;
                    var @uint0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uint0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[171]) {
                    // 171: type_specifier_nonarray : 'bool' ;
                    var @bool0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@bool0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[172]) {
                    // 172: type_specifier_nonarray : 'vec2' ;
                    var @vec20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@vec20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[173]) {
                    // 173: type_specifier_nonarray : 'vec3' ;
                    var @vec30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@vec30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[174]) {
                    // 174: type_specifier_nonarray : 'vec4' ;
                    var @vec40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@vec40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[175]) {
                    // 175: type_specifier_nonarray : 'dvec2' ;
                    var @dvec20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dvec20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[176]) {
                    // 176: type_specifier_nonarray : 'dvec3' ;
                    var @dvec30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dvec30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[177]) {
                    // 177: type_specifier_nonarray : 'dvec4' ;
                    var @dvec40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dvec40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[178]) {
                    // 178: type_specifier_nonarray : 'bvec2' ;
                    var @bvec20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@bvec20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[179]) {
                    // 179: type_specifier_nonarray : 'bvec3' ;
                    var @bvec30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@bvec30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[180]) {
                    // 180: type_specifier_nonarray : 'bvec4' ;
                    var @bvec40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@bvec40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[181]) {
                    // 181: type_specifier_nonarray : 'ivec2' ;
                    var @ivec20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@ivec20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[182]) {
                    // 182: type_specifier_nonarray : 'ivec3' ;
                    var @ivec30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@ivec30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[183]) {
                    // 183: type_specifier_nonarray : 'ivec4' ;
                    var @ivec40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@ivec40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[184]) {
                    // 184: type_specifier_nonarray : 'uvec2' ;
                    var @uvec20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uvec20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[185]) {
                    // 185: type_specifier_nonarray : 'uvec3' ;
                    var @uvec30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uvec30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[186]) {
                    // 186: type_specifier_nonarray : 'uvec4' ;
                    var @uvec40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uvec40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[187]) {
                    // 187: type_specifier_nonarray : 'mat2' ;
                    var @mat20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[188]) {
                    // 188: type_specifier_nonarray : 'mat3' ;
                    var @mat30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[189]) {
                    // 189: type_specifier_nonarray : 'mat4' ;
                    var @mat40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[190]) {
                    // 190: type_specifier_nonarray : 'mat2x2' ;
                    var @mat2x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat2x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[191]) {
                    // 191: type_specifier_nonarray : 'mat2x3' ;
                    var @mat2x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat2x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[192]) {
                    // 192: type_specifier_nonarray : 'mat2x4' ;
                    var @mat2x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat2x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[193]) {
                    // 193: type_specifier_nonarray : 'mat3x2' ;
                    var @mat3x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat3x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[194]) {
                    // 194: type_specifier_nonarray : 'mat3x3' ;
                    var @mat3x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat3x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[195]) {
                    // 195: type_specifier_nonarray : 'mat3x4' ;
                    var @mat3x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat3x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[196]) {
                    // 196: type_specifier_nonarray : 'mat4x2' ;
                    var @mat4x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat4x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[197]) {
                    // 197: type_specifier_nonarray : 'mat4x3' ;
                    var @mat4x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat4x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[198]) {
                    // 198: type_specifier_nonarray : 'mat4x4' ;
                    var @mat4x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@mat4x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[199]) {
                    // 199: type_specifier_nonarray : 'dmat2' ;
                    var @dmat20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[200]) {
                    // 200: type_specifier_nonarray : 'dmat3' ;
                    var @dmat30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[201]) {
                    // 201: type_specifier_nonarray : 'dmat4' ;
                    var @dmat40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[202]) {
                    // 202: type_specifier_nonarray : 'dmat2x2' ;
                    var @dmat2x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat2x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[203]) {
                    // 203: type_specifier_nonarray : 'dmat2x3' ;
                    var @dmat2x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat2x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[204]) {
                    // 204: type_specifier_nonarray : 'dmat2x4' ;
                    var @dmat2x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat2x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[205]) {
                    // 205: type_specifier_nonarray : 'dmat3x2' ;
                    var @dmat3x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat3x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[206]) {
                    // 206: type_specifier_nonarray : 'dmat3x3' ;
                    var @dmat3x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat3x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[207]) {
                    // 207: type_specifier_nonarray : 'dmat3x4' ;
                    var @dmat3x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat3x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[208]) {
                    // 208: type_specifier_nonarray : 'dmat4x2' ;
                    var @dmat4x20 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat4x20*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[209]) {
                    // 209: type_specifier_nonarray : 'dmat4x3' ;
                    var @dmat4x30 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat4x30*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[210]) {
                    // 210: type_specifier_nonarray : 'dmat4x4' ;
                    var @dmat4x40 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@dmat4x40*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[211]) {
                    // 211: type_specifier_nonarray : 'atomic_uint' ;
                    var @atomic_uint0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@atomic_uint0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[212]) {
                    // 212: type_specifier_nonarray : 'sampler1D' ;
                    var @sampler1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[213]) {
                    // 213: type_specifier_nonarray : 'sampler2D' ;
                    var @sampler2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[214]) {
                    // 214: type_specifier_nonarray : 'sampler3D' ;
                    var @sampler3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[215]) {
                    // 215: type_specifier_nonarray : 'samplerCube' ;
                    var @samplerCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@samplerCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[216]) {
                    // 216: type_specifier_nonarray : 'sampler1DShadow' ;
                    var @sampler1DShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler1DShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[217]) {
                    // 217: type_specifier_nonarray : 'sampler2DShadow' ;
                    var @sampler2DShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[218]) {
                    // 218: type_specifier_nonarray : 'samplerCubeShadow' ;
                    var @samplerCubeShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@samplerCubeShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[219]) {
                    // 219: type_specifier_nonarray : 'sampler1DArray' ;
                    var @sampler1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[220]) {
                    // 220: type_specifier_nonarray : 'sampler2DArray' ;
                    var @sampler2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[221]) {
                    // 221: type_specifier_nonarray : 'sampler1DArrayShadow' ;
                    var @sampler1DArrayShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler1DArrayShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[222]) {
                    // 222: type_specifier_nonarray : 'sampler2DArrayShadow' ;
                    var @sampler2DArrayShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DArrayShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[223]) {
                    // 223: type_specifier_nonarray : 'samplerCubeArray' ;
                    var @samplerCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@samplerCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[224]) {
                    // 224: type_specifier_nonarray : 'samplerCubeArrayShadow' ;
                    var @samplerCubeArrayShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@samplerCubeArrayShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[225]) {
                    // 225: type_specifier_nonarray : 'isampler1D' ;
                    var @isampler1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[226]) {
                    // 226: type_specifier_nonarray : 'isampler2D' ;
                    var @isampler2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[227]) {
                    // 227: type_specifier_nonarray : 'isampler3D' ;
                    var @isampler3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[228]) {
                    // 228: type_specifier_nonarray : 'isamplerCube' ;
                    var @isamplerCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isamplerCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[229]) {
                    // 229: type_specifier_nonarray : 'isampler1DArray' ;
                    var @isampler1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[230]) {
                    // 230: type_specifier_nonarray : 'isampler2DArray' ;
                    var @isampler2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[231]) {
                    // 231: type_specifier_nonarray : 'isamplerCubeArray' ;
                    var @isamplerCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isamplerCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[232]) {
                    // 232: type_specifier_nonarray : 'usampler1D' ;
                    var @usampler1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[233]) {
                    // 233: type_specifier_nonarray : 'usampler2D' ;
                    var @usampler2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[234]) {
                    // 234: type_specifier_nonarray : 'usampler3D' ;
                    var @usampler3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[235]) {
                    // 235: type_specifier_nonarray : 'usamplerCube' ;
                    var @usamplerCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usamplerCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[236]) {
                    // 236: type_specifier_nonarray : 'usampler1DArray' ;
                    var @usampler1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[237]) {
                    // 237: type_specifier_nonarray : 'usampler2DArray' ;
                    var @usampler2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[238]) {
                    // 238: type_specifier_nonarray : 'usamplerCubeArray' ;
                    var @usamplerCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usamplerCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[239]) {
                    // 239: type_specifier_nonarray : 'sampler2DRect' ;
                    var @sampler2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[240]) {
                    // 240: type_specifier_nonarray : 'sampler2DRectShadow' ;
                    var @sampler2DRectShadow0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DRectShadow0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[241]) {
                    // 241: type_specifier_nonarray : 'isampler2DRect' ;
                    var @isampler2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[242]) {
                    // 242: type_specifier_nonarray : 'usampler2DRect' ;
                    var @usampler2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[243]) {
                    // 243: type_specifier_nonarray : 'samplerBuffer' ;
                    var @samplerBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@samplerBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[244]) {
                    // 244: type_specifier_nonarray : 'isamplerBuffer' ;
                    var @isamplerBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isamplerBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[245]) {
                    // 245: type_specifier_nonarray : 'usamplerBuffer' ;
                    var @usamplerBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usamplerBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[246]) {
                    // 246: type_specifier_nonarray : 'sampler2DMS' ;
                    var @sampler2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[247]) {
                    // 247: type_specifier_nonarray : 'isampler2DMS' ;
                    var @isampler2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[248]) {
                    // 248: type_specifier_nonarray : 'usampler2DMS' ;
                    var @usampler2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[249]) {
                    // 249: type_specifier_nonarray : 'sampler2DMSArray' ;
                    var @sampler2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@sampler2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[250]) {
                    // 250: type_specifier_nonarray : 'isampler2DMSArray' ;
                    var @isampler2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@isampler2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[251]) {
                    // 251: type_specifier_nonarray : 'usampler2DMSArray' ;
                    var @usampler2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@usampler2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[252]) {
                    // 252: type_specifier_nonarray : 'image1D' ;
                    var @image1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[253]) {
                    // 253: type_specifier_nonarray : 'iimage1D' ;
                    var @iimage1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[254]) {
                    // 254: type_specifier_nonarray : 'uimage1D' ;
                    var @uimage1D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage1D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[255]) {
                    // 255: type_specifier_nonarray : 'image2D' ;
                    var @image2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[256]) {
                    // 256: type_specifier_nonarray : 'iimage2D' ;
                    var @iimage2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[257]) {
                    // 257: type_specifier_nonarray : 'uimage2D' ;
                    var @uimage2D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage2D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[258]) {
                    // 258: type_specifier_nonarray : 'image3D' ;
                    var @image3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[259]) {
                    // 259: type_specifier_nonarray : 'iimage3D' ;
                    var @iimage3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[260]) {
                    // 260: type_specifier_nonarray : 'uimage3D' ;
                    var @uimage3D0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage3D0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[261]) {
                    // 261: type_specifier_nonarray : 'image2DRect' ;
                    var @image2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[262]) {
                    // 262: type_specifier_nonarray : 'iimage2DRect' ;
                    var @iimage2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[263]) {
                    // 263: type_specifier_nonarray : 'uimage2DRect' ;
                    var @uimage2DRect0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage2DRect0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[264]) {
                    // 264: type_specifier_nonarray : 'imageCube' ;
                    var @imageCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@imageCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[265]) {
                    // 265: type_specifier_nonarray : 'iimageCube' ;
                    var @iimageCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimageCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[266]) {
                    // 266: type_specifier_nonarray : 'uimageCube' ;
                    var @uimageCube0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimageCube0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[267]) {
                    // 267: type_specifier_nonarray : 'imageBuffer' ;
                    var @imageBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@imageBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[268]) {
                    // 268: type_specifier_nonarray : 'iimageBuffer' ;
                    var @iimageBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimageBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[269]) {
                    // 269: type_specifier_nonarray : 'uimageBuffer' ;
                    var @uimageBuffer0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimageBuffer0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[270]) {
                    // 270: type_specifier_nonarray : 'image1DArray' ;
                    var @image1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[271]) {
                    // 271: type_specifier_nonarray : 'iimage1DArray' ;
                    var @iimage1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[272]) {
                    // 272: type_specifier_nonarray : 'uimage1DArray' ;
                    var @uimage1DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage1DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[273]) {
                    // 273: type_specifier_nonarray : 'image2DArray' ;
                    var @image2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[274]) {
                    // 274: type_specifier_nonarray : 'iimage2DArray' ;
                    var @iimage2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[275]) {
                    // 275: type_specifier_nonarray : 'uimage2DArray' ;
                    var @uimage2DArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage2DArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[276]) {
                    // 276: type_specifier_nonarray : 'imageCubeArray' ;
                    var @imageCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@imageCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[277]) {
                    // 277: type_specifier_nonarray : 'iimageCubeArray' ;
                    var @iimageCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimageCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[278]) {
                    // 278: type_specifier_nonarray : 'uimageCubeArray' ;
                    var @uimageCubeArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimageCubeArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[279]) {
                    // 279: type_specifier_nonarray : 'image2DMS' ;
                    var @image2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[280]) {
                    // 280: type_specifier_nonarray : 'iimage2DMS' ;
                    var @iimage2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[281]) {
                    // 281: type_specifier_nonarray : 'uimage2DMS' ;
                    var @uimage2DMS0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage2DMS0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[282]) {
                    // 282: type_specifier_nonarray : 'image2DMSArray' ;
                    var @image2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@image2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[283]) {
                    // 283: type_specifier_nonarray : 'iimage2DMSArray' ;
                    var @iimage2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@iimage2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[284]) {
                    // 284: type_specifier_nonarray : 'uimage2DMSArray' ;
                    var @uimage2DMSArray0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@uimage2DMSArray0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[285]) {
                    // 285: type_specifier_nonarray : struct_specifier ;
                    var struct_specifier0 = context.objStack.Pop() as struct_specifier;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*struct_specifier0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else if (node.regulation == CompilerGLSL.regulations[286]) {
                    // 286: type_specifier_nonarray : 'userDefinedType' ;
                    var @userDefinedType0 = context.objStack.Pop() as Token;
                    var type_specifier_nonarray = new type_specifier_nonarray(/*@userDefinedType0*/);
                    context.objStack.Push(type_specifier_nonarray);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.precision_qualifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[287]) {
                    // 287: precision_qualifier : 'high_precision' ;
                    var @high_precision0 = context.objStack.Pop() as Token;
                    var precision_qualifier = new precision_qualifier(/*@high_precision0*/);
                    context.objStack.Push(precision_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[288]) {
                    // 288: precision_qualifier : 'medium_precision' ;
                    var @medium_precision0 = context.objStack.Pop() as Token;
                    var precision_qualifier = new precision_qualifier(/*@medium_precision0*/);
                    context.objStack.Push(precision_qualifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[289]) {
                    // 289: precision_qualifier : 'low_precision' ;
                    var @low_precision0 = context.objStack.Pop() as Token;
                    var precision_qualifier = new precision_qualifier(/*@low_precision0*/);
                    context.objStack.Push(precision_qualifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.struct_specifier,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[290]) {
                    // 290: struct_specifier : 'struct' type_name '{' struct_declaration_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var struct_declaration_list1 = context.objStack.Pop() as struct_declaration_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var type_name3 = context.objStack.Pop() as type_name;
                    var @struct4 = context.objStack.Pop() as Token;
                    var struct_specifier = new struct_specifier(/*@struct4, type_name3, @LeftBrace2, struct_declaration_list1, @RightBrace0*/);
                    context.objStack.Push(struct_specifier);
                }
                else if (node.regulation == CompilerGLSL.regulations[292]) {
                    // 292: struct_specifier : 'struct' '{' struct_declaration_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var struct_declaration_list1 = context.objStack.Pop() as struct_declaration_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var @struct3 = context.objStack.Pop() as Token;
                    var struct_specifier = new struct_specifier(/*@struct3, @LeftBrace2, struct_declaration_list1, @RightBrace0*/);
                    context.objStack.Push(struct_specifier);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.type_name,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[291]) {
                    // 291: type_name : 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var type_name = new type_name(/*@identifier0*/);
                    context.objStack.Push(type_name);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.struct_declaration_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[293]) {
                    // 293: struct_declaration_list : struct_declaration ;
                    var struct_declaration0 = context.objStack.Pop() as struct_declaration;
                    var struct_declaration_list = new struct_declaration_list(/*struct_declaration0*/);
                    context.objStack.Push(struct_declaration_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[294]) {
                    // 294: struct_declaration_list : struct_declaration_list struct_declaration ;
                    var struct_declaration0 = context.objStack.Pop() as struct_declaration;
                    var struct_declaration_list1 = context.objStack.Pop() as struct_declaration_list;
                    var struct_declaration_list = new struct_declaration_list(/*struct_declaration_list1, struct_declaration0*/);
                    context.objStack.Push(struct_declaration_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.struct_declaration,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[295]) {
                    // 295: struct_declaration : type_specifier struct_declarator_list ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var struct_declarator_list1 = context.objStack.Pop() as struct_declarator_list;
                    var type_specifier2 = context.objStack.Pop() as type_specifier;
                    var struct_declaration = new struct_declaration(/*type_specifier2, struct_declarator_list1, @Semicolon0*/);
                    context.objStack.Push(struct_declaration);
                }
                else if (node.regulation == CompilerGLSL.regulations[296]) {
                    // 296: struct_declaration : type_qualifier type_specifier struct_declarator_list ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var struct_declarator_list1 = context.objStack.Pop() as struct_declarator_list;
                    var type_specifier2 = context.objStack.Pop() as type_specifier;
                    var type_qualifier3 = context.objStack.Pop() as type_qualifier;
                    var struct_declaration = new struct_declaration(/*type_qualifier3, type_specifier2, struct_declarator_list1, @Semicolon0*/);
                    context.objStack.Push(struct_declaration);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.struct_declarator_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[297]) {
                    // 297: struct_declarator_list : struct_declarator ;
                    var struct_declarator0 = context.objStack.Pop() as struct_declarator;
                    var struct_declarator_list = new struct_declarator_list(/*struct_declarator0*/);
                    context.objStack.Push(struct_declarator_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[298]) {
                    // 298: struct_declarator_list : struct_declarator_list ',' struct_declarator ;
                    var struct_declarator0 = context.objStack.Pop() as struct_declarator;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var struct_declarator_list2 = context.objStack.Pop() as struct_declarator_list;
                    var struct_declarator_list = new struct_declarator_list(/*struct_declarator_list2, @Comma1, struct_declarator0*/);
                    context.objStack.Push(struct_declarator_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.struct_declarator,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[299]) {
                    // 299: struct_declarator : 'identifier' ;
                    var @identifier0 = context.objStack.Pop() as Token;
                    var struct_declarator = new struct_declarator(/*@identifier0*/);
                    context.objStack.Push(struct_declarator);
                }
                else if (node.regulation == CompilerGLSL.regulations[300]) {
                    // 300: struct_declarator : 'identifier' array_specifier ;
                    var array_specifier0 = context.objStack.Pop() as array_specifier;
                    var @identifier1 = context.objStack.Pop() as Token;
                    var struct_declarator = new struct_declarator(/*@identifier1, array_specifier0*/);
                    context.objStack.Push(struct_declarator);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.initializer,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[301]) {
                    // 301: initializer : assignment_expression ;
                    var assignment_expression0 = context.objStack.Pop() as assignment_expression;
                    var initializer = new initializer(/*assignment_expression0*/);
                    context.objStack.Push(initializer);
                }
                else if (node.regulation == CompilerGLSL.regulations[302]) {
                    // 302: initializer : '{' initializer_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var initializer_list1 = context.objStack.Pop() as initializer_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var initializer = new initializer(/*@LeftBrace2, initializer_list1, @RightBrace0*/);
                    context.objStack.Push(initializer);
                }
                else if (node.regulation == CompilerGLSL.regulations[303]) {
                    // 303: initializer : '{' initializer_list ',' '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var initializer_list2 = context.objStack.Pop() as initializer_list;
                    var @LeftBrace3 = context.objStack.Pop() as Token;
                    var initializer = new initializer(/*@LeftBrace3, initializer_list2, @Comma1, @RightBrace0*/);
                    context.objStack.Push(initializer);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.initializer_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[304]) {
                    // 304: initializer_list : initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var initializer_list = new initializer_list(/*initializer0*/);
                    context.objStack.Push(initializer_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[305]) {
                    // 305: initializer_list : initializer_list ',' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var initializer_list2 = context.objStack.Pop() as initializer_list;
                    var initializer_list = new initializer_list(/*initializer_list2, @Comma1, initializer0*/);
                    context.objStack.Push(initializer_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.declaration_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[306]) {
                    // 306: declaration_statement : declaration ;
                    var declaration0 = context.objStack.Pop() as declaration;
                    var declaration_statement = new declaration_statement(/*declaration0*/);
                    context.objStack.Push(declaration_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[307]) {
                    // 307: statement : compound_statement ;
                    var compound_statement0 = context.objStack.Pop() as compound_statement;
                    var statement = new statement(/*compound_statement0*/);
                    context.objStack.Push(statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[308]) {
                    // 308: statement : simple_statement ;
                    var simple_statement0 = context.objStack.Pop() as simple_statement;
                    var statement = new statement(/*simple_statement0*/);
                    context.objStack.Push(statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.simple_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[309]) {
                    // 309: simple_statement : declaration_statement ;
                    var declaration_statement0 = context.objStack.Pop() as declaration_statement;
                    var simple_statement = new simple_statement(/*declaration_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[310]) {
                    // 310: simple_statement : expression_statement ;
                    var expression_statement0 = context.objStack.Pop() as expression_statement;
                    var simple_statement = new simple_statement(/*expression_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[311]) {
                    // 311: simple_statement : selection_statement ;
                    var selection_statement0 = context.objStack.Pop() as selection_statement;
                    var simple_statement = new simple_statement(/*selection_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[312]) {
                    // 312: simple_statement : switch_statement ;
                    var switch_statement0 = context.objStack.Pop() as switch_statement;
                    var simple_statement = new simple_statement(/*switch_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[313]) {
                    // 313: simple_statement : case_label ;
                    var case_label0 = context.objStack.Pop() as case_label;
                    var simple_statement = new simple_statement(/*case_label0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[314]) {
                    // 314: simple_statement : iteration_statement ;
                    var iteration_statement0 = context.objStack.Pop() as iteration_statement;
                    var simple_statement = new simple_statement(/*iteration_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[315]) {
                    // 315: simple_statement : jump_statement ;
                    var jump_statement0 = context.objStack.Pop() as jump_statement;
                    var simple_statement = new simple_statement(/*jump_statement0*/);
                    context.objStack.Push(simple_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.compound_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[316]) {
                    // 316: compound_statement : '{' '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var @LeftBrace1 = context.objStack.Pop() as Token;
                    var compound_statement = new compound_statement(/*@LeftBrace1, @RightBrace0*/);
                    context.objStack.Push(compound_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[317]) {
                    // 317: compound_statement : '{' statement_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var statement_list1 = context.objStack.Pop() as statement_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var compound_statement = new compound_statement(/*@LeftBrace2, statement_list1, @RightBrace0*/);
                    context.objStack.Push(compound_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.statement_no_new_scope,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[318]) {
                    // 318: statement_no_new_scope : compound_statement_no_new_scope ;
                    var compound_statement_no_new_scope0 = context.objStack.Pop() as compound_statement_no_new_scope;
                    var statement_no_new_scope = new statement_no_new_scope(/*compound_statement_no_new_scope0*/);
                    context.objStack.Push(statement_no_new_scope);
                }
                else if (node.regulation == CompilerGLSL.regulations[319]) {
                    // 319: statement_no_new_scope : simple_statement ;
                    var simple_statement0 = context.objStack.Pop() as simple_statement;
                    var statement_no_new_scope = new statement_no_new_scope(/*simple_statement0*/);
                    context.objStack.Push(statement_no_new_scope);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.compound_statement_no_new_scope,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[320]) {
                    // 320: compound_statement_no_new_scope : '{' '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var @LeftBrace1 = context.objStack.Pop() as Token;
                    var compound_statement_no_new_scope = new compound_statement_no_new_scope(/*@LeftBrace1, @RightBrace0*/);
                    context.objStack.Push(compound_statement_no_new_scope);
                }
                else if (node.regulation == CompilerGLSL.regulations[321]) {
                    // 321: compound_statement_no_new_scope : '{' statement_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var statement_list1 = context.objStack.Pop() as statement_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var compound_statement_no_new_scope = new compound_statement_no_new_scope(/*@LeftBrace2, statement_list1, @RightBrace0*/);
                    context.objStack.Push(compound_statement_no_new_scope);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.statement_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[322]) {
                    // 322: statement_list : statement ;
                    var statement0 = context.objStack.Pop() as statement;
                    var statement_list = new statement_list(/*statement0*/);
                    context.objStack.Push(statement_list);
                }
                else if (node.regulation == CompilerGLSL.regulations[323]) {
                    // 323: statement_list : statement_list statement ;
                    var statement0 = context.objStack.Pop() as statement;
                    var statement_list1 = context.objStack.Pop() as statement_list;
                    var statement_list = new statement_list(/*statement_list1, statement0*/);
                    context.objStack.Push(statement_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.expression_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[324]) {
                    // 324: expression_statement : ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var expression_statement = new expression_statement(/*@Semicolon0*/);
                    context.objStack.Push(expression_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[325]) {
                    // 325: expression_statement : expression ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var expression1 = context.objStack.Pop() as expression;
                    var expression_statement = new expression_statement(/*expression1, @Semicolon0*/);
                    context.objStack.Push(expression_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.selection_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[326]) {
                    // 326: selection_statement : 'if' '(' expression ')' selection_rest_statement ;
                    var selection_rest_statement0 = context.objStack.Pop() as selection_rest_statement;
                    var @RightParenthesis1 = context.objStack.Pop() as Token;
                    var expression2 = context.objStack.Pop() as expression;
                    var @LeftParenthesis3 = context.objStack.Pop() as Token;
                    var @if4 = context.objStack.Pop() as Token;
                    var selection_statement = new selection_statement(/*@if4, @LeftParenthesis3, expression2, @RightParenthesis1, selection_rest_statement0*/);
                    context.objStack.Push(selection_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.selection_rest_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[327]) {
                    // 327: selection_rest_statement : statement 'else' statement ;
                    var statement0 = context.objStack.Pop() as statement;
                    var @else1 = context.objStack.Pop() as Token;
                    var statement2 = context.objStack.Pop() as statement;
                    var selection_rest_statement = new selection_rest_statement(/*statement2, @else1, statement0*/);
                    context.objStack.Push(selection_rest_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[328]) {
                    // 328: selection_rest_statement : statement ;
                    var statement0 = context.objStack.Pop() as statement;
                    var selection_rest_statement = new selection_rest_statement(/*statement0*/);
                    context.objStack.Push(selection_rest_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.condition,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[329]) {
                    // 329: condition : expression ;
                    var expression0 = context.objStack.Pop() as expression;
                    var condition = new condition(/*expression0*/);
                    context.objStack.Push(condition);
                }
                else if (node.regulation == CompilerGLSL.regulations[330]) {
                    // 330: condition : fully_specified_type 'identifier' '=' initializer ;
                    var initializer0 = context.objStack.Pop() as initializer;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var @identifier2 = context.objStack.Pop() as Token;
                    var fully_specified_type3 = context.objStack.Pop() as fully_specified_type;
                    var condition = new condition(/*fully_specified_type3, @identifier2, @Equal1, initializer0*/);
                    context.objStack.Push(condition);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.switch_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[331]) {
                    // 331: switch_statement : 'switch' '(' expression ')' '{' switch_statement_list '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var switch_statement_list1 = context.objStack.Pop() as switch_statement_list;
                    var @LeftBrace2 = context.objStack.Pop() as Token;
                    var @RightParenthesis3 = context.objStack.Pop() as Token;
                    var expression4 = context.objStack.Pop() as expression;
                    var @LeftParenthesis5 = context.objStack.Pop() as Token;
                    var @switch6 = context.objStack.Pop() as Token;
                    var switch_statement = new switch_statement(/*@switch6, @LeftParenthesis5, expression4, @RightParenthesis3, @LeftBrace2, switch_statement_list1, @RightBrace0*/);
                    context.objStack.Push(switch_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.switch_statement_list,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[332]) {
                    // 332: switch_statement_list : statement_list ;
                    var statement_list0 = context.objStack.Pop() as statement_list;
                    var switch_statement_list = new switch_statement_list(/*statement_list0*/);
                    context.objStack.Push(switch_statement_list);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.case_label,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[333]) {
                    // 333: case_label : 'case' expression ':' ;
                    var @Colon0 = context.objStack.Pop() as Token;
                    var expression1 = context.objStack.Pop() as expression;
                    var @case2 = context.objStack.Pop() as Token;
                    var case_label = new case_label(/*@case2, expression1, @Colon0*/);
                    context.objStack.Push(case_label);
                }
                else if (node.regulation == CompilerGLSL.regulations[334]) {
                    // 334: case_label : 'default' ':' ;
                    var @Colon0 = context.objStack.Pop() as Token;
                    var @default1 = context.objStack.Pop() as Token;
                    var case_label = new case_label(/*@default1, @Colon0*/);
                    context.objStack.Push(case_label);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.iteration_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[335]) {
                    // 335: iteration_statement : 'while' '(' condition ')' statement_no_new_scope ;
                    var statement_no_new_scope0 = context.objStack.Pop() as statement_no_new_scope;
                    var @RightParenthesis1 = context.objStack.Pop() as Token;
                    var condition2 = context.objStack.Pop() as condition;
                    var @LeftParenthesis3 = context.objStack.Pop() as Token;
                    var @while4 = context.objStack.Pop() as Token;
                    var iteration_statement = new iteration_statement(/*@while4, @LeftParenthesis3, condition2, @RightParenthesis1, statement_no_new_scope0*/);
                    context.objStack.Push(iteration_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[336]) {
                    // 336: iteration_statement : 'do' statement 'while' '(' expression ')' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @RightParenthesis1 = context.objStack.Pop() as Token;
                    var expression2 = context.objStack.Pop() as expression;
                    var @LeftParenthesis3 = context.objStack.Pop() as Token;
                    var @while4 = context.objStack.Pop() as Token;
                    var statement5 = context.objStack.Pop() as statement;
                    var @do6 = context.objStack.Pop() as Token;
                    var iteration_statement = new iteration_statement(/*@do6, statement5, @while4, @LeftParenthesis3, expression2, @RightParenthesis1, @Semicolon0*/);
                    context.objStack.Push(iteration_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[337]) {
                    // 337: iteration_statement : 'for' '(' for_init_statement for_rest_statement ')' statement_no_new_scope ;
                    var statement_no_new_scope0 = context.objStack.Pop() as statement_no_new_scope;
                    var @RightParenthesis1 = context.objStack.Pop() as Token;
                    var for_rest_statement2 = context.objStack.Pop() as for_rest_statement;
                    var for_init_statement3 = context.objStack.Pop() as for_init_statement;
                    var @LeftParenthesis4 = context.objStack.Pop() as Token;
                    var @for5 = context.objStack.Pop() as Token;
                    var iteration_statement = new iteration_statement(/*@for5, @LeftParenthesis4, for_init_statement3, for_rest_statement2, @RightParenthesis1, statement_no_new_scope0*/);
                    context.objStack.Push(iteration_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.for_init_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[338]) {
                    // 338: for_init_statement : expression_statement ;
                    var expression_statement0 = context.objStack.Pop() as expression_statement;
                    var for_init_statement = new for_init_statement(/*expression_statement0*/);
                    context.objStack.Push(for_init_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[339]) {
                    // 339: for_init_statement : declaration_statement ;
                    var declaration_statement0 = context.objStack.Pop() as declaration_statement;
                    var for_init_statement = new for_init_statement(/*declaration_statement0*/);
                    context.objStack.Push(for_init_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.conditionopt,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[340]) {
                    // 340: conditionopt : condition ;
                    var condition0 = context.objStack.Pop() as condition;
                    var conditionopt = new conditionopt(/*condition0*/);
                    context.objStack.Push(conditionopt);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.for_rest_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[341]) {
                    // 341: for_rest_statement : conditionopt ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var conditionopt1 = context.objStack.Pop() as conditionopt;
                    var for_rest_statement = new for_rest_statement(/*conditionopt1, @Semicolon0*/);
                    context.objStack.Push(for_rest_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[342]) {
                    // 342: for_rest_statement : conditionopt ';' expression ;
                    var expression0 = context.objStack.Pop() as expression;
                    var @Semicolon1 = context.objStack.Pop() as Token;
                    var conditionopt2 = context.objStack.Pop() as conditionopt;
                    var for_rest_statement = new for_rest_statement(/*conditionopt2, @Semicolon1, expression0*/);
                    context.objStack.Push(for_rest_statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.jump_statement,
            (node, context) => {
                if (node.regulation == CompilerGLSL.regulations[343]) {
                    // 343: jump_statement : 'continue' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @continue1 = context.objStack.Pop() as Token;
                    var jump_statement = new jump_statement(/*@continue1, @Semicolon0*/);
                    context.objStack.Push(jump_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[344]) {
                    // 344: jump_statement : 'break' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @break1 = context.objStack.Pop() as Token;
                    var jump_statement = new jump_statement(/*@break1, @Semicolon0*/);
                    context.objStack.Push(jump_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[345]) {
                    // 345: jump_statement : 'return' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @return1 = context.objStack.Pop() as Token;
                    var jump_statement = new jump_statement(/*@return1, @Semicolon0*/);
                    context.objStack.Push(jump_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[346]) {
                    // 346: jump_statement : 'return' expression ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var expression1 = context.objStack.Pop() as expression;
                    var @return2 = context.objStack.Pop() as Token;
                    var jump_statement = new jump_statement(/*@return2, expression1, @Semicolon0*/);
                    context.objStack.Push(jump_statement);
                }
                else if (node.regulation == CompilerGLSL.regulations[347]) {
                    // 347: jump_statement : 'discard' ';' ;
                    var @Semicolon0 = context.objStack.Pop() as Token;
                    var @discard1 = context.objStack.Pop() as Token;
                    var jump_statement = new jump_statement(/*@discard1, @Semicolon0*/);
                    context.objStack.Push(jump_statement);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}