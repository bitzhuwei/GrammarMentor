# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA7_16_24818239[["εNFA7-16 regex start"]]
eNFA7_0_22037565[["εNFA7-0 char{1, 1}"]]
eNFA7_1_64120358[["εNFA7-1 char[1]"]]
eNFA7_2_40212317[["εNFA7-2 char{1, 1}"]]
eNFA7_3_65741925[["εNFA7-3 char[1]"]]
eNFA7_6_5772232[["εNFA7-6 regex start"]]
eNFA7_4_64897643[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_51950091[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_47207880[["εNFA7-7 regex end"]]
eNFA7_5_23495690[["εNFA7-5 scope[1]"]]
eNFA7_9_51316583[["εNFA7-9 scope[1]"]]
eNFA7_12_54806415[["εNFA7-12 char{1, 1}"]]
eNFA7_10_2932438[["εNFA7-10 scope{1, 1}"]]
eNFA7_13_26391943[["εNFA7-13 char[1]"]]
eNFA7_11_6165902[["εNFA7-11 scope[1]"]]
eNFA7_14_36200896[["εNFA7-14 char{1, 1}"]]
eNFA7_15_46591446[["εNFA7-15 char[1]"]]
eNFA7_17_16669838[["εNFA7-17 regex end"]]
eNFA7_18_15810818[["εNFA7-18 post-regex start"]]
eNFA7_19_8079634[\"εNFA7-19 post-regex end"/]
eNFA7_16_24818239 -.->|"ε"|eNFA7_0_22037565
eNFA7_0_22037565 -->|"/"|eNFA7_1_64120358
eNFA7_1_64120358 -.->|"ε"|eNFA7_2_40212317
eNFA7_2_40212317 -->|"*"|eNFA7_3_65741925
eNFA7_3_65741925 -.->|"ε"|eNFA7_6_5772232
eNFA7_6_5772232 -.->|"ε"|eNFA7_4_64897643
eNFA7_6_5772232 -.->|"ε"|eNFA7_8_51950091
eNFA7_6_5772232 -.->|"ε"|eNFA7_7_47207880
eNFA7_4_64897643 -->|"[^*]"|eNFA7_5_23495690
eNFA7_8_51950091 -->|"[*]"|eNFA7_9_51316583
eNFA7_7_47207880 -.->|"ε"|eNFA7_6_5772232
eNFA7_7_47207880 -.->|"ε"|eNFA7_12_54806415
eNFA7_5_23495690 -.->|"ε"|eNFA7_7_47207880
eNFA7_9_51316583 -.->|"ε"|eNFA7_10_2932438
eNFA7_12_54806415 -->|"*"|eNFA7_13_26391943
eNFA7_10_2932438 -->|"[^/]"|eNFA7_11_6165902
eNFA7_13_26391943 -.->|"ε"|eNFA7_14_36200896
eNFA7_11_6165902 -.->|"ε"|eNFA7_7_47207880
eNFA7_14_36200896 -->|"/"|eNFA7_15_46591446
eNFA7_15_46591446 -.->|"ε"|eNFA7_17_16669838
eNFA7_17_16669838 -.->|"ε"|eNFA7_18_15810818
eNFA7_18_15810818 -.->|"ε"|eNFA7_19_8079634
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
eNFA7_16_5607849[["εNFA7-16 regex start"]]
eNFA7_0_50470647[["εNFA7-0 char{1, 1}"]]
eNFA7_1_51582645[["εNFA7-1 char[1]"]]
eNFA7_2_61590629[["εNFA7-2 char{1, 1}"]]
eNFA7_3_59196065[["εNFA7-3 char[1]"]]
eNFA7_6_26366538[["εNFA7-6 regex start"]]
eNFA7_4_55314834[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_35972254[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_28071463[["εNFA7-7 regex end"]]
eNFA7_5_30151988[["εNFA7-5 scope[1]"]]
eNFA7_9_17444750[["εNFA7-9 scope[1]"]]
eNFA7_12_63002544[["εNFA7-12 char{1, 1}"]]
eNFA7_13_3738651[["εNFA7-13 char[1]"]]
eNFA7_10_22785027[["εNFA7-10 scope{1, 1}"]]
eNFA7_11_57372610[["εNFA7-11 scope[1]"]]
eNFA7_14_33647865[["εNFA7-14 char{1, 1}"]]
eNFA7_15_34395333[\"εNFA7-15 char[1]"/]
eNFA7_17_41122544[\"εNFA7-17 regex end"/]
eNFA7_18_34558579[\"εNFA7-18 post-regex start"/]
eNFA7_19_42591759[\"εNFA7-19 post-regex end"/]
eNFA7_16_5607849 -.->|"ε"|eNFA7_0_50470647
eNFA7_16_5607849 -->|"/"|eNFA7_1_51582645
eNFA7_0_50470647 -->|"/"|eNFA7_1_51582645
eNFA7_1_51582645 -.->|"ε"|eNFA7_2_61590629
eNFA7_1_51582645 -->|"*"|eNFA7_3_59196065
eNFA7_2_61590629 -->|"*"|eNFA7_3_59196065
eNFA7_3_59196065 -.->|"ε"|eNFA7_6_26366538
eNFA7_3_59196065 -.->|"ε"|eNFA7_4_55314834
eNFA7_3_59196065 -.->|"ε"|eNFA7_8_35972254
eNFA7_3_59196065 -.->|"ε"|eNFA7_7_28071463
eNFA7_3_59196065 -->|"[^*]"|eNFA7_5_30151988
eNFA7_3_59196065 -->|"[*]"|eNFA7_9_17444750
eNFA7_3_59196065 -.->|"ε"|eNFA7_12_63002544
eNFA7_3_59196065 -->|"*"|eNFA7_13_3738651
eNFA7_6_26366538 -.->|"ε"|eNFA7_4_55314834
eNFA7_6_26366538 -.->|"ε"|eNFA7_8_35972254
eNFA7_6_26366538 -.->|"ε"|eNFA7_7_28071463
eNFA7_6_26366538 -->|"[^*]"|eNFA7_5_30151988
eNFA7_6_26366538 -->|"[*]"|eNFA7_9_17444750
eNFA7_6_26366538 -.->|"ε"|eNFA7_6_26366538
eNFA7_6_26366538 -.->|"ε"|eNFA7_12_63002544
eNFA7_6_26366538 -->|"*"|eNFA7_13_3738651
eNFA7_4_55314834 -->|"[^*]"|eNFA7_5_30151988
eNFA7_8_35972254 -->|"[*]"|eNFA7_9_17444750
eNFA7_7_28071463 -.->|"ε"|eNFA7_6_26366538
eNFA7_7_28071463 -.->|"ε"|eNFA7_12_63002544
eNFA7_7_28071463 -.->|"ε"|eNFA7_4_55314834
eNFA7_7_28071463 -.->|"ε"|eNFA7_8_35972254
eNFA7_7_28071463 -.->|"ε"|eNFA7_7_28071463
eNFA7_7_28071463 -->|"[^*]"|eNFA7_5_30151988
eNFA7_7_28071463 -->|"[*]"|eNFA7_9_17444750
eNFA7_7_28071463 -->|"*"|eNFA7_13_3738651
eNFA7_5_30151988 -.->|"ε"|eNFA7_7_28071463
eNFA7_5_30151988 -.->|"ε"|eNFA7_6_26366538
eNFA7_5_30151988 -.->|"ε"|eNFA7_12_63002544
eNFA7_5_30151988 -.->|"ε"|eNFA7_4_55314834
eNFA7_5_30151988 -.->|"ε"|eNFA7_8_35972254
eNFA7_5_30151988 -->|"[^*]"|eNFA7_5_30151988
eNFA7_5_30151988 -->|"[*]"|eNFA7_9_17444750
eNFA7_5_30151988 -->|"*"|eNFA7_13_3738651
eNFA7_9_17444750 -.->|"ε"|eNFA7_10_22785027
eNFA7_9_17444750 -->|"[^/]"|eNFA7_11_57372610
eNFA7_12_63002544 -->|"*"|eNFA7_13_3738651
eNFA7_13_3738651 -.->|"ε"|eNFA7_14_33647865
eNFA7_13_3738651 -->|"/"|eNFA7_15_34395333
eNFA7_10_22785027 -->|"[^/]"|eNFA7_11_57372610
eNFA7_11_57372610 -.->|"ε"|eNFA7_7_28071463
eNFA7_11_57372610 -.->|"ε"|eNFA7_6_26366538
eNFA7_11_57372610 -.->|"ε"|eNFA7_12_63002544
eNFA7_11_57372610 -.->|"ε"|eNFA7_4_55314834
eNFA7_11_57372610 -.->|"ε"|eNFA7_8_35972254
eNFA7_11_57372610 -->|"[^*]"|eNFA7_5_30151988
eNFA7_11_57372610 -->|"[*]"|eNFA7_9_17444750
eNFA7_11_57372610 -->|"*"|eNFA7_13_3738651
eNFA7_14_33647865 -->|"/"|eNFA7_15_34395333
eNFA7_15_34395333 -.->|"ε"|eNFA7_17_41122544
eNFA7_15_34395333 -.->|"ε"|eNFA7_18_34558579
eNFA7_15_34395333 -.->|"ε"|eNFA7_19_42591759
eNFA7_17_41122544 -.->|"ε"|eNFA7_18_34558579
eNFA7_17_41122544 -.->|"ε"|eNFA7_19_42591759
eNFA7_18_34558579 -.->|"ε"|eNFA7_19_42591759
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
NFA7_16_60007281("NFA7-16 regex start")
NFA7_1_3194617("NFA7-1 char[1]")
NFA7_3_47781518("NFA7-3 char[1]")
NFA7_5_45097725("NFA7-5 scope[1]")
NFA7_9_27380479("NFA7-9 scope[1]")
NFA7_13_3226344("NFA7-13 char[1]")
NFA7_11_29037097("NFA7-11 scope[1]")
NFA7_15_28751554[\"NFA7-15 char[1]"/]
NFA7_16_60007281 -->|"/"|NFA7_1_3194617
NFA7_1_3194617 -->|"*"|NFA7_3_47781518
NFA7_3_47781518 -->|"[^*]"|NFA7_5_45097725
NFA7_3_47781518 -->|"[*]"|NFA7_9_27380479
NFA7_3_47781518 -->|"*"|NFA7_13_3226344
NFA7_5_45097725 -->|"[^*]"|NFA7_5_45097725
NFA7_5_45097725 -->|"[*]"|NFA7_9_27380479
NFA7_5_45097725 -->|"*"|NFA7_13_3226344
NFA7_9_27380479 -->|"[^/]"|NFA7_11_29037097
NFA7_13_3226344 -->|"/"|NFA7_15_28751554
NFA7_11_29037097 -->|"[^*]"|NFA7_5_45097725
NFA7_11_29037097 -->|"[*]"|NFA7_9_27380479
NFA7_11_29037097 -->|"*"|NFA7_13_3226344
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
subgraph DFA0_-541616746["DFA0 regex start"]
NFA7_16_60007281_0("NFA7-16 regex start")
end
subgraph DFA1_1151147297["DFA1 {1}"]
NFA7_1_3194617_1("NFA7-1 char[1]")
end
subgraph DFA2_-790990007["DFA2 {1}"]
NFA7_3_47781518_2("NFA7-3 char[1]")
end
subgraph DFA3_-1964566411["DFA3 {1}"]
NFA7_5_45097725_3("NFA7-5 scope[1]")
end
subgraph DFA4_1543045244["DFA4 {2}"]
NFA7_9_27380479_4("NFA7-9 scope[1]")
NFA7_13_3226344_5("NFA7-13 char[1]")
end
subgraph DFA5_243914616["DFA5 {1}"]
NFA7_11_29037097_6("NFA7-11 scope[1]")
end
subgraph DFA6_-1461898603["DFA6 {1}"]
NFA7_15_28751554_7[\"NFA7-15 char[1]"/]
end
DFA0_-541616746 -->|"/"|DFA1_1151147297
DFA1_1151147297 -->|"*"|DFA2_-790990007
DFA2_-790990007 -->|"[^*]"|DFA3_-1964566411
DFA2_-790990007 -->|"*"|DFA4_1543045244
DFA3_-1964566411 -->|"[^*]"|DFA3_-1964566411
DFA3_-1964566411 -->|"*"|DFA4_1543045244
DFA4_1543045244 -->|"[^/]"|DFA5_243914616
DFA4_1543045244 -->|"/"|DFA6_-1461898603
DFA5_243914616 -->|"[^*]"|DFA3_-1964566411
DFA5_243914616 -->|"*"|DFA4_1543045244
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
DFA0_-541616746{{"DFA0 regex start"}}
DFA1_1151147297{{"DFA1 {1}"}}
DFA2_-790990007{{"DFA2 {1}"}}
DFA3_-1964566411{{"DFA3 {1}"}}
DFA4_1543045244{{"DFA4 {2}"}}
DFA5_243914616{{"DFA5 {1}"}}
DFA6_-1461898603[\"DFA6 {1}"/]
DFA0_-541616746 -->|"/"|DFA1_1151147297
DFA1_1151147297 -->|"*"|DFA2_-790990007
DFA2_-790990007 -->|"[^*]"|DFA3_-1964566411
DFA2_-790990007 -->|"*"|DFA4_1543045244
DFA3_-1964566411 -->|"[^*]"|DFA3_-1964566411
DFA3_-1964566411 -->|"*"|DFA4_1543045244
DFA4_1543045244 -->|"[^/]"|DFA5_243914616
DFA4_1543045244 -->|"/"|DFA6_-1461898603
DFA5_243914616 -->|"[^*]"|DFA3_-1964566411
DFA5_243914616 -->|"*"|DFA4_1543045244
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
subgraph MiniDFA0_199039135["MiniDFA0 {1}"]
DFA0_-541616746_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-699743334["MiniDFA1 {1}"]
DFA1_1151147297_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_487771005["MiniDFA2 {3}"]
DFA2_-790990007_2{{"DFA2 {1}"}}
DFA3_-1964566411_3{{"DFA3 {1}"}}
DFA5_243914616_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_-141348777["MiniDFA3 {1}"]
DFA4_1543045244_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-974982848["MiniDFA4 {1}"]
DFA6_-1461898603_6[\"DFA6 {1}"/]
end
MiniDFA0_199039135 -->|"/"|MiniDFA1_-699743334
MiniDFA1_-699743334 -->|"*"|MiniDFA2_487771005
MiniDFA2_487771005 -->|"[^*]"|MiniDFA2_487771005
MiniDFA2_487771005 -->|"*"|MiniDFA3_-141348777
MiniDFA3_-141348777 -->|"[^/]"|MiniDFA2_487771005
MiniDFA3_-141348777 -->|"/"|MiniDFA4_-974982848
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
MiniDFA0_199039135(["MiniDFA0 {1}"])
MiniDFA1_-699743334(["MiniDFA1 {1}"])
MiniDFA2_487771005(["MiniDFA2 {3}"])
MiniDFA3_-141348777(["MiniDFA3 {1}"])
MiniDFA4_-974982848[\"MiniDFA4 {1}"/]
MiniDFA0_199039135 -->|"/"|MiniDFA1_-699743334
MiniDFA1_-699743334 -->|"*"|MiniDFA2_487771005
MiniDFA2_487771005 -->|"[^*]"|MiniDFA2_487771005
MiniDFA2_487771005 -->|"*"|MiniDFA3_-141348777
MiniDFA3_-141348777 -->|"[^/]"|MiniDFA2_487771005
MiniDFA3_-141348777 -->|"/"|MiniDFA4_-974982848
```
-------------------------------
