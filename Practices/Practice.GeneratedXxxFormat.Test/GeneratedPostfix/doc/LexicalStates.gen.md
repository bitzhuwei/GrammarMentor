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
eNFA0_0_56141706[["εNFA0-0 wholeStart"]]
eNFA1_2_334102[["εNFA1-2 regex start"]]
class eNFA1_2_334102 c1000;
eNFA2_2_35513308[["εNFA2-2 regex start"]]
class eNFA2_2_35513308 c1000;
eNFA3_2_839735[["εNFA3-2 regex start"]]
class eNFA3_2_839735 c1000;
eNFA4_16_9941070[["εNFA4-16 regex start"]]
class eNFA4_16_9941070 c1000;
eNFA5_5_7649781[["εNFA5-5 regex start"]]
class eNFA5_5_7649781 c1000;
eNFA1_0_33972808[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_52888890[["εNFA2-0 scope{1, ∞}"]]
eNFA3_0_909717[["εNFA3-0 char{1, 1}"]]
eNFA4_0_67029240[["εNFA4-0 char{1, 1}"]]
eNFA5_0_15652561[["εNFA5-0 char{1, 1}"]]
eNFA1_1_33600918[["εNFA1-1 scope[1]"]]
eNFA2_1_65528866[["εNFA2-1 scope[1]"]]
eNFA3_1_8187461[["εNFA3-1 char[1]"]]
eNFA4_1_48033450[["εNFA4-1 char[1]"]]
eNFA5_1_29647872[["εNFA5-1 char[1]"]]
eNFA1_3_37319824[["εNFA1-3 regex end"]]
class eNFA1_3_37319824 c0100;
eNFA2_3_6237967[["εNFA2-3 regex end"]]
class eNFA2_3_6237967 c0100;
eNFA3_3_6578292[["εNFA3-3 regex end"]]
class eNFA3_3_6578292 c0100;
eNFA4_2_180812[["εNFA4-2 char{1, 1}"]]
eNFA5_2_1627311[["εNFA5-2 char{1, 1}"]]
eNFA1_6_3006923[["εNFA1-6 regex start"]]
class eNFA1_6_3006923 c0010;
eNFA2_4_52289087[["εNFA2-4 post-regex start"]]
class eNFA2_4_52289087 c0010;
eNFA3_4_59204636[["εNFA3-4 post-regex start"]]
class eNFA3_4_59204636 c0010;
eNFA4_3_5391908[["εNFA4-3 char[1]"]]
eNFA5_3_63060783[["εNFA5-3 char[1]"]]
eNFA1_4_27062312[["εNFA1-4 char{1, 1}"]]
eNFA2_5_51184318[\"εNFA2-5 post-regex end"/]
class eNFA2_5_51184318 c0001;
eNFA3_5_7557620[\"εNFA3-5 post-regex end"/]
class eNFA3_5_7557620 c0001;
eNFA4_6_63079676[["εNFA4-6 regex start"]]
eNFA5_4_14463294[["εNFA5-4 char{0, ∞}"]]
eNFA1_5_42234223[["εNFA1-5 char[1]"]]
eNFA0_1_58005681[\"εNFA0-1 wholeEnd"/]
eNFA4_4_9180116[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_30846174[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_15512181[["εNFA4-7 regex end"]]
eNFA5_6_30676137[["εNFA5-6 regex end"]]
class eNFA5_6_30676137 c0100;
eNFA1_7_44563687[\"εNFA1-7 regex end"/]
class eNFA1_7_44563687 c0001;
eNFA4_5_34091413[["εNFA4-5 scope[1]"]]
eNFA4_9_33444533[["εNFA4-9 scope[1]"]]
eNFA4_12_48527177[["εNFA4-12 char{1, 1}"]]
eNFA5_7_6655321[["εNFA5-7 post-regex start"]]
class eNFA5_7_6655321 c0010;
eNFA4_10_53734436[["εNFA4-10 scope{1, 1}"]]
eNFA4_13_13847879[["εNFA4-13 char[1]"]]
eNFA5_8_1739173[\"εNFA5-8 post-regex end"/]
class eNFA5_8_1739173 c0001;
eNFA4_11_38387265[["εNFA4-11 scope[1]"]]
eNFA4_14_57522049[["εNFA4-14 char{1, 1}"]]
eNFA4_15_66392255[["εNFA4-15 char[1]"]]
eNFA4_17_60659387[["εNFA4-17 regex end"]]
class eNFA4_17_60659387 c0100;
eNFA4_18_9063573[["εNFA4-18 post-regex start"]]
class eNFA4_18_9063573 c0010;
eNFA4_19_22360774[\"εNFA4-19 post-regex end"/]
class eNFA4_19_22360774 c0001;
eNFA0_0_56141706 -.->|"ε"|eNFA1_2_334102
eNFA0_0_56141706 -.->|"ε"|eNFA2_2_35513308
eNFA0_0_56141706 -.->|"ε"|eNFA3_2_839735
eNFA0_0_56141706 -.->|"ε"|eNFA4_16_9941070
eNFA0_0_56141706 -.->|"ε"|eNFA5_5_7649781
eNFA1_2_334102 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_33972808
eNFA2_2_35513308 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_52888890
eNFA3_2_839735 -.->|"ε
BeginToken '='"|eNFA3_0_909717
eNFA4_16_9941070 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_67029240
eNFA5_5_7649781 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_15652561
eNFA1_0_33972808 -->|"[0-9]"|eNFA1_1_33600918
eNFA2_0_52888890 -->|"[0-9]"|eNFA2_1_65528866
eNFA3_0_909717 -->|"="|eNFA3_1_8187461
eNFA4_0_67029240 -->|"/"|eNFA4_1_48033450
eNFA5_0_15652561 -->|"/"|eNFA5_1_29647872
eNFA1_1_33600918 -->|"[0-9]"|eNFA1_1_33600918
eNFA1_1_33600918 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_37319824
eNFA2_1_65528866 -->|"[0-9]"|eNFA2_1_65528866
eNFA2_1_65528866 -.->|"ε
ExtendToken 'refEntity'"|eNFA2_3_6237967
eNFA3_1_8187461 -.->|"ε
ExtendToken '='"|eNFA3_3_6578292
eNFA4_1_48033450 -.->|"ε"|eNFA4_2_180812
eNFA5_1_29647872 -.->|"ε"|eNFA5_2_1627311
eNFA1_3_37319824 -.->|"ε"|eNFA1_6_3006923
eNFA2_3_6237967 -.->|"ε"|eNFA2_4_52289087
eNFA3_3_6578292 -.->|"ε"|eNFA3_4_59204636
eNFA4_2_180812 -->|"*"|eNFA4_3_5391908
eNFA5_2_1627311 -->|"/"|eNFA5_3_63060783
eNFA1_6_3006923 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_27062312
eNFA2_4_52289087 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_51184318
eNFA3_4_59204636 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_7557620
eNFA4_3_5391908 -.->|"ε"|eNFA4_6_63079676
eNFA5_3_63060783 -.->|"ε"|eNFA5_4_14463294
eNFA1_4_27062312 -->|"="|eNFA1_5_42234223
eNFA2_5_51184318 -.->|"ε"|eNFA0_1_58005681
eNFA3_5_7557620 -.->|"ε"|eNFA0_1_58005681
eNFA4_6_63079676 -.->|"ε"|eNFA4_4_9180116
eNFA4_6_63079676 -.->|"ε"|eNFA4_8_30846174
eNFA4_6_63079676 -.->|"ε"|eNFA4_7_15512181
eNFA5_4_14463294 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_14463294
eNFA5_4_14463294 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_30676137
eNFA1_5_42234223 -.->|"ε
AcceptToken 'entityId'"|eNFA1_7_44563687
eNFA4_4_9180116 -->|"[^*]"|eNFA4_5_34091413
eNFA4_8_30846174 -->|"[*]"|eNFA4_9_33444533
eNFA4_7_15512181 -.->|"ε"|eNFA4_6_63079676
eNFA4_7_15512181 -.->|"ε"|eNFA4_12_48527177
eNFA5_6_30676137 -.->|"ε"|eNFA5_7_6655321
eNFA1_7_44563687 -.->|"ε"|eNFA0_1_58005681
eNFA4_5_34091413 -.->|"ε"|eNFA4_7_15512181
eNFA4_9_33444533 -.->|"ε"|eNFA4_10_53734436
eNFA4_12_48527177 -->|"*"|eNFA4_13_13847879
eNFA5_7_6655321 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_1739173
eNFA4_10_53734436 -->|"[^/]"|eNFA4_11_38387265
eNFA4_13_13847879 -.->|"ε"|eNFA4_14_57522049
eNFA5_8_1739173 -.->|"ε"|eNFA0_1_58005681
eNFA4_11_38387265 -.->|"ε"|eNFA4_7_15512181
eNFA4_14_57522049 -->|"/"|eNFA4_15_66392255
eNFA4_15_66392255 -.->|"ε
ExtendToken 'blockComment'"|eNFA4_17_60659387
eNFA4_17_60659387 -.->|"ε"|eNFA4_18_9063573
eNFA4_18_9063573 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_22360774
eNFA4_19_22360774 -.->|"ε"|eNFA0_1_58005681
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
eNFA0_0_59897896[["εNFA0-0 wholeStart"]]
class eNFA0_0_59897896 c1000;
eNFA1_2_19891428[["εNFA1-2 regex start"]]
class eNFA1_2_19891428 c1000;
eNFA2_2_2210158[["εNFA2-2 regex start"]]
class eNFA2_2_2210158 c1000;
eNFA3_2_44805132[["εNFA3-2 regex start"]]
class eNFA3_2_44805132 c1000;
eNFA4_16_593005[["εNFA4-16 regex start"]]
class eNFA4_16_593005 c1000;
eNFA5_5_5337050[["εNFA5-5 regex start"]]
class eNFA5_5_5337050 c1000;
eNFA1_0_52667431[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_52667431 c1000;
eNFA2_0_8287277[["εNFA2-0 scope{1, ∞}"]]
class eNFA2_0_8287277 c1000;
eNFA3_0_54046809[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_54046809 c1000;
eNFA4_0_64991193[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_64991193 c1000;
eNFA5_0_64605626[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_64605626 c1000;
eNFA1_1_65504260[["εNFA1-1 scope[1]"]]
class eNFA1_1_65504260 c0110;
eNFA2_1_38203510[\"εNFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class eNFA2_1_38203510 c0111;
eNFA3_1_16659241[\"εNFA3-1 char[1]
AcceptToken '='"/]
class eNFA3_1_16659241 c0111;
eNFA4_1_65673219[["εNFA4-1 char[1]"]]
eNFA5_1_17930557[["εNFA5-1 char[1]"]]
eNFA1_3_4244834[["εNFA1-3 regex end"]]
class eNFA1_3_4244834 c0110;
eNFA1_6_49022972[["εNFA1-6 regex start"]]
class eNFA1_6_49022972 c0010;
eNFA1_4_38553569[["εNFA1-4 char{1, 1}"]]
class eNFA1_4_38553569 c0010;
eNFA1_5_11437802[\"εNFA1-5 char[1]
AcceptToken 'entityId'"/]
class eNFA1_5_11437802 c0001;
eNFA2_3_7476630[\"εNFA2-3 regex end
AcceptToken 'refEntity'"/]
class eNFA2_3_7476630 c0111;
eNFA2_4_35831362[\"εNFA2-4 post-regex start
AcceptToken 'refEntity'"/]
class eNFA2_4_35831362 c0011;
eNFA2_5_45459112[\"εNFA2-5 post-regex end"/]
class eNFA2_5_45459112 c0011;
eNFA0_1_64703336[\"εNFA0-1 wholeEnd"/]
eNFA3_3_15715441[\"εNFA3-3 regex end
AcceptToken '='"/]
class eNFA3_3_15715441 c0111;
eNFA3_4_7221243[\"εNFA3-4 post-regex start
AcceptToken '='"/]
class eNFA3_4_7221243 c0011;
eNFA3_5_14645800[\"εNFA3-5 post-regex end"/]
class eNFA3_5_14645800 c0011;
eNFA4_2_43089040[["εNFA4-2 char{1, 1}"]]
eNFA4_3_32565348[["εNFA4-3 char[1]"]]
eNFA5_2_27157292[["εNFA5-2 char{1, 1}"]]
eNFA5_3_47637651[\"εNFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA5_3_47637651 c0111;
eNFA1_7_20547495[\"εNFA1-7 regex end"/]
class eNFA1_7_20547495 c0001;
eNFA4_6_6478825[["εNFA4-6 regex start"]]
eNFA4_4_55022811[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_58309428[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_25443253[["εNFA4-7 regex end"]]
eNFA4_5_50709735[["εNFA4-5 scope[1]"]]
eNFA4_9_52257042[["εNFA4-9 scope[1]"]]
eNFA4_12_24652676[["εNFA4-12 char{1, 1}"]]
eNFA4_13_4961980[["εNFA4-13 char[1]"]]
eNFA5_4_27662693[\"εNFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA5_4_27662693 c0111;
eNFA5_6_26085680[\"εNFA5-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA5_6_26085680 c0111;
eNFA5_7_44579726[\"εNFA5-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA5_7_44579726 c0011;
eNFA5_8_47936395[\"εNFA5-8 post-regex end"/]
class eNFA5_8_47936395 c0011;
eNFA4_10_551331[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_28774374[["εNFA4-11 scope[1]"]]
eNFA4_14_54188067[["εNFA4-14 char{1, 1}"]]
eNFA4_15_48049826[\"εNFA4-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA4_15_48049826 c0111;
eNFA4_17_29795257[\"εNFA4-17 regex end
AcceptToken 'blockComment'"/]
class eNFA4_17_29795257 c0111;
eNFA4_18_66830726[\"εNFA4-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA4_18_66830726 c0011;
eNFA4_19_57642780[\"εNFA4-19 post-regex end"/]
class eNFA4_19_57642780 c0011;
eNFA0_0_59897896 -.->|"ε"|eNFA1_2_19891428
eNFA0_0_59897896 -.->|"ε"|eNFA2_2_2210158
eNFA0_0_59897896 -.->|"ε"|eNFA3_2_44805132
eNFA0_0_59897896 -.->|"ε"|eNFA4_16_593005
eNFA0_0_59897896 -.->|"ε"|eNFA5_5_5337050
eNFA0_0_59897896 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_52667431
eNFA0_0_59897896 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_8287277
eNFA0_0_59897896 -.->|"ε
BeginToken '='"|eNFA3_0_54046809
eNFA0_0_59897896 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_64991193
eNFA0_0_59897896 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_64605626
eNFA0_0_59897896 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_65504260
eNFA0_0_59897896 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_38203510
eNFA0_0_59897896 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_16659241
eNFA0_0_59897896 -->|"/
BeginToken 'blockComment'"|eNFA4_1_65673219
eNFA0_0_59897896 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_17930557
eNFA1_2_19891428 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_52667431
eNFA1_2_19891428 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_65504260
eNFA2_2_2210158 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_8287277
eNFA2_2_2210158 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_38203510
eNFA3_2_44805132 -.->|"ε
BeginToken '='"|eNFA3_0_54046809
eNFA3_2_44805132 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_16659241
eNFA4_16_593005 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_64991193
eNFA4_16_593005 -->|"/
BeginToken 'blockComment'"|eNFA4_1_65673219
eNFA5_5_5337050 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_64605626
eNFA5_5_5337050 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_17930557
eNFA1_0_52667431 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_65504260
eNFA2_0_8287277 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_38203510
eNFA3_0_54046809 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_16659241
eNFA4_0_64991193 -->|"/
BeginToken 'blockComment'"|eNFA4_1_65673219
eNFA5_0_64605626 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_17930557
eNFA1_1_65504260 -->|"[0-9]
ExtendToken 'entityId'"|eNFA1_1_65504260
eNFA1_1_65504260 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_4244834
eNFA1_1_65504260 -.->|"ε"|eNFA1_6_49022972
eNFA1_1_65504260 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_38553569
eNFA1_1_65504260 -->|"=
CheckToken 'entityId'"|eNFA1_5_11437802
eNFA2_1_38203510 -->|"[0-9]
ExtendToken 'refEntity'"|eNFA2_1_38203510
eNFA2_1_38203510 -.->|"ε
ExtendToken 'refEntity'"|eNFA2_3_7476630
eNFA2_1_38203510 -.->|"ε"|eNFA2_4_35831362
eNFA2_1_38203510 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_45459112
eNFA2_1_38203510 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_64703336
eNFA3_1_16659241 -.->|"ε
ExtendToken '='"|eNFA3_3_15715441
eNFA3_1_16659241 -.->|"ε"|eNFA3_4_7221243
eNFA3_1_16659241 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_14645800
eNFA3_1_16659241 -.->|"ε
CheckToken '='"|eNFA0_1_64703336
eNFA4_1_65673219 -.->|"ε"|eNFA4_2_43089040
eNFA4_1_65673219 -->|"*"|eNFA4_3_32565348
eNFA5_1_17930557 -.->|"ε"|eNFA5_2_27157292
eNFA5_1_17930557 -->|"/
ExtendToken 'inlineComment'"|eNFA5_3_47637651
eNFA1_3_4244834 -.->|"ε"|eNFA1_6_49022972
eNFA1_3_4244834 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_38553569
eNFA1_3_4244834 -->|"=
CheckToken 'entityId'"|eNFA1_5_11437802
eNFA1_6_49022972 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_38553569
eNFA1_6_49022972 -->|"=
CheckToken 'entityId'"|eNFA1_5_11437802
eNFA1_4_38553569 -->|"=
CheckToken 'entityId'"|eNFA1_5_11437802
eNFA1_5_11437802 -.->|"ε
AcceptToken 'entityId'"|eNFA1_7_20547495
eNFA1_5_11437802 -.->|"ε"|eNFA0_1_64703336
eNFA2_3_7476630 -.->|"ε"|eNFA2_4_35831362
eNFA2_3_7476630 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_45459112
eNFA2_3_7476630 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_64703336
eNFA2_4_35831362 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_45459112
eNFA2_4_35831362 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_64703336
eNFA2_5_45459112 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_64703336
eNFA3_3_15715441 -.->|"ε"|eNFA3_4_7221243
eNFA3_3_15715441 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_14645800
eNFA3_3_15715441 -.->|"ε
CheckToken '='"|eNFA0_1_64703336
eNFA3_4_7221243 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_14645800
eNFA3_4_7221243 -.->|"ε
CheckToken '='"|eNFA0_1_64703336
eNFA3_5_14645800 -.->|"ε
CheckToken '='"|eNFA0_1_64703336
eNFA4_2_43089040 -->|"*"|eNFA4_3_32565348
eNFA4_3_32565348 -.->|"ε"|eNFA4_6_6478825
eNFA4_3_32565348 -.->|"ε"|eNFA4_4_55022811
eNFA4_3_32565348 -.->|"ε"|eNFA4_8_58309428
eNFA4_3_32565348 -.->|"ε"|eNFA4_7_25443253
eNFA4_3_32565348 -->|"[^*]"|eNFA4_5_50709735
eNFA4_3_32565348 -->|"[*]"|eNFA4_9_52257042
eNFA4_3_32565348 -.->|"ε"|eNFA4_12_24652676
eNFA4_3_32565348 -->|"*"|eNFA4_13_4961980
eNFA5_2_27157292 -->|"/
ExtendToken 'inlineComment'"|eNFA5_3_47637651
eNFA5_3_47637651 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_4_27662693
eNFA5_3_47637651 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA5_4_27662693
eNFA5_3_47637651 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_26085680
eNFA5_3_47637651 -.->|"ε"|eNFA5_7_44579726
eNFA5_3_47637651 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_47936395
eNFA5_3_47637651 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_64703336
eNFA1_7_20547495 -.->|"ε"|eNFA0_1_64703336
eNFA4_6_6478825 -.->|"ε"|eNFA4_4_55022811
eNFA4_6_6478825 -.->|"ε"|eNFA4_8_58309428
eNFA4_6_6478825 -.->|"ε"|eNFA4_7_25443253
eNFA4_6_6478825 -->|"[^*]"|eNFA4_5_50709735
eNFA4_6_6478825 -->|"[*]"|eNFA4_9_52257042
eNFA4_6_6478825 -.->|"ε"|eNFA4_6_6478825
eNFA4_6_6478825 -.->|"ε"|eNFA4_12_24652676
eNFA4_6_6478825 -->|"*"|eNFA4_13_4961980
eNFA4_4_55022811 -->|"[^*]"|eNFA4_5_50709735
eNFA4_8_58309428 -->|"[*]"|eNFA4_9_52257042
eNFA4_7_25443253 -.->|"ε"|eNFA4_6_6478825
eNFA4_7_25443253 -.->|"ε"|eNFA4_12_24652676
eNFA4_7_25443253 -.->|"ε"|eNFA4_4_55022811
eNFA4_7_25443253 -.->|"ε"|eNFA4_8_58309428
eNFA4_7_25443253 -.->|"ε"|eNFA4_7_25443253
eNFA4_7_25443253 -->|"[^*]"|eNFA4_5_50709735
eNFA4_7_25443253 -->|"[*]"|eNFA4_9_52257042
eNFA4_7_25443253 -->|"*"|eNFA4_13_4961980
eNFA4_5_50709735 -.->|"ε"|eNFA4_7_25443253
eNFA4_5_50709735 -.->|"ε"|eNFA4_6_6478825
eNFA4_5_50709735 -.->|"ε"|eNFA4_12_24652676
eNFA4_5_50709735 -.->|"ε"|eNFA4_4_55022811
eNFA4_5_50709735 -.->|"ε"|eNFA4_8_58309428
eNFA4_5_50709735 -->|"[^*]"|eNFA4_5_50709735
eNFA4_5_50709735 -->|"[*]"|eNFA4_9_52257042
eNFA4_5_50709735 -->|"*"|eNFA4_13_4961980
eNFA4_9_52257042 -.->|"ε"|eNFA4_10_551331
eNFA4_9_52257042 -->|"[^/]"|eNFA4_11_28774374
eNFA4_12_24652676 -->|"*"|eNFA4_13_4961980
eNFA4_13_4961980 -.->|"ε"|eNFA4_14_54188067
eNFA4_13_4961980 -->|"/
ExtendToken 'blockComment'"|eNFA4_15_48049826
eNFA5_4_27662693 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA5_4_27662693
eNFA5_4_27662693 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_26085680
eNFA5_4_27662693 -.->|"ε"|eNFA5_7_44579726
eNFA5_4_27662693 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_47936395
eNFA5_4_27662693 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_64703336
eNFA5_6_26085680 -.->|"ε"|eNFA5_7_44579726
eNFA5_6_26085680 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_47936395
eNFA5_6_26085680 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_64703336
eNFA5_7_44579726 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_47936395
eNFA5_7_44579726 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_64703336
eNFA5_8_47936395 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_64703336
eNFA4_10_551331 -->|"[^/]"|eNFA4_11_28774374
eNFA4_11_28774374 -.->|"ε"|eNFA4_7_25443253
eNFA4_11_28774374 -.->|"ε"|eNFA4_6_6478825
eNFA4_11_28774374 -.->|"ε"|eNFA4_12_24652676
eNFA4_11_28774374 -.->|"ε"|eNFA4_4_55022811
eNFA4_11_28774374 -.->|"ε"|eNFA4_8_58309428
eNFA4_11_28774374 -->|"[^*]"|eNFA4_5_50709735
eNFA4_11_28774374 -->|"[*]"|eNFA4_9_52257042
eNFA4_11_28774374 -->|"*"|eNFA4_13_4961980
eNFA4_14_54188067 -->|"/
ExtendToken 'blockComment'"|eNFA4_15_48049826
eNFA4_15_48049826 -.->|"ε
ExtendToken 'blockComment'"|eNFA4_17_29795257
eNFA4_15_48049826 -.->|"ε"|eNFA4_18_66830726
eNFA4_15_48049826 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_57642780
eNFA4_15_48049826 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_64703336
eNFA4_17_29795257 -.->|"ε"|eNFA4_18_66830726
eNFA4_17_29795257 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_57642780
eNFA4_17_29795257 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_64703336
eNFA4_18_66830726 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_57642780
eNFA4_18_66830726 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_64703336
eNFA4_19_57642780 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_64703336
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
NFA0_0_44657822("NFA0-0 wholeStart")
class NFA0_0_44657822 c1000;
NFA1_1_66376082("NFA1-1 scope[1]")
class NFA1_1_66376082 c0110;
NFA2_1_60513834[\"NFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA2_1_60513834 c0101;
NFA3_1_7753598[\"NFA3-1 char[1]
AcceptToken '='"/]
class NFA3_1_7753598 c0101;
NFA4_1_2673518("NFA4-1 char[1]")
NFA5_1_24061669("NFA5-1 char[1]")
NFA1_5_15228435[\"NFA1-5 char[1]
AcceptToken 'entityId'"/]
class NFA1_5_15228435 c0001;
NFA4_3_25543745("NFA4-3 char[1]")
NFA5_3_2838193[\"NFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA5_3_2838193 c0101;
NFA4_5_55777439("NFA4-5 scope[1]")
NFA4_9_28567114("NFA4-9 scope[1]")
NFA4_13_32234903("NFA4-13 char[1]")
NFA5_4_21678677[\"NFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA5_4_21678677 c0101;
NFA4_11_11142412("NFA4-11 scope[1]")
NFA4_15_60890369[\"NFA4-15 char[1]
AcceptToken 'blockComment'"/]
class NFA4_15_60890369 c0101;
NFA0_0_44657822 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|NFA1_1_66376082
NFA0_0_44657822 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|NFA2_1_60513834
NFA0_0_44657822 -->|"=
BeginToken '='
ExtendToken '='"|NFA3_1_7753598
NFA0_0_44657822 -->|"/
BeginToken 'blockComment'"|NFA4_1_2673518
NFA0_0_44657822 -->|"/
BeginToken 'inlineComment'"|NFA5_1_24061669
NFA1_1_66376082 -->|"[0-9]
ExtendToken 'entityId'"|NFA1_1_66376082
NFA1_1_66376082 -->|"=
CheckToken 'entityId'"|NFA1_5_15228435
NFA2_1_60513834 -->|"[0-9]
ExtendToken 'refEntity'"|NFA2_1_60513834
NFA4_1_2673518 -->|"*"|NFA4_3_25543745
NFA5_1_24061669 -->|"/
ExtendToken 'inlineComment'"|NFA5_3_2838193
NFA4_3_25543745 -->|"[^*]"|NFA4_5_55777439
NFA4_3_25543745 -->|"[*]"|NFA4_9_28567114
NFA4_3_25543745 -->|"*"|NFA4_13_32234903
NFA5_3_2838193 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA5_4_21678677
NFA4_5_55777439 -->|"[^*]"|NFA4_5_55777439
NFA4_5_55777439 -->|"[*]"|NFA4_9_28567114
NFA4_5_55777439 -->|"*"|NFA4_13_32234903
NFA4_9_28567114 -->|"[^/]"|NFA4_11_11142412
NFA4_13_32234903 -->|"/
ExtendToken 'blockComment'"|NFA4_15_60890369
NFA5_4_21678677 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA5_4_21678677
NFA4_11_11142412 -->|"[^*]"|NFA4_5_55777439
NFA4_11_11142412 -->|"[*]"|NFA4_9_28567114
NFA4_11_11142412 -->|"*"|NFA4_13_32234903
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
subgraph DFA0_1257045888["DFA0 wholeStart"]
NFA0_0_44657822_0("NFA0-0 wholeStart")
class NFA0_0_44657822_0 c1000;
end
class DFA0_1257045888 c1000;
subgraph DFA1_1892905281["DFA1 {2}"]
NFA1_1_66376082_1("NFA1-1 scope[1]")
class NFA1_1_66376082_1 c0110;
NFA2_1_60513834_2[\"NFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA2_1_60513834_2 c0101;
end
class DFA1_1892905281 c0111;
subgraph DFA2_-1400778774["DFA2 {1}"]
NFA3_1_7753598_3[\"NFA3-1 char[1]
AcceptToken '='"/]
class NFA3_1_7753598_3 c0101;
end
class DFA2_-1400778774 c0101;
subgraph DFA3_1164797663["DFA3 {2}"]
NFA4_1_2673518_4("NFA4-1 char[1]")
NFA5_1_24061669_5("NFA5-1 char[1]")
end
subgraph DFA4_-561999181["DFA4 {1}"]
NFA1_5_15228435_6[\"NFA1-5 char[1]
AcceptToken 'entityId'"/]
class NFA1_5_15228435_6 c0001;
end
class DFA4_-561999181 c0001;
subgraph DFA5_1214651240["DFA5 {1}"]
NFA4_3_25543745_7("NFA4-3 char[1]")
end
subgraph DFA6_14562357["DFA6 {1}"]
NFA5_3_2838193_8[\"NFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA5_3_2838193_8 c0101;
end
class DFA6_14562357 c0101;
subgraph DFA7_392280436["DFA7 {1}"]
NFA4_5_55777439_9("NFA4-5 scope[1]")
end
subgraph DFA8_1257315080["DFA8 {2}"]
NFA4_9_28567114_10("NFA4-9 scope[1]")
NFA4_13_32234903_11("NFA4-13 char[1]")
end
subgraph DFA9_-1363874881["DFA9 {1}"]
NFA5_4_21678677_12[\"NFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA5_4_21678677_12 c0101;
end
class DFA9_-1363874881 c0101;
subgraph DFA10_-721149647["DFA10 {1}"]
NFA4_11_11142412_13("NFA4-11 scope[1]")
end
subgraph DFA11_1533316750["DFA11 {1}"]
NFA4_15_60890369_14[\"NFA4-15 char[1]
AcceptToken 'blockComment'"/]
class NFA4_15_60890369_14 c0101;
end
class DFA11_1533316750 c0101;
DFA0_1257045888 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|DFA1_1892905281
DFA0_1257045888 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-1400778774
DFA0_1257045888 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_1164797663
DFA1_1892905281 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|DFA1_1892905281
DFA1_1892905281 -->|"=
CheckToken 'entityId'"|DFA4_-561999181
DFA3_1164797663 -->|"*"|DFA5_1214651240
DFA3_1164797663 -->|"/
ExtendToken 'inlineComment'"|DFA6_14562357
DFA5_1214651240 -->|"[^*]"|DFA7_392280436
DFA5_1214651240 -->|"*"|DFA8_1257315080
DFA6_14562357 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1363874881
DFA7_392280436 -->|"[^*]"|DFA7_392280436
DFA7_392280436 -->|"*"|DFA8_1257315080
DFA8_1257315080 -->|"[^/]"|DFA10_-721149647
DFA8_1257315080 -->|"/
ExtendToken 'blockComment'"|DFA11_1533316750
DFA9_-1363874881 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1363874881
DFA10_-721149647 -->|"[^*]"|DFA7_392280436
DFA10_-721149647 -->|"*"|DFA8_1257315080
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
DFA0_1257045888{{"DFA0 wholeStart"}}
class DFA0_1257045888 c1000;
DFA1_1892905281[\"DFA1 {2}
AcceptToken 'refEntity'"/]
class DFA1_1892905281 c0111;
DFA2_-1400778774[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-1400778774 c0101;
DFA3_1164797663{{"DFA3 {2}"}}
DFA4_-561999181[\"DFA4 {1}
AcceptToken 'entityId'"/]
class DFA4_-561999181 c0001;
DFA5_1214651240{{"DFA5 {1}"}}
DFA6_14562357[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_14562357 c0101;
DFA7_392280436{{"DFA7 {1}"}}
DFA8_1257315080{{"DFA8 {2}"}}
DFA9_-1363874881[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1363874881 c0101;
DFA10_-721149647{{"DFA10 {1}"}}
DFA11_1533316750[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_1533316750 c0101;
DFA0_1257045888 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|DFA1_1892905281
DFA0_1257045888 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-1400778774
DFA0_1257045888 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_1164797663
DFA1_1892905281 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|DFA1_1892905281
DFA1_1892905281 -->|"=
CheckToken 'entityId'"|DFA4_-561999181
DFA3_1164797663 -->|"*"|DFA5_1214651240
DFA3_1164797663 -->|"/
ExtendToken 'inlineComment'"|DFA6_14562357
DFA5_1214651240 -->|"[^*]"|DFA7_392280436
DFA5_1214651240 -->|"*"|DFA8_1257315080
DFA6_14562357 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1363874881
DFA7_392280436 -->|"[^*]"|DFA7_392280436
DFA7_392280436 -->|"*"|DFA8_1257315080
DFA8_1257315080 -->|"[^/]"|DFA10_-721149647
DFA8_1257315080 -->|"/
ExtendToken 'blockComment'"|DFA11_1533316750
DFA9_-1363874881 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1363874881
DFA10_-721149647 -->|"[^*]"|DFA7_392280436
DFA10_-721149647 -->|"*"|DFA8_1257315080
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
subgraph MiniDFA0_-398947286["MiniDFA0 {1}"]
DFA0_1257045888_0{{"DFA0 wholeStart"}}
class DFA0_1257045888_0 c1000;
end
class MiniDFA0_-398947286 c1000;
subgraph MiniDFA4_-122463974["MiniDFA4 {1}"]
DFA1_1892905281_1[\"DFA1 {2}
AcceptToken 'refEntity'"/]
class DFA1_1892905281_1 c0111;
end
class MiniDFA4_-122463974 c0111;
subgraph MiniDFA5_1639487572["MiniDFA5 {1}"]
DFA2_-1400778774_2[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-1400778774_2 c0101;
end
class MiniDFA5_1639487572 c0101;
subgraph MiniDFA1_1760699034["MiniDFA1 {1}"]
DFA3_1164797663_3{{"DFA3 {2}"}}
end
subgraph MiniDFA6_1463535829["MiniDFA6 {1}"]
DFA4_-561999181_4[\"DFA4 {1}
AcceptToken 'entityId'"/]
class DFA4_-561999181_4 c0001;
end
class MiniDFA6_1463535829 c0001;
subgraph MiniDFA2_-1380621967["MiniDFA2 {3}"]
DFA5_1214651240_5{{"DFA5 {1}"}}
DFA7_392280436_6{{"DFA7 {1}"}}
DFA10_-721149647_7{{"DFA10 {1}"}}
end
subgraph MiniDFA7_-1369597224["MiniDFA7 {1}"]
DFA6_14562357_8[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_14562357_8 c0101;
end
class MiniDFA7_-1369597224 c0101;
subgraph MiniDFA3_-680397321["MiniDFA3 {1}"]
DFA8_1257315080_9{{"DFA8 {2}"}}
end
subgraph MiniDFA8_-855898515["MiniDFA8 {1}"]
DFA9_-1363874881_10[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1363874881_10 c0101;
end
class MiniDFA8_-855898515 c0101;
subgraph MiniDFA9_1668245151["MiniDFA9 {1}"]
DFA11_1533316750_11[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_1533316750_11 c0101;
end
class MiniDFA9_1668245151 c0101;
MiniDFA0_-398947286 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|MiniDFA4_-122463974
MiniDFA0_-398947286 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA5_1639487572
MiniDFA0_-398947286 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_1760699034
MiniDFA4_-122463974 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|MiniDFA4_-122463974
MiniDFA4_-122463974 -->|"=
CheckToken 'entityId'"|MiniDFA6_1463535829
MiniDFA1_1760699034 -->|"*"|MiniDFA2_-1380621967
MiniDFA1_1760699034 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-1369597224
MiniDFA2_-1380621967 -->|"[^*]"|MiniDFA2_-1380621967
MiniDFA2_-1380621967 -->|"*"|MiniDFA3_-680397321
MiniDFA7_-1369597224 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_-855898515
MiniDFA3_-680397321 -->|"[^/]"|MiniDFA2_-1380621967
MiniDFA3_-680397321 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_1668245151
MiniDFA8_-855898515 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_-855898515
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
MiniDFA0_-398947286(["MiniDFA0 {1}"])
class MiniDFA0_-398947286 c1000;
MiniDFA4_-122463974[\"MiniDFA4 {1}
AcceptToken 'refEntity'"/]
class MiniDFA4_-122463974 c0111;
MiniDFA5_1639487572[\"MiniDFA5 {1}
AcceptToken '='"/]
class MiniDFA5_1639487572 c0101;
MiniDFA1_1760699034(["MiniDFA1 {1}"])
MiniDFA6_1463535829[\"MiniDFA6 {1}
AcceptToken 'entityId'"/]
class MiniDFA6_1463535829 c0001;
MiniDFA2_-1380621967(["MiniDFA2 {3}"])
MiniDFA7_-1369597224[\"MiniDFA7 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA7_-1369597224 c0101;
MiniDFA3_-680397321(["MiniDFA3 {1}"])
MiniDFA8_-855898515[\"MiniDFA8 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA8_-855898515 c0101;
MiniDFA9_1668245151[\"MiniDFA9 {1}
AcceptToken 'blockComment'"/]
class MiniDFA9_1668245151 c0101;
MiniDFA0_-398947286 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|MiniDFA4_-122463974
MiniDFA0_-398947286 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA5_1639487572
MiniDFA0_-398947286 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_1760699034
MiniDFA4_-122463974 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|MiniDFA4_-122463974
MiniDFA4_-122463974 -->|"=
CheckToken 'entityId'"|MiniDFA6_1463535829
MiniDFA1_1760699034 -->|"*"|MiniDFA2_-1380621967
MiniDFA1_1760699034 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-1369597224
MiniDFA2_-1380621967 -->|"[^*]"|MiniDFA2_-1380621967
MiniDFA2_-1380621967 -->|"*"|MiniDFA3_-680397321
MiniDFA7_-1369597224 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_-855898515
MiniDFA3_-680397321 -->|"[^/]"|MiniDFA2_-1380621967
MiniDFA3_-680397321 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_1668245151
MiniDFA8_-855898515 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_-855898515
```
-------------------------------
