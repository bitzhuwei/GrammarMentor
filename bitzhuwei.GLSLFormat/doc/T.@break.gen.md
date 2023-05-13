# 'break'

pattern: `break`

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
eNFA206_10_38515013[["εNFA206-10 regex start"]]
eNFA206_0_11090802[["εNFA206-0 char{1, 1}"]]
eNFA206_1_32708358[["εNFA206-1 char[1]"]]
eNFA206_2_25939770[["εNFA206-2 char{1, 1}"]]
eNFA206_3_32131343[["εNFA206-3 char[1]"]]
eNFA206_4_20746639[["εNFA206-4 char{1, 1}"]]
eNFA206_5_52502025[["εNFA206-5 char[1]"]]
eNFA206_6_2756184[["εNFA206-6 char{1, 1}"]]
eNFA206_7_24805660[["εNFA206-7 char[1]"]]
eNFA206_8_21924350[["εNFA206-8 char{1, 1}"]]
eNFA206_9_63101423[["εNFA206-9 char[1]"]]
eNFA206_11_31041896[["εNFA206-11 regex end"]]
eNFA206_12_10941610[["εNFA206-12 post-regex start"]]
eNFA206_13_31365630[\"εNFA206-13 post-regex end"/]
eNFA206_10_38515013 -.->|"ε"|eNFA206_0_11090802
eNFA206_0_11090802 -->|"b"|eNFA206_1_32708358
eNFA206_1_32708358 -.->|"ε"|eNFA206_2_25939770
eNFA206_2_25939770 -->|"r"|eNFA206_3_32131343
eNFA206_3_32131343 -.->|"ε"|eNFA206_4_20746639
eNFA206_4_20746639 -->|"e"|eNFA206_5_52502025
eNFA206_5_52502025 -.->|"ε"|eNFA206_6_2756184
eNFA206_6_2756184 -->|"a"|eNFA206_7_24805660
eNFA206_7_24805660 -.->|"ε"|eNFA206_8_21924350
eNFA206_8_21924350 -->|"k"|eNFA206_9_63101423
eNFA206_9_63101423 -.->|"ε"|eNFA206_11_31041896
eNFA206_11_31041896 -.->|"ε"|eNFA206_12_10941610
eNFA206_12_10941610 -.->|"ε"|eNFA206_13_31365630
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
eNFA206_10_13855222[["εNFA206-10 regex start"]]
eNFA206_0_57588138[["εNFA206-0 char{1, 1}"]]
eNFA206_1_48531194[["εNFA206-1 char[1]"]]
eNFA206_2_34127569[["εNFA206-2 char{1, 1}"]]
eNFA206_3_38712671[["εNFA206-3 char[1]"]]
eNFA206_4_12869725[["εNFA206-4 char{1, 1}"]]
eNFA206_5_48718669[["εNFA206-5 char[1]"]]
eNFA206_6_35814838[["εNFA206-6 char{1, 1}"]]
eNFA206_7_53898091[["εNFA206-7 char[1]"]]
eNFA206_8_15320771[["εNFA206-8 char{1, 1}"]]
eNFA206_9_3669217[\"εNFA206-9 char[1]"/]
eNFA206_11_33022957[\"εNFA206-11 regex end"/]
eNFA206_12_28771160[\"εNFA206-12 post-regex start"/]
eNFA206_13_57613851[\"εNFA206-13 post-regex end"/]
eNFA206_10_13855222 -.->|"ε"|eNFA206_0_57588138
eNFA206_10_13855222 -->|"b"|eNFA206_1_48531194
eNFA206_0_57588138 -->|"b"|eNFA206_1_48531194
eNFA206_1_48531194 -.->|"ε"|eNFA206_2_34127569
eNFA206_1_48531194 -->|"r"|eNFA206_3_38712671
eNFA206_2_34127569 -->|"r"|eNFA206_3_38712671
eNFA206_3_38712671 -.->|"ε"|eNFA206_4_12869725
eNFA206_3_38712671 -->|"e"|eNFA206_5_48718669
eNFA206_4_12869725 -->|"e"|eNFA206_5_48718669
eNFA206_5_48718669 -.->|"ε"|eNFA206_6_35814838
eNFA206_5_48718669 -->|"a"|eNFA206_7_53898091
eNFA206_6_35814838 -->|"a"|eNFA206_7_53898091
eNFA206_7_53898091 -.->|"ε"|eNFA206_8_15320771
eNFA206_7_53898091 -->|"k"|eNFA206_9_3669217
eNFA206_8_15320771 -->|"k"|eNFA206_9_3669217
eNFA206_9_3669217 -.->|"ε"|eNFA206_11_33022957
eNFA206_9_3669217 -.->|"ε"|eNFA206_12_28771160
eNFA206_9_3669217 -.->|"ε"|eNFA206_13_57613851
eNFA206_11_33022957 -.->|"ε"|eNFA206_12_28771160
eNFA206_11_33022957 -.->|"ε"|eNFA206_13_57613851
eNFA206_12_28771160 -.->|"ε"|eNFA206_13_57613851
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
NFA206_10_48762615("NFA206-10 regex start")
NFA206_1_36210358("NFA206-1 char[1]")
NFA206_3_57457767("NFA206-3 char[1]")
NFA206_5_47357861("NFA206-5 char[1]")
NFA206_7_23567568("NFA206-7 char[1]")
NFA206_9_10781521[\"NFA206-9 char[1]"/]
NFA206_10_48762615 -->|"b"|NFA206_1_36210358
NFA206_1_36210358 -->|"r"|NFA206_3_57457767
NFA206_3_57457767 -->|"e"|NFA206_5_47357861
NFA206_5_47357861 -->|"a"|NFA206_7_23567568
NFA206_7_23567568 -->|"k"|NFA206_9_10781521
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
subgraph DFA0_-945469244["DFA0 regex start"]
NFA206_10_48762615_0("NFA206-10 regex start")
end
subgraph DFA1_-601568030["DFA1 {1}"]
NFA206_1_36210358_1("NFA206-1 char[1]")
end
subgraph DFA2_-1802237702["DFA2 {1}"]
NFA206_3_57457767_2("NFA206-3 char[1]")
end
subgraph DFA3_1846487365["DFA3 {1}"]
NFA206_5_47357861_3("NFA206-5 char[1]")
end
subgraph DFA4_718617952["DFA4 {1}"]
NFA206_7_23567568_4("NFA206-7 char[1]")
end
subgraph DFA5_87552641["DFA5 {1}"]
NFA206_9_10781521_5[\"NFA206-9 char[1]"/]
end
DFA0_-945469244 -->|"b"|DFA1_-601568030
DFA1_-601568030 -->|"r"|DFA2_-1802237702
DFA2_-1802237702 -->|"e"|DFA3_1846487365
DFA3_1846487365 -->|"a"|DFA4_718617952
DFA4_718617952 -->|"k"|DFA5_87552641
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
DFA0_-945469244{{"DFA0 regex start"}}
DFA1_-601568030{{"DFA1 {1}"}}
DFA2_-1802237702{{"DFA2 {1}"}}
DFA3_1846487365{{"DFA3 {1}"}}
DFA4_718617952{{"DFA4 {1}"}}
DFA5_87552641[\"DFA5 {1}"/]
DFA0_-945469244 -->|"b"|DFA1_-601568030
DFA1_-601568030 -->|"r"|DFA2_-1802237702
DFA2_-1802237702 -->|"e"|DFA3_1846487365
DFA3_1846487365 -->|"a"|DFA4_718617952
DFA4_718617952 -->|"k"|DFA5_87552641
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
subgraph MiniDFA0_-1492773365["MiniDFA0 {1}"]
DFA0_-945469244_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-482708131["MiniDFA1 {1}"]
DFA1_-601568030_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-232940899["MiniDFA2 {1}"]
DFA2_-1802237702_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_580121977["MiniDFA3 {1}"]
DFA3_1846487365_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1403601117["MiniDFA4 {1}"]
DFA4_718617952_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_995835526["MiniDFA5 {1}"]
DFA5_87552641_5[\"DFA5 {1}"/]
end
MiniDFA0_-1492773365 -->|"b"|MiniDFA1_-482708131
MiniDFA1_-482708131 -->|"r"|MiniDFA2_-232940899
MiniDFA2_-232940899 -->|"e"|MiniDFA3_580121977
MiniDFA3_580121977 -->|"a"|MiniDFA4_1403601117
MiniDFA4_1403601117 -->|"k"|MiniDFA5_995835526
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
MiniDFA0_-1492773365(["MiniDFA0 {1}"])
MiniDFA1_-482708131(["MiniDFA1 {1}"])
MiniDFA2_-232940899(["MiniDFA2 {1}"])
MiniDFA3_580121977(["MiniDFA3 {1}"])
MiniDFA4_1403601117(["MiniDFA4 {1}"])
MiniDFA5_995835526[\"MiniDFA5 {1}"/]
MiniDFA0_-1492773365 -->|"b"|MiniDFA1_-482708131
MiniDFA1_-482708131 -->|"r"|MiniDFA2_-232940899
MiniDFA2_-232940899 -->|"e"|MiniDFA3_580121977
MiniDFA3_580121977 -->|"a"|MiniDFA4_1403601117
MiniDFA4_1403601117 -->|"k"|MiniDFA5_995835526
```
-------------------------------
