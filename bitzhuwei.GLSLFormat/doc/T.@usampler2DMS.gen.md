# 'usampler2DMS'

pattern: `usampler2DMS`

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
eNFA156_24_2911981[["εNFA156-24 regex start"]]
eNFA156_0_26207835[["εNFA156-0 char{1, 1}"]]
eNFA156_1_34543924[["εNFA156-1 char[1]"]]
eNFA156_2_42459867[["εNFA156-2 char{1, 1}"]]
eNFA156_3_46594488[["εNFA156-3 char[1]"]]
eNFA156_4_16697212[["εNFA156-4 char{1, 1}"]]
eNFA156_5_16057184[["εNFA156-5 char[1]"]]
eNFA156_6_10296933[["εNFA156-6 char{1, 1}"]]
eNFA156_7_25563541[["εNFA156-7 char[1]"]]
eNFA156_8_28745279[["εNFA156-8 char{1, 1}"]]
eNFA156_9_57380926[["εNFA156-9 char[1]"]]
eNFA156_10_46666290[["εNFA156-10 char{1, 1}"]]
eNFA156_11_17343428[["εNFA156-11 char[1]"]]
eNFA156_12_21873125[["εNFA156-12 char{1, 1}"]]
eNFA156_13_62640398[["εNFA156-13 char[1]"]]
eNFA156_14_26892672[["εNFA156-14 char{1, 1}"]]
eNFA156_15_40707460[["εNFA156-15 char[1]"]]
eNFA156_16_30822828[["εNFA156-16 char{1, 1}"]]
eNFA156_17_8970000[["εNFA156-17 char[1]"]]
eNFA156_18_13621136[["εNFA156-18 char{1, 1}"]]
eNFA156_19_55481367[["εNFA156-19 char[1]"]]
eNFA156_20_29570261[["εNFA156-20 char{1, 1}"]]
eNFA156_21_64805763[["εNFA156-21 char[1]"]]
eNFA156_22_46380963[["εNFA156-22 char{1, 1}"]]
eNFA156_23_14775484[["εNFA156-23 char[1]"]]
eNFA156_25_65870497[["εNFA156-25 regex end"]]
eNFA156_26_55963561[["εNFA156-26 post-regex start"]]
eNFA156_27_33910007[\"εNFA156-27 post-regex end"/]
eNFA156_24_2911981 -.->|"ε"|eNFA156_0_26207835
eNFA156_0_26207835 -->|"u"|eNFA156_1_34543924
eNFA156_1_34543924 -.->|"ε"|eNFA156_2_42459867
eNFA156_2_42459867 -->|"s"|eNFA156_3_46594488
eNFA156_3_46594488 -.->|"ε"|eNFA156_4_16697212
eNFA156_4_16697212 -->|"a"|eNFA156_5_16057184
eNFA156_5_16057184 -.->|"ε"|eNFA156_6_10296933
eNFA156_6_10296933 -->|"m"|eNFA156_7_25563541
eNFA156_7_25563541 -.->|"ε"|eNFA156_8_28745279
eNFA156_8_28745279 -->|"p"|eNFA156_9_57380926
eNFA156_9_57380926 -.->|"ε"|eNFA156_10_46666290
eNFA156_10_46666290 -->|"l"|eNFA156_11_17343428
eNFA156_11_17343428 -.->|"ε"|eNFA156_12_21873125
eNFA156_12_21873125 -->|"e"|eNFA156_13_62640398
eNFA156_13_62640398 -.->|"ε"|eNFA156_14_26892672
eNFA156_14_26892672 -->|"r"|eNFA156_15_40707460
eNFA156_15_40707460 -.->|"ε"|eNFA156_16_30822828
eNFA156_16_30822828 -->|"2"|eNFA156_17_8970000
eNFA156_17_8970000 -.->|"ε"|eNFA156_18_13621136
eNFA156_18_13621136 -->|"D"|eNFA156_19_55481367
eNFA156_19_55481367 -.->|"ε"|eNFA156_20_29570261
eNFA156_20_29570261 -->|"M"|eNFA156_21_64805763
eNFA156_21_64805763 -.->|"ε"|eNFA156_22_46380963
eNFA156_22_46380963 -->|"S"|eNFA156_23_14775484
eNFA156_23_14775484 -.->|"ε"|eNFA156_25_65870497
eNFA156_25_65870497 -.->|"ε"|eNFA156_26_55963561
eNFA156_26_55963561 -.->|"ε"|eNFA156_27_33910007
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
eNFA156_24_36754611[["εNFA156-24 regex start"]]
eNFA156_0_62356046[["εNFA156-0 char{1, 1}"]]
eNFA156_1_24333505[["εNFA156-1 char[1]"]]
eNFA156_2_17674957[["εNFA156-2 char{1, 1}"]]
eNFA156_3_24856892[["εNFA156-3 char[1]"]]
eNFA156_4_22385437[["εNFA156-4 char{1, 1}"]]
eNFA156_5_142347[["εNFA156-5 char[1]"]]
eNFA156_6_1281126[["εNFA156-6 char{1, 1}"]]
eNFA156_7_11530135[["εNFA156-7 char[1]"]]
eNFA156_8_36662351[["εNFA156-8 char{1, 1}"]]
eNFA156_9_61525703[["εNFA156-9 char[1]"]]
eNFA156_10_16860416[["εNFA156-10 char{1, 1}"]]
eNFA156_11_17526019[["εNFA156-11 char[1]"]]
eNFA156_12_23516450[["εNFA156-12 char{1, 1}"]]
eNFA156_13_10321460[["εNFA156-13 char[1]"]]
eNFA156_14_25784284[["εNFA156-14 char{1, 1}"]]
eNFA156_15_30731970[["εNFA156-15 char[1]"]]
eNFA156_16_8152279[["εNFA156-16 char{1, 1}"]]
eNFA156_17_6261652[["εNFA156-17 char[1]"]]
eNFA156_18_56354875[["εNFA156-18 char{1, 1}"]]
eNFA156_19_37431827[["εNFA156-19 char[1]"]]
eNFA156_20_1342126[["εNFA156-20 char{1, 1}"]]
eNFA156_21_12079142[["εNFA156-21 char[1]"]]
eNFA156_22_41603419[["εNFA156-22 char{1, 1}"]]
eNFA156_23_38886454[\"εNFA156-23 char[1]"/]
eNFA156_25_14433768[\"εNFA156-25 regex end"/]
eNFA156_26_62795050[\"εNFA156-26 post-regex start"/]
eNFA156_27_28284541[\"εNFA156-27 post-regex end"/]
eNFA156_24_36754611 -.->|"ε"|eNFA156_0_62356046
eNFA156_24_36754611 -->|"u"|eNFA156_1_24333505
eNFA156_0_62356046 -->|"u"|eNFA156_1_24333505
eNFA156_1_24333505 -.->|"ε"|eNFA156_2_17674957
eNFA156_1_24333505 -->|"s"|eNFA156_3_24856892
eNFA156_2_17674957 -->|"s"|eNFA156_3_24856892
eNFA156_3_24856892 -.->|"ε"|eNFA156_4_22385437
eNFA156_3_24856892 -->|"a"|eNFA156_5_142347
eNFA156_4_22385437 -->|"a"|eNFA156_5_142347
eNFA156_5_142347 -.->|"ε"|eNFA156_6_1281126
eNFA156_5_142347 -->|"m"|eNFA156_7_11530135
eNFA156_6_1281126 -->|"m"|eNFA156_7_11530135
eNFA156_7_11530135 -.->|"ε"|eNFA156_8_36662351
eNFA156_7_11530135 -->|"p"|eNFA156_9_61525703
eNFA156_8_36662351 -->|"p"|eNFA156_9_61525703
eNFA156_9_61525703 -.->|"ε"|eNFA156_10_16860416
eNFA156_9_61525703 -->|"l"|eNFA156_11_17526019
eNFA156_10_16860416 -->|"l"|eNFA156_11_17526019
eNFA156_11_17526019 -.->|"ε"|eNFA156_12_23516450
eNFA156_11_17526019 -->|"e"|eNFA156_13_10321460
eNFA156_12_23516450 -->|"e"|eNFA156_13_10321460
eNFA156_13_10321460 -.->|"ε"|eNFA156_14_25784284
eNFA156_13_10321460 -->|"r"|eNFA156_15_30731970
eNFA156_14_25784284 -->|"r"|eNFA156_15_30731970
eNFA156_15_30731970 -.->|"ε"|eNFA156_16_8152279
eNFA156_15_30731970 -->|"2"|eNFA156_17_6261652
eNFA156_16_8152279 -->|"2"|eNFA156_17_6261652
eNFA156_17_6261652 -.->|"ε"|eNFA156_18_56354875
eNFA156_17_6261652 -->|"D"|eNFA156_19_37431827
eNFA156_18_56354875 -->|"D"|eNFA156_19_37431827
eNFA156_19_37431827 -.->|"ε"|eNFA156_20_1342126
eNFA156_19_37431827 -->|"M"|eNFA156_21_12079142
eNFA156_20_1342126 -->|"M"|eNFA156_21_12079142
eNFA156_21_12079142 -.->|"ε"|eNFA156_22_41603419
eNFA156_21_12079142 -->|"S"|eNFA156_23_38886454
eNFA156_22_41603419 -->|"S"|eNFA156_23_38886454
eNFA156_23_38886454 -.->|"ε"|eNFA156_25_14433768
eNFA156_23_38886454 -.->|"ε"|eNFA156_26_62795050
eNFA156_23_38886454 -.->|"ε"|eNFA156_27_28284541
eNFA156_25_14433768 -.->|"ε"|eNFA156_26_62795050
eNFA156_25_14433768 -.->|"ε"|eNFA156_27_28284541
eNFA156_26_62795050 -.->|"ε"|eNFA156_27_28284541
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
NFA156_24_53234283("NFA156-24 regex start")
NFA156_1_9346499("NFA156-1 char[1]")
NFA156_3_17009632("NFA156-3 char[1]")
NFA156_5_18868961("NFA156-5 char[1]")
NFA156_7_35602929("NFA156-7 char[1]")
NFA156_9_51990912("NFA156-9 char[1]")
NFA156_11_65265032("NFA156-11 char[1]")
NFA156_13_50514376("NFA156-13 char[1]")
NFA156_15_51976202("NFA156-15 char[1]")
NFA156_17_65132640("NFA156-17 char[1]")
NFA156_19_49322849("NFA156-19 char[1]")
NFA156_21_41252464("NFA156-21 char[1]")
NFA156_23_35727861[\"NFA156-23 char[1]"/]
NFA156_24_53234283 -->|"u"|NFA156_1_9346499
NFA156_1_9346499 -->|"s"|NFA156_3_17009632
NFA156_3_17009632 -->|"a"|NFA156_5_18868961
NFA156_5_18868961 -->|"m"|NFA156_7_35602929
NFA156_7_35602929 -->|"p"|NFA156_9_51990912
NFA156_9_51990912 -->|"l"|NFA156_11_65265032
NFA156_11_65265032 -->|"e"|NFA156_13_50514376
NFA156_13_50514376 -->|"r"|NFA156_15_51976202
NFA156_15_51976202 -->|"2"|NFA156_17_65132640
NFA156_17_65132640 -->|"D"|NFA156_19_49322849
NFA156_19_49322849 -->|"M"|NFA156_21_41252464
NFA156_21_41252464 -->|"S"|NFA156_23_35727861
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
subgraph DFA0_-785090455["DFA0 regex start"]
NFA156_24_53234283_0("NFA156-24 regex start")
end
subgraph DFA1_1447967385["DFA1 {1}"]
NFA156_1_9346499_1("NFA156-1 char[1]")
end
subgraph DFA2_1192339496["DFA2 {1}"]
NFA156_3_17009632_2("NFA156-3 char[1]")
end
subgraph DFA3_-1768818881["DFA3 {1}"]
NFA156_5_18868961_3("NFA156-5 char[1]")
end
subgraph DFA4_-691264426["DFA4 {1}"]
NFA156_7_35602929_4("NFA156-7 char[1]")
end
subgraph DFA5_1258297411["DFA5 {1}"]
NFA156_9_51990912_5("NFA156-9 char[1]")
end
subgraph DFA6_437150893["DFA6 {1}"]
NFA156_11_65265032_6("NFA156-11 char[1]")
end
subgraph DFA7_-1900728248["DFA7 {1}"]
NFA156_13_50514376_7("NFA156-13 char[1]")
end
subgraph DFA8_974635650["DFA8 {1}"]
NFA156_15_51976202_8("NFA156-15 char[1]")
end
subgraph DFA9_-934556041["DFA9 {1}"]
NFA156_17_65132640_9("NFA156-17 char[1]")
end
subgraph DFA10_-1453105194["DFA10 {1}"]
NFA156_19_49322849_10("NFA156-19 char[1]")
end
subgraph DFA11_755733530["DFA11 {1}"]
NFA156_21_41252464_11("NFA156-21 char[1]")
end
subgraph DFA12_1055558698["DFA12 {1}"]
NFA156_23_35727861_12[\"NFA156-23 char[1]"/]
end
DFA0_-785090455 -->|"u"|DFA1_1447967385
DFA1_1447967385 -->|"s"|DFA2_1192339496
DFA2_1192339496 -->|"a"|DFA3_-1768818881
DFA3_-1768818881 -->|"m"|DFA4_-691264426
DFA4_-691264426 -->|"p"|DFA5_1258297411
DFA5_1258297411 -->|"l"|DFA6_437150893
DFA6_437150893 -->|"e"|DFA7_-1900728248
DFA7_-1900728248 -->|"r"|DFA8_974635650
DFA8_974635650 -->|"2"|DFA9_-934556041
DFA9_-934556041 -->|"D"|DFA10_-1453105194
DFA10_-1453105194 -->|"M"|DFA11_755733530
DFA11_755733530 -->|"S"|DFA12_1055558698
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
DFA0_-785090455{{"DFA0 regex start"}}
DFA1_1447967385{{"DFA1 {1}"}}
DFA2_1192339496{{"DFA2 {1}"}}
DFA3_-1768818881{{"DFA3 {1}"}}
DFA4_-691264426{{"DFA4 {1}"}}
DFA5_1258297411{{"DFA5 {1}"}}
DFA6_437150893{{"DFA6 {1}"}}
DFA7_-1900728248{{"DFA7 {1}"}}
DFA8_974635650{{"DFA8 {1}"}}
DFA9_-934556041{{"DFA9 {1}"}}
DFA10_-1453105194{{"DFA10 {1}"}}
DFA11_755733530{{"DFA11 {1}"}}
DFA12_1055558698[\"DFA12 {1}"/]
DFA0_-785090455 -->|"u"|DFA1_1447967385
DFA1_1447967385 -->|"s"|DFA2_1192339496
DFA2_1192339496 -->|"a"|DFA3_-1768818881
DFA3_-1768818881 -->|"m"|DFA4_-691264426
DFA4_-691264426 -->|"p"|DFA5_1258297411
DFA5_1258297411 -->|"l"|DFA6_437150893
DFA6_437150893 -->|"e"|DFA7_-1900728248
DFA7_-1900728248 -->|"r"|DFA8_974635650
DFA8_974635650 -->|"2"|DFA9_-934556041
DFA9_-934556041 -->|"D"|DFA10_-1453105194
DFA10_-1453105194 -->|"M"|DFA11_755733530
DFA11_755733530 -->|"S"|DFA12_1055558698
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
subgraph MiniDFA0_-1500016202["MiniDFA0 {1}"]
DFA0_-785090455_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1797403097["MiniDFA1 {1}"]
DFA1_1447967385_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-816446219["MiniDFA2 {1}"]
DFA2_1192339496_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1598144778["MiniDFA3 {1}"]
DFA3_-1768818881_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1878993767["MiniDFA4 {1}"]
DFA4_-691264426_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1320492564["MiniDFA5 {1}"]
DFA5_1258297411_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-325766186["MiniDFA6 {1}"]
DFA6_437150893_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-364523649["MiniDFA7 {1}"]
DFA7_-1900728248_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-145582987["MiniDFA8 {1}"]
DFA8_974635650_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-579707304["MiniDFA9 {1}"]
DFA9_-934556041_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_266464721["MiniDFA10 {1}"]
DFA10_-1453105194_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-7213075["MiniDFA11 {1}"]
DFA11_755733530_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_382856857["MiniDFA12 {1}"]
DFA12_1055558698_12[\"DFA12 {1}"/]
end
MiniDFA0_-1500016202 -->|"u"|MiniDFA1_1797403097
MiniDFA1_1797403097 -->|"s"|MiniDFA2_-816446219
MiniDFA2_-816446219 -->|"a"|MiniDFA3_-1598144778
MiniDFA3_-1598144778 -->|"m"|MiniDFA4_-1878993767
MiniDFA4_-1878993767 -->|"p"|MiniDFA5_-1320492564
MiniDFA5_-1320492564 -->|"l"|MiniDFA6_-325766186
MiniDFA6_-325766186 -->|"e"|MiniDFA7_-364523649
MiniDFA7_-364523649 -->|"r"|MiniDFA8_-145582987
MiniDFA8_-145582987 -->|"2"|MiniDFA9_-579707304
MiniDFA9_-579707304 -->|"D"|MiniDFA10_266464721
MiniDFA10_266464721 -->|"M"|MiniDFA11_-7213075
MiniDFA11_-7213075 -->|"S"|MiniDFA12_382856857
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
MiniDFA0_-1500016202(["MiniDFA0 {1}"])
MiniDFA1_1797403097(["MiniDFA1 {1}"])
MiniDFA2_-816446219(["MiniDFA2 {1}"])
MiniDFA3_-1598144778(["MiniDFA3 {1}"])
MiniDFA4_-1878993767(["MiniDFA4 {1}"])
MiniDFA5_-1320492564(["MiniDFA5 {1}"])
MiniDFA6_-325766186(["MiniDFA6 {1}"])
MiniDFA7_-364523649(["MiniDFA7 {1}"])
MiniDFA8_-145582987(["MiniDFA8 {1}"])
MiniDFA9_-579707304(["MiniDFA9 {1}"])
MiniDFA10_266464721(["MiniDFA10 {1}"])
MiniDFA11_-7213075(["MiniDFA11 {1}"])
MiniDFA12_382856857[\"MiniDFA12 {1}"/]
MiniDFA0_-1500016202 -->|"u"|MiniDFA1_1797403097
MiniDFA1_1797403097 -->|"s"|MiniDFA2_-816446219
MiniDFA2_-816446219 -->|"a"|MiniDFA3_-1598144778
MiniDFA3_-1598144778 -->|"m"|MiniDFA4_-1878993767
MiniDFA4_-1878993767 -->|"p"|MiniDFA5_-1320492564
MiniDFA5_-1320492564 -->|"l"|MiniDFA6_-325766186
MiniDFA6_-325766186 -->|"e"|MiniDFA7_-364523649
MiniDFA7_-364523649 -->|"r"|MiniDFA8_-145582987
MiniDFA8_-145582987 -->|"2"|MiniDFA9_-579707304
MiniDFA9_-579707304 -->|"D"|MiniDFA10_266464721
MiniDFA10_266464721 -->|"M"|MiniDFA11_-7213075
MiniDFA11_-7213075 -->|"S"|MiniDFA12_382856857
```
-------------------------------
