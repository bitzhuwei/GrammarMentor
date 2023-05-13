# 'bvec2'

pattern: `bvec2`

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
eNFA86_10_32794215[["εNFA86-10 regex start"]]
eNFA86_0_26712487[["εNFA86-0 char{1, 1}"]]
eNFA86_1_39085796[["εNFA86-1 char[1]"]]
eNFA86_2_16227847[["εNFA86-2 char{1, 1}"]]
eNFA86_3_11832897[["εNFA86-3 char[1]"]]
eNFA86_4_39387211[["εNFA86-4 char{1, 1}"]]
eNFA86_5_18940582[["εNFA86-5 char[1]"]]
eNFA86_6_36247516[["εNFA86-6 char{1, 1}"]]
eNFA86_7_57792188[["εNFA86-7 char[1]"]]
eNFA86_8_50367649[["εNFA86-8 char{1, 1}"]]
eNFA86_9_50655658[["εNFA86-9 char[1]"]]
eNFA86_11_53247746[["εNFA86-11 regex end"]]
eNFA86_12_9467673[["εNFA86-12 post-regex start"]]
eNFA86_13_18100201[\"εNFA86-13 post-regex end"/]
eNFA86_10_32794215 -.->|"ε"|eNFA86_0_26712487
eNFA86_0_26712487 -->|"b"|eNFA86_1_39085796
eNFA86_1_39085796 -.->|"ε"|eNFA86_2_16227847
eNFA86_2_16227847 -->|"v"|eNFA86_3_11832897
eNFA86_3_11832897 -.->|"ε"|eNFA86_4_39387211
eNFA86_4_39387211 -->|"e"|eNFA86_5_18940582
eNFA86_5_18940582 -.->|"ε"|eNFA86_6_36247516
eNFA86_6_36247516 -->|"c"|eNFA86_7_57792188
eNFA86_7_57792188 -.->|"ε"|eNFA86_8_50367649
eNFA86_8_50367649 -->|"2"|eNFA86_9_50655658
eNFA86_9_50655658 -.->|"ε"|eNFA86_11_53247746
eNFA86_11_53247746 -.->|"ε"|eNFA86_12_9467673
eNFA86_12_9467673 -.->|"ε"|eNFA86_13_18100201
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
eNFA86_10_28684081[["εNFA86-10 regex start"]]
eNFA86_0_56830139[["εNFA86-0 char{1, 1}"]]
eNFA86_1_41709209[["εNFA86-1 char[1]"]]
eNFA86_2_39838562[["εNFA86-2 char{1, 1}"]]
eNFA86_3_23002745[["εNFA86-3 char[1]"]]
eNFA86_4_5698118[["εNFA86-4 char{1, 1}"]]
eNFA86_5_51283066[["εNFA86-5 char[1]"]]
eNFA86_6_58894414[["εNFA86-6 char{1, 1}"]]
eNFA86_7_60287683[["εNFA86-7 char[1]"]]
eNFA86_8_5718243[["εNFA86-8 char{1, 1}"]]
eNFA86_9_51464189[\"εNFA86-9 char[1]"/]
eNFA86_11_60524524[\"εNFA86-11 regex end"/]
eNFA86_12_7849808[\"εNFA86-12 post-regex start"/]
eNFA86_13_3539410[\"εNFA86-13 post-regex end"/]
eNFA86_10_28684081 -.->|"ε"|eNFA86_0_56830139
eNFA86_10_28684081 -->|"b"|eNFA86_1_41709209
eNFA86_0_56830139 -->|"b"|eNFA86_1_41709209
eNFA86_1_41709209 -.->|"ε"|eNFA86_2_39838562
eNFA86_1_41709209 -->|"v"|eNFA86_3_23002745
eNFA86_2_39838562 -->|"v"|eNFA86_3_23002745
eNFA86_3_23002745 -.->|"ε"|eNFA86_4_5698118
eNFA86_3_23002745 -->|"e"|eNFA86_5_51283066
eNFA86_4_5698118 -->|"e"|eNFA86_5_51283066
eNFA86_5_51283066 -.->|"ε"|eNFA86_6_58894414
eNFA86_5_51283066 -->|"c"|eNFA86_7_60287683
eNFA86_6_58894414 -->|"c"|eNFA86_7_60287683
eNFA86_7_60287683 -.->|"ε"|eNFA86_8_5718243
eNFA86_7_60287683 -->|"2"|eNFA86_9_51464189
eNFA86_8_5718243 -->|"2"|eNFA86_9_51464189
eNFA86_9_51464189 -.->|"ε"|eNFA86_11_60524524
eNFA86_9_51464189 -.->|"ε"|eNFA86_12_7849808
eNFA86_9_51464189 -.->|"ε"|eNFA86_13_3539410
eNFA86_11_60524524 -.->|"ε"|eNFA86_12_7849808
eNFA86_11_60524524 -.->|"ε"|eNFA86_13_3539410
eNFA86_12_7849808 -.->|"ε"|eNFA86_13_3539410
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
NFA86_10_31854691("NFA86-10 regex start")
NFA86_1_18256764("NFA86-1 char[1]")
NFA86_3_30093150("NFA86-3 char[1]")
NFA86_5_2402898("NFA86-5 char[1]")
NFA86_7_21626090("NFA86-7 char[1]")
NFA86_9_60417086[\"NFA86-9 char[1]"/]
NFA86_10_31854691 -->|"b"|NFA86_1_18256764
NFA86_1_18256764 -->|"v"|NFA86_3_30093150
NFA86_3_30093150 -->|"e"|NFA86_5_2402898
NFA86_5_2402898 -->|"c"|NFA86_7_21626090
NFA86_7_21626090 -->|"2"|NFA86_9_60417086
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
subgraph DFA0_1250345236["DFA0 regex start"]
NFA86_10_31854691_0("NFA86-10 regex start")
end
subgraph DFA1_-327122050["DFA1 {1}"]
NFA86_1_18256764_1("NFA86-1 char[1]")
end
subgraph DFA2_-974323597["DFA2 {1}"]
NFA86_3_30093150_2("NFA86-3 char[1]")
end
subgraph DFA3_6160314["DFA3 {1}"]
NFA86_5_2402898_3("NFA86-5 char[1]")
end
subgraph DFA4_-1700889712["DFA4 {1}"]
NFA86_7_21626090_4("NFA86-7 char[1]")
end
subgraph DFA5_-1205690418["DFA5 {1}"]
NFA86_9_60417086_5[\"NFA86-9 char[1]"/]
end
DFA0_1250345236 -->|"b"|DFA1_-327122050
DFA1_-327122050 -->|"v"|DFA2_-974323597
DFA2_-974323597 -->|"e"|DFA3_6160314
DFA3_6160314 -->|"c"|DFA4_-1700889712
DFA4_-1700889712 -->|"2"|DFA5_-1205690418
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
DFA0_1250345236{{"DFA0 regex start"}}
DFA1_-327122050{{"DFA1 {1}"}}
DFA2_-974323597{{"DFA2 {1}"}}
DFA3_6160314{{"DFA3 {1}"}}
DFA4_-1700889712{{"DFA4 {1}"}}
DFA5_-1205690418[\"DFA5 {1}"/]
DFA0_1250345236 -->|"b"|DFA1_-327122050
DFA1_-327122050 -->|"v"|DFA2_-974323597
DFA2_-974323597 -->|"e"|DFA3_6160314
DFA3_6160314 -->|"c"|DFA4_-1700889712
DFA4_-1700889712 -->|"2"|DFA5_-1205690418
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
subgraph MiniDFA0_-1606990763["MiniDFA0 {1}"]
DFA0_1250345236_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1359096229["MiniDFA1 {1}"]
DFA1_-327122050_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1431874["MiniDFA2 {1}"]
DFA2_-974323597_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1977857268["MiniDFA3 {1}"]
DFA3_6160314_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-951377868["MiniDFA4 {1}"]
DFA4_-1700889712_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-505712254["MiniDFA5 {1}"]
DFA5_-1205690418_5[\"DFA5 {1}"/]
end
MiniDFA0_-1606990763 -->|"b"|MiniDFA1_-1359096229
MiniDFA1_-1359096229 -->|"v"|MiniDFA2_-1431874
MiniDFA2_-1431874 -->|"e"|MiniDFA3_1977857268
MiniDFA3_1977857268 -->|"c"|MiniDFA4_-951377868
MiniDFA4_-951377868 -->|"2"|MiniDFA5_-505712254
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
MiniDFA0_-1606990763(["MiniDFA0 {1}"])
MiniDFA1_-1359096229(["MiniDFA1 {1}"])
MiniDFA2_-1431874(["MiniDFA2 {1}"])
MiniDFA3_1977857268(["MiniDFA3 {1}"])
MiniDFA4_-951377868(["MiniDFA4 {1}"])
MiniDFA5_-505712254[\"MiniDFA5 {1}"/]
MiniDFA0_-1606990763 -->|"b"|MiniDFA1_-1359096229
MiniDFA1_-1359096229 -->|"v"|MiniDFA2_-1431874
MiniDFA2_-1431874 -->|"e"|MiniDFA3_1977857268
MiniDFA3_1977857268 -->|"c"|MiniDFA4_-951377868
MiniDFA4_-951377868 -->|"2"|MiniDFA5_-505712254
```
-------------------------------
