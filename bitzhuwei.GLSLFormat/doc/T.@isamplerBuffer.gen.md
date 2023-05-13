# 'isamplerBuffer'

pattern: `isamplerBuffer`

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
eNFA152_28_20684297[["εNFA152-28 regex start"]]
eNFA152_0_51940951[["εNFA152-0 char{1, 1}"]]
eNFA152_1_64815380[["εNFA152-1 char[1]"]]
eNFA152_2_46467513[["εNFA152-2 char{1, 1}"]]
eNFA152_3_15554440[["εNFA152-3 char[1]"]]
eNFA152_4_5772232[["εNFA152-4 char{1, 1}"]]
eNFA152_5_51950091[["εNFA152-5 char[1]"]]
eNFA152_6_64897643[["εNFA152-6 char{1, 1}"]]
eNFA152_7_47207880[["εNFA152-7 char[1]"]]
eNFA152_8_22217739[["εNFA152-8 char{1, 1}"]]
eNFA152_9_65741925[["εNFA152-9 char[1]"]]
eNFA152_10_54806415[["εNFA152-10 char{1, 1}"]]
eNFA152_11_23495690[["εNFA152-11 char[1]"]]
eNFA152_12_10134624[["εNFA152-12 char{1, 1}"]]
eNFA152_13_24102752[["εNFA152-13 char[1]"]]
eNFA152_14_15598181[["εNFA152-14 char{1, 1}"]]
eNFA152_15_6165902[["εNFA152-15 char[1]"]]
eNFA152_16_55493126[["εNFA152-16 char{1, 1}"]]
eNFA152_17_29676093[["εNFA152-17 char[1]"]]
eNFA152_18_65758253[["εNFA152-18 char{1, 1}"]]
eNFA152_19_54953365[["εNFA152-19 char[1]"]]
eNFA152_20_24818239[["εNFA152-20 char{1, 1}"]]
eNFA152_21_22037565[["εNFA152-21 char[1]"]]
eNFA152_22_64120358[["εNFA152-22 char{1, 1}"]]
eNFA152_23_40212317[["εNFA152-23 char[1]"]]
eNFA152_24_26366538[["εNFA152-24 char{1, 1}"]]
eNFA152_25_35972254[["εNFA152-25 char[1]"]]
eNFA152_26_55314834[["εNFA152-26 char{1, 1}"]]
eNFA152_27_28071463[["εNFA152-27 char[1]"]]
eNFA152_29_51316583[["εNFA152-29 regex end"]]
eNFA152_30_59196065[["εNFA152-30 post-regex start"]]
eNFA152_31_63002544[\"εNFA152-31 post-regex end"/]
eNFA152_28_20684297 -.->|"ε"|eNFA152_0_51940951
eNFA152_0_51940951 -->|"i"|eNFA152_1_64815380
eNFA152_1_64815380 -.->|"ε"|eNFA152_2_46467513
eNFA152_2_46467513 -->|"s"|eNFA152_3_15554440
eNFA152_3_15554440 -.->|"ε"|eNFA152_4_5772232
eNFA152_4_5772232 -->|"a"|eNFA152_5_51950091
eNFA152_5_51950091 -.->|"ε"|eNFA152_6_64897643
eNFA152_6_64897643 -->|"m"|eNFA152_7_47207880
eNFA152_7_47207880 -.->|"ε"|eNFA152_8_22217739
eNFA152_8_22217739 -->|"p"|eNFA152_9_65741925
eNFA152_9_65741925 -.->|"ε"|eNFA152_10_54806415
eNFA152_10_54806415 -->|"l"|eNFA152_11_23495690
eNFA152_11_23495690 -.->|"ε"|eNFA152_12_10134624
eNFA152_12_10134624 -->|"e"|eNFA152_13_24102752
eNFA152_13_24102752 -.->|"ε"|eNFA152_14_15598181
eNFA152_14_15598181 -->|"r"|eNFA152_15_6165902
eNFA152_15_6165902 -.->|"ε"|eNFA152_16_55493126
eNFA152_16_55493126 -->|"B"|eNFA152_17_29676093
eNFA152_17_29676093 -.->|"ε"|eNFA152_18_65758253
eNFA152_18_65758253 -->|"u"|eNFA152_19_54953365
eNFA152_19_54953365 -.->|"ε"|eNFA152_20_24818239
eNFA152_20_24818239 -->|"f"|eNFA152_21_22037565
eNFA152_21_22037565 -.->|"ε"|eNFA152_22_64120358
eNFA152_22_64120358 -->|"f"|eNFA152_23_40212317
eNFA152_23_40212317 -.->|"ε"|eNFA152_24_26366538
eNFA152_24_26366538 -->|"e"|eNFA152_25_35972254
eNFA152_25_35972254 -.->|"ε"|eNFA152_26_55314834
eNFA152_26_55314834 -->|"r"|eNFA152_27_28071463
eNFA152_27_28071463 -.->|"ε"|eNFA152_29_51316583
eNFA152_29_51316583 -.->|"ε"|eNFA152_30_59196065
eNFA152_30_59196065 -.->|"ε"|eNFA152_31_63002544
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
eNFA152_28_30151988[["εNFA152-28 regex start"]]
eNFA152_0_2932438[["εNFA152-0 char{1, 1}"]]
eNFA152_1_26391943[["εNFA152-1 char[1]"]]
eNFA152_2_36200896[["εNFA152-2 char{1, 1}"]]
eNFA152_3_57372610[["εNFA152-3 char[1]"]]
eNFA152_4_46591446[["εNFA152-4 char{1, 1}"]]
eNFA152_5_16669838[["εNFA152-5 char[1]"]]
eNFA152_6_15810818[["εNFA152-6 char{1, 1}"]]
eNFA152_7_8079634[["εNFA152-7 char[1]"]]
eNFA152_8_5607849[["εNFA152-8 char{1, 1}"]]
eNFA152_9_50470647[["εNFA152-9 char[1]"]]
eNFA152_10_51582645[["εNFA152-10 char{1, 1}"]]
eNFA152_11_61590629[["εNFA152-11 char[1]"]]
eNFA152_12_17444750[["εNFA152-12 char{1, 1}"]]
eNFA152_13_22785027[["εNFA152-13 char[1]"]]
eNFA152_14_3738651[["εNFA152-14 char{1, 1}"]]
eNFA152_15_33647865[["εNFA152-15 char[1]"]]
eNFA152_16_34395333[["εNFA152-16 char{1, 1}"]]
eNFA152_17_41122544[["εNFA152-17 char[1]"]]
eNFA152_18_34558579[["εNFA152-18 char{1, 1}"]]
eNFA152_19_42591759[["εNFA152-19 char[1]"]]
eNFA152_20_47781518[["εNFA152-20 char{1, 1}"]]
eNFA152_21_27380479[["εNFA152-21 char[1]"]]
eNFA152_22_45097725[["εNFA152-22 char{1, 1}"]]
eNFA152_23_3226344[["εNFA152-23 char[1]"]]
eNFA152_24_29037097[["εNFA152-24 char{1, 1}"]]
eNFA152_25_60007281[["εNFA152-25 char[1]"]]
eNFA152_26_3194617[["εNFA152-26 char{1, 1}"]]
eNFA152_27_28751554[\"εNFA152-27 char[1]"/]
eNFA152_29_57437397[\"εNFA152-29 regex end"/]
eNFA152_30_47174532[\"εNFA152-30 post-regex start"/]
eNFA152_31_21917606[\"εNFA152-31 post-regex end"/]
eNFA152_28_30151988 -.->|"ε"|eNFA152_0_2932438
eNFA152_28_30151988 -->|"i"|eNFA152_1_26391943
eNFA152_0_2932438 -->|"i"|eNFA152_1_26391943
eNFA152_1_26391943 -.->|"ε"|eNFA152_2_36200896
eNFA152_1_26391943 -->|"s"|eNFA152_3_57372610
eNFA152_2_36200896 -->|"s"|eNFA152_3_57372610
eNFA152_3_57372610 -.->|"ε"|eNFA152_4_46591446
eNFA152_3_57372610 -->|"a"|eNFA152_5_16669838
eNFA152_4_46591446 -->|"a"|eNFA152_5_16669838
eNFA152_5_16669838 -.->|"ε"|eNFA152_6_15810818
eNFA152_5_16669838 -->|"m"|eNFA152_7_8079634
eNFA152_6_15810818 -->|"m"|eNFA152_7_8079634
eNFA152_7_8079634 -.->|"ε"|eNFA152_8_5607849
eNFA152_7_8079634 -->|"p"|eNFA152_9_50470647
eNFA152_8_5607849 -->|"p"|eNFA152_9_50470647
eNFA152_9_50470647 -.->|"ε"|eNFA152_10_51582645
eNFA152_9_50470647 -->|"l"|eNFA152_11_61590629
eNFA152_10_51582645 -->|"l"|eNFA152_11_61590629
eNFA152_11_61590629 -.->|"ε"|eNFA152_12_17444750
eNFA152_11_61590629 -->|"e"|eNFA152_13_22785027
eNFA152_12_17444750 -->|"e"|eNFA152_13_22785027
eNFA152_13_22785027 -.->|"ε"|eNFA152_14_3738651
eNFA152_13_22785027 -->|"r"|eNFA152_15_33647865
eNFA152_14_3738651 -->|"r"|eNFA152_15_33647865
eNFA152_15_33647865 -.->|"ε"|eNFA152_16_34395333
eNFA152_15_33647865 -->|"B"|eNFA152_17_41122544
eNFA152_16_34395333 -->|"B"|eNFA152_17_41122544
eNFA152_17_41122544 -.->|"ε"|eNFA152_18_34558579
eNFA152_17_41122544 -->|"u"|eNFA152_19_42591759
eNFA152_18_34558579 -->|"u"|eNFA152_19_42591759
eNFA152_19_42591759 -.->|"ε"|eNFA152_20_47781518
eNFA152_19_42591759 -->|"f"|eNFA152_21_27380479
eNFA152_20_47781518 -->|"f"|eNFA152_21_27380479
eNFA152_21_27380479 -.->|"ε"|eNFA152_22_45097725
eNFA152_21_27380479 -->|"f"|eNFA152_23_3226344
eNFA152_22_45097725 -->|"f"|eNFA152_23_3226344
eNFA152_23_3226344 -.->|"ε"|eNFA152_24_29037097
eNFA152_23_3226344 -->|"e"|eNFA152_25_60007281
eNFA152_24_29037097 -->|"e"|eNFA152_25_60007281
eNFA152_25_60007281 -.->|"ε"|eNFA152_26_3194617
eNFA152_25_60007281 -->|"r"|eNFA152_27_28751554
eNFA152_26_3194617 -->|"r"|eNFA152_27_28751554
eNFA152_27_28751554 -.->|"ε"|eNFA152_29_57437397
eNFA152_27_28751554 -.->|"ε"|eNFA152_30_47174532
eNFA152_27_28751554 -.->|"ε"|eNFA152_31_21917606
eNFA152_29_57437397 -.->|"ε"|eNFA152_30_47174532
eNFA152_29_57437397 -.->|"ε"|eNFA152_31_21917606
eNFA152_30_47174532 -.->|"ε"|eNFA152_31_21917606
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
NFA152_28_63040734("NFA152-28 regex start")
NFA152_1_30495700("NFA152-1 char[1]")
NFA152_3_6025849("NFA152-3 char[1]")
NFA152_5_54232646("NFA152-5 char[1]")
NFA152_7_18331773("NFA152-7 char[1]")
NFA152_9_30768229("NFA152-9 char[1]")
NFA152_11_8478608("NFA152-11 char[1]")
NFA152_13_9198616("NFA152-13 char[1]")
NFA152_15_15678685("NFA152-15 char[1]")
NFA152_17_6890440("NFA152-17 char[1]")
NFA152_19_62013962("NFA152-19 char[1]")
NFA152_21_21254748("NFA152-21 char[1]")
NFA152_23_57075007("NFA152-23 char[1]")
NFA152_25_43913021("NFA152-25 char[1]")
NFA152_27_59672869[\"NFA152-27 char[1]"/]
NFA152_28_63040734 -->|"i"|NFA152_1_30495700
NFA152_1_30495700 -->|"s"|NFA152_3_6025849
NFA152_3_6025849 -->|"a"|NFA152_5_54232646
NFA152_5_54232646 -->|"m"|NFA152_7_18331773
NFA152_7_18331773 -->|"p"|NFA152_9_30768229
NFA152_9_30768229 -->|"l"|NFA152_11_8478608
NFA152_11_8478608 -->|"e"|NFA152_13_9198616
NFA152_13_9198616 -->|"r"|NFA152_15_15678685
NFA152_15_15678685 -->|"B"|NFA152_17_6890440
NFA152_17_6890440 -->|"u"|NFA152_19_62013962
NFA152_19_62013962 -->|"f"|NFA152_21_21254748
NFA152_21_21254748 -->|"f"|NFA152_23_57075007
NFA152_23_57075007 -->|"e"|NFA152_25_43913021
NFA152_25_43913021 -->|"r"|NFA152_27_59672869
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
subgraph DFA0_957005251["DFA0 regex start"]
NFA152_28_63040734_0("NFA152-28 regex start")
end
subgraph DFA1_-876397654["DFA1 {1}"]
NFA152_1_30495700_1("NFA152-1 char[1]")
end
subgraph DFA2_-1139420946["DFA2 {1}"]
NFA152_3_6025849_2("NFA152-3 char[1]")
end
subgraph DFA3_229039962["DFA3 {1}"]
NFA152_5_54232646_3("NFA152-5 char[1]")
end
subgraph DFA4_507466688["DFA4 {1}"]
NFA152_7_18331773_4("NFA152-7 char[1]")
end
subgraph DFA5_2057129025["DFA5 {1}"]
NFA152_9_30768229_5("NFA152-9 char[1]")
end
subgraph DFA6_-521749491["DFA6 {1}"]
NFA152_11_8478608_6("NFA152-11 char[1]")
end
subgraph DFA7_60841179["DFA7 {1}"]
NFA152_13_9198616_7("NFA152-13 char[1]")
end
subgraph DFA8_475642866["DFA8 {1}"]
NFA152_15_15678685_8("NFA152-15 char[1]")
end
subgraph DFA9_-1257069767["DFA9 {1}"]
NFA152_17_6890440_9("NFA152-17 char[1]")
end
subgraph DFA10_1873354826["DFA10 {1}"]
NFA152_19_62013962_10("NFA152-19 char[1]")
end
subgraph DFA11_-151246132["DFA11 {1}"]
NFA152_21_21254748_11("NFA152-21 char[1]")
end
subgraph DFA12_-2912869["DFA12 {1}"]
NFA152_23_57075007_12("NFA152-23 char[1]")
end
subgraph DFA13_-1230879320["DFA13 {1}"]
NFA152_25_43913021_13("NFA152-25 char[1]")
end
subgraph DFA14_59220779["DFA14 {1}"]
NFA152_27_59672869_14[\"NFA152-27 char[1]"/]
end
DFA0_957005251 -->|"i"|DFA1_-876397654
DFA1_-876397654 -->|"s"|DFA2_-1139420946
DFA2_-1139420946 -->|"a"|DFA3_229039962
DFA3_229039962 -->|"m"|DFA4_507466688
DFA4_507466688 -->|"p"|DFA5_2057129025
DFA5_2057129025 -->|"l"|DFA6_-521749491
DFA6_-521749491 -->|"e"|DFA7_60841179
DFA7_60841179 -->|"r"|DFA8_475642866
DFA8_475642866 -->|"B"|DFA9_-1257069767
DFA9_-1257069767 -->|"u"|DFA10_1873354826
DFA10_1873354826 -->|"f"|DFA11_-151246132
DFA11_-151246132 -->|"f"|DFA12_-2912869
DFA12_-2912869 -->|"e"|DFA13_-1230879320
DFA13_-1230879320 -->|"r"|DFA14_59220779
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
DFA0_957005251{{"DFA0 regex start"}}
DFA1_-876397654{{"DFA1 {1}"}}
DFA2_-1139420946{{"DFA2 {1}"}}
DFA3_229039962{{"DFA3 {1}"}}
DFA4_507466688{{"DFA4 {1}"}}
DFA5_2057129025{{"DFA5 {1}"}}
DFA6_-521749491{{"DFA6 {1}"}}
DFA7_60841179{{"DFA7 {1}"}}
DFA8_475642866{{"DFA8 {1}"}}
DFA9_-1257069767{{"DFA9 {1}"}}
DFA10_1873354826{{"DFA10 {1}"}}
DFA11_-151246132{{"DFA11 {1}"}}
DFA12_-2912869{{"DFA12 {1}"}}
DFA13_-1230879320{{"DFA13 {1}"}}
DFA14_59220779[\"DFA14 {1}"/]
DFA0_957005251 -->|"i"|DFA1_-876397654
DFA1_-876397654 -->|"s"|DFA2_-1139420946
DFA2_-1139420946 -->|"a"|DFA3_229039962
DFA3_229039962 -->|"m"|DFA4_507466688
DFA4_507466688 -->|"p"|DFA5_2057129025
DFA5_2057129025 -->|"l"|DFA6_-521749491
DFA6_-521749491 -->|"e"|DFA7_60841179
DFA7_60841179 -->|"r"|DFA8_475642866
DFA8_475642866 -->|"B"|DFA9_-1257069767
DFA9_-1257069767 -->|"u"|DFA10_1873354826
DFA10_1873354826 -->|"f"|DFA11_-151246132
DFA11_-151246132 -->|"f"|DFA12_-2912869
DFA12_-2912869 -->|"e"|DFA13_-1230879320
DFA13_-1230879320 -->|"r"|DFA14_59220779
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
subgraph MiniDFA0_-1773817374["MiniDFA0 {1}"]
DFA0_957005251_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1158150206["MiniDFA1 {1}"]
DFA1_-876397654_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1176833435["MiniDFA2 {1}"]
DFA2_-1139420946_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_933596090["MiniDFA3 {1}"]
DFA3_229039962_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-721387124["MiniDFA4 {1}"]
DFA4_507466688_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_21115128["MiniDFA5 {1}"]
DFA5_2057129025_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_668766725["MiniDFA6 {1}"]
DFA6_-521749491_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1135484022["MiniDFA8 {1}"]
DFA7_60841179_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_610641835["MiniDFA9 {1}"]
DFA8_475642866_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_1812422343["MiniDFA10 {1}"]
DFA9_-1257069767_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_22451794["MiniDFA11 {1}"]
DFA10_1873354826_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_-1451158565["MiniDFA12 {1}"]
DFA11_-151246132_11{{"DFA11 {1}"}}
end
subgraph MiniDFA7_868960102["MiniDFA7 {1}"]
DFA12_-2912869_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_1814276262["MiniDFA13 {1}"]
DFA13_-1230879320_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1787772548["MiniDFA14 {1}"]
DFA14_59220779_14[\"DFA14 {1}"/]
end
MiniDFA0_-1773817374 -->|"i"|MiniDFA1_1158150206
MiniDFA1_1158150206 -->|"s"|MiniDFA2_1176833435
MiniDFA2_1176833435 -->|"a"|MiniDFA3_933596090
MiniDFA3_933596090 -->|"m"|MiniDFA4_-721387124
MiniDFA4_-721387124 -->|"p"|MiniDFA5_21115128
MiniDFA5_21115128 -->|"l"|MiniDFA6_668766725
MiniDFA6_668766725 -->|"e"|MiniDFA8_-1135484022
MiniDFA8_-1135484022 -->|"r"|MiniDFA9_610641835
MiniDFA9_610641835 -->|"B"|MiniDFA10_1812422343
MiniDFA10_1812422343 -->|"u"|MiniDFA11_22451794
MiniDFA11_22451794 -->|"f"|MiniDFA12_-1451158565
MiniDFA12_-1451158565 -->|"f"|MiniDFA7_868960102
MiniDFA7_868960102 -->|"e"|MiniDFA13_1814276262
MiniDFA13_1814276262 -->|"r"|MiniDFA14_1787772548
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
MiniDFA0_-1773817374(["MiniDFA0 {1}"])
MiniDFA1_1158150206(["MiniDFA1 {1}"])
MiniDFA2_1176833435(["MiniDFA2 {1}"])
MiniDFA3_933596090(["MiniDFA3 {1}"])
MiniDFA4_-721387124(["MiniDFA4 {1}"])
MiniDFA5_21115128(["MiniDFA5 {1}"])
MiniDFA6_668766725(["MiniDFA6 {1}"])
MiniDFA8_-1135484022(["MiniDFA8 {1}"])
MiniDFA9_610641835(["MiniDFA9 {1}"])
MiniDFA10_1812422343(["MiniDFA10 {1}"])
MiniDFA11_22451794(["MiniDFA11 {1}"])
MiniDFA12_-1451158565(["MiniDFA12 {1}"])
MiniDFA7_868960102(["MiniDFA7 {1}"])
MiniDFA13_1814276262(["MiniDFA13 {1}"])
MiniDFA14_1787772548[\"MiniDFA14 {1}"/]
MiniDFA0_-1773817374 -->|"i"|MiniDFA1_1158150206
MiniDFA1_1158150206 -->|"s"|MiniDFA2_1176833435
MiniDFA2_1176833435 -->|"a"|MiniDFA3_933596090
MiniDFA3_933596090 -->|"m"|MiniDFA4_-721387124
MiniDFA4_-721387124 -->|"p"|MiniDFA5_21115128
MiniDFA5_21115128 -->|"l"|MiniDFA6_668766725
MiniDFA6_668766725 -->|"e"|MiniDFA8_-1135484022
MiniDFA8_-1135484022 -->|"r"|MiniDFA9_610641835
MiniDFA9_610641835 -->|"B"|MiniDFA10_1812422343
MiniDFA10_1812422343 -->|"u"|MiniDFA11_22451794
MiniDFA11_22451794 -->|"f"|MiniDFA12_-1451158565
MiniDFA12_-1451158565 -->|"f"|MiniDFA7_868960102
MiniDFA7_868960102 -->|"e"|MiniDFA13_1814276262
MiniDFA13_1814276262 -->|"r"|MiniDFA14_1787772548
```
-------------------------------
