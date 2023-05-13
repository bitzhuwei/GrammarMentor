# 'medium_precision'

pattern: `medium_precision`

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
eNFA194_32_53956341[["εNFA194-32 regex start"]]
eNFA194_0_15845023[["εNFA194-0 char{1, 1}"]]
eNFA194_1_8387487[["εNFA194-1 char[1]"]]
eNFA194_2_8378525[["εNFA194-2 char{1, 1}"]]
eNFA194_3_8297866[["εNFA194-3 char[1]"]]
eNFA194_4_7571935[["εNFA194-4 char{1, 1}"]]
eNFA194_5_1038558[["εNFA194-5 char[1]"]]
eNFA194_6_9347022[["εNFA194-6 char{1, 1}"]]
eNFA194_7_17014337[["εNFA194-7 char[1]"]]
eNFA194_8_18911313[["εNFA194-8 char{1, 1}"]]
eNFA194_9_35984094[["εNFA194-9 char[1]"]]
eNFA194_10_55421393[["εNFA194-10 char{1, 1}"]]
eNFA194_11_29030491[["εNFA194-11 char[1]"]]
eNFA194_12_59947829[["εNFA194-12 char{1, 1}"]]
eNFA194_13_2659552[["εNFA194-13 char[1]"]]
eNFA194_14_23935974[["εNFA194-14 char{1, 1}"]]
eNFA194_15_14097174[["εNFA194-15 char[1]"]]
eNFA194_16_59765707[["εNFA194-16 char{1, 1}"]]
eNFA194_17_1020452[["εNFA194-17 char[1]"]]
eNFA194_18_9184076[["εNFA194-18 char{1, 1}"]]
eNFA194_19_15547827[["εNFA194-19 char[1]"]]
eNFA194_20_5712723[["εNFA194-20 char{1, 1}"]]
eNFA194_21_51414507[["εNFA194-21 char[1]"]]
eNFA194_22_60077381[["εNFA194-22 char{1, 1}"]]
eNFA194_23_3825523[["εNFA194-23 char[1]"]]
eNFA194_24_34429708[["εNFA194-24 char{1, 1}"]]
eNFA194_25_41431923[["εNFA194-25 char[1]"]]
eNFA194_26_37342992[["εNFA194-26 char{1, 1}"]]
eNFA194_27_542612[["εNFA194-27 char[1]"]]
eNFA194_28_4883512[["εNFA194-28 char{1, 1}"]]
eNFA194_29_43951613[["εNFA194-29 char[1]"]]
eNFA194_30_60020205[["εNFA194-30 char{1, 1}"]]
eNFA194_31_3310935[["εNFA194-31 char[1]"]]
eNFA194_33_29798422[["εNFA194-33 regex end"]]
eNFA194_34_66859210[["εNFA194-34 post-regex start"]]
eNFA194_35_64861980[\"εNFA194-35 post-regex end"/]
eNFA194_32_53956341 -.->|"ε"|eNFA194_0_15845023
eNFA194_0_15845023 -->|"m"|eNFA194_1_8387487
eNFA194_1_8387487 -.->|"ε"|eNFA194_2_8378525
eNFA194_2_8378525 -->|"e"|eNFA194_3_8297866
eNFA194_3_8297866 -.->|"ε"|eNFA194_4_7571935
eNFA194_4_7571935 -->|"d"|eNFA194_5_1038558
eNFA194_5_1038558 -.->|"ε"|eNFA194_6_9347022
eNFA194_6_9347022 -->|"i"|eNFA194_7_17014337
eNFA194_7_17014337 -.->|"ε"|eNFA194_8_18911313
eNFA194_8_18911313 -->|"u"|eNFA194_9_35984094
eNFA194_9_35984094 -.->|"ε"|eNFA194_10_55421393
eNFA194_10_55421393 -->|"m"|eNFA194_11_29030491
eNFA194_11_29030491 -.->|"ε"|eNFA194_12_59947829
eNFA194_12_59947829 -->|"_"|eNFA194_13_2659552
eNFA194_13_2659552 -.->|"ε"|eNFA194_14_23935974
eNFA194_14_23935974 -->|"p"|eNFA194_15_14097174
eNFA194_15_14097174 -.->|"ε"|eNFA194_16_59765707
eNFA194_16_59765707 -->|"r"|eNFA194_17_1020452
eNFA194_17_1020452 -.->|"ε"|eNFA194_18_9184076
eNFA194_18_9184076 -->|"e"|eNFA194_19_15547827
eNFA194_19_15547827 -.->|"ε"|eNFA194_20_5712723
eNFA194_20_5712723 -->|"c"|eNFA194_21_51414507
eNFA194_21_51414507 -.->|"ε"|eNFA194_22_60077381
eNFA194_22_60077381 -->|"i"|eNFA194_23_3825523
eNFA194_23_3825523 -.->|"ε"|eNFA194_24_34429708
eNFA194_24_34429708 -->|"s"|eNFA194_25_41431923
eNFA194_25_41431923 -.->|"ε"|eNFA194_26_37342992
eNFA194_26_37342992 -->|"i"|eNFA194_27_542612
eNFA194_27_542612 -.->|"ε"|eNFA194_28_4883512
eNFA194_28_4883512 -->|"o"|eNFA194_29_43951613
eNFA194_29_43951613 -.->|"ε"|eNFA194_30_60020205
eNFA194_30_60020205 -->|"n"|eNFA194_31_3310935
eNFA194_31_3310935 -.->|"ε"|eNFA194_33_29798422
eNFA194_33_29798422 -.->|"ε"|eNFA194_34_66859210
eNFA194_34_66859210 -.->|"ε"|eNFA194_35_64861980
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
eNFA194_32_46886909[["εNFA194-32 regex start"]]
eNFA194_0_19328998[["εNFA194-0 char{1, 1}"]]
eNFA194_1_39743256[["εNFA194-1 char[1]"]]
eNFA194_2_22144988[["εNFA194-2 char{1, 1}"]]
eNFA194_3_65087172[["εNFA194-3 char[1]"]]
eNFA194_4_48913640[["εNFA194-4 char{1, 1}"]]
eNFA194_5_37569576[["εNFA194-5 char[1]"]]
eNFA194_6_2581871[["εNFA194-6 char{1, 1}"]]
eNFA194_7_23236845[["εNFA194-7 char[1]"]]
eNFA194_8_7805019[["εNFA194-8 char{1, 1}"]]
eNFA194_9_3136315[["εNFA194-9 char[1]"]]
eNFA194_10_28226836[["εNFA194-10 char{1, 1}"]]
eNFA194_11_52714937[["εNFA194-11 char[1]"]]
eNFA194_12_4672385[["εNFA194-12 char{1, 1}"]]
eNFA194_13_42051471[["εNFA194-13 char[1]"]]
eNFA194_14_42918923[["εNFA194-14 char{1, 1}"]]
eNFA194_15_50725990[["εNFA194-15 char[1]"]]
eNFA194_16_53880729[["εNFA194-16 char{1, 1}"]]
eNFA194_17_15164517[["εNFA194-17 char[1]"]]
eNFA194_18_2262932[["εNFA194-18 char{1, 1}"]]
eNFA194_19_20366389[["εNFA194-19 char[1]"]]
eNFA194_20_49079779[["εNFA194-20 char{1, 1}"]]
eNFA194_21_39064830[["εNFA194-21 char[1]"]]
eNFA194_22_16039151[["εNFA194-22 char{1, 1}"]]
eNFA194_23_10134631[["εNFA194-23 char[1]"]]
eNFA194_24_24102815[["εNFA194-24 char{1, 1}"]]
eNFA194_25_15598744[["εNFA194-25 char[1]"]]
eNFA194_26_6170971[["εNFA194-26 char{1, 1}"]]
eNFA194_27_55538746[["εNFA194-27 char[1]"]]
eNFA194_28_30086668[["εNFA194-28 char{1, 1}"]]
eNFA194_29_2344564[["εNFA194-29 char[1]"]]
eNFA194_30_21101082[["εNFA194-30 char{1, 1}"]]
eNFA194_31_55692015[\"εNFA194-31 char[1]"/]
eNFA194_33_31466092[\"εNFA194-33 regex end"/]
eNFA194_34_14759379[\"εNFA194-34 post-regex start"/]
eNFA194_35_65725547[\"εNFA194-35 post-regex end"/]
eNFA194_32_46886909 -.->|"ε"|eNFA194_0_19328998
eNFA194_32_46886909 -->|"m"|eNFA194_1_39743256
eNFA194_0_19328998 -->|"m"|eNFA194_1_39743256
eNFA194_1_39743256 -.->|"ε"|eNFA194_2_22144988
eNFA194_1_39743256 -->|"e"|eNFA194_3_65087172
eNFA194_2_22144988 -->|"e"|eNFA194_3_65087172
eNFA194_3_65087172 -.->|"ε"|eNFA194_4_48913640
eNFA194_3_65087172 -->|"d"|eNFA194_5_37569576
eNFA194_4_48913640 -->|"d"|eNFA194_5_37569576
eNFA194_5_37569576 -.->|"ε"|eNFA194_6_2581871
eNFA194_5_37569576 -->|"i"|eNFA194_7_23236845
eNFA194_6_2581871 -->|"i"|eNFA194_7_23236845
eNFA194_7_23236845 -.->|"ε"|eNFA194_8_7805019
eNFA194_7_23236845 -->|"u"|eNFA194_9_3136315
eNFA194_8_7805019 -->|"u"|eNFA194_9_3136315
eNFA194_9_3136315 -.->|"ε"|eNFA194_10_28226836
eNFA194_9_3136315 -->|"m"|eNFA194_11_52714937
eNFA194_10_28226836 -->|"m"|eNFA194_11_52714937
eNFA194_11_52714937 -.->|"ε"|eNFA194_12_4672385
eNFA194_11_52714937 -->|"_"|eNFA194_13_42051471
eNFA194_12_4672385 -->|"_"|eNFA194_13_42051471
eNFA194_13_42051471 -.->|"ε"|eNFA194_14_42918923
eNFA194_13_42051471 -->|"p"|eNFA194_15_50725990
eNFA194_14_42918923 -->|"p"|eNFA194_15_50725990
eNFA194_15_50725990 -.->|"ε"|eNFA194_16_53880729
eNFA194_15_50725990 -->|"r"|eNFA194_17_15164517
eNFA194_16_53880729 -->|"r"|eNFA194_17_15164517
eNFA194_17_15164517 -.->|"ε"|eNFA194_18_2262932
eNFA194_17_15164517 -->|"e"|eNFA194_19_20366389
eNFA194_18_2262932 -->|"e"|eNFA194_19_20366389
eNFA194_19_20366389 -.->|"ε"|eNFA194_20_49079779
eNFA194_19_20366389 -->|"c"|eNFA194_21_39064830
eNFA194_20_49079779 -->|"c"|eNFA194_21_39064830
eNFA194_21_39064830 -.->|"ε"|eNFA194_22_16039151
eNFA194_21_39064830 -->|"i"|eNFA194_23_10134631
eNFA194_22_16039151 -->|"i"|eNFA194_23_10134631
eNFA194_23_10134631 -.->|"ε"|eNFA194_24_24102815
eNFA194_23_10134631 -->|"s"|eNFA194_25_15598744
eNFA194_24_24102815 -->|"s"|eNFA194_25_15598744
eNFA194_25_15598744 -.->|"ε"|eNFA194_26_6170971
eNFA194_25_15598744 -->|"i"|eNFA194_27_55538746
eNFA194_26_6170971 -->|"i"|eNFA194_27_55538746
eNFA194_27_55538746 -.->|"ε"|eNFA194_28_30086668
eNFA194_27_55538746 -->|"o"|eNFA194_29_2344564
eNFA194_28_30086668 -->|"o"|eNFA194_29_2344564
eNFA194_29_2344564 -.->|"ε"|eNFA194_30_21101082
eNFA194_29_2344564 -->|"n"|eNFA194_31_55692015
eNFA194_30_21101082 -->|"n"|eNFA194_31_55692015
eNFA194_31_55692015 -.->|"ε"|eNFA194_33_31466092
eNFA194_31_55692015 -.->|"ε"|eNFA194_34_14759379
eNFA194_31_55692015 -.->|"ε"|eNFA194_35_65725547
eNFA194_33_31466092 -.->|"ε"|eNFA194_34_14759379
eNFA194_33_31466092 -.->|"ε"|eNFA194_35_65725547
eNFA194_34_14759379 -.->|"ε"|eNFA194_35_65725547
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
NFA194_32_54659014("NFA194-32 regex start")
NFA194_1_22169086("NFA194-1 char[1]")
NFA194_3_65304051("NFA194-3 char[1]")
NFA194_5_50865550("NFA194-5 char[1]")
NFA194_7_55136768("NFA194-7 char[1]")
NFA194_9_26468866("NFA194-9 char[1]")
NFA194_11_36893205("NFA194-11 char[1]")
NFA194_13_63603395("NFA194-13 char[1]")
NFA194_15_35559643("NFA194-15 char[1]")
NFA194_17_51601336("NFA194-17 char[1]")
NFA194_19_61758841("NFA194-19 char[1]")
NFA194_21_18958665("NFA194-21 char[1]")
NFA194_23_36410264("NFA194-23 char[1]")
NFA194_25_59256928("NFA194-25 char[1]")
NFA194_27_63550304("NFA194-27 char[1]")
NFA194_29_35081826("NFA194-29 char[1]")
NFA194_31_47300984[\"NFA194-31 char[1]"/]
NFA194_32_54659014 -->|"m"|NFA194_1_22169086
NFA194_1_22169086 -->|"e"|NFA194_3_65304051
NFA194_3_65304051 -->|"d"|NFA194_5_50865550
NFA194_5_50865550 -->|"i"|NFA194_7_55136768
NFA194_7_55136768 -->|"u"|NFA194_9_26468866
NFA194_9_26468866 -->|"m"|NFA194_11_36893205
NFA194_11_36893205 -->|"_"|NFA194_13_63603395
NFA194_13_63603395 -->|"p"|NFA194_15_35559643
NFA194_15_35559643 -->|"r"|NFA194_17_51601336
NFA194_17_51601336 -->|"e"|NFA194_19_61758841
NFA194_19_61758841 -->|"c"|NFA194_21_18958665
NFA194_21_18958665 -->|"i"|NFA194_23_36410264
NFA194_23_36410264 -->|"s"|NFA194_25_59256928
NFA194_25_59256928 -->|"i"|NFA194_27_63550304
NFA194_27_63550304 -->|"o"|NFA194_29_35081826
NFA194_29_35081826 -->|"n"|NFA194_31_47300984
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
subgraph DFA0_-337286600["DFA0 regex start"]
NFA194_32_54659014_0("NFA194-32 regex start")
end
subgraph DFA1_-1905976809["DFA1 {1}"]
NFA194_1_22169086_1("NFA194-1 char[1]")
end
subgraph DFA2_1049075445["DFA2 {1}"]
NFA194_3_65304051_2("NFA194-3 char[1]")
end
subgraph DFA3_1173113606["DFA3 {1}"]
NFA194_5_50865550_3("NFA194-5 char[1]")
end
subgraph DFA4_-1805170675["DFA4 {1}"]
NFA194_7_55136768_4("NFA194-7 char[1]")
end
subgraph DFA5_-1700587696["DFA5 {1}"]
NFA194_9_26468866_5("NFA194-9 char[1]")
end
subgraph DFA6_422352413["DFA6 {1}"]
NFA194_11_36893205_6("NFA194-11 char[1]")
end
subgraph DFA7_1576304577["DFA7 {1}"]
NFA194_13_63603395_7("NFA194-13 char[1]")
end
subgraph DFA8_2022938264["DFA8 {1}"]
NFA194_15_35559643_8("NFA194-15 char[1]")
end
subgraph DFA9_-1161650479["DFA9 {1}"]
NFA194_17_51601336_9("NFA194-17 char[1]")
end
subgraph DFA10_-1633974139["DFA10 {1}"]
NFA194_19_61758841_10("NFA194-19 char[1]")
end
subgraph DFA11_-996842290["DFA11 {1}"]
NFA194_21_18958665_11("NFA194-21 char[1]")
end
subgraph DFA12_-1051523648["DFA12 {1}"]
NFA194_23_36410264_12("NFA194-23 char[1]")
end
subgraph DFA13_1880108098["DFA13 {1}"]
NFA194_25_59256928_13("NFA194-25 char[1]")
end
subgraph DFA14_-411816239["DFA14 {1}"]
NFA194_27_63550304_14("NFA194-27 char[1]")
end
subgraph DFA15_797391507["DFA15 {1}"]
NFA194_29_35081826_15("NFA194-29 char[1]")
end
subgraph DFA16_-791541766["DFA16 {1}"]
NFA194_31_47300984_16[\"NFA194-31 char[1]"/]
end
DFA0_-337286600 -->|"m"|DFA1_-1905976809
DFA1_-1905976809 -->|"e"|DFA2_1049075445
DFA2_1049075445 -->|"d"|DFA3_1173113606
DFA3_1173113606 -->|"i"|DFA4_-1805170675
DFA4_-1805170675 -->|"u"|DFA5_-1700587696
DFA5_-1700587696 -->|"m"|DFA6_422352413
DFA6_422352413 -->|"_"|DFA7_1576304577
DFA7_1576304577 -->|"p"|DFA8_2022938264
DFA8_2022938264 -->|"r"|DFA9_-1161650479
DFA9_-1161650479 -->|"e"|DFA10_-1633974139
DFA10_-1633974139 -->|"c"|DFA11_-996842290
DFA11_-996842290 -->|"i"|DFA12_-1051523648
DFA12_-1051523648 -->|"s"|DFA13_1880108098
DFA13_1880108098 -->|"i"|DFA14_-411816239
DFA14_-411816239 -->|"o"|DFA15_797391507
DFA15_797391507 -->|"n"|DFA16_-791541766
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
DFA0_-337286600{{"DFA0 regex start"}}
DFA1_-1905976809{{"DFA1 {1}"}}
DFA2_1049075445{{"DFA2 {1}"}}
DFA3_1173113606{{"DFA3 {1}"}}
DFA4_-1805170675{{"DFA4 {1}"}}
DFA5_-1700587696{{"DFA5 {1}"}}
DFA6_422352413{{"DFA6 {1}"}}
DFA7_1576304577{{"DFA7 {1}"}}
DFA8_2022938264{{"DFA8 {1}"}}
DFA9_-1161650479{{"DFA9 {1}"}}
DFA10_-1633974139{{"DFA10 {1}"}}
DFA11_-996842290{{"DFA11 {1}"}}
DFA12_-1051523648{{"DFA12 {1}"}}
DFA13_1880108098{{"DFA13 {1}"}}
DFA14_-411816239{{"DFA14 {1}"}}
DFA15_797391507{{"DFA15 {1}"}}
DFA16_-791541766[\"DFA16 {1}"/]
DFA0_-337286600 -->|"m"|DFA1_-1905976809
DFA1_-1905976809 -->|"e"|DFA2_1049075445
DFA2_1049075445 -->|"d"|DFA3_1173113606
DFA3_1173113606 -->|"i"|DFA4_-1805170675
DFA4_-1805170675 -->|"u"|DFA5_-1700587696
DFA5_-1700587696 -->|"m"|DFA6_422352413
DFA6_422352413 -->|"_"|DFA7_1576304577
DFA7_1576304577 -->|"p"|DFA8_2022938264
DFA8_2022938264 -->|"r"|DFA9_-1161650479
DFA9_-1161650479 -->|"e"|DFA10_-1633974139
DFA10_-1633974139 -->|"c"|DFA11_-996842290
DFA11_-996842290 -->|"i"|DFA12_-1051523648
DFA12_-1051523648 -->|"s"|DFA13_1880108098
DFA13_1880108098 -->|"i"|DFA14_-411816239
DFA14_-411816239 -->|"o"|DFA15_797391507
DFA15_797391507 -->|"n"|DFA16_-791541766
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
subgraph MiniDFA0_141696771["MiniDFA0 {1}"]
DFA0_-337286600_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_2047379531["MiniDFA2 {1}"]
DFA1_-1905976809_1{{"DFA1 {1}"}}
end
subgraph MiniDFA4_-1092583695["MiniDFA4 {1}"]
DFA2_1049075445_2{{"DFA2 {1}"}}
end
subgraph MiniDFA5_340544620["MiniDFA5 {1}"]
DFA3_1173113606_3{{"DFA3 {1}"}}
end
subgraph MiniDFA8_-178060578["MiniDFA8 {1}"]
DFA4_-1805170675_4{{"DFA4 {1}"}}
end
subgraph MiniDFA1_64096170["MiniDFA1 {1}"]
DFA5_-1700587696_5{{"DFA5 {1}"}}
end
subgraph MiniDFA9_-390580473["MiniDFA9 {1}"]
DFA6_422352413_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_-1806901708["MiniDFA10 {1}"]
DFA7_1576304577_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_-1482008953["MiniDFA11 {1}"]
DFA8_2022938264_8{{"DFA8 {1}"}}
end
subgraph MiniDFA3_1295688641["MiniDFA3 {1}"]
DFA9_-1161650479_9{{"DFA9 {1}"}}
end
subgraph MiniDFA12_1482116093["MiniDFA12 {1}"]
DFA10_-1633974139_10{{"DFA10 {1}"}}
end
subgraph MiniDFA6_-1279687855["MiniDFA6 {1}"]
DFA11_-996842290_11{{"DFA11 {1}"}}
end
subgraph MiniDFA13_-2096362163["MiniDFA13 {1}"]
DFA12_-1051523648_12{{"DFA12 {1}"}}
end
subgraph MiniDFA7_585791918["MiniDFA7 {1}"]
DFA13_1880108098_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_798702243["MiniDFA14 {1}"]
DFA14_-411816239_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_-858825802["MiniDFA15 {1}"]
DFA15_797391507_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_-2066823327["MiniDFA16 {1}"]
DFA16_-791541766_16[\"DFA16 {1}"/]
end
MiniDFA0_141696771 -->|"m"|MiniDFA2_2047379531
MiniDFA2_2047379531 -->|"e"|MiniDFA4_-1092583695
MiniDFA4_-1092583695 -->|"d"|MiniDFA5_340544620
MiniDFA5_340544620 -->|"i"|MiniDFA8_-178060578
MiniDFA8_-178060578 -->|"u"|MiniDFA1_64096170
MiniDFA1_64096170 -->|"m"|MiniDFA9_-390580473
MiniDFA9_-390580473 -->|"_"|MiniDFA10_-1806901708
MiniDFA10_-1806901708 -->|"p"|MiniDFA11_-1482008953
MiniDFA11_-1482008953 -->|"r"|MiniDFA3_1295688641
MiniDFA3_1295688641 -->|"e"|MiniDFA12_1482116093
MiniDFA12_1482116093 -->|"c"|MiniDFA6_-1279687855
MiniDFA6_-1279687855 -->|"i"|MiniDFA13_-2096362163
MiniDFA13_-2096362163 -->|"s"|MiniDFA7_585791918
MiniDFA7_585791918 -->|"i"|MiniDFA14_798702243
MiniDFA14_798702243 -->|"o"|MiniDFA15_-858825802
MiniDFA15_-858825802 -->|"n"|MiniDFA16_-2066823327
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
MiniDFA0_141696771(["MiniDFA0 {1}"])
MiniDFA2_2047379531(["MiniDFA2 {1}"])
MiniDFA4_-1092583695(["MiniDFA4 {1}"])
MiniDFA5_340544620(["MiniDFA5 {1}"])
MiniDFA8_-178060578(["MiniDFA8 {1}"])
MiniDFA1_64096170(["MiniDFA1 {1}"])
MiniDFA9_-390580473(["MiniDFA9 {1}"])
MiniDFA10_-1806901708(["MiniDFA10 {1}"])
MiniDFA11_-1482008953(["MiniDFA11 {1}"])
MiniDFA3_1295688641(["MiniDFA3 {1}"])
MiniDFA12_1482116093(["MiniDFA12 {1}"])
MiniDFA6_-1279687855(["MiniDFA6 {1}"])
MiniDFA13_-2096362163(["MiniDFA13 {1}"])
MiniDFA7_585791918(["MiniDFA7 {1}"])
MiniDFA14_798702243(["MiniDFA14 {1}"])
MiniDFA15_-858825802(["MiniDFA15 {1}"])
MiniDFA16_-2066823327[\"MiniDFA16 {1}"/]
MiniDFA0_141696771 -->|"m"|MiniDFA2_2047379531
MiniDFA2_2047379531 -->|"e"|MiniDFA4_-1092583695
MiniDFA4_-1092583695 -->|"d"|MiniDFA5_340544620
MiniDFA5_340544620 -->|"i"|MiniDFA8_-178060578
MiniDFA8_-178060578 -->|"u"|MiniDFA1_64096170
MiniDFA1_64096170 -->|"m"|MiniDFA9_-390580473
MiniDFA9_-390580473 -->|"_"|MiniDFA10_-1806901708
MiniDFA10_-1806901708 -->|"p"|MiniDFA11_-1482008953
MiniDFA11_-1482008953 -->|"r"|MiniDFA3_1295688641
MiniDFA3_1295688641 -->|"e"|MiniDFA12_1482116093
MiniDFA12_1482116093 -->|"c"|MiniDFA6_-1279687855
MiniDFA6_-1279687855 -->|"i"|MiniDFA13_-2096362163
MiniDFA13_-2096362163 -->|"s"|MiniDFA7_585791918
MiniDFA7_585791918 -->|"i"|MiniDFA14_798702243
MiniDFA14_798702243 -->|"o"|MiniDFA15_-858825802
MiniDFA15_-858825802 -->|"n"|MiniDFA16_-2066823327
```
-------------------------------
