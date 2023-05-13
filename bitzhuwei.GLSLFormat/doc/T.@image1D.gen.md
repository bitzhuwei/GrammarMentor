# 'image1D'

pattern: `image1D`

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
eNFA160_14_12830622[["εNFA160-14 regex start"]]
eNFA160_0_48366737[["εNFA160-0 char{1, 1}"]]
eNFA160_1_32647452[["εNFA160-1 char[1]"]]
eNFA160_2_25391616[["εNFA160-2 char{1, 1}"]]
eNFA160_3_27197959[["εNFA160-3 char[1]"]]
eNFA160_4_43455040[["εNFA160-4 char{1, 1}"]]
eNFA160_5_55551046[["εNFA160-5 char[1]"]]
eNFA160_6_30197369[["εNFA160-6 char{1, 1}"]]
eNFA160_7_3340866[["εNFA160-7 char[1]"]]
eNFA160_8_30067794[["εNFA160-8 char{1, 1}"]]
eNFA160_9_2174690[["εNFA160-9 char[1]"]]
eNFA160_10_19572211[["εNFA160-10 char{1, 1}"]]
eNFA160_11_41932174[["εNFA160-11 char[1]"]]
eNFA160_12_41845253[["εNFA160-12 char{1, 1}"]]
eNFA160_13_41062959[["εNFA160-13 char[1]"]]
eNFA160_15_34022319[["εNFA160-15 regex end"]]
eNFA160_16_37765421[["εNFA160-16 post-regex start"]]
eNFA160_17_4344474[\"εNFA160-17 post-regex end"/]
eNFA160_14_12830622 -.->|"ε"|eNFA160_0_48366737
eNFA160_0_48366737 -->|"i"|eNFA160_1_32647452
eNFA160_1_32647452 -.->|"ε"|eNFA160_2_25391616
eNFA160_2_25391616 -->|"m"|eNFA160_3_27197959
eNFA160_3_27197959 -.->|"ε"|eNFA160_4_43455040
eNFA160_4_43455040 -->|"a"|eNFA160_5_55551046
eNFA160_5_55551046 -.->|"ε"|eNFA160_6_30197369
eNFA160_6_30197369 -->|"g"|eNFA160_7_3340866
eNFA160_7_3340866 -.->|"ε"|eNFA160_8_30067794
eNFA160_8_30067794 -->|"e"|eNFA160_9_2174690
eNFA160_9_2174690 -.->|"ε"|eNFA160_10_19572211
eNFA160_10_19572211 -->|"1"|eNFA160_11_41932174
eNFA160_11_41932174 -.->|"ε"|eNFA160_12_41845253
eNFA160_12_41845253 -->|"D"|eNFA160_13_41062959
eNFA160_13_41062959 -.->|"ε"|eNFA160_15_34022319
eNFA160_15_34022319 -.->|"ε"|eNFA160_16_37765421
eNFA160_16_37765421 -.->|"ε"|eNFA160_17_4344474
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
eNFA160_14_39100271[["εNFA160-14 regex start"]]
eNFA160_0_16358126[["εNFA160-0 char{1, 1}"]]
eNFA160_1_13005406[["εNFA160-1 char[1]"]]
eNFA160_2_49939793[["εNFA160-2 char{1, 1}"]]
eNFA160_3_46804961[["εNFA160-3 char[1]"]]
eNFA160_4_18591470[["εNFA160-4 char{1, 1}"]]
eNFA160_5_33105505[["εNFA160-5 char[1]"]]
eNFA160_6_29514091[["εNFA160-6 char{1, 1}"]]
eNFA160_7_64300229[["εNFA160-7 char[1]"]]
eNFA160_8_41831152[["εNFA160-8 char{1, 1}"]]
eNFA160_9_40936054[["εNFA160-9 char[1]"]]
eNFA160_10_32880166[["εNFA160-10 char{1, 1}"]]
eNFA160_11_27486043[["εNFA160-11 char[1]"]]
eNFA160_12_46047796[["εNFA160-12 char{1, 1}"]]
eNFA160_13_11776988[\"εNFA160-13 char[1]"/]
eNFA160_15_38884035[\"εNFA160-15 regex end"/]
eNFA160_16_14412003[\"εNFA160-16 post-regex start"/]
eNFA160_17_62599163[\"εNFA160-17 post-regex end"/]
eNFA160_14_39100271 -.->|"ε"|eNFA160_0_16358126
eNFA160_14_39100271 -->|"i"|eNFA160_1_13005406
eNFA160_0_16358126 -->|"i"|eNFA160_1_13005406
eNFA160_1_13005406 -.->|"ε"|eNFA160_2_49939793
eNFA160_1_13005406 -->|"m"|eNFA160_3_46804961
eNFA160_2_49939793 -->|"m"|eNFA160_3_46804961
eNFA160_3_46804961 -.->|"ε"|eNFA160_4_18591470
eNFA160_3_46804961 -->|"a"|eNFA160_5_33105505
eNFA160_4_18591470 -->|"a"|eNFA160_5_33105505
eNFA160_5_33105505 -.->|"ε"|eNFA160_6_29514091
eNFA160_5_33105505 -->|"g"|eNFA160_7_64300229
eNFA160_6_29514091 -->|"g"|eNFA160_7_64300229
eNFA160_7_64300229 -.->|"ε"|eNFA160_8_41831152
eNFA160_7_64300229 -->|"e"|eNFA160_9_40936054
eNFA160_8_41831152 -->|"e"|eNFA160_9_40936054
eNFA160_9_40936054 -.->|"ε"|eNFA160_10_32880166
eNFA160_9_40936054 -->|"1"|eNFA160_11_27486043
eNFA160_10_32880166 -->|"1"|eNFA160_11_27486043
eNFA160_11_27486043 -.->|"ε"|eNFA160_12_46047796
eNFA160_11_27486043 -->|"D"|eNFA160_13_11776988
eNFA160_12_46047796 -->|"D"|eNFA160_13_11776988
eNFA160_13_11776988 -.->|"ε"|eNFA160_15_38884035
eNFA160_13_11776988 -.->|"ε"|eNFA160_16_14412003
eNFA160_13_11776988 -.->|"ε"|eNFA160_17_62599163
eNFA160_15_38884035 -.->|"ε"|eNFA160_16_14412003
eNFA160_15_38884035 -.->|"ε"|eNFA160_17_62599163
eNFA160_16_14412003 -.->|"ε"|eNFA160_17_62599163
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
NFA160_14_26521557("NFA160-14 regex start")
NFA160_1_37367427("NFA160-1 char[1]")
NFA160_3_762524("NFA160-3 char[1]")
NFA160_5_6862723("NFA160-5 char[1]")
NFA160_7_61764512("NFA160-7 char[1]")
NFA160_9_19009700("NFA160-9 char[1]")
NFA160_11_36869576("NFA160-11 char[1]")
NFA160_13_63390733[\"NFA160-13 char[1]"/]
NFA160_14_26521557 -->|"i"|NFA160_1_37367427
NFA160_1_37367427 -->|"m"|NFA160_3_762524
NFA160_3_762524 -->|"a"|NFA160_5_6862723
NFA160_5_6862723 -->|"g"|NFA160_7_61764512
NFA160_7_61764512 -->|"e"|NFA160_9_19009700
NFA160_9_19009700 -->|"1"|NFA160_11_36869576
NFA160_11_36869576 -->|"D"|NFA160_13_63390733
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
subgraph DFA0_856094179["DFA0 regex start"]
NFA160_14_26521557_0("NFA160-14 regex start")
end
subgraph DFA1_1843097001["DFA1 {1}"]
NFA160_1_37367427_1("NFA160-1 char[1]")
end
subgraph DFA2_1180309230["DFA2 {1}"]
NFA160_3_762524_2("NFA160-3 char[1]")
end
subgraph DFA3_847361398["DFA3 {1}"]
NFA160_5_6862723_3("NFA160-5 char[1]")
end
subgraph DFA4_-1956310648["DFA4 {1}"]
NFA160_7_61764512_4("NFA160-7 char[1]")
end
subgraph DFA5_183820522["DFA5 {1}"]
NFA160_9_19009700_5("NFA160-9 char[1]")
end
subgraph DFA6_-2131038585["DFA6 {1}"]
NFA160_11_36869576_6("NFA160-11 char[1]")
end
subgraph DFA7_426755542["DFA7 {1}"]
NFA160_13_63390733_7[\"NFA160-13 char[1]"/]
end
DFA0_856094179 -->|"i"|DFA1_1843097001
DFA1_1843097001 -->|"m"|DFA2_1180309230
DFA2_1180309230 -->|"a"|DFA3_847361398
DFA3_847361398 -->|"g"|DFA4_-1956310648
DFA4_-1956310648 -->|"e"|DFA5_183820522
DFA5_183820522 -->|"1"|DFA6_-2131038585
DFA6_-2131038585 -->|"D"|DFA7_426755542
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
DFA0_856094179{{"DFA0 regex start"}}
DFA1_1843097001{{"DFA1 {1}"}}
DFA2_1180309230{{"DFA2 {1}"}}
DFA3_847361398{{"DFA3 {1}"}}
DFA4_-1956310648{{"DFA4 {1}"}}
DFA5_183820522{{"DFA5 {1}"}}
DFA6_-2131038585{{"DFA6 {1}"}}
DFA7_426755542[\"DFA7 {1}"/]
DFA0_856094179 -->|"i"|DFA1_1843097001
DFA1_1843097001 -->|"m"|DFA2_1180309230
DFA2_1180309230 -->|"a"|DFA3_847361398
DFA3_847361398 -->|"g"|DFA4_-1956310648
DFA4_-1956310648 -->|"e"|DFA5_183820522
DFA5_183820522 -->|"1"|DFA6_-2131038585
DFA6_-2131038585 -->|"D"|DFA7_426755542
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
subgraph MiniDFA0_1737149011["MiniDFA0 {1}"]
DFA0_856094179_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1691167369["MiniDFA1 {1}"]
DFA1_1843097001_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1239858820["MiniDFA2 {1}"]
DFA2_1180309230_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_2054831551["MiniDFA3 {1}"]
DFA3_847361398_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1819807548["MiniDFA4 {1}"]
DFA4_-1956310648_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-242956290["MiniDFA5 {1}"]
DFA5_183820522_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_928598543["MiniDFA6 {1}"]
DFA6_-2131038585_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1336902090["MiniDFA7 {1}"]
DFA7_426755542_7[\"DFA7 {1}"/]
end
MiniDFA0_1737149011 -->|"i"|MiniDFA1_-1691167369
MiniDFA1_-1691167369 -->|"m"|MiniDFA2_-1239858820
MiniDFA2_-1239858820 -->|"a"|MiniDFA3_2054831551
MiniDFA3_2054831551 -->|"g"|MiniDFA4_-1819807548
MiniDFA4_-1819807548 -->|"e"|MiniDFA5_-242956290
MiniDFA5_-242956290 -->|"1"|MiniDFA6_928598543
MiniDFA6_928598543 -->|"D"|MiniDFA7_1336902090
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
MiniDFA0_1737149011(["MiniDFA0 {1}"])
MiniDFA1_-1691167369(["MiniDFA1 {1}"])
MiniDFA2_-1239858820(["MiniDFA2 {1}"])
MiniDFA3_2054831551(["MiniDFA3 {1}"])
MiniDFA4_-1819807548(["MiniDFA4 {1}"])
MiniDFA5_-242956290(["MiniDFA5 {1}"])
MiniDFA6_928598543(["MiniDFA6 {1}"])
MiniDFA7_1336902090[\"MiniDFA7 {1}"/]
MiniDFA0_1737149011 -->|"i"|MiniDFA1_-1691167369
MiniDFA1_-1691167369 -->|"m"|MiniDFA2_-1239858820
MiniDFA2_-1239858820 -->|"a"|MiniDFA3_2054831551
MiniDFA3_2054831551 -->|"g"|MiniDFA4_-1819807548
MiniDFA4_-1819807548 -->|"e"|MiniDFA5_-242956290
MiniDFA5_-242956290 -->|"1"|MiniDFA6_928598543
MiniDFA6_928598543 -->|"D"|MiniDFA7_1336902090
```
-------------------------------
