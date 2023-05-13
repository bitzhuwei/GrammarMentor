# '%='

pattern: `%=`

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
eNFA40_4_34767408[["εNFA40-4 regex start"]]
eNFA40_0_44471219[["εNFA40-0 char{1, 1}"]]
eNFA40_1_64696659[["εNFA40-1 char[1]"]]
eNFA40_2_45399024[["εNFA40-2 char{1, 1}"]]
eNFA40_3_5938035[["εNFA40-3 char[1]"]]
eNFA40_5_53442317[["εNFA40-5 regex end"]]
eNFA40_6_11218807[["εNFA40-6 post-regex start"]]
eNFA40_7_33860402[\"εNFA40-7 post-regex end"/]
eNFA40_4_34767408 -.->|"ε"|eNFA40_0_44471219
eNFA40_0_44471219 -->|"%"|eNFA40_1_64696659
eNFA40_1_64696659 -.->|"ε"|eNFA40_2_45399024
eNFA40_2_45399024 -->|"="|eNFA40_3_5938035
eNFA40_3_5938035 -.->|"ε"|eNFA40_5_53442317
eNFA40_5_53442317 -.->|"ε"|eNFA40_6_11218807
eNFA40_6_11218807 -.->|"ε"|eNFA40_7_33860402
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
eNFA40_4_36308168[["εNFA40-4 regex start"]]
eNFA40_0_58338056[["εNFA40-0 char{1, 1}"]]
eNFA40_1_55280461[["εNFA40-1 char[1]"]]
eNFA40_2_27762102[["εNFA40-2 char{1, 1}"]]
eNFA40_3_48532334[\"εNFA40-3 char[1]"/]
eNFA40_5_34137829[\"εNFA40-5 regex end"/]
eNFA40_6_38805013[\"εNFA40-6 post-regex start"/]
eNFA40_7_13700797[\"εNFA40-7 post-regex end"/]
eNFA40_4_36308168 -.->|"ε"|eNFA40_0_58338056
eNFA40_4_36308168 -->|"%"|eNFA40_1_55280461
eNFA40_0_58338056 -->|"%"|eNFA40_1_55280461
eNFA40_1_55280461 -.->|"ε"|eNFA40_2_27762102
eNFA40_1_55280461 -->|"="|eNFA40_3_48532334
eNFA40_2_27762102 -->|"="|eNFA40_3_48532334
eNFA40_3_48532334 -.->|"ε"|eNFA40_5_34137829
eNFA40_3_48532334 -.->|"ε"|eNFA40_6_38805013
eNFA40_3_48532334 -.->|"ε"|eNFA40_7_13700797
eNFA40_5_34137829 -.->|"ε"|eNFA40_6_38805013
eNFA40_5_34137829 -.->|"ε"|eNFA40_7_13700797
eNFA40_6_38805013 -.->|"ε"|eNFA40_7_13700797
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
NFA40_4_56198311("NFA40-4 regex start")
NFA40_1_36022757("NFA40-1 char[1]")
NFA40_3_55769358[\"NFA40-3 char[1]"/]
NFA40_4_56198311 -->|"%"|NFA40_1_36022757
NFA40_1_36022757 -->|"="|NFA40_3_55769358
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
subgraph DFA0_728316478["DFA0 regex start"]
NFA40_4_56198311_0("NFA40-4 regex start")
end
subgraph DFA1_-849682251["DFA1 {1}"]
NFA40_1_36022757_1("NFA40-1 char[1]")
end
subgraph DFA2_-464885107["DFA2 {1}"]
NFA40_3_55769358_2[\"NFA40-3 char[1]"/]
end
DFA0_728316478 -->|"%"|DFA1_-849682251
DFA1_-849682251 -->|"="|DFA2_-464885107
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
DFA0_728316478{{"DFA0 regex start"}}
DFA1_-849682251{{"DFA1 {1}"}}
DFA2_-464885107[\"DFA2 {1}"/]
DFA0_728316478 -->|"%"|DFA1_-849682251
DFA1_-849682251 -->|"="|DFA2_-464885107
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
subgraph MiniDFA0_395511851["MiniDFA0 {1}"]
DFA0_728316478_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-500072357["MiniDFA1 {1}"]
DFA1_-849682251_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_688666537["MiniDFA2 {1}"]
DFA2_-464885107_2[\"DFA2 {1}"/]
end
MiniDFA0_395511851 -->|"%"|MiniDFA1_-500072357
MiniDFA1_-500072357 -->|"="|MiniDFA2_688666537
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
MiniDFA0_395511851(["MiniDFA0 {1}"])
MiniDFA1_-500072357(["MiniDFA1 {1}"])
MiniDFA2_688666537[\"MiniDFA2 {1}"/]
MiniDFA0_395511851 -->|"%"|MiniDFA1_-500072357
MiniDFA1_-500072357 -->|"="|MiniDFA2_688666537
```
-------------------------------
