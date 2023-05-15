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
eNFA0_0_541162[["εNFA0-0 wholeStart"]]
eNFA1_2_26248478[["εNFA1-2 regex start"]]
class eNFA1_2_26248478 c1000;
eNFA2_2_4870463[["εNFA2-2 regex start"]]
class eNFA2_2_4870463 c1000;
eNFA3_2_42402794[["εNFA3-2 regex start"]]
class eNFA3_2_42402794 c1000;
eNFA4_2_30795413[["εNFA4-2 regex start"]]
class eNFA4_2_30795413 c1000;
eNFA5_2_39391664[["εNFA5-2 regex start"]]
class eNFA5_2_39391664 c1000;
eNFA6_2_3951668[["εNFA6-2 regex start"]]
class eNFA6_2_3951668 c1000;
eNFA7_16_10176696[["εNFA7-16 regex start"]]
class eNFA7_16_10176696 c1000;
eNFA8_5_15447074[["εNFA8-5 regex start"]]
class eNFA8_5_15447074 c1000;
eNFA1_0_34909710[["εNFA1-0 char{1, 1}"]]
eNFA2_0_60906657[["εNFA2-0 char{1, 1}"]]
eNFA3_0_12074265[["εNFA3-0 char{1, 1}"]]
eNFA4_0_11400497[["εNFA4-0 char{1, 1}"]]
eNFA5_0_36608226[["εNFA5-0 char{1, 1}"]]
eNFA6_0_51649700[["εNFA6-0 char{1, 1}"]]
eNFA7_0_19006063[["εNFA7-0 char{1, 1}"]]
eNFA8_0_43253509[["εNFA8-0 char{1, 1}"]]
eNFA1_1_45751941[["εNFA1-1 char[1]"]]
eNFA2_1_11289004[["εNFA2-1 char[1]"]]
eNFA3_1_41559524[["εNFA3-1 char[1]"]]
eNFA4_1_35495616[["εNFA4-1 char[1]"]]
eNFA5_1_61038585[["εNFA5-1 char[1]"]]
eNFA6_1_62194118[["εNFA6-1 char[1]"]]
eNFA7_1_30368798[["εNFA7-1 char[1]"]]
eNFA8_1_4883734[["εNFA8-1 char[1]"]]
eNFA1_3_9114291[["εNFA1-3 regex end"]]
class eNFA1_3_9114291 c0100;
eNFA2_3_34492175[["εNFA2-3 regex end"]]
class eNFA2_3_34492175 c0100;
eNFA3_3_38491397[["εNFA3-3 regex end"]]
class eNFA3_3_38491397 c0100;
eNFA4_3_51025090[["εNFA4-3 regex end"]]
class eNFA4_3_51025090 c0100;
eNFA5_3_12476353[["εNFA5-3 regex end"]]
class eNFA5_3_12476353 c0100;
eNFA6_3_22876152[["εNFA6-3 regex end"]]
class eNFA6_3_22876152 c0100;
eNFA7_2_43953607[["εNFA7-2 char{1, 1}"]]
eNFA8_2_60038148[["εNFA8-2 char{1, 1}"]]
eNFA1_4_14919761[["εNFA1-4 post-regex start"]]
class eNFA1_4_14919761 c0010;
eNFA2_4_41994123[["εNFA2-4 post-regex start"]]
class eNFA2_4_41994123 c0010;
eNFA3_4_10878253[["εNFA3-4 post-regex start"]]
class eNFA3_4_10878253 c0010;
eNFA4_4_56572634[["εNFA4-4 post-regex start"]]
class eNFA4_4_56572634 c0010;
eNFA5_4_45178316[["εNFA5-4 post-regex start"]]
class eNFA5_4_45178316 c0010;
eNFA6_4_4558779[["εNFA6-4 post-regex start"]]
class eNFA6_4_4558779 c0010;
eNFA7_3_17727455[["εNFA7-3 char[1]"]]
eNFA8_3_27531352[["εNFA8-3 char[1]"]]
eNFA1_5_60129[\"εNFA1-5 post-regex end"/]
class eNFA1_5_60129 c0001;
eNFA2_5_43834167[\"εNFA2-5 post-regex end"/]
class eNFA2_5_43834167 c0001;
eNFA3_5_46080827[\"εNFA3-5 post-regex end"/]
class eNFA3_5_46080827 c0001;
eNFA4_5_8723262[\"εNFA4-5 post-regex end"/]
class eNFA4_5_8723262 c0001;
eNFA5_5_18980661[\"εNFA5-5 post-regex end"/]
class eNFA5_5_18980661 c0001;
eNFA6_5_35565017[\"εNFA6-5 post-regex end"/]
class eNFA6_5_35565017 c0001;
eNFA7_6_41029017[["εNFA7-6 regex start"]]
eNFA8_4_10515579[["εNFA8-4 char{0, ∞}"]]
eNFA0_1_58963189[\"εNFA0-1 wholeEnd"/]
eNFA7_4_35016046[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_33716833[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_46708959[["εNFA7-7 regex end"]]
eNFA8_6_46455584[["εNFA8-6 regex end"]]
class eNFA8_6_46455584 c0100;
eNFA7_5_26637782[["εNFA7-5 scope[1]"]]
eNFA7_9_41932174[["εNFA7-9 scope[1]"]]
eNFA7_12_25329374[["εNFA7-12 char{1, 1}"]]
eNFA8_7_53737263[["εNFA8-7 post-regex start"]]
class eNFA8_7_53737263 c0010;
eNFA7_10_37765421[["εNFA7-10 scope{1, 1}"]]
eNFA7_13_4344474[["εNFA7-13 char[1]"]]
eNFA8_8_4805945[\"εNFA8-8 post-regex end"/]
class eNFA8_8_4805945 c0001;
eNFA7_11_38413446[["εNFA7-11 scope[1]"]]
eNFA7_14_39100271[["εNFA7-14 char{1, 1}"]]
eNFA7_15_36836846[["εNFA7-15 char[1]"]]
eNFA7_17_63096163[["εNFA7-17 regex end"]]
class eNFA7_17_63096163 c0100;
eNFA7_18_30994559[["εNFA7-18 post-regex start"]]
class eNFA7_18_30994559 c0010;
eNFA7_19_24481406[\"εNFA7-19 post-regex end"/]
class eNFA7_19_24481406 c0001;
eNFA0_0_541162 -.->|"ε"|eNFA1_2_26248478
eNFA0_0_541162 -.->|"ε"|eNFA2_2_4870463
eNFA0_0_541162 -.->|"ε"|eNFA3_2_42402794
eNFA0_0_541162 -.->|"ε"|eNFA4_2_30795413
eNFA0_0_541162 -.->|"ε"|eNFA5_2_39391664
eNFA0_0_541162 -.->|"ε"|eNFA6_2_3951668
eNFA0_0_541162 -.->|"ε"|eNFA7_16_10176696
eNFA0_0_541162 -.->|"ε"|eNFA8_5_15447074
eNFA1_2_26248478 -.->|"ε
BeginToken 's'"|eNFA1_0_34909710
eNFA2_2_4870463 -.->|"ε
BeginToken 't'"|eNFA2_0_60906657
eNFA3_2_42402794 -.->|"ε
BeginToken 'g'"|eNFA3_0_12074265
eNFA4_2_30795413 -.->|"ε
BeginToken 'w'"|eNFA4_0_11400497
eNFA5_2_39391664 -.->|"ε
BeginToken 'e'"|eNFA5_0_36608226
eNFA6_2_3951668 -.->|"ε
BeginToken 'd'"|eNFA6_0_51649700
eNFA7_16_10176696 -.->|"ε
BeginToken 'blockComment'"|eNFA7_0_19006063
eNFA8_5_15447074 -.->|"ε
BeginToken 'inlineComment'"|eNFA8_0_43253509
eNFA1_0_34909710 -->|"s"|eNFA1_1_45751941
eNFA2_0_60906657 -->|"t"|eNFA2_1_11289004
eNFA3_0_12074265 -->|"g"|eNFA3_1_41559524
eNFA4_0_11400497 -->|"w"|eNFA4_1_35495616
eNFA5_0_36608226 -->|"e"|eNFA5_1_61038585
eNFA6_0_51649700 -->|"d"|eNFA6_1_62194118
eNFA7_0_19006063 -->|"/"|eNFA7_1_30368798
eNFA8_0_43253509 -->|"/"|eNFA8_1_4883734
eNFA1_1_45751941 -.->|"ε
ExtendToken 's'"|eNFA1_3_9114291
eNFA2_1_11289004 -.->|"ε
ExtendToken 't'"|eNFA2_3_34492175
eNFA3_1_41559524 -.->|"ε
ExtendToken 'g'"|eNFA3_3_38491397
eNFA4_1_35495616 -.->|"ε
ExtendToken 'w'"|eNFA4_3_51025090
eNFA5_1_61038585 -.->|"ε
ExtendToken 'e'"|eNFA5_3_12476353
eNFA6_1_62194118 -.->|"ε
ExtendToken 'd'"|eNFA6_3_22876152
eNFA7_1_30368798 -.->|"ε"|eNFA7_2_43953607
eNFA8_1_4883734 -.->|"ε"|eNFA8_2_60038148
eNFA1_3_9114291 -.->|"ε"|eNFA1_4_14919761
eNFA2_3_34492175 -.->|"ε"|eNFA2_4_41994123
eNFA3_3_38491397 -.->|"ε"|eNFA3_4_10878253
eNFA4_3_51025090 -.->|"ε"|eNFA4_4_56572634
eNFA5_3_12476353 -.->|"ε"|eNFA5_4_45178316
eNFA6_3_22876152 -.->|"ε"|eNFA6_4_4558779
eNFA7_2_43953607 -->|"*"|eNFA7_3_17727455
eNFA8_2_60038148 -->|"/"|eNFA8_3_27531352
eNFA1_4_14919761 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_60129
eNFA2_4_41994123 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_43834167
eNFA3_4_10878253 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_46080827
eNFA4_4_56572634 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_8723262
eNFA5_4_45178316 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_18980661
eNFA6_4_4558779 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_35565017
eNFA7_3_17727455 -.->|"ε"|eNFA7_6_41029017
eNFA8_3_27531352 -.->|"ε"|eNFA8_4_10515579
eNFA1_5_60129 -.->|"ε"|eNFA0_1_58963189
eNFA2_5_43834167 -.->|"ε"|eNFA0_1_58963189
eNFA3_5_46080827 -.->|"ε"|eNFA0_1_58963189
eNFA4_5_8723262 -.->|"ε"|eNFA0_1_58963189
eNFA5_5_18980661 -.->|"ε"|eNFA0_1_58963189
eNFA6_5_35565017 -.->|"ε"|eNFA0_1_58963189
eNFA7_6_41029017 -.->|"ε"|eNFA7_4_35016046
eNFA7_6_41029017 -.->|"ε"|eNFA7_8_33716833
eNFA7_6_41029017 -.->|"ε"|eNFA7_7_46708959
eNFA8_4_10515579 -->|"[#92;t#92;r#32;-~]"|eNFA8_4_10515579
eNFA8_4_10515579 -.->|"ε
ExtendToken 'inlineComment'"|eNFA8_6_46455584
eNFA7_4_35016046 -->|"[^*]"|eNFA7_5_26637782
eNFA7_8_33716833 -->|"[*]"|eNFA7_9_41932174
eNFA7_7_46708959 -.->|"ε"|eNFA7_6_41029017
eNFA7_7_46708959 -.->|"ε"|eNFA7_12_25329374
eNFA8_6_46455584 -.->|"ε"|eNFA8_7_53737263
eNFA7_5_26637782 -.->|"ε"|eNFA7_7_46708959
eNFA7_9_41932174 -.->|"ε"|eNFA7_10_37765421
eNFA7_12_25329374 -->|"*"|eNFA7_13_4344474
eNFA8_7_53737263 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA8_8_4805945
eNFA7_10_37765421 -->|"[^/]"|eNFA7_11_38413446
eNFA7_13_4344474 -.->|"ε"|eNFA7_14_39100271
eNFA8_8_4805945 -.->|"ε"|eNFA0_1_58963189
eNFA7_11_38413446 -.->|"ε"|eNFA7_7_46708959
eNFA7_14_39100271 -->|"/"|eNFA7_15_36836846
eNFA7_15_36836846 -.->|"ε
ExtendToken 'blockComment'"|eNFA7_17_63096163
eNFA7_17_63096163 -.->|"ε"|eNFA7_18_30994559
eNFA7_18_30994559 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA7_19_24481406
eNFA7_19_24481406 -.->|"ε"|eNFA0_1_58963189
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
eNFA0_0_13873320[["εNFA0-0 wholeStart"]]
class eNFA0_0_13873320 c1000;
eNFA1_2_49997107[["εNFA1-2 regex start"]]
class eNFA1_2_49997107 c1000;
eNFA2_2_57751017[["εNFA2-2 regex start"]]
class eNFA2_2_57751017 c1000;
eNFA3_2_47320783[["εNFA3-2 regex start"]]
class eNFA3_2_47320783 c1000;
eNFA4_2_23233871[["εNFA4-2 regex start"]]
class eNFA4_2_23233871 c1000;
eNFA5_2_7778251[["εNFA5-2 regex start"]]
class eNFA5_2_7778251 c1000;
eNFA6_2_2895395[["εNFA6-2 regex start"]]
class eNFA6_2_2895395 c1000;
eNFA7_16_26058562[["εNFA7-16 regex start"]]
class eNFA7_16_26058562 c1000;
eNFA8_5_33200472[["εNFA8-5 regex start"]]
class eNFA8_5_33200472 c1000;
eNFA1_0_46804961[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_46804961 c1000;
eNFA2_0_64300229[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_64300229 c1000;
eNFA3_0_27486043[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_27486043 c1000;
eNFA4_0_14412003[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_14412003 c1000;
eNFA5_0_762524[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_762524 c1000;
eNFA6_0_36869576[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_36869576 c1000;
eNFA7_0_40946598[["εNFA7-0 char{1, 1}"]]
class eNFA7_0_40946598 c1000;
eNFA8_0_13849974[["εNFA8-0 char{1, 1}"]]
class eNFA8_0_13849974 c1000;
eNFA1_1_18591470[\"εNFA1-1 char[1]
AcceptToken 's'"/]
class eNFA1_1_18591470 c0111;
eNFA2_1_41831152[\"εNFA2-1 char[1]
AcceptToken 't'"/]
class eNFA2_1_41831152 c0111;
eNFA3_1_46047796[\"εNFA3-1 char[1]
AcceptToken 'g'"/]
class eNFA3_1_46047796 c0111;
eNFA4_1_62599163[\"εNFA4-1 char[1]
AcceptToken 'w'"/]
class eNFA4_1_62599163 c0111;
eNFA5_1_6862723[\"εNFA5-1 char[1]
AcceptToken 'e'"/]
class eNFA5_1_6862723 c0111;
eNFA6_1_63390733[\"εNFA6-1 char[1]
AcceptToken 'd'"/]
class eNFA6_1_63390733 c0111;
eNFA7_1_48106092[["εNFA7-1 char[1]"]]
eNFA8_1_4279416[["εNFA8-1 char[1]"]]
eNFA1_3_33105505[\"εNFA1-3 regex end
AcceptToken 's'"/]
class eNFA1_3_33105505 c0111;
eNFA1_4_29514091[\"εNFA1-4 post-regex start
AcceptToken 's'"/]
class eNFA1_4_29514091 c0011;
eNFA1_5_12830622[\"εNFA1-5 post-regex end"/]
class eNFA1_5_12830622 c0011;
eNFA0_1_31251786[\"εNFA0-1 wholeEnd"/]
eNFA2_3_40936054[\"εNFA2-3 regex end
AcceptToken 't'"/]
class eNFA2_3_40936054 c0111;
eNFA2_4_32880166[\"εNFA2-4 post-regex start
AcceptToken 't'"/]
class eNFA2_4_32880166 c0011;
eNFA2_5_3472420[\"εNFA2-5 post-regex end"/]
class eNFA2_5_3472420 c0011;
eNFA3_3_11776988[\"εNFA3-3 regex end
AcceptToken 'g'"/]
class eNFA3_3_11776988 c0111;
eNFA3_4_38884035[\"εNFA3-4 post-regex start
AcceptToken 'g'"/]
class eNFA3_4_38884035 c0011;
eNFA3_5_48366737[\"εNFA3-5 post-regex end"/]
class eNFA3_5_48366737 c0011;
eNFA4_3_26521557[\"εNFA4-3 regex end
AcceptToken 'w'"/]
class eNFA4_3_26521557 c0111;
eNFA4_4_37367427[\"εNFA4-4 post-regex start
AcceptToken 'w'"/]
class eNFA4_4_37367427 c0011;
eNFA4_5_32647452[\"εNFA4-5 post-regex end"/]
class eNFA4_5_32647452 c0011;
eNFA5_3_61764512[\"εNFA5-3 regex end
AcceptToken 'e'"/]
class eNFA5_3_61764512 c0111;
eNFA5_4_19009700[\"εNFA5-4 post-regex start
AcceptToken 'e'"/]
class eNFA5_4_19009700 c0011;
eNFA5_5_25391616[\"εNFA5-5 post-regex end"/]
class eNFA5_5_25391616 c0011;
eNFA6_3_33645693[\"εNFA6-3 regex end
AcceptToken 'd'"/]
class eNFA6_3_33645693 c0111;
eNFA6_4_34375783[\"εNFA6-4 post-regex start
AcceptToken 'd'"/]
class eNFA6_4_34375783 c0011;
eNFA6_5_27197959[\"εNFA6-5 post-regex end"/]
class eNFA6_5_27197959 c0011;
eNFA7_2_11088383[["εNFA7-2 char{1, 1}"]]
eNFA7_3_41845253[["εNFA7-3 char[1]"]]
eNFA8_2_38514744[["εNFA8-2 char{1, 1}"]]
eNFA8_3_2174690[\"εNFA8-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA8_3_2174690 c0111;
eNFA7_6_43455040[["εNFA7-6 regex start"]]
eNFA7_4_30197369[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_55551046[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_3340866[["εNFA7-7 regex end"]]
eNFA7_5_34022319[["εNFA7-5 scope[1]"]]
eNFA7_9_32686589[["εNFA7-9 scope[1]"]]
eNFA7_12_41062959[["εNFA7-12 char{1, 1}"]]
eNFA7_13_30368075[["εNFA7-13 char[1]"]]
eNFA8_4_30067794[\"εNFA8-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA8_4_30067794 c0111;
eNFA8_6_19572211[\"εNFA8-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA8_6_19572211 c0111;
eNFA8_7_57540904[\"εNFA8-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA8_7_57540904 c0011;
eNFA8_8_16358126[\"εNFA8-8 post-regex end"/]
class eNFA8_8_16358126 c0011;
eNFA7_10_25743851[["εNFA7-10 scope{1, 1}"]]
eNFA7_11_13005406[["εNFA7-11 scope[1]"]]
eNFA7_14_30301652[["εNFA7-14 char{1, 1}"]]
eNFA7_15_32975066[\"εNFA7-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA7_15_32975066 c0111;
eNFA7_17_28340140[\"εNFA7-17 regex end
AcceptToken 'blockComment'"/]
class eNFA7_17_28340140 c0111;
eNFA7_18_53734669[\"εNFA7-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA7_18_53734669 c0011;
eNFA7_19_49939793[\"εNFA7-19 post-regex end"/]
class eNFA7_19_49939793 c0011;
eNFA0_0_13873320 -.->|"ε"|eNFA1_2_49997107
eNFA0_0_13873320 -.->|"ε"|eNFA2_2_57751017
eNFA0_0_13873320 -.->|"ε"|eNFA3_2_47320783
eNFA0_0_13873320 -.->|"ε"|eNFA4_2_23233871
eNFA0_0_13873320 -.->|"ε"|eNFA5_2_7778251
eNFA0_0_13873320 -.->|"ε"|eNFA6_2_2895395
eNFA0_0_13873320 -.->|"ε"|eNFA7_16_26058562
eNFA0_0_13873320 -.->|"ε"|eNFA8_5_33200472
eNFA0_0_13873320 -.->|"ε
BeginToken 's'"|eNFA1_0_46804961
eNFA0_0_13873320 -.->|"ε
BeginToken 't'"|eNFA2_0_64300229
eNFA0_0_13873320 -.->|"ε
BeginToken 'g'"|eNFA3_0_27486043
eNFA0_0_13873320 -.->|"ε
BeginToken 'w'"|eNFA4_0_14412003
eNFA0_0_13873320 -.->|"ε
BeginToken 'e'"|eNFA5_0_762524
eNFA0_0_13873320 -.->|"ε
BeginToken 'd'"|eNFA6_0_36869576
eNFA0_0_13873320 -.->|"ε
BeginToken 'blockComment'"|eNFA7_0_40946598
eNFA0_0_13873320 -.->|"ε
BeginToken 'inlineComment'"|eNFA8_0_13849974
eNFA0_0_13873320 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_18591470
eNFA0_0_13873320 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_41831152
eNFA0_0_13873320 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_46047796
eNFA0_0_13873320 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_62599163
eNFA0_0_13873320 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_6862723
eNFA0_0_13873320 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_63390733
eNFA0_0_13873320 -->|"/
BeginToken 'blockComment'"|eNFA7_1_48106092
eNFA0_0_13873320 -->|"/
BeginToken 'inlineComment'"|eNFA8_1_4279416
eNFA1_2_49997107 -.->|"ε
BeginToken 's'"|eNFA1_0_46804961
eNFA1_2_49997107 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_18591470
eNFA2_2_57751017 -.->|"ε
BeginToken 't'"|eNFA2_0_64300229
eNFA2_2_57751017 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_41831152
eNFA3_2_47320783 -.->|"ε
BeginToken 'g'"|eNFA3_0_27486043
eNFA3_2_47320783 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_46047796
eNFA4_2_23233871 -.->|"ε
BeginToken 'w'"|eNFA4_0_14412003
eNFA4_2_23233871 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_62599163
eNFA5_2_7778251 -.->|"ε
BeginToken 'e'"|eNFA5_0_762524
eNFA5_2_7778251 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_6862723
eNFA6_2_2895395 -.->|"ε
BeginToken 'd'"|eNFA6_0_36869576
eNFA6_2_2895395 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_63390733
eNFA7_16_26058562 -.->|"ε
BeginToken 'blockComment'"|eNFA7_0_40946598
eNFA7_16_26058562 -->|"/
BeginToken 'blockComment'"|eNFA7_1_48106092
eNFA8_5_33200472 -.->|"ε
BeginToken 'inlineComment'"|eNFA8_0_13849974
eNFA8_5_33200472 -->|"/
BeginToken 'inlineComment'"|eNFA8_1_4279416
eNFA1_0_46804961 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_18591470
eNFA2_0_64300229 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_41831152
eNFA3_0_27486043 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_46047796
eNFA4_0_14412003 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_62599163
eNFA5_0_762524 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_6862723
eNFA6_0_36869576 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_63390733
eNFA7_0_40946598 -->|"/
BeginToken 'blockComment'"|eNFA7_1_48106092
eNFA8_0_13849974 -->|"/
BeginToken 'inlineComment'"|eNFA8_1_4279416
eNFA1_1_18591470 -.->|"ε
ExtendToken 's'"|eNFA1_3_33105505
eNFA1_1_18591470 -.->|"ε"|eNFA1_4_29514091
eNFA1_1_18591470 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_12830622
eNFA1_1_18591470 -.->|"ε
CheckToken 's'"|eNFA0_1_31251786
eNFA2_1_41831152 -.->|"ε
ExtendToken 't'"|eNFA2_3_40936054
eNFA2_1_41831152 -.->|"ε"|eNFA2_4_32880166
eNFA2_1_41831152 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_3472420
eNFA2_1_41831152 -.->|"ε
CheckToken 't'"|eNFA0_1_31251786
eNFA3_1_46047796 -.->|"ε
ExtendToken 'g'"|eNFA3_3_11776988
eNFA3_1_46047796 -.->|"ε"|eNFA3_4_38884035
eNFA3_1_46047796 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_48366737
eNFA3_1_46047796 -.->|"ε
CheckToken 'g'"|eNFA0_1_31251786
eNFA4_1_62599163 -.->|"ε
ExtendToken 'w'"|eNFA4_3_26521557
eNFA4_1_62599163 -.->|"ε"|eNFA4_4_37367427
eNFA4_1_62599163 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_32647452
eNFA4_1_62599163 -.->|"ε
CheckToken 'w'"|eNFA0_1_31251786
eNFA5_1_6862723 -.->|"ε
ExtendToken 'e'"|eNFA5_3_61764512
eNFA5_1_6862723 -.->|"ε"|eNFA5_4_19009700
eNFA5_1_6862723 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_25391616
eNFA5_1_6862723 -.->|"ε
CheckToken 'e'"|eNFA0_1_31251786
eNFA6_1_63390733 -.->|"ε
ExtendToken 'd'"|eNFA6_3_33645693
eNFA6_1_63390733 -.->|"ε"|eNFA6_4_34375783
eNFA6_1_63390733 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_27197959
eNFA6_1_63390733 -.->|"ε
CheckToken 'd'"|eNFA0_1_31251786
eNFA7_1_48106092 -.->|"ε"|eNFA7_2_11088383
eNFA7_1_48106092 -->|"*"|eNFA7_3_41845253
eNFA8_1_4279416 -.->|"ε"|eNFA8_2_38514744
eNFA8_1_4279416 -->|"/
ExtendToken 'inlineComment'"|eNFA8_3_2174690
eNFA1_3_33105505 -.->|"ε"|eNFA1_4_29514091
eNFA1_3_33105505 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_12830622
eNFA1_3_33105505 -.->|"ε
CheckToken 's'"|eNFA0_1_31251786
eNFA1_4_29514091 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_12830622
eNFA1_4_29514091 -.->|"ε
CheckToken 's'"|eNFA0_1_31251786
eNFA1_5_12830622 -.->|"ε
CheckToken 's'"|eNFA0_1_31251786
eNFA2_3_40936054 -.->|"ε"|eNFA2_4_32880166
eNFA2_3_40936054 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_3472420
eNFA2_3_40936054 -.->|"ε
CheckToken 't'"|eNFA0_1_31251786
eNFA2_4_32880166 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_3472420
eNFA2_4_32880166 -.->|"ε
CheckToken 't'"|eNFA0_1_31251786
eNFA2_5_3472420 -.->|"ε
CheckToken 't'"|eNFA0_1_31251786
eNFA3_3_11776988 -.->|"ε"|eNFA3_4_38884035
eNFA3_3_11776988 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_48366737
eNFA3_3_11776988 -.->|"ε
CheckToken 'g'"|eNFA0_1_31251786
eNFA3_4_38884035 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_48366737
eNFA3_4_38884035 -.->|"ε
CheckToken 'g'"|eNFA0_1_31251786
eNFA3_5_48366737 -.->|"ε
CheckToken 'g'"|eNFA0_1_31251786
eNFA4_3_26521557 -.->|"ε"|eNFA4_4_37367427
eNFA4_3_26521557 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_32647452
eNFA4_3_26521557 -.->|"ε
CheckToken 'w'"|eNFA0_1_31251786
eNFA4_4_37367427 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_32647452
eNFA4_4_37367427 -.->|"ε
CheckToken 'w'"|eNFA0_1_31251786
eNFA4_5_32647452 -.->|"ε
CheckToken 'w'"|eNFA0_1_31251786
eNFA5_3_61764512 -.->|"ε"|eNFA5_4_19009700
eNFA5_3_61764512 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_25391616
eNFA5_3_61764512 -.->|"ε
CheckToken 'e'"|eNFA0_1_31251786
eNFA5_4_19009700 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_25391616
eNFA5_4_19009700 -.->|"ε
CheckToken 'e'"|eNFA0_1_31251786
eNFA5_5_25391616 -.->|"ε
CheckToken 'e'"|eNFA0_1_31251786
eNFA6_3_33645693 -.->|"ε"|eNFA6_4_34375783
eNFA6_3_33645693 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_27197959
eNFA6_3_33645693 -.->|"ε
CheckToken 'd'"|eNFA0_1_31251786
eNFA6_4_34375783 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_27197959
eNFA6_4_34375783 -.->|"ε
CheckToken 'd'"|eNFA0_1_31251786
eNFA6_5_27197959 -.->|"ε
CheckToken 'd'"|eNFA0_1_31251786
eNFA7_2_11088383 -->|"*"|eNFA7_3_41845253
eNFA7_3_41845253 -.->|"ε"|eNFA7_6_43455040
eNFA7_3_41845253 -.->|"ε"|eNFA7_4_30197369
eNFA7_3_41845253 -.->|"ε"|eNFA7_8_55551046
eNFA7_3_41845253 -.->|"ε"|eNFA7_7_3340866
eNFA7_3_41845253 -->|"[^*]"|eNFA7_5_34022319
eNFA7_3_41845253 -->|"[*]"|eNFA7_9_32686589
eNFA7_3_41845253 -.->|"ε"|eNFA7_12_41062959
eNFA7_3_41845253 -->|"*"|eNFA7_13_30368075
eNFA8_2_38514744 -->|"/
ExtendToken 'inlineComment'"|eNFA8_3_2174690
eNFA8_3_2174690 -.->|"ε
ExtendToken 'inlineComment'"|eNFA8_4_30067794
eNFA8_3_2174690 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA8_4_30067794
eNFA8_3_2174690 -.->|"ε
ExtendToken 'inlineComment'"|eNFA8_6_19572211
eNFA8_3_2174690 -.->|"ε"|eNFA8_7_57540904
eNFA8_3_2174690 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA8_8_16358126
eNFA8_3_2174690 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_31251786
eNFA7_6_43455040 -.->|"ε"|eNFA7_4_30197369
eNFA7_6_43455040 -.->|"ε"|eNFA7_8_55551046
eNFA7_6_43455040 -.->|"ε"|eNFA7_7_3340866
eNFA7_6_43455040 -->|"[^*]"|eNFA7_5_34022319
eNFA7_6_43455040 -->|"[*]"|eNFA7_9_32686589
eNFA7_6_43455040 -.->|"ε"|eNFA7_6_43455040
eNFA7_6_43455040 -.->|"ε"|eNFA7_12_41062959
eNFA7_6_43455040 -->|"*"|eNFA7_13_30368075
eNFA7_4_30197369 -->|"[^*]"|eNFA7_5_34022319
eNFA7_8_55551046 -->|"[*]"|eNFA7_9_32686589
eNFA7_7_3340866 -.->|"ε"|eNFA7_6_43455040
eNFA7_7_3340866 -.->|"ε"|eNFA7_12_41062959
eNFA7_7_3340866 -.->|"ε"|eNFA7_4_30197369
eNFA7_7_3340866 -.->|"ε"|eNFA7_8_55551046
eNFA7_7_3340866 -.->|"ε"|eNFA7_7_3340866
eNFA7_7_3340866 -->|"[^*]"|eNFA7_5_34022319
eNFA7_7_3340866 -->|"[*]"|eNFA7_9_32686589
eNFA7_7_3340866 -->|"*"|eNFA7_13_30368075
eNFA7_5_34022319 -.->|"ε"|eNFA7_7_3340866
eNFA7_5_34022319 -.->|"ε"|eNFA7_6_43455040
eNFA7_5_34022319 -.->|"ε"|eNFA7_12_41062959
eNFA7_5_34022319 -.->|"ε"|eNFA7_4_30197369
eNFA7_5_34022319 -.->|"ε"|eNFA7_8_55551046
eNFA7_5_34022319 -->|"[^*]"|eNFA7_5_34022319
eNFA7_5_34022319 -->|"[*]"|eNFA7_9_32686589
eNFA7_5_34022319 -->|"*"|eNFA7_13_30368075
eNFA7_9_32686589 -.->|"ε"|eNFA7_10_25743851
eNFA7_9_32686589 -->|"[^/]"|eNFA7_11_13005406
eNFA7_12_41062959 -->|"*"|eNFA7_13_30368075
eNFA7_13_30368075 -.->|"ε"|eNFA7_14_30301652
eNFA7_13_30368075 -->|"/
ExtendToken 'blockComment'"|eNFA7_15_32975066
eNFA8_4_30067794 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA8_4_30067794
eNFA8_4_30067794 -.->|"ε
ExtendToken 'inlineComment'"|eNFA8_6_19572211
eNFA8_4_30067794 -.->|"ε"|eNFA8_7_57540904
eNFA8_4_30067794 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA8_8_16358126
eNFA8_4_30067794 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_31251786
eNFA8_6_19572211 -.->|"ε"|eNFA8_7_57540904
eNFA8_6_19572211 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA8_8_16358126
eNFA8_6_19572211 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_31251786
eNFA8_7_57540904 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA8_8_16358126
eNFA8_7_57540904 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_31251786
eNFA8_8_16358126 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_31251786
eNFA7_10_25743851 -->|"[^/]"|eNFA7_11_13005406
eNFA7_11_13005406 -.->|"ε"|eNFA7_7_3340866
eNFA7_11_13005406 -.->|"ε"|eNFA7_6_43455040
eNFA7_11_13005406 -.->|"ε"|eNFA7_12_41062959
eNFA7_11_13005406 -.->|"ε"|eNFA7_4_30197369
eNFA7_11_13005406 -.->|"ε"|eNFA7_8_55551046
eNFA7_11_13005406 -->|"[^*]"|eNFA7_5_34022319
eNFA7_11_13005406 -->|"[*]"|eNFA7_9_32686589
eNFA7_11_13005406 -->|"*"|eNFA7_13_30368075
eNFA7_14_30301652 -->|"/
ExtendToken 'blockComment'"|eNFA7_15_32975066
eNFA7_15_32975066 -.->|"ε
ExtendToken 'blockComment'"|eNFA7_17_28340140
eNFA7_15_32975066 -.->|"ε"|eNFA7_18_53734669
eNFA7_15_32975066 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA7_19_49939793
eNFA7_15_32975066 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_31251786
eNFA7_17_28340140 -.->|"ε"|eNFA7_18_53734669
eNFA7_17_28340140 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA7_19_49939793
eNFA7_17_28340140 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_31251786
eNFA7_18_53734669 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA7_19_49939793
eNFA7_18_53734669 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_31251786
eNFA7_19_49939793 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_31251786
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
NFA0_0_43894985("NFA0-0 wholeStart")
class NFA0_0_43894985 c1000;
NFA1_1_4877220[\"NFA1-1 char[1]
AcceptToken 's'"/]
class NFA1_1_4877220 c0101;
NFA2_1_59510545[\"NFA2-1 char[1]
AcceptToken 't'"/]
class NFA2_1_59510545 c0101;
NFA3_1_65832863[\"NFA3-1 char[1]
AcceptToken 'g'"/]
class NFA3_1_65832863 c0101;
NFA4_1_55624859[\"NFA4-1 char[1]
AcceptToken 'w'"/]
class NFA4_1_55624859 c0101;
NFA5_1_30861686[\"NFA5-1 char[1]
AcceptToken 'e'"/]
class NFA5_1_30861686 c0101;
NFA6_1_9319721[\"NFA6-1 char[1]
AcceptToken 'd'"/]
class NFA6_1_9319721 c0101;
NFA7_1_16768629("NFA7-1 char[1]")
NFA8_1_16699940("NFA8-1 char[1]")
NFA7_3_10517875("NFA7-3 char[1]")
NFA8_3_16081733[\"NFA8-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA8_3_16081733 c0101;
NFA7_5_46641535("NFA7-5 scope[1]")
NFA7_9_27552014("NFA7-9 scope[1]")
NFA7_13_17120631("NFA7-13 char[1]")
NFA8_4_19867951[\"NFA8-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA8_4_19867951 c0101;
NFA7_11_65800171("NFA7-11 scope[1]")
NFA7_15_44593832[\"NFA7-15 char[1]
AcceptToken 'blockComment'"/]
class NFA7_15_44593832 c0101;
NFA0_0_43894985 -->|"s
BeginToken 's'
ExtendToken 's'"|NFA1_1_4877220
NFA0_0_43894985 -->|"t
BeginToken 't'
ExtendToken 't'"|NFA2_1_59510545
NFA0_0_43894985 -->|"g
BeginToken 'g'
ExtendToken 'g'"|NFA3_1_65832863
NFA0_0_43894985 -->|"w
BeginToken 'w'
ExtendToken 'w'"|NFA4_1_55624859
NFA0_0_43894985 -->|"e
BeginToken 'e'
ExtendToken 'e'"|NFA5_1_30861686
NFA0_0_43894985 -->|"d
BeginToken 'd'
ExtendToken 'd'"|NFA6_1_9319721
NFA0_0_43894985 -->|"/
BeginToken 'blockComment'"|NFA7_1_16768629
NFA0_0_43894985 -->|"/
BeginToken 'inlineComment'"|NFA8_1_16699940
NFA7_1_16768629 -->|"*"|NFA7_3_10517875
NFA8_1_16699940 -->|"/
ExtendToken 'inlineComment'"|NFA8_3_16081733
NFA7_3_10517875 -->|"[^*]"|NFA7_5_46641535
NFA7_3_10517875 -->|"[*]"|NFA7_9_27552014
NFA7_3_10517875 -->|"*"|NFA7_13_17120631
NFA8_3_16081733 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA8_4_19867951
NFA7_5_46641535 -->|"[^*]"|NFA7_5_46641535
NFA7_5_46641535 -->|"[*]"|NFA7_9_27552014
NFA7_5_46641535 -->|"*"|NFA7_13_17120631
NFA7_9_27552014 -->|"[^/]"|NFA7_11_65800171
NFA7_13_17120631 -->|"/
ExtendToken 'blockComment'"|NFA7_15_44593832
NFA8_4_19867951 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA8_4_19867951
NFA7_11_65800171 -->|"[^*]"|NFA7_5_46641535
NFA7_11_65800171 -->|"[*]"|NFA7_9_27552014
NFA7_11_65800171 -->|"*"|NFA7_13_17120631
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
subgraph DFA0_-1299054439["DFA0 wholeStart"]
NFA0_0_43894985_0("NFA0-0 wholeStart")
class NFA0_0_43894985_0 c1000;
end
class DFA0_-1299054439 c1000;
subgraph DFA1_1055845689["DFA1 {1}"]
NFA1_1_4877220_1[\"NFA1-1 char[1]
AcceptToken 's'"/]
class NFA1_1_4877220_1 c0101;
end
class DFA1_1055845689 c0101;
subgraph DFA2_-1917490574["DFA2 {1}"]
NFA2_1_59510545_2[\"NFA2-1 char[1]
AcceptToken 't'"/]
class NFA2_1_59510545_2 c0101;
end
class DFA2_-1917490574 c0101;
subgraph DFA3_-701376295["DFA3 {1}"]
NFA3_1_65832863_3[\"NFA3-1 char[1]
AcceptToken 'g'"/]
class NFA3_1_65832863_3 c0101;
end
class DFA3_-701376295 c0101;
subgraph DFA4_-681318700["DFA4 {1}"]
NFA4_1_55624859_4[\"NFA4-1 char[1]
AcceptToken 'w'"/]
class NFA4_1_55624859_4 c0101;
end
class DFA4_-681318700 c0101;
subgraph DFA5_2051529573["DFA5 {1}"]
NFA5_1_30861686_5[\"NFA5-1 char[1]
AcceptToken 'e'"/]
class NFA5_1_30861686_5 c0101;
end
class DFA5_2051529573 c0101;
subgraph DFA6_-1169595839["DFA6 {1}"]
NFA6_1_9319721_6[\"NFA6-1 char[1]
AcceptToken 'd'"/]
class NFA6_1_9319721_6 c0101;
end
class DFA6_-1169595839 c0101;
subgraph DFA7_-670766500["DFA7 {2}"]
NFA7_1_16768629_7("NFA7-1 char[1]")
NFA8_1_16699940_8("NFA8-1 char[1]")
end
subgraph DFA8_1306797959["DFA8 {1}"]
NFA7_3_10517875_9("NFA7-3 char[1]")
end
subgraph DFA9_-1957368769["DFA9 {1}"]
NFA8_3_16081733_10[\"NFA8-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA8_3_16081733_10 c0101;
end
class DFA9_-1957368769 c0101;
subgraph DFA10_-167006945["DFA10 {1}"]
NFA7_5_46641535_11("NFA7-5 scope[1]")
end
subgraph DFA11_1657803936["DFA11 {2}"]
NFA7_9_27552014_12("NFA7-9 scope[1]")
NFA7_13_17120631_13("NFA7-13 char[1]")
end
subgraph DFA12_1950027080["DFA12 {1}"]
NFA8_4_19867951_14[\"NFA8-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA8_4_19867951_14 c0101;
end
class DFA12_1950027080 c0101;
subgraph DFA13_-1208762609["DFA13 {1}"]
NFA7_11_65800171_15("NFA7-11 scope[1]")
end
subgraph DFA14_-560072739["DFA14 {1}"]
NFA7_15_44593832_16[\"NFA7-15 char[1]
AcceptToken 'blockComment'"/]
class NFA7_15_44593832_16 c0101;
end
class DFA14_-560072739 c0101;
DFA0_-1299054439 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA1_1055845689
DFA0_-1299054439 -->|"t
BeginToken 't'
ExtendToken 't'"|DFA2_-1917490574
DFA0_-1299054439 -->|"g
BeginToken 'g'
ExtendToken 'g'"|DFA3_-701376295
DFA0_-1299054439 -->|"w
BeginToken 'w'
ExtendToken 'w'"|DFA4_-681318700
DFA0_-1299054439 -->|"e
BeginToken 'e'
ExtendToken 'e'"|DFA5_2051529573
DFA0_-1299054439 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA6_-1169595839
DFA0_-1299054439 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA7_-670766500
DFA7_-670766500 -->|"*"|DFA8_1306797959
DFA7_-670766500 -->|"/
ExtendToken 'inlineComment'"|DFA9_-1957368769
DFA8_1306797959 -->|"[^*]"|DFA10_-167006945
DFA8_1306797959 -->|"*"|DFA11_1657803936
DFA9_-1957368769 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1950027080
DFA10_-167006945 -->|"[^*]"|DFA10_-167006945
DFA10_-167006945 -->|"*"|DFA11_1657803936
DFA11_1657803936 -->|"[^/]"|DFA13_-1208762609
DFA11_1657803936 -->|"/
ExtendToken 'blockComment'"|DFA14_-560072739
DFA12_1950027080 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1950027080
DFA13_-1208762609 -->|"[^*]"|DFA10_-167006945
DFA13_-1208762609 -->|"*"|DFA11_1657803936
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
DFA0_-1299054439{{"DFA0 wholeStart"}}
class DFA0_-1299054439 c1000;
DFA1_1055845689[\"DFA1 {1}
AcceptToken 's'"/]
class DFA1_1055845689 c0101;
DFA2_-1917490574[\"DFA2 {1}
AcceptToken 't'"/]
class DFA2_-1917490574 c0101;
DFA3_-701376295[\"DFA3 {1}
AcceptToken 'g'"/]
class DFA3_-701376295 c0101;
DFA4_-681318700[\"DFA4 {1}
AcceptToken 'w'"/]
class DFA4_-681318700 c0101;
DFA5_2051529573[\"DFA5 {1}
AcceptToken 'e'"/]
class DFA5_2051529573 c0101;
DFA6_-1169595839[\"DFA6 {1}
AcceptToken 'd'"/]
class DFA6_-1169595839 c0101;
DFA7_-670766500{{"DFA7 {2}"}}
DFA8_1306797959{{"DFA8 {1}"}}
DFA9_-1957368769[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1957368769 c0101;
DFA10_-167006945{{"DFA10 {1}"}}
DFA11_1657803936{{"DFA11 {2}"}}
DFA12_1950027080[\"DFA12 {1}
AcceptToken 'inlineComment'"/]
class DFA12_1950027080 c0101;
DFA13_-1208762609{{"DFA13 {1}"}}
DFA14_-560072739[\"DFA14 {1}
AcceptToken 'blockComment'"/]
class DFA14_-560072739 c0101;
DFA0_-1299054439 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA1_1055845689
DFA0_-1299054439 -->|"t
BeginToken 't'
ExtendToken 't'"|DFA2_-1917490574
DFA0_-1299054439 -->|"g
BeginToken 'g'
ExtendToken 'g'"|DFA3_-701376295
DFA0_-1299054439 -->|"w
BeginToken 'w'
ExtendToken 'w'"|DFA4_-681318700
DFA0_-1299054439 -->|"e
BeginToken 'e'
ExtendToken 'e'"|DFA5_2051529573
DFA0_-1299054439 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA6_-1169595839
DFA0_-1299054439 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA7_-670766500
DFA7_-670766500 -->|"*"|DFA8_1306797959
DFA7_-670766500 -->|"/
ExtendToken 'inlineComment'"|DFA9_-1957368769
DFA8_1306797959 -->|"[^*]"|DFA10_-167006945
DFA8_1306797959 -->|"*"|DFA11_1657803936
DFA9_-1957368769 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1950027080
DFA10_-167006945 -->|"[^*]"|DFA10_-167006945
DFA10_-167006945 -->|"*"|DFA11_1657803936
DFA11_1657803936 -->|"[^/]"|DFA13_-1208762609
DFA11_1657803936 -->|"/
ExtendToken 'blockComment'"|DFA14_-560072739
DFA12_1950027080 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1950027080
DFA13_-1208762609 -->|"[^*]"|DFA10_-167006945
DFA13_-1208762609 -->|"*"|DFA11_1657803936
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
subgraph MiniDFA0_-1374853353["MiniDFA0 {1}"]
DFA0_-1299054439_0{{"DFA0 wholeStart"}}
class DFA0_-1299054439_0 c1000;
end
class MiniDFA0_-1374853353 c1000;
subgraph MiniDFA4_-2079138749["MiniDFA4 {1}"]
DFA1_1055845689_1[\"DFA1 {1}
AcceptToken 's'"/]
class DFA1_1055845689_1 c0101;
end
class MiniDFA4_-2079138749 c0101;
subgraph MiniDFA5_-457621818["MiniDFA5 {1}"]
DFA2_-1917490574_2[\"DFA2 {1}
AcceptToken 't'"/]
class DFA2_-1917490574_2 c0101;
end
class MiniDFA5_-457621818 c0101;
subgraph MiniDFA6_511684543["MiniDFA6 {1}"]
DFA3_-701376295_3[\"DFA3 {1}
AcceptToken 'g'"/]
class DFA3_-701376295_3 c0101;
end
class MiniDFA6_511684543 c0101;
subgraph MiniDFA7_-1236270071["MiniDFA7 {1}"]
DFA4_-681318700_4[\"DFA4 {1}
AcceptToken 'w'"/]
class DFA4_-681318700_4 c0101;
end
class MiniDFA7_-1236270071 c0101;
subgraph MiniDFA8_-1428199615["MiniDFA8 {1}"]
DFA5_2051529573_5[\"DFA5 {1}
AcceptToken 'e'"/]
class DFA5_2051529573_5 c0101;
end
class MiniDFA8_-1428199615 c0101;
subgraph MiniDFA9_-830418548["MiniDFA9 {1}"]
DFA6_-1169595839_6[\"DFA6 {1}
AcceptToken 'd'"/]
class DFA6_-1169595839_6 c0101;
end
class MiniDFA9_-830418548 c0101;
subgraph MiniDFA1_-1434017908["MiniDFA1 {1}"]
DFA7_-670766500_7{{"DFA7 {2}"}}
end
subgraph MiniDFA2_1078136426["MiniDFA2 {3}"]
DFA8_1306797959_8{{"DFA8 {1}"}}
DFA10_-167006945_9{{"DFA10 {1}"}}
DFA13_-1208762609_10{{"DFA13 {1}"}}
end
subgraph MiniDFA10_1509238363["MiniDFA10 {1}"]
DFA9_-1957368769_11[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1957368769_11 c0101;
end
class MiniDFA10_1509238363 c0101;
subgraph MiniDFA3_-1680542343["MiniDFA3 {1}"]
DFA11_1657803936_12{{"DFA11 {2}"}}
end
subgraph MiniDFA11_-808404463["MiniDFA11 {1}"]
DFA12_1950027080_13[\"DFA12 {1}
AcceptToken 'inlineComment'"/]
class DFA12_1950027080_13 c0101;
end
class MiniDFA11_-808404463 c0101;
subgraph MiniDFA12_-421454105["MiniDFA12 {1}"]
DFA14_-560072739_14[\"DFA14 {1}
AcceptToken 'blockComment'"/]
class DFA14_-560072739_14 c0101;
end
class MiniDFA12_-421454105 c0101;
MiniDFA0_-1374853353 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA4_-2079138749
MiniDFA0_-1374853353 -->|"t
BeginToken 't'
ExtendToken 't'"|MiniDFA5_-457621818
MiniDFA0_-1374853353 -->|"g
BeginToken 'g'
ExtendToken 'g'"|MiniDFA6_511684543
MiniDFA0_-1374853353 -->|"w
BeginToken 'w'
ExtendToken 'w'"|MiniDFA7_-1236270071
MiniDFA0_-1374853353 -->|"e
BeginToken 'e'
ExtendToken 'e'"|MiniDFA8_-1428199615
MiniDFA0_-1374853353 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA9_-830418548
MiniDFA0_-1374853353 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1434017908
MiniDFA1_-1434017908 -->|"*"|MiniDFA2_1078136426
MiniDFA1_-1434017908 -->|"/
ExtendToken 'inlineComment'"|MiniDFA10_1509238363
MiniDFA2_1078136426 -->|"[^*]"|MiniDFA2_1078136426
MiniDFA2_1078136426 -->|"*"|MiniDFA3_-1680542343
MiniDFA10_1509238363 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-808404463
MiniDFA3_-1680542343 -->|"[^/]"|MiniDFA2_1078136426
MiniDFA3_-1680542343 -->|"/
ExtendToken 'blockComment'"|MiniDFA12_-421454105
MiniDFA11_-808404463 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-808404463
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
MiniDFA0_-1374853353(["MiniDFA0 {1}"])
class MiniDFA0_-1374853353 c1000;
MiniDFA4_-2079138749[\"MiniDFA4 {1}
AcceptToken 's'"/]
class MiniDFA4_-2079138749 c0101;
MiniDFA5_-457621818[\"MiniDFA5 {1}
AcceptToken 't'"/]
class MiniDFA5_-457621818 c0101;
MiniDFA6_511684543[\"MiniDFA6 {1}
AcceptToken 'g'"/]
class MiniDFA6_511684543 c0101;
MiniDFA7_-1236270071[\"MiniDFA7 {1}
AcceptToken 'w'"/]
class MiniDFA7_-1236270071 c0101;
MiniDFA8_-1428199615[\"MiniDFA8 {1}
AcceptToken 'e'"/]
class MiniDFA8_-1428199615 c0101;
MiniDFA9_-830418548[\"MiniDFA9 {1}
AcceptToken 'd'"/]
class MiniDFA9_-830418548 c0101;
MiniDFA1_-1434017908(["MiniDFA1 {1}"])
MiniDFA2_1078136426(["MiniDFA2 {3}"])
MiniDFA10_1509238363[\"MiniDFA10 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA10_1509238363 c0101;
MiniDFA3_-1680542343(["MiniDFA3 {1}"])
MiniDFA11_-808404463[\"MiniDFA11 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA11_-808404463 c0101;
MiniDFA12_-421454105[\"MiniDFA12 {1}
AcceptToken 'blockComment'"/]
class MiniDFA12_-421454105 c0101;
MiniDFA0_-1374853353 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA4_-2079138749
MiniDFA0_-1374853353 -->|"t
BeginToken 't'
ExtendToken 't'"|MiniDFA5_-457621818
MiniDFA0_-1374853353 -->|"g
BeginToken 'g'
ExtendToken 'g'"|MiniDFA6_511684543
MiniDFA0_-1374853353 -->|"w
BeginToken 'w'
ExtendToken 'w'"|MiniDFA7_-1236270071
MiniDFA0_-1374853353 -->|"e
BeginToken 'e'
ExtendToken 'e'"|MiniDFA8_-1428199615
MiniDFA0_-1374853353 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA9_-830418548
MiniDFA0_-1374853353 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1434017908
MiniDFA1_-1434017908 -->|"*"|MiniDFA2_1078136426
MiniDFA1_-1434017908 -->|"/
ExtendToken 'inlineComment'"|MiniDFA10_1509238363
MiniDFA2_1078136426 -->|"[^*]"|MiniDFA2_1078136426
MiniDFA2_1078136426 -->|"*"|MiniDFA3_-1680542343
MiniDFA10_1509238363 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-808404463
MiniDFA3_-1680542343 -->|"[^/]"|MiniDFA2_1078136426
MiniDFA3_-1680542343 -->|"/
ExtendToken 'blockComment'"|MiniDFA12_-421454105
MiniDFA11_-808404463 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-808404463
```
-------------------------------
