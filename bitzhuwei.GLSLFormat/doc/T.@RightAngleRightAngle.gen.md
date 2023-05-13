# '>>'

pattern: `\>\>`

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
eNFA22_4_50570707[["εNFA22-4 regex start"]]
eNFA22_0_52483186[["εNFA22-0 char{1, 1}"]]
eNFA22_1_2586631[["εNFA22-1 char[1]"]]
eNFA22_2_23279683[["εNFA22-2 char{1, 1}"]]
eNFA22_3_8190559[["εNFA22-3 char[1]"]]
eNFA22_5_6606172[["εNFA22-5 regex end"]]
eNFA22_6_59455556[["εNFA22-6 post-regex start"]]
eNFA22_7_65337958[\"εNFA22-7 post-regex end"/]
eNFA22_4_50570707 -.->|"ε"|eNFA22_0_52483186
eNFA22_0_52483186 -->|">"|eNFA22_1_2586631
eNFA22_1_2586631 -.->|"ε"|eNFA22_2_23279683
eNFA22_2_23279683 -->|">"|eNFA22_3_8190559
eNFA22_3_8190559 -.->|"ε"|eNFA22_5_6606172
eNFA22_5_6606172 -.->|"ε"|eNFA22_6_59455556
eNFA22_6_59455556 -.->|"ε"|eNFA22_7_65337958
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
eNFA22_4_51170717[["εNFA22-4 regex start"]]
eNFA22_0_57883273[["εNFA22-0 char{1, 1}"]]
eNFA22_1_51187411[["εNFA22-1 char[1]"]]
eNFA22_2_58033516[["εNFA22-2 char{1, 1}"]]
eNFA22_3_52539597[\"εNFA22-3 char[1]"/]
eNFA22_5_3094327[\"εNFA22-5 regex end"/]
eNFA22_6_27848947[\"εNFA22-6 post-regex start"/]
eNFA22_7_49313939[\"εNFA22-7 post-regex end"/]
eNFA22_4_51170717 -.->|"ε"|eNFA22_0_57883273
eNFA22_4_51170717 -->|">"|eNFA22_1_51187411
eNFA22_0_57883273 -->|">"|eNFA22_1_51187411
eNFA22_1_51187411 -.->|"ε"|eNFA22_2_58033516
eNFA22_1_51187411 -->|">"|eNFA22_3_52539597
eNFA22_2_58033516 -->|">"|eNFA22_3_52539597
eNFA22_3_52539597 -.->|"ε"|eNFA22_5_3094327
eNFA22_3_52539597 -.->|"ε"|eNFA22_6_27848947
eNFA22_3_52539597 -.->|"ε"|eNFA22_7_49313939
eNFA22_5_3094327 -.->|"ε"|eNFA22_6_27848947
eNFA22_5_3094327 -.->|"ε"|eNFA22_7_49313939
eNFA22_6_27848947 -.->|"ε"|eNFA22_7_49313939
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
NFA22_4_41172271("NFA22-4 regex start")
NFA22_1_35006119("NFA22-1 char[1]")
NFA22_3_46619622[\"NFA22-3 char[1]"/]
NFA22_4_41172271 -->|">"|NFA22_1_35006119
NFA22_1_35006119 -->|">"|NFA22_3_46619622
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
subgraph DFA0_-651167531["DFA0 regex start"]
NFA22_4_41172271_0("NFA22-4 regex start")
end
subgraph DFA1_-296791498["DFA1 {1}"]
NFA22_1_35006119_1("NFA22-1 char[1]")
end
subgraph DFA2_2015969506["DFA2 {1}"]
NFA22_3_46619622_2[\"NFA22-3 char[1]"/]
end
DFA0_-651167531 -->|">"|DFA1_-296791498
DFA1_-296791498 -->|">"|DFA2_2015969506
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
DFA0_-651167531{{"DFA0 regex start"}}
DFA1_-296791498{{"DFA1 {1}"}}
DFA2_2015969506[\"DFA2 {1}"/]
DFA0_-651167531 -->|">"|DFA1_-296791498
DFA1_-296791498 -->|">"|DFA2_2015969506
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
subgraph MiniDFA0_171658950["MiniDFA0 {1}"]
DFA0_-651167531_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-242973206["MiniDFA1 {1}"]
DFA1_-296791498_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1658801140["MiniDFA2 {1}"]
DFA2_2015969506_2[\"DFA2 {1}"/]
end
MiniDFA0_171658950 -->|">"|MiniDFA1_-242973206
MiniDFA1_-242973206 -->|">"|MiniDFA2_-1658801140
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
MiniDFA0_171658950(["MiniDFA0 {1}"])
MiniDFA1_-242973206(["MiniDFA1 {1}"])
MiniDFA2_-1658801140[\"MiniDFA2 {1}"/]
MiniDFA0_171658950 -->|">"|MiniDFA1_-242973206
MiniDFA1_-242973206 -->|">"|MiniDFA2_-1658801140
```
-------------------------------
