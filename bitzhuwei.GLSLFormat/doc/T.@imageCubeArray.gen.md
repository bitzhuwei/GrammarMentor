# 'imageCubeArray'

pattern: `imageCubeArray`

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
eNFA184_28_2492297[["εNFA184-28 regex start"]]
eNFA184_0_22430675[["εNFA184-0 char{1, 1}"]]
eNFA184_1_549487[["εNFA184-1 char[1]"]]
eNFA184_2_4945391[["εNFA184-2 char{1, 1}"]]
eNFA184_3_44508523[["εNFA184-3 char[1]"]]
eNFA184_4_65032387[["εNFA184-4 char{1, 1}"]]
eNFA184_5_48420578[["εNFA184-5 char[1]"]]
eNFA184_6_33132024[["εNFA184-6 char{1, 1}"]]
eNFA184_7_29752766[["εNFA184-7 char[1]"]]
eNFA184_8_66448310[["εNFA184-8 char{1, 1}"]]
eNFA184_9_61163879[["εNFA184-9 char[1]"]]
eNFA184_10_13604004[["εNFA184-10 char{1, 1}"]]
eNFA184_11_55327172[["εNFA184-11 char[1]"]]
eNFA184_12_28182506[["εNFA184-12 char{1, 1}"]]
eNFA184_13_52315966[["εNFA184-13 char[1]"]]
eNFA184_14_1081649[["εNFA184-14 char{1, 1}"]]
eNFA184_15_9734844[["εNFA184-15 char[1]"]]
eNFA184_16_20504736[["εNFA184-16 char{1, 1}"]]
eNFA184_17_50324903[["εNFA184-17 char[1]"]]
eNFA184_18_50270944[["εNFA184-18 char{1, 1}"]]
eNFA184_19_49785318[["εNFA184-19 char[1]"]]
eNFA184_20_45414681[["εNFA184-20 char{1, 1}"]]
eNFA184_21_6078946[["εNFA184-21 char[1]"]]
eNFA184_22_54710514[["εNFA184-22 char{1, 1}"]]
eNFA184_23_22632578[["εNFA184-23 char[1]"]]
eNFA184_24_2366611[["εNFA184-24 char{1, 1}"]]
eNFA184_25_21299502[["εNFA184-25 char[1]"]]
eNFA184_26_57477797[["εNFA184-26 char{1, 1}"]]
eNFA184_27_47538127[["εNFA184-27 char[1]"]]
eNFA184_29_25189967[["εNFA184-29 regex end"]]
eNFA184_30_25383117[["εNFA184-30 post-regex start"]]
eNFA184_31_27121466[\"εNFA184-31 post-regex end"/]
eNFA184_28_2492297 -.->|"ε"|eNFA184_0_22430675
eNFA184_0_22430675 -->|"i"|eNFA184_1_549487
eNFA184_1_549487 -.->|"ε"|eNFA184_2_4945391
eNFA184_2_4945391 -->|"m"|eNFA184_3_44508523
eNFA184_3_44508523 -.->|"ε"|eNFA184_4_65032387
eNFA184_4_65032387 -->|"a"|eNFA184_5_48420578
eNFA184_5_48420578 -.->|"ε"|eNFA184_6_33132024
eNFA184_6_33132024 -->|"g"|eNFA184_7_29752766
eNFA184_7_29752766 -.->|"ε"|eNFA184_8_66448310
eNFA184_8_66448310 -->|"e"|eNFA184_9_61163879
eNFA184_9_61163879 -.->|"ε"|eNFA184_10_13604004
eNFA184_10_13604004 -->|"C"|eNFA184_11_55327172
eNFA184_11_55327172 -.->|"ε"|eNFA184_12_28182506
eNFA184_12_28182506 -->|"u"|eNFA184_13_52315966
eNFA184_13_52315966 -.->|"ε"|eNFA184_14_1081649
eNFA184_14_1081649 -->|"b"|eNFA184_15_9734844
eNFA184_15_9734844 -.->|"ε"|eNFA184_16_20504736
eNFA184_16_20504736 -->|"e"|eNFA184_17_50324903
eNFA184_17_50324903 -.->|"ε"|eNFA184_18_50270944
eNFA184_18_50270944 -->|"A"|eNFA184_19_49785318
eNFA184_19_49785318 -.->|"ε"|eNFA184_20_45414681
eNFA184_20_45414681 -->|"r"|eNFA184_21_6078946
eNFA184_21_6078946 -.->|"ε"|eNFA184_22_54710514
eNFA184_22_54710514 -->|"r"|eNFA184_23_22632578
eNFA184_23_22632578 -.->|"ε"|eNFA184_24_2366611
eNFA184_24_2366611 -->|"a"|eNFA184_25_21299502
eNFA184_25_21299502 -.->|"ε"|eNFA184_26_57477797
eNFA184_26_57477797 -->|"y"|eNFA184_27_47538127
eNFA184_27_47538127 -.->|"ε"|eNFA184_29_25189967
eNFA184_29_25189967 -.->|"ε"|eNFA184_30_25383117
eNFA184_30_25383117 -.->|"ε"|eNFA184_31_27121466
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
eNFA184_28_42766607[["εNFA184-28 regex start"]]
eNFA184_0_49355150[["εNFA184-0 char{1, 1}"]]
eNFA184_1_41543166[["εNFA184-1 char[1]"]]
eNFA184_2_38344177[["εNFA184-2 char{1, 1}"]]
eNFA184_3_9553281[["εNFA184-3 char[1]"]]
eNFA184_4_18870670[["εNFA184-4 char{1, 1}"]]
eNFA184_5_35618305[["εNFA184-5 char[1]"]]
eNFA184_6_52129291[["εNFA184-6 char{1, 1}"]]
eNFA184_7_66510437[["εNFA184-7 char[1]"]]
eNFA184_8_61723024[["εNFA184-8 char{1, 1}"]]
eNFA184_9_18636310[["εNFA184-9 char[1]"]]
eNFA184_10_33509062[["εNFA184-10 char{1, 1}"]]
eNFA184_11_33146107[["εNFA184-11 char[1]"]]
eNFA184_12_29879508[["εNFA184-12 char{1, 1}"]]
eNFA184_13_480124[["εNFA184-13 char[1]"]]
eNFA184_14_4321123[["εNFA184-14 char{1, 1}"]]
eNFA184_15_38890115[["εNFA184-15 char[1]"]]
eNFA184_16_14466715[["εNFA184-16 char{1, 1}"]]
eNFA184_17_63091573[["εNFA184-17 char[1]"]]
eNFA184_18_30953251[["εNFA184-18 char{1, 1}"]]
eNFA184_19_10143804[["εNFA184-19 char[1]"]]
eNFA184_20_24185379[["εNFA184-20 char{1, 1}"]]
eNFA184_21_16341824[["εNFA184-21 char[1]"]]
eNFA184_22_12858692[["εNFA184-22 char{1, 1}"]]
eNFA184_23_48619368[["εNFA184-23 char[1]"]]
eNFA184_24_34921133[["εNFA184-24 char{1, 1}"]]
eNFA184_25_45854749[["εNFA184-25 char[1]"]]
eNFA184_26_10039559[["εNFA184-26 char{1, 1}"]]
eNFA184_27_23247174[\"εNFA184-27 char[1]"/]
eNFA184_29_7897978[\"εNFA184-29 regex end"/]
eNFA184_30_3972940[\"εNFA184-30 post-regex start"/]
eNFA184_31_35756461[\"εNFA184-31 post-regex end"/]
eNFA184_28_42766607 -.->|"ε"|eNFA184_0_49355150
eNFA184_28_42766607 -->|"i"|eNFA184_1_41543166
eNFA184_0_49355150 -->|"i"|eNFA184_1_41543166
eNFA184_1_41543166 -.->|"ε"|eNFA184_2_38344177
eNFA184_1_41543166 -->|"m"|eNFA184_3_9553281
eNFA184_2_38344177 -->|"m"|eNFA184_3_9553281
eNFA184_3_9553281 -.->|"ε"|eNFA184_4_18870670
eNFA184_3_9553281 -->|"a"|eNFA184_5_35618305
eNFA184_4_18870670 -->|"a"|eNFA184_5_35618305
eNFA184_5_35618305 -.->|"ε"|eNFA184_6_52129291
eNFA184_5_35618305 -->|"g"|eNFA184_7_66510437
eNFA184_6_52129291 -->|"g"|eNFA184_7_66510437
eNFA184_7_66510437 -.->|"ε"|eNFA184_8_61723024
eNFA184_7_66510437 -->|"e"|eNFA184_9_18636310
eNFA184_8_61723024 -->|"e"|eNFA184_9_18636310
eNFA184_9_18636310 -.->|"ε"|eNFA184_10_33509062
eNFA184_9_18636310 -->|"C"|eNFA184_11_33146107
eNFA184_10_33509062 -->|"C"|eNFA184_11_33146107
eNFA184_11_33146107 -.->|"ε"|eNFA184_12_29879508
eNFA184_11_33146107 -->|"u"|eNFA184_13_480124
eNFA184_12_29879508 -->|"u"|eNFA184_13_480124
eNFA184_13_480124 -.->|"ε"|eNFA184_14_4321123
eNFA184_13_480124 -->|"b"|eNFA184_15_38890115
eNFA184_14_4321123 -->|"b"|eNFA184_15_38890115
eNFA184_15_38890115 -.->|"ε"|eNFA184_16_14466715
eNFA184_15_38890115 -->|"e"|eNFA184_17_63091573
eNFA184_16_14466715 -->|"e"|eNFA184_17_63091573
eNFA184_17_63091573 -.->|"ε"|eNFA184_18_30953251
eNFA184_17_63091573 -->|"A"|eNFA184_19_10143804
eNFA184_18_30953251 -->|"A"|eNFA184_19_10143804
eNFA184_19_10143804 -.->|"ε"|eNFA184_20_24185379
eNFA184_19_10143804 -->|"r"|eNFA184_21_16341824
eNFA184_20_24185379 -->|"r"|eNFA184_21_16341824
eNFA184_21_16341824 -.->|"ε"|eNFA184_22_12858692
eNFA184_21_16341824 -->|"r"|eNFA184_23_48619368
eNFA184_22_12858692 -->|"r"|eNFA184_23_48619368
eNFA184_23_48619368 -.->|"ε"|eNFA184_24_34921133
eNFA184_23_48619368 -->|"a"|eNFA184_25_45854749
eNFA184_24_34921133 -->|"a"|eNFA184_25_45854749
eNFA184_25_45854749 -.->|"ε"|eNFA184_26_10039559
eNFA184_25_45854749 -->|"y"|eNFA184_27_23247174
eNFA184_26_10039559 -->|"y"|eNFA184_27_23247174
eNFA184_27_23247174 -.->|"ε"|eNFA184_29_7897978
eNFA184_27_23247174 -.->|"ε"|eNFA184_30_3972940
eNFA184_27_23247174 -.->|"ε"|eNFA184_31_35756461
eNFA184_29_7897978 -.->|"ε"|eNFA184_30_3972940
eNFA184_29_7897978 -.->|"ε"|eNFA184_31_35756461
eNFA184_30_3972940 -.->|"ε"|eNFA184_31_35756461
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
NFA184_28_53372694("NFA184-28 regex start")
NFA184_1_10592200("NFA184-1 char[1]")
NFA184_3_28220940("NFA184-3 char[1]")
NFA184_5_52661876("NFA184-5 char[1]")
NFA184_7_4194840("NFA184-7 char[1]")
NFA184_9_37753560("NFA184-9 char[1]")
NFA184_11_4237727("NFA184-11 char[1]")
NFA184_13_38139549("NFA184-13 char[1]")
NFA184_15_7711627("NFA184-15 char[1]")
NFA184_17_2295787("NFA184-17 char[1]")
NFA184_19_20662084("NFA184-19 char[1]")
NFA184_21_51741033("NFA184-21 char[1]")
NFA184_23_63016113("NFA184-23 char[1]")
NFA184_25_30274111("NFA184-25 char[1]")
NFA184_27_4031547[\"NFA184-27 char[1]"/]
NFA184_28_53372694 -->|"i"|NFA184_1_10592200
NFA184_1_10592200 -->|"m"|NFA184_3_28220940
NFA184_3_28220940 -->|"a"|NFA184_5_52661876
NFA184_5_52661876 -->|"g"|NFA184_7_4194840
NFA184_7_4194840 -->|"e"|NFA184_9_37753560
NFA184_9_37753560 -->|"C"|NFA184_11_4237727
NFA184_11_4237727 -->|"u"|NFA184_13_38139549
NFA184_13_38139549 -->|"b"|NFA184_15_7711627
NFA184_15_7711627 -->|"e"|NFA184_17_2295787
NFA184_17_2295787 -->|"A"|NFA184_19_20662084
NFA184_19_20662084 -->|"r"|NFA184_21_51741033
NFA184_21_51741033 -->|"r"|NFA184_23_63016113
NFA184_23_63016113 -->|"a"|NFA184_25_30274111
NFA184_25_30274111 -->|"y"|NFA184_27_4031547
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
subgraph DFA0_-122501313["DFA0 regex start"]
NFA184_28_53372694_0("NFA184-28 regex start")
end
subgraph DFA1_1962027841["DFA1 {1}"]
NFA184_1_10592200_1("NFA184-1 char[1]")
end
subgraph DFA2_711931598["DFA2 {1}"]
NFA184_3_28220940_2("NFA184-3 char[1]")
end
subgraph DFA3_-648300444["DFA3 {1}"]
NFA184_5_52661876_3("NFA184-5 char[1]")
end
subgraph DFA4_-41197995["DFA4 {1}"]
NFA184_7_4194840_4("NFA184-7 char[1]")
end
subgraph DFA5_148770261["DFA5 {1}"]
NFA184_9_37753560_5("NFA184-9 char[1]")
end
subgraph DFA6_1558895234["DFA6 {1}"]
NFA184_11_4237727_6("NFA184-11 char[1]")
end
subgraph DFA7_146852936["DFA7 {1}"]
NFA184_13_38139549_7("NFA184-13 char[1]")
end
subgraph DFA8_1749700068["DFA8 {1}"]
NFA184_15_7711627_8("NFA184-15 char[1]")
end
subgraph DFA9_628571468["DFA9 {1}"]
NFA184_17_2295787_9("NFA184-17 char[1]")
end
subgraph DFA10_-1969838848["DFA10 {1}"]
NFA184_19_20662084_10("NFA184-19 char[1]")
end
subgraph DFA11_-1298588557["DFA11 {1}"]
NFA184_21_51741033_11("NFA184-21 char[1]")
end
subgraph DFA12_-734734314["DFA12 {1}"]
NFA184_23_63016113_12("NFA184-23 char[1]")
end
subgraph DFA13_657495830["DFA13 {1}"]
NFA184_25_30274111_13("NFA184-25 char[1]")
end
subgraph DFA14_1972520390["DFA14 {1}"]
NFA184_27_4031547_14[\"NFA184-27 char[1]"/]
end
DFA0_-122501313 -->|"i"|DFA1_1962027841
DFA1_1962027841 -->|"m"|DFA2_711931598
DFA2_711931598 -->|"a"|DFA3_-648300444
DFA3_-648300444 -->|"g"|DFA4_-41197995
DFA4_-41197995 -->|"e"|DFA5_148770261
DFA5_148770261 -->|"C"|DFA6_1558895234
DFA6_1558895234 -->|"u"|DFA7_146852936
DFA7_146852936 -->|"b"|DFA8_1749700068
DFA8_1749700068 -->|"e"|DFA9_628571468
DFA9_628571468 -->|"A"|DFA10_-1969838848
DFA10_-1969838848 -->|"r"|DFA11_-1298588557
DFA11_-1298588557 -->|"r"|DFA12_-734734314
DFA12_-734734314 -->|"a"|DFA13_657495830
DFA13_657495830 -->|"y"|DFA14_1972520390
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
DFA0_-122501313{{"DFA0 regex start"}}
DFA1_1962027841{{"DFA1 {1}"}}
DFA2_711931598{{"DFA2 {1}"}}
DFA3_-648300444{{"DFA3 {1}"}}
DFA4_-41197995{{"DFA4 {1}"}}
DFA5_148770261{{"DFA5 {1}"}}
DFA6_1558895234{{"DFA6 {1}"}}
DFA7_146852936{{"DFA7 {1}"}}
DFA8_1749700068{{"DFA8 {1}"}}
DFA9_628571468{{"DFA9 {1}"}}
DFA10_-1969838848{{"DFA10 {1}"}}
DFA11_-1298588557{{"DFA11 {1}"}}
DFA12_-734734314{{"DFA12 {1}"}}
DFA13_657495830{{"DFA13 {1}"}}
DFA14_1972520390[\"DFA14 {1}"/]
DFA0_-122501313 -->|"i"|DFA1_1962027841
DFA1_1962027841 -->|"m"|DFA2_711931598
DFA2_711931598 -->|"a"|DFA3_-648300444
DFA3_-648300444 -->|"g"|DFA4_-41197995
DFA4_-41197995 -->|"e"|DFA5_148770261
DFA5_148770261 -->|"C"|DFA6_1558895234
DFA6_1558895234 -->|"u"|DFA7_146852936
DFA7_146852936 -->|"b"|DFA8_1749700068
DFA8_1749700068 -->|"e"|DFA9_628571468
DFA9_628571468 -->|"A"|DFA10_-1969838848
DFA10_-1969838848 -->|"r"|DFA11_-1298588557
DFA11_-1298588557 -->|"r"|DFA12_-734734314
DFA12_-734734314 -->|"a"|DFA13_657495830
DFA13_657495830 -->|"y"|DFA14_1972520390
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
subgraph MiniDFA0_-1480521776["MiniDFA0 {1}"]
DFA0_-122501313_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1715931955["MiniDFA1 {1}"]
DFA1_1962027841_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_414362483["MiniDFA2 {1}"]
DFA2_711931598_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1004946849["MiniDFA4 {1}"]
DFA3_-648300444_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_87541120["MiniDFA5 {1}"]
DFA4_-41197995_4{{"DFA4 {1}"}}
end
subgraph MiniDFA7_-1090642612["MiniDFA7 {1}"]
DFA5_148770261_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_59061964["MiniDFA8 {1}"]
DFA6_1558895234_6{{"DFA6 {1}"}}
end
subgraph MiniDFA9_1515241840["MiniDFA9 {1}"]
DFA7_146852936_7{{"DFA7 {1}"}}
end
subgraph MiniDFA6_976256552["MiniDFA6 {1}"]
DFA8_1749700068_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_2054026333["MiniDFA10 {1}"]
DFA9_628571468_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_56621686["MiniDFA11 {1}"]
DFA10_-1969838848_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_25405458["MiniDFA12 {1}"]
DFA11_-1298588557_11{{"DFA11 {1}"}}
end
subgraph MiniDFA3_282813577["MiniDFA3 {1}"]
DFA12_-734734314_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1745737692["MiniDFA13 {1}"]
DFA13_657495830_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-602641937["MiniDFA14 {1}"]
DFA14_1972520390_14[\"DFA14 {1}"/]
end
MiniDFA0_-1480521776 -->|"i"|MiniDFA1_-1715931955
MiniDFA1_-1715931955 -->|"m"|MiniDFA2_414362483
MiniDFA2_414362483 -->|"a"|MiniDFA4_1004946849
MiniDFA4_1004946849 -->|"g"|MiniDFA5_87541120
MiniDFA5_87541120 -->|"e"|MiniDFA7_-1090642612
MiniDFA7_-1090642612 -->|"C"|MiniDFA8_59061964
MiniDFA8_59061964 -->|"u"|MiniDFA9_1515241840
MiniDFA9_1515241840 -->|"b"|MiniDFA6_976256552
MiniDFA6_976256552 -->|"e"|MiniDFA10_2054026333
MiniDFA10_2054026333 -->|"A"|MiniDFA11_56621686
MiniDFA11_56621686 -->|"r"|MiniDFA12_25405458
MiniDFA12_25405458 -->|"r"|MiniDFA3_282813577
MiniDFA3_282813577 -->|"a"|MiniDFA13_-1745737692
MiniDFA13_-1745737692 -->|"y"|MiniDFA14_-602641937
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
MiniDFA0_-1480521776(["MiniDFA0 {1}"])
MiniDFA1_-1715931955(["MiniDFA1 {1}"])
MiniDFA2_414362483(["MiniDFA2 {1}"])
MiniDFA4_1004946849(["MiniDFA4 {1}"])
MiniDFA5_87541120(["MiniDFA5 {1}"])
MiniDFA7_-1090642612(["MiniDFA7 {1}"])
MiniDFA8_59061964(["MiniDFA8 {1}"])
MiniDFA9_1515241840(["MiniDFA9 {1}"])
MiniDFA6_976256552(["MiniDFA6 {1}"])
MiniDFA10_2054026333(["MiniDFA10 {1}"])
MiniDFA11_56621686(["MiniDFA11 {1}"])
MiniDFA12_25405458(["MiniDFA12 {1}"])
MiniDFA3_282813577(["MiniDFA3 {1}"])
MiniDFA13_-1745737692(["MiniDFA13 {1}"])
MiniDFA14_-602641937[\"MiniDFA14 {1}"/]
MiniDFA0_-1480521776 -->|"i"|MiniDFA1_-1715931955
MiniDFA1_-1715931955 -->|"m"|MiniDFA2_414362483
MiniDFA2_414362483 -->|"a"|MiniDFA4_1004946849
MiniDFA4_1004946849 -->|"g"|MiniDFA5_87541120
MiniDFA5_87541120 -->|"e"|MiniDFA7_-1090642612
MiniDFA7_-1090642612 -->|"C"|MiniDFA8_59061964
MiniDFA8_59061964 -->|"u"|MiniDFA9_1515241840
MiniDFA9_1515241840 -->|"b"|MiniDFA6_976256552
MiniDFA6_976256552 -->|"e"|MiniDFA10_2054026333
MiniDFA10_2054026333 -->|"A"|MiniDFA11_56621686
MiniDFA11_56621686 -->|"r"|MiniDFA12_25405458
MiniDFA12_25405458 -->|"r"|MiniDFA3_282813577
MiniDFA3_282813577 -->|"a"|MiniDFA13_-1745737692
MiniDFA13_-1745737692 -->|"y"|MiniDFA14_-602641937
```
-------------------------------
