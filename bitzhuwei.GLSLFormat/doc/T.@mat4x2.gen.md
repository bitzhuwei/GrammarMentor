# 'mat4x2'

pattern: `mat4x2`

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
eNFA104_12_44225290[["εNFA104-12 regex start"]]
eNFA104_0_62483297[["εNFA104-0 char{1, 1}"]]
eNFA104_1_25478763[["εNFA104-1 char[1]"]]
eNFA104_2_27982283[["εNFA104-2 char{1, 1}"]]
eNFA104_3_50513961[["εNFA104-3 char[1]"]]
eNFA104_4_51972470[["εNFA104-4 char{1, 1}"]]
eNFA104_5_65099051[["εNFA104-5 char[1]"]]
eNFA104_6_49020554[["εNFA104-6 char{1, 1}"]]
eNFA104_7_38531802[["εNFA104-7 char[1]"]]
eNFA104_8_11241901[["εNFA104-8 char{1, 1}"]]
eNFA104_9_34068253[["εNFA104-9 char[1]"]]
eNFA104_10_38178826[["εNFA104-10 char{1, 1}"]]
eNFA104_11_8065117[["εNFA104-11 char[1]"]]
eNFA104_13_5477191[["εNFA104-13 regex end"]]
eNFA104_14_49294721[["εNFA104-14 post-regex start"]]
eNFA104_15_40999308[\"εNFA104-15 post-regex end"/]
eNFA104_12_44225290 -.->|"ε"|eNFA104_0_62483297
eNFA104_0_62483297 -->|"m"|eNFA104_1_25478763
eNFA104_1_25478763 -.->|"ε"|eNFA104_2_27982283
eNFA104_2_27982283 -->|"a"|eNFA104_3_50513961
eNFA104_3_50513961 -.->|"ε"|eNFA104_4_51972470
eNFA104_4_51972470 -->|"t"|eNFA104_5_65099051
eNFA104_5_65099051 -.->|"ε"|eNFA104_6_49020554
eNFA104_6_49020554 -->|"4"|eNFA104_7_38531802
eNFA104_7_38531802 -.->|"ε"|eNFA104_8_11241901
eNFA104_8_11241901 -->|"x"|eNFA104_9_34068253
eNFA104_9_34068253 -.->|"ε"|eNFA104_10_38178826
eNFA104_10_38178826 -->|"2"|eNFA104_11_8065117
eNFA104_11_8065117 -.->|"ε"|eNFA104_13_5477191
eNFA104_13_5477191 -.->|"ε"|eNFA104_14_49294721
eNFA104_14_49294721 -.->|"ε"|eNFA104_15_40999308
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
eNFA104_12_33449458[["εNFA104-12 regex start"]]
eNFA104_0_32609666[["εNFA104-0 char{1, 1}"]]
eNFA104_1_25051543[["εNFA104-1 char[1]"]]
eNFA104_2_24137296[["εNFA104-2 char{1, 1}"]]
eNFA104_3_15909080[["εNFA104-3 char[1]"]]
eNFA104_4_8963999[["εNFA104-4 char{1, 1}"]]
eNFA104_5_13567135[["εNFA104-5 char[1]"]]
eNFA104_6_54995351[["εNFA104-6 char{1, 1}"]]
eNFA104_7_25196113[["εNFA104-7 char[1]"]]
eNFA104_8_25438431[["εNFA104-8 char{1, 1}"]]
eNFA104_9_27619288[["εNFA104-9 char[1]"]]
eNFA104_10_47247007[["εNFA104-10 char{1, 1}"]]
eNFA104_11_22569884[\"εNFA104-11 char[1]"/]
eNFA104_13_1802368[\"εNFA104-13 regex end"/]
eNFA104_14_16221316[\"εNFA104-14 post-regex start"/]
eNFA104_15_11774121[\"εNFA104-15 post-regex end"/]
eNFA104_12_33449458 -.->|"ε"|eNFA104_0_32609666
eNFA104_12_33449458 -->|"m"|eNFA104_1_25051543
eNFA104_0_32609666 -->|"m"|eNFA104_1_25051543
eNFA104_1_25051543 -.->|"ε"|eNFA104_2_24137296
eNFA104_1_25051543 -->|"a"|eNFA104_3_15909080
eNFA104_2_24137296 -->|"a"|eNFA104_3_15909080
eNFA104_3_15909080 -.->|"ε"|eNFA104_4_8963999
eNFA104_3_15909080 -->|"t"|eNFA104_5_13567135
eNFA104_4_8963999 -->|"t"|eNFA104_5_13567135
eNFA104_5_13567135 -.->|"ε"|eNFA104_6_54995351
eNFA104_5_13567135 -->|"4"|eNFA104_7_25196113
eNFA104_6_54995351 -->|"4"|eNFA104_7_25196113
eNFA104_7_25196113 -.->|"ε"|eNFA104_8_25438431
eNFA104_7_25196113 -->|"x"|eNFA104_9_27619288
eNFA104_8_25438431 -->|"x"|eNFA104_9_27619288
eNFA104_9_27619288 -.->|"ε"|eNFA104_10_47247007
eNFA104_9_27619288 -->|"2"|eNFA104_11_22569884
eNFA104_10_47247007 -->|"2"|eNFA104_11_22569884
eNFA104_11_22569884 -.->|"ε"|eNFA104_13_1802368
eNFA104_11_22569884 -.->|"ε"|eNFA104_14_16221316
eNFA104_11_22569884 -.->|"ε"|eNFA104_15_11774121
eNFA104_13_1802368 -.->|"ε"|eNFA104_14_16221316
eNFA104_13_1802368 -.->|"ε"|eNFA104_15_11774121
eNFA104_14_16221316 -.->|"ε"|eNFA104_15_11774121
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
NFA104_12_38858233("NFA104-12 regex start")
NFA104_1_14179779("NFA104-1 char[1]")
NFA104_3_60509154("NFA104-3 char[1]")
NFA104_5_7711478("NFA104-5 char[1]")
NFA104_7_2294440("NFA104-7 char[1]")
NFA104_9_20649961("NFA104-9 char[1]")
NFA104_11_51631922[\"NFA104-11 char[1]"/]
NFA104_12_38858233 -->|"m"|NFA104_1_14179779
NFA104_1_14179779 -->|"a"|NFA104_3_60509154
NFA104_3_60509154 -->|"t"|NFA104_5_7711478
NFA104_5_7711478 -->|"4"|NFA104_7_2294440
NFA104_7_2294440 -->|"x"|NFA104_9_20649961
NFA104_9_20649961 -->|"2"|NFA104_11_51631922
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
subgraph DFA0_-1697672218["DFA0 regex start"]
NFA104_12_38858233_0("NFA104-12 regex start")
end
subgraph DFA1_-50401792["DFA1 {1}"]
NFA104_1_14179779_1("NFA104-1 char[1]")
end
subgraph DFA2_1378239688["DFA2 {1}"]
NFA104_3_60509154_2("NFA104-3 char[1]")
end
subgraph DFA3_1712740376["DFA3 {1}"]
NFA104_5_7711478_3("NFA104-5 char[1]")
end
subgraph DFA4_-1088880310["DFA4 {1}"]
NFA104_7_2294440_4("NFA104-7 char[1]")
end
subgraph DFA5_-285813777["DFA5 {1}"]
NFA104_9_20649961_5("NFA104-9 char[1]")
end
subgraph DFA6_-1549583819["DFA6 {1}"]
NFA104_11_51631922_6[\"NFA104-11 char[1]"/]
end
DFA0_-1697672218 -->|"m"|DFA1_-50401792
DFA1_-50401792 -->|"a"|DFA2_1378239688
DFA2_1378239688 -->|"t"|DFA3_1712740376
DFA3_1712740376 -->|"4"|DFA4_-1088880310
DFA4_-1088880310 -->|"x"|DFA5_-285813777
DFA5_-285813777 -->|"2"|DFA6_-1549583819
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
DFA0_-1697672218{{"DFA0 regex start"}}
DFA1_-50401792{{"DFA1 {1}"}}
DFA2_1378239688{{"DFA2 {1}"}}
DFA3_1712740376{{"DFA3 {1}"}}
DFA4_-1088880310{{"DFA4 {1}"}}
DFA5_-285813777{{"DFA5 {1}"}}
DFA6_-1549583819[\"DFA6 {1}"/]
DFA0_-1697672218 -->|"m"|DFA1_-50401792
DFA1_-50401792 -->|"a"|DFA2_1378239688
DFA2_1378239688 -->|"t"|DFA3_1712740376
DFA3_1712740376 -->|"4"|DFA4_-1088880310
DFA4_-1088880310 -->|"x"|DFA5_-285813777
DFA5_-285813777 -->|"2"|DFA6_-1549583819
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
subgraph MiniDFA0_2116483669["MiniDFA0 {1}"]
DFA0_-1697672218_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_761435166["MiniDFA1 {1}"]
DFA1_-50401792_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1359189469["MiniDFA2 {1}"]
DFA2_1378239688_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1724345175["MiniDFA3 {1}"]
DFA3_1712740376_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_2138954156["MiniDFA4 {1}"]
DFA4_-1088880310_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-895981004["MiniDFA5 {1}"]
DFA5_-285813777_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1486919902["MiniDFA6 {1}"]
DFA6_-1549583819_6[\"DFA6 {1}"/]
end
MiniDFA0_2116483669 -->|"m"|MiniDFA1_761435166
MiniDFA1_761435166 -->|"a"|MiniDFA2_1359189469
MiniDFA2_1359189469 -->|"t"|MiniDFA3_1724345175
MiniDFA3_1724345175 -->|"4"|MiniDFA4_2138954156
MiniDFA4_2138954156 -->|"x"|MiniDFA5_-895981004
MiniDFA5_-895981004 -->|"2"|MiniDFA6_-1486919902
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
MiniDFA0_2116483669(["MiniDFA0 {1}"])
MiniDFA1_761435166(["MiniDFA1 {1}"])
MiniDFA2_1359189469(["MiniDFA2 {1}"])
MiniDFA3_1724345175(["MiniDFA3 {1}"])
MiniDFA4_2138954156(["MiniDFA4 {1}"])
MiniDFA5_-895981004(["MiniDFA5 {1}"])
MiniDFA6_-1486919902[\"MiniDFA6 {1}"/]
MiniDFA0_2116483669 -->|"m"|MiniDFA1_761435166
MiniDFA1_761435166 -->|"a"|MiniDFA2_1359189469
MiniDFA2_1359189469 -->|"t"|MiniDFA3_1724345175
MiniDFA3_1724345175 -->|"4"|MiniDFA4_2138954156
MiniDFA4_2138954156 -->|"x"|MiniDFA5_-895981004
MiniDFA5_-895981004 -->|"2"|MiniDFA6_-1486919902
```
-------------------------------
