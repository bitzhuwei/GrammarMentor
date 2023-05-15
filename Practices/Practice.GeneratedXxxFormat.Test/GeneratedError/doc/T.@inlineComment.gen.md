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
eNFA3_5_27806533[["εNFA3-5 regex start"]]
eNFA3_0_48932206[["εNFA3-0 char{1, 1}"]]
eNFA3_1_37736673[["εNFA3-1 char[1]"]]
eNFA3_2_4085744[["εNFA3-2 char{1, 1}"]]
eNFA3_3_8340425[["εNFA3-3 char[1]"]]
eNFA3_4_30752875[["εNFA3-4 char{0, ∞}"]]
eNFA3_6_7954964[["εNFA3-6 regex end"]]
eNFA3_7_30131813[["εNFA3-7 post-regex start"]]
eNFA3_8_2750866[\"εNFA3-8 post-regex end"/]
eNFA3_5_27806533 -.->|"ε"|eNFA3_0_48932206
eNFA3_0_48932206 -->|"/"|eNFA3_1_37736673
eNFA3_1_37736673 -.->|"ε"|eNFA3_2_4085744
eNFA3_2_4085744 -->|"/"|eNFA3_3_8340425
eNFA3_3_8340425 -.->|"ε"|eNFA3_4_30752875
eNFA3_4_30752875 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_30752875
eNFA3_4_30752875 -.->|"ε"|eNFA3_6_7954964
eNFA3_6_7954964 -.->|"ε"|eNFA3_7_30131813
eNFA3_7_30131813 -.->|"ε"|eNFA3_8_2750866
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
eNFA3_5_24757801[["εNFA3-5 regex start"]]
eNFA3_0_21493617[["εNFA3-0 char{1, 1}"]]
eNFA3_1_59224828[["εNFA3-1 char[1]"]]
eNFA3_2_63261412[["εNFA3-2 char{1, 1}"]]
eNFA3_3_62509834[\"εNFA3-3 char[1]"/]
eNFA3_4_36771698[\"εNFA3-4 char{0, ∞}"/]
eNFA3_6_25717600[\"εNFA3-6 regex end"/]
eNFA3_7_32481801[\"εNFA3-7 post-regex start"/]
eNFA3_8_23900756[\"εNFA3-8 post-regex end"/]
eNFA3_5_24757801 -.->|"ε"|eNFA3_0_21493617
eNFA3_5_24757801 -->|"/"|eNFA3_1_59224828
eNFA3_0_21493617 -->|"/"|eNFA3_1_59224828
eNFA3_1_59224828 -.->|"ε"|eNFA3_2_63261412
eNFA3_1_59224828 -->|"/"|eNFA3_3_62509834
eNFA3_2_63261412 -->|"/"|eNFA3_3_62509834
eNFA3_3_62509834 -.->|"ε"|eNFA3_4_36771698
eNFA3_3_62509834 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_36771698
eNFA3_3_62509834 -.->|"ε"|eNFA3_6_25717600
eNFA3_3_62509834 -.->|"ε"|eNFA3_7_32481801
eNFA3_3_62509834 -.->|"ε"|eNFA3_8_23900756
eNFA3_4_36771698 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_36771698
eNFA3_4_36771698 -.->|"ε"|eNFA3_6_25717600
eNFA3_4_36771698 -.->|"ε"|eNFA3_7_32481801
eNFA3_4_36771698 -.->|"ε"|eNFA3_8_23900756
eNFA3_6_25717600 -.->|"ε"|eNFA3_7_32481801
eNFA3_6_25717600 -.->|"ε"|eNFA3_8_23900756
eNFA3_7_32481801 -.->|"ε"|eNFA3_8_23900756
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
NFA3_5_42455531("NFA3-5 regex start")
NFA3_1_46555465("NFA3-1 char[1]")
NFA3_3_56913064[\"NFA3-3 char[1]"/]
NFA3_4_13780214[\"NFA3-4 char{0, ∞}"/]
NFA3_5_42455531 -->|"/"|NFA3_1_46555465
NFA3_1_46555465 -->|"/"|NFA3_3_56913064
NFA3_3_56913064 -->|"[#92;t#92;r#32;-~]"|NFA3_4_13780214
NFA3_4_13780214 -->|"[#92;t#92;r#32;-~]"|NFA3_4_13780214
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
subgraph DFA0_-1955312960["DFA0 regex start"]
NFA3_5_42455531_0("NFA3-5 regex start")
end
subgraph DFA1_273561241["DFA1 {1}"]
NFA3_1_46555465_1("NFA3-1 char[1]")
end
subgraph DFA2_-1378937119["DFA2 {1}"]
NFA3_3_56913064_2[\"NFA3-3 char[1]"/]
end
subgraph DFA3_2085931541["DFA3 {1}"]
NFA3_4_13780214_3[\"NFA3-4 char{0, ∞}"/]
end
DFA0_-1955312960 -->|"/"|DFA1_273561241
DFA1_273561241 -->|"/"|DFA2_-1378937119
DFA2_-1378937119 -->|"[#92;t#92;r#32;-~]"|DFA3_2085931541
DFA3_2085931541 -->|"[#92;t#92;r#32;-~]"|DFA3_2085931541
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
DFA0_-1955312960{{"DFA0 regex start"}}
DFA1_273561241{{"DFA1 {1}"}}
DFA2_-1378937119[\"DFA2 {1}"/]
DFA3_2085931541[\"DFA3 {1}"/]
DFA0_-1955312960 -->|"/"|DFA1_273561241
DFA1_273561241 -->|"/"|DFA2_-1378937119
DFA2_-1378937119 -->|"[#92;t#92;r#32;-~]"|DFA3_2085931541
DFA3_2085931541 -->|"[#92;t#92;r#32;-~]"|DFA3_2085931541
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
subgraph MiniDFA0_152815922["MiniDFA0 {1}"]
DFA0_-1955312960_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2023897004["MiniDFA1 {1}"]
DFA1_273561241_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_600637182["MiniDFA2 {1}"]
DFA2_-1378937119_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_1771604059["MiniDFA3 {1}"]
DFA3_2085931541_3[\"DFA3 {1}"/]
end
MiniDFA0_152815922 -->|"/"|MiniDFA1_2023897004
MiniDFA1_2023897004 -->|"/"|MiniDFA2_600637182
MiniDFA2_600637182 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1771604059
MiniDFA3_1771604059 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1771604059
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
MiniDFA0_152815922(["MiniDFA0 {1}"])
MiniDFA1_2023897004(["MiniDFA1 {1}"])
MiniDFA2_600637182[\"MiniDFA2 {1}"/]
MiniDFA3_1771604059[\"MiniDFA3 {1}"/]
MiniDFA0_152815922 -->|"/"|MiniDFA1_2023897004
MiniDFA1_2023897004 -->|"/"|MiniDFA2_600637182
MiniDFA2_600637182 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1771604059
MiniDFA3_1771604059 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1771604059
```
-------------------------------
