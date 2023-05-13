# '/='

pattern: `\/=`

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
eNFA39_4_8199418[["εNFA39-4 regex start"]]
eNFA39_0_6685904[["εNFA39-0 char{1, 1}"]]
eNFA39_1_60173144[["εNFA39-1 char[1]"]]
eNFA39_2_4687385[["εNFA39-2 char{1, 1}"]]
eNFA39_3_42186470[["εNFA39-3 char[1]"]]
eNFA39_5_44133910[["εNFA39-5 regex end"]]
eNFA39_6_61660876[["εNFA39-6 post-regex start"]]
eNFA39_7_18076976[\"εNFA39-7 post-regex end"/]
eNFA39_4_8199418 -.->|"ε"|eNFA39_0_6685904
eNFA39_0_6685904 -->|"/"|eNFA39_1_60173144
eNFA39_1_60173144 -.->|"ε"|eNFA39_2_4687385
eNFA39_2_4687385 -->|"="|eNFA39_3_42186470
eNFA39_3_42186470 -.->|"ε"|eNFA39_5_44133910
eNFA39_5_44133910 -.->|"ε"|eNFA39_6_61660876
eNFA39_6_61660876 -.->|"ε"|eNFA39_7_18076976
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
eNFA39_4_28475059[["εNFA39-4 regex start"]]
eNFA39_0_54948942[["εNFA39-0 char{1, 1}"]]
eNFA39_1_24778434[["εNFA39-1 char[1]"]]
eNFA39_2_21679321[["εNFA39-2 char{1, 1}"]]
eNFA39_3_60896162[\"εNFA39-3 char[1]"/]
eNFA39_5_11194552[\"εNFA39-5 regex end"/]
eNFA39_6_33642107[\"εNFA39-6 post-regex start"/]
eNFA39_7_34343508[\"εNFA39-7 post-regex end"/]
eNFA39_4_28475059 -.->|"ε"|eNFA39_0_54948942
eNFA39_4_28475059 -->|"/"|eNFA39_1_24778434
eNFA39_0_54948942 -->|"/"|eNFA39_1_24778434
eNFA39_1_24778434 -.->|"ε"|eNFA39_2_21679321
eNFA39_1_24778434 -->|"="|eNFA39_3_60896162
eNFA39_2_21679321 -->|"="|eNFA39_3_60896162
eNFA39_3_60896162 -.->|"ε"|eNFA39_5_11194552
eNFA39_3_60896162 -.->|"ε"|eNFA39_6_33642107
eNFA39_3_60896162 -.->|"ε"|eNFA39_7_34343508
eNFA39_5_11194552 -.->|"ε"|eNFA39_6_33642107
eNFA39_5_11194552 -.->|"ε"|eNFA39_7_34343508
eNFA39_6_33642107 -.->|"ε"|eNFA39_7_34343508
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
NFA39_4_40656116("NFA39-4 regex start")
NFA39_1_30360724("NFA39-1 char[1]")
NFA39_3_4811061[\"NFA39-3 char[1]"/]
NFA39_4_40656116 -->|"/"|NFA39_1_30360724
NFA39_1_30360724 -->|"="|NFA39_3_4811061
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
subgraph DFA0_-422341764["DFA0 regex start"]
NFA39_4_40656116_0("NFA39-4 regex start")
end
subgraph DFA1_-1287894951["DFA1 {1}"]
NFA39_1_30360724_1("NFA39-1 char[1]")
end
subgraph DFA2_-953176780["DFA2 {1}"]
NFA39_3_4811061_2[\"NFA39-3 char[1]"/]
end
DFA0_-422341764 -->|"/"|DFA1_-1287894951
DFA1_-1287894951 -->|"="|DFA2_-953176780
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
DFA0_-422341764{{"DFA0 regex start"}}
DFA1_-1287894951{{"DFA1 {1}"}}
DFA2_-953176780[\"DFA2 {1}"/]
DFA0_-422341764 -->|"/"|DFA1_-1287894951
DFA1_-1287894951 -->|"="|DFA2_-953176780
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
subgraph MiniDFA0_895975371["MiniDFA0 {1}"]
DFA0_-422341764_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-590741864["MiniDFA1 {1}"]
DFA1_-1287894951_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_2104753927["MiniDFA2 {1}"]
DFA2_-953176780_2[\"DFA2 {1}"/]
end
MiniDFA0_895975371 -->|"/"|MiniDFA1_-590741864
MiniDFA1_-590741864 -->|"="|MiniDFA2_2104753927
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
MiniDFA0_895975371(["MiniDFA0 {1}"])
MiniDFA1_-590741864(["MiniDFA1 {1}"])
MiniDFA2_2104753927[\"MiniDFA2 {1}"/]
MiniDFA0_895975371 -->|"/"|MiniDFA1_-590741864
MiniDFA1_-590741864 -->|"="|MiniDFA2_2104753927
```
-------------------------------
