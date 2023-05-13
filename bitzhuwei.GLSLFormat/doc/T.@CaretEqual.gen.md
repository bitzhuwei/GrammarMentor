# '^='

pattern: `\^=`

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
eNFA46_4_48623408[["εNFA46-4 regex start"]]
eNFA46_0_34957489[["εNFA46-0 char{1, 1}"]]
eNFA46_1_46181951[["εNFA46-1 char[1]"]]
eNFA46_2_12984378[["εNFA46-2 char{1, 1}"]]
eNFA46_3_49750539[["εNFA46-3 char[1]"]]
eNFA46_5_45101667[["εNFA46-5 regex end"]]
eNFA46_6_3261819[["εNFA46-6 post-regex start"]]
eNFA46_7_29356372[\"εNFA46-7 post-regex end"/]
eNFA46_4_48623408 -.->|"ε"|eNFA46_0_34957489
eNFA46_0_34957489 -->|"^"|eNFA46_1_46181951
eNFA46_1_46181951 -.->|"ε"|eNFA46_2_12984378
eNFA46_2_12984378 -->|"="|eNFA46_3_49750539
eNFA46_3_49750539 -.->|"ε"|eNFA46_5_45101667
eNFA46_5_45101667 -.->|"ε"|eNFA46_6_3261819
eNFA46_6_3261819 -.->|"ε"|eNFA46_7_29356372
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
eNFA46_4_62880759[["εNFA46-4 regex start"]]
eNFA46_0_29055926[["εNFA46-0 char{1, 1}"]]
eNFA46_1_60176744[["εNFA46-1 char[1]"]]
eNFA46_2_4719792[["εNFA46-2 char{1, 1}"]]
eNFA46_3_42478134[\"εNFA46-3 char[1]"/]
eNFA46_5_46758891[\"εNFA46-5 regex end"/]
eNFA46_6_18176840[\"εNFA46-6 post-regex start"/]
eNFA46_7_29373839[\"εNFA46-7 post-regex end"/]
eNFA46_4_62880759 -.->|"ε"|eNFA46_0_29055926
eNFA46_4_62880759 -->|"^"|eNFA46_1_60176744
eNFA46_0_29055926 -->|"^"|eNFA46_1_60176744
eNFA46_1_60176744 -.->|"ε"|eNFA46_2_4719792
eNFA46_1_60176744 -->|"="|eNFA46_3_42478134
eNFA46_2_4719792 -->|"="|eNFA46_3_42478134
eNFA46_3_42478134 -.->|"ε"|eNFA46_5_46758891
eNFA46_3_42478134 -.->|"ε"|eNFA46_6_18176840
eNFA46_3_42478134 -.->|"ε"|eNFA46_7_29373839
eNFA46_5_46758891 -.->|"ε"|eNFA46_6_18176840
eNFA46_5_46758891 -.->|"ε"|eNFA46_7_29373839
eNFA46_6_18176840 -.->|"ε"|eNFA46_7_29373839
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
NFA46_4_63037959("NFA46-4 regex start")
NFA46_1_30470722("NFA46-1 char[1]")
NFA46_3_5801050[\"NFA46-3 char[1]"/]
NFA46_4_63037959 -->|"^"|NFA46_1_30470722
NFA46_1_30470722 -->|"="|NFA46_3_5801050
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
subgraph DFA0_-1689529896["DFA0 regex start"]
NFA46_4_63037959_0("NFA46-4 regex start")
end
subgraph DFA1_1812517326["DFA1 {1}"]
NFA46_1_30470722_1("NFA46-1 char[1]")
end
subgraph DFA2_840088379["DFA2 {1}"]
NFA46_3_5801050_2[\"NFA46-3 char[1]"/]
end
DFA0_-1689529896 -->|"^"|DFA1_1812517326
DFA1_1812517326 -->|"="|DFA2_840088379
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
DFA0_-1689529896{{"DFA0 regex start"}}
DFA1_1812517326{{"DFA1 {1}"}}
DFA2_840088379[\"DFA2 {1}"/]
DFA0_-1689529896 -->|"^"|DFA1_1812517326
DFA1_1812517326 -->|"="|DFA2_840088379
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
subgraph MiniDFA0_-969269708["MiniDFA0 {1}"]
DFA0_-1689529896_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-43069028["MiniDFA1 {1}"]
DFA1_1812517326_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1029364416["MiniDFA2 {1}"]
DFA2_840088379_2[\"DFA2 {1}"/]
end
MiniDFA0_-969269708 -->|"^"|MiniDFA1_-43069028
MiniDFA1_-43069028 -->|"="|MiniDFA2_1029364416
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
MiniDFA0_-969269708(["MiniDFA0 {1}"])
MiniDFA1_-43069028(["MiniDFA1 {1}"])
MiniDFA2_1029364416[\"MiniDFA2 {1}"/]
MiniDFA0_-969269708 -->|"^"|MiniDFA1_-43069028
MiniDFA1_-43069028 -->|"="|MiniDFA2_1029364416
```
-------------------------------
