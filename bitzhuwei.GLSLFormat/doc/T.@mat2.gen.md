# 'mat2'

pattern: `mat2`

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
eNFA95_8_63379561[["εNFA95-8 regex start"]]
eNFA95_0_33545144[["εNFA95-0 char{1, 1}"]]
eNFA95_1_33470841[["εNFA95-1 char[1]"]]
eNFA95_2_32802119[["εNFA95-2 char{1, 1}"]]
eNFA95_3_26783618[["εNFA95-3 char[1]"]]
eNFA95_4_39725971[["εNFA95-4 char{1, 1}"]]
eNFA95_5_21989419[["εNFA95-5 char[1]"]]
eNFA95_6_63687043[["εNFA95-6 char{1, 1}"]]
eNFA95_7_36312476[["εNFA95-7 char[1]"]]
eNFA95_9_58376831[["εNFA95-9 regex end"]]
eNFA95_10_55629438[["εNFA95-10 post-regex start"]]
eNFA95_11_30902896[\"εNFA95-11 post-regex end"/]
eNFA95_8_63379561 -.->|"ε"|eNFA95_0_33545144
eNFA95_0_33545144 -->|"m"|eNFA95_1_33470841
eNFA95_1_33470841 -.->|"ε"|eNFA95_2_32802119
eNFA95_2_32802119 -->|"a"|eNFA95_3_26783618
eNFA95_3_26783618 -.->|"ε"|eNFA95_4_39725971
eNFA95_4_39725971 -->|"t"|eNFA95_5_21989419
eNFA95_5_21989419 -.->|"ε"|eNFA95_6_63687043
eNFA95_6_63687043 -->|"2"|eNFA95_7_36312476
eNFA95_7_36312476 -.->|"ε"|eNFA95_9_58376831
eNFA95_9_58376831 -.->|"ε"|eNFA95_10_55629438
eNFA95_10_55629438 -.->|"ε"|eNFA95_11_30902896
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
eNFA95_8_9690616[["εNFA95-8 regex start"]]
eNFA95_0_20106686[["εNFA95-0 char{1, 1}"]]
eNFA95_1_46742451[["εNFA95-1 char[1]"]]
eNFA95_2_18028880[["εNFA95-2 char{1, 1}"]]
eNFA95_3_28042199[["εNFA95-3 char[1]"]]
eNFA95_4_51053199[["εNFA95-4 char{1, 1}"]]
eNFA95_5_56825610[["εNFA95-5 char[1]"]]
eNFA95_6_41668450[["εNFA95-6 char{1, 1}"]]
eNFA95_7_39471735[\"εNFA95-7 char[1]"/]
eNFA95_9_19701298[\"εNFA95-9 regex end"/]
eNFA95_10_43093956[\"εNFA95-10 post-regex start"/]
eNFA95_11_52301286[\"εNFA95-11 post-regex end"/]
eNFA95_8_9690616 -.->|"ε"|eNFA95_0_20106686
eNFA95_8_9690616 -->|"m"|eNFA95_1_46742451
eNFA95_0_20106686 -->|"m"|eNFA95_1_46742451
eNFA95_1_46742451 -.->|"ε"|eNFA95_2_18028880
eNFA95_1_46742451 -->|"a"|eNFA95_3_28042199
eNFA95_2_18028880 -->|"a"|eNFA95_3_28042199
eNFA95_3_28042199 -.->|"ε"|eNFA95_4_51053199
eNFA95_3_28042199 -->|"t"|eNFA95_5_56825610
eNFA95_4_51053199 -->|"t"|eNFA95_5_56825610
eNFA95_5_56825610 -.->|"ε"|eNFA95_6_41668450
eNFA95_5_56825610 -->|"2"|eNFA95_7_39471735
eNFA95_6_41668450 -->|"2"|eNFA95_7_39471735
eNFA95_7_39471735 -.->|"ε"|eNFA95_9_19701298
eNFA95_7_39471735 -.->|"ε"|eNFA95_10_43093956
eNFA95_7_39471735 -.->|"ε"|eNFA95_11_52301286
eNFA95_9_19701298 -.->|"ε"|eNFA95_10_43093956
eNFA95_9_19701298 -.->|"ε"|eNFA95_11_52301286
eNFA95_10_43093956 -.->|"ε"|eNFA95_11_52301286
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
NFA95_8_949529("NFA95-8 regex start")
NFA95_1_8545767("NFA95-1 char[1]")
NFA95_3_9803039("NFA95-3 char[1]")
NFA95_5_21118492("NFA95-5 char[1]")
NFA95_7_55848701[\"NFA95-7 char[1]"/]
NFA95_8_949529 -->|"m"|NFA95_1_8545767
NFA95_1_8545767 -->|"a"|NFA95_3_9803039
NFA95_3_9803039 -->|"t"|NFA95_5_21118492
NFA95_5_21118492 -->|"2"|NFA95_7_55848701
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
subgraph DFA0_-816455749["DFA0 regex start"]
NFA95_8_949529_0("NFA95-8 regex start")
end
subgraph DFA1_-297322488["DFA1 {1}"]
NFA95_1_8545767_1("NFA95-1 char[1]")
end
subgraph DFA2_-139260870["DFA2 {1}"]
NFA95_3_9803039_2("NFA95-3 char[1]")
end
subgraph DFA3_434572685["DFA3 {1}"]
NFA95_5_21118492_3("NFA95-5 char[1]")
end
subgraph DFA4_198636749["DFA4 {1}"]
NFA95_7_55848701_4[\"NFA95-7 char[1]"/]
end
DFA0_-816455749 -->|"m"|DFA1_-297322488
DFA1_-297322488 -->|"a"|DFA2_-139260870
DFA2_-139260870 -->|"t"|DFA3_434572685
DFA3_434572685 -->|"2"|DFA4_198636749
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
DFA0_-816455749{{"DFA0 regex start"}}
DFA1_-297322488{{"DFA1 {1}"}}
DFA2_-139260870{{"DFA2 {1}"}}
DFA3_434572685{{"DFA3 {1}"}}
DFA4_198636749[\"DFA4 {1}"/]
DFA0_-816455749 -->|"m"|DFA1_-297322488
DFA1_-297322488 -->|"a"|DFA2_-139260870
DFA2_-139260870 -->|"t"|DFA3_434572685
DFA3_434572685 -->|"2"|DFA4_198636749
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
subgraph MiniDFA0_-5308154["MiniDFA0 {1}"]
DFA0_-816455749_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_403742429["MiniDFA1 {1}"]
DFA1_-297322488_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_2132465069["MiniDFA2 {1}"]
DFA2_-139260870_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1845605165["MiniDFA3 {1}"]
DFA3_434572685_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_397014120["MiniDFA4 {1}"]
DFA4_198636749_4[\"DFA4 {1}"/]
end
MiniDFA0_-5308154 -->|"m"|MiniDFA1_403742429
MiniDFA1_403742429 -->|"a"|MiniDFA2_2132465069
MiniDFA2_2132465069 -->|"t"|MiniDFA3_1845605165
MiniDFA3_1845605165 -->|"2"|MiniDFA4_397014120
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
MiniDFA0_-5308154(["MiniDFA0 {1}"])
MiniDFA1_403742429(["MiniDFA1 {1}"])
MiniDFA2_2132465069(["MiniDFA2 {1}"])
MiniDFA3_1845605165(["MiniDFA3 {1}"])
MiniDFA4_397014120[\"MiniDFA4 {1}"/]
MiniDFA0_-5308154 -->|"m"|MiniDFA1_403742429
MiniDFA1_403742429 -->|"a"|MiniDFA2_2132465069
MiniDFA2_2132465069 -->|"t"|MiniDFA3_1845605165
MiniDFA3_1845605165 -->|"2"|MiniDFA4_397014120
```
-------------------------------
