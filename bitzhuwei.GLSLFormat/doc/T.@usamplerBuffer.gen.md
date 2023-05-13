# 'usamplerBuffer'

pattern: `usamplerBuffer`

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
eNFA153_28_7722248[["εNFA153-28 regex start"]]
eNFA153_0_2391374[["εNFA153-0 char{1, 1}"]]
eNFA153_1_21522370[["εNFA153-1 char[1]"]]
eNFA153_2_59483605[["εNFA153-2 char{1, 1}"]]
eNFA153_3_65590400[["εNFA153-3 char[1]"]]
eNFA153_4_53442692[["εNFA153-4 char{1, 1}"]]
eNFA153_5_11222187[["εNFA153-5 char[1]"]]
eNFA153_6_33890820[["εNFA153-6 char{1, 1}"]]
eNFA153_7_36581930[["εNFA153-7 char[1]"]]
eNFA153_8_60801917[["εNFA153-8 char{1, 1}"]]
eNFA153_9_10346342[["εNFA153-9 char[1]"]]
eNFA153_10_26008214[["εNFA153-10 char{1, 1}"]]
eNFA153_11_32747334[["εNFA153-11 char[1]"]]
eNFA153_12_26290551[["εNFA153-12 char{1, 1}"]]
eNFA153_13_35288370[["εNFA153-13 char[1]"]]
eNFA153_14_49159881[["εNFA153-14 char{1, 1}"]]
eNFA153_15_39785747[["εNFA153-15 char[1]"]]
eNFA153_16_22527411[["εNFA153-16 char{1, 1}"]]
eNFA153_17_1420113[["εNFA153-17 char[1]"]]
eNFA153_18_12781022[["εNFA153-18 char{1, 1}"]]
eNFA153_19_47920339[["εNFA153-19 char[1]"]]
eNFA153_20_28629874[["εNFA153-20 char{1, 1}"]]
eNFA153_21_56342274[["εNFA153-21 char[1]"]]
eNFA153_22_37318421[["εNFA153-22 char{1, 1}"]]
eNFA153_23_321477[["εNFA153-23 char[1]"]]
eNFA153_24_2893298[["εNFA153-24 char{1, 1}"]]
eNFA153_25_26039685[["εNFA153-25 char[1]"]]
eNFA153_26_33030575[["εNFA153-26 char{1, 1}"]]
eNFA153_27_28839721[["εNFA153-27 char[1]"]]
eNFA153_29_58230900[["εNFA153-29 regex end"]]
eNFA153_30_54316058[["εNFA153-30 post-regex start"]]
eNFA153_31_19082474[\"εNFA153-31 post-regex end"/]
eNFA153_28_7722248 -.->|"ε"|eNFA153_0_2391374
eNFA153_0_2391374 -->|"u"|eNFA153_1_21522370
eNFA153_1_21522370 -.->|"ε"|eNFA153_2_59483605
eNFA153_2_59483605 -->|"s"|eNFA153_3_65590400
eNFA153_3_65590400 -.->|"ε"|eNFA153_4_53442692
eNFA153_4_53442692 -->|"a"|eNFA153_5_11222187
eNFA153_5_11222187 -.->|"ε"|eNFA153_6_33890820
eNFA153_6_33890820 -->|"m"|eNFA153_7_36581930
eNFA153_7_36581930 -.->|"ε"|eNFA153_8_60801917
eNFA153_8_60801917 -->|"p"|eNFA153_9_10346342
eNFA153_9_10346342 -.->|"ε"|eNFA153_10_26008214
eNFA153_10_26008214 -->|"l"|eNFA153_11_32747334
eNFA153_11_32747334 -.->|"ε"|eNFA153_12_26290551
eNFA153_12_26290551 -->|"e"|eNFA153_13_35288370
eNFA153_13_35288370 -.->|"ε"|eNFA153_14_49159881
eNFA153_14_49159881 -->|"r"|eNFA153_15_39785747
eNFA153_15_39785747 -.->|"ε"|eNFA153_16_22527411
eNFA153_16_22527411 -->|"B"|eNFA153_17_1420113
eNFA153_17_1420113 -.->|"ε"|eNFA153_18_12781022
eNFA153_18_12781022 -->|"u"|eNFA153_19_47920339
eNFA153_19_47920339 -.->|"ε"|eNFA153_20_28629874
eNFA153_20_28629874 -->|"f"|eNFA153_21_56342274
eNFA153_21_56342274 -.->|"ε"|eNFA153_22_37318421
eNFA153_22_37318421 -->|"f"|eNFA153_23_321477
eNFA153_23_321477 -.->|"ε"|eNFA153_24_2893298
eNFA153_24_2893298 -->|"e"|eNFA153_25_26039685
eNFA153_25_26039685 -.->|"ε"|eNFA153_26_33030575
eNFA153_26_33030575 -->|"r"|eNFA153_27_28839721
eNFA153_27_28839721 -.->|"ε"|eNFA153_29_58230900
eNFA153_29_58230900 -.->|"ε"|eNFA153_30_54316058
eNFA153_30_54316058 -.->|"ε"|eNFA153_31_19082474
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
eNFA153_28_37524543[["εNFA153-28 regex start"]]
eNFA153_0_2176568[["εNFA153-0 char{1, 1}"]]
eNFA153_1_19589120[["εNFA153-1 char[1]"]]
eNFA153_2_42084359[["εNFA153-2 char{1, 1}"]]
eNFA153_3_43214919[["εNFA153-3 char[1]"]]
eNFA153_4_53389951[["εNFA153-4 char{1, 1}"]]
eNFA153_5_10747513[["εNFA153-5 char[1]"]]
eNFA153_6_29618759[["εNFA153-6 char{1, 1}"]]
eNFA153_7_65242240[["εNFA153-7 char[1]"]]
eNFA153_8_50309255[["εNFA153-8 char{1, 1}"]]
eNFA153_9_50130116[["εNFA153-9 char[1]"]]
eNFA153_10_48517864[["εNFA153-10 char{1, 1}"]]
eNFA153_11_34007596[["εNFA153-11 char[1]"]]
eNFA153_12_37632913[["εNFA153-12 char{1, 1}"]]
eNFA153_13_3151905[["εNFA153-13 char[1]"]]
eNFA153_14_28367147[["εNFA153-14 char{1, 1}"]]
eNFA153_15_53977738[["εNFA153-15 char[1]"]]
eNFA153_16_16037598[["εNFA153-16 char{1, 1}"]]
eNFA153_17_10120656[["εNFA153-17 char[1]"]]
eNFA153_18_23977041[["εNFA153-18 char{1, 1}"]]
eNFA153_19_14466778[["εNFA153-19 char[1]"]]
eNFA153_20_63092140[["εNFA153-20 char{1, 1}"]]
eNFA153_21_30958352[["εNFA153-21 char[1]"]]
eNFA153_22_10189720[["εNFA153-22 char{1, 1}"]]
eNFA153_23_24598620[["εNFA153-23 char[1]"]]
eNFA153_24_20060988[["εNFA153-24 char{1, 1}"]]
eNFA153_25_46331171[["εNFA153-25 char[1]"]]
eNFA153_26_14327361[["εNFA153-26 char{1, 1}"]]
eNFA153_27_61837391[\"εNFA153-27 char[1]"/]
eNFA153_29_19665615[\"εNFA153-29 regex end"/]
eNFA153_30_42772808[\"εNFA153-30 post-regex start"/]
eNFA153_31_49410957[\"εNFA153-31 post-regex end"/]
eNFA153_28_37524543 -.->|"ε"|eNFA153_0_2176568
eNFA153_28_37524543 -->|"u"|eNFA153_1_19589120
eNFA153_0_2176568 -->|"u"|eNFA153_1_19589120
eNFA153_1_19589120 -.->|"ε"|eNFA153_2_42084359
eNFA153_1_19589120 -->|"s"|eNFA153_3_43214919
eNFA153_2_42084359 -->|"s"|eNFA153_3_43214919
eNFA153_3_43214919 -.->|"ε"|eNFA153_4_53389951
eNFA153_3_43214919 -->|"a"|eNFA153_5_10747513
eNFA153_4_53389951 -->|"a"|eNFA153_5_10747513
eNFA153_5_10747513 -.->|"ε"|eNFA153_6_29618759
eNFA153_5_10747513 -->|"m"|eNFA153_7_65242240
eNFA153_6_29618759 -->|"m"|eNFA153_7_65242240
eNFA153_7_65242240 -.->|"ε"|eNFA153_8_50309255
eNFA153_7_65242240 -->|"p"|eNFA153_9_50130116
eNFA153_8_50309255 -->|"p"|eNFA153_9_50130116
eNFA153_9_50130116 -.->|"ε"|eNFA153_10_48517864
eNFA153_9_50130116 -->|"l"|eNFA153_11_34007596
eNFA153_10_48517864 -->|"l"|eNFA153_11_34007596
eNFA153_11_34007596 -.->|"ε"|eNFA153_12_37632913
eNFA153_11_34007596 -->|"e"|eNFA153_13_3151905
eNFA153_12_37632913 -->|"e"|eNFA153_13_3151905
eNFA153_13_3151905 -.->|"ε"|eNFA153_14_28367147
eNFA153_13_3151905 -->|"r"|eNFA153_15_53977738
eNFA153_14_28367147 -->|"r"|eNFA153_15_53977738
eNFA153_15_53977738 -.->|"ε"|eNFA153_16_16037598
eNFA153_15_53977738 -->|"B"|eNFA153_17_10120656
eNFA153_16_16037598 -->|"B"|eNFA153_17_10120656
eNFA153_17_10120656 -.->|"ε"|eNFA153_18_23977041
eNFA153_17_10120656 -->|"u"|eNFA153_19_14466778
eNFA153_18_23977041 -->|"u"|eNFA153_19_14466778
eNFA153_19_14466778 -.->|"ε"|eNFA153_20_63092140
eNFA153_19_14466778 -->|"f"|eNFA153_21_30958352
eNFA153_20_63092140 -->|"f"|eNFA153_21_30958352
eNFA153_21_30958352 -.->|"ε"|eNFA153_22_10189720
eNFA153_21_30958352 -->|"f"|eNFA153_23_24598620
eNFA153_22_10189720 -->|"f"|eNFA153_23_24598620
eNFA153_23_24598620 -.->|"ε"|eNFA153_24_20060988
eNFA153_23_24598620 -->|"e"|eNFA153_25_46331171
eNFA153_24_20060988 -->|"e"|eNFA153_25_46331171
eNFA153_25_46331171 -.->|"ε"|eNFA153_26_14327361
eNFA153_25_46331171 -->|"r"|eNFA153_27_61837391
eNFA153_26_14327361 -->|"r"|eNFA153_27_61837391
eNFA153_27_61837391 -.->|"ε"|eNFA153_29_19665615
eNFA153_27_61837391 -.->|"ε"|eNFA153_30_42772808
eNFA153_27_61837391 -.->|"ε"|eNFA153_31_49410957
eNFA153_29_19665615 -.->|"ε"|eNFA153_30_42772808
eNFA153_29_19665615 -.->|"ε"|eNFA153_31_49410957
eNFA153_30_42772808 -.->|"ε"|eNFA153_31_49410957
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
NFA153_28_42045429("NFA153-28 regex start")
NFA153_1_42864547("NFA153-1 char[1]")
NFA153_3_50236607("NFA153-3 char[1]")
NFA153_5_49476282("NFA153-5 char[1]")
NFA153_7_42633357("NFA153-7 char[1]")
NFA153_9_48155897("NFA153-9 char[1]")
NFA153_11_30749896("NFA153-11 char[1]")
NFA153_13_8313609("NFA153-13 char[1]")
NFA153_15_7713623("NFA153-15 char[1]")
NFA153_17_2313746("NFA153-17 char[1]")
NFA153_19_20823715("NFA153-19 char[1]")
NFA153_21_53195707("NFA153-21 char[1]")
NFA153_23_8999315("NFA153-23 char[1]")
NFA153_25_13884972("NFA153-25 char[1]")
NFA153_27_57855887[\"NFA153-27 char[1]"/]
NFA153_28_42045429 -->|"u"|NFA153_1_42864547
NFA153_1_42864547 -->|"s"|NFA153_3_50236607
NFA153_3_50236607 -->|"a"|NFA153_5_49476282
NFA153_5_49476282 -->|"m"|NFA153_7_42633357
NFA153_7_42633357 -->|"p"|NFA153_9_48155897
NFA153_9_48155897 -->|"l"|NFA153_11_30749896
NFA153_11_30749896 -->|"e"|NFA153_13_8313609
NFA153_13_8313609 -->|"r"|NFA153_15_7713623
NFA153_15_7713623 -->|"B"|NFA153_17_2313746
NFA153_17_2313746 -->|"u"|NFA153_19_20823715
NFA153_19_20823715 -->|"f"|NFA153_21_53195707
NFA153_21_53195707 -->|"f"|NFA153_23_8999315
NFA153_23_8999315 -->|"e"|NFA153_25_13884972
NFA153_25_13884972 -->|"r"|NFA153_27_57855887
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
subgraph DFA0_-947782314["DFA0 regex start"]
NFA153_28_42045429_0("NFA153-28 regex start")
end
subgraph DFA1_-1815220794["DFA1 {1}"]
NFA153_1_42864547_1("NFA153-1 char[1]")
end
subgraph DFA2_-661650488["DFA2 {1}"]
NFA153_3_50236607_2("NFA153-3 char[1]")
end
subgraph DFA3_-502505789["DFA3 {1}"]
NFA153_5_49476282_3("NFA153-5 char[1]")
end
subgraph DFA4_-398616013["DFA4 {1}"]
NFA153_7_42633357_4("NFA153-7 char[1]")
end
subgraph DFA5_-661366662["DFA5 {1}"]
NFA153_9_48155897_5("NFA153-9 char[1]")
end
subgraph DFA6_1690614587["DFA6 {1}"]
NFA153_11_30749896_6("NFA153-11 char[1]")
end
subgraph DFA7_-1599518884["DFA7 {1}"]
NFA153_13_8313609_7("NFA153-13 char[1]")
end
subgraph DFA8_-1847266062["DFA8 {1}"]
NFA153_15_7713623_8("NFA153-15 char[1]")
end
subgraph DFA9_-1824017343["DFA9 {1}"]
NFA153_17_2313746_9("NFA153-17 char[1]")
end
subgraph DFA10_-1367079659["DFA10 {1}"]
NFA153_19_20823715_10("NFA153-19 char[1]")
end
subgraph DFA11_1758585481["DFA11 {1}"]
NFA153_21_53195707_11("NFA153-21 char[1]")
end
subgraph DFA12_714888661["DFA12 {1}"]
NFA153_23_8999315_12("NFA153-23 char[1]")
end
subgraph DFA13_-15036595["DFA13 {1}"]
NFA153_25_13884972_13("NFA153-25 char[1]")
end
subgraph DFA14_26425906["DFA14 {1}"]
NFA153_27_57855887_14[\"NFA153-27 char[1]"/]
end
DFA0_-947782314 -->|"u"|DFA1_-1815220794
DFA1_-1815220794 -->|"s"|DFA2_-661650488
DFA2_-661650488 -->|"a"|DFA3_-502505789
DFA3_-502505789 -->|"m"|DFA4_-398616013
DFA4_-398616013 -->|"p"|DFA5_-661366662
DFA5_-661366662 -->|"l"|DFA6_1690614587
DFA6_1690614587 -->|"e"|DFA7_-1599518884
DFA7_-1599518884 -->|"r"|DFA8_-1847266062
DFA8_-1847266062 -->|"B"|DFA9_-1824017343
DFA9_-1824017343 -->|"u"|DFA10_-1367079659
DFA10_-1367079659 -->|"f"|DFA11_1758585481
DFA11_1758585481 -->|"f"|DFA12_714888661
DFA12_714888661 -->|"e"|DFA13_-15036595
DFA13_-15036595 -->|"r"|DFA14_26425906
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
DFA0_-947782314{{"DFA0 regex start"}}
DFA1_-1815220794{{"DFA1 {1}"}}
DFA2_-661650488{{"DFA2 {1}"}}
DFA3_-502505789{{"DFA3 {1}"}}
DFA4_-398616013{{"DFA4 {1}"}}
DFA5_-661366662{{"DFA5 {1}"}}
DFA6_1690614587{{"DFA6 {1}"}}
DFA7_-1599518884{{"DFA7 {1}"}}
DFA8_-1847266062{{"DFA8 {1}"}}
DFA9_-1824017343{{"DFA9 {1}"}}
DFA10_-1367079659{{"DFA10 {1}"}}
DFA11_1758585481{{"DFA11 {1}"}}
DFA12_714888661{{"DFA12 {1}"}}
DFA13_-15036595{{"DFA13 {1}"}}
DFA14_26425906[\"DFA14 {1}"/]
DFA0_-947782314 -->|"u"|DFA1_-1815220794
DFA1_-1815220794 -->|"s"|DFA2_-661650488
DFA2_-661650488 -->|"a"|DFA3_-502505789
DFA3_-502505789 -->|"m"|DFA4_-398616013
DFA4_-398616013 -->|"p"|DFA5_-661366662
DFA5_-661366662 -->|"l"|DFA6_1690614587
DFA6_1690614587 -->|"e"|DFA7_-1599518884
DFA7_-1599518884 -->|"r"|DFA8_-1847266062
DFA8_-1847266062 -->|"B"|DFA9_-1824017343
DFA9_-1824017343 -->|"u"|DFA10_-1367079659
DFA10_-1367079659 -->|"f"|DFA11_1758585481
DFA11_1758585481 -->|"f"|DFA12_714888661
DFA12_714888661 -->|"e"|DFA13_-15036595
DFA13_-15036595 -->|"r"|DFA14_26425906
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
subgraph MiniDFA0_1022675548["MiniDFA0 {1}"]
DFA0_-947782314_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_788247528["MiniDFA2 {1}"]
DFA1_-1815220794_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-560839125["MiniDFA3 {1}"]
DFA2_-661650488_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-315224994["MiniDFA4 {1}"]
DFA3_-502505789_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-372566379["MiniDFA5 {1}"]
DFA4_-398616013_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1278493952["MiniDFA6 {1}"]
DFA5_-661366662_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1624341861["MiniDFA7 {1}"]
DFA6_1690614587_6{{"DFA6 {1}"}}
end
subgraph MiniDFA9_1897675370["MiniDFA9 {1}"]
DFA7_-1599518884_7{{"DFA7 {1}"}}
end
subgraph MiniDFA10_-504498010["MiniDFA10 {1}"]
DFA8_-1847266062_8{{"DFA8 {1}"}}
end
subgraph MiniDFA1_1908289856["MiniDFA1 {1}"]
DFA9_-1824017343_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_1642107457["MiniDFA11 {1}"]
DFA10_-1367079659_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_-1153802329["MiniDFA12 {1}"]
DFA11_1758585481_11{{"DFA11 {1}"}}
end
subgraph MiniDFA8_1967931319["MiniDFA8 {1}"]
DFA12_714888661_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_641565963["MiniDFA13 {1}"]
DFA13_-15036595_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-1168808138["MiniDFA14 {1}"]
DFA14_26425906_14[\"DFA14 {1}"/]
end
MiniDFA0_1022675548 -->|"u"|MiniDFA2_788247528
MiniDFA2_788247528 -->|"s"|MiniDFA3_-560839125
MiniDFA3_-560839125 -->|"a"|MiniDFA4_-315224994
MiniDFA4_-315224994 -->|"m"|MiniDFA5_-372566379
MiniDFA5_-372566379 -->|"p"|MiniDFA6_-1278493952
MiniDFA6_-1278493952 -->|"l"|MiniDFA7_1624341861
MiniDFA7_1624341861 -->|"e"|MiniDFA9_1897675370
MiniDFA9_1897675370 -->|"r"|MiniDFA10_-504498010
MiniDFA10_-504498010 -->|"B"|MiniDFA1_1908289856
MiniDFA1_1908289856 -->|"u"|MiniDFA11_1642107457
MiniDFA11_1642107457 -->|"f"|MiniDFA12_-1153802329
MiniDFA12_-1153802329 -->|"f"|MiniDFA8_1967931319
MiniDFA8_1967931319 -->|"e"|MiniDFA13_641565963
MiniDFA13_641565963 -->|"r"|MiniDFA14_-1168808138
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
MiniDFA0_1022675548(["MiniDFA0 {1}"])
MiniDFA2_788247528(["MiniDFA2 {1}"])
MiniDFA3_-560839125(["MiniDFA3 {1}"])
MiniDFA4_-315224994(["MiniDFA4 {1}"])
MiniDFA5_-372566379(["MiniDFA5 {1}"])
MiniDFA6_-1278493952(["MiniDFA6 {1}"])
MiniDFA7_1624341861(["MiniDFA7 {1}"])
MiniDFA9_1897675370(["MiniDFA9 {1}"])
MiniDFA10_-504498010(["MiniDFA10 {1}"])
MiniDFA1_1908289856(["MiniDFA1 {1}"])
MiniDFA11_1642107457(["MiniDFA11 {1}"])
MiniDFA12_-1153802329(["MiniDFA12 {1}"])
MiniDFA8_1967931319(["MiniDFA8 {1}"])
MiniDFA13_641565963(["MiniDFA13 {1}"])
MiniDFA14_-1168808138[\"MiniDFA14 {1}"/]
MiniDFA0_1022675548 -->|"u"|MiniDFA2_788247528
MiniDFA2_788247528 -->|"s"|MiniDFA3_-560839125
MiniDFA3_-560839125 -->|"a"|MiniDFA4_-315224994
MiniDFA4_-315224994 -->|"m"|MiniDFA5_-372566379
MiniDFA5_-372566379 -->|"p"|MiniDFA6_-1278493952
MiniDFA6_-1278493952 -->|"l"|MiniDFA7_1624341861
MiniDFA7_1624341861 -->|"e"|MiniDFA9_1897675370
MiniDFA9_1897675370 -->|"r"|MiniDFA10_-504498010
MiniDFA10_-504498010 -->|"B"|MiniDFA1_1908289856
MiniDFA1_1908289856 -->|"u"|MiniDFA11_1642107457
MiniDFA11_1642107457 -->|"f"|MiniDFA12_-1153802329
MiniDFA12_-1153802329 -->|"f"|MiniDFA8_1967931319
MiniDFA8_1967931319 -->|"e"|MiniDFA13_641565963
MiniDFA13_641565963 -->|"r"|MiniDFA14_-1168808138
```
-------------------------------
