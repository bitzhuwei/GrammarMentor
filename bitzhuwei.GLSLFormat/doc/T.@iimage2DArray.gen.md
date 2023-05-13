# 'iimage2DArray'

pattern: `iimage2DArray`

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
eNFA182_26_43839368[["εNFA182-26 regex start"]]
eNFA182_0_59009999[["εNFA182-0 char{1, 1}"]]
eNFA182_1_61327951[["εNFA182-1 char[1]"]]
eNFA182_2_15080647[["εNFA182-2 char{1, 1}"]]
eNFA182_3_1508097[["εNFA182-3 char[1]"]]
eNFA182_4_13572879[["εNFA182-4 char{1, 1}"]]
eNFA182_5_55047048[["εNFA182-5 char[1]"]]
eNFA182_6_25661391[["εNFA182-6 char{1, 1}"]]
eNFA182_7_29625932[["εNFA182-7 char[1]"]]
eNFA182_8_65306800[["εNFA182-8 char{1, 1}"]]
eNFA182_9_50890292[["εNFA182-9 char[1]"]]
eNFA182_10_55359449[["εNFA182-10 char{1, 1}"]]
eNFA182_11_28473001[["εNFA182-11 char[1]"]]
eNFA182_12_54930419[["εNFA182-12 char{1, 1}"]]
eNFA182_13_24611730[["εNFA182-13 char[1]"]]
eNFA182_14_20178982[["εNFA182-14 char{1, 1}"]]
eNFA182_15_47393112[["εNFA182-15 char[1]"]]
eNFA182_16_23884825[["εNFA182-16 char{1, 1}"]]
eNFA182_17_13636834[["εNFA182-17 char[1]"]]
eNFA182_18_55622644[["εNFA182-18 char{1, 1}"]]
eNFA182_19_30841752[["εNFA182-19 char[1]"]]
eNFA182_20_9140320[["εNFA182-20 char{1, 1}"]]
eNFA182_21_15154020[["εNFA182-21 char[1]"]]
eNFA182_22_2168452[["εNFA182-22 char{1, 1}"]]
eNFA182_23_19516075[["εNFA182-23 char[1]"]]
eNFA182_24_41426953[["εNFA182-24 char{1, 1}"]]
eNFA182_25_37298263[["εNFA182-25 char[1]"]]
eNFA182_27_140055[["εNFA182-27 regex end"]]
eNFA182_28_1260496[["εNFA182-28 post-regex start"]]
eNFA182_29_11344469[\"εNFA182-29 post-regex end"/]
eNFA182_26_43839368 -.->|"ε"|eNFA182_0_59009999
eNFA182_0_59009999 -->|"i"|eNFA182_1_61327951
eNFA182_1_61327951 -.->|"ε"|eNFA182_2_15080647
eNFA182_2_15080647 -->|"i"|eNFA182_3_1508097
eNFA182_3_1508097 -.->|"ε"|eNFA182_4_13572879
eNFA182_4_13572879 -->|"m"|eNFA182_5_55047048
eNFA182_5_55047048 -.->|"ε"|eNFA182_6_25661391
eNFA182_6_25661391 -->|"a"|eNFA182_7_29625932
eNFA182_7_29625932 -.->|"ε"|eNFA182_8_65306800
eNFA182_8_65306800 -->|"g"|eNFA182_9_50890292
eNFA182_9_50890292 -.->|"ε"|eNFA182_10_55359449
eNFA182_10_55359449 -->|"e"|eNFA182_11_28473001
eNFA182_11_28473001 -.->|"ε"|eNFA182_12_54930419
eNFA182_12_54930419 -->|"2"|eNFA182_13_24611730
eNFA182_13_24611730 -.->|"ε"|eNFA182_14_20178982
eNFA182_14_20178982 -->|"D"|eNFA182_15_47393112
eNFA182_15_47393112 -.->|"ε"|eNFA182_16_23884825
eNFA182_16_23884825 -->|"A"|eNFA182_17_13636834
eNFA182_17_13636834 -.->|"ε"|eNFA182_18_55622644
eNFA182_18_55622644 -->|"r"|eNFA182_19_30841752
eNFA182_19_30841752 -.->|"ε"|eNFA182_20_9140320
eNFA182_20_9140320 -->|"r"|eNFA182_21_15154020
eNFA182_21_15154020 -.->|"ε"|eNFA182_22_2168452
eNFA182_22_2168452 -->|"a"|eNFA182_23_19516075
eNFA182_23_19516075 -.->|"ε"|eNFA182_24_41426953
eNFA182_24_41426953 -->|"y"|eNFA182_25_37298263
eNFA182_25_37298263 -.->|"ε"|eNFA182_27_140055
eNFA182_27_140055 -.->|"ε"|eNFA182_28_1260496
eNFA182_28_1260496 -.->|"ε"|eNFA182_29_11344469
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
eNFA182_26_34991357[["εNFA182-26 regex start"]]
eNFA182_0_46486763[["εNFA182-0 char{1, 1}"]]
eNFA182_1_15727687[["εNFA182-1 char[1]"]]
eNFA182_2_7331458[["εNFA182-2 char{1, 1}"]]
eNFA182_3_65983125[["εNFA182-3 char[1]"]]
eNFA182_4_56977217[["εNFA182-4 char{1, 1}"]]
eNFA182_5_43032912[["εNFA182-5 char[1]"]]
eNFA182_6_51751889[["εNFA182-6 char{1, 1}"]]
eNFA182_7_63113823[["εNFA182-7 char[1]"]]
eNFA182_8_31153498[["εNFA182-8 char{1, 1}"]]
eNFA182_9_11946027[["εNFA182-9 char[1]"]]
eNFA182_10_40405379[["εNFA182-10 char{1, 1}"]]
eNFA182_11_28104091[["εNFA182-11 char[1]"]]
eNFA182_12_51610228[["εNFA182-12 char{1, 1}"]]
eNFA182_13_61838871[["εNFA182-13 char[1]"]]
eNFA182_14_19678934[["εNFA182-14 char{1, 1}"]]
eNFA182_15_42892680[["εNFA182-15 char[1]"]]
eNFA182_16_50489808[["εNFA182-16 char{1, 1}"]]
eNFA182_17_51755094[["εNFA182-17 char[1]"]]
eNFA182_18_63142667[["εNFA182-18 char{1, 1}"]]
eNFA182_19_31413096[["εNFA182-19 char[1]"]]
eNFA182_20_14282415[["εNFA182-20 char{1, 1}"]]
eNFA182_21_61432871[["εNFA182-21 char[1]"]]
eNFA182_22_16024930[["εNFA182-22 char{1, 1}"]]
eNFA182_23_10006650[["εNFA182-23 char[1]"]]
eNFA182_24_22950991[["εNFA182-24 char{1, 1}"]]
eNFA182_25_5232330[\"εNFA182-25 char[1]"/]
eNFA182_27_47090972[\"εNFA182-27 regex end"/]
eNFA182_28_21165566[\"εNFA182-28 post-regex start"/]
eNFA182_29_56272369[\"εNFA182-29 post-regex end"/]
eNFA182_26_34991357 -.->|"ε"|eNFA182_0_46486763
eNFA182_26_34991357 -->|"i"|eNFA182_1_15727687
eNFA182_0_46486763 -->|"i"|eNFA182_1_15727687
eNFA182_1_15727687 -.->|"ε"|eNFA182_2_7331458
eNFA182_1_15727687 -->|"i"|eNFA182_3_65983125
eNFA182_2_7331458 -->|"i"|eNFA182_3_65983125
eNFA182_3_65983125 -.->|"ε"|eNFA182_4_56977217
eNFA182_3_65983125 -->|"m"|eNFA182_5_43032912
eNFA182_4_56977217 -->|"m"|eNFA182_5_43032912
eNFA182_5_43032912 -.->|"ε"|eNFA182_6_51751889
eNFA182_5_43032912 -->|"a"|eNFA182_7_63113823
eNFA182_6_51751889 -->|"a"|eNFA182_7_63113823
eNFA182_7_63113823 -.->|"ε"|eNFA182_8_31153498
eNFA182_7_63113823 -->|"g"|eNFA182_9_11946027
eNFA182_8_31153498 -->|"g"|eNFA182_9_11946027
eNFA182_9_11946027 -.->|"ε"|eNFA182_10_40405379
eNFA182_9_11946027 -->|"e"|eNFA182_11_28104091
eNFA182_10_40405379 -->|"e"|eNFA182_11_28104091
eNFA182_11_28104091 -.->|"ε"|eNFA182_12_51610228
eNFA182_11_28104091 -->|"2"|eNFA182_13_61838871
eNFA182_12_51610228 -->|"2"|eNFA182_13_61838871
eNFA182_13_61838871 -.->|"ε"|eNFA182_14_19678934
eNFA182_13_61838871 -->|"D"|eNFA182_15_42892680
eNFA182_14_19678934 -->|"D"|eNFA182_15_42892680
eNFA182_15_42892680 -.->|"ε"|eNFA182_16_50489808
eNFA182_15_42892680 -->|"A"|eNFA182_17_51755094
eNFA182_16_50489808 -->|"A"|eNFA182_17_51755094
eNFA182_17_51755094 -.->|"ε"|eNFA182_18_63142667
eNFA182_17_51755094 -->|"r"|eNFA182_19_31413096
eNFA182_18_63142667 -->|"r"|eNFA182_19_31413096
eNFA182_19_31413096 -.->|"ε"|eNFA182_20_14282415
eNFA182_19_31413096 -->|"r"|eNFA182_21_61432871
eNFA182_20_14282415 -->|"r"|eNFA182_21_61432871
eNFA182_21_61432871 -.->|"ε"|eNFA182_22_16024930
eNFA182_21_61432871 -->|"a"|eNFA182_23_10006650
eNFA182_22_16024930 -->|"a"|eNFA182_23_10006650
eNFA182_23_10006650 -.->|"ε"|eNFA182_24_22950991
eNFA182_23_10006650 -->|"y"|eNFA182_25_5232330
eNFA182_24_22950991 -->|"y"|eNFA182_25_5232330
eNFA182_25_5232330 -.->|"ε"|eNFA182_27_47090972
eNFA182_25_5232330 -.->|"ε"|eNFA182_28_21165566
eNFA182_25_5232330 -.->|"ε"|eNFA182_29_56272369
eNFA182_27_47090972 -.->|"ε"|eNFA182_28_21165566
eNFA182_27_47090972 -.->|"ε"|eNFA182_29_56272369
eNFA182_28_21165566 -.->|"ε"|eNFA182_29_56272369
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
NFA182_26_36689279("NFA182-26 regex start")
NFA182_1_61768055("NFA182-1 char[1]")
NFA182_3_19041588("NFA182-3 char[1]")
NFA182_5_37156565("NFA182-5 char[1]")
NFA182_7_65973637("NFA182-7 char[1]")
NFA182_9_56891828("NFA182-9 char[1]")
NFA182_11_42264412("NFA182-11 char[1]")
NFA182_13_44835388("NFA182-13 char[1]")
NFA182_15_865310("NFA182-15 char[1]")
NFA182_17_7787796("NFA182-17 char[1]")
NFA182_19_2981301("NFA182-19 char[1]")
NFA182_21_26831716("NFA182-21 char[1]")
NFA182_23_40158857("NFA182-23 char[1]")
NFA182_25_25885397[\"NFA182-25 char[1]"/]
NFA182_26_36689279 -->|"i"|NFA182_1_61768055
NFA182_1_61768055 -->|"i"|NFA182_3_19041588
NFA182_3_19041588 -->|"m"|NFA182_5_37156565
NFA182_5_37156565 -->|"a"|NFA182_7_65973637
NFA182_7_65973637 -->|"g"|NFA182_9_56891828
NFA182_9_56891828 -->|"e"|NFA182_11_42264412
NFA182_11_42264412 -->|"2"|NFA182_13_44835388
NFA182_13_44835388 -->|"D"|NFA182_15_865310
NFA182_15_865310 -->|"A"|NFA182_17_7787796
NFA182_17_7787796 -->|"r"|NFA182_19_2981301
NFA182_19_2981301 -->|"r"|NFA182_21_26831716
NFA182_21_26831716 -->|"a"|NFA182_23_40158857
NFA182_23_40158857 -->|"y"|NFA182_25_25885397
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
subgraph DFA0_-1042454048["DFA0 regex start"]
NFA182_26_36689279_0("NFA182-26 regex start")
end
subgraph DFA1_935498374["DFA1 {1}"]
NFA182_1_61768055_1("NFA182-1 char[1]")
end
subgraph DFA2_-888528541["DFA2 {1}"]
NFA182_3_19041588_2("NFA182-3 char[1]")
end
subgraph DFA3_1935902313["DFA3 {1}"]
NFA182_5_37156565_3("NFA182-5 char[1]")
end
subgraph DFA4_267899524["DFA4 {1}"]
NFA182_7_65973637_4("NFA182-7 char[1]")
end
subgraph DFA5_-671997655["DFA5 {1}"]
NFA182_9_56891828_5("NFA182-9 char[1]")
end
subgraph DFA6_271017272["DFA6 {1}"]
NFA182_11_42264412_6("NFA182-11 char[1]")
end
subgraph DFA7_1381566605["DFA7 {1}"]
NFA182_13_44835388_7("NFA182-13 char[1]")
end
subgraph DFA8_-1009457784["DFA8 {1}"]
NFA182_15_865310_8("NFA182-15 char[1]")
end
subgraph DFA9_1147482045["DFA9 {1}"]
NFA182_17_7787796_9("NFA182-17 char[1]")
end
subgraph DFA10_708138150["DFA10 {1}"]
NFA182_19_2981301_10("NFA182-19 char[1]")
end
subgraph DFA11_2074888035["DFA11 {1}"]
NFA182_21_26831716_11("NFA182-21 char[1]")
end
subgraph DFA12_-2040624716["DFA12 {1}"]
NFA182_23_40158857_12("NFA182-23 char[1]")
end
subgraph DFA13_-1242650989["DFA13 {1}"]
NFA182_25_25885397_13[\"NFA182-25 char[1]"/]
end
DFA0_-1042454048 -->|"i"|DFA1_935498374
DFA1_935498374 -->|"i"|DFA2_-888528541
DFA2_-888528541 -->|"m"|DFA3_1935902313
DFA3_1935902313 -->|"a"|DFA4_267899524
DFA4_267899524 -->|"g"|DFA5_-671997655
DFA5_-671997655 -->|"e"|DFA6_271017272
DFA6_271017272 -->|"2"|DFA7_1381566605
DFA7_1381566605 -->|"D"|DFA8_-1009457784
DFA8_-1009457784 -->|"A"|DFA9_1147482045
DFA9_1147482045 -->|"r"|DFA10_708138150
DFA10_708138150 -->|"r"|DFA11_2074888035
DFA11_2074888035 -->|"a"|DFA12_-2040624716
DFA12_-2040624716 -->|"y"|DFA13_-1242650989
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
DFA0_-1042454048{{"DFA0 regex start"}}
DFA1_935498374{{"DFA1 {1}"}}
DFA2_-888528541{{"DFA2 {1}"}}
DFA3_1935902313{{"DFA3 {1}"}}
DFA4_267899524{{"DFA4 {1}"}}
DFA5_-671997655{{"DFA5 {1}"}}
DFA6_271017272{{"DFA6 {1}"}}
DFA7_1381566605{{"DFA7 {1}"}}
DFA8_-1009457784{{"DFA8 {1}"}}
DFA9_1147482045{{"DFA9 {1}"}}
DFA10_708138150{{"DFA10 {1}"}}
DFA11_2074888035{{"DFA11 {1}"}}
DFA12_-2040624716{{"DFA12 {1}"}}
DFA13_-1242650989[\"DFA13 {1}"/]
DFA0_-1042454048 -->|"i"|DFA1_935498374
DFA1_935498374 -->|"i"|DFA2_-888528541
DFA2_-888528541 -->|"m"|DFA3_1935902313
DFA3_1935902313 -->|"a"|DFA4_267899524
DFA4_267899524 -->|"g"|DFA5_-671997655
DFA5_-671997655 -->|"e"|DFA6_271017272
DFA6_271017272 -->|"2"|DFA7_1381566605
DFA7_1381566605 -->|"D"|DFA8_-1009457784
DFA8_-1009457784 -->|"A"|DFA9_1147482045
DFA9_1147482045 -->|"r"|DFA10_708138150
DFA10_708138150 -->|"r"|DFA11_2074888035
DFA11_2074888035 -->|"a"|DFA12_-2040624716
DFA12_-2040624716 -->|"y"|DFA13_-1242650989
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
subgraph MiniDFA0_-1495404281["MiniDFA0 {1}"]
DFA0_-1042454048_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_686841556["MiniDFA1 {1}"]
DFA1_935498374_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1241671754["MiniDFA2 {1}"]
DFA2_-888528541_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1105729298["MiniDFA3 {1}"]
DFA3_1935902313_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1621934040["MiniDFA5 {1}"]
DFA4_267899524_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1892065047["MiniDFA6 {1}"]
DFA5_-671997655_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1247656688["MiniDFA7 {1}"]
DFA6_271017272_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1794164957["MiniDFA8 {1}"]
DFA7_1381566605_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_1111422998["MiniDFA9 {1}"]
DFA8_-1009457784_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-636327300["MiniDFA10 {1}"]
DFA9_1147482045_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-172778702["MiniDFA11 {1}"]
DFA10_708138150_10{{"DFA10 {1}"}}
end
subgraph MiniDFA4_1218199411["MiniDFA4 {1}"]
DFA11_2074888035_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_2065698851["MiniDFA12 {1}"]
DFA12_-2040624716_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_1875761456["MiniDFA13 {1}"]
DFA13_-1242650989_13[\"DFA13 {1}"/]
end
MiniDFA0_-1495404281 -->|"i"|MiniDFA1_686841556
MiniDFA1_686841556 -->|"i"|MiniDFA2_1241671754
MiniDFA2_1241671754 -->|"m"|MiniDFA3_1105729298
MiniDFA3_1105729298 -->|"a"|MiniDFA5_-1621934040
MiniDFA5_-1621934040 -->|"g"|MiniDFA6_-1892065047
MiniDFA6_-1892065047 -->|"e"|MiniDFA7_1247656688
MiniDFA7_1247656688 -->|"2"|MiniDFA8_-1794164957
MiniDFA8_-1794164957 -->|"D"|MiniDFA9_1111422998
MiniDFA9_1111422998 -->|"A"|MiniDFA10_-636327300
MiniDFA10_-636327300 -->|"r"|MiniDFA11_-172778702
MiniDFA11_-172778702 -->|"r"|MiniDFA4_1218199411
MiniDFA4_1218199411 -->|"a"|MiniDFA12_2065698851
MiniDFA12_2065698851 -->|"y"|MiniDFA13_1875761456
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
MiniDFA0_-1495404281(["MiniDFA0 {1}"])
MiniDFA1_686841556(["MiniDFA1 {1}"])
MiniDFA2_1241671754(["MiniDFA2 {1}"])
MiniDFA3_1105729298(["MiniDFA3 {1}"])
MiniDFA5_-1621934040(["MiniDFA5 {1}"])
MiniDFA6_-1892065047(["MiniDFA6 {1}"])
MiniDFA7_1247656688(["MiniDFA7 {1}"])
MiniDFA8_-1794164957(["MiniDFA8 {1}"])
MiniDFA9_1111422998(["MiniDFA9 {1}"])
MiniDFA10_-636327300(["MiniDFA10 {1}"])
MiniDFA11_-172778702(["MiniDFA11 {1}"])
MiniDFA4_1218199411(["MiniDFA4 {1}"])
MiniDFA12_2065698851(["MiniDFA12 {1}"])
MiniDFA13_1875761456[\"MiniDFA13 {1}"/]
MiniDFA0_-1495404281 -->|"i"|MiniDFA1_686841556
MiniDFA1_686841556 -->|"i"|MiniDFA2_1241671754
MiniDFA2_1241671754 -->|"m"|MiniDFA3_1105729298
MiniDFA3_1105729298 -->|"a"|MiniDFA5_-1621934040
MiniDFA5_-1621934040 -->|"g"|MiniDFA6_-1892065047
MiniDFA6_-1892065047 -->|"e"|MiniDFA7_1247656688
MiniDFA7_1247656688 -->|"2"|MiniDFA8_-1794164957
MiniDFA8_-1794164957 -->|"D"|MiniDFA9_1111422998
MiniDFA9_1111422998 -->|"A"|MiniDFA10_-636327300
MiniDFA10_-636327300 -->|"r"|MiniDFA11_-172778702
MiniDFA11_-172778702 -->|"r"|MiniDFA4_1218199411
MiniDFA4_1218199411 -->|"a"|MiniDFA12_2065698851
MiniDFA12_2065698851 -->|"y"|MiniDFA13_1875761456
```
-------------------------------
