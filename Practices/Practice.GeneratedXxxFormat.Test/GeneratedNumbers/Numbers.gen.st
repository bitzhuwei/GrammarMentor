// 4 VnRegulations:
Numbers : Numbers Number // [0]
        | Number ; // [1]
Number : 'integer' // [2]
       | 'float' ; // [3]
// 2 VtPatterns:
'integer' : %%[0-9]+%% ; // [0]
'float' : %%[0-9]+\.[0-9]+%% ; // [1]
