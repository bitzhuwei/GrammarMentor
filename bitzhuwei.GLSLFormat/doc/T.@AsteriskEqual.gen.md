# '*='

pattern: `\*=`

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
eNFA38_4_63509856[["εNFA38-4 regex start"]]
eNFA38_0_34717793[["εNFA38-0 char{1, 1}"]]
eNFA38_1_44024689[["εNFA38-1 char[1]"]]
eNFA38_2_60677888[["εNFA38-2 char{1, 1}"]]
eNFA38_3_9230088[["εNFA38-3 char[1]"]]
eNFA38_5_15961928[["εNFA38-5 regex end"]]
eNFA38_6_9439626[["εNFA38-6 post-regex start"]]
eNFA38_7_17847776[\"εNFA38-7 post-regex end"/]
eNFA38_4_63509856 -.->|"ε"|eNFA38_0_34717793
eNFA38_0_34717793 -->|"*"|eNFA38_1_44024689
eNFA38_1_44024689 -.->|"ε"|eNFA38_2_60677888
eNFA38_2_60677888 -->|"="|eNFA38_3_9230088
eNFA38_3_9230088 -.->|"ε"|eNFA38_5_15961928
eNFA38_5_15961928 -.->|"ε"|eNFA38_6_9439626
eNFA38_6_9439626 -.->|"ε"|eNFA38_7_17847776
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
eNFA38_4_26412257[["εNFA38-4 regex start"]]
eNFA38_0_36383728[["εNFA38-0 char{1, 1}"]]
eNFA38_1_59018101[["εNFA38-1 char[1]"]]
eNFA38_2_61400865[["εNFA38-2 char{1, 1}"]]
eNFA38_3_15736877[\"εNFA38-3 char[1]"/]
eNFA38_5_7414170[\"εNFA38-5 regex end"/]
eNFA38_6_66727538[\"εNFA38-6 post-regex start"/]
eNFA38_7_63676932[\"εNFA38-7 post-regex end"/]
eNFA38_4_26412257 -.->|"ε"|eNFA38_0_36383728
eNFA38_4_26412257 -->|"*"|eNFA38_1_59018101
eNFA38_0_36383728 -->|"*"|eNFA38_1_59018101
eNFA38_1_59018101 -.->|"ε"|eNFA38_2_61400865
eNFA38_1_59018101 -->|"="|eNFA38_3_15736877
eNFA38_2_61400865 -->|"="|eNFA38_3_15736877
eNFA38_3_15736877 -.->|"ε"|eNFA38_5_7414170
eNFA38_3_15736877 -.->|"ε"|eNFA38_6_66727538
eNFA38_3_15736877 -.->|"ε"|eNFA38_7_63676932
eNFA38_5_7414170 -.->|"ε"|eNFA38_6_66727538
eNFA38_5_7414170 -.->|"ε"|eNFA38_7_63676932
eNFA38_6_66727538 -.->|"ε"|eNFA38_7_63676932
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
NFA38_4_36221483("NFA38-4 regex start")
NFA38_1_57557895("NFA38-1 char[1]")
NFA38_3_48259009[\"NFA38-3 char[1]"/]
NFA38_4_36221483 -->|"*"|NFA38_1_57557895
NFA38_1_57557895 -->|"="|NFA38_3_48259009
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
subgraph DFA0_1230315523["DFA0 regex start"]
NFA38_4_36221483_0("NFA38-4 regex start")
end
subgraph DFA1_41652659["DFA1 {1}"]
NFA38_1_57557895_1("NFA38-1 char[1]")
end
subgraph DFA2_-406370105["DFA2 {1}"]
NFA38_3_48259009_2[\"NFA38-3 char[1]"/]
end
DFA0_1230315523 -->|"*"|DFA1_41652659
DFA1_41652659 -->|"="|DFA2_-406370105
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
DFA0_1230315523{{"DFA0 regex start"}}
DFA1_41652659{{"DFA1 {1}"}}
DFA2_-406370105[\"DFA2 {1}"/]
DFA0_1230315523 -->|"*"|DFA1_41652659
DFA1_41652659 -->|"="|DFA2_-406370105
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
subgraph MiniDFA0_-1318573143["MiniDFA0 {1}"]
DFA0_1230315523_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1353024377["MiniDFA1 {1}"]
DFA1_41652659_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-511659190["MiniDFA2 {1}"]
DFA2_-406370105_2[\"DFA2 {1}"/]
end
MiniDFA0_-1318573143 -->|"*"|MiniDFA1_-1353024377
MiniDFA1_-1353024377 -->|"="|MiniDFA2_-511659190
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
MiniDFA0_-1318573143(["MiniDFA0 {1}"])
MiniDFA1_-1353024377(["MiniDFA1 {1}"])
MiniDFA2_-511659190[\"MiniDFA2 {1}"/]
MiniDFA0_-1318573143 -->|"*"|MiniDFA1_-1353024377
MiniDFA1_-1353024377 -->|"="|MiniDFA2_-511659190
```
-------------------------------
