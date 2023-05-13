# 'usampler2DRect'

pattern: `usampler2DRect`

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
eNFA150_28_762549[["εNFA150-28 regex start"]]
eNFA150_0_6862947[["εNFA150-0 char{1, 1}"]]
eNFA150_1_61766529[["εNFA150-1 char[1]"]]
eNFA150_2_19027857[["εNFA150-2 char{1, 1}"]]
eNFA150_3_37032986[["εNFA150-3 char[1]"]]
eNFA150_4_64861423[["εNFA150-4 char{1, 1}"]]
eNFA150_5_46881895[["εNFA150-5 char[1]"]]
eNFA150_6_19283877[["εNFA150-6 char{1, 1}"]]
eNFA150_7_39337169[["εNFA150-7 char[1]"]]
eNFA150_8_18490204[["εNFA150-8 char{1, 1}"]]
eNFA150_9_32194111[["εNFA150-9 char[1]"]]
eNFA150_10_21311547[["εNFA150-10 char{1, 1}"]]
eNFA150_11_57586202[["εNFA150-11 char[1]"]]
eNFA150_12_48513771[["εNFA150-12 char{1, 1}"]]
eNFA150_13_33970761[["εNFA150-13 char[1]"]]
eNFA150_14_37301396[["εNFA150-14 char{1, 1}"]]
eNFA150_15_168245[["εNFA150-15 char[1]"]]
eNFA150_16_1514205[["εNFA150-16 char{1, 1}"]]
eNFA150_17_13627845[["εNFA150-17 char[1]"]]
eNFA150_18_55541742[["εNFA150-18 char{1, 1}"]]
eNFA150_19_30113633[["εNFA150-19 char[1]"]]
eNFA150_20_2587248[["εNFA150-20 char{1, 1}"]]
eNFA150_21_23285234[["εNFA150-21 char[1]"]]
eNFA150_22_8240522[["εNFA150-22 char{1, 1}"]]
eNFA150_23_7055840[["εNFA150-23 char[1]"]]
eNFA150_24_63502565[["εNFA150-24 char{1, 1}"]]
eNFA150_25_34652178[["εNFA150-25 char[1]"]]
eNFA150_26_43434153[["εNFA150-26 char{1, 1}"]]
eNFA150_27_55363057[["εNFA150-27 char[1]"]]
eNFA150_29_28505468[["εNFA150-29 regex end"]]
eNFA150_30_55222628[["εNFA150-30 post-regex start"]]
eNFA150_31_27241609[\"εNFA150-31 post-regex end"/]
eNFA150_28_762549 -.->|"ε"|eNFA150_0_6862947
eNFA150_0_6862947 -->|"u"|eNFA150_1_61766529
eNFA150_1_61766529 -.->|"ε"|eNFA150_2_19027857
eNFA150_2_19027857 -->|"s"|eNFA150_3_37032986
eNFA150_3_37032986 -.->|"ε"|eNFA150_4_64861423
eNFA150_4_64861423 -->|"a"|eNFA150_5_46881895
eNFA150_5_46881895 -.->|"ε"|eNFA150_6_19283877
eNFA150_6_19283877 -->|"m"|eNFA150_7_39337169
eNFA150_7_39337169 -.->|"ε"|eNFA150_8_18490204
eNFA150_8_18490204 -->|"p"|eNFA150_9_32194111
eNFA150_9_32194111 -.->|"ε"|eNFA150_10_21311547
eNFA150_10_21311547 -->|"l"|eNFA150_11_57586202
eNFA150_11_57586202 -.->|"ε"|eNFA150_12_48513771
eNFA150_12_48513771 -->|"e"|eNFA150_13_33970761
eNFA150_13_33970761 -.->|"ε"|eNFA150_14_37301396
eNFA150_14_37301396 -->|"r"|eNFA150_15_168245
eNFA150_15_168245 -.->|"ε"|eNFA150_16_1514205
eNFA150_16_1514205 -->|"2"|eNFA150_17_13627845
eNFA150_17_13627845 -.->|"ε"|eNFA150_18_55541742
eNFA150_18_55541742 -->|"D"|eNFA150_19_30113633
eNFA150_19_30113633 -.->|"ε"|eNFA150_20_2587248
eNFA150_20_2587248 -->|"R"|eNFA150_21_23285234
eNFA150_21_23285234 -.->|"ε"|eNFA150_22_8240522
eNFA150_22_8240522 -->|"e"|eNFA150_23_7055840
eNFA150_23_7055840 -.->|"ε"|eNFA150_24_63502565
eNFA150_24_63502565 -->|"c"|eNFA150_25_34652178
eNFA150_25_34652178 -.->|"ε"|eNFA150_26_43434153
eNFA150_26_43434153 -->|"t"|eNFA150_27_55363057
eNFA150_27_55363057 -.->|"ε"|eNFA150_29_28505468
eNFA150_29_28505468 -.->|"ε"|eNFA150_30_55222628
eNFA150_30_55222628 -.->|"ε"|eNFA150_31_27241609
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
eNFA150_28_43847892[["εNFA150-28 regex start"]]
eNFA150_0_59086710[["εNFA150-0 char{1, 1}"]]
eNFA150_1_62018344[["εNFA150-1 char[1]"]]
eNFA150_2_21294187[["εNFA150-2 char{1, 1}"]]
eNFA150_3_57429961[["εNFA150-3 char[1]"]]
eNFA150_4_47107601[["εNFA150-4 char{1, 1}"]]
eNFA150_5_21315230[["εNFA150-5 char[1]"]]
eNFA150_6_57619343[["εNFA150-6 char{1, 1}"]]
eNFA150_7_48812047[["εNFA150-7 char[1]"]]
eNFA150_8_36655246[["εNFA150-8 char{1, 1}"]]
eNFA150_9_61461766[["εNFA150-9 char[1]"]]
eNFA150_10_16284982[["εNFA150-10 char{1, 1}"]]
eNFA150_11_12347112[["εNFA150-11 char[1]"]]
eNFA150_12_44015150[["εNFA150-12 char{1, 1}"]]
eNFA150_13_60592031[["εNFA150-13 char[1]"]]
eNFA150_14_8457374[["εNFA150-14 char{1, 1}"]]
eNFA150_15_9007507[["εNFA150-15 char[1]"]]
eNFA150_16_13958703[["εNFA150-16 char{1, 1}"]]
eNFA150_17_58519467[["εNFA150-17 char[1]"]]
eNFA150_18_56913160[["εNFA150-18 char{1, 1}"]]
eNFA150_19_42456400[["εNFA150-19 char[1]"]]
eNFA150_20_46563282[["εNFA150-20 char{1, 1}"]]
eNFA150_21_16416361[["εNFA150-21 char[1]"]]
eNFA150_22_13529525[["εNFA150-22 char{1, 1}"]]
eNFA150_23_54656863[["εNFA150-23 char[1]"]]
eNFA150_24_22149720[["εNFA150-24 char{1, 1}"]]
eNFA150_25_65129753[["εNFA150-25 char[1]"]]
eNFA150_26_49296867[["εNFA150-26 char{1, 1}"]]
eNFA150_27_41018623[\"εNFA150-27 char[1]"/]
eNFA150_29_33623295[\"εNFA150-29 regex end"/]
eNFA150_30_34174203[\"εNFA150-30 post-regex start"/]
eNFA150_31_39132371[\"εNFA150-31 post-regex end"/]
eNFA150_28_43847892 -.->|"ε"|eNFA150_0_59086710
eNFA150_28_43847892 -->|"u"|eNFA150_1_62018344
eNFA150_0_59086710 -->|"u"|eNFA150_1_62018344
eNFA150_1_62018344 -.->|"ε"|eNFA150_2_21294187
eNFA150_1_62018344 -->|"s"|eNFA150_3_57429961
eNFA150_2_21294187 -->|"s"|eNFA150_3_57429961
eNFA150_3_57429961 -.->|"ε"|eNFA150_4_47107601
eNFA150_3_57429961 -->|"a"|eNFA150_5_21315230
eNFA150_4_47107601 -->|"a"|eNFA150_5_21315230
eNFA150_5_21315230 -.->|"ε"|eNFA150_6_57619343
eNFA150_5_21315230 -->|"m"|eNFA150_7_48812047
eNFA150_6_57619343 -->|"m"|eNFA150_7_48812047
eNFA150_7_48812047 -.->|"ε"|eNFA150_8_36655246
eNFA150_7_48812047 -->|"p"|eNFA150_9_61461766
eNFA150_8_36655246 -->|"p"|eNFA150_9_61461766
eNFA150_9_61461766 -.->|"ε"|eNFA150_10_16284982
eNFA150_9_61461766 -->|"l"|eNFA150_11_12347112
eNFA150_10_16284982 -->|"l"|eNFA150_11_12347112
eNFA150_11_12347112 -.->|"ε"|eNFA150_12_44015150
eNFA150_11_12347112 -->|"e"|eNFA150_13_60592031
eNFA150_12_44015150 -->|"e"|eNFA150_13_60592031
eNFA150_13_60592031 -.->|"ε"|eNFA150_14_8457374
eNFA150_13_60592031 -->|"r"|eNFA150_15_9007507
eNFA150_14_8457374 -->|"r"|eNFA150_15_9007507
eNFA150_15_9007507 -.->|"ε"|eNFA150_16_13958703
eNFA150_15_9007507 -->|"2"|eNFA150_17_58519467
eNFA150_16_13958703 -->|"2"|eNFA150_17_58519467
eNFA150_17_58519467 -.->|"ε"|eNFA150_18_56913160
eNFA150_17_58519467 -->|"D"|eNFA150_19_42456400
eNFA150_18_56913160 -->|"D"|eNFA150_19_42456400
eNFA150_19_42456400 -.->|"ε"|eNFA150_20_46563282
eNFA150_19_42456400 -->|"R"|eNFA150_21_16416361
eNFA150_20_46563282 -->|"R"|eNFA150_21_16416361
eNFA150_21_16416361 -.->|"ε"|eNFA150_22_13529525
eNFA150_21_16416361 -->|"e"|eNFA150_23_54656863
eNFA150_22_13529525 -->|"e"|eNFA150_23_54656863
eNFA150_23_54656863 -.->|"ε"|eNFA150_24_22149720
eNFA150_23_54656863 -->|"c"|eNFA150_25_65129753
eNFA150_24_22149720 -->|"c"|eNFA150_25_65129753
eNFA150_25_65129753 -.->|"ε"|eNFA150_26_49296867
eNFA150_25_65129753 -->|"t"|eNFA150_27_41018623
eNFA150_26_49296867 -->|"t"|eNFA150_27_41018623
eNFA150_27_41018623 -.->|"ε"|eNFA150_29_33623295
eNFA150_27_41018623 -.->|"ε"|eNFA150_30_34174203
eNFA150_27_41018623 -.->|"ε"|eNFA150_31_39132371
eNFA150_29_33623295 -.->|"ε"|eNFA150_30_34174203
eNFA150_29_33623295 -.->|"ε"|eNFA150_31_39132371
eNFA150_30_34174203 -.->|"ε"|eNFA150_31_39132371
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
NFA150_28_16647026("NFA150-28 regex start")
NFA150_1_15605512("NFA150-1 char[1]")
NFA150_3_6231886("NFA150-3 char[1]")
NFA150_5_56086982("NFA150-5 char[1]")
NFA150_7_35020791("NFA150-7 char[1]")
NFA150_9_46751668("NFA150-9 char[1]")
NFA150_11_18111828("NFA150-11 char[1]")
NFA150_13_28788730("NFA150-13 char[1]")
NFA150_15_57771982("NFA150-15 char[1]")
NFA150_17_50185793("NFA150-17 char[1]")
NFA150_19_49018956("NFA150-19 char[1]")
NFA150_21_38517424("NFA150-21 char[1]")
NFA150_23_11112503("NFA150-23 char[1]")
NFA150_25_32903664("NFA150-25 char[1]")
NFA150_27_27697526[\"NFA150-27 char[1]"/]
NFA150_28_16647026 -->|"u"|NFA150_1_15605512
NFA150_1_15605512 -->|"s"|NFA150_3_6231886
NFA150_3_6231886 -->|"a"|NFA150_5_56086982
NFA150_5_56086982 -->|"m"|NFA150_7_35020791
NFA150_7_35020791 -->|"p"|NFA150_9_46751668
NFA150_9_46751668 -->|"l"|NFA150_11_18111828
NFA150_11_18111828 -->|"e"|NFA150_13_28788730
NFA150_13_28788730 -->|"r"|NFA150_15_57771982
NFA150_15_57771982 -->|"2"|NFA150_17_50185793
NFA150_17_50185793 -->|"D"|NFA150_19_49018956
NFA150_19_49018956 -->|"R"|NFA150_21_38517424
NFA150_21_38517424 -->|"e"|NFA150_23_11112503
NFA150_23_11112503 -->|"c"|NFA150_25_32903664
NFA150_25_32903664 -->|"t"|NFA150_27_27697526
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
subgraph DFA0_-1055265518["DFA0 regex start"]
NFA150_28_16647026_0("NFA150-28 regex start")
end
subgraph DFA1_-988345285["DFA1 {1}"]
NFA150_1_15605512_1("NFA150-1 char[1]")
end
subgraph DFA2_2069944645["DFA2 {1}"]
NFA150_3_6231886_2("NFA150-3 char[1]")
end
subgraph DFA3_1273808606["DFA3 {1}"]
NFA150_5_56086982_3("NFA150-5 char[1]")
end
subgraph DFA4_-1045471554["DFA4 {1}"]
NFA150_7_35020791_4("NFA150-7 char[1]")
end
subgraph DFA5_1591205675["DFA5 {1}"]
NFA150_9_46751668_5("NFA150-9 char[1]")
end
subgraph DFA6_1631621168["DFA6 {1}"]
NFA150_11_18111828_6("NFA150-11 char[1]")
end
subgraph DFA7_1977290714["DFA7 {1}"]
NFA150_13_28788730_7("NFA150-13 char[1]")
end
subgraph DFA8_-1247053563["DFA8 {1}"]
NFA150_15_57771982_8("NFA150-15 char[1]")
end
subgraph DFA9_36979037["DFA9 {1}"]
NFA150_17_50185793_9("NFA150-17 char[1]")
end
subgraph DFA10_-18616855["DFA10 {1}"]
NFA150_19_49018956_10("NFA150-19 char[1]")
end
subgraph DFA11_976660286["DFA11 {1}"]
NFA150_21_38517424_11("NFA150-21 char[1]")
end
subgraph DFA12_-232824940["DFA12 {1}"]
NFA150_23_11112503_12("NFA150-23 char[1]")
end
subgraph DFA13_825649552["DFA13 {1}"]
NFA150_25_32903664_13("NFA150-25 char[1]")
end
subgraph DFA14_583887123["DFA14 {1}"]
NFA150_27_27697526_14[\"NFA150-27 char[1]"/]
end
DFA0_-1055265518 -->|"u"|DFA1_-988345285
DFA1_-988345285 -->|"s"|DFA2_2069944645
DFA2_2069944645 -->|"a"|DFA3_1273808606
DFA3_1273808606 -->|"m"|DFA4_-1045471554
DFA4_-1045471554 -->|"p"|DFA5_1591205675
DFA5_1591205675 -->|"l"|DFA6_1631621168
DFA6_1631621168 -->|"e"|DFA7_1977290714
DFA7_1977290714 -->|"r"|DFA8_-1247053563
DFA8_-1247053563 -->|"2"|DFA9_36979037
DFA9_36979037 -->|"D"|DFA10_-18616855
DFA10_-18616855 -->|"R"|DFA11_976660286
DFA11_976660286 -->|"e"|DFA12_-232824940
DFA12_-232824940 -->|"c"|DFA13_825649552
DFA13_825649552 -->|"t"|DFA14_583887123
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
DFA0_-1055265518{{"DFA0 regex start"}}
DFA1_-988345285{{"DFA1 {1}"}}
DFA2_2069944645{{"DFA2 {1}"}}
DFA3_1273808606{{"DFA3 {1}"}}
DFA4_-1045471554{{"DFA4 {1}"}}
DFA5_1591205675{{"DFA5 {1}"}}
DFA6_1631621168{{"DFA6 {1}"}}
DFA7_1977290714{{"DFA7 {1}"}}
DFA8_-1247053563{{"DFA8 {1}"}}
DFA9_36979037{{"DFA9 {1}"}}
DFA10_-18616855{{"DFA10 {1}"}}
DFA11_976660286{{"DFA11 {1}"}}
DFA12_-232824940{{"DFA12 {1}"}}
DFA13_825649552{{"DFA13 {1}"}}
DFA14_583887123[\"DFA14 {1}"/]
DFA0_-1055265518 -->|"u"|DFA1_-988345285
DFA1_-988345285 -->|"s"|DFA2_2069944645
DFA2_2069944645 -->|"a"|DFA3_1273808606
DFA3_1273808606 -->|"m"|DFA4_-1045471554
DFA4_-1045471554 -->|"p"|DFA5_1591205675
DFA5_1591205675 -->|"l"|DFA6_1631621168
DFA6_1631621168 -->|"e"|DFA7_1977290714
DFA7_1977290714 -->|"r"|DFA8_-1247053563
DFA8_-1247053563 -->|"2"|DFA9_36979037
DFA9_36979037 -->|"D"|DFA10_-18616855
DFA10_-18616855 -->|"R"|DFA11_976660286
DFA11_976660286 -->|"e"|DFA12_-232824940
DFA12_-232824940 -->|"c"|DFA13_825649552
DFA13_825649552 -->|"t"|DFA14_583887123
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
subgraph MiniDFA0_-218363955["MiniDFA0 {1}"]
DFA0_-1055265518_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1850054061["MiniDFA1 {1}"]
DFA1_-988345285_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1204018555["MiniDFA2 {1}"]
DFA2_2069944645_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1675006459["MiniDFA3 {1}"]
DFA3_1273808606_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1397666905["MiniDFA4 {1}"]
DFA4_-1045471554_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1449640302["MiniDFA5 {1}"]
DFA5_1591205675_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_2133019003["MiniDFA6 {1}"]
DFA6_1631621168_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1180366731["MiniDFA8 {1}"]
DFA7_1977290714_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1649723845["MiniDFA9 {1}"]
DFA8_-1247053563_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-1083843035["MiniDFA10 {1}"]
DFA9_36979037_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_1923438997["MiniDFA11 {1}"]
DFA10_-18616855_10{{"DFA10 {1}"}}
end
subgraph MiniDFA7_-1095055279["MiniDFA7 {1}"]
DFA11_976660286_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1447298027["MiniDFA12 {1}"]
DFA12_-232824940_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_206412132["MiniDFA13 {1}"]
DFA13_825649552_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1256464038["MiniDFA14 {1}"]
DFA14_583887123_14[\"DFA14 {1}"/]
end
MiniDFA0_-218363955 -->|"u"|MiniDFA1_-1850054061
MiniDFA1_-1850054061 -->|"s"|MiniDFA2_-1204018555
MiniDFA2_-1204018555 -->|"a"|MiniDFA3_1675006459
MiniDFA3_1675006459 -->|"m"|MiniDFA4_-1397666905
MiniDFA4_-1397666905 -->|"p"|MiniDFA5_-1449640302
MiniDFA5_-1449640302 -->|"l"|MiniDFA6_2133019003
MiniDFA6_2133019003 -->|"e"|MiniDFA8_1180366731
MiniDFA8_1180366731 -->|"r"|MiniDFA9_-1649723845
MiniDFA9_-1649723845 -->|"2"|MiniDFA10_-1083843035
MiniDFA10_-1083843035 -->|"D"|MiniDFA11_1923438997
MiniDFA11_1923438997 -->|"R"|MiniDFA7_-1095055279
MiniDFA7_-1095055279 -->|"e"|MiniDFA12_-1447298027
MiniDFA12_-1447298027 -->|"c"|MiniDFA13_206412132
MiniDFA13_206412132 -->|"t"|MiniDFA14_1256464038
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
MiniDFA0_-218363955(["MiniDFA0 {1}"])
MiniDFA1_-1850054061(["MiniDFA1 {1}"])
MiniDFA2_-1204018555(["MiniDFA2 {1}"])
MiniDFA3_1675006459(["MiniDFA3 {1}"])
MiniDFA4_-1397666905(["MiniDFA4 {1}"])
MiniDFA5_-1449640302(["MiniDFA5 {1}"])
MiniDFA6_2133019003(["MiniDFA6 {1}"])
MiniDFA8_1180366731(["MiniDFA8 {1}"])
MiniDFA9_-1649723845(["MiniDFA9 {1}"])
MiniDFA10_-1083843035(["MiniDFA10 {1}"])
MiniDFA11_1923438997(["MiniDFA11 {1}"])
MiniDFA7_-1095055279(["MiniDFA7 {1}"])
MiniDFA12_-1447298027(["MiniDFA12 {1}"])
MiniDFA13_206412132(["MiniDFA13 {1}"])
MiniDFA14_1256464038[\"MiniDFA14 {1}"/]
MiniDFA0_-218363955 -->|"u"|MiniDFA1_-1850054061
MiniDFA1_-1850054061 -->|"s"|MiniDFA2_-1204018555
MiniDFA2_-1204018555 -->|"a"|MiniDFA3_1675006459
MiniDFA3_1675006459 -->|"m"|MiniDFA4_-1397666905
MiniDFA4_-1397666905 -->|"p"|MiniDFA5_-1449640302
MiniDFA5_-1449640302 -->|"l"|MiniDFA6_2133019003
MiniDFA6_2133019003 -->|"e"|MiniDFA8_1180366731
MiniDFA8_1180366731 -->|"r"|MiniDFA9_-1649723845
MiniDFA9_-1649723845 -->|"2"|MiniDFA10_-1083843035
MiniDFA10_-1083843035 -->|"D"|MiniDFA11_1923438997
MiniDFA11_1923438997 -->|"R"|MiniDFA7_-1095055279
MiniDFA7_-1095055279 -->|"e"|MiniDFA12_-1447298027
MiniDFA12_-1447298027 -->|"c"|MiniDFA13_206412132
MiniDFA13_206412132 -->|"t"|MiniDFA14_1256464038
```
-------------------------------
