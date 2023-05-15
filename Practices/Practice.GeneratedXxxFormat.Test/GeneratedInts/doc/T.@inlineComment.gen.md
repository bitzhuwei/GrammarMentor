# 'inlineComment'

pattern: `\/\/.*`

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
eNFA3_5_60569775[["εNFA3-5 regex start"]]
eNFA3_0_8257064[["εNFA3-0 char{1, 1}"]]
eNFA3_1_7204713[["εNFA3-1 char[1]"]]
eNFA3_2_64842419[["εNFA3-2 char{1, 1}"]]
eNFA3_3_30715040[["εNFA3-3 char[1]"]]
eNFA3_4_48152024[["εNFA3-4 char{0, ∞}"]]
eNFA3_6_7999906[["εNFA3-6 regex end"]]
eNFA3_7_28025763[["εNFA3-7 post-regex start"]]
eNFA3_8_50905282[\"εNFA3-8 post-regex end"/]
eNFA3_5_60569775 -.->|"ε"|eNFA3_0_8257064
eNFA3_0_8257064 -->|"/"|eNFA3_1_7204713
eNFA3_1_7204713 -.->|"ε"|eNFA3_2_64842419
eNFA3_2_64842419 -->|"/"|eNFA3_3_30715040
eNFA3_3_30715040 -.->|"ε"|eNFA3_4_48152024
eNFA3_4_48152024 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_48152024
eNFA3_4_48152024 -.->|"ε"|eNFA3_6_7999906
eNFA3_6_7999906 -.->|"ε"|eNFA3_7_28025763
eNFA3_7_28025763 -.->|"ε"|eNFA3_8_50905282
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
eNFA3_5_55494360[["εNFA3-5 regex start"]]
eNFA3_0_29687198[["εNFA3-0 char{1, 1}"]]
eNFA3_1_65858198[["εNFA3-1 char[1]"]]
eNFA3_2_55852871[["εNFA3-2 char{1, 1}"]]
eNFA3_3_17744591[\"εNFA3-3 char[1]"/]
eNFA3_4_46710863[\"εNFA3-4 char{0, ∞}"/]
eNFA3_6_25483595[\"εNFA3-6 regex end"/]
eNFA3_7_32913796[\"εNFA3-7 post-regex start"/]
eNFA3_8_27788708[\"εNFA3-8 post-regex end"/]
eNFA3_5_55494360 -.->|"ε"|eNFA3_0_29687198
eNFA3_5_55494360 -->|"/"|eNFA3_1_65858198
eNFA3_0_29687198 -->|"/"|eNFA3_1_65858198
eNFA3_1_65858198 -.->|"ε"|eNFA3_2_55852871
eNFA3_1_65858198 -->|"/"|eNFA3_3_17744591
eNFA3_2_55852871 -->|"/"|eNFA3_3_17744591
eNFA3_3_17744591 -.->|"ε"|eNFA3_4_46710863
eNFA3_3_17744591 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_46710863
eNFA3_3_17744591 -.->|"ε"|eNFA3_6_25483595
eNFA3_3_17744591 -.->|"ε"|eNFA3_7_32913796
eNFA3_3_17744591 -.->|"ε"|eNFA3_8_27788708
eNFA3_4_46710863 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_46710863
eNFA3_4_46710863 -.->|"ε"|eNFA3_6_25483595
eNFA3_4_46710863 -.->|"ε"|eNFA3_7_32913796
eNFA3_4_46710863 -.->|"ε"|eNFA3_8_27788708
eNFA3_6_25483595 -.->|"ε"|eNFA3_7_32913796
eNFA3_6_25483595 -.->|"ε"|eNFA3_8_27788708
eNFA3_7_32913796 -.->|"ε"|eNFA3_8_27788708
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
NFA3_5_58200593("NFA3-5 regex start")
NFA3_1_54043292("NFA3-1 char[1]")
NFA3_3_36292894[\"NFA3-3 char[1]"/]
NFA3_4_48771786[\"NFA3-4 char{0, ∞}"/]
NFA3_5_58200593 -->|"/"|NFA3_1_54043292
NFA3_1_54043292 -->|"/"|NFA3_3_36292894
NFA3_3_36292894 -->|"[#92;t#92;r#32;-~]"|NFA3_4_48771786
NFA3_4_48771786 -->|"[#92;t#92;r#32;-~]"|NFA3_4_48771786
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
subgraph DFA0_-38388159["DFA0 regex start"]
NFA3_5_58200593_0("NFA3-5 regex start")
end
subgraph DFA1_-810324086["DFA1 {1}"]
NFA3_1_54043292_1("NFA3-1 char[1]")
end
subgraph DFA2_1982085238["DFA2 {1}"]
NFA3_3_36292894_2[\"NFA3-3 char[1]"/]
end
subgraph DFA3_-1353646538["DFA3 {1}"]
NFA3_4_48771786_3[\"NFA3-4 char{0, ∞}"/]
end
DFA0_-38388159 -->|"/"|DFA1_-810324086
DFA1_-810324086 -->|"/"|DFA2_1982085238
DFA2_1982085238 -->|"[#92;t#92;r#32;-~]"|DFA3_-1353646538
DFA3_-1353646538 -->|"[#92;t#92;r#32;-~]"|DFA3_-1353646538
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
DFA0_-38388159{{"DFA0 regex start"}}
DFA1_-810324086{{"DFA1 {1}"}}
DFA2_1982085238[\"DFA2 {1}"/]
DFA3_-1353646538[\"DFA3 {1}"/]
DFA0_-38388159 -->|"/"|DFA1_-810324086
DFA1_-810324086 -->|"/"|DFA2_1982085238
DFA2_1982085238 -->|"[#92;t#92;r#32;-~]"|DFA3_-1353646538
DFA3_-1353646538 -->|"[#92;t#92;r#32;-~]"|DFA3_-1353646538
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
subgraph MiniDFA0_-843440092["MiniDFA0 {1}"]
DFA0_-38388159_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1489093333["MiniDFA1 {1}"]
DFA1_-810324086_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1977403348["MiniDFA2 {1}"]
DFA2_1982085238_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-119540973["MiniDFA3 {1}"]
DFA3_-1353646538_3[\"DFA3 {1}"/]
end
MiniDFA0_-843440092 -->|"/"|MiniDFA1_-1489093333
MiniDFA1_-1489093333 -->|"/"|MiniDFA2_-1977403348
MiniDFA2_-1977403348 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-119540973
MiniDFA3_-119540973 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-119540973
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
MiniDFA0_-843440092(["MiniDFA0 {1}"])
MiniDFA1_-1489093333(["MiniDFA1 {1}"])
MiniDFA2_-1977403348[\"MiniDFA2 {1}"/]
MiniDFA3_-119540973[\"MiniDFA3 {1}"/]
MiniDFA0_-843440092 -->|"/"|MiniDFA1_-1489093333
MiniDFA1_-1489093333 -->|"/"|MiniDFA2_-1977403348
MiniDFA2_-1977403348 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-119540973
MiniDFA3_-119540973 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-119540973
```
-------------------------------
