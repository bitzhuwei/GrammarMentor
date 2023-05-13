# '<<'

pattern: `\<\<`

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
eNFA21_4_13491266[["εNFA21-4 regex start"]]
eNFA21_0_54312533[["εNFA21-0 char{1, 1}"]]
eNFA21_1_19050756[["εNFA21-1 char[1]"]]
eNFA21_2_37239078[["εNFA21-2 char{1, 1}"]]
eNFA21_3_66716254[["εNFA21-3 char[1]"]]
eNFA21_5_63575380[["εNFA21-5 regex end"]]
eNFA21_6_35307513[["εNFA21-6 post-regex start"]]
eNFA21_7_49332166[\"εNFA21-7 post-regex end"/]
eNFA21_4_13491266 -.->|"ε"|eNFA21_0_54312533
eNFA21_0_54312533 -->|"<"|eNFA21_1_19050756
eNFA21_1_19050756 -.->|"ε"|eNFA21_2_37239078
eNFA21_2_37239078 -->|"<"|eNFA21_3_66716254
eNFA21_3_66716254 -.->|"ε"|eNFA21_5_63575380
eNFA21_5_63575380 -.->|"ε"|eNFA21_6_35307513
eNFA21_6_35307513 -.->|"ε"|eNFA21_7_49332166
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
eNFA21_4_41336317[["εNFA21-4 regex start"]]
eNFA21_0_36482533[["εNFA21-0 char{1, 1}"]]
eNFA21_1_59907344[["εNFA21-1 char[1]"]]
eNFA21_2_2295192[["εNFA21-2 char{1, 1}"]]
eNFA21_3_20656733[\"εNFA21-3 char[1]"/]
eNFA21_5_51692872[\"εNFA21-5 regex end"/]
eNFA21_6_62582666[\"εNFA21-6 post-regex start"/]
eNFA21_7_26373084[\"εNFA21-7 post-regex end"/]
eNFA21_4_41336317 -.->|"ε"|eNFA21_0_36482533
eNFA21_4_41336317 -->|"<"|eNFA21_1_59907344
eNFA21_0_36482533 -->|"<"|eNFA21_1_59907344
eNFA21_1_59907344 -.->|"ε"|eNFA21_2_2295192
eNFA21_1_59907344 -->|"<"|eNFA21_3_20656733
eNFA21_2_2295192 -->|"<"|eNFA21_3_20656733
eNFA21_3_20656733 -.->|"ε"|eNFA21_5_51692872
eNFA21_3_20656733 -.->|"ε"|eNFA21_6_62582666
eNFA21_3_20656733 -.->|"ε"|eNFA21_7_26373084
eNFA21_5_51692872 -.->|"ε"|eNFA21_6_62582666
eNFA21_5_51692872 -.->|"ε"|eNFA21_7_26373084
eNFA21_6_62582666 -.->|"ε"|eNFA21_7_26373084
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
NFA21_4_36031167("NFA21-4 regex start")
NFA21_1_55845053("NFA21-1 char[1]")
NFA21_3_32843429[\"NFA21-3 char[1]"/]
NFA21_4_36031167 -->|"<"|NFA21_1_55845053
NFA21_1_55845053 -->|"<"|NFA21_3_32843429
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
subgraph DFA0_-1245936452["DFA0 regex start"]
NFA21_4_36031167_0("NFA21-4 regex start")
end
subgraph DFA1_-1378892974["DFA1 {1}"]
NFA21_1_55845053_1("NFA21-1 char[1]")
end
subgraph DFA2_-658764375["DFA2 {1}"]
NFA21_3_32843429_2[\"NFA21-3 char[1]"/]
end
DFA0_-1245936452 -->|"<"|DFA1_-1378892974
DFA1_-1378892974 -->|"<"|DFA2_-658764375
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
DFA0_-1245936452{{"DFA0 regex start"}}
DFA1_-1378892974{{"DFA1 {1}"}}
DFA2_-658764375[\"DFA2 {1}"/]
DFA0_-1245936452 -->|"<"|DFA1_-1378892974
DFA1_-1378892974 -->|"<"|DFA2_-658764375
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
subgraph MiniDFA0_416976685["MiniDFA0 {1}"]
DFA0_-1245936452_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_764383522["MiniDFA1 {1}"]
DFA1_-1378892974_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-769944961["MiniDFA2 {1}"]
DFA2_-658764375_2[\"DFA2 {1}"/]
end
MiniDFA0_416976685 -->|"<"|MiniDFA1_764383522
MiniDFA1_764383522 -->|"<"|MiniDFA2_-769944961
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
MiniDFA0_416976685(["MiniDFA0 {1}"])
MiniDFA1_764383522(["MiniDFA1 {1}"])
MiniDFA2_-769944961[\"MiniDFA2 {1}"/]
MiniDFA0_416976685 -->|"<"|MiniDFA1_764383522
MiniDFA1_764383522 -->|"<"|MiniDFA2_-769944961
```
-------------------------------
