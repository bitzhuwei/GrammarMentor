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
eNFA0_0_61735358[["εNFA0-0 wholeStart"]]
eNFA1_2_49150562[["εNFA1-2 regex start"]]
class eNFA1_2_49150562 c1000;
eNFA2_2_18747312[["εNFA2-2 regex start"]]
class eNFA2_2_18747312 c1000;
eNFA3_2_37685299[["εNFA3-2 regex start"]]
class eNFA3_2_37685299 c1000;
eNFA4_2_13858403[["εNFA4-2 regex start"]]
class eNFA4_2_13858403 c1000;
eNFA5_2_61469371[["εNFA5-2 regex start"]]
class eNFA5_2_61469371 c1000;
eNFA6_2_24250547[["εNFA6-2 regex start"]]
class eNFA6_2_24250547 c1000;
eNFA7_2_14920772[["εNFA7-2 regex start"]]
class eNFA7_2_14920772 c1000;
eNFA8_16_46191521[["εNFA8-16 regex start"]]
class eNFA8_16_46191521 c1000;
eNFA9_5_59880657[["εNFA9-5 regex start"]]
class eNFA9_5_59880657 c1000;
eNFA1_0_32089967[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_43691456[["εNFA2-0 char{1, 1}"]]
eNFA3_0_32610412[["εNFA3-0 char{1, 1}"]]
eNFA4_0_48788849[["εNFA4-0 char{1, 1}"]]
eNFA5_0_12963143[["εNFA5-0 char{1, 1}"]]
eNFA6_0_18137316[["εNFA6-0 char{1, 1}"]]
eNFA7_0_623043[["εNFA7-0 char{1, 1}"]]
eNFA8_0_50525752[["εNFA8-0 char{1, 1}"]]
eNFA9_0_18495050[["εNFA9-0 char{1, 1}"]]
eNFA1_1_25935173[["εNFA1-1 scope[1]"]]
eNFA2_1_57678784[["εNFA2-1 char[1]"]]
eNFA3_1_25058257[["εNFA3-1 char[1]"]]
eNFA4_1_36446461[["εNFA4-1 char[1]"]]
eNFA5_1_49559423[["εNFA5-1 char[1]"]]
eNFA6_1_29018124[["εNFA6-1 char[1]"]]
eNFA7_1_5607390[["εNFA7-1 char[1]"]]
eNFA8_1_49967061[["εNFA8-1 char[1]"]]
eNFA9_1_47050372[["εNFA9-1 char[1]"]]
eNFA1_3_20374254[["εNFA1-3 regex end"]]
class eNFA1_3_20374254 c0100;
eNFA2_3_49347015[["εNFA2-3 regex end"]]
class eNFA2_3_49347015 c0100;
eNFA3_3_24197721[["εNFA3-3 regex end"]]
class eNFA3_3_24197721 c0100;
eNFA4_3_59582700[["εNFA4-3 regex end"]]
class eNFA4_3_59582700 c0100;
eNFA5_3_43381623[["εNFA5-3 regex end"]]
class eNFA5_3_43381623 c0100;
eNFA6_3_59836530[["εNFA6-3 regex end"]]
class eNFA6_3_59836530 c0100;
eNFA7_3_50466518[["εNFA7-3 regex end"]]
class eNFA7_3_50466518 c0100;
eNFA8_2_63830089[["εNFA8-2 char{1, 1}"]]
eNFA9_2_37599894[["εNFA9-2 char{1, 1}"]]
eNFA1_4_39701876[["εNFA1-4 post-regex start"]]
class eNFA1_4_39701876 c0010;
eNFA2_4_41469957[["εNFA2-4 post-regex start"]]
class eNFA2_4_41469957 c0010;
eNFA3_4_16452903[["εNFA3-4 post-regex start"]]
class eNFA3_4_16452903 c0010;
eNFA4_4_66482253[["εNFA4-4 post-regex start"]]
class eNFA4_4_66482253 c0010;
eNFA5_4_54890288[["εNFA5-4 post-regex start"]]
class eNFA5_4_54890288 c0010;
eNFA6_4_1657863[["εNFA6-4 post-regex start"]]
class eNFA6_4_1657863 c0010;
eNFA7_4_51545483[["εNFA7-4 post-regex start"]]
class eNFA7_4_51545483 c0010;
eNFA8_3_53829147[["εNFA8-3 char[1]"]]
eNFA9_3_36364960[["εNFA9-3 char[1]"]]
eNFA1_5_21772565[\"εNFA1-5 post-regex end"/]
class eNFA1_5_21772565 c0001;
eNFA2_5_34508084[\"εNFA2-5 post-regex end"/]
class eNFA2_5_34508084 c0001;
eNFA3_5_3623379[\"εNFA3-5 post-regex end"/]
class eNFA3_5_3623379 c0001;
eNFA4_5_57616766[\"εNFA4-5 post-regex end"/]
class eNFA4_5_57616766 c0001;
eNFA5_5_16353430[\"εNFA5-5 post-regex end"/]
class eNFA5_5_16353430 c0001;
eNFA6_5_16928338[\"εNFA6-5 post-regex end"/]
class eNFA6_5_16928338 c0001;
eNFA7_5_69227[\"εNFA7-5 post-regex end"/]
class eNFA7_5_69227 c0001;
eNFA8_6_61256166[["εNFA8-6 regex start"]]
eNFA9_4_48779793[["εNFA9-4 char{0, ∞}"]]
eNFA0_1_42137308[\"εNFA0-1 wholeEnd"/]
eNFA8_4_62802394[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_14434584[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_28350637[["εNFA8-7 regex end"]]
eNFA9_6_58849189[["εNFA9-6 regex end"]]
class eNFA9_6_58849189 c0100;
eNFA8_5_65193616[["εNFA8-5 scope[1]"]]
eNFA8_9_58377623[["εNFA8-9 scope[1]"]]
eNFA8_12_14700275[["εNFA8-12 char{1, 1}"]]
eNFA9_7_32237730[["εNFA9-7 post-regex start"]]
class eNFA9_7_32237730 c0010;
eNFA8_10_25299820[["εNFA8-10 scope{1, 1}"]]
eNFA8_13_26371793[["εNFA8-13 char[1]"]]
eNFA9_8_2055005[\"εNFA9-8 post-regex end"/]
class eNFA9_8_2055005 c0001;
eNFA8_11_49871633[["εNFA8-11 scope[1]"]]
eNFA8_14_36019552[["εNFA8-14 char{1, 1}"]]
eNFA8_15_52078584[["εNFA8-15 char[1]"]]
eNFA8_17_66054074[["εNFA8-17 regex end"]]
class eNFA8_17_66054074 c0100;
eNFA8_18_57615760[["εNFA8-18 post-regex start"]]
class eNFA8_18_57615760 c0010;
eNFA8_19_13070512[\"εNFA8-19 post-regex end"/]
class eNFA8_19_13070512 c0001;
eNFA0_0_61735358 -.->|"ε"|eNFA1_2_49150562
eNFA0_0_61735358 -.->|"ε"|eNFA2_2_18747312
eNFA0_0_61735358 -.->|"ε"|eNFA3_2_37685299
eNFA0_0_61735358 -.->|"ε"|eNFA4_2_13858403
eNFA0_0_61735358 -.->|"ε"|eNFA5_2_61469371
eNFA0_0_61735358 -.->|"ε"|eNFA6_2_24250547
eNFA0_0_61735358 -.->|"ε"|eNFA7_2_14920772
eNFA0_0_61735358 -.->|"ε"|eNFA8_16_46191521
eNFA0_0_61735358 -.->|"ε"|eNFA9_5_59880657
eNFA1_2_49150562 -.->|"ε
BeginToken 'number'"|eNFA1_0_32089967
eNFA2_2_18747312 -.->|"ε
BeginToken '+'"|eNFA2_0_43691456
eNFA3_2_37685299 -.->|"ε
BeginToken '-'"|eNFA3_0_32610412
eNFA4_2_13858403 -.->|"ε
BeginToken '*'"|eNFA4_0_48788849
eNFA5_2_61469371 -.->|"ε
BeginToken '/'"|eNFA5_0_12963143
eNFA6_2_24250547 -.->|"ε
BeginToken '('"|eNFA6_0_18137316
eNFA7_2_14920772 -.->|"ε
BeginToken ')'"|eNFA7_0_623043
eNFA8_16_46191521 -.->|"ε
BeginToken 'blockComment'"|eNFA8_0_50525752
eNFA9_5_59880657 -.->|"ε
BeginToken 'inlineComment'"|eNFA9_0_18495050
eNFA1_0_32089967 -->|"[0-9]"|eNFA1_1_25935173
eNFA2_0_43691456 -->|"+"|eNFA2_1_57678784
eNFA3_0_32610412 -->|"-"|eNFA3_1_25058257
eNFA4_0_48788849 -->|"*"|eNFA4_1_36446461
eNFA5_0_12963143 -->|"/"|eNFA5_1_49559423
eNFA6_0_18137316 -->|"("|eNFA6_1_29018124
eNFA7_0_623043 -->|")"|eNFA7_1_5607390
eNFA8_0_50525752 -->|"/"|eNFA8_1_49967061
eNFA9_0_18495050 -->|"/"|eNFA9_1_47050372
eNFA1_1_25935173 -->|"[0-9]"|eNFA1_1_25935173
eNFA1_1_25935173 -.->|"ε
ExtendToken 'number'"|eNFA1_3_20374254
eNFA2_1_57678784 -.->|"ε
ExtendToken '+'"|eNFA2_3_49347015
eNFA3_1_25058257 -.->|"ε
ExtendToken '-'"|eNFA3_3_24197721
eNFA4_1_36446461 -.->|"ε
ExtendToken '*'"|eNFA4_3_59582700
eNFA5_1_49559423 -.->|"ε
ExtendToken '/'"|eNFA5_3_43381623
eNFA6_1_29018124 -.->|"ε
ExtendToken '('"|eNFA6_3_59836530
eNFA7_1_5607390 -.->|"ε
ExtendToken ')'"|eNFA7_3_50466518
eNFA8_1_49967061 -.->|"ε"|eNFA8_2_63830089
eNFA9_1_47050372 -.->|"ε"|eNFA9_2_37599894
eNFA1_3_20374254 -.->|"ε"|eNFA1_4_39701876
eNFA2_3_49347015 -.->|"ε"|eNFA2_4_41469957
eNFA3_3_24197721 -.->|"ε"|eNFA3_4_16452903
eNFA4_3_59582700 -.->|"ε"|eNFA4_4_66482253
eNFA5_3_43381623 -.->|"ε"|eNFA5_4_54890288
eNFA6_3_59836530 -.->|"ε"|eNFA6_4_1657863
eNFA7_3_50466518 -.->|"ε"|eNFA7_4_51545483
eNFA8_2_63830089 -->|"*"|eNFA8_3_53829147
eNFA9_2_37599894 -->|"/"|eNFA9_3_36364960
eNFA1_4_39701876 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_21772565
eNFA2_4_41469957 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_34508084
eNFA3_4_16452903 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_3623379
eNFA4_4_66482253 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_57616766
eNFA5_4_54890288 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_16353430
eNFA6_4_1657863 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_16928338
eNFA7_4_51545483 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_69227
eNFA8_3_53829147 -.->|"ε"|eNFA8_6_61256166
eNFA9_3_36364960 -.->|"ε"|eNFA9_4_48779793
eNFA1_5_21772565 -.->|"ε"|eNFA0_1_42137308
eNFA2_5_34508084 -.->|"ε"|eNFA0_1_42137308
eNFA3_5_3623379 -.->|"ε"|eNFA0_1_42137308
eNFA4_5_57616766 -.->|"ε"|eNFA0_1_42137308
eNFA5_5_16353430 -.->|"ε"|eNFA0_1_42137308
eNFA6_5_16928338 -.->|"ε"|eNFA0_1_42137308
eNFA7_5_69227 -.->|"ε"|eNFA0_1_42137308
eNFA8_6_61256166 -.->|"ε"|eNFA8_4_62802394
eNFA8_6_61256166 -.->|"ε"|eNFA8_8_14434584
eNFA8_6_61256166 -.->|"ε"|eNFA8_7_28350637
eNFA9_4_48779793 -->|"[#92;t#92;r#32;-~]"|eNFA9_4_48779793
eNFA9_4_48779793 -.->|"ε
ExtendToken 'inlineComment'"|eNFA9_6_58849189
eNFA8_4_62802394 -->|"[^*]"|eNFA8_5_65193616
eNFA8_8_14434584 -->|"[*]"|eNFA8_9_58377623
eNFA8_7_28350637 -.->|"ε"|eNFA8_6_61256166
eNFA8_7_28350637 -.->|"ε"|eNFA8_12_14700275
eNFA9_6_58849189 -.->|"ε"|eNFA9_7_32237730
eNFA8_5_65193616 -.->|"ε"|eNFA8_7_28350637
eNFA8_9_58377623 -.->|"ε"|eNFA8_10_25299820
eNFA8_12_14700275 -->|"*"|eNFA8_13_26371793
eNFA9_7_32237730 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA9_8_2055005
eNFA8_10_25299820 -->|"[^/]"|eNFA8_11_49871633
eNFA8_13_26371793 -.->|"ε"|eNFA8_14_36019552
eNFA9_8_2055005 -.->|"ε"|eNFA0_1_42137308
eNFA8_11_49871633 -.->|"ε"|eNFA8_7_28350637
eNFA8_14_36019552 -->|"/"|eNFA8_15_52078584
eNFA8_15_52078584 -.->|"ε
ExtendToken 'blockComment'"|eNFA8_17_66054074
eNFA8_17_66054074 -.->|"ε"|eNFA8_18_57615760
eNFA8_18_57615760 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA8_19_13070512
eNFA8_19_13070512 -.->|"ε"|eNFA0_1_42137308
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
eNFA0_0_21704116[["εNFA0-0 wholeStart"]]
class eNFA0_0_21704116 c1000;
eNFA1_2_13202999[["εNFA1-2 regex start"]]
class eNFA1_2_13202999 c1000;
eNFA2_2_61119323[["εNFA2-2 regex start"]]
class eNFA2_2_61119323 c1000;
eNFA3_2_51718129[["εNFA3-2 regex start"]]
class eNFA3_2_51718129 c1000;
eNFA4_2_62809978[["εNFA4-2 regex start"]]
class eNFA4_2_62809978 c1000;
eNFA5_2_28418891[["εNFA5-2 regex start"]]
class eNFA5_2_28418891 c1000;
eNFA6_2_54443429[["εNFA6-2 regex start"]]
class eNFA6_2_54443429 c1000;
eNFA7_2_20228817[["εNFA7-2 regex start"]]
class eNFA7_2_20228817 c1000;
eNFA8_16_47841633[["εNFA8-16 regex start"]]
class eNFA8_16_47841633 c1000;
eNFA9_5_27921517[["εNFA9-5 regex start"]]
class eNFA9_5_27921517 c1000;
eNFA1_0_52983808[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_52983808 c1000;
eNFA2_0_37302179[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_37302179 c1000;
eNFA3_0_60679928[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_60679928 c1000;
eNFA4_0_31226782[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_31226782 c1000;
eNFA5_0_62669527[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_62669527 c1000;
eNFA6_0_65870306[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_65870306 c1000;
eNFA7_0_61105663[["εNFA7-0 char{1, 1}"]]
class eNFA7_0_61105663 c1000;
eNFA8_0_5903470[["εNFA8-0 char{1, 1}"]]
class eNFA8_0_5903470 c1000;
eNFA9_0_10852974[["εNFA9-0 char{1, 1}"]]
class eNFA9_0_10852974 c1000;
eNFA1_1_20800170[\"εNFA1-1 scope[1]
AcceptToken 'number'"/]
class eNFA1_1_20800170 c0111;
eNFA2_1_175293[\"εNFA2-1 char[1]
AcceptToken '+'"/]
class eNFA2_1_175293 c0111;
eNFA3_1_9248440[\"εNFA3-1 char[1]
AcceptToken '-'"/]
class eNFA3_1_9248440 c0111;
eNFA4_1_12605589[\"εNFA4-1 char[1]
AcceptToken '*'"/]
class eNFA4_1_12605589 c0111;
eNFA5_1_27154837[\"εNFA5-1 char[1]
AcceptToken '/'"/]
class eNFA5_1_27154837 c0111;
eNFA6_1_55961846[\"εNFA6-1 char[1]
AcceptToken '('"/]
class eNFA6_1_55961846 c0111;
eNFA7_1_13080057[\"εNFA7-1 char[1]
AcceptToken ')'"/]
class eNFA7_1_13080057 c0111;
eNFA8_1_6675738[["εNFA8-1 char[1]"]]
eNFA9_1_3863873[["εNFA9-1 char[1]"]]
eNFA1_3_7092232[\"εNFA1-3 regex end
AcceptToken 'number'"/]
class eNFA1_3_7092232 c0111;
eNFA1_4_33970848[\"εNFA1-4 post-regex start
AcceptToken 'number'"/]
class eNFA1_4_33970848 c0011;
eNFA1_5_29906272[\"εNFA1-5 post-regex end"/]
class eNFA1_5_29906272 c0011;
eNFA0_1_25692540[\"εNFA0-1 wholeEnd"/]
eNFA2_3_1577639[\"εNFA2-3 regex end
AcceptToken '+'"/]
class eNFA2_3_1577639 c0111;
eNFA2_4_14198754[\"εNFA2-4 post-regex start
AcceptToken '+'"/]
class eNFA2_4_14198754 c0011;
eNFA2_5_2854726[\"εNFA2-5 post-regex end"/]
class eNFA2_5_2854726 c0011;
eNFA3_3_16127101[\"εNFA3-3 regex end
AcceptToken '-'"/]
class eNFA3_3_16127101 c0111;
eNFA3_4_10926182[\"εNFA3-4 post-regex start
AcceptToken '-'"/]
class eNFA3_4_10926182 c0011;
eNFA3_5_720995[\"εNFA3-5 post-regex end"/]
class eNFA3_5_720995 c0011;
eNFA4_3_46341445[\"εNFA4-3 regex end
AcceptToken '*'"/]
class eNFA4_3_46341445 c0111;
eNFA4_4_14419821[\"εNFA4-4 post-regex start
AcceptToken '*'"/]
class eNFA4_4_14419821 c0011;
eNFA4_5_6488958[\"εNFA4-5 post-regex end"/]
class eNFA4_5_6488958 c0011;
eNFA5_3_43066942[\"εNFA5-3 regex end
AcceptToken '/'"/]
class eNFA5_3_43066942 c0111;
eNFA5_4_52058165[\"εNFA5-4 post-regex start
AcceptToken '/'"/]
class eNFA5_4_52058165 c0011;
eNFA5_5_58400626[\"εNFA5-5 post-regex end"/]
class eNFA5_5_58400626 c0011;
eNFA6_3_33894570[\"εNFA6-3 regex end
AcceptToken '('"/]
class eNFA6_3_33894570 c0111;
eNFA6_4_36615679[\"εNFA6-4 post-regex start
AcceptToken '('"/]
class eNFA6_4_36615679 c0011;
eNFA6_5_55843593[\"εNFA6-5 post-regex end"/]
class eNFA6_5_55843593 c0011;
eNFA7_3_50611656[\"εNFA7-3 regex end
AcceptToken ')'"/]
class eNFA7_3_50611656 c0111;
eNFA7_4_52851724[\"εNFA7-4 post-regex start
AcceptToken ')'"/]
class eNFA7_4_52851724 c0011;
eNFA7_5_32830290[\"εNFA7-5 post-regex end"/]
class eNFA7_5_32830290 c0011;
eNFA8_2_44538317[["εNFA8-2 char{1, 1}"]]
eNFA8_3_55636561[["εNFA8-3 char[1]"]]
eNFA9_2_34774863[["εNFA9-2 char{1, 1}"]]
eNFA9_3_64515557[\"εNFA9-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA9_3_64515557 c0111;
eNFA8_6_27037160[["εNFA8-6 regex start"]]
eNFA8_4_42526340[["εNFA8-4 scope{1, 1}"]]
eNFA8_8_42007851[["εNFA8-8 scope{1, 1}"]]
eNFA8_7_47192740[["εNFA8-7 regex end"]]
eNFA8_5_10267631[["εNFA8-5 scope[1]"]]
eNFA8_9_65300541[["εNFA8-9 scope[1]"]]
eNFA8_12_30967009[["εNFA8-12 char{1, 1}"]]
eNFA8_13_54852443[["εNFA8-13 char[1]"]]
eNFA9_4_22081476[\"εNFA9-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA9_4_22081476 c0111;
eNFA9_6_43769104[\"εNFA9-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA9_6_43769104 c0111;
eNFA9_7_30567910[\"εNFA9-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA9_7_30567910 c0011;
eNFA9_8_55740512[\"εNFA9-8 post-regex end"/]
class eNFA9_8_55740512 c0011;
eNFA8_10_50833958[["εNFA8-10 scope{1, 1}"]]
eNFA8_11_31902563[["εNFA8-11 scope[1]"]]
eNFA8_14_60081642[["εNFA8-14 char{1, 1}"]]
eNFA8_15_53131231[\"εNFA8-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA8_15_53131231 c0111;
eNFA8_17_8419032[\"εNFA8-17 regex end
AcceptToken 'blockComment'"/]
class eNFA8_17_8419032 c0111;
eNFA8_18_8662426[\"εNFA8-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA8_18_8662426 c0011;
eNFA8_19_18687619[\"εNFA8-19 post-regex end"/]
class eNFA8_19_18687619 c0011;
eNFA0_0_21704116 -.->|"ε"|eNFA1_2_13202999
eNFA0_0_21704116 -.->|"ε"|eNFA2_2_61119323
eNFA0_0_21704116 -.->|"ε"|eNFA3_2_51718129
eNFA0_0_21704116 -.->|"ε"|eNFA4_2_62809978
eNFA0_0_21704116 -.->|"ε"|eNFA5_2_28418891
eNFA0_0_21704116 -.->|"ε"|eNFA6_2_54443429
eNFA0_0_21704116 -.->|"ε"|eNFA7_2_20228817
eNFA0_0_21704116 -.->|"ε"|eNFA8_16_47841633
eNFA0_0_21704116 -.->|"ε"|eNFA9_5_27921517
eNFA0_0_21704116 -.->|"ε
BeginToken 'number'"|eNFA1_0_52983808
eNFA0_0_21704116 -.->|"ε
BeginToken '+'"|eNFA2_0_37302179
eNFA0_0_21704116 -.->|"ε
BeginToken '-'"|eNFA3_0_60679928
eNFA0_0_21704116 -.->|"ε
BeginToken '*'"|eNFA4_0_31226782
eNFA0_0_21704116 -.->|"ε
BeginToken '/'"|eNFA5_0_62669527
eNFA0_0_21704116 -.->|"ε
BeginToken '('"|eNFA6_0_65870306
eNFA0_0_21704116 -.->|"ε
BeginToken ')'"|eNFA7_0_61105663
eNFA0_0_21704116 -.->|"ε
BeginToken 'blockComment'"|eNFA8_0_5903470
eNFA0_0_21704116 -.->|"ε
BeginToken 'inlineComment'"|eNFA9_0_10852974
eNFA0_0_21704116 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_20800170
eNFA0_0_21704116 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_175293
eNFA0_0_21704116 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_9248440
eNFA0_0_21704116 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_12605589
eNFA0_0_21704116 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_27154837
eNFA0_0_21704116 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_55961846
eNFA0_0_21704116 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_13080057
eNFA0_0_21704116 -->|"/
BeginToken 'blockComment'"|eNFA8_1_6675738
eNFA0_0_21704116 -->|"/
BeginToken 'inlineComment'"|eNFA9_1_3863873
eNFA1_2_13202999 -.->|"ε
BeginToken 'number'"|eNFA1_0_52983808
eNFA1_2_13202999 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_20800170
eNFA2_2_61119323 -.->|"ε
BeginToken '+'"|eNFA2_0_37302179
eNFA2_2_61119323 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_175293
eNFA3_2_51718129 -.->|"ε
BeginToken '-'"|eNFA3_0_60679928
eNFA3_2_51718129 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_9248440
eNFA4_2_62809978 -.->|"ε
BeginToken '*'"|eNFA4_0_31226782
eNFA4_2_62809978 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_12605589
eNFA5_2_28418891 -.->|"ε
BeginToken '/'"|eNFA5_0_62669527
eNFA5_2_28418891 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_27154837
eNFA6_2_54443429 -.->|"ε
BeginToken '('"|eNFA6_0_65870306
eNFA6_2_54443429 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_55961846
eNFA7_2_20228817 -.->|"ε
BeginToken ')'"|eNFA7_0_61105663
eNFA7_2_20228817 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_13080057
eNFA8_16_47841633 -.->|"ε
BeginToken 'blockComment'"|eNFA8_0_5903470
eNFA8_16_47841633 -->|"/
BeginToken 'blockComment'"|eNFA8_1_6675738
eNFA9_5_27921517 -.->|"ε
BeginToken 'inlineComment'"|eNFA9_0_10852974
eNFA9_5_27921517 -->|"/
BeginToken 'inlineComment'"|eNFA9_1_3863873
eNFA1_0_52983808 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_20800170
eNFA2_0_37302179 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_175293
eNFA3_0_60679928 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_9248440
eNFA4_0_31226782 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_12605589
eNFA5_0_62669527 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_27154837
eNFA6_0_65870306 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_55961846
eNFA7_0_61105663 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_13080057
eNFA8_0_5903470 -->|"/
BeginToken 'blockComment'"|eNFA8_1_6675738
eNFA9_0_10852974 -->|"/
BeginToken 'inlineComment'"|eNFA9_1_3863873
eNFA1_1_20800170 -->|"[0-9]
ExtendToken 'number'"|eNFA1_1_20800170
eNFA1_1_20800170 -.->|"ε
ExtendToken 'number'"|eNFA1_3_7092232
eNFA1_1_20800170 -.->|"ε"|eNFA1_4_33970848
eNFA1_1_20800170 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_29906272
eNFA1_1_20800170 -.->|"ε
CheckToken 'number'"|eNFA0_1_25692540
eNFA2_1_175293 -.->|"ε
ExtendToken '+'"|eNFA2_3_1577639
eNFA2_1_175293 -.->|"ε"|eNFA2_4_14198754
eNFA2_1_175293 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_2854726
eNFA2_1_175293 -.->|"ε
CheckToken '+'"|eNFA0_1_25692540
eNFA3_1_9248440 -.->|"ε
ExtendToken '-'"|eNFA3_3_16127101
eNFA3_1_9248440 -.->|"ε"|eNFA3_4_10926182
eNFA3_1_9248440 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_720995
eNFA3_1_9248440 -.->|"ε
CheckToken '-'"|eNFA0_1_25692540
eNFA4_1_12605589 -.->|"ε
ExtendToken '*'"|eNFA4_3_46341445
eNFA4_1_12605589 -.->|"ε"|eNFA4_4_14419821
eNFA4_1_12605589 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_6488958
eNFA4_1_12605589 -.->|"ε
CheckToken '*'"|eNFA0_1_25692540
eNFA5_1_27154837 -.->|"ε
ExtendToken '/'"|eNFA5_3_43066942
eNFA5_1_27154837 -.->|"ε"|eNFA5_4_52058165
eNFA5_1_27154837 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_58400626
eNFA5_1_27154837 -.->|"ε
CheckToken '/'"|eNFA0_1_25692540
eNFA6_1_55961846 -.->|"ε
ExtendToken '('"|eNFA6_3_33894570
eNFA6_1_55961846 -.->|"ε"|eNFA6_4_36615679
eNFA6_1_55961846 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_55843593
eNFA6_1_55961846 -.->|"ε
CheckToken '('"|eNFA0_1_25692540
eNFA7_1_13080057 -.->|"ε
ExtendToken ')'"|eNFA7_3_50611656
eNFA7_1_13080057 -.->|"ε"|eNFA7_4_52851724
eNFA7_1_13080057 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_32830290
eNFA7_1_13080057 -.->|"ε
CheckToken ')'"|eNFA0_1_25692540
eNFA8_1_6675738 -.->|"ε"|eNFA8_2_44538317
eNFA8_1_6675738 -->|"*"|eNFA8_3_55636561
eNFA9_1_3863873 -.->|"ε"|eNFA9_2_34774863
eNFA9_1_3863873 -->|"/
ExtendToken 'inlineComment'"|eNFA9_3_64515557
eNFA1_3_7092232 -.->|"ε"|eNFA1_4_33970848
eNFA1_3_7092232 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_29906272
eNFA1_3_7092232 -.->|"ε
CheckToken 'number'"|eNFA0_1_25692540
eNFA1_4_33970848 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_29906272
eNFA1_4_33970848 -.->|"ε
CheckToken 'number'"|eNFA0_1_25692540
eNFA1_5_29906272 -.->|"ε
CheckToken 'number'"|eNFA0_1_25692540
eNFA2_3_1577639 -.->|"ε"|eNFA2_4_14198754
eNFA2_3_1577639 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_2854726
eNFA2_3_1577639 -.->|"ε
CheckToken '+'"|eNFA0_1_25692540
eNFA2_4_14198754 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_2854726
eNFA2_4_14198754 -.->|"ε
CheckToken '+'"|eNFA0_1_25692540
eNFA2_5_2854726 -.->|"ε
CheckToken '+'"|eNFA0_1_25692540
eNFA3_3_16127101 -.->|"ε"|eNFA3_4_10926182
eNFA3_3_16127101 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_720995
eNFA3_3_16127101 -.->|"ε
CheckToken '-'"|eNFA0_1_25692540
eNFA3_4_10926182 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_720995
eNFA3_4_10926182 -.->|"ε
CheckToken '-'"|eNFA0_1_25692540
eNFA3_5_720995 -.->|"ε
CheckToken '-'"|eNFA0_1_25692540
eNFA4_3_46341445 -.->|"ε"|eNFA4_4_14419821
eNFA4_3_46341445 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_6488958
eNFA4_3_46341445 -.->|"ε
CheckToken '*'"|eNFA0_1_25692540
eNFA4_4_14419821 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_6488958
eNFA4_4_14419821 -.->|"ε
CheckToken '*'"|eNFA0_1_25692540
eNFA4_5_6488958 -.->|"ε
CheckToken '*'"|eNFA0_1_25692540
eNFA5_3_43066942 -.->|"ε"|eNFA5_4_52058165
eNFA5_3_43066942 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_58400626
eNFA5_3_43066942 -.->|"ε
CheckToken '/'"|eNFA0_1_25692540
eNFA5_4_52058165 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_58400626
eNFA5_4_52058165 -.->|"ε
CheckToken '/'"|eNFA0_1_25692540
eNFA5_5_58400626 -.->|"ε
CheckToken '/'"|eNFA0_1_25692540
eNFA6_3_33894570 -.->|"ε"|eNFA6_4_36615679
eNFA6_3_33894570 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_55843593
eNFA6_3_33894570 -.->|"ε
CheckToken '('"|eNFA0_1_25692540
eNFA6_4_36615679 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_55843593
eNFA6_4_36615679 -.->|"ε
CheckToken '('"|eNFA0_1_25692540
eNFA6_5_55843593 -.->|"ε
CheckToken '('"|eNFA0_1_25692540
eNFA7_3_50611656 -.->|"ε"|eNFA7_4_52851724
eNFA7_3_50611656 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_32830290
eNFA7_3_50611656 -.->|"ε
CheckToken ')'"|eNFA0_1_25692540
eNFA7_4_52851724 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_32830290
eNFA7_4_52851724 -.->|"ε
CheckToken ')'"|eNFA0_1_25692540
eNFA7_5_32830290 -.->|"ε
CheckToken ')'"|eNFA0_1_25692540
eNFA8_2_44538317 -->|"*"|eNFA8_3_55636561
eNFA8_3_55636561 -.->|"ε"|eNFA8_6_27037160
eNFA8_3_55636561 -.->|"ε"|eNFA8_4_42526340
eNFA8_3_55636561 -.->|"ε"|eNFA8_8_42007851
eNFA8_3_55636561 -.->|"ε"|eNFA8_7_47192740
eNFA8_3_55636561 -->|"[^*]"|eNFA8_5_10267631
eNFA8_3_55636561 -->|"[*]"|eNFA8_9_65300541
eNFA8_3_55636561 -.->|"ε"|eNFA8_12_30967009
eNFA8_3_55636561 -->|"*"|eNFA8_13_54852443
eNFA9_2_34774863 -->|"/
ExtendToken 'inlineComment'"|eNFA9_3_64515557
eNFA9_3_64515557 -.->|"ε
ExtendToken 'inlineComment'"|eNFA9_4_22081476
eNFA9_3_64515557 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA9_4_22081476
eNFA9_3_64515557 -.->|"ε
ExtendToken 'inlineComment'"|eNFA9_6_43769104
eNFA9_3_64515557 -.->|"ε"|eNFA9_7_30567910
eNFA9_3_64515557 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA9_8_55740512
eNFA9_3_64515557 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_25692540
eNFA8_6_27037160 -.->|"ε"|eNFA8_4_42526340
eNFA8_6_27037160 -.->|"ε"|eNFA8_8_42007851
eNFA8_6_27037160 -.->|"ε"|eNFA8_7_47192740
eNFA8_6_27037160 -->|"[^*]"|eNFA8_5_10267631
eNFA8_6_27037160 -->|"[*]"|eNFA8_9_65300541
eNFA8_6_27037160 -.->|"ε"|eNFA8_6_27037160
eNFA8_6_27037160 -.->|"ε"|eNFA8_12_30967009
eNFA8_6_27037160 -->|"*"|eNFA8_13_54852443
eNFA8_4_42526340 -->|"[^*]"|eNFA8_5_10267631
eNFA8_8_42007851 -->|"[*]"|eNFA8_9_65300541
eNFA8_7_47192740 -.->|"ε"|eNFA8_6_27037160
eNFA8_7_47192740 -.->|"ε"|eNFA8_12_30967009
eNFA8_7_47192740 -.->|"ε"|eNFA8_4_42526340
eNFA8_7_47192740 -.->|"ε"|eNFA8_8_42007851
eNFA8_7_47192740 -.->|"ε"|eNFA8_7_47192740
eNFA8_7_47192740 -->|"[^*]"|eNFA8_5_10267631
eNFA8_7_47192740 -->|"[*]"|eNFA8_9_65300541
eNFA8_7_47192740 -->|"*"|eNFA8_13_54852443
eNFA8_5_10267631 -.->|"ε"|eNFA8_7_47192740
eNFA8_5_10267631 -.->|"ε"|eNFA8_6_27037160
eNFA8_5_10267631 -.->|"ε"|eNFA8_12_30967009
eNFA8_5_10267631 -.->|"ε"|eNFA8_4_42526340
eNFA8_5_10267631 -.->|"ε"|eNFA8_8_42007851
eNFA8_5_10267631 -->|"[^*]"|eNFA8_5_10267631
eNFA8_5_10267631 -->|"[*]"|eNFA8_9_65300541
eNFA8_5_10267631 -->|"*"|eNFA8_13_54852443
eNFA8_9_65300541 -.->|"ε"|eNFA8_10_50833958
eNFA8_9_65300541 -->|"[^/]"|eNFA8_11_31902563
eNFA8_12_30967009 -->|"*"|eNFA8_13_54852443
eNFA8_13_54852443 -.->|"ε"|eNFA8_14_60081642
eNFA8_13_54852443 -->|"/
ExtendToken 'blockComment'"|eNFA8_15_53131231
eNFA9_4_22081476 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA9_4_22081476
eNFA9_4_22081476 -.->|"ε
ExtendToken 'inlineComment'"|eNFA9_6_43769104
eNFA9_4_22081476 -.->|"ε"|eNFA9_7_30567910
eNFA9_4_22081476 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA9_8_55740512
eNFA9_4_22081476 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_25692540
eNFA9_6_43769104 -.->|"ε"|eNFA9_7_30567910
eNFA9_6_43769104 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA9_8_55740512
eNFA9_6_43769104 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_25692540
eNFA9_7_30567910 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA9_8_55740512
eNFA9_7_30567910 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_25692540
eNFA9_8_55740512 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_25692540
eNFA8_10_50833958 -->|"[^/]"|eNFA8_11_31902563
eNFA8_11_31902563 -.->|"ε"|eNFA8_7_47192740
eNFA8_11_31902563 -.->|"ε"|eNFA8_6_27037160
eNFA8_11_31902563 -.->|"ε"|eNFA8_12_30967009
eNFA8_11_31902563 -.->|"ε"|eNFA8_4_42526340
eNFA8_11_31902563 -.->|"ε"|eNFA8_8_42007851
eNFA8_11_31902563 -->|"[^*]"|eNFA8_5_10267631
eNFA8_11_31902563 -->|"[*]"|eNFA8_9_65300541
eNFA8_11_31902563 -->|"*"|eNFA8_13_54852443
eNFA8_14_60081642 -->|"/
ExtendToken 'blockComment'"|eNFA8_15_53131231
eNFA8_15_53131231 -.->|"ε
ExtendToken 'blockComment'"|eNFA8_17_8419032
eNFA8_15_53131231 -.->|"ε"|eNFA8_18_8662426
eNFA8_15_53131231 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA8_19_18687619
eNFA8_15_53131231 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_25692540
eNFA8_17_8419032 -.->|"ε"|eNFA8_18_8662426
eNFA8_17_8419032 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA8_19_18687619
eNFA8_17_8419032 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_25692540
eNFA8_18_8662426 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA8_19_18687619
eNFA8_18_8662426 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_25692540
eNFA8_19_18687619 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_25692540
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
NFA0_0_13862865("NFA0-0 wholeStart")
class NFA0_0_13862865 c1000;
NFA1_1_23909939[\"NFA1-1 scope[1]
AcceptToken 'number'"/]
class NFA1_1_23909939 c0101;
NFA2_1_57656925[\"NFA2-1 char[1]
AcceptToken '+'"/]
class NFA2_1_57656925 c0101;
NFA3_1_49150280[\"NFA3-1 char[1]
AcceptToken '-'"/]
class NFA3_1_49150280 c0101;
NFA4_1_39699339[\"NFA4-1 char[1]
AcceptToken '*'"/]
class NFA4_1_39699339 c0101;
NFA5_1_21749735[\"NFA5-1 char[1]
AcceptToken '/'"/]
class NFA5_1_21749735 c0101;
NFA6_1_61529894[\"NFA6-1 char[1]
AcceptToken '('"/]
class NFA6_1_61529894 c0101;
NFA7_1_16898135[\"NFA7-1 char[1]
AcceptToken ')'"/]
class NFA7_1_16898135 c0101;
NFA8_1_17865493("NFA8-1 char[1]")
NFA9_1_26571712("NFA9-1 char[1]")
NFA8_3_4825033("NFA8-3 char[1]")
NFA9_3_37818817[\"NFA9-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA9_3_37818817 c0101;
NFA8_5_55283354("NFA8-5 scope[1]")
NFA8_9_43425297("NFA8-9 scope[1]")
NFA8_13_27788141("NFA8-13 char[1]")
NFA9_4_48766684[\"NFA9-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA9_4_48766684 c0101;
NFA8_11_57787318("NFA8-11 scope[1]")
NFA8_15_36246974[\"NFA8-15 char[1]
AcceptToken 'blockComment'"/]
class NFA8_15_36246974 c0101;
NFA0_0_13862865 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|NFA1_1_23909939
NFA0_0_13862865 -->|"+
BeginToken '+'
ExtendToken '+'"|NFA2_1_57656925
NFA0_0_13862865 -->|"-
BeginToken '-'
ExtendToken '-'"|NFA3_1_49150280
NFA0_0_13862865 -->|"*
BeginToken '*'
ExtendToken '*'"|NFA4_1_39699339
NFA0_0_13862865 -->|"/
BeginToken '/'
ExtendToken '/'"|NFA5_1_21749735
NFA0_0_13862865 -->|"(
BeginToken '('
ExtendToken '('"|NFA6_1_61529894
NFA0_0_13862865 -->|")
BeginToken ')'
ExtendToken ')'"|NFA7_1_16898135
NFA0_0_13862865 -->|"/
BeginToken 'blockComment'"|NFA8_1_17865493
NFA0_0_13862865 -->|"/
BeginToken 'inlineComment'"|NFA9_1_26571712
NFA1_1_23909939 -->|"[0-9]
ExtendToken 'number'"|NFA1_1_23909939
NFA8_1_17865493 -->|"*"|NFA8_3_4825033
NFA9_1_26571712 -->|"/
ExtendToken 'inlineComment'"|NFA9_3_37818817
NFA8_3_4825033 -->|"[^*]"|NFA8_5_55283354
NFA8_3_4825033 -->|"[*]"|NFA8_9_43425297
NFA8_3_4825033 -->|"*"|NFA8_13_27788141
NFA9_3_37818817 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA9_4_48766684
NFA8_5_55283354 -->|"[^*]"|NFA8_5_55283354
NFA8_5_55283354 -->|"[*]"|NFA8_9_43425297
NFA8_5_55283354 -->|"*"|NFA8_13_27788141
NFA8_9_43425297 -->|"[^/]"|NFA8_11_57787318
NFA8_13_27788141 -->|"/
ExtendToken 'blockComment'"|NFA8_15_36246974
NFA9_4_48766684 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA9_4_48766684
NFA8_11_57787318 -->|"[^*]"|NFA8_5_55283354
NFA8_11_57787318 -->|"[*]"|NFA8_9_43425297
NFA8_11_57787318 -->|"*"|NFA8_13_27788141
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
subgraph DFA0_-466580192["DFA0 wholeStart"]
NFA0_0_13862865_0("NFA0-0 wholeStart")
class NFA0_0_13862865_0 c1000;
end
class DFA0_-466580192 c1000;
subgraph DFA1_-1093464317["DFA1 {1}"]
NFA1_1_23909939_1[\"NFA1-1 scope[1]
AcceptToken 'number'"/]
class NFA1_1_23909939_1 c0101;
end
class DFA1_-1093464317 c0101;
subgraph DFA2_946815801["DFA2 {1}"]
NFA2_1_57656925_2[\"NFA2-1 char[1]
AcceptToken '+'"/]
class NFA2_1_57656925_2 c0101;
end
class DFA2_946815801 c0101;
subgraph DFA3_-1934379784["DFA3 {1}"]
NFA3_1_49150280_3[\"NFA3-1 char[1]
AcceptToken '-'"/]
class NFA3_1_49150280_3 c0101;
end
class DFA3_-1934379784 c0101;
subgraph DFA4_344512846["DFA4 {1}"]
NFA4_1_39699339_4[\"NFA4-1 char[1]
AcceptToken '*'"/]
class NFA4_1_39699339_4 c0101;
end
class DFA4_344512846 c0101;
subgraph DFA5_-1207796552["DFA5 {3}"]
NFA5_1_21749735_5[\"NFA5-1 char[1]
AcceptToken '/'"/]
class NFA5_1_21749735_5 c0101;
NFA8_1_17865493_6("NFA8-1 char[1]")
NFA9_1_26571712_7("NFA9-1 char[1]")
end
class DFA5_-1207796552 c0101;
subgraph DFA6_-1232478392["DFA6 {1}"]
NFA6_1_61529894_8[\"NFA6-1 char[1]
AcceptToken '('"/]
class NFA6_1_61529894_8 c0101;
end
class DFA6_-1232478392 c0101;
subgraph DFA7_-1911608150["DFA7 {1}"]
NFA7_1_16898135_9[\"NFA7-1 char[1]
AcceptToken ')'"/]
class NFA7_1_16898135_9 c0101;
end
class DFA7_-1911608150 c0101;
subgraph DFA8_-2126796951["DFA8 {1}"]
NFA8_3_4825033_10("NFA8-3 char[1]")
end
subgraph DFA9_1544858617["DFA9 {1}"]
NFA9_3_37818817_11[\"NFA9-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA9_3_37818817_11 c0101;
end
class DFA9_1544858617 c0101;
subgraph DFA10_1709820913["DFA10 {1}"]
NFA8_5_55283354_12("NFA8-5 scope[1]")
end
subgraph DFA11_816023626["DFA11 {2}"]
NFA8_9_43425297_13("NFA8-9 scope[1]")
NFA8_13_27788141_14("NFA8-13 char[1]")
end
subgraph DFA12_1452258063["DFA12 {1}"]
NFA9_4_48766684_15[\"NFA9-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA9_4_48766684_15 c0101;
end
class DFA12_1452258063 c0101;
subgraph DFA13_546524016["DFA13 {1}"]
NFA8_11_57787318_16("NFA8-11 scope[1]")
end
subgraph DFA14_-1224855203["DFA14 {1}"]
NFA8_15_36246974_17[\"NFA8-15 char[1]
AcceptToken 'blockComment'"/]
class NFA8_15_36246974_17 c0101;
end
class DFA14_-1224855203 c0101;
DFA0_-466580192 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|DFA1_-1093464317
DFA0_-466580192 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA2_946815801
DFA0_-466580192 -->|"-
BeginToken '-'
ExtendToken '-'"|DFA3_-1934379784
DFA0_-466580192 -->|"*
BeginToken '*'
ExtendToken '*'"|DFA4_344512846
DFA0_-466580192 -->|"/
BeginToken '/''blockComment''inlineComment'
ExtendToken '/'"|DFA5_-1207796552
DFA0_-466580192 -->|"(
BeginToken '('
ExtendToken '('"|DFA6_-1232478392
DFA0_-466580192 -->|")
BeginToken ')'
ExtendToken ')'"|DFA7_-1911608150
DFA1_-1093464317 -->|"[0-9]
ExtendToken 'number'"|DFA1_-1093464317
DFA5_-1207796552 -->|"*"|DFA8_-2126796951
DFA5_-1207796552 -->|"/
ExtendToken 'inlineComment'"|DFA9_1544858617
DFA8_-2126796951 -->|"[^*]"|DFA10_1709820913
DFA8_-2126796951 -->|"*"|DFA11_816023626
DFA9_1544858617 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1452258063
DFA10_1709820913 -->|"[^*]"|DFA10_1709820913
DFA10_1709820913 -->|"*"|DFA11_816023626
DFA11_816023626 -->|"[^/]"|DFA13_546524016
DFA11_816023626 -->|"/
ExtendToken 'blockComment'"|DFA14_-1224855203
DFA12_1452258063 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1452258063
DFA13_546524016 -->|"[^*]"|DFA10_1709820913
DFA13_546524016 -->|"*"|DFA11_816023626
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
DFA0_-466580192{{"DFA0 wholeStart"}}
class DFA0_-466580192 c1000;
DFA1_-1093464317[\"DFA1 {1}
AcceptToken 'number'"/]
class DFA1_-1093464317 c0101;
DFA2_946815801[\"DFA2 {1}
AcceptToken '+'"/]
class DFA2_946815801 c0101;
DFA3_-1934379784[\"DFA3 {1}
AcceptToken '-'"/]
class DFA3_-1934379784 c0101;
DFA4_344512846[\"DFA4 {1}
AcceptToken '*'"/]
class DFA4_344512846 c0101;
DFA5_-1207796552[\"DFA5 {3}
AcceptToken '/'"/]
class DFA5_-1207796552 c0101;
DFA6_-1232478392[\"DFA6 {1}
AcceptToken '('"/]
class DFA6_-1232478392 c0101;
DFA7_-1911608150[\"DFA7 {1}
AcceptToken ')'"/]
class DFA7_-1911608150 c0101;
DFA8_-2126796951{{"DFA8 {1}"}}
DFA9_1544858617[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_1544858617 c0101;
DFA10_1709820913{{"DFA10 {1}"}}
DFA11_816023626{{"DFA11 {2}"}}
DFA12_1452258063[\"DFA12 {1}
AcceptToken 'inlineComment'"/]
class DFA12_1452258063 c0101;
DFA13_546524016{{"DFA13 {1}"}}
DFA14_-1224855203[\"DFA14 {1}
AcceptToken 'blockComment'"/]
class DFA14_-1224855203 c0101;
DFA0_-466580192 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|DFA1_-1093464317
DFA0_-466580192 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA2_946815801
DFA0_-466580192 -->|"-
BeginToken '-'
ExtendToken '-'"|DFA3_-1934379784
DFA0_-466580192 -->|"*
BeginToken '*'
ExtendToken '*'"|DFA4_344512846
DFA0_-466580192 -->|"/
BeginToken '/''blockComment''inlineComment'
ExtendToken '/'"|DFA5_-1207796552
DFA0_-466580192 -->|"(
BeginToken '('
ExtendToken '('"|DFA6_-1232478392
DFA0_-466580192 -->|")
BeginToken ')'
ExtendToken ')'"|DFA7_-1911608150
DFA1_-1093464317 -->|"[0-9]
ExtendToken 'number'"|DFA1_-1093464317
DFA5_-1207796552 -->|"*"|DFA8_-2126796951
DFA5_-1207796552 -->|"/
ExtendToken 'inlineComment'"|DFA9_1544858617
DFA8_-2126796951 -->|"[^*]"|DFA10_1709820913
DFA8_-2126796951 -->|"*"|DFA11_816023626
DFA9_1544858617 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1452258063
DFA10_1709820913 -->|"[^*]"|DFA10_1709820913
DFA10_1709820913 -->|"*"|DFA11_816023626
DFA11_816023626 -->|"[^/]"|DFA13_546524016
DFA11_816023626 -->|"/
ExtendToken 'blockComment'"|DFA14_-1224855203
DFA12_1452258063 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA12_1452258063
DFA13_546524016 -->|"[^*]"|DFA10_1709820913
DFA13_546524016 -->|"*"|DFA11_816023626
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
subgraph MiniDFA0_1938844696["MiniDFA0 {1}"]
DFA0_-466580192_0{{"DFA0 wholeStart"}}
class DFA0_-466580192_0 c1000;
end
class MiniDFA0_1938844696 c1000;
subgraph MiniDFA3_-536073564["MiniDFA3 {1}"]
DFA1_-1093464317_1[\"DFA1 {1}
AcceptToken 'number'"/]
class DFA1_-1093464317_1 c0101;
end
class MiniDFA3_-536073564 c0101;
subgraph MiniDFA4_-1334831830["MiniDFA4 {1}"]
DFA2_946815801_2[\"DFA2 {1}
AcceptToken '+'"/]
class DFA2_946815801_2 c0101;
end
class MiniDFA4_-1334831830 c0101;
subgraph MiniDFA5_935629358["MiniDFA5 {1}"]
DFA3_-1934379784_3[\"DFA3 {1}
AcceptToken '-'"/]
class DFA3_-1934379784_3 c0101;
end
class MiniDFA5_935629358 c0101;
subgraph MiniDFA6_-115108059["MiniDFA6 {1}"]
DFA4_344512846_4[\"DFA4 {1}
AcceptToken '*'"/]
class DFA4_344512846_4 c0101;
end
class MiniDFA6_-115108059 c0101;
subgraph MiniDFA7_264045022["MiniDFA7 {1}"]
DFA5_-1207796552_5[\"DFA5 {3}
AcceptToken '/'"/]
class DFA5_-1207796552_5 c0101;
end
class MiniDFA7_264045022 c0101;
subgraph MiniDFA8_2053636133["MiniDFA8 {1}"]
DFA6_-1232478392_6[\"DFA6 {1}
AcceptToken '('"/]
class DFA6_-1232478392_6 c0101;
end
class MiniDFA8_2053636133 c0101;
subgraph MiniDFA9_521877951["MiniDFA9 {1}"]
DFA7_-1911608150_7[\"DFA7 {1}
AcceptToken ')'"/]
class DFA7_-1911608150_7 c0101;
end
class MiniDFA9_521877951 c0101;
subgraph MiniDFA1_-1908093477["MiniDFA1 {3}"]
DFA8_-2126796951_8{{"DFA8 {1}"}}
DFA10_1709820913_9{{"DFA10 {1}"}}
DFA13_546524016_10{{"DFA13 {1}"}}
end
subgraph MiniDFA10_1096893112["MiniDFA10 {1}"]
DFA9_1544858617_11[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_1544858617_11 c0101;
end
class MiniDFA10_1096893112 c0101;
subgraph MiniDFA2_-1226756194["MiniDFA2 {1}"]
DFA11_816023626_12{{"DFA11 {2}"}}
end
subgraph MiniDFA11_-1136834600["MiniDFA11 {1}"]
DFA12_1452258063_13[\"DFA12 {1}
AcceptToken 'inlineComment'"/]
class DFA12_1452258063_13 c0101;
end
class MiniDFA11_-1136834600 c0101;
subgraph MiniDFA12_1170201576["MiniDFA12 {1}"]
DFA14_-1224855203_14[\"DFA14 {1}
AcceptToken 'blockComment'"/]
class DFA14_-1224855203_14 c0101;
end
class MiniDFA12_1170201576 c0101;
MiniDFA0_1938844696 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|MiniDFA3_-536073564
MiniDFA0_1938844696 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA4_-1334831830
MiniDFA0_1938844696 -->|"-
BeginToken '-'
ExtendToken '-'"|MiniDFA5_935629358
MiniDFA0_1938844696 -->|"*
BeginToken '*'
ExtendToken '*'"|MiniDFA6_-115108059
MiniDFA0_1938844696 -->|"/
BeginToken '/''blockComment''inlineComment'
ExtendToken '/'"|MiniDFA7_264045022
MiniDFA0_1938844696 -->|"(
BeginToken '('
ExtendToken '('"|MiniDFA8_2053636133
MiniDFA0_1938844696 -->|")
BeginToken ')'
ExtendToken ')'"|MiniDFA9_521877951
MiniDFA3_-536073564 -->|"[0-9]
ExtendToken 'number'"|MiniDFA3_-536073564
MiniDFA7_264045022 -->|"*"|MiniDFA1_-1908093477
MiniDFA7_264045022 -->|"/
ExtendToken 'inlineComment'"|MiniDFA10_1096893112
MiniDFA1_-1908093477 -->|"[^*]"|MiniDFA1_-1908093477
MiniDFA1_-1908093477 -->|"*"|MiniDFA2_-1226756194
MiniDFA10_1096893112 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-1136834600
MiniDFA2_-1226756194 -->|"[^/]"|MiniDFA1_-1908093477
MiniDFA2_-1226756194 -->|"/
ExtendToken 'blockComment'"|MiniDFA12_1170201576
MiniDFA11_-1136834600 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-1136834600
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
MiniDFA0_1938844696(["MiniDFA0 {1}"])
class MiniDFA0_1938844696 c1000;
MiniDFA3_-536073564[\"MiniDFA3 {1}
AcceptToken 'number'"/]
class MiniDFA3_-536073564 c0101;
MiniDFA4_-1334831830[\"MiniDFA4 {1}
AcceptToken '+'"/]
class MiniDFA4_-1334831830 c0101;
MiniDFA5_935629358[\"MiniDFA5 {1}
AcceptToken '-'"/]
class MiniDFA5_935629358 c0101;
MiniDFA6_-115108059[\"MiniDFA6 {1}
AcceptToken '*'"/]
class MiniDFA6_-115108059 c0101;
MiniDFA7_264045022[\"MiniDFA7 {1}
AcceptToken '/'"/]
class MiniDFA7_264045022 c0101;
MiniDFA8_2053636133[\"MiniDFA8 {1}
AcceptToken '('"/]
class MiniDFA8_2053636133 c0101;
MiniDFA9_521877951[\"MiniDFA9 {1}
AcceptToken ')'"/]
class MiniDFA9_521877951 c0101;
MiniDFA1_-1908093477(["MiniDFA1 {3}"])
MiniDFA10_1096893112[\"MiniDFA10 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA10_1096893112 c0101;
MiniDFA2_-1226756194(["MiniDFA2 {1}"])
MiniDFA11_-1136834600[\"MiniDFA11 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA11_-1136834600 c0101;
MiniDFA12_1170201576[\"MiniDFA12 {1}
AcceptToken 'blockComment'"/]
class MiniDFA12_1170201576 c0101;
MiniDFA0_1938844696 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|MiniDFA3_-536073564
MiniDFA0_1938844696 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA4_-1334831830
MiniDFA0_1938844696 -->|"-
BeginToken '-'
ExtendToken '-'"|MiniDFA5_935629358
MiniDFA0_1938844696 -->|"*
BeginToken '*'
ExtendToken '*'"|MiniDFA6_-115108059
MiniDFA0_1938844696 -->|"/
BeginToken '/''blockComment''inlineComment'
ExtendToken '/'"|MiniDFA7_264045022
MiniDFA0_1938844696 -->|"(
BeginToken '('
ExtendToken '('"|MiniDFA8_2053636133
MiniDFA0_1938844696 -->|")
BeginToken ')'
ExtendToken ')'"|MiniDFA9_521877951
MiniDFA3_-536073564 -->|"[0-9]
ExtendToken 'number'"|MiniDFA3_-536073564
MiniDFA7_264045022 -->|"*"|MiniDFA1_-1908093477
MiniDFA7_264045022 -->|"/
ExtendToken 'inlineComment'"|MiniDFA10_1096893112
MiniDFA1_-1908093477 -->|"[^*]"|MiniDFA1_-1908093477
MiniDFA1_-1908093477 -->|"*"|MiniDFA2_-1226756194
MiniDFA10_1096893112 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-1136834600
MiniDFA2_-1226756194 -->|"[^/]"|MiniDFA1_-1908093477
MiniDFA2_-1226756194 -->|"/
ExtendToken 'blockComment'"|MiniDFA12_1170201576
MiniDFA11_-1136834600 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA11_-1136834600
```
-------------------------------
