# 'invariant'

pattern: `invariant`

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
eNFA52_18_262829[["εNFA52-18 regex start"]]
eNFA52_0_2365466[["εNFA52-0 char{1, 1}"]]
eNFA52_1_21289199[["εNFA52-1 char[1]"]]
eNFA52_2_57385070[["εNFA52-2 char{1, 1}"]]
eNFA52_3_46703582[["εNFA52-3 char[1]"]]
eNFA52_4_17679057[["εNFA52-4 char{1, 1}"]]
eNFA52_5_24893793[["εNFA52-5 char[1]"]]
eNFA52_6_22717550[["εNFA52-6 char{1, 1}"]]
eNFA52_7_3131361[["εNFA52-7 char[1]"]]
eNFA52_8_28182251[["εNFA52-8 char{1, 1}"]]
eNFA52_9_52313669[["εNFA52-9 char[1]"]]
eNFA52_10_1060976[["εNFA52-10 char{1, 1}"]]
eNFA52_11_9548790[["εNFA52-11 char[1]"]]
eNFA52_12_18830246[["εNFA52-12 char{1, 1}"]]
eNFA52_13_35254491[["εNFA52-13 char[1]"]]
eNFA52_14_48854964[["εNFA52-14 char{1, 1}"]]
eNFA52_15_37041500[["εNFA52-15 char[1]"]]
eNFA52_16_64938051[["εNFA52-16 char{1, 1}"]]
eNFA52_17_47571555[["εNFA52-17 char[1]"]]
eNFA52_19_25490811[["εNFA52-19 regex end"]]
eNFA52_20_28090709[["εNFA52-20 post-regex start"]]
eNFA52_21_51489795[\"εNFA52-21 post-regex end"/]
eNFA52_18_262829 -.->|"ε"|eNFA52_0_2365466
eNFA52_0_2365466 -->|"i"|eNFA52_1_21289199
eNFA52_1_21289199 -.->|"ε"|eNFA52_2_57385070
eNFA52_2_57385070 -->|"n"|eNFA52_3_46703582
eNFA52_3_46703582 -.->|"ε"|eNFA52_4_17679057
eNFA52_4_17679057 -->|"v"|eNFA52_5_24893793
eNFA52_5_24893793 -.->|"ε"|eNFA52_6_22717550
eNFA52_6_22717550 -->|"a"|eNFA52_7_3131361
eNFA52_7_3131361 -.->|"ε"|eNFA52_8_28182251
eNFA52_8_28182251 -->|"r"|eNFA52_9_52313669
eNFA52_9_52313669 -.->|"ε"|eNFA52_10_1060976
eNFA52_10_1060976 -->|"i"|eNFA52_11_9548790
eNFA52_11_9548790 -.->|"ε"|eNFA52_12_18830246
eNFA52_12_18830246 -->|"a"|eNFA52_13_35254491
eNFA52_13_35254491 -.->|"ε"|eNFA52_14_48854964
eNFA52_14_48854964 -->|"n"|eNFA52_15_37041500
eNFA52_15_37041500 -.->|"ε"|eNFA52_16_64938051
eNFA52_16_64938051 -->|"t"|eNFA52_17_47571555
eNFA52_17_47571555 -.->|"ε"|eNFA52_19_25490811
eNFA52_19_25490811 -.->|"ε"|eNFA52_20_28090709
eNFA52_20_28090709 -.->|"ε"|eNFA52_21_51489795
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
eNFA52_18_60754972[["εNFA52-18 regex start"]]
eNFA52_0_9923843[["εNFA52-0 char{1, 1}"]]
eNFA52_1_22205728[["εNFA52-1 char[1]"]]
eNFA52_2_65633828[["εNFA52-2 char{1, 1}"]]
eNFA52_3_53833544[["εNFA52-3 char[1]"]]
eNFA52_4_14739853[["εNFA52-4 char{1, 1}"]]
eNFA52_5_65549821[["εNFA52-5 char[1]"]]
eNFA52_6_53077479[["εNFA52-6 char{1, 1}"]]
eNFA52_7_7935270[["εNFA52-7 char[1]"]]
eNFA52_8_4308570[["εNFA52-8 char{1, 1}"]]
eNFA52_9_38777132[["εNFA52-9 char[1]"]]
eNFA52_10_13449869[["εNFA52-10 char{1, 1}"]]
eNFA52_11_53939958[["εNFA52-11 char[1]"]]
eNFA52_12_15697576[["εNFA52-12 char{1, 1}"]]
eNFA52_13_7060460[["εNFA52-13 char[1]"]]
eNFA52_14_63544148[["εNFA52-14 char{1, 1}"]]
eNFA52_15_35026424[["εNFA52-15 char[1]"]]
eNFA52_16_46802360[["εNFA52-16 char{1, 1}"]]
eNFA52_17_18568063[\"εNFA52-17 char[1]"/]
eNFA52_19_32894845[\"εNFA52-19 regex end"/]
eNFA52_20_27618155[\"εNFA52-20 post-regex start"/]
eNFA52_21_47236811[\"εNFA52-21 post-regex end"/]
eNFA52_18_60754972 -.->|"ε"|eNFA52_0_9923843
eNFA52_18_60754972 -->|"i"|eNFA52_1_22205728
eNFA52_0_9923843 -->|"i"|eNFA52_1_22205728
eNFA52_1_22205728 -.->|"ε"|eNFA52_2_65633828
eNFA52_1_22205728 -->|"n"|eNFA52_3_53833544
eNFA52_2_65633828 -->|"n"|eNFA52_3_53833544
eNFA52_3_53833544 -.->|"ε"|eNFA52_4_14739853
eNFA52_3_53833544 -->|"v"|eNFA52_5_65549821
eNFA52_4_14739853 -->|"v"|eNFA52_5_65549821
eNFA52_5_65549821 -.->|"ε"|eNFA52_6_53077479
eNFA52_5_65549821 -->|"a"|eNFA52_7_7935270
eNFA52_6_53077479 -->|"a"|eNFA52_7_7935270
eNFA52_7_7935270 -.->|"ε"|eNFA52_8_4308570
eNFA52_7_7935270 -->|"r"|eNFA52_9_38777132
eNFA52_8_4308570 -->|"r"|eNFA52_9_38777132
eNFA52_9_38777132 -.->|"ε"|eNFA52_10_13449869
eNFA52_9_38777132 -->|"i"|eNFA52_11_53939958
eNFA52_10_13449869 -->|"i"|eNFA52_11_53939958
eNFA52_11_53939958 -.->|"ε"|eNFA52_12_15697576
eNFA52_11_53939958 -->|"a"|eNFA52_13_7060460
eNFA52_12_15697576 -->|"a"|eNFA52_13_7060460
eNFA52_13_7060460 -.->|"ε"|eNFA52_14_63544148
eNFA52_13_7060460 -->|"n"|eNFA52_15_35026424
eNFA52_14_63544148 -->|"n"|eNFA52_15_35026424
eNFA52_15_35026424 -.->|"ε"|eNFA52_16_46802360
eNFA52_15_35026424 -->|"t"|eNFA52_17_18568063
eNFA52_16_46802360 -->|"t"|eNFA52_17_18568063
eNFA52_17_18568063 -.->|"ε"|eNFA52_19_32894845
eNFA52_17_18568063 -.->|"ε"|eNFA52_20_27618155
eNFA52_17_18568063 -.->|"ε"|eNFA52_21_47236811
eNFA52_19_32894845 -.->|"ε"|eNFA52_20_27618155
eNFA52_19_32894845 -.->|"ε"|eNFA52_21_47236811
eNFA52_20_27618155 -.->|"ε"|eNFA52_21_47236811
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
NFA52_18_22478116("NFA52-18 regex start")
NFA52_1_976457("NFA52-1 char[1]")
NFA52_3_8788113("NFA52-3 char[1]")
NFA52_5_11984159("NFA52-5 char[1]")
NFA52_7_40748571("NFA52-7 char[1]")
NFA52_9_31192822("NFA52-9 char[1]")
NFA52_11_12299945("NFA52-11 char[1]")
NFA52_13_43590645("NFA52-13 char[1]")
NFA52_15_56771492("NFA52-15 char[1]")
NFA52_17_41181381[\"NFA52-17 char[1]"/]
NFA52_18_22478116 -->|"i"|NFA52_1_976457
NFA52_1_976457 -->|"n"|NFA52_3_8788113
NFA52_3_8788113 -->|"v"|NFA52_5_11984159
NFA52_5_11984159 -->|"a"|NFA52_7_40748571
NFA52_7_40748571 -->|"r"|NFA52_9_31192822
NFA52_9_31192822 -->|"i"|NFA52_11_12299945
NFA52_11_12299945 -->|"a"|NFA52_13_43590645
NFA52_13_43590645 -->|"n"|NFA52_15_56771492
NFA52_15_56771492 -->|"t"|NFA52_17_41181381
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
subgraph DFA0_872560621["DFA0 regex start"]
NFA52_18_22478116_0("NFA52-18 regex start")
end
subgraph DFA1_-2005946481["DFA1 {1}"]
NFA52_1_976457_1("NFA52-1 char[1]")
end
subgraph DFA2_914067862["DFA2 {1}"]
NFA52_3_8788113_2("NFA52-3 char[1]")
end
subgraph DFA3_-1862188901["DFA3 {1}"]
NFA52_5_11984159_3("NFA52-5 char[1]")
end
subgraph DFA4_-418641926["DFA4 {1}"]
NFA52_7_40748571_4("NFA52-7 char[1]")
end
subgraph DFA5_296427203["DFA5 {1}"]
NFA52_9_31192822_5("NFA52-9 char[1]")
end
subgraph DFA6_-1090519560["DFA6 {1}"]
NFA52_11_12299945_6("NFA52-11 char[1]")
end
subgraph DFA7_-557500852["DFA7 {1}"]
NFA52_13_43590645_7("NFA52-13 char[1]")
end
subgraph DFA8_-1609041819["DFA8 {1}"]
NFA52_15_56771492_8("NFA52-15 char[1]")
end
subgraph DFA9_407798694["DFA9 {1}"]
NFA52_17_41181381_9[\"NFA52-17 char[1]"/]
end
DFA0_872560621 -->|"i"|DFA1_-2005946481
DFA1_-2005946481 -->|"n"|DFA2_914067862
DFA2_914067862 -->|"v"|DFA3_-1862188901
DFA3_-1862188901 -->|"a"|DFA4_-418641926
DFA4_-418641926 -->|"r"|DFA5_296427203
DFA5_296427203 -->|"i"|DFA6_-1090519560
DFA6_-1090519560 -->|"a"|DFA7_-557500852
DFA7_-557500852 -->|"n"|DFA8_-1609041819
DFA8_-1609041819 -->|"t"|DFA9_407798694
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
DFA0_872560621{{"DFA0 regex start"}}
DFA1_-2005946481{{"DFA1 {1}"}}
DFA2_914067862{{"DFA2 {1}"}}
DFA3_-1862188901{{"DFA3 {1}"}}
DFA4_-418641926{{"DFA4 {1}"}}
DFA5_296427203{{"DFA5 {1}"}}
DFA6_-1090519560{{"DFA6 {1}"}}
DFA7_-557500852{{"DFA7 {1}"}}
DFA8_-1609041819{{"DFA8 {1}"}}
DFA9_407798694[\"DFA9 {1}"/]
DFA0_872560621 -->|"i"|DFA1_-2005946481
DFA1_-2005946481 -->|"n"|DFA2_914067862
DFA2_914067862 -->|"v"|DFA3_-1862188901
DFA3_-1862188901 -->|"a"|DFA4_-418641926
DFA4_-418641926 -->|"r"|DFA5_296427203
DFA5_296427203 -->|"i"|DFA6_-1090519560
DFA6_-1090519560 -->|"a"|DFA7_-557500852
DFA7_-557500852 -->|"n"|DFA8_-1609041819
DFA8_-1609041819 -->|"t"|DFA9_407798694
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
subgraph MiniDFA0_28740108["MiniDFA0 {1}"]
DFA0_872560621_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_-1335281518["MiniDFA2 {1}"]
DFA1_-2005946481_1{{"DFA1 {1}"}}
end
subgraph MiniDFA4_-748868970["MiniDFA4 {1}"]
DFA2_914067862_2{{"DFA2 {1}"}}
end
subgraph MiniDFA5_-536219042["MiniDFA5 {1}"]
DFA3_-1862188901_3{{"DFA3 {1}"}}
end
subgraph MiniDFA7_-952896070["MiniDFA7 {1}"]
DFA4_-418641926_4{{"DFA4 {1}"}}
end
subgraph MiniDFA1_1580238983["MiniDFA1 {1}"]
DFA5_296427203_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1457481402["MiniDFA6 {1}"]
DFA6_-1090519560_6{{"DFA6 {1}"}}
end
subgraph MiniDFA3_-20117319["MiniDFA3 {1}"]
DFA7_-557500852_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1954011422["MiniDFA8 {1}"]
DFA8_-1609041819_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-627053475["MiniDFA9 {1}"]
DFA9_407798694_9[\"DFA9 {1}"/]
end
MiniDFA0_28740108 -->|"i"|MiniDFA2_-1335281518
MiniDFA2_-1335281518 -->|"n"|MiniDFA4_-748868970
MiniDFA4_-748868970 -->|"v"|MiniDFA5_-536219042
MiniDFA5_-536219042 -->|"a"|MiniDFA7_-952896070
MiniDFA7_-952896070 -->|"r"|MiniDFA1_1580238983
MiniDFA1_1580238983 -->|"i"|MiniDFA6_-1457481402
MiniDFA6_-1457481402 -->|"a"|MiniDFA3_-20117319
MiniDFA3_-20117319 -->|"n"|MiniDFA8_1954011422
MiniDFA8_1954011422 -->|"t"|MiniDFA9_-627053475
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
MiniDFA0_28740108(["MiniDFA0 {1}"])
MiniDFA2_-1335281518(["MiniDFA2 {1}"])
MiniDFA4_-748868970(["MiniDFA4 {1}"])
MiniDFA5_-536219042(["MiniDFA5 {1}"])
MiniDFA7_-952896070(["MiniDFA7 {1}"])
MiniDFA1_1580238983(["MiniDFA1 {1}"])
MiniDFA6_-1457481402(["MiniDFA6 {1}"])
MiniDFA3_-20117319(["MiniDFA3 {1}"])
MiniDFA8_1954011422(["MiniDFA8 {1}"])
MiniDFA9_-627053475[\"MiniDFA9 {1}"/]
MiniDFA0_28740108 -->|"i"|MiniDFA2_-1335281518
MiniDFA2_-1335281518 -->|"n"|MiniDFA4_-748868970
MiniDFA4_-748868970 -->|"v"|MiniDFA5_-536219042
MiniDFA5_-536219042 -->|"a"|MiniDFA7_-952896070
MiniDFA7_-952896070 -->|"r"|MiniDFA1_1580238983
MiniDFA1_1580238983 -->|"i"|MiniDFA6_-1457481402
MiniDFA6_-1457481402 -->|"a"|MiniDFA3_-20117319
MiniDFA3_-20117319 -->|"n"|MiniDFA8_1954011422
MiniDFA8_1954011422 -->|"t"|MiniDFA9_-627053475
```
-------------------------------
