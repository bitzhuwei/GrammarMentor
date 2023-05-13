# 'true'

pattern: `true`

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
eNFA5_8_40799911[["εNFA5-8 regex start"]]
eNFA5_0_31654880[["εNFA5-0 char{1, 1}"]]
eNFA5_1_16458469[["εNFA5-1 char[1]"]]
eNFA5_2_13908493[["εNFA5-2 char{1, 1}"]]
eNFA5_3_58067579[["εNFA5-3 char[1]"]]
eNFA5_4_52846167[["εNFA5-4 char{1, 1}"]]
eNFA5_5_5853458[["εNFA5-5 char[1]"]]
eNFA5_6_52681125[["εNFA5-6 char{1, 1}"]]
eNFA5_7_4368081[["εNFA5-7 char[1]"]]
eNFA5_9_39312736[["εNFA5-9 regex end"]]
eNFA5_10_18270305[["εNFA5-10 post-regex start"]]
eNFA5_11_30215023[\"εNFA5-11 post-regex end"/]
eNFA5_8_40799911 -.->|"ε"|eNFA5_0_31654880
eNFA5_0_31654880 -->|"t"|eNFA5_1_16458469
eNFA5_1_16458469 -.->|"ε"|eNFA5_2_13908493
eNFA5_2_13908493 -->|"r"|eNFA5_3_58067579
eNFA5_3_58067579 -.->|"ε"|eNFA5_4_52846167
eNFA5_4_52846167 -->|"u"|eNFA5_5_5853458
eNFA5_5_5853458 -.->|"ε"|eNFA5_6_52681125
eNFA5_6_52681125 -->|"e"|eNFA5_7_4368081
eNFA5_7_4368081 -.->|"ε"|eNFA5_9_39312736
eNFA5_9_39312736 -.->|"ε"|eNFA5_10_18270305
eNFA5_10_18270305 -.->|"ε"|eNFA5_11_30215023
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
eNFA5_8_3499754[["εNFA5-8 regex start"]]
eNFA5_0_31497787[["εNFA5-0 char{1, 1}"]]
eNFA5_1_15044627[["εNFA5-1 char[1]"]]
eNFA5_2_1183915[["εNFA5-2 char{1, 1}"]]
eNFA5_3_10655236[["εNFA5-3 char[1]"]]
eNFA5_4_28788263[["εNFA5-4 char{1, 1}"]]
eNFA5_5_57767782[["εNFA5-5 char[1]"]]
eNFA5_6_50147992[["εNFA5-6 char{1, 1}"]]
eNFA5_7_48678752[\"εNFA5-7 char[1]"/]
eNFA5_9_35455590[\"εNFA5-9 regex end"/]
eNFA5_10_50664859[\"εNFA5-10 post-regex start"/]
eNFA5_11_53330552[\"εNFA5-11 post-regex end"/]
eNFA5_8_3499754 -.->|"ε"|eNFA5_0_31497787
eNFA5_8_3499754 -->|"t"|eNFA5_1_15044627
eNFA5_0_31497787 -->|"t"|eNFA5_1_15044627
eNFA5_1_15044627 -.->|"ε"|eNFA5_2_1183915
eNFA5_1_15044627 -->|"r"|eNFA5_3_10655236
eNFA5_2_1183915 -->|"r"|eNFA5_3_10655236
eNFA5_3_10655236 -.->|"ε"|eNFA5_4_28788263
eNFA5_3_10655236 -->|"u"|eNFA5_5_57767782
eNFA5_4_28788263 -->|"u"|eNFA5_5_57767782
eNFA5_5_57767782 -.->|"ε"|eNFA5_6_50147992
eNFA5_5_57767782 -->|"e"|eNFA5_7_48678752
eNFA5_6_50147992 -->|"e"|eNFA5_7_48678752
eNFA5_7_48678752 -.->|"ε"|eNFA5_9_35455590
eNFA5_7_48678752 -.->|"ε"|eNFA5_10_50664859
eNFA5_7_48678752 -.->|"ε"|eNFA5_11_53330552
eNFA5_9_35455590 -.->|"ε"|eNFA5_10_50664859
eNFA5_9_35455590 -.->|"ε"|eNFA5_11_53330552
eNFA5_10_50664859 -.->|"ε"|eNFA5_11_53330552
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
NFA5_8_10212927("NFA5-8 regex start")
NFA5_1_24807479("NFA5-1 char[1]")
NFA5_3_21940722("NFA5-3 char[1]")
NFA5_5_63248778("NFA5-5 char[1]")
NFA5_7_32368095[\"NFA5-7 char[1]"/]
NFA5_8_10212927 -->|"t"|NFA5_1_24807479
NFA5_1_24807479 -->|"r"|NFA5_3_21940722
NFA5_3_21940722 -->|"u"|NFA5_5_63248778
NFA5_5_63248778 -->|"e"|NFA5_7_32368095
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
subgraph DFA0_-1579787873["DFA0 regex start"]
NFA5_8_10212927_0("NFA5-8 regex start")
end
subgraph DFA1_-1846095987["DFA1 {1}"]
NFA5_1_24807479_1("NFA5-1 char[1]")
end
subgraph DFA2_1641279886["DFA2 {1}"]
NFA5_3_21940722_2("NFA5-3 char[1]")
end
subgraph DFA3_-671150250["DFA3 {1}"]
NFA5_5_63248778_3("NFA5-5 char[1]")
end
subgraph DFA4_842451611["DFA4 {1}"]
NFA5_7_32368095_4[\"NFA5-7 char[1]"/]
end
DFA0_-1579787873 -->|"t"|DFA1_-1846095987
DFA1_-1846095987 -->|"r"|DFA2_1641279886
DFA2_1641279886 -->|"u"|DFA3_-671150250
DFA3_-671150250 -->|"e"|DFA4_842451611
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
DFA0_-1579787873{{"DFA0 regex start"}}
DFA1_-1846095987{{"DFA1 {1}"}}
DFA2_1641279886{{"DFA2 {1}"}}
DFA3_-671150250{{"DFA3 {1}"}}
DFA4_842451611[\"DFA4 {1}"/]
DFA0_-1579787873 -->|"t"|DFA1_-1846095987
DFA1_-1846095987 -->|"r"|DFA2_1641279886
DFA2_1641279886 -->|"u"|DFA3_-671150250
DFA3_-671150250 -->|"e"|DFA4_842451611
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
subgraph MiniDFA0_236951406["MiniDFA0 {1}"]
DFA0_-1579787873_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1274442471["MiniDFA1 {1}"]
DFA1_-1846095987_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-706686711["MiniDFA2 {1}"]
DFA2_1641279886_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1830402553["MiniDFA3 {1}"]
DFA3_-671150250_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1374431843["MiniDFA4 {1}"]
DFA4_842451611_4[\"DFA4 {1}"/]
end
MiniDFA0_236951406 -->|"t"|MiniDFA1_-1274442471
MiniDFA1_-1274442471 -->|"r"|MiniDFA2_-706686711
MiniDFA2_-706686711 -->|"u"|MiniDFA3_-1830402553
MiniDFA3_-1830402553 -->|"e"|MiniDFA4_1374431843
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
MiniDFA0_236951406(["MiniDFA0 {1}"])
MiniDFA1_-1274442471(["MiniDFA1 {1}"])
MiniDFA2_-706686711(["MiniDFA2 {1}"])
MiniDFA3_-1830402553(["MiniDFA3 {1}"])
MiniDFA4_1374431843[\"MiniDFA4 {1}"/]
MiniDFA0_236951406 -->|"t"|MiniDFA1_-1274442471
MiniDFA1_-1274442471 -->|"r"|MiniDFA2_-706686711
MiniDFA2_-706686711 -->|"u"|MiniDFA3_-1830402553
MiniDFA3_-1830402553 -->|"e"|MiniDFA4_1374431843
```
-------------------------------
