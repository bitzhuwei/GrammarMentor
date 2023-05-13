# 'dmat4x4'

pattern: `dmat4x4`

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
eNFA118_14_30350400[["εNFA118-14 regex start"]]
eNFA118_0_4718148[["εNFA118-0 char{1, 1}"]]
eNFA118_1_42463340[["εNFA118-1 char[1]"]]
eNFA118_2_46625744[["εNFA118-2 char{1, 1}"]]
eNFA118_3_16978512[["εNFA118-3 char[1]"]]
eNFA118_4_18588887[["εNFA118-4 char{1, 1}"]]
eNFA118_5_33082261[["εNFA118-5 char[1]"]]
eNFA118_6_29304899[["εNFA118-6 char{1, 1}"]]
eNFA118_7_62417507[["εNFA118-7 char[1]"]]
eNFA118_8_24886652[["εNFA118-8 char{1, 1}"]]
eNFA118_9_22653281[["εNFA118-9 char[1]"]]
eNFA118_10_2552937[["εNFA118-10 char{1, 1}"]]
eNFA118_11_22976439[["εNFA118-11 char[1]"]]
eNFA118_12_5461363[["εNFA118-12 char{1, 1}"]]
eNFA118_13_49152270[["εNFA118-13 char[1]"]]
eNFA118_15_39717249[["εNFA118-15 regex end"]]
eNFA118_16_21910925[["εNFA118-16 post-regex start"]]
eNFA118_17_62980604[\"εNFA118-17 post-regex end"/]
eNFA118_14_30350400 -.->|"ε"|eNFA118_0_4718148
eNFA118_0_4718148 -->|"d"|eNFA118_1_42463340
eNFA118_1_42463340 -.->|"ε"|eNFA118_2_46625744
eNFA118_2_46625744 -->|"m"|eNFA118_3_16978512
eNFA118_3_16978512 -.->|"ε"|eNFA118_4_18588887
eNFA118_4_18588887 -->|"a"|eNFA118_5_33082261
eNFA118_5_33082261 -.->|"ε"|eNFA118_6_29304899
eNFA118_6_29304899 -->|"t"|eNFA118_7_62417507
eNFA118_7_62417507 -.->|"ε"|eNFA118_8_24886652
eNFA118_8_24886652 -->|"4"|eNFA118_9_22653281
eNFA118_9_22653281 -.->|"ε"|eNFA118_10_2552937
eNFA118_10_2552937 -->|"x"|eNFA118_11_22976439
eNFA118_11_22976439 -.->|"ε"|eNFA118_12_5461363
eNFA118_12_5461363 -->|"4"|eNFA118_13_49152270
eNFA118_13_49152270 -.->|"ε"|eNFA118_15_39717249
eNFA118_15_39717249 -.->|"ε"|eNFA118_16_21910925
eNFA118_16_21910925 -.->|"ε"|eNFA118_17_62980604
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
eNFA118_14_29954525[["εNFA118-14 regex start"]]
eNFA118_0_1155275[["εNFA118-0 char{1, 1}"]]
eNFA118_1_10397478[["εNFA118-1 char[1]"]]
eNFA118_2_26468439[["εNFA118-2 char{1, 1}"]]
eNFA118_3_36889359[["εNFA118-3 char[1]"]]
eNFA118_4_63568775[["εNFA118-4 char{1, 1}"]]
eNFA118_5_35248064[["εNFA118-5 char[1]"]]
eNFA118_6_48797123[["εNFA118-6 char{1, 1}"]]
eNFA118_7_36520930[["εNFA118-7 char[1]"]]
eNFA118_8_60252916[["εNFA118-8 char{1, 1}"]]
eNFA118_9_5405340[["εNFA118-9 char[1]"]]
eNFA118_10_48648066[["εNFA118-10 char{1, 1}"]]
eNFA118_11_35179415[["εNFA118-11 char[1]"]]
eNFA118_12_48179284[["εNFA118-12 char{1, 1}"]]
eNFA118_13_30960379[\"εNFA118-13 char[1]"/]
eNFA118_15_10207955[\"εNFA118-15 regex end"/]
eNFA118_16_24762734[\"εNFA118-16 post-regex start"/]
eNFA118_17_21538022[\"εNFA118-17 post-regex end"/]
eNFA118_14_29954525 -.->|"ε"|eNFA118_0_1155275
eNFA118_14_29954525 -->|"d"|eNFA118_1_10397478
eNFA118_0_1155275 -->|"d"|eNFA118_1_10397478
eNFA118_1_10397478 -.->|"ε"|eNFA118_2_26468439
eNFA118_1_10397478 -->|"m"|eNFA118_3_36889359
eNFA118_2_26468439 -->|"m"|eNFA118_3_36889359
eNFA118_3_36889359 -.->|"ε"|eNFA118_4_63568775
eNFA118_3_36889359 -->|"a"|eNFA118_5_35248064
eNFA118_4_63568775 -->|"a"|eNFA118_5_35248064
eNFA118_5_35248064 -.->|"ε"|eNFA118_6_48797123
eNFA118_5_35248064 -->|"t"|eNFA118_7_36520930
eNFA118_6_48797123 -->|"t"|eNFA118_7_36520930
eNFA118_7_36520930 -.->|"ε"|eNFA118_8_60252916
eNFA118_7_36520930 -->|"4"|eNFA118_9_5405340
eNFA118_8_60252916 -->|"4"|eNFA118_9_5405340
eNFA118_9_5405340 -.->|"ε"|eNFA118_10_48648066
eNFA118_9_5405340 -->|"x"|eNFA118_11_35179415
eNFA118_10_48648066 -->|"x"|eNFA118_11_35179415
eNFA118_11_35179415 -.->|"ε"|eNFA118_12_48179284
eNFA118_11_35179415 -->|"4"|eNFA118_13_30960379
eNFA118_12_48179284 -->|"4"|eNFA118_13_30960379
eNFA118_13_30960379 -.->|"ε"|eNFA118_15_10207955
eNFA118_13_30960379 -.->|"ε"|eNFA118_16_24762734
eNFA118_13_30960379 -.->|"ε"|eNFA118_17_21538022
eNFA118_15_10207955 -.->|"ε"|eNFA118_16_24762734
eNFA118_15_10207955 -.->|"ε"|eNFA118_17_21538022
eNFA118_16_24762734 -.->|"ε"|eNFA118_17_21538022
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
NFA118_14_59624475("NFA118-14 regex start")
NFA118_1_66858230("NFA118-1 char[1]")
NFA118_3_64853160("NFA118-3 char[1]")
NFA118_5_46807530("NFA118-5 char[1]")
NFA118_7_18614589("NFA118-7 char[1]")
NFA118_9_33313579("NFA118-9 char[1]")
NFA118_11_31386755("NFA118-11 char[1]")
NFA118_13_14045344[\"NFA118-13 char[1]"/]
NFA118_14_59624475 -->|"d"|NFA118_1_66858230
NFA118_1_66858230 -->|"m"|NFA118_3_64853160
NFA118_3_64853160 -->|"a"|NFA118_5_46807530
NFA118_5_46807530 -->|"t"|NFA118_7_18614589
NFA118_7_18614589 -->|"4"|NFA118_9_33313579
NFA118_9_33313579 -->|"x"|NFA118_11_31386755
NFA118_11_31386755 -->|"4"|NFA118_13_14045344
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
subgraph DFA0_1734808710["DFA0 regex start"]
NFA118_14_59624475_0("NFA118-14 regex start")
end
subgraph DFA1_13939451["DFA1 {1}"]
NFA118_1_66858230_1("NFA118-1 char[1]")
end
subgraph DFA2_-201832823["DFA2 {1}"]
NFA118_3_64853160_2("NFA118-3 char[1]")
end
subgraph DFA3_1462847310["DFA3 {1}"]
NFA118_5_46807530_3("NFA118-5 char[1]")
end
subgraph DFA4_1715098688["DFA4 {1}"]
NFA118_7_18614589_4("NFA118-7 char[1]")
end
subgraph DFA5_-1002088902["DFA5 {1}"]
NFA118_9_33313579_5("NFA118-9 char[1]")
end
subgraph DFA6_-58221208["DFA6 {1}"]
NFA118_11_31386755_6("NFA118-11 char[1]")
end
subgraph DFA7_-1997653781["DFA7 {1}"]
NFA118_13_14045344_7[\"NFA118-13 char[1]"/]
end
DFA0_1734808710 -->|"d"|DFA1_13939451
DFA1_13939451 -->|"m"|DFA2_-201832823
DFA2_-201832823 -->|"a"|DFA3_1462847310
DFA3_1462847310 -->|"t"|DFA4_1715098688
DFA4_1715098688 -->|"4"|DFA5_-1002088902
DFA5_-1002088902 -->|"x"|DFA6_-58221208
DFA6_-58221208 -->|"4"|DFA7_-1997653781
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
DFA0_1734808710{{"DFA0 regex start"}}
DFA1_13939451{{"DFA1 {1}"}}
DFA2_-201832823{{"DFA2 {1}"}}
DFA3_1462847310{{"DFA3 {1}"}}
DFA4_1715098688{{"DFA4 {1}"}}
DFA5_-1002088902{{"DFA5 {1}"}}
DFA6_-58221208{{"DFA6 {1}"}}
DFA7_-1997653781[\"DFA7 {1}"/]
DFA0_1734808710 -->|"d"|DFA1_13939451
DFA1_13939451 -->|"m"|DFA2_-201832823
DFA2_-201832823 -->|"a"|DFA3_1462847310
DFA3_1462847310 -->|"t"|DFA4_1715098688
DFA4_1715098688 -->|"4"|DFA5_-1002088902
DFA5_-1002088902 -->|"x"|DFA6_-58221208
DFA6_-58221208 -->|"4"|DFA7_-1997653781
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
subgraph MiniDFA0_-1269191274["MiniDFA0 {1}"]
DFA0_1734808710_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2067775077["MiniDFA1 {1}"]
DFA1_13939451_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-457118371["MiniDFA2 {1}"]
DFA2_-201832823_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1567704449["MiniDFA3 {1}"]
DFA3_1462847310_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1792441474["MiniDFA4 {1}"]
DFA4_1715098688_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1446957676["MiniDFA5 {1}"]
DFA5_-1002088902_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_491770450["MiniDFA6 {1}"]
DFA6_-58221208_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_4953181["MiniDFA7 {1}"]
DFA7_-1997653781_7[\"DFA7 {1}"/]
end
MiniDFA0_-1269191274 -->|"d"|MiniDFA1_2067775077
MiniDFA1_2067775077 -->|"m"|MiniDFA2_-457118371
MiniDFA2_-457118371 -->|"a"|MiniDFA3_-1567704449
MiniDFA3_-1567704449 -->|"t"|MiniDFA4_-1792441474
MiniDFA4_-1792441474 -->|"4"|MiniDFA5_-1446957676
MiniDFA5_-1446957676 -->|"x"|MiniDFA6_491770450
MiniDFA6_491770450 -->|"4"|MiniDFA7_4953181
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
MiniDFA0_-1269191274(["MiniDFA0 {1}"])
MiniDFA1_2067775077(["MiniDFA1 {1}"])
MiniDFA2_-457118371(["MiniDFA2 {1}"])
MiniDFA3_-1567704449(["MiniDFA3 {1}"])
MiniDFA4_-1792441474(["MiniDFA4 {1}"])
MiniDFA5_-1446957676(["MiniDFA5 {1}"])
MiniDFA6_491770450(["MiniDFA6 {1}"])
MiniDFA7_4953181[\"MiniDFA7 {1}"/]
MiniDFA0_-1269191274 -->|"d"|MiniDFA1_2067775077
MiniDFA1_2067775077 -->|"m"|MiniDFA2_-457118371
MiniDFA2_-457118371 -->|"a"|MiniDFA3_-1567704449
MiniDFA3_-1567704449 -->|"t"|MiniDFA4_-1792441474
MiniDFA4_-1792441474 -->|"4"|MiniDFA5_-1446957676
MiniDFA5_-1446957676 -->|"x"|MiniDFA6_491770450
MiniDFA6_491770450 -->|"4"|MiniDFA7_4953181
```
-------------------------------
