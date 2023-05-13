# 'mat3'

pattern: `mat3`

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
eNFA96_8_59260526[["εNFA96-8 regex start"]]
eNFA96_0_63582688[["εNFA96-0 char{1, 1}"]]
eNFA96_1_35373287[["εNFA96-1 char[1]"]]
eNFA96_2_49924131[["εNFA96-2 char{1, 1}"]]
eNFA96_3_46663997[["εNFA96-3 char[1]"]]
eNFA96_4_17322790[["εNFA96-4 char{1, 1}"]]
eNFA96_5_21687383[["εNFA96-5 char[1]"]]
eNFA96_6_60968721[["εNFA96-6 char{1, 1}"]]
eNFA96_7_11847581[["εNFA96-7 char[1]"]]
eNFA96_9_39519373[["εNFA96-9 regex end"]]
eNFA96_10_20130041[["εNFA96-10 post-regex start"]]
eNFA96_11_46952641[\"εNFA96-11 post-regex end"/]
eNFA96_8_59260526 -.->|"ε"|eNFA96_0_63582688
eNFA96_0_63582688 -->|"m"|eNFA96_1_35373287
eNFA96_1_35373287 -.->|"ε"|eNFA96_2_49924131
eNFA96_2_49924131 -->|"a"|eNFA96_3_46663997
eNFA96_3_46663997 -.->|"ε"|eNFA96_4_17322790
eNFA96_4_17322790 -->|"t"|eNFA96_5_21687383
eNFA96_5_21687383 -.->|"ε"|eNFA96_6_60968721
eNFA96_6_60968721 -->|"3"|eNFA96_7_11847581
eNFA96_7_11847581 -.->|"ε"|eNFA96_9_39519373
eNFA96_9_39519373 -.->|"ε"|eNFA96_10_20130041
eNFA96_10_20130041 -.->|"ε"|eNFA96_11_46952641
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
eNFA96_8_19920592[["εNFA96-8 regex start"]]
eNFA96_0_45067606[["εNFA96-0 char{1, 1}"]]
eNFA96_1_2955276[["εNFA96-1 char[1]"]]
eNFA96_2_26597492[["εNFA96-2 char{1, 1}"]]
eNFA96_3_38050837[["εNFA96-3 char[1]"]]
eNFA96_4_6913218[["εNFA96-4 char{1, 1}"]]
eNFA96_5_62218962[["εNFA96-5 char[1]"]]
eNFA96_6_23099752[["εNFA96-6 char{1, 1}"]]
eNFA96_7_6571180[\"εNFA96-7 char[1]"/]
eNFA96_9_59140623[\"εNFA96-9 regex end"/]
eNFA96_10_62503562[\"εNFA96-10 post-regex start"/]
eNFA96_11_25661150[\"εNFA96-11 post-regex end"/]
eNFA96_8_19920592 -.->|"ε"|eNFA96_0_45067606
eNFA96_8_19920592 -->|"m"|eNFA96_1_2955276
eNFA96_0_45067606 -->|"m"|eNFA96_1_2955276
eNFA96_1_2955276 -.->|"ε"|eNFA96_2_26597492
eNFA96_1_2955276 -->|"a"|eNFA96_3_38050837
eNFA96_2_26597492 -->|"a"|eNFA96_3_38050837
eNFA96_3_38050837 -.->|"ε"|eNFA96_4_6913218
eNFA96_3_38050837 -->|"t"|eNFA96_5_62218962
eNFA96_4_6913218 -->|"t"|eNFA96_5_62218962
eNFA96_5_62218962 -.->|"ε"|eNFA96_6_23099752
eNFA96_5_62218962 -->|"3"|eNFA96_7_6571180
eNFA96_6_23099752 -->|"3"|eNFA96_7_6571180
eNFA96_7_6571180 -.->|"ε"|eNFA96_9_59140623
eNFA96_7_6571180 -.->|"ε"|eNFA96_10_62503562
eNFA96_7_6571180 -.->|"ε"|eNFA96_11_25661150
eNFA96_9_59140623 -.->|"ε"|eNFA96_10_62503562
eNFA96_9_59140623 -.->|"ε"|eNFA96_11_25661150
eNFA96_10_62503562 -.->|"ε"|eNFA96_11_25661150
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
NFA96_8_29623765("NFA96-8 regex start")
NFA96_1_65287294("NFA96-1 char[1]")
NFA96_3_50714740("NFA96-3 char[1]")
NFA96_5_53779479("NFA96-5 char[1]")
NFA96_7_14253264[\"NFA96-7 char[1]"/]
NFA96_8_29623765 -->|"m"|NFA96_1_65287294
NFA96_1_65287294 -->|"a"|NFA96_3_50714740
NFA96_3_50714740 -->|"t"|NFA96_5_53779479
NFA96_5_53779479 -->|"3"|NFA96_7_14253264
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
subgraph DFA0_-832122801["DFA0 regex start"]
NFA96_8_29623765_0("NFA96-8 regex start")
end
subgraph DFA1_1458301590["DFA1 {1}"]
NFA96_1_65287294_1("NFA96-1 char[1]")
end
subgraph DFA2_-482640916["DFA2 {1}"]
NFA96_3_50714740_2("NFA96-3 char[1]")
end
subgraph DFA3_371322271["DFA3 {1}"]
NFA96_5_53779479_3("NFA96-5 char[1]")
end
subgraph DFA4_-1886037825["DFA4 {1}"]
NFA96_7_14253264_4[\"NFA96-7 char[1]"/]
end
DFA0_-832122801 -->|"m"|DFA1_1458301590
DFA1_1458301590 -->|"a"|DFA2_-482640916
DFA2_-482640916 -->|"t"|DFA3_371322271
DFA3_371322271 -->|"3"|DFA4_-1886037825
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
DFA0_-832122801{{"DFA0 regex start"}}
DFA1_1458301590{{"DFA1 {1}"}}
DFA2_-482640916{{"DFA2 {1}"}}
DFA3_371322271{{"DFA3 {1}"}}
DFA4_-1886037825[\"DFA4 {1}"/]
DFA0_-832122801 -->|"m"|DFA1_1458301590
DFA1_1458301590 -->|"a"|DFA2_-482640916
DFA2_-482640916 -->|"t"|DFA3_371322271
DFA3_371322271 -->|"3"|DFA4_-1886037825
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
subgraph MiniDFA0_-1731326769["MiniDFA0 {1}"]
DFA0_-832122801_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-760926914["MiniDFA1 {1}"]
DFA1_1458301590_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1449076152["MiniDFA2 {1}"]
DFA2_-482640916_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1086269440["MiniDFA3 {1}"]
DFA3_371322271_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-293447603["MiniDFA4 {1}"]
DFA4_-1886037825_4[\"DFA4 {1}"/]
end
MiniDFA0_-1731326769 -->|"m"|MiniDFA1_-760926914
MiniDFA1_-760926914 -->|"a"|MiniDFA2_-1449076152
MiniDFA2_-1449076152 -->|"t"|MiniDFA3_-1086269440
MiniDFA3_-1086269440 -->|"3"|MiniDFA4_-293447603
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
MiniDFA0_-1731326769(["MiniDFA0 {1}"])
MiniDFA1_-760926914(["MiniDFA1 {1}"])
MiniDFA2_-1449076152(["MiniDFA2 {1}"])
MiniDFA3_-1086269440(["MiniDFA3 {1}"])
MiniDFA4_-293447603[\"MiniDFA4 {1}"/]
MiniDFA0_-1731326769 -->|"m"|MiniDFA1_-760926914
MiniDFA1_-760926914 -->|"a"|MiniDFA2_-1449076152
MiniDFA2_-1449076152 -->|"t"|MiniDFA3_-1086269440
MiniDFA3_-1086269440 -->|"3"|MiniDFA4_-293447603
```
-------------------------------
