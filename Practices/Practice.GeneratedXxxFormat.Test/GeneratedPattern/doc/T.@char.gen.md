# 'char'

pattern: `[ !"#%&',]|-|[0-9:;<=>@A-Z_`a-z~]|\\[$()*+]|\\-|\\[./<>?]|\\\[|\\\\|\\\]|\\\^|\\\{|\\\||\\\}|\\u[0-9a-fA-F]{4}`

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
eNFA4_2_7471967[["εNFA4-2 regex start"]]
eNFA4_0_1249601[["εNFA4-0 scope{1, 1}"]]
eNFA4_4_138844[["εNFA4-4 char{1, 1}"]]
eNFA4_6_11246416[["εNFA4-6 scope{1, 1}"]]
eNFA4_8_34108880[["εNFA4-8 char{1, 1}"]]
eNFA4_12_38544467[["εNFA4-12 char{1, 1}"]]
eNFA4_16_11355891[["εNFA4-16 char{1, 1}"]]
eNFA4_20_35094160[["εNFA4-20 char{1, 1}"]]
eNFA4_24_47411987[["εNFA4-24 char{1, 1}"]]
eNFA4_28_24054701[["εNFA4-28 char{1, 1}"]]
eNFA4_32_15165719[["εNFA4-32 char{1, 1}"]]
eNFA4_36_2273746[["εNFA4-36 char{1, 1}"]]
eNFA4_40_20463720[["εNFA4-40 char{1, 1}"]]
eNFA4_44_49955752[["εNFA4-44 char{1, 1}"]]
eNFA4_48_46948589[["εNFA4-48 char{1, 1}"]]
eNFA4_1_53778287[["εNFA4-1 scope[1]"]]
eNFA4_5_42917658[["εNFA4-5 char[1]"]]
eNFA4_7_14242537[["εNFA4-7 scope[1]"]]
eNFA4_9_34751460[["εNFA4-9 char[1]"]]
eNFA4_13_44327687[["εNFA4-13 char[1]"]]
eNFA4_17_63404869[["εNFA4-17 char[1]"]]
eNFA4_21_33772909[["εNFA4-21 char[1]"]]
eNFA4_25_35520730[["εNFA4-25 char[1]"]]
eNFA4_29_51251115[["εNFA4-29 char[1]"]]
eNFA4_33_58606859[["εNFA4-33 char[1]"]]
eNFA4_37_57699690[["εNFA4-37 char[1]"]]
eNFA4_41_49535170[["εNFA4-41 char[1]"]]
eNFA4_45_43163346[["εNFA4-45 char[1]"]]
eNFA4_49_52925796[["εNFA4-49 char[1]"]]
eNFA4_3_50714607[["εNFA4-3 regex end"]]
eNFA4_10_22681099[["εNFA4-10 scope{1, 1}"]]
eNFA4_14_2803303[["εNFA4-14 char{1, 1}"]]
eNFA4_18_25229732[["εNFA4-18 scope{1, 1}"]]
eNFA4_22_25741004[["εNFA4-22 char{1, 1}"]]
eNFA4_26_30342446[["εNFA4-26 char{1, 1}"]]
eNFA4_30_4646565[["εNFA4-30 char{1, 1}"]]
eNFA4_34_41819089[["εNFA4-34 char{1, 1}"]]
eNFA4_38_40827483[["εNFA4-38 char{1, 1}"]]
eNFA4_42_31903028[["εNFA4-42 char{1, 1}"]]
eNFA4_46_18691797[["εNFA4-46 char{1, 1}"]]
eNFA4_50_34008447[["εNFA4-50 char{1, 1}"]]
eNFA4_57_37640571[["εNFA4-57 post-regex start"]]
eNFA4_11_23568445[["εNFA4-11 scope[1]"]]
eNFA4_15_10789421[["εNFA4-15 char[1]"]]
eNFA4_19_29995926[["εNFA4-19 scope[1]"]]
eNFA4_23_1527883[["εNFA4-23 char[1]"]]
eNFA4_27_13750947[["εNFA4-27 char[1]"]]
eNFA4_31_56649665[["εNFA4-31 char[1]"]]
eNFA4_35_40084941[["εNFA4-35 char[1]"]]
eNFA4_39_25220152[["εNFA4-39 char[1]"]]
eNFA4_43_25654779[["εNFA4-43 char[1]"]]
eNFA4_47_29566423[["εNFA4-47 char[1]"]]
eNFA4_51_3220827[["εNFA4-51 char[1]"]]
eNFA4_58_28987447[\"εNFA4-58 post-regex end"/]
eNFA4_52_47533853[["εNFA4-52 scope{4, 4}"]]
eNFA4_53_25151496[["εNFA4-53 scope[1]"]]
eNFA4_54_25036876[["εNFA4-54 scope[2]"]]
eNFA4_55_24005299[["εNFA4-55 scope[3]"]]
eNFA4_56_30661937[["εNFA4-56 scope[4]"]]
eNFA4_2_7471967 -.->|"ε"|eNFA4_0_1249601
eNFA4_2_7471967 -.->|"ε"|eNFA4_4_138844
eNFA4_2_7471967 -.->|"ε"|eNFA4_6_11246416
eNFA4_2_7471967 -.->|"ε"|eNFA4_8_34108880
eNFA4_2_7471967 -.->|"ε"|eNFA4_12_38544467
eNFA4_2_7471967 -.->|"ε"|eNFA4_16_11355891
eNFA4_2_7471967 -.->|"ε"|eNFA4_20_35094160
eNFA4_2_7471967 -.->|"ε"|eNFA4_24_47411987
eNFA4_2_7471967 -.->|"ε"|eNFA4_28_24054701
eNFA4_2_7471967 -.->|"ε"|eNFA4_32_15165719
eNFA4_2_7471967 -.->|"ε"|eNFA4_36_2273746
eNFA4_2_7471967 -.->|"ε"|eNFA4_40_20463720
eNFA4_2_7471967 -.->|"ε"|eNFA4_44_49955752
eNFA4_2_7471967 -.->|"ε"|eNFA4_48_46948589
eNFA4_0_1249601 -->|"[#32;!#34;#35;%&',]"|eNFA4_1_53778287
eNFA4_4_138844 -->|"-"|eNFA4_5_42917658
eNFA4_6_11246416 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|eNFA4_7_14242537
eNFA4_8_34108880 -->|"#92;"|eNFA4_9_34751460
eNFA4_12_38544467 -->|"#92;"|eNFA4_13_44327687
eNFA4_16_11355891 -->|"#92;"|eNFA4_17_63404869
eNFA4_20_35094160 -->|"#92;"|eNFA4_21_33772909
eNFA4_24_47411987 -->|"#92;"|eNFA4_25_35520730
eNFA4_28_24054701 -->|"#92;"|eNFA4_29_51251115
eNFA4_32_15165719 -->|"#92;"|eNFA4_33_58606859
eNFA4_36_2273746 -->|"#92;"|eNFA4_37_57699690
eNFA4_40_20463720 -->|"#92;"|eNFA4_41_49535170
eNFA4_44_49955752 -->|"#92;"|eNFA4_45_43163346
eNFA4_48_46948589 -->|"#92;"|eNFA4_49_52925796
eNFA4_1_53778287 -.->|"ε"|eNFA4_3_50714607
eNFA4_5_42917658 -.->|"ε"|eNFA4_3_50714607
eNFA4_7_14242537 -.->|"ε"|eNFA4_3_50714607
eNFA4_9_34751460 -.->|"ε"|eNFA4_10_22681099
eNFA4_13_44327687 -.->|"ε"|eNFA4_14_2803303
eNFA4_17_63404869 -.->|"ε"|eNFA4_18_25229732
eNFA4_21_33772909 -.->|"ε"|eNFA4_22_25741004
eNFA4_25_35520730 -.->|"ε"|eNFA4_26_30342446
eNFA4_29_51251115 -.->|"ε"|eNFA4_30_4646565
eNFA4_33_58606859 -.->|"ε"|eNFA4_34_41819089
eNFA4_37_57699690 -.->|"ε"|eNFA4_38_40827483
eNFA4_41_49535170 -.->|"ε"|eNFA4_42_31903028
eNFA4_45_43163346 -.->|"ε"|eNFA4_46_18691797
eNFA4_49_52925796 -.->|"ε"|eNFA4_50_34008447
eNFA4_3_50714607 -.->|"ε"|eNFA4_57_37640571
eNFA4_10_22681099 -->|"[$()*+]"|eNFA4_11_23568445
eNFA4_14_2803303 -->|"-"|eNFA4_15_10789421
eNFA4_18_25229732 -->|"[./<>?]"|eNFA4_19_29995926
eNFA4_22_25741004 -->|"["|eNFA4_23_1527883
eNFA4_26_30342446 -->|"#92;"|eNFA4_27_13750947
eNFA4_30_4646565 -->|"]"|eNFA4_31_56649665
eNFA4_34_41819089 -->|"^"|eNFA4_35_40084941
eNFA4_38_40827483 -->|"{"|eNFA4_39_25220152
eNFA4_42_31903028 -->|"|"|eNFA4_43_25654779
eNFA4_46_18691797 -->|"}"|eNFA4_47_29566423
eNFA4_50_34008447 -->|"u"|eNFA4_51_3220827
eNFA4_57_37640571 -.->|"ε"|eNFA4_58_28987447
eNFA4_11_23568445 -.->|"ε"|eNFA4_3_50714607
eNFA4_15_10789421 -.->|"ε"|eNFA4_3_50714607
eNFA4_19_29995926 -.->|"ε"|eNFA4_3_50714607
eNFA4_23_1527883 -.->|"ε"|eNFA4_3_50714607
eNFA4_27_13750947 -.->|"ε"|eNFA4_3_50714607
eNFA4_31_56649665 -.->|"ε"|eNFA4_3_50714607
eNFA4_35_40084941 -.->|"ε"|eNFA4_3_50714607
eNFA4_39_25220152 -.->|"ε"|eNFA4_3_50714607
eNFA4_43_25654779 -.->|"ε"|eNFA4_3_50714607
eNFA4_47_29566423 -.->|"ε"|eNFA4_3_50714607
eNFA4_51_3220827 -.->|"ε"|eNFA4_52_47533853
eNFA4_52_47533853 -->|"[0-9a-fA-F]"|eNFA4_53_25151496
eNFA4_53_25151496 -->|"[0-9a-fA-F]"|eNFA4_54_25036876
eNFA4_54_25036876 -->|"[0-9a-fA-F]"|eNFA4_55_24005299
eNFA4_55_24005299 -->|"[0-9a-fA-F]"|eNFA4_56_30661937
eNFA4_56_30661937 -.->|"ε"|eNFA4_3_50714607
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
eNFA4_2_5300362[["εNFA4-2 regex start"]]
eNFA4_0_26676172[["εNFA4-0 scope{1, 1}"]]
eNFA4_4_47703261[["εNFA4-4 char{1, 1}"]]
eNFA4_6_38758958[["εNFA4-6 scope{1, 1}"]]
eNFA4_8_13286310[["εNFA4-8 char{1, 1}"]]
eNFA4_12_52467932[["εNFA4-12 char{1, 1}"]]
eNFA4_16_2449345[["εNFA4-16 char{1, 1}"]]
eNFA4_20_22044110[["εNFA4-20 char{1, 1}"]]
eNFA4_24_64179269[["εNFA4-24 char{1, 1}"]]
eNFA4_28_40742509[["εNFA4-28 char{1, 1}"]]
eNFA4_32_31138264[["εNFA4-32 char{1, 1}"]]
eNFA4_36_11808928[["εNFA4-36 char{1, 1}"]]
eNFA4_40_39171493[["εNFA4-40 char{1, 1}"]]
eNFA4_44_16999120[["εNFA4-44 char{1, 1}"]]
eNFA4_48_18774354[["εNFA4-48 char{1, 1}"]]
eNFA4_1_62417850[\"εNFA4-1 scope[1]"/]
eNFA4_5_6570122[\"εNFA4-5 char[1]"/]
eNFA4_7_24889743[\"εNFA4-7 scope[1]"/]
eNFA4_9_65381042[["εNFA4-9 char[1]"]]
eNFA4_13_61373038[["εNFA4-13 char[1]"]]
eNFA4_17_5160142[["εNFA4-17 char[1]"]]
eNFA4_21_15318330[["εNFA4-21 char[1]"]]
eNFA4_25_32825243[["εNFA4-25 char[1]"]]
eNFA4_29_41599065[["εNFA4-29 char[1]"]]
eNFA4_33_14081115[["εNFA4-33 char[1]"]]
eNFA4_37_66828554[["εNFA4-37 char[1]"]]
eNFA4_41_44403789[["εNFA4-41 char[1]"]]
eNFA4_45_39937165[["εNFA4-45 char[1]"]]
eNFA4_49_13684913[["εNFA4-49 char[1]"]]
eNFA4_3_59131099[\"εNFA4-3 regex end"/]
eNFA4_57_34736162[\"εNFA4-57 post-regex start"/]
eNFA4_58_44190002[\"εNFA4-58 post-regex end"/]
eNFA4_10_51558469[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_59560431[\"εNFA4-11 scope[1]"/]
eNFA4_14_15486430[["εNFA4-14 char{1, 1}"]]
eNFA4_15_66281838[\"εNFA4-15 char[1]"/]
eNFA4_18_46441279[["εNFA4-18 scope{1, 1}"]]
eNFA4_19_59665636[\"εNFA4-19 scope[1]"/]
eNFA4_22_3647249[["εNFA4-22 char{1, 1}"]]
eNFA4_23_119818[\"εNFA4-23 char[1]"/]
eNFA4_26_26991739[["εNFA4-26 char{1, 1}"]]
eNFA4_27_1078370[\"εNFA4-27 char[1]"/]
eNFA4_30_38847270[["εNFA4-30 char{1, 1}"]]
eNFA4_31_9705331[\"εNFA4-31 char[1]"/]
eNFA4_34_59621178[["εNFA4-34 char{1, 1}"]]
eNFA4_35_20239120[\"εNFA4-35 char[1]"/]
eNFA4_38_64586077[["εNFA4-38 char{1, 1}"]]
eNFA4_39_47934352[\"εNFA4-39 char[1]"/]
eNFA4_42_64089786[["εNFA4-42 char{1, 1}"]]
eNFA4_43_28755990[\"εNFA4-43 char[1]"/]
eNFA4_46_23890167[["εNFA4-46 char{1, 1}"]]
eNFA4_47_57477322[\"εNFA4-47 char[1]"/]
eNFA4_50_56055356[["εNFA4-50 char{1, 1}"]]
eNFA4_51_62165703[["εNFA4-51 char[1]"]]
eNFA4_52_22620416[["εNFA4-52 scope{4, 4}"]]
eNFA4_53_2257160[["εNFA4-53 scope[1]"]]
eNFA4_54_24537816[["εNFA4-54 scope[2]"]]
eNFA4_55_19513753[["εNFA4-55 scope[3]"]]
eNFA4_56_14721100[\"εNFA4-56 scope[4]"/]
eNFA4_2_5300362 -.->|"ε"|eNFA4_0_26676172
eNFA4_2_5300362 -.->|"ε"|eNFA4_4_47703261
eNFA4_2_5300362 -.->|"ε"|eNFA4_6_38758958
eNFA4_2_5300362 -.->|"ε"|eNFA4_8_13286310
eNFA4_2_5300362 -.->|"ε"|eNFA4_12_52467932
eNFA4_2_5300362 -.->|"ε"|eNFA4_16_2449345
eNFA4_2_5300362 -.->|"ε"|eNFA4_20_22044110
eNFA4_2_5300362 -.->|"ε"|eNFA4_24_64179269
eNFA4_2_5300362 -.->|"ε"|eNFA4_28_40742509
eNFA4_2_5300362 -.->|"ε"|eNFA4_32_31138264
eNFA4_2_5300362 -.->|"ε"|eNFA4_36_11808928
eNFA4_2_5300362 -.->|"ε"|eNFA4_40_39171493
eNFA4_2_5300362 -.->|"ε"|eNFA4_44_16999120
eNFA4_2_5300362 -.->|"ε"|eNFA4_48_18774354
eNFA4_2_5300362 -->|"[#32;!#34;#35;%&',]"|eNFA4_1_62417850
eNFA4_2_5300362 -->|"-"|eNFA4_5_6570122
eNFA4_2_5300362 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|eNFA4_7_24889743
eNFA4_2_5300362 -->|"#92;"|eNFA4_9_65381042
eNFA4_2_5300362 -->|"#92;"|eNFA4_13_61373038
eNFA4_2_5300362 -->|"#92;"|eNFA4_17_5160142
eNFA4_2_5300362 -->|"#92;"|eNFA4_21_15318330
eNFA4_2_5300362 -->|"#92;"|eNFA4_25_32825243
eNFA4_2_5300362 -->|"#92;"|eNFA4_29_41599065
eNFA4_2_5300362 -->|"#92;"|eNFA4_33_14081115
eNFA4_2_5300362 -->|"#92;"|eNFA4_37_66828554
eNFA4_2_5300362 -->|"#92;"|eNFA4_41_44403789
eNFA4_2_5300362 -->|"#92;"|eNFA4_45_39937165
eNFA4_2_5300362 -->|"#92;"|eNFA4_49_13684913
eNFA4_0_26676172 -->|"[#32;!#34;#35;%&',]"|eNFA4_1_62417850
eNFA4_4_47703261 -->|"-"|eNFA4_5_6570122
eNFA4_6_38758958 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|eNFA4_7_24889743
eNFA4_8_13286310 -->|"#92;"|eNFA4_9_65381042
eNFA4_12_52467932 -->|"#92;"|eNFA4_13_61373038
eNFA4_16_2449345 -->|"#92;"|eNFA4_17_5160142
eNFA4_20_22044110 -->|"#92;"|eNFA4_21_15318330
eNFA4_24_64179269 -->|"#92;"|eNFA4_25_32825243
eNFA4_28_40742509 -->|"#92;"|eNFA4_29_41599065
eNFA4_32_31138264 -->|"#92;"|eNFA4_33_14081115
eNFA4_36_11808928 -->|"#92;"|eNFA4_37_66828554
eNFA4_40_39171493 -->|"#92;"|eNFA4_41_44403789
eNFA4_44_16999120 -->|"#92;"|eNFA4_45_39937165
eNFA4_48_18774354 -->|"#92;"|eNFA4_49_13684913
eNFA4_1_62417850 -.->|"ε"|eNFA4_3_59131099
eNFA4_1_62417850 -.->|"ε"|eNFA4_57_34736162
eNFA4_1_62417850 -.->|"ε"|eNFA4_58_44190002
eNFA4_5_6570122 -.->|"ε"|eNFA4_3_59131099
eNFA4_5_6570122 -.->|"ε"|eNFA4_57_34736162
eNFA4_5_6570122 -.->|"ε"|eNFA4_58_44190002
eNFA4_7_24889743 -.->|"ε"|eNFA4_3_59131099
eNFA4_7_24889743 -.->|"ε"|eNFA4_57_34736162
eNFA4_7_24889743 -.->|"ε"|eNFA4_58_44190002
eNFA4_9_65381042 -.->|"ε"|eNFA4_10_51558469
eNFA4_9_65381042 -->|"[$()*+]"|eNFA4_11_59560431
eNFA4_13_61373038 -.->|"ε"|eNFA4_14_15486430
eNFA4_13_61373038 -->|"-"|eNFA4_15_66281838
eNFA4_17_5160142 -.->|"ε"|eNFA4_18_46441279
eNFA4_17_5160142 -->|"[./<>?]"|eNFA4_19_59665636
eNFA4_21_15318330 -.->|"ε"|eNFA4_22_3647249
eNFA4_21_15318330 -->|"["|eNFA4_23_119818
eNFA4_25_32825243 -.->|"ε"|eNFA4_26_26991739
eNFA4_25_32825243 -->|"#92;"|eNFA4_27_1078370
eNFA4_29_41599065 -.->|"ε"|eNFA4_30_38847270
eNFA4_29_41599065 -->|"]"|eNFA4_31_9705331
eNFA4_33_14081115 -.->|"ε"|eNFA4_34_59621178
eNFA4_33_14081115 -->|"^"|eNFA4_35_20239120
eNFA4_37_66828554 -.->|"ε"|eNFA4_38_64586077
eNFA4_37_66828554 -->|"{"|eNFA4_39_47934352
eNFA4_41_44403789 -.->|"ε"|eNFA4_42_64089786
eNFA4_41_44403789 -->|"|"|eNFA4_43_28755990
eNFA4_45_39937165 -.->|"ε"|eNFA4_46_23890167
eNFA4_45_39937165 -->|"}"|eNFA4_47_57477322
eNFA4_49_13684913 -.->|"ε"|eNFA4_50_56055356
eNFA4_49_13684913 -->|"u"|eNFA4_51_62165703
eNFA4_3_59131099 -.->|"ε"|eNFA4_57_34736162
eNFA4_3_59131099 -.->|"ε"|eNFA4_58_44190002
eNFA4_57_34736162 -.->|"ε"|eNFA4_58_44190002
eNFA4_10_51558469 -->|"[$()*+]"|eNFA4_11_59560431
eNFA4_11_59560431 -.->|"ε"|eNFA4_3_59131099
eNFA4_11_59560431 -.->|"ε"|eNFA4_57_34736162
eNFA4_11_59560431 -.->|"ε"|eNFA4_58_44190002
eNFA4_14_15486430 -->|"-"|eNFA4_15_66281838
eNFA4_15_66281838 -.->|"ε"|eNFA4_3_59131099
eNFA4_15_66281838 -.->|"ε"|eNFA4_57_34736162
eNFA4_15_66281838 -.->|"ε"|eNFA4_58_44190002
eNFA4_18_46441279 -->|"[./<>?]"|eNFA4_19_59665636
eNFA4_19_59665636 -.->|"ε"|eNFA4_3_59131099
eNFA4_19_59665636 -.->|"ε"|eNFA4_57_34736162
eNFA4_19_59665636 -.->|"ε"|eNFA4_58_44190002
eNFA4_22_3647249 -->|"["|eNFA4_23_119818
eNFA4_23_119818 -.->|"ε"|eNFA4_3_59131099
eNFA4_23_119818 -.->|"ε"|eNFA4_57_34736162
eNFA4_23_119818 -.->|"ε"|eNFA4_58_44190002
eNFA4_26_26991739 -->|"#92;"|eNFA4_27_1078370
eNFA4_27_1078370 -.->|"ε"|eNFA4_3_59131099
eNFA4_27_1078370 -.->|"ε"|eNFA4_57_34736162
eNFA4_27_1078370 -.->|"ε"|eNFA4_58_44190002
eNFA4_30_38847270 -->|"]"|eNFA4_31_9705331
eNFA4_31_9705331 -.->|"ε"|eNFA4_3_59131099
eNFA4_31_9705331 -.->|"ε"|eNFA4_57_34736162
eNFA4_31_9705331 -.->|"ε"|eNFA4_58_44190002
eNFA4_34_59621178 -->|"^"|eNFA4_35_20239120
eNFA4_35_20239120 -.->|"ε"|eNFA4_3_59131099
eNFA4_35_20239120 -.->|"ε"|eNFA4_57_34736162
eNFA4_35_20239120 -.->|"ε"|eNFA4_58_44190002
eNFA4_38_64586077 -->|"{"|eNFA4_39_47934352
eNFA4_39_47934352 -.->|"ε"|eNFA4_3_59131099
eNFA4_39_47934352 -.->|"ε"|eNFA4_57_34736162
eNFA4_39_47934352 -.->|"ε"|eNFA4_58_44190002
eNFA4_42_64089786 -->|"|"|eNFA4_43_28755990
eNFA4_43_28755990 -.->|"ε"|eNFA4_3_59131099
eNFA4_43_28755990 -.->|"ε"|eNFA4_57_34736162
eNFA4_43_28755990 -.->|"ε"|eNFA4_58_44190002
eNFA4_46_23890167 -->|"}"|eNFA4_47_57477322
eNFA4_47_57477322 -.->|"ε"|eNFA4_3_59131099
eNFA4_47_57477322 -.->|"ε"|eNFA4_57_34736162
eNFA4_47_57477322 -.->|"ε"|eNFA4_58_44190002
eNFA4_50_56055356 -->|"u"|eNFA4_51_62165703
eNFA4_51_62165703 -.->|"ε"|eNFA4_52_22620416
eNFA4_51_62165703 -->|"[0-9a-fA-F]"|eNFA4_53_2257160
eNFA4_52_22620416 -->|"[0-9a-fA-F]"|eNFA4_53_2257160
eNFA4_53_2257160 -->|"[0-9a-fA-F]"|eNFA4_54_24537816
eNFA4_54_24537816 -->|"[0-9a-fA-F]"|eNFA4_55_19513753
eNFA4_55_19513753 -->|"[0-9a-fA-F]"|eNFA4_56_14721100
eNFA4_56_14721100 -.->|"ε"|eNFA4_3_59131099
eNFA4_56_14721100 -.->|"ε"|eNFA4_57_34736162
eNFA4_56_14721100 -.->|"ε"|eNFA4_58_44190002
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
NFA4_2_20314447("NFA4-2 regex start")
NFA4_1_34857543[\"NFA4-1 scope[1]"/]
NFA4_5_48612303[\"NFA4-5 char[1]"/]
NFA4_7_45282433[\"NFA4-7 scope[1]"/]
NFA4_9_4888719("NFA4-9 char[1]")
NFA4_13_43998472("NFA4-13 char[1]")
NFA4_17_60441935("NFA4-17 char[1]")
NFA4_21_7106508("NFA4-21 char[1]")
NFA4_25_63958576("NFA4-25 char[1]")
NFA4_29_38756276("NFA4-29 char[1]")
NFA4_33_13262169("NFA4-33 char[1]")
NFA4_37_52250665("NFA4-37 char[1]")
NFA4_41_493939("NFA4-41 char[1]")
NFA4_45_4445458("NFA4-45 char[1]")
NFA4_49_40009126("NFA4-49 char[1]")
NFA4_11_41406050[\"NFA4-11 scope[1]"/]
NFA4_15_37110132[\"NFA4-15 char[1]"/]
NFA4_19_65555736[\"NFA4-19 scope[1]"/]
NFA4_23_53130720[\"NFA4-23 char[1]"/]
NFA4_27_8414436[\"NFA4-27 char[1]"/]
NFA4_31_8621060[\"NFA4-31 char[1]"/]
NFA4_35_10480683[\"NFA4-35 char[1]"/]
NFA4_39_27217289[\"NFA4-39 char[1]"/]
NFA4_43_43629015[\"NFA4-43 char[1]"/]
NFA4_47_57116823[\"NFA4-47 char[1]"/]
NFA4_51_44289360("NFA4-51 char[1]")
NFA4_53_63059925("NFA4-53 scope[1]")
NFA4_54_30668413("NFA4-54 scope[2]")
NFA4_55_7580267("NFA4-55 scope[3]")
NFA4_56_1113543[\"NFA4-56 scope[4]"/]
NFA4_2_20314447 -->|"[#32;!#34;#35;%&',]"|NFA4_1_34857543
NFA4_2_20314447 -->|"-"|NFA4_5_48612303
NFA4_2_20314447 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|NFA4_7_45282433
NFA4_2_20314447 -->|"#92;"|NFA4_9_4888719
NFA4_2_20314447 -->|"#92;"|NFA4_13_43998472
NFA4_2_20314447 -->|"#92;"|NFA4_17_60441935
NFA4_2_20314447 -->|"#92;"|NFA4_21_7106508
NFA4_2_20314447 -->|"#92;"|NFA4_25_63958576
NFA4_2_20314447 -->|"#92;"|NFA4_29_38756276
NFA4_2_20314447 -->|"#92;"|NFA4_33_13262169
NFA4_2_20314447 -->|"#92;"|NFA4_37_52250665
NFA4_2_20314447 -->|"#92;"|NFA4_41_493939
NFA4_2_20314447 -->|"#92;"|NFA4_45_4445458
NFA4_2_20314447 -->|"#92;"|NFA4_49_40009126
NFA4_9_4888719 -->|"[$()*+]"|NFA4_11_41406050
NFA4_13_43998472 -->|"-"|NFA4_15_37110132
NFA4_17_60441935 -->|"[./<>?]"|NFA4_19_65555736
NFA4_21_7106508 -->|"["|NFA4_23_53130720
NFA4_25_63958576 -->|"#92;"|NFA4_27_8414436
NFA4_29_38756276 -->|"]"|NFA4_31_8621060
NFA4_33_13262169 -->|"^"|NFA4_35_10480683
NFA4_37_52250665 -->|"{"|NFA4_39_27217289
NFA4_41_493939 -->|"|"|NFA4_43_43629015
NFA4_45_4445458 -->|"}"|NFA4_47_57116823
NFA4_49_40009126 -->|"u"|NFA4_51_44289360
NFA4_51_44289360 -->|"[0-9a-fA-F]"|NFA4_53_63059925
NFA4_53_63059925 -->|"[0-9a-fA-F]"|NFA4_54_30668413
NFA4_54_30668413 -->|"[0-9a-fA-F]"|NFA4_55_7580267
NFA4_55_7580267 -->|"[0-9a-fA-F]"|NFA4_56_1113543
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
subgraph DFA0_-1134304930["DFA0 regex start"]
NFA4_2_20314447_0("NFA4-2 regex start")
end
subgraph DFA1_-852880014["DFA1 {1}"]
NFA4_1_34857543_1[\"NFA4-1 scope[1]"/]
end
subgraph DFA2_-1015268764["DFA2 {1}"]
NFA4_5_48612303_2[\"NFA4-5 char[1]"/]
end
subgraph DFA3_-661273213["DFA3 {1}"]
NFA4_7_45282433_3[\"NFA4-7 scope[1]"/]
end
subgraph DFA4_465433054["DFA4 {11}"]
NFA4_9_4888719_4("NFA4-9 char[1]")
NFA4_13_43998472_5("NFA4-13 char[1]")
NFA4_17_60441935_6("NFA4-17 char[1]")
NFA4_21_7106508_7("NFA4-21 char[1]")
NFA4_25_63958576_8("NFA4-25 char[1]")
NFA4_29_38756276_9("NFA4-29 char[1]")
NFA4_33_13262169_10("NFA4-33 char[1]")
NFA4_37_52250665_11("NFA4-37 char[1]")
NFA4_41_493939_12("NFA4-41 char[1]")
NFA4_45_4445458_13("NFA4-45 char[1]")
NFA4_49_40009126_14("NFA4-49 char[1]")
end
subgraph DFA5_-1257745381["DFA5 {1}"]
NFA4_11_41406050_15[\"NFA4-11 scope[1]"/]
end
subgraph DFA6_-486555991["DFA6 {1}"]
NFA4_15_37110132_16[\"NFA4-15 char[1]"/]
end
subgraph DFA7_-1059472282["DFA7 {1}"]
NFA4_19_65555736_17[\"NFA4-19 scope[1]"/]
end
subgraph DFA8_-1860060541["DFA8 {1}"]
NFA4_23_53130720_18[\"NFA4-23 char[1]"/]
end
subgraph DFA9_791826478["DFA9 {1}"]
NFA4_27_8414436_19[\"NFA4-27 char[1]"/]
end
subgraph DFA10_193951197["DFA10 {1}"]
NFA4_31_8621060_20[\"NFA4-31 char[1]"/]
end
subgraph DFA11_391264415["DFA11 {1}"]
NFA4_35_10480683_21[\"NFA4-35 char[1]"/]
end
subgraph DFA12_1394568260["DFA12 {1}"]
NFA4_39_27217289_22[\"NFA4-39 char[1]"/]
end
subgraph DFA13_-600974722["DFA13 {1}"]
NFA4_43_43629015_23[\"NFA4-43 char[1]"/]
end
subgraph DFA14_333706308["DFA14 {1}"]
NFA4_47_57116823_24[\"NFA4-47 char[1]"/]
end
subgraph DFA15_1889122233["DFA15 {1}"]
NFA4_51_44289360_25("NFA4-51 char[1]")
end
subgraph DFA16_-397926317["DFA16 {1}"]
NFA4_53_63059925_26("NFA4-53 scope[1]")
end
subgraph DFA17_1046942804["DFA17 {1}"]
NFA4_54_30668413_27("NFA4-54 scope[2]")
end
subgraph DFA18_-935411299["DFA18 {1}"]
NFA4_55_7580267_28("NFA4-55 scope[3]")
end
subgraph DFA19_420809800["DFA19 {1}"]
NFA4_56_1113543_29[\"NFA4-56 scope[4]"/]
end
DFA0_-1134304930 -->|"[#32;!#34;#35;%&',]"|DFA1_-852880014
DFA0_-1134304930 -->|"-"|DFA2_-1015268764
DFA0_-1134304930 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|DFA3_-661273213
DFA0_-1134304930 -->|"#92;"|DFA4_465433054
DFA4_465433054 -->|"[$()*+]"|DFA5_-1257745381
DFA4_465433054 -->|"-"|DFA6_-486555991
DFA4_465433054 -->|"[./<>?]"|DFA7_-1059472282
DFA4_465433054 -->|"["|DFA8_-1860060541
DFA4_465433054 -->|"#92;"|DFA9_791826478
DFA4_465433054 -->|"]"|DFA10_193951197
DFA4_465433054 -->|"^"|DFA11_391264415
DFA4_465433054 -->|"{"|DFA12_1394568260
DFA4_465433054 -->|"|"|DFA13_-600974722
DFA4_465433054 -->|"}"|DFA14_333706308
DFA4_465433054 -->|"u"|DFA15_1889122233
DFA15_1889122233 -->|"[0-9a-fA-F]"|DFA16_-397926317
DFA16_-397926317 -->|"[0-9a-fA-F]"|DFA17_1046942804
DFA17_1046942804 -->|"[0-9a-fA-F]"|DFA18_-935411299
DFA18_-935411299 -->|"[0-9a-fA-F]"|DFA19_420809800
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
DFA0_-1134304930{{"DFA0 regex start"}}
DFA1_-852880014[\"DFA1 {1}"/]
DFA2_-1015268764[\"DFA2 {1}"/]
DFA3_-661273213[\"DFA3 {1}"/]
DFA4_465433054{{"DFA4 {11}"}}
DFA5_-1257745381[\"DFA5 {1}"/]
DFA6_-486555991[\"DFA6 {1}"/]
DFA7_-1059472282[\"DFA7 {1}"/]
DFA8_-1860060541[\"DFA8 {1}"/]
DFA9_791826478[\"DFA9 {1}"/]
DFA10_193951197[\"DFA10 {1}"/]
DFA11_391264415[\"DFA11 {1}"/]
DFA12_1394568260[\"DFA12 {1}"/]
DFA13_-600974722[\"DFA13 {1}"/]
DFA14_333706308[\"DFA14 {1}"/]
DFA15_1889122233{{"DFA15 {1}"}}
DFA16_-397926317{{"DFA16 {1}"}}
DFA17_1046942804{{"DFA17 {1}"}}
DFA18_-935411299{{"DFA18 {1}"}}
DFA19_420809800[\"DFA19 {1}"/]
DFA0_-1134304930 -->|"[#32;!#34;#35;%&',]"|DFA1_-852880014
DFA0_-1134304930 -->|"-"|DFA2_-1015268764
DFA0_-1134304930 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|DFA3_-661273213
DFA0_-1134304930 -->|"#92;"|DFA4_465433054
DFA4_465433054 -->|"[$()*+]"|DFA5_-1257745381
DFA4_465433054 -->|"-"|DFA6_-486555991
DFA4_465433054 -->|"[./<>?]"|DFA7_-1059472282
DFA4_465433054 -->|"["|DFA8_-1860060541
DFA4_465433054 -->|"#92;"|DFA9_791826478
DFA4_465433054 -->|"]"|DFA10_193951197
DFA4_465433054 -->|"^"|DFA11_391264415
DFA4_465433054 -->|"{"|DFA12_1394568260
DFA4_465433054 -->|"|"|DFA13_-600974722
DFA4_465433054 -->|"}"|DFA14_333706308
DFA4_465433054 -->|"u"|DFA15_1889122233
DFA15_1889122233 -->|"[0-9a-fA-F]"|DFA16_-397926317
DFA16_-397926317 -->|"[0-9a-fA-F]"|DFA17_1046942804
DFA17_1046942804 -->|"[0-9a-fA-F]"|DFA18_-935411299
DFA18_-935411299 -->|"[0-9a-fA-F]"|DFA19_420809800
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
subgraph MiniDFA0_-2140797874["MiniDFA0 {1}"]
DFA0_-1134304930_0{{"DFA0 regex start"}}
end
subgraph MiniDFA6_-134990214["MiniDFA6 {1}"]
DFA1_-852880014_1[\"DFA1 {1}"/]
end
subgraph MiniDFA7_-543825291["MiniDFA7 {1}"]
DFA2_-1015268764_2[\"DFA2 {1}"/]
end
subgraph MiniDFA8_83014279["MiniDFA8 {1}"]
DFA3_-661273213_3[\"DFA3 {1}"/]
end
subgraph MiniDFA1_-1557613746["MiniDFA1 {1}"]
DFA4_465433054_4{{"DFA4 {11}"}}
end
subgraph MiniDFA9_1070519503["MiniDFA9 {1}"]
DFA5_-1257745381_5[\"DFA5 {1}"/]
end
subgraph MiniDFA10_-2021758811["MiniDFA10 {1}"]
DFA6_-486555991_6[\"DFA6 {1}"/]
end
subgraph MiniDFA11_498380207["MiniDFA11 {1}"]
DFA7_-1059472282_7[\"DFA7 {1}"/]
end
subgraph MiniDFA12_1217590171["MiniDFA12 {1}"]
DFA8_-1860060541_8[\"DFA8 {1}"/]
end
subgraph MiniDFA13_-473490921["MiniDFA13 {1}"]
DFA9_791826478_9[\"DFA9 {1}"/]
end
subgraph MiniDFA14_1156438374["MiniDFA14 {1}"]
DFA10_193951197_10[\"DFA10 {1}"/]
end
subgraph MiniDFA15_833463665["MiniDFA15 {1}"]
DFA11_391264415_11[\"DFA11 {1}"/]
end
subgraph MiniDFA16_-23365677["MiniDFA16 {1}"]
DFA12_1394568260_12[\"DFA12 {1}"/]
end
subgraph MiniDFA17_1825255294["MiniDFA17 {1}"]
DFA13_-600974722_13[\"DFA13 {1}"/]
end
subgraph MiniDFA18_1531528879["MiniDFA18 {1}"]
DFA14_333706308_14[\"DFA14 {1}"/]
end
subgraph MiniDFA2_456176345["MiniDFA2 {1}"]
DFA15_1889122233_15{{"DFA15 {1}"}}
end
subgraph MiniDFA3_-1333359305["MiniDFA3 {1}"]
DFA16_-397926317_16{{"DFA16 {1}"}}
end
subgraph MiniDFA4_1647679306["MiniDFA4 {1}"]
DFA17_1046942804_17{{"DFA17 {1}"}}
end
subgraph MiniDFA5_-1944334288["MiniDFA5 {1}"]
DFA18_-935411299_18{{"DFA18 {1}"}}
end
subgraph MiniDFA19_-119074490["MiniDFA19 {1}"]
DFA19_420809800_19[\"DFA19 {1}"/]
end
MiniDFA0_-2140797874 -->|"[#32;!#34;#35;%&',]"|MiniDFA6_-134990214
MiniDFA0_-2140797874 -->|"-"|MiniDFA7_-543825291
MiniDFA0_-2140797874 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|MiniDFA8_83014279
MiniDFA0_-2140797874 -->|"#92;"|MiniDFA1_-1557613746
MiniDFA1_-1557613746 -->|"[$()*+]"|MiniDFA9_1070519503
MiniDFA1_-1557613746 -->|"-"|MiniDFA10_-2021758811
MiniDFA1_-1557613746 -->|"[./<>?]"|MiniDFA11_498380207
MiniDFA1_-1557613746 -->|"["|MiniDFA12_1217590171
MiniDFA1_-1557613746 -->|"#92;"|MiniDFA13_-473490921
MiniDFA1_-1557613746 -->|"]"|MiniDFA14_1156438374
MiniDFA1_-1557613746 -->|"^"|MiniDFA15_833463665
MiniDFA1_-1557613746 -->|"{"|MiniDFA16_-23365677
MiniDFA1_-1557613746 -->|"|"|MiniDFA17_1825255294
MiniDFA1_-1557613746 -->|"}"|MiniDFA18_1531528879
MiniDFA1_-1557613746 -->|"u"|MiniDFA2_456176345
MiniDFA2_456176345 -->|"[0-9a-fA-F]"|MiniDFA3_-1333359305
MiniDFA3_-1333359305 -->|"[0-9a-fA-F]"|MiniDFA4_1647679306
MiniDFA4_1647679306 -->|"[0-9a-fA-F]"|MiniDFA5_-1944334288
MiniDFA5_-1944334288 -->|"[0-9a-fA-F]"|MiniDFA19_-119074490
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
MiniDFA0_-2140797874(["MiniDFA0 {1}"])
MiniDFA6_-134990214[\"MiniDFA6 {1}"/]
MiniDFA7_-543825291[\"MiniDFA7 {1}"/]
MiniDFA8_83014279[\"MiniDFA8 {1}"/]
MiniDFA1_-1557613746(["MiniDFA1 {1}"])
MiniDFA9_1070519503[\"MiniDFA9 {1}"/]
MiniDFA10_-2021758811[\"MiniDFA10 {1}"/]
MiniDFA11_498380207[\"MiniDFA11 {1}"/]
MiniDFA12_1217590171[\"MiniDFA12 {1}"/]
MiniDFA13_-473490921[\"MiniDFA13 {1}"/]
MiniDFA14_1156438374[\"MiniDFA14 {1}"/]
MiniDFA15_833463665[\"MiniDFA15 {1}"/]
MiniDFA16_-23365677[\"MiniDFA16 {1}"/]
MiniDFA17_1825255294[\"MiniDFA17 {1}"/]
MiniDFA18_1531528879[\"MiniDFA18 {1}"/]
MiniDFA2_456176345(["MiniDFA2 {1}"])
MiniDFA3_-1333359305(["MiniDFA3 {1}"])
MiniDFA4_1647679306(["MiniDFA4 {1}"])
MiniDFA5_-1944334288(["MiniDFA5 {1}"])
MiniDFA19_-119074490[\"MiniDFA19 {1}"/]
MiniDFA0_-2140797874 -->|"[#32;!#34;#35;%&',]"|MiniDFA6_-134990214
MiniDFA0_-2140797874 -->|"-"|MiniDFA7_-543825291
MiniDFA0_-2140797874 -->|"[0-9:;<=>@A-Z_#96;a-z~]"|MiniDFA8_83014279
MiniDFA0_-2140797874 -->|"#92;"|MiniDFA1_-1557613746
MiniDFA1_-1557613746 -->|"[$()*+]"|MiniDFA9_1070519503
MiniDFA1_-1557613746 -->|"-"|MiniDFA10_-2021758811
MiniDFA1_-1557613746 -->|"[./<>?]"|MiniDFA11_498380207
MiniDFA1_-1557613746 -->|"["|MiniDFA12_1217590171
MiniDFA1_-1557613746 -->|"#92;"|MiniDFA13_-473490921
MiniDFA1_-1557613746 -->|"]"|MiniDFA14_1156438374
MiniDFA1_-1557613746 -->|"^"|MiniDFA15_833463665
MiniDFA1_-1557613746 -->|"{"|MiniDFA16_-23365677
MiniDFA1_-1557613746 -->|"|"|MiniDFA17_1825255294
MiniDFA1_-1557613746 -->|"}"|MiniDFA18_1531528879
MiniDFA1_-1557613746 -->|"u"|MiniDFA2_456176345
MiniDFA2_456176345 -->|"[0-9a-fA-F]"|MiniDFA3_-1333359305
MiniDFA3_-1333359305 -->|"[0-9a-fA-F]"|MiniDFA4_1647679306
MiniDFA4_1647679306 -->|"[0-9a-fA-F]"|MiniDFA5_-1944334288
MiniDFA5_-1944334288 -->|"[0-9a-fA-F]"|MiniDFA19_-119074490
```
-------------------------------
