# 'inlineComment'

pattern: `\/\/.*`

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
eNFA8_5_51960593[["εNFA8-5 regex start"]]
eNFA8_0_64992155[["εNFA8-0 char{1, 1}"]]
eNFA8_1_48058489[["εNFA8-1 char[1]"]]
eNFA8_2_29873218[["εNFA8-2 char{1, 1}"]]
eNFA8_3_42946954[["εNFA8-3 char[1]"]]
eNFA8_4_27141505[["εNFA8-4 char{0, ∞}"]]
eNFA8_6_50978274[["εNFA8-6 regex end"]]
eNFA8_7_40305966[["εNFA8-7 post-regex start"]]
eNFA8_8_27209379[\"εNFA8-8 post-regex end"/]
eNFA8_5_51960593 -.->|"ε"|eNFA8_0_64992155
eNFA8_0_64992155 -->|"/"|eNFA8_1_48058489
eNFA8_1_48058489 -.->|"ε"|eNFA8_2_29873218
eNFA8_2_29873218 -->|"/"|eNFA8_3_42946954
eNFA8_3_42946954 -.->|"ε"|eNFA8_4_27141505
eNFA8_4_27141505 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_27141505
eNFA8_4_27141505 -.->|"ε"|eNFA8_6_50978274
eNFA8_6_50978274 -.->|"ε"|eNFA8_7_40305966
eNFA8_7_40305966 -.->|"ε"|eNFA8_8_27209379
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
eNFA8_5_43557827[["εNFA8-5 regex start"]]
eNFA8_0_56476125[["εNFA8-0 char{1, 1}"]]
eNFA8_1_38523084[["εNFA8-1 char[1]"]]
eNFA8_2_11163440[["εNFA8-2 char{1, 1}"]]
eNFA8_3_3811622[\"εNFA8-3 char[1]"/]
eNFA8_4_423513[\"εNFA8-4 char{0, ∞}"/]
eNFA8_6_34304602[\"εNFA8-6 regex end"/]
eNFA8_7_33362098[\"εNFA8-7 post-regex start"/]
eNFA8_8_31823427[\"εNFA8-8 post-regex end"/]
eNFA8_5_43557827 -.->|"ε"|eNFA8_0_56476125
eNFA8_5_43557827 -->|"/"|eNFA8_1_38523084
eNFA8_0_56476125 -->|"/"|eNFA8_1_38523084
eNFA8_1_38523084 -.->|"ε"|eNFA8_2_11163440
eNFA8_1_38523084 -->|"/"|eNFA8_3_3811622
eNFA8_2_11163440 -->|"/"|eNFA8_3_3811622
eNFA8_3_3811622 -.->|"ε"|eNFA8_4_423513
eNFA8_3_3811622 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_423513
eNFA8_3_3811622 -.->|"ε"|eNFA8_6_34304602
eNFA8_3_3811622 -.->|"ε"|eNFA8_7_33362098
eNFA8_3_3811622 -.->|"ε"|eNFA8_8_31823427
eNFA8_4_423513 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_423513
eNFA8_4_423513 -.->|"ε"|eNFA8_6_34304602
eNFA8_4_423513 -.->|"ε"|eNFA8_7_33362098
eNFA8_4_423513 -.->|"ε"|eNFA8_8_31823427
eNFA8_6_34304602 -.->|"ε"|eNFA8_7_33362098
eNFA8_6_34304602 -.->|"ε"|eNFA8_8_31823427
eNFA8_7_33362098 -.->|"ε"|eNFA8_8_31823427
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
NFA8_5_46720306("NFA8-5 regex start")
NFA8_1_17829578("NFA8-1 char[1]")
NFA8_3_27560766[\"NFA8-3 char[1]"/]
NFA8_4_17975388[\"NFA8-4 char{0, ∞}"/]
NFA8_5_46720306 -->|"/"|NFA8_1_17829578
NFA8_1_17829578 -->|"/"|NFA8_3_27560766
NFA8_3_27560766 -->|"[#92;t#92;r#32;-~]"|NFA8_4_17975388
NFA8_4_17975388 -->|"[#92;t#92;r#32;-~]"|NFA8_4_17975388
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
subgraph DFA0_812586648["DFA0 regex start"]
NFA8_5_46720306_0("NFA8-5 regex start")
end
subgraph DFA1_-1118323911["DFA1 {1}"]
NFA8_1_17829578_1("NFA8-1 char[1]")
end
subgraph DFA2_-1587498670["DFA2 {1}"]
NFA8_3_27560766_2[\"NFA8-3 char[1]"/]
end
subgraph DFA3_1493367361["DFA3 {1}"]
NFA8_4_17975388_3[\"NFA8-4 char{0, ∞}"/]
end
DFA0_812586648 -->|"/"|DFA1_-1118323911
DFA1_-1118323911 -->|"/"|DFA2_-1587498670
DFA2_-1587498670 -->|"[#92;t#92;r#32;-~]"|DFA3_1493367361
DFA3_1493367361 -->|"[#92;t#92;r#32;-~]"|DFA3_1493367361
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
DFA0_812586648{{"DFA0 regex start"}}
DFA1_-1118323911{{"DFA1 {1}"}}
DFA2_-1587498670[\"DFA2 {1}"/]
DFA3_1493367361[\"DFA3 {1}"/]
DFA0_812586648 -->|"/"|DFA1_-1118323911
DFA1_-1118323911 -->|"/"|DFA2_-1587498670
DFA2_-1587498670 -->|"[#92;t#92;r#32;-~]"|DFA3_1493367361
DFA3_1493367361 -->|"[#92;t#92;r#32;-~]"|DFA3_1493367361
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
subgraph MiniDFA0_230345308["MiniDFA0 {1}"]
DFA0_812586648_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_144462081["MiniDFA1 {1}"]
DFA1_-1118323911_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_2142514447["MiniDFA2 {1}"]
DFA2_-1587498670_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-1340371611["MiniDFA3 {1}"]
DFA3_1493367361_3[\"DFA3 {1}"/]
end
MiniDFA0_230345308 -->|"/"|MiniDFA1_144462081
MiniDFA1_144462081 -->|"/"|MiniDFA2_2142514447
MiniDFA2_2142514447 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1340371611
MiniDFA3_-1340371611 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1340371611
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
MiniDFA0_230345308(["MiniDFA0 {1}"])
MiniDFA1_144462081(["MiniDFA1 {1}"])
MiniDFA2_2142514447[\"MiniDFA2 {1}"/]
MiniDFA3_-1340371611[\"MiniDFA3 {1}"/]
MiniDFA0_230345308 -->|"/"|MiniDFA1_144462081
MiniDFA1_144462081 -->|"/"|MiniDFA2_2142514447
MiniDFA2_2142514447 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1340371611
MiniDFA3_-1340371611 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1340371611
```
-------------------------------
