# 'mat2x2'

pattern: `mat2x2`

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
eNFA98_12_20460183[["εNFA98-12 regex start"]]
eNFA98_0_49923923[["εNFA98-0 char{1, 1}"]]
eNFA98_1_46662130[["εNFA98-1 char[1]"]]
eNFA98_2_17305987[["εNFA98-2 char{1, 1}"]]
eNFA98_3_21536161[["εNFA98-3 char[1]"]]
eNFA98_4_59607724[["εNFA98-4 char{1, 1}"]]
eNFA98_5_66707469[["εNFA98-5 char[1]"]]
eNFA98_6_63496309[["εNFA98-6 char{1, 1}"]]
eNFA98_7_34595869[["εNFA98-7 char[1]"]]
eNFA98_8_42927366[["εNFA98-8 char{1, 1}"]]
eNFA98_9_50801977[["εNFA98-9 char[1]"]]
eNFA98_10_54564616[["εNFA98-10 char{1, 1}"]]
eNFA98_11_21319498[["εNFA98-11 char[1]"]]
eNFA98_13_57657762[["εNFA98-13 regex end"]]
eNFA98_14_49157816[["εNFA98-14 post-regex start"]]
eNFA98_15_39767165[\"εNFA98-15 post-regex end"/]
eNFA98_12_20460183 -.->|"ε"|eNFA98_0_49923923
eNFA98_0_49923923 -->|"m"|eNFA98_1_46662130
eNFA98_1_46662130 -.->|"ε"|eNFA98_2_17305987
eNFA98_2_17305987 -->|"a"|eNFA98_3_21536161
eNFA98_3_21536161 -.->|"ε"|eNFA98_4_59607724
eNFA98_4_59607724 -->|"t"|eNFA98_5_66707469
eNFA98_5_66707469 -.->|"ε"|eNFA98_6_63496309
eNFA98_6_63496309 -->|"2"|eNFA98_7_34595869
eNFA98_7_34595869 -.->|"ε"|eNFA98_8_42927366
eNFA98_8_42927366 -->|"x"|eNFA98_9_50801977
eNFA98_9_50801977 -.->|"ε"|eNFA98_10_54564616
eNFA98_10_54564616 -->|"2"|eNFA98_11_21319498
eNFA98_11_21319498 -.->|"ε"|eNFA98_13_57657762
eNFA98_13_57657762 -.->|"ε"|eNFA98_14_49157816
eNFA98_14_49157816 -.->|"ε"|eNFA98_15_39767165
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
eNFA98_12_22360170[["εNFA98-12 regex start"]]
eNFA98_0_67023809[["εNFA98-0 char{1, 1}"]]
eNFA98_1_66343369[["εNFA98-1 char[1]"]]
eNFA98_2_60219412[["εNFA98-2 char{1, 1}"]]
eNFA98_3_5103804[["εNFA98-3 char[1]"]]
eNFA98_4_45934241[["εNFA98-4 char{1, 1}"]]
eNFA98_5_10754988[["εNFA98-5 char[1]"]]
eNFA98_6_29686030[["εNFA98-6 char{1, 1}"]]
eNFA98_7_65847680[["εNFA98-7 char[1]"]]
eNFA98_8_55758211[["εNFA98-8 char{1, 1}"]]
eNFA98_9_32061857[["εNFA98-9 char[1]"]]
eNFA98_10_20121257[["εNFA98-10 char{1, 1}"]]
eNFA98_11_46873590[\"εNFA98-11 char[1]"/]
eNFA98_13_19209127[\"εNFA98-13 regex end"/]
eNFA98_14_38664423[\"εNFA98-14 post-regex start"/]
eNFA98_15_12435494[\"εNFA98-15 post-regex end"/]
eNFA98_12_22360170 -.->|"ε"|eNFA98_0_67023809
eNFA98_12_22360170 -->|"m"|eNFA98_1_66343369
eNFA98_0_67023809 -->|"m"|eNFA98_1_66343369
eNFA98_1_66343369 -.->|"ε"|eNFA98_2_60219412
eNFA98_1_66343369 -->|"a"|eNFA98_3_5103804
eNFA98_2_60219412 -->|"a"|eNFA98_3_5103804
eNFA98_3_5103804 -.->|"ε"|eNFA98_4_45934241
eNFA98_3_5103804 -->|"t"|eNFA98_5_10754988
eNFA98_4_45934241 -->|"t"|eNFA98_5_10754988
eNFA98_5_10754988 -.->|"ε"|eNFA98_6_29686030
eNFA98_5_10754988 -->|"2"|eNFA98_7_65847680
eNFA98_6_29686030 -->|"2"|eNFA98_7_65847680
eNFA98_7_65847680 -.->|"ε"|eNFA98_8_55758211
eNFA98_7_65847680 -->|"x"|eNFA98_9_32061857
eNFA98_8_55758211 -->|"x"|eNFA98_9_32061857
eNFA98_9_32061857 -.->|"ε"|eNFA98_10_20121257
eNFA98_9_32061857 -->|"2"|eNFA98_11_46873590
eNFA98_10_20121257 -->|"2"|eNFA98_11_46873590
eNFA98_11_46873590 -.->|"ε"|eNFA98_13_19209127
eNFA98_11_46873590 -.->|"ε"|eNFA98_14_38664423
eNFA98_11_46873590 -.->|"ε"|eNFA98_15_12435494
eNFA98_13_19209127 -.->|"ε"|eNFA98_14_38664423
eNFA98_13_19209127 -.->|"ε"|eNFA98_15_12435494
eNFA98_14_38664423 -.->|"ε"|eNFA98_15_12435494
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
NFA98_12_44810590("NFA98-12 regex start")
NFA98_1_642126("NFA98-1 char[1]")
NFA98_3_5779136("NFA98-3 char[1]")
NFA98_5_52012230("NFA98-5 char[1]")
NFA98_7_65456887("NFA98-7 char[1]")
NFA98_9_52241078("NFA98-9 char[1]")
NFA98_11_407659[\"NFA98-11 char[1]"/]
NFA98_12_44810590 -->|"m"|NFA98_1_642126
NFA98_1_642126 -->|"a"|NFA98_3_5779136
NFA98_3_5779136 -->|"t"|NFA98_5_52012230
NFA98_5_52012230 -->|"2"|NFA98_7_65456887
NFA98_7_65456887 -->|"x"|NFA98_9_52241078
NFA98_9_52241078 -->|"2"|NFA98_11_407659
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
subgraph DFA0_667490824["DFA0 regex start"]
NFA98_12_44810590_0("NFA98-12 regex start")
end
subgraph DFA1_-255500605["DFA1 {1}"]
NFA98_1_642126_1("NFA98-1 char[1]")
end
subgraph DFA2_-290377845["DFA2 {1}"]
NFA98_3_5779136_2("NFA98-3 char[1]")
end
subgraph DFA3_193669721["DFA3 {1}"]
NFA98_5_52012230_3("NFA98-5 char[1]")
end
subgraph DFA4_-592095448["DFA4 {1}"]
NFA98_7_65456887_4("NFA98-7 char[1]")
end
subgraph DFA5_994692123["DFA5 {1}"]
NFA98_9_52241078_5("NFA98-9 char[1]")
end
subgraph DFA6_-1923152696["DFA6 {1}"]
NFA98_11_407659_6[\"NFA98-11 char[1]"/]
end
DFA0_667490824 -->|"m"|DFA1_-255500605
DFA1_-255500605 -->|"a"|DFA2_-290377845
DFA2_-290377845 -->|"t"|DFA3_193669721
DFA3_193669721 -->|"2"|DFA4_-592095448
DFA4_-592095448 -->|"x"|DFA5_994692123
DFA5_994692123 -->|"2"|DFA6_-1923152696
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
DFA0_667490824{{"DFA0 regex start"}}
DFA1_-255500605{{"DFA1 {1}"}}
DFA2_-290377845{{"DFA2 {1}"}}
DFA3_193669721{{"DFA3 {1}"}}
DFA4_-592095448{{"DFA4 {1}"}}
DFA5_994692123{{"DFA5 {1}"}}
DFA6_-1923152696[\"DFA6 {1}"/]
DFA0_667490824 -->|"m"|DFA1_-255500605
DFA1_-255500605 -->|"a"|DFA2_-290377845
DFA2_-290377845 -->|"t"|DFA3_193669721
DFA3_193669721 -->|"2"|DFA4_-592095448
DFA4_-592095448 -->|"x"|DFA5_994692123
DFA5_994692123 -->|"2"|DFA6_-1923152696
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
subgraph MiniDFA0_1349941144["MiniDFA0 {1}"]
DFA0_667490824_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1776435777["MiniDFA1 {1}"]
DFA1_-255500605_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1718400911["MiniDFA2 {1}"]
DFA2_-290377845_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_2103522774["MiniDFA3 {1}"]
DFA3_193669721_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1615495392["MiniDFA4 {1}"]
DFA4_-592095448_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1913416909["MiniDFA5 {1}"]
DFA5_994692123_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-2046796139["MiniDFA6 {1}"]
DFA6_-1923152696_6[\"DFA6 {1}"/]
end
MiniDFA0_1349941144 -->|"m"|MiniDFA1_1776435777
MiniDFA1_1776435777 -->|"a"|MiniDFA2_1718400911
MiniDFA2_1718400911 -->|"t"|MiniDFA3_2103522774
MiniDFA3_2103522774 -->|"2"|MiniDFA4_1615495392
MiniDFA4_1615495392 -->|"x"|MiniDFA5_1913416909
MiniDFA5_1913416909 -->|"2"|MiniDFA6_-2046796139
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
MiniDFA0_1349941144(["MiniDFA0 {1}"])
MiniDFA1_1776435777(["MiniDFA1 {1}"])
MiniDFA2_1718400911(["MiniDFA2 {1}"])
MiniDFA3_2103522774(["MiniDFA3 {1}"])
MiniDFA4_1615495392(["MiniDFA4 {1}"])
MiniDFA5_1913416909(["MiniDFA5 {1}"])
MiniDFA6_-2046796139[\"MiniDFA6 {1}"/]
MiniDFA0_1349941144 -->|"m"|MiniDFA1_1776435777
MiniDFA1_1776435777 -->|"a"|MiniDFA2_1718400911
MiniDFA2_1718400911 -->|"t"|MiniDFA3_2103522774
MiniDFA3_2103522774 -->|"2"|MiniDFA4_1615495392
MiniDFA4_1615495392 -->|"x"|MiniDFA5_1913416909
MiniDFA5_1913416909 -->|"2"|MiniDFA6_-2046796139
```
-------------------------------
