# 'dmat3'

pattern: `dmat3`

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
eNFA108_10_52239951[["εNFA108-10 regex start"]]
eNFA108_0_397519[["εNFA108-0 char{1, 1}"]]
eNFA108_1_3577678[["εNFA108-1 char[1]"]]
eNFA108_2_32199110[["εNFA108-2 char{1, 1}"]]
eNFA108_3_21356534[["εNFA108-3 char[1]"]]
eNFA108_4_57991080[["εNFA108-4 char{1, 1}"]]
eNFA108_5_52157678[["εNFA108-5 char[1]"]]
eNFA108_6_66765919[["εNFA108-6 char{1, 1}"]]
eNFA108_7_64022366[["εNFA108-7 char[1]"]]
eNFA108_8_39330387[["εNFA108-8 char{1, 1}"]]
eNFA108_9_18429167[["εNFA108-9 char[1]"]]
eNFA108_11_31644779[["εNFA108-11 regex end"]]
eNFA108_12_16367560[["εNFA108-12 post-regex start"]]
eNFA108_13_13090320[\"εNFA108-13 post-regex end"/]
eNFA108_10_52239951 -.->|"ε"|eNFA108_0_397519
eNFA108_0_397519 -->|"d"|eNFA108_1_3577678
eNFA108_1_3577678 -.->|"ε"|eNFA108_2_32199110
eNFA108_2_32199110 -->|"m"|eNFA108_3_21356534
eNFA108_3_21356534 -.->|"ε"|eNFA108_4_57991080
eNFA108_4_57991080 -->|"a"|eNFA108_5_52157678
eNFA108_5_52157678 -.->|"ε"|eNFA108_6_66765919
eNFA108_6_66765919 -->|"t"|eNFA108_7_64022366
eNFA108_7_64022366 -.->|"ε"|eNFA108_8_39330387
eNFA108_8_39330387 -->|"3"|eNFA108_9_18429167
eNFA108_9_18429167 -.->|"ε"|eNFA108_11_31644779
eNFA108_11_31644779 -.->|"ε"|eNFA108_12_16367560
eNFA108_12_16367560 -.->|"ε"|eNFA108_13_13090320
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
eNFA108_10_50704018[["εNFA108-10 regex start"]]
eNFA108_0_53682985[["εNFA108-0 char{1, 1}"]]
eNFA108_1_13384821[["εNFA108-1 char[1]"]]
eNFA108_2_53354527[["εNFA108-2 char{1, 1}"]]
eNFA108_3_10428696[["εNFA108-3 char[1]"]]
eNFA108_4_26749401[["εNFA108-4 char{1, 1}"]]
eNFA108_5_39418019[["εNFA108-5 char[1]"]]
eNFA108_6_19217855[["εNFA108-6 char{1, 1}"]]
eNFA108_7_38742975[["εNFA108-7 char[1]"]]
eNFA108_8_13142459[["εNFA108-8 char{1, 1}"]]
eNFA108_9_51173267[\"εNFA108-9 char[1]"/]
eNFA108_11_57906226[\"εNFA108-11 regex end"/]
eNFA108_12_51393992[\"εNFA108-12 post-regex start"/]
eNFA108_13_59892750[\"εNFA108-13 post-regex end"/]
eNFA108_10_50704018 -.->|"ε"|eNFA108_0_53682985
eNFA108_10_50704018 -->|"d"|eNFA108_1_13384821
eNFA108_0_53682985 -->|"d"|eNFA108_1_13384821
eNFA108_1_13384821 -.->|"ε"|eNFA108_2_53354527
eNFA108_1_13384821 -->|"m"|eNFA108_3_10428696
eNFA108_2_53354527 -->|"m"|eNFA108_3_10428696
eNFA108_3_10428696 -.->|"ε"|eNFA108_4_26749401
eNFA108_3_10428696 -->|"a"|eNFA108_5_39418019
eNFA108_4_26749401 -->|"a"|eNFA108_5_39418019
eNFA108_5_39418019 -.->|"ε"|eNFA108_6_19217855
eNFA108_5_39418019 -->|"t"|eNFA108_7_38742975
eNFA108_6_19217855 -->|"t"|eNFA108_7_38742975
eNFA108_7_38742975 -.->|"ε"|eNFA108_8_13142459
eNFA108_7_38742975 -->|"3"|eNFA108_9_51173267
eNFA108_8_13142459 -->|"3"|eNFA108_9_51173267
eNFA108_9_51173267 -.->|"ε"|eNFA108_11_57906226
eNFA108_9_51173267 -.->|"ε"|eNFA108_12_51393992
eNFA108_9_51173267 -.->|"ε"|eNFA108_13_59892750
eNFA108_11_57906226 -.->|"ε"|eNFA108_12_51393992
eNFA108_11_57906226 -.->|"ε"|eNFA108_13_59892750
eNFA108_12_51393992 -.->|"ε"|eNFA108_13_59892750
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
NFA108_10_2163846("NFA108-10 regex start")
NFA108_1_19474615("NFA108-1 char[1]")
NFA108_3_41053812("NFA108-3 char[1]")
NFA108_5_33939988("NFA108-5 char[1]")
NFA108_7_37024442("NFA108-7 char[1]")
NFA108_9_64784526[\"NFA108-9 char[1]"/]
NFA108_10_2163846 -->|"d"|NFA108_1_19474615
NFA108_1_19474615 -->|"m"|NFA108_3_41053812
NFA108_3_41053812 -->|"a"|NFA108_5_33939988
NFA108_5_33939988 -->|"t"|NFA108_7_37024442
NFA108_7_37024442 -->|"3"|NFA108_9_64784526
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
subgraph DFA0_654497590["DFA0 regex start"]
NFA108_10_2163846_0("NFA108-10 regex start")
end
subgraph DFA1_786708280["DFA1 {1}"]
NFA108_1_19474615_1("NFA108-1 char[1]")
end
subgraph DFA2_-1758401383["DFA2 {1}"]
NFA108_3_41053812_2("NFA108-3 char[1]")
end
subgraph DFA3_1695177297["DFA3 {1}"]
NFA108_5_33939988_3("NFA108-5 char[1]")
end
subgraph DFA4_90393509["DFA4 {1}"]
NFA108_7_37024442_4("NFA108-7 char[1]")
end
subgraph DFA5_926074301["DFA5 {1}"]
NFA108_9_64784526_5[\"NFA108-9 char[1]"/]
end
DFA0_654497590 -->|"d"|DFA1_786708280
DFA1_786708280 -->|"m"|DFA2_-1758401383
DFA2_-1758401383 -->|"a"|DFA3_1695177297
DFA3_1695177297 -->|"t"|DFA4_90393509
DFA4_90393509 -->|"3"|DFA5_926074301
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
DFA0_654497590{{"DFA0 regex start"}}
DFA1_786708280{{"DFA1 {1}"}}
DFA2_-1758401383{{"DFA2 {1}"}}
DFA3_1695177297{{"DFA3 {1}"}}
DFA4_90393509{{"DFA4 {1}"}}
DFA5_926074301[\"DFA5 {1}"/]
DFA0_654497590 -->|"d"|DFA1_786708280
DFA1_786708280 -->|"m"|DFA2_-1758401383
DFA2_-1758401383 -->|"a"|DFA3_1695177297
DFA3_1695177297 -->|"t"|DFA4_90393509
DFA4_90393509 -->|"3"|DFA5_926074301
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
subgraph MiniDFA0_1349529412["MiniDFA0 {1}"]
DFA0_654497590_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1063972222["MiniDFA1 {1}"]
DFA1_786708280_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1181491207["MiniDFA2 {1}"]
DFA2_-1758401383_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-469806533["MiniDFA3 {1}"]
DFA3_1695177297_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1202369980["MiniDFA4 {1}"]
DFA4_90393509_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1648792368["MiniDFA5 {1}"]
DFA5_926074301_5[\"DFA5 {1}"/]
end
MiniDFA0_1349529412 -->|"d"|MiniDFA1_1063972222
MiniDFA1_1063972222 -->|"m"|MiniDFA2_1181491207
MiniDFA2_1181491207 -->|"a"|MiniDFA3_-469806533
MiniDFA3_-469806533 -->|"t"|MiniDFA4_-1202369980
MiniDFA4_-1202369980 -->|"3"|MiniDFA5_1648792368
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
MiniDFA0_1349529412(["MiniDFA0 {1}"])
MiniDFA1_1063972222(["MiniDFA1 {1}"])
MiniDFA2_1181491207(["MiniDFA2 {1}"])
MiniDFA3_-469806533(["MiniDFA3 {1}"])
MiniDFA4_-1202369980(["MiniDFA4 {1}"])
MiniDFA5_1648792368[\"MiniDFA5 {1}"/]
MiniDFA0_1349529412 -->|"d"|MiniDFA1_1063972222
MiniDFA1_1063972222 -->|"m"|MiniDFA2_1181491207
MiniDFA2_1181491207 -->|"a"|MiniDFA3_-469806533
MiniDFA3_-469806533 -->|"t"|MiniDFA4_-1202369980
MiniDFA4_-1202369980 -->|"3"|MiniDFA5_1648792368
```
-------------------------------
