# 'entityId'

pattern: `[0-9]+/=`

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
eNFA1_2_1896157[["εNFA1-2 regex start"]]
eNFA1_0_65583313[["εNFA1-0 scope{1, ∞}"]]
eNFA1_1_66939358[["εNFA1-1 scope[1]"]]
eNFA1_3_53378906[["εNFA1-3 regex end"]]
eNFA1_6_25548402[["εNFA1-6 regex start"]]
eNFA1_4_28609031[["εNFA1-4 char{1, 1}"]]
eNFA1_5_56154694[["εNFA1-5 char[1]"]]
eNFA1_7_35630198[\"εNFA1-7 regex end"/]
eNFA1_2_1896157 -.->|"ε"|eNFA1_0_65583313
eNFA1_0_65583313 -->|"[0-9]"|eNFA1_1_66939358
eNFA1_1_66939358 -->|"[0-9]"|eNFA1_1_66939358
eNFA1_1_66939358 -.->|"ε"|eNFA1_3_53378906
eNFA1_3_53378906 -.->|"ε"|eNFA1_6_25548402
eNFA1_6_25548402 -.->|"ε"|eNFA1_4_28609031
eNFA1_4_28609031 -->|"="|eNFA1_5_56154694
eNFA1_5_56154694 -.->|"ε"|eNFA1_7_35630198
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
eNFA1_2_52236329[["εNFA1-2 regex start"]]
eNFA1_0_19371015[["εNFA1-0 scope{1, ∞}"]]
eNFA1_1_17065415[["εNFA1-1 scope[1]"]]
eNFA1_3_40121413[["εNFA1-3 regex end"]]
eNFA1_6_364921[["εNFA1-6 regex start"]]
eNFA1_4_3284294[["εNFA1-4 char{1, 1}"]]
eNFA1_5_29558649[\"εNFA1-5 char[1]"/]
eNFA1_7_64701251[\"εNFA1-7 regex end"/]
eNFA1_2_52236329 -.->|"ε"|eNFA1_0_19371015
eNFA1_2_52236329 -->|"[0-9]"|eNFA1_1_17065415
eNFA1_0_19371015 -->|"[0-9]"|eNFA1_1_17065415
eNFA1_1_17065415 -->|"[0-9]"|eNFA1_1_17065415
eNFA1_1_17065415 -.->|"ε"|eNFA1_3_40121413
eNFA1_1_17065415 -.->|"ε"|eNFA1_6_364921
eNFA1_1_17065415 -.->|"ε"|eNFA1_4_3284294
eNFA1_1_17065415 -->|"="|eNFA1_5_29558649
eNFA1_3_40121413 -.->|"ε"|eNFA1_6_364921
eNFA1_3_40121413 -.->|"ε"|eNFA1_4_3284294
eNFA1_3_40121413 -->|"="|eNFA1_5_29558649
eNFA1_6_364921 -.->|"ε"|eNFA1_4_3284294
eNFA1_6_364921 -->|"="|eNFA1_5_29558649
eNFA1_4_3284294 -->|"="|eNFA1_5_29558649
eNFA1_5_29558649 -.->|"ε"|eNFA1_7_64701251
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
NFA1_2_6309960("NFA1-2 regex start")
NFA1_1_45440349("NFA1-1 scope[1]")
NFA1_5_56789646[\"NFA1-5 char[1]"/]
NFA1_2_6309960 -->|"[0-9]"|NFA1_1_45440349
NFA1_1_45440349 -->|"[0-9]"|NFA1_1_45440349
NFA1_1_45440349 -->|"="|NFA1_5_56789646
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
subgraph DFA0_1214142285["DFA0 regex start"]
NFA1_2_6309960_0("NFA1-2 regex start")
end
subgraph DFA1_1116277864["DFA1 {1}"]
NFA1_1_45440349_1("NFA1-1 scope[1]")
end
subgraph DFA2_428236510["DFA2 {1}"]
NFA1_5_56789646_2[\"NFA1-5 char[1]"/]
end
DFA0_1214142285 -->|"[0-9]"|DFA1_1116277864
DFA1_1116277864 -->|"[0-9]"|DFA1_1116277864
DFA1_1116277864 -->|"="|DFA2_428236510
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
DFA0_1214142285{{"DFA0 regex start"}}
DFA1_1116277864{{"DFA1 {1}"}}
DFA2_428236510[\"DFA2 {1}"/]
DFA0_1214142285 -->|"[0-9]"|DFA1_1116277864
DFA1_1116277864 -->|"[0-9]"|DFA1_1116277864
DFA1_1116277864 -->|"="|DFA2_428236510
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
subgraph MiniDFA0_774925984["MiniDFA0 {1}"]
DFA0_1214142285_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-90615061["MiniDFA1 {1}"]
DFA1_1116277864_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1934444451["MiniDFA2 {1}"]
DFA2_428236510_2[\"DFA2 {1}"/]
end
MiniDFA0_774925984 -->|"[0-9]"|MiniDFA1_-90615061
MiniDFA1_-90615061 -->|"[0-9]"|MiniDFA1_-90615061
MiniDFA1_-90615061 -->|"="|MiniDFA2_1934444451
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
MiniDFA0_774925984(["MiniDFA0 {1}"])
MiniDFA1_-90615061(["MiniDFA1 {1}"])
MiniDFA2_1934444451[\"MiniDFA2 {1}"/]
MiniDFA0_774925984 -->|"[0-9]"|MiniDFA1_-90615061
MiniDFA1_-90615061 -->|"[0-9]"|MiniDFA1_-90615061
MiniDFA1_-90615061 -->|"="|MiniDFA2_1934444451
```
-------------------------------
