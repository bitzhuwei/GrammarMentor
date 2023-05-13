# 'sampler1D'

pattern: `sampler1D`

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
eNFA120_18_54179398[["εNFA120-18 regex start"]]
eNFA120_0_17852540[["εNFA120-0 char{1, 1}"]]
eNFA120_1_26455137[["εNFA120-1 char[1]"]]
eNFA120_2_36769646[["εNFA120-2 char{1, 1}"]]
eNFA120_3_62491365[["εNFA120-3 char[1]"]]
eNFA120_4_25551373[["εNFA120-4 char{1, 1}"]]
eNFA120_5_28635768[["εNFA120-5 char[1]"]]
eNFA120_6_56395328[["εNFA120-6 char{1, 1}"]]
eNFA120_7_37795909[["εNFA120-7 char[1]"]]
eNFA120_8_4618864[["εNFA120-8 char{1, 1}"]]
eNFA120_9_41569778[["εNFA120-9 char[1]"]]
eNFA120_10_38583684[["εNFA120-10 char{1, 1}"]]
eNFA120_11_11708839[["εNFA120-11 char[1]"]]
eNFA120_12_38270693[["εNFA120-12 char{1, 1}"]]
eNFA120_13_8891917[["εNFA120-13 char[1]"]]
eNFA120_14_12918394[["εNFA120-14 char{1, 1}"]]
eNFA120_15_49156683[["εNFA120-15 char[1]"]]
eNFA120_16_39756971[["εNFA120-16 char{1, 1}"]]
eNFA120_17_22268426[["εNFA120-17 char[1]"]]
eNFA120_19_66198114[["εNFA120-19 regex end"]]
eNFA120_20_58912114[["εNFA120-20 post-regex start"]]
eNFA120_21_60446980[\"εNFA120-21 post-regex end"/]
eNFA120_18_54179398 -.->|"ε"|eNFA120_0_17852540
eNFA120_0_17852540 -->|"s"|eNFA120_1_26455137
eNFA120_1_26455137 -.->|"ε"|eNFA120_2_36769646
eNFA120_2_36769646 -->|"a"|eNFA120_3_62491365
eNFA120_3_62491365 -.->|"ε"|eNFA120_4_25551373
eNFA120_4_25551373 -->|"m"|eNFA120_5_28635768
eNFA120_5_28635768 -.->|"ε"|eNFA120_6_56395328
eNFA120_6_56395328 -->|"p"|eNFA120_7_37795909
eNFA120_7_37795909 -.->|"ε"|eNFA120_8_4618864
eNFA120_8_4618864 -->|"l"|eNFA120_9_41569778
eNFA120_9_41569778 -.->|"ε"|eNFA120_10_38583684
eNFA120_10_38583684 -->|"e"|eNFA120_11_11708839
eNFA120_11_11708839 -.->|"ε"|eNFA120_12_38270693
eNFA120_12_38270693 -->|"r"|eNFA120_13_8891917
eNFA120_13_8891917 -.->|"ε"|eNFA120_14_12918394
eNFA120_14_12918394 -->|"1"|eNFA120_15_49156683
eNFA120_15_49156683 -.->|"ε"|eNFA120_16_39756971
eNFA120_16_39756971 -->|"D"|eNFA120_17_22268426
eNFA120_17_22268426 -.->|"ε"|eNFA120_19_66198114
eNFA120_19_66198114 -.->|"ε"|eNFA120_20_58912114
eNFA120_20_58912114 -.->|"ε"|eNFA120_21_60446980
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
eNFA120_18_7151914[["εNFA120-18 regex start"]]
eNFA120_0_64367227[["εNFA120-0 char{1, 1}"]]
eNFA120_1_42434138[["εNFA120-1 char[1]"]]
eNFA120_2_46362927[["εNFA120-2 char{1, 1}"]]
eNFA120_3_14613163[["εNFA120-3 char[1]"]]
eNFA120_4_64409607[["εNFA120-4 char{1, 1}"]]
eNFA120_5_42815556[["εNFA120-5 char[1]"]]
eNFA120_6_49795692[["εNFA120-6 char{1, 1}"]]
eNFA120_7_45508046[["εNFA120-7 char[1]"]]
eNFA120_8_6919237[["εNFA120-8 char{1, 1}"]]
eNFA120_9_62273137[["εNFA120-9 char[1]"]]
eNFA120_10_23587323[["εNFA120-10 char{1, 1}"]]
eNFA120_11_10959316[["εNFA120-11 char[1]"]]
eNFA120_12_31524981[["εNFA120-12 char{1, 1}"]]
eNFA120_13_15289375[["εNFA120-13 char[1]"]]
eNFA120_14_3386651[["εNFA120-14 char{1, 1}"]]
eNFA120_15_30479867[["εNFA120-15 char[1]"]]
eNFA120_16_5883351[["εNFA120-16 char{1, 1}"]]
eNFA120_17_52950159[\"εNFA120-17 char[1]"/]
eNFA120_19_6789390[\"εNFA120-19 regex end"/]
eNFA120_20_61104516[\"εNFA120-20 post-regex start"/]
eNFA120_21_13069738[\"εNFA120-21 post-regex end"/]
eNFA120_18_7151914 -.->|"ε"|eNFA120_0_64367227
eNFA120_18_7151914 -->|"s"|eNFA120_1_42434138
eNFA120_0_64367227 -->|"s"|eNFA120_1_42434138
eNFA120_1_42434138 -.->|"ε"|eNFA120_2_46362927
eNFA120_1_42434138 -->|"a"|eNFA120_3_14613163
eNFA120_2_46362927 -->|"a"|eNFA120_3_14613163
eNFA120_3_14613163 -.->|"ε"|eNFA120_4_64409607
eNFA120_3_14613163 -->|"m"|eNFA120_5_42815556
eNFA120_4_64409607 -->|"m"|eNFA120_5_42815556
eNFA120_5_42815556 -.->|"ε"|eNFA120_6_49795692
eNFA120_5_42815556 -->|"p"|eNFA120_7_45508046
eNFA120_6_49795692 -->|"p"|eNFA120_7_45508046
eNFA120_7_45508046 -.->|"ε"|eNFA120_8_6919237
eNFA120_7_45508046 -->|"l"|eNFA120_9_62273137
eNFA120_8_6919237 -->|"l"|eNFA120_9_62273137
eNFA120_9_62273137 -.->|"ε"|eNFA120_10_23587323
eNFA120_9_62273137 -->|"e"|eNFA120_11_10959316
eNFA120_10_23587323 -->|"e"|eNFA120_11_10959316
eNFA120_11_10959316 -.->|"ε"|eNFA120_12_31524981
eNFA120_11_10959316 -->|"r"|eNFA120_13_15289375
eNFA120_12_31524981 -->|"r"|eNFA120_13_15289375
eNFA120_13_15289375 -.->|"ε"|eNFA120_14_3386651
eNFA120_13_15289375 -->|"1"|eNFA120_15_30479867
eNFA120_14_3386651 -->|"1"|eNFA120_15_30479867
eNFA120_15_30479867 -.->|"ε"|eNFA120_16_5883351
eNFA120_15_30479867 -->|"D"|eNFA120_17_52950159
eNFA120_16_5883351 -->|"D"|eNFA120_17_52950159
eNFA120_17_52950159 -.->|"ε"|eNFA120_19_6789390
eNFA120_17_52950159 -.->|"ε"|eNFA120_20_61104516
eNFA120_17_52950159 -.->|"ε"|eNFA120_21_13069738
eNFA120_19_6789390 -.->|"ε"|eNFA120_20_61104516
eNFA120_19_6789390 -.->|"ε"|eNFA120_21_13069738
eNFA120_20_61104516 -.->|"ε"|eNFA120_21_13069738
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
NFA120_18_50518786("NFA120-18 regex start")
NFA120_1_52015891("NFA120-1 char[1]")
NFA120_3_65489840("NFA120-3 char[1]")
NFA120_5_52537648("NFA120-5 char[1]")
NFA120_7_3076790("NFA120-7 char[1]")
NFA120_9_27691114("NFA120-9 char[1]")
NFA120_11_47893437("NFA120-11 char[1]")
NFA120_13_28387752("NFA120-13 char[1]")
NFA120_15_54163180("NFA120-15 char[1]")
NFA120_17_17706579[\"NFA120-17 char[1]"/]
NFA120_18_50518786 -->|"s"|NFA120_1_52015891
NFA120_1_52015891 -->|"a"|NFA120_3_65489840
NFA120_3_65489840 -->|"m"|NFA120_5_52537648
NFA120_5_52537648 -->|"p"|NFA120_7_3076790
NFA120_7_3076790 -->|"l"|NFA120_9_27691114
NFA120_9_27691114 -->|"e"|NFA120_11_47893437
NFA120_11_47893437 -->|"r"|NFA120_13_28387752
NFA120_13_28387752 -->|"1"|NFA120_15_54163180
NFA120_15_54163180 -->|"D"|NFA120_17_17706579
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
subgraph DFA0_-1778632827["DFA0 regex start"]
NFA120_18_50518786_0("NFA120-18 regex start")
end
subgraph DFA1_-882116911["DFA1 {1}"]
NFA120_1_52015891_1("NFA120-1 char[1]")
end
subgraph DFA2_1139328707["DFA2 {1}"]
NFA120_3_65489840_2("NFA120-3 char[1]")
end
subgraph DFA3_447688435["DFA3 {1}"]
NFA120_5_52537648_3("NFA120-5 char[1]")
end
subgraph DFA4_-1847846213["DFA4 {1}"]
NFA120_7_3076790_4("NFA120-7 char[1]")
end
subgraph DFA5_285498802["DFA5 {1}"]
NFA120_9_27691114_5("NFA120-9 char[1]")
end
subgraph DFA6_1881966845["DFA6 {1}"]
NFA120_11_47893437_6("NFA120-11 char[1]")
end
subgraph DFA7_819786628["DFA7 {1}"]
NFA120_13_28387752_7("NFA120-13 char[1]")
end
subgraph DFA8_1224681346["DFA8 {1}"]
NFA120_15_54163180_8("NFA120-15 char[1]")
end
subgraph DFA9_713260487["DFA9 {1}"]
NFA120_17_17706579_9[\"NFA120-17 char[1]"/]
end
DFA0_-1778632827 -->|"s"|DFA1_-882116911
DFA1_-882116911 -->|"a"|DFA2_1139328707
DFA2_1139328707 -->|"m"|DFA3_447688435
DFA3_447688435 -->|"p"|DFA4_-1847846213
DFA4_-1847846213 -->|"l"|DFA5_285498802
DFA5_285498802 -->|"e"|DFA6_1881966845
DFA6_1881966845 -->|"r"|DFA7_819786628
DFA7_819786628 -->|"1"|DFA8_1224681346
DFA8_1224681346 -->|"D"|DFA9_713260487
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
DFA0_-1778632827{{"DFA0 regex start"}}
DFA1_-882116911{{"DFA1 {1}"}}
DFA2_1139328707{{"DFA2 {1}"}}
DFA3_447688435{{"DFA3 {1}"}}
DFA4_-1847846213{{"DFA4 {1}"}}
DFA5_285498802{{"DFA5 {1}"}}
DFA6_1881966845{{"DFA6 {1}"}}
DFA7_819786628{{"DFA7 {1}"}}
DFA8_1224681346{{"DFA8 {1}"}}
DFA9_713260487[\"DFA9 {1}"/]
DFA0_-1778632827 -->|"s"|DFA1_-882116911
DFA1_-882116911 -->|"a"|DFA2_1139328707
DFA2_1139328707 -->|"m"|DFA3_447688435
DFA3_447688435 -->|"p"|DFA4_-1847846213
DFA4_-1847846213 -->|"l"|DFA5_285498802
DFA5_285498802 -->|"e"|DFA6_1881966845
DFA6_1881966845 -->|"r"|DFA7_819786628
DFA7_819786628 -->|"1"|DFA8_1224681346
DFA8_1224681346 -->|"D"|DFA9_713260487
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
subgraph MiniDFA0_-1901385813["MiniDFA0 {1}"]
DFA0_-1778632827_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_28858699["MiniDFA1 {1}"]
DFA1_-882116911_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-673600918["MiniDFA2 {1}"]
DFA2_1139328707_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1059053811["MiniDFA3 {1}"]
DFA3_447688435_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_926372789["MiniDFA4 {1}"]
DFA4_-1847846213_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-127437549["MiniDFA5 {1}"]
DFA5_285498802_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_2056434452["MiniDFA6 {1}"]
DFA6_1881966845_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1645361801["MiniDFA7 {1}"]
DFA7_819786628_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1575983695["MiniDFA8 {1}"]
DFA8_1224681346_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_265378883["MiniDFA9 {1}"]
DFA9_713260487_9[\"DFA9 {1}"/]
end
MiniDFA0_-1901385813 -->|"s"|MiniDFA1_28858699
MiniDFA1_28858699 -->|"a"|MiniDFA2_-673600918
MiniDFA2_-673600918 -->|"m"|MiniDFA3_1059053811
MiniDFA3_1059053811 -->|"p"|MiniDFA4_926372789
MiniDFA4_926372789 -->|"l"|MiniDFA5_-127437549
MiniDFA5_-127437549 -->|"e"|MiniDFA6_2056434452
MiniDFA6_2056434452 -->|"r"|MiniDFA7_-1645361801
MiniDFA7_-1645361801 -->|"1"|MiniDFA8_1575983695
MiniDFA8_1575983695 -->|"D"|MiniDFA9_265378883
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
MiniDFA0_-1901385813(["MiniDFA0 {1}"])
MiniDFA1_28858699(["MiniDFA1 {1}"])
MiniDFA2_-673600918(["MiniDFA2 {1}"])
MiniDFA3_1059053811(["MiniDFA3 {1}"])
MiniDFA4_926372789(["MiniDFA4 {1}"])
MiniDFA5_-127437549(["MiniDFA5 {1}"])
MiniDFA6_2056434452(["MiniDFA6 {1}"])
MiniDFA7_-1645361801(["MiniDFA7 {1}"])
MiniDFA8_1575983695(["MiniDFA8 {1}"])
MiniDFA9_265378883[\"MiniDFA9 {1}"/]
MiniDFA0_-1901385813 -->|"s"|MiniDFA1_28858699
MiniDFA1_28858699 -->|"a"|MiniDFA2_-673600918
MiniDFA2_-673600918 -->|"m"|MiniDFA3_1059053811
MiniDFA3_1059053811 -->|"p"|MiniDFA4_926372789
MiniDFA4_926372789 -->|"l"|MiniDFA5_-127437549
MiniDFA5_-127437549 -->|"e"|MiniDFA6_2056434452
MiniDFA6_2056434452 -->|"r"|MiniDFA7_-1645361801
MiniDFA7_-1645361801 -->|"1"|MiniDFA8_1575983695
MiniDFA8_1575983695 -->|"D"|MiniDFA9_265378883
```
-------------------------------
