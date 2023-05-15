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
eNFA18_5_52900717[["εNFA18-5 regex start"]]
eNFA18_0_6344410[["εNFA18-0 char{1, 1}"]]
eNFA18_1_57099698[["εNFA18-1 char[1]"]]
eNFA18_2_44135236[["εNFA18-2 char{1, 1}"]]
eNFA18_3_45207585[["εNFA18-3 char[1]"]]
eNFA18_4_57218848[["εNFA18-4 char{0, ∞}"]]
eNFA18_6_4215088[["εNFA18-6 regex end"]]
eNFA18_7_63649546[["εNFA18-7 post-regex start"]]
eNFA18_8_35975003[\"εNFA18-8 post-regex end"/]
eNFA18_5_52900717 -.->|"ε"|eNFA18_0_6344410
eNFA18_0_6344410 -->|"/"|eNFA18_1_57099698
eNFA18_1_57099698 -.->|"ε"|eNFA18_2_44135236
eNFA18_2_44135236 -->|"/"|eNFA18_3_45207585
eNFA18_3_45207585 -.->|"ε"|eNFA18_4_57218848
eNFA18_4_57218848 -->|"[#92;t#92;r#32;-~]"|eNFA18_4_57218848
eNFA18_4_57218848 -.->|"ε"|eNFA18_6_4215088
eNFA18_6_4215088 -.->|"ε"|eNFA18_7_63649546
eNFA18_7_63649546 -.->|"ε"|eNFA18_8_35975003
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
eNFA18_5_55339573[["εNFA18-5 regex start"]]
eNFA18_0_28294113[["εNFA18-0 char{1, 1}"]]
eNFA18_1_53320433[["εNFA18-1 char[1]"]]
eNFA18_2_10121853[["εNFA18-2 char{1, 1}"]]
eNFA18_3_18184391[\"εNFA18-3 char[1]"/]
eNFA18_4_61672811[\"εNFA18-4 char{0, ∞}"/]
eNFA18_6_29441793[\"εNFA18-6 regex end"/]
eNFA18_7_23987813[\"εNFA18-7 post-regex start"/]
eNFA18_8_14563732[\"εNFA18-8 post-regex end"/]
eNFA18_5_55339573 -.->|"ε"|eNFA18_0_28294113
eNFA18_5_55339573 -->|"/"|eNFA18_1_53320433
eNFA18_0_28294113 -->|"/"|eNFA18_1_53320433
eNFA18_1_53320433 -.->|"ε"|eNFA18_2_10121853
eNFA18_1_53320433 -->|"/"|eNFA18_3_18184391
eNFA18_2_10121853 -->|"/"|eNFA18_3_18184391
eNFA18_3_18184391 -.->|"ε"|eNFA18_4_61672811
eNFA18_3_18184391 -->|"[#92;t#92;r#32;-~]"|eNFA18_4_61672811
eNFA18_3_18184391 -.->|"ε"|eNFA18_6_29441793
eNFA18_3_18184391 -.->|"ε"|eNFA18_7_23987813
eNFA18_3_18184391 -.->|"ε"|eNFA18_8_14563732
eNFA18_4_61672811 -->|"[#92;t#92;r#32;-~]"|eNFA18_4_61672811
eNFA18_4_61672811 -.->|"ε"|eNFA18_6_29441793
eNFA18_4_61672811 -.->|"ε"|eNFA18_7_23987813
eNFA18_4_61672811 -.->|"ε"|eNFA18_8_14563732
eNFA18_6_29441793 -.->|"ε"|eNFA18_7_23987813
eNFA18_6_29441793 -.->|"ε"|eNFA18_8_14563732
eNFA18_7_23987813 -.->|"ε"|eNFA18_8_14563732
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
NFA18_5_13760664("NFA18-5 regex start")
NFA18_1_56737113("NFA18-1 char[1]")
NFA18_3_38811664[\"NFA18-3 char[1]"/]
NFA18_4_63964730[\"NFA18-4 char{0, ∞}"/]
NFA18_5_13760664 -->|"/"|NFA18_1_56737113
NFA18_1_56737113 -->|"/"|NFA18_3_38811664
NFA18_3_38811664 -->|"[#92;t#92;r#32;-~]"|NFA18_4_63964730
NFA18_4_63964730 -->|"[#92;t#92;r#32;-~]"|NFA18_4_63964730
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
subgraph DFA0_484623311["DFA0 regex start"]
NFA18_5_13760664_0("NFA18-5 regex start")
end
subgraph DFA1_2124428765["DFA1 {1}"]
NFA18_1_56737113_1("NFA18-1 char[1]")
end
subgraph DFA2_-267131210["DFA2 {1}"]
NFA18_3_38811664_2[\"NFA18-3 char[1]"/]
end
subgraph DFA3_302595750["DFA3 {1}"]
NFA18_4_63964730_3[\"NFA18-4 char{0, ∞}"/]
end
DFA0_484623311 -->|"/"|DFA1_2124428765
DFA1_2124428765 -->|"/"|DFA2_-267131210
DFA2_-267131210 -->|"[#92;t#92;r#32;-~]"|DFA3_302595750
DFA3_302595750 -->|"[#92;t#92;r#32;-~]"|DFA3_302595750
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
DFA0_484623311{{"DFA0 regex start"}}
DFA1_2124428765{{"DFA1 {1}"}}
DFA2_-267131210[\"DFA2 {1}"/]
DFA3_302595750[\"DFA3 {1}"/]
DFA0_484623311 -->|"/"|DFA1_2124428765
DFA1_2124428765 -->|"/"|DFA2_-267131210
DFA2_-267131210 -->|"[#92;t#92;r#32;-~]"|DFA3_302595750
DFA3_302595750 -->|"[#92;t#92;r#32;-~]"|DFA3_302595750
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
subgraph MiniDFA0_-304151542["MiniDFA0 {1}"]
DFA0_484623311_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1947232348["MiniDFA1 {1}"]
DFA1_2124428765_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_863999507["MiniDFA2 {1}"]
DFA2_-267131210_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-1486764086["MiniDFA3 {1}"]
DFA3_302595750_3[\"DFA3 {1}"/]
end
MiniDFA0_-304151542 -->|"/"|MiniDFA1_1947232348
MiniDFA1_1947232348 -->|"/"|MiniDFA2_863999507
MiniDFA2_863999507 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1486764086
MiniDFA3_-1486764086 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1486764086
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
MiniDFA0_-304151542(["MiniDFA0 {1}"])
MiniDFA1_1947232348(["MiniDFA1 {1}"])
MiniDFA2_863999507[\"MiniDFA2 {1}"/]
MiniDFA3_-1486764086[\"MiniDFA3 {1}"/]
MiniDFA0_-304151542 -->|"/"|MiniDFA1_1947232348
MiniDFA1_1947232348 -->|"/"|MiniDFA2_863999507
MiniDFA2_863999507 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1486764086
MiniDFA3_-1486764086 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1486764086
```
-------------------------------
