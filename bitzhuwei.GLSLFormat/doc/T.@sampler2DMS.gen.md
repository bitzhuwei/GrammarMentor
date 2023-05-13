# 'sampler2DMS'

pattern: `sampler2DMS`

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
eNFA154_22_53031964[["εNFA154-22 regex start"]]
eNFA154_0_7525633[["εNFA154-0 char{1, 1}"]]
eNFA154_1_621837[["εNFA154-1 char[1]"]]
eNFA154_2_5596537[["εNFA154-2 char{1, 1}"]]
eNFA154_3_50368838[["εNFA154-3 char[1]"]]
eNFA154_4_50666366[["εNFA154-4 char{1, 1}"]]
eNFA154_5_53344112[["εNFA154-5 char[1]"]]
eNFA154_6_10334967[["εNFA154-6 char{1, 1}"]]
eNFA154_7_25905843[["εNFA154-7 char[1]"]]
eNFA154_8_31825997[["εNFA154-8 char{1, 1}"]]
eNFA154_9_17998518[["εNFA154-9 char[1]"]]
eNFA154_10_27768935[["εNFA154-10 char{1, 1}"]]
eNFA154_11_48593825[["εNFA154-11 char[1]"]]
eNFA154_12_34691245[["εNFA154-12 char{1, 1}"]]
eNFA154_13_43785757[["εNFA154-13 char[1]"]]
eNFA154_14_58527497[["εNFA154-14 char{1, 1}"]]
eNFA154_15_56985425[["εNFA154-15 char[1]"]]
eNFA154_16_43106784[["εNFA154-16 char{1, 1}"]]
eNFA154_17_52416742[["εNFA154-17 char[1]"]]
eNFA154_18_1988636[["εNFA154-18 char{1, 1}"]]
eNFA154_19_17897732[["εNFA154-19 char[1]"]]
eNFA154_20_26861861[["εNFA154-20 char{1, 1}"]]
eNFA154_21_40430162[["εNFA154-21 char[1]"]]
eNFA154_23_28327138[["εNFA154-23 regex end"]]
eNFA154_24_53617656[["εNFA154-24 post-regex start"]]
eNFA154_25_12796860[\"εNFA154-25 post-regex end"/]
eNFA154_22_53031964 -.->|"ε"|eNFA154_0_7525633
eNFA154_0_7525633 -->|"s"|eNFA154_1_621837
eNFA154_1_621837 -.->|"ε"|eNFA154_2_5596537
eNFA154_2_5596537 -->|"a"|eNFA154_3_50368838
eNFA154_3_50368838 -.->|"ε"|eNFA154_4_50666366
eNFA154_4_50666366 -->|"m"|eNFA154_5_53344112
eNFA154_5_53344112 -.->|"ε"|eNFA154_6_10334967
eNFA154_6_10334967 -->|"p"|eNFA154_7_25905843
eNFA154_7_25905843 -.->|"ε"|eNFA154_8_31825997
eNFA154_8_31825997 -->|"l"|eNFA154_9_17998518
eNFA154_9_17998518 -.->|"ε"|eNFA154_10_27768935
eNFA154_10_27768935 -->|"e"|eNFA154_11_48593825
eNFA154_11_48593825 -.->|"ε"|eNFA154_12_34691245
eNFA154_12_34691245 -->|"r"|eNFA154_13_43785757
eNFA154_13_43785757 -.->|"ε"|eNFA154_14_58527497
eNFA154_14_58527497 -->|"2"|eNFA154_15_56985425
eNFA154_15_56985425 -.->|"ε"|eNFA154_16_43106784
eNFA154_16_43106784 -->|"D"|eNFA154_17_52416742
eNFA154_17_52416742 -.->|"ε"|eNFA154_18_1988636
eNFA154_18_1988636 -->|"M"|eNFA154_19_17897732
eNFA154_19_17897732 -.->|"ε"|eNFA154_20_26861861
eNFA154_20_26861861 -->|"S"|eNFA154_21_40430162
eNFA154_21_40430162 -.->|"ε"|eNFA154_23_28327138
eNFA154_23_28327138 -.->|"ε"|eNFA154_24_53617656
eNFA154_24_53617656 -.->|"ε"|eNFA154_25_12796860
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
eNFA154_22_48062879[["εNFA154-22 regex start"]]
eNFA154_0_29912730[["εNFA154-0 char{1, 1}"]]
eNFA154_1_779118[["εNFA154-1 char[1]"]]
eNFA154_2_7012069[["εNFA154-2 char{1, 1}"]]
eNFA154_3_63108622[["εNFA154-3 char[1]"]]
eNFA154_4_31106692[["εNFA154-4 char{1, 1}"]]
eNFA154_5_11524775[["εNFA154-5 char[1]"]]
eNFA154_6_36614112[["εNFA154-6 char{1, 1}"]]
eNFA154_7_61091552[["εNFA154-7 char[1]"]]
eNFA154_8_12953056[["εNFA154-8 char{1, 1}"]]
eNFA154_9_49468641[["εNFA154-9 char[1]"]]
eNFA154_10_42564588[["εNFA154-10 char{1, 1}"]]
eNFA154_11_47536979[["εNFA154-11 char[1]"]]
eNFA154_12_25179629[["εNFA154-12 char{1, 1}"]]
eNFA154_13_25290077[["εNFA154-13 char[1]"]]
eNFA154_14_26284107[["εNFA154-14 char{1, 1}"]]
eNFA154_15_35230376[["εNFA154-15 char[1]"]]
eNFA154_16_48637933[["εNFA154-16 char{1, 1}"]]
eNFA154_17_35088220[["εNFA154-17 char[1]"]]
eNFA154_18_47358524[["εNFA154-18 char{1, 1}"]]
eNFA154_19_23573535[["εNFA154-19 char[1]"]]
eNFA154_20_10835231[["εNFA154-20 char{1, 1}"]]
eNFA154_21_30408220[\"εNFA154-21 char[1]"/]
eNFA154_23_5238527[\"εNFA154-23 regex end"/]
eNFA154_24_47146745[\"εNFA154-24 post-regex start"/]
eNFA154_25_21667523[\"εNFA154-25 post-regex end"/]
eNFA154_22_48062879 -.->|"ε"|eNFA154_0_29912730
eNFA154_22_48062879 -->|"s"|eNFA154_1_779118
eNFA154_0_29912730 -->|"s"|eNFA154_1_779118
eNFA154_1_779118 -.->|"ε"|eNFA154_2_7012069
eNFA154_1_779118 -->|"a"|eNFA154_3_63108622
eNFA154_2_7012069 -->|"a"|eNFA154_3_63108622
eNFA154_3_63108622 -.->|"ε"|eNFA154_4_31106692
eNFA154_3_63108622 -->|"m"|eNFA154_5_11524775
eNFA154_4_31106692 -->|"m"|eNFA154_5_11524775
eNFA154_5_11524775 -.->|"ε"|eNFA154_6_36614112
eNFA154_5_11524775 -->|"p"|eNFA154_7_61091552
eNFA154_6_36614112 -->|"p"|eNFA154_7_61091552
eNFA154_7_61091552 -.->|"ε"|eNFA154_8_12953056
eNFA154_7_61091552 -->|"l"|eNFA154_9_49468641
eNFA154_8_12953056 -->|"l"|eNFA154_9_49468641
eNFA154_9_49468641 -.->|"ε"|eNFA154_10_42564588
eNFA154_9_49468641 -->|"e"|eNFA154_11_47536979
eNFA154_10_42564588 -->|"e"|eNFA154_11_47536979
eNFA154_11_47536979 -.->|"ε"|eNFA154_12_25179629
eNFA154_11_47536979 -->|"r"|eNFA154_13_25290077
eNFA154_12_25179629 -->|"r"|eNFA154_13_25290077
eNFA154_13_25290077 -.->|"ε"|eNFA154_14_26284107
eNFA154_13_25290077 -->|"2"|eNFA154_15_35230376
eNFA154_14_26284107 -->|"2"|eNFA154_15_35230376
eNFA154_15_35230376 -.->|"ε"|eNFA154_16_48637933
eNFA154_15_35230376 -->|"D"|eNFA154_17_35088220
eNFA154_16_48637933 -->|"D"|eNFA154_17_35088220
eNFA154_17_35088220 -.->|"ε"|eNFA154_18_47358524
eNFA154_17_35088220 -->|"M"|eNFA154_19_23573535
eNFA154_18_47358524 -->|"M"|eNFA154_19_23573535
eNFA154_19_23573535 -.->|"ε"|eNFA154_20_10835231
eNFA154_19_23573535 -->|"S"|eNFA154_21_30408220
eNFA154_20_10835231 -->|"S"|eNFA154_21_30408220
eNFA154_21_30408220 -.->|"ε"|eNFA154_23_5238527
eNFA154_21_30408220 -.->|"ε"|eNFA154_24_47146745
eNFA154_21_30408220 -.->|"ε"|eNFA154_25_21667523
eNFA154_23_5238527 -.->|"ε"|eNFA154_24_47146745
eNFA154_23_5238527 -.->|"ε"|eNFA154_25_21667523
eNFA154_24_47146745 -.->|"ε"|eNFA154_25_21667523
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
NFA154_22_60789982("NFA154-22 regex start")
NFA154_1_10238932("NFA154-1 char[1]")
NFA154_3_25041524("NFA154-3 char[1]")
NFA154_5_24047129("NFA154-5 char[1]")
NFA154_7_15097570("NFA154-7 char[1]")
NFA154_9_1660410("NFA154-9 char[1]")
NFA154_11_14943697("NFA154-11 char[1]")
NFA154_13_275553("NFA154-13 char[1]")
NFA154_15_2479977("NFA154-15 char[1]")
NFA154_17_22319795("NFA154-17 char[1]")
NFA154_19_66660433("NFA154-19 char[1]")
NFA154_21_63072986[\"NFA154-21 char[1]"/]
NFA154_22_60789982 -->|"s"|NFA154_1_10238932
NFA154_1_10238932 -->|"a"|NFA154_3_25041524
NFA154_3_25041524 -->|"m"|NFA154_5_24047129
NFA154_5_24047129 -->|"p"|NFA154_7_15097570
NFA154_7_15097570 -->|"l"|NFA154_9_1660410
NFA154_9_1660410 -->|"e"|NFA154_11_14943697
NFA154_11_14943697 -->|"r"|NFA154_13_275553
NFA154_13_275553 -->|"2"|NFA154_15_2479977
NFA154_15_2479977 -->|"D"|NFA154_17_22319795
NFA154_17_22319795 -->|"M"|NFA154_19_66660433
NFA154_19_66660433 -->|"S"|NFA154_21_63072986
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
subgraph DFA0_-727967319["DFA0 regex start"]
NFA154_22_60789982_0("NFA154-22 regex start")
end
subgraph DFA1_650358190["DFA1 {1}"]
NFA154_1_10238932_1("NFA154-1 char[1]")
end
subgraph DFA2_1773915096["DFA2 {1}"]
NFA154_3_25041524_2("NFA154-3 char[1]")
end
subgraph DFA3_1889244906["DFA3 {1}"]
NFA154_5_24047129_3("NFA154-5 char[1]")
end
subgraph DFA4_810980186["DFA4 {1}"]
NFA154_7_15097570_4("NFA154-7 char[1]")
end
subgraph DFA5_-1672902192["DFA5 {1}"]
NFA154_9_1660410_5("NFA154-9 char[1]")
end
subgraph DFA6_667608790["DFA6 {1}"]
NFA154_11_14943697_6("NFA154-11 char[1]")
end
subgraph DFA7_1920006435["DFA7 {1}"]
NFA154_13_275553_7("NFA154-13 char[1]")
end
subgraph DFA8_961634615["DFA8 {1}"]
NFA154_15_2479977_8("NFA154-15 char[1]")
end
subgraph DFA9_-857814225["DFA9 {1}"]
NFA154_17_22319795_9("NFA154-17 char[1]")
end
subgraph DFA10_-934289591["DFA10 {1}"]
NFA154_19_66660433_10("NFA154-19 char[1]")
end
subgraph DFA11_1468933790["DFA11 {1}"]
NFA154_21_63072986_11[\"NFA154-21 char[1]"/]
end
DFA0_-727967319 -->|"s"|DFA1_650358190
DFA1_650358190 -->|"a"|DFA2_1773915096
DFA2_1773915096 -->|"m"|DFA3_1889244906
DFA3_1889244906 -->|"p"|DFA4_810980186
DFA4_810980186 -->|"l"|DFA5_-1672902192
DFA5_-1672902192 -->|"e"|DFA6_667608790
DFA6_667608790 -->|"r"|DFA7_1920006435
DFA7_1920006435 -->|"2"|DFA8_961634615
DFA8_961634615 -->|"D"|DFA9_-857814225
DFA9_-857814225 -->|"M"|DFA10_-934289591
DFA10_-934289591 -->|"S"|DFA11_1468933790
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
DFA0_-727967319{{"DFA0 regex start"}}
DFA1_650358190{{"DFA1 {1}"}}
DFA2_1773915096{{"DFA2 {1}"}}
DFA3_1889244906{{"DFA3 {1}"}}
DFA4_810980186{{"DFA4 {1}"}}
DFA5_-1672902192{{"DFA5 {1}"}}
DFA6_667608790{{"DFA6 {1}"}}
DFA7_1920006435{{"DFA7 {1}"}}
DFA8_961634615{{"DFA8 {1}"}}
DFA9_-857814225{{"DFA9 {1}"}}
DFA10_-934289591{{"DFA10 {1}"}}
DFA11_1468933790[\"DFA11 {1}"/]
DFA0_-727967319 -->|"s"|DFA1_650358190
DFA1_650358190 -->|"a"|DFA2_1773915096
DFA2_1773915096 -->|"m"|DFA3_1889244906
DFA3_1889244906 -->|"p"|DFA4_810980186
DFA4_810980186 -->|"l"|DFA5_-1672902192
DFA5_-1672902192 -->|"e"|DFA6_667608790
DFA6_667608790 -->|"r"|DFA7_1920006435
DFA7_1920006435 -->|"2"|DFA8_961634615
DFA8_961634615 -->|"D"|DFA9_-857814225
DFA9_-857814225 -->|"M"|DFA10_-934289591
DFA10_-934289591 -->|"S"|DFA11_1468933790
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
subgraph MiniDFA0_-1614447145["MiniDFA0 {1}"]
DFA0_-727967319_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2099175239["MiniDFA1 {1}"]
DFA1_650358190_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-711692218["MiniDFA2 {1}"]
DFA2_1773915096_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_20985909["MiniDFA3 {1}"]
DFA3_1889244906_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-123040624["MiniDFA4 {1}"]
DFA4_810980186_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1787541470["MiniDFA5 {1}"]
DFA5_-1672902192_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_763522391["MiniDFA6 {1}"]
DFA6_667608790_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-443604526["MiniDFA7 {1}"]
DFA7_1920006435_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1596137169["MiniDFA8 {1}"]
DFA8_961634615_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-1681855355["MiniDFA9 {1}"]
DFA9_-857814225_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_1140720487["MiniDFA10 {1}"]
DFA10_-934289591_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-296075549["MiniDFA11 {1}"]
DFA11_1468933790_11[\"DFA11 {1}"/]
end
MiniDFA0_-1614447145 -->|"s"|MiniDFA1_2099175239
MiniDFA1_2099175239 -->|"a"|MiniDFA2_-711692218
MiniDFA2_-711692218 -->|"m"|MiniDFA3_20985909
MiniDFA3_20985909 -->|"p"|MiniDFA4_-123040624
MiniDFA4_-123040624 -->|"l"|MiniDFA5_1787541470
MiniDFA5_1787541470 -->|"e"|MiniDFA6_763522391
MiniDFA6_763522391 -->|"r"|MiniDFA7_-443604526
MiniDFA7_-443604526 -->|"2"|MiniDFA8_-1596137169
MiniDFA8_-1596137169 -->|"D"|MiniDFA9_-1681855355
MiniDFA9_-1681855355 -->|"M"|MiniDFA10_1140720487
MiniDFA10_1140720487 -->|"S"|MiniDFA11_-296075549
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
MiniDFA0_-1614447145(["MiniDFA0 {1}"])
MiniDFA1_2099175239(["MiniDFA1 {1}"])
MiniDFA2_-711692218(["MiniDFA2 {1}"])
MiniDFA3_20985909(["MiniDFA3 {1}"])
MiniDFA4_-123040624(["MiniDFA4 {1}"])
MiniDFA5_1787541470(["MiniDFA5 {1}"])
MiniDFA6_763522391(["MiniDFA6 {1}"])
MiniDFA7_-443604526(["MiniDFA7 {1}"])
MiniDFA8_-1596137169(["MiniDFA8 {1}"])
MiniDFA9_-1681855355(["MiniDFA9 {1}"])
MiniDFA10_1140720487(["MiniDFA10 {1}"])
MiniDFA11_-296075549[\"MiniDFA11 {1}"/]
MiniDFA0_-1614447145 -->|"s"|MiniDFA1_2099175239
MiniDFA1_2099175239 -->|"a"|MiniDFA2_-711692218
MiniDFA2_-711692218 -->|"m"|MiniDFA3_20985909
MiniDFA3_20985909 -->|"p"|MiniDFA4_-123040624
MiniDFA4_-123040624 -->|"l"|MiniDFA5_1787541470
MiniDFA5_1787541470 -->|"e"|MiniDFA6_763522391
MiniDFA6_763522391 -->|"r"|MiniDFA7_-443604526
MiniDFA7_-443604526 -->|"2"|MiniDFA8_-1596137169
MiniDFA8_-1596137169 -->|"D"|MiniDFA9_-1681855355
MiniDFA9_-1681855355 -->|"M"|MiniDFA10_1140720487
MiniDFA10_1140720487 -->|"S"|MiniDFA11_-296075549
```
-------------------------------
