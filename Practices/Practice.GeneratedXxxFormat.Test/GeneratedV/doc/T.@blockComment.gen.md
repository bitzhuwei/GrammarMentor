# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA2_16_54470546[["εNFA2-16 regex start"]]
eNFA2_0_20472869[["εNFA2-0 char{1, 1}"]]
eNFA2_1_50038096[["εNFA2-1 char[1]"]]
eNFA2_2_47689684[["εNFA2-2 char{1, 1}"]]
eNFA2_3_45232995[["εNFA2-3 char[1]"]]
eNFA2_6_9389347[["εNFA2-6 regex start"]]
eNFA2_4_22339613[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_17395260[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_66838791[["εNFA2-7 regex end"]]
eNFA2_5_39993975[["εNFA2-5 scope[1]"]]
eNFA2_9_6046518[["εNFA2-9 scope[1]"]]
eNFA2_12_4443775[["εNFA2-12 char{1, 1}"]]
eNFA2_10_9865986[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_21685017[["εNFA2-13 char[1]"]]
eNFA2_11_4817386[["εNFA2-11 scope[1]"]]
eNFA2_14_60947427[["εNFA2-14 char{1, 1}"]]
eNFA2_15_37794593[["εNFA2-15 char[1]"]]
eNFA2_17_4607022[["εNFA2-17 regex end"]]
eNFA2_18_41463203[["εNFA2-18 post-regex start"]]
eNFA2_19_37624514[\"εNFA2-19 post-regex end"/]
eNFA2_16_54470546 -.->|"ε"|eNFA2_0_20472869
eNFA2_0_20472869 -->|"/"|eNFA2_1_50038096
eNFA2_1_50038096 -.->|"ε"|eNFA2_2_47689684
eNFA2_2_47689684 -->|"*"|eNFA2_3_45232995
eNFA2_3_45232995 -.->|"ε"|eNFA2_6_9389347
eNFA2_6_9389347 -.->|"ε"|eNFA2_4_22339613
eNFA2_6_9389347 -.->|"ε"|eNFA2_8_17395260
eNFA2_6_9389347 -.->|"ε"|eNFA2_7_66838791
eNFA2_4_22339613 -->|"[^*]"|eNFA2_5_39993975
eNFA2_8_17395260 -->|"[*]"|eNFA2_9_6046518
eNFA2_7_66838791 -.->|"ε"|eNFA2_6_9389347
eNFA2_7_66838791 -.->|"ε"|eNFA2_12_4443775
eNFA2_5_39993975 -.->|"ε"|eNFA2_7_66838791
eNFA2_9_6046518 -.->|"ε"|eNFA2_10_9865986
eNFA2_12_4443775 -->|"*"|eNFA2_13_21685017
eNFA2_10_9865986 -->|"[^/]"|eNFA2_11_4817386
eNFA2_13_21685017 -.->|"ε"|eNFA2_14_60947427
eNFA2_11_4817386 -.->|"ε"|eNFA2_7_66838791
eNFA2_14_60947427 -->|"/"|eNFA2_15_37794593
eNFA2_15_37794593 -.->|"ε"|eNFA2_17_4607022
eNFA2_17_4607022 -.->|"ε"|eNFA2_18_41463203
eNFA2_18_41463203 -.->|"ε"|eNFA2_19_37624514
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
eNFA2_16_3076306[["εNFA2-16 regex start"]]
eNFA2_0_27686757[["εNFA2-0 char{1, 1}"]]
eNFA2_1_47854229[["εNFA2-1 char[1]"]]
eNFA2_2_28034882[["εNFA2-2 char{1, 1}"]]
eNFA2_3_54418662[["εNFA2-3 char[1]"]]
eNFA2_6_26553979[["εNFA2-6 regex start"]]
eNFA2_4_3388666[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_37659220[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_30497997[["εNFA2-7 regex end"]]
eNFA2_5_45835463[["εNFA2-5 scope[1]"]]
eNFA2_9_50987349[["εNFA2-9 scope[1]"]]
eNFA2_12_20005910[["εNFA2-12 char{1, 1}"]]
eNFA2_13_36334585[["εNFA2-13 char[1]"]]
eNFA2_10_56232959[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_11655939[["εNFA2-11 scope[1]"]]
eNFA2_14_58575812[["εNFA2-14 char{1, 1}"]]
eNFA2_15_57420266[\"εNFA2-15 char[1]"/]
eNFA2_17_47020346[\"εNFA2-17 regex end"/]
eNFA2_18_20529935[\"εNFA2-18 post-regex start"/]
eNFA2_19_50551688[\"εNFA2-19 post-regex end"/]
eNFA2_16_3076306 -.->|"ε"|eNFA2_0_27686757
eNFA2_16_3076306 -->|"/"|eNFA2_1_47854229
eNFA2_0_27686757 -->|"/"|eNFA2_1_47854229
eNFA2_1_47854229 -.->|"ε"|eNFA2_2_28034882
eNFA2_1_47854229 -->|"*"|eNFA2_3_54418662
eNFA2_2_28034882 -->|"*"|eNFA2_3_54418662
eNFA2_3_54418662 -.->|"ε"|eNFA2_6_26553979
eNFA2_3_54418662 -.->|"ε"|eNFA2_4_3388666
eNFA2_3_54418662 -.->|"ε"|eNFA2_8_37659220
eNFA2_3_54418662 -.->|"ε"|eNFA2_7_30497997
eNFA2_3_54418662 -->|"[^*]"|eNFA2_5_45835463
eNFA2_3_54418662 -->|"[*]"|eNFA2_9_50987349
eNFA2_3_54418662 -.->|"ε"|eNFA2_12_20005910
eNFA2_3_54418662 -->|"*"|eNFA2_13_36334585
eNFA2_6_26553979 -.->|"ε"|eNFA2_4_3388666
eNFA2_6_26553979 -.->|"ε"|eNFA2_8_37659220
eNFA2_6_26553979 -.->|"ε"|eNFA2_7_30497997
eNFA2_6_26553979 -->|"[^*]"|eNFA2_5_45835463
eNFA2_6_26553979 -->|"[*]"|eNFA2_9_50987349
eNFA2_6_26553979 -.->|"ε"|eNFA2_6_26553979
eNFA2_6_26553979 -.->|"ε"|eNFA2_12_20005910
eNFA2_6_26553979 -->|"*"|eNFA2_13_36334585
eNFA2_4_3388666 -->|"[^*]"|eNFA2_5_45835463
eNFA2_8_37659220 -->|"[*]"|eNFA2_9_50987349
eNFA2_7_30497997 -.->|"ε"|eNFA2_6_26553979
eNFA2_7_30497997 -.->|"ε"|eNFA2_12_20005910
eNFA2_7_30497997 -.->|"ε"|eNFA2_4_3388666
eNFA2_7_30497997 -.->|"ε"|eNFA2_8_37659220
eNFA2_7_30497997 -.->|"ε"|eNFA2_7_30497997
eNFA2_7_30497997 -->|"[^*]"|eNFA2_5_45835463
eNFA2_7_30497997 -->|"[*]"|eNFA2_9_50987349
eNFA2_7_30497997 -->|"*"|eNFA2_13_36334585
eNFA2_5_45835463 -.->|"ε"|eNFA2_7_30497997
eNFA2_5_45835463 -.->|"ε"|eNFA2_6_26553979
eNFA2_5_45835463 -.->|"ε"|eNFA2_12_20005910
eNFA2_5_45835463 -.->|"ε"|eNFA2_4_3388666
eNFA2_5_45835463 -.->|"ε"|eNFA2_8_37659220
eNFA2_5_45835463 -->|"[^*]"|eNFA2_5_45835463
eNFA2_5_45835463 -->|"[*]"|eNFA2_9_50987349
eNFA2_5_45835463 -->|"*"|eNFA2_13_36334585
eNFA2_9_50987349 -.->|"ε"|eNFA2_10_56232959
eNFA2_9_50987349 -->|"[^/]"|eNFA2_11_11655939
eNFA2_12_20005910 -->|"*"|eNFA2_13_36334585
eNFA2_13_36334585 -.->|"ε"|eNFA2_14_58575812
eNFA2_13_36334585 -->|"/"|eNFA2_15_57420266
eNFA2_10_56232959 -->|"[^/]"|eNFA2_11_11655939
eNFA2_11_11655939 -.->|"ε"|eNFA2_7_30497997
eNFA2_11_11655939 -.->|"ε"|eNFA2_6_26553979
eNFA2_11_11655939 -.->|"ε"|eNFA2_12_20005910
eNFA2_11_11655939 -.->|"ε"|eNFA2_4_3388666
eNFA2_11_11655939 -.->|"ε"|eNFA2_8_37659220
eNFA2_11_11655939 -->|"[^*]"|eNFA2_5_45835463
eNFA2_11_11655939 -->|"[*]"|eNFA2_9_50987349
eNFA2_11_11655939 -->|"*"|eNFA2_13_36334585
eNFA2_14_58575812 -->|"/"|eNFA2_15_57420266
eNFA2_15_57420266 -.->|"ε"|eNFA2_17_47020346
eNFA2_15_57420266 -.->|"ε"|eNFA2_18_20529935
eNFA2_15_57420266 -.->|"ε"|eNFA2_19_50551688
eNFA2_17_47020346 -.->|"ε"|eNFA2_18_20529935
eNFA2_17_47020346 -.->|"ε"|eNFA2_19_50551688
eNFA2_18_20529935 -.->|"ε"|eNFA2_19_50551688
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
NFA2_16_18383511("NFA2-16 regex start")
NFA2_1_31233872("NFA2-1 char[1]")
NFA2_3_52312016("NFA2-3 char[1]")
NFA2_5_9414935("NFA2-5 scope[1]")
NFA2_9_1046103("NFA2-9 scope[1]")
NFA2_13_17625551("NFA2-13 char[1]")
NFA2_11_24412233("NFA2-11 scope[1]")
NFA2_15_12669399[\"NFA2-15 char[1]"/]
NFA2_16_18383511 -->|"/"|NFA2_1_31233872
NFA2_1_31233872 -->|"*"|NFA2_3_52312016
NFA2_3_52312016 -->|"[^*]"|NFA2_5_9414935
NFA2_3_52312016 -->|"[*]"|NFA2_9_1046103
NFA2_3_52312016 -->|"*"|NFA2_13_17625551
NFA2_5_9414935 -->|"[^*]"|NFA2_5_9414935
NFA2_5_9414935 -->|"[*]"|NFA2_9_1046103
NFA2_5_9414935 -->|"*"|NFA2_13_17625551
NFA2_9_1046103 -->|"[^/]"|NFA2_11_24412233
NFA2_13_17625551 -->|"/"|NFA2_15_12669399
NFA2_11_24412233 -->|"[^*]"|NFA2_5_9414935
NFA2_11_24412233 -->|"[*]"|NFA2_9_1046103
NFA2_11_24412233 -->|"*"|NFA2_13_17625551
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
subgraph DFA0_-1808193467["DFA0 regex start"]
NFA2_16_18383511_0("NFA2-16 regex start")
end
subgraph DFA1_391315681["DFA1 {1}"]
NFA2_1_31233872_1("NFA2-1 char[1]")
end
subgraph DFA2_-2126499099["DFA2 {1}"]
NFA2_3_52312016_2("NFA2-3 char[1]")
end
subgraph DFA3_1998230706["DFA3 {1}"]
NFA2_5_9414935_3("NFA2-5 scope[1]")
end
subgraph DFA4_-1556493412["DFA4 {2}"]
NFA2_9_1046103_4("NFA2-9 scope[1]")
NFA2_13_17625551_5("NFA2-13 char[1]")
end
subgraph DFA5_1288116315["DFA5 {1}"]
NFA2_11_24412233_6("NFA2-11 scope[1]")
end
subgraph DFA6_-542645053["DFA6 {1}"]
NFA2_15_12669399_7[\"NFA2-15 char[1]"/]
end
DFA0_-1808193467 -->|"/"|DFA1_391315681
DFA1_391315681 -->|"*"|DFA2_-2126499099
DFA2_-2126499099 -->|"[^*]"|DFA3_1998230706
DFA2_-2126499099 -->|"*"|DFA4_-1556493412
DFA3_1998230706 -->|"[^*]"|DFA3_1998230706
DFA3_1998230706 -->|"*"|DFA4_-1556493412
DFA4_-1556493412 -->|"[^/]"|DFA5_1288116315
DFA4_-1556493412 -->|"/"|DFA6_-542645053
DFA5_1288116315 -->|"[^*]"|DFA3_1998230706
DFA5_1288116315 -->|"*"|DFA4_-1556493412
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
DFA0_-1808193467{{"DFA0 regex start"}}
DFA1_391315681{{"DFA1 {1}"}}
DFA2_-2126499099{{"DFA2 {1}"}}
DFA3_1998230706{{"DFA3 {1}"}}
DFA4_-1556493412{{"DFA4 {2}"}}
DFA5_1288116315{{"DFA5 {1}"}}
DFA6_-542645053[\"DFA6 {1}"/]
DFA0_-1808193467 -->|"/"|DFA1_391315681
DFA1_391315681 -->|"*"|DFA2_-2126499099
DFA2_-2126499099 -->|"[^*]"|DFA3_1998230706
DFA2_-2126499099 -->|"*"|DFA4_-1556493412
DFA3_1998230706 -->|"[^*]"|DFA3_1998230706
DFA3_1998230706 -->|"*"|DFA4_-1556493412
DFA4_-1556493412 -->|"[^/]"|DFA5_1288116315
DFA4_-1556493412 -->|"/"|DFA6_-542645053
DFA5_1288116315 -->|"[^*]"|DFA3_1998230706
DFA5_1288116315 -->|"*"|DFA4_-1556493412
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
subgraph MiniDFA0_-660557185["MiniDFA0 {1}"]
DFA0_-1808193467_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1077216717["MiniDFA1 {1}"]
DFA1_391315681_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1876249119["MiniDFA2 {3}"]
DFA2_-2126499099_2{{"DFA2 {1}"}}
DFA3_1998230706_3{{"DFA3 {1}"}}
DFA5_1288116315_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_1602337203["MiniDFA3 {1}"]
DFA4_-1556493412_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-2095570459["MiniDFA4 {1}"]
DFA6_-542645053_6[\"DFA6 {1}"/]
end
MiniDFA0_-660557185 -->|"/"|MiniDFA1_1077216717
MiniDFA1_1077216717 -->|"*"|MiniDFA2_-1876249119
MiniDFA2_-1876249119 -->|"[^*]"|MiniDFA2_-1876249119
MiniDFA2_-1876249119 -->|"*"|MiniDFA3_1602337203
MiniDFA3_1602337203 -->|"[^/]"|MiniDFA2_-1876249119
MiniDFA3_1602337203 -->|"/"|MiniDFA4_-2095570459
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
MiniDFA0_-660557185(["MiniDFA0 {1}"])
MiniDFA1_1077216717(["MiniDFA1 {1}"])
MiniDFA2_-1876249119(["MiniDFA2 {3}"])
MiniDFA3_1602337203(["MiniDFA3 {1}"])
MiniDFA4_-2095570459[\"MiniDFA4 {1}"/]
MiniDFA0_-660557185 -->|"/"|MiniDFA1_1077216717
MiniDFA1_1077216717 -->|"*"|MiniDFA2_-1876249119
MiniDFA2_-1876249119 -->|"[^*]"|MiniDFA2_-1876249119
MiniDFA2_-1876249119 -->|"*"|MiniDFA3_1602337203
MiniDFA3_1602337203 -->|"[^/]"|MiniDFA2_-1876249119
MiniDFA3_1602337203 -->|"/"|MiniDFA4_-2095570459
```
-------------------------------
