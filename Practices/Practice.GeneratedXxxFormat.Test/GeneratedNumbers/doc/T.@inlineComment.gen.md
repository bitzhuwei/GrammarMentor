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
eNFA4_5_45081147[["εNFA4-5 regex start"]]
eNFA4_0_3077144[["εNFA4-0 char{1, 1}"]]
eNFA4_1_27694303[["εNFA4-1 char[1]"]]
eNFA4_2_47922135[["εNFA4-2 char{1, 1}"]]
eNFA4_3_15155206[["εNFA4-3 char[1]"]]
eNFA4_4_1683911[["εNFA4-4 char{0, ∞}"]]
eNFA4_6_2179128[["εNFA4-6 regex end"]]
eNFA4_7_12102778[["εNFA4-7 post-regex start"]]
eNFA4_8_41816140[\"εNFA4-8 post-regex end"/]
eNFA4_5_45081147 -.->|"ε"|eNFA4_0_3077144
eNFA4_0_3077144 -->|"/"|eNFA4_1_27694303
eNFA4_1_27694303 -.->|"ε"|eNFA4_2_47922135
eNFA4_2_47922135 -->|"/"|eNFA4_3_15155206
eNFA4_3_15155206 -.->|"ε"|eNFA4_4_1683911
eNFA4_4_1683911 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_1683911
eNFA4_4_1683911 -.->|"ε"|eNFA4_6_2179128
eNFA4_6_2179128 -.->|"ε"|eNFA4_7_12102778
eNFA4_7_12102778 -.->|"ε"|eNFA4_8_41816140
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
eNFA4_5_40800942[["εNFA4-5 regex start"]]
eNFA4_0_31664161[["εNFA4-0 char{1, 1}"]]
eNFA4_1_16541999[["εNFA4-1 char[1]"]]
eNFA4_2_14660263[["εNFA4-2 char{1, 1}"]]
eNFA4_3_56487722[\"εNFA4-3 char[1]"/]
eNFA4_4_28646034[\"εNFA4-4 char{0, ∞}"/]
eNFA4_6_38627455[\"εNFA4-6 regex end"/]
eNFA4_7_64833508[\"εNFA4-7 post-regex start"/]
eNFA4_8_46630661[\"εNFA4-8 post-regex end"/]
eNFA4_5_40800942 -.->|"ε"|eNFA4_0_31664161
eNFA4_5_40800942 -->|"/"|eNFA4_1_16541999
eNFA4_0_31664161 -->|"/"|eNFA4_1_16541999
eNFA4_1_16541999 -.->|"ε"|eNFA4_2_14660263
eNFA4_1_16541999 -->|"/"|eNFA4_3_56487722
eNFA4_2_14660263 -->|"/"|eNFA4_3_56487722
eNFA4_3_56487722 -.->|"ε"|eNFA4_4_28646034
eNFA4_3_56487722 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_28646034
eNFA4_3_56487722 -.->|"ε"|eNFA4_6_38627455
eNFA4_3_56487722 -.->|"ε"|eNFA4_7_64833508
eNFA4_3_56487722 -.->|"ε"|eNFA4_8_46630661
eNFA4_4_28646034 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_28646034
eNFA4_4_28646034 -.->|"ε"|eNFA4_6_38627455
eNFA4_4_28646034 -.->|"ε"|eNFA4_7_64833508
eNFA4_4_28646034 -.->|"ε"|eNFA4_8_46630661
eNFA4_6_38627455 -.->|"ε"|eNFA4_7_64833508
eNFA4_6_38627455 -.->|"ε"|eNFA4_8_46630661
eNFA4_7_64833508 -.->|"ε"|eNFA4_8_46630661
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
NFA4_5_36667404("NFA4-5 regex start")
NFA4_1_61571180("NFA4-1 char[1]")
NFA4_3_18987236[\"NFA4-3 char[1]"/]
NFA4_4_17022773[\"NFA4-4 char{0, ∞}"/]
NFA4_5_36667404 -->|"/"|NFA4_1_61571180
NFA4_1_61571180 -->|"/"|NFA4_3_18987236
NFA4_3_18987236 -->|"[#92;t#92;r#32;-~]"|NFA4_4_17022773
NFA4_4_17022773 -->|"[#92;t#92;r#32;-~]"|NFA4_4_17022773
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
subgraph DFA0_-819708741["DFA0 regex start"]
NFA4_5_36667404_0("NFA4-5 regex start")
end
subgraph DFA1_-344864794["DFA1 {1}"]
NFA4_1_61571180_1("NFA4-1 char[1]")
end
subgraph DFA2_-453504112["DFA2 {1}"]
NFA4_3_18987236_2[\"NFA4-3 char[1]"/]
end
subgraph DFA3_-2121018758["DFA3 {1}"]
NFA4_4_17022773_3[\"NFA4-4 char{0, ∞}"/]
end
DFA0_-819708741 -->|"/"|DFA1_-344864794
DFA1_-344864794 -->|"/"|DFA2_-453504112
DFA2_-453504112 -->|"[#92;t#92;r#32;-~]"|DFA3_-2121018758
DFA3_-2121018758 -->|"[#92;t#92;r#32;-~]"|DFA3_-2121018758
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
DFA0_-819708741{{"DFA0 regex start"}}
DFA1_-344864794{{"DFA1 {1}"}}
DFA2_-453504112[\"DFA2 {1}"/]
DFA3_-2121018758[\"DFA3 {1}"/]
DFA0_-819708741 -->|"/"|DFA1_-344864794
DFA1_-344864794 -->|"/"|DFA2_-453504112
DFA2_-453504112 -->|"[#92;t#92;r#32;-~]"|DFA3_-2121018758
DFA3_-2121018758 -->|"[#92;t#92;r#32;-~]"|DFA3_-2121018758
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
subgraph MiniDFA0_-888768850["MiniDFA0 {1}"]
DFA0_-819708741_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_816905712["MiniDFA1 {1}"]
DFA1_-344864794_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-913967946["MiniDFA2 {1}"]
DFA2_-453504112_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_1039134852["MiniDFA3 {1}"]
DFA3_-2121018758_3[\"DFA3 {1}"/]
end
MiniDFA0_-888768850 -->|"/"|MiniDFA1_816905712
MiniDFA1_816905712 -->|"/"|MiniDFA2_-913967946
MiniDFA2_-913967946 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1039134852
MiniDFA3_1039134852 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1039134852
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
MiniDFA0_-888768850(["MiniDFA0 {1}"])
MiniDFA1_816905712(["MiniDFA1 {1}"])
MiniDFA2_-913967946[\"MiniDFA2 {1}"/]
MiniDFA3_1039134852[\"MiniDFA3 {1}"/]
MiniDFA0_-888768850 -->|"/"|MiniDFA1_816905712
MiniDFA1_816905712 -->|"/"|MiniDFA2_-913967946
MiniDFA2_-913967946 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1039134852
MiniDFA3_1039134852 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1039134852
```
-------------------------------
