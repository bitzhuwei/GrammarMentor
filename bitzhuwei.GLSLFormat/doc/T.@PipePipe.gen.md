# '||'

pattern: `\|\|`

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
eNFA34_4_40578897[["εNFA34-4 regex start"]]
eNFA34_0_29665754[["εNFA34-0 char{1, 1}"]]
eNFA34_1_65665194[["εNFA34-1 char[1]"]]
eNFA34_2_54115834[["εNFA34-2 char{1, 1}"]]
eNFA34_3_17280459[["εNFA34-3 char[1]"]]
eNFA34_5_21306406[["εNFA34-5 regex end"]]
eNFA34_6_57539933[["εNFA34-6 post-regex start"]]
eNFA34_7_48097351[\"εNFA34-7 post-regex end"/]
eNFA34_4_40578897 -.->|"ε"|eNFA34_0_29665754
eNFA34_0_29665754 -->|"|"|eNFA34_1_65665194
eNFA34_1_65665194 -.->|"ε"|eNFA34_2_54115834
eNFA34_2_54115834 -->|"|"|eNFA34_3_17280459
eNFA34_3_17280459 -.->|"ε"|eNFA34_5_21306406
eNFA34_5_21306406 -.->|"ε"|eNFA34_6_57539933
eNFA34_6_57539933 -.->|"ε"|eNFA34_7_48097351
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
eNFA34_4_30222983[["εNFA34-4 regex start"]]
eNFA34_0_3571397[["εNFA34-0 char{1, 1}"]]
eNFA34_1_32142578[["εNFA34-1 char[1]"]]
eNFA34_2_20847751[["εNFA34-2 char{1, 1}"]]
eNFA34_3_53412038[\"εNFA34-3 char[1]"/]
eNFA34_5_10946294[\"εNFA34-5 regex end"/]
eNFA34_6_31407785[\"εNFA34-6 post-regex start"/]
eNFA34_7_14234617[\"εNFA34-7 post-regex end"/]
eNFA34_4_30222983 -.->|"ε"|eNFA34_0_3571397
eNFA34_4_30222983 -->|"|"|eNFA34_1_32142578
eNFA34_0_3571397 -->|"|"|eNFA34_1_32142578
eNFA34_1_32142578 -.->|"ε"|eNFA34_2_20847751
eNFA34_1_32142578 -->|"|"|eNFA34_3_53412038
eNFA34_2_20847751 -->|"|"|eNFA34_3_53412038
eNFA34_3_53412038 -.->|"ε"|eNFA34_5_10946294
eNFA34_3_53412038 -.->|"ε"|eNFA34_6_31407785
eNFA34_3_53412038 -.->|"ε"|eNFA34_7_14234617
eNFA34_5_10946294 -.->|"ε"|eNFA34_6_31407785
eNFA34_5_10946294 -.->|"ε"|eNFA34_7_14234617
eNFA34_6_31407785 -.->|"ε"|eNFA34_7_14234617
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
NFA34_4_61002694("NFA34-4 regex start")
NFA34_1_12153337("NFA34-1 char[1]")
NFA34_3_42271171[\"NFA34-3 char[1]"/]
NFA34_4_61002694 -->|"|"|NFA34_1_12153337
NFA34_1_12153337 -->|"|"|NFA34_3_42271171
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
subgraph DFA0_-1808365411["DFA0 regex start"]
NFA34_4_61002694_0("NFA34-4 regex start")
end
subgraph DFA1_-679107727["DFA1 {1}"]
NFA34_1_12153337_1("NFA34-1 char[1]")
end
subgraph DFA2_1257198997["DFA2 {1}"]
NFA34_3_42271171_2[\"NFA34-3 char[1]"/]
end
DFA0_-1808365411 -->|"|"|DFA1_-679107727
DFA1_-679107727 -->|"|"|DFA2_1257198997
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
DFA0_-1808365411{{"DFA0 regex start"}}
DFA1_-679107727{{"DFA1 {1}"}}
DFA2_1257198997[\"DFA2 {1}"/]
DFA0_-1808365411 -->|"|"|DFA1_-679107727
DFA1_-679107727 -->|"|"|DFA2_1257198997
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
subgraph MiniDFA0_-1987671008["MiniDFA0 {1}"]
DFA0_-1808365411_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1817846394["MiniDFA1 {1}"]
DFA1_-679107727_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-152629732["MiniDFA2 {1}"]
DFA2_1257198997_2[\"DFA2 {1}"/]
end
MiniDFA0_-1987671008 -->|"|"|MiniDFA1_1817846394
MiniDFA1_1817846394 -->|"|"|MiniDFA2_-152629732
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
MiniDFA0_-1987671008(["MiniDFA0 {1}"])
MiniDFA1_1817846394(["MiniDFA1 {1}"])
MiniDFA2_-152629732[\"MiniDFA2 {1}"/]
MiniDFA0_-1987671008 -->|"|"|MiniDFA1_1817846394
MiniDFA1_1817846394 -->|"|"|MiniDFA2_-152629732
```
-------------------------------
