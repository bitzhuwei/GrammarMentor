# 'mat4'

pattern: `mat4`

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
eNFA97_8_6769295[["εNFA97-8 regex start"]]
eNFA97_0_60923663[["εNFA97-0 char{1, 1}"]]
eNFA97_1_11442060[["εNFA97-1 char[1]"]]
eNFA97_2_35869679[["εNFA97-2 char{1, 1}"]]
eNFA97_3_54391657[["εNFA97-3 char[1]"]]
eNFA97_4_19762867[["εNFA97-4 char{1, 1}"]]
eNFA97_5_43648078[["εNFA97-5 char[1]"]]
eNFA97_6_57288388[["εNFA97-6 char{1, 1}"]]
eNFA97_7_45833444[["εNFA97-7 char[1]"]]
eNFA97_9_9847817[["εNFA97-9 regex end"]]
eNFA97_10_21521490[["εNFA97-10 post-regex start"]]
eNFA97_11_59475690[\"εNFA97-11 post-regex end"/]
eNFA97_8_6769295 -.->|"ε"|eNFA97_0_60923663
eNFA97_0_60923663 -->|"m"|eNFA97_1_11442060
eNFA97_1_11442060 -.->|"ε"|eNFA97_2_35869679
eNFA97_2_35869679 -->|"a"|eNFA97_3_54391657
eNFA97_3_54391657 -.->|"ε"|eNFA97_4_19762867
eNFA97_4_19762867 -->|"t"|eNFA97_5_43648078
eNFA97_5_43648078 -.->|"ε"|eNFA97_6_57288388
eNFA97_6_57288388 -->|"4"|eNFA97_7_45833444
eNFA97_7_45833444 -.->|"ε"|eNFA97_9_9847817
eNFA97_9_9847817 -.->|"ε"|eNFA97_10_21521490
eNFA97_10_21521490 -.->|"ε"|eNFA97_11_59475690
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
eNFA97_8_65519169[["εNFA97-8 regex start"]]
eNFA97_0_52801617[["εNFA97-0 char{1, 1}"]]
eNFA97_1_5452505[["εNFA97-1 char[1]"]]
eNFA97_2_49072547[["εNFA97-2 char{1, 1}"]]
eNFA97_3_38999745[["εNFA97-3 char[1]"]]
eNFA97_4_15453386[["εNFA97-4 char{1, 1}"]]
eNFA97_5_4862753[["εNFA97-5 char[1]"]]
eNFA97_6_43764782[["εNFA97-6 char{1, 1}"]]
eNFA97_7_58338722[\"εNFA97-7 char[1]"/]
eNFA97_9_55286454[\"εNFA97-9 regex end"/]
eNFA97_10_27816043[\"εNFA97-10 post-regex start"/]
eNFA97_11_49017803[\"εNFA97-11 post-regex end"/]
eNFA97_8_65519169 -.->|"ε"|eNFA97_0_52801617
eNFA97_8_65519169 -->|"m"|eNFA97_1_5452505
eNFA97_0_52801617 -->|"m"|eNFA97_1_5452505
eNFA97_1_5452505 -.->|"ε"|eNFA97_2_49072547
eNFA97_1_5452505 -->|"a"|eNFA97_3_38999745
eNFA97_2_49072547 -->|"a"|eNFA97_3_38999745
eNFA97_3_38999745 -.->|"ε"|eNFA97_4_15453386
eNFA97_3_38999745 -->|"t"|eNFA97_5_4862753
eNFA97_4_15453386 -->|"t"|eNFA97_5_4862753
eNFA97_5_4862753 -.->|"ε"|eNFA97_6_43764782
eNFA97_5_4862753 -->|"4"|eNFA97_7_58338722
eNFA97_6_43764782 -->|"4"|eNFA97_7_58338722
eNFA97_7_58338722 -.->|"ε"|eNFA97_9_55286454
eNFA97_7_58338722 -.->|"ε"|eNFA97_10_27816043
eNFA97_7_58338722 -.->|"ε"|eNFA97_11_49017803
eNFA97_9_55286454 -.->|"ε"|eNFA97_10_27816043
eNFA97_9_55286454 -.->|"ε"|eNFA97_11_49017803
eNFA97_10_27816043 -.->|"ε"|eNFA97_11_49017803
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
NFA97_8_38507045("NFA97-8 regex start")
NFA97_1_11019092("NFA97-1 char[1]")
NFA97_3_32062968("NFA97-3 char[1]")
NFA97_5_20131258("NFA97-5 char[1]")
NFA97_7_46963595[\"NFA97-7 char[1]"/]
NFA97_8_38507045 -->|"m"|NFA97_1_11019092
NFA97_1_11019092 -->|"a"|NFA97_3_32062968
NFA97_3_32062968 -->|"t"|NFA97_5_20131258
NFA97_5_20131258 -->|"4"|NFA97_7_46963595
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
subgraph DFA0_-133562300["DFA0 regex start"]
NFA97_8_38507045_0("NFA97-8 regex start")
end
subgraph DFA1_596891689["DFA1 {1}"]
NFA97_1_11019092_1("NFA97-1 char[1]")
end
subgraph DFA2_1928380106["DFA2 {1}"]
NFA97_3_32062968_2("NFA97-3 char[1]")
end
subgraph DFA3_1911567636["DFA3 {1}"]
NFA97_5_20131258_3("NFA97-5 char[1]")
end
subgraph DFA4_-1717340066["DFA4 {1}"]
NFA97_7_46963595_4[\"NFA97-7 char[1]"/]
end
DFA0_-133562300 -->|"m"|DFA1_596891689
DFA1_596891689 -->|"a"|DFA2_1928380106
DFA2_1928380106 -->|"t"|DFA3_1911567636
DFA3_1911567636 -->|"4"|DFA4_-1717340066
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
DFA0_-133562300{{"DFA0 regex start"}}
DFA1_596891689{{"DFA1 {1}"}}
DFA2_1928380106{{"DFA2 {1}"}}
DFA3_1911567636{{"DFA3 {1}"}}
DFA4_-1717340066[\"DFA4 {1}"/]
DFA0_-133562300 -->|"m"|DFA1_596891689
DFA1_596891689 -->|"a"|DFA2_1928380106
DFA2_1928380106 -->|"t"|DFA3_1911567636
DFA3_1911567636 -->|"4"|DFA4_-1717340066
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
subgraph MiniDFA0_-980563463["MiniDFA0 {1}"]
DFA0_-133562300_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-747574128["MiniDFA1 {1}"]
DFA1_596891689_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_812693193["MiniDFA2 {1}"]
DFA2_1928380106_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-88397651["MiniDFA3 {1}"]
DFA3_1911567636_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1929629074["MiniDFA4 {1}"]
DFA4_-1717340066_4[\"DFA4 {1}"/]
end
MiniDFA0_-980563463 -->|"m"|MiniDFA1_-747574128
MiniDFA1_-747574128 -->|"a"|MiniDFA2_812693193
MiniDFA2_812693193 -->|"t"|MiniDFA3_-88397651
MiniDFA3_-88397651 -->|"4"|MiniDFA4_1929629074
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
MiniDFA0_-980563463(["MiniDFA0 {1}"])
MiniDFA1_-747574128(["MiniDFA1 {1}"])
MiniDFA2_812693193(["MiniDFA2 {1}"])
MiniDFA3_-88397651(["MiniDFA3 {1}"])
MiniDFA4_1929629074[\"MiniDFA4 {1}"/]
MiniDFA0_-980563463 -->|"m"|MiniDFA1_-747574128
MiniDFA1_-747574128 -->|"a"|MiniDFA2_812693193
MiniDFA2_812693193 -->|"t"|MiniDFA3_-88397651
MiniDFA3_-88397651 -->|"4"|MiniDFA4_1929629074
```
-------------------------------
