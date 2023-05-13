# 'userDefinedType'

pattern: `userDefinedType`

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
eNFA74_30_47313454[["εNFA74-30 regex start"]]
eNFA74_0_23167904[["εNFA74-0 char{1, 1}"]]
eNFA74_1_7184552[["εNFA74-1 char[1]"]]
eNFA74_2_64660974[["εNFA74-2 char{1, 1}"]]
eNFA74_3_45077859[["εNFA74-3 char[1]"]]
eNFA74_4_3047552[["εNFA74-4 char{1, 1}"]]
eNFA74_5_27427975[["εNFA74-5 char[1]"]]
eNFA74_6_45525183[["εNFA74-6 char{1, 1}"]]
eNFA74_7_7073466[["εNFA74-7 char[1]"]]
eNFA74_8_63661202[["εNFA74-8 char{1, 1}"]]
eNFA74_9_36079911[["εNFA74-9 char[1]"]]
eNFA74_10_56283746[["εNFA74-10 char{1, 1}"]]
eNFA74_11_36791668[["εNFA74-11 char[1]"]]
eNFA74_12_62689558[["εNFA74-12 char{1, 1}"]]
eNFA74_13_27335113[["εNFA74-13 char[1]"]]
eNFA74_14_44689431[["εNFA74-14 char{1, 1}"]]
eNFA74_15_66660559[["εNFA74-15 char[1]"]]
eNFA74_16_63074124[["εNFA74-16 char{1, 1}"]]
eNFA74_17_30796205[["εNFA74-17 char[1]"]]
eNFA74_18_8730397[["εNFA74-18 char{1, 1}"]]
eNFA74_19_11464716[["εNFA74-19 char[1]"]]
eNFA74_20_36073588[["εNFA74-20 char{1, 1}"]]
eNFA74_21_56226836[["εNFA74-21 char[1]"]]
eNFA74_22_36279478[["εNFA74-22 char{1, 1}"]]
eNFA74_23_58079852[["εNFA74-23 char[1]"]]
eNFA74_24_52956621[["εNFA74-24 char{1, 1}"]]
eNFA74_25_6847548[["εNFA74-25 char[1]"]]
eNFA74_26_61627937[["εNFA74-26 char{1, 1}"]]
eNFA74_27_17780525[["εNFA74-27 char[1]"]]
eNFA74_28_25807001[["εNFA74-28 char{1, 1}"]]
eNFA74_29_30936422[["εNFA74-29 char[1]"]]
eNFA74_31_9992350[["εNFA74-31 regex end"]]
eNFA74_32_22822288[["εNFA74-32 post-regex start"]]
eNFA74_33_4074007[\"εNFA74-33 post-regex end"/]
eNFA74_30_47313454 -.->|"ε"|eNFA74_0_23167904
eNFA74_0_23167904 -->|"u"|eNFA74_1_7184552
eNFA74_1_7184552 -.->|"ε"|eNFA74_2_64660974
eNFA74_2_64660974 -->|"s"|eNFA74_3_45077859
eNFA74_3_45077859 -.->|"ε"|eNFA74_4_3047552
eNFA74_4_3047552 -->|"e"|eNFA74_5_27427975
eNFA74_5_27427975 -.->|"ε"|eNFA74_6_45525183
eNFA74_6_45525183 -->|"r"|eNFA74_7_7073466
eNFA74_7_7073466 -.->|"ε"|eNFA74_8_63661202
eNFA74_8_63661202 -->|"D"|eNFA74_9_36079911
eNFA74_9_36079911 -.->|"ε"|eNFA74_10_56283746
eNFA74_10_56283746 -->|"e"|eNFA74_11_36791668
eNFA74_11_36791668 -.->|"ε"|eNFA74_12_62689558
eNFA74_12_62689558 -->|"f"|eNFA74_13_27335113
eNFA74_13_27335113 -.->|"ε"|eNFA74_14_44689431
eNFA74_14_44689431 -->|"i"|eNFA74_15_66660559
eNFA74_15_66660559 -.->|"ε"|eNFA74_16_63074124
eNFA74_16_63074124 -->|"n"|eNFA74_17_30796205
eNFA74_17_30796205 -.->|"ε"|eNFA74_18_8730397
eNFA74_18_8730397 -->|"e"|eNFA74_19_11464716
eNFA74_19_11464716 -.->|"ε"|eNFA74_20_36073588
eNFA74_20_36073588 -->|"d"|eNFA74_21_56226836
eNFA74_21_56226836 -.->|"ε"|eNFA74_22_36279478
eNFA74_22_36279478 -->|"T"|eNFA74_23_58079852
eNFA74_23_58079852 -.->|"ε"|eNFA74_24_52956621
eNFA74_24_52956621 -->|"y"|eNFA74_25_6847548
eNFA74_25_6847548 -.->|"ε"|eNFA74_26_61627937
eNFA74_26_61627937 -->|"p"|eNFA74_27_17780525
eNFA74_27_17780525 -.->|"ε"|eNFA74_28_25807001
eNFA74_28_25807001 -->|"e"|eNFA74_29_30936422
eNFA74_29_30936422 -.->|"ε"|eNFA74_31_9992350
eNFA74_31_9992350 -.->|"ε"|eNFA74_32_22822288
eNFA74_32_22822288 -.->|"ε"|eNFA74_33_4074007
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
eNFA74_30_36666067[["εNFA74-30 regex start"]]
eNFA74_0_61559149[["εNFA74-0 char{1, 1}"]]
eNFA74_1_17161430[["εNFA74-1 char[1]"]]
eNFA74_2_20235143[["εNFA74-2 char{1, 1}"]]
eNFA74_3_47898561[["εNFA74-3 char[1]"]]
eNFA74_4_28433869[["εNFA74-4 char{1, 1}"]]
eNFA74_5_54578237[["εNFA74-5 char[1]"]]
eNFA74_6_21442089[["εNFA74-6 char{1, 1}"]]
eNFA74_7_58761073[["εNFA74-7 char[1]"]]
eNFA74_8_59087616[["εNFA74-8 char{1, 1}"]]
eNFA74_9_62026502[["εNFA74-9 char[1]"]]
eNFA74_10_21367612[["εNFA74-10 char{1, 1}"]]
eNFA74_11_58090788[["εNFA74-11 char[1]"]]
eNFA74_12_53055045[["εNFA74-12 char{1, 1}"]]
eNFA74_13_7733362[["εNFA74-13 char[1]"]]
eNFA74_14_2491394[["εNFA74-14 char{1, 1}"]]
eNFA74_15_22422552[["εNFA74-15 char[1]"]]
eNFA74_16_476380[["εNFA74-16 char{1, 1}"]]
eNFA74_17_4287423[["εNFA74-17 char[1]"]]
eNFA74_18_38586810[["εNFA74-18 char{1, 1}"]]
eNFA74_19_11736974[["εNFA74-19 char[1]"]]
eNFA74_20_38523909[["εNFA74-20 char{1, 1}"]]
eNFA74_21_11170862[["εNFA74-21 char[1]"]]
eNFA74_22_33428900[["εNFA74-22 char{1, 1}"]]
eNFA74_23_32424647[["εNFA74-23 char[1]"]]
eNFA74_24_23386368[["εNFA74-24 char{1, 1}"]]
eNFA74_25_9150720[["εNFA74-25 char[1]"]]
eNFA74_26_15247616[["εNFA74-26 char{1, 1}"]]
eNFA74_27_3010817[["εNFA74-27 char[1]"]]
eNFA74_28_27097356[["εNFA74-28 char{1, 1}"]]
eNFA74_29_42549619[\"εNFA74-29 char[1]"/]
eNFA74_31_47402253[\"εNFA74-31 regex end"/]
eNFA74_32_23967101[\"εNFA74-32 post-regex start"/]
eNFA74_33_14377323[\"εNFA74-33 post-regex end"/]
eNFA74_30_36666067 -.->|"ε"|eNFA74_0_61559149
eNFA74_30_36666067 -->|"u"|eNFA74_1_17161430
eNFA74_0_61559149 -->|"u"|eNFA74_1_17161430
eNFA74_1_17161430 -.->|"ε"|eNFA74_2_20235143
eNFA74_1_17161430 -->|"s"|eNFA74_3_47898561
eNFA74_2_20235143 -->|"s"|eNFA74_3_47898561
eNFA74_3_47898561 -.->|"ε"|eNFA74_4_28433869
eNFA74_3_47898561 -->|"e"|eNFA74_5_54578237
eNFA74_4_28433869 -->|"e"|eNFA74_5_54578237
eNFA74_5_54578237 -.->|"ε"|eNFA74_6_21442089
eNFA74_5_54578237 -->|"r"|eNFA74_7_58761073
eNFA74_6_21442089 -->|"r"|eNFA74_7_58761073
eNFA74_7_58761073 -.->|"ε"|eNFA74_8_59087616
eNFA74_7_58761073 -->|"D"|eNFA74_9_62026502
eNFA74_8_59087616 -->|"D"|eNFA74_9_62026502
eNFA74_9_62026502 -.->|"ε"|eNFA74_10_21367612
eNFA74_9_62026502 -->|"e"|eNFA74_11_58090788
eNFA74_10_21367612 -->|"e"|eNFA74_11_58090788
eNFA74_11_58090788 -.->|"ε"|eNFA74_12_53055045
eNFA74_11_58090788 -->|"f"|eNFA74_13_7733362
eNFA74_12_53055045 -->|"f"|eNFA74_13_7733362
eNFA74_13_7733362 -.->|"ε"|eNFA74_14_2491394
eNFA74_13_7733362 -->|"i"|eNFA74_15_22422552
eNFA74_14_2491394 -->|"i"|eNFA74_15_22422552
eNFA74_15_22422552 -.->|"ε"|eNFA74_16_476380
eNFA74_15_22422552 -->|"n"|eNFA74_17_4287423
eNFA74_16_476380 -->|"n"|eNFA74_17_4287423
eNFA74_17_4287423 -.->|"ε"|eNFA74_18_38586810
eNFA74_17_4287423 -->|"e"|eNFA74_19_11736974
eNFA74_18_38586810 -->|"e"|eNFA74_19_11736974
eNFA74_19_11736974 -.->|"ε"|eNFA74_20_38523909
eNFA74_19_11736974 -->|"d"|eNFA74_21_11170862
eNFA74_20_38523909 -->|"d"|eNFA74_21_11170862
eNFA74_21_11170862 -.->|"ε"|eNFA74_22_33428900
eNFA74_21_11170862 -->|"T"|eNFA74_23_32424647
eNFA74_22_33428900 -->|"T"|eNFA74_23_32424647
eNFA74_23_32424647 -.->|"ε"|eNFA74_24_23386368
eNFA74_23_32424647 -->|"y"|eNFA74_25_9150720
eNFA74_24_23386368 -->|"y"|eNFA74_25_9150720
eNFA74_25_9150720 -.->|"ε"|eNFA74_26_15247616
eNFA74_25_9150720 -->|"p"|eNFA74_27_3010817
eNFA74_26_15247616 -->|"p"|eNFA74_27_3010817
eNFA74_27_3010817 -.->|"ε"|eNFA74_28_27097356
eNFA74_27_3010817 -->|"e"|eNFA74_29_42549619
eNFA74_28_27097356 -->|"e"|eNFA74_29_42549619
eNFA74_29_42549619 -.->|"ε"|eNFA74_31_47402253
eNFA74_29_42549619 -.->|"ε"|eNFA74_32_23967101
eNFA74_29_42549619 -.->|"ε"|eNFA74_33_14377323
eNFA74_31_47402253 -.->|"ε"|eNFA74_32_23967101
eNFA74_31_47402253 -.->|"ε"|eNFA74_33_14377323
eNFA74_32_23967101 -.->|"ε"|eNFA74_33_14377323
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
NFA74_30_62287048("NFA74-30 regex start")
NFA74_1_23712525("NFA74-1 char[1]")
NFA74_3_12086140("NFA74-3 char[1]")
NFA74_5_41666396("NFA74-5 char[1]")
NFA74_7_39453247("NFA74-7 char[1]")
NFA74_9_19534911("NFA74-9 char[1]")
NFA74_11_41596476("NFA74-11 char[1]")
NFA74_13_38823967("NFA74-13 char[1]")
NFA74_15_13871385("NFA74-15 char[1]")
NFA74_17_57733603("NFA74-17 char[1]")
NFA74_19_49840382("NFA74-19 char[1]")
NFA74_21_45910260("NFA74-21 char[1]")
NFA74_23_10539156("NFA74-23 char[1]")
NFA74_25_27743545("NFA74-25 char[1]")
NFA74_27_48365314("NFA74-27 char[1]")
NFA74_29_32634650[\"NFA74-29 char[1]"/]
NFA74_30_62287048 -->|"u"|NFA74_1_23712525
NFA74_1_23712525 -->|"s"|NFA74_3_12086140
NFA74_3_12086140 -->|"e"|NFA74_5_41666396
NFA74_5_41666396 -->|"r"|NFA74_7_39453247
NFA74_7_39453247 -->|"D"|NFA74_9_19534911
NFA74_9_19534911 -->|"e"|NFA74_11_41596476
NFA74_11_41596476 -->|"f"|NFA74_13_38823967
NFA74_13_38823967 -->|"i"|NFA74_15_13871385
NFA74_15_13871385 -->|"n"|NFA74_17_57733603
NFA74_17_57733603 -->|"e"|NFA74_19_49840382
NFA74_19_49840382 -->|"d"|NFA74_21_45910260
NFA74_21_45910260 -->|"T"|NFA74_23_10539156
NFA74_23_10539156 -->|"y"|NFA74_25_27743545
NFA74_25_27743545 -->|"p"|NFA74_27_48365314
NFA74_27_48365314 -->|"e"|NFA74_29_32634650
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
subgraph DFA0_1442952393["DFA0 regex start"]
NFA74_30_62287048_0("NFA74-30 regex start")
end
subgraph DFA1_1776322462["DFA1 {1}"]
NFA74_1_23712525_1("NFA74-1 char[1]")
end
subgraph DFA2_-1145768906["DFA2 {1}"]
NFA74_3_12086140_2("NFA74-3 char[1]")
end
subgraph DFA3_-418096010["DFA3 {1}"]
NFA74_5_41666396_3("NFA74-5 char[1]")
end
subgraph DFA4_1950988007["DFA4 {1}"]
NFA74_7_39453247_4("NFA74-7 char[1]")
end
subgraph DFA5_276212658["DFA5 {1}"]
NFA74_9_19534911_5("NFA74-9 char[1]")
end
subgraph DFA6_-1519409020["DFA6 {1}"]
NFA74_11_41596476_6("NFA74-11 char[1]")
end
subgraph DFA7_337003208["DFA7 {1}"]
NFA74_13_38823967_7("NFA74-13 char[1]")
end
subgraph DFA8_1718302170["DFA8 {1}"]
NFA74_15_13871385_8("NFA74-15 char[1]")
end
subgraph DFA9_646441238["DFA9 {1}"]
NFA74_17_57733603_9("NFA74-17 char[1]")
end
subgraph DFA10_810498010["DFA10 {1}"]
NFA74_19_49840382_10("NFA74-19 char[1]")
end
subgraph DFA11_1016453249["DFA11 {1}"]
NFA74_21_45910260_11("NFA74-21 char[1]")
end
subgraph DFA12_1102851291["DFA12 {1}"]
NFA74_23_10539156_12("NFA74-23 char[1]")
end
subgraph DFA13_-1267892146["DFA13 {1}"]
NFA74_25_27743545_13("NFA74-25 char[1]")
end
subgraph DFA14_-1707236587["DFA14 {1}"]
NFA74_27_48365314_14("NFA74-27 char[1]")
end
subgraph DFA15_454693795["DFA15 {1}"]
NFA74_29_32634650_15[\"NFA74-29 char[1]"/]
end
DFA0_1442952393 -->|"u"|DFA1_1776322462
DFA1_1776322462 -->|"s"|DFA2_-1145768906
DFA2_-1145768906 -->|"e"|DFA3_-418096010
DFA3_-418096010 -->|"r"|DFA4_1950988007
DFA4_1950988007 -->|"D"|DFA5_276212658
DFA5_276212658 -->|"e"|DFA6_-1519409020
DFA6_-1519409020 -->|"f"|DFA7_337003208
DFA7_337003208 -->|"i"|DFA8_1718302170
DFA8_1718302170 -->|"n"|DFA9_646441238
DFA9_646441238 -->|"e"|DFA10_810498010
DFA10_810498010 -->|"d"|DFA11_1016453249
DFA11_1016453249 -->|"T"|DFA12_1102851291
DFA12_1102851291 -->|"y"|DFA13_-1267892146
DFA13_-1267892146 -->|"p"|DFA14_-1707236587
DFA14_-1707236587 -->|"e"|DFA15_454693795
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
DFA0_1442952393{{"DFA0 regex start"}}
DFA1_1776322462{{"DFA1 {1}"}}
DFA2_-1145768906{{"DFA2 {1}"}}
DFA3_-418096010{{"DFA3 {1}"}}
DFA4_1950988007{{"DFA4 {1}"}}
DFA5_276212658{{"DFA5 {1}"}}
DFA6_-1519409020{{"DFA6 {1}"}}
DFA7_337003208{{"DFA7 {1}"}}
DFA8_1718302170{{"DFA8 {1}"}}
DFA9_646441238{{"DFA9 {1}"}}
DFA10_810498010{{"DFA10 {1}"}}
DFA11_1016453249{{"DFA11 {1}"}}
DFA12_1102851291{{"DFA12 {1}"}}
DFA13_-1267892146{{"DFA13 {1}"}}
DFA14_-1707236587{{"DFA14 {1}"}}
DFA15_454693795[\"DFA15 {1}"/]
DFA0_1442952393 -->|"u"|DFA1_1776322462
DFA1_1776322462 -->|"s"|DFA2_-1145768906
DFA2_-1145768906 -->|"e"|DFA3_-418096010
DFA3_-418096010 -->|"r"|DFA4_1950988007
DFA4_1950988007 -->|"D"|DFA5_276212658
DFA5_276212658 -->|"e"|DFA6_-1519409020
DFA6_-1519409020 -->|"f"|DFA7_337003208
DFA7_337003208 -->|"i"|DFA8_1718302170
DFA8_1718302170 -->|"n"|DFA9_646441238
DFA9_646441238 -->|"e"|DFA10_810498010
DFA10_810498010 -->|"d"|DFA11_1016453249
DFA11_1016453249 -->|"T"|DFA12_1102851291
DFA12_1102851291 -->|"y"|DFA13_-1267892146
DFA13_-1267892146 -->|"p"|DFA14_-1707236587
DFA14_-1707236587 -->|"e"|DFA15_454693795
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
subgraph MiniDFA0_-1658991041["MiniDFA0 {1}"]
DFA0_1442952393_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2087174134["MiniDFA1 {1}"]
DFA1_1776322462_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1314514714["MiniDFA2 {1}"]
DFA2_-1145768906_2{{"DFA2 {1}"}}
end
subgraph MiniDFA5_32346879["MiniDFA5 {1}"]
DFA3_-418096010_3{{"DFA3 {1}"}}
end
subgraph MiniDFA6_2124771421["MiniDFA6 {1}"]
DFA4_1950988007_4{{"DFA4 {1}"}}
end
subgraph MiniDFA3_-756028991["MiniDFA3 {1}"]
DFA5_276212658_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_972904372["MiniDFA7 {1}"]
DFA6_-1519409020_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1821575128["MiniDFA8 {1}"]
DFA7_337003208_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_700835660["MiniDFA9 {1}"]
DFA8_1718302170_8{{"DFA8 {1}"}}
end
subgraph MiniDFA4_1696521108["MiniDFA4 {1}"]
DFA9_646441238_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-395494272["MiniDFA10 {1}"]
DFA10_810498010_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_599054609["MiniDFA11 {1}"]
DFA11_1016453249_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-441229324["MiniDFA12 {1}"]
DFA12_1102851291_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1920677960["MiniDFA13 {1}"]
DFA13_-1267892146_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1432644981["MiniDFA14 {1}"]
DFA14_-1707236587_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_1275415002["MiniDFA15 {1}"]
DFA15_454693795_15[\"DFA15 {1}"/]
end
MiniDFA0_-1658991041 -->|"u"|MiniDFA1_2087174134
MiniDFA1_2087174134 -->|"s"|MiniDFA2_-1314514714
MiniDFA2_-1314514714 -->|"e"|MiniDFA5_32346879
MiniDFA5_32346879 -->|"r"|MiniDFA6_2124771421
MiniDFA6_2124771421 -->|"D"|MiniDFA3_-756028991
MiniDFA3_-756028991 -->|"e"|MiniDFA7_972904372
MiniDFA7_972904372 -->|"f"|MiniDFA8_1821575128
MiniDFA8_1821575128 -->|"i"|MiniDFA9_700835660
MiniDFA9_700835660 -->|"n"|MiniDFA4_1696521108
MiniDFA4_1696521108 -->|"e"|MiniDFA10_-395494272
MiniDFA10_-395494272 -->|"d"|MiniDFA11_599054609
MiniDFA11_599054609 -->|"T"|MiniDFA12_-441229324
MiniDFA12_-441229324 -->|"y"|MiniDFA13_-1920677960
MiniDFA13_-1920677960 -->|"p"|MiniDFA14_1432644981
MiniDFA14_1432644981 -->|"e"|MiniDFA15_1275415002
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
MiniDFA0_-1658991041(["MiniDFA0 {1}"])
MiniDFA1_2087174134(["MiniDFA1 {1}"])
MiniDFA2_-1314514714(["MiniDFA2 {1}"])
MiniDFA5_32346879(["MiniDFA5 {1}"])
MiniDFA6_2124771421(["MiniDFA6 {1}"])
MiniDFA3_-756028991(["MiniDFA3 {1}"])
MiniDFA7_972904372(["MiniDFA7 {1}"])
MiniDFA8_1821575128(["MiniDFA8 {1}"])
MiniDFA9_700835660(["MiniDFA9 {1}"])
MiniDFA4_1696521108(["MiniDFA4 {1}"])
MiniDFA10_-395494272(["MiniDFA10 {1}"])
MiniDFA11_599054609(["MiniDFA11 {1}"])
MiniDFA12_-441229324(["MiniDFA12 {1}"])
MiniDFA13_-1920677960(["MiniDFA13 {1}"])
MiniDFA14_1432644981(["MiniDFA14 {1}"])
MiniDFA15_1275415002[\"MiniDFA15 {1}"/]
MiniDFA0_-1658991041 -->|"u"|MiniDFA1_2087174134
MiniDFA1_2087174134 -->|"s"|MiniDFA2_-1314514714
MiniDFA2_-1314514714 -->|"e"|MiniDFA5_32346879
MiniDFA5_32346879 -->|"r"|MiniDFA6_2124771421
MiniDFA6_2124771421 -->|"D"|MiniDFA3_-756028991
MiniDFA3_-756028991 -->|"e"|MiniDFA7_972904372
MiniDFA7_972904372 -->|"f"|MiniDFA8_1821575128
MiniDFA8_1821575128 -->|"i"|MiniDFA9_700835660
MiniDFA9_700835660 -->|"n"|MiniDFA4_1696521108
MiniDFA4_1696521108 -->|"e"|MiniDFA10_-395494272
MiniDFA10_-395494272 -->|"d"|MiniDFA11_599054609
MiniDFA11_599054609 -->|"T"|MiniDFA12_-441229324
MiniDFA12_-441229324 -->|"y"|MiniDFA13_-1920677960
MiniDFA13_-1920677960 -->|"p"|MiniDFA14_1432644981
MiniDFA14_1432644981 -->|"e"|MiniDFA15_1275415002
```
-------------------------------
