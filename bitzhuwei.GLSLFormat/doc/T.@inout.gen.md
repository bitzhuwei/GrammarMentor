# 'inout'

pattern: `inout`

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
eNFA59_10_21044820[["εNFA59-10 regex start"]]
eNFA59_0_55185655[["εNFA59-0 char{1, 1}"]]
eNFA59_1_26908851[["εNFA59-1 char[1]"]]
eNFA59_2_40853074[["εNFA59-2 char{1, 1}"]]
eNFA59_3_32133347[["εNFA59-3 char[1]"]]
eNFA59_4_20764673[["εNFA59-4 char{1, 1}"]]
eNFA59_5_52664332[["εNFA59-5 char[1]"]]
eNFA59_6_4216941[["εNFA59-6 char{1, 1}"]]
eNFA59_7_37952469[["εNFA59-7 char[1]"]]
eNFA59_8_6027901[["εNFA59-8 char{1, 1}"]]
eNFA59_9_54251110[["εNFA59-9 char[1]"]]
eNFA59_11_18497945[["εNFA59-11 regex end"]]
eNFA59_12_32263784[["εNFA59-12 post-regex start"]]
eNFA59_13_21938602[\"εNFA59-13 post-regex end"/]
eNFA59_10_21044820 -.->|"ε"|eNFA59_0_55185655
eNFA59_0_55185655 -->|"i"|eNFA59_1_26908851
eNFA59_1_26908851 -.->|"ε"|eNFA59_2_40853074
eNFA59_2_40853074 -->|"n"|eNFA59_3_32133347
eNFA59_3_32133347 -.->|"ε"|eNFA59_4_20764673
eNFA59_4_20764673 -->|"o"|eNFA59_5_52664332
eNFA59_5_52664332 -.->|"ε"|eNFA59_6_4216941
eNFA59_6_4216941 -->|"u"|eNFA59_7_37952469
eNFA59_7_37952469 -.->|"ε"|eNFA59_8_6027901
eNFA59_8_6027901 -->|"t"|eNFA59_9_54251110
eNFA59_9_54251110 -.->|"ε"|eNFA59_11_18497945
eNFA59_11_18497945 -.->|"ε"|eNFA59_12_32263784
eNFA59_12_32263784 -.->|"ε"|eNFA59_13_21938602
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
eNFA59_10_63229698[["εNFA59-10 regex start"]]
eNFA59_0_32196376[["εNFA59-0 char{1, 1}"]]
eNFA59_1_21331933[["εNFA59-1 char[1]"]]
eNFA59_2_57769674[["εNFA59-2 char{1, 1}"]]
eNFA59_3_50165025[["εNFA59-3 char[1]"]]
eNFA59_4_48832041[["εNFA59-4 char{1, 1}"]]
eNFA59_5_36835188[["εNFA59-5 char[1]"]]
eNFA59_6_63081244[["εNFA59-6 char{1, 1}"]]
eNFA59_7_30860289[["εNFA59-7 char[1]"]]
eNFA59_8_9307148[["εNFA59-8 char{1, 1}"]]
eNFA59_9_16655470[\"εNFA59-9 char[1]"/]
eNFA59_11_15681504[\"εNFA59-11 regex end"/]
eNFA59_12_6915811[\"εNFA59-12 post-regex start"/]
eNFA59_13_62242305[\"εNFA59-13 post-regex end"/]
eNFA59_10_63229698 -.->|"ε"|eNFA59_0_32196376
eNFA59_10_63229698 -->|"i"|eNFA59_1_21331933
eNFA59_0_32196376 -->|"i"|eNFA59_1_21331933
eNFA59_1_21331933 -.->|"ε"|eNFA59_2_57769674
eNFA59_1_21331933 -->|"n"|eNFA59_3_50165025
eNFA59_2_57769674 -->|"n"|eNFA59_3_50165025
eNFA59_3_50165025 -.->|"ε"|eNFA59_4_48832041
eNFA59_3_50165025 -->|"o"|eNFA59_5_36835188
eNFA59_4_48832041 -->|"o"|eNFA59_5_36835188
eNFA59_5_36835188 -.->|"ε"|eNFA59_6_63081244
eNFA59_5_36835188 -->|"u"|eNFA59_7_30860289
eNFA59_6_63081244 -->|"u"|eNFA59_7_30860289
eNFA59_7_30860289 -.->|"ε"|eNFA59_8_9307148
eNFA59_7_30860289 -->|"t"|eNFA59_9_16655470
eNFA59_8_9307148 -->|"t"|eNFA59_9_16655470
eNFA59_9_16655470 -.->|"ε"|eNFA59_11_15681504
eNFA59_9_16655470 -.->|"ε"|eNFA59_12_6915811
eNFA59_9_16655470 -.->|"ε"|eNFA59_13_62242305
eNFA59_11_15681504 -.->|"ε"|eNFA59_12_6915811
eNFA59_11_15681504 -.->|"ε"|eNFA59_13_62242305
eNFA59_12_6915811 -.->|"ε"|eNFA59_13_62242305
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
NFA59_10_23309833("NFA59-10 regex start")
NFA59_1_8461910("NFA59-1 char[1]")
NFA59_3_9048327("NFA59-3 char[1]")
NFA59_5_14326087("NFA59-5 char[1]")
NFA59_7_61825926("NFA59-7 char[1]")
NFA59_9_19562430[\"NFA59-9 char[1]"/]
NFA59_10_23309833 -->|"i"|NFA59_1_8461910
NFA59_1_8461910 -->|"n"|NFA59_3_9048327
NFA59_3_9048327 -->|"o"|NFA59_5_14326087
NFA59_5_14326087 -->|"u"|NFA59_7_61825926
NFA59_7_61825926 -->|"t"|NFA59_9_19562430
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
subgraph DFA0_-536009657["DFA0 regex start"]
NFA59_10_23309833_0("NFA59-10 regex start")
end
subgraph DFA1_-352181487["DFA1 {1}"]
NFA59_1_8461910_1("NFA59-1 char[1]")
end
subgraph DFA2_-540233048["DFA2 {1}"]
NFA59_3_9048327_2("NFA59-3 char[1]")
end
subgraph DFA3_-633324889["DFA3 {1}"]
NFA59_5_14326087_3("NFA59-5 char[1]")
end
subgraph DFA4_-584155396["DFA4 {1}"]
NFA59_7_61825926_4("NFA59-7 char[1]")
end
subgraph DFA5_-365862402["DFA5 {1}"]
NFA59_9_19562430_5[\"NFA59-9 char[1]"/]
end
DFA0_-536009657 -->|"i"|DFA1_-352181487
DFA1_-352181487 -->|"n"|DFA2_-540233048
DFA2_-540233048 -->|"o"|DFA3_-633324889
DFA3_-633324889 -->|"u"|DFA4_-584155396
DFA4_-584155396 -->|"t"|DFA5_-365862402
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
DFA0_-536009657{{"DFA0 regex start"}}
DFA1_-352181487{{"DFA1 {1}"}}
DFA2_-540233048{{"DFA2 {1}"}}
DFA3_-633324889{{"DFA3 {1}"}}
DFA4_-584155396{{"DFA4 {1}"}}
DFA5_-365862402[\"DFA5 {1}"/]
DFA0_-536009657 -->|"i"|DFA1_-352181487
DFA1_-352181487 -->|"n"|DFA2_-540233048
DFA2_-540233048 -->|"o"|DFA3_-633324889
DFA3_-633324889 -->|"u"|DFA4_-584155396
DFA4_-584155396 -->|"t"|DFA5_-365862402
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
subgraph MiniDFA0_216364767["MiniDFA0 {1}"]
DFA0_-536009657_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1602389187["MiniDFA1 {1}"]
DFA1_-352181487_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_905842667["MiniDFA2 {1}"]
DFA2_-540233048_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1509373957["MiniDFA3 {1}"]
DFA3_-633324889_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_627270481["MiniDFA4 {1}"]
DFA4_-584155396_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1480372124["MiniDFA5 {1}"]
DFA5_-365862402_5[\"DFA5 {1}"/]
end
MiniDFA0_216364767 -->|"i"|MiniDFA1_-1602389187
MiniDFA1_-1602389187 -->|"n"|MiniDFA2_905842667
MiniDFA2_905842667 -->|"o"|MiniDFA3_-1509373957
MiniDFA3_-1509373957 -->|"u"|MiniDFA4_627270481
MiniDFA4_627270481 -->|"t"|MiniDFA5_-1480372124
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
MiniDFA0_216364767(["MiniDFA0 {1}"])
MiniDFA1_-1602389187(["MiniDFA1 {1}"])
MiniDFA2_905842667(["MiniDFA2 {1}"])
MiniDFA3_-1509373957(["MiniDFA3 {1}"])
MiniDFA4_627270481(["MiniDFA4 {1}"])
MiniDFA5_-1480372124[\"MiniDFA5 {1}"/]
MiniDFA0_216364767 -->|"i"|MiniDFA1_-1602389187
MiniDFA1_-1602389187 -->|"n"|MiniDFA2_905842667
MiniDFA2_905842667 -->|"o"|MiniDFA3_-1509373957
MiniDFA3_-1509373957 -->|"u"|MiniDFA4_627270481
MiniDFA4_627270481 -->|"t"|MiniDFA5_-1480372124
```
-------------------------------
