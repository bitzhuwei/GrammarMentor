// GrammarName=Grammar
// ExtractedType=GrammarDraft
//-------------Syntax Statements-----------------
StatementList         : StatementList Statement | Statement ;
Statement             : SyntaxProduction | LexiProduction ;
SyntaxProduction      : 'Vn' ':' CandidateList ';' ;
CandidateList         : CandidateList '|' Candidate | Candidate ;
Candidate             : Candidate V | V ;
V                     : 'Vn' | 'Vt' | 'empty' ; // V is Vn or Vt or the keyword(empty).
LexiProduction        : 'Vt' ':' 'pattern' ';' ;
//--------------Lexi Statements------------------
'Vn'                  : %%[a-zA-Z_][a-zA-Z0-9_]*%% ;
'Vt'                  : %%'([ -&]|\\'|[(-\[]|\\\\|[\]-~])+'%% ; // any char or \'
'pattern'             : %%[%]{2}[ -~]+[%]{2}%% ;
'MultipleLineComment' : %%\/\*.*\*\/%% ; // omissible
'SingleLineComment'   : %%//.*%% ; // omissible

// something(...) between %%...%%
// GrammarName=Pattern
// ExtractedType=SomeToken
// VnRegulations:
Pattern       : PreRegex Regex PostRegex ;
PreRegex      : 'refVt' | empty ;
PostRegex     : '/' Regex | empty ;
Regex         : Regex '|' Bunch | Bunch;
Bunch         : Bunch Unit | Unit ;
Unit          : 'char' Repeat | 'scope' Repeat | '(' Regex ')' Repeat ;
Repeat        : '?' | '+' | '*' | '{' 'min' UpperBound '}' | empty ;
UpperBound    : ',' 'max' | ',' | empty ;
// VtRegex:
'refVt'       : %%\<'([ -&]|\\'|[(-\[]|\\\\|[\]-~])+'\>%% // start with <' and end with '> 
// 'char' is a letter or an escape
// letter:  !"# %&'   ,-   0..9:;<=>   @A..Z _`a..z   ~
// escape: content:    $()*+./?[\]^{|}
//         appearance: \$   \( \) \* \+   \.  \/   \?   \[ \\ \] \^   \{ \| \}
//  content   : %%[- !"#%&',0-9:;<=>@A-Z_`a-z~]| \u[0-9A-Fa-f]{4}| \[$()*+./<>?]| \[ | \\ | \] | \^ | \{ | \| | \}%% ;
'char'        : %%[- !"#%&',0-9:;<=>@A-Z_`a-z~]|\\u[0-9A-Fa-f]{4}|\\[$()*+./<>?]|\\\[|\\\\|\\\]|\\\^|\\\{|\\\||\\\}%% ;
// letter:  !"# %&'   ,-   0...9:;<=>   @A...Z   _`a...z   ~
//         $   ()*+   .  /   ?   [   ](只可首字)   {|}
// escape: \\ \] \^(首字反义)
'scope'       : %%\[[ -~]+\]%% ; // a-z or A-Z or ...
'min'         : %%<'{'>[0-9]+%% ;
'max'         : %%<','>[0-9]+%% ;

```


```

# End
