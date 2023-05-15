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
eNFA8_16_18409771[["εNFA8-16 regex start"]]
eNFA8_0_31470215[["εNFA8-0 char{1, 1}"]]
eNFA8_1_14796483[["εNFA8-1 char[1]"]]
eNFA8_2_66059488[["εNFA8-2 char{1, 1}"]]
eNFA8_3_18634089[["εNFA8-3 char[1]"]]
eNFA8_6_12577900[["εNFA8-6 regex start"]]
eNFA8_4_12176960[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_46092238[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_42483779[["εNFA8-7 regex end"]]
eNFA8_5_32966247[["εNFA8-5 scope[1]"]]
eNFA8_9_44041463[["εNFA8-9 scope[1]"]]
eNFA8_12_33489078[["εNFA8-12 char{1, 1}"]]
eNFA8_10_52380055[["εNFA8-10 scope{1, 1}"]]
eNFA8_13_1658455[["εNFA8-13 char[1]"]]
eNFA8_11_66793230[["εNFA8-11 scope[1]"]]
eNFA8_14_14926099[["εNFA8-14 char{1, 1}"]]
eNFA8_15_1054474[["εNFA8-15 char[1]"]]
eNFA8_17_9490272[["εNFA8-17 regex end"]]
eNFA8_18_18303590[["εNFA8-18 post-regex start"]]
eNFA8_19_30514590[\"εNFA8-19 post-regex end"/]
eNFA8_16_18409771 -.->|"ε"|eNFA8_0_31470215
eNFA8_0_31470215 -->|"/"|eNFA8_1_14796483
eNFA8_1_14796483 -.->|"ε"|eNFA8_2_66059488
eNFA8_2_66059488 -->|"*"|eNFA8_3_18634089
eNFA8_3_18634089 -.->|"ε"|eNFA8_6_12577900
eNFA8_6_12577900 -.->|"ε"|eNFA8_4_12176960
eNFA8_6_12577900 -.->|"ε"|eNFA8_8_46092238
eNFA8_6_12577900 -.->|"ε"|eNFA8_7_42483779
eNFA8_4_12176960 -->|"[^*]"|eNFA8_5_32966247
eNFA8_8_46092238 -->|"[*]"|eNFA8_9_44041463
eNFA8_7_42483779 -.->|"ε"|eNFA8_6_12577900
eNFA8_7_42483779 -.->|"ε"|eNFA8_12_33489078
eNFA8_5_32966247 -.->|"ε"|eNFA8_7_42483779
eNFA8_9_44041463 -.->|"ε"|eNFA8_10_52380055
eNFA8_12_33489078 -->|"*"|eNFA8_13_1658455
eNFA8_10_52380055 -->|"[^/]"|eNFA8_11_66793230
eNFA8_13_1658455 -.->|"ε"|eNFA8_14_14926099
eNFA8_11_66793230 -.->|"ε"|eNFA8_7_42483779
eNFA8_14_14926099 -->|"/"|eNFA8_15_1054474
eNFA8_15_1054474 -.->|"ε"|eNFA8_17_9490272
eNFA8_17_9490272 -.->|"ε"|eNFA8_18_18303590
eNFA8_18_18303590 -.->|"ε"|eNFA8_19_30514590
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
eNFA8_16_6195855[["εNFA8-16 regex start"]]
eNFA8_0_55762700[["εNFA8-0 char{1, 1}"]]
eNFA8_1_32102252[["εNFA8-1 char[1]"]]
eNFA8_2_20484818[["εNFA8-2 char{1, 1}"]]
eNFA8_3_60828848[["εNFA8-3 char[1]"]]
eNFA8_6_57664488[["εNFA8-6 regex start"]]
eNFA8_4_40311937[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_49218346[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_27263117[["εNFA8-7 regex end"]]
eNFA8_5_28189627[["εNFA8-5 scope[1]"]]
eNFA8_9_50145638[["εNFA8-9 scope[1]"]]
eNFA8_12_10588721[["εNFA8-12 char{1, 1}"]]
eNFA8_13_35264868[["εNFA8-13 char[1]"]]
eNFA8_10_48657561[["εNFA8-10 scope{1, 1}"]]
eNFA8_11_117163[["εNFA8-11 scope[1]"]]
eNFA8_14_48948360[["εNFA8-14 char{1, 1}"]]
eNFA8_15_37882063[\"εNFA8-15 char[1]"/]
eNFA8_17_5394248[\"εNFA8-17 regex end"/]
eNFA8_18_48548238[\"εNFA8-18 post-regex start"/]
eNFA8_19_34280961[\"εNFA8-19 post-regex end"/]
eNFA8_16_6195855 -.->|"ε"|eNFA8_0_55762700
eNFA8_16_6195855 -->|"/"|eNFA8_1_32102252
eNFA8_0_55762700 -->|"/"|eNFA8_1_32102252
eNFA8_1_32102252 -.->|"ε"|eNFA8_2_20484818
eNFA8_1_32102252 -->|"*"|eNFA8_3_60828848
eNFA8_2_20484818 -->|"*"|eNFA8_3_60828848
eNFA8_3_60828848 -.->|"ε"|eNFA8_6_57664488
eNFA8_3_60828848 -.->|"ε"|eNFA8_4_40311937
eNFA8_3_60828848 -.->|"ε"|eNFA8_8_49218346
eNFA8_3_60828848 -.->|"ε"|eNFA8_7_27263117
eNFA8_3_60828848 -->|"[^*]"|eNFA8_5_28189627
eNFA8_3_60828848 -->|"[*]"|eNFA8_9_50145638
eNFA8_3_60828848 -.->|"ε"|eNFA8_12_10588721
eNFA8_3_60828848 -->|"*"|eNFA8_13_35264868
eNFA8_6_57664488 -.->|"ε"|eNFA8_4_40311937
eNFA8_6_57664488 -.->|"ε"|eNFA8_8_49218346
eNFA8_6_57664488 -.->|"ε"|eNFA8_7_27263117
eNFA8_6_57664488 -->|"[^*]"|eNFA8_5_28189627
eNFA8_6_57664488 -->|"[*]"|eNFA8_9_50145638
eNFA8_6_57664488 -.->|"ε"|eNFA8_6_57664488
eNFA8_6_57664488 -.->|"ε"|eNFA8_12_10588721
eNFA8_6_57664488 -->|"*"|eNFA8_13_35264868
eNFA8_4_40311937 -->|"[^*]"|eNFA8_5_28189627
eNFA8_8_49218346 -->|"[*]"|eNFA8_9_50145638
eNFA8_7_27263117 -.->|"ε"|eNFA8_6_57664488
eNFA8_7_27263117 -.->|"ε"|eNFA8_12_10588721
eNFA8_7_27263117 -.->|"ε"|eNFA8_4_40311937
eNFA8_7_27263117 -.->|"ε"|eNFA8_8_49218346
eNFA8_7_27263117 -.->|"ε"|eNFA8_7_27263117
eNFA8_7_27263117 -->|"[^*]"|eNFA8_5_28189627
eNFA8_7_27263117 -->|"[*]"|eNFA8_9_50145638
eNFA8_7_27263117 -->|"*"|eNFA8_13_35264868
eNFA8_5_28189627 -.->|"ε"|eNFA8_7_27263117
eNFA8_5_28189627 -.->|"ε"|eNFA8_6_57664488
eNFA8_5_28189627 -.->|"ε"|eNFA8_12_10588721
eNFA8_5_28189627 -.->|"ε"|eNFA8_4_40311937
eNFA8_5_28189627 -.->|"ε"|eNFA8_8_49218346
eNFA8_5_28189627 -->|"[^*]"|eNFA8_5_28189627
eNFA8_5_28189627 -->|"[*]"|eNFA8_9_50145638
eNFA8_5_28189627 -->|"*"|eNFA8_13_35264868
eNFA8_9_50145638 -.->|"ε"|eNFA8_10_48657561
eNFA8_9_50145638 -->|"[^/]"|eNFA8_11_117163
eNFA8_12_10588721 -->|"*"|eNFA8_13_35264868
eNFA8_13_35264868 -.->|"ε"|eNFA8_14_48948360
eNFA8_13_35264868 -->|"/"|eNFA8_15_37882063
eNFA8_10_48657561 -->|"[^/]"|eNFA8_11_117163
eNFA8_11_117163 -.->|"ε"|eNFA8_7_27263117
eNFA8_11_117163 -.->|"ε"|eNFA8_6_57664488
eNFA8_11_117163 -.->|"ε"|eNFA8_12_10588721
eNFA8_11_117163 -.->|"ε"|eNFA8_4_40311937
eNFA8_11_117163 -.->|"ε"|eNFA8_8_49218346
eNFA8_11_117163 -->|"[^*]"|eNFA8_5_28189627
eNFA8_11_117163 -->|"[*]"|eNFA8_9_50145638
eNFA8_11_117163 -->|"*"|eNFA8_13_35264868
eNFA8_14_48948360 -->|"/"|eNFA8_15_37882063
eNFA8_15_37882063 -.->|"ε"|eNFA8_17_5394248
eNFA8_15_37882063 -.->|"ε"|eNFA8_18_48548238
eNFA8_15_37882063 -.->|"ε"|eNFA8_19_34280961
eNFA8_17_5394248 -.->|"ε"|eNFA8_18_48548238
eNFA8_17_5394248 -.->|"ε"|eNFA8_19_34280961
eNFA8_18_48548238 -.->|"ε"|eNFA8_19_34280961
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
NFA8_16_63617293("NFA8-16 regex start")
NFA8_1_35684727("NFA8-1 char[1]")
NFA8_3_40093194("NFA8-3 char[1]")
NFA8_5_26323242("NFA8-5 scope[1]")
NFA8_9_25294426("NFA8-9 scope[1]")
NFA8_13_35582587("NFA8-13 char[1]")
NFA8_11_51807830("NFA8-11 scope[1]")
NFA8_15_52727095[\"NFA8-15 char[1]"/]
NFA8_16_63617293 -->|"/"|NFA8_1_35684727
NFA8_1_35684727 -->|"*"|NFA8_3_40093194
NFA8_3_40093194 -->|"[^*]"|NFA8_5_26323242
NFA8_3_40093194 -->|"[*]"|NFA8_9_25294426
NFA8_3_40093194 -->|"*"|NFA8_13_35582587
NFA8_5_26323242 -->|"[^*]"|NFA8_5_26323242
NFA8_5_26323242 -->|"[*]"|NFA8_9_25294426
NFA8_5_26323242 -->|"*"|NFA8_13_35582587
NFA8_9_25294426 -->|"[^/]"|NFA8_11_51807830
NFA8_13_35582587 -->|"/"|NFA8_15_52727095
NFA8_11_51807830 -->|"[^*]"|NFA8_5_26323242
NFA8_11_51807830 -->|"[*]"|NFA8_9_25294426
NFA8_11_51807830 -->|"*"|NFA8_13_35582587
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
subgraph DFA0_-1010439070["DFA0 regex start"]
NFA8_16_63617293_0("NFA8-16 regex start")
end
subgraph DFA1_-184920813["DFA1 {1}"]
NFA8_1_35684727_1("NFA8-1 char[1]")
end
subgraph DFA2_2004040045["DFA2 {1}"]
NFA8_3_40093194_2("NFA8-3 char[1]")
end
subgraph DFA3_-608567637["DFA3 {1}"]
NFA8_5_26323242_3("NFA8-5 scope[1]")
end
subgraph DFA4_1394166720["DFA4 {2}"]
NFA8_9_25294426_4("NFA8-9 scope[1]")
NFA8_13_35582587_5("NFA8-13 char[1]")
end
subgraph DFA5_-665381699["DFA5 {1}"]
NFA8_11_51807830_6("NFA8-11 scope[1]")
end
subgraph DFA6_796890906["DFA6 {1}"]
NFA8_15_52727095_7[\"NFA8-15 char[1]"/]
end
DFA0_-1010439070 -->|"/"|DFA1_-184920813
DFA1_-184920813 -->|"*"|DFA2_2004040045
DFA2_2004040045 -->|"[^*]"|DFA3_-608567637
DFA2_2004040045 -->|"*"|DFA4_1394166720
DFA3_-608567637 -->|"[^*]"|DFA3_-608567637
DFA3_-608567637 -->|"*"|DFA4_1394166720
DFA4_1394166720 -->|"[^/]"|DFA5_-665381699
DFA4_1394166720 -->|"/"|DFA6_796890906
DFA5_-665381699 -->|"[^*]"|DFA3_-608567637
DFA5_-665381699 -->|"*"|DFA4_1394166720
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
DFA0_-1010439070{{"DFA0 regex start"}}
DFA1_-184920813{{"DFA1 {1}"}}
DFA2_2004040045{{"DFA2 {1}"}}
DFA3_-608567637{{"DFA3 {1}"}}
DFA4_1394166720{{"DFA4 {2}"}}
DFA5_-665381699{{"DFA5 {1}"}}
DFA6_796890906[\"DFA6 {1}"/]
DFA0_-1010439070 -->|"/"|DFA1_-184920813
DFA1_-184920813 -->|"*"|DFA2_2004040045
DFA2_2004040045 -->|"[^*]"|DFA3_-608567637
DFA2_2004040045 -->|"*"|DFA4_1394166720
DFA3_-608567637 -->|"[^*]"|DFA3_-608567637
DFA3_-608567637 -->|"*"|DFA4_1394166720
DFA4_1394166720 -->|"[^/]"|DFA5_-665381699
DFA4_1394166720 -->|"/"|DFA6_796890906
DFA5_-665381699 -->|"[^*]"|DFA3_-608567637
DFA5_-665381699 -->|"*"|DFA4_1394166720
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
subgraph MiniDFA0_-32094755["MiniDFA0 {1}"]
DFA0_-1010439070_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_410914869["MiniDFA1 {1}"]
DFA1_-184920813_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-113659363["MiniDFA2 {3}"]
DFA2_2004040045_2{{"DFA2 {1}"}}
DFA3_-608567637_3{{"DFA3 {1}"}}
DFA5_-665381699_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_654518683["MiniDFA3 {1}"]
DFA4_1394166720_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-773250637["MiniDFA4 {1}"]
DFA6_796890906_6[\"DFA6 {1}"/]
end
MiniDFA0_-32094755 -->|"/"|MiniDFA1_410914869
MiniDFA1_410914869 -->|"*"|MiniDFA2_-113659363
MiniDFA2_-113659363 -->|"[^*]"|MiniDFA2_-113659363
MiniDFA2_-113659363 -->|"*"|MiniDFA3_654518683
MiniDFA3_654518683 -->|"[^/]"|MiniDFA2_-113659363
MiniDFA3_654518683 -->|"/"|MiniDFA4_-773250637
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
MiniDFA0_-32094755(["MiniDFA0 {1}"])
MiniDFA1_410914869(["MiniDFA1 {1}"])
MiniDFA2_-113659363(["MiniDFA2 {3}"])
MiniDFA3_654518683(["MiniDFA3 {1}"])
MiniDFA4_-773250637[\"MiniDFA4 {1}"/]
MiniDFA0_-32094755 -->|"/"|MiniDFA1_410914869
MiniDFA1_410914869 -->|"*"|MiniDFA2_-113659363
MiniDFA2_-113659363 -->|"[^*]"|MiniDFA2_-113659363
MiniDFA2_-113659363 -->|"*"|MiniDFA3_654518683
MiniDFA3_654518683 -->|"[^/]"|MiniDFA2_-113659363
MiniDFA3_654518683 -->|"/"|MiniDFA4_-773250637
```
-------------------------------
