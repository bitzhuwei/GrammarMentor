# '++'

pattern: `\+\+`

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
eNFA10_4_37736673[["εNFA10-4 regex start"]]
eNFA10_0_4085744[["εNFA10-0 char{1, 1}"]]
eNFA10_1_36771698[["εNFA10-1 char[1]"]]
eNFA10_2_62509834[["εNFA10-2 char{1, 1}"]]
eNFA10_3_25717600[["εNFA10-3 char[1]"]]
eNFA10_5_30131813[["εNFA10-5 regex end"]]
eNFA10_6_2750866[["εNFA10-6 post-regex start"]]
eNFA10_7_24757801[\"εNFA10-7 post-regex end"/]
eNFA10_4_37736673 -.->|"ε"|eNFA10_0_4085744
eNFA10_0_4085744 -->|"+"|eNFA10_1_36771698
eNFA10_1_36771698 -.->|"ε"|eNFA10_2_62509834
eNFA10_2_62509834 -->|"+"|eNFA10_3_25717600
eNFA10_3_25717600 -.->|"ε"|eNFA10_5_30131813
eNFA10_5_30131813 -.->|"ε"|eNFA10_6_2750866
eNFA10_6_2750866 -.->|"ε"|eNFA10_7_24757801
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
eNFA10_4_21493617[["εNFA10-4 regex start"]]
eNFA10_0_59224828[["εNFA10-0 char{1, 1}"]]
eNFA10_1_63261412[["εNFA10-1 char[1]"]]
eNFA10_2_32481801[["εNFA10-2 char{1, 1}"]]
eNFA10_3_23900756[\"εNFA10-3 char[1]"/]
eNFA10_5_13780214[\"εNFA10-5 regex end"/]
eNFA10_6_56913064[\"εNFA10-6 post-regex start"/]
eNFA10_7_42455531[\"εNFA10-7 post-regex end"/]
eNFA10_4_21493617 -.->|"ε"|eNFA10_0_59224828
eNFA10_4_21493617 -->|"+"|eNFA10_1_63261412
eNFA10_0_59224828 -->|"+"|eNFA10_1_63261412
eNFA10_1_63261412 -.->|"ε"|eNFA10_2_32481801
eNFA10_1_63261412 -->|"+"|eNFA10_3_23900756
eNFA10_2_32481801 -->|"+"|eNFA10_3_23900756
eNFA10_3_23900756 -.->|"ε"|eNFA10_5_13780214
eNFA10_3_23900756 -.->|"ε"|eNFA10_6_56913064
eNFA10_3_23900756 -.->|"ε"|eNFA10_7_42455531
eNFA10_5_13780214 -.->|"ε"|eNFA10_6_56913064
eNFA10_5_13780214 -.->|"ε"|eNFA10_7_42455531
eNFA10_6_56913064 -.->|"ε"|eNFA10_7_42455531
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
NFA10_4_46555465("NFA10-4 regex start")
NFA10_1_16346001("NFA10-1 char[1]")
NFA10_3_12896286[\"NFA10-3 char[1]"/]
NFA10_4_46555465 -->|"+"|NFA10_1_16346001
NFA10_1_16346001 -->|"+"|NFA10_3_12896286
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
subgraph DFA0_273561241["DFA0 regex start"]
NFA10_4_46555465_0("NFA10-4 regex start")
end
subgraph DFA1_-480880766["DFA1 {1}"]
NFA10_1_16346001_1("NFA10-1 char[1]")
end
subgraph DFA2_321062783["DFA2 {1}"]
NFA10_3_12896286_2[\"NFA10-3 char[1]"/]
end
DFA0_273561241 -->|"+"|DFA1_-480880766
DFA1_-480880766 -->|"+"|DFA2_321062783
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
DFA0_273561241{{"DFA0 regex start"}}
DFA1_-480880766{{"DFA1 {1}"}}
DFA2_321062783[\"DFA2 {1}"/]
DFA0_273561241 -->|"+"|DFA1_-480880766
DFA1_-480880766 -->|"+"|DFA2_321062783
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
subgraph MiniDFA0_2023897004["MiniDFA0 {1}"]
DFA0_273561241_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1457019369["MiniDFA1 {1}"]
DFA1_-480880766_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1893579506["MiniDFA2 {1}"]
DFA2_321062783_2[\"DFA2 {1}"/]
end
MiniDFA0_2023897004 -->|"+"|MiniDFA1_1457019369
MiniDFA1_1457019369 -->|"+"|MiniDFA2_1893579506
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
MiniDFA0_2023897004(["MiniDFA0 {1}"])
MiniDFA1_1457019369(["MiniDFA1 {1}"])
MiniDFA2_1893579506[\"MiniDFA2 {1}"/]
MiniDFA0_2023897004 -->|"+"|MiniDFA1_1457019369
MiniDFA1_1457019369 -->|"+"|MiniDFA2_1893579506
```
-------------------------------
