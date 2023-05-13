# '^^'

pattern: `\^\^`

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
eNFA33_4_15985080[["εNFA33-4 regex start"]]
eNFA33_0_9647994[["εNFA33-0 char{1, 1}"]]
eNFA33_1_19723089[["εNFA33-1 char[1]"]]
eNFA33_2_43290077[["εNFA33-2 char{1, 1}"]]
eNFA33_3_54066375[["εNFA33-3 char[1]"]]
eNFA33_5_16835328[["εNFA33-5 regex end"]]
eNFA33_6_17300225[["εNFA33-6 post-regex start"]]
eNFA33_7_21484299[\"εNFA33-7 post-regex end"/]
eNFA33_4_15985080 -.->|"ε"|eNFA33_0_9647994
eNFA33_0_9647994 -->|"^"|eNFA33_1_19723089
eNFA33_1_19723089 -.->|"ε"|eNFA33_2_43290077
eNFA33_2_43290077 -->|"^"|eNFA33_3_54066375
eNFA33_3_54066375 -.->|"ε"|eNFA33_5_16835328
eNFA33_5_16835328 -.->|"ε"|eNFA33_6_17300225
eNFA33_6_17300225 -.->|"ε"|eNFA33_7_21484299
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
eNFA33_4_59140967[["εNFA33-4 regex start"]]
eNFA33_0_62506663[["εNFA33-0 char{1, 1}"]]
eNFA33_1_25689059[["εNFA33-1 char[1]"]]
eNFA33_2_29874939[["εNFA33-2 char{1, 1}"]]
eNFA33_3_439002[\"εNFA33-3 char[1]"/]
eNFA33_5_3951024[\"εNFA33-5 regex end"/]
eNFA33_6_35559222[\"εNFA33-6 post-regex start"/]
eNFA33_7_51597550[\"εNFA33-7 post-regex end"/]
eNFA33_4_59140967 -.->|"ε"|eNFA33_0_62506663
eNFA33_4_59140967 -->|"^"|eNFA33_1_25689059
eNFA33_0_62506663 -->|"^"|eNFA33_1_25689059
eNFA33_1_25689059 -.->|"ε"|eNFA33_2_29874939
eNFA33_1_25689059 -->|"^"|eNFA33_3_439002
eNFA33_2_29874939 -->|"^"|eNFA33_3_439002
eNFA33_3_439002 -.->|"ε"|eNFA33_5_3951024
eNFA33_3_439002 -.->|"ε"|eNFA33_6_35559222
eNFA33_3_439002 -.->|"ε"|eNFA33_7_51597550
eNFA33_5_3951024 -.->|"ε"|eNFA33_6_35559222
eNFA33_5_3951024 -.->|"ε"|eNFA33_7_51597550
eNFA33_6_35559222 -.->|"ε"|eNFA33_7_51597550
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
NFA33_4_61724767("NFA33-4 regex start")
NFA33_1_18651996("NFA33-1 char[1]")
NFA33_3_33650236[\"NFA33-3 char[1]"/]
NFA33_4_61724767 -->|"^"|NFA33_1_18651996
NFA33_1_18651996 -->|"^"|NFA33_3_33650236
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
subgraph DFA0_-156172972["DFA0 regex start"]
NFA33_4_61724767_0("NFA33-4 regex start")
end
subgraph DFA1_878550098["DFA1 {1}"]
NFA33_1_18651996_1("NFA33-1 char[1]")
end
subgraph DFA2_238748970["DFA2 {1}"]
NFA33_3_33650236_2[\"NFA33-3 char[1]"/]
end
DFA0_-156172972 -->|"^"|DFA1_878550098
DFA1_878550098 -->|"^"|DFA2_238748970
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
DFA0_-156172972{{"DFA0 regex start"}}
DFA1_878550098{{"DFA1 {1}"}}
DFA2_238748970[\"DFA2 {1}"/]
DFA0_-156172972 -->|"^"|DFA1_878550098
DFA1_878550098 -->|"^"|DFA2_238748970
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
subgraph MiniDFA0_1782912643["MiniDFA0 {1}"]
DFA0_-156172972_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1488223345["MiniDFA1 {1}"]
DFA1_878550098_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2105044664["MiniDFA2 {1}"]
DFA2_238748970_2[\"DFA2 {1}"/]
end
MiniDFA0_1782912643 -->|"^"|MiniDFA1_1488223345
MiniDFA1_1488223345 -->|"^"|MiniDFA2_-2105044664
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
MiniDFA0_1782912643(["MiniDFA0 {1}"])
MiniDFA1_1488223345(["MiniDFA1 {1}"])
MiniDFA2_-2105044664[\"MiniDFA2 {1}"/]
MiniDFA0_1782912643 -->|"^"|MiniDFA1_1488223345
MiniDFA1_1488223345 -->|"^"|MiniDFA2_-2105044664
```
-------------------------------
