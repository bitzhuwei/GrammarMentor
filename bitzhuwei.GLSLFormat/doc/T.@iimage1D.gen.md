# 'iimage1D'

pattern: `iimage1D`

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
eNFA161_16_55624859[["εNFA161-16 regex start"]]
eNFA161_0_30861686[["εNFA161-0 char{1, 1}"]]
eNFA161_1_9319721[["εNFA161-1 char[1]"]]
eNFA161_2_16768629[["εNFA161-2 char{1, 1}"]]
eNFA161_3_16699940[["εNFA161-3 char[1]"]]
eNFA161_4_16081733[["εNFA161-4 char{1, 1}"]]
eNFA161_5_10517875[["εNFA161-5 char[1]"]]
eNFA161_6_27552014[["εNFA161-6 char{1, 1}"]]
eNFA161_7_46641535[["εNFA161-7 char[1]"]]
eNFA161_8_17120631[["εNFA161-8 char{1, 1}"]]
eNFA161_9_19867951[["εNFA161-9 char[1]"]]
eNFA161_10_44593832[["εNFA161-10 char{1, 1}"]]
eNFA161_11_65800171[["εNFA161-11 char[1]"]]
eNFA161_12_55330634[["εNFA161-12 char{1, 1}"]]
eNFA161_13_28213660[["εNFA161-13 char[1]"]]
eNFA161_14_52596356[["εNFA161-14 char{1, 1}"]]
eNFA161_15_3605162[["εNFA161-15 char[1]"]]
eNFA161_17_32446463[["εNFA161-17 regex end"]]
eNFA161_18_23582716[["εNFA161-18 post-regex start"]]
eNFA161_19_10917859[\"εNFA161-19 post-regex end"/]
eNFA161_16_55624859 -.->|"ε"|eNFA161_0_30861686
eNFA161_0_30861686 -->|"i"|eNFA161_1_9319721
eNFA161_1_9319721 -.->|"ε"|eNFA161_2_16768629
eNFA161_2_16768629 -->|"i"|eNFA161_3_16699940
eNFA161_3_16699940 -.->|"ε"|eNFA161_4_16081733
eNFA161_4_16081733 -->|"m"|eNFA161_5_10517875
eNFA161_5_10517875 -.->|"ε"|eNFA161_6_27552014
eNFA161_6_27552014 -->|"a"|eNFA161_7_46641535
eNFA161_7_46641535 -.->|"ε"|eNFA161_8_17120631
eNFA161_8_17120631 -->|"g"|eNFA161_9_19867951
eNFA161_9_19867951 -.->|"ε"|eNFA161_10_44593832
eNFA161_10_44593832 -->|"e"|eNFA161_11_65800171
eNFA161_11_65800171 -.->|"ε"|eNFA161_12_55330634
eNFA161_12_55330634 -->|"1"|eNFA161_13_28213660
eNFA161_13_28213660 -.->|"ε"|eNFA161_14_52596356
eNFA161_14_52596356 -->|"D"|eNFA161_15_3605162
eNFA161_15_3605162 -.->|"ε"|eNFA161_17_32446463
eNFA161_17_32446463 -.->|"ε"|eNFA161_18_23582716
eNFA161_18_23582716 -.->|"ε"|eNFA161_19_10917859
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
eNFA161_16_31151867[["εNFA161-16 regex start"]]
eNFA161_0_11931350[["εNFA161-0 char{1, 1}"]]
eNFA161_1_40273294[["εNFA161-1 char[1]"]]
eNFA161_2_26915331[["εNFA161-2 char{1, 1}"]]
eNFA161_3_40911390[["εNFA161-3 char[1]"]]
eNFA161_4_32658192[["εNFA161-4 char{1, 1}"]]
eNFA161_5_25488274[["εNFA161-5 char[1]"]]
eNFA161_6_28067877[["εNFA161-6 char{1, 1}"]]
eNFA161_7_51284307[["εNFA161-7 char[1]"]]
eNFA161_8_58905579[["εNFA161-8 char{1, 1}"]]
eNFA161_9_60388168[["εNFA161-9 char[1]"]]
eNFA161_10_6622601[["εNFA161-10 char{1, 1}"]]
eNFA161_11_59603417[["εNFA161-11 char[1]"]]
eNFA161_12_66668712[["εNFA161-12 char{1, 1}"]]
eNFA161_13_63147504[["εNFA161-13 char[1]"]]
eNFA161_14_31456624[["εNFA161-14 char{1, 1}"]]
eNFA161_15_14674162[\"εNFA161-15 char[1]"/]
eNFA161_17_64958600[\"εNFA161-17 regex end"/]
eNFA161_18_47756489[\"εNFA161-18 post-regex start"/]
eNFA161_19_27155224[\"εNFA161-19 post-regex end"/]
eNFA161_16_31151867 -.->|"ε"|eNFA161_0_11931350
eNFA161_16_31151867 -->|"i"|eNFA161_1_40273294
eNFA161_0_11931350 -->|"i"|eNFA161_1_40273294
eNFA161_1_40273294 -.->|"ε"|eNFA161_2_26915331
eNFA161_1_40273294 -->|"i"|eNFA161_3_40911390
eNFA161_2_26915331 -->|"i"|eNFA161_3_40911390
eNFA161_3_40911390 -.->|"ε"|eNFA161_4_32658192
eNFA161_3_40911390 -->|"m"|eNFA161_5_25488274
eNFA161_4_32658192 -->|"m"|eNFA161_5_25488274
eNFA161_5_25488274 -.->|"ε"|eNFA161_6_28067877
eNFA161_5_25488274 -->|"a"|eNFA161_7_51284307
eNFA161_6_28067877 -->|"a"|eNFA161_7_51284307
eNFA161_7_51284307 -.->|"ε"|eNFA161_8_58905579
eNFA161_7_51284307 -->|"g"|eNFA161_9_60388168
eNFA161_8_58905579 -->|"g"|eNFA161_9_60388168
eNFA161_9_60388168 -.->|"ε"|eNFA161_10_6622601
eNFA161_9_60388168 -->|"e"|eNFA161_11_59603417
eNFA161_10_6622601 -->|"e"|eNFA161_11_59603417
eNFA161_11_59603417 -.->|"ε"|eNFA161_12_66668712
eNFA161_11_59603417 -->|"1"|eNFA161_13_63147504
eNFA161_12_66668712 -->|"1"|eNFA161_13_63147504
eNFA161_13_63147504 -.->|"ε"|eNFA161_14_31456624
eNFA161_13_63147504 -->|"D"|eNFA161_15_14674162
eNFA161_14_31456624 -->|"D"|eNFA161_15_14674162
eNFA161_15_14674162 -.->|"ε"|eNFA161_17_64958600
eNFA161_15_14674162 -.->|"ε"|eNFA161_18_47756489
eNFA161_15_14674162 -.->|"ε"|eNFA161_19_27155224
eNFA161_17_64958600 -.->|"ε"|eNFA161_18_47756489
eNFA161_17_64958600 -.->|"ε"|eNFA161_19_27155224
eNFA161_18_47756489 -.->|"ε"|eNFA161_19_27155224
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
NFA161_16_43070429("NFA161-16 regex start")
NFA161_1_52089545("NFA161-1 char[1]")
NFA161_3_66152725("NFA161-3 char[1]")
NFA161_5_58503618("NFA161-5 char[1]")
NFA161_7_56770522("NFA161-7 char[1]")
NFA161_9_41172652("NFA161-9 char[1]")
NFA161_11_35009555("NFA161-11 char[1]")
NFA161_13_46650543("NFA161-13 char[1]")
NFA161_15_17201705[\"NFA161-15 char[1]"/]
NFA161_16_43070429 -->|"i"|NFA161_1_52089545
NFA161_1_52089545 -->|"i"|NFA161_3_66152725
NFA161_3_66152725 -->|"m"|NFA161_5_58503618
NFA161_5_58503618 -->|"a"|NFA161_7_56770522
NFA161_7_56770522 -->|"g"|NFA161_9_41172652
NFA161_9_41172652 -->|"e"|NFA161_11_35009555
NFA161_11_35009555 -->|"1"|NFA161_13_46650543
NFA161_13_46650543 -->|"D"|NFA161_15_17201705
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
subgraph DFA0_1473704501["DFA0 regex start"]
NFA161_16_43070429_0("NFA161-16 regex start")
end
subgraph DFA1_2104011109["DFA1 {1}"]
NFA161_1_52089545_1("NFA161-1 char[1]")
end
subgraph DFA2_-2000619938["DFA2 {1}"]
NFA161_3_66152725_2("NFA161-3 char[1]")
end
subgraph DFA3_1293447042["DFA3 {1}"]
NFA161_5_58503618_3("NFA161-5 char[1]")
end
subgraph DFA4_188519296["DFA4 {1}"]
NFA161_7_56770522_4("NFA161-7 char[1]")
end
subgraph DFA5_218321421["DFA5 {1}"]
NFA161_9_41172652_5("NFA161-9 char[1]")
end
subgraph DFA6_-519977515["DFA6 {1}"]
NFA161_11_35009555_6("NFA161-11 char[1]")
end
subgraph DFA7_-871670004["DFA7 {1}"]
NFA161_13_46650543_7("NFA161-13 char[1]")
end
subgraph DFA8_-1800684861["DFA8 {1}"]
NFA161_15_17201705_8[\"NFA161-15 char[1]"/]
end
DFA0_1473704501 -->|"i"|DFA1_2104011109
DFA1_2104011109 -->|"i"|DFA2_-2000619938
DFA2_-2000619938 -->|"m"|DFA3_1293447042
DFA3_1293447042 -->|"a"|DFA4_188519296
DFA4_188519296 -->|"g"|DFA5_218321421
DFA5_218321421 -->|"e"|DFA6_-519977515
DFA6_-519977515 -->|"1"|DFA7_-871670004
DFA7_-871670004 -->|"D"|DFA8_-1800684861
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
DFA0_1473704501{{"DFA0 regex start"}}
DFA1_2104011109{{"DFA1 {1}"}}
DFA2_-2000619938{{"DFA2 {1}"}}
DFA3_1293447042{{"DFA3 {1}"}}
DFA4_188519296{{"DFA4 {1}"}}
DFA5_218321421{{"DFA5 {1}"}}
DFA6_-519977515{{"DFA6 {1}"}}
DFA7_-871670004{{"DFA7 {1}"}}
DFA8_-1800684861[\"DFA8 {1}"/]
DFA0_1473704501 -->|"i"|DFA1_2104011109
DFA1_2104011109 -->|"i"|DFA2_-2000619938
DFA2_-2000619938 -->|"m"|DFA3_1293447042
DFA3_1293447042 -->|"a"|DFA4_188519296
DFA4_188519296 -->|"g"|DFA5_218321421
DFA5_218321421 -->|"e"|DFA6_-519977515
DFA6_-519977515 -->|"1"|DFA7_-871670004
DFA7_-871670004 -->|"D"|DFA8_-1800684861
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
subgraph MiniDFA0_-1668422443["MiniDFA0 {1}"]
DFA0_1473704501_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1359171053["MiniDFA1 {1}"]
DFA1_2104011109_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-606250600["MiniDFA2 {1}"]
DFA2_-2000619938_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-867009354["MiniDFA3 {1}"]
DFA3_1293447042_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-990648978["MiniDFA4 {1}"]
DFA4_188519296_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-140191366["MiniDFA5 {1}"]
DFA5_218321421_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1697511668["MiniDFA6 {1}"]
DFA6_-519977515_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1637393911["MiniDFA7 {1}"]
DFA7_-871670004_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_669556198["MiniDFA8 {1}"]
DFA8_-1800684861_8[\"DFA8 {1}"/]
end
MiniDFA0_-1668422443 -->|"i"|MiniDFA1_-1359171053
MiniDFA1_-1359171053 -->|"i"|MiniDFA2_-606250600
MiniDFA2_-606250600 -->|"m"|MiniDFA3_-867009354
MiniDFA3_-867009354 -->|"a"|MiniDFA4_-990648978
MiniDFA4_-990648978 -->|"g"|MiniDFA5_-140191366
MiniDFA5_-140191366 -->|"e"|MiniDFA6_-1697511668
MiniDFA6_-1697511668 -->|"1"|MiniDFA7_-1637393911
MiniDFA7_-1637393911 -->|"D"|MiniDFA8_669556198
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
MiniDFA0_-1668422443(["MiniDFA0 {1}"])
MiniDFA1_-1359171053(["MiniDFA1 {1}"])
MiniDFA2_-606250600(["MiniDFA2 {1}"])
MiniDFA3_-867009354(["MiniDFA3 {1}"])
MiniDFA4_-990648978(["MiniDFA4 {1}"])
MiniDFA5_-140191366(["MiniDFA5 {1}"])
MiniDFA6_-1697511668(["MiniDFA6 {1}"])
MiniDFA7_-1637393911(["MiniDFA7 {1}"])
MiniDFA8_669556198[\"MiniDFA8 {1}"/]
MiniDFA0_-1668422443 -->|"i"|MiniDFA1_-1359171053
MiniDFA1_-1359171053 -->|"i"|MiniDFA2_-606250600
MiniDFA2_-606250600 -->|"m"|MiniDFA3_-867009354
MiniDFA3_-867009354 -->|"a"|MiniDFA4_-990648978
MiniDFA4_-990648978 -->|"g"|MiniDFA5_-140191366
MiniDFA5_-140191366 -->|"e"|MiniDFA6_-1697511668
MiniDFA6_-1697511668 -->|"1"|MiniDFA7_-1637393911
MiniDFA7_-1637393911 -->|"D"|MiniDFA8_669556198
```
-------------------------------
