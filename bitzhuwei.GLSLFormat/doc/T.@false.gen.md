# 'false'

pattern: `false`

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
eNFA6_10_48254661[["εNFA6-10 regex start"]]
eNFA6_0_31638772[["εNFA6-0 char{1, 1}"]]
eNFA6_1_16313497[["εNFA6-1 char[1]"]]
eNFA6_2_12603749[["εNFA6-2 char{1, 1}"]]
eNFA6_3_46324881[["εNFA6-3 char[1]"]]
eNFA6_4_14270750[["εNFA6-4 char{1, 1}"]]
eNFA6_5_61327894[["εNFA6-5 char[1]"]]
eNFA6_6_15080136[["εNFA6-6 char{1, 1}"]]
eNFA6_7_1503503[["εNFA6-7 char[1]"]]
eNFA6_8_13531531[["εNFA6-8 char{1, 1}"]]
eNFA6_9_54674917[["εNFA6-9 char[1]"]]
eNFA6_11_22312206[["εNFA6-11 regex end"]]
eNFA6_12_66592127[["εNFA6-12 post-regex start"]]
eNFA6_13_62458233[\"εNFA6-13 post-regex end"/]
eNFA6_10_48254661 -.->|"ε"|eNFA6_0_31638772
eNFA6_0_31638772 -->|"f"|eNFA6_1_16313497
eNFA6_1_16313497 -.->|"ε"|eNFA6_2_12603749
eNFA6_2_12603749 -->|"a"|eNFA6_3_46324881
eNFA6_3_46324881 -.->|"ε"|eNFA6_4_14270750
eNFA6_4_14270750 -->|"l"|eNFA6_5_61327894
eNFA6_5_61327894 -.->|"ε"|eNFA6_6_15080136
eNFA6_6_15080136 -->|"s"|eNFA6_7_1503503
eNFA6_7_1503503 -.->|"ε"|eNFA6_8_13531531
eNFA6_8_13531531 -->|"e"|eNFA6_9_54674917
eNFA6_9_54674917 -.->|"ε"|eNFA6_11_22312206
eNFA6_11_22312206 -.->|"ε"|eNFA6_12_66592127
eNFA6_12_66592127 -.->|"ε"|eNFA6_13_62458233
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
eNFA6_10_25253189[["εNFA6-10 regex start"]]
eNFA6_0_25952117[["εNFA6-0 char{1, 1}"]]
eNFA6_1_32242465[["εNFA6-1 char[1]"]]
eNFA6_2_21746729[["εNFA6-2 char{1, 1}"]]
eNFA6_3_61502840[["εNFA6-3 char[1]"]]
eNFA6_4_16654654[["εNFA6-4 char{1, 1}"]]
eNFA6_5_15674164[["εNFA6-5 char[1]"]]
eNFA6_6_6849756[["εNFA6-6 char{1, 1}"]]
eNFA6_7_61647805[["εNFA6-7 char[1]"]]
eNFA6_8_17959338[["εNFA6-8 char{1, 1}"]]
eNFA6_9_27416314[\"εNFA6-9 char[1]"/]
eNFA6_11_45420240[\"εNFA6-11 regex end"/]
eNFA6_12_6128980[\"εNFA6-12 post-regex start"/]
eNFA6_13_55160823[\"εNFA6-13 post-regex end"/]
eNFA6_10_25253189 -.->|"ε"|eNFA6_0_25952117
eNFA6_10_25253189 -->|"f"|eNFA6_1_32242465
eNFA6_0_25952117 -->|"f"|eNFA6_1_32242465
eNFA6_1_32242465 -.->|"ε"|eNFA6_2_21746729
eNFA6_1_32242465 -->|"a"|eNFA6_3_61502840
eNFA6_2_21746729 -->|"a"|eNFA6_3_61502840
eNFA6_3_61502840 -.->|"ε"|eNFA6_4_16654654
eNFA6_3_61502840 -->|"l"|eNFA6_5_15674164
eNFA6_4_16654654 -->|"l"|eNFA6_5_15674164
eNFA6_5_15674164 -.->|"ε"|eNFA6_6_6849756
eNFA6_5_15674164 -->|"s"|eNFA6_7_61647805
eNFA6_6_6849756 -->|"s"|eNFA6_7_61647805
eNFA6_7_61647805 -.->|"ε"|eNFA6_8_17959338
eNFA6_7_61647805 -->|"e"|eNFA6_9_27416314
eNFA6_8_17959338 -->|"e"|eNFA6_9_27416314
eNFA6_9_27416314 -.->|"ε"|eNFA6_11_45420240
eNFA6_9_27416314 -.->|"ε"|eNFA6_12_6128980
eNFA6_9_27416314 -.->|"ε"|eNFA6_13_55160823
eNFA6_11_45420240 -.->|"ε"|eNFA6_12_6128980
eNFA6_11_45420240 -.->|"ε"|eNFA6_13_55160823
eNFA6_12_6128980 -.->|"ε"|eNFA6_13_55160823
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
NFA6_10_26685362("NFA6-10 regex start")
NFA6_1_38841670("NFA6-1 char[1]")
NFA6_3_14030717("NFA6-3 char[1]")
NFA6_5_59167590("NFA6-5 char[1]")
NFA6_7_62746268("NFA6-7 char[1]")
NFA6_9_27845503[\"NFA6-9 char[1]"/]
NFA6_10_26685362 -->|"f"|NFA6_1_38841670
NFA6_1_38841670 -->|"a"|NFA6_3_14030717
NFA6_3_14030717 -->|"l"|NFA6_5_59167590
NFA6_5_59167590 -->|"s"|NFA6_7_62746268
NFA6_7_62746268 -->|"e"|NFA6_9_27845503
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
subgraph DFA0_-286440003["DFA0 regex start"]
NFA6_10_26685362_0("NFA6-10 regex start")
end
subgraph DFA1_465365747["DFA1 {1}"]
NFA6_1_38841670_1("NFA6-1 char[1]")
end
subgraph DFA2_-1397918807["DFA2 {1}"]
NFA6_3_14030717_2("NFA6-3 char[1]")
end
subgraph DFA3_-1099694666["DFA3 {1}"]
NFA6_5_59167590_3("NFA6-5 char[1]")
end
subgraph DFA4_604105901["DFA4 {1}"]
NFA6_7_62746268_4("NFA6-7 char[1]")
end
subgraph DFA5_1991309409["DFA5 {1}"]
NFA6_9_27845503_5[\"NFA6-9 char[1]"/]
end
DFA0_-286440003 -->|"f"|DFA1_465365747
DFA1_465365747 -->|"a"|DFA2_-1397918807
DFA2_-1397918807 -->|"l"|DFA3_-1099694666
DFA3_-1099694666 -->|"s"|DFA4_604105901
DFA4_604105901 -->|"e"|DFA5_1991309409
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
DFA0_-286440003{{"DFA0 regex start"}}
DFA1_465365747{{"DFA1 {1}"}}
DFA2_-1397918807{{"DFA2 {1}"}}
DFA3_-1099694666{{"DFA3 {1}"}}
DFA4_604105901{{"DFA4 {1}"}}
DFA5_1991309409[\"DFA5 {1}"/]
DFA0_-286440003 -->|"f"|DFA1_465365747
DFA1_465365747 -->|"a"|DFA2_-1397918807
DFA2_-1397918807 -->|"l"|DFA3_-1099694666
DFA3_-1099694666 -->|"s"|DFA4_604105901
DFA4_604105901 -->|"e"|DFA5_1991309409
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
subgraph MiniDFA0_-1991333141["MiniDFA0 {1}"]
DFA0_-286440003_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1229322445["MiniDFA1 {1}"]
DFA1_465365747_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1309986734["MiniDFA2 {1}"]
DFA2_-1397918807_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-823560841["MiniDFA3 {1}"]
DFA3_-1099694666_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1502405350["MiniDFA4 {1}"]
DFA4_604105901_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1620938414["MiniDFA5 {1}"]
DFA5_1991309409_5[\"DFA5 {1}"/]
end
MiniDFA0_-1991333141 -->|"f"|MiniDFA1_-1229322445
MiniDFA1_-1229322445 -->|"a"|MiniDFA2_1309986734
MiniDFA2_1309986734 -->|"l"|MiniDFA3_-823560841
MiniDFA3_-823560841 -->|"s"|MiniDFA4_-1502405350
MiniDFA4_-1502405350 -->|"e"|MiniDFA5_-1620938414
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
MiniDFA0_-1991333141(["MiniDFA0 {1}"])
MiniDFA1_-1229322445(["MiniDFA1 {1}"])
MiniDFA2_1309986734(["MiniDFA2 {1}"])
MiniDFA3_-823560841(["MiniDFA3 {1}"])
MiniDFA4_-1502405350(["MiniDFA4 {1}"])
MiniDFA5_-1620938414[\"MiniDFA5 {1}"/]
MiniDFA0_-1991333141 -->|"f"|MiniDFA1_-1229322445
MiniDFA1_-1229322445 -->|"a"|MiniDFA2_1309986734
MiniDFA2_1309986734 -->|"l"|MiniDFA3_-823560841
MiniDFA3_-823560841 -->|"s"|MiniDFA4_-1502405350
MiniDFA4_-1502405350 -->|"e"|MiniDFA5_-1620938414
```
-------------------------------
