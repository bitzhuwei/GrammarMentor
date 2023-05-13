// GrammarName=Grammar
// ExtractedType=GrammarDraft
//-------------Syntax Statements-----------------
StatementList         : StatementList Statement | Statement ;
Statement             : SyntaxProduction | LexiProduction ;
SyntaxProduction      : 'Vn' ':' CandidateList ';' ;
CandidateList         : CandidateList '|' Candidate | Candidate ;
Candidate             : VList | 'empty' ; // candidate is a list of V or the keyword(empty)
VList                 : VList V | V ;
V                     : 'Vn' | 'Vt' ; // V is Vn or Vt.
LexiProduction        : 'Vt' ':' 'pattern' ';' ;
//--------------Lexi Statements------------------
'Vn'                  : %%[a-zA-Z_][a-zA-Z0-9_]*%% ; // identifier
'Vt'                  : %%'([ -&]|\\'|[(-\[]|\\\\|[\]-~])+'%% ; // any char or \'
'pattern'             : %%[%]{2}[ -~]([^%]|%[^%])*[%]{2}%% ; // %%xxx%%
