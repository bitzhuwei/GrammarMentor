# 'Vn'

pattern: `[a-zA-Z_][a-zA-Z0-9_]*`

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
eNFA1_3_44654309[["εNFA1-3 regex start"]]
eNFA1_0_66344464[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_37320193[["εNFA1-1 scope[1]"]]
eNFA1_2_33972849[["εNFA1-2 scope{0, ∞}"]]
eNFA1_4_337422[["εNFA1-4 regex end"]]
eNFA1_5_17940820[["εNFA1-5 post-regex start"]]
eNFA1_6_27249660[\"εNFA1-6 post-regex end"/]
eNFA1_3_44654309 -.->|"ε"|eNFA1_0_66344464
eNFA1_0_66344464 -->|"[a-zA-Z_]"|eNFA1_1_37320193
eNFA1_1_37320193 -.->|"ε"|eNFA1_2_33972849
eNFA1_2_33972849 -->|"[a-zA-Z0-9_]"|eNFA1_2_33972849
eNFA1_2_33972849 -.->|"ε"|eNFA1_4_337422
eNFA1_4_337422 -.->|"ε"|eNFA1_5_17940820
eNFA1_5_17940820 -.->|"ε"|eNFA1_6_27249660
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
eNFA1_3_43920355[["εNFA1-3 regex start"]]
eNFA1_0_59738883[["εNFA1-0 scope{1, 1}"]]
eNFA1_1_5192518[\"εNFA1-1 scope[1]"/]
eNFA1_2_60229270[\"εNFA1-2 scope{0, ∞}"/]
eNFA1_4_46732667[\"εNFA1-4 regex end"/]
eNFA1_5_779035[\"εNFA1-5 post-regex start"/]
eNFA1_6_7011317[\"εNFA1-6 post-regex end"/]
eNFA1_3_43920355 -.->|"ε"|eNFA1_0_59738883
eNFA1_3_43920355 -->|"[a-zA-Z_]"|eNFA1_1_5192518
eNFA1_0_59738883 -->|"[a-zA-Z_]"|eNFA1_1_5192518
eNFA1_1_5192518 -.->|"ε"|eNFA1_2_60229270
eNFA1_1_5192518 -->|"[a-zA-Z0-9_]"|eNFA1_2_60229270
eNFA1_1_5192518 -.->|"ε"|eNFA1_4_46732667
eNFA1_1_5192518 -.->|"ε"|eNFA1_5_779035
eNFA1_1_5192518 -.->|"ε"|eNFA1_6_7011317
eNFA1_2_60229270 -->|"[a-zA-Z0-9_]"|eNFA1_2_60229270
eNFA1_2_60229270 -.->|"ε"|eNFA1_4_46732667
eNFA1_2_60229270 -.->|"ε"|eNFA1_5_779035
eNFA1_2_60229270 -.->|"ε"|eNFA1_6_7011317
eNFA1_4_46732667 -.->|"ε"|eNFA1_5_779035
eNFA1_4_46732667 -.->|"ε"|eNFA1_6_7011317
eNFA1_5_779035 -.->|"ε"|eNFA1_6_7011317
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
NFA1_3_10976931("NFA1-3 regex start")
NFA1_1_31045820[\"NFA1-1 scope[1]"/]
NFA1_2_63101859[\"NFA1-2 scope{0, ∞}"/]
NFA1_3_10976931 -->|"[a-zA-Z_]"|NFA1_1_31045820
NFA1_1_31045820 -->|"[a-zA-Z0-9_]"|NFA1_2_63101859
NFA1_2_63101859 -->|"[a-zA-Z0-9_]"|NFA1_2_63101859
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
subgraph DFA0_-333610546["DFA0 regex start"]
NFA1_3_10976931_0("NFA1-3 regex start")
end
subgraph DFA1_-509263877["DFA1 {1}"]
NFA1_1_31045820_1[\"NFA1-1 scope[1]"/]
end
subgraph DFA2_1134210744["DFA2 {1}"]
NFA1_2_63101859_2[\"NFA1-2 scope{0, ∞}"/]
end
DFA0_-333610546 -->|"[a-zA-Z_]"|DFA1_-509263877
DFA1_-509263877 -->|"[a-zA-Z0-9_]"|DFA2_1134210744
DFA2_1134210744 -->|"[a-zA-Z0-9_]"|DFA2_1134210744
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
DFA0_-333610546{{"DFA0 regex start"}}
DFA1_-509263877[\"DFA1 {1}"/]
DFA2_1134210744[\"DFA2 {1}"/]
DFA0_-333610546 -->|"[a-zA-Z_]"|DFA1_-509263877
DFA1_-509263877 -->|"[a-zA-Z0-9_]"|DFA2_1134210744
DFA2_1134210744 -->|"[a-zA-Z0-9_]"|DFA2_1134210744
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
subgraph MiniDFA0_-878185653["MiniDFA0 {1}"]
DFA0_-333610546_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2074970200["MiniDFA1 {1}"]
DFA1_-509263877_1[\"DFA1 {1}"/]
end
subgraph MiniDFA2_1860195573["MiniDFA2 {1}"]
DFA2_1134210744_2[\"DFA2 {1}"/]
end
MiniDFA0_-878185653 -->|"[a-zA-Z_]"|MiniDFA1_2074970200
MiniDFA1_2074970200 -->|"[a-zA-Z0-9_]"|MiniDFA2_1860195573
MiniDFA2_1860195573 -->|"[a-zA-Z0-9_]"|MiniDFA2_1860195573
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
MiniDFA0_-878185653(["MiniDFA0 {1}"])
MiniDFA1_2074970200[\"MiniDFA1 {1}"/]
MiniDFA2_1860195573[\"MiniDFA2 {1}"/]
MiniDFA0_-878185653 -->|"[a-zA-Z_]"|MiniDFA1_2074970200
MiniDFA1_2074970200 -->|"[a-zA-Z0-9_]"|MiniDFA2_1860195573
MiniDFA2_1860195573 -->|"[a-zA-Z0-9_]"|MiniDFA2_1860195573
```
-------------------------------
