# 'dvec3'

pattern: `dvec3`

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
eNFA84_10_53130720[["εNFA84-10 regex start"]]
eNFA84_0_8414436[["εNFA84-0 char{1, 1}"]]
eNFA84_1_8621060[["εNFA84-1 char[1]"]]
eNFA84_2_10480683[["εNFA84-2 char{1, 1}"]]
eNFA84_3_27217289[["εNFA84-3 char[1]"]]
eNFA84_4_43629015[["εNFA84-4 char{1, 1}"]]
eNFA84_5_57116823[["εNFA84-5 char[1]"]]
eNFA84_6_44289360[["εNFA84-6 char{1, 1}"]]
eNFA84_7_63059925[["εNFA84-7 char[1]"]]
eNFA84_8_30668413[["εNFA84-8 char{1, 1}"]]
eNFA84_9_7580267[["εNFA84-9 char[1]"]]
eNFA84_11_1113543[["εNFA84-11 regex end"]]
eNFA84_12_10021890[["εNFA84-12 post-regex start"]]
eNFA84_13_23088149[\"εNFA84-13 post-regex end"/]
eNFA84_10_53130720 -.->|"ε"|eNFA84_0_8414436
eNFA84_0_8414436 -->|"d"|eNFA84_1_8621060
eNFA84_1_8621060 -.->|"ε"|eNFA84_2_10480683
eNFA84_2_10480683 -->|"v"|eNFA84_3_27217289
eNFA84_3_27217289 -.->|"ε"|eNFA84_4_43629015
eNFA84_4_43629015 -->|"e"|eNFA84_5_57116823
eNFA84_5_57116823 -.->|"ε"|eNFA84_6_44289360
eNFA84_6_44289360 -->|"c"|eNFA84_7_63059925
eNFA84_7_63059925 -.->|"ε"|eNFA84_8_30668413
eNFA84_8_30668413 -->|"3"|eNFA84_9_7580267
eNFA84_9_7580267 -.->|"ε"|eNFA84_11_1113543
eNFA84_11_1113543 -.->|"ε"|eNFA84_12_10021890
eNFA84_12_10021890 -.->|"ε"|eNFA84_13_23088149
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
eNFA84_10_6466753[["εNFA84-10 regex start"]]
eNFA84_0_58200784[["εNFA84-0 char{1, 1}"]]
eNFA84_1_54045009[["εNFA84-1 char[1]"]]
eNFA84_2_16643039[["εNFA84-2 char{1, 1}"]]
eNFA84_3_15569626[["εNFA84-3 char[1]"]]
eNFA84_4_5908907[["εNFA84-4 char{1, 1}"]]
eNFA84_5_53180163[["εNFA84-5 char[1]"]]
eNFA84_6_8859419[["εNFA84-6 char{1, 1}"]]
eNFA84_7_12625908[["εNFA84-7 char[1]"]]
eNFA84_8_46524311[["εNFA84-8 char{1, 1}"]]
eNFA84_9_16065622[\"εNFA84-9 char[1]"/]
eNFA84_11_10372872[\"εNFA84-11 regex end"/]
eNFA84_12_26246992[\"εNFA84-12 post-regex start"/]
eNFA84_13_34896342[\"εNFA84-13 post-regex end"/]
eNFA84_10_6466753 -.->|"ε"|eNFA84_0_58200784
eNFA84_10_6466753 -->|"d"|eNFA84_1_54045009
eNFA84_0_58200784 -->|"d"|eNFA84_1_54045009
eNFA84_1_54045009 -.->|"ε"|eNFA84_2_16643039
eNFA84_1_54045009 -->|"v"|eNFA84_3_15569626
eNFA84_2_16643039 -->|"v"|eNFA84_3_15569626
eNFA84_3_15569626 -.->|"ε"|eNFA84_4_5908907
eNFA84_3_15569626 -->|"e"|eNFA84_5_53180163
eNFA84_4_5908907 -->|"e"|eNFA84_5_53180163
eNFA84_5_53180163 -.->|"ε"|eNFA84_6_8859419
eNFA84_5_53180163 -->|"c"|eNFA84_7_12625908
eNFA84_6_8859419 -->|"c"|eNFA84_7_12625908
eNFA84_7_12625908 -.->|"ε"|eNFA84_8_46524311
eNFA84_7_12625908 -->|"3"|eNFA84_9_16065622
eNFA84_8_46524311 -->|"3"|eNFA84_9_16065622
eNFA84_9_16065622 -.->|"ε"|eNFA84_11_10372872
eNFA84_9_16065622 -.->|"ε"|eNFA84_12_26246992
eNFA84_9_16065622 -.->|"ε"|eNFA84_13_34896342
eNFA84_11_10372872 -.->|"ε"|eNFA84_12_26246992
eNFA84_11_10372872 -.->|"ε"|eNFA84_13_34896342
eNFA84_12_26246992 -.->|"ε"|eNFA84_13_34896342
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
NFA84_10_45631627("NFA84-10 regex start")
NFA84_1_8031464("NFA84-1 char[1]")
NFA84_3_5174319("NFA84-3 char[1]")
NFA84_5_46568871("NFA84-5 char[1]")
NFA84_7_16466658("NFA84-7 char[1]")
NFA84_9_13982202[\"NFA84-9 char[1]"/]
NFA84_10_45631627 -->|"d"|NFA84_1_8031464
NFA84_1_8031464 -->|"v"|NFA84_3_5174319
NFA84_3_5174319 -->|"e"|NFA84_5_46568871
NFA84_5_46568871 -->|"c"|NFA84_7_16466658
NFA84_7_16466658 -->|"3"|NFA84_9_13982202
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
subgraph DFA0_359930008["DFA0 regex start"]
NFA84_10_45631627_0("NFA84-10 regex start")
end
subgraph DFA1_332126658["DFA1 {1}"]
NFA84_1_8031464_1("NFA84-1 char[1]")
end
subgraph DFA2_1057540540["DFA2 {1}"]
NFA84_3_5174319_2("NFA84-3 char[1]")
end
subgraph DFA3_1607233001["DFA3 {1}"]
NFA84_5_46568871_3("NFA84-5 char[1]")
end
subgraph DFA4_-1660705113["DFA4 {1}"]
NFA84_7_16466658_4("NFA84-7 char[1]")
end
subgraph DFA5_576117612["DFA5 {1}"]
NFA84_9_13982202_5[\"NFA84-9 char[1]"/]
end
DFA0_359930008 -->|"d"|DFA1_332126658
DFA1_332126658 -->|"v"|DFA2_1057540540
DFA2_1057540540 -->|"e"|DFA3_1607233001
DFA3_1607233001 -->|"c"|DFA4_-1660705113
DFA4_-1660705113 -->|"3"|DFA5_576117612
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
DFA0_359930008{{"DFA0 regex start"}}
DFA1_332126658{{"DFA1 {1}"}}
DFA2_1057540540{{"DFA2 {1}"}}
DFA3_1607233001{{"DFA3 {1}"}}
DFA4_-1660705113{{"DFA4 {1}"}}
DFA5_576117612[\"DFA5 {1}"/]
DFA0_359930008 -->|"d"|DFA1_332126658
DFA1_332126658 -->|"v"|DFA2_1057540540
DFA2_1057540540 -->|"e"|DFA3_1607233001
DFA3_1607233001 -->|"c"|DFA4_-1660705113
DFA4_-1660705113 -->|"3"|DFA5_576117612
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
subgraph MiniDFA0_-962546595["MiniDFA0 {1}"]
DFA0_359930008_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_631284570["MiniDFA1 {1}"]
DFA1_332126658_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1176900300["MiniDFA2 {1}"]
DFA2_1057540540_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-614805443["MiniDFA3 {1}"]
DFA3_1607233001_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_293902260["MiniDFA4 {1}"]
DFA4_-1660705113_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1567209395["MiniDFA5 {1}"]
DFA5_576117612_5[\"DFA5 {1}"/]
end
MiniDFA0_-962546595 -->|"d"|MiniDFA1_631284570
MiniDFA1_631284570 -->|"v"|MiniDFA2_-1176900300
MiniDFA2_-1176900300 -->|"e"|MiniDFA3_-614805443
MiniDFA3_-614805443 -->|"c"|MiniDFA4_293902260
MiniDFA4_293902260 -->|"3"|MiniDFA5_-1567209395
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
MiniDFA0_-962546595(["MiniDFA0 {1}"])
MiniDFA1_631284570(["MiniDFA1 {1}"])
MiniDFA2_-1176900300(["MiniDFA2 {1}"])
MiniDFA3_-614805443(["MiniDFA3 {1}"])
MiniDFA4_293902260(["MiniDFA4 {1}"])
MiniDFA5_-1567209395[\"MiniDFA5 {1}"/]
MiniDFA0_-962546595 -->|"d"|MiniDFA1_631284570
MiniDFA1_631284570 -->|"v"|MiniDFA2_-1176900300
MiniDFA2_-1176900300 -->|"e"|MiniDFA3_-614805443
MiniDFA3_-614805443 -->|"c"|MiniDFA4_293902260
MiniDFA4_293902260 -->|"3"|MiniDFA5_-1567209395
```
-------------------------------
