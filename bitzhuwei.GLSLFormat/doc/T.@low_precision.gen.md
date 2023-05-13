# 'low_precision'

pattern: `low_precision`

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
eNFA195_26_49646001[["εNFA195-26 regex start"]]
eNFA195_0_44160826[["εNFA195-0 char{1, 1}"]]
eNFA195_1_61903120[["εNFA195-1 char[1]"]]
eNFA195_2_20257171[["εNFA195-2 char{1, 1}"]]
eNFA195_3_48096812[["εNFA195-3 char[1]"]]
eNFA195_4_30218124[["εNFA195-4 char{1, 1}"]]
eNFA195_5_3527660[["εNFA195-5 char[1]"]]
eNFA195_6_31748941[["εNFA195-6 char{1, 1}"]]
eNFA195_7_17305016[["εNFA195-7 char[1]"]]
eNFA195_8_21527423[["εNFA195-8 char{1, 1}"]]
eNFA195_9_59529081[["εNFA195-9 char[1]"]]
eNFA195_10_65999689[["εNFA195-10 char{1, 1}"]]
eNFA195_11_57126295[["εNFA195-11 char[1]"]]
eNFA195_12_44374612[["εNFA195-12 char{1, 1}"]]
eNFA195_13_63827193[["εNFA195-13 char[1]"]]
eNFA195_14_37573832[["εNFA195-14 char{1, 1}"]]
eNFA195_15_2620168[["εNFA195-15 char[1]"]]
eNFA195_16_23581515[["εNFA195-16 char{1, 1}"]]
eNFA195_17_10907051[["εNFA195-17 char[1]"]]
eNFA195_18_31054600[["εNFA195-18 char{1, 1}"]]
eNFA195_19_11055947[["εNFA195-19 char[1]"]]
eNFA195_20_32394661[["εNFA195-20 char{1, 1}"]]
eNFA195_21_23116495[["εNFA195-21 char[1]"]]
eNFA195_22_6721866[["εNFA195-22 char{1, 1}"]]
eNFA195_23_60496800[["εNFA195-23 char[1]"]]
eNFA195_24_7600288[["εNFA195-24 char{1, 1}"]]
eNFA195_25_1293733[["εNFA195-25 char[1]"]]
eNFA195_27_11643598[["εNFA195-27 regex end"]]
eNFA195_28_37683526[["εNFA195-28 post-regex start"]]
eNFA195_29_3607421[\"εNFA195-29 post-regex end"/]
eNFA195_26_49646001 -.->|"ε"|eNFA195_0_44160826
eNFA195_0_44160826 -->|"l"|eNFA195_1_61903120
eNFA195_1_61903120 -.->|"ε"|eNFA195_2_20257171
eNFA195_2_20257171 -->|"o"|eNFA195_3_48096812
eNFA195_3_48096812 -.->|"ε"|eNFA195_4_30218124
eNFA195_4_30218124 -->|"w"|eNFA195_5_3527660
eNFA195_5_3527660 -.->|"ε"|eNFA195_6_31748941
eNFA195_6_31748941 -->|"_"|eNFA195_7_17305016
eNFA195_7_17305016 -.->|"ε"|eNFA195_8_21527423
eNFA195_8_21527423 -->|"p"|eNFA195_9_59529081
eNFA195_9_59529081 -.->|"ε"|eNFA195_10_65999689
eNFA195_10_65999689 -->|"r"|eNFA195_11_57126295
eNFA195_11_57126295 -.->|"ε"|eNFA195_12_44374612
eNFA195_12_44374612 -->|"e"|eNFA195_13_63827193
eNFA195_13_63827193 -.->|"ε"|eNFA195_14_37573832
eNFA195_14_37573832 -->|"c"|eNFA195_15_2620168
eNFA195_15_2620168 -.->|"ε"|eNFA195_16_23581515
eNFA195_16_23581515 -->|"i"|eNFA195_17_10907051
eNFA195_17_10907051 -.->|"ε"|eNFA195_18_31054600
eNFA195_18_31054600 -->|"s"|eNFA195_19_11055947
eNFA195_19_11055947 -.->|"ε"|eNFA195_20_32394661
eNFA195_20_32394661 -->|"i"|eNFA195_21_23116495
eNFA195_21_23116495 -.->|"ε"|eNFA195_22_6721866
eNFA195_22_6721866 -->|"o"|eNFA195_23_60496800
eNFA195_23_60496800 -.->|"ε"|eNFA195_24_7600288
eNFA195_24_7600288 -->|"n"|eNFA195_25_1293733
eNFA195_25_1293733 -.->|"ε"|eNFA195_27_11643598
eNFA195_27_11643598 -.->|"ε"|eNFA195_28_37683526
eNFA195_28_37683526 -.->|"ε"|eNFA195_29_3607421
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
eNFA195_26_32466797[["εNFA195-26 regex start"]]
eNFA195_0_23765717[["εNFA195-0 char{1, 1}"]]
eNFA195_1_12564863[["εNFA195-1 char[1]"]]
eNFA195_2_45974909[["εNFA195-2 char{1, 1}"]]
eNFA195_3_11120998[["εNFA195-3 char[1]"]]
eNFA195_4_32980125[["εNFA195-4 char{1, 1}"]]
eNFA195_5_28385674[["εNFA195-5 char[1]"]]
eNFA195_6_54144478[["εNFA195-6 char{1, 1}"]]
eNFA195_7_17538258[["εNFA195-7 char[1]"]]
eNFA195_8_23626599[["εNFA195-8 char{1, 1}"]]
eNFA195_9_11312807[["εNFA195-9 char[1]"]]
eNFA195_10_34706401[["εNFA195-10 char{1, 1}"]]
eNFA195_11_43922160[["εNFA195-11 char[1]"]]
eNFA195_12_59755124[["εNFA195-12 char{1, 1}"]]
eNFA195_13_925206[["εNFA195-13 char[1]"]]
eNFA195_14_8326855[["εNFA195-14 char{1, 1}"]]
eNFA195_15_7832832[["εNFA195-15 char[1]"]]
eNFA195_16_3386626[["εNFA195-16 char{1, 1}"]]
eNFA195_17_30479638[["εNFA195-17 char[1]"]]
eNFA195_18_5881294[["εNFA195-18 char{1, 1}"]]
eNFA195_19_52931650[["εNFA195-19 char[1]"]]
eNFA195_20_6622802[["εNFA195-20 char{1, 1}"]]
eNFA195_21_59605225[["εNFA195-21 char[1]"]]
eNFA195_22_66684983[["εNFA195-22 char{1, 1}"]]
eNFA195_23_63293941[["εNFA195-23 char[1]"]]
eNFA195_24_32774565[["εNFA195-24 char{1, 1}"]]
eNFA195_25_26535630[\"εNFA195-25 char[1]"/]
eNFA195_27_37494083[\"εNFA195-27 regex end"/]
eNFA195_28_1902427[\"εNFA195-28 post-regex start"/]
eNFA195_29_17121849[\"εNFA195-29 post-regex end"/]
eNFA195_26_32466797 -.->|"ε"|eNFA195_0_23765717
eNFA195_26_32466797 -->|"l"|eNFA195_1_12564863
eNFA195_0_23765717 -->|"l"|eNFA195_1_12564863
eNFA195_1_12564863 -.->|"ε"|eNFA195_2_45974909
eNFA195_1_12564863 -->|"o"|eNFA195_3_11120998
eNFA195_2_45974909 -->|"o"|eNFA195_3_11120998
eNFA195_3_11120998 -.->|"ε"|eNFA195_4_32980125
eNFA195_3_11120998 -->|"w"|eNFA195_5_28385674
eNFA195_4_32980125 -->|"w"|eNFA195_5_28385674
eNFA195_5_28385674 -.->|"ε"|eNFA195_6_54144478
eNFA195_5_28385674 -->|"_"|eNFA195_7_17538258
eNFA195_6_54144478 -->|"_"|eNFA195_7_17538258
eNFA195_7_17538258 -.->|"ε"|eNFA195_8_23626599
eNFA195_7_17538258 -->|"p"|eNFA195_9_11312807
eNFA195_8_23626599 -->|"p"|eNFA195_9_11312807
eNFA195_9_11312807 -.->|"ε"|eNFA195_10_34706401
eNFA195_9_11312807 -->|"r"|eNFA195_11_43922160
eNFA195_10_34706401 -->|"r"|eNFA195_11_43922160
eNFA195_11_43922160 -.->|"ε"|eNFA195_12_59755124
eNFA195_11_43922160 -->|"e"|eNFA195_13_925206
eNFA195_12_59755124 -->|"e"|eNFA195_13_925206
eNFA195_13_925206 -.->|"ε"|eNFA195_14_8326855
eNFA195_13_925206 -->|"c"|eNFA195_15_7832832
eNFA195_14_8326855 -->|"c"|eNFA195_15_7832832
eNFA195_15_7832832 -.->|"ε"|eNFA195_16_3386626
eNFA195_15_7832832 -->|"i"|eNFA195_17_30479638
eNFA195_16_3386626 -->|"i"|eNFA195_17_30479638
eNFA195_17_30479638 -.->|"ε"|eNFA195_18_5881294
eNFA195_17_30479638 -->|"s"|eNFA195_19_52931650
eNFA195_18_5881294 -->|"s"|eNFA195_19_52931650
eNFA195_19_52931650 -.->|"ε"|eNFA195_20_6622802
eNFA195_19_52931650 -->|"i"|eNFA195_21_59605225
eNFA195_20_6622802 -->|"i"|eNFA195_21_59605225
eNFA195_21_59605225 -.->|"ε"|eNFA195_22_66684983
eNFA195_21_59605225 -->|"o"|eNFA195_23_63293941
eNFA195_22_66684983 -->|"o"|eNFA195_23_63293941
eNFA195_23_63293941 -.->|"ε"|eNFA195_24_32774565
eNFA195_23_63293941 -->|"n"|eNFA195_25_26535630
eNFA195_24_32774565 -->|"n"|eNFA195_25_26535630
eNFA195_25_26535630 -.->|"ε"|eNFA195_27_37494083
eNFA195_25_26535630 -.->|"ε"|eNFA195_28_1902427
eNFA195_25_26535630 -.->|"ε"|eNFA195_29_17121849
eNFA195_27_37494083 -.->|"ε"|eNFA195_28_1902427
eNFA195_27_37494083 -.->|"ε"|eNFA195_29_17121849
eNFA195_28_1902427 -.->|"ε"|eNFA195_29_17121849
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
NFA195_26_19878917("NFA195-26 regex start")
NFA195_1_44692528("NFA195-1 char[1]")
NFA195_3_66688435("NFA195-3 char[1]")
NFA195_5_63325007("NFA195-5 char[1]")
NFA195_7_33054158("NFA195-7 char[1]")
NFA195_9_29051967("NFA195-9 char[1]")
NFA195_11_60141117("NFA195-11 char[1]")
NFA195_13_4399144("NFA195-13 char[1]")
NFA195_15_39592297("NFA195-15 char[1]")
NFA195_17_20786353("NFA195-17 char[1]")
NFA195_19_52859449("NFA195-19 char[1]")
NFA195_21_5972994("NFA195-21 char[1]")
NFA195_23_53756949("NFA195-23 char[1]")
NFA195_25_14050500[\"NFA195-25 char[1]"/]
NFA195_26_19878917 -->|"l"|NFA195_1_44692528
NFA195_1_44692528 -->|"o"|NFA195_3_66688435
NFA195_3_66688435 -->|"w"|NFA195_5_63325007
NFA195_5_63325007 -->|"_"|NFA195_7_33054158
NFA195_7_33054158 -->|"p"|NFA195_9_29051967
NFA195_9_29051967 -->|"r"|NFA195_11_60141117
NFA195_11_60141117 -->|"e"|NFA195_13_4399144
NFA195_13_4399144 -->|"c"|NFA195_15_39592297
NFA195_15_39592297 -->|"i"|NFA195_17_20786353
NFA195_17_20786353 -->|"s"|NFA195_19_52859449
NFA195_19_52859449 -->|"i"|NFA195_21_5972994
NFA195_21_5972994 -->|"o"|NFA195_23_53756949
NFA195_23_53756949 -->|"n"|NFA195_25_14050500
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
subgraph DFA0_-1378300091["DFA0 regex start"]
NFA195_26_19878917_0("NFA195-26 regex start")
end
subgraph DFA1_1839561257["DFA1 {1}"]
NFA195_1_44692528_1("NFA195-1 char[1]")
end
subgraph DFA2_1369530512["DFA2 {1}"]
NFA195_3_66688435_2("NFA195-3 char[1]")
end
subgraph DFA3_92493727["DFA3 {1}"]
NFA195_5_63325007_3("NFA195-5 char[1]")
end
subgraph DFA4_2076344198["DFA4 {1}"]
NFA195_7_33054158_4("NFA195-7 char[1]")
end
subgraph DFA5_-1352682625["DFA5 {1}"]
NFA195_9_29051967_5("NFA195-9 char[1]")
end
subgraph DFA6_1749679801["DFA6 {1}"]
NFA195_11_60141117_6("NFA195-11 char[1]")
end
subgraph DFA7_373738967["DFA7 {1}"]
NFA195_13_4399144_7("NFA195-13 char[1]")
end
subgraph DFA8_1303914933["DFA8 {1}"]
NFA195_15_39592297_8("NFA195-15 char[1]")
end
subgraph DFA9_-1347920719["DFA9 {1}"]
NFA195_17_20786353_9("NFA195-17 char[1]")
end
subgraph DFA10_1284065634["DFA10 {1}"]
NFA195_19_52859449_10("NFA195-19 char[1]")
end
subgraph DFA11_1029911503["DFA11 {1}"]
NFA195_21_5972994_11("NFA195-21 char[1]")
end
subgraph DFA12_-1445308524["DFA12 {1}"]
NFA195_23_53756949_12("NFA195-23 char[1]")
end
subgraph DFA13_-737658689["DFA13 {1}"]
NFA195_25_14050500_13[\"NFA195-25 char[1]"/]
end
DFA0_-1378300091 -->|"l"|DFA1_1839561257
DFA1_1839561257 -->|"o"|DFA2_1369530512
DFA2_1369530512 -->|"w"|DFA3_92493727
DFA3_92493727 -->|"_"|DFA4_2076344198
DFA4_2076344198 -->|"p"|DFA5_-1352682625
DFA5_-1352682625 -->|"r"|DFA6_1749679801
DFA6_1749679801 -->|"e"|DFA7_373738967
DFA7_373738967 -->|"c"|DFA8_1303914933
DFA8_1303914933 -->|"i"|DFA9_-1347920719
DFA9_-1347920719 -->|"s"|DFA10_1284065634
DFA10_1284065634 -->|"i"|DFA11_1029911503
DFA11_1029911503 -->|"o"|DFA12_-1445308524
DFA12_-1445308524 -->|"n"|DFA13_-737658689
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
DFA0_-1378300091{{"DFA0 regex start"}}
DFA1_1839561257{{"DFA1 {1}"}}
DFA2_1369530512{{"DFA2 {1}"}}
DFA3_92493727{{"DFA3 {1}"}}
DFA4_2076344198{{"DFA4 {1}"}}
DFA5_-1352682625{{"DFA5 {1}"}}
DFA6_1749679801{{"DFA6 {1}"}}
DFA7_373738967{{"DFA7 {1}"}}
DFA8_1303914933{{"DFA8 {1}"}}
DFA9_-1347920719{{"DFA9 {1}"}}
DFA10_1284065634{{"DFA10 {1}"}}
DFA11_1029911503{{"DFA11 {1}"}}
DFA12_-1445308524{{"DFA12 {1}"}}
DFA13_-737658689[\"DFA13 {1}"/]
DFA0_-1378300091 -->|"l"|DFA1_1839561257
DFA1_1839561257 -->|"o"|DFA2_1369530512
DFA2_1369530512 -->|"w"|DFA3_92493727
DFA3_92493727 -->|"_"|DFA4_2076344198
DFA4_2076344198 -->|"p"|DFA5_-1352682625
DFA5_-1352682625 -->|"r"|DFA6_1749679801
DFA6_1749679801 -->|"e"|DFA7_373738967
DFA7_373738967 -->|"c"|DFA8_1303914933
DFA8_1303914933 -->|"i"|DFA9_-1347920719
DFA9_-1347920719 -->|"s"|DFA10_1284065634
DFA10_1284065634 -->|"i"|DFA11_1029911503
DFA11_1029911503 -->|"o"|DFA12_-1445308524
DFA12_-1445308524 -->|"n"|DFA13_-737658689
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
subgraph MiniDFA0_168525054["MiniDFA0 {1}"]
DFA0_-1378300091_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-149200100["MiniDFA1 {1}"]
DFA1_1839561257_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-548071967["MiniDFA3 {1}"]
DFA2_1369530512_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-1714480630["MiniDFA4 {1}"]
DFA3_92493727_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_2146329027["MiniDFA5 {1}"]
DFA4_2076344198_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1754093278["MiniDFA6 {1}"]
DFA5_-1352682625_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1120739318["MiniDFA7 {1}"]
DFA6_1749679801_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1434208506["MiniDFA8 {1}"]
DFA7_373738967_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_761522049["MiniDFA9 {1}"]
DFA8_1303914933_8{{"DFA8 {1}"}}
end
subgraph MiniDFA11_-1064030903["MiniDFA11 {1}"]
DFA9_-1347920719_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_609558726["MiniDFA10 {1}"]
DFA10_1284065634_10{{"DFA10 {1}"}}
end
subgraph MiniDFA2_969869717["MiniDFA2 {1}"]
DFA11_1029911503_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1841698641["MiniDFA12 {1}"]
DFA12_-1445308524_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1786918537["MiniDFA13 {1}"]
DFA13_-737658689_13[\"DFA13 {1}"/]
end
MiniDFA0_168525054 -->|"l"|MiniDFA1_-149200100
MiniDFA1_-149200100 -->|"o"|MiniDFA3_-548071967
MiniDFA3_-548071967 -->|"w"|MiniDFA4_-1714480630
MiniDFA4_-1714480630 -->|"_"|MiniDFA5_2146329027
MiniDFA5_2146329027 -->|"p"|MiniDFA6_1754093278
MiniDFA6_1754093278 -->|"r"|MiniDFA7_1120739318
MiniDFA7_1120739318 -->|"e"|MiniDFA8_-1434208506
MiniDFA8_-1434208506 -->|"c"|MiniDFA9_761522049
MiniDFA9_761522049 -->|"i"|MiniDFA11_-1064030903
MiniDFA11_-1064030903 -->|"s"|MiniDFA10_609558726
MiniDFA10_609558726 -->|"i"|MiniDFA2_969869717
MiniDFA2_969869717 -->|"o"|MiniDFA12_-1841698641
MiniDFA12_-1841698641 -->|"n"|MiniDFA13_-1786918537
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
MiniDFA0_168525054(["MiniDFA0 {1}"])
MiniDFA1_-149200100(["MiniDFA1 {1}"])
MiniDFA3_-548071967(["MiniDFA3 {1}"])
MiniDFA4_-1714480630(["MiniDFA4 {1}"])
MiniDFA5_2146329027(["MiniDFA5 {1}"])
MiniDFA6_1754093278(["MiniDFA6 {1}"])
MiniDFA7_1120739318(["MiniDFA7 {1}"])
MiniDFA8_-1434208506(["MiniDFA8 {1}"])
MiniDFA9_761522049(["MiniDFA9 {1}"])
MiniDFA11_-1064030903(["MiniDFA11 {1}"])
MiniDFA10_609558726(["MiniDFA10 {1}"])
MiniDFA2_969869717(["MiniDFA2 {1}"])
MiniDFA12_-1841698641(["MiniDFA12 {1}"])
MiniDFA13_-1786918537[\"MiniDFA13 {1}"/]
MiniDFA0_168525054 -->|"l"|MiniDFA1_-149200100
MiniDFA1_-149200100 -->|"o"|MiniDFA3_-548071967
MiniDFA3_-548071967 -->|"w"|MiniDFA4_-1714480630
MiniDFA4_-1714480630 -->|"_"|MiniDFA5_2146329027
MiniDFA5_2146329027 -->|"p"|MiniDFA6_1754093278
MiniDFA6_1754093278 -->|"r"|MiniDFA7_1120739318
MiniDFA7_1120739318 -->|"e"|MiniDFA8_-1434208506
MiniDFA8_-1434208506 -->|"c"|MiniDFA9_761522049
MiniDFA9_761522049 -->|"i"|MiniDFA11_-1064030903
MiniDFA11_-1064030903 -->|"s"|MiniDFA10_609558726
MiniDFA10_609558726 -->|"i"|MiniDFA2_969869717
MiniDFA2_969869717 -->|"o"|MiniDFA12_-1841698641
MiniDFA12_-1841698641 -->|"n"|MiniDFA13_-1786918537
```
-------------------------------
