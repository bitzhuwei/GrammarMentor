# 'else'

pattern: `else`

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
eNFA198_8_32943969[["εNFA198-8 regex start"]]
eNFA198_0_28060267[["εNFA198-0 char{1, 1}"]]
eNFA198_1_51215818[["εNFA198-1 char[1]"]]
eNFA198_2_58289182[["εNFA198-2 char{1, 1}"]]
eNFA198_3_54840592[["εNFA198-3 char[1]"]]
eNFA198_4_23803281[["εNFA198-4 char{1, 1}"]]
eNFA198_5_12902938[["εNFA198-5 char[1]"]]
eNFA198_6_49017580[["εNFA198-6 char{1, 1}"]]
eNFA198_7_38505040[["εNFA198-7 char[1]"]]
eNFA198_9_11001048[["εNFA198-9 regex end"]]
eNFA198_10_31900572[["εNFA198-10 post-regex start"]]
eNFA198_11_18669692[\"εNFA198-11 post-regex end"/]
eNFA198_8_32943969 -.->|"ε"|eNFA198_0_28060267
eNFA198_0_28060267 -->|"e"|eNFA198_1_51215818
eNFA198_1_51215818 -.->|"ε"|eNFA198_2_58289182
eNFA198_2_58289182 -->|"l"|eNFA198_3_54840592
eNFA198_3_54840592 -.->|"ε"|eNFA198_4_23803281
eNFA198_4_23803281 -->|"s"|eNFA198_5_12902938
eNFA198_5_12902938 -.->|"ε"|eNFA198_6_49017580
eNFA198_6_49017580 -->|"e"|eNFA198_7_38505040
eNFA198_7_38505040 -.->|"ε"|eNFA198_9_11001048
eNFA198_9_11001048 -.->|"ε"|eNFA198_10_31900572
eNFA198_10_31900572 -.->|"ε"|eNFA198_11_18669692
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
eNFA198_8_33809507[["εNFA198-8 regex start"]]
eNFA198_0_35850113[["εNFA198-0 char{1, 1}"]]
eNFA198_1_54215567[["εNFA198-1 char[1]"]]
eNFA198_2_18178063[["εNFA198-2 char{1, 1}"]]
eNFA198_3_29384840[["εNFA198-3 char[1]"]]
eNFA198_4_63136973[["εNFA198-4 char{1, 1}"]]
eNFA198_5_31361845[["εNFA198-5 char[1]"]]
eNFA198_6_13821155[["εNFA198-6 char{1, 1}"]]
eNFA198_7_57281535[\"εNFA198-7 char[1]"/]
eNFA198_9_45771770[\"εNFA198-9 regex end"/]
eNFA198_10_9292749[\"εNFA198-10 post-regex start"/]
eNFA198_11_16525881[\"εNFA198-11 post-regex end"/]
eNFA198_8_33809507 -.->|"ε"|eNFA198_0_35850113
eNFA198_8_33809507 -->|"e"|eNFA198_1_54215567
eNFA198_0_35850113 -->|"e"|eNFA198_1_54215567
eNFA198_1_54215567 -.->|"ε"|eNFA198_2_18178063
eNFA198_1_54215567 -->|"l"|eNFA198_3_29384840
eNFA198_2_18178063 -->|"l"|eNFA198_3_29384840
eNFA198_3_29384840 -.->|"ε"|eNFA198_4_63136973
eNFA198_3_29384840 -->|"s"|eNFA198_5_31361845
eNFA198_4_63136973 -->|"s"|eNFA198_5_31361845
eNFA198_5_31361845 -.->|"ε"|eNFA198_6_13821155
eNFA198_5_31361845 -->|"e"|eNFA198_7_57281535
eNFA198_6_13821155 -->|"e"|eNFA198_7_57281535
eNFA198_7_57281535 -.->|"ε"|eNFA198_9_45771770
eNFA198_7_57281535 -.->|"ε"|eNFA198_10_9292749
eNFA198_7_57281535 -.->|"ε"|eNFA198_11_16525881
eNFA198_9_45771770 -.->|"ε"|eNFA198_10_9292749
eNFA198_9_45771770 -.->|"ε"|eNFA198_11_16525881
eNFA198_10_9292749 -.->|"ε"|eNFA198_11_16525881
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
NFA198_8_14515208("NFA198-8 regex start")
NFA198_1_63528009("NFA198-1 char[1]")
NFA198_3_34881175("NFA198-3 char[1]")
NFA198_5_45495122("NFA198-5 char[1]")
NFA198_7_6802915[\"NFA198-7 char[1]"/]
NFA198_8_14515208 -->|"e"|NFA198_1_63528009
NFA198_1_63528009 -->|"l"|NFA198_3_34881175
NFA198_3_34881175 -->|"s"|NFA198_5_45495122
NFA198_5_45495122 -->|"e"|NFA198_7_6802915
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
subgraph DFA0_-1410845771["DFA0 regex start"]
NFA198_8_14515208_0("NFA198-8 regex start")
end
subgraph DFA1_-812770225["DFA1 {1}"]
NFA198_1_63528009_1("NFA198-1 char[1]")
end
subgraph DFA2_710279611["DFA2 {1}"]
NFA198_3_34881175_2("NFA198-3 char[1]")
end
subgraph DFA3_803258592["DFA3 {1}"]
NFA198_5_45495122_3("NFA198-5 char[1]")
end
subgraph DFA4_1056647874["DFA4 {1}"]
NFA198_7_6802915_4[\"NFA198-7 char[1]"/]
end
DFA0_-1410845771 -->|"e"|DFA1_-812770225
DFA1_-812770225 -->|"l"|DFA2_710279611
DFA2_710279611 -->|"s"|DFA3_803258592
DFA3_803258592 -->|"e"|DFA4_1056647874
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
DFA0_-1410845771{{"DFA0 regex start"}}
DFA1_-812770225{{"DFA1 {1}"}}
DFA2_710279611{{"DFA2 {1}"}}
DFA3_803258592{{"DFA3 {1}"}}
DFA4_1056647874[\"DFA4 {1}"/]
DFA0_-1410845771 -->|"e"|DFA1_-812770225
DFA1_-812770225 -->|"l"|DFA2_710279611
DFA2_710279611 -->|"s"|DFA3_803258592
DFA3_803258592 -->|"e"|DFA4_1056647874
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
subgraph MiniDFA0_-1732627670["MiniDFA0 {1}"]
DFA0_-1410845771_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1781749951["MiniDFA1 {1}"]
DFA1_-812770225_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_694909286["MiniDFA2 {1}"]
DFA2_710279611_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_500181693["MiniDFA3 {1}"]
DFA3_803258592_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_575335606["MiniDFA4 {1}"]
DFA4_1056647874_4[\"DFA4 {1}"/]
end
MiniDFA0_-1732627670 -->|"e"|MiniDFA1_-1781749951
MiniDFA1_-1781749951 -->|"l"|MiniDFA2_694909286
MiniDFA2_694909286 -->|"s"|MiniDFA3_500181693
MiniDFA3_500181693 -->|"e"|MiniDFA4_575335606
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
MiniDFA0_-1732627670(["MiniDFA0 {1}"])
MiniDFA1_-1781749951(["MiniDFA1 {1}"])
MiniDFA2_694909286(["MiniDFA2 {1}"])
MiniDFA3_500181693(["MiniDFA3 {1}"])
MiniDFA4_575335606[\"MiniDFA4 {1}"/]
MiniDFA0_-1732627670 -->|"e"|MiniDFA1_-1781749951
MiniDFA1_-1781749951 -->|"l"|MiniDFA2_694909286
MiniDFA2_694909286 -->|"s"|MiniDFA3_500181693
MiniDFA3_500181693 -->|"e"|MiniDFA4_575335606
```
-------------------------------
