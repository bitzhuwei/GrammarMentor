# 'imageBuffer'

pattern: `imageBuffer`

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
eNFA175_22_51727075[["εNFA175-22 regex start"]]
eNFA175_0_62890495[["εNFA175-0 char{1, 1}"]]
eNFA175_1_29143545[["εNFA175-1 char[1]"]]
eNFA175_2_60965314[["εNFA175-2 char{1, 1}"]]
eNFA175_3_11816915[["εNFA175-3 char[1]"]]
eNFA175_4_39243373[["εNFA175-4 char{1, 1}"]]
eNFA175_5_17646041[["εNFA175-5 char[1]"]]
eNFA175_6_24596649[["εNFA175-6 char{1, 1}"]]
eNFA175_7_20043253[["εNFA175-7 char[1]"]]
eNFA175_8_46171549[["εNFA175-8 char{1, 1}"]]
eNFA175_9_12890764[["εNFA175-9 char[1]"]]
eNFA175_10_48908018[["εNFA175-10 char{1, 1}"]]
eNFA175_11_37518984[["εNFA175-11 char[1]"]]
eNFA175_12_2126544[["εNFA175-12 char{1, 1}"]]
eNFA175_13_19138897[["εNFA175-13 char[1]"]]
eNFA175_14_38032350[["εNFA175-14 char{1, 1}"]]
eNFA175_15_6746830[["εNFA175-15 char[1]"]]
eNFA175_16_60721476[["εNFA175-16 char{1, 1}"]]
eNFA175_17_9622376[["εNFA175-17 char[1]"]]
eNFA175_18_19492523[["εNFA175-18 char{1, 1}"]]
eNFA175_19_41214982[["εNFA175-19 char[1]"]]
eNFA175_20_35390522[["εNFA175-20 char{1, 1}"]]
eNFA175_21_50079249[["εNFA175-21 char[1]"]]
eNFA175_23_48060058[["εNFA175-23 regex end"]]
eNFA175_24_29887344[["εNFA175-24 post-regex start"]]
eNFA175_25_550643[\"εNFA175-25 post-regex end"/]
eNFA175_22_51727075 -.->|"ε"|eNFA175_0_62890495
eNFA175_0_62890495 -->|"i"|eNFA175_1_29143545
eNFA175_1_29143545 -.->|"ε"|eNFA175_2_60965314
eNFA175_2_60965314 -->|"m"|eNFA175_3_11816915
eNFA175_3_11816915 -.->|"ε"|eNFA175_4_39243373
eNFA175_4_39243373 -->|"a"|eNFA175_5_17646041
eNFA175_5_17646041 -.->|"ε"|eNFA175_6_24596649
eNFA175_6_24596649 -->|"g"|eNFA175_7_20043253
eNFA175_7_20043253 -.->|"ε"|eNFA175_8_46171549
eNFA175_8_46171549 -->|"e"|eNFA175_9_12890764
eNFA175_9_12890764 -.->|"ε"|eNFA175_10_48908018
eNFA175_10_48908018 -->|"B"|eNFA175_11_37518984
eNFA175_11_37518984 -.->|"ε"|eNFA175_12_2126544
eNFA175_12_2126544 -->|"u"|eNFA175_13_19138897
eNFA175_13_19138897 -.->|"ε"|eNFA175_14_38032350
eNFA175_14_38032350 -->|"f"|eNFA175_15_6746830
eNFA175_15_6746830 -.->|"ε"|eNFA175_16_60721476
eNFA175_16_60721476 -->|"f"|eNFA175_17_9622376
eNFA175_17_9622376 -.->|"ε"|eNFA175_18_19492523
eNFA175_18_19492523 -->|"e"|eNFA175_19_41214982
eNFA175_19_41214982 -.->|"ε"|eNFA175_20_35390522
eNFA175_20_35390522 -->|"r"|eNFA175_21_50079249
eNFA175_21_50079249 -.->|"ε"|eNFA175_23_48060058
eNFA175_23_48060058 -.->|"ε"|eNFA175_24_29887344
eNFA175_24_29887344 -.->|"ε"|eNFA175_25_550643
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
eNFA175_22_4955788[["εNFA175-22 regex start"]]
eNFA175_0_44602092[["εNFA175-0 char{1, 1}"]]
eNFA175_1_65874508[["εNFA175-1 char[1]"]]
eNFA175_2_55999661[["εNFA175-2 char{1, 1}"]]
eNFA175_3_34234904[["εNFA175-3 char[1]"]]
eNFA175_4_39678687[["εNFA175-4 char{1, 1}"]]
eNFA175_5_21563865[["εNFA175-5 char[1]"]]
eNFA175_6_59857065[["εNFA175-6 char{1, 1}"]]
eNFA175_7_1842679[["εNFA175-7 char[1]"]]
eNFA175_8_16584116[["εNFA175-8 char{1, 1}"]]
eNFA175_9_15039321[["εNFA175-9 char[1]"]]
eNFA175_10_1136168[["εNFA175-10 char{1, 1}"]]
eNFA175_11_10225512[["εNFA175-11 char[1]"]]
eNFA175_12_24920747[["εNFA175-12 char{1, 1}"]]
eNFA175_13_22960139[["εNFA175-13 char[1]"]]
eNFA175_14_5314664[["εNFA175-14 char{1, 1}"]]
eNFA175_15_47831979[["εNFA175-15 char[1]"]]
eNFA175_16_27834629[["εNFA175-16 char{1, 1}"]]
eNFA175_17_49185071[["εNFA175-17 char[1]"]]
eNFA175_18_40012458[["εNFA175-18 char{1, 1}"]]
eNFA175_19_24567808[["εNFA175-19 char[1]"]]
eNFA175_20_19783680[["εNFA175-20 char{1, 1}"]]
eNFA175_21_43835397[\"εNFA175-21 char[1]"/]
eNFA175_23_58974254[\"εNFA175-23 regex end"/]
eNFA175_24_61006246[\"εNFA175-24 post-regex start"/]
eNFA175_25_12185309[\"εNFA175-25 post-regex end"/]
eNFA175_22_4955788 -.->|"ε"|eNFA175_0_44602092
eNFA175_22_4955788 -->|"i"|eNFA175_1_65874508
eNFA175_0_44602092 -->|"i"|eNFA175_1_65874508
eNFA175_1_65874508 -.->|"ε"|eNFA175_2_55999661
eNFA175_1_65874508 -->|"m"|eNFA175_3_34234904
eNFA175_2_55999661 -->|"m"|eNFA175_3_34234904
eNFA175_3_34234904 -.->|"ε"|eNFA175_4_39678687
eNFA175_3_34234904 -->|"a"|eNFA175_5_21563865
eNFA175_4_39678687 -->|"a"|eNFA175_5_21563865
eNFA175_5_21563865 -.->|"ε"|eNFA175_6_59857065
eNFA175_5_21563865 -->|"g"|eNFA175_7_1842679
eNFA175_6_59857065 -->|"g"|eNFA175_7_1842679
eNFA175_7_1842679 -.->|"ε"|eNFA175_8_16584116
eNFA175_7_1842679 -->|"e"|eNFA175_9_15039321
eNFA175_8_16584116 -->|"e"|eNFA175_9_15039321
eNFA175_9_15039321 -.->|"ε"|eNFA175_10_1136168
eNFA175_9_15039321 -->|"B"|eNFA175_11_10225512
eNFA175_10_1136168 -->|"B"|eNFA175_11_10225512
eNFA175_11_10225512 -.->|"ε"|eNFA175_12_24920747
eNFA175_11_10225512 -->|"u"|eNFA175_13_22960139
eNFA175_12_24920747 -->|"u"|eNFA175_13_22960139
eNFA175_13_22960139 -.->|"ε"|eNFA175_14_5314664
eNFA175_13_22960139 -->|"f"|eNFA175_15_47831979
eNFA175_14_5314664 -->|"f"|eNFA175_15_47831979
eNFA175_15_47831979 -.->|"ε"|eNFA175_16_27834629
eNFA175_15_47831979 -->|"f"|eNFA175_17_49185071
eNFA175_16_27834629 -->|"f"|eNFA175_17_49185071
eNFA175_17_49185071 -.->|"ε"|eNFA175_18_40012458
eNFA175_17_49185071 -->|"e"|eNFA175_19_24567808
eNFA175_18_40012458 -->|"e"|eNFA175_19_24567808
eNFA175_19_24567808 -.->|"ε"|eNFA175_20_19783680
eNFA175_19_24567808 -->|"r"|eNFA175_21_43835397
eNFA175_20_19783680 -->|"r"|eNFA175_21_43835397
eNFA175_21_43835397 -.->|"ε"|eNFA175_23_58974254
eNFA175_21_43835397 -.->|"ε"|eNFA175_24_61006246
eNFA175_21_43835397 -.->|"ε"|eNFA175_25_12185309
eNFA175_23_58974254 -.->|"ε"|eNFA175_24_61006246
eNFA175_23_58974254 -.->|"ε"|eNFA175_25_12185309
eNFA175_24_61006246 -.->|"ε"|eNFA175_25_12185309
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
NFA175_22_42558925("NFA175-22 regex start")
NFA175_1_47486005("NFA175-1 char[1]")
NFA175_3_24720863("NFA175-3 char[1]")
NFA175_5_21161181("NFA175-5 char[1]")
NFA175_7_56232902("NFA175-7 char[1]")
NFA175_9_36334077("NFA175-9 char[1]")
NFA175_11_58571242("NFA175-11 char[1]")
NFA175_13_57379134("NFA175-13 char[1]")
NFA175_15_46650162("NFA175-15 char[1]")
NFA175_17_17198279("NFA175-17 char[1]")
NFA175_19_20566791("NFA175-19 char[1]")
NFA175_21_50883393[\"NFA175-21 char[1]"/]
NFA175_22_42558925 -->|"i"|NFA175_1_47486005
NFA175_1_47486005 -->|"m"|NFA175_3_24720863
NFA175_3_24720863 -->|"a"|NFA175_5_21161181
NFA175_5_21161181 -->|"g"|NFA175_7_56232902
NFA175_7_56232902 -->|"e"|NFA175_9_36334077
NFA175_9_36334077 -->|"B"|NFA175_11_58571242
NFA175_11_58571242 -->|"u"|NFA175_13_57379134
NFA175_13_57379134 -->|"f"|NFA175_15_46650162
NFA175_15_46650162 -->|"f"|NFA175_17_17198279
NFA175_17_17198279 -->|"e"|NFA175_19_20566791
NFA175_19_20566791 -->|"r"|NFA175_21_50883393
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
subgraph DFA0_-1792737559["DFA0 regex start"]
NFA175_22_42558925_0("NFA175-22 regex start")
end
subgraph DFA1_542049078["DFA1 {1}"]
NFA175_1_47486005_1("NFA175-1 char[1]")
end
subgraph DFA2_1995030059["DFA2 {1}"]
NFA175_3_24720863_2("NFA175-3 char[1]")
end
subgraph DFA3_-2091476975["DFA3 {1}"]
NFA175_5_21161181_3("NFA175-5 char[1]")
end
subgraph DFA4_331460013["DFA4 {1}"]
NFA175_7_56232902_4("NFA175-7 char[1]")
end
subgraph DFA5_1704129514["DFA5 {1}"]
NFA175_9_36334077_5("NFA175-9 char[1]")
end
subgraph DFA6_-1292201675["DFA6 {1}"]
NFA175_11_58571242_6("NFA175-11 char[1]")
end
subgraph DFA7_913609388["DFA7 {1}"]
NFA175_13_57379134_7("NFA175-13 char[1]")
end
subgraph DFA8_1539511990["DFA8 {1}"]
NFA175_15_46650162_8("NFA175-15 char[1]")
end
subgraph DFA9_62816318["DFA9 {1}"]
NFA175_17_17198279_9("NFA175-17 char[1]")
end
subgraph DFA10_2060205232["DFA10 {1}"]
NFA175_19_20566791_10("NFA175-19 char[1]")
end
subgraph DFA11_-423485957["DFA11 {1}"]
NFA175_21_50883393_11[\"NFA175-21 char[1]"/]
end
DFA0_-1792737559 -->|"i"|DFA1_542049078
DFA1_542049078 -->|"m"|DFA2_1995030059
DFA2_1995030059 -->|"a"|DFA3_-2091476975
DFA3_-2091476975 -->|"g"|DFA4_331460013
DFA4_331460013 -->|"e"|DFA5_1704129514
DFA5_1704129514 -->|"B"|DFA6_-1292201675
DFA6_-1292201675 -->|"u"|DFA7_913609388
DFA7_913609388 -->|"f"|DFA8_1539511990
DFA8_1539511990 -->|"f"|DFA9_62816318
DFA9_62816318 -->|"e"|DFA10_2060205232
DFA10_2060205232 -->|"r"|DFA11_-423485957
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
DFA0_-1792737559{{"DFA0 regex start"}}
DFA1_542049078{{"DFA1 {1}"}}
DFA2_1995030059{{"DFA2 {1}"}}
DFA3_-2091476975{{"DFA3 {1}"}}
DFA4_331460013{{"DFA4 {1}"}}
DFA5_1704129514{{"DFA5 {1}"}}
DFA6_-1292201675{{"DFA6 {1}"}}
DFA7_913609388{{"DFA7 {1}"}}
DFA8_1539511990{{"DFA8 {1}"}}
DFA9_62816318{{"DFA9 {1}"}}
DFA10_2060205232{{"DFA10 {1}"}}
DFA11_-423485957[\"DFA11 {1}"/]
DFA0_-1792737559 -->|"i"|DFA1_542049078
DFA1_542049078 -->|"m"|DFA2_1995030059
DFA2_1995030059 -->|"a"|DFA3_-2091476975
DFA3_-2091476975 -->|"g"|DFA4_331460013
DFA4_331460013 -->|"e"|DFA5_1704129514
DFA5_1704129514 -->|"B"|DFA6_-1292201675
DFA6_-1292201675 -->|"u"|DFA7_913609388
DFA7_913609388 -->|"f"|DFA8_1539511990
DFA8_1539511990 -->|"f"|DFA9_62816318
DFA9_62816318 -->|"e"|DFA10_2060205232
DFA10_2060205232 -->|"r"|DFA11_-423485957
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
subgraph MiniDFA0_1333702387["MiniDFA0 {1}"]
DFA0_-1792737559_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_724227270["MiniDFA1 {1}"]
DFA1_542049078_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1656348970["MiniDFA2 {1}"]
DFA2_1995030059_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1247780479["MiniDFA3 {1}"]
DFA3_-2091476975_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1120295331["MiniDFA4 {1}"]
DFA4_331460013_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1249167959["MiniDFA6 {1}"]
DFA5_1704129514_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-730900577["MiniDFA7 {1}"]
DFA6_-1292201675_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1752497576["MiniDFA8 {1}"]
DFA7_913609388_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_919410029["MiniDFA9 {1}"]
DFA8_1539511990_8{{"DFA8 {1}"}}
end
subgraph MiniDFA5_2050616185["MiniDFA5 {1}"]
DFA9_62816318_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1017862071["MiniDFA10 {1}"]
DFA10_2060205232_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-288363781["MiniDFA11 {1}"]
DFA11_-423485957_11[\"DFA11 {1}"/]
end
MiniDFA0_1333702387 -->|"i"|MiniDFA1_724227270
MiniDFA1_724227270 -->|"m"|MiniDFA2_1656348970
MiniDFA2_1656348970 -->|"a"|MiniDFA3_-1247780479
MiniDFA3_-1247780479 -->|"g"|MiniDFA4_1120295331
MiniDFA4_1120295331 -->|"e"|MiniDFA6_1249167959
MiniDFA6_1249167959 -->|"B"|MiniDFA7_-730900577
MiniDFA7_-730900577 -->|"u"|MiniDFA8_-1752497576
MiniDFA8_-1752497576 -->|"f"|MiniDFA9_919410029
MiniDFA9_919410029 -->|"f"|MiniDFA5_2050616185
MiniDFA5_2050616185 -->|"e"|MiniDFA10_-1017862071
MiniDFA10_-1017862071 -->|"r"|MiniDFA11_-288363781
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
MiniDFA0_1333702387(["MiniDFA0 {1}"])
MiniDFA1_724227270(["MiniDFA1 {1}"])
MiniDFA2_1656348970(["MiniDFA2 {1}"])
MiniDFA3_-1247780479(["MiniDFA3 {1}"])
MiniDFA4_1120295331(["MiniDFA4 {1}"])
MiniDFA6_1249167959(["MiniDFA6 {1}"])
MiniDFA7_-730900577(["MiniDFA7 {1}"])
MiniDFA8_-1752497576(["MiniDFA8 {1}"])
MiniDFA9_919410029(["MiniDFA9 {1}"])
MiniDFA5_2050616185(["MiniDFA5 {1}"])
MiniDFA10_-1017862071(["MiniDFA10 {1}"])
MiniDFA11_-288363781[\"MiniDFA11 {1}"/]
MiniDFA0_1333702387 -->|"i"|MiniDFA1_724227270
MiniDFA1_724227270 -->|"m"|MiniDFA2_1656348970
MiniDFA2_1656348970 -->|"a"|MiniDFA3_-1247780479
MiniDFA3_-1247780479 -->|"g"|MiniDFA4_1120295331
MiniDFA4_1120295331 -->|"e"|MiniDFA6_1249167959
MiniDFA6_1249167959 -->|"B"|MiniDFA7_-730900577
MiniDFA7_-730900577 -->|"u"|MiniDFA8_-1752497576
MiniDFA8_-1752497576 -->|"f"|MiniDFA9_919410029
MiniDFA9_919410029 -->|"f"|MiniDFA5_2050616185
MiniDFA5_2050616185 -->|"e"|MiniDFA10_-1017862071
MiniDFA10_-1017862071 -->|"r"|MiniDFA11_-288363781
```
-------------------------------
