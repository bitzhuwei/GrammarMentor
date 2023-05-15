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
eNFA17_16_33082261[["εNFA17-16 regex start"]]
eNFA17_0_29304899[["εNFA17-0 char{1, 1}"]]
eNFA17_1_62417507[["εNFA17-1 char[1]"]]
eNFA17_2_24886652[["εNFA17-2 char{1, 1}"]]
eNFA17_3_12825854[["εNFA17-3 char[1]"]]
eNFA17_6_9862716[["εNFA17-6 regex start"]]
eNFA17_4_60682533[["εNFA17-4 scope{1, 1}"]]
eNFA17_8_21655584[["εNFA17-8 scope{1, 1}"]]
eNFA17_7_9271893[["εNFA17-7 regex end"]]
eNFA17_5_32261252[["εNFA17-5 scope[1]"]]
eNFA17_9_49152270[["εNFA17-9 scope[1]"]]
eNFA17_12_48323826[["εNFA17-12 char{1, 1}"]]
eNFA17_10_29954525[["εNFA17-10 scope{1, 1}"]]
eNFA17_13_1155275[["εNFA17-13 char[1]"]]
eNFA17_11_4718148[["εNFA17-11 scope[1]"]]
eNFA17_14_10397478[["εNFA17-14 char{1, 1}"]]
eNFA17_15_36889359[["εNFA17-15 char[1]"]]
eNFA17_17_63568775[["εNFA17-17 regex end"]]
eNFA17_18_35248064[["εNFA17-18 post-regex start"]]
eNFA17_19_48797123[\"εNFA17-19 post-regex end"/]
eNFA17_16_33082261 -.->|"ε"|eNFA17_0_29304899
eNFA17_0_29304899 -->|"/"|eNFA17_1_62417507
eNFA17_1_62417507 -.->|"ε"|eNFA17_2_24886652
eNFA17_2_24886652 -->|"*"|eNFA17_3_12825854
eNFA17_3_12825854 -.->|"ε"|eNFA17_6_9862716
eNFA17_6_9862716 -.->|"ε"|eNFA17_4_60682533
eNFA17_6_9862716 -.->|"ε"|eNFA17_8_21655584
eNFA17_6_9862716 -.->|"ε"|eNFA17_7_9271893
eNFA17_4_60682533 -->|"[^*]"|eNFA17_5_32261252
eNFA17_8_21655584 -->|"[*]"|eNFA17_9_49152270
eNFA17_7_9271893 -.->|"ε"|eNFA17_6_9862716
eNFA17_7_9271893 -.->|"ε"|eNFA17_12_48323826
eNFA17_5_32261252 -.->|"ε"|eNFA17_7_9271893
eNFA17_9_49152270 -.->|"ε"|eNFA17_10_29954525
eNFA17_12_48323826 -->|"*"|eNFA17_13_1155275
eNFA17_10_29954525 -->|"[^/]"|eNFA17_11_4718148
eNFA17_13_1155275 -.->|"ε"|eNFA17_14_10397478
eNFA17_11_4718148 -.->|"ε"|eNFA17_7_9271893
eNFA17_14_10397478 -->|"/"|eNFA17_15_36889359
eNFA17_15_36889359 -.->|"ε"|eNFA17_17_63568775
eNFA17_17_63568775 -.->|"ε"|eNFA17_18_35248064
eNFA17_18_35248064 -.->|"ε"|eNFA17_19_48797123
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
eNFA17_16_36520930[["εNFA17-16 regex start"]]
eNFA17_0_60252916[["εNFA17-0 char{1, 1}"]]
eNFA17_1_5405340[["εNFA17-1 char[1]"]]
eNFA17_2_48648066[["εNFA17-2 char{1, 1}"]]
eNFA17_3_39717249[["εNFA17-3 char[1]"]]
eNFA17_6_22653281[["εNFA17-6 regex start"]]
eNFA17_4_22976439[["εNFA17-4 scope{1, 1}"]]
eNFA17_8_2552937[["εNFA17-8 scope{1, 1}"]]
eNFA17_7_5461363[["εNFA17-7 regex end"]]
eNFA17_5_62980604[["εNFA17-5 scope[1]"]]
eNFA17_9_35179415[["εNFA17-9 scope[1]"]]
eNFA17_12_21910925[["εNFA17-12 char{1, 1}"]]
eNFA17_13_30960379[["εNFA17-13 char[1]"]]
eNFA17_10_48179284[["εNFA17-10 scope{1, 1}"]]
eNFA17_11_26468439[["εNFA17-11 scope[1]"]]
eNFA17_14_10207955[["εNFA17-14 char{1, 1}"]]
eNFA17_15_24762734[\"εNFA17-15 char[1]"/]
eNFA17_17_21538022[\"εNFA17-17 regex end"/]
eNFA17_18_59624475[\"εNFA17-18 post-regex start"/]
eNFA17_19_66858230[\"εNFA17-19 post-regex end"/]
eNFA17_16_36520930 -.->|"ε"|eNFA17_0_60252916
eNFA17_16_36520930 -->|"/"|eNFA17_1_5405340
eNFA17_0_60252916 -->|"/"|eNFA17_1_5405340
eNFA17_1_5405340 -.->|"ε"|eNFA17_2_48648066
eNFA17_1_5405340 -->|"*"|eNFA17_3_39717249
eNFA17_2_48648066 -->|"*"|eNFA17_3_39717249
eNFA17_3_39717249 -.->|"ε"|eNFA17_6_22653281
eNFA17_3_39717249 -.->|"ε"|eNFA17_4_22976439
eNFA17_3_39717249 -.->|"ε"|eNFA17_8_2552937
eNFA17_3_39717249 -.->|"ε"|eNFA17_7_5461363
eNFA17_3_39717249 -->|"[^*]"|eNFA17_5_62980604
eNFA17_3_39717249 -->|"[*]"|eNFA17_9_35179415
eNFA17_3_39717249 -.->|"ε"|eNFA17_12_21910925
eNFA17_3_39717249 -->|"*"|eNFA17_13_30960379
eNFA17_6_22653281 -.->|"ε"|eNFA17_4_22976439
eNFA17_6_22653281 -.->|"ε"|eNFA17_8_2552937
eNFA17_6_22653281 -.->|"ε"|eNFA17_7_5461363
eNFA17_6_22653281 -->|"[^*]"|eNFA17_5_62980604
eNFA17_6_22653281 -->|"[*]"|eNFA17_9_35179415
eNFA17_6_22653281 -.->|"ε"|eNFA17_6_22653281
eNFA17_6_22653281 -.->|"ε"|eNFA17_12_21910925
eNFA17_6_22653281 -->|"*"|eNFA17_13_30960379
eNFA17_4_22976439 -->|"[^*]"|eNFA17_5_62980604
eNFA17_8_2552937 -->|"[*]"|eNFA17_9_35179415
eNFA17_7_5461363 -.->|"ε"|eNFA17_6_22653281
eNFA17_7_5461363 -.->|"ε"|eNFA17_12_21910925
eNFA17_7_5461363 -.->|"ε"|eNFA17_4_22976439
eNFA17_7_5461363 -.->|"ε"|eNFA17_8_2552937
eNFA17_7_5461363 -.->|"ε"|eNFA17_7_5461363
eNFA17_7_5461363 -->|"[^*]"|eNFA17_5_62980604
eNFA17_7_5461363 -->|"[*]"|eNFA17_9_35179415
eNFA17_7_5461363 -->|"*"|eNFA17_13_30960379
eNFA17_5_62980604 -.->|"ε"|eNFA17_7_5461363
eNFA17_5_62980604 -.->|"ε"|eNFA17_6_22653281
eNFA17_5_62980604 -.->|"ε"|eNFA17_12_21910925
eNFA17_5_62980604 -.->|"ε"|eNFA17_4_22976439
eNFA17_5_62980604 -.->|"ε"|eNFA17_8_2552937
eNFA17_5_62980604 -->|"[^*]"|eNFA17_5_62980604
eNFA17_5_62980604 -->|"[*]"|eNFA17_9_35179415
eNFA17_5_62980604 -->|"*"|eNFA17_13_30960379
eNFA17_9_35179415 -.->|"ε"|eNFA17_10_48179284
eNFA17_9_35179415 -->|"[^/]"|eNFA17_11_26468439
eNFA17_12_21910925 -->|"*"|eNFA17_13_30960379
eNFA17_13_30960379 -.->|"ε"|eNFA17_14_10207955
eNFA17_13_30960379 -->|"/"|eNFA17_15_24762734
eNFA17_10_48179284 -->|"[^/]"|eNFA17_11_26468439
eNFA17_11_26468439 -.->|"ε"|eNFA17_7_5461363
eNFA17_11_26468439 -.->|"ε"|eNFA17_6_22653281
eNFA17_11_26468439 -.->|"ε"|eNFA17_12_21910925
eNFA17_11_26468439 -.->|"ε"|eNFA17_4_22976439
eNFA17_11_26468439 -.->|"ε"|eNFA17_8_2552937
eNFA17_11_26468439 -->|"[^*]"|eNFA17_5_62980604
eNFA17_11_26468439 -->|"[*]"|eNFA17_9_35179415
eNFA17_11_26468439 -->|"*"|eNFA17_13_30960379
eNFA17_14_10207955 -->|"/"|eNFA17_15_24762734
eNFA17_15_24762734 -.->|"ε"|eNFA17_17_21538022
eNFA17_15_24762734 -.->|"ε"|eNFA17_18_59624475
eNFA17_15_24762734 -.->|"ε"|eNFA17_19_66858230
eNFA17_17_21538022 -.->|"ε"|eNFA17_18_59624475
eNFA17_17_21538022 -.->|"ε"|eNFA17_19_66858230
eNFA17_18_59624475 -.->|"ε"|eNFA17_19_66858230
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
NFA17_16_14045344("NFA17-16 regex start")
NFA17_1_59299233("NFA17-1 char[1]")
NFA17_3_64853160("NFA17-3 char[1]")
NFA17_5_18614589("NFA17-5 scope[1]")
NFA17_9_46807530("NFA17-9 scope[1]")
NFA17_13_33313579("NFA17-13 char[1]")
NFA17_11_31386755("NFA17-11 scope[1]")
NFA17_15_63931057[\"NFA17-15 char[1]"/]
NFA17_16_14045344 -->|"/"|NFA17_1_59299233
NFA17_1_59299233 -->|"*"|NFA17_3_64853160
NFA17_3_64853160 -->|"[^*]"|NFA17_5_18614589
NFA17_3_64853160 -->|"[*]"|NFA17_9_46807530
NFA17_3_64853160 -->|"*"|NFA17_13_33313579
NFA17_5_18614589 -->|"[^*]"|NFA17_5_18614589
NFA17_5_18614589 -->|"[*]"|NFA17_9_46807530
NFA17_5_18614589 -->|"*"|NFA17_13_33313579
NFA17_9_46807530 -->|"[^/]"|NFA17_11_31386755
NFA17_13_33313579 -->|"/"|NFA17_15_63931057
NFA17_11_31386755 -->|"[^*]"|NFA17_5_18614589
NFA17_11_31386755 -->|"[*]"|NFA17_9_46807530
NFA17_11_31386755 -->|"*"|NFA17_13_33313579
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
subgraph DFA0_-1997653781["DFA0 regex start"]
NFA17_16_14045344_0("NFA17-16 regex start")
end
subgraph DFA1_1958102695["DFA1 {1}"]
NFA17_1_59299233_1("NFA17-1 char[1]")
end
subgraph DFA2_-201832823["DFA2 {1}"]
NFA17_3_64853160_2("NFA17-3 char[1]")
end
subgraph DFA3_1715098688["DFA3 {1}"]
NFA17_5_18614589_3("NFA17-5 scope[1]")
end
subgraph DFA4_-1058589499["DFA4 {2}"]
NFA17_9_46807530_4("NFA17-9 scope[1]")
NFA17_13_33313579_5("NFA17-13 char[1]")
end
subgraph DFA5_-58221208["DFA5 {1}"]
NFA17_11_31386755_6("NFA17-11 scope[1]")
end
subgraph DFA6_414337637["DFA6 {1}"]
NFA17_15_63931057_7[\"NFA17-15 char[1]"/]
end
DFA0_-1997653781 -->|"/"|DFA1_1958102695
DFA1_1958102695 -->|"*"|DFA2_-201832823
DFA2_-201832823 -->|"[^*]"|DFA3_1715098688
DFA2_-201832823 -->|"*"|DFA4_-1058589499
DFA3_1715098688 -->|"[^*]"|DFA3_1715098688
DFA3_1715098688 -->|"*"|DFA4_-1058589499
DFA4_-1058589499 -->|"[^/]"|DFA5_-58221208
DFA4_-1058589499 -->|"/"|DFA6_414337637
DFA5_-58221208 -->|"[^*]"|DFA3_1715098688
DFA5_-58221208 -->|"*"|DFA4_-1058589499
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
DFA0_-1997653781{{"DFA0 regex start"}}
DFA1_1958102695{{"DFA1 {1}"}}
DFA2_-201832823{{"DFA2 {1}"}}
DFA3_1715098688{{"DFA3 {1}"}}
DFA4_-1058589499{{"DFA4 {2}"}}
DFA5_-58221208{{"DFA5 {1}"}}
DFA6_414337637[\"DFA6 {1}"/]
DFA0_-1997653781 -->|"/"|DFA1_1958102695
DFA1_1958102695 -->|"*"|DFA2_-201832823
DFA2_-201832823 -->|"[^*]"|DFA3_1715098688
DFA2_-201832823 -->|"*"|DFA4_-1058589499
DFA3_1715098688 -->|"[^*]"|DFA3_1715098688
DFA3_1715098688 -->|"*"|DFA4_-1058589499
DFA4_-1058589499 -->|"[^/]"|DFA5_-58221208
DFA4_-1058589499 -->|"/"|DFA6_414337637
DFA5_-58221208 -->|"[^*]"|DFA3_1715098688
DFA5_-58221208 -->|"*"|DFA4_-1058589499
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
subgraph MiniDFA0_4953181["MiniDFA0 {1}"]
DFA0_-1997653781_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1237984235["MiniDFA1 {1}"]
DFA1_1958102695_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-910951964["MiniDFA2 {3}"]
DFA2_-201832823_2{{"DFA2 {1}"}}
DFA3_1715098688_3{{"DFA3 {1}"}}
DFA5_-58221208_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_11782534["MiniDFA3 {1}"]
DFA4_-1058589499_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-615605359["MiniDFA4 {1}"]
DFA6_414337637_6[\"DFA6 {1}"/]
end
MiniDFA0_4953181 -->|"/"|MiniDFA1_1237984235
MiniDFA1_1237984235 -->|"*"|MiniDFA2_-910951964
MiniDFA2_-910951964 -->|"[^*]"|MiniDFA2_-910951964
MiniDFA2_-910951964 -->|"*"|MiniDFA3_11782534
MiniDFA3_11782534 -->|"[^/]"|MiniDFA2_-910951964
MiniDFA3_11782534 -->|"/"|MiniDFA4_-615605359
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
MiniDFA0_4953181(["MiniDFA0 {1}"])
MiniDFA1_1237984235(["MiniDFA1 {1}"])
MiniDFA2_-910951964(["MiniDFA2 {3}"])
MiniDFA3_11782534(["MiniDFA3 {1}"])
MiniDFA4_-615605359[\"MiniDFA4 {1}"/]
MiniDFA0_4953181 -->|"/"|MiniDFA1_1237984235
MiniDFA1_1237984235 -->|"*"|MiniDFA2_-910951964
MiniDFA2_-910951964 -->|"[^*]"|MiniDFA2_-910951964
MiniDFA2_-910951964 -->|"*"|MiniDFA3_11782534
MiniDFA3_11782534 -->|"[^/]"|MiniDFA2_-910951964
MiniDFA3_11782534 -->|"/"|MiniDFA4_-615605359
```
-------------------------------
