# 'continue'

pattern: `continue`

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
eNFA205_16_52394293[["εNFA205-16 regex start"]]
eNFA205_0_1786593[["εNFA205-0 char{1, 1}"]]
eNFA205_1_16079341[["εNFA205-1 char[1]"]]
eNFA205_2_10496346[["εNFA205-2 char{1, 1}"]]
eNFA205_3_27358258[["εNFA205-3 char[1]"]]
eNFA205_4_44897732[["εNFA205-4 char{1, 1}"]]
eNFA205_5_1426411[["εNFA205-5 char[1]"]]
eNFA205_6_12837703[["εNFA205-6 char{1, 1}"]]
eNFA205_7_48430465[["εNFA205-7 char[1]"]]
eNFA205_8_33221002[["εNFA205-8 char{1, 1}"]]
eNFA205_9_30553563[["εNFA205-9 char[1]"]]
eNFA205_10_6546613[["εNFA205-10 char{1, 1}"]]
eNFA205_11_58919521[["εNFA205-11 char[1]"]]
eNFA205_12_60513649[["εNFA205-12 char{1, 1}"]]
eNFA205_13_7751933[["εNFA205-13 char[1]"]]
eNFA205_14_2658533[["εNFA205-14 char{1, 1}"]]
eNFA205_15_23926804[["εNFA205-15 char[1]"]]
eNFA205_17_14014650[["εNFA205-17 regex end"]]
eNFA205_18_59022992[["εNFA205-18 post-regex start"]]
eNFA205_19_61444888[\"εNFA205-19 post-regex end"/]
eNFA205_16_52394293 -.->|"ε"|eNFA205_0_1786593
eNFA205_0_1786593 -->|"c"|eNFA205_1_16079341
eNFA205_1_16079341 -.->|"ε"|eNFA205_2_10496346
eNFA205_2_10496346 -->|"o"|eNFA205_3_27358258
eNFA205_3_27358258 -.->|"ε"|eNFA205_4_44897732
eNFA205_4_44897732 -->|"n"|eNFA205_5_1426411
eNFA205_5_1426411 -.->|"ε"|eNFA205_6_12837703
eNFA205_6_12837703 -->|"t"|eNFA205_7_48430465
eNFA205_7_48430465 -.->|"ε"|eNFA205_8_33221002
eNFA205_8_33221002 -->|"i"|eNFA205_9_30553563
eNFA205_9_30553563 -.->|"ε"|eNFA205_10_6546613
eNFA205_10_6546613 -->|"n"|eNFA205_11_58919521
eNFA205_11_58919521 -.->|"ε"|eNFA205_12_60513649
eNFA205_12_60513649 -->|"u"|eNFA205_13_7751933
eNFA205_13_7751933 -.->|"ε"|eNFA205_14_2658533
eNFA205_14_2658533 -->|"e"|eNFA205_15_23926804
eNFA205_15_23926804 -.->|"ε"|eNFA205_17_14014650
eNFA205_17_14014650 -.->|"ε"|eNFA205_18_59022992
eNFA205_18_59022992 -.->|"ε"|eNFA205_19_61444888
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
eNFA205_16_16133081[["εNFA205-16 regex start"]]
eNFA205_0_10980006[["εNFA205-0 char{1, 1}"]]
eNFA205_1_31711190[["εNFA205-1 char[1]"]]
eNFA205_2_16965260[["εNFA205-2 char{1, 1}"]]
eNFA205_3_18469616[["εNFA205-3 char[1]"]]
eNFA205_4_32008819[["εNFA205-4 char{1, 1}"]]
eNFA205_5_19643918[["εNFA205-5 char[1]"]]
eNFA205_6_42577538[["εNFA205-6 char{1, 1}"]]
eNFA205_7_47653529[["εNFA205-7 char[1]"]]
eNFA205_8_26228578[["εNFA205-8 char{1, 1}"]]
eNFA205_9_34730616[["εNFA205-9 char[1]"]]
eNFA205_10_44140091[["εNFA205-10 char{1, 1}"]]
eNFA205_11_61716500[["εNFA205-11 char[1]"]]
eNFA205_12_18577588[["εNFA205-12 char{1, 1}"]]
eNFA205_13_32980564[["εNFA205-13 char[1]"]]
eNFA205_14_28389621[["εNFA205-14 char{1, 1}"]]
eNFA205_15_54180000[\"εNFA205-15 char[1]"/]
eNFA205_17_17857959[\"εNFA205-17 regex end"/]
eNFA205_18_26503905[\"εNFA205-18 post-regex start"/]
eNFA205_19_37208561[\"εNFA205-19 post-regex end"/]
eNFA205_16_16133081 -.->|"ε"|eNFA205_0_10980006
eNFA205_16_16133081 -->|"c"|eNFA205_1_31711190
eNFA205_0_10980006 -->|"c"|eNFA205_1_31711190
eNFA205_1_31711190 -.->|"ε"|eNFA205_2_16965260
eNFA205_1_31711190 -->|"o"|eNFA205_3_18469616
eNFA205_2_16965260 -->|"o"|eNFA205_3_18469616
eNFA205_3_18469616 -.->|"ε"|eNFA205_4_32008819
eNFA205_3_18469616 -->|"n"|eNFA205_5_19643918
eNFA205_4_32008819 -->|"n"|eNFA205_5_19643918
eNFA205_5_19643918 -.->|"ε"|eNFA205_6_42577538
eNFA205_5_19643918 -->|"t"|eNFA205_7_47653529
eNFA205_6_42577538 -->|"t"|eNFA205_7_47653529
eNFA205_7_47653529 -.->|"ε"|eNFA205_8_26228578
eNFA205_7_47653529 -->|"i"|eNFA205_9_34730616
eNFA205_8_26228578 -->|"i"|eNFA205_9_34730616
eNFA205_9_34730616 -.->|"ε"|eNFA205_10_44140091
eNFA205_9_34730616 -->|"n"|eNFA205_11_61716500
eNFA205_10_44140091 -->|"n"|eNFA205_11_61716500
eNFA205_11_61716500 -.->|"ε"|eNFA205_12_18577588
eNFA205_11_61716500 -->|"u"|eNFA205_13_32980564
eNFA205_12_18577588 -->|"u"|eNFA205_13_32980564
eNFA205_13_32980564 -.->|"ε"|eNFA205_14_28389621
eNFA205_13_32980564 -->|"e"|eNFA205_15_54180000
eNFA205_14_28389621 -->|"e"|eNFA205_15_54180000
eNFA205_15_54180000 -.->|"ε"|eNFA205_17_17857959
eNFA205_15_54180000 -.->|"ε"|eNFA205_18_26503905
eNFA205_15_54180000 -.->|"ε"|eNFA205_19_37208561
eNFA205_17_17857959 -.->|"ε"|eNFA205_18_26503905
eNFA205_17_17857959 -.->|"ε"|eNFA205_19_37208561
eNFA205_18_26503905 -.->|"ε"|eNFA205_19_37208561
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
NFA205_16_66441599("NFA205-16 regex start")
NFA205_1_61103484("NFA205-1 char[1]")
NFA205_3_13060449("NFA205-3 char[1]")
NFA205_5_50435184("NFA205-5 char[1]")
NFA205_7_51263472("NFA205-7 char[1]")
NFA205_9_58718067("NFA205-9 char[1]")
NFA205_11_58700563("NFA205-11 char[1]")
NFA205_13_58543024("NFA205-13 char[1]")
NFA205_15_57125171[\"NFA205-15 char[1]"/]
NFA205_16_66441599 -->|"c"|NFA205_1_61103484
NFA205_1_61103484 -->|"o"|NFA205_3_13060449
NFA205_3_13060449 -->|"n"|NFA205_5_50435184
NFA205_5_50435184 -->|"t"|NFA205_7_51263472
NFA205_7_51263472 -->|"i"|NFA205_9_58718067
NFA205_9_58718067 -->|"n"|NFA205_11_58700563
NFA205_11_58700563 -->|"u"|NFA205_13_58543024
NFA205_13_58543024 -->|"e"|NFA205_15_57125171
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
subgraph DFA0_-1654008832["DFA0 regex start"]
NFA205_16_66441599_0("NFA205-16 regex start")
end
subgraph DFA1_1174132410["DFA1 {1}"]
NFA205_1_61103484_1("NFA205-1 char[1]")
end
subgraph DFA2_-2042974709["DFA2 {1}"]
NFA205_3_13060449_2("NFA205-3 char[1]")
end
subgraph DFA3_-768733331["DFA3 {1}"]
NFA205_5_50435184_3("NFA205-5 char[1]")
end
subgraph DFA4_3893310["DFA4 {1}"]
NFA205_7_51263472_4("NFA205-7 char[1]")
end
subgraph DFA5_-1704258733["DFA5 {1}"]
NFA205_9_58718067_5("NFA205-9 char[1]")
end
subgraph DFA6_-163118177["DFA6 {1}"]
NFA205_11_58700563_6("NFA205-11 char[1]")
end
subgraph DFA7_-584966675["DFA7 {1}"]
NFA205_13_58543024_7("NFA205-13 char[1]")
end
subgraph DFA8_1300824915["DFA8 {1}"]
NFA205_15_57125171_8[\"NFA205-15 char[1]"/]
end
DFA0_-1654008832 -->|"c"|DFA1_1174132410
DFA1_1174132410 -->|"o"|DFA2_-2042974709
DFA2_-2042974709 -->|"n"|DFA3_-768733331
DFA3_-768733331 -->|"t"|DFA4_3893310
DFA4_3893310 -->|"i"|DFA5_-1704258733
DFA5_-1704258733 -->|"n"|DFA6_-163118177
DFA6_-163118177 -->|"u"|DFA7_-584966675
DFA7_-584966675 -->|"e"|DFA8_1300824915
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
DFA0_-1654008832{{"DFA0 regex start"}}
DFA1_1174132410{{"DFA1 {1}"}}
DFA2_-2042974709{{"DFA2 {1}"}}
DFA3_-768733331{{"DFA3 {1}"}}
DFA4_3893310{{"DFA4 {1}"}}
DFA5_-1704258733{{"DFA5 {1}"}}
DFA6_-163118177{{"DFA6 {1}"}}
DFA7_-584966675{{"DFA7 {1}"}}
DFA8_1300824915[\"DFA8 {1}"/]
DFA0_-1654008832 -->|"c"|DFA1_1174132410
DFA1_1174132410 -->|"o"|DFA2_-2042974709
DFA2_-2042974709 -->|"n"|DFA3_-768733331
DFA3_-768733331 -->|"t"|DFA4_3893310
DFA4_3893310 -->|"i"|DFA5_-1704258733
DFA5_-1704258733 -->|"n"|DFA6_-163118177
DFA6_-163118177 -->|"u"|DFA7_-584966675
DFA7_-584966675 -->|"e"|DFA8_1300824915
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
subgraph MiniDFA0_-1111016384["MiniDFA0 {1}"]
DFA0_-1654008832_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1327289017["MiniDFA1 {1}"]
DFA1_1174132410_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-2041741037["MiniDFA2 {1}"]
DFA2_-2042974709_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-23573742["MiniDFA4 {1}"]
DFA3_-768733331_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_390541725["MiniDFA5 {1}"]
DFA4_3893310_4{{"DFA4 {1}"}}
end
subgraph MiniDFA3_-438742196["MiniDFA3 {1}"]
DFA5_-1704258733_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_157930684["MiniDFA6 {1}"]
DFA6_-163118177_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1411650570["MiniDFA7 {1}"]
DFA7_-584966675_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1290712096["MiniDFA8 {1}"]
DFA8_1300824915_8[\"DFA8 {1}"/]
end
MiniDFA0_-1111016384 -->|"c"|MiniDFA1_1327289017
MiniDFA1_1327289017 -->|"o"|MiniDFA2_-2041741037
MiniDFA2_-2041741037 -->|"n"|MiniDFA4_-23573742
MiniDFA4_-23573742 -->|"t"|MiniDFA5_390541725
MiniDFA5_390541725 -->|"i"|MiniDFA3_-438742196
MiniDFA3_-438742196 -->|"n"|MiniDFA6_157930684
MiniDFA6_157930684 -->|"u"|MiniDFA7_1411650570
MiniDFA7_1411650570 -->|"e"|MiniDFA8_-1290712096
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
MiniDFA0_-1111016384(["MiniDFA0 {1}"])
MiniDFA1_1327289017(["MiniDFA1 {1}"])
MiniDFA2_-2041741037(["MiniDFA2 {1}"])
MiniDFA4_-23573742(["MiniDFA4 {1}"])
MiniDFA5_390541725(["MiniDFA5 {1}"])
MiniDFA3_-438742196(["MiniDFA3 {1}"])
MiniDFA6_157930684(["MiniDFA6 {1}"])
MiniDFA7_1411650570(["MiniDFA7 {1}"])
MiniDFA8_-1290712096[\"MiniDFA8 {1}"/]
MiniDFA0_-1111016384 -->|"c"|MiniDFA1_1327289017
MiniDFA1_1327289017 -->|"o"|MiniDFA2_-2041741037
MiniDFA2_-2041741037 -->|"n"|MiniDFA4_-23573742
MiniDFA4_-23573742 -->|"t"|MiniDFA5_390541725
MiniDFA5_390541725 -->|"i"|MiniDFA3_-438742196
MiniDFA3_-438742196 -->|"n"|MiniDFA6_157930684
MiniDFA6_157930684 -->|"u"|MiniDFA7_1411650570
MiniDFA7_1411650570 -->|"e"|MiniDFA8_-1290712096
```
-------------------------------
