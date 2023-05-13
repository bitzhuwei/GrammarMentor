# 'vec3'

pattern: `vec3`

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
eNFA81_8_29752015[["εNFA81-8 regex start"]]
eNFA81_0_66441544[["εNFA81-0 char{1, 1}"]]
eNFA81_1_61102986[["εNFA81-1 char[1]"]]
eNFA81_2_13055966[["εNFA81-2 char{1, 1}"]]
eNFA81_3_50394838[["εNFA81-3 char[1]"]]
eNFA81_4_50900362[["εNFA81-4 char{1, 1}"]]
eNFA81_5_55450074[["εNFA81-5 char[1]"]]
eNFA81_6_29288625[["εNFA81-6 char{1, 1}"]]
eNFA81_7_62271039[["εNFA81-7 char[1]"]]
eNFA81_9_23568445[["εNFA81-9 regex end"]]
eNFA81_10_10789421[["εNFA81-10 post-regex start"]]
eNFA81_11_29995926[\"εNFA81-11 post-regex end"/]
eNFA81_8_29752015 -.->|"ε"|eNFA81_0_66441544
eNFA81_0_66441544 -->|"v"|eNFA81_1_61102986
eNFA81_1_61102986 -.->|"ε"|eNFA81_2_13055966
eNFA81_2_13055966 -->|"e"|eNFA81_3_50394838
eNFA81_3_50394838 -.->|"ε"|eNFA81_4_50900362
eNFA81_4_50900362 -->|"c"|eNFA81_5_55450074
eNFA81_5_55450074 -.->|"ε"|eNFA81_6_29288625
eNFA81_6_29288625 -->|"3"|eNFA81_7_62271039
eNFA81_7_62271039 -.->|"ε"|eNFA81_9_23568445
eNFA81_9_23568445 -.->|"ε"|eNFA81_10_10789421
eNFA81_10_10789421 -.->|"ε"|eNFA81_11_29995926
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
eNFA81_8_1527883[["εNFA81-8 regex start"]]
eNFA81_0_13750947[["εNFA81-0 char{1, 1}"]]
eNFA81_1_56649665[["εNFA81-1 char[1]"]]
eNFA81_2_40084941[["εNFA81-2 char{1, 1}"]]
eNFA81_3_25220152[["εNFA81-3 char[1]"]]
eNFA81_4_25654779[["εNFA81-4 char{1, 1}"]]
eNFA81_5_29566423[["εNFA81-5 char[1]"]]
eNFA81_6_64771222[["εNFA81-6 char{1, 1}"]]
eNFA81_7_46070087[\"εNFA81-7 char[1]"/]
eNFA81_9_11977605[\"εNFA81-9 regex end"/]
eNFA81_10_40689584[\"εNFA81-10 post-regex start"/]
eNFA81_11_30661937[\"εNFA81-11 post-regex end"/]
eNFA81_8_1527883 -.->|"ε"|eNFA81_0_13750947
eNFA81_8_1527883 -->|"v"|eNFA81_1_56649665
eNFA81_0_13750947 -->|"v"|eNFA81_1_56649665
eNFA81_1_56649665 -.->|"ε"|eNFA81_2_40084941
eNFA81_1_56649665 -->|"e"|eNFA81_3_25220152
eNFA81_2_40084941 -->|"e"|eNFA81_3_25220152
eNFA81_3_25220152 -.->|"ε"|eNFA81_4_25654779
eNFA81_3_25220152 -->|"c"|eNFA81_5_29566423
eNFA81_4_25654779 -->|"c"|eNFA81_5_29566423
eNFA81_5_29566423 -.->|"ε"|eNFA81_6_64771222
eNFA81_5_29566423 -->|"3"|eNFA81_7_46070087
eNFA81_6_64771222 -->|"3"|eNFA81_7_46070087
eNFA81_7_46070087 -.->|"ε"|eNFA81_9_11977605
eNFA81_7_46070087 -.->|"ε"|eNFA81_10_40689584
eNFA81_7_46070087 -.->|"ε"|eNFA81_11_30661937
eNFA81_9_11977605 -.->|"ε"|eNFA81_10_40689584
eNFA81_9_11977605 -.->|"ε"|eNFA81_11_30661937
eNFA81_10_40689584 -.->|"ε"|eNFA81_11_30661937
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
NFA81_8_7521977("NFA81-8 regex start")
NFA81_1_588929("NFA81-1 char[1]")
NFA81_3_5300362("NFA81-3 char[1]")
NFA81_5_47703261("NFA81-5 char[1]")
NFA81_7_26676172[\"NFA81-7 char[1]"/]
NFA81_8_7521977 -->|"v"|NFA81_1_588929
NFA81_1_588929 -->|"e"|NFA81_3_5300362
NFA81_3_5300362 -->|"c"|NFA81_5_47703261
NFA81_5_47703261 -->|"3"|NFA81_7_26676172
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
subgraph DFA0_-813618501["DFA0 regex start"]
NFA81_8_7521977_0("NFA81-8 regex start")
end
subgraph DFA1_-538958876["DFA1 {1}"]
NFA81_1_588929_1("NFA81-1 char[1]")
end
subgraph DFA2_-522976500["DFA2 {1}"]
NFA81_3_5300362_2("NFA81-3 char[1]")
end
subgraph DFA3_347598921["DFA3 {1}"]
NFA81_5_47703261_3("NFA81-5 char[1]")
end
subgraph DFA4_-1914114789["DFA4 {1}"]
NFA81_7_26676172_4[\"NFA81-7 char[1]"/]
end
DFA0_-813618501 -->|"v"|DFA1_-538958876
DFA1_-538958876 -->|"e"|DFA2_-522976500
DFA2_-522976500 -->|"c"|DFA3_347598921
DFA3_347598921 -->|"3"|DFA4_-1914114789
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
DFA0_-813618501{{"DFA0 regex start"}}
DFA1_-538958876{{"DFA1 {1}"}}
DFA2_-522976500{{"DFA2 {1}"}}
DFA3_347598921{{"DFA3 {1}"}}
DFA4_-1914114789[\"DFA4 {1}"/]
DFA0_-813618501 -->|"v"|DFA1_-538958876
DFA1_-538958876 -->|"e"|DFA2_-522976500
DFA2_-522976500 -->|"c"|DFA3_347598921
DFA3_347598921 -->|"3"|DFA4_-1914114789
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
subgraph MiniDFA0_-306835249["MiniDFA0 {1}"]
DFA0_-813618501_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1786699413["MiniDFA1 {1}"]
DFA1_-538958876_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1580746026["MiniDFA2 {1}"]
DFA2_-522976500_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-632482368["MiniDFA3 {1}"]
DFA3_347598921_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_799713665["MiniDFA4 {1}"]
DFA4_-1914114789_4[\"DFA4 {1}"/]
end
MiniDFA0_-306835249 -->|"v"|MiniDFA1_-1786699413
MiniDFA1_-1786699413 -->|"e"|MiniDFA2_-1580746026
MiniDFA2_-1580746026 -->|"c"|MiniDFA3_-632482368
MiniDFA3_-632482368 -->|"3"|MiniDFA4_799713665
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
MiniDFA0_-306835249(["MiniDFA0 {1}"])
MiniDFA1_-1786699413(["MiniDFA1 {1}"])
MiniDFA2_-1580746026(["MiniDFA2 {1}"])
MiniDFA3_-632482368(["MiniDFA3 {1}"])
MiniDFA4_799713665[\"MiniDFA4 {1}"/]
MiniDFA0_-306835249 -->|"v"|MiniDFA1_-1786699413
MiniDFA1_-1786699413 -->|"e"|MiniDFA2_-1580746026
MiniDFA2_-1580746026 -->|"c"|MiniDFA3_-632482368
MiniDFA3_-632482368 -->|"3"|MiniDFA4_799713665
```
-------------------------------
