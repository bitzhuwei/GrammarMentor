using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: translation_unit : external_declaration ;
            new Regulation(EType.translation_unit, EType.external_declaration), 
            // 1: translation_unit : translation_unit external_declaration ;
            new Regulation(EType.translation_unit, EType.translation_unit, EType.external_declaration), 
            // 2: external_declaration : function_definition ;
            new Regulation(EType.external_declaration, EType.function_definition), 
            // 3: external_declaration : declaration ;
            new Regulation(EType.external_declaration, EType.declaration), 
            // 4: function_definition : function_prototype compound_statement_no_new_scope ;
            new Regulation(EType.function_definition, EType.function_prototype, EType.compound_statement_no_new_scope), 
            // 5: variable_identifier : 'identifier' ;
            new Regulation(EType.variable_identifier, EType.@identifier), 
            // 6: primary_expression : variable_identifier ;
            new Regulation(EType.primary_expression, EType.variable_identifier), 
            // 7: primary_expression : 'number' ;
            new Regulation(EType.primary_expression, EType.@number), 
            // 8: primary_expression : BOOLCONSTANT ;
            new Regulation(EType.primary_expression, EType.BOOLCONSTANT), 
            // 9: primary_expression : '(' expression ')' ;
            new Regulation(EType.primary_expression, EType.@LeftParenthesis, EType.expression, EType.@RightParenthesis), 
            // 10: BOOLCONSTANT : 'true' ;
            new Regulation(EType.BOOLCONSTANT, EType.@true), 
            // 11: BOOLCONSTANT : 'false' ;
            new Regulation(EType.BOOLCONSTANT, EType.@false), 
            // 12: postfix_expression : primary_expression ;
            new Regulation(EType.postfix_expression, EType.primary_expression), 
            // 13: postfix_expression : postfix_expression '[' integer_expression ']' ;
            new Regulation(EType.postfix_expression, EType.postfix_expression, EType.@LeftBracket, EType.integer_expression, EType.@RightBracket), 
            // 14: postfix_expression : function_call ;
            new Regulation(EType.postfix_expression, EType.function_call), 
            // 15: postfix_expression : postfix_expression '.' FIELD_SELECTION ;
            new Regulation(EType.postfix_expression, EType.postfix_expression, EType.@Dot, EType.FIELD_SELECTION), 
            // 16: postfix_expression : postfix_expression '++' ;
            new Regulation(EType.postfix_expression, EType.postfix_expression, EType.@PlusPlus), 
            // 17: postfix_expression : postfix_expression '--' ;
            new Regulation(EType.postfix_expression, EType.postfix_expression, EType.@DashDash), 
            // 18: FIELD_SELECTION : 'identifier' ;
            new Regulation(EType.FIELD_SELECTION, EType.@identifier), 
            // 19: integer_expression : expression ;
            new Regulation(EType.integer_expression, EType.expression), 
            // 20: function_call : function_call_or_method ;
            new Regulation(EType.function_call, EType.function_call_or_method), 
            // 21: function_call_or_method : function_call_generic ;
            new Regulation(EType.function_call_or_method, EType.function_call_generic), 
            // 22: function_call_generic : function_call_header_with_parameters ')' ;
            new Regulation(EType.function_call_generic, EType.function_call_header_with_parameters, EType.@RightParenthesis), 
            // 23: function_call_generic : function_call_header_no_parameters ')' ;
            new Regulation(EType.function_call_generic, EType.function_call_header_no_parameters, EType.@RightParenthesis), 
            // 24: function_call_header_no_parameters : function_call_header 'void' ;
            new Regulation(EType.function_call_header_no_parameters, EType.function_call_header, EType.@void), 
            // 25: function_call_header_no_parameters : function_call_header ;
            new Regulation(EType.function_call_header_no_parameters, EType.function_call_header), 
            // 26: function_call_header_with_parameters : function_call_header assignment_expression ;
            new Regulation(EType.function_call_header_with_parameters, EType.function_call_header, EType.assignment_expression), 
            // 27: function_call_header_with_parameters : function_call_header_with_parameters ',' assignment_expression ;
            new Regulation(EType.function_call_header_with_parameters, EType.function_call_header_with_parameters, EType.@Comma, EType.assignment_expression), 
            // 28: function_call_header : function_identifier '(' ;
            new Regulation(EType.function_call_header, EType.function_identifier, EType.@LeftParenthesis), 
            // 29: function_identifier : type_specifier ;
            new Regulation(EType.function_identifier, EType.type_specifier), 
            // 30: function_identifier : postfix_expression ;
            new Regulation(EType.function_identifier, EType.postfix_expression), 
            // 31: unary_expression : postfix_expression ;
            new Regulation(EType.unary_expression, EType.postfix_expression), 
            // 32: unary_expression : '++' unary_expression ;
            new Regulation(EType.unary_expression, EType.@PlusPlus, EType.unary_expression), 
            // 33: unary_expression : '--' unary_expression ;
            new Regulation(EType.unary_expression, EType.@DashDash, EType.unary_expression), 
            // 34: unary_expression : unary_operator unary_expression ;
            new Regulation(EType.unary_expression, EType.unary_operator, EType.unary_expression), 
            // 35: unary_operator : '+' ;
            new Regulation(EType.unary_operator, EType.@Plus), 
            // 36: unary_operator : '-' ;
            new Regulation(EType.unary_operator, EType.@Dash), 
            // 37: unary_operator : '!' ;
            new Regulation(EType.unary_operator, EType.@Bang), 
            // 38: unary_operator : '~' ;
            new Regulation(EType.unary_operator, EType.@Tilde), 
            // 39: multiplicative_expression : unary_expression ;
            new Regulation(EType.multiplicative_expression, EType.unary_expression), 
            // 40: multiplicative_expression : multiplicative_expression '*' unary_expression ;
            new Regulation(EType.multiplicative_expression, EType.multiplicative_expression, EType.@Asterisk, EType.unary_expression), 
            // 41: multiplicative_expression : multiplicative_expression '/' unary_expression ;
            new Regulation(EType.multiplicative_expression, EType.multiplicative_expression, EType.@Slash, EType.unary_expression), 
            // 42: multiplicative_expression : multiplicative_expression '%' unary_expression ;
            new Regulation(EType.multiplicative_expression, EType.multiplicative_expression, EType.@Percent, EType.unary_expression), 
            // 43: additive_expression : multiplicative_expression ;
            new Regulation(EType.additive_expression, EType.multiplicative_expression), 
            // 44: additive_expression : additive_expression '+' multiplicative_expression ;
            new Regulation(EType.additive_expression, EType.additive_expression, EType.@Plus, EType.multiplicative_expression), 
            // 45: additive_expression : additive_expression '-' multiplicative_expression ;
            new Regulation(EType.additive_expression, EType.additive_expression, EType.@Dash, EType.multiplicative_expression), 
            // 46: shift_expression : additive_expression ;
            new Regulation(EType.shift_expression, EType.additive_expression), 
            // 47: shift_expression : shift_expression '<<' additive_expression ;
            new Regulation(EType.shift_expression, EType.shift_expression, EType.@LeftAngleLeftAngle, EType.additive_expression), 
            // 48: shift_expression : shift_expression '>>' additive_expression ;
            new Regulation(EType.shift_expression, EType.shift_expression, EType.@RightAngleRightAngle, EType.additive_expression), 
            // 49: relational_expression : shift_expression ;
            new Regulation(EType.relational_expression, EType.shift_expression), 
            // 50: relational_expression : relational_expression '<' shift_expression ;
            new Regulation(EType.relational_expression, EType.relational_expression, EType.@LeftAngle, EType.shift_expression), 
            // 51: relational_expression : relational_expression '>' shift_expression ;
            new Regulation(EType.relational_expression, EType.relational_expression, EType.@RightAngle, EType.shift_expression), 
            // 52: relational_expression : relational_expression '<=' shift_expression ;
            new Regulation(EType.relational_expression, EType.relational_expression, EType.@LeftAngleEqual, EType.shift_expression), 
            // 53: relational_expression : relational_expression '>=' shift_expression ;
            new Regulation(EType.relational_expression, EType.relational_expression, EType.@RightAngleEqual, EType.shift_expression), 
            // 54: equality_expression : relational_expression ;
            new Regulation(EType.equality_expression, EType.relational_expression), 
            // 55: equality_expression : equality_expression '==' relational_expression ;
            new Regulation(EType.equality_expression, EType.equality_expression, EType.@EqualEqual, EType.relational_expression), 
            // 56: equality_expression : equality_expression '!=' relational_expression ;
            new Regulation(EType.equality_expression, EType.equality_expression, EType.@BangEqual, EType.relational_expression), 
            // 57: and_expression : equality_expression ;
            new Regulation(EType.and_expression, EType.equality_expression), 
            // 58: and_expression : and_expression '&' equality_expression ;
            new Regulation(EType.and_expression, EType.and_expression, EType.@And, EType.equality_expression), 
            // 59: exclusive_or_expression : and_expression ;
            new Regulation(EType.exclusive_or_expression, EType.and_expression), 
            // 60: exclusive_or_expression : exclusive_or_expression '^' and_expression ;
            new Regulation(EType.exclusive_or_expression, EType.exclusive_or_expression, EType.@Caret, EType.and_expression), 
            // 61: inclusive_or_expression : exclusive_or_expression ;
            new Regulation(EType.inclusive_or_expression, EType.exclusive_or_expression), 
            // 62: inclusive_or_expression : inclusive_or_expression '|' exclusive_or_expression ;
            new Regulation(EType.inclusive_or_expression, EType.inclusive_or_expression, EType.@Pipe, EType.exclusive_or_expression), 
            // 63: logical_and_expression : inclusive_or_expression ;
            new Regulation(EType.logical_and_expression, EType.inclusive_or_expression), 
            // 64: logical_and_expression : logical_and_expression '&&' inclusive_or_expression ;
            new Regulation(EType.logical_and_expression, EType.logical_and_expression, EType.@AndAnd, EType.inclusive_or_expression), 
            // 65: logical_xor_expression : logical_and_expression ;
            new Regulation(EType.logical_xor_expression, EType.logical_and_expression), 
            // 66: logical_xor_expression : logical_xor_expression '^^' logical_and_expression ;
            new Regulation(EType.logical_xor_expression, EType.logical_xor_expression, EType.@CaretCaret, EType.logical_and_expression), 
            // 67: logical_or_expression : logical_xor_expression ;
            new Regulation(EType.logical_or_expression, EType.logical_xor_expression), 
            // 68: logical_or_expression : logical_or_expression '||' logical_xor_expression ;
            new Regulation(EType.logical_or_expression, EType.logical_or_expression, EType.@PipePipe, EType.logical_xor_expression), 
            // 69: conditional_expression : logical_or_expression ;
            new Regulation(EType.conditional_expression, EType.logical_or_expression), 
            // 70: conditional_expression : logical_or_expression '?' expression ':' assignment_expression ;
            new Regulation(EType.conditional_expression, EType.logical_or_expression, EType.@Question, EType.expression, EType.@Colon, EType.assignment_expression), 
            // 71: assignment_expression : conditional_expression ;
            new Regulation(EType.assignment_expression, EType.conditional_expression), 
            // 72: assignment_expression : unary_expression assignment_operator assignment_expression ;
            new Regulation(EType.assignment_expression, EType.unary_expression, EType.assignment_operator, EType.assignment_expression), 
            // 73: assignment_operator : '=' ;
            new Regulation(EType.assignment_operator, EType.@Equal), 
            // 74: assignment_operator : '*=' ;
            new Regulation(EType.assignment_operator, EType.@AsteriskEqual), 
            // 75: assignment_operator : '/=' ;
            new Regulation(EType.assignment_operator, EType.@SlashEqual), 
            // 76: assignment_operator : '%=' ;
            new Regulation(EType.assignment_operator, EType.@PercentEqual), 
            // 77: assignment_operator : '+=' ;
            new Regulation(EType.assignment_operator, EType.@PlusEqual), 
            // 78: assignment_operator : '-=' ;
            new Regulation(EType.assignment_operator, EType.@DashEqual), 
            // 79: assignment_operator : '<<=' ;
            new Regulation(EType.assignment_operator, EType.@LeftAngleLeftAngleEqual), 
            // 80: assignment_operator : '>>=' ;
            new Regulation(EType.assignment_operator, EType.@RightAngleRightAngleEqual), 
            // 81: assignment_operator : '&=' ;
            new Regulation(EType.assignment_operator, EType.@AndEqual), 
            // 82: assignment_operator : '^=' ;
            new Regulation(EType.assignment_operator, EType.@CaretEqual), 
            // 83: assignment_operator : '|=' ;
            new Regulation(EType.assignment_operator, EType.@PipeEqual), 
            // 84: expression : assignment_expression ;
            new Regulation(EType.expression, EType.assignment_expression), 
            // 85: expression : expression ',' assignment_expression ;
            new Regulation(EType.expression, EType.expression, EType.@Comma, EType.assignment_expression), 
            // 86: constant_expression : conditional_expression ;
            new Regulation(EType.constant_expression, EType.conditional_expression), 
            // 87: declaration : function_prototype ';' ;
            new Regulation(EType.declaration, EType.function_prototype, EType.@Semicolon), 
            // 88: declaration : init_declarator_list ';' ;
            new Regulation(EType.declaration, EType.init_declarator_list, EType.@Semicolon), 
            // 89: declaration : 'precision' precision_qualifier type_specifier ';' ;
            new Regulation(EType.declaration, EType.@precision, EType.precision_qualifier, EType.type_specifier, EType.@Semicolon), 
            // 90: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@identifier, EType.@LeftBrace, EType.struct_declaration_list, EType.@RightBrace, EType.@Semicolon), 
            // 91: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' 'identifier' ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@identifier, EType.@LeftBrace, EType.struct_declaration_list, EType.@RightBrace, EType.@identifier, EType.@Semicolon), 
            // 92: declaration : type_qualifier 'identifier' '{' struct_declaration_list '}' 'identifier' array_specifier ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@identifier, EType.@LeftBrace, EType.struct_declaration_list, EType.@RightBrace, EType.@identifier, EType.array_specifier, EType.@Semicolon), 
            // 93: declaration : type_qualifier ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@Semicolon), 
            // 94: declaration : type_qualifier 'identifier' ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@identifier, EType.@Semicolon), 
            // 95: declaration : type_qualifier 'identifier' identifier_list ';' ;
            new Regulation(EType.declaration, EType.type_qualifier, EType.@identifier, EType.identifier_list, EType.@Semicolon), 
            // 96: identifier_list : ',' 'identifier' ;
            new Regulation(EType.identifier_list, EType.@Comma, EType.@identifier), 
            // 97: identifier_list : identifier_list ',' 'identifier' ;
            new Regulation(EType.identifier_list, EType.identifier_list, EType.@Comma, EType.@identifier), 
            // 98: function_prototype : function_declarator ')' ;
            new Regulation(EType.function_prototype, EType.function_declarator, EType.@RightParenthesis), 
            // 99: function_declarator : function_header ;
            new Regulation(EType.function_declarator, EType.function_header), 
            // 100: function_declarator : function_header_with_parameters ;
            new Regulation(EType.function_declarator, EType.function_header_with_parameters), 
            // 101: function_header_with_parameters : function_header parameter_declaration ;
            new Regulation(EType.function_header_with_parameters, EType.function_header, EType.parameter_declaration), 
            // 102: function_header_with_parameters : function_header_with_parameters ',' parameter_declaration ;
            new Regulation(EType.function_header_with_parameters, EType.function_header_with_parameters, EType.@Comma, EType.parameter_declaration), 
            // 103: function_header : fully_specified_type 'identifier' '(' ;
            new Regulation(EType.function_header, EType.fully_specified_type, EType.@identifier, EType.@LeftParenthesis), 
            // 104: parameter_declarator : type_specifier 'identifier' ;
            new Regulation(EType.parameter_declarator, EType.type_specifier, EType.@identifier), 
            // 105: parameter_declarator : type_specifier 'identifier' array_specifier ;
            new Regulation(EType.parameter_declarator, EType.type_specifier, EType.@identifier, EType.array_specifier), 
            // 106: parameter_declaration : type_qualifier parameter_declarator ;
            new Regulation(EType.parameter_declaration, EType.type_qualifier, EType.parameter_declarator), 
            // 107: parameter_declaration : parameter_declarator ;
            new Regulation(EType.parameter_declaration, EType.parameter_declarator), 
            // 108: parameter_declaration : type_qualifier parameter_type_specifier ;
            new Regulation(EType.parameter_declaration, EType.type_qualifier, EType.parameter_type_specifier), 
            // 109: parameter_declaration : parameter_type_specifier ;
            new Regulation(EType.parameter_declaration, EType.parameter_type_specifier), 
            // 110: parameter_type_specifier : type_specifier ;
            new Regulation(EType.parameter_type_specifier, EType.type_specifier), 
            // 111: init_declarator_list : single_declaration ;
            new Regulation(EType.init_declarator_list, EType.single_declaration), 
            // 112: init_declarator_list : init_declarator_list ',' 'identifier' ;
            new Regulation(EType.init_declarator_list, EType.init_declarator_list, EType.@Comma, EType.@identifier), 
            // 113: init_declarator_list : init_declarator_list ',' 'identifier' array_specifier ;
            new Regulation(EType.init_declarator_list, EType.init_declarator_list, EType.@Comma, EType.@identifier, EType.array_specifier), 
            // 114: init_declarator_list : init_declarator_list ',' 'identifier' array_specifier '=' initializer ;
            new Regulation(EType.init_declarator_list, EType.init_declarator_list, EType.@Comma, EType.@identifier, EType.array_specifier, EType.@Equal, EType.initializer), 
            // 115: init_declarator_list : init_declarator_list ',' 'identifier' '=' initializer ;
            new Regulation(EType.init_declarator_list, EType.init_declarator_list, EType.@Comma, EType.@identifier, EType.@Equal, EType.initializer), 
            // 116: single_declaration : fully_specified_type ;
            new Regulation(EType.single_declaration, EType.fully_specified_type), 
            // 117: single_declaration : fully_specified_type 'identifier' ;
            new Regulation(EType.single_declaration, EType.fully_specified_type, EType.@identifier), 
            // 118: single_declaration : fully_specified_type 'identifier' array_specifier ;
            new Regulation(EType.single_declaration, EType.fully_specified_type, EType.@identifier, EType.array_specifier), 
            // 119: single_declaration : fully_specified_type 'identifier' array_specifier '=' initializer ;
            new Regulation(EType.single_declaration, EType.fully_specified_type, EType.@identifier, EType.array_specifier, EType.@Equal, EType.initializer), 
            // 120: single_declaration : fully_specified_type 'identifier' '=' initializer ;
            new Regulation(EType.single_declaration, EType.fully_specified_type, EType.@identifier, EType.@Equal, EType.initializer), 
            // 121: fully_specified_type : type_specifier ;
            new Regulation(EType.fully_specified_type, EType.type_specifier), 
            // 122: fully_specified_type : type_qualifier type_specifier ;
            new Regulation(EType.fully_specified_type, EType.type_qualifier, EType.type_specifier), 
            // 123: invariant_qualifier : 'invariant' ;
            new Regulation(EType.invariant_qualifier, EType.@invariant), 
            // 124: interpolation_qualifier : 'smooth' ;
            new Regulation(EType.interpolation_qualifier, EType.@smooth), 
            // 125: interpolation_qualifier : 'flat' ;
            new Regulation(EType.interpolation_qualifier, EType.@flat), 
            // 126: interpolation_qualifier : 'noperspective' ;
            new Regulation(EType.interpolation_qualifier, EType.@noperspective), 
            // 127: layout_qualifier : 'layout' '(' layout_qualifier_id_list ')' ;
            new Regulation(EType.layout_qualifier, EType.@layout, EType.@LeftParenthesis, EType.layout_qualifier_id_list, EType.@RightParenthesis), 
            // 128: layout_qualifier_id_list : layout_qualifier_id ;
            new Regulation(EType.layout_qualifier_id_list, EType.layout_qualifier_id), 
            // 129: layout_qualifier_id_list : layout_qualifier_id_list ',' layout_qualifier_id ;
            new Regulation(EType.layout_qualifier_id_list, EType.layout_qualifier_id_list, EType.@Comma, EType.layout_qualifier_id), 
            // 130: layout_qualifier_id : 'identifier' ;
            new Regulation(EType.layout_qualifier_id, EType.@identifier), 
            // 131: layout_qualifier_id : 'identifier' '=' 'number' ;
            new Regulation(EType.layout_qualifier_id, EType.@identifier, EType.@Equal, EType.@number), 
            // 132: precise_qualifier : 'precise' ;
            new Regulation(EType.precise_qualifier, EType.@precise), 
            // 133: type_qualifier : single_type_qualifier ;
            new Regulation(EType.type_qualifier, EType.single_type_qualifier), 
            // 134: type_qualifier : type_qualifier single_type_qualifier ;
            new Regulation(EType.type_qualifier, EType.type_qualifier, EType.single_type_qualifier), 
            // 135: single_type_qualifier : storage_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.storage_qualifier), 
            // 136: single_type_qualifier : layout_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.layout_qualifier), 
            // 137: single_type_qualifier : precision_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.precision_qualifier), 
            // 138: single_type_qualifier : interpolation_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.interpolation_qualifier), 
            // 139: single_type_qualifier : invariant_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.invariant_qualifier), 
            // 140: single_type_qualifier : precise_qualifier ;
            new Regulation(EType.single_type_qualifier, EType.precise_qualifier), 
            // 141: storage_qualifier : 'const' ;
            new Regulation(EType.storage_qualifier, EType.@const), 
            // 142: storage_qualifier : 'inout' ;
            new Regulation(EType.storage_qualifier, EType.@inout), 
            // 143: storage_qualifier : 'in' ;
            new Regulation(EType.storage_qualifier, EType.@in), 
            // 144: storage_qualifier : 'out' ;
            new Regulation(EType.storage_qualifier, EType.@out), 
            // 145: storage_qualifier : 'centroid' ;
            new Regulation(EType.storage_qualifier, EType.@centroid), 
            // 146: storage_qualifier : 'patch' ;
            new Regulation(EType.storage_qualifier, EType.@patch), 
            // 147: storage_qualifier : 'sample' ;
            new Regulation(EType.storage_qualifier, EType.@sample), 
            // 148: storage_qualifier : 'uniform' ;
            new Regulation(EType.storage_qualifier, EType.@uniform), 
            // 149: storage_qualifier : 'buffer' ;
            new Regulation(EType.storage_qualifier, EType.@buffer), 
            // 150: storage_qualifier : 'shared' ;
            new Regulation(EType.storage_qualifier, EType.@shared), 
            // 151: storage_qualifier : 'coherent' ;
            new Regulation(EType.storage_qualifier, EType.@coherent), 
            // 152: storage_qualifier : 'volatile' ;
            new Regulation(EType.storage_qualifier, EType.@volatile), 
            // 153: storage_qualifier : 'restrict' ;
            new Regulation(EType.storage_qualifier, EType.@restrict), 
            // 154: storage_qualifier : 'readonly' ;
            new Regulation(EType.storage_qualifier, EType.@readonly), 
            // 155: storage_qualifier : 'writeonly' ;
            new Regulation(EType.storage_qualifier, EType.@writeonly), 
            // 156: storage_qualifier : 'subroutine' ;
            new Regulation(EType.storage_qualifier, EType.@subroutine), 
            // 157: storage_qualifier : 'subroutine' '(' type_name_list ')' ;
            new Regulation(EType.storage_qualifier, EType.@subroutine, EType.@LeftParenthesis, EType.type_name_list, EType.@RightParenthesis), 
            // 158: type_name_list : 'userDefinedType' ;
            new Regulation(EType.type_name_list, EType.@userDefinedType), 
            // 159: type_name_list : type_name_list ',' 'userDefinedType' ;
            new Regulation(EType.type_name_list, EType.type_name_list, EType.@Comma, EType.@userDefinedType), 
            // 160: type_specifier : type_specifier_nonarray ;
            new Regulation(EType.type_specifier, EType.type_specifier_nonarray), 
            // 161: type_specifier : type_specifier_nonarray array_specifier ;
            new Regulation(EType.type_specifier, EType.type_specifier_nonarray, EType.array_specifier), 
            // 162: array_specifier : '[' ']' ;
            new Regulation(EType.array_specifier, EType.@LeftBracket, EType.@RightBracket), 
            // 163: array_specifier : '[' constant_expression ']' ;
            new Regulation(EType.array_specifier, EType.@LeftBracket, EType.constant_expression, EType.@RightBracket), 
            // 164: array_specifier : array_specifier '[' ']' ;
            new Regulation(EType.array_specifier, EType.array_specifier, EType.@LeftBracket, EType.@RightBracket), 
            // 165: array_specifier : array_specifier '[' constant_expression ']' ;
            new Regulation(EType.array_specifier, EType.array_specifier, EType.@LeftBracket, EType.constant_expression, EType.@RightBracket), 
            // 166: type_specifier_nonarray : 'void' ;
            new Regulation(EType.type_specifier_nonarray, EType.@void), 
            // 167: type_specifier_nonarray : 'float' ;
            new Regulation(EType.type_specifier_nonarray, EType.@float), 
            // 168: type_specifier_nonarray : 'double' ;
            new Regulation(EType.type_specifier_nonarray, EType.@double), 
            // 169: type_specifier_nonarray : 'int' ;
            new Regulation(EType.type_specifier_nonarray, EType.@int), 
            // 170: type_specifier_nonarray : 'uint' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uint), 
            // 171: type_specifier_nonarray : 'bool' ;
            new Regulation(EType.type_specifier_nonarray, EType.@bool), 
            // 172: type_specifier_nonarray : 'vec2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@vec2), 
            // 173: type_specifier_nonarray : 'vec3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@vec3), 
            // 174: type_specifier_nonarray : 'vec4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@vec4), 
            // 175: type_specifier_nonarray : 'dvec2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dvec2), 
            // 176: type_specifier_nonarray : 'dvec3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dvec3), 
            // 177: type_specifier_nonarray : 'dvec4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dvec4), 
            // 178: type_specifier_nonarray : 'bvec2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@bvec2), 
            // 179: type_specifier_nonarray : 'bvec3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@bvec3), 
            // 180: type_specifier_nonarray : 'bvec4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@bvec4), 
            // 181: type_specifier_nonarray : 'ivec2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@ivec2), 
            // 182: type_specifier_nonarray : 'ivec3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@ivec3), 
            // 183: type_specifier_nonarray : 'ivec4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@ivec4), 
            // 184: type_specifier_nonarray : 'uvec2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uvec2), 
            // 185: type_specifier_nonarray : 'uvec3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uvec3), 
            // 186: type_specifier_nonarray : 'uvec4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uvec4), 
            // 187: type_specifier_nonarray : 'mat2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat2), 
            // 188: type_specifier_nonarray : 'mat3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat3), 
            // 189: type_specifier_nonarray : 'mat4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat4), 
            // 190: type_specifier_nonarray : 'mat2x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat2x2), 
            // 191: type_specifier_nonarray : 'mat2x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat2x3), 
            // 192: type_specifier_nonarray : 'mat2x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat2x4), 
            // 193: type_specifier_nonarray : 'mat3x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat3x2), 
            // 194: type_specifier_nonarray : 'mat3x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat3x3), 
            // 195: type_specifier_nonarray : 'mat3x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat3x4), 
            // 196: type_specifier_nonarray : 'mat4x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat4x2), 
            // 197: type_specifier_nonarray : 'mat4x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat4x3), 
            // 198: type_specifier_nonarray : 'mat4x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@mat4x4), 
            // 199: type_specifier_nonarray : 'dmat2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat2), 
            // 200: type_specifier_nonarray : 'dmat3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat3), 
            // 201: type_specifier_nonarray : 'dmat4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat4), 
            // 202: type_specifier_nonarray : 'dmat2x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat2x2), 
            // 203: type_specifier_nonarray : 'dmat2x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat2x3), 
            // 204: type_specifier_nonarray : 'dmat2x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat2x4), 
            // 205: type_specifier_nonarray : 'dmat3x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat3x2), 
            // 206: type_specifier_nonarray : 'dmat3x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat3x3), 
            // 207: type_specifier_nonarray : 'dmat3x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat3x4), 
            // 208: type_specifier_nonarray : 'dmat4x2' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat4x2), 
            // 209: type_specifier_nonarray : 'dmat4x3' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat4x3), 
            // 210: type_specifier_nonarray : 'dmat4x4' ;
            new Regulation(EType.type_specifier_nonarray, EType.@dmat4x4), 
            // 211: type_specifier_nonarray : 'atomic_uint' ;
            new Regulation(EType.type_specifier_nonarray, EType.@atomic_uint), 
            // 212: type_specifier_nonarray : 'sampler1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler1D), 
            // 213: type_specifier_nonarray : 'sampler2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2D), 
            // 214: type_specifier_nonarray : 'sampler3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler3D), 
            // 215: type_specifier_nonarray : 'samplerCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@samplerCube), 
            // 216: type_specifier_nonarray : 'sampler1DShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler1DShadow), 
            // 217: type_specifier_nonarray : 'sampler2DShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DShadow), 
            // 218: type_specifier_nonarray : 'samplerCubeShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@samplerCubeShadow), 
            // 219: type_specifier_nonarray : 'sampler1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler1DArray), 
            // 220: type_specifier_nonarray : 'sampler2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DArray), 
            // 221: type_specifier_nonarray : 'sampler1DArrayShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler1DArrayShadow), 
            // 222: type_specifier_nonarray : 'sampler2DArrayShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DArrayShadow), 
            // 223: type_specifier_nonarray : 'samplerCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@samplerCubeArray), 
            // 224: type_specifier_nonarray : 'samplerCubeArrayShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@samplerCubeArrayShadow), 
            // 225: type_specifier_nonarray : 'isampler1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler1D), 
            // 226: type_specifier_nonarray : 'isampler2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler2D), 
            // 227: type_specifier_nonarray : 'isampler3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler3D), 
            // 228: type_specifier_nonarray : 'isamplerCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isamplerCube), 
            // 229: type_specifier_nonarray : 'isampler1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler1DArray), 
            // 230: type_specifier_nonarray : 'isampler2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler2DArray), 
            // 231: type_specifier_nonarray : 'isamplerCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isamplerCubeArray), 
            // 232: type_specifier_nonarray : 'usampler1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler1D), 
            // 233: type_specifier_nonarray : 'usampler2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler2D), 
            // 234: type_specifier_nonarray : 'usampler3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler3D), 
            // 235: type_specifier_nonarray : 'usamplerCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usamplerCube), 
            // 236: type_specifier_nonarray : 'usampler1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler1DArray), 
            // 237: type_specifier_nonarray : 'usampler2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler2DArray), 
            // 238: type_specifier_nonarray : 'usamplerCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usamplerCubeArray), 
            // 239: type_specifier_nonarray : 'sampler2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DRect), 
            // 240: type_specifier_nonarray : 'sampler2DRectShadow' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DRectShadow), 
            // 241: type_specifier_nonarray : 'isampler2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler2DRect), 
            // 242: type_specifier_nonarray : 'usampler2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler2DRect), 
            // 243: type_specifier_nonarray : 'samplerBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@samplerBuffer), 
            // 244: type_specifier_nonarray : 'isamplerBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isamplerBuffer), 
            // 245: type_specifier_nonarray : 'usamplerBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usamplerBuffer), 
            // 246: type_specifier_nonarray : 'sampler2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DMS), 
            // 247: type_specifier_nonarray : 'isampler2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler2DMS), 
            // 248: type_specifier_nonarray : 'usampler2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler2DMS), 
            // 249: type_specifier_nonarray : 'sampler2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@sampler2DMSArray), 
            // 250: type_specifier_nonarray : 'isampler2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@isampler2DMSArray), 
            // 251: type_specifier_nonarray : 'usampler2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@usampler2DMSArray), 
            // 252: type_specifier_nonarray : 'image1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image1D), 
            // 253: type_specifier_nonarray : 'iimage1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage1D), 
            // 254: type_specifier_nonarray : 'uimage1D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage1D), 
            // 255: type_specifier_nonarray : 'image2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image2D), 
            // 256: type_specifier_nonarray : 'iimage2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage2D), 
            // 257: type_specifier_nonarray : 'uimage2D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage2D), 
            // 258: type_specifier_nonarray : 'image3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image3D), 
            // 259: type_specifier_nonarray : 'iimage3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage3D), 
            // 260: type_specifier_nonarray : 'uimage3D' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage3D), 
            // 261: type_specifier_nonarray : 'image2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image2DRect), 
            // 262: type_specifier_nonarray : 'iimage2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage2DRect), 
            // 263: type_specifier_nonarray : 'uimage2DRect' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage2DRect), 
            // 264: type_specifier_nonarray : 'imageCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@imageCube), 
            // 265: type_specifier_nonarray : 'iimageCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimageCube), 
            // 266: type_specifier_nonarray : 'uimageCube' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimageCube), 
            // 267: type_specifier_nonarray : 'imageBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@imageBuffer), 
            // 268: type_specifier_nonarray : 'iimageBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimageBuffer), 
            // 269: type_specifier_nonarray : 'uimageBuffer' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimageBuffer), 
            // 270: type_specifier_nonarray : 'image1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image1DArray), 
            // 271: type_specifier_nonarray : 'iimage1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage1DArray), 
            // 272: type_specifier_nonarray : 'uimage1DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage1DArray), 
            // 273: type_specifier_nonarray : 'image2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image2DArray), 
            // 274: type_specifier_nonarray : 'iimage2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage2DArray), 
            // 275: type_specifier_nonarray : 'uimage2DArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage2DArray), 
            // 276: type_specifier_nonarray : 'imageCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@imageCubeArray), 
            // 277: type_specifier_nonarray : 'iimageCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimageCubeArray), 
            // 278: type_specifier_nonarray : 'uimageCubeArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimageCubeArray), 
            // 279: type_specifier_nonarray : 'image2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image2DMS), 
            // 280: type_specifier_nonarray : 'iimage2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage2DMS), 
            // 281: type_specifier_nonarray : 'uimage2DMS' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage2DMS), 
            // 282: type_specifier_nonarray : 'image2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@image2DMSArray), 
            // 283: type_specifier_nonarray : 'iimage2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@iimage2DMSArray), 
            // 284: type_specifier_nonarray : 'uimage2DMSArray' ;
            new Regulation(EType.type_specifier_nonarray, EType.@uimage2DMSArray), 
            // 285: type_specifier_nonarray : struct_specifier ;
            new Regulation(EType.type_specifier_nonarray, EType.struct_specifier), 
            // 286: type_specifier_nonarray : 'userDefinedType' ;
            new Regulation(EType.type_specifier_nonarray, EType.@userDefinedType), 
            // 287: precision_qualifier : 'high_precision' ;
            new Regulation(EType.precision_qualifier, EType.@high_precision), 
            // 288: precision_qualifier : 'medium_precision' ;
            new Regulation(EType.precision_qualifier, EType.@medium_precision), 
            // 289: precision_qualifier : 'low_precision' ;
            new Regulation(EType.precision_qualifier, EType.@low_precision), 
            // 290: struct_specifier : 'struct' type_name '{' struct_declaration_list '}' ;
            new Regulation(EType.struct_specifier, EType.@struct, EType.type_name, EType.@LeftBrace, EType.struct_declaration_list, EType.@RightBrace), 
            // 291: type_name : 'identifier' ;
            new Regulation(EType.type_name, EType.@identifier), 
            // 292: struct_specifier : 'struct' '{' struct_declaration_list '}' ;
            new Regulation(EType.struct_specifier, EType.@struct, EType.@LeftBrace, EType.struct_declaration_list, EType.@RightBrace), 
            // 293: struct_declaration_list : struct_declaration ;
            new Regulation(EType.struct_declaration_list, EType.struct_declaration), 
            // 294: struct_declaration_list : struct_declaration_list struct_declaration ;
            new Regulation(EType.struct_declaration_list, EType.struct_declaration_list, EType.struct_declaration), 
            // 295: struct_declaration : type_specifier struct_declarator_list ';' ;
            new Regulation(EType.struct_declaration, EType.type_specifier, EType.struct_declarator_list, EType.@Semicolon), 
            // 296: struct_declaration : type_qualifier type_specifier struct_declarator_list ';' ;
            new Regulation(EType.struct_declaration, EType.type_qualifier, EType.type_specifier, EType.struct_declarator_list, EType.@Semicolon), 
            // 297: struct_declarator_list : struct_declarator ;
            new Regulation(EType.struct_declarator_list, EType.struct_declarator), 
            // 298: struct_declarator_list : struct_declarator_list ',' struct_declarator ;
            new Regulation(EType.struct_declarator_list, EType.struct_declarator_list, EType.@Comma, EType.struct_declarator), 
            // 299: struct_declarator : 'identifier' ;
            new Regulation(EType.struct_declarator, EType.@identifier), 
            // 300: struct_declarator : 'identifier' array_specifier ;
            new Regulation(EType.struct_declarator, EType.@identifier, EType.array_specifier), 
            // 301: initializer : assignment_expression ;
            new Regulation(EType.initializer, EType.assignment_expression), 
            // 302: initializer : '{' initializer_list '}' ;
            new Regulation(EType.initializer, EType.@LeftBrace, EType.initializer_list, EType.@RightBrace), 
            // 303: initializer : '{' initializer_list ',' '}' ;
            new Regulation(EType.initializer, EType.@LeftBrace, EType.initializer_list, EType.@Comma, EType.@RightBrace), 
            // 304: initializer_list : initializer ;
            new Regulation(EType.initializer_list, EType.initializer), 
            // 305: initializer_list : initializer_list ',' initializer ;
            new Regulation(EType.initializer_list, EType.initializer_list, EType.@Comma, EType.initializer), 
            // 306: declaration_statement : declaration ;
            new Regulation(EType.declaration_statement, EType.declaration), 
            // 307: statement : compound_statement ;
            new Regulation(EType.statement, EType.compound_statement), 
            // 308: statement : simple_statement ;
            new Regulation(EType.statement, EType.simple_statement), 
            // 309: simple_statement : declaration_statement ;
            new Regulation(EType.simple_statement, EType.declaration_statement), 
            // 310: simple_statement : expression_statement ;
            new Regulation(EType.simple_statement, EType.expression_statement), 
            // 311: simple_statement : selection_statement ;
            new Regulation(EType.simple_statement, EType.selection_statement), 
            // 312: simple_statement : switch_statement ;
            new Regulation(EType.simple_statement, EType.switch_statement), 
            // 313: simple_statement : case_label ;
            new Regulation(EType.simple_statement, EType.case_label), 
            // 314: simple_statement : iteration_statement ;
            new Regulation(EType.simple_statement, EType.iteration_statement), 
            // 315: simple_statement : jump_statement ;
            new Regulation(EType.simple_statement, EType.jump_statement), 
            // 316: compound_statement : '{' '}' ;
            new Regulation(EType.compound_statement, EType.@LeftBrace, EType.@RightBrace), 
            // 317: compound_statement : '{' statement_list '}' ;
            new Regulation(EType.compound_statement, EType.@LeftBrace, EType.statement_list, EType.@RightBrace), 
            // 318: statement_no_new_scope : compound_statement_no_new_scope ;
            new Regulation(EType.statement_no_new_scope, EType.compound_statement_no_new_scope), 
            // 319: statement_no_new_scope : simple_statement ;
            new Regulation(EType.statement_no_new_scope, EType.simple_statement), 
            // 320: compound_statement_no_new_scope : '{' '}' ;
            new Regulation(EType.compound_statement_no_new_scope, EType.@LeftBrace, EType.@RightBrace), 
            // 321: compound_statement_no_new_scope : '{' statement_list '}' ;
            new Regulation(EType.compound_statement_no_new_scope, EType.@LeftBrace, EType.statement_list, EType.@RightBrace), 
            // 322: statement_list : statement ;
            new Regulation(EType.statement_list, EType.statement), 
            // 323: statement_list : statement_list statement ;
            new Regulation(EType.statement_list, EType.statement_list, EType.statement), 
            // 324: expression_statement : ';' ;
            new Regulation(EType.expression_statement, EType.@Semicolon), 
            // 325: expression_statement : expression ';' ;
            new Regulation(EType.expression_statement, EType.expression, EType.@Semicolon), 
            // 326: selection_statement : 'if' '(' expression ')' selection_rest_statement ;
            new Regulation(EType.selection_statement, EType.@if, EType.@LeftParenthesis, EType.expression, EType.@RightParenthesis, EType.selection_rest_statement), 
            // 327: selection_rest_statement : statement 'else' statement ;
            new Regulation(EType.selection_rest_statement, EType.statement, EType.@else, EType.statement), 
            // 328: selection_rest_statement : statement ;
            new Regulation(EType.selection_rest_statement, EType.statement), 
            // 329: condition : expression ;
            new Regulation(EType.condition, EType.expression), 
            // 330: condition : fully_specified_type 'identifier' '=' initializer ;
            new Regulation(EType.condition, EType.fully_specified_type, EType.@identifier, EType.@Equal, EType.initializer), 
            // 331: switch_statement : 'switch' '(' expression ')' '{' switch_statement_list '}' ;
            new Regulation(EType.switch_statement, EType.@switch, EType.@LeftParenthesis, EType.expression, EType.@RightParenthesis, EType.@LeftBrace, EType.switch_statement_list, EType.@RightBrace), 
            // 332: switch_statement_list : statement_list ;
            new Regulation(EType.switch_statement_list, EType.statement_list), 
            // 333: case_label : 'case' expression ':' ;
            new Regulation(EType.case_label, EType.@case, EType.expression, EType.@Colon), 
            // 334: case_label : 'default' ':' ;
            new Regulation(EType.case_label, EType.@default, EType.@Colon), 
            // 335: iteration_statement : 'while' '(' condition ')' statement_no_new_scope ;
            new Regulation(EType.iteration_statement, EType.@while, EType.@LeftParenthesis, EType.condition, EType.@RightParenthesis, EType.statement_no_new_scope), 
            // 336: iteration_statement : 'do' statement 'while' '(' expression ')' ';' ;
            new Regulation(EType.iteration_statement, EType.@do, EType.statement, EType.@while, EType.@LeftParenthesis, EType.expression, EType.@RightParenthesis, EType.@Semicolon), 
            // 337: iteration_statement : 'for' '(' for_init_statement for_rest_statement ')' statement_no_new_scope ;
            new Regulation(EType.iteration_statement, EType.@for, EType.@LeftParenthesis, EType.for_init_statement, EType.for_rest_statement, EType.@RightParenthesis, EType.statement_no_new_scope), 
            // 338: for_init_statement : expression_statement ;
            new Regulation(EType.for_init_statement, EType.expression_statement), 
            // 339: for_init_statement : declaration_statement ;
            new Regulation(EType.for_init_statement, EType.declaration_statement), 
            // 340: conditionopt : condition ;
            new Regulation(EType.conditionopt, EType.condition), 
            // 341: for_rest_statement : conditionopt ';' ;
            new Regulation(EType.for_rest_statement, EType.conditionopt, EType.@Semicolon), 
            // 342: for_rest_statement : conditionopt ';' expression ;
            new Regulation(EType.for_rest_statement, EType.conditionopt, EType.@Semicolon, EType.expression), 
            // 343: jump_statement : 'continue' ';' ;
            new Regulation(EType.jump_statement, EType.@continue, EType.@Semicolon), 
            // 344: jump_statement : 'break' ';' ;
            new Regulation(EType.jump_statement, EType.@break, EType.@Semicolon), 
            // 345: jump_statement : 'return' ';' ;
            new Regulation(EType.jump_statement, EType.@return, EType.@Semicolon), 
            // 346: jump_statement : 'return' expression ';' ;
            new Regulation(EType.jump_statement, EType.@return, EType.expression, EType.@Semicolon), 
            // 347: jump_statement : 'discard' ';' ;
            new Regulation(EType.jump_statement, EType.@discard, EType.@Semicolon), 

        };
    }
}
