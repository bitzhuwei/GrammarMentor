# 'void'

pattern: `void`

-------------------------------
# 1/5: extracted ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA12_8_6720246[["εNFA12-8 regex start"]]
eNFA12_0_60482217[["εNFA12-0 char{1, 1}"]]
eNFA12_1_7469042[["εNFA12-1 char[1]"]]
eNFA12_2_112514[["εNFA12-2 char{1, 1}"]]
eNFA12_3_1012626[["εNFA12-3 char[1]"]]
eNFA12_4_9113635[["εNFA12-4 char{1, 1}"]]
eNFA12_5_14913854[["εNFA12-5 char[1]"]]
eNFA12_6_6965[["εNFA12-6 char{1, 1}"]]
eNFA12_7_62687[["εNFA12-7 char[1]"]]
eNFA12_9_564191[["εNFA12-9 regex end"]]
eNFA12_10_5077725[["εNFA12-10 post-regex start"]]
eNFA12_11_45699530[\"εNFA12-11 post-regex end"/]
eNFA12_8_6720246 -.->|"ε"|eNFA12_0_60482217
eNFA12_0_60482217 -->|"v"|eNFA12_1_7469042
eNFA12_1_7469042 -.->|"ε"|eNFA12_2_112514
eNFA12_2_112514 -->|"o"|eNFA12_3_1012626
eNFA12_3_1012626 -.->|"ε"|eNFA12_4_9113635
eNFA12_4_9113635 -->|"i"|eNFA12_5_14913854
eNFA12_5_14913854 -.->|"ε"|eNFA12_6_6965
eNFA12_6_6965 -->|"d"|eNFA12_7_62687
eNFA12_7_62687 -.->|"ε"|eNFA12_9_564191
eNFA12_9_564191 -.->|"ε"|eNFA12_10_5077725
eNFA12_10_5077725 -.->|"ε"|eNFA12_11_45699530
```
-------------------------------
# 2/5: manifested ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA12_8_8642591[["εNFA12-8 regex start"]]
eNFA12_0_10674462[["εNFA12-0 char{1, 1}"]]
eNFA12_1_28961294[["εNFA12-1 char[1]"]]
eNFA12_2_59325057[["εNFA12-2 char{1, 1}"]]
eNFA12_3_64163473[["εNFA12-3 char[1]"]]
eNFA12_4_40600350[["εNFA12-4 char{1, 1}"]]
eNFA12_5_29858833[["εNFA12-5 char[1]"]]
eNFA12_6_294043[["εNFA12-6 char{1, 1}"]]
eNFA12_7_2646389[\"εNFA12-7 char[1]"/]
eNFA12_9_23817504[\"εNFA12-9 regex end"/]
eNFA12_10_13030950[\"εNFA12-10 post-regex start"/]
eNFA12_11_50169686[\"εNFA12-11 post-regex end"/]
eNFA12_8_8642591 -.->|"ε"|eNFA12_0_10674462
eNFA12_8_8642591 -->|"v"|eNFA12_1_28961294
eNFA12_0_10674462 -->|"v"|eNFA12_1_28961294
eNFA12_1_28961294 -.->|"ε"|eNFA12_2_59325057
eNFA12_1_28961294 -->|"o"|eNFA12_3_64163473
eNFA12_2_59325057 -->|"o"|eNFA12_3_64163473
eNFA12_3_64163473 -.->|"ε"|eNFA12_4_40600350
eNFA12_3_64163473 -->|"i"|eNFA12_5_29858833
eNFA12_4_40600350 -->|"i"|eNFA12_5_29858833
eNFA12_5_29858833 -.->|"ε"|eNFA12_6_294043
eNFA12_5_29858833 -->|"d"|eNFA12_7_2646389
eNFA12_6_294043 -->|"d"|eNFA12_7_2646389
eNFA12_7_2646389 -.->|"ε"|eNFA12_9_23817504
eNFA12_7_2646389 -.->|"ε"|eNFA12_10_13030950
eNFA12_7_2646389 -.->|"ε"|eNFA12_11_50169686
eNFA12_9_23817504 -.->|"ε"|eNFA12_10_13030950
eNFA12_9_23817504 -.->|"ε"|eNFA12_11_50169686
eNFA12_10_13030950 -.->|"ε"|eNFA12_11_50169686
```
-------------------------------
# 3/5: NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
NFA12_8_48873995("NFA12-8 regex start")
NFA12_1_37212772("NFA12-1 char[1]")
NFA12_3_66479500("NFA12-3 char[1]")
NFA12_5_61444595("NFA12-5 char[1]")
NFA12_7_16130451[\"NFA12-7 char[1]"/]
NFA12_8_48873995 -->|"v"|NFA12_1_37212772
NFA12_1_37212772 -->|"o"|NFA12_3_66479500
NFA12_3_66479500 -->|"i"|NFA12_5_61444595
NFA12_5_61444595 -->|"d"|NFA12_7_16130451
```
-------------------------------
# 4/5: DFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph DFA0_368646440["DFA0 regex start"]
NFA12_8_48873995_0("NFA12-8 regex start")
end
subgraph DFA1_1042687584["DFA1 {1}"]
NFA12_1_37212772_1("NFA12-1 char[1]")
end
subgraph DFA2_-836908687["DFA2 {1}"]
NFA12_3_66479500_2("NFA12-3 char[1]")
end
subgraph DFA3_1225857791["DFA3 {1}"]
NFA12_5_61444595_3("NFA12-5 char[1]")
end
subgraph DFA4_1605682222["DFA4 {1}"]
NFA12_7_16130451_4[\"NFA12-7 char[1]"/]
end
DFA0_368646440 -->|"v"|DFA1_1042687584
DFA1_1042687584 -->|"o"|DFA2_-836908687
DFA2_-836908687 -->|"i"|DFA3_1225857791
DFA3_1225857791 -->|"d"|DFA4_1605682222
```
-------------------------------
# 4/5: DFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
DFA0_368646440{{"DFA0 regex start"}}
DFA1_1042687584{{"DFA1 {1}"}}
DFA2_-836908687{{"DFA2 {1}"}}
DFA3_1225857791{{"DFA3 {1}"}}
DFA4_1605682222[\"DFA4 {1}"/]
DFA0_368646440 -->|"v"|DFA1_1042687584
DFA1_1042687584 -->|"o"|DFA2_-836908687
DFA2_-836908687 -->|"i"|DFA3_1225857791
DFA3_1225857791 -->|"d"|DFA4_1605682222
```
-------------------------------
# 5/5: miniDFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph MiniDFA0_1091446713["MiniDFA0 {1}"]
DFA0_368646440_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_57622796["MiniDFA1 {1}"]
DFA1_1042687584_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1808758135["MiniDFA2 {1}"]
DFA2_-836908687_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_504402879["MiniDFA3 {1}"]
DFA3_1225857791_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1167211473["MiniDFA4 {1}"]
DFA4_1605682222_4[\"DFA4 {1}"/]
end
MiniDFA0_1091446713 -->|"v"|MiniDFA1_57622796
MiniDFA1_57622796 -->|"o"|MiniDFA2_-1808758135
MiniDFA2_-1808758135 -->|"i"|MiniDFA3_504402879
MiniDFA3_504402879 -->|"d"|MiniDFA4_1167211473
```
-------------------------------
# 5/5: miniDFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
MiniDFA0_1091446713(["MiniDFA0 {1}"])
MiniDFA1_57622796(["MiniDFA1 {1}"])
MiniDFA2_-1808758135(["MiniDFA2 {1}"])
MiniDFA3_504402879(["MiniDFA3 {1}"])
MiniDFA4_1167211473[\"MiniDFA4 {1}"/]
MiniDFA0_1091446713 -->|"v"|MiniDFA1_57622796
MiniDFA1_57622796 -->|"o"|MiniDFA2_-1808758135
MiniDFA2_-1808758135 -->|"i"|MiniDFA3_504402879
MiniDFA3_504402879 -->|"d"|MiniDFA4_1167211473
```
-------------------------------
