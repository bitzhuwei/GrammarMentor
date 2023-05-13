# 'patch'

pattern: `patch`

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
eNFA63_10_56925253[["εNFA63-10 regex start"]]
eNFA63_0_42565233[["εNFA63-0 char{1, 1}"]]
eNFA63_1_47542785[["εNFA63-1 char[1]"]]
eNFA63_2_25231885[["εNFA63-2 char{1, 1}"]]
eNFA63_3_25760373[["εNFA63-3 char[1]"]]
eNFA63_4_30516772[["εNFA63-4 char{1, 1}"]]
eNFA63_5_6215498[["εNFA63-5 char[1]"]]
eNFA63_6_55939488[["εNFA63-6 char{1, 1}"]]
eNFA63_7_33693352[["εNFA63-7 char[1]"]]
eNFA63_8_34804713[["εNFA63-8 char{1, 1}"]]
eNFA63_9_44806966[["εNFA63-9 char[1]"]]
eNFA63_11_609510[["εNFA63-11 regex end"]]
eNFA63_12_5485596[["εNFA63-12 post-regex start"]]
eNFA63_13_49370368[\"εNFA63-13 post-regex end"/]
eNFA63_10_56925253 -.->|"ε"|eNFA63_0_42565233
eNFA63_0_42565233 -->|"p"|eNFA63_1_47542785
eNFA63_1_47542785 -.->|"ε"|eNFA63_2_25231885
eNFA63_2_25231885 -->|"a"|eNFA63_3_25760373
eNFA63_3_25760373 -.->|"ε"|eNFA63_4_30516772
eNFA63_4_30516772 -->|"t"|eNFA63_5_6215498
eNFA63_5_6215498 -.->|"ε"|eNFA63_6_55939488
eNFA63_6_55939488 -->|"c"|eNFA63_7_33693352
eNFA63_7_33693352 -.->|"ε"|eNFA63_8_34804713
eNFA63_8_34804713 -->|"h"|eNFA63_9_44806966
eNFA63_9_44806966 -.->|"ε"|eNFA63_11_609510
eNFA63_11_609510 -.->|"ε"|eNFA63_12_5485596
eNFA63_12_5485596 -.->|"ε"|eNFA63_13_49370368
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
eNFA63_10_41680131[["εNFA63-10 regex start"]]
eNFA63_0_39576862[["εNFA63-0 char{1, 1}"]]
eNFA63_1_20647442[["εNFA63-1 char[1]"]]
eNFA63_2_51609257[["εNFA63-2 char{1, 1}"]]
eNFA63_3_61830130[["εNFA63-3 char[1]"]]
eNFA63_4_19600264[["εNFA63-4 char{1, 1}"]]
eNFA63_5_42184651[["εNFA63-5 char[1]"]]
eNFA63_6_44117540[["εNFA63-6 char{1, 1}"]]
eNFA63_7_61513540[["εNFA63-7 char[1]"]]
eNFA63_8_16750948[["εNFA63-8 char{1, 1}"]]
eNFA63_9_16540805[\"εNFA63-9 char[1]"/]
eNFA63_11_14649520[\"εNFA63-11 regex end"/]
eNFA63_12_64736823[\"εNFA63-12 post-regex start"/]
eNFA63_13_45760497[\"εNFA63-13 post-regex end"/]
eNFA63_10_41680131 -.->|"ε"|eNFA63_0_39576862
eNFA63_10_41680131 -->|"p"|eNFA63_1_20647442
eNFA63_0_39576862 -->|"p"|eNFA63_1_20647442
eNFA63_1_20647442 -.->|"ε"|eNFA63_2_51609257
eNFA63_1_20647442 -->|"a"|eNFA63_3_61830130
eNFA63_2_51609257 -->|"a"|eNFA63_3_61830130
eNFA63_3_61830130 -.->|"ε"|eNFA63_4_19600264
eNFA63_3_61830130 -->|"t"|eNFA63_5_42184651
eNFA63_4_19600264 -->|"t"|eNFA63_5_42184651
eNFA63_5_42184651 -.->|"ε"|eNFA63_6_44117540
eNFA63_5_42184651 -->|"c"|eNFA63_7_61513540
eNFA63_6_44117540 -->|"c"|eNFA63_7_61513540
eNFA63_7_61513540 -.->|"ε"|eNFA63_8_16750948
eNFA63_7_61513540 -->|"h"|eNFA63_9_16540805
eNFA63_8_16750948 -->|"h"|eNFA63_9_16540805
eNFA63_9_16540805 -.->|"ε"|eNFA63_11_14649520
eNFA63_9_16540805 -.->|"ε"|eNFA63_12_64736823
eNFA63_9_16540805 -.->|"ε"|eNFA63_13_45760497
eNFA63_11_14649520 -.->|"ε"|eNFA63_12_64736823
eNFA63_11_14649520 -.->|"ε"|eNFA63_13_45760497
eNFA63_12_64736823 -.->|"ε"|eNFA63_13_45760497
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
NFA63_10_9191297("NFA63-10 regex start")
NFA63_1_15612815("NFA63-1 char[1]")
NFA63_3_6297612("NFA63-3 char[1]")
NFA63_5_56678513("NFA63-5 char[1]")
NFA63_7_40344576("NFA63-7 char[1]")
NFA63_9_27556864[\"NFA63-9 char[1]"/]
NFA63_10_9191297 -->|"p"|NFA63_1_15612815
NFA63_1_15612815 -->|"a"|NFA63_3_6297612
NFA63_3_6297612 -->|"t"|NFA63_5_56678513
NFA63_5_56678513 -->|"c"|NFA63_7_40344576
NFA63_7_40344576 -->|"h"|NFA63_9_27556864
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
subgraph DFA0_-2095804691["DFA0 regex start"]
NFA63_10_9191297_0("NFA63-10 regex start")
end
subgraph DFA1_827722064["DFA1 {1}"]
NFA63_1_15612815_1("NFA63-1 char[1]")
end
subgraph DFA2_459721082["DFA2 {1}"]
NFA63_3_6297612_2("NFA63-3 char[1]")
end
subgraph DFA3_-770666153["DFA3 {1}"]
NFA63_5_56678513_3("NFA63-5 char[1]")
end
subgraph DFA4_-1887155322["DFA4 {1}"]
NFA63_7_40344576_4("NFA63-7 char[1]")
end
subgraph DFA5_-269108073["DFA5 {1}"]
NFA63_9_27556864_5[\"NFA63-9 char[1]"/]
end
DFA0_-2095804691 -->|"p"|DFA1_827722064
DFA1_827722064 -->|"a"|DFA2_459721082
DFA2_459721082 -->|"t"|DFA3_-770666153
DFA3_-770666153 -->|"c"|DFA4_-1887155322
DFA4_-1887155322 -->|"h"|DFA5_-269108073
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
DFA0_-2095804691{{"DFA0 regex start"}}
DFA1_827722064{{"DFA1 {1}"}}
DFA2_459721082{{"DFA2 {1}"}}
DFA3_-770666153{{"DFA3 {1}"}}
DFA4_-1887155322{{"DFA4 {1}"}}
DFA5_-269108073[\"DFA5 {1}"/]
DFA0_-2095804691 -->|"p"|DFA1_827722064
DFA1_827722064 -->|"a"|DFA2_459721082
DFA2_459721082 -->|"t"|DFA3_-770666153
DFA3_-770666153 -->|"c"|DFA4_-1887155322
DFA4_-1887155322 -->|"h"|DFA5_-269108073
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
subgraph MiniDFA0_-612341517["MiniDFA0 {1}"]
DFA0_-2095804691_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-431124552["MiniDFA1 {1}"]
DFA1_827722064_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1560364640["MiniDFA2 {1}"]
DFA2_459721082_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-631765387["MiniDFA3 {1}"]
DFA3_-770666153_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_113971672["MiniDFA4 {1}"]
DFA4_-1887155322_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1481876927["MiniDFA5 {1}"]
DFA5_-269108073_5[\"DFA5 {1}"/]
end
MiniDFA0_-612341517 -->|"p"|MiniDFA1_-431124552
MiniDFA1_-431124552 -->|"a"|MiniDFA2_1560364640
MiniDFA2_1560364640 -->|"t"|MiniDFA3_-631765387
MiniDFA3_-631765387 -->|"c"|MiniDFA4_113971672
MiniDFA4_113971672 -->|"h"|MiniDFA5_-1481876927
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
MiniDFA0_-612341517(["MiniDFA0 {1}"])
MiniDFA1_-431124552(["MiniDFA1 {1}"])
MiniDFA2_1560364640(["MiniDFA2 {1}"])
MiniDFA3_-631765387(["MiniDFA3 {1}"])
MiniDFA4_113971672(["MiniDFA4 {1}"])
MiniDFA5_-1481876927[\"MiniDFA5 {1}"/]
MiniDFA0_-612341517 -->|"p"|MiniDFA1_-431124552
MiniDFA1_-431124552 -->|"a"|MiniDFA2_1560364640
MiniDFA2_1560364640 -->|"t"|MiniDFA3_-631765387
MiniDFA3_-631765387 -->|"c"|MiniDFA4_113971672
MiniDFA4_113971672 -->|"h"|MiniDFA5_-1481876927
```
-------------------------------
