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
eNFA3_9_15481850[["εNFA3-9 regex start"]]
eNFA3_0_46070326[["εNFA3-0 char{1, 1}"]]
eNFA3_11_5118925[["εNFA3-11 char{1, 1}"]]
eNFA3_15_11979750[["εNFA3-15 char{1, 1}"]]
eNFA3_19_40708886[["εNFA3-19 char{1, 1}"]]
eNFA3_23_30835655[["εNFA3-23 char{1, 1}"]]
eNFA3_27_9085442[["εNFA3-27 scope{1, 1}"]]
eNFA3_29_14660121[["εNFA3-29 char{1, 1}"]]
eNFA3_33_64832227[["εNFA3-33 char{1, 1}"]]
eNFA3_37_46619139[["εNFA3-37 char{1, 1}"]]
eNFA3_41_16919073[["εNFA3-41 char{1, 1}"]]
eNFA3_43_18053934[["εNFA3-43 char{1, 1}"]]
eNFA3_47_28267683[["εNFA3-47 scope{1, 1}"]]
eNFA3_1_46193959[["εNFA3-1 char[1]"]]
eNFA3_12_13092450[["εNFA3-12 char[1]"]]
eNFA3_16_50723187[["εNFA3-16 char[1]"]]
eNFA3_20_53855499[["εNFA3-20 char[1]"]]
eNFA3_24_14937443[["εNFA3-24 char[1]"]]
eNFA3_28_4202064[["εNFA3-28 scope[1]"]]
eNFA3_30_219260[["εNFA3-30 char[1]"]]
eNFA3_34_1973343[["εNFA3-34 char[1]"]]
eNFA3_38_17760094[["εNFA3-38 char[1]"]]
eNFA3_42_20764489[["εNFA3-42 char[1]"]]
eNFA3_44_25623120[["εNFA3-44 char[1]"]]
eNFA3_48_4822932[["εNFA3-48 scope[1]"]]
eNFA3_2_29281496[["εNFA3-2 char{1, 1}"]]
eNFA3_13_62206878[["εNFA3-13 char{1, 1}"]]
eNFA3_17_22990995[["εNFA3-17 char{1, 1}"]]
eNFA3_21_5592368[["εNFA3-21 char{1, 1}"]]
eNFA3_25_50331319[["εNFA3-25 char{1, 1}"]]
eNFA3_10_52662679[["εNFA3-10 regex end"]]
eNFA3_31_50328687[["εNFA3-31 char{1, 1}"]]
eNFA3_35_50305002[["εNFA3-35 char{1, 1}"]]
eNFA3_39_50091842[["εNFA3-39 char{1, 1}"]]
eNFA3_45_20472262[["εNFA3-45 char{1, 1}"]]
eNFA3_3_47640519[["εNFA3-3 char[1]"]]
eNFA3_14_26256865[["εNFA3-14 char[1]"]]
eNFA3_18_34985201[["εNFA3-18 char[1]"]]
eNFA3_22_46431355[["εNFA3-22 char[1]"]]
eNFA3_26_15229018[["εNFA3-26 char[1]"]]
eNFA3_49_26111487[["εNFA3-49 post-regex start"]]
eNFA3_32_2843438[["εNFA3-32 char[1]"]]
eNFA3_36_25590944[["εNFA3-36 char[1]"]]
eNFA3_40_28991905[["εNFA3-40 char[1]"]]
eNFA3_46_59600554[["εNFA3-46 char[1]"]]
eNFA3_4_33676796[["εNFA3-4 scope{4, 4}"]]
eNFA3_50_11281988[\"εNFA3-50 post-regex end"/]
eNFA3_5_434129[["εNFA3-5 scope[1]"]]
eNFA3_6_3907165[["εNFA3-6 scope[2]"]]
eNFA3_7_35164489[["εNFA3-7 scope[3]"]]
eNFA3_8_62994988[["εNFA3-8 scope[4]"]]
eNFA3_9_15481850 -.->|"ε"|eNFA3_0_46070326
eNFA3_9_15481850 -.->|"ε"|eNFA3_11_5118925
eNFA3_9_15481850 -.->|"ε"|eNFA3_15_11979750
eNFA3_9_15481850 -.->|"ε"|eNFA3_19_40708886
eNFA3_9_15481850 -.->|"ε"|eNFA3_23_30835655
eNFA3_9_15481850 -.->|"ε"|eNFA3_27_9085442
eNFA3_9_15481850 -.->|"ε"|eNFA3_29_14660121
eNFA3_9_15481850 -.->|"ε"|eNFA3_33_64832227
eNFA3_9_15481850 -.->|"ε"|eNFA3_37_46619139
eNFA3_9_15481850 -.->|"ε"|eNFA3_41_16919073
eNFA3_9_15481850 -.->|"ε"|eNFA3_43_18053934
eNFA3_9_15481850 -.->|"ε"|eNFA3_47_28267683
eNFA3_0_46070326 -->|"#92;"|eNFA3_1_46193959
eNFA3_11_5118925 -->|"#92;"|eNFA3_12_13092450
eNFA3_15_11979750 -->|"#92;"|eNFA3_16_50723187
eNFA3_19_40708886 -->|"#92;"|eNFA3_20_53855499
eNFA3_23_30835655 -->|"#92;"|eNFA3_24_14937443
eNFA3_27_9085442 -->|"[#32;-Z]"|eNFA3_28_4202064
eNFA3_29_14660121 -->|"#92;"|eNFA3_30_219260
eNFA3_33_64832227 -->|"#92;"|eNFA3_34_1973343
eNFA3_37_46619139 -->|"#92;"|eNFA3_38_17760094
eNFA3_41_16919073 -->|"^"|eNFA3_42_20764489
eNFA3_43_18053934 -->|"#92;"|eNFA3_44_25623120
eNFA3_47_28267683 -->|"[_-~]"|eNFA3_48_4822932
eNFA3_1_46193959 -.->|"ε"|eNFA3_2_29281496
eNFA3_12_13092450 -.->|"ε"|eNFA3_13_62206878
eNFA3_16_50723187 -.->|"ε"|eNFA3_17_22990995
eNFA3_20_53855499 -.->|"ε"|eNFA3_21_5592368
eNFA3_24_14937443 -.->|"ε"|eNFA3_25_50331319
eNFA3_28_4202064 -.->|"ε"|eNFA3_10_52662679
eNFA3_30_219260 -.->|"ε"|eNFA3_31_50328687
eNFA3_34_1973343 -.->|"ε"|eNFA3_35_50305002
eNFA3_38_17760094 -.->|"ε"|eNFA3_39_50091842
eNFA3_42_20764489 -.->|"ε"|eNFA3_10_52662679
eNFA3_44_25623120 -.->|"ε"|eNFA3_45_20472262
eNFA3_48_4822932 -.->|"ε"|eNFA3_10_52662679
eNFA3_2_29281496 -->|"u"|eNFA3_3_47640519
eNFA3_13_62206878 -->|"t"|eNFA3_14_26256865
eNFA3_17_22990995 -->|"n"|eNFA3_18_34985201
eNFA3_21_5592368 -->|"r"|eNFA3_22_46431355
eNFA3_25_50331319 -->|"-"|eNFA3_26_15229018
eNFA3_10_52662679 -.->|"ε"|eNFA3_49_26111487
eNFA3_31_50328687 -->|"["|eNFA3_32_2843438
eNFA3_35_50305002 -->|"#92;"|eNFA3_36_25590944
eNFA3_39_50091842 -->|"]"|eNFA3_40_28991905
eNFA3_45_20472262 -->|"^"|eNFA3_46_59600554
eNFA3_3_47640519 -.->|"ε"|eNFA3_4_33676796
eNFA3_14_26256865 -.->|"ε"|eNFA3_10_52662679
eNFA3_18_34985201 -.->|"ε"|eNFA3_10_52662679
eNFA3_22_46431355 -.->|"ε"|eNFA3_10_52662679
eNFA3_26_15229018 -.->|"ε"|eNFA3_10_52662679
eNFA3_49_26111487 -.->|"ε"|eNFA3_50_11281988
eNFA3_32_2843438 -.->|"ε"|eNFA3_10_52662679
eNFA3_36_25590944 -.->|"ε"|eNFA3_10_52662679
eNFA3_40_28991905 -.->|"ε"|eNFA3_10_52662679
eNFA3_46_59600554 -.->|"ε"|eNFA3_10_52662679
eNFA3_4_33676796 -->|"[0-9]"|eNFA3_5_434129
eNFA3_5_434129 -->|"[0-9]"|eNFA3_6_3907165
eNFA3_6_3907165 -->|"[0-9]"|eNFA3_7_35164489
eNFA3_7_35164489 -->|"[0-9]"|eNFA3_8_62994988
eNFA3_8_62994988 -.->|"ε"|eNFA3_10_52662679
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
eNFA3_9_20883345[["εNFA3-9 regex start"]]
eNFA3_0_13829407[["εNFA3-0 char{1, 1}"]]
eNFA3_11_53732383[["εNFA3-11 char{1, 1}"]]
eNFA3_15_57355800[["εNFA3-15 char{1, 1}"]]
eNFA3_19_46440157[["εNFA3-19 char{1, 1}"]]
eNFA3_23_15308229[["εNFA3-23 char{1, 1}"]]
eNFA3_27_3556339[["εNFA3-27 scope{1, 1}"]]
eNFA3_29_32007055[["εNFA3-29 char{1, 1}"]]
eNFA3_33_19628042[["εNFA3-33 char{1, 1}"]]
eNFA3_37_42434653[["εNFA3-37 char{1, 1}"]]
eNFA3_41_46367561[["εNFA3-41 char{1, 1}"]]
eNFA3_43_14654872[["εNFA3-43 char{1, 1}"]]
eNFA3_47_64784985[["εNFA3-47 scope{1, 1}"]]
eNFA3_1_29751374[["εNFA3-1 char[1]"]]
eNFA3_12_61051079[["εNFA3-12 char[1]"]]
eNFA3_16_46190365[["εNFA3-16 char[1]"]]
eNFA3_20_50432055[["εNFA3-20 char[1]"]]
eNFA3_24_58464637[["εNFA3-24 char[1]"]]
eNFA3_28_9731236[\"εNFA3-28 scope[1]"/]
eNFA3_30_38015193[["εNFA3-30 char[1]"]]
eNFA3_34_59331760[["εNFA3-34 char[1]"]]
eNFA3_38_41143276[["εNFA3-38 char[1]"]]
eNFA3_42_48173399[\"εNFA3-42 char[1]"/]
eNFA3_44_44271093[["εNFA3-44 char[1]"]]
eNFA3_48_50032633[\"εNFA3-48 scope[1]"/]
eNFA3_2_66435776[["εNFA3-2 char{1, 1}"]]
eNFA3_3_61372488[["εNFA3-3 char[1]"]]
eNFA3_13_12588803[["εNFA3-13 char{1, 1}"]]
eNFA3_14_34655709[\"εNFA3-14 char[1]"/]
eNFA3_17_13060102[["εNFA3-17 char{1, 1}"]]
eNFA3_18_43465933[\"εNFA3-18 char[1]"/]
eNFA3_21_51235313[["εNFA3-21 char{1, 1}"]]
eNFA3_22_55649084[\"εNFA3-22 char[1]"/]
eNFA3_25_56419693[["εNFA3-25 char{1, 1}"]]
eNFA3_26_31079716[\"εNFA3-26 char[1]"/]
eNFA3_10_30907410[\"εNFA3-10 regex end"/]
eNFA3_49_29188786[\"εNFA3-49 post-regex start"/]
eNFA3_50_5115631[\"εNFA3-50 post-regex end"/]
eNFA3_31_6592417[["εNFA3-31 char{1, 1}"]]
eNFA3_32_34429030[\"εNFA3-32 char[1]"/]
eNFA3_35_64223798[["εNFA3-35 char{1, 1}"]]
eNFA3_36_41425820[\"εNFA3-36 char[1]"/]
eNFA3_39_34745172[["εNFA3-39 char{1, 1}"]]
eNFA3_40_37288061[\"εNFA3-40 char[1]"/]
eNFA3_45_62895522[["εNFA3-45 char{1, 1}"]]
eNFA3_46_48236[\"εNFA3-46 char[1]"/]
eNFA3_4_15481484[["εNFA3-4 scope{4, 4}"]]
eNFA3_5_46040682[["εNFA3-5 scope[1]"]]
eNFA3_6_39571227[["εNFA3-6 scope[2]"]]
eNFA3_7_20596728[["εNFA3-7 scope[3]"]]
eNFA3_8_48044950[\"εNFA3-8 scope[4]"/]
eNFA3_9_20883345 -.->|"ε"|eNFA3_0_13829407
eNFA3_9_20883345 -.->|"ε"|eNFA3_11_53732383
eNFA3_9_20883345 -.->|"ε"|eNFA3_15_57355800
eNFA3_9_20883345 -.->|"ε"|eNFA3_19_46440157
eNFA3_9_20883345 -.->|"ε"|eNFA3_23_15308229
eNFA3_9_20883345 -.->|"ε"|eNFA3_27_3556339
eNFA3_9_20883345 -.->|"ε"|eNFA3_29_32007055
eNFA3_9_20883345 -.->|"ε"|eNFA3_33_19628042
eNFA3_9_20883345 -.->|"ε"|eNFA3_37_42434653
eNFA3_9_20883345 -.->|"ε"|eNFA3_41_46367561
eNFA3_9_20883345 -.->|"ε"|eNFA3_43_14654872
eNFA3_9_20883345 -.->|"ε"|eNFA3_47_64784985
eNFA3_9_20883345 -->|"#92;"|eNFA3_1_29751374
eNFA3_9_20883345 -->|"#92;"|eNFA3_12_61051079
eNFA3_9_20883345 -->|"#92;"|eNFA3_16_46190365
eNFA3_9_20883345 -->|"#92;"|eNFA3_20_50432055
eNFA3_9_20883345 -->|"#92;"|eNFA3_24_58464637
eNFA3_9_20883345 -->|"[#32;-Z]"|eNFA3_28_9731236
eNFA3_9_20883345 -->|"#92;"|eNFA3_30_38015193
eNFA3_9_20883345 -->|"#92;"|eNFA3_34_59331760
eNFA3_9_20883345 -->|"#92;"|eNFA3_38_41143276
eNFA3_9_20883345 -->|"^"|eNFA3_42_48173399
eNFA3_9_20883345 -->|"#92;"|eNFA3_44_44271093
eNFA3_9_20883345 -->|"[_-~]"|eNFA3_48_50032633
eNFA3_0_13829407 -->|"#92;"|eNFA3_1_29751374
eNFA3_11_53732383 -->|"#92;"|eNFA3_12_61051079
eNFA3_15_57355800 -->|"#92;"|eNFA3_16_46190365
eNFA3_19_46440157 -->|"#92;"|eNFA3_20_50432055
eNFA3_23_15308229 -->|"#92;"|eNFA3_24_58464637
eNFA3_27_3556339 -->|"[#32;-Z]"|eNFA3_28_9731236
eNFA3_29_32007055 -->|"#92;"|eNFA3_30_38015193
eNFA3_33_19628042 -->|"#92;"|eNFA3_34_59331760
eNFA3_37_42434653 -->|"#92;"|eNFA3_38_41143276
eNFA3_41_46367561 -->|"^"|eNFA3_42_48173399
eNFA3_43_14654872 -->|"#92;"|eNFA3_44_44271093
eNFA3_47_64784985 -->|"[_-~]"|eNFA3_48_50032633
eNFA3_1_29751374 -.->|"ε"|eNFA3_2_66435776
eNFA3_1_29751374 -->|"u"|eNFA3_3_61372488
eNFA3_12_61051079 -.->|"ε"|eNFA3_13_12588803
eNFA3_12_61051079 -->|"t"|eNFA3_14_34655709
eNFA3_16_46190365 -.->|"ε"|eNFA3_17_13060102
eNFA3_16_46190365 -->|"n"|eNFA3_18_43465933
eNFA3_20_50432055 -.->|"ε"|eNFA3_21_51235313
eNFA3_20_50432055 -->|"r"|eNFA3_22_55649084
eNFA3_24_58464637 -.->|"ε"|eNFA3_25_56419693
eNFA3_24_58464637 -->|"-"|eNFA3_26_31079716
eNFA3_28_9731236 -.->|"ε"|eNFA3_10_30907410
eNFA3_28_9731236 -.->|"ε"|eNFA3_49_29188786
eNFA3_28_9731236 -.->|"ε"|eNFA3_50_5115631
eNFA3_30_38015193 -.->|"ε"|eNFA3_31_6592417
eNFA3_30_38015193 -->|"["|eNFA3_32_34429030
eNFA3_34_59331760 -.->|"ε"|eNFA3_35_64223798
eNFA3_34_59331760 -->|"#92;"|eNFA3_36_41425820
eNFA3_38_41143276 -.->|"ε"|eNFA3_39_34745172
eNFA3_38_41143276 -->|"]"|eNFA3_40_37288061
eNFA3_42_48173399 -.->|"ε"|eNFA3_10_30907410
eNFA3_42_48173399 -.->|"ε"|eNFA3_49_29188786
eNFA3_42_48173399 -.->|"ε"|eNFA3_50_5115631
eNFA3_44_44271093 -.->|"ε"|eNFA3_45_62895522
eNFA3_44_44271093 -->|"^"|eNFA3_46_48236
eNFA3_48_50032633 -.->|"ε"|eNFA3_10_30907410
eNFA3_48_50032633 -.->|"ε"|eNFA3_49_29188786
eNFA3_48_50032633 -.->|"ε"|eNFA3_50_5115631
eNFA3_2_66435776 -->|"u"|eNFA3_3_61372488
eNFA3_3_61372488 -.->|"ε"|eNFA3_4_15481484
eNFA3_3_61372488 -->|"[0-9]"|eNFA3_5_46040682
eNFA3_13_12588803 -->|"t"|eNFA3_14_34655709
eNFA3_14_34655709 -.->|"ε"|eNFA3_10_30907410
eNFA3_14_34655709 -.->|"ε"|eNFA3_49_29188786
eNFA3_14_34655709 -.->|"ε"|eNFA3_50_5115631
eNFA3_17_13060102 -->|"n"|eNFA3_18_43465933
eNFA3_18_43465933 -.->|"ε"|eNFA3_10_30907410
eNFA3_18_43465933 -.->|"ε"|eNFA3_49_29188786
eNFA3_18_43465933 -.->|"ε"|eNFA3_50_5115631
eNFA3_21_51235313 -->|"r"|eNFA3_22_55649084
eNFA3_22_55649084 -.->|"ε"|eNFA3_10_30907410
eNFA3_22_55649084 -.->|"ε"|eNFA3_49_29188786
eNFA3_22_55649084 -.->|"ε"|eNFA3_50_5115631
eNFA3_25_56419693 -->|"-"|eNFA3_26_31079716
eNFA3_26_31079716 -.->|"ε"|eNFA3_10_30907410
eNFA3_26_31079716 -.->|"ε"|eNFA3_49_29188786
eNFA3_26_31079716 -.->|"ε"|eNFA3_50_5115631
eNFA3_10_30907410 -.->|"ε"|eNFA3_49_29188786
eNFA3_10_30907410 -.->|"ε"|eNFA3_50_5115631
eNFA3_49_29188786 -.->|"ε"|eNFA3_50_5115631
eNFA3_31_6592417 -->|"["|eNFA3_32_34429030
eNFA3_32_34429030 -.->|"ε"|eNFA3_10_30907410
eNFA3_32_34429030 -.->|"ε"|eNFA3_49_29188786
eNFA3_32_34429030 -.->|"ε"|eNFA3_50_5115631
eNFA3_35_64223798 -->|"#92;"|eNFA3_36_41425820
eNFA3_36_41425820 -.->|"ε"|eNFA3_10_30907410
eNFA3_36_41425820 -.->|"ε"|eNFA3_49_29188786
eNFA3_36_41425820 -.->|"ε"|eNFA3_50_5115631
eNFA3_39_34745172 -->|"]"|eNFA3_40_37288061
eNFA3_40_37288061 -.->|"ε"|eNFA3_10_30907410
eNFA3_40_37288061 -.->|"ε"|eNFA3_49_29188786
eNFA3_40_37288061 -.->|"ε"|eNFA3_50_5115631
eNFA3_45_62895522 -->|"^"|eNFA3_46_48236
eNFA3_46_48236 -.->|"ε"|eNFA3_10_30907410
eNFA3_46_48236 -.->|"ε"|eNFA3_49_29188786
eNFA3_46_48236 -.->|"ε"|eNFA3_50_5115631
eNFA3_4_15481484 -->|"[0-9]"|eNFA3_5_46040682
eNFA3_5_46040682 -->|"[0-9]"|eNFA3_6_39571227
eNFA3_6_39571227 -->|"[0-9]"|eNFA3_7_20596728
eNFA3_7_20596728 -->|"[0-9]"|eNFA3_8_48044950
eNFA3_8_48044950 -.->|"ε"|eNFA3_10_30907410
eNFA3_8_48044950 -.->|"ε"|eNFA3_49_29188786
eNFA3_8_48044950 -.->|"ε"|eNFA3_50_5115631
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
NFA3_9_11712958("NFA3-9 regex start")
NFA3_1_9225566("NFA3-1 char[1]")
NFA3_12_38307765("NFA3-12 char[1]")
NFA3_16_15921236("NFA3-16 char[1]")
NFA3_20_9073399("NFA3-20 char[1]")
NFA3_24_14551728("NFA3-24 char[1]")
NFA3_28_63856688[\"NFA3-28 scope[1]"/]
NFA3_30_37839280("NFA3-30 char[1]")
NFA3_34_5009201("NFA3-34 char[1]")
NFA3_38_45082812("NFA3-38 char[1]")
NFA3_42_3092131[\"NFA3-42 char[1]"/]
NFA3_44_27829181("NFA3-44 char[1]")
NFA3_48_49136045[\"NFA3-48 scope[1]"/]
NFA3_3_51152829("NFA3-3 char[1]")
NFA3_14_57722284[\"NFA3-14 char[1]"/]
NFA3_18_49738508[\"NFA3-18 char[1]"/]
NFA3_22_44993391[\"NFA3-22 char[1]"/]
NFA3_26_2287343[\"NFA3-26 char[1]"/]
NFA3_32_20586092[\"NFA3-32 char[1]"/]
NFA3_36_51057103[\"NFA3-36 char[1]"/]
NFA3_40_56860745[\"NFA3-40 char[1]"/]
NFA3_46_41984659[\"NFA3-46 char[1]"/]
NFA3_5_42317614("NFA3-5 scope[1]")
NFA3_6_45314212("NFA3-6 scope[2]")
NFA3_7_5174724("NFA3-7 scope[3]")
NFA3_8_46572521[\"NFA3-8 scope[4]"/]
NFA3_9_11712958 -->|"#92;"|NFA3_1_9225566
NFA3_9_11712958 -->|"#92;"|NFA3_12_38307765
NFA3_9_11712958 -->|"#92;"|NFA3_16_15921236
NFA3_9_11712958 -->|"#92;"|NFA3_20_9073399
NFA3_9_11712958 -->|"#92;"|NFA3_24_14551728
NFA3_9_11712958 -->|"[#32;-Z]"|NFA3_28_63856688
NFA3_9_11712958 -->|"#92;"|NFA3_30_37839280
NFA3_9_11712958 -->|"#92;"|NFA3_34_5009201
NFA3_9_11712958 -->|"#92;"|NFA3_38_45082812
NFA3_9_11712958 -->|"^"|NFA3_42_3092131
NFA3_9_11712958 -->|"#92;"|NFA3_44_27829181
NFA3_9_11712958 -->|"[_-~]"|NFA3_48_49136045
NFA3_1_9225566 -->|"u"|NFA3_3_51152829
NFA3_12_38307765 -->|"t"|NFA3_14_57722284
NFA3_16_15921236 -->|"n"|NFA3_18_49738508
NFA3_20_9073399 -->|"r"|NFA3_22_44993391
NFA3_24_14551728 -->|"-"|NFA3_26_2287343
NFA3_30_37839280 -->|"["|NFA3_32_20586092
NFA3_34_5009201 -->|"#92;"|NFA3_36_51057103
NFA3_38_45082812 -->|"]"|NFA3_40_56860745
NFA3_44_27829181 -->|"^"|NFA3_46_41984659
NFA3_3_51152829 -->|"[0-9]"|NFA3_5_42317614
NFA3_5_42317614 -->|"[0-9]"|NFA3_6_45314212
NFA3_6_45314212 -->|"[0-9]"|NFA3_7_5174724
NFA3_7_5174724 -->|"[0-9]"|NFA3_8_46572521
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
subgraph DFA0_-1833742324["DFA0 regex start"]
NFA3_9_11712958_0("NFA3-9 regex start")
end
subgraph DFA1_-1514032506["DFA1 {9}"]
NFA3_1_9225566_1("NFA3-1 char[1]")
NFA3_12_38307765_2("NFA3-12 char[1]")
NFA3_16_15921236_3("NFA3-16 char[1]")
NFA3_20_9073399_4("NFA3-20 char[1]")
NFA3_24_14551728_5("NFA3-24 char[1]")
NFA3_30_37839280_6("NFA3-30 char[1]")
NFA3_34_5009201_7("NFA3-34 char[1]")
NFA3_38_45082812_8("NFA3-38 char[1]")
NFA3_44_27829181_9("NFA3-44 char[1]")
end
subgraph DFA2_1025750768["DFA2 {1}"]
NFA3_28_63856688_10[\"NFA3-28 scope[1]"/]
end
subgraph DFA3_1423772466["DFA3 {1}"]
NFA3_42_3092131_11[\"NFA3-42 char[1]"/]
end
subgraph DFA4_-1099674008["DFA4 {1}"]
NFA3_48_49136045_12[\"NFA3-48 scope[1]"/]
end
subgraph DFA5_593514686["DFA5 {1}"]
NFA3_3_51152829_13("NFA3-3 char[1]")
end
subgraph DFA6_1458201865["DFA6 {1}"]
NFA3_14_57722284_14[\"NFA3-14 char[1]"/]
end
subgraph DFA7_-480148453["DFA7 {1}"]
NFA3_18_49738508_15[\"NFA3-18 char[1]"/]
end
subgraph DFA8_-1317165909["DFA8 {1}"]
NFA3_22_44993391_16[\"NFA3-22 char[1]"/]
end
subgraph DFA9_530775965["DFA9 {1}"]
NFA3_26_2287343_17[\"NFA3-26 char[1]"/]
end
subgraph DFA10_-429957774["DFA10 {1}"]
NFA3_32_20586092_18[\"NFA3-32 char[1]"/]
end
subgraph DFA11_910980487["DFA11 {1}"]
NFA3_36_51057103_19[\"NFA3-36 char[1]"/]
end
subgraph DFA12_970627223["DFA12 {1}"]
NFA3_40_56860745_20[\"NFA3-40 char[1]"/]
end
subgraph DFA13_559621168["DFA13 {1}"]
NFA3_46_41984659_21[\"NFA3-46 char[1]"/]
end
subgraph DFA14_-1761833499["DFA14 {1}"]
NFA3_5_42317614_22("NFA3-5 scope[1]")
end
subgraph DFA15_-2038400933["DFA15 {1}"]
NFA3_6_45314212_23("NFA3-6 scope[2]")
end
subgraph DFA16_2026010757["DFA16 {1}"]
NFA3_7_5174724_24("NFA3-7 scope[3]")
end
subgraph DFA17_447888396["DFA17 {1}"]
NFA3_8_46572521_25[\"NFA3-8 scope[4]"/]
end
DFA0_-1833742324 -->|"#92;"|DFA1_-1514032506
DFA0_-1833742324 -->|"[#32;-Z]"|DFA2_1025750768
DFA0_-1833742324 -->|"^"|DFA3_1423772466
DFA0_-1833742324 -->|"[_-~]"|DFA4_-1099674008
DFA1_-1514032506 -->|"u"|DFA5_593514686
DFA1_-1514032506 -->|"t"|DFA6_1458201865
DFA1_-1514032506 -->|"n"|DFA7_-480148453
DFA1_-1514032506 -->|"r"|DFA8_-1317165909
DFA1_-1514032506 -->|"-"|DFA9_530775965
DFA1_-1514032506 -->|"["|DFA10_-429957774
DFA1_-1514032506 -->|"#92;"|DFA11_910980487
DFA1_-1514032506 -->|"]"|DFA12_970627223
DFA1_-1514032506 -->|"^"|DFA13_559621168
DFA5_593514686 -->|"[0-9]"|DFA14_-1761833499
DFA14_-1761833499 -->|"[0-9]"|DFA15_-2038400933
DFA15_-2038400933 -->|"[0-9]"|DFA16_2026010757
DFA16_2026010757 -->|"[0-9]"|DFA17_447888396
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
DFA0_-1833742324{{"DFA0 regex start"}}
DFA1_-1514032506{{"DFA1 {9}"}}
DFA2_1025750768[\"DFA2 {1}"/]
DFA3_1423772466[\"DFA3 {1}"/]
DFA4_-1099674008[\"DFA4 {1}"/]
DFA5_593514686{{"DFA5 {1}"}}
DFA6_1458201865[\"DFA6 {1}"/]
DFA7_-480148453[\"DFA7 {1}"/]
DFA8_-1317165909[\"DFA8 {1}"/]
DFA9_530775965[\"DFA9 {1}"/]
DFA10_-429957774[\"DFA10 {1}"/]
DFA11_910980487[\"DFA11 {1}"/]
DFA12_970627223[\"DFA12 {1}"/]
DFA13_559621168[\"DFA13 {1}"/]
DFA14_-1761833499{{"DFA14 {1}"}}
DFA15_-2038400933{{"DFA15 {1}"}}
DFA16_2026010757{{"DFA16 {1}"}}
DFA17_447888396[\"DFA17 {1}"/]
DFA0_-1833742324 -->|"#92;"|DFA1_-1514032506
DFA0_-1833742324 -->|"[#32;-Z]"|DFA2_1025750768
DFA0_-1833742324 -->|"^"|DFA3_1423772466
DFA0_-1833742324 -->|"[_-~]"|DFA4_-1099674008
DFA1_-1514032506 -->|"u"|DFA5_593514686
DFA1_-1514032506 -->|"t"|DFA6_1458201865
DFA1_-1514032506 -->|"n"|DFA7_-480148453
DFA1_-1514032506 -->|"r"|DFA8_-1317165909
DFA1_-1514032506 -->|"-"|DFA9_530775965
DFA1_-1514032506 -->|"["|DFA10_-429957774
DFA1_-1514032506 -->|"#92;"|DFA11_910980487
DFA1_-1514032506 -->|"]"|DFA12_970627223
DFA1_-1514032506 -->|"^"|DFA13_559621168
DFA5_593514686 -->|"[0-9]"|DFA14_-1761833499
DFA14_-1761833499 -->|"[0-9]"|DFA15_-2038400933
DFA15_-2038400933 -->|"[0-9]"|DFA16_2026010757
DFA16_2026010757 -->|"[0-9]"|DFA17_447888396
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
subgraph MiniDFA0_-1824000490["MiniDFA0 {1}"]
DFA0_-1833742324_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-608886490["MiniDFA1 {1}"]
DFA1_-1514032506_1{{"DFA1 {9}"}}
end
subgraph MiniDFA6_265915928["MiniDFA6 {1}"]
DFA2_1025750768_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_-912072416["MiniDFA7 {1}"]
DFA3_1423772466_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_1735144349["MiniDFA8 {1}"]
DFA4_-1099674008_4[\"DFA4 {1}"/]
end
subgraph MiniDFA2_-1301579891["MiniDFA2 {1}"]
DFA5_593514686_5{{"DFA5 {1}"}}
end
subgraph MiniDFA9_1976641438["MiniDFA9 {1}"]
DFA6_1458201865_6[\"DFA6 {1}"/]
end
subgraph MiniDFA10_917278996["MiniDFA10 {1}"]
DFA7_-480148453_7[\"DFA7 {1}"/]
end
subgraph MiniDFA11_860747322["MiniDFA11 {1}"]
DFA8_-1317165909_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_-25943421["MiniDFA12 {1}"]
DFA9_530775965_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_244715329["MiniDFA13 {1}"]
DFA10_-429957774_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_1159012174["MiniDFA14 {1}"]
DFA11_910980487_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_-1525184033["MiniDFA15 {1}"]
DFA12_970627223_12[\"DFA12 {1}"/]
end
subgraph MiniDFA16_1292471834["MiniDFA16 {1}"]
DFA13_559621168_13[\"DFA13 {1}"/]
end
subgraph MiniDFA3_83195023["MiniDFA3 {1}"]
DFA14_-1761833499_14{{"DFA14 {1}"}}
end
subgraph MiniDFA4_1384228617["MiniDFA4 {1}"]
DFA15_-2038400933_15{{"DFA15 {1}"}}
end
subgraph MiniDFA5_146543935["MiniDFA5 {1}"]
DFA16_2026010757_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_-285434128["MiniDFA17 {1}"]
DFA17_447888396_17[\"DFA17 {1}"/]
end
MiniDFA0_-1824000490 -->|"#92;"|MiniDFA1_-608886490
MiniDFA0_-1824000490 -->|"[#32;-Z]"|MiniDFA6_265915928
MiniDFA0_-1824000490 -->|"^"|MiniDFA7_-912072416
MiniDFA0_-1824000490 -->|"[_-~]"|MiniDFA8_1735144349
MiniDFA1_-608886490 -->|"u"|MiniDFA2_-1301579891
MiniDFA1_-608886490 -->|"t"|MiniDFA9_1976641438
MiniDFA1_-608886490 -->|"n"|MiniDFA10_917278996
MiniDFA1_-608886490 -->|"r"|MiniDFA11_860747322
MiniDFA1_-608886490 -->|"-"|MiniDFA12_-25943421
MiniDFA1_-608886490 -->|"["|MiniDFA13_244715329
MiniDFA1_-608886490 -->|"#92;"|MiniDFA14_1159012174
MiniDFA1_-608886490 -->|"]"|MiniDFA15_-1525184033
MiniDFA1_-608886490 -->|"^"|MiniDFA16_1292471834
MiniDFA2_-1301579891 -->|"[0-9]"|MiniDFA3_83195023
MiniDFA3_83195023 -->|"[0-9]"|MiniDFA4_1384228617
MiniDFA4_1384228617 -->|"[0-9]"|MiniDFA5_146543935
MiniDFA5_146543935 -->|"[0-9]"|MiniDFA17_-285434128
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
MiniDFA0_-1824000490(["MiniDFA0 {1}"])
MiniDFA1_-608886490(["MiniDFA1 {1}"])
MiniDFA6_265915928[\"MiniDFA6 {1}"/]
MiniDFA7_-912072416[\"MiniDFA7 {1}"/]
MiniDFA8_1735144349[\"MiniDFA8 {1}"/]
MiniDFA2_-1301579891(["MiniDFA2 {1}"])
MiniDFA9_1976641438[\"MiniDFA9 {1}"/]
MiniDFA10_917278996[\"MiniDFA10 {1}"/]
MiniDFA11_860747322[\"MiniDFA11 {1}"/]
MiniDFA12_-25943421[\"MiniDFA12 {1}"/]
MiniDFA13_244715329[\"MiniDFA13 {1}"/]
MiniDFA14_1159012174[\"MiniDFA14 {1}"/]
MiniDFA15_-1525184033[\"MiniDFA15 {1}"/]
MiniDFA16_1292471834[\"MiniDFA16 {1}"/]
MiniDFA3_83195023(["MiniDFA3 {1}"])
MiniDFA4_1384228617(["MiniDFA4 {1}"])
MiniDFA5_146543935(["MiniDFA5 {1}"])
MiniDFA17_-285434128[\"MiniDFA17 {1}"/]
MiniDFA0_-1824000490 -->|"#92;"|MiniDFA1_-608886490
MiniDFA0_-1824000490 -->|"[#32;-Z]"|MiniDFA6_265915928
MiniDFA0_-1824000490 -->|"^"|MiniDFA7_-912072416
MiniDFA0_-1824000490 -->|"[_-~]"|MiniDFA8_1735144349
MiniDFA1_-608886490 -->|"u"|MiniDFA2_-1301579891
MiniDFA1_-608886490 -->|"t"|MiniDFA9_1976641438
MiniDFA1_-608886490 -->|"n"|MiniDFA10_917278996
MiniDFA1_-608886490 -->|"r"|MiniDFA11_860747322
MiniDFA1_-608886490 -->|"-"|MiniDFA12_-25943421
MiniDFA1_-608886490 -->|"["|MiniDFA13_244715329
MiniDFA1_-608886490 -->|"#92;"|MiniDFA14_1159012174
MiniDFA1_-608886490 -->|"]"|MiniDFA15_-1525184033
MiniDFA1_-608886490 -->|"^"|MiniDFA16_1292471834
MiniDFA2_-1301579891 -->|"[0-9]"|MiniDFA3_83195023
MiniDFA3_83195023 -->|"[0-9]"|MiniDFA4_1384228617
MiniDFA4_1384228617 -->|"[0-9]"|MiniDFA5_146543935
MiniDFA5_146543935 -->|"[0-9]"|MiniDFA17_-285434128
```
-------------------------------
