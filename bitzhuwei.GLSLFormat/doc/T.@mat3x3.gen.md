# 'mat3x3'

pattern: `mat3x3`

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
eNFA102_12_66572221[["εNFA102-12 regex start"]]
eNFA102_0_62279078[["εNFA102-0 char{1, 1}"]]
eNFA102_1_23640798[["εNFA102-1 char[1]"]]
eNFA102_2_11440597[["εNFA102-2 char{1, 1}"]]
eNFA102_3_35856517[["εNFA102-3 char[1]"]]
eNFA102_4_54273197[["εNFA102-4 char{1, 1}"]]
eNFA102_5_18696727[["εNFA102-5 char[1]"]]
eNFA102_6_34052821[["εNFA102-6 char{1, 1}"]]
eNFA102_7_38039934[["εNFA102-7 char[1]"]]
eNFA102_8_6815093[["εNFA102-8 char{1, 1}"]]
eNFA102_9_61335842[["εNFA102-9 char[1]"]]
eNFA102_10_15151670[["εNFA102-10 char{1, 1}"]]
eNFA102_11_2147306[["εNFA102-11 char[1]"]]
eNFA102_13_19325759[["εNFA102-13 regex end"]]
eNFA102_14_39714111[["εNFA102-14 post-regex start"]]
eNFA102_15_21882681[\"εNFA102-15 post-regex end"/]
eNFA102_12_66572221 -.->|"ε"|eNFA102_0_62279078
eNFA102_0_62279078 -->|"m"|eNFA102_1_23640798
eNFA102_1_23640798 -.->|"ε"|eNFA102_2_11440597
eNFA102_2_11440597 -->|"a"|eNFA102_3_35856517
eNFA102_3_35856517 -.->|"ε"|eNFA102_4_54273197
eNFA102_4_54273197 -->|"t"|eNFA102_5_18696727
eNFA102_5_18696727 -.->|"ε"|eNFA102_6_34052821
eNFA102_6_34052821 -->|"3"|eNFA102_7_38039934
eNFA102_7_38039934 -.->|"ε"|eNFA102_8_6815093
eNFA102_8_6815093 -->|"x"|eNFA102_9_61335842
eNFA102_9_61335842 -.->|"ε"|eNFA102_10_15151670
eNFA102_10_15151670 -->|"3"|eNFA102_11_2147306
eNFA102_11_2147306 -.->|"ε"|eNFA102_13_19325759
eNFA102_13_19325759 -.->|"ε"|eNFA102_14_39714111
eNFA102_14_39714111 -.->|"ε"|eNFA102_15_21882681
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
eNFA102_12_62726408[["εNFA102-12 regex start"]]
eNFA102_0_27666764[["εNFA102-0 char{1, 1}"]]
eNFA102_1_47674286[["εNFA102-1 char[1]"]]
eNFA102_2_26415391[["εNFA102-2 char{1, 1}"]]
eNFA102_3_36411928[["εNFA102-3 char[1]"]]
eNFA102_4_59271898[["εNFA102-4 char{1, 1}"]]
eNFA102_5_63685038[["εNFA102-5 char[1]"]]
eNFA102_6_36294438[["εNFA102-6 char{1, 1}"]]
eNFA102_7_58214490[["εNFA102-7 char[1]"]]
eNFA102_8_54168362[["εNFA102-8 char{1, 1}"]]
eNFA102_9_17753217[["εNFA102-9 char[1]"]]
eNFA102_10_25561231[["εNFA102-10 char{1, 1}"]]
eNFA102_11_28724493[\"εNFA102-11 char[1]"/]
eNFA102_13_57193853[\"εNFA102-13 regex end"/]
eNFA102_14_44982630[\"εNFA102-14 post-regex start"/]
eNFA102_15_2190491[\"εNFA102-15 post-regex end"/]
eNFA102_12_62726408 -.->|"ε"|eNFA102_0_27666764
eNFA102_12_62726408 -->|"m"|eNFA102_1_47674286
eNFA102_0_27666764 -->|"m"|eNFA102_1_47674286
eNFA102_1_47674286 -.->|"ε"|eNFA102_2_26415391
eNFA102_1_47674286 -->|"a"|eNFA102_3_36411928
eNFA102_2_26415391 -->|"a"|eNFA102_3_36411928
eNFA102_3_36411928 -.->|"ε"|eNFA102_4_59271898
eNFA102_3_36411928 -->|"t"|eNFA102_5_63685038
eNFA102_4_59271898 -->|"t"|eNFA102_5_63685038
eNFA102_5_63685038 -.->|"ε"|eNFA102_6_36294438
eNFA102_5_63685038 -->|"3"|eNFA102_7_58214490
eNFA102_6_36294438 -->|"3"|eNFA102_7_58214490
eNFA102_7_58214490 -.->|"ε"|eNFA102_8_54168362
eNFA102_7_58214490 -->|"x"|eNFA102_9_17753217
eNFA102_8_54168362 -->|"x"|eNFA102_9_17753217
eNFA102_9_17753217 -.->|"ε"|eNFA102_10_25561231
eNFA102_9_17753217 -->|"3"|eNFA102_11_28724493
eNFA102_10_25561231 -->|"3"|eNFA102_11_28724493
eNFA102_11_28724493 -.->|"ε"|eNFA102_13_57193853
eNFA102_11_28724493 -.->|"ε"|eNFA102_14_44982630
eNFA102_11_28724493 -.->|"ε"|eNFA102_15_2190491
eNFA102_13_57193853 -.->|"ε"|eNFA102_14_44982630
eNFA102_13_57193853 -.->|"ε"|eNFA102_15_2190491
eNFA102_14_44982630 -.->|"ε"|eNFA102_15_2190491
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
NFA102_12_19714419("NFA102-12 regex start")
NFA102_1_43212049("NFA102-1 char[1]")
NFA102_3_53364125("NFA102-3 char[1]")
NFA102_5_10515080("NFA102-5 char[1]")
NFA102_7_27526859("NFA102-7 char[1]")
NFA102_9_46415143("NFA102-9 char[1]")
NFA102_11_15083110[\"NFA102-11 char[1]"/]
NFA102_12_19714419 -->|"m"|NFA102_1_43212049
NFA102_1_43212049 -->|"a"|NFA102_3_53364125
NFA102_3_53364125 -->|"t"|NFA102_5_10515080
NFA102_5_10515080 -->|"3"|NFA102_7_27526859
NFA102_7_27526859 -->|"x"|NFA102_9_46415143
NFA102_9_46415143 -->|"3"|NFA102_11_15083110
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
subgraph DFA0_2058851666["DFA0 regex start"]
NFA102_12_19714419_0("NFA102-12 regex start")
end
subgraph DFA1_-1866664636["DFA1 {1}"]
NFA102_1_43212049_1("NFA102-1 char[1]")
end
subgraph DFA2_-773173225["DFA2 {1}"]
NFA102_3_53364125_2("NFA102-3 char[1]")
end
subgraph DFA3_-991145798["DFA3 {1}"]
NFA102_5_10515080_3("NFA102-5 char[1]")
end
subgraph DFA4_857056722["DFA4 {1}"]
NFA102_7_27526859_4("NFA102-7 char[1]")
end
subgraph DFA5_-1953131542["DFA5 {1}"]
NFA102_9_46415143_5("NFA102-9 char[1]")
end
subgraph DFA6_283218414["DFA6 {1}"]
NFA102_11_15083110_6[\"NFA102-11 char[1]"/]
end
DFA0_2058851666 -->|"m"|DFA1_-1866664636
DFA1_-1866664636 -->|"a"|DFA2_-773173225
DFA2_-773173225 -->|"t"|DFA3_-991145798
DFA3_-991145798 -->|"3"|DFA4_857056722
DFA4_857056722 -->|"x"|DFA5_-1953131542
DFA5_-1953131542 -->|"3"|DFA6_283218414
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
DFA0_2058851666{{"DFA0 regex start"}}
DFA1_-1866664636{{"DFA1 {1}"}}
DFA2_-773173225{{"DFA2 {1}"}}
DFA3_-991145798{{"DFA3 {1}"}}
DFA4_857056722{{"DFA4 {1}"}}
DFA5_-1953131542{{"DFA5 {1}"}}
DFA6_283218414[\"DFA6 {1}"/]
DFA0_2058851666 -->|"m"|DFA1_-1866664636
DFA1_-1866664636 -->|"a"|DFA2_-773173225
DFA2_-773173225 -->|"t"|DFA3_-991145798
DFA3_-991145798 -->|"3"|DFA4_857056722
DFA4_857056722 -->|"x"|DFA5_-1953131542
DFA5_-1953131542 -->|"3"|DFA6_283218414
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
subgraph MiniDFA0_316553748["MiniDFA0 {1}"]
DFA0_2058851666_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_103284237["MiniDFA1 {1}"]
DFA1_-1866664636_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-466510920["MiniDFA2 {1}"]
DFA2_-773173225_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1823492270["MiniDFA3 {1}"]
DFA3_-991145798_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1689651445["MiniDFA4 {1}"]
DFA4_857056722_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1492229413["MiniDFA5 {1}"]
DFA5_-1953131542_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1472420505["MiniDFA6 {1}"]
DFA6_283218414_6[\"DFA6 {1}"/]
end
MiniDFA0_316553748 -->|"m"|MiniDFA1_103284237
MiniDFA1_103284237 -->|"a"|MiniDFA2_-466510920
MiniDFA2_-466510920 -->|"t"|MiniDFA3_1823492270
MiniDFA3_1823492270 -->|"3"|MiniDFA4_-1689651445
MiniDFA4_-1689651445 -->|"x"|MiniDFA5_-1492229413
MiniDFA5_-1492229413 -->|"3"|MiniDFA6_1472420505
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
MiniDFA0_316553748(["MiniDFA0 {1}"])
MiniDFA1_103284237(["MiniDFA1 {1}"])
MiniDFA2_-466510920(["MiniDFA2 {1}"])
MiniDFA3_1823492270(["MiniDFA3 {1}"])
MiniDFA4_-1689651445(["MiniDFA4 {1}"])
MiniDFA5_-1492229413(["MiniDFA5 {1}"])
MiniDFA6_1472420505[\"MiniDFA6 {1}"/]
MiniDFA0_316553748 -->|"m"|MiniDFA1_103284237
MiniDFA1_103284237 -->|"a"|MiniDFA2_-466510920
MiniDFA2_-466510920 -->|"t"|MiniDFA3_1823492270
MiniDFA3_1823492270 -->|"3"|MiniDFA4_-1689651445
MiniDFA4_-1689651445 -->|"x"|MiniDFA5_-1492229413
MiniDFA5_-1492229413 -->|"3"|MiniDFA6_1472420505
```
-------------------------------
