# 'sampler2DMSArray'

pattern: `sampler2DMSArray`

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
eNFA157_32_16673895[["εNFA157-32 regex start"]]
eNFA157_0_15847329[["εNFA157-0 char{1, 1}"]]
eNFA157_1_8408241[["εNFA157-1 char[1]"]]
eNFA157_2_8565311[["εNFA157-2 char{1, 1}"]]
eNFA157_3_9978940[["εNFA157-3 char[1]"]]
eNFA157_4_22701601[["εNFA157-4 char{1, 1}"]]
eNFA157_5_2987824[["εNFA157-5 char[1]"]]
eNFA157_6_26890416[["εNFA157-6 char{1, 1}"]]
eNFA157_7_40687155[["εNFA157-7 char[1]"]]
eNFA157_8_30640083[["εNFA157-8 char{1, 1}"]]
eNFA157_9_7325296[["εNFA157-9 char[1]"]]
eNFA157_10_65927667[["εNFA157-10 char{1, 1}"]]
eNFA157_11_56478093[["εNFA157-11 char[1]"]]
eNFA157_12_38540791[["εNFA157-12 char{1, 1}"]]
eNFA157_13_11322802[["εNFA157-13 char[1]"]]
eNFA157_14_34796360[["εNFA157-14 char{1, 1}"]]
eNFA157_15_44731784[["εNFA157-15 char[1]"]]
eNFA157_16_67041741[["εNFA157-16 char{1, 1}"]]
eNFA157_17_66504758[["εNFA157-17 char[1]"]]
eNFA157_18_61671918[["εNFA157-18 char{1, 1}"]]
eNFA157_19_18176357[["εNFA157-19 char[1]"]]
eNFA157_20_29369493[["εNFA157-20 char{1, 1}"]]
eNFA157_21_62998845[["εNFA157-21 char[1]"]]
eNFA157_22_30118695[["εNFA157-22 char{1, 1}"]]
eNFA157_23_2632805[["εNFA157-23 char[1]"]]
eNFA157_24_23695246[["εNFA157-24 char{1, 1}"]]
eNFA157_25_11930629[["εNFA157-25 char[1]"]]
eNFA157_26_40266802[["εNFA157-26 char{1, 1}"]]
eNFA157_27_26856902[["εNFA157-27 char[1]"]]
eNFA157_28_40385530[["εNFA157-28 char{1, 1}"]]
eNFA157_29_27925455[["εNFA157-29 char[1]"]]
eNFA157_30_50002511[["εNFA157-30 char{1, 1}"]]
eNFA157_31_47369417[["εNFA157-31 char[1]"]]
eNFA157_33_23671576[["εNFA157-33 regex end"]]
eNFA157_34_11717596[["εNFA157-34 post-regex start"]]
eNFA157_35_38349502[\"εNFA157-35 post-regex end"/]
eNFA157_32_16673895 -.->|"ε"|eNFA157_0_15847329
eNFA157_0_15847329 -->|"s"|eNFA157_1_8408241
eNFA157_1_8408241 -.->|"ε"|eNFA157_2_8565311
eNFA157_2_8565311 -->|"a"|eNFA157_3_9978940
eNFA157_3_9978940 -.->|"ε"|eNFA157_4_22701601
eNFA157_4_22701601 -->|"m"|eNFA157_5_2987824
eNFA157_5_2987824 -.->|"ε"|eNFA157_6_26890416
eNFA157_6_26890416 -->|"p"|eNFA157_7_40687155
eNFA157_7_40687155 -.->|"ε"|eNFA157_8_30640083
eNFA157_8_30640083 -->|"l"|eNFA157_9_7325296
eNFA157_9_7325296 -.->|"ε"|eNFA157_10_65927667
eNFA157_10_65927667 -->|"e"|eNFA157_11_56478093
eNFA157_11_56478093 -.->|"ε"|eNFA157_12_38540791
eNFA157_12_38540791 -->|"r"|eNFA157_13_11322802
eNFA157_13_11322802 -.->|"ε"|eNFA157_14_34796360
eNFA157_14_34796360 -->|"2"|eNFA157_15_44731784
eNFA157_15_44731784 -.->|"ε"|eNFA157_16_67041741
eNFA157_16_67041741 -->|"D"|eNFA157_17_66504758
eNFA157_17_66504758 -.->|"ε"|eNFA157_18_61671918
eNFA157_18_61671918 -->|"M"|eNFA157_19_18176357
eNFA157_19_18176357 -.->|"ε"|eNFA157_20_29369493
eNFA157_20_29369493 -->|"S"|eNFA157_21_62998845
eNFA157_21_62998845 -.->|"ε"|eNFA157_22_30118695
eNFA157_22_30118695 -->|"A"|eNFA157_23_2632805
eNFA157_23_2632805 -.->|"ε"|eNFA157_24_23695246
eNFA157_24_23695246 -->|"r"|eNFA157_25_11930629
eNFA157_25_11930629 -.->|"ε"|eNFA157_26_40266802
eNFA157_26_40266802 -->|"r"|eNFA157_27_26856902
eNFA157_27_26856902 -.->|"ε"|eNFA157_28_40385530
eNFA157_28_40385530 -->|"a"|eNFA157_29_27925455
eNFA157_29_27925455 -.->|"ε"|eNFA157_30_50002511
eNFA157_30_50002511 -->|"y"|eNFA157_31_47369417
eNFA157_31_47369417 -.->|"ε"|eNFA157_33_23671576
eNFA157_33_23671576 -.->|"ε"|eNFA157_34_11717596
eNFA157_34_11717596 -.->|"ε"|eNFA157_35_38349502
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
eNFA157_32_9601199[["εNFA157-32 regex start"]]
eNFA157_0_19301928[["εNFA157-0 char{1, 1}"]]
eNFA157_1_39499626[["εNFA157-1 char[1]"]]
eNFA157_2_19952318[["εNFA157-2 char{1, 1}"]]
eNFA157_3_45353142[["εNFA157-3 char[1]"]]
eNFA157_4_5525098[["εNFA157-4 char{1, 1}"]]
eNFA157_5_49725882[["εNFA157-5 char[1]"]]
eNFA157_6_44879761[["εNFA157-6 char{1, 1}"]]
eNFA157_7_1264671[["εNFA157-7 char[1]"]]
eNFA157_8_11382045[["εNFA157-8 char{1, 1}"]]
eNFA157_9_35329549[["εNFA157-9 char[1]"]]
eNFA157_10_49530486[["εNFA157-10 char{1, 1}"]]
eNFA157_11_43121195[["εNFA157-11 char[1]"]]
eNFA157_12_52546435[["εNFA157-12 char{1, 1}"]]
eNFA157_13_3155873[["εNFA157-13 char[1]"]]
eNFA157_14_28402861[["εNFA157-14 char{1, 1}"]]
eNFA157_15_54299160[["εNFA157-15 char[1]"]]
eNFA157_16_18930395[["εNFA157-16 char{1, 1}"]]
eNFA157_17_36155831[["εNFA157-17 char[1]"]]
eNFA157_18_56967030[["εNFA157-18 char{1, 1}"]]
eNFA157_19_42941223[["εNFA157-19 char[1]"]]
eNFA157_20_50926693[["εNFA157-20 char{1, 1}"]]
eNFA157_21_55687056[["εNFA157-21 char[1]"]]
eNFA157_22_31421457[["εNFA157-22 char{1, 1}"]]
eNFA157_23_14357657[["εNFA157-23 char[1]"]]
eNFA157_24_62110049[["εNFA157-24 char{1, 1}"]]
eNFA157_25_22119530[["εNFA157-25 char[1]"]]
eNFA157_26_64858045[["εNFA157-26 char{1, 1}"]]
eNFA157_27_46851500[["εNFA157-27 char[1]"]]
eNFA157_28_19010318[["εNFA157-28 char{1, 1}"]]
eNFA157_29_36875142[["εNFA157-29 char[1]"]]
eNFA157_30_63440828[["εNFA157-30 char{1, 1}"]]
eNFA157_31_34096545[\"εNFA157-31 char[1]"/]
eNFA157_33_38433454[\"εNFA157-33 regex end"/]
eNFA157_34_10356773[\"εNFA157-34 post-regex start"/]
eNFA157_35_26102093[\"εNFA157-35 post-regex end"/]
eNFA157_32_9601199 -.->|"ε"|eNFA157_0_19301928
eNFA157_32_9601199 -->|"s"|eNFA157_1_39499626
eNFA157_0_19301928 -->|"s"|eNFA157_1_39499626
eNFA157_1_39499626 -.->|"ε"|eNFA157_2_19952318
eNFA157_1_39499626 -->|"a"|eNFA157_3_45353142
eNFA157_2_19952318 -->|"a"|eNFA157_3_45353142
eNFA157_3_45353142 -.->|"ε"|eNFA157_4_5525098
eNFA157_3_45353142 -->|"m"|eNFA157_5_49725882
eNFA157_4_5525098 -->|"m"|eNFA157_5_49725882
eNFA157_5_49725882 -.->|"ε"|eNFA157_6_44879761
eNFA157_5_49725882 -->|"p"|eNFA157_7_1264671
eNFA157_6_44879761 -->|"p"|eNFA157_7_1264671
eNFA157_7_1264671 -.->|"ε"|eNFA157_8_11382045
eNFA157_7_1264671 -->|"l"|eNFA157_9_35329549
eNFA157_8_11382045 -->|"l"|eNFA157_9_35329549
eNFA157_9_35329549 -.->|"ε"|eNFA157_10_49530486
eNFA157_9_35329549 -->|"e"|eNFA157_11_43121195
eNFA157_10_49530486 -->|"e"|eNFA157_11_43121195
eNFA157_11_43121195 -.->|"ε"|eNFA157_12_52546435
eNFA157_11_43121195 -->|"r"|eNFA157_13_3155873
eNFA157_12_52546435 -->|"r"|eNFA157_13_3155873
eNFA157_13_3155873 -.->|"ε"|eNFA157_14_28402861
eNFA157_13_3155873 -->|"2"|eNFA157_15_54299160
eNFA157_14_28402861 -->|"2"|eNFA157_15_54299160
eNFA157_15_54299160 -.->|"ε"|eNFA157_16_18930395
eNFA157_15_54299160 -->|"D"|eNFA157_17_36155831
eNFA157_16_18930395 -->|"D"|eNFA157_17_36155831
eNFA157_17_36155831 -.->|"ε"|eNFA157_18_56967030
eNFA157_17_36155831 -->|"M"|eNFA157_19_42941223
eNFA157_18_56967030 -->|"M"|eNFA157_19_42941223
eNFA157_19_42941223 -.->|"ε"|eNFA157_20_50926693
eNFA157_19_42941223 -->|"S"|eNFA157_21_55687056
eNFA157_20_50926693 -->|"S"|eNFA157_21_55687056
eNFA157_21_55687056 -.->|"ε"|eNFA157_22_31421457
eNFA157_21_55687056 -->|"A"|eNFA157_23_14357657
eNFA157_22_31421457 -->|"A"|eNFA157_23_14357657
eNFA157_23_14357657 -.->|"ε"|eNFA157_24_62110049
eNFA157_23_14357657 -->|"r"|eNFA157_25_22119530
eNFA157_24_62110049 -->|"r"|eNFA157_25_22119530
eNFA157_25_22119530 -.->|"ε"|eNFA157_26_64858045
eNFA157_25_22119530 -->|"r"|eNFA157_27_46851500
eNFA157_26_64858045 -->|"r"|eNFA157_27_46851500
eNFA157_27_46851500 -.->|"ε"|eNFA157_28_19010318
eNFA157_27_46851500 -->|"a"|eNFA157_29_36875142
eNFA157_28_19010318 -->|"a"|eNFA157_29_36875142
eNFA157_29_36875142 -.->|"ε"|eNFA157_30_63440828
eNFA157_29_36875142 -->|"y"|eNFA157_31_34096545
eNFA157_30_63440828 -->|"y"|eNFA157_31_34096545
eNFA157_31_34096545 -.->|"ε"|eNFA157_33_38433454
eNFA157_31_34096545 -.->|"ε"|eNFA157_34_10356773
eNFA157_31_34096545 -.->|"ε"|eNFA157_35_26102093
eNFA157_33_38433454 -.->|"ε"|eNFA157_34_10356773
eNFA157_33_38433454 -.->|"ε"|eNFA157_35_26102093
eNFA157_34_10356773 -.->|"ε"|eNFA157_35_26102093
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
NFA157_32_33592248("NFA157-32 regex start")
NFA157_1_33894784("NFA157-1 char[1]")
NFA157_3_36617605("NFA157-3 char[1]")
NFA157_5_61122992("NFA157-5 char[1]")
NFA157_7_13236018("NFA157-7 char[1]")
NFA157_9_52015300("NFA157-9 char[1]")
NFA157_11_65484519("NFA157-11 char[1]")
NFA157_13_52489765("NFA157-13 char[1]")
NFA157_15_2645837("NFA157-15 char[1]")
NFA157_17_23812538("NFA157-17 char[1]")
NFA157_19_12986251("NFA157-19 char[1]")
NFA157_21_49767403("NFA157-21 char[1]")
NFA157_23_45253450("NFA157-23 char[1]")
NFA157_25_4627874("NFA157-25 char[1]")
NFA157_27_41650866("NFA157-27 char[1]")
NFA157_29_39313476("NFA157-29 char[1]")
NFA157_31_18276970[\"NFA157-31 char[1]"/]
NFA157_32_33592248 -->|"s"|NFA157_1_33894784
NFA157_1_33894784 -->|"a"|NFA157_3_36617605
NFA157_3_36617605 -->|"m"|NFA157_5_61122992
NFA157_5_61122992 -->|"p"|NFA157_7_13236018
NFA157_7_13236018 -->|"l"|NFA157_9_52015300
NFA157_9_52015300 -->|"e"|NFA157_11_65484519
NFA157_11_65484519 -->|"r"|NFA157_13_52489765
NFA157_13_52489765 -->|"2"|NFA157_15_2645837
NFA157_15_2645837 -->|"D"|NFA157_17_23812538
NFA157_17_23812538 -->|"M"|NFA157_19_12986251
NFA157_19_12986251 -->|"S"|NFA157_21_49767403
NFA157_21_49767403 -->|"A"|NFA157_23_45253450
NFA157_23_45253450 -->|"r"|NFA157_25_4627874
NFA157_25_4627874 -->|"r"|NFA157_27_41650866
NFA157_27_41650866 -->|"a"|NFA157_29_39313476
NFA157_29_39313476 -->|"y"|NFA157_31_18276970
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
subgraph DFA0_1365399421["DFA0 regex start"]
NFA157_32_33592248_0("NFA157-32 regex start")
end
subgraph DFA1_68610551["DFA1 {1}"]
NFA157_1_33894784_1("NFA157-1 char[1]")
end
subgraph DFA2_651474672["DFA2 {1}"]
NFA157_3_36617605_2("NFA157-3 char[1]")
end
subgraph DFA3_-509538006["DFA3 {1}"]
NFA157_5_61122992_3("NFA157-5 char[1]")
end
subgraph DFA4_1378795827["DFA4 {1}"]
NFA157_7_13236018_4("NFA157-7 char[1]")
end
subgraph DFA5_1933639670["DFA5 {1}"]
NFA157_9_52015300_5("NFA157-9 char[1]")
end
subgraph DFA6_1504843368["DFA6 {1}"]
NFA157_11_65484519_6("NFA157-11 char[1]")
end
subgraph DFA7_1316916988["DFA7 {1}"]
NFA157_13_52489765_7("NFA157-13 char[1]")
end
subgraph DFA8_212399576["DFA8 {1}"]
NFA157_15_2645837_8("NFA157-15 char[1]")
end
subgraph DFA9_-1293652480["DFA9 {1}"]
NFA157_17_23812538_9("NFA157-17 char[1]")
end
subgraph DFA10_-473595085["DFA10 {1}"]
NFA157_19_12986251_10("NFA157-19 char[1]")
end
subgraph DFA11_161579562["DFA11 {1}"]
NFA157_21_49767403_11("NFA157-21 char[1]")
end
subgraph DFA12_2015090705["DFA12 {1}"]
NFA157_23_45253450_12("NFA157-23 char[1]")
end
subgraph DFA13_-2116311317["DFA13 {1}"]
NFA157_25_4627874_13("NFA157-25 char[1]")
end
subgraph DFA14_67289702["DFA14 {1}"]
NFA157_27_41650866_14("NFA157-27 char[1]")
end
subgraph DFA15_-1639029456["DFA15 {1}"]
NFA157_29_39313476_15("NFA157-29 char[1]")
end
subgraph DFA16_1523178721["DFA16 {1}"]
NFA157_31_18276970_16[\"NFA157-31 char[1]"/]
end
DFA0_1365399421 -->|"s"|DFA1_68610551
DFA1_68610551 -->|"a"|DFA2_651474672
DFA2_651474672 -->|"m"|DFA3_-509538006
DFA3_-509538006 -->|"p"|DFA4_1378795827
DFA4_1378795827 -->|"l"|DFA5_1933639670
DFA5_1933639670 -->|"e"|DFA6_1504843368
DFA6_1504843368 -->|"r"|DFA7_1316916988
DFA7_1316916988 -->|"2"|DFA8_212399576
DFA8_212399576 -->|"D"|DFA9_-1293652480
DFA9_-1293652480 -->|"M"|DFA10_-473595085
DFA10_-473595085 -->|"S"|DFA11_161579562
DFA11_161579562 -->|"A"|DFA12_2015090705
DFA12_2015090705 -->|"r"|DFA13_-2116311317
DFA13_-2116311317 -->|"r"|DFA14_67289702
DFA14_67289702 -->|"a"|DFA15_-1639029456
DFA15_-1639029456 -->|"y"|DFA16_1523178721
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
DFA0_1365399421{{"DFA0 regex start"}}
DFA1_68610551{{"DFA1 {1}"}}
DFA2_651474672{{"DFA2 {1}"}}
DFA3_-509538006{{"DFA3 {1}"}}
DFA4_1378795827{{"DFA4 {1}"}}
DFA5_1933639670{{"DFA5 {1}"}}
DFA6_1504843368{{"DFA6 {1}"}}
DFA7_1316916988{{"DFA7 {1}"}}
DFA8_212399576{{"DFA8 {1}"}}
DFA9_-1293652480{{"DFA9 {1}"}}
DFA10_-473595085{{"DFA10 {1}"}}
DFA11_161579562{{"DFA11 {1}"}}
DFA12_2015090705{{"DFA12 {1}"}}
DFA13_-2116311317{{"DFA13 {1}"}}
DFA14_67289702{{"DFA14 {1}"}}
DFA15_-1639029456{{"DFA15 {1}"}}
DFA16_1523178721[\"DFA16 {1}"/]
DFA0_1365399421 -->|"s"|DFA1_68610551
DFA1_68610551 -->|"a"|DFA2_651474672
DFA2_651474672 -->|"m"|DFA3_-509538006
DFA3_-509538006 -->|"p"|DFA4_1378795827
DFA4_1378795827 -->|"l"|DFA5_1933639670
DFA5_1933639670 -->|"e"|DFA6_1504843368
DFA6_1504843368 -->|"r"|DFA7_1316916988
DFA7_1316916988 -->|"2"|DFA8_212399576
DFA8_212399576 -->|"D"|DFA9_-1293652480
DFA9_-1293652480 -->|"M"|DFA10_-473595085
DFA10_-473595085 -->|"S"|DFA11_161579562
DFA11_161579562 -->|"A"|DFA12_2015090705
DFA12_2015090705 -->|"r"|DFA13_-2116311317
DFA13_-2116311317 -->|"r"|DFA14_67289702
DFA14_67289702 -->|"a"|DFA15_-1639029456
DFA15_-1639029456 -->|"y"|DFA16_1523178721
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
subgraph MiniDFA0_1154880858["MiniDFA0 {1}"]
DFA0_1365399421_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1441963350["MiniDFA1 {1}"]
DFA1_68610551_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-287109338["MiniDFA3 {1}"]
DFA2_651474672_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_557761107["MiniDFA4 {1}"]
DFA3_-509538006_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-2045949408["MiniDFA5 {1}"]
DFA4_1378795827_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1073490137["MiniDFA6 {1}"]
DFA5_1933639670_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-802676901["MiniDFA7 {1}"]
DFA6_1504843368_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_120189052["MiniDFA10 {1}"]
DFA7_1316916988_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_361608673["MiniDFA11 {1}"]
DFA8_212399576_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_-1226849837["MiniDFA12 {1}"]
DFA9_-1293652480_9{{"DFA9 {1}"}}
end
subgraph MiniDFA13_1938137147["MiniDFA13 {1}"]
DFA10_-473595085_10{{"DFA10 {1}"}}
end
subgraph MiniDFA14_1135984626["MiniDFA14 {1}"]
DFA11_161579562_11{{"DFA11 {1}"}}
end
subgraph MiniDFA8_-569629004["MiniDFA8 {1}"]
DFA12_2015090705_12{{"DFA12 {1}"}}
end
subgraph MiniDFA9_827440619["MiniDFA9 {1}"]
DFA13_-2116311317_13{{"DFA13 {1}"}}
end
subgraph MiniDFA2_1562568444["MiniDFA2 {1}"]
DFA14_67289702_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_241322487["MiniDFA15 {1}"]
DFA15_-1639029456_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_2116871627["MiniDFA16 {1}"]
DFA16_1523178721_16[\"DFA16 {1}"/]
end
MiniDFA0_1154880858 -->|"s"|MiniDFA1_-1441963350
MiniDFA1_-1441963350 -->|"a"|MiniDFA3_-287109338
MiniDFA3_-287109338 -->|"m"|MiniDFA4_557761107
MiniDFA4_557761107 -->|"p"|MiniDFA5_-2045949408
MiniDFA5_-2045949408 -->|"l"|MiniDFA6_-1073490137
MiniDFA6_-1073490137 -->|"e"|MiniDFA7_-802676901
MiniDFA7_-802676901 -->|"r"|MiniDFA10_120189052
MiniDFA10_120189052 -->|"2"|MiniDFA11_361608673
MiniDFA11_361608673 -->|"D"|MiniDFA12_-1226849837
MiniDFA12_-1226849837 -->|"M"|MiniDFA13_1938137147
MiniDFA13_1938137147 -->|"S"|MiniDFA14_1135984626
MiniDFA14_1135984626 -->|"A"|MiniDFA8_-569629004
MiniDFA8_-569629004 -->|"r"|MiniDFA9_827440619
MiniDFA9_827440619 -->|"r"|MiniDFA2_1562568444
MiniDFA2_1562568444 -->|"a"|MiniDFA15_241322487
MiniDFA15_241322487 -->|"y"|MiniDFA16_2116871627
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
MiniDFA0_1154880858(["MiniDFA0 {1}"])
MiniDFA1_-1441963350(["MiniDFA1 {1}"])
MiniDFA3_-287109338(["MiniDFA3 {1}"])
MiniDFA4_557761107(["MiniDFA4 {1}"])
MiniDFA5_-2045949408(["MiniDFA5 {1}"])
MiniDFA6_-1073490137(["MiniDFA6 {1}"])
MiniDFA7_-802676901(["MiniDFA7 {1}"])
MiniDFA10_120189052(["MiniDFA10 {1}"])
MiniDFA11_361608673(["MiniDFA11 {1}"])
MiniDFA12_-1226849837(["MiniDFA12 {1}"])
MiniDFA13_1938137147(["MiniDFA13 {1}"])
MiniDFA14_1135984626(["MiniDFA14 {1}"])
MiniDFA8_-569629004(["MiniDFA8 {1}"])
MiniDFA9_827440619(["MiniDFA9 {1}"])
MiniDFA2_1562568444(["MiniDFA2 {1}"])
MiniDFA15_241322487(["MiniDFA15 {1}"])
MiniDFA16_2116871627[\"MiniDFA16 {1}"/]
MiniDFA0_1154880858 -->|"s"|MiniDFA1_-1441963350
MiniDFA1_-1441963350 -->|"a"|MiniDFA3_-287109338
MiniDFA3_-287109338 -->|"m"|MiniDFA4_557761107
MiniDFA4_557761107 -->|"p"|MiniDFA5_-2045949408
MiniDFA5_-2045949408 -->|"l"|MiniDFA6_-1073490137
MiniDFA6_-1073490137 -->|"e"|MiniDFA7_-802676901
MiniDFA7_-802676901 -->|"r"|MiniDFA10_120189052
MiniDFA10_120189052 -->|"2"|MiniDFA11_361608673
MiniDFA11_361608673 -->|"D"|MiniDFA12_-1226849837
MiniDFA12_-1226849837 -->|"M"|MiniDFA13_1938137147
MiniDFA13_1938137147 -->|"S"|MiniDFA14_1135984626
MiniDFA14_1135984626 -->|"A"|MiniDFA8_-569629004
MiniDFA8_-569629004 -->|"r"|MiniDFA9_827440619
MiniDFA9_827440619 -->|"r"|MiniDFA2_1562568444
MiniDFA2_1562568444 -->|"a"|MiniDFA15_241322487
MiniDFA15_241322487 -->|"y"|MiniDFA16_2116871627
```
-------------------------------
