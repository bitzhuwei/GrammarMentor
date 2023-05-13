# 'layout'

pattern: `layout`

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
eNFA56_12_63687823[["εNFA56-12 regex start"]]
eNFA56_0_36319496[["εNFA56-0 char{1, 1}"]]
eNFA56_1_58440016[["εNFA56-1 char[1]"]]
eNFA56_2_56198103[["εNFA56-2 char{1, 1}"]]
eNFA56_3_36020887[["εNFA56-3 char[1]"]]
eNFA56_4_55752527[["εNFA56-4 char{1, 1}"]]
eNFA56_5_32010697[["εNFA56-5 char[1]"]]
eNFA56_6_19660823[["εNFA56-6 char{1, 1}"]]
eNFA56_7_42729680[["εNFA56-7 char[1]"]]
eNFA56_8_49022807[["εNFA56-8 char{1, 1}"]]
eNFA56_9_38552084[["εNFA56-9 char[1]"]]
eNFA56_10_11424440[["εNFA56-10 char{1, 1}"]]
eNFA56_11_35711100[["εNFA56-11 char[1]"]]
eNFA56_13_52964449[["εNFA56-13 regex end"]]
eNFA56_14_6918001[["εNFA56-14 post-regex start"]]
eNFA56_15_62262011[\"εNFA56-15 post-regex end"/]
eNFA56_12_63687823 -.->|"ε"|eNFA56_0_36319496
eNFA56_0_36319496 -->|"l"|eNFA56_1_58440016
eNFA56_1_58440016 -.->|"ε"|eNFA56_2_56198103
eNFA56_2_56198103 -->|"a"|eNFA56_3_36020887
eNFA56_3_36020887 -.->|"ε"|eNFA56_4_55752527
eNFA56_4_55752527 -->|"y"|eNFA56_5_32010697
eNFA56_5_32010697 -.->|"ε"|eNFA56_6_19660823
eNFA56_6_19660823 -->|"o"|eNFA56_7_42729680
eNFA56_7_42729680 -.->|"ε"|eNFA56_8_49022807
eNFA56_8_49022807 -->|"u"|eNFA56_9_38552084
eNFA56_9_38552084 -.->|"ε"|eNFA56_10_11424440
eNFA56_10_11424440 -->|"t"|eNFA56_11_35711100
eNFA56_11_35711100 -.->|"ε"|eNFA56_13_52964449
eNFA56_13_52964449 -.->|"ε"|eNFA56_14_6918001
eNFA56_14_6918001 -.->|"ε"|eNFA56_15_62262011
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
eNFA56_12_23487194[["εNFA56-12 regex start"]]
eNFA56_0_10058158[["εNFA56-0 char{1, 1}"]]
eNFA56_1_23414560[["εNFA56-1 char[1]"]]
eNFA56_2_9404449[["εNFA56-2 char{1, 1}"]]
eNFA56_3_17531178[["εNFA56-3 char[1]"]]
eNFA56_4_23562876[["εNFA56-4 char{1, 1}"]]
eNFA56_5_10739296[["εNFA56-5 char[1]"]]
eNFA56_6_29544808[["εNFA56-6 char{1, 1}"]]
eNFA56_7_64576684[["εNFA56-7 char[1]"]]
eNFA56_8_44319244[["εNFA56-8 char{1, 1}"]]
eNFA56_9_63328883[["εNFA56-9 char[1]"]]
eNFA56_10_33089041[["εNFA56-10 char{1, 1}"]]
eNFA56_11_29365919[\"εNFA56-11 char[1]"/]
eNFA56_13_62966687[\"εNFA56-13 regex end"/]
eNFA56_14_29829272[\"εNFA56-14 post-regex start"/]
eNFA56_15_27997[\"εNFA56-15 post-regex end"/]
eNFA56_12_23487194 -.->|"ε"|eNFA56_0_10058158
eNFA56_12_23487194 -->|"l"|eNFA56_1_23414560
eNFA56_0_10058158 -->|"l"|eNFA56_1_23414560
eNFA56_1_23414560 -.->|"ε"|eNFA56_2_9404449
eNFA56_1_23414560 -->|"a"|eNFA56_3_17531178
eNFA56_2_9404449 -->|"a"|eNFA56_3_17531178
eNFA56_3_17531178 -.->|"ε"|eNFA56_4_23562876
eNFA56_3_17531178 -->|"y"|eNFA56_5_10739296
eNFA56_4_23562876 -->|"y"|eNFA56_5_10739296
eNFA56_5_10739296 -.->|"ε"|eNFA56_6_29544808
eNFA56_5_10739296 -->|"o"|eNFA56_7_64576684
eNFA56_6_29544808 -->|"o"|eNFA56_7_64576684
eNFA56_7_64576684 -.->|"ε"|eNFA56_8_44319244
eNFA56_7_64576684 -->|"u"|eNFA56_9_63328883
eNFA56_8_44319244 -->|"u"|eNFA56_9_63328883
eNFA56_9_63328883 -.->|"ε"|eNFA56_10_33089041
eNFA56_9_63328883 -->|"t"|eNFA56_11_29365919
eNFA56_10_33089041 -->|"t"|eNFA56_11_29365919
eNFA56_11_29365919 -.->|"ε"|eNFA56_13_62966687
eNFA56_11_29365919 -.->|"ε"|eNFA56_14_29829272
eNFA56_11_29365919 -.->|"ε"|eNFA56_15_27997
eNFA56_13_62966687 -.->|"ε"|eNFA56_14_29829272
eNFA56_13_62966687 -.->|"ε"|eNFA56_15_27997
eNFA56_14_29829272 -.->|"ε"|eNFA56_15_27997
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
NFA56_12_251973("NFA56-12 regex start")
NFA56_1_2267763("NFA56-1 char[1]")
NFA56_3_20409871("NFA56-3 char[1]")
NFA56_5_49471114("NFA56-5 char[1]")
NFA56_7_42586845("NFA56-7 char[1]")
NFA56_9_47737289("NFA56-9 char[1]")
NFA56_11_26982424[\"NFA56-11 char[1]"/]
NFA56_12_251973 -->|"l"|NFA56_1_2267763
NFA56_1_2267763 -->|"a"|NFA56_3_20409871
NFA56_3_20409871 -->|"y"|NFA56_5_49471114
NFA56_5_49471114 -->|"o"|NFA56_7_42586845
NFA56_7_42586845 -->|"u"|NFA56_9_47737289
NFA56_9_47737289 -->|"t"|NFA56_11_26982424
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
subgraph DFA0_-173424413["DFA0 regex start"]
NFA56_12_251973_0("NFA56-12 regex start")
end
subgraph DFA1_1579461189["DFA1 {1}"]
NFA56_1_2267763_1("NFA56-1 char[1]")
end
subgraph DFA2_-713074302["DFA2 {1}"]
NFA56_3_20409871_2("NFA56-3 char[1]")
end
subgraph DFA3_-1709778631["DFA3 {1}"]
NFA56_5_49471114_3("NFA56-5 char[1]")
end
subgraph DFA4_-603539062["DFA4 {1}"]
NFA56_7_42586845_4("NFA56-7 char[1]")
end
subgraph DFA5_872134140["DFA5 {1}"]
NFA56_9_47737289_5("NFA56-9 char[1]")
end
subgraph DFA6_1559547589["DFA6 {1}"]
NFA56_11_26982424_6[\"NFA56-11 char[1]"/]
end
DFA0_-173424413 -->|"l"|DFA1_1579461189
DFA1_1579461189 -->|"a"|DFA2_-713074302
DFA2_-713074302 -->|"y"|DFA3_-1709778631
DFA3_-1709778631 -->|"o"|DFA4_-603539062
DFA4_-603539062 -->|"u"|DFA5_872134140
DFA5_872134140 -->|"t"|DFA6_1559547589
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
DFA0_-173424413{{"DFA0 regex start"}}
DFA1_1579461189{{"DFA1 {1}"}}
DFA2_-713074302{{"DFA2 {1}"}}
DFA3_-1709778631{{"DFA3 {1}"}}
DFA4_-603539062{{"DFA4 {1}"}}
DFA5_872134140{{"DFA5 {1}"}}
DFA6_1559547589[\"DFA6 {1}"/]
DFA0_-173424413 -->|"l"|DFA1_1579461189
DFA1_1579461189 -->|"a"|DFA2_-713074302
DFA2_-713074302 -->|"y"|DFA3_-1709778631
DFA3_-1709778631 -->|"o"|DFA4_-603539062
DFA4_-603539062 -->|"u"|DFA5_872134140
DFA5_872134140 -->|"t"|DFA6_1559547589
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
subgraph MiniDFA0_-1108365461["MiniDFA0 {1}"]
DFA0_-173424413_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_399335196["MiniDFA1 {1}"]
DFA1_1579461189_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1628999223["MiniDFA2 {1}"]
DFA2_-713074302_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1993027275["MiniDFA3 {1}"]
DFA3_-1709778631_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_287452139["MiniDFA4 {1}"]
DFA4_-603539062_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_626821533["MiniDFA5 {1}"]
DFA5_872134140_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-53485166["MiniDFA6 {1}"]
DFA6_1559547589_6[\"DFA6 {1}"/]
end
MiniDFA0_-1108365461 -->|"l"|MiniDFA1_399335196
MiniDFA1_399335196 -->|"a"|MiniDFA2_1628999223
MiniDFA2_1628999223 -->|"y"|MiniDFA3_-1993027275
MiniDFA3_-1993027275 -->|"o"|MiniDFA4_287452139
MiniDFA4_287452139 -->|"u"|MiniDFA5_626821533
MiniDFA5_626821533 -->|"t"|MiniDFA6_-53485166
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
MiniDFA0_-1108365461(["MiniDFA0 {1}"])
MiniDFA1_399335196(["MiniDFA1 {1}"])
MiniDFA2_1628999223(["MiniDFA2 {1}"])
MiniDFA3_-1993027275(["MiniDFA3 {1}"])
MiniDFA4_287452139(["MiniDFA4 {1}"])
MiniDFA5_626821533(["MiniDFA5 {1}"])
MiniDFA6_-53485166[\"MiniDFA6 {1}"/]
MiniDFA0_-1108365461 -->|"l"|MiniDFA1_399335196
MiniDFA1_399335196 -->|"a"|MiniDFA2_1628999223
MiniDFA2_1628999223 -->|"y"|MiniDFA3_-1993027275
MiniDFA3_-1993027275 -->|"o"|MiniDFA4_287452139
MiniDFA4_287452139 -->|"u"|MiniDFA5_626821533
MiniDFA5_626821533 -->|"t"|MiniDFA6_-53485166
```
-------------------------------
