# 'sampler2D'

pattern: `sampler2D`

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
eNFA121_18_47045852[["εNFA121-18 regex start"]]
eNFA121_0_20759490[["εNFA121-0 char{1, 1}"]]
eNFA121_1_52617682[["εNFA121-1 char[1]"]]
eNFA121_2_3797095[["εNFA121-2 char{1, 1}"]]
eNFA121_3_34173856[["εNFA121-3 char[1]"]]
eNFA121_4_39129256[["εNFA121-4 char{1, 1}"]]
eNFA121_5_16618991[["εNFA121-5 char[1]"]]
eNFA121_6_15353199[["εNFA121-6 char{1, 1}"]]
eNFA121_7_3961063[["εNFA121-7 char[1]"]]
eNFA121_8_35649569[["εNFA121-8 char{1, 1}"]]
eNFA121_9_52410671[["εNFA121-9 char[1]"]]
eNFA121_10_1933992[["εNFA121-10 char{1, 1}"]]
eNFA121_11_17405935[["εNFA121-11 char[1]"]]
eNFA121_12_22435692[["εNFA121-12 char{1, 1}"]]
eNFA121_13_594640[["εNFA121-13 char[1]"]]
eNFA121_14_5351764[["εNFA121-14 char{1, 1}"]]
eNFA121_15_48165881[["εNFA121-15 char[1]"]]
eNFA121_16_30839753[["εNFA121-16 char{1, 1}"]]
eNFA121_17_9122323[["εNFA121-17 char[1]"]]
eNFA121_19_14992050[["εNFA121-19 regex end"]]
eNFA121_20_710726[["εNFA121-20 post-regex start"]]
eNFA121_21_6396536[\"εNFA121-21 post-regex end"/]
eNFA121_18_47045852 -.->|"ε"|eNFA121_0_20759490
eNFA121_0_20759490 -->|"s"|eNFA121_1_52617682
eNFA121_1_52617682 -.->|"ε"|eNFA121_2_3797095
eNFA121_2_3797095 -->|"a"|eNFA121_3_34173856
eNFA121_3_34173856 -.->|"ε"|eNFA121_4_39129256
eNFA121_4_39129256 -->|"m"|eNFA121_5_16618991
eNFA121_5_16618991 -.->|"ε"|eNFA121_6_15353199
eNFA121_6_15353199 -->|"p"|eNFA121_7_3961063
eNFA121_7_3961063 -.->|"ε"|eNFA121_8_35649569
eNFA121_8_35649569 -->|"l"|eNFA121_9_52410671
eNFA121_9_52410671 -.->|"ε"|eNFA121_10_1933992
eNFA121_10_1933992 -->|"e"|eNFA121_11_17405935
eNFA121_11_17405935 -.->|"ε"|eNFA121_12_22435692
eNFA121_12_22435692 -->|"r"|eNFA121_13_594640
eNFA121_13_594640 -.->|"ε"|eNFA121_14_5351764
eNFA121_14_5351764 -->|"2"|eNFA121_15_48165881
eNFA121_15_48165881 -.->|"ε"|eNFA121_16_30839753
eNFA121_16_30839753 -->|"D"|eNFA121_17_9122323
eNFA121_17_9122323 -.->|"ε"|eNFA121_19_14992050
eNFA121_19_14992050 -.->|"ε"|eNFA121_20_710726
eNFA121_20_710726 -.->|"ε"|eNFA121_21_6396536
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
eNFA121_18_57568825[["εNFA121-18 regex start"]]
eNFA121_0_48357378[["εNFA121-0 char{1, 1}"]]
eNFA121_1_32563220[["εNFA121-1 char[1]"]]
eNFA121_2_24633528[["εNFA121-2 char{1, 1}"]]
eNFA121_3_20375168[["εNFA121-3 char[1]"]]
eNFA121_4_49158788[["εNFA121-4 char{1, 1}"]]
eNFA121_5_39775908[["εNFA121-5 char[1]"]]
eNFA121_6_22438859[["εNFA121-6 char{1, 1}"]]
eNFA121_7_623145[["εNFA121-7 char[1]"]]
eNFA121_8_5608311[["εNFA121-8 char{1, 1}"]]
eNFA121_9_50474807[["εNFA121-9 char[1]"]]
eNFA121_10_51620080[["εNFA121-10 char{1, 1}"]]
eNFA121_11_61927541[["εNFA121-11 char[1]"]]
eNFA121_12_20476957[["εNFA121-12 char{1, 1}"]]
eNFA121_13_50074891[["εNFA121-13 char[1]"]]
eNFA121_14_48020839[["εNFA121-14 char{1, 1}"]]
eNFA121_15_29534370[["εNFA121-15 char[1]"]]
eNFA121_16_64482741[["εNFA121-16 char{1, 1}"]]
eNFA121_17_43473761[\"εNFA121-17 char[1]"/]
eNFA121_19_55719536[\"εNFA121-19 regex end"/]
eNFA121_20_31713777[\"εNFA121-20 post-regex start"/]
eNFA121_21_16988543[\"εNFA121-21 post-regex end"/]
eNFA121_18_57568825 -.->|"ε"|eNFA121_0_48357378
eNFA121_18_57568825 -->|"s"|eNFA121_1_32563220
eNFA121_0_48357378 -->|"s"|eNFA121_1_32563220
eNFA121_1_32563220 -.->|"ε"|eNFA121_2_24633528
eNFA121_1_32563220 -->|"a"|eNFA121_3_20375168
eNFA121_2_24633528 -->|"a"|eNFA121_3_20375168
eNFA121_3_20375168 -.->|"ε"|eNFA121_4_49158788
eNFA121_3_20375168 -->|"m"|eNFA121_5_39775908
eNFA121_4_49158788 -->|"m"|eNFA121_5_39775908
eNFA121_5_39775908 -.->|"ε"|eNFA121_6_22438859
eNFA121_5_39775908 -->|"p"|eNFA121_7_623145
eNFA121_6_22438859 -->|"p"|eNFA121_7_623145
eNFA121_7_623145 -.->|"ε"|eNFA121_8_5608311
eNFA121_7_623145 -->|"l"|eNFA121_9_50474807
eNFA121_8_5608311 -->|"l"|eNFA121_9_50474807
eNFA121_9_50474807 -.->|"ε"|eNFA121_10_51620080
eNFA121_9_50474807 -->|"e"|eNFA121_11_61927541
eNFA121_10_51620080 -->|"e"|eNFA121_11_61927541
eNFA121_11_61927541 -.->|"ε"|eNFA121_12_20476957
eNFA121_11_61927541 -->|"r"|eNFA121_13_50074891
eNFA121_12_20476957 -->|"r"|eNFA121_13_50074891
eNFA121_13_50074891 -.->|"ε"|eNFA121_14_48020839
eNFA121_13_50074891 -->|"2"|eNFA121_15_29534370
eNFA121_14_48020839 -->|"2"|eNFA121_15_29534370
eNFA121_15_29534370 -.->|"ε"|eNFA121_16_64482741
eNFA121_15_29534370 -->|"D"|eNFA121_17_43473761
eNFA121_16_64482741 -->|"D"|eNFA121_17_43473761
eNFA121_17_43473761 -.->|"ε"|eNFA121_19_55719536
eNFA121_17_43473761 -.->|"ε"|eNFA121_20_31713777
eNFA121_17_43473761 -.->|"ε"|eNFA121_21_16988543
eNFA121_19_55719536 -.->|"ε"|eNFA121_20_31713777
eNFA121_19_55719536 -.->|"ε"|eNFA121_21_16988543
eNFA121_20_31713777 -.->|"ε"|eNFA121_21_16988543
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
NFA121_18_18679162("NFA121-18 regex start")
NFA121_1_33894731("NFA121-1 char[1]")
NFA121_3_36617123("NFA121-3 char[1]")
NFA121_5_61118651("NFA121-5 char[1]")
NFA121_7_13196948("NFA121-7 char[1]")
NFA121_9_51663671("NFA121-9 char[1]")
NFA121_11_62319862("NFA121-11 char[1]")
NFA121_13_24007848("NFA121-13 char[1]")
NFA121_15_14744048("NFA121-15 char[1]")
NFA121_17_65587574[\"NFA121-17 char[1]"/]
NFA121_18_18679162 -->|"s"|NFA121_1_33894731
NFA121_1_33894731 -->|"a"|NFA121_3_36617123
NFA121_3_36617123 -->|"m"|NFA121_5_61118651
NFA121_5_61118651 -->|"p"|NFA121_7_13196948
NFA121_7_13196948 -->|"l"|NFA121_9_51663671
NFA121_9_51663671 -->|"e"|NFA121_11_62319862
NFA121_11_62319862 -->|"r"|NFA121_13_24007848
NFA121_13_24007848 -->|"2"|NFA121_15_14744048
NFA121_15_14744048 -->|"D"|NFA121_17_65587574
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
subgraph DFA0_1802734626["DFA0 regex start"]
NFA121_18_18679162_0("NFA121-18 regex start")
end
subgraph DFA1_1783903025["DFA1 {1}"]
NFA121_1_33894731_1("NFA121-1 char[1]")
end
subgraph DFA2_529351586["DFA2 {1}"]
NFA121_3_36617123_2("NFA121-3 char[1]")
end
subgraph DFA3_-34255236["DFA3 {1}"]
NFA121_5_61118651_3("NFA121-5 char[1]")
end
subgraph DFA4_778855262["DFA4 {1}"]
NFA121_7_13196948_4("NFA121-7 char[1]")
end
subgraph DFA5_-2026347654["DFA5 {1}"]
NFA121_9_51663671_5("NFA121-9 char[1]")
end
subgraph DFA6_1403038569["DFA6 {1}"]
NFA121_11_62319862_6("NFA121-11 char[1]")
end
subgraph DFA7_850168801["DFA7 {1}"]
NFA121_13_24007848_7("NFA121-13 char[1]")
end
subgraph DFA8_1400681750["DFA8 {1}"]
NFA121_15_14744048_8("NFA121-15 char[1]")
end
subgraph DFA9_1918221946["DFA9 {1}"]
NFA121_17_65587574_9[\"NFA121-17 char[1]"/]
end
DFA0_1802734626 -->|"s"|DFA1_1783903025
DFA1_1783903025 -->|"a"|DFA2_529351586
DFA2_529351586 -->|"m"|DFA3_-34255236
DFA3_-34255236 -->|"p"|DFA4_778855262
DFA4_778855262 -->|"l"|DFA5_-2026347654
DFA5_-2026347654 -->|"e"|DFA6_1403038569
DFA6_1403038569 -->|"r"|DFA7_850168801
DFA7_850168801 -->|"2"|DFA8_1400681750
DFA8_1400681750 -->|"D"|DFA9_1918221946
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
DFA0_1802734626{{"DFA0 regex start"}}
DFA1_1783903025{{"DFA1 {1}"}}
DFA2_529351586{{"DFA2 {1}"}}
DFA3_-34255236{{"DFA3 {1}"}}
DFA4_778855262{{"DFA4 {1}"}}
DFA5_-2026347654{{"DFA5 {1}"}}
DFA6_1403038569{{"DFA6 {1}"}}
DFA7_850168801{{"DFA7 {1}"}}
DFA8_1400681750{{"DFA8 {1}"}}
DFA9_1918221946[\"DFA9 {1}"/]
DFA0_1802734626 -->|"s"|DFA1_1783903025
DFA1_1783903025 -->|"a"|DFA2_529351586
DFA2_529351586 -->|"m"|DFA3_-34255236
DFA3_-34255236 -->|"p"|DFA4_778855262
DFA4_778855262 -->|"l"|DFA5_-2026347654
DFA5_-2026347654 -->|"e"|DFA6_1403038569
DFA6_1403038569 -->|"r"|DFA7_850168801
DFA7_850168801 -->|"2"|DFA8_1400681750
DFA8_1400681750 -->|"D"|DFA9_1918221946
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
subgraph MiniDFA0_403598513["MiniDFA0 {1}"]
DFA0_1802734626_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1073360953["MiniDFA1 {1}"]
DFA1_1783903025_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-321591160["MiniDFA2 {1}"]
DFA2_529351586_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_2114185190["MiniDFA3 {1}"]
DFA3_-34255236_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1626952663["MiniDFA4 {1}"]
DFA4_778855262_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1178241096["MiniDFA5 {1}"]
DFA5_-2026347654_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_542361089["MiniDFA6 {1}"]
DFA6_1403038569_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1942304891["MiniDFA7 {1}"]
DFA7_850168801_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1123250881["MiniDFA8 {1}"]
DFA8_1400681750_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_323743229["MiniDFA9 {1}"]
DFA9_1918221946_9[\"DFA9 {1}"/]
end
MiniDFA0_403598513 -->|"s"|MiniDFA1_1073360953
MiniDFA1_1073360953 -->|"a"|MiniDFA2_-321591160
MiniDFA2_-321591160 -->|"m"|MiniDFA3_2114185190
MiniDFA3_2114185190 -->|"p"|MiniDFA4_-1626952663
MiniDFA4_-1626952663 -->|"l"|MiniDFA5_1178241096
MiniDFA5_1178241096 -->|"e"|MiniDFA6_542361089
MiniDFA6_542361089 -->|"r"|MiniDFA7_-1942304891
MiniDFA7_-1942304891 -->|"2"|MiniDFA8_1123250881
MiniDFA8_1123250881 -->|"D"|MiniDFA9_323743229
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
MiniDFA0_403598513(["MiniDFA0 {1}"])
MiniDFA1_1073360953(["MiniDFA1 {1}"])
MiniDFA2_-321591160(["MiniDFA2 {1}"])
MiniDFA3_2114185190(["MiniDFA3 {1}"])
MiniDFA4_-1626952663(["MiniDFA4 {1}"])
MiniDFA5_1178241096(["MiniDFA5 {1}"])
MiniDFA6_542361089(["MiniDFA6 {1}"])
MiniDFA7_-1942304891(["MiniDFA7 {1}"])
MiniDFA8_1123250881(["MiniDFA8 {1}"])
MiniDFA9_323743229[\"MiniDFA9 {1}"/]
MiniDFA0_403598513 -->|"s"|MiniDFA1_1073360953
MiniDFA1_1073360953 -->|"a"|MiniDFA2_-321591160
MiniDFA2_-321591160 -->|"m"|MiniDFA3_2114185190
MiniDFA3_2114185190 -->|"p"|MiniDFA4_-1626952663
MiniDFA4_-1626952663 -->|"l"|MiniDFA5_1178241096
MiniDFA5_1178241096 -->|"e"|MiniDFA6_542361089
MiniDFA6_542361089 -->|"r"|MiniDFA7_-1942304891
MiniDFA7_-1942304891 -->|"2"|MiniDFA8_1123250881
MiniDFA8_1123250881 -->|"D"|MiniDFA9_323743229
```
-------------------------------
