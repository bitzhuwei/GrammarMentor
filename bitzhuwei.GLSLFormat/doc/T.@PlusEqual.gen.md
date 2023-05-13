# '+='

pattern: `\+=`

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
eNFA41_4_58941788[["εNFA41-4 regex start"]]
eNFA41_0_60714046[["εNFA41-0 char{1, 1}"]]
eNFA41_1_9555503[["εNFA41-1 char[1]"]]
eNFA41_2_18890664[["εNFA41-2 char{1, 1}"]]
eNFA41_3_35798250[["εNFA41-3 char[1]"]]
eNFA41_5_53748798[["εNFA41-5 regex end"]]
eNFA41_6_13977142[["εNFA41-6 post-regex start"]]
eNFA41_7_58685418[\"εNFA41-7 post-regex end"/]
eNFA41_4_58941788 -.->|"ε"|eNFA41_0_60714046
eNFA41_0_60714046 -->|"+"|eNFA41_1_9555503
eNFA41_1_9555503 -.->|"ε"|eNFA41_2_18890664
eNFA41_2_18890664 -->|"="|eNFA41_3_35798250
eNFA41_3_35798250 -.->|"ε"|eNFA41_5_53748798
eNFA41_5_53748798 -.->|"ε"|eNFA41_6_13977142
eNFA41_6_13977142 -.->|"ε"|eNFA41_7_58685418
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
eNFA41_4_58406714[["εNFA41-4 regex start"]]
eNFA41_0_55898385[["εNFA41-0 char{1, 1}"]]
eNFA41_1_33323423[["εNFA41-1 char[1]"]]
eNFA41_2_31475357[["εNFA41-2 char{1, 1}"]]
eNFA41_3_14842765[\"εNFA41-3 char[1]"/]
eNFA41_5_66476022[\"εNFA41-5 regex end"/]
eNFA41_6_61413291[\"εNFA41-6 post-regex start"/]
eNFA41_7_15848707[\"εNFA41-7 post-regex end"/]
eNFA41_4_58406714 -.->|"ε"|eNFA41_0_55898385
eNFA41_4_58406714 -->|"+"|eNFA41_1_33323423
eNFA41_0_55898385 -->|"+"|eNFA41_1_33323423
eNFA41_1_33323423 -.->|"ε"|eNFA41_2_31475357
eNFA41_1_33323423 -->|"="|eNFA41_3_14842765
eNFA41_2_31475357 -->|"="|eNFA41_3_14842765
eNFA41_3_14842765 -.->|"ε"|eNFA41_5_66476022
eNFA41_3_14842765 -.->|"ε"|eNFA41_6_61413291
eNFA41_3_14842765 -.->|"ε"|eNFA41_7_15848707
eNFA41_5_66476022 -.->|"ε"|eNFA41_6_61413291
eNFA41_5_66476022 -.->|"ε"|eNFA41_7_15848707
eNFA41_6_61413291 -.->|"ε"|eNFA41_7_15848707
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
NFA41_4_8420641("NFA41-4 regex start")
NFA41_1_8676909("NFA41-1 char[1]")
NFA41_3_10983320[\"NFA41-3 char[1]"/]
NFA41_4_8420641 -->|"+"|NFA41_1_8676909
NFA41_1_8676909 -->|"="|NFA41_3_10983320
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
subgraph DFA0_-198512131["DFA0 regex start"]
NFA41_4_8420641_0("NFA41-4 regex start")
end
subgraph DFA1_-482627169["DFA1 {1}"]
NFA41_1_8676909_1("NFA41-1 char[1]")
end
subgraph DFA2_1229386637["DFA2 {1}"]
NFA41_3_10983320_2[\"NFA41-3 char[1]"/]
end
DFA0_-198512131 -->|"+"|DFA1_-482627169
DFA1_-482627169 -->|"="|DFA2_1229386637
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
DFA0_-198512131{{"DFA0 regex start"}}
DFA1_-482627169{{"DFA1 {1}"}}
DFA2_1229386637[\"DFA2 {1}"/]
DFA0_-198512131 -->|"+"|DFA1_-482627169
DFA1_-482627169 -->|"="|DFA2_1229386637
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
subgraph MiniDFA0_-614661375["MiniDFA0 {1}"]
DFA0_-198512131_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_448118089["MiniDFA1 {1}"]
DFA1_-482627169_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1636027808["MiniDFA2 {1}"]
DFA2_1229386637_2[\"DFA2 {1}"/]
end
MiniDFA0_-614661375 -->|"+"|MiniDFA1_448118089
MiniDFA1_448118089 -->|"="|MiniDFA2_1636027808
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
MiniDFA0_-614661375(["MiniDFA0 {1}"])
MiniDFA1_448118089(["MiniDFA1 {1}"])
MiniDFA2_1636027808[\"MiniDFA2 {1}"/]
MiniDFA0_-614661375 -->|"+"|MiniDFA1_448118089
MiniDFA1_448118089 -->|"="|MiniDFA2_1636027808
```
-------------------------------
