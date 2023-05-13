# 'iimage2D'

pattern: `iimage2D`

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
eNFA164_16_6046518[["εNFA164-16 regex start"]]
eNFA164_0_54418662[["εNFA164-0 char{1, 1}"]]
eNFA164_1_20005910[["εNFA164-1 char[1]"]]
eNFA164_2_45835463[["εNFA164-2 char{1, 1}"]]
eNFA164_3_9865986[["εNFA164-3 char[1]"]]
eNFA164_4_21685017[["εNFA164-4 char{1, 1}"]]
eNFA164_5_60947427[["εNFA164-5 char[1]"]]
eNFA164_6_11655939[["εNFA164-6 char{1, 1}"]]
eNFA164_7_37794593[["εNFA164-7 char[1]"]]
eNFA164_8_4607022[["εNFA164-8 char{1, 1}"]]
eNFA164_9_41463203[["εNFA164-9 char[1]"]]
eNFA164_10_37624514[["εNFA164-10 char{1, 1}"]]
eNFA164_11_3076306[["εNFA164-11 char[1]"]]
eNFA164_12_27686757[["εNFA164-12 char{1, 1}"]]
eNFA164_13_47854229[["εNFA164-13 char[1]"]]
eNFA164_14_28034882[["εNFA164-14 char{1, 1}"]]
eNFA164_15_50987349[["εNFA164-15 char[1]"]]
eNFA164_17_56232959[["εNFA164-17 regex end"]]
eNFA164_18_36334585[["εNFA164-18 post-regex start"]]
eNFA164_19_58575812[\"εNFA164-19 post-regex end"/]
eNFA164_16_6046518 -.->|"ε"|eNFA164_0_54418662
eNFA164_0_54418662 -->|"i"|eNFA164_1_20005910
eNFA164_1_20005910 -.->|"ε"|eNFA164_2_45835463
eNFA164_2_45835463 -->|"i"|eNFA164_3_9865986
eNFA164_3_9865986 -.->|"ε"|eNFA164_4_21685017
eNFA164_4_21685017 -->|"m"|eNFA164_5_60947427
eNFA164_5_60947427 -.->|"ε"|eNFA164_6_11655939
eNFA164_6_11655939 -->|"a"|eNFA164_7_37794593
eNFA164_7_37794593 -.->|"ε"|eNFA164_8_4607022
eNFA164_8_4607022 -->|"g"|eNFA164_9_41463203
eNFA164_9_41463203 -.->|"ε"|eNFA164_10_37624514
eNFA164_10_37624514 -->|"e"|eNFA164_11_3076306
eNFA164_11_3076306 -.->|"ε"|eNFA164_12_27686757
eNFA164_12_27686757 -->|"2"|eNFA164_13_47854229
eNFA164_13_47854229 -.->|"ε"|eNFA164_14_28034882
eNFA164_14_28034882 -->|"D"|eNFA164_15_50987349
eNFA164_15_50987349 -.->|"ε"|eNFA164_17_56232959
eNFA164_17_56232959 -.->|"ε"|eNFA164_18_36334585
eNFA164_18_36334585 -.->|"ε"|eNFA164_19_58575812
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
eNFA164_16_57420266[["εNFA164-16 regex start"]]
eNFA164_0_47020346[["εNFA164-0 char{1, 1}"]]
eNFA164_1_20529935[["εNFA164-1 char[1]"]]
eNFA164_2_50551688[["εNFA164-2 char{1, 1}"]]
eNFA164_3_52312016[["εNFA164-3 char[1]"]]
eNFA164_4_1046103[["εNFA164-4 char{1, 1}"]]
eNFA164_5_9414935[["εNFA164-5 char[1]"]]
eNFA164_6_17625551[["εNFA164-6 char{1, 1}"]]
eNFA164_7_24412233[["εNFA164-7 char[1]"]]
eNFA164_8_18383511[["εNFA164-8 char{1, 1}"]]
eNFA164_9_31233872[["εNFA164-9 char[1]"]]
eNFA164_10_12669399[["εNFA164-10 char{1, 1}"]]
eNFA164_11_46915732[["εNFA164-11 char[1]"]]
eNFA164_12_19588408[["εNFA164-12 char{1, 1}"]]
eNFA164_13_42077948[["εNFA164-13 char[1]"]]
eNFA164_14_43157217[["εNFA164-14 char{1, 1}"]]
eNFA164_15_52870641[\"εNFA164-15 char[1]"/]
eNFA164_17_6073723[\"εNFA164-17 regex end"/]
eNFA164_18_54663514[\"εNFA164-18 post-regex start"/]
eNFA164_19_22209582[\"εNFA164-19 post-regex end"/]
eNFA164_16_57420266 -.->|"ε"|eNFA164_0_47020346
eNFA164_16_57420266 -->|"i"|eNFA164_1_20529935
eNFA164_0_47020346 -->|"i"|eNFA164_1_20529935
eNFA164_1_20529935 -.->|"ε"|eNFA164_2_50551688
eNFA164_1_20529935 -->|"i"|eNFA164_3_52312016
eNFA164_2_50551688 -->|"i"|eNFA164_3_52312016
eNFA164_3_52312016 -.->|"ε"|eNFA164_4_1046103
eNFA164_3_52312016 -->|"m"|eNFA164_5_9414935
eNFA164_4_1046103 -->|"m"|eNFA164_5_9414935
eNFA164_5_9414935 -.->|"ε"|eNFA164_6_17625551
eNFA164_5_9414935 -->|"a"|eNFA164_7_24412233
eNFA164_6_17625551 -->|"a"|eNFA164_7_24412233
eNFA164_7_24412233 -.->|"ε"|eNFA164_8_18383511
eNFA164_7_24412233 -->|"g"|eNFA164_9_31233872
eNFA164_8_18383511 -->|"g"|eNFA164_9_31233872
eNFA164_9_31233872 -.->|"ε"|eNFA164_10_12669399
eNFA164_9_31233872 -->|"e"|eNFA164_11_46915732
eNFA164_10_12669399 -->|"e"|eNFA164_11_46915732
eNFA164_11_46915732 -.->|"ε"|eNFA164_12_19588408
eNFA164_11_46915732 -->|"2"|eNFA164_13_42077948
eNFA164_12_19588408 -->|"2"|eNFA164_13_42077948
eNFA164_13_42077948 -.->|"ε"|eNFA164_14_43157217
eNFA164_13_42077948 -->|"D"|eNFA164_15_52870641
eNFA164_14_43157217 -->|"D"|eNFA164_15_52870641
eNFA164_15_52870641 -.->|"ε"|eNFA164_17_6073723
eNFA164_15_52870641 -.->|"ε"|eNFA164_18_54663514
eNFA164_15_52870641 -.->|"ε"|eNFA164_19_22209582
eNFA164_17_6073723 -.->|"ε"|eNFA164_18_54663514
eNFA164_17_6073723 -.->|"ε"|eNFA164_19_22209582
eNFA164_18_54663514 -.->|"ε"|eNFA164_19_22209582
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
NFA164_16_65668512("NFA164-16 regex start")
NFA164_1_54145697("NFA164-1 char[1]")
NFA164_3_17549226("NFA164-3 char[1]")
NFA164_5_23725308("NFA164-5 char[1]")
NFA164_7_12201184("NFA164-7 char[1]")
NFA164_9_42701800("NFA164-9 char[1]")
NFA164_11_48771884("NFA164-11 char[1]")
NFA164_13_36293772("NFA164-13 char[1]")
NFA164_15_58208499[\"NFA164-15 char[1]"/]
NFA164_16_65668512 -->|"i"|NFA164_1_54145697
NFA164_1_54145697 -->|"i"|NFA164_3_17549226
NFA164_3_17549226 -->|"m"|NFA164_5_23725308
NFA164_5_23725308 -->|"a"|NFA164_7_12201184
NFA164_7_12201184 -->|"g"|NFA164_9_42701800
NFA164_9_42701800 -->|"e"|NFA164_11_48771884
NFA164_11_48771884 -->|"2"|NFA164_13_36293772
NFA164_13_36293772 -->|"D"|NFA164_15_58208499
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
subgraph DFA0_-1685155682["DFA0 regex start"]
NFA164_16_65668512_0("NFA164-16 regex start")
end
subgraph DFA1_-1665531742["DFA1 {1}"]
NFA164_1_54145697_1("NFA164-1 char[1]")
end
subgraph DFA2_1097594940["DFA2 {1}"]
NFA164_3_17549226_2("NFA164-3 char[1]")
end
subgraph DFA3_-560740498["DFA3 {1}"]
NFA164_5_23725308_3("NFA164-5 char[1]")
end
subgraph DFA4_1010365526["DFA4 {1}"]
NFA164_7_12201184_4("NFA164-7 char[1]")
end
subgraph DFA5_1998189722["DFA5 {1}"]
NFA164_9_42701800_5("NFA164-9 char[1]")
end
subgraph DFA6_1488642942["DFA6 {1}"]
NFA164_11_48771884_6("NFA164-11 char[1]")
end
subgraph DFA7_-1779503099["DFA7 {1}"]
NFA164_13_36293772_7("NFA164-13 char[1]")
end
subgraph DFA8_-1933287259["DFA8 {1}"]
NFA164_15_58208499_8[\"NFA164-15 char[1]"/]
end
DFA0_-1685155682 -->|"i"|DFA1_-1665531742
DFA1_-1665531742 -->|"i"|DFA2_1097594940
DFA2_1097594940 -->|"m"|DFA3_-560740498
DFA3_-560740498 -->|"a"|DFA4_1010365526
DFA4_1010365526 -->|"g"|DFA5_1998189722
DFA5_1998189722 -->|"e"|DFA6_1488642942
DFA6_1488642942 -->|"2"|DFA7_-1779503099
DFA7_-1779503099 -->|"D"|DFA8_-1933287259
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
DFA0_-1685155682{{"DFA0 regex start"}}
DFA1_-1665531742{{"DFA1 {1}"}}
DFA2_1097594940{{"DFA2 {1}"}}
DFA3_-560740498{{"DFA3 {1}"}}
DFA4_1010365526{{"DFA4 {1}"}}
DFA5_1998189722{{"DFA5 {1}"}}
DFA6_1488642942{{"DFA6 {1}"}}
DFA7_-1779503099{{"DFA7 {1}"}}
DFA8_-1933287259[\"DFA8 {1}"/]
DFA0_-1685155682 -->|"i"|DFA1_-1665531742
DFA1_-1665531742 -->|"i"|DFA2_1097594940
DFA2_1097594940 -->|"m"|DFA3_-560740498
DFA3_-560740498 -->|"a"|DFA4_1010365526
DFA4_1010365526 -->|"g"|DFA5_1998189722
DFA5_1998189722 -->|"e"|DFA6_1488642942
DFA6_1488642942 -->|"2"|DFA7_-1779503099
DFA7_-1779503099 -->|"D"|DFA8_-1933287259
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
subgraph MiniDFA0_427866116["MiniDFA0 {1}"]
DFA0_-1685155682_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-986360058["MiniDFA1 {1}"]
DFA1_-1665531742_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-417544969["MiniDFA2 {1}"]
DFA2_1097594940_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_729633052["MiniDFA3 {1}"]
DFA3_-560740498_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1575429531["MiniDFA4 {1}"]
DFA4_1010365526_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_292002012["MiniDFA5 {1}"]
DFA5_1998189722_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-402608627["MiniDFA6 {1}"]
DFA6_1488642942_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1427052613["MiniDFA7 {1}"]
DFA7_-1779503099_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_2041340430["MiniDFA8 {1}"]
DFA8_-1933287259_8[\"DFA8 {1}"/]
end
MiniDFA0_427866116 -->|"i"|MiniDFA1_-986360058
MiniDFA1_-986360058 -->|"i"|MiniDFA2_-417544969
MiniDFA2_-417544969 -->|"m"|MiniDFA3_729633052
MiniDFA3_729633052 -->|"a"|MiniDFA4_1575429531
MiniDFA4_1575429531 -->|"g"|MiniDFA5_292002012
MiniDFA5_292002012 -->|"e"|MiniDFA6_-402608627
MiniDFA6_-402608627 -->|"2"|MiniDFA7_-1427052613
MiniDFA7_-1427052613 -->|"D"|MiniDFA8_2041340430
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
MiniDFA0_427866116(["MiniDFA0 {1}"])
MiniDFA1_-986360058(["MiniDFA1 {1}"])
MiniDFA2_-417544969(["MiniDFA2 {1}"])
MiniDFA3_729633052(["MiniDFA3 {1}"])
MiniDFA4_1575429531(["MiniDFA4 {1}"])
MiniDFA5_292002012(["MiniDFA5 {1}"])
MiniDFA6_-402608627(["MiniDFA6 {1}"])
MiniDFA7_-1427052613(["MiniDFA7 {1}"])
MiniDFA8_2041340430[\"MiniDFA8 {1}"/]
MiniDFA0_427866116 -->|"i"|MiniDFA1_-986360058
MiniDFA1_-986360058 -->|"i"|MiniDFA2_-417544969
MiniDFA2_-417544969 -->|"m"|MiniDFA3_729633052
MiniDFA3_729633052 -->|"a"|MiniDFA4_1575429531
MiniDFA4_1575429531 -->|"g"|MiniDFA5_292002012
MiniDFA5_292002012 -->|"e"|MiniDFA6_-402608627
MiniDFA6_-402608627 -->|"2"|MiniDFA7_-1427052613
MiniDFA7_-1427052613 -->|"D"|MiniDFA8_2041340430
```
-------------------------------
