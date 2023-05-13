# 'precision'

pattern: `precision`

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
eNFA49_18_57793596[["εNFA49-18 regex start"]]
eNFA49_0_50380316[["εNFA49-0 char{1, 1}"]]
eNFA49_1_50769665[["εNFA49-1 char[1]"]]
eNFA49_2_54273802[["εNFA49-2 char{1, 1}"]]
eNFA49_3_18702178[["εNFA49-3 char[1]"]]
eNFA49_4_34101881[["εNFA49-4 char{1, 1}"]]
eNFA49_5_38481481[["εNFA49-5 char[1]"]]
eNFA49_6_10789009[["εNFA49-6 char{1, 1}"]]
eNFA49_7_29992219[["εNFA49-7 char[1]"]]
eNFA49_8_1494521[["εNFA49-8 char{1, 1}"]]
eNFA49_9_13450690[["εNFA49-9 char[1]"]]
eNFA49_10_53947353[["εNFA49-10 char{1, 1}"]]
eNFA49_11_15764134[["εNFA49-11 char[1]"]]
eNFA49_12_7659482[["εNFA49-12 char{1, 1}"]]
eNFA49_13_1826478[["εNFA49-13 char[1]"]]
eNFA49_14_16438307[["εNFA49-14 char{1, 1}"]]
eNFA49_15_13727043[["εNFA49-15 char[1]"]]
eNFA49_16_56434525[["εNFA49-16 char{1, 1}"]]
eNFA49_17_38148684[["εNFA49-17 char[1]"]]
eNFA49_19_7793840[["εNFA49-19 regex end"]]
eNFA49_20_3035698[["εNFA49-20 post-regex start"]]
eNFA49_21_27321283[\"εNFA49-21 post-regex end"/]
eNFA49_18_57793596 -.->|"ε"|eNFA49_0_50380316
eNFA49_0_50380316 -->|"p"|eNFA49_1_50769665
eNFA49_1_50769665 -.->|"ε"|eNFA49_2_54273802
eNFA49_2_54273802 -->|"r"|eNFA49_3_18702178
eNFA49_3_18702178 -.->|"ε"|eNFA49_4_34101881
eNFA49_4_34101881 -->|"e"|eNFA49_5_38481481
eNFA49_5_38481481 -.->|"ε"|eNFA49_6_10789009
eNFA49_6_10789009 -->|"c"|eNFA49_7_29992219
eNFA49_7_29992219 -.->|"ε"|eNFA49_8_1494521
eNFA49_8_1494521 -->|"i"|eNFA49_9_13450690
eNFA49_9_13450690 -.->|"ε"|eNFA49_10_53947353
eNFA49_10_53947353 -->|"s"|eNFA49_11_15764134
eNFA49_11_15764134 -.->|"ε"|eNFA49_12_7659482
eNFA49_12_7659482 -->|"i"|eNFA49_13_1826478
eNFA49_13_1826478 -.->|"ε"|eNFA49_14_16438307
eNFA49_14_16438307 -->|"o"|eNFA49_15_13727043
eNFA49_15_13727043 -.->|"ε"|eNFA49_16_56434525
eNFA49_16_56434525 -->|"n"|eNFA49_17_38148684
eNFA49_17_38148684 -.->|"ε"|eNFA49_19_7793840
eNFA49_19_7793840 -.->|"ε"|eNFA49_20_3035698
eNFA49_20_3035698 -.->|"ε"|eNFA49_21_27321283
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
eNFA49_18_44564956[["εNFA49-18 regex start"]]
eNFA49_0_65540286[["εNFA49-0 char{1, 1}"]]
eNFA49_1_52991666[["εNFA49-1 char[1]"]]
eNFA49_2_7162954[["εNFA49-2 char{1, 1}"]]
eNFA49_3_64466590[["εNFA49-3 char[1]"]]
eNFA49_4_43328398[["εNFA49-4 char{1, 1}"]]
eNFA49_5_54411269[["εNFA49-5 char[1]"]]
eNFA49_6_19939379[["εNFA49-6 char{1, 1}"]]
eNFA49_7_45236689[["εNFA49-7 char[1]"]]
eNFA49_8_4477025[["εNFA49-8 char{1, 1}"]]
eNFA49_9_40293226[["εNFA49-9 char[1]"]]
eNFA49_10_27094719[["εNFA49-10 char{1, 1}"]]
eNFA49_11_42525879[["εNFA49-11 char[1]"]]
eNFA49_12_47188597[["εNFA49-12 char{1, 1}"]]
eNFA49_13_22044193[["εNFA49-13 char[1]"]]
eNFA49_14_64180012[["εNFA49-14 char{1, 1}"]]
eNFA49_15_40749199[["εNFA49-15 char[1]"]]
eNFA49_16_31198475[["εNFA49-16 char{1, 1}"]]
eNFA49_17_12350826[\"εNFA49-17 char[1]"/]
eNFA49_19_44048571[\"εNFA49-19 regex end"/]
eNFA49_20_60892825[\"εNFA49-20 post-regex start"/]
eNFA49_21_11164516[\"εNFA49-21 post-regex end"/]
eNFA49_18_44564956 -.->|"ε"|eNFA49_0_65540286
eNFA49_18_44564956 -->|"p"|eNFA49_1_52991666
eNFA49_0_65540286 -->|"p"|eNFA49_1_52991666
eNFA49_1_52991666 -.->|"ε"|eNFA49_2_7162954
eNFA49_1_52991666 -->|"r"|eNFA49_3_64466590
eNFA49_2_7162954 -->|"r"|eNFA49_3_64466590
eNFA49_3_64466590 -.->|"ε"|eNFA49_4_43328398
eNFA49_3_64466590 -->|"e"|eNFA49_5_54411269
eNFA49_4_43328398 -->|"e"|eNFA49_5_54411269
eNFA49_5_54411269 -.->|"ε"|eNFA49_6_19939379
eNFA49_5_54411269 -->|"c"|eNFA49_7_45236689
eNFA49_6_19939379 -->|"c"|eNFA49_7_45236689
eNFA49_7_45236689 -.->|"ε"|eNFA49_8_4477025
eNFA49_7_45236689 -->|"i"|eNFA49_9_40293226
eNFA49_8_4477025 -->|"i"|eNFA49_9_40293226
eNFA49_9_40293226 -.->|"ε"|eNFA49_10_27094719
eNFA49_9_40293226 -->|"s"|eNFA49_11_42525879
eNFA49_10_27094719 -->|"s"|eNFA49_11_42525879
eNFA49_11_42525879 -.->|"ε"|eNFA49_12_47188597
eNFA49_11_42525879 -->|"i"|eNFA49_13_22044193
eNFA49_12_47188597 -->|"i"|eNFA49_13_22044193
eNFA49_13_22044193 -.->|"ε"|eNFA49_14_64180012
eNFA49_13_22044193 -->|"o"|eNFA49_15_40749199
eNFA49_14_64180012 -->|"o"|eNFA49_15_40749199
eNFA49_15_40749199 -.->|"ε"|eNFA49_16_31198475
eNFA49_15_40749199 -->|"n"|eNFA49_17_12350826
eNFA49_16_31198475 -->|"n"|eNFA49_17_12350826
eNFA49_17_12350826 -.->|"ε"|eNFA49_19_44048571
eNFA49_17_12350826 -.->|"ε"|eNFA49_20_60892825
eNFA49_17_12350826 -.->|"ε"|eNFA49_21_11164516
eNFA49_19_44048571 -.->|"ε"|eNFA49_20_60892825
eNFA49_19_44048571 -.->|"ε"|eNFA49_21_11164516
eNFA49_20_60892825 -.->|"ε"|eNFA49_21_11164516
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
NFA49_18_33371781("NFA49-18 regex start")
NFA49_1_31910573("NFA49-1 char[1]")
NFA49_3_18759701("NFA49-3 char[1]")
NFA49_5_34619582("NFA49-5 char[1]")
NFA49_7_43140785("NFA49-7 char[1]")
NFA49_9_52722752("NFA49-9 char[1]")
NFA49_11_4742722("NFA49-11 char[1]")
NFA49_13_42684506("NFA49-13 char[1]")
NFA49_15_48616240("NFA49-15 char[1]")
NFA49_17_34892981[\"NFA49-17 char[1]"/]
NFA49_18_33371781 -->|"p"|NFA49_1_31910573
NFA49_1_31910573 -->|"r"|NFA49_3_18759701
NFA49_3_18759701 -->|"e"|NFA49_5_34619582
NFA49_5_34619582 -->|"c"|NFA49_7_43140785
NFA49_7_43140785 -->|"i"|NFA49_9_52722752
NFA49_9_52722752 -->|"s"|NFA49_11_4742722
NFA49_11_4742722 -->|"i"|NFA49_13_42684506
NFA49_13_42684506 -->|"o"|NFA49_15_48616240
NFA49_15_48616240 -->|"n"|NFA49_17_34892981
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
subgraph DFA0_-282568311["DFA0 regex start"]
NFA49_18_33371781_0("NFA49-18 regex start")
end
subgraph DFA1_-2096389381["DFA1 {1}"]
NFA49_1_31910573_1("NFA49-1 char[1]")
end
subgraph DFA2_389335825["DFA2 {1}"]
NFA49_3_18759701_2("NFA49-3 char[1]")
end
subgraph DFA3_-985598220["DFA3 {1}"]
NFA49_5_34619582_3("NFA49-5 char[1]")
end
subgraph DFA4_592584954["DFA4 {1}"]
NFA49_7_43140785_4("NFA49-7 char[1]")
end
subgraph DFA5_274951536["DFA5 {1}"]
NFA49_9_52722752_5("NFA49-9 char[1]")
end
subgraph DFA6_-765950529["DFA6 {1}"]
NFA49_11_4742722_6("NFA49-11 char[1]")
end
subgraph DFA7_-1353493520["DFA7 {1}"]
NFA49_13_42684506_7("NFA49-13 char[1]")
end
subgraph DFA8_1465165798["DFA8 {1}"]
NFA49_15_48616240_8("NFA49-15 char[1]")
end
subgraph DFA9_-349543970["DFA9 {1}"]
NFA49_17_34892981_9[\"NFA49-17 char[1]"/]
end
DFA0_-282568311 -->|"p"|DFA1_-2096389381
DFA1_-2096389381 -->|"r"|DFA2_389335825
DFA2_389335825 -->|"e"|DFA3_-985598220
DFA3_-985598220 -->|"c"|DFA4_592584954
DFA4_592584954 -->|"i"|DFA5_274951536
DFA5_274951536 -->|"s"|DFA6_-765950529
DFA6_-765950529 -->|"i"|DFA7_-1353493520
DFA7_-1353493520 -->|"o"|DFA8_1465165798
DFA8_1465165798 -->|"n"|DFA9_-349543970
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
DFA0_-282568311{{"DFA0 regex start"}}
DFA1_-2096389381{{"DFA1 {1}"}}
DFA2_389335825{{"DFA2 {1}"}}
DFA3_-985598220{{"DFA3 {1}"}}
DFA4_592584954{{"DFA4 {1}"}}
DFA5_274951536{{"DFA5 {1}"}}
DFA6_-765950529{{"DFA6 {1}"}}
DFA7_-1353493520{{"DFA7 {1}"}}
DFA8_1465165798{{"DFA8 {1}"}}
DFA9_-349543970[\"DFA9 {1}"/]
DFA0_-282568311 -->|"p"|DFA1_-2096389381
DFA1_-2096389381 -->|"r"|DFA2_389335825
DFA2_389335825 -->|"e"|DFA3_-985598220
DFA3_-985598220 -->|"c"|DFA4_592584954
DFA4_592584954 -->|"i"|DFA5_274951536
DFA5_274951536 -->|"s"|DFA6_-765950529
DFA6_-765950529 -->|"i"|DFA7_-1353493520
DFA7_-1353493520 -->|"o"|DFA8_1465165798
DFA8_1465165798 -->|"n"|DFA9_-349543970
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
subgraph MiniDFA0_-1894573535["MiniDFA0 {1}"]
DFA0_-282568311_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1978028062["MiniDFA1 {1}"]
DFA1_-2096389381_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-167882425["MiniDFA2 {1}"]
DFA2_389335825_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1566890824["MiniDFA3 {1}"]
DFA3_-985598220_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1065714013["MiniDFA4 {1}"]
DFA4_592584954_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1961963026["MiniDFA6 {1}"]
DFA5_274951536_5{{"DFA5 {1}"}}
end
subgraph MiniDFA5_-1897121384["MiniDFA5 {1}"]
DFA6_-765950529_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_842753559["MiniDFA7 {1}"]
DFA7_-1353493520_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1304511037["MiniDFA8 {1}"]
DFA8_1465165798_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_603106686["MiniDFA9 {1}"]
DFA9_-349543970_9[\"DFA9 {1}"/]
end
MiniDFA0_-1894573535 -->|"p"|MiniDFA1_-1978028062
MiniDFA1_-1978028062 -->|"r"|MiniDFA2_-167882425
MiniDFA2_-167882425 -->|"e"|MiniDFA3_1566890824
MiniDFA3_1566890824 -->|"c"|MiniDFA4_1065714013
MiniDFA4_1065714013 -->|"i"|MiniDFA6_-1961963026
MiniDFA6_-1961963026 -->|"s"|MiniDFA5_-1897121384
MiniDFA5_-1897121384 -->|"i"|MiniDFA7_842753559
MiniDFA7_842753559 -->|"o"|MiniDFA8_1304511037
MiniDFA8_1304511037 -->|"n"|MiniDFA9_603106686
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
MiniDFA0_-1894573535(["MiniDFA0 {1}"])
MiniDFA1_-1978028062(["MiniDFA1 {1}"])
MiniDFA2_-167882425(["MiniDFA2 {1}"])
MiniDFA3_1566890824(["MiniDFA3 {1}"])
MiniDFA4_1065714013(["MiniDFA4 {1}"])
MiniDFA6_-1961963026(["MiniDFA6 {1}"])
MiniDFA5_-1897121384(["MiniDFA5 {1}"])
MiniDFA7_842753559(["MiniDFA7 {1}"])
MiniDFA8_1304511037(["MiniDFA8 {1}"])
MiniDFA9_603106686[\"MiniDFA9 {1}"/]
MiniDFA0_-1894573535 -->|"p"|MiniDFA1_-1978028062
MiniDFA1_-1978028062 -->|"r"|MiniDFA2_-167882425
MiniDFA2_-167882425 -->|"e"|MiniDFA3_1566890824
MiniDFA3_1566890824 -->|"c"|MiniDFA4_1065714013
MiniDFA4_1065714013 -->|"i"|MiniDFA6_-1961963026
MiniDFA6_-1961963026 -->|"s"|MiniDFA5_-1897121384
MiniDFA5_-1897121384 -->|"i"|MiniDFA7_842753559
MiniDFA7_842753559 -->|"o"|MiniDFA8_1304511037
MiniDFA8_1304511037 -->|"n"|MiniDFA9_603106686
```
-------------------------------
