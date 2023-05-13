// 8 VnRegulations:
Additive : Additive '+' Multiplicative // [0]
         | Additive '-' Multiplicative // [1]
         | Multiplicative ; // [2]
Multiplicative : Multiplicative '*' Primary // [3]
               | Multiplicative '/' Primary // [4]
               | Primary ; // [5]
Primary : '(' Additive ')' // [6]
        | 'number' ; // [7]
// 1 VtPatterns:
'number' : %%[0-9]+%% ; // [0]
