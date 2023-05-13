# 'if'

pattern: `if`

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
eNFA197_4_28127241[["εNFA197-4 regex start"]]
eNFA197_0_51818579[["εNFA197-0 char{1, 1}"]]
eNFA197_1_63714035[["εNFA197-1 char[1]"]]
eNFA197_2_36555409[["εNFA197-2 char{1, 1}"]]
eNFA197_3_60563230[["εNFA197-3 char[1]"]]
eNFA197_5_8198163[["εNFA197-5 regex end"]]
eNFA197_6_6674610[["εNFA197-6 post-regex start"]]
eNFA197_7_60071490[\"εNFA197-7 post-regex end"/]
eNFA197_4_28127241 -.->|"ε"|eNFA197_0_51818579
eNFA197_0_51818579 -->|"i"|eNFA197_1_63714035
eNFA197_1_63714035 -.->|"ε"|eNFA197_2_36555409
eNFA197_2_36555409 -->|"f"|eNFA197_3_60563230
eNFA197_3_60563230 -.->|"ε"|eNFA197_5_8198163
eNFA197_5_8198163 -.->|"ε"|eNFA197_6_6674610
eNFA197_6_6674610 -.->|"ε"|eNFA197_7_60071490
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
eNFA197_4_3772501[["εNFA197-4 regex start"]]
eNFA197_0_33952517[["εNFA197-0 char{1, 1}"]]
eNFA197_1_37137202[["εNFA197-1 char[1]"]]
eNFA197_2_65799365[["εNFA197-2 char{1, 1}"]]
eNFA197_3_55323375[\"εNFA197-3 char[1]"/]
eNFA197_5_28148329[\"εNFA197-5 regex end"/]
eNFA197_6_52008372[\"εNFA197-6 post-regex start"/]
eNFA197_7_65422170[\"εNFA197-7 post-regex end"/]
eNFA197_4_3772501 -.->|"ε"|eNFA197_0_33952517
eNFA197_4_3772501 -->|"i"|eNFA197_1_37137202
eNFA197_0_33952517 -->|"i"|eNFA197_1_37137202
eNFA197_1_37137202 -.->|"ε"|eNFA197_2_65799365
eNFA197_1_37137202 -->|"f"|eNFA197_3_55323375
eNFA197_2_65799365 -->|"f"|eNFA197_3_55323375
eNFA197_3_55323375 -.->|"ε"|eNFA197_5_28148329
eNFA197_3_55323375 -.->|"ε"|eNFA197_6_52008372
eNFA197_3_55323375 -.->|"ε"|eNFA197_7_65422170
eNFA197_5_28148329 -.->|"ε"|eNFA197_6_52008372
eNFA197_5_28148329 -.->|"ε"|eNFA197_7_65422170
eNFA197_6_52008372 -.->|"ε"|eNFA197_7_65422170
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
NFA197_4_51928618("NFA197-4 regex start")
NFA197_1_64704383("NFA197-1 char[1]")
NFA197_3_45468536[\"NFA197-3 char[1]"/]
NFA197_4_51928618 -->|"i"|NFA197_1_64704383
NFA197_1_64704383 -->|"f"|NFA197_3_45468536
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
subgraph DFA0_-1848102703["DFA0 regex start"]
NFA197_4_51928618_0("NFA197-4 regex start")
end
subgraph DFA1_40500509["DFA1 {1}"]
NFA197_1_64704383_1("NFA197-1 char[1]")
end
subgraph DFA2_719009491["DFA2 {1}"]
NFA197_3_45468536_2[\"NFA197-3 char[1]"/]
end
DFA0_-1848102703 -->|"i"|DFA1_40500509
DFA1_40500509 -->|"f"|DFA2_719009491
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
DFA0_-1848102703{{"DFA0 regex start"}}
DFA1_40500509{{"DFA1 {1}"}}
DFA2_719009491[\"DFA2 {1}"/]
DFA0_-1848102703 -->|"i"|DFA1_40500509
DFA1_40500509 -->|"f"|DFA2_719009491
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
subgraph MiniDFA0_479646293["MiniDFA0 {1}"]
DFA0_-1848102703_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_542603503["MiniDFA1 {1}"]
DFA1_40500509_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1985051538["MiniDFA2 {1}"]
DFA2_719009491_2[\"DFA2 {1}"/]
end
MiniDFA0_479646293 -->|"i"|MiniDFA1_542603503
MiniDFA1_542603503 -->|"f"|MiniDFA2_1985051538
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
MiniDFA0_479646293(["MiniDFA0 {1}"])
MiniDFA1_542603503(["MiniDFA1 {1}"])
MiniDFA2_1985051538[\"MiniDFA2 {1}"/]
MiniDFA0_479646293 -->|"i"|MiniDFA1_542603503
MiniDFA1_542603503 -->|"f"|MiniDFA2_1985051538
```
-------------------------------
