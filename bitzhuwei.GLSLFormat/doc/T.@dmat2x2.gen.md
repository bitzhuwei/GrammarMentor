# 'dmat2x2'

pattern: `dmat2x2`

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
eNFA110_14_5286373[["εNFA110-14 regex start"]]
eNFA110_0_47577364[["εNFA110-0 char{1, 1}"]]
eNFA110_1_25543093[["εNFA110-1 char[1]"]]
eNFA110_2_28561251[["εNFA110-2 char{1, 1}"]]
eNFA110_3_55724670[["εNFA110-3 char[1]"]]
eNFA110_4_31759983[["εNFA110-4 char{1, 1}"]]
eNFA110_5_17404391[["εNFA110-5 char[1]"]]
eNFA110_6_22421791[["εNFA110-6 char{1, 1}"]]
eNFA110_7_469528[["εNFA110-7 char[1]"]]
eNFA110_8_4225755[["εNFA110-8 char{1, 1}"]]
eNFA110_9_38031802[["εNFA110-9 char[1]"]]
eNFA110_10_6741900[["εNFA110-10 char{1, 1}"]]
eNFA110_11_60677108[["εNFA110-11 char[1]"]]
eNFA110_12_9223066[["εNFA110-12 char{1, 1}"]]
eNFA110_13_15898735[["εNFA110-13 char[1]"]]
eNFA110_15_8870892[["εNFA110-15 regex end"]]
eNFA110_16_12729171[["εNFA110-16 post-regex start"]]
eNFA110_17_47453675[\"εNFA110-17 post-regex end"/]
eNFA110_14_5286373 -.->|"ε"|eNFA110_0_47577364
eNFA110_0_47577364 -->|"d"|eNFA110_1_25543093
eNFA110_1_25543093 -.->|"ε"|eNFA110_2_28561251
eNFA110_2_28561251 -->|"m"|eNFA110_3_55724670
eNFA110_3_55724670 -.->|"ε"|eNFA110_4_31759983
eNFA110_4_31759983 -->|"a"|eNFA110_5_17404391
eNFA110_5_17404391 -.->|"ε"|eNFA110_6_22421791
eNFA110_6_22421791 -->|"t"|eNFA110_7_469528
eNFA110_7_469528 -.->|"ε"|eNFA110_8_4225755
eNFA110_8_4225755 -->|"2"|eNFA110_9_38031802
eNFA110_9_38031802 -.->|"ε"|eNFA110_10_6741900
eNFA110_10_6741900 -->|"x"|eNFA110_11_60677108
eNFA110_11_60677108 -.->|"ε"|eNFA110_12_9223066
eNFA110_12_9223066 -->|"2"|eNFA110_13_15898735
eNFA110_13_15898735 -.->|"ε"|eNFA110_15_8870892
eNFA110_15_8870892 -.->|"ε"|eNFA110_16_12729171
eNFA110_16_12729171 -.->|"ε"|eNFA110_17_47453675
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
eNFA110_14_24429894[["εNFA110-14 regex start"]]
eNFA110_0_18542462[["εNFA110-0 char{1, 1}"]]
eNFA110_1_32664435[["εNFA110-1 char[1]"]]
eNFA110_2_25544462[["εNFA110-2 char{1, 1}"]]
eNFA110_3_28573568[["εNFA110-3 char[1]"]]
eNFA110_4_55835522[["εNFA110-4 char{1, 1}"]]
eNFA110_5_32757653[["εNFA110-5 char[1]"]]
eNFA110_6_26383427[["εNFA110-6 char{1, 1}"]]
eNFA110_7_36124251[["εNFA110-7 char[1]"]]
eNFA110_8_56682808[["εNFA110-8 char{1, 1}"]]
eNFA110_9_40383225[["εNFA110-9 char[1]"]]
eNFA110_10_27904713[["εNFA110-10 char{1, 1}"]]
eNFA110_11_49815832[["εNFA110-11 char[1]"]]
eNFA110_12_45689312[["εNFA110-12 char{1, 1}"]]
eNFA110_13_8550624[\"εNFA110-13 char[1]"/]
eNFA110_15_9846754[\"εNFA110-15 regex end"/]
eNFA110_16_21511928[\"εNFA110-16 post-regex start"/]
eNFA110_17_59389625[\"εNFA110-17 post-regex end"/]
eNFA110_14_24429894 -.->|"ε"|eNFA110_0_18542462
eNFA110_14_24429894 -->|"d"|eNFA110_1_32664435
eNFA110_0_18542462 -->|"d"|eNFA110_1_32664435
eNFA110_1_32664435 -.->|"ε"|eNFA110_2_25544462
eNFA110_1_32664435 -->|"m"|eNFA110_3_28573568
eNFA110_2_25544462 -->|"m"|eNFA110_3_28573568
eNFA110_3_28573568 -.->|"ε"|eNFA110_4_55835522
eNFA110_3_28573568 -->|"a"|eNFA110_5_32757653
eNFA110_4_55835522 -->|"a"|eNFA110_5_32757653
eNFA110_5_32757653 -.->|"ε"|eNFA110_6_26383427
eNFA110_5_32757653 -->|"t"|eNFA110_7_36124251
eNFA110_6_26383427 -->|"t"|eNFA110_7_36124251
eNFA110_7_36124251 -.->|"ε"|eNFA110_8_56682808
eNFA110_7_36124251 -->|"2"|eNFA110_9_40383225
eNFA110_8_56682808 -->|"2"|eNFA110_9_40383225
eNFA110_9_40383225 -.->|"ε"|eNFA110_10_27904713
eNFA110_9_40383225 -->|"x"|eNFA110_11_49815832
eNFA110_10_27904713 -->|"x"|eNFA110_11_49815832
eNFA110_11_49815832 -.->|"ε"|eNFA110_12_45689312
eNFA110_11_49815832 -->|"2"|eNFA110_13_8550624
eNFA110_12_45689312 -->|"2"|eNFA110_13_8550624
eNFA110_13_8550624 -.->|"ε"|eNFA110_15_9846754
eNFA110_13_8550624 -.->|"ε"|eNFA110_16_21511928
eNFA110_13_8550624 -.->|"ε"|eNFA110_17_59389625
eNFA110_15_9846754 -.->|"ε"|eNFA110_16_21511928
eNFA110_15_9846754 -.->|"ε"|eNFA110_17_59389625
eNFA110_16_21511928 -.->|"ε"|eNFA110_17_59389625
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
NFA110_14_64744584("NFA110-14 regex start")
NFA110_1_45830349("NFA110-1 char[1]")
NFA110_3_9819961("NFA110-3 char[1]")
NFA110_5_21270789("NFA110-5 char[1]")
NFA110_7_57219378("NFA110-7 char[1]")
NFA110_9_45212362("NFA110-9 char[1]")
NFA110_11_4258076("NFA110-11 char[1]")
NFA110_13_38322691[\"NFA110-13 char[1]"/]
NFA110_14_64744584 -->|"d"|NFA110_1_45830349
NFA110_1_45830349 -->|"m"|NFA110_3_9819961
NFA110_3_9819961 -->|"a"|NFA110_5_21270789
NFA110_5_21270789 -->|"t"|NFA110_7_57219378
NFA110_7_57219378 -->|"2"|NFA110_9_45212362
NFA110_9_45212362 -->|"x"|NFA110_11_4258076
NFA110_11_4258076 -->|"2"|NFA110_13_38322691
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
subgraph DFA0_1808971226["DFA0 regex start"]
NFA110_14_64744584_0("NFA110-14 regex start")
end
subgraph DFA1_836448673["DFA1 {1}"]
NFA110_1_45830349_1("NFA110-1 char[1]")
end
subgraph DFA2_649403767["DFA2 {1}"]
NFA110_3_9819961_2("NFA110-3 char[1]")
end
subgraph DFA3_1858214350["DFA3 {1}"]
NFA110_5_21270789_3("NFA110-5 char[1]")
end
subgraph DFA4_-315793243["DFA4 {1}"]
NFA110_7_57219378_4("NFA110-7 char[1]")
end
subgraph DFA5_372498409["DFA5 {1}"]
NFA110_9_45212362_5("NFA110-9 char[1]")
end
subgraph DFA6_-1108802045["DFA6 {1}"]
NFA110_11_4258076_6("NFA110-11 char[1]")
end
subgraph DFA7_560791650["DFA7 {1}"]
NFA110_13_38322691_7[\"NFA110-13 char[1]"/]
end
DFA0_1808971226 -->|"d"|DFA1_836448673
DFA1_836448673 -->|"m"|DFA2_649403767
DFA2_649403767 -->|"a"|DFA3_1858214350
DFA3_1858214350 -->|"t"|DFA4_-315793243
DFA4_-315793243 -->|"2"|DFA5_372498409
DFA5_372498409 -->|"x"|DFA6_-1108802045
DFA6_-1108802045 -->|"2"|DFA7_560791650
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
DFA0_1808971226{{"DFA0 regex start"}}
DFA1_836448673{{"DFA1 {1}"}}
DFA2_649403767{{"DFA2 {1}"}}
DFA3_1858214350{{"DFA3 {1}"}}
DFA4_-315793243{{"DFA4 {1}"}}
DFA5_372498409{{"DFA5 {1}"}}
DFA6_-1108802045{{"DFA6 {1}"}}
DFA7_560791650[\"DFA7 {1}"/]
DFA0_1808971226 -->|"d"|DFA1_836448673
DFA1_836448673 -->|"m"|DFA2_649403767
DFA2_649403767 -->|"a"|DFA3_1858214350
DFA3_1858214350 -->|"t"|DFA4_-315793243
DFA4_-315793243 -->|"2"|DFA5_372498409
DFA5_372498409 -->|"x"|DFA6_-1108802045
DFA6_-1108802045 -->|"2"|DFA7_560791650
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
subgraph MiniDFA0_1055277663["MiniDFA0 {1}"]
DFA0_1808971226_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1744038400["MiniDFA1 {1}"]
DFA1_836448673_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1149701095["MiniDFA2 {1}"]
DFA2_649403767_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1355348659["MiniDFA3 {1}"]
DFA3_1858214350_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_954734116["MiniDFA4 {1}"]
DFA4_-315793243_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-441499033["MiniDFA5 {1}"]
DFA5_372498409_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1314554515["MiniDFA6 {1}"]
DFA6_-1108802045_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1336503512["MiniDFA7 {1}"]
DFA7_560791650_7[\"DFA7 {1}"/]
end
MiniDFA0_1055277663 -->|"d"|MiniDFA1_1744038400
MiniDFA1_1744038400 -->|"m"|MiniDFA2_-1149701095
MiniDFA2_-1149701095 -->|"a"|MiniDFA3_1355348659
MiniDFA3_1355348659 -->|"t"|MiniDFA4_954734116
MiniDFA4_954734116 -->|"2"|MiniDFA5_-441499033
MiniDFA5_-441499033 -->|"x"|MiniDFA6_-1314554515
MiniDFA6_-1314554515 -->|"2"|MiniDFA7_1336503512
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
MiniDFA0_1055277663(["MiniDFA0 {1}"])
MiniDFA1_1744038400(["MiniDFA1 {1}"])
MiniDFA2_-1149701095(["MiniDFA2 {1}"])
MiniDFA3_1355348659(["MiniDFA3 {1}"])
MiniDFA4_954734116(["MiniDFA4 {1}"])
MiniDFA5_-441499033(["MiniDFA5 {1}"])
MiniDFA6_-1314554515(["MiniDFA6 {1}"])
MiniDFA7_1336503512[\"MiniDFA7 {1}"/]
MiniDFA0_1055277663 -->|"d"|MiniDFA1_1744038400
MiniDFA1_1744038400 -->|"m"|MiniDFA2_-1149701095
MiniDFA2_-1149701095 -->|"a"|MiniDFA3_1355348659
MiniDFA3_1355348659 -->|"t"|MiniDFA4_954734116
MiniDFA4_954734116 -->|"2"|MiniDFA5_-441499033
MiniDFA5_-441499033 -->|"x"|MiniDFA6_-1314554515
MiniDFA6_-1314554515 -->|"2"|MiniDFA7_1336503512
```
-------------------------------
