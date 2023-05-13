// 7 VnRegulations:
Scope : '[' 'firstItem1' RangeItems ']' // [0]
      | '[^' 'firstItem2' RangeItems ']' // [1]
      | '[' 'firstItem1' ']' // [2]
      | '[^' 'firstItem2' ']' ; // [3]
RangeItems : RangeItems RangeItem // [4]
           | RangeItem ; // [5]
RangeItem : 'char' ; // [6]
// 3 VtPatterns:
'firstItem1' : %%<'['>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~]%% ; // [0]
'firstItem2' : %%<'[^'>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~]%% ; // [1]
'char' : %%\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~]%% ; // [2]
