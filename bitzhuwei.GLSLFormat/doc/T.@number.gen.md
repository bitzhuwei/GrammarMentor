# 'number'

pattern: `[-+]?[0-9]+([.][0-9]+)?([Ee][-+]?[0-9]+)?`

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
eNFA2_18_36246974[["εNFA2-18 regex start"]]
eNFA2_0_13080057[["εNFA2-0 scope{0, 1}"]]
eNFA2_1_50611656[["εNFA2-1 scope[1]"]]
eNFA2_2_5903470[["εNFA2-2 scope{1, ∞}"]]
eNFA2_3_52851724[["εNFA2-3 scope[1]"]]
eNFA2_8_53131231[["εNFA2-8 regex start"]]
eNFA2_4_8662426[["εNFA2-4 scope{1, 1}"]]
eNFA2_9_8419032[["εNFA2-9 regex end"]]
eNFA2_5_51294256[["εNFA2-5 scope[1]"]]
eNFA2_16_10852974[["εNFA2-16 regex start"]]
eNFA2_6_34774863[["εNFA2-6 scope{1, ∞}"]]
eNFA2_10_6675738[["εNFA2-10 scope{1, 1}"]]
eNFA2_17_30567910[["εNFA2-17 regex end"]]
eNFA2_7_3863873[["εNFA2-7 scope[1]"]]
eNFA2_11_57773428[["εNFA2-11 scope[1]"]]
eNFA2_19_50198807[["εNFA2-19 regex end"]]
eNFA2_9_44538317[["εNFA2-9 regex end"]]
eNFA2_12_65300541[["εNFA2-12 scope{0, 1}"]]
eNFA2_20_51181499[["εNFA2-20 post-regex start"]]
eNFA2_8_54852443[["εNFA2-8 regex start"]]
eNFA2_13_50833958[["εNFA2-13 scope[1]"]]
eNFA2_21_65893970[\"εNFA2-21 post-regex end"/]
eNFA2_4_23909939[["εNFA2-4 scope{1, 1}"]]
eNFA2_14_49150280[["εNFA2-14 scope{1, ∞}"]]
eNFA2_5_53866394[["εNFA2-5 scope[1]"]]
eNFA2_15_57656925[["εNFA2-15 scope[1]"]]
eNFA2_6_61529894[["εNFA2-6 scope{1, ∞}"]]
eNFA2_17_39699339[["εNFA2-17 regex end"]]
eNFA2_7_21749735[["εNFA2-7 scope[1]"]]
eNFA2_16_16898135[["εNFA2-16 regex start"]]
eNFA2_10_17865493[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_1237054[["εNFA2-11 scope[1]"]]
eNFA2_12_37818817[["εNFA2-12 scope{0, 1}"]]
eNFA2_13_4825033[["εNFA2-13 scope[1]"]]
eNFA2_14_55283354[["εNFA2-14 scope{1, ∞}"]]
eNFA2_15_43425297[["εNFA2-15 scope[1]"]]
eNFA2_18_36246974 -.->|"ε"|eNFA2_0_13080057
eNFA2_0_13080057 -->|"[-+]"|eNFA2_1_50611656
eNFA2_0_13080057 -.->|"ε"|eNFA2_1_50611656
eNFA2_1_50611656 -.->|"ε"|eNFA2_2_5903470
eNFA2_2_5903470 -->|"[0-9]"|eNFA2_3_52851724
eNFA2_3_52851724 -->|"[0-9]"|eNFA2_3_52851724
eNFA2_3_52851724 -.->|"ε"|eNFA2_8_53131231
eNFA2_8_53131231 -.->|"ε"|eNFA2_4_8662426
eNFA2_8_53131231 -.->|"ε"|eNFA2_9_8419032
eNFA2_4_8662426 -->|"[.]"|eNFA2_5_51294256
eNFA2_9_8419032 -.->|"ε"|eNFA2_16_10852974
eNFA2_5_51294256 -.->|"ε"|eNFA2_6_34774863
eNFA2_16_10852974 -.->|"ε"|eNFA2_10_6675738
eNFA2_16_10852974 -.->|"ε"|eNFA2_17_30567910
eNFA2_6_34774863 -->|"[0-9]"|eNFA2_7_3863873
eNFA2_10_6675738 -->|"[Ee]"|eNFA2_11_57773428
eNFA2_17_30567910 -.->|"ε"|eNFA2_19_50198807
eNFA2_7_3863873 -->|"[0-9]"|eNFA2_7_3863873
eNFA2_7_3863873 -.->|"ε"|eNFA2_9_44538317
eNFA2_11_57773428 -.->|"ε"|eNFA2_12_65300541
eNFA2_19_50198807 -.->|"ε"|eNFA2_20_51181499
eNFA2_9_44538317 -.->|"ε"|eNFA2_8_54852443
eNFA2_12_65300541 -->|"[-+]"|eNFA2_13_50833958
eNFA2_12_65300541 -.->|"ε"|eNFA2_13_50833958
eNFA2_20_51181499 -.->|"ε"|eNFA2_21_65893970
eNFA2_8_54852443 -.->|"ε"|eNFA2_4_23909939
eNFA2_8_54852443 -.->|"ε"|eNFA2_9_8419032
eNFA2_13_50833958 -.->|"ε"|eNFA2_14_49150280
eNFA2_4_23909939 -->|"[.]"|eNFA2_5_53866394
eNFA2_14_49150280 -->|"[0-9]"|eNFA2_15_57656925
eNFA2_5_53866394 -.->|"ε"|eNFA2_6_61529894
eNFA2_15_57656925 -->|"[0-9]"|eNFA2_15_57656925
eNFA2_15_57656925 -.->|"ε"|eNFA2_17_39699339
eNFA2_6_61529894 -->|"[0-9]"|eNFA2_7_21749735
eNFA2_17_39699339 -.->|"ε"|eNFA2_16_16898135
eNFA2_7_21749735 -->|"[0-9]"|eNFA2_7_21749735
eNFA2_7_21749735 -.->|"ε"|eNFA2_9_8419032
eNFA2_16_16898135 -.->|"ε"|eNFA2_10_17865493
eNFA2_16_16898135 -.->|"ε"|eNFA2_17_30567910
eNFA2_10_17865493 -->|"[Ee]"|eNFA2_11_1237054
eNFA2_11_1237054 -.->|"ε"|eNFA2_12_37818817
eNFA2_12_37818817 -->|"[-+]"|eNFA2_13_4825033
eNFA2_12_37818817 -.->|"ε"|eNFA2_13_4825033
eNFA2_13_4825033 -.->|"ε"|eNFA2_14_55283354
eNFA2_14_55283354 -->|"[0-9]"|eNFA2_15_43425297
eNFA2_15_43425297 -->|"[0-9]"|eNFA2_15_43425297
eNFA2_15_43425297 -.->|"ε"|eNFA2_17_30567910
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
eNFA2_18_32406629[["εNFA2-18 regex start"]]
eNFA2_0_57787318[["εNFA2-0 scope{0, 1}"]]
eNFA2_1_50323820[["εNFA2-1 scope[1]"]]
eNFA2_2_49697630[["εNFA2-2 scope{1, ∞}"]]
eNFA2_3_50261201[\"εNFA2-3 scope[1]"/]
eNFA2_8_44625493[\"εNFA2-8 regex start"/]
eNFA2_4_57895144[\"εNFA2-4 scope{1, 1}"/]
eNFA2_9_66085117[\"εNFA2-9 regex end"/]
eNFA2_5_23224207[["εNFA2-5 scope[1]"]]
eNFA2_16_58995125[\"εNFA2-16 regex start"/]
eNFA2_10_13875810[\"εNFA2-10 scope{1, 1}"/]
eNFA2_17_61194080[\"εNFA2-17 regex end"/]
eNFA2_11_2112619[["εNFA2-11 scope[1]"]]
eNFA2_19_7691275[\"εNFA2-19 regex end"/]
eNFA2_20_19013575[\"εNFA2-20 post-regex start"/]
eNFA2_21_36904447[\"εNFA2-21 post-regex end"/]
eNFA2_6_39571581[["εNFA2-6 scope{1, ∞}"]]
eNFA2_7_49136085[\"εNFA2-7 scope[1]"/]
eNFA2_12_57980315[["εNFA2-12 scope{0, 1}"]]
eNFA2_13_52060794[["εNFA2-13 scope[1]"]]
eNFA2_14_1101770[["εNFA2-14 scope{1, ∞}"]]
eNFA2_15_15035499[\"εNFA2-15 scope[1]"/]
eNFA2_9_20599914[\"εNFA2-9 regex end"/]
eNFA2_8_56174818[\"εNFA2-8 regex start"/]
eNFA2_4_35811316[\"εNFA2-4 scope{1, 1}"/]
eNFA2_5_63704574[["εNFA2-5 scope[1]"]]
eNFA2_17_9915935[\"εNFA2-17 regex end"/]
eNFA2_16_48068532[\"εNFA2-16 regex start"/]
eNFA2_10_29963612[\"εNFA2-10 scope{1, 1}"/]
eNFA2_11_36470260[["εNFA2-11 scope[1]"]]
eNFA2_6_64993271[["εNFA2-6 scope{1, ∞}"]]
eNFA2_7_22134555[\"εNFA2-7 scope[1]"/]
eNFA2_12_11133493[["εNFA2-12 scope{0, 1}"]]
eNFA2_13_33092577[["εNFA2-13 scope[1]"]]
eNFA2_14_63253060[["εNFA2-14 scope{1, ∞}"]]
eNFA2_15_29397739[\"εNFA2-15 scope[1]"/]
eNFA2_18_32406629 -.->|"ε"|eNFA2_0_57787318
eNFA2_18_32406629 -->|"[-+]"|eNFA2_1_50323820
eNFA2_18_32406629 -.->|"ε"|eNFA2_1_50323820
eNFA2_18_32406629 -.->|"ε"|eNFA2_2_49697630
eNFA2_18_32406629 -->|"[0-9]"|eNFA2_3_50261201
eNFA2_0_57787318 -->|"[-+]"|eNFA2_1_50323820
eNFA2_0_57787318 -.->|"ε"|eNFA2_1_50323820
eNFA2_0_57787318 -.->|"ε"|eNFA2_2_49697630
eNFA2_0_57787318 -->|"[0-9]"|eNFA2_3_50261201
eNFA2_1_50323820 -.->|"ε"|eNFA2_2_49697630
eNFA2_1_50323820 -->|"[0-9]"|eNFA2_3_50261201
eNFA2_2_49697630 -->|"[0-9]"|eNFA2_3_50261201
eNFA2_3_50261201 -->|"[0-9]"|eNFA2_3_50261201
eNFA2_3_50261201 -.->|"ε"|eNFA2_8_44625493
eNFA2_3_50261201 -.->|"ε"|eNFA2_4_57895144
eNFA2_3_50261201 -.->|"ε"|eNFA2_9_66085117
eNFA2_3_50261201 -->|"[.]"|eNFA2_5_23224207
eNFA2_3_50261201 -.->|"ε"|eNFA2_16_58995125
eNFA2_3_50261201 -.->|"ε"|eNFA2_10_13875810
eNFA2_3_50261201 -.->|"ε"|eNFA2_17_61194080
eNFA2_3_50261201 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_3_50261201 -.->|"ε"|eNFA2_19_7691275
eNFA2_3_50261201 -.->|"ε"|eNFA2_20_19013575
eNFA2_3_50261201 -.->|"ε"|eNFA2_21_36904447
eNFA2_8_44625493 -.->|"ε"|eNFA2_4_57895144
eNFA2_8_44625493 -.->|"ε"|eNFA2_9_66085117
eNFA2_8_44625493 -->|"[.]"|eNFA2_5_23224207
eNFA2_8_44625493 -.->|"ε"|eNFA2_16_58995125
eNFA2_8_44625493 -.->|"ε"|eNFA2_10_13875810
eNFA2_8_44625493 -.->|"ε"|eNFA2_17_61194080
eNFA2_8_44625493 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_8_44625493 -.->|"ε"|eNFA2_19_7691275
eNFA2_8_44625493 -.->|"ε"|eNFA2_20_19013575
eNFA2_8_44625493 -.->|"ε"|eNFA2_21_36904447
eNFA2_4_57895144 -->|"[.]"|eNFA2_5_23224207
eNFA2_9_66085117 -.->|"ε"|eNFA2_16_58995125
eNFA2_9_66085117 -.->|"ε"|eNFA2_10_13875810
eNFA2_9_66085117 -.->|"ε"|eNFA2_17_61194080
eNFA2_9_66085117 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_9_66085117 -.->|"ε"|eNFA2_19_7691275
eNFA2_9_66085117 -.->|"ε"|eNFA2_20_19013575
eNFA2_9_66085117 -.->|"ε"|eNFA2_21_36904447
eNFA2_5_23224207 -.->|"ε"|eNFA2_6_39571581
eNFA2_5_23224207 -->|"[0-9]"|eNFA2_7_49136085
eNFA2_16_58995125 -.->|"ε"|eNFA2_10_13875810
eNFA2_16_58995125 -.->|"ε"|eNFA2_17_61194080
eNFA2_16_58995125 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_16_58995125 -.->|"ε"|eNFA2_19_7691275
eNFA2_16_58995125 -.->|"ε"|eNFA2_20_19013575
eNFA2_16_58995125 -.->|"ε"|eNFA2_21_36904447
eNFA2_10_13875810 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_17_61194080 -.->|"ε"|eNFA2_19_7691275
eNFA2_17_61194080 -.->|"ε"|eNFA2_20_19013575
eNFA2_17_61194080 -.->|"ε"|eNFA2_21_36904447
eNFA2_11_2112619 -.->|"ε"|eNFA2_12_57980315
eNFA2_11_2112619 -->|"[-+]"|eNFA2_13_52060794
eNFA2_11_2112619 -.->|"ε"|eNFA2_13_52060794
eNFA2_11_2112619 -.->|"ε"|eNFA2_14_1101770
eNFA2_11_2112619 -->|"[0-9]"|eNFA2_15_15035499
eNFA2_19_7691275 -.->|"ε"|eNFA2_20_19013575
eNFA2_19_7691275 -.->|"ε"|eNFA2_21_36904447
eNFA2_20_19013575 -.->|"ε"|eNFA2_21_36904447
eNFA2_6_39571581 -->|"[0-9]"|eNFA2_7_49136085
eNFA2_7_49136085 -->|"[0-9]"|eNFA2_7_49136085
eNFA2_7_49136085 -.->|"ε"|eNFA2_9_20599914
eNFA2_7_49136085 -.->|"ε"|eNFA2_8_56174818
eNFA2_7_49136085 -.->|"ε"|eNFA2_4_35811316
eNFA2_7_49136085 -.->|"ε"|eNFA2_9_66085117
eNFA2_7_49136085 -->|"[.]"|eNFA2_5_63704574
eNFA2_7_49136085 -.->|"ε"|eNFA2_16_58995125
eNFA2_7_49136085 -.->|"ε"|eNFA2_10_13875810
eNFA2_7_49136085 -.->|"ε"|eNFA2_17_61194080
eNFA2_7_49136085 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_7_49136085 -.->|"ε"|eNFA2_19_7691275
eNFA2_7_49136085 -.->|"ε"|eNFA2_20_19013575
eNFA2_7_49136085 -.->|"ε"|eNFA2_21_36904447
eNFA2_12_57980315 -->|"[-+]"|eNFA2_13_52060794
eNFA2_12_57980315 -.->|"ε"|eNFA2_13_52060794
eNFA2_12_57980315 -.->|"ε"|eNFA2_14_1101770
eNFA2_12_57980315 -->|"[0-9]"|eNFA2_15_15035499
eNFA2_13_52060794 -.->|"ε"|eNFA2_14_1101770
eNFA2_13_52060794 -->|"[0-9]"|eNFA2_15_15035499
eNFA2_14_1101770 -->|"[0-9]"|eNFA2_15_15035499
eNFA2_15_15035499 -->|"[0-9]"|eNFA2_15_15035499
eNFA2_15_15035499 -.->|"ε"|eNFA2_17_9915935
eNFA2_15_15035499 -.->|"ε"|eNFA2_16_48068532
eNFA2_15_15035499 -.->|"ε"|eNFA2_10_29963612
eNFA2_15_15035499 -.->|"ε"|eNFA2_17_61194080
eNFA2_15_15035499 -->|"[Ee]"|eNFA2_11_36470260
eNFA2_15_15035499 -.->|"ε"|eNFA2_19_7691275
eNFA2_15_15035499 -.->|"ε"|eNFA2_20_19013575
eNFA2_15_15035499 -.->|"ε"|eNFA2_21_36904447
eNFA2_9_20599914 -.->|"ε"|eNFA2_8_56174818
eNFA2_9_20599914 -.->|"ε"|eNFA2_4_35811316
eNFA2_9_20599914 -.->|"ε"|eNFA2_9_66085117
eNFA2_9_20599914 -->|"[.]"|eNFA2_5_63704574
eNFA2_9_20599914 -.->|"ε"|eNFA2_16_58995125
eNFA2_9_20599914 -.->|"ε"|eNFA2_10_13875810
eNFA2_9_20599914 -.->|"ε"|eNFA2_17_61194080
eNFA2_9_20599914 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_9_20599914 -.->|"ε"|eNFA2_19_7691275
eNFA2_9_20599914 -.->|"ε"|eNFA2_20_19013575
eNFA2_9_20599914 -.->|"ε"|eNFA2_21_36904447
eNFA2_8_56174818 -.->|"ε"|eNFA2_4_35811316
eNFA2_8_56174818 -.->|"ε"|eNFA2_9_66085117
eNFA2_8_56174818 -->|"[.]"|eNFA2_5_63704574
eNFA2_8_56174818 -.->|"ε"|eNFA2_16_58995125
eNFA2_8_56174818 -.->|"ε"|eNFA2_10_13875810
eNFA2_8_56174818 -.->|"ε"|eNFA2_17_61194080
eNFA2_8_56174818 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_8_56174818 -.->|"ε"|eNFA2_19_7691275
eNFA2_8_56174818 -.->|"ε"|eNFA2_20_19013575
eNFA2_8_56174818 -.->|"ε"|eNFA2_21_36904447
eNFA2_4_35811316 -->|"[.]"|eNFA2_5_63704574
eNFA2_5_63704574 -.->|"ε"|eNFA2_6_64993271
eNFA2_5_63704574 -->|"[0-9]"|eNFA2_7_22134555
eNFA2_17_9915935 -.->|"ε"|eNFA2_16_48068532
eNFA2_17_9915935 -.->|"ε"|eNFA2_10_29963612
eNFA2_17_9915935 -.->|"ε"|eNFA2_17_61194080
eNFA2_17_9915935 -->|"[Ee]"|eNFA2_11_36470260
eNFA2_17_9915935 -.->|"ε"|eNFA2_19_7691275
eNFA2_17_9915935 -.->|"ε"|eNFA2_20_19013575
eNFA2_17_9915935 -.->|"ε"|eNFA2_21_36904447
eNFA2_16_48068532 -.->|"ε"|eNFA2_10_29963612
eNFA2_16_48068532 -.->|"ε"|eNFA2_17_61194080
eNFA2_16_48068532 -->|"[Ee]"|eNFA2_11_36470260
eNFA2_16_48068532 -.->|"ε"|eNFA2_19_7691275
eNFA2_16_48068532 -.->|"ε"|eNFA2_20_19013575
eNFA2_16_48068532 -.->|"ε"|eNFA2_21_36904447
eNFA2_10_29963612 -->|"[Ee]"|eNFA2_11_36470260
eNFA2_11_36470260 -.->|"ε"|eNFA2_12_11133493
eNFA2_11_36470260 -->|"[-+]"|eNFA2_13_33092577
eNFA2_11_36470260 -.->|"ε"|eNFA2_13_33092577
eNFA2_11_36470260 -.->|"ε"|eNFA2_14_63253060
eNFA2_11_36470260 -->|"[0-9]"|eNFA2_15_29397739
eNFA2_6_64993271 -->|"[0-9]"|eNFA2_7_22134555
eNFA2_7_22134555 -->|"[0-9]"|eNFA2_7_22134555
eNFA2_7_22134555 -.->|"ε"|eNFA2_9_66085117
eNFA2_7_22134555 -.->|"ε"|eNFA2_16_58995125
eNFA2_7_22134555 -.->|"ε"|eNFA2_10_13875810
eNFA2_7_22134555 -.->|"ε"|eNFA2_17_61194080
eNFA2_7_22134555 -->|"[Ee]"|eNFA2_11_2112619
eNFA2_7_22134555 -.->|"ε"|eNFA2_19_7691275
eNFA2_7_22134555 -.->|"ε"|eNFA2_20_19013575
eNFA2_7_22134555 -.->|"ε"|eNFA2_21_36904447
eNFA2_12_11133493 -->|"[-+]"|eNFA2_13_33092577
eNFA2_12_11133493 -.->|"ε"|eNFA2_13_33092577
eNFA2_12_11133493 -.->|"ε"|eNFA2_14_63253060
eNFA2_12_11133493 -->|"[0-9]"|eNFA2_15_29397739
eNFA2_13_33092577 -.->|"ε"|eNFA2_14_63253060
eNFA2_13_33092577 -->|"[0-9]"|eNFA2_15_29397739
eNFA2_14_63253060 -->|"[0-9]"|eNFA2_15_29397739
eNFA2_15_29397739 -->|"[0-9]"|eNFA2_15_29397739
eNFA2_15_29397739 -.->|"ε"|eNFA2_17_61194080
eNFA2_15_29397739 -.->|"ε"|eNFA2_19_7691275
eNFA2_15_29397739 -.->|"ε"|eNFA2_20_19013575
eNFA2_15_29397739 -.->|"ε"|eNFA2_21_36904447
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
NFA2_18_59796890("NFA2-18 regex start")
NFA2_1_11709955("NFA2-1 scope[1]")
NFA2_3_1301106[\"NFA2-3 scope[1]"/]
NFA2_5_38280736("NFA2-5 scope[1]")
NFA2_11_8982304("NFA2-11 scope[1]")
NFA2_7_38540333[\"NFA2-7 scope[1]"/]
NFA2_13_56478042("NFA2-13 scope[1]")
NFA2_15_13731878[\"NFA2-15 scope[1]"/]
NFA2_5_11318680("NFA2-5 scope[1]")
NFA2_11_34759260("NFA2-11 scope[1]")
NFA2_7_39459394[\"NFA2-7 scope[1]"/]
NFA2_13_64036700("NFA2-13 scope[1]")
NFA2_15_44397891[\"NFA2-15 scope[1]"/]
NFA2_18_59796890 -->|"[-+]"|NFA2_1_11709955
NFA2_18_59796890 -->|"[0-9]"|NFA2_3_1301106
NFA2_1_11709955 -->|"[0-9]"|NFA2_3_1301106
NFA2_3_1301106 -->|"[0-9]"|NFA2_3_1301106
NFA2_3_1301106 -->|"[.]"|NFA2_5_38280736
NFA2_3_1301106 -->|"[Ee]"|NFA2_11_8982304
NFA2_5_38280736 -->|"[0-9]"|NFA2_7_38540333
NFA2_11_8982304 -->|"[-+]"|NFA2_13_56478042
NFA2_11_8982304 -->|"[0-9]"|NFA2_15_13731878
NFA2_7_38540333 -->|"[0-9]"|NFA2_7_38540333
NFA2_7_38540333 -->|"[.]"|NFA2_5_11318680
NFA2_7_38540333 -->|"[Ee]"|NFA2_11_8982304
NFA2_13_56478042 -->|"[0-9]"|NFA2_15_13731878
NFA2_15_13731878 -->|"[0-9]"|NFA2_15_13731878
NFA2_15_13731878 -->|"[Ee]"|NFA2_11_34759260
NFA2_5_11318680 -->|"[0-9]"|NFA2_7_39459394
NFA2_11_34759260 -->|"[-+]"|NFA2_13_64036700
NFA2_11_34759260 -->|"[0-9]"|NFA2_15_44397891
NFA2_7_39459394 -->|"[0-9]"|NFA2_7_39459394
NFA2_7_39459394 -->|"[Ee]"|NFA2_11_8982304
NFA2_13_64036700 -->|"[0-9]"|NFA2_15_44397891
NFA2_15_44397891 -->|"[0-9]"|NFA2_15_44397891
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
subgraph DFA0_854297462["DFA0 regex start"]
NFA2_18_59796890_0("NFA2-18 regex start")
end
subgraph DFA1_-1242619327["DFA1 {1}"]
NFA2_1_11709955_1("NFA2-1 scope[1]")
end
subgraph DFA2_872977453["DFA2 {1}"]
NFA2_3_1301106_2[\"NFA2-3 scope[1]"/]
end
subgraph DFA3_796161625["DFA3 {1}"]
NFA2_5_38280736_3("NFA2-5 scope[1]")
end
subgraph DFA4_1560076770["DFA4 {1}"]
NFA2_11_8982304_4("NFA2-11 scope[1]")
end
subgraph DFA5_-1726250775["DFA5 {1}"]
NFA2_7_38540333_5[\"NFA2-7 scope[1]"/]
end
subgraph DFA6_-1843190077["DFA6 {1}"]
NFA2_13_56478042_6("NFA2-13 scope[1]")
end
subgraph DFA7_1626823071["DFA7 {1}"]
NFA2_15_13731878_7[\"NFA2-15 scope[1]"/]
end
subgraph DFA8_-955626574["DFA8 {1}"]
NFA2_5_11318680_8("NFA2-5 scope[1]")
end
subgraph DFA9_876036821["DFA9 {1}"]
NFA2_11_34759260_9("NFA2-11 scope[1]")
end
subgraph DFA10_-2088593982["DFA10 {1}"]
NFA2_7_39459394_10[\"NFA2-7 scope[1]"/]
end
subgraph DFA11_1584283167["DFA11 {1}"]
NFA2_13_64036700_11("NFA2-13 scope[1]")
end
subgraph DFA12_-293359031["DFA12 {1}"]
NFA2_15_44397891_12[\"NFA2-15 scope[1]"/]
end
DFA0_854297462 -->|"[-+]"|DFA1_-1242619327
DFA0_854297462 -->|"[0-9]"|DFA2_872977453
DFA1_-1242619327 -->|"[0-9]"|DFA2_872977453
DFA2_872977453 -->|"[0-9]"|DFA2_872977453
DFA2_872977453 -->|"[.]"|DFA3_796161625
DFA2_872977453 -->|"[Ee]"|DFA4_1560076770
DFA3_796161625 -->|"[0-9]"|DFA5_-1726250775
DFA4_1560076770 -->|"[-+]"|DFA6_-1843190077
DFA4_1560076770 -->|"[0-9]"|DFA7_1626823071
DFA5_-1726250775 -->|"[0-9]"|DFA5_-1726250775
DFA5_-1726250775 -->|"[.]"|DFA8_-955626574
DFA5_-1726250775 -->|"[Ee]"|DFA4_1560076770
DFA6_-1843190077 -->|"[0-9]"|DFA7_1626823071
DFA7_1626823071 -->|"[0-9]"|DFA7_1626823071
DFA7_1626823071 -->|"[Ee]"|DFA9_876036821
DFA8_-955626574 -->|"[0-9]"|DFA10_-2088593982
DFA9_876036821 -->|"[-+]"|DFA11_1584283167
DFA9_876036821 -->|"[0-9]"|DFA12_-293359031
DFA10_-2088593982 -->|"[0-9]"|DFA10_-2088593982
DFA10_-2088593982 -->|"[Ee]"|DFA4_1560076770
DFA11_1584283167 -->|"[0-9]"|DFA12_-293359031
DFA12_-293359031 -->|"[0-9]"|DFA12_-293359031
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
DFA0_854297462{{"DFA0 regex start"}}
DFA1_-1242619327{{"DFA1 {1}"}}
DFA2_872977453[\"DFA2 {1}"/]
DFA3_796161625{{"DFA3 {1}"}}
DFA4_1560076770{{"DFA4 {1}"}}
DFA5_-1726250775[\"DFA5 {1}"/]
DFA6_-1843190077{{"DFA6 {1}"}}
DFA7_1626823071[\"DFA7 {1}"/]
DFA8_-955626574{{"DFA8 {1}"}}
DFA9_876036821{{"DFA9 {1}"}}
DFA10_-2088593982[\"DFA10 {1}"/]
DFA11_1584283167{{"DFA11 {1}"}}
DFA12_-293359031[\"DFA12 {1}"/]
DFA0_854297462 -->|"[-+]"|DFA1_-1242619327
DFA0_854297462 -->|"[0-9]"|DFA2_872977453
DFA1_-1242619327 -->|"[0-9]"|DFA2_872977453
DFA2_872977453 -->|"[0-9]"|DFA2_872977453
DFA2_872977453 -->|"[.]"|DFA3_796161625
DFA2_872977453 -->|"[Ee]"|DFA4_1560076770
DFA3_796161625 -->|"[0-9]"|DFA5_-1726250775
DFA4_1560076770 -->|"[-+]"|DFA6_-1843190077
DFA4_1560076770 -->|"[0-9]"|DFA7_1626823071
DFA5_-1726250775 -->|"[0-9]"|DFA5_-1726250775
DFA5_-1726250775 -->|"[.]"|DFA8_-955626574
DFA5_-1726250775 -->|"[Ee]"|DFA4_1560076770
DFA6_-1843190077 -->|"[0-9]"|DFA7_1626823071
DFA7_1626823071 -->|"[0-9]"|DFA7_1626823071
DFA7_1626823071 -->|"[Ee]"|DFA9_876036821
DFA8_-955626574 -->|"[0-9]"|DFA10_-2088593982
DFA9_876036821 -->|"[-+]"|DFA11_1584283167
DFA9_876036821 -->|"[0-9]"|DFA12_-293359031
DFA10_-2088593982 -->|"[0-9]"|DFA10_-2088593982
DFA10_-2088593982 -->|"[Ee]"|DFA4_1560076770
DFA11_1584283167 -->|"[0-9]"|DFA12_-293359031
DFA12_-293359031 -->|"[0-9]"|DFA12_-293359031
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
subgraph MiniDFA0_1546011132["MiniDFA0 {1}"]
DFA0_854297462_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1296468508["MiniDFA1 {1}"]
DFA1_-1242619327_1{{"DFA1 {1}"}}
end
subgraph MiniDFA8_1226626491["MiniDFA8 {1}"]
DFA2_872977453_2[\"DFA2 {1}"/]
end
subgraph MiniDFA2_-495176242["MiniDFA2 {1}"]
DFA3_796161625_3{{"DFA3 {1}"}}
end
subgraph MiniDFA3_-1840746708["MiniDFA3 {1}"]
DFA4_1560076770_4{{"DFA4 {1}"}}
end
subgraph MiniDFA9_865833780["MiniDFA9 {1}"]
DFA5_-1726250775_5[\"DFA5 {1}"/]
end
subgraph MiniDFA4_-1510640773["MiniDFA4 {1}"]
DFA6_-1843190077_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_-735882253["MiniDFA10 {1}"]
DFA7_1626823071_7[\"DFA7 {1}"/]
end
subgraph MiniDFA5_-2027031144["MiniDFA5 {1}"]
DFA8_-955626574_8{{"DFA8 {1}"}}
end
subgraph MiniDFA6_-275073042["MiniDFA6 {1}"]
DFA9_876036821_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-970470977["MiniDFA11 {1}"]
DFA10_-2088593982_10[\"DFA10 {1}"/]
end
subgraph MiniDFA7_-1829257632["MiniDFA7 {1}"]
DFA11_1584283167_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1652744804["MiniDFA12 {1}"]
DFA12_-293359031_12[\"DFA12 {1}"/]
end
MiniDFA0_1546011132 -->|"[-+]"|MiniDFA1_1296468508
MiniDFA0_1546011132 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA1_1296468508 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA8_1226626491 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA8_1226626491 -->|"[.]"|MiniDFA2_-495176242
MiniDFA8_1226626491 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA2_-495176242 -->|"[0-9]"|MiniDFA9_865833780
MiniDFA3_-1840746708 -->|"[-+]"|MiniDFA4_-1510640773
MiniDFA3_-1840746708 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA9_865833780 -->|"[0-9]"|MiniDFA9_865833780
MiniDFA9_865833780 -->|"[.]"|MiniDFA5_-2027031144
MiniDFA9_865833780 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA4_-1510640773 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA10_-735882253 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA10_-735882253 -->|"[Ee]"|MiniDFA6_-275073042
MiniDFA5_-2027031144 -->|"[0-9]"|MiniDFA11_-970470977
MiniDFA6_-275073042 -->|"[-+]"|MiniDFA7_-1829257632
MiniDFA6_-275073042 -->|"[0-9]"|MiniDFA12_-1652744804
MiniDFA11_-970470977 -->|"[0-9]"|MiniDFA11_-970470977
MiniDFA11_-970470977 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA7_-1829257632 -->|"[0-9]"|MiniDFA12_-1652744804
MiniDFA12_-1652744804 -->|"[0-9]"|MiniDFA12_-1652744804
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
MiniDFA0_1546011132(["MiniDFA0 {1}"])
MiniDFA1_1296468508(["MiniDFA1 {1}"])
MiniDFA8_1226626491[\"MiniDFA8 {1}"/]
MiniDFA2_-495176242(["MiniDFA2 {1}"])
MiniDFA3_-1840746708(["MiniDFA3 {1}"])
MiniDFA9_865833780[\"MiniDFA9 {1}"/]
MiniDFA4_-1510640773(["MiniDFA4 {1}"])
MiniDFA10_-735882253[\"MiniDFA10 {1}"/]
MiniDFA5_-2027031144(["MiniDFA5 {1}"])
MiniDFA6_-275073042(["MiniDFA6 {1}"])
MiniDFA11_-970470977[\"MiniDFA11 {1}"/]
MiniDFA7_-1829257632(["MiniDFA7 {1}"])
MiniDFA12_-1652744804[\"MiniDFA12 {1}"/]
MiniDFA0_1546011132 -->|"[-+]"|MiniDFA1_1296468508
MiniDFA0_1546011132 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA1_1296468508 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA8_1226626491 -->|"[0-9]"|MiniDFA8_1226626491
MiniDFA8_1226626491 -->|"[.]"|MiniDFA2_-495176242
MiniDFA8_1226626491 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA2_-495176242 -->|"[0-9]"|MiniDFA9_865833780
MiniDFA3_-1840746708 -->|"[-+]"|MiniDFA4_-1510640773
MiniDFA3_-1840746708 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA9_865833780 -->|"[0-9]"|MiniDFA9_865833780
MiniDFA9_865833780 -->|"[.]"|MiniDFA5_-2027031144
MiniDFA9_865833780 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA4_-1510640773 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA10_-735882253 -->|"[0-9]"|MiniDFA10_-735882253
MiniDFA10_-735882253 -->|"[Ee]"|MiniDFA6_-275073042
MiniDFA5_-2027031144 -->|"[0-9]"|MiniDFA11_-970470977
MiniDFA6_-275073042 -->|"[-+]"|MiniDFA7_-1829257632
MiniDFA6_-275073042 -->|"[0-9]"|MiniDFA12_-1652744804
MiniDFA11_-970470977 -->|"[0-9]"|MiniDFA11_-970470977
MiniDFA11_-970470977 -->|"[Ee]"|MiniDFA3_-1840746708
MiniDFA7_-1829257632 -->|"[0-9]"|MiniDFA12_-1652744804
MiniDFA12_-1652744804 -->|"[0-9]"|MiniDFA12_-1652744804
```
-------------------------------
