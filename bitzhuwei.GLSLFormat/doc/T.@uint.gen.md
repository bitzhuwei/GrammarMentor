# 'uint'

pattern: `uint`

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
eNFA78_8_9616944[["εNFA78-8 regex start"]]
eNFA78_0_19443632[["εNFA78-0 char{1, 1}"]]
eNFA78_1_40774967[["εNFA78-1 char[1]"]]
eNFA78_2_31430389[["εNFA78-2 char{1, 1}"]]
eNFA78_3_14438051[["εNFA78-3 char[1]"]]
eNFA78_4_62833603[["εNFA78-4 char{1, 1}"]]
eNFA78_5_28631516[["εNFA78-5 char[1]"]]
eNFA78_6_56357057[["εNFA78-6 char{1, 1}"]]
eNFA78_7_37451465[["εNFA78-7 char[1]"]]
eNFA78_9_1518871[["εNFA78-9 regex end"]]
eNFA78_10_13669843[["εNFA78-10 post-regex start"]]
eNFA78_11_55919726[\"εNFA78-11 post-regex end"/]
eNFA78_8_9616944 -.->|"ε"|eNFA78_0_19443632
eNFA78_0_19443632 -->|"u"|eNFA78_1_40774967
eNFA78_1_40774967 -.->|"ε"|eNFA78_2_31430389
eNFA78_2_31430389 -->|"i"|eNFA78_3_14438051
eNFA78_3_14438051 -.->|"ε"|eNFA78_4_62833603
eNFA78_4_62833603 -->|"n"|eNFA78_5_28631516
eNFA78_5_28631516 -.->|"ε"|eNFA78_6_56357057
eNFA78_6_56357057 -->|"t"|eNFA78_7_37451465
eNFA78_7_37451465 -.->|"ε"|eNFA78_9_1518871
eNFA78_9_1518871 -.->|"ε"|eNFA78_10_13669843
eNFA78_10_13669843 -.->|"ε"|eNFA78_11_55919726
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
eNFA78_8_33515489[["εNFA78-8 regex start"]]
eNFA78_0_33203949[["εNFA78-0 char{1, 1}"]]
eNFA78_1_30400092[["εNFA78-1 char[1]"]]
eNFA78_2_5165373[["εNFA78-2 char{1, 1}"]]
eNFA78_3_46488363[["εNFA78-3 char[1]"]]
eNFA78_4_15742086[["εNFA78-4 char{1, 1}"]]
eNFA78_5_7461047[["εNFA78-5 char[1]"]]
eNFA78_6_40559[["εNFA78-6 char{1, 1}"]]
eNFA78_7_365031[\"εNFA78-7 char[1]"/]
eNFA78_9_3285280[\"εNFA78-9 regex end"/]
eNFA78_10_29567523[\"εNFA78-10 post-regex start"/]
eNFA78_11_64781122[\"εNFA78-11 post-regex end"/]
eNFA78_8_33515489 -.->|"ε"|eNFA78_0_33203949
eNFA78_8_33515489 -->|"u"|eNFA78_1_30400092
eNFA78_0_33203949 -->|"u"|eNFA78_1_30400092
eNFA78_1_30400092 -.->|"ε"|eNFA78_2_5165373
eNFA78_1_30400092 -->|"i"|eNFA78_3_46488363
eNFA78_2_5165373 -->|"i"|eNFA78_3_46488363
eNFA78_3_46488363 -.->|"ε"|eNFA78_4_15742086
eNFA78_3_46488363 -->|"n"|eNFA78_5_7461047
eNFA78_4_15742086 -->|"n"|eNFA78_5_7461047
eNFA78_5_7461047 -.->|"ε"|eNFA78_6_40559
eNFA78_5_7461047 -->|"t"|eNFA78_7_365031
eNFA78_6_40559 -->|"t"|eNFA78_7_365031
eNFA78_7_365031 -.->|"ε"|eNFA78_9_3285280
eNFA78_7_365031 -.->|"ε"|eNFA78_10_29567523
eNFA78_7_365031 -.->|"ε"|eNFA78_11_64781122
eNFA78_9_3285280 -.->|"ε"|eNFA78_10_29567523
eNFA78_9_3285280 -.->|"ε"|eNFA78_11_64781122
eNFA78_10_29567523 -.->|"ε"|eNFA78_11_64781122
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
NFA78_8_46159188("NFA78-8 regex start")
NFA78_1_12779516("NFA78-1 char[1]")
NFA78_3_47906786("NFA78-3 char[1]")
NFA78_5_28507895("NFA78-5 char[1]")
NFA78_7_55244468[\"NFA78-7 char[1]"/]
NFA78_8_46159188 -->|"u"|NFA78_1_12779516
NFA78_1_12779516 -->|"i"|NFA78_3_47906786
NFA78_3_47906786 -->|"n"|NFA78_5_28507895
NFA78_5_28507895 -->|"t"|NFA78_7_55244468
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
subgraph DFA0_-1879298647["DFA0 regex start"]
NFA78_8_46159188_0("NFA78-8 regex start")
end
subgraph DFA1_-539033734["DFA1 {1}"]
NFA78_1_12779516_1("NFA78-1 char[1]")
end
subgraph DFA2_925686596["DFA2 {1}"]
NFA78_3_47906786_2("NFA78-3 char[1]")
end
subgraph DFA3_594689189["DFA3 {1}"]
NFA78_5_28507895_3("NFA78-5 char[1]")
end
subgraph DFA4_862546712["DFA4 {1}"]
NFA78_7_55244468_4[\"NFA78-7 char[1]"/]
end
DFA0_-1879298647 -->|"u"|DFA1_-539033734
DFA1_-539033734 -->|"i"|DFA2_925686596
DFA2_925686596 -->|"n"|DFA3_594689189
DFA3_594689189 -->|"t"|DFA4_862546712
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
DFA0_-1879298647{{"DFA0 regex start"}}
DFA1_-539033734{{"DFA1 {1}"}}
DFA2_925686596{{"DFA2 {1}"}}
DFA3_594689189{{"DFA3 {1}"}}
DFA4_862546712[\"DFA4 {1}"/]
DFA0_-1879298647 -->|"u"|DFA1_-539033734
DFA1_-539033734 -->|"i"|DFA2_925686596
DFA2_925686596 -->|"n"|DFA3_594689189
DFA3_594689189 -->|"t"|DFA4_862546712
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
subgraph MiniDFA0_-1214853710["MiniDFA0 {1}"]
DFA0_-1879298647_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1804703831["MiniDFA1 {1}"]
DFA1_-539033734_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1770298948["MiniDFA2 {1}"]
DFA2_925686596_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-180105576["MiniDFA3 {1}"]
DFA3_594689189_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-2028219511["MiniDFA4 {1}"]
DFA4_862546712_4[\"DFA4 {1}"/]
end
MiniDFA0_-1214853710 -->|"u"|MiniDFA1_1804703831
MiniDFA1_1804703831 -->|"i"|MiniDFA2_-1770298948
MiniDFA2_-1770298948 -->|"n"|MiniDFA3_-180105576
MiniDFA3_-180105576 -->|"t"|MiniDFA4_-2028219511
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
MiniDFA0_-1214853710(["MiniDFA0 {1}"])
MiniDFA1_1804703831(["MiniDFA1 {1}"])
MiniDFA2_-1770298948(["MiniDFA2 {1}"])
MiniDFA3_-180105576(["MiniDFA3 {1}"])
MiniDFA4_-2028219511[\"MiniDFA4 {1}"/]
MiniDFA0_-1214853710 -->|"u"|MiniDFA1_1804703831
MiniDFA1_1804703831 -->|"i"|MiniDFA2_-1770298948
MiniDFA2_-1770298948 -->|"n"|MiniDFA3_-180105576
MiniDFA3_-180105576 -->|"t"|MiniDFA4_-2028219511
```
-------------------------------
