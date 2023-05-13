# 'dmat4'

pattern: `dmat4`

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
eNFA109_10_45814047[["εNFA109-10 regex start"]]
eNFA109_0_9673245[["εNFA109-0 char{1, 1}"]]
eNFA109_1_19950346[["εNFA109-1 char[1]"]]
eNFA109_2_45335391[["εNFA109-2 char{1, 1}"]]
eNFA109_3_5365342[["εNFA109-3 char[1]"]]
eNFA109_4_48288078[["εNFA109-4 char{1, 1}"]]
eNFA109_5_31939521[["εNFA109-5 char[1]"]]
eNFA109_6_19020241[["εNFA109-6 char{1, 1}"]]
eNFA109_7_36964446[["εNFA109-7 char[1]"]]
eNFA109_8_64244561[["εNFA109-8 char{1, 1}"]]
eNFA109_9_41330139[["εNFA109-9 char[1]"]]
eNFA109_11_36426933[["εNFA109-11 regex end"]]
eNFA109_12_59406944[["εNFA109-12 post-regex start"]]
eNFA109_13_64900454[\"εNFA109-13 post-regex end"/]
eNFA109_10_45814047 -.->|"ε"|eNFA109_0_9673245
eNFA109_0_9673245 -->|"d"|eNFA109_1_19950346
eNFA109_1_19950346 -.->|"ε"|eNFA109_2_45335391
eNFA109_2_45335391 -->|"m"|eNFA109_3_5365342
eNFA109_3_5365342 -.->|"ε"|eNFA109_4_48288078
eNFA109_4_48288078 -->|"a"|eNFA109_5_31939521
eNFA109_5_31939521 -.->|"ε"|eNFA109_6_19020241
eNFA109_6_19020241 -->|"t"|eNFA109_7_36964446
eNFA109_7_36964446 -.->|"ε"|eNFA109_8_64244561
eNFA109_8_64244561 -->|"4"|eNFA109_9_41330139
eNFA109_9_41330139 -.->|"ε"|eNFA109_11_36426933
eNFA109_11_36426933 -.->|"ε"|eNFA109_12_59406944
eNFA109_12_59406944 -.->|"ε"|eNFA109_13_64900454
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
eNFA109_10_47233174[["εNFA109-10 regex start"]]
eNFA109_0_22445387[["εNFA109-0 char{1, 1}"]]
eNFA109_1_681892[["εNFA109-1 char[1]"]]
eNFA109_2_6137036[["εNFA109-2 char{1, 1}"]]
eNFA109_3_55233331[["εNFA109-3 char[1]"]]
eNFA109_4_27337939[["εNFA109-4 char{1, 1}"]]
eNFA109_5_44714859[["εNFA109-5 char[1]"]]
eNFA109_6_66889413[["εNFA109-6 char{1, 1}"]]
eNFA109_7_65133811[["εNFA109-7 char[1]"]]
eNFA109_8_49333388[["εNFA109-8 char{1, 1}"]]
eNFA109_9_41347315[\"εNFA109-9 char[1]"/]
eNFA109_11_36581520[\"εNFA109-11 regex end"/]
eNFA109_12_60798228[\"εNFA109-12 post-regex start"/]
eNFA109_13_10313144[\"εNFA109-13 post-regex end"/]
eNFA109_10_47233174 -.->|"ε"|eNFA109_0_22445387
eNFA109_10_47233174 -->|"d"|eNFA109_1_681892
eNFA109_0_22445387 -->|"d"|eNFA109_1_681892
eNFA109_1_681892 -.->|"ε"|eNFA109_2_6137036
eNFA109_1_681892 -->|"m"|eNFA109_3_55233331
eNFA109_2_6137036 -->|"m"|eNFA109_3_55233331
eNFA109_3_55233331 -.->|"ε"|eNFA109_4_27337939
eNFA109_3_55233331 -->|"a"|eNFA109_5_44714859
eNFA109_4_27337939 -->|"a"|eNFA109_5_44714859
eNFA109_5_44714859 -.->|"ε"|eNFA109_6_66889413
eNFA109_5_44714859 -->|"t"|eNFA109_7_65133811
eNFA109_6_66889413 -->|"t"|eNFA109_7_65133811
eNFA109_7_65133811 -.->|"ε"|eNFA109_8_49333388
eNFA109_7_65133811 -->|"4"|eNFA109_9_41347315
eNFA109_8_49333388 -->|"4"|eNFA109_9_41347315
eNFA109_9_41347315 -.->|"ε"|eNFA109_11_36581520
eNFA109_9_41347315 -.->|"ε"|eNFA109_12_60798228
eNFA109_9_41347315 -.->|"ε"|eNFA109_13_10313144
eNFA109_11_36581520 -.->|"ε"|eNFA109_12_60798228
eNFA109_11_36581520 -.->|"ε"|eNFA109_13_10313144
eNFA109_12_60798228 -.->|"ε"|eNFA109_13_10313144
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
NFA109_10_25709437("NFA109-10 regex start")
NFA109_1_30058349("NFA109-1 char[1]")
NFA109_3_2089687("NFA109-3 char[1]")
NFA109_5_18807190("NFA109-5 char[1]")
NFA109_7_35046986("NFA109-7 char[1]")
NFA109_9_46987420[\"NFA109-9 char[1]"/]
NFA109_10_25709437 -->|"d"|NFA109_1_30058349
NFA109_1_30058349 -->|"m"|NFA109_3_2089687
NFA109_3_2089687 -->|"a"|NFA109_5_18807190
NFA109_5_18807190 -->|"t"|NFA109_7_35046986
NFA109_7_35046986 -->|"4"|NFA109_9_46987420
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
subgraph DFA0_1843136532["DFA0 regex start"]
NFA109_10_25709437_0("NFA109-10 regex start")
end
subgraph DFA1_636481041["DFA1 {1}"]
NFA109_1_30058349_1("NFA109-1 char[1]")
end
subgraph DFA2_324790895["DFA2 {1}"]
NFA109_3_2089687_2("NFA109-3 char[1]")
end
subgraph DFA3_847262449["DFA3 {1}"]
NFA109_5_18807190_3("NFA109-5 char[1]")
end
subgraph DFA4_1331239155["DFA4 {1}"]
NFA109_7_35046986_4("NFA109-7 char[1]")
end
subgraph DFA5_1907647923["DFA5 {1}"]
NFA109_9_46987420_5[\"NFA109-9 char[1]"/]
end
DFA0_1843136532 -->|"d"|DFA1_636481041
DFA1_636481041 -->|"m"|DFA2_324790895
DFA2_324790895 -->|"a"|DFA3_847262449
DFA3_847262449 -->|"t"|DFA4_1331239155
DFA4_1331239155 -->|"4"|DFA5_1907647923
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
DFA0_1843136532{{"DFA0 regex start"}}
DFA1_636481041{{"DFA1 {1}"}}
DFA2_324790895{{"DFA2 {1}"}}
DFA3_847262449{{"DFA3 {1}"}}
DFA4_1331239155{{"DFA4 {1}"}}
DFA5_1907647923[\"DFA5 {1}"/]
DFA0_1843136532 -->|"d"|DFA1_636481041
DFA1_636481041 -->|"m"|DFA2_324790895
DFA2_324790895 -->|"a"|DFA3_847262449
DFA3_847262449 -->|"t"|DFA4_1331239155
DFA4_1331239155 -->|"4"|DFA5_1907647923
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
subgraph MiniDFA0_1402540101["MiniDFA0 {1}"]
DFA0_1843136532_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1328030062["MiniDFA1 {1}"]
DFA1_636481041_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-568347364["MiniDFA2 {1}"]
DFA2_324790895_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-240451823["MiniDFA3 {1}"]
DFA3_847262449_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_910838378["MiniDFA4 {1}"]
DFA4_1331239155_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_203873071["MiniDFA5 {1}"]
DFA5_1907647923_5[\"DFA5 {1}"/]
end
MiniDFA0_1402540101 -->|"d"|MiniDFA1_-1328030062
MiniDFA1_-1328030062 -->|"m"|MiniDFA2_-568347364
MiniDFA2_-568347364 -->|"a"|MiniDFA3_-240451823
MiniDFA3_-240451823 -->|"t"|MiniDFA4_910838378
MiniDFA4_910838378 -->|"4"|MiniDFA5_203873071
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
MiniDFA0_1402540101(["MiniDFA0 {1}"])
MiniDFA1_-1328030062(["MiniDFA1 {1}"])
MiniDFA2_-568347364(["MiniDFA2 {1}"])
MiniDFA3_-240451823(["MiniDFA3 {1}"])
MiniDFA4_910838378(["MiniDFA4 {1}"])
MiniDFA5_203873071[\"MiniDFA5 {1}"/]
MiniDFA0_1402540101 -->|"d"|MiniDFA1_-1328030062
MiniDFA1_-1328030062 -->|"m"|MiniDFA2_-568347364
MiniDFA2_-568347364 -->|"a"|MiniDFA3_-240451823
MiniDFA3_-240451823 -->|"t"|MiniDFA4_910838378
MiniDFA4_910838378 -->|"4"|MiniDFA5_203873071
```
-------------------------------
