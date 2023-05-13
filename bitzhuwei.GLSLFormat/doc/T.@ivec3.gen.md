# 'ivec3'

pattern: `ivec3`

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
eNFA90_10_49552630[["εNFA90-10 regex start"]]
eNFA90_0_43320494[["εNFA90-0 char{1, 1}"]]
eNFA90_1_54340131[["εNFA90-1 char[1]"]]
eNFA90_2_19299134[["εNFA90-2 char{1, 1}"]]
eNFA90_3_39474480[["εNFA90-3 char[1]"]]
eNFA90_4_19726002[["εNFA90-4 char{1, 1}"]]
eNFA90_5_43316293[["εNFA90-5 char[1]"]]
eNFA90_6_54302323[["εNFA90-6 char{1, 1}"]]
eNFA90_7_18958859[["εNFA90-7 char[1]"]]
eNFA90_8_36412008[["εNFA90-8 char{1, 1}"]]
eNFA90_9_59272617[["εNFA90-9 char[1]"]]
eNFA90_11_63691513[["εNFA90-11 regex end"]]
eNFA90_12_36352712[["εNFA90-12 post-regex start"]]
eNFA90_13_58738960[\"εNFA90-13 post-regex end"/]
eNFA90_10_49552630 -.->|"ε"|eNFA90_0_43320494
eNFA90_0_43320494 -->|"i"|eNFA90_1_54340131
eNFA90_1_54340131 -.->|"ε"|eNFA90_2_19299134
eNFA90_2_19299134 -->|"v"|eNFA90_3_39474480
eNFA90_3_39474480 -.->|"ε"|eNFA90_4_19726002
eNFA90_4_19726002 -->|"e"|eNFA90_5_43316293
eNFA90_5_43316293 -.->|"ε"|eNFA90_6_54302323
eNFA90_6_54302323 -->|"c"|eNFA90_7_18958859
eNFA90_7_18958859 -.->|"ε"|eNFA90_8_36412008
eNFA90_8_36412008 -->|"3"|eNFA90_9_59272617
eNFA90_9_59272617 -.->|"ε"|eNFA90_11_63691513
eNFA90_11_63691513 -.->|"ε"|eNFA90_12_36352712
eNFA90_12_36352712 -.->|"ε"|eNFA90_13_58738960
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
eNFA90_10_58888592[["εNFA90-10 regex start"]]
eNFA90_0_60235282[["εNFA90-0 char{1, 1}"]]
eNFA90_1_5246632[["εNFA90-1 char[1]"]]
eNFA90_2_47219689[["εNFA90-2 char{1, 1}"]]
eNFA90_3_22324024[["εNFA90-3 char[1]"]]
eNFA90_4_66698493[["εNFA90-4 char{1, 1}"]]
eNFA90_5_63415529[["εNFA90-5 char[1]"]]
eNFA90_6_33868853[["εNFA90-6 char{1, 1}"]]
eNFA90_7_36384226[["εNFA90-7 char[1]"]]
eNFA90_8_59022586[["εNFA90-8 char{1, 1}"]]
eNFA90_9_61441228[\"εNFA90-9 char[1]"/]
eNFA90_11_16100147[\"εNFA90-11 regex end"/]
eNFA90_12_10683599[\"εNFA90-12 post-regex start"/]
eNFA90_13_29043529[\"εNFA90-13 post-regex end"/]
eNFA90_10_58888592 -.->|"ε"|eNFA90_0_60235282
eNFA90_10_58888592 -->|"i"|eNFA90_1_5246632
eNFA90_0_60235282 -->|"i"|eNFA90_1_5246632
eNFA90_1_5246632 -.->|"ε"|eNFA90_2_47219689
eNFA90_1_5246632 -->|"v"|eNFA90_3_22324024
eNFA90_2_47219689 -->|"v"|eNFA90_3_22324024
eNFA90_3_22324024 -.->|"ε"|eNFA90_4_66698493
eNFA90_3_22324024 -->|"e"|eNFA90_5_63415529
eNFA90_4_66698493 -->|"e"|eNFA90_5_63415529
eNFA90_5_63415529 -.->|"ε"|eNFA90_6_33868853
eNFA90_5_63415529 -->|"c"|eNFA90_7_36384226
eNFA90_6_33868853 -->|"c"|eNFA90_7_36384226
eNFA90_7_36384226 -.->|"ε"|eNFA90_8_59022586
eNFA90_7_36384226 -->|"3"|eNFA90_9_61441228
eNFA90_8_59022586 -->|"3"|eNFA90_9_61441228
eNFA90_9_61441228 -.->|"ε"|eNFA90_11_16100147
eNFA90_9_61441228 -.->|"ε"|eNFA90_12_10683599
eNFA90_9_61441228 -.->|"ε"|eNFA90_13_29043529
eNFA90_11_16100147 -.->|"ε"|eNFA90_12_10683599
eNFA90_11_16100147 -.->|"ε"|eNFA90_13_29043529
eNFA90_12_10683599 -.->|"ε"|eNFA90_13_29043529
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
NFA90_10_60065170("NFA90-10 regex start")
NFA90_1_3715619("NFA90-1 char[1]")
NFA90_3_33440573("NFA90-3 char[1]")
NFA90_5_32529705("NFA90-5 char[1]")
NFA90_7_24331897("NFA90-7 char[1]")
NFA90_9_17660485[\"NFA90-9 char[1]"/]
NFA90_10_60065170 -->|"i"|NFA90_1_3715619
NFA90_1_3715619 -->|"v"|NFA90_3_33440573
NFA90_3_33440573 -->|"e"|NFA90_5_32529705
NFA90_5_32529705 -->|"c"|NFA90_7_24331897
NFA90_7_24331897 -->|"3"|NFA90_9_17660485
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
subgraph DFA0_-692492151["DFA0 regex start"]
NFA90_10_60065170_0("NFA90-10 regex start")
end
subgraph DFA1_372739709["DFA1 {1}"]
NFA90_1_3715619_1("NFA90-1 char[1]")
end
subgraph DFA2_-2126865976["DFA2 {1}"]
NFA90_3_33440573_2("NFA90-3 char[1]")
end
subgraph DFA3_-1214397040["DFA3 {1}"]
NFA90_5_32529705_3("NFA90-5 char[1]")
end
subgraph DFA4_153364517["DFA4 {1}"]
NFA90_7_24331897_4("NFA90-7 char[1]")
end
subgraph DFA5_208189421["DFA5 {1}"]
NFA90_9_17660485_5[\"NFA90-9 char[1]"/]
end
DFA0_-692492151 -->|"i"|DFA1_372739709
DFA1_372739709 -->|"v"|DFA2_-2126865976
DFA2_-2126865976 -->|"e"|DFA3_-1214397040
DFA3_-1214397040 -->|"c"|DFA4_153364517
DFA4_153364517 -->|"3"|DFA5_208189421
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
DFA0_-692492151{{"DFA0 regex start"}}
DFA1_372739709{{"DFA1 {1}"}}
DFA2_-2126865976{{"DFA2 {1}"}}
DFA3_-1214397040{{"DFA3 {1}"}}
DFA4_153364517{{"DFA4 {1}"}}
DFA5_208189421[\"DFA5 {1}"/]
DFA0_-692492151 -->|"i"|DFA1_372739709
DFA1_372739709 -->|"v"|DFA2_-2126865976
DFA2_-2126865976 -->|"e"|DFA3_-1214397040
DFA3_-1214397040 -->|"c"|DFA4_153364517
DFA4_153364517 -->|"3"|DFA5_208189421
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
subgraph MiniDFA0_823784357["MiniDFA0 {1}"]
DFA0_-692492151_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_587361178["MiniDFA1 {1}"]
DFA1_372739709_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1099087955["MiniDFA2 {1}"]
DFA2_-2126865976_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_197952134["MiniDFA3 {1}"]
DFA3_-1214397040_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1708410654["MiniDFA4 {1}"]
DFA4_153364517_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1269687594["MiniDFA5 {1}"]
DFA5_208189421_5[\"DFA5 {1}"/]
end
MiniDFA0_823784357 -->|"i"|MiniDFA1_587361178
MiniDFA1_587361178 -->|"v"|MiniDFA2_1099087955
MiniDFA2_1099087955 -->|"e"|MiniDFA3_197952134
MiniDFA3_197952134 -->|"c"|MiniDFA4_1708410654
MiniDFA4_1708410654 -->|"3"|MiniDFA5_1269687594
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
MiniDFA0_823784357(["MiniDFA0 {1}"])
MiniDFA1_587361178(["MiniDFA1 {1}"])
MiniDFA2_1099087955(["MiniDFA2 {1}"])
MiniDFA3_197952134(["MiniDFA3 {1}"])
MiniDFA4_1708410654(["MiniDFA4 {1}"])
MiniDFA5_1269687594[\"MiniDFA5 {1}"/]
MiniDFA0_823784357 -->|"i"|MiniDFA1_587361178
MiniDFA1_587361178 -->|"v"|MiniDFA2_1099087955
MiniDFA2_1099087955 -->|"e"|MiniDFA3_197952134
MiniDFA3_197952134 -->|"c"|MiniDFA4_1708410654
MiniDFA4_1708410654 -->|"3"|MiniDFA5_1269687594
```
-------------------------------
