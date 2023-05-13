# 'isamplerCube'

pattern: `isamplerCube`

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
eNFA136_24_56669482[["εNFA136-24 regex start"]]
eNFA136_0_40263291[["εNFA136-0 char{1, 1}"]]
eNFA136_1_26825300[["εNFA136-1 char[1]"]]
eNFA136_2_40101110[["εNFA136-2 char{1, 1}"]]
eNFA136_3_25365674[["εNFA136-3 char[1]"]]
eNFA136_4_26964482[["εNFA136-4 char{1, 1}"]]
eNFA136_5_41353750[["εNFA136-5 char[1]"]]
eNFA136_6_36639430[["εNFA136-6 char{1, 1}"]]
eNFA136_7_61319421[["εNFA136-7 char[1]"]]
eNFA136_8_15003883[["εNFA136-8 char{1, 1}"]]
eNFA136_9_817225[["εNFA136-9 char[1]"]]
eNFA136_10_7355033[["εNFA136-10 char{1, 1}"]]
eNFA136_11_66195298[["εNFA136-11 char[1]"]]
eNFA136_12_58886775[["εNFA136-12 char{1, 1}"]]
eNFA136_13_60218927[["εNFA136-13 char[1]"]]
eNFA136_14_5099437[["εNFA136-14 char{1, 1}"]]
eNFA136_15_45894937[["εNFA136-15 char[1]"]]
eNFA136_16_10401252[["εNFA136-16 char{1, 1}"]]
eNFA136_17_26502407[["εNFA136-17 char[1]"]]
eNFA136_18_37195075[["εNFA136-18 char{1, 1}"]]
eNFA136_19_66320226[["εNFA136-19 char[1]"]]
eNFA136_20_60011123[["εNFA136-20 char{1, 1}"]]
eNFA136_21_3229201[["εNFA136-21 char[1]"]]
eNFA136_22_29062812[["εNFA136-22 char{1, 1}"]]
eNFA136_23_60238717[["εNFA136-23 char[1]"]]
eNFA136_25_5277541[["εNFA136-25 regex end"]]
eNFA136_26_47497869[["εNFA136-26 post-regex start"]]
eNFA136_27_24827638[\"εNFA136-27 post-regex end"/]
eNFA136_24_56669482 -.->|"ε"|eNFA136_0_40263291
eNFA136_0_40263291 -->|"i"|eNFA136_1_26825300
eNFA136_1_26825300 -.->|"ε"|eNFA136_2_40101110
eNFA136_2_40101110 -->|"s"|eNFA136_3_25365674
eNFA136_3_25365674 -.->|"ε"|eNFA136_4_26964482
eNFA136_4_26964482 -->|"a"|eNFA136_5_41353750
eNFA136_5_41353750 -.->|"ε"|eNFA136_6_36639430
eNFA136_6_36639430 -->|"m"|eNFA136_7_61319421
eNFA136_7_61319421 -.->|"ε"|eNFA136_8_15003883
eNFA136_8_15003883 -->|"p"|eNFA136_9_817225
eNFA136_9_817225 -.->|"ε"|eNFA136_10_7355033
eNFA136_10_7355033 -->|"l"|eNFA136_11_66195298
eNFA136_11_66195298 -.->|"ε"|eNFA136_12_58886775
eNFA136_12_58886775 -->|"e"|eNFA136_13_60218927
eNFA136_13_60218927 -.->|"ε"|eNFA136_14_5099437
eNFA136_14_5099437 -->|"r"|eNFA136_15_45894937
eNFA136_15_45894937 -.->|"ε"|eNFA136_16_10401252
eNFA136_16_10401252 -->|"C"|eNFA136_17_26502407
eNFA136_17_26502407 -.->|"ε"|eNFA136_18_37195075
eNFA136_18_37195075 -->|"u"|eNFA136_19_66320226
eNFA136_19_66320226 -.->|"ε"|eNFA136_20_60011123
eNFA136_20_60011123 -->|"b"|eNFA136_21_3229201
eNFA136_21_3229201 -.->|"ε"|eNFA136_22_29062812
eNFA136_22_29062812 -->|"e"|eNFA136_23_60238717
eNFA136_23_60238717 -.->|"ε"|eNFA136_25_5277541
eNFA136_25_5277541 -.->|"ε"|eNFA136_26_47497869
eNFA136_26_47497869 -.->|"ε"|eNFA136_27_24827638
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
eNFA136_24_22122153[["εNFA136-24 regex start"]]
eNFA136_0_64881656[["εNFA136-0 char{1, 1}"]]
eNFA136_1_47063994[["εNFA136-1 char[1]"]]
eNFA136_2_20922770[["εNFA136-2 char{1, 1}"]]
eNFA136_3_54087208[["εNFA136-3 char[1]"]]
eNFA136_4_17022829[["εNFA136-4 char{1, 1}"]]
eNFA136_5_18987738[["εNFA136-5 char[1]"]]
eNFA136_6_36671921[["εNFA136-6 char{1, 1}"]]
eNFA136_7_61611833[["εNFA136-7 char[1]"]]
eNFA136_8_17635588[["εNFA136-8 char{1, 1}"]]
eNFA136_9_24502572[["εNFA136-9 char[1]"]]
eNFA136_10_19196561[["εNFA136-10 char{1, 1}"]]
eNFA136_11_38551324[["εNFA136-11 char[1]"]]
eNFA136_12_11417598[["εNFA136-12 char{1, 1}"]]
eNFA136_13_35649520[["εNFA136-13 char[1]"]]
eNFA136_14_52410227[["εNFA136-14 char{1, 1}"]]
eNFA136_15_1930001[["εNFA136-15 char[1]"]]
eNFA136_16_17370009[["εNFA136-16 char{1, 1}"]]
eNFA136_17_22112358[["εNFA136-17 char[1]"]]
eNFA136_18_64793495[["εNFA136-18 char{1, 1}"]]
eNFA136_19_46270551[["εNFA136-19 char[1]"]]
eNFA136_20_13781782[["εNFA136-20 char{1, 1}"]]
eNFA136_21_56927182[["εNFA136-21 char[1]"]]
eNFA136_22_42582590[["εNFA136-22 char{1, 1}"]]
eNFA136_23_47698992[\"εNFA136-23 char[1]"/]
eNFA136_25_26637750[\"εNFA136-25 regex end"/]
eNFA136_26_38413159[\"εNFA136-26 post-regex start"/]
eNFA136_27_10174118[\"εNFA136-27 post-regex end"/]
eNFA136_24_22122153 -.->|"ε"|eNFA136_0_64881656
eNFA136_24_22122153 -->|"i"|eNFA136_1_47063994
eNFA136_0_64881656 -->|"i"|eNFA136_1_47063994
eNFA136_1_47063994 -.->|"ε"|eNFA136_2_20922770
eNFA136_1_47063994 -->|"s"|eNFA136_3_54087208
eNFA136_2_20922770 -->|"s"|eNFA136_3_54087208
eNFA136_3_54087208 -.->|"ε"|eNFA136_4_17022829
eNFA136_3_54087208 -->|"a"|eNFA136_5_18987738
eNFA136_4_17022829 -->|"a"|eNFA136_5_18987738
eNFA136_5_18987738 -.->|"ε"|eNFA136_6_36671921
eNFA136_5_18987738 -->|"m"|eNFA136_7_61611833
eNFA136_6_36671921 -->|"m"|eNFA136_7_61611833
eNFA136_7_61611833 -.->|"ε"|eNFA136_8_17635588
eNFA136_7_61611833 -->|"p"|eNFA136_9_24502572
eNFA136_8_17635588 -->|"p"|eNFA136_9_24502572
eNFA136_9_24502572 -.->|"ε"|eNFA136_10_19196561
eNFA136_9_24502572 -->|"l"|eNFA136_11_38551324
eNFA136_10_19196561 -->|"l"|eNFA136_11_38551324
eNFA136_11_38551324 -.->|"ε"|eNFA136_12_11417598
eNFA136_11_38551324 -->|"e"|eNFA136_13_35649520
eNFA136_12_11417598 -->|"e"|eNFA136_13_35649520
eNFA136_13_35649520 -.->|"ε"|eNFA136_14_52410227
eNFA136_13_35649520 -->|"r"|eNFA136_15_1930001
eNFA136_14_52410227 -->|"r"|eNFA136_15_1930001
eNFA136_15_1930001 -.->|"ε"|eNFA136_16_17370009
eNFA136_15_1930001 -->|"C"|eNFA136_17_22112358
eNFA136_16_17370009 -->|"C"|eNFA136_17_22112358
eNFA136_17_22112358 -.->|"ε"|eNFA136_18_64793495
eNFA136_17_22112358 -->|"u"|eNFA136_19_46270551
eNFA136_18_64793495 -->|"u"|eNFA136_19_46270551
eNFA136_19_46270551 -.->|"ε"|eNFA136_20_13781782
eNFA136_19_46270551 -->|"b"|eNFA136_21_56927182
eNFA136_20_13781782 -->|"b"|eNFA136_21_56927182
eNFA136_21_56927182 -.->|"ε"|eNFA136_22_42582590
eNFA136_21_56927182 -->|"e"|eNFA136_23_47698992
eNFA136_22_42582590 -->|"e"|eNFA136_23_47698992
eNFA136_23_47698992 -.->|"ε"|eNFA136_25_26637750
eNFA136_23_47698992 -.->|"ε"|eNFA136_26_38413159
eNFA136_23_47698992 -.->|"ε"|eNFA136_27_10174118
eNFA136_25_26637750 -.->|"ε"|eNFA136_26_38413159
eNFA136_25_26637750 -.->|"ε"|eNFA136_27_10174118
eNFA136_26_38413159 -.->|"ε"|eNFA136_27_10174118
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
NFA136_24_24458203("NFA136-24 regex start")
NFA136_1_18797239("NFA136-1 char[1]")
NFA136_3_34957427("NFA136-3 char[1]")
NFA136_5_46181392("NFA136-5 char[1]")
NFA136_7_12979352("NFA136-7 char[1]")
NFA136_9_49705306("NFA136-9 char[1]")
NFA136_11_44694577("NFA136-11 char[1]")
NFA136_13_66706877("NFA136-13 char[1]")
NFA136_15_63490983("NFA136-15 char[1]")
NFA136_17_34547936("NFA136-17 char[1]")
NFA136_19_42495969("NFA136-19 char[1]")
NFA136_21_46919403("NFA136-21 char[1]")
NFA136_23_19621447[\"NFA136-23 char[1]"/]
NFA136_24_24458203 -->|"i"|NFA136_1_18797239
NFA136_1_18797239 -->|"s"|NFA136_3_34957427
NFA136_3_34957427 -->|"a"|NFA136_5_46181392
NFA136_5_46181392 -->|"m"|NFA136_7_12979352
NFA136_7_12979352 -->|"p"|NFA136_9_49705306
NFA136_9_49705306 -->|"l"|NFA136_11_44694577
NFA136_11_44694577 -->|"e"|NFA136_13_66706877
NFA136_13_66706877 -->|"r"|NFA136_15_63490983
NFA136_15_63490983 -->|"C"|NFA136_17_34547936
NFA136_17_34547936 -->|"u"|NFA136_19_42495969
NFA136_19_42495969 -->|"b"|NFA136_21_46919403
NFA136_21_46919403 -->|"e"|NFA136_23_19621447
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
subgraph DFA0_-761190881["DFA0 regex start"]
NFA136_24_24458203_0("NFA136-24 regex start")
end
subgraph DFA1_1807766974["DFA1 {1}"]
NFA136_1_18797239_1("NFA136-1 char[1]")
end
subgraph DFA2_1250394585["DFA2 {1}"]
NFA136_3_34957427_2("NFA136-3 char[1]")
end
subgraph DFA3_1013467528["DFA3 {1}"]
NFA136_5_46181392_3("NFA136-5 char[1]")
end
subgraph DFA4_-1777214622["DFA4 {1}"]
NFA136_7_12979352_4("NFA136-7 char[1]")
end
subgraph DFA5_-1700907814["DFA5 {1}"]
NFA136_9_49705306_5("NFA136-9 char[1]")
end
subgraph DFA6_651141817["DFA6 {1}"]
NFA136_11_44694577_6("NFA136-11 char[1]")
end
subgraph DFA7_-261790925["DFA7 {1}"]
NFA136_13_66706877_7("NFA136-13 char[1]")
end
subgraph DFA8_1015339560["DFA8 {1}"]
NFA136_15_63490983_8("NFA136-15 char[1]")
end
subgraph DFA9_-23514860["DFA9 {1}"]
NFA136_17_34547936_9("NFA136-17 char[1]")
end
subgraph DFA10_-1479559764["DFA10 {1}"]
NFA136_19_42495969_10("NFA136-19 char[1]")
end
subgraph DFA11_2115008474["DFA11 {1}"]
NFA136_21_46919403_11("NFA136-21 char[1]")
end
subgraph DFA12_1279297686["DFA12 {1}"]
NFA136_23_19621447_12[\"NFA136-23 char[1]"/]
end
DFA0_-761190881 -->|"i"|DFA1_1807766974
DFA1_1807766974 -->|"s"|DFA2_1250394585
DFA2_1250394585 -->|"a"|DFA3_1013467528
DFA3_1013467528 -->|"m"|DFA4_-1777214622
DFA4_-1777214622 -->|"p"|DFA5_-1700907814
DFA5_-1700907814 -->|"l"|DFA6_651141817
DFA6_651141817 -->|"e"|DFA7_-261790925
DFA7_-261790925 -->|"r"|DFA8_1015339560
DFA8_1015339560 -->|"C"|DFA9_-23514860
DFA9_-23514860 -->|"u"|DFA10_-1479559764
DFA10_-1479559764 -->|"b"|DFA11_2115008474
DFA11_2115008474 -->|"e"|DFA12_1279297686
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
DFA0_-761190881{{"DFA0 regex start"}}
DFA1_1807766974{{"DFA1 {1}"}}
DFA2_1250394585{{"DFA2 {1}"}}
DFA3_1013467528{{"DFA3 {1}"}}
DFA4_-1777214622{{"DFA4 {1}"}}
DFA5_-1700907814{{"DFA5 {1}"}}
DFA6_651141817{{"DFA6 {1}"}}
DFA7_-261790925{{"DFA7 {1}"}}
DFA8_1015339560{{"DFA8 {1}"}}
DFA9_-23514860{{"DFA9 {1}"}}
DFA10_-1479559764{{"DFA10 {1}"}}
DFA11_2115008474{{"DFA11 {1}"}}
DFA12_1279297686[\"DFA12 {1}"/]
DFA0_-761190881 -->|"i"|DFA1_1807766974
DFA1_1807766974 -->|"s"|DFA2_1250394585
DFA2_1250394585 -->|"a"|DFA3_1013467528
DFA3_1013467528 -->|"m"|DFA4_-1777214622
DFA4_-1777214622 -->|"p"|DFA5_-1700907814
DFA5_-1700907814 -->|"l"|DFA6_651141817
DFA6_651141817 -->|"e"|DFA7_-261790925
DFA7_-261790925 -->|"r"|DFA8_1015339560
DFA8_1015339560 -->|"C"|DFA9_-23514860
DFA9_-23514860 -->|"u"|DFA10_-1479559764
DFA10_-1479559764 -->|"b"|DFA11_2115008474
DFA11_2115008474 -->|"e"|DFA12_1279297686
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
subgraph MiniDFA0_1571262490["MiniDFA0 {1}"]
DFA0_-761190881_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1811655769["MiniDFA1 {1}"]
DFA1_1807766974_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-724565152["MiniDFA2 {1}"]
DFA2_1250394585_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1076757660["MiniDFA3 {1}"]
DFA3_1013467528_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1974523182["MiniDFA4 {1}"]
DFA4_-1777214622_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1830930923["MiniDFA5 {1}"]
DFA5_-1700907814_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_843043425["MiniDFA6 {1}"]
DFA6_651141817_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_90028960["MiniDFA7 {1}"]
DFA7_-261790925_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_307058360["MiniDFA8 {1}"]
DFA8_1015339560_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_545587907["MiniDFA9 {1}"]
DFA9_-23514860_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-65147685["MiniDFA10 {1}"]
DFA10_-1479559764_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-475381493["MiniDFA11 {1}"]
DFA11_2115008474_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_474915534["MiniDFA12 {1}"]
DFA12_1279297686_12[\"DFA12 {1}"/]
end
MiniDFA0_1571262490 -->|"i"|MiniDFA1_-1811655769
MiniDFA1_-1811655769 -->|"s"|MiniDFA2_-724565152
MiniDFA2_-724565152 -->|"a"|MiniDFA3_-1076757660
MiniDFA3_-1076757660 -->|"m"|MiniDFA4_-1974523182
MiniDFA4_-1974523182 -->|"p"|MiniDFA5_-1830930923
MiniDFA5_-1830930923 -->|"l"|MiniDFA6_843043425
MiniDFA6_843043425 -->|"e"|MiniDFA7_90028960
MiniDFA7_90028960 -->|"r"|MiniDFA8_307058360
MiniDFA8_307058360 -->|"C"|MiniDFA9_545587907
MiniDFA9_545587907 -->|"u"|MiniDFA10_-65147685
MiniDFA10_-65147685 -->|"b"|MiniDFA11_-475381493
MiniDFA11_-475381493 -->|"e"|MiniDFA12_474915534
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
MiniDFA0_1571262490(["MiniDFA0 {1}"])
MiniDFA1_-1811655769(["MiniDFA1 {1}"])
MiniDFA2_-724565152(["MiniDFA2 {1}"])
MiniDFA3_-1076757660(["MiniDFA3 {1}"])
MiniDFA4_-1974523182(["MiniDFA4 {1}"])
MiniDFA5_-1830930923(["MiniDFA5 {1}"])
MiniDFA6_843043425(["MiniDFA6 {1}"])
MiniDFA7_90028960(["MiniDFA7 {1}"])
MiniDFA8_307058360(["MiniDFA8 {1}"])
MiniDFA9_545587907(["MiniDFA9 {1}"])
MiniDFA10_-65147685(["MiniDFA10 {1}"])
MiniDFA11_-475381493(["MiniDFA11 {1}"])
MiniDFA12_474915534[\"MiniDFA12 {1}"/]
MiniDFA0_1571262490 -->|"i"|MiniDFA1_-1811655769
MiniDFA1_-1811655769 -->|"s"|MiniDFA2_-724565152
MiniDFA2_-724565152 -->|"a"|MiniDFA3_-1076757660
MiniDFA3_-1076757660 -->|"m"|MiniDFA4_-1974523182
MiniDFA4_-1974523182 -->|"p"|MiniDFA5_-1830930923
MiniDFA5_-1830930923 -->|"l"|MiniDFA6_843043425
MiniDFA6_843043425 -->|"e"|MiniDFA7_90028960
MiniDFA7_90028960 -->|"r"|MiniDFA8_307058360
MiniDFA8_307058360 -->|"C"|MiniDFA9_545587907
MiniDFA9_545587907 -->|"u"|MiniDFA10_-65147685
MiniDFA10_-65147685 -->|"b"|MiniDFA11_-475381493
MiniDFA11_-475381493 -->|"e"|MiniDFA12_474915534
```
-------------------------------
