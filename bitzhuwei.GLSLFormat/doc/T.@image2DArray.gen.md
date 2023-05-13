# 'image2DArray'

pattern: `image2DArray`

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
eNFA181_24_18887371[["εNFA181-24 regex start"]]
eNFA181_0_35768611[["εNFA181-0 char{1, 1}"]]
eNFA181_1_53482049[["εNFA181-1 char[1]"]]
eNFA181_2_11576397[["εNFA181-2 char{1, 1}"]]
eNFA181_3_37078712[["εNFA181-3 char[1]"]]
eNFA181_4_65272955[["εNFA181-4 char{1, 1}"]]
eNFA181_5_50585687[["εNFA181-5 char[1]"]]
eNFA181_6_52618006[["εNFA181-6 char{1, 1}"]]
eNFA181_7_3800007[["εNFA181-7 char[1]"]]
eNFA181_8_34200069[["εNFA181-8 char{1, 1}"]]
eNFA181_9_39365168[["εNFA181-9 char[1]"]]
eNFA181_10_18742193[["εNFA181-10 char{1, 1}"]]
eNFA181_11_34462009[["εNFA181-11 char[1]"]]
eNFA181_12_41722625[["εNFA181-12 char{1, 1}"]]
eNFA181_13_39959306[["εNFA181-13 char[1]"]]
eNFA181_14_24089437[["εNFA181-14 char{1, 1}"]]
eNFA181_15_15478348[["εNFA181-15 char[1]"]]
eNFA181_16_5087406[["εNFA181-16 char{1, 1}"]]
eNFA181_17_45786662[["εNFA181-17 char[1]"]]
eNFA181_18_9426780[["εNFA181-18 char{1, 1}"]]
eNFA181_19_17732161[["εNFA181-19 char[1]"]]
eNFA181_20_25371726[["εNFA181-20 char{1, 1}"]]
eNFA181_21_27018949[["εNFA181-21 char[1]"]]
eNFA181_22_41843949[["εNFA181-22 char{1, 1}"]]
eNFA181_23_41051224[["εNFA181-23 char[1]"]]
eNFA181_25_33916704[["εNFA181-25 regex end"]]
eNFA181_26_36814885[["εNFA181-26 post-regex start"]]
eNFA181_27_62898512[\"εNFA181-27 post-regex end"/]
eNFA181_24_18887371 -.->|"ε"|eNFA181_0_35768611
eNFA181_0_35768611 -->|"i"|eNFA181_1_53482049
eNFA181_1_53482049 -.->|"ε"|eNFA181_2_11576397
eNFA181_2_11576397 -->|"m"|eNFA181_3_37078712
eNFA181_3_37078712 -.->|"ε"|eNFA181_4_65272955
eNFA181_4_65272955 -->|"a"|eNFA181_5_50585687
eNFA181_5_50585687 -.->|"ε"|eNFA181_6_52618006
eNFA181_6_52618006 -->|"g"|eNFA181_7_3800007
eNFA181_7_3800007 -.->|"ε"|eNFA181_8_34200069
eNFA181_8_34200069 -->|"e"|eNFA181_9_39365168
eNFA181_9_39365168 -.->|"ε"|eNFA181_10_18742193
eNFA181_10_18742193 -->|"2"|eNFA181_11_34462009
eNFA181_11_34462009 -.->|"ε"|eNFA181_12_41722625
eNFA181_12_41722625 -->|"D"|eNFA181_13_39959306
eNFA181_13_39959306 -.->|"ε"|eNFA181_14_24089437
eNFA181_14_24089437 -->|"A"|eNFA181_15_15478348
eNFA181_15_15478348 -.->|"ε"|eNFA181_16_5087406
eNFA181_16_5087406 -->|"r"|eNFA181_17_45786662
eNFA181_17_45786662 -.->|"ε"|eNFA181_18_9426780
eNFA181_18_9426780 -->|"r"|eNFA181_19_17732161
eNFA181_19_17732161 -.->|"ε"|eNFA181_20_25371726
eNFA181_20_25371726 -->|"a"|eNFA181_21_27018949
eNFA181_21_27018949 -.->|"ε"|eNFA181_22_41843949
eNFA181_22_41843949 -->|"y"|eNFA181_23_41051224
eNFA181_23_41051224 -.->|"ε"|eNFA181_25_33916704
eNFA181_25_33916704 -.->|"ε"|eNFA181_26_36814885
eNFA181_26_36814885 -.->|"ε"|eNFA181_27_62898512
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
eNFA181_24_29215698[["εNFA181-24 regex start"]]
eNFA181_0_61614692[["εNFA181-0 char{1, 1}"]]
eNFA181_1_17661319[["εNFA181-1 char[1]"]]
eNFA181_2_24734149[["εNFA181-2 char{1, 1}"]]
eNFA181_3_21280749[["εNFA181-3 char[1]"]]
eNFA181_4_57309018[["εNFA181-4 char{1, 1}"]]
eNFA181_5_46019115[["εNFA181-5 char[1]"]]
eNFA181_6_11518859[["εNFA181-6 char{1, 1}"]]
eNFA181_7_36560874[["εNFA181-7 char[1]"]]
eNFA181_8_60612418[["εNFA181-8 char{1, 1}"]]
eNFA181_9_8640850[["εNFA181-9 char[1]"]]
eNFA181_10_10658788[["εNFA181-10 char{1, 1}"]]
eNFA181_11_28820234[["εNFA181-11 char[1]"]]
eNFA181_12_58055515[["εNFA181-12 char{1, 1}"]]
eNFA181_13_52737594[["εNFA181-13 char[1]"]]
eNFA181_14_4876303[["εNFA181-14 char{1, 1}"]]
eNFA181_15_43886731[["εNFA181-15 char[1]"]]
eNFA181_16_59436263[["εNFA181-16 char{1, 1}"]]
eNFA181_17_65164324[["εNFA181-17 char[1]"]]
eNFA181_18_49608012[["εNFA181-18 char{1, 1}"]]
eNFA181_19_43818926[["εNFA181-19 char[1]"]]
eNFA181_20_58826021[["εNFA181-20 char{1, 1}"]]
eNFA181_21_59672145[["εNFA181-21 char[1]"]]
eNFA181_22_178395[["εNFA181-22 char{1, 1}"]]
eNFA181_23_1605556[\"εNFA181-23 char[1]"/]
eNFA181_25_14450005[\"εNFA181-25 regex end"/]
eNFA181_26_62941183[\"εNFA181-26 post-regex start"/]
eNFA181_27_29599739[\"εNFA181-27 post-regex end"/]
eNFA181_24_29215698 -.->|"ε"|eNFA181_0_61614692
eNFA181_24_29215698 -->|"i"|eNFA181_1_17661319
eNFA181_0_61614692 -->|"i"|eNFA181_1_17661319
eNFA181_1_17661319 -.->|"ε"|eNFA181_2_24734149
eNFA181_1_17661319 -->|"m"|eNFA181_3_21280749
eNFA181_2_24734149 -->|"m"|eNFA181_3_21280749
eNFA181_3_21280749 -.->|"ε"|eNFA181_4_57309018
eNFA181_3_21280749 -->|"a"|eNFA181_5_46019115
eNFA181_4_57309018 -->|"a"|eNFA181_5_46019115
eNFA181_5_46019115 -.->|"ε"|eNFA181_6_11518859
eNFA181_5_46019115 -->|"g"|eNFA181_7_36560874
eNFA181_6_11518859 -->|"g"|eNFA181_7_36560874
eNFA181_7_36560874 -.->|"ε"|eNFA181_8_60612418
eNFA181_7_36560874 -->|"e"|eNFA181_9_8640850
eNFA181_8_60612418 -->|"e"|eNFA181_9_8640850
eNFA181_9_8640850 -.->|"ε"|eNFA181_10_10658788
eNFA181_9_8640850 -->|"2"|eNFA181_11_28820234
eNFA181_10_10658788 -->|"2"|eNFA181_11_28820234
eNFA181_11_28820234 -.->|"ε"|eNFA181_12_58055515
eNFA181_11_28820234 -->|"D"|eNFA181_13_52737594
eNFA181_12_58055515 -->|"D"|eNFA181_13_52737594
eNFA181_13_52737594 -.->|"ε"|eNFA181_14_4876303
eNFA181_13_52737594 -->|"A"|eNFA181_15_43886731
eNFA181_14_4876303 -->|"A"|eNFA181_15_43886731
eNFA181_15_43886731 -.->|"ε"|eNFA181_16_59436263
eNFA181_15_43886731 -->|"r"|eNFA181_17_65164324
eNFA181_16_59436263 -->|"r"|eNFA181_17_65164324
eNFA181_17_65164324 -.->|"ε"|eNFA181_18_49608012
eNFA181_17_65164324 -->|"r"|eNFA181_19_43818926
eNFA181_18_49608012 -->|"r"|eNFA181_19_43818926
eNFA181_19_43818926 -.->|"ε"|eNFA181_20_58826021
eNFA181_19_43818926 -->|"a"|eNFA181_21_59672145
eNFA181_20_58826021 -->|"a"|eNFA181_21_59672145
eNFA181_21_59672145 -.->|"ε"|eNFA181_22_178395
eNFA181_21_59672145 -->|"y"|eNFA181_23_1605556
eNFA181_22_178395 -->|"y"|eNFA181_23_1605556
eNFA181_23_1605556 -.->|"ε"|eNFA181_25_14450005
eNFA181_23_1605556 -.->|"ε"|eNFA181_26_62941183
eNFA181_23_1605556 -.->|"ε"|eNFA181_27_29599739
eNFA181_25_14450005 -.->|"ε"|eNFA181_26_62941183
eNFA181_25_14450005 -.->|"ε"|eNFA181_27_29599739
eNFA181_26_62941183 -.->|"ε"|eNFA181_27_29599739
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
NFA181_24_65071067("NFA181-24 regex start")
NFA181_1_48768695("NFA181-1 char[1]")
NFA181_3_36265071("NFA181-3 char[1]")
NFA181_5_57950190("NFA181-5 char[1]")
NFA181_7_51789668("NFA181-7 char[1]")
NFA181_9_63453834("NFA181-9 char[1]")
NFA181_11_34213602("NFA181-11 char[1]")
NFA181_13_39486963("NFA181-13 char[1]")
NFA181_15_19838352("NFA181-15 char[1]")
NFA181_17_44327440("NFA181-17 char[1]")
NFA181_19_63402646("NFA181-19 char[1]")
NFA181_21_33752906("NFA181-21 char[1]")
NFA181_23_35340701[\"NFA181-23 char[1]"/]
NFA181_24_65071067 -->|"i"|NFA181_1_48768695
NFA181_1_48768695 -->|"m"|NFA181_3_36265071
NFA181_3_36265071 -->|"a"|NFA181_5_57950190
NFA181_5_57950190 -->|"g"|NFA181_7_51789668
NFA181_7_51789668 -->|"e"|NFA181_9_63453834
NFA181_9_63453834 -->|"2"|NFA181_11_34213602
NFA181_11_34213602 -->|"D"|NFA181_13_39486963
NFA181_13_39486963 -->|"A"|NFA181_15_19838352
NFA181_15_19838352 -->|"r"|NFA181_17_44327440
NFA181_17_44327440 -->|"r"|NFA181_19_63402646
NFA181_19_63402646 -->|"a"|NFA181_21_33752906
NFA181_21_33752906 -->|"y"|NFA181_23_35340701
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
subgraph DFA0_-1588742592["DFA0 regex start"]
NFA181_24_65071067_0("NFA181-24 regex start")
end
subgraph DFA1_-409801384["DFA1 {1}"]
NFA181_1_48768695_1("NFA181-1 char[1]")
end
subgraph DFA2_1703264317["DFA2 {1}"]
NFA181_3_36265071_2("NFA181-3 char[1]")
end
subgraph DFA3_-1970044764["DFA3 {1}"]
NFA181_5_57950190_3("NFA181-5 char[1]")
end
subgraph DFA4_-1220774034["DFA4 {1}"]
NFA181_7_51789668_4("NFA181-7 char[1]")
end
subgraph DFA5_-866871421["DFA5 {1}"]
NFA181_9_63453834_5("NFA181-9 char[1]")
end
subgraph DFA6_334259498["DFA6 {1}"]
NFA181_11_34213602_6("NFA181-11 char[1]")
end
subgraph DFA7_-1417026936["DFA7 {1}"]
NFA181_13_39486963_7("NFA181-13 char[1]")
end
subgraph DFA8_-2018348716["DFA8 {1}"]
NFA181_15_19838352_8("NFA181-15 char[1]")
end
subgraph DFA9_-1554304916["DFA9 {1}"]
NFA181_17_44327440_9("NFA181-17 char[1]")
end
subgraph DFA10_-340890485["DFA10 {1}"]
NFA181_19_63402646_10("NFA181-19 char[1]")
end
subgraph DFA11_913423113["DFA11 {1}"]
NFA181_21_33752906_11("NFA181-21 char[1]")
end
subgraph DFA12_-1928220389["DFA12 {1}"]
NFA181_23_35340701_12[\"NFA181-23 char[1]"/]
end
DFA0_-1588742592 -->|"i"|DFA1_-409801384
DFA1_-409801384 -->|"m"|DFA2_1703264317
DFA2_1703264317 -->|"a"|DFA3_-1970044764
DFA3_-1970044764 -->|"g"|DFA4_-1220774034
DFA4_-1220774034 -->|"e"|DFA5_-866871421
DFA5_-866871421 -->|"2"|DFA6_334259498
DFA6_334259498 -->|"D"|DFA7_-1417026936
DFA7_-1417026936 -->|"A"|DFA8_-2018348716
DFA8_-2018348716 -->|"r"|DFA9_-1554304916
DFA9_-1554304916 -->|"r"|DFA10_-340890485
DFA10_-340890485 -->|"a"|DFA11_913423113
DFA11_913423113 -->|"y"|DFA12_-1928220389
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
DFA0_-1588742592{{"DFA0 regex start"}}
DFA1_-409801384{{"DFA1 {1}"}}
DFA2_1703264317{{"DFA2 {1}"}}
DFA3_-1970044764{{"DFA3 {1}"}}
DFA4_-1220774034{{"DFA4 {1}"}}
DFA5_-866871421{{"DFA5 {1}"}}
DFA6_334259498{{"DFA6 {1}"}}
DFA7_-1417026936{{"DFA7 {1}"}}
DFA8_-2018348716{{"DFA8 {1}"}}
DFA9_-1554304916{{"DFA9 {1}"}}
DFA10_-340890485{{"DFA10 {1}"}}
DFA11_913423113{{"DFA11 {1}"}}
DFA12_-1928220389[\"DFA12 {1}"/]
DFA0_-1588742592 -->|"i"|DFA1_-409801384
DFA1_-409801384 -->|"m"|DFA2_1703264317
DFA2_1703264317 -->|"a"|DFA3_-1970044764
DFA3_-1970044764 -->|"g"|DFA4_-1220774034
DFA4_-1220774034 -->|"e"|DFA5_-866871421
DFA5_-866871421 -->|"2"|DFA6_334259498
DFA6_334259498 -->|"D"|DFA7_-1417026936
DFA7_-1417026936 -->|"A"|DFA8_-2018348716
DFA8_-2018348716 -->|"r"|DFA9_-1554304916
DFA9_-1554304916 -->|"r"|DFA10_-340890485
DFA10_-340890485 -->|"a"|DFA11_913423113
DFA11_913423113 -->|"y"|DFA12_-1928220389
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
subgraph MiniDFA0_504780259["MiniDFA0 {1}"]
DFA0_-1588742592_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1465788330["MiniDFA1 {1}"]
DFA1_-409801384_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_877721636["MiniDFA2 {1}"]
DFA2_1703264317_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-1034597025["MiniDFA4 {1}"]
DFA3_-1970044764_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_928127144["MiniDFA5 {1}"]
DFA4_-1220774034_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-890103782["MiniDFA6 {1}"]
DFA5_-866871421_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1094696181["MiniDFA7 {1}"]
DFA6_334259498_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1114311988["MiniDFA8 {1}"]
DFA7_-1417026936_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_15885241["MiniDFA9 {1}"]
DFA8_-2018348716_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-878623421["MiniDFA10 {1}"]
DFA9_-1554304916_9{{"DFA9 {1}"}}
end
subgraph MiniDFA3_1885579528["MiniDFA3 {1}"]
DFA10_-340890485_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_2020061616["MiniDFA11 {1}"]
DFA11_913423113_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1309443540["MiniDFA12 {1}"]
DFA12_-1928220389_12[\"DFA12 {1}"/]
end
MiniDFA0_504780259 -->|"i"|MiniDFA1_1465788330
MiniDFA1_1465788330 -->|"m"|MiniDFA2_877721636
MiniDFA2_877721636 -->|"a"|MiniDFA4_-1034597025
MiniDFA4_-1034597025 -->|"g"|MiniDFA5_928127144
MiniDFA5_928127144 -->|"e"|MiniDFA6_-890103782
MiniDFA6_-890103782 -->|"2"|MiniDFA7_-1094696181
MiniDFA7_-1094696181 -->|"D"|MiniDFA8_1114311988
MiniDFA8_1114311988 -->|"A"|MiniDFA9_15885241
MiniDFA9_15885241 -->|"r"|MiniDFA10_-878623421
MiniDFA10_-878623421 -->|"r"|MiniDFA3_1885579528
MiniDFA3_1885579528 -->|"a"|MiniDFA11_2020061616
MiniDFA11_2020061616 -->|"y"|MiniDFA12_-1309443540
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
MiniDFA0_504780259(["MiniDFA0 {1}"])
MiniDFA1_1465788330(["MiniDFA1 {1}"])
MiniDFA2_877721636(["MiniDFA2 {1}"])
MiniDFA4_-1034597025(["MiniDFA4 {1}"])
MiniDFA5_928127144(["MiniDFA5 {1}"])
MiniDFA6_-890103782(["MiniDFA6 {1}"])
MiniDFA7_-1094696181(["MiniDFA7 {1}"])
MiniDFA8_1114311988(["MiniDFA8 {1}"])
MiniDFA9_15885241(["MiniDFA9 {1}"])
MiniDFA10_-878623421(["MiniDFA10 {1}"])
MiniDFA3_1885579528(["MiniDFA3 {1}"])
MiniDFA11_2020061616(["MiniDFA11 {1}"])
MiniDFA12_-1309443540[\"MiniDFA12 {1}"/]
MiniDFA0_504780259 -->|"i"|MiniDFA1_1465788330
MiniDFA1_1465788330 -->|"m"|MiniDFA2_877721636
MiniDFA2_877721636 -->|"a"|MiniDFA4_-1034597025
MiniDFA4_-1034597025 -->|"g"|MiniDFA5_928127144
MiniDFA5_928127144 -->|"e"|MiniDFA6_-890103782
MiniDFA6_-890103782 -->|"2"|MiniDFA7_-1094696181
MiniDFA7_-1094696181 -->|"D"|MiniDFA8_1114311988
MiniDFA8_1114311988 -->|"A"|MiniDFA9_15885241
MiniDFA9_15885241 -->|"r"|MiniDFA10_-878623421
MiniDFA10_-878623421 -->|"r"|MiniDFA3_1885579528
MiniDFA3_1885579528 -->|"a"|MiniDFA11_2020061616
MiniDFA11_2020061616 -->|"y"|MiniDFA12_-1309443540
```
-------------------------------
