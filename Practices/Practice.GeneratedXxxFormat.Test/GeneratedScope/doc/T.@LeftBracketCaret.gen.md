# '[^'

pattern: `\[\^`

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
eNFA6_4_38287490[["εNFA6-4 regex start"]]
eNFA6_0_9043096[["εNFA6-0 char{1, 1}"]]
eNFA6_1_14279005[["εNFA6-1 char[1]"]]
eNFA6_2_61402186[["εNFA6-2 char{1, 1}"]]
eNFA6_3_15748769[["εNFA6-3 char[1]"]]
eNFA6_5_7521193[["εNFA6-5 regex end"]]
eNFA6_6_581876[["εNFA6-6 post-regex start"]]
eNFA6_7_5236892[\"εNFA6-7 post-regex end"/]
eNFA6_4_38287490 -.->|"ε"|eNFA6_0_9043096
eNFA6_0_9043096 -->|"["|eNFA6_1_14279005
eNFA6_1_14279005 -.->|"ε"|eNFA6_2_61402186
eNFA6_2_61402186 -->|"^"|eNFA6_3_15748769
eNFA6_3_15748769 -.->|"ε"|eNFA6_5_7521193
eNFA6_5_7521193 -.->|"ε"|eNFA6_6_581876
eNFA6_6_581876 -.->|"ε"|eNFA6_7_5236892
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
eNFA6_4_47132033[["εNFA6-4 regex start"]]
eNFA6_0_21535116[["εNFA6-0 char{1, 1}"]]
eNFA6_1_59598318[["εNFA6-1 char[1]"]]
eNFA6_2_66622816[["εNFA6-2 char{1, 1}"]]
eNFA6_3_62734435[\"εNFA6-3 char[1]"/]
eNFA6_5_27739009[\"εNFA6-5 regex end"/]
eNFA6_6_48324489[\"εNFA6-6 post-regex start"/]
eNFA6_7_32267222[\"εNFA6-7 post-regex end"/]
eNFA6_4_47132033 -.->|"ε"|eNFA6_0_21535116
eNFA6_4_47132033 -->|"["|eNFA6_1_59598318
eNFA6_0_21535116 -->|"["|eNFA6_1_59598318
eNFA6_1_59598318 -.->|"ε"|eNFA6_2_66622816
eNFA6_1_59598318 -->|"^"|eNFA6_3_62734435
eNFA6_2_66622816 -->|"^"|eNFA6_3_62734435
eNFA6_3_62734435 -.->|"ε"|eNFA6_5_27739009
eNFA6_3_62734435 -.->|"ε"|eNFA6_6_48324489
eNFA6_3_62734435 -.->|"ε"|eNFA6_7_32267222
eNFA6_5_27739009 -.->|"ε"|eNFA6_6_48324489
eNFA6_5_27739009 -.->|"ε"|eNFA6_7_32267222
eNFA6_6_48324489 -.->|"ε"|eNFA6_7_32267222
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
NFA6_4_21969543("NFA6-4 regex start")
NFA6_1_63508167("NFA6-1 char[1]")
NFA6_3_34702598[\"NFA6-3 char[1]"/]
NFA6_4_21969543 -->|"["|NFA6_1_63508167
NFA6_1_63508167 -->|"^"|NFA6_3_34702598
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
subgraph DFA0_-313414784["DFA0 regex start"]
NFA6_4_21969543_0("NFA6-4 regex start")
end
subgraph DFA1_-881975555["DFA1 {1}"]
NFA6_1_63508167_1("NFA6-1 char[1]")
end
subgraph DFA2_679988503["DFA2 {1}"]
NFA6_3_34702598_2[\"NFA6-3 char[1]"/]
end
DFA0_-313414784 -->|"["|DFA1_-881975555
DFA1_-881975555 -->|"^"|DFA2_679988503
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
DFA0_-313414784{{"DFA0 regex start"}}
DFA1_-881975555{{"DFA1 {1}"}}
DFA2_679988503[\"DFA2 {1}"/]
DFA0_-313414784 -->|"["|DFA1_-881975555
DFA1_-881975555 -->|"^"|DFA2_679988503
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
subgraph MiniDFA0_1926162943["MiniDFA0 {1}"]
DFA0_-313414784_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_147880204["MiniDFA1 {1}"]
DFA1_-881975555_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-769166624["MiniDFA2 {1}"]
DFA2_679988503_2[\"DFA2 {1}"/]
end
MiniDFA0_1926162943 -->|"["|MiniDFA1_147880204
MiniDFA1_147880204 -->|"^"|MiniDFA2_-769166624
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
MiniDFA0_1926162943(["MiniDFA0 {1}"])
MiniDFA1_147880204(["MiniDFA1 {1}"])
MiniDFA2_-769166624[\"MiniDFA2 {1}"/]
MiniDFA0_1926162943 -->|"["|MiniDFA1_147880204
MiniDFA1_147880204 -->|"^"|MiniDFA2_-769166624
```
-------------------------------
