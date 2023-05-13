# 'uvec4'

pattern: `uvec4`

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
eNFA94_10_64374149[["εNFA94-10 regex start"]]
eNFA94_0_42496437[["εNFA94-0 char{1, 1}"]]
eNFA94_1_46923618[["εNFA94-1 char[1]"]]
eNFA94_2_19659381[["εNFA94-2 char{1, 1}"]]
eNFA94_3_42716703[["εNFA94-3 char[1]"]]
eNFA94_4_48906009[["εNFA94-4 char{1, 1}"]]
eNFA94_5_37500900[["εNFA94-5 char[1]"]]
eNFA94_6_1963786[["εNFA94-6 char{1, 1}"]]
eNFA94_7_17674074[["εNFA94-7 char[1]"]]
eNFA94_8_24848943[["εNFA94-8 char{1, 1}"]]
eNFA94_9_22313896[["εNFA94-9 char[1]"]]
eNFA94_11_66607344[["εNFA94-11 regex end"]]
eNFA94_12_62595191[["εNFA94-12 post-regex start"]]
eNFA94_13_26485815[\"εNFA94-13 post-regex end"/]
eNFA94_10_64374149 -.->|"ε"|eNFA94_0_42496437
eNFA94_0_42496437 -->|"u"|eNFA94_1_46923618
eNFA94_1_46923618 -.->|"ε"|eNFA94_2_19659381
eNFA94_2_19659381 -->|"v"|eNFA94_3_42716703
eNFA94_3_42716703 -.->|"ε"|eNFA94_4_48906009
eNFA94_4_48906009 -->|"e"|eNFA94_5_37500900
eNFA94_5_37500900 -.->|"ε"|eNFA94_6_1963786
eNFA94_6_1963786 -->|"c"|eNFA94_7_17674074
eNFA94_7_17674074 -.->|"ε"|eNFA94_8_24848943
eNFA94_8_24848943 -->|"4"|eNFA94_9_22313896
eNFA94_9_22313896 -.->|"ε"|eNFA94_11_66607344
eNFA94_11_66607344 -.->|"ε"|eNFA94_12_62595191
eNFA94_12_62595191 -.->|"ε"|eNFA94_13_26485815
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
eNFA94_10_37045743[["εNFA94-10 regex start"]]
eNFA94_0_64976233[["εNFA94-0 char{1, 1}"]]
eNFA94_1_47915191[["εNFA94-1 char[1]"]]
eNFA94_2_28583536[["εNFA94-2 char{1, 1}"]]
eNFA94_3_55925239[["εNFA94-3 char[1]"]]
eNFA94_4_33565108[["εNFA94-4 char{1, 1}"]]
eNFA94_5_33650520[["εNFA94-5 char[1]"]]
eNFA94_6_34419228[["εNFA94-6 char{1, 1}"]]
eNFA94_7_41337601[["εNFA94-7 char[1]"]]
eNFA94_8_36494097[["εNFA94-8 char{1, 1}"]]
eNFA94_9_60011419[\"εNFA94-9 char[1]"/]
eNFA94_11_3231866[\"εNFA94-11 regex end"/]
eNFA94_12_29086798[\"εNFA94-12 post-regex start"/]
eNFA94_13_60454592[\"εNFA94-13 post-regex end"/]
eNFA94_10_37045743 -.->|"ε"|eNFA94_0_64976233
eNFA94_10_37045743 -->|"u"|eNFA94_1_47915191
eNFA94_0_64976233 -->|"u"|eNFA94_1_47915191
eNFA94_1_47915191 -.->|"ε"|eNFA94_2_28583536
eNFA94_1_47915191 -->|"v"|eNFA94_3_55925239
eNFA94_2_28583536 -->|"v"|eNFA94_3_55925239
eNFA94_3_55925239 -.->|"ε"|eNFA94_4_33565108
eNFA94_3_55925239 -->|"e"|eNFA94_5_33650520
eNFA94_4_33565108 -->|"e"|eNFA94_5_33650520
eNFA94_5_33650520 -.->|"ε"|eNFA94_6_34419228
eNFA94_5_33650520 -->|"c"|eNFA94_7_41337601
eNFA94_6_34419228 -->|"c"|eNFA94_7_41337601
eNFA94_7_41337601 -.->|"ε"|eNFA94_8_36494097
eNFA94_7_41337601 -->|"4"|eNFA94_9_60011419
eNFA94_8_36494097 -->|"4"|eNFA94_9_60011419
eNFA94_9_60011419 -.->|"ε"|eNFA94_11_3231866
eNFA94_9_60011419 -.->|"ε"|eNFA94_12_29086798
eNFA94_9_60011419 -.->|"ε"|eNFA94_13_60454592
eNFA94_11_3231866 -.->|"ε"|eNFA94_12_29086798
eNFA94_11_3231866 -.->|"ε"|eNFA94_13_60454592
eNFA94_12_29086798 -.->|"ε"|eNFA94_13_60454592
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
NFA94_10_7220417("NFA94-10 regex start")
NFA94_1_64983754("NFA94-1 char[1]")
NFA94_3_47982876("NFA94-3 char[1]")
NFA94_5_29192704("NFA94-5 char[1]")
NFA94_7_61407752("NFA94-7 char[1]")
NFA94_9_15798860[\"NFA94-9 char[1]"/]
NFA94_10_7220417 -->|"u"|NFA94_1_64983754
NFA94_1_64983754 -->|"v"|NFA94_3_47982876
NFA94_3_47982876 -->|"e"|NFA94_5_29192704
NFA94_5_29192704 -->|"c"|NFA94_7_61407752
NFA94_7_61407752 -->|"4"|NFA94_9_15798860
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
subgraph DFA0_1309126945["DFA0 regex start"]
NFA94_10_7220417_0("NFA94-10 regex start")
end
subgraph DFA1_267843065["DFA1 {1}"]
NFA94_1_64983754_1("NFA94-1 char[1]")
end
subgraph DFA2_-1484082236["DFA2 {1}"]
NFA94_3_47982876_2("NFA94-3 char[1]")
end
subgraph DFA3_-852411894["DFA3 {1}"]
NFA94_5_29192704_3("NFA94-5 char[1]")
end
subgraph DFA4_-1124044143["DFA4 {1}"]
NFA94_7_61407752_4("NFA94-7 char[1]")
end
subgraph DFA5_373398013["DFA5 {1}"]
NFA94_9_15798860_5[\"NFA94-9 char[1]"/]
end
DFA0_1309126945 -->|"u"|DFA1_267843065
DFA1_267843065 -->|"v"|DFA2_-1484082236
DFA2_-1484082236 -->|"e"|DFA3_-852411894
DFA3_-852411894 -->|"c"|DFA4_-1124044143
DFA4_-1124044143 -->|"4"|DFA5_373398013
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
DFA0_1309126945{{"DFA0 regex start"}}
DFA1_267843065{{"DFA1 {1}"}}
DFA2_-1484082236{{"DFA2 {1}"}}
DFA3_-852411894{{"DFA3 {1}"}}
DFA4_-1124044143{{"DFA4 {1}"}}
DFA5_373398013[\"DFA5 {1}"/]
DFA0_1309126945 -->|"u"|DFA1_267843065
DFA1_267843065 -->|"v"|DFA2_-1484082236
DFA2_-1484082236 -->|"e"|DFA3_-852411894
DFA3_-852411894 -->|"c"|DFA4_-1124044143
DFA4_-1124044143 -->|"4"|DFA5_373398013
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
subgraph MiniDFA0_-1412364997["MiniDFA0 {1}"]
DFA0_1309126945_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-469325817["MiniDFA1 {1}"]
DFA1_267843065_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1054972923["MiniDFA2 {1}"]
DFA2_-1484082236_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1215051936["MiniDFA3 {1}"]
DFA3_-852411894_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_982685027["MiniDFA4 {1}"]
DFA4_-1124044143_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_860097742["MiniDFA5 {1}"]
DFA5_373398013_5[\"DFA5 {1}"/]
end
MiniDFA0_-1412364997 -->|"u"|MiniDFA1_-469325817
MiniDFA1_-469325817 -->|"v"|MiniDFA2_1054972923
MiniDFA2_1054972923 -->|"e"|MiniDFA3_-1215051936
MiniDFA3_-1215051936 -->|"c"|MiniDFA4_982685027
MiniDFA4_982685027 -->|"4"|MiniDFA5_860097742
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
MiniDFA0_-1412364997(["MiniDFA0 {1}"])
MiniDFA1_-469325817(["MiniDFA1 {1}"])
MiniDFA2_1054972923(["MiniDFA2 {1}"])
MiniDFA3_-1215051936(["MiniDFA3 {1}"])
MiniDFA4_982685027(["MiniDFA4 {1}"])
MiniDFA5_860097742[\"MiniDFA5 {1}"/]
MiniDFA0_-1412364997 -->|"u"|MiniDFA1_-469325817
MiniDFA1_-469325817 -->|"v"|MiniDFA2_1054972923
MiniDFA2_1054972923 -->|"e"|MiniDFA3_-1215051936
MiniDFA3_-1215051936 -->|"c"|MiniDFA4_982685027
MiniDFA4_982685027 -->|"4"|MiniDFA5_860097742
```
-------------------------------
