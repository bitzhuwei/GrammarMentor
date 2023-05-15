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
eNFA5_5_26148945[["εNFA5-5 regex start"]]
eNFA5_0_34013913[["εNFA5-0 char{1, 1}"]]
eNFA5_1_37689768[["εNFA5-1 char[1]"]]
eNFA5_2_3663598[["εNFA5-2 char{1, 1}"]]
eNFA5_3_51442863[["εNFA5-3 char[1]"]]
eNFA5_4_13172414[["εNFA5-4 char{0, ∞}"]]
eNFA5_6_60332585[["εNFA5-6 regex end"]]
eNFA5_7_11898202[["εNFA5-7 post-regex start"]]
eNFA5_8_39974954[\"εNFA5-8 post-regex end"/]
eNFA5_5_26148945 -.->|"ε"|eNFA5_0_34013913
eNFA5_0_34013913 -->|"/"|eNFA5_1_37689768
eNFA5_1_37689768 -.->|"ε"|eNFA5_2_3663598
eNFA5_2_3663598 -->|"/"|eNFA5_3_51442863
eNFA5_3_51442863 -.->|"ε"|eNFA5_4_13172414
eNFA5_4_13172414 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_13172414
eNFA5_4_13172414 -.->|"ε"|eNFA5_6_60332585
eNFA5_6_60332585 -.->|"ε"|eNFA5_7_11898202
eNFA5_7_11898202 -.->|"ε"|eNFA5_8_39974954
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
eNFA5_5_24230272[["εNFA5-5 regex start"]]
eNFA5_0_16745860[["εNFA5-0 char{1, 1}"]]
eNFA5_1_16495015[["εNFA5-1 char[1]"]]
eNFA5_2_14237410[["εNFA5-2 char{1, 1}"]]
eNFA5_3_28316044[\"εNFA5-3 char[1]"/]
eNFA5_4_32972388[\"εNFA5-4 char{0, ∞}"/]
eNFA5_6_53517805[\"εNFA5-6 regex end"/]
eNFA5_7_61027830[\"εNFA5-7 post-regex start"/]
eNFA5_8_12379565[\"εNFA5-8 post-regex end"/]
eNFA5_5_24230272 -.->|"ε"|eNFA5_0_16745860
eNFA5_5_24230272 -->|"/"|eNFA5_1_16495015
eNFA5_0_16745860 -->|"/"|eNFA5_1_16495015
eNFA5_1_16495015 -.->|"ε"|eNFA5_2_14237410
eNFA5_1_16495015 -->|"/"|eNFA5_3_28316044
eNFA5_2_14237410 -->|"/"|eNFA5_3_28316044
eNFA5_3_28316044 -.->|"ε"|eNFA5_4_32972388
eNFA5_3_28316044 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_32972388
eNFA5_3_28316044 -.->|"ε"|eNFA5_6_53517805
eNFA5_3_28316044 -.->|"ε"|eNFA5_7_61027830
eNFA5_3_28316044 -.->|"ε"|eNFA5_8_12379565
eNFA5_4_32972388 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_32972388
eNFA5_4_32972388 -.->|"ε"|eNFA5_6_53517805
eNFA5_4_32972388 -.->|"ε"|eNFA5_7_61027830
eNFA5_4_32972388 -.->|"ε"|eNFA5_8_12379565
eNFA5_6_53517805 -.->|"ε"|eNFA5_7_61027830
eNFA5_6_53517805 -.->|"ε"|eNFA5_8_12379565
eNFA5_7_61027830 -.->|"ε"|eNFA5_8_12379565
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
NFA5_5_32115247("NFA5-5 regex start")
NFA5_1_20601768("NFA5-1 char[1]")
NFA5_3_63220684[\"NFA5-3 char[1]"/]
NFA5_4_44307222[\"NFA5-4 char{0, ∞}"/]
NFA5_5_32115247 -->|"/"|NFA5_1_20601768
NFA5_1_20601768 -->|"/"|NFA5_3_63220684
NFA5_3_63220684 -->|"[#92;t#92;r#32;-~]"|NFA5_4_44307222
NFA5_4_44307222 -->|"[#92;t#92;r#32;-~]"|NFA5_4_44307222
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
subgraph DFA0_1236099965["DFA0 regex start"]
NFA5_5_32115247_0("NFA5-5 regex start")
end
subgraph DFA1_1443612004["DFA1 {1}"]
NFA5_1_20601768_1("NFA5-1 char[1]")
end
subgraph DFA2_829781499["DFA2 {1}"]
NFA5_3_63220684_2[\"NFA5-3 char[1]"/]
end
subgraph DFA3_1780643038["DFA3 {1}"]
NFA5_4_44307222_3[\"NFA5-4 char{0, ∞}"/]
end
DFA0_1236099965 -->|"/"|DFA1_1443612004
DFA1_1443612004 -->|"/"|DFA2_829781499
DFA2_829781499 -->|"[#92;t#92;r#32;-~]"|DFA3_1780643038
DFA3_1780643038 -->|"[#92;t#92;r#32;-~]"|DFA3_1780643038
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
DFA0_1236099965{{"DFA0 regex start"}}
DFA1_1443612004{{"DFA1 {1}"}}
DFA2_829781499[\"DFA2 {1}"/]
DFA3_1780643038[\"DFA3 {1}"/]
DFA0_1236099965 -->|"/"|DFA1_1443612004
DFA1_1443612004 -->|"/"|DFA2_829781499
DFA2_829781499 -->|"[#92;t#92;r#32;-~]"|DFA3_1780643038
DFA3_1780643038 -->|"[#92;t#92;r#32;-~]"|DFA3_1780643038
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
subgraph MiniDFA0_1735551285["MiniDFA0 {1}"]
DFA0_1236099965_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2102669255["MiniDFA1 {1}"]
DFA1_1443612004_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-285207029["MiniDFA2 {1}"]
DFA2_829781499_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_1645863807["MiniDFA3 {1}"]
DFA3_1780643038_3[\"DFA3 {1}"/]
end
MiniDFA0_1735551285 -->|"/"|MiniDFA1_2102669255
MiniDFA1_2102669255 -->|"/"|MiniDFA2_-285207029
MiniDFA2_-285207029 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1645863807
MiniDFA3_1645863807 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1645863807
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
MiniDFA0_1735551285(["MiniDFA0 {1}"])
MiniDFA1_2102669255(["MiniDFA1 {1}"])
MiniDFA2_-285207029[\"MiniDFA2 {1}"/]
MiniDFA3_1645863807[\"MiniDFA3 {1}"/]
MiniDFA0_1735551285 -->|"/"|MiniDFA1_2102669255
MiniDFA1_2102669255 -->|"/"|MiniDFA2_-285207029
MiniDFA2_-285207029 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1645863807
MiniDFA3_1645863807 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1645863807
```
-------------------------------
