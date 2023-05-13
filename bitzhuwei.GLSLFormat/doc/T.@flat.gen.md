# 'flat'

pattern: `flat`

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
eNFA54_8_56049180[["εNFA54-8 regex start"]]
eNFA54_0_34680572[["εNFA54-0 char{1, 1}"]]
eNFA54_1_43689693[["εNFA54-1 char[1]"]]
eNFA54_2_57662920[["εNFA54-2 char{1, 1}"]]
eNFA54_3_49204239[["εNFA54-3 char[1]"]]
eNFA54_4_40184969[["εNFA54-4 char{1, 1}"]]
eNFA54_5_26120409[["εNFA54-5 char[1]"]]
eNFA54_6_33757095[["εNFA54-6 char{1, 1}"]]
eNFA54_7_35378404[["εNFA54-7 char[1]"]]
eNFA54_9_49970185[["εNFA54-9 regex end"]]
eNFA54_10_47078488[["εNFA54-10 post-regex start"]]
eNFA54_11_21053208[\"εNFA54-11 post-regex end"/]
eNFA54_8_56049180 -.->|"ε"|eNFA54_0_34680572
eNFA54_0_34680572 -->|"f"|eNFA54_1_43689693
eNFA54_1_43689693 -.->|"ε"|eNFA54_2_57662920
eNFA54_2_57662920 -->|"l"|eNFA54_3_49204239
eNFA54_3_49204239 -.->|"ε"|eNFA54_4_40184969
eNFA54_4_40184969 -->|"a"|eNFA54_5_26120409
eNFA54_5_26120409 -.->|"ε"|eNFA54_6_33757095
eNFA54_6_33757095 -->|"t"|eNFA54_7_35378404
eNFA54_7_35378404 -.->|"ε"|eNFA54_9_49970185
eNFA54_9_49970185 -.->|"ε"|eNFA54_10_47078488
eNFA54_10_47078488 -.->|"ε"|eNFA54_11_21053208
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
eNFA54_8_55261147[["εNFA54-8 regex start"]]
eNFA54_0_27588283[["εNFA54-0 char{1, 1}"]]
eNFA54_1_46967960[["εNFA54-1 char[1]"]]
eNFA54_2_20058459[["εNFA54-2 char{1, 1}"]]
eNFA54_3_46308405[["εNFA54-3 char[1]"]]
eNFA54_4_14122463[["εNFA54-4 char{1, 1}"]]
eNFA54_5_59993306[["εNFA54-5 char[1]"]]
eNFA54_6_3068848[["εNFA54-6 char{1, 1}"]]
eNFA54_7_27619632[\"εNFA54-7 char[1]"/]
eNFA54_9_47250101[\"εNFA54-9 regex end"/]
eNFA54_10_22597726[\"εNFA54-10 post-regex start"/]
eNFA54_11_2052950[\"εNFA54-11 post-regex end"/]
eNFA54_8_55261147 -.->|"ε"|eNFA54_0_27588283
eNFA54_8_55261147 -->|"f"|eNFA54_1_46967960
eNFA54_0_27588283 -->|"f"|eNFA54_1_46967960
eNFA54_1_46967960 -.->|"ε"|eNFA54_2_20058459
eNFA54_1_46967960 -->|"l"|eNFA54_3_46308405
eNFA54_2_20058459 -->|"l"|eNFA54_3_46308405
eNFA54_3_46308405 -.->|"ε"|eNFA54_4_14122463
eNFA54_3_46308405 -->|"a"|eNFA54_5_59993306
eNFA54_4_14122463 -->|"a"|eNFA54_5_59993306
eNFA54_5_59993306 -.->|"ε"|eNFA54_6_3068848
eNFA54_5_59993306 -->|"t"|eNFA54_7_27619632
eNFA54_6_3068848 -->|"t"|eNFA54_7_27619632
eNFA54_7_27619632 -.->|"ε"|eNFA54_9_47250101
eNFA54_7_27619632 -.->|"ε"|eNFA54_10_22597726
eNFA54_7_27619632 -.->|"ε"|eNFA54_11_2052950
eNFA54_9_47250101 -.->|"ε"|eNFA54_10_22597726
eNFA54_9_47250101 -.->|"ε"|eNFA54_11_2052950
eNFA54_10_22597726 -.->|"ε"|eNFA54_11_2052950
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
NFA54_8_18476557("NFA54-8 regex start")
NFA54_1_32071293("NFA54-1 char[1]")
NFA54_3_20206181("NFA54-3 char[1]")
NFA54_5_47637903("NFA54-5 char[1]")
NFA54_7_26087949[\"NFA54-7 char[1]"/]
NFA54_8_18476557 -->|"f"|NFA54_1_32071293
NFA54_1_32071293 -->|"l"|NFA54_3_20206181
NFA54_3_20206181 -->|"a"|NFA54_5_47637903
NFA54_5_47637903 -->|"t"|NFA54_7_26087949
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
subgraph DFA0_762047693["DFA0 regex start"]
NFA54_8_18476557_0("NFA54-8 regex start")
end
subgraph DFA1_1009090675["DFA1 {1}"]
NFA54_1_32071293_1("NFA54-1 char[1]")
end
subgraph DFA2_-2037330635["DFA2 {1}"]
NFA54_3_20206181_2("NFA54-3 char[1]")
end
subgraph DFA3_1908153810["DFA3 {1}"]
NFA54_5_47637903_3("NFA54-5 char[1]")
end
subgraph DFA4_-2074254781["DFA4 {1}"]
NFA54_7_26087949_4[\"NFA54-7 char[1]"/]
end
DFA0_762047693 -->|"f"|DFA1_1009090675
DFA1_1009090675 -->|"l"|DFA2_-2037330635
DFA2_-2037330635 -->|"a"|DFA3_1908153810
DFA3_1908153810 -->|"t"|DFA4_-2074254781
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
DFA0_762047693{{"DFA0 regex start"}}
DFA1_1009090675{{"DFA1 {1}"}}
DFA2_-2037330635{{"DFA2 {1}"}}
DFA3_1908153810{{"DFA3 {1}"}}
DFA4_-2074254781[\"DFA4 {1}"/]
DFA0_762047693 -->|"f"|DFA1_1009090675
DFA1_1009090675 -->|"l"|DFA2_-2037330635
DFA2_-2037330635 -->|"a"|DFA3_1908153810
DFA3_1908153810 -->|"t"|DFA4_-2074254781
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
subgraph MiniDFA0_-1113572335["MiniDFA0 {1}"]
DFA0_762047693_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-152809536["MiniDFA1 {1}"]
DFA1_1009090675_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1002285932["MiniDFA2 {1}"]
DFA2_-2037330635_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-22092510["MiniDFA3 {1}"]
DFA3_1908153810_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-313798834["MiniDFA4 {1}"]
DFA4_-2074254781_4[\"DFA4 {1}"/]
end
MiniDFA0_-1113572335 -->|"f"|MiniDFA1_-152809536
MiniDFA1_-152809536 -->|"l"|MiniDFA2_-1002285932
MiniDFA2_-1002285932 -->|"a"|MiniDFA3_-22092510
MiniDFA3_-22092510 -->|"t"|MiniDFA4_-313798834
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
MiniDFA0_-1113572335(["MiniDFA0 {1}"])
MiniDFA1_-152809536(["MiniDFA1 {1}"])
MiniDFA2_-1002285932(["MiniDFA2 {1}"])
MiniDFA3_-22092510(["MiniDFA3 {1}"])
MiniDFA4_-313798834[\"MiniDFA4 {1}"/]
MiniDFA0_-1113572335 -->|"f"|MiniDFA1_-152809536
MiniDFA1_-152809536 -->|"l"|MiniDFA2_-1002285932
MiniDFA2_-1002285932 -->|"a"|MiniDFA3_-22092510
MiniDFA3_-22092510 -->|"t"|MiniDFA4_-313798834
```
-------------------------------
