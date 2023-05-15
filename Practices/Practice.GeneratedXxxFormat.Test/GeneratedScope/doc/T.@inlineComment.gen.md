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
eNFA8_5_8478608[["εNFA8-5 regex start"]]
eNFA8_0_9198616[["εNFA8-0 char{1, 1}"]]
eNFA8_1_15678685[["εNFA8-1 char[1]"]]
eNFA8_2_6890440[["εNFA8-2 char{1, 1}"]]
eNFA8_3_6025849[["εNFA8-3 char[1]"]]
eNFA8_4_30495700[["εNFA8-4 char{0, ∞}"]]
eNFA8_6_54232646[["εNFA8-6 regex end"]]
eNFA8_7_43913021[["εNFA8-7 post-regex start"]]
eNFA8_8_59672869[\"εNFA8-8 post-regex end"/]
eNFA8_5_8478608 -.->|"ε"|eNFA8_0_9198616
eNFA8_0_9198616 -->|"/"|eNFA8_1_15678685
eNFA8_1_15678685 -.->|"ε"|eNFA8_2_6890440
eNFA8_2_6890440 -->|"/"|eNFA8_3_6025849
eNFA8_3_6025849 -.->|"ε"|eNFA8_4_30495700
eNFA8_4_30495700 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_30495700
eNFA8_4_30495700 -.->|"ε"|eNFA8_6_54232646
eNFA8_6_54232646 -.->|"ε"|eNFA8_7_43913021
eNFA8_7_43913021 -.->|"ε"|eNFA8_8_59672869
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
eNFA8_5_184914[["εNFA8-5 regex start"]]
eNFA8_0_1664227[["εNFA8-0 char{1, 1}"]]
eNFA8_1_14978051[["εNFA8-1 char[1]"]]
eNFA8_2_584738[["εNFA8-2 char{1, 1}"]]
eNFA8_3_21254748[\"εNFA8-3 char[1]"/]
eNFA8_4_62013962[\"εNFA8-4 char{0, ∞}"/]
eNFA8_6_57075007[\"εNFA8-6 regex end"/]
eNFA8_7_5262650[\"εNFA8-7 post-regex start"/]
eNFA8_8_47363850[\"εNFA8-8 post-regex end"/]
eNFA8_5_184914 -.->|"ε"|eNFA8_0_1664227
eNFA8_5_184914 -->|"/"|eNFA8_1_14978051
eNFA8_0_1664227 -->|"/"|eNFA8_1_14978051
eNFA8_1_14978051 -.->|"ε"|eNFA8_2_584738
eNFA8_1_14978051 -->|"/"|eNFA8_3_21254748
eNFA8_2_584738 -->|"/"|eNFA8_3_21254748
eNFA8_3_21254748 -.->|"ε"|eNFA8_4_62013962
eNFA8_3_21254748 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_62013962
eNFA8_3_21254748 -.->|"ε"|eNFA8_6_57075007
eNFA8_3_21254748 -.->|"ε"|eNFA8_7_5262650
eNFA8_3_21254748 -.->|"ε"|eNFA8_8_47363850
eNFA8_4_62013962 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_62013962
eNFA8_4_62013962 -.->|"ε"|eNFA8_6_57075007
eNFA8_4_62013962 -.->|"ε"|eNFA8_7_5262650
eNFA8_4_62013962 -.->|"ε"|eNFA8_8_47363850
eNFA8_6_57075007 -.->|"ε"|eNFA8_7_5262650
eNFA8_6_57075007 -.->|"ε"|eNFA8_8_47363850
eNFA8_7_5262650 -.->|"ε"|eNFA8_8_47363850
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
NFA8_5_34290771("NFA8-5 regex start")
NFA8_1_40181490("NFA8-1 char[1]")
NFA8_3_11266626[\"NFA8-3 char[1]"/]
NFA8_4_23621468[\"NFA8-4 char{0, ∞}"/]
NFA8_5_34290771 -->|"/"|NFA8_1_40181490
NFA8_1_40181490 -->|"/"|NFA8_3_11266626
NFA8_3_11266626 -->|"[#92;t#92;r#32;-~]"|NFA8_4_23621468
NFA8_4_23621468 -->|"[#92;t#92;r#32;-~]"|NFA8_4_23621468
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
subgraph DFA0_1265363062["DFA0 regex start"]
NFA8_5_34290771_0("NFA8-5 regex start")
end
subgraph DFA1_1948730669["DFA1 {1}"]
NFA8_1_40181490_1("NFA8-1 char[1]")
end
subgraph DFA2_-1032336021["DFA2 {1}"]
NFA8_3_11266626_2[\"NFA8-3 char[1]"/]
end
subgraph DFA3_-2134655957["DFA3 {1}"]
NFA8_4_23621468_3[\"NFA8-4 char{0, ∞}"/]
end
DFA0_1265363062 -->|"/"|DFA1_1948730669
DFA1_1948730669 -->|"/"|DFA2_-1032336021
DFA2_-1032336021 -->|"[#92;t#92;r#32;-~]"|DFA3_-2134655957
DFA3_-2134655957 -->|"[#92;t#92;r#32;-~]"|DFA3_-2134655957
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
DFA0_1265363062{{"DFA0 regex start"}}
DFA1_1948730669{{"DFA1 {1}"}}
DFA2_-1032336021[\"DFA2 {1}"/]
DFA3_-2134655957[\"DFA3 {1}"/]
DFA0_1265363062 -->|"/"|DFA1_1948730669
DFA1_1948730669 -->|"/"|DFA2_-1032336021
DFA2_-1032336021 -->|"[#92;t#92;r#32;-~]"|DFA3_-2134655957
DFA3_-2134655957 -->|"[#92;t#92;r#32;-~]"|DFA3_-2134655957
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
subgraph MiniDFA0_784586783["MiniDFA0 {1}"]
DFA0_1265363062_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_900390987["MiniDFA1 {1}"]
DFA1_1948730669_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_356624159["MiniDFA2 {1}"]
DFA2_-1032336021_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_1651048730["MiniDFA3 {1}"]
DFA3_-2134655957_3[\"DFA3 {1}"/]
end
MiniDFA0_784586783 -->|"/"|MiniDFA1_900390987
MiniDFA1_900390987 -->|"/"|MiniDFA2_356624159
MiniDFA2_356624159 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1651048730
MiniDFA3_1651048730 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1651048730
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
MiniDFA0_784586783(["MiniDFA0 {1}"])
MiniDFA1_900390987(["MiniDFA1 {1}"])
MiniDFA2_356624159[\"MiniDFA2 {1}"/]
MiniDFA3_1651048730[\"MiniDFA3 {1}"/]
MiniDFA0_784586783 -->|"/"|MiniDFA1_900390987
MiniDFA1_900390987 -->|"/"|MiniDFA2_356624159
MiniDFA2_356624159 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1651048730
MiniDFA3_1651048730 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_1651048730
```
-------------------------------
