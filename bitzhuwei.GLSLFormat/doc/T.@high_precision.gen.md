# 'high_precision'

pattern: `high_precision`

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
eNFA193_28_27493275[["εNFA193-28 regex start"]]
eNFA193_0_46112886[["εNFA193-0 char{1, 1}"]]
eNFA193_1_12362796[["εNFA193-1 char[1]"]]
eNFA193_2_44156300[["εNFA193-2 char{1, 1}"]]
eNFA193_3_61862385[["εNFA193-3 char[1]"]]
eNFA193_4_19890554[["εNFA193-4 char{1, 1}"]]
eNFA193_5_44797266[["εNFA193-5 char[1]"]]
eNFA193_6_522217[["εNFA193-6 char{1, 1}"]]
eNFA193_7_4699961[["εNFA193-7 char[1]"]]
eNFA193_8_42299649[["εNFA193-8 char{1, 1}"]]
eNFA193_9_45152523[["εNFA193-9 char[1]"]]
eNFA193_10_3719529[["εNFA193-10 char{1, 1}"]]
eNFA193_11_33475762[["εNFA193-11 char[1]"]]
eNFA193_12_32846409[["εNFA193-12 char{1, 1}"]]
eNFA193_13_27182230[["εNFA193-13 char[1]"]]
eNFA193_14_43313482[["εNFA193-14 char{1, 1}"]]
eNFA193_15_54277022[["εNFA193-15 char[1]"]]
eNFA193_16_18731155[["εNFA193-16 char{1, 1}"]]
eNFA193_17_34362675[["εNFA193-17 char[1]"]]
eNFA193_18_40828621[["εNFA193-18 char{1, 1}"]]
eNFA193_19_31913276[["εNFA193-19 char[1]"]]
eNFA193_20_18784032[["εNFA193-20 char{1, 1}"]]
eNFA193_21_34838562[["εNFA193-21 char[1]"]]
eNFA193_22_45111603[["εNFA193-22 char{1, 1}"]]
eNFA193_23_3351244[["εNFA193-23 char[1]"]]
eNFA193_24_30161198[["εNFA193-24 char{1, 1}"]]
eNFA193_25_3015330[["εNFA193-25 char[1]"]]
eNFA193_26_27137978[["εNFA193-26 char{1, 1}"]]
eNFA193_27_42915214[["εNFA193-27 char[1]"]]
eNFA193_29_50692606[["εNFA193-29 regex end"]]
eNFA193_30_53580277[["εNFA193-30 post-regex start"]]
eNFA193_31_12460451[\"εNFA193-31 post-regex end"/]
eNFA193_28_27493275 -.->|"ε"|eNFA193_0_46112886
eNFA193_0_46112886 -->|"h"|eNFA193_1_12362796
eNFA193_1_12362796 -.->|"ε"|eNFA193_2_44156300
eNFA193_2_44156300 -->|"i"|eNFA193_3_61862385
eNFA193_3_61862385 -.->|"ε"|eNFA193_4_19890554
eNFA193_4_19890554 -->|"g"|eNFA193_5_44797266
eNFA193_5_44797266 -.->|"ε"|eNFA193_6_522217
eNFA193_6_522217 -->|"h"|eNFA193_7_4699961
eNFA193_7_4699961 -.->|"ε"|eNFA193_8_42299649
eNFA193_8_42299649 -->|"_"|eNFA193_9_45152523
eNFA193_9_45152523 -.->|"ε"|eNFA193_10_3719529
eNFA193_10_3719529 -->|"p"|eNFA193_11_33475762
eNFA193_11_33475762 -.->|"ε"|eNFA193_12_32846409
eNFA193_12_32846409 -->|"r"|eNFA193_13_27182230
eNFA193_13_27182230 -.->|"ε"|eNFA193_14_43313482
eNFA193_14_43313482 -->|"e"|eNFA193_15_54277022
eNFA193_15_54277022 -.->|"ε"|eNFA193_16_18731155
eNFA193_16_18731155 -->|"c"|eNFA193_17_34362675
eNFA193_17_34362675 -.->|"ε"|eNFA193_18_40828621
eNFA193_18_40828621 -->|"i"|eNFA193_19_31913276
eNFA193_19_31913276 -.->|"ε"|eNFA193_20_18784032
eNFA193_20_18784032 -->|"s"|eNFA193_21_34838562
eNFA193_21_34838562 -.->|"ε"|eNFA193_22_45111603
eNFA193_22_45111603 -->|"i"|eNFA193_23_3351244
eNFA193_23_3351244 -.->|"ε"|eNFA193_24_30161198
eNFA193_24_30161198 -->|"o"|eNFA193_25_3015330
eNFA193_25_3015330 -.->|"ε"|eNFA193_26_27137978
eNFA193_26_27137978 -->|"n"|eNFA193_27_42915214
eNFA193_27_42915214 -.->|"ε"|eNFA193_29_50692606
eNFA193_29_50692606 -.->|"ε"|eNFA193_30_53580277
eNFA193_30_53580277 -.->|"ε"|eNFA193_31_12460451
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
eNFA193_28_45035201[["εNFA193-28 regex start"]]
eNFA193_0_2663633[["εNFA193-0 char{1, 1}"]]
eNFA193_1_23972698[["εNFA193-1 char[1]"]]
eNFA193_2_14427695[["εNFA193-2 char{1, 1}"]]
eNFA193_3_62740391[["εNFA193-3 char[1]"]]
eNFA193_4_27792613[["εNFA193-4 char{1, 1}"]]
eNFA193_5_48806929[["εNFA193-5 char[1]"]]
eNFA193_6_36609180[["εNFA193-6 char{1, 1}"]]
eNFA193_7_61047167[["εNFA193-7 char[1]"]]
eNFA193_8_12553595[["εNFA193-8 char{1, 1}"]]
eNFA193_9_45873498[["εNFA193-9 char[1]"]]
eNFA193_10_10208299[["εNFA193-10 char{1, 1}"]]
eNFA193_11_24765833[["εNFA193-11 char[1]"]]
eNFA193_12_21565908[["εNFA193-12 char{1, 1}"]]
eNFA193_13_59875445[["εNFA193-13 char[1]"]]
eNFA193_14_2008093[["εNFA193-14 char{1, 1}"]]
eNFA193_15_18072837[["εNFA193-15 char[1]"]]
eNFA193_16_28437806[["εNFA193-16 char{1, 1}"]]
eNFA193_17_54613665[["εNFA193-17 char[1]"]]
eNFA193_18_21760944[["εNFA193-18 char{1, 1}"]]
eNFA193_19_61630770[["εNFA193-19 char[1]"]]
eNFA193_20_17806026[["εNFA193-20 char{1, 1}"]]
eNFA193_21_26036512[["εNFA193-21 char[1]"]]
eNFA193_22_33002021[["εNFA193-22 char{1, 1}"]]
eNFA193_23_28582738[["εNFA193-23 char[1]"]]
eNFA193_24_55918057[["εNFA193-24 char{1, 1}"]]
eNFA193_25_33500465[["εNFA193-25 char[1]"]]
eNFA193_26_33068732[["εNFA193-26 char{1, 1}"]]
eNFA193_27_29183140[\"εNFA193-27 char[1]"/]
eNFA193_29_61321673[\"εNFA193-29 regex end"/]
eNFA193_30_15024148[\"εNFA193-30 post-regex start"/]
eNFA193_31_999606[\"εNFA193-31 post-regex end"/]
eNFA193_28_45035201 -.->|"ε"|eNFA193_0_2663633
eNFA193_28_45035201 -->|"h"|eNFA193_1_23972698
eNFA193_0_2663633 -->|"h"|eNFA193_1_23972698
eNFA193_1_23972698 -.->|"ε"|eNFA193_2_14427695
eNFA193_1_23972698 -->|"i"|eNFA193_3_62740391
eNFA193_2_14427695 -->|"i"|eNFA193_3_62740391
eNFA193_3_62740391 -.->|"ε"|eNFA193_4_27792613
eNFA193_3_62740391 -->|"g"|eNFA193_5_48806929
eNFA193_4_27792613 -->|"g"|eNFA193_5_48806929
eNFA193_5_48806929 -.->|"ε"|eNFA193_6_36609180
eNFA193_5_48806929 -->|"h"|eNFA193_7_61047167
eNFA193_6_36609180 -->|"h"|eNFA193_7_61047167
eNFA193_7_61047167 -.->|"ε"|eNFA193_8_12553595
eNFA193_7_61047167 -->|"_"|eNFA193_9_45873498
eNFA193_8_12553595 -->|"_"|eNFA193_9_45873498
eNFA193_9_45873498 -.->|"ε"|eNFA193_10_10208299
eNFA193_9_45873498 -->|"p"|eNFA193_11_24765833
eNFA193_10_10208299 -->|"p"|eNFA193_11_24765833
eNFA193_11_24765833 -.->|"ε"|eNFA193_12_21565908
eNFA193_11_24765833 -->|"r"|eNFA193_13_59875445
eNFA193_12_21565908 -->|"r"|eNFA193_13_59875445
eNFA193_13_59875445 -.->|"ε"|eNFA193_14_2008093
eNFA193_13_59875445 -->|"e"|eNFA193_15_18072837
eNFA193_14_2008093 -->|"e"|eNFA193_15_18072837
eNFA193_15_18072837 -.->|"ε"|eNFA193_16_28437806
eNFA193_15_18072837 -->|"c"|eNFA193_17_54613665
eNFA193_16_28437806 -->|"c"|eNFA193_17_54613665
eNFA193_17_54613665 -.->|"ε"|eNFA193_18_21760944
eNFA193_17_54613665 -->|"i"|eNFA193_19_61630770
eNFA193_18_21760944 -->|"i"|eNFA193_19_61630770
eNFA193_19_61630770 -.->|"ε"|eNFA193_20_17806026
eNFA193_19_61630770 -->|"s"|eNFA193_21_26036512
eNFA193_20_17806026 -->|"s"|eNFA193_21_26036512
eNFA193_21_26036512 -.->|"ε"|eNFA193_22_33002021
eNFA193_21_26036512 -->|"i"|eNFA193_23_28582738
eNFA193_22_33002021 -->|"i"|eNFA193_23_28582738
eNFA193_23_28582738 -.->|"ε"|eNFA193_24_55918057
eNFA193_23_28582738 -->|"o"|eNFA193_25_33500465
eNFA193_24_55918057 -->|"o"|eNFA193_25_33500465
eNFA193_25_33500465 -.->|"ε"|eNFA193_26_33068732
eNFA193_25_33500465 -->|"n"|eNFA193_27_29183140
eNFA193_26_33068732 -->|"n"|eNFA193_27_29183140
eNFA193_27_29183140 -.->|"ε"|eNFA193_29_61321673
eNFA193_27_29183140 -.->|"ε"|eNFA193_30_15024148
eNFA193_27_29183140 -.->|"ε"|eNFA193_31_999606
eNFA193_29_61321673 -.->|"ε"|eNFA193_30_15024148
eNFA193_29_61321673 -.->|"ε"|eNFA193_31_999606
eNFA193_30_15024148 -.->|"ε"|eNFA193_31_999606
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
NFA193_28_8996456("NFA193-28 regex start")
NFA193_1_13859243("NFA193-1 char[1]")
NFA193_3_57624329("NFA193-3 char[1]")
NFA193_5_48856913("NFA193-5 char[1]")
NFA193_7_37059038("NFA193-7 char[1]")
NFA193_9_65095887("NFA193-9 char[1]")
NFA193_11_48992079("NFA193-11 char[1]")
NFA193_13_38275534("NFA193-13 char[1]")
NFA193_15_8935494("NFA193-15 char[1]")
NFA193_17_13310582("NFA193-17 char[1]")
NFA193_19_52686376("NFA193-19 char[1]")
NFA193_21_4415342("NFA193-21 char[1]")
NFA193_23_39738079("NFA193-23 char[1]")
NFA193_25_22098398("NFA193-25 char[1]")
NFA193_27_64667859[\"NFA193-27 char[1]"/]
NFA193_28_8996456 -->|"h"|NFA193_1_13859243
NFA193_1_13859243 -->|"i"|NFA193_3_57624329
NFA193_3_57624329 -->|"g"|NFA193_5_48856913
NFA193_5_48856913 -->|"h"|NFA193_7_37059038
NFA193_7_37059038 -->|"_"|NFA193_9_65095887
NFA193_9_65095887 -->|"p"|NFA193_11_48992079
NFA193_11_48992079 -->|"r"|NFA193_13_38275534
NFA193_13_38275534 -->|"e"|NFA193_15_8935494
NFA193_15_8935494 -->|"c"|NFA193_17_13310582
NFA193_17_13310582 -->|"i"|NFA193_19_52686376
NFA193_19_52686376 -->|"s"|NFA193_21_4415342
NFA193_21_4415342 -->|"i"|NFA193_23_39738079
NFA193_23_39738079 -->|"o"|NFA193_25_22098398
NFA193_25_22098398 -->|"n"|NFA193_27_64667859
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
subgraph DFA0_1832109878["DFA0 regex start"]
NFA193_28_8996456_0("NFA193-28 regex start")
end
subgraph DFA1_-1317903625["DFA1 {1}"]
NFA193_1_13859243_1("NFA193-1 char[1]")
end
subgraph DFA2_1213134455["DFA2 {1}"]
NFA193_3_57624329_2("NFA193-3 char[1]")
end
subgraph DFA3_1604300164["DFA3 {1}"]
NFA193_5_48856913_3("NFA193-5 char[1]")
end
subgraph DFA4_-1802397837["DFA4 {1}"]
NFA193_7_37059038_4("NFA193-7 char[1]")
end
subgraph DFA5_1827691527["DFA5 {1}"]
NFA193_9_65095887_5("NFA193-9 char[1]")
end
subgraph DFA6_-1384848678["DFA6 {1}"]
NFA193_11_48992079_6("NFA193-11 char[1]")
end
subgraph DFA7_593588424["DFA7 {1}"]
NFA193_13_38275534_7("NFA193-13 char[1]")
end
subgraph DFA8_-501938756["DFA8 {1}"]
NFA193_15_8935494_8("NFA193-15 char[1]")
end
subgraph DFA9_-384723093["DFA9 {1}"]
NFA193_17_13310582_9("NFA193-17 char[1]")
end
subgraph DFA10_-318814694["DFA10 {1}"]
NFA193_19_52686376_10("NFA193-19 char[1]")
end
subgraph DFA11_-66058242["DFA11 {1}"]
NFA193_21_4415342_11("NFA193-21 char[1]")
end
subgraph DFA12_779618654["DFA12 {1}"]
NFA193_23_39738079_12("NFA193-23 char[1]")
end
subgraph DFA13_-1333418114["DFA13 {1}"]
NFA193_25_22098398_13("NFA193-25 char[1]")
end
subgraph DFA14_210070325["DFA14 {1}"]
NFA193_27_64667859_14[\"NFA193-27 char[1]"/]
end
DFA0_1832109878 -->|"h"|DFA1_-1317903625
DFA1_-1317903625 -->|"i"|DFA2_1213134455
DFA2_1213134455 -->|"g"|DFA3_1604300164
DFA3_1604300164 -->|"h"|DFA4_-1802397837
DFA4_-1802397837 -->|"_"|DFA5_1827691527
DFA5_1827691527 -->|"p"|DFA6_-1384848678
DFA6_-1384848678 -->|"r"|DFA7_593588424
DFA7_593588424 -->|"e"|DFA8_-501938756
DFA8_-501938756 -->|"c"|DFA9_-384723093
DFA9_-384723093 -->|"i"|DFA10_-318814694
DFA10_-318814694 -->|"s"|DFA11_-66058242
DFA11_-66058242 -->|"i"|DFA12_779618654
DFA12_779618654 -->|"o"|DFA13_-1333418114
DFA13_-1333418114 -->|"n"|DFA14_210070325
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
DFA0_1832109878{{"DFA0 regex start"}}
DFA1_-1317903625{{"DFA1 {1}"}}
DFA2_1213134455{{"DFA2 {1}"}}
DFA3_1604300164{{"DFA3 {1}"}}
DFA4_-1802397837{{"DFA4 {1}"}}
DFA5_1827691527{{"DFA5 {1}"}}
DFA6_-1384848678{{"DFA6 {1}"}}
DFA7_593588424{{"DFA7 {1}"}}
DFA8_-501938756{{"DFA8 {1}"}}
DFA9_-384723093{{"DFA9 {1}"}}
DFA10_-318814694{{"DFA10 {1}"}}
DFA11_-66058242{{"DFA11 {1}"}}
DFA12_779618654{{"DFA12 {1}"}}
DFA13_-1333418114{{"DFA13 {1}"}}
DFA14_210070325[\"DFA14 {1}"/]
DFA0_1832109878 -->|"h"|DFA1_-1317903625
DFA1_-1317903625 -->|"i"|DFA2_1213134455
DFA2_1213134455 -->|"g"|DFA3_1604300164
DFA3_1604300164 -->|"h"|DFA4_-1802397837
DFA4_-1802397837 -->|"_"|DFA5_1827691527
DFA5_1827691527 -->|"p"|DFA6_-1384848678
DFA6_-1384848678 -->|"r"|DFA7_593588424
DFA7_593588424 -->|"e"|DFA8_-501938756
DFA8_-501938756 -->|"c"|DFA9_-384723093
DFA9_-384723093 -->|"i"|DFA10_-318814694
DFA10_-318814694 -->|"s"|DFA11_-66058242
DFA11_-66058242 -->|"i"|DFA12_779618654
DFA12_779618654 -->|"o"|DFA13_-1333418114
DFA13_-1333418114 -->|"n"|DFA14_210070325
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
subgraph MiniDFA0_1136440737["MiniDFA0 {1}"]
DFA0_1832109878_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_1258370840["MiniDFA2 {1}"]
DFA1_-1317903625_1{{"DFA1 {1}"}}
end
subgraph MiniDFA5_95039733["MiniDFA5 {1}"]
DFA2_1213134455_2{{"DFA2 {1}"}}
end
subgraph MiniDFA1_1385382376["MiniDFA1 {1}"]
DFA3_1604300164_3{{"DFA3 {1}"}}
end
subgraph MiniDFA6_1809131475["MiniDFA6 {1}"]
DFA4_-1802397837_4{{"DFA4 {1}"}}
end
subgraph MiniDFA7_1767423530["MiniDFA7 {1}"]
DFA5_1827691527_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_1441516626["MiniDFA8 {1}"]
DFA6_-1384848678_6{{"DFA6 {1}"}}
end
subgraph MiniDFA9_667688646["MiniDFA9 {1}"]
DFA7_593588424_7{{"DFA7 {1}"}}
end
subgraph MiniDFA10_1740040983["MiniDFA10 {1}"]
DFA8_-501938756_8{{"DFA8 {1}"}}
end
subgraph MiniDFA3_2063119316["MiniDFA3 {1}"]
DFA9_-384723093_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-1479445789["MiniDFA11 {1}"]
DFA10_-318814694_10{{"DFA10 {1}"}}
end
subgraph MiniDFA4_330643615["MiniDFA4 {1}"]
DFA11_-66058242_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1069242959["MiniDFA12 {1}"]
DFA12_779618654_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1365918882["MiniDFA13 {1}"]
DFA13_-1333418114_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-41207735["MiniDFA14 {1}"]
DFA14_210070325_14[\"DFA14 {1}"/]
end
MiniDFA0_1136440737 -->|"h"|MiniDFA2_1258370840
MiniDFA2_1258370840 -->|"i"|MiniDFA5_95039733
MiniDFA5_95039733 -->|"g"|MiniDFA1_1385382376
MiniDFA1_1385382376 -->|"h"|MiniDFA6_1809131475
MiniDFA6_1809131475 -->|"_"|MiniDFA7_1767423530
MiniDFA7_1767423530 -->|"p"|MiniDFA8_1441516626
MiniDFA8_1441516626 -->|"r"|MiniDFA9_667688646
MiniDFA9_667688646 -->|"e"|MiniDFA10_1740040983
MiniDFA10_1740040983 -->|"c"|MiniDFA3_2063119316
MiniDFA3_2063119316 -->|"i"|MiniDFA11_-1479445789
MiniDFA11_-1479445789 -->|"s"|MiniDFA4_330643615
MiniDFA4_330643615 -->|"i"|MiniDFA12_-1069242959
MiniDFA12_-1069242959 -->|"o"|MiniDFA13_-1365918882
MiniDFA13_-1365918882 -->|"n"|MiniDFA14_-41207735
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
MiniDFA0_1136440737(["MiniDFA0 {1}"])
MiniDFA2_1258370840(["MiniDFA2 {1}"])
MiniDFA5_95039733(["MiniDFA5 {1}"])
MiniDFA1_1385382376(["MiniDFA1 {1}"])
MiniDFA6_1809131475(["MiniDFA6 {1}"])
MiniDFA7_1767423530(["MiniDFA7 {1}"])
MiniDFA8_1441516626(["MiniDFA8 {1}"])
MiniDFA9_667688646(["MiniDFA9 {1}"])
MiniDFA10_1740040983(["MiniDFA10 {1}"])
MiniDFA3_2063119316(["MiniDFA3 {1}"])
MiniDFA11_-1479445789(["MiniDFA11 {1}"])
MiniDFA4_330643615(["MiniDFA4 {1}"])
MiniDFA12_-1069242959(["MiniDFA12 {1}"])
MiniDFA13_-1365918882(["MiniDFA13 {1}"])
MiniDFA14_-41207735[\"MiniDFA14 {1}"/]
MiniDFA0_1136440737 -->|"h"|MiniDFA2_1258370840
MiniDFA2_1258370840 -->|"i"|MiniDFA5_95039733
MiniDFA5_95039733 -->|"g"|MiniDFA1_1385382376
MiniDFA1_1385382376 -->|"h"|MiniDFA6_1809131475
MiniDFA6_1809131475 -->|"_"|MiniDFA7_1767423530
MiniDFA7_1767423530 -->|"p"|MiniDFA8_1441516626
MiniDFA8_1441516626 -->|"r"|MiniDFA9_667688646
MiniDFA9_667688646 -->|"e"|MiniDFA10_1740040983
MiniDFA10_1740040983 -->|"c"|MiniDFA3_2063119316
MiniDFA3_2063119316 -->|"i"|MiniDFA11_-1479445789
MiniDFA11_-1479445789 -->|"s"|MiniDFA4_330643615
MiniDFA4_330643615 -->|"i"|MiniDFA12_-1069242959
MiniDFA12_-1069242959 -->|"o"|MiniDFA13_-1365918882
MiniDFA13_-1365918882 -->|"n"|MiniDFA14_-41207735
```
-------------------------------
