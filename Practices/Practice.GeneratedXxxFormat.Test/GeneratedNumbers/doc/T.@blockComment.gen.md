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
eNFA3_16_65282360[["εNFA3-16 regex start"]]
eNFA3_0_50670335[["εNFA3-0 char{1, 1}"]]
eNFA3_1_53379839[["εNFA3-1 char[1]"]]
eNFA3_2_10656503[["εNFA3-2 char{1, 1}"]]
eNFA3_3_40466701[["εNFA3-3 char[1]"]]
eNFA3_6_25475209[["εNFA3-6 regex start"]]
eNFA3_4_50226059[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_27950294[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_49381354[["εNFA3-7 regex end"]]
eNFA3_5_56577386[["εNFA3-5 scope[1]"]]
eNFA3_9_43154428[["εNFA3-9 scope[1]"]]
eNFA3_12_28655997[["εNFA3-12 char{1, 1}"]]
eNFA3_10_3908185[["εNFA3-10 scope{1, 1}"]]
eNFA3_13_35173667[["εNFA3-13 char[1]"]]
eNFA3_11_25105132[["εNFA3-11 scope[1]"]]
eNFA3_14_48127554[["εNFA3-14 char{1, 1}"]]
eNFA3_15_6017800[["εNFA3-15 char[1]"]]
eNFA3_17_54160201[["εNFA3-17 regex end"]]
eNFA3_18_17679762[["εNFA3-18 post-regex start"]]
eNFA3_19_24900132[\"εNFA3-19 post-regex end"/]
eNFA3_16_65282360 -.->|"ε"|eNFA3_0_50670335
eNFA3_0_50670335 -->|"/"|eNFA3_1_53379839
eNFA3_1_53379839 -.->|"ε"|eNFA3_2_10656503
eNFA3_2_10656503 -->|"*"|eNFA3_3_40466701
eNFA3_3_40466701 -.->|"ε"|eNFA3_6_25475209
eNFA3_6_25475209 -.->|"ε"|eNFA3_4_50226059
eNFA3_6_25475209 -.->|"ε"|eNFA3_8_27950294
eNFA3_6_25475209 -.->|"ε"|eNFA3_7_49381354
eNFA3_4_50226059 -->|"[^*]"|eNFA3_5_56577386
eNFA3_8_27950294 -->|"[*]"|eNFA3_9_43154428
eNFA3_7_49381354 -.->|"ε"|eNFA3_6_25475209
eNFA3_7_49381354 -.->|"ε"|eNFA3_12_28655997
eNFA3_5_56577386 -.->|"ε"|eNFA3_7_49381354
eNFA3_9_43154428 -.->|"ε"|eNFA3_10_3908185
eNFA3_12_28655997 -->|"*"|eNFA3_13_35173667
eNFA3_10_3908185 -->|"[^/]"|eNFA3_11_25105132
eNFA3_13_35173667 -.->|"ε"|eNFA3_14_48127554
eNFA3_11_25105132 -.->|"ε"|eNFA3_7_49381354
eNFA3_14_48127554 -->|"/"|eNFA3_15_6017800
eNFA3_15_6017800 -.->|"ε"|eNFA3_17_54160201
eNFA3_17_54160201 -.->|"ε"|eNFA3_18_17679762
eNFA3_18_17679762 -.->|"ε"|eNFA3_19_24900132
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
eNFA3_16_22774600[["εNFA3-16 regex start"]]
eNFA3_0_3644816[["εNFA3-0 char{1, 1}"]]
eNFA3_1_32803348[["εNFA3-1 char[1]"]]
eNFA3_2_26794676[["εNFA3-2 char{1, 1}"]]
eNFA3_3_52845536[["εNFA3-3 char[1]"]]
eNFA3_6_28799665[["εNFA3-6 regex start"]]
eNFA3_4_51071544[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_57870399[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_56990719[["εNFA3-7 regex end"]]
eNFA3_5_52630025[["εNFA3-5 scope[1]"]]
eNFA3_9_39825499[["εNFA3-9 scope[1]"]]
eNFA3_12_5847780[["εNFA3-12 char{1, 1}"]]
eNFA3_13_4640007[["εNFA3-13 char[1]"]]
eNFA3_10_22885177[["εNFA3-10 scope{1, 1}"]]
eNFA3_11_30494806[["εNFA3-11 scope[1]"]]
eNFA3_14_41760071[["εNFA3-14 char{1, 1}"]]
eNFA3_15_40296320[\"εNFA3-15 char[1]"/]
eNFA3_17_27122565[\"εNFA3-17 regex end"/]
eNFA3_18_42776493[\"εNFA3-18 post-regex start"/]
eNFA3_19_49444123[\"εNFA3-19 post-regex end"/]
eNFA3_16_22774600 -.->|"ε"|eNFA3_0_3644816
eNFA3_16_22774600 -->|"/"|eNFA3_1_32803348
eNFA3_0_3644816 -->|"/"|eNFA3_1_32803348
eNFA3_1_32803348 -.->|"ε"|eNFA3_2_26794676
eNFA3_1_32803348 -->|"*"|eNFA3_3_52845536
eNFA3_2_26794676 -->|"*"|eNFA3_3_52845536
eNFA3_3_52845536 -.->|"ε"|eNFA3_6_28799665
eNFA3_3_52845536 -.->|"ε"|eNFA3_4_51071544
eNFA3_3_52845536 -.->|"ε"|eNFA3_8_57870399
eNFA3_3_52845536 -.->|"ε"|eNFA3_7_56990719
eNFA3_3_52845536 -->|"[^*]"|eNFA3_5_52630025
eNFA3_3_52845536 -->|"[*]"|eNFA3_9_39825499
eNFA3_3_52845536 -.->|"ε"|eNFA3_12_5847780
eNFA3_3_52845536 -->|"*"|eNFA3_13_4640007
eNFA3_6_28799665 -.->|"ε"|eNFA3_4_51071544
eNFA3_6_28799665 -.->|"ε"|eNFA3_8_57870399
eNFA3_6_28799665 -.->|"ε"|eNFA3_7_56990719
eNFA3_6_28799665 -->|"[^*]"|eNFA3_5_52630025
eNFA3_6_28799665 -->|"[*]"|eNFA3_9_39825499
eNFA3_6_28799665 -.->|"ε"|eNFA3_6_28799665
eNFA3_6_28799665 -.->|"ε"|eNFA3_12_5847780
eNFA3_6_28799665 -->|"*"|eNFA3_13_4640007
eNFA3_4_51071544 -->|"[^*]"|eNFA3_5_52630025
eNFA3_8_57870399 -->|"[*]"|eNFA3_9_39825499
eNFA3_7_56990719 -.->|"ε"|eNFA3_6_28799665
eNFA3_7_56990719 -.->|"ε"|eNFA3_12_5847780
eNFA3_7_56990719 -.->|"ε"|eNFA3_4_51071544
eNFA3_7_56990719 -.->|"ε"|eNFA3_8_57870399
eNFA3_7_56990719 -.->|"ε"|eNFA3_7_56990719
eNFA3_7_56990719 -->|"[^*]"|eNFA3_5_52630025
eNFA3_7_56990719 -->|"[*]"|eNFA3_9_39825499
eNFA3_7_56990719 -->|"*"|eNFA3_13_4640007
eNFA3_5_52630025 -.->|"ε"|eNFA3_7_56990719
eNFA3_5_52630025 -.->|"ε"|eNFA3_6_28799665
eNFA3_5_52630025 -.->|"ε"|eNFA3_12_5847780
eNFA3_5_52630025 -.->|"ε"|eNFA3_4_51071544
eNFA3_5_52630025 -.->|"ε"|eNFA3_8_57870399
eNFA3_5_52630025 -->|"[^*]"|eNFA3_5_52630025
eNFA3_5_52630025 -->|"[*]"|eNFA3_9_39825499
eNFA3_5_52630025 -->|"*"|eNFA3_13_4640007
eNFA3_9_39825499 -.->|"ε"|eNFA3_10_22885177
eNFA3_9_39825499 -->|"[^/]"|eNFA3_11_30494806
eNFA3_12_5847780 -->|"*"|eNFA3_13_4640007
eNFA3_13_4640007 -.->|"ε"|eNFA3_14_41760071
eNFA3_13_4640007 -->|"/"|eNFA3_15_40296320
eNFA3_10_22885177 -->|"[^/]"|eNFA3_11_30494806
eNFA3_11_30494806 -.->|"ε"|eNFA3_7_56990719
eNFA3_11_30494806 -.->|"ε"|eNFA3_6_28799665
eNFA3_11_30494806 -.->|"ε"|eNFA3_12_5847780
eNFA3_11_30494806 -.->|"ε"|eNFA3_4_51071544
eNFA3_11_30494806 -.->|"ε"|eNFA3_8_57870399
eNFA3_11_30494806 -->|"[^*]"|eNFA3_5_52630025
eNFA3_11_30494806 -->|"[*]"|eNFA3_9_39825499
eNFA3_11_30494806 -->|"*"|eNFA3_13_4640007
eNFA3_14_41760071 -->|"/"|eNFA3_15_40296320
eNFA3_15_40296320 -.->|"ε"|eNFA3_17_27122565
eNFA3_15_40296320 -.->|"ε"|eNFA3_18_42776493
eNFA3_15_40296320 -.->|"ε"|eNFA3_19_49444123
eNFA3_17_27122565 -.->|"ε"|eNFA3_18_42776493
eNFA3_17_27122565 -.->|"ε"|eNFA3_19_49444123
eNFA3_18_42776493 -.->|"ε"|eNFA3_19_49444123
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
NFA3_16_24512769("NFA3-16 regex start")
NFA3_1_19288335("NFA3-1 char[1]")
NFA3_3_42343927("NFA3-3 char[1]")
NFA3_5_7306053("NFA3-5 scope[1]")
NFA3_9_45551026("NFA3-9 scope[1]")
NFA3_13_65754481("NFA3-13 char[1]")
NFA3_11_54919424("NFA3-11 scope[1]")
NFA3_15_39377290[\"NFA3-15 char[1]"/]
NFA3_16_24512769 -->|"/"|NFA3_1_19288335
NFA3_1_19288335 -->|"*"|NFA3_3_42343927
NFA3_3_42343927 -->|"[^*]"|NFA3_5_7306053
NFA3_3_42343927 -->|"[*]"|NFA3_9_45551026
NFA3_3_42343927 -->|"*"|NFA3_13_65754481
NFA3_5_7306053 -->|"[^*]"|NFA3_5_7306053
NFA3_5_7306053 -->|"[*]"|NFA3_9_45551026
NFA3_5_7306053 -->|"*"|NFA3_13_65754481
NFA3_9_45551026 -->|"[^/]"|NFA3_11_54919424
NFA3_13_65754481 -->|"/"|NFA3_15_39377290
NFA3_11_54919424 -->|"[^*]"|NFA3_5_7306053
NFA3_11_54919424 -->|"[*]"|NFA3_9_45551026
NFA3_11_54919424 -->|"*"|NFA3_13_65754481
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
subgraph DFA0_-297412680["DFA0 regex start"]
NFA3_16_24512769_0("NFA3-16 regex start")
end
subgraph DFA1_1282677404["DFA1 {1}"]
NFA3_1_19288335_1("NFA3-1 char[1]")
end
subgraph DFA2_273008140["DFA2 {1}"]
NFA3_3_42343927_2("NFA3-3 char[1]")
end
subgraph DFA3_-1385153204["DFA3 {1}"]
NFA3_5_7306053_3("NFA3-5 scope[1]")
end
subgraph DFA4_-1328769525["DFA4 {2}"]
NFA3_9_45551026_4("NFA3-9 scope[1]")
NFA3_13_65754481_5("NFA3-13 char[1]")
end
subgraph DFA5_-1716404899["DFA5 {1}"]
NFA3_11_54919424_6("NFA3-11 scope[1]")
end
subgraph DFA6_-582734649["DFA6 {1}"]
NFA3_15_39377290_7[\"NFA3-15 char[1]"/]
end
DFA0_-297412680 -->|"/"|DFA1_1282677404
DFA1_1282677404 -->|"*"|DFA2_273008140
DFA2_273008140 -->|"[^*]"|DFA3_-1385153204
DFA2_273008140 -->|"*"|DFA4_-1328769525
DFA3_-1385153204 -->|"[^*]"|DFA3_-1385153204
DFA3_-1385153204 -->|"*"|DFA4_-1328769525
DFA4_-1328769525 -->|"[^/]"|DFA5_-1716404899
DFA4_-1328769525 -->|"/"|DFA6_-582734649
DFA5_-1716404899 -->|"[^*]"|DFA3_-1385153204
DFA5_-1716404899 -->|"*"|DFA4_-1328769525
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
DFA0_-297412680{{"DFA0 regex start"}}
DFA1_1282677404{{"DFA1 {1}"}}
DFA2_273008140{{"DFA2 {1}"}}
DFA3_-1385153204{{"DFA3 {1}"}}
DFA4_-1328769525{{"DFA4 {2}"}}
DFA5_-1716404899{{"DFA5 {1}"}}
DFA6_-582734649[\"DFA6 {1}"/]
DFA0_-297412680 -->|"/"|DFA1_1282677404
DFA1_1282677404 -->|"*"|DFA2_273008140
DFA2_273008140 -->|"[^*]"|DFA3_-1385153204
DFA2_273008140 -->|"*"|DFA4_-1328769525
DFA3_-1385153204 -->|"[^*]"|DFA3_-1385153204
DFA3_-1385153204 -->|"*"|DFA4_-1328769525
DFA4_-1328769525 -->|"[^/]"|DFA5_-1716404899
DFA4_-1328769525 -->|"/"|DFA6_-582734649
DFA5_-1716404899 -->|"[^*]"|DFA3_-1385153204
DFA5_-1716404899 -->|"*"|DFA4_-1328769525
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
subgraph MiniDFA0_-1752807369["MiniDFA0 {1}"]
DFA0_-297412680_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-25942275["MiniDFA1 {1}"]
DFA1_1282677404_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1537850035["MiniDFA2 {3}"]
DFA2_273008140_2{{"DFA2 {1}"}}
DFA3_-1385153204_3{{"DFA3 {1}"}}
DFA5_-1716404899_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_1785783862["MiniDFA3 {1}"]
DFA4_-1328769525_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_663705216["MiniDFA4 {1}"]
DFA6_-582734649_6[\"DFA6 {1}"/]
end
MiniDFA0_-1752807369 -->|"/"|MiniDFA1_-25942275
MiniDFA1_-25942275 -->|"*"|MiniDFA2_1537850035
MiniDFA2_1537850035 -->|"[^*]"|MiniDFA2_1537850035
MiniDFA2_1537850035 -->|"*"|MiniDFA3_1785783862
MiniDFA3_1785783862 -->|"[^/]"|MiniDFA2_1537850035
MiniDFA3_1785783862 -->|"/"|MiniDFA4_663705216
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
MiniDFA0_-1752807369(["MiniDFA0 {1}"])
MiniDFA1_-25942275(["MiniDFA1 {1}"])
MiniDFA2_1537850035(["MiniDFA2 {3}"])
MiniDFA3_1785783862(["MiniDFA3 {1}"])
MiniDFA4_663705216[\"MiniDFA4 {1}"/]
MiniDFA0_-1752807369 -->|"/"|MiniDFA1_-25942275
MiniDFA1_-25942275 -->|"*"|MiniDFA2_1537850035
MiniDFA2_1537850035 -->|"[^*]"|MiniDFA2_1537850035
MiniDFA2_1537850035 -->|"*"|MiniDFA3_1785783862
MiniDFA3_1785783862 -->|"[^/]"|MiniDFA2_1537850035
MiniDFA3_1785783862 -->|"/"|MiniDFA4_663705216
```
-------------------------------
