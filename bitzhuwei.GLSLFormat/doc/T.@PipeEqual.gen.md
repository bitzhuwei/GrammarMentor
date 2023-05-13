# '|='

pattern: `\|=`

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
eNFA47_4_803253[["εNFA47-4 regex start"]]
eNFA47_0_7229285[["εNFA47-0 char{1, 1}"]]
eNFA47_1_65063572[["εNFA47-1 char[1]"]]
eNFA47_2_48701244[["εNFA47-2 char{1, 1}"]]
eNFA47_3_35658012[["εNFA47-3 char[1]"]]
eNFA47_5_52486654[["εNFA47-5 regex end"]]
eNFA47_6_2617844[["εNFA47-6 post-regex start"]]
eNFA47_7_23560597[\"εNFA47-7 post-regex end"/]
eNFA47_4_803253 -.->|"ε"|eNFA47_0_7229285
eNFA47_0_7229285 -->|"|"|eNFA47_1_65063572
eNFA47_1_65063572 -.->|"ε"|eNFA47_2_48701244
eNFA47_2_48701244 -->|"="|eNFA47_3_35658012
eNFA47_3_35658012 -.->|"ε"|eNFA47_5_52486654
eNFA47_5_52486654 -.->|"ε"|eNFA47_6_2617844
eNFA47_6_2617844 -.->|"ε"|eNFA47_7_23560597
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
eNFA47_4_10718788[["εNFA47-4 regex start"]]
eNFA47_0_29360233[["εNFA47-0 char{1, 1}"]]
eNFA47_1_62915509[["εNFA47-1 char[1]"]]
eNFA47_2_29368673[["εNFA47-2 char{1, 1}"]]
eNFA47_3_62991470[\"εNFA47-3 char[1]"/]
eNFA47_5_30052326[\"εNFA47-5 regex end"/]
eNFA47_6_2035480[\"εNFA47-6 post-regex start"/]
eNFA47_7_18319327[\"εNFA47-7 post-regex end"/]
eNFA47_4_10718788 -.->|"ε"|eNFA47_0_29360233
eNFA47_4_10718788 -->|"|"|eNFA47_1_62915509
eNFA47_0_29360233 -->|"|"|eNFA47_1_62915509
eNFA47_1_62915509 -.->|"ε"|eNFA47_2_29368673
eNFA47_1_62915509 -->|"="|eNFA47_3_62991470
eNFA47_2_29368673 -->|"="|eNFA47_3_62991470
eNFA47_3_62991470 -.->|"ε"|eNFA47_5_30052326
eNFA47_3_62991470 -.->|"ε"|eNFA47_6_2035480
eNFA47_3_62991470 -.->|"ε"|eNFA47_7_18319327
eNFA47_5_30052326 -.->|"ε"|eNFA47_6_2035480
eNFA47_5_30052326 -.->|"ε"|eNFA47_7_18319327
eNFA47_6_2035480 -.->|"ε"|eNFA47_7_18319327
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
NFA47_4_30656219("NFA47-4 regex start")
NFA47_1_7470517("NFA47-1 char[1]")
NFA47_3_125790[\"NFA47-3 char[1]"/]
NFA47_4_30656219 -->|"|"|NFA47_1_7470517
NFA47_1_7470517 -->|"="|NFA47_3_125790
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
subgraph DFA0_292578460["DFA0 regex start"]
NFA47_4_30656219_0("NFA47-4 regex start")
end
subgraph DFA1_-1104062850["DFA1 {1}"]
NFA47_1_7470517_1("NFA47-1 char[1]")
end
subgraph DFA2_-85318649["DFA2 {1}"]
NFA47_3_125790_2[\"NFA47-3 char[1]"/]
end
DFA0_292578460 -->|"|"|DFA1_-1104062850
DFA1_-1104062850 -->|"="|DFA2_-85318649
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
DFA0_292578460{{"DFA0 regex start"}}
DFA1_-1104062850{{"DFA1 {1}"}}
DFA2_-85318649[\"DFA2 {1}"/]
DFA0_292578460 -->|"|"|DFA1_-1104062850
DFA1_-1104062850 -->|"="|DFA2_-85318649
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
subgraph MiniDFA0_-928022044["MiniDFA0 {1}"]
DFA0_292578460_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1694060228["MiniDFA1 {1}"]
DFA1_-1104062850_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-394378734["MiniDFA2 {1}"]
DFA2_-85318649_2[\"DFA2 {1}"/]
end
MiniDFA0_-928022044 -->|"|"|MiniDFA1_-1694060228
MiniDFA1_-1694060228 -->|"="|MiniDFA2_-394378734
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
MiniDFA0_-928022044(["MiniDFA0 {1}"])
MiniDFA1_-1694060228(["MiniDFA1 {1}"])
MiniDFA2_-394378734[\"MiniDFA2 {1}"/]
MiniDFA0_-928022044 -->|"|"|MiniDFA1_-1694060228
MiniDFA1_-1694060228 -->|"="|MiniDFA2_-394378734
```
-------------------------------
