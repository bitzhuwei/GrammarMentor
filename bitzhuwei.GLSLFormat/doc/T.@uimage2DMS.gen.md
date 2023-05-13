# 'uimage2DMS'

pattern: `uimage2DMS`

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
eNFA189_20_12533056[["εNFA189-20 regex start"]]
eNFA189_0_45688646[["εNFA189-0 char{1, 1}"]]
eNFA189_1_8544631[["εNFA189-1 char[1]"]]
eNFA189_2_9792822[["εNFA189-2 char{1, 1}"]]
eNFA189_3_21026539[["εNFA189-3 char[1]"]]
eNFA189_4_55021127[["εNFA189-4 char{1, 1}"]]
eNFA189_5_25428099[["εNFA189-5 char[1]"]]
eNFA189_6_27526304[["εNFA189-6 char{1, 1}"]]
eNFA189_7_46410152[["εNFA189-7 char[1]"]]
eNFA189_8_15038186[["εNFA189-8 char{1, 1}"]]
eNFA189_9_1125953[["εNFA189-9 char[1]"]]
eNFA189_10_10133581[["εNFA189-10 char{1, 1}"]]
eNFA189_11_24093367[["εNFA189-11 char[1]"]]
eNFA189_12_15513712[["εNFA189-12 char{1, 1}"]]
eNFA189_13_5405681[["εNFA189-13 char[1]"]]
eNFA189_14_48651131[["εNFA189-14 char{1, 1}"]]
eNFA189_15_35206999[["εNFA189-15 char[1]"]]
eNFA189_16_48427543[["εNFA189-16 char{1, 1}"]]
eNFA189_17_33194707[["εNFA189-17 char[1]"]]
eNFA189_18_30316907[["εNFA189-18 char{1, 1}"]]
eNFA189_19_4416714[["εNFA189-19 char[1]"]]
eNFA189_21_39750432[["εNFA189-21 regex end"]]
eNFA189_22_22209574[["εNFA189-22 post-regex start"]]
eNFA189_23_65668446[\"εNFA189-23 post-regex end"/]
eNFA189_20_12533056 -.->|"ε"|eNFA189_0_45688646
eNFA189_0_45688646 -->|"u"|eNFA189_1_8544631
eNFA189_1_8544631 -.->|"ε"|eNFA189_2_9792822
eNFA189_2_9792822 -->|"i"|eNFA189_3_21026539
eNFA189_3_21026539 -.->|"ε"|eNFA189_4_55021127
eNFA189_4_55021127 -->|"m"|eNFA189_5_25428099
eNFA189_5_25428099 -.->|"ε"|eNFA189_6_27526304
eNFA189_6_27526304 -->|"a"|eNFA189_7_46410152
eNFA189_7_46410152 -.->|"ε"|eNFA189_8_15038186
eNFA189_8_15038186 -->|"g"|eNFA189_9_1125953
eNFA189_9_1125953 -.->|"ε"|eNFA189_10_10133581
eNFA189_10_10133581 -->|"e"|eNFA189_11_24093367
eNFA189_11_24093367 -.->|"ε"|eNFA189_12_15513712
eNFA189_12_15513712 -->|"2"|eNFA189_13_5405681
eNFA189_13_5405681 -.->|"ε"|eNFA189_14_48651131
eNFA189_14_48651131 -->|"D"|eNFA189_15_35206999
eNFA189_15_35206999 -.->|"ε"|eNFA189_16_48427543
eNFA189_16_48427543 -->|"M"|eNFA189_17_33194707
eNFA189_17_33194707 -.->|"ε"|eNFA189_18_30316907
eNFA189_18_30316907 -->|"S"|eNFA189_19_4416714
eNFA189_19_4416714 -.->|"ε"|eNFA189_21_39750432
eNFA189_21_39750432 -.->|"ε"|eNFA189_22_22209574
eNFA189_22_22209574 -.->|"ε"|eNFA189_23_65668446
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
eNFA189_20_54145103[["εNFA189-20 regex start"]]
eNFA189_0_17543884[["εNFA189-0 char{1, 1}"]]
eNFA189_1_23677228[["εNFA189-1 char[1]"]]
eNFA189_2_11768466[["εNFA189-2 char{1, 1}"]]
eNFA189_3_38807334[["εNFA189-3 char[1]"]]
eNFA189_4_13721689[["εNFA189-4 char{1, 1}"]]
eNFA189_5_56386340[["εNFA189-5 char[1]"]]
eNFA189_6_37715016[["εNFA189-6 char{1, 1}"]]
eNFA189_7_3890831[["εNFA189-7 char[1]"]]
eNFA189_8_35017480[["εNFA189-8 char{1, 1}"]]
eNFA189_9_46721870[["εNFA189-9 char[1]"]]
eNFA189_10_17843649[["εNFA189-10 char{1, 1}"]]
eNFA189_11_26375114[["εNFA189-11 char[1]"]]
eNFA189_12_36049434[["εNFA189-12 char{1, 1}"]]
eNFA189_13_56009450[["εNFA189-13 char[1]"]]
eNFA189_14_34323003[["εNFA189-14 char{1, 1}"]]
eNFA189_15_40471574[["εNFA189-15 char[1]"]]
eNFA189_16_28699853[["εNFA189-16 char{1, 1}"]]
eNFA189_17_56972087[["εNFA189-17 char[1]"]]
eNFA189_18_42986743[["εNFA189-18 char{1, 1}"]]
eNFA189_19_51336373[\"εNFA189-19 char[1]"/]
eNFA189_21_59374178[\"εNFA189-21 regex end"/]
eNFA189_22_64605559[\"εNFA189-22 post-regex start"/]
eNFA189_23_44579126[\"εNFA189-23 post-regex end"/]
eNFA189_20_54145103 -.->|"ε"|eNFA189_0_17543884
eNFA189_20_54145103 -->|"u"|eNFA189_1_23677228
eNFA189_0_17543884 -->|"u"|eNFA189_1_23677228
eNFA189_1_23677228 -.->|"ε"|eNFA189_2_11768466
eNFA189_1_23677228 -->|"i"|eNFA189_3_38807334
eNFA189_2_11768466 -->|"i"|eNFA189_3_38807334
eNFA189_3_38807334 -.->|"ε"|eNFA189_4_13721689
eNFA189_3_38807334 -->|"m"|eNFA189_5_56386340
eNFA189_4_13721689 -->|"m"|eNFA189_5_56386340
eNFA189_5_56386340 -.->|"ε"|eNFA189_6_37715016
eNFA189_5_56386340 -->|"a"|eNFA189_7_3890831
eNFA189_6_37715016 -->|"a"|eNFA189_7_3890831
eNFA189_7_3890831 -.->|"ε"|eNFA189_8_35017480
eNFA189_7_3890831 -->|"g"|eNFA189_9_46721870
eNFA189_8_35017480 -->|"g"|eNFA189_9_46721870
eNFA189_9_46721870 -.->|"ε"|eNFA189_10_17843649
eNFA189_9_46721870 -->|"e"|eNFA189_11_26375114
eNFA189_10_17843649 -->|"e"|eNFA189_11_26375114
eNFA189_11_26375114 -.->|"ε"|eNFA189_12_36049434
eNFA189_11_26375114 -->|"2"|eNFA189_13_56009450
eNFA189_12_36049434 -->|"2"|eNFA189_13_56009450
eNFA189_13_56009450 -.->|"ε"|eNFA189_14_34323003
eNFA189_13_56009450 -->|"D"|eNFA189_15_40471574
eNFA189_14_34323003 -->|"D"|eNFA189_15_40471574
eNFA189_15_40471574 -.->|"ε"|eNFA189_16_28699853
eNFA189_15_40471574 -->|"M"|eNFA189_17_56972087
eNFA189_16_28699853 -->|"M"|eNFA189_17_56972087
eNFA189_17_56972087 -.->|"ε"|eNFA189_18_42986743
eNFA189_17_56972087 -->|"S"|eNFA189_19_51336373
eNFA189_18_42986743 -->|"S"|eNFA189_19_51336373
eNFA189_19_51336373 -.->|"ε"|eNFA189_21_59374178
eNFA189_19_51336373 -.->|"ε"|eNFA189_22_64605559
eNFA189_19_51336373 -.->|"ε"|eNFA189_23_44579126
eNFA189_21_59374178 -.->|"ε"|eNFA189_22_64605559
eNFA189_21_59374178 -.->|"ε"|eNFA189_23_44579126
eNFA189_22_64605559 -.->|"ε"|eNFA189_23_44579126
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
NFA189_20_65667814("NFA189-20 regex start")
NFA189_1_54139417("NFA189-1 char[1]")
NFA189_3_17492713("NFA189-3 char[1]")
NFA189_5_23216694("NFA189-5 char[1]")
NFA189_7_7623657("NFA189-7 char[1]")
NFA189_9_1504051("NFA189-9 char[1]")
NFA189_11_13536461("NFA189-11 char[1]")
NFA189_13_54719288("NFA189-13 char[1]")
NFA189_15_22711550("NFA189-15 char[1]")
NFA189_17_3077358("NFA189-17 char[1]")
NFA189_19_27696227[\"NFA189-19 char[1]"/]
NFA189_20_65667814 -->|"u"|NFA189_1_54139417
NFA189_1_54139417 -->|"i"|NFA189_3_17492713
NFA189_3_17492713 -->|"m"|NFA189_5_23216694
NFA189_5_23216694 -->|"a"|NFA189_7_7623657
NFA189_7_7623657 -->|"g"|NFA189_9_1504051
NFA189_9_1504051 -->|"e"|NFA189_11_13536461
NFA189_11_13536461 -->|"2"|NFA189_13_54719288
NFA189_13_54719288 -->|"D"|NFA189_15_22711550
NFA189_15_22711550 -->|"M"|NFA189_17_3077358
NFA189_17_3077358 -->|"S"|NFA189_19_27696227
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
subgraph DFA0_-793497672["DFA0 regex start"]
NFA189_20_65667814_0("NFA189-20 regex start")
end
subgraph DFA1_1365543075["DFA1 {1}"]
NFA189_1_54139417_1("NFA189-1 char[1]")
end
subgraph DFA2_2146547563["DFA2 {1}"]
NFA189_3_17492713_2("NFA189-3 char[1]")
end
subgraph DFA3_-1479610980["DFA3 {1}"]
NFA189_5_23216694_3("NFA189-5 char[1]")
end
subgraph DFA4_-168646809["DFA4 {1}"]
NFA189_7_7623657_4("NFA189-7 char[1]")
end
subgraph DFA5_848463324["DFA5 {1}"]
NFA189_9_1504051_5("NFA189-9 char[1]")
end
subgraph DFA6_-1835993873["DFA6 {1}"]
NFA189_11_13536461_6("NFA189-11 char[1]")
end
subgraph DFA7_-2144979424["DFA7 {1}"]
NFA189_13_54719288_7("NFA189-13 char[1]")
end
subgraph DFA8_989904522["DFA8 {1}"]
NFA189_15_22711550_8("NFA189-15 char[1]")
end
subgraph DFA9_570470752["DFA9 {1}"]
NFA189_17_3077358_9("NFA189-17 char[1]")
end
subgraph DFA10_-2043572682["DFA10 {1}"]
NFA189_19_27696227_10[\"NFA189-19 char[1]"/]
end
DFA0_-793497672 -->|"u"|DFA1_1365543075
DFA1_1365543075 -->|"i"|DFA2_2146547563
DFA2_2146547563 -->|"m"|DFA3_-1479610980
DFA3_-1479610980 -->|"a"|DFA4_-168646809
DFA4_-168646809 -->|"g"|DFA5_848463324
DFA5_848463324 -->|"e"|DFA6_-1835993873
DFA6_-1835993873 -->|"2"|DFA7_-2144979424
DFA7_-2144979424 -->|"D"|DFA8_989904522
DFA8_989904522 -->|"M"|DFA9_570470752
DFA9_570470752 -->|"S"|DFA10_-2043572682
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
DFA0_-793497672{{"DFA0 regex start"}}
DFA1_1365543075{{"DFA1 {1}"}}
DFA2_2146547563{{"DFA2 {1}"}}
DFA3_-1479610980{{"DFA3 {1}"}}
DFA4_-168646809{{"DFA4 {1}"}}
DFA5_848463324{{"DFA5 {1}"}}
DFA6_-1835993873{{"DFA6 {1}"}}
DFA7_-2144979424{{"DFA7 {1}"}}
DFA8_989904522{{"DFA8 {1}"}}
DFA9_570470752{{"DFA9 {1}"}}
DFA10_-2043572682[\"DFA10 {1}"/]
DFA0_-793497672 -->|"u"|DFA1_1365543075
DFA1_1365543075 -->|"i"|DFA2_2146547563
DFA2_2146547563 -->|"m"|DFA3_-1479610980
DFA3_-1479610980 -->|"a"|DFA4_-168646809
DFA4_-168646809 -->|"g"|DFA5_848463324
DFA5_848463324 -->|"e"|DFA6_-1835993873
DFA6_-1835993873 -->|"2"|DFA7_-2144979424
DFA7_-2144979424 -->|"D"|DFA8_989904522
DFA8_989904522 -->|"M"|DFA9_570470752
DFA9_570470752 -->|"S"|DFA10_-2043572682
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
subgraph MiniDFA0_1708810526["MiniDFA0 {1}"]
DFA0_-793497672_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1635113324["MiniDFA1 {1}"]
DFA1_1365543075_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1907736788["MiniDFA2 {1}"]
DFA2_2146547563_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1149562861["MiniDFA3 {1}"]
DFA3_-1479610980_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-469664308["MiniDFA4 {1}"]
DFA4_-168646809_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1116487184["MiniDFA5 {1}"]
DFA5_848463324_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1027254079["MiniDFA6 {1}"]
DFA6_-1835993873_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-635445652["MiniDFA7 {1}"]
DFA7_-2144979424_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_138011357["MiniDFA8 {1}"]
DFA8_989904522_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_1873274839["MiniDFA9 {1}"]
DFA9_570470752_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_1401508009["MiniDFA10 {1}"]
DFA10_-2043572682_10[\"DFA10 {1}"/]
end
MiniDFA0_1708810526 -->|"u"|MiniDFA1_1635113324
MiniDFA1_1635113324 -->|"i"|MiniDFA2_-1907736788
MiniDFA2_-1907736788 -->|"m"|MiniDFA3_-1149562861
MiniDFA3_-1149562861 -->|"a"|MiniDFA4_-469664308
MiniDFA4_-469664308 -->|"g"|MiniDFA5_-1116487184
MiniDFA5_-1116487184 -->|"e"|MiniDFA6_-1027254079
MiniDFA6_-1027254079 -->|"2"|MiniDFA7_-635445652
MiniDFA7_-635445652 -->|"D"|MiniDFA8_138011357
MiniDFA8_138011357 -->|"M"|MiniDFA9_1873274839
MiniDFA9_1873274839 -->|"S"|MiniDFA10_1401508009
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
MiniDFA0_1708810526(["MiniDFA0 {1}"])
MiniDFA1_1635113324(["MiniDFA1 {1}"])
MiniDFA2_-1907736788(["MiniDFA2 {1}"])
MiniDFA3_-1149562861(["MiniDFA3 {1}"])
MiniDFA4_-469664308(["MiniDFA4 {1}"])
MiniDFA5_-1116487184(["MiniDFA5 {1}"])
MiniDFA6_-1027254079(["MiniDFA6 {1}"])
MiniDFA7_-635445652(["MiniDFA7 {1}"])
MiniDFA8_138011357(["MiniDFA8 {1}"])
MiniDFA9_1873274839(["MiniDFA9 {1}"])
MiniDFA10_1401508009[\"MiniDFA10 {1}"/]
MiniDFA0_1708810526 -->|"u"|MiniDFA1_1635113324
MiniDFA1_1635113324 -->|"i"|MiniDFA2_-1907736788
MiniDFA2_-1907736788 -->|"m"|MiniDFA3_-1149562861
MiniDFA3_-1149562861 -->|"a"|MiniDFA4_-469664308
MiniDFA4_-469664308 -->|"g"|MiniDFA5_-1116487184
MiniDFA5_-1116487184 -->|"e"|MiniDFA6_-1027254079
MiniDFA6_-1027254079 -->|"2"|MiniDFA7_-635445652
MiniDFA7_-635445652 -->|"D"|MiniDFA8_138011357
MiniDFA8_138011357 -->|"M"|MiniDFA9_1873274839
MiniDFA9_1873274839 -->|"S"|MiniDFA10_1401508009
```
-------------------------------
