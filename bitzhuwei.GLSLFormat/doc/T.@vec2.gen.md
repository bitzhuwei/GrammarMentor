# 'vec2'

pattern: `vec2`

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
eNFA80_8_4739572[["εNFA80-8 regex start"]]
eNFA80_0_42656148[["εNFA80-0 char{1, 1}"]]
eNFA80_1_48361012[["εNFA80-1 char[1]"]]
eNFA80_2_32595925[["εNFA80-2 char{1, 1}"]]
eNFA80_3_24927872[["εNFA80-3 char[1]"]]
eNFA80_4_23024263[["εNFA80-4 char{1, 1}"]]
eNFA80_5_5891777[["εNFA80-5 char[1]"]]
eNFA80_6_53026001[["εNFA80-6 char{1, 1}"]]
eNFA80_7_7471967[["εNFA80-7 char[1]"]]
eNFA80_9_138844[["εNFA80-9 regex end"]]
eNFA80_10_1249601[["εNFA80-10 post-regex start"]]
eNFA80_11_11246416[\"εNFA80-11 post-regex end"/]
eNFA80_8_4739572 -.->|"ε"|eNFA80_0_42656148
eNFA80_0_42656148 -->|"v"|eNFA80_1_48361012
eNFA80_1_48361012 -.->|"ε"|eNFA80_2_32595925
eNFA80_2_32595925 -->|"e"|eNFA80_3_24927872
eNFA80_3_24927872 -.->|"ε"|eNFA80_4_23024263
eNFA80_4_23024263 -->|"c"|eNFA80_5_5891777
eNFA80_5_5891777 -.->|"ε"|eNFA80_6_53026001
eNFA80_6_53026001 -->|"2"|eNFA80_7_7471967
eNFA80_7_7471967 -.->|"ε"|eNFA80_9_138844
eNFA80_9_138844 -.->|"ε"|eNFA80_10_1249601
eNFA80_10_1249601 -.->|"ε"|eNFA80_11_11246416
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
eNFA80_8_34108880[["εNFA80-8 regex start"]]
eNFA80_0_38544467[["εNFA80-0 char{1, 1}"]]
eNFA80_1_11355891[["εNFA80-1 char[1]"]]
eNFA80_2_35094160[["εNFA80-2 char{1, 1}"]]
eNFA80_3_47411987[["εNFA80-3 char[1]"]]
eNFA80_4_24054701[["εNFA80-4 char{1, 1}"]]
eNFA80_5_15165719[["εNFA80-5 char[1]"]]
eNFA80_6_2273746[["εNFA80-6 char{1, 1}"]]
eNFA80_7_20463720[\"εNFA80-7 char[1]"/]
eNFA80_9_49955752[\"εNFA80-9 regex end"/]
eNFA80_10_46948589[\"εNFA80-10 post-regex start"/]
eNFA80_11_19884118[\"εNFA80-11 post-regex end"/]
eNFA80_8_34108880 -.->|"ε"|eNFA80_0_38544467
eNFA80_8_34108880 -->|"v"|eNFA80_1_11355891
eNFA80_0_38544467 -->|"v"|eNFA80_1_11355891
eNFA80_1_11355891 -.->|"ε"|eNFA80_2_35094160
eNFA80_1_11355891 -->|"e"|eNFA80_3_47411987
eNFA80_2_35094160 -->|"e"|eNFA80_3_47411987
eNFA80_3_47411987 -.->|"ε"|eNFA80_4_24054701
eNFA80_3_47411987 -->|"c"|eNFA80_5_15165719
eNFA80_4_24054701 -->|"c"|eNFA80_5_15165719
eNFA80_5_15165719 -.->|"ε"|eNFA80_6_2273746
eNFA80_5_15165719 -->|"2"|eNFA80_7_20463720
eNFA80_6_2273746 -->|"2"|eNFA80_7_20463720
eNFA80_7_20463720 -.->|"ε"|eNFA80_9_49955752
eNFA80_7_20463720 -.->|"ε"|eNFA80_10_46948589
eNFA80_7_20463720 -.->|"ε"|eNFA80_11_19884118
eNFA80_9_49955752 -.->|"ε"|eNFA80_10_46948589
eNFA80_9_49955752 -.->|"ε"|eNFA80_11_19884118
eNFA80_10_46948589 -.->|"ε"|eNFA80_11_19884118
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
NFA80_8_44739342("NFA80-8 regex start")
NFA80_1_901("NFA80-1 char[1]")
NFA80_3_8117("NFA80-3 char[1]")
NFA80_5_73053("NFA80-5 char[1]")
NFA80_7_657479[\"NFA80-7 char[1]"/]
NFA80_8_44739342 -->|"v"|NFA80_1_901
NFA80_1_901 -->|"e"|NFA80_3_8117
NFA80_3_8117 -->|"c"|NFA80_5_73053
NFA80_5_73053 -->|"2"|NFA80_7_657479
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
subgraph DFA0_-2138256659["DFA0 regex start"]
NFA80_8_44739342_0("NFA80-8 regex start")
end
subgraph DFA1_1337052939["DFA1 {1}"]
NFA80_1_901_1("NFA80-1 char[1]")
end
subgraph DFA2_105417265["DFA2 {1}"]
NFA80_3_8117_2("NFA80-3 char[1]")
end
subgraph DFA3_421221279["DFA3 {1}"]
NFA80_5_73053_3("NFA80-5 char[1]")
end
subgraph DFA4_194446459["DFA4 {1}"]
NFA80_7_657479_4[\"NFA80-7 char[1]"/]
end
DFA0_-2138256659 -->|"v"|DFA1_1337052939
DFA1_1337052939 -->|"e"|DFA2_105417265
DFA2_105417265 -->|"c"|DFA3_421221279
DFA3_421221279 -->|"2"|DFA4_194446459
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
DFA0_-2138256659{{"DFA0 regex start"}}
DFA1_1337052939{{"DFA1 {1}"}}
DFA2_105417265{{"DFA2 {1}"}}
DFA3_421221279{{"DFA3 {1}"}}
DFA4_194446459[\"DFA4 {1}"/]
DFA0_-2138256659 -->|"v"|DFA1_1337052939
DFA1_1337052939 -->|"e"|DFA2_105417265
DFA2_105417265 -->|"c"|DFA3_421221279
DFA3_421221279 -->|"2"|DFA4_194446459
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
subgraph MiniDFA0_-1637353917["MiniDFA0 {1}"]
DFA0_-2138256659_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2144613826["MiniDFA1 {1}"]
DFA1_1337052939_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-26117874["MiniDFA2 {1}"]
DFA2_105417265_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_572558020["MiniDFA3 {1}"]
DFA3_421221279_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_754781002["MiniDFA4 {1}"]
DFA4_194446459_4[\"DFA4 {1}"/]
end
MiniDFA0_-1637353917 -->|"v"|MiniDFA1_2144613826
MiniDFA1_2144613826 -->|"e"|MiniDFA2_-26117874
MiniDFA2_-26117874 -->|"c"|MiniDFA3_572558020
MiniDFA3_572558020 -->|"2"|MiniDFA4_754781002
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
MiniDFA0_-1637353917(["MiniDFA0 {1}"])
MiniDFA1_2144613826(["MiniDFA1 {1}"])
MiniDFA2_-26117874(["MiniDFA2 {1}"])
MiniDFA3_572558020(["MiniDFA3 {1}"])
MiniDFA4_754781002[\"MiniDFA4 {1}"/]
MiniDFA0_-1637353917 -->|"v"|MiniDFA1_2144613826
MiniDFA1_2144613826 -->|"e"|MiniDFA2_-26117874
MiniDFA2_-26117874 -->|"c"|MiniDFA3_572558020
MiniDFA3_572558020 -->|"2"|MiniDFA4_754781002
```
-------------------------------
