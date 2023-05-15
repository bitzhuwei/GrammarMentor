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
eNFA6_16_49211517[["εNFA6-16 regex start"]]
eNFA6_0_40250470[["εNFA6-0 char{1, 1}"]]
eNFA6_1_26709911[["εNFA6-1 char[1]"]]
eNFA6_2_39062609[["εNFA6-2 char{1, 1}"]]
eNFA6_3_28552188[["εNFA6-3 char[1]"]]
eNFA6_6_23815725[["εNFA6-6 regex start"]]
eNFA6_4_50025604[["εNFA6-4 scope{1, 1}"]]
eNFA6_8_13014940[["εNFA6-8 scope{1, 1}"]]
eNFA6_7_47577252[["εNFA6-7 regex end"]]
eNFA6_5_31025868[["εNFA6-5 scope[1]"]]
eNFA6_9_9266704[["εNFA6-9 scope[1]"]]
eNFA6_12_55643101[["εNFA6-12 char{1, 1}"]]
eNFA6_10_65327957[["εNFA6-10 scope{1, 1}"]]
eNFA6_13_51080706[["εNFA6-13 char[1]"]]
eNFA6_11_19539446[["εNFA6-11 scope[1]"]]
eNFA6_14_57073170[["εNFA6-14 char{1, 1}"]]
eNFA6_15_59524076[["εNFA6-15 char[1]"]]
eNFA6_17_65954639[["εNFA6-17 regex end"]]
eNFA6_18_56720842[["εNFA6-18 post-regex start"]]
eNFA6_19_40725534[\"εNFA6-19 post-regex end"/]
eNFA6_16_49211517 -.->|"ε"|eNFA6_0_40250470
eNFA6_0_40250470 -->|"/"|eNFA6_1_26709911
eNFA6_1_26709911 -.->|"ε"|eNFA6_2_39062609
eNFA6_2_39062609 -->|"*"|eNFA6_3_28552188
eNFA6_3_28552188 -.->|"ε"|eNFA6_6_23815725
eNFA6_6_23815725 -.->|"ε"|eNFA6_4_50025604
eNFA6_6_23815725 -.->|"ε"|eNFA6_8_13014940
eNFA6_6_23815725 -.->|"ε"|eNFA6_7_47577252
eNFA6_4_50025604 -->|"[^*]"|eNFA6_5_31025868
eNFA6_8_13014940 -->|"[*]"|eNFA6_9_9266704
eNFA6_7_47577252 -.->|"ε"|eNFA6_6_23815725
eNFA6_7_47577252 -.->|"ε"|eNFA6_12_55643101
eNFA6_5_31025868 -.->|"ε"|eNFA6_7_47577252
eNFA6_9_9266704 -.->|"ε"|eNFA6_10_65327957
eNFA6_12_55643101 -->|"*"|eNFA6_13_51080706
eNFA6_10_65327957 -->|"[^/]"|eNFA6_11_19539446
eNFA6_13_51080706 -.->|"ε"|eNFA6_14_57073170
eNFA6_11_19539446 -.->|"ε"|eNFA6_7_47577252
eNFA6_14_57073170 -->|"/"|eNFA6_15_59524076
eNFA6_15_59524076 -.->|"ε"|eNFA6_17_65954639
eNFA6_17_65954639 -.->|"ε"|eNFA6_18_56720842
eNFA6_18_56720842 -.->|"ε"|eNFA6_19_40725534
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
eNFA6_16_30985493[["εNFA6-16 regex start"]]
eNFA6_0_10433982[["εNFA6-0 char{1, 1}"]]
eNFA6_1_26796980[["εNFA6-1 char[1]"]]
eNFA6_2_39846231[["εNFA6-2 char{1, 1}"]]
eNFA6_3_16291478[["εNFA6-3 char[1]"]]
eNFA6_6_16019165[["εNFA6-6 regex start"]]
eNFA6_4_22484025[["εNFA6-4 scope{1, 1}"]]
eNFA6_8_9954765[["εNFA6-8 scope{1, 1}"]]
eNFA6_7_1029633[["εNFA6-7 regex end"]]
eNFA6_5_44541364[["εNFA6-5 scope[1]"]]
eNFA6_9_23071760[["εNFA6-9 scope[1]"]]
eNFA6_12_12405580[["εNFA6-12 char{1, 1}"]]
eNFA6_13_56873232[["εNFA6-13 char[1]"]]
eNFA6_10_6319248[["εNFA6-10 scope{1, 1}"]]
eNFA6_11_43896488[["εNFA6-11 scope[1]"]]
eNFA6_14_42097041[["εNFA6-14 char{1, 1}"]]
eNFA6_15_43329052[\"εNFA6-15 char[1]"/]
eNFA6_17_54417155[\"εNFA6-17 regex end"/]
eNFA6_18_19992349[\"εNFA6-18 post-regex start"/]
eNFA6_19_45713421[\"εNFA6-19 post-regex end"/]
eNFA6_16_30985493 -.->|"ε"|eNFA6_0_10433982
eNFA6_16_30985493 -->|"/"|eNFA6_1_26796980
eNFA6_0_10433982 -->|"/"|eNFA6_1_26796980
eNFA6_1_26796980 -.->|"ε"|eNFA6_2_39846231
eNFA6_1_26796980 -->|"*"|eNFA6_3_16291478
eNFA6_2_39846231 -->|"*"|eNFA6_3_16291478
eNFA6_3_16291478 -.->|"ε"|eNFA6_6_16019165
eNFA6_3_16291478 -.->|"ε"|eNFA6_4_22484025
eNFA6_3_16291478 -.->|"ε"|eNFA6_8_9954765
eNFA6_3_16291478 -.->|"ε"|eNFA6_7_1029633
eNFA6_3_16291478 -->|"[^*]"|eNFA6_5_44541364
eNFA6_3_16291478 -->|"[*]"|eNFA6_9_23071760
eNFA6_3_16291478 -.->|"ε"|eNFA6_12_12405580
eNFA6_3_16291478 -->|"*"|eNFA6_13_56873232
eNFA6_6_16019165 -.->|"ε"|eNFA6_4_22484025
eNFA6_6_16019165 -.->|"ε"|eNFA6_8_9954765
eNFA6_6_16019165 -.->|"ε"|eNFA6_7_1029633
eNFA6_6_16019165 -->|"[^*]"|eNFA6_5_44541364
eNFA6_6_16019165 -->|"[*]"|eNFA6_9_23071760
eNFA6_6_16019165 -.->|"ε"|eNFA6_6_16019165
eNFA6_6_16019165 -.->|"ε"|eNFA6_12_12405580
eNFA6_6_16019165 -->|"*"|eNFA6_13_56873232
eNFA6_4_22484025 -->|"[^*]"|eNFA6_5_44541364
eNFA6_8_9954765 -->|"[*]"|eNFA6_9_23071760
eNFA6_7_1029633 -.->|"ε"|eNFA6_6_16019165
eNFA6_7_1029633 -.->|"ε"|eNFA6_12_12405580
eNFA6_7_1029633 -.->|"ε"|eNFA6_4_22484025
eNFA6_7_1029633 -.->|"ε"|eNFA6_8_9954765
eNFA6_7_1029633 -.->|"ε"|eNFA6_7_1029633
eNFA6_7_1029633 -->|"[^*]"|eNFA6_5_44541364
eNFA6_7_1029633 -->|"[*]"|eNFA6_9_23071760
eNFA6_7_1029633 -->|"*"|eNFA6_13_56873232
eNFA6_5_44541364 -.->|"ε"|eNFA6_7_1029633
eNFA6_5_44541364 -.->|"ε"|eNFA6_6_16019165
eNFA6_5_44541364 -.->|"ε"|eNFA6_12_12405580
eNFA6_5_44541364 -.->|"ε"|eNFA6_4_22484025
eNFA6_5_44541364 -.->|"ε"|eNFA6_8_9954765
eNFA6_5_44541364 -->|"[^*]"|eNFA6_5_44541364
eNFA6_5_44541364 -->|"[*]"|eNFA6_9_23071760
eNFA6_5_44541364 -->|"*"|eNFA6_13_56873232
eNFA6_9_23071760 -.->|"ε"|eNFA6_10_6319248
eNFA6_9_23071760 -->|"[^/]"|eNFA6_11_43896488
eNFA6_12_12405580 -->|"*"|eNFA6_13_56873232
eNFA6_13_56873232 -.->|"ε"|eNFA6_14_42097041
eNFA6_13_56873232 -->|"/"|eNFA6_15_43329052
eNFA6_10_6319248 -->|"[^/]"|eNFA6_11_43896488
eNFA6_11_43896488 -.->|"ε"|eNFA6_7_1029633
eNFA6_11_43896488 -.->|"ε"|eNFA6_6_16019165
eNFA6_11_43896488 -.->|"ε"|eNFA6_12_12405580
eNFA6_11_43896488 -.->|"ε"|eNFA6_4_22484025
eNFA6_11_43896488 -.->|"ε"|eNFA6_8_9954765
eNFA6_11_43896488 -->|"[^*]"|eNFA6_5_44541364
eNFA6_11_43896488 -->|"[*]"|eNFA6_9_23071760
eNFA6_11_43896488 -->|"*"|eNFA6_13_56873232
eNFA6_14_42097041 -->|"/"|eNFA6_15_43329052
eNFA6_15_43329052 -.->|"ε"|eNFA6_17_54417155
eNFA6_15_43329052 -.->|"ε"|eNFA6_18_19992349
eNFA6_15_43329052 -.->|"ε"|eNFA6_19_45713421
eNFA6_17_54417155 -.->|"ε"|eNFA6_18_19992349
eNFA6_17_54417155 -.->|"ε"|eNFA6_19_45713421
eNFA6_18_19992349 -.->|"ε"|eNFA6_19_45713421
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
NFA6_16_40922063("NFA6-16 regex start")
NFA6_1_32754255("NFA6-1 char[1]")
NFA6_3_8767611("NFA6-3 char[1]")
NFA6_5_39087901("NFA6-5 scope[1]")
NFA6_9_11799640("NFA6-9 scope[1]")
NFA6_13_16246796("NFA6-13 char[1]")
NFA6_11_12003436("NFA6-11 scope[1]")
NFA6_15_26352844[\"NFA6-15 char[1]"/]
NFA6_16_40922063 -->|"/"|NFA6_1_32754255
NFA6_1_32754255 -->|"*"|NFA6_3_8767611
NFA6_3_8767611 -->|"[^*]"|NFA6_5_39087901
NFA6_3_8767611 -->|"[*]"|NFA6_9_11799640
NFA6_3_8767611 -->|"*"|NFA6_13_16246796
NFA6_5_39087901 -->|"[^*]"|NFA6_5_39087901
NFA6_5_39087901 -->|"[*]"|NFA6_9_11799640
NFA6_5_39087901 -->|"*"|NFA6_13_16246796
NFA6_9_11799640 -->|"[^/]"|NFA6_11_12003436
NFA6_13_16246796 -->|"/"|NFA6_15_26352844
NFA6_11_12003436 -->|"[^*]"|NFA6_5_39087901
NFA6_11_12003436 -->|"[*]"|NFA6_9_11799640
NFA6_11_12003436 -->|"*"|NFA6_13_16246796
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
subgraph DFA0_-761325535["DFA0 regex start"]
NFA6_16_40922063_0("NFA6-16 regex start")
end
subgraph DFA1_1919945768["DFA1 {1}"]
NFA6_1_32754255_1("NFA6-1 char[1]")
end
subgraph DFA2_-1750439964["DFA2 {1}"]
NFA6_3_8767611_2("NFA6-3 char[1]")
end
subgraph DFA3_2076903085["DFA3 {1}"]
NFA6_5_39087901_3("NFA6-5 scope[1]")
end
subgraph DFA4_124176737["DFA4 {2}"]
NFA6_9_11799640_4("NFA6-9 scope[1]")
NFA6_13_16246796_5("NFA6-13 char[1]")
end
subgraph DFA5_1462627464["DFA5 {1}"]
NFA6_11_12003436_6("NFA6-11 scope[1]")
end
subgraph DFA6_351022970["DFA6 {1}"]
NFA6_15_26352844_7[\"NFA6-15 char[1]"/]
end
DFA0_-761325535 -->|"/"|DFA1_1919945768
DFA1_1919945768 -->|"*"|DFA2_-1750439964
DFA2_-1750439964 -->|"[^*]"|DFA3_2076903085
DFA2_-1750439964 -->|"*"|DFA4_124176737
DFA3_2076903085 -->|"[^*]"|DFA3_2076903085
DFA3_2076903085 -->|"*"|DFA4_124176737
DFA4_124176737 -->|"[^/]"|DFA5_1462627464
DFA4_124176737 -->|"/"|DFA6_351022970
DFA5_1462627464 -->|"[^*]"|DFA3_2076903085
DFA5_1462627464 -->|"*"|DFA4_124176737
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
DFA0_-761325535{{"DFA0 regex start"}}
DFA1_1919945768{{"DFA1 {1}"}}
DFA2_-1750439964{{"DFA2 {1}"}}
DFA3_2076903085{{"DFA3 {1}"}}
DFA4_124176737{{"DFA4 {2}"}}
DFA5_1462627464{{"DFA5 {1}"}}
DFA6_351022970[\"DFA6 {1}"/]
DFA0_-761325535 -->|"/"|DFA1_1919945768
DFA1_1919945768 -->|"*"|DFA2_-1750439964
DFA2_-1750439964 -->|"[^*]"|DFA3_2076903085
DFA2_-1750439964 -->|"*"|DFA4_124176737
DFA3_2076903085 -->|"[^*]"|DFA3_2076903085
DFA3_2076903085 -->|"*"|DFA4_124176737
DFA4_124176737 -->|"[^/]"|DFA5_1462627464
DFA4_124176737 -->|"/"|DFA6_351022970
DFA5_1462627464 -->|"[^*]"|DFA3_2076903085
DFA5_1462627464 -->|"*"|DFA4_124176737
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
subgraph MiniDFA0_1800983019["MiniDFA0 {1}"]
DFA0_-761325535_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1983454737["MiniDFA1 {1}"]
DFA1_1919945768_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_711894042["MiniDFA2 {3}"]
DFA2_-1750439964_2{{"DFA2 {1}"}}
DFA3_2076903085_3{{"DFA3 {1}"}}
DFA5_1462627464_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_-1349372748["MiniDFA3 {1}"]
DFA4_124176737_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_1025048203["MiniDFA4 {1}"]
DFA6_351022970_6[\"DFA6 {1}"/]
end
MiniDFA0_1800983019 -->|"/"|MiniDFA1_-1983454737
MiniDFA1_-1983454737 -->|"*"|MiniDFA2_711894042
MiniDFA2_711894042 -->|"[^*]"|MiniDFA2_711894042
MiniDFA2_711894042 -->|"*"|MiniDFA3_-1349372748
MiniDFA3_-1349372748 -->|"[^/]"|MiniDFA2_711894042
MiniDFA3_-1349372748 -->|"/"|MiniDFA4_1025048203
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
MiniDFA0_1800983019(["MiniDFA0 {1}"])
MiniDFA1_-1983454737(["MiniDFA1 {1}"])
MiniDFA2_711894042(["MiniDFA2 {3}"])
MiniDFA3_-1349372748(["MiniDFA3 {1}"])
MiniDFA4_1025048203[\"MiniDFA4 {1}"/]
MiniDFA0_1800983019 -->|"/"|MiniDFA1_-1983454737
MiniDFA1_-1983454737 -->|"*"|MiniDFA2_711894042
MiniDFA2_711894042 -->|"[^*]"|MiniDFA2_711894042
MiniDFA2_711894042 -->|"*"|MiniDFA3_-1349372748
MiniDFA3_-1349372748 -->|"[^/]"|MiniDFA2_711894042
MiniDFA3_-1349372748 -->|"/"|MiniDFA4_1025048203
```
-------------------------------
