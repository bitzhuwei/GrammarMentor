# 'iimageCube'

pattern: `iimageCube`

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
eNFA173_20_14426089[["εNFA173-20 regex start"]]
eNFA173_0_62725940[["εNFA173-0 char{1, 1}"]]
eNFA173_1_27662549[["εNFA173-1 char[1]"]]
eNFA173_2_47636349[["εNFA173-2 char{1, 1}"]]
eNFA173_3_26073957[["εNFA173-3 char[1]"]]
eNFA173_4_33339022[["εNFA173-4 char{1, 1}"]]
eNFA173_5_31615745[["εNFA173-5 char[1]"]]
eNFA173_6_16106256[["εNFA173-6 char{1, 1}"]]
eNFA173_7_10738578[["εNFA173-7 char[1]"]]
eNFA173_8_29538346[["εNFA173-8 char{1, 1}"]]
eNFA173_9_64518528[["εNFA173-9 char[1]"]]
eNFA173_10_43795845[["εNFA173-10 char{1, 1}"]]
eNFA173_11_58618290[["εNFA173-11 char[1]"]]
eNFA173_12_57802569[["εNFA173-12 char{1, 1}"]]
eNFA173_13_50461073[["εNFA173-13 char[1]"]]
eNFA173_14_51496476[["εNFA173-14 char{1, 1}"]]
eNFA173_15_60815108[["εNFA173-15 char[1]"]]
eNFA173_16_10465065[["εNFA173-16 char{1, 1}"]]
eNFA173_17_27076724[["εNFA173-17 char[1]"]]
eNFA173_18_42363926[["εNFA173-18 char{1, 1}"]]
eNFA173_19_45731016[["εNFA173-19 char[1]"]]
eNFA173_21_8925963[["εNFA173-21 regex end"]]
eNFA173_22_13224809[["εNFA173-22 post-regex start"]]
eNFA173_23_51914417[\"εNFA173-23 post-regex end"/]
eNFA173_20_14426089 -.->|"ε"|eNFA173_0_62725940
eNFA173_0_62725940 -->|"i"|eNFA173_1_27662549
eNFA173_1_27662549 -.->|"ε"|eNFA173_2_47636349
eNFA173_2_47636349 -->|"i"|eNFA173_3_26073957
eNFA173_3_26073957 -.->|"ε"|eNFA173_4_33339022
eNFA173_4_33339022 -->|"m"|eNFA173_5_31615745
eNFA173_5_31615745 -.->|"ε"|eNFA173_6_16106256
eNFA173_6_16106256 -->|"a"|eNFA173_7_10738578
eNFA173_7_10738578 -.->|"ε"|eNFA173_8_29538346
eNFA173_8_29538346 -->|"g"|eNFA173_9_64518528
eNFA173_9_64518528 -.->|"ε"|eNFA173_10_43795845
eNFA173_10_43795845 -->|"e"|eNFA173_11_58618290
eNFA173_11_58618290 -.->|"ε"|eNFA173_12_57802569
eNFA173_12_57802569 -->|"C"|eNFA173_13_50461073
eNFA173_13_50461073 -.->|"ε"|eNFA173_14_51496476
eNFA173_14_51496476 -->|"u"|eNFA173_15_60815108
eNFA173_15_60815108 -.->|"ε"|eNFA173_16_10465065
eNFA173_16_10465065 -->|"b"|eNFA173_17_27076724
eNFA173_17_27076724 -.->|"ε"|eNFA173_18_42363926
eNFA173_18_42363926 -->|"e"|eNFA173_19_45731016
eNFA173_19_45731016 -.->|"ε"|eNFA173_21_8925963
eNFA173_21_8925963 -.->|"ε"|eNFA173_22_13224809
eNFA173_22_13224809 -.->|"ε"|eNFA173_23_51914417
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
eNFA173_20_64576574[["εNFA173-20 regex start"]]
eNFA173_0_44318255[["εNFA173-0 char{1, 1}"]]
eNFA173_1_63319983[["εNFA173-1 char[1]"]]
eNFA173_2_33008942[["εNFA173-2 char{1, 1}"]]
eNFA173_3_28645030[["εNFA173-3 char[1]"]]
eNFA173_4_56478678[["εNFA173-4 char{1, 1}"]]
eNFA173_5_38546056[["εNFA173-5 char[1]"]]
eNFA173_6_11370190[["εNFA173-6 char{1, 1}"]]
eNFA173_7_35222847[["εNFA173-7 char[1]"]]
eNFA173_8_48570174[["εNFA173-8 char{1, 1}"]]
eNFA173_9_34478387[["εNFA173-9 char[1]"]]
eNFA173_10_41870031[["εNFA173-10 char{1, 1}"]]
eNFA173_11_41285963[["εNFA173-11 char[1]"]]
eNFA173_12_36029352[["εNFA173-12 char{1, 1}"]]
eNFA173_13_55828720[["εNFA173-13 char[1]"]]
eNFA173_14_32696434[["εNFA173-14 char{1, 1}"]]
eNFA173_15_25832457[["εNFA173-15 char[1]"]]
eNFA173_16_31165525[["εNFA173-16 char{1, 1}"]]
eNFA173_17_12054271[["εNFA173-17 char[1]"]]
eNFA173_18_41379576[["εNFA173-18 char{1, 1}"]]
eNFA173_19_36871865[\"εNFA173-19 char[1]"/]
eNFA173_21_63411331[\"εNFA173-21 regex end"/]
eNFA173_22_33831071[\"εNFA173-22 post-regex start"/]
eNFA173_23_36044191[\"εNFA173-23 post-regex end"/]
eNFA173_20_64576574 -.->|"ε"|eNFA173_0_44318255
eNFA173_20_64576574 -->|"i"|eNFA173_1_63319983
eNFA173_0_44318255 -->|"i"|eNFA173_1_63319983
eNFA173_1_63319983 -.->|"ε"|eNFA173_2_33008942
eNFA173_1_63319983 -->|"i"|eNFA173_3_28645030
eNFA173_2_33008942 -->|"i"|eNFA173_3_28645030
eNFA173_3_28645030 -.->|"ε"|eNFA173_4_56478678
eNFA173_3_28645030 -->|"m"|eNFA173_5_38546056
eNFA173_4_56478678 -->|"m"|eNFA173_5_38546056
eNFA173_5_38546056 -.->|"ε"|eNFA173_6_11370190
eNFA173_5_38546056 -->|"a"|eNFA173_7_35222847
eNFA173_6_11370190 -->|"a"|eNFA173_7_35222847
eNFA173_7_35222847 -.->|"ε"|eNFA173_8_48570174
eNFA173_7_35222847 -->|"g"|eNFA173_9_34478387
eNFA173_8_48570174 -->|"g"|eNFA173_9_34478387
eNFA173_9_34478387 -.->|"ε"|eNFA173_10_41870031
eNFA173_9_34478387 -->|"e"|eNFA173_11_41285963
eNFA173_10_41870031 -->|"e"|eNFA173_11_41285963
eNFA173_11_41285963 -.->|"ε"|eNFA173_12_36029352
eNFA173_11_41285963 -->|"C"|eNFA173_13_55828720
eNFA173_12_36029352 -->|"C"|eNFA173_13_55828720
eNFA173_13_55828720 -.->|"ε"|eNFA173_14_32696434
eNFA173_13_55828720 -->|"u"|eNFA173_15_25832457
eNFA173_14_32696434 -->|"u"|eNFA173_15_25832457
eNFA173_15_25832457 -.->|"ε"|eNFA173_16_31165525
eNFA173_15_25832457 -->|"b"|eNFA173_17_12054271
eNFA173_16_31165525 -->|"b"|eNFA173_17_12054271
eNFA173_17_12054271 -.->|"ε"|eNFA173_18_41379576
eNFA173_17_12054271 -->|"e"|eNFA173_19_36871865
eNFA173_18_41379576 -->|"e"|eNFA173_19_36871865
eNFA173_19_36871865 -.->|"ε"|eNFA173_21_63411331
eNFA173_19_36871865 -.->|"ε"|eNFA173_22_33831071
eNFA173_19_36871865 -.->|"ε"|eNFA173_23_36044191
eNFA173_21_63411331 -.->|"ε"|eNFA173_22_33831071
eNFA173_21_63411331 -.->|"ε"|eNFA173_23_36044191
eNFA173_22_33831071 -.->|"ε"|eNFA173_23_36044191
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
NFA173_20_55962267("NFA173-20 regex start")
NFA173_1_33898355("NFA173-1 char[1]")
NFA173_3_36649746("NFA173-3 char[1]")
NFA173_5_61412264("NFA173-5 char[1]")
NFA173_7_15839470("NFA173-7 char[1]")
NFA173_9_8337510("NFA173-9 char[1]")
NFA173_11_7928727("NFA173-11 char[1]")
NFA173_13_4249684("NFA173-13 char[1]")
NFA173_15_38247156("NFA173-15 char[1]")
NFA173_17_8680090("NFA173-17 char[1]")
NFA173_19_11011950[\"NFA173-19 char[1]"/]
NFA173_20_55962267 -->|"i"|NFA173_1_33898355
NFA173_1_33898355 -->|"i"|NFA173_3_36649746
NFA173_3_36649746 -->|"m"|NFA173_5_61412264
NFA173_5_61412264 -->|"a"|NFA173_7_15839470
NFA173_7_15839470 -->|"g"|NFA173_9_8337510
NFA173_9_8337510 -->|"e"|NFA173_11_7928727
NFA173_11_7928727 -->|"C"|NFA173_13_4249684
NFA173_13_4249684 -->|"u"|NFA173_15_38247156
NFA173_15_38247156 -->|"b"|NFA173_17_8680090
NFA173_17_8680090 -->|"e"|NFA173_19_11011950
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
subgraph DFA0_-2055403792["DFA0 regex start"]
NFA173_20_55962267_0("NFA173-20 regex start")
end
subgraph DFA1_-1522119764["DFA1 {1}"]
NFA173_1_33898355_1("NFA173-1 char[1]")
end
subgraph DFA2_689516511["DFA2 {1}"]
NFA173_3_36649746_2("NFA173-3 char[1]")
end
subgraph DFA3_-1951464535["DFA3 {1}"]
NFA173_5_61412264_3("NFA173-5 char[1]")
end
subgraph DFA4_1513771555["DFA4 {1}"]
NFA173_7_15839470_4("NFA173-7 char[1]")
end
subgraph DFA5_487330005["DFA5 {1}"]
NFA173_9_8337510_5("NFA173-9 char[1]")
end
subgraph DFA6_-1136268040["DFA6 {1}"]
NFA173_11_7928727_6("NFA173-11 char[1]")
end
subgraph DFA7_956341504["DFA7 {1}"]
NFA173_13_4249684_7("NFA173-13 char[1]")
end
subgraph DFA8_-1635063503["DFA8 {1}"]
NFA173_15_38247156_8("NFA173-15 char[1]")
end
subgraph DFA9_-1988376171["DFA9 {1}"]
NFA173_17_8680090_9("NFA173-17 char[1]")
end
subgraph DFA10_1346675315["DFA10 {1}"]
NFA173_19_11011950_10[\"NFA173-19 char[1]"/]
end
DFA0_-2055403792 -->|"i"|DFA1_-1522119764
DFA1_-1522119764 -->|"i"|DFA2_689516511
DFA2_689516511 -->|"m"|DFA3_-1951464535
DFA3_-1951464535 -->|"a"|DFA4_1513771555
DFA4_1513771555 -->|"g"|DFA5_487330005
DFA5_487330005 -->|"e"|DFA6_-1136268040
DFA6_-1136268040 -->|"C"|DFA7_956341504
DFA7_956341504 -->|"u"|DFA8_-1635063503
DFA8_-1635063503 -->|"b"|DFA9_-1988376171
DFA9_-1988376171 -->|"e"|DFA10_1346675315
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
DFA0_-2055403792{{"DFA0 regex start"}}
DFA1_-1522119764{{"DFA1 {1}"}}
DFA2_689516511{{"DFA2 {1}"}}
DFA3_-1951464535{{"DFA3 {1}"}}
DFA4_1513771555{{"DFA4 {1}"}}
DFA5_487330005{{"DFA5 {1}"}}
DFA6_-1136268040{{"DFA6 {1}"}}
DFA7_956341504{{"DFA7 {1}"}}
DFA8_-1635063503{{"DFA8 {1}"}}
DFA9_-1988376171{{"DFA9 {1}"}}
DFA10_1346675315[\"DFA10 {1}"/]
DFA0_-2055403792 -->|"i"|DFA1_-1522119764
DFA1_-1522119764 -->|"i"|DFA2_689516511
DFA2_689516511 -->|"m"|DFA3_-1951464535
DFA3_-1951464535 -->|"a"|DFA4_1513771555
DFA4_1513771555 -->|"g"|DFA5_487330005
DFA5_487330005 -->|"e"|DFA6_-1136268040
DFA6_-1136268040 -->|"C"|DFA7_956341504
DFA7_956341504 -->|"u"|DFA8_-1635063503
DFA8_-1635063503 -->|"b"|DFA9_-1988376171
DFA9_-1988376171 -->|"e"|DFA10_1346675315
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
subgraph MiniDFA0_378758291["MiniDFA0 {1}"]
DFA0_-2055403792_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1339745537["MiniDFA1 {1}"]
DFA1_-1522119764_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1554517253["MiniDFA2 {1}"]
DFA2_689516511_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1836855038["MiniDFA3 {1}"]
DFA3_-1951464535_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1547481148["MiniDFA4 {1}"]
DFA4_1513771555_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-2138498198["MiniDFA5 {1}"]
DFA5_487330005_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1590039278["MiniDFA6 {1}"]
DFA6_-1136268040_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1379068284["MiniDFA7 {1}"]
DFA7_956341504_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1762001615["MiniDFA8 {1}"]
DFA8_-1635063503_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-490241268["MiniDFA9 {1}"]
DFA9_-1988376171_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_480875256["MiniDFA10 {1}"]
DFA10_1346675315_10[\"DFA10 {1}"/]
end
MiniDFA0_378758291 -->|"i"|MiniDFA1_1339745537
MiniDFA1_1339745537 -->|"i"|MiniDFA2_-1554517253
MiniDFA2_-1554517253 -->|"m"|MiniDFA3_1836855038
MiniDFA3_1836855038 -->|"a"|MiniDFA4_1547481148
MiniDFA4_1547481148 -->|"g"|MiniDFA5_-2138498198
MiniDFA5_-2138498198 -->|"e"|MiniDFA6_1590039278
MiniDFA6_1590039278 -->|"C"|MiniDFA7_-1379068284
MiniDFA7_-1379068284 -->|"u"|MiniDFA8_1762001615
MiniDFA8_1762001615 -->|"b"|MiniDFA9_-490241268
MiniDFA9_-490241268 -->|"e"|MiniDFA10_480875256
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
MiniDFA0_378758291(["MiniDFA0 {1}"])
MiniDFA1_1339745537(["MiniDFA1 {1}"])
MiniDFA2_-1554517253(["MiniDFA2 {1}"])
MiniDFA3_1836855038(["MiniDFA3 {1}"])
MiniDFA4_1547481148(["MiniDFA4 {1}"])
MiniDFA5_-2138498198(["MiniDFA5 {1}"])
MiniDFA6_1590039278(["MiniDFA6 {1}"])
MiniDFA7_-1379068284(["MiniDFA7 {1}"])
MiniDFA8_1762001615(["MiniDFA8 {1}"])
MiniDFA9_-490241268(["MiniDFA9 {1}"])
MiniDFA10_480875256[\"MiniDFA10 {1}"/]
MiniDFA0_378758291 -->|"i"|MiniDFA1_1339745537
MiniDFA1_1339745537 -->|"i"|MiniDFA2_-1554517253
MiniDFA2_-1554517253 -->|"m"|MiniDFA3_1836855038
MiniDFA3_1836855038 -->|"a"|MiniDFA4_1547481148
MiniDFA4_1547481148 -->|"g"|MiniDFA5_-2138498198
MiniDFA5_-2138498198 -->|"e"|MiniDFA6_1590039278
MiniDFA6_1590039278 -->|"C"|MiniDFA7_-1379068284
MiniDFA7_-1379068284 -->|"u"|MiniDFA8_1762001615
MiniDFA8_1762001615 -->|"b"|MiniDFA9_-490241268
MiniDFA9_-490241268 -->|"e"|MiniDFA10_480875256
```
-------------------------------
