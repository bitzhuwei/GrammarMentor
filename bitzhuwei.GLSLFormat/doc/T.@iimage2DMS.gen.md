# 'iimage2DMS'

pattern: `iimage2DMS`

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
eNFA188_20_51783064[["εNFA188-20 regex start"]]
eNFA188_0_63394397[["εNFA188-0 char{1, 1}"]]
eNFA188_1_33678668[["εNFA188-1 char[1]"]]
eNFA188_2_34672556[["εNFA188-2 char{1, 1}"]]
eNFA188_3_43617551[["εNFA188-3 char[1]"]]
eNFA188_4_57013647[["εNFA188-4 char{1, 1}"]]
eNFA188_5_43360780[["εNFA188-5 char[1]"]]
eNFA188_6_54702703[["εNFA188-6 char{1, 1}"]]
eNFA188_7_22562281[["εNFA188-7 char[1]"]]
eNFA188_8_1733939[["εNFA188-8 char{1, 1}"]]
eNFA188_9_15605454[["εNFA188-9 char[1]"]]
eNFA188_10_6231364[["εNFA188-10 char{1, 1}"]]
eNFA188_11_56082276[["εNFA188-11 char[1]"]]
eNFA188_12_34978441[["εNFA188-12 char{1, 1}"]]
eNFA188_13_46370514[["εNFA188-13 char[1]"]]
eNFA188_14_14681450[["εNFA188-14 char{1, 1}"]]
eNFA188_15_65024193[["εNFA188-15 char[1]"]]
eNFA188_16_48346833[["εNFA188-16 char{1, 1}"]]
eNFA188_17_32468313[["εNFA188-17 char[1]"]]
eNFA188_18_23779363[["εNFA188-18 char{1, 1}"]]
eNFA188_19_12687681[["εNFA188-19 char[1]"]]
eNFA188_21_47080266[["εNFA188-21 regex end"]]
eNFA188_22_21069217[["εNFA188-22 post-regex start"]]
eNFA188_23_55405230[\"εNFA188-23 post-regex end"/]
eNFA188_20_51783064 -.->|"ε"|eNFA188_0_63394397
eNFA188_0_63394397 -->|"i"|eNFA188_1_33678668
eNFA188_1_33678668 -.->|"ε"|eNFA188_2_34672556
eNFA188_2_34672556 -->|"i"|eNFA188_3_43617551
eNFA188_3_43617551 -.->|"ε"|eNFA188_4_57013647
eNFA188_4_57013647 -->|"m"|eNFA188_5_43360780
eNFA188_5_43360780 -.->|"ε"|eNFA188_6_54702703
eNFA188_6_54702703 -->|"a"|eNFA188_7_22562281
eNFA188_7_22562281 -.->|"ε"|eNFA188_8_1733939
eNFA188_8_1733939 -->|"g"|eNFA188_9_15605454
eNFA188_9_15605454 -.->|"ε"|eNFA188_10_6231364
eNFA188_10_6231364 -->|"e"|eNFA188_11_56082276
eNFA188_11_56082276 -.->|"ε"|eNFA188_12_34978441
eNFA188_12_34978441 -->|"2"|eNFA188_13_46370514
eNFA188_13_46370514 -.->|"ε"|eNFA188_14_14681450
eNFA188_14_14681450 -->|"D"|eNFA188_15_65024193
eNFA188_15_65024193 -.->|"ε"|eNFA188_16_48346833
eNFA188_16_48346833 -->|"M"|eNFA188_17_32468313
eNFA188_17_32468313 -.->|"ε"|eNFA188_18_23779363
eNFA188_18_23779363 -->|"S"|eNFA188_19_12687681
eNFA188_19_12687681 -.->|"ε"|eNFA188_21_47080266
eNFA188_21_47080266 -.->|"ε"|eNFA188_22_21069217
eNFA188_22_21069217 -.->|"ε"|eNFA188_23_55405230
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
eNFA188_20_28885026[["εNFA188-20 regex start"]]
eNFA188_0_58638646[["εNFA188-0 char{1, 1}"]]
eNFA188_1_57985771[["εNFA188-1 char[1]"]]
eNFA188_2_52109899[["εNFA188-2 char{1, 1}"]]
eNFA188_3_66335909[["εNFA188-3 char[1]"]]
eNFA188_4_60152276[["εNFA188-4 char{1, 1}"]]
eNFA188_5_4499576[["εNFA188-5 char[1]"]]
eNFA188_6_40496186[["εNFA188-6 char{1, 1}"]]
eNFA188_7_28921355[["εNFA188-7 char[1]"]]
eNFA188_8_58965604[["εNFA188-8 char{1, 1}"]]
eNFA188_9_60928390[["εNFA188-9 char[1]"]]
eNFA188_10_11484602[["εNFA188-10 char{1, 1}"]]
eNFA188_11_36252562[["εNFA188-11 char[1]"]]
eNFA188_12_57837606[["εNFA188-12 char{1, 1}"]]
eNFA188_13_50776406[["εNFA188-13 char[1]"]]
eNFA188_14_54334477[["εNFA188-14 char{1, 1}"]]
eNFA188_15_19248251[["εNFA188-15 char[1]"]]
eNFA188_16_39016537[["εNFA188-16 char{1, 1}"]]
eNFA188_17_15604521[["εNFA188-17 char[1]"]]
eNFA188_18_6222962[["εNFA188-18 char{1, 1}"]]
eNFA188_19_56006663[\"εNFA188-19 char[1]"/]
eNFA188_21_34297919[\"εNFA188-21 regex end"/]
eNFA188_22_40245821[\"εNFA188-22 post-regex start"/]
eNFA188_23_26668073[\"εNFA188-23 post-regex end"/]
eNFA188_20_28885026 -.->|"ε"|eNFA188_0_58638646
eNFA188_20_28885026 -->|"i"|eNFA188_1_57985771
eNFA188_0_58638646 -->|"i"|eNFA188_1_57985771
eNFA188_1_57985771 -.->|"ε"|eNFA188_2_52109899
eNFA188_1_57985771 -->|"i"|eNFA188_3_66335909
eNFA188_2_52109899 -->|"i"|eNFA188_3_66335909
eNFA188_3_66335909 -.->|"ε"|eNFA188_4_60152276
eNFA188_3_66335909 -->|"m"|eNFA188_5_4499576
eNFA188_4_60152276 -->|"m"|eNFA188_5_4499576
eNFA188_5_4499576 -.->|"ε"|eNFA188_6_40496186
eNFA188_5_4499576 -->|"a"|eNFA188_7_28921355
eNFA188_6_40496186 -->|"a"|eNFA188_7_28921355
eNFA188_7_28921355 -.->|"ε"|eNFA188_8_58965604
eNFA188_7_28921355 -->|"g"|eNFA188_9_60928390
eNFA188_8_58965604 -->|"g"|eNFA188_9_60928390
eNFA188_9_60928390 -.->|"ε"|eNFA188_10_11484602
eNFA188_9_60928390 -->|"e"|eNFA188_11_36252562
eNFA188_10_11484602 -->|"e"|eNFA188_11_36252562
eNFA188_11_36252562 -.->|"ε"|eNFA188_12_57837606
eNFA188_11_36252562 -->|"2"|eNFA188_13_50776406
eNFA188_12_57837606 -->|"2"|eNFA188_13_50776406
eNFA188_13_50776406 -.->|"ε"|eNFA188_14_54334477
eNFA188_13_50776406 -->|"D"|eNFA188_15_19248251
eNFA188_14_54334477 -->|"D"|eNFA188_15_19248251
eNFA188_15_19248251 -.->|"ε"|eNFA188_16_39016537
eNFA188_15_19248251 -->|"M"|eNFA188_17_15604521
eNFA188_16_39016537 -->|"M"|eNFA188_17_15604521
eNFA188_17_15604521 -.->|"ε"|eNFA188_18_6222962
eNFA188_17_15604521 -->|"S"|eNFA188_19_56006663
eNFA188_18_6222962 -->|"S"|eNFA188_19_56006663
eNFA188_19_56006663 -.->|"ε"|eNFA188_21_34297919
eNFA188_19_56006663 -.->|"ε"|eNFA188_22_40245821
eNFA188_19_56006663 -.->|"ε"|eNFA188_23_26668073
eNFA188_21_34297919 -.->|"ε"|eNFA188_22_40245821
eNFA188_21_34297919 -.->|"ε"|eNFA188_23_26668073
eNFA188_22_40245821 -.->|"ε"|eNFA188_23_26668073
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
NFA188_20_38686068("NFA188-20 regex start")
NFA188_1_12630295("NFA188-1 char[1]")
NFA188_3_46563795("NFA188-3 char[1]")
NFA188_5_16420978("NFA188-5 char[1]")
NFA188_7_13571075("NFA188-7 char[1]")
NFA188_9_55030817("NFA188-9 char[1]")
NFA188_11_25515308("NFA188-11 char[1]")
NFA188_13_28311181("NFA188-13 char[1]")
NFA188_15_53474037("NFA188-15 char[1]")
NFA188_17_11504285("NFA188-17 char[1]")
NFA188_19_36429702[\"NFA188-19 char[1]"/]
NFA188_20_38686068 -->|"i"|NFA188_1_12630295
NFA188_1_12630295 -->|"i"|NFA188_3_46563795
NFA188_3_46563795 -->|"m"|NFA188_5_16420978
NFA188_5_16420978 -->|"a"|NFA188_7_13571075
NFA188_7_13571075 -->|"g"|NFA188_9_55030817
NFA188_9_55030817 -->|"e"|NFA188_11_25515308
NFA188_11_25515308 -->|"2"|NFA188_13_28311181
NFA188_13_28311181 -->|"D"|NFA188_15_53474037
NFA188_15_53474037 -->|"M"|NFA188_17_11504285
NFA188_17_11504285 -->|"S"|NFA188_19_36429702
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
subgraph DFA0_1872479736["DFA0 regex start"]
NFA188_20_38686068_0("NFA188-20 regex start")
end
subgraph DFA1_-923872890["DFA1 {1}"]
NFA188_1_12630295_1("NFA188-1 char[1]")
end
subgraph DFA2_1231239185["DFA2 {1}"]
NFA188_3_46563795_2("NFA188-3 char[1]")
end
subgraph DFA3_-1718585227["DFA3 {1}"]
NFA188_5_16420978_3("NFA188-5 char[1]")
end
subgraph DFA4_-1882587484["DFA4 {1}"]
NFA188_7_13571075_4("NFA188-7 char[1]")
end
subgraph DFA5_-1314929783["DFA5 {1}"]
NFA188_9_55030817_5("NFA188-9 char[1]")
end
subgraph DFA6_-157541049["DFA6 {1}"]
NFA188_11_25515308_6("NFA188-11 char[1]")
end
subgraph DFA7_-1438744256["DFA7 {1}"]
NFA188_13_28311181_7("NFA188-13 char[1]")
end
subgraph DFA8_1567956158["DFA8 {1}"]
NFA188_15_53474037_8("NFA188-15 char[1]")
end
subgraph DFA9_-910631734["DFA9 {1}"]
NFA188_17_11504285_9("NFA188-17 char[1]")
end
subgraph DFA10_-1664252560["DFA10 {1}"]
NFA188_19_36429702_10[\"NFA188-19 char[1]"/]
end
DFA0_1872479736 -->|"i"|DFA1_-923872890
DFA1_-923872890 -->|"i"|DFA2_1231239185
DFA2_1231239185 -->|"m"|DFA3_-1718585227
DFA3_-1718585227 -->|"a"|DFA4_-1882587484
DFA4_-1882587484 -->|"g"|DFA5_-1314929783
DFA5_-1314929783 -->|"e"|DFA6_-157541049
DFA6_-157541049 -->|"2"|DFA7_-1438744256
DFA7_-1438744256 -->|"D"|DFA8_1567956158
DFA8_1567956158 -->|"M"|DFA9_-910631734
DFA9_-910631734 -->|"S"|DFA10_-1664252560
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
DFA0_1872479736{{"DFA0 regex start"}}
DFA1_-923872890{{"DFA1 {1}"}}
DFA2_1231239185{{"DFA2 {1}"}}
DFA3_-1718585227{{"DFA3 {1}"}}
DFA4_-1882587484{{"DFA4 {1}"}}
DFA5_-1314929783{{"DFA5 {1}"}}
DFA6_-157541049{{"DFA6 {1}"}}
DFA7_-1438744256{{"DFA7 {1}"}}
DFA8_1567956158{{"DFA8 {1}"}}
DFA9_-910631734{{"DFA9 {1}"}}
DFA10_-1664252560[\"DFA10 {1}"/]
DFA0_1872479736 -->|"i"|DFA1_-923872890
DFA1_-923872890 -->|"i"|DFA2_1231239185
DFA2_1231239185 -->|"m"|DFA3_-1718585227
DFA3_-1718585227 -->|"a"|DFA4_-1882587484
DFA4_-1882587484 -->|"g"|DFA5_-1314929783
DFA5_-1314929783 -->|"e"|DFA6_-157541049
DFA6_-157541049 -->|"2"|DFA7_-1438744256
DFA7_-1438744256 -->|"D"|DFA8_1567956158
DFA8_1567956158 -->|"M"|DFA9_-910631734
DFA9_-910631734 -->|"S"|DFA10_-1664252560
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
subgraph MiniDFA0_-410870920["MiniDFA0 {1}"]
DFA0_1872479736_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-948977355["MiniDFA1 {1}"]
DFA1_-923872890_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-616602763["MiniDFA2 {1}"]
DFA2_1231239185_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-350338835["MiniDFA3 {1}"]
DFA3_-1718585227_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_963383351["MiniDFA4 {1}"]
DFA4_-1882587484_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1071761027["MiniDFA5 {1}"]
DFA5_-1314929783_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1222944494["MiniDFA6 {1}"]
DFA6_-157541049_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_589503484["MiniDFA7 {1}"]
DFA7_-1438744256_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1212632322["MiniDFA8 {1}"]
DFA8_1567956158_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-181197706["MiniDFA9 {1}"]
DFA9_-910631734_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_1077155697["MiniDFA10 {1}"]
DFA10_-1664252560_10[\"DFA10 {1}"/]
end
MiniDFA0_-410870920 -->|"i"|MiniDFA1_-948977355
MiniDFA1_-948977355 -->|"i"|MiniDFA2_-616602763
MiniDFA2_-616602763 -->|"m"|MiniDFA3_-350338835
MiniDFA3_-350338835 -->|"a"|MiniDFA4_963383351
MiniDFA4_963383351 -->|"g"|MiniDFA5_1071761027
MiniDFA5_1071761027 -->|"e"|MiniDFA6_-1222944494
MiniDFA6_-1222944494 -->|"2"|MiniDFA7_589503484
MiniDFA7_589503484 -->|"D"|MiniDFA8_-1212632322
MiniDFA8_-1212632322 -->|"M"|MiniDFA9_-181197706
MiniDFA9_-181197706 -->|"S"|MiniDFA10_1077155697
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
MiniDFA0_-410870920(["MiniDFA0 {1}"])
MiniDFA1_-948977355(["MiniDFA1 {1}"])
MiniDFA2_-616602763(["MiniDFA2 {1}"])
MiniDFA3_-350338835(["MiniDFA3 {1}"])
MiniDFA4_963383351(["MiniDFA4 {1}"])
MiniDFA5_1071761027(["MiniDFA5 {1}"])
MiniDFA6_-1222944494(["MiniDFA6 {1}"])
MiniDFA7_589503484(["MiniDFA7 {1}"])
MiniDFA8_-1212632322(["MiniDFA8 {1}"])
MiniDFA9_-181197706(["MiniDFA9 {1}"])
MiniDFA10_1077155697[\"MiniDFA10 {1}"/]
MiniDFA0_-410870920 -->|"i"|MiniDFA1_-948977355
MiniDFA1_-948977355 -->|"i"|MiniDFA2_-616602763
MiniDFA2_-616602763 -->|"m"|MiniDFA3_-350338835
MiniDFA3_-350338835 -->|"a"|MiniDFA4_963383351
MiniDFA4_963383351 -->|"g"|MiniDFA5_1071761027
MiniDFA5_1071761027 -->|"e"|MiniDFA6_-1222944494
MiniDFA6_-1222944494 -->|"2"|MiniDFA7_589503484
MiniDFA7_589503484 -->|"D"|MiniDFA8_-1212632322
MiniDFA8_-1212632322 -->|"M"|MiniDFA9_-181197706
MiniDFA9_-181197706 -->|"S"|MiniDFA10_1077155697
```
-------------------------------
