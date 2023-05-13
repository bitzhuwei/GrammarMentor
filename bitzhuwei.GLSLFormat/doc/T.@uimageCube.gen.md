# 'uimageCube'

pattern: `uimageCube`

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
eNFA174_20_52290491[["εNFA174-20 regex start"]]
eNFA174_0_852373[["εNFA174-0 char{1, 1}"]]
eNFA174_1_7671360[["εNFA174-1 char[1]"]]
eNFA174_2_1933382[["εNFA174-2 char{1, 1}"]]
eNFA174_3_17400438[["εNFA174-3 char[1]"]]
eNFA174_4_22386219[["εNFA174-4 char{1, 1}"]]
eNFA174_5_149380[["εNFA174-5 char[1]"]]
eNFA174_6_1344428[["εNFA174-6 char{1, 1}"]]
eNFA174_7_12099859[["εNFA174-7 char[1]"]]
eNFA174_8_41789875[["εNFA174-8 char{1, 1}"]]
eNFA174_9_40564555[["εNFA174-9 char[1]"]]
eNFA174_10_29536677[["εNFA174-10 char{1, 1}"]]
eNFA174_11_64503507[["εNFA174-11 char[1]"]]
eNFA174_12_43660652[["εNFA174-12 char{1, 1}"]]
eNFA174_13_57401555[["εNFA174-13 char[1]"]]
eNFA174_14_46851952[["εNFA174-14 char{1, 1}"]]
eNFA174_15_19014388[["εNFA174-15 char[1]"]]
eNFA174_16_36911768[["εNFA174-16 char{1, 1}"]]
eNFA174_17_63770461[["εNFA174-17 char[1]"]]
eNFA174_18_37063245[["εNFA174-18 char{1, 1}"]]
eNFA174_19_65133751[["εNFA174-19 char[1]"]]
eNFA174_21_49332854[["εNFA174-21 regex end"]]
eNFA174_22_41342506[["εNFA174-22 post-regex start"]]
eNFA174_23_36538236[\"εNFA174-23 post-regex end"/]
eNFA174_20_52290491 -.->|"ε"|eNFA174_0_852373
eNFA174_0_852373 -->|"u"|eNFA174_1_7671360
eNFA174_1_7671360 -.->|"ε"|eNFA174_2_1933382
eNFA174_2_1933382 -->|"i"|eNFA174_3_17400438
eNFA174_3_17400438 -.->|"ε"|eNFA174_4_22386219
eNFA174_4_22386219 -->|"m"|eNFA174_5_149380
eNFA174_5_149380 -.->|"ε"|eNFA174_6_1344428
eNFA174_6_1344428 -->|"a"|eNFA174_7_12099859
eNFA174_7_12099859 -.->|"ε"|eNFA174_8_41789875
eNFA174_8_41789875 -->|"g"|eNFA174_9_40564555
eNFA174_9_40564555 -.->|"ε"|eNFA174_10_29536677
eNFA174_10_29536677 -->|"e"|eNFA174_11_64503507
eNFA174_11_64503507 -.->|"ε"|eNFA174_12_43660652
eNFA174_12_43660652 -->|"C"|eNFA174_13_57401555
eNFA174_13_57401555 -.->|"ε"|eNFA174_14_46851952
eNFA174_14_46851952 -->|"u"|eNFA174_15_19014388
eNFA174_15_19014388 -.->|"ε"|eNFA174_16_36911768
eNFA174_16_36911768 -->|"b"|eNFA174_17_63770461
eNFA174_17_63770461 -.->|"ε"|eNFA174_18_37063245
eNFA174_18_37063245 -->|"e"|eNFA174_19_65133751
eNFA174_19_65133751 -.->|"ε"|eNFA174_21_49332854
eNFA174_21_49332854 -.->|"ε"|eNFA174_22_41342506
eNFA174_22_41342506 -.->|"ε"|eNFA174_23_36538236
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
eNFA174_20_60408669[["εNFA174-20 regex start"]]
eNFA174_0_6807110[["εNFA174-0 char{1, 1}"]]
eNFA174_1_61263992[["εNFA174-1 char[1]"]]
eNFA174_2_14505020[["εNFA174-2 char{1, 1}"]]
eNFA174_3_63436324[["εNFA174-3 char[1]"]]
eNFA174_4_34056008[["εNFA174-4 char{1, 1}"]]
eNFA174_5_38068616[["εNFA174-5 char[1]"]]
eNFA174_6_7073231[["εNFA174-6 char{1, 1}"]]
eNFA174_7_63659085[["εNFA174-7 char[1]"]]
eNFA174_8_36060859[["εNFA174-8 char{1, 1}"]]
eNFA174_9_56112283[["εNFA174-9 char[1]"]]
eNFA174_10_35248500[["εNFA174-10 char{1, 1}"]]
eNFA174_11_48801049[["εNFA174-11 char[1]"]]
eNFA174_12_36556257[["εNFA174-12 char{1, 1}"]]
eNFA174_13_60570863[["εNFA174-13 char[1]"]]
eNFA174_14_8266859[["εNFA174-14 char{1, 1}"]]
eNFA174_15_7292870[["εNFA174-15 char[1]"]]
eNFA174_16_65635833[["εNFA174-16 char{1, 1}"]]
eNFA174_17_53851589[["εNFA174-17 char[1]"]]
eNFA174_18_14902260[["εNFA174-18 char{1, 1}"]]
eNFA174_19_67011477[\"εNFA174-19 char[1]"/]
eNFA174_21_66232387[\"εNFA174-21 regex end"/]
eNFA174_22_59220574[\"εNFA174-22 post-regex start"/]
eNFA174_23_63223119[\"εNFA174-23 post-regex end"/]
eNFA174_20_60408669 -.->|"ε"|eNFA174_0_6807110
eNFA174_20_60408669 -->|"u"|eNFA174_1_61263992
eNFA174_0_6807110 -->|"u"|eNFA174_1_61263992
eNFA174_1_61263992 -.->|"ε"|eNFA174_2_14505020
eNFA174_1_61263992 -->|"i"|eNFA174_3_63436324
eNFA174_2_14505020 -->|"i"|eNFA174_3_63436324
eNFA174_3_63436324 -.->|"ε"|eNFA174_4_34056008
eNFA174_3_63436324 -->|"m"|eNFA174_5_38068616
eNFA174_4_34056008 -->|"m"|eNFA174_5_38068616
eNFA174_5_38068616 -.->|"ε"|eNFA174_6_7073231
eNFA174_5_38068616 -->|"a"|eNFA174_7_63659085
eNFA174_6_7073231 -->|"a"|eNFA174_7_63659085
eNFA174_7_63659085 -.->|"ε"|eNFA174_8_36060859
eNFA174_7_63659085 -->|"g"|eNFA174_9_56112283
eNFA174_8_36060859 -->|"g"|eNFA174_9_56112283
eNFA174_9_56112283 -.->|"ε"|eNFA174_10_35248500
eNFA174_9_56112283 -->|"e"|eNFA174_11_48801049
eNFA174_10_35248500 -->|"e"|eNFA174_11_48801049
eNFA174_11_48801049 -.->|"ε"|eNFA174_12_36556257
eNFA174_11_48801049 -->|"C"|eNFA174_13_60570863
eNFA174_12_36556257 -->|"C"|eNFA174_13_60570863
eNFA174_13_60570863 -.->|"ε"|eNFA174_14_8266859
eNFA174_13_60570863 -->|"u"|eNFA174_15_7292870
eNFA174_14_8266859 -->|"u"|eNFA174_15_7292870
eNFA174_15_7292870 -.->|"ε"|eNFA174_16_65635833
eNFA174_15_7292870 -->|"b"|eNFA174_17_53851589
eNFA174_16_65635833 -->|"b"|eNFA174_17_53851589
eNFA174_17_53851589 -.->|"ε"|eNFA174_18_14902260
eNFA174_17_53851589 -->|"e"|eNFA174_19_67011477
eNFA174_18_14902260 -->|"e"|eNFA174_19_67011477
eNFA174_19_67011477 -.->|"ε"|eNFA174_21_66232387
eNFA174_19_67011477 -.->|"ε"|eNFA174_22_59220574
eNFA174_19_67011477 -.->|"ε"|eNFA174_23_63223119
eNFA174_21_66232387 -.->|"ε"|eNFA174_22_59220574
eNFA174_21_66232387 -.->|"ε"|eNFA174_23_63223119
eNFA174_22_59220574 -.->|"ε"|eNFA174_23_63223119
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
NFA174_20_32137159("NFA174-20 regex start")
NFA174_1_20798975("NFA174-1 char[1]")
NFA174_3_52973048("NFA174-3 char[1]")
NFA174_5_6995387("NFA174-5 char[1]")
NFA174_7_62958490("NFA174-7 char[1]")
NFA174_9_29755500("NFA174-9 char[1]")
NFA174_11_66472916("NFA174-11 char[1]")
NFA174_13_61385338("NFA174-13 char[1]")
NFA174_15_15597135("NFA174-15 char[1]")
NFA174_17_6156492("NFA174-17 char[1]")
NFA174_19_55408435[\"NFA174-19 char[1]"/]
NFA174_20_32137159 -->|"u"|NFA174_1_20798975
NFA174_1_20798975 -->|"i"|NFA174_3_52973048
NFA174_3_52973048 -->|"m"|NFA174_5_6995387
NFA174_5_6995387 -->|"a"|NFA174_7_62958490
NFA174_7_62958490 -->|"g"|NFA174_9_29755500
NFA174_9_29755500 -->|"e"|NFA174_11_66472916
NFA174_11_66472916 -->|"C"|NFA174_13_61385338
NFA174_13_61385338 -->|"u"|NFA174_15_15597135
NFA174_15_15597135 -->|"b"|NFA174_17_6156492
NFA174_17_6156492 -->|"e"|NFA174_19_55408435
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
subgraph DFA0_-513300422["DFA0 regex start"]
NFA174_20_32137159_0("NFA174-20 regex start")
end
subgraph DFA1_1298468235["DFA1 {1}"]
NFA174_1_20798975_1("NFA174-1 char[1]")
end
subgraph DFA2_-579256985["DFA2 {1}"]
NFA174_3_52973048_2("NFA174-3 char[1]")
end
subgraph DFA3_-1342047808["DFA3 {1}"]
NFA174_5_6995387_3("NFA174-5 char[1]")
end
subgraph DFA4_127410825["DFA4 {1}"]
NFA174_7_62958490_4("NFA174-7 char[1]")
end
subgraph DFA5_-112390745["DFA5 {1}"]
NFA174_9_29755500_5("NFA174-9 char[1]")
end
subgraph DFA6_424097490["DFA6 {1}"]
NFA174_11_66472916_6("NFA174-11 char[1]")
end
subgraph DFA7_407881303["DFA7 {1}"]
NFA174_13_61385338_7("NFA174-13 char[1]")
end
subgraph DFA8_431099445["DFA8 {1}"]
NFA174_15_15597135_8("NFA174-15 char[1]")
end
subgraph DFA9_-133246954["DFA9 {1}"]
NFA174_17_6156492_9("NFA174-17 char[1]")
end
subgraph DFA10_873152906["DFA10 {1}"]
NFA174_19_55408435_10[\"NFA174-19 char[1]"/]
end
DFA0_-513300422 -->|"u"|DFA1_1298468235
DFA1_1298468235 -->|"i"|DFA2_-579256985
DFA2_-579256985 -->|"m"|DFA3_-1342047808
DFA3_-1342047808 -->|"a"|DFA4_127410825
DFA4_127410825 -->|"g"|DFA5_-112390745
DFA5_-112390745 -->|"e"|DFA6_424097490
DFA6_424097490 -->|"C"|DFA7_407881303
DFA7_407881303 -->|"u"|DFA8_431099445
DFA8_431099445 -->|"b"|DFA9_-133246954
DFA9_-133246954 -->|"e"|DFA10_873152906
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
DFA0_-513300422{{"DFA0 regex start"}}
DFA1_1298468235{{"DFA1 {1}"}}
DFA2_-579256985{{"DFA2 {1}"}}
DFA3_-1342047808{{"DFA3 {1}"}}
DFA4_127410825{{"DFA4 {1}"}}
DFA5_-112390745{{"DFA5 {1}"}}
DFA6_424097490{{"DFA6 {1}"}}
DFA7_407881303{{"DFA7 {1}"}}
DFA8_431099445{{"DFA8 {1}"}}
DFA9_-133246954{{"DFA9 {1}"}}
DFA10_873152906[\"DFA10 {1}"/]
DFA0_-513300422 -->|"u"|DFA1_1298468235
DFA1_1298468235 -->|"i"|DFA2_-579256985
DFA2_-579256985 -->|"m"|DFA3_-1342047808
DFA3_-1342047808 -->|"a"|DFA4_127410825
DFA4_127410825 -->|"g"|DFA5_-112390745
DFA5_-112390745 -->|"e"|DFA6_424097490
DFA6_424097490 -->|"C"|DFA7_407881303
DFA7_407881303 -->|"u"|DFA8_431099445
DFA8_431099445 -->|"b"|DFA9_-133246954
DFA9_-133246954 -->|"e"|DFA10_873152906
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
subgraph MiniDFA0_-1430128032["MiniDFA0 {1}"]
DFA0_-513300422_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_870770426["MiniDFA2 {1}"]
DFA1_1298468235_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-852793766["MiniDFA3 {1}"]
DFA2_-579256985_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_269131082["MiniDFA4 {1}"]
DFA3_-1342047808_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1630001182["MiniDFA5 {1}"]
DFA4_127410825_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-2046113907["MiniDFA6 {1}"]
DFA5_-112390745_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1165573867["MiniDFA7 {1}"]
DFA6_424097490_6{{"DFA6 {1}"}}
end
subgraph MiniDFA1_1789516109["MiniDFA1 {1}"]
DFA7_407881303_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-913244326["MiniDFA8 {1}"]
DFA8_431099445_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_585506991["MiniDFA9 {1}"]
DFA9_-133246954_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_351484659["MiniDFA10 {1}"]
DFA10_873152906_10[\"DFA10 {1}"/]
end
MiniDFA0_-1430128032 -->|"u"|MiniDFA2_870770426
MiniDFA2_870770426 -->|"i"|MiniDFA3_-852793766
MiniDFA3_-852793766 -->|"m"|MiniDFA4_269131082
MiniDFA4_269131082 -->|"a"|MiniDFA5_-1630001182
MiniDFA5_-1630001182 -->|"g"|MiniDFA6_-2046113907
MiniDFA6_-2046113907 -->|"e"|MiniDFA7_1165573867
MiniDFA7_1165573867 -->|"C"|MiniDFA1_1789516109
MiniDFA1_1789516109 -->|"u"|MiniDFA8_-913244326
MiniDFA8_-913244326 -->|"b"|MiniDFA9_585506991
MiniDFA9_585506991 -->|"e"|MiniDFA10_351484659
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
MiniDFA0_-1430128032(["MiniDFA0 {1}"])
MiniDFA2_870770426(["MiniDFA2 {1}"])
MiniDFA3_-852793766(["MiniDFA3 {1}"])
MiniDFA4_269131082(["MiniDFA4 {1}"])
MiniDFA5_-1630001182(["MiniDFA5 {1}"])
MiniDFA6_-2046113907(["MiniDFA6 {1}"])
MiniDFA7_1165573867(["MiniDFA7 {1}"])
MiniDFA1_1789516109(["MiniDFA1 {1}"])
MiniDFA8_-913244326(["MiniDFA8 {1}"])
MiniDFA9_585506991(["MiniDFA9 {1}"])
MiniDFA10_351484659[\"MiniDFA10 {1}"/]
MiniDFA0_-1430128032 -->|"u"|MiniDFA2_870770426
MiniDFA2_870770426 -->|"i"|MiniDFA3_-852793766
MiniDFA3_-852793766 -->|"m"|MiniDFA4_269131082
MiniDFA4_269131082 -->|"a"|MiniDFA5_-1630001182
MiniDFA5_-1630001182 -->|"g"|MiniDFA6_-2046113907
MiniDFA6_-2046113907 -->|"e"|MiniDFA7_1165573867
MiniDFA7_1165573867 -->|"C"|MiniDFA1_1789516109
MiniDFA1_1789516109 -->|"u"|MiniDFA8_-913244326
MiniDFA8_-913244326 -->|"b"|MiniDFA9_585506991
MiniDFA9_585506991 -->|"e"|MiniDFA10_351484659
```
-------------------------------
