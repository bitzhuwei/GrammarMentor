# 'usamplerCubeArray'

pattern: `usamplerCubeArray`

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
eNFA146_34_36267453[["εNFA146-34 regex start"]]
eNFA146_0_57971626[["εNFA146-0 char{1, 1}"]]
eNFA146_1_51982593[["εNFA146-1 char[1]"]]
eNFA146_2_65190153[["εNFA146-2 char{1, 1}"]]
eNFA146_3_49840468[["εNFA146-3 char[1]"]]
eNFA146_4_45911036[["εNFA146-4 char{1, 1}"]]
eNFA146_5_10546145[["εNFA146-5 char[1]"]]
eNFA146_6_27806444[["εNFA146-6 char{1, 1}"]]
eNFA146_7_48931406[["εNFA146-7 char[1]"]]
eNFA146_8_37729472[["εNFA146-8 char{1, 1}"]]
eNFA146_9_4020931[["εNFA146-9 char[1]"]]
eNFA146_10_36188385[["εNFA146-10 char{1, 1}"]]
eNFA146_11_57260009[["εNFA146-11 char[1]"]]
eNFA146_12_45578038[["εNFA146-12 char{1, 1}"]]
eNFA146_13_7549159[["εNFA146-13 char[1]"]]
eNFA146_14_833575[["εNFA146-14 char{1, 1}"]]
eNFA146_15_7502182[["εNFA146-15 char[1]"]]
eNFA146_16_410782[["εNFA146-16 char{1, 1}"]]
eNFA146_17_3697038[["εNFA146-17 char[1]"]]
eNFA146_18_33273344[["εNFA146-18 char{1, 1}"]]
eNFA146_19_31024646[["εNFA146-19 char[1]"]]
eNFA146_20_10786359[["εNFA146-20 char{1, 1}"]]
eNFA146_21_29968374[["εNFA146-21 char[1]"]]
eNFA146_22_1279915[["εNFA146-22 char{1, 1}"]]
eNFA146_23_11519239[["εNFA146-23 char[1]"]]
eNFA146_24_36564291[["εNFA146-24 char{1, 1}"]]
eNFA146_25_60643168[["εNFA146-25 char[1]"]]
eNFA146_26_8917608[["εNFA146-26 char{1, 1}"]]
eNFA146_27_13149610[["εNFA146-27 char[1]"]]
eNFA146_28_51237633[["εNFA146-28 char{1, 1}"]]
eNFA146_29_58485517[["εNFA146-29 char[1]"]]
eNFA146_30_56607607[["εNFA146-30 char{1, 1}"]]
eNFA146_31_39706416[["εNFA146-31 char[1]"]]
eNFA146_32_21813425[["εNFA146-32 char{1, 1}"]]
eNFA146_33_62103099[["εNFA146-33 char[1]"]]
eNFA146_35_22056983[["εNFA146-35 regex end"]]
eNFA146_36_64295127[["εNFA146-36 post-regex start"]]
eNFA146_37_41785235[\"εNFA146-37 post-regex end"/]
eNFA146_34_36267453 -.->|"ε"|eNFA146_0_57971626
eNFA146_0_57971626 -->|"u"|eNFA146_1_51982593
eNFA146_1_51982593 -.->|"ε"|eNFA146_2_65190153
eNFA146_2_65190153 -->|"s"|eNFA146_3_49840468
eNFA146_3_49840468 -.->|"ε"|eNFA146_4_45911036
eNFA146_4_45911036 -->|"a"|eNFA146_5_10546145
eNFA146_5_10546145 -.->|"ε"|eNFA146_6_27806444
eNFA146_6_27806444 -->|"m"|eNFA146_7_48931406
eNFA146_7_48931406 -.->|"ε"|eNFA146_8_37729472
eNFA146_8_37729472 -->|"p"|eNFA146_9_4020931
eNFA146_9_4020931 -.->|"ε"|eNFA146_10_36188385
eNFA146_10_36188385 -->|"l"|eNFA146_11_57260009
eNFA146_11_57260009 -.->|"ε"|eNFA146_12_45578038
eNFA146_12_45578038 -->|"e"|eNFA146_13_7549159
eNFA146_13_7549159 -.->|"ε"|eNFA146_14_833575
eNFA146_14_833575 -->|"r"|eNFA146_15_7502182
eNFA146_15_7502182 -.->|"ε"|eNFA146_16_410782
eNFA146_16_410782 -->|"C"|eNFA146_17_3697038
eNFA146_17_3697038 -.->|"ε"|eNFA146_18_33273344
eNFA146_18_33273344 -->|"u"|eNFA146_19_31024646
eNFA146_19_31024646 -.->|"ε"|eNFA146_20_10786359
eNFA146_20_10786359 -->|"b"|eNFA146_21_29968374
eNFA146_21_29968374 -.->|"ε"|eNFA146_22_1279915
eNFA146_22_1279915 -->|"e"|eNFA146_23_11519239
eNFA146_23_11519239 -.->|"ε"|eNFA146_24_36564291
eNFA146_24_36564291 -->|"A"|eNFA146_25_60643168
eNFA146_25_60643168 -.->|"ε"|eNFA146_26_8917608
eNFA146_26_8917608 -->|"r"|eNFA146_27_13149610
eNFA146_27_13149610 -.->|"ε"|eNFA146_28_51237633
eNFA146_28_51237633 -->|"r"|eNFA146_29_58485517
eNFA146_29_58485517 -.->|"ε"|eNFA146_30_56607607
eNFA146_30_56607607 -->|"a"|eNFA146_31_39706416
eNFA146_31_39706416 -.->|"ε"|eNFA146_32_21813425
eNFA146_32_21813425 -->|"y"|eNFA146_33_62103099
eNFA146_33_62103099 -.->|"ε"|eNFA146_35_22056983
eNFA146_35_22056983 -.->|"ε"|eNFA146_36_64295127
eNFA146_36_64295127 -.->|"ε"|eNFA146_37_41785235
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
eNFA146_34_40522795[["εNFA146-34 regex start"]]
eNFA146_0_29160842[["εNFA146-0 char{1, 1}"]]
eNFA146_1_61120992[["εNFA146-1 char[1]"]]
eNFA146_2_13218022[["εNFA146-2 char{1, 1}"]]
eNFA146_3_51853342[["εNFA146-3 char[1]"]]
eNFA146_4_64026895[["εNFA146-4 char{1, 1}"]]
eNFA146_5_39371148[["εNFA146-5 char[1]"]]
eNFA146_6_18796012[["εNFA146-6 char{1, 1}"]]
eNFA146_7_34946386[["εNFA146-7 char[1]"]]
eNFA146_8_46082022[["εNFA146-8 char{1, 1}"]]
eNFA146_9_12085017[["εNFA146-9 char[1]"]]
eNFA146_10_41656292[["εNFA146-10 char{1, 1}"]]
eNFA146_11_39362312[["εNFA146-11 char[1]"]]
eNFA146_12_18716495[["εNFA146-12 char{1, 1}"]]
eNFA146_13_34230728[["εNFA146-13 char[1]"]]
eNFA146_14_39641102[["εNFA146-14 char{1, 1}"]]
eNFA146_15_21225601[["εNFA146-15 char[1]"]]
eNFA146_16_56812682[["εNFA146-16 char{1, 1}"]]
eNFA146_17_41552090[["εNFA146-17 char[1]"]]
eNFA146_18_38424490[["εNFA146-18 char{1, 1}"]]
eNFA146_19_10276091[["εNFA146-19 char[1]"]]
eNFA146_20_25375958[["εNFA146-20 char{1, 1}"]]
eNFA146_21_27057037[["εNFA146-21 char[1]"]]
eNFA146_22_42186743[["εNFA146-22 char{1, 1}"]]
eNFA146_23_44136375[["εNFA146-23 char[1]"]]
eNFA146_24_61683061[["εNFA146-24 char{1, 1}"]]
eNFA146_25_18276642[["εNFA146-25 char[1]"]]
eNFA146_26_30272055[["εNFA146-26 char{1, 1}"]]
eNFA146_27_4013046[["εNFA146-27 char[1]"]]
eNFA146_28_36117414[["εNFA146-28 char{1, 1}"]]
eNFA146_29_56621273[["εNFA146-29 char[1]"]]
eNFA146_30_39829417[["εNFA146-30 char{1, 1}"]]
eNFA146_31_22920438[["εNFA146-31 char[1]"]]
eNFA146_32_4957353[["εNFA146-32 char{1, 1}"]]
eNFA146_33_44616179[\"εNFA146-33 char[1]"/]
eNFA146_35_66001293[\"εNFA146-35 regex end"/]
eNFA146_36_57140728[\"εNFA146-36 post-regex start"/]
eNFA146_37_44504510[\"εNFA146-37 post-regex end"/]
eNFA146_34_40522795 -.->|"ε"|eNFA146_0_29160842
eNFA146_34_40522795 -->|"u"|eNFA146_1_61120992
eNFA146_0_29160842 -->|"u"|eNFA146_1_61120992
eNFA146_1_61120992 -.->|"ε"|eNFA146_2_13218022
eNFA146_1_61120992 -->|"s"|eNFA146_3_51853342
eNFA146_2_13218022 -->|"s"|eNFA146_3_51853342
eNFA146_3_51853342 -.->|"ε"|eNFA146_4_64026895
eNFA146_3_51853342 -->|"a"|eNFA146_5_39371148
eNFA146_4_64026895 -->|"a"|eNFA146_5_39371148
eNFA146_5_39371148 -.->|"ε"|eNFA146_6_18796012
eNFA146_5_39371148 -->|"m"|eNFA146_7_34946386
eNFA146_6_18796012 -->|"m"|eNFA146_7_34946386
eNFA146_7_34946386 -.->|"ε"|eNFA146_8_46082022
eNFA146_7_34946386 -->|"p"|eNFA146_9_12085017
eNFA146_8_46082022 -->|"p"|eNFA146_9_12085017
eNFA146_9_12085017 -.->|"ε"|eNFA146_10_41656292
eNFA146_9_12085017 -->|"l"|eNFA146_11_39362312
eNFA146_10_41656292 -->|"l"|eNFA146_11_39362312
eNFA146_11_39362312 -.->|"ε"|eNFA146_12_18716495
eNFA146_11_39362312 -->|"e"|eNFA146_13_34230728
eNFA146_12_18716495 -->|"e"|eNFA146_13_34230728
eNFA146_13_34230728 -.->|"ε"|eNFA146_14_39641102
eNFA146_13_34230728 -->|"r"|eNFA146_15_21225601
eNFA146_14_39641102 -->|"r"|eNFA146_15_21225601
eNFA146_15_21225601 -.->|"ε"|eNFA146_16_56812682
eNFA146_15_21225601 -->|"C"|eNFA146_17_41552090
eNFA146_16_56812682 -->|"C"|eNFA146_17_41552090
eNFA146_17_41552090 -.->|"ε"|eNFA146_18_38424490
eNFA146_17_41552090 -->|"u"|eNFA146_19_10276091
eNFA146_18_38424490 -->|"u"|eNFA146_19_10276091
eNFA146_19_10276091 -.->|"ε"|eNFA146_20_25375958
eNFA146_19_10276091 -->|"b"|eNFA146_21_27057037
eNFA146_20_25375958 -->|"b"|eNFA146_21_27057037
eNFA146_21_27057037 -.->|"ε"|eNFA146_22_42186743
eNFA146_21_27057037 -->|"e"|eNFA146_23_44136375
eNFA146_22_42186743 -->|"e"|eNFA146_23_44136375
eNFA146_23_44136375 -.->|"ε"|eNFA146_24_61683061
eNFA146_23_44136375 -->|"A"|eNFA146_25_18276642
eNFA146_24_61683061 -->|"A"|eNFA146_25_18276642
eNFA146_25_18276642 -.->|"ε"|eNFA146_26_30272055
eNFA146_25_18276642 -->|"r"|eNFA146_27_4013046
eNFA146_26_30272055 -->|"r"|eNFA146_27_4013046
eNFA146_27_4013046 -.->|"ε"|eNFA146_28_36117414
eNFA146_27_4013046 -->|"r"|eNFA146_29_56621273
eNFA146_28_36117414 -->|"r"|eNFA146_29_56621273
eNFA146_29_56621273 -.->|"ε"|eNFA146_30_39829417
eNFA146_29_56621273 -->|"a"|eNFA146_31_22920438
eNFA146_30_39829417 -->|"a"|eNFA146_31_22920438
eNFA146_31_22920438 -.->|"ε"|eNFA146_32_4957353
eNFA146_31_22920438 -->|"y"|eNFA146_33_44616179
eNFA146_32_4957353 -->|"y"|eNFA146_33_44616179
eNFA146_33_44616179 -.->|"ε"|eNFA146_35_66001293
eNFA146_33_44616179 -.->|"ε"|eNFA146_36_57140728
eNFA146_33_44616179 -.->|"ε"|eNFA146_37_44504510
eNFA146_35_66001293 -.->|"ε"|eNFA146_36_57140728
eNFA146_35_66001293 -.->|"ε"|eNFA146_37_44504510
eNFA146_36_57140728 -.->|"ε"|eNFA146_37_44504510
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
NFA146_34_64996270("NFA146-34 regex start")
NFA146_1_48095523("NFA146-1 char[1]")
NFA146_3_30206524("NFA146-3 char[1]")
NFA146_5_3423268("NFA146-5 char[1]")
NFA146_7_30809419("NFA146-7 char[1]")
NFA146_9_8849323("NFA146-9 char[1]")
NFA146_11_12535043("NFA146-11 char[1]")
NFA146_13_45706525("NFA146-13 char[1]")
NFA146_15_8705547("NFA146-15 char[1]")
NFA146_17_11241060("NFA146-17 char[1]")
NFA146_19_34060683("NFA146-19 char[1]")
NFA146_21_38110696("NFA146-21 char[1]")
NFA146_23_7451948("NFA146-23 char[1]")
NFA146_25_67067536("NFA146-25 char[1]")
NFA146_27_66736917("NFA146-27 char[1]")
NFA146_29_63761349("NFA146-29 char[1]")
NFA146_31_36981231("NFA146-31 char[1]")
NFA146_33_64395630[\"NFA146-33 char[1]"/]
NFA146_34_64996270 -->|"u"|NFA146_1_48095523
NFA146_1_48095523 -->|"s"|NFA146_3_30206524
NFA146_3_30206524 -->|"a"|NFA146_5_3423268
NFA146_5_3423268 -->|"m"|NFA146_7_30809419
NFA146_7_30809419 -->|"p"|NFA146_9_8849323
NFA146_9_8849323 -->|"l"|NFA146_11_12535043
NFA146_11_12535043 -->|"e"|NFA146_13_45706525
NFA146_13_45706525 -->|"r"|NFA146_15_8705547
NFA146_15_8705547 -->|"C"|NFA146_17_11241060
NFA146_17_11241060 -->|"u"|NFA146_19_34060683
NFA146_19_34060683 -->|"b"|NFA146_21_38110696
NFA146_21_38110696 -->|"e"|NFA146_23_7451948
NFA146_23_7451948 -->|"A"|NFA146_25_67067536
NFA146_25_67067536 -->|"r"|NFA146_27_66736917
NFA146_27_66736917 -->|"r"|NFA146_29_63761349
NFA146_29_63761349 -->|"a"|NFA146_31_36981231
NFA146_31_36981231 -->|"y"|NFA146_33_64395630
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
subgraph DFA0_974410901["DFA0 regex start"]
NFA146_34_64996270_0("NFA146-34 regex start")
end
subgraph DFA1_-2090892559["DFA1 {1}"]
NFA146_1_48095523_1("NFA146-1 char[1]")
end
subgraph DFA2_1316175587["DFA2 {1}"]
NFA146_3_30206524_2("NFA146-3 char[1]")
end
subgraph DFA3_-242323174["DFA3 {1}"]
NFA146_5_3423268_3("NFA146-5 char[1]")
end
subgraph DFA4_946912063["DFA4 {1}"]
NFA146_7_30809419_4("NFA146-7 char[1]")
end
subgraph DFA5_-2110633370["DFA5 {1}"]
NFA146_9_8849323_5("NFA146-9 char[1]")
end
subgraph DFA6_-1541853847["DFA6 {1}"]
NFA146_11_12535043_6("NFA146-11 char[1]")
end
subgraph DFA7_1049003886["DFA7 {1}"]
NFA146_13_45706525_7("NFA146-13 char[1]")
end
subgraph DFA8_831892096["DFA8 {1}"]
NFA146_15_8705547_8("NFA146-15 char[1]")
end
subgraph DFA9_428756666["DFA9 {1}"]
NFA146_17_11241060_9("NFA146-17 char[1]")
end
subgraph DFA10_-1077145697["DFA10 {1}"]
NFA146_19_34060683_10("NFA146-19 char[1]")
end
subgraph DFA11_-1294456897["DFA11 {1}"]
NFA146_21_38110696_11("NFA146-21 char[1]")
end
subgraph DFA12_1483878704["DFA12 {1}"]
NFA146_23_7451948_12("NFA146-23 char[1]")
end
subgraph DFA13_-1102883668["DFA13 {1}"]
NFA146_25_67067536_13("NFA146-25 char[1]")
end
subgraph DFA14_-1030696623["DFA14 {1}"]
NFA146_27_66736917_14("NFA146-27 char[1]")
end
subgraph DFA15_628704808["DFA15 {1}"]
NFA146_29_63761349_15("NFA146-29 char[1]")
end
subgraph DFA16_1379683725["DFA16 {1}"]
NFA146_31_36981231_16("NFA146-31 char[1]")
end
subgraph DFA17_965118415["DFA17 {1}"]
NFA146_33_64395630_17[\"NFA146-33 char[1]"/]
end
DFA0_974410901 -->|"u"|DFA1_-2090892559
DFA1_-2090892559 -->|"s"|DFA2_1316175587
DFA2_1316175587 -->|"a"|DFA3_-242323174
DFA3_-242323174 -->|"m"|DFA4_946912063
DFA4_946912063 -->|"p"|DFA5_-2110633370
DFA5_-2110633370 -->|"l"|DFA6_-1541853847
DFA6_-1541853847 -->|"e"|DFA7_1049003886
DFA7_1049003886 -->|"r"|DFA8_831892096
DFA8_831892096 -->|"C"|DFA9_428756666
DFA9_428756666 -->|"u"|DFA10_-1077145697
DFA10_-1077145697 -->|"b"|DFA11_-1294456897
DFA11_-1294456897 -->|"e"|DFA12_1483878704
DFA12_1483878704 -->|"A"|DFA13_-1102883668
DFA13_-1102883668 -->|"r"|DFA14_-1030696623
DFA14_-1030696623 -->|"r"|DFA15_628704808
DFA15_628704808 -->|"a"|DFA16_1379683725
DFA16_1379683725 -->|"y"|DFA17_965118415
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
DFA0_974410901{{"DFA0 regex start"}}
DFA1_-2090892559{{"DFA1 {1}"}}
DFA2_1316175587{{"DFA2 {1}"}}
DFA3_-242323174{{"DFA3 {1}"}}
DFA4_946912063{{"DFA4 {1}"}}
DFA5_-2110633370{{"DFA5 {1}"}}
DFA6_-1541853847{{"DFA6 {1}"}}
DFA7_1049003886{{"DFA7 {1}"}}
DFA8_831892096{{"DFA8 {1}"}}
DFA9_428756666{{"DFA9 {1}"}}
DFA10_-1077145697{{"DFA10 {1}"}}
DFA11_-1294456897{{"DFA11 {1}"}}
DFA12_1483878704{{"DFA12 {1}"}}
DFA13_-1102883668{{"DFA13 {1}"}}
DFA14_-1030696623{{"DFA14 {1}"}}
DFA15_628704808{{"DFA15 {1}"}}
DFA16_1379683725{{"DFA16 {1}"}}
DFA17_965118415[\"DFA17 {1}"/]
DFA0_974410901 -->|"u"|DFA1_-2090892559
DFA1_-2090892559 -->|"s"|DFA2_1316175587
DFA2_1316175587 -->|"a"|DFA3_-242323174
DFA3_-242323174 -->|"m"|DFA4_946912063
DFA4_946912063 -->|"p"|DFA5_-2110633370
DFA5_-2110633370 -->|"l"|DFA6_-1541853847
DFA6_-1541853847 -->|"e"|DFA7_1049003886
DFA7_1049003886 -->|"r"|DFA8_831892096
DFA8_831892096 -->|"C"|DFA9_428756666
DFA9_428756666 -->|"u"|DFA10_-1077145697
DFA10_-1077145697 -->|"b"|DFA11_-1294456897
DFA11_-1294456897 -->|"e"|DFA12_1483878704
DFA12_1483878704 -->|"A"|DFA13_-1102883668
DFA13_-1102883668 -->|"r"|DFA14_-1030696623
DFA14_-1030696623 -->|"r"|DFA15_628704808
DFA15_628704808 -->|"a"|DFA16_1379683725
DFA16_1379683725 -->|"y"|DFA17_965118415
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
subgraph MiniDFA0_1359918871["MiniDFA0 {1}"]
DFA0_974410901_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_-2057850503["MiniDFA2 {1}"]
DFA1_-2090892559_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_1731107664["MiniDFA3 {1}"]
DFA2_1316175587_2{{"DFA2 {1}"}}
end
subgraph MiniDFA5_-1503066810["MiniDFA5 {1}"]
DFA3_-242323174_3{{"DFA3 {1}"}}
end
subgraph MiniDFA6_-374827854["MiniDFA6 {1}"]
DFA4_946912063_4{{"DFA4 {1}"}}
end
subgraph MiniDFA7_1022433765["MiniDFA7 {1}"]
DFA5_-2110633370_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_-2070506051["MiniDFA8 {1}"]
DFA6_-1541853847_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_669203716["MiniDFA10 {1}"]
DFA7_1049003886_7{{"DFA7 {1}"}}
end
subgraph MiniDFA13_-2000637468["MiniDFA13 {1}"]
DFA8_831892096_8{{"DFA8 {1}"}}
end
subgraph MiniDFA1_-1926865957["MiniDFA1 {1}"]
DFA9_428756666_9{{"DFA9 {1}"}}
end
subgraph MiniDFA14_-1236087489["MiniDFA14 {1}"]
DFA10_-1077145697_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_-2108799256["MiniDFA9 {1}"]
DFA11_-1294456897_11{{"DFA11 {1}"}}
end
subgraph MiniDFA15_1466563930["MiniDFA15 {1}"]
DFA12_1483878704_12{{"DFA12 {1}"}}
end
subgraph MiniDFA11_-135207612["MiniDFA11 {1}"]
DFA13_-1102883668_13{{"DFA13 {1}"}}
end
subgraph MiniDFA12_-2144976381["MiniDFA12 {1}"]
DFA14_-1030696623_14{{"DFA14 {1}"}}
end
subgraph MiniDFA4_-593684795["MiniDFA4 {1}"]
DFA15_628704808_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_651729537["MiniDFA16 {1}"]
DFA16_1379683725_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_1173141555["MiniDFA17 {1}"]
DFA17_965118415_17[\"DFA17 {1}"/]
end
MiniDFA0_1359918871 -->|"u"|MiniDFA2_-2057850503
MiniDFA2_-2057850503 -->|"s"|MiniDFA3_1731107664
MiniDFA3_1731107664 -->|"a"|MiniDFA5_-1503066810
MiniDFA5_-1503066810 -->|"m"|MiniDFA6_-374827854
MiniDFA6_-374827854 -->|"p"|MiniDFA7_1022433765
MiniDFA7_1022433765 -->|"l"|MiniDFA8_-2070506051
MiniDFA8_-2070506051 -->|"e"|MiniDFA10_669203716
MiniDFA10_669203716 -->|"r"|MiniDFA13_-2000637468
MiniDFA13_-2000637468 -->|"C"|MiniDFA1_-1926865957
MiniDFA1_-1926865957 -->|"u"|MiniDFA14_-1236087489
MiniDFA14_-1236087489 -->|"b"|MiniDFA9_-2108799256
MiniDFA9_-2108799256 -->|"e"|MiniDFA15_1466563930
MiniDFA15_1466563930 -->|"A"|MiniDFA11_-135207612
MiniDFA11_-135207612 -->|"r"|MiniDFA12_-2144976381
MiniDFA12_-2144976381 -->|"r"|MiniDFA4_-593684795
MiniDFA4_-593684795 -->|"a"|MiniDFA16_651729537
MiniDFA16_651729537 -->|"y"|MiniDFA17_1173141555
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
MiniDFA0_1359918871(["MiniDFA0 {1}"])
MiniDFA2_-2057850503(["MiniDFA2 {1}"])
MiniDFA3_1731107664(["MiniDFA3 {1}"])
MiniDFA5_-1503066810(["MiniDFA5 {1}"])
MiniDFA6_-374827854(["MiniDFA6 {1}"])
MiniDFA7_1022433765(["MiniDFA7 {1}"])
MiniDFA8_-2070506051(["MiniDFA8 {1}"])
MiniDFA10_669203716(["MiniDFA10 {1}"])
MiniDFA13_-2000637468(["MiniDFA13 {1}"])
MiniDFA1_-1926865957(["MiniDFA1 {1}"])
MiniDFA14_-1236087489(["MiniDFA14 {1}"])
MiniDFA9_-2108799256(["MiniDFA9 {1}"])
MiniDFA15_1466563930(["MiniDFA15 {1}"])
MiniDFA11_-135207612(["MiniDFA11 {1}"])
MiniDFA12_-2144976381(["MiniDFA12 {1}"])
MiniDFA4_-593684795(["MiniDFA4 {1}"])
MiniDFA16_651729537(["MiniDFA16 {1}"])
MiniDFA17_1173141555[\"MiniDFA17 {1}"/]
MiniDFA0_1359918871 -->|"u"|MiniDFA2_-2057850503
MiniDFA2_-2057850503 -->|"s"|MiniDFA3_1731107664
MiniDFA3_1731107664 -->|"a"|MiniDFA5_-1503066810
MiniDFA5_-1503066810 -->|"m"|MiniDFA6_-374827854
MiniDFA6_-374827854 -->|"p"|MiniDFA7_1022433765
MiniDFA7_1022433765 -->|"l"|MiniDFA8_-2070506051
MiniDFA8_-2070506051 -->|"e"|MiniDFA10_669203716
MiniDFA10_669203716 -->|"r"|MiniDFA13_-2000637468
MiniDFA13_-2000637468 -->|"C"|MiniDFA1_-1926865957
MiniDFA1_-1926865957 -->|"u"|MiniDFA14_-1236087489
MiniDFA14_-1236087489 -->|"b"|MiniDFA9_-2108799256
MiniDFA9_-2108799256 -->|"e"|MiniDFA15_1466563930
MiniDFA15_1466563930 -->|"A"|MiniDFA11_-135207612
MiniDFA11_-135207612 -->|"r"|MiniDFA12_-2144976381
MiniDFA12_-2144976381 -->|"r"|MiniDFA4_-593684795
MiniDFA4_-593684795 -->|"a"|MiniDFA16_651729537
MiniDFA16_651729537 -->|"y"|MiniDFA17_1173141555
```
-------------------------------
