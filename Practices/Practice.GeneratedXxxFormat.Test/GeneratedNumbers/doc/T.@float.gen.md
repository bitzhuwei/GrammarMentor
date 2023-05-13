# 'float'

pattern: `[0-9]+\.[0-9]+`

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
eNFA2_6_2049614[["εNFA2-6 regex start"]]
eNFA2_0_38788406[["εNFA2-0 scope{1, ∞}"]]
eNFA2_1_26679444[["εNFA2-1 scope[1]"]]
eNFA2_2_13551336[["εNFA2-2 char{1, 1}"]]
eNFA2_3_25750510[["εNFA2-3 char[1]"]]
eNFA2_4_13921233[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_23916425[["εNFA2-5 scope[1]"]]
eNFA2_7_58182238[["εNFA2-7 regex end"]]
eNFA2_8_36086767[["εNFA2-8 post-regex start"]]
eNFA2_9_56345451[\"εNFA2-9 post-regex end"/]
eNFA2_6_2049614 -.->|"ε"|eNFA2_0_38788406
eNFA2_0_38788406 -->|"[0-9]"|eNFA2_1_26679444
eNFA2_1_26679444 -->|"[0-9]"|eNFA2_1_26679444
eNFA2_1_26679444 -.->|"ε"|eNFA2_2_13551336
eNFA2_2_13551336 -->|"."|eNFA2_3_25750510
eNFA2_3_25750510 -.->|"ε"|eNFA2_4_13921233
eNFA2_4_13921233 -->|"[0-9]"|eNFA2_5_23916425
eNFA2_5_23916425 -->|"[0-9]"|eNFA2_5_23916425
eNFA2_5_23916425 -.->|"ε"|eNFA2_7_58182238
eNFA2_7_58182238 -.->|"ε"|eNFA2_8_36086767
eNFA2_8_36086767 -.->|"ε"|eNFA2_9_56345451
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
eNFA2_6_37347016[["εNFA2-6 regex start"]]
eNFA2_0_31801078[["εNFA2-0 scope{1, ∞}"]]
eNFA2_1_18446534[["εNFA2-1 scope[1]"]]
eNFA2_2_17774248[["εNFA2-2 char{1, 1}"]]
eNFA2_3_578832[["εNFA2-3 char[1]"]]
eNFA2_4_5416542[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_30427999[\"εNFA2-5 scope[1]"/]
eNFA2_7_48748883[\"εNFA2-7 regex end"/]
eNFA2_8_5209490[\"εNFA2-8 post-regex start"/]
eNFA2_9_46885417[\"εNFA2-9 post-regex end"/]
eNFA2_6_37347016 -.->|"ε"|eNFA2_0_31801078
eNFA2_6_37347016 -->|"[0-9]"|eNFA2_1_18446534
eNFA2_0_31801078 -->|"[0-9]"|eNFA2_1_18446534
eNFA2_1_18446534 -->|"[0-9]"|eNFA2_1_18446534
eNFA2_1_18446534 -.->|"ε"|eNFA2_2_17774248
eNFA2_1_18446534 -->|"."|eNFA2_3_578832
eNFA2_2_17774248 -->|"."|eNFA2_3_578832
eNFA2_3_578832 -.->|"ε"|eNFA2_4_5416542
eNFA2_3_578832 -->|"[0-9]"|eNFA2_5_30427999
eNFA2_4_5416542 -->|"[0-9]"|eNFA2_5_30427999
eNFA2_5_30427999 -->|"[0-9]"|eNFA2_5_30427999
eNFA2_5_30427999 -.->|"ε"|eNFA2_7_48748883
eNFA2_5_30427999 -.->|"ε"|eNFA2_8_5209490
eNFA2_5_30427999 -.->|"ε"|eNFA2_9_46885417
eNFA2_7_48748883 -.->|"ε"|eNFA2_8_5209490
eNFA2_7_48748883 -.->|"ε"|eNFA2_9_46885417
eNFA2_8_5209490 -.->|"ε"|eNFA2_9_46885417
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
NFA2_6_39622431("NFA2-6 regex start")
NFA2_1_19315573("NFA2-1 scope[1]")
NFA2_3_21057560("NFA2-3 char[1]")
NFA2_5_55300313[\"NFA2-5 scope[1]"/]
NFA2_6_39622431 -->|"[0-9]"|NFA2_1_19315573
NFA2_1_19315573 -->|"[0-9]"|NFA2_1_19315573
NFA2_1_19315573 -->|"."|NFA2_3_21057560
NFA2_3_21057560 -->|"[0-9]"|NFA2_5_55300313
NFA2_5_55300313 -->|"[0-9]"|NFA2_5_55300313
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
subgraph DFA0_1679929951["DFA0 regex start"]
NFA2_6_39622431_0("NFA2-6 regex start")
end
subgraph DFA1_-475235210["DFA1 {1}"]
NFA2_1_19315573_1("NFA2-1 scope[1]")
end
subgraph DFA2_1188853750["DFA2 {1}"]
NFA2_3_21057560_2("NFA2-3 char[1]")
end
subgraph DFA3_1906304233["DFA3 {1}"]
NFA2_5_55300313_3[\"NFA2-5 scope[1]"/]
end
DFA0_1679929951 -->|"[0-9]"|DFA1_-475235210
DFA1_-475235210 -->|"[0-9]"|DFA1_-475235210
DFA1_-475235210 -->|"."|DFA2_1188853750
DFA2_1188853750 -->|"[0-9]"|DFA3_1906304233
DFA3_1906304233 -->|"[0-9]"|DFA3_1906304233
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
DFA0_1679929951{{"DFA0 regex start"}}
DFA1_-475235210{{"DFA1 {1}"}}
DFA2_1188853750{{"DFA2 {1}"}}
DFA3_1906304233[\"DFA3 {1}"/]
DFA0_1679929951 -->|"[0-9]"|DFA1_-475235210
DFA1_-475235210 -->|"[0-9]"|DFA1_-475235210
DFA1_-475235210 -->|"."|DFA2_1188853750
DFA2_1188853750 -->|"[0-9]"|DFA3_1906304233
DFA3_1906304233 -->|"[0-9]"|DFA3_1906304233
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
subgraph MiniDFA0_380502197["MiniDFA0 {1}"]
DFA0_1679929951_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1543376702["MiniDFA1 {1}"]
DFA1_-475235210_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2000214235["MiniDFA2 {1}"]
DFA2_1188853750_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1530855497["MiniDFA3 {1}"]
DFA3_1906304233_3[\"DFA3 {1}"/]
end
MiniDFA0_380502197 -->|"[0-9]"|MiniDFA1_1543376702
MiniDFA1_1543376702 -->|"[0-9]"|MiniDFA1_1543376702
MiniDFA1_1543376702 -->|"."|MiniDFA2_-2000214235
MiniDFA2_-2000214235 -->|"[0-9]"|MiniDFA3_1530855497
MiniDFA3_1530855497 -->|"[0-9]"|MiniDFA3_1530855497
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
MiniDFA0_380502197(["MiniDFA0 {1}"])
MiniDFA1_1543376702(["MiniDFA1 {1}"])
MiniDFA2_-2000214235(["MiniDFA2 {1}"])
MiniDFA3_1530855497[\"MiniDFA3 {1}"/]
MiniDFA0_380502197 -->|"[0-9]"|MiniDFA1_1543376702
MiniDFA1_1543376702 -->|"[0-9]"|MiniDFA1_1543376702
MiniDFA1_1543376702 -->|"."|MiniDFA2_-2000214235
MiniDFA2_-2000214235 -->|"[0-9]"|MiniDFA3_1530855497
MiniDFA3_1530855497 -->|"[0-9]"|MiniDFA3_1530855497
```
-------------------------------
