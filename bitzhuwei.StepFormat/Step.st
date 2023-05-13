// 现在（2023年3月28日15:19:36）我能处理的文法：可以有左递归，不可以有empty。
// 现在（2023年4月12日15:14:41）：可以有empty。

// 总结构
StepFile       : 'STEP' ';' 'HEADER' ';' HeadLine 'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';'
               | 'STEP' ';' 'HEADER' ';'          'ENDSEC' ';' 'DATA' ';' Model 'ENDSEC' ';' 'ENDSTEP' ';' ;

////////////////////////////////////////////////

// model部分，即主要数据所在的地方
Model          : Entity | Model Entity ;

Entity         : 'EntityId' '=' ScopeBlock EntityBody ';'
               | 'EntityId' '='            EntityBody ';' ;
ScopeBlock     : 'SCOPE' Model 'ENDSCOPE' '/' IdList '/' 
               | 'SCOPE' Model 'ENDSCOPE' 
               | 'SCOPE'       'ENDSCOPE' '/' IdList '/' 
               | 'SCOPE'       'ENDSCOPE' ;
IdList         : IdList ',' 'Identity' | 'Identity' ;   // #123, #456, #789
EntityBody     : TypeObj
               | '(' Complex ')' ; 
TypeObj        : 'TypeName' LArgsJ ;
Complex        : Complex TypeObj | TypeObj ;
////////////////////////////////////////////////

// HEADER包含的信息，估计没用，暂时不看。好吧看了。
HeadLine       : HeadLine TypeObj ';' | TypeObj ';' ;

////////////////////////////////////////////////
// 共用的结构们
LArgsJ         : '(' Args ')' // /* liste normale, non vide */ 正常列表，不是空的
               | '(' ')' ;       // /* liste vide (peut y en avoir) */ 空列表(可能有)
Args           : Args ',' Arg | Arg ;
Arg            : 'Identity'           // { StepData-SetTypeArg(Interface_ParamIdent); StepData-CreateNewArg(); }
               | '$'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | '*'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | 'String'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | 'Integer'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | 'Float'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | 'Hexadecimal'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | 'Enum'            // { StepData-CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
               | LArgsJ         // { StepData-CreateNewArg(); } /*  rec_newent lors du ')' */ 最近的新闻
               | TypeObj // { StepData-CreateNewArg(); } /*  liste typee  */
               // | error           // { StepData-CreateErrorArg(); } /* Erreur sur Parametre : tacher de le noter sans jeter l'Entite  */ 参数错误:删除注释而不丢弃实体
               ;
'EntityId'     : %%#[0-9]+/[ \t\r\n]*=%%
'Identity'     : %%#[0-9]+%%
'String'       : %%'[ -~]+'/[ \t\r\n]*[,)]%%

