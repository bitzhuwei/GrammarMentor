# 'iimage2DMSArray'

pattern: `iimage2DMSArray`

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
eNFA191_30_53621294[["εNFA191-30 regex start"]]
eNFA191_0_12829599[["εNFA191-0 char{1, 1}"]]
eNFA191_1_48357528[["εNFA191-1 char[1]"]]
eNFA191_2_32564570[["εNFA191-2 char{1, 1}"]]
eNFA191_3_24645678[["εNFA191-3 char[1]"]]
eNFA191_4_20484518[["εNFA191-4 char{1, 1}"]]
eNFA191_5_50142938[["εNFA191-5 char[1]"]]
eNFA191_6_48633258[["εNFA191-6 char{1, 1}"]]
eNFA191_7_35046145[["εNFA191-7 char[1]"]]
eNFA191_8_46979855[["εNFA191-8 char{1, 1}"]]
eNFA191_9_20165517[["εNFA191-9 char[1]"]]
eNFA191_10_47271933[["εNFA191-10 char{1, 1}"]]
eNFA191_11_22794214[["εNFA191-11 char[1]"]]
eNFA191_12_3821339[["εNFA191-12 char{1, 1}"]]
eNFA191_13_34392051[["εNFA191-13 char[1]"]]
eNFA191_14_41093009[["εNFA191-14 char{1, 1}"]]
eNFA191_15_34292765[["εNFA191-15 char[1]"]]
eNFA191_16_40199432[["εNFA191-16 char{1, 1}"]]
eNFA191_17_26250571[["εNFA191-17 char[1]"]]
eNFA191_18_34928551[["εNFA191-18 char{1, 1}"]]
eNFA191_19_45921510[["εNFA191-19 char[1]"]]
eNFA191_20_10640407[["εNFA191-20 char{1, 1}"]]
eNFA191_21_28654805[["εNFA191-21 char[1]"]]
eNFA191_22_56566656[["εNFA191-22 char{1, 1}"]]
eNFA191_23_39337857[["εNFA191-23 char[1]"]]
eNFA191_24_18496393[["εNFA191-24 char{1, 1}"]]
eNFA191_25_32249809[["εNFA191-25 char[1]"]]
eNFA191_26_21812826[["εNFA191-26 char{1, 1}"]]
eNFA191_27_62097709[["εNFA191-27 char[1]"]]
eNFA191_28_22008476[["εNFA191-28 char{1, 1}"]]
eNFA191_29_63858558[["εNFA191-29 char[1]"]]
eNFA191_31_37856118[["εNFA191-31 regex end"]]
eNFA191_32_5160748[["εNFA191-32 post-regex start"]]
eNFA191_33_46446737[\"εNFA191-33 post-regex end"/]
eNFA191_30_53621294 -.->|"ε"|eNFA191_0_12829599
eNFA191_0_12829599 -->|"i"|eNFA191_1_48357528
eNFA191_1_48357528 -.->|"ε"|eNFA191_2_32564570
eNFA191_2_32564570 -->|"i"|eNFA191_3_24645678
eNFA191_3_24645678 -.->|"ε"|eNFA191_4_20484518
eNFA191_4_20484518 -->|"m"|eNFA191_5_50142938
eNFA191_5_50142938 -.->|"ε"|eNFA191_6_48633258
eNFA191_6_48633258 -->|"a"|eNFA191_7_35046145
eNFA191_7_35046145 -.->|"ε"|eNFA191_8_46979855
eNFA191_8_46979855 -->|"g"|eNFA191_9_20165517
eNFA191_9_20165517 -.->|"ε"|eNFA191_10_47271933
eNFA191_10_47271933 -->|"e"|eNFA191_11_22794214
eNFA191_11_22794214 -.->|"ε"|eNFA191_12_3821339
eNFA191_12_3821339 -->|"2"|eNFA191_13_34392051
eNFA191_13_34392051 -.->|"ε"|eNFA191_14_41093009
eNFA191_14_41093009 -->|"D"|eNFA191_15_34292765
eNFA191_15_34292765 -.->|"ε"|eNFA191_16_40199432
eNFA191_16_40199432 -->|"M"|eNFA191_17_26250571
eNFA191_17_26250571 -.->|"ε"|eNFA191_18_34928551
eNFA191_18_34928551 -->|"S"|eNFA191_19_45921510
eNFA191_19_45921510 -.->|"ε"|eNFA191_20_10640407
eNFA191_20_10640407 -->|"A"|eNFA191_21_28654805
eNFA191_21_28654805 -.->|"ε"|eNFA191_22_56566656
eNFA191_22_56566656 -->|"r"|eNFA191_23_39337857
eNFA191_23_39337857 -.->|"ε"|eNFA191_24_18496393
eNFA191_24_18496393 -->|"r"|eNFA191_25_32249809
eNFA191_25_32249809 -.->|"ε"|eNFA191_26_21812826
eNFA191_26_21812826 -->|"a"|eNFA191_27_62097709
eNFA191_27_62097709 -.->|"ε"|eNFA191_28_22008476
eNFA191_28_22008476 -->|"y"|eNFA191_29_63858558
eNFA191_29_63858558 -.->|"ε"|eNFA191_31_37856118
eNFA191_31_37856118 -.->|"ε"|eNFA191_32_5160748
eNFA191_32_5160748 -.->|"ε"|eNFA191_33_46446737
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
eNFA191_30_15367454[["εNFA191-30 regex start"]]
eNFA191_0_4089365[["εNFA191-0 char{1, 1}"]]
eNFA191_1_36804285[["εNFA191-1 char[1]"]]
eNFA191_2_62803112[["εNFA191-2 char{1, 1}"]]
eNFA191_3_28357104[["εNFA191-3 char[1]"]]
eNFA191_4_53887349[["εNFA191-4 char{1, 1}"]]
eNFA191_5_15224096[["εNFA191-5 char[1]"]]
eNFA191_6_2799138[["εNFA191-6 char{1, 1}"]]
eNFA191_7_25192244[["εNFA191-7 char[1]"]]
eNFA191_8_25403607[["εNFA191-8 char{1, 1}"]]
eNFA191_9_27305877[["εNFA191-9 char[1]"]]
eNFA191_10_44426301[["εNFA191-10 char{1, 1}"]]
eNFA191_11_64292394[["εNFA191-11 char[1]"]]
eNFA191_12_41760635[["εNFA191-12 char{1, 1}"]]
eNFA191_13_40301403[["εNFA191-13 char[1]"]]
eNFA191_14_27168314[["εNFA191-14 char{1, 1}"]]
eNFA191_15_43188242[["εNFA191-15 char[1]"]]
eNFA191_16_53149858[["εNFA191-16 char{1, 1}"]]
eNFA191_17_8586676[["εNFA191-17 char[1]"]]
eNFA191_18_10171226[["εNFA191-18 char{1, 1}"]]
eNFA191_19_24432171[["εNFA191-19 char[1]"]]
eNFA191_20_18562954[["εNFA191-20 char{1, 1}"]]
eNFA191_21_32848863[["εNFA191-21 char[1]"]]
eNFA191_22_27204315[["εNFA191-22 char{1, 1}"]]
eNFA191_23_43512247[["εNFA191-23 char[1]"]]
eNFA191_24_56065908[["εNFA191-24 char{1, 1}"]]
eNFA191_25_34831132[["εNFA191-25 char[1]"]]
eNFA191_26_45044734[["εNFA191-26 char{1, 1}"]]
eNFA191_27_2749429[["εNFA191-27 char[1]"]]
eNFA191_28_24744865[["εNFA191-28 char{1, 1}"]]
eNFA191_29_21377195[\"εNFA191-29 char[1]"/]
eNFA191_31_58177028[\"εNFA191-31 regex end"/]
eNFA191_32_53831205[\"εNFA191-32 post-regex start"/]
eNFA191_33_14718799[\"εNFA191-33 post-regex end"/]
eNFA191_30_15367454 -.->|"ε"|eNFA191_0_4089365
eNFA191_30_15367454 -->|"i"|eNFA191_1_36804285
eNFA191_0_4089365 -->|"i"|eNFA191_1_36804285
eNFA191_1_36804285 -.->|"ε"|eNFA191_2_62803112
eNFA191_1_36804285 -->|"i"|eNFA191_3_28357104
eNFA191_2_62803112 -->|"i"|eNFA191_3_28357104
eNFA191_3_28357104 -.->|"ε"|eNFA191_4_53887349
eNFA191_3_28357104 -->|"m"|eNFA191_5_15224096
eNFA191_4_53887349 -->|"m"|eNFA191_5_15224096
eNFA191_5_15224096 -.->|"ε"|eNFA191_6_2799138
eNFA191_5_15224096 -->|"a"|eNFA191_7_25192244
eNFA191_6_2799138 -->|"a"|eNFA191_7_25192244
eNFA191_7_25192244 -.->|"ε"|eNFA191_8_25403607
eNFA191_7_25192244 -->|"g"|eNFA191_9_27305877
eNFA191_8_25403607 -->|"g"|eNFA191_9_27305877
eNFA191_9_27305877 -.->|"ε"|eNFA191_10_44426301
eNFA191_9_27305877 -->|"e"|eNFA191_11_64292394
eNFA191_10_44426301 -->|"e"|eNFA191_11_64292394
eNFA191_11_64292394 -.->|"ε"|eNFA191_12_41760635
eNFA191_11_64292394 -->|"2"|eNFA191_13_40301403
eNFA191_12_41760635 -->|"2"|eNFA191_13_40301403
eNFA191_13_40301403 -.->|"ε"|eNFA191_14_27168314
eNFA191_13_40301403 -->|"D"|eNFA191_15_43188242
eNFA191_14_27168314 -->|"D"|eNFA191_15_43188242
eNFA191_15_43188242 -.->|"ε"|eNFA191_16_53149858
eNFA191_15_43188242 -->|"M"|eNFA191_17_8586676
eNFA191_16_53149858 -->|"M"|eNFA191_17_8586676
eNFA191_17_8586676 -.->|"ε"|eNFA191_18_10171226
eNFA191_17_8586676 -->|"S"|eNFA191_19_24432171
eNFA191_18_10171226 -->|"S"|eNFA191_19_24432171
eNFA191_19_24432171 -.->|"ε"|eNFA191_20_18562954
eNFA191_19_24432171 -->|"A"|eNFA191_21_32848863
eNFA191_20_18562954 -->|"A"|eNFA191_21_32848863
eNFA191_21_32848863 -.->|"ε"|eNFA191_22_27204315
eNFA191_21_32848863 -->|"r"|eNFA191_23_43512247
eNFA191_22_27204315 -->|"r"|eNFA191_23_43512247
eNFA191_23_43512247 -.->|"ε"|eNFA191_24_56065908
eNFA191_23_43512247 -->|"r"|eNFA191_25_34831132
eNFA191_24_56065908 -->|"r"|eNFA191_25_34831132
eNFA191_25_34831132 -.->|"ε"|eNFA191_26_45044734
eNFA191_25_34831132 -->|"a"|eNFA191_27_2749429
eNFA191_26_45044734 -->|"a"|eNFA191_27_2749429
eNFA191_27_2749429 -.->|"ε"|eNFA191_28_24744865
eNFA191_27_2749429 -->|"y"|eNFA191_29_21377195
eNFA191_28_24744865 -->|"y"|eNFA191_29_21377195
eNFA191_29_21377195 -.->|"ε"|eNFA191_31_58177028
eNFA191_29_21377195 -.->|"ε"|eNFA191_32_53831205
eNFA191_29_21377195 -.->|"ε"|eNFA191_33_14718799
eNFA191_31_58177028 -.->|"ε"|eNFA191_32_53831205
eNFA191_31_58177028 -.->|"ε"|eNFA191_33_14718799
eNFA191_32_53831205 -.->|"ε"|eNFA191_33_14718799
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
NFA191_30_65360331("NFA191-30 regex start")
NFA191_1_51372075("NFA191-1 char[1]")
NFA191_3_59695495("NFA191-3 char[1]")
NFA191_5_388543("NFA191-5 char[1]")
NFA191_7_3496894("NFA191-7 char[1]")
NFA191_9_31472052("NFA191-9 char[1]")
NFA191_11_14813018("NFA191-11 char[1]")
NFA191_13_66208306("NFA191-13 char[1]")
NFA191_15_59003843("NFA191-15 char[1]")
NFA191_17_61272544("NFA191-17 char[1]")
NFA191_19_14581984("NFA191-19 char[1]")
NFA191_21_64128998("NFA191-21 char[1]")
NFA191_23_40290074("NFA191-23 char[1]")
NFA191_25_27066349("NFA191-25 char[1]")
NFA191_27_42270552("NFA191-27 char[1]")
NFA191_29_44890652[\"NFA191-29 char[1]"/]
NFA191_30_65360331 -->|"i"|NFA191_1_51372075
NFA191_1_51372075 -->|"i"|NFA191_3_59695495
NFA191_3_59695495 -->|"m"|NFA191_5_388543
NFA191_5_388543 -->|"a"|NFA191_7_3496894
NFA191_7_3496894 -->|"g"|NFA191_9_31472052
NFA191_9_31472052 -->|"e"|NFA191_11_14813018
NFA191_11_14813018 -->|"2"|NFA191_13_66208306
NFA191_13_66208306 -->|"D"|NFA191_15_59003843
NFA191_15_59003843 -->|"M"|NFA191_17_61272544
NFA191_17_61272544 -->|"S"|NFA191_19_14581984
NFA191_19_14581984 -->|"A"|NFA191_21_64128998
NFA191_21_64128998 -->|"r"|NFA191_23_40290074
NFA191_23_40290074 -->|"r"|NFA191_25_27066349
NFA191_25_27066349 -->|"a"|NFA191_27_42270552
NFA191_27_42270552 -->|"y"|NFA191_29_44890652
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
subgraph DFA0_-1471085991["DFA0 regex start"]
NFA191_30_65360331_0("NFA191-30 regex start")
end
subgraph DFA1_-64740073["DFA1 {1}"]
NFA191_1_51372075_1("NFA191-1 char[1]")
end
subgraph DFA2_-692251259["DFA2 {1}"]
NFA191_3_59695495_2("NFA191-3 char[1]")
end
subgraph DFA3_179043077["DFA3 {1}"]
NFA191_5_388543_3("NFA191-5 char[1]")
end
subgraph DFA4_720543624["DFA4 {1}"]
NFA191_7_3496894_4("NFA191-7 char[1]")
end
subgraph DFA5_1594205405["DFA5 {1}"]
NFA191_9_31472052_5("NFA191-9 char[1]")
end
subgraph DFA6_1664825193["DFA6 {1}"]
NFA191_11_14813018_6("NFA191-11 char[1]")
end
subgraph DFA7_-665636845["DFA7 {1}"]
NFA191_13_66208306_7("NFA191-13 char[1]")
end
subgraph DFA8_-99702865["DFA8 {1}"]
NFA191_15_59003843_8("NFA191-15 char[1]")
end
subgraph DFA9_-124818406["DFA9 {1}"]
NFA191_17_61272544_9("NFA191-17 char[1]")
end
subgraph DFA10_-565882426["DFA10 {1}"]
NFA191_19_14581984_10("NFA191-19 char[1]")
end
subgraph DFA11_-1658309626["DFA11 {1}"]
NFA191_21_64128998_11("NFA191-21 char[1]")
end
subgraph DFA12_-1713961611["DFA12 {1}"]
NFA191_23_40290074_12("NFA191-23 char[1]")
end
subgraph DFA13_2113530746["DFA13 {1}"]
NFA191_25_27066349_13("NFA191-25 char[1]")
end
subgraph DFA14_-523896080["DFA14 {1}"]
NFA191_27_42270552_14("NFA191-27 char[1]")
end
subgraph DFA15_994904914["DFA15 {1}"]
NFA191_29_44890652_15[\"NFA191-29 char[1]"/]
end
DFA0_-1471085991 -->|"i"|DFA1_-64740073
DFA1_-64740073 -->|"i"|DFA2_-692251259
DFA2_-692251259 -->|"m"|DFA3_179043077
DFA3_179043077 -->|"a"|DFA4_720543624
DFA4_720543624 -->|"g"|DFA5_1594205405
DFA5_1594205405 -->|"e"|DFA6_1664825193
DFA6_1664825193 -->|"2"|DFA7_-665636845
DFA7_-665636845 -->|"D"|DFA8_-99702865
DFA8_-99702865 -->|"M"|DFA9_-124818406
DFA9_-124818406 -->|"S"|DFA10_-565882426
DFA10_-565882426 -->|"A"|DFA11_-1658309626
DFA11_-1658309626 -->|"r"|DFA12_-1713961611
DFA12_-1713961611 -->|"r"|DFA13_2113530746
DFA13_2113530746 -->|"a"|DFA14_-523896080
DFA14_-523896080 -->|"y"|DFA15_994904914
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
DFA0_-1471085991{{"DFA0 regex start"}}
DFA1_-64740073{{"DFA1 {1}"}}
DFA2_-692251259{{"DFA2 {1}"}}
DFA3_179043077{{"DFA3 {1}"}}
DFA4_720543624{{"DFA4 {1}"}}
DFA5_1594205405{{"DFA5 {1}"}}
DFA6_1664825193{{"DFA6 {1}"}}
DFA7_-665636845{{"DFA7 {1}"}}
DFA8_-99702865{{"DFA8 {1}"}}
DFA9_-124818406{{"DFA9 {1}"}}
DFA10_-565882426{{"DFA10 {1}"}}
DFA11_-1658309626{{"DFA11 {1}"}}
DFA12_-1713961611{{"DFA12 {1}"}}
DFA13_2113530746{{"DFA13 {1}"}}
DFA14_-523896080{{"DFA14 {1}"}}
DFA15_994904914[\"DFA15 {1}"/]
DFA0_-1471085991 -->|"i"|DFA1_-64740073
DFA1_-64740073 -->|"i"|DFA2_-692251259
DFA2_-692251259 -->|"m"|DFA3_179043077
DFA3_179043077 -->|"a"|DFA4_720543624
DFA4_720543624 -->|"g"|DFA5_1594205405
DFA5_1594205405 -->|"e"|DFA6_1664825193
DFA6_1664825193 -->|"2"|DFA7_-665636845
DFA7_-665636845 -->|"D"|DFA8_-99702865
DFA8_-99702865 -->|"M"|DFA9_-124818406
DFA9_-124818406 -->|"S"|DFA10_-565882426
DFA10_-565882426 -->|"A"|DFA11_-1658309626
DFA11_-1658309626 -->|"r"|DFA12_-1713961611
DFA12_-1713961611 -->|"r"|DFA13_2113530746
DFA13_2113530746 -->|"a"|DFA14_-523896080
DFA14_-523896080 -->|"y"|DFA15_994904914
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
subgraph MiniDFA0_-541322710["MiniDFA0 {1}"]
DFA0_-1471085991_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_269737492["MiniDFA1 {1}"]
DFA1_-64740073_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_319722916["MiniDFA2 {1}"]
DFA2_-692251259_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-593742145["MiniDFA3 {1}"]
DFA3_179043077_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_229000742["MiniDFA5 {1}"]
DFA4_720543624_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-958967798["MiniDFA6 {1}"]
DFA5_1594205405_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1601052718["MiniDFA7 {1}"]
DFA6_1664825193_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_62651986["MiniDFA8 {1}"]
DFA7_-665636845_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1710682851["MiniDFA9 {1}"]
DFA8_-99702865_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-1058835245["MiniDFA10 {1}"]
DFA9_-124818406_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_2120284659["MiniDFA11 {1}"]
DFA10_-565882426_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_34086632["MiniDFA12 {1}"]
DFA11_-1658309626_11{{"DFA11 {1}"}}
end
subgraph MiniDFA13_-1420036641["MiniDFA13 {1}"]
DFA12_-1713961611_12{{"DFA12 {1}"}}
end
subgraph MiniDFA4_-497209316["MiniDFA4 {1}"]
DFA13_2113530746_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1004562244["MiniDFA14 {1}"]
DFA14_-523896080_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_1188157777["MiniDFA15 {1}"]
DFA15_994904914_15[\"DFA15 {1}"/]
end
MiniDFA0_-541322710 -->|"i"|MiniDFA1_269737492
MiniDFA1_269737492 -->|"i"|MiniDFA2_319722916
MiniDFA2_319722916 -->|"m"|MiniDFA3_-593742145
MiniDFA3_-593742145 -->|"a"|MiniDFA5_229000742
MiniDFA5_229000742 -->|"g"|MiniDFA6_-958967798
MiniDFA6_-958967798 -->|"e"|MiniDFA7_-1601052718
MiniDFA7_-1601052718 -->|"2"|MiniDFA8_62651986
MiniDFA8_62651986 -->|"D"|MiniDFA9_-1710682851
MiniDFA9_-1710682851 -->|"M"|MiniDFA10_-1058835245
MiniDFA10_-1058835245 -->|"S"|MiniDFA11_2120284659
MiniDFA11_2120284659 -->|"A"|MiniDFA12_34086632
MiniDFA12_34086632 -->|"r"|MiniDFA13_-1420036641
MiniDFA13_-1420036641 -->|"r"|MiniDFA4_-497209316
MiniDFA4_-497209316 -->|"a"|MiniDFA14_1004562244
MiniDFA14_1004562244 -->|"y"|MiniDFA15_1188157777
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
MiniDFA0_-541322710(["MiniDFA0 {1}"])
MiniDFA1_269737492(["MiniDFA1 {1}"])
MiniDFA2_319722916(["MiniDFA2 {1}"])
MiniDFA3_-593742145(["MiniDFA3 {1}"])
MiniDFA5_229000742(["MiniDFA5 {1}"])
MiniDFA6_-958967798(["MiniDFA6 {1}"])
MiniDFA7_-1601052718(["MiniDFA7 {1}"])
MiniDFA8_62651986(["MiniDFA8 {1}"])
MiniDFA9_-1710682851(["MiniDFA9 {1}"])
MiniDFA10_-1058835245(["MiniDFA10 {1}"])
MiniDFA11_2120284659(["MiniDFA11 {1}"])
MiniDFA12_34086632(["MiniDFA12 {1}"])
MiniDFA13_-1420036641(["MiniDFA13 {1}"])
MiniDFA4_-497209316(["MiniDFA4 {1}"])
MiniDFA14_1004562244(["MiniDFA14 {1}"])
MiniDFA15_1188157777[\"MiniDFA15 {1}"/]
MiniDFA0_-541322710 -->|"i"|MiniDFA1_269737492
MiniDFA1_269737492 -->|"i"|MiniDFA2_319722916
MiniDFA2_319722916 -->|"m"|MiniDFA3_-593742145
MiniDFA3_-593742145 -->|"a"|MiniDFA5_229000742
MiniDFA5_229000742 -->|"g"|MiniDFA6_-958967798
MiniDFA6_-958967798 -->|"e"|MiniDFA7_-1601052718
MiniDFA7_-1601052718 -->|"2"|MiniDFA8_62651986
MiniDFA8_62651986 -->|"D"|MiniDFA9_-1710682851
MiniDFA9_-1710682851 -->|"M"|MiniDFA10_-1058835245
MiniDFA10_-1058835245 -->|"S"|MiniDFA11_2120284659
MiniDFA11_2120284659 -->|"A"|MiniDFA12_34086632
MiniDFA12_34086632 -->|"r"|MiniDFA13_-1420036641
MiniDFA13_-1420036641 -->|"r"|MiniDFA4_-497209316
MiniDFA4_-497209316 -->|"a"|MiniDFA14_1004562244
MiniDFA14_1004562244 -->|"y"|MiniDFA15_1188157777
```
-------------------------------
