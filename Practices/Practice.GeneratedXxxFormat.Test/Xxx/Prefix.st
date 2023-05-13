// GrammarName = Prefix
// ExtractedType = Prefix2
// 4 VnRegulations:
Items : Items Item | Item ;
Item : 'entityId' '=' 'refEntity' ;
// 2 VtPatterns:
'entityId'  : %%[0-9]+%% ;
'refEntity' : %%<'='>[0-9]+%% ;
