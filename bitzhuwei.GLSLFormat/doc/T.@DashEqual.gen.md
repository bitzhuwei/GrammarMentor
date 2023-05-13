# '-='

pattern: `\-=`

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
eNFA42_4_6296289[["εNFA42-4 regex start"]]
eNFA42_0_56666602[["εNFA42-0 char{1, 1}"]]
eNFA42_1_40237373[["εNFA42-1 char[1]"]]
eNFA42_2_26592044[["εNFA42-2 char{1, 1}"]]
eNFA42_3_38001806[["εNFA42-3 char[1]"]]
eNFA42_5_6471942[["εNFA42-5 regex end"]]
eNFA42_6_58247484[["εNFA42-6 post-regex start"]]
eNFA42_7_54465313[\"εNFA42-7 post-regex end"/]
eNFA42_4_6296289 -.->|"ε"|eNFA42_0_56666602
eNFA42_0_56666602 -->|"-"|eNFA42_1_40237373
eNFA42_1_40237373 -.->|"ε"|eNFA42_2_26592044
eNFA42_2_26592044 -->|"="|eNFA42_3_38001806
eNFA42_3_38001806 -.->|"ε"|eNFA42_5_6471942
eNFA42_5_6471942 -.->|"ε"|eNFA42_6_58247484
eNFA42_6_58247484 -.->|"ε"|eNFA42_7_54465313
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
eNFA42_4_20425774[["εNFA42-4 regex start"]]
eNFA42_0_49614245[["εNFA42-0 char{1, 1}"]]
eNFA42_1_43875021[["εNFA42-1 char[1]"]]
eNFA42_2_59330872[["εNFA42-2 char{1, 1}"]]
eNFA42_3_64215808[\"εNFA42-3 char[1]"/]
eNFA42_5_41071365[\"εNFA42-5 regex end"/]
eNFA42_6_34097968[\"εNFA42-6 post-regex start"/]
eNFA42_7_38446258[\"εNFA42-7 post-regex end"/]
eNFA42_4_20425774 -.->|"ε"|eNFA42_0_49614245
eNFA42_4_20425774 -->|"-"|eNFA42_1_43875021
eNFA42_0_49614245 -->|"-"|eNFA42_1_43875021
eNFA42_1_43875021 -.->|"ε"|eNFA42_2_59330872
eNFA42_1_43875021 -->|"="|eNFA42_3_64215808
eNFA42_2_59330872 -->|"="|eNFA42_3_64215808
eNFA42_3_64215808 -.->|"ε"|eNFA42_5_41071365
eNFA42_3_64215808 -.->|"ε"|eNFA42_6_34097968
eNFA42_3_64215808 -.->|"ε"|eNFA42_7_38446258
eNFA42_5_41071365 -.->|"ε"|eNFA42_6_34097968
eNFA42_5_41071365 -.->|"ε"|eNFA42_7_38446258
eNFA42_6_34097968 -.->|"ε"|eNFA42_7_38446258
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
NFA42_4_10472004("NFA42-4 regex start")
NFA42_1_27139175("NFA42-1 char[1]")
NFA42_3_42925989[\"NFA42-3 char[1]"/]
NFA42_4_10472004 -->|"-"|NFA42_1_27139175
NFA42_1_27139175 -->|"="|NFA42_3_42925989
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
subgraph DFA0_494692095["DFA0 regex start"]
NFA42_4_10472004_0("NFA42-4 regex start")
end
subgraph DFA1_-359160068["DFA1 {1}"]
NFA42_1_27139175_1("NFA42-1 char[1]")
end
subgraph DFA2_442054869["DFA2 {1}"]
NFA42_3_42925989_2[\"NFA42-3 char[1]"/]
end
DFA0_494692095 -->|"-"|DFA1_-359160068
DFA1_-359160068 -->|"="|DFA2_442054869
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
DFA0_494692095{{"DFA0 regex start"}}
DFA1_-359160068{{"DFA1 {1}"}}
DFA2_442054869[\"DFA2 {1}"/]
DFA0_494692095 -->|"-"|DFA1_-359160068
DFA1_-359160068 -->|"="|DFA2_442054869
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
subgraph MiniDFA0_1614912464["MiniDFA0 {1}"]
DFA0_494692095_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1267405954["MiniDFA1 {1}"]
DFA1_-359160068_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1235754850["MiniDFA2 {1}"]
DFA2_442054869_2[\"DFA2 {1}"/]
end
MiniDFA0_1614912464 -->|"-"|MiniDFA1_1267405954
MiniDFA1_1267405954 -->|"="|MiniDFA2_1235754850
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
MiniDFA0_1614912464(["MiniDFA0 {1}"])
MiniDFA1_1267405954(["MiniDFA1 {1}"])
MiniDFA2_1235754850[\"MiniDFA2 {1}"/]
MiniDFA0_1614912464 -->|"-"|MiniDFA1_1267405954
MiniDFA1_1267405954 -->|"="|MiniDFA2_1235754850
```
-------------------------------
