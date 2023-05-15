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
eNFA4_5_20685786[["εNFA4-5 regex start"]]
eNFA4_0_51954348[["εNFA4-0 char{1, 1}"]]
eNFA4_1_64935954[["εNFA4-1 char[1]"]]
eNFA4_2_47552675[["εNFA4-2 char{1, 1}"]]
eNFA4_3_50020275[["εNFA4-3 char[1]"]]
eNFA4_4_35383970[["εNFA4-4 char{0, ∞}"]]
eNFA4_6_47529299[["εNFA4-6 regex end"]]
eNFA4_7_3997487[["εNFA4-7 post-regex start"]]
eNFA4_8_35977388[\"εNFA4-8 post-regex end"/]
eNFA4_5_20685786 -.->|"ε"|eNFA4_0_51954348
eNFA4_0_51954348 -->|"/"|eNFA4_1_64935954
eNFA4_1_64935954 -.->|"ε"|eNFA4_2_47552675
eNFA4_2_47552675 -->|"/"|eNFA4_3_50020275
eNFA4_3_50020275 -.->|"ε"|eNFA4_4_35383970
eNFA4_4_35383970 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_35383970
eNFA4_4_35383970 -.->|"ε"|eNFA4_6_47529299
eNFA4_6_47529299 -.->|"ε"|eNFA4_7_3997487
eNFA4_7_3997487 -.->|"ε"|eNFA4_8_35977388
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
eNFA4_5_55361044[["εNFA4-5 regex start"]]
eNFA4_0_28487350[["εNFA4-0 char{1, 1}"]]
eNFA4_1_55059565[["εNFA4-1 char[1]"]]
eNFA4_2_25774041[["εNFA4-2 char{1, 1}"]]
eNFA4_3_26561495[\"εNFA4-3 char[1]"/]
eNFA4_4_25320898[\"εNFA4-4 char{0, ∞}"/]
eNFA4_6_37726867[\"εNFA4-6 regex end"/]
eNFA4_7_30639779[\"εNFA4-7 post-regex start"/]
eNFA4_8_7322556[\"εNFA4-8 post-regex end"/]
eNFA4_5_55361044 -.->|"ε"|eNFA4_0_28487350
eNFA4_5_55361044 -->|"/"|eNFA4_1_55059565
eNFA4_0_28487350 -->|"/"|eNFA4_1_55059565
eNFA4_1_55059565 -.->|"ε"|eNFA4_2_25774041
eNFA4_1_55059565 -->|"/"|eNFA4_3_26561495
eNFA4_2_25774041 -->|"/"|eNFA4_3_26561495
eNFA4_3_26561495 -.->|"ε"|eNFA4_4_25320898
eNFA4_3_26561495 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_25320898
eNFA4_3_26561495 -.->|"ε"|eNFA4_6_37726867
eNFA4_3_26561495 -.->|"ε"|eNFA4_7_30639779
eNFA4_3_26561495 -.->|"ε"|eNFA4_8_7322556
eNFA4_4_25320898 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_25320898
eNFA4_4_25320898 -.->|"ε"|eNFA4_6_37726867
eNFA4_4_25320898 -.->|"ε"|eNFA4_7_30639779
eNFA4_4_25320898 -.->|"ε"|eNFA4_8_7322556
eNFA4_6_37726867 -.->|"ε"|eNFA4_7_30639779
eNFA4_6_37726867 -.->|"ε"|eNFA4_8_7322556
eNFA4_7_30639779 -.->|"ε"|eNFA4_8_7322556
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
NFA4_5_36543171("NFA4-5 regex start")
NFA4_1_60453091("NFA4-1 char[1]")
NFA4_3_56256135[\"NFA4-3 char[1]"/]
NFA4_4_65903005[\"NFA4-4 char{0, ∞}"/]
NFA4_5_36543171 -->|"/"|NFA4_1_60453091
NFA4_1_60453091 -->|"/"|NFA4_3_56256135
NFA4_3_56256135 -->|"[#92;t#92;r#32;-~]"|NFA4_4_65903005
NFA4_4_65903005 -->|"[#92;t#92;r#32;-~]"|NFA4_4_65903005
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
subgraph DFA0_-2118731724["DFA0 regex start"]
NFA4_5_36543171_0("NFA4-5 regex start")
end
subgraph DFA1_-1798914740["DFA1 {1}"]
NFA4_1_60453091_1("NFA4-1 char[1]")
end
subgraph DFA2_-1014647460["DFA2 {1}"]
NFA4_3_56256135_2[\"NFA4-3 char[1]"/]
end
subgraph DFA3_1465580158["DFA3 {1}"]
NFA4_4_65903005_3[\"NFA4-4 char{0, ∞}"/]
end
DFA0_-2118731724 -->|"/"|DFA1_-1798914740
DFA1_-1798914740 -->|"/"|DFA2_-1014647460
DFA2_-1014647460 -->|"[#92;t#92;r#32;-~]"|DFA3_1465580158
DFA3_1465580158 -->|"[#92;t#92;r#32;-~]"|DFA3_1465580158
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
DFA0_-2118731724{{"DFA0 regex start"}}
DFA1_-1798914740{{"DFA1 {1}"}}
DFA2_-1014647460[\"DFA2 {1}"/]
DFA3_1465580158[\"DFA3 {1}"/]
DFA0_-2118731724 -->|"/"|DFA1_-1798914740
DFA1_-1798914740 -->|"/"|DFA2_-1014647460
DFA2_-1014647460 -->|"[#92;t#92;r#32;-~]"|DFA3_1465580158
DFA3_1465580158 -->|"[#92;t#92;r#32;-~]"|DFA3_1465580158
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
subgraph MiniDFA0_1614924784["MiniDFA0 {1}"]
DFA0_-2118731724_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1140094524["MiniDFA1 {1}"]
DFA1_-1798914740_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-659298733["MiniDFA2 {1}"]
DFA2_-1014647460_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_740866934["MiniDFA3 {1}"]
DFA3_1465580158_3[\"DFA3 {1}"/]
end
MiniDFA0_1614924784 -->|"/"|MiniDFA1_1140094524
MiniDFA1_1140094524 -->|"/"|MiniDFA2_-659298733
MiniDFA2_-659298733 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_740866934
MiniDFA3_740866934 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_740866934
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
MiniDFA0_1614924784(["MiniDFA0 {1}"])
MiniDFA1_1140094524(["MiniDFA1 {1}"])
MiniDFA2_-659298733[\"MiniDFA2 {1}"/]
MiniDFA3_740866934[\"MiniDFA3 {1}"/]
MiniDFA0_1614924784 -->|"/"|MiniDFA1_1140094524
MiniDFA1_1140094524 -->|"/"|MiniDFA2_-659298733
MiniDFA2_-659298733 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_740866934
MiniDFA3_740866934 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_740866934
```
-------------------------------
