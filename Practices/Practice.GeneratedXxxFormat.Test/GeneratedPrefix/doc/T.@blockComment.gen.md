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
eNFA4_16_23871500[["εNFA4-16 regex start"]]
eNFA4_0_13516909[["εNFA4-0 char{1, 1}"]]
eNFA4_1_54543318[["εNFA4-1 char[1]"]]
eNFA4_2_21127816[["εNFA4-2 char{1, 1}"]]
eNFA4_3_2362851[["εNFA4-3 char[1]"]]
eNFA4_6_61346876[["εNFA4-6 regex start"]]
eNFA4_4_3041091[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_15250979[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_27369819[["εNFA4-7 regex end"]]
eNFA4_5_57173219[["εNFA4-5 scope[1]"]]
eNFA4_9_22657631[["εNFA4-9 scope[1]"]]
eNFA4_12_21265660[["εNFA4-12 char{1, 1}"]]
eNFA4_10_10588164[["εNFA4-10 scope{1, 1}"]]
eNFA4_13_28184617[["εNFA4-13 char[1]"]]
eNFA4_11_42052973[["εNFA4-11 scope[1]"]]
eNFA4_14_52334961[["εNFA4-14 char{1, 1}"]]
eNFA4_15_11273467[["εNFA4-15 char[1]"]]
eNFA4_17_34352342[["εNFA4-17 regex end"]]
eNFA4_18_40735625[["εNFA4-18 post-regex start"]]
eNFA4_19_31076309[\"εNFA4-19 post-regex end"/]
eNFA4_16_23871500 -.->|"ε"|eNFA4_0_13516909
eNFA4_0_13516909 -->|"/"|eNFA4_1_54543318
eNFA4_1_54543318 -.->|"ε"|eNFA4_2_21127816
eNFA4_2_21127816 -->|"*"|eNFA4_3_2362851
eNFA4_3_2362851 -.->|"ε"|eNFA4_6_61346876
eNFA4_6_61346876 -.->|"ε"|eNFA4_4_3041091
eNFA4_6_61346876 -.->|"ε"|eNFA4_8_15250979
eNFA4_6_61346876 -.->|"ε"|eNFA4_7_27369819
eNFA4_4_3041091 -->|"[^*]"|eNFA4_5_57173219
eNFA4_8_15250979 -->|"[*]"|eNFA4_9_22657631
eNFA4_7_27369819 -.->|"ε"|eNFA4_6_61346876
eNFA4_7_27369819 -.->|"ε"|eNFA4_12_21265660
eNFA4_5_57173219 -.->|"ε"|eNFA4_7_27369819
eNFA4_9_22657631 -.->|"ε"|eNFA4_10_10588164
eNFA4_12_21265660 -->|"*"|eNFA4_13_28184617
eNFA4_10_10588164 -->|"[^/]"|eNFA4_11_42052973
eNFA4_13_28184617 -.->|"ε"|eNFA4_14_52334961
eNFA4_11_42052973 -.->|"ε"|eNFA4_7_27369819
eNFA4_14_52334961 -->|"/"|eNFA4_15_11273467
eNFA4_15_11273467 -.->|"ε"|eNFA4_17_34352342
eNFA4_17_34352342 -.->|"ε"|eNFA4_18_40735625
eNFA4_18_40735625 -.->|"ε"|eNFA4_19_31076309
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
eNFA4_16_11251332[["εNFA4-16 regex start"]]
eNFA4_0_34153125[["εNFA4-0 char{1, 1}"]]
eNFA4_1_38942675[["εNFA4-1 char[1]"]]
eNFA4_2_14939758[["εNFA4-2 char{1, 1}"]]
eNFA4_3_2592093[["εNFA4-3 char[1]"]]
eNFA4_6_55932620[["εNFA4-6 regex start"]]
eNFA4_4_34248408[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_33631540[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_39800216[["εNFA4-7 regex end"]]
eNFA4_5_8633003[["εNFA4-5 scope[1]"]]
eNFA4_9_240095[["εNFA4-9 scope[1]"]]
eNFA4_12_23328843[["εNFA4-12 char{1, 1}"]]
eNFA4_13_19447695[["εNFA4-13 char[1]"]]
eNFA4_10_2160855[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_1252607[["εNFA4-11 scope[1]"]]
eNFA4_14_40811528[["εNFA4-14 char{1, 1}"]]
eNFA4_15_31759435[\"εNFA4-15 char[1]"/]
eNFA4_17_17399466[\"εNFA4-17 regex end"/]
eNFA4_18_22377468[\"εNFA4-18 post-regex start"/]
eNFA4_19_70628[\"εNFA4-19 post-regex end"/]
eNFA4_16_11251332 -.->|"ε"|eNFA4_0_34153125
eNFA4_16_11251332 -->|"/"|eNFA4_1_38942675
eNFA4_0_34153125 -->|"/"|eNFA4_1_38942675
eNFA4_1_38942675 -.->|"ε"|eNFA4_2_14939758
eNFA4_1_38942675 -->|"*"|eNFA4_3_2592093
eNFA4_2_14939758 -->|"*"|eNFA4_3_2592093
eNFA4_3_2592093 -.->|"ε"|eNFA4_6_55932620
eNFA4_3_2592093 -.->|"ε"|eNFA4_4_34248408
eNFA4_3_2592093 -.->|"ε"|eNFA4_8_33631540
eNFA4_3_2592093 -.->|"ε"|eNFA4_7_39800216
eNFA4_3_2592093 -->|"[^*]"|eNFA4_5_8633003
eNFA4_3_2592093 -->|"[*]"|eNFA4_9_240095
eNFA4_3_2592093 -.->|"ε"|eNFA4_12_23328843
eNFA4_3_2592093 -->|"*"|eNFA4_13_19447695
eNFA4_6_55932620 -.->|"ε"|eNFA4_4_34248408
eNFA4_6_55932620 -.->|"ε"|eNFA4_8_33631540
eNFA4_6_55932620 -.->|"ε"|eNFA4_7_39800216
eNFA4_6_55932620 -->|"[^*]"|eNFA4_5_8633003
eNFA4_6_55932620 -->|"[*]"|eNFA4_9_240095
eNFA4_6_55932620 -.->|"ε"|eNFA4_6_55932620
eNFA4_6_55932620 -.->|"ε"|eNFA4_12_23328843
eNFA4_6_55932620 -->|"*"|eNFA4_13_19447695
eNFA4_4_34248408 -->|"[^*]"|eNFA4_5_8633003
eNFA4_8_33631540 -->|"[*]"|eNFA4_9_240095
eNFA4_7_39800216 -.->|"ε"|eNFA4_6_55932620
eNFA4_7_39800216 -.->|"ε"|eNFA4_12_23328843
eNFA4_7_39800216 -.->|"ε"|eNFA4_4_34248408
eNFA4_7_39800216 -.->|"ε"|eNFA4_8_33631540
eNFA4_7_39800216 -.->|"ε"|eNFA4_7_39800216
eNFA4_7_39800216 -->|"[^*]"|eNFA4_5_8633003
eNFA4_7_39800216 -->|"[*]"|eNFA4_9_240095
eNFA4_7_39800216 -->|"*"|eNFA4_13_19447695
eNFA4_5_8633003 -.->|"ε"|eNFA4_7_39800216
eNFA4_5_8633003 -.->|"ε"|eNFA4_6_55932620
eNFA4_5_8633003 -.->|"ε"|eNFA4_12_23328843
eNFA4_5_8633003 -.->|"ε"|eNFA4_4_34248408
eNFA4_5_8633003 -.->|"ε"|eNFA4_8_33631540
eNFA4_5_8633003 -->|"[^*]"|eNFA4_5_8633003
eNFA4_5_8633003 -->|"[*]"|eNFA4_9_240095
eNFA4_5_8633003 -->|"*"|eNFA4_13_19447695
eNFA4_9_240095 -.->|"ε"|eNFA4_10_2160855
eNFA4_9_240095 -->|"[^/]"|eNFA4_11_1252607
eNFA4_12_23328843 -->|"*"|eNFA4_13_19447695
eNFA4_13_19447695 -.->|"ε"|eNFA4_14_40811528
eNFA4_13_19447695 -->|"/"|eNFA4_15_31759435
eNFA4_10_2160855 -->|"[^/]"|eNFA4_11_1252607
eNFA4_11_1252607 -.->|"ε"|eNFA4_7_39800216
eNFA4_11_1252607 -.->|"ε"|eNFA4_6_55932620
eNFA4_11_1252607 -.->|"ε"|eNFA4_12_23328843
eNFA4_11_1252607 -.->|"ε"|eNFA4_4_34248408
eNFA4_11_1252607 -.->|"ε"|eNFA4_8_33631540
eNFA4_11_1252607 -->|"[^*]"|eNFA4_5_8633003
eNFA4_11_1252607 -->|"[*]"|eNFA4_9_240095
eNFA4_11_1252607 -->|"*"|eNFA4_13_19447695
eNFA4_14_40811528 -->|"/"|eNFA4_15_31759435
eNFA4_15_31759435 -.->|"ε"|eNFA4_17_17399466
eNFA4_15_31759435 -.->|"ε"|eNFA4_18_22377468
eNFA4_15_31759435 -.->|"ε"|eNFA4_19_70628
eNFA4_17_17399466 -.->|"ε"|eNFA4_18_22377468
eNFA4_17_17399466 -.->|"ε"|eNFA4_19_70628
eNFA4_18_22377468 -.->|"ε"|eNFA4_19_70628
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
NFA4_16_21151286("NFA4-16 regex start")
NFA4_1_56143854("NFA4-1 char[1]")
NFA4_3_635658("NFA4-3 char[1]")
NFA4_5_51488348("NFA4-5 scope[1]")
NFA4_9_5720927("NFA4-9 scope[1]")
NFA4_13_60741955("NFA4-13 char[1]")
NFA4_11_9806683("NFA4-11 scope[1]")
NFA4_15_35532643[\"NFA4-15 char[1]"/]
NFA4_16_21151286 -->|"/"|NFA4_1_56143854
NFA4_1_56143854 -->|"*"|NFA4_3_635658
NFA4_3_635658 -->|"[^*]"|NFA4_5_51488348
NFA4_3_635658 -->|"[*]"|NFA4_9_5720927
NFA4_3_635658 -->|"*"|NFA4_13_60741955
NFA4_5_51488348 -->|"[^*]"|NFA4_5_51488348
NFA4_5_51488348 -->|"[*]"|NFA4_9_5720927
NFA4_5_51488348 -->|"*"|NFA4_13_60741955
NFA4_9_5720927 -->|"[^/]"|NFA4_11_9806683
NFA4_13_60741955 -->|"/"|NFA4_15_35532643
NFA4_11_9806683 -->|"[^*]"|NFA4_5_51488348
NFA4_11_9806683 -->|"[*]"|NFA4_9_5720927
NFA4_11_9806683 -->|"*"|NFA4_13_60741955
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
subgraph DFA0_1073972679["DFA0 regex start"]
NFA4_16_21151286_0("NFA4-16 regex start")
end
subgraph DFA1_-965150740["DFA1 {1}"]
NFA4_1_56143854_1("NFA4-1 char[1]")
end
subgraph DFA2_1101388524["DFA2 {1}"]
NFA4_3_635658_2("NFA4-3 char[1]")
end
subgraph DFA3_-1814757880["DFA3 {1}"]
NFA4_5_51488348_3("NFA4-5 scope[1]")
end
subgraph DFA4_981660735["DFA4 {2}"]
NFA4_9_5720927_4("NFA4-9 scope[1]")
NFA4_13_60741955_5("NFA4-13 char[1]")
end
subgraph DFA5_49972413["DFA5 {1}"]
NFA4_11_9806683_6("NFA4-11 scope[1]")
end
subgraph DFA6_-1204380963["DFA6 {1}"]
NFA4_15_35532643_7[\"NFA4-15 char[1]"/]
end
DFA0_1073972679 -->|"/"|DFA1_-965150740
DFA1_-965150740 -->|"*"|DFA2_1101388524
DFA2_1101388524 -->|"[^*]"|DFA3_-1814757880
DFA2_1101388524 -->|"*"|DFA4_981660735
DFA3_-1814757880 -->|"[^*]"|DFA3_-1814757880
DFA3_-1814757880 -->|"*"|DFA4_981660735
DFA4_981660735 -->|"[^/]"|DFA5_49972413
DFA4_981660735 -->|"/"|DFA6_-1204380963
DFA5_49972413 -->|"[^*]"|DFA3_-1814757880
DFA5_49972413 -->|"*"|DFA4_981660735
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
DFA0_1073972679{{"DFA0 regex start"}}
DFA1_-965150740{{"DFA1 {1}"}}
DFA2_1101388524{{"DFA2 {1}"}}
DFA3_-1814757880{{"DFA3 {1}"}}
DFA4_981660735{{"DFA4 {2}"}}
DFA5_49972413{{"DFA5 {1}"}}
DFA6_-1204380963[\"DFA6 {1}"/]
DFA0_1073972679 -->|"/"|DFA1_-965150740
DFA1_-965150740 -->|"*"|DFA2_1101388524
DFA2_1101388524 -->|"[^*]"|DFA3_-1814757880
DFA2_1101388524 -->|"*"|DFA4_981660735
DFA3_-1814757880 -->|"[^*]"|DFA3_-1814757880
DFA3_-1814757880 -->|"*"|DFA4_981660735
DFA4_981660735 -->|"[^/]"|DFA5_49972413
DFA4_981660735 -->|"/"|DFA6_-1204380963
DFA5_49972413 -->|"[^*]"|DFA3_-1814757880
DFA5_49972413 -->|"*"|DFA4_981660735
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
subgraph MiniDFA0_624432673["MiniDFA0 {1}"]
DFA0_1073972679_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_320374368["MiniDFA1 {1}"]
DFA1_-965150740_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1038945383["MiniDFA2 {3}"]
DFA2_1101388524_2{{"DFA2 {1}"}}
DFA3_-1814757880_3{{"DFA3 {1}"}}
DFA5_49972413_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_-435871385["MiniDFA3 {1}"]
DFA4_981660735_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_299585725["MiniDFA4 {1}"]
DFA6_-1204380963_6[\"DFA6 {1}"/]
end
MiniDFA0_624432673 -->|"/"|MiniDFA1_320374368
MiniDFA1_320374368 -->|"*"|MiniDFA2_-1038945383
MiniDFA2_-1038945383 -->|"[^*]"|MiniDFA2_-1038945383
MiniDFA2_-1038945383 -->|"*"|MiniDFA3_-435871385
MiniDFA3_-435871385 -->|"[^/]"|MiniDFA2_-1038945383
MiniDFA3_-435871385 -->|"/"|MiniDFA4_299585725
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
MiniDFA0_624432673(["MiniDFA0 {1}"])
MiniDFA1_320374368(["MiniDFA1 {1}"])
MiniDFA2_-1038945383(["MiniDFA2 {3}"])
MiniDFA3_-435871385(["MiniDFA3 {1}"])
MiniDFA4_299585725[\"MiniDFA4 {1}"/]
MiniDFA0_624432673 -->|"/"|MiniDFA1_320374368
MiniDFA1_320374368 -->|"*"|MiniDFA2_-1038945383
MiniDFA2_-1038945383 -->|"[^*]"|MiniDFA2_-1038945383
MiniDFA2_-1038945383 -->|"*"|MiniDFA3_-435871385
MiniDFA3_-435871385 -->|"[^/]"|MiniDFA2_-1038945383
MiniDFA3_-435871385 -->|"/"|MiniDFA4_299585725
```
-------------------------------
