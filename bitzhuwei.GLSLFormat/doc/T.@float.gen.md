# 'float'

pattern: `float`

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
eNFA75_10_6738088[["εNFA75-10 regex start"]]
eNFA75_0_60642794[["εNFA75-0 char{1, 1}"]]
eNFA75_1_8914235[["εNFA75-1 char[1]"]]
eNFA75_2_13119252[["εNFA75-2 char{1, 1}"]]
eNFA75_3_50964406[["εNFA75-3 char[1]"]]
eNFA75_4_56026474[["εNFA75-4 char{1, 1}"]]
eNFA75_5_34476226[["εNFA75-5 char[1]"]]
eNFA75_6_41850582[["εNFA75-6 char{1, 1}"]]
eNFA75_7_41110918[["εNFA75-7 char[1]"]]
eNFA75_8_34453949[["εNFA75-8 char{1, 1}"]]
eNFA75_9_41650091[["εNFA75-9 char[1]"]]
eNFA75_11_39306505[["εNFA75-11 regex end"]]
eNFA75_12_18214233[["εNFA75-12 post-regex start"]]
eNFA75_13_29710370[\"εNFA75-13 post-regex end"/]
eNFA75_10_6738088 -.->|"ε"|eNFA75_0_60642794
eNFA75_0_60642794 -->|"f"|eNFA75_1_8914235
eNFA75_1_8914235 -.->|"ε"|eNFA75_2_13119252
eNFA75_2_13119252 -->|"l"|eNFA75_3_50964406
eNFA75_3_50964406 -.->|"ε"|eNFA75_4_56026474
eNFA75_4_56026474 -->|"o"|eNFA75_5_34476226
eNFA75_5_34476226 -.->|"ε"|eNFA75_6_41850582
eNFA75_6_41850582 -->|"a"|eNFA75_7_41110918
eNFA75_7_41110918 -.->|"ε"|eNFA75_8_34453949
eNFA75_8_34453949 -->|"t"|eNFA75_9_41650091
eNFA75_9_41650091 -.->|"ε"|eNFA75_11_39306505
eNFA75_11_39306505 -.->|"ε"|eNFA75_12_18214233
eNFA75_12_18214233 -.->|"ε"|eNFA75_13_29710370
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
eNFA75_10_66066743[["εNFA75-10 regex start"]]
eNFA75_0_57729775[["εNFA75-0 char{1, 1}"]]
eNFA75_1_49805933[["εNFA75-1 char[1]"]]
eNFA75_2_45600217[["εNFA75-2 char{1, 1}"]]
eNFA75_3_7748772[["εNFA75-3 char[1]"]]
eNFA75_4_2630087[["εNFA75-4 char{1, 1}"]]
eNFA75_5_23670787[["εNFA75-5 char[1]"]]
eNFA75_6_11710498[["εNFA75-6 char{1, 1}"]]
eNFA75_7_38285619[["εNFA75-7 char[1]"]]
eNFA75_8_9026257[["εNFA75-8 char{1, 1}"]]
eNFA75_9_14127452[\"εNFA75-9 char[1]"/]
eNFA75_11_60038205[\"εNFA75-11 regex end"/]
eNFA75_12_3472933[\"εNFA75-12 post-regex start"/]
eNFA75_13_31256397[\"εNFA75-13 post-regex end"/]
eNFA75_10_66066743 -.->|"ε"|eNFA75_0_57729775
eNFA75_10_66066743 -->|"f"|eNFA75_1_49805933
eNFA75_0_57729775 -->|"f"|eNFA75_1_49805933
eNFA75_1_49805933 -.->|"ε"|eNFA75_2_45600217
eNFA75_1_49805933 -->|"l"|eNFA75_3_7748772
eNFA75_2_45600217 -->|"l"|eNFA75_3_7748772
eNFA75_3_7748772 -.->|"ε"|eNFA75_4_2630087
eNFA75_3_7748772 -->|"o"|eNFA75_5_23670787
eNFA75_4_2630087 -->|"o"|eNFA75_5_23670787
eNFA75_5_23670787 -.->|"ε"|eNFA75_6_11710498
eNFA75_5_23670787 -->|"a"|eNFA75_7_38285619
eNFA75_6_11710498 -->|"a"|eNFA75_7_38285619
eNFA75_7_38285619 -.->|"ε"|eNFA75_8_9026257
eNFA75_7_38285619 -->|"t"|eNFA75_9_14127452
eNFA75_8_9026257 -->|"t"|eNFA75_9_14127452
eNFA75_9_14127452 -.->|"ε"|eNFA75_11_60038205
eNFA75_9_14127452 -.->|"ε"|eNFA75_12_3472933
eNFA75_9_14127452 -.->|"ε"|eNFA75_13_31256397
eNFA75_11_60038205 -.->|"ε"|eNFA75_12_3472933
eNFA75_11_60038205 -.->|"ε"|eNFA75_13_31256397
eNFA75_12_3472933 -.->|"ε"|eNFA75_13_31256397
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
NFA75_10_12872118("NFA75-10 regex start")
NFA75_1_48740201("NFA75-1 char[1]")
NFA75_3_36008632("NFA75-3 char[1]")
NFA75_5_55642234("NFA75-5 char[1]")
NFA75_7_31018066("NFA75-7 char[1]")
NFA75_9_10727144[\"NFA75-9 char[1]"/]
NFA75_10_12872118 -->|"f"|NFA75_1_48740201
NFA75_1_48740201 -->|"l"|NFA75_3_36008632
NFA75_3_36008632 -->|"o"|NFA75_5_55642234
NFA75_5_55642234 -->|"a"|NFA75_7_31018066
NFA75_7_31018066 -->|"t"|NFA75_9_10727144
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
subgraph DFA0_262242791["DFA0 regex start"]
NFA75_10_12872118_0("NFA75-10 regex start")
end
subgraph DFA1_-1300545806["DFA1 {1}"]
NFA75_1_48740201_1("NFA75-1 char[1]")
end
subgraph DFA2_1068730990["DFA2 {1}"]
NFA75_3_36008632_2("NFA75-3 char[1]")
end
subgraph DFA3_-799421191["DFA3 {1}"]
NFA75_5_55642234_3("NFA75-5 char[1]")
end
subgraph DFA4_-916202522["DFA4 {1}"]
NFA75_7_31018066_4("NFA75-7 char[1]")
end
subgraph DFA5_406743607["DFA5 {1}"]
NFA75_9_10727144_5[\"NFA75-9 char[1]"/]
end
DFA0_262242791 -->|"f"|DFA1_-1300545806
DFA1_-1300545806 -->|"l"|DFA2_1068730990
DFA2_1068730990 -->|"o"|DFA3_-799421191
DFA3_-799421191 -->|"a"|DFA4_-916202522
DFA4_-916202522 -->|"t"|DFA5_406743607
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
DFA0_262242791{{"DFA0 regex start"}}
DFA1_-1300545806{{"DFA1 {1}"}}
DFA2_1068730990{{"DFA2 {1}"}}
DFA3_-799421191{{"DFA3 {1}"}}
DFA4_-916202522{{"DFA4 {1}"}}
DFA5_406743607[\"DFA5 {1}"/]
DFA0_262242791 -->|"f"|DFA1_-1300545806
DFA1_-1300545806 -->|"l"|DFA2_1068730990
DFA2_1068730990 -->|"o"|DFA3_-799421191
DFA3_-799421191 -->|"a"|DFA4_-916202522
DFA4_-916202522 -->|"t"|DFA5_406743607
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
subgraph MiniDFA0_-2094896616["MiniDFA0 {1}"]
DFA0_262242791_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1661380324["MiniDFA1 {1}"]
DFA1_-1300545806_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1864366709["MiniDFA2 {1}"]
DFA2_1068730990_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1595594685["MiniDFA3 {1}"]
DFA3_-799421191_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1709877350["MiniDFA4 {1}"]
DFA4_-916202522_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-12835860["MiniDFA5 {1}"]
DFA5_406743607_5[\"DFA5 {1}"/]
end
MiniDFA0_-2094896616 -->|"f"|MiniDFA1_1661380324
MiniDFA1_1661380324 -->|"l"|MiniDFA2_1864366709
MiniDFA2_1864366709 -->|"o"|MiniDFA3_-1595594685
MiniDFA3_-1595594685 -->|"a"|MiniDFA4_-1709877350
MiniDFA4_-1709877350 -->|"t"|MiniDFA5_-12835860
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
MiniDFA0_-2094896616(["MiniDFA0 {1}"])
MiniDFA1_1661380324(["MiniDFA1 {1}"])
MiniDFA2_1864366709(["MiniDFA2 {1}"])
MiniDFA3_-1595594685(["MiniDFA3 {1}"])
MiniDFA4_-1709877350(["MiniDFA4 {1}"])
MiniDFA5_-12835860[\"MiniDFA5 {1}"/]
MiniDFA0_-2094896616 -->|"f"|MiniDFA1_1661380324
MiniDFA1_1661380324 -->|"l"|MiniDFA2_1864366709
MiniDFA2_1864366709 -->|"o"|MiniDFA3_-1595594685
MiniDFA3_-1595594685 -->|"a"|MiniDFA4_-1709877350
MiniDFA4_-1709877350 -->|"t"|MiniDFA5_-12835860
```
-------------------------------
