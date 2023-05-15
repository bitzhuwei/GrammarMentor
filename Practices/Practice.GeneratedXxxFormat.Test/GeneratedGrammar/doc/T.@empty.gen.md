# 'empty'

pattern: `empty`

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
eNFA7_10_19845579[["εNFA7-10 regex start"]]
eNFA7_0_44392488[["εNFA7-0 char{1, 1}"]]
eNFA7_1_63988077[["εNFA7-1 char[1]"]]
eNFA7_2_39021788[["εNFA7-2 char{1, 1}"]]
eNFA7_3_15651772[["εNFA7-3 char[1]"]]
eNFA7_4_6648223[["εNFA7-4 char{1, 1}"]]
eNFA7_5_59834015[["εNFA7-5 char[1]"]]
eNFA7_6_1635228[["εNFA7-6 char{1, 1}"]]
eNFA7_7_14717055[["εNFA7-7 char[1]"]]
eNFA7_8_65344633[["εNFA7-8 char{1, 1}"]]
eNFA7_9_51230787[["εNFA7-9 char[1]"]]
eNFA7_11_58423902[["εNFA7-11 regex end"]]
eNFA7_12_56053076[["εNFA7-12 post-regex start"]]
eNFA7_13_34715636[\"εNFA7-13 post-regex end"/]
eNFA7_10_19845579 -.->|"ε"|eNFA7_0_44392488
eNFA7_0_44392488 -->|"e"|eNFA7_1_63988077
eNFA7_1_63988077 -.->|"ε"|eNFA7_2_39021788
eNFA7_2_39021788 -->|"m"|eNFA7_3_15651772
eNFA7_3_15651772 -.->|"ε"|eNFA7_4_6648223
eNFA7_4_6648223 -->|"p"|eNFA7_5_59834015
eNFA7_5_59834015 -.->|"ε"|eNFA7_6_1635228
eNFA7_6_1635228 -->|"t"|eNFA7_7_14717055
eNFA7_7_14717055 -.->|"ε"|eNFA7_8_65344633
eNFA7_8_65344633 -->|"y"|eNFA7_9_51230787
eNFA7_9_51230787 -.->|"ε"|eNFA7_11_58423902
eNFA7_11_58423902 -.->|"ε"|eNFA7_12_56053076
eNFA7_12_56053076 -.->|"ε"|eNFA7_13_34715636
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
eNFA7_10_44005273[["εNFA7-10 regex start"]]
eNFA7_0_60503138[["εNFA7-0 char{1, 1}"]]
eNFA7_1_7657338[["εNFA7-1 char[1]"]]
eNFA7_2_1807185[["εNFA7-2 char{1, 1}"]]
eNFA7_3_16264673[["εNFA7-3 char[1]"]]
eNFA7_4_12164329[["εNFA7-4 char{1, 1}"]]
eNFA7_5_42370099[["εNFA7-5 char[1]"]]
eNFA7_6_45786577[["εNFA7-6 char{1, 1}"]]
eNFA7_7_9426010[["εNFA7-7 char[1]"]]
eNFA7_8_17725233[["εNFA7-8 char{1, 1}"]]
eNFA7_9_25309374[\"εNFA7-9 char[1]"/]
eNFA7_11_26457778[\"εNFA7-11 regex end"/]
eNFA7_12_36793414[\"εNFA7-12 post-regex start"/]
eNFA7_13_62705275[\"εNFA7-13 post-regex end"/]
eNFA7_10_44005273 -.->|"ε"|eNFA7_0_60503138
eNFA7_10_44005273 -->|"e"|eNFA7_1_7657338
eNFA7_0_60503138 -->|"e"|eNFA7_1_7657338
eNFA7_1_7657338 -.->|"ε"|eNFA7_2_1807185
eNFA7_1_7657338 -->|"m"|eNFA7_3_16264673
eNFA7_2_1807185 -->|"m"|eNFA7_3_16264673
eNFA7_3_16264673 -.->|"ε"|eNFA7_4_12164329
eNFA7_3_16264673 -->|"p"|eNFA7_5_42370099
eNFA7_4_12164329 -->|"p"|eNFA7_5_42370099
eNFA7_5_42370099 -.->|"ε"|eNFA7_6_45786577
eNFA7_5_42370099 -->|"t"|eNFA7_7_9426010
eNFA7_6_45786577 -->|"t"|eNFA7_7_9426010
eNFA7_7_9426010 -.->|"ε"|eNFA7_8_17725233
eNFA7_7_9426010 -->|"y"|eNFA7_9_25309374
eNFA7_8_17725233 -->|"y"|eNFA7_9_25309374
eNFA7_9_25309374 -.->|"ε"|eNFA7_11_26457778
eNFA7_9_25309374 -.->|"ε"|eNFA7_12_36793414
eNFA7_9_25309374 -.->|"ε"|eNFA7_13_62705275
eNFA7_11_26457778 -.->|"ε"|eNFA7_12_36793414
eNFA7_11_26457778 -.->|"ε"|eNFA7_13_62705275
eNFA7_12_36793414 -.->|"ε"|eNFA7_13_62705275
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
NFA7_10_27476571("NFA7-10 regex start")
NFA7_1_45962549("NFA7-1 char[1]")
NFA7_3_11009764("NFA7-3 char[1]")
NFA7_5_31979016("NFA7-5 char[1]")
NFA7_7_19375690("NFA7-7 char[1]")
NFA7_9_40163483[\"NFA7-9 char[1]"/]
NFA7_10_27476571 -->|"e"|NFA7_1_45962549
NFA7_1_45962549 -->|"m"|NFA7_3_11009764
NFA7_3_11009764 -->|"p"|NFA7_5_31979016
NFA7_5_31979016 -->|"t"|NFA7_7_19375690
NFA7_7_19375690 -->|"y"|NFA7_9_40163483
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
subgraph DFA0_-581217594["DFA0 regex start"]
NFA7_10_27476571_0("NFA7-10 regex start")
end
subgraph DFA1_-102531699["DFA1 {1}"]
NFA7_1_45962549_1("NFA7-1 char[1]")
end
subgraph DFA2_-35495911["DFA2 {1}"]
NFA7_3_11009764_2("NFA7-3 char[1]")
end
subgraph DFA3_-535131818["DFA3 {1}"]
NFA7_5_31979016_3("NFA7-5 char[1]")
end
subgraph DFA4_-1632873258["DFA4 {1}"]
NFA7_7_19375690_4("NFA7-7 char[1]")
end
subgraph DFA5_-594581610["DFA5 {1}"]
NFA7_9_40163483_5[\"NFA7-9 char[1]"/]
end
DFA0_-581217594 -->|"e"|DFA1_-102531699
DFA1_-102531699 -->|"m"|DFA2_-35495911
DFA2_-35495911 -->|"p"|DFA3_-535131818
DFA3_-535131818 -->|"t"|DFA4_-1632873258
DFA4_-1632873258 -->|"y"|DFA5_-594581610
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
DFA0_-581217594{{"DFA0 regex start"}}
DFA1_-102531699{{"DFA1 {1}"}}
DFA2_-35495911{{"DFA2 {1}"}}
DFA3_-535131818{{"DFA3 {1}"}}
DFA4_-1632873258{{"DFA4 {1}"}}
DFA5_-594581610[\"DFA5 {1}"/]
DFA0_-581217594 -->|"e"|DFA1_-102531699
DFA1_-102531699 -->|"m"|DFA2_-35495911
DFA2_-35495911 -->|"p"|DFA3_-535131818
DFA3_-535131818 -->|"t"|DFA4_-1632873258
DFA4_-1632873258 -->|"y"|DFA5_-594581610
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
subgraph MiniDFA0_81783063["MiniDFA0 {1}"]
DFA0_-581217594_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-515189128["MiniDFA1 {1}"]
DFA1_-102531699_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-507109098["MiniDFA2 {1}"]
DFA2_-35495911_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1765910664["MiniDFA3 {1}"]
DFA3_-535131818_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_512360556["MiniDFA4 {1}"]
DFA4_-1632873258_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1112581023["MiniDFA5 {1}"]
DFA5_-594581610_5[\"DFA5 {1}"/]
end
MiniDFA0_81783063 -->|"e"|MiniDFA1_-515189128
MiniDFA1_-515189128 -->|"m"|MiniDFA2_-507109098
MiniDFA2_-507109098 -->|"p"|MiniDFA3_-1765910664
MiniDFA3_-1765910664 -->|"t"|MiniDFA4_512360556
MiniDFA4_512360556 -->|"y"|MiniDFA5_1112581023
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
MiniDFA0_81783063(["MiniDFA0 {1}"])
MiniDFA1_-515189128(["MiniDFA1 {1}"])
MiniDFA2_-507109098(["MiniDFA2 {1}"])
MiniDFA3_-1765910664(["MiniDFA3 {1}"])
MiniDFA4_512360556(["MiniDFA4 {1}"])
MiniDFA5_1112581023[\"MiniDFA5 {1}"/]
MiniDFA0_81783063 -->|"e"|MiniDFA1_-515189128
MiniDFA1_-515189128 -->|"m"|MiniDFA2_-507109098
MiniDFA2_-507109098 -->|"p"|MiniDFA3_-1765910664
MiniDFA3_-1765910664 -->|"t"|MiniDFA4_512360556
MiniDFA4_512360556 -->|"y"|MiniDFA5_1112581023
```
-------------------------------
