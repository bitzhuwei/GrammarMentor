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
eNFA5_5_14249239[["εNFA5-5 regex start"]]
eNFA5_0_61134295[["εNFA5-0 char{1, 1}"]]
eNFA5_1_13337744[["εNFA5-1 char[1]"]]
eNFA5_2_52930837[["εNFA5-2 char{1, 1}"]]
eNFA5_3_52678692[["εNFA5-3 char[1]"]]
eNFA5_4_13309728[["εNFA5-4 char{0, ∞}"]]
eNFA5_6_4346180[["εNFA5-6 regex end"]]
eNFA5_7_57959746[["εNFA5-7 post-regex start"]]
eNFA5_8_51875669[\"εNFA5-8 post-regex end"/]
eNFA5_5_14249239 -.->|"ε"|eNFA5_0_61134295
eNFA5_0_61134295 -->|"/"|eNFA5_1_13337744
eNFA5_1_13337744 -.->|"ε"|eNFA5_2_52930837
eNFA5_2_52930837 -->|"/"|eNFA5_3_52678692
eNFA5_3_52678692 -.->|"ε"|eNFA5_4_13309728
eNFA5_4_13309728 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_13309728
eNFA5_4_13309728 -.->|"ε"|eNFA5_6_4346180
eNFA5_6_4346180 -.->|"ε"|eNFA5_7_57959746
eNFA5_7_57959746 -.->|"ε"|eNFA5_8_51875669
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
eNFA5_5_64227841[["εNFA5-5 regex start"]]
eNFA5_0_41179664[["εNFA5-0 char{1, 1}"]]
eNFA5_1_35072657[["εNFA5-1 char[1]"]]
eNFA5_2_47218463[["εNFA5-2 char{1, 1}"]]
eNFA5_3_59539371[\"εNFA5-3 char[1]"/]
eNFA5_4_6615485[\"εNFA5-4 char{0, ∞}"/]
eNFA5_6_66092295[\"εNFA5-6 regex end"/]
eNFA5_7_22312986[\"εNFA5-7 post-regex start"/]
eNFA5_8_66599147[\"εNFA5-8 post-regex end"/]
eNFA5_5_64227841 -.->|"ε"|eNFA5_0_41179664
eNFA5_5_64227841 -->|"/"|eNFA5_1_35072657
eNFA5_0_41179664 -->|"/"|eNFA5_1_35072657
eNFA5_1_35072657 -.->|"ε"|eNFA5_2_47218463
eNFA5_1_35072657 -->|"/"|eNFA5_3_59539371
eNFA5_2_47218463 -->|"/"|eNFA5_3_59539371
eNFA5_3_59539371 -.->|"ε"|eNFA5_4_6615485
eNFA5_3_59539371 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_6615485
eNFA5_3_59539371 -.->|"ε"|eNFA5_6_66092295
eNFA5_3_59539371 -.->|"ε"|eNFA5_7_22312986
eNFA5_3_59539371 -.->|"ε"|eNFA5_8_66599147
eNFA5_4_6615485 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_6615485
eNFA5_4_6615485 -.->|"ε"|eNFA5_6_66092295
eNFA5_4_6615485 -.->|"ε"|eNFA5_7_22312986
eNFA5_4_6615485 -.->|"ε"|eNFA5_8_66599147
eNFA5_6_66092295 -.->|"ε"|eNFA5_7_22312986
eNFA5_6_66092295 -.->|"ε"|eNFA5_8_66599147
eNFA5_7_22312986 -.->|"ε"|eNFA5_8_66599147
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
NFA5_5_31069492("NFA5-5 regex start")
NFA5_1_11189975("NFA5-1 char[1]")
NFA5_3_25821787[\"NFA5-3 char[1]"/]
NFA5_4_62521411[\"NFA5-4 char{0, ∞}"/]
NFA5_5_31069492 -->|"/"|NFA5_1_11189975
NFA5_1_11189975 -->|"/"|NFA5_3_25821787
NFA5_3_25821787 -->|"[#92;t#92;r#32;-~]"|NFA5_4_62521411
NFA5_4_62521411 -->|"[#92;t#92;r#32;-~]"|NFA5_4_62521411
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
subgraph DFA0_1498576639["DFA0 regex start"]
NFA5_5_31069492_0("NFA5-5 regex start")
end
subgraph DFA1_-1780796803["DFA1 {1}"]
NFA5_1_11189975_1("NFA5-1 char[1]")
end
subgraph DFA2_-1497493473["DFA2 {1}"]
NFA5_3_25821787_2[\"NFA5-3 char[1]"/]
end
subgraph DFA3_1261702155["DFA3 {1}"]
NFA5_4_62521411_3[\"NFA5-4 char{0, ∞}"/]
end
DFA0_1498576639 -->|"/"|DFA1_-1780796803
DFA1_-1780796803 -->|"/"|DFA2_-1497493473
DFA2_-1497493473 -->|"[#92;t#92;r#32;-~]"|DFA3_1261702155
DFA3_1261702155 -->|"[#92;t#92;r#32;-~]"|DFA3_1261702155
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
DFA0_1498576639{{"DFA0 regex start"}}
DFA1_-1780796803{{"DFA1 {1}"}}
DFA2_-1497493473[\"DFA2 {1}"/]
DFA3_1261702155[\"DFA3 {1}"/]
DFA0_1498576639 -->|"/"|DFA1_-1780796803
DFA1_-1780796803 -->|"/"|DFA2_-1497493473
DFA2_-1497493473 -->|"[#92;t#92;r#32;-~]"|DFA3_1261702155
DFA3_1261702155 -->|"[#92;t#92;r#32;-~]"|DFA3_1261702155
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
subgraph MiniDFA0_697490964["MiniDFA0 {1}"]
DFA0_1498576639_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2145421023["MiniDFA1 {1}"]
DFA1_-1780796803_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_149024092["MiniDFA2 {1}"]
DFA2_-1497493473_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-529782848["MiniDFA3 {1}"]
DFA3_1261702155_3[\"DFA3 {1}"/]
end
MiniDFA0_697490964 -->|"/"|MiniDFA1_-2145421023
MiniDFA1_-2145421023 -->|"/"|MiniDFA2_149024092
MiniDFA2_149024092 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-529782848
MiniDFA3_-529782848 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-529782848
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
MiniDFA0_697490964(["MiniDFA0 {1}"])
MiniDFA1_-2145421023(["MiniDFA1 {1}"])
MiniDFA2_149024092[\"MiniDFA2 {1}"/]
MiniDFA3_-529782848[\"MiniDFA3 {1}"/]
MiniDFA0_697490964 -->|"/"|MiniDFA1_-2145421023
MiniDFA1_-2145421023 -->|"/"|MiniDFA2_149024092
MiniDFA2_149024092 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-529782848
MiniDFA3_-529782848 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-529782848
```
-------------------------------
