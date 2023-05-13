# 'uniform'

pattern: `uniform`

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
eNFA65_14_37057034[["εNFA65-14 regex start"]]
eNFA65_0_65077851[["εNFA65-0 char{1, 1}"]]
eNFA65_1_48829755[["εNFA65-1 char[1]"]]
eNFA65_2_36814618[["εNFA65-2 char{1, 1}"]]
eNFA65_3_62896114[["εNFA65-3 char[1]"]]
eNFA65_4_29194114[["εNFA65-4 char{1, 1}"]]
eNFA65_5_61420436[["εNFA65-5 char[1]"]]
eNFA65_6_15913018[["εNFA65-6 char{1, 1}"]]
eNFA65_7_8999435[["εNFA65-7 char[1]"]]
eNFA65_8_13886058[["εNFA65-8 char{1, 1}"]]
eNFA65_9_57865663[["εNFA65-9 char[1]"]]
eNFA65_10_51028923[["εNFA65-10 char{1, 1}"]]
eNFA65_11_56607127[["εNFA65-11 char[1]"]]
eNFA65_12_39702100[["εNFA65-12 char{1, 1}"]]
eNFA65_13_21774588[["εNFA65-13 char[1]"]]
eNFA65_15_61753566[["εNFA65-15 regex end"]]
eNFA65_16_18911189[["εNFA65-16 post-regex start"]]
eNFA65_17_35982977[\"εNFA65-17 post-regex end"/]
eNFA65_14_37057034 -.->|"ε"|eNFA65_0_65077851
eNFA65_0_65077851 -->|"u"|eNFA65_1_48829755
eNFA65_1_48829755 -.->|"ε"|eNFA65_2_36814618
eNFA65_2_36814618 -->|"n"|eNFA65_3_62896114
eNFA65_3_62896114 -.->|"ε"|eNFA65_4_29194114
eNFA65_4_29194114 -->|"i"|eNFA65_5_61420436
eNFA65_5_61420436 -.->|"ε"|eNFA65_6_15913018
eNFA65_6_15913018 -->|"f"|eNFA65_7_8999435
eNFA65_7_8999435 -.->|"ε"|eNFA65_8_13886058
eNFA65_8_13886058 -->|"o"|eNFA65_9_57865663
eNFA65_9_57865663 -.->|"ε"|eNFA65_10_51028923
eNFA65_10_51028923 -->|"r"|eNFA65_11_56607127
eNFA65_11_56607127 -.->|"ε"|eNFA65_12_39702100
eNFA65_12_39702100 -->|"m"|eNFA65_13_21774588
eNFA65_13_21774588 -.->|"ε"|eNFA65_15_61753566
eNFA65_15_61753566 -.->|"ε"|eNFA65_16_18911189
eNFA65_16_18911189 -.->|"ε"|eNFA65_17_35982977
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
eNFA65_14_55411339[["εNFA65-14 regex start"]]
eNFA65_0_28940004[["εNFA65-0 char{1, 1}"]]
eNFA65_1_59133445[["εNFA65-1 char[1]"]]
eNFA65_2_62438959[["εNFA65-2 char{1, 1}"]]
eNFA65_3_25079723[["εNFA65-3 char[1]"]]
eNFA65_4_24390923[["εNFA65-4 char{1, 1}"]]
eNFA65_5_18191719[["εNFA65-5 char[1]"]]
eNFA65_6_29507743[["εNFA65-6 char{1, 1}"]]
eNFA65_7_64243102[["εNFA65-7 char[1]"]]
eNFA65_8_41317012[["εNFA65-8 char{1, 1}"]]
eNFA65_9_36308794[["εNFA65-9 char[1]"]]
eNFA65_10_58343698[["εNFA65-10 char{1, 1}"]]
eNFA65_11_55331235[["εNFA65-11 char[1]"]]
eNFA65_12_28219072[["εNFA65-12 char{1, 1}"]]
eNFA65_13_52645056[\"εNFA65-13 char[1]"/]
eNFA65_15_4043462[\"εNFA65-15 regex end"/]
eNFA65_16_36391162[\"εNFA65-16 post-regex start"/]
eNFA65_17_59085005[\"εNFA65-17 post-regex end"/]
eNFA65_14_55411339 -.->|"ε"|eNFA65_0_28940004
eNFA65_14_55411339 -->|"u"|eNFA65_1_59133445
eNFA65_0_28940004 -->|"u"|eNFA65_1_59133445
eNFA65_1_59133445 -.->|"ε"|eNFA65_2_62438959
eNFA65_1_59133445 -->|"n"|eNFA65_3_25079723
eNFA65_2_62438959 -->|"n"|eNFA65_3_25079723
eNFA65_3_25079723 -.->|"ε"|eNFA65_4_24390923
eNFA65_3_25079723 -->|"i"|eNFA65_5_18191719
eNFA65_4_24390923 -->|"i"|eNFA65_5_18191719
eNFA65_5_18191719 -.->|"ε"|eNFA65_6_29507743
eNFA65_5_18191719 -->|"f"|eNFA65_7_64243102
eNFA65_6_29507743 -->|"f"|eNFA65_7_64243102
eNFA65_7_64243102 -.->|"ε"|eNFA65_8_41317012
eNFA65_7_64243102 -->|"o"|eNFA65_9_36308794
eNFA65_8_41317012 -->|"o"|eNFA65_9_36308794
eNFA65_9_36308794 -.->|"ε"|eNFA65_10_58343698
eNFA65_9_36308794 -->|"r"|eNFA65_11_55331235
eNFA65_10_58343698 -->|"r"|eNFA65_11_55331235
eNFA65_11_55331235 -.->|"ε"|eNFA65_12_28219072
eNFA65_11_55331235 -->|"m"|eNFA65_13_52645056
eNFA65_12_28219072 -->|"m"|eNFA65_13_52645056
eNFA65_13_52645056 -.->|"ε"|eNFA65_15_4043462
eNFA65_13_52645056 -.->|"ε"|eNFA65_16_36391162
eNFA65_13_52645056 -.->|"ε"|eNFA65_17_59085005
eNFA65_15_4043462 -.->|"ε"|eNFA65_16_36391162
eNFA65_15_4043462 -.->|"ε"|eNFA65_17_59085005
eNFA65_16_36391162 -.->|"ε"|eNFA65_17_59085005
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
NFA65_14_62003000("NFA65-14 regex start")
NFA65_1_21156092("NFA65-1 char[1]")
NFA65_3_56187107("NFA65-3 char[1]")
NFA65_5_35921916("NFA65-5 char[1]")
NFA65_7_54861794("NFA65-7 char[1]")
NFA65_9_23994101("NFA65-9 char[1]")
NFA65_11_14620318("NFA65-11 char[1]")
NFA65_13_64473998[\"NFA65-13 char[1]"/]
NFA65_14_62003000 -->|"u"|NFA65_1_21156092
NFA65_1_21156092 -->|"n"|NFA65_3_56187107
NFA65_3_56187107 -->|"i"|NFA65_5_35921916
NFA65_5_35921916 -->|"f"|NFA65_7_54861794
NFA65_7_54861794 -->|"o"|NFA65_9_23994101
NFA65_9_23994101 -->|"r"|NFA65_11_14620318
NFA65_11_14620318 -->|"m"|NFA65_13_64473998
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
subgraph DFA0_1568329338["DFA0 regex start"]
NFA65_14_62003000_0("NFA65-14 regex start")
end
subgraph DFA1_-181093739["DFA1 {1}"]
NFA65_1_21156092_1("NFA65-1 char[1]")
end
subgraph DFA2_1575269616["DFA2 {1}"]
NFA65_3_56187107_2("NFA65-3 char[1]")
end
subgraph DFA3_-1894905396["DFA3 {1}"]
NFA65_5_35921916_3("NFA65-5 char[1]")
end
subgraph DFA4_-490304927["DFA4 {1}"]
NFA65_7_54861794_4("NFA65-7 char[1]")
end
subgraph DFA5_-644450896["DFA5 {1}"]
NFA65_9_23994101_5("NFA65-9 char[1]")
end
subgraph DFA6_1430959008["DFA6 {1}"]
NFA65_11_14620318_6("NFA65-11 char[1]")
end
subgraph DFA7_636507519["DFA7 {1}"]
NFA65_13_64473998_7[\"NFA65-13 char[1]"/]
end
DFA0_1568329338 -->|"u"|DFA1_-181093739
DFA1_-181093739 -->|"n"|DFA2_1575269616
DFA2_1575269616 -->|"i"|DFA3_-1894905396
DFA3_-1894905396 -->|"f"|DFA4_-490304927
DFA4_-490304927 -->|"o"|DFA5_-644450896
DFA5_-644450896 -->|"r"|DFA6_1430959008
DFA6_1430959008 -->|"m"|DFA7_636507519
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
DFA0_1568329338{{"DFA0 regex start"}}
DFA1_-181093739{{"DFA1 {1}"}}
DFA2_1575269616{{"DFA2 {1}"}}
DFA3_-1894905396{{"DFA3 {1}"}}
DFA4_-490304927{{"DFA4 {1}"}}
DFA5_-644450896{{"DFA5 {1}"}}
DFA6_1430959008{{"DFA6 {1}"}}
DFA7_636507519[\"DFA7 {1}"/]
DFA0_1568329338 -->|"u"|DFA1_-181093739
DFA1_-181093739 -->|"n"|DFA2_1575269616
DFA2_1575269616 -->|"i"|DFA3_-1894905396
DFA3_-1894905396 -->|"f"|DFA4_-490304927
DFA4_-490304927 -->|"o"|DFA5_-644450896
DFA5_-644450896 -->|"r"|DFA6_1430959008
DFA6_1430959008 -->|"m"|DFA7_636507519
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
subgraph MiniDFA0_435158898["MiniDFA0 {1}"]
DFA0_1568329338_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-632249219["MiniDFA1 {1}"]
DFA1_-181093739_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-406993031["MiniDFA2 {1}"]
DFA2_1575269616_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1720383973["MiniDFA3 {1}"]
DFA3_-1894905396_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-114158144["MiniDFA4 {1}"]
DFA4_-490304927_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1942109774["MiniDFA5 {1}"]
DFA5_-644450896_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-2124268381["MiniDFA6 {1}"]
DFA6_1430959008_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-964947982["MiniDFA7 {1}"]
DFA7_636507519_7[\"DFA7 {1}"/]
end
MiniDFA0_435158898 -->|"u"|MiniDFA1_-632249219
MiniDFA1_-632249219 -->|"n"|MiniDFA2_-406993031
MiniDFA2_-406993031 -->|"i"|MiniDFA3_1720383973
MiniDFA3_1720383973 -->|"f"|MiniDFA4_-114158144
MiniDFA4_-114158144 -->|"o"|MiniDFA5_-1942109774
MiniDFA5_-1942109774 -->|"r"|MiniDFA6_-2124268381
MiniDFA6_-2124268381 -->|"m"|MiniDFA7_-964947982
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
MiniDFA0_435158898(["MiniDFA0 {1}"])
MiniDFA1_-632249219(["MiniDFA1 {1}"])
MiniDFA2_-406993031(["MiniDFA2 {1}"])
MiniDFA3_1720383973(["MiniDFA3 {1}"])
MiniDFA4_-114158144(["MiniDFA4 {1}"])
MiniDFA5_-1942109774(["MiniDFA5 {1}"])
MiniDFA6_-2124268381(["MiniDFA6 {1}"])
MiniDFA7_-964947982[\"MiniDFA7 {1}"/]
MiniDFA0_435158898 -->|"u"|MiniDFA1_-632249219
MiniDFA1_-632249219 -->|"n"|MiniDFA2_-406993031
MiniDFA2_-406993031 -->|"i"|MiniDFA3_1720383973
MiniDFA3_1720383973 -->|"f"|MiniDFA4_-114158144
MiniDFA4_-114158144 -->|"o"|MiniDFA5_-1942109774
MiniDFA5_-1942109774 -->|"r"|MiniDFA6_-2124268381
MiniDFA6_-2124268381 -->|"m"|MiniDFA7_-964947982
```
-------------------------------
