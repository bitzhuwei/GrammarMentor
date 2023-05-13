# 'mat4x4'

pattern: `mat4x4`

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
eNFA106_12_29580916[["εNFA106-12 regex start"]]
eNFA106_0_64901660[["εNFA106-0 char{1, 1}"]]
eNFA106_1_47244029[["εNFA106-1 char[1]"]]
eNFA106_2_22543082[["εNFA106-2 char{1, 1}"]]
eNFA106_3_1561146[["εNFA106-3 char[1]"]]
eNFA106_4_14050320[["εNFA106-4 char{1, 1}"]]
eNFA106_5_59344020[["εNFA106-5 char[1]"]]
eNFA106_6_64334135[["εNFA106-6 char{1, 1}"]]
eNFA106_7_42136306[["εNFA106-7 char[1]"]]
eNFA106_8_43682438[["εNFA106-8 char{1, 1}"]]
eNFA106_9_57597629[["εNFA106-9 char[1]"]]
eNFA106_10_48616614[["εNFA106-10 char{1, 1}"]]
eNFA106_11_34896348[["εNFA106-11 char[1]"]]
eNFA106_13_45631679[["εNFA106-13 regex end"]]
eNFA106_14_8031928[["εNFA106-14 post-regex start"]]
eNFA106_15_5178488[\"εNFA106-15 post-regex end"/]
eNFA106_12_29580916 -.->|"ε"|eNFA106_0_64901660
eNFA106_0_64901660 -->|"m"|eNFA106_1_47244029
eNFA106_1_47244029 -.->|"ε"|eNFA106_2_22543082
eNFA106_2_22543082 -->|"a"|eNFA106_3_1561146
eNFA106_3_1561146 -.->|"ε"|eNFA106_4_14050320
eNFA106_4_14050320 -->|"t"|eNFA106_5_59344020
eNFA106_5_59344020 -.->|"ε"|eNFA106_6_64334135
eNFA106_6_64334135 -->|"4"|eNFA106_7_42136306
eNFA106_7_42136306 -.->|"ε"|eNFA106_8_43682438
eNFA106_8_43682438 -->|"x"|eNFA106_9_57597629
eNFA106_9_57597629 -.->|"ε"|eNFA106_10_48616614
eNFA106_10_48616614 -->|"4"|eNFA106_11_34896348
eNFA106_11_34896348 -.->|"ε"|eNFA106_13_45631679
eNFA106_13_45631679 -.->|"ε"|eNFA106_14_8031928
eNFA106_14_8031928 -.->|"ε"|eNFA106_15_5178488
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
eNFA106_12_46606392[["εNFA106-12 regex start"]]
eNFA106_0_16804345[["εNFA106-0 char{1, 1}"]]
eNFA106_1_17021380[["εNFA106-1 char[1]"]]
eNFA106_2_18974699[["εNFA106-2 char{1, 1}"]]
eNFA106_3_36554565[["εNFA106-3 char[1]"]]
eNFA106_4_60555637[["εNFA106-4 char{1, 1}"]]
eNFA106_5_8129827[["εNFA106-5 char[1]"]]
eNFA106_6_6059584[["εNFA106-6 char{1, 1}"]]
eNFA106_7_54536261[["εNFA106-7 char[1]"]]
eNFA106_8_21064308[["εNFA106-8 char{1, 1}"]]
eNFA106_9_55361044[["εNFA106-9 char[1]"]]
eNFA106_10_28487351[["εNFA106-10 char{1, 1}"]]
eNFA106_11_55059575[\"εNFA106-11 char[1]"/]
eNFA106_13_25774132[\"εNFA106-13 regex end"/]
eNFA106_14_30640599[\"εNFA106-14 post-regex start"/]
eNFA106_15_7329937[\"εNFA106-15 post-regex end"/]
eNFA106_12_46606392 -.->|"ε"|eNFA106_0_16804345
eNFA106_12_46606392 -->|"m"|eNFA106_1_17021380
eNFA106_0_16804345 -->|"m"|eNFA106_1_17021380
eNFA106_1_17021380 -.->|"ε"|eNFA106_2_18974699
eNFA106_1_17021380 -->|"a"|eNFA106_3_36554565
eNFA106_2_18974699 -->|"a"|eNFA106_3_36554565
eNFA106_3_36554565 -.->|"ε"|eNFA106_4_60555637
eNFA106_3_36554565 -->|"t"|eNFA106_5_8129827
eNFA106_4_60555637 -->|"t"|eNFA106_5_8129827
eNFA106_5_8129827 -.->|"ε"|eNFA106_6_6059584
eNFA106_5_8129827 -->|"4"|eNFA106_7_54536261
eNFA106_6_6059584 -->|"4"|eNFA106_7_54536261
eNFA106_7_54536261 -.->|"ε"|eNFA106_8_21064308
eNFA106_7_54536261 -->|"x"|eNFA106_9_55361044
eNFA106_8_21064308 -->|"x"|eNFA106_9_55361044
eNFA106_9_55361044 -.->|"ε"|eNFA106_10_28487351
eNFA106_9_55361044 -->|"4"|eNFA106_11_55059575
eNFA106_10_28487351 -->|"4"|eNFA106_11_55059575
eNFA106_11_55059575 -.->|"ε"|eNFA106_13_25774132
eNFA106_11_55059575 -.->|"ε"|eNFA106_14_30640599
eNFA106_11_55059575 -.->|"ε"|eNFA106_15_7329937
eNFA106_13_25774132 -.->|"ε"|eNFA106_14_30640599
eNFA106_13_25774132 -.->|"ε"|eNFA106_15_7329937
eNFA106_14_30640599 -.->|"ε"|eNFA106_15_7329937
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
NFA106_12_65969435("NFA106-12 regex start")
NFA106_1_56854006("NFA106-1 char[1]")
NFA106_3_41924012("NFA106-3 char[1]")
NFA106_5_41771788("NFA106-5 char[1]")
NFA106_7_40401777("NFA106-7 char[1]")
NFA106_9_28071674("NFA106-9 char[1]")
NFA106_11_51318482[\"NFA106-11 char[1]"/]
NFA106_12_65969435 -->|"m"|NFA106_1_56854006
NFA106_1_56854006 -->|"a"|NFA106_3_41924012
NFA106_3_41924012 -->|"t"|NFA106_5_41771788
NFA106_5_41771788 -->|"4"|NFA106_7_40401777
NFA106_7_40401777 -->|"x"|NFA106_9_28071674
NFA106_9_28071674 -->|"4"|NFA106_11_51318482
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
subgraph DFA0_1770342034["DFA0 regex start"]
NFA106_12_65969435_0("NFA106-12 regex start")
end
subgraph DFA1_2047350820["DFA1 {1}"]
NFA106_1_56854006_1("NFA106-1 char[1]")
end
subgraph DFA2_399922778["DFA2 {1}"]
NFA106_3_41924012_2("NFA106-3 char[1]")
end
subgraph DFA3_-449907406["DFA3 {1}"]
NFA106_5_41771788_3("NFA106-5 char[1]")
end
subgraph DFA4_459193285["DFA4 {1}"]
NFA106_7_40401777_4("NFA106-7 char[1]")
end
subgraph DFA5_-784178591["DFA5 {1}"]
NFA106_9_28071674_5("NFA106-9 char[1]")
end
subgraph DFA6_218245753["DFA6 {1}"]
NFA106_11_51318482_6[\"NFA106-11 char[1]"/]
end
DFA0_1770342034 -->|"m"|DFA1_2047350820
DFA1_2047350820 -->|"a"|DFA2_399922778
DFA2_399922778 -->|"t"|DFA3_-449907406
DFA3_-449907406 -->|"4"|DFA4_459193285
DFA4_459193285 -->|"x"|DFA5_-784178591
DFA5_-784178591 -->|"4"|DFA6_218245753
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
DFA0_1770342034{{"DFA0 regex start"}}
DFA1_2047350820{{"DFA1 {1}"}}
DFA2_399922778{{"DFA2 {1}"}}
DFA3_-449907406{{"DFA3 {1}"}}
DFA4_459193285{{"DFA4 {1}"}}
DFA5_-784178591{{"DFA5 {1}"}}
DFA6_218245753[\"DFA6 {1}"/]
DFA0_1770342034 -->|"m"|DFA1_2047350820
DFA1_2047350820 -->|"a"|DFA2_399922778
DFA2_399922778 -->|"t"|DFA3_-449907406
DFA3_-449907406 -->|"4"|DFA4_459193285
DFA4_459193285 -->|"x"|DFA5_-784178591
DFA5_-784178591 -->|"4"|DFA6_218245753
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
subgraph MiniDFA0_-1016813632["MiniDFA0 {1}"]
DFA0_1770342034_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2096904540["MiniDFA1 {1}"]
DFA1_2047350820_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-899281977["MiniDFA2 {1}"]
DFA2_399922778_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1294164281["MiniDFA3 {1}"]
DFA3_-449907406_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1595554950["MiniDFA4 {1}"]
DFA4_459193285_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1276564800["MiniDFA5 {1}"]
DFA5_-784178591_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1310694731["MiniDFA6 {1}"]
DFA6_218245753_6[\"DFA6 {1}"/]
end
MiniDFA0_-1016813632 -->|"m"|MiniDFA1_-2096904540
MiniDFA1_-2096904540 -->|"a"|MiniDFA2_-899281977
MiniDFA2_-899281977 -->|"t"|MiniDFA3_-1294164281
MiniDFA3_-1294164281 -->|"4"|MiniDFA4_-1595554950
MiniDFA4_-1595554950 -->|"x"|MiniDFA5_1276564800
MiniDFA5_1276564800 -->|"4"|MiniDFA6_-1310694731
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
MiniDFA0_-1016813632(["MiniDFA0 {1}"])
MiniDFA1_-2096904540(["MiniDFA1 {1}"])
MiniDFA2_-899281977(["MiniDFA2 {1}"])
MiniDFA3_-1294164281(["MiniDFA3 {1}"])
MiniDFA4_-1595554950(["MiniDFA4 {1}"])
MiniDFA5_1276564800(["MiniDFA5 {1}"])
MiniDFA6_-1310694731[\"MiniDFA6 {1}"/]
MiniDFA0_-1016813632 -->|"m"|MiniDFA1_-2096904540
MiniDFA1_-2096904540 -->|"a"|MiniDFA2_-899281977
MiniDFA2_-899281977 -->|"t"|MiniDFA3_-1294164281
MiniDFA3_-1294164281 -->|"4"|MiniDFA4_-1595554950
MiniDFA4_-1595554950 -->|"x"|MiniDFA5_1276564800
MiniDFA5_1276564800 -->|"4"|MiniDFA6_-1310694731
```
-------------------------------
