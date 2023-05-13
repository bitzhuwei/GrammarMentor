# 'image2DRect'

pattern: `image2DRect`

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
eNFA169_22_52441537[["εNFA169-22 regex start"]]
eNFA169_0_2211792[["εNFA169-0 char{1, 1}"]]
eNFA169_1_19906136[["εNFA169-1 char[1]"]]
eNFA169_2_44937496[["εNFA169-2 char{1, 1}"]]
eNFA169_3_1784282[["εNFA169-3 char[1]"]]
eNFA169_4_16058544[["εNFA169-4 char{1, 1}"]]
eNFA169_5_10309169[["εNFA169-5 char[1]"]]
eNFA169_6_25673664[["εNFA169-6 char{1, 1}"]]
eNFA169_7_29736389[["εNFA169-7 char[1]"]]
eNFA169_8_66300913[["εNFA169-8 char{1, 1}"]]
eNFA169_9_59837309[["εNFA169-9 char[1]"]]
eNFA169_10_1664874[["εNFA169-10 char{1, 1}"]]
eNFA169_11_14983874[["εNFA169-11 char[1]"]]
eNFA169_12_637140[["εNFA169-12 char{1, 1}"]]
eNFA169_13_5734267[["εNFA169-13 char[1]"]]
eNFA169_14_51608407[["εNFA169-14 char{1, 1}"]]
eNFA169_15_61822481[["εNFA169-15 char[1]"]]
eNFA169_16_19531418[["εNFA169-16 char{1, 1}"]]
eNFA169_17_41565035[["εNFA169-17 char[1]"]]
eNFA169_18_38540997[["εNFA169-18 char{1, 1}"]]
eNFA169_19_11324657[["εNFA169-19 char[1]"]]
eNFA169_20_34813057[["εNFA169-20 char{1, 1}"]]
eNFA169_21_44882061[["εNFA169-21 char[1]"]]
eNFA169_23_1285365[["εNFA169-23 regex end"]]
eNFA169_24_11568292[["εNFA169-24 post-regex start"]]
eNFA169_25_37005770[\"εNFA169-25 post-regex end"/]
eNFA169_22_52441537 -.->|"ε"|eNFA169_0_2211792
eNFA169_0_2211792 -->|"i"|eNFA169_1_19906136
eNFA169_1_19906136 -.->|"ε"|eNFA169_2_44937496
eNFA169_2_44937496 -->|"m"|eNFA169_3_1784282
eNFA169_3_1784282 -.->|"ε"|eNFA169_4_16058544
eNFA169_4_16058544 -->|"a"|eNFA169_5_10309169
eNFA169_5_10309169 -.->|"ε"|eNFA169_6_25673664
eNFA169_6_25673664 -->|"g"|eNFA169_7_29736389
eNFA169_7_29736389 -.->|"ε"|eNFA169_8_66300913
eNFA169_8_66300913 -->|"e"|eNFA169_9_59837309
eNFA169_9_59837309 -.->|"ε"|eNFA169_10_1664874
eNFA169_10_1664874 -->|"2"|eNFA169_11_14983874
eNFA169_11_14983874 -.->|"ε"|eNFA169_12_637140
eNFA169_12_637140 -->|"D"|eNFA169_13_5734267
eNFA169_13_5734267 -.->|"ε"|eNFA169_14_51608407
eNFA169_14_51608407 -->|"R"|eNFA169_15_61822481
eNFA169_15_61822481 -.->|"ε"|eNFA169_16_19531418
eNFA169_16_19531418 -->|"e"|eNFA169_17_41565035
eNFA169_17_41565035 -.->|"ε"|eNFA169_18_38540997
eNFA169_18_38540997 -->|"c"|eNFA169_19_11324657
eNFA169_19_11324657 -.->|"ε"|eNFA169_20_34813057
eNFA169_20_34813057 -->|"t"|eNFA169_21_44882061
eNFA169_21_44882061 -.->|"ε"|eNFA169_23_1285365
eNFA169_23_1285365 -.->|"ε"|eNFA169_24_11568292
eNFA169_24_11568292 -.->|"ε"|eNFA169_25_37005770
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
eNFA169_22_64616480[["εNFA169-22 regex start"]]
eNFA169_0_44677416[["εNFA169-0 char{1, 1}"]]
eNFA169_1_66552425[["εNFA169-1 char[1]"]]
eNFA169_2_62100918[["εNFA169-2 char{1, 1}"]]
eNFA169_3_22037350[["εNFA169-3 char[1]"]]
eNFA169_4_64118428[["εNFA169-4 char{1, 1}"]]
eNFA169_5_40194944[["εNFA169-5 char[1]"]]
eNFA169_6_26210179[["εNFA169-6 char{1, 1}"]]
eNFA169_7_34565022[["εNFA169-7 char[1]"]]
eNFA169_8_42649746[["εNFA169-8 char{1, 1}"]]
eNFA169_9_48303401[["εNFA169-9 char[1]"]]
eNFA169_10_32077426[["εNFA169-10 char{1, 1}"]]
eNFA169_11_20261384[["εNFA169-11 char[1]"]]
eNFA169_12_48134731[["εNFA169-12 char{1, 1}"]]
eNFA169_13_30559396[["εNFA169-13 char[1]"]]
eNFA169_14_6599108[["εNFA169-14 char{1, 1}"]]
eNFA169_15_59391972[["εNFA169-15 char[1]"]]
eNFA169_16_64765701[["εNFA169-16 char{1, 1}"]]
eNFA169_17_46020400[["εNFA169-17 char[1]"]]
eNFA169_18_11530423[["εNFA169-18 char{1, 1}"]]
eNFA169_19_36664945[["εNFA169-19 char[1]"]]
eNFA169_20_61549057[["εNFA169-20 char{1, 1}"]]
eNFA169_21_17070607[\"εNFA169-21 char[1]"/]
eNFA169_23_19417740[\"εNFA169-23 regex end"/]
eNFA169_24_40541937[\"εNFA169-24 post-regex start"/]
eNFA169_25_29333120[\"εNFA169-25 post-regex end"/]
eNFA169_22_64616480 -.->|"ε"|eNFA169_0_44677416
eNFA169_22_64616480 -->|"i"|eNFA169_1_66552425
eNFA169_0_44677416 -->|"i"|eNFA169_1_66552425
eNFA169_1_66552425 -.->|"ε"|eNFA169_2_62100918
eNFA169_1_66552425 -->|"m"|eNFA169_3_22037350
eNFA169_2_62100918 -->|"m"|eNFA169_3_22037350
eNFA169_3_22037350 -.->|"ε"|eNFA169_4_64118428
eNFA169_3_22037350 -->|"a"|eNFA169_5_40194944
eNFA169_4_64118428 -->|"a"|eNFA169_5_40194944
eNFA169_5_40194944 -.->|"ε"|eNFA169_6_26210179
eNFA169_5_40194944 -->|"g"|eNFA169_7_34565022
eNFA169_6_26210179 -->|"g"|eNFA169_7_34565022
eNFA169_7_34565022 -.->|"ε"|eNFA169_8_42649746
eNFA169_7_34565022 -->|"e"|eNFA169_9_48303401
eNFA169_8_42649746 -->|"e"|eNFA169_9_48303401
eNFA169_9_48303401 -.->|"ε"|eNFA169_10_32077426
eNFA169_9_48303401 -->|"2"|eNFA169_11_20261384
eNFA169_10_32077426 -->|"2"|eNFA169_11_20261384
eNFA169_11_20261384 -.->|"ε"|eNFA169_12_48134731
eNFA169_11_20261384 -->|"D"|eNFA169_13_30559396
eNFA169_12_48134731 -->|"D"|eNFA169_13_30559396
eNFA169_13_30559396 -.->|"ε"|eNFA169_14_6599108
eNFA169_13_30559396 -->|"R"|eNFA169_15_59391972
eNFA169_14_6599108 -->|"R"|eNFA169_15_59391972
eNFA169_15_59391972 -.->|"ε"|eNFA169_16_64765701
eNFA169_15_59391972 -->|"e"|eNFA169_17_46020400
eNFA169_16_64765701 -->|"e"|eNFA169_17_46020400
eNFA169_17_46020400 -.->|"ε"|eNFA169_18_11530423
eNFA169_17_46020400 -->|"c"|eNFA169_19_36664945
eNFA169_18_11530423 -->|"c"|eNFA169_19_36664945
eNFA169_19_36664945 -.->|"ε"|eNFA169_20_61549057
eNFA169_19_36664945 -->|"t"|eNFA169_21_17070607
eNFA169_20_61549057 -->|"t"|eNFA169_21_17070607
eNFA169_21_17070607 -.->|"ε"|eNFA169_23_19417740
eNFA169_21_17070607 -.->|"ε"|eNFA169_24_40541937
eNFA169_21_17070607 -.->|"ε"|eNFA169_25_29333120
eNFA169_23_19417740 -.->|"ε"|eNFA169_24_40541937
eNFA169_23_19417740 -.->|"ε"|eNFA169_25_29333120
eNFA169_24_40541937 -.->|"ε"|eNFA169_25_29333120
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
NFA169_22_62671488("NFA169-22 regex start")
NFA169_1_27172483("NFA169-1 char[1]")
NFA169_3_43225763("NFA169-3 char[1]")
NFA169_5_53487552("NFA169-5 char[1]")
NFA169_7_11625923("NFA169-7 char[1]")
NFA169_9_37524445("NFA169-9 char[1]")
NFA169_11_2175687("NFA169-11 char[1]")
NFA169_13_19581186("NFA169-13 char[1]")
NFA169_15_42012952("NFA169-15 char[1]")
NFA169_17_42572248("NFA169-17 char[1]")
NFA169_19_47605917("NFA169-19 char[1]")
NFA169_21_25800070[\"NFA169-21 char[1]"/]
NFA169_22_62671488 -->|"i"|NFA169_1_27172483
NFA169_1_27172483 -->|"m"|NFA169_3_43225763
NFA169_3_43225763 -->|"a"|NFA169_5_53487552
NFA169_5_53487552 -->|"g"|NFA169_7_11625923
NFA169_7_11625923 -->|"e"|NFA169_9_37524445
NFA169_9_37524445 -->|"2"|NFA169_11_2175687
NFA169_11_2175687 -->|"D"|NFA169_13_19581186
NFA169_13_19581186 -->|"R"|NFA169_15_42012952
NFA169_15_42012952 -->|"e"|NFA169_17_42572248
NFA169_17_42572248 -->|"c"|NFA169_19_47605917
NFA169_19_47605917 -->|"t"|NFA169_21_25800070
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
subgraph DFA0_-417737953["DFA0 regex start"]
NFA169_22_62671488_0("NFA169-22 regex start")
end
subgraph DFA1_-214797844["DFA1 {1}"]
NFA169_1_27172483_1("NFA169-1 char[1]")
end
subgraph DFA2_1309618939["DFA2 {1}"]
NFA169_3_43225763_2("NFA169-3 char[1]")
end
subgraph DFA3_-919230562["DFA3 {1}"]
NFA169_5_53487552_3("NFA169-5 char[1]")
end
subgraph DFA4_-1031729602["DFA4 {1}"]
NFA169_7_11625923_4("NFA169-7 char[1]")
end
subgraph DFA5_611331985["DFA5 {1}"]
NFA169_9_37524445_5("NFA169-9 char[1]")
end
subgraph DFA6_970778500["DFA6 {1}"]
NFA169_11_2175687_6("NFA169-11 char[1]")
end
subgraph DFA7_1258654749["DFA7 {1}"]
NFA169_13_19581186_7("NFA169-13 char[1]")
end
subgraph DFA8_1021760224["DFA8 {1}"]
NFA169_15_42012952_8("NFA169-15 char[1]")
end
subgraph DFA9_-979626486["DFA9 {1}"]
NFA169_17_42572248_9("NFA169-17 char[1]")
end
subgraph DFA10_-1744412080["DFA10 {1}"]
NFA169_19_47605917_10("NFA169-19 char[1]")
end
subgraph DFA11_804741985["DFA11 {1}"]
NFA169_21_25800070_11[\"NFA169-21 char[1]"/]
end
DFA0_-417737953 -->|"i"|DFA1_-214797844
DFA1_-214797844 -->|"m"|DFA2_1309618939
DFA2_1309618939 -->|"a"|DFA3_-919230562
DFA3_-919230562 -->|"g"|DFA4_-1031729602
DFA4_-1031729602 -->|"e"|DFA5_611331985
DFA5_611331985 -->|"2"|DFA6_970778500
DFA6_970778500 -->|"D"|DFA7_1258654749
DFA7_1258654749 -->|"R"|DFA8_1021760224
DFA8_1021760224 -->|"e"|DFA9_-979626486
DFA9_-979626486 -->|"c"|DFA10_-1744412080
DFA10_-1744412080 -->|"t"|DFA11_804741985
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
DFA0_-417737953{{"DFA0 regex start"}}
DFA1_-214797844{{"DFA1 {1}"}}
DFA2_1309618939{{"DFA2 {1}"}}
DFA3_-919230562{{"DFA3 {1}"}}
DFA4_-1031729602{{"DFA4 {1}"}}
DFA5_611331985{{"DFA5 {1}"}}
DFA6_970778500{{"DFA6 {1}"}}
DFA7_1258654749{{"DFA7 {1}"}}
DFA8_1021760224{{"DFA8 {1}"}}
DFA9_-979626486{{"DFA9 {1}"}}
DFA10_-1744412080{{"DFA10 {1}"}}
DFA11_804741985[\"DFA11 {1}"/]
DFA0_-417737953 -->|"i"|DFA1_-214797844
DFA1_-214797844 -->|"m"|DFA2_1309618939
DFA2_1309618939 -->|"a"|DFA3_-919230562
DFA3_-919230562 -->|"g"|DFA4_-1031729602
DFA4_-1031729602 -->|"e"|DFA5_611331985
DFA5_611331985 -->|"2"|DFA6_970778500
DFA6_970778500 -->|"D"|DFA7_1258654749
DFA7_1258654749 -->|"R"|DFA8_1021760224
DFA8_1021760224 -->|"e"|DFA9_-979626486
DFA9_-979626486 -->|"c"|DFA10_-1744412080
DFA10_-1744412080 -->|"t"|DFA11_804741985
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
subgraph MiniDFA0_-695633369["MiniDFA0 {1}"]
DFA0_-417737953_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1876280678["MiniDFA1 {1}"]
DFA1_-214797844_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_632097574["MiniDFA2 {1}"]
DFA2_1309618939_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1586816423["MiniDFA3 {1}"]
DFA3_-919230562_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1536030818["MiniDFA4 {1}"]
DFA4_-1031729602_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-535378051["MiniDFA6 {1}"]
DFA5_611331985_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_511987047["MiniDFA7 {1}"]
DFA6_970778500_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1689700658["MiniDFA8 {1}"]
DFA7_1258654749_7{{"DFA7 {1}"}}
end
subgraph MiniDFA5_-1982496171["MiniDFA5 {1}"]
DFA8_1021760224_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-1649544693["MiniDFA9 {1}"]
DFA9_-979626486_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_1694123227["MiniDFA10 {1}"]
DFA10_-1744412080_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_374850643["MiniDFA11 {1}"]
DFA11_804741985_11[\"DFA11 {1}"/]
end
MiniDFA0_-695633369 -->|"i"|MiniDFA1_-1876280678
MiniDFA1_-1876280678 -->|"m"|MiniDFA2_632097574
MiniDFA2_632097574 -->|"a"|MiniDFA3_1586816423
MiniDFA3_1586816423 -->|"g"|MiniDFA4_-1536030818
MiniDFA4_-1536030818 -->|"e"|MiniDFA6_-535378051
MiniDFA6_-535378051 -->|"2"|MiniDFA7_511987047
MiniDFA7_511987047 -->|"D"|MiniDFA8_1689700658
MiniDFA8_1689700658 -->|"R"|MiniDFA5_-1982496171
MiniDFA5_-1982496171 -->|"e"|MiniDFA9_-1649544693
MiniDFA9_-1649544693 -->|"c"|MiniDFA10_1694123227
MiniDFA10_1694123227 -->|"t"|MiniDFA11_374850643
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
MiniDFA0_-695633369(["MiniDFA0 {1}"])
MiniDFA1_-1876280678(["MiniDFA1 {1}"])
MiniDFA2_632097574(["MiniDFA2 {1}"])
MiniDFA3_1586816423(["MiniDFA3 {1}"])
MiniDFA4_-1536030818(["MiniDFA4 {1}"])
MiniDFA6_-535378051(["MiniDFA6 {1}"])
MiniDFA7_511987047(["MiniDFA7 {1}"])
MiniDFA8_1689700658(["MiniDFA8 {1}"])
MiniDFA5_-1982496171(["MiniDFA5 {1}"])
MiniDFA9_-1649544693(["MiniDFA9 {1}"])
MiniDFA10_1694123227(["MiniDFA10 {1}"])
MiniDFA11_374850643[\"MiniDFA11 {1}"/]
MiniDFA0_-695633369 -->|"i"|MiniDFA1_-1876280678
MiniDFA1_-1876280678 -->|"m"|MiniDFA2_632097574
MiniDFA2_632097574 -->|"a"|MiniDFA3_1586816423
MiniDFA3_1586816423 -->|"g"|MiniDFA4_-1536030818
MiniDFA4_-1536030818 -->|"e"|MiniDFA6_-535378051
MiniDFA6_-535378051 -->|"2"|MiniDFA7_511987047
MiniDFA7_511987047 -->|"D"|MiniDFA8_1689700658
MiniDFA8_1689700658 -->|"R"|MiniDFA5_-1982496171
MiniDFA5_-1982496171 -->|"e"|MiniDFA9_-1649544693
MiniDFA9_-1649544693 -->|"c"|MiniDFA10_1694123227
MiniDFA10_1694123227 -->|"t"|MiniDFA11_374850643
```
-------------------------------
