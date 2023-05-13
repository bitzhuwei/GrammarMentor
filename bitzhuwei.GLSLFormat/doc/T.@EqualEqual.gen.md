# '=='

pattern: `==`

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
eNFA27_4_6250253[["εNFA27-4 regex start"]]
eNFA27_0_56252285[["εNFA27-0 char{1, 1}"]]
eNFA27_1_36508524[["εNFA27-1 char[1]"]]
eNFA27_2_60141268[["εNFA27-2 char{1, 1}"]]
eNFA27_3_4400500[["εNFA27-3 char[1]"]]
eNFA27_5_39604502[["εNFA27-5 regex end"]]
eNFA27_6_20896204[["εNFA27-6 post-regex start"]]
eNFA27_7_53848109[\"εNFA27-7 post-regex end"/]
eNFA27_4_6250253 -.->|"ε"|eNFA27_0_56252285
eNFA27_0_56252285 -->|"="|eNFA27_1_36508524
eNFA27_1_36508524 -.->|"ε"|eNFA27_2_60141268
eNFA27_2_60141268 -->|"="|eNFA27_3_4400500
eNFA27_3_4400500 -.->|"ε"|eNFA27_5_39604502
eNFA27_5_39604502 -.->|"ε"|eNFA27_6_20896204
eNFA27_6_20896204 -.->|"ε"|eNFA27_7_53848109
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
eNFA27_4_14870940[["εNFA27-4 regex start"]]
eNFA27_0_66729601[["εNFA27-0 char{1, 1}"]]
eNFA27_1_63695501[["εNFA27-1 char[1]"]]
eNFA27_2_36388601[["εNFA27-2 char{1, 1}"]]
eNFA27_3_59061958[\"εNFA27-3 char[1]"/]
eNFA27_5_61795582[\"εNFA27-5 regex end"/]
eNFA27_6_19289328[\"εNFA27-6 post-regex start"/]
eNFA27_7_39386231[\"εNFA27-7 post-regex end"/]
eNFA27_4_14870940 -.->|"ε"|eNFA27_0_66729601
eNFA27_4_14870940 -->|"="|eNFA27_1_63695501
eNFA27_0_66729601 -->|"="|eNFA27_1_63695501
eNFA27_1_63695501 -.->|"ε"|eNFA27_2_36388601
eNFA27_1_63695501 -->|"="|eNFA27_3_59061958
eNFA27_2_36388601 -->|"="|eNFA27_3_59061958
eNFA27_3_59061958 -.->|"ε"|eNFA27_5_61795582
eNFA27_3_59061958 -.->|"ε"|eNFA27_6_19289328
eNFA27_3_59061958 -.->|"ε"|eNFA27_7_39386231
eNFA27_5_61795582 -.->|"ε"|eNFA27_6_19289328
eNFA27_5_61795582 -.->|"ε"|eNFA27_7_39386231
eNFA27_6_19289328 -.->|"ε"|eNFA27_7_39386231
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
NFA27_4_18931763("NFA27-4 regex start")
NFA27_1_36168141("NFA27-1 char[1]")
NFA27_3_57077814[\"NFA27-3 char[1]"/]
NFA27_4_18931763 -->|"="|NFA27_1_36168141
NFA27_1_36168141 -->|"="|NFA27_3_57077814
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
subgraph DFA0_937088678["DFA0 regex start"]
NFA27_4_18931763_0("NFA27-4 regex start")
end
subgraph DFA1_-323538627["DFA1 {1}"]
NFA27_1_36168141_1("NFA27-1 char[1]")
end
subgraph DFA2_-1047139092["DFA2 {1}"]
NFA27_3_57077814_2[\"NFA27-3 char[1]"/]
end
DFA0_937088678 -->|"="|DFA1_-323538627
DFA1_-323538627 -->|"="|DFA2_-1047139092
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
DFA0_937088678{{"DFA0 regex start"}}
DFA1_-323538627{{"DFA1 {1}"}}
DFA2_-1047139092[\"DFA2 {1}"/]
DFA0_937088678 -->|"="|DFA1_-323538627
DFA1_-323538627 -->|"="|DFA2_-1047139092
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
subgraph MiniDFA0_-389493409["MiniDFA0 {1}"]
DFA0_937088678_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_739338477["MiniDFA1 {1}"]
DFA1_-323538627_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1354576102["MiniDFA2 {1}"]
DFA2_-1047139092_2[\"DFA2 {1}"/]
end
MiniDFA0_-389493409 -->|"="|MiniDFA1_739338477
MiniDFA1_739338477 -->|"="|MiniDFA2_-1354576102
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
MiniDFA0_-389493409(["MiniDFA0 {1}"])
MiniDFA1_739338477(["MiniDFA1 {1}"])
MiniDFA2_-1354576102[\"MiniDFA2 {1}"/]
MiniDFA0_-389493409 -->|"="|MiniDFA1_739338477
MiniDFA1_739338477 -->|"="|MiniDFA2_-1354576102
```
-------------------------------
