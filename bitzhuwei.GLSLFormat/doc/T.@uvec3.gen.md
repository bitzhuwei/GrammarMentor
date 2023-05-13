# 'uvec3'

pattern: `uvec3`

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
eNFA93_10_46250162[["εNFA93-10 regex start"]]
eNFA93_0_13598275[["εNFA93-0 char{1, 1}"]]
eNFA93_1_55275618[["εNFA93-1 char[1]"]]
eNFA93_2_27718519[["εNFA93-2 char{1, 1}"]]
eNFA93_3_48140083[["εNFA93-3 char[1]"]]
eNFA93_4_30607567[["εNFA93-4 char{1, 1}"]]
eNFA93_5_7032652[["εNFA93-5 char[1]"]]
eNFA93_6_63293876[["εNFA93-6 char{1, 1}"]]
eNFA93_7_32773974[["εNFA93-7 char[1]"]]
eNFA93_8_26530317[["εNFA93-8 char{1, 1}"]]
eNFA93_9_37446265[["εNFA93-9 char[1]"]]
eNFA93_11_1472067[["εNFA93-11 regex end"]]
eNFA93_12_13248604[["εNFA93-12 post-regex start"]]
eNFA93_13_52128573[\"εNFA93-13 post-regex end"/]
eNFA93_10_46250162 -.->|"ε"|eNFA93_0_13598275
eNFA93_0_13598275 -->|"u"|eNFA93_1_55275618
eNFA93_1_55275618 -.->|"ε"|eNFA93_2_27718519
eNFA93_2_27718519 -->|"v"|eNFA93_3_48140083
eNFA93_3_48140083 -.->|"ε"|eNFA93_4_30607567
eNFA93_4_30607567 -->|"e"|eNFA93_5_7032652
eNFA93_5_7032652 -.->|"ε"|eNFA93_6_63293876
eNFA93_6_63293876 -->|"c"|eNFA93_7_32773974
eNFA93_7_32773974 -.->|"ε"|eNFA93_8_26530317
eNFA93_8_26530317 -->|"3"|eNFA93_9_37446265
eNFA93_9_37446265 -.->|"ε"|eNFA93_11_1472067
eNFA93_11_1472067 -.->|"ε"|eNFA93_12_13248604
eNFA93_12_13248604 -.->|"ε"|eNFA93_13_52128573
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
eNFA93_10_66503975[["εNFA93-10 regex start"]]
eNFA93_0_61664867[["εNFA93-0 char{1, 1}"]]
eNFA93_1_18112899[["εNFA93-1 char[1]"]]
eNFA93_2_28798367[["εNFA93-2 char{1, 1}"]]
eNFA93_3_57858711[["εNFA93-3 char[1]"]]
eNFA93_4_50966358[["εNFA93-4 char{1, 1}"]]
eNFA93_5_56044044[["εNFA93-5 char[1]"]]
eNFA93_6_34634354[["εNFA93-6 char{1, 1}"]]
eNFA93_7_43273738[["εNFA93-7 char[1]"]]
eNFA93_8_53919323[["εNFA93-8 char{1, 1}"]]
eNFA93_9_15511864[\"εNFA93-9 char[1]"/]
eNFA93_11_5389048[\"εNFA93-11 regex end"/]
eNFA93_12_48501438[\"εNFA93-12 post-regex start"/]
eNFA93_13_33859762[\"εNFA93-13 post-regex end"/]
eNFA93_10_66503975 -.->|"ε"|eNFA93_0_61664867
eNFA93_10_66503975 -->|"u"|eNFA93_1_18112899
eNFA93_0_61664867 -->|"u"|eNFA93_1_18112899
eNFA93_1_18112899 -.->|"ε"|eNFA93_2_28798367
eNFA93_1_18112899 -->|"v"|eNFA93_3_57858711
eNFA93_2_28798367 -->|"v"|eNFA93_3_57858711
eNFA93_3_57858711 -.->|"ε"|eNFA93_4_50966358
eNFA93_3_57858711 -->|"e"|eNFA93_5_56044044
eNFA93_4_50966358 -->|"e"|eNFA93_5_56044044
eNFA93_5_56044044 -.->|"ε"|eNFA93_6_34634354
eNFA93_5_56044044 -->|"c"|eNFA93_7_43273738
eNFA93_6_34634354 -->|"c"|eNFA93_7_43273738
eNFA93_7_43273738 -.->|"ε"|eNFA93_8_53919323
eNFA93_7_43273738 -->|"3"|eNFA93_9_15511864
eNFA93_8_53919323 -->|"3"|eNFA93_9_15511864
eNFA93_9_15511864 -.->|"ε"|eNFA93_11_5389048
eNFA93_9_15511864 -.->|"ε"|eNFA93_12_48501438
eNFA93_9_15511864 -.->|"ε"|eNFA93_13_33859762
eNFA93_11_5389048 -.->|"ε"|eNFA93_12_48501438
eNFA93_11_5389048 -.->|"ε"|eNFA93_13_33859762
eNFA93_12_48501438 -.->|"ε"|eNFA93_13_33859762
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
NFA93_10_36302405("NFA93-10 regex start")
NFA93_1_58286192("NFA93-1 char[1]")
NFA93_3_54813684("NFA93-3 char[1]")
NFA93_5_23561115("NFA93-5 char[1]")
NFA93_7_10723444("NFA93-7 char[1]")
NFA93_9_29402138[\"NFA93-9 char[1]"/]
NFA93_10_36302405 -->|"u"|NFA93_1_58286192
NFA93_1_58286192 -->|"v"|NFA93_3_54813684
NFA93_3_54813684 -->|"e"|NFA93_5_23561115
NFA93_5_23561115 -->|"c"|NFA93_7_10723444
NFA93_7_10723444 -->|"3"|NFA93_9_29402138
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
subgraph DFA0_391733723["DFA0 regex start"]
NFA93_10_36302405_0("NFA93-10 regex start")
end
subgraph DFA1_-193784163["DFA1 {1}"]
NFA93_1_58286192_1("NFA93-1 char[1]")
end
subgraph DFA2_1429351294["DFA2 {1}"]
NFA93_3_54813684_2("NFA93-3 char[1]")
end
subgraph DFA3_673015746["DFA3 {1}"]
NFA93_5_23561115_3("NFA93-5 char[1]")
end
subgraph DFA4_82186651["DFA4 {1}"]
NFA93_7_10723444_4("NFA93-7 char[1]")
end
subgraph DFA5_548009503["DFA5 {1}"]
NFA93_9_29402138_5[\"NFA93-9 char[1]"/]
end
DFA0_391733723 -->|"u"|DFA1_-193784163
DFA1_-193784163 -->|"v"|DFA2_1429351294
DFA2_1429351294 -->|"e"|DFA3_673015746
DFA3_673015746 -->|"c"|DFA4_82186651
DFA4_82186651 -->|"3"|DFA5_548009503
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
DFA0_391733723{{"DFA0 regex start"}}
DFA1_-193784163{{"DFA1 {1}"}}
DFA2_1429351294{{"DFA2 {1}"}}
DFA3_673015746{{"DFA3 {1}"}}
DFA4_82186651{{"DFA4 {1}"}}
DFA5_548009503[\"DFA5 {1}"/]
DFA0_391733723 -->|"u"|DFA1_-193784163
DFA1_-193784163 -->|"v"|DFA2_1429351294
DFA2_1429351294 -->|"e"|DFA3_673015746
DFA3_673015746 -->|"c"|DFA4_82186651
DFA4_82186651 -->|"3"|DFA5_548009503
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
subgraph MiniDFA0_1006870387["MiniDFA0 {1}"]
DFA0_391733723_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-793741413["MiniDFA1 {1}"]
DFA1_-193784163_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_769252124["MiniDFA2 {1}"]
DFA2_1429351294_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-180069350["MiniDFA3 {1}"]
DFA3_673015746_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1795647862["MiniDFA4 {1}"]
DFA4_82186651_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-83850558["MiniDFA5 {1}"]
DFA5_548009503_5[\"DFA5 {1}"/]
end
MiniDFA0_1006870387 -->|"u"|MiniDFA1_-793741413
MiniDFA1_-793741413 -->|"v"|MiniDFA2_769252124
MiniDFA2_769252124 -->|"e"|MiniDFA3_-180069350
MiniDFA3_-180069350 -->|"c"|MiniDFA4_1795647862
MiniDFA4_1795647862 -->|"3"|MiniDFA5_-83850558
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
MiniDFA0_1006870387(["MiniDFA0 {1}"])
MiniDFA1_-793741413(["MiniDFA1 {1}"])
MiniDFA2_769252124(["MiniDFA2 {1}"])
MiniDFA3_-180069350(["MiniDFA3 {1}"])
MiniDFA4_1795647862(["MiniDFA4 {1}"])
MiniDFA5_-83850558[\"MiniDFA5 {1}"/]
MiniDFA0_1006870387 -->|"u"|MiniDFA1_-793741413
MiniDFA1_-793741413 -->|"v"|MiniDFA2_769252124
MiniDFA2_769252124 -->|"e"|MiniDFA3_-180069350
MiniDFA3_-180069350 -->|"c"|MiniDFA4_1795647862
MiniDFA4_1795647862 -->|"3"|MiniDFA5_-83850558
```
-------------------------------
