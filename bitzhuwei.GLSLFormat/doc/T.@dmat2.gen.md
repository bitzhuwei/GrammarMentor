# 'dmat2'

pattern: `dmat2`

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
eNFA107_10_12268704[["εNFA107-10 regex start"]]
eNFA107_0_43309474[["εNFA107-0 char{1, 1}"]]
eNFA107_1_54240947[["εNFA107-1 char[1]"]]
eNFA107_2_18406476[["εNFA107-2 char{1, 1}"]]
eNFA107_3_31440558[["εNFA107-3 char[1]"]]
eNFA107_4_14529570[["εNFA107-4 char{1, 1}"]]
eNFA107_5_63657274[["εNFA107-5 char[1]"]]
eNFA107_6_36044558[["εNFA107-6 char{1, 1}"]]
eNFA107_7_55965566[["εNFA107-7 char[1]"]]
eNFA107_8_33928053[["εNFA107-8 char{1, 1}"]]
eNFA107_9_36917027[["εNFA107-9 char[1]"]]
eNFA107_11_63817793[["εNFA107-11 regex end"]]
eNFA107_12_37489233[["εNFA107-12 post-regex start"]]
eNFA107_13_1858778[\"εNFA107-13 post-regex end"/]
eNFA107_10_12268704 -.->|"ε"|eNFA107_0_43309474
eNFA107_0_43309474 -->|"d"|eNFA107_1_54240947
eNFA107_1_54240947 -.->|"ε"|eNFA107_2_18406476
eNFA107_2_18406476 -->|"m"|eNFA107_3_31440558
eNFA107_3_31440558 -.->|"ε"|eNFA107_4_14529570
eNFA107_4_14529570 -->|"a"|eNFA107_5_63657274
eNFA107_5_63657274 -.->|"ε"|eNFA107_6_36044558
eNFA107_6_36044558 -->|"t"|eNFA107_7_55965566
eNFA107_7_55965566 -.->|"ε"|eNFA107_8_33928053
eNFA107_8_33928053 -->|"2"|eNFA107_9_36917027
eNFA107_9_36917027 -.->|"ε"|eNFA107_11_63817793
eNFA107_11_63817793 -.->|"ε"|eNFA107_12_37489233
eNFA107_12_37489233 -.->|"ε"|eNFA107_13_1858778
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
eNFA107_10_16729007[["εNFA107-10 regex start"]]
eNFA107_0_16343335[["εNFA107-0 char{1, 1}"]]
eNFA107_1_12872293[["εNFA107-1 char[1]"]]
eNFA107_2_48741777[["εNFA107-2 char{1, 1}"]]
eNFA107_3_36022812[["εNFA107-3 char[1]"]]
eNFA107_4_55769855[["εNFA107-4 char{1, 1}"]]
eNFA107_5_32166651[["εNFA107-5 char[1]"]]
eNFA107_6_21064410[["εNFA107-6 char{1, 1}"]]
eNFA107_7_55361963[["εNFA107-7 char[1]"]]
eNFA107_8_28495625[["εNFA107-8 char{1, 1}"]]
eNFA107_9_55134036[\"εNFA107-9 char[1]"/]
eNFA107_11_26444277[\"εNFA107-11 regex end"/]
eNFA107_12_36671901[\"εNFA107-12 post-regex start"/]
eNFA107_13_61611653[\"εNFA107-13 post-regex end"/]
eNFA107_10_16729007 -.->|"ε"|eNFA107_0_16343335
eNFA107_10_16729007 -->|"d"|eNFA107_1_12872293
eNFA107_0_16343335 -->|"d"|eNFA107_1_12872293
eNFA107_1_12872293 -.->|"ε"|eNFA107_2_48741777
eNFA107_1_12872293 -->|"m"|eNFA107_3_36022812
eNFA107_2_48741777 -->|"m"|eNFA107_3_36022812
eNFA107_3_36022812 -.->|"ε"|eNFA107_4_55769855
eNFA107_3_36022812 -->|"a"|eNFA107_5_32166651
eNFA107_4_55769855 -->|"a"|eNFA107_5_32166651
eNFA107_5_32166651 -.->|"ε"|eNFA107_6_21064410
eNFA107_5_32166651 -->|"t"|eNFA107_7_55361963
eNFA107_6_21064410 -->|"t"|eNFA107_7_55361963
eNFA107_7_55361963 -.->|"ε"|eNFA107_8_28495625
eNFA107_7_55361963 -->|"2"|eNFA107_9_55134036
eNFA107_8_28495625 -->|"2"|eNFA107_9_55134036
eNFA107_9_55134036 -.->|"ε"|eNFA107_11_26444277
eNFA107_9_55134036 -.->|"ε"|eNFA107_12_36671901
eNFA107_9_55134036 -.->|"ε"|eNFA107_13_61611653
eNFA107_11_26444277 -.->|"ε"|eNFA107_12_36671901
eNFA107_11_26444277 -.->|"ε"|eNFA107_13_61611653
eNFA107_12_36671901 -.->|"ε"|eNFA107_13_61611653
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
NFA107_10_17633966("NFA107-10 regex start")
NFA107_1_24487969("NFA107-1 char[1]")
NFA107_3_19065136("NFA107-3 char[1]")
NFA107_5_37368498("NFA107-5 char[1]")
NFA107_7_772170("NFA107-7 char[1]")
NFA107_9_6949536[\"NFA107-9 char[1]"/]
NFA107_10_17633966 -->|"d"|NFA107_1_24487969
NFA107_1_24487969 -->|"m"|NFA107_3_19065136
NFA107_3_19065136 -->|"a"|NFA107_5_37368498
NFA107_5_37368498 -->|"t"|NFA107_7_772170
NFA107_7_772170 -->|"2"|NFA107_9_6949536
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
subgraph DFA0_1223570592["DFA0 regex start"]
NFA107_10_17633966_0("NFA107-10 regex start")
end
subgraph DFA1_829175471["DFA1 {1}"]
NFA107_1_24487969_1("NFA107-1 char[1]")
end
subgraph DFA2_1295713155["DFA2 {1}"]
NFA107_3_19065136_2("NFA107-3 char[1]")
end
subgraph DFA3_-1046113901["DFA3 {1}"]
NFA107_5_37368498_3("NFA107-5 char[1]")
end
subgraph DFA4_1363525277["DFA4 {1}"]
NFA107_7_772170_4("NFA107-7 char[1]")
end
subgraph DFA5_-624105922["DFA5 {1}"]
NFA107_9_6949536_5[\"NFA107-9 char[1]"/]
end
DFA0_1223570592 -->|"d"|DFA1_829175471
DFA1_829175471 -->|"m"|DFA2_1295713155
DFA2_1295713155 -->|"a"|DFA3_-1046113901
DFA3_-1046113901 -->|"t"|DFA4_1363525277
DFA4_1363525277 -->|"2"|DFA5_-624105922
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
DFA0_1223570592{{"DFA0 regex start"}}
DFA1_829175471{{"DFA1 {1}"}}
DFA2_1295713155{{"DFA2 {1}"}}
DFA3_-1046113901{{"DFA3 {1}"}}
DFA4_1363525277{{"DFA4 {1}"}}
DFA5_-624105922[\"DFA5 {1}"/]
DFA0_1223570592 -->|"d"|DFA1_829175471
DFA1_829175471 -->|"m"|DFA2_1295713155
DFA2_1295713155 -->|"a"|DFA3_-1046113901
DFA3_-1046113901 -->|"t"|DFA4_1363525277
DFA4_1363525277 -->|"2"|DFA5_-624105922
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
subgraph MiniDFA0_1756557432["MiniDFA0 {1}"]
DFA0_1223570592_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1656769458["MiniDFA1 {1}"]
DFA1_829175471_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-856717644["MiniDFA2 {1}"]
DFA2_1295713155_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1189876190["MiniDFA3 {1}"]
DFA3_-1046113901_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_873918087["MiniDFA4 {1}"]
DFA4_1363525277_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_2124063912["MiniDFA5 {1}"]
DFA5_-624105922_5[\"DFA5 {1}"/]
end
MiniDFA0_1756557432 -->|"d"|MiniDFA1_-1656769458
MiniDFA1_-1656769458 -->|"m"|MiniDFA2_-856717644
MiniDFA2_-856717644 -->|"a"|MiniDFA3_-1189876190
MiniDFA3_-1189876190 -->|"t"|MiniDFA4_873918087
MiniDFA4_873918087 -->|"2"|MiniDFA5_2124063912
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
MiniDFA0_1756557432(["MiniDFA0 {1}"])
MiniDFA1_-1656769458(["MiniDFA1 {1}"])
MiniDFA2_-856717644(["MiniDFA2 {1}"])
MiniDFA3_-1189876190(["MiniDFA3 {1}"])
MiniDFA4_873918087(["MiniDFA4 {1}"])
MiniDFA5_2124063912[\"MiniDFA5 {1}"/]
MiniDFA0_1756557432 -->|"d"|MiniDFA1_-1656769458
MiniDFA1_-1656769458 -->|"m"|MiniDFA2_-856717644
MiniDFA2_-856717644 -->|"a"|MiniDFA3_-1189876190
MiniDFA3_-1189876190 -->|"t"|MiniDFA4_873918087
MiniDFA4_873918087 -->|"2"|MiniDFA5_2124063912
```
-------------------------------
