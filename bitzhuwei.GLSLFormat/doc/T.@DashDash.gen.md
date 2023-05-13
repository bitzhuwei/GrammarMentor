# '--'

pattern: `\-\-`

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
eNFA11_4_54575646[["εNFA11-4 regex start"]]
eNFA11_0_21418771[["εNFA11-0 char{1, 1}"]]
eNFA11_1_58551215[["εNFA11-1 char[1]"]]
eNFA11_2_57198891[["εNFA11-2 char{1, 1}"]]
eNFA11_3_45027976[["εNFA11-3 char[1]"]]
eNFA11_5_2598608[["εNFA11-5 regex end"]]
eNFA11_6_23387474[["εNFA11-6 post-regex start"]]
eNFA11_7_9160681[\"εNFA11-7 post-regex end"/]
eNFA11_4_54575646 -.->|"ε"|eNFA11_0_21418771
eNFA11_0_21418771 -->|"-"|eNFA11_1_58551215
eNFA11_1_58551215 -.->|"ε"|eNFA11_2_57198891
eNFA11_2_57198891 -->|"-"|eNFA11_3_45027976
eNFA11_3_45027976 -.->|"ε"|eNFA11_5_2598608
eNFA11_5_2598608 -.->|"ε"|eNFA11_6_23387474
eNFA11_6_23387474 -.->|"ε"|eNFA11_7_9160681
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
eNFA11_4_15337269[["εNFA11-4 regex start"]]
eNFA11_0_3817695[["εNFA11-0 char{1, 1}"]]
eNFA11_1_34359256[["εNFA11-1 char[1]"]]
eNFA11_2_40797849[["εNFA11-2 char{1, 1}"]]
eNFA11_3_31636323[\"εNFA11-3 char[1]"/]
eNFA11_5_16291455[\"εNFA11-5 regex end"/]
eNFA11_6_12405375[\"εNFA11-6 post-regex start"/]
eNFA11_7_44539515[\"εNFA11-7 post-regex end"/]
eNFA11_4_15337269 -.->|"ε"|eNFA11_0_3817695
eNFA11_4_15337269 -->|"-"|eNFA11_1_34359256
eNFA11_0_3817695 -->|"-"|eNFA11_1_34359256
eNFA11_1_34359256 -.->|"ε"|eNFA11_2_40797849
eNFA11_1_34359256 -->|"-"|eNFA11_3_31636323
eNFA11_2_40797849 -->|"-"|eNFA11_3_31636323
eNFA11_3_31636323 -.->|"ε"|eNFA11_5_16291455
eNFA11_3_31636323 -.->|"ε"|eNFA11_6_12405375
eNFA11_3_31636323 -.->|"ε"|eNFA11_7_44539515
eNFA11_5_16291455 -.->|"ε"|eNFA11_6_12405375
eNFA11_5_16291455 -.->|"ε"|eNFA11_7_44539515
eNFA11_6_12405375 -.->|"ε"|eNFA11_7_44539515
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
NFA11_4_65311315("NFA11-4 regex start")
NFA11_1_50930930("NFA11-1 char[1]")
NFA11_3_55725192[\"NFA11-3 char[1]"/]
NFA11_4_65311315 -->|"-"|NFA11_1_50930930
NFA11_1_50930930 -->|"-"|NFA11_3_55725192
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
subgraph DFA0_1169976293["DFA0 regex start"]
NFA11_4_65311315_0("NFA11-4 regex start")
end
subgraph DFA1_-989187286["DFA1 {1}"]
NFA11_1_50930930_1("NFA11-1 char[1]")
end
subgraph DFA2_-1322012086["DFA2 {1}"]
NFA11_3_55725192_2[\"NFA11-3 char[1]"/]
end
DFA0_1169976293 -->|"-"|DFA1_-989187286
DFA1_-989187286 -->|"-"|DFA2_-1322012086
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
DFA0_1169976293{{"DFA0 regex start"}}
DFA1_-989187286{{"DFA1 {1}"}}
DFA2_-1322012086[\"DFA2 {1}"/]
DFA0_1169976293 -->|"-"|DFA1_-989187286
DFA1_-989187286 -->|"-"|DFA2_-1322012086
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
subgraph MiniDFA0_903791946["MiniDFA0 {1}"]
DFA0_1169976293_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-332990631["MiniDFA1 {1}"]
DFA1_-989187286_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-815240916["MiniDFA2 {1}"]
DFA2_-1322012086_2[\"DFA2 {1}"/]
end
MiniDFA0_903791946 -->|"-"|MiniDFA1_-332990631
MiniDFA1_-332990631 -->|"-"|MiniDFA2_-815240916
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
MiniDFA0_903791946(["MiniDFA0 {1}"])
MiniDFA1_-332990631(["MiniDFA1 {1}"])
MiniDFA2_-815240916[\"MiniDFA2 {1}"/]
MiniDFA0_903791946 -->|"-"|MiniDFA1_-332990631
MiniDFA1_-332990631 -->|"-"|MiniDFA2_-815240916
```
-------------------------------
