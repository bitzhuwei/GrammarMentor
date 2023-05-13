# 'dmat3x4'

pattern: `dmat3x4`

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
eNFA115_14_38725542[["εNFA115-14 regex start"]]
eNFA115_0_12985564[["εNFA115-0 char{1, 1}"]]
eNFA115_1_49761220[["εNFA115-1 char[1]"]]
eNFA115_2_45197797[["εNFA115-2 char{1, 1}"]]
eNFA115_3_4126994[["εNFA115-3 char[1]"]]
eNFA115_4_37142946[["εNFA115-4 char{1, 1}"]]
eNFA115_5_65851064[["εNFA115-5 char[1]"]]
eNFA115_6_55788668[["εNFA115-6 char{1, 1}"]]
eNFA115_7_32335967[["εNFA115-7 char[1]"]]
eNFA115_8_22588250[["εNFA115-8 char{1, 1}"]]
eNFA115_9_1967662[["εNFA115-9 char[1]"]]
eNFA115_10_17708965[["εNFA115-10 char{1, 1}"]]
eNFA115_11_25162958[["εNFA115-11 char[1]"]]
eNFA115_12_25140036[["εNFA115-12 char{1, 1}"]]
eNFA115_13_24933735[["εNFA115-13 char[1]"]]
eNFA115_15_23077024[["εNFA115-15 regex end"]]
eNFA115_16_6366624[["εNFA115-16 post-regex start"]]
eNFA115_17_57299616[\"εNFA115-17 post-regex end"/]
eNFA115_14_38725542 -.->|"ε"|eNFA115_0_12985564
eNFA115_0_12985564 -->|"d"|eNFA115_1_49761220
eNFA115_1_49761220 -.->|"ε"|eNFA115_2_45197797
eNFA115_2_45197797 -->|"m"|eNFA115_3_4126994
eNFA115_3_4126994 -.->|"ε"|eNFA115_4_37142946
eNFA115_4_37142946 -->|"a"|eNFA115_5_65851064
eNFA115_5_65851064 -.->|"ε"|eNFA115_6_55788668
eNFA115_6_55788668 -->|"t"|eNFA115_7_32335967
eNFA115_7_32335967 -.->|"ε"|eNFA115_8_22588250
eNFA115_8_22588250 -->|"3"|eNFA115_9_1967662
eNFA115_9_1967662 -.->|"ε"|eNFA115_10_17708965
eNFA115_10_17708965 -->|"x"|eNFA115_11_25162958
eNFA115_11_25162958 -.->|"ε"|eNFA115_12_25140036
eNFA115_12_25140036 -->|"4"|eNFA115_13_24933735
eNFA115_13_24933735 -.->|"ε"|eNFA115_15_23077024
eNFA115_15_23077024 -.->|"ε"|eNFA115_16_6366624
eNFA115_16_6366624 -.->|"ε"|eNFA115_17_57299616
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
eNFA115_14_45934497[["εNFA115-14 regex start"]]
eNFA115_0_10757292[["εNFA115-0 char{1, 1}"]]
eNFA115_1_29706771[["εNFA115-1 char[1]"]]
eNFA115_2_66034349[["εNFA115-2 char{1, 1}"]]
eNFA115_3_57438237[["εNFA115-3 char[1]"]]
eNFA115_4_47182091[["εNFA115-4 char{1, 1}"]]
eNFA115_5_21985640[["εNFA115-5 char[1]"]]
eNFA115_6_63653037[["εNFA115-6 char{1, 1}"]]
eNFA115_7_36006428[["εNFA115-7 char[1]"]]
eNFA115_8_55622396[["εNFA115-8 char{1, 1}"]]
eNFA115_9_30839519[["εNFA115-9 char[1]"]]
eNFA115_10_9120223[["εNFA115-10 char{1, 1}"]]
eNFA115_11_14973148[["εNFA115-11 char[1]"]]
eNFA115_12_540607[["εNFA115-12 char{1, 1}"]]
eNFA115_13_4865465[\"εNFA115-13 char[1]"/]
eNFA115_15_43789187[\"εNFA115-15 regex end"/]
eNFA115_16_58558366[\"εNFA115-16 post-regex start"/]
eNFA115_17_57263252[\"εNFA115-17 post-regex end"/]
eNFA115_14_45934497 -.->|"ε"|eNFA115_0_10757292
eNFA115_14_45934497 -->|"d"|eNFA115_1_29706771
eNFA115_0_10757292 -->|"d"|eNFA115_1_29706771
eNFA115_1_29706771 -.->|"ε"|eNFA115_2_66034349
eNFA115_1_29706771 -->|"m"|eNFA115_3_57438237
eNFA115_2_66034349 -->|"m"|eNFA115_3_57438237
eNFA115_3_57438237 -.->|"ε"|eNFA115_4_47182091
eNFA115_3_57438237 -->|"a"|eNFA115_5_21985640
eNFA115_4_47182091 -->|"a"|eNFA115_5_21985640
eNFA115_5_21985640 -.->|"ε"|eNFA115_6_63653037
eNFA115_5_21985640 -->|"t"|eNFA115_7_36006428
eNFA115_6_63653037 -->|"t"|eNFA115_7_36006428
eNFA115_7_36006428 -.->|"ε"|eNFA115_8_55622396
eNFA115_7_36006428 -->|"3"|eNFA115_9_30839519
eNFA115_8_55622396 -->|"3"|eNFA115_9_30839519
eNFA115_9_30839519 -.->|"ε"|eNFA115_10_9120223
eNFA115_9_30839519 -->|"x"|eNFA115_11_14973148
eNFA115_10_9120223 -->|"x"|eNFA115_11_14973148
eNFA115_11_14973148 -.->|"ε"|eNFA115_12_540607
eNFA115_11_14973148 -->|"4"|eNFA115_13_4865465
eNFA115_12_540607 -->|"4"|eNFA115_13_4865465
eNFA115_13_4865465 -.->|"ε"|eNFA115_15_43789187
eNFA115_13_4865465 -.->|"ε"|eNFA115_16_58558366
eNFA115_13_4865465 -.->|"ε"|eNFA115_17_57263252
eNFA115_15_43789187 -.->|"ε"|eNFA115_16_58558366
eNFA115_15_43789187 -.->|"ε"|eNFA115_17_57263252
eNFA115_16_58558366 -.->|"ε"|eNFA115_17_57263252
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
NFA115_14_45607220("NFA115-14 regex start")
NFA115_1_7811801("NFA115-1 char[1]")
NFA115_3_3197346("NFA115-3 char[1]")
NFA115_5_28776122("NFA115-5 char[1]")
NFA115_7_57658513("NFA115-7 char[1]")
NFA115_9_49164577("NFA115-9 char[1]")
NFA115_11_39828009("NFA115-11 char[1]")
NFA115_13_22907763[\"NFA115-13 char[1]"/]
NFA115_14_45607220 -->|"d"|NFA115_1_7811801
NFA115_1_7811801 -->|"m"|NFA115_3_3197346
NFA115_3_3197346 -->|"a"|NFA115_5_28776122
NFA115_5_28776122 -->|"t"|NFA115_7_57658513
NFA115_7_57658513 -->|"3"|NFA115_9_49164577
NFA115_9_49164577 -->|"x"|NFA115_11_39828009
NFA115_11_39828009 -->|"4"|NFA115_13_22907763
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
subgraph DFA0_-204978672["DFA0 regex start"]
NFA115_14_45607220_0("NFA115-14 regex start")
end
subgraph DFA1_-398967197["DFA1 {1}"]
NFA115_1_7811801_1("NFA115-1 char[1]")
end
subgraph DFA2_-994896136["DFA2 {1}"]
NFA115_3_3197346_2("NFA115-3 char[1]")
end
subgraph DFA3_513933845["DFA3 {1}"]
NFA115_5_28776122_3("NFA115-5 char[1]")
end
subgraph DFA4_1197130342["DFA4 {1}"]
NFA115_7_57658513_4("NFA115-7 char[1]")
end
subgraph DFA5_-1618785528["DFA5 {1}"]
NFA115_9_49164577_5("NFA115-9 char[1]")
end
subgraph DFA6_1506354390["DFA6 {1}"]
NFA115_11_39828009_6("NFA115-11 char[1]")
end
subgraph DFA7_-1193526673["DFA7 {1}"]
NFA115_13_22907763_7[\"NFA115-13 char[1]"/]
end
DFA0_-204978672 -->|"d"|DFA1_-398967197
DFA1_-398967197 -->|"m"|DFA2_-994896136
DFA2_-994896136 -->|"a"|DFA3_513933845
DFA3_513933845 -->|"t"|DFA4_1197130342
DFA4_1197130342 -->|"3"|DFA5_-1618785528
DFA5_-1618785528 -->|"x"|DFA6_1506354390
DFA6_1506354390 -->|"4"|DFA7_-1193526673
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
DFA0_-204978672{{"DFA0 regex start"}}
DFA1_-398967197{{"DFA1 {1}"}}
DFA2_-994896136{{"DFA2 {1}"}}
DFA3_513933845{{"DFA3 {1}"}}
DFA4_1197130342{{"DFA4 {1}"}}
DFA5_-1618785528{{"DFA5 {1}"}}
DFA6_1506354390{{"DFA6 {1}"}}
DFA7_-1193526673[\"DFA7 {1}"/]
DFA0_-204978672 -->|"d"|DFA1_-398967197
DFA1_-398967197 -->|"m"|DFA2_-994896136
DFA2_-994896136 -->|"a"|DFA3_513933845
DFA3_513933845 -->|"t"|DFA4_1197130342
DFA4_1197130342 -->|"3"|DFA5_-1618785528
DFA5_-1618785528 -->|"x"|DFA6_1506354390
DFA6_1506354390 -->|"4"|DFA7_-1193526673
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
subgraph MiniDFA0_1974484766["MiniDFA0 {1}"]
DFA0_-204978672_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_810010387["MiniDFA1 {1}"]
DFA1_-398967197_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_852793176["MiniDFA2 {1}"]
DFA2_-994896136_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_358232688["MiniDFA3 {1}"]
DFA3_513933845_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-813105341["MiniDFA4 {1}"]
DFA4_1197130342_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1785142964["MiniDFA5 {1}"]
DFA5_-1618785528_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_972637151["MiniDFA6 {1}"]
DFA6_1506354390_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-250144709["MiniDFA7 {1}"]
DFA7_-1193526673_7[\"DFA7 {1}"/]
end
MiniDFA0_1974484766 -->|"d"|MiniDFA1_810010387
MiniDFA1_810010387 -->|"m"|MiniDFA2_852793176
MiniDFA2_852793176 -->|"a"|MiniDFA3_358232688
MiniDFA3_358232688 -->|"t"|MiniDFA4_-813105341
MiniDFA4_-813105341 -->|"3"|MiniDFA5_1785142964
MiniDFA5_1785142964 -->|"x"|MiniDFA6_972637151
MiniDFA6_972637151 -->|"4"|MiniDFA7_-250144709
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
MiniDFA0_1974484766(["MiniDFA0 {1}"])
MiniDFA1_810010387(["MiniDFA1 {1}"])
MiniDFA2_852793176(["MiniDFA2 {1}"])
MiniDFA3_358232688(["MiniDFA3 {1}"])
MiniDFA4_-813105341(["MiniDFA4 {1}"])
MiniDFA5_1785142964(["MiniDFA5 {1}"])
MiniDFA6_972637151(["MiniDFA6 {1}"])
MiniDFA7_-250144709[\"MiniDFA7 {1}"/]
MiniDFA0_1974484766 -->|"d"|MiniDFA1_810010387
MiniDFA1_810010387 -->|"m"|MiniDFA2_852793176
MiniDFA2_852793176 -->|"a"|MiniDFA3_358232688
MiniDFA3_358232688 -->|"t"|MiniDFA4_-813105341
MiniDFA4_-813105341 -->|"3"|MiniDFA5_1785142964
MiniDFA5_1785142964 -->|"x"|MiniDFA6_972637151
MiniDFA6_972637151 -->|"4"|MiniDFA7_-250144709
```
-------------------------------
