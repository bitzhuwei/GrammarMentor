# 'image2D'

pattern: `image2D`

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
eNFA163_14_4740601[["εNFA163-14 regex start"]]
eNFA163_0_42665409[["εNFA163-0 char{1, 1}"]]
eNFA163_1_48444361[["εNFA163-1 char[1]"]]
eNFA163_2_33346066[["εNFA163-2 char{1, 1}"]]
eNFA163_3_31679141[["εNFA163-3 char[1]"]]
eNFA163_4_16676820[["εNFA163-4 char{1, 1}"]]
eNFA163_5_15873654[["εNFA163-5 char[1]"]]
eNFA163_6_8645166[["εNFA163-6 char{1, 1}"]]
eNFA163_7_10697636[["εNFA163-7 char[1]"]]
eNFA163_8_29169865[["εNFA163-8 char{1, 1}"]]
eNFA163_9_61202198[["εNFA163-9 char[1]"]]
eNFA163_10_13948877[["εNFA163-10 char{1, 1}"]]
eNFA163_11_58431029[["εNFA163-11 char[1]"]]
eNFA163_12_56117216[["εNFA163-12 char{1, 1}"]]
eNFA163_13_35292904[["εNFA163-13 char[1]"]]
eNFA163_15_49200685[["εNFA163-15 regex end"]]
eNFA163_16_40152984[["εNFA163-16 post-regex start"]]
eNFA163_17_25832538[\"εNFA163-17 post-regex end"/]
eNFA163_14_4740601 -.->|"ε"|eNFA163_0_42665409
eNFA163_0_42665409 -->|"i"|eNFA163_1_48444361
eNFA163_1_48444361 -.->|"ε"|eNFA163_2_33346066
eNFA163_2_33346066 -->|"m"|eNFA163_3_31679141
eNFA163_3_31679141 -.->|"ε"|eNFA163_4_16676820
eNFA163_4_16676820 -->|"a"|eNFA163_5_15873654
eNFA163_5_15873654 -.->|"ε"|eNFA163_6_8645166
eNFA163_6_8645166 -->|"g"|eNFA163_7_10697636
eNFA163_7_10697636 -.->|"ε"|eNFA163_8_29169865
eNFA163_8_29169865 -->|"e"|eNFA163_9_61202198
eNFA163_9_61202198 -.->|"ε"|eNFA163_10_13948877
eNFA163_10_13948877 -->|"2"|eNFA163_11_58431029
eNFA163_11_58431029 -.->|"ε"|eNFA163_12_56117216
eNFA163_12_56117216 -->|"D"|eNFA163_13_35292904
eNFA163_13_35292904 -.->|"ε"|eNFA163_15_49200685
eNFA163_15_49200685 -.->|"ε"|eNFA163_16_40152984
eNFA163_16_40152984 -.->|"ε"|eNFA163_17_25832538
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
eNFA163_14_31166252[["εNFA163-14 regex start"]]
eNFA163_0_12060815[["εNFA163-0 char{1, 1}"]]
eNFA163_1_41438477[["εNFA163-1 char[1]"]]
eNFA163_2_37401973[["εNFA163-2 char{1, 1}"]]
eNFA163_3_1073442[["εNFA163-3 char[1]"]]
eNFA163_4_9660979[["εNFA163-4 char{1, 1}"]]
eNFA163_5_19839955[["εNFA163-5 char[1]"]]
eNFA163_6_44341874[["εNFA163-6 char{1, 1}"]]
eNFA163_7_63532554[["εNFA163-7 char[1]"]]
eNFA163_8_34922074[["εNFA163-8 char{1, 1}"]]
eNFA163_9_45863212[["εNFA163-9 char[1]"]]
eNFA163_10_10115730[["εNFA163-10 char{1, 1}"]]
eNFA163_11_23932707[["εNFA163-11 char[1]"]]
eNFA163_12_14067778[["εNFA163-12 char{1, 1}"]]
eNFA163_13_59501143[\"εNFA163-13 char[1]"/]
eNFA163_15_65748243[\"εNFA163-15 regex end"/]
eNFA163_16_54863279[\"εNFA163-16 post-regex start"/]
eNFA163_17_24007468[\"εNFA163-17 post-regex end"/]
eNFA163_14_31166252 -.->|"ε"|eNFA163_0_12060815
eNFA163_14_31166252 -->|"i"|eNFA163_1_41438477
eNFA163_0_12060815 -->|"i"|eNFA163_1_41438477
eNFA163_1_41438477 -.->|"ε"|eNFA163_2_37401973
eNFA163_1_41438477 -->|"m"|eNFA163_3_1073442
eNFA163_2_37401973 -->|"m"|eNFA163_3_1073442
eNFA163_3_1073442 -.->|"ε"|eNFA163_4_9660979
eNFA163_3_1073442 -->|"a"|eNFA163_5_19839955
eNFA163_4_9660979 -->|"a"|eNFA163_5_19839955
eNFA163_5_19839955 -.->|"ε"|eNFA163_6_44341874
eNFA163_5_19839955 -->|"g"|eNFA163_7_63532554
eNFA163_6_44341874 -->|"g"|eNFA163_7_63532554
eNFA163_7_63532554 -.->|"ε"|eNFA163_8_34922074
eNFA163_7_63532554 -->|"e"|eNFA163_9_45863212
eNFA163_8_34922074 -->|"e"|eNFA163_9_45863212
eNFA163_9_45863212 -.->|"ε"|eNFA163_10_10115730
eNFA163_9_45863212 -->|"2"|eNFA163_11_23932707
eNFA163_10_10115730 -->|"2"|eNFA163_11_23932707
eNFA163_11_23932707 -.->|"ε"|eNFA163_12_14067778
eNFA163_11_23932707 -->|"D"|eNFA163_13_59501143
eNFA163_12_14067778 -->|"D"|eNFA163_13_59501143
eNFA163_13_59501143 -.->|"ε"|eNFA163_15_65748243
eNFA163_13_59501143 -.->|"ε"|eNFA163_16_54863279
eNFA163_13_59501143 -.->|"ε"|eNFA163_17_24007468
eNFA163_15_65748243 -.->|"ε"|eNFA163_16_54863279
eNFA163_15_65748243 -.->|"ε"|eNFA163_17_24007468
eNFA163_16_54863279 -.->|"ε"|eNFA163_17_24007468
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
NFA163_14_14740628("NFA163-14 regex start")
NFA163_1_65556790("NFA163-1 char[1]")
NFA163_3_53140205("NFA163-3 char[1]")
NFA163_5_8499801("NFA163-5 char[1]")
NFA163_7_9389347("NFA163-7 char[1]")
NFA163_9_17395260("NFA163-9 char[1]")
NFA163_11_22339613("NFA163-11 char[1]")
NFA163_13_66838791[\"NFA163-13 char[1]"/]
NFA163_14_14740628 -->|"i"|NFA163_1_65556790
NFA163_1_65556790 -->|"m"|NFA163_3_53140205
NFA163_3_53140205 -->|"a"|NFA163_5_8499801
NFA163_5_8499801 -->|"g"|NFA163_7_9389347
NFA163_7_9389347 -->|"e"|NFA163_9_17395260
NFA163_9_17395260 -->|"2"|NFA163_11_22339613
NFA163_11_22339613 -->|"D"|NFA163_13_66838791
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
subgraph DFA0_-506293225["DFA0 regex start"]
NFA163_14_14740628_0("NFA163-14 regex start")
end
subgraph DFA1_467520480["DFA1 {1}"]
NFA163_1_65556790_1("NFA163-1 char[1]")
end
subgraph DFA2_1463448361["DFA2 {1}"]
NFA163_3_53140205_2("NFA163-3 char[1]")
end
subgraph DFA3_2003553783["DFA3 {1}"]
NFA163_5_8499801_3("NFA163-5 char[1]")
end
subgraph DFA4_495976217["DFA4 {1}"]
NFA163_7_9389347_4("NFA163-7 char[1]")
end
subgraph DFA5_311282956["DFA5 {1}"]
NFA163_9_17395260_5("NFA163-9 char[1]")
end
subgraph DFA6_1509916291["DFA6 {1}"]
NFA163_11_22339613_6("NFA163-11 char[1]")
end
subgraph DFA7_1804901754["DFA7 {1}"]
NFA163_13_66838791_7[\"NFA163-13 char[1]"/]
end
DFA0_-506293225 -->|"i"|DFA1_467520480
DFA1_467520480 -->|"m"|DFA2_1463448361
DFA2_1463448361 -->|"a"|DFA3_2003553783
DFA3_2003553783 -->|"g"|DFA4_495976217
DFA4_495976217 -->|"e"|DFA5_311282956
DFA5_311282956 -->|"2"|DFA6_1509916291
DFA6_1509916291 -->|"D"|DFA7_1804901754
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
DFA0_-506293225{{"DFA0 regex start"}}
DFA1_467520480{{"DFA1 {1}"}}
DFA2_1463448361{{"DFA2 {1}"}}
DFA3_2003553783{{"DFA3 {1}"}}
DFA4_495976217{{"DFA4 {1}"}}
DFA5_311282956{{"DFA5 {1}"}}
DFA6_1509916291{{"DFA6 {1}"}}
DFA7_1804901754[\"DFA7 {1}"/]
DFA0_-506293225 -->|"i"|DFA1_467520480
DFA1_467520480 -->|"m"|DFA2_1463448361
DFA2_1463448361 -->|"a"|DFA3_2003553783
DFA3_2003553783 -->|"g"|DFA4_495976217
DFA4_495976217 -->|"e"|DFA5_311282956
DFA5_311282956 -->|"2"|DFA6_1509916291
DFA6_1509916291 -->|"D"|DFA7_1804901754
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
subgraph MiniDFA0_332086005["MiniDFA0 {1}"]
DFA0_-506293225_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1964335741["MiniDFA1 {1}"]
DFA1_467520480_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1325554655["MiniDFA2 {1}"]
DFA2_1463448361_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-840963360["MiniDFA3 {1}"]
DFA3_2003553783_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1154548341["MiniDFA4 {1}"]
DFA4_495976217_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1112919776["MiniDFA5 {1}"]
DFA5_311282956_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1961027865["MiniDFA6 {1}"]
DFA6_1509916291_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-452061742["MiniDFA7 {1}"]
DFA7_1804901754_7[\"DFA7 {1}"/]
end
MiniDFA0_332086005 -->|"i"|MiniDFA1_1964335741
MiniDFA1_1964335741 -->|"m"|MiniDFA2_1325554655
MiniDFA2_1325554655 -->|"a"|MiniDFA3_-840963360
MiniDFA3_-840963360 -->|"g"|MiniDFA4_1154548341
MiniDFA4_1154548341 -->|"e"|MiniDFA5_-1112919776
MiniDFA5_-1112919776 -->|"2"|MiniDFA6_-1961027865
MiniDFA6_-1961027865 -->|"D"|MiniDFA7_-452061742
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
MiniDFA0_332086005(["MiniDFA0 {1}"])
MiniDFA1_1964335741(["MiniDFA1 {1}"])
MiniDFA2_1325554655(["MiniDFA2 {1}"])
MiniDFA3_-840963360(["MiniDFA3 {1}"])
MiniDFA4_1154548341(["MiniDFA4 {1}"])
MiniDFA5_-1112919776(["MiniDFA5 {1}"])
MiniDFA6_-1961027865(["MiniDFA6 {1}"])
MiniDFA7_-452061742[\"MiniDFA7 {1}"/]
MiniDFA0_332086005 -->|"i"|MiniDFA1_1964335741
MiniDFA1_1964335741 -->|"m"|MiniDFA2_1325554655
MiniDFA2_1325554655 -->|"a"|MiniDFA3_-840963360
MiniDFA3_-840963360 -->|"g"|MiniDFA4_1154548341
MiniDFA4_1154548341 -->|"e"|MiniDFA5_-1112919776
MiniDFA5_-1112919776 -->|"2"|MiniDFA6_-1961027865
MiniDFA6_-1961027865 -->|"D"|MiniDFA7_-452061742
```
-------------------------------
