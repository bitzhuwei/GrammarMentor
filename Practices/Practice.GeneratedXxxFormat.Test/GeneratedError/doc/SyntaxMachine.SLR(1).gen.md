# Compiler of `Error`

The C# source code of the compiler `Error` is generated by `bitzhuwei.GrammarFormat`.

## SLR(1) Syntax Machine

| 状态 | \'refVt\' | \'￥\' | PreRegex |
|:---:|:---:|:---:|:---:|
| 0 | S2 |   | G1 |
| 1 |   | 完成 |   |
| 2 |   | R[0] |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"SLR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] Error2> : ⏳ PreRegex ; 
[0] PreRegex : ⏳ 'refVt' ; ")
syntaxState1("syntaxState1
[-1] Error2> : PreRegex ⏳ ; ")
syntaxState2("syntaxState2
[0] PreRegex : 'refVt' ⏳ ; ")
syntaxState0 -.-> |"PreRegex"| syntaxState1
syntaxState0 --> |"'refVt'"| syntaxState2
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'￥' 
R[0]= PreRegex : 'refVt' ;"| syntaxState2


```

