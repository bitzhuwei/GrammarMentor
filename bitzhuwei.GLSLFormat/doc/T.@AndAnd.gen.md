# '&&'

pattern: `&&`

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
eNFA32_4_15456653[["εNFA32-4 regex start"]]
eNFA32_0_4892154[["εNFA32-0 char{1, 1}"]]
eNFA32_1_44029393[["εNFA32-1 char[1]"]]
eNFA32_2_60720217[["εNFA32-2 char{1, 1}"]]
eNFA32_3_9611044[["εNFA32-3 char[1]"]]
eNFA32_5_19390540[["εNFA32-5 regex end"]]
eNFA32_6_40297137[["εNFA32-6 post-regex start"]]
eNFA32_7_27129916[\"εNFA32-7 post-regex end"/]
eNFA32_4_15456653 -.->|"ε"|eNFA32_0_4892154
eNFA32_0_4892154 -->|"&"|eNFA32_1_44029393
eNFA32_1_44029393 -.->|"ε"|eNFA32_2_60720217
eNFA32_2_60720217 -->|"&"|eNFA32_3_9611044
eNFA32_3_9611044 -.->|"ε"|eNFA32_5_19390540
eNFA32_5_19390540 -.->|"ε"|eNFA32_6_40297137
eNFA32_6_40297137 -.->|"ε"|eNFA32_7_27129916
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
eNFA32_4_42842654[["εNFA32-4 regex start"]]
eNFA32_0_50039568[["εNFA32-0 char{1, 1}"]]
eNFA32_1_47702931[["εNFA32-1 char[1]"]]
eNFA32_2_26673201[["εNFA32-2 char{1, 1}"]]
eNFA32_3_38732217[\"εNFA32-3 char[1]"/]
eNFA32_5_13045638[\"εNFA32-5 regex end"/]
eNFA32_6_50301879[\"εNFA32-6 post-regex start"/]
eNFA32_7_50063735[\"εNFA32-7 post-regex end"/]
eNFA32_4_42842654 -.->|"ε"|eNFA32_0_50039568
eNFA32_4_42842654 -->|"&"|eNFA32_1_47702931
eNFA32_0_50039568 -->|"&"|eNFA32_1_47702931
eNFA32_1_47702931 -.->|"ε"|eNFA32_2_26673201
eNFA32_1_47702931 -->|"&"|eNFA32_3_38732217
eNFA32_2_26673201 -->|"&"|eNFA32_3_38732217
eNFA32_3_38732217 -.->|"ε"|eNFA32_5_13045638
eNFA32_3_38732217 -.->|"ε"|eNFA32_6_50301879
eNFA32_3_38732217 -.->|"ε"|eNFA32_7_50063735
eNFA32_5_13045638 -.->|"ε"|eNFA32_6_50301879
eNFA32_5_13045638 -.->|"ε"|eNFA32_7_50063735
eNFA32_6_50301879 -.->|"ε"|eNFA32_7_50063735
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
NFA32_4_47920438("NFA32-4 regex start")
NFA32_1_28630766("NFA32-1 char[1]")
NFA32_3_56350302[\"NFA32-3 char[1]"/]
NFA32_4_47920438 -->|"&"|NFA32_1_28630766
NFA32_1_28630766 -->|"&"|NFA32_3_56350302
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
subgraph DFA0_1731070713["DFA0 regex start"]
NFA32_4_47920438_0("NFA32-4 regex start")
end
subgraph DFA1_-65537694["DFA1 {1}"]
NFA32_1_28630766_1("NFA32-1 char[1]")
end
subgraph DFA2_-2061989891["DFA2 {1}"]
NFA32_3_56350302_2[\"NFA32-3 char[1]"/]
end
DFA0_1731070713 -->|"&"|DFA1_-65537694
DFA1_-65537694 -->|"&"|DFA2_-2061989891
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
DFA0_1731070713{{"DFA0 regex start"}}
DFA1_-65537694{{"DFA1 {1}"}}
DFA2_-2061989891[\"DFA2 {1}"/]
DFA0_1731070713 -->|"&"|DFA1_-65537694
DFA1_-65537694 -->|"&"|DFA2_-2061989891
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
subgraph MiniDFA0_-339477480["MiniDFA0 {1}"]
DFA0_1731070713_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1276895233["MiniDFA1 {1}"]
DFA1_-65537694_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_734668528["MiniDFA2 {1}"]
DFA2_-2061989891_2[\"DFA2 {1}"/]
end
MiniDFA0_-339477480 -->|"&"|MiniDFA1_-1276895233
MiniDFA1_-1276895233 -->|"&"|MiniDFA2_734668528
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
MiniDFA0_-339477480(["MiniDFA0 {1}"])
MiniDFA1_-1276895233(["MiniDFA1 {1}"])
MiniDFA2_734668528[\"MiniDFA2 {1}"/]
MiniDFA0_-339477480 -->|"&"|MiniDFA1_-1276895233
MiniDFA1_-1276895233 -->|"&"|MiniDFA2_734668528
```
-------------------------------
