# 'dmat3x2'

pattern: `dmat3x2`

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
eNFA113_14_4582792[["εNFA113-14 regex start"]]
eNFA113_0_41245128[["εNFA113-0 char{1, 1}"]]
eNFA113_1_35661838[["εNFA113-1 char[1]"]]
eNFA113_2_52521090[["εNFA113-2 char{1, 1}"]]
eNFA113_3_2927765[["εNFA113-3 char[1]"]]
eNFA113_4_26349888[["εNFA113-4 char{1, 1}"]]
eNFA113_5_35822404[["εNFA113-5 char[1]"]]
eNFA113_6_53966187[["εNFA113-6 char{1, 1}"]]
eNFA113_7_15933636[["εNFA113-7 char[1]"]]
eNFA113_8_9185002[["εNFA113-8 char{1, 1}"]]
eNFA113_9_15556157[["εNFA113-9 char[1]"]]
eNFA113_10_5787686[["εNFA113-10 char{1, 1}"]]
eNFA113_11_52089174[["εNFA113-11 char[1]"]]
eNFA113_12_66149382[["εNFA113-12 char{1, 1}"]]
eNFA113_13_58473527[["εNFA113-13 char[1]"]]
eNFA113_15_56499698[["εNFA113-15 regex end"]]
eNFA113_16_38735241[["εNFA113-16 post-regex start"]]
eNFA113_17_13072851[\"εNFA113-17 post-regex end"/]
eNFA113_14_4582792 -.->|"ε"|eNFA113_0_41245128
eNFA113_0_41245128 -->|"d"|eNFA113_1_35661838
eNFA113_1_35661838 -.->|"ε"|eNFA113_2_52521090
eNFA113_2_52521090 -->|"m"|eNFA113_3_2927765
eNFA113_3_2927765 -.->|"ε"|eNFA113_4_26349888
eNFA113_4_26349888 -->|"a"|eNFA113_5_35822404
eNFA113_5_35822404 -.->|"ε"|eNFA113_6_53966187
eNFA113_6_53966187 -->|"t"|eNFA113_7_15933636
eNFA113_7_15933636 -.->|"ε"|eNFA113_8_9185002
eNFA113_8_9185002 -->|"3"|eNFA113_9_15556157
eNFA113_9_15556157 -.->|"ε"|eNFA113_10_5787686
eNFA113_10_5787686 -->|"x"|eNFA113_11_52089174
eNFA113_11_52089174 -.->|"ε"|eNFA113_12_66149382
eNFA113_12_66149382 -->|"2"|eNFA113_13_58473527
eNFA113_13_58473527 -.->|"ε"|eNFA113_15_56499698
eNFA113_15_56499698 -.->|"ε"|eNFA113_16_38735241
eNFA113_16_38735241 -.->|"ε"|eNFA113_17_13072851
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
eNFA113_14_50546803[["εNFA113-14 regex start"]]
eNFA113_0_52268049[["εNFA113-0 char{1, 1}"]]
eNFA113_1_650398[["εNFA113-1 char[1]"]]
eNFA113_2_5853587[["εNFA113-2 char{1, 1}"]]
eNFA113_3_52682290[["εNFA113-3 char[1]"]]
eNFA113_4_4378562[["εNFA113-4 char{1, 1}"]]
eNFA113_5_39407061[["εNFA113-5 char[1]"]]
eNFA113_6_19119237[["εNFA113-6 char{1, 1}"]]
eNFA113_7_37855410[["εNFA113-7 char[1]"]]
eNFA113_8_5154373[["εNFA113-8 char{1, 1}"]]
eNFA113_9_46389359[["εNFA113-9 char[1]"]]
eNFA113_10_14851049[["εNFA113-10 char{1, 1}"]]
eNFA113_11_66550580[["εNFA113-11 char[1]"]]
eNFA113_12_62084314[["εNFA113-12 char{1, 1}"]]
eNFA113_13_21887914[\"εNFA113-13 char[1]"/]
eNFA113_15_62773503[\"εNFA113-15 regex end"/]
eNFA113_16_28090616[\"εNFA113-16 post-regex start"/]
eNFA113_17_51488960[\"εNFA113-17 post-regex end"/]
eNFA113_14_50546803 -.->|"ε"|eNFA113_0_52268049
eNFA113_14_50546803 -->|"d"|eNFA113_1_650398
eNFA113_0_52268049 -->|"d"|eNFA113_1_650398
eNFA113_1_650398 -.->|"ε"|eNFA113_2_5853587
eNFA113_1_650398 -->|"m"|eNFA113_3_52682290
eNFA113_2_5853587 -->|"m"|eNFA113_3_52682290
eNFA113_3_52682290 -.->|"ε"|eNFA113_4_4378562
eNFA113_3_52682290 -->|"a"|eNFA113_5_39407061
eNFA113_4_4378562 -->|"a"|eNFA113_5_39407061
eNFA113_5_39407061 -.->|"ε"|eNFA113_6_19119237
eNFA113_5_39407061 -->|"t"|eNFA113_7_37855410
eNFA113_6_19119237 -->|"t"|eNFA113_7_37855410
eNFA113_7_37855410 -.->|"ε"|eNFA113_8_5154373
eNFA113_7_37855410 -->|"3"|eNFA113_9_46389359
eNFA113_8_5154373 -->|"3"|eNFA113_9_46389359
eNFA113_9_46389359 -.->|"ε"|eNFA113_10_14851049
eNFA113_9_46389359 -->|"x"|eNFA113_11_66550580
eNFA113_10_14851049 -->|"x"|eNFA113_11_66550580
eNFA113_11_66550580 -.->|"ε"|eNFA113_12_62084314
eNFA113_11_66550580 -->|"2"|eNFA113_13_21887914
eNFA113_12_62084314 -->|"2"|eNFA113_13_21887914
eNFA113_13_21887914 -.->|"ε"|eNFA113_15_62773503
eNFA113_13_21887914 -.->|"ε"|eNFA113_16_28090616
eNFA113_13_21887914 -.->|"ε"|eNFA113_17_51488960
eNFA113_15_62773503 -.->|"ε"|eNFA113_16_28090616
eNFA113_15_62773503 -.->|"ε"|eNFA113_17_51488960
eNFA113_16_28090616 -.->|"ε"|eNFA113_17_51488960
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
NFA113_14_60747463("NFA113-14 regex start")
NFA113_1_9856263("NFA113-1 char[1]")
NFA113_3_21597503("NFA113-3 char[1]")
NFA113_5_60159801("NFA113-5 char[1]")
NFA113_7_4567303("NFA113-7 char[1]")
NFA113_9_41105728("NFA113-9 char[1]")
NFA113_11_34407239("NFA113-11 char[1]")
NFA113_13_41229700[\"NFA113-13 char[1]"/]
NFA113_14_60747463 -->|"d"|NFA113_1_9856263
NFA113_1_9856263 -->|"m"|NFA113_3_21597503
NFA113_3_21597503 -->|"a"|NFA113_5_60159801
NFA113_5_60159801 -->|"t"|NFA113_7_4567303
NFA113_7_4567303 -->|"3"|NFA113_9_41105728
NFA113_9_41105728 -->|"x"|NFA113_11_34407239
NFA113_11_34407239 -->|"2"|NFA113_13_41229700
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
subgraph DFA0_-981046972["DFA0 regex start"]
NFA113_14_60747463_0("NFA113-14 regex start")
end
subgraph DFA1_-866869148["DFA1 {1}"]
NFA113_1_9856263_1("NFA113-1 char[1]")
end
subgraph DFA2_217427278["DFA2 {1}"]
NFA113_3_21597503_2("NFA113-3 char[1]")
end
subgraph DFA3_-570953862["DFA3 {1}"]
NFA113_5_60159801_3("NFA113-5 char[1]")
end
subgraph DFA4_-1734412881["DFA4 {1}"]
NFA113_7_4567303_4("NFA113-7 char[1]")
end
subgraph DFA5_-2132129167["DFA5 {1}"]
NFA113_9_41105728_5("NFA113-9 char[1]")
end
subgraph DFA6_30479307["DFA6 {1}"]
NFA113_11_34407239_6("NFA113-11 char[1]")
end
subgraph DFA7_-229476348["DFA7 {1}"]
NFA113_13_41229700_7[\"NFA113-13 char[1]"/]
end
DFA0_-981046972 -->|"d"|DFA1_-866869148
DFA1_-866869148 -->|"m"|DFA2_217427278
DFA2_217427278 -->|"a"|DFA3_-570953862
DFA3_-570953862 -->|"t"|DFA4_-1734412881
DFA4_-1734412881 -->|"3"|DFA5_-2132129167
DFA5_-2132129167 -->|"x"|DFA6_30479307
DFA6_30479307 -->|"2"|DFA7_-229476348
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
DFA0_-981046972{{"DFA0 regex start"}}
DFA1_-866869148{{"DFA1 {1}"}}
DFA2_217427278{{"DFA2 {1}"}}
DFA3_-570953862{{"DFA3 {1}"}}
DFA4_-1734412881{{"DFA4 {1}"}}
DFA5_-2132129167{{"DFA5 {1}"}}
DFA6_30479307{{"DFA6 {1}"}}
DFA7_-229476348[\"DFA7 {1}"/]
DFA0_-981046972 -->|"d"|DFA1_-866869148
DFA1_-866869148 -->|"m"|DFA2_217427278
DFA2_217427278 -->|"a"|DFA3_-570953862
DFA3_-570953862 -->|"t"|DFA4_-1734412881
DFA4_-1734412881 -->|"3"|DFA5_-2132129167
DFA5_-2132129167 -->|"x"|DFA6_30479307
DFA6_30479307 -->|"2"|DFA7_-229476348
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
subgraph MiniDFA0_1590400788["MiniDFA0 {1}"]
DFA0_-981046972_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-799044676["MiniDFA1 {1}"]
DFA1_-866869148_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1445679971["MiniDFA2 {1}"]
DFA2_217427278_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1828743232["MiniDFA3 {1}"]
DFA3_-570953862_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1195410957["MiniDFA4 {1}"]
DFA4_-1734412881_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_155302951["MiniDFA5 {1}"]
DFA5_-2132129167_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_2046803558["MiniDFA6 {1}"]
DFA6_30479307_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1275624768["MiniDFA7 {1}"]
DFA7_-229476348_7[\"DFA7 {1}"/]
end
MiniDFA0_1590400788 -->|"d"|MiniDFA1_-799044676
MiniDFA1_-799044676 -->|"m"|MiniDFA2_-1445679971
MiniDFA2_-1445679971 -->|"a"|MiniDFA3_1828743232
MiniDFA3_1828743232 -->|"t"|MiniDFA4_-1195410957
MiniDFA4_-1195410957 -->|"3"|MiniDFA5_155302951
MiniDFA5_155302951 -->|"x"|MiniDFA6_2046803558
MiniDFA6_2046803558 -->|"2"|MiniDFA7_1275624768
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
MiniDFA0_1590400788(["MiniDFA0 {1}"])
MiniDFA1_-799044676(["MiniDFA1 {1}"])
MiniDFA2_-1445679971(["MiniDFA2 {1}"])
MiniDFA3_1828743232(["MiniDFA3 {1}"])
MiniDFA4_-1195410957(["MiniDFA4 {1}"])
MiniDFA5_155302951(["MiniDFA5 {1}"])
MiniDFA6_2046803558(["MiniDFA6 {1}"])
MiniDFA7_1275624768[\"MiniDFA7 {1}"/]
MiniDFA0_1590400788 -->|"d"|MiniDFA1_-799044676
MiniDFA1_-799044676 -->|"m"|MiniDFA2_-1445679971
MiniDFA2_-1445679971 -->|"a"|MiniDFA3_1828743232
MiniDFA3_1828743232 -->|"t"|MiniDFA4_-1195410957
MiniDFA4_-1195410957 -->|"3"|MiniDFA5_155302951
MiniDFA5_155302951 -->|"x"|MiniDFA6_2046803558
MiniDFA6_2046803558 -->|"2"|MiniDFA7_1275624768
```
-------------------------------
