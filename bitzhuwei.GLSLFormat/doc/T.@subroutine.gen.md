# 'subroutine'

pattern: `subroutine`

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
eNFA73_20_36437619[["εNFA73-20 regex start"]]
eNFA73_0_59503116[["εNFA73-0 char{1, 1}"]]
eNFA73_1_65765997[["εNFA73-1 char[1]"]]
eNFA73_2_55023063[["εNFA73-2 char{1, 1}"]]
eNFA73_3_25445523[["εNFA73-3 char[1]"]]
eNFA73_4_27683123[["εNFA73-4 char{1, 1}"]]
eNFA73_5_47821519[["εNFA73-5 char[1]"]]
eNFA73_6_27740487[["εNFA73-6 char{1, 1}"]]
eNFA73_7_48337798[["εNFA73-7 char[1]"]]
eNFA73_8_32387004[["εNFA73-8 char{1, 1}"]]
eNFA73_9_23047586[["εNFA73-9 char[1]"]]
eNFA73_10_6101690[["εNFA73-10 char{1, 1}"]]
eNFA73_11_54915211[["εNFA73-11 char[1]"]]
eNFA73_12_24474856[["εNFA73-12 char{1, 1}"]]
eNFA73_13_18947112[["εNFA73-13 char[1]"]]
eNFA73_14_36306286[["εNFA73-14 char{1, 1}"]]
eNFA73_15_58321122[["εNFA73-15 char[1]"]]
eNFA73_16_55128053[["εNFA73-16 char{1, 1}"]]
eNFA73_17_26390432[["εNFA73-17 char[1]"]]
eNFA73_18_36187300[["εNFA73-18 char{1, 1}"]]
eNFA73_19_57250251[["εNFA73-19 char[1]"]]
eNFA73_21_45490212[["εNFA73-21 regex end"]]
eNFA73_22_6758730[["εNFA73-22 post-regex start"]]
eNFA73_23_60828573[\"εNFA73-23 post-regex end"/]
eNFA73_20_36437619 -.->|"ε"|eNFA73_0_59503116
eNFA73_0_59503116 -->|"s"|eNFA73_1_65765997
eNFA73_1_65765997 -.->|"ε"|eNFA73_2_55023063
eNFA73_2_55023063 -->|"u"|eNFA73_3_25445523
eNFA73_3_25445523 -.->|"ε"|eNFA73_4_27683123
eNFA73_4_27683123 -->|"b"|eNFA73_5_47821519
eNFA73_5_47821519 -.->|"ε"|eNFA73_6_27740487
eNFA73_6_27740487 -->|"r"|eNFA73_7_48337798
eNFA73_7_48337798 -.->|"ε"|eNFA73_8_32387004
eNFA73_8_32387004 -->|"o"|eNFA73_9_23047586
eNFA73_9_23047586 -.->|"ε"|eNFA73_10_6101690
eNFA73_10_6101690 -->|"u"|eNFA73_11_54915211
eNFA73_11_54915211 -.->|"ε"|eNFA73_12_24474856
eNFA73_12_24474856 -->|"t"|eNFA73_13_18947112
eNFA73_13_18947112 -.->|"ε"|eNFA73_14_36306286
eNFA73_14_36306286 -->|"i"|eNFA73_15_58321122
eNFA73_15_58321122 -.->|"ε"|eNFA73_16_55128053
eNFA73_16_55128053 -->|"n"|eNFA73_17_26390432
eNFA73_17_26390432 -.->|"ε"|eNFA73_18_36187300
eNFA73_18_36187300 -->|"e"|eNFA73_19_57250251
eNFA73_19_57250251 -.->|"ε"|eNFA73_21_45490212
eNFA73_21_45490212 -.->|"ε"|eNFA73_22_6758730
eNFA73_22_6758730 -.->|"ε"|eNFA73_23_60828573
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
eNFA73_20_10586246[["εNFA73-20 regex start"]]
eNFA73_0_28167350[["εNFA73-0 char{1, 1}"]]
eNFA73_1_52179558[["εNFA73-1 char[1]"]]
eNFA73_2_66962839[["εNFA73-2 char{1, 1}"]]
eNFA73_3_65794642[["εNFA73-3 char[1]"]]
eNFA73_4_55280873[["εNFA73-4 char{1, 1}"]]
eNFA73_5_27765811[["εNFA73-5 char[1]"]]
eNFA73_6_48565715[["εNFA73-6 char{1, 1}"]]
eNFA73_7_34438257[["εNFA73-7 char[1]"]]
eNFA73_8_41508862[["εNFA73-8 char{1, 1}"]]
eNFA73_9_38035443[["εNFA73-9 char[1]"]]
eNFA73_10_6774674[["εNFA73-10 char{1, 1}"]]
eNFA73_11_60972066[["εNFA73-11 char[1]"]]
eNFA73_12_11877685[["εNFA73-12 char{1, 1}"]]
eNFA73_13_39790309[["εNFA73-13 char[1]"]]
eNFA73_14_22568466[["εNFA73-14 char{1, 1}"]]
eNFA73_15_1789605[["εNFA73-15 char[1]"]]
eNFA73_16_16106447[["εNFA73-16 char{1, 1}"]]
eNFA73_17_10740297[["εNFA73-17 char[1]"]]
eNFA73_18_29553812[["εNFA73-18 char{1, 1}"]]
eNFA73_19_64657722[\"εNFA73-19 char[1]"/]
eNFA73_21_45048586[\"εNFA73-21 regex end"/]
eNFA73_22_2784095[\"εNFA73-22 post-regex start"/]
eNFA73_23_25056856[\"εNFA73-23 post-regex end"/]
eNFA73_20_10586246 -.->|"ε"|eNFA73_0_28167350
eNFA73_20_10586246 -->|"s"|eNFA73_1_52179558
eNFA73_0_28167350 -->|"s"|eNFA73_1_52179558
eNFA73_1_52179558 -.->|"ε"|eNFA73_2_66962839
eNFA73_1_52179558 -->|"u"|eNFA73_3_65794642
eNFA73_2_66962839 -->|"u"|eNFA73_3_65794642
eNFA73_3_65794642 -.->|"ε"|eNFA73_4_55280873
eNFA73_3_65794642 -->|"b"|eNFA73_5_27765811
eNFA73_4_55280873 -->|"b"|eNFA73_5_27765811
eNFA73_5_27765811 -.->|"ε"|eNFA73_6_48565715
eNFA73_5_27765811 -->|"r"|eNFA73_7_34438257
eNFA73_6_48565715 -->|"r"|eNFA73_7_34438257
eNFA73_7_34438257 -.->|"ε"|eNFA73_8_41508862
eNFA73_7_34438257 -->|"o"|eNFA73_9_38035443
eNFA73_8_41508862 -->|"o"|eNFA73_9_38035443
eNFA73_9_38035443 -.->|"ε"|eNFA73_10_6774674
eNFA73_9_38035443 -->|"u"|eNFA73_11_60972066
eNFA73_10_6774674 -->|"u"|eNFA73_11_60972066
eNFA73_11_60972066 -.->|"ε"|eNFA73_12_11877685
eNFA73_11_60972066 -->|"t"|eNFA73_13_39790309
eNFA73_12_11877685 -->|"t"|eNFA73_13_39790309
eNFA73_13_39790309 -.->|"ε"|eNFA73_14_22568466
eNFA73_13_39790309 -->|"i"|eNFA73_15_1789605
eNFA73_14_22568466 -->|"i"|eNFA73_15_1789605
eNFA73_15_1789605 -.->|"ε"|eNFA73_16_16106447
eNFA73_15_1789605 -->|"n"|eNFA73_17_10740297
eNFA73_16_16106447 -->|"n"|eNFA73_17_10740297
eNFA73_17_10740297 -.->|"ε"|eNFA73_18_29553812
eNFA73_17_10740297 -->|"e"|eNFA73_19_64657722
eNFA73_18_29553812 -->|"e"|eNFA73_19_64657722
eNFA73_19_64657722 -.->|"ε"|eNFA73_21_45048586
eNFA73_19_64657722 -.->|"ε"|eNFA73_22_2784095
eNFA73_19_64657722 -.->|"ε"|eNFA73_23_25056856
eNFA73_21_45048586 -.->|"ε"|eNFA73_22_2784095
eNFA73_21_45048586 -.->|"ε"|eNFA73_23_25056856
eNFA73_22_2784095 -.->|"ε"|eNFA73_23_25056856
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
NFA73_20_24185120("NFA73-20 regex start")
NFA73_1_16339495("NFA73-1 char[1]")
NFA73_3_12837735("NFA73-3 char[1]")
NFA73_5_48430751("NFA73-5 char[1]")
NFA73_7_33223577("NFA73-7 char[1]")
NFA73_9_30576743("NFA73-9 char[1]")
NFA73_11_6755232("NFA73-11 char[1]")
NFA73_13_60797095("NFA73-13 char[1]")
NFA73_15_10302948("NFA73-15 char[1]")
NFA73_17_25617672("NFA73-17 char[1]")
NFA73_19_29232460[\"NFA73-19 char[1]"/]
NFA73_20_24185120 -->|"s"|NFA73_1_16339495
NFA73_1_16339495 -->|"u"|NFA73_3_12837735
NFA73_3_12837735 -->|"b"|NFA73_5_48430751
NFA73_5_48430751 -->|"r"|NFA73_7_33223577
NFA73_7_33223577 -->|"o"|NFA73_9_30576743
NFA73_9_30576743 -->|"u"|NFA73_11_6755232
NFA73_11_6755232 -->|"t"|NFA73_13_60797095
NFA73_13_60797095 -->|"i"|NFA73_15_10302948
NFA73_15_10302948 -->|"n"|NFA73_17_25617672
NFA73_17_25617672 -->|"e"|NFA73_19_29232460
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
subgraph DFA0_-1931957507["DFA0 regex start"]
NFA73_20_24185120_0("NFA73-20 regex start")
end
subgraph DFA1_1385596475["DFA1 {1}"]
NFA73_1_16339495_1("NFA73-1 char[1]")
end
subgraph DFA2_1268595377["DFA2 {1}"]
NFA73_3_12837735_2("NFA73-3 char[1]")
end
subgraph DFA3_-1147475265["DFA3 {1}"]
NFA73_5_48430751_3("NFA73-5 char[1]")
end
subgraph DFA4_-1825098644["DFA4 {1}"]
NFA73_7_33223577_4("NFA73-7 char[1]")
end
subgraph DFA5_545778906["DFA5 {1}"]
NFA73_9_30576743_5("NFA73-9 char[1]")
end
subgraph DFA6_1695000978["DFA6 {1}"]
NFA73_11_6755232_6("NFA73-11 char[1]")
end
subgraph DFA7_2064402841["DFA7 {1}"]
NFA73_13_60797095_7("NFA73-13 char[1]")
end
subgraph DFA8_-1199615018["DFA8 {1}"]
NFA73_15_10302948_8("NFA73-15 char[1]")
end
subgraph DFA9_-793741010["DFA9 {1}"]
NFA73_17_25617672_9("NFA73-17 char[1]")
end
subgraph DFA10_-184937597["DFA10 {1}"]
NFA73_19_29232460_10[\"NFA73-19 char[1]"/]
end
DFA0_-1931957507 -->|"s"|DFA1_1385596475
DFA1_1385596475 -->|"u"|DFA2_1268595377
DFA2_1268595377 -->|"b"|DFA3_-1147475265
DFA3_-1147475265 -->|"r"|DFA4_-1825098644
DFA4_-1825098644 -->|"o"|DFA5_545778906
DFA5_545778906 -->|"u"|DFA6_1695000978
DFA6_1695000978 -->|"t"|DFA7_2064402841
DFA7_2064402841 -->|"i"|DFA8_-1199615018
DFA8_-1199615018 -->|"n"|DFA9_-793741010
DFA9_-793741010 -->|"e"|DFA10_-184937597
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
DFA0_-1931957507{{"DFA0 regex start"}}
DFA1_1385596475{{"DFA1 {1}"}}
DFA2_1268595377{{"DFA2 {1}"}}
DFA3_-1147475265{{"DFA3 {1}"}}
DFA4_-1825098644{{"DFA4 {1}"}}
DFA5_545778906{{"DFA5 {1}"}}
DFA6_1695000978{{"DFA6 {1}"}}
DFA7_2064402841{{"DFA7 {1}"}}
DFA8_-1199615018{{"DFA8 {1}"}}
DFA9_-793741010{{"DFA9 {1}"}}
DFA10_-184937597[\"DFA10 {1}"/]
DFA0_-1931957507 -->|"s"|DFA1_1385596475
DFA1_1385596475 -->|"u"|DFA2_1268595377
DFA2_1268595377 -->|"b"|DFA3_-1147475265
DFA3_-1147475265 -->|"r"|DFA4_-1825098644
DFA4_-1825098644 -->|"o"|DFA5_545778906
DFA5_545778906 -->|"u"|DFA6_1695000978
DFA6_1695000978 -->|"t"|DFA7_2064402841
DFA7_2064402841 -->|"i"|DFA8_-1199615018
DFA8_-1199615018 -->|"n"|DFA9_-793741010
DFA9_-793741010 -->|"e"|DFA10_-184937597
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
subgraph MiniDFA0_-550326735["MiniDFA0 {1}"]
DFA0_-1931957507_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1397660306["MiniDFA1 {1}"]
DFA1_1385596475_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-1488144684["MiniDFA3 {1}"]
DFA2_1268595377_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-663812133["MiniDFA4 {1}"]
DFA3_-1147475265_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1502544574["MiniDFA5 {1}"]
DFA4_-1825098644_4{{"DFA4 {1}"}}
end
subgraph MiniDFA2_1934544609["MiniDFA2 {1}"]
DFA5_545778906_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-292616227["MiniDFA6 {1}"]
DFA6_1695000978_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_588024407["MiniDFA7 {1}"]
DFA7_2064402841_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_341146331["MiniDFA8 {1}"]
DFA8_-1199615018_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-843250212["MiniDFA9 {1}"]
DFA9_-793741010_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1987362894["MiniDFA10 {1}"]
DFA10_-184937597_10[\"DFA10 {1}"/]
end
MiniDFA0_-550326735 -->|"s"|MiniDFA1_1397660306
MiniDFA1_1397660306 -->|"u"|MiniDFA3_-1488144684
MiniDFA3_-1488144684 -->|"b"|MiniDFA4_-663812133
MiniDFA4_-663812133 -->|"r"|MiniDFA5_-1502544574
MiniDFA5_-1502544574 -->|"o"|MiniDFA2_1934544609
MiniDFA2_1934544609 -->|"u"|MiniDFA6_-292616227
MiniDFA6_-292616227 -->|"t"|MiniDFA7_588024407
MiniDFA7_588024407 -->|"i"|MiniDFA8_341146331
MiniDFA8_341146331 -->|"n"|MiniDFA9_-843250212
MiniDFA9_-843250212 -->|"e"|MiniDFA10_-1987362894
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
MiniDFA0_-550326735(["MiniDFA0 {1}"])
MiniDFA1_1397660306(["MiniDFA1 {1}"])
MiniDFA3_-1488144684(["MiniDFA3 {1}"])
MiniDFA4_-663812133(["MiniDFA4 {1}"])
MiniDFA5_-1502544574(["MiniDFA5 {1}"])
MiniDFA2_1934544609(["MiniDFA2 {1}"])
MiniDFA6_-292616227(["MiniDFA6 {1}"])
MiniDFA7_588024407(["MiniDFA7 {1}"])
MiniDFA8_341146331(["MiniDFA8 {1}"])
MiniDFA9_-843250212(["MiniDFA9 {1}"])
MiniDFA10_-1987362894[\"MiniDFA10 {1}"/]
MiniDFA0_-550326735 -->|"s"|MiniDFA1_1397660306
MiniDFA1_1397660306 -->|"u"|MiniDFA3_-1488144684
MiniDFA3_-1488144684 -->|"b"|MiniDFA4_-663812133
MiniDFA4_-663812133 -->|"r"|MiniDFA5_-1502544574
MiniDFA5_-1502544574 -->|"o"|MiniDFA2_1934544609
MiniDFA2_1934544609 -->|"u"|MiniDFA6_-292616227
MiniDFA6_-292616227 -->|"t"|MiniDFA7_588024407
MiniDFA7_588024407 -->|"i"|MiniDFA8_341146331
MiniDFA8_341146331 -->|"n"|MiniDFA9_-843250212
MiniDFA9_-843250212 -->|"e"|MiniDFA10_-1987362894
```
-------------------------------
