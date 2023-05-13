// GrammarName = Ints2
// ExtractedType = Ints2Array
Ints : Ints ',' Int | Int ;
Int : 'integer' ;
'integer' : %%[0-9]+%% ;