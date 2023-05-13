# 'do'

pattern: `do`

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
eNFA203_4_23340236[["εNFA203-4 regex start"]]
eNFA203_0_8735540[["εNFA203-0 char{1, 1}"]]
eNFA203_1_11511003[["εNFA203-1 char[1]"]]
eNFA203_2_36490171[["εNFA203-2 char{1, 1}"]]
eNFA203_3_59976083[["εNFA203-3 char[1]"]]
eNFA203_5_2913837[["εNFA203-5 regex end"]]
eNFA203_6_26224539[["εNFA203-6 post-regex start"]]
eNFA203_7_34694260[\"εNFA203-7 post-regex end"/]
eNFA203_4_23340236 -.->|"ε"|eNFA203_0_8735540
eNFA203_0_8735540 -->|"d"|eNFA203_1_11511003
eNFA203_1_11511003 -.->|"ε"|eNFA203_2_36490171
eNFA203_2_36490171 -->|"o"|eNFA203_3_59976083
eNFA203_3_59976083 -.->|"ε"|eNFA203_5_2913837
eNFA203_5_2913837 -.->|"ε"|eNFA203_6_26224539
eNFA203_6_26224539 -.->|"ε"|eNFA203_7_34694260
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
eNFA203_4_43812891[["εNFA203-4 regex start"]]
eNFA203_0_58771704[["εNFA203-0 char{1, 1}"]]
eNFA203_1_59183292[["εNFA203-1 char[1]"]]
eNFA203_2_62887584[["εNFA203-2 char{1, 1}"]]
eNFA203_3_29117349[\"εNFA203-3 char[1]"/]
eNFA203_5_60729557[\"εNFA203-5 regex end"/]
eNFA203_6_9695103[\"εNFA203-6 post-regex start"/]
eNFA203_7_20147070[\"εNFA203-7 post-regex end"/]
eNFA203_4_43812891 -.->|"ε"|eNFA203_0_58771704
eNFA203_4_43812891 -->|"d"|eNFA203_1_59183292
eNFA203_0_58771704 -->|"d"|eNFA203_1_59183292
eNFA203_1_59183292 -.->|"ε"|eNFA203_2_62887584
eNFA203_1_59183292 -->|"o"|eNFA203_3_29117349
eNFA203_2_62887584 -->|"o"|eNFA203_3_29117349
eNFA203_3_29117349 -.->|"ε"|eNFA203_5_60729557
eNFA203_3_29117349 -.->|"ε"|eNFA203_6_9695103
eNFA203_3_29117349 -.->|"ε"|eNFA203_7_20147070
eNFA203_5_60729557 -.->|"ε"|eNFA203_6_9695103
eNFA203_5_60729557 -.->|"ε"|eNFA203_7_20147070
eNFA203_6_9695103 -.->|"ε"|eNFA203_7_20147070
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
NFA203_4_47105906("NFA203-4 regex start")
NFA203_1_21299972("NFA203-1 char[1]")
NFA203_3_57482021[\"NFA203-3 char[1]"/]
NFA203_4_47105906 -->|"d"|NFA203_1_21299972
NFA203_1_21299972 -->|"o"|NFA203_3_57482021
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
subgraph DFA0_-346862339["DFA0 regex start"]
NFA203_4_47105906_0("NFA203-4 regex start")
end
subgraph DFA1_-256205106["DFA1 {1}"]
NFA203_1_21299972_1("NFA203-1 char[1]")
end
subgraph DFA2_-1701947475["DFA2 {1}"]
NFA203_3_57482021_2[\"NFA203-3 char[1]"/]
end
DFA0_-346862339 -->|"d"|DFA1_-256205106
DFA1_-256205106 -->|"o"|DFA2_-1701947475
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
DFA0_-346862339{{"DFA0 regex start"}}
DFA1_-256205106{{"DFA1 {1}"}}
DFA2_-1701947475[\"DFA2 {1}"/]
DFA0_-346862339 -->|"d"|DFA1_-256205106
DFA1_-256205106 -->|"o"|DFA2_-1701947475
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
subgraph MiniDFA0_1955213169["MiniDFA0 {1}"]
DFA0_-346862339_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1059821090["MiniDFA1 {1}"]
DFA1_-256205106_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2056315088["MiniDFA2 {1}"]
DFA2_-1701947475_2[\"DFA2 {1}"/]
end
MiniDFA0_1955213169 -->|"d"|MiniDFA1_1059821090
MiniDFA1_1059821090 -->|"o"|MiniDFA2_-2056315088
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
MiniDFA0_1955213169(["MiniDFA0 {1}"])
MiniDFA1_1059821090(["MiniDFA1 {1}"])
MiniDFA2_-2056315088[\"MiniDFA2 {1}"/]
MiniDFA0_1955213169 -->|"d"|MiniDFA1_1059821090
MiniDFA1_1059821090 -->|"o"|MiniDFA2_-2056315088
```
-------------------------------
