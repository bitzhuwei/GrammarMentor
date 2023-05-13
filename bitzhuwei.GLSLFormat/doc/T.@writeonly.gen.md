# 'writeonly'

pattern: `writeonly`

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
eNFA72_18_12672845[["εNFA72-18 regex start"]]
eNFA72_0_46946741[["εNFA72-0 char{1, 1}"]]
eNFA72_1_19867487[["εNFA72-1 char[1]"]]
eNFA72_2_44589661[["εNFA72-2 char{1, 1}"]]
eNFA72_3_65762630[["εNFA72-3 char[1]"]]
eNFA72_4_54992765[["εNFA72-4 char{1, 1}"]]
eNFA72_5_25172842[["εNFA72-5 char[1]"]]
eNFA72_6_25228990[["εNFA72-6 char{1, 1}"]]
eNFA72_7_25734322[["εNFA72-7 char[1]"]]
eNFA72_8_30282311[["εNFA72-8 char{1, 1}"]]
eNFA72_9_4105351[["εNFA72-9 char[1]"]]
eNFA72_10_36948161[["εNFA72-10 char{1, 1}"]]
eNFA72_11_64098000[["εNFA72-11 char[1]"]]
eNFA72_12_40011092[["εNFA72-12 char{1, 1}"]]
eNFA72_13_24555510[["εNFA72-13 char[1]"]]
eNFA72_14_19672999[["εNFA72-14 char{1, 1}"]]
eNFA72_15_42839264[["εNFA72-15 char[1]"]]
eNFA72_16_50009058[["εNFA72-16 char{1, 1}"]]
eNFA72_17_47428342[["εNFA72-17 char[1]"]]
eNFA72_19_24201902[["εNFA72-19 regex end"]]
eNFA72_20_16490530[["εNFA72-20 post-regex start"]]
eNFA72_21_14197042[\"εNFA72-21 post-regex end"/]
eNFA72_18_12672845 -.->|"ε"|eNFA72_0_46946741
eNFA72_0_46946741 -->|"w"|eNFA72_1_19867487
eNFA72_1_19867487 -.->|"ε"|eNFA72_2_44589661
eNFA72_2_44589661 -->|"r"|eNFA72_3_65762630
eNFA72_3_65762630 -.->|"ε"|eNFA72_4_54992765
eNFA72_4_54992765 -->|"i"|eNFA72_5_25172842
eNFA72_5_25172842 -.->|"ε"|eNFA72_6_25228990
eNFA72_6_25228990 -->|"t"|eNFA72_7_25734322
eNFA72_7_25734322 -.->|"ε"|eNFA72_8_30282311
eNFA72_8_30282311 -->|"e"|eNFA72_9_4105351
eNFA72_9_4105351 -.->|"ε"|eNFA72_10_36948161
eNFA72_10_36948161 -->|"o"|eNFA72_11_64098000
eNFA72_11_64098000 -.->|"ε"|eNFA72_12_40011092
eNFA72_12_40011092 -->|"n"|eNFA72_13_24555510
eNFA72_13_24555510 -.->|"ε"|eNFA72_14_19672999
eNFA72_14_19672999 -->|"l"|eNFA72_15_42839264
eNFA72_15_42839264 -.->|"ε"|eNFA72_16_50009058
eNFA72_16_50009058 -->|"y"|eNFA72_17_47428342
eNFA72_17_47428342 -.->|"ε"|eNFA72_19_24201902
eNFA72_19_24201902 -.->|"ε"|eNFA72_20_16490530
eNFA72_20_16490530 -.->|"ε"|eNFA72_21_14197042
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
eNFA72_18_60664521[["εNFA72-18 regex start"]]
eNFA72_0_9109783[["εNFA72-0 char{1, 1}"]]
eNFA72_1_14879189[["εNFA72-1 char[1]"]]
eNFA72_2_66803845[["εNFA72-2 char{1, 1}"]]
eNFA72_3_64363694[["εNFA72-3 char[1]"]]
eNFA72_4_42402339[["εNFA72-4 char{1, 1}"]]
eNFA72_5_46076731[["εNFA72-5 char[1]"]]
eNFA72_6_12037401[["εNFA72-6 char{1, 1}"]]
eNFA72_7_41227749[["εNFA72-7 char[1]"]]
eNFA72_8_35505424[["εNFA72-8 char{1, 1}"]]
eNFA72_9_51113363[["εNFA72-9 char[1]"]]
eNFA72_10_57367087[["εNFA72-10 char{1, 1}"]]
eNFA72_11_46541742[["εNFA72-11 char[1]"]]
eNFA72_12_16222495[["εNFA72-12 char{1, 1}"]]
eNFA72_13_11784733[["εNFA72-13 char[1]"]]
eNFA72_14_38953736[["εNFA72-14 char{1, 1}"]]
eNFA72_15_15039305[["εNFA72-15 char[1]"]]
eNFA72_16_1136017[["εNFA72-16 char{1, 1}"]]
eNFA72_17_10224153[\"εNFA72-17 char[1]"/]
eNFA72_19_24908514[\"εNFA72-19 regex end"/]
eNFA72_20_22850037[\"εNFA72-20 post-regex start"/]
eNFA72_21_4323748[\"εNFA72-21 post-regex end"/]
eNFA72_18_60664521 -.->|"ε"|eNFA72_0_9109783
eNFA72_18_60664521 -->|"w"|eNFA72_1_14879189
eNFA72_0_9109783 -->|"w"|eNFA72_1_14879189
eNFA72_1_14879189 -.->|"ε"|eNFA72_2_66803845
eNFA72_1_14879189 -->|"r"|eNFA72_3_64363694
eNFA72_2_66803845 -->|"r"|eNFA72_3_64363694
eNFA72_3_64363694 -.->|"ε"|eNFA72_4_42402339
eNFA72_3_64363694 -->|"i"|eNFA72_5_46076731
eNFA72_4_42402339 -->|"i"|eNFA72_5_46076731
eNFA72_5_46076731 -.->|"ε"|eNFA72_6_12037401
eNFA72_5_46076731 -->|"t"|eNFA72_7_41227749
eNFA72_6_12037401 -->|"t"|eNFA72_7_41227749
eNFA72_7_41227749 -.->|"ε"|eNFA72_8_35505424
eNFA72_7_41227749 -->|"e"|eNFA72_9_51113363
eNFA72_8_35505424 -->|"e"|eNFA72_9_51113363
eNFA72_9_51113363 -.->|"ε"|eNFA72_10_57367087
eNFA72_9_51113363 -->|"o"|eNFA72_11_46541742
eNFA72_10_57367087 -->|"o"|eNFA72_11_46541742
eNFA72_11_46541742 -.->|"ε"|eNFA72_12_16222495
eNFA72_11_46541742 -->|"n"|eNFA72_13_11784733
eNFA72_12_16222495 -->|"n"|eNFA72_13_11784733
eNFA72_13_11784733 -.->|"ε"|eNFA72_14_38953736
eNFA72_13_11784733 -->|"l"|eNFA72_15_15039305
eNFA72_14_38953736 -->|"l"|eNFA72_15_15039305
eNFA72_15_15039305 -.->|"ε"|eNFA72_16_1136017
eNFA72_15_15039305 -->|"y"|eNFA72_17_10224153
eNFA72_16_1136017 -->|"y"|eNFA72_17_10224153
eNFA72_17_10224153 -.->|"ε"|eNFA72_19_24908514
eNFA72_17_10224153 -.->|"ε"|eNFA72_20_22850037
eNFA72_17_10224153 -.->|"ε"|eNFA72_21_4323748
eNFA72_19_24908514 -.->|"ε"|eNFA72_20_22850037
eNFA72_19_24908514 -.->|"ε"|eNFA72_21_4323748
eNFA72_20_22850037 -.->|"ε"|eNFA72_21_4323748
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
NFA72_18_38913734("NFA72-18 regex start")
NFA72_1_14679294("NFA72-1 char[1]")
NFA72_3_65004788("NFA72-3 char[1]")
NFA72_5_48172185("NFA72-5 char[1]")
NFA72_7_30896486("NFA72-7 char[1]")
NFA72_9_9632925("NFA72-9 char[1]")
NFA72_11_19587461("NFA72-11 char[1]")
NFA72_13_42069424("NFA72-13 char[1]")
NFA72_15_43080504("NFA72-15 char[1]")
NFA72_17_52180221[\"NFA72-17 char[1]"/]
NFA72_18_38913734 -->|"w"|NFA72_1_14679294
NFA72_1_14679294 -->|"r"|NFA72_3_65004788
NFA72_3_65004788 -->|"i"|NFA72_5_48172185
NFA72_5_48172185 -->|"t"|NFA72_7_30896486
NFA72_7_30896486 -->|"e"|NFA72_9_9632925
NFA72_9_9632925 -->|"o"|NFA72_11_19587461
NFA72_11_19587461 -->|"n"|NFA72_13_42069424
NFA72_13_42069424 -->|"l"|NFA72_15_43080504
NFA72_15_43080504 -->|"y"|NFA72_17_52180221
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
subgraph DFA0_-2138973822["DFA0 regex start"]
NFA72_18_38913734_0("NFA72-18 regex start")
end
subgraph DFA1_-1805508632["DFA1 {1}"]
NFA72_1_14679294_1("NFA72-1 char[1]")
end
subgraph DFA2_-1190980001["DFA2 {1}"]
NFA72_3_65004788_2("NFA72-3 char[1]")
end
subgraph DFA3_-1432599902["DFA3 {1}"]
NFA72_5_48172185_3("NFA72-5 char[1]")
end
subgraph DFA4_-1518941868["DFA4 {1}"]
NFA72_7_30896486_4("NFA72-7 char[1]")
end
subgraph DFA5_-220557769["DFA5 {1}"]
NFA72_9_9632925_5("NFA72-9 char[1]")
end
subgraph DFA6_-1534443757["DFA6 {1}"]
NFA72_11_19587461_6("NFA72-11 char[1]")
end
subgraph DFA7_-1493019807["DFA7 {1}"]
NFA72_13_42069424_7("NFA72-13 char[1]")
end
subgraph DFA8_-482388116["DFA8 {1}"]
NFA72_15_43080504_8("NFA72-15 char[1]")
end
subgraph DFA9_408973048["DFA9 {1}"]
NFA72_17_52180221_9[\"NFA72-17 char[1]"/]
end
DFA0_-2138973822 -->|"w"|DFA1_-1805508632
DFA1_-1805508632 -->|"r"|DFA2_-1190980001
DFA2_-1190980001 -->|"i"|DFA3_-1432599902
DFA3_-1432599902 -->|"t"|DFA4_-1518941868
DFA4_-1518941868 -->|"e"|DFA5_-220557769
DFA5_-220557769 -->|"o"|DFA6_-1534443757
DFA6_-1534443757 -->|"n"|DFA7_-1493019807
DFA7_-1493019807 -->|"l"|DFA8_-482388116
DFA8_-482388116 -->|"y"|DFA9_408973048
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
DFA0_-2138973822{{"DFA0 regex start"}}
DFA1_-1805508632{{"DFA1 {1}"}}
DFA2_-1190980001{{"DFA2 {1}"}}
DFA3_-1432599902{{"DFA3 {1}"}}
DFA4_-1518941868{{"DFA4 {1}"}}
DFA5_-220557769{{"DFA5 {1}"}}
DFA6_-1534443757{{"DFA6 {1}"}}
DFA7_-1493019807{{"DFA7 {1}"}}
DFA8_-482388116{{"DFA8 {1}"}}
DFA9_408973048[\"DFA9 {1}"/]
DFA0_-2138973822 -->|"w"|DFA1_-1805508632
DFA1_-1805508632 -->|"r"|DFA2_-1190980001
DFA2_-1190980001 -->|"i"|DFA3_-1432599902
DFA3_-1432599902 -->|"t"|DFA4_-1518941868
DFA4_-1518941868 -->|"e"|DFA5_-220557769
DFA5_-220557769 -->|"o"|DFA6_-1534443757
DFA6_-1534443757 -->|"n"|DFA7_-1493019807
DFA7_-1493019807 -->|"l"|DFA8_-482388116
DFA8_-482388116 -->|"y"|DFA9_408973048
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
subgraph MiniDFA0_-697960161["MiniDFA0 {1}"]
DFA0_-2138973822_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1446215679["MiniDFA1 {1}"]
DFA1_-1805508632_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1771315517["MiniDFA2 {1}"]
DFA2_-1190980001_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1543308854["MiniDFA3 {1}"]
DFA3_-1432599902_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-2147465107["MiniDFA4 {1}"]
DFA4_-1518941868_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1674987960["MiniDFA5 {1}"]
DFA5_-220557769_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1825677637["MiniDFA6 {1}"]
DFA6_-1534443757_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1213608070["MiniDFA7 {1}"]
DFA7_-1493019807_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1864461268["MiniDFA8 {1}"]
DFA8_-482388116_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-2077130438["MiniDFA9 {1}"]
DFA9_408973048_9[\"DFA9 {1}"/]
end
MiniDFA0_-697960161 -->|"w"|MiniDFA1_-1446215679
MiniDFA1_-1446215679 -->|"r"|MiniDFA2_-1771315517
MiniDFA2_-1771315517 -->|"i"|MiniDFA3_1543308854
MiniDFA3_1543308854 -->|"t"|MiniDFA4_-2147465107
MiniDFA4_-2147465107 -->|"e"|MiniDFA5_-1674987960
MiniDFA5_-1674987960 -->|"o"|MiniDFA6_-1825677637
MiniDFA6_-1825677637 -->|"n"|MiniDFA7_1213608070
MiniDFA7_1213608070 -->|"l"|MiniDFA8_-1864461268
MiniDFA8_-1864461268 -->|"y"|MiniDFA9_-2077130438
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
MiniDFA0_-697960161(["MiniDFA0 {1}"])
MiniDFA1_-1446215679(["MiniDFA1 {1}"])
MiniDFA2_-1771315517(["MiniDFA2 {1}"])
MiniDFA3_1543308854(["MiniDFA3 {1}"])
MiniDFA4_-2147465107(["MiniDFA4 {1}"])
MiniDFA5_-1674987960(["MiniDFA5 {1}"])
MiniDFA6_-1825677637(["MiniDFA6 {1}"])
MiniDFA7_1213608070(["MiniDFA7 {1}"])
MiniDFA8_-1864461268(["MiniDFA8 {1}"])
MiniDFA9_-2077130438[\"MiniDFA9 {1}"/]
MiniDFA0_-697960161 -->|"w"|MiniDFA1_-1446215679
MiniDFA1_-1446215679 -->|"r"|MiniDFA2_-1771315517
MiniDFA2_-1771315517 -->|"i"|MiniDFA3_1543308854
MiniDFA3_1543308854 -->|"t"|MiniDFA4_-2147465107
MiniDFA4_-2147465107 -->|"e"|MiniDFA5_-1674987960
MiniDFA5_-1674987960 -->|"o"|MiniDFA6_-1825677637
MiniDFA6_-1825677637 -->|"n"|MiniDFA7_1213608070
MiniDFA7_1213608070 -->|"l"|MiniDFA8_-1864461268
MiniDFA8_-1864461268 -->|"y"|MiniDFA9_-2077130438
```
-------------------------------
