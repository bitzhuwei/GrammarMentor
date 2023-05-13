# 'samplerBuffer'

pattern: `samplerBuffer`

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
eNFA151_26_16653875[["εNFA151-26 regex start"]]
eNFA151_0_15667148[["εNFA151-0 char{1, 1}"]]
eNFA151_1_6786611[["εNFA151-1 char[1]"]]
eNFA151_2_61079504[["εNFA151-2 char{1, 1}"]]
eNFA151_3_12844628[["εNFA151-3 char[1]"]]
eNFA151_4_48492792[["εNFA151-4 char{1, 1}"]]
eNFA151_5_33781949[["εNFA151-5 char[1]"]]
eNFA151_6_35602093[["εNFA151-6 char{1, 1}"]]
eNFA151_7_51983383[["εNFA151-7 char[1]"]]
eNFA151_8_65197270[["εNFA151-8 char{1, 1}"]]
eNFA151_9_49904522[["εNFA151-9 char[1]"]]
eNFA151_10_46487516[["εNFA151-10 char{1, 1}"]]
eNFA151_11_15734461[["εNFA151-11 char[1]"]]
eNFA151_12_7392422[["εNFA151-12 char{1, 1}"]]
eNFA151_13_66531800[["εNFA151-13 char[1]"]]
eNFA151_14_61915292[["εNFA151-14 char{1, 1}"]]
eNFA151_15_20366724[["εNFA151-15 char[1]"]]
eNFA151_16_49082792[["εNFA151-16 char{1, 1}"]]
eNFA151_17_39091944[["εNFA151-17 char[1]"]]
eNFA151_18_16283183[["εNFA151-18 char{1, 1}"]]
eNFA151_19_12330925[["εNFA151-19 char[1]"]]
eNFA151_20_43869467[["εNFA151-20 char{1, 1}"]]
eNFA151_21_59280891[["εNFA151-21 char[1]"]]
eNFA151_22_63765972[["εNFA151-22 char{1, 1}"]]
eNFA151_23_37022841[["εNFA151-23 char[1]"]]
eNFA151_24_64770113[["εNFA151-24 char{1, 1}"]]
eNFA151_25_46060111[["εNFA151-25 char[1]"]]
eNFA151_27_11887819[["εNFA151-27 regex end"]]
eNFA151_28_39881510[["εNFA151-28 post-regex start"]]
eNFA151_29_23389273[\"εNFA151-29 post-regex end"/]
eNFA151_26_16653875 -.->|"ε"|eNFA151_0_15667148
eNFA151_0_15667148 -->|"s"|eNFA151_1_6786611
eNFA151_1_6786611 -.->|"ε"|eNFA151_2_61079504
eNFA151_2_61079504 -->|"a"|eNFA151_3_12844628
eNFA151_3_12844628 -.->|"ε"|eNFA151_4_48492792
eNFA151_4_48492792 -->|"m"|eNFA151_5_33781949
eNFA151_5_33781949 -.->|"ε"|eNFA151_6_35602093
eNFA151_6_35602093 -->|"p"|eNFA151_7_51983383
eNFA151_7_51983383 -.->|"ε"|eNFA151_8_65197270
eNFA151_8_65197270 -->|"l"|eNFA151_9_49904522
eNFA151_9_49904522 -.->|"ε"|eNFA151_10_46487516
eNFA151_10_46487516 -->|"e"|eNFA151_11_15734461
eNFA151_11_15734461 -.->|"ε"|eNFA151_12_7392422
eNFA151_12_7392422 -->|"r"|eNFA151_13_66531800
eNFA151_13_66531800 -.->|"ε"|eNFA151_14_61915292
eNFA151_14_61915292 -->|"B"|eNFA151_15_20366724
eNFA151_15_20366724 -.->|"ε"|eNFA151_16_49082792
eNFA151_16_49082792 -->|"u"|eNFA151_17_39091944
eNFA151_17_39091944 -.->|"ε"|eNFA151_18_16283183
eNFA151_18_16283183 -->|"f"|eNFA151_19_12330925
eNFA151_19_12330925 -.->|"ε"|eNFA151_20_43869467
eNFA151_20_43869467 -->|"f"|eNFA151_21_59280891
eNFA151_21_59280891 -.->|"ε"|eNFA151_22_63765972
eNFA151_22_63765972 -->|"e"|eNFA151_23_37022841
eNFA151_23_37022841 -.->|"ε"|eNFA151_24_64770113
eNFA151_24_64770113 -->|"r"|eNFA151_25_46060111
eNFA151_25_46060111 -.->|"ε"|eNFA151_27_11887819
eNFA151_27_11887819 -.->|"ε"|eNFA151_28_39881510
eNFA151_28_39881510 -.->|"ε"|eNFA151_29_23389273
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
eNFA151_26_9176869[["εNFA151-26 regex start"]]
eNFA151_0_15482964[["εNFA151-0 char{1, 1}"]]
eNFA151_1_5128949[["εNFA151-1 char[1]"]]
eNFA151_2_46160547[["εNFA151-2 char{1, 1}"]]
eNFA151_3_12791742[["εNFA151-3 char[1]"]]
eNFA151_4_48016815[["εNFA151-4 char{1, 1}"]]
eNFA151_5_29498151[["εNFA151-5 char[1]"]]
eNFA151_6_64156767[["εNFA151-6 char{1, 1}"]]
eNFA151_7_40539992[["εNFA151-7 char[1]"]]
eNFA151_8_29315611[["εNFA151-8 char{1, 1}"]]
eNFA151_9_62513914[["εNFA151-9 char[1]"]]
eNFA151_10_25754316[["εNFA151-10 char{1, 1}"]]
eNFA151_11_30462260[["εNFA151-11 char[1]"]]
eNFA151_12_5724890[["εNFA151-12 char{1, 1}"]]
eNFA151_13_51524015[["εNFA151-13 char[1]"]]
eNFA151_14_61062956[["εNFA151-14 char{1, 1}"]]
eNFA151_15_12695699[["εNFA151-15 char[1]"]]
eNFA151_16_47152427[["εNFA151-16 char{1, 1}"]]
eNFA151_17_21718662[["εNFA151-17 char[1]"]]
eNFA151_18_61250238[["εNFA151-18 char{1, 1}"]]
eNFA151_19_14381235[["εNFA151-19 char[1]"]]
eNFA151_20_62322254[["εNFA151-20 char{1, 1}"]]
eNFA151_21_24029376[["εNFA151-21 char[1]"]]
eNFA151_22_14937794[["εNFA151-22 char{1, 1}"]]
eNFA151_23_222421[["εNFA151-23 char[1]"]]
eNFA151_24_2001795[["εNFA151-24 char{1, 1}"]]
eNFA151_25_18016155[\"εNFA151-25 char[1]"/]
eNFA151_27_27927672[\"εNFA151-27 regex end"/]
eNFA151_28_50022457[\"εNFA151-28 post-regex start"/]
eNFA151_29_47548937[\"εNFA151-29 post-regex end"/]
eNFA151_26_9176869 -.->|"ε"|eNFA151_0_15482964
eNFA151_26_9176869 -->|"s"|eNFA151_1_5128949
eNFA151_0_15482964 -->|"s"|eNFA151_1_5128949
eNFA151_1_5128949 -.->|"ε"|eNFA151_2_46160547
eNFA151_1_5128949 -->|"a"|eNFA151_3_12791742
eNFA151_2_46160547 -->|"a"|eNFA151_3_12791742
eNFA151_3_12791742 -.->|"ε"|eNFA151_4_48016815
eNFA151_3_12791742 -->|"m"|eNFA151_5_29498151
eNFA151_4_48016815 -->|"m"|eNFA151_5_29498151
eNFA151_5_29498151 -.->|"ε"|eNFA151_6_64156767
eNFA151_5_29498151 -->|"p"|eNFA151_7_40539992
eNFA151_6_64156767 -->|"p"|eNFA151_7_40539992
eNFA151_7_40539992 -.->|"ε"|eNFA151_8_29315611
eNFA151_7_40539992 -->|"l"|eNFA151_9_62513914
eNFA151_8_29315611 -->|"l"|eNFA151_9_62513914
eNFA151_9_62513914 -.->|"ε"|eNFA151_10_25754316
eNFA151_9_62513914 -->|"e"|eNFA151_11_30462260
eNFA151_10_25754316 -->|"e"|eNFA151_11_30462260
eNFA151_11_30462260 -.->|"ε"|eNFA151_12_5724890
eNFA151_11_30462260 -->|"r"|eNFA151_13_51524015
eNFA151_12_5724890 -->|"r"|eNFA151_13_51524015
eNFA151_13_51524015 -.->|"ε"|eNFA151_14_61062956
eNFA151_13_51524015 -->|"B"|eNFA151_15_12695699
eNFA151_14_61062956 -->|"B"|eNFA151_15_12695699
eNFA151_15_12695699 -.->|"ε"|eNFA151_16_47152427
eNFA151_15_12695699 -->|"u"|eNFA151_17_21718662
eNFA151_16_47152427 -->|"u"|eNFA151_17_21718662
eNFA151_17_21718662 -.->|"ε"|eNFA151_18_61250238
eNFA151_17_21718662 -->|"f"|eNFA151_19_14381235
eNFA151_18_61250238 -->|"f"|eNFA151_19_14381235
eNFA151_19_14381235 -.->|"ε"|eNFA151_20_62322254
eNFA151_19_14381235 -->|"f"|eNFA151_21_24029376
eNFA151_20_62322254 -->|"f"|eNFA151_21_24029376
eNFA151_21_24029376 -.->|"ε"|eNFA151_22_14937794
eNFA151_21_24029376 -->|"e"|eNFA151_23_222421
eNFA151_22_14937794 -->|"e"|eNFA151_23_222421
eNFA151_23_222421 -.->|"ε"|eNFA151_24_2001795
eNFA151_23_222421 -->|"r"|eNFA151_25_18016155
eNFA151_24_2001795 -->|"r"|eNFA151_25_18016155
eNFA151_25_18016155 -.->|"ε"|eNFA151_27_27927672
eNFA151_25_18016155 -.->|"ε"|eNFA151_28_50022457
eNFA151_25_18016155 -.->|"ε"|eNFA151_29_47548937
eNFA151_27_27927672 -.->|"ε"|eNFA151_28_50022457
eNFA151_27_27927672 -.->|"ε"|eNFA151_29_47548937
eNFA151_28_50022457 -.->|"ε"|eNFA151_29_47548937
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
NFA151_26_25287256("NFA151-26 regex start")
NFA151_1_26258720("NFA151-1 char[1]")
NFA151_3_35001888("NFA151-3 char[1]")
NFA151_5_46581538("NFA151-5 char[1]")
NFA151_7_16580664("NFA151-7 char[1]")
NFA151_9_15008249("NFA151-9 char[1]")
NFA151_11_856520("NFA151-11 char[1]")
NFA151_13_7708685("NFA151-13 char[1]")
NFA151_15_2269305("NFA151-15 char[1]")
NFA151_17_20423749("NFA151-17 char[1]")
NFA151_19_49596018("NFA151-19 char[1]")
NFA151_21_43710986("NFA151-21 char[1]")
NFA151_23_57854556("NFA151-23 char[1]")
NFA151_25_50928963[\"NFA151-25 char[1]"/]
NFA151_26_25287256 -->|"s"|NFA151_1_26258720
NFA151_1_26258720 -->|"a"|NFA151_3_35001888
NFA151_3_35001888 -->|"m"|NFA151_5_46581538
NFA151_5_46581538 -->|"p"|NFA151_7_16580664
NFA151_7_16580664 -->|"l"|NFA151_9_15008249
NFA151_9_15008249 -->|"e"|NFA151_11_856520
NFA151_11_856520 -->|"r"|NFA151_13_7708685
NFA151_13_7708685 -->|"B"|NFA151_15_2269305
NFA151_15_2269305 -->|"u"|NFA151_17_20423749
NFA151_17_20423749 -->|"f"|NFA151_19_49596018
NFA151_19_49596018 -->|"f"|NFA151_21_43710986
NFA151_21_43710986 -->|"e"|NFA151_23_57854556
NFA151_23_57854556 -->|"r"|NFA151_25_50928963
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
subgraph DFA0_296220560["DFA0 regex start"]
NFA151_26_25287256_0("NFA151-26 regex start")
end
subgraph DFA1_-1191250435["DFA1 {1}"]
NFA151_1_26258720_1("NFA151-1 char[1]")
end
subgraph DFA2_-9684572["DFA2 {1}"]
NFA151_3_35001888_2("NFA151-3 char[1]")
end
subgraph DFA3_1363344413["DFA3 {1}"]
NFA151_5_46581538_3("NFA151-5 char[1]")
end
subgraph DFA4_-1460400884["DFA4 {1}"]
NFA151_7_16580664_4("NFA151-7 char[1]")
end
subgraph DFA5_-111670082["DFA5 {1}"]
NFA151_9_15008249_5("NFA151-9 char[1]")
end
subgraph DFA6_-1751681916["DFA6 {1}"]
NFA151_11_856520_6("NFA151-11 char[1]")
end
subgraph DFA7_429443668["DFA7 {1}"]
NFA151_13_7708685_7("NFA151-13 char[1]")
end
subgraph DFA8_-1784545759["DFA8 {1}"]
NFA151_15_2269305_8("NFA151-15 char[1]")
end
subgraph DFA9_413038509["DFA9 {1}"]
NFA151_17_20423749_9("NFA151-17 char[1]")
end
subgraph DFA10_-1274074662["DFA10 {1}"]
NFA151_19_49596018_10("NFA151-19 char[1]")
end
subgraph DFA11_-284312508["DFA11 {1}"]
NFA151_21_43710986_11("NFA151-21 char[1]")
end
subgraph DFA12_1148182722["DFA12 {1}"]
NFA151_23_57854556_12("NFA151-23 char[1]")
end
subgraph DFA13_-663093200["DFA13 {1}"]
NFA151_25_50928963_13[\"NFA151-25 char[1]"/]
end
DFA0_296220560 -->|"s"|DFA1_-1191250435
DFA1_-1191250435 -->|"a"|DFA2_-9684572
DFA2_-9684572 -->|"m"|DFA3_1363344413
DFA3_1363344413 -->|"p"|DFA4_-1460400884
DFA4_-1460400884 -->|"l"|DFA5_-111670082
DFA5_-111670082 -->|"e"|DFA6_-1751681916
DFA6_-1751681916 -->|"r"|DFA7_429443668
DFA7_429443668 -->|"B"|DFA8_-1784545759
DFA8_-1784545759 -->|"u"|DFA9_413038509
DFA9_413038509 -->|"f"|DFA10_-1274074662
DFA10_-1274074662 -->|"f"|DFA11_-284312508
DFA11_-284312508 -->|"e"|DFA12_1148182722
DFA12_1148182722 -->|"r"|DFA13_-663093200
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
DFA0_296220560{{"DFA0 regex start"}}
DFA1_-1191250435{{"DFA1 {1}"}}
DFA2_-9684572{{"DFA2 {1}"}}
DFA3_1363344413{{"DFA3 {1}"}}
DFA4_-1460400884{{"DFA4 {1}"}}
DFA5_-111670082{{"DFA5 {1}"}}
DFA6_-1751681916{{"DFA6 {1}"}}
DFA7_429443668{{"DFA7 {1}"}}
DFA8_-1784545759{{"DFA8 {1}"}}
DFA9_413038509{{"DFA9 {1}"}}
DFA10_-1274074662{{"DFA10 {1}"}}
DFA11_-284312508{{"DFA11 {1}"}}
DFA12_1148182722{{"DFA12 {1}"}}
DFA13_-663093200[\"DFA13 {1}"/]
DFA0_296220560 -->|"s"|DFA1_-1191250435
DFA1_-1191250435 -->|"a"|DFA2_-9684572
DFA2_-9684572 -->|"m"|DFA3_1363344413
DFA3_1363344413 -->|"p"|DFA4_-1460400884
DFA4_-1460400884 -->|"l"|DFA5_-111670082
DFA5_-111670082 -->|"e"|DFA6_-1751681916
DFA6_-1751681916 -->|"r"|DFA7_429443668
DFA7_429443668 -->|"B"|DFA8_-1784545759
DFA8_-1784545759 -->|"u"|DFA9_413038509
DFA9_413038509 -->|"f"|DFA10_-1274074662
DFA10_-1274074662 -->|"f"|DFA11_-284312508
DFA11_-284312508 -->|"e"|DFA12_1148182722
DFA12_1148182722 -->|"r"|DFA13_-663093200
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
subgraph MiniDFA0_-659188555["MiniDFA0 {1}"]
DFA0_296220560_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2033062064["MiniDFA1 {1}"]
DFA1_-1191250435_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1548614179["MiniDFA2 {1}"]
DFA2_-9684572_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1240792640["MiniDFA3 {1}"]
DFA3_1363344413_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1413148837["MiniDFA4 {1}"]
DFA4_-1460400884_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1306858161["MiniDFA5 {1}"]
DFA5_-111670082_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1358583344["MiniDFA7 {1}"]
DFA6_-1751681916_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_41650225["MiniDFA8 {1}"]
DFA7_429443668_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_905561329["MiniDFA9 {1}"]
DFA8_-1784545759_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-876728423["MiniDFA10 {1}"]
DFA9_413038509_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_544630270["MiniDFA11 {1}"]
DFA10_-1274074662_10{{"DFA10 {1}"}}
end
subgraph MiniDFA6_-450355997["MiniDFA6 {1}"]
DFA11_-284312508_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-173024570["MiniDFA12 {1}"]
DFA12_1148182722_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_2118438572["MiniDFA13 {1}"]
DFA13_-663093200_13[\"DFA13 {1}"/]
end
MiniDFA0_-659188555 -->|"s"|MiniDFA1_2033062064
MiniDFA1_2033062064 -->|"a"|MiniDFA2_1548614179
MiniDFA2_1548614179 -->|"m"|MiniDFA3_1240792640
MiniDFA3_1240792640 -->|"p"|MiniDFA4_-1413148837
MiniDFA4_-1413148837 -->|"l"|MiniDFA5_1306858161
MiniDFA5_1306858161 -->|"e"|MiniDFA7_1358583344
MiniDFA7_1358583344 -->|"r"|MiniDFA8_41650225
MiniDFA8_41650225 -->|"B"|MiniDFA9_905561329
MiniDFA9_905561329 -->|"u"|MiniDFA10_-876728423
MiniDFA10_-876728423 -->|"f"|MiniDFA11_544630270
MiniDFA11_544630270 -->|"f"|MiniDFA6_-450355997
MiniDFA6_-450355997 -->|"e"|MiniDFA12_-173024570
MiniDFA12_-173024570 -->|"r"|MiniDFA13_2118438572
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
MiniDFA0_-659188555(["MiniDFA0 {1}"])
MiniDFA1_2033062064(["MiniDFA1 {1}"])
MiniDFA2_1548614179(["MiniDFA2 {1}"])
MiniDFA3_1240792640(["MiniDFA3 {1}"])
MiniDFA4_-1413148837(["MiniDFA4 {1}"])
MiniDFA5_1306858161(["MiniDFA5 {1}"])
MiniDFA7_1358583344(["MiniDFA7 {1}"])
MiniDFA8_41650225(["MiniDFA8 {1}"])
MiniDFA9_905561329(["MiniDFA9 {1}"])
MiniDFA10_-876728423(["MiniDFA10 {1}"])
MiniDFA11_544630270(["MiniDFA11 {1}"])
MiniDFA6_-450355997(["MiniDFA6 {1}"])
MiniDFA12_-173024570(["MiniDFA12 {1}"])
MiniDFA13_2118438572[\"MiniDFA13 {1}"/]
MiniDFA0_-659188555 -->|"s"|MiniDFA1_2033062064
MiniDFA1_2033062064 -->|"a"|MiniDFA2_1548614179
MiniDFA2_1548614179 -->|"m"|MiniDFA3_1240792640
MiniDFA3_1240792640 -->|"p"|MiniDFA4_-1413148837
MiniDFA4_-1413148837 -->|"l"|MiniDFA5_1306858161
MiniDFA5_1306858161 -->|"e"|MiniDFA7_1358583344
MiniDFA7_1358583344 -->|"r"|MiniDFA8_41650225
MiniDFA8_41650225 -->|"B"|MiniDFA9_905561329
MiniDFA9_905561329 -->|"u"|MiniDFA10_-876728423
MiniDFA10_-876728423 -->|"f"|MiniDFA11_544630270
MiniDFA11_544630270 -->|"f"|MiniDFA6_-450355997
MiniDFA6_-450355997 -->|"e"|MiniDFA12_-173024570
MiniDFA12_-173024570 -->|"r"|MiniDFA13_2118438572
```
-------------------------------
