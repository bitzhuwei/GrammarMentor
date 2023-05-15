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
eNFA9_5_29874939[["εNFA9-5 regex start"]]
eNFA9_0_439002[["εNFA9-0 char{1, 1}"]]
eNFA9_1_3951024[["εNFA9-1 char[1]"]]
eNFA9_2_35559222[["εNFA9-2 char{1, 1}"]]
eNFA9_3_21484299[["εNFA9-3 char[1]"]]
eNFA9_4_17300225[["εNFA9-4 char{0, ∞}"]]
eNFA9_6_59140967[["εNFA9-6 regex end"]]
eNFA9_7_33650236[["εNFA9-7 post-regex start"]]
eNFA9_8_34416674[\"εNFA9-8 post-regex end"/]
eNFA9_5_29874939 -.->|"ε"|eNFA9_0_439002
eNFA9_0_439002 -->|"/"|eNFA9_1_3951024
eNFA9_1_3951024 -.->|"ε"|eNFA9_2_35559222
eNFA9_2_35559222 -->|"/"|eNFA9_3_21484299
eNFA9_3_21484299 -.->|"ε"|eNFA9_4_17300225
eNFA9_4_17300225 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_17300225
eNFA9_4_17300225 -.->|"ε"|eNFA9_6_59140967
eNFA9_6_59140967 -.->|"ε"|eNFA9_7_33650236
eNFA9_7_33650236 -.->|"ε"|eNFA9_8_34416674
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
eNFA9_5_41314614[["εNFA9-5 regex start"]]
eNFA9_0_36287209[["εNFA9-0 char{1, 1}"]]
eNFA9_1_58149428[["εNFA9-1 char[1]"]]
eNFA9_2_53582808[["εNFA9-2 char{1, 1}"]]
eNFA9_3_61724767[\"εNFA9-3 char[1]"/]
eNFA9_4_51597550[\"εNFA9-4 char{0, ∞}"/]
eNFA9_6_18651996[\"εNFA9-6 regex end"/]
eNFA9_7_12483231[\"εNFA9-7 post-regex start"/]
eNFA9_8_45240216[\"εNFA9-8 post-regex end"/]
eNFA9_5_41314614 -.->|"ε"|eNFA9_0_36287209
eNFA9_5_41314614 -->|"/"|eNFA9_1_58149428
eNFA9_0_36287209 -->|"/"|eNFA9_1_58149428
eNFA9_1_58149428 -.->|"ε"|eNFA9_2_53582808
eNFA9_1_58149428 -->|"/"|eNFA9_3_61724767
eNFA9_2_53582808 -->|"/"|eNFA9_3_61724767
eNFA9_3_61724767 -.->|"ε"|eNFA9_4_51597550
eNFA9_3_61724767 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_51597550
eNFA9_3_61724767 -.->|"ε"|eNFA9_6_18651996
eNFA9_3_61724767 -.->|"ε"|eNFA9_7_12483231
eNFA9_3_61724767 -.->|"ε"|eNFA9_8_45240216
eNFA9_4_51597550 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_51597550
eNFA9_4_51597550 -.->|"ε"|eNFA9_6_18651996
eNFA9_4_51597550 -.->|"ε"|eNFA9_7_12483231
eNFA9_4_51597550 -.->|"ε"|eNFA9_8_45240216
eNFA9_6_18651996 -.->|"ε"|eNFA9_7_12483231
eNFA9_6_18651996 -.->|"ε"|eNFA9_8_45240216
eNFA9_7_12483231 -.->|"ε"|eNFA9_8_45240216
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
NFA9_5_29665754("NFA9-5 regex start")
NFA9_1_65665194("NFA9-1 char[1]")
NFA9_3_40578897[\"NFA9-3 char[1]"/]
NFA9_4_4508766[\"NFA9-4 char{0, ∞}"/]
NFA9_5_29665754 -->|"/"|NFA9_1_65665194
NFA9_1_65665194 -->|"/"|NFA9_3_40578897
NFA9_3_40578897 -->|"[#92;t#92;r#32;-~]"|NFA9_4_4508766
NFA9_4_4508766 -->|"[#92;t#92;r#32;-~]"|NFA9_4_4508766
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
subgraph DFA0_-363576960["DFA0 regex start"]
NFA9_5_29665754_0("NFA9-5 regex start")
end
subgraph DFA1_-1624161152["DFA1 {1}"]
NFA9_1_65665194_1("NFA9-1 char[1]")
end
subgraph DFA2_124783937["DFA2 {1}"]
NFA9_3_40578897_2[\"NFA9-3 char[1]"/]
end
subgraph DFA3_1596505677["DFA3 {1}"]
NFA9_4_4508766_3[\"NFA9-4 char{0, ∞}"/]
end
DFA0_-363576960 -->|"/"|DFA1_-1624161152
DFA1_-1624161152 -->|"/"|DFA2_124783937
DFA2_124783937 -->|"[#92;t#92;r#32;-~]"|DFA3_1596505677
DFA3_1596505677 -->|"[#92;t#92;r#32;-~]"|DFA3_1596505677
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
DFA0_-363576960{{"DFA0 regex start"}}
DFA1_-1624161152{{"DFA1 {1}"}}
DFA2_124783937[\"DFA2 {1}"/]
DFA3_1596505677[\"DFA3 {1}"/]
DFA0_-363576960 -->|"/"|DFA1_-1624161152
DFA1_-1624161152 -->|"/"|DFA2_124783937
DFA2_124783937 -->|"[#92;t#92;r#32;-~]"|DFA3_1596505677
DFA3_1596505677 -->|"[#92;t#92;r#32;-~]"|DFA3_1596505677
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
subgraph MiniDFA0_-175796263["MiniDFA0 {1}"]
DFA0_-363576960_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1703012157["MiniDFA1 {1}"]
DFA1_-1624161152_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-507712376["MiniDFA2 {1}"]
DFA2_124783937_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-751838913["MiniDFA3 {1}"]
DFA3_1596505677_3[\"DFA3 {1}"/]
end
MiniDFA0_-175796263 -->|"/"|MiniDFA1_1703012157
MiniDFA1_1703012157 -->|"/"|MiniDFA2_-507712376
MiniDFA2_-507712376 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-751838913
MiniDFA3_-751838913 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-751838913
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
MiniDFA0_-175796263(["MiniDFA0 {1}"])
MiniDFA1_1703012157(["MiniDFA1 {1}"])
MiniDFA2_-507712376[\"MiniDFA2 {1}"/]
MiniDFA3_-751838913[\"MiniDFA3 {1}"/]
MiniDFA0_-175796263 -->|"/"|MiniDFA1_1703012157
MiniDFA1_1703012157 -->|"/"|MiniDFA2_-507712376
MiniDFA2_-507712376 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-751838913
MiniDFA3_-751838913 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-751838913
```
-------------------------------
