# 'sampler1DArray'

pattern: `sampler1DArray`

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
eNFA127_28_12996279[["εNFA127-28 regex start"]]
eNFA127_0_49857648[["εNFA127-0 char{1, 1}"]]
eNFA127_1_46065648[["εNFA127-1 char[1]"]]
eNFA127_2_11937648[["εNFA127-2 char{1, 1}"]]
eNFA127_3_40329969[["εNFA127-3 char[1]"]]
eNFA127_4_27425404[["εNFA127-4 char{1, 1}"]]
eNFA127_5_45502051[["εNFA127-5 char[1]"]]
eNFA127_6_6865277[["εNFA127-6 char{1, 1}"]]
eNFA127_7_61787501[["εNFA127-7 char[1]"]]
eNFA127_8_19216603[["εNFA127-8 char{1, 1}"]]
eNFA127_9_38731704[["εNFA127-9 char[1]"]]
eNFA127_10_13041021[["εNFA127-10 char{1, 1}"]]
eNFA127_11_50260332[["εNFA127-11 char[1]"]]
eNFA127_12_49689804[["εNFA127-12 char{1, 1}"]]
eNFA127_13_44555055[["εNFA127-13 char[1]"]]
eNFA127_14_65451183[["εNFA127-14 char{1, 1}"]]
eNFA127_15_52189740[["εNFA127-15 char[1]"]]
eNFA127_16_67054479[["εNFA127-16 char{1, 1}"]]
eNFA127_17_66619401[["εNFA127-17 char[1]"]]
eNFA127_18_62703699[["εNFA127-18 char{1, 1}"]]
eNFA127_19_27462382[["εNFA127-19 char[1]"]]
eNFA127_20_45834852[["εNFA127-20 char{1, 1}"]]
eNFA127_21_9860484[["εNFA127-21 char[1]"]]
eNFA127_22_21635497[["εNFA127-22 char{1, 1}"]]
eNFA127_23_60501746[["εNFA127-23 char[1]"]]
eNFA127_24_7644810[["εNFA127-24 char{1, 1}"]]
eNFA127_25_1694433[["εNFA127-25 char[1]"]]
eNFA127_26_15249905[["εNFA127-26 char{1, 1}"]]
eNFA127_27_3031417[["εNFA127-27 char[1]"]]
eNFA127_29_27282755[["εNFA127-29 regex end"]]
eNFA127_30_44218209[["εNFA127-30 post-regex start"]]
eNFA127_31_62419562[\"εNFA127-31 post-regex end"/]
eNFA127_28_12996279 -.->|"ε"|eNFA127_0_49857648
eNFA127_0_49857648 -->|"s"|eNFA127_1_46065648
eNFA127_1_46065648 -.->|"ε"|eNFA127_2_11937648
eNFA127_2_11937648 -->|"a"|eNFA127_3_40329969
eNFA127_3_40329969 -.->|"ε"|eNFA127_4_27425404
eNFA127_4_27425404 -->|"m"|eNFA127_5_45502051
eNFA127_5_45502051 -.->|"ε"|eNFA127_6_6865277
eNFA127_6_6865277 -->|"p"|eNFA127_7_61787501
eNFA127_7_61787501 -.->|"ε"|eNFA127_8_19216603
eNFA127_8_19216603 -->|"l"|eNFA127_9_38731704
eNFA127_9_38731704 -.->|"ε"|eNFA127_10_13041021
eNFA127_10_13041021 -->|"e"|eNFA127_11_50260332
eNFA127_11_50260332 -.->|"ε"|eNFA127_12_49689804
eNFA127_12_49689804 -->|"r"|eNFA127_13_44555055
eNFA127_13_44555055 -.->|"ε"|eNFA127_14_65451183
eNFA127_14_65451183 -->|"1"|eNFA127_15_52189740
eNFA127_15_52189740 -.->|"ε"|eNFA127_16_67054479
eNFA127_16_67054479 -->|"D"|eNFA127_17_66619401
eNFA127_17_66619401 -.->|"ε"|eNFA127_18_62703699
eNFA127_18_62703699 -->|"A"|eNFA127_19_27462382
eNFA127_19_27462382 -.->|"ε"|eNFA127_20_45834852
eNFA127_20_45834852 -->|"r"|eNFA127_21_9860484
eNFA127_21_9860484 -.->|"ε"|eNFA127_22_21635497
eNFA127_22_21635497 -->|"r"|eNFA127_23_60501746
eNFA127_23_60501746 -.->|"ε"|eNFA127_24_7644810
eNFA127_24_7644810 -->|"a"|eNFA127_25_1694433
eNFA127_25_1694433 -.->|"ε"|eNFA127_26_15249905
eNFA127_26_15249905 -->|"y"|eNFA127_27_3031417
eNFA127_27_3031417 -.->|"ε"|eNFA127_29_27282755
eNFA127_29_27282755 -.->|"ε"|eNFA127_30_44218209
eNFA127_30_44218209 -.->|"ε"|eNFA127_31_62419562
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
eNFA127_28_24905153[["εNFA127-28 regex start"]]
eNFA127_0_22819790[["εNFA127-0 char{1, 1}"]]
eNFA127_1_4051522[["εNFA127-1 char[1]"]]
eNFA127_2_36463702[["εNFA127-2 char{1, 1}"]]
eNFA127_3_59737867[["εNFA127-3 char[1]"]]
eNFA127_4_769899[["εNFA127-4 char{1, 1}"]]
eNFA127_5_6929093[["εNFA127-5 char[1]"]]
eNFA127_6_62361844[["εNFA127-6 char{1, 1}"]]
eNFA127_7_24385688[["εNFA127-7 char[1]"]]
eNFA127_8_18144602[["εNFA127-8 char{1, 1}"]]
eNFA127_9_29083691[["εNFA127-9 char[1]"]]
eNFA127_10_60426628[["εNFA127-10 char{1, 1}"]]
eNFA127_11_6968742[["εNFA127-11 char[1]"]]
eNFA127_12_62718682[["εNFA127-12 char{1, 1}"]]
eNFA127_13_27597234[["εNFA127-13 char[1]"]]
eNFA127_14_47048518[["εNFA127-14 char{1, 1}"]]
eNFA127_15_20783478[["εNFA127-15 char[1]"]]
eNFA127_16_52833581[["εNFA127-16 char{1, 1}"]]
eNFA127_17_5740187[["εNFA127-17 char[1]"]]
eNFA127_18_51661689[["εNFA127-18 char{1, 1}"]]
eNFA127_19_62302025[["εNFA127-19 char[1]"]]
eNFA127_20_23847314[["εNFA127-20 char{1, 1}"]]
eNFA127_21_13299239[["εNFA127-21 char[1]"]]
eNFA127_22_52584287[["εNFA127-22 char{1, 1}"]]
eNFA127_23_3496541[["εNFA127-23 char[1]"]]
eNFA127_24_31468873[["εNFA127-24 char{1, 1}"]]
eNFA127_25_14784404[["εNFA127-25 char[1]"]]
eNFA127_26_65950775[["εNFA127-26 char{1, 1}"]]
eNFA127_27_56686067[\"εNFA127-27 char[1]"/]
eNFA127_29_40412562[\"εNFA127-29 regex end"/]
eNFA127_30_28168739[\"εNFA127-30 post-regex start"/]
eNFA127_31_52192065[\"εNFA127-31 post-regex end"/]
eNFA127_28_24905153 -.->|"ε"|eNFA127_0_22819790
eNFA127_28_24905153 -->|"s"|eNFA127_1_4051522
eNFA127_0_22819790 -->|"s"|eNFA127_1_4051522
eNFA127_1_4051522 -.->|"ε"|eNFA127_2_36463702
eNFA127_1_4051522 -->|"a"|eNFA127_3_59737867
eNFA127_2_36463702 -->|"a"|eNFA127_3_59737867
eNFA127_3_59737867 -.->|"ε"|eNFA127_4_769899
eNFA127_3_59737867 -->|"m"|eNFA127_5_6929093
eNFA127_4_769899 -->|"m"|eNFA127_5_6929093
eNFA127_5_6929093 -.->|"ε"|eNFA127_6_62361844
eNFA127_5_6929093 -->|"p"|eNFA127_7_24385688
eNFA127_6_62361844 -->|"p"|eNFA127_7_24385688
eNFA127_7_24385688 -.->|"ε"|eNFA127_8_18144602
eNFA127_7_24385688 -->|"l"|eNFA127_9_29083691
eNFA127_8_18144602 -->|"l"|eNFA127_9_29083691
eNFA127_9_29083691 -.->|"ε"|eNFA127_10_60426628
eNFA127_9_29083691 -->|"e"|eNFA127_11_6968742
eNFA127_10_60426628 -->|"e"|eNFA127_11_6968742
eNFA127_11_6968742 -.->|"ε"|eNFA127_12_62718682
eNFA127_11_6968742 -->|"r"|eNFA127_13_27597234
eNFA127_12_62718682 -->|"r"|eNFA127_13_27597234
eNFA127_13_27597234 -.->|"ε"|eNFA127_14_47048518
eNFA127_13_27597234 -->|"1"|eNFA127_15_20783478
eNFA127_14_47048518 -->|"1"|eNFA127_15_20783478
eNFA127_15_20783478 -.->|"ε"|eNFA127_16_52833581
eNFA127_15_20783478 -->|"D"|eNFA127_17_5740187
eNFA127_16_52833581 -->|"D"|eNFA127_17_5740187
eNFA127_17_5740187 -.->|"ε"|eNFA127_18_51661689
eNFA127_17_5740187 -->|"A"|eNFA127_19_62302025
eNFA127_18_51661689 -->|"A"|eNFA127_19_62302025
eNFA127_19_62302025 -.->|"ε"|eNFA127_20_23847314
eNFA127_19_62302025 -->|"r"|eNFA127_21_13299239
eNFA127_20_23847314 -->|"r"|eNFA127_21_13299239
eNFA127_21_13299239 -.->|"ε"|eNFA127_22_52584287
eNFA127_21_13299239 -->|"r"|eNFA127_23_3496541
eNFA127_22_52584287 -->|"r"|eNFA127_23_3496541
eNFA127_23_3496541 -.->|"ε"|eNFA127_24_31468873
eNFA127_23_3496541 -->|"a"|eNFA127_25_14784404
eNFA127_24_31468873 -->|"a"|eNFA127_25_14784404
eNFA127_25_14784404 -.->|"ε"|eNFA127_26_65950775
eNFA127_25_14784404 -->|"y"|eNFA127_27_56686067
eNFA127_26_65950775 -->|"y"|eNFA127_27_56686067
eNFA127_27_56686067 -.->|"ε"|eNFA127_29_40412562
eNFA127_27_56686067 -.->|"ε"|eNFA127_30_28168739
eNFA127_27_56686067 -.->|"ε"|eNFA127_31_52192065
eNFA127_29_40412562 -.->|"ε"|eNFA127_30_28168739
eNFA127_29_40412562 -.->|"ε"|eNFA127_31_52192065
eNFA127_30_28168739 -.->|"ε"|eNFA127_31_52192065
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
NFA127_28_67075404("NFA127-28 regex start")
NFA127_1_66807725("NFA127-1 char[1]")
NFA127_3_64398613("NFA127-3 char[1]")
NFA127_5_42716605("NFA127-5 char[1]")
NFA127_7_48905126("NFA127-7 char[1]")
NFA127_9_37492953("NFA127-9 char[1]")
NFA127_11_1892264("NFA127-11 char[1]")
NFA127_13_17030378("NFA127-13 char[1]")
NFA127_15_19055682("NFA127-15 char[1]")
NFA127_17_37283416("NFA127-17 char[1]")
NFA127_19_6429("NFA127-19 char[1]")
NFA127_21_57866("NFA127-21 char[1]")
NFA127_23_520801("NFA127-23 char[1]")
NFA127_25_4687209("NFA127-25 char[1]")
NFA127_27_42184884[\"NFA127-27 char[1]"/]
NFA127_28_67075404 -->|"s"|NFA127_1_66807725
NFA127_1_66807725 -->|"a"|NFA127_3_64398613
NFA127_3_64398613 -->|"m"|NFA127_5_42716605
NFA127_5_42716605 -->|"p"|NFA127_7_48905126
NFA127_7_48905126 -->|"l"|NFA127_9_37492953
NFA127_9_37492953 -->|"e"|NFA127_11_1892264
NFA127_11_1892264 -->|"r"|NFA127_13_17030378
NFA127_13_17030378 -->|"1"|NFA127_15_19055682
NFA127_15_19055682 -->|"D"|NFA127_17_37283416
NFA127_17_37283416 -->|"A"|NFA127_19_6429
NFA127_19_6429 -->|"r"|NFA127_21_57866
NFA127_21_57866 -->|"r"|NFA127_23_520801
NFA127_23_520801 -->|"a"|NFA127_25_4687209
NFA127_25_4687209 -->|"y"|NFA127_27_42184884
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
subgraph DFA0_-1246240523["DFA0 regex start"]
NFA127_28_67075404_0("NFA127-28 regex start")
end
subgraph DFA1_320921683["DFA1 {1}"]
NFA127_1_66807725_1("NFA127-1 char[1]")
end
subgraph DFA2_-1449129117["DFA2 {1}"]
NFA127_3_64398613_2("NFA127-3 char[1]")
end
subgraph DFA3_207962475["DFA3 {1}"]
NFA127_5_42716605_3("NFA127-5 char[1]")
end
subgraph DFA4_1300011302["DFA4 {1}"]
NFA127_7_48905126_4("NFA127-7 char[1]")
end
subgraph DFA5_803381387["DFA5 {1}"]
NFA127_9_37492953_5("NFA127-9 char[1]")
end
subgraph DFA6_-1729571996["DFA6 {1}"]
NFA127_11_1892264_6("NFA127-11 char[1]")
end
subgraph DFA7_-1658935542["DFA7 {1}"]
NFA127_13_17030378_7("NFA127-13 char[1]")
end
subgraph DFA8_2097046106["DFA8 {1}"]
NFA127_15_19055682_8("NFA127-15 char[1]")
end
subgraph DFA9_1460560538["DFA9 {1}"]
NFA127_17_37283416_9("NFA127-17 char[1]")
end
subgraph DFA10_166869204["DFA10 {1}"]
NFA127_19_6429_10("NFA127-19 char[1]")
end
subgraph DFA11_211179063["DFA11 {1}"]
NFA127_21_57866_11("NFA127-21 char[1]")
end
subgraph DFA12_-1680718101["DFA12 {1}"]
NFA127_23_520801_12("NFA127-23 char[1]")
end
subgraph DFA13_-1341428158["DFA13 {1}"]
NFA127_25_4687209_13("NFA127-25 char[1]")
end
subgraph DFA14_-721769973["DFA14 {1}"]
NFA127_27_42184884_14[\"NFA127-27 char[1]"/]
end
DFA0_-1246240523 -->|"s"|DFA1_320921683
DFA1_320921683 -->|"a"|DFA2_-1449129117
DFA2_-1449129117 -->|"m"|DFA3_207962475
DFA3_207962475 -->|"p"|DFA4_1300011302
DFA4_1300011302 -->|"l"|DFA5_803381387
DFA5_803381387 -->|"e"|DFA6_-1729571996
DFA6_-1729571996 -->|"r"|DFA7_-1658935542
DFA7_-1658935542 -->|"1"|DFA8_2097046106
DFA8_2097046106 -->|"D"|DFA9_1460560538
DFA9_1460560538 -->|"A"|DFA10_166869204
DFA10_166869204 -->|"r"|DFA11_211179063
DFA11_211179063 -->|"r"|DFA12_-1680718101
DFA12_-1680718101 -->|"a"|DFA13_-1341428158
DFA13_-1341428158 -->|"y"|DFA14_-721769973
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
DFA0_-1246240523{{"DFA0 regex start"}}
DFA1_320921683{{"DFA1 {1}"}}
DFA2_-1449129117{{"DFA2 {1}"}}
DFA3_207962475{{"DFA3 {1}"}}
DFA4_1300011302{{"DFA4 {1}"}}
DFA5_803381387{{"DFA5 {1}"}}
DFA6_-1729571996{{"DFA6 {1}"}}
DFA7_-1658935542{{"DFA7 {1}"}}
DFA8_2097046106{{"DFA8 {1}"}}
DFA9_1460560538{{"DFA9 {1}"}}
DFA10_166869204{{"DFA10 {1}"}}
DFA11_211179063{{"DFA11 {1}"}}
DFA12_-1680718101{{"DFA12 {1}"}}
DFA13_-1341428158{{"DFA13 {1}"}}
DFA14_-721769973[\"DFA14 {1}"/]
DFA0_-1246240523 -->|"s"|DFA1_320921683
DFA1_320921683 -->|"a"|DFA2_-1449129117
DFA2_-1449129117 -->|"m"|DFA3_207962475
DFA3_207962475 -->|"p"|DFA4_1300011302
DFA4_1300011302 -->|"l"|DFA5_803381387
DFA5_803381387 -->|"e"|DFA6_-1729571996
DFA6_-1729571996 -->|"r"|DFA7_-1658935542
DFA7_-1658935542 -->|"1"|DFA8_2097046106
DFA8_2097046106 -->|"D"|DFA9_1460560538
DFA9_1460560538 -->|"A"|DFA10_166869204
DFA10_166869204 -->|"r"|DFA11_211179063
DFA11_211179063 -->|"r"|DFA12_-1680718101
DFA12_-1680718101 -->|"a"|DFA13_-1341428158
DFA13_-1341428158 -->|"y"|DFA14_-721769973
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
subgraph MiniDFA0_590760047["MiniDFA0 {1}"]
DFA0_-1246240523_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1463921752["MiniDFA1 {1}"]
DFA1_320921683_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-2146366988["MiniDFA3 {1}"]
DFA2_-1449129117_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-523496515["MiniDFA4 {1}"]
DFA3_207962475_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1286044857["MiniDFA5 {1}"]
DFA4_1300011302_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-874424865["MiniDFA6 {1}"]
DFA5_803381387_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_68734495["MiniDFA7 {1}"]
DFA6_-1729571996_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_1797055270["MiniDFA10 {1}"]
DFA7_-1658935542_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_1714460413["MiniDFA11 {1}"]
DFA8_2097046106_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_-1208564015["MiniDFA12 {1}"]
DFA9_1460560538_9{{"DFA9 {1}"}}
end
subgraph MiniDFA8_1598602108["MiniDFA8 {1}"]
DFA10_166869204_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_1362432902["MiniDFA9 {1}"]
DFA11_211179063_11{{"DFA11 {1}"}}
end
subgraph MiniDFA2_1931331329["MiniDFA2 {1}"]
DFA12_-1680718101_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_597548736["MiniDFA13 {1}"]
DFA13_-1341428158_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1390980217["MiniDFA14 {1}"]
DFA14_-721769973_14[\"DFA14 {1}"/]
end
MiniDFA0_590760047 -->|"s"|MiniDFA1_1463921752
MiniDFA1_1463921752 -->|"a"|MiniDFA3_-2146366988
MiniDFA3_-2146366988 -->|"m"|MiniDFA4_-523496515
MiniDFA4_-523496515 -->|"p"|MiniDFA5_-1286044857
MiniDFA5_-1286044857 -->|"l"|MiniDFA6_-874424865
MiniDFA6_-874424865 -->|"e"|MiniDFA7_68734495
MiniDFA7_68734495 -->|"r"|MiniDFA10_1797055270
MiniDFA10_1797055270 -->|"1"|MiniDFA11_1714460413
MiniDFA11_1714460413 -->|"D"|MiniDFA12_-1208564015
MiniDFA12_-1208564015 -->|"A"|MiniDFA8_1598602108
MiniDFA8_1598602108 -->|"r"|MiniDFA9_1362432902
MiniDFA9_1362432902 -->|"r"|MiniDFA2_1931331329
MiniDFA2_1931331329 -->|"a"|MiniDFA13_597548736
MiniDFA13_597548736 -->|"y"|MiniDFA14_1390980217
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
MiniDFA0_590760047(["MiniDFA0 {1}"])
MiniDFA1_1463921752(["MiniDFA1 {1}"])
MiniDFA3_-2146366988(["MiniDFA3 {1}"])
MiniDFA4_-523496515(["MiniDFA4 {1}"])
MiniDFA5_-1286044857(["MiniDFA5 {1}"])
MiniDFA6_-874424865(["MiniDFA6 {1}"])
MiniDFA7_68734495(["MiniDFA7 {1}"])
MiniDFA10_1797055270(["MiniDFA10 {1}"])
MiniDFA11_1714460413(["MiniDFA11 {1}"])
MiniDFA12_-1208564015(["MiniDFA12 {1}"])
MiniDFA8_1598602108(["MiniDFA8 {1}"])
MiniDFA9_1362432902(["MiniDFA9 {1}"])
MiniDFA2_1931331329(["MiniDFA2 {1}"])
MiniDFA13_597548736(["MiniDFA13 {1}"])
MiniDFA14_1390980217[\"MiniDFA14 {1}"/]
MiniDFA0_590760047 -->|"s"|MiniDFA1_1463921752
MiniDFA1_1463921752 -->|"a"|MiniDFA3_-2146366988
MiniDFA3_-2146366988 -->|"m"|MiniDFA4_-523496515
MiniDFA4_-523496515 -->|"p"|MiniDFA5_-1286044857
MiniDFA5_-1286044857 -->|"l"|MiniDFA6_-874424865
MiniDFA6_-874424865 -->|"e"|MiniDFA7_68734495
MiniDFA7_68734495 -->|"r"|MiniDFA10_1797055270
MiniDFA10_1797055270 -->|"1"|MiniDFA11_1714460413
MiniDFA11_1714460413 -->|"D"|MiniDFA12_-1208564015
MiniDFA12_-1208564015 -->|"A"|MiniDFA8_1598602108
MiniDFA8_1598602108 -->|"r"|MiniDFA9_1362432902
MiniDFA9_1362432902 -->|"r"|MiniDFA2_1931331329
MiniDFA2_1931331329 -->|"a"|MiniDFA13_597548736
MiniDFA13_597548736 -->|"y"|MiniDFA14_1390980217
```
-------------------------------
