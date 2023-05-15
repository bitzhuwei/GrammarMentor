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
eNFA4_16_26367774[["εNFA4-16 regex start"]]
eNFA4_0_35983374[["εNFA4-0 char{1, 1}"]]
eNFA4_1_55414911[["εNFA4-1 char[1]"]]
eNFA4_2_28972154[["εNFA4-2 char{1, 1}"]]
eNFA4_3_53470928[["εNFA4-3 char[1]"]]
eNFA4_6_37901860[["εNFA4-6 regex start"]]
eNFA4_4_50151842[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_5572426[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_48713395[["εNFA4-7 regex end"]]
eNFA4_5_36177930[["εNFA4-5 scope[1]"]]
eNFA4_9_37608550[["εNFA4-9 scope[1]"]]
eNFA4_12_11476310[["εNFA4-12 char{1, 1}"]]
eNFA4_10_57516701[["εNFA4-10 scope{1, 1}"]]
eNFA4_13_47888269[["εNFA4-13 char[1]"]]
eNFA4_11_66458099[["εNFA4-11 scope[1]"]]
eNFA4_14_28341242[["εNFA4-14 char{1, 1}"]]
eNFA4_15_13939255[["εNFA4-15 char[1]"]]
eNFA4_17_58344433[["εNFA4-17 regex end"]]
eNFA4_18_55337852[["εNFA4-18 post-regex start"]]
eNFA4_19_28278626[\"εNFA4-19 post-regex end"/]
eNFA4_16_26367774 -.->|"ε"|eNFA4_0_35983374
eNFA4_0_35983374 -->|"/"|eNFA4_1_55414911
eNFA4_1_55414911 -.->|"ε"|eNFA4_2_28972154
eNFA4_2_28972154 -->|"*"|eNFA4_3_53470928
eNFA4_3_53470928 -.->|"ε"|eNFA4_6_37901860
eNFA4_6_37901860 -.->|"ε"|eNFA4_4_50151842
eNFA4_6_37901860 -.->|"ε"|eNFA4_8_5572426
eNFA4_6_37901860 -.->|"ε"|eNFA4_7_48713395
eNFA4_4_50151842 -->|"[^*]"|eNFA4_5_36177930
eNFA4_8_5572426 -->|"[*]"|eNFA4_9_37608550
eNFA4_7_48713395 -.->|"ε"|eNFA4_6_37901860
eNFA4_7_48713395 -.->|"ε"|eNFA4_12_11476310
eNFA4_5_36177930 -.->|"ε"|eNFA4_7_48713395
eNFA4_9_37608550 -.->|"ε"|eNFA4_10_57516701
eNFA4_12_11476310 -->|"*"|eNFA4_13_47888269
eNFA4_10_57516701 -->|"[^/]"|eNFA4_11_66458099
eNFA4_13_47888269 -.->|"ε"|eNFA4_14_28341242
eNFA4_11_66458099 -.->|"ε"|eNFA4_7_48713395
eNFA4_14_28341242 -->|"/"|eNFA4_15_13939255
eNFA4_15_13939255 -.->|"ε"|eNFA4_17_58344433
eNFA4_17_58344433 -.->|"ε"|eNFA4_18_55337852
eNFA4_18_55337852 -.->|"ε"|eNFA4_19_28278626
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
eNFA4_16_53181042[["εNFA4-16 regex start"]]
eNFA4_0_8867335[["εNFA4-0 char{1, 1}"]]
eNFA4_1_12697152[["εNFA4-1 char[1]"]]
eNFA4_2_47165512[["εNFA4-2 char{1, 1}"]]
eNFA4_3_2932635[["εNFA4-3 char[1]"]]
eNFA4_6_59422801[["εNFA4-6 regex start"]]
eNFA4_4_48517563[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_65043163[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_34004889[["εNFA4-7 regex end"]]
eNFA4_5_36216906[["εNFA4-5 scope[1]"]]
eNFA4_9_21836431[["εNFA4-9 scope[1]"]]
eNFA4_12_26393722[["εNFA4-12 char{1, 1}"]]
eNFA4_13_23920519[["εNFA4-13 char[1]"]]
eNFA4_10_62310159[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_53744589[["εNFA4-11 scope[1]"]]
eNFA4_14_13958081[["εNFA4-14 char{1, 1}"]]
eNFA4_15_58513871[\"εNFA4-15 char[1]"/]
eNFA4_17_56862792[\"εNFA4-17 regex end"/]
eNFA4_18_42003087[\"εNFA4-18 post-regex start"/]
eNFA4_19_42483468[\"εNFA4-19 post-regex end"/]
eNFA4_16_53181042 -.->|"ε"|eNFA4_0_8867335
eNFA4_16_53181042 -->|"/"|eNFA4_1_12697152
eNFA4_0_8867335 -->|"/"|eNFA4_1_12697152
eNFA4_1_12697152 -.->|"ε"|eNFA4_2_47165512
eNFA4_1_12697152 -->|"*"|eNFA4_3_2932635
eNFA4_2_47165512 -->|"*"|eNFA4_3_2932635
eNFA4_3_2932635 -.->|"ε"|eNFA4_6_59422801
eNFA4_3_2932635 -.->|"ε"|eNFA4_4_48517563
eNFA4_3_2932635 -.->|"ε"|eNFA4_8_65043163
eNFA4_3_2932635 -.->|"ε"|eNFA4_7_34004889
eNFA4_3_2932635 -->|"[^*]"|eNFA4_5_36216906
eNFA4_3_2932635 -->|"[*]"|eNFA4_9_21836431
eNFA4_3_2932635 -.->|"ε"|eNFA4_12_26393722
eNFA4_3_2932635 -->|"*"|eNFA4_13_23920519
eNFA4_6_59422801 -.->|"ε"|eNFA4_4_48517563
eNFA4_6_59422801 -.->|"ε"|eNFA4_8_65043163
eNFA4_6_59422801 -.->|"ε"|eNFA4_7_34004889
eNFA4_6_59422801 -->|"[^*]"|eNFA4_5_36216906
eNFA4_6_59422801 -->|"[*]"|eNFA4_9_21836431
eNFA4_6_59422801 -.->|"ε"|eNFA4_6_59422801
eNFA4_6_59422801 -.->|"ε"|eNFA4_12_26393722
eNFA4_6_59422801 -->|"*"|eNFA4_13_23920519
eNFA4_4_48517563 -->|"[^*]"|eNFA4_5_36216906
eNFA4_8_65043163 -->|"[*]"|eNFA4_9_21836431
eNFA4_7_34004889 -.->|"ε"|eNFA4_6_59422801
eNFA4_7_34004889 -.->|"ε"|eNFA4_12_26393722
eNFA4_7_34004889 -.->|"ε"|eNFA4_4_48517563
eNFA4_7_34004889 -.->|"ε"|eNFA4_8_65043163
eNFA4_7_34004889 -.->|"ε"|eNFA4_7_34004889
eNFA4_7_34004889 -->|"[^*]"|eNFA4_5_36216906
eNFA4_7_34004889 -->|"[*]"|eNFA4_9_21836431
eNFA4_7_34004889 -->|"*"|eNFA4_13_23920519
eNFA4_5_36216906 -.->|"ε"|eNFA4_7_34004889
eNFA4_5_36216906 -.->|"ε"|eNFA4_6_59422801
eNFA4_5_36216906 -.->|"ε"|eNFA4_12_26393722
eNFA4_5_36216906 -.->|"ε"|eNFA4_4_48517563
eNFA4_5_36216906 -.->|"ε"|eNFA4_8_65043163
eNFA4_5_36216906 -->|"[^*]"|eNFA4_5_36216906
eNFA4_5_36216906 -->|"[*]"|eNFA4_9_21836431
eNFA4_5_36216906 -->|"*"|eNFA4_13_23920519
eNFA4_9_21836431 -.->|"ε"|eNFA4_10_62310159
eNFA4_9_21836431 -->|"[^/]"|eNFA4_11_53744589
eNFA4_12_26393722 -->|"*"|eNFA4_13_23920519
eNFA4_13_23920519 -.->|"ε"|eNFA4_14_13958081
eNFA4_13_23920519 -->|"/"|eNFA4_15_58513871
eNFA4_10_62310159 -->|"[^/]"|eNFA4_11_53744589
eNFA4_11_53744589 -.->|"ε"|eNFA4_7_34004889
eNFA4_11_53744589 -.->|"ε"|eNFA4_6_59422801
eNFA4_11_53744589 -.->|"ε"|eNFA4_12_26393722
eNFA4_11_53744589 -.->|"ε"|eNFA4_4_48517563
eNFA4_11_53744589 -.->|"ε"|eNFA4_8_65043163
eNFA4_11_53744589 -->|"[^*]"|eNFA4_5_36216906
eNFA4_11_53744589 -->|"[*]"|eNFA4_9_21836431
eNFA4_11_53744589 -->|"*"|eNFA4_13_23920519
eNFA4_14_13958081 -->|"/"|eNFA4_15_58513871
eNFA4_15_58513871 -.->|"ε"|eNFA4_17_56862792
eNFA4_15_58513871 -.->|"ε"|eNFA4_18_42003087
eNFA4_15_58513871 -.->|"ε"|eNFA4_19_42483468
eNFA4_17_56862792 -.->|"ε"|eNFA4_18_42003087
eNFA4_17_56862792 -.->|"ε"|eNFA4_19_42483468
eNFA4_18_42003087 -.->|"ε"|eNFA4_19_42483468
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
NFA4_16_21868626("NFA4-16 regex start")
NFA4_1_62599910("NFA4-1 char[1]")
NFA4_3_46806896("NFA4-3 char[1]")
NFA4_5_33262233("NFA4-5 scope[1]")
NFA4_9_18608884("NFA4-9 scope[1]")
NFA4_13_30924649("NFA4-13 char[1]")
NFA4_11_9886387("NFA4-11 scope[1]")
NFA4_15_26528280[\"NFA4-15 char[1]"/]
NFA4_16_21868626 -->|"/"|NFA4_1_62599910
NFA4_1_62599910 -->|"*"|NFA4_3_46806896
NFA4_3_46806896 -->|"[^*]"|NFA4_5_33262233
NFA4_3_46806896 -->|"[*]"|NFA4_9_18608884
NFA4_3_46806896 -->|"*"|NFA4_13_30924649
NFA4_5_33262233 -->|"[^*]"|NFA4_5_33262233
NFA4_5_33262233 -->|"[*]"|NFA4_9_18608884
NFA4_5_33262233 -->|"*"|NFA4_13_30924649
NFA4_9_18608884 -->|"[^/]"|NFA4_11_9886387
NFA4_13_30924649 -->|"/"|NFA4_15_26528280
NFA4_11_9886387 -->|"[^*]"|NFA4_5_33262233
NFA4_11_9886387 -->|"[*]"|NFA4_9_18608884
NFA4_11_9886387 -->|"*"|NFA4_13_30924649
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
subgraph DFA0_-1280095440["DFA0 regex start"]
NFA4_16_21868626_0("NFA4-16 regex start")
end
subgraph DFA1_1026508518["DFA1 {1}"]
NFA4_1_62599910_1("NFA4-1 char[1]")
end
subgraph DFA2_1613474041["DFA2 {1}"]
NFA4_3_46806896_2("NFA4-3 char[1]")
end
subgraph DFA3_-21084192["DFA3 {1}"]
NFA4_5_33262233_3("NFA4-5 scope[1]")
end
subgraph DFA4_273235804["DFA4 {2}"]
NFA4_9_18608884_4("NFA4-9 scope[1]")
NFA4_13_30924649_5("NFA4-13 char[1]")
end
subgraph DFA5_-739175451["DFA5 {1}"]
NFA4_11_9886387_6("NFA4-11 scope[1]")
end
subgraph DFA6_1254050985["DFA6 {1}"]
NFA4_15_26528280_7[\"NFA4-15 char[1]"/]
end
DFA0_-1280095440 -->|"/"|DFA1_1026508518
DFA1_1026508518 -->|"*"|DFA2_1613474041
DFA2_1613474041 -->|"[^*]"|DFA3_-21084192
DFA2_1613474041 -->|"*"|DFA4_273235804
DFA3_-21084192 -->|"[^*]"|DFA3_-21084192
DFA3_-21084192 -->|"*"|DFA4_273235804
DFA4_273235804 -->|"[^/]"|DFA5_-739175451
DFA4_273235804 -->|"/"|DFA6_1254050985
DFA5_-739175451 -->|"[^*]"|DFA3_-21084192
DFA5_-739175451 -->|"*"|DFA4_273235804
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
DFA0_-1280095440{{"DFA0 regex start"}}
DFA1_1026508518{{"DFA1 {1}"}}
DFA2_1613474041{{"DFA2 {1}"}}
DFA3_-21084192{{"DFA3 {1}"}}
DFA4_273235804{{"DFA4 {2}"}}
DFA5_-739175451{{"DFA5 {1}"}}
DFA6_1254050985[\"DFA6 {1}"/]
DFA0_-1280095440 -->|"/"|DFA1_1026508518
DFA1_1026508518 -->|"*"|DFA2_1613474041
DFA2_1613474041 -->|"[^*]"|DFA3_-21084192
DFA2_1613474041 -->|"*"|DFA4_273235804
DFA3_-21084192 -->|"[^*]"|DFA3_-21084192
DFA3_-21084192 -->|"*"|DFA4_273235804
DFA4_273235804 -->|"[^/]"|DFA5_-739175451
DFA4_273235804 -->|"/"|DFA6_1254050985
DFA5_-739175451 -->|"[^*]"|DFA3_-21084192
DFA5_-739175451 -->|"*"|DFA4_273235804
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
subgraph MiniDFA0_1702695940["MiniDFA0 {1}"]
DFA0_-1280095440_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_617255648["MiniDFA1 {1}"]
DFA1_1026508518_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1749273778["MiniDFA2 {3}"]
DFA2_1613474041_2{{"DFA2 {1}"}}
DFA3_-21084192_3{{"DFA3 {1}"}}
DFA5_-739175451_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_111256166["MiniDFA3 {1}"]
DFA4_273235804_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_256555465["MiniDFA4 {1}"]
DFA6_1254050985_6[\"DFA6 {1}"/]
end
MiniDFA0_1702695940 -->|"/"|MiniDFA1_617255648
MiniDFA1_617255648 -->|"*"|MiniDFA2_1749273778
MiniDFA2_1749273778 -->|"[^*]"|MiniDFA2_1749273778
MiniDFA2_1749273778 -->|"*"|MiniDFA3_111256166
MiniDFA3_111256166 -->|"[^/]"|MiniDFA2_1749273778
MiniDFA3_111256166 -->|"/"|MiniDFA4_256555465
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
MiniDFA0_1702695940(["MiniDFA0 {1}"])
MiniDFA1_617255648(["MiniDFA1 {1}"])
MiniDFA2_1749273778(["MiniDFA2 {3}"])
MiniDFA3_111256166(["MiniDFA3 {1}"])
MiniDFA4_256555465[\"MiniDFA4 {1}"/]
MiniDFA0_1702695940 -->|"/"|MiniDFA1_617255648
MiniDFA1_617255648 -->|"*"|MiniDFA2_1749273778
MiniDFA2_1749273778 -->|"[^*]"|MiniDFA2_1749273778
MiniDFA2_1749273778 -->|"*"|MiniDFA3_111256166
MiniDFA3_111256166 -->|"[^/]"|MiniDFA2_1749273778
MiniDFA3_111256166 -->|"/"|MiniDFA4_256555465
```
-------------------------------
