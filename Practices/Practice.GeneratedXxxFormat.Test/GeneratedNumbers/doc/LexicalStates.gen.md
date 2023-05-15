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
eNFA0_0_53720453[["εNFA0-0 wholeStart"]]
eNFA1_2_40261524[["εNFA1-2 regex start"]]
class eNFA1_2_40261524 c1000;
eNFA2_6_13722030[["εNFA2-6 regex start"]]
class eNFA2_6_13722030 c1000;
eNFA3_16_24183370[["εNFA3-16 regex start"]]
class eNFA3_16_24183370 c1000;
eNFA4_5_324668[["εNFA4-5 regex start"]]
class eNFA4_5_324668 c1000;
eNFA1_0_21209668[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_15374270[["εNFA2-0 scope{1, ∞}"]]
eNFA3_0_12695920[["εNFA3-0 char{1, 1}"]]
eNFA4_0_26298136[["εNFA4-0 char{1, 1}"]]
eNFA1_1_17269710[["εNFA1-1 scope[1]"]]
eNFA2_1_24077873[["εNFA2-1 scope[1]"]]
eNFA3_1_18826965[["εNFA3-1 char[1]"]]
eNFA4_1_35224963[["εNFA4-1 char[1]"]]
eNFA1_3_56669285[["εNFA1-3 regex end"]]
class eNFA1_3_56669285 c0100;
eNFA2_2_4150710[["εNFA2-2 char{1, 1}"]]
eNFA3_2_18974100[["εNFA3-2 char{1, 1}"]]
eNFA4_2_36549175[["εNFA4-2 char{1, 1}"]]
eNFA1_4_26809401[["εNFA1-4 post-regex start"]]
class eNFA1_4_26809401 c0010;
eNFA2_3_60507121[["εNFA2-3 char[1]"]]
eNFA3_3_7378398[["εNFA3-3 char[1]"]]
eNFA4_3_8289053[["εNFA4-3 char[1]"]]
eNFA1_5_39958021[\"εNFA1-5 post-regex end"/]
class eNFA1_5_39958021 c0001;
eNFA2_4_663215[["εNFA2-4 scope{1, ∞}"]]
eNFA3_6_37253141[["εNFA3-6 regex start"]]
eNFA4_4_15834086[["εNFA4-4 char{0, ∞}"]]
eNFA0_1_37742617[\"εNFA0-1 wholeEnd"/]
eNFA2_5_37356392[["εNFA2-5 scope[1]"]]
eNFA3_4_64714441[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_66842817[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_45559064[["εNFA3-7 regex end"]]
eNFA4_6_7492614[["εNFA4-6 regex end"]]
class eNFA4_6_7492614 c0100;
eNFA2_7_5968939[["εNFA2-7 regex end"]]
class eNFA2_7_5968939 c0100;
eNFA3_5_60779388[["εNFA3-5 scope[1]"]]
eNFA3_9_61695723[["εNFA3-9 scope[1]"]]
eNFA3_12_66405588[["εNFA3-12 char{1, 1}"]]
eNFA4_7_35356632[["εNFA4-7 post-regex start"]]
class eNFA4_7_35356632 c0010;
eNFA2_8_4139237[["εNFA2-8 post-regex start"]]
class eNFA2_8_4139237 c0010;
eNFA3_10_52084342[["εNFA3-10 scope{1, 1}"]]
eNFA3_13_66105898[["εNFA3-13 char[1]"]]
eNFA4_8_2922015[\"εNFA4-8 post-regex end"/]
class eNFA4_8_2922015 c0001;
eNFA2_9_56389407[\"εNFA2-9 post-regex end"/]
class eNFA2_9_56389407 c0001;
eNFA3_11_10143581[["εNFA3-11 scope[1]"]]
eNFA3_14_58082174[["εNFA3-14 char{1, 1}"]]
eNFA3_15_47154420[["εNFA3-15 char[1]"]]
eNFA3_17_21736599[["εNFA3-17 regex end"]]
class eNFA3_17_21736599 c0100;
eNFA3_18_61411666[["εNFA3-18 post-regex start"]]
class eNFA3_18_61411666 c0010;
eNFA3_19_16323738[\"εNFA3-19 post-regex end"/]
class eNFA3_19_16323738 c0001;
eNFA0_0_53720453 -.->|"ε"|eNFA1_2_40261524
eNFA0_0_53720453 -.->|"ε"|eNFA2_6_13722030
eNFA0_0_53720453 -.->|"ε"|eNFA3_16_24183370
eNFA0_0_53720453 -.->|"ε"|eNFA4_5_324668
eNFA1_2_40261524 -.->|"ε
BeginToken 'integer'"|eNFA1_0_21209668
eNFA2_6_13722030 -.->|"ε
BeginToken 'float'"|eNFA2_0_15374270
eNFA3_16_24183370 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_12695920
eNFA4_5_324668 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_26298136
eNFA1_0_21209668 -->|"[0-9]"|eNFA1_1_17269710
eNFA2_0_15374270 -->|"[0-9]"|eNFA2_1_24077873
eNFA3_0_12695920 -->|"/"|eNFA3_1_18826965
eNFA4_0_26298136 -->|"/"|eNFA4_1_35224963
eNFA1_1_17269710 -->|"[0-9]"|eNFA1_1_17269710
eNFA1_1_17269710 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_56669285
eNFA2_1_24077873 -->|"[0-9]"|eNFA2_1_24077873
eNFA2_1_24077873 -.->|"ε"|eNFA2_2_4150710
eNFA3_1_18826965 -.->|"ε"|eNFA3_2_18974100
eNFA4_1_35224963 -.->|"ε"|eNFA4_2_36549175
eNFA1_3_56669285 -.->|"ε"|eNFA1_4_26809401
eNFA2_2_4150710 -->|"."|eNFA2_3_60507121
eNFA3_2_18974100 -->|"*"|eNFA3_3_7378398
eNFA4_2_36549175 -->|"/"|eNFA4_3_8289053
eNFA1_4_26809401 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_39958021
eNFA2_3_60507121 -.->|"ε"|eNFA2_4_663215
eNFA3_3_7378398 -.->|"ε"|eNFA3_6_37253141
eNFA4_3_8289053 -.->|"ε"|eNFA4_4_15834086
eNFA1_5_39958021 -.->|"ε"|eNFA0_1_37742617
eNFA2_4_663215 -->|"[0-9]"|eNFA2_5_37356392
eNFA3_6_37253141 -.->|"ε"|eNFA3_4_64714441
eNFA3_6_37253141 -.->|"ε"|eNFA3_8_66842817
eNFA3_6_37253141 -.->|"ε"|eNFA3_7_45559064
eNFA4_4_15834086 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_15834086
eNFA4_4_15834086 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_7492614
eNFA2_5_37356392 -->|"[0-9]"|eNFA2_5_37356392
eNFA2_5_37356392 -.->|"ε
ExtendToken 'float'"|eNFA2_7_5968939
eNFA3_4_64714441 -->|"[^*]"|eNFA3_5_60779388
eNFA3_8_66842817 -->|"[*]"|eNFA3_9_61695723
eNFA3_7_45559064 -.->|"ε"|eNFA3_6_37253141
eNFA3_7_45559064 -.->|"ε"|eNFA3_12_66405588
eNFA4_6_7492614 -.->|"ε"|eNFA4_7_35356632
eNFA2_7_5968939 -.->|"ε"|eNFA2_8_4139237
eNFA3_5_60779388 -.->|"ε"|eNFA3_7_45559064
eNFA3_9_61695723 -.->|"ε"|eNFA3_10_52084342
eNFA3_12_66405588 -->|"*"|eNFA3_13_66105898
eNFA4_7_35356632 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_2922015
eNFA2_8_4139237 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_56389407
eNFA3_10_52084342 -->|"[^/]"|eNFA3_11_10143581
eNFA3_13_66105898 -.->|"ε"|eNFA3_14_58082174
eNFA4_8_2922015 -.->|"ε"|eNFA0_1_37742617
eNFA2_9_56389407 -.->|"ε"|eNFA0_1_37742617
eNFA3_11_10143581 -.->|"ε"|eNFA3_7_45559064
eNFA3_14_58082174 -->|"/"|eNFA3_15_47154420
eNFA3_15_47154420 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_21736599
eNFA3_17_21736599 -.->|"ε"|eNFA3_18_61411666
eNFA3_18_61411666 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_16323738
eNFA3_19_16323738 -.->|"ε"|eNFA0_1_37742617
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
eNFA0_0_49774232[["εNFA0-0 wholeStart"]]
class eNFA0_0_49774232 c1000;
eNFA1_2_5180964[["εNFA1-2 regex start"]]
class eNFA1_2_5180964 c1000;
eNFA2_6_45314905[["εNFA2-6 regex start"]]
class eNFA2_6_45314905 c1000;
eNFA3_16_46628683[["εNFA3-16 regex start"]]
class eNFA3_16_46628683 c1000;
eNFA4_5_17004965[["εNFA4-5 regex start"]]
class eNFA4_5_17004965 c1000;
eNFA1_0_34649765[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_34649765 c1000;
eNFA2_0_26746391[["εNFA2-0 scope{1, ∞}"]]
class eNFA2_0_26746391 c1000;
eNFA3_0_41459726[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_41459726 c1000;
eNFA4_0_25040094[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_25040094 c1000;
eNFA1_1_48589216[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_48589216 c0111;
eNFA2_1_55167604[["εNFA2-1 scope[1]"]]
eNFA3_1_14981763[["εNFA3-1 char[1]"]]
eNFA4_1_5563313[["εNFA4-1 char[1]"]]
eNFA1_3_43412436[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_43412436 c0111;
eNFA1_4_45251091[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_45251091 c0011;
eNFA1_5_63321005[\"εNFA1-5 post-regex end"/]
class eNFA1_5_63321005 c0011;
eNFA0_1_7035667[\"εNFA0-1 wholeEnd"/]
eNFA2_2_39390935[["εNFA2-2 char{1, 1}"]]
eNFA2_3_29123463[["εNFA2-3 char[1]"]]
eNFA3_2_47975183[["εNFA3-2 char{1, 1}"]]
eNFA3_3_18390601[["εNFA3-3 char[1]"]]
eNFA4_2_50069818[["εNFA4-2 char{1, 1}"]]
eNFA4_3_14650458[\"εNFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA4_3_14650458 c0111;
eNFA2_4_9875225[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_45836489[\"εNFA2-5 scope[1]
AcceptToken 'float'"/]
class eNFA2_5_45836489 c0111;
eNFA3_6_7693179[["εNFA3-6 regex start"]]
eNFA3_4_19167756[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_2129750[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_38292076[["εNFA3-7 regex end"]]
eNFA3_5_13243689[["εNFA3-5 scope[1]"]]
eNFA3_9_60784581[["εNFA3-9 scope[1]"]]
eNFA3_12_31297682[["εNFA3-12 char{1, 1}"]]
eNFA3_13_24604028[["εNFA3-13 char[1]"]]
eNFA4_4_9084369[\"εNFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA4_4_9084369 c0111;
eNFA4_6_64745266[\"εNFA4-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA4_6_64745266 c0111;
eNFA4_7_24034261[\"εNFA4-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA4_7_24034261 c0011;
eNFA4_8_52977523[\"εNFA4-8 post-regex end"/]
class eNFA4_8_52977523 c0011;
eNFA2_7_21768161[\"εNFA2-7 regex end
AcceptToken 'float'"/]
class eNFA2_7_21768161 c0111;
eNFA2_8_4606636[\"εNFA2-8 post-regex start
AcceptToken 'float'"/]
class eNFA2_8_4606636 c0011;
eNFA2_9_33018140[\"εNFA2-9 post-regex end"/]
class eNFA2_9_33018140 c0011;
eNFA3_10_10190321[["εNFA3-10 scope{1, 1}"]]
eNFA3_11_28727808[["εNFA3-11 scope[1]"]]
eNFA3_14_618145[["εNFA3-14 char{1, 1}"]]
eNFA3_15_37593218[\"εNFA3-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA3_15_37593218 c0111;
eNFA3_17_2794650[\"εNFA3-17 regex end
AcceptToken 'blockComment'"/]
class eNFA3_17_2794650 c0111;
eNFA3_18_25151854[\"εNFA3-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA3_18_25151854 c0011;
eNFA3_19_57223682[\"εNFA3-19 post-regex end"/]
class eNFA3_19_57223682 c0011;
eNFA0_0_49774232 -.->|"ε"|eNFA1_2_5180964
eNFA0_0_49774232 -.->|"ε"|eNFA2_6_45314905
eNFA0_0_49774232 -.->|"ε"|eNFA3_16_46628683
eNFA0_0_49774232 -.->|"ε"|eNFA4_5_17004965
eNFA0_0_49774232 -.->|"ε
BeginToken 'integer'"|eNFA1_0_34649765
eNFA0_0_49774232 -.->|"ε
BeginToken 'float'"|eNFA2_0_26746391
eNFA0_0_49774232 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_41459726
eNFA0_0_49774232 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_25040094
eNFA0_0_49774232 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_48589216
eNFA0_0_49774232 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_55167604
eNFA0_0_49774232 -->|"/
BeginToken 'blockComment'"|eNFA3_1_14981763
eNFA0_0_49774232 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_5563313
eNFA1_2_5180964 -.->|"ε
BeginToken 'integer'"|eNFA1_0_34649765
eNFA1_2_5180964 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_48589216
eNFA2_6_45314905 -.->|"ε
BeginToken 'float'"|eNFA2_0_26746391
eNFA2_6_45314905 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_55167604
eNFA3_16_46628683 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_41459726
eNFA3_16_46628683 -->|"/
BeginToken 'blockComment'"|eNFA3_1_14981763
eNFA4_5_17004965 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_25040094
eNFA4_5_17004965 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_5563313
eNFA1_0_34649765 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_48589216
eNFA2_0_26746391 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_55167604
eNFA3_0_41459726 -->|"/
BeginToken 'blockComment'"|eNFA3_1_14981763
eNFA4_0_25040094 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_5563313
eNFA1_1_48589216 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_48589216
eNFA1_1_48589216 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_43412436
eNFA1_1_48589216 -.->|"ε"|eNFA1_4_45251091
eNFA1_1_48589216 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_63321005
eNFA1_1_48589216 -.->|"ε
CheckToken 'integer'"|eNFA0_1_7035667
eNFA2_1_55167604 -->|"[0-9]"|eNFA2_1_55167604
eNFA2_1_55167604 -.->|"ε"|eNFA2_2_39390935
eNFA2_1_55167604 -->|"."|eNFA2_3_29123463
eNFA3_1_14981763 -.->|"ε"|eNFA3_2_47975183
eNFA3_1_14981763 -->|"*"|eNFA3_3_18390601
eNFA4_1_5563313 -.->|"ε"|eNFA4_2_50069818
eNFA4_1_5563313 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_14650458
eNFA1_3_43412436 -.->|"ε"|eNFA1_4_45251091
eNFA1_3_43412436 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_63321005
eNFA1_3_43412436 -.->|"ε
CheckToken 'integer'"|eNFA0_1_7035667
eNFA1_4_45251091 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_63321005
eNFA1_4_45251091 -.->|"ε
CheckToken 'integer'"|eNFA0_1_7035667
eNFA1_5_63321005 -.->|"ε
CheckToken 'integer'"|eNFA0_1_7035667
eNFA2_2_39390935 -->|"."|eNFA2_3_29123463
eNFA2_3_29123463 -.->|"ε"|eNFA2_4_9875225
eNFA2_3_29123463 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_45836489
eNFA3_2_47975183 -->|"*"|eNFA3_3_18390601
eNFA3_3_18390601 -.->|"ε"|eNFA3_6_7693179
eNFA3_3_18390601 -.->|"ε"|eNFA3_4_19167756
eNFA3_3_18390601 -.->|"ε"|eNFA3_8_2129750
eNFA3_3_18390601 -.->|"ε"|eNFA3_7_38292076
eNFA3_3_18390601 -->|"[^*]"|eNFA3_5_13243689
eNFA3_3_18390601 -->|"[*]"|eNFA3_9_60784581
eNFA3_3_18390601 -.->|"ε"|eNFA3_12_31297682
eNFA3_3_18390601 -->|"*"|eNFA3_13_24604028
eNFA4_2_50069818 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_14650458
eNFA4_3_14650458 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_4_9084369
eNFA4_3_14650458 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_9084369
eNFA4_3_14650458 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_64745266
eNFA4_3_14650458 -.->|"ε"|eNFA4_7_24034261
eNFA4_3_14650458 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_52977523
eNFA4_3_14650458 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_7035667
eNFA2_4_9875225 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_45836489
eNFA2_5_45836489 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_45836489
eNFA2_5_45836489 -.->|"ε
ExtendToken 'float'"|eNFA2_7_21768161
eNFA2_5_45836489 -.->|"ε"|eNFA2_8_4606636
eNFA2_5_45836489 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_33018140
eNFA2_5_45836489 -.->|"ε
CheckToken 'float'"|eNFA0_1_7035667
eNFA3_6_7693179 -.->|"ε"|eNFA3_4_19167756
eNFA3_6_7693179 -.->|"ε"|eNFA3_8_2129750
eNFA3_6_7693179 -.->|"ε"|eNFA3_7_38292076
eNFA3_6_7693179 -->|"[^*]"|eNFA3_5_13243689
eNFA3_6_7693179 -->|"[*]"|eNFA3_9_60784581
eNFA3_6_7693179 -.->|"ε"|eNFA3_6_7693179
eNFA3_6_7693179 -.->|"ε"|eNFA3_12_31297682
eNFA3_6_7693179 -->|"*"|eNFA3_13_24604028
eNFA3_4_19167756 -->|"[^*]"|eNFA3_5_13243689
eNFA3_8_2129750 -->|"[*]"|eNFA3_9_60784581
eNFA3_7_38292076 -.->|"ε"|eNFA3_6_7693179
eNFA3_7_38292076 -.->|"ε"|eNFA3_12_31297682
eNFA3_7_38292076 -.->|"ε"|eNFA3_4_19167756
eNFA3_7_38292076 -.->|"ε"|eNFA3_8_2129750
eNFA3_7_38292076 -.->|"ε"|eNFA3_7_38292076
eNFA3_7_38292076 -->|"[^*]"|eNFA3_5_13243689
eNFA3_7_38292076 -->|"[*]"|eNFA3_9_60784581
eNFA3_7_38292076 -->|"*"|eNFA3_13_24604028
eNFA3_5_13243689 -.->|"ε"|eNFA3_7_38292076
eNFA3_5_13243689 -.->|"ε"|eNFA3_6_7693179
eNFA3_5_13243689 -.->|"ε"|eNFA3_12_31297682
eNFA3_5_13243689 -.->|"ε"|eNFA3_4_19167756
eNFA3_5_13243689 -.->|"ε"|eNFA3_8_2129750
eNFA3_5_13243689 -->|"[^*]"|eNFA3_5_13243689
eNFA3_5_13243689 -->|"[*]"|eNFA3_9_60784581
eNFA3_5_13243689 -->|"*"|eNFA3_13_24604028
eNFA3_9_60784581 -.->|"ε"|eNFA3_10_10190321
eNFA3_9_60784581 -->|"[^/]"|eNFA3_11_28727808
eNFA3_12_31297682 -->|"*"|eNFA3_13_24604028
eNFA3_13_24604028 -.->|"ε"|eNFA3_14_618145
eNFA3_13_24604028 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_37593218
eNFA4_4_9084369 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_9084369
eNFA4_4_9084369 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_64745266
eNFA4_4_9084369 -.->|"ε"|eNFA4_7_24034261
eNFA4_4_9084369 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_52977523
eNFA4_4_9084369 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_7035667
eNFA4_6_64745266 -.->|"ε"|eNFA4_7_24034261
eNFA4_6_64745266 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_52977523
eNFA4_6_64745266 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_7035667
eNFA4_7_24034261 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_52977523
eNFA4_7_24034261 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_7035667
eNFA4_8_52977523 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_7035667
eNFA2_7_21768161 -.->|"ε"|eNFA2_8_4606636
eNFA2_7_21768161 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_33018140
eNFA2_7_21768161 -.->|"ε
CheckToken 'float'"|eNFA0_1_7035667
eNFA2_8_4606636 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_33018140
eNFA2_8_4606636 -.->|"ε
CheckToken 'float'"|eNFA0_1_7035667
eNFA2_9_33018140 -.->|"ε
CheckToken 'float'"|eNFA0_1_7035667
eNFA3_10_10190321 -->|"[^/]"|eNFA3_11_28727808
eNFA3_11_28727808 -.->|"ε"|eNFA3_7_38292076
eNFA3_11_28727808 -.->|"ε"|eNFA3_6_7693179
eNFA3_11_28727808 -.->|"ε"|eNFA3_12_31297682
eNFA3_11_28727808 -.->|"ε"|eNFA3_4_19167756
eNFA3_11_28727808 -.->|"ε"|eNFA3_8_2129750
eNFA3_11_28727808 -->|"[^*]"|eNFA3_5_13243689
eNFA3_11_28727808 -->|"[*]"|eNFA3_9_60784581
eNFA3_11_28727808 -->|"*"|eNFA3_13_24604028
eNFA3_14_618145 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_37593218
eNFA3_15_37593218 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_2794650
eNFA3_15_37593218 -.->|"ε"|eNFA3_18_25151854
eNFA3_15_37593218 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_57223682
eNFA3_15_37593218 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_7035667
eNFA3_17_2794650 -.->|"ε"|eNFA3_18_25151854
eNFA3_17_2794650 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_57223682
eNFA3_17_2794650 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_7035667
eNFA3_18_25151854 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_57223682
eNFA3_18_25151854 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_7035667
eNFA3_19_57223682 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_7035667
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
NFA0_0_46769243("NFA0-0 wholeStart")
class NFA0_0_46769243 c1000;
NFA1_1_20109663[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_20109663 c0101;
NFA2_1_18270010("NFA2-1 scope[1]")
NFA3_1_30212363("NFA3-1 char[1]")
NFA4_1_3475817("NFA4-1 char[1]")
NFA2_3_31282356("NFA2-3 char[1]")
NFA3_3_54932709("NFA3-3 char[1]")
NFA4_3_13105749[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_13105749 c0101;
NFA2_5_50842877[\"NFA2-5 scope[1]
AcceptToken 'float'"/]
class NFA2_5_50842877 c0101;
NFA3_5_20364417("NFA3-5 scope[1]")
NFA3_9_24632334("NFA3-9 scope[1]")
NFA3_13_49062032("NFA3-13 char[1]")
NFA4_4_38905106[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_38905106 c0101;
NFA3_11_64305920("NFA3-11 scope[1]")
NFA3_15_14601642[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_14601642 c0101;
NFA0_0_46769243 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_20109663
NFA0_0_46769243 -->|"[0-9]
BeginToken 'float'"|NFA2_1_18270010
NFA0_0_46769243 -->|"/
BeginToken 'blockComment'"|NFA3_1_30212363
NFA0_0_46769243 -->|"/
BeginToken 'inlineComment'"|NFA4_1_3475817
NFA1_1_20109663 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_20109663
NFA2_1_18270010 -->|"[0-9]"|NFA2_1_18270010
NFA2_1_18270010 -->|"."|NFA2_3_31282356
NFA3_1_30212363 -->|"*"|NFA3_3_54932709
NFA4_1_3475817 -->|"/
ExtendToken 'inlineComment'"|NFA4_3_13105749
NFA2_3_31282356 -->|"[0-9]
ExtendToken 'float'"|NFA2_5_50842877
NFA3_3_54932709 -->|"[^*]"|NFA3_5_20364417
NFA3_3_54932709 -->|"[*]"|NFA3_9_24632334
NFA3_3_54932709 -->|"*"|NFA3_13_49062032
NFA4_3_13105749 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_38905106
NFA2_5_50842877 -->|"[0-9]
ExtendToken 'float'"|NFA2_5_50842877
NFA3_5_20364417 -->|"[^*]"|NFA3_5_20364417
NFA3_5_20364417 -->|"[*]"|NFA3_9_24632334
NFA3_5_20364417 -->|"*"|NFA3_13_49062032
NFA3_9_24632334 -->|"[^/]"|NFA3_11_64305920
NFA3_13_49062032 -->|"/
ExtendToken 'blockComment'"|NFA3_15_14601642
NFA4_4_38905106 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_38905106
NFA3_11_64305920 -->|"[^*]"|NFA3_5_20364417
NFA3_11_64305920 -->|"[*]"|NFA3_9_24632334
NFA3_11_64305920 -->|"*"|NFA3_13_49062032
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
subgraph DFA0_-771602367["DFA0 wholeStart"]
NFA0_0_46769243_0("NFA0-0 wholeStart")
class NFA0_0_46769243_0 c1000;
end
class DFA0_-771602367 c1000;
subgraph DFA1_-1280135935["DFA1 {2}"]
NFA1_1_20109663_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_20109663_1 c0101;
NFA2_1_18270010_2("NFA2-1 scope[1]")
end
class DFA1_-1280135935 c0101;
subgraph DFA2_1441873589["DFA2 {2}"]
NFA3_1_30212363_3("NFA3-1 char[1]")
NFA4_1_3475817_4("NFA4-1 char[1]")
end
subgraph DFA3_816773074["DFA3 {1}"]
NFA2_3_31282356_5("NFA2-3 char[1]")
end
subgraph DFA4_2093590239["DFA4 {1}"]
NFA3_3_54932709_6("NFA3-3 char[1]")
end
subgraph DFA5_648968295["DFA5 {1}"]
NFA4_3_13105749_7[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_13105749_7 c0101;
end
class DFA5_648968295 c0101;
subgraph DFA6_1463751463["DFA6 {1}"]
NFA2_5_50842877_8[\"NFA2-5 scope[1]
AcceptToken 'float'"/]
class NFA2_5_50842877_8 c0101;
end
class DFA6_1463751463 c0101;
subgraph DFA7_-664238604["DFA7 {1}"]
NFA3_5_20364417_9("NFA3-5 scope[1]")
end
subgraph DFA8_-1012450386["DFA8 {2}"]
NFA3_9_24632334_10("NFA3-9 scope[1]")
NFA3_13_49062032_11("NFA3-13 char[1]")
end
subgraph DFA9_-1308847123["DFA9 {1}"]
NFA4_4_38905106_12[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_38905106_12 c0101;
end
class DFA9_-1308847123 c0101;
subgraph DFA10_155505367["DFA10 {1}"]
NFA3_11_64305920_13("NFA3-11 scope[1]")
end
subgraph DFA11_-175018733["DFA11 {1}"]
NFA3_15_14601642_14[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_14601642_14 c0101;
end
class DFA11_-175018733 c0101;
DFA0_-771602367 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|DFA1_-1280135935
DFA0_-771602367 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_1441873589
DFA1_-1280135935 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1280135935
DFA1_-1280135935 -->|"."|DFA3_816773074
DFA2_1441873589 -->|"*"|DFA4_2093590239
DFA2_1441873589 -->|"/
ExtendToken 'inlineComment'"|DFA5_648968295
DFA3_816773074 -->|"[0-9]
ExtendToken 'float'"|DFA6_1463751463
DFA4_2093590239 -->|"[^*]"|DFA7_-664238604
DFA4_2093590239 -->|"*"|DFA8_-1012450386
DFA5_648968295 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1308847123
DFA6_1463751463 -->|"[0-9]
ExtendToken 'float'"|DFA6_1463751463
DFA7_-664238604 -->|"[^*]"|DFA7_-664238604
DFA7_-664238604 -->|"*"|DFA8_-1012450386
DFA8_-1012450386 -->|"[^/]"|DFA10_155505367
DFA8_-1012450386 -->|"/
ExtendToken 'blockComment'"|DFA11_-175018733
DFA9_-1308847123 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1308847123
DFA10_155505367 -->|"[^*]"|DFA7_-664238604
DFA10_155505367 -->|"*"|DFA8_-1012450386
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
DFA0_-771602367{{"DFA0 wholeStart"}}
class DFA0_-771602367 c1000;
DFA1_-1280135935[\"DFA1 {2}
AcceptToken 'integer'"/]
class DFA1_-1280135935 c0101;
DFA2_1441873589{{"DFA2 {2}"}}
DFA3_816773074{{"DFA3 {1}"}}
DFA4_2093590239{{"DFA4 {1}"}}
DFA5_648968295[\"DFA5 {1}
AcceptToken 'inlineComment'"/]
class DFA5_648968295 c0101;
DFA6_1463751463[\"DFA6 {1}
AcceptToken 'float'"/]
class DFA6_1463751463 c0101;
DFA7_-664238604{{"DFA7 {1}"}}
DFA8_-1012450386{{"DFA8 {2}"}}
DFA9_-1308847123[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1308847123 c0101;
DFA10_155505367{{"DFA10 {1}"}}
DFA11_-175018733[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_-175018733 c0101;
DFA0_-771602367 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|DFA1_-1280135935
DFA0_-771602367 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_1441873589
DFA1_-1280135935 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1280135935
DFA1_-1280135935 -->|"."|DFA3_816773074
DFA2_1441873589 -->|"*"|DFA4_2093590239
DFA2_1441873589 -->|"/
ExtendToken 'inlineComment'"|DFA5_648968295
DFA3_816773074 -->|"[0-9]
ExtendToken 'float'"|DFA6_1463751463
DFA4_2093590239 -->|"[^*]"|DFA7_-664238604
DFA4_2093590239 -->|"*"|DFA8_-1012450386
DFA5_648968295 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1308847123
DFA6_1463751463 -->|"[0-9]
ExtendToken 'float'"|DFA6_1463751463
DFA7_-664238604 -->|"[^*]"|DFA7_-664238604
DFA7_-664238604 -->|"*"|DFA8_-1012450386
DFA8_-1012450386 -->|"[^/]"|DFA10_155505367
DFA8_-1012450386 -->|"/
ExtendToken 'blockComment'"|DFA11_-175018733
DFA9_-1308847123 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1308847123
DFA10_155505367 -->|"[^*]"|DFA7_-664238604
DFA10_155505367 -->|"*"|DFA8_-1012450386
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
subgraph MiniDFA0_-525307974["MiniDFA0 {1}"]
DFA0_-771602367_0{{"DFA0 wholeStart"}}
class DFA0_-771602367_0 c1000;
end
class MiniDFA0_-525307974 c1000;
subgraph MiniDFA5_-1569637513["MiniDFA5 {1}"]
DFA1_-1280135935_1[\"DFA1 {2}
AcceptToken 'integer'"/]
class DFA1_-1280135935_1 c0101;
end
class MiniDFA5_-1569637513 c0101;
subgraph MiniDFA1_-1850694947["MiniDFA1 {1}"]
DFA2_1441873589_2{{"DFA2 {2}"}}
end
subgraph MiniDFA2_-1722998101["MiniDFA2 {1}"]
DFA3_816773074_3{{"DFA3 {1}"}}
end
subgraph MiniDFA3_-1677745688["MiniDFA3 {3}"]
DFA4_2093590239_4{{"DFA4 {1}"}}
DFA7_-664238604_5{{"DFA7 {1}"}}
DFA10_155505367_6{{"DFA10 {1}"}}
end
subgraph MiniDFA6_-9237331["MiniDFA6 {1}"]
DFA5_648968295_7[\"DFA5 {1}
AcceptToken 'inlineComment'"/]
class DFA5_648968295_7 c0101;
end
class MiniDFA6_-9237331 c0101;
subgraph MiniDFA7_-2114836410["MiniDFA7 {1}"]
DFA6_1463751463_8[\"DFA6 {1}
AcceptToken 'float'"/]
class DFA6_1463751463_8 c0101;
end
class MiniDFA7_-2114836410 c0101;
subgraph MiniDFA4_758297002["MiniDFA4 {1}"]
DFA8_-1012450386_9{{"DFA8 {2}"}}
end
subgraph MiniDFA8_1937419997["MiniDFA8 {1}"]
DFA9_-1308847123_10[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1308847123_10 c0101;
end
class MiniDFA8_1937419997 c0101;
subgraph MiniDFA9_-2008467491["MiniDFA9 {1}"]
DFA11_-175018733_11[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_-175018733_11 c0101;
end
class MiniDFA9_-2008467491 c0101;
MiniDFA0_-525307974 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|MiniDFA5_-1569637513
MiniDFA0_-525307974 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1850694947
MiniDFA5_-1569637513 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA5_-1569637513
MiniDFA5_-1569637513 -->|"."|MiniDFA2_-1722998101
MiniDFA1_-1850694947 -->|"*"|MiniDFA3_-1677745688
MiniDFA1_-1850694947 -->|"/
ExtendToken 'inlineComment'"|MiniDFA6_-9237331
MiniDFA2_-1722998101 -->|"[0-9]
ExtendToken 'float'"|MiniDFA7_-2114836410
MiniDFA3_-1677745688 -->|"[^*]"|MiniDFA3_-1677745688
MiniDFA3_-1677745688 -->|"*"|MiniDFA4_758297002
MiniDFA6_-9237331 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_1937419997
MiniDFA7_-2114836410 -->|"[0-9]
ExtendToken 'float'"|MiniDFA7_-2114836410
MiniDFA4_758297002 -->|"[^/]"|MiniDFA3_-1677745688
MiniDFA4_758297002 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_-2008467491
MiniDFA8_1937419997 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_1937419997
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
MiniDFA0_-525307974(["MiniDFA0 {1}"])
class MiniDFA0_-525307974 c1000;
MiniDFA5_-1569637513[\"MiniDFA5 {1}
AcceptToken 'integer'"/]
class MiniDFA5_-1569637513 c0101;
MiniDFA1_-1850694947(["MiniDFA1 {1}"])
MiniDFA2_-1722998101(["MiniDFA2 {1}"])
MiniDFA3_-1677745688(["MiniDFA3 {3}"])
MiniDFA6_-9237331[\"MiniDFA6 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA6_-9237331 c0101;
MiniDFA7_-2114836410[\"MiniDFA7 {1}
AcceptToken 'float'"/]
class MiniDFA7_-2114836410 c0101;
MiniDFA4_758297002(["MiniDFA4 {1}"])
MiniDFA8_1937419997[\"MiniDFA8 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA8_1937419997 c0101;
MiniDFA9_-2008467491[\"MiniDFA9 {1}
AcceptToken 'blockComment'"/]
class MiniDFA9_-2008467491 c0101;
MiniDFA0_-525307974 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|MiniDFA5_-1569637513
MiniDFA0_-525307974 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1850694947
MiniDFA5_-1569637513 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA5_-1569637513
MiniDFA5_-1569637513 -->|"."|MiniDFA2_-1722998101
MiniDFA1_-1850694947 -->|"*"|MiniDFA3_-1677745688
MiniDFA1_-1850694947 -->|"/
ExtendToken 'inlineComment'"|MiniDFA6_-9237331
MiniDFA2_-1722998101 -->|"[0-9]
ExtendToken 'float'"|MiniDFA7_-2114836410
MiniDFA3_-1677745688 -->|"[^*]"|MiniDFA3_-1677745688
MiniDFA3_-1677745688 -->|"*"|MiniDFA4_758297002
MiniDFA6_-9237331 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_1937419997
MiniDFA7_-2114836410 -->|"[0-9]
ExtendToken 'float'"|MiniDFA7_-2114836410
MiniDFA4_758297002 -->|"[^/]"|MiniDFA3_-1677745688
MiniDFA4_758297002 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_-2008467491
MiniDFA8_1937419997 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_1937419997
```
-------------------------------
