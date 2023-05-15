# 'char'

pattern: `\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~]`

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
eNFA3_9_66444130[["εNFA3-9 regex start"]]
eNFA3_0_13265486[["εNFA3-0 char{1, 1}"]]
eNFA3_11_61126266[["εNFA3-11 char{1, 1}"]]
eNFA3_15_52280510[["εNFA3-15 char{1, 1}"]]
eNFA3_19_762549[["εNFA3-19 char{1, 1}"]]
eNFA3_23_6862947[["εNFA3-23 char{1, 1}"]]
eNFA3_27_61766529[["εNFA3-27 scope{1, 1}"]]
eNFA3_29_19027857[["εNFA3-29 char{1, 1}"]]
eNFA3_33_37032986[["εNFA3-33 char{1, 1}"]]
eNFA3_37_64861423[["εNFA3-37 char{1, 1}"]]
eNFA3_41_46881895[["εNFA3-41 char{1, 1}"]]
eNFA3_43_19283877[["εNFA3-43 char{1, 1}"]]
eNFA3_47_39337169[["εNFA3-47 scope{1, 1}"]]
eNFA3_1_41018623[["εNFA3-1 char[1]"]]
eNFA3_12_33623295[["εNFA3-12 char[1]"]]
eNFA3_16_34174203[["εNFA3-16 char[1]"]]
eNFA3_20_39132371[["εNFA3-20 char[1]"]]
eNFA3_24_16647026[["εNFA3-24 char[1]"]]
eNFA3_28_55363057[["εNFA3-28 scope[1]"]]
eNFA3_30_15605512[["εNFA3-30 char[1]"]]
eNFA3_34_6231886[["εNFA3-34 char[1]"]]
eNFA3_38_56086982[["εNFA3-38 char[1]"]]
eNFA3_42_34652178[["εNFA3-42 char[1]"]]
eNFA3_44_35020791[["εNFA3-44 char[1]"]]
eNFA3_48_55222628[["εNFA3-48 scope[1]"]]
eNFA3_2_46751668[["εNFA3-2 char{1, 1}"]]
eNFA3_13_18111828[["εNFA3-13 char{1, 1}"]]
eNFA3_17_28788730[["εNFA3-17 char{1, 1}"]]
eNFA3_21_57771982[["εNFA3-21 char{1, 1}"]]
eNFA3_25_50185793[["εNFA3-25 char{1, 1}"]]
eNFA3_10_43434153[["εNFA3-10 regex end"]]
eNFA3_31_49018956[["εNFA3-31 char{1, 1}"]]
eNFA3_35_38517424[["εNFA3-35 char{1, 1}"]]
eNFA3_39_11112503[["εNFA3-39 char{1, 1}"]]
eNFA3_45_28907122[["εNFA3-45 char{1, 1}"]]
eNFA3_3_59775506[["εNFA3-3 char[1]"]]
eNFA3_14_59086710[["εNFA3-14 char[1]"]]
eNFA3_18_62018344[["εNFA3-18 char[1]"]]
eNFA3_22_21294187[["εNFA3-22 char[1]"]]
eNFA3_26_57429961[["εNFA3-26 char[1]"]]
eNFA3_49_1108643[["εNFA3-49 post-regex start"]]
eNFA3_32_47107601[["εNFA3-32 char[1]"]]
eNFA3_36_21315230[["εNFA3-36 char[1]"]]
eNFA3_40_57619343[["εNFA3-40 char[1]"]]
eNFA3_46_48812047[["εNFA3-46 char[1]"]]
eNFA3_4_9977790[["εNFA3-4 scope{4, 4}"]]
eNFA3_50_29852746[\"εNFA3-50 post-regex end"/]
eNFA3_5_26305809[["εNFA3-5 scope[1]"]]
eNFA3_6_35425694[["εNFA3-6 scope[2]"]]
eNFA3_7_50395793[["εNFA3-7 scope[3]"]]
eNFA3_8_12347112[["εNFA3-8 scope[4]"]]
eNFA3_9_66444130 -.->|"ε"|eNFA3_0_13265486
eNFA3_9_66444130 -.->|"ε"|eNFA3_11_61126266
eNFA3_9_66444130 -.->|"ε"|eNFA3_15_52280510
eNFA3_9_66444130 -.->|"ε"|eNFA3_19_762549
eNFA3_9_66444130 -.->|"ε"|eNFA3_23_6862947
eNFA3_9_66444130 -.->|"ε"|eNFA3_27_61766529
eNFA3_9_66444130 -.->|"ε"|eNFA3_29_19027857
eNFA3_9_66444130 -.->|"ε"|eNFA3_33_37032986
eNFA3_9_66444130 -.->|"ε"|eNFA3_37_64861423
eNFA3_9_66444130 -.->|"ε"|eNFA3_41_46881895
eNFA3_9_66444130 -.->|"ε"|eNFA3_43_19283877
eNFA3_9_66444130 -.->|"ε"|eNFA3_47_39337169
eNFA3_0_13265486 -->|"#92;"|eNFA3_1_41018623
eNFA3_11_61126266 -->|"#92;"|eNFA3_12_33623295
eNFA3_15_52280510 -->|"#92;"|eNFA3_16_34174203
eNFA3_19_762549 -->|"#92;"|eNFA3_20_39132371
eNFA3_23_6862947 -->|"#92;"|eNFA3_24_16647026
eNFA3_27_61766529 -->|"[#32;-Z]"|eNFA3_28_55363057
eNFA3_29_19027857 -->|"#92;"|eNFA3_30_15605512
eNFA3_33_37032986 -->|"#92;"|eNFA3_34_6231886
eNFA3_37_64861423 -->|"#92;"|eNFA3_38_56086982
eNFA3_41_46881895 -->|"^"|eNFA3_42_34652178
eNFA3_43_19283877 -->|"#92;"|eNFA3_44_35020791
eNFA3_47_39337169 -->|"[_-~]"|eNFA3_48_55222628
eNFA3_1_41018623 -.->|"ε"|eNFA3_2_46751668
eNFA3_12_33623295 -.->|"ε"|eNFA3_13_18111828
eNFA3_16_34174203 -.->|"ε"|eNFA3_17_28788730
eNFA3_20_39132371 -.->|"ε"|eNFA3_21_57771982
eNFA3_24_16647026 -.->|"ε"|eNFA3_25_50185793
eNFA3_28_55363057 -.->|"ε"|eNFA3_10_43434153
eNFA3_30_15605512 -.->|"ε"|eNFA3_31_49018956
eNFA3_34_6231886 -.->|"ε"|eNFA3_35_38517424
eNFA3_38_56086982 -.->|"ε"|eNFA3_39_11112503
eNFA3_42_34652178 -.->|"ε"|eNFA3_10_43434153
eNFA3_44_35020791 -.->|"ε"|eNFA3_45_28907122
eNFA3_48_55222628 -.->|"ε"|eNFA3_10_43434153
eNFA3_2_46751668 -->|"u"|eNFA3_3_59775506
eNFA3_13_18111828 -->|"t"|eNFA3_14_59086710
eNFA3_17_28788730 -->|"n"|eNFA3_18_62018344
eNFA3_21_57771982 -->|"r"|eNFA3_22_21294187
eNFA3_25_50185793 -->|"-"|eNFA3_26_57429961
eNFA3_10_43434153 -.->|"ε"|eNFA3_49_1108643
eNFA3_31_49018956 -->|"["|eNFA3_32_47107601
eNFA3_35_38517424 -->|"#92;"|eNFA3_36_21315230
eNFA3_39_11112503 -->|"]"|eNFA3_40_57619343
eNFA3_45_28907122 -->|"^"|eNFA3_46_48812047
eNFA3_3_59775506 -.->|"ε"|eNFA3_4_9977790
eNFA3_14_59086710 -.->|"ε"|eNFA3_10_43434153
eNFA3_18_62018344 -.->|"ε"|eNFA3_10_43434153
eNFA3_22_21294187 -.->|"ε"|eNFA3_10_43434153
eNFA3_26_57429961 -.->|"ε"|eNFA3_10_43434153
eNFA3_49_1108643 -.->|"ε"|eNFA3_50_29852746
eNFA3_32_47107601 -.->|"ε"|eNFA3_10_43434153
eNFA3_36_21315230 -.->|"ε"|eNFA3_10_43434153
eNFA3_40_57619343 -.->|"ε"|eNFA3_10_43434153
eNFA3_46_48812047 -.->|"ε"|eNFA3_10_43434153
eNFA3_4_9977790 -->|"[0-9]"|eNFA3_5_26305809
eNFA3_5_26305809 -->|"[0-9]"|eNFA3_6_35425694
eNFA3_6_35425694 -->|"[0-9]"|eNFA3_7_50395793
eNFA3_7_50395793 -->|"[0-9]"|eNFA3_8_12347112
eNFA3_8_12347112 -.->|"ε"|eNFA3_10_43434153
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
eNFA3_9_8457374[["εNFA3-9 regex start"]]
eNFA3_0_13958703[["εNFA3-0 char{1, 1}"]]
eNFA3_11_9007507[["εNFA3-11 char{1, 1}"]]
eNFA3_15_58519467[["εNFA3-15 char{1, 1}"]]
eNFA3_19_56913160[["εNFA3-19 char{1, 1}"]]
eNFA3_23_42456400[["εNFA3-23 char{1, 1}"]]
eNFA3_27_46563282[["εNFA3-27 scope{1, 1}"]]
eNFA3_29_16416361[["εNFA3-29 char{1, 1}"]]
eNFA3_33_13529525[["εNFA3-33 char{1, 1}"]]
eNFA3_37_54656863[["εNFA3-37 char{1, 1}"]]
eNFA3_41_22149720[["εNFA3-41 char{1, 1}"]]
eNFA3_43_65129753[["εNFA3-43 char{1, 1}"]]
eNFA3_47_49296867[["εNFA3-47 scope{1, 1}"]]
eNFA3_1_55527413[["εNFA3-1 char[1]"]]
eNFA3_12_1426598[["εNFA3-12 char[1]"]]
eNFA3_16_48445579[["εNFA3-16 char[1]"]]
eNFA3_20_31777804[["εNFA3-20 char[1]"]]
eNFA3_24_23865363[["εNFA3-24 char[1]"]]
eNFA3_28_47951145[\"εNFA3-28 scope[1]"/]
eNFA3_30_54046213[["εNFA3-30 char[1]"]]
eNFA3_34_15667148[["εNFA3-34 char[1]"]]
eNFA3_38_61079504[["εNFA3-38 char[1]"]]
eNFA3_42_32903664[\"εNFA3-42 char[1]"/]
eNFA3_44_48492792[["εNFA3-44 char[1]"]]
eNFA3_48_58837506[\"εNFA3-48 scope[1]"/]
eNFA3_2_29984672[["εNFA3-2 char{1, 1}"]]
eNFA3_3_51983383[["εNFA3-3 char[1]"]]
eNFA3_13_12839382[["εNFA3-13 char{1, 1}"]]
eNFA3_14_22691253[\"εNFA3-14 char[1]"/]
eNFA3_17_33357028[["εNFA3-17 char{1, 1}"]]
eNFA3_18_2894687[\"εNFA3-18 char[1]"/]
eNFA3_21_17564787[["εNFA3-21 char{1, 1}"]]
eNFA3_22_26052191[\"εNFA3-22 char[1]"/]
eNFA3_25_13461675[["εNFA3-25 char{1, 1}"]]
eNFA3_26_33143133[\"εNFA3-26 char[1]"/]
eNFA3_10_27697526[\"εNFA3-10 regex end"/]
eNFA3_49_35602093[\"εNFA3-49 post-regex start"/]
eNFA3_50_49904522[\"εNFA3-50 post-regex end"/]
eNFA3_31_16653875[["εNFA3-31 char{1, 1}"]]
eNFA3_32_239263[\"εNFA3-32 char[1]"/]
eNFA3_35_6786611[["εNFA3-35 char{1, 1}"]]
eNFA3_36_2153374[\"εNFA3-36 char[1]"/]
eNFA3_39_12844628[["εNFA3-39 char{1, 1}"]]
eNFA3_40_19380366[\"εNFA3-40 char[1]"/]
eNFA3_45_33781949[["εNFA3-45 char{1, 1}"]]
eNFA3_46_40205569[\"εNFA3-46 char[1]"/]
eNFA3_4_65197270[["εNFA3-4 scope{4, 4}"]]
eNFA3_5_46487516[["εNFA3-5 scope[1]"]]
eNFA3_6_64770113[["εNFA3-6 scope[2]"]]
eNFA3_7_46060111[["εNFA3-7 scope[3]"]]
eNFA3_8_50908955[\"εNFA3-8 scope[4]"/]
eNFA3_9_8457374 -.->|"ε"|eNFA3_0_13958703
eNFA3_9_8457374 -.->|"ε"|eNFA3_11_9007507
eNFA3_9_8457374 -.->|"ε"|eNFA3_15_58519467
eNFA3_9_8457374 -.->|"ε"|eNFA3_19_56913160
eNFA3_9_8457374 -.->|"ε"|eNFA3_23_42456400
eNFA3_9_8457374 -.->|"ε"|eNFA3_27_46563282
eNFA3_9_8457374 -.->|"ε"|eNFA3_29_16416361
eNFA3_9_8457374 -.->|"ε"|eNFA3_33_13529525
eNFA3_9_8457374 -.->|"ε"|eNFA3_37_54656863
eNFA3_9_8457374 -.->|"ε"|eNFA3_41_22149720
eNFA3_9_8457374 -.->|"ε"|eNFA3_43_65129753
eNFA3_9_8457374 -.->|"ε"|eNFA3_47_49296867
eNFA3_9_8457374 -->|"#92;"|eNFA3_1_55527413
eNFA3_9_8457374 -->|"#92;"|eNFA3_12_1426598
eNFA3_9_8457374 -->|"#92;"|eNFA3_16_48445579
eNFA3_9_8457374 -->|"#92;"|eNFA3_20_31777804
eNFA3_9_8457374 -->|"#92;"|eNFA3_24_23865363
eNFA3_9_8457374 -->|"[#32;-Z]"|eNFA3_28_47951145
eNFA3_9_8457374 -->|"#92;"|eNFA3_30_54046213
eNFA3_9_8457374 -->|"#92;"|eNFA3_34_15667148
eNFA3_9_8457374 -->|"#92;"|eNFA3_38_61079504
eNFA3_9_8457374 -->|"^"|eNFA3_42_32903664
eNFA3_9_8457374 -->|"#92;"|eNFA3_44_48492792
eNFA3_9_8457374 -->|"[_-~]"|eNFA3_48_58837506
eNFA3_0_13958703 -->|"#92;"|eNFA3_1_55527413
eNFA3_11_9007507 -->|"#92;"|eNFA3_12_1426598
eNFA3_15_58519467 -->|"#92;"|eNFA3_16_48445579
eNFA3_19_56913160 -->|"#92;"|eNFA3_20_31777804
eNFA3_23_42456400 -->|"#92;"|eNFA3_24_23865363
eNFA3_27_46563282 -->|"[#32;-Z]"|eNFA3_28_47951145
eNFA3_29_16416361 -->|"#92;"|eNFA3_30_54046213
eNFA3_33_13529525 -->|"#92;"|eNFA3_34_15667148
eNFA3_37_54656863 -->|"#92;"|eNFA3_38_61079504
eNFA3_41_22149720 -->|"^"|eNFA3_42_32903664
eNFA3_43_65129753 -->|"#92;"|eNFA3_44_48492792
eNFA3_47_49296867 -->|"[_-~]"|eNFA3_48_58837506
eNFA3_1_55527413 -.->|"ε"|eNFA3_2_29984672
eNFA3_1_55527413 -->|"u"|eNFA3_3_51983383
eNFA3_12_1426598 -.->|"ε"|eNFA3_13_12839382
eNFA3_12_1426598 -->|"t"|eNFA3_14_22691253
eNFA3_16_48445579 -.->|"ε"|eNFA3_17_33357028
eNFA3_16_48445579 -->|"n"|eNFA3_18_2894687
eNFA3_20_31777804 -.->|"ε"|eNFA3_21_17564787
eNFA3_20_31777804 -->|"r"|eNFA3_22_26052191
eNFA3_24_23865363 -.->|"ε"|eNFA3_25_13461675
eNFA3_24_23865363 -->|"-"|eNFA3_26_33143133
eNFA3_28_47951145 -.->|"ε"|eNFA3_10_27697526
eNFA3_28_47951145 -.->|"ε"|eNFA3_49_35602093
eNFA3_28_47951145 -.->|"ε"|eNFA3_50_49904522
eNFA3_30_54046213 -.->|"ε"|eNFA3_31_16653875
eNFA3_30_54046213 -->|"["|eNFA3_32_239263
eNFA3_34_15667148 -.->|"ε"|eNFA3_35_6786611
eNFA3_34_15667148 -->|"#92;"|eNFA3_36_2153374
eNFA3_38_61079504 -.->|"ε"|eNFA3_39_12844628
eNFA3_38_61079504 -->|"]"|eNFA3_40_19380366
eNFA3_42_32903664 -.->|"ε"|eNFA3_10_27697526
eNFA3_42_32903664 -.->|"ε"|eNFA3_49_35602093
eNFA3_42_32903664 -.->|"ε"|eNFA3_50_49904522
eNFA3_44_48492792 -.->|"ε"|eNFA3_45_33781949
eNFA3_44_48492792 -->|"^"|eNFA3_46_40205569
eNFA3_48_58837506 -.->|"ε"|eNFA3_10_27697526
eNFA3_48_58837506 -.->|"ε"|eNFA3_49_35602093
eNFA3_48_58837506 -.->|"ε"|eNFA3_50_49904522
eNFA3_2_29984672 -->|"u"|eNFA3_3_51983383
eNFA3_3_51983383 -.->|"ε"|eNFA3_4_65197270
eNFA3_3_51983383 -->|"[0-9]"|eNFA3_5_46487516
eNFA3_13_12839382 -->|"t"|eNFA3_14_22691253
eNFA3_14_22691253 -.->|"ε"|eNFA3_10_27697526
eNFA3_14_22691253 -.->|"ε"|eNFA3_49_35602093
eNFA3_14_22691253 -.->|"ε"|eNFA3_50_49904522
eNFA3_17_33357028 -->|"n"|eNFA3_18_2894687
eNFA3_18_2894687 -.->|"ε"|eNFA3_10_27697526
eNFA3_18_2894687 -.->|"ε"|eNFA3_49_35602093
eNFA3_18_2894687 -.->|"ε"|eNFA3_50_49904522
eNFA3_21_17564787 -->|"r"|eNFA3_22_26052191
eNFA3_22_26052191 -.->|"ε"|eNFA3_10_27697526
eNFA3_22_26052191 -.->|"ε"|eNFA3_49_35602093
eNFA3_22_26052191 -.->|"ε"|eNFA3_50_49904522
eNFA3_25_13461675 -->|"-"|eNFA3_26_33143133
eNFA3_26_33143133 -.->|"ε"|eNFA3_10_27697526
eNFA3_26_33143133 -.->|"ε"|eNFA3_49_35602093
eNFA3_26_33143133 -.->|"ε"|eNFA3_50_49904522
eNFA3_10_27697526 -.->|"ε"|eNFA3_49_35602093
eNFA3_10_27697526 -.->|"ε"|eNFA3_50_49904522
eNFA3_49_35602093 -.->|"ε"|eNFA3_50_49904522
eNFA3_31_16653875 -->|"["|eNFA3_32_239263
eNFA3_32_239263 -.->|"ε"|eNFA3_10_27697526
eNFA3_32_239263 -.->|"ε"|eNFA3_49_35602093
eNFA3_32_239263 -.->|"ε"|eNFA3_50_49904522
eNFA3_35_6786611 -->|"#92;"|eNFA3_36_2153374
eNFA3_36_2153374 -.->|"ε"|eNFA3_10_27697526
eNFA3_36_2153374 -.->|"ε"|eNFA3_49_35602093
eNFA3_36_2153374 -.->|"ε"|eNFA3_50_49904522
eNFA3_39_12844628 -->|"]"|eNFA3_40_19380366
eNFA3_40_19380366 -.->|"ε"|eNFA3_10_27697526
eNFA3_40_19380366 -.->|"ε"|eNFA3_49_35602093
eNFA3_40_19380366 -.->|"ε"|eNFA3_50_49904522
eNFA3_45_33781949 -->|"^"|eNFA3_46_40205569
eNFA3_46_40205569 -.->|"ε"|eNFA3_10_27697526
eNFA3_46_40205569 -.->|"ε"|eNFA3_49_35602093
eNFA3_46_40205569 -.->|"ε"|eNFA3_50_49904522
eNFA3_4_65197270 -->|"[0-9]"|eNFA3_5_46487516
eNFA3_5_46487516 -->|"[0-9]"|eNFA3_6_64770113
eNFA3_6_64770113 -->|"[0-9]"|eNFA3_7_46060111
eNFA3_7_46060111 -->|"[0-9]"|eNFA3_8_50908955
eNFA3_8_50908955 -.->|"ε"|eNFA3_10_27697526
eNFA3_8_50908955 -.->|"ε"|eNFA3_49_35602093
eNFA3_8_50908955 -.->|"ε"|eNFA3_50_49904522
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
NFA3_9_15734461("NFA3-9 regex start")
NFA3_1_66531800("NFA3-1 char[1]")
NFA3_12_7392422("NFA3-12 char[1]")
NFA3_16_61915292("NFA3-16 char[1]")
NFA3_20_20366724("NFA3-20 char[1]")
NFA3_24_49082792("NFA3-24 char[1]")
NFA3_28_39091944[\"NFA3-28 scope[1]"/]
NFA3_30_16283183("NFA3-30 char[1]")
NFA3_34_12330925("NFA3-34 char[1]")
NFA3_38_43869467("NFA3-38 char[1]")
NFA3_42_59280891[\"NFA3-42 char[1]"/]
NFA3_44_63765972("NFA3-44 char[1]")
NFA3_48_37022841[\"NFA3-48 scope[1]"/]
NFA3_3_11887819("NFA3-3 char[1]")
NFA3_14_39881510[\"NFA3-14 char[1]"/]
NFA3_18_23389273[\"NFA3-18 char[1]"/]
NFA3_22_9176869[\"NFA3-22 char[1]"/]
NFA3_26_15482964[\"NFA3-26 char[1]"/]
NFA3_32_5128949[\"NFA3-32 char[1]"/]
NFA3_36_46160547[\"NFA3-36 char[1]"/]
NFA3_40_12791742[\"NFA3-40 char[1]"/]
NFA3_46_48016815[\"NFA3-46 char[1]"/]
NFA3_5_29498151("NFA3-5 scope[1]")
NFA3_6_64156767("NFA3-6 scope[2]")
NFA3_7_40539992("NFA3-7 scope[3]")
NFA3_8_29315611[\"NFA3-8 scope[4]"/]
NFA3_9_15734461 -->|"#92;"|NFA3_1_66531800
NFA3_9_15734461 -->|"#92;"|NFA3_12_7392422
NFA3_9_15734461 -->|"#92;"|NFA3_16_61915292
NFA3_9_15734461 -->|"#92;"|NFA3_20_20366724
NFA3_9_15734461 -->|"#92;"|NFA3_24_49082792
NFA3_9_15734461 -->|"[#32;-Z]"|NFA3_28_39091944
NFA3_9_15734461 -->|"#92;"|NFA3_30_16283183
NFA3_9_15734461 -->|"#92;"|NFA3_34_12330925
NFA3_9_15734461 -->|"#92;"|NFA3_38_43869467
NFA3_9_15734461 -->|"^"|NFA3_42_59280891
NFA3_9_15734461 -->|"#92;"|NFA3_44_63765972
NFA3_9_15734461 -->|"[_-~]"|NFA3_48_37022841
NFA3_1_66531800 -->|"u"|NFA3_3_11887819
NFA3_12_7392422 -->|"t"|NFA3_14_39881510
NFA3_16_61915292 -->|"n"|NFA3_18_23389273
NFA3_20_20366724 -->|"r"|NFA3_22_9176869
NFA3_24_49082792 -->|"-"|NFA3_26_15482964
NFA3_30_16283183 -->|"["|NFA3_32_5128949
NFA3_34_12330925 -->|"#92;"|NFA3_36_46160547
NFA3_38_43869467 -->|"]"|NFA3_40_12791742
NFA3_44_63765972 -->|"^"|NFA3_46_48016815
NFA3_3_11887819 -->|"[0-9]"|NFA3_5_29498151
NFA3_5_29498151 -->|"[0-9]"|NFA3_6_64156767
NFA3_6_64156767 -->|"[0-9]"|NFA3_7_40539992
NFA3_7_40539992 -->|"[0-9]"|NFA3_8_29315611
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
subgraph DFA0_1435714417["DFA0 regex start"]
NFA3_9_15734461_0("NFA3-9 regex start")
end
subgraph DFA1_439091645["DFA1 {9}"]
NFA3_1_66531800_1("NFA3-1 char[1]")
NFA3_12_7392422_2("NFA3-12 char[1]")
NFA3_16_61915292_3("NFA3-16 char[1]")
NFA3_20_20366724_4("NFA3-20 char[1]")
NFA3_24_49082792_5("NFA3-24 char[1]")
NFA3_30_16283183_6("NFA3-30 char[1]")
NFA3_34_12330925_7("NFA3-34 char[1]")
NFA3_38_43869467_8("NFA3-38 char[1]")
NFA3_44_63765972_9("NFA3-44 char[1]")
end
subgraph DFA2_1728542218["DFA2 {1}"]
NFA3_28_39091944_10[\"NFA3-28 scope[1]"/]
end
subgraph DFA3_1011623844["DFA3 {1}"]
NFA3_42_59280891_11[\"NFA3-42 char[1]"/]
end
subgraph DFA4_292656186["DFA4 {1}"]
NFA3_48_37022841_12[\"NFA3-48 scope[1]"/]
end
subgraph DFA5_-2034071206["DFA5 {1}"]
NFA3_3_11887819_13("NFA3-3 char[1]")
end
subgraph DFA6_-717600109["DFA6 {1}"]
NFA3_14_39881510_14[\"NFA3-14 char[1]"/]
end
subgraph DFA7_1763693033["DFA7 {1}"]
NFA3_18_23389273_15[\"NFA3-18 char[1]"/]
end
subgraph DFA8_1244918061["DFA8 {1}"]
NFA3_22_9176869_16[\"NFA3-22 char[1]"/]
end
subgraph DFA9_-720702220["DFA9 {1}"]
NFA3_26_15482964_17[\"NFA3-26 char[1]"/]
end
subgraph DFA10_-1879135244["DFA10 {1}"]
NFA3_32_5128949_18[\"NFA3-32 char[1]"/]
end
subgraph DFA11_1149300808["DFA11 {1}"]
NFA3_36_46160547_19[\"NFA3-36 char[1]"/]
end
subgraph DFA12_-13217190["DFA12 {1}"]
NFA3_40_12791742_20[\"NFA3-40 char[1]"/]
end
subgraph DFA13_824506811["DFA13 {1}"]
NFA3_46_48016815_21[\"NFA3-46 char[1]"/]
end
subgraph DFA14_268150595["DFA14 {1}"]
NFA3_5_29498151_22("NFA3-5 scope[1]")
end
subgraph DFA15_-1216760668["DFA15 {1}"]
NFA3_6_64156767_23("NFA3-6 scope[2]")
end
subgraph DFA16_1020004378["DFA16 {1}"]
NFA3_7_40539992_24("NFA3-7 scope[3]")
end
subgraph DFA17_890054773["DFA17 {1}"]
NFA3_8_29315611_25[\"NFA3-8 scope[4]"/]
end
DFA0_1435714417 -->|"#92;"|DFA1_439091645
DFA0_1435714417 -->|"[#32;-Z]"|DFA2_1728542218
DFA0_1435714417 -->|"^"|DFA3_1011623844
DFA0_1435714417 -->|"[_-~]"|DFA4_292656186
DFA1_439091645 -->|"u"|DFA5_-2034071206
DFA1_439091645 -->|"t"|DFA6_-717600109
DFA1_439091645 -->|"n"|DFA7_1763693033
DFA1_439091645 -->|"r"|DFA8_1244918061
DFA1_439091645 -->|"-"|DFA9_-720702220
DFA1_439091645 -->|"["|DFA10_-1879135244
DFA1_439091645 -->|"#92;"|DFA11_1149300808
DFA1_439091645 -->|"]"|DFA12_-13217190
DFA1_439091645 -->|"^"|DFA13_824506811
DFA5_-2034071206 -->|"[0-9]"|DFA14_268150595
DFA14_268150595 -->|"[0-9]"|DFA15_-1216760668
DFA15_-1216760668 -->|"[0-9]"|DFA16_1020004378
DFA16_1020004378 -->|"[0-9]"|DFA17_890054773
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
DFA0_1435714417{{"DFA0 regex start"}}
DFA1_439091645{{"DFA1 {9}"}}
DFA2_1728542218[\"DFA2 {1}"/]
DFA3_1011623844[\"DFA3 {1}"/]
DFA4_292656186[\"DFA4 {1}"/]
DFA5_-2034071206{{"DFA5 {1}"}}
DFA6_-717600109[\"DFA6 {1}"/]
DFA7_1763693033[\"DFA7 {1}"/]
DFA8_1244918061[\"DFA8 {1}"/]
DFA9_-720702220[\"DFA9 {1}"/]
DFA10_-1879135244[\"DFA10 {1}"/]
DFA11_1149300808[\"DFA11 {1}"/]
DFA12_-13217190[\"DFA12 {1}"/]
DFA13_824506811[\"DFA13 {1}"/]
DFA14_268150595{{"DFA14 {1}"}}
DFA15_-1216760668{{"DFA15 {1}"}}
DFA16_1020004378{{"DFA16 {1}"}}
DFA17_890054773[\"DFA17 {1}"/]
DFA0_1435714417 -->|"#92;"|DFA1_439091645
DFA0_1435714417 -->|"[#32;-Z]"|DFA2_1728542218
DFA0_1435714417 -->|"^"|DFA3_1011623844
DFA0_1435714417 -->|"[_-~]"|DFA4_292656186
DFA1_439091645 -->|"u"|DFA5_-2034071206
DFA1_439091645 -->|"t"|DFA6_-717600109
DFA1_439091645 -->|"n"|DFA7_1763693033
DFA1_439091645 -->|"r"|DFA8_1244918061
DFA1_439091645 -->|"-"|DFA9_-720702220
DFA1_439091645 -->|"["|DFA10_-1879135244
DFA1_439091645 -->|"#92;"|DFA11_1149300808
DFA1_439091645 -->|"]"|DFA12_-13217190
DFA1_439091645 -->|"^"|DFA13_824506811
DFA5_-2034071206 -->|"[0-9]"|DFA14_268150595
DFA14_268150595 -->|"[0-9]"|DFA15_-1216760668
DFA15_-1216760668 -->|"[0-9]"|DFA16_1020004378
DFA16_1020004378 -->|"[0-9]"|DFA17_890054773
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
subgraph MiniDFA0_-602930770["MiniDFA0 {1}"]
DFA0_1435714417_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1768279425["MiniDFA1 {1}"]
DFA1_439091645_1{{"DFA1 {9}"}}
end
subgraph MiniDFA6_-1317557659["MiniDFA6 {1}"]
DFA2_1728542218_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_1143497015["MiniDFA7 {1}"]
DFA3_1011623844_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_-101674732["MiniDFA8 {1}"]
DFA4_292656186_4[\"DFA4 {1}"/]
end
subgraph MiniDFA2_928217795["MiniDFA2 {1}"]
DFA5_-2034071206_5{{"DFA5 {1}"}}
end
subgraph MiniDFA9_731664768["MiniDFA9 {1}"]
DFA6_-717600109_6[\"DFA6 {1}"/]
end
subgraph MiniDFA10_-225480666["MiniDFA10 {1}"]
DFA7_1763693033_7[\"DFA7 {1}"/]
end
subgraph MiniDFA11_1898916755["MiniDFA11 {1}"]
DFA8_1244918061_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_56236471["MiniDFA12 {1}"]
DFA9_-720702220_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_1600262354["MiniDFA13 {1}"]
DFA10_-1879135244_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_-1592448324["MiniDFA14 {1}"]
DFA11_1149300808_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_-1152318613["MiniDFA15 {1}"]
DFA12_-13217190_12[\"DFA12 {1}"/]
end
subgraph MiniDFA16_-1995768104["MiniDFA16 {1}"]
DFA13_824506811_13[\"DFA13 {1}"/]
end
subgraph MiniDFA3_1517774804["MiniDFA3 {1}"]
DFA14_268150595_14{{"DFA14 {1}"}}
end
subgraph MiniDFA4_-1952124149["MiniDFA4 {1}"]
DFA15_-1216760668_15{{"DFA15 {1}"}}
end
subgraph MiniDFA5_-1532909261["MiniDFA5 {1}"]
DFA16_1020004378_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_-938361283["MiniDFA17 {1}"]
DFA17_890054773_17[\"DFA17 {1}"/]
end
MiniDFA0_-602930770 -->|"#92;"|MiniDFA1_-1768279425
MiniDFA0_-602930770 -->|"[#32;-Z]"|MiniDFA6_-1317557659
MiniDFA0_-602930770 -->|"^"|MiniDFA7_1143497015
MiniDFA0_-602930770 -->|"[_-~]"|MiniDFA8_-101674732
MiniDFA1_-1768279425 -->|"u"|MiniDFA2_928217795
MiniDFA1_-1768279425 -->|"t"|MiniDFA9_731664768
MiniDFA1_-1768279425 -->|"n"|MiniDFA10_-225480666
MiniDFA1_-1768279425 -->|"r"|MiniDFA11_1898916755
MiniDFA1_-1768279425 -->|"-"|MiniDFA12_56236471
MiniDFA1_-1768279425 -->|"["|MiniDFA13_1600262354
MiniDFA1_-1768279425 -->|"#92;"|MiniDFA14_-1592448324
MiniDFA1_-1768279425 -->|"]"|MiniDFA15_-1152318613
MiniDFA1_-1768279425 -->|"^"|MiniDFA16_-1995768104
MiniDFA2_928217795 -->|"[0-9]"|MiniDFA3_1517774804
MiniDFA3_1517774804 -->|"[0-9]"|MiniDFA4_-1952124149
MiniDFA4_-1952124149 -->|"[0-9]"|MiniDFA5_-1532909261
MiniDFA5_-1532909261 -->|"[0-9]"|MiniDFA17_-938361283
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
MiniDFA0_-602930770(["MiniDFA0 {1}"])
MiniDFA1_-1768279425(["MiniDFA1 {1}"])
MiniDFA6_-1317557659[\"MiniDFA6 {1}"/]
MiniDFA7_1143497015[\"MiniDFA7 {1}"/]
MiniDFA8_-101674732[\"MiniDFA8 {1}"/]
MiniDFA2_928217795(["MiniDFA2 {1}"])
MiniDFA9_731664768[\"MiniDFA9 {1}"/]
MiniDFA10_-225480666[\"MiniDFA10 {1}"/]
MiniDFA11_1898916755[\"MiniDFA11 {1}"/]
MiniDFA12_56236471[\"MiniDFA12 {1}"/]
MiniDFA13_1600262354[\"MiniDFA13 {1}"/]
MiniDFA14_-1592448324[\"MiniDFA14 {1}"/]
MiniDFA15_-1152318613[\"MiniDFA15 {1}"/]
MiniDFA16_-1995768104[\"MiniDFA16 {1}"/]
MiniDFA3_1517774804(["MiniDFA3 {1}"])
MiniDFA4_-1952124149(["MiniDFA4 {1}"])
MiniDFA5_-1532909261(["MiniDFA5 {1}"])
MiniDFA17_-938361283[\"MiniDFA17 {1}"/]
MiniDFA0_-602930770 -->|"#92;"|MiniDFA1_-1768279425
MiniDFA0_-602930770 -->|"[#32;-Z]"|MiniDFA6_-1317557659
MiniDFA0_-602930770 -->|"^"|MiniDFA7_1143497015
MiniDFA0_-602930770 -->|"[_-~]"|MiniDFA8_-101674732
MiniDFA1_-1768279425 -->|"u"|MiniDFA2_928217795
MiniDFA1_-1768279425 -->|"t"|MiniDFA9_731664768
MiniDFA1_-1768279425 -->|"n"|MiniDFA10_-225480666
MiniDFA1_-1768279425 -->|"r"|MiniDFA11_1898916755
MiniDFA1_-1768279425 -->|"-"|MiniDFA12_56236471
MiniDFA1_-1768279425 -->|"["|MiniDFA13_1600262354
MiniDFA1_-1768279425 -->|"#92;"|MiniDFA14_-1592448324
MiniDFA1_-1768279425 -->|"]"|MiniDFA15_-1152318613
MiniDFA1_-1768279425 -->|"^"|MiniDFA16_-1995768104
MiniDFA2_928217795 -->|"[0-9]"|MiniDFA3_1517774804
MiniDFA3_1517774804 -->|"[0-9]"|MiniDFA4_-1952124149
MiniDFA4_-1952124149 -->|"[0-9]"|MiniDFA5_-1532909261
MiniDFA5_-1532909261 -->|"[0-9]"|MiniDFA17_-938361283
```
-------------------------------
