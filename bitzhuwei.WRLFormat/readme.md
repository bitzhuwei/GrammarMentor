# `WRL`文法

```
//-----------Syntax Statements----------------
SeparatorStart    : 'Separator' '{' PropertyGroupList '}' ;
PropertyGroupList : PropertyGroupList PropertyGroup | PropertyGroup ;
PropertyGroup     : GroupName '{' PropertyList '}' ;
GroupName         : 'identifier' ;
PropertyList      : PropertyList Property | Property ;
Property          : 'identifier' 'identifier' 
                  | 'ambientColor' '[' 'Float' 'Float' 'Float' ']' 
                  | 'diffuseColor' '[' 'Float' 'Float' 'Float' ']' 
                  | 'emissiveColor' '[' 'Float' 'Float' 'Float' ']' 
                  | 'specularColor' '[' 'Float' 'Float' 'Float' ']' 
                  | 'shininess' '[' 'Float' ']' 
                  | 'transparency' '[' 'Float' ']' 
                  | 'point' '[' PointList ']' 
                  | 'coordIndex' '[' CoordIndexList ']' ;
PointList         : PointList ',' Point | Point ;
Point             : 'Float' 'Float' 'Float' ;
CoordIndexList    : CoordIndexList ',' CoordIndex | CoordIndex ;
CoordIndex        : 'Integer' ;
//------------Lexi Statements-----------------
'{'               : %%\{%% ;
'}'               : %%\}%% ;
'['               : %%\[%% ;
']'               : %%\]%% ;
','               : %%,%% ;
'identifier'      : %%[a-zA-Z_][a-zA-Z0-9_]*%% ;
'ambientColor'    : %%ambientColor%% ;
'diffuseColor'    : %%diffuseColor%% ;
'emissiveColor'   : %%emissiveColor%% ;
'specularColor'   : %%specularColor%% ;
'shininess'       : %%shininess%% ;
'transparency'    : %%transparency%% ;
'point'           : %%point%% ;
'coordIndex'      : %%coordIndex%% ;
'Float'           : %%[+-]?[0-9]+([.][0-9]+)?%% ;
'Integer'         : %%[+-]?[0-9]+%% ;
```

# `WRL`文法（旧样式备查）

```
<SeparatorStart>    ::= "Separator" "{" <PropertyGroupList> "}" ;
<PropertyGroupList> ::= <PropertyGroupList> <PropertyGroup> | <PropertyGroup> ;
<PropertyGroup>     ::= <GroupName> "{" <PropertyList> "}" ;
<GroupName>         ::= "identifier" ;
<PropertyList>      ::= <PropertyList> <Property> | <Property> ;
<Property>          ::= "identifier" "identifier" 
                    |   "ambientColor" "[" "Float" "Float" "Float" "]" 
                    |   "diffuseColor" "[" "Float" "Float" "Float" "]" 
                    |   "emissiveColor" "[" "Float" "Float" "Float" "]" 
                    |   "specularColor" "[" "Float" "Float" "Float" "]" 
                    |   "shininess" "[" "Float" "]" 
                    |   "transparency" "[" "Float" "]" 
                    |   "point" "[" <PointList> "]" 
                    |   "coordIndex" "[" <CoordIndexList> "]" ;
<PointList>         ::= <PointList> "," <Point> | <Point> ;
<Point>             ::= "Float" "Float" "Float" ;
<CoordIndexList>         ::= <CoordIndexList> "," <CoordIndex> | <CoordIndex> ;
<CoordIndex>        ::= "Integer" ;
```

