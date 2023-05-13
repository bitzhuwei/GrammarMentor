# 'mat3x2'

pattern: `mat3x2`

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
eNFA101_12_3672032[["εNFA101-12 regex start"]]
eNFA101_0_33048293[["εNFA101-0 char{1, 1}"]]
eNFA101_1_28999185[["εNFA101-1 char[1]"]]
eNFA101_2_59666077[["εNFA101-2 char{1, 1}"]]
eNFA101_3_123786[["εNFA101-3 char[1]"]]
eNFA101_4_1114082[["εNFA101-4 char{1, 1}"]]
eNFA101_5_10026740[["εNFA101-5 char[1]"]]
eNFA101_6_23131803[["εNFA101-6 char{1, 1}"]]
eNFA101_7_6859639[["εNFA101-7 char[1]"]]
eNFA101_8_61736753[["εNFA101-8 char{1, 1}"]]
eNFA101_9_18759866[["εNFA101-9 char[1]"]]
eNFA101_10_34621067[["εNFA101-10 char{1, 1}"]]
eNFA101_11_43154149[["εNFA101-11 char[1]"]]
eNFA101_13_52843025[["εNFA101-13 regex end"]]
eNFA101_14_5825185[["εNFA101-14 post-regex start"]]
eNFA101_15_52426669[\"εNFA101-15 post-regex end"/]
eNFA101_12_3672032 -.->|"ε"|eNFA101_0_33048293
eNFA101_0_33048293 -->|"m"|eNFA101_1_28999185
eNFA101_1_28999185 -.->|"ε"|eNFA101_2_59666077
eNFA101_2_59666077 -->|"a"|eNFA101_3_123786
eNFA101_3_123786 -.->|"ε"|eNFA101_4_1114082
eNFA101_4_1114082 -->|"t"|eNFA101_5_10026740
eNFA101_5_10026740 -.->|"ε"|eNFA101_6_23131803
eNFA101_6_23131803 -->|"3"|eNFA101_7_6859639
eNFA101_7_6859639 -.->|"ε"|eNFA101_8_61736753
eNFA101_8_61736753 -->|"x"|eNFA101_9_18759866
eNFA101_9_18759866 -.->|"ε"|eNFA101_10_34621067
eNFA101_10_34621067 -->|"2"|eNFA101_11_43154149
eNFA101_11_43154149 -.->|"ε"|eNFA101_13_52843025
eNFA101_13_52843025 -.->|"ε"|eNFA101_14_5825185
eNFA101_14_5825185 -.->|"ε"|eNFA101_15_52426669
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
eNFA101_12_2077973[["εNFA101-12 regex start"]]
eNFA101_0_18701764[["εNFA101-0 char{1, 1}"]]
eNFA101_1_34098154[["εNFA101-1 char[1]"]]
eNFA101_2_38447936[["εNFA101-2 char{1, 1}"]]
eNFA101_3_10487112[["εNFA101-3 char[1]"]]
eNFA101_4_27275145[["εNFA101-4 char{1, 1}"]]
eNFA101_5_44149718[["εNFA101-5 char[1]"]]
eNFA101_6_61803142[["εNFA101-6 char{1, 1}"]]
eNFA101_7_19357372[["εNFA101-7 char[1]"]]
eNFA101_8_39998624[["εNFA101-8 char{1, 1}"]]
eNFA101_9_24443299[["εNFA101-9 char[1]"]]
eNFA101_10_18663102[["εNFA101-10 char{1, 1}"]]
eNFA101_11_33750194[\"εNFA101-11 char[1]"/]
eNFA101_13_35316297[\"εNFA101-13 regex end"/]
eNFA101_14_49411218[\"εNFA101-14 post-regex start"/]
eNFA101_15_42047784[\"εNFA101-15 post-regex end"/]
eNFA101_12_2077973 -.->|"ε"|eNFA101_0_18701764
eNFA101_12_2077973 -->|"m"|eNFA101_1_34098154
eNFA101_0_18701764 -->|"m"|eNFA101_1_34098154
eNFA101_1_34098154 -.->|"ε"|eNFA101_2_38447936
eNFA101_1_34098154 -->|"a"|eNFA101_3_10487112
eNFA101_2_38447936 -->|"a"|eNFA101_3_10487112
eNFA101_3_10487112 -.->|"ε"|eNFA101_4_27275145
eNFA101_3_10487112 -->|"t"|eNFA101_5_44149718
eNFA101_4_27275145 -->|"t"|eNFA101_5_44149718
eNFA101_5_44149718 -.->|"ε"|eNFA101_6_61803142
eNFA101_5_44149718 -->|"3"|eNFA101_7_19357372
eNFA101_6_61803142 -->|"3"|eNFA101_7_19357372
eNFA101_7_19357372 -.->|"ε"|eNFA101_8_39998624
eNFA101_7_19357372 -->|"x"|eNFA101_9_24443299
eNFA101_8_39998624 -->|"x"|eNFA101_9_24443299
eNFA101_9_24443299 -.->|"ε"|eNFA101_10_18663102
eNFA101_9_24443299 -->|"2"|eNFA101_11_33750194
eNFA101_10_18663102 -->|"2"|eNFA101_11_33750194
eNFA101_11_33750194 -.->|"ε"|eNFA101_13_35316297
eNFA101_11_33750194 -.->|"ε"|eNFA101_14_49411218
eNFA101_11_33750194 -.->|"ε"|eNFA101_15_42047784
eNFA101_13_35316297 -.->|"ε"|eNFA101_14_49411218
eNFA101_13_35316297 -.->|"ε"|eNFA101_15_42047784
eNFA101_14_49411218 -.->|"ε"|eNFA101_15_42047784
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
NFA101_12_42885739("NFA101-12 regex start")
NFA101_1_50427332("NFA101-1 char[1]")
NFA101_3_51192804("NFA101-3 char[1]")
NFA101_5_58082052("NFA101-5 char[1]")
NFA101_7_52976421("NFA101-7 char[1]")
NFA101_9_7025744("NFA101-9 char[1]")
NFA101_11_63231703[\"NFA101-11 char[1]"/]
NFA101_12_42885739 -->|"m"|NFA101_1_50427332
NFA101_1_50427332 -->|"a"|NFA101_3_51192804
NFA101_3_51192804 -->|"t"|NFA101_5_58082052
NFA101_5_58082052 -->|"3"|NFA101_7_52976421
NFA101_7_52976421 -->|"x"|NFA101_9_7025744
NFA101_9_7025744 -->|"2"|NFA101_11_63231703
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
subgraph DFA0_-1378046628["DFA0 regex start"]
NFA101_12_42885739_0("NFA101-12 regex start")
end
subgraph DFA1_-710417519["DFA1 {1}"]
NFA101_1_50427332_1("NFA101-1 char[1]")
end
subgraph DFA2_-2079101217["DFA2 {1}"]
NFA101_3_51192804_2("NFA101-3 char[1]")
end
subgraph DFA3_1839687454["DFA3 {1}"]
NFA101_5_58082052_3("NFA101-5 char[1]")
end
subgraph DFA4_379187656["DFA4 {1}"]
NFA101_7_52976421_4("NFA101-7 char[1]")
end
subgraph DFA5_-167353424["DFA5 {1}"]
NFA101_9_7025744_5("NFA101-9 char[1]")
end
subgraph DFA6_-385793751["DFA6 {1}"]
NFA101_11_63231703_6[\"NFA101-11 char[1]"/]
end
DFA0_-1378046628 -->|"m"|DFA1_-710417519
DFA1_-710417519 -->|"a"|DFA2_-2079101217
DFA2_-2079101217 -->|"t"|DFA3_1839687454
DFA3_1839687454 -->|"3"|DFA4_379187656
DFA4_379187656 -->|"x"|DFA5_-167353424
DFA5_-167353424 -->|"2"|DFA6_-385793751
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
DFA0_-1378046628{{"DFA0 regex start"}}
DFA1_-710417519{{"DFA1 {1}"}}
DFA2_-2079101217{{"DFA2 {1}"}}
DFA3_1839687454{{"DFA3 {1}"}}
DFA4_379187656{{"DFA4 {1}"}}
DFA5_-167353424{{"DFA5 {1}"}}
DFA6_-385793751[\"DFA6 {1}"/]
DFA0_-1378046628 -->|"m"|DFA1_-710417519
DFA1_-710417519 -->|"a"|DFA2_-2079101217
DFA2_-2079101217 -->|"t"|DFA3_1839687454
DFA3_1839687454 -->|"3"|DFA4_379187656
DFA4_379187656 -->|"x"|DFA5_-167353424
DFA5_-167353424 -->|"2"|DFA6_-385793751
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
subgraph MiniDFA0_2058887843["MiniDFA0 {1}"]
DFA0_-1378046628_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_478520368["MiniDFA1 {1}"]
DFA1_-710417519_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-72276636["MiniDFA2 {1}"]
DFA2_-2079101217_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-174191609["MiniDFA3 {1}"]
DFA3_1839687454_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_413321552["MiniDFA4 {1}"]
DFA4_379187656_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1602987054["MiniDFA5 {1}"]
DFA5_-167353424_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1266166861["MiniDFA6 {1}"]
DFA6_-385793751_6[\"DFA6 {1}"/]
end
MiniDFA0_2058887843 -->|"m"|MiniDFA1_478520368
MiniDFA1_478520368 -->|"a"|MiniDFA2_-72276636
MiniDFA2_-72276636 -->|"t"|MiniDFA3_-174191609
MiniDFA3_-174191609 -->|"3"|MiniDFA4_413321552
MiniDFA4_413321552 -->|"x"|MiniDFA5_1602987054
MiniDFA5_1602987054 -->|"2"|MiniDFA6_1266166861
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
MiniDFA0_2058887843(["MiniDFA0 {1}"])
MiniDFA1_478520368(["MiniDFA1 {1}"])
MiniDFA2_-72276636(["MiniDFA2 {1}"])
MiniDFA3_-174191609(["MiniDFA3 {1}"])
MiniDFA4_413321552(["MiniDFA4 {1}"])
MiniDFA5_1602987054(["MiniDFA5 {1}"])
MiniDFA6_1266166861[\"MiniDFA6 {1}"/]
MiniDFA0_2058887843 -->|"m"|MiniDFA1_478520368
MiniDFA1_478520368 -->|"a"|MiniDFA2_-72276636
MiniDFA2_-72276636 -->|"t"|MiniDFA3_-174191609
MiniDFA3_-174191609 -->|"3"|MiniDFA4_413321552
MiniDFA4_413321552 -->|"x"|MiniDFA5_1602987054
MiniDFA5_1602987054 -->|"2"|MiniDFA6_1266166861
```
-------------------------------
