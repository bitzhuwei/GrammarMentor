# '[^'

pattern: `\[\^`

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
eNFA6_4_64248638[["εNFA6-4 regex start"]]
eNFA6_0_41366830[["εNFA6-0 char{1, 1}"]]
eNFA6_1_36757156[["εNFA6-1 char[1]"]]
eNFA6_2_62378952[["εNFA6-2 char{1, 1}"]]
eNFA6_3_24539659[["εNFA6-3 char[1]"]]
eNFA6_5_19530342[["εNFA6-5 regex end"]]
eNFA6_6_41555354[["εNFA6-6 post-regex start"]]
eNFA6_7_38453873[\"εNFA6-7 post-regex end"/]
eNFA6_4_64248638 -.->|"ε"|eNFA6_0_41366830
eNFA6_0_41366830 -->|"["|eNFA6_1_36757156
eNFA6_1_36757156 -.->|"ε"|eNFA6_2_62378952
eNFA6_2_62378952 -->|"^"|eNFA6_3_24539659
eNFA6_3_24539659 -.->|"ε"|eNFA6_5_19530342
eNFA6_5_19530342 -.->|"ε"|eNFA6_6_41555354
eNFA6_6_41555354 -.->|"ε"|eNFA6_7_38453873
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
eNFA6_4_10540538[["εNFA6-4 regex start"]]
eNFA6_0_27755984[["εNFA6-0 char{1, 1}"]]
eNFA6_1_48477267[["εNFA6-1 char[1]"]]
eNFA6_2_33642220[["εNFA6-2 char{1, 1}"]]
eNFA6_3_34344524[\"εNFA6-3 char[1]"/]
eNFA6_5_40665260[\"εNFA6-5 regex end"/]
eNFA6_6_30443021[\"εNFA6-6 post-regex start"/]
eNFA6_7_5551736[\"εNFA6-7 post-regex end"/]
eNFA6_4_10540538 -.->|"ε"|eNFA6_0_27755984
eNFA6_4_10540538 -->|"["|eNFA6_1_48477267
eNFA6_0_27755984 -->|"["|eNFA6_1_48477267
eNFA6_1_48477267 -.->|"ε"|eNFA6_2_33642220
eNFA6_1_48477267 -->|"^"|eNFA6_3_34344524
eNFA6_2_33642220 -->|"^"|eNFA6_3_34344524
eNFA6_3_34344524 -.->|"ε"|eNFA6_5_40665260
eNFA6_3_34344524 -.->|"ε"|eNFA6_6_30443021
eNFA6_3_34344524 -.->|"ε"|eNFA6_7_5551736
eNFA6_5_40665260 -.->|"ε"|eNFA6_6_30443021
eNFA6_5_40665260 -.->|"ε"|eNFA6_7_5551736
eNFA6_6_30443021 -.->|"ε"|eNFA6_7_5551736
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
NFA6_4_49965631("NFA6-4 regex start")
NFA6_1_47037497("NFA6-1 char[1]")
NFA6_3_20684297[\"NFA6-3 char[1]"/]
NFA6_4_49965631 -->|"["|NFA6_1_47037497
NFA6_1_47037497 -->|"^"|NFA6_3_20684297
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
subgraph DFA0_-242527643["DFA0 regex start"]
NFA6_4_49965631_0("NFA6-4 regex start")
end
subgraph DFA1_1510141912["DFA1 {1}"]
NFA6_1_47037497_1("NFA6-1 char[1]")
end
subgraph DFA2_1993267937["DFA2 {1}"]
NFA6_3_20684297_2[\"NFA6-3 char[1]"/]
end
DFA0_-242527643 -->|"["|DFA1_1510141912
DFA1_1510141912 -->|"^"|DFA2_1993267937
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
DFA0_-242527643{{"DFA0 regex start"}}
DFA1_1510141912{{"DFA1 {1}"}}
DFA2_1993267937[\"DFA2 {1}"/]
DFA0_-242527643 -->|"["|DFA1_1510141912
DFA1_1510141912 -->|"^"|DFA2_1993267937
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
subgraph MiniDFA0_1402925856["MiniDFA0 {1}"]
DFA0_-242527643_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1350427678["MiniDFA1 {1}"]
DFA1_1510141912_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1027817212["MiniDFA2 {1}"]
DFA2_1993267937_2[\"DFA2 {1}"/]
end
MiniDFA0_1402925856 -->|"["|MiniDFA1_1350427678
MiniDFA1_1350427678 -->|"^"|MiniDFA2_1027817212
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
MiniDFA0_1402925856(["MiniDFA0 {1}"])
MiniDFA1_1350427678(["MiniDFA1 {1}"])
MiniDFA2_1027817212[\"MiniDFA2 {1}"/]
MiniDFA0_1402925856 -->|"["|MiniDFA1_1350427678
MiniDFA1_1350427678 -->|"^"|MiniDFA2_1027817212
```
-------------------------------
