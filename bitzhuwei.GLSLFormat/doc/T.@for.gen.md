# 'for'

pattern: `for`

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
eNFA204_6_23538684[["εNFA204-6 regex start"]]
eNFA204_0_10521569[["εNFA204-0 char{1, 1}"]]
eNFA204_1_27585257[["εNFA204-1 char[1]"]]
eNFA204_2_46940727[["εNFA204-2 char{1, 1}"]]
eNFA204_3_19813363[["εNFA204-3 char[1]"]]
eNFA204_4_44102542[["εNFA204-4 char{1, 1}"]]
eNFA204_5_61378561[["εNFA204-5 char[1]"]]
eNFA204_7_15536141[["εNFA204-7 regex end"]]
eNFA204_8_5607548[["εNFA204-8 post-regex start"]]
eNFA204_9_50467933[\"εNFA204-9 post-regex end"/]
eNFA204_6_23538684 -.->|"ε"|eNFA204_0_10521569
eNFA204_0_10521569 -->|"f"|eNFA204_1_27585257
eNFA204_1_27585257 -.->|"ε"|eNFA204_2_46940727
eNFA204_2_46940727 -->|"o"|eNFA204_3_19813363
eNFA204_3_19813363 -.->|"ε"|eNFA204_4_44102542
eNFA204_4_44102542 -->|"r"|eNFA204_5_61378561
eNFA204_5_61378561 -.->|"ε"|eNFA204_7_15536141
eNFA204_7_15536141 -.->|"ε"|eNFA204_8_5607548
eNFA204_8_5607548 -.->|"ε"|eNFA204_9_50467933
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
eNFA204_6_51558219[["εNFA204-6 regex start"]]
eNFA204_0_61370790[["εNFA204-0 char{1, 1}"]]
eNFA204_1_15466199[["εNFA204-1 char[1]"]]
eNFA204_2_4978063[["εNFA204-2 char{1, 1}"]]
eNFA204_3_44802567[["εNFA204-3 char[1]"]]
eNFA204_4_569920[["εNFA204-4 char{1, 1}"]]
eNFA204_5_5129283[\"εNFA204-5 char[1]"/]
eNFA204_7_46163554[\"εNFA204-7 regex end"/]
eNFA204_8_12818804[\"εNFA204-8 post-regex start"/]
eNFA204_9_48260380[\"εNFA204-9 post-regex end"/]
eNFA204_6_51558219 -.->|"ε"|eNFA204_0_61370790
eNFA204_6_51558219 -->|"f"|eNFA204_1_15466199
eNFA204_0_61370790 -->|"f"|eNFA204_1_15466199
eNFA204_1_15466199 -.->|"ε"|eNFA204_2_4978063
eNFA204_1_15466199 -->|"o"|eNFA204_3_44802567
eNFA204_2_4978063 -->|"o"|eNFA204_3_44802567
eNFA204_3_44802567 -.->|"ε"|eNFA204_4_569920
eNFA204_3_44802567 -->|"r"|eNFA204_5_5129283
eNFA204_4_569920 -->|"r"|eNFA204_5_5129283
eNFA204_5_5129283 -.->|"ε"|eNFA204_7_46163554
eNFA204_5_5129283 -.->|"ε"|eNFA204_8_12818804
eNFA204_5_5129283 -.->|"ε"|eNFA204_9_48260380
eNFA204_7_46163554 -.->|"ε"|eNFA204_8_12818804
eNFA204_7_46163554 -.->|"ε"|eNFA204_9_48260380
eNFA204_8_12818804 -.->|"ε"|eNFA204_9_48260380
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
NFA204_6_31690242("NFA204-6 regex start")
NFA204_1_16776727("NFA204-1 char[1]")
NFA204_3_16772820("NFA204-3 char[1]")
NFA204_5_16737659[\"NFA204-5 char[1]"/]
NFA204_6_31690242 -->|"f"|NFA204_1_16776727
NFA204_1_16776727 -->|"o"|NFA204_3_16772820
NFA204_3_16772820 -->|"r"|NFA204_5_16737659
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
subgraph DFA0_1330613153["DFA0 regex start"]
NFA204_6_31690242_0("NFA204-6 regex start")
end
subgraph DFA1_-319646992["DFA1 {1}"]
NFA204_1_16776727_1("NFA204-1 char[1]")
end
subgraph DFA2_431936777["DFA2 {1}"]
NFA204_3_16772820_2("NFA204-3 char[1]")
end
subgraph DFA3_-630985386["DFA3 {1}"]
NFA204_5_16737659_3[\"NFA204-5 char[1]"/]
end
DFA0_1330613153 -->|"f"|DFA1_-319646992
DFA1_-319646992 -->|"o"|DFA2_431936777
DFA2_431936777 -->|"r"|DFA3_-630985386
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
DFA0_1330613153{{"DFA0 regex start"}}
DFA1_-319646992{{"DFA1 {1}"}}
DFA2_431936777{{"DFA2 {1}"}}
DFA3_-630985386[\"DFA3 {1}"/]
DFA0_1330613153 -->|"f"|DFA1_-319646992
DFA1_-319646992 -->|"o"|DFA2_431936777
DFA2_431936777 -->|"r"|DFA3_-630985386
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
subgraph MiniDFA0_-743125574["MiniDFA0 {1}"]
DFA0_1330613153_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-650259889["MiniDFA1 {1}"]
DFA1_-319646992_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2095619408["MiniDFA2 {1}"]
DFA2_431936777_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_981410541["MiniDFA3 {1}"]
DFA3_-630985386_3[\"DFA3 {1}"/]
end
MiniDFA0_-743125574 -->|"f"|MiniDFA1_-650259889
MiniDFA1_-650259889 -->|"o"|MiniDFA2_-2095619408
MiniDFA2_-2095619408 -->|"r"|MiniDFA3_981410541
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
MiniDFA0_-743125574(["MiniDFA0 {1}"])
MiniDFA1_-650259889(["MiniDFA1 {1}"])
MiniDFA2_-2095619408(["MiniDFA2 {1}"])
MiniDFA3_981410541[\"MiniDFA3 {1}"/]
MiniDFA0_-743125574 -->|"f"|MiniDFA1_-650259889
MiniDFA1_-650259889 -->|"o"|MiniDFA2_-2095619408
MiniDFA2_-2095619408 -->|"r"|MiniDFA3_981410541
```
-------------------------------
