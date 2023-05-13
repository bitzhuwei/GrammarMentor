# 'double'

pattern: `double`

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
eNFA76_12_27627990[["εNFA76-12 regex start"]]
eNFA76_0_47325326[["εNFA76-0 char{1, 1}"]]
eNFA76_1_23274750[["εNFA76-1 char[1]"]]
eNFA76_2_8146160[["εNFA76-2 char{1, 1}"]]
eNFA76_3_6206582[["εNFA76-3 char[1]"]]
eNFA76_4_55859239[["εNFA76-4 char{1, 1}"]]
eNFA76_5_32971110[["εNFA76-5 char[1]"]]
eNFA76_6_28304539[["εNFA76-6 char{1, 1}"]]
eNFA76_7_53414263[["εNFA76-7 char[1]"]]
eNFA76_8_10966323[["εNFA76-8 char{1, 1}"]]
eNFA76_9_31588048[["εNFA76-9 char[1]"]]
eNFA76_10_15856984[["εNFA76-10 char{1, 1}"]]
eNFA76_11_8495130[["εNFA76-11 char[1]"]]
eNFA76_13_9347313[["εNFA76-13 regex end"]]
eNFA76_14_17016957[["εNFA76-14 post-regex start"]]
eNFA76_15_18934887[\"εNFA76-15 post-regex end"/]
eNFA76_12_27627990 -.->|"ε"|eNFA76_0_47325326
eNFA76_0_47325326 -->|"d"|eNFA76_1_23274750
eNFA76_1_23274750 -.->|"ε"|eNFA76_2_8146160
eNFA76_2_8146160 -->|"o"|eNFA76_3_6206582
eNFA76_3_6206582 -.->|"ε"|eNFA76_4_55859239
eNFA76_4_55859239 -->|"u"|eNFA76_5_32971110
eNFA76_5_32971110 -.->|"ε"|eNFA76_6_28304539
eNFA76_6_28304539 -->|"b"|eNFA76_7_53414263
eNFA76_7_53414263 -.->|"ε"|eNFA76_8_10966323
eNFA76_8_10966323 -->|"l"|eNFA76_9_31588048
eNFA76_9_31588048 -.->|"ε"|eNFA76_10_15856984
eNFA76_10_15856984 -->|"e"|eNFA76_11_8495130
eNFA76_11_8495130 -.->|"ε"|eNFA76_13_9347313
eNFA76_13_9347313 -.->|"ε"|eNFA76_14_17016957
eNFA76_14_17016957 -.->|"ε"|eNFA76_15_18934887
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
eNFA76_12_36196256[["εNFA76-12 regex start"]]
eNFA76_0_57330849[["εNFA76-0 char{1, 1}"]]
eNFA76_1_46215595[["εNFA76-1 char[1]"]]
eNFA76_2_13287175[["εNFA76-2 char{1, 1}"]]
eNFA76_3_52475719[["εNFA76-3 char[1]"]]
eNFA76_4_2519427[["εNFA76-4 char{1, 1}"]]
eNFA76_5_22674843[["εNFA76-5 char[1]"]]
eNFA76_6_2747002[["εNFA76-6 char{1, 1}"]]
eNFA76_7_24723024[["εNFA76-7 char[1]"]]
eNFA76_8_21180630[["εNFA76-8 char{1, 1}"]]
eNFA76_9_56407950[["εNFA76-9 char[1]"]]
eNFA76_10_37909503[["εNFA76-10 char{1, 1}"]]
eNFA76_11_5641212[\"εNFA76-11 char[1]"/]
eNFA76_13_50770908[\"εNFA76-13 regex end"/]
eNFA76_14_54284994[\"εNFA76-14 post-regex start"/]
eNFA76_15_18802902[\"εNFA76-15 post-regex end"/]
eNFA76_12_36196256 -.->|"ε"|eNFA76_0_57330849
eNFA76_12_36196256 -->|"d"|eNFA76_1_46215595
eNFA76_0_57330849 -->|"d"|eNFA76_1_46215595
eNFA76_1_46215595 -.->|"ε"|eNFA76_2_13287175
eNFA76_1_46215595 -->|"o"|eNFA76_3_52475719
eNFA76_2_13287175 -->|"o"|eNFA76_3_52475719
eNFA76_3_52475719 -.->|"ε"|eNFA76_4_2519427
eNFA76_3_52475719 -->|"u"|eNFA76_5_22674843
eNFA76_4_2519427 -->|"u"|eNFA76_5_22674843
eNFA76_5_22674843 -.->|"ε"|eNFA76_6_2747002
eNFA76_5_22674843 -->|"b"|eNFA76_7_24723024
eNFA76_6_2747002 -->|"b"|eNFA76_7_24723024
eNFA76_7_24723024 -.->|"ε"|eNFA76_8_21180630
eNFA76_7_24723024 -->|"l"|eNFA76_9_56407950
eNFA76_8_21180630 -->|"l"|eNFA76_9_56407950
eNFA76_9_56407950 -.->|"ε"|eNFA76_10_37909503
eNFA76_9_56407950 -->|"e"|eNFA76_11_5641212
eNFA76_10_37909503 -->|"e"|eNFA76_11_5641212
eNFA76_11_5641212 -.->|"ε"|eNFA76_13_50770908
eNFA76_11_5641212 -.->|"ε"|eNFA76_14_54284994
eNFA76_11_5641212 -.->|"ε"|eNFA76_15_18802902
eNFA76_13_50770908 -.->|"ε"|eNFA76_14_54284994
eNFA76_13_50770908 -.->|"ε"|eNFA76_15_18802902
eNFA76_14_54284994 -.->|"ε"|eNFA76_15_18802902
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
NFA76_12_35008393("NFA76-12 regex start")
NFA76_1_46640084("NFA76-1 char[1]")
NFA76_3_17107576("NFA76-3 char[1]")
NFA76_5_19750463("NFA76-5 char[1]")
NFA76_7_43536440("NFA76-7 char[1]")
NFA76_9_56283646("NFA76-9 char[1]")
NFA76_11_36790769[\"NFA76-11 char[1]"/]
NFA76_12_35008393 -->|"d"|NFA76_1_46640084
NFA76_1_46640084 -->|"o"|NFA76_3_17107576
NFA76_3_17107576 -->|"u"|NFA76_5_19750463
NFA76_5_19750463 -->|"b"|NFA76_7_43536440
NFA76_7_43536440 -->|"l"|NFA76_9_56283646
NFA76_9_56283646 -->|"e"|NFA76_11_36790769
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
subgraph DFA0_1596117819["DFA0 regex start"]
NFA76_12_35008393_0("NFA76-12 regex start")
end
subgraph DFA1_1860347911["DFA1 {1}"]
NFA76_1_46640084_1("NFA76-1 char[1]")
end
subgraph DFA2_-1676542019["DFA2 {1}"]
NFA76_3_17107576_2("NFA76-3 char[1]")
end
subgraph DFA3_-1466206134["DFA3 {1}"]
NFA76_5_19750463_3("NFA76-5 char[1]")
end
subgraph DFA4_-2026645308["DFA4 {1}"]
NFA76_7_43536440_4("NFA76-7 char[1]")
end
subgraph DFA5_-1830545077["DFA5 {1}"]
NFA76_9_56283646_5("NFA76-9 char[1]")
end
subgraph DFA6_-889487309["DFA6 {1}"]
NFA76_11_36790769_6[\"NFA76-11 char[1]"/]
end
DFA0_1596117819 -->|"d"|DFA1_1860347911
DFA1_1860347911 -->|"o"|DFA2_-1676542019
DFA2_-1676542019 -->|"u"|DFA3_-1466206134
DFA3_-1466206134 -->|"b"|DFA4_-2026645308
DFA4_-2026645308 -->|"l"|DFA5_-1830545077
DFA5_-1830545077 -->|"e"|DFA6_-889487309
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
DFA0_1596117819{{"DFA0 regex start"}}
DFA1_1860347911{{"DFA1 {1}"}}
DFA2_-1676542019{{"DFA2 {1}"}}
DFA3_-1466206134{{"DFA3 {1}"}}
DFA4_-2026645308{{"DFA4 {1}"}}
DFA5_-1830545077{{"DFA5 {1}"}}
DFA6_-889487309[\"DFA6 {1}"/]
DFA0_1596117819 -->|"d"|DFA1_1860347911
DFA1_1860347911 -->|"o"|DFA2_-1676542019
DFA2_-1676542019 -->|"u"|DFA3_-1466206134
DFA3_-1466206134 -->|"b"|DFA4_-2026645308
DFA4_-2026645308 -->|"l"|DFA5_-1830545077
DFA5_-1830545077 -->|"e"|DFA6_-889487309
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
subgraph MiniDFA0_-1428404118["MiniDFA0 {1}"]
DFA0_1596117819_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_456799491["MiniDFA1 {1}"]
DFA1_1860347911_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1203617768["MiniDFA2 {1}"]
DFA2_-1676542019_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-212575215["MiniDFA3 {1}"]
DFA3_-1466206134_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_441404498["MiniDFA4 {1}"]
DFA4_-2026645308_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1004217219["MiniDFA5 {1}"]
DFA5_-1830545077_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_286770951["MiniDFA6 {1}"]
DFA6_-889487309_6[\"DFA6 {1}"/]
end
MiniDFA0_-1428404118 -->|"d"|MiniDFA1_456799491
MiniDFA1_456799491 -->|"o"|MiniDFA2_1203617768
MiniDFA2_1203617768 -->|"u"|MiniDFA3_-212575215
MiniDFA3_-212575215 -->|"b"|MiniDFA4_441404498
MiniDFA4_441404498 -->|"l"|MiniDFA5_1004217219
MiniDFA5_1004217219 -->|"e"|MiniDFA6_286770951
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
MiniDFA0_-1428404118(["MiniDFA0 {1}"])
MiniDFA1_456799491(["MiniDFA1 {1}"])
MiniDFA2_1203617768(["MiniDFA2 {1}"])
MiniDFA3_-212575215(["MiniDFA3 {1}"])
MiniDFA4_441404498(["MiniDFA4 {1}"])
MiniDFA5_1004217219(["MiniDFA5 {1}"])
MiniDFA6_286770951[\"MiniDFA6 {1}"/]
MiniDFA0_-1428404118 -->|"d"|MiniDFA1_456799491
MiniDFA1_456799491 -->|"o"|MiniDFA2_1203617768
MiniDFA2_1203617768 -->|"u"|MiniDFA3_-212575215
MiniDFA3_-212575215 -->|"b"|MiniDFA4_441404498
MiniDFA4_441404498 -->|"l"|MiniDFA5_1004217219
MiniDFA5_1004217219 -->|"e"|MiniDFA6_286770951
```
-------------------------------
