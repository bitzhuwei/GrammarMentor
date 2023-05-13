# 'case'

pattern: `case`

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
eNFA200_8_26137388[["εNFA200-8 regex start"]]
eNFA200_0_33909907[["εNFA200-0 char{1, 1}"]]
eNFA200_1_36753709[["εNFA200-1 char[1]"]]
eNFA200_2_62347933[["εNFA200-2 char{1, 1}"]]
eNFA200_3_24260491[["εNFA200-3 char[1]"]]
eNFA200_4_17017832[["εNFA200-4 char{1, 1}"]]
eNFA200_5_18942765[["εNFA200-5 char[1]"]]
eNFA200_6_36267164[["εNFA200-6 char{1, 1}"]]
eNFA200_7_57969020[["εNFA200-7 char[1]"]]
eNFA200_9_51959135[["εNFA200-9 regex end"]]
eNFA200_10_64979039[["εNFA200-10 post-regex start"]]
eNFA200_11_47940444[\"εNFA200-11 post-regex end"/]
eNFA200_8_26137388 -.->|"ε"|eNFA200_0_33909907
eNFA200_0_33909907 -->|"c"|eNFA200_1_36753709
eNFA200_1_36753709 -.->|"ε"|eNFA200_2_62347933
eNFA200_2_62347933 -->|"a"|eNFA200_3_24260491
eNFA200_3_24260491 -.->|"ε"|eNFA200_4_17017832
eNFA200_4_17017832 -->|"s"|eNFA200_5_18942765
eNFA200_5_18942765 -.->|"ε"|eNFA200_6_36267164
eNFA200_6_36267164 -->|"e"|eNFA200_7_57969020
eNFA200_7_57969020 -.->|"ε"|eNFA200_9_51959135
eNFA200_9_51959135 -.->|"ε"|eNFA200_10_64979039
eNFA200_10_64979039 -.->|"ε"|eNFA200_11_47940444
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
eNFA200_8_28810815[["εNFA200-8 regex start"]]
eNFA200_0_57970745[["εNFA200-0 char{1, 1}"]]
eNFA200_1_51974659[["εNFA200-1 char[1]"]]
eNFA200_2_65118750[["εNFA200-2 char{1, 1}"]]
eNFA200_3_49197844[["εNFA200-3 char[1]"]]
eNFA200_4_40127412[["εNFA200-4 char{1, 1}"]]
eNFA200_5_25602393[["εNFA200-5 char[1]"]]
eNFA200_6_29094946[["εNFA200-6 char{1, 1}"]]
eNFA200_7_60527930[\"εNFA200-7 char[1]"/]
eNFA200_9_7880465[\"εNFA200-9 regex end"/]
eNFA200_10_3815329[\"εNFA200-10 post-regex start"/]
eNFA200_11_34337961[\"εNFA200-11 post-regex end"/]
eNFA200_8_28810815 -.->|"ε"|eNFA200_0_57970745
eNFA200_8_28810815 -->|"c"|eNFA200_1_51974659
eNFA200_0_57970745 -->|"c"|eNFA200_1_51974659
eNFA200_1_51974659 -.->|"ε"|eNFA200_2_65118750
eNFA200_1_51974659 -->|"a"|eNFA200_3_49197844
eNFA200_2_65118750 -->|"a"|eNFA200_3_49197844
eNFA200_3_49197844 -.->|"ε"|eNFA200_4_40127412
eNFA200_3_49197844 -->|"s"|eNFA200_5_25602393
eNFA200_4_40127412 -->|"s"|eNFA200_5_25602393
eNFA200_5_25602393 -.->|"ε"|eNFA200_6_29094946
eNFA200_5_25602393 -->|"e"|eNFA200_7_60527930
eNFA200_6_29094946 -->|"e"|eNFA200_7_60527930
eNFA200_7_60527930 -.->|"ε"|eNFA200_9_7880465
eNFA200_7_60527930 -.->|"ε"|eNFA200_10_3815329
eNFA200_7_60527930 -.->|"ε"|eNFA200_11_34337961
eNFA200_9_7880465 -.->|"ε"|eNFA200_10_3815329
eNFA200_9_7880465 -.->|"ε"|eNFA200_11_34337961
eNFA200_10_3815329 -.->|"ε"|eNFA200_11_34337961
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
NFA200_8_40606195("NFA200-8 regex start")
NFA200_1_29911441("NFA200-1 char[1]")
NFA200_3_767514("NFA200-3 char[1]")
NFA200_5_6907633("NFA200-5 char[1]")
NFA200_7_62168702[\"NFA200-7 char[1]"/]
NFA200_8_40606195 -->|"c"|NFA200_1_29911441
NFA200_1_29911441 -->|"a"|NFA200_3_767514
NFA200_3_767514 -->|"s"|NFA200_5_6907633
NFA200_5_6907633 -->|"e"|NFA200_7_62168702
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
subgraph DFA0_-398020487["DFA0 regex start"]
NFA200_8_40606195_0("NFA200-8 regex start")
end
subgraph DFA1_2109101375["DFA1 {1}"]
NFA200_1_29911441_1("NFA200-1 char[1]")
end
subgraph DFA2_-215947037["DFA2 {1}"]
NFA200_3_767514_2("NFA200-3 char[1]")
end
subgraph DFA3_-1278650064["DFA3 {1}"]
NFA200_5_6907633_3("NFA200-5 char[1]")
end
subgraph DFA4_-1072731847["DFA4 {1}"]
NFA200_7_62168702_4[\"NFA200-7 char[1]"/]
end
DFA0_-398020487 -->|"c"|DFA1_2109101375
DFA1_2109101375 -->|"a"|DFA2_-215947037
DFA2_-215947037 -->|"s"|DFA3_-1278650064
DFA3_-1278650064 -->|"e"|DFA4_-1072731847
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
DFA0_-398020487{{"DFA0 regex start"}}
DFA1_2109101375{{"DFA1 {1}"}}
DFA2_-215947037{{"DFA2 {1}"}}
DFA3_-1278650064{{"DFA3 {1}"}}
DFA4_-1072731847[\"DFA4 {1}"/]
DFA0_-398020487 -->|"c"|DFA1_2109101375
DFA1_2109101375 -->|"a"|DFA2_-215947037
DFA2_-215947037 -->|"s"|DFA3_-1278650064
DFA3_-1278650064 -->|"e"|DFA4_-1072731847
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
subgraph MiniDFA0_-273352615["MiniDFA0 {1}"]
DFA0_-398020487_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1417632637["MiniDFA1 {1}"]
DFA1_2109101375_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1865076789["MiniDFA2 {1}"]
DFA2_-215947037_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1141647997["MiniDFA3 {1}"]
DFA3_-1278650064_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-847993021["MiniDFA4 {1}"]
DFA4_-1072731847_4[\"DFA4 {1}"/]
end
MiniDFA0_-273352615 -->|"c"|MiniDFA1_-1417632637
MiniDFA1_-1417632637 -->|"a"|MiniDFA2_-1865076789
MiniDFA2_-1865076789 -->|"s"|MiniDFA3_1141647997
MiniDFA3_1141647997 -->|"e"|MiniDFA4_-847993021
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
MiniDFA0_-273352615(["MiniDFA0 {1}"])
MiniDFA1_-1417632637(["MiniDFA1 {1}"])
MiniDFA2_-1865076789(["MiniDFA2 {1}"])
MiniDFA3_1141647997(["MiniDFA3 {1}"])
MiniDFA4_-847993021[\"MiniDFA4 {1}"/]
MiniDFA0_-273352615 -->|"c"|MiniDFA1_-1417632637
MiniDFA1_-1417632637 -->|"a"|MiniDFA2_-1865076789
MiniDFA2_-1865076789 -->|"s"|MiniDFA3_1141647997
MiniDFA3_1141647997 -->|"e"|MiniDFA4_-847993021
```
-------------------------------
