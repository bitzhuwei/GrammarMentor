using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.StepFormat
{
    public partial class CompilerStep
    {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, StepModelContext}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/ , Action<Node, TContext<StepModel>>> stepModelExtracterDict = new Dictionary<string, Action<Node, TContext<StepModel>>>();

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeStepModelExtracterDict()
        {
            var extracterDict = stepModelExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, stepContext) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            extracterDict.Add(EType.STEP,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            //extracterDict.Add(EType.Semicolon,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.HEADER,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.ENDSEC,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.DATA,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            extracterDict.Add(EType.ENDSTEP,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.EntityId,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            //extracterDict.Add(EType.Equal,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.SCOPE,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.ENDSCOPE,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.Slash,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.Comma,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            extracterDict.Add(EType.Identity,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            //extracterDict.Add(EType.LeftParenthesis,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.RightParenthesis,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            extracterDict.Add(EType.TypeName,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Dollar,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Asterisk,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.String,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Integer,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Float,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Hexadecimal,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Enum,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) =>
            {
                // -1: StepModel☞ : StepFile '¥' ;
                //var obj = context.objStack.Pop(); var stepFile = obj as StepModel;
                //var stepModel = new StepModel(/*stepFile*/);
                //context.result = stepModel; // final step, no need to push into stack.
                object obj;
                obj = context.objStack.Pop(); var stepFile = obj as StepModel;
                context.result = stepFile;
            });
            extracterDict.Add(EType.StepFile,
            (node, context) =>
            {
                //if (node.regulation == regulations[0])
                //{
                //    // 0: StepFile : 'STEP' ';' 'HEADER' ';' HeadLine 'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSTEP1 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon2 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSEC3 = obj as string;
                //    obj = context.objStack.Pop(); var model4 = obj as Model;
                //    obj = context.objStack.Pop(); var semicolon5 = obj as string;
                //    obj = context.objStack.Pop(); var dATA6 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon7 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSEC8 = obj as string;
                //    obj = context.objStack.Pop(); var headLine9 = obj as HeadLine;
                //    obj = context.objStack.Pop(); var semicolon10 = obj as string;
                //    obj = context.objStack.Pop(); var hEADER11 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon12 = obj as string;
                //    obj = context.objStack.Pop(); var sTEP13 = obj as string;
                //    var stepFile = new StepFile(/*sTEP13, semicolon12, hEADER11, semicolon10, headLine9, eNDSEC8, semicolon7, dATA6, semicolon5, model4, eNDSEC3, semicolon2, eNDSTEP1, semicolon0*/);
                //    context.objStack.Push(stepFile);
                //}
                //else if (node.regulation == regulations[1])
                //{
                //    // 1: StepFile : 'STEP' ';' 'HEADER' ';' 'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSTEP1 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon2 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSEC3 = obj as string;
                //    obj = context.objStack.Pop(); var model4 = obj as Model;
                //    obj = context.objStack.Pop(); var semicolon5 = obj as string;
                //    obj = context.objStack.Pop(); var dATA6 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon7 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSEC8 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon9 = obj as string;
                //    obj = context.objStack.Pop(); var hEADER10 = obj as string;
                //    obj = context.objStack.Pop(); var semicolon11 = obj as string;
                //    obj = context.objStack.Pop(); var sTEP12 = obj as string;
                //    var stepFile = new StepFile(/*sTEP12, semicolon11, hEADER10, semicolon9, eNDSEC8, semicolon7, dATA6, semicolon5, model4, eNDSEC3, semicolon2, eNDSTEP1, semicolon0*/);
                //    context.objStack.Push(stepFile);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[0])
                {
                    // 0: <StepFile> ::= "STEP" ";" "HEADER" ";" <HeadLine> "ENDSEC" ";" "DATA" ";" <Model> "ENDSEC" ";" "ENDSTEP" ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var endStep = obj as string;
                    obj = context.objStack.Pop(); var entityDict = obj as Dictionary<string, StepEntity>;
                    obj = context.objStack.Pop(); var headlineList = obj as List<StepTypeObj>;
                    obj = context.objStack.Pop(); var step = obj as string;
                    var stepFile = new StepModel(step, headlineList, entityDict, endStep);
                    context.objStack.Push(stepFile);
                }
                else if (node.regulation == regulations[1])
                {
                    // 1: <StepFile> ::= "STEP" ";" "HEADER" ";" "ENDSEC" ";" "DATA" ";" <Model> "ENDSEC" ";" "ENDSTEP" ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var endStep = obj as string;
                    obj = context.objStack.Pop(); var entityDict = obj as Dictionary<string, StepEntity>;
                    /*obj = context.objStack.Pop();*/
                    var headlineList = new List<StepTypeObj>();
                    obj = context.objStack.Pop(); var step = obj as string;
                    var stepFile = new StepModel(step, headlineList, entityDict, endStep);
                    context.objStack.Push(stepFile);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Model,
            (node, context) =>
            {
                //if (node.regulation == regulations[2])
                //{
                //    // 2: Model : Entity ;
                //    object obj;
                //    obj = context.objStack.Pop(); var entity0 = obj as Entity;
                //    var model = new Model(/*entity0*/);
                //    context.objStack.Push(model);
                //}
                //else if (node.regulation == regulations[3])
                //{
                //    // 3: Model : Model Entity ;
                //    object obj;
                //    obj = context.objStack.Pop(); var entity0 = obj as Entity;
                //    obj = context.objStack.Pop(); var model1 = obj as Model;
                //    var model = new Model(/*model1, entity0*/);
                //    context.objStack.Push(model);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[2])
                {
                    // 2: <Model> ::= <Entity> ;
                    object obj = context.objStack.Pop(); var entity = obj as StepEntity;
                    var dict = new Dictionary<string, StepEntity>(); dict.Add(entity.entityId, entity);
                    context.objStack.Push(dict);
                }
                else if (node.regulation == regulations[3])
                {
                    // 3: <Model> ::= <Model> <Entity> ;
                    object obj;
                    obj = context.objStack.Pop(); var entity = obj as StepEntity;
                    obj = context.objStack.Pop(); var dict = obj as Dictionary<string, StepEntity>;
                    dict.Add(entity.entityId, entity);
                    context.objStack.Push(dict);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Entity,
            (node, context) =>
            {
                //if (node.regulation == regulations[4])
                //{
                //    // 4: Entity : 'EntityId' '=' ScopeBlock EntityBody ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var entityBody1 = obj as EntityBody;
                //    obj = context.objStack.Pop(); var scopeBlock2 = obj as ScopeBlock;
                //    obj = context.objStack.Pop(); var equal3 = obj as string;
                //    obj = context.objStack.Pop(); var entityId4 = obj as string;
                //    var entity = new Entity(/*entityId4, equal3, scopeBlock2, entityBody1, semicolon0*/);
                //    context.objStack.Push(entity);
                //}
                //else if (node.regulation == regulations[5])
                //{
                //    // 5: Entity : 'EntityId' '=' EntityBody ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var entityBody1 = obj as EntityBody;
                //    obj = context.objStack.Pop(); var equal2 = obj as string;
                //    obj = context.objStack.Pop(); var entityId3 = obj as string;
                //    var entity = new Entity(/*entityId3, equal2, entityBody1, semicolon0*/);
                //    context.objStack.Push(entity);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[4])
                {
                    // 4: <Entity> ::= "EntityId" "=" <ScopeBlock> <EntityBody> ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObjList = obj as List<StepTypeObj>; // <EntityBody>
                    obj = context.objStack.Pop(); var idList = obj as List<string>; //<ScopeBlock>
                    obj = context.objStack.Pop(); var entityList = obj as List<StepEntity>; // <ScopeBlock>
                    obj = context.objStack.Pop(); var scope = (bool)obj; // <ScopeBlock>
                    obj = context.objStack.Pop(); var entityId = obj as string; // "EntityId"
                    var entity = new StepEntity(entityId, scope, entityList, idList, typeObjList);
                    context.objStack.Push(entity);
                }
                else if (node.regulation == regulations[5])
                {
                    // 5: <Entity> ::= "EntityId" "=" <EntityBody> ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObjList = obj as List<StepTypeObj>; // <EntityBody>
                    /*obj = context.objStack.Pop();*/
                    var idList = new List<string>(); //<ScopeBlock>
                    /*obj = context.objStack.Pop();*/
                    var entityList = new List<StepEntity>(); // <ScopeBlock>
                    /*obj = context.objStack.Pop();*/
                    var scope = false; // <ScopeBlock>
                    obj = context.objStack.Pop(); var entityId = obj as string; // "EntityId"
                    var entity = new StepEntity(entityId, scope, entityList, idList, typeObjList);
                    context.objStack.Push(entity);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.ScopeBlock,
            (node, context) =>
            {
                //if (node.regulation == regulations[6])
                //{
                //    // 6: ScopeBlock : 'SCOPE' Model 'ENDSCOPE' '/' IdList '/' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var slash0 = obj as string;
                //    obj = context.objStack.Pop(); var idList1 = obj as IdList;
                //    obj = context.objStack.Pop(); var slash2 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSCOPE3 = obj as string;
                //    obj = context.objStack.Pop(); var model4 = obj as Model;
                //    obj = context.objStack.Pop(); var sCOPE5 = obj as string;
                //    var scopeBlock = new ScopeBlock(/*sCOPE5, model4, eNDSCOPE3, slash2, idList1, slash0*/);
                //    context.objStack.Push(scopeBlock);
                //}
                //else if (node.regulation == regulations[7])
                //{
                //    // 7: ScopeBlock : 'SCOPE' Model 'ENDSCOPE' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var eNDSCOPE0 = obj as string;
                //    obj = context.objStack.Pop(); var model1 = obj as Model;
                //    obj = context.objStack.Pop(); var sCOPE2 = obj as string;
                //    var scopeBlock = new ScopeBlock(/*sCOPE2, model1, eNDSCOPE0*/);
                //    context.objStack.Push(scopeBlock);
                //}
                //else if (node.regulation == regulations[8])
                //{
                //    // 8: ScopeBlock : 'SCOPE' 'ENDSCOPE' '/' IdList '/' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var slash0 = obj as string;
                //    obj = context.objStack.Pop(); var idList1 = obj as IdList;
                //    obj = context.objStack.Pop(); var slash2 = obj as string;
                //    obj = context.objStack.Pop(); var eNDSCOPE3 = obj as string;
                //    obj = context.objStack.Pop(); var sCOPE4 = obj as string;
                //    var scopeBlock = new ScopeBlock(/*sCOPE4, eNDSCOPE3, slash2, idList1, slash0*/);
                //    context.objStack.Push(scopeBlock);
                //}
                //else if (node.regulation == regulations[9])
                //{
                //    // 9: ScopeBlock : 'SCOPE' 'ENDSCOPE' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var eNDSCOPE0 = obj as string;
                //    obj = context.objStack.Pop(); var sCOPE1 = obj as string;
                //    var scopeBlock = new ScopeBlock(/*sCOPE1, eNDSCOPE0*/);
                //    context.objStack.Push(scopeBlock);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[6])
                {
                    // 6: <ScopeBlock> ::= "SCOPE" <Model> "ENDSCOPE" "/" <IdList> "/" ;
                    object obj;
                    obj = context.objStack.Pop(); var idList = obj as List<string>;
                    obj = context.objStack.Pop(); var entityList = obj as List<StepEntity>;
                    bool scope = true;
                    context.objStack.Push(scope);
                    context.objStack.Push(entityList);
                    context.objStack.Push(idList);
                }
                else if (node.regulation == regulations[7])
                {
                    // 7: <ScopeBlock> ::= "SCOPE" <Model> "ENDSCOPE" ;
                    object obj;
                    /*obj = context.objStack.Pop();*/
                    var idList = new List<string>();
                    obj = context.objStack.Pop(); var entityList = obj as List<StepEntity>;
                    bool scope = true;
                    context.objStack.Push(scope);
                    context.objStack.Push(entityList);
                    context.objStack.Push(idList);
                }
                else if (node.regulation == regulations[8])
                {
                    // 8: <ScopeBlock> ::= "SCOPE" "ENDSCOPE" "/" <IdList> "/" ;
                    object obj;
                    obj = context.objStack.Pop(); var idList = obj as List<string>;
                    /*obj = context.objStack.Pop();*/
                    var entityList = new List<StepEntity>();
                    bool scope = true;
                    context.objStack.Push(scope);
                    context.objStack.Push(entityList);
                    context.objStack.Push(idList);
                }
                else if (node.regulation == regulations[9])
                {
                    // 9: <ScopeBlock> ::= "SCOPE" "ENDSCOPE" ;
                    //object obj;
                    /*obj = context.objStack.Pop();*/
                    var idList = new List<string>();
                    /*obj = context.objStack.Pop();*/
                    var entityList = new List<StepEntity>();
                    bool scope = false;
                    context.objStack.Push(scope);
                    context.objStack.Push(entityList);
                    context.objStack.Push(idList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.IdList,
            (node, context) =>
            {
                //if (node.regulation == regulations[10])
                //{
                //    // 10: IdList : IdList ',' 'Identity' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var identity0 = obj as string;
                //    obj = context.objStack.Pop(); var comma1 = obj as string;
                //    obj = context.objStack.Pop(); var idList2 = obj as IdList;
                //    var idList = new IdList(/*idList2, comma1, identity0*/);
                //    context.objStack.Push(idList);
                //}
                //else if (node.regulation == regulations[11])
                //{
                //    // 11: IdList : 'Identity' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var identity0 = obj as string;
                //    var idList = new IdList(/*identity0*/);
                //    context.objStack.Push(idList);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[10])
                {
                    // 10: <IdList> ::= <IdList> "," "Identity" ;
                    object obj;
                    obj = context.objStack.Pop(); var identity = obj as string;
                    obj = context.objStack.Pop(); var idList = obj as List<string>;
                    idList.Add(identity);
                    context.objStack.Push(idList);
                }
                else if (node.regulation == regulations[11])
                {
                    // 11: <IdList> ::= "Identity" ;
                    object obj;
                    obj = context.objStack.Pop(); var identity = obj as string;
                    /*obj = context.objStack.Pop();*/
                    var idList = new List<string>();
                    idList.Add(identity);
                    context.objStack.Push(idList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.EntityBody,
            (node, context) =>
            {
                //if (node.regulation == regulations[12])
                //{
                //    // 12: EntityBody : TypeObj ;
                //    object obj;
                //    obj = context.objStack.Pop(); var typeObj0 = obj as TypeObj;
                //    var entityBody = new EntityBody(/*typeObj0*/);
                //    context.objStack.Push(entityBody);
                //}
                //else if (node.regulation == regulations[13])
                //{
                //    // 13: EntityBody : '(' Complex ')' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var rightParenthesis0 = obj as string;
                //    obj = context.objStack.Pop(); var complex1 = obj as Complex;
                //    obj = context.objStack.Pop(); var leftParenthesis2 = obj as string;
                //    var entityBody = new EntityBody(/*leftParenthesis2, complex1, rightParenthesis0*/);
                //    context.objStack.Push(entityBody);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[12])
                {
                    // 12: <EntityBody> ::= <TypeObj> ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    var typeObjList = new List<StepTypeObj>();
                    typeObjList.Add(typeObj);
                    context.objStack.Push(typeObjList);
                }
                else if (node.regulation == regulations[13])
                {
                    // 13: <EntityBody> ::= "(" <Complex> ")" ;
                    // Comment this because it makes no change.
                    //object obj;
                    //obj = context.objStack.Pop(); var typeObjList = obj as List<StepTypeObj>;
                    //context.objStack.Push(typeObjList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.TypeObj,
            (node, context) =>
            {
                //if (node.regulation == regulations[14])
                //{
                //    // 14: TypeObj : 'TypeName' LArgsJ ;
                //    object obj;
                //    obj = context.objStack.Pop(); var lArgsJ0 = obj as LArgsJ;
                //    obj = context.objStack.Pop(); var typeName1 = obj as string;
                //    var typeObj = new TypeObj(/*typeName1, lArgsJ0*/);
                //    context.objStack.Push(typeObj);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[14])
                {
                    // 14: <TypeObj> ::= "TypeName" <LArgsJ> ;
                    object obj;
                    obj = context.objStack.Pop(); var argList = obj as List<StepArg>;
                    obj = context.objStack.Pop(); var typeName = obj as string;
                    var typeObj = new StepTypeObj(typeName, argList);
                    context.objStack.Push(typeObj);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Complex,
            (node, context) =>
            {
                //if (node.regulation == regulations[15])
                //{
                //    // 15: Complex : Complex TypeObj ;
                //    object obj;
                //    obj = context.objStack.Pop(); var typeObj0 = obj as TypeObj;
                //    obj = context.objStack.Pop(); var complex1 = obj as Complex;
                //    var complex = new Complex(/*complex1, typeObj0*/);
                //    context.objStack.Push(complex);
                //}
                //else if (node.regulation == regulations[16])
                //{
                //    // 16: Complex : TypeObj ;
                //    object obj;
                //    obj = context.objStack.Pop(); var typeObj0 = obj as TypeObj;
                //    var complex = new Complex(/*typeObj0*/);
                //    context.objStack.Push(complex);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[15])
                {
                    // 15: <Complex> ::= <Complex> <TypeObj> ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    obj = context.objStack.Pop(); var typeObjList = obj as List<StepTypeObj>;
                    typeObjList.Add(typeObj);
                    context.objStack.Push(typeObjList);
                }
                else if (node.regulation == regulations[16])
                {
                    // 16: <Complex> ::= <TypeObj> ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    /*obj = context.objStack.Pop();*/
                    var typeObjList = new List<StepTypeObj>();
                    typeObjList.Add(typeObj);
                    context.objStack.Push(typeObjList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.HeadLine,
            (node, context) =>
            {
                //if (node.regulation == regulations[17])
                //{
                //    // 17: HeadLine : HeadLine TypeObj ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var typeObj1 = obj as TypeObj;
                //    obj = context.objStack.Pop(); var headLine2 = obj as HeadLine;
                //    var headLine = new HeadLine(/*headLine2, typeObj1, semicolon0*/);
                //    context.objStack.Push(headLine);
                //}
                //else if (node.regulation == regulations[18])
                //{
                //    // 18: HeadLine : TypeObj ';' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var semicolon0 = obj as string;
                //    obj = context.objStack.Pop(); var typeObj1 = obj as TypeObj;
                //    var headLine = new HeadLine(/*typeObj1, semicolon0*/);
                //    context.objStack.Push(headLine);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[17])
                {
                    // 17: <HeadLine> ::= <HeadLine> <TypeObj> ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    obj = context.objStack.Pop(); var typeObjList = obj as List<StepTypeObj>;
                    typeObjList.Add(typeObj);
                    context.objStack.Push(typeObjList);
                }
                else if (node.regulation == regulations[18])
                {
                    // 18: <HeadLine> ::= <TypeObj> ";" ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    /*obj = context.objStack.Pop();*/
                    var typeObjList = new List<StepTypeObj>();
                    typeObjList.Add(typeObj);
                    context.objStack.Push(typeObjList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.LArgsJ,
            (node, context) =>
            {
                //if (node.regulation == regulations[19])
                //{
                //    // 19: LArgsJ : '(' Args ')' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var rightParenthesis0 = obj as string;
                //    obj = context.objStack.Pop(); var args1 = obj as Args;
                //    obj = context.objStack.Pop(); var leftParenthesis2 = obj as string;
                //    var lArgsJ = new LArgsJ(/*leftParenthesis2, args1, rightParenthesis0*/);
                //    context.objStack.Push(lArgsJ);
                //}
                //else if (node.regulation == regulations[20])
                //{
                //    // 20: LArgsJ : '(' ')' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var rightParenthesis0 = obj as string;
                //    obj = context.objStack.Pop(); var leftParenthesis1 = obj as string;
                //    var lArgsJ = new LArgsJ(/*leftParenthesis1, rightParenthesis0*/);
                //    context.objStack.Push(lArgsJ);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[19])
                {
                    // 19: <LArgsJ> ::= "(" <Args> ")" ;
                    // Comment this because it makes no change.
                    //object obj;
                    //obj = context.objStack.Pop(); var argList = obj as List<StepArg>;
                    //context.objStack.Push(argList);
                }
                else if (node.regulation == regulations[20])
                {
                    // 20: <LArgsJ> ::= "(" ")" ;
                    var argList = new List<StepArg>();
                    context.objStack.Push(argList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Args,
            (node, context) =>
            {
                //if (node.regulation == regulations[21])
                //{
                //    // 21: Args : Args ',' Arg ;
                //    object obj;
                //    obj = context.objStack.Pop(); var arg0 = obj as Arg;
                //    obj = context.objStack.Pop(); var comma1 = obj as string;
                //    obj = context.objStack.Pop(); var args2 = obj as Args;
                //    var args = new Args(/*args2, comma1, arg0*/);
                //    context.objStack.Push(args);
                //}
                //else if (node.regulation == regulations[22])
                //{
                //    // 22: Args : Arg ;
                //    object obj;
                //    obj = context.objStack.Pop(); var arg0 = obj as Arg;
                //    var args = new Args(/*arg0*/);
                //    context.objStack.Push(args);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[21])
                {
                    // 21: <Args> ::= <Args> "," <Arg> ;
                    object obj;
                    obj = context.objStack.Pop(); var arg = obj as StepArg;
                    obj = context.objStack.Pop(); var argList = obj as List<StepArg>;
                    argList.Add(arg);
                    context.objStack.Push(argList);
                }
                else if (node.regulation == regulations[22])
                {
                    // 22: <Args> ::= <Arg> ;
                    object obj;
                    obj = context.objStack.Pop(); var arg = obj as StepArg;
                    /*obj = context.objStack.Pop();*/
                    var argList = new List<StepArg>();
                    argList.Add(arg);
                    context.objStack.Push(argList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Arg,
            (node, context) =>
            {
                //if (node.regulation == regulations[23])
                //{
                //    // 23: Arg : 'Identity' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var identity0 = obj as string;
                //    var arg = new Arg(/*identity0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[24])
                //{
                //    // 24: Arg : '$' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var dollar0 = obj as string;
                //    var arg = new Arg(/*dollar0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[25])
                //{
                //    // 25: Arg : '*' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var asterisk0 = obj as string;
                //    var arg = new Arg(/*asterisk0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[26])
                //{
                //    // 26: Arg : 'String' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var string0 = obj as string;
                //    var arg = new Arg(/*string0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[27])
                //{
                //    // 27: Arg : 'Integer' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var integer0 = obj as string;
                //    var arg = new Arg(/*integer0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[28])
                //{
                //    // 28: Arg : 'Float' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var float0 = obj as string;
                //    var arg = new Arg(/*float0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[29])
                //{
                //    // 29: Arg : 'Hexadecimal' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var hexadecimal0 = obj as string;
                //    var arg = new Arg(/*hexadecimal0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[30])
                //{
                //    // 30: Arg : 'Enum' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var enum0 = obj as string;
                //    var arg = new Arg(/*enum0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[31])
                //{
                //    // 31: Arg : LArgsJ ;
                //    object obj;
                //    obj = context.objStack.Pop(); var lArgsJ0 = obj as LArgsJ;
                //    var arg = new Arg(/*lArgsJ0*/);
                //    context.objStack.Push(arg);
                //}
                //else if (node.regulation == regulations[32])
                //{
                //    // 32: Arg : TypeObj ;
                //    object obj;
                //    obj = context.objStack.Pop(); var typeObj0 = obj as TypeObj;
                //    var arg = new Arg(/*typeObj0*/);
                //    context.objStack.Push(arg);
                //}
                //else { throw new NotImplementedException(); }
                if (node.regulation == regulations[23])
                {
                    // 23: <Arg> ::= "Identity" ;
                    object obj;
                    obj = context.objStack.Pop(); var identity = obj as string;
                    var arg = new StepArg23(identity);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[24])
                {
                    // 24: <Arg> ::= "Dollar" ;
                    object obj;
                    obj = context.objStack.Pop(); var dollar = obj as string;
                    var arg = new StepArg24(dollar);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[25])
                {
                    // 25: <Arg> ::= "Asterisk" ;
                    object obj;
                    obj = context.objStack.Pop(); var asterisk = obj as string;
                    var arg = new StepArg25(asterisk);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[26])
                {
                    // 26: <Arg> ::= "String" ;
                    object obj;
                    obj = context.objStack.Pop(); var string_ = obj as string;
                    var arg = new StepArg26(string_);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[27])
                {
                    // 27: <Arg> ::= "Integer" ;
                    object obj;
                    obj = context.objStack.Pop(); var integer = obj as string;
                    var arg = new StepArg27(integer);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[28])
                {
                    // 28: <Arg> ::= "Float" ;
                    object obj;
                    obj = context.objStack.Pop(); var float_ = obj as string;
                    var arg = new StepArg28(float_);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[29])
                {
                    // 29: <Arg> ::= "Hexadecimal" ;
                    object obj;
                    obj = context.objStack.Pop(); var hexadecimal = obj as string;
                    var arg = new StepArg29(hexadecimal);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[30])
                {
                    // 30: <Arg> ::= "Enum" ;
                    object obj;
                    obj = context.objStack.Pop(); var Enum_ = obj as string;
                    var arg = new StepArg30(Enum_);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[31])
                {
                    // 31: <Arg> ::= <LArgsJ> ;
                    object obj;
                    obj = context.objStack.Pop(); var argList = obj as List<StepArg>;
                    var arg = new StepArg31(argList);
                    context.objStack.Push(arg);
                }
                else if (node.regulation == regulations[32])
                {
                    // 32: <Arg> ::= <TypeObj> ;
                    object obj;
                    obj = context.objStack.Pop(); var typeObj = obj as StepTypeObj;
                    var arg = new StepArg32(typeObj);
                    context.objStack.Push(arg);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }

}