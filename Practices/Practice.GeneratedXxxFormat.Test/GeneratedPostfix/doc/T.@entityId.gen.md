# 'entityId'

pattern: `[0-9]+/=`

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
eNFA1_2_16393485[["εNFA1-2 regex start"]]
eNFA1_0_13521789[["εNFA1-0 scope{1, ∞}"]]
eNFA1_1_46241663[["εNFA1-1 scope[1]"]]
eNFA1_3_54587245[["εNFA1-3 regex end"]]
eNFA1_6_49257430[["εNFA1-6 regex start"]]
eNFA1_4_40663687[["εNFA1-4 char{1, 1}"]]
eNFA1_5_30428869[["εNFA1-5 char[1]"]]
eNFA1_7_5424368[\"εNFA1-7 regex end"/]
eNFA1_2_16393485 -.->|"ε"|eNFA1_0_13521789
eNFA1_0_13521789 -->|"[0-9]"|eNFA1_1_46241663
eNFA1_1_46241663 -->|"[0-9]"|eNFA1_1_46241663
eNFA1_1_46241663 -.->|"ε"|eNFA1_3_54587245
eNFA1_3_54587245 -.->|"ε"|eNFA1_6_49257430
eNFA1_6_49257430 -.->|"ε"|eNFA1_4_40663687
eNFA1_4_40663687 -->|"="|eNFA1_5_30428869
eNFA1_5_30428869 -.->|"ε"|eNFA1_7_5424368
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
eNFA1_2_48819313[["εNFA1-2 regex start"]]
eNFA1_0_52803899[["εNFA1-0 scope{1, ∞}"]]
eNFA1_1_13323640[["εNFA1-1 scope[1]"]]
eNFA1_3_5473047[["εNFA1-3 regex end"]]
eNFA1_6_36720633[["εNFA1-6 regex start"]]
eNFA1_4_62050241[["εNFA1-4 char{1, 1}"]]
eNFA1_5_21581258[\"εNFA1-5 char[1]"/]
eNFA1_7_60013597[\"εNFA1-7 regex end"/]
eNFA1_2_48819313 -.->|"ε"|eNFA1_0_52803899
eNFA1_2_48819313 -->|"[0-9]"|eNFA1_1_13323640
eNFA1_0_52803899 -->|"[0-9]"|eNFA1_1_13323640
eNFA1_1_13323640 -->|"[0-9]"|eNFA1_1_13323640
eNFA1_1_13323640 -.->|"ε"|eNFA1_3_5473047
eNFA1_1_13323640 -.->|"ε"|eNFA1_6_36720633
eNFA1_1_13323640 -.->|"ε"|eNFA1_4_62050241
eNFA1_1_13323640 -->|"="|eNFA1_5_21581258
eNFA1_3_5473047 -.->|"ε"|eNFA1_6_36720633
eNFA1_3_5473047 -.->|"ε"|eNFA1_4_62050241
eNFA1_3_5473047 -->|"="|eNFA1_5_21581258
eNFA1_6_36720633 -.->|"ε"|eNFA1_4_62050241
eNFA1_6_36720633 -->|"="|eNFA1_5_21581258
eNFA1_4_62050241 -->|"="|eNFA1_5_21581258
eNFA1_5_21581258 -.->|"ε"|eNFA1_7_60013597
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
NFA1_2_29263214("NFA1-2 regex start")
NFA1_1_3251468("NFA1-1 scope[1]")
NFA1_5_62042342[\"NFA1-5 char[1]"/]
NFA1_2_29263214 -->|"[0-9]"|NFA1_1_3251468
NFA1_1_3251468 -->|"[0-9]"|NFA1_1_3251468
NFA1_1_3251468 -->|"="|NFA1_5_62042342
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
subgraph DFA0_-1152216815["DFA0 regex start"]
NFA1_2_29263214_0("NFA1-2 regex start")
end
subgraph DFA1_-87995955["DFA1 {1}"]
NFA1_1_3251468_1("NFA1-1 scope[1]")
end
subgraph DFA2_1436151300["DFA2 {1}"]
NFA1_5_62042342_2[\"NFA1-5 char[1]"/]
end
DFA0_-1152216815 -->|"[0-9]"|DFA1_-87995955
DFA1_-87995955 -->|"[0-9]"|DFA1_-87995955
DFA1_-87995955 -->|"="|DFA2_1436151300
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
DFA0_-1152216815{{"DFA0 regex start"}}
DFA1_-87995955{{"DFA1 {1}"}}
DFA2_1436151300[\"DFA2 {1}"/]
DFA0_-1152216815 -->|"[0-9]"|DFA1_-87995955
DFA1_-87995955 -->|"[0-9]"|DFA1_-87995955
DFA1_-87995955 -->|"="|DFA2_1436151300
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
subgraph MiniDFA0_857901919["MiniDFA0 {1}"]
DFA0_-1152216815_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1950242821["MiniDFA1 {1}"]
DFA1_-87995955_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1123410186["MiniDFA2 {1}"]
DFA2_1436151300_2[\"DFA2 {1}"/]
end
MiniDFA0_857901919 -->|"[0-9]"|MiniDFA1_-1950242821
MiniDFA1_-1950242821 -->|"[0-9]"|MiniDFA1_-1950242821
MiniDFA1_-1950242821 -->|"="|MiniDFA2_1123410186
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
MiniDFA0_857901919(["MiniDFA0 {1}"])
MiniDFA1_-1950242821(["MiniDFA1 {1}"])
MiniDFA2_1123410186[\"MiniDFA2 {1}"/]
MiniDFA0_857901919 -->|"[0-9]"|MiniDFA1_-1950242821
MiniDFA1_-1950242821 -->|"[0-9]"|MiniDFA1_-1950242821
MiniDFA1_-1950242821 -->|"="|MiniDFA2_1123410186
```
-------------------------------
