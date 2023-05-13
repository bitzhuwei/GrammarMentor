# 'uimage3D'

pattern: `uimage3D`

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
eNFA168_16_8980857[["εNFA168-16 regex start"]]
eNFA168_0_13718857[["εNFA168-0 char{1, 1}"]]
eNFA168_1_56360854[["εNFA168-1 char[1]"]]
eNFA168_2_37485641[["εNFA168-2 char{1, 1}"]]
eNFA168_3_1826451[["εNFA168-3 char[1]"]]
eNFA168_4_16438061[["εNFA168-4 char{1, 1}"]]
eNFA168_5_13724824[["εNFA168-5 char[1]"]]
eNFA168_6_56414558[["εNFA168-6 char{1, 1}"]]
eNFA168_7_37968974[["εNFA168-7 char[1]"]]
eNFA168_8_6176451[["εNFA168-8 char{1, 1}"]]
eNFA168_9_55588060[["εNFA168-9 char[1]"]]
eNFA168_10_30530500[["εNFA168-10 char{1, 1}"]]
eNFA168_11_6339051[["εNFA168-11 char[1]"]]
eNFA168_12_57051467[["εNFA168-12 char{1, 1}"]]
eNFA168_13_43701155[["εNFA168-13 char[1]"]]
eNFA168_14_57766077[["εNFA168-14 char{1, 1}"]]
eNFA168_15_50132651[["εNFA168-15 char[1]"]]
eNFA168_17_48540676[["εNFA168-17 regex end"]]
eNFA168_18_34212907[["εNFA168-18 post-regex start"]]
eNFA168_19_39480712[\"εNFA168-19 post-regex end"/]
eNFA168_16_8980857 -.->|"ε"|eNFA168_0_13718857
eNFA168_0_13718857 -->|"u"|eNFA168_1_56360854
eNFA168_1_56360854 -.->|"ε"|eNFA168_2_37485641
eNFA168_2_37485641 -->|"i"|eNFA168_3_1826451
eNFA168_3_1826451 -.->|"ε"|eNFA168_4_16438061
eNFA168_4_16438061 -->|"m"|eNFA168_5_13724824
eNFA168_5_13724824 -.->|"ε"|eNFA168_6_56414558
eNFA168_6_56414558 -->|"a"|eNFA168_7_37968974
eNFA168_7_37968974 -.->|"ε"|eNFA168_8_6176451
eNFA168_8_6176451 -->|"g"|eNFA168_9_55588060
eNFA168_9_55588060 -.->|"ε"|eNFA168_10_30530500
eNFA168_10_30530500 -->|"e"|eNFA168_11_6339051
eNFA168_11_6339051 -.->|"ε"|eNFA168_12_57051467
eNFA168_12_57051467 -->|"3"|eNFA168_13_43701155
eNFA168_13_43701155 -.->|"ε"|eNFA168_14_57766077
eNFA168_14_57766077 -->|"D"|eNFA168_15_50132651
eNFA168_15_50132651 -.->|"ε"|eNFA168_17_48540676
eNFA168_17_48540676 -.->|"ε"|eNFA168_18_34212907
eNFA168_18_34212907 -.->|"ε"|eNFA168_19_39480712
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
eNFA168_16_19782092[["εNFA168-16 regex start"]]
eNFA168_0_43821104[["εNFA168-0 char{1, 1}"]]
eNFA168_1_58845621[["εNFA168-1 char[1]"]]
eNFA168_2_59848549[["εNFA168-2 char{1, 1}"]]
eNFA168_3_1766031[["εNFA168-3 char[1]"]]
eNFA168_4_15894286[["εNFA168-4 char{1, 1}"]]
eNFA168_5_8830850[["εNFA168-5 char[1]"]]
eNFA168_6_12368788[["εNFA168-6 char{1, 1}"]]
eNFA168_7_44210229[["εNFA168-7 char[1]"]]
eNFA168_8_62347742[["εNFA168-8 char{1, 1}"]]
eNFA168_9_24258768[["εNFA168-9 char[1]"]]
eNFA168_10_17002324[["εNFA168-10 char{1, 1}"]]
eNFA168_11_18803196[["εNFA168-11 char[1]"]]
eNFA168_12_35011040[["εNFA168-12 char{1, 1}"]]
eNFA168_13_46663904[["εNFA168-13 char[1]"]]
eNFA168_14_17321959[["εNFA168-14 char{1, 1}"]]
eNFA168_15_21679909[\"εNFA168-15 char[1]"/]
eNFA168_17_60901459[\"εNFA168-17 regex end"/]
eNFA168_18_11242227[\"εNFA168-18 post-regex start"/]
eNFA168_19_34071180[\"εNFA168-19 post-regex end"/]
eNFA168_16_19782092 -.->|"ε"|eNFA168_0_43821104
eNFA168_16_19782092 -->|"u"|eNFA168_1_58845621
eNFA168_0_43821104 -->|"u"|eNFA168_1_58845621
eNFA168_1_58845621 -.->|"ε"|eNFA168_2_59848549
eNFA168_1_58845621 -->|"i"|eNFA168_3_1766031
eNFA168_2_59848549 -->|"i"|eNFA168_3_1766031
eNFA168_3_1766031 -.->|"ε"|eNFA168_4_15894286
eNFA168_3_1766031 -->|"m"|eNFA168_5_8830850
eNFA168_4_15894286 -->|"m"|eNFA168_5_8830850
eNFA168_5_8830850 -.->|"ε"|eNFA168_6_12368788
eNFA168_5_8830850 -->|"a"|eNFA168_7_44210229
eNFA168_6_12368788 -->|"a"|eNFA168_7_44210229
eNFA168_7_44210229 -.->|"ε"|eNFA168_8_62347742
eNFA168_7_44210229 -->|"g"|eNFA168_9_24258768
eNFA168_8_62347742 -->|"g"|eNFA168_9_24258768
eNFA168_9_24258768 -.->|"ε"|eNFA168_10_17002324
eNFA168_9_24258768 -->|"e"|eNFA168_11_18803196
eNFA168_10_17002324 -->|"e"|eNFA168_11_18803196
eNFA168_11_18803196 -.->|"ε"|eNFA168_12_35011040
eNFA168_11_18803196 -->|"3"|eNFA168_13_46663904
eNFA168_12_35011040 -->|"3"|eNFA168_13_46663904
eNFA168_13_46663904 -.->|"ε"|eNFA168_14_17321959
eNFA168_13_46663904 -->|"D"|eNFA168_15_21679909
eNFA168_14_17321959 -->|"D"|eNFA168_15_21679909
eNFA168_15_21679909 -.->|"ε"|eNFA168_17_60901459
eNFA168_15_21679909 -.->|"ε"|eNFA168_18_11242227
eNFA168_15_21679909 -.->|"ε"|eNFA168_19_34071180
eNFA168_17_60901459 -.->|"ε"|eNFA168_18_11242227
eNFA168_17_60901459 -.->|"ε"|eNFA168_19_34071180
eNFA168_18_11242227 -.->|"ε"|eNFA168_19_34071180
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
NFA168_16_38205169("NFA168-16 regex start")
NFA168_1_8302201("NFA168-1 char[1]")
NFA168_3_7610951("NFA168-3 char[1]")
NFA168_5_1389699("NFA168-5 char[1]")
NFA168_7_12507294("NFA168-7 char[1]")
NFA168_9_45456785("NFA168-9 char[1]")
NFA168_11_6457885("NFA168-11 char[1]")
NFA168_13_58120972("NFA168-13 char[1]")
NFA168_15_53326701[\"NFA168-15 char[1]"/]
NFA168_16_38205169 -->|"u"|NFA168_1_8302201
NFA168_1_8302201 -->|"i"|NFA168_3_7610951
NFA168_3_7610951 -->|"m"|NFA168_5_1389699
NFA168_5_1389699 -->|"a"|NFA168_7_12507294
NFA168_7_12507294 -->|"g"|NFA168_9_45456785
NFA168_9_45456785 -->|"e"|NFA168_11_6457885
NFA168_11_6457885 -->|"3"|NFA168_13_58120972
NFA168_13_58120972 -->|"D"|NFA168_15_53326701
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
subgraph DFA0_-1788678909["DFA0 regex start"]
NFA168_16_38205169_0("NFA168-16 regex start")
end
subgraph DFA1_-473836639["DFA1 {1}"]
NFA168_1_8302201_1("NFA168-1 char[1]")
end
subgraph DFA2_-1943349449["DFA2 {1}"]
NFA168_3_7610951_2("NFA168-3 char[1]")
end
subgraph DFA3_1684059607["DFA3 {1}"]
NFA168_5_1389699_3("NFA168-5 char[1]")
end
subgraph DFA4_-1417057639["DFA4 {1}"]
NFA168_7_12507294_4("NFA168-7 char[1]")
end
subgraph DFA5_805255873["DFA5 {1}"]
NFA168_9_45456785_5("NFA168-9 char[1]")
end
subgraph DFA6_-1526737291["DFA6 {1}"]
NFA168_11_6457885_6("NFA168-11 char[1]")
end
subgraph DFA7_-681767960["DFA7 {1}"]
NFA168_13_58120972_7("NFA168-13 char[1]")
end
subgraph DFA8_691585531["DFA8 {1}"]
NFA168_15_53326701_8[\"NFA168-15 char[1]"/]
end
DFA0_-1788678909 -->|"u"|DFA1_-473836639
DFA1_-473836639 -->|"i"|DFA2_-1943349449
DFA2_-1943349449 -->|"m"|DFA3_1684059607
DFA3_1684059607 -->|"a"|DFA4_-1417057639
DFA4_-1417057639 -->|"g"|DFA5_805255873
DFA5_805255873 -->|"e"|DFA6_-1526737291
DFA6_-1526737291 -->|"3"|DFA7_-681767960
DFA7_-681767960 -->|"D"|DFA8_691585531
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
DFA0_-1788678909{{"DFA0 regex start"}}
DFA1_-473836639{{"DFA1 {1}"}}
DFA2_-1943349449{{"DFA2 {1}"}}
DFA3_1684059607{{"DFA3 {1}"}}
DFA4_-1417057639{{"DFA4 {1}"}}
DFA5_805255873{{"DFA5 {1}"}}
DFA6_-1526737291{{"DFA6 {1}"}}
DFA7_-681767960{{"DFA7 {1}"}}
DFA8_691585531[\"DFA8 {1}"/]
DFA0_-1788678909 -->|"u"|DFA1_-473836639
DFA1_-473836639 -->|"i"|DFA2_-1943349449
DFA2_-1943349449 -->|"m"|DFA3_1684059607
DFA3_1684059607 -->|"a"|DFA4_-1417057639
DFA4_-1417057639 -->|"g"|DFA5_805255873
DFA5_805255873 -->|"e"|DFA6_-1526737291
DFA6_-1526737291 -->|"3"|DFA7_-681767960
DFA7_-681767960 -->|"D"|DFA8_691585531
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
subgraph MiniDFA0_-877045432["MiniDFA0 {1}"]
DFA0_-1788678909_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1013052805["MiniDFA1 {1}"]
DFA1_-473836639_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-310695971["MiniDFA2 {1}"]
DFA2_-1943349449_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_599163683["MiniDFA3 {1}"]
DFA3_1684059607_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1029444128["MiniDFA4 {1}"]
DFA4_-1417057639_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1584689163["MiniDFA5 {1}"]
DFA5_805255873_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_173691966["MiniDFA6 {1}"]
DFA6_-1526737291_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_20865045["MiniDFA7 {1}"]
DFA7_-681767960_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1482831567["MiniDFA8 {1}"]
DFA8_691585531_8[\"DFA8 {1}"/]
end
MiniDFA0_-877045432 -->|"u"|MiniDFA1_1013052805
MiniDFA1_1013052805 -->|"i"|MiniDFA2_-310695971
MiniDFA2_-310695971 -->|"m"|MiniDFA3_599163683
MiniDFA3_599163683 -->|"a"|MiniDFA4_-1029444128
MiniDFA4_-1029444128 -->|"g"|MiniDFA5_-1584689163
MiniDFA5_-1584689163 -->|"e"|MiniDFA6_173691966
MiniDFA6_173691966 -->|"3"|MiniDFA7_20865045
MiniDFA7_20865045 -->|"D"|MiniDFA8_1482831567
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
MiniDFA0_-877045432(["MiniDFA0 {1}"])
MiniDFA1_1013052805(["MiniDFA1 {1}"])
MiniDFA2_-310695971(["MiniDFA2 {1}"])
MiniDFA3_599163683(["MiniDFA3 {1}"])
MiniDFA4_-1029444128(["MiniDFA4 {1}"])
MiniDFA5_-1584689163(["MiniDFA5 {1}"])
MiniDFA6_173691966(["MiniDFA6 {1}"])
MiniDFA7_20865045(["MiniDFA7 {1}"])
MiniDFA8_1482831567[\"MiniDFA8 {1}"/]
MiniDFA0_-877045432 -->|"u"|MiniDFA1_1013052805
MiniDFA1_1013052805 -->|"i"|MiniDFA2_-310695971
MiniDFA2_-310695971 -->|"m"|MiniDFA3_599163683
MiniDFA3_599163683 -->|"a"|MiniDFA4_-1029444128
MiniDFA4_-1029444128 -->|"g"|MiniDFA5_-1584689163
MiniDFA5_-1584689163 -->|"e"|MiniDFA6_173691966
MiniDFA6_173691966 -->|"3"|MiniDFA7_20865045
MiniDFA7_20865045 -->|"D"|MiniDFA8_1482831567
```
-------------------------------
