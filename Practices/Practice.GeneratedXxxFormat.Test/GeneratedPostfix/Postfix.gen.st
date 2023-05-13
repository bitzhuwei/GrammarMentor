// 3 VnRegulations:
Items : Items Item // [0]
      | Item ; // [1]
Item : 'entityId' '=' 'refEntity' ; // [2]
// 2 VtPatterns:
'entityId' : %%[0-9]+/=%% ; // [0]
'refEntity' : %%[0-9]+%% ; // [1]
