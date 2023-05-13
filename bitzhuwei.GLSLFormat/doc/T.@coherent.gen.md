# 'coherent'

pattern: `coherent`

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
eNFA68_16_5180964[["εNFA68-16 regex start"]]
eNFA68_0_46628683[["εNFA68-0 char{1, 1}"]]
eNFA68_1_17004965[["εNFA68-1 char[1]"]]
eNFA68_2_18826965[["εNFA68-2 char{1, 1}"]]
eNFA68_3_35224963[["εNFA68-3 char[1]"]]
eNFA68_4_48589216[["εNFA68-4 char{1, 1}"]]
eNFA68_5_34649765[["εNFA68-5 char[1]"]]
eNFA68_6_43412436[["εNFA68-6 char{1, 1}"]]
eNFA68_7_55167604[["εNFA68-7 char[1]"]]
eNFA68_8_26746391[["εNFA68-8 char{1, 1}"]]
eNFA68_9_39390935[["εNFA68-9 char[1]"]]
eNFA68_10_18974100[["εNFA68-10 char{1, 1}"]]
eNFA68_11_36549175[["εNFA68-11 char[1]"]]
eNFA68_12_60507121[["εNFA68-12 char{1, 1}"]]
eNFA68_13_7693179[["εNFA68-13 char[1]"]]
eNFA68_14_2129750[["εNFA68-14 char{1, 1}"]]
eNFA68_15_19167756[["εNFA68-15 char[1]"]]
eNFA68_17_38292076[["εNFA68-17 regex end"]]
eNFA68_18_9084369[["εNFA68-18 post-regex start"]]
eNFA68_19_14650458[\"εNFA68-19 post-regex end"/]
eNFA68_16_5180964 -.->|"ε"|eNFA68_0_46628683
eNFA68_0_46628683 -->|"c"|eNFA68_1_17004965
eNFA68_1_17004965 -.->|"ε"|eNFA68_2_18826965
eNFA68_2_18826965 -->|"o"|eNFA68_3_35224963
eNFA68_3_35224963 -.->|"ε"|eNFA68_4_48589216
eNFA68_4_48589216 -->|"h"|eNFA68_5_34649765
eNFA68_5_34649765 -.->|"ε"|eNFA68_6_43412436
eNFA68_6_43412436 -->|"e"|eNFA68_7_55167604
eNFA68_7_55167604 -.->|"ε"|eNFA68_8_26746391
eNFA68_8_26746391 -->|"r"|eNFA68_9_39390935
eNFA68_9_39390935 -.->|"ε"|eNFA68_10_18974100
eNFA68_10_18974100 -->|"e"|eNFA68_11_36549175
eNFA68_11_36549175 -.->|"ε"|eNFA68_12_60507121
eNFA68_12_60507121 -->|"n"|eNFA68_13_7693179
eNFA68_13_7693179 -.->|"ε"|eNFA68_14_2129750
eNFA68_14_2129750 -->|"t"|eNFA68_15_19167756
eNFA68_15_19167756 -.->|"ε"|eNFA68_17_38292076
eNFA68_17_38292076 -.->|"ε"|eNFA68_18_9084369
eNFA68_18_9084369 -.->|"ε"|eNFA68_19_14650458
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
eNFA68_16_64745266[["εNFA68-16 regex start"]]
eNFA68_0_45836489[["εNFA68-0 char{1, 1}"]]
eNFA68_1_9875225[["εNFA68-1 char[1]"]]
eNFA68_2_21768161[["εNFA68-2 char{1, 1}"]]
eNFA68_3_61695723[["εNFA68-3 char[1]"]]
eNFA68_4_18390601[["εNFA68-4 char{1, 1}"]]
eNFA68_5_31297682[["εNFA68-5 char[1]"]]
eNFA68_6_13243689[["εNFA68-6 char{1, 1}"]]
eNFA68_7_52084342[["εNFA68-7 char[1]"]]
eNFA68_8_66105898[["εNFA68-8 char{1, 1}"]]
eNFA68_9_58082174[["εNFA68-9 char[1]"]]
eNFA68_10_52977523[["εNFA68-10 char{1, 1}"]]
eNFA68_11_7035667[["εNFA68-11 char[1]"]]
eNFA68_12_63321005[["εNFA68-12 char{1, 1}"]]
eNFA68_13_33018140[["εNFA68-13 char[1]"]]
eNFA68_14_28727808[["εNFA68-14 char{1, 1}"]]
eNFA68_15_57223682[\"εNFA68-15 char[1]"/]
eNFA68_17_45251091[\"εNFA68-17 regex end"/]
eNFA68_18_4606636[\"εNFA68-18 post-regex start"/]
eNFA68_19_41459726[\"εNFA68-19 post-regex end"/]
eNFA68_16_64745266 -.->|"ε"|eNFA68_0_45836489
eNFA68_16_64745266 -->|"c"|eNFA68_1_9875225
eNFA68_0_45836489 -->|"c"|eNFA68_1_9875225
eNFA68_1_9875225 -.->|"ε"|eNFA68_2_21768161
eNFA68_1_9875225 -->|"o"|eNFA68_3_61695723
eNFA68_2_21768161 -->|"o"|eNFA68_3_61695723
eNFA68_3_61695723 -.->|"ε"|eNFA68_4_18390601
eNFA68_3_61695723 -->|"h"|eNFA68_5_31297682
eNFA68_4_18390601 -->|"h"|eNFA68_5_31297682
eNFA68_5_31297682 -.->|"ε"|eNFA68_6_13243689
eNFA68_5_31297682 -->|"e"|eNFA68_7_52084342
eNFA68_6_13243689 -->|"e"|eNFA68_7_52084342
eNFA68_7_52084342 -.->|"ε"|eNFA68_8_66105898
eNFA68_7_52084342 -->|"r"|eNFA68_9_58082174
eNFA68_8_66105898 -->|"r"|eNFA68_9_58082174
eNFA68_9_58082174 -.->|"ε"|eNFA68_10_52977523
eNFA68_9_58082174 -->|"e"|eNFA68_11_7035667
eNFA68_10_52977523 -->|"e"|eNFA68_11_7035667
eNFA68_11_7035667 -.->|"ε"|eNFA68_12_63321005
eNFA68_11_7035667 -->|"n"|eNFA68_13_33018140
eNFA68_12_63321005 -->|"n"|eNFA68_13_33018140
eNFA68_13_33018140 -.->|"ε"|eNFA68_14_28727808
eNFA68_13_33018140 -->|"t"|eNFA68_15_57223682
eNFA68_14_28727808 -->|"t"|eNFA68_15_57223682
eNFA68_15_57223682 -.->|"ε"|eNFA68_17_45251091
eNFA68_15_57223682 -.->|"ε"|eNFA68_18_4606636
eNFA68_15_57223682 -.->|"ε"|eNFA68_19_41459726
eNFA68_17_45251091 -.->|"ε"|eNFA68_18_4606636
eNFA68_17_45251091 -.->|"ε"|eNFA68_19_41459726
eNFA68_18_4606636 -.->|"ε"|eNFA68_19_41459726
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
NFA68_16_37593218("NFA68-16 regex start")
NFA68_1_2794650("NFA68-1 char[1]")
NFA68_3_25151854("NFA68-3 char[1]")
NFA68_5_25040094("NFA68-5 char[1]")
NFA68_7_24034261("NFA68-7 char[1]")
NFA68_9_14981763("NFA68-9 char[1]")
NFA68_11_618145("NFA68-11 char[1]")
NFA68_13_5563313("NFA68-13 char[1]")
NFA68_15_50069818[\"NFA68-15 char[1]"/]
NFA68_16_37593218 -->|"c"|NFA68_1_2794650
NFA68_1_2794650 -->|"o"|NFA68_3_25151854
NFA68_3_25151854 -->|"h"|NFA68_5_25040094
NFA68_5_25040094 -->|"e"|NFA68_7_24034261
NFA68_7_24034261 -->|"r"|NFA68_9_14981763
NFA68_9_14981763 -->|"e"|NFA68_11_618145
NFA68_11_618145 -->|"n"|NFA68_13_5563313
NFA68_13_5563313 -->|"t"|NFA68_15_50069818
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
subgraph DFA0_632190969["DFA0 regex start"]
NFA68_16_37593218_0("NFA68-16 regex start")
end
subgraph DFA1_-1077955778["DFA1 {1}"]
NFA68_1_2794650_1("NFA68-1 char[1]")
end
subgraph DFA2_242041480["DFA2 {1}"]
NFA68_3_25151854_2("NFA68-3 char[1]")
end
subgraph DFA3_-1911961493["DFA3 {1}"]
NFA68_5_25040094_3("NFA68-5 char[1]")
end
subgraph DFA4_-509114318["DFA4 {1}"]
NFA68_7_24034261_4("NFA68-7 char[1]")
end
subgraph DFA5_-1283637138["DFA5 {1}"]
NFA68_9_14981763_5("NFA68-9 char[1]")
end
subgraph DFA6_-1044931749["DFA6 {1}"]
NFA68_11_618145_6("NFA68-11 char[1]")
end
subgraph DFA7_-1266436284["DFA7 {1}"]
NFA68_13_5563313_7("NFA68-13 char[1]")
end
subgraph DFA8_207305364["DFA8 {1}"]
NFA68_15_50069818_8[\"NFA68-15 char[1]"/]
end
DFA0_632190969 -->|"c"|DFA1_-1077955778
DFA1_-1077955778 -->|"o"|DFA2_242041480
DFA2_242041480 -->|"h"|DFA3_-1911961493
DFA3_-1911961493 -->|"e"|DFA4_-509114318
DFA4_-509114318 -->|"r"|DFA5_-1283637138
DFA5_-1283637138 -->|"e"|DFA6_-1044931749
DFA6_-1044931749 -->|"n"|DFA7_-1266436284
DFA7_-1266436284 -->|"t"|DFA8_207305364
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
DFA0_632190969{{"DFA0 regex start"}}
DFA1_-1077955778{{"DFA1 {1}"}}
DFA2_242041480{{"DFA2 {1}"}}
DFA3_-1911961493{{"DFA3 {1}"}}
DFA4_-509114318{{"DFA4 {1}"}}
DFA5_-1283637138{{"DFA5 {1}"}}
DFA6_-1044931749{{"DFA6 {1}"}}
DFA7_-1266436284{{"DFA7 {1}"}}
DFA8_207305364[\"DFA8 {1}"/]
DFA0_632190969 -->|"c"|DFA1_-1077955778
DFA1_-1077955778 -->|"o"|DFA2_242041480
DFA2_242041480 -->|"h"|DFA3_-1911961493
DFA3_-1911961493 -->|"e"|DFA4_-509114318
DFA4_-509114318 -->|"r"|DFA5_-1283637138
DFA5_-1283637138 -->|"e"|DFA6_-1044931749
DFA6_-1044931749 -->|"n"|DFA7_-1266436284
DFA7_-1266436284 -->|"t"|DFA8_207305364
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
subgraph MiniDFA0_-249991691["MiniDFA0 {1}"]
DFA0_632190969_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_591982959["MiniDFA1 {1}"]
DFA1_-1077955778_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1061058489["MiniDFA2 {1}"]
DFA2_242041480_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1993152355["MiniDFA3 {1}"]
DFA3_-1911961493_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-195150903["MiniDFA5 {1}"]
DFA4_-509114318_4{{"DFA4 {1}"}}
end
subgraph MiniDFA4_2132485470["MiniDFA4 {1}"]
DFA5_-1283637138_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1456667455["MiniDFA6 {1}"]
DFA6_-1044931749_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-283961054["MiniDFA7 {1}"]
DFA7_-1266436284_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-789474325["MiniDFA8 {1}"]
DFA8_207305364_8[\"DFA8 {1}"/]
end
MiniDFA0_-249991691 -->|"c"|MiniDFA1_591982959
MiniDFA1_591982959 -->|"o"|MiniDFA2_-1061058489
MiniDFA2_-1061058489 -->|"h"|MiniDFA3_-1993152355
MiniDFA3_-1993152355 -->|"e"|MiniDFA5_-195150903
MiniDFA5_-195150903 -->|"r"|MiniDFA4_2132485470
MiniDFA4_2132485470 -->|"e"|MiniDFA6_1456667455
MiniDFA6_1456667455 -->|"n"|MiniDFA7_-283961054
MiniDFA7_-283961054 -->|"t"|MiniDFA8_-789474325
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
MiniDFA0_-249991691(["MiniDFA0 {1}"])
MiniDFA1_591982959(["MiniDFA1 {1}"])
MiniDFA2_-1061058489(["MiniDFA2 {1}"])
MiniDFA3_-1993152355(["MiniDFA3 {1}"])
MiniDFA5_-195150903(["MiniDFA5 {1}"])
MiniDFA4_2132485470(["MiniDFA4 {1}"])
MiniDFA6_1456667455(["MiniDFA6 {1}"])
MiniDFA7_-283961054(["MiniDFA7 {1}"])
MiniDFA8_-789474325[\"MiniDFA8 {1}"/]
MiniDFA0_-249991691 -->|"c"|MiniDFA1_591982959
MiniDFA1_591982959 -->|"o"|MiniDFA2_-1061058489
MiniDFA2_-1061058489 -->|"h"|MiniDFA3_-1993152355
MiniDFA3_-1993152355 -->|"e"|MiniDFA5_-195150903
MiniDFA5_-195150903 -->|"r"|MiniDFA4_2132485470
MiniDFA4_2132485470 -->|"e"|MiniDFA6_1456667455
MiniDFA6_1456667455 -->|"n"|MiniDFA7_-283961054
MiniDFA7_-283961054 -->|"t"|MiniDFA8_-789474325
```
-------------------------------
