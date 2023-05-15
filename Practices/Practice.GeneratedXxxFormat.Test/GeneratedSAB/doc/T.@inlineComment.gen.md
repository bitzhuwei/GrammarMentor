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
eNFA7_5_13891457[["εNFA7-5 regex start"]]
eNFA7_0_57914257[["εNFA7-0 char{1, 1}"]]
eNFA7_1_51466265[["εNFA7-1 char[1]"]]
eNFA7_2_60543203[["εNFA7-2 char{1, 1}"]]
eNFA7_3_33132068[["εNFA7-3 char[1]"]]
eNFA7_4_55877124[["εNFA7-4 char{0, ∞}"]]
eNFA7_6_29753161[["εNFA7-6 regex end"]]
eNFA7_7_6593390[["εNFA7-7 post-regex start"]]
eNFA7_8_59340514[\"εNFA7-8 post-regex end"/]
eNFA7_5_13891457 -.->|"ε"|eNFA7_0_57914257
eNFA7_0_57914257 -->|"/"|eNFA7_1_51466265
eNFA7_1_51466265 -.->|"ε"|eNFA7_2_60543203
eNFA7_2_60543203 -->|"/"|eNFA7_3_33132068
eNFA7_3_33132068 -.->|"ε"|eNFA7_4_55877124
eNFA7_4_55877124 -->|"[#92;t#92;r#32;-~]"|eNFA7_4_55877124
eNFA7_4_55877124 -.->|"ε"|eNFA7_6_29753161
eNFA7_6_29753161 -.->|"ε"|eNFA7_7_6593390
eNFA7_7_6593390 -.->|"ε"|eNFA7_8_59340514
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
eNFA7_5_64302582[["εNFA7-5 regex start"]]
eNFA7_0_41852331[["εNFA7-0 char{1, 1}"]]
eNFA7_1_41126667[["εNFA7-1 char[1]"]]
eNFA7_2_34595685[["εNFA7-2 char{1, 1}"]]
eNFA7_3_5052426[\"εNFA7-3 char[1]"/]
eNFA7_4_8017921[\"εNFA7-4 char{0, ∞}"/]
eNFA7_6_45471841[\"εNFA7-6 regex end"/]
eNFA7_7_42925716[\"εNFA7-7 post-regex start"/]
eNFA7_8_50787128[\"εNFA7-8 post-regex end"/]
eNFA7_5_64302582 -.->|"ε"|eNFA7_0_41852331
eNFA7_5_64302582 -->|"/"|eNFA7_1_41126667
eNFA7_0_41852331 -->|"/"|eNFA7_1_41126667
eNFA7_1_41126667 -.->|"ε"|eNFA7_2_34595685
eNFA7_1_41126667 -->|"/"|eNFA7_3_5052426
eNFA7_2_34595685 -->|"/"|eNFA7_3_5052426
eNFA7_3_5052426 -.->|"ε"|eNFA7_4_8017921
eNFA7_3_5052426 -->|"[#92;t#92;r#32;-~]"|eNFA7_4_8017921
eNFA7_3_5052426 -.->|"ε"|eNFA7_6_45471841
eNFA7_3_5052426 -.->|"ε"|eNFA7_7_42925716
eNFA7_3_5052426 -.->|"ε"|eNFA7_8_50787128
eNFA7_4_8017921 -->|"[#92;t#92;r#32;-~]"|eNFA7_4_8017921
eNFA7_4_8017921 -.->|"ε"|eNFA7_6_45471841
eNFA7_4_8017921 -.->|"ε"|eNFA7_7_42925716
eNFA7_4_8017921 -.->|"ε"|eNFA7_8_50787128
eNFA7_6_45471841 -.->|"ε"|eNFA7_7_42925716
eNFA7_6_45471841 -.->|"ε"|eNFA7_8_50787128
eNFA7_7_42925716 -.->|"ε"|eNFA7_8_50787128
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
NFA7_5_46832420("NFA7-5 regex start")
NFA7_1_18838598("NFA7-1 char[1]")
NFA7_3_20116683[\"NFA7-3 char[1]"/]
NFA7_4_54430970[\"NFA7-4 char{0, ∞}"/]
NFA7_5_46832420 -->|"/"|NFA7_1_18838598
NFA7_1_18838598 -->|"/"|NFA7_3_20116683
NFA7_3_20116683 -->|"[#92;t#92;r#32;-~]"|NFA7_4_54430970
NFA7_4_54430970 -->|"[#92;t#92;r#32;-~]"|NFA7_4_54430970
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
subgraph DFA0_-1189936588["DFA0 regex start"]
NFA7_5_46832420_0("NFA7-5 regex start")
end
subgraph DFA1_-179120099["DFA1 {1}"]
NFA7_1_18838598_1("NFA7-1 char[1]")
end
subgraph DFA2_-723217743["DFA2 {1}"]
NFA7_3_20116683_2[\"NFA7-3 char[1]"/]
end
subgraph DFA3_-1240700024["DFA3 {1}"]
NFA7_4_54430970_3[\"NFA7-4 char{0, ∞}"/]
end
DFA0_-1189936588 -->|"/"|DFA1_-179120099
DFA1_-179120099 -->|"/"|DFA2_-723217743
DFA2_-723217743 -->|"[#92;t#92;r#32;-~]"|DFA3_-1240700024
DFA3_-1240700024 -->|"[#92;t#92;r#32;-~]"|DFA3_-1240700024
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
DFA0_-1189936588{{"DFA0 regex start"}}
DFA1_-179120099{{"DFA1 {1}"}}
DFA2_-723217743[\"DFA2 {1}"/]
DFA3_-1240700024[\"DFA3 {1}"/]
DFA0_-1189936588 -->|"/"|DFA1_-179120099
DFA1_-179120099 -->|"/"|DFA2_-723217743
DFA2_-723217743 -->|"[#92;t#92;r#32;-~]"|DFA3_-1240700024
DFA3_-1240700024 -->|"[#92;t#92;r#32;-~]"|DFA3_-1240700024
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
subgraph MiniDFA0_524874628["MiniDFA0 {1}"]
DFA0_-1189936588_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-829861696["MiniDFA1 {1}"]
DFA1_-179120099_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_596019774["MiniDFA2 {1}"]
DFA2_-723217743_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-1223637425["MiniDFA3 {1}"]
DFA3_-1240700024_3[\"DFA3 {1}"/]
end
MiniDFA0_524874628 -->|"/"|MiniDFA1_-829861696
MiniDFA1_-829861696 -->|"/"|MiniDFA2_596019774
MiniDFA2_596019774 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1223637425
MiniDFA3_-1223637425 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1223637425
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
MiniDFA0_524874628(["MiniDFA0 {1}"])
MiniDFA1_-829861696(["MiniDFA1 {1}"])
MiniDFA2_596019774[\"MiniDFA2 {1}"/]
MiniDFA3_-1223637425[\"MiniDFA3 {1}"/]
MiniDFA0_524874628 -->|"/"|MiniDFA1_-829861696
MiniDFA1_-829861696 -->|"/"|MiniDFA2_596019774
MiniDFA2_596019774 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1223637425
MiniDFA3_-1223637425 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1223637425
```
-------------------------------
