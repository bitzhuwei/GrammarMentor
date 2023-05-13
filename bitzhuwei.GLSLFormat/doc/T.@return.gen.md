# 'return'

pattern: `return`

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
eNFA207_12_20553842[["εNFA207-12 regex start"]]
eNFA207_0_50766852[["εNFA207-0 char{1, 1}"]]
eNFA207_1_54248487[["εNFA207-1 char[1]"]]
eNFA207_2_18474341[["εNFA207-2 char{1, 1}"]]
eNFA207_3_32051341[["εNFA207-3 char[1]"]]
eNFA207_4_20026618[["εNFA207-4 char{1, 1}"]]
eNFA207_5_46021835[["εNFA207-5 char[1]"]]
eNFA207_6_11543339[["εNFA207-6 char{1, 1}"]]
eNFA207_7_36781194[["εNFA207-7 char[1]"]]
eNFA207_8_62595298[["εNFA207-8 char{1, 1}"]]
eNFA207_9_26486770[["εNFA207-9 char[1]"]]
eNFA207_10_37054340[["εNFA207-10 char{1, 1}"]]
eNFA207_11_65053610[["εNFA207-11 char[1]"]]
eNFA207_13_48611579[["εNFA207-13 regex end"]]
eNFA207_14_34851034[["εNFA207-14 post-regex start"]]
eNFA207_15_45223855[\"εNFA207-15 post-regex end"/]
eNFA207_12_20553842 -.->|"ε"|eNFA207_0_50766852
eNFA207_0_50766852 -->|"r"|eNFA207_1_54248487
eNFA207_1_54248487 -.->|"ε"|eNFA207_2_18474341
eNFA207_2_18474341 -->|"e"|eNFA207_3_32051341
eNFA207_3_32051341 -.->|"ε"|eNFA207_4_20026618
eNFA207_4_20026618 -->|"t"|eNFA207_5_46021835
eNFA207_5_46021835 -.->|"ε"|eNFA207_6_11543339
eNFA207_6_11543339 -->|"u"|eNFA207_7_36781194
eNFA207_7_36781194 -.->|"ε"|eNFA207_8_62595298
eNFA207_8_62595298 -->|"r"|eNFA207_9_26486770
eNFA207_9_26486770 -.->|"ε"|eNFA207_10_37054340
eNFA207_10_37054340 -->|"n"|eNFA207_11_65053610
eNFA207_11_65053610 -.->|"ε"|eNFA207_13_48611579
eNFA207_13_48611579 -.->|"ε"|eNFA207_14_34851034
eNFA207_14_34851034 -.->|"ε"|eNFA207_15_45223855
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
eNFA207_12_4361515[["εNFA207-12 regex start"]]
eNFA207_0_39253639[["εNFA207-0 char{1, 1}"]]
eNFA207_1_17738436[["εNFA207-1 char[1]"]]
eNFA207_2_25428204[["εNFA207-2 char{1, 1}"]]
eNFA207_3_27527246[["εNFA207-3 char[1]"]]
eNFA207_4_46418629[["εNFA207-4 char{1, 1}"]]
eNFA207_5_15114481[["εNFA207-5 char[1]"]]
eNFA207_6_1812603[["εNFA207-6 char{1, 1}"]]
eNFA207_7_16313428[["εNFA207-7 char[1]"]]
eNFA207_8_12603125[["εNFA207-8 char{1, 1}"]]
eNFA207_9_46319263[["εNFA207-9 char[1]"]]
eNFA207_10_14220187[["εNFA207-10 char{1, 1}"]]
eNFA207_11_60872827[\"εNFA207-11 char[1]"/]
eNFA207_13_10984535[\"εNFA207-13 regex end"/]
eNFA207_14_31751951[\"εNFA207-14 post-regex start"/]
eNFA207_15_17332110[\"εNFA207-15 post-regex end"/]
eNFA207_12_4361515 -.->|"ε"|eNFA207_0_39253639
eNFA207_12_4361515 -->|"r"|eNFA207_1_17738436
eNFA207_0_39253639 -->|"r"|eNFA207_1_17738436
eNFA207_1_17738436 -.->|"ε"|eNFA207_2_25428204
eNFA207_1_17738436 -->|"e"|eNFA207_3_27527246
eNFA207_2_25428204 -->|"e"|eNFA207_3_27527246
eNFA207_3_27527246 -.->|"ε"|eNFA207_4_46418629
eNFA207_3_27527246 -->|"t"|eNFA207_5_15114481
eNFA207_4_46418629 -->|"t"|eNFA207_5_15114481
eNFA207_5_15114481 -.->|"ε"|eNFA207_6_1812603
eNFA207_5_15114481 -->|"u"|eNFA207_7_16313428
eNFA207_6_1812603 -->|"u"|eNFA207_7_16313428
eNFA207_7_16313428 -.->|"ε"|eNFA207_8_12603125
eNFA207_7_16313428 -->|"r"|eNFA207_9_46319263
eNFA207_8_12603125 -->|"r"|eNFA207_9_46319263
eNFA207_9_46319263 -.->|"ε"|eNFA207_10_14220187
eNFA207_9_46319263 -->|"n"|eNFA207_11_60872827
eNFA207_10_14220187 -->|"n"|eNFA207_11_60872827
eNFA207_11_60872827 -.->|"ε"|eNFA207_13_10984535
eNFA207_11_60872827 -.->|"ε"|eNFA207_14_31751951
eNFA207_11_60872827 -.->|"ε"|eNFA207_15_17332110
eNFA207_13_10984535 -.->|"ε"|eNFA207_14_31751951
eNFA207_13_10984535 -.->|"ε"|eNFA207_15_17332110
eNFA207_14_31751951 -.->|"ε"|eNFA207_15_17332110
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
NFA207_12_21771268("NFA207-12 regex start")
NFA207_1_61723690("NFA207-1 char[1]")
NFA207_3_18642306("NFA207-3 char[1]")
NFA207_5_33563027("NFA207-5 char[1]")
NFA207_7_33631792("NFA207-7 char[1]")
NFA207_9_34250672("NFA207-9 char[1]")
NFA207_11_39820598[\"NFA207-11 char[1]"/]
NFA207_12_21771268 -->|"r"|NFA207_1_61723690
NFA207_1_61723690 -->|"e"|NFA207_3_18642306
NFA207_3_18642306 -->|"t"|NFA207_5_33563027
NFA207_5_33563027 -->|"u"|NFA207_7_33631792
NFA207_7_33631792 -->|"r"|NFA207_9_34250672
NFA207_9_34250672 -->|"n"|NFA207_11_39820598
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
subgraph DFA0_687555739["DFA0 regex start"]
NFA207_12_21771268_0("NFA207-12 regex start")
end
subgraph DFA1_369469967["DFA1 {1}"]
NFA207_1_61723690_1("NFA207-1 char[1]")
end
subgraph DFA2_-1084681207["DFA2 {1}"]
NFA207_3_18642306_2("NFA207-3 char[1]")
end
subgraph DFA3_-877141314["DFA3 {1}"]
NFA207_5_33563027_3("NFA207-5 char[1]")
end
subgraph DFA4_-1108399748["DFA4 {1}"]
NFA207_7_33631792_4("NFA207-7 char[1]")
end
subgraph DFA5_-1654818653["DFA5 {1}"]
NFA207_9_34250672_5("NFA207-9 char[1]")
end
subgraph DFA6_-334497696["DFA6 {1}"]
NFA207_11_39820598_6[\"NFA207-11 char[1]"/]
end
DFA0_687555739 -->|"r"|DFA1_369469967
DFA1_369469967 -->|"e"|DFA2_-1084681207
DFA2_-1084681207 -->|"t"|DFA3_-877141314
DFA3_-877141314 -->|"u"|DFA4_-1108399748
DFA4_-1108399748 -->|"r"|DFA5_-1654818653
DFA5_-1654818653 -->|"n"|DFA6_-334497696
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
DFA0_687555739{{"DFA0 regex start"}}
DFA1_369469967{{"DFA1 {1}"}}
DFA2_-1084681207{{"DFA2 {1}"}}
DFA3_-877141314{{"DFA3 {1}"}}
DFA4_-1108399748{{"DFA4 {1}"}}
DFA5_-1654818653{{"DFA5 {1}"}}
DFA6_-334497696[\"DFA6 {1}"/]
DFA0_687555739 -->|"r"|DFA1_369469967
DFA1_369469967 -->|"e"|DFA2_-1084681207
DFA2_-1084681207 -->|"t"|DFA3_-877141314
DFA3_-877141314 -->|"u"|DFA4_-1108399748
DFA4_-1108399748 -->|"r"|DFA5_-1654818653
DFA5_-1654818653 -->|"n"|DFA6_-334497696
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
subgraph MiniDFA0_1245795323["MiniDFA0 {1}"]
DFA0_687555739_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_-548462750["MiniDFA2 {1}"]
DFA1_369469967_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_983460914["MiniDFA3 {1}"]
DFA2_-1084681207_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-1111118537["MiniDFA4 {1}"]
DFA3_-877141314_3{{"DFA3 {1}"}}
end
subgraph MiniDFA1_2024634092["MiniDFA1 {1}"]
DFA4_-1108399748_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-792743074["MiniDFA5 {1}"]
DFA5_-1654818653_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-75885693["MiniDFA6 {1}"]
DFA6_-334497696_6[\"DFA6 {1}"/]
end
MiniDFA0_1245795323 -->|"r"|MiniDFA2_-548462750
MiniDFA2_-548462750 -->|"e"|MiniDFA3_983460914
MiniDFA3_983460914 -->|"t"|MiniDFA4_-1111118537
MiniDFA4_-1111118537 -->|"u"|MiniDFA1_2024634092
MiniDFA1_2024634092 -->|"r"|MiniDFA5_-792743074
MiniDFA5_-792743074 -->|"n"|MiniDFA6_-75885693
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
MiniDFA0_1245795323(["MiniDFA0 {1}"])
MiniDFA2_-548462750(["MiniDFA2 {1}"])
MiniDFA3_983460914(["MiniDFA3 {1}"])
MiniDFA4_-1111118537(["MiniDFA4 {1}"])
MiniDFA1_2024634092(["MiniDFA1 {1}"])
MiniDFA5_-792743074(["MiniDFA5 {1}"])
MiniDFA6_-75885693[\"MiniDFA6 {1}"/]
MiniDFA0_1245795323 -->|"r"|MiniDFA2_-548462750
MiniDFA2_-548462750 -->|"e"|MiniDFA3_983460914
MiniDFA3_983460914 -->|"t"|MiniDFA4_-1111118537
MiniDFA4_-1111118537 -->|"u"|MiniDFA1_2024634092
MiniDFA1_2024634092 -->|"r"|MiniDFA5_-792743074
MiniDFA5_-792743074 -->|"n"|MiniDFA6_-75885693
```
-------------------------------
