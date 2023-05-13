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
eNFA2_9_37822080[["εNFA2-9 regex start"]]
eNFA2_0_43689614[["εNFA2-0 char{1, 1}"]]
eNFA2_11_4854401[["εNFA2-11 char{1, 1}"]]
eNFA2_15_57662206[["εNFA2-15 char{1, 1}"]]
eNFA2_19_49197812[["εNFA2-19 char{1, 1}"]]
eNFA2_23_40127128[["εNFA2-23 char{1, 1}"]]
eNFA2_27_25599835[["εNFA2-27 scope{1, 1}"]]
eNFA2_29_29071926[["εNFA2-29 char{1, 1}"]]
eNFA2_31_60320746[["εNFA2-31 char{1, 1}"]]
eNFA2_35_6015809[["εNFA2-35 char{1, 1}"]]
eNFA2_37_54142282[["εNFA2-37 char{1, 1}"]]
eNFA2_39_17518496[["εNFA2-39 char{1, 1}"]]
eNFA2_43_23448739[["εNFA2-43 scope{1, 1}"]]
eNFA2_1_34077026[["εNFA2-1 char[1]"]]
eNFA2_12_38257785[["εNFA2-12 char[1]"]]
eNFA2_16_8775751[["εNFA2-16 char[1]"]]
eNFA2_20_11872901[["εNFA2-20 char[1]"]]
eNFA2_24_39747253[["εNFA2-24 char[1]"]]
eNFA2_28_40326203[["εNFA2-28 scope[1]"]]
eNFA2_30_57664664[["εNFA2-30 char[1]"]]
eNFA2_32_22180958[["εNFA2-32 char[1]"]]
eNFA2_36_45197019[["εNFA2-36 char[1]"]]
eNFA2_38_4119989[["εNFA2-38 char[1]"]]
eNFA2_40_65410899[["εNFA2-40 char[1]"]]
eNFA2_44_65283674[["εNFA2-44 scope[1]"]]
eNFA2_2_51827179[["εNFA2-2 char{1, 1}"]]
eNFA2_13_63791433[["εNFA2-13 char{1, 1}"]]
eNFA2_17_37251989[["εNFA2-17 char{1, 1}"]]
eNFA2_21_66832448[["εNFA2-21 char{1, 1}"]]
eNFA2_25_64621123[["εNFA2-25 char{1, 1}"]]
eNFA2_10_49219931[["εNFA2-10 regex end"]]
eNFA2_33_52497613[["εNFA2-33 char{1, 1}"]]
eNFA2_41_18707649[["εNFA2-41 char{1, 1}"]]
eNFA2_3_38924562[["εNFA2-3 char[1]"]]
eNFA2_14_11614261[["εNFA2-14 char[1]"]]
eNFA2_18_37419486[["εNFA2-18 char[1]"]]
eNFA2_22_1231062[["εNFA2-22 char[1]"]]
eNFA2_26_11079565[["εNFA2-26 char[1]"]]
eNFA2_45_14776741[["εNFA2-45 post-regex start"]]
eNFA2_34_32607229[["εNFA2-34 char[1]"]]
eNFA2_42_25029605[["εNFA2-42 char[1]"]]
eNFA2_4_65881812[["εNFA2-4 scope{4, 4}"]]
eNFA2_46_21399062[\"εNFA2-46 post-regex end"/]
eNFA2_5_30660320[["εNFA2-5 scope[1]"]]
eNFA2_6_7507432[["εNFA2-6 scope[2]"]]
eNFA2_7_458029[["εNFA2-7 scope[3]"]]
eNFA2_8_3850157[["εNFA2-8 scope[4]"]]
eNFA2_9_37822080 -.->|"ε"|eNFA2_0_43689614
eNFA2_9_37822080 -.->|"ε"|eNFA2_11_4854401
eNFA2_9_37822080 -.->|"ε"|eNFA2_15_57662206
eNFA2_9_37822080 -.->|"ε"|eNFA2_19_49197812
eNFA2_9_37822080 -.->|"ε"|eNFA2_23_40127128
eNFA2_9_37822080 -.->|"ε"|eNFA2_27_25599835
eNFA2_9_37822080 -.->|"ε"|eNFA2_29_29071926
eNFA2_9_37822080 -.->|"ε"|eNFA2_31_60320746
eNFA2_9_37822080 -.->|"ε"|eNFA2_35_6015809
eNFA2_9_37822080 -.->|"ε"|eNFA2_37_54142282
eNFA2_9_37822080 -.->|"ε"|eNFA2_39_17518496
eNFA2_9_37822080 -.->|"ε"|eNFA2_43_23448739
eNFA2_0_43689614 -->|"#92;"|eNFA2_1_34077026
eNFA2_11_4854401 -->|"#92;"|eNFA2_12_38257785
eNFA2_15_57662206 -->|"#92;"|eNFA2_16_8775751
eNFA2_19_49197812 -->|"#92;"|eNFA2_20_11872901
eNFA2_23_40127128 -->|"#92;"|eNFA2_24_39747253
eNFA2_27_25599835 -->|"[#32;-Z]"|eNFA2_28_40326203
eNFA2_29_29071926 -->|"["|eNFA2_30_57664664
eNFA2_31_60320746 -->|"#92;"|eNFA2_32_22180958
eNFA2_35_6015809 -->|"]"|eNFA2_36_45197019
eNFA2_37_54142282 -->|"^"|eNFA2_38_4119989
eNFA2_39_17518496 -->|"#92;"|eNFA2_40_65410899
eNFA2_43_23448739 -->|"[_-~]"|eNFA2_44_65283674
eNFA2_1_34077026 -.->|"ε"|eNFA2_2_51827179
eNFA2_12_38257785 -.->|"ε"|eNFA2_13_63791433
eNFA2_16_8775751 -.->|"ε"|eNFA2_17_37251989
eNFA2_20_11872901 -.->|"ε"|eNFA2_21_66832448
eNFA2_24_39747253 -.->|"ε"|eNFA2_25_64621123
eNFA2_28_40326203 -.->|"ε"|eNFA2_10_49219931
eNFA2_30_57664664 -.->|"ε"|eNFA2_10_49219931
eNFA2_32_22180958 -.->|"ε"|eNFA2_33_52497613
eNFA2_36_45197019 -.->|"ε"|eNFA2_10_49219931
eNFA2_38_4119989 -.->|"ε"|eNFA2_10_49219931
eNFA2_40_65410899 -.->|"ε"|eNFA2_41_18707649
eNFA2_44_65283674 -.->|"ε"|eNFA2_10_49219931
eNFA2_2_51827179 -->|"u"|eNFA2_3_38924562
eNFA2_13_63791433 -->|"t"|eNFA2_14_11614261
eNFA2_17_37251989 -->|"n"|eNFA2_18_37419486
eNFA2_21_66832448 -->|"r"|eNFA2_22_1231062
eNFA2_25_64621123 -->|"-"|eNFA2_26_11079565
eNFA2_10_49219931 -.->|"ε"|eNFA2_45_14776741
eNFA2_33_52497613 -->|"#92;"|eNFA2_34_32607229
eNFA2_41_18707649 -->|"^"|eNFA2_42_25029605
eNFA2_3_38924562 -.->|"ε"|eNFA2_4_65881812
eNFA2_14_11614261 -.->|"ε"|eNFA2_10_49219931
eNFA2_18_37419486 -.->|"ε"|eNFA2_10_49219931
eNFA2_22_1231062 -.->|"ε"|eNFA2_10_49219931
eNFA2_26_11079565 -.->|"ε"|eNFA2_10_49219931
eNFA2_45_14776741 -.->|"ε"|eNFA2_46_21399062
eNFA2_34_32607229 -.->|"ε"|eNFA2_10_49219931
eNFA2_42_25029605 -.->|"ε"|eNFA2_10_49219931
eNFA2_4_65881812 -->|"[0-9]"|eNFA2_5_30660320
eNFA2_5_30660320 -->|"[0-9]"|eNFA2_6_7507432
eNFA2_6_7507432 -->|"[0-9]"|eNFA2_7_458029
eNFA2_7_458029 -->|"[0-9]"|eNFA2_8_3850157
eNFA2_8_3850157 -.->|"ε"|eNFA2_10_49219931
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
eNFA2_9_55301474[["εNFA2-9 regex start"]]
eNFA2_0_50234423[["εNFA2-0 char{1, 1}"]]
eNFA2_11_27951223[["εNFA2-11 char{1, 1}"]]
eNFA2_15_49456625[["εNFA2-15 char{1, 1}"]]
eNFA2_19_42456448[["εNFA2-19 char{1, 1}"]]
eNFA2_23_46563716[["εNFA2-23 char{1, 1}"]]
eNFA2_27_16420262[["εNFA2-27 scope{1, 1}"]]
eNFA2_29_13564631[["εNFA2-29 char{1, 1}"]]
eNFA2_31_54972816[["εNFA2-31 char{1, 1}"]]
eNFA2_35_24993298[["εNFA2-35 char{1, 1}"]]
eNFA2_37_23613094[["εNFA2-37 char{1, 1}"]]
eNFA2_39_11191262[["εNFA2-39 char{1, 1}"]]
eNFA2_43_33612498[["εNFA2-43 scope{1, 1}"]]
eNFA2_1_37100378[["εNFA2-1 char[1]"]]
eNFA2_12_52340623[["εNFA2-12 char[1]"]]
eNFA2_16_11732085[["εNFA2-16 char[1]"]]
eNFA2_20_10774835[["εNFA2-20 char[1]"]]
eNFA2_24_346482[["εNFA2-24 char[1]"]]
eNFA2_28_65485391[\"εNFA2-28 scope[1]"/]
eNFA2_30_44719199[\"εNFA2-30 char[1]"/]
eNFA2_32_28065114[["εNFA2-32 char[1]"]]
eNFA2_36_2716472[\"εNFA2-36 char[1]"/]
eNFA2_38_24448249[\"εNFA2-38 char[1]"/]
eNFA2_40_58681746[["εNFA2-40 char[1]"]]
eNFA2_44_34151113[\"εNFA2-44 scope[1]"/]
eNFA2_2_65467948[["εNFA2-2 char{1, 1}"]]
eNFA2_3_30646615[["εNFA2-3 char[1]"]]
eNFA2_13_1303565[["εNFA2-13 char{1, 1}"]]
eNFA2_14_56065398[\"εNFA2-14 char[1]"/]
eNFA2_17_38479906[["εNFA2-17 char{1, 1}"]]
eNFA2_18_34826542[\"εNFA2-18 char[1]"/]
eNFA2_21_29864659[["εNFA2-21 char{1, 1}"]]
eNFA2_22_45003428[\"εNFA2-22 char[1]"/]
eNFA2_25_3118346[["εNFA2-25 char{1, 1}"]]
eNFA2_26_2377673[\"εNFA2-26 char[1]"/]
eNFA2_10_66928478[\"εNFA2-10 regex end"/]
eNFA2_45_55600962[\"εNFA2-45 post-regex start"/]
eNFA2_46_66456751[\"εNFA2-46 post-regex end"/]
eNFA2_33_51259436[["εNFA2-33 char{1, 1}"]]
eNFA2_34_58373837[\"εNFA2-34 char[1]"/]
eNFA2_41_58373667[["εNFA2-41 char{1, 1}"]]
eNFA2_42_55602485[\"εNFA2-42 char[1]"/]
eNFA2_4_7384083[["εNFA2-4 scope{4, 4}"]]
eNFA2_5_61239852[["εNFA2-5 scope[1]"]]
eNFA2_6_53868268[["εNFA2-6 scope[2]"]]
eNFA2_7_15052370[["εNFA2-7 scope[3]"]]
eNFA2_8_4122264[\"εNFA2-8 scope[4]"/]
eNFA2_9_55301474 -.->|"ε"|eNFA2_0_50234423
eNFA2_9_55301474 -.->|"ε"|eNFA2_11_27951223
eNFA2_9_55301474 -.->|"ε"|eNFA2_15_49456625
eNFA2_9_55301474 -.->|"ε"|eNFA2_19_42456448
eNFA2_9_55301474 -.->|"ε"|eNFA2_23_46563716
eNFA2_9_55301474 -.->|"ε"|eNFA2_27_16420262
eNFA2_9_55301474 -.->|"ε"|eNFA2_29_13564631
eNFA2_9_55301474 -.->|"ε"|eNFA2_31_54972816
eNFA2_9_55301474 -.->|"ε"|eNFA2_35_24993298
eNFA2_9_55301474 -.->|"ε"|eNFA2_37_23613094
eNFA2_9_55301474 -.->|"ε"|eNFA2_39_11191262
eNFA2_9_55301474 -.->|"ε"|eNFA2_43_33612498
eNFA2_9_55301474 -->|"#92;"|eNFA2_1_37100378
eNFA2_9_55301474 -->|"#92;"|eNFA2_12_52340623
eNFA2_9_55301474 -->|"#92;"|eNFA2_16_11732085
eNFA2_9_55301474 -->|"#92;"|eNFA2_20_10774835
eNFA2_9_55301474 -->|"#92;"|eNFA2_24_346482
eNFA2_9_55301474 -->|"[#32;-Z]"|eNFA2_28_65485391
eNFA2_9_55301474 -->|"["|eNFA2_30_44719199
eNFA2_9_55301474 -->|"#92;"|eNFA2_32_28065114
eNFA2_9_55301474 -->|"]"|eNFA2_36_2716472
eNFA2_9_55301474 -->|"^"|eNFA2_38_24448249
eNFA2_9_55301474 -->|"#92;"|eNFA2_40_58681746
eNFA2_9_55301474 -->|"[_-~]"|eNFA2_44_34151113
eNFA2_0_50234423 -->|"#92;"|eNFA2_1_37100378
eNFA2_11_27951223 -->|"#92;"|eNFA2_12_52340623
eNFA2_15_49456625 -->|"#92;"|eNFA2_16_11732085
eNFA2_19_42456448 -->|"#92;"|eNFA2_20_10774835
eNFA2_23_46563716 -->|"#92;"|eNFA2_24_346482
eNFA2_27_16420262 -->|"[#32;-Z]"|eNFA2_28_65485391
eNFA2_29_13564631 -->|"["|eNFA2_30_44719199
eNFA2_31_54972816 -->|"#92;"|eNFA2_32_28065114
eNFA2_35_24993298 -->|"]"|eNFA2_36_2716472
eNFA2_37_23613094 -->|"^"|eNFA2_38_24448249
eNFA2_39_11191262 -->|"#92;"|eNFA2_40_58681746
eNFA2_43_33612498 -->|"[_-~]"|eNFA2_44_34151113
eNFA2_1_37100378 -.->|"ε"|eNFA2_2_65467948
eNFA2_1_37100378 -->|"u"|eNFA2_3_30646615
eNFA2_12_52340623 -.->|"ε"|eNFA2_13_1303565
eNFA2_12_52340623 -->|"t"|eNFA2_14_56065398
eNFA2_16_11732085 -.->|"ε"|eNFA2_17_38479906
eNFA2_16_11732085 -->|"n"|eNFA2_18_34826542
eNFA2_20_10774835 -.->|"ε"|eNFA2_21_29864659
eNFA2_20_10774835 -->|"r"|eNFA2_22_45003428
eNFA2_24_346482 -.->|"ε"|eNFA2_25_3118346
eNFA2_24_346482 -->|"-"|eNFA2_26_2377673
eNFA2_28_65485391 -.->|"ε"|eNFA2_10_66928478
eNFA2_28_65485391 -.->|"ε"|eNFA2_45_55600962
eNFA2_28_65485391 -.->|"ε"|eNFA2_46_66456751
eNFA2_30_44719199 -.->|"ε"|eNFA2_10_66928478
eNFA2_30_44719199 -.->|"ε"|eNFA2_45_55600962
eNFA2_30_44719199 -.->|"ε"|eNFA2_46_66456751
eNFA2_32_28065114 -.->|"ε"|eNFA2_33_51259436
eNFA2_32_28065114 -->|"#92;"|eNFA2_34_58373837
eNFA2_36_2716472 -.->|"ε"|eNFA2_10_66928478
eNFA2_36_2716472 -.->|"ε"|eNFA2_45_55600962
eNFA2_36_2716472 -.->|"ε"|eNFA2_46_66456751
eNFA2_38_24448249 -.->|"ε"|eNFA2_10_66928478
eNFA2_38_24448249 -.->|"ε"|eNFA2_45_55600962
eNFA2_38_24448249 -.->|"ε"|eNFA2_46_66456751
eNFA2_40_58681746 -.->|"ε"|eNFA2_41_58373667
eNFA2_40_58681746 -->|"^"|eNFA2_42_55602485
eNFA2_44_34151113 -.->|"ε"|eNFA2_10_66928478
eNFA2_44_34151113 -.->|"ε"|eNFA2_45_55600962
eNFA2_44_34151113 -.->|"ε"|eNFA2_46_66456751
eNFA2_2_65467948 -->|"u"|eNFA2_3_30646615
eNFA2_3_30646615 -.->|"ε"|eNFA2_4_7384083
eNFA2_3_30646615 -->|"[0-9]"|eNFA2_5_61239852
eNFA2_13_1303565 -->|"t"|eNFA2_14_56065398
eNFA2_14_56065398 -.->|"ε"|eNFA2_10_66928478
eNFA2_14_56065398 -.->|"ε"|eNFA2_45_55600962
eNFA2_14_56065398 -.->|"ε"|eNFA2_46_66456751
eNFA2_17_38479906 -->|"n"|eNFA2_18_34826542
eNFA2_18_34826542 -.->|"ε"|eNFA2_10_66928478
eNFA2_18_34826542 -.->|"ε"|eNFA2_45_55600962
eNFA2_18_34826542 -.->|"ε"|eNFA2_46_66456751
eNFA2_21_29864659 -->|"r"|eNFA2_22_45003428
eNFA2_22_45003428 -.->|"ε"|eNFA2_10_66928478
eNFA2_22_45003428 -.->|"ε"|eNFA2_45_55600962
eNFA2_22_45003428 -.->|"ε"|eNFA2_46_66456751
eNFA2_25_3118346 -->|"-"|eNFA2_26_2377673
eNFA2_26_2377673 -.->|"ε"|eNFA2_10_66928478
eNFA2_26_2377673 -.->|"ε"|eNFA2_45_55600962
eNFA2_26_2377673 -.->|"ε"|eNFA2_46_66456751
eNFA2_10_66928478 -.->|"ε"|eNFA2_45_55600962
eNFA2_10_66928478 -.->|"ε"|eNFA2_46_66456751
eNFA2_45_55600962 -.->|"ε"|eNFA2_46_66456751
eNFA2_33_51259436 -->|"#92;"|eNFA2_34_58373837
eNFA2_34_58373837 -.->|"ε"|eNFA2_10_66928478
eNFA2_34_58373837 -.->|"ε"|eNFA2_45_55600962
eNFA2_34_58373837 -.->|"ε"|eNFA2_46_66456751
eNFA2_41_58373667 -->|"^"|eNFA2_42_55602485
eNFA2_42_55602485 -.->|"ε"|eNFA2_10_66928478
eNFA2_42_55602485 -.->|"ε"|eNFA2_45_55600962
eNFA2_42_55602485 -.->|"ε"|eNFA2_46_66456751
eNFA2_4_7384083 -->|"[0-9]"|eNFA2_5_61239852
eNFA2_5_61239852 -->|"[0-9]"|eNFA2_6_53868268
eNFA2_6_53868268 -->|"[0-9]"|eNFA2_7_15052370
eNFA2_7_15052370 -->|"[0-9]"|eNFA2_8_4122264
eNFA2_8_4122264 -.->|"ε"|eNFA2_10_66928478
eNFA2_8_4122264 -.->|"ε"|eNFA2_45_55600962
eNFA2_8_4122264 -.->|"ε"|eNFA2_46_66456751
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
NFA2_9_14287764("NFA2-9 regex start")
NFA2_1_16458221("NFA2-1 char[1]")
NFA2_12_61481014("NFA2-12 char[1]")
NFA2_16_13906265("NFA2-16 char[1]")
NFA2_20_58047523("NFA2-20 char[1]")
NFA2_24_52665660("NFA2-24 char[1]")
NFA2_28_4228893[\"NFA2-28 scope[1]"/]
NFA2_30_38060039[\"NFA2-30 char[1]"/]
NFA2_32_6996035("NFA2-32 char[1]")
NFA2_36_62964323[\"NFA2-36 char[1]"/]
NFA2_38_29807999[\"NFA2-38 char[1]"/]
NFA2_40_66945399("NFA2-40 char[1]")
NFA2_44_65637686[\"NFA2-44 scope[1]"/]
NFA2_3_1253610("NFA2-3 char[1]")
NFA2_14_11282491[\"NFA2-14 char[1]"/]
NFA2_18_34433560[\"NFA2-18 char[1]"/]
NFA2_22_41466584[\"NFA2-22 char[1]"/]
NFA2_26_37654942[\"NFA2-26 char[1]"/]
NFA2_34_3350162[\"NFA2-34 char[1]"/]
NFA2_42_30151461[\"NFA2-42 char[1]"/]
NFA2_5_2927696("NFA2-5 scope[1]")
NFA2_6_26349268("NFA2-6 scope[2]")
NFA2_7_35816827("NFA2-7 scope[3]")
NFA2_8_53915988[\"NFA2-8 scope[4]"/]
NFA2_9_14287764 -->|"#92;"|NFA2_1_16458221
NFA2_9_14287764 -->|"#92;"|NFA2_12_61481014
NFA2_9_14287764 -->|"#92;"|NFA2_16_13906265
NFA2_9_14287764 -->|"#92;"|NFA2_20_58047523
NFA2_9_14287764 -->|"#92;"|NFA2_24_52665660
NFA2_9_14287764 -->|"[#32;-Z]"|NFA2_28_4228893
NFA2_9_14287764 -->|"["|NFA2_30_38060039
NFA2_9_14287764 -->|"#92;"|NFA2_32_6996035
NFA2_9_14287764 -->|"]"|NFA2_36_62964323
NFA2_9_14287764 -->|"^"|NFA2_38_29807999
NFA2_9_14287764 -->|"#92;"|NFA2_40_66945399
NFA2_9_14287764 -->|"[_-~]"|NFA2_44_65637686
NFA2_1_16458221 -->|"u"|NFA2_3_1253610
NFA2_12_61481014 -->|"t"|NFA2_14_11282491
NFA2_16_13906265 -->|"n"|NFA2_18_34433560
NFA2_20_58047523 -->|"r"|NFA2_22_41466584
NFA2_24_52665660 -->|"-"|NFA2_26_37654942
NFA2_32_6996035 -->|"#92;"|NFA2_34_3350162
NFA2_40_66945399 -->|"^"|NFA2_42_30151461
NFA2_3_1253610 -->|"[0-9]"|NFA2_5_2927696
NFA2_5_2927696 -->|"[0-9]"|NFA2_6_26349268
NFA2_6_26349268 -->|"[0-9]"|NFA2_7_35816827
NFA2_7_35816827 -->|"[0-9]"|NFA2_8_53915988
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
subgraph DFA0_1124316954["DFA0 regex start"]
NFA2_9_14287764_0("NFA2-9 regex start")
end
subgraph DFA1_-1859878462["DFA1 {7}"]
NFA2_1_16458221_1("NFA2-1 char[1]")
NFA2_12_61481014_2("NFA2-12 char[1]")
NFA2_16_13906265_3("NFA2-16 char[1]")
NFA2_20_58047523_4("NFA2-20 char[1]")
NFA2_24_52665660_5("NFA2-24 char[1]")
NFA2_32_6996035_6("NFA2-32 char[1]")
NFA2_40_66945399_7("NFA2-40 char[1]")
end
subgraph DFA2_1162717234["DFA2 {1}"]
NFA2_28_4228893_8[\"NFA2-28 scope[1]"/]
end
subgraph DFA3_-1240862659["DFA3 {1}"]
NFA2_30_38060039_9[\"NFA2-30 char[1]"/]
end
subgraph DFA4_-398883392["DFA4 {1}"]
NFA2_36_62964323_10[\"NFA2-36 char[1]"/]
end
subgraph DFA5_-1077390557["DFA5 {1}"]
NFA2_38_29807999_11[\"NFA2-38 char[1]"/]
end
subgraph DFA6_746246640["DFA6 {1}"]
NFA2_44_65637686_12[\"NFA2-44 scope[1]"/]
end
subgraph DFA7_496058285["DFA7 {1}"]
NFA2_3_1253610_13("NFA2-3 char[1]")
end
subgraph DFA8_2050615773["DFA8 {1}"]
NFA2_14_11282491_14[\"NFA2-14 char[1]"/]
end
subgraph DFA9_-1976041124["DFA9 {1}"]
NFA2_18_34433560_15[\"NFA2-18 char[1]"/]
end
subgraph DFA10_409389581["DFA10 {1}"]
NFA2_22_41466584_16[\"NFA2-22 char[1]"/]
end
subgraph DFA11_-586330398["DFA11 {1}"]
NFA2_26_37654942_17[\"NFA2-26 char[1]"/]
end
subgraph DFA12_-1319828414["DFA12 {1}"]
NFA2_34_3350162_18[\"NFA2-34 char[1]"/]
end
subgraph DFA13_1173373570["DFA13 {1}"]
NFA2_42_30151461_19[\"NFA2-42 char[1]"/]
end
subgraph DFA14_1814555838["DFA14 {1}"]
NFA2_5_2927696_20("NFA2-5 scope[1]")
end
subgraph DFA15_323477146["DFA15 {1}"]
NFA2_6_26349268_21("NFA2-6 scope[2]")
end
subgraph DFA16_219640903["DFA16 {1}"]
NFA2_7_35816827_22("NFA2-7 scope[3]")
end
subgraph DFA17_-1749309892["DFA17 {1}"]
NFA2_8_53915988_23[\"NFA2-8 scope[4]"/]
end
DFA0_1124316954 -->|"#92;"|DFA1_-1859878462
DFA0_1124316954 -->|"[#32;-Z]"|DFA2_1162717234
DFA0_1124316954 -->|"["|DFA3_-1240862659
DFA0_1124316954 -->|"]"|DFA4_-398883392
DFA0_1124316954 -->|"^"|DFA5_-1077390557
DFA0_1124316954 -->|"[_-~]"|DFA6_746246640
DFA1_-1859878462 -->|"u"|DFA7_496058285
DFA1_-1859878462 -->|"t"|DFA8_2050615773
DFA1_-1859878462 -->|"n"|DFA9_-1976041124
DFA1_-1859878462 -->|"r"|DFA10_409389581
DFA1_-1859878462 -->|"-"|DFA11_-586330398
DFA1_-1859878462 -->|"#92;"|DFA12_-1319828414
DFA1_-1859878462 -->|"^"|DFA13_1173373570
DFA7_496058285 -->|"[0-9]"|DFA14_1814555838
DFA14_1814555838 -->|"[0-9]"|DFA15_323477146
DFA15_323477146 -->|"[0-9]"|DFA16_219640903
DFA16_219640903 -->|"[0-9]"|DFA17_-1749309892
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
DFA0_1124316954{{"DFA0 regex start"}}
DFA1_-1859878462{{"DFA1 {7}"}}
DFA2_1162717234[\"DFA2 {1}"/]
DFA3_-1240862659[\"DFA3 {1}"/]
DFA4_-398883392[\"DFA4 {1}"/]
DFA5_-1077390557[\"DFA5 {1}"/]
DFA6_746246640[\"DFA6 {1}"/]
DFA7_496058285{{"DFA7 {1}"}}
DFA8_2050615773[\"DFA8 {1}"/]
DFA9_-1976041124[\"DFA9 {1}"/]
DFA10_409389581[\"DFA10 {1}"/]
DFA11_-586330398[\"DFA11 {1}"/]
DFA12_-1319828414[\"DFA12 {1}"/]
DFA13_1173373570[\"DFA13 {1}"/]
DFA14_1814555838{{"DFA14 {1}"}}
DFA15_323477146{{"DFA15 {1}"}}
DFA16_219640903{{"DFA16 {1}"}}
DFA17_-1749309892[\"DFA17 {1}"/]
DFA0_1124316954 -->|"#92;"|DFA1_-1859878462
DFA0_1124316954 -->|"[#32;-Z]"|DFA2_1162717234
DFA0_1124316954 -->|"["|DFA3_-1240862659
DFA0_1124316954 -->|"]"|DFA4_-398883392
DFA0_1124316954 -->|"^"|DFA5_-1077390557
DFA0_1124316954 -->|"[_-~]"|DFA6_746246640
DFA1_-1859878462 -->|"u"|DFA7_496058285
DFA1_-1859878462 -->|"t"|DFA8_2050615773
DFA1_-1859878462 -->|"n"|DFA9_-1976041124
DFA1_-1859878462 -->|"r"|DFA10_409389581
DFA1_-1859878462 -->|"-"|DFA11_-586330398
DFA1_-1859878462 -->|"#92;"|DFA12_-1319828414
DFA1_-1859878462 -->|"^"|DFA13_1173373570
DFA7_496058285 -->|"[0-9]"|DFA14_1814555838
DFA14_1814555838 -->|"[0-9]"|DFA15_323477146
DFA15_323477146 -->|"[0-9]"|DFA16_219640903
DFA16_219640903 -->|"[0-9]"|DFA17_-1749309892
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
subgraph MiniDFA0_402275167["MiniDFA0 {1}"]
DFA0_1124316954_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_891520643["MiniDFA1 {1}"]
DFA1_-1859878462_1{{"DFA1 {7}"}}
end
subgraph MiniDFA6_-334557749["MiniDFA6 {1}"]
DFA2_1162717234_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_-2080261022["MiniDFA7 {1}"]
DFA3_-1240862659_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_-1348472548["MiniDFA8 {1}"]
DFA4_-398883392_4[\"DFA4 {1}"/]
end
subgraph MiniDFA9_1428943349["MiniDFA9 {1}"]
DFA5_-1077390557_5[\"DFA5 {1}"/]
end
subgraph MiniDFA10_1683803548["MiniDFA10 {1}"]
DFA6_746246640_6[\"DFA6 {1}"/]
end
subgraph MiniDFA2_-657993033["MiniDFA2 {1}"]
DFA7_496058285_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_1872506398["MiniDFA11 {1}"]
DFA8_2050615773_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_529499529["MiniDFA12 {1}"]
DFA9_-1976041124_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_-673181269["MiniDFA13 {1}"]
DFA10_409389581_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_442277807["MiniDFA14 {1}"]
DFA11_-586330398_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_-1565226984["MiniDFA15 {1}"]
DFA12_-1319828414_12[\"DFA12 {1}"/]
end
subgraph MiniDFA16_-749041499["MiniDFA16 {1}"]
DFA13_1173373570_13[\"DFA13 {1}"/]
end
subgraph MiniDFA3_-136173377["MiniDFA3 {1}"]
DFA14_1814555838_14{{"DFA14 {1}"}}
end
subgraph MiniDFA4_-254705788["MiniDFA4 {1}"]
DFA15_323477146_15{{"DFA15 {1}"}}
end
subgraph MiniDFA5_901809931["MiniDFA5 {1}"]
DFA16_219640903_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_1154079735["MiniDFA17 {1}"]
DFA17_-1749309892_17[\"DFA17 {1}"/]
end
MiniDFA0_402275167 -->|"#92;"|MiniDFA1_891520643
MiniDFA0_402275167 -->|"[#32;-Z]"|MiniDFA6_-334557749
MiniDFA0_402275167 -->|"["|MiniDFA7_-2080261022
MiniDFA0_402275167 -->|"]"|MiniDFA8_-1348472548
MiniDFA0_402275167 -->|"^"|MiniDFA9_1428943349
MiniDFA0_402275167 -->|"[_-~]"|MiniDFA10_1683803548
MiniDFA1_891520643 -->|"u"|MiniDFA2_-657993033
MiniDFA1_891520643 -->|"t"|MiniDFA11_1872506398
MiniDFA1_891520643 -->|"n"|MiniDFA12_529499529
MiniDFA1_891520643 -->|"r"|MiniDFA13_-673181269
MiniDFA1_891520643 -->|"-"|MiniDFA14_442277807
MiniDFA1_891520643 -->|"#92;"|MiniDFA15_-1565226984
MiniDFA1_891520643 -->|"^"|MiniDFA16_-749041499
MiniDFA2_-657993033 -->|"[0-9]"|MiniDFA3_-136173377
MiniDFA3_-136173377 -->|"[0-9]"|MiniDFA4_-254705788
MiniDFA4_-254705788 -->|"[0-9]"|MiniDFA5_901809931
MiniDFA5_901809931 -->|"[0-9]"|MiniDFA17_1154079735
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
MiniDFA0_402275167(["MiniDFA0 {1}"])
MiniDFA1_891520643(["MiniDFA1 {1}"])
MiniDFA6_-334557749[\"MiniDFA6 {1}"/]
MiniDFA7_-2080261022[\"MiniDFA7 {1}"/]
MiniDFA8_-1348472548[\"MiniDFA8 {1}"/]
MiniDFA9_1428943349[\"MiniDFA9 {1}"/]
MiniDFA10_1683803548[\"MiniDFA10 {1}"/]
MiniDFA2_-657993033(["MiniDFA2 {1}"])
MiniDFA11_1872506398[\"MiniDFA11 {1}"/]
MiniDFA12_529499529[\"MiniDFA12 {1}"/]
MiniDFA13_-673181269[\"MiniDFA13 {1}"/]
MiniDFA14_442277807[\"MiniDFA14 {1}"/]
MiniDFA15_-1565226984[\"MiniDFA15 {1}"/]
MiniDFA16_-749041499[\"MiniDFA16 {1}"/]
MiniDFA3_-136173377(["MiniDFA3 {1}"])
MiniDFA4_-254705788(["MiniDFA4 {1}"])
MiniDFA5_901809931(["MiniDFA5 {1}"])
MiniDFA17_1154079735[\"MiniDFA17 {1}"/]
MiniDFA0_402275167 -->|"#92;"|MiniDFA1_891520643
MiniDFA0_402275167 -->|"[#32;-Z]"|MiniDFA6_-334557749
MiniDFA0_402275167 -->|"["|MiniDFA7_-2080261022
MiniDFA0_402275167 -->|"]"|MiniDFA8_-1348472548
MiniDFA0_402275167 -->|"^"|MiniDFA9_1428943349
MiniDFA0_402275167 -->|"[_-~]"|MiniDFA10_1683803548
MiniDFA1_891520643 -->|"u"|MiniDFA2_-657993033
MiniDFA1_891520643 -->|"t"|MiniDFA11_1872506398
MiniDFA1_891520643 -->|"n"|MiniDFA12_529499529
MiniDFA1_891520643 -->|"r"|MiniDFA13_-673181269
MiniDFA1_891520643 -->|"-"|MiniDFA14_442277807
MiniDFA1_891520643 -->|"#92;"|MiniDFA15_-1565226984
MiniDFA1_891520643 -->|"^"|MiniDFA16_-749041499
MiniDFA2_-657993033 -->|"[0-9]"|MiniDFA3_-136173377
MiniDFA3_-136173377 -->|"[0-9]"|MiniDFA4_-254705788
MiniDFA4_-254705788 -->|"[0-9]"|MiniDFA5_901809931
MiniDFA5_901809931 -->|"[0-9]"|MiniDFA17_1154079735
```
-------------------------------
