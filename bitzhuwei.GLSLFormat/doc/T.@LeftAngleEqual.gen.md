# '<='

pattern: `\<=`

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
eNFA25_4_58179688[["εNFA25-4 regex start"]]
eNFA25_0_53855148[["εNFA25-0 char{1, 1}"]]
eNFA25_1_14934289[["εNFA25-1 char[1]"]]
eNFA25_2_190881[["εNFA25-2 char{1, 1}"]]
eNFA25_3_1717931[["εNFA25-3 char[1]"]]
eNFA25_5_15461386[["εNFA25-5 regex end"]]
eNFA25_6_4934750[["εNFA25-6 post-regex start"]]
eNFA25_7_44412752[\"εNFA25-7 post-regex end"/]
eNFA25_4_58179688 -.->|"ε"|eNFA25_0_53855148
eNFA25_0_53855148 -->|"<"|eNFA25_1_14934289
eNFA25_1_14934289 -.->|"ε"|eNFA25_2_190881
eNFA25_2_190881 -->|"="|eNFA25_3_1717931
eNFA25_3_1717931 -.->|"ε"|eNFA25_5_15461386
eNFA25_5_15461386 -.->|"ε"|eNFA25_6_4934750
eNFA25_6_4934750 -.->|"ε"|eNFA25_7_44412752
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
eNFA25_4_64170449[["εNFA25-4 regex start"]]
eNFA25_0_40663130[["εNFA25-0 char{1, 1}"]]
eNFA25_1_30423852[["εNFA25-1 char[1]"]]
eNFA25_2_5379216[["εNFA25-2 char{1, 1}"]]
eNFA25_3_48412952[\"εNFA25-3 char[1]"/]
eNFA25_5_33063388[\"εNFA25-5 regex end"/]
eNFA25_6_29135036[\"εNFA25-6 post-regex start"/]
eNFA25_7_60888739[\"εNFA25-7 post-regex end"/]
eNFA25_4_64170449 -.->|"ε"|eNFA25_0_40663130
eNFA25_4_64170449 -->|"<"|eNFA25_1_30423852
eNFA25_0_40663130 -->|"<"|eNFA25_1_30423852
eNFA25_1_30423852 -.->|"ε"|eNFA25_2_5379216
eNFA25_1_30423852 -->|"="|eNFA25_3_48412952
eNFA25_2_5379216 -->|"="|eNFA25_3_48412952
eNFA25_3_48412952 -.->|"ε"|eNFA25_5_33063388
eNFA25_3_48412952 -.->|"ε"|eNFA25_6_29135036
eNFA25_3_48412952 -.->|"ε"|eNFA25_7_60888739
eNFA25_5_33063388 -.->|"ε"|eNFA25_6_29135036
eNFA25_5_33063388 -.->|"ε"|eNFA25_7_60888739
eNFA25_6_29135036 -.->|"ε"|eNFA25_7_60888739
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
NFA25_4_11127745("NFA25-4 regex start")
NFA25_1_33040847("NFA25-1 char[1]")
NFA25_3_28932175[\"NFA25-3 char[1]"/]
NFA25_4_11127745 -->|"<"|NFA25_1_33040847
NFA25_1_33040847 -->|"="|NFA25_3_28932175
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
subgraph DFA0_-104998463["DFA0 regex start"]
NFA25_4_11127745_0("NFA25-4 regex start")
end
subgraph DFA1_246485344["DFA1 {1}"]
NFA25_1_33040847_1("NFA25-1 char[1]")
end
subgraph DFA2_1466398650["DFA2 {1}"]
NFA25_3_28932175_2[\"NFA25-3 char[1]"/]
end
DFA0_-104998463 -->|"<"|DFA1_246485344
DFA1_246485344 -->|"="|DFA2_1466398650
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
DFA0_-104998463{{"DFA0 regex start"}}
DFA1_246485344{{"DFA1 {1}"}}
DFA2_1466398650[\"DFA2 {1}"/]
DFA0_-104998463 -->|"<"|DFA1_246485344
DFA1_246485344 -->|"="|DFA2_1466398650
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
subgraph MiniDFA0_-1337489793["MiniDFA0 {1}"]
DFA0_-104998463_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1170669723["MiniDFA1 {1}"]
DFA1_246485344_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1783503797["MiniDFA2 {1}"]
DFA2_1466398650_2[\"DFA2 {1}"/]
end
MiniDFA0_-1337489793 -->|"<"|MiniDFA1_1170669723
MiniDFA1_1170669723 -->|"="|MiniDFA2_-1783503797
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
MiniDFA0_-1337489793(["MiniDFA0 {1}"])
MiniDFA1_1170669723(["MiniDFA1 {1}"])
MiniDFA2_-1783503797[\"MiniDFA2 {1}"/]
MiniDFA0_-1337489793 -->|"<"|MiniDFA1_1170669723
MiniDFA1_1170669723 -->|"="|MiniDFA2_-1783503797
```
-------------------------------
