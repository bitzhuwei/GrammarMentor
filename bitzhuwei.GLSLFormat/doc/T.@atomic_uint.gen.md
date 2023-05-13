# 'atomic_uint'

pattern: `atomic_uint`

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
eNFA119_22_63964730[["εNFA119-22 regex start"]]
eNFA119_0_38811664[["εNFA119-0 char{1, 1}"]]
eNFA119_1_13760664[["εNFA119-1 char[1]"]]
eNFA119_2_56737113[["εNFA119-2 char{1, 1}"]]
eNFA119_3_40871974[["εNFA119-3 char[1]"]]
eNFA119_4_32303446[["εNFA119-4 char{1, 1}"]]
eNFA119_5_22295564[["εNFA119-5 char[1]"]]
eNFA119_6_66442352[["εNFA119-6 char{1, 1}"]]
eNFA119_7_61110259[["εNFA119-7 char[1]"]]
eNFA119_8_13121422[["εNFA119-8 char{1, 1}"]]
eNFA119_9_50983938[["εNFA119-9 char[1]"]]
eNFA119_10_56202265[["εNFA119-10 char{1, 1}"]]
eNFA119_11_36058338[["εNFA119-11 char[1]"]]
eNFA119_12_56089592[["εNFA119-12 char{1, 1}"]]
eNFA119_13_35044283[["εNFA119-13 char[1]"]]
eNFA119_14_46963092[["εNFA119-14 char{1, 1}"]]
eNFA119_15_20014644[["εNFA119-15 char[1]"]]
eNFA119_16_45914068[["εNFA119-16 char{1, 1}"]]
eNFA119_17_10573429[["εNFA119-17 char[1]"]]
eNFA119_18_28052000[["εNFA119-18 char{1, 1}"]]
eNFA119_19_51141415[["εNFA119-19 char[1]"]]
eNFA119_20_57619553[["εNFA119-20 char{1, 1}"]]
eNFA119_21_48813937[["εNFA119-21 char[1]"]]
eNFA119_23_36672255[["εNFA119-23 regex end"]]
eNFA119_24_61614844[["εNFA119-24 post-regex start"]]
eNFA119_25_17662689[\"εNFA119-25 post-regex end"/]
eNFA119_22_63964730 -.->|"ε"|eNFA119_0_38811664
eNFA119_0_38811664 -->|"a"|eNFA119_1_13760664
eNFA119_1_13760664 -.->|"ε"|eNFA119_2_56737113
eNFA119_2_56737113 -->|"t"|eNFA119_3_40871974
eNFA119_3_40871974 -.->|"ε"|eNFA119_4_32303446
eNFA119_4_32303446 -->|"o"|eNFA119_5_22295564
eNFA119_5_22295564 -.->|"ε"|eNFA119_6_66442352
eNFA119_6_66442352 -->|"m"|eNFA119_7_61110259
eNFA119_7_61110259 -.->|"ε"|eNFA119_8_13121422
eNFA119_8_13121422 -->|"i"|eNFA119_9_50983938
eNFA119_9_50983938 -.->|"ε"|eNFA119_10_56202265
eNFA119_10_56202265 -->|"c"|eNFA119_11_36058338
eNFA119_11_36058338 -.->|"ε"|eNFA119_12_56089592
eNFA119_12_56089592 -->|"_"|eNFA119_13_35044283
eNFA119_13_35044283 -.->|"ε"|eNFA119_14_46963092
eNFA119_14_46963092 -->|"u"|eNFA119_15_20014644
eNFA119_15_20014644 -.->|"ε"|eNFA119_16_45914068
eNFA119_16_45914068 -->|"i"|eNFA119_17_10573429
eNFA119_17_10573429 -.->|"ε"|eNFA119_18_28052000
eNFA119_18_28052000 -->|"n"|eNFA119_19_51141415
eNFA119_19_51141415 -.->|"ε"|eNFA119_20_57619553
eNFA119_20_57619553 -->|"t"|eNFA119_21_48813937
eNFA119_21_48813937 -.->|"ε"|eNFA119_23_36672255
eNFA119_23_36672255 -.->|"ε"|eNFA119_24_61614844
eNFA119_24_61614844 -.->|"ε"|eNFA119_25_17662689
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
eNFA119_22_24746480[["εNFA119-22 regex start"]]
eNFA119_0_21391728[["εNFA119-0 char{1, 1}"]]
eNFA119_1_58307827[["εNFA119-1 char[1]"]]
eNFA119_2_55008403[["εNFA119-2 char{1, 1}"]]
eNFA119_3_25313584[["εNFA119-3 char[1]"]]
eNFA119_4_26495667[["εNFA119-4 char{1, 1}"]]
eNFA119_5_37134413[["εNFA119-5 char[1]"]]
eNFA119_6_65774263[["εNFA119-6 char{1, 1}"]]
eNFA119_7_55097458[["εNFA119-7 char[1]"]]
eNFA119_8_26115080[["εNFA119-8 char{1, 1}"]]
eNFA119_9_33709128[["εNFA119-9 char[1]"]]
eNFA119_10_34946701[["εNFA119-10 char{1, 1}"]]
eNFA119_11_46084854[["εNFA119-11 char[1]"]]
eNFA119_12_12110510[["εNFA119-12 char{1, 1}"]]
eNFA119_13_41885733[["εNFA119-13 char[1]"]]
eNFA119_14_41427285[["εNFA119-14 char{1, 1}"]]
eNFA119_15_37301245[["εNFA119-15 char[1]"]]
eNFA119_16_166887[["εNFA119-16 char{1, 1}"]]
eNFA119_17_1501989[["εNFA119-17 char[1]"]]
eNFA119_18_13517902[["εNFA119-18 char{1, 1}"]]
eNFA119_19_54552261[["εNFA119-19 char[1]"]]
eNFA119_20_21208306[["εNFA119-20 char{1, 1}"]]
eNFA119_21_56657030[\"εNFA119-21 char[1]"/]
eNFA119_23_40151226[\"εNFA119-23 regex end"/]
eNFA119_24_25816719[\"εNFA119-24 post-regex start"/]
eNFA119_25_31023887[\"εNFA119-25 post-regex end"/]
eNFA119_22_24746480 -.->|"ε"|eNFA119_0_21391728
eNFA119_22_24746480 -->|"a"|eNFA119_1_58307827
eNFA119_0_21391728 -->|"a"|eNFA119_1_58307827
eNFA119_1_58307827 -.->|"ε"|eNFA119_2_55008403
eNFA119_1_58307827 -->|"t"|eNFA119_3_25313584
eNFA119_2_55008403 -->|"t"|eNFA119_3_25313584
eNFA119_3_25313584 -.->|"ε"|eNFA119_4_26495667
eNFA119_3_25313584 -->|"o"|eNFA119_5_37134413
eNFA119_4_26495667 -->|"o"|eNFA119_5_37134413
eNFA119_5_37134413 -.->|"ε"|eNFA119_6_65774263
eNFA119_5_37134413 -->|"m"|eNFA119_7_55097458
eNFA119_6_65774263 -->|"m"|eNFA119_7_55097458
eNFA119_7_55097458 -.->|"ε"|eNFA119_8_26115080
eNFA119_7_55097458 -->|"i"|eNFA119_9_33709128
eNFA119_8_26115080 -->|"i"|eNFA119_9_33709128
eNFA119_9_33709128 -.->|"ε"|eNFA119_10_34946701
eNFA119_9_33709128 -->|"c"|eNFA119_11_46084854
eNFA119_10_34946701 -->|"c"|eNFA119_11_46084854
eNFA119_11_46084854 -.->|"ε"|eNFA119_12_12110510
eNFA119_11_46084854 -->|"_"|eNFA119_13_41885733
eNFA119_12_12110510 -->|"_"|eNFA119_13_41885733
eNFA119_13_41885733 -.->|"ε"|eNFA119_14_41427285
eNFA119_13_41885733 -->|"u"|eNFA119_15_37301245
eNFA119_14_41427285 -->|"u"|eNFA119_15_37301245
eNFA119_15_37301245 -.->|"ε"|eNFA119_16_166887
eNFA119_15_37301245 -->|"i"|eNFA119_17_1501989
eNFA119_16_166887 -->|"i"|eNFA119_17_1501989
eNFA119_17_1501989 -.->|"ε"|eNFA119_18_13517902
eNFA119_17_1501989 -->|"n"|eNFA119_19_54552261
eNFA119_18_13517902 -->|"n"|eNFA119_19_54552261
eNFA119_19_54552261 -.->|"ε"|eNFA119_20_21208306
eNFA119_19_54552261 -->|"t"|eNFA119_21_56657030
eNFA119_20_21208306 -->|"t"|eNFA119_21_56657030
eNFA119_21_56657030 -.->|"ε"|eNFA119_23_40151226
eNFA119_21_56657030 -.->|"ε"|eNFA119_24_25816719
eNFA119_21_56657030 -.->|"ε"|eNFA119_25_31023887
eNFA119_23_40151226 -.->|"ε"|eNFA119_24_25816719
eNFA119_23_40151226 -.->|"ε"|eNFA119_25_31023887
eNFA119_24_25816719 -.->|"ε"|eNFA119_25_31023887
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
NFA119_22_10779529("NFA119-22 regex start")
NFA119_1_29906904("NFA119-1 char[1]")
NFA119_3_726684("NFA119-3 char[1]")
NFA119_5_6540158("NFA119-5 char[1]")
NFA119_7_58861423("NFA119-7 char[1]")
NFA119_9_59990760("NFA119-9 char[1]")
NFA119_11_3045930("NFA119-11 char[1]")
NFA119_13_27413374("NFA119-13 char[1]")
NFA119_15_45393782("NFA119-15 char[1]")
NFA119_17_5890858("NFA119-17 char[1]")
NFA119_19_53017722("NFA119-19 char[1]")
NFA119_21_7397457[\"NFA119-21 char[1]"/]
NFA119_22_10779529 -->|"a"|NFA119_1_29906904
NFA119_1_29906904 -->|"t"|NFA119_3_726684
NFA119_3_726684 -->|"o"|NFA119_5_6540158
NFA119_5_6540158 -->|"m"|NFA119_7_58861423
NFA119_7_58861423 -->|"i"|NFA119_9_59990760
NFA119_9_59990760 -->|"c"|NFA119_11_3045930
NFA119_11_3045930 -->|"_"|NFA119_13_27413374
NFA119_13_27413374 -->|"u"|NFA119_15_45393782
NFA119_15_45393782 -->|"i"|NFA119_17_5890858
NFA119_17_5890858 -->|"n"|NFA119_19_53017722
NFA119_19_53017722 -->|"t"|NFA119_21_7397457
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
subgraph DFA0_356919006["DFA0 regex start"]
NFA119_22_10779529_0("NFA119-22 regex start")
end
subgraph DFA1_1304530656["DFA1 {1}"]
NFA119_1_29906904_1("NFA119-1 char[1]")
end
subgraph DFA2_-156234316["DFA2 {1}"]
NFA119_3_726684_2("NFA119-3 char[1]")
end
subgraph DFA3_-448709284["DFA3 {1}"]
NFA119_5_6540158_3("NFA119-5 char[1]")
end
subgraph DFA4_1875026795["DFA4 {1}"]
NFA119_7_58861423_4("NFA119-7 char[1]")
end
subgraph DFA5_1728423432["DFA5 {1}"]
NFA119_9_59990760_5("NFA119-9 char[1]")
end
subgraph DFA6_-2074237331["DFA6 {1}"]
NFA119_11_3045930_6("NFA119-11 char[1]")
end
subgraph DFA7_-889900909["DFA7 {1}"]
NFA119_13_27413374_7("NFA119-13 char[1]")
end
subgraph DFA8_-288626550["DFA8 {1}"]
NFA119_15_45393782_8("NFA119-15 char[1]")
end
subgraph DFA9_-2061692082["DFA9 {1}"]
NFA119_17_5890858_9("NFA119-17 char[1]")
end
subgraph DFA10_-414449253["DFA10 {1}"]
NFA119_19_53017722_10("NFA119-19 char[1]")
end
subgraph DFA11_1481778302["DFA11 {1}"]
NFA119_21_7397457_11[\"NFA119-21 char[1]"/]
end
DFA0_356919006 -->|"a"|DFA1_1304530656
DFA1_1304530656 -->|"t"|DFA2_-156234316
DFA2_-156234316 -->|"o"|DFA3_-448709284
DFA3_-448709284 -->|"m"|DFA4_1875026795
DFA4_1875026795 -->|"i"|DFA5_1728423432
DFA5_1728423432 -->|"c"|DFA6_-2074237331
DFA6_-2074237331 -->|"_"|DFA7_-889900909
DFA7_-889900909 -->|"u"|DFA8_-288626550
DFA8_-288626550 -->|"i"|DFA9_-2061692082
DFA9_-2061692082 -->|"n"|DFA10_-414449253
DFA10_-414449253 -->|"t"|DFA11_1481778302
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
DFA0_356919006{{"DFA0 regex start"}}
DFA1_1304530656{{"DFA1 {1}"}}
DFA2_-156234316{{"DFA2 {1}"}}
DFA3_-448709284{{"DFA3 {1}"}}
DFA4_1875026795{{"DFA4 {1}"}}
DFA5_1728423432{{"DFA5 {1}"}}
DFA6_-2074237331{{"DFA6 {1}"}}
DFA7_-889900909{{"DFA7 {1}"}}
DFA8_-288626550{{"DFA8 {1}"}}
DFA9_-2061692082{{"DFA9 {1}"}}
DFA10_-414449253{{"DFA10 {1}"}}
DFA11_1481778302[\"DFA11 {1}"/]
DFA0_356919006 -->|"a"|DFA1_1304530656
DFA1_1304530656 -->|"t"|DFA2_-156234316
DFA2_-156234316 -->|"o"|DFA3_-448709284
DFA3_-448709284 -->|"m"|DFA4_1875026795
DFA4_1875026795 -->|"i"|DFA5_1728423432
DFA5_1728423432 -->|"c"|DFA6_-2074237331
DFA6_-2074237331 -->|"_"|DFA7_-889900909
DFA7_-889900909 -->|"u"|DFA8_-288626550
DFA8_-288626550 -->|"i"|DFA9_-2061692082
DFA9_-2061692082 -->|"n"|DFA10_-414449253
DFA10_-414449253 -->|"t"|DFA11_1481778302
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
subgraph MiniDFA0_185271649["MiniDFA0 {1}"]
DFA0_356919006_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_778012036["MiniDFA1 {1}"]
DFA1_1304530656_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_873938134["MiniDFA2 {1}"]
DFA2_-156234316_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-2132424560["MiniDFA3 {1}"]
DFA3_-448709284_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-960169769["MiniDFA4 {1}"]
DFA4_1875026795_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1762128315["MiniDFA6 {1}"]
DFA5_1728423432_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_604245539["MiniDFA7 {1}"]
DFA6_-2074237331_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1123450314["MiniDFA8 {1}"]
DFA7_-889900909_7{{"DFA7 {1}"}}
end
subgraph MiniDFA5_-121151674["MiniDFA5 {1}"]
DFA8_-288626550_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_803249303["MiniDFA9 {1}"]
DFA9_-2061692082_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_559637758["MiniDFA10 {1}"]
DFA10_-414449253_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-4640144["MiniDFA11 {1}"]
DFA11_1481778302_11[\"DFA11 {1}"/]
end
MiniDFA0_185271649 -->|"a"|MiniDFA1_778012036
MiniDFA1_778012036 -->|"t"|MiniDFA2_873938134
MiniDFA2_873938134 -->|"o"|MiniDFA3_-2132424560
MiniDFA3_-2132424560 -->|"m"|MiniDFA4_-960169769
MiniDFA4_-960169769 -->|"i"|MiniDFA6_1762128315
MiniDFA6_1762128315 -->|"c"|MiniDFA7_604245539
MiniDFA7_604245539 -->|"_"|MiniDFA8_-1123450314
MiniDFA8_-1123450314 -->|"u"|MiniDFA5_-121151674
MiniDFA5_-121151674 -->|"i"|MiniDFA9_803249303
MiniDFA9_803249303 -->|"n"|MiniDFA10_559637758
MiniDFA10_559637758 -->|"t"|MiniDFA11_-4640144
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
MiniDFA0_185271649(["MiniDFA0 {1}"])
MiniDFA1_778012036(["MiniDFA1 {1}"])
MiniDFA2_873938134(["MiniDFA2 {1}"])
MiniDFA3_-2132424560(["MiniDFA3 {1}"])
MiniDFA4_-960169769(["MiniDFA4 {1}"])
MiniDFA6_1762128315(["MiniDFA6 {1}"])
MiniDFA7_604245539(["MiniDFA7 {1}"])
MiniDFA8_-1123450314(["MiniDFA8 {1}"])
MiniDFA5_-121151674(["MiniDFA5 {1}"])
MiniDFA9_803249303(["MiniDFA9 {1}"])
MiniDFA10_559637758(["MiniDFA10 {1}"])
MiniDFA11_-4640144[\"MiniDFA11 {1}"/]
MiniDFA0_185271649 -->|"a"|MiniDFA1_778012036
MiniDFA1_778012036 -->|"t"|MiniDFA2_873938134
MiniDFA2_873938134 -->|"o"|MiniDFA3_-2132424560
MiniDFA3_-2132424560 -->|"m"|MiniDFA4_-960169769
MiniDFA4_-960169769 -->|"i"|MiniDFA6_1762128315
MiniDFA6_1762128315 -->|"c"|MiniDFA7_604245539
MiniDFA7_604245539 -->|"_"|MiniDFA8_-1123450314
MiniDFA8_-1123450314 -->|"u"|MiniDFA5_-121151674
MiniDFA5_-121151674 -->|"i"|MiniDFA9_803249303
MiniDFA9_803249303 -->|"n"|MiniDFA10_559637758
MiniDFA10_559637758 -->|"t"|MiniDFA11_-4640144
```
-------------------------------
