# 'iimageBuffer'

pattern: `iimageBuffer`

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
eNFA176_24_4696217[["εNFA176-24 regex start"]]
eNFA176_0_42265954[["εNFA176-0 char{1, 1}"]]
eNFA176_1_44849269[["εNFA176-1 char[1]"]]
eNFA176_2_990244[["εNFA176-2 char{1, 1}"]]
eNFA176_3_8912198[["εNFA176-3 char[1]"]]
eNFA176_4_13100926[["εNFA176-4 char{1, 1}"]]
eNFA176_5_50799476[["εNFA176-5 char[1]"]]
eNFA176_6_54542105[["εNFA176-6 char{1, 1}"]]
eNFA176_7_21116902[["εNFA176-7 char[1]"]]
eNFA176_8_55834397[["εNFA176-8 char{1, 1}"]]
eNFA176_9_32747525[["εNFA176-9 char[1]"]]
eNFA176_10_26292272[["εNFA176-10 char{1, 1}"]]
eNFA176_11_35303864[["εNFA176-11 char[1]"]]
eNFA176_12_49299325[["εNFA176-12 char{1, 1}"]]
eNFA176_13_41040744[["εNFA176-13 char[1]"]]
eNFA176_14_33822378[["εNFA176-14 char{1, 1}"]]
eNFA176_15_35965948[["εNFA176-15 char[1]"]]
eNFA176_16_55258079[["εNFA176-16 char{1, 1}"]]
eNFA176_17_27560669[["εNFA176-17 char[1]"]]
eNFA176_18_46719429[["εNFA176-18 char{1, 1}"]]
eNFA176_19_17821682[["εNFA176-19 char[1]"]]
eNFA176_20_26177411[["εNFA176-20 char{1, 1}"]]
eNFA176_21_34270115[["εNFA176-21 char[1]"]]
eNFA176_22_39995586[["εNFA176-22 char{1, 1}"]]
eNFA176_23_24415962[["εNFA176-23 char[1]"]]
eNFA176_25_18417066[["εNFA176-25 regex end"]]
eNFA176_26_31535868[["εNFA176-26 post-regex start"]]
eNFA176_27_15387362[\"εNFA176-27 post-regex end"/]
eNFA176_24_4696217 -.->|"ε"|eNFA176_0_42265954
eNFA176_0_42265954 -->|"i"|eNFA176_1_44849269
eNFA176_1_44849269 -.->|"ε"|eNFA176_2_990244
eNFA176_2_990244 -->|"i"|eNFA176_3_8912198
eNFA176_3_8912198 -.->|"ε"|eNFA176_4_13100926
eNFA176_4_13100926 -->|"m"|eNFA176_5_50799476
eNFA176_5_50799476 -.->|"ε"|eNFA176_6_54542105
eNFA176_6_54542105 -->|"a"|eNFA176_7_21116902
eNFA176_7_21116902 -.->|"ε"|eNFA176_8_55834397
eNFA176_8_55834397 -->|"g"|eNFA176_9_32747525
eNFA176_9_32747525 -.->|"ε"|eNFA176_10_26292272
eNFA176_10_26292272 -->|"e"|eNFA176_11_35303864
eNFA176_11_35303864 -.->|"ε"|eNFA176_12_49299325
eNFA176_12_49299325 -->|"B"|eNFA176_13_41040744
eNFA176_13_41040744 -.->|"ε"|eNFA176_14_33822378
eNFA176_14_33822378 -->|"u"|eNFA176_15_35965948
eNFA176_15_35965948 -.->|"ε"|eNFA176_16_55258079
eNFA176_16_55258079 -->|"f"|eNFA176_17_27560669
eNFA176_17_27560669 -.->|"ε"|eNFA176_18_46719429
eNFA176_18_46719429 -->|"f"|eNFA176_19_17821682
eNFA176_19_17821682 -.->|"ε"|eNFA176_20_26177411
eNFA176_20_26177411 -->|"e"|eNFA176_21_34270115
eNFA176_21_34270115 -.->|"ε"|eNFA176_22_39995586
eNFA176_22_39995586 -->|"r"|eNFA176_23_24415962
eNFA176_23_24415962 -.->|"ε"|eNFA176_25_18417066
eNFA176_25_18417066 -.->|"ε"|eNFA176_26_31535868
eNFA176_26_31535868 -.->|"ε"|eNFA176_27_15387362
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
eNFA176_24_4268531[["εNFA176-24 regex start"]]
eNFA176_0_38416786[["εNFA176-0 char{1, 1}"]]
eNFA176_1_10206759[["εNFA176-1 char[1]"]]
eNFA176_2_24751971[["εNFA176-2 char{1, 1}"]]
eNFA176_3_21441151[["εNFA176-3 char[1]"]]
eNFA176_4_58752636[["εNFA176-4 char{1, 1}"]]
eNFA176_5_59011684[["εNFA176-5 char[1]"]]
eNFA176_6_61343110[["εNFA176-6 char{1, 1}"]]
eNFA176_7_15217085[["εNFA176-7 char[1]"]]
eNFA176_8_2736041[["εNFA176-8 char{1, 1}"]]
eNFA176_9_24624371[["εNFA176-9 char[1]"]]
eNFA176_10_20292748[["εNFA176-10 char{1, 1}"]]
eNFA176_11_48417005[["εNFA176-11 char[1]"]]
eNFA176_12_33099863[["εNFA176-12 char{1, 1}"]]
eNFA176_13_29463315[["εNFA176-13 char[1]"]]
eNFA176_14_63843251[["εNFA176-14 char{1, 1}"]]
eNFA176_15_37718351[["εNFA176-15 char[1]"]]
eNFA176_16_3920839[["εNFA176-16 char{1, 1}"]]
eNFA176_17_35287558[["εNFA176-17 char[1]"]]
eNFA176_18_49152572[["εNFA176-18 char{1, 1}"]]
eNFA176_19_39719970[["εNFA176-19 char[1]"]]
eNFA176_20_21935418[["εNFA176-20 char{1, 1}"]]
eNFA176_21_63201035[["εNFA176-21 char[1]"]]
eNFA176_22_31938408[["εNFA176-22 char{1, 1}"]]
eNFA176_23_19010216[\"εNFA176-23 char[1]"/]
eNFA176_25_36874222[\"εNFA176-25 regex end"/]
eNFA176_26_63432546[\"εNFA176-26 post-regex start"/]
eNFA176_27_34022005[\"εNFA176-27 post-regex end"/]
eNFA176_24_4268531 -.->|"ε"|eNFA176_0_38416786
eNFA176_24_4268531 -->|"i"|eNFA176_1_10206759
eNFA176_0_38416786 -->|"i"|eNFA176_1_10206759
eNFA176_1_10206759 -.->|"ε"|eNFA176_2_24751971
eNFA176_1_10206759 -->|"i"|eNFA176_3_21441151
eNFA176_2_24751971 -->|"i"|eNFA176_3_21441151
eNFA176_3_21441151 -.->|"ε"|eNFA176_4_58752636
eNFA176_3_21441151 -->|"m"|eNFA176_5_59011684
eNFA176_4_58752636 -->|"m"|eNFA176_5_59011684
eNFA176_5_59011684 -.->|"ε"|eNFA176_6_61343110
eNFA176_5_59011684 -->|"a"|eNFA176_7_15217085
eNFA176_6_61343110 -->|"a"|eNFA176_7_15217085
eNFA176_7_15217085 -.->|"ε"|eNFA176_8_2736041
eNFA176_7_15217085 -->|"g"|eNFA176_9_24624371
eNFA176_8_2736041 -->|"g"|eNFA176_9_24624371
eNFA176_9_24624371 -.->|"ε"|eNFA176_10_20292748
eNFA176_9_24624371 -->|"e"|eNFA176_11_48417005
eNFA176_10_20292748 -->|"e"|eNFA176_11_48417005
eNFA176_11_48417005 -.->|"ε"|eNFA176_12_33099863
eNFA176_11_48417005 -->|"B"|eNFA176_13_29463315
eNFA176_12_33099863 -->|"B"|eNFA176_13_29463315
eNFA176_13_29463315 -.->|"ε"|eNFA176_14_63843251
eNFA176_13_29463315 -->|"u"|eNFA176_15_37718351
eNFA176_14_63843251 -->|"u"|eNFA176_15_37718351
eNFA176_15_37718351 -.->|"ε"|eNFA176_16_3920839
eNFA176_15_37718351 -->|"f"|eNFA176_17_35287558
eNFA176_16_3920839 -->|"f"|eNFA176_17_35287558
eNFA176_17_35287558 -.->|"ε"|eNFA176_18_49152572
eNFA176_17_35287558 -->|"f"|eNFA176_19_39719970
eNFA176_18_49152572 -->|"f"|eNFA176_19_39719970
eNFA176_19_39719970 -.->|"ε"|eNFA176_20_21935418
eNFA176_19_39719970 -->|"e"|eNFA176_21_63201035
eNFA176_20_21935418 -->|"e"|eNFA176_21_63201035
eNFA176_21_63201035 -.->|"ε"|eNFA176_22_31938408
eNFA176_21_63201035 -->|"r"|eNFA176_23_19010216
eNFA176_22_31938408 -->|"r"|eNFA176_23_19010216
eNFA176_23_19010216 -.->|"ε"|eNFA176_25_36874222
eNFA176_23_19010216 -.->|"ε"|eNFA176_26_63432546
eNFA176_23_19010216 -.->|"ε"|eNFA176_27_34022005
eNFA176_25_36874222 -.->|"ε"|eNFA176_26_63432546
eNFA176_25_36874222 -.->|"ε"|eNFA176_27_34022005
eNFA176_26_63432546 -.->|"ε"|eNFA176_27_34022005
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
NFA176_24_37762592("NFA176-24 regex start")
NFA176_1_4319012("NFA176-1 char[1]")
NFA176_3_38871115("NFA176-3 char[1]")
NFA176_5_14295716("NFA176-5 char[1]")
NFA176_7_61552586("NFA176-7 char[1]")
NFA176_9_17102365("NFA176-9 char[1]")
NFA176_11_19703558("NFA176-11 char[1]")
NFA176_13_43114294("NFA176-13 char[1]")
NFA176_15_52484326("NFA176-15 char[1]")
NFA176_17_2596887("NFA176-17 char[1]")
NFA176_19_23371986("NFA176-19 char[1]")
NFA176_21_9021289("NFA176-21 char[1]")
NFA176_23_14082739[\"NFA176-23 char[1]"/]
NFA176_24_37762592 -->|"i"|NFA176_1_4319012
NFA176_1_4319012 -->|"i"|NFA176_3_38871115
NFA176_3_38871115 -->|"m"|NFA176_5_14295716
NFA176_5_14295716 -->|"a"|NFA176_7_61552586
NFA176_7_61552586 -->|"g"|NFA176_9_17102365
NFA176_9_17102365 -->|"e"|NFA176_11_19703558
NFA176_11_19703558 -->|"B"|NFA176_13_43114294
NFA176_13_43114294 -->|"u"|NFA176_15_52484326
NFA176_15_52484326 -->|"f"|NFA176_17_2596887
NFA176_17_2596887 -->|"f"|NFA176_19_23371986
NFA176_19_23371986 -->|"e"|NFA176_21_9021289
NFA176_21_9021289 -->|"r"|NFA176_23_14082739
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
subgraph DFA0_-82303432["DFA0 regex start"]
NFA176_24_37762592_0("NFA176-24 regex start")
end
subgraph DFA1_1101390788["DFA1 {1}"]
NFA176_1_4319012_1("NFA176-1 char[1]")
end
subgraph DFA2_-1731802125["DFA2 {1}"]
NFA176_3_38871115_2("NFA176-3 char[1]")
end
subgraph DFA3_-1978662175["DFA3 {1}"]
NFA176_5_14295716_3("NFA176-5 char[1]")
end
subgraph DFA4_1954737831["DFA4 {1}"]
NFA176_7_61552586_4("NFA176-7 char[1]")
end
subgraph DFA5_-1864316376["DFA5 {1}"]
NFA176_9_17102365_5("NFA176-9 char[1]")
end
subgraph DFA6_863276099["DFA6 {1}"]
NFA176_11_19703558_6("NFA176-11 char[1]")
end
subgraph DFA7_774227161["DFA7 {1}"]
NFA176_13_43114294_7("NFA176-13 char[1]")
end
subgraph DFA8_-1512433187["DFA8 {1}"]
NFA176_15_52484326_8("NFA176-15 char[1]")
end
subgraph DFA9_2054496577["DFA9 {1}"]
NFA176_17_2596887_9("NFA176-17 char[1]")
end
subgraph DFA10_1481896995["DFA10 {1}"]
NFA176_19_23371986_10("NFA176-19 char[1]")
end
subgraph DFA11_-487297774["DFA11 {1}"]
NFA176_21_9021289_11("NFA176-21 char[1]")
end
subgraph DFA12_926824493["DFA12 {1}"]
NFA176_23_14082739_12[\"NFA176-23 char[1]"/]
end
DFA0_-82303432 -->|"i"|DFA1_1101390788
DFA1_1101390788 -->|"i"|DFA2_-1731802125
DFA2_-1731802125 -->|"m"|DFA3_-1978662175
DFA3_-1978662175 -->|"a"|DFA4_1954737831
DFA4_1954737831 -->|"g"|DFA5_-1864316376
DFA5_-1864316376 -->|"e"|DFA6_863276099
DFA6_863276099 -->|"B"|DFA7_774227161
DFA7_774227161 -->|"u"|DFA8_-1512433187
DFA8_-1512433187 -->|"f"|DFA9_2054496577
DFA9_2054496577 -->|"f"|DFA10_1481896995
DFA10_1481896995 -->|"e"|DFA11_-487297774
DFA11_-487297774 -->|"r"|DFA12_926824493
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
DFA0_-82303432{{"DFA0 regex start"}}
DFA1_1101390788{{"DFA1 {1}"}}
DFA2_-1731802125{{"DFA2 {1}"}}
DFA3_-1978662175{{"DFA3 {1}"}}
DFA4_1954737831{{"DFA4 {1}"}}
DFA5_-1864316376{{"DFA5 {1}"}}
DFA6_863276099{{"DFA6 {1}"}}
DFA7_774227161{{"DFA7 {1}"}}
DFA8_-1512433187{{"DFA8 {1}"}}
DFA9_2054496577{{"DFA9 {1}"}}
DFA10_1481896995{{"DFA10 {1}"}}
DFA11_-487297774{{"DFA11 {1}"}}
DFA12_926824493[\"DFA12 {1}"/]
DFA0_-82303432 -->|"i"|DFA1_1101390788
DFA1_1101390788 -->|"i"|DFA2_-1731802125
DFA2_-1731802125 -->|"m"|DFA3_-1978662175
DFA3_-1978662175 -->|"a"|DFA4_1954737831
DFA4_1954737831 -->|"g"|DFA5_-1864316376
DFA5_-1864316376 -->|"e"|DFA6_863276099
DFA6_863276099 -->|"B"|DFA7_774227161
DFA7_774227161 -->|"u"|DFA8_-1512433187
DFA8_-1512433187 -->|"f"|DFA9_2054496577
DFA9_2054496577 -->|"f"|DFA10_1481896995
DFA10_1481896995 -->|"e"|DFA11_-487297774
DFA11_-487297774 -->|"r"|DFA12_926824493
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
subgraph MiniDFA0_1152053340["MiniDFA0 {1}"]
DFA0_-82303432_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1773409867["MiniDFA1 {1}"]
DFA1_1101390788_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1127051688["MiniDFA2 {1}"]
DFA2_-1731802125_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1554897226["MiniDFA3 {1}"]
DFA3_-1978662175_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-938307761["MiniDFA4 {1}"]
DFA4_1954737831_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_753882331["MiniDFA5 {1}"]
DFA5_-1864316376_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-558796709["MiniDFA7 {1}"]
DFA6_863276099_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_413063757["MiniDFA8 {1}"]
DFA7_774227161_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1979638011["MiniDFA9 {1}"]
DFA8_-1512433187_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_1935731111["MiniDFA10 {1}"]
DFA9_2054496577_9{{"DFA9 {1}"}}
end
subgraph MiniDFA6_787695045["MiniDFA6 {1}"]
DFA10_1481896995_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_464234208["MiniDFA11 {1}"]
DFA11_-487297774_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-228054429["MiniDFA12 {1}"]
DFA12_926824493_12[\"DFA12 {1}"/]
end
MiniDFA0_1152053340 -->|"i"|MiniDFA1_-1773409867
MiniDFA1_-1773409867 -->|"i"|MiniDFA2_1127051688
MiniDFA2_1127051688 -->|"m"|MiniDFA3_1554897226
MiniDFA3_1554897226 -->|"a"|MiniDFA4_-938307761
MiniDFA4_-938307761 -->|"g"|MiniDFA5_753882331
MiniDFA5_753882331 -->|"e"|MiniDFA7_-558796709
MiniDFA7_-558796709 -->|"B"|MiniDFA8_413063757
MiniDFA8_413063757 -->|"u"|MiniDFA9_-1979638011
MiniDFA9_-1979638011 -->|"f"|MiniDFA10_1935731111
MiniDFA10_1935731111 -->|"f"|MiniDFA6_787695045
MiniDFA6_787695045 -->|"e"|MiniDFA11_464234208
MiniDFA11_464234208 -->|"r"|MiniDFA12_-228054429
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
MiniDFA0_1152053340(["MiniDFA0 {1}"])
MiniDFA1_-1773409867(["MiniDFA1 {1}"])
MiniDFA2_1127051688(["MiniDFA2 {1}"])
MiniDFA3_1554897226(["MiniDFA3 {1}"])
MiniDFA4_-938307761(["MiniDFA4 {1}"])
MiniDFA5_753882331(["MiniDFA5 {1}"])
MiniDFA7_-558796709(["MiniDFA7 {1}"])
MiniDFA8_413063757(["MiniDFA8 {1}"])
MiniDFA9_-1979638011(["MiniDFA9 {1}"])
MiniDFA10_1935731111(["MiniDFA10 {1}"])
MiniDFA6_787695045(["MiniDFA6 {1}"])
MiniDFA11_464234208(["MiniDFA11 {1}"])
MiniDFA12_-228054429[\"MiniDFA12 {1}"/]
MiniDFA0_1152053340 -->|"i"|MiniDFA1_-1773409867
MiniDFA1_-1773409867 -->|"i"|MiniDFA2_1127051688
MiniDFA2_1127051688 -->|"m"|MiniDFA3_1554897226
MiniDFA3_1554897226 -->|"a"|MiniDFA4_-938307761
MiniDFA4_-938307761 -->|"g"|MiniDFA5_753882331
MiniDFA5_753882331 -->|"e"|MiniDFA7_-558796709
MiniDFA7_-558796709 -->|"B"|MiniDFA8_413063757
MiniDFA8_413063757 -->|"u"|MiniDFA9_-1979638011
MiniDFA9_-1979638011 -->|"f"|MiniDFA10_1935731111
MiniDFA10_1935731111 -->|"f"|MiniDFA6_787695045
MiniDFA6_787695045 -->|"e"|MiniDFA11_464234208
MiniDFA11_464234208 -->|"r"|MiniDFA12_-228054429
```
-------------------------------
