# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA4_16_41560081[["εNFA4-16 regex start"]]
eNFA4_0_38496415[["εNFA4-0 char{1, 1}"]]
eNFA4_1_10923418[["εNFA4-1 char[1]"]]
eNFA4_2_31201899[["εNFA4-2 char{1, 1}"]]
eNFA4_3_58328727[["εNFA4-3 char[1]"]]
eNFA4_6_61494432[["εNFA4-6 regex start"]]
eNFA4_4_14993092[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_16578980[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_720107[["εNFA4-7 regex end"]]
eNFA4_5_27006480[["εNFA4-5 scope[1]"]]
eNFA4_9_34181910[["εNFA4-9 scope[1]"]]
eNFA4_12_55196503[["εNFA4-12 char{1, 1}"]]
eNFA4_10_56799051[["εNFA4-10 scope{1, 1}"]]
eNFA4_13_41429416[["εNFA4-13 char[1]"]]
eNFA4_11_22118023[["εNFA4-11 scope[1]"]]
eNFA4_14_37320431[["εNFA4-14 char{1, 1}"]]
eNFA4_15_3056034[["εNFA4-15 char[1]"]]
eNFA4_17_27504314[["εNFA4-17 regex end"]]
eNFA4_18_46212239[["εNFA4-18 post-regex start"]]
eNFA4_19_13256970[\"εNFA4-19 post-regex end"/]
eNFA4_16_41560081 -.->|"ε"|eNFA4_0_38496415
eNFA4_0_38496415 -->|"/"|eNFA4_1_10923418
eNFA4_1_10923418 -.->|"ε"|eNFA4_2_31201899
eNFA4_2_31201899 -->|"*"|eNFA4_3_58328727
eNFA4_3_58328727 -.->|"ε"|eNFA4_6_61494432
eNFA4_6_61494432 -.->|"ε"|eNFA4_4_14993092
eNFA4_6_61494432 -.->|"ε"|eNFA4_8_16578980
eNFA4_6_61494432 -.->|"ε"|eNFA4_7_720107
eNFA4_4_14993092 -->|"[^*]"|eNFA4_5_27006480
eNFA4_8_16578980 -->|"[*]"|eNFA4_9_34181910
eNFA4_7_720107 -.->|"ε"|eNFA4_6_61494432
eNFA4_7_720107 -.->|"ε"|eNFA4_12_55196503
eNFA4_5_27006480 -.->|"ε"|eNFA4_7_720107
eNFA4_9_34181910 -.->|"ε"|eNFA4_10_56799051
eNFA4_12_55196503 -->|"*"|eNFA4_13_41429416
eNFA4_10_56799051 -->|"[^/]"|eNFA4_11_22118023
eNFA4_13_41429416 -.->|"ε"|eNFA4_14_37320431
eNFA4_11_22118023 -.->|"ε"|eNFA4_7_720107
eNFA4_14_37320431 -->|"/"|eNFA4_15_3056034
eNFA4_15_3056034 -.->|"ε"|eNFA4_17_27504314
eNFA4_17_27504314 -.->|"ε"|eNFA4_18_46212239
eNFA4_18_46212239 -.->|"ε"|eNFA4_19_13256970
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
eNFA4_16_52203868[["εNFA4-16 regex start"]]
eNFA4_0_72766[["εNFA4-0 char{1, 1}"]]
eNFA4_1_654897[["εNFA4-1 char[1]"]]
eNFA4_2_5894079[["εNFA4-2 char{1, 1}"]]
eNFA4_3_39201736[["εNFA4-3 char[1]"]]
eNFA4_6_12381635[["εNFA4-6 regex start"]]
eNFA4_4_63388340[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_44325851[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_33624151[["εNFA4-7 regex end"]]
eNFA4_5_21224086[["εNFA4-5 scope[1]"]]
eNFA4_9_53046711[["εNFA4-9 scope[1]"]]
eNFA4_12_17271312[["εNFA4-12 char{1, 1}"]]
eNFA4_13_1816341[["εNFA4-13 char[1]"]]
eNFA4_10_7658356[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_339559[["εNFA4-11 scope[1]"]]
eNFA4_14_16347077[["εNFA4-14 char{1, 1}"]]
eNFA4_15_12905972[\"εNFA4-15 char[1]"/]
eNFA4_17_49044892[\"εNFA4-17 regex end"/]
eNFA4_18_38750844[\"εNFA4-18 post-regex start"/]
eNFA4_19_13213278[\"εNFA4-19 post-regex end"/]
eNFA4_16_52203868 -.->|"ε"|eNFA4_0_72766
eNFA4_16_52203868 -->|"/"|eNFA4_1_654897
eNFA4_0_72766 -->|"/"|eNFA4_1_654897
eNFA4_1_654897 -.->|"ε"|eNFA4_2_5894079
eNFA4_1_654897 -->|"*"|eNFA4_3_39201736
eNFA4_2_5894079 -->|"*"|eNFA4_3_39201736
eNFA4_3_39201736 -.->|"ε"|eNFA4_6_12381635
eNFA4_3_39201736 -.->|"ε"|eNFA4_4_63388340
eNFA4_3_39201736 -.->|"ε"|eNFA4_8_44325851
eNFA4_3_39201736 -.->|"ε"|eNFA4_7_33624151
eNFA4_3_39201736 -->|"[^*]"|eNFA4_5_21224086
eNFA4_3_39201736 -->|"[*]"|eNFA4_9_53046711
eNFA4_3_39201736 -.->|"ε"|eNFA4_12_17271312
eNFA4_3_39201736 -->|"*"|eNFA4_13_1816341
eNFA4_6_12381635 -.->|"ε"|eNFA4_4_63388340
eNFA4_6_12381635 -.->|"ε"|eNFA4_8_44325851
eNFA4_6_12381635 -.->|"ε"|eNFA4_7_33624151
eNFA4_6_12381635 -->|"[^*]"|eNFA4_5_21224086
eNFA4_6_12381635 -->|"[*]"|eNFA4_9_53046711
eNFA4_6_12381635 -.->|"ε"|eNFA4_6_12381635
eNFA4_6_12381635 -.->|"ε"|eNFA4_12_17271312
eNFA4_6_12381635 -->|"*"|eNFA4_13_1816341
eNFA4_4_63388340 -->|"[^*]"|eNFA4_5_21224086
eNFA4_8_44325851 -->|"[*]"|eNFA4_9_53046711
eNFA4_7_33624151 -.->|"ε"|eNFA4_6_12381635
eNFA4_7_33624151 -.->|"ε"|eNFA4_12_17271312
eNFA4_7_33624151 -.->|"ε"|eNFA4_4_63388340
eNFA4_7_33624151 -.->|"ε"|eNFA4_8_44325851
eNFA4_7_33624151 -.->|"ε"|eNFA4_7_33624151
eNFA4_7_33624151 -->|"[^*]"|eNFA4_5_21224086
eNFA4_7_33624151 -->|"[*]"|eNFA4_9_53046711
eNFA4_7_33624151 -->|"*"|eNFA4_13_1816341
eNFA4_5_21224086 -.->|"ε"|eNFA4_7_33624151
eNFA4_5_21224086 -.->|"ε"|eNFA4_6_12381635
eNFA4_5_21224086 -.->|"ε"|eNFA4_12_17271312
eNFA4_5_21224086 -.->|"ε"|eNFA4_4_63388340
eNFA4_5_21224086 -.->|"ε"|eNFA4_8_44325851
eNFA4_5_21224086 -->|"[^*]"|eNFA4_5_21224086
eNFA4_5_21224086 -->|"[*]"|eNFA4_9_53046711
eNFA4_5_21224086 -->|"*"|eNFA4_13_1816341
eNFA4_9_53046711 -.->|"ε"|eNFA4_10_7658356
eNFA4_9_53046711 -->|"[^/]"|eNFA4_11_339559
eNFA4_12_17271312 -->|"*"|eNFA4_13_1816341
eNFA4_13_1816341 -.->|"ε"|eNFA4_14_16347077
eNFA4_13_1816341 -->|"/"|eNFA4_15_12905972
eNFA4_10_7658356 -->|"[^/]"|eNFA4_11_339559
eNFA4_11_339559 -.->|"ε"|eNFA4_7_33624151
eNFA4_11_339559 -.->|"ε"|eNFA4_6_12381635
eNFA4_11_339559 -.->|"ε"|eNFA4_12_17271312
eNFA4_11_339559 -.->|"ε"|eNFA4_4_63388340
eNFA4_11_339559 -.->|"ε"|eNFA4_8_44325851
eNFA4_11_339559 -->|"[^*]"|eNFA4_5_21224086
eNFA4_11_339559 -->|"[*]"|eNFA4_9_53046711
eNFA4_11_339559 -->|"*"|eNFA4_13_1816341
eNFA4_14_16347077 -->|"/"|eNFA4_15_12905972
eNFA4_15_12905972 -.->|"ε"|eNFA4_17_49044892
eNFA4_15_12905972 -.->|"ε"|eNFA4_18_38750844
eNFA4_15_12905972 -.->|"ε"|eNFA4_19_13213278
eNFA4_17_49044892 -.->|"ε"|eNFA4_18_38750844
eNFA4_17_49044892 -.->|"ε"|eNFA4_19_13213278
eNFA4_18_38750844 -.->|"ε"|eNFA4_19_13213278
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
NFA4_16_7837633("NFA4-16 regex start")
NFA4_1_3429838("NFA4-1 char[1]")
NFA4_3_51810644("NFA4-3 char[1]")
NFA4_5_35912612("NFA4-5 scope[1]")
NFA4_9_63642613("NFA4-9 scope[1]")
NFA4_13_54778057("NFA4-13 char[1]")
NFA4_11_23240469("NFA4-11 scope[1]")
NFA4_15_30868550[\"NFA4-15 char[1]"/]
NFA4_16_7837633 -->|"/"|NFA4_1_3429838
NFA4_1_3429838 -->|"*"|NFA4_3_51810644
NFA4_3_51810644 -->|"[^*]"|NFA4_5_35912612
NFA4_3_51810644 -->|"[*]"|NFA4_9_63642613
NFA4_3_51810644 -->|"*"|NFA4_13_54778057
NFA4_5_35912612 -->|"[^*]"|NFA4_5_35912612
NFA4_5_35912612 -->|"[*]"|NFA4_9_63642613
NFA4_5_35912612 -->|"*"|NFA4_13_54778057
NFA4_9_63642613 -->|"[^/]"|NFA4_11_23240469
NFA4_13_54778057 -->|"/"|NFA4_15_30868550
NFA4_11_23240469 -->|"[^*]"|NFA4_5_35912612
NFA4_11_23240469 -->|"[*]"|NFA4_9_63642613
NFA4_11_23240469 -->|"*"|NFA4_13_54778057
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
subgraph DFA0_-1979782369["DFA0 regex start"]
NFA4_16_7837633_0("NFA4-16 regex start")
end
subgraph DFA1_-1978269096["DFA1 {1}"]
NFA4_1_3429838_1("NFA4-1 char[1]")
end
subgraph DFA2_910344125["DFA2 {1}"]
NFA4_3_51810644_2("NFA4-3 char[1]")
end
subgraph DFA3_-1609076695["DFA3 {1}"]
NFA4_5_35912612_3("NFA4-5 scope[1]")
end
subgraph DFA4_1661319033["DFA4 {2}"]
NFA4_9_63642613_4("NFA4-9 scope[1]")
NFA4_13_54778057_5("NFA4-13 char[1]")
end
subgraph DFA5_502006728["DFA5 {1}"]
NFA4_11_23240469_6("NFA4-11 scope[1]")
end
subgraph DFA6_-1353670641["DFA6 {1}"]
NFA4_15_30868550_7[\"NFA4-15 char[1]"/]
end
DFA0_-1979782369 -->|"/"|DFA1_-1978269096
DFA1_-1978269096 -->|"*"|DFA2_910344125
DFA2_910344125 -->|"[^*]"|DFA3_-1609076695
DFA2_910344125 -->|"*"|DFA4_1661319033
DFA3_-1609076695 -->|"[^*]"|DFA3_-1609076695
DFA3_-1609076695 -->|"*"|DFA4_1661319033
DFA4_1661319033 -->|"[^/]"|DFA5_502006728
DFA4_1661319033 -->|"/"|DFA6_-1353670641
DFA5_502006728 -->|"[^*]"|DFA3_-1609076695
DFA5_502006728 -->|"*"|DFA4_1661319033
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
DFA0_-1979782369{{"DFA0 regex start"}}
DFA1_-1978269096{{"DFA1 {1}"}}
DFA2_910344125{{"DFA2 {1}"}}
DFA3_-1609076695{{"DFA3 {1}"}}
DFA4_1661319033{{"DFA4 {2}"}}
DFA5_502006728{{"DFA5 {1}"}}
DFA6_-1353670641[\"DFA6 {1}"/]
DFA0_-1979782369 -->|"/"|DFA1_-1978269096
DFA1_-1978269096 -->|"*"|DFA2_910344125
DFA2_910344125 -->|"[^*]"|DFA3_-1609076695
DFA2_910344125 -->|"*"|DFA4_1661319033
DFA3_-1609076695 -->|"[^*]"|DFA3_-1609076695
DFA3_-1609076695 -->|"*"|DFA4_1661319033
DFA4_1661319033 -->|"[^/]"|DFA5_502006728
DFA4_1661319033 -->|"/"|DFA6_-1353670641
DFA5_502006728 -->|"[^*]"|DFA3_-1609076695
DFA5_502006728 -->|"*"|DFA4_1661319033
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
subgraph MiniDFA0_908363240["MiniDFA0 {1}"]
DFA0_-1979782369_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_925356560["MiniDFA1 {1}"]
DFA1_-1978269096_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-121035749["MiniDFA2 {3}"]
DFA2_910344125_2{{"DFA2 {1}"}}
DFA3_-1609076695_3{{"DFA3 {1}"}}
DFA5_502006728_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_-1467565770["MiniDFA3 {1}"]
DFA4_1661319033_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_1921185818["MiniDFA4 {1}"]
DFA6_-1353670641_6[\"DFA6 {1}"/]
end
MiniDFA0_908363240 -->|"/"|MiniDFA1_925356560
MiniDFA1_925356560 -->|"*"|MiniDFA2_-121035749
MiniDFA2_-121035749 -->|"[^*]"|MiniDFA2_-121035749
MiniDFA2_-121035749 -->|"*"|MiniDFA3_-1467565770
MiniDFA3_-1467565770 -->|"[^/]"|MiniDFA2_-121035749
MiniDFA3_-1467565770 -->|"/"|MiniDFA4_1921185818
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
MiniDFA0_908363240(["MiniDFA0 {1}"])
MiniDFA1_925356560(["MiniDFA1 {1}"])
MiniDFA2_-121035749(["MiniDFA2 {3}"])
MiniDFA3_-1467565770(["MiniDFA3 {1}"])
MiniDFA4_1921185818[\"MiniDFA4 {1}"/]
MiniDFA0_908363240 -->|"/"|MiniDFA1_925356560
MiniDFA1_925356560 -->|"*"|MiniDFA2_-121035749
MiniDFA2_-121035749 -->|"[^*]"|MiniDFA2_-121035749
MiniDFA2_-121035749 -->|"*"|MiniDFA3_-1467565770
MiniDFA3_-1467565770 -->|"[^/]"|MiniDFA2_-121035749
MiniDFA3_-1467565770 -->|"/"|MiniDFA4_1921185818
```
-------------------------------
