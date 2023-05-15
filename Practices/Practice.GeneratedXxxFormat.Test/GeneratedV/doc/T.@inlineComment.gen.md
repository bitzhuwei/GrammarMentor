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
eNFA3_5_54145697[["εNFA3-5 regex start"]]
eNFA3_0_17549226[["εNFA3-0 char{1, 1}"]]
eNFA3_1_23725308[["εNFA3-1 char[1]"]]
eNFA3_2_12201184[["εNFA3-2 char{1, 1}"]]
eNFA3_3_6073723[["εNFA3-3 char[1]"]]
eNFA3_4_52870641[["εNFA3-4 char{0, ∞}"]]
eNFA3_6_54663514[["εNFA3-6 regex end"]]
eNFA3_7_58208499[["εNFA3-7 post-regex start"]]
eNFA3_8_54114449[\"εNFA3-8 post-regex end"/]
eNFA3_5_54145697 -.->|"ε"|eNFA3_0_17549226
eNFA3_0_17549226 -->|"/"|eNFA3_1_23725308
eNFA3_1_23725308 -.->|"ε"|eNFA3_2_12201184
eNFA3_2_12201184 -->|"/"|eNFA3_3_6073723
eNFA3_3_6073723 -.->|"ε"|eNFA3_4_52870641
eNFA3_4_52870641 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_52870641
eNFA3_4_52870641 -.->|"ε"|eNFA3_6_54663514
eNFA3_6_54663514 -.->|"ε"|eNFA3_7_58208499
eNFA3_7_58208499 -.->|"ε"|eNFA3_8_54114449
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
eNFA3_5_17267999[["εNFA3-5 regex start"]]
eNFA3_0_21194271[["εNFA3-0 char{1, 1}"]]
eNFA3_1_56530712[["εNFA3-1 char[1]"]]
eNFA3_2_39014365[["εNFA3-2 char{1, 1}"]]
eNFA3_3_48771884[\"εNFA3-3 char[1]"/]
eNFA3_4_42701800[\"εNFA3-4 char{0, ∞}"/]
eNFA3_6_36293772[\"εNFA3-6 regex end"/]
eNFA3_7_15584965[\"εNFA3-7 post-regex start"/]
eNFA3_8_6046963[\"εNFA3-8 post-regex end"/]
eNFA3_5_17267999 -.->|"ε"|eNFA3_0_21194271
eNFA3_5_17267999 -->|"/"|eNFA3_1_56530712
eNFA3_0_21194271 -->|"/"|eNFA3_1_56530712
eNFA3_1_56530712 -.->|"ε"|eNFA3_2_39014365
eNFA3_1_56530712 -->|"/"|eNFA3_3_48771884
eNFA3_2_39014365 -->|"/"|eNFA3_3_48771884
eNFA3_3_48771884 -.->|"ε"|eNFA3_4_42701800
eNFA3_3_48771884 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_42701800
eNFA3_3_48771884 -.->|"ε"|eNFA3_6_36293772
eNFA3_3_48771884 -.->|"ε"|eNFA3_7_15584965
eNFA3_3_48771884 -.->|"ε"|eNFA3_8_6046963
eNFA3_4_42701800 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_42701800
eNFA3_4_42701800 -.->|"ε"|eNFA3_6_36293772
eNFA3_4_42701800 -.->|"ε"|eNFA3_7_15584965
eNFA3_4_42701800 -.->|"ε"|eNFA3_8_6046963
eNFA3_6_36293772 -.->|"ε"|eNFA3_7_15584965
eNFA3_6_36293772 -.->|"ε"|eNFA3_8_6046963
eNFA3_7_15584965 -.->|"ε"|eNFA3_8_6046963
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
NFA3_5_46160221("NFA3-5 regex start")
NFA3_1_12788809("NFA3-1 char[1]")
NFA3_3_20041994[\"NFA3-3 char[1]"/]
NFA3_4_54422671[\"NFA3-4 char{0, ∞}"/]
NFA3_5_46160221 -->|"/"|NFA3_1_12788809
NFA3_1_12788809 -->|"/"|NFA3_3_20041994
NFA3_3_20041994 -->|"[#92;t#92;r#32;-~]"|NFA3_4_54422671
NFA3_4_54422671 -->|"[#92;t#92;r#32;-~]"|NFA3_4_54422671
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
subgraph DFA0_-57273975["DFA0 regex start"]
NFA3_5_46160221_0("NFA3-5 regex start")
end
subgraph DFA1_1074026627["DFA1 {1}"]
NFA3_1_12788809_1("NFA3-1 char[1]")
end
subgraph DFA2_931457299["DFA2 {1}"]
NFA3_3_20041994_2[\"NFA3-3 char[1]"/]
end
subgraph DFA3_546418077["DFA3 {1}"]
NFA3_4_54422671_3[\"NFA3-4 char{0, ∞}"/]
end
DFA0_-57273975 -->|"/"|DFA1_1074026627
DFA1_1074026627 -->|"/"|DFA2_931457299
DFA2_931457299 -->|"[#92;t#92;r#32;-~]"|DFA3_546418077
DFA3_546418077 -->|"[#92;t#92;r#32;-~]"|DFA3_546418077
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
DFA0_-57273975{{"DFA0 regex start"}}
DFA1_1074026627{{"DFA1 {1}"}}
DFA2_931457299[\"DFA2 {1}"/]
DFA3_546418077[\"DFA3 {1}"/]
DFA0_-57273975 -->|"/"|DFA1_1074026627
DFA1_1074026627 -->|"/"|DFA2_931457299
DFA2_931457299 -->|"[#92;t#92;r#32;-~]"|DFA3_546418077
DFA3_546418077 -->|"[#92;t#92;r#32;-~]"|DFA3_546418077
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
subgraph MiniDFA0_852353675["MiniDFA0 {1}"]
DFA0_-57273975_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1301114404["MiniDFA1 {1}"]
DFA1_1074026627_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1583108141["MiniDFA2 {1}"]
DFA2_931457299_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-1896986030["MiniDFA3 {1}"]
DFA3_546418077_3[\"DFA3 {1}"/]
end
MiniDFA0_852353675 -->|"/"|MiniDFA1_1301114404
MiniDFA1_1301114404 -->|"/"|MiniDFA2_1583108141
MiniDFA2_1583108141 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1896986030
MiniDFA3_-1896986030 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1896986030
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
MiniDFA0_852353675(["MiniDFA0 {1}"])
MiniDFA1_1301114404(["MiniDFA1 {1}"])
MiniDFA2_1583108141[\"MiniDFA2 {1}"/]
MiniDFA3_-1896986030[\"MiniDFA3 {1}"/]
MiniDFA0_852353675 -->|"/"|MiniDFA1_1301114404
MiniDFA1_1301114404 -->|"/"|MiniDFA2_1583108141
MiniDFA2_1583108141 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1896986030
MiniDFA3_-1896986030 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_-1896986030
```
-------------------------------
