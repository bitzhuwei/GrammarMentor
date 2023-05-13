# 'ivec4'

pattern: `ivec4`

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
eNFA91_10_12358762[["εNFA91-10 regex start"]]
eNFA91_0_44120000[["εNFA91-0 char{1, 1}"]]
eNFA91_1_61535683[["εNFA91-1 char[1]"]]
eNFA91_2_16950236[["εNFA91-2 char{1, 1}"]]
eNFA91_3_18334396[["εNFA91-3 char[1]"]]
eNFA91_4_30791836[["εNFA91-4 char{1, 1}"]]
eNFA91_5_8691069[["εNFA91-5 char[1]"]]
eNFA91_6_11110760[["εNFA91-6 char{1, 1}"]]
eNFA91_7_32887983[["εNFA91-7 char[1]"]]
eNFA91_8_27556393[["εNFA91-8 char{1, 1}"]]
eNFA91_9_46680953[["εNFA91-9 char[1]"]]
eNFA91_11_17475399[["εNFA91-11 regex end"]]
eNFA91_12_23060868[["εNFA91-12 post-regex start"]]
eNFA91_13_6221225[\"εNFA91-13 post-regex end"/]
eNFA91_10_12358762 -.->|"ε"|eNFA91_0_44120000
eNFA91_0_44120000 -->|"i"|eNFA91_1_61535683
eNFA91_1_61535683 -.->|"ε"|eNFA91_2_16950236
eNFA91_2_16950236 -->|"v"|eNFA91_3_18334396
eNFA91_3_18334396 -.->|"ε"|eNFA91_4_30791836
eNFA91_4_30791836 -->|"e"|eNFA91_5_8691069
eNFA91_5_8691069 -.->|"ε"|eNFA91_6_11110760
eNFA91_6_11110760 -->|"c"|eNFA91_7_32887983
eNFA91_7_32887983 -.->|"ε"|eNFA91_8_27556393
eNFA91_8_27556393 -->|"4"|eNFA91_9_46680953
eNFA91_9_46680953 -.->|"ε"|eNFA91_11_17475399
eNFA91_11_17475399 -.->|"ε"|eNFA91_12_23060868
eNFA91_12_23060868 -.->|"ε"|eNFA91_13_6221225
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
eNFA91_10_55991032[["εNFA91-10 regex start"]]
eNFA91_0_34157240[["εNFA91-0 char{1, 1}"]]
eNFA91_1_38979707[["εNFA91-1 char[1]"]]
eNFA91_2_15273051[["εNFA91-2 char{1, 1}"]]
eNFA91_3_3239736[["εNFA91-3 char[1]"]]
eNFA91_4_29157627[["εNFA91-4 char{1, 1}"]]
eNFA91_5_61092053[["εNFA91-5 char[1]"]]
eNFA91_6_12957567[["εNFA91-6 char{1, 1}"]]
eNFA91_7_49509242[["εNFA91-7 char[1]"]]
eNFA91_8_42930000[["εNFA91-8 char{1, 1}"]]
eNFA91_9_50825680[\"εNFA91-9 char[1]"/]
eNFA91_11_54777941[\"εNFA91-11 regex end"/]
eNFA91_12_23239422[\"εNFA91-12 post-regex start"/]
eNFA91_13_7828214[\"εNFA91-13 post-regex end"/]
eNFA91_10_55991032 -.->|"ε"|eNFA91_0_34157240
eNFA91_10_55991032 -->|"i"|eNFA91_1_38979707
eNFA91_0_34157240 -->|"i"|eNFA91_1_38979707
eNFA91_1_38979707 -.->|"ε"|eNFA91_2_15273051
eNFA91_1_38979707 -->|"v"|eNFA91_3_3239736
eNFA91_2_15273051 -->|"v"|eNFA91_3_3239736
eNFA91_3_3239736 -.->|"ε"|eNFA91_4_29157627
eNFA91_3_3239736 -->|"e"|eNFA91_5_61092053
eNFA91_4_29157627 -->|"e"|eNFA91_5_61092053
eNFA91_5_61092053 -.->|"ε"|eNFA91_6_12957567
eNFA91_5_61092053 -->|"c"|eNFA91_7_49509242
eNFA91_6_12957567 -->|"c"|eNFA91_7_49509242
eNFA91_7_49509242 -.->|"ε"|eNFA91_8_42930000
eNFA91_7_49509242 -->|"4"|eNFA91_9_50825680
eNFA91_8_42930000 -->|"4"|eNFA91_9_50825680
eNFA91_9_50825680 -.->|"ε"|eNFA91_11_54777941
eNFA91_9_50825680 -.->|"ε"|eNFA91_12_23239422
eNFA91_9_50825680 -.->|"ε"|eNFA91_13_7828214
eNFA91_11_54777941 -.->|"ε"|eNFA91_12_23239422
eNFA91_11_54777941 -.->|"ε"|eNFA91_13_7828214
eNFA91_12_23239422 -.->|"ε"|eNFA91_13_7828214
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
NFA91_10_3345069("NFA91-10 regex start")
NFA91_1_30105629("NFA91-1 char[1]")
NFA91_3_2515205("NFA91-3 char[1]")
NFA91_5_22636847("NFA91-5 char[1]")
NFA91_7_2405037("NFA91-7 char[1]")
NFA91_9_21645334[\"NFA91-9 char[1]"/]
NFA91_10_3345069 -->|"i"|NFA91_1_30105629
NFA91_1_30105629 -->|"v"|NFA91_3_2515205
NFA91_3_2515205 -->|"e"|NFA91_5_22636847
NFA91_5_22636847 -->|"c"|NFA91_7_2405037
NFA91_7_2405037 -->|"4"|NFA91_9_21645334
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
subgraph DFA0_1295575412["DFA0 regex start"]
NFA91_10_3345069_0("NFA91-10 regex start")
end
subgraph DFA1_1597511590["DFA1 {1}"]
NFA91_1_30105629_1("NFA91-1 char[1]")
end
subgraph DFA2_-1965770535["DFA2 {1}"]
NFA91_3_2515205_2("NFA91-3 char[1]")
end
subgraph DFA3_-1631392255["DFA3 {1}"]
NFA91_5_22636847_3("NFA91-5 char[1]")
end
subgraph DFA4_-1673022720["DFA4 {1}"]
NFA91_7_2405037_4("NFA91-7 char[1]")
end
subgraph DFA5_-1849026294["DFA5 {1}"]
NFA91_9_21645334_5[\"NFA91-9 char[1]"/]
end
DFA0_1295575412 -->|"i"|DFA1_1597511590
DFA1_1597511590 -->|"v"|DFA2_-1965770535
DFA2_-1965770535 -->|"e"|DFA3_-1631392255
DFA3_-1631392255 -->|"c"|DFA4_-1673022720
DFA4_-1673022720 -->|"4"|DFA5_-1849026294
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
DFA0_1295575412{{"DFA0 regex start"}}
DFA1_1597511590{{"DFA1 {1}"}}
DFA2_-1965770535{{"DFA2 {1}"}}
DFA3_-1631392255{{"DFA3 {1}"}}
DFA4_-1673022720{{"DFA4 {1}"}}
DFA5_-1849026294[\"DFA5 {1}"/]
DFA0_1295575412 -->|"i"|DFA1_1597511590
DFA1_1597511590 -->|"v"|DFA2_-1965770535
DFA2_-1965770535 -->|"e"|DFA3_-1631392255
DFA3_-1631392255 -->|"c"|DFA4_-1673022720
DFA4_-1673022720 -->|"4"|DFA5_-1849026294
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
subgraph MiniDFA0_1105868620["MiniDFA0 {1}"]
DFA0_1295575412_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_52669570["MiniDFA1 {1}"]
DFA1_1597511590_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1881359384["MiniDFA2 {1}"]
DFA2_-1965770535_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-301753619["MiniDFA3 {1}"]
DFA3_-1631392255_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-141541575["MiniDFA4 {1}"]
DFA4_-1673022720_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_224012471["MiniDFA5 {1}"]
DFA5_-1849026294_5[\"DFA5 {1}"/]
end
MiniDFA0_1105868620 -->|"i"|MiniDFA1_52669570
MiniDFA1_52669570 -->|"v"|MiniDFA2_1881359384
MiniDFA2_1881359384 -->|"e"|MiniDFA3_-301753619
MiniDFA3_-301753619 -->|"c"|MiniDFA4_-141541575
MiniDFA4_-141541575 -->|"4"|MiniDFA5_224012471
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
MiniDFA0_1105868620(["MiniDFA0 {1}"])
MiniDFA1_52669570(["MiniDFA1 {1}"])
MiniDFA2_1881359384(["MiniDFA2 {1}"])
MiniDFA3_-301753619(["MiniDFA3 {1}"])
MiniDFA4_-141541575(["MiniDFA4 {1}"])
MiniDFA5_224012471[\"MiniDFA5 {1}"/]
MiniDFA0_1105868620 -->|"i"|MiniDFA1_52669570
MiniDFA1_52669570 -->|"v"|MiniDFA2_1881359384
MiniDFA2_1881359384 -->|"e"|MiniDFA3_-301753619
MiniDFA3_-301753619 -->|"c"|MiniDFA4_-141541575
MiniDFA4_-141541575 -->|"4"|MiniDFA5_224012471
```
-------------------------------
