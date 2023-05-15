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
eNFA0_0_21551128[["εNFA0-0 wholeStart"]]
eNFA1_2_45781421[["εNFA1-2 regex start"]]
class eNFA1_2_45781421 c1000;
eNFA2_2_59742432[["εNFA2-2 regex start"]]
class eNFA2_2_59742432 c1000;
eNFA3_16_28781532[["εNFA3-16 regex start"]]
class eNFA3_16_28781532 c1000;
eNFA4_5_25057336[["εNFA4-5 regex start"]]
class eNFA4_5_25057336 c1000;
eNFA1_0_38676409[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_65689182[["εNFA2-0 char{1, 1}"]]
eNFA3_0_49602728[["εNFA3-0 char{1, 1}"]]
eNFA4_0_16378299[["εNFA4-0 char{1, 1}"]]
eNFA1_1_56493161[["εNFA1-1 scope[1]"]]
eNFA2_1_54331732[["εNFA2-1 char[1]"]]
eNFA3_1_65495901[["εNFA3-1 char[1]"]]
eNFA4_1_52592197[["εNFA4-1 char[1]"]]
eNFA1_3_12543365[["εNFA1-3 regex end"]]
class eNFA1_3_12543365 c0100;
eNFA2_3_19223544[["εNFA2-3 regex end"]]
class eNFA2_3_19223544 c0100;
eNFA3_2_50736653[["εNFA3-2 char{1, 1}"]]
eNFA4_2_53976698[["εNFA4-2 char{1, 1}"]]
eNFA1_4_9379612[["εNFA1-4 post-regex start"]]
class eNFA1_4_9379612 c0010;
eNFA2_4_38794171[["εNFA2-4 post-regex start"]]
class eNFA2_4_38794171 c0010;
eNFA5_2_16394943[["εNFA5-2 regex start"]]
class eNFA5_2_16394943 c1000;
eNFA3_3_63062784[["εNFA3-3 char[1]"]]
eNFA4_3_25164484[["εNFA4-3 char[1]"]]
eNFA1_5_17307650[\"εNFA1-5 post-regex end"/]
class eNFA1_5_17307650 c0001;
eNFA2_5_810977[\"εNFA2-5 post-regex end"/]
class eNFA2_5_810977 c0001;
eNFA5_0_61511739[["εNFA5-0 scope{1, ∞}"]]
eNFA3_6_13603222[["εNFA3-6 regex start"]]
eNFA4_4_32622215[["εNFA4-4 char{0, ∞}"]]
eNFA0_1_7298798[\"εNFA0-1 wholeEnd"/]
eNFA5_1_51573880[["εNFA5-1 scope[1]"]]
eNFA3_4_28119201[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_55320138[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_51746218[["εNFA3-7 regex end"]]
eNFA4_6_25153769[["εNFA4-6 regex end"]]
class eNFA4_6_25153769 c0100;
eNFA5_3_16734741[["εNFA5-3 regex end"]]
class eNFA5_3_16734741 c0100;
eNFA3_5_7811868[["εNFA3-5 scope[1]"]]
eNFA3_9_5850279[["εNFA3-9 scope[1]"]]
eNFA3_12_30694147[["εNFA3-12 char{1, 1}"]]
eNFA4_7_13186971[["εNFA4-7 post-regex start"]]
class eNFA4_7_13186971 c0010;
eNFA5_4_52922000[["εNFA5-4 post-regex start"]]
class eNFA5_4_52922000 c0010;
eNFA3_10_64524211[["εNFA3-10 scope{1, 1}"]]
eNFA3_13_43846987[["εNFA3-13 char[1]"]]
eNFA4_8_24189432[\"εNFA4-8 post-regex end"/]
class eNFA4_8_24189432 c0001;
eNFA5_5_13336762[\"εNFA5-5 post-regex end"/]
class eNFA5_5_13336762 c0001;
eNFA3_11_3197948[["εNFA3-11 scope[1]"]]
eNFA3_14_59078569[["εNFA3-14 char{1, 1}"]]
eNFA3_15_43771375[["εNFA3-15 char[1]"]]
eNFA3_17_58398057[["εNFA3-17 regex end"]]
class eNFA3_17_58398057 c0100;
eNFA3_18_55820473[["εNFA3-18 post-regex start"]]
class eNFA3_18_55820473 c0010;
eNFA3_19_57707197[\"εNFA3-19 post-regex end"/]
class eNFA3_19_57707197 c0001;
eNFA0_0_21551128 -.->|"ε"|eNFA1_2_45781421
eNFA0_0_21551128 -.->|"ε"|eNFA2_2_59742432
eNFA0_0_21551128 -.->|"ε"|eNFA3_16_28781532
eNFA0_0_21551128 -.->|"ε"|eNFA4_5_25057336
eNFA1_2_45781421 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_38676409
eNFA2_2_59742432 -.->|"ε
BeginToken '='"|eNFA2_0_65689182
eNFA3_16_28781532 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_49602728
eNFA4_5_25057336 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_16378299
eNFA1_0_38676409 -->|"[0-9]"|eNFA1_1_56493161
eNFA2_0_65689182 -->|"="|eNFA2_1_54331732
eNFA3_0_49602728 -->|"/"|eNFA3_1_65495901
eNFA4_0_16378299 -->|"/"|eNFA4_1_52592197
eNFA1_1_56493161 -->|"[0-9]"|eNFA1_1_56493161
eNFA1_1_56493161 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_12543365
eNFA2_1_54331732 -.->|"ε
ExtendToken '='"|eNFA2_3_19223544
eNFA3_1_65495901 -.->|"ε"|eNFA3_2_50736653
eNFA4_1_52592197 -.->|"ε"|eNFA4_2_53976698
eNFA1_3_12543365 -.->|"ε"|eNFA1_4_9379612
eNFA2_3_19223544 -.->|"ε"|eNFA2_4_38794171
eNFA2_3_19223544 -.->|"ε
AcceptPrevious '='"|eNFA5_2_16394943
eNFA3_2_50736653 -->|"*"|eNFA3_3_63062784
eNFA4_2_53976698 -->|"/"|eNFA4_3_25164484
eNFA1_4_9379612 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_17307650
eNFA2_4_38794171 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_810977
eNFA5_2_16394943 -.->|"ε
BeginToken 'refEntity'"|eNFA5_0_61511739
eNFA3_3_63062784 -.->|"ε"|eNFA3_6_13603222
eNFA4_3_25164484 -.->|"ε"|eNFA4_4_32622215
eNFA1_5_17307650 -.->|"ε"|eNFA0_1_7298798
eNFA2_5_810977 -.->|"ε"|eNFA0_1_7298798
eNFA5_0_61511739 -->|"[0-9]"|eNFA5_1_51573880
eNFA3_6_13603222 -.->|"ε"|eNFA3_4_28119201
eNFA3_6_13603222 -.->|"ε"|eNFA3_8_55320138
eNFA3_6_13603222 -.->|"ε"|eNFA3_7_51746218
eNFA4_4_32622215 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_32622215
eNFA4_4_32622215 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_25153769
eNFA5_1_51573880 -->|"[0-9]"|eNFA5_1_51573880
eNFA5_1_51573880 -.->|"ε
ExtendToken 'refEntity'"|eNFA5_3_16734741
eNFA3_4_28119201 -->|"[^*]"|eNFA3_5_7811868
eNFA3_8_55320138 -->|"[*]"|eNFA3_9_5850279
eNFA3_7_51746218 -.->|"ε"|eNFA3_6_13603222
eNFA3_7_51746218 -.->|"ε"|eNFA3_12_30694147
eNFA4_6_25153769 -.->|"ε"|eNFA4_7_13186971
eNFA5_3_16734741 -.->|"ε"|eNFA5_4_52922000
eNFA3_5_7811868 -.->|"ε"|eNFA3_7_51746218
eNFA3_9_5850279 -.->|"ε"|eNFA3_10_64524211
eNFA3_12_30694147 -->|"*"|eNFA3_13_43846987
eNFA4_7_13186971 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_24189432
eNFA5_4_52922000 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA5_5_13336762
eNFA3_10_64524211 -->|"[^/]"|eNFA3_11_3197948
eNFA3_13_43846987 -.->|"ε"|eNFA3_14_59078569
eNFA4_8_24189432 -.->|"ε"|eNFA0_1_7298798
eNFA5_5_13336762 -.->|"ε"|eNFA0_1_7298798
eNFA3_11_3197948 -.->|"ε"|eNFA3_7_51746218
eNFA3_14_59078569 -->|"/"|eNFA3_15_43771375
eNFA3_15_43771375 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_58398057
eNFA3_17_58398057 -.->|"ε"|eNFA3_18_55820473
eNFA3_18_55820473 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_57707197
eNFA3_19_57707197 -.->|"ε"|eNFA0_1_7298798
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
eNFA0_0_6535952[["εNFA0-0 wholeStart"]]
class eNFA0_0_6535952 c1000;
eNFA1_2_59650110[["εNFA1-2 regex start"]]
class eNFA1_2_59650110 c1000;
eNFA2_2_58823573[["εNFA2-2 regex start"]]
class eNFA2_2_58823573 c1000;
eNFA3_16_67088950[["εNFA3-16 regex start"]]
class eNFA3_16_67088950 c1000;
eNFA4_5_66929645[["εNFA4-5 regex start"]]
class eNFA4_5_66929645 c1000;
eNFA1_0_32109549[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_32109549 c1000;
eNFA2_0_26241711[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_26241711 c1000;
eNFA3_0_45203864[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_45203864 c1000;
eNFA4_0_28482418[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_28482418 c1000;
eNFA1_1_3567727[\"εNFA1-1 scope[1]
AcceptToken 'entityId'"/]
class eNFA1_1_3567727 c0111;
eNFA2_1_34848813[\"εNFA2-1 char[1]
AcceptToken '='"/]
class eNFA2_1_34848813 c1111;
eNFA3_1_27044054[["εNFA3-1 char[1]"]]
eNFA4_1_43084804[["εNFA4-1 char[1]"]]
eNFA1_3_20550486[\"εNFA1-3 regex end
AcceptToken 'entityId'"/]
class eNFA1_3_20550486 c0111;
eNFA1_4_10372286[\"εNFA1-4 post-regex start
AcceptToken 'entityId'"/]
class eNFA1_4_10372286 c0011;
eNFA1_5_15147232[\"εNFA1-5 post-regex end"/]
class eNFA1_5_15147232 c0011;
eNFA0_1_1683025[\"εNFA0-1 wholeEnd"/]
eNFA2_3_16028238[\"εNFA2-3 regex end
AcceptToken '='"/]
class eNFA2_3_16028238 c1111;
eNFA2_4_23218903[\"εNFA2-4 post-regex start
AcceptToken '='"/]
class eNFA2_4_23218903 c0011;
eNFA5_2_10036418[\"εNFA5-2 regex start"/]
class eNFA5_2_10036418 c1000;
eNFA2_5_7643543[\"εNFA2-5 post-regex end"/]
class eNFA2_5_7643543 c0011;
eNFA5_0_42325954[\"εNFA5-0 scope{1, ∞}"/]
class eNFA5_0_42325954 c1000;
eNFA5_1_41985586[\"εNFA5-1 scope[1]
AcceptToken 'refEntity'"/]
class eNFA5_1_41985586 c0111;
eNFA3_2_208246[["εNFA3-2 char{1, 1}"]]
eNFA3_3_52652517[["εNFA3-3 char[1]"]]
eNFA4_2_52218921[["εNFA4-2 char{1, 1}"]]
eNFA4_3_17916934[\"εNFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA4_3_17916934 c0111;
eNFA5_3_45389273[\"εNFA5-3 regex end
AcceptToken 'refEntity'"/]
class eNFA5_3_45389273 c0111;
eNFA5_4_25374516[\"εNFA5-4 post-regex start
AcceptToken 'refEntity'"/]
class eNFA5_4_25374516 c0011;
eNFA5_5_20634784[\"εNFA5-5 post-regex end"/]
class eNFA5_5_20634784 c0011;
eNFA3_6_2107364[["εNFA3-6 regex start"]]
eNFA3_4_36478775[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_18966278[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_59873520[["εNFA3-7 regex end"]]
eNFA3_5_36995518[["εNFA3-5 scope[1]"]]
eNFA3_9_1874221[["εNFA3-9 scope[1]"]]
eNFA3_12_4110613[["εNFA3-12 char{1, 1}"]]
eNFA3_13_17594176[["εNFA3-13 char[1]"]]
eNFA4_4_1990770[\"εNFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA4_4_1990770 c0111;
eNFA4_6_27034686[\"εNFA4-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA4_6_27034686 c0111;
eNFA4_7_55015173[\"εNFA4-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA4_7_55015173 c0011;
eNFA4_8_61945077[\"εNFA4-8 post-regex end"/]
class eNFA4_8_61945077 c0011;
eNFA3_10_16867989[["εNFA3-10 scope{1, 1}"]]
eNFA3_11_51495331[["εNFA3-11 scope[1]"]]
eNFA3_14_42069902[["εNFA3-14 char{1, 1}"]]
eNFA3_15_4181593[\"εNFA3-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA3_15_4181593 c0111;
eNFA3_17_37634337[\"εNFA3-17 regex end
AcceptToken 'blockComment'"/]
class eNFA3_17_37634337 c0111;
eNFA3_18_3164713[\"εNFA3-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA3_18_3164713 c0011;
eNFA3_19_60804799[\"εNFA3-19 post-regex end"/]
class eNFA3_19_60804799 c0011;
eNFA0_0_6535952 -.->|"ε"|eNFA1_2_59650110
eNFA0_0_6535952 -.->|"ε"|eNFA2_2_58823573
eNFA0_0_6535952 -.->|"ε"|eNFA3_16_67088950
eNFA0_0_6535952 -.->|"ε"|eNFA4_5_66929645
eNFA0_0_6535952 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_32109549
eNFA0_0_6535952 -.->|"ε
BeginToken '='"|eNFA2_0_26241711
eNFA0_0_6535952 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_45203864
eNFA0_0_6535952 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_28482418
eNFA0_0_6535952 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_3567727
eNFA0_0_6535952 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_34848813
eNFA0_0_6535952 -->|"/
BeginToken 'blockComment'"|eNFA3_1_27044054
eNFA0_0_6535952 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_43084804
eNFA1_2_59650110 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_32109549
eNFA1_2_59650110 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_3567727
eNFA2_2_58823573 -.->|"ε
BeginToken '='"|eNFA2_0_26241711
eNFA2_2_58823573 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_34848813
eNFA3_16_67088950 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_45203864
eNFA3_16_67088950 -->|"/
BeginToken 'blockComment'"|eNFA3_1_27044054
eNFA4_5_66929645 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_28482418
eNFA4_5_66929645 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_43084804
eNFA1_0_32109549 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_3567727
eNFA2_0_26241711 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_34848813
eNFA3_0_45203864 -->|"/
BeginToken 'blockComment'"|eNFA3_1_27044054
eNFA4_0_28482418 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_43084804
eNFA1_1_3567727 -->|"[0-9]
ExtendToken 'entityId'"|eNFA1_1_3567727
eNFA1_1_3567727 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_20550486
eNFA1_1_3567727 -.->|"ε"|eNFA1_4_10372286
eNFA1_1_3567727 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_15147232
eNFA1_1_3567727 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_1683025
eNFA2_1_34848813 -.->|"ε
ExtendToken '='"|eNFA2_3_16028238
eNFA2_1_34848813 -.->|"ε"|eNFA2_4_23218903
eNFA2_1_34848813 -.->|"ε
AcceptPrevious '='"|eNFA5_2_10036418
eNFA2_1_34848813 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_7643543
eNFA2_1_34848813 -.->|"ε
CheckToken '='"|eNFA0_1_1683025
eNFA2_1_34848813 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA5_0_42325954
eNFA2_1_34848813 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA5_1_41985586
eNFA3_1_27044054 -.->|"ε"|eNFA3_2_208246
eNFA3_1_27044054 -->|"*"|eNFA3_3_52652517
eNFA4_1_43084804 -.->|"ε"|eNFA4_2_52218921
eNFA4_1_43084804 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_17916934
eNFA1_3_20550486 -.->|"ε"|eNFA1_4_10372286
eNFA1_3_20550486 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_15147232
eNFA1_3_20550486 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_1683025
eNFA1_4_10372286 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_15147232
eNFA1_4_10372286 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_1683025
eNFA1_5_15147232 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_1683025
eNFA2_3_16028238 -.->|"ε"|eNFA2_4_23218903
eNFA2_3_16028238 -.->|"ε
AcceptPrevious '='"|eNFA5_2_10036418
eNFA2_3_16028238 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_7643543
eNFA2_3_16028238 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA5_0_42325954
eNFA2_3_16028238 -.->|"ε
CheckToken '='"|eNFA0_1_1683025
eNFA2_3_16028238 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA5_1_41985586
eNFA2_4_23218903 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_7643543
eNFA2_4_23218903 -.->|"ε
CheckToken '='"|eNFA0_1_1683025
eNFA5_2_10036418 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA5_0_42325954
eNFA5_2_10036418 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA5_1_41985586
eNFA2_5_7643543 -.->|"ε
CheckToken '='"|eNFA0_1_1683025
eNFA5_0_42325954 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA5_1_41985586
eNFA5_1_41985586 -->|"[0-9]
ExtendToken 'refEntity'"|eNFA5_1_41985586
eNFA5_1_41985586 -.->|"ε
ExtendToken 'refEntity'"|eNFA5_3_45389273
eNFA5_1_41985586 -.->|"ε"|eNFA5_4_25374516
eNFA5_1_41985586 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA5_5_20634784
eNFA5_1_41985586 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_1683025
eNFA3_2_208246 -->|"*"|eNFA3_3_52652517
eNFA3_3_52652517 -.->|"ε"|eNFA3_6_2107364
eNFA3_3_52652517 -.->|"ε"|eNFA3_4_36478775
eNFA3_3_52652517 -.->|"ε"|eNFA3_8_18966278
eNFA3_3_52652517 -.->|"ε"|eNFA3_7_59873520
eNFA3_3_52652517 -->|"[^*]"|eNFA3_5_36995518
eNFA3_3_52652517 -->|"[*]"|eNFA3_9_1874221
eNFA3_3_52652517 -.->|"ε"|eNFA3_12_4110613
eNFA3_3_52652517 -->|"*"|eNFA3_13_17594176
eNFA4_2_52218921 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_17916934
eNFA4_3_17916934 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_4_1990770
eNFA4_3_17916934 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_1990770
eNFA4_3_17916934 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_27034686
eNFA4_3_17916934 -.->|"ε"|eNFA4_7_55015173
eNFA4_3_17916934 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_61945077
eNFA4_3_17916934 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_1683025
eNFA5_3_45389273 -.->|"ε"|eNFA5_4_25374516
eNFA5_3_45389273 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA5_5_20634784
eNFA5_3_45389273 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_1683025
eNFA5_4_25374516 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA5_5_20634784
eNFA5_4_25374516 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_1683025
eNFA5_5_20634784 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_1683025
eNFA3_6_2107364 -.->|"ε"|eNFA3_4_36478775
eNFA3_6_2107364 -.->|"ε"|eNFA3_8_18966278
eNFA3_6_2107364 -.->|"ε"|eNFA3_7_59873520
eNFA3_6_2107364 -->|"[^*]"|eNFA3_5_36995518
eNFA3_6_2107364 -->|"[*]"|eNFA3_9_1874221
eNFA3_6_2107364 -.->|"ε"|eNFA3_6_2107364
eNFA3_6_2107364 -.->|"ε"|eNFA3_12_4110613
eNFA3_6_2107364 -->|"*"|eNFA3_13_17594176
eNFA3_4_36478775 -->|"[^*]"|eNFA3_5_36995518
eNFA3_8_18966278 -->|"[*]"|eNFA3_9_1874221
eNFA3_7_59873520 -.->|"ε"|eNFA3_6_2107364
eNFA3_7_59873520 -.->|"ε"|eNFA3_12_4110613
eNFA3_7_59873520 -.->|"ε"|eNFA3_4_36478775
eNFA3_7_59873520 -.->|"ε"|eNFA3_8_18966278
eNFA3_7_59873520 -.->|"ε"|eNFA3_7_59873520
eNFA3_7_59873520 -->|"[^*]"|eNFA3_5_36995518
eNFA3_7_59873520 -->|"[*]"|eNFA3_9_1874221
eNFA3_7_59873520 -->|"*"|eNFA3_13_17594176
eNFA3_5_36995518 -.->|"ε"|eNFA3_7_59873520
eNFA3_5_36995518 -.->|"ε"|eNFA3_6_2107364
eNFA3_5_36995518 -.->|"ε"|eNFA3_12_4110613
eNFA3_5_36995518 -.->|"ε"|eNFA3_4_36478775
eNFA3_5_36995518 -.->|"ε"|eNFA3_8_18966278
eNFA3_5_36995518 -->|"[^*]"|eNFA3_5_36995518
eNFA3_5_36995518 -->|"[*]"|eNFA3_9_1874221
eNFA3_5_36995518 -->|"*"|eNFA3_13_17594176
eNFA3_9_1874221 -.->|"ε"|eNFA3_10_16867989
eNFA3_9_1874221 -->|"[^/]"|eNFA3_11_51495331
eNFA3_12_4110613 -->|"*"|eNFA3_13_17594176
eNFA3_13_17594176 -.->|"ε"|eNFA3_14_42069902
eNFA3_13_17594176 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_4181593
eNFA4_4_1990770 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_1990770
eNFA4_4_1990770 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_27034686
eNFA4_4_1990770 -.->|"ε"|eNFA4_7_55015173
eNFA4_4_1990770 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_61945077
eNFA4_4_1990770 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_1683025
eNFA4_6_27034686 -.->|"ε"|eNFA4_7_55015173
eNFA4_6_27034686 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_61945077
eNFA4_6_27034686 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_1683025
eNFA4_7_55015173 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_61945077
eNFA4_7_55015173 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_1683025
eNFA4_8_61945077 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_1683025
eNFA3_10_16867989 -->|"[^/]"|eNFA3_11_51495331
eNFA3_11_51495331 -.->|"ε"|eNFA3_7_59873520
eNFA3_11_51495331 -.->|"ε"|eNFA3_6_2107364
eNFA3_11_51495331 -.->|"ε"|eNFA3_12_4110613
eNFA3_11_51495331 -.->|"ε"|eNFA3_4_36478775
eNFA3_11_51495331 -.->|"ε"|eNFA3_8_18966278
eNFA3_11_51495331 -->|"[^*]"|eNFA3_5_36995518
eNFA3_11_51495331 -->|"[*]"|eNFA3_9_1874221
eNFA3_11_51495331 -->|"*"|eNFA3_13_17594176
eNFA3_14_42069902 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_4181593
eNFA3_15_4181593 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_37634337
eNFA3_15_4181593 -.->|"ε"|eNFA3_18_3164713
eNFA3_15_4181593 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_60804799
eNFA3_15_4181593 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_1683025
eNFA3_17_37634337 -.->|"ε"|eNFA3_18_3164713
eNFA3_17_37634337 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_60804799
eNFA3_17_37634337 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_1683025
eNFA3_18_3164713 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_60804799
eNFA3_18_3164713 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_1683025
eNFA3_19_60804799 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_1683025
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
NFA0_0_15842189("NFA0-0 wholeStart")
class NFA0_0_15842189 c1000;
NFA1_1_24129864[\"NFA1-1 scope[1]
AcceptToken 'entityId'"/]
class NFA1_1_24129864 c0101;
NFA2_1_8361976[\"NFA2-1 char[1]
AcceptToken '='"/]
class NFA2_1_8361976 c1101;
NFA3_1_8148922("NFA3-1 char[1]")
NFA4_1_6231436("NFA4-1 char[1]")
NFA5_1_56082927[\"NFA5-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA5_1_56082927 c0101;
NFA3_3_46423253("NFA3-3 char[1]")
NFA4_3_34984301[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_34984301 c0101;
NFA3_5_2187155("NFA3-5 scope[1]")
NFA3_9_15156098("NFA3-9 scope[1]")
NFA3_13_19684403("NFA3-13 char[1]")
NFA4_4_42941906[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_42941906 c0101;
NFA3_11_55742394("NFA3-11 scope[1]")
NFA3_15_50932842[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_50932842 c0101;
NFA0_0_15842189 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|NFA1_1_24129864
NFA0_0_15842189 -->|"=
BeginToken '='
ExtendToken '='"|NFA2_1_8361976
NFA0_0_15842189 -->|"/
BeginToken 'blockComment'"|NFA3_1_8148922
NFA0_0_15842189 -->|"/
BeginToken 'inlineComment'"|NFA4_1_6231436
NFA1_1_24129864 -->|"[0-9]
ExtendToken 'entityId'"|NFA1_1_24129864
NFA2_1_8361976 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|NFA5_1_56082927
NFA3_1_8148922 -->|"*"|NFA3_3_46423253
NFA4_1_6231436 -->|"/
ExtendToken 'inlineComment'"|NFA4_3_34984301
NFA5_1_56082927 -->|"[0-9]
ExtendToken 'refEntity'"|NFA5_1_56082927
NFA3_3_46423253 -->|"[^*]"|NFA3_5_2187155
NFA3_3_46423253 -->|"[*]"|NFA3_9_15156098
NFA3_3_46423253 -->|"*"|NFA3_13_19684403
NFA4_3_34984301 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_42941906
NFA3_5_2187155 -->|"[^*]"|NFA3_5_2187155
NFA3_5_2187155 -->|"[*]"|NFA3_9_15156098
NFA3_5_2187155 -->|"*"|NFA3_13_19684403
NFA3_9_15156098 -->|"[^/]"|NFA3_11_55742394
NFA3_13_19684403 -->|"/
ExtendToken 'blockComment'"|NFA3_15_50932842
NFA4_4_42941906 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_42941906
NFA3_11_55742394 -->|"[^*]"|NFA3_5_2187155
NFA3_11_55742394 -->|"[*]"|NFA3_9_15156098
NFA3_11_55742394 -->|"*"|NFA3_13_19684403
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
subgraph DFA0_-1247633812["DFA0 wholeStart"]
NFA0_0_15842189_0("NFA0-0 wholeStart")
class NFA0_0_15842189_0 c1000;
end
class DFA0_-1247633812 c1000;
subgraph DFA1_1778675542["DFA1 {1}"]
NFA1_1_24129864_1[\"NFA1-1 scope[1]
AcceptToken 'entityId'"/]
class NFA1_1_24129864_1 c0101;
end
class DFA1_1778675542 c0101;
subgraph DFA2_1260656262["DFA2 {1}"]
NFA2_1_8361976_2[\"NFA2-1 char[1]
AcceptToken '='"/]
class NFA2_1_8361976_2 c1101;
end
class DFA2_1260656262 c1101;
subgraph DFA3_-1481152672["DFA3 {2}"]
NFA3_1_8148922_3("NFA3-1 char[1]")
NFA4_1_6231436_4("NFA4-1 char[1]")
end
subgraph DFA4_1905852967["DFA4 {1}"]
NFA5_1_56082927_5[\"NFA5-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA5_1_56082927_5 c0101;
end
class DFA4_1905852967 c0101;
subgraph DFA5_-8675653["DFA5 {1}"]
NFA3_3_46423253_6("NFA3-3 char[1]")
end
subgraph DFA6_-512962250["DFA6 {1}"]
NFA4_3_34984301_7[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_34984301_7 c0101;
end
class DFA6_-512962250 c0101;
subgraph DFA7_157542378["DFA7 {1}"]
NFA3_5_2187155_8("NFA3-5 scope[1]")
end
subgraph DFA8_-271251562["DFA8 {2}"]
NFA3_9_15156098_9("NFA3-9 scope[1]")
NFA3_13_19684403_10("NFA3-13 char[1]")
end
subgraph DFA9_-1647430205["DFA9 {1}"]
NFA4_4_42941906_11[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_42941906_11 c0101;
end
class DFA9_-1647430205 c0101;
subgraph DFA10_-1871932841["DFA10 {1}"]
NFA3_11_55742394_12("NFA3-11 scope[1]")
end
subgraph DFA11_1927963297["DFA11 {1}"]
NFA3_15_50932842_13[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_50932842_13 c0101;
end
class DFA11_1927963297 c0101;
DFA0_-1247633812 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|DFA1_1778675542
DFA0_-1247633812 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_1260656262
DFA0_-1247633812 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_-1481152672
DFA1_1778675542 -->|"[0-9]
ExtendToken 'entityId'"|DFA1_1778675542
DFA2_1260656262 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|DFA4_1905852967
DFA3_-1481152672 -->|"*"|DFA5_-8675653
DFA3_-1481152672 -->|"/
ExtendToken 'inlineComment'"|DFA6_-512962250
DFA4_1905852967 -->|"[0-9]
ExtendToken 'refEntity'"|DFA4_1905852967
DFA5_-8675653 -->|"[^*]"|DFA7_157542378
DFA5_-8675653 -->|"*"|DFA8_-271251562
DFA6_-512962250 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1647430205
DFA7_157542378 -->|"[^*]"|DFA7_157542378
DFA7_157542378 -->|"*"|DFA8_-271251562
DFA8_-271251562 -->|"[^/]"|DFA10_-1871932841
DFA8_-271251562 -->|"/
ExtendToken 'blockComment'"|DFA11_1927963297
DFA9_-1647430205 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1647430205
DFA10_-1871932841 -->|"[^*]"|DFA7_157542378
DFA10_-1871932841 -->|"*"|DFA8_-271251562
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
DFA0_-1247633812{{"DFA0 wholeStart"}}
class DFA0_-1247633812 c1000;
DFA1_1778675542[\"DFA1 {1}
AcceptToken 'entityId'"/]
class DFA1_1778675542 c0101;
DFA2_1260656262[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_1260656262 c1101;
DFA3_-1481152672{{"DFA3 {2}"}}
DFA4_1905852967[\"DFA4 {1}
AcceptToken 'refEntity'"/]
class DFA4_1905852967 c0101;
DFA5_-8675653{{"DFA5 {1}"}}
DFA6_-512962250[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_-512962250 c0101;
DFA7_157542378{{"DFA7 {1}"}}
DFA8_-271251562{{"DFA8 {2}"}}
DFA9_-1647430205[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1647430205 c0101;
DFA10_-1871932841{{"DFA10 {1}"}}
DFA11_1927963297[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_1927963297 c0101;
DFA0_-1247633812 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|DFA1_1778675542
DFA0_-1247633812 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_1260656262
DFA0_-1247633812 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_-1481152672
DFA1_1778675542 -->|"[0-9]
ExtendToken 'entityId'"|DFA1_1778675542
DFA2_1260656262 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|DFA4_1905852967
DFA3_-1481152672 -->|"*"|DFA5_-8675653
DFA3_-1481152672 -->|"/
ExtendToken 'inlineComment'"|DFA6_-512962250
DFA4_1905852967 -->|"[0-9]
ExtendToken 'refEntity'"|DFA4_1905852967
DFA5_-8675653 -->|"[^*]"|DFA7_157542378
DFA5_-8675653 -->|"*"|DFA8_-271251562
DFA6_-512962250 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1647430205
DFA7_157542378 -->|"[^*]"|DFA7_157542378
DFA7_157542378 -->|"*"|DFA8_-271251562
DFA8_-271251562 -->|"[^/]"|DFA10_-1871932841
DFA8_-271251562 -->|"/
ExtendToken 'blockComment'"|DFA11_1927963297
DFA9_-1647430205 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1647430205
DFA10_-1871932841 -->|"[^*]"|DFA7_157542378
DFA10_-1871932841 -->|"*"|DFA8_-271251562
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
subgraph MiniDFA0_-1315845637["MiniDFA0 {1}"]
DFA0_-1247633812_0{{"DFA0 wholeStart"}}
class DFA0_-1247633812_0 c1000;
end
class MiniDFA0_-1315845637 c1000;
subgraph MiniDFA4_1442053852["MiniDFA4 {1}"]
DFA1_1778675542_1[\"DFA1 {1}
AcceptToken 'entityId'"/]
class DFA1_1778675542_1 c0101;
end
class MiniDFA4_1442053852 c0101;
subgraph MiniDFA5_185564740["MiniDFA5 {1}"]
DFA2_1260656262_2[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_1260656262_2 c1101;
end
class MiniDFA5_185564740 c1101;
subgraph MiniDFA1_-678884485["MiniDFA1 {1}"]
DFA3_-1481152672_3{{"DFA3 {2}"}}
end
subgraph MiniDFA6_692057757["MiniDFA6 {1}"]
DFA4_1905852967_4[\"DFA4 {1}
AcceptToken 'refEntity'"/]
class DFA4_1905852967_4 c0101;
end
class MiniDFA6_692057757 c0101;
subgraph MiniDFA2_-385248872["MiniDFA2 {3}"]
DFA5_-8675653_5{{"DFA5 {1}"}}
DFA7_157542378_6{{"DFA7 {1}"}}
DFA10_-1871932841_7{{"DFA10 {1}"}}
end
subgraph MiniDFA7_-500746164["MiniDFA7 {1}"]
DFA6_-512962250_8[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_-512962250_8 c0101;
end
class MiniDFA7_-500746164 c0101;
subgraph MiniDFA3_-1884997737["MiniDFA3 {1}"]
DFA8_-271251562_9{{"DFA8 {2}"}}
end
subgraph MiniDFA8_190811382["MiniDFA8 {1}"]
DFA9_-1647430205_10[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1647430205_10 c0101;
end
class MiniDFA8_190811382 c0101;
subgraph MiniDFA9_1589134563["MiniDFA9 {1}"]
DFA11_1927963297_11[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_1927963297_11 c0101;
end
class MiniDFA9_1589134563 c0101;
MiniDFA0_-1315845637 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|MiniDFA4_1442053852
MiniDFA0_-1315845637 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA5_185564740
MiniDFA0_-1315845637 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-678884485
MiniDFA4_1442053852 -->|"[0-9]
ExtendToken 'entityId'"|MiniDFA4_1442053852
MiniDFA5_185564740 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|MiniDFA6_692057757
MiniDFA1_-678884485 -->|"*"|MiniDFA2_-385248872
MiniDFA1_-678884485 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-500746164
MiniDFA6_692057757 -->|"[0-9]
ExtendToken 'refEntity'"|MiniDFA6_692057757
MiniDFA2_-385248872 -->|"[^*]"|MiniDFA2_-385248872
MiniDFA2_-385248872 -->|"*"|MiniDFA3_-1884997737
MiniDFA7_-500746164 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_190811382
MiniDFA3_-1884997737 -->|"[^/]"|MiniDFA2_-385248872
MiniDFA3_-1884997737 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_1589134563
MiniDFA8_190811382 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_190811382
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
MiniDFA0_-1315845637(["MiniDFA0 {1}"])
class MiniDFA0_-1315845637 c1000;
MiniDFA4_1442053852[\"MiniDFA4 {1}
AcceptToken 'entityId'"/]
class MiniDFA4_1442053852 c0101;
MiniDFA5_185564740[\"MiniDFA5 {1}
AcceptToken '='"/]
class MiniDFA5_185564740 c1101;
MiniDFA1_-678884485(["MiniDFA1 {1}"])
MiniDFA6_692057757[\"MiniDFA6 {1}
AcceptToken 'refEntity'"/]
class MiniDFA6_692057757 c0101;
MiniDFA2_-385248872(["MiniDFA2 {3}"])
MiniDFA7_-500746164[\"MiniDFA7 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA7_-500746164 c0101;
MiniDFA3_-1884997737(["MiniDFA3 {1}"])
MiniDFA8_190811382[\"MiniDFA8 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA8_190811382 c0101;
MiniDFA9_1589134563[\"MiniDFA9 {1}
AcceptToken 'blockComment'"/]
class MiniDFA9_1589134563 c0101;
MiniDFA0_-1315845637 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|MiniDFA4_1442053852
MiniDFA0_-1315845637 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA5_185564740
MiniDFA0_-1315845637 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-678884485
MiniDFA4_1442053852 -->|"[0-9]
ExtendToken 'entityId'"|MiniDFA4_1442053852
MiniDFA5_185564740 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|MiniDFA6_692057757
MiniDFA1_-678884485 -->|"*"|MiniDFA2_-385248872
MiniDFA1_-678884485 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-500746164
MiniDFA6_692057757 -->|"[0-9]
ExtendToken 'refEntity'"|MiniDFA6_692057757
MiniDFA2_-385248872 -->|"[^*]"|MiniDFA2_-385248872
MiniDFA2_-385248872 -->|"*"|MiniDFA3_-1884997737
MiniDFA7_-500746164 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_190811382
MiniDFA3_-1884997737 -->|"[^/]"|MiniDFA2_-385248872
MiniDFA3_-1884997737 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_1589134563
MiniDFA8_190811382 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_190811382
```
-------------------------------
