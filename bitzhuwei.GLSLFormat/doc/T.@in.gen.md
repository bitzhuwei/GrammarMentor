# 'in'

pattern: `in`

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
eNFA60_4_5198720[["εNFA60-4 regex start"]]
eNFA60_0_46788488[["εNFA60-0 char{1, 1}"]]
eNFA60_1_18443210[["εNFA60-1 char[1]"]]
eNFA60_2_31771169[["εNFA60-2 char{1, 1}"]]
eNFA60_3_17505069[["εNFA60-3 char[1]"]]
eNFA60_5_23327895[["εNFA60-5 regex end"]]
eNFA60_6_8624464[["εNFA60-6 post-regex start"]]
eNFA60_7_10511313[\"εNFA60-7 post-regex end"/]
eNFA60_4_5198720 -.->|"ε"|eNFA60_0_46788488
eNFA60_0_46788488 -->|"i"|eNFA60_1_18443210
eNFA60_1_18443210 -.->|"ε"|eNFA60_2_31771169
eNFA60_2_31771169 -->|"n"|eNFA60_3_17505069
eNFA60_3_17505069 -.->|"ε"|eNFA60_5_23327895
eNFA60_5_23327895 -.->|"ε"|eNFA60_6_8624464
eNFA60_6_8624464 -.->|"ε"|eNFA60_7_10511313
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
eNFA60_4_27492955[["εNFA60-4 regex start"]]
eNFA60_0_46110007[["εNFA60-0 char{1, 1}"]]
eNFA60_1_12336887[["εNFA60-1 char[1]"]]
eNFA60_2_43923123[["εNFA60-2 char{1, 1}"]]
eNFA60_3_59763787[\"εNFA60-3 char[1]"/]
eNFA60_5_1003178[\"εNFA60-5 regex end"/]
eNFA60_6_9028608[\"εNFA60-6 post-regex start"/]
eNFA60_7_14148614[\"εNFA60-7 post-regex end"/]
eNFA60_4_27492955 -.->|"ε"|eNFA60_0_46110007
eNFA60_4_27492955 -->|"i"|eNFA60_1_12336887
eNFA60_0_46110007 -->|"i"|eNFA60_1_12336887
eNFA60_1_12336887 -.->|"ε"|eNFA60_2_43923123
eNFA60_1_12336887 -->|"n"|eNFA60_3_59763787
eNFA60_2_43923123 -->|"n"|eNFA60_3_59763787
eNFA60_3_59763787 -.->|"ε"|eNFA60_5_1003178
eNFA60_3_59763787 -.->|"ε"|eNFA60_6_9028608
eNFA60_3_59763787 -.->|"ε"|eNFA60_7_14148614
eNFA60_5_1003178 -.->|"ε"|eNFA60_6_9028608
eNFA60_5_1003178 -.->|"ε"|eNFA60_7_14148614
eNFA60_6_9028608 -.->|"ε"|eNFA60_7_14148614
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
NFA60_4_60228670("NFA60-4 regex start")
NFA60_1_5187119("NFA60-1 char[1]")
NFA60_3_46684076[\"NFA60-3 char[1]"/]
NFA60_4_60228670 -->|"i"|NFA60_1_5187119
NFA60_1_5187119 -->|"n"|NFA60_3_46684076
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
subgraph DFA0_-1720373520["DFA0 regex start"]
NFA60_4_60228670_0("NFA60-4 regex start")
end
subgraph DFA1_2061065529["DFA1 {1}"]
NFA60_1_5187119_1("NFA60-1 char[1]")
end
subgraph DFA2_945653935["DFA2 {1}"]
NFA60_3_46684076_2[\"NFA60-3 char[1]"/]
end
DFA0_-1720373520 -->|"i"|DFA1_2061065529
DFA1_2061065529 -->|"n"|DFA2_945653935
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
DFA0_-1720373520{{"DFA0 regex start"}}
DFA1_2061065529{{"DFA1 {1}"}}
DFA2_945653935[\"DFA2 {1}"/]
DFA0_-1720373520 -->|"i"|DFA1_2061065529
DFA1_2061065529 -->|"n"|DFA2_945653935
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
subgraph MiniDFA0_2079003196["MiniDFA0 {1}"]
DFA0_-1720373520_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_148961852["MiniDFA1 {1}"]
DFA1_2061065529_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1241411893["MiniDFA2 {1}"]
DFA2_945653935_2[\"DFA2 {1}"/]
end
MiniDFA0_2079003196 -->|"i"|MiniDFA1_148961852
MiniDFA1_148961852 -->|"n"|MiniDFA2_-1241411893
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
MiniDFA0_2079003196(["MiniDFA0 {1}"])
MiniDFA1_148961852(["MiniDFA1 {1}"])
MiniDFA2_-1241411893[\"MiniDFA2 {1}"/]
MiniDFA0_2079003196 -->|"i"|MiniDFA1_148961852
MiniDFA1_148961852 -->|"n"|MiniDFA2_-1241411893
```
-------------------------------
