# 'float'

pattern: `[0-9]+\.[0-9]+`

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
eNFA2_6_36308794[["εNFA2-6 regex start"]]
eNFA2_0_59133445[["εNFA2-0 scope{1, ∞}"]]
eNFA2_1_28940004[["εNFA2-1 scope[1]"]]
eNFA2_2_62438959[["εNFA2-2 char{1, 1}"]]
eNFA2_3_52645056[["εNFA2-3 char[1]"]]
eNFA2_4_18191719[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_24390923[["εNFA2-5 scope[1]"]]
eNFA2_7_29507743[["εNFA2-7 regex end"]]
eNFA2_8_62003000[["εNFA2-8 post-regex start"]]
eNFA2_9_21156092[\"εNFA2-9 post-regex end"/]
eNFA2_6_36308794 -.->|"ε"|eNFA2_0_59133445
eNFA2_0_59133445 -->|"[0-9]"|eNFA2_1_28940004
eNFA2_1_28940004 -->|"[0-9]"|eNFA2_1_28940004
eNFA2_1_28940004 -.->|"ε"|eNFA2_2_62438959
eNFA2_2_62438959 -->|"."|eNFA2_3_52645056
eNFA2_3_52645056 -.->|"ε"|eNFA2_4_18191719
eNFA2_4_18191719 -->|"[0-9]"|eNFA2_5_24390923
eNFA2_5_24390923 -->|"[0-9]"|eNFA2_5_24390923
eNFA2_5_24390923 -.->|"ε"|eNFA2_7_29507743
eNFA2_7_29507743 -.->|"ε"|eNFA2_8_62003000
eNFA2_8_62003000 -.->|"ε"|eNFA2_9_21156092
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
eNFA2_6_56187107[["εNFA2-6 regex start"]]
eNFA2_0_55331235[["εNFA2-0 scope{1, ∞}"]]
eNFA2_1_58343698[["εNFA2-1 scope[1]"]]
eNFA2_2_28219072[["εNFA2-2 char{1, 1}"]]
eNFA2_3_35921916[["εNFA2-3 char[1]"]]
eNFA2_4_36391162[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_4043462[\"εNFA2-5 scope[1]"/]
eNFA2_7_59085005[\"εNFA2-7 regex end"/]
eNFA2_8_54861794[\"εNFA2-8 post-regex start"/]
eNFA2_9_23994101[\"εNFA2-9 post-regex end"/]
eNFA2_6_56187107 -.->|"ε"|eNFA2_0_55331235
eNFA2_6_56187107 -->|"[0-9]"|eNFA2_1_58343698
eNFA2_0_55331235 -->|"[0-9]"|eNFA2_1_58343698
eNFA2_1_58343698 -->|"[0-9]"|eNFA2_1_58343698
eNFA2_1_58343698 -.->|"ε"|eNFA2_2_28219072
eNFA2_1_58343698 -->|"."|eNFA2_3_35921916
eNFA2_2_28219072 -->|"."|eNFA2_3_35921916
eNFA2_3_35921916 -.->|"ε"|eNFA2_4_36391162
eNFA2_3_35921916 -->|"[0-9]"|eNFA2_5_4043462
eNFA2_4_36391162 -->|"[0-9]"|eNFA2_5_4043462
eNFA2_5_4043462 -->|"[0-9]"|eNFA2_5_4043462
eNFA2_5_4043462 -.->|"ε"|eNFA2_7_59085005
eNFA2_5_4043462 -.->|"ε"|eNFA2_8_54861794
eNFA2_5_4043462 -.->|"ε"|eNFA2_9_23994101
eNFA2_7_59085005 -.->|"ε"|eNFA2_8_54861794
eNFA2_7_59085005 -.->|"ε"|eNFA2_9_23994101
eNFA2_8_54861794 -.->|"ε"|eNFA2_9_23994101
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
NFA2_6_64473998("NFA2-6 regex start")
NFA2_1_14620318("NFA2-1 scope[1]")
NFA2_3_43395070("NFA2-3 char[1]")
NFA2_5_55011311[\"NFA2-5 scope[1]"/]
NFA2_6_64473998 -->|"[0-9]"|NFA2_1_14620318
NFA2_1_14620318 -->|"[0-9]"|NFA2_1_14620318
NFA2_1_14620318 -->|"."|NFA2_3_43395070
NFA2_3_43395070 -->|"[0-9]"|NFA2_5_55011311
NFA2_5_55011311 -->|"[0-9]"|NFA2_5_55011311
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
subgraph DFA0_636507519["DFA0 regex start"]
NFA2_6_64473998_0("NFA2-6 regex start")
end
subgraph DFA1_1430959008["DFA1 {1}"]
NFA2_1_14620318_1("NFA2-1 scope[1]")
end
subgraph DFA2_-1919249782["DFA2 {1}"]
NFA2_3_43395070_2("NFA2-3 char[1]")
end
subgraph DFA3_-250497205["DFA3 {1}"]
NFA2_5_55011311_3[\"NFA2-5 scope[1]"/]
end
DFA0_636507519 -->|"[0-9]"|DFA1_1430959008
DFA1_1430959008 -->|"[0-9]"|DFA1_1430959008
DFA1_1430959008 -->|"."|DFA2_-1919249782
DFA2_-1919249782 -->|"[0-9]"|DFA3_-250497205
DFA3_-250497205 -->|"[0-9]"|DFA3_-250497205
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
DFA0_636507519{{"DFA0 regex start"}}
DFA1_1430959008{{"DFA1 {1}"}}
DFA2_-1919249782{{"DFA2 {1}"}}
DFA3_-250497205[\"DFA3 {1}"/]
DFA0_636507519 -->|"[0-9]"|DFA1_1430959008
DFA1_1430959008 -->|"[0-9]"|DFA1_1430959008
DFA1_1430959008 -->|"."|DFA2_-1919249782
DFA2_-1919249782 -->|"[0-9]"|DFA3_-250497205
DFA3_-250497205 -->|"[0-9]"|DFA3_-250497205
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
subgraph MiniDFA0_-964947982["MiniDFA0 {1}"]
DFA0_636507519_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2124268381["MiniDFA1 {1}"]
DFA1_1430959008_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1483486628["MiniDFA2 {1}"]
DFA2_-1919249782_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-277247636["MiniDFA3 {1}"]
DFA3_-250497205_3[\"DFA3 {1}"/]
end
MiniDFA0_-964947982 -->|"[0-9]"|MiniDFA1_-2124268381
MiniDFA1_-2124268381 -->|"[0-9]"|MiniDFA1_-2124268381
MiniDFA1_-2124268381 -->|"."|MiniDFA2_1483486628
MiniDFA2_1483486628 -->|"[0-9]"|MiniDFA3_-277247636
MiniDFA3_-277247636 -->|"[0-9]"|MiniDFA3_-277247636
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
MiniDFA0_-964947982(["MiniDFA0 {1}"])
MiniDFA1_-2124268381(["MiniDFA1 {1}"])
MiniDFA2_1483486628(["MiniDFA2 {1}"])
MiniDFA3_-277247636[\"MiniDFA3 {1}"/]
MiniDFA0_-964947982 -->|"[0-9]"|MiniDFA1_-2124268381
MiniDFA1_-2124268381 -->|"[0-9]"|MiniDFA1_-2124268381
MiniDFA1_-2124268381 -->|"."|MiniDFA2_1483486628
MiniDFA2_1483486628 -->|"[0-9]"|MiniDFA3_-277247636
MiniDFA3_-277247636 -->|"[0-9]"|MiniDFA3_-277247636
```
-------------------------------
