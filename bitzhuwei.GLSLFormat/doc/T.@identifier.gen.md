# 'identifier'

pattern: `[a-z-A-Z_][a-z-A-Z0-9_]*`

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
eNFA1_3_16127101[["εNFA1-3 regex start"]]
eNFA1_0_10926182[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_1577639[["εNFA1-1 scope[1]"]]
eNFA1_2_175293[["εNFA1-2 scope{0, ∞}"]]
eNFA1_4_14198754[["εNFA1-4 regex end"]]
eNFA1_5_14419821[["εNFA1-5 post-regex start"]]
eNFA1_6_62669527[\"εNFA1-6 post-regex end"/]
eNFA1_3_16127101 -.->|"ε"|eNFA1_0_10926182
eNFA1_0_10926182 -->|"[a-z-A-Z_]"|eNFA1_1_1577639
eNFA1_1_1577639 -.->|"ε"|eNFA1_2_175293
eNFA1_2_175293 -->|"[a-z-A-Z0-9_]"|eNFA1_2_175293
eNFA1_2_175293 -.->|"ε"|eNFA1_4_14198754
eNFA1_4_14198754 -.->|"ε"|eNFA1_5_14419821
eNFA1_5_14419821 -.->|"ε"|eNFA1_6_62669527
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
eNFA1_3_27154837[["εNFA1-3 regex start"]]
eNFA1_0_43066942[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_12605589[\"εNFA1-1 scope[1]"/]
eNFA1_2_31226782[\"εNFA1-2 scope{0, ∞}"/]
eNFA1_4_46341445[\"εNFA1-4 regex end"/]
eNFA1_5_52058165[\"εNFA1-5 post-regex start"/]
eNFA1_6_65870306[\"εNFA1-6 post-regex end"/]
eNFA1_3_27154837 -.->|"ε"|eNFA1_0_43066942
eNFA1_3_27154837 -->|"[a-z-A-Z_]"|eNFA1_1_12605589
eNFA1_0_43066942 -->|"[a-z-A-Z_]"|eNFA1_1_12605589
eNFA1_1_12605589 -.->|"ε"|eNFA1_2_31226782
eNFA1_1_12605589 -->|"[a-z-A-Z0-9_]"|eNFA1_2_31226782
eNFA1_1_12605589 -.->|"ε"|eNFA1_4_46341445
eNFA1_1_12605589 -.->|"ε"|eNFA1_5_52058165
eNFA1_1_12605589 -.->|"ε"|eNFA1_6_65870306
eNFA1_2_31226782 -->|"[a-z-A-Z0-9_]"|eNFA1_2_31226782
eNFA1_2_31226782 -.->|"ε"|eNFA1_4_46341445
eNFA1_2_31226782 -.->|"ε"|eNFA1_5_52058165
eNFA1_2_31226782 -.->|"ε"|eNFA1_6_65870306
eNFA1_4_46341445 -.->|"ε"|eNFA1_5_52058165
eNFA1_4_46341445 -.->|"ε"|eNFA1_6_65870306
eNFA1_5_52058165 -.->|"ε"|eNFA1_6_65870306
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
NFA1_3_36615679("NFA1-3 regex start")
NFA1_1_33894570[\"NFA1-1 scope[1]"/]
NFA1_2_55961846[\"NFA1-2 scope{0, ∞}"/]
NFA1_3_36615679 -->|"[a-z-A-Z_]"|NFA1_1_33894570
NFA1_1_33894570 -->|"[a-z-A-Z0-9_]"|NFA1_2_55961846
NFA1_2_55961846 -->|"[a-z-A-Z0-9_]"|NFA1_2_55961846
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
subgraph DFA0_-1256498327["DFA0 regex start"]
NFA1_3_36615679_0("NFA1-3 regex start")
end
subgraph DFA1_-1260138316["DFA1 {1}"]
NFA1_1_33894570_1[\"NFA1-1 scope[1]"/]
end
subgraph DFA2_-1625083381["DFA2 {1}"]
NFA1_2_55961846_2[\"NFA1-2 scope{0, ∞}"/]
end
DFA0_-1256498327 -->|"[a-z-A-Z_]"|DFA1_-1260138316
DFA1_-1260138316 -->|"[a-z-A-Z0-9_]"|DFA2_-1625083381
DFA2_-1625083381 -->|"[a-z-A-Z0-9_]"|DFA2_-1625083381
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
DFA0_-1256498327{{"DFA0 regex start"}}
DFA1_-1260138316[\"DFA1 {1}"/]
DFA2_-1625083381[\"DFA2 {1}"/]
DFA0_-1256498327 -->|"[a-z-A-Z_]"|DFA1_-1260138316
DFA1_-1260138316 -->|"[a-z-A-Z0-9_]"|DFA2_-1625083381
DFA2_-1625083381 -->|"[a-z-A-Z0-9_]"|DFA2_-1625083381
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
subgraph MiniDFA0_1664084667["MiniDFA0 {1}"]
DFA0_-1256498327_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_277162586["MiniDFA1 {1}"]
DFA1_-1260138316_1[\"DFA1 {1}"/]
end
subgraph MiniDFA2_-955645585["MiniDFA2 {1}"]
DFA2_-1625083381_2[\"DFA2 {1}"/]
end
MiniDFA0_1664084667 -->|"[a-z-A-Z_]"|MiniDFA1_277162586
MiniDFA1_277162586 -->|"[a-z-A-Z0-9_]"|MiniDFA2_-955645585
MiniDFA2_-955645585 -->|"[a-z-A-Z0-9_]"|MiniDFA2_-955645585
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
MiniDFA0_1664084667(["MiniDFA0 {1}"])
MiniDFA1_277162586[\"MiniDFA1 {1}"/]
MiniDFA2_-955645585[\"MiniDFA2 {1}"/]
MiniDFA0_1664084667 -->|"[a-z-A-Z_]"|MiniDFA1_277162586
MiniDFA1_277162586 -->|"[a-z-A-Z0-9_]"|MiniDFA2_-955645585
MiniDFA2_-955645585 -->|"[a-z-A-Z0-9_]"|MiniDFA2_-955645585
```
-------------------------------
