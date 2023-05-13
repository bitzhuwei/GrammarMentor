# 'const'

pattern: `const`

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
eNFA58_10_52225656[["εNFA58-10 regex start"]]
eNFA58_0_268861[["εNFA58-0 char{1, 1}"]]
eNFA58_1_2419756[["εNFA58-1 char[1]"]]
eNFA58_2_21777804[["εNFA58-2 char{1, 1}"]]
eNFA58_3_61782511[["εNFA58-3 char[1]"]]
eNFA58_4_19171695[["εNFA58-4 char{1, 1}"]]
eNFA58_5_38327532[["εNFA58-5 char[1]"]]
eNFA58_6_9403471[["εNFA58-6 char{1, 1}"]]
eNFA58_7_17522377[["εNFA58-7 char[1]"]]
eNFA58_8_23483667[["εNFA58-8 char{1, 1}"]]
eNFA58_9_10026414[["εNFA58-9 char[1]"]]
eNFA58_11_23128868[["εNFA58-11 regex end"]]
eNFA58_12_6833220[["εNFA58-12 post-regex start"]]
eNFA58_13_61498985[\"εNFA58-13 post-regex end"/]
eNFA58_10_52225656 -.->|"ε"|eNFA58_0_268861
eNFA58_0_268861 -->|"c"|eNFA58_1_2419756
eNFA58_1_2419756 -.->|"ε"|eNFA58_2_21777804
eNFA58_2_21777804 -->|"o"|eNFA58_3_61782511
eNFA58_3_61782511 -.->|"ε"|eNFA58_4_19171695
eNFA58_4_19171695 -->|"n"|eNFA58_5_38327532
eNFA58_5_38327532 -.->|"ε"|eNFA58_6_9403471
eNFA58_6_9403471 -->|"s"|eNFA58_7_17522377
eNFA58_7_17522377 -.->|"ε"|eNFA58_8_23483667
eNFA58_8_23483667 -->|"t"|eNFA58_9_10026414
eNFA58_9_10026414 -.->|"ε"|eNFA58_11_23128868
eNFA58_11_23128868 -.->|"ε"|eNFA58_12_6833220
eNFA58_12_6833220 -.->|"ε"|eNFA58_13_61498985
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
eNFA58_10_16619954[["εNFA58-10 regex start"]]
eNFA58_0_15361866[["εNFA58-0 char{1, 1}"]]
eNFA58_1_4039073[["εNFA58-1 char[1]"]]
eNFA58_2_36351665[["εNFA58-2 char{1, 1}"]]
eNFA58_3_58729529[["εNFA58-3 char[1]"]]
eNFA58_4_58803715[["εNFA58-4 char{1, 1}"]]
eNFA58_5_59471393[["εNFA58-5 char[1]"]]
eNFA58_6_65480490[["εNFA58-6 char{1, 1}"]]
eNFA58_7_52453505[["εNFA58-7 char[1]"]]
eNFA58_8_2319502[["εNFA58-8 char{1, 1}"]]
eNFA58_9_20875522[\"εNFA58-9 char[1]"/]
eNFA58_11_53661974[\"εNFA58-11 regex end"/]
eNFA58_12_13195723[\"εNFA58-12 post-regex start"/]
eNFA58_13_51652651[\"εNFA58-13 post-regex end"/]
eNFA58_10_16619954 -.->|"ε"|eNFA58_0_15361866
eNFA58_10_16619954 -->|"c"|eNFA58_1_4039073
eNFA58_0_15361866 -->|"c"|eNFA58_1_4039073
eNFA58_1_4039073 -.->|"ε"|eNFA58_2_36351665
eNFA58_1_4039073 -->|"o"|eNFA58_3_58729529
eNFA58_2_36351665 -->|"o"|eNFA58_3_58729529
eNFA58_3_58729529 -.->|"ε"|eNFA58_4_58803715
eNFA58_3_58729529 -->|"n"|eNFA58_5_59471393
eNFA58_4_58803715 -->|"n"|eNFA58_5_59471393
eNFA58_5_59471393 -.->|"ε"|eNFA58_6_65480490
eNFA58_5_59471393 -->|"s"|eNFA58_7_52453505
eNFA58_6_65480490 -->|"s"|eNFA58_7_52453505
eNFA58_7_52453505 -.->|"ε"|eNFA58_8_2319502
eNFA58_7_52453505 -->|"t"|eNFA58_9_20875522
eNFA58_8_2319502 -->|"t"|eNFA58_9_20875522
eNFA58_9_20875522 -.->|"ε"|eNFA58_11_53661974
eNFA58_9_20875522 -.->|"ε"|eNFA58_12_13195723
eNFA58_9_20875522 -.->|"ε"|eNFA58_13_51652651
eNFA58_11_53661974 -.->|"ε"|eNFA58_12_13195723
eNFA58_11_53661974 -.->|"ε"|eNFA58_13_51652651
eNFA58_12_13195723 -.->|"ε"|eNFA58_13_51652651
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
NFA58_10_62220677("NFA58-10 regex start")
NFA58_1_23115188("NFA58-1 char[1]")
NFA58_3_6710104("NFA58-3 char[1]")
NFA58_5_60390938("NFA58-5 char[1]")
NFA58_7_6647531("NFA58-7 char[1]")
NFA58_9_59827780[\"NFA58-9 char[1]"/]
NFA58_10_62220677 -->|"c"|NFA58_1_23115188
NFA58_1_23115188 -->|"o"|NFA58_3_6710104
NFA58_3_6710104 -->|"n"|NFA58_5_60390938
NFA58_5_60390938 -->|"s"|NFA58_7_6647531
NFA58_7_6647531 -->|"t"|NFA58_9_59827780
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
subgraph DFA0_1983762145["DFA0 regex start"]
NFA58_10_62220677_0("NFA58-10 regex start")
end
subgraph DFA1_-940623033["DFA1 {1}"]
NFA58_1_23115188_1("NFA58-1 char[1]")
end
subgraph DFA2_-70643274["DFA2 {1}"]
NFA58_3_6710104_2("NFA58-3 char[1]")
end
subgraph DFA3_218301575["DFA3 {1}"]
NFA58_5_60390938_3("NFA58-5 char[1]")
end
subgraph DFA4_1707669684["DFA4 {1}"]
NFA58_7_6647531_4("NFA58-7 char[1]")
end
subgraph DFA5_1682736289["DFA5 {1}"]
NFA58_9_59827780_5[\"NFA58-9 char[1]"/]
end
DFA0_1983762145 -->|"c"|DFA1_-940623033
DFA1_-940623033 -->|"o"|DFA2_-70643274
DFA2_-70643274 -->|"n"|DFA3_218301575
DFA3_218301575 -->|"s"|DFA4_1707669684
DFA4_1707669684 -->|"t"|DFA5_1682736289
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
DFA0_1983762145{{"DFA0 regex start"}}
DFA1_-940623033{{"DFA1 {1}"}}
DFA2_-70643274{{"DFA2 {1}"}}
DFA3_218301575{{"DFA3 {1}"}}
DFA4_1707669684{{"DFA4 {1}"}}
DFA5_1682736289[\"DFA5 {1}"/]
DFA0_1983762145 -->|"c"|DFA1_-940623033
DFA1_-940623033 -->|"o"|DFA2_-70643274
DFA2_-70643274 -->|"n"|DFA3_218301575
DFA3_218301575 -->|"s"|DFA4_1707669684
DFA4_1707669684 -->|"t"|DFA5_1682736289
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
subgraph MiniDFA0_1690379923["MiniDFA0 {1}"]
DFA0_1983762145_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1500164691["MiniDFA1 {1}"]
DFA1_-940623033_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_939706345["MiniDFA2 {1}"]
DFA2_-70643274_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1920554402["MiniDFA3 {1}"]
DFA3_218301575_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1994301920["MiniDFA4 {1}"]
DFA4_1707669684_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1421871447["MiniDFA5 {1}"]
DFA5_1682736289_5[\"DFA5 {1}"/]
end
MiniDFA0_1690379923 -->|"c"|MiniDFA1_1500164691
MiniDFA1_1500164691 -->|"o"|MiniDFA2_939706345
MiniDFA2_939706345 -->|"n"|MiniDFA3_1920554402
MiniDFA3_1920554402 -->|"s"|MiniDFA4_1994301920
MiniDFA4_1994301920 -->|"t"|MiniDFA5_-1421871447
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
MiniDFA0_1690379923(["MiniDFA0 {1}"])
MiniDFA1_1500164691(["MiniDFA1 {1}"])
MiniDFA2_939706345(["MiniDFA2 {1}"])
MiniDFA3_1920554402(["MiniDFA3 {1}"])
MiniDFA4_1994301920(["MiniDFA4 {1}"])
MiniDFA5_-1421871447[\"MiniDFA5 {1}"/]
MiniDFA0_1690379923 -->|"c"|MiniDFA1_1500164691
MiniDFA1_1500164691 -->|"o"|MiniDFA2_939706345
MiniDFA2_939706345 -->|"n"|MiniDFA3_1920554402
MiniDFA3_1920554402 -->|"s"|MiniDFA4_1994301920
MiniDFA4_1994301920 -->|"t"|MiniDFA5_-1421871447
```
-------------------------------
