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
eNFA8_16_56751409[["εNFA8-16 regex start"]]
eNFA8_0_41000636[["εNFA8-0 char{1, 1}"]]
eNFA8_1_33461405[["εNFA8-1 char[1]"]]
eNFA8_2_32717189[["εNFA8-2 char{1, 1}"]]
eNFA8_3_16041657[["εNFA8-3 char[1]"]]
eNFA8_6_53371190[["εNFA8-6 regex start"]]
eNFA8_4_28099101[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_10578662[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_51565323[["εNFA8-7 regex end"]]
eNFA8_5_24305815[["εNFA8-5 scope[1]"]]
eNFA8_9_54426330[["εNFA8-9 scope[1]"]]
eNFA8_12_10157186[["εNFA8-12 char{1, 1}"]]
eNFA8_10_4892154[["εNFA8-10 scope{1, 1}"]]
eNFA8_13_44029393[["εNFA8-13 char[1]"]]
eNFA8_11_19791876[["εNFA8-11 scope[1]"]]
eNFA8_14_60720217[["εNFA8-14 char{1, 1}"]]
eNFA8_15_19390540[["εNFA8-15 char[1]"]]
eNFA8_17_40297137[["εNFA8-17 regex end"]]
eNFA8_18_27129916[["εNFA8-18 post-regex start"]]
eNFA8_19_42842654[\"εNFA8-19 post-regex end"/]
eNFA8_16_56751409 -.->|"ε"|eNFA8_0_41000636
eNFA8_0_41000636 -->|"/"|eNFA8_1_33461405
eNFA8_1_33461405 -.->|"ε"|eNFA8_2_32717189
eNFA8_2_32717189 -->|"*"|eNFA8_3_16041657
eNFA8_3_16041657 -.->|"ε"|eNFA8_6_53371190
eNFA8_6_53371190 -.->|"ε"|eNFA8_4_28099101
eNFA8_6_53371190 -.->|"ε"|eNFA8_8_10578662
eNFA8_6_53371190 -.->|"ε"|eNFA8_7_51565323
eNFA8_4_28099101 -->|"[^*]"|eNFA8_5_24305815
eNFA8_8_10578662 -->|"[*]"|eNFA8_9_54426330
eNFA8_7_51565323 -.->|"ε"|eNFA8_6_53371190
eNFA8_7_51565323 -.->|"ε"|eNFA8_12_10157186
eNFA8_5_24305815 -.->|"ε"|eNFA8_7_51565323
eNFA8_9_54426330 -.->|"ε"|eNFA8_10_4892154
eNFA8_12_10157186 -->|"*"|eNFA8_13_44029393
eNFA8_10_4892154 -->|"[^/]"|eNFA8_11_19791876
eNFA8_13_44029393 -.->|"ε"|eNFA8_14_60720217
eNFA8_11_19791876 -.->|"ε"|eNFA8_7_51565323
eNFA8_14_60720217 -->|"/"|eNFA8_15_19390540
eNFA8_15_19390540 -.->|"ε"|eNFA8_17_40297137
eNFA8_17_40297137 -.->|"ε"|eNFA8_18_27129916
eNFA8_18_27129916 -.->|"ε"|eNFA8_19_42842654
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
eNFA8_16_50039568[["εNFA8-16 regex start"]]
eNFA8_0_47702931[["εNFA8-0 char{1, 1}"]]
eNFA8_1_26673201[["εNFA8-1 char[1]"]]
eNFA8_2_38732217[["εNFA8-2 char{1, 1}"]]
eNFA8_3_20074930[["εNFA8-3 char[1]"]]
eNFA8_6_26019245[["εNFA8-6 regex start"]]
eNFA8_4_27184073[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_32846614[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_43330072[["εNFA8-7 regex end"]]
eNFA8_5_15456653[["εNFA8-5 scope[1]"]]
eNFA8_9_13045638[["εNFA8-9 scope[1]"]]
eNFA8_12_46456648[["εNFA8-12 char{1, 1}"]]
eNFA8_13_50063735[["εNFA8-13 char[1]"]]
eNFA8_10_50301879[["εNFA8-10 scope{1, 1}"]]
eNFA8_11_9611044[["εNFA8-11 scope[1]"]]
eNFA8_14_47920438[["εNFA8-14 char{1, 1}"]]
eNFA8_15_28630766[\"εNFA8-15 char[1]"/]
eNFA8_17_56350302[\"εNFA8-17 regex end"/]
eNFA8_18_37390672[\"εNFA8-18 post-regex start"/]
eNFA8_19_971734[\"εNFA8-19 post-regex end"/]
eNFA8_16_50039568 -.->|"ε"|eNFA8_0_47702931
eNFA8_16_50039568 -->|"/"|eNFA8_1_26673201
eNFA8_0_47702931 -->|"/"|eNFA8_1_26673201
eNFA8_1_26673201 -.->|"ε"|eNFA8_2_38732217
eNFA8_1_26673201 -->|"*"|eNFA8_3_20074930
eNFA8_2_38732217 -->|"*"|eNFA8_3_20074930
eNFA8_3_20074930 -.->|"ε"|eNFA8_6_26019245
eNFA8_3_20074930 -.->|"ε"|eNFA8_4_27184073
eNFA8_3_20074930 -.->|"ε"|eNFA8_8_32846614
eNFA8_3_20074930 -.->|"ε"|eNFA8_7_43330072
eNFA8_3_20074930 -->|"[^*]"|eNFA8_5_15456653
eNFA8_3_20074930 -->|"[*]"|eNFA8_9_13045638
eNFA8_3_20074930 -.->|"ε"|eNFA8_12_46456648
eNFA8_3_20074930 -->|"*"|eNFA8_13_50063735
eNFA8_6_26019245 -.->|"ε"|eNFA8_4_27184073
eNFA8_6_26019245 -.->|"ε"|eNFA8_8_32846614
eNFA8_6_26019245 -.->|"ε"|eNFA8_7_43330072
eNFA8_6_26019245 -->|"[^*]"|eNFA8_5_15456653
eNFA8_6_26019245 -->|"[*]"|eNFA8_9_13045638
eNFA8_6_26019245 -.->|"ε"|eNFA8_6_26019245
eNFA8_6_26019245 -.->|"ε"|eNFA8_12_46456648
eNFA8_6_26019245 -->|"*"|eNFA8_13_50063735
eNFA8_4_27184073 -->|"[^*]"|eNFA8_5_15456653
eNFA8_8_32846614 -->|"[*]"|eNFA8_9_13045638
eNFA8_7_43330072 -.->|"ε"|eNFA8_6_26019245
eNFA8_7_43330072 -.->|"ε"|eNFA8_12_46456648
eNFA8_7_43330072 -.->|"ε"|eNFA8_4_27184073
eNFA8_7_43330072 -.->|"ε"|eNFA8_8_32846614
eNFA8_7_43330072 -.->|"ε"|eNFA8_7_43330072
eNFA8_7_43330072 -->|"[^*]"|eNFA8_5_15456653
eNFA8_7_43330072 -->|"[*]"|eNFA8_9_13045638
eNFA8_7_43330072 -->|"*"|eNFA8_13_50063735
eNFA8_5_15456653 -.->|"ε"|eNFA8_7_43330072
eNFA8_5_15456653 -.->|"ε"|eNFA8_6_26019245
eNFA8_5_15456653 -.->|"ε"|eNFA8_12_46456648
eNFA8_5_15456653 -.->|"ε"|eNFA8_4_27184073
eNFA8_5_15456653 -.->|"ε"|eNFA8_8_32846614
eNFA8_5_15456653 -->|"[^*]"|eNFA8_5_15456653
eNFA8_5_15456653 -->|"[*]"|eNFA8_9_13045638
eNFA8_5_15456653 -->|"*"|eNFA8_13_50063735
eNFA8_9_13045638 -.->|"ε"|eNFA8_10_50301879
eNFA8_9_13045638 -->|"[^/]"|eNFA8_11_9611044
eNFA8_12_46456648 -->|"*"|eNFA8_13_50063735
eNFA8_13_50063735 -.->|"ε"|eNFA8_14_47920438
eNFA8_13_50063735 -->|"/"|eNFA8_15_28630766
eNFA8_10_50301879 -->|"[^/]"|eNFA8_11_9611044
eNFA8_11_9611044 -.->|"ε"|eNFA8_7_43330072
eNFA8_11_9611044 -.->|"ε"|eNFA8_6_26019245
eNFA8_11_9611044 -.->|"ε"|eNFA8_12_46456648
eNFA8_11_9611044 -.->|"ε"|eNFA8_4_27184073
eNFA8_11_9611044 -.->|"ε"|eNFA8_8_32846614
eNFA8_11_9611044 -->|"[^*]"|eNFA8_5_15456653
eNFA8_11_9611044 -->|"[*]"|eNFA8_9_13045638
eNFA8_11_9611044 -->|"*"|eNFA8_13_50063735
eNFA8_14_47920438 -->|"/"|eNFA8_15_28630766
eNFA8_15_28630766 -.->|"ε"|eNFA8_17_56350302
eNFA8_15_28630766 -.->|"ε"|eNFA8_18_37390672
eNFA8_15_28630766 -.->|"ε"|eNFA8_19_971734
eNFA8_17_56350302 -.->|"ε"|eNFA8_18_37390672
eNFA8_17_56350302 -.->|"ε"|eNFA8_19_971734
eNFA8_18_37390672 -.->|"ε"|eNFA8_19_971734
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
NFA8_16_16689200("NFA8-16 regex start")
NFA8_1_15985080("NFA8-1 char[1]")
NFA8_3_8745607("NFA8-3 char[1]")
NFA8_5_37305595("NFA8-5 scope[1]")
NFA8_9_11601606("NFA8-9 scope[1]")
NFA8_13_206039("NFA8-13 char[1]")
NFA8_11_1854355("NFA8-11 scope[1]")
NFA8_15_9647994[\"NFA8-15 char[1]"/]
NFA8_16_16689200 -->|"/"|NFA8_1_15985080
NFA8_1_15985080 -->|"*"|NFA8_3_8745607
NFA8_3_8745607 -->|"[^*]"|NFA8_5_37305595
NFA8_3_8745607 -->|"[*]"|NFA8_9_11601606
NFA8_3_8745607 -->|"*"|NFA8_13_206039
NFA8_5_37305595 -->|"[^*]"|NFA8_5_37305595
NFA8_5_37305595 -->|"[*]"|NFA8_9_11601606
NFA8_5_37305595 -->|"*"|NFA8_13_206039
NFA8_9_11601606 -->|"[^/]"|NFA8_11_1854355
NFA8_13_206039 -->|"/"|NFA8_15_9647994
NFA8_11_1854355 -->|"[^*]"|NFA8_5_37305595
NFA8_11_1854355 -->|"[*]"|NFA8_9_11601606
NFA8_11_1854355 -->|"*"|NFA8_13_206039
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
subgraph DFA0_2090930652["DFA0 regex start"]
NFA8_16_16689200_0("NFA8-16 regex start")
end
subgraph DFA1_1588898329["DFA1 {1}"]
NFA8_1_15985080_1("NFA8-1 char[1]")
end
subgraph DFA2_777402519["DFA2 {1}"]
NFA8_3_8745607_2("NFA8-3 char[1]")
end
subgraph DFA3_1976801609["DFA3 {1}"]
NFA8_5_37305595_3("NFA8-5 scope[1]")
end
subgraph DFA4_865486367["DFA4 {2}"]
NFA8_9_11601606_4("NFA8-9 scope[1]")
NFA8_13_206039_5("NFA8-13 char[1]")
end
subgraph DFA5_274902443["DFA5 {1}"]
NFA8_11_1854355_6("NFA8-11 scope[1]")
end
subgraph DFA6_-268200105["DFA6 {1}"]
NFA8_15_9647994_7[\"NFA8-15 char[1]"/]
end
DFA0_2090930652 -->|"/"|DFA1_1588898329
DFA1_1588898329 -->|"*"|DFA2_777402519
DFA2_777402519 -->|"[^*]"|DFA3_1976801609
DFA2_777402519 -->|"*"|DFA4_865486367
DFA3_1976801609 -->|"[^*]"|DFA3_1976801609
DFA3_1976801609 -->|"*"|DFA4_865486367
DFA4_865486367 -->|"[^/]"|DFA5_274902443
DFA4_865486367 -->|"/"|DFA6_-268200105
DFA5_274902443 -->|"[^*]"|DFA3_1976801609
DFA5_274902443 -->|"*"|DFA4_865486367
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
DFA0_2090930652{{"DFA0 regex start"}}
DFA1_1588898329{{"DFA1 {1}"}}
DFA2_777402519{{"DFA2 {1}"}}
DFA3_1976801609{{"DFA3 {1}"}}
DFA4_865486367{{"DFA4 {2}"}}
DFA5_274902443{{"DFA5 {1}"}}
DFA6_-268200105[\"DFA6 {1}"/]
DFA0_2090930652 -->|"/"|DFA1_1588898329
DFA1_1588898329 -->|"*"|DFA2_777402519
DFA2_777402519 -->|"[^*]"|DFA3_1976801609
DFA2_777402519 -->|"*"|DFA4_865486367
DFA3_1976801609 -->|"[^*]"|DFA3_1976801609
DFA3_1976801609 -->|"*"|DFA4_865486367
DFA4_865486367 -->|"[^/]"|DFA5_274902443
DFA4_865486367 -->|"/"|DFA6_-268200105
DFA5_274902443 -->|"[^*]"|DFA3_1976801609
DFA5_274902443 -->|"*"|DFA4_865486367
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
subgraph MiniDFA0_1811131740["MiniDFA0 {1}"]
DFA0_2090930652_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1787852811["MiniDFA1 {1}"]
DFA1_1588898329_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2102173254["MiniDFA2 {3}"]
DFA2_777402519_2{{"DFA2 {1}"}}
DFA3_1976801609_3{{"DFA3 {1}"}}
DFA5_274902443_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_849359870["MiniDFA3 {1}"]
DFA4_865486367_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-841559429["MiniDFA4 {1}"]
DFA6_-268200105_6[\"DFA6 {1}"/]
end
MiniDFA0_1811131740 -->|"/"|MiniDFA1_1787852811
MiniDFA1_1787852811 -->|"*"|MiniDFA2_-2102173254
MiniDFA2_-2102173254 -->|"[^*]"|MiniDFA2_-2102173254
MiniDFA2_-2102173254 -->|"*"|MiniDFA3_849359870
MiniDFA3_849359870 -->|"[^/]"|MiniDFA2_-2102173254
MiniDFA3_849359870 -->|"/"|MiniDFA4_-841559429
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
MiniDFA0_1811131740(["MiniDFA0 {1}"])
MiniDFA1_1787852811(["MiniDFA1 {1}"])
MiniDFA2_-2102173254(["MiniDFA2 {3}"])
MiniDFA3_849359870(["MiniDFA3 {1}"])
MiniDFA4_-841559429[\"MiniDFA4 {1}"/]
MiniDFA0_1811131740 -->|"/"|MiniDFA1_1787852811
MiniDFA1_1787852811 -->|"*"|MiniDFA2_-2102173254
MiniDFA2_-2102173254 -->|"[^*]"|MiniDFA2_-2102173254
MiniDFA2_-2102173254 -->|"*"|MiniDFA3_849359870
MiniDFA3_849359870 -->|"[^/]"|MiniDFA2_-2102173254
MiniDFA3_849359870 -->|"/"|MiniDFA4_-841559429
```
-------------------------------
