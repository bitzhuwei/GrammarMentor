# 'firstItem1'

pattern: `<'['>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~]`

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
eNFA1_9_31003727[["εNFA1-9 regex start"]]
eNFA1_0_28273955[["εNFA1-0 char{1, 1}"]]
eNFA1_11_10598091[["εNFA1-11 char{1, 1}"]]
eNFA1_15_53139010[["εNFA1-15 char{1, 1}"]]
eNFA1_19_8489048[["εNFA1-19 char{1, 1}"]]
eNFA1_23_9292574[["εNFA1-23 char{1, 1}"]]
eNFA1_27_16524310[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_14501063[["εNFA1-29 char{1, 1}"]]
eNFA1_31_63400708[["εNFA1-31 char{1, 1}"]]
eNFA1_35_33735460[["εNFA1-35 char{1, 1}"]]
eNFA1_37_35183690[["εNFA1-37 char{1, 1}"]]
eNFA1_41_48217758[["εNFA1-41 scope{1, 1}"]]
eNFA1_1_12522150[["εNFA1-1 char[1]"]]
eNFA1_12_45590490[["εNFA1-12 char[1]"]]
eNFA1_16_7661228[["εNFA1-16 char[1]"]]
eNFA1_20_1842189[["εNFA1-20 char[1]"]]
eNFA1_24_16579702[["εNFA1-24 char[1]"]]
eNFA1_28_33858223[["εNFA1-28 scope[1]"]]
eNFA1_30_58413317[["εNFA1-30 char[1]"]]
eNFA1_32_14999592[["εNFA1-32 char[1]"]]
eNFA1_36_58161562[["εNFA1-36 char[1]"]]
eNFA1_38_778604[["εNFA1-38 char[1]"]]
eNFA1_42_13466094[["εNFA1-42 scope[1]"]]
eNFA1_2_7007444[["εNFA1-2 char{1, 1}"]]
eNFA1_13_63067000[["εNFA1-13 char{1, 1}"]]
eNFA1_17_30732088[["εNFA1-17 char{1, 1}"]]
eNFA1_21_8153343[["εNFA1-21 char{1, 1}"]]
eNFA1_25_6271229[["εNFA1-25 char{1, 1}"]]
eNFA1_10_55957807[["εNFA1-10 regex end"]]
eNFA1_33_7804873[["εNFA1-33 char{1, 1}"]]
eNFA1_39_28214943[["εNFA1-39 char{1, 1}"]]
eNFA1_3_3709046[["εNFA1-3 char[1]"]]
eNFA1_14_18888417[["εNFA1-14 char[1]"]]
eNFA1_18_35778030[["εNFA1-18 char[1]"]]
eNFA1_22_53566817[["εNFA1-22 char[1]"]]
eNFA1_26_12339307[["εNFA1-26 char[1]"]]
eNFA1_43_33381417[["εNFA1-43 post-regex start"]]
eNFA1_34_43944901[["εNFA1-34 char[1]"]]
eNFA1_40_59959792[["εNFA1-40 char[1]"]]
eNFA1_4_31997301[["εNFA1-4 scope{4, 4}"]]
eNFA1_44_25716863[\"εNFA1-44 post-regex end"/]
eNFA1_5_24220072[["εNFA1-5 scope[1]"]]
eNFA1_6_16654059[["εNFA1-6 scope[2]"]]
eNFA1_7_15668810[["εNFA1-7 scope[3]"]]
eNFA1_8_4038964[["εNFA1-8 scope[4]"]]
eNFA1_9_31003727 -.->|"ε"|eNFA1_0_28273955
eNFA1_9_31003727 -.->|"ε"|eNFA1_11_10598091
eNFA1_9_31003727 -.->|"ε"|eNFA1_15_53139010
eNFA1_9_31003727 -.->|"ε"|eNFA1_19_8489048
eNFA1_9_31003727 -.->|"ε"|eNFA1_23_9292574
eNFA1_9_31003727 -.->|"ε"|eNFA1_27_16524310
eNFA1_9_31003727 -.->|"ε"|eNFA1_29_14501063
eNFA1_9_31003727 -.->|"ε"|eNFA1_31_63400708
eNFA1_9_31003727 -.->|"ε"|eNFA1_35_33735460
eNFA1_9_31003727 -.->|"ε"|eNFA1_37_35183690
eNFA1_9_31003727 -.->|"ε"|eNFA1_41_48217758
eNFA1_0_28273955 -->|"#92;"|eNFA1_1_12522150
eNFA1_11_10598091 -->|"#92;"|eNFA1_12_45590490
eNFA1_15_53139010 -->|"#92;"|eNFA1_16_7661228
eNFA1_19_8489048 -->|"#92;"|eNFA1_20_1842189
eNFA1_23_9292574 -->|"#92;"|eNFA1_24_16579702
eNFA1_27_16524310 -->|"[#32;-Z]"|eNFA1_28_33858223
eNFA1_29_14501063 -->|"["|eNFA1_30_58413317
eNFA1_31_63400708 -->|"#92;"|eNFA1_32_14999592
eNFA1_35_33735460 -->|"]"|eNFA1_36_58161562
eNFA1_37_35183690 -->|"#92;"|eNFA1_38_778604
eNFA1_41_48217758 -->|"[_-~]"|eNFA1_42_13466094
eNFA1_1_12522150 -.->|"ε"|eNFA1_2_7007444
eNFA1_12_45590490 -.->|"ε"|eNFA1_13_63067000
eNFA1_16_7661228 -.->|"ε"|eNFA1_17_30732088
eNFA1_20_1842189 -.->|"ε"|eNFA1_21_8153343
eNFA1_24_16579702 -.->|"ε"|eNFA1_25_6271229
eNFA1_28_33858223 -.->|"ε"|eNFA1_10_55957807
eNFA1_30_58413317 -.->|"ε"|eNFA1_10_55957807
eNFA1_32_14999592 -.->|"ε"|eNFA1_33_7804873
eNFA1_36_58161562 -.->|"ε"|eNFA1_10_55957807
eNFA1_38_778604 -.->|"ε"|eNFA1_39_28214943
eNFA1_42_13466094 -.->|"ε"|eNFA1_10_55957807
eNFA1_2_7007444 -->|"u"|eNFA1_3_3709046
eNFA1_13_63067000 -->|"t"|eNFA1_14_18888417
eNFA1_17_30732088 -->|"n"|eNFA1_18_35778030
eNFA1_21_8153343 -->|"r"|eNFA1_22_53566817
eNFA1_25_6271229 -->|"-"|eNFA1_26_12339307
eNFA1_10_55957807 -.->|"ε"|eNFA1_43_33381417
eNFA1_33_7804873 -->|"#92;"|eNFA1_34_43944901
eNFA1_39_28214943 -->|"^"|eNFA1_40_59959792
eNFA1_3_3709046 -.->|"ε"|eNFA1_4_31997301
eNFA1_14_18888417 -.->|"ε"|eNFA1_10_55957807
eNFA1_18_35778030 -.->|"ε"|eNFA1_10_55957807
eNFA1_22_53566817 -.->|"ε"|eNFA1_10_55957807
eNFA1_26_12339307 -.->|"ε"|eNFA1_10_55957807
eNFA1_43_33381417 -.->|"ε"|eNFA1_44_25716863
eNFA1_34_43944901 -.->|"ε"|eNFA1_10_55957807
eNFA1_40_59959792 -.->|"ε"|eNFA1_10_55957807
eNFA1_4_31997301 -->|"[0-9]"|eNFA1_5_24220072
eNFA1_5_24220072 -->|"[0-9]"|eNFA1_6_16654059
eNFA1_6_16654059 -->|"[0-9]"|eNFA1_7_15668810
eNFA1_7_15668810 -->|"[0-9]"|eNFA1_8_4038964
eNFA1_8_4038964 -.->|"ε"|eNFA1_10_55957807
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
eNFA1_9_58724323[["εNFA1-9 regex start"]]
eNFA1_0_59049685[["εNFA1-0 char{1, 1}"]]
eNFA1_11_58756859[["εNFA1-11 char{1, 1}"]]
eNFA1_15_61685123[["εNFA1-15 char{1, 1}"]]
eNFA1_19_18295196[["εNFA1-19 char{1, 1}"]]
eNFA1_23_30439043[["εNFA1-23 char{1, 1}"]]
eNFA1_27_5515936[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_49643428[["εNFA1-29 char{1, 1}"]]
eNFA1_31_44137672[["εNFA1-31 char{1, 1}"]]
eNFA1_35_61694733[["εNFA1-35 char{1, 1}"]]
eNFA1_37_18381693[["εNFA1-37 char{1, 1}"]]
eNFA1_41_31217511[["εNFA1-41 scope{1, 1}"]]
eNFA1_1_61214084[["εNFA1-1 char[1]"]]
eNFA1_12_59393791[["εNFA1-12 char[1]"]]
eNFA1_16_46167779[["εNFA1-16 char[1]"]]
eNFA1_20_48602582[["εNFA1-20 char[1]"]]
eNFA1_24_44495107[["εNFA1-24 char[1]"]]
eNFA1_28_8323748[\"εNFA1-28 scope[1]"/]
eNFA1_30_56441067[\"εNFA1-30 char[1]"/]
eNFA1_32_47333904[["εNFA1-32 char[1]"]]
eNFA1_36_3134993[\"εNFA1-36 char[1]"/]
eNFA1_38_8840997[["εNFA1-38 char[1]"]]
eNFA1_42_52607899[\"εNFA1-42 scope[1]"/]
eNFA1_2_14055850[["εNFA1-2 char{1, 1}"]]
eNFA1_3_2636360[["εNFA1-3 char[1]"]]
eNFA1_13_64782076[["εNFA1-13 char{1, 1}"]]
eNFA1_14_19540260[\"εNFA1-14 char[1]"/]
eNFA1_17_12856827[["εNFA1-17 char{1, 1}"]]
eNFA1_18_41644613[\"εNFA1-18 char[1]"/]
eNFA1_21_34770062[["εNFA1-21 char{1, 1}"]]
eNFA1_22_39257203[\"εNFA1-22 char[1]"/]
eNFA1_25_64911646[["εNFA1-25 char{1, 1}"]]
eNFA1_26_17770510[\"εNFA1-26 char[1]"/]
eNFA1_10_38207563[\"εNFA1-10 regex end"/]
eNFA1_43_45032171[\"εNFA1-43 post-regex start"/]
eNFA1_44_12218585[\"εNFA1-44 post-regex end"/]
eNFA1_33_23351954[["εNFA1-33 char{1, 1}"]]
eNFA1_34_30125175[\"εNFA1-34 char[1]"/]
eNFA1_39_12460115[["εNFA1-39 char{1, 1}"]]
eNFA1_40_2691119[\"εNFA1-40 char[1]"/]
eNFA1_4_23727241[["εNFA1-4 scope{4, 4}"]]
eNFA1_5_42858408[["εNFA1-5 scope[1]"]]
eNFA1_6_3832595[["εNFA1-6 scope[2]"]]
eNFA1_7_34493359[["εNFA1-7 scope[3]"]]
eNFA1_8_6801564[\"εNFA1-8 scope[4]"/]
eNFA1_9_58724323 -.->|"ε"|eNFA1_0_59049685
eNFA1_9_58724323 -.->|"ε"|eNFA1_11_58756859
eNFA1_9_58724323 -.->|"ε"|eNFA1_15_61685123
eNFA1_9_58724323 -.->|"ε"|eNFA1_19_18295196
eNFA1_9_58724323 -.->|"ε"|eNFA1_23_30439043
eNFA1_9_58724323 -.->|"ε"|eNFA1_27_5515936
eNFA1_9_58724323 -.->|"ε"|eNFA1_29_49643428
eNFA1_9_58724323 -.->|"ε"|eNFA1_31_44137672
eNFA1_9_58724323 -.->|"ε"|eNFA1_35_61694733
eNFA1_9_58724323 -.->|"ε"|eNFA1_37_18381693
eNFA1_9_58724323 -.->|"ε"|eNFA1_41_31217511
eNFA1_9_58724323 -->|"#92;"|eNFA1_1_61214084
eNFA1_9_58724323 -->|"#92;"|eNFA1_12_59393791
eNFA1_9_58724323 -->|"#92;"|eNFA1_16_46167779
eNFA1_9_58724323 -->|"#92;"|eNFA1_20_48602582
eNFA1_9_58724323 -->|"#92;"|eNFA1_24_44495107
eNFA1_9_58724323 -->|"[#32;-Z]"|eNFA1_28_8323748
eNFA1_9_58724323 -->|"["|eNFA1_30_56441067
eNFA1_9_58724323 -->|"#92;"|eNFA1_32_47333904
eNFA1_9_58724323 -->|"]"|eNFA1_36_3134993
eNFA1_9_58724323 -->|"#92;"|eNFA1_38_8840997
eNFA1_9_58724323 -->|"[_-~]"|eNFA1_42_52607899
eNFA1_0_59049685 -->|"#92;"|eNFA1_1_61214084
eNFA1_11_58756859 -->|"#92;"|eNFA1_12_59393791
eNFA1_15_61685123 -->|"#92;"|eNFA1_16_46167779
eNFA1_19_18295196 -->|"#92;"|eNFA1_20_48602582
eNFA1_23_30439043 -->|"#92;"|eNFA1_24_44495107
eNFA1_27_5515936 -->|"[#32;-Z]"|eNFA1_28_8323748
eNFA1_29_49643428 -->|"["|eNFA1_30_56441067
eNFA1_31_44137672 -->|"#92;"|eNFA1_32_47333904
eNFA1_35_61694733 -->|"]"|eNFA1_36_3134993
eNFA1_37_18381693 -->|"#92;"|eNFA1_38_8840997
eNFA1_41_31217511 -->|"[_-~]"|eNFA1_42_52607899
eNFA1_1_61214084 -.->|"ε"|eNFA1_2_14055850
eNFA1_1_61214084 -->|"u"|eNFA1_3_2636360
eNFA1_12_59393791 -.->|"ε"|eNFA1_13_64782076
eNFA1_12_59393791 -->|"t"|eNFA1_14_19540260
eNFA1_16_46167779 -.->|"ε"|eNFA1_17_12856827
eNFA1_16_46167779 -->|"n"|eNFA1_18_41644613
eNFA1_20_48602582 -.->|"ε"|eNFA1_21_34770062
eNFA1_20_48602582 -->|"r"|eNFA1_22_39257203
eNFA1_24_44495107 -.->|"ε"|eNFA1_25_64911646
eNFA1_24_44495107 -->|"-"|eNFA1_26_17770510
eNFA1_28_8323748 -.->|"ε"|eNFA1_10_38207563
eNFA1_28_8323748 -.->|"ε"|eNFA1_43_45032171
eNFA1_28_8323748 -.->|"ε"|eNFA1_44_12218585
eNFA1_30_56441067 -.->|"ε"|eNFA1_10_38207563
eNFA1_30_56441067 -.->|"ε"|eNFA1_43_45032171
eNFA1_30_56441067 -.->|"ε"|eNFA1_44_12218585
eNFA1_32_47333904 -.->|"ε"|eNFA1_33_23351954
eNFA1_32_47333904 -->|"#92;"|eNFA1_34_30125175
eNFA1_36_3134993 -.->|"ε"|eNFA1_10_38207563
eNFA1_36_3134993 -.->|"ε"|eNFA1_43_45032171
eNFA1_36_3134993 -.->|"ε"|eNFA1_44_12218585
eNFA1_38_8840997 -.->|"ε"|eNFA1_39_12460115
eNFA1_38_8840997 -->|"^"|eNFA1_40_2691119
eNFA1_42_52607899 -.->|"ε"|eNFA1_10_38207563
eNFA1_42_52607899 -.->|"ε"|eNFA1_43_45032171
eNFA1_42_52607899 -.->|"ε"|eNFA1_44_12218585
eNFA1_2_14055850 -->|"u"|eNFA1_3_2636360
eNFA1_3_2636360 -.->|"ε"|eNFA1_4_23727241
eNFA1_3_2636360 -->|"[0-9]"|eNFA1_5_42858408
eNFA1_13_64782076 -->|"t"|eNFA1_14_19540260
eNFA1_14_19540260 -.->|"ε"|eNFA1_10_38207563
eNFA1_14_19540260 -.->|"ε"|eNFA1_43_45032171
eNFA1_14_19540260 -.->|"ε"|eNFA1_44_12218585
eNFA1_17_12856827 -->|"n"|eNFA1_18_41644613
eNFA1_18_41644613 -.->|"ε"|eNFA1_10_38207563
eNFA1_18_41644613 -.->|"ε"|eNFA1_43_45032171
eNFA1_18_41644613 -.->|"ε"|eNFA1_44_12218585
eNFA1_21_34770062 -->|"r"|eNFA1_22_39257203
eNFA1_22_39257203 -.->|"ε"|eNFA1_10_38207563
eNFA1_22_39257203 -.->|"ε"|eNFA1_43_45032171
eNFA1_22_39257203 -.->|"ε"|eNFA1_44_12218585
eNFA1_25_64911646 -->|"-"|eNFA1_26_17770510
eNFA1_26_17770510 -.->|"ε"|eNFA1_10_38207563
eNFA1_26_17770510 -.->|"ε"|eNFA1_43_45032171
eNFA1_26_17770510 -.->|"ε"|eNFA1_44_12218585
eNFA1_10_38207563 -.->|"ε"|eNFA1_43_45032171
eNFA1_10_38207563 -.->|"ε"|eNFA1_44_12218585
eNFA1_43_45032171 -.->|"ε"|eNFA1_44_12218585
eNFA1_33_23351954 -->|"#92;"|eNFA1_34_30125175
eNFA1_34_30125175 -.->|"ε"|eNFA1_10_38207563
eNFA1_34_30125175 -.->|"ε"|eNFA1_43_45032171
eNFA1_34_30125175 -.->|"ε"|eNFA1_44_12218585
eNFA1_39_12460115 -->|"^"|eNFA1_40_2691119
eNFA1_40_2691119 -.->|"ε"|eNFA1_10_38207563
eNFA1_40_2691119 -.->|"ε"|eNFA1_43_45032171
eNFA1_40_2691119 -.->|"ε"|eNFA1_44_12218585
eNFA1_4_23727241 -->|"[0-9]"|eNFA1_5_42858408
eNFA1_5_42858408 -->|"[0-9]"|eNFA1_6_3832595
eNFA1_6_3832595 -->|"[0-9]"|eNFA1_7_34493359
eNFA1_7_34493359 -->|"[0-9]"|eNFA1_8_6801564
eNFA1_8_6801564 -.->|"ε"|eNFA1_10_38207563
eNFA1_8_6801564 -.->|"ε"|eNFA1_43_45032171
eNFA1_8_6801564 -.->|"ε"|eNFA1_44_12218585
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
NFA1_9_50181360("NFA1-9 regex start")
NFA1_1_38158322("NFA1-1 char[1]")
NFA1_12_48979056("NFA1-12 char[1]")
NFA1_16_7880584("NFA1-16 char[1]")
NFA1_20_3816393("NFA1-20 char[1]")
NFA1_24_34347544("NFA1-24 char[1]")
NFA1_28_40692445[\"NFA1-28 scope[1]"/]
NFA1_30_30687689[\"NFA1-30 char[1]"/]
NFA1_32_7753749("NFA1-32 char[1]")
NFA1_36_2674882[\"NFA1-36 char[1]"/]
NFA1_38_24073946("NFA1-38 char[1]")
NFA1_42_15338924[\"NFA1-42 scope[1]"/]
NFA1_3_42004777("NFA1-3 char[1]")
NFA1_14_42498674[\"NFA1-14 char[1]"/]
NFA1_18_46943747[\"NFA1-18 char[1]"/]
NFA1_22_19840541[\"NFA1-22 char[1]"/]
NFA1_26_44347145[\"NFA1-26 char[1]"/]
NFA1_34_63579993[\"NFA1-34 char[1]"/]
NFA1_40_35349029[\"NFA1-40 char[1]"/]
NFA1_5_49705805("NFA1-5 scope[1]")
NFA1_6_44699068("NFA1-6 scope[2]")
NFA1_7_66747298("NFA1-7 scope[3]")
NFA1_8_63854776[\"NFA1-8 scope[4]"/]
NFA1_9_50181360 -->|"#92;"|NFA1_1_38158322
NFA1_9_50181360 -->|"#92;"|NFA1_12_48979056
NFA1_9_50181360 -->|"#92;"|NFA1_16_7880584
NFA1_9_50181360 -->|"#92;"|NFA1_20_3816393
NFA1_9_50181360 -->|"#92;"|NFA1_24_34347544
NFA1_9_50181360 -->|"[#32;-Z]"|NFA1_28_40692445
NFA1_9_50181360 -->|"["|NFA1_30_30687689
NFA1_9_50181360 -->|"#92;"|NFA1_32_7753749
NFA1_9_50181360 -->|"]"|NFA1_36_2674882
NFA1_9_50181360 -->|"#92;"|NFA1_38_24073946
NFA1_9_50181360 -->|"[_-~]"|NFA1_42_15338924
NFA1_1_38158322 -->|"u"|NFA1_3_42004777
NFA1_12_48979056 -->|"t"|NFA1_14_42498674
NFA1_16_7880584 -->|"n"|NFA1_18_46943747
NFA1_20_3816393 -->|"r"|NFA1_22_19840541
NFA1_24_34347544 -->|"-"|NFA1_26_44347145
NFA1_32_7753749 -->|"#92;"|NFA1_34_63579993
NFA1_38_24073946 -->|"^"|NFA1_40_35349029
NFA1_3_42004777 -->|"[0-9]"|NFA1_5_49705805
NFA1_5_49705805 -->|"[0-9]"|NFA1_6_44699068
NFA1_6_44699068 -->|"[0-9]"|NFA1_7_66747298
NFA1_7_66747298 -->|"[0-9]"|NFA1_8_63854776
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
subgraph DFA0_-291112809["DFA0 regex start"]
NFA1_9_50181360_0("NFA1-9 regex start")
end
subgraph DFA1_-124490058["DFA1 {7}"]
NFA1_1_38158322_1("NFA1-1 char[1]")
NFA1_12_48979056_2("NFA1-12 char[1]")
NFA1_16_7880584_3("NFA1-16 char[1]")
NFA1_20_3816393_4("NFA1-20 char[1]")
NFA1_24_34347544_5("NFA1-24 char[1]")
NFA1_32_7753749_6("NFA1-32 char[1]")
NFA1_38_24073946_7("NFA1-38 char[1]")
end
subgraph DFA2_1602388786["DFA2 {1}"]
NFA1_28_40692445_8[\"NFA1-28 scope[1]"/]
end
subgraph DFA3_1149589413["DFA3 {1}"]
NFA1_30_30687689_9[\"NFA1-30 char[1]"/]
end
subgraph DFA4_-2042664595["DFA4 {1}"]
NFA1_36_2674882_10[\"NFA1-36 char[1]"/]
end
subgraph DFA5_-497080198["DFA5 {1}"]
NFA1_42_15338924_11[\"NFA1-42 scope[1]"/]
end
subgraph DFA6_-747584832["DFA6 {1}"]
NFA1_3_42004777_12("NFA1-3 char[1]")
end
subgraph DFA7_354333142["DFA7 {1}"]
NFA1_14_42498674_13[\"NFA1-14 char[1]"/]
end
subgraph DFA8_1690430939["DFA8 {1}"]
NFA1_18_46943747_14[\"NFA1-18 char[1]"/]
end
subgraph DFA9_-245099455["DFA9 {1}"]
NFA1_22_19840541_15[\"NFA1-22 char[1]"/]
end
subgraph DFA10_-736316886["DFA10 {1}"]
NFA1_26_44347145_16[\"NFA1-26 char[1]"/]
end
subgraph DFA11_323231976["DFA11 {1}"]
NFA1_34_63579993_17[\"NFA1-34 char[1]"/]
end
subgraph DFA12_-2054564977["DFA12 {1}"]
NFA1_40_35349029_18[\"NFA1-40 char[1]"/]
end
subgraph DFA13_-1544868987["DFA13 {1}"]
NFA1_5_49705805_19("NFA1-5 scope[1]")
end
subgraph DFA14_691089247["DFA14 {1}"]
NFA1_6_44699068_20("NFA1-6 scope[2]")
end
subgraph DFA15_1520560464["DFA15 {1}"]
NFA1_7_66747298_21("NFA1-7 scope[3]")
end
subgraph DFA16_-1860244244["DFA16 {1}"]
NFA1_8_63854776_22[\"NFA1-8 scope[4]"/]
end
DFA0_-291112809 -->|"#92;"|DFA1_-124490058
DFA0_-291112809 -->|"[#32;-Z]"|DFA2_1602388786
DFA0_-291112809 -->|"["|DFA3_1149589413
DFA0_-291112809 -->|"]"|DFA4_-2042664595
DFA0_-291112809 -->|"[_-~]"|DFA5_-497080198
DFA1_-124490058 -->|"u"|DFA6_-747584832
DFA1_-124490058 -->|"t"|DFA7_354333142
DFA1_-124490058 -->|"n"|DFA8_1690430939
DFA1_-124490058 -->|"r"|DFA9_-245099455
DFA1_-124490058 -->|"-"|DFA10_-736316886
DFA1_-124490058 -->|"#92;"|DFA11_323231976
DFA1_-124490058 -->|"^"|DFA12_-2054564977
DFA6_-747584832 -->|"[0-9]"|DFA13_-1544868987
DFA13_-1544868987 -->|"[0-9]"|DFA14_691089247
DFA14_691089247 -->|"[0-9]"|DFA15_1520560464
DFA15_1520560464 -->|"[0-9]"|DFA16_-1860244244
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
DFA0_-291112809{{"DFA0 regex start"}}
DFA1_-124490058{{"DFA1 {7}"}}
DFA2_1602388786[\"DFA2 {1}"/]
DFA3_1149589413[\"DFA3 {1}"/]
DFA4_-2042664595[\"DFA4 {1}"/]
DFA5_-497080198[\"DFA5 {1}"/]
DFA6_-747584832{{"DFA6 {1}"}}
DFA7_354333142[\"DFA7 {1}"/]
DFA8_1690430939[\"DFA8 {1}"/]
DFA9_-245099455[\"DFA9 {1}"/]
DFA10_-736316886[\"DFA10 {1}"/]
DFA11_323231976[\"DFA11 {1}"/]
DFA12_-2054564977[\"DFA12 {1}"/]
DFA13_-1544868987{{"DFA13 {1}"}}
DFA14_691089247{{"DFA14 {1}"}}
DFA15_1520560464{{"DFA15 {1}"}}
DFA16_-1860244244[\"DFA16 {1}"/]
DFA0_-291112809 -->|"#92;"|DFA1_-124490058
DFA0_-291112809 -->|"[#32;-Z]"|DFA2_1602388786
DFA0_-291112809 -->|"["|DFA3_1149589413
DFA0_-291112809 -->|"]"|DFA4_-2042664595
DFA0_-291112809 -->|"[_-~]"|DFA5_-497080198
DFA1_-124490058 -->|"u"|DFA6_-747584832
DFA1_-124490058 -->|"t"|DFA7_354333142
DFA1_-124490058 -->|"n"|DFA8_1690430939
DFA1_-124490058 -->|"r"|DFA9_-245099455
DFA1_-124490058 -->|"-"|DFA10_-736316886
DFA1_-124490058 -->|"#92;"|DFA11_323231976
DFA1_-124490058 -->|"^"|DFA12_-2054564977
DFA6_-747584832 -->|"[0-9]"|DFA13_-1544868987
DFA13_-1544868987 -->|"[0-9]"|DFA14_691089247
DFA14_691089247 -->|"[0-9]"|DFA15_1520560464
DFA15_1520560464 -->|"[0-9]"|DFA16_-1860244244
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
subgraph MiniDFA0_1560752186["MiniDFA0 {1}"]
DFA0_-291112809_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_315920310["MiniDFA1 {1}"]
DFA1_-124490058_1{{"DFA1 {7}"}}
end
subgraph MiniDFA6_1953595583["MiniDFA6 {1}"]
DFA2_1602388786_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_590350089["MiniDFA7 {1}"]
DFA3_1149589413_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_841839095["MiniDFA8 {1}"]
DFA4_-2042664595_4[\"DFA4 {1}"/]
end
subgraph MiniDFA9_-1824705656["MiniDFA9 {1}"]
DFA5_-497080198_5[\"DFA5 {1}"/]
end
subgraph MiniDFA2_854329805["MiniDFA2 {1}"]
DFA6_-747584832_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_901085138["MiniDFA10 {1}"]
DFA7_354333142_7[\"DFA7 {1}"/]
end
subgraph MiniDFA11_1112496283["MiniDFA11 {1}"]
DFA8_1690430939_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_1927725372["MiniDFA12 {1}"]
DFA9_-245099455_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_1652291077["MiniDFA13 {1}"]
DFA10_-736316886_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_-1012714072["MiniDFA14 {1}"]
DFA11_323231976_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_-343357867["MiniDFA15 {1}"]
DFA12_-2054564977_12[\"DFA12 {1}"/]
end
subgraph MiniDFA3_-185040614["MiniDFA3 {1}"]
DFA13_-1544868987_13{{"DFA13 {1}"}}
end
subgraph MiniDFA4_-993488692["MiniDFA4 {1}"]
DFA14_691089247_14{{"DFA14 {1}"}}
end
subgraph MiniDFA5_-1862201485["MiniDFA5 {1}"]
DFA15_1520560464_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_248852859["MiniDFA16 {1}"]
DFA16_-1860244244_16[\"DFA16 {1}"/]
end
MiniDFA0_1560752186 -->|"#92;"|MiniDFA1_315920310
MiniDFA0_1560752186 -->|"[#32;-Z]"|MiniDFA6_1953595583
MiniDFA0_1560752186 -->|"["|MiniDFA7_590350089
MiniDFA0_1560752186 -->|"]"|MiniDFA8_841839095
MiniDFA0_1560752186 -->|"[_-~]"|MiniDFA9_-1824705656
MiniDFA1_315920310 -->|"u"|MiniDFA2_854329805
MiniDFA1_315920310 -->|"t"|MiniDFA10_901085138
MiniDFA1_315920310 -->|"n"|MiniDFA11_1112496283
MiniDFA1_315920310 -->|"r"|MiniDFA12_1927725372
MiniDFA1_315920310 -->|"-"|MiniDFA13_1652291077
MiniDFA1_315920310 -->|"#92;"|MiniDFA14_-1012714072
MiniDFA1_315920310 -->|"^"|MiniDFA15_-343357867
MiniDFA2_854329805 -->|"[0-9]"|MiniDFA3_-185040614
MiniDFA3_-185040614 -->|"[0-9]"|MiniDFA4_-993488692
MiniDFA4_-993488692 -->|"[0-9]"|MiniDFA5_-1862201485
MiniDFA5_-1862201485 -->|"[0-9]"|MiniDFA16_248852859
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
MiniDFA0_1560752186(["MiniDFA0 {1}"])
MiniDFA1_315920310(["MiniDFA1 {1}"])
MiniDFA6_1953595583[\"MiniDFA6 {1}"/]
MiniDFA7_590350089[\"MiniDFA7 {1}"/]
MiniDFA8_841839095[\"MiniDFA8 {1}"/]
MiniDFA9_-1824705656[\"MiniDFA9 {1}"/]
MiniDFA2_854329805(["MiniDFA2 {1}"])
MiniDFA10_901085138[\"MiniDFA10 {1}"/]
MiniDFA11_1112496283[\"MiniDFA11 {1}"/]
MiniDFA12_1927725372[\"MiniDFA12 {1}"/]
MiniDFA13_1652291077[\"MiniDFA13 {1}"/]
MiniDFA14_-1012714072[\"MiniDFA14 {1}"/]
MiniDFA15_-343357867[\"MiniDFA15 {1}"/]
MiniDFA3_-185040614(["MiniDFA3 {1}"])
MiniDFA4_-993488692(["MiniDFA4 {1}"])
MiniDFA5_-1862201485(["MiniDFA5 {1}"])
MiniDFA16_248852859[\"MiniDFA16 {1}"/]
MiniDFA0_1560752186 -->|"#92;"|MiniDFA1_315920310
MiniDFA0_1560752186 -->|"[#32;-Z]"|MiniDFA6_1953595583
MiniDFA0_1560752186 -->|"["|MiniDFA7_590350089
MiniDFA0_1560752186 -->|"]"|MiniDFA8_841839095
MiniDFA0_1560752186 -->|"[_-~]"|MiniDFA9_-1824705656
MiniDFA1_315920310 -->|"u"|MiniDFA2_854329805
MiniDFA1_315920310 -->|"t"|MiniDFA10_901085138
MiniDFA1_315920310 -->|"n"|MiniDFA11_1112496283
MiniDFA1_315920310 -->|"r"|MiniDFA12_1927725372
MiniDFA1_315920310 -->|"-"|MiniDFA13_1652291077
MiniDFA1_315920310 -->|"#92;"|MiniDFA14_-1012714072
MiniDFA1_315920310 -->|"^"|MiniDFA15_-343357867
MiniDFA2_854329805 -->|"[0-9]"|MiniDFA3_-185040614
MiniDFA3_-185040614 -->|"[0-9]"|MiniDFA4_-993488692
MiniDFA4_-993488692 -->|"[0-9]"|MiniDFA5_-1862201485
MiniDFA5_-1862201485 -->|"[0-9]"|MiniDFA16_248852859
```
-------------------------------
