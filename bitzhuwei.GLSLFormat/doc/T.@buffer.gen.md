# 'buffer'

pattern: `buffer`

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
eNFA66_12_40072161[["εNFA66-12 regex start"]]
eNFA66_0_25105132[["εNFA66-0 char{1, 1}"]]
eNFA66_1_24619602[["εNFA66-1 char[1]"]]
eNFA66_2_20249826[["εNFA66-2 char{1, 1}"]]
eNFA66_3_48030711[["εNFA66-3 char[1]"]]
eNFA66_4_29623216[["εNFA66-4 char{1, 1}"]]
eNFA66_5_65282360[["εNFA66-5 char[1]"]]
eNFA66_6_50670335[["εNFA66-6 char{1, 1}"]]
eNFA66_7_53379839[["εNFA66-7 char[1]"]]
eNFA66_8_10656503[["εNFA66-8 char{1, 1}"]]
eNFA66_9_28799665[["εNFA66-9 char[1]"]]
eNFA66_10_57870399[["εNFA66-10 char{1, 1}"]]
eNFA66_11_51071544[["εNFA66-11 char[1]"]]
eNFA66_13_56990719[["εNFA66-13 regex end"]]
eNFA66_14_43154428[["εNFA66-14 post-regex start"]]
eNFA66_15_52845536[\"εNFA66-15 post-regex end"/]
eNFA66_12_40072161 -.->|"ε"|eNFA66_0_25105132
eNFA66_0_25105132 -->|"b"|eNFA66_1_24619602
eNFA66_1_24619602 -.->|"ε"|eNFA66_2_20249826
eNFA66_2_20249826 -->|"u"|eNFA66_3_48030711
eNFA66_3_48030711 -.->|"ε"|eNFA66_4_29623216
eNFA66_4_29623216 -->|"f"|eNFA66_5_65282360
eNFA66_5_65282360 -.->|"ε"|eNFA66_6_50670335
eNFA66_6_50670335 -->|"f"|eNFA66_7_53379839
eNFA66_7_53379839 -.->|"ε"|eNFA66_8_10656503
eNFA66_8_10656503 -->|"e"|eNFA66_9_28799665
eNFA66_9_28799665 -.->|"ε"|eNFA66_10_57870399
eNFA66_10_57870399 -->|"r"|eNFA66_11_51071544
eNFA66_11_51071544 -.->|"ε"|eNFA66_13_56990719
eNFA66_13_56990719 -.->|"ε"|eNFA66_14_43154428
eNFA66_14_43154428 -.->|"ε"|eNFA66_15_52845536
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
eNFA66_12_5847780[["εNFA66-12 regex start"]]
eNFA66_0_52630025[["εNFA66-0 char{1, 1}"]]
eNFA66_1_3908185[["εNFA66-1 char[1]"]]
eNFA66_2_35173667[["εNFA66-2 char{1, 1}"]]
eNFA66_3_48127554[["εNFA66-3 char[1]"]]
eNFA66_4_30494806[["εNFA66-4 char{1, 1}"]]
eNFA66_5_6017800[["εNFA66-5 char[1]"]]
eNFA66_6_54160201[["εNFA66-6 char{1, 1}"]]
eNFA66_7_17679762[["εNFA66-7 char[1]"]]
eNFA66_8_24900132[["εNFA66-8 char{1, 1}"]]
eNFA66_9_22774600[["εNFA66-9 char[1]"]]
eNFA66_10_3644816[["εNFA66-10 char{1, 1}"]]
eNFA66_11_32803348[\"εNFA66-11 char[1]"/]
eNFA66_13_26794676[\"εNFA66-13 regex end"/]
eNFA66_14_39825499[\"εNFA66-14 post-regex start"/]
eNFA66_15_22885177[\"εNFA66-15 post-regex end"/]
eNFA66_12_5847780 -.->|"ε"|eNFA66_0_52630025
eNFA66_12_5847780 -->|"b"|eNFA66_1_3908185
eNFA66_0_52630025 -->|"b"|eNFA66_1_3908185
eNFA66_1_3908185 -.->|"ε"|eNFA66_2_35173667
eNFA66_1_3908185 -->|"u"|eNFA66_3_48127554
eNFA66_2_35173667 -->|"u"|eNFA66_3_48127554
eNFA66_3_48127554 -.->|"ε"|eNFA66_4_30494806
eNFA66_3_48127554 -->|"f"|eNFA66_5_6017800
eNFA66_4_30494806 -->|"f"|eNFA66_5_6017800
eNFA66_5_6017800 -.->|"ε"|eNFA66_6_54160201
eNFA66_5_6017800 -->|"f"|eNFA66_7_17679762
eNFA66_6_54160201 -->|"f"|eNFA66_7_17679762
eNFA66_7_17679762 -.->|"ε"|eNFA66_8_24900132
eNFA66_7_17679762 -->|"e"|eNFA66_9_22774600
eNFA66_8_24900132 -->|"e"|eNFA66_9_22774600
eNFA66_9_22774600 -.->|"ε"|eNFA66_10_3644816
eNFA66_9_22774600 -->|"r"|eNFA66_11_32803348
eNFA66_10_3644816 -->|"r"|eNFA66_11_32803348
eNFA66_11_32803348 -.->|"ε"|eNFA66_13_26794676
eNFA66_11_32803348 -.->|"ε"|eNFA66_14_39825499
eNFA66_11_32803348 -.->|"ε"|eNFA66_15_22885177
eNFA66_13_26794676 -.->|"ε"|eNFA66_14_39825499
eNFA66_13_26794676 -.->|"ε"|eNFA66_15_22885177
eNFA66_14_39825499 -.->|"ε"|eNFA66_15_22885177
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
NFA66_12_4640007("NFA66-12 regex start")
NFA66_1_41760071("NFA66-1 char[1]")
NFA66_3_40296320("NFA66-3 char[1]")
NFA66_5_27122565("NFA66-5 char[1]")
NFA66_7_42776493("NFA66-7 char[1]")
NFA66_9_49444123("NFA66-9 char[1]")
NFA66_11_42343927[\"NFA66-11 char[1]"/]
NFA66_12_4640007 -->|"b"|NFA66_1_41760071
NFA66_1_41760071 -->|"u"|NFA66_3_40296320
NFA66_3_40296320 -->|"f"|NFA66_5_27122565
NFA66_5_27122565 -->|"f"|NFA66_7_42776493
NFA66_7_42776493 -->|"e"|NFA66_9_49444123
NFA66_9_49444123 -->|"r"|NFA66_11_42343927
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
subgraph DFA0_129877369["DFA0 regex start"]
NFA66_12_4640007_0("NFA66-12 regex start")
end
subgraph DFA1_1309907263["DFA1 {1}"]
NFA66_1_41760071_1("NFA66-1 char[1]")
end
subgraph DFA2_1873551125["DFA2 {1}"]
NFA66_3_40296320_2("NFA66-3 char[1]")
end
subgraph DFA3_764062618["DFA3 {1}"]
NFA66_5_27122565_3("NFA66-5 char[1]")
end
subgraph DFA4_250939435["DFA4 {1}"]
NFA66_7_42776493_4("NFA66-7 char[1]")
end
subgraph DFA5_-688141916["DFA5 {1}"]
NFA66_9_49444123_5("NFA66-9 char[1]")
end
subgraph DFA6_273008140["DFA6 {1}"]
NFA66_11_42343927_6[\"NFA66-11 char[1]"/]
end
DFA0_129877369 -->|"b"|DFA1_1309907263
DFA1_1309907263 -->|"u"|DFA2_1873551125
DFA2_1873551125 -->|"f"|DFA3_764062618
DFA3_764062618 -->|"f"|DFA4_250939435
DFA4_250939435 -->|"e"|DFA5_-688141916
DFA5_-688141916 -->|"r"|DFA6_273008140
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
DFA0_129877369{{"DFA0 regex start"}}
DFA1_1309907263{{"DFA1 {1}"}}
DFA2_1873551125{{"DFA2 {1}"}}
DFA3_764062618{{"DFA3 {1}"}}
DFA4_250939435{{"DFA4 {1}"}}
DFA5_-688141916{{"DFA5 {1}"}}
DFA6_273008140[\"DFA6 {1}"/]
DFA0_129877369 -->|"b"|DFA1_1309907263
DFA1_1309907263 -->|"u"|DFA2_1873551125
DFA2_1873551125 -->|"f"|DFA3_764062618
DFA3_764062618 -->|"f"|DFA4_250939435
DFA4_250939435 -->|"e"|DFA5_-688141916
DFA5_-688141916 -->|"r"|DFA6_273008140
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
subgraph MiniDFA0_-778305729["MiniDFA0 {1}"]
DFA0_129877369_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_448829974["MiniDFA1 {1}"]
DFA1_1309907263_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-85524295["MiniDFA2 {1}"]
DFA2_1873551125_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_863052188["MiniDFA3 {1}"]
DFA3_764062618_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_347802955["MiniDFA4 {1}"]
DFA4_250939435_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-860997933["MiniDFA5 {1}"]
DFA5_-688141916_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1390515504["MiniDFA6 {1}"]
DFA6_273008140_6[\"DFA6 {1}"/]
end
MiniDFA0_-778305729 -->|"b"|MiniDFA1_448829974
MiniDFA1_448829974 -->|"u"|MiniDFA2_-85524295
MiniDFA2_-85524295 -->|"f"|MiniDFA3_863052188
MiniDFA3_863052188 -->|"f"|MiniDFA4_347802955
MiniDFA4_347802955 -->|"e"|MiniDFA5_-860997933
MiniDFA5_-860997933 -->|"r"|MiniDFA6_1390515504
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
MiniDFA0_-778305729(["MiniDFA0 {1}"])
MiniDFA1_448829974(["MiniDFA1 {1}"])
MiniDFA2_-85524295(["MiniDFA2 {1}"])
MiniDFA3_863052188(["MiniDFA3 {1}"])
MiniDFA4_347802955(["MiniDFA4 {1}"])
MiniDFA5_-860997933(["MiniDFA5 {1}"])
MiniDFA6_1390515504[\"MiniDFA6 {1}"/]
MiniDFA0_-778305729 -->|"b"|MiniDFA1_448829974
MiniDFA1_448829974 -->|"u"|MiniDFA2_-85524295
MiniDFA2_-85524295 -->|"f"|MiniDFA3_863052188
MiniDFA3_863052188 -->|"f"|MiniDFA4_347802955
MiniDFA4_347802955 -->|"e"|MiniDFA5_-860997933
MiniDFA5_-860997933 -->|"r"|MiniDFA6_1390515504
```
-------------------------------
