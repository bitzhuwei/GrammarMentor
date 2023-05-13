
%token STEP HEADER ENDSEC DATA ENDSTEP SCOPE ENDSCOPE ENTITY TYPE INTEGER FLOAT IDENT TEXT NONDEF ENUM HEXA QUID
%start stepf

%code requires {
	#include <StepFile_ReadData.hxx>
	namespace step {
		class scanner;
	};

	#undef yylex
	#define yylex scanner->lex
	#define StepData scanner->myDataModel

	void StepFile_Interrupt (Standard_CString theErrorMessage, const Standard_Boolean theIsFail);
	#include "FlexLexer.h"

	namespace step {
		class scanner : public stepFlexLexer
		{
		public:
			explicit scanner(StepFile_ReadData* theDataModel, std::istream* in = 0, std::ostream* out = 0);

			int lex(step::parser::semantic_type* yylval);

			StepFile_ReadData* myDataModel;
		};
	};
}

%%

// 总结构
stepf   : stepf1 | stepf2 | stepf3 {  return(0); } ; /*  fini pour celui-la  */ 这个人完了
stepf1  : STEP HEADER headl ENDSEC endhead model ENDSEC finstep ;
stepf2  : STEP HEADER       ENDSEC endhead model ENDSEC ENDSTEP ;
stepf3  : STEP HEADER       ENDSEC endhead model error ;

/*  N.B. : les commentaires sont filtres par LEX  */ 注释被LEX过滤
/*  La fin vide (selon systeme emetteur) est filtree ici  */ 空结尾(根据发射系统)在这里是过滤器

finstep	: ENDSTEP | ENDSTEP finvide ;
finvide : ' ' | finvide ' ' ;
////////////////////////////////////////////////
// model部分，即主要数据所在的地方
model   : bloc | model bloc ;
bloc    : entlab '=' debscop model finscop unent ';'
        | entlab '=' debscop finscop unent ';'
        | entlab '=' unent ';'
        | error   /*  Erreur sur Entite : la sauter  */
entlab  : ENTITY { StepData->RecordIdent(); } ;
debscop : SCOPE { StepData->AddNewScope(); } ;
finscop : ENDSCOPE debexp export '/' 
          /*  La liste Export est prise comme ARGUMENT du EndScope  */ Export列表作为EndScope的参数
          { printf("***  Warning : Export List not yet processed\n"); StepData->RecordNewEntity(); StepData->FinalOfScope(); }
        | ENDSCOPE { StepData->FinalOfScope(); } ;
debexp  : '/' { StepData->RecordListStart(); } ;
export  : export ',' unid
        | unid;  // ENDSCOPE / #123, #456, #789
unid    : IDENT { StepData->SetTypeArg(Interface_ParamIdent); StepData->CreateNewArg(); } ;


unent   : enttype listarg /*    Entite de Type Simple    */
        | '(' plex ')'    /*    Entite de Type Complexe  */ ;
enttype : TYPE { StepData->RecordType(); } ;
listarg : deblist arglist finlist /* liste normale, non vide */ 正常列表，不是空的
        | deblist finlist ; /* liste vide (peut y en avoir) */ 空列表(可能有)
deblist : '(' { StepData->RecordListStart(); } ;
finlist	: ')' 
          {
              if (StepData->GetModePrint() > 0)
              {
                  printf("Record no : %d -- ", StepData->GetNbRecord()+1); StepData->PrintCurrentRecord();
              }
              StepData->RecordNewEntity ();
              yyerrstatus_ = 0;
          } ;
arglist	: arglist ',' unarg
        | unarg ;
unarg   : IDENT           { StepData->SetTypeArg(Interface_ParamIdent); StepData->CreateNewArg(); }
        | QUID            { StepData->CreateNewArg(); } /* deja fait par lex*/ lex已经做过了
        | listarg         { StepData->CreateNewArg(); } /*  rec_newent lors du ')' */ 最近的新闻
        | listype listarg { StepData->CreateNewArg(); } /*  liste typee  */
        | error           { StepData->CreateErrorArg(); } /* Erreur sur Parametre : tacher de le noter sans jeter l'Entite  */ 参数错误:删除注释而不丢弃实体
          ;
listype : TYPE { StepData->RecordTypeText(); } ;
plex    : plex enttype listarg /* sert a ce qui suit : */ 服务于以下目的
        | enttype listarg ;
////////////////////////////////////////////////
// HEADER包含的信息，估计没用，暂时不看。好吧看了。
headl   : headl headent
        | headent ;
headent : enttype listarg ';'
        | error /* Erreur sur Entite : la sauter */ 实体错误:跳过
          ;
endhead : DATA { StepData->FinalOfHead(); } ;




%%

