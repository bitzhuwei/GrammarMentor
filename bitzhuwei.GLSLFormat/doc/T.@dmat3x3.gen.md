# 'dmat3x3'

pattern: `dmat3x3`

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
eNFA114_14_23250319[["εNFA114-14 regex start"]]
eNFA114_0_7926280[["εNFA114-0 char{1, 1}"]]
eNFA114_1_4227661[["εNFA114-1 char[1]"]]
eNFA114_2_38048949[["εNFA114-2 char{1, 1}"]]
eNFA114_3_6896227[["εNFA114-3 char[1]"]]
eNFA114_4_62066047[["εNFA114-4 char{1, 1}"]]
eNFA114_5_21723514[["εNFA114-5 char[1]"]]
eNFA114_6_61293901[["εNFA114-6 char{1, 1}"]]
eNFA114_7_14774201[["εNFA114-7 char[1]"]]
eNFA114_8_65858952[["εNFA114-8 char{1, 1}"]]
eNFA114_9_55859657[["εNFA114-9 char[1]"]]
eNFA114_10_32974871[["εNFA114-10 char{1, 1}"]]
eNFA114_11_28338386[["εNFA114-11 char[1]"]]
eNFA114_12_53718883[["εNFA114-12 char{1, 1}"]]
eNFA114_13_13707899[["εNFA114-13 char[1]"]]
eNFA114_15_56262227[["εNFA114-15 regex end"]]
eNFA114_16_36597996[["εNFA114-16 post-regex start"]]
eNFA114_17_60946511[\"εNFA114-17 post-regex end"/]
eNFA114_14_23250319 -.->|"ε"|eNFA114_0_7926280
eNFA114_0_7926280 -->|"d"|eNFA114_1_4227661
eNFA114_1_4227661 -.->|"ε"|eNFA114_2_38048949
eNFA114_2_38048949 -->|"m"|eNFA114_3_6896227
eNFA114_3_6896227 -.->|"ε"|eNFA114_4_62066047
eNFA114_4_62066047 -->|"a"|eNFA114_5_21723514
eNFA114_5_21723514 -.->|"ε"|eNFA114_6_61293901
eNFA114_6_61293901 -->|"t"|eNFA114_7_14774201
eNFA114_7_14774201 -.->|"ε"|eNFA114_8_65858952
eNFA114_8_65858952 -->|"3"|eNFA114_9_55859657
eNFA114_9_55859657 -.->|"ε"|eNFA114_10_32974871
eNFA114_10_32974871 -->|"x"|eNFA114_11_28338386
eNFA114_11_28338386 -.->|"ε"|eNFA114_12_53718883
eNFA114_12_53718883 -->|"3"|eNFA114_13_13707899
eNFA114_13_13707899 -.->|"ε"|eNFA114_15_56262227
eNFA114_15_56262227 -.->|"ε"|eNFA114_16_36597996
eNFA114_16_36597996 -.->|"ε"|eNFA114_17_60946511
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
eNFA114_14_11647694[["εNFA114-14 regex start"]]
eNFA114_0_37720384[["εNFA114-0 char{1, 1}"]]
eNFA114_1_3939144[["εNFA114-1 char[1]"]]
eNFA114_2_35452302[["εNFA114-2 char{1, 1}"]]
eNFA114_3_50635267[["εNFA114-3 char[1]"]]
eNFA114_4_53064224[["εNFA114-4 char{1, 1}"]]
eNFA114_5_7815975[["εNFA114-5 char[1]"]]
eNFA114_6_3234911[["εNFA114-6 char{1, 1}"]]
eNFA114_7_29114202[["εNFA114-7 char[1]"]]
eNFA114_8_60701234[["εNFA114-8 char{1, 1}"]]
eNFA114_9_9440199[["εNFA114-9 char[1]"]]
eNFA114_10_17852930[["εNFA114-10 char{1, 1}"]]
eNFA114_11_26458644[["εNFA114-11 char[1]"]]
eNFA114_12_36801206[["εNFA114-12 char{1, 1}"]]
eNFA114_13_62775401[\"εNFA114-13 char[1]"/]
eNFA114_15_28107703[\"εNFA114-15 regex end"/]
eNFA114_16_51642735[\"εNFA114-16 post-regex start"/]
eNFA114_17_62131436[\"εNFA114-17 post-regex end"/]
eNFA114_14_11647694 -.->|"ε"|eNFA114_0_37720384
eNFA114_14_11647694 -->|"d"|eNFA114_1_3939144
eNFA114_0_37720384 -->|"d"|eNFA114_1_3939144
eNFA114_1_3939144 -.->|"ε"|eNFA114_2_35452302
eNFA114_1_3939144 -->|"m"|eNFA114_3_50635267
eNFA114_2_35452302 -->|"m"|eNFA114_3_50635267
eNFA114_3_50635267 -.->|"ε"|eNFA114_4_53064224
eNFA114_3_50635267 -->|"a"|eNFA114_5_7815975
eNFA114_4_53064224 -->|"a"|eNFA114_5_7815975
eNFA114_5_7815975 -.->|"ε"|eNFA114_6_3234911
eNFA114_5_7815975 -->|"t"|eNFA114_7_29114202
eNFA114_6_3234911 -->|"t"|eNFA114_7_29114202
eNFA114_7_29114202 -.->|"ε"|eNFA114_8_60701234
eNFA114_7_29114202 -->|"3"|eNFA114_9_9440199
eNFA114_8_60701234 -->|"3"|eNFA114_9_9440199
eNFA114_9_9440199 -.->|"ε"|eNFA114_10_17852930
eNFA114_9_9440199 -->|"x"|eNFA114_11_26458644
eNFA114_10_17852930 -->|"x"|eNFA114_11_26458644
eNFA114_11_26458644 -.->|"ε"|eNFA114_12_36801206
eNFA114_11_26458644 -->|"3"|eNFA114_13_62775401
eNFA114_12_36801206 -->|"3"|eNFA114_13_62775401
eNFA114_13_62775401 -.->|"ε"|eNFA114_15_28107703
eNFA114_13_62775401 -.->|"ε"|eNFA114_16_51642735
eNFA114_13_62775401 -.->|"ε"|eNFA114_17_62131436
eNFA114_15_28107703 -.->|"ε"|eNFA114_16_51642735
eNFA114_15_28107703 -.->|"ε"|eNFA114_17_62131436
eNFA114_16_51642735 -.->|"ε"|eNFA114_17_62131436
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
NFA114_14_22312013("NFA114-14 regex start")
NFA114_1_66590397("NFA114-1 char[1]")
NFA114_3_62442668("NFA114-3 char[1]")
NFA114_5_25113108("NFA114-5 char[1]")
NFA114_7_24691380("NFA114-7 char[1]")
NFA114_9_20895830("NFA114-9 char[1]")
NFA114_11_53844748("NFA114-11 char[1]")
NFA114_13_14840685[\"NFA114-13 char[1]"/]
NFA114_14_22312013 -->|"d"|NFA114_1_66590397
NFA114_1_66590397 -->|"m"|NFA114_3_62442668
NFA114_3_62442668 -->|"a"|NFA114_5_25113108
NFA114_5_25113108 -->|"t"|NFA114_7_24691380
NFA114_7_24691380 -->|"3"|NFA114_9_20895830
NFA114_9_20895830 -->|"x"|NFA114_11_53844748
NFA114_11_53844748 -->|"3"|NFA114_13_14840685
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
subgraph DFA0_1932299179["DFA0 regex start"]
NFA114_14_22312013_0("NFA114-14 regex start")
end
subgraph DFA1_-317525404["DFA1 {1}"]
NFA114_1_66590397_1("NFA114-1 char[1]")
end
subgraph DFA2_-824308507["DFA2 {1}"]
NFA114_3_62442668_2("NFA114-3 char[1]")
end
subgraph DFA3_-361398272["DFA3 {1}"]
NFA114_5_25113108_3("NFA114-5 char[1]")
end
subgraph DFA4_1258639553["DFA4 {1}"]
NFA114_7_24691380_4("NFA114-7 char[1]")
end
subgraph DFA5_-750754172["DFA5 {1}"]
NFA114_9_20895830_5("NFA114-9 char[1]")
end
subgraph DFA6_-53363750["DFA6 {1}"]
NFA114_11_53844748_6("NFA114-11 char[1]")
end
subgraph DFA7_188792829["DFA7 {1}"]
NFA114_13_14840685_7[\"NFA114-13 char[1]"/]
end
DFA0_1932299179 -->|"d"|DFA1_-317525404
DFA1_-317525404 -->|"m"|DFA2_-824308507
DFA2_-824308507 -->|"a"|DFA3_-361398272
DFA3_-361398272 -->|"t"|DFA4_1258639553
DFA4_1258639553 -->|"3"|DFA5_-750754172
DFA5_-750754172 -->|"x"|DFA6_-53363750
DFA6_-53363750 -->|"3"|DFA7_188792829
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
DFA0_1932299179{{"DFA0 regex start"}}
DFA1_-317525404{{"DFA1 {1}"}}
DFA2_-824308507{{"DFA2 {1}"}}
DFA3_-361398272{{"DFA3 {1}"}}
DFA4_1258639553{{"DFA4 {1}"}}
DFA5_-750754172{{"DFA5 {1}"}}
DFA6_-53363750{{"DFA6 {1}"}}
DFA7_188792829[\"DFA7 {1}"/]
DFA0_1932299179 -->|"d"|DFA1_-317525404
DFA1_-317525404 -->|"m"|DFA2_-824308507
DFA2_-824308507 -->|"a"|DFA3_-361398272
DFA3_-361398272 -->|"t"|DFA4_1258639553
DFA4_1258639553 -->|"3"|DFA5_-750754172
DFA5_-750754172 -->|"x"|DFA6_-53363750
DFA6_-53363750 -->|"3"|DFA7_188792829
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
subgraph MiniDFA0_415545718["MiniDFA0 {1}"]
DFA0_1932299179_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1869374998["MiniDFA1 {1}"]
DFA1_-317525404_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_340031249["MiniDFA2 {1}"]
DFA2_-824308507_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1154349109["MiniDFA3 {1}"]
DFA3_-361398272_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1340147853["MiniDFA4 {1}"]
DFA4_1258639553_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-663452023["MiniDFA5 {1}"]
DFA5_-750754172_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-517965693["MiniDFA6 {1}"]
DFA6_-53363750_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-920693350["MiniDFA7 {1}"]
DFA7_188792829_7[\"DFA7 {1}"/]
end
MiniDFA0_415545718 -->|"d"|MiniDFA1_1869374998
MiniDFA1_1869374998 -->|"m"|MiniDFA2_340031249
MiniDFA2_340031249 -->|"a"|MiniDFA3_-1154349109
MiniDFA3_-1154349109 -->|"t"|MiniDFA4_1340147853
MiniDFA4_1340147853 -->|"3"|MiniDFA5_-663452023
MiniDFA5_-663452023 -->|"x"|MiniDFA6_-517965693
MiniDFA6_-517965693 -->|"3"|MiniDFA7_-920693350
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
MiniDFA0_415545718(["MiniDFA0 {1}"])
MiniDFA1_1869374998(["MiniDFA1 {1}"])
MiniDFA2_340031249(["MiniDFA2 {1}"])
MiniDFA3_-1154349109(["MiniDFA3 {1}"])
MiniDFA4_1340147853(["MiniDFA4 {1}"])
MiniDFA5_-663452023(["MiniDFA5 {1}"])
MiniDFA6_-517965693(["MiniDFA6 {1}"])
MiniDFA7_-920693350[\"MiniDFA7 {1}"/]
MiniDFA0_415545718 -->|"d"|MiniDFA1_1869374998
MiniDFA1_1869374998 -->|"m"|MiniDFA2_340031249
MiniDFA2_340031249 -->|"a"|MiniDFA3_-1154349109
MiniDFA3_-1154349109 -->|"t"|MiniDFA4_1340147853
MiniDFA4_1340147853 -->|"3"|MiniDFA5_-663452023
MiniDFA5_-663452023 -->|"x"|MiniDFA6_-517965693
MiniDFA6_-517965693 -->|"3"|MiniDFA7_-920693350
```
-------------------------------
