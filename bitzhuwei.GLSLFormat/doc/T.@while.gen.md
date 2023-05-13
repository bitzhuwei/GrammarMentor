# 'while'

pattern: `while`

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
eNFA202_10_52128359[["εNFA202-10 regex start"]]
eNFA202_0_66502051[["εNFA202-0 char{1, 1}"]]
eNFA202_1_61647547[["εNFA202-1 char[1]"]]
eNFA202_2_17957018[["εNFA202-2 char{1, 1}"]]
eNFA202_3_27395440[["εNFA202-3 char[1]"]]
eNFA202_4_45232374[["εNFA202-4 char{1, 1}"]]
eNFA202_5_4438190[["εNFA202-5 char[1]"]]
eNFA202_6_39943711[["εNFA202-6 char{1, 1}"]]
eNFA202_7_23949084[["εNFA202-7 char[1]"]]
eNFA202_8_14215164[["εNFA202-8 char{1, 1}"]]
eNFA202_9_60827618[["εNFA202-9 char[1]"]]
eNFA202_11_10577654[["εNFA202-11 regex end"]]
eNFA202_12_28090025[["εNFA202-12 post-regex start"]]
eNFA202_13_51483636[\"εNFA202-13 post-regex end"/]
eNFA202_10_52128359 -.->|"ε"|eNFA202_0_66502051
eNFA202_0_66502051 -->|"w"|eNFA202_1_61647547
eNFA202_1_61647547 -.->|"ε"|eNFA202_2_17957018
eNFA202_2_17957018 -->|"h"|eNFA202_3_27395440
eNFA202_3_27395440 -.->|"ε"|eNFA202_4_45232374
eNFA202_4_45232374 -->|"i"|eNFA202_5_4438190
eNFA202_5_4438190 -.->|"ε"|eNFA202_6_39943711
eNFA202_6_39943711 -->|"l"|eNFA202_7_23949084
eNFA202_7_23949084 -.->|"ε"|eNFA202_8_14215164
eNFA202_8_14215164 -->|"e"|eNFA202_9_60827618
eNFA202_9_60827618 -.->|"ε"|eNFA202_11_10577654
eNFA202_11_10577654 -.->|"ε"|eNFA202_12_28090025
eNFA202_12_28090025 -.->|"ε"|eNFA202_13_51483636
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
eNFA202_10_60699544[["εNFA202-10 regex start"]]
eNFA202_0_9424991[["εNFA202-0 char{1, 1}"]]
eNFA202_1_17716056[["εNFA202-1 char[1]"]]
eNFA202_2_25226782[["εNFA202-2 char{1, 1}"]]
eNFA202_3_25714449[["εNFA202-3 char[1]"]]
eNFA202_4_30103450[["εNFA202-4 char{1, 1}"]]
eNFA202_5_2495594[["εNFA202-5 char[1]"]]
eNFA202_6_22460346[["εNFA202-6 char{1, 1}"]]
eNFA202_7_816523[["εNFA202-7 char[1]"]]
eNFA202_8_7348710[["εNFA202-8 char{1, 1}"]]
eNFA202_9_66138397[\"εNFA202-9 char[1]"/]
eNFA202_11_58374663[\"εNFA202-11 regex end"/]
eNFA202_12_55609927[\"εNFA202-12 post-regex start"/]
eNFA202_13_30727301[\"εNFA202-13 post-regex end"/]
eNFA202_10_60699544 -.->|"ε"|eNFA202_0_9424991
eNFA202_10_60699544 -->|"w"|eNFA202_1_17716056
eNFA202_0_9424991 -->|"w"|eNFA202_1_17716056
eNFA202_1_17716056 -.->|"ε"|eNFA202_2_25226782
eNFA202_1_17716056 -->|"h"|eNFA202_3_25714449
eNFA202_2_25226782 -->|"h"|eNFA202_3_25714449
eNFA202_3_25714449 -.->|"ε"|eNFA202_4_30103450
eNFA202_3_25714449 -->|"i"|eNFA202_5_2495594
eNFA202_4_30103450 -->|"i"|eNFA202_5_2495594
eNFA202_5_2495594 -.->|"ε"|eNFA202_6_22460346
eNFA202_5_2495594 -->|"l"|eNFA202_7_816523
eNFA202_6_22460346 -->|"l"|eNFA202_7_816523
eNFA202_7_816523 -.->|"ε"|eNFA202_8_7348710
eNFA202_7_816523 -->|"e"|eNFA202_9_66138397
eNFA202_8_7348710 -->|"e"|eNFA202_9_66138397
eNFA202_9_66138397 -.->|"ε"|eNFA202_11_58374663
eNFA202_9_66138397 -.->|"ε"|eNFA202_12_55609927
eNFA202_9_66138397 -.->|"ε"|eNFA202_13_30727301
eNFA202_11_58374663 -.->|"ε"|eNFA202_12_55609927
eNFA202_11_58374663 -.->|"ε"|eNFA202_13_30727301
eNFA202_12_55609927 -.->|"ε"|eNFA202_13_30727301
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
NFA202_10_8110258("NFA202-10 regex start")
NFA202_1_5883463("NFA202-1 char[1]")
NFA202_3_52951174("NFA202-3 char[1]")
NFA202_5_6798518("NFA202-5 char[1]")
NFA202_7_61186665("NFA202-7 char[1]")
NFA202_9_13809081[\"NFA202-9 char[1]"/]
NFA202_10_8110258 -->|"w"|NFA202_1_5883463
NFA202_1_5883463 -->|"h"|NFA202_3_52951174
NFA202_3_52951174 -->|"i"|NFA202_5_6798518
NFA202_5_6798518 -->|"l"|NFA202_7_61186665
NFA202_7_61186665 -->|"e"|NFA202_9_13809081
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
subgraph DFA0_1385843689["DFA0 regex start"]
NFA202_10_8110258_0("NFA202-10 regex start")
end
subgraph DFA1_-955845194["DFA1 {1}"]
NFA202_1_5883463_1("NFA202-1 char[1]")
end
subgraph DFA2_336696071["DFA2 {1}"]
NFA202_3_52951174_2("NFA202-3 char[1]")
end
subgraph DFA3_1884861742["DFA3 {1}"]
NFA202_5_6798518_3("NFA202-5 char[1]")
end
subgraph DFA4_-1441625249["DFA4 {1}"]
NFA202_7_61186665_4("NFA202-7 char[1]")
end
subgraph DFA5_2005088405["DFA5 {1}"]
NFA202_9_13809081_5[\"NFA202-9 char[1]"/]
end
DFA0_1385843689 -->|"w"|DFA1_-955845194
DFA1_-955845194 -->|"h"|DFA2_336696071
DFA2_336696071 -->|"i"|DFA3_1884861742
DFA3_1884861742 -->|"l"|DFA4_-1441625249
DFA4_-1441625249 -->|"e"|DFA5_2005088405
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
DFA0_1385843689{{"DFA0 regex start"}}
DFA1_-955845194{{"DFA1 {1}"}}
DFA2_336696071{{"DFA2 {1}"}}
DFA3_1884861742{{"DFA3 {1}"}}
DFA4_-1441625249{{"DFA4 {1}"}}
DFA5_2005088405[\"DFA5 {1}"/]
DFA0_1385843689 -->|"w"|DFA1_-955845194
DFA1_-955845194 -->|"h"|DFA2_336696071
DFA2_336696071 -->|"i"|DFA3_1884861742
DFA3_1884861742 -->|"l"|DFA4_-1441625249
DFA4_-1441625249 -->|"e"|DFA5_2005088405
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
subgraph MiniDFA0_-1002434465["MiniDFA0 {1}"]
DFA0_1385843689_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1289759453["MiniDFA1 {1}"]
DFA1_-955845194_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1411824351["MiniDFA2 {1}"]
DFA2_336696071_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1773247459["MiniDFA3 {1}"]
DFA3_1884861742_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_198505281["MiniDFA4 {1}"]
DFA4_-1441625249_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1766358351["MiniDFA5 {1}"]
DFA5_2005088405_5[\"DFA5 {1}"/]
end
MiniDFA0_-1002434465 -->|"w"|MiniDFA1_-1289759453
MiniDFA1_-1289759453 -->|"h"|MiniDFA2_-1411824351
MiniDFA2_-1411824351 -->|"i"|MiniDFA3_-1773247459
MiniDFA3_-1773247459 -->|"l"|MiniDFA4_198505281
MiniDFA4_198505281 -->|"e"|MiniDFA5_-1766358351
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
MiniDFA0_-1002434465(["MiniDFA0 {1}"])
MiniDFA1_-1289759453(["MiniDFA1 {1}"])
MiniDFA2_-1411824351(["MiniDFA2 {1}"])
MiniDFA3_-1773247459(["MiniDFA3 {1}"])
MiniDFA4_198505281(["MiniDFA4 {1}"])
MiniDFA5_-1766358351[\"MiniDFA5 {1}"/]
MiniDFA0_-1002434465 -->|"w"|MiniDFA1_-1289759453
MiniDFA1_-1289759453 -->|"h"|MiniDFA2_-1411824351
MiniDFA2_-1411824351 -->|"i"|MiniDFA3_-1773247459
MiniDFA3_-1773247459 -->|"l"|MiniDFA4_198505281
MiniDFA4_198505281 -->|"e"|MiniDFA5_-1766358351
```
-------------------------------
