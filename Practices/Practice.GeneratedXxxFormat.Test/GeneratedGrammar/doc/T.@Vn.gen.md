# 'Vn'

pattern: `[a-zA-Z_][a-zA-Z0-9_]*`

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
eNFA1_3_3453833[["εNFA1-3 regex start"]]
eNFA1_0_31084503[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_34122637[["εNFA1-1 scope[1]"]]
eNFA1_2_3791404[["εNFA1-2 scope{0, ∞}"]]
eNFA1_4_38668280[["εNFA1-4 regex end"]]
eNFA1_5_1590600[["εNFA1-5 post-regex start"]]
eNFA1_6_14315403[\"εNFA1-6 post-regex end"/]
eNFA1_3_3453833 -.->|"ε"|eNFA1_0_31084503
eNFA1_0_31084503 -->|"[a-zA-Z_]"|eNFA1_1_34122637
eNFA1_1_34122637 -.->|"ε"|eNFA1_2_3791404
eNFA1_2_3791404 -->|"[a-zA-Z0-9_]"|eNFA1_2_3791404
eNFA1_2_3791404 -.->|"ε"|eNFA1_4_38668280
eNFA1_4_38668280 -.->|"ε"|eNFA1_5_1590600
eNFA1_5_1590600 -.->|"ε"|eNFA1_6_14315403
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
eNFA1_3_61729771[["εNFA1-3 regex start"]]
eNFA1_0_18697032[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_34816825[\"εNFA1-1 scope[1]"/]
eNFA1_2_11325076[\"εNFA1-2 scope{0, ∞}"/]
eNFA1_4_44915976[\"εNFA1-4 regex end"/]
eNFA1_5_34055563[\"εNFA1-5 post-regex start"/]
eNFA1_6_38064613[\"εNFA1-6 post-regex end"/]
eNFA1_3_61729771 -.->|"ε"|eNFA1_0_18697032
eNFA1_3_61729771 -->|"[a-zA-Z_]"|eNFA1_1_34816825
eNFA1_0_18697032 -->|"[a-zA-Z_]"|eNFA1_1_34816825
eNFA1_1_34816825 -.->|"ε"|eNFA1_2_11325076
eNFA1_1_34816825 -->|"[a-zA-Z0-9_]"|eNFA1_2_11325076
eNFA1_1_34816825 -.->|"ε"|eNFA1_4_44915976
eNFA1_1_34816825 -.->|"ε"|eNFA1_5_34055563
eNFA1_1_34816825 -.->|"ε"|eNFA1_6_38064613
eNFA1_2_11325076 -->|"[a-zA-Z0-9_]"|eNFA1_2_11325076
eNFA1_2_11325076 -.->|"ε"|eNFA1_4_44915976
eNFA1_2_11325076 -.->|"ε"|eNFA1_5_34055563
eNFA1_2_11325076 -.->|"ε"|eNFA1_6_38064613
eNFA1_4_44915976 -.->|"ε"|eNFA1_5_34055563
eNFA1_4_44915976 -.->|"ε"|eNFA1_6_38064613
eNFA1_5_34055563 -.->|"ε"|eNFA1_6_38064613
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
NFA1_3_33142240("NFA1-3 regex start")
NFA1_1_63334794[\"NFA1-1 scope[1]"/]
NFA1_2_7037199[\"NFA1-2 scope{0, ∞}"/]
NFA1_3_33142240 -->|"[a-zA-Z_]"|NFA1_1_63334794
NFA1_1_63334794 -->|"[a-zA-Z0-9_]"|NFA1_2_7037199
NFA1_2_7037199 -->|"[a-zA-Z0-9_]"|NFA1_2_7037199
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
subgraph DFA0_-259252348["DFA0 regex start"]
NFA1_3_33142240_0("NFA1-3 regex start")
end
subgraph DFA1_1689248301["DFA1 {1}"]
NFA1_1_63334794_1[\"NFA1-1 scope[1]"/]
end
subgraph DFA2_1781973808["DFA2 {1}"]
NFA1_2_7037199_2[\"NFA1-2 scope{0, ∞}"/]
end
DFA0_-259252348 -->|"[a-zA-Z_]"|DFA1_1689248301
DFA1_1689248301 -->|"[a-zA-Z0-9_]"|DFA2_1781973808
DFA2_1781973808 -->|"[a-zA-Z0-9_]"|DFA2_1781973808
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
DFA0_-259252348{{"DFA0 regex start"}}
DFA1_1689248301[\"DFA1 {1}"/]
DFA2_1781973808[\"DFA2 {1}"/]
DFA0_-259252348 -->|"[a-zA-Z_]"|DFA1_1689248301
DFA1_1689248301 -->|"[a-zA-Z0-9_]"|DFA2_1781973808
DFA2_1781973808 -->|"[a-zA-Z0-9_]"|DFA2_1781973808
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
subgraph MiniDFA0_1971186646["MiniDFA0 {1}"]
DFA0_-259252348_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2036448001["MiniDFA1 {1}"]
DFA1_1689248301_1[\"DFA1 {1}"/]
end
subgraph MiniDFA2_-1392151414["MiniDFA2 {1}"]
DFA2_1781973808_2[\"DFA2 {1}"/]
end
MiniDFA0_1971186646 -->|"[a-zA-Z_]"|MiniDFA1_-2036448001
MiniDFA1_-2036448001 -->|"[a-zA-Z0-9_]"|MiniDFA2_-1392151414
MiniDFA2_-1392151414 -->|"[a-zA-Z0-9_]"|MiniDFA2_-1392151414
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
MiniDFA0_1971186646(["MiniDFA0 {1}"])
MiniDFA1_-2036448001[\"MiniDFA1 {1}"/]
MiniDFA2_-1392151414[\"MiniDFA2 {1}"/]
MiniDFA0_1971186646 -->|"[a-zA-Z_]"|MiniDFA1_-2036448001
MiniDFA1_-2036448001 -->|"[a-zA-Z0-9_]"|MiniDFA2_-1392151414
MiniDFA2_-1392151414 -->|"[a-zA-Z0-9_]"|MiniDFA2_-1392151414
```
-------------------------------
