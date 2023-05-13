# 'image2DMS'

pattern: `image2DMS`

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
eNFA187_18_30528233[["εNFA187-18 regex start"]]
eNFA187_0_6318648[["εNFA187-0 char{1, 1}"]]
eNFA187_1_56867833[["εNFA187-1 char[1]"]]
eNFA187_2_42048455[["εNFA187-2 char{1, 1}"]]
eNFA187_3_42891778[["εNFA187-3 char[1]"]]
eNFA187_4_50481683[["εNFA187-4 char{1, 1}"]]
eNFA187_5_51681963[["εNFA187-5 char[1]"]]
eNFA187_6_62484483[["εNFA187-6 char{1, 1}"]]
eNFA187_7_25489436[["εNFA187-7 char[1]"]]
eNFA187_8_28078335[["εNFA187-8 char{1, 1}"]]
eNFA187_9_51378430[["εNFA187-9 char[1]"]]
eNFA187_10_59752688[["εNFA187-10 char{1, 1}"]]
eNFA187_11_903288[["εNFA187-11 char[1]"]]
eNFA187_12_8129598[["εNFA187-12 char{1, 1}"]]
eNFA187_13_6057523[["εNFA187-13 char[1]"]]
eNFA187_14_54517712[["εNFA187-14 char{1, 1}"]]
eNFA187_15_20897367[["εNFA187-15 char[1]"]]
eNFA187_16_53858575[["εNFA187-16 char{1, 1}"]]
eNFA187_17_14965130[["εNFA187-17 char[1]"]]
eNFA187_19_468450[["εNFA187-19 regex end"]]
eNFA187_20_4216055[["εNFA187-20 post-regex start"]]
eNFA187_21_37944498[\"εNFA187-21 post-regex end"/]
eNFA187_18_30528233 -.->|"ε"|eNFA187_0_6318648
eNFA187_0_6318648 -->|"i"|eNFA187_1_56867833
eNFA187_1_56867833 -.->|"ε"|eNFA187_2_42048455
eNFA187_2_42048455 -->|"m"|eNFA187_3_42891778
eNFA187_3_42891778 -.->|"ε"|eNFA187_4_50481683
eNFA187_4_50481683 -->|"a"|eNFA187_5_51681963
eNFA187_5_51681963 -.->|"ε"|eNFA187_6_62484483
eNFA187_6_62484483 -->|"g"|eNFA187_7_25489436
eNFA187_7_25489436 -.->|"ε"|eNFA187_8_28078335
eNFA187_8_28078335 -->|"e"|eNFA187_9_51378430
eNFA187_9_51378430 -.->|"ε"|eNFA187_10_59752688
eNFA187_10_59752688 -->|"2"|eNFA187_11_903288
eNFA187_11_903288 -.->|"ε"|eNFA187_12_8129598
eNFA187_12_8129598 -->|"D"|eNFA187_13_6057523
eNFA187_13_6057523 -.->|"ε"|eNFA187_14_54517712
eNFA187_14_54517712 -->|"M"|eNFA187_15_20897367
eNFA187_15_20897367 -.->|"ε"|eNFA187_16_53858575
eNFA187_16_53858575 -->|"S"|eNFA187_17_14965130
eNFA187_17_14965130 -.->|"ε"|eNFA187_19_468450
eNFA187_19_468450 -.->|"ε"|eNFA187_20_4216055
eNFA187_20_4216055 -.->|"ε"|eNFA187_21_37944498
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
eNFA187_18_5956164[["εNFA187-18 regex start"]]
eNFA187_0_53605478[["εNFA187-0 char{1, 1}"]]
eNFA187_1_12687257[["εNFA187-1 char[1]"]]
eNFA187_2_47076455[["εNFA187-2 char{1, 1}"]]
eNFA187_3_21034911[["εNFA187-3 char[1]"]]
eNFA187_4_55096476[["εNFA187-4 char{1, 1}"]]
eNFA187_5_26106237[["εNFA187-5 char[1]"]]
eNFA187_6_33629549[["εNFA187-6 char{1, 1}"]]
eNFA187_7_34230492[["εNFA187-7 char[1]"]]
eNFA187_8_39638980[["εNFA187-8 char{1, 1}"]]
eNFA187_9_21206500[["εNFA187-9 char[1]"]]
eNFA187_10_56640774[["εNFA187-10 char{1, 1}"]]
eNFA187_11_40004924[["εNFA187-11 char[1]"]]
eNFA187_12_24499997[["εNFA187-12 char{1, 1}"]]
eNFA187_13_19173388[["εNFA187-13 char[1]"]]
eNFA187_14_38342769[["εNFA187-14 char{1, 1}"]]
eNFA187_15_9540605[["εNFA187-15 char[1]"]]
eNFA187_16_18756585[["εNFA187-16 char{1, 1}"]]
eNFA187_17_34591542[\"εNFA187-17 char[1]"/]
eNFA187_19_42888430[\"εNFA187-19 regex end"/]
eNFA187_20_50451552[\"εNFA187-20 post-regex start"/]
eNFA187_21_51410791[\"εNFA187-21 post-regex end"/]
eNFA187_18_5956164 -.->|"ε"|eNFA187_0_53605478
eNFA187_18_5956164 -->|"i"|eNFA187_1_12687257
eNFA187_0_53605478 -->|"i"|eNFA187_1_12687257
eNFA187_1_12687257 -.->|"ε"|eNFA187_2_47076455
eNFA187_1_12687257 -->|"m"|eNFA187_3_21034911
eNFA187_2_47076455 -->|"m"|eNFA187_3_21034911
eNFA187_3_21034911 -.->|"ε"|eNFA187_4_55096476
eNFA187_3_21034911 -->|"a"|eNFA187_5_26106237
eNFA187_4_55096476 -->|"a"|eNFA187_5_26106237
eNFA187_5_26106237 -.->|"ε"|eNFA187_6_33629549
eNFA187_5_26106237 -->|"g"|eNFA187_7_34230492
eNFA187_6_33629549 -->|"g"|eNFA187_7_34230492
eNFA187_7_34230492 -.->|"ε"|eNFA187_8_39638980
eNFA187_7_34230492 -->|"e"|eNFA187_9_21206500
eNFA187_8_39638980 -->|"e"|eNFA187_9_21206500
eNFA187_9_21206500 -.->|"ε"|eNFA187_10_56640774
eNFA187_9_21206500 -->|"2"|eNFA187_11_40004924
eNFA187_10_56640774 -->|"2"|eNFA187_11_40004924
eNFA187_11_40004924 -.->|"ε"|eNFA187_12_24499997
eNFA187_11_40004924 -->|"D"|eNFA187_13_19173388
eNFA187_12_24499997 -->|"D"|eNFA187_13_19173388
eNFA187_13_19173388 -.->|"ε"|eNFA187_14_38342769
eNFA187_13_19173388 -->|"M"|eNFA187_15_9540605
eNFA187_14_38342769 -->|"M"|eNFA187_15_9540605
eNFA187_15_9540605 -.->|"ε"|eNFA187_16_18756585
eNFA187_15_9540605 -->|"S"|eNFA187_17_34591542
eNFA187_16_18756585 -->|"S"|eNFA187_17_34591542
eNFA187_17_34591542 -.->|"ε"|eNFA187_19_42888430
eNFA187_17_34591542 -.->|"ε"|eNFA187_20_50451552
eNFA187_17_34591542 -.->|"ε"|eNFA187_21_51410791
eNFA187_19_42888430 -.->|"ε"|eNFA187_20_50451552
eNFA187_19_42888430 -.->|"ε"|eNFA187_21_51410791
eNFA187_20_50451552 -.->|"ε"|eNFA187_21_51410791
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
NFA187_18_60043939("NFA187-18 regex start")
NFA187_1_3524541("NFA187-1 char[1]")
NFA187_3_31720870("NFA187-3 char[1]")
NFA187_5_17052375("NFA187-5 char[1]")
NFA187_7_19253649("NFA187-7 char[1]")
NFA187_9_39065117("NFA187-9 char[1]")
NFA187_11_16041741("NFA187-11 char[1]")
NFA187_13_10157945("NFA187-13 char[1]")
NFA187_15_24312641("NFA187-15 char[1]")
NFA187_17_17487184[\"NFA187-17 char[1]"/]
NFA187_18_60043939 -->|"i"|NFA187_1_3524541
NFA187_1_3524541 -->|"m"|NFA187_3_31720870
NFA187_3_31720870 -->|"a"|NFA187_5_17052375
NFA187_5_17052375 -->|"g"|NFA187_7_19253649
NFA187_7_19253649 -->|"e"|NFA187_9_39065117
NFA187_9_39065117 -->|"2"|NFA187_11_16041741
NFA187_11_16041741 -->|"D"|NFA187_13_10157945
NFA187_13_10157945 -->|"M"|NFA187_15_24312641
NFA187_15_24312641 -->|"S"|NFA187_17_17487184
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
subgraph DFA0_-815862297["DFA0 regex start"]
NFA187_18_60043939_0("NFA187-18 regex start")
end
subgraph DFA1_332110345["DFA1 {1}"]
NFA187_1_3524541_1("NFA187-1 char[1]")
end
subgraph DFA2_1558393290["DFA2 {1}"]
NFA187_3_31720870_2("NFA187-3 char[1]")
end
subgraph DFA3_-327039984["DFA3 {1}"]
NFA187_5_17052375_3("NFA187-5 char[1]")
end
subgraph DFA4_1866429966["DFA4 {1}"]
NFA187_7_19253649_4("NFA187-7 char[1]")
end
subgraph DFA5_-1220080796["DFA5 {1}"]
NFA187_9_39065117_5("NFA187-9 char[1]")
end
subgraph DFA6_-339705164["DFA6 {1}"]
NFA187_11_16041741_6("NFA187-11 char[1]")
end
subgraph DFA7_1966195189["DFA7 {1}"]
NFA187_13_10157945_7("NFA187-13 char[1]")
end
subgraph DFA8_-86002087["DFA8 {1}"]
NFA187_15_24312641_8("NFA187-15 char[1]")
end
subgraph DFA9_1271986237["DFA9 {1}"]
NFA187_17_17487184_9[\"NFA187-17 char[1]"/]
end
DFA0_-815862297 -->|"i"|DFA1_332110345
DFA1_332110345 -->|"m"|DFA2_1558393290
DFA2_1558393290 -->|"a"|DFA3_-327039984
DFA3_-327039984 -->|"g"|DFA4_1866429966
DFA4_1866429966 -->|"e"|DFA5_-1220080796
DFA5_-1220080796 -->|"2"|DFA6_-339705164
DFA6_-339705164 -->|"D"|DFA7_1966195189
DFA7_1966195189 -->|"M"|DFA8_-86002087
DFA8_-86002087 -->|"S"|DFA9_1271986237
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
DFA0_-815862297{{"DFA0 regex start"}}
DFA1_332110345{{"DFA1 {1}"}}
DFA2_1558393290{{"DFA2 {1}"}}
DFA3_-327039984{{"DFA3 {1}"}}
DFA4_1866429966{{"DFA4 {1}"}}
DFA5_-1220080796{{"DFA5 {1}"}}
DFA6_-339705164{{"DFA6 {1}"}}
DFA7_1966195189{{"DFA7 {1}"}}
DFA8_-86002087{{"DFA8 {1}"}}
DFA9_1271986237[\"DFA9 {1}"/]
DFA0_-815862297 -->|"i"|DFA1_332110345
DFA1_332110345 -->|"m"|DFA2_1558393290
DFA2_1558393290 -->|"a"|DFA3_-327039984
DFA3_-327039984 -->|"g"|DFA4_1866429966
DFA4_1866429966 -->|"e"|DFA5_-1220080796
DFA5_-1220080796 -->|"2"|DFA6_-339705164
DFA6_-339705164 -->|"D"|DFA7_1966195189
DFA7_1966195189 -->|"M"|DFA8_-86002087
DFA8_-86002087 -->|"S"|DFA9_1271986237
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
subgraph MiniDFA0_-1837279203["MiniDFA0 {1}"]
DFA0_-815862297_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1940580502["MiniDFA1 {1}"]
DFA1_332110345_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1481262639["MiniDFA2 {1}"]
DFA2_1558393290_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1257625458["MiniDFA3 {1}"]
DFA3_-327039984_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1994370555["MiniDFA4 {1}"]
DFA4_1866429966_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1819819121["MiniDFA5 {1}"]
DFA5_-1220080796_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1196158191["MiniDFA6 {1}"]
DFA6_-339705164_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1239041973["MiniDFA7 {1}"]
DFA7_1966195189_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_909980547["MiniDFA8 {1}"]
DFA8_-86002087_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_1060582994["MiniDFA9 {1}"]
DFA9_1271986237_9[\"DFA9 {1}"/]
end
MiniDFA0_-1837279203 -->|"i"|MiniDFA1_1940580502
MiniDFA1_1940580502 -->|"m"|MiniDFA2_1481262639
MiniDFA2_1481262639 -->|"a"|MiniDFA3_1257625458
MiniDFA3_1257625458 -->|"g"|MiniDFA4_1994370555
MiniDFA4_1994370555 -->|"e"|MiniDFA5_1819819121
MiniDFA5_1819819121 -->|"2"|MiniDFA6_1196158191
MiniDFA6_1196158191 -->|"D"|MiniDFA7_-1239041973
MiniDFA7_-1239041973 -->|"M"|MiniDFA8_909980547
MiniDFA8_909980547 -->|"S"|MiniDFA9_1060582994
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
MiniDFA0_-1837279203(["MiniDFA0 {1}"])
MiniDFA1_1940580502(["MiniDFA1 {1}"])
MiniDFA2_1481262639(["MiniDFA2 {1}"])
MiniDFA3_1257625458(["MiniDFA3 {1}"])
MiniDFA4_1994370555(["MiniDFA4 {1}"])
MiniDFA5_1819819121(["MiniDFA5 {1}"])
MiniDFA6_1196158191(["MiniDFA6 {1}"])
MiniDFA7_-1239041973(["MiniDFA7 {1}"])
MiniDFA8_909980547(["MiniDFA8 {1}"])
MiniDFA9_1060582994[\"MiniDFA9 {1}"/]
MiniDFA0_-1837279203 -->|"i"|MiniDFA1_1940580502
MiniDFA1_1940580502 -->|"m"|MiniDFA2_1481262639
MiniDFA2_1481262639 -->|"a"|MiniDFA3_1257625458
MiniDFA3_1257625458 -->|"g"|MiniDFA4_1994370555
MiniDFA4_1994370555 -->|"e"|MiniDFA5_1819819121
MiniDFA5_1819819121 -->|"2"|MiniDFA6_1196158191
MiniDFA6_1196158191 -->|"D"|MiniDFA7_-1239041973
MiniDFA7_-1239041973 -->|"M"|MiniDFA8_909980547
MiniDFA8_909980547 -->|"S"|MiniDFA9_1060582994
```
-------------------------------
