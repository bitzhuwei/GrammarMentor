// GrammarName = Ints
// ExtractedType = IntArray
Ints : Ints Int | Int ;
Int : 'integer' ;
'integer' : %%[0-9]+%% ;