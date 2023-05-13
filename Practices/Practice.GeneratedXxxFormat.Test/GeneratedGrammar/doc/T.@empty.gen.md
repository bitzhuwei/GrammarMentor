# 'empty'

pattern: `empty`

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
eNFA7_10_2676452[["εNFA7-10 regex start"]]
eNFA7_0_24088074[["εNFA7-0 char{1, 1}"]]
eNFA7_1_15466074[["εNFA7-1 char[1]"]]
eNFA7_2_4976943[["εNFA7-2 char{1, 1}"]]
eNFA7_3_44792488[["εNFA7-3 char[1]"]]
eNFA7_4_479216[["εNFA7-4 char{1, 1}"]]
eNFA7_5_4312951[["εNFA7-5 char[1]"]]
eNFA7_6_38816567[["εNFA7-6 char{1, 1}"]]
eNFA7_7_13804783[["εNFA7-7 char[1]"]]
eNFA7_8_57134185[["εNFA7-8 char{1, 1}"]]
eNFA7_9_44445623[["εNFA7-9 char[1]"]]
eNFA7_11_64466288[["εNFA7-11 regex end"]]
eNFA7_12_43325687[["εNFA7-12 post-regex start"]]
eNFA7_13_54386868[\"εNFA7-13 post-regex end"/]
eNFA7_10_2676452 -.->|"ε"|eNFA7_0_24088074
eNFA7_0_24088074 -->|"e"|eNFA7_1_15466074
eNFA7_1_15466074 -.->|"ε"|eNFA7_2_4976943
eNFA7_2_4976943 -->|"m"|eNFA7_3_44792488
eNFA7_3_44792488 -.->|"ε"|eNFA7_4_479216
eNFA7_4_479216 -->|"p"|eNFA7_5_4312951
eNFA7_5_4312951 -.->|"ε"|eNFA7_6_38816567
eNFA7_6_38816567 -->|"t"|eNFA7_7_13804783
eNFA7_7_13804783 -.->|"ε"|eNFA7_8_57134185
eNFA7_8_57134185 -->|"y"|eNFA7_9_44445623
eNFA7_9_44445623 -.->|"ε"|eNFA7_11_64466288
eNFA7_11_64466288 -.->|"ε"|eNFA7_12_43325687
eNFA7_12_43325687 -.->|"ε"|eNFA7_13_54386868
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
eNFA7_10_19719768[["εNFA7-10 regex start"]]
eNFA7_0_43260188[["εNFA7-0 char{1, 1}"]]
eNFA7_1_53797377[["εNFA7-1 char[1]"]]
eNFA7_2_14414353[["εNFA7-2 char{1, 1}"]]
eNFA7_3_62620315[["εNFA7-3 char[1]"]]
eNFA7_4_26711930[["εNFA7-4 char{1, 1}"]]
eNFA7_5_39080782[["εNFA7-5 char[1]"]]
eNFA7_6_16182720[["εNFA7-6 char{1, 1}"]]
eNFA7_7_11426753[["εNFA7-7 char[1]"]]
eNFA7_8_35731914[["εNFA7-8 char{1, 1}"]]
eNFA7_9_53151772[\"εNFA7-9 char[1]"/]
eNFA7_11_8603904[\"εNFA7-11 regex end"/]
eNFA7_12_10326280[\"εNFA7-12 post-regex start"/]
eNFA7_13_25827660[\"εNFA7-13 post-regex end"/]
eNFA7_10_19719768 -.->|"ε"|eNFA7_0_43260188
eNFA7_10_19719768 -->|"e"|eNFA7_1_53797377
eNFA7_0_43260188 -->|"e"|eNFA7_1_53797377
eNFA7_1_53797377 -.->|"ε"|eNFA7_2_14414353
eNFA7_1_53797377 -->|"m"|eNFA7_3_62620315
eNFA7_2_14414353 -->|"m"|eNFA7_3_62620315
eNFA7_3_62620315 -.->|"ε"|eNFA7_4_26711930
eNFA7_3_62620315 -->|"p"|eNFA7_5_39080782
eNFA7_4_26711930 -->|"p"|eNFA7_5_39080782
eNFA7_5_39080782 -.->|"ε"|eNFA7_6_16182720
eNFA7_5_39080782 -->|"t"|eNFA7_7_11426753
eNFA7_6_16182720 -->|"t"|eNFA7_7_11426753
eNFA7_7_11426753 -.->|"ε"|eNFA7_8_35731914
eNFA7_7_11426753 -->|"y"|eNFA7_9_53151772
eNFA7_8_35731914 -->|"y"|eNFA7_9_53151772
eNFA7_9_53151772 -.->|"ε"|eNFA7_11_8603904
eNFA7_9_53151772 -.->|"ε"|eNFA7_12_10326280
eNFA7_9_53151772 -.->|"ε"|eNFA7_13_25827660
eNFA7_11_8603904 -.->|"ε"|eNFA7_12_10326280
eNFA7_11_8603904 -.->|"ε"|eNFA7_13_25827660
eNFA7_12_10326280 -.->|"ε"|eNFA7_13_25827660
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
NFA7_10_31122348("NFA7-10 regex start")
NFA7_1_11665683("NFA7-1 char[1]")
NFA7_3_37882289("NFA7-3 char[1]")
NFA7_5_5396287("NFA7-5 char[1]")
NFA7_7_48566591("NFA7-7 char[1]")
NFA7_9_34446136[\"NFA7-9 char[1]"/]
NFA7_10_31122348 -->|"e"|NFA7_1_11665683
NFA7_1_11665683 -->|"m"|NFA7_3_37882289
NFA7_3_37882289 -->|"p"|NFA7_5_5396287
NFA7_5_5396287 -->|"t"|NFA7_7_48566591
NFA7_7_48566591 -->|"y"|NFA7_9_34446136
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
subgraph DFA0_1759926493["DFA0 regex start"]
NFA7_10_31122348_0("NFA7-10 regex start")
end
subgraph DFA1_-1203409057["DFA1 {1}"]
NFA7_1_11665683_1("NFA7-1 char[1]")
end
subgraph DFA2_-178736307["DFA2 {1}"]
NFA7_3_37882289_2("NFA7-3 char[1]")
end
subgraph DFA3_1964942939["DFA3 {1}"]
NFA7_5_5396287_3("NFA7-5 char[1]")
end
subgraph DFA4_-164487152["DFA4 {1}"]
NFA7_7_48566591_4("NFA7-7 char[1]")
end
subgraph DFA5_1111737941["DFA5 {1}"]
NFA7_9_34446136_5[\"NFA7-9 char[1]"/]
end
DFA0_1759926493 -->|"e"|DFA1_-1203409057
DFA1_-1203409057 -->|"m"|DFA2_-178736307
DFA2_-178736307 -->|"p"|DFA3_1964942939
DFA3_1964942939 -->|"t"|DFA4_-164487152
DFA4_-164487152 -->|"y"|DFA5_1111737941
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
DFA0_1759926493{{"DFA0 regex start"}}
DFA1_-1203409057{{"DFA1 {1}"}}
DFA2_-178736307{{"DFA2 {1}"}}
DFA3_1964942939{{"DFA3 {1}"}}
DFA4_-164487152{{"DFA4 {1}"}}
DFA5_1111737941[\"DFA5 {1}"/]
DFA0_1759926493 -->|"e"|DFA1_-1203409057
DFA1_-1203409057 -->|"m"|DFA2_-178736307
DFA2_-178736307 -->|"p"|DFA3_1964942939
DFA3_1964942939 -->|"t"|DFA4_-164487152
DFA4_-164487152 -->|"y"|DFA5_1111737941
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
subgraph MiniDFA0_1219185257["MiniDFA0 {1}"]
DFA0_1759926493_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1459639229["MiniDFA1 {1}"]
DFA1_-1203409057_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_232472721["MiniDFA2 {1}"]
DFA2_-178736307_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_321162798["MiniDFA3 {1}"]
DFA3_1964942939_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1883349697["MiniDFA4 {1}"]
DFA4_-164487152_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1845737400["MiniDFA5 {1}"]
DFA5_1111737941_5[\"DFA5 {1}"/]
end
MiniDFA0_1219185257 -->|"e"|MiniDFA1_-1459639229
MiniDFA1_-1459639229 -->|"m"|MiniDFA2_232472721
MiniDFA2_232472721 -->|"p"|MiniDFA3_321162798
MiniDFA3_321162798 -->|"t"|MiniDFA4_-1883349697
MiniDFA4_-1883349697 -->|"y"|MiniDFA5_1845737400
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
MiniDFA0_1219185257(["MiniDFA0 {1}"])
MiniDFA1_-1459639229(["MiniDFA1 {1}"])
MiniDFA2_232472721(["MiniDFA2 {1}"])
MiniDFA3_321162798(["MiniDFA3 {1}"])
MiniDFA4_-1883349697(["MiniDFA4 {1}"])
MiniDFA5_1845737400[\"MiniDFA5 {1}"/]
MiniDFA0_1219185257 -->|"e"|MiniDFA1_-1459639229
MiniDFA1_-1459639229 -->|"m"|MiniDFA2_232472721
MiniDFA2_232472721 -->|"p"|MiniDFA3_321162798
MiniDFA3_321162798 -->|"t"|MiniDFA4_-1883349697
MiniDFA4_-1883349697 -->|"y"|MiniDFA5_1845737400
```
-------------------------------
