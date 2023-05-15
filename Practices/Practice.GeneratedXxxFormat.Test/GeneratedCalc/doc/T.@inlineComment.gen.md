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
eNFA9_5_36468595[["εNFA9-5 regex start"]]
eNFA9_0_59781901[["εNFA9-0 char{1, 1}"]]
eNFA9_1_1166200[["εNFA9-1 char[1]"]]
eNFA9_2_10495806[["εNFA9-2 char{1, 1}"]]
eNFA9_3_34322009[["εNFA9-3 char[1]"]]
eNFA9_4_33639718[["εNFA9-4 char{0, ∞}"]]
eNFA9_6_40462633[["εNFA9-6 regex end"]]
eNFA9_7_9289124[["εNFA9-7 post-regex start"]]
eNFA9_8_16493259[\"εNFA9-8 post-regex end"/]
eNFA9_5_36468595 -.->|"ε"|eNFA9_0_59781901
eNFA9_0_59781901 -->|"/"|eNFA9_1_1166200
eNFA9_1_1166200 -.->|"ε"|eNFA9_2_10495806
eNFA9_2_10495806 -->|"/"|eNFA9_3_34322009
eNFA9_3_34322009 -.->|"ε"|eNFA9_4_33639718
eNFA9_4_33639718 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_33639718
eNFA9_4_33639718 -.->|"ε"|eNFA9_6_40462633
eNFA9_6_40462633 -.->|"ε"|eNFA9_7_9289124
eNFA9_7_9289124 -.->|"ε"|eNFA9_8_16493259
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
eNFA9_5_14221611[["εNFA9-5 regex start"]]
eNFA9_0_60885635[["εNFA9-0 char{1, 1}"]]
eNFA9_1_11099805[["εNFA9-1 char[1]"]]
eNFA9_2_32789387[["εNFA9-2 char{1, 1}"]]
eNFA9_3_44853923[\"εNFA9-3 char[1]"/]
eNFA9_4_27353390[\"εNFA9-4 char{0, ∞}"/]
eNFA9_6_1032124[\"εNFA9-6 regex end"/]
eNFA9_7_26669028[\"εNFA9-7 post-regex start"/]
eNFA9_8_38694667[\"εNFA9-8 post-regex end"/]
eNFA9_5_14221611 -.->|"ε"|eNFA9_0_60885635
eNFA9_5_14221611 -->|"/"|eNFA9_1_11099805
eNFA9_0_60885635 -->|"/"|eNFA9_1_11099805
eNFA9_1_11099805 -.->|"ε"|eNFA9_2_32789387
eNFA9_1_11099805 -->|"/"|eNFA9_3_44853923
eNFA9_2_32789387 -->|"/"|eNFA9_3_44853923
eNFA9_3_44853923 -.->|"ε"|eNFA9_4_27353390
eNFA9_3_44853923 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_27353390
eNFA9_3_44853923 -.->|"ε"|eNFA9_6_1032124
eNFA9_3_44853923 -.->|"ε"|eNFA9_7_26669028
eNFA9_3_44853923 -.->|"ε"|eNFA9_8_38694667
eNFA9_4_27353390 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_27353390
eNFA9_4_27353390 -.->|"ε"|eNFA9_6_1032124
eNFA9_4_27353390 -.->|"ε"|eNFA9_7_26669028
eNFA9_4_27353390 -.->|"ε"|eNFA9_8_38694667
eNFA9_6_1032124 -.->|"ε"|eNFA9_7_26669028
eNFA9_6_1032124 -.->|"ε"|eNFA9_8_38694667
eNFA9_7_26669028 -.->|"ε"|eNFA9_8_38694667
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
NFA9_5_22689808("NFA9-5 regex start")
NFA9_1_2881685("NFA9-1 char[1]")
NFA9_3_47260332[\"NFA9-3 char[1]"/]
NFA9_4_12707688[\"NFA9-4 char{0, ∞}"/]
NFA9_5_22689808 -->|"/"|NFA9_1_2881685
NFA9_1_2881685 -->|"/"|NFA9_3_47260332
NFA9_3_47260332 -->|"[#92;t#92;r#32;-~]"|NFA9_4_12707688
NFA9_4_12707688 -->|"[#92;t#92;r#32;-~]"|NFA9_4_12707688
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
subgraph DFA0_1978056286["DFA0 regex start"]
NFA9_5_22689808_0("NFA9-5 regex start")
end
subgraph DFA1_-2122535992["DFA1 {1}"]
NFA9_1_2881685_1("NFA9-1 char[1]")
end
subgraph DFA2_-1729133373["DFA2 {1}"]
NFA9_3_47260332_2[\"NFA9-3 char[1]"/]
end
subgraph DFA3_1818924723["DFA3 {1}"]
NFA9_4_12707688_3[\"NFA9-4 char{0, ∞}"/]
end
DFA0_1978056286 -->|"/"|DFA1_-2122535992
DFA1_-2122535992 -->|"/"|DFA2_-1729133373
DFA2_-1729133373 -->|"[#92;t#92;r#32;-~]"|DFA3_1818924723
DFA3_1818924723 -->|"[#92;t#92;r#32;-~]"|DFA3_1818924723
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
DFA0_1978056286{{"DFA0 regex start"}}
DFA1_-2122535992{{"DFA1 {1}"}}
DFA2_-1729133373[\"DFA2 {1}"/]
DFA3_1818924723[\"DFA3 {1}"/]
DFA0_1978056286 -->|"/"|DFA1_-2122535992
DFA1_-2122535992 -->|"/"|DFA2_-1729133373
DFA2_-1729133373 -->|"[#92;t#92;r#32;-~]"|DFA3_1818924723
DFA3_1818924723 -->|"[#92;t#92;r#32;-~]"|DFA3_1818924723
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
subgraph MiniDFA0_-633143272["MiniDFA0 {1}"]
DFA0_1978056286_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-906285153["MiniDFA1 {1}"]
DFA1_-2122535992_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1012330525["MiniDFA2 {1}"]
DFA2_-1729133373_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-919064930["MiniDFA3 {1}"]
DFA3_1818924723_3[\"DFA3 {1}"/]
end
MiniDFA0_-633143272 -->|"/"|MiniDFA1_-906285153
MiniDFA1_-906285153 -->|"/"|MiniDFA2_1012330525
MiniDFA2_1012330525 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-919064930
MiniDFA3_-919064930 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-919064930
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
MiniDFA0_-633143272(["MiniDFA0 {1}"])
MiniDFA1_-906285153(["MiniDFA1 {1}"])
MiniDFA2_1012330525[\"MiniDFA2 {1}"/]
MiniDFA3_-919064930[\"MiniDFA3 {1}"/]
MiniDFA0_-633143272 -->|"/"|MiniDFA1_-906285153
MiniDFA1_-906285153 -->|"/"|MiniDFA2_1012330525
MiniDFA2_1012330525 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-919064930
MiniDFA3_-919064930 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-919064930
```
-------------------------------
