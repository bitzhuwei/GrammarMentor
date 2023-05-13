# 'volatile'

pattern: `volatile`

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
eNFA69_16_41882373[["εNFA69-16 regex start"]]
eNFA69_0_41397042[["εNFA69-0 char{1, 1}"]]
eNFA69_1_37029065[["εNFA69-1 char[1]"]]
eNFA69_2_64826129[["εNFA69-2 char{1, 1}"]]
eNFA69_3_46564252[["εNFA69-3 char[1]"]]
eNFA69_4_16425092[["εNFA69-4 char{1, 1}"]]
eNFA69_5_13608105[["εNFA69-5 char[1]"]]
eNFA69_6_55364084[["εNFA69-6 char{1, 1}"]]
eNFA69_7_28514710[["εNFA69-7 char[1]"]]
eNFA69_8_55305800[["εNFA69-8 char{1, 1}"]]
eNFA69_9_27990155[["εNFA69-9 char[1]"]]
eNFA69_10_50584809[["εNFA69-10 char{1, 1}"]]
eNFA69_11_52610097[["εNFA69-11 char[1]"]]
eNFA69_12_3728830[["εNFA69-12 char{1, 1}"]]
eNFA69_13_33559471[["εNFA69-13 char[1]"]]
eNFA69_14_33599791[["εNFA69-14 char{1, 1}"]]
eNFA69_15_33962670[["εNFA69-15 char[1]"]]
eNFA69_17_37228582[["εNFA69-17 regex end"]]
eNFA69_18_66621782[["εNFA69-18 post-regex start"]]
eNFA69_19_62725128[\"εNFA69-19 post-regex end"/]
eNFA69_16_41882373 -.->|"ε"|eNFA69_0_41397042
eNFA69_0_41397042 -->|"v"|eNFA69_1_37029065
eNFA69_1_37029065 -.->|"ε"|eNFA69_2_64826129
eNFA69_2_64826129 -->|"o"|eNFA69_3_46564252
eNFA69_3_46564252 -.->|"ε"|eNFA69_4_16425092
eNFA69_4_16425092 -->|"l"|eNFA69_5_13608105
eNFA69_5_13608105 -.->|"ε"|eNFA69_6_55364084
eNFA69_6_55364084 -->|"a"|eNFA69_7_28514710
eNFA69_7_28514710 -.->|"ε"|eNFA69_8_55305800
eNFA69_8_55305800 -->|"t"|eNFA69_9_27990155
eNFA69_9_27990155 -.->|"ε"|eNFA69_10_50584809
eNFA69_10_50584809 -->|"i"|eNFA69_11_52610097
eNFA69_11_52610097 -.->|"ε"|eNFA69_12_3728830
eNFA69_12_3728830 -->|"l"|eNFA69_13_33559471
eNFA69_13_33559471 -.->|"ε"|eNFA69_14_33599791
eNFA69_14_33599791 -->|"e"|eNFA69_15_33962670
eNFA69_15_33962670 -.->|"ε"|eNFA69_17_37228582
eNFA69_17_37228582 -.->|"ε"|eNFA69_18_66621782
eNFA69_18_66621782 -.->|"ε"|eNFA69_19_62725128
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
eNFA69_16_27655246[["εNFA69-16 regex start"]]
eNFA69_0_47570623[["εNFA69-0 char{1, 1}"]]
eNFA69_1_25482430[["εNFA69-1 char[1]"]]
eNFA69_2_28015283[["εNFA69-2 char{1, 1}"]]
eNFA69_3_50810959[["εNFA69-3 char[1]"]]
eNFA69_4_54645451[["εNFA69-4 char{1, 1}"]]
eNFA69_5_22047016[["εNFA69-5 char[1]"]]
eNFA69_6_64205424[["εNFA69-6 char{1, 1}"]]
eNFA69_7_40977906[["εNFA69-7 char[1]"]]
eNFA69_8_33256841[["εNFA69-8 char{1, 1}"]]
eNFA69_9_30876117[["εNFA69-9 char[1]"]]
eNFA69_10_9449599[["εNFA69-10 char{1, 1}"]]
eNFA69_11_17937528[["εNFA69-11 char[1]"]]
eNFA69_12_27220025[["εNFA69-12 char{1, 1}"]]
eNFA69_13_43653635[["εNFA69-13 char[1]"]]
eNFA69_14_57338399[["εNFA69-14 char{1, 1}"]]
eNFA69_15_46283551[\"εNFA69-15 char[1]"/]
eNFA69_17_13898779[\"εNFA69-17 regex end"/]
eNFA69_18_57980147[\"εNFA69-18 post-regex start"/]
eNFA69_19_52059282[\"εNFA69-19 post-regex end"/]
eNFA69_16_27655246 -.->|"ε"|eNFA69_0_47570623
eNFA69_16_27655246 -->|"v"|eNFA69_1_25482430
eNFA69_0_47570623 -->|"v"|eNFA69_1_25482430
eNFA69_1_25482430 -.->|"ε"|eNFA69_2_28015283
eNFA69_1_25482430 -->|"o"|eNFA69_3_50810959
eNFA69_2_28015283 -->|"o"|eNFA69_3_50810959
eNFA69_3_50810959 -.->|"ε"|eNFA69_4_54645451
eNFA69_3_50810959 -->|"l"|eNFA69_5_22047016
eNFA69_4_54645451 -->|"l"|eNFA69_5_22047016
eNFA69_5_22047016 -.->|"ε"|eNFA69_6_64205424
eNFA69_5_22047016 -->|"a"|eNFA69_7_40977906
eNFA69_6_64205424 -->|"a"|eNFA69_7_40977906
eNFA69_7_40977906 -.->|"ε"|eNFA69_8_33256841
eNFA69_7_40977906 -->|"t"|eNFA69_9_30876117
eNFA69_8_33256841 -->|"t"|eNFA69_9_30876117
eNFA69_9_30876117 -.->|"ε"|eNFA69_10_9449599
eNFA69_9_30876117 -->|"i"|eNFA69_11_17937528
eNFA69_10_9449599 -->|"i"|eNFA69_11_17937528
eNFA69_11_17937528 -.->|"ε"|eNFA69_12_27220025
eNFA69_11_17937528 -->|"l"|eNFA69_13_43653635
eNFA69_12_27220025 -->|"l"|eNFA69_13_43653635
eNFA69_13_43653635 -.->|"ε"|eNFA69_14_57338399
eNFA69_13_43653635 -->|"e"|eNFA69_15_46283551
eNFA69_14_57338399 -->|"e"|eNFA69_15_46283551
eNFA69_15_46283551 -.->|"ε"|eNFA69_17_13898779
eNFA69_15_46283551 -.->|"ε"|eNFA69_18_57980147
eNFA69_15_46283551 -.->|"ε"|eNFA69_19_52059282
eNFA69_17_13898779 -.->|"ε"|eNFA69_18_57980147
eNFA69_17_13898779 -.->|"ε"|eNFA69_19_52059282
eNFA69_18_57980147 -.->|"ε"|eNFA69_19_52059282
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
NFA69_16_65880360("NFA69-16 regex start")
NFA69_1_56052334("NFA69-1 char[1]")
NFA69_3_34708966("NFA69-3 char[1]")
NFA69_5_43945239("NFA69-5 char[1]")
NFA69_7_59962836("NFA69-7 char[1]")
NFA69_9_2794612("NFA69-9 char[1]")
NFA69_11_25151514("NFA69-11 char[1]")
NFA69_13_25037038("NFA69-13 char[1]")
NFA69_15_24006753[\"NFA69-15 char[1]"/]
NFA69_16_65880360 -->|"v"|NFA69_1_56052334
NFA69_1_56052334 -->|"o"|NFA69_3_34708966
NFA69_3_34708966 -->|"l"|NFA69_5_43945239
NFA69_5_43945239 -->|"a"|NFA69_7_59962836
NFA69_7_59962836 -->|"t"|NFA69_9_2794612
NFA69_9_2794612 -->|"i"|NFA69_11_25151514
NFA69_11_25151514 -->|"l"|NFA69_13_25037038
NFA69_13_25037038 -->|"e"|NFA69_15_24006753
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
subgraph DFA0_1264100522["DFA0 regex start"]
NFA69_16_65880360_0("NFA69-16 regex start")
end
subgraph DFA1_-1570477257["DFA1 {1}"]
NFA69_1_56052334_1("NFA69-1 char[1]")
end
subgraph DFA2_2018920292["DFA2 {1}"]
NFA69_3_34708966_2("NFA69-3 char[1]")
end
subgraph DFA3_805039606["DFA3 {1}"]
NFA69_5_43945239_3("NFA69-5 char[1]")
end
subgraph DFA4_1927763421["DFA4 {1}"]
NFA69_7_59962836_4("NFA69-7 char[1]")
end
subgraph DFA5_-1958523596["DFA5 {1}"]
NFA69_9_2794612_5("NFA69-9 char[1]")
end
subgraph DFA6_-2079799541["DFA6 {1}"]
NFA69_11_25151514_6("NFA69-11 char[1]")
end
subgraph DFA7_1067957423["DFA7 {1}"]
NFA69_13_25037038_7("NFA69-13 char[1]")
end
subgraph DFA8_-1349920311["DFA8 {1}"]
NFA69_15_24006753_8[\"NFA69-15 char[1]"/]
end
DFA0_1264100522 -->|"v"|DFA1_-1570477257
DFA1_-1570477257 -->|"o"|DFA2_2018920292
DFA2_2018920292 -->|"l"|DFA3_805039606
DFA3_805039606 -->|"a"|DFA4_1927763421
DFA4_1927763421 -->|"t"|DFA5_-1958523596
DFA5_-1958523596 -->|"i"|DFA6_-2079799541
DFA6_-2079799541 -->|"l"|DFA7_1067957423
DFA7_1067957423 -->|"e"|DFA8_-1349920311
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
DFA0_1264100522{{"DFA0 regex start"}}
DFA1_-1570477257{{"DFA1 {1}"}}
DFA2_2018920292{{"DFA2 {1}"}}
DFA3_805039606{{"DFA3 {1}"}}
DFA4_1927763421{{"DFA4 {1}"}}
DFA5_-1958523596{{"DFA5 {1}"}}
DFA6_-2079799541{{"DFA6 {1}"}}
DFA7_1067957423{{"DFA7 {1}"}}
DFA8_-1349920311[\"DFA8 {1}"/]
DFA0_1264100522 -->|"v"|DFA1_-1570477257
DFA1_-1570477257 -->|"o"|DFA2_2018920292
DFA2_2018920292 -->|"l"|DFA3_805039606
DFA3_805039606 -->|"a"|DFA4_1927763421
DFA4_1927763421 -->|"t"|DFA5_-1958523596
DFA5_-1958523596 -->|"i"|DFA6_-2079799541
DFA6_-2079799541 -->|"l"|DFA7_1067957423
DFA7_1067957423 -->|"e"|DFA8_-1349920311
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
subgraph MiniDFA0_1480848964["MiniDFA0 {1}"]
DFA0_1264100522_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1033265549["MiniDFA1 {1}"]
DFA1_-1570477257_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-292270664["MiniDFA2 {1}"]
DFA2_2018920292_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_709470933["MiniDFA4 {1}"]
DFA3_805039606_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_2015174271["MiniDFA5 {1}"]
DFA4_1927763421_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_202672778["MiniDFA6 {1}"]
DFA5_-1958523596_5{{"DFA5 {1}"}}
end
subgraph MiniDFA3_1100836160["MiniDFA3 {1}"]
DFA6_-2079799541_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1166964841["MiniDFA7 {1}"]
DFA7_1067957423_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1016552775["MiniDFA8 {1}"]
DFA8_-1349920311_8[\"DFA8 {1}"/]
end
MiniDFA0_1480848964 -->|"v"|MiniDFA1_-1033265549
MiniDFA1_-1033265549 -->|"o"|MiniDFA2_-292270664
MiniDFA2_-292270664 -->|"l"|MiniDFA4_709470933
MiniDFA4_709470933 -->|"a"|MiniDFA5_2015174271
MiniDFA5_2015174271 -->|"t"|MiniDFA6_202672778
MiniDFA6_202672778 -->|"i"|MiniDFA3_1100836160
MiniDFA3_1100836160 -->|"l"|MiniDFA7_1166964841
MiniDFA7_1166964841 -->|"e"|MiniDFA8_-1016552775
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
MiniDFA0_1480848964(["MiniDFA0 {1}"])
MiniDFA1_-1033265549(["MiniDFA1 {1}"])
MiniDFA2_-292270664(["MiniDFA2 {1}"])
MiniDFA4_709470933(["MiniDFA4 {1}"])
MiniDFA5_2015174271(["MiniDFA5 {1}"])
MiniDFA6_202672778(["MiniDFA6 {1}"])
MiniDFA3_1100836160(["MiniDFA3 {1}"])
MiniDFA7_1166964841(["MiniDFA7 {1}"])
MiniDFA8_-1016552775[\"MiniDFA8 {1}"/]
MiniDFA0_1480848964 -->|"v"|MiniDFA1_-1033265549
MiniDFA1_-1033265549 -->|"o"|MiniDFA2_-292270664
MiniDFA2_-292270664 -->|"l"|MiniDFA4_709470933
MiniDFA4_709470933 -->|"a"|MiniDFA5_2015174271
MiniDFA5_2015174271 -->|"t"|MiniDFA6_202672778
MiniDFA6_202672778 -->|"i"|MiniDFA3_1100836160
MiniDFA3_1100836160 -->|"l"|MiniDFA7_1166964841
MiniDFA7_1166964841 -->|"e"|MiniDFA8_-1016552775
```
-------------------------------
