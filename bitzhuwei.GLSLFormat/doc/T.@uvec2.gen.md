# 'uvec2'

pattern: `uvec2`

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
eNFA92_10_32056062[["εNFA92-10 regex start"]]
eNFA92_0_20069106[["εNFA92-0 char{1, 1}"]]
eNFA92_1_46404226[["εNFA92-1 char[1]"]]
eNFA92_2_14984857[["εNFA92-2 char{1, 1}"]]
eNFA92_3_645991[["εNFA92-3 char[1]"]]
eNFA92_4_5813925[["εNFA92-4 char{1, 1}"]]
eNFA92_5_52325333[["εNFA92-5 char[1]"]]
eNFA92_6_1165950[["εNFA92-6 char{1, 1}"]]
eNFA92_7_10493555[["εNFA92-7 char[1]"]]
eNFA92_8_27333131[["εNFA92-8 char{1, 1}"]]
eNFA92_9_44671593[["εNFA92-9 char[1]"]]
eNFA92_11_66500021[["εNFA92-11 regex end"]]
eNFA92_12_61629280[["εNFA92-12 post-regex start"]]
eNFA92_13_17792611[\"εNFA92-13 post-regex end"/]
eNFA92_10_32056062 -.->|"ε"|eNFA92_0_20069106
eNFA92_0_20069106 -->|"u"|eNFA92_1_46404226
eNFA92_1_46404226 -.->|"ε"|eNFA92_2_14984857
eNFA92_2_14984857 -->|"v"|eNFA92_3_645991
eNFA92_3_645991 -.->|"ε"|eNFA92_4_5813925
eNFA92_4_5813925 -->|"e"|eNFA92_5_52325333
eNFA92_5_52325333 -.->|"ε"|eNFA92_6_1165950
eNFA92_6_1165950 -->|"c"|eNFA92_7_10493555
eNFA92_7_10493555 -.->|"ε"|eNFA92_8_27333131
eNFA92_8_27333131 -->|"2"|eNFA92_9_44671593
eNFA92_9_44671593 -.->|"ε"|eNFA92_11_66500021
eNFA92_11_66500021 -.->|"ε"|eNFA92_12_61629280
eNFA92_12_61629280 -.->|"ε"|eNFA92_13_17792611
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
eNFA92_10_25915775[["εNFA92-10 regex start"]]
eNFA92_0_31915390[["εNFA92-0 char{1, 1}"]]
eNFA92_1_18803055[["εNFA92-1 char[1]"]]
eNFA92_2_35009773[["εNFA92-2 char{1, 1}"]]
eNFA92_3_46652504[["εNFA92-3 char[1]"]]
eNFA92_4_17219353[["εNFA92-4 char{1, 1}"]]
eNFA92_5_20756449[["εNFA92-5 char[1]"]]
eNFA92_6_52590313[["εNFA92-6 char{1, 1}"]]
eNFA92_7_3550770[["εNFA92-7 char[1]"]]
eNFA92_8_31956933[["εNFA92-8 char{1, 1}"]]
eNFA92_9_19176948[\"εNFA92-9 char[1]"/]
eNFA92_11_38374806[\"εNFA92-11 regex end"/]
eNFA92_12_9828942[\"εNFA92-12 post-regex start"/]
eNFA92_13_21351620[\"εNFA92-13 post-regex end"/]
eNFA92_10_25915775 -.->|"ε"|eNFA92_0_31915390
eNFA92_10_25915775 -->|"u"|eNFA92_1_18803055
eNFA92_0_31915390 -->|"u"|eNFA92_1_18803055
eNFA92_1_18803055 -.->|"ε"|eNFA92_2_35009773
eNFA92_1_18803055 -->|"v"|eNFA92_3_46652504
eNFA92_2_35009773 -->|"v"|eNFA92_3_46652504
eNFA92_3_46652504 -.->|"ε"|eNFA92_4_17219353
eNFA92_3_46652504 -->|"e"|eNFA92_5_20756449
eNFA92_4_17219353 -->|"e"|eNFA92_5_20756449
eNFA92_5_20756449 -.->|"ε"|eNFA92_6_52590313
eNFA92_5_20756449 -->|"c"|eNFA92_7_3550770
eNFA92_6_52590313 -->|"c"|eNFA92_7_3550770
eNFA92_7_3550770 -.->|"ε"|eNFA92_8_31956933
eNFA92_7_3550770 -->|"2"|eNFA92_9_19176948
eNFA92_8_31956933 -->|"2"|eNFA92_9_19176948
eNFA92_9_19176948 -.->|"ε"|eNFA92_11_38374806
eNFA92_9_19176948 -.->|"ε"|eNFA92_12_9828942
eNFA92_9_19176948 -.->|"ε"|eNFA92_13_21351620
eNFA92_11_38374806 -.->|"ε"|eNFA92_12_9828942
eNFA92_11_38374806 -.->|"ε"|eNFA92_13_21351620
eNFA92_12_9828942 -.->|"ε"|eNFA92_13_21351620
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
NFA92_10_57946857("NFA92-10 regex start")
NFA92_1_51759670("NFA92-1 char[1]")
NFA92_3_63183853("NFA92-3 char[1]")
NFA92_5_31783765("NFA92-5 char[1]")
NFA92_7_17618432("NFA92-7 char[1]")
NFA92_9_24348168[\"NFA92-9 char[1]"/]
NFA92_10_57946857 -->|"u"|NFA92_1_51759670
NFA92_1_51759670 -->|"v"|NFA92_3_63183853
NFA92_3_63183853 -->|"e"|NFA92_5_31783765
NFA92_5_31783765 -->|"c"|NFA92_7_17618432
NFA92_7_17618432 -->|"2"|NFA92_9_24348168
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
subgraph DFA0_-1890378138["DFA0 regex start"]
NFA92_10_57946857_0("NFA92-10 regex start")
end
subgraph DFA1_-256368726["DFA1 {1}"]
NFA92_1_51759670_1("NFA92-1 char[1]")
end
subgraph DFA2_-1814620484["DFA2 {1}"]
NFA92_3_63183853_2("NFA92-3 char[1]")
end
subgraph DFA3_733493816["DFA3 {1}"]
NFA92_5_31783765_3("NFA92-5 char[1]")
end
subgraph DFA4_540133901["DFA4 {1}"]
NFA92_7_17618432_4("NFA92-7 char[1]")
end
subgraph DFA5_1141897111["DFA5 {1}"]
NFA92_9_24348168_5[\"NFA92-9 char[1]"/]
end
DFA0_-1890378138 -->|"u"|DFA1_-256368726
DFA1_-256368726 -->|"v"|DFA2_-1814620484
DFA2_-1814620484 -->|"e"|DFA3_733493816
DFA3_733493816 -->|"c"|DFA4_540133901
DFA4_540133901 -->|"2"|DFA5_1141897111
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
DFA0_-1890378138{{"DFA0 regex start"}}
DFA1_-256368726{{"DFA1 {1}"}}
DFA2_-1814620484{{"DFA2 {1}"}}
DFA3_733493816{{"DFA3 {1}"}}
DFA4_540133901{{"DFA4 {1}"}}
DFA5_1141897111[\"DFA5 {1}"/]
DFA0_-1890378138 -->|"u"|DFA1_-256368726
DFA1_-256368726 -->|"v"|DFA2_-1814620484
DFA2_-1814620484 -->|"e"|DFA3_733493816
DFA3_733493816 -->|"c"|DFA4_540133901
DFA4_540133901 -->|"2"|DFA5_1141897111
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
subgraph MiniDFA0_-1375957261["MiniDFA0 {1}"]
DFA0_-1890378138_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_247555778["MiniDFA1 {1}"]
DFA1_-256368726_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-863651461["MiniDFA2 {1}"]
DFA2_-1814620484_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1944359348["MiniDFA3 {1}"]
DFA3_733493816_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_141060373["MiniDFA4 {1}"]
DFA4_540133901_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1868833915["MiniDFA5 {1}"]
DFA5_1141897111_5[\"DFA5 {1}"/]
end
MiniDFA0_-1375957261 -->|"u"|MiniDFA1_247555778
MiniDFA1_247555778 -->|"v"|MiniDFA2_-863651461
MiniDFA2_-863651461 -->|"e"|MiniDFA3_-1944359348
MiniDFA3_-1944359348 -->|"c"|MiniDFA4_141060373
MiniDFA4_141060373 -->|"2"|MiniDFA5_-1868833915
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
MiniDFA0_-1375957261(["MiniDFA0 {1}"])
MiniDFA1_247555778(["MiniDFA1 {1}"])
MiniDFA2_-863651461(["MiniDFA2 {1}"])
MiniDFA3_-1944359348(["MiniDFA3 {1}"])
MiniDFA4_141060373(["MiniDFA4 {1}"])
MiniDFA5_-1868833915[\"MiniDFA5 {1}"/]
MiniDFA0_-1375957261 -->|"u"|MiniDFA1_247555778
MiniDFA1_247555778 -->|"v"|MiniDFA2_-863651461
MiniDFA2_-863651461 -->|"e"|MiniDFA3_-1944359348
MiniDFA3_-1944359348 -->|"c"|MiniDFA4_141060373
MiniDFA4_141060373 -->|"2"|MiniDFA5_-1868833915
```
-------------------------------
