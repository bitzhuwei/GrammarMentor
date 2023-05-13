# 'image3D'

pattern: `image3D`

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
eNFA166_14_36591643[["εNFA166-14 regex start"]]
eNFA166_0_60889336[["εNFA166-0 char{1, 1}"]]
eNFA166_1_11133117[["εNFA166-1 char[1]"]]
eNFA166_2_33089196[["εNFA166-2 char{1, 1}"]]
eNFA166_3_29367308[["εNFA166-3 char[1]"]]
eNFA166_4_62979183[["εNFA166-4 char{1, 1}"]]
eNFA166_5_29941743[["εNFA166-5 char[1]"]]
eNFA166_6_1040236[["εNFA166-6 char{1, 1}"]]
eNFA166_7_9362127[["εNFA166-7 char[1]"]]
eNFA166_8_17150281[["εNFA166-8 char{1, 1}"]]
eNFA166_9_20134803[["εNFA166-9 char[1]"]]
eNFA166_10_46995502[["εNFA166-10 char{1, 1}"]]
eNFA166_11_20306340[["εNFA166-11 char[1]"]]
eNFA166_12_48539332[["εNFA166-12 char{1, 1}"]]
eNFA166_13_34200809[["εNFA166-13 char[1]"]]
eNFA166_15_39371826[["εNFA166-15 regex end"]]
eNFA166_16_18802122[["εNFA166-16 post-regex start"]]
eNFA166_17_35001377[\"εNFA166-17 post-regex end"/]
eNFA166_14_36591643 -.->|"ε"|eNFA166_0_60889336
eNFA166_0_60889336 -->|"i"|eNFA166_1_11133117
eNFA166_1_11133117 -.->|"ε"|eNFA166_2_33089196
eNFA166_2_33089196 -->|"m"|eNFA166_3_29367308
eNFA166_3_29367308 -.->|"ε"|eNFA166_4_62979183
eNFA166_4_62979183 -->|"a"|eNFA166_5_29941743
eNFA166_5_29941743 -.->|"ε"|eNFA166_6_1040236
eNFA166_6_1040236 -->|"g"|eNFA166_7_9362127
eNFA166_7_9362127 -.->|"ε"|eNFA166_8_17150281
eNFA166_8_17150281 -->|"e"|eNFA166_9_20134803
eNFA166_9_20134803 -.->|"ε"|eNFA166_10_46995502
eNFA166_10_46995502 -->|"3"|eNFA166_11_20306340
eNFA166_11_20306340 -.->|"ε"|eNFA166_12_48539332
eNFA166_12_48539332 -->|"D"|eNFA166_13_34200809
eNFA166_13_34200809 -.->|"ε"|eNFA166_15_39371826
eNFA166_15_39371826 -.->|"ε"|eNFA166_16_18802122
eNFA166_16_18802122 -.->|"ε"|eNFA166_17_35001377
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
eNFA166_14_46576945[["εNFA166-14 regex start"]]
eNFA166_0_16539321[["εNFA166-0 char{1, 1}"]]
eNFA166_1_14636163[["εNFA166-1 char[1]"]]
eNFA166_2_64616609[["εNFA166-2 char{1, 1}"]]
eNFA166_3_44678570[["εNFA166-3 char[1]"]]
eNFA166_4_66562817[["εNFA166-4 char{1, 1}"]]
eNFA166_5_62194446[["εNFA166-5 char[1]"]]
eNFA166_6_22879106[["εNFA166-6 char{1, 1}"]]
eNFA166_7_4585366[["εNFA166-7 char[1]"]]
eNFA166_8_41268299[["εNFA166-8 char{1, 1}"]]
eNFA166_9_35870379[["εNFA166-9 char[1]"]]
eNFA166_10_54397957[["εNFA166-10 char{1, 1}"]]
eNFA166_11_19819572[["εNFA166-11 char[1]"]]
eNFA166_12_44158424[["εNFA166-12 char{1, 1}"]]
eNFA166_13_61881498[\"εNFA166-13 char[1]"/]
eNFA166_15_20062571[\"εNFA166-15 regex end"/]
eNFA166_16_46345412[\"εNFA166-16 post-regex start"/]
eNFA166_17_14455526[\"εNFA166-17 post-regex end"/]
eNFA166_14_46576945 -.->|"ε"|eNFA166_0_16539321
eNFA166_14_46576945 -->|"i"|eNFA166_1_14636163
eNFA166_0_16539321 -->|"i"|eNFA166_1_14636163
eNFA166_1_14636163 -.->|"ε"|eNFA166_2_64616609
eNFA166_1_14636163 -->|"m"|eNFA166_3_44678570
eNFA166_2_64616609 -->|"m"|eNFA166_3_44678570
eNFA166_3_44678570 -.->|"ε"|eNFA166_4_66562817
eNFA166_3_44678570 -->|"a"|eNFA166_5_62194446
eNFA166_4_66562817 -->|"a"|eNFA166_5_62194446
eNFA166_5_62194446 -.->|"ε"|eNFA166_6_22879106
eNFA166_5_62194446 -->|"g"|eNFA166_7_4585366
eNFA166_6_22879106 -->|"g"|eNFA166_7_4585366
eNFA166_7_4585366 -.->|"ε"|eNFA166_8_41268299
eNFA166_7_4585366 -->|"e"|eNFA166_9_35870379
eNFA166_8_41268299 -->|"e"|eNFA166_9_35870379
eNFA166_9_35870379 -.->|"ε"|eNFA166_10_54397957
eNFA166_9_35870379 -->|"3"|eNFA166_11_19819572
eNFA166_10_54397957 -->|"3"|eNFA166_11_19819572
eNFA166_11_19819572 -.->|"ε"|eNFA166_12_44158424
eNFA166_11_19819572 -->|"D"|eNFA166_13_61881498
eNFA166_12_44158424 -->|"D"|eNFA166_13_61881498
eNFA166_13_61881498 -.->|"ε"|eNFA166_15_20062571
eNFA166_13_61881498 -.->|"ε"|eNFA166_16_46345412
eNFA166_13_61881498 -.->|"ε"|eNFA166_17_14455526
eNFA166_15_20062571 -.->|"ε"|eNFA166_16_46345412
eNFA166_15_20062571 -.->|"ε"|eNFA166_17_14455526
eNFA166_16_46345412 -.->|"ε"|eNFA166_17_14455526
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
NFA166_14_62990874("NFA166-14 regex start")
NFA166_1_30046962("NFA166-1 char[1]")
NFA166_3_1987206("NFA166-3 char[1]")
NFA166_5_17884854("NFA166-5 char[1]")
NFA166_7_26745965("NFA166-7 char[1]")
NFA166_9_39387099("NFA166-9 char[1]")
NFA166_11_18939577("NFA166-11 char[1]")
NFA166_13_36238473[\"NFA166-13 char[1]"/]
NFA166_14_62990874 -->|"i"|NFA166_1_30046962
NFA166_1_30046962 -->|"m"|NFA166_3_1987206
NFA166_3_1987206 -->|"a"|NFA166_5_17884854
NFA166_5_17884854 -->|"g"|NFA166_7_26745965
NFA166_7_26745965 -->|"e"|NFA166_9_39387099
NFA166_9_39387099 -->|"3"|NFA166_11_18939577
NFA166_11_18939577 -->|"D"|NFA166_13_36238473
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
subgraph DFA0_-348179080["DFA0 regex start"]
NFA166_14_62990874_0("NFA166-14 regex start")
end
subgraph DFA1_1014188469["DFA1 {1}"]
NFA166_1_30046962_1("NFA166-1 char[1]")
end
subgraph DFA2_-646101636["DFA2 {1}"]
NFA166_3_1987206_2("NFA166-3 char[1]")
end
subgraph DFA3_2014510733["DFA3 {1}"]
NFA166_5_17884854_3("NFA166-5 char[1]")
end
subgraph DFA4_702045539["DFA4 {1}"]
NFA166_7_26745965_4("NFA166-7 char[1]")
end
subgraph DFA5_1153747115["DFA5 {1}"]
NFA166_9_39387099_5("NFA166-9 char[1]")
end
subgraph DFA6_-790842844["DFA6 {1}"]
NFA166_11_18939577_6("NFA166-11 char[1]")
end
subgraph DFA7_409349388["DFA7 {1}"]
NFA166_13_36238473_7[\"NFA166-13 char[1]"/]
end
DFA0_-348179080 -->|"i"|DFA1_1014188469
DFA1_1014188469 -->|"m"|DFA2_-646101636
DFA2_-646101636 -->|"a"|DFA3_2014510733
DFA3_2014510733 -->|"g"|DFA4_702045539
DFA4_702045539 -->|"e"|DFA5_1153747115
DFA5_1153747115 -->|"3"|DFA6_-790842844
DFA6_-790842844 -->|"D"|DFA7_409349388
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
DFA0_-348179080{{"DFA0 regex start"}}
DFA1_1014188469{{"DFA1 {1}"}}
DFA2_-646101636{{"DFA2 {1}"}}
DFA3_2014510733{{"DFA3 {1}"}}
DFA4_702045539{{"DFA4 {1}"}}
DFA5_1153747115{{"DFA5 {1}"}}
DFA6_-790842844{{"DFA6 {1}"}}
DFA7_409349388[\"DFA7 {1}"/]
DFA0_-348179080 -->|"i"|DFA1_1014188469
DFA1_1014188469 -->|"m"|DFA2_-646101636
DFA2_-646101636 -->|"a"|DFA3_2014510733
DFA3_2014510733 -->|"g"|DFA4_702045539
DFA4_702045539 -->|"e"|DFA5_1153747115
DFA5_1153747115 -->|"3"|DFA6_-790842844
DFA6_-790842844 -->|"D"|DFA7_409349388
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
subgraph MiniDFA0_1591336653["MiniDFA0 {1}"]
DFA0_-348179080_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-537095777["MiniDFA1 {1}"]
DFA1_1014188469_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_162909637["MiniDFA2 {1}"]
DFA2_-646101636_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-2052547670["MiniDFA3 {1}"]
DFA3_2014510733_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_409678256["MiniDFA4 {1}"]
DFA4_702045539_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1830759626["MiniDFA5 {1}"]
DFA5_1153747115_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_550955661["MiniDFA6 {1}"]
DFA6_-790842844_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1212100935["MiniDFA7 {1}"]
DFA7_409349388_7[\"DFA7 {1}"/]
end
MiniDFA0_1591336653 -->|"i"|MiniDFA1_-537095777
MiniDFA1_-537095777 -->|"m"|MiniDFA2_162909637
MiniDFA2_162909637 -->|"a"|MiniDFA3_-2052547670
MiniDFA3_-2052547670 -->|"g"|MiniDFA4_409678256
MiniDFA4_409678256 -->|"e"|MiniDFA5_1830759626
MiniDFA5_1830759626 -->|"3"|MiniDFA6_550955661
MiniDFA6_550955661 -->|"D"|MiniDFA7_-1212100935
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
MiniDFA0_1591336653(["MiniDFA0 {1}"])
MiniDFA1_-537095777(["MiniDFA1 {1}"])
MiniDFA2_162909637(["MiniDFA2 {1}"])
MiniDFA3_-2052547670(["MiniDFA3 {1}"])
MiniDFA4_409678256(["MiniDFA4 {1}"])
MiniDFA5_1830759626(["MiniDFA5 {1}"])
MiniDFA6_550955661(["MiniDFA6 {1}"])
MiniDFA7_-1212100935[\"MiniDFA7 {1}"/]
MiniDFA0_1591336653 -->|"i"|MiniDFA1_-537095777
MiniDFA1_-537095777 -->|"m"|MiniDFA2_162909637
MiniDFA2_162909637 -->|"a"|MiniDFA3_-2052547670
MiniDFA3_-2052547670 -->|"g"|MiniDFA4_409678256
MiniDFA4_409678256 -->|"e"|MiniDFA5_1830759626
MiniDFA5_1830759626 -->|"3"|MiniDFA6_550955661
MiniDFA6_550955661 -->|"D"|MiniDFA7_-1212100935
```
-------------------------------
