# '&='

pattern: `&=`

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
eNFA45_4_35572112[["εNFA45-4 regex start"]]
eNFA45_0_51713556[["εNFA45-0 char{1, 1}"]]
eNFA45_1_62768825[["εNFA45-1 char[1]"]]
eNFA45_2_28048521[["εNFA45-2 char{1, 1}"]]
eNFA45_3_51110099[["εNFA45-3 char[1]"]]
eNFA45_5_57337714[["εNFA45-5 regex end"]]
eNFA45_6_46277382[["εNFA45-6 post-regex start"]]
eNFA45_7_13843256[\"εNFA45-7 post-regex end"/]
eNFA45_4_35572112 -.->|"ε"|eNFA45_0_51713556
eNFA45_0_51713556 -->|"&"|eNFA45_1_62768825
eNFA45_1_62768825 -.->|"ε"|eNFA45_2_28048521
eNFA45_2_28048521 -->|"="|eNFA45_3_51110099
eNFA45_3_51110099 -.->|"ε"|eNFA45_5_57337714
eNFA45_5_57337714 -.->|"ε"|eNFA45_6_46277382
eNFA45_6_46277382 -.->|"ε"|eNFA45_7_13843256
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
eNFA45_4_57480441[["εNFA45-4 regex start"]]
eNFA45_0_47561922[["εNFA45-0 char{1, 1}"]]
eNFA45_1_25404116[["εNFA45-1 char[1]"]]
eNFA45_2_27310456[["εNFA45-2 char{1, 1}"]]
eNFA45_3_44467520[\"εNFA45-3 char[1]"/]
eNFA45_5_64663364[\"εNFA45-5 regex end"/]
eNFA45_6_45099364[\"εNFA45-6 post-regex start"/]
eNFA45_7_3241099[\"εNFA45-7 post-regex end"/]
eNFA45_4_57480441 -.->|"ε"|eNFA45_0_47561922
eNFA45_4_57480441 -->|"&"|eNFA45_1_25404116
eNFA45_0_47561922 -->|"&"|eNFA45_1_25404116
eNFA45_1_25404116 -.->|"ε"|eNFA45_2_27310456
eNFA45_1_25404116 -->|"="|eNFA45_3_44467520
eNFA45_2_27310456 -->|"="|eNFA45_3_44467520
eNFA45_3_44467520 -.->|"ε"|eNFA45_5_64663364
eNFA45_3_44467520 -.->|"ε"|eNFA45_6_45099364
eNFA45_3_44467520 -.->|"ε"|eNFA45_7_3241099
eNFA45_5_64663364 -.->|"ε"|eNFA45_6_45099364
eNFA45_5_64663364 -.->|"ε"|eNFA45_7_3241099
eNFA45_6_45099364 -.->|"ε"|eNFA45_7_3241099
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
NFA45_4_29169897("NFA45-4 regex start")
NFA45_1_61202487("NFA45-1 char[1]")
NFA45_3_13951479[\"NFA45-3 char[1]"/]
NFA45_4_29169897 -->|"&"|NFA45_1_61202487
NFA45_1_61202487 -->|"="|NFA45_3_13951479
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
subgraph DFA0_-1492128138["DFA0 regex start"]
NFA45_4_29169897_0("NFA45-4 regex start")
end
subgraph DFA1_860627770["DFA1 {1}"]
NFA45_1_61202487_1("NFA45-1 char[1]")
end
subgraph DFA2_-895455491["DFA2 {1}"]
NFA45_3_13951479_2[\"NFA45-3 char[1]"/]
end
DFA0_-1492128138 -->|"&"|DFA1_860627770
DFA1_860627770 -->|"="|DFA2_-895455491
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
DFA0_-1492128138{{"DFA0 regex start"}}
DFA1_860627770{{"DFA1 {1}"}}
DFA2_-895455491[\"DFA2 {1}"/]
DFA0_-1492128138 -->|"&"|DFA1_860627770
DFA1_860627770 -->|"="|DFA2_-895455491
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
subgraph MiniDFA0_-838269423["MiniDFA0 {1}"]
DFA0_-1492128138_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-570938624["MiniDFA1 {1}"]
DFA1_860627770_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-11396779["MiniDFA2 {1}"]
DFA2_-895455491_2[\"DFA2 {1}"/]
end
MiniDFA0_-838269423 -->|"&"|MiniDFA1_-570938624
MiniDFA1_-570938624 -->|"="|MiniDFA2_-11396779
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
MiniDFA0_-838269423(["MiniDFA0 {1}"])
MiniDFA1_-570938624(["MiniDFA1 {1}"])
MiniDFA2_-11396779[\"MiniDFA2 {1}"/]
MiniDFA0_-838269423 -->|"&"|MiniDFA1_-570938624
MiniDFA1_-570938624 -->|"="|MiniDFA2_-11396779
```
-------------------------------
