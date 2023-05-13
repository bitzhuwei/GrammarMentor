# 'uimageBuffer'

pattern: `uimageBuffer`

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
eNFA177_24_19452465[["εNFA177-24 regex start"]]
eNFA177_0_40854465[["εNFA177-0 char{1, 1}"]]
eNFA177_1_32145867[["εNFA177-1 char[1]"]]
eNFA177_2_20877354[["εNFA177-2 char{1, 1}"]]
eNFA177_3_53678462[["εNFA177-3 char[1]"]]
eNFA177_4_13344112[["εNFA177-4 char{1, 1}"]]
eNFA177_5_52988145[["εNFA177-5 char[1]"]]
eNFA177_6_7131258[["εNFA177-6 char{1, 1}"]]
eNFA177_7_64181324[["εNFA177-7 char[1]"]]
eNFA177_8_40761008[["εNFA177-8 char{1, 1}"]]
eNFA177_9_31304760[["εNFA177-9 char[1]"]]
eNFA177_10_13307388[["εNFA177-10 char{1, 1}"]]
eNFA177_11_52657628[["εNFA177-11 char[1]"]]
eNFA177_12_4156611[["εNFA177-12 char{1, 1}"]]
eNFA177_13_37409505[["εNFA177-13 char[1]"]]
eNFA177_14_1141231[["εNFA177-14 char{1, 1}"]]
eNFA177_15_10271087[["εNFA177-15 char[1]"]]
eNFA177_16_25330920[["εNFA177-16 char{1, 1}"]]
eNFA177_17_26651693[["εNFA177-17 char[1]"]]
eNFA177_18_38538645[["εNFA177-18 char{1, 1}"]]
eNFA177_19_11303491[["εNFA177-19 char[1]"]]
eNFA177_20_34622559[["εNFA177-20 char{1, 1}"]]
eNFA177_21_43167578[["εNFA177-21 char[1]"]]
eNFA177_22_52963885[["εNFA177-22 char{1, 1}"]]
eNFA177_23_6912921[["εNFA177-23 char[1]"]]
eNFA177_25_62216296[["εNFA177-25 regex end"]]
eNFA177_26_23075753[["εNFA177-26 post-regex start"]]
eNFA177_27_6355191[\"εNFA177-27 post-regex end"/]
eNFA177_24_19452465 -.->|"ε"|eNFA177_0_40854465
eNFA177_0_40854465 -->|"u"|eNFA177_1_32145867
eNFA177_1_32145867 -.->|"ε"|eNFA177_2_20877354
eNFA177_2_20877354 -->|"i"|eNFA177_3_53678462
eNFA177_3_53678462 -.->|"ε"|eNFA177_4_13344112
eNFA177_4_13344112 -->|"m"|eNFA177_5_52988145
eNFA177_5_52988145 -.->|"ε"|eNFA177_6_7131258
eNFA177_6_7131258 -->|"a"|eNFA177_7_64181324
eNFA177_7_64181324 -.->|"ε"|eNFA177_8_40761008
eNFA177_8_40761008 -->|"g"|eNFA177_9_31304760
eNFA177_9_31304760 -.->|"ε"|eNFA177_10_13307388
eNFA177_10_13307388 -->|"e"|eNFA177_11_52657628
eNFA177_11_52657628 -.->|"ε"|eNFA177_12_4156611
eNFA177_12_4156611 -->|"B"|eNFA177_13_37409505
eNFA177_13_37409505 -.->|"ε"|eNFA177_14_1141231
eNFA177_14_1141231 -->|"u"|eNFA177_15_10271087
eNFA177_15_10271087 -.->|"ε"|eNFA177_16_25330920
eNFA177_16_25330920 -->|"f"|eNFA177_17_26651693
eNFA177_17_26651693 -.->|"ε"|eNFA177_18_38538645
eNFA177_18_38538645 -->|"f"|eNFA177_19_11303491
eNFA177_19_11303491 -.->|"ε"|eNFA177_20_34622559
eNFA177_20_34622559 -->|"e"|eNFA177_21_43167578
eNFA177_21_43167578 -.->|"ε"|eNFA177_22_52963885
eNFA177_22_52963885 -->|"r"|eNFA177_23_6912921
eNFA177_23_6912921 -.->|"ε"|eNFA177_25_62216296
eNFA177_25_62216296 -.->|"ε"|eNFA177_26_23075753
eNFA177_26_23075753 -.->|"ε"|eNFA177_27_6355191
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
eNFA177_24_57196722[["εNFA177-24 regex start"]]
eNFA177_0_45008451[["εNFA177-0 char{1, 1}"]]
eNFA177_1_2422875[["εNFA177-1 char[1]"]]
eNFA177_2_21805875[["εNFA177-2 char{1, 1}"]]
eNFA177_3_62035148[["εNFA177-3 char[1]"]]
eNFA177_4_21445423[["εNFA177-4 char{1, 1}"]]
eNFA177_5_58791086[["εNFA177-5 char[1]"]]
eNFA177_6_59357728[["εNFA177-6 char{1, 1}"]]
eNFA177_7_64457512[["εNFA177-7 char[1]"]]
eNFA177_8_43246702[["εNFA177-8 char{1, 1}"]]
eNFA177_9_53676003[["εNFA177-9 char[1]"]]
eNFA177_10_13321984[["εNFA177-10 char{1, 1}"]]
eNFA177_11_52788999[["εNFA177-11 char[1]"]]
eNFA177_12_5338943[["εNFA177-12 char{1, 1}"]]
eNFA177_13_48050490[["εNFA177-13 char[1]"]]
eNFA177_14_29801234[["εNFA177-14 char{1, 1}"]]
eNFA177_15_66884519[["εNFA177-15 char[1]"]]
eNFA177_16_65089762[["εNFA177-16 char{1, 1}"]]
eNFA177_17_48936948[["εNFA177-17 char[1]"]]
eNFA177_18_37779350[["εNFA177-18 char{1, 1}"]]
eNFA177_19_4469833[["εNFA177-19 char[1]"]]
eNFA177_20_40228503[["εNFA177-20 char{1, 1}"]]
eNFA177_21_26512207[["εNFA177-21 char[1]"]]
eNFA177_22_37283276[["εNFA177-22 char{1, 1}"]]
eNFA177_23_5165[\"εNFA177-23 char[1]"/]
eNFA177_25_46493[\"εNFA177-25 regex end"/]
eNFA177_26_418444[\"εNFA177-26 post-regex start"/]
eNFA177_27_3766004[\"εNFA177-27 post-regex end"/]
eNFA177_24_57196722 -.->|"ε"|eNFA177_0_45008451
eNFA177_24_57196722 -->|"u"|eNFA177_1_2422875
eNFA177_0_45008451 -->|"u"|eNFA177_1_2422875
eNFA177_1_2422875 -.->|"ε"|eNFA177_2_21805875
eNFA177_1_2422875 -->|"i"|eNFA177_3_62035148
eNFA177_2_21805875 -->|"i"|eNFA177_3_62035148
eNFA177_3_62035148 -.->|"ε"|eNFA177_4_21445423
eNFA177_3_62035148 -->|"m"|eNFA177_5_58791086
eNFA177_4_21445423 -->|"m"|eNFA177_5_58791086
eNFA177_5_58791086 -.->|"ε"|eNFA177_6_59357728
eNFA177_5_58791086 -->|"a"|eNFA177_7_64457512
eNFA177_6_59357728 -->|"a"|eNFA177_7_64457512
eNFA177_7_64457512 -.->|"ε"|eNFA177_8_43246702
eNFA177_7_64457512 -->|"g"|eNFA177_9_53676003
eNFA177_8_43246702 -->|"g"|eNFA177_9_53676003
eNFA177_9_53676003 -.->|"ε"|eNFA177_10_13321984
eNFA177_9_53676003 -->|"e"|eNFA177_11_52788999
eNFA177_10_13321984 -->|"e"|eNFA177_11_52788999
eNFA177_11_52788999 -.->|"ε"|eNFA177_12_5338943
eNFA177_11_52788999 -->|"B"|eNFA177_13_48050490
eNFA177_12_5338943 -->|"B"|eNFA177_13_48050490
eNFA177_13_48050490 -.->|"ε"|eNFA177_14_29801234
eNFA177_13_48050490 -->|"u"|eNFA177_15_66884519
eNFA177_14_29801234 -->|"u"|eNFA177_15_66884519
eNFA177_15_66884519 -.->|"ε"|eNFA177_16_65089762
eNFA177_15_66884519 -->|"f"|eNFA177_17_48936948
eNFA177_16_65089762 -->|"f"|eNFA177_17_48936948
eNFA177_17_48936948 -.->|"ε"|eNFA177_18_37779350
eNFA177_17_48936948 -->|"f"|eNFA177_19_4469833
eNFA177_18_37779350 -->|"f"|eNFA177_19_4469833
eNFA177_19_4469833 -.->|"ε"|eNFA177_20_40228503
eNFA177_19_4469833 -->|"e"|eNFA177_21_26512207
eNFA177_20_40228503 -->|"e"|eNFA177_21_26512207
eNFA177_21_26512207 -.->|"ε"|eNFA177_22_37283276
eNFA177_21_26512207 -->|"r"|eNFA177_23_5165
eNFA177_22_37283276 -->|"r"|eNFA177_23_5165
eNFA177_23_5165 -.->|"ε"|eNFA177_25_46493
eNFA177_23_5165 -.->|"ε"|eNFA177_26_418444
eNFA177_23_5165 -.->|"ε"|eNFA177_27_3766004
eNFA177_25_46493 -.->|"ε"|eNFA177_26_418444
eNFA177_25_46493 -.->|"ε"|eNFA177_27_3766004
eNFA177_26_418444 -.->|"ε"|eNFA177_27_3766004
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
NFA177_24_33894036("NFA177-24 regex start")
NFA177_1_36610870("NFA177-1 char[1]")
NFA177_3_61062380("NFA177-3 char[1]")
NFA177_5_12690509("NFA177-5 char[1]")
NFA177_7_47105724("NFA177-7 char[1]")
NFA177_9_21298337("NFA177-9 char[1]")
NFA177_11_57467309("NFA177-11 char[1]")
NFA177_13_47443737("NFA177-13 char[1]")
NFA177_15_24340454("NFA177-15 char[1]")
NFA177_17_17737502("NFA177-17 char[1]")
NFA177_19_25419792("NFA177-19 char[1]")
NFA177_21_27451543("NFA177-21 char[1]")
NFA177_23_45737299[\"NFA177-23 char[1]"/]
NFA177_24_33894036 -->|"u"|NFA177_1_36610870
NFA177_1_36610870 -->|"i"|NFA177_3_61062380
NFA177_3_61062380 -->|"m"|NFA177_5_12690509
NFA177_5_12690509 -->|"a"|NFA177_7_47105724
NFA177_7_47105724 -->|"g"|NFA177_9_21298337
NFA177_9_21298337 -->|"e"|NFA177_11_57467309
NFA177_11_57467309 -->|"B"|NFA177_13_47443737
NFA177_13_47443737 -->|"u"|NFA177_15_24340454
NFA177_15_24340454 -->|"f"|NFA177_17_17737502
NFA177_17_17737502 -->|"f"|NFA177_19_25419792
NFA177_19_25419792 -->|"e"|NFA177_21_27451543
NFA177_21_27451543 -->|"r"|NFA177_23_45737299
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
subgraph DFA0_-564464825["DFA0 regex start"]
NFA177_24_33894036_0("NFA177-24 regex start")
end
subgraph DFA1_1431398990["DFA1 {1}"]
NFA177_1_36610870_1("NFA177-1 char[1]")
end
subgraph DFA2_-1559686236["DFA2 {1}"]
NFA177_3_61062380_2("NFA177-3 char[1]")
end
subgraph DFA3_-1883567020["DFA3 {1}"]
NFA177_5_12690509_3("NFA177-5 char[1]")
end
subgraph DFA4_-1391019893["DFA4 {1}"]
NFA177_7_47105724_4("NFA177-7 char[1]")
end
subgraph DFA5_890124479["DFA5 {1}"]
NFA177_9_21298337_5("NFA177-9 char[1]")
end
subgraph DFA6_1885015711["DFA6 {1}"]
NFA177_11_57467309_6("NFA177-11 char[1]")
end
subgraph DFA7_-214340007["DFA7 {1}"]
NFA177_13_47443737_7("NFA177-13 char[1]")
end
subgraph DFA8_-260719618["DFA8 {1}"]
NFA177_15_24340454_8("NFA177-15 char[1]")
end
subgraph DFA9_-111473269["DFA9 {1}"]
NFA177_17_17737502_9("NFA177-17 char[1]")
end
subgraph DFA10_-2029404628["DFA10 {1}"]
NFA177_19_25419792_10("NFA177-19 char[1]")
end
subgraph DFA11_-92987748["DFA11 {1}"]
NFA177_21_27451543_11("NFA177-21 char[1]")
end
subgraph DFA12_-824558133["DFA12 {1}"]
NFA177_23_45737299_12[\"NFA177-23 char[1]"/]
end
DFA0_-564464825 -->|"u"|DFA1_1431398990
DFA1_1431398990 -->|"i"|DFA2_-1559686236
DFA2_-1559686236 -->|"m"|DFA3_-1883567020
DFA3_-1883567020 -->|"a"|DFA4_-1391019893
DFA4_-1391019893 -->|"g"|DFA5_890124479
DFA5_890124479 -->|"e"|DFA6_1885015711
DFA6_1885015711 -->|"B"|DFA7_-214340007
DFA7_-214340007 -->|"u"|DFA8_-260719618
DFA8_-260719618 -->|"f"|DFA9_-111473269
DFA9_-111473269 -->|"f"|DFA10_-2029404628
DFA10_-2029404628 -->|"e"|DFA11_-92987748
DFA11_-92987748 -->|"r"|DFA12_-824558133
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
DFA0_-564464825{{"DFA0 regex start"}}
DFA1_1431398990{{"DFA1 {1}"}}
DFA2_-1559686236{{"DFA2 {1}"}}
DFA3_-1883567020{{"DFA3 {1}"}}
DFA4_-1391019893{{"DFA4 {1}"}}
DFA5_890124479{{"DFA5 {1}"}}
DFA6_1885015711{{"DFA6 {1}"}}
DFA7_-214340007{{"DFA7 {1}"}}
DFA8_-260719618{{"DFA8 {1}"}}
DFA9_-111473269{{"DFA9 {1}"}}
DFA10_-2029404628{{"DFA10 {1}"}}
DFA11_-92987748{{"DFA11 {1}"}}
DFA12_-824558133[\"DFA12 {1}"/]
DFA0_-564464825 -->|"u"|DFA1_1431398990
DFA1_1431398990 -->|"i"|DFA2_-1559686236
DFA2_-1559686236 -->|"m"|DFA3_-1883567020
DFA3_-1883567020 -->|"a"|DFA4_-1391019893
DFA4_-1391019893 -->|"g"|DFA5_890124479
DFA5_890124479 -->|"e"|DFA6_1885015711
DFA6_1885015711 -->|"B"|DFA7_-214340007
DFA7_-214340007 -->|"u"|DFA8_-260719618
DFA8_-260719618 -->|"f"|DFA9_-111473269
DFA9_-111473269 -->|"f"|DFA10_-2029404628
DFA10_-2029404628 -->|"e"|DFA11_-92987748
DFA11_-92987748 -->|"r"|DFA12_-824558133
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
subgraph MiniDFA0_672546155["MiniDFA0 {1}"]
DFA0_-564464825_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_1547695543["MiniDFA2 {1}"]
DFA1_1431398990_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-1269166922["MiniDFA3 {1}"]
DFA2_-1559686236_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_621832399["MiniDFA4 {1}"]
DFA3_-1883567020_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_1167958650["MiniDFA5 {1}"]
DFA4_-1391019893_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1905711568["MiniDFA6 {1}"]
DFA5_890124479_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_330701050["MiniDFA8 {1}"]
DFA6_1885015711_6{{"DFA6 {1}"}}
end
subgraph MiniDFA1_1282253595["MiniDFA1 {1}"]
DFA7_-214340007_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_468729391["MiniDFA9 {1}"]
DFA8_-260719618_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-2098459639["MiniDFA10 {1}"]
DFA9_-111473269_9{{"DFA9 {1}"}}
end
subgraph MiniDFA7_1201095526["MiniDFA7 {1}"]
DFA10_-2029404628_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_1696023297["MiniDFA11 {1}"]
DFA11_-92987748_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_175188523["MiniDFA12 {1}"]
DFA12_-824558133_12[\"DFA12 {1}"/]
end
MiniDFA0_672546155 -->|"u"|MiniDFA2_1547695543
MiniDFA2_1547695543 -->|"i"|MiniDFA3_-1269166922
MiniDFA3_-1269166922 -->|"m"|MiniDFA4_621832399
MiniDFA4_621832399 -->|"a"|MiniDFA5_1167958650
MiniDFA5_1167958650 -->|"g"|MiniDFA6_1905711568
MiniDFA6_1905711568 -->|"e"|MiniDFA8_330701050
MiniDFA8_330701050 -->|"B"|MiniDFA1_1282253595
MiniDFA1_1282253595 -->|"u"|MiniDFA9_468729391
MiniDFA9_468729391 -->|"f"|MiniDFA10_-2098459639
MiniDFA10_-2098459639 -->|"f"|MiniDFA7_1201095526
MiniDFA7_1201095526 -->|"e"|MiniDFA11_1696023297
MiniDFA11_1696023297 -->|"r"|MiniDFA12_175188523
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
MiniDFA0_672546155(["MiniDFA0 {1}"])
MiniDFA2_1547695543(["MiniDFA2 {1}"])
MiniDFA3_-1269166922(["MiniDFA3 {1}"])
MiniDFA4_621832399(["MiniDFA4 {1}"])
MiniDFA5_1167958650(["MiniDFA5 {1}"])
MiniDFA6_1905711568(["MiniDFA6 {1}"])
MiniDFA8_330701050(["MiniDFA8 {1}"])
MiniDFA1_1282253595(["MiniDFA1 {1}"])
MiniDFA9_468729391(["MiniDFA9 {1}"])
MiniDFA10_-2098459639(["MiniDFA10 {1}"])
MiniDFA7_1201095526(["MiniDFA7 {1}"])
MiniDFA11_1696023297(["MiniDFA11 {1}"])
MiniDFA12_175188523[\"MiniDFA12 {1}"/]
MiniDFA0_672546155 -->|"u"|MiniDFA2_1547695543
MiniDFA2_1547695543 -->|"i"|MiniDFA3_-1269166922
MiniDFA3_-1269166922 -->|"m"|MiniDFA4_621832399
MiniDFA4_621832399 -->|"a"|MiniDFA5_1167958650
MiniDFA5_1167958650 -->|"g"|MiniDFA6_1905711568
MiniDFA6_1905711568 -->|"e"|MiniDFA8_330701050
MiniDFA8_330701050 -->|"B"|MiniDFA1_1282253595
MiniDFA1_1282253595 -->|"u"|MiniDFA9_468729391
MiniDFA9_468729391 -->|"f"|MiniDFA10_-2098459639
MiniDFA10_-2098459639 -->|"f"|MiniDFA7_1201095526
MiniDFA7_1201095526 -->|"e"|MiniDFA11_1696023297
MiniDFA11_1696023297 -->|"r"|MiniDFA12_175188523
```
-------------------------------
