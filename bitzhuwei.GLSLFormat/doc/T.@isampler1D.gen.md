# 'isampler1D'

pattern: `isampler1D`

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
eNFA133_20_26431778[["εNFA133-20 regex start"]]
eNFA133_0_36559414[["εNFA133-0 char{1, 1}"]]
eNFA133_1_60599278[["εNFA133-1 char[1]"]]
eNFA133_2_8522594[["εNFA133-2 char{1, 1}"]]
eNFA133_3_9594482[["εNFA133-3 char[1]"]]
eNFA133_4_19241481[["εNFA133-4 char{1, 1}"]]
eNFA133_5_38955607[["εNFA133-5 char[1]"]]
eNFA133_6_15056149[["εNFA133-6 char{1, 1}"]]
eNFA133_7_1287621[["εNFA133-7 char[1]"]]
eNFA133_8_11588590[["εNFA133-8 char{1, 1}"]]
eNFA133_9_37188451[["εNFA133-9 char[1]"]]
eNFA133_10_66260603[["εNFA133-10 char{1, 1}"]]
eNFA133_11_59474521[["εNFA133-11 char[1]"]]
eNFA133_12_65508645[["εNFA133-12 char{1, 1}"]]
eNFA133_13_52706896[["εNFA133-13 char[1]"]]
eNFA133_14_4600019[["εNFA133-14 char{1, 1}"]]
eNFA133_15_41400175[["εNFA133-15 char[1]"]]
eNFA133_16_37057262[["εNFA133-16 char{1, 1}"]]
eNFA133_17_65079903[["εNFA133-17 char[1]"]]
eNFA133_18_48848221[["εNFA133-18 char{1, 1}"]]
eNFA133_19_36980808[["εNFA133-19 char[1]"]]
eNFA133_21_64391817[["εNFA133-21 regex end"]]
eNFA133_22_42655441[["εNFA133-22 post-regex start"]]
eNFA133_23_48354649[\"εNFA133-23 post-regex end"/]
eNFA133_20_26431778 -.->|"ε"|eNFA133_0_36559414
eNFA133_0_36559414 -->|"i"|eNFA133_1_60599278
eNFA133_1_60599278 -.->|"ε"|eNFA133_2_8522594
eNFA133_2_8522594 -->|"s"|eNFA133_3_9594482
eNFA133_3_9594482 -.->|"ε"|eNFA133_4_19241481
eNFA133_4_19241481 -->|"a"|eNFA133_5_38955607
eNFA133_5_38955607 -.->|"ε"|eNFA133_6_15056149
eNFA133_6_15056149 -->|"m"|eNFA133_7_1287621
eNFA133_7_1287621 -.->|"ε"|eNFA133_8_11588590
eNFA133_8_11588590 -->|"p"|eNFA133_9_37188451
eNFA133_9_37188451 -.->|"ε"|eNFA133_10_66260603
eNFA133_10_66260603 -->|"l"|eNFA133_11_59474521
eNFA133_11_59474521 -.->|"ε"|eNFA133_12_65508645
eNFA133_12_65508645 -->|"e"|eNFA133_13_52706896
eNFA133_13_52706896 -.->|"ε"|eNFA133_14_4600019
eNFA133_14_4600019 -->|"r"|eNFA133_15_41400175
eNFA133_15_41400175 -.->|"ε"|eNFA133_16_37057262
eNFA133_16_37057262 -->|"1"|eNFA133_17_65079903
eNFA133_17_65079903 -.->|"ε"|eNFA133_18_48848221
eNFA133_18_48848221 -->|"D"|eNFA133_19_36980808
eNFA133_19_36980808 -.->|"ε"|eNFA133_21_64391817
eNFA133_21_64391817 -.->|"ε"|eNFA133_22_42655441
eNFA133_22_42655441 -.->|"ε"|eNFA133_23_48354649
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
eNFA133_20_32538658[["εNFA133-20 regex start"]]
eNFA133_0_24412469[["εNFA133-0 char{1, 1}"]]
eNFA133_1_18385636[["εNFA133-1 char[1]"]]
eNFA133_2_31252998[["εNFA133-2 char{1, 1}"]]
eNFA133_3_12841534[["εNFA133-3 char[1]"]]
eNFA133_4_48464948[["εNFA133-4 char{1, 1}"]]
eNFA133_5_33531353[["εNFA133-5 char[1]"]]
eNFA133_6_33346726[["εNFA133-6 char{1, 1}"]]
eNFA133_7_31685085[["εNFA133-7 char[1]"]]
eNFA133_8_16730309[["εNFA133-8 char{1, 1}"]]
eNFA133_9_16355056[["εNFA133-9 char[1]"]]
eNFA133_10_12977784[["εNFA133-10 char{1, 1}"]]
eNFA133_11_49691197[["εNFA133-11 char[1]"]]
eNFA133_12_44567592[["εNFA133-12 char{1, 1}"]]
eNFA133_13_65564010[["εNFA133-13 char[1]"]]
eNFA133_14_53205180[["εNFA133-14 char{1, 1}"]]
eNFA133_15_9084575[["εNFA133-15 char[1]"]]
eNFA133_16_14652317[["εNFA133-16 char{1, 1}"]]
eNFA133_17_64761989[["εNFA133-17 char[1]"]]
eNFA133_18_45986994[["εNFA133-18 char{1, 1}"]]
eNFA133_19_11229763[\"εNFA133-19 char[1]"/]
eNFA133_21_33959011[\"εNFA133-21 regex end"/]
eNFA133_22_37195650[\"εNFA133-22 post-regex start"/]
eNFA133_23_66325402[\"εNFA133-23 post-regex end"/]
eNFA133_20_32538658 -.->|"ε"|eNFA133_0_24412469
eNFA133_20_32538658 -->|"i"|eNFA133_1_18385636
eNFA133_0_24412469 -->|"i"|eNFA133_1_18385636
eNFA133_1_18385636 -.->|"ε"|eNFA133_2_31252998
eNFA133_1_18385636 -->|"s"|eNFA133_3_12841534
eNFA133_2_31252998 -->|"s"|eNFA133_3_12841534
eNFA133_3_12841534 -.->|"ε"|eNFA133_4_48464948
eNFA133_3_12841534 -->|"a"|eNFA133_5_33531353
eNFA133_4_48464948 -->|"a"|eNFA133_5_33531353
eNFA133_5_33531353 -.->|"ε"|eNFA133_6_33346726
eNFA133_5_33531353 -->|"m"|eNFA133_7_31685085
eNFA133_6_33346726 -->|"m"|eNFA133_7_31685085
eNFA133_7_31685085 -.->|"ε"|eNFA133_8_16730309
eNFA133_7_31685085 -->|"p"|eNFA133_9_16355056
eNFA133_8_16730309 -->|"p"|eNFA133_9_16355056
eNFA133_9_16355056 -.->|"ε"|eNFA133_10_12977784
eNFA133_9_16355056 -->|"l"|eNFA133_11_49691197
eNFA133_10_12977784 -->|"l"|eNFA133_11_49691197
eNFA133_11_49691197 -.->|"ε"|eNFA133_12_44567592
eNFA133_11_49691197 -->|"e"|eNFA133_13_65564010
eNFA133_12_44567592 -->|"e"|eNFA133_13_65564010
eNFA133_13_65564010 -.->|"ε"|eNFA133_14_53205180
eNFA133_13_65564010 -->|"r"|eNFA133_15_9084575
eNFA133_14_53205180 -->|"r"|eNFA133_15_9084575
eNFA133_15_9084575 -.->|"ε"|eNFA133_16_14652317
eNFA133_15_9084575 -->|"1"|eNFA133_17_64761989
eNFA133_16_14652317 -->|"1"|eNFA133_17_64761989
eNFA133_17_64761989 -.->|"ε"|eNFA133_18_45986994
eNFA133_17_64761989 -->|"D"|eNFA133_19_11229763
eNFA133_18_45986994 -->|"D"|eNFA133_19_11229763
eNFA133_19_11229763 -.->|"ε"|eNFA133_21_33959011
eNFA133_19_11229763 -.->|"ε"|eNFA133_22_37195650
eNFA133_19_11229763 -.->|"ε"|eNFA133_23_66325402
eNFA133_21_33959011 -.->|"ε"|eNFA133_22_37195650
eNFA133_21_33959011 -.->|"ε"|eNFA133_23_66325402
eNFA133_22_37195650 -.->|"ε"|eNFA133_23_66325402
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
NFA133_20_60057706("NFA133-20 regex start")
NFA133_1_3648444("NFA133-1 char[1]")
NFA133_3_32836002("NFA133-3 char[1]")
NFA133_5_27088563("NFA133-5 char[1]")
NFA133_7_42470482("NFA133-7 char[1]")
NFA133_9_46690023("NFA133-9 char[1]")
NFA133_11_17557027("NFA133-11 char[1]")
NFA133_13_23795519("NFA133-13 char[1]")
NFA133_15_12833084("NFA133-15 char[1]")
NFA133_17_48388900("NFA133-17 char[1]")
NFA133_19_32846918[\"NFA133-19 char[1]"/]
NFA133_20_60057706 -->|"i"|NFA133_1_3648444
NFA133_1_3648444 -->|"s"|NFA133_3_32836002
NFA133_3_32836002 -->|"a"|NFA133_5_27088563
NFA133_5_27088563 -->|"m"|NFA133_7_42470482
NFA133_7_42470482 -->|"p"|NFA133_9_46690023
NFA133_9_46690023 -->|"l"|NFA133_11_17557027
NFA133_11_17557027 -->|"e"|NFA133_13_23795519
NFA133_13_23795519 -->|"r"|NFA133_15_12833084
NFA133_15_12833084 -->|"1"|NFA133_17_48388900
NFA133_17_48388900 -->|"D"|NFA133_19_32846918
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
subgraph DFA0_1381359178["DFA0 regex start"]
NFA133_20_60057706_0("NFA133-20 regex start")
end
subgraph DFA1_-1742505414["DFA1 {1}"]
NFA133_1_3648444_1("NFA133-1 char[1]")
end
subgraph DFA2_-607700195["DFA2 {1}"]
NFA133_3_32836002_2("NFA133-3 char[1]")
end
subgraph DFA3_468877737["DFA3 {1}"]
NFA133_5_27088563_3("NFA133-5 char[1]")
end
subgraph DFA4_-534340185["DFA4 {1}"]
NFA133_7_42470482_4("NFA133-7 char[1]")
end
subgraph DFA5_1812541269["DFA5 {1}"]
NFA133_9_46690023_5("NFA133-9 char[1]")
end
subgraph DFA6_61502438["DFA6 {1}"]
NFA133_11_17557027_6("NFA133-11 char[1]")
end
subgraph DFA7_-302799188["DFA7 {1}"]
NFA133_13_23795519_7("NFA133-13 char[1]")
end
subgraph DFA8_1530564430["DFA8 {1}"]
NFA133_15_12833084_8("NFA133-15 char[1]")
end
subgraph DFA9_1264978946["DFA9 {1}"]
NFA133_17_48388900_9("NFA133-17 char[1]")
end
subgraph DFA10_-390422153["DFA10 {1}"]
NFA133_19_32846918_10[\"NFA133-19 char[1]"/]
end
DFA0_1381359178 -->|"i"|DFA1_-1742505414
DFA1_-1742505414 -->|"s"|DFA2_-607700195
DFA2_-607700195 -->|"a"|DFA3_468877737
DFA3_468877737 -->|"m"|DFA4_-534340185
DFA4_-534340185 -->|"p"|DFA5_1812541269
DFA5_1812541269 -->|"l"|DFA6_61502438
DFA6_61502438 -->|"e"|DFA7_-302799188
DFA7_-302799188 -->|"r"|DFA8_1530564430
DFA8_1530564430 -->|"1"|DFA9_1264978946
DFA9_1264978946 -->|"D"|DFA10_-390422153
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
DFA0_1381359178{{"DFA0 regex start"}}
DFA1_-1742505414{{"DFA1 {1}"}}
DFA2_-607700195{{"DFA2 {1}"}}
DFA3_468877737{{"DFA3 {1}"}}
DFA4_-534340185{{"DFA4 {1}"}}
DFA5_1812541269{{"DFA5 {1}"}}
DFA6_61502438{{"DFA6 {1}"}}
DFA7_-302799188{{"DFA7 {1}"}}
DFA8_1530564430{{"DFA8 {1}"}}
DFA9_1264978946{{"DFA9 {1}"}}
DFA10_-390422153[\"DFA10 {1}"/]
DFA0_1381359178 -->|"i"|DFA1_-1742505414
DFA1_-1742505414 -->|"s"|DFA2_-607700195
DFA2_-607700195 -->|"a"|DFA3_468877737
DFA3_468877737 -->|"m"|DFA4_-534340185
DFA4_-534340185 -->|"p"|DFA5_1812541269
DFA5_1812541269 -->|"l"|DFA6_61502438
DFA6_61502438 -->|"e"|DFA7_-302799188
DFA7_-302799188 -->|"r"|DFA8_1530564430
DFA8_1530564430 -->|"1"|DFA9_1264978946
DFA9_1264978946 -->|"D"|DFA10_-390422153
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
subgraph MiniDFA0_195098842["MiniDFA0 {1}"]
DFA0_1381359178_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_57087439["MiniDFA1 {1}"]
DFA1_-1742505414_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1449554407["MiniDFA2 {1}"]
DFA2_-607700195_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-587119185["MiniDFA3 {1}"]
DFA3_468877737_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1032171775["MiniDFA4 {1}"]
DFA4_-534340185_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1640024969["MiniDFA5 {1}"]
DFA5_1812541269_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1954561588["MiniDFA6 {1}"]
DFA6_61502438_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1288780244["MiniDFA7 {1}"]
DFA7_-302799188_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_132891221["MiniDFA8 {1}"]
DFA8_1530564430_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_1452647083["MiniDFA9 {1}"]
DFA9_1264978946_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1287554799["MiniDFA10 {1}"]
DFA10_-390422153_10[\"DFA10 {1}"/]
end
MiniDFA0_195098842 -->|"i"|MiniDFA1_57087439
MiniDFA1_57087439 -->|"s"|MiniDFA2_1449554407
MiniDFA2_1449554407 -->|"a"|MiniDFA3_-587119185
MiniDFA3_-587119185 -->|"m"|MiniDFA4_1032171775
MiniDFA4_1032171775 -->|"p"|MiniDFA5_1640024969
MiniDFA5_1640024969 -->|"l"|MiniDFA6_1954561588
MiniDFA6_1954561588 -->|"e"|MiniDFA7_1288780244
MiniDFA7_1288780244 -->|"r"|MiniDFA8_132891221
MiniDFA8_132891221 -->|"1"|MiniDFA9_1452647083
MiniDFA9_1452647083 -->|"D"|MiniDFA10_-1287554799
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
MiniDFA0_195098842(["MiniDFA0 {1}"])
MiniDFA1_57087439(["MiniDFA1 {1}"])
MiniDFA2_1449554407(["MiniDFA2 {1}"])
MiniDFA3_-587119185(["MiniDFA3 {1}"])
MiniDFA4_1032171775(["MiniDFA4 {1}"])
MiniDFA5_1640024969(["MiniDFA5 {1}"])
MiniDFA6_1954561588(["MiniDFA6 {1}"])
MiniDFA7_1288780244(["MiniDFA7 {1}"])
MiniDFA8_132891221(["MiniDFA8 {1}"])
MiniDFA9_1452647083(["MiniDFA9 {1}"])
MiniDFA10_-1287554799[\"MiniDFA10 {1}"/]
MiniDFA0_195098842 -->|"i"|MiniDFA1_57087439
MiniDFA1_57087439 -->|"s"|MiniDFA2_1449554407
MiniDFA2_1449554407 -->|"a"|MiniDFA3_-587119185
MiniDFA3_-587119185 -->|"m"|MiniDFA4_1032171775
MiniDFA4_1032171775 -->|"p"|MiniDFA5_1640024969
MiniDFA5_1640024969 -->|"l"|MiniDFA6_1954561588
MiniDFA6_1954561588 -->|"e"|MiniDFA7_1288780244
MiniDFA7_1288780244 -->|"r"|MiniDFA8_132891221
MiniDFA8_132891221 -->|"1"|MiniDFA9_1452647083
MiniDFA9_1452647083 -->|"D"|MiniDFA10_-1287554799
```
-------------------------------
