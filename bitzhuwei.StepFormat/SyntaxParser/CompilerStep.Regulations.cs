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
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: StepFile : 'STEP' ';' 'HEADER' ';' HeadLine 'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';' ;
            new Regulation(EType.StepFile, EType.STEP, EType.Semicolon, EType.HEADER, EType.Semicolon, EType.HeadLine, EType.ENDSEC, EType.Semicolon, EType.DATA, EType.Semicolon, EType.Model, EType.ENDSEC, EType.Semicolon, EType.ENDSTEP, EType.Semicolon), 
            // 1: StepFile : 'STEP' ';' 'HEADER' ';' 'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';' ;
            new Regulation(EType.StepFile, EType.STEP, EType.Semicolon, EType.HEADER, EType.Semicolon, EType.ENDSEC, EType.Semicolon, EType.DATA, EType.Semicolon, EType.Model, EType.ENDSEC, EType.Semicolon, EType.ENDSTEP, EType.Semicolon), 
            // 2: Model : Entity ;
            new Regulation(EType.Model, EType.Entity), 
            // 3: Model : Model Entity ;
            new Regulation(EType.Model, EType.Model, EType.Entity), 
            // 4: Entity : 'EntityId' '=' ScopeBlock EntityBody ';' ;
            new Regulation(EType.Entity, EType.EntityId, EType.Equal, EType.ScopeBlock, EType.EntityBody, EType.Semicolon), 
            // 5: Entity : 'EntityId' '=' EntityBody ';' ;
            new Regulation(EType.Entity, EType.EntityId, EType.Equal, EType.EntityBody, EType.Semicolon), 
            // 6: ScopeBlock : 'SCOPE' Model 'ENDSCOPE' '/' IdList '/' ;
            new Regulation(EType.ScopeBlock, EType.SCOPE, EType.Model, EType.ENDSCOPE, EType.Slash, EType.IdList, EType.Slash), 
            // 7: ScopeBlock : 'SCOPE' Model 'ENDSCOPE' ;
            new Regulation(EType.ScopeBlock, EType.SCOPE, EType.Model, EType.ENDSCOPE), 
            // 8: ScopeBlock : 'SCOPE' 'ENDSCOPE' '/' IdList '/' ;
            new Regulation(EType.ScopeBlock, EType.SCOPE, EType.ENDSCOPE, EType.Slash, EType.IdList, EType.Slash), 
            // 9: ScopeBlock : 'SCOPE' 'ENDSCOPE' ;
            new Regulation(EType.ScopeBlock, EType.SCOPE, EType.ENDSCOPE), 
            // 10: IdList : IdList ',' 'Identity' ;
            new Regulation(EType.IdList, EType.IdList, EType.Comma, EType.Identity), 
            // 11: IdList : 'Identity' ;
            new Regulation(EType.IdList, EType.Identity), 
            // 12: EntityBody : TypeObj ;
            new Regulation(EType.EntityBody, EType.TypeObj), 
            // 13: EntityBody : '(' Complex ')' ;
            new Regulation(EType.EntityBody, EType.LeftParenthesis, EType.Complex, EType.RightParenthesis), 
            // 14: TypeObj : 'TypeName' LArgsJ ;
            new Regulation(EType.TypeObj, EType.TypeName, EType.LArgsJ), 
            // 15: Complex : Complex TypeObj ;
            new Regulation(EType.Complex, EType.Complex, EType.TypeObj), 
            // 16: Complex : TypeObj ;
            new Regulation(EType.Complex, EType.TypeObj), 
            // 17: HeadLine : HeadLine TypeObj ';' ;
            new Regulation(EType.HeadLine, EType.HeadLine, EType.TypeObj, EType.Semicolon), 
            // 18: HeadLine : TypeObj ';' ;
            new Regulation(EType.HeadLine, EType.TypeObj, EType.Semicolon), 
            // 19: LArgsJ : '(' Args ')' ;
            new Regulation(EType.LArgsJ, EType.LeftParenthesis, EType.Args, EType.RightParenthesis), 
            // 20: LArgsJ : '(' ')' ;
            new Regulation(EType.LArgsJ, EType.LeftParenthesis, EType.RightParenthesis), 
            // 21: Args : Args ',' Arg ;
            new Regulation(EType.Args, EType.Args, EType.Comma, EType.Arg), 
            // 22: Args : Arg ;
            new Regulation(EType.Args, EType.Arg), 
            // 23: Arg : 'Identity' ;
            new Regulation(EType.Arg, EType.Identity), 
            // 24: Arg : '$' ;
            new Regulation(EType.Arg, EType.Dollar), 
            // 25: Arg : '*' ;
            new Regulation(EType.Arg, EType.Asterisk), 
            // 26: Arg : 'String' ;
            new Regulation(EType.Arg, EType.String), 
            // 27: Arg : 'Integer' ;
            new Regulation(EType.Arg, EType.Integer), 
            // 28: Arg : 'Float' ;
            new Regulation(EType.Arg, EType.Float), 
            // 29: Arg : 'Hexadecimal' ;
            new Regulation(EType.Arg, EType.Hexadecimal), 
            // 30: Arg : 'Enum' ;
            new Regulation(EType.Arg, EType.Enum), 
            // 31: Arg : LArgsJ ;
            new Regulation(EType.Arg, EType.LArgsJ), 
            // 32: Arg : TypeObj ;
            new Regulation(EType.Arg, EType.TypeObj),

        };
    }
}
