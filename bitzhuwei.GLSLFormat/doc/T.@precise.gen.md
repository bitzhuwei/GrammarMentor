# 'precise'

pattern: `precise`

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
eNFA57_14_66373591[["εNFA57-14 regex start"]]
eNFA57_0_60491410[["εNFA57-0 char{1, 1}"]]
eNFA57_1_7551780[["εNFA57-1 char[1]"]]
eNFA57_2_857158[["εNFA57-2 char{1, 1}"]]
eNFA57_3_7714425[["εNFA57-3 char[1]"]]
eNFA57_4_2320967[["εNFA57-4 char{1, 1}"]]
eNFA57_5_20888703[["εNFA57-5 char[1]"]]
eNFA57_6_53780604[["εNFA57-6 char{1, 1}"]]
eNFA57_7_14263389[["εNFA57-7 char[1]"]]
eNFA57_8_61261645[["εNFA57-8 char{1, 1}"]]
eNFA57_9_14483900[["εNFA57-9 char[1]"]]
eNFA57_10_63246244[["εNFA57-10 char{1, 1}"]]
eNFA57_11_32345284[["εNFA57-11 char[1]"]]
eNFA57_12_22672102[["εNFA57-12 char{1, 1}"]]
eNFA57_13_2722332[["εNFA57-13 char[1]"]]
eNFA57_15_24500989[["εNFA57-15 regex end"]]
eNFA57_16_19182316[["εNFA57-16 post-regex start"]]
eNFA57_17_38423121[\"εNFA57-17 post-regex end"/]
eNFA57_14_66373591 -.->|"ε"|eNFA57_0_60491410
eNFA57_0_60491410 -->|"p"|eNFA57_1_7551780
eNFA57_1_7551780 -.->|"ε"|eNFA57_2_857158
eNFA57_2_857158 -->|"r"|eNFA57_3_7714425
eNFA57_3_7714425 -.->|"ε"|eNFA57_4_2320967
eNFA57_4_2320967 -->|"e"|eNFA57_5_20888703
eNFA57_5_20888703 -.->|"ε"|eNFA57_6_53780604
eNFA57_6_53780604 -->|"c"|eNFA57_7_14263389
eNFA57_7_14263389 -.->|"ε"|eNFA57_8_61261645
eNFA57_8_61261645 -->|"i"|eNFA57_9_14483900
eNFA57_9_14483900 -.->|"ε"|eNFA57_10_63246244
eNFA57_10_63246244 -->|"s"|eNFA57_11_32345284
eNFA57_11_32345284 -.->|"ε"|eNFA57_12_22672102
eNFA57_12_22672102 -->|"e"|eNFA57_13_2722332
eNFA57_13_2722332 -.->|"ε"|eNFA57_15_24500989
eNFA57_15_24500989 -.->|"ε"|eNFA57_16_19182316
eNFA57_16_19182316 -.->|"ε"|eNFA57_17_38423121
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
eNFA57_14_10263773[["εNFA57-14 regex start"]]
eNFA57_0_25265097[["εNFA57-0 char{1, 1}"]]
eNFA57_1_26059286[["εNFA57-1 char[1]"]]
eNFA57_2_33206990[["εNFA57-2 char{1, 1}"]]
eNFA57_3_30427456[["εNFA57-3 char[1]"]]
eNFA57_4_5411655[["εNFA57-4 char{1, 1}"]]
eNFA57_5_48704899[["εNFA57-5 char[1]"]]
eNFA57_6_35690909[["εNFA57-6 char{1, 1}"]]
eNFA57_7_52782726[["εNFA57-7 char[1]"]]
eNFA57_8_5282487[["εNFA57-8 char{1, 1}"]]
eNFA57_9_47542385[["εNFA57-9 char[1]"]]
eNFA57_10_25228285[["εNFA57-10 char{1, 1}"]]
eNFA57_11_25727981[["εNFA57-11 char[1]"]]
eNFA57_12_30225241[["εNFA57-12 char{1, 1}"]]
eNFA57_13_3591713[\"εNFA57-13 char[1]"/]
eNFA57_15_32325424[\"εNFA57-15 regex end"/]
eNFA57_16_22493366[\"εNFA57-16 post-regex start"/]
eNFA57_17_1113708[\"εNFA57-17 post-regex end"/]
eNFA57_14_10263773 -.->|"ε"|eNFA57_0_25265097
eNFA57_14_10263773 -->|"p"|eNFA57_1_26059286
eNFA57_0_25265097 -->|"p"|eNFA57_1_26059286
eNFA57_1_26059286 -.->|"ε"|eNFA57_2_33206990
eNFA57_1_26059286 -->|"r"|eNFA57_3_30427456
eNFA57_2_33206990 -->|"r"|eNFA57_3_30427456
eNFA57_3_30427456 -.->|"ε"|eNFA57_4_5411655
eNFA57_3_30427456 -->|"e"|eNFA57_5_48704899
eNFA57_4_5411655 -->|"e"|eNFA57_5_48704899
eNFA57_5_48704899 -.->|"ε"|eNFA57_6_35690909
eNFA57_5_48704899 -->|"c"|eNFA57_7_52782726
eNFA57_6_35690909 -->|"c"|eNFA57_7_52782726
eNFA57_7_52782726 -.->|"ε"|eNFA57_8_5282487
eNFA57_7_52782726 -->|"i"|eNFA57_9_47542385
eNFA57_8_5282487 -->|"i"|eNFA57_9_47542385
eNFA57_9_47542385 -.->|"ε"|eNFA57_10_25228285
eNFA57_9_47542385 -->|"s"|eNFA57_11_25727981
eNFA57_10_25228285 -->|"s"|eNFA57_11_25727981
eNFA57_11_25727981 -.->|"ε"|eNFA57_12_30225241
eNFA57_11_25727981 -->|"e"|eNFA57_13_3591713
eNFA57_12_30225241 -->|"e"|eNFA57_13_3591713
eNFA57_13_3591713 -.->|"ε"|eNFA57_15_32325424
eNFA57_13_3591713 -.->|"ε"|eNFA57_16_22493366
eNFA57_13_3591713 -.->|"ε"|eNFA57_17_1113708
eNFA57_15_32325424 -.->|"ε"|eNFA57_16_22493366
eNFA57_15_32325424 -.->|"ε"|eNFA57_17_1113708
eNFA57_16_22493366 -.->|"ε"|eNFA57_17_1113708
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
NFA57_14_10023380("NFA57-14 regex start")
NFA57_1_23101557("NFA57-1 char[1]")
NFA57_3_6587426("NFA57-3 char[1]")
NFA57_5_59286834("NFA57-5 char[1]")
NFA57_7_63819464("NFA57-7 char[1]")
NFA57_9_37504268("NFA57-9 char[1]")
NFA57_11_1994095("NFA57-11 char[1]")
NFA57_13_17946858[\"NFA57-13 char[1]"/]
NFA57_14_10023380 -->|"p"|NFA57_1_23101557
NFA57_1_23101557 -->|"r"|NFA57_3_6587426
NFA57_3_6587426 -->|"e"|NFA57_5_59286834
NFA57_5_59286834 -->|"c"|NFA57_7_63819464
NFA57_7_63819464 -->|"i"|NFA57_9_37504268
NFA57_9_37504268 -->|"s"|NFA57_11_1994095
NFA57_11_1994095 -->|"e"|NFA57_13_17946858
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
subgraph DFA0_-1900431429["DFA0 regex start"]
NFA57_14_10023380_0("NFA57-14 regex start")
end
subgraph DFA1_270186223["DFA1 {1}"]
NFA57_1_23101557_1("NFA57-1 char[1]")
end
subgraph DFA2_-1194502234["DFA2 {1}"]
NFA57_3_6587426_2("NFA57-3 char[1]")
end
subgraph DFA3_1196892287["DFA3 {1}"]
NFA57_5_59286834_3("NFA57-5 char[1]")
end
subgraph DFA4_1626973038["DFA4 {1}"]
NFA57_7_63819464_4("NFA57-7 char[1]")
end
subgraph DFA5_-1975403236["DFA5 {1}"]
NFA57_9_37504268_5("NFA57-9 char[1]")
end
subgraph DFA6_-1327155549["DFA6 {1}"]
NFA57_11_1994095_6("NFA57-11 char[1]")
end
subgraph DFA7_-1490539861["DFA7 {1}"]
NFA57_13_17946858_7[\"NFA57-13 char[1]"/]
end
DFA0_-1900431429 -->|"p"|DFA1_270186223
DFA1_270186223 -->|"r"|DFA2_-1194502234
DFA2_-1194502234 -->|"e"|DFA3_1196892287
DFA3_1196892287 -->|"c"|DFA4_1626973038
DFA4_1626973038 -->|"i"|DFA5_-1975403236
DFA5_-1975403236 -->|"s"|DFA6_-1327155549
DFA6_-1327155549 -->|"e"|DFA7_-1490539861
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
DFA0_-1900431429{{"DFA0 regex start"}}
DFA1_270186223{{"DFA1 {1}"}}
DFA2_-1194502234{{"DFA2 {1}"}}
DFA3_1196892287{{"DFA3 {1}"}}
DFA4_1626973038{{"DFA4 {1}"}}
DFA5_-1975403236{{"DFA5 {1}"}}
DFA6_-1327155549{{"DFA6 {1}"}}
DFA7_-1490539861[\"DFA7 {1}"/]
DFA0_-1900431429 -->|"p"|DFA1_270186223
DFA1_270186223 -->|"r"|DFA2_-1194502234
DFA2_-1194502234 -->|"e"|DFA3_1196892287
DFA3_1196892287 -->|"c"|DFA4_1626973038
DFA4_1626973038 -->|"i"|DFA5_-1975403236
DFA5_-1975403236 -->|"s"|DFA6_-1327155549
DFA6_-1327155549 -->|"e"|DFA7_-1490539861
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
subgraph MiniDFA0_-94707051["MiniDFA0 {1}"]
DFA0_-1900431429_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1834536283["MiniDFA1 {1}"]
DFA1_270186223_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1438134019["MiniDFA2 {1}"]
DFA2_-1194502234_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1710148083["MiniDFA3 {1}"]
DFA3_1196892287_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_2042029195["MiniDFA4 {1}"]
DFA4_1626973038_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-671556822["MiniDFA5 {1}"]
DFA5_-1975403236_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1071292491["MiniDFA6 {1}"]
DFA6_-1327155549_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1860014713["MiniDFA7 {1}"]
DFA7_-1490539861_7[\"DFA7 {1}"/]
end
MiniDFA0_-94707051 -->|"p"|MiniDFA1_1834536283
MiniDFA1_1834536283 -->|"r"|MiniDFA2_1438134019
MiniDFA2_1438134019 -->|"e"|MiniDFA3_1710148083
MiniDFA3_1710148083 -->|"c"|MiniDFA4_2042029195
MiniDFA4_2042029195 -->|"i"|MiniDFA5_-671556822
MiniDFA5_-671556822 -->|"s"|MiniDFA6_1071292491
MiniDFA6_1071292491 -->|"e"|MiniDFA7_1860014713
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
MiniDFA0_-94707051(["MiniDFA0 {1}"])
MiniDFA1_1834536283(["MiniDFA1 {1}"])
MiniDFA2_1438134019(["MiniDFA2 {1}"])
MiniDFA3_1710148083(["MiniDFA3 {1}"])
MiniDFA4_2042029195(["MiniDFA4 {1}"])
MiniDFA5_-671556822(["MiniDFA5 {1}"])
MiniDFA6_1071292491(["MiniDFA6 {1}"])
MiniDFA7_1860014713[\"MiniDFA7 {1}"/]
MiniDFA0_-94707051 -->|"p"|MiniDFA1_1834536283
MiniDFA1_1834536283 -->|"r"|MiniDFA2_1438134019
MiniDFA2_1438134019 -->|"e"|MiniDFA3_1710148083
MiniDFA3_1710148083 -->|"c"|MiniDFA4_2042029195
MiniDFA4_2042029195 -->|"i"|MiniDFA5_-671556822
MiniDFA5_-671556822 -->|"s"|MiniDFA6_1071292491
MiniDFA6_1071292491 -->|"e"|MiniDFA7_1860014713
```
-------------------------------
