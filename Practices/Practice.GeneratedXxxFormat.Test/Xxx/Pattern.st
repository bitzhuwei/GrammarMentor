// something(...) between %%...%%
// GrammarName=Pattern
// ExtractedType=TokenDraft
// VnRegulations:
Pattern    : PreRegex Regex PostRegex ;
PreRegex   : 'refVt' | empty ;
PostRegex  : '/' Regex | empty ;
Regex      : Regex '|' Bunch | Bunch;
Bunch      : Bunch Unit | Unit ;
Unit       : 'char' Repeat | '.' Repeat | 'scope' Repeat | '(' Regex ')' Repeat ;
Repeat     : '?' | '+' | '*' | '{' 'min' UpperBound '}' | empty ;
UpperBound : ',' 'max' | ',' | empty ;
// VtRegex:
'refVt'    : %%\<'([ -&]|\\'|[(-~])+'\>%% ; // start with <' and end with '> 
'min'      : %%<'{'>[0-9]+%% ;
'max'      : %%<','>[0-9]+%% ;
// 'char' is a letter or an escape
'char'     : %%[ !"#%&',]|-|[0-9:;<=>@A-Z_`a-z~]|\\[$()*+]|\\-|\\[./<>?]|\\\[|\\\\|\\\]|\\\^|\\\{|\\\||\\\}|\\u[0-9a-fA-F]{4}%% ;
//'scope'    : %%\[((firstLetter1)(char)*|\^(firstLetter2)(char)*)\]%% ; // a-z or A-Z or ...
//firstLetter1 = \\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~]
//firstLetter2 = \\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~]
//char =         \\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~]
'scope'    : %%\[((\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~])(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~])*|\^(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~])(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~])*)\]%% ; // a-z or A-Z or ...