// 3 VnRegulations:
Ints : Ints ',' Int // [0]
     | Int ; // [1]
Int : 'integer' ; // [2]
// 1 VtPatterns:
'integer' : %%[0-9]+%% ; // [0]
