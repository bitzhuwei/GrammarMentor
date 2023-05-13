# '>='

pattern: `\>=`

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
eNFA26_4_52733512[["εNFA26-4 regex start"]]
eNFA26_0_4839561[["εNFA26-0 char{1, 1}"]]
eNFA26_1_43556055[["εNFA26-1 char[1]"]]
eNFA26_2_56460178[["εNFA26-2 char{1, 1}"]]
eNFA26_3_38379555[["εNFA26-3 char[1]"]]
eNFA26_5_9871675[["εNFA26-5 regex end"]]
eNFA26_6_21736211[["εNFA26-6 post-regex start"]]
eNFA26_7_61408172[\"εNFA26-7 post-regex end"/]
eNFA26_4_52733512 -.->|"ε"|eNFA26_0_4839561
eNFA26_0_4839561 -->|">"|eNFA26_1_43556055
eNFA26_1_43556055 -.->|"ε"|eNFA26_2_56460178
eNFA26_2_56460178 -->|"="|eNFA26_3_38379555
eNFA26_3_38379555 -.->|"ε"|eNFA26_5_9871675
eNFA26_5_9871675 -.->|"ε"|eNFA26_6_21736211
eNFA26_6_21736211 -.->|"ε"|eNFA26_7_61408172
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
eNFA26_4_15802639[["εNFA26-4 regex start"]]
eNFA26_0_8006030[["εNFA26-0 char{1, 1}"]]
eNFA26_1_4945408[["εNFA26-1 char[1]"]]
eNFA26_2_44508680[["εNFA26-2 char{1, 1}"]]
eNFA26_3_65033806[\"εNFA26-3 char[1]"/]
eNFA26_5_48433347[\"εNFA26-5 regex end"/]
eNFA26_6_33246944[\"εNFA26-6 post-regex start"/]
eNFA26_7_30787047[\"εNFA26-7 post-regex end"/]
eNFA26_4_15802639 -.->|"ε"|eNFA26_0_8006030
eNFA26_4_15802639 -->|">"|eNFA26_1_4945408
eNFA26_0_8006030 -->|">"|eNFA26_1_4945408
eNFA26_1_4945408 -.->|"ε"|eNFA26_2_44508680
eNFA26_1_4945408 -->|"="|eNFA26_3_65033806
eNFA26_2_44508680 -->|"="|eNFA26_3_65033806
eNFA26_3_65033806 -.->|"ε"|eNFA26_5_48433347
eNFA26_3_65033806 -.->|"ε"|eNFA26_6_33246944
eNFA26_3_65033806 -.->|"ε"|eNFA26_7_30787047
eNFA26_5_48433347 -.->|"ε"|eNFA26_6_33246944
eNFA26_5_48433347 -.->|"ε"|eNFA26_7_30787047
eNFA26_6_33246944 -.->|"ε"|eNFA26_7_30787047
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
NFA26_4_8647967("NFA26-4 regex start")
NFA26_1_10722842("NFA26-1 char[1]")
NFA26_3_29396722[\"NFA26-3 char[1]"/]
NFA26_4_8647967 -->|">"|NFA26_1_10722842
NFA26_1_10722842 -->|"="|NFA26_3_29396722
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
subgraph DFA0_-684107774["DFA0 regex start"]
NFA26_4_8647967_0("NFA26-4 regex start")
end
subgraph DFA1_1506121835["DFA1 {1}"]
NFA26_1_10722842_1("NFA26-1 char[1]")
end
subgraph DFA2_647569818["DFA2 {1}"]
NFA26_3_29396722_2[\"NFA26-3 char[1]"/]
end
DFA0_-684107774 -->|">"|DFA1_1506121835
DFA1_1506121835 -->|"="|DFA2_647569818
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
DFA0_-684107774{{"DFA0 regex start"}}
DFA1_1506121835{{"DFA1 {1}"}}
DFA2_647569818[\"DFA2 {1}"/]
DFA0_-684107774 -->|">"|DFA1_1506121835
DFA1_1506121835 -->|"="|DFA2_647569818
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
subgraph MiniDFA0_-1551718736["MiniDFA0 {1}"]
DFA0_-684107774_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1203719605["MiniDFA1 {1}"]
DFA1_1506121835_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-172073059["MiniDFA2 {1}"]
DFA2_647569818_2[\"DFA2 {1}"/]
end
MiniDFA0_-1551718736 -->|">"|MiniDFA1_1203719605
MiniDFA1_1203719605 -->|"="|MiniDFA2_-172073059
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
MiniDFA0_-1551718736(["MiniDFA0 {1}"])
MiniDFA1_1203719605(["MiniDFA1 {1}"])
MiniDFA2_-172073059[\"MiniDFA2 {1}"/]
MiniDFA0_-1551718736 -->|">"|MiniDFA1_1203719605
MiniDFA1_1203719605 -->|"="|MiniDFA2_-172073059
```
-------------------------------
