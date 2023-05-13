# 'default'

pattern: `default`

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
eNFA201_14_20164217[["εNFA201-14 regex start"]]
eNFA201_0_47260226[["εNFA201-0 char{1, 1}"]]
eNFA201_1_22688855[["εNFA201-1 char[1]"]]
eNFA201_2_2873103[["εNFA201-2 char{1, 1}"]]
eNFA201_3_25857933[["εNFA201-3 char[1]"]]
eNFA201_4_31394809[["εNFA201-4 char{1, 1}"]]
eNFA201_5_14117828[["εNFA201-5 char[1]"]]
eNFA201_6_59951591[["εNFA201-6 char{1, 1}"]]
eNFA201_7_2693411[["εNFA201-7 char[1]"]]
eNFA201_8_24240706[["εNFA201-8 char{1, 1}"]]
eNFA201_9_16839763[["εNFA201-9 char[1]"]]
eNFA201_10_17340145[["εNFA201-10 char{1, 1}"]]
eNFA201_11_21843580[["εNFA201-11 char[1]"]]
eNFA201_12_62374493[["εNFA201-12 char{1, 1}"]]
eNFA201_13_24499525[["εNFA201-13 char[1]"]]
eNFA201_15_19169133[["εNFA201-15 regex end"]]
eNFA201_16_38304470[["εNFA201-16 post-regex start"]]
eNFA201_17_9195913[\"εNFA201-17 post-regex end"/]
eNFA201_14_20164217 -.->|"ε"|eNFA201_0_47260226
eNFA201_0_47260226 -->|"d"|eNFA201_1_22688855
eNFA201_1_22688855 -.->|"ε"|eNFA201_2_2873103
eNFA201_2_2873103 -->|"e"|eNFA201_3_25857933
eNFA201_3_25857933 -.->|"ε"|eNFA201_4_31394809
eNFA201_4_31394809 -->|"f"|eNFA201_5_14117828
eNFA201_5_14117828 -.->|"ε"|eNFA201_6_59951591
eNFA201_6_59951591 -->|"a"|eNFA201_7_2693411
eNFA201_7_2693411 -.->|"ε"|eNFA201_8_24240706
eNFA201_8_24240706 -->|"u"|eNFA201_9_16839763
eNFA201_9_16839763 -.->|"ε"|eNFA201_10_17340145
eNFA201_10_17340145 -->|"l"|eNFA201_11_21843580
eNFA201_11_21843580 -.->|"ε"|eNFA201_12_62374493
eNFA201_12_62374493 -->|"t"|eNFA201_13_24499525
eNFA201_13_24499525 -.->|"ε"|eNFA201_15_19169133
eNFA201_15_19169133 -.->|"ε"|eNFA201_16_38304470
eNFA201_16_38304470 -.->|"ε"|eNFA201_17_9195913
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
eNFA201_14_15654360[["εNFA201-14 regex start"]]
eNFA201_0_6671514[["εNFA201-0 char{1, 1}"]]
eNFA201_1_60043634[["εNFA201-1 char[1]"]]
eNFA201_2_3521800[["εNFA201-2 char{1, 1}"]]
eNFA201_3_31696205[["εNFA201-3 char[1]"]]
eNFA201_4_16830394[["εNFA201-4 char{1, 1}"]]
eNFA201_5_17255825[["εNFA201-5 char[1]"]]
eNFA201_6_21084697[["εNFA201-6 char{1, 1}"]]
eNFA201_7_55544548[["εNFA201-7 char[1]"]]
eNFA201_8_30138892[["εNFA201-8 char{1, 1}"]]
eNFA201_9_2814577[["εNFA201-9 char[1]"]]
eNFA201_10_25331196[["εNFA201-10 char{1, 1}"]]
eNFA201_11_26654174[["εNFA201-11 char[1]"]]
eNFA201_12_38560976[["εNFA201-12 char{1, 1}"]]
eNFA201_13_11504467[\"εNFA201-13 char[1]"/]
eNFA201_15_36431345[\"εNFA201-15 regex end"/]
eNFA201_16_59446649[\"εNFA201-16 post-regex start"/]
eNFA201_17_65257798[\"εNFA201-17 post-regex end"/]
eNFA201_14_15654360 -.->|"ε"|eNFA201_0_6671514
eNFA201_14_15654360 -->|"d"|eNFA201_1_60043634
eNFA201_0_6671514 -->|"d"|eNFA201_1_60043634
eNFA201_1_60043634 -.->|"ε"|eNFA201_2_3521800
eNFA201_1_60043634 -->|"e"|eNFA201_3_31696205
eNFA201_2_3521800 -->|"e"|eNFA201_3_31696205
eNFA201_3_31696205 -.->|"ε"|eNFA201_4_16830394
eNFA201_3_31696205 -->|"f"|eNFA201_5_17255825
eNFA201_4_16830394 -->|"f"|eNFA201_5_17255825
eNFA201_5_17255825 -.->|"ε"|eNFA201_6_21084697
eNFA201_5_17255825 -->|"a"|eNFA201_7_55544548
eNFA201_6_21084697 -->|"a"|eNFA201_7_55544548
eNFA201_7_55544548 -.->|"ε"|eNFA201_8_30138892
eNFA201_7_55544548 -->|"u"|eNFA201_9_2814577
eNFA201_8_30138892 -->|"u"|eNFA201_9_2814577
eNFA201_9_2814577 -.->|"ε"|eNFA201_10_25331196
eNFA201_9_2814577 -->|"l"|eNFA201_11_26654174
eNFA201_10_25331196 -->|"l"|eNFA201_11_26654174
eNFA201_11_26654174 -.->|"ε"|eNFA201_12_38560976
eNFA201_11_26654174 -->|"t"|eNFA201_13_11504467
eNFA201_12_38560976 -->|"t"|eNFA201_13_11504467
eNFA201_13_11504467 -.->|"ε"|eNFA201_15_36431345
eNFA201_13_11504467 -.->|"ε"|eNFA201_16_59446649
eNFA201_13_11504467 -.->|"ε"|eNFA201_17_65257798
eNFA201_15_36431345 -.->|"ε"|eNFA201_16_59446649
eNFA201_15_36431345 -.->|"ε"|eNFA201_17_65257798
eNFA201_16_59446649 -.->|"ε"|eNFA201_17_65257798
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
NFA201_14_50449271("NFA201-14 regex start")
NFA201_1_51390263("NFA201-1 char[1]")
NFA201_3_59859190("NFA201-3 char[1]")
NFA201_5_1861806("NFA201-5 char[1]")
NFA201_7_16756254("NFA201-7 char[1]")
NFA201_9_16588560("NFA201-9 char[1]")
NFA201_11_15079318("NFA201-11 char[1]")
NFA201_13_1496135[\"NFA201-13 char[1]"/]
NFA201_14_50449271 -->|"d"|NFA201_1_51390263
NFA201_1_51390263 -->|"e"|NFA201_3_59859190
NFA201_3_59859190 -->|"f"|NFA201_5_1861806
NFA201_5_1861806 -->|"a"|NFA201_7_16756254
NFA201_7_16756254 -->|"u"|NFA201_9_16588560
NFA201_9_16588560 -->|"l"|NFA201_11_15079318
NFA201_11_15079318 -->|"t"|NFA201_13_1496135
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
subgraph DFA0_-1049331617["DFA0 regex start"]
NFA201_14_50449271_0("NFA201-14 regex start")
end
subgraph DFA1_1643355058["DFA1 {1}"]
NFA201_1_51390263_1("NFA201-1 char[1]")
end
subgraph DFA2_-101007678["DFA2 {1}"]
NFA201_3_59859190_2("NFA201-3 char[1]")
end
subgraph DFA3_-1219188194["DFA3 {1}"]
NFA201_5_1861806_3("NFA201-5 char[1]")
end
subgraph DFA4_-81903796["DFA4 {1}"]
NFA201_7_16756254_4("NFA201-7 char[1]")
end
subgraph DFA5_1702357406["DFA5 {1}"]
NFA201_9_16588560_5("NFA201-9 char[1]")
end
subgraph DFA6_-1375428294["DFA6 {1}"]
NFA201_11_15079318_6("NFA201-11 char[1]")
end
subgraph DFA7_-1939184883["DFA7 {1}"]
NFA201_13_1496135_7[\"NFA201-13 char[1]"/]
end
DFA0_-1049331617 -->|"d"|DFA1_1643355058
DFA1_1643355058 -->|"e"|DFA2_-101007678
DFA2_-101007678 -->|"f"|DFA3_-1219188194
DFA3_-1219188194 -->|"a"|DFA4_-81903796
DFA4_-81903796 -->|"u"|DFA5_1702357406
DFA5_1702357406 -->|"l"|DFA6_-1375428294
DFA6_-1375428294 -->|"t"|DFA7_-1939184883
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
DFA0_-1049331617{{"DFA0 regex start"}}
DFA1_1643355058{{"DFA1 {1}"}}
DFA2_-101007678{{"DFA2 {1}"}}
DFA3_-1219188194{{"DFA3 {1}"}}
DFA4_-81903796{{"DFA4 {1}"}}
DFA5_1702357406{{"DFA5 {1}"}}
DFA6_-1375428294{{"DFA6 {1}"}}
DFA7_-1939184883[\"DFA7 {1}"/]
DFA0_-1049331617 -->|"d"|DFA1_1643355058
DFA1_1643355058 -->|"e"|DFA2_-101007678
DFA2_-101007678 -->|"f"|DFA3_-1219188194
DFA3_-1219188194 -->|"a"|DFA4_-81903796
DFA4_-81903796 -->|"u"|DFA5_1702357406
DFA5_1702357406 -->|"l"|DFA6_-1375428294
DFA6_-1375428294 -->|"t"|DFA7_-1939184883
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
subgraph MiniDFA0_1716762867["MiniDFA0 {1}"]
DFA0_-1049331617_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1143074616["MiniDFA1 {1}"]
DFA1_1643355058_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1872198065["MiniDFA2 {1}"]
DFA2_-101007678_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-912578626["MiniDFA3 {1}"]
DFA3_-1219188194_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1183224289["MiniDFA4 {1}"]
DFA4_-81903796_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1824271593["MiniDFA5 {1}"]
DFA5_1702357406_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_849016217["MiniDFA6 {1}"]
DFA6_-1375428294_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-899371364["MiniDFA7 {1}"]
DFA7_-1939184883_7[\"DFA7 {1}"/]
end
MiniDFA0_1716762867 -->|"d"|MiniDFA1_1143074616
MiniDFA1_1143074616 -->|"e"|MiniDFA2_1872198065
MiniDFA2_1872198065 -->|"f"|MiniDFA3_-912578626
MiniDFA3_-912578626 -->|"a"|MiniDFA4_1183224289
MiniDFA4_1183224289 -->|"u"|MiniDFA5_-1824271593
MiniDFA5_-1824271593 -->|"l"|MiniDFA6_849016217
MiniDFA6_849016217 -->|"t"|MiniDFA7_-899371364
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
MiniDFA0_1716762867(["MiniDFA0 {1}"])
MiniDFA1_1143074616(["MiniDFA1 {1}"])
MiniDFA2_1872198065(["MiniDFA2 {1}"])
MiniDFA3_-912578626(["MiniDFA3 {1}"])
MiniDFA4_1183224289(["MiniDFA4 {1}"])
MiniDFA5_-1824271593(["MiniDFA5 {1}"])
MiniDFA6_849016217(["MiniDFA6 {1}"])
MiniDFA7_-899371364[\"MiniDFA7 {1}"/]
MiniDFA0_1716762867 -->|"d"|MiniDFA1_1143074616
MiniDFA1_1143074616 -->|"e"|MiniDFA2_1872198065
MiniDFA2_1872198065 -->|"f"|MiniDFA3_-912578626
MiniDFA3_-912578626 -->|"a"|MiniDFA4_1183224289
MiniDFA4_1183224289 -->|"u"|MiniDFA5_-1824271593
MiniDFA5_-1824271593 -->|"l"|MiniDFA6_849016217
MiniDFA6_849016217 -->|"t"|MiniDFA7_-899371364
```
-------------------------------
