// GrammarName = Numbers
// ExtractedType = NumberArray
Numbers : Numbers Number | Number ;
Number  : 'integer' | 'float' ;
'integer' : %%[0-9]+%% ;
'float'   : %%[0-9]+\.[0-9]+%% ;