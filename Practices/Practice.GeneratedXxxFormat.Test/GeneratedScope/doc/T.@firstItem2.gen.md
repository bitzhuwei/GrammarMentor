# 'firstItem2'

pattern: `<'[^'>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~]`

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
eNFA2_9_27118016[["εNFA2-9 regex start"]]
eNFA2_0_49075689[["εNFA2-0 char{1, 1}"]]
eNFA2_11_42735556[["εNFA2-11 char{1, 1}"]]
eNFA2_15_39028025[["εNFA2-15 char{1, 1}"]]
eNFA2_19_15707907[["εNFA2-19 char{1, 1}"]]
eNFA2_23_7153442[["εNFA2-23 char{1, 1}"]]
eNFA2_27_64380982[["εNFA2-27 scope{1, 1}"]]
eNFA2_29_42557928[["εNFA2-29 char{1, 1}"]]
eNFA2_31_47477033[["εNFA2-31 char{1, 1}"]]
eNFA2_35_24640114[["εNFA2-35 char{1, 1}"]]
eNFA2_37_20434436[["εNFA2-37 char{1, 1}"]]
eNFA2_39_49692200[["εNFA2-39 char{1, 1}"]]
eNFA2_43_44576624[["εNFA2-43 scope{1, 1}"]]
eNFA2_1_66307108[["εNFA2-1 char[1]"]]
eNFA2_12_59893061[["εNFA2-12 char[1]"]]
eNFA2_16_2166644[["εNFA2-16 char[1]"]]
eNFA2_20_19499801[["εNFA2-20 char[1]"]]
eNFA2_24_41280485[["εNFA2-24 char[1]"]]
eNFA2_28_29387744[["εNFA2-28 scope[1]"]]
eNFA2_30_16932901[["εNFA2-30 char[1]"]]
eNFA2_32_35980049[["εNFA2-32 char[1]"]]
eNFA2_36_31597039[["εNFA2-36 char[1]"]]
eNFA2_38_15937898[["εNFA2-38 char[1]"]]
eNFA2_40_55384990[["εNFA2-40 char[1]"]]
eNFA2_44_15901331[["εNFA2-44 scope[1]"]]
eNFA2_2_28702870[["εNFA2-2 char{1, 1}"]]
eNFA2_13_56999240[["εNFA2-13 char{1, 1}"]]
eNFA2_17_43231119[["εNFA2-17 char{1, 1}"]]
eNFA2_21_53535755[["εNFA2-21 char{1, 1}"]]
eNFA2_25_12059749[["εNFA2-25 char{1, 1}"]]
eNFA2_10_18178385[["εNFA2-10 regex end"]]
eNFA2_33_2663365[["εNFA2-33 char{1, 1}"]]
eNFA2_41_62545577[["εNFA2-41 char{1, 1}"]]
eNFA2_3_33027006[["εNFA2-3 char[1]"]]
eNFA2_14_49345703[["εNFA2-14 char[1]"]]
eNFA2_18_41458150[["εNFA2-18 char[1]"]]
eNFA2_22_37579032[["εNFA2-22 char[1]"]]
eNFA2_26_2666976[["εNFA2-26 char[1]"]]
eNFA2_45_28807604[["εNFA2-45 post-regex start"]]
eNFA2_34_24002790[["εNFA2-34 char[1]"]]
eNFA2_42_14698523[["εNFA2-42 char[1]"]]
eNFA2_4_57941852[["εNFA2-4 scope{4, 4}"]]
eNFA2_46_64324564[\"εNFA2-46 post-regex end"/]
eNFA2_5_50620358[["εNFA2-5 scope[1]"]]
eNFA2_6_52930045[["εNFA2-6 scope[2]"]]
eNFA2_7_6608358[["εNFA2-7 scope[3]"]]
eNFA2_8_1576050[["εNFA2-8 scope[4]"]]
eNFA2_9_27118016 -.->|"ε"|eNFA2_0_49075689
eNFA2_9_27118016 -.->|"ε"|eNFA2_11_42735556
eNFA2_9_27118016 -.->|"ε"|eNFA2_15_39028025
eNFA2_9_27118016 -.->|"ε"|eNFA2_19_15707907
eNFA2_9_27118016 -.->|"ε"|eNFA2_23_7153442
eNFA2_9_27118016 -.->|"ε"|eNFA2_27_64380982
eNFA2_9_27118016 -.->|"ε"|eNFA2_29_42557928
eNFA2_9_27118016 -.->|"ε"|eNFA2_31_47477033
eNFA2_9_27118016 -.->|"ε"|eNFA2_35_24640114
eNFA2_9_27118016 -.->|"ε"|eNFA2_37_20434436
eNFA2_9_27118016 -.->|"ε"|eNFA2_39_49692200
eNFA2_9_27118016 -.->|"ε"|eNFA2_43_44576624
eNFA2_0_49075689 -->|"#92;"|eNFA2_1_66307108
eNFA2_11_42735556 -->|"#92;"|eNFA2_12_59893061
eNFA2_15_39028025 -->|"#92;"|eNFA2_16_2166644
eNFA2_19_15707907 -->|"#92;"|eNFA2_20_19499801
eNFA2_23_7153442 -->|"#92;"|eNFA2_24_41280485
eNFA2_27_64380982 -->|"[#32;-Z]"|eNFA2_28_29387744
eNFA2_29_42557928 -->|"["|eNFA2_30_16932901
eNFA2_31_47477033 -->|"#92;"|eNFA2_32_35980049
eNFA2_35_24640114 -->|"]"|eNFA2_36_31597039
eNFA2_37_20434436 -->|"^"|eNFA2_38_15937898
eNFA2_39_49692200 -->|"#92;"|eNFA2_40_55384990
eNFA2_43_44576624 -->|"[_-~]"|eNFA2_44_15901331
eNFA2_1_66307108 -.->|"ε"|eNFA2_2_28702870
eNFA2_12_59893061 -.->|"ε"|eNFA2_13_56999240
eNFA2_16_2166644 -.->|"ε"|eNFA2_17_43231119
eNFA2_20_19499801 -.->|"ε"|eNFA2_21_53535755
eNFA2_24_41280485 -.->|"ε"|eNFA2_25_12059749
eNFA2_28_29387744 -.->|"ε"|eNFA2_10_18178385
eNFA2_30_16932901 -.->|"ε"|eNFA2_10_18178385
eNFA2_32_35980049 -.->|"ε"|eNFA2_33_2663365
eNFA2_36_31597039 -.->|"ε"|eNFA2_10_18178385
eNFA2_38_15937898 -.->|"ε"|eNFA2_10_18178385
eNFA2_40_55384990 -.->|"ε"|eNFA2_41_62545577
eNFA2_44_15901331 -.->|"ε"|eNFA2_10_18178385
eNFA2_2_28702870 -->|"u"|eNFA2_3_33027006
eNFA2_13_56999240 -->|"t"|eNFA2_14_49345703
eNFA2_17_43231119 -->|"n"|eNFA2_18_41458150
eNFA2_21_53535755 -->|"r"|eNFA2_22_37579032
eNFA2_25_12059749 -->|"-"|eNFA2_26_2666976
eNFA2_10_18178385 -.->|"ε"|eNFA2_45_28807604
eNFA2_33_2663365 -->|"#92;"|eNFA2_34_24002790
eNFA2_41_62545577 -->|"^"|eNFA2_42_14698523
eNFA2_3_33027006 -.->|"ε"|eNFA2_4_57941852
eNFA2_14_49345703 -.->|"ε"|eNFA2_10_18178385
eNFA2_18_41458150 -.->|"ε"|eNFA2_10_18178385
eNFA2_22_37579032 -.->|"ε"|eNFA2_10_18178385
eNFA2_26_2666976 -.->|"ε"|eNFA2_10_18178385
eNFA2_45_28807604 -.->|"ε"|eNFA2_46_64324564
eNFA2_34_24002790 -.->|"ε"|eNFA2_10_18178385
eNFA2_42_14698523 -.->|"ε"|eNFA2_10_18178385
eNFA2_4_57941852 -->|"[0-9]"|eNFA2_5_50620358
eNFA2_5_50620358 -->|"[0-9]"|eNFA2_6_52930045
eNFA2_6_52930045 -->|"[0-9]"|eNFA2_7_6608358
eNFA2_7_6608358 -->|"[0-9]"|eNFA2_8_1576050
eNFA2_8_1576050 -.->|"ε"|eNFA2_10_18178385
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
eNFA2_9_8090458[["εNFA2-9 regex start"]]
eNFA2_0_51347342[["εNFA2-0 char{1, 1}"]]
eNFA2_11_5705260[["εNFA2-11 char{1, 1}"]]
eNFA2_15_59472897[["εNFA2-15 char{1, 1}"]]
eNFA2_19_65494031[["εNFA2-19 char{1, 1}"]]
eNFA2_23_52575367[["εNFA2-23 char{1, 1}"]]
eNFA2_27_3416260[["εNFA2-27 scope{1, 1}"]]
eNFA2_29_30746341[["εNFA2-29 char{1, 1}"]]
eNFA2_31_8281621[["εNFA2-31 char{1, 1}"]]
eNFA2_35_7425732[["εNFA2-35 char{1, 1}"]]
eNFA2_37_66831596[["εNFA2-37 char{1, 1}"]]
eNFA2_39_64613452[["εNFA2-39 char{1, 1}"]]
eNFA2_43_44650158[["εNFA2-43 scope{1, 1}"]]
eNFA2_1_65515007[["εNFA2-1 char[1]"]]
eNFA2_12_5115320[["εNFA2-12 char[1]"]]
eNFA2_16_11687737[["εNFA2-16 char[1]"]]
eNFA2_20_7182635[["εNFA2-20 char[1]"]]
eNFA2_24_44922549[["εNFA2-24 char[1]"]]
eNFA2_28_295929[\"εNFA2-28 scope[1]"/]
eNFA2_30_41428878[\"εNFA2-30 char[1]"/]
eNFA2_32_14847872[["εNFA2-32 char[1]"]]
eNFA2_36_23970293[\"εNFA2-36 char[1]"/]
eNFA2_38_14406049[\"εNFA2-38 char[1]"/]
eNFA2_40_61826996[["εNFA2-40 char[1]"]]
eNFA2_44_26039288[\"εNFA2-44 scope[1]"/]
eNFA2_2_52764152[["εNFA2-2 char{1, 1}"]]
eNFA2_3_41832375[["εNFA2-3 char[1]"]]
eNFA2_13_46037880[["εNFA2-13 char{1, 1}"]]
eNFA2_14_51714621[\"εNFA2-14 char[1]"/]
eNFA2_17_38080772[["εNFA2-17 char{1, 1}"]]
eNFA2_18_62778410[\"εNFA2-18 char[1]"/]
eNFA2_21_64643717[["εNFA2-21 char{1, 1}"]]
eNFA2_22_28134778[\"εNFA2-22 char[1]"/]
eNFA2_25_1649763[["εNFA2-25 char{1, 1}"]]
eNFA2_26_51886416[\"εNFA2-26 char[1]"/]
eNFA2_10_37315583[\"εNFA2-10 regex end"/]
eNFA2_45_41930743[\"εNFA2-45 post-regex start"/]
eNFA2_46_32979223[\"εNFA2-46 post-regex end"/]
eNFA2_33_66521989[["εNFA2-33 char{1, 1}"]]
eNFA2_34_42050167[\"εNFA2-34 char[1]"/]
eNFA2_41_19572052[["εNFA2-41 char{1, 1}"]]
eNFA2_42_42907186[\"εNFA2-42 char[1]"/]
eNFA2_4_40947060[["εNFA2-4 scope{4, 4}"]]
eNFA2_5_28377553[["εNFA2-5 scope[1]"]]
eNFA2_6_23432457[["εNFA2-6 scope[2]"]]
eNFA2_7_9565526[["εNFA2-7 scope[3]"]]
eNFA2_8_59475228[\"εNFA2-8 scope[4]"/]
eNFA2_9_8090458 -.->|"ε"|eNFA2_0_51347342
eNFA2_9_8090458 -.->|"ε"|eNFA2_11_5705260
eNFA2_9_8090458 -.->|"ε"|eNFA2_15_59472897
eNFA2_9_8090458 -.->|"ε"|eNFA2_19_65494031
eNFA2_9_8090458 -.->|"ε"|eNFA2_23_52575367
eNFA2_9_8090458 -.->|"ε"|eNFA2_27_3416260
eNFA2_9_8090458 -.->|"ε"|eNFA2_29_30746341
eNFA2_9_8090458 -.->|"ε"|eNFA2_31_8281621
eNFA2_9_8090458 -.->|"ε"|eNFA2_35_7425732
eNFA2_9_8090458 -.->|"ε"|eNFA2_37_66831596
eNFA2_9_8090458 -.->|"ε"|eNFA2_39_64613452
eNFA2_9_8090458 -.->|"ε"|eNFA2_43_44650158
eNFA2_9_8090458 -->|"#92;"|eNFA2_1_65515007
eNFA2_9_8090458 -->|"#92;"|eNFA2_12_5115320
eNFA2_9_8090458 -->|"#92;"|eNFA2_16_11687737
eNFA2_9_8090458 -->|"#92;"|eNFA2_20_7182635
eNFA2_9_8090458 -->|"#92;"|eNFA2_24_44922549
eNFA2_9_8090458 -->|"[#32;-Z]"|eNFA2_28_295929
eNFA2_9_8090458 -->|"["|eNFA2_30_41428878
eNFA2_9_8090458 -->|"#92;"|eNFA2_32_14847872
eNFA2_9_8090458 -->|"]"|eNFA2_36_23970293
eNFA2_9_8090458 -->|"^"|eNFA2_38_14406049
eNFA2_9_8090458 -->|"#92;"|eNFA2_40_61826996
eNFA2_9_8090458 -->|"[_-~]"|eNFA2_44_26039288
eNFA2_0_51347342 -->|"#92;"|eNFA2_1_65515007
eNFA2_11_5705260 -->|"#92;"|eNFA2_12_5115320
eNFA2_15_59472897 -->|"#92;"|eNFA2_16_11687737
eNFA2_19_65494031 -->|"#92;"|eNFA2_20_7182635
eNFA2_23_52575367 -->|"#92;"|eNFA2_24_44922549
eNFA2_27_3416260 -->|"[#32;-Z]"|eNFA2_28_295929
eNFA2_29_30746341 -->|"["|eNFA2_30_41428878
eNFA2_31_8281621 -->|"#92;"|eNFA2_32_14847872
eNFA2_35_7425732 -->|"]"|eNFA2_36_23970293
eNFA2_37_66831596 -->|"^"|eNFA2_38_14406049
eNFA2_39_64613452 -->|"#92;"|eNFA2_40_61826996
eNFA2_43_44650158 -->|"[_-~]"|eNFA2_44_26039288
eNFA2_1_65515007 -.->|"ε"|eNFA2_2_52764152
eNFA2_1_65515007 -->|"u"|eNFA2_3_41832375
eNFA2_12_5115320 -.->|"ε"|eNFA2_13_46037880
eNFA2_12_5115320 -->|"t"|eNFA2_14_51714621
eNFA2_16_11687737 -.->|"ε"|eNFA2_17_38080772
eNFA2_16_11687737 -->|"n"|eNFA2_18_62778410
eNFA2_20_7182635 -.->|"ε"|eNFA2_21_64643717
eNFA2_20_7182635 -->|"r"|eNFA2_22_28134778
eNFA2_24_44922549 -.->|"ε"|eNFA2_25_1649763
eNFA2_24_44922549 -->|"-"|eNFA2_26_51886416
eNFA2_28_295929 -.->|"ε"|eNFA2_10_37315583
eNFA2_28_295929 -.->|"ε"|eNFA2_45_41930743
eNFA2_28_295929 -.->|"ε"|eNFA2_46_32979223
eNFA2_30_41428878 -.->|"ε"|eNFA2_10_37315583
eNFA2_30_41428878 -.->|"ε"|eNFA2_45_41930743
eNFA2_30_41428878 -.->|"ε"|eNFA2_46_32979223
eNFA2_32_14847872 -.->|"ε"|eNFA2_33_66521989
eNFA2_32_14847872 -->|"#92;"|eNFA2_34_42050167
eNFA2_36_23970293 -.->|"ε"|eNFA2_10_37315583
eNFA2_36_23970293 -.->|"ε"|eNFA2_45_41930743
eNFA2_36_23970293 -.->|"ε"|eNFA2_46_32979223
eNFA2_38_14406049 -.->|"ε"|eNFA2_10_37315583
eNFA2_38_14406049 -.->|"ε"|eNFA2_45_41930743
eNFA2_38_14406049 -.->|"ε"|eNFA2_46_32979223
eNFA2_40_61826996 -.->|"ε"|eNFA2_41_19572052
eNFA2_40_61826996 -->|"^"|eNFA2_42_42907186
eNFA2_44_26039288 -.->|"ε"|eNFA2_10_37315583
eNFA2_44_26039288 -.->|"ε"|eNFA2_45_41930743
eNFA2_44_26039288 -.->|"ε"|eNFA2_46_32979223
eNFA2_2_52764152 -->|"u"|eNFA2_3_41832375
eNFA2_3_41832375 -.->|"ε"|eNFA2_4_40947060
eNFA2_3_41832375 -->|"[0-9]"|eNFA2_5_28377553
eNFA2_13_46037880 -->|"t"|eNFA2_14_51714621
eNFA2_14_51714621 -.->|"ε"|eNFA2_10_37315583
eNFA2_14_51714621 -.->|"ε"|eNFA2_45_41930743
eNFA2_14_51714621 -.->|"ε"|eNFA2_46_32979223
eNFA2_17_38080772 -->|"n"|eNFA2_18_62778410
eNFA2_18_62778410 -.->|"ε"|eNFA2_10_37315583
eNFA2_18_62778410 -.->|"ε"|eNFA2_45_41930743
eNFA2_18_62778410 -.->|"ε"|eNFA2_46_32979223
eNFA2_21_64643717 -->|"r"|eNFA2_22_28134778
eNFA2_22_28134778 -.->|"ε"|eNFA2_10_37315583
eNFA2_22_28134778 -.->|"ε"|eNFA2_45_41930743
eNFA2_22_28134778 -.->|"ε"|eNFA2_46_32979223
eNFA2_25_1649763 -->|"-"|eNFA2_26_51886416
eNFA2_26_51886416 -.->|"ε"|eNFA2_10_37315583
eNFA2_26_51886416 -.->|"ε"|eNFA2_45_41930743
eNFA2_26_51886416 -.->|"ε"|eNFA2_46_32979223
eNFA2_10_37315583 -.->|"ε"|eNFA2_45_41930743
eNFA2_10_37315583 -.->|"ε"|eNFA2_46_32979223
eNFA2_45_41930743 -.->|"ε"|eNFA2_46_32979223
eNFA2_33_66521989 -->|"#92;"|eNFA2_34_42050167
eNFA2_34_42050167 -.->|"ε"|eNFA2_10_37315583
eNFA2_34_42050167 -.->|"ε"|eNFA2_45_41930743
eNFA2_34_42050167 -.->|"ε"|eNFA2_46_32979223
eNFA2_41_19572052 -->|"^"|eNFA2_42_42907186
eNFA2_42_42907186 -.->|"ε"|eNFA2_10_37315583
eNFA2_42_42907186 -.->|"ε"|eNFA2_45_41930743
eNFA2_42_42907186 -.->|"ε"|eNFA2_46_32979223
eNFA2_4_40947060 -->|"[0-9]"|eNFA2_5_28377553
eNFA2_5_28377553 -->|"[0-9]"|eNFA2_6_23432457
eNFA2_6_23432457 -->|"[0-9]"|eNFA2_7_9565526
eNFA2_7_9565526 -->|"[0-9]"|eNFA2_8_59475228
eNFA2_8_59475228 -.->|"ε"|eNFA2_10_37315583
eNFA2_8_59475228 -.->|"ε"|eNFA2_45_41930743
eNFA2_8_59475228 -.->|"ε"|eNFA2_46_32979223
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
NFA2_9_54071387("NFA2-9 regex start")
NFA2_1_17706220("NFA2-1 char[1]")
NFA2_12_16880438("NFA2-12 char[1]")
NFA2_16_25138252("NFA2-16 char[1]")
NFA2_20_24917681("NFA2-20 char[1]")
NFA2_24_22932538("NFA2-24 char[1]")
NFA2_28_5066258[\"NFA2-28 scope[1]"/]
NFA2_30_45596329[\"NFA2-30 char[1]"/]
NFA2_32_7713785("NFA2-32 char[1]")
NFA2_36_2315201[\"NFA2-36 char[1]"/]
NFA2_38_20836811[\"NFA2-38 char[1]"/]
NFA2_40_53313577("NFA2-40 char[1]")
NFA2_44_10060146[\"NFA2-44 scope[1]"/]
NFA2_3_18980874("NFA2-3 char[1]")
NFA2_14_36610142[\"NFA2-14 char[1]"/]
NFA2_18_61055827[\"NFA2-18 char[1]"/]
NFA2_22_12631539[\"NFA2-22 char[1]"/]
NFA2_26_46574989[\"NFA2-26 char[1]"/]
NFA2_34_16521724[\"NFA2-34 char[1]"/]
NFA2_42_14477792[\"NFA2-42 char[1]"/]
NFA2_5_63191266("NFA2-5 scope[1]")
NFA2_6_31850483("NFA2-6 scope[2]")
NFA2_7_18218892("NFA2-7 scope[3]")
NFA2_8_29752302[\"NFA2-8 scope[4]"/]
NFA2_9_54071387 -->|"#92;"|NFA2_1_17706220
NFA2_9_54071387 -->|"#92;"|NFA2_12_16880438
NFA2_9_54071387 -->|"#92;"|NFA2_16_25138252
NFA2_9_54071387 -->|"#92;"|NFA2_20_24917681
NFA2_9_54071387 -->|"#92;"|NFA2_24_22932538
NFA2_9_54071387 -->|"[#32;-Z]"|NFA2_28_5066258
NFA2_9_54071387 -->|"["|NFA2_30_45596329
NFA2_9_54071387 -->|"#92;"|NFA2_32_7713785
NFA2_9_54071387 -->|"]"|NFA2_36_2315201
NFA2_9_54071387 -->|"^"|NFA2_38_20836811
NFA2_9_54071387 -->|"#92;"|NFA2_40_53313577
NFA2_9_54071387 -->|"[_-~]"|NFA2_44_10060146
NFA2_1_17706220 -->|"u"|NFA2_3_18980874
NFA2_12_16880438 -->|"t"|NFA2_14_36610142
NFA2_16_25138252 -->|"n"|NFA2_18_61055827
NFA2_20_24917681 -->|"r"|NFA2_22_12631539
NFA2_24_22932538 -->|"-"|NFA2_26_46574989
NFA2_32_7713785 -->|"#92;"|NFA2_34_16521724
NFA2_40_53313577 -->|"^"|NFA2_42_14477792
NFA2_3_18980874 -->|"[0-9]"|NFA2_5_63191266
NFA2_5_63191266 -->|"[0-9]"|NFA2_6_31850483
NFA2_6_31850483 -->|"[0-9]"|NFA2_7_18218892
NFA2_7_18218892 -->|"[0-9]"|NFA2_8_29752302
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
subgraph DFA0_1225214303["DFA0 regex start"]
NFA2_9_54071387_0("NFA2-9 regex start")
end
subgraph DFA1_255956390["DFA1 {7}"]
NFA2_1_17706220_1("NFA2-1 char[1]")
NFA2_12_16880438_2("NFA2-12 char[1]")
NFA2_16_25138252_3("NFA2-16 char[1]")
NFA2_20_24917681_4("NFA2-20 char[1]")
NFA2_24_22932538_5("NFA2-24 char[1]")
NFA2_32_7713785_6("NFA2-32 char[1]")
NFA2_40_53313577_7("NFA2-40 char[1]")
end
subgraph DFA2_994659007["DFA2 {1}"]
NFA2_28_5066258_8[\"NFA2-28 scope[1]"/]
end
subgraph DFA3_-1261969447["DFA3 {1}"]
NFA2_30_45596329_9[\"NFA2-30 char[1]"/]
end
subgraph DFA4_-85762123["DFA4 {1}"]
NFA2_36_2315201_10[\"NFA2-36 char[1]"/]
end
subgraph DFA5_593143648["DFA5 {1}"]
NFA2_38_20836811_11[\"NFA2-38 char[1]"/]
end
subgraph DFA6_-1661968460["DFA6 {1}"]
NFA2_44_10060146_12[\"NFA2-44 scope[1]"/]
end
subgraph DFA7_-210431188["DFA7 {1}"]
NFA2_3_18980874_13("NFA2-3 char[1]")
end
subgraph DFA8_-1459910078["DFA8 {1}"]
NFA2_14_36610142_14[\"NFA2-14 char[1]"/]
end
subgraph DFA9_1179629431["DFA9 {1}"]
NFA2_18_61055827_15[\"NFA2-18 char[1]"/]
end
subgraph DFA10_-1882927791["DFA10 {1}"]
NFA2_22_12631539_16[\"NFA2-22 char[1]"/]
end
subgraph DFA11_-1193643423["DFA11 {1}"]
NFA2_26_46574989_17[\"NFA2-26 char[1]"/]
end
subgraph DFA12_-97735452["DFA12 {1}"]
NFA2_34_16521724_18[\"NFA2-34 char[1]"/]
end
subgraph DFA13_401994931["DFA13 {1}"]
NFA2_42_14477792_19[\"NFA2-42 char[1]"/]
end
subgraph DFA14_-5423966["DFA14 {1}"]
NFA2_5_63191266_20("NFA2-5 scope[1]")
end
subgraph DFA15_636774088["DFA15 {1}"]
NFA2_6_31850483_21("NFA2-6 scope[2]")
end
subgraph DFA16_-1476465473["DFA16 {1}"]
NFA2_7_18218892_22("NFA2-7 scope[3]")
end
subgraph DFA17_-689046688["DFA17 {1}"]
NFA2_8_29752302_23[\"NFA2-8 scope[4]"/]
end
DFA0_1225214303 -->|"#92;"|DFA1_255956390
DFA0_1225214303 -->|"[#32;-Z]"|DFA2_994659007
DFA0_1225214303 -->|"["|DFA3_-1261969447
DFA0_1225214303 -->|"]"|DFA4_-85762123
DFA0_1225214303 -->|"^"|DFA5_593143648
DFA0_1225214303 -->|"[_-~]"|DFA6_-1661968460
DFA1_255956390 -->|"u"|DFA7_-210431188
DFA1_255956390 -->|"t"|DFA8_-1459910078
DFA1_255956390 -->|"n"|DFA9_1179629431
DFA1_255956390 -->|"r"|DFA10_-1882927791
DFA1_255956390 -->|"-"|DFA11_-1193643423
DFA1_255956390 -->|"#92;"|DFA12_-97735452
DFA1_255956390 -->|"^"|DFA13_401994931
DFA7_-210431188 -->|"[0-9]"|DFA14_-5423966
DFA14_-5423966 -->|"[0-9]"|DFA15_636774088
DFA15_636774088 -->|"[0-9]"|DFA16_-1476465473
DFA16_-1476465473 -->|"[0-9]"|DFA17_-689046688
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
DFA0_1225214303{{"DFA0 regex start"}}
DFA1_255956390{{"DFA1 {7}"}}
DFA2_994659007[\"DFA2 {1}"/]
DFA3_-1261969447[\"DFA3 {1}"/]
DFA4_-85762123[\"DFA4 {1}"/]
DFA5_593143648[\"DFA5 {1}"/]
DFA6_-1661968460[\"DFA6 {1}"/]
DFA7_-210431188{{"DFA7 {1}"}}
DFA8_-1459910078[\"DFA8 {1}"/]
DFA9_1179629431[\"DFA9 {1}"/]
DFA10_-1882927791[\"DFA10 {1}"/]
DFA11_-1193643423[\"DFA11 {1}"/]
DFA12_-97735452[\"DFA12 {1}"/]
DFA13_401994931[\"DFA13 {1}"/]
DFA14_-5423966{{"DFA14 {1}"}}
DFA15_636774088{{"DFA15 {1}"}}
DFA16_-1476465473{{"DFA16 {1}"}}
DFA17_-689046688[\"DFA17 {1}"/]
DFA0_1225214303 -->|"#92;"|DFA1_255956390
DFA0_1225214303 -->|"[#32;-Z]"|DFA2_994659007
DFA0_1225214303 -->|"["|DFA3_-1261969447
DFA0_1225214303 -->|"]"|DFA4_-85762123
DFA0_1225214303 -->|"^"|DFA5_593143648
DFA0_1225214303 -->|"[_-~]"|DFA6_-1661968460
DFA1_255956390 -->|"u"|DFA7_-210431188
DFA1_255956390 -->|"t"|DFA8_-1459910078
DFA1_255956390 -->|"n"|DFA9_1179629431
DFA1_255956390 -->|"r"|DFA10_-1882927791
DFA1_255956390 -->|"-"|DFA11_-1193643423
DFA1_255956390 -->|"#92;"|DFA12_-97735452
DFA1_255956390 -->|"^"|DFA13_401994931
DFA7_-210431188 -->|"[0-9]"|DFA14_-5423966
DFA14_-5423966 -->|"[0-9]"|DFA15_636774088
DFA15_636774088 -->|"[0-9]"|DFA16_-1476465473
DFA16_-1476465473 -->|"[0-9]"|DFA17_-689046688
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
subgraph MiniDFA0_410395011["MiniDFA0 {1}"]
DFA0_1225214303_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1195899432["MiniDFA1 {1}"]
DFA1_255956390_1{{"DFA1 {7}"}}
end
subgraph MiniDFA6_1327940834["MiniDFA6 {1}"]
DFA2_994659007_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_-1812651305["MiniDFA7 {1}"]
DFA3_-1261969447_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_-889640612["MiniDFA8 {1}"]
DFA4_-85762123_4[\"DFA4 {1}"/]
end
subgraph MiniDFA9_-1154242154["MiniDFA9 {1}"]
DFA5_593143648_5[\"DFA5 {1}"/]
end
subgraph MiniDFA10_-2022902141["MiniDFA10 {1}"]
DFA6_-1661968460_6[\"DFA6 {1}"/]
end
subgraph MiniDFA2_-1071378309["MiniDFA2 {1}"]
DFA7_-210431188_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_1043418402["MiniDFA11 {1}"]
DFA8_-1459910078_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_-816690951["MiniDFA12 {1}"]
DFA9_1179629431_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_1572460433["MiniDFA13 {1}"]
DFA10_-1882927791_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_2048054204["MiniDFA14 {1}"]
DFA11_-1193643423_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_84808236["MiniDFA15 {1}"]
DFA12_-97735452_12[\"DFA12 {1}"/]
end
subgraph MiniDFA16_2112177321["MiniDFA16 {1}"]
DFA13_401994931_13[\"DFA13 {1}"/]
end
subgraph MiniDFA3_730882331["MiniDFA3 {1}"]
DFA14_-5423966_14{{"DFA14 {1}"}}
end
subgraph MiniDFA4_-1094785365["MiniDFA4 {1}"]
DFA15_636774088_15{{"DFA15 {1}"}}
end
subgraph MiniDFA5_2020669982["MiniDFA5 {1}"]
DFA16_-1476465473_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_567877829["MiniDFA17 {1}"]
DFA17_-689046688_17[\"DFA17 {1}"/]
end
MiniDFA0_410395011 -->|"#92;"|MiniDFA1_1195899432
MiniDFA0_410395011 -->|"[#32;-Z]"|MiniDFA6_1327940834
MiniDFA0_410395011 -->|"["|MiniDFA7_-1812651305
MiniDFA0_410395011 -->|"]"|MiniDFA8_-889640612
MiniDFA0_410395011 -->|"^"|MiniDFA9_-1154242154
MiniDFA0_410395011 -->|"[_-~]"|MiniDFA10_-2022902141
MiniDFA1_1195899432 -->|"u"|MiniDFA2_-1071378309
MiniDFA1_1195899432 -->|"t"|MiniDFA11_1043418402
MiniDFA1_1195899432 -->|"n"|MiniDFA12_-816690951
MiniDFA1_1195899432 -->|"r"|MiniDFA13_1572460433
MiniDFA1_1195899432 -->|"-"|MiniDFA14_2048054204
MiniDFA1_1195899432 -->|"#92;"|MiniDFA15_84808236
MiniDFA1_1195899432 -->|"^"|MiniDFA16_2112177321
MiniDFA2_-1071378309 -->|"[0-9]"|MiniDFA3_730882331
MiniDFA3_730882331 -->|"[0-9]"|MiniDFA4_-1094785365
MiniDFA4_-1094785365 -->|"[0-9]"|MiniDFA5_2020669982
MiniDFA5_2020669982 -->|"[0-9]"|MiniDFA17_567877829
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
MiniDFA0_410395011(["MiniDFA0 {1}"])
MiniDFA1_1195899432(["MiniDFA1 {1}"])
MiniDFA6_1327940834[\"MiniDFA6 {1}"/]
MiniDFA7_-1812651305[\"MiniDFA7 {1}"/]
MiniDFA8_-889640612[\"MiniDFA8 {1}"/]
MiniDFA9_-1154242154[\"MiniDFA9 {1}"/]
MiniDFA10_-2022902141[\"MiniDFA10 {1}"/]
MiniDFA2_-1071378309(["MiniDFA2 {1}"])
MiniDFA11_1043418402[\"MiniDFA11 {1}"/]
MiniDFA12_-816690951[\"MiniDFA12 {1}"/]
MiniDFA13_1572460433[\"MiniDFA13 {1}"/]
MiniDFA14_2048054204[\"MiniDFA14 {1}"/]
MiniDFA15_84808236[\"MiniDFA15 {1}"/]
MiniDFA16_2112177321[\"MiniDFA16 {1}"/]
MiniDFA3_730882331(["MiniDFA3 {1}"])
MiniDFA4_-1094785365(["MiniDFA4 {1}"])
MiniDFA5_2020669982(["MiniDFA5 {1}"])
MiniDFA17_567877829[\"MiniDFA17 {1}"/]
MiniDFA0_410395011 -->|"#92;"|MiniDFA1_1195899432
MiniDFA0_410395011 -->|"[#32;-Z]"|MiniDFA6_1327940834
MiniDFA0_410395011 -->|"["|MiniDFA7_-1812651305
MiniDFA0_410395011 -->|"]"|MiniDFA8_-889640612
MiniDFA0_410395011 -->|"^"|MiniDFA9_-1154242154
MiniDFA0_410395011 -->|"[_-~]"|MiniDFA10_-2022902141
MiniDFA1_1195899432 -->|"u"|MiniDFA2_-1071378309
MiniDFA1_1195899432 -->|"t"|MiniDFA11_1043418402
MiniDFA1_1195899432 -->|"n"|MiniDFA12_-816690951
MiniDFA1_1195899432 -->|"r"|MiniDFA13_1572460433
MiniDFA1_1195899432 -->|"-"|MiniDFA14_2048054204
MiniDFA1_1195899432 -->|"#92;"|MiniDFA15_84808236
MiniDFA1_1195899432 -->|"^"|MiniDFA16_2112177321
MiniDFA2_-1071378309 -->|"[0-9]"|MiniDFA3_730882331
MiniDFA3_730882331 -->|"[0-9]"|MiniDFA4_-1094785365
MiniDFA4_-1094785365 -->|"[0-9]"|MiniDFA5_2020669982
MiniDFA5_2020669982 -->|"[0-9]"|MiniDFA17_567877829
```
-------------------------------
