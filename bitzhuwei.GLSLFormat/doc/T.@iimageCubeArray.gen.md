# 'iimageCubeArray'

pattern: `iimageCubeArray`

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
eNFA185_30_12176400[["εNFA185-30 regex start"]]
eNFA185_0_42478738[["εNFA185-0 char{1, 1}"]]
eNFA185_1_46764328[["εNFA185-1 char[1]"]]
eNFA185_2_18225769[["εNFA185-2 char{1, 1}"]]
eNFA185_3_29814200[["εNFA185-3 char[1]"]]
eNFA185_4_67001213[["εNFA185-4 char{1, 1}"]]
eNFA185_5_66140009[["εNFA185-5 char[1]"]]
eNFA185_6_58389173[["εNFA185-6 char{1, 1}"]]
eNFA185_7_55740514[["εNFA185-7 char[1]"]]
eNFA185_8_31902586[["εNFA185-8 char{1, 1}"]]
eNFA185_9_18687820[["εNFA185-9 char[1]"]]
eNFA185_10_33972659[["εNFA185-10 char{1, 1}"]]
eNFA185_11_37318479[["εNFA185-11 char[1]"]]
eNFA185_12_321993[["εNFA185-12 char{1, 1}"]]
eNFA185_13_2897938[["εNFA185-13 char[1]"]]
eNFA185_14_26081443[["εNFA185-14 char{1, 1}"]]
eNFA185_15_33406397[["εNFA185-15 char[1]"]]
eNFA185_16_32222121[["εNFA185-16 char{1, 1}"]]
eNFA185_17_21563641[["εNFA185-17 char[1]"]]
eNFA185_18_59855045[["εNFA185-18 char{1, 1}"]]
eNFA185_19_1824493[["εNFA185-19 char[1]"]]
eNFA185_20_16420444[["εNFA185-20 char{1, 1}"]]
eNFA185_21_13566274[["εNFA185-21 char[1]"]]
eNFA185_22_54987608[["εNFA185-22 char{1, 1}"]]
eNFA185_23_25126432[["εNFA185-23 char[1]"]]
eNFA185_24_24811297[["εNFA185-24 char{1, 1}"]]
eNFA185_25_21975086[["εNFA185-25 char[1]"]]
eNFA185_26_63558046[["εNFA185-26 char{1, 1}"]]
eNFA185_27_35151508[["εNFA185-27 char[1]"]]
eNFA185_28_47928120[["εNFA185-28 char{1, 1}"]]
eNFA185_29_28699899[["εNFA185-29 char[1]"]]
eNFA185_31_56972502[["εNFA185-31 regex end"]]
eNFA185_32_42990474[["εNFA185-32 post-regex start"]]
eNFA185_33_51369953[\"εNFA185-33 post-regex end"/]
eNFA185_30_12176400 -.->|"ε"|eNFA185_0_42478738
eNFA185_0_42478738 -->|"i"|eNFA185_1_46764328
eNFA185_1_46764328 -.->|"ε"|eNFA185_2_18225769
eNFA185_2_18225769 -->|"i"|eNFA185_3_29814200
eNFA185_3_29814200 -.->|"ε"|eNFA185_4_67001213
eNFA185_4_67001213 -->|"m"|eNFA185_5_66140009
eNFA185_5_66140009 -.->|"ε"|eNFA185_6_58389173
eNFA185_6_58389173 -->|"a"|eNFA185_7_55740514
eNFA185_7_55740514 -.->|"ε"|eNFA185_8_31902586
eNFA185_8_31902586 -->|"g"|eNFA185_9_18687820
eNFA185_9_18687820 -.->|"ε"|eNFA185_10_33972659
eNFA185_10_33972659 -->|"e"|eNFA185_11_37318479
eNFA185_11_37318479 -.->|"ε"|eNFA185_12_321993
eNFA185_12_321993 -->|"C"|eNFA185_13_2897938
eNFA185_13_2897938 -.->|"ε"|eNFA185_14_26081443
eNFA185_14_26081443 -->|"u"|eNFA185_15_33406397
eNFA185_15_33406397 -.->|"ε"|eNFA185_16_32222121
eNFA185_16_32222121 -->|"b"|eNFA185_17_21563641
eNFA185_17_21563641 -.->|"ε"|eNFA185_18_59855045
eNFA185_18_59855045 -->|"e"|eNFA185_19_1824493
eNFA185_19_1824493 -.->|"ε"|eNFA185_20_16420444
eNFA185_20_16420444 -->|"A"|eNFA185_21_13566274
eNFA185_21_13566274 -.->|"ε"|eNFA185_22_54987608
eNFA185_22_54987608 -->|"r"|eNFA185_23_25126432
eNFA185_23_25126432 -.->|"ε"|eNFA185_24_24811297
eNFA185_24_24811297 -->|"r"|eNFA185_25_21975086
eNFA185_25_21975086 -.->|"ε"|eNFA185_26_63558046
eNFA185_26_63558046 -->|"a"|eNFA185_27_35151508
eNFA185_27_35151508 -.->|"ε"|eNFA185_28_47928120
eNFA185_28_47928120 -->|"y"|eNFA185_29_28699899
eNFA185_29_28699899 -.->|"ε"|eNFA185_31_56972502
eNFA185_31_56972502 -.->|"ε"|eNFA185_32_42990474
eNFA185_32_42990474 -.->|"ε"|eNFA185_33_51369953
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
eNFA185_30_59676394[["εNFA185-30 regex start"]]
eNFA185_0_216640[["εNFA185-0 char{1, 1}"]]
eNFA185_1_1949763[["εNFA185-1 char[1]"]]
eNFA185_2_17547868[["εNFA185-2 char{1, 1}"]]
eNFA185_3_23713084[["εNFA185-3 char[1]"]]
eNFA185_4_12091164[["εNFA185-4 char{1, 1}"]]
eNFA185_5_41711613[["εNFA185-5 char[1]"]]
eNFA185_6_39860200[["εNFA185-6 char{1, 1}"]]
eNFA185_7_23197487[["εNFA185-7 char[1]"]]
eNFA185_8_7450793[["εNFA185-8 char{1, 1}"]]
eNFA185_9_67057145[["εNFA185-9 char[1]"]]
eNFA185_10_66643399[["εNFA185-10 char{1, 1}"]]
eNFA185_11_62919684[["εNFA185-11 char[1]"]]
eNFA185_12_29406249[["εNFA185-12 char{1, 1}"]]
eNFA185_13_63329656[["εNFA185-13 char[1]"]]
eNFA185_14_33095992[["εNFA185-14 char{1, 1}"]]
eNFA185_15_29428475[["εNFA185-15 char[1]"]]
eNFA185_16_63529691[["εNFA185-16 char{1, 1}"]]
eNFA185_17_34896312[["εNFA185-17 char[1]"]]
eNFA185_18_45631355[["εNFA185-18 char{1, 1}"]]
eNFA185_19_8029013[["εNFA185-19 char[1]"]]
eNFA185_20_5152255[["εNFA185-20 char{1, 1}"]]
eNFA185_21_46370298[["εNFA185-21 char[1]"]]
eNFA185_22_14679504[["εNFA185-22 char{1, 1}"]]
eNFA185_23_65006672[["εNFA185-23 char[1]"]]
eNFA185_24_48189141[["εNFA185-24 char{1, 1}"]]
eNFA185_25_31049086[["εNFA185-25 char[1]"]]
eNFA185_26_11006326[["εNFA185-26 char{1, 1}"]]
eNFA185_27_31948077[["εNFA185-27 char[1]"]]
eNFA185_28_19097245[["εNFA185-28 char{1, 1}"]]
eNFA185_29_37657477[\"εNFA185-29 char[1]"/]
eNFA185_31_3372975[\"εNFA185-31 regex end"/]
eNFA185_32_30356781[\"εNFA185-32 post-regex start"/]
eNFA185_33_4775574[\"εNFA185-33 post-regex end"/]
eNFA185_30_59676394 -.->|"ε"|eNFA185_0_216640
eNFA185_30_59676394 -->|"i"|eNFA185_1_1949763
eNFA185_0_216640 -->|"i"|eNFA185_1_1949763
eNFA185_1_1949763 -.->|"ε"|eNFA185_2_17547868
eNFA185_1_1949763 -->|"i"|eNFA185_3_23713084
eNFA185_2_17547868 -->|"i"|eNFA185_3_23713084
eNFA185_3_23713084 -.->|"ε"|eNFA185_4_12091164
eNFA185_3_23713084 -->|"m"|eNFA185_5_41711613
eNFA185_4_12091164 -->|"m"|eNFA185_5_41711613
eNFA185_5_41711613 -.->|"ε"|eNFA185_6_39860200
eNFA185_5_41711613 -->|"a"|eNFA185_7_23197487
eNFA185_6_39860200 -->|"a"|eNFA185_7_23197487
eNFA185_7_23197487 -.->|"ε"|eNFA185_8_7450793
eNFA185_7_23197487 -->|"g"|eNFA185_9_67057145
eNFA185_8_7450793 -->|"g"|eNFA185_9_67057145
eNFA185_9_67057145 -.->|"ε"|eNFA185_10_66643399
eNFA185_9_67057145 -->|"e"|eNFA185_11_62919684
eNFA185_10_66643399 -->|"e"|eNFA185_11_62919684
eNFA185_11_62919684 -.->|"ε"|eNFA185_12_29406249
eNFA185_11_62919684 -->|"C"|eNFA185_13_63329656
eNFA185_12_29406249 -->|"C"|eNFA185_13_63329656
eNFA185_13_63329656 -.->|"ε"|eNFA185_14_33095992
eNFA185_13_63329656 -->|"u"|eNFA185_15_29428475
eNFA185_14_33095992 -->|"u"|eNFA185_15_29428475
eNFA185_15_29428475 -.->|"ε"|eNFA185_16_63529691
eNFA185_15_29428475 -->|"b"|eNFA185_17_34896312
eNFA185_16_63529691 -->|"b"|eNFA185_17_34896312
eNFA185_17_34896312 -.->|"ε"|eNFA185_18_45631355
eNFA185_17_34896312 -->|"e"|eNFA185_19_8029013
eNFA185_18_45631355 -->|"e"|eNFA185_19_8029013
eNFA185_19_8029013 -.->|"ε"|eNFA185_20_5152255
eNFA185_19_8029013 -->|"A"|eNFA185_21_46370298
eNFA185_20_5152255 -->|"A"|eNFA185_21_46370298
eNFA185_21_46370298 -.->|"ε"|eNFA185_22_14679504
eNFA185_21_46370298 -->|"r"|eNFA185_23_65006672
eNFA185_22_14679504 -->|"r"|eNFA185_23_65006672
eNFA185_23_65006672 -.->|"ε"|eNFA185_24_48189141
eNFA185_23_65006672 -->|"r"|eNFA185_25_31049086
eNFA185_24_48189141 -->|"r"|eNFA185_25_31049086
eNFA185_25_31049086 -.->|"ε"|eNFA185_26_11006326
eNFA185_25_31049086 -->|"a"|eNFA185_27_31948077
eNFA185_26_11006326 -->|"a"|eNFA185_27_31948077
eNFA185_27_31948077 -.->|"ε"|eNFA185_28_19097245
eNFA185_27_31948077 -->|"y"|eNFA185_29_37657477
eNFA185_28_19097245 -->|"y"|eNFA185_29_37657477
eNFA185_29_37657477 -.->|"ε"|eNFA185_31_3372975
eNFA185_29_37657477 -.->|"ε"|eNFA185_32_30356781
eNFA185_29_37657477 -.->|"ε"|eNFA185_33_4775574
eNFA185_31_3372975 -.->|"ε"|eNFA185_32_30356781
eNFA185_31_3372975 -.->|"ε"|eNFA185_33_4775574
eNFA185_32_30356781 -.->|"ε"|eNFA185_33_4775574
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
NFA185_30_42980173("NFA185-30 regex start")
NFA185_1_51277242("NFA185-1 char[1]")
NFA185_3_58841998("NFA185-3 char[1]")
NFA185_5_59815938("NFA185-5 char[1]")
NFA185_7_1472535("NFA185-7 char[1]")
NFA185_9_13252823("NFA185-9 char[1]")
NFA185_11_52166545("NFA185-11 char[1]")
NFA185_13_66845728("NFA185-13 char[1]")
NFA185_15_64740644("NFA185-15 char[1]")
NFA185_17_45794886("NFA185-17 char[1]")
NFA185_19_9500791("NFA185-19 char[1]")
NFA185_21_18398256("NFA185-21 char[1]")
NFA185_23_31366578("NFA185-23 char[1]")
NFA185_25_13863750("NFA185-25 char[1]")
NFA185_27_57664894("NFA185-27 char[1]")
NFA185_29_49222002[\"NFA185-29 char[1]"/]
NFA185_30_42980173 -->|"i"|NFA185_1_51277242
NFA185_1_51277242 -->|"i"|NFA185_3_58841998
NFA185_3_58841998 -->|"m"|NFA185_5_59815938
NFA185_5_59815938 -->|"a"|NFA185_7_1472535
NFA185_7_1472535 -->|"g"|NFA185_9_13252823
NFA185_9_13252823 -->|"e"|NFA185_11_52166545
NFA185_11_52166545 -->|"C"|NFA185_13_66845728
NFA185_13_66845728 -->|"u"|NFA185_15_64740644
NFA185_15_64740644 -->|"b"|NFA185_17_45794886
NFA185_17_45794886 -->|"e"|NFA185_19_9500791
NFA185_19_9500791 -->|"A"|NFA185_21_18398256
NFA185_21_18398256 -->|"r"|NFA185_23_31366578
NFA185_23_31366578 -->|"r"|NFA185_25_13863750
NFA185_25_13863750 -->|"a"|NFA185_27_57664894
NFA185_27_57664894 -->|"y"|NFA185_29_49222002
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
subgraph DFA0_157616664["DFA0 regex start"]
NFA185_30_42980173_0("NFA185-30 regex start")
end
subgraph DFA1_1902100946["DFA1 {1}"]
NFA185_1_51277242_1("NFA185-1 char[1]")
end
subgraph DFA2_939247267["DFA2 {1}"]
NFA185_3_58841998_2("NFA185-3 char[1]")
end
subgraph DFA3_-647970591["DFA3 {1}"]
NFA185_5_59815938_3("NFA185-5 char[1]")
end
subgraph DFA4_1322624606["DFA4 {1}"]
NFA185_7_1472535_4("NFA185-7 char[1]")
end
subgraph DFA5_523199712["DFA5 {1}"]
NFA185_9_13252823_5("NFA185-9 char[1]")
end
subgraph DFA6_1211446540["DFA6 {1}"]
NFA185_11_52166545_6("NFA185-11 char[1]")
end
subgraph DFA7_-392396344["DFA7 {1}"]
NFA185_13_66845728_7("NFA185-13 char[1]")
end
subgraph DFA8_-1384819704["DFA8 {1}"]
NFA185_15_64740644_8("NFA185-15 char[1]")
end
subgraph DFA9_643385764["DFA9 {1}"]
NFA185_17_45794886_9("NFA185-17 char[1]")
end
subgraph DFA10_-2055391672["DFA10 {1}"]
NFA185_19_9500791_10("NFA185-19 char[1]")
end
subgraph DFA11_-1731056753["DFA11 {1}"]
NFA185_21_18398256_11("NFA185-21 char[1]")
end
subgraph DFA12_1933344923["DFA12 {1}"]
NFA185_23_31366578_12("NFA185-23 char[1]")
end
subgraph DFA13_-357467635["DFA13 {1}"]
NFA185_25_13863750_13("NFA185-25 char[1]")
end
subgraph DFA14_1439459861["DFA14 {1}"]
NFA185_27_57664894_14("NFA185-27 char[1]")
end
subgraph DFA15_2015528221["DFA15 {1}"]
NFA185_29_49222002_15[\"NFA185-29 char[1]"/]
end
DFA0_157616664 -->|"i"|DFA1_1902100946
DFA1_1902100946 -->|"i"|DFA2_939247267
DFA2_939247267 -->|"m"|DFA3_-647970591
DFA3_-647970591 -->|"a"|DFA4_1322624606
DFA4_1322624606 -->|"g"|DFA5_523199712
DFA5_523199712 -->|"e"|DFA6_1211446540
DFA6_1211446540 -->|"C"|DFA7_-392396344
DFA7_-392396344 -->|"u"|DFA8_-1384819704
DFA8_-1384819704 -->|"b"|DFA9_643385764
DFA9_643385764 -->|"e"|DFA10_-2055391672
DFA10_-2055391672 -->|"A"|DFA11_-1731056753
DFA11_-1731056753 -->|"r"|DFA12_1933344923
DFA12_1933344923 -->|"r"|DFA13_-357467635
DFA13_-357467635 -->|"a"|DFA14_1439459861
DFA14_1439459861 -->|"y"|DFA15_2015528221
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
DFA0_157616664{{"DFA0 regex start"}}
DFA1_1902100946{{"DFA1 {1}"}}
DFA2_939247267{{"DFA2 {1}"}}
DFA3_-647970591{{"DFA3 {1}"}}
DFA4_1322624606{{"DFA4 {1}"}}
DFA5_523199712{{"DFA5 {1}"}}
DFA6_1211446540{{"DFA6 {1}"}}
DFA7_-392396344{{"DFA7 {1}"}}
DFA8_-1384819704{{"DFA8 {1}"}}
DFA9_643385764{{"DFA9 {1}"}}
DFA10_-2055391672{{"DFA10 {1}"}}
DFA11_-1731056753{{"DFA11 {1}"}}
DFA12_1933344923{{"DFA12 {1}"}}
DFA13_-357467635{{"DFA13 {1}"}}
DFA14_1439459861{{"DFA14 {1}"}}
DFA15_2015528221[\"DFA15 {1}"/]
DFA0_157616664 -->|"i"|DFA1_1902100946
DFA1_1902100946 -->|"i"|DFA2_939247267
DFA2_939247267 -->|"m"|DFA3_-647970591
DFA3_-647970591 -->|"a"|DFA4_1322624606
DFA4_1322624606 -->|"g"|DFA5_523199712
DFA5_523199712 -->|"e"|DFA6_1211446540
DFA6_1211446540 -->|"C"|DFA7_-392396344
DFA7_-392396344 -->|"u"|DFA8_-1384819704
DFA8_-1384819704 -->|"b"|DFA9_643385764
DFA9_643385764 -->|"e"|DFA10_-2055391672
DFA10_-2055391672 -->|"A"|DFA11_-1731056753
DFA11_-1731056753 -->|"r"|DFA12_1933344923
DFA12_1933344923 -->|"r"|DFA13_-357467635
DFA13_-357467635 -->|"a"|DFA14_1439459861
DFA14_1439459861 -->|"y"|DFA15_2015528221
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
subgraph MiniDFA0_-60653083["MiniDFA0 {1}"]
DFA0_157616664_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1109194711["MiniDFA1 {1}"]
DFA1_1902100946_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1370160471["MiniDFA2 {1}"]
DFA2_939247267_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1752855692["MiniDFA3 {1}"]
DFA3_-647970591_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_395862454["MiniDFA5 {1}"]
DFA4_1322624606_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_799725938["MiniDFA6 {1}"]
DFA5_523199712_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_-163979280["MiniDFA8 {1}"]
DFA6_1211446540_6{{"DFA6 {1}"}}
end
subgraph MiniDFA9_-820078943["MiniDFA9 {1}"]
DFA7_-392396344_7{{"DFA7 {1}"}}
end
subgraph MiniDFA10_-116762569["MiniDFA10 {1}"]
DFA8_-1384819704_8{{"DFA8 {1}"}}
end
subgraph MiniDFA7_1002288807["MiniDFA7 {1}"]
DFA9_643385764_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_1669621861["MiniDFA11 {1}"]
DFA10_-2055391672_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_-416337290["MiniDFA12 {1}"]
DFA11_-1731056753_11{{"DFA11 {1}"}}
end
subgraph MiniDFA13_-2010774252["MiniDFA13 {1}"]
DFA12_1933344923_12{{"DFA12 {1}"}}
end
subgraph MiniDFA4_-279657026["MiniDFA4 {1}"]
DFA13_-357467635_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1951655624["MiniDFA14 {1}"]
DFA14_1439459861_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_518019626["MiniDFA15 {1}"]
DFA15_2015528221_15[\"DFA15 {1}"/]
end
MiniDFA0_-60653083 -->|"i"|MiniDFA1_-1109194711
MiniDFA1_-1109194711 -->|"i"|MiniDFA2_1370160471
MiniDFA2_1370160471 -->|"m"|MiniDFA3_-1752855692
MiniDFA3_-1752855692 -->|"a"|MiniDFA5_395862454
MiniDFA5_395862454 -->|"g"|MiniDFA6_799725938
MiniDFA6_799725938 -->|"e"|MiniDFA8_-163979280
MiniDFA8_-163979280 -->|"C"|MiniDFA9_-820078943
MiniDFA9_-820078943 -->|"u"|MiniDFA10_-116762569
MiniDFA10_-116762569 -->|"b"|MiniDFA7_1002288807
MiniDFA7_1002288807 -->|"e"|MiniDFA11_1669621861
MiniDFA11_1669621861 -->|"A"|MiniDFA12_-416337290
MiniDFA12_-416337290 -->|"r"|MiniDFA13_-2010774252
MiniDFA13_-2010774252 -->|"r"|MiniDFA4_-279657026
MiniDFA4_-279657026 -->|"a"|MiniDFA14_1951655624
MiniDFA14_1951655624 -->|"y"|MiniDFA15_518019626
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
MiniDFA0_-60653083(["MiniDFA0 {1}"])
MiniDFA1_-1109194711(["MiniDFA1 {1}"])
MiniDFA2_1370160471(["MiniDFA2 {1}"])
MiniDFA3_-1752855692(["MiniDFA3 {1}"])
MiniDFA5_395862454(["MiniDFA5 {1}"])
MiniDFA6_799725938(["MiniDFA6 {1}"])
MiniDFA8_-163979280(["MiniDFA8 {1}"])
MiniDFA9_-820078943(["MiniDFA9 {1}"])
MiniDFA10_-116762569(["MiniDFA10 {1}"])
MiniDFA7_1002288807(["MiniDFA7 {1}"])
MiniDFA11_1669621861(["MiniDFA11 {1}"])
MiniDFA12_-416337290(["MiniDFA12 {1}"])
MiniDFA13_-2010774252(["MiniDFA13 {1}"])
MiniDFA4_-279657026(["MiniDFA4 {1}"])
MiniDFA14_1951655624(["MiniDFA14 {1}"])
MiniDFA15_518019626[\"MiniDFA15 {1}"/]
MiniDFA0_-60653083 -->|"i"|MiniDFA1_-1109194711
MiniDFA1_-1109194711 -->|"i"|MiniDFA2_1370160471
MiniDFA2_1370160471 -->|"m"|MiniDFA3_-1752855692
MiniDFA3_-1752855692 -->|"a"|MiniDFA5_395862454
MiniDFA5_395862454 -->|"g"|MiniDFA6_799725938
MiniDFA6_799725938 -->|"e"|MiniDFA8_-163979280
MiniDFA8_-163979280 -->|"C"|MiniDFA9_-820078943
MiniDFA9_-820078943 -->|"u"|MiniDFA10_-116762569
MiniDFA10_-116762569 -->|"b"|MiniDFA7_1002288807
MiniDFA7_1002288807 -->|"e"|MiniDFA11_1669621861
MiniDFA11_1669621861 -->|"A"|MiniDFA12_-416337290
MiniDFA12_-416337290 -->|"r"|MiniDFA13_-2010774252
MiniDFA13_-2010774252 -->|"r"|MiniDFA4_-279657026
MiniDFA4_-279657026 -->|"a"|MiniDFA14_1951655624
MiniDFA14_1951655624 -->|"y"|MiniDFA15_518019626
```
-------------------------------
