# 'dmat2x4'

pattern: `dmat2x4`

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
eNFA112_14_52271033[["εNFA112-14 regex start"]]
eNFA112_0_677253[["εNFA112-0 char{1, 1}"]]
eNFA112_1_6095280[["εNFA112-1 char[1]"]]
eNFA112_2_54857523[["εNFA112-2 char{1, 1}"]]
eNFA112_3_23955663[["εNFA112-3 char[1]"]]
eNFA112_4_14274382[["εNFA112-4 char{1, 1}"]]
eNFA112_5_61360575[["εNFA112-5 char[1]"]]
eNFA112_6_15374269[["εNFA112-6 char{1, 1}"]]
eNFA112_7_4150696[["εNFA112-7 char[1]"]]
eNFA112_8_37356265[["εNFA112-8 char{1, 1}"]]
eNFA112_9_662065[["εNFA112-9 char[1]"]]
eNFA112_10_5958585[["εNFA112-10 char{1, 1}"]]
eNFA112_11_53627266[["εNFA112-11 char[1]"]]
eNFA112_12_12883349[["εNFA112-12 char{1, 1}"]]
eNFA112_13_48841284[["εNFA112-13 char[1]"]]
eNFA112_15_36918374[["εNFA112-15 regex end"]]
eNFA112_16_63829918[["εNFA112-16 post-regex start"]]
eNFA112_17_37598356[\"εNFA112-17 post-regex end"/]
eNFA112_14_52271033 -.->|"ε"|eNFA112_0_677253
eNFA112_0_677253 -->|"d"|eNFA112_1_6095280
eNFA112_1_6095280 -.->|"ε"|eNFA112_2_54857523
eNFA112_2_54857523 -->|"m"|eNFA112_3_23955663
eNFA112_3_23955663 -.->|"ε"|eNFA112_4_14274382
eNFA112_4_14274382 -->|"a"|eNFA112_5_61360575
eNFA112_5_61360575 -.->|"ε"|eNFA112_6_15374269
eNFA112_6_15374269 -->|"t"|eNFA112_7_4150696
eNFA112_7_4150696 -.->|"ε"|eNFA112_8_37356265
eNFA112_8_37356265 -->|"2"|eNFA112_9_662065
eNFA112_9_662065 -.->|"ε"|eNFA112_10_5958585
eNFA112_10_5958585 -->|"x"|eNFA112_11_53627266
eNFA112_11_53627266 -.->|"ε"|eNFA112_12_12883349
eNFA112_12_12883349 -->|"4"|eNFA112_13_48841284
eNFA112_13_48841284 -.->|"ε"|eNFA112_15_36918374
eNFA112_15_36918374 -.->|"ε"|eNFA112_16_63829918
eNFA112_16_63829918 -.->|"ε"|eNFA112_17_37598356
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
eNFA112_14_2840889[["εNFA112-14 regex start"]]
eNFA112_0_25568006[["εNFA112-0 char{1, 1}"]]
eNFA112_1_28785469[["εNFA112-1 char[1]"]]
eNFA112_2_57742629[["εNFA112-2 char{1, 1}"]]
eNFA112_3_49921616[["εNFA112-3 char[1]"]]
eNFA112_4_46641368[["εNFA112-4 char{1, 1}"]]
eNFA112_5_17119133[["εNFA112-5 char[1]"]]
eNFA112_6_19854472[["εNFA112-6 char{1, 1}"]]
eNFA112_7_44472522[["εNFA112-7 char[1]"]]
eNFA112_8_64708380[["εNFA112-8 char{1, 1}"]]
eNFA112_9_45504511[["εNFA112-9 char[1]"]]
eNFA112_10_6887421[["εNFA112-10 char{1, 1}"]]
eNFA112_11_61986789[["εNFA112-11 char[1]"]]
eNFA112_12_21010194[["εNFA112-12 char{1, 1}"]]
eNFA112_13_54874019[\"εNFA112-13 char[1]"/]
eNFA112_15_24104131[\"εNFA112-15 regex end"/]
eNFA112_16_15610594[\"εNFA112-16 post-regex start"/]
eNFA112_17_6277626[\"εNFA112-17 post-regex end"/]
eNFA112_14_2840889 -.->|"ε"|eNFA112_0_25568006
eNFA112_14_2840889 -->|"d"|eNFA112_1_28785469
eNFA112_0_25568006 -->|"d"|eNFA112_1_28785469
eNFA112_1_28785469 -.->|"ε"|eNFA112_2_57742629
eNFA112_1_28785469 -->|"m"|eNFA112_3_49921616
eNFA112_2_57742629 -->|"m"|eNFA112_3_49921616
eNFA112_3_49921616 -.->|"ε"|eNFA112_4_46641368
eNFA112_3_49921616 -->|"a"|eNFA112_5_17119133
eNFA112_4_46641368 -->|"a"|eNFA112_5_17119133
eNFA112_5_17119133 -.->|"ε"|eNFA112_6_19854472
eNFA112_5_17119133 -->|"t"|eNFA112_7_44472522
eNFA112_6_19854472 -->|"t"|eNFA112_7_44472522
eNFA112_7_44472522 -.->|"ε"|eNFA112_8_64708380
eNFA112_7_44472522 -->|"2"|eNFA112_9_45504511
eNFA112_8_64708380 -->|"2"|eNFA112_9_45504511
eNFA112_9_45504511 -.->|"ε"|eNFA112_10_6887421
eNFA112_9_45504511 -->|"x"|eNFA112_11_61986789
eNFA112_10_6887421 -->|"x"|eNFA112_11_61986789
eNFA112_11_61986789 -.->|"ε"|eNFA112_12_21010194
eNFA112_11_61986789 -->|"4"|eNFA112_13_54874019
eNFA112_12_21010194 -->|"4"|eNFA112_13_54874019
eNFA112_13_54874019 -.->|"ε"|eNFA112_15_24104131
eNFA112_13_54874019 -.->|"ε"|eNFA112_16_15610594
eNFA112_13_54874019 -.->|"ε"|eNFA112_17_6277626
eNFA112_15_24104131 -.->|"ε"|eNFA112_16_15610594
eNFA112_15_24104131 -.->|"ε"|eNFA112_17_6277626
eNFA112_16_15610594 -.->|"ε"|eNFA112_17_6277626
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
NFA112_14_56498634("NFA112-14 regex start")
NFA112_1_38725660("NFA112-1 char[1]")
NFA112_3_12986626("NFA112-3 char[1]")
NFA112_5_49770771("NFA112-5 char[1]")
NFA112_7_45283762("NFA112-7 char[1]")
NFA112_9_4900679("NFA112-9 char[1]")
NFA112_11_44106115("NFA112-11 char[1]")
NFA112_13_61410719[\"NFA112-13 char[1]"/]
NFA112_14_56498634 -->|"d"|NFA112_1_38725660
NFA112_1_38725660 -->|"m"|NFA112_3_12986626
NFA112_3_12986626 -->|"a"|NFA112_5_49770771
NFA112_5_49770771 -->|"t"|NFA112_7_45283762
NFA112_7_45283762 -->|"2"|NFA112_9_4900679
NFA112_9_4900679 -->|"x"|NFA112_11_44106115
NFA112_11_44106115 -->|"4"|NFA112_13_61410719
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
subgraph DFA0_-955827553["DFA0 regex start"]
NFA112_14_56498634_0("NFA112-14 regex start")
end
subgraph DFA1_-878577700["DFA1 {1}"]
NFA112_1_38725660_1("NFA112-1 char[1]")
end
subgraph DFA2_-1487904156["DFA2 {1}"]
NFA112_3_12986626_2("NFA112-3 char[1]")
end
subgraph DFA3_-997115058["DFA3 {1}"]
NFA112_5_49770771_3("NFA112-5 char[1]")
end
subgraph DFA4_-186977820["DFA4 {1}"]
NFA112_7_45283762_4("NFA112-7 char[1]")
end
subgraph DFA5_460794370["DFA5 {1}"]
NFA112_9_4900679_5("NFA112-9 char[1]")
end
subgraph DFA6_-1295050751["DFA6 {1}"]
NFA112_11_44106115_6("NFA112-11 char[1]")
end
subgraph DFA7_836058681["DFA7 {1}"]
NFA112_13_61410719_7[\"NFA112-13 char[1]"/]
end
DFA0_-955827553 -->|"d"|DFA1_-878577700
DFA1_-878577700 -->|"m"|DFA2_-1487904156
DFA2_-1487904156 -->|"a"|DFA3_-997115058
DFA3_-997115058 -->|"t"|DFA4_-186977820
DFA4_-186977820 -->|"2"|DFA5_460794370
DFA5_460794370 -->|"x"|DFA6_-1295050751
DFA6_-1295050751 -->|"4"|DFA7_836058681
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
DFA0_-955827553{{"DFA0 regex start"}}
DFA1_-878577700{{"DFA1 {1}"}}
DFA2_-1487904156{{"DFA2 {1}"}}
DFA3_-997115058{{"DFA3 {1}"}}
DFA4_-186977820{{"DFA4 {1}"}}
DFA5_460794370{{"DFA5 {1}"}}
DFA6_-1295050751{{"DFA6 {1}"}}
DFA7_836058681[\"DFA7 {1}"/]
DFA0_-955827553 -->|"d"|DFA1_-878577700
DFA1_-878577700 -->|"m"|DFA2_-1487904156
DFA2_-1487904156 -->|"a"|DFA3_-997115058
DFA3_-997115058 -->|"t"|DFA4_-186977820
DFA4_-186977820 -->|"2"|DFA5_460794370
DFA5_460794370 -->|"x"|DFA6_-1295050751
DFA6_-1295050751 -->|"4"|DFA7_836058681
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
subgraph MiniDFA0_-796829702["MiniDFA0 {1}"]
DFA0_-955827553_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_211725533["MiniDFA1 {1}"]
DFA1_-878577700_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-905702271["MiniDFA2 {1}"]
DFA2_-1487904156_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1259081860["MiniDFA3 {1}"]
DFA3_-997115058_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1097131361["MiniDFA4 {1}"]
DFA4_-186977820_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1442129076["MiniDFA5 {1}"]
DFA5_460794370_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-171869721["MiniDFA6 {1}"]
DFA6_-1295050751_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_875003613["MiniDFA7 {1}"]
DFA7_836058681_7[\"DFA7 {1}"/]
end
MiniDFA0_-796829702 -->|"d"|MiniDFA1_211725533
MiniDFA1_211725533 -->|"m"|MiniDFA2_-905702271
MiniDFA2_-905702271 -->|"a"|MiniDFA3_-1259081860
MiniDFA3_-1259081860 -->|"t"|MiniDFA4_1097131361
MiniDFA4_1097131361 -->|"2"|MiniDFA5_-1442129076
MiniDFA5_-1442129076 -->|"x"|MiniDFA6_-171869721
MiniDFA6_-171869721 -->|"4"|MiniDFA7_875003613
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
MiniDFA0_-796829702(["MiniDFA0 {1}"])
MiniDFA1_211725533(["MiniDFA1 {1}"])
MiniDFA2_-905702271(["MiniDFA2 {1}"])
MiniDFA3_-1259081860(["MiniDFA3 {1}"])
MiniDFA4_1097131361(["MiniDFA4 {1}"])
MiniDFA5_-1442129076(["MiniDFA5 {1}"])
MiniDFA6_-171869721(["MiniDFA6 {1}"])
MiniDFA7_875003613[\"MiniDFA7 {1}"/]
MiniDFA0_-796829702 -->|"d"|MiniDFA1_211725533
MiniDFA1_211725533 -->|"m"|MiniDFA2_-905702271
MiniDFA2_-905702271 -->|"a"|MiniDFA3_-1259081860
MiniDFA3_-1259081860 -->|"t"|MiniDFA4_1097131361
MiniDFA4_1097131361 -->|"2"|MiniDFA5_-1442129076
MiniDFA5_-1442129076 -->|"x"|MiniDFA6_-171869721
MiniDFA6_-171869721 -->|"4"|MiniDFA7_875003613
```
-------------------------------
