# 'dvec2'

pattern: `dvec2`

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
eNFA83_10_14721100[["εNFA83-10 regex start"]]
eNFA83_0_65381042[["εNFA83-0 char{1, 1}"]]
eNFA83_1_51558469[["εNFA83-1 char[1]"]]
eNFA83_2_61373038[["εNFA83-2 char{1, 1}"]]
eNFA83_3_15486430[["εNFA83-3 char[1]"]]
eNFA83_4_5160142[["εNFA83-4 char{1, 1}"]]
eNFA83_5_46441279[["εNFA83-5 char[1]"]]
eNFA83_6_15318330[["εNFA83-6 char{1, 1}"]]
eNFA83_7_3647249[["εNFA83-7 char[1]"]]
eNFA83_8_32825243[["εNFA83-8 char{1, 1}"]]
eNFA83_9_26991739[["εNFA83-9 char[1]"]]
eNFA83_11_41599065[["εNFA83-11 regex end"]]
eNFA83_12_38847270[["εNFA83-12 post-regex start"]]
eNFA83_13_14081115[\"εNFA83-13 post-regex end"/]
eNFA83_10_14721100 -.->|"ε"|eNFA83_0_65381042
eNFA83_0_65381042 -->|"d"|eNFA83_1_51558469
eNFA83_1_51558469 -.->|"ε"|eNFA83_2_61373038
eNFA83_2_61373038 -->|"v"|eNFA83_3_15486430
eNFA83_3_15486430 -.->|"ε"|eNFA83_4_5160142
eNFA83_4_5160142 -->|"e"|eNFA83_5_46441279
eNFA83_5_46441279 -.->|"ε"|eNFA83_6_15318330
eNFA83_6_15318330 -->|"c"|eNFA83_7_3647249
eNFA83_7_3647249 -.->|"ε"|eNFA83_8_32825243
eNFA83_8_32825243 -->|"2"|eNFA83_9_26991739
eNFA83_9_26991739 -.->|"ε"|eNFA83_11_41599065
eNFA83_11_41599065 -.->|"ε"|eNFA83_12_38847270
eNFA83_12_38847270 -.->|"ε"|eNFA83_13_14081115
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
eNFA83_10_59621178[["εNFA83-10 regex start"]]
eNFA83_0_66828554[["εNFA83-0 char{1, 1}"]]
eNFA83_1_64586077[["εNFA83-1 char[1]"]]
eNFA83_2_44403789[["εNFA83-2 char{1, 1}"]]
eNFA83_3_64089786[["εNFA83-3 char[1]"]]
eNFA83_4_39937165[["εNFA83-4 char{1, 1}"]]
eNFA83_5_23890167[["εNFA83-5 char[1]"]]
eNFA83_6_13684913[["εNFA83-6 char{1, 1}"]]
eNFA83_7_56055356[["εNFA83-7 char[1]"]]
eNFA83_8_34736162[["εNFA83-8 char{1, 1}"]]
eNFA83_9_44190002[\"εNFA83-9 char[1]"/]
eNFA83_11_62165703[\"εNFA83-11 regex end"/]
eNFA83_12_22620416[\"εNFA83-12 post-regex start"/]
eNFA83_13_2257160[\"εNFA83-13 post-regex end"/]
eNFA83_10_59621178 -.->|"ε"|eNFA83_0_66828554
eNFA83_10_59621178 -->|"d"|eNFA83_1_64586077
eNFA83_0_66828554 -->|"d"|eNFA83_1_64586077
eNFA83_1_64586077 -.->|"ε"|eNFA83_2_44403789
eNFA83_1_64586077 -->|"v"|eNFA83_3_64089786
eNFA83_2_44403789 -->|"v"|eNFA83_3_64089786
eNFA83_3_64089786 -.->|"ε"|eNFA83_4_39937165
eNFA83_3_64089786 -->|"e"|eNFA83_5_23890167
eNFA83_4_39937165 -->|"e"|eNFA83_5_23890167
eNFA83_5_23890167 -.->|"ε"|eNFA83_6_13684913
eNFA83_5_23890167 -->|"c"|eNFA83_7_56055356
eNFA83_6_13684913 -->|"c"|eNFA83_7_56055356
eNFA83_7_56055356 -.->|"ε"|eNFA83_8_34736162
eNFA83_7_56055356 -->|"2"|eNFA83_9_44190002
eNFA83_8_34736162 -->|"2"|eNFA83_9_44190002
eNFA83_9_44190002 -.->|"ε"|eNFA83_11_62165703
eNFA83_9_44190002 -.->|"ε"|eNFA83_12_22620416
eNFA83_9_44190002 -.->|"ε"|eNFA83_13_2257160
eNFA83_11_62165703 -.->|"ε"|eNFA83_12_22620416
eNFA83_11_62165703 -.->|"ε"|eNFA83_13_2257160
eNFA83_12_22620416 -.->|"ε"|eNFA83_13_2257160
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
NFA83_10_20314447("NFA83-10 regex start")
NFA83_1_48612303("NFA83-1 char[1]")
NFA83_3_34857543("NFA83-3 char[1]")
NFA83_5_45282433("NFA83-5 char[1]")
NFA83_7_4888719("NFA83-7 char[1]")
NFA83_9_43998472[\"NFA83-9 char[1]"/]
NFA83_10_20314447 -->|"d"|NFA83_1_48612303
NFA83_1_48612303 -->|"v"|NFA83_3_34857543
NFA83_3_34857543 -->|"e"|NFA83_5_45282433
NFA83_5_45282433 -->|"c"|NFA83_7_4888719
NFA83_7_4888719 -->|"2"|NFA83_9_43998472
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
subgraph DFA0_-1134304930["DFA0 regex start"]
NFA83_10_20314447_0("NFA83-10 regex start")
end
subgraph DFA1_-1015268764["DFA1 {1}"]
NFA83_1_48612303_1("NFA83-1 char[1]")
end
subgraph DFA2_-852880014["DFA2 {1}"]
NFA83_3_34857543_2("NFA83-3 char[1]")
end
subgraph DFA3_-661273213["DFA3 {1}"]
NFA83_5_45282433_3("NFA83-5 char[1]")
end
subgraph DFA4_1864007575["DFA4 {1}"]
NFA83_7_4888719_4("NFA83-7 char[1]")
end
subgraph DFA5_-1893593049["DFA5 {1}"]
NFA83_9_43998472_5[\"NFA83-9 char[1]"/]
end
DFA0_-1134304930 -->|"d"|DFA1_-1015268764
DFA1_-1015268764 -->|"v"|DFA2_-852880014
DFA2_-852880014 -->|"e"|DFA3_-661273213
DFA3_-661273213 -->|"c"|DFA4_1864007575
DFA4_1864007575 -->|"2"|DFA5_-1893593049
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
DFA0_-1134304930{{"DFA0 regex start"}}
DFA1_-1015268764{{"DFA1 {1}"}}
DFA2_-852880014{{"DFA2 {1}"}}
DFA3_-661273213{{"DFA3 {1}"}}
DFA4_1864007575{{"DFA4 {1}"}}
DFA5_-1893593049[\"DFA5 {1}"/]
DFA0_-1134304930 -->|"d"|DFA1_-1015268764
DFA1_-1015268764 -->|"v"|DFA2_-852880014
DFA2_-852880014 -->|"e"|DFA3_-661273213
DFA3_-661273213 -->|"c"|DFA4_1864007575
DFA4_1864007575 -->|"2"|DFA5_-1893593049
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
subgraph MiniDFA0_-2140797874["MiniDFA0 {1}"]
DFA0_-1134304930_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-543825291["MiniDFA1 {1}"]
DFA1_-1015268764_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-134990214["MiniDFA2 {1}"]
DFA2_-852880014_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_83014279["MiniDFA3 {1}"]
DFA3_-661273213_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1979112364["MiniDFA4 {1}"]
DFA4_1864007575_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1798704217["MiniDFA5 {1}"]
DFA5_-1893593049_5[\"DFA5 {1}"/]
end
MiniDFA0_-2140797874 -->|"d"|MiniDFA1_-543825291
MiniDFA1_-543825291 -->|"v"|MiniDFA2_-134990214
MiniDFA2_-134990214 -->|"e"|MiniDFA3_83014279
MiniDFA3_83014279 -->|"c"|MiniDFA4_-1979112364
MiniDFA4_-1979112364 -->|"2"|MiniDFA5_-1798704217
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
MiniDFA0_-2140797874(["MiniDFA0 {1}"])
MiniDFA1_-543825291(["MiniDFA1 {1}"])
MiniDFA2_-134990214(["MiniDFA2 {1}"])
MiniDFA3_83014279(["MiniDFA3 {1}"])
MiniDFA4_-1979112364(["MiniDFA4 {1}"])
MiniDFA5_-1798704217[\"MiniDFA5 {1}"/]
MiniDFA0_-2140797874 -->|"d"|MiniDFA1_-543825291
MiniDFA1_-543825291 -->|"v"|MiniDFA2_-134990214
MiniDFA2_-134990214 -->|"e"|MiniDFA3_83014279
MiniDFA3_83014279 -->|"c"|MiniDFA4_-1979112364
MiniDFA4_-1979112364 -->|"2"|MiniDFA5_-1798704217
```
-------------------------------
