# 'mat3x4'

pattern: `mat3x4`

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
eNFA103_12_1509928[["εNFA103-12 regex start"]]
eNFA103_0_13589360[["εNFA103-0 char{1, 1}"]]
eNFA103_1_55195381[["εNFA103-1 char[1]"]]
eNFA103_2_26996384[["εNFA103-2 char{1, 1}"]]
eNFA103_3_41640866[["εNFA103-3 char[1]"]]
eNFA103_4_39223476[["εNFA103-4 char{1, 1}"]]
eNFA103_5_17466967[["εNFA103-5 char[1]"]]
eNFA103_6_22984981[["εNFA103-6 char{1, 1}"]]
eNFA103_7_5538237[["εNFA103-7 char[1]"]]
eNFA103_8_49844138[["εNFA103-8 char{1, 1}"]]
eNFA103_9_45944059[["εNFA103-9 char[1]"]]
eNFA103_10_10843355[["εNFA103-10 char{1, 1}"]]
eNFA103_11_30481338[["εNFA103-11 char[1]"]]
eNFA103_13_5896594[["εNFA103-13 regex end"]]
eNFA103_14_53069346[["εNFA103-14 post-regex start"]]
eNFA103_15_7862068[\"εNFA103-15 post-regex end"/]
eNFA103_12_1509928 -.->|"ε"|eNFA103_0_13589360
eNFA103_0_13589360 -->|"m"|eNFA103_1_55195381
eNFA103_1_55195381 -.->|"ε"|eNFA103_2_26996384
eNFA103_2_26996384 -->|"a"|eNFA103_3_41640866
eNFA103_3_41640866 -.->|"ε"|eNFA103_4_39223476
eNFA103_4_39223476 -->|"t"|eNFA103_5_17466967
eNFA103_5_17466967 -.->|"ε"|eNFA103_6_22984981
eNFA103_6_22984981 -->|"3"|eNFA103_7_5538237
eNFA103_7_5538237 -.->|"ε"|eNFA103_8_49844138
eNFA103_8_49844138 -->|"x"|eNFA103_9_45944059
eNFA103_9_45944059 -.->|"ε"|eNFA103_10_10843355
eNFA103_10_10843355 -->|"4"|eNFA103_11_30481338
eNFA103_11_30481338 -.->|"ε"|eNFA103_13_5896594
eNFA103_13_5896594 -.->|"ε"|eNFA103_14_53069346
eNFA103_14_53069346 -.->|"ε"|eNFA103_15_7862068
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
eNFA103_12_3649754[["εNFA103-12 regex start"]]
eNFA103_0_32847787[["εNFA103-0 char{1, 1}"]]
eNFA103_1_27194634[["εNFA103-1 char[1]"]]
eNFA103_2_43425119[["εNFA103-2 char{1, 1}"]]
eNFA103_3_55281755[["εNFA103-3 char[1]"]]
eNFA103_4_27773751[["εNFA103-4 char{1, 1}"]]
eNFA103_5_48637172[["εNFA103-5 char[1]"]]
eNFA103_6_35081372[["εNFA103-6 char{1, 1}"]]
eNFA103_7_47296894[["εNFA103-7 char[1]"]]
eNFA103_8_23018869[["εNFA103-8 char{1, 1}"]]
eNFA103_9_5843233[["εNFA103-9 char[1]"]]
eNFA103_10_52589099[["εNFA103-10 char{1, 1}"]]
eNFA103_11_3539844[\"εNFA103-11 char[1]"/]
eNFA103_13_31858597[\"εNFA103-13 regex end"/]
eNFA103_14_18291919[\"εNFA103-14 post-regex start"/]
eNFA103_15_30409547[\"εNFA103-15 post-regex end"/]
eNFA103_12_3649754 -.->|"ε"|eNFA103_0_32847787
eNFA103_12_3649754 -->|"m"|eNFA103_1_27194634
eNFA103_0_32847787 -->|"m"|eNFA103_1_27194634
eNFA103_1_27194634 -.->|"ε"|eNFA103_2_43425119
eNFA103_1_27194634 -->|"a"|eNFA103_3_55281755
eNFA103_2_43425119 -->|"a"|eNFA103_3_55281755
eNFA103_3_55281755 -.->|"ε"|eNFA103_4_27773751
eNFA103_3_55281755 -->|"t"|eNFA103_5_48637172
eNFA103_4_27773751 -->|"t"|eNFA103_5_48637172
eNFA103_5_48637172 -.->|"ε"|eNFA103_6_35081372
eNFA103_5_48637172 -->|"3"|eNFA103_7_47296894
eNFA103_6_35081372 -->|"3"|eNFA103_7_47296894
eNFA103_7_47296894 -.->|"ε"|eNFA103_8_23018869
eNFA103_7_47296894 -->|"x"|eNFA103_9_5843233
eNFA103_8_23018869 -->|"x"|eNFA103_9_5843233
eNFA103_9_5843233 -.->|"ε"|eNFA103_10_52589099
eNFA103_9_5843233 -->|"4"|eNFA103_11_3539844
eNFA103_10_52589099 -->|"4"|eNFA103_11_3539844
eNFA103_11_3539844 -.->|"ε"|eNFA103_13_31858597
eNFA103_11_3539844 -.->|"ε"|eNFA103_14_18291919
eNFA103_11_3539844 -.->|"ε"|eNFA103_15_30409547
eNFA103_13_31858597 -.->|"ε"|eNFA103_14_18291919
eNFA103_13_31858597 -.->|"ε"|eNFA103_15_30409547
eNFA103_14_18291919 -.->|"ε"|eNFA103_15_30409547
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
NFA103_12_5250475("NFA103-12 regex start")
NFA103_1_47254279("NFA103-1 char[1]")
NFA103_3_22635327("NFA103-3 char[1]")
NFA103_5_2391358("NFA103-5 char[1]")
NFA103_7_21522228("NFA103-7 char[1]")
NFA103_9_59482330("NFA103-9 char[1]")
NFA103_11_65578930[\"NFA103-11 char[1]"/]
NFA103_12_5250475 -->|"m"|NFA103_1_47254279
NFA103_1_47254279 -->|"a"|NFA103_3_22635327
NFA103_3_22635327 -->|"t"|NFA103_5_2391358
NFA103_5_2391358 -->|"3"|NFA103_7_21522228
NFA103_7_21522228 -->|"x"|NFA103_9_59482330
NFA103_9_59482330 -->|"4"|NFA103_11_65578930
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
subgraph DFA0_633843010["DFA0 regex start"]
NFA103_12_5250475_0("NFA103-12 regex start")
end
subgraph DFA1_-842646989["DFA1 {1}"]
NFA103_1_47254279_1("NFA103-1 char[1]")
end
subgraph DFA2_526130285["DFA2 {1}"]
NFA103_3_22635327_2("NFA103-3 char[1]")
end
subgraph DFA3_1916288539["DFA3 {1}"]
NFA103_5_2391358_3("NFA103-5 char[1]")
end
subgraph DFA4_-187886137["DFA4 {1}"]
NFA103_7_21522228_4("NFA103-7 char[1]")
end
subgraph DFA5_-787445806["DFA5 {1}"]
NFA103_9_59482330_5("NFA103-9 char[1]")
end
subgraph DFA6_1487589970["DFA6 {1}"]
NFA103_11_65578930_6[\"NFA103-11 char[1]"/]
end
DFA0_633843010 -->|"m"|DFA1_-842646989
DFA1_-842646989 -->|"a"|DFA2_526130285
DFA2_526130285 -->|"t"|DFA3_1916288539
DFA3_1916288539 -->|"3"|DFA4_-187886137
DFA4_-187886137 -->|"x"|DFA5_-787445806
DFA5_-787445806 -->|"4"|DFA6_1487589970
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
DFA0_633843010{{"DFA0 regex start"}}
DFA1_-842646989{{"DFA1 {1}"}}
DFA2_526130285{{"DFA2 {1}"}}
DFA3_1916288539{{"DFA3 {1}"}}
DFA4_-187886137{{"DFA4 {1}"}}
DFA5_-787445806{{"DFA5 {1}"}}
DFA6_1487589970[\"DFA6 {1}"/]
DFA0_633843010 -->|"m"|DFA1_-842646989
DFA1_-842646989 -->|"a"|DFA2_526130285
DFA2_526130285 -->|"t"|DFA3_1916288539
DFA3_1916288539 -->|"3"|DFA4_-187886137
DFA4_-187886137 -->|"x"|DFA5_-787445806
DFA5_-787445806 -->|"4"|DFA6_1487589970
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
subgraph MiniDFA0_1098819475["MiniDFA0 {1}"]
DFA0_633843010_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-180910057["MiniDFA1 {1}"]
DFA1_-842646989_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_181894220["MiniDFA2 {1}"]
DFA2_526130285_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1147601228["MiniDFA3 {1}"]
DFA3_1916288539_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-609503423["MiniDFA4 {1}"]
DFA4_-187886137_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_2101935768["MiniDFA5 {1}"]
DFA5_-787445806_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-735697034["MiniDFA6 {1}"]
DFA6_1487589970_6[\"DFA6 {1}"/]
end
MiniDFA0_1098819475 -->|"m"|MiniDFA1_-180910057
MiniDFA1_-180910057 -->|"a"|MiniDFA2_181894220
MiniDFA2_181894220 -->|"t"|MiniDFA3_-1147601228
MiniDFA3_-1147601228 -->|"3"|MiniDFA4_-609503423
MiniDFA4_-609503423 -->|"x"|MiniDFA5_2101935768
MiniDFA5_2101935768 -->|"4"|MiniDFA6_-735697034
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
MiniDFA0_1098819475(["MiniDFA0 {1}"])
MiniDFA1_-180910057(["MiniDFA1 {1}"])
MiniDFA2_181894220(["MiniDFA2 {1}"])
MiniDFA3_-1147601228(["MiniDFA3 {1}"])
MiniDFA4_-609503423(["MiniDFA4 {1}"])
MiniDFA5_2101935768(["MiniDFA5 {1}"])
MiniDFA6_-735697034[\"MiniDFA6 {1}"/]
MiniDFA0_1098819475 -->|"m"|MiniDFA1_-180910057
MiniDFA1_-180910057 -->|"a"|MiniDFA2_181894220
MiniDFA2_181894220 -->|"t"|MiniDFA3_-1147601228
MiniDFA3_-1147601228 -->|"3"|MiniDFA4_-609503423
MiniDFA4_-609503423 -->|"x"|MiniDFA5_2101935768
MiniDFA5_2101935768 -->|"4"|MiniDFA6_-735697034
```
-------------------------------
