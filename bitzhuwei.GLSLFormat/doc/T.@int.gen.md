# 'int'

pattern: `int`

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
eNFA77_6_19140135[["εNFA77-6 regex start"]]
eNFA77_0_38043494[["εNFA77-0 char{1, 1}"]]
eNFA77_1_6847126[["εNFA77-1 char[1]"]]
eNFA77_2_61624137[["εNFA77-2 char{1, 1}"]]
eNFA77_3_17746329[["εNFA77-3 char[1]"]]
eNFA77_4_25499238[["εNFA77-4 char{1, 1}"]]
eNFA77_5_28166553[["εNFA77-5 char[1]"]]
eNFA77_7_52172387[["εNFA77-7 regex end"]]
eNFA77_8_66898301[["εNFA77-8 post-regex start"]]
eNFA77_9_65213800[\"εNFA77-9 post-regex end"/]
eNFA77_6_19140135 -.->|"ε"|eNFA77_0_38043494
eNFA77_0_38043494 -->|"i"|eNFA77_1_6847126
eNFA77_1_6847126 -.->|"ε"|eNFA77_2_61624137
eNFA77_2_61624137 -->|"n"|eNFA77_3_17746329
eNFA77_3_17746329 -.->|"ε"|eNFA77_4_25499238
eNFA77_4_25499238 -->|"t"|eNFA77_5_28166553
eNFA77_5_28166553 -.->|"ε"|eNFA77_7_52172387
eNFA77_7_52172387 -.->|"ε"|eNFA77_8_66898301
eNFA77_8_66898301 -.->|"ε"|eNFA77_9_65213800
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
eNFA77_6_50053294[["εNFA77-6 regex start"]]
eNFA77_0_47826462[["εNFA77-0 char{1, 1}"]]
eNFA77_1_27784979[["εNFA77-1 char[1]"]]
eNFA77_2_48738220[["εNFA77-2 char{1, 1}"]]
eNFA77_3_35990804[["εNFA77-3 char[1]"]]
eNFA77_4_55481787[["εNFA77-4 char{1, 1}"]]
eNFA77_5_29574043[\"εNFA77-5 char[1]"/]
eNFA77_7_64839795[\"εNFA77-7 regex end"/]
eNFA77_8_46687245[\"εNFA77-8 post-regex start"/]
eNFA77_9_17532027[\"εNFA77-9 post-regex end"/]
eNFA77_6_50053294 -.->|"ε"|eNFA77_0_47826462
eNFA77_6_50053294 -->|"i"|eNFA77_1_27784979
eNFA77_0_47826462 -->|"i"|eNFA77_1_27784979
eNFA77_1_27784979 -.->|"ε"|eNFA77_2_48738220
eNFA77_1_27784979 -->|"n"|eNFA77_3_35990804
eNFA77_2_48738220 -->|"n"|eNFA77_3_35990804
eNFA77_3_35990804 -.->|"ε"|eNFA77_4_55481787
eNFA77_3_35990804 -->|"t"|eNFA77_5_29574043
eNFA77_4_55481787 -->|"t"|eNFA77_5_29574043
eNFA77_5_29574043 -.->|"ε"|eNFA77_7_64839795
eNFA77_5_29574043 -.->|"ε"|eNFA77_8_46687245
eNFA77_5_29574043 -.->|"ε"|eNFA77_9_17532027
eNFA77_7_64839795 -.->|"ε"|eNFA77_8_46687245
eNFA77_7_64839795 -.->|"ε"|eNFA77_9_17532027
eNFA77_8_46687245 -.->|"ε"|eNFA77_9_17532027
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
NFA77_6_23570516("NFA77-6 regex start")
NFA77_1_10808059("NFA77-1 char[1]")
NFA77_3_30163672("NFA77-3 char[1]")
NFA77_5_3037596[\"NFA77-5 char[1]"/]
NFA77_6_23570516 -->|"i"|NFA77_1_10808059
NFA77_1_10808059 -->|"n"|NFA77_3_30163672
NFA77_3_30163672 -->|"t"|NFA77_5_3037596
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
subgraph DFA0_-2087967305["DFA0 regex start"]
NFA77_6_23570516_0("NFA77-6 regex start")
end
subgraph DFA1_-180510563["DFA1 {1}"]
NFA77_1_10808059_1("NFA77-1 char[1]")
end
subgraph DFA2_1420584875["DFA2 {1}"]
NFA77_3_30163672_2("NFA77-3 char[1]")
end
subgraph DFA3_-902397154["DFA3 {1}"]
NFA77_5_3037596_3[\"NFA77-5 char[1]"/]
end
DFA0_-2087967305 -->|"i"|DFA1_-180510563
DFA1_-180510563 -->|"n"|DFA2_1420584875
DFA2_1420584875 -->|"t"|DFA3_-902397154
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
DFA0_-2087967305{{"DFA0 regex start"}}
DFA1_-180510563{{"DFA1 {1}"}}
DFA2_1420584875{{"DFA2 {1}"}}
DFA3_-902397154[\"DFA3 {1}"/]
DFA0_-2087967305 -->|"i"|DFA1_-180510563
DFA1_-180510563 -->|"n"|DFA2_1420584875
DFA2_1420584875 -->|"t"|DFA3_-902397154
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
subgraph MiniDFA0_-1425435070["MiniDFA0 {1}"]
DFA0_-2087967305_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-226403281["MiniDFA1 {1}"]
DFA1_-180510563_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-953801369["MiniDFA2 {1}"]
DFA2_1420584875_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_766341810["MiniDFA3 {1}"]
DFA3_-902397154_3[\"DFA3 {1}"/]
end
MiniDFA0_-1425435070 -->|"i"|MiniDFA1_-226403281
MiniDFA1_-226403281 -->|"n"|MiniDFA2_-953801369
MiniDFA2_-953801369 -->|"t"|MiniDFA3_766341810
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
MiniDFA0_-1425435070(["MiniDFA0 {1}"])
MiniDFA1_-226403281(["MiniDFA1 {1}"])
MiniDFA2_-953801369(["MiniDFA2 {1}"])
MiniDFA3_766341810[\"MiniDFA3 {1}"/]
MiniDFA0_-1425435070 -->|"i"|MiniDFA1_-226403281
MiniDFA1_-226403281 -->|"n"|MiniDFA2_-953801369
MiniDFA2_-953801369 -->|"t"|MiniDFA3_766341810
```
-------------------------------
