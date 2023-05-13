# '!='

pattern: `!=`

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
eNFA28_4_9302428[["εNFA28-4 regex start"]]
eNFA28_0_16612996[["εNFA28-0 char{1, 1}"]]
eNFA28_1_15299237[["εNFA28-1 char[1]"]]
eNFA28_2_3475410[["εNFA28-2 char{1, 1}"]]
eNFA28_3_31278690[["εNFA28-3 char[1]"]]
eNFA28_5_13072760[["εNFA28-5 regex end"]]
eNFA28_6_50545980[["εNFA28-6 post-regex start"]]
eNFA28_7_52260639[\"εNFA28-7 post-regex end"/]
eNFA28_4_9302428 -.->|"ε"|eNFA28_0_16612996
eNFA28_0_16612996 -->|"!"|eNFA28_1_15299237
eNFA28_1_15299237 -.->|"ε"|eNFA28_2_3475410
eNFA28_2_3475410 -->|"="|eNFA28_3_31278690
eNFA28_3_31278690 -.->|"ε"|eNFA28_5_13072760
eNFA28_5_13072760 -.->|"ε"|eNFA28_6_50545980
eNFA28_6_50545980 -.->|"ε"|eNFA28_7_52260639
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
eNFA28_4_583706[["εNFA28-4 regex start"]]
eNFA28_0_5253358[["εNFA28-0 char{1, 1}"]]
eNFA28_1_47280229[["εNFA28-1 char[1]"]]
eNFA28_2_22868878[["εNFA28-2 char{1, 1}"]]
eNFA28_3_4493316[\"εNFA28-3 char[1]"/]
eNFA28_5_40439847[\"εNFA28-5 regex end"/]
eNFA28_6_28414304[\"εNFA28-6 post-regex start"/]
eNFA28_7_54402144[\"εNFA28-7 post-regex end"/]
eNFA28_4_583706 -.->|"ε"|eNFA28_0_5253358
eNFA28_4_583706 -->|"!"|eNFA28_1_47280229
eNFA28_0_5253358 -->|"!"|eNFA28_1_47280229
eNFA28_1_47280229 -.->|"ε"|eNFA28_2_22868878
eNFA28_1_47280229 -->|"="|eNFA28_3_4493316
eNFA28_2_22868878 -->|"="|eNFA28_3_4493316
eNFA28_3_4493316 -.->|"ε"|eNFA28_5_40439847
eNFA28_3_4493316 -.->|"ε"|eNFA28_6_28414304
eNFA28_3_4493316 -.->|"ε"|eNFA28_7_54402144
eNFA28_5_40439847 -.->|"ε"|eNFA28_6_28414304
eNFA28_5_40439847 -.->|"ε"|eNFA28_7_54402144
eNFA28_6_28414304 -.->|"ε"|eNFA28_7_54402144
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
NFA28_4_19857248("NFA28-4 regex start")
NFA28_1_44497505("NFA28-1 char[1]")
NFA28_3_64933228[\"NFA28-3 char[1]"/]
NFA28_4_19857248 -->|"!"|NFA28_1_44497505
NFA28_1_44497505 -->|"="|NFA28_3_64933228
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
subgraph DFA0_-1318504946["DFA0 regex start"]
NFA28_4_19857248_0("NFA28-4 regex start")
end
subgraph DFA1_1459423557["DFA1 {1}"]
NFA28_1_44497505_1("NFA28-1 char[1]")
end
subgraph DFA2_1582697448["DFA2 {1}"]
NFA28_3_64933228_2[\"NFA28-3 char[1]"/]
end
DFA0_-1318504946 -->|"!"|DFA1_1459423557
DFA1_1459423557 -->|"="|DFA2_1582697448
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
DFA0_-1318504946{{"DFA0 regex start"}}
DFA1_1459423557{{"DFA1 {1}"}}
DFA2_1582697448[\"DFA2 {1}"/]
DFA0_-1318504946 -->|"!"|DFA1_1459423557
DFA1_1459423557 -->|"="|DFA2_1582697448
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
subgraph MiniDFA0_1256996294["MiniDFA0 {1}"]
DFA0_-1318504946_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_265633422["MiniDFA1 {1}"]
DFA1_1459423557_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-518516624["MiniDFA2 {1}"]
DFA2_1582697448_2[\"DFA2 {1}"/]
end
MiniDFA0_1256996294 -->|"!"|MiniDFA1_265633422
MiniDFA1_265633422 -->|"="|MiniDFA2_-518516624
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
MiniDFA0_1256996294(["MiniDFA0 {1}"])
MiniDFA1_265633422(["MiniDFA1 {1}"])
MiniDFA2_-518516624[\"MiniDFA2 {1}"/]
MiniDFA0_1256996294 -->|"!"|MiniDFA1_265633422
MiniDFA1_265633422 -->|"="|MiniDFA2_-518516624
```
-------------------------------
