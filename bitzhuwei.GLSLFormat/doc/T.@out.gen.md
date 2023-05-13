# 'out'

pattern: `out`

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
eNFA61_6_37195178[["εNFA61-6 regex start"]]
eNFA61_0_66321146[["εNFA61-0 char{1, 1}"]]
eNFA61_1_60019402[["εNFA61-1 char[1]"]]
eNFA61_2_3303707[["εNFA61-2 char{1, 1}"]]
eNFA61_3_29733366[["εNFA61-3 char[1]"]]
eNFA61_4_66273709[["εNFA61-4 char{1, 1}"]]
eNFA61_5_59592471[["εNFA61-5 char[1]"]]
eNFA61_7_66570199[["εNFA61-7 regex end"]]
eNFA61_8_62260885[["εNFA61-8 post-regex start"]]
eNFA61_9_23477058[\"εNFA61-9 post-regex end"/]
eNFA61_6_37195178 -.->|"ε"|eNFA61_0_66321146
eNFA61_0_66321146 -->|"o"|eNFA61_1_60019402
eNFA61_1_60019402 -.->|"ε"|eNFA61_2_3303707
eNFA61_2_3303707 -->|"u"|eNFA61_3_29733366
eNFA61_3_29733366 -.->|"ε"|eNFA61_4_66273709
eNFA61_4_66273709 -->|"t"|eNFA61_5_59592471
eNFA61_5_59592471 -.->|"ε"|eNFA61_7_66570199
eNFA61_7_66570199 -.->|"ε"|eNFA61_8_62260885
eNFA61_8_62260885 -.->|"ε"|eNFA61_9_23477058
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
eNFA61_6_9966935[["εNFA61-6 regex start"]]
eNFA61_0_22593558[["εNFA61-0 char{1, 1}"]]
eNFA61_1_2015430[["εNFA61-1 char[1]"]]
eNFA61_2_18138873[["εNFA61-2 char{1, 1}"]]
eNFA61_3_29032137[["εNFA61-3 char[1]"]]
eNFA61_4_59962646[["εNFA61-4 char{1, 1}"]]
eNFA61_5_2792905[\"εNFA61-5 char[1]"/]
eNFA61_7_25136147[\"εNFA61-7 regex end"/]
eNFA61_8_24898733[\"εNFA61-8 post-regex start"/]
eNFA61_9_22762008[\"εNFA61-9 post-regex end"/]
eNFA61_6_9966935 -.->|"ε"|eNFA61_0_22593558
eNFA61_6_9966935 -->|"o"|eNFA61_1_2015430
eNFA61_0_22593558 -->|"o"|eNFA61_1_2015430
eNFA61_1_2015430 -.->|"ε"|eNFA61_2_18138873
eNFA61_1_2015430 -->|"u"|eNFA61_3_29032137
eNFA61_2_18138873 -->|"u"|eNFA61_3_29032137
eNFA61_3_29032137 -.->|"ε"|eNFA61_4_59962646
eNFA61_3_29032137 -->|"t"|eNFA61_5_2792905
eNFA61_4_59962646 -->|"t"|eNFA61_5_2792905
eNFA61_5_2792905 -.->|"ε"|eNFA61_7_25136147
eNFA61_5_2792905 -.->|"ε"|eNFA61_8_24898733
eNFA61_5_2792905 -.->|"ε"|eNFA61_9_22762008
eNFA61_7_25136147 -.->|"ε"|eNFA61_8_24898733
eNFA61_7_25136147 -.->|"ε"|eNFA61_9_22762008
eNFA61_8_24898733 -.->|"ε"|eNFA61_9_22762008
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
NFA61_6_3531486("NFA61-6 regex start")
NFA61_1_31783374("NFA61-1 char[1]")
NFA61_3_17614915("NFA61-3 char[1]")
NFA61_5_24316508[\"NFA61-5 char[1]"/]
NFA61_6_3531486 -->|"o"|NFA61_1_31783374
NFA61_1_31783374 -->|"u"|NFA61_3_17614915
NFA61_3_17614915 -->|"t"|NFA61_5_24316508
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
subgraph DFA0_-1675366070["DFA0 regex start"]
NFA61_6_3531486_0("NFA61-6 regex start")
end
subgraph DFA1_-1108220577["DFA1 {1}"]
NFA61_1_31783374_1("NFA61-1 char[1]")
end
subgraph DFA2_-805123500["DFA2 {1}"]
NFA61_3_17614915_2("NFA61-3 char[1]")
end
subgraph DFA3_-1592229472["DFA3 {1}"]
NFA61_5_24316508_3[\"NFA61-5 char[1]"/]
end
DFA0_-1675366070 -->|"o"|DFA1_-1108220577
DFA1_-1108220577 -->|"u"|DFA2_-805123500
DFA2_-805123500 -->|"t"|DFA3_-1592229472
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
DFA0_-1675366070{{"DFA0 regex start"}}
DFA1_-1108220577{{"DFA1 {1}"}}
DFA2_-805123500{{"DFA2 {1}"}}
DFA3_-1592229472[\"DFA3 {1}"/]
DFA0_-1675366070 -->|"o"|DFA1_-1108220577
DFA1_-1108220577 -->|"u"|DFA2_-805123500
DFA2_-805123500 -->|"t"|DFA3_-1592229472
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
subgraph MiniDFA0_1646240939["MiniDFA0 {1}"]
DFA0_-1675366070_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1726870292["MiniDFA1 {1}"]
DFA1_-1108220577_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_8075096["MiniDFA2 {1}"]
DFA2_-805123500_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1418627051["MiniDFA3 {1}"]
DFA3_-1592229472_3[\"DFA3 {1}"/]
end
MiniDFA0_1646240939 -->|"o"|MiniDFA1_-1726870292
MiniDFA1_-1726870292 -->|"u"|MiniDFA2_8075096
MiniDFA2_8075096 -->|"t"|MiniDFA3_-1418627051
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
MiniDFA0_1646240939(["MiniDFA0 {1}"])
MiniDFA1_-1726870292(["MiniDFA1 {1}"])
MiniDFA2_8075096(["MiniDFA2 {1}"])
MiniDFA3_-1418627051[\"MiniDFA3 {1}"/]
MiniDFA0_1646240939 -->|"o"|MiniDFA1_-1726870292
MiniDFA1_-1726870292 -->|"u"|MiniDFA2_8075096
MiniDFA2_8075096 -->|"t"|MiniDFA3_-1418627051
```
-------------------------------
