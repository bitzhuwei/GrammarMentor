# Compiler of `Postfix`

The C# source code of the compiler `Postfix` is generated by `bitzhuwei.GrammarFormat`.

## LR(1) Syntax Machine

| 状态 | \'entityId\' | \'=\' | \'refEntity\' | \'￥\' | Items | Item |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 | S3 |   |   |   | G1 | G2 |
| 1 | S3 |   |   | 完成 |   | G4 |
| 2 | R[1] |   |   | R[1] |   |   |
| 3 |   | S5 |   |   |   |   |
| 4 | R[0] |   |   | R[0] |   |   |
| 5 |   |   | S6 |   |   |   |
| 6 | R[2] |   |   | R[2] |   |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] Postfix2> : ⏳ Items ; '￥' 
[0] Items : ⏳ Items Item ; '￥' 'entityId' 
[1] Items : ⏳ Item ; '￥' 'entityId' 
[2] Item : ⏳ 'entityId' '=' 'refEntity' ; '￥' 'entityId' ")
syntaxState1("syntaxState1
[-1] Postfix2> : Items ⏳ ; '￥' 
[0] Items : Items ⏳ Item ; '￥' 'entityId' 
[2] Item : ⏳ 'entityId' '=' 'refEntity' ; '￥' 'entityId' ")
syntaxState2("syntaxState2
[1] Items : Item ⏳ ; '￥' 'entityId' ")
syntaxState3("syntaxState3
[2] Item : 'entityId' ⏳ '=' 'refEntity' ; '￥' 'entityId' ")
syntaxState4("syntaxState4
[0] Items : Items Item ⏳ ; '￥' 'entityId' ")
syntaxState5("syntaxState5
[2] Item : 'entityId' '=' ⏳ 'refEntity' ; '￥' 'entityId' ")
syntaxState6("syntaxState6
[2] Item : 'entityId' '=' 'refEntity' ⏳ ; '￥' 'entityId' ")
syntaxState0 -.-> |"Items"| syntaxState1
syntaxState0 -.-> |"Item"| syntaxState2
syntaxState0 --> |"'entityId'"| syntaxState3
syntaxState1 -.-> |"Item"| syntaxState4
syntaxState1 --> |"'entityId'"| syntaxState3
syntaxState3 --> |"'='"| syntaxState5
syntaxState5 --> |"'refEntity'"| syntaxState6
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'￥' 'entityId' 
R[1]= Items : Item ;"| syntaxState2
syntaxState4 x==x |"'￥' 'entityId' 
R[0]= Items : Items Item ;"| syntaxState4
syntaxState6 x==x |"'￥' 'entityId' 
R[2]= Item : 'entityId' '=' 'refEntity' ;"| syntaxState6


```

