# 'uimage1DArray'

pattern: `uimage1DArray`

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
eNFA180_26_66933755[["εNFA180-26 regex start"]]
eNFA180_0_65532886[["εNFA180-0 char{1, 1}"]]
eNFA180_1_52925064[["εNFA180-1 char[1]"]]
eNFA180_2_6563530[["εNFA180-2 char{1, 1}"]]
eNFA180_3_59071773[["εNFA180-3 char[1]"]]
eNFA180_4_61883915[["εNFA180-4 char{1, 1}"]]
eNFA180_5_20084323[["εNFA180-5 char[1]"]]
eNFA180_6_46541184[["εNFA180-6 char{1, 1}"]]
eNFA180_7_16217473[["εNFA180-7 char[1]"]]
eNFA180_8_11739537[["εNFA180-8 char{1, 1}"]]
eNFA180_9_38546976[["εNFA180-9 char[1]"]]
eNFA180_10_11378472[["εNFA180-10 char{1, 1}"]]
eNFA180_11_35297384[["εNFA180-11 char[1]"]]
eNFA180_12_49241002[["εNFA180-12 char{1, 1}"]]
eNFA180_13_40515840[["εNFA180-13 char[1]"]]
eNFA180_14_29098241[["εNFA180-14 char{1, 1}"]]
eNFA180_15_60557584[["εNFA180-15 char[1]"]]
eNFA180_16_8147349[["εNFA180-16 char{1, 1}"]]
eNFA180_17_6217281[["εNFA180-17 char[1]"]]
eNFA180_18_55955533[["εNFA180-18 char{1, 1}"]]
eNFA180_19_33837754[["εNFA180-19 char[1]"]]
eNFA180_20_36104338[["εNFA180-20 char{1, 1}"]]
eNFA180_21_56503588[["εNFA180-21 char[1]"]]
eNFA180_22_38770251[["εNFA180-22 char{1, 1}"]]
eNFA180_23_13387943[["εNFA180-23 char[1]"]]
eNFA180_24_53382625[["εNFA180-24 char{1, 1}"]]
eNFA180_25_10681578[["εNFA180-25 char[1]"]]
eNFA180_27_29025339[["εNFA180-27 regex end"]]
eNFA180_28_59901461[["εNFA180-28 post-regex start"]]
eNFA180_29_2242241[\"εNFA180-29 post-regex end"/]
eNFA180_26_66933755 -.->|"ε"|eNFA180_0_65532886
eNFA180_0_65532886 -->|"u"|eNFA180_1_52925064
eNFA180_1_52925064 -.->|"ε"|eNFA180_2_6563530
eNFA180_2_6563530 -->|"i"|eNFA180_3_59071773
eNFA180_3_59071773 -.->|"ε"|eNFA180_4_61883915
eNFA180_4_61883915 -->|"m"|eNFA180_5_20084323
eNFA180_5_20084323 -.->|"ε"|eNFA180_6_46541184
eNFA180_6_46541184 -->|"a"|eNFA180_7_16217473
eNFA180_7_16217473 -.->|"ε"|eNFA180_8_11739537
eNFA180_8_11739537 -->|"g"|eNFA180_9_38546976
eNFA180_9_38546976 -.->|"ε"|eNFA180_10_11378472
eNFA180_10_11378472 -->|"e"|eNFA180_11_35297384
eNFA180_11_35297384 -.->|"ε"|eNFA180_12_49241002
eNFA180_12_49241002 -->|"1"|eNFA180_13_40515840
eNFA180_13_40515840 -.->|"ε"|eNFA180_14_29098241
eNFA180_14_29098241 -->|"D"|eNFA180_15_60557584
eNFA180_15_60557584 -.->|"ε"|eNFA180_16_8147349
eNFA180_16_8147349 -->|"A"|eNFA180_17_6217281
eNFA180_17_6217281 -.->|"ε"|eNFA180_18_55955533
eNFA180_18_55955533 -->|"r"|eNFA180_19_33837754
eNFA180_19_33837754 -.->|"ε"|eNFA180_20_36104338
eNFA180_20_36104338 -->|"r"|eNFA180_21_56503588
eNFA180_21_56503588 -.->|"ε"|eNFA180_22_38770251
eNFA180_22_38770251 -->|"a"|eNFA180_23_13387943
eNFA180_23_13387943 -.->|"ε"|eNFA180_24_53382625
eNFA180_24_53382625 -->|"y"|eNFA180_25_10681578
eNFA180_25_10681578 -.->|"ε"|eNFA180_27_29025339
eNFA180_27_29025339 -.->|"ε"|eNFA180_28_59901461
eNFA180_28_59901461 -.->|"ε"|eNFA180_29_2242241
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
eNFA180_26_20180177[["εNFA180-26 regex start"]]
eNFA180_0_47403869[["εNFA180-0 char{1, 1}"]]
eNFA180_1_23981637[["εNFA180-1 char[1]"]]
eNFA180_2_14508148[["εNFA180-2 char{1, 1}"]]
eNFA180_3_63464474[["εNFA180-3 char[1]"]]
eNFA180_4_34309360[["εNFA180-4 char{1, 1}"]]
eNFA180_5_40348792[["εNFA180-5 char[1]"]]
eNFA180_6_27594809[["εNFA180-6 char{1, 1}"]]
eNFA180_7_47026694[["εNFA180-7 char[1]"]]
eNFA180_8_20587062[["εNFA180-8 char{1, 1}"]]
eNFA180_9_51065836[["εNFA180-9 char[1]"]]
eNFA180_10_56939344[["εNFA180-10 char{1, 1}"]]
eNFA180_11_42692051[["εNFA180-11 char[1]"]]
eNFA180_12_48684142[["εNFA180-12 char{1, 1}"]]
eNFA180_13_35504098[["εNFA180-13 char[1]"]]
eNFA180_14_51101433[["εNFA180-14 char{1, 1}"]]
eNFA180_15_57259714[["εNFA180-15 char[1]"]]
eNFA180_16_45575384[["εNFA180-16 char{1, 1}"]]
eNFA180_17_7525275[["εNFA180-17 char[1]"]]
eNFA180_18_618612[["εNFA180-18 char{1, 1}"]]
eNFA180_19_5567508[["εNFA180-19 char[1]"]]
eNFA180_20_50107572[["εNFA180-20 char{1, 1}"]]
eNFA180_21_48314965[["εNFA180-21 char[1]"]]
eNFA180_22_32181504[["εNFA180-22 char{1, 1}"]]
eNFA180_23_21198087[["εNFA180-23 char[1]"]]
eNFA180_24_56565057[["εNFA180-24 char{1, 1}"]]
eNFA180_25_39323473[\"εNFA180-25 char[1]"/]
eNFA180_27_18366943[\"εNFA180-27 regex end"/]
eNFA180_28_31084764[\"εNFA180-28 post-regex start"/]
eNFA180_29_11327425[\"εNFA180-29 post-regex end"/]
eNFA180_26_20180177 -.->|"ε"|eNFA180_0_47403869
eNFA180_26_20180177 -->|"u"|eNFA180_1_23981637
eNFA180_0_47403869 -->|"u"|eNFA180_1_23981637
eNFA180_1_23981637 -.->|"ε"|eNFA180_2_14508148
eNFA180_1_23981637 -->|"i"|eNFA180_3_63464474
eNFA180_2_14508148 -->|"i"|eNFA180_3_63464474
eNFA180_3_63464474 -.->|"ε"|eNFA180_4_34309360
eNFA180_3_63464474 -->|"m"|eNFA180_5_40348792
eNFA180_4_34309360 -->|"m"|eNFA180_5_40348792
eNFA180_5_40348792 -.->|"ε"|eNFA180_6_27594809
eNFA180_5_40348792 -->|"a"|eNFA180_7_47026694
eNFA180_6_27594809 -->|"a"|eNFA180_7_47026694
eNFA180_7_47026694 -.->|"ε"|eNFA180_8_20587062
eNFA180_7_47026694 -->|"g"|eNFA180_9_51065836
eNFA180_8_20587062 -->|"g"|eNFA180_9_51065836
eNFA180_9_51065836 -.->|"ε"|eNFA180_10_56939344
eNFA180_9_51065836 -->|"e"|eNFA180_11_42692051
eNFA180_10_56939344 -->|"e"|eNFA180_11_42692051
eNFA180_11_42692051 -.->|"ε"|eNFA180_12_48684142
eNFA180_11_42692051 -->|"1"|eNFA180_13_35504098
eNFA180_12_48684142 -->|"1"|eNFA180_13_35504098
eNFA180_13_35504098 -.->|"ε"|eNFA180_14_51101433
eNFA180_13_35504098 -->|"D"|eNFA180_15_57259714
eNFA180_14_51101433 -->|"D"|eNFA180_15_57259714
eNFA180_15_57259714 -.->|"ε"|eNFA180_16_45575384
eNFA180_15_57259714 -->|"A"|eNFA180_17_7525275
eNFA180_16_45575384 -->|"A"|eNFA180_17_7525275
eNFA180_17_7525275 -.->|"ε"|eNFA180_18_618612
eNFA180_17_7525275 -->|"r"|eNFA180_19_5567508
eNFA180_18_618612 -->|"r"|eNFA180_19_5567508
eNFA180_19_5567508 -.->|"ε"|eNFA180_20_50107572
eNFA180_19_5567508 -->|"r"|eNFA180_21_48314965
eNFA180_20_50107572 -->|"r"|eNFA180_21_48314965
eNFA180_21_48314965 -.->|"ε"|eNFA180_22_32181504
eNFA180_21_48314965 -->|"a"|eNFA180_23_21198087
eNFA180_22_32181504 -->|"a"|eNFA180_23_21198087
eNFA180_23_21198087 -.->|"ε"|eNFA180_24_56565057
eNFA180_23_21198087 -->|"y"|eNFA180_25_39323473
eNFA180_24_56565057 -->|"y"|eNFA180_25_39323473
eNFA180_25_39323473 -.->|"ε"|eNFA180_27_18366943
eNFA180_25_39323473 -.->|"ε"|eNFA180_28_31084764
eNFA180_25_39323473 -.->|"ε"|eNFA180_29_11327425
eNFA180_27_18366943 -.->|"ε"|eNFA180_28_31084764
eNFA180_27_18366943 -.->|"ε"|eNFA180_29_11327425
eNFA180_28_31084764 -.->|"ε"|eNFA180_29_11327425
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
NFA180_26_34837968("NFA180-26 regex start")
NFA180_1_45106256("NFA180-1 char[1]")
NFA180_3_3303123("NFA180-3 char[1]")
NFA180_5_29728115("NFA180-5 char[1]")
NFA180_7_66226448("NFA180-7 char[1]")
NFA180_9_59167123("NFA180-9 char[1]")
NFA180_11_62742061("NFA180-11 char[1]")
NFA180_13_27807639("NFA180-13 char[1]")
NFA180_15_48942162("NFA180-15 char[1]")
NFA180_17_37826280("NFA180-17 char[1]")
NFA180_19_4892200("NFA180-19 char[1]")
NFA180_21_44029805("NFA180-21 char[1]")
NFA180_23_60723926("NFA180-23 char[1]")
NFA180_25_9644430[\"NFA180-25 char[1]"/]
NFA180_26_34837968 -->|"u"|NFA180_1_45106256
NFA180_1_45106256 -->|"i"|NFA180_3_3303123
NFA180_3_3303123 -->|"m"|NFA180_5_29728115
NFA180_5_29728115 -->|"a"|NFA180_7_66226448
NFA180_7_66226448 -->|"g"|NFA180_9_59167123
NFA180_9_59167123 -->|"e"|NFA180_11_62742061
NFA180_11_62742061 -->|"1"|NFA180_13_27807639
NFA180_13_27807639 -->|"D"|NFA180_15_48942162
NFA180_15_48942162 -->|"A"|NFA180_17_37826280
NFA180_17_37826280 -->|"r"|NFA180_19_4892200
NFA180_19_4892200 -->|"r"|NFA180_21_44029805
NFA180_21_44029805 -->|"a"|NFA180_23_60723926
NFA180_23_60723926 -->|"y"|NFA180_25_9644430
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
subgraph DFA0_-527706995["DFA0 regex start"]
NFA180_26_34837968_0("NFA180-26 regex start")
end
subgraph DFA1_737171255["DFA1 {1}"]
NFA180_1_45106256_1("NFA180-1 char[1]")
end
subgraph DFA2_1217216616["DFA2 {1}"]
NFA180_3_3303123_2("NFA180-3 char[1]")
end
subgraph DFA3_-1309264394["DFA3 {1}"]
NFA180_5_29728115_3("NFA180-5 char[1]")
end
subgraph DFA4_-646133477["DFA4 {1}"]
NFA180_7_66226448_4("NFA180-7 char[1]")
end
subgraph DFA5_-349536183["DFA5 {1}"]
NFA180_9_59167123_5("NFA180-9 char[1]")
end
subgraph DFA6_-238871130["DFA6 {1}"]
NFA180_11_62742061_6("NFA180-11 char[1]")
end
subgraph DFA7_-1862032557["DFA7 {1}"]
NFA180_13_27807639_7("NFA180-13 char[1]")
end
subgraph DFA8_-1889196593["DFA8 {1}"]
NFA180_15_48942162_8("NFA180-15 char[1]")
end
subgraph DFA9_546464281["DFA9 {1}"]
NFA180_17_37826280_9("NFA180-17 char[1]")
end
subgraph DFA10_-1070943483["DFA10 {1}"]
NFA180_19_4892200_10("NFA180-19 char[1]")
end
subgraph DFA11_559212408["DFA11 {1}"]
NFA180_21_44029805_11("NFA180-21 char[1]")
end
subgraph DFA12_-1192257895["DFA12 {1}"]
NFA180_23_60723926_12("NFA180-23 char[1]")
end
subgraph DFA13_1131501845["DFA13 {1}"]
NFA180_25_9644430_13[\"NFA180-25 char[1]"/]
end
DFA0_-527706995 -->|"u"|DFA1_737171255
DFA1_737171255 -->|"i"|DFA2_1217216616
DFA2_1217216616 -->|"m"|DFA3_-1309264394
DFA3_-1309264394 -->|"a"|DFA4_-646133477
DFA4_-646133477 -->|"g"|DFA5_-349536183
DFA5_-349536183 -->|"e"|DFA6_-238871130
DFA6_-238871130 -->|"1"|DFA7_-1862032557
DFA7_-1862032557 -->|"D"|DFA8_-1889196593
DFA8_-1889196593 -->|"A"|DFA9_546464281
DFA9_546464281 -->|"r"|DFA10_-1070943483
DFA10_-1070943483 -->|"r"|DFA11_559212408
DFA11_559212408 -->|"a"|DFA12_-1192257895
DFA12_-1192257895 -->|"y"|DFA13_1131501845
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
DFA0_-527706995{{"DFA0 regex start"}}
DFA1_737171255{{"DFA1 {1}"}}
DFA2_1217216616{{"DFA2 {1}"}}
DFA3_-1309264394{{"DFA3 {1}"}}
DFA4_-646133477{{"DFA4 {1}"}}
DFA5_-349536183{{"DFA5 {1}"}}
DFA6_-238871130{{"DFA6 {1}"}}
DFA7_-1862032557{{"DFA7 {1}"}}
DFA8_-1889196593{{"DFA8 {1}"}}
DFA9_546464281{{"DFA9 {1}"}}
DFA10_-1070943483{{"DFA10 {1}"}}
DFA11_559212408{{"DFA11 {1}"}}
DFA12_-1192257895{{"DFA12 {1}"}}
DFA13_1131501845[\"DFA13 {1}"/]
DFA0_-527706995 -->|"u"|DFA1_737171255
DFA1_737171255 -->|"i"|DFA2_1217216616
DFA2_1217216616 -->|"m"|DFA3_-1309264394
DFA3_-1309264394 -->|"a"|DFA4_-646133477
DFA4_-646133477 -->|"g"|DFA5_-349536183
DFA5_-349536183 -->|"e"|DFA6_-238871130
DFA6_-238871130 -->|"1"|DFA7_-1862032557
DFA7_-1862032557 -->|"D"|DFA8_-1889196593
DFA8_-1889196593 -->|"A"|DFA9_546464281
DFA9_546464281 -->|"r"|DFA10_-1070943483
DFA10_-1070943483 -->|"r"|DFA11_559212408
DFA11_559212408 -->|"a"|DFA12_-1192257895
DFA12_-1192257895 -->|"y"|DFA13_1131501845
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
subgraph MiniDFA0_-244064720["MiniDFA0 {1}"]
DFA0_-527706995_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1398810197["MiniDFA1 {1}"]
DFA1_737171255_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1559543120["MiniDFA2 {1}"]
DFA2_1217216616_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_739919655["MiniDFA3 {1}"]
DFA3_-1309264394_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1707241028["MiniDFA5 {1}"]
DFA4_-646133477_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1567277725["MiniDFA6 {1}"]
DFA5_-349536183_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-296522326["MiniDFA7 {1}"]
DFA6_-238871130_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1931381143["MiniDFA8 {1}"]
DFA7_-1862032557_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-565109174["MiniDFA9 {1}"]
DFA8_-1889196593_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_1463818943["MiniDFA10 {1}"]
DFA9_546464281_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-628727171["MiniDFA11 {1}"]
DFA10_-1070943483_10{{"DFA10 {1}"}}
end
subgraph MiniDFA4_1696540364["MiniDFA4 {1}"]
DFA11_559212408_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1076436602["MiniDFA12 {1}"]
DFA12_-1192257895_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-2050244713["MiniDFA13 {1}"]
DFA13_1131501845_13[\"DFA13 {1}"/]
end
MiniDFA0_-244064720 -->|"u"|MiniDFA1_-1398810197
MiniDFA1_-1398810197 -->|"i"|MiniDFA2_-1559543120
MiniDFA2_-1559543120 -->|"m"|MiniDFA3_739919655
MiniDFA3_739919655 -->|"a"|MiniDFA5_-1707241028
MiniDFA5_-1707241028 -->|"g"|MiniDFA6_1567277725
MiniDFA6_1567277725 -->|"e"|MiniDFA7_-296522326
MiniDFA7_-296522326 -->|"1"|MiniDFA8_-1931381143
MiniDFA8_-1931381143 -->|"D"|MiniDFA9_-565109174
MiniDFA9_-565109174 -->|"A"|MiniDFA10_1463818943
MiniDFA10_1463818943 -->|"r"|MiniDFA11_-628727171
MiniDFA11_-628727171 -->|"r"|MiniDFA4_1696540364
MiniDFA4_1696540364 -->|"a"|MiniDFA12_1076436602
MiniDFA12_1076436602 -->|"y"|MiniDFA13_-2050244713
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
MiniDFA0_-244064720(["MiniDFA0 {1}"])
MiniDFA1_-1398810197(["MiniDFA1 {1}"])
MiniDFA2_-1559543120(["MiniDFA2 {1}"])
MiniDFA3_739919655(["MiniDFA3 {1}"])
MiniDFA5_-1707241028(["MiniDFA5 {1}"])
MiniDFA6_1567277725(["MiniDFA6 {1}"])
MiniDFA7_-296522326(["MiniDFA7 {1}"])
MiniDFA8_-1931381143(["MiniDFA8 {1}"])
MiniDFA9_-565109174(["MiniDFA9 {1}"])
MiniDFA10_1463818943(["MiniDFA10 {1}"])
MiniDFA11_-628727171(["MiniDFA11 {1}"])
MiniDFA4_1696540364(["MiniDFA4 {1}"])
MiniDFA12_1076436602(["MiniDFA12 {1}"])
MiniDFA13_-2050244713[\"MiniDFA13 {1}"/]
MiniDFA0_-244064720 -->|"u"|MiniDFA1_-1398810197
MiniDFA1_-1398810197 -->|"i"|MiniDFA2_-1559543120
MiniDFA2_-1559543120 -->|"m"|MiniDFA3_739919655
MiniDFA3_739919655 -->|"a"|MiniDFA5_-1707241028
MiniDFA5_-1707241028 -->|"g"|MiniDFA6_1567277725
MiniDFA6_1567277725 -->|"e"|MiniDFA7_-296522326
MiniDFA7_-296522326 -->|"1"|MiniDFA8_-1931381143
MiniDFA8_-1931381143 -->|"D"|MiniDFA9_-565109174
MiniDFA9_-565109174 -->|"A"|MiniDFA10_1463818943
MiniDFA10_1463818943 -->|"r"|MiniDFA11_-628727171
MiniDFA11_-628727171 -->|"r"|MiniDFA4_1696540364
MiniDFA4_1696540364 -->|"a"|MiniDFA12_1076436602
MiniDFA12_1076436602 -->|"y"|MiniDFA13_-2050244713
```
-------------------------------
