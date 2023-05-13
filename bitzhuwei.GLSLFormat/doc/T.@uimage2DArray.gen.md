# 'uimage2DArray'

pattern: `uimage2DArray`

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
eNFA183_26_6424936[["εNFA183-26 regex start"]]
eNFA183_0_57824424[["εNFA183-0 char{1, 1}"]]
eNFA183_1_50657768[["εNFA183-1 char[1]"]]
eNFA183_2_53266729[["εNFA183-2 char{1, 1}"]]
eNFA183_3_9638516[["εNFA183-3 char[1]"]]
eNFA183_4_19637787[["εNFA183-4 char{1, 1}"]]
eNFA183_5_42522357[["εNFA183-5 char[1]"]]
eNFA183_6_47156901[["εNFA183-6 char{1, 1}"]]
eNFA183_7_21758931[["εNFA183-7 char[1]"]]
eNFA183_8_61612656[["εNFA183-8 char{1, 1}"]]
eNFA183_9_17642997[["εNFA183-9 char[1]"]]
eNFA183_10_24569252[["εNFA183-10 char{1, 1}"]]
eNFA183_11_19796676[["εNFA183-11 char[1]"]]
eNFA183_12_43952359[["εNFA183-12 char{1, 1}"]]
eNFA183_13_60026919[["εNFA183-13 char[1]"]]
eNFA183_14_3371364[["εNFA183-14 char{1, 1}"]]
eNFA183_15_30342279[["εNFA183-15 char[1]"]]
eNFA183_16_4645057[["εNFA183-16 char{1, 1}"]]
eNFA183_17_41805515[["εNFA183-17 char[1]"]]
eNFA183_18_40705318[["εNFA183-18 char{1, 1}"]]
eNFA183_19_30803548[["εNFA183-19 char[1]"]]
eNFA183_20_8796476[["εNFA183-20 char{1, 1}"]]
eNFA183_21_12059425[["εNFA183-21 char[1]"]]
eNFA183_22_41425962[["εNFA183-22 char{1, 1}"]]
eNFA183_23_37289346[["εNFA183-23 char[1]"]]
eNFA183_24_59801[["εNFA183-24 char{1, 1}"]]
eNFA183_25_538217[["εNFA183-25 char[1]"]]
eNFA183_27_4843953[["εNFA183-27 regex end"]]
eNFA183_28_43595579[["εNFA183-28 post-regex start"]]
eNFA183_29_56815897[\"εNFA183-29 post-regex end"/]
eNFA183_26_6424936 -.->|"ε"|eNFA183_0_57824424
eNFA183_0_57824424 -->|"u"|eNFA183_1_50657768
eNFA183_1_50657768 -.->|"ε"|eNFA183_2_53266729
eNFA183_2_53266729 -->|"i"|eNFA183_3_9638516
eNFA183_3_9638516 -.->|"ε"|eNFA183_4_19637787
eNFA183_4_19637787 -->|"m"|eNFA183_5_42522357
eNFA183_5_42522357 -.->|"ε"|eNFA183_6_47156901
eNFA183_6_47156901 -->|"a"|eNFA183_7_21758931
eNFA183_7_21758931 -.->|"ε"|eNFA183_8_61612656
eNFA183_8_61612656 -->|"g"|eNFA183_9_17642997
eNFA183_9_17642997 -.->|"ε"|eNFA183_10_24569252
eNFA183_10_24569252 -->|"e"|eNFA183_11_19796676
eNFA183_11_19796676 -.->|"ε"|eNFA183_12_43952359
eNFA183_12_43952359 -->|"2"|eNFA183_13_60026919
eNFA183_13_60026919 -.->|"ε"|eNFA183_14_3371364
eNFA183_14_3371364 -->|"D"|eNFA183_15_30342279
eNFA183_15_30342279 -.->|"ε"|eNFA183_16_4645057
eNFA183_16_4645057 -->|"A"|eNFA183_17_41805515
eNFA183_17_41805515 -.->|"ε"|eNFA183_18_40705318
eNFA183_18_40705318 -->|"r"|eNFA183_19_30803548
eNFA183_19_30803548 -.->|"ε"|eNFA183_20_8796476
eNFA183_20_8796476 -->|"r"|eNFA183_21_12059425
eNFA183_21_12059425 -.->|"ε"|eNFA183_22_41425962
eNFA183_22_41425962 -->|"a"|eNFA183_23_37289346
eNFA183_23_37289346 -.->|"ε"|eNFA183_24_59801
eNFA183_24_59801 -->|"y"|eNFA183_25_538217
eNFA183_25_538217 -.->|"ε"|eNFA183_27_4843953
eNFA183_27_4843953 -.->|"ε"|eNFA183_28_43595579
eNFA183_28_43595579 -.->|"ε"|eNFA183_29_56815897
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
eNFA183_26_41581026[["εNFA183-26 regex start"]]
eNFA183_0_38684921[["εNFA183-0 char{1, 1}"]]
eNFA183_1_12619974[["εNFA183-1 char[1]"]]
eNFA183_2_46470906[["εNFA183-2 char{1, 1}"]]
eNFA183_3_15584974[["εNFA183-3 char[1]"]]
eNFA183_4_6047043[["εNFA183-4 char{1, 1}"]]
eNFA183_5_54423395[["εNFA183-5 char[1]"]]
eNFA183_6_20048509[["εNFA183-6 char{1, 1}"]]
eNFA183_7_46218860[["εNFA183-7 char[1]"]]
eNFA183_8_13316560[["εNFA183-8 char{1, 1}"]]
eNFA183_9_52740178[["εNFA183-9 char[1]"]]
eNFA183_10_4899555[["εNFA183-10 char{1, 1}"]]
eNFA183_11_44095996[["εNFA183-11 char[1]"]]
eNFA183_12_61319646[["εNFA183-12 char{1, 1}"]]
eNFA183_13_15005906[["εNFA183-13 char[1]"]]
eNFA183_14_835434[["εNFA183-14 char{1, 1}"]]
eNFA183_15_7518910[["εNFA183-15 char[1]"]]
eNFA183_16_561326[["εNFA183-16 char{1, 1}"]]
eNFA183_17_5051941[["εNFA183-17 char[1]"]]
eNFA183_18_45467475[["εNFA183-18 char{1, 1}"]]
eNFA183_19_6554097[["εNFA183-19 char[1]"]]
eNFA183_20_58986881[["εNFA183-20 char{1, 1}"]]
eNFA183_21_61119882[["εNFA183-21 char[1]"]]
eNFA183_22_13208031[["εNFA183-22 char{1, 1}"]]
eNFA183_23_51763415[["εNFA183-23 char[1]"]]
eNFA183_24_63217557[["εNFA183-24 char{1, 1}"]]
eNFA183_25_32087105[\"εNFA183-25 char[1]"/]
eNFA183_27_20348492[\"εNFA183-27 regex end"/]
eNFA183_28_48918703[\"εNFA183-28 post-regex start"/]
eNFA183_29_37615147[\"εNFA183-29 post-regex end"/]
eNFA183_26_41581026 -.->|"ε"|eNFA183_0_38684921
eNFA183_26_41581026 -->|"u"|eNFA183_1_12619974
eNFA183_0_38684921 -->|"u"|eNFA183_1_12619974
eNFA183_1_12619974 -.->|"ε"|eNFA183_2_46470906
eNFA183_1_12619974 -->|"i"|eNFA183_3_15584974
eNFA183_2_46470906 -->|"i"|eNFA183_3_15584974
eNFA183_3_15584974 -.->|"ε"|eNFA183_4_6047043
eNFA183_3_15584974 -->|"m"|eNFA183_5_54423395
eNFA183_4_6047043 -->|"m"|eNFA183_5_54423395
eNFA183_5_54423395 -.->|"ε"|eNFA183_6_20048509
eNFA183_5_54423395 -->|"a"|eNFA183_7_46218860
eNFA183_6_20048509 -->|"a"|eNFA183_7_46218860
eNFA183_7_46218860 -.->|"ε"|eNFA183_8_13316560
eNFA183_7_46218860 -->|"g"|eNFA183_9_52740178
eNFA183_8_13316560 -->|"g"|eNFA183_9_52740178
eNFA183_9_52740178 -.->|"ε"|eNFA183_10_4899555
eNFA183_9_52740178 -->|"e"|eNFA183_11_44095996
eNFA183_10_4899555 -->|"e"|eNFA183_11_44095996
eNFA183_11_44095996 -.->|"ε"|eNFA183_12_61319646
eNFA183_11_44095996 -->|"2"|eNFA183_13_15005906
eNFA183_12_61319646 -->|"2"|eNFA183_13_15005906
eNFA183_13_15005906 -.->|"ε"|eNFA183_14_835434
eNFA183_13_15005906 -->|"D"|eNFA183_15_7518910
eNFA183_14_835434 -->|"D"|eNFA183_15_7518910
eNFA183_15_7518910 -.->|"ε"|eNFA183_16_561326
eNFA183_15_7518910 -->|"A"|eNFA183_17_5051941
eNFA183_16_561326 -->|"A"|eNFA183_17_5051941
eNFA183_17_5051941 -.->|"ε"|eNFA183_18_45467475
eNFA183_17_5051941 -->|"r"|eNFA183_19_6554097
eNFA183_18_45467475 -->|"r"|eNFA183_19_6554097
eNFA183_19_6554097 -.->|"ε"|eNFA183_20_58986881
eNFA183_19_6554097 -->|"r"|eNFA183_21_61119882
eNFA183_20_58986881 -->|"r"|eNFA183_21_61119882
eNFA183_21_61119882 -.->|"ε"|eNFA183_22_13208031
eNFA183_21_61119882 -->|"a"|eNFA183_23_51763415
eNFA183_22_13208031 -->|"a"|eNFA183_23_51763415
eNFA183_23_51763415 -.->|"ε"|eNFA183_24_63217557
eNFA183_23_51763415 -->|"y"|eNFA183_25_32087105
eNFA183_24_63217557 -->|"y"|eNFA183_25_32087105
eNFA183_25_32087105 -.->|"ε"|eNFA183_27_20348492
eNFA183_25_32087105 -.->|"ε"|eNFA183_28_48918703
eNFA183_25_32087105 -.->|"ε"|eNFA183_29_37615147
eNFA183_27_20348492 -.->|"ε"|eNFA183_28_48918703
eNFA183_27_20348492 -.->|"ε"|eNFA183_29_37615147
eNFA183_28_48918703 -.->|"ε"|eNFA183_29_37615147
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
NFA183_26_2992010("NFA183-26 regex start")
NFA183_1_26928091("NFA183-1 char[1]")
NFA183_3_41026233("NFA183-3 char[1]")
NFA183_5_33691780("NFA183-5 char[1]")
NFA183_7_34790565("NFA183-7 char[1]")
NFA183_9_44679629("NFA183-9 char[1]")
NFA183_11_66572341("NFA183-11 char[1]")
NFA183_13_62280158("NFA183-13 char[1]")
NFA183_15_23650513("NFA183-15 char[1]")
NFA183_17_11528032("NFA183-17 char[1]")
NFA183_19_36643426("NFA183-19 char[1]")
NFA183_21_61355386("NFA183-21 char[1]")
NFA183_23_15327568("NFA183-23 char[1]")
NFA183_25_3730389[\"NFA183-25 char[1]"/]
NFA183_26_2992010 -->|"u"|NFA183_1_26928091
NFA183_1_26928091 -->|"i"|NFA183_3_41026233
NFA183_3_41026233 -->|"m"|NFA183_5_33691780
NFA183_5_33691780 -->|"a"|NFA183_7_34790565
NFA183_7_34790565 -->|"g"|NFA183_9_44679629
NFA183_9_44679629 -->|"e"|NFA183_11_66572341
NFA183_11_66572341 -->|"2"|NFA183_13_62280158
NFA183_13_62280158 -->|"D"|NFA183_15_23650513
NFA183_15_23650513 -->|"A"|NFA183_17_11528032
NFA183_17_11528032 -->|"r"|NFA183_19_36643426
NFA183_19_36643426 -->|"r"|NFA183_21_61355386
NFA183_21_61355386 -->|"a"|NFA183_23_15327568
NFA183_23_15327568 -->|"y"|NFA183_25_3730389
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
subgraph DFA0_169148673["DFA0 regex start"]
NFA183_26_2992010_0("NFA183-26 regex start")
end
subgraph DFA1_-1474620430["DFA1 {1}"]
NFA183_1_26928091_1("NFA183-1 char[1]")
end
subgraph DFA2_1690540717["DFA2 {1}"]
NFA183_3_41026233_2("NFA183-3 char[1]")
end
subgraph DFA3_1813331406["DFA3 {1}"]
NFA183_5_33691780_3("NFA183-5 char[1]")
end
subgraph DFA4_1622986808["DFA4 {1}"]
NFA183_7_34790565_4("NFA183-7 char[1]")
end
subgraph DFA5_-2086338621["DFA5 {1}"]
NFA183_9_44679629_5("NFA183-9 char[1]")
end
subgraph DFA6_-1179906069["DFA6 {1}"]
NFA183_11_66572341_6("NFA183-11 char[1]")
end
subgraph DFA7_-1729825468["DFA7 {1}"]
NFA183_13_62280158_7("NFA183-13 char[1]")
end
subgraph DFA8_2104264248["DFA8 {1}"]
NFA183_15_23650513_8("NFA183-15 char[1]")
end
subgraph DFA9_685497294["DFA9 {1}"]
NFA183_17_11528032_9("NFA183-17 char[1]")
end
subgraph DFA10_256121731["DFA10 {1}"]
NFA183_19_36643426_10("NFA183-19 char[1]")
end
subgraph DFA11_-144770498["DFA11 {1}"]
NFA183_21_61355386_11("NFA183-21 char[1]")
end
subgraph DFA12_1451348595["DFA12 {1}"]
NFA183_23_15327568_12("NFA183-23 char[1]")
end
subgraph DFA13_-1981265084["DFA13 {1}"]
NFA183_25_3730389_13[\"NFA183-25 char[1]"/]
end
DFA0_169148673 -->|"u"|DFA1_-1474620430
DFA1_-1474620430 -->|"i"|DFA2_1690540717
DFA2_1690540717 -->|"m"|DFA3_1813331406
DFA3_1813331406 -->|"a"|DFA4_1622986808
DFA4_1622986808 -->|"g"|DFA5_-2086338621
DFA5_-2086338621 -->|"e"|DFA6_-1179906069
DFA6_-1179906069 -->|"2"|DFA7_-1729825468
DFA7_-1729825468 -->|"D"|DFA8_2104264248
DFA8_2104264248 -->|"A"|DFA9_685497294
DFA9_685497294 -->|"r"|DFA10_256121731
DFA10_256121731 -->|"r"|DFA11_-144770498
DFA11_-144770498 -->|"a"|DFA12_1451348595
DFA12_1451348595 -->|"y"|DFA13_-1981265084
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
DFA0_169148673{{"DFA0 regex start"}}
DFA1_-1474620430{{"DFA1 {1}"}}
DFA2_1690540717{{"DFA2 {1}"}}
DFA3_1813331406{{"DFA3 {1}"}}
DFA4_1622986808{{"DFA4 {1}"}}
DFA5_-2086338621{{"DFA5 {1}"}}
DFA6_-1179906069{{"DFA6 {1}"}}
DFA7_-1729825468{{"DFA7 {1}"}}
DFA8_2104264248{{"DFA8 {1}"}}
DFA9_685497294{{"DFA9 {1}"}}
DFA10_256121731{{"DFA10 {1}"}}
DFA11_-144770498{{"DFA11 {1}"}}
DFA12_1451348595{{"DFA12 {1}"}}
DFA13_-1981265084[\"DFA13 {1}"/]
DFA0_169148673 -->|"u"|DFA1_-1474620430
DFA1_-1474620430 -->|"i"|DFA2_1690540717
DFA2_1690540717 -->|"m"|DFA3_1813331406
DFA3_1813331406 -->|"a"|DFA4_1622986808
DFA4_1622986808 -->|"g"|DFA5_-2086338621
DFA5_-2086338621 -->|"e"|DFA6_-1179906069
DFA6_-1179906069 -->|"2"|DFA7_-1729825468
DFA7_-1729825468 -->|"D"|DFA8_2104264248
DFA8_2104264248 -->|"A"|DFA9_685497294
DFA9_685497294 -->|"r"|DFA10_256121731
DFA10_256121731 -->|"r"|DFA11_-144770498
DFA11_-144770498 -->|"a"|DFA12_1451348595
DFA12_1451348595 -->|"y"|DFA13_-1981265084
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
subgraph MiniDFA0_-888685780["MiniDFA0 {1}"]
DFA0_169148673_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1145605448["MiniDFA1 {1}"]
DFA1_-1474620430_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1263485620["MiniDFA2 {1}"]
DFA2_1690540717_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1693852790["MiniDFA3 {1}"]
DFA3_1813331406_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1944794656["MiniDFA5 {1}"]
DFA4_1622986808_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_758093782["MiniDFA6 {1}"]
DFA5_-2086338621_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1272498383["MiniDFA7 {1}"]
DFA6_-1179906069_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_392228269["MiniDFA8 {1}"]
DFA7_-1729825468_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1428303648["MiniDFA9 {1}"]
DFA8_2104264248_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_113947408["MiniDFA10 {1}"]
DFA9_685497294_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-118859183["MiniDFA11 {1}"]
DFA10_256121731_10{{"DFA10 {1}"}}
end
subgraph MiniDFA4_1087732123["MiniDFA4 {1}"]
DFA11_-144770498_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-2134570224["MiniDFA12 {1}"]
DFA12_1451348595_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-456001287["MiniDFA13 {1}"]
DFA13_-1981265084_13[\"DFA13 {1}"/]
end
MiniDFA0_-888685780 -->|"u"|MiniDFA1_1145605448
MiniDFA1_1145605448 -->|"i"|MiniDFA2_-1263485620
MiniDFA2_-1263485620 -->|"m"|MiniDFA3_1693852790
MiniDFA3_1693852790 -->|"a"|MiniDFA5_-1944794656
MiniDFA5_-1944794656 -->|"g"|MiniDFA6_758093782
MiniDFA6_758093782 -->|"e"|MiniDFA7_-1272498383
MiniDFA7_-1272498383 -->|"2"|MiniDFA8_392228269
MiniDFA8_392228269 -->|"D"|MiniDFA9_-1428303648
MiniDFA9_-1428303648 -->|"A"|MiniDFA10_113947408
MiniDFA10_113947408 -->|"r"|MiniDFA11_-118859183
MiniDFA11_-118859183 -->|"r"|MiniDFA4_1087732123
MiniDFA4_1087732123 -->|"a"|MiniDFA12_-2134570224
MiniDFA12_-2134570224 -->|"y"|MiniDFA13_-456001287
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
MiniDFA0_-888685780(["MiniDFA0 {1}"])
MiniDFA1_1145605448(["MiniDFA1 {1}"])
MiniDFA2_-1263485620(["MiniDFA2 {1}"])
MiniDFA3_1693852790(["MiniDFA3 {1}"])
MiniDFA5_-1944794656(["MiniDFA5 {1}"])
MiniDFA6_758093782(["MiniDFA6 {1}"])
MiniDFA7_-1272498383(["MiniDFA7 {1}"])
MiniDFA8_392228269(["MiniDFA8 {1}"])
MiniDFA9_-1428303648(["MiniDFA9 {1}"])
MiniDFA10_113947408(["MiniDFA10 {1}"])
MiniDFA11_-118859183(["MiniDFA11 {1}"])
MiniDFA4_1087732123(["MiniDFA4 {1}"])
MiniDFA12_-2134570224(["MiniDFA12 {1}"])
MiniDFA13_-456001287[\"MiniDFA13 {1}"/]
MiniDFA0_-888685780 -->|"u"|MiniDFA1_1145605448
MiniDFA1_1145605448 -->|"i"|MiniDFA2_-1263485620
MiniDFA2_-1263485620 -->|"m"|MiniDFA3_1693852790
MiniDFA3_1693852790 -->|"a"|MiniDFA5_-1944794656
MiniDFA5_-1944794656 -->|"g"|MiniDFA6_758093782
MiniDFA6_758093782 -->|"e"|MiniDFA7_-1272498383
MiniDFA7_-1272498383 -->|"2"|MiniDFA8_392228269
MiniDFA8_392228269 -->|"D"|MiniDFA9_-1428303648
MiniDFA9_-1428303648 -->|"A"|MiniDFA10_113947408
MiniDFA10_113947408 -->|"r"|MiniDFA11_-118859183
MiniDFA11_-118859183 -->|"r"|MiniDFA4_1087732123
MiniDFA4_1087732123 -->|"a"|MiniDFA12_-2134570224
MiniDFA12_-2134570224 -->|"y"|MiniDFA13_-456001287
```
-------------------------------
