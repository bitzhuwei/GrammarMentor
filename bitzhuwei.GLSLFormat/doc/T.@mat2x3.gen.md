# 'mat2x3'

pattern: `mat2x3`

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
eNFA99_12_51034272[["εNFA99-12 regex start"]]
eNFA99_0_56655270[["εNFA99-0 char{1, 1}"]]
eNFA99_1_40135390[["εNFA99-1 char[1]"]]
eNFA99_2_25674191[["εNFA99-2 char{1, 1}"]]
eNFA99_3_29741132[["εNFA99-3 char[1]"]]
eNFA99_4_66343596[["εNFA99-4 char{1, 1}"]]
eNFA99_5_60221458[["εNFA99-5 char[1]"]]
eNFA99_6_5122214[["εNFA99-6 char{1, 1}"]]
eNFA99_7_46099929[["εNFA99-7 char[1]"]]
eNFA99_8_12246180[["εNFA99-8 char{1, 1}"]]
eNFA99_9_43106760[["εNFA99-9 char[1]"]]
eNFA99_10_52416527[["εNFA99-10 char{1, 1}"]]
eNFA99_11_1986696[["εNFA99-11 char[1]"]]
eNFA99_13_17880270[["εNFA99-13 regex end"]]
eNFA99_14_26704705[["εNFA99-14 post-regex start"]]
eNFA99_15_39015754[\"εNFA99-15 post-regex end"/]
eNFA99_12_51034272 -.->|"ε"|eNFA99_0_56655270
eNFA99_0_56655270 -->|"m"|eNFA99_1_40135390
eNFA99_1_40135390 -.->|"ε"|eNFA99_2_25674191
eNFA99_2_25674191 -->|"a"|eNFA99_3_29741132
eNFA99_3_29741132 -.->|"ε"|eNFA99_4_66343596
eNFA99_4_66343596 -->|"t"|eNFA99_5_60221458
eNFA99_5_60221458 -.->|"ε"|eNFA99_6_5122214
eNFA99_6_5122214 -->|"2"|eNFA99_7_46099929
eNFA99_7_46099929 -.->|"ε"|eNFA99_8_12246180
eNFA99_8_12246180 -->|"x"|eNFA99_9_43106760
eNFA99_9_43106760 -.->|"ε"|eNFA99_10_52416527
eNFA99_10_52416527 -->|"3"|eNFA99_11_1986696
eNFA99_11_1986696 -.->|"ε"|eNFA99_13_17880270
eNFA99_13_17880270 -.->|"ε"|eNFA99_14_26704705
eNFA99_14_26704705 -.->|"ε"|eNFA99_15_39015754
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
eNFA99_12_15597466[["εNFA99-12 regex start"]]
eNFA99_0_6159466[["εNFA99-0 char{1, 1}"]]
eNFA99_1_55435195[["εNFA99-1 char[1]"]]
eNFA99_2_29154710[["εNFA99-2 char{1, 1}"]]
eNFA99_3_61065805[["εNFA99-3 char[1]"]]
eNFA99_4_12721335[["εNFA99-4 char{1, 1}"]]
eNFA99_5_47383159[["εNFA99-5 char[1]"]]
eNFA99_6_23795253[["εNFA99-6 char{1, 1}"]]
eNFA99_7_12830690[["εNFA99-7 char[1]"]]
eNFA99_8_48367351[["εNFA99-8 char{1, 1}"]]
eNFA99_9_32652982[["εNFA99-9 char[1]"]]
eNFA99_10_25441382[["εNFA99-10 char{1, 1}"]]
eNFA99_11_27645849[\"εNFA99-11 char[1]"/]
eNFA99_13_47486057[\"εNFA99-13 regex end"/]
eNFA99_14_24721334[\"εNFA99-14 post-regex start"/]
eNFA99_15_21165417[\"εNFA99-15 post-regex end"/]
eNFA99_12_15597466 -.->|"ε"|eNFA99_0_6159466
eNFA99_12_15597466 -->|"m"|eNFA99_1_55435195
eNFA99_0_6159466 -->|"m"|eNFA99_1_55435195
eNFA99_1_55435195 -.->|"ε"|eNFA99_2_29154710
eNFA99_1_55435195 -->|"a"|eNFA99_3_61065805
eNFA99_2_29154710 -->|"a"|eNFA99_3_61065805
eNFA99_3_61065805 -.->|"ε"|eNFA99_4_12721335
eNFA99_3_61065805 -->|"t"|eNFA99_5_47383159
eNFA99_4_12721335 -->|"t"|eNFA99_5_47383159
eNFA99_5_47383159 -.->|"ε"|eNFA99_6_23795253
eNFA99_5_47383159 -->|"2"|eNFA99_7_12830690
eNFA99_6_23795253 -->|"2"|eNFA99_7_12830690
eNFA99_7_12830690 -.->|"ε"|eNFA99_8_48367351
eNFA99_7_12830690 -->|"x"|eNFA99_9_32652982
eNFA99_8_48367351 -->|"x"|eNFA99_9_32652982
eNFA99_9_32652982 -.->|"ε"|eNFA99_10_25441382
eNFA99_9_32652982 -->|"3"|eNFA99_11_27645849
eNFA99_10_25441382 -->|"3"|eNFA99_11_27645849
eNFA99_11_27645849 -.->|"ε"|eNFA99_13_47486057
eNFA99_11_27645849 -.->|"ε"|eNFA99_14_24721334
eNFA99_11_27645849 -.->|"ε"|eNFA99_15_21165417
eNFA99_13_47486057 -.->|"ε"|eNFA99_14_24721334
eNFA99_13_47486057 -.->|"ε"|eNFA99_15_21165417
eNFA99_14_24721334 -.->|"ε"|eNFA99_15_21165417
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
NFA99_12_56271027("NFA99-12 regex start")
NFA99_1_36677197("NFA99-1 char[1]")
NFA99_3_61659320("NFA99-3 char[1]")
NFA99_5_18062974("NFA99-5 char[1]")
NFA99_7_28349038("NFA99-7 char[1]")
NFA99_9_53814755("NFA99-9 char[1]")
NFA99_11_14570748[\"NFA99-11 char[1]"/]
NFA99_12_56271027 -->|"m"|NFA99_1_36677197
NFA99_1_36677197 -->|"a"|NFA99_3_61659320
NFA99_3_61659320 -->|"t"|NFA99_5_18062974
NFA99_5_18062974 -->|"2"|NFA99_7_28349038
NFA99_7_28349038 -->|"x"|NFA99_9_53814755
NFA99_9_53814755 -->|"3"|NFA99_11_14570748
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
subgraph DFA0_-1097336387["DFA0 regex start"]
NFA99_12_56271027_0("NFA99-12 regex start")
end
subgraph DFA1_-571064770["DFA1 {1}"]
NFA99_1_36677197_1("NFA99-1 char[1]")
end
subgraph DFA2_1023795364["DFA2 {1}"]
NFA99_3_61659320_2("NFA99-3 char[1]")
end
subgraph DFA3_843138657["DFA3 {1}"]
NFA99_5_18062974_3("NFA99-5 char[1]")
end
subgraph DFA4_-844885143["DFA4 {1}"]
NFA99_7_28349038_4("NFA99-7 char[1]")
end
subgraph DFA5_-1278212085["DFA5 {1}"]
NFA99_9_53814755_5("NFA99-9 char[1]")
end
subgraph DFA6_1967360267["DFA6 {1}"]
NFA99_11_14570748_6[\"NFA99-11 char[1]"/]
end
DFA0_-1097336387 -->|"m"|DFA1_-571064770
DFA1_-571064770 -->|"a"|DFA2_1023795364
DFA2_1023795364 -->|"t"|DFA3_843138657
DFA3_843138657 -->|"2"|DFA4_-844885143
DFA4_-844885143 -->|"x"|DFA5_-1278212085
DFA5_-1278212085 -->|"3"|DFA6_1967360267
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
DFA0_-1097336387{{"DFA0 regex start"}}
DFA1_-571064770{{"DFA1 {1}"}}
DFA2_1023795364{{"DFA2 {1}"}}
DFA3_843138657{{"DFA3 {1}"}}
DFA4_-844885143{{"DFA4 {1}"}}
DFA5_-1278212085{{"DFA5 {1}"}}
DFA6_1967360267[\"DFA6 {1}"/]
DFA0_-1097336387 -->|"m"|DFA1_-571064770
DFA1_-571064770 -->|"a"|DFA2_1023795364
DFA2_1023795364 -->|"t"|DFA3_843138657
DFA3_843138657 -->|"2"|DFA4_-844885143
DFA4_-844885143 -->|"x"|DFA5_-1278212085
DFA5_-1278212085 -->|"3"|DFA6_1967360267
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
subgraph MiniDFA0_1525543100["MiniDFA0 {1}"]
DFA0_-1097336387_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_638259131["MiniDFA1 {1}"]
DFA1_-571064770_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_847823967["MiniDFA2 {1}"]
DFA2_1023795364_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1324881500["MiniDFA3 {1}"]
DFA3_843138657_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1686835208["MiniDFA4 {1}"]
DFA4_-844885143_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1219511566["MiniDFA5 {1}"]
DFA5_-1278212085_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1920267221["MiniDFA6 {1}"]
DFA6_1967360267_6[\"DFA6 {1}"/]
end
MiniDFA0_1525543100 -->|"m"|MiniDFA1_638259131
MiniDFA1_638259131 -->|"a"|MiniDFA2_847823967
MiniDFA2_847823967 -->|"t"|MiniDFA3_-1324881500
MiniDFA3_-1324881500 -->|"2"|MiniDFA4_-1686835208
MiniDFA4_-1686835208 -->|"x"|MiniDFA5_1219511566
MiniDFA5_1219511566 -->|"3"|MiniDFA6_-1920267221
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
MiniDFA0_1525543100(["MiniDFA0 {1}"])
MiniDFA1_638259131(["MiniDFA1 {1}"])
MiniDFA2_847823967(["MiniDFA2 {1}"])
MiniDFA3_-1324881500(["MiniDFA3 {1}"])
MiniDFA4_-1686835208(["MiniDFA4 {1}"])
MiniDFA5_1219511566(["MiniDFA5 {1}"])
MiniDFA6_-1920267221[\"MiniDFA6 {1}"/]
MiniDFA0_1525543100 -->|"m"|MiniDFA1_638259131
MiniDFA1_638259131 -->|"a"|MiniDFA2_847823967
MiniDFA2_847823967 -->|"t"|MiniDFA3_-1324881500
MiniDFA3_-1324881500 -->|"2"|MiniDFA4_-1686835208
MiniDFA4_-1686835208 -->|"x"|MiniDFA5_1219511566
MiniDFA5_1219511566 -->|"3"|MiniDFA6_-1920267221
```
-------------------------------
