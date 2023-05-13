# 'usampler2D'

pattern: `usampler2D`

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
eNFA141_20_34619920[["εNFA141-20 regex start"]]
eNFA141_0_43143829[["εNFA141-0 char{1, 1}"]]
eNFA141_1_52750146[["εNFA141-1 char[1]"]]
eNFA141_2_4989273[["εNFA141-2 char{1, 1}"]]
eNFA141_3_44903457[["εNFA141-3 char[1]"]]
eNFA141_4_1477932[["εNFA141-4 char{1, 1}"]]
eNFA141_5_13301396[["εNFA141-5 char[1]"]]
eNFA141_6_52603705[["εNFA141-6 char{1, 1}"]]
eNFA141_7_3671300[["εNFA141-7 char[1]"]]
eNFA141_8_33041702[["εNFA141-8 char{1, 1}"]]
eNFA141_9_28939864[["εNFA141-9 char[1]"]]
eNFA141_10_59132187[["εNFA141-10 char{1, 1}"]]
eNFA141_11_62427641[["εNFA141-11 char[1]"]]
eNFA141_12_24977857[["εNFA141-12 char{1, 1}"]]
eNFA141_13_23474126[["εNFA141-13 char[1]"]]
eNFA141_14_9940543[["εNFA141-14 char{1, 1}"]]
eNFA141_15_22356031[["εNFA141-15 char[1]"]]
eNFA141_16_66986558[["εNFA141-16 char{1, 1}"]]
eNFA141_17_66008118[["εNFA141-17 char[1]"]]
eNFA141_18_57202150[["εNFA141-18 char{1, 1}"]]
eNFA141_19_45057304[["εNFA141-19 char[1]"]]
eNFA141_21_2862558[["εNFA141-21 regex end"]]
eNFA141_22_25763023[["εNFA141-22 post-regex start"]]
eNFA141_23_30540622[\"εNFA141-23 post-regex end"/]
eNFA141_20_34619920 -.->|"ε"|eNFA141_0_43143829
eNFA141_0_43143829 -->|"u"|eNFA141_1_52750146
eNFA141_1_52750146 -.->|"ε"|eNFA141_2_4989273
eNFA141_2_4989273 -->|"s"|eNFA141_3_44903457
eNFA141_3_44903457 -.->|"ε"|eNFA141_4_1477932
eNFA141_4_1477932 -->|"a"|eNFA141_5_13301396
eNFA141_5_13301396 -.->|"ε"|eNFA141_6_52603705
eNFA141_6_52603705 -->|"m"|eNFA141_7_3671300
eNFA141_7_3671300 -.->|"ε"|eNFA141_8_33041702
eNFA141_8_33041702 -->|"p"|eNFA141_9_28939864
eNFA141_9_28939864 -.->|"ε"|eNFA141_10_59132187
eNFA141_10_59132187 -->|"l"|eNFA141_11_62427641
eNFA141_11_62427641 -.->|"ε"|eNFA141_12_24977857
eNFA141_12_24977857 -->|"e"|eNFA141_13_23474126
eNFA141_13_23474126 -.->|"ε"|eNFA141_14_9940543
eNFA141_14_9940543 -->|"r"|eNFA141_15_22356031
eNFA141_15_22356031 -.->|"ε"|eNFA141_16_66986558
eNFA141_16_66986558 -->|"2"|eNFA141_17_66008118
eNFA141_17_66008118 -.->|"ε"|eNFA141_18_57202150
eNFA141_18_57202150 -->|"D"|eNFA141_19_45057304
eNFA141_19_45057304 -.->|"ε"|eNFA141_21_2862558
eNFA141_21_2862558 -.->|"ε"|eNFA141_22_25763023
eNFA141_22_25763023 -.->|"ε"|eNFA141_23_30540622
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
eNFA141_20_6430147[["εNFA141-20 regex start"]]
eNFA141_0_57871327[["εNFA141-0 char{1, 1}"]]
eNFA141_1_51079899[["εNFA141-1 char[1]"]]
eNFA141_2_57065912[["εNFA141-2 char{1, 1}"]]
eNFA141_3_43831168[["εNFA141-3 char[1]"]]
eNFA141_4_58936194[["εNFA141-4 char{1, 1}"]]
eNFA141_5_60663705[["εNFA141-5 char[1]"]]
eNFA141_6_9102437[["εNFA141-6 char{1, 1}"]]
eNFA141_7_14813071[["εNFA141-7 char[1]"]]
eNFA141_8_66208776[["εNFA141-8 char{1, 1}"]]
eNFA141_9_59008073[["εNFA141-9 char[1]"]]
eNFA141_10_61310611[["εNFA141-10 char{1, 1}"]]
eNFA141_11_14924591[["εNFA141-11 char[1]"]]
eNFA141_12_103599[["εNFA141-12 char{1, 1}"]]
eNFA141_13_932395[["εNFA141-13 char[1]"]]
eNFA141_14_8391555[["εNFA141-14 char{1, 1}"]]
eNFA141_15_8415138[["εNFA141-15 char[1]"]]
eNFA141_16_8627384[["εNFA141-16 char{1, 1}"]]
eNFA141_17_10537598[["εNFA141-17 char[1]"]]
eNFA141_18_27729526[["εNFA141-18 char{1, 1}"]]
eNFA141_19_48239143[\"εNFA141-19 char[1]"/]
eNFA141_21_31499108[\"εNFA141-21 regex end"/]
eNFA141_22_15056516[\"εNFA141-22 post-regex start"/]
eNFA141_23_1290922[\"εNFA141-23 post-regex end"/]
eNFA141_20_6430147 -.->|"ε"|eNFA141_0_57871327
eNFA141_20_6430147 -->|"u"|eNFA141_1_51079899
eNFA141_0_57871327 -->|"u"|eNFA141_1_51079899
eNFA141_1_51079899 -.->|"ε"|eNFA141_2_57065912
eNFA141_1_51079899 -->|"s"|eNFA141_3_43831168
eNFA141_2_57065912 -->|"s"|eNFA141_3_43831168
eNFA141_3_43831168 -.->|"ε"|eNFA141_4_58936194
eNFA141_3_43831168 -->|"a"|eNFA141_5_60663705
eNFA141_4_58936194 -->|"a"|eNFA141_5_60663705
eNFA141_5_60663705 -.->|"ε"|eNFA141_6_9102437
eNFA141_5_60663705 -->|"m"|eNFA141_7_14813071
eNFA141_6_9102437 -->|"m"|eNFA141_7_14813071
eNFA141_7_14813071 -.->|"ε"|eNFA141_8_66208776
eNFA141_7_14813071 -->|"p"|eNFA141_9_59008073
eNFA141_8_66208776 -->|"p"|eNFA141_9_59008073
eNFA141_9_59008073 -.->|"ε"|eNFA141_10_61310611
eNFA141_9_59008073 -->|"l"|eNFA141_11_14924591
eNFA141_10_61310611 -->|"l"|eNFA141_11_14924591
eNFA141_11_14924591 -.->|"ε"|eNFA141_12_103599
eNFA141_11_14924591 -->|"e"|eNFA141_13_932395
eNFA141_12_103599 -->|"e"|eNFA141_13_932395
eNFA141_13_932395 -.->|"ε"|eNFA141_14_8391555
eNFA141_13_932395 -->|"r"|eNFA141_15_8415138
eNFA141_14_8391555 -->|"r"|eNFA141_15_8415138
eNFA141_15_8415138 -.->|"ε"|eNFA141_16_8627384
eNFA141_15_8415138 -->|"2"|eNFA141_17_10537598
eNFA141_16_8627384 -->|"2"|eNFA141_17_10537598
eNFA141_17_10537598 -.->|"ε"|eNFA141_18_27729526
eNFA141_17_10537598 -->|"D"|eNFA141_19_48239143
eNFA141_18_27729526 -->|"D"|eNFA141_19_48239143
eNFA141_19_48239143 -.->|"ε"|eNFA141_21_31499108
eNFA141_19_48239143 -.->|"ε"|eNFA141_22_15056516
eNFA141_19_48239143 -.->|"ε"|eNFA141_23_1290922
eNFA141_21_31499108 -.->|"ε"|eNFA141_22_15056516
eNFA141_21_31499108 -.->|"ε"|eNFA141_23_1290922
eNFA141_22_15056516 -.->|"ε"|eNFA141_23_1290922
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
NFA141_20_11618302("NFA141-20 regex start")
NFA141_1_37455857("NFA141-1 char[1]")
NFA141_3_1558396("NFA141-3 char[1]")
NFA141_5_14025568("NFA141-5 char[1]")
NFA141_7_59121255("NFA141-7 char[1]")
NFA141_9_62329248("NFA141-9 char[1]")
NFA141_11_24092326("NFA141-11 char[1]")
NFA141_13_15504345("NFA141-13 char[1]")
NFA141_15_5321378("NFA141-15 char[1]")
NFA141_17_47892402("NFA141-17 char[1]")
NFA141_19_28378434[\"NFA141-19 char[1]"/]
NFA141_20_11618302 -->|"u"|NFA141_1_37455857
NFA141_1_37455857 -->|"s"|NFA141_3_1558396
NFA141_3_1558396 -->|"a"|NFA141_5_14025568
NFA141_5_14025568 -->|"m"|NFA141_7_59121255
NFA141_7_59121255 -->|"p"|NFA141_9_62329248
NFA141_9_62329248 -->|"l"|NFA141_11_24092326
NFA141_11_24092326 -->|"e"|NFA141_13_15504345
NFA141_13_15504345 -->|"r"|NFA141_15_5321378
NFA141_15_5321378 -->|"2"|NFA141_17_47892402
NFA141_17_47892402 -->|"D"|NFA141_19_28378434
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
subgraph DFA0_1339571775["DFA0 regex start"]
NFA141_20_11618302_0("NFA141-20 regex start")
end
subgraph DFA1_-173564231["DFA1 {1}"]
NFA141_1_37455857_1("NFA141-1 char[1]")
end
subgraph DFA2_202163782["DFA2 {1}"]
NFA141_3_1558396_2("NFA141-3 char[1]")
end
subgraph DFA3_-1255206601["DFA3 {1}"]
NFA141_5_14025568_3("NFA141-5 char[1]")
end
subgraph DFA4_-473026584["DFA4 {1}"]
NFA141_7_59121255_4("NFA141-7 char[1]")
end
subgraph DFA5_2127354591["DFA5 {1}"]
NFA141_9_62329248_5("NFA141-9 char[1]")
end
subgraph DFA6_1372769983["DFA6 {1}"]
NFA141_11_24092326_6("NFA141-11 char[1]")
end
subgraph DFA7_1498818340["DFA7 {1}"]
NFA141_13_15504345_7("NFA141-13 char[1]")
end
subgraph DFA8_-2091046338["DFA8 {1}"]
NFA141_15_5321378_8("NFA141-15 char[1]")
end
subgraph DFA9_-1894686340["DFA9 {1}"]
NFA141_17_47892402_9("NFA141-17 char[1]")
end
subgraph DFA10_-1516699425["DFA10 {1}"]
NFA141_19_28378434_10[\"NFA141-19 char[1]"/]
end
DFA0_1339571775 -->|"u"|DFA1_-173564231
DFA1_-173564231 -->|"s"|DFA2_202163782
DFA2_202163782 -->|"a"|DFA3_-1255206601
DFA3_-1255206601 -->|"m"|DFA4_-473026584
DFA4_-473026584 -->|"p"|DFA5_2127354591
DFA5_2127354591 -->|"l"|DFA6_1372769983
DFA6_1372769983 -->|"e"|DFA7_1498818340
DFA7_1498818340 -->|"r"|DFA8_-2091046338
DFA8_-2091046338 -->|"2"|DFA9_-1894686340
DFA9_-1894686340 -->|"D"|DFA10_-1516699425
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
DFA0_1339571775{{"DFA0 regex start"}}
DFA1_-173564231{{"DFA1 {1}"}}
DFA2_202163782{{"DFA2 {1}"}}
DFA3_-1255206601{{"DFA3 {1}"}}
DFA4_-473026584{{"DFA4 {1}"}}
DFA5_2127354591{{"DFA5 {1}"}}
DFA6_1372769983{{"DFA6 {1}"}}
DFA7_1498818340{{"DFA7 {1}"}}
DFA8_-2091046338{{"DFA8 {1}"}}
DFA9_-1894686340{{"DFA9 {1}"}}
DFA10_-1516699425[\"DFA10 {1}"/]
DFA0_1339571775 -->|"u"|DFA1_-173564231
DFA1_-173564231 -->|"s"|DFA2_202163782
DFA2_202163782 -->|"a"|DFA3_-1255206601
DFA3_-1255206601 -->|"m"|DFA4_-473026584
DFA4_-473026584 -->|"p"|DFA5_2127354591
DFA5_2127354591 -->|"l"|DFA6_1372769983
DFA6_1372769983 -->|"e"|DFA7_1498818340
DFA7_1498818340 -->|"r"|DFA8_-2091046338
DFA8_-2091046338 -->|"2"|DFA9_-1894686340
DFA9_-1894686340 -->|"D"|DFA10_-1516699425
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
subgraph MiniDFA0_850824570["MiniDFA0 {1}"]
DFA0_1339571775_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_809146540["MiniDFA1 {1}"]
DFA1_-173564231_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1346371202["MiniDFA2 {1}"]
DFA2_202163782_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_230452242["MiniDFA3 {1}"]
DFA3_-1255206601_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_267052257["MiniDFA4 {1}"]
DFA4_-473026584_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_510643843["MiniDFA5 {1}"]
DFA5_2127354591_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1208491510["MiniDFA6 {1}"]
DFA6_1372769983_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1928909413["MiniDFA7 {1}"]
DFA7_1498818340_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-245661284["MiniDFA8 {1}"]
DFA8_-2091046338_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-1989789342["MiniDFA9 {1}"]
DFA9_-1894686340_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1319365366["MiniDFA10 {1}"]
DFA10_-1516699425_10[\"DFA10 {1}"/]
end
MiniDFA0_850824570 -->|"u"|MiniDFA1_809146540
MiniDFA1_809146540 -->|"s"|MiniDFA2_1346371202
MiniDFA2_1346371202 -->|"a"|MiniDFA3_230452242
MiniDFA3_230452242 -->|"m"|MiniDFA4_267052257
MiniDFA4_267052257 -->|"p"|MiniDFA5_510643843
MiniDFA5_510643843 -->|"l"|MiniDFA6_1208491510
MiniDFA6_1208491510 -->|"e"|MiniDFA7_1928909413
MiniDFA7_1928909413 -->|"r"|MiniDFA8_-245661284
MiniDFA8_-245661284 -->|"2"|MiniDFA9_-1989789342
MiniDFA9_-1989789342 -->|"D"|MiniDFA10_-1319365366
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
MiniDFA0_850824570(["MiniDFA0 {1}"])
MiniDFA1_809146540(["MiniDFA1 {1}"])
MiniDFA2_1346371202(["MiniDFA2 {1}"])
MiniDFA3_230452242(["MiniDFA3 {1}"])
MiniDFA4_267052257(["MiniDFA4 {1}"])
MiniDFA5_510643843(["MiniDFA5 {1}"])
MiniDFA6_1208491510(["MiniDFA6 {1}"])
MiniDFA7_1928909413(["MiniDFA7 {1}"])
MiniDFA8_-245661284(["MiniDFA8 {1}"])
MiniDFA9_-1989789342(["MiniDFA9 {1}"])
MiniDFA10_-1319365366[\"MiniDFA10 {1}"/]
MiniDFA0_850824570 -->|"u"|MiniDFA1_809146540
MiniDFA1_809146540 -->|"s"|MiniDFA2_1346371202
MiniDFA2_1346371202 -->|"a"|MiniDFA3_230452242
MiniDFA3_230452242 -->|"m"|MiniDFA4_267052257
MiniDFA4_267052257 -->|"p"|MiniDFA5_510643843
MiniDFA5_510643843 -->|"l"|MiniDFA6_1208491510
MiniDFA6_1208491510 -->|"e"|MiniDFA7_1928909413
MiniDFA7_1928909413 -->|"r"|MiniDFA8_-245661284
MiniDFA8_-245661284 -->|"2"|MiniDFA9_-1989789342
MiniDFA9_-1989789342 -->|"D"|MiniDFA10_-1319365366
```
-------------------------------
