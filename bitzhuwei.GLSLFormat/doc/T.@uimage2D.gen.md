# 'uimage2D'

pattern: `uimage2D`

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
eNFA165_16_13906014[["εNFA165-16 regex start"]]
eNFA165_0_58045264[["εNFA165-0 char{1, 1}"]]
eNFA165_1_52645336[["εNFA165-1 char[1]"]]
eNFA165_2_4045982[["εNFA165-2 char{1, 1}"]]
eNFA165_3_36413843[["εNFA165-3 char[1]"]]
eNFA165_4_59289136[["εNFA165-4 char{1, 1}"]]
eNFA165_5_63840183[["εNFA165-5 char[1]"]]
eNFA165_6_37690735[["εNFA165-6 char{1, 1}"]]
eNFA165_7_3672298[["εNFA165-7 char[1]"]]
eNFA165_8_33050690[["εNFA165-8 char{1, 1}"]]
eNFA165_9_29020759[["εNFA165-9 char[1]"]]
eNFA165_10_59860242[["εNFA165-10 char{1, 1}"]]
eNFA165_11_1871268[["εNFA165-11 char[1]"]]
eNFA165_12_16841414[["εNFA165-12 char{1, 1}"]]
eNFA165_13_17355001[["εNFA165-13 char[1]"]]
eNFA165_14_21977287[["εNFA165-14 char{1, 1}"]]
eNFA165_15_63577855[["εNFA165-15 char[1]"]]
eNFA165_17_35329788[["εNFA165-17 regex end"]]
eNFA165_18_49532637[["εNFA165-18 post-regex start"]]
eNFA165_19_43140557[\"εNFA165-19 post-regex end"/]
eNFA165_16_13906014 -.->|"ε"|eNFA165_0_58045264
eNFA165_0_58045264 -->|"u"|eNFA165_1_52645336
eNFA165_1_52645336 -.->|"ε"|eNFA165_2_4045982
eNFA165_2_4045982 -->|"i"|eNFA165_3_36413843
eNFA165_3_36413843 -.->|"ε"|eNFA165_4_59289136
eNFA165_4_59289136 -->|"m"|eNFA165_5_63840183
eNFA165_5_63840183 -.->|"ε"|eNFA165_6_37690735
eNFA165_6_37690735 -->|"a"|eNFA165_7_3672298
eNFA165_7_3672298 -.->|"ε"|eNFA165_8_33050690
eNFA165_8_33050690 -->|"g"|eNFA165_9_29020759
eNFA165_9_29020759 -.->|"ε"|eNFA165_10_59860242
eNFA165_10_59860242 -->|"e"|eNFA165_11_1871268
eNFA165_11_1871268 -.->|"ε"|eNFA165_12_16841414
eNFA165_12_16841414 -->|"2"|eNFA165_13_17355001
eNFA165_13_17355001 -.->|"ε"|eNFA165_14_21977287
eNFA165_14_21977287 -->|"D"|eNFA165_15_63577855
eNFA165_15_63577855 -.->|"ε"|eNFA165_17_35329788
eNFA165_17_35329788 -.->|"ε"|eNFA165_18_49532637
eNFA165_18_49532637 -.->|"ε"|eNFA165_19_43140557
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
eNFA165_16_52720700[["εNFA165-16 regex start"]]
eNFA165_0_4724260[["εNFA165-0 char{1, 1}"]]
eNFA165_1_42518340[["εNFA165-1 char[1]"]]
eNFA165_2_47120742[["εNFA165-2 char{1, 1}"]]
eNFA165_3_21433500[["εNFA165-3 char[1]"]]
eNFA165_4_58683773[["εNFA165-4 char{1, 1}"]]
eNFA165_5_58391916[["εNFA165-5 char[1]"]]
eNFA165_6_55765201[["εNFA165-6 char{1, 1}"]]
eNFA165_7_32124765[["εNFA165-7 char[1]"]]
eNFA165_8_20687433[["εNFA165-8 char{1, 1}"]]
eNFA165_9_51969174[["εNFA165-9 char[1]"]]
eNFA165_10_65069390[["εNFA165-10 char{1, 1}"]]
eNFA165_11_48753600[["εNFA165-11 char[1]"]]
eNFA165_12_36129223[["εNFA165-12 char{1, 1}"]]
eNFA165_13_56727555[["εNFA165-13 char[1]"]]
eNFA165_14_40785949[["εNFA165-14 char{1, 1}"]]
eNFA165_15_31529222[\"εNFA165-15 char[1]"/]
eNFA165_17_15327543[\"εNFA165-17 regex end"/]
eNFA165_18_3730161[\"εNFA165-18 post-regex start"/]
eNFA165_19_33571453[\"εNFA165-19 post-regex end"/]
eNFA165_16_52720700 -.->|"ε"|eNFA165_0_4724260
eNFA165_16_52720700 -->|"u"|eNFA165_1_42518340
eNFA165_0_4724260 -->|"u"|eNFA165_1_42518340
eNFA165_1_42518340 -.->|"ε"|eNFA165_2_47120742
eNFA165_1_42518340 -->|"i"|eNFA165_3_21433500
eNFA165_2_47120742 -->|"i"|eNFA165_3_21433500
eNFA165_3_21433500 -.->|"ε"|eNFA165_4_58683773
eNFA165_3_21433500 -->|"m"|eNFA165_5_58391916
eNFA165_4_58683773 -->|"m"|eNFA165_5_58391916
eNFA165_5_58391916 -.->|"ε"|eNFA165_6_55765201
eNFA165_5_58391916 -->|"a"|eNFA165_7_32124765
eNFA165_6_55765201 -->|"a"|eNFA165_7_32124765
eNFA165_7_32124765 -.->|"ε"|eNFA165_8_20687433
eNFA165_7_32124765 -->|"g"|eNFA165_9_51969174
eNFA165_8_20687433 -->|"g"|eNFA165_9_51969174
eNFA165_9_51969174 -.->|"ε"|eNFA165_10_65069390
eNFA165_9_51969174 -->|"e"|eNFA165_11_48753600
eNFA165_10_65069390 -->|"e"|eNFA165_11_48753600
eNFA165_11_48753600 -.->|"ε"|eNFA165_12_36129223
eNFA165_11_48753600 -->|"2"|eNFA165_13_56727555
eNFA165_12_36129223 -->|"2"|eNFA165_13_56727555
eNFA165_13_56727555 -.->|"ε"|eNFA165_14_40785949
eNFA165_13_56727555 -->|"D"|eNFA165_15_31529222
eNFA165_14_40785949 -->|"D"|eNFA165_15_31529222
eNFA165_15_31529222 -.->|"ε"|eNFA165_17_15327543
eNFA165_15_31529222 -.->|"ε"|eNFA165_18_3730161
eNFA165_15_31529222 -.->|"ε"|eNFA165_19_33571453
eNFA165_17_15327543 -.->|"ε"|eNFA165_18_3730161
eNFA165_17_15327543 -.->|"ε"|eNFA165_19_33571453
eNFA165_18_3730161 -.->|"ε"|eNFA165_19_33571453
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
NFA165_16_33707629("NFA165-16 regex start")
NFA165_1_34933209("NFA165-1 char[1]")
NFA165_3_45963425("NFA165-3 char[1]")
NFA165_5_11017648("NFA165-5 char[1]")
NFA165_7_32049974("NFA165-7 char[1]")
NFA165_9_20014316("NFA165-9 char[1]")
NFA165_11_45911124("NFA165-11 char[1]")
NFA165_13_10546933("NFA165-13 char[1]")
NFA165_15_27813538[\"NFA165-15 char[1]"/]
NFA165_16_33707629 -->|"u"|NFA165_1_34933209
NFA165_1_34933209 -->|"i"|NFA165_3_45963425
NFA165_3_45963425 -->|"m"|NFA165_5_11017648
NFA165_5_11017648 -->|"a"|NFA165_7_32049974
NFA165_7_32049974 -->|"g"|NFA165_9_20014316
NFA165_9_20014316 -->|"e"|NFA165_11_45911124
NFA165_11_45911124 -->|"2"|NFA165_13_10546933
NFA165_13_10546933 -->|"D"|NFA165_15_27813538
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
subgraph DFA0_1307901524["DFA0 regex start"]
NFA165_16_33707629_0("NFA165-16 regex start")
end
subgraph DFA1_2065098015["DFA1 {1}"]
NFA165_1_34933209_1("NFA165-1 char[1]")
end
subgraph DFA2_1011066250["DFA2 {1}"]
NFA165_3_45963425_2("NFA165-3 char[1]")
end
subgraph DFA3_1557997097["DFA3 {1}"]
NFA165_5_11017648_3("NFA165-5 char[1]")
end
subgraph DFA4_-336205674["DFA4 {1}"]
NFA165_7_32049974_4("NFA165-7 char[1]")
end
subgraph DFA5_-1798871772["DFA5 {1}"]
NFA165_9_20014316_5("NFA165-9 char[1]")
end
subgraph DFA6_-922971402["DFA6 {1}"]
NFA165_11_45911124_6("NFA165-11 char[1]")
end
subgraph DFA7_935522276["DFA7 {1}"]
NFA165_13_10546933_7("NFA165-13 char[1]")
end
subgraph DFA8_-255891583["DFA8 {1}"]
NFA165_15_27813538_8[\"NFA165-15 char[1]"/]
end
DFA0_1307901524 -->|"u"|DFA1_2065098015
DFA1_2065098015 -->|"i"|DFA2_1011066250
DFA2_1011066250 -->|"m"|DFA3_1557997097
DFA3_1557997097 -->|"a"|DFA4_-336205674
DFA4_-336205674 -->|"g"|DFA5_-1798871772
DFA5_-1798871772 -->|"e"|DFA6_-922971402
DFA6_-922971402 -->|"2"|DFA7_935522276
DFA7_935522276 -->|"D"|DFA8_-255891583
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
DFA0_1307901524{{"DFA0 regex start"}}
DFA1_2065098015{{"DFA1 {1}"}}
DFA2_1011066250{{"DFA2 {1}"}}
DFA3_1557997097{{"DFA3 {1}"}}
DFA4_-336205674{{"DFA4 {1}"}}
DFA5_-1798871772{{"DFA5 {1}"}}
DFA6_-922971402{{"DFA6 {1}"}}
DFA7_935522276{{"DFA7 {1}"}}
DFA8_-255891583[\"DFA8 {1}"/]
DFA0_1307901524 -->|"u"|DFA1_2065098015
DFA1_2065098015 -->|"i"|DFA2_1011066250
DFA2_1011066250 -->|"m"|DFA3_1557997097
DFA3_1557997097 -->|"a"|DFA4_-336205674
DFA4_-336205674 -->|"g"|DFA5_-1798871772
DFA5_-1798871772 -->|"e"|DFA6_-922971402
DFA6_-922971402 -->|"2"|DFA7_935522276
DFA7_935522276 -->|"D"|DFA8_-255891583
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
subgraph MiniDFA0_1447396549["MiniDFA0 {1}"]
DFA0_1307901524_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_499154775["MiniDFA1 {1}"]
DFA1_2065098015_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1062524171["MiniDFA2 {1}"]
DFA2_1011066250_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-2018452737["MiniDFA3 {1}"]
DFA3_1557997097_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1452609891["MiniDFA4 {1}"]
DFA4_-336205674_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1079314877["MiniDFA5 {1}"]
DFA5_-1798871772_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_978857119["MiniDFA6 {1}"]
DFA6_-922971402_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1825659732["MiniDFA7 {1}"]
DFA7_935522276_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1429221279["MiniDFA8 {1}"]
DFA8_-255891583_8[\"DFA8 {1}"/]
end
MiniDFA0_1447396549 -->|"u"|MiniDFA1_499154775
MiniDFA1_499154775 -->|"i"|MiniDFA2_-1062524171
MiniDFA2_-1062524171 -->|"m"|MiniDFA3_-2018452737
MiniDFA3_-2018452737 -->|"a"|MiniDFA4_-1452609891
MiniDFA4_-1452609891 -->|"g"|MiniDFA5_-1079314877
MiniDFA5_-1079314877 -->|"e"|MiniDFA6_978857119
MiniDFA6_978857119 -->|"2"|MiniDFA7_-1825659732
MiniDFA7_-1825659732 -->|"D"|MiniDFA8_1429221279
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
MiniDFA0_1447396549(["MiniDFA0 {1}"])
MiniDFA1_499154775(["MiniDFA1 {1}"])
MiniDFA2_-1062524171(["MiniDFA2 {1}"])
MiniDFA3_-2018452737(["MiniDFA3 {1}"])
MiniDFA4_-1452609891(["MiniDFA4 {1}"])
MiniDFA5_-1079314877(["MiniDFA5 {1}"])
MiniDFA6_978857119(["MiniDFA6 {1}"])
MiniDFA7_-1825659732(["MiniDFA7 {1}"])
MiniDFA8_1429221279[\"MiniDFA8 {1}"/]
MiniDFA0_1447396549 -->|"u"|MiniDFA1_499154775
MiniDFA1_499154775 -->|"i"|MiniDFA2_-1062524171
MiniDFA2_-1062524171 -->|"m"|MiniDFA3_-2018452737
MiniDFA3_-2018452737 -->|"a"|MiniDFA4_-1452609891
MiniDFA4_-1452609891 -->|"g"|MiniDFA5_-1079314877
MiniDFA5_-1079314877 -->|"e"|MiniDFA6_978857119
MiniDFA6_978857119 -->|"2"|MiniDFA7_-1825659732
MiniDFA7_-1825659732 -->|"D"|MiniDFA8_1429221279
```
-------------------------------
