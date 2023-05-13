# 'dmat4x2'

pattern: `dmat4x2`

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
eNFA116_14_5058598[["εNFA116-14 regex start"]]
eNFA116_0_45527389[["εNFA116-0 char{1, 1}"]]
eNFA116_1_7093323[["εNFA116-1 char[1]"]]
eNFA116_2_63839913[["εNFA116-2 char{1, 1}"]]
eNFA116_3_37688313[["εNFA116-3 char[1]"]]
eNFA116_4_3650498[["εNFA116-4 char{1, 1}"]]
eNFA116_5_32854487[["εNFA116-5 char[1]"]]
eNFA116_6_27254927[["εNFA116-6 char{1, 1}"]]
eNFA116_7_43967757[["εNFA116-7 char[1]"]]
eNFA116_8_60165497[["εNFA116-8 char{1, 1}"]]
eNFA116_9_4618564[["εNFA116-9 char[1]"]]
eNFA116_10_41567079[["εNFA116-10 char{1, 1}"]]
eNFA116_11_38559395[["εNFA116-11 char[1]"]]
eNFA116_12_11490242[["εNFA116-12 char{1, 1}"]]
eNFA116_13_36303315[["εNFA116-13 char[1]"]]
eNFA116_15_58294385[["εNFA116-15 regex end"]]
eNFA116_16_54887420[["εNFA116-16 post-regex start"]]
eNFA116_17_24224733[\"εNFA116-17 post-regex end"/]
eNFA116_14_5058598 -.->|"ε"|eNFA116_0_45527389
eNFA116_0_45527389 -->|"d"|eNFA116_1_7093323
eNFA116_1_7093323 -.->|"ε"|eNFA116_2_63839913
eNFA116_2_63839913 -->|"m"|eNFA116_3_37688313
eNFA116_3_37688313 -.->|"ε"|eNFA116_4_3650498
eNFA116_4_3650498 -->|"a"|eNFA116_5_32854487
eNFA116_5_32854487 -.->|"ε"|eNFA116_6_27254927
eNFA116_6_27254927 -->|"t"|eNFA116_7_43967757
eNFA116_7_43967757 -.->|"ε"|eNFA116_8_60165497
eNFA116_8_60165497 -->|"4"|eNFA116_9_4618564
eNFA116_9_4618564 -.->|"ε"|eNFA116_10_41567079
eNFA116_10_41567079 -->|"x"|eNFA116_11_38559395
eNFA116_11_38559395 -.->|"ε"|eNFA116_12_11490242
eNFA116_12_11490242 -->|"2"|eNFA116_13_36303315
eNFA116_13_36303315 -.->|"ε"|eNFA116_15_58294385
eNFA116_15_58294385 -.->|"ε"|eNFA116_16_54887420
eNFA116_16_54887420 -.->|"ε"|eNFA116_17_24224733
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
eNFA116_14_16696005[["εNFA116-14 regex start"]]
eNFA116_0_16046317[["εNFA116-0 char{1, 1}"]]
eNFA116_1_10199126[["εNFA116-1 char[1]"]]
eNFA116_2_24683273[["εNFA116-2 char{1, 1}"]]
eNFA116_3_20822872[["εNFA116-3 char[1]"]]
eNFA116_4_53188122[["εNFA116-4 char{1, 1}"]]
eNFA116_5_8931058[["εNFA116-5 char[1]"]]
eNFA116_6_13270664[["εNFA116-6 char{1, 1}"]]
eNFA116_7_52327117[["εNFA116-7 char[1]"]]
eNFA116_8_1182010[["εNFA116-8 char{1, 1}"]]
eNFA116_9_10638097[["εNFA116-9 char[1]"]]
eNFA116_10_28634009[["εNFA116-10 char{1, 1}"]]
eNFA116_11_56379492[["εNFA116-11 char[1]"]]
eNFA116_12_37653388[["εNFA116-12 char{1, 1}"]]
eNFA116_13_3336177[\"εNFA116-13 char[1]"/]
eNFA116_15_30025596[\"εNFA116-15 regex end"/]
eNFA116_16_1794910[\"εNFA116-16 post-regex start"/]
eNFA116_17_16154192[\"εNFA116-17 post-regex end"/]
eNFA116_14_16696005 -.->|"ε"|eNFA116_0_16046317
eNFA116_14_16696005 -->|"d"|eNFA116_1_10199126
eNFA116_0_16046317 -->|"d"|eNFA116_1_10199126
eNFA116_1_10199126 -.->|"ε"|eNFA116_2_24683273
eNFA116_1_10199126 -->|"m"|eNFA116_3_20822872
eNFA116_2_24683273 -->|"m"|eNFA116_3_20822872
eNFA116_3_20822872 -.->|"ε"|eNFA116_4_53188122
eNFA116_3_20822872 -->|"a"|eNFA116_5_8931058
eNFA116_4_53188122 -->|"a"|eNFA116_5_8931058
eNFA116_5_8931058 -.->|"ε"|eNFA116_6_13270664
eNFA116_5_8931058 -->|"t"|eNFA116_7_52327117
eNFA116_6_13270664 -->|"t"|eNFA116_7_52327117
eNFA116_7_52327117 -.->|"ε"|eNFA116_8_1182010
eNFA116_7_52327117 -->|"4"|eNFA116_9_10638097
eNFA116_8_1182010 -->|"4"|eNFA116_9_10638097
eNFA116_9_10638097 -.->|"ε"|eNFA116_10_28634009
eNFA116_9_10638097 -->|"x"|eNFA116_11_56379492
eNFA116_10_28634009 -->|"x"|eNFA116_11_56379492
eNFA116_11_56379492 -.->|"ε"|eNFA116_12_37653388
eNFA116_11_56379492 -->|"2"|eNFA116_13_3336177
eNFA116_12_37653388 -->|"2"|eNFA116_13_3336177
eNFA116_13_3336177 -.->|"ε"|eNFA116_15_30025596
eNFA116_13_3336177 -.->|"ε"|eNFA116_16_1794910
eNFA116_13_3336177 -.->|"ε"|eNFA116_17_16154192
eNFA116_15_30025596 -.->|"ε"|eNFA116_16_1794910
eNFA116_15_30025596 -.->|"ε"|eNFA116_17_16154192
eNFA116_16_1794910 -.->|"ε"|eNFA116_17_16154192
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
NFA116_14_11170003("NFA116-14 regex start")
NFA116_1_33421169("NFA116-1 char[1]")
NFA116_3_32355065("NFA116-3 char[1]")
NFA116_5_22760134("NFA116-5 char[1]")
NFA116_7_3514615("NFA116-7 char[1]")
NFA116_9_31631543("NFA116-9 char[1]")
NFA116_11_16248438("NFA116-11 char[1]")
NFA116_13_12018222[\"NFA116-13 char[1]"/]
NFA116_14_11170003 -->|"d"|NFA116_1_33421169
NFA116_1_33421169 -->|"m"|NFA116_3_32355065
NFA116_3_32355065 -->|"a"|NFA116_5_22760134
NFA116_5_22760134 -->|"t"|NFA116_7_3514615
NFA116_7_3514615 -->|"4"|NFA116_9_31631543
NFA116_9_31631543 -->|"x"|NFA116_11_16248438
NFA116_11_16248438 -->|"2"|NFA116_13_12018222
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
subgraph DFA0_709517201["DFA0 regex start"]
NFA116_14_11170003_0("NFA116-14 regex start")
end
subgraph DFA1_1113584933["DFA1 {1}"]
NFA116_1_33421169_1("NFA116-1 char[1]")
end
subgraph DFA2_789913925["DFA2 {1}"]
NFA116_3_32355065_2("NFA116-3 char[1]")
end
subgraph DFA3_1143990184["DFA3 {1}"]
NFA116_5_22760134_3("NFA116-5 char[1]")
end
subgraph DFA4_1084351236["DFA4 {1}"]
NFA116_7_3514615_4("NFA116-7 char[1]")
end
subgraph DFA5_-1584559850["DFA5 {1}"]
NFA116_9_31631543_5("NFA116-9 char[1]")
end
subgraph DFA6_-1970845529["DFA6 {1}"]
NFA116_11_16248438_6("NFA116-11 char[1]")
end
subgraph DFA7_-1145835423["DFA7 {1}"]
NFA116_13_12018222_7[\"NFA116-13 char[1]"/]
end
DFA0_709517201 -->|"d"|DFA1_1113584933
DFA1_1113584933 -->|"m"|DFA2_789913925
DFA2_789913925 -->|"a"|DFA3_1143990184
DFA3_1143990184 -->|"t"|DFA4_1084351236
DFA4_1084351236 -->|"4"|DFA5_-1584559850
DFA5_-1584559850 -->|"x"|DFA6_-1970845529
DFA6_-1970845529 -->|"2"|DFA7_-1145835423
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
DFA0_709517201{{"DFA0 regex start"}}
DFA1_1113584933{{"DFA1 {1}"}}
DFA2_789913925{{"DFA2 {1}"}}
DFA3_1143990184{{"DFA3 {1}"}}
DFA4_1084351236{{"DFA4 {1}"}}
DFA5_-1584559850{{"DFA5 {1}"}}
DFA6_-1970845529{{"DFA6 {1}"}}
DFA7_-1145835423[\"DFA7 {1}"/]
DFA0_709517201 -->|"d"|DFA1_1113584933
DFA1_1113584933 -->|"m"|DFA2_789913925
DFA2_789913925 -->|"a"|DFA3_1143990184
DFA3_1143990184 -->|"t"|DFA4_1084351236
DFA4_1084351236 -->|"4"|DFA5_-1584559850
DFA5_-1584559850 -->|"x"|DFA6_-1970845529
DFA6_-1970845529 -->|"2"|DFA7_-1145835423
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
subgraph MiniDFA0_-1311387592["MiniDFA0 {1}"]
DFA0_709517201_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2145762897["MiniDFA1 {1}"]
DFA1_1113584933_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1202926217["MiniDFA2 {1}"]
DFA2_789913925_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1392812447["MiniDFA3 {1}"]
DFA3_1143990184_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_179469202["MiniDFA4 {1}"]
DFA4_1084351236_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-800486883["MiniDFA5 {1}"]
DFA5_-1584559850_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-397131627["MiniDFA6 {1}"]
DFA6_-1970845529_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_825497407["MiniDFA7 {1}"]
DFA7_-1145835423_7[\"DFA7 {1}"/]
end
MiniDFA0_-1311387592 -->|"d"|MiniDFA1_-2145762897
MiniDFA1_-2145762897 -->|"m"|MiniDFA2_-1202926217
MiniDFA2_-1202926217 -->|"a"|MiniDFA3_1392812447
MiniDFA3_1392812447 -->|"t"|MiniDFA4_179469202
MiniDFA4_179469202 -->|"4"|MiniDFA5_-800486883
MiniDFA5_-800486883 -->|"x"|MiniDFA6_-397131627
MiniDFA6_-397131627 -->|"2"|MiniDFA7_825497407
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
MiniDFA0_-1311387592(["MiniDFA0 {1}"])
MiniDFA1_-2145762897(["MiniDFA1 {1}"])
MiniDFA2_-1202926217(["MiniDFA2 {1}"])
MiniDFA3_1392812447(["MiniDFA3 {1}"])
MiniDFA4_179469202(["MiniDFA4 {1}"])
MiniDFA5_-800486883(["MiniDFA5 {1}"])
MiniDFA6_-397131627(["MiniDFA6 {1}"])
MiniDFA7_825497407[\"MiniDFA7 {1}"/]
MiniDFA0_-1311387592 -->|"d"|MiniDFA1_-2145762897
MiniDFA1_-2145762897 -->|"m"|MiniDFA2_-1202926217
MiniDFA2_-1202926217 -->|"a"|MiniDFA3_1392812447
MiniDFA3_1392812447 -->|"t"|MiniDFA4_179469202
MiniDFA4_179469202 -->|"4"|MiniDFA5_-800486883
MiniDFA5_-800486883 -->|"x"|MiniDFA6_-397131627
MiniDFA6_-397131627 -->|"2"|MiniDFA7_825497407
```
-------------------------------
