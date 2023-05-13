# 'uimageCubeArray'

pattern: `uimageCubeArray`

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
eNFA186_30_18874618[["εNFA186-30 regex start"]]
eNFA186_0_35653836[["εNFA186-0 char{1, 1}"]]
eNFA186_1_52449071[["εNFA186-1 char[1]"]]
eNFA186_2_2279597[["εNFA186-2 char{1, 1}"]]
eNFA186_3_20516373[["εNFA186-3 char[1]"]]
eNFA186_4_50429634[["εNFA186-4 char{1, 1}"]]
eNFA186_5_51213523[["εNFA186-5 char[1]"]]
eNFA186_6_58268531[["εNFA186-6 char{1, 1}"]]
eNFA186_7_54654738[["εNFA186-7 char[1]"]]
eNFA186_8_22130602[["εNFA186-8 char{1, 1}"]]
eNFA186_9_64957690[["εNFA186-9 char[1]"]]
eNFA186_10_47748300[["εNFA186-10 char{1, 1}"]]
eNFA186_11_27081522[["εNFA186-11 char[1]"]]
eNFA186_12_42407107[["εNFA186-12 char{1, 1}"]]
eNFA186_13_46119650[["εNFA186-13 char[1]"]]
eNFA186_14_12423671[["εNFA186-14 char{1, 1}"]]
eNFA186_15_44704179[["εNFA186-15 char[1]"]]
eNFA186_16_66793295[["εNFA186-16 char{1, 1}"]]
eNFA186_17_64268748[["εNFA186-17 char[1]"]]
eNFA186_18_41547828[["εNFA186-18 char{1, 1}"]]
eNFA186_19_38386134[["εNFA186-19 char[1]"]]
eNFA186_20_9930893[["εNFA186-20 char{1, 1}"]]
eNFA186_21_22269177[["εNFA186-21 char[1]"]]
eNFA186_22_66204867[["εNFA186-22 char{1, 1}"]]
eNFA186_23_58972892[["εNFA186-23 char[1]"]]
eNFA186_24_60993981[["εNFA186-24 char{1, 1}"]]
eNFA186_25_12074919[["εNFA186-25 char[1]"]]
eNFA186_26_41565411[["εNFA186-26 char{1, 1}"]]
eNFA186_27_38544387[["εNFA186-27 char[1]"]]
eNFA186_28_11355167[["εNFA186-28 char{1, 1}"]]
eNFA186_29_35087639[["εNFA186-29 char[1]"]]
eNFA186_31_47353302[["εNFA186-31 regex end"]]
eNFA186_32_23526540[["εNFA186-32 post-regex start"]]
eNFA186_33_10412274[\"εNFA186-33 post-regex end"/]
eNFA186_30_18874618 -.->|"ε"|eNFA186_0_35653836
eNFA186_0_35653836 -->|"u"|eNFA186_1_52449071
eNFA186_1_52449071 -.->|"ε"|eNFA186_2_2279597
eNFA186_2_2279597 -->|"i"|eNFA186_3_20516373
eNFA186_3_20516373 -.->|"ε"|eNFA186_4_50429634
eNFA186_4_50429634 -->|"m"|eNFA186_5_51213523
eNFA186_5_51213523 -.->|"ε"|eNFA186_6_58268531
eNFA186_6_58268531 -->|"a"|eNFA186_7_54654738
eNFA186_7_54654738 -.->|"ε"|eNFA186_8_22130602
eNFA186_8_22130602 -->|"g"|eNFA186_9_64957690
eNFA186_9_64957690 -.->|"ε"|eNFA186_10_47748300
eNFA186_10_47748300 -->|"e"|eNFA186_11_27081522
eNFA186_11_27081522 -.->|"ε"|eNFA186_12_42407107
eNFA186_12_42407107 -->|"C"|eNFA186_13_46119650
eNFA186_13_46119650 -.->|"ε"|eNFA186_14_12423671
eNFA186_14_12423671 -->|"u"|eNFA186_15_44704179
eNFA186_15_44704179 -.->|"ε"|eNFA186_16_66793295
eNFA186_16_66793295 -->|"b"|eNFA186_17_64268748
eNFA186_17_64268748 -.->|"ε"|eNFA186_18_41547828
eNFA186_18_41547828 -->|"e"|eNFA186_19_38386134
eNFA186_19_38386134 -.->|"ε"|eNFA186_20_9930893
eNFA186_20_9930893 -->|"A"|eNFA186_21_22269177
eNFA186_21_22269177 -.->|"ε"|eNFA186_22_66204867
eNFA186_22_66204867 -->|"r"|eNFA186_23_58972892
eNFA186_23_58972892 -.->|"ε"|eNFA186_24_60993981
eNFA186_24_60993981 -->|"r"|eNFA186_25_12074919
eNFA186_25_12074919 -.->|"ε"|eNFA186_26_41565411
eNFA186_26_41565411 -->|"a"|eNFA186_27_38544387
eNFA186_27_38544387 -.->|"ε"|eNFA186_28_11355167
eNFA186_28_11355167 -->|"y"|eNFA186_29_35087639
eNFA186_29_35087639 -.->|"ε"|eNFA186_31_47353302
eNFA186_31_47353302 -.->|"ε"|eNFA186_32_23526540
eNFA186_32_23526540 -.->|"ε"|eNFA186_33_10412274
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
eNFA186_30_26601610[["εNFA186-30 regex start"]]
eNFA186_0_38087899[["εNFA186-0 char{1, 1}"]]
eNFA186_1_7246776[["εNFA186-1 char[1]"]]
eNFA186_2_65220984[["εNFA186-2 char{1, 1}"]]
eNFA186_3_50117950[["εNFA186-3 char[1]"]]
eNFA186_4_48408370[["εNFA186-4 char{1, 1}"]]
eNFA186_5_33022149[["εNFA186-5 char[1]"]]
eNFA186_6_28763888[["εNFA186-6 char{1, 1}"]]
eNFA186_7_57548404[["εNFA186-7 char[1]"]]
eNFA186_8_48173595[["εNFA186-8 char{1, 1}"]]
eNFA186_9_30909172[["εNFA186-9 char[1]"]]
eNFA186_10_9747098[["εNFA186-10 char{1, 1}"]]
eNFA186_11_20615021[["εNFA186-11 char[1]"]]
eNFA186_12_51317462[["εNFA186-12 char{1, 1}"]]
eNFA186_13_59203974[["εNFA186-13 char[1]"]]
eNFA186_14_63073718[["εNFA186-14 char{1, 1}"]]
eNFA186_15_30792551[["εNFA186-15 char[1]"]]
eNFA186_16_8697506[["εNFA186-16 char{1, 1}"]]
eNFA186_17_11168697[["εNFA186-17 char[1]"]]
eNFA186_18_33409411[["εNFA186-18 char{1, 1}"]]
eNFA186_19_32249251[["εNFA186-19 char[1]"]]
eNFA186_20_21807809[["εNFA186-20 char{1, 1}"]]
eNFA186_21_62052558[["εNFA186-21 char[1]"]]
eNFA186_22_21602115[["εNFA186-22 char{1, 1}"]]
eNFA186_23_60201314[["εNFA186-23 char[1]"]]
eNFA186_24_4940914[["εNFA186-24 char{1, 1}"]]
eNFA186_25_44468229[["εNFA186-25 char[1]"]]
eNFA186_26_64669749[["εNFA186-26 char{1, 1}"]]
eNFA186_27_45156834[["εNFA186-27 char[1]"]]
eNFA186_28_3758325[["εNFA186-28 char{1, 1}"]]
eNFA186_29_33824927[\"εNFA186-29 char[1]"/]
eNFA186_31_35988889[\"εNFA186-31 regex end"/]
eNFA186_32_55464548[\"εNFA186-32 post-regex start"/]
eNFA186_33_29418890[\"εNFA186-33 post-regex end"/]
eNFA186_30_26601610 -.->|"ε"|eNFA186_0_38087899
eNFA186_30_26601610 -->|"u"|eNFA186_1_7246776
eNFA186_0_38087899 -->|"u"|eNFA186_1_7246776
eNFA186_1_7246776 -.->|"ε"|eNFA186_2_65220984
eNFA186_1_7246776 -->|"i"|eNFA186_3_50117950
eNFA186_2_65220984 -->|"i"|eNFA186_3_50117950
eNFA186_3_50117950 -.->|"ε"|eNFA186_4_48408370
eNFA186_3_50117950 -->|"m"|eNFA186_5_33022149
eNFA186_4_48408370 -->|"m"|eNFA186_5_33022149
eNFA186_5_33022149 -.->|"ε"|eNFA186_6_28763888
eNFA186_5_33022149 -->|"a"|eNFA186_7_57548404
eNFA186_6_28763888 -->|"a"|eNFA186_7_57548404
eNFA186_7_57548404 -.->|"ε"|eNFA186_8_48173595
eNFA186_7_57548404 -->|"g"|eNFA186_9_30909172
eNFA186_8_48173595 -->|"g"|eNFA186_9_30909172
eNFA186_9_30909172 -.->|"ε"|eNFA186_10_9747098
eNFA186_9_30909172 -->|"e"|eNFA186_11_20615021
eNFA186_10_9747098 -->|"e"|eNFA186_11_20615021
eNFA186_11_20615021 -.->|"ε"|eNFA186_12_51317462
eNFA186_11_20615021 -->|"C"|eNFA186_13_59203974
eNFA186_12_51317462 -->|"C"|eNFA186_13_59203974
eNFA186_13_59203974 -.->|"ε"|eNFA186_14_63073718
eNFA186_13_59203974 -->|"u"|eNFA186_15_30792551
eNFA186_14_63073718 -->|"u"|eNFA186_15_30792551
eNFA186_15_30792551 -.->|"ε"|eNFA186_16_8697506
eNFA186_15_30792551 -->|"b"|eNFA186_17_11168697
eNFA186_16_8697506 -->|"b"|eNFA186_17_11168697
eNFA186_17_11168697 -.->|"ε"|eNFA186_18_33409411
eNFA186_17_11168697 -->|"e"|eNFA186_19_32249251
eNFA186_18_33409411 -->|"e"|eNFA186_19_32249251
eNFA186_19_32249251 -.->|"ε"|eNFA186_20_21807809
eNFA186_19_32249251 -->|"A"|eNFA186_21_62052558
eNFA186_20_21807809 -->|"A"|eNFA186_21_62052558
eNFA186_21_62052558 -.->|"ε"|eNFA186_22_21602115
eNFA186_21_62052558 -->|"r"|eNFA186_23_60201314
eNFA186_22_21602115 -->|"r"|eNFA186_23_60201314
eNFA186_23_60201314 -.->|"ε"|eNFA186_24_4940914
eNFA186_23_60201314 -->|"r"|eNFA186_25_44468229
eNFA186_24_4940914 -->|"r"|eNFA186_25_44468229
eNFA186_25_44468229 -.->|"ε"|eNFA186_26_64669749
eNFA186_25_44468229 -->|"a"|eNFA186_27_45156834
eNFA186_26_64669749 -->|"a"|eNFA186_27_45156834
eNFA186_27_45156834 -.->|"ε"|eNFA186_28_3758325
eNFA186_27_45156834 -->|"y"|eNFA186_29_33824927
eNFA186_28_3758325 -->|"y"|eNFA186_29_33824927
eNFA186_29_33824927 -.->|"ε"|eNFA186_31_35988889
eNFA186_29_33824927 -.->|"ε"|eNFA186_32_55464548
eNFA186_29_33824927 -.->|"ε"|eNFA186_33_29418890
eNFA186_31_35988889 -.->|"ε"|eNFA186_32_55464548
eNFA186_31_35988889 -.->|"ε"|eNFA186_33_29418890
eNFA186_32_55464548 -.->|"ε"|eNFA186_33_29418890
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
NFA186_30_63443418("NFA186-30 regex start")
NFA186_1_34119855("NFA186-1 char[1]")
NFA186_3_38643240("NFA186-3 char[1]")
NFA186_5_12244848("NFA186-5 char[1]")
NFA186_7_43094775("NFA186-7 char[1]")
NFA186_9_52308663("NFA186-9 char[1]")
NFA186_11_1015919("NFA186-11 char[1]")
NFA186_13_9143273("NFA186-13 char[1]")
NFA186_15_15180599("NFA186-15 char[1]")
NFA186_17_2407664("NFA186-17 char[1]")
NFA186_19_21668983("NFA186-19 char[1]")
NFA186_21_60803124("NFA186-21 char[1]")
NFA186_23_10357208("NFA186-23 char[1]")
NFA186_25_26106012("NFA186-25 char[1]")
NFA186_27_33627521("NFA186-27 char[1]")
NFA186_29_34212241[\"NFA186-29 char[1]"/]
NFA186_30_63443418 -->|"u"|NFA186_1_34119855
NFA186_1_34119855 -->|"i"|NFA186_3_38643240
NFA186_3_38643240 -->|"m"|NFA186_5_12244848
NFA186_5_12244848 -->|"a"|NFA186_7_43094775
NFA186_7_43094775 -->|"g"|NFA186_9_52308663
NFA186_9_52308663 -->|"e"|NFA186_11_1015919
NFA186_11_1015919 -->|"C"|NFA186_13_9143273
NFA186_13_9143273 -->|"u"|NFA186_15_15180599
NFA186_15_15180599 -->|"b"|NFA186_17_2407664
NFA186_17_2407664 -->|"e"|NFA186_19_21668983
NFA186_19_21668983 -->|"A"|NFA186_21_60803124
NFA186_21_60803124 -->|"r"|NFA186_23_10357208
NFA186_23_10357208 -->|"r"|NFA186_25_26106012
NFA186_25_26106012 -->|"a"|NFA186_27_33627521
NFA186_27_33627521 -->|"y"|NFA186_29_34212241
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
subgraph DFA0_-1310422298["DFA0 regex start"]
NFA186_30_63443418_0("NFA186-30 regex start")
end
subgraph DFA1_2136750488["DFA1 {1}"]
NFA186_1_34119855_1("NFA186-1 char[1]")
end
subgraph DFA2_-1784085794["DFA2 {1}"]
NFA186_3_38643240_2("NFA186-3 char[1]")
end
subgraph DFA3_-1461450098["DFA3 {1}"]
NFA186_5_12244848_3("NFA186-5 char[1]")
end
subgraph DFA4_-166087179["DFA4 {1}"]
NFA186_7_43094775_4("NFA186-7 char[1]")
end
subgraph DFA5_794444160["DFA5 {1}"]
NFA186_9_52308663_5("NFA186-9 char[1]")
end
subgraph DFA6_-1259947072["DFA6 {1}"]
NFA186_11_1015919_6("NFA186-11 char[1]")
end
subgraph DFA7_605035995["DFA7 {1}"]
NFA186_13_9143273_7("NFA186-13 char[1]")
end
subgraph DFA8_-1449288426["DFA8 {1}"]
NFA186_15_15180599_8("NFA186-15 char[1]")
end
subgraph DFA9_1808775448["DFA9 {1}"]
NFA186_17_2407664_9("NFA186-17 char[1]")
end
subgraph DFA10_-1053724666["DFA10 {1}"]
NFA186_19_21668983_10("NFA186-19 char[1]")
end
subgraph DFA11_-439970675["DFA11 {1}"]
NFA186_21_60803124_11("NFA186-21 char[1]")
end
subgraph DFA12_2091110919["DFA12 {1}"]
NFA186_23_10357208_12("NFA186-23 char[1]")
end
subgraph DFA13_10383317["DFA13 {1}"]
NFA186_25_26106012_13("NFA186-25 char[1]")
end
subgraph DFA14_-2124814744["DFA14 {1}"]
NFA186_27_33627521_14("NFA186-27 char[1]")
end
subgraph DFA15_-658368536["DFA15 {1}"]
NFA186_29_34212241_15[\"NFA186-29 char[1]"/]
end
DFA0_-1310422298 -->|"u"|DFA1_2136750488
DFA1_2136750488 -->|"i"|DFA2_-1784085794
DFA2_-1784085794 -->|"m"|DFA3_-1461450098
DFA3_-1461450098 -->|"a"|DFA4_-166087179
DFA4_-166087179 -->|"g"|DFA5_794444160
DFA5_794444160 -->|"e"|DFA6_-1259947072
DFA6_-1259947072 -->|"C"|DFA7_605035995
DFA7_605035995 -->|"u"|DFA8_-1449288426
DFA8_-1449288426 -->|"b"|DFA9_1808775448
DFA9_1808775448 -->|"e"|DFA10_-1053724666
DFA10_-1053724666 -->|"A"|DFA11_-439970675
DFA11_-439970675 -->|"r"|DFA12_2091110919
DFA12_2091110919 -->|"r"|DFA13_10383317
DFA13_10383317 -->|"a"|DFA14_-2124814744
DFA14_-2124814744 -->|"y"|DFA15_-658368536
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
DFA0_-1310422298{{"DFA0 regex start"}}
DFA1_2136750488{{"DFA1 {1}"}}
DFA2_-1784085794{{"DFA2 {1}"}}
DFA3_-1461450098{{"DFA3 {1}"}}
DFA4_-166087179{{"DFA4 {1}"}}
DFA5_794444160{{"DFA5 {1}"}}
DFA6_-1259947072{{"DFA6 {1}"}}
DFA7_605035995{{"DFA7 {1}"}}
DFA8_-1449288426{{"DFA8 {1}"}}
DFA9_1808775448{{"DFA9 {1}"}}
DFA10_-1053724666{{"DFA10 {1}"}}
DFA11_-439970675{{"DFA11 {1}"}}
DFA12_2091110919{{"DFA12 {1}"}}
DFA13_10383317{{"DFA13 {1}"}}
DFA14_-2124814744{{"DFA14 {1}"}}
DFA15_-658368536[\"DFA15 {1}"/]
DFA0_-1310422298 -->|"u"|DFA1_2136750488
DFA1_2136750488 -->|"i"|DFA2_-1784085794
DFA2_-1784085794 -->|"m"|DFA3_-1461450098
DFA3_-1461450098 -->|"a"|DFA4_-166087179
DFA4_-166087179 -->|"g"|DFA5_794444160
DFA5_794444160 -->|"e"|DFA6_-1259947072
DFA6_-1259947072 -->|"C"|DFA7_605035995
DFA7_605035995 -->|"u"|DFA8_-1449288426
DFA8_-1449288426 -->|"b"|DFA9_1808775448
DFA9_1808775448 -->|"e"|DFA10_-1053724666
DFA10_-1053724666 -->|"A"|DFA11_-439970675
DFA11_-439970675 -->|"r"|DFA12_2091110919
DFA12_2091110919 -->|"r"|DFA13_10383317
DFA13_10383317 -->|"a"|DFA14_-2124814744
DFA14_-2124814744 -->|"y"|DFA15_-658368536
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
subgraph MiniDFA0_-1566907249["MiniDFA0 {1}"]
DFA0_-1310422298_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_780208008["MiniDFA2 {1}"]
DFA1_2136750488_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-925314152["MiniDFA3 {1}"]
DFA2_-1784085794_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_2059751482["MiniDFA4 {1}"]
DFA3_-1461450098_3{{"DFA3 {1}"}}
end
subgraph MiniDFA6_-412576939["MiniDFA6 {1}"]
DFA4_-166087179_4{{"DFA4 {1}"}}
end
subgraph MiniDFA7_-1347518253["MiniDFA7 {1}"]
DFA5_794444160_5{{"DFA5 {1}"}}
end
subgraph MiniDFA9_-1085121845["MiniDFA9 {1}"]
DFA6_-1259947072_6{{"DFA6 {1}"}}
end
subgraph MiniDFA1_-256238911["MiniDFA1 {1}"]
DFA7_605035995_7{{"DFA7 {1}"}}
end
subgraph MiniDFA10_-638328579["MiniDFA10 {1}"]
DFA8_-1449288426_8{{"DFA8 {1}"}}
end
subgraph MiniDFA8_-754660318["MiniDFA8 {1}"]
DFA9_1808775448_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_624838850["MiniDFA11 {1}"]
DFA10_-1053724666_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_1865787337["MiniDFA12 {1}"]
DFA11_-439970675_11{{"DFA11 {1}"}}
end
subgraph MiniDFA13_439245606["MiniDFA13 {1}"]
DFA12_2091110919_12{{"DFA12 {1}"}}
end
subgraph MiniDFA5_-61777580["MiniDFA5 {1}"]
DFA13_10383317_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1403458959["MiniDFA14 {1}"]
DFA14_-2124814744_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_1444952458["MiniDFA15 {1}"]
DFA15_-658368536_15[\"DFA15 {1}"/]
end
MiniDFA0_-1566907249 -->|"u"|MiniDFA2_780208008
MiniDFA2_780208008 -->|"i"|MiniDFA3_-925314152
MiniDFA3_-925314152 -->|"m"|MiniDFA4_2059751482
MiniDFA4_2059751482 -->|"a"|MiniDFA6_-412576939
MiniDFA6_-412576939 -->|"g"|MiniDFA7_-1347518253
MiniDFA7_-1347518253 -->|"e"|MiniDFA9_-1085121845
MiniDFA9_-1085121845 -->|"C"|MiniDFA1_-256238911
MiniDFA1_-256238911 -->|"u"|MiniDFA10_-638328579
MiniDFA10_-638328579 -->|"b"|MiniDFA8_-754660318
MiniDFA8_-754660318 -->|"e"|MiniDFA11_624838850
MiniDFA11_624838850 -->|"A"|MiniDFA12_1865787337
MiniDFA12_1865787337 -->|"r"|MiniDFA13_439245606
MiniDFA13_439245606 -->|"r"|MiniDFA5_-61777580
MiniDFA5_-61777580 -->|"a"|MiniDFA14_1403458959
MiniDFA14_1403458959 -->|"y"|MiniDFA15_1444952458
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
MiniDFA0_-1566907249(["MiniDFA0 {1}"])
MiniDFA2_780208008(["MiniDFA2 {1}"])
MiniDFA3_-925314152(["MiniDFA3 {1}"])
MiniDFA4_2059751482(["MiniDFA4 {1}"])
MiniDFA6_-412576939(["MiniDFA6 {1}"])
MiniDFA7_-1347518253(["MiniDFA7 {1}"])
MiniDFA9_-1085121845(["MiniDFA9 {1}"])
MiniDFA1_-256238911(["MiniDFA1 {1}"])
MiniDFA10_-638328579(["MiniDFA10 {1}"])
MiniDFA8_-754660318(["MiniDFA8 {1}"])
MiniDFA11_624838850(["MiniDFA11 {1}"])
MiniDFA12_1865787337(["MiniDFA12 {1}"])
MiniDFA13_439245606(["MiniDFA13 {1}"])
MiniDFA5_-61777580(["MiniDFA5 {1}"])
MiniDFA14_1403458959(["MiniDFA14 {1}"])
MiniDFA15_1444952458[\"MiniDFA15 {1}"/]
MiniDFA0_-1566907249 -->|"u"|MiniDFA2_780208008
MiniDFA2_780208008 -->|"i"|MiniDFA3_-925314152
MiniDFA3_-925314152 -->|"m"|MiniDFA4_2059751482
MiniDFA4_2059751482 -->|"a"|MiniDFA6_-412576939
MiniDFA6_-412576939 -->|"g"|MiniDFA7_-1347518253
MiniDFA7_-1347518253 -->|"e"|MiniDFA9_-1085121845
MiniDFA9_-1085121845 -->|"C"|MiniDFA1_-256238911
MiniDFA1_-256238911 -->|"u"|MiniDFA10_-638328579
MiniDFA10_-638328579 -->|"b"|MiniDFA8_-754660318
MiniDFA8_-754660318 -->|"e"|MiniDFA11_624838850
MiniDFA11_624838850 -->|"A"|MiniDFA12_1865787337
MiniDFA12_1865787337 -->|"r"|MiniDFA13_439245606
MiniDFA13_439245606 -->|"r"|MiniDFA5_-61777580
MiniDFA5_-61777580 -->|"a"|MiniDFA14_1403458959
MiniDFA14_1403458959 -->|"y"|MiniDFA15_1444952458
```
-------------------------------
