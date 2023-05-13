# 'struct'

pattern: `struct`

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
eNFA196_12_31788434[["εNFA196-12 regex start"]]
eNFA196_0_17660451[["εNFA196-0 char{1, 1}"]]
eNFA196_1_24726339[["εNFA196-1 char[1]"]]
eNFA196_2_21210466[["εNFA196-2 char{1, 1}"]]
eNFA196_3_56676474[["εNFA196-3 char[1]"]]
eNFA196_4_40326218[["εNFA196-4 char{1, 1}"]]
eNFA196_5_27391644[["εNFA196-5 char[1]"]]
eNFA196_6_45198210[["εNFA196-6 char{1, 1}"]]
eNFA196_7_4130707[["εNFA196-7 char[1]"]]
eNFA196_8_37176370[["εNFA196-8 char{1, 1}"]]
eNFA196_9_66151879[["εNFA196-9 char[1]"]]
eNFA196_10_58496003[["εNFA196-10 char{1, 1}"]]
eNFA196_11_56701983[["εNFA196-11 char[1]"]]
eNFA196_13_40555804[["εNFA196-13 regex end"]]
eNFA196_14_29457924[["εNFA196-14 post-regex start"]]
eNFA196_15_63794726[\"εNFA196-15 post-regex end"/]
eNFA196_12_31788434 -.->|"ε"|eNFA196_0_17660451
eNFA196_0_17660451 -->|"s"|eNFA196_1_24726339
eNFA196_1_24726339 -.->|"ε"|eNFA196_2_21210466
eNFA196_2_21210466 -->|"t"|eNFA196_3_56676474
eNFA196_3_56676474 -.->|"ε"|eNFA196_4_40326218
eNFA196_4_40326218 -->|"r"|eNFA196_5_27391644
eNFA196_5_27391644 -.->|"ε"|eNFA196_6_45198210
eNFA196_6_45198210 -->|"u"|eNFA196_7_4130707
eNFA196_7_4130707 -.->|"ε"|eNFA196_8_37176370
eNFA196_8_37176370 -->|"c"|eNFA196_9_66151879
eNFA196_9_66151879 -.->|"ε"|eNFA196_10_58496003
eNFA196_10_58496003 -->|"t"|eNFA196_11_56701983
eNFA196_11_56701983 -.->|"ε"|eNFA196_13_40555804
eNFA196_13_40555804 -.->|"ε"|eNFA196_14_29457924
eNFA196_14_29457924 -.->|"ε"|eNFA196_15_63794726
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
eNFA196_12_37281629[["εNFA196-12 regex start"]]
eNFA196_0_67099209[["εNFA196-0 char{1, 1}"]]
eNFA196_1_67021971[["εNFA196-1 char[1]"]]
eNFA196_2_66326828[["εNFA196-2 char{1, 1}"]]
eNFA196_3_60070541[["εNFA196-3 char[1]"]]
eNFA196_4_3763959[["εNFA196-4 char{1, 1}"]]
eNFA196_5_33875635[["εNFA196-5 char[1]"]]
eNFA196_6_36445267[["εNFA196-6 char{1, 1}"]]
eNFA196_7_59571951[["εNFA196-7 char[1]"]]
eNFA196_8_66385511[["εNFA196-8 char{1, 1}"]]
eNFA196_9_60598694[["εNFA196-9 char[1]"]]
eNFA196_10_8517340[["εNFA196-10 char{1, 1}"]]
eNFA196_11_9547202[\"εNFA196-11 char[1]"/]
eNFA196_13_18815962[\"εNFA196-13 regex end"/]
eNFA196_14_35125931[\"εNFA196-14 post-regex start"/]
eNFA196_15_47697928[\"εNFA196-15 post-regex end"/]
eNFA196_12_37281629 -.->|"ε"|eNFA196_0_67099209
eNFA196_12_37281629 -->|"s"|eNFA196_1_67021971
eNFA196_0_67099209 -->|"s"|eNFA196_1_67021971
eNFA196_1_67021971 -.->|"ε"|eNFA196_2_66326828
eNFA196_1_67021971 -->|"t"|eNFA196_3_60070541
eNFA196_2_66326828 -->|"t"|eNFA196_3_60070541
eNFA196_3_60070541 -.->|"ε"|eNFA196_4_3763959
eNFA196_3_60070541 -->|"r"|eNFA196_5_33875635
eNFA196_4_3763959 -->|"r"|eNFA196_5_33875635
eNFA196_5_33875635 -.->|"ε"|eNFA196_6_36445267
eNFA196_5_33875635 -->|"u"|eNFA196_7_59571951
eNFA196_6_36445267 -->|"u"|eNFA196_7_59571951
eNFA196_7_59571951 -.->|"ε"|eNFA196_8_66385511
eNFA196_7_59571951 -->|"c"|eNFA196_9_60598694
eNFA196_8_66385511 -->|"c"|eNFA196_9_60598694
eNFA196_9_60598694 -.->|"ε"|eNFA196_10_8517340
eNFA196_9_60598694 -->|"t"|eNFA196_11_9547202
eNFA196_10_8517340 -->|"t"|eNFA196_11_9547202
eNFA196_11_9547202 -.->|"ε"|eNFA196_13_18815962
eNFA196_11_9547202 -.->|"ε"|eNFA196_14_35125931
eNFA196_11_9547202 -.->|"ε"|eNFA196_15_47697928
eNFA196_13_18815962 -.->|"ε"|eNFA196_14_35125931
eNFA196_13_18815962 -.->|"ε"|eNFA196_15_47697928
eNFA196_14_35125931 -.->|"ε"|eNFA196_15_47697928
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
NFA196_12_26628168("NFA196-12 regex start")
NFA196_1_38326926("NFA196-1 char[1]")
NFA196_3_9398018("NFA196-3 char[1]")
NFA196_5_17473301("NFA196-5 char[1]")
NFA196_7_23041984("NFA196-7 char[1]")
NFA196_9_6051268("NFA196-9 char[1]")
NFA196_11_54461419[\"NFA196-11 char[1]"/]
NFA196_12_26628168 -->|"s"|NFA196_1_38326926
NFA196_1_38326926 -->|"t"|NFA196_3_9398018
NFA196_3_9398018 -->|"r"|NFA196_5_17473301
NFA196_5_17473301 -->|"u"|NFA196_7_23041984
NFA196_7_23041984 -->|"c"|NFA196_9_6051268
NFA196_9_6051268 -->|"t"|NFA196_11_54461419
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
subgraph DFA0_2075312853["DFA0 regex start"]
NFA196_12_26628168_0("NFA196-12 regex start")
end
subgraph DFA1_-1084168763["DFA1 {1}"]
NFA196_1_38326926_1("NFA196-1 char[1]")
end
subgraph DFA2_-749497413["DFA2 {1}"]
NFA196_3_9398018_2("NFA196-3 char[1]")
end
subgraph DFA3_-1032063522["DFA3 {1}"]
NFA196_5_17473301_3("NFA196-5 char[1]")
end
subgraph DFA4_594917351["DFA4 {1}"]
NFA196_7_23041984_4("NFA196-7 char[1]")
end
subgraph DFA5_1703818599["DFA5 {1}"]
NFA196_9_6051268_5("NFA196-9 char[1]")
end
subgraph DFA6_1814443530["DFA6 {1}"]
NFA196_11_54461419_6[\"NFA196-11 char[1]"/]
end
DFA0_2075312853 -->|"s"|DFA1_-1084168763
DFA1_-1084168763 -->|"t"|DFA2_-749497413
DFA2_-749497413 -->|"r"|DFA3_-1032063522
DFA3_-1032063522 -->|"u"|DFA4_594917351
DFA4_594917351 -->|"c"|DFA5_1703818599
DFA5_1703818599 -->|"t"|DFA6_1814443530
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
DFA0_2075312853{{"DFA0 regex start"}}
DFA1_-1084168763{{"DFA1 {1}"}}
DFA2_-749497413{{"DFA2 {1}"}}
DFA3_-1032063522{{"DFA3 {1}"}}
DFA4_594917351{{"DFA4 {1}"}}
DFA5_1703818599{{"DFA5 {1}"}}
DFA6_1814443530[\"DFA6 {1}"/]
DFA0_2075312853 -->|"s"|DFA1_-1084168763
DFA1_-1084168763 -->|"t"|DFA2_-749497413
DFA2_-749497413 -->|"r"|DFA3_-1032063522
DFA3_-1032063522 -->|"u"|DFA4_594917351
DFA4_594917351 -->|"c"|DFA5_1703818599
DFA5_1703818599 -->|"t"|DFA6_1814443530
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
subgraph MiniDFA0_1678899965["MiniDFA0 {1}"]
DFA0_2075312853_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-969696400["MiniDFA1 {1}"]
DFA1_-1084168763_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1968157934["MiniDFA2 {1}"]
DFA2_-749497413_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_374151195["MiniDFA3 {1}"]
DFA3_-1032063522_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1261554899["MiniDFA4 {1}"]
DFA4_594917351_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-2018642958["MiniDFA5 {1}"]
DFA5_1703818599_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1783090394["MiniDFA6 {1}"]
DFA6_1814443530_6[\"DFA6 {1}"/]
end
MiniDFA0_1678899965 -->|"s"|MiniDFA1_-969696400
MiniDFA1_-969696400 -->|"t"|MiniDFA2_-1968157934
MiniDFA2_-1968157934 -->|"r"|MiniDFA3_374151195
MiniDFA3_374151195 -->|"u"|MiniDFA4_1261554899
MiniDFA4_1261554899 -->|"c"|MiniDFA5_-2018642958
MiniDFA5_-2018642958 -->|"t"|MiniDFA6_-1783090394
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
MiniDFA0_1678899965(["MiniDFA0 {1}"])
MiniDFA1_-969696400(["MiniDFA1 {1}"])
MiniDFA2_-1968157934(["MiniDFA2 {1}"])
MiniDFA3_374151195(["MiniDFA3 {1}"])
MiniDFA4_1261554899(["MiniDFA4 {1}"])
MiniDFA5_-2018642958(["MiniDFA5 {1}"])
MiniDFA6_-1783090394[\"MiniDFA6 {1}"/]
MiniDFA0_1678899965 -->|"s"|MiniDFA1_-969696400
MiniDFA1_-969696400 -->|"t"|MiniDFA2_-1968157934
MiniDFA2_-1968157934 -->|"r"|MiniDFA3_374151195
MiniDFA3_374151195 -->|"u"|MiniDFA4_1261554899
MiniDFA4_1261554899 -->|"c"|MiniDFA5_-2018642958
MiniDFA5_-2018642958 -->|"t"|MiniDFA6_-1783090394
```
-------------------------------
