# 'sampler2DShadow'

pattern: `sampler2DShadow`

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
eNFA125_30_34211353[["εNFA125-30 regex start"]]
eNFA125_0_39466727[["εNFA125-0 char{1, 1}"]]
eNFA125_1_19656228[["εNFA125-1 char[1]"]]
eNFA125_2_42688329[["εNFA125-2 char{1, 1}"]]
eNFA125_3_48650648[["εNFA125-3 char[1]"]]
eNFA125_4_35202648[["εNFA125-4 char{1, 1}"]]
eNFA125_5_48388379[["εNFA125-5 char[1]"]]
eNFA125_6_32842235[["εNFA125-6 char{1, 1}"]]
eNFA125_7_27144664[["εNFA125-7 char[1]"]]
eNFA125_8_42975387[["εNFA125-8 char{1, 1}"]]
eNFA125_9_51234165[["εNFA125-9 char[1]"]]
eNFA125_10_58454303[["εNFA125-10 char{1, 1}"]]
eNFA125_11_56326682[["εNFA125-11 char[1]"]]
eNFA125_12_37178096[["εNFA125-12 char{1, 1}"]]
eNFA125_13_66167408[["εNFA125-13 char[1]"]]
eNFA125_14_58635765[["εNFA125-14 char{1, 1}"]]
eNFA125_15_57959838[["εNFA125-15 char[1]"]]
eNFA125_16_51876502[["εNFA125-16 char{1, 1}"]]
eNFA125_17_64235341[["εNFA125-17 char[1]"]]
eNFA125_18_41247165[["εNFA125-18 char{1, 1}"]]
eNFA125_19_35680165[["εNFA125-19 char[1]"]]
eNFA125_20_52686031[["εNFA125-20 char{1, 1}"]]
eNFA125_21_4412237[["εNFA125-21 char[1]"]]
eNFA125_22_39710134[["εNFA125-22 char{1, 1}"]]
eNFA125_23_21846893[["εNFA125-23 char[1]"]]
eNFA125_24_62404314[["εNFA125-24 char{1, 1}"]]
eNFA125_25_24767918[["εNFA125-25 char[1]"]]
eNFA125_26_21584674[["εNFA125-26 char{1, 1}"]]
eNFA125_27_60044343[["εNFA125-27 char[1]"]]
eNFA125_28_3528183[["εNFA125-28 char{1, 1}"]]
eNFA125_29_31753649[["εNFA125-29 char[1]"]]
eNFA125_31_17347392[["εNFA125-31 regex end"]]
eNFA125_32_21908804[["εNFA125-32 post-regex start"]]
eNFA125_33_62961510[\"εNFA125-33 post-regex end"/]
eNFA125_30_34211353 -.->|"ε"|eNFA125_0_39466727
eNFA125_0_39466727 -->|"s"|eNFA125_1_19656228
eNFA125_1_19656228 -.->|"ε"|eNFA125_2_42688329
eNFA125_2_42688329 -->|"a"|eNFA125_3_48650648
eNFA125_3_48650648 -.->|"ε"|eNFA125_4_35202648
eNFA125_4_35202648 -->|"m"|eNFA125_5_48388379
eNFA125_5_48388379 -.->|"ε"|eNFA125_6_32842235
eNFA125_6_32842235 -->|"p"|eNFA125_7_27144664
eNFA125_7_27144664 -.->|"ε"|eNFA125_8_42975387
eNFA125_8_42975387 -->|"l"|eNFA125_9_51234165
eNFA125_9_51234165 -.->|"ε"|eNFA125_10_58454303
eNFA125_10_58454303 -->|"e"|eNFA125_11_56326682
eNFA125_11_56326682 -.->|"ε"|eNFA125_12_37178096
eNFA125_12_37178096 -->|"r"|eNFA125_13_66167408
eNFA125_13_66167408 -.->|"ε"|eNFA125_14_58635765
eNFA125_14_58635765 -->|"2"|eNFA125_15_57959838
eNFA125_15_57959838 -.->|"ε"|eNFA125_16_51876502
eNFA125_16_51876502 -->|"D"|eNFA125_17_64235341
eNFA125_17_64235341 -.->|"ε"|eNFA125_18_41247165
eNFA125_18_41247165 -->|"S"|eNFA125_19_35680165
eNFA125_19_35680165 -.->|"ε"|eNFA125_20_52686031
eNFA125_20_52686031 -->|"h"|eNFA125_21_4412237
eNFA125_21_4412237 -.->|"ε"|eNFA125_22_39710134
eNFA125_22_39710134 -->|"a"|eNFA125_23_21846893
eNFA125_23_21846893 -.->|"ε"|eNFA125_24_62404314
eNFA125_24_62404314 -->|"d"|eNFA125_25_24767918
eNFA125_25_24767918 -.->|"ε"|eNFA125_26_21584674
eNFA125_26_21584674 -->|"o"|eNFA125_27_60044343
eNFA125_27_60044343 -.->|"ε"|eNFA125_28_3528183
eNFA125_28_3528183 -->|"w"|eNFA125_29_31753649
eNFA125_29_31753649 -.->|"ε"|eNFA125_31_17347392
eNFA125_31_17347392 -.->|"ε"|eNFA125_32_21908804
eNFA125_32_21908804 -.->|"ε"|eNFA125_33_62961510
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
eNFA125_30_29782679[["εNFA125-30 regex start"]]
eNFA125_0_66717520[["εNFA125-0 char{1, 1}"]]
eNFA125_1_63586770[["εNFA125-1 char[1]"]]
eNFA125_2_35410022[["εNFA125-2 char{1, 1}"]]
eNFA125_3_50254750[["εNFA125-3 char[1]"]]
eNFA125_4_49639570[["εNFA125-4 char{1, 1}"]]
eNFA125_5_44102946[["εNFA125-5 char[1]"]]
eNFA125_6_61382201[["εNFA125-6 char{1, 1}"]]
eNFA125_7_15568903[["εNFA125-7 char[1]"]]
eNFA125_8_5902405[["εNFA125-8 char{1, 1}"]]
eNFA125_9_53121653[["εNFA125-9 char[1]"]]
eNFA125_10_8332830[["εNFA125-10 char{1, 1}"]]
eNFA125_11_7886611[["εNFA125-11 char[1]"]]
eNFA125_12_3870635[["εNFA125-12 char{1, 1}"]]
eNFA125_13_34835721[["εNFA125-13 char[1]"]]
eNFA125_14_45086037[["εNFA125-14 char{1, 1}"]]
eNFA125_15_3121152[["εNFA125-15 char[1]"]]
eNFA125_16_28090371[["εNFA125-16 char{1, 1}"]]
eNFA125_17_51486751[["εNFA125-17 char[1]"]]
eNFA125_18_60727582[["εNFA125-18 char{1, 1}"]]
eNFA125_19_9677327[["εNFA125-19 char[1]"]]
eNFA125_20_19987085[["εNFA125-20 char{1, 1}"]]
eNFA125_21_45666040[["εNFA125-21 char[1]"]]
eNFA125_22_8341177[["εNFA125-22 char{1, 1}"]]
eNFA125_23_7961729[["εNFA125-23 char[1]"]]
eNFA125_24_4546697[["εNFA125-24 char{1, 1}"]]
eNFA125_25_40920274[["εNFA125-25 char[1]"]]
eNFA125_26_32738149[["εNFA125-26 char{1, 1}"]]
eNFA125_27_26207892[["εNFA125-27 char[1]"]]
eNFA125_28_34544438[["εNFA125-28 char{1, 1}"]]
eNFA125_29_42464494[\"εNFA125-29 char[1]"/]
eNFA125_31_46636132[\"εNFA125-31 regex end"/]
eNFA125_32_17072009[\"εNFA125-32 post-regex start"/]
eNFA125_33_19430358[\"εNFA125-33 post-regex end"/]
eNFA125_30_29782679 -.->|"ε"|eNFA125_0_66717520
eNFA125_30_29782679 -->|"s"|eNFA125_1_63586770
eNFA125_0_66717520 -->|"s"|eNFA125_1_63586770
eNFA125_1_63586770 -.->|"ε"|eNFA125_2_35410022
eNFA125_1_63586770 -->|"a"|eNFA125_3_50254750
eNFA125_2_35410022 -->|"a"|eNFA125_3_50254750
eNFA125_3_50254750 -.->|"ε"|eNFA125_4_49639570
eNFA125_3_50254750 -->|"m"|eNFA125_5_44102946
eNFA125_4_49639570 -->|"m"|eNFA125_5_44102946
eNFA125_5_44102946 -.->|"ε"|eNFA125_6_61382201
eNFA125_5_44102946 -->|"p"|eNFA125_7_15568903
eNFA125_6_61382201 -->|"p"|eNFA125_7_15568903
eNFA125_7_15568903 -.->|"ε"|eNFA125_8_5902405
eNFA125_7_15568903 -->|"l"|eNFA125_9_53121653
eNFA125_8_5902405 -->|"l"|eNFA125_9_53121653
eNFA125_9_53121653 -.->|"ε"|eNFA125_10_8332830
eNFA125_9_53121653 -->|"e"|eNFA125_11_7886611
eNFA125_10_8332830 -->|"e"|eNFA125_11_7886611
eNFA125_11_7886611 -.->|"ε"|eNFA125_12_3870635
eNFA125_11_7886611 -->|"r"|eNFA125_13_34835721
eNFA125_12_3870635 -->|"r"|eNFA125_13_34835721
eNFA125_13_34835721 -.->|"ε"|eNFA125_14_45086037
eNFA125_13_34835721 -->|"2"|eNFA125_15_3121152
eNFA125_14_45086037 -->|"2"|eNFA125_15_3121152
eNFA125_15_3121152 -.->|"ε"|eNFA125_16_28090371
eNFA125_15_3121152 -->|"D"|eNFA125_17_51486751
eNFA125_16_28090371 -->|"D"|eNFA125_17_51486751
eNFA125_17_51486751 -.->|"ε"|eNFA125_18_60727582
eNFA125_17_51486751 -->|"S"|eNFA125_19_9677327
eNFA125_18_60727582 -->|"S"|eNFA125_19_9677327
eNFA125_19_9677327 -.->|"ε"|eNFA125_20_19987085
eNFA125_19_9677327 -->|"h"|eNFA125_21_45666040
eNFA125_20_19987085 -->|"h"|eNFA125_21_45666040
eNFA125_21_45666040 -.->|"ε"|eNFA125_22_8341177
eNFA125_21_45666040 -->|"a"|eNFA125_23_7961729
eNFA125_22_8341177 -->|"a"|eNFA125_23_7961729
eNFA125_23_7961729 -.->|"ε"|eNFA125_24_4546697
eNFA125_23_7961729 -->|"d"|eNFA125_25_40920274
eNFA125_24_4546697 -->|"d"|eNFA125_25_40920274
eNFA125_25_40920274 -.->|"ε"|eNFA125_26_32738149
eNFA125_25_40920274 -->|"o"|eNFA125_27_26207892
eNFA125_26_32738149 -->|"o"|eNFA125_27_26207892
eNFA125_27_26207892 -.->|"ε"|eNFA125_28_34544438
eNFA125_27_26207892 -->|"w"|eNFA125_29_42464494
eNFA125_28_34544438 -->|"w"|eNFA125_29_42464494
eNFA125_29_42464494 -.->|"ε"|eNFA125_31_46636132
eNFA125_29_42464494 -.->|"ε"|eNFA125_32_17072009
eNFA125_29_42464494 -.->|"ε"|eNFA125_33_19430358
eNFA125_31_46636132 -.->|"ε"|eNFA125_32_17072009
eNFA125_31_46636132 -.->|"ε"|eNFA125_33_19430358
eNFA125_32_17072009 -.->|"ε"|eNFA125_33_19430358
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
NFA125_30_40655501("NFA125-30 regex start")
NFA125_1_30355189("NFA125-1 char[1]")
NFA125_3_4761248("NFA125-3 char[1]")
NFA125_5_42851240("NFA125-5 char[1]")
NFA125_7_50116845("NFA125-7 char[1]")
NFA125_9_48398424("NFA125-9 char[1]")
NFA125_11_32932634("NFA125-11 char[1]")
NFA125_13_27958252("NFA125-13 char[1]")
NFA125_15_50297679("NFA125-15 char[1]")
NFA125_17_50025933("NFA125-17 char[1]")
NFA125_19_47580213("NFA125-19 char[1]")
NFA125_21_25568738("NFA125-21 char[1]")
NFA125_23_28792051("NFA125-23 char[1]")
NFA125_25_57801875("NFA125-25 char[1]")
NFA125_27_50454834("NFA125-27 char[1]")
NFA125_29_51440330[\"NFA125-29 char[1]"/]
NFA125_30_40655501 -->|"s"|NFA125_1_30355189
NFA125_1_30355189 -->|"a"|NFA125_3_4761248
NFA125_3_4761248 -->|"m"|NFA125_5_42851240
NFA125_5_42851240 -->|"p"|NFA125_7_50116845
NFA125_7_50116845 -->|"l"|NFA125_9_48398424
NFA125_9_48398424 -->|"e"|NFA125_11_32932634
NFA125_11_32932634 -->|"r"|NFA125_13_27958252
NFA125_13_27958252 -->|"2"|NFA125_15_50297679
NFA125_15_50297679 -->|"D"|NFA125_17_50025933
NFA125_17_50025933 -->|"S"|NFA125_19_47580213
NFA125_19_47580213 -->|"h"|NFA125_21_25568738
NFA125_21_25568738 -->|"a"|NFA125_23_28792051
NFA125_23_28792051 -->|"d"|NFA125_25_57801875
NFA125_25_57801875 -->|"o"|NFA125_27_50454834
NFA125_27_50454834 -->|"w"|NFA125_29_51440330
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
subgraph DFA0_-557183995["DFA0 regex start"]
NFA125_30_40655501_0("NFA125-30 regex start")
end
subgraph DFA1_-29114705["DFA1 {1}"]
NFA125_1_30355189_1("NFA125-1 char[1]")
end
subgraph DFA2_69349375["DFA2 {1}"]
NFA125_3_4761248_2("NFA125-3 char[1]")
end
subgraph DFA3_324356544["DFA3 {1}"]
NFA125_5_42851240_3("NFA125-5 char[1]")
end
subgraph DFA4_-1123937891["DFA4 {1}"]
NFA125_7_50116845_4("NFA125-7 char[1]")
end
subgraph DFA5_1397190793["DFA5 {1}"]
NFA125_9_48398424_5("NFA125-9 char[1]")
end
subgraph DFA6_-1519124345["DFA6 {1}"]
NFA125_11_32932634_6("NFA125-11 char[1]")
end
subgraph DFA7_-1992238535["DFA7 {1}"]
NFA125_13_27958252_7("NFA125-13 char[1]")
end
subgraph DFA8_-729071827["DFA8 {1}"]
NFA125_15_50297679_8("NFA125-15 char[1]")
end
subgraph DFA9_-1381485191["DFA9 {1}"]
NFA125_17_50025933_9("NFA125-17 char[1]")
end
subgraph DFA10_-579134405["DFA10 {1}"]
NFA125_19_47580213_10("NFA125-19 char[1]")
end
subgraph DFA11_-247673900["DFA11 {1}"]
NFA125_21_25568738_11("NFA125-21 char[1]")
end
subgraph DFA12_-1052035875["DFA12 {1}"]
NFA125_23_28792051_12("NFA125-23 char[1]")
end
subgraph DFA13_-627909927["DFA13 {1}"]
NFA125_25_57801875_13("NFA125-25 char[1]")
end
subgraph DFA14_-197576635["DFA14 {1}"]
NFA125_27_50454834_14("NFA125-27 char[1]")
end
subgraph DFA15_1779603837["DFA15 {1}"]
NFA125_29_51440330_15[\"NFA125-29 char[1]"/]
end
DFA0_-557183995 -->|"s"|DFA1_-29114705
DFA1_-29114705 -->|"a"|DFA2_69349375
DFA2_69349375 -->|"m"|DFA3_324356544
DFA3_324356544 -->|"p"|DFA4_-1123937891
DFA4_-1123937891 -->|"l"|DFA5_1397190793
DFA5_1397190793 -->|"e"|DFA6_-1519124345
DFA6_-1519124345 -->|"r"|DFA7_-1992238535
DFA7_-1992238535 -->|"2"|DFA8_-729071827
DFA8_-729071827 -->|"D"|DFA9_-1381485191
DFA9_-1381485191 -->|"S"|DFA10_-579134405
DFA10_-579134405 -->|"h"|DFA11_-247673900
DFA11_-247673900 -->|"a"|DFA12_-1052035875
DFA12_-1052035875 -->|"d"|DFA13_-627909927
DFA13_-627909927 -->|"o"|DFA14_-197576635
DFA14_-197576635 -->|"w"|DFA15_1779603837
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
DFA0_-557183995{{"DFA0 regex start"}}
DFA1_-29114705{{"DFA1 {1}"}}
DFA2_69349375{{"DFA2 {1}"}}
DFA3_324356544{{"DFA3 {1}"}}
DFA4_-1123937891{{"DFA4 {1}"}}
DFA5_1397190793{{"DFA5 {1}"}}
DFA6_-1519124345{{"DFA6 {1}"}}
DFA7_-1992238535{{"DFA7 {1}"}}
DFA8_-729071827{{"DFA8 {1}"}}
DFA9_-1381485191{{"DFA9 {1}"}}
DFA10_-579134405{{"DFA10 {1}"}}
DFA11_-247673900{{"DFA11 {1}"}}
DFA12_-1052035875{{"DFA12 {1}"}}
DFA13_-627909927{{"DFA13 {1}"}}
DFA14_-197576635{{"DFA14 {1}"}}
DFA15_1779603837[\"DFA15 {1}"/]
DFA0_-557183995 -->|"s"|DFA1_-29114705
DFA1_-29114705 -->|"a"|DFA2_69349375
DFA2_69349375 -->|"m"|DFA3_324356544
DFA3_324356544 -->|"p"|DFA4_-1123937891
DFA4_-1123937891 -->|"l"|DFA5_1397190793
DFA5_1397190793 -->|"e"|DFA6_-1519124345
DFA6_-1519124345 -->|"r"|DFA7_-1992238535
DFA7_-1992238535 -->|"2"|DFA8_-729071827
DFA8_-729071827 -->|"D"|DFA9_-1381485191
DFA9_-1381485191 -->|"S"|DFA10_-579134405
DFA10_-579134405 -->|"h"|DFA11_-247673900
DFA11_-247673900 -->|"a"|DFA12_-1052035875
DFA12_-1052035875 -->|"d"|DFA13_-627909927
DFA13_-627909927 -->|"o"|DFA14_-197576635
DFA14_-197576635 -->|"w"|DFA15_1779603837
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
subgraph MiniDFA0_179266550["MiniDFA0 {1}"]
DFA0_-557183995_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-50018135["MiniDFA1 {1}"]
DFA1_-29114705_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-542296667["MiniDFA3 {1}"]
DFA2_69349375_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_831548085["MiniDFA4 {1}"]
DFA3_324356544_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-770894827["MiniDFA5 {1}"]
DFA4_-1123937891_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-275559843["MiniDFA6 {1}"]
DFA5_1397190793_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_2074450974["MiniDFA7 {1}"]
DFA6_-1519124345_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_825622174["MiniDFA8 {1}"]
DFA7_-1992238535_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_385666866["MiniDFA9 {1}"]
DFA8_-729071827_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-1322336892["MiniDFA10 {1}"]
DFA9_-1381485191_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-851903558["MiniDFA11 {1}"]
DFA10_-579134405_10{{"DFA10 {1}"}}
end
subgraph MiniDFA2_1222003599["MiniDFA2 {1}"]
DFA11_-247673900_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-497435378["MiniDFA12 {1}"]
DFA12_-1052035875_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_200661493["MiniDFA13 {1}"]
DFA13_-627909927_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-297861384["MiniDFA14 {1}"]
DFA14_-197576635_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_1547143928["MiniDFA15 {1}"]
DFA15_1779603837_15[\"DFA15 {1}"/]
end
MiniDFA0_179266550 -->|"s"|MiniDFA1_-50018135
MiniDFA1_-50018135 -->|"a"|MiniDFA3_-542296667
MiniDFA3_-542296667 -->|"m"|MiniDFA4_831548085
MiniDFA4_831548085 -->|"p"|MiniDFA5_-770894827
MiniDFA5_-770894827 -->|"l"|MiniDFA6_-275559843
MiniDFA6_-275559843 -->|"e"|MiniDFA7_2074450974
MiniDFA7_2074450974 -->|"r"|MiniDFA8_825622174
MiniDFA8_825622174 -->|"2"|MiniDFA9_385666866
MiniDFA9_385666866 -->|"D"|MiniDFA10_-1322336892
MiniDFA10_-1322336892 -->|"S"|MiniDFA11_-851903558
MiniDFA11_-851903558 -->|"h"|MiniDFA2_1222003599
MiniDFA2_1222003599 -->|"a"|MiniDFA12_-497435378
MiniDFA12_-497435378 -->|"d"|MiniDFA13_200661493
MiniDFA13_200661493 -->|"o"|MiniDFA14_-297861384
MiniDFA14_-297861384 -->|"w"|MiniDFA15_1547143928
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
MiniDFA0_179266550(["MiniDFA0 {1}"])
MiniDFA1_-50018135(["MiniDFA1 {1}"])
MiniDFA3_-542296667(["MiniDFA3 {1}"])
MiniDFA4_831548085(["MiniDFA4 {1}"])
MiniDFA5_-770894827(["MiniDFA5 {1}"])
MiniDFA6_-275559843(["MiniDFA6 {1}"])
MiniDFA7_2074450974(["MiniDFA7 {1}"])
MiniDFA8_825622174(["MiniDFA8 {1}"])
MiniDFA9_385666866(["MiniDFA9 {1}"])
MiniDFA10_-1322336892(["MiniDFA10 {1}"])
MiniDFA11_-851903558(["MiniDFA11 {1}"])
MiniDFA2_1222003599(["MiniDFA2 {1}"])
MiniDFA12_-497435378(["MiniDFA12 {1}"])
MiniDFA13_200661493(["MiniDFA13 {1}"])
MiniDFA14_-297861384(["MiniDFA14 {1}"])
MiniDFA15_1547143928[\"MiniDFA15 {1}"/]
MiniDFA0_179266550 -->|"s"|MiniDFA1_-50018135
MiniDFA1_-50018135 -->|"a"|MiniDFA3_-542296667
MiniDFA3_-542296667 -->|"m"|MiniDFA4_831548085
MiniDFA4_831548085 -->|"p"|MiniDFA5_-770894827
MiniDFA5_-770894827 -->|"l"|MiniDFA6_-275559843
MiniDFA6_-275559843 -->|"e"|MiniDFA7_2074450974
MiniDFA7_2074450974 -->|"r"|MiniDFA8_825622174
MiniDFA8_825622174 -->|"2"|MiniDFA9_385666866
MiniDFA9_385666866 -->|"D"|MiniDFA10_-1322336892
MiniDFA10_-1322336892 -->|"S"|MiniDFA11_-851903558
MiniDFA11_-851903558 -->|"h"|MiniDFA2_1222003599
MiniDFA2_1222003599 -->|"a"|MiniDFA12_-497435378
MiniDFA12_-497435378 -->|"d"|MiniDFA13_200661493
MiniDFA13_200661493 -->|"o"|MiniDFA14_-297861384
MiniDFA14_-297861384 -->|"w"|MiniDFA15_1547143928
```
-------------------------------
