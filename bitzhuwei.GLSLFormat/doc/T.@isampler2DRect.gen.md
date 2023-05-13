# 'isampler2DRect'

pattern: `isampler2DRect`

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
eNFA149_28_15901331[["εNFA149-28 regex start"]]
eNFA149_0_8894251[["εNFA149-0 char{1, 1}"]]
eNFA149_1_12939396[["εNFA149-1 char[1]"]]
eNFA149_2_49345703[["εNFA149-2 char{1, 1}"]]
eNFA149_3_41458150[["εNFA149-3 char[1]"]]
eNFA149_4_37579032[["εNFA149-4 char{1, 1}"]]
eNFA149_5_2666976[["εNFA149-5 char[1]"]]
eNFA149_6_24002790[["εNFA149-6 char{1, 1}"]]
eNFA149_7_14698523[["εNFA149-7 char[1]"]]
eNFA149_8_65177848[["εNFA149-8 char{1, 1}"]]
eNFA149_9_49729727[["εNFA149-9 char[1]"]]
eNFA149_10_44914359[["εNFA149-10 char{1, 1}"]]
eNFA149_11_1576050[["εNFA149-11 char[1]"]]
eNFA149_12_14184458[["εNFA149-12 char{1, 1}"]]
eNFA149_13_60551263[["εNFA149-13 char[1]"]]
eNFA149_14_8090458[["εNFA149-14 char{1, 1}"]]
eNFA149_15_5705260[["εNFA149-15 char[1]"]]
eNFA149_16_51347342[["εNFA149-16 char{1, 1}"]]
eNFA149_17_59472897[["εNFA149-17 char[1]"]]
eNFA149_18_65494031[["εNFA149-18 char{1, 1}"]]
eNFA149_19_52575367[["εNFA149-19 char[1]"]]
eNFA149_20_3416260[["εNFA149-20 char{1, 1}"]]
eNFA149_21_30746341[["εNFA149-21 char[1]"]]
eNFA149_22_8281621[["εNFA149-22 char{1, 1}"]]
eNFA149_23_7425732[["εNFA149-23 char[1]"]]
eNFA149_24_66831596[["εNFA149-24 char{1, 1}"]]
eNFA149_25_64613452[["εNFA149-25 char[1]"]]
eNFA149_26_44650158[["εNFA149-26 char{1, 1}"]]
eNFA149_27_66307108[["εNFA149-27 char[1]"]]
eNFA149_29_59893061[["εNFA149-29 regex end"]]
eNFA149_30_2166644[["εNFA149-30 post-regex start"]]
eNFA149_31_19499801[\"εNFA149-31 post-regex end"/]
eNFA149_28_15901331 -.->|"ε"|eNFA149_0_8894251
eNFA149_0_8894251 -->|"i"|eNFA149_1_12939396
eNFA149_1_12939396 -.->|"ε"|eNFA149_2_49345703
eNFA149_2_49345703 -->|"s"|eNFA149_3_41458150
eNFA149_3_41458150 -.->|"ε"|eNFA149_4_37579032
eNFA149_4_37579032 -->|"a"|eNFA149_5_2666976
eNFA149_5_2666976 -.->|"ε"|eNFA149_6_24002790
eNFA149_6_24002790 -->|"m"|eNFA149_7_14698523
eNFA149_7_14698523 -.->|"ε"|eNFA149_8_65177848
eNFA149_8_65177848 -->|"p"|eNFA149_9_49729727
eNFA149_9_49729727 -.->|"ε"|eNFA149_10_44914359
eNFA149_10_44914359 -->|"l"|eNFA149_11_1576050
eNFA149_11_1576050 -.->|"ε"|eNFA149_12_14184458
eNFA149_12_14184458 -->|"e"|eNFA149_13_60551263
eNFA149_13_60551263 -.->|"ε"|eNFA149_14_8090458
eNFA149_14_8090458 -->|"r"|eNFA149_15_5705260
eNFA149_15_5705260 -.->|"ε"|eNFA149_16_51347342
eNFA149_16_51347342 -->|"2"|eNFA149_17_59472897
eNFA149_17_59472897 -.->|"ε"|eNFA149_18_65494031
eNFA149_18_65494031 -->|"D"|eNFA149_19_52575367
eNFA149_19_52575367 -.->|"ε"|eNFA149_20_3416260
eNFA149_20_3416260 -->|"R"|eNFA149_21_30746341
eNFA149_21_30746341 -.->|"ε"|eNFA149_22_8281621
eNFA149_22_8281621 -->|"e"|eNFA149_23_7425732
eNFA149_23_7425732 -.->|"ε"|eNFA149_24_66831596
eNFA149_24_66831596 -->|"c"|eNFA149_25_64613452
eNFA149_25_64613452 -.->|"ε"|eNFA149_26_44650158
eNFA149_26_44650158 -->|"t"|eNFA149_27_66307108
eNFA149_27_66307108 -.->|"ε"|eNFA149_29_59893061
eNFA149_29_59893061 -.->|"ε"|eNFA149_30_2166644
eNFA149_30_2166644 -.->|"ε"|eNFA149_31_19499801
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
eNFA149_28_41280485[["εNFA149-28 regex start"]]
eNFA149_0_35980049[["εNFA149-0 char{1, 1}"]]
eNFA149_1_55384990[["εNFA149-1 char[1]"]]
eNFA149_2_28702870[["εNFA149-2 char{1, 1}"]]
eNFA149_3_56999240[["εNFA149-3 char[1]"]]
eNFA149_4_43231119[["εNFA149-4 char{1, 1}"]]
eNFA149_5_53535755[["εNFA149-5 char[1]"]]
eNFA149_6_12059749[["εNFA149-6 char{1, 1}"]]
eNFA149_7_41428878[["εNFA149-7 char[1]"]]
eNFA149_8_37315583[["εNFA149-8 char{1, 1}"]]
eNFA149_9_295929[["εNFA149-9 char[1]"]]
eNFA149_10_2663365[["εNFA149-10 char{1, 1}"]]
eNFA149_11_23970293[["εNFA149-11 char[1]"]]
eNFA149_12_14406049[["εNFA149-12 char{1, 1}"]]
eNFA149_13_62545577[["εNFA149-13 char[1]"]]
eNFA149_14_26039288[["εNFA149-14 char{1, 1}"]]
eNFA149_15_33027006[["εNFA149-15 char[1]"]]
eNFA149_16_28807604[["εNFA149-16 char{1, 1}"]]
eNFA149_17_57941852[["εNFA149-17 char[1]"]]
eNFA149_18_51714621[["εNFA149-18 char{1, 1}"]]
eNFA149_19_62778410[["εNFA149-19 char[1]"]]
eNFA149_20_28134778[["εNFA149-20 char{1, 1}"]]
eNFA149_21_51886416[["εNFA149-21 char[1]"]]
eNFA149_22_64324564[["εNFA149-22 char{1, 1}"]]
eNFA149_23_42050167[["εNFA149-23 char[1]"]]
eNFA149_24_42907186[["εNFA149-24 char{1, 1}"]]
eNFA149_25_50620358[["εNFA149-25 char[1]"]]
eNFA149_26_52930045[["εNFA149-26 char{1, 1}"]]
eNFA149_27_6608358[\"εNFA149-27 char[1]"/]
eNFA149_29_59475228[\"εNFA149-29 regex end"/]
eNFA149_30_65515007[\"εNFA149-30 post-regex start"/]
eNFA149_31_52764152[\"εNFA149-31 post-regex end"/]
eNFA149_28_41280485 -.->|"ε"|eNFA149_0_35980049
eNFA149_28_41280485 -->|"i"|eNFA149_1_55384990
eNFA149_0_35980049 -->|"i"|eNFA149_1_55384990
eNFA149_1_55384990 -.->|"ε"|eNFA149_2_28702870
eNFA149_1_55384990 -->|"s"|eNFA149_3_56999240
eNFA149_2_28702870 -->|"s"|eNFA149_3_56999240
eNFA149_3_56999240 -.->|"ε"|eNFA149_4_43231119
eNFA149_3_56999240 -->|"a"|eNFA149_5_53535755
eNFA149_4_43231119 -->|"a"|eNFA149_5_53535755
eNFA149_5_53535755 -.->|"ε"|eNFA149_6_12059749
eNFA149_5_53535755 -->|"m"|eNFA149_7_41428878
eNFA149_6_12059749 -->|"m"|eNFA149_7_41428878
eNFA149_7_41428878 -.->|"ε"|eNFA149_8_37315583
eNFA149_7_41428878 -->|"p"|eNFA149_9_295929
eNFA149_8_37315583 -->|"p"|eNFA149_9_295929
eNFA149_9_295929 -.->|"ε"|eNFA149_10_2663365
eNFA149_9_295929 -->|"l"|eNFA149_11_23970293
eNFA149_10_2663365 -->|"l"|eNFA149_11_23970293
eNFA149_11_23970293 -.->|"ε"|eNFA149_12_14406049
eNFA149_11_23970293 -->|"e"|eNFA149_13_62545577
eNFA149_12_14406049 -->|"e"|eNFA149_13_62545577
eNFA149_13_62545577 -.->|"ε"|eNFA149_14_26039288
eNFA149_13_62545577 -->|"r"|eNFA149_15_33027006
eNFA149_14_26039288 -->|"r"|eNFA149_15_33027006
eNFA149_15_33027006 -.->|"ε"|eNFA149_16_28807604
eNFA149_15_33027006 -->|"2"|eNFA149_17_57941852
eNFA149_16_28807604 -->|"2"|eNFA149_17_57941852
eNFA149_17_57941852 -.->|"ε"|eNFA149_18_51714621
eNFA149_17_57941852 -->|"D"|eNFA149_19_62778410
eNFA149_18_51714621 -->|"D"|eNFA149_19_62778410
eNFA149_19_62778410 -.->|"ε"|eNFA149_20_28134778
eNFA149_19_62778410 -->|"R"|eNFA149_21_51886416
eNFA149_20_28134778 -->|"R"|eNFA149_21_51886416
eNFA149_21_51886416 -.->|"ε"|eNFA149_22_64324564
eNFA149_21_51886416 -->|"e"|eNFA149_23_42050167
eNFA149_22_64324564 -->|"e"|eNFA149_23_42050167
eNFA149_23_42050167 -.->|"ε"|eNFA149_24_42907186
eNFA149_23_42050167 -->|"c"|eNFA149_25_50620358
eNFA149_24_42907186 -->|"c"|eNFA149_25_50620358
eNFA149_25_50620358 -.->|"ε"|eNFA149_26_52930045
eNFA149_25_50620358 -->|"t"|eNFA149_27_6608358
eNFA149_26_52930045 -->|"t"|eNFA149_27_6608358
eNFA149_27_6608358 -.->|"ε"|eNFA149_29_59475228
eNFA149_27_6608358 -.->|"ε"|eNFA149_30_65515007
eNFA149_27_6608358 -.->|"ε"|eNFA149_31_52764152
eNFA149_29_59475228 -.->|"ε"|eNFA149_30_65515007
eNFA149_29_59475228 -.->|"ε"|eNFA149_31_52764152
eNFA149_30_65515007 -.->|"ε"|eNFA149_31_52764152
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
NFA149_28_5115320("NFA149-28 regex start")
NFA149_1_46037880("NFA149-1 char[1]")
NFA149_3_11687737("NFA149-3 char[1]")
NFA149_5_38080772("NFA149-5 char[1]")
NFA149_7_7182635("NFA149-7 char[1]")
NFA149_9_64643717("NFA149-9 char[1]")
NFA149_11_44922549("NFA149-11 char[1]")
NFA149_13_1649763("NFA149-13 char[1]")
NFA149_15_14847872("NFA149-15 char[1]")
NFA149_17_66521989("NFA149-17 char[1]")
NFA149_19_61826996("NFA149-19 char[1]")
NFA149_21_19572052("NFA149-21 char[1]")
NFA149_23_41930743("NFA149-23 char[1]")
NFA149_25_41832375("NFA149-25 char[1]")
NFA149_27_40947060[\"NFA149-27 char[1]"/]
NFA149_28_5115320 -->|"i"|NFA149_1_46037880
NFA149_1_46037880 -->|"s"|NFA149_3_11687737
NFA149_3_11687737 -->|"a"|NFA149_5_38080772
NFA149_5_38080772 -->|"m"|NFA149_7_7182635
NFA149_7_7182635 -->|"p"|NFA149_9_64643717
NFA149_9_64643717 -->|"l"|NFA149_11_44922549
NFA149_11_44922549 -->|"e"|NFA149_13_1649763
NFA149_13_1649763 -->|"r"|NFA149_15_14847872
NFA149_15_14847872 -->|"2"|NFA149_17_66521989
NFA149_17_66521989 -->|"D"|NFA149_19_61826996
NFA149_19_61826996 -->|"R"|NFA149_21_19572052
NFA149_21_19572052 -->|"e"|NFA149_23_41930743
NFA149_23_41930743 -->|"c"|NFA149_25_41832375
NFA149_25_41832375 -->|"t"|NFA149_27_40947060
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
subgraph DFA0_-344177778["DFA0 regex start"]
NFA149_28_5115320_0("NFA149-28 regex start")
end
subgraph DFA1_1468881626["DFA1 {1}"]
NFA149_1_46037880_1("NFA149-1 char[1]")
end
subgraph DFA2_1631691627["DFA2 {1}"]
NFA149_3_11687737_2("NFA149-3 char[1]")
end
subgraph DFA3_-1787041020["DFA3 {1}"]
NFA149_5_38080772_3("NFA149-5 char[1]")
end
subgraph DFA4_632928580["DFA4 {1}"]
NFA149_7_7182635_4("NFA149-7 char[1]")
end
subgraph DFA5_524366687["DFA5 {1}"]
NFA149_9_64643717_5("NFA149-9 char[1]")
end
subgraph DFA6_-86841112["DFA6 {1}"]
NFA149_11_44922549_6("NFA149-11 char[1]")
end
subgraph DFA7_1894659552["DFA7 {1}"]
NFA149_13_1649763_7("NFA149-13 char[1]")
end
subgraph DFA8_1737560120["DFA8 {1}"]
NFA149_15_14847872_8("NFA149-15 char[1]")
end
subgraph DFA9_552937214["DFA9 {1}"]
NFA149_17_66521989_9("NFA149-17 char[1]")
end
subgraph DFA10_686225502["DFA10 {1}"]
NFA149_19_61826996_10("NFA149-19 char[1]")
end
subgraph DFA11_1098754489["DFA11 {1}"]
NFA149_21_19572052_11("NFA149-21 char[1]")
end
subgraph DFA12_1824153739["DFA12 {1}"]
NFA149_23_41930743_12("NFA149-23 char[1]")
end
subgraph DFA13_646606095["DFA13 {1}"]
NFA149_25_41832375_13("NFA149-25 char[1]")
end
subgraph DFA14_-921961769["DFA14 {1}"]
NFA149_27_40947060_14[\"NFA149-27 char[1]"/]
end
DFA0_-344177778 -->|"i"|DFA1_1468881626
DFA1_1468881626 -->|"s"|DFA2_1631691627
DFA2_1631691627 -->|"a"|DFA3_-1787041020
DFA3_-1787041020 -->|"m"|DFA4_632928580
DFA4_632928580 -->|"p"|DFA5_524366687
DFA5_524366687 -->|"l"|DFA6_-86841112
DFA6_-86841112 -->|"e"|DFA7_1894659552
DFA7_1894659552 -->|"r"|DFA8_1737560120
DFA8_1737560120 -->|"2"|DFA9_552937214
DFA9_552937214 -->|"D"|DFA10_686225502
DFA10_686225502 -->|"R"|DFA11_1098754489
DFA11_1098754489 -->|"e"|DFA12_1824153739
DFA12_1824153739 -->|"c"|DFA13_646606095
DFA13_646606095 -->|"t"|DFA14_-921961769
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
DFA0_-344177778{{"DFA0 regex start"}}
DFA1_1468881626{{"DFA1 {1}"}}
DFA2_1631691627{{"DFA2 {1}"}}
DFA3_-1787041020{{"DFA3 {1}"}}
DFA4_632928580{{"DFA4 {1}"}}
DFA5_524366687{{"DFA5 {1}"}}
DFA6_-86841112{{"DFA6 {1}"}}
DFA7_1894659552{{"DFA7 {1}"}}
DFA8_1737560120{{"DFA8 {1}"}}
DFA9_552937214{{"DFA9 {1}"}}
DFA10_686225502{{"DFA10 {1}"}}
DFA11_1098754489{{"DFA11 {1}"}}
DFA12_1824153739{{"DFA12 {1}"}}
DFA13_646606095{{"DFA13 {1}"}}
DFA14_-921961769[\"DFA14 {1}"/]
DFA0_-344177778 -->|"i"|DFA1_1468881626
DFA1_1468881626 -->|"s"|DFA2_1631691627
DFA2_1631691627 -->|"a"|DFA3_-1787041020
DFA3_-1787041020 -->|"m"|DFA4_632928580
DFA4_632928580 -->|"p"|DFA5_524366687
DFA5_524366687 -->|"l"|DFA6_-86841112
DFA6_-86841112 -->|"e"|DFA7_1894659552
DFA7_1894659552 -->|"r"|DFA8_1737560120
DFA8_1737560120 -->|"2"|DFA9_552937214
DFA9_552937214 -->|"D"|DFA10_686225502
DFA10_686225502 -->|"R"|DFA11_1098754489
DFA11_1098754489 -->|"e"|DFA12_1824153739
DFA12_1824153739 -->|"c"|DFA13_646606095
DFA13_646606095 -->|"t"|DFA14_-921961769
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
subgraph MiniDFA0_2061165162["MiniDFA0 {1}"]
DFA0_-344177778_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_132605626["MiniDFA1 {1}"]
DFA1_1468881626_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1490703500["MiniDFA2 {1}"]
DFA2_1631691627_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1971877950["MiniDFA3 {1}"]
DFA3_-1787041020_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-553458718["MiniDFA4 {1}"]
DFA4_632928580_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_584634149["MiniDFA5 {1}"]
DFA5_524366687_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1484723636["MiniDFA6 {1}"]
DFA6_-86841112_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1668806995["MiniDFA8 {1}"]
DFA7_1894659552_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_161122281["MiniDFA9 {1}"]
DFA8_1737560120_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_1424945586["MiniDFA10 {1}"]
DFA9_552937214_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_1773653967["MiniDFA11 {1}"]
DFA10_686225502_10{{"DFA10 {1}"}}
end
subgraph MiniDFA7_702881884["MiniDFA7 {1}"]
DFA11_1098754489_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1126866403["MiniDFA12 {1}"]
DFA12_1824153739_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_1923425659["MiniDFA13 {1}"]
DFA13_646606095_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-202762695["MiniDFA14 {1}"]
DFA14_-921961769_14[\"DFA14 {1}"/]
end
MiniDFA0_2061165162 -->|"i"|MiniDFA1_132605626
MiniDFA1_132605626 -->|"s"|MiniDFA2_-1490703500
MiniDFA2_-1490703500 -->|"a"|MiniDFA3_1971877950
MiniDFA3_1971877950 -->|"m"|MiniDFA4_-553458718
MiniDFA4_-553458718 -->|"p"|MiniDFA5_584634149
MiniDFA5_584634149 -->|"l"|MiniDFA6_1484723636
MiniDFA6_1484723636 -->|"e"|MiniDFA8_-1668806995
MiniDFA8_-1668806995 -->|"r"|MiniDFA9_161122281
MiniDFA9_161122281 -->|"2"|MiniDFA10_1424945586
MiniDFA10_1424945586 -->|"D"|MiniDFA11_1773653967
MiniDFA11_1773653967 -->|"R"|MiniDFA7_702881884
MiniDFA7_702881884 -->|"e"|MiniDFA12_1126866403
MiniDFA12_1126866403 -->|"c"|MiniDFA13_1923425659
MiniDFA13_1923425659 -->|"t"|MiniDFA14_-202762695
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
MiniDFA0_2061165162(["MiniDFA0 {1}"])
MiniDFA1_132605626(["MiniDFA1 {1}"])
MiniDFA2_-1490703500(["MiniDFA2 {1}"])
MiniDFA3_1971877950(["MiniDFA3 {1}"])
MiniDFA4_-553458718(["MiniDFA4 {1}"])
MiniDFA5_584634149(["MiniDFA5 {1}"])
MiniDFA6_1484723636(["MiniDFA6 {1}"])
MiniDFA8_-1668806995(["MiniDFA8 {1}"])
MiniDFA9_161122281(["MiniDFA9 {1}"])
MiniDFA10_1424945586(["MiniDFA10 {1}"])
MiniDFA11_1773653967(["MiniDFA11 {1}"])
MiniDFA7_702881884(["MiniDFA7 {1}"])
MiniDFA12_1126866403(["MiniDFA12 {1}"])
MiniDFA13_1923425659(["MiniDFA13 {1}"])
MiniDFA14_-202762695[\"MiniDFA14 {1}"/]
MiniDFA0_2061165162 -->|"i"|MiniDFA1_132605626
MiniDFA1_132605626 -->|"s"|MiniDFA2_-1490703500
MiniDFA2_-1490703500 -->|"a"|MiniDFA3_1971877950
MiniDFA3_1971877950 -->|"m"|MiniDFA4_-553458718
MiniDFA4_-553458718 -->|"p"|MiniDFA5_584634149
MiniDFA5_584634149 -->|"l"|MiniDFA6_1484723636
MiniDFA6_1484723636 -->|"e"|MiniDFA8_-1668806995
MiniDFA8_-1668806995 -->|"r"|MiniDFA9_161122281
MiniDFA9_161122281 -->|"2"|MiniDFA10_1424945586
MiniDFA10_1424945586 -->|"D"|MiniDFA11_1773653967
MiniDFA11_1773653967 -->|"R"|MiniDFA7_702881884
MiniDFA7_702881884 -->|"e"|MiniDFA12_1126866403
MiniDFA12_1126866403 -->|"c"|MiniDFA13_1923425659
MiniDFA13_1923425659 -->|"t"|MiniDFA14_-202762695
```
-------------------------------
