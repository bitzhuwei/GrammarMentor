# 'isampler2DArray'

pattern: `isampler2DArray`

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
eNFA138_30_4285383[["εNFA138-30 regex start"]]
eNFA138_0_38568449[["εNFA138-0 char{1, 1}"]]
eNFA138_1_11571729[["εNFA138-1 char[1]"]]
eNFA138_2_37036703[["εNFA138-2 char{1, 1}"]]
eNFA138_3_64894876[["εNFA138-3 char[1]"]]
eNFA138_4_47182977[["εNFA138-4 char{1, 1}"]]
eNFA138_5_21993616[["εNFA138-5 char[1]"]]
eNFA138_6_63724816[["εNFA138-6 char{1, 1}"]]
eNFA138_7_36652435[["εNFA138-7 char[1]"]]
eNFA138_8_61436467[["εNFA138-8 char{1, 1}"]]
eNFA138_9_16057296[["εNFA138-9 char[1]"]]
eNFA138_10_10297939[["εNFA138-10 char{1, 1}"]]
eNFA138_11_25572589[["εNFA138-11 char[1]"]]
eNFA138_12_28826711[["εNFA138-12 char{1, 1}"]]
eNFA138_13_58113810[["εNFA138-13 char[1]"]]
eNFA138_14_53262248[["εNFA138-14 char{1, 1}"]]
eNFA138_15_9598184[["εNFA138-15 char[1]"]]
eNFA138_16_19274797[["εNFA138-16 char{1, 1}"]]
eNFA138_17_39255446[["εNFA138-17 char[1]"]]
eNFA138_18_17754702[["εNFA138-18 char{1, 1}"]]
eNFA138_19_25574597[["εNFA138-19 char[1]"]]
eNFA138_20_28844789[["εNFA138-20 char{1, 1}"]]
eNFA138_21_58276509[["εNFA138-21 char[1]"]]
eNFA138_22_54726535[["εNFA138-22 char{1, 1}"]]
eNFA138_23_22776773[["εNFA138-23 char[1]"]]
eNFA138_24_3664366[["εNFA138-24 char{1, 1}"]]
eNFA138_25_32979301[["εNFA138-25 char[1]"]]
eNFA138_26_28378258[["εNFA138-26 char{1, 1}"]]
eNFA138_27_54077734[["εNFA138-27 char[1]"]]
eNFA138_28_16937562[["εNFA138-28 char{1, 1}"]]
eNFA138_29_18220335[["εNFA138-29 char[1]"]]
eNFA138_31_29765295[["εNFA138-31 regex end"]]
eNFA138_32_66561065[["εNFA138-32 post-regex start"]]
eNFA138_33_62178680[\"εNFA138-33 post-regex end"/]
eNFA138_30_4285383 -.->|"ε"|eNFA138_0_38568449
eNFA138_0_38568449 -->|"i"|eNFA138_1_11571729
eNFA138_1_11571729 -.->|"ε"|eNFA138_2_37036703
eNFA138_2_37036703 -->|"s"|eNFA138_3_64894876
eNFA138_3_64894876 -.->|"ε"|eNFA138_4_47182977
eNFA138_4_47182977 -->|"a"|eNFA138_5_21993616
eNFA138_5_21993616 -.->|"ε"|eNFA138_6_63724816
eNFA138_6_63724816 -->|"m"|eNFA138_7_36652435
eNFA138_7_36652435 -.->|"ε"|eNFA138_8_61436467
eNFA138_8_61436467 -->|"p"|eNFA138_9_16057296
eNFA138_9_16057296 -.->|"ε"|eNFA138_10_10297939
eNFA138_10_10297939 -->|"l"|eNFA138_11_25572589
eNFA138_11_25572589 -.->|"ε"|eNFA138_12_28826711
eNFA138_12_28826711 -->|"e"|eNFA138_13_58113810
eNFA138_13_58113810 -.->|"ε"|eNFA138_14_53262248
eNFA138_14_53262248 -->|"r"|eNFA138_15_9598184
eNFA138_15_9598184 -.->|"ε"|eNFA138_16_19274797
eNFA138_16_19274797 -->|"2"|eNFA138_17_39255446
eNFA138_17_39255446 -.->|"ε"|eNFA138_18_17754702
eNFA138_18_17754702 -->|"D"|eNFA138_19_25574597
eNFA138_19_25574597 -.->|"ε"|eNFA138_20_28844789
eNFA138_20_28844789 -->|"A"|eNFA138_21_58276509
eNFA138_21_58276509 -.->|"ε"|eNFA138_22_54726535
eNFA138_22_54726535 -->|"r"|eNFA138_23_22776773
eNFA138_23_22776773 -.->|"ε"|eNFA138_24_3664366
eNFA138_24_3664366 -->|"r"|eNFA138_25_32979301
eNFA138_25_32979301 -.->|"ε"|eNFA138_26_28378258
eNFA138_26_28378258 -->|"a"|eNFA138_27_54077734
eNFA138_27_54077734 -.->|"ε"|eNFA138_28_16937562
eNFA138_28_16937562 -->|"y"|eNFA138_29_18220335
eNFA138_29_18220335 -.->|"ε"|eNFA138_31_29765295
eNFA138_31_29765295 -.->|"ε"|eNFA138_32_66561065
eNFA138_32_66561065 -.->|"ε"|eNFA138_33_62178680
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
eNFA138_30_22737212[["εNFA138-30 regex start"]]
eNFA138_0_3308318[["εNFA138-0 char{1, 1}"]]
eNFA138_1_29774863[["εNFA138-1 char[1]"]]
eNFA138_2_66647176[["εNFA138-2 char{1, 1}"]]
eNFA138_3_62953674[["εNFA138-3 char[1]"]]
eNFA138_4_29712158[["εNFA138-4 char{1, 1}"]]
eNFA138_5_66082838[["εNFA138-5 char[1]"]]
eNFA138_6_57874634[["εNFA138-6 char{1, 1}"]]
eNFA138_7_51109658[["εNFA138-7 char[1]"]]
eNFA138_8_57333745[["εNFA138-8 char{1, 1}"]]
eNFA138_9_46241663[["εNFA138-9 char[1]"]]
eNFA138_10_13521789[["εNFA138-10 char{1, 1}"]]
eNFA138_11_54587245[["εNFA138-11 char[1]"]]
eNFA138_12_21523158[["εNFA138-12 char{1, 1}"]]
eNFA138_13_59490699[["εNFA138-13 char[1]"]]
eNFA138_14_65654243[["εNFA138-14 char{1, 1}"]]
eNFA138_15_54017281[["εNFA138-15 char[1]"]]
eNFA138_16_16393485[["εNFA138-16 char{1, 1}"]]
eNFA138_17_13323640[["εNFA138-17 char[1]"]]
eNFA138_18_52803899[["εNFA138-18 char{1, 1}"]]
eNFA138_19_5473047[["εNFA138-19 char[1]"]]
eNFA138_20_49257430[["εNFA138-20 char{1, 1}"]]
eNFA138_21_40663687[["εNFA138-21 char[1]"]]
eNFA138_22_30428869[["εNFA138-22 char{1, 1}"]]
eNFA138_23_5424368[["εNFA138-23 char[1]"]]
eNFA138_24_48819313[["εNFA138-24 char{1, 1}"]]
eNFA138_25_36720633[["εNFA138-25 char[1]"]]
eNFA138_26_62050241[["εNFA138-26 char{1, 1}"]]
eNFA138_27_21581258[["εNFA138-27 char[1]"]]
eNFA138_28_60013597[["εNFA138-28 char{1, 1}"]]
eNFA138_29_3251468[\"εNFA138-29 char[1]"/]
eNFA138_31_29263214[\"εNFA138-31 regex end"/]
eNFA138_32_62042342[\"εNFA138-32 post-regex start"/]
eNFA138_33_21510172[\"εNFA138-33 post-regex end"/]
eNFA138_30_22737212 -.->|"ε"|eNFA138_0_3308318
eNFA138_30_22737212 -->|"i"|eNFA138_1_29774863
eNFA138_0_3308318 -->|"i"|eNFA138_1_29774863
eNFA138_1_29774863 -.->|"ε"|eNFA138_2_66647176
eNFA138_1_29774863 -->|"s"|eNFA138_3_62953674
eNFA138_2_66647176 -->|"s"|eNFA138_3_62953674
eNFA138_3_62953674 -.->|"ε"|eNFA138_4_29712158
eNFA138_3_62953674 -->|"a"|eNFA138_5_66082838
eNFA138_4_29712158 -->|"a"|eNFA138_5_66082838
eNFA138_5_66082838 -.->|"ε"|eNFA138_6_57874634
eNFA138_5_66082838 -->|"m"|eNFA138_7_51109658
eNFA138_6_57874634 -->|"m"|eNFA138_7_51109658
eNFA138_7_51109658 -.->|"ε"|eNFA138_8_57333745
eNFA138_7_51109658 -->|"p"|eNFA138_9_46241663
eNFA138_8_57333745 -->|"p"|eNFA138_9_46241663
eNFA138_9_46241663 -.->|"ε"|eNFA138_10_13521789
eNFA138_9_46241663 -->|"l"|eNFA138_11_54587245
eNFA138_10_13521789 -->|"l"|eNFA138_11_54587245
eNFA138_11_54587245 -.->|"ε"|eNFA138_12_21523158
eNFA138_11_54587245 -->|"e"|eNFA138_13_59490699
eNFA138_12_21523158 -->|"e"|eNFA138_13_59490699
eNFA138_13_59490699 -.->|"ε"|eNFA138_14_65654243
eNFA138_13_59490699 -->|"r"|eNFA138_15_54017281
eNFA138_14_65654243 -->|"r"|eNFA138_15_54017281
eNFA138_15_54017281 -.->|"ε"|eNFA138_16_16393485
eNFA138_15_54017281 -->|"2"|eNFA138_17_13323640
eNFA138_16_16393485 -->|"2"|eNFA138_17_13323640
eNFA138_17_13323640 -.->|"ε"|eNFA138_18_52803899
eNFA138_17_13323640 -->|"D"|eNFA138_19_5473047
eNFA138_18_52803899 -->|"D"|eNFA138_19_5473047
eNFA138_19_5473047 -.->|"ε"|eNFA138_20_49257430
eNFA138_19_5473047 -->|"A"|eNFA138_21_40663687
eNFA138_20_49257430 -->|"A"|eNFA138_21_40663687
eNFA138_21_40663687 -.->|"ε"|eNFA138_22_30428869
eNFA138_21_40663687 -->|"r"|eNFA138_23_5424368
eNFA138_22_30428869 -->|"r"|eNFA138_23_5424368
eNFA138_23_5424368 -.->|"ε"|eNFA138_24_48819313
eNFA138_23_5424368 -->|"r"|eNFA138_25_36720633
eNFA138_24_48819313 -->|"r"|eNFA138_25_36720633
eNFA138_25_36720633 -.->|"ε"|eNFA138_26_62050241
eNFA138_25_36720633 -->|"a"|eNFA138_27_21581258
eNFA138_26_62050241 -->|"a"|eNFA138_27_21581258
eNFA138_27_21581258 -.->|"ε"|eNFA138_28_60013597
eNFA138_27_21581258 -->|"y"|eNFA138_29_3251468
eNFA138_28_60013597 -->|"y"|eNFA138_29_3251468
eNFA138_29_3251468 -.->|"ε"|eNFA138_31_29263214
eNFA138_29_3251468 -.->|"ε"|eNFA138_32_62042342
eNFA138_29_3251468 -.->|"ε"|eNFA138_33_21510172
eNFA138_31_29263214 -.->|"ε"|eNFA138_32_62042342
eNFA138_31_29263214 -.->|"ε"|eNFA138_33_21510172
eNFA138_32_62042342 -.->|"ε"|eNFA138_33_21510172
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
NFA138_30_59373825("NFA138-30 regex start")
NFA138_1_64602382("NFA138-1 char[1]")
NFA138_3_44550533("NFA138-3 char[1]")
NFA138_5_65410477("NFA138-5 char[1]")
NFA138_7_51823384("NFA138-7 char[1]")
NFA138_9_63757280("NFA138-9 char[1]")
NFA138_11_36944613("NFA138-11 char[1]")
NFA138_13_64066064("NFA138-13 char[1]")
NFA138_15_39723666("NFA138-15 char[1]")
NFA138_17_21968676("NFA138-17 char[1]")
NFA138_19_63500359("NFA138-19 char[1]")
NFA138_21_34632325("NFA138-21 char[1]")
NFA138_23_43255469("NFA138-23 char[1]")
NFA138_25_53754906("NFA138-25 char[1]")
NFA138_27_14032107("NFA138-27 char[1]")
NFA138_29_59180107[\"NFA138-29 char[1]"/]
NFA138_30_59373825 -->|"i"|NFA138_1_64602382
NFA138_1_64602382 -->|"s"|NFA138_3_44550533
NFA138_3_44550533 -->|"a"|NFA138_5_65410477
NFA138_5_65410477 -->|"m"|NFA138_7_51823384
NFA138_7_51823384 -->|"p"|NFA138_9_63757280
NFA138_9_63757280 -->|"l"|NFA138_11_36944613
NFA138_11_36944613 -->|"e"|NFA138_13_64066064
NFA138_13_64066064 -->|"r"|NFA138_15_39723666
NFA138_15_39723666 -->|"2"|NFA138_17_21968676
NFA138_17_21968676 -->|"D"|NFA138_19_63500359
NFA138_19_63500359 -->|"A"|NFA138_21_34632325
NFA138_21_34632325 -->|"r"|NFA138_23_43255469
NFA138_23_43255469 -->|"r"|NFA138_25_53754906
NFA138_25_53754906 -->|"a"|NFA138_27_14032107
NFA138_27_14032107 -->|"y"|NFA138_29_59180107
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
subgraph DFA0_1434646610["DFA0 regex start"]
NFA138_30_59373825_0("NFA138-30 regex start")
end
subgraph DFA1_-643320729["DFA1 {1}"]
NFA138_1_64602382_1("NFA138-1 char[1]")
end
subgraph DFA2_570350216["DFA2 {1}"]
NFA138_3_44550533_2("NFA138-3 char[1]")
end
subgraph DFA3_793186583["DFA3 {1}"]
NFA138_5_65410477_3("NFA138-5 char[1]")
end
subgraph DFA4_835487199["DFA4 {1}"]
NFA138_7_51823384_4("NFA138-7 char[1]")
end
subgraph DFA5_1153071296["DFA5 {1}"]
NFA138_9_63757280_5("NFA138-9 char[1]")
end
subgraph DFA6_-705054256["DFA6 {1}"]
NFA138_11_36944613_6("NFA138-11 char[1]")
end
subgraph DFA7_-461763720["DFA7 {1}"]
NFA138_13_64066064_7("NFA138-13 char[1]")
end
subgraph DFA8_-1929986284["DFA8 {1}"]
NFA138_15_39723666_8("NFA138-15 char[1]")
end
subgraph DFA9_537597623["DFA9 {1}"]
NFA138_17_21968676_9("NFA138-17 char[1]")
end
subgraph DFA10_-102466818["DFA10 {1}"]
NFA138_19_63500359_10("NFA138-19 char[1]")
end
subgraph DFA11_-531032153["DFA11 {1}"]
NFA138_21_34632325_11("NFA138-21 char[1]")
end
subgraph DFA12_-1715475936["DFA12 {1}"]
NFA138_23_43255469_12("NFA138-23 char[1]")
end
subgraph DFA13_199084786["DFA13 {1}"]
NFA138_25_53754906_13("NFA138-25 char[1]")
end
subgraph DFA14_1194196050["DFA14 {1}"]
NFA138_27_14032107_14("NFA138-27 char[1]")
end
subgraph DFA15_-1303535536["DFA15 {1}"]
NFA138_29_59180107_15[\"NFA138-29 char[1]"/]
end
DFA0_1434646610 -->|"i"|DFA1_-643320729
DFA1_-643320729 -->|"s"|DFA2_570350216
DFA2_570350216 -->|"a"|DFA3_793186583
DFA3_793186583 -->|"m"|DFA4_835487199
DFA4_835487199 -->|"p"|DFA5_1153071296
DFA5_1153071296 -->|"l"|DFA6_-705054256
DFA6_-705054256 -->|"e"|DFA7_-461763720
DFA7_-461763720 -->|"r"|DFA8_-1929986284
DFA8_-1929986284 -->|"2"|DFA9_537597623
DFA9_537597623 -->|"D"|DFA10_-102466818
DFA10_-102466818 -->|"A"|DFA11_-531032153
DFA11_-531032153 -->|"r"|DFA12_-1715475936
DFA12_-1715475936 -->|"r"|DFA13_199084786
DFA13_199084786 -->|"a"|DFA14_1194196050
DFA14_1194196050 -->|"y"|DFA15_-1303535536
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
DFA0_1434646610{{"DFA0 regex start"}}
DFA1_-643320729{{"DFA1 {1}"}}
DFA2_570350216{{"DFA2 {1}"}}
DFA3_793186583{{"DFA3 {1}"}}
DFA4_835487199{{"DFA4 {1}"}}
DFA5_1153071296{{"DFA5 {1}"}}
DFA6_-705054256{{"DFA6 {1}"}}
DFA7_-461763720{{"DFA7 {1}"}}
DFA8_-1929986284{{"DFA8 {1}"}}
DFA9_537597623{{"DFA9 {1}"}}
DFA10_-102466818{{"DFA10 {1}"}}
DFA11_-531032153{{"DFA11 {1}"}}
DFA12_-1715475936{{"DFA12 {1}"}}
DFA13_199084786{{"DFA13 {1}"}}
DFA14_1194196050{{"DFA14 {1}"}}
DFA15_-1303535536[\"DFA15 {1}"/]
DFA0_1434646610 -->|"i"|DFA1_-643320729
DFA1_-643320729 -->|"s"|DFA2_570350216
DFA2_570350216 -->|"a"|DFA3_793186583
DFA3_793186583 -->|"m"|DFA4_835487199
DFA4_835487199 -->|"p"|DFA5_1153071296
DFA5_1153071296 -->|"l"|DFA6_-705054256
DFA6_-705054256 -->|"e"|DFA7_-461763720
DFA7_-461763720 -->|"r"|DFA8_-1929986284
DFA8_-1929986284 -->|"2"|DFA9_537597623
DFA9_537597623 -->|"D"|DFA10_-102466818
DFA10_-102466818 -->|"A"|DFA11_-531032153
DFA11_-531032153 -->|"r"|DFA12_-1715475936
DFA12_-1715475936 -->|"r"|DFA13_199084786
DFA13_199084786 -->|"a"|DFA14_1194196050
DFA14_1194196050 -->|"y"|DFA15_-1303535536
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
subgraph MiniDFA0_-98593541["MiniDFA0 {1}"]
DFA0_1434646610_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-370545221["MiniDFA1 {1}"]
DFA1_-643320729_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1627173706["MiniDFA2 {1}"]
DFA2_570350216_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_264583778["MiniDFA4 {1}"]
DFA3_793186583_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_398710481["MiniDFA5 {1}"]
DFA4_835487199_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_757366929["MiniDFA6 {1}"]
DFA5_1153071296_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1620754717["MiniDFA7 {1}"]
DFA6_-705054256_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1368580927["MiniDFA8 {1}"]
DFA7_-461763720_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_752464675["MiniDFA11 {1}"]
DFA8_-1929986284_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_-2116963346["MiniDFA12 {1}"]
DFA9_537597623_9{{"DFA9 {1}"}}
end
subgraph MiniDFA13_-784029402["MiniDFA13 {1}"]
DFA10_-102466818_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_-108797213["MiniDFA9 {1}"]
DFA11_-531032153_11{{"DFA11 {1}"}}
end
subgraph MiniDFA10_110159441["MiniDFA10 {1}"]
DFA12_-1715475936_12{{"DFA12 {1}"}}
end
subgraph MiniDFA3_1137500358["MiniDFA3 {1}"]
DFA13_199084786_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_384432184["MiniDFA14 {1}"]
DFA14_1194196050_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_-216854586["MiniDFA15 {1}"]
DFA15_-1303535536_15[\"DFA15 {1}"/]
end
MiniDFA0_-98593541 -->|"i"|MiniDFA1_-370545221
MiniDFA1_-370545221 -->|"s"|MiniDFA2_1627173706
MiniDFA2_1627173706 -->|"a"|MiniDFA4_264583778
MiniDFA4_264583778 -->|"m"|MiniDFA5_398710481
MiniDFA5_398710481 -->|"p"|MiniDFA6_757366929
MiniDFA6_757366929 -->|"l"|MiniDFA7_1620754717
MiniDFA7_1620754717 -->|"e"|MiniDFA8_1368580927
MiniDFA8_1368580927 -->|"r"|MiniDFA11_752464675
MiniDFA11_752464675 -->|"2"|MiniDFA12_-2116963346
MiniDFA12_-2116963346 -->|"D"|MiniDFA13_-784029402
MiniDFA13_-784029402 -->|"A"|MiniDFA9_-108797213
MiniDFA9_-108797213 -->|"r"|MiniDFA10_110159441
MiniDFA10_110159441 -->|"r"|MiniDFA3_1137500358
MiniDFA3_1137500358 -->|"a"|MiniDFA14_384432184
MiniDFA14_384432184 -->|"y"|MiniDFA15_-216854586
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
MiniDFA0_-98593541(["MiniDFA0 {1}"])
MiniDFA1_-370545221(["MiniDFA1 {1}"])
MiniDFA2_1627173706(["MiniDFA2 {1}"])
MiniDFA4_264583778(["MiniDFA4 {1}"])
MiniDFA5_398710481(["MiniDFA5 {1}"])
MiniDFA6_757366929(["MiniDFA6 {1}"])
MiniDFA7_1620754717(["MiniDFA7 {1}"])
MiniDFA8_1368580927(["MiniDFA8 {1}"])
MiniDFA11_752464675(["MiniDFA11 {1}"])
MiniDFA12_-2116963346(["MiniDFA12 {1}"])
MiniDFA13_-784029402(["MiniDFA13 {1}"])
MiniDFA9_-108797213(["MiniDFA9 {1}"])
MiniDFA10_110159441(["MiniDFA10 {1}"])
MiniDFA3_1137500358(["MiniDFA3 {1}"])
MiniDFA14_384432184(["MiniDFA14 {1}"])
MiniDFA15_-216854586[\"MiniDFA15 {1}"/]
MiniDFA0_-98593541 -->|"i"|MiniDFA1_-370545221
MiniDFA1_-370545221 -->|"s"|MiniDFA2_1627173706
MiniDFA2_1627173706 -->|"a"|MiniDFA4_264583778
MiniDFA4_264583778 -->|"m"|MiniDFA5_398710481
MiniDFA5_398710481 -->|"p"|MiniDFA6_757366929
MiniDFA6_757366929 -->|"l"|MiniDFA7_1620754717
MiniDFA7_1620754717 -->|"e"|MiniDFA8_1368580927
MiniDFA8_1368580927 -->|"r"|MiniDFA11_752464675
MiniDFA11_752464675 -->|"2"|MiniDFA12_-2116963346
MiniDFA12_-2116963346 -->|"D"|MiniDFA13_-784029402
MiniDFA13_-784029402 -->|"A"|MiniDFA9_-108797213
MiniDFA9_-108797213 -->|"r"|MiniDFA10_110159441
MiniDFA10_110159441 -->|"r"|MiniDFA3_1137500358
MiniDFA3_1137500358 -->|"a"|MiniDFA14_384432184
MiniDFA14_384432184 -->|"y"|MiniDFA15_-216854586
```
-------------------------------
