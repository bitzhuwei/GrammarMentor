# 'discard'

pattern: `discard`

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
eNFA208_14_17405051[["εNFA208-14 regex start"]]
eNFA208_0_22427738[["εNFA208-0 char{1, 1}"]]
eNFA208_1_523050[["εNFA208-1 char[1]"]]
eNFA208_2_4707453[["εNFA208-2 char{1, 1}"]]
eNFA208_3_42367085[["εNFA208-3 char[1]"]]
eNFA208_4_45759450[["εNFA208-4 char{1, 1}"]]
eNFA208_5_9181869[["εNFA208-5 char[1]"]]
eNFA208_6_15527959[["εNFA208-6 char{1, 1}"]]
eNFA208_7_5533905[["εNFA208-7 char[1]"]]
eNFA208_8_49805148[["εNFA208-8 char{1, 1}"]]
eNFA208_9_45593154[["εNFA208-9 char[1]"]]
eNFA208_10_7685202[["εNFA208-10 char{1, 1}"]]
eNFA208_11_2057959[["εNFA208-11 char[1]"]]
eNFA208_12_18521632[["εNFA208-12 char{1, 1}"]]
eNFA208_13_32476968[["εNFA208-13 char[1]"]]
eNFA208_15_23857263[["εNFA208-15 regex end"]]
eNFA208_16_13388783[["εNFA208-16 post-regex start"]]
eNFA208_17_53390183[\"εNFA208-17 post-regex end"/]
eNFA208_14_17405051 -.->|"ε"|eNFA208_0_22427738
eNFA208_0_22427738 -->|"d"|eNFA208_1_523050
eNFA208_1_523050 -.->|"ε"|eNFA208_2_4707453
eNFA208_2_4707453 -->|"i"|eNFA208_3_42367085
eNFA208_3_42367085 -.->|"ε"|eNFA208_4_45759450
eNFA208_4_45759450 -->|"s"|eNFA208_5_9181869
eNFA208_5_9181869 -.->|"ε"|eNFA208_6_15527959
eNFA208_6_15527959 -->|"c"|eNFA208_7_5533905
eNFA208_7_5533905 -.->|"ε"|eNFA208_8_49805148
eNFA208_8_49805148 -->|"a"|eNFA208_9_45593154
eNFA208_9_45593154 -.->|"ε"|eNFA208_10_7685202
eNFA208_10_7685202 -->|"r"|eNFA208_11_2057959
eNFA208_11_2057959 -.->|"ε"|eNFA208_12_18521632
eNFA208_12_18521632 -->|"d"|eNFA208_13_32476968
eNFA208_13_32476968 -.->|"ε"|eNFA208_15_23857263
eNFA208_15_23857263 -.->|"ε"|eNFA208_16_13388783
eNFA208_16_13388783 -.->|"ε"|eNFA208_17_53390183
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
eNFA208_14_10749601[["εNFA208-14 regex start"]]
eNFA208_0_29637551[["εNFA208-0 char{1, 1}"]]
eNFA208_1_65411368[["εNFA208-1 char[1]"]]
eNFA208_2_51831407[["εNFA208-2 char{1, 1}"]]
eNFA208_3_63829484[["εNFA208-3 char[1]"]]
eNFA208_4_37594448[["εNFA208-4 char{1, 1}"]]
eNFA208_5_2805716[["εNFA208-5 char[1]"]]
eNFA208_6_25251449[["εNFA208-6 char{1, 1}"]]
eNFA208_7_25936457[["εNFA208-7 char[1]"]]
eNFA208_8_32101523[["εNFA208-8 char{1, 1}"]]
eNFA208_9_20478258[["εNFA208-9 char[1]"]]
eNFA208_10_50086598[["εNFA208-10 char{1, 1}"]]
eNFA208_11_48126200[["εNFA208-11 char[1]"]]
eNFA208_12_30482617[["εNFA208-12 char{1, 1}"]]
eNFA208_13_5908098[\"εNFA208-13 char[1]"/]
eNFA208_15_53172884[\"εNFA208-15 regex end"/]
eNFA208_16_8793912[\"εNFA208-16 post-regex start"/]
eNFA208_17_12036352[\"εNFA208-17 post-regex end"/]
eNFA208_14_10749601 -.->|"ε"|eNFA208_0_29637551
eNFA208_14_10749601 -->|"d"|eNFA208_1_65411368
eNFA208_0_29637551 -->|"d"|eNFA208_1_65411368
eNFA208_1_65411368 -.->|"ε"|eNFA208_2_51831407
eNFA208_1_65411368 -->|"i"|eNFA208_3_63829484
eNFA208_2_51831407 -->|"i"|eNFA208_3_63829484
eNFA208_3_63829484 -.->|"ε"|eNFA208_4_37594448
eNFA208_3_63829484 -->|"s"|eNFA208_5_2805716
eNFA208_4_37594448 -->|"s"|eNFA208_5_2805716
eNFA208_5_2805716 -.->|"ε"|eNFA208_6_25251449
eNFA208_5_2805716 -->|"c"|eNFA208_7_25936457
eNFA208_6_25251449 -->|"c"|eNFA208_7_25936457
eNFA208_7_25936457 -.->|"ε"|eNFA208_8_32101523
eNFA208_7_25936457 -->|"a"|eNFA208_9_20478258
eNFA208_8_32101523 -->|"a"|eNFA208_9_20478258
eNFA208_9_20478258 -.->|"ε"|eNFA208_10_50086598
eNFA208_9_20478258 -->|"r"|eNFA208_11_48126200
eNFA208_10_50086598 -->|"r"|eNFA208_11_48126200
eNFA208_11_48126200 -.->|"ε"|eNFA208_12_30482617
eNFA208_11_48126200 -->|"d"|eNFA208_13_5908098
eNFA208_12_30482617 -->|"d"|eNFA208_13_5908098
eNFA208_13_5908098 -.->|"ε"|eNFA208_15_53172884
eNFA208_13_5908098 -.->|"ε"|eNFA208_16_8793912
eNFA208_13_5908098 -.->|"ε"|eNFA208_17_12036352
eNFA208_15_53172884 -.->|"ε"|eNFA208_16_8793912
eNFA208_15_53172884 -.->|"ε"|eNFA208_17_12036352
eNFA208_16_8793912 -.->|"ε"|eNFA208_17_12036352
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
NFA208_14_41218308("NFA208-14 regex start")
NFA208_1_35420452("NFA208-1 char[1]")
NFA208_3_50348619("NFA208-3 char[1]")
NFA208_5_50484393("NFA208-5 char[1]")
NFA208_7_51706359("NFA208-7 char[1]")
NFA208_9_62704055("NFA208-9 char[1]")
NFA208_11_27465584("NFA208-11 char[1]")
NFA208_13_45863669[\"NFA208-13 char[1]"/]
NFA208_14_41218308 -->|"d"|NFA208_1_35420452
NFA208_1_35420452 -->|"i"|NFA208_3_50348619
NFA208_3_50348619 -->|"s"|NFA208_5_50484393
NFA208_5_50484393 -->|"c"|NFA208_7_51706359
NFA208_7_51706359 -->|"a"|NFA208_9_62704055
NFA208_9_62704055 -->|"r"|NFA208_11_27465584
NFA208_11_27465584 -->|"d"|NFA208_13_45863669
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
subgraph DFA0_-1315905374["DFA0 regex start"]
NFA208_14_41218308_0("NFA208-14 regex start")
end
subgraph DFA1_1014775137["DFA1 {1}"]
NFA208_1_35420452_1("NFA208-1 char[1]")
end
subgraph DFA2_1732916284["DFA2 {1}"]
NFA208_3_50348619_2("NFA208-3 char[1]")
end
subgraph DFA3_-1525728368["DFA3 {1}"]
NFA208_5_50484393_3("NFA208-5 char[1]")
end
subgraph DFA4_1647329510["DFA4 {1}"]
NFA208_7_51706359_4("NFA208-7 char[1]")
end
subgraph DFA5_1449251319["DFA5 {1}"]
NFA208_9_62704055_5("NFA208-9 char[1]")
end
subgraph DFA6_1125371231["DFA6 {1}"]
NFA208_11_27465584_6("NFA208-11 char[1]")
end
subgraph DFA7_-390758747["DFA7 {1}"]
NFA208_13_45863669_7[\"NFA208-13 char[1]"/]
end
DFA0_-1315905374 -->|"d"|DFA1_1014775137
DFA1_1014775137 -->|"i"|DFA2_1732916284
DFA2_1732916284 -->|"s"|DFA3_-1525728368
DFA3_-1525728368 -->|"c"|DFA4_1647329510
DFA4_1647329510 -->|"a"|DFA5_1449251319
DFA5_1449251319 -->|"r"|DFA6_1125371231
DFA6_1125371231 -->|"d"|DFA7_-390758747
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
DFA0_-1315905374{{"DFA0 regex start"}}
DFA1_1014775137{{"DFA1 {1}"}}
DFA2_1732916284{{"DFA2 {1}"}}
DFA3_-1525728368{{"DFA3 {1}"}}
DFA4_1647329510{{"DFA4 {1}"}}
DFA5_1449251319{{"DFA5 {1}"}}
DFA6_1125371231{{"DFA6 {1}"}}
DFA7_-390758747[\"DFA7 {1}"/]
DFA0_-1315905374 -->|"d"|DFA1_1014775137
DFA1_1014775137 -->|"i"|DFA2_1732916284
DFA2_1732916284 -->|"s"|DFA3_-1525728368
DFA3_-1525728368 -->|"c"|DFA4_1647329510
DFA4_1647329510 -->|"a"|DFA5_1449251319
DFA5_1449251319 -->|"r"|DFA6_1125371231
DFA6_1125371231 -->|"d"|DFA7_-390758747
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
subgraph MiniDFA0_1162187167["MiniDFA0 {1}"]
DFA0_-1315905374_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1826889587["MiniDFA1 {1}"]
DFA1_1014775137_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-444293527["MiniDFA2 {1}"]
DFA2_1732916284_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1715706130["MiniDFA3 {1}"]
DFA3_-1525728368_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1562460505["MiniDFA4 {1}"]
DFA4_1647329510_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_841095999["MiniDFA5 {1}"]
DFA5_1449251319_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1337746568["MiniDFA6 {1}"]
DFA6_1125371231_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1990055161["MiniDFA7 {1}"]
DFA7_-390758747_7[\"DFA7 {1}"/]
end
MiniDFA0_1162187167 -->|"d"|MiniDFA1_1826889587
MiniDFA1_1826889587 -->|"i"|MiniDFA2_-444293527
MiniDFA2_-444293527 -->|"s"|MiniDFA3_-1715706130
MiniDFA3_-1715706130 -->|"c"|MiniDFA4_-1562460505
MiniDFA4_-1562460505 -->|"a"|MiniDFA5_841095999
MiniDFA5_841095999 -->|"r"|MiniDFA6_1337746568
MiniDFA6_1337746568 -->|"d"|MiniDFA7_1990055161
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
MiniDFA0_1162187167(["MiniDFA0 {1}"])
MiniDFA1_1826889587(["MiniDFA1 {1}"])
MiniDFA2_-444293527(["MiniDFA2 {1}"])
MiniDFA3_-1715706130(["MiniDFA3 {1}"])
MiniDFA4_-1562460505(["MiniDFA4 {1}"])
MiniDFA5_841095999(["MiniDFA5 {1}"])
MiniDFA6_1337746568(["MiniDFA6 {1}"])
MiniDFA7_1990055161[\"MiniDFA7 {1}"/]
MiniDFA0_1162187167 -->|"d"|MiniDFA1_1826889587
MiniDFA1_1826889587 -->|"i"|MiniDFA2_-444293527
MiniDFA2_-444293527 -->|"s"|MiniDFA3_-1715706130
MiniDFA3_-1715706130 -->|"c"|MiniDFA4_-1562460505
MiniDFA4_-1562460505 -->|"a"|MiniDFA5_841095999
MiniDFA5_841095999 -->|"r"|MiniDFA6_1337746568
MiniDFA6_1337746568 -->|"d"|MiniDFA7_1990055161
```
-------------------------------
