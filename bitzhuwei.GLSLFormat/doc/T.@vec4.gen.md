# 'vec4'

pattern: `vec4`

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
eNFA82_8_34751460[["εNFA82-8 regex start"]]
eNFA82_0_44327687[["εNFA82-0 char{1, 1}"]]
eNFA82_1_63404869[["εNFA82-1 char[1]"]]
eNFA82_2_33772909[["εNFA82-2 char{1, 1}"]]
eNFA82_3_35520730[["εNFA82-3 char[1]"]]
eNFA82_4_51251115[["εNFA82-4 char{1, 1}"]]
eNFA82_5_58606859[["εNFA82-5 char[1]"]]
eNFA82_6_57699690[["εNFA82-6 char{1, 1}"]]
eNFA82_7_49535170[["εNFA82-7 char[1]"]]
eNFA82_9_43163346[["εNFA82-9 regex end"]]
eNFA82_10_52925796[["εNFA82-10 post-regex start"]]
eNFA82_11_6570122[\"εNFA82-11 post-regex end"/]
eNFA82_8_34751460 -.->|"ε"|eNFA82_0_44327687
eNFA82_0_44327687 -->|"v"|eNFA82_1_63404869
eNFA82_1_63404869 -.->|"ε"|eNFA82_2_33772909
eNFA82_2_33772909 -->|"e"|eNFA82_3_35520730
eNFA82_3_35520730 -.->|"ε"|eNFA82_4_51251115
eNFA82_4_51251115 -->|"c"|eNFA82_5_58606859
eNFA82_5_58606859 -.->|"ε"|eNFA82_6_57699690
eNFA82_6_57699690 -->|"4"|eNFA82_7_49535170
eNFA82_7_49535170 -.->|"ε"|eNFA82_9_43163346
eNFA82_9_43163346 -.->|"ε"|eNFA82_10_52925796
eNFA82_10_52925796 -.->|"ε"|eNFA82_11_6570122
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
eNFA82_8_59131099[["εNFA82-8 regex start"]]
eNFA82_0_62417850[["εNFA82-0 char{1, 1}"]]
eNFA82_1_24889743[["εNFA82-1 char[1]"]]
eNFA82_2_22681099[["εNFA82-2 char{1, 1}"]]
eNFA82_3_2803303[["εNFA82-3 char[1]"]]
eNFA82_4_25229732[["εNFA82-4 char{1, 1}"]]
eNFA82_5_25741004[["εNFA82-5 char[1]"]]
eNFA82_6_30342446[["εNFA82-6 char{1, 1}"]]
eNFA82_7_4646565[\"εNFA82-7 char[1]"/]
eNFA82_9_41819089[\"εNFA82-9 regex end"/]
eNFA82_10_40827483[\"εNFA82-10 post-regex start"/]
eNFA82_11_31903028[\"εNFA82-11 post-regex end"/]
eNFA82_8_59131099 -.->|"ε"|eNFA82_0_62417850
eNFA82_8_59131099 -->|"v"|eNFA82_1_24889743
eNFA82_0_62417850 -->|"v"|eNFA82_1_24889743
eNFA82_1_24889743 -.->|"ε"|eNFA82_2_22681099
eNFA82_1_24889743 -->|"e"|eNFA82_3_2803303
eNFA82_2_22681099 -->|"e"|eNFA82_3_2803303
eNFA82_3_2803303 -.->|"ε"|eNFA82_4_25229732
eNFA82_3_2803303 -->|"c"|eNFA82_5_25741004
eNFA82_4_25229732 -->|"c"|eNFA82_5_25741004
eNFA82_5_25741004 -.->|"ε"|eNFA82_6_30342446
eNFA82_5_25741004 -->|"4"|eNFA82_7_4646565
eNFA82_6_30342446 -->|"4"|eNFA82_7_4646565
eNFA82_7_4646565 -.->|"ε"|eNFA82_9_41819089
eNFA82_7_4646565 -.->|"ε"|eNFA82_10_40827483
eNFA82_7_4646565 -.->|"ε"|eNFA82_11_31903028
eNFA82_9_41819089 -.->|"ε"|eNFA82_10_40827483
eNFA82_9_41819089 -.->|"ε"|eNFA82_11_31903028
eNFA82_10_40827483 -.->|"ε"|eNFA82_11_31903028
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
NFA82_8_18691797("NFA82-8 regex start")
NFA82_1_34008447("NFA82-1 char[1]")
NFA82_3_37640571("NFA82-3 char[1]")
NFA82_5_3220827("NFA82-5 char[1]")
NFA82_7_28987447[\"NFA82-7 char[1]"/]
NFA82_8_18691797 -->|"v"|NFA82_1_34008447
NFA82_1_34008447 -->|"e"|NFA82_3_37640571
NFA82_3_37640571 -->|"c"|NFA82_5_3220827
NFA82_5_3220827 -->|"4"|NFA82_7_28987447
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
subgraph DFA0_-909518723["DFA0 regex start"]
NFA82_8_18691797_0("NFA82-8 regex start")
end
subgraph DFA1_733200613["DFA1 {1}"]
NFA82_1_34008447_1("NFA82-1 char[1]")
end
subgraph DFA2_1376074119["DFA2 {1}"]
NFA82_3_37640571_2("NFA82-3 char[1]")
end
subgraph DFA3_487070651["DFA3 {1}"]
NFA82_5_3220827_3("NFA82-5 char[1]")
end
subgraph DFA4_1662518091["DFA4 {1}"]
NFA82_7_28987447_4[\"NFA82-7 char[1]"/]
end
DFA0_-909518723 -->|"v"|DFA1_733200613
DFA1_733200613 -->|"e"|DFA2_1376074119
DFA2_1376074119 -->|"c"|DFA3_487070651
DFA3_487070651 -->|"4"|DFA4_1662518091
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
DFA0_-909518723{{"DFA0 regex start"}}
DFA1_733200613{{"DFA1 {1}"}}
DFA2_1376074119{{"DFA2 {1}"}}
DFA3_487070651{{"DFA3 {1}"}}
DFA4_1662518091[\"DFA4 {1}"/]
DFA0_-909518723 -->|"v"|DFA1_733200613
DFA1_733200613 -->|"e"|DFA2_1376074119
DFA2_1376074119 -->|"c"|DFA3_487070651
DFA3_487070651 -->|"4"|DFA4_1662518091
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
subgraph MiniDFA0_1810996180["MiniDFA0 {1}"]
DFA0_-909518723_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_473059808["MiniDFA1 {1}"]
DFA1_733200613_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1961677176["MiniDFA2 {1}"]
DFA2_1376074119_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1912139695["MiniDFA3 {1}"]
DFA3_487070651_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-309696239["MiniDFA4 {1}"]
DFA4_1662518091_4[\"DFA4 {1}"/]
end
MiniDFA0_1810996180 -->|"v"|MiniDFA1_473059808
MiniDFA1_473059808 -->|"e"|MiniDFA2_-1961677176
MiniDFA2_-1961677176 -->|"c"|MiniDFA3_1912139695
MiniDFA3_1912139695 -->|"4"|MiniDFA4_-309696239
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
MiniDFA0_1810996180(["MiniDFA0 {1}"])
MiniDFA1_473059808(["MiniDFA1 {1}"])
MiniDFA2_-1961677176(["MiniDFA2 {1}"])
MiniDFA3_1912139695(["MiniDFA3 {1}"])
MiniDFA4_-309696239[\"MiniDFA4 {1}"/]
MiniDFA0_1810996180 -->|"v"|MiniDFA1_473059808
MiniDFA1_473059808 -->|"e"|MiniDFA2_-1961677176
MiniDFA2_-1961677176 -->|"c"|MiniDFA3_1912139695
MiniDFA3_1912139695 -->|"4"|MiniDFA4_-309696239
```
-------------------------------
