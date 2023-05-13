# 'samplerCubeArray'

pattern: `samplerCubeArray`

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
eNFA131_32_61770902[["εNFA131-32 regex start"]]
eNFA131_0_19067212[["εNFA131-0 char{1, 1}"]]
eNFA131_1_37387180[["εNFA131-1 char[1]"]]
eNFA131_2_940305[["εNFA131-2 char{1, 1}"]]
eNFA131_3_8462746[["εNFA131-3 char[1]"]]
eNFA131_4_9055858[["εNFA131-4 char{1, 1}"]]
eNFA131_5_14393865[["εNFA131-5 char[1]"]]
eNFA131_6_62435929[["εNFA131-6 char{1, 1}"]]
eNFA131_7_25052449[["εNFA131-7 char[1]"]]
eNFA131_8_24145451[["εNFA131-8 char{1, 1}"]]
eNFA131_9_15982473[["εNFA131-9 char[1]"]]
eNFA131_10_9624530[["εNFA131-10 char{1, 1}"]]
eNFA131_11_19511913[["εNFA131-11 char[1]"]]
eNFA131_12_41389494[["εNFA131-12 char{1, 1}"]]
eNFA131_13_36961130[["εNFA131-13 char[1]"]]
eNFA131_14_64214718[["εNFA131-14 char{1, 1}"]]
eNFA131_15_41061555[["εNFA131-15 char[1]"]]
eNFA131_16_34009683[["εNFA131-16 char{1, 1}"]]
eNFA131_17_37651693[["εNFA131-17 char[1]"]]
eNFA131_18_3320924[["εNFA131-18 char{1, 1}"]]
eNFA131_19_29888320[["εNFA131-19 char[1]"]]
eNFA131_20_559426[["εNFA131-20 char{1, 1}"]]
eNFA131_21_5034835[["εNFA131-21 char[1]"]]
eNFA131_22_45313516[["εNFA131-22 char{1, 1}"]]
eNFA131_23_5168462[["εNFA131-23 char[1]"]]
eNFA131_24_46516162[["εNFA131-24 char{1, 1}"]]
eNFA131_25_15992282[["εNFA131-25 char[1]"]]
eNFA131_26_9712814[["εNFA131-26 char{1, 1}"]]
eNFA131_27_20306462[["εNFA131-27 char[1]"]]
eNFA131_28_48540437[["εNFA131-28 char{1, 1}"]]
eNFA131_29_34210755[["εNFA131-29 char[1]"]]
eNFA131_30_39461345[["εNFA131-30 char{1, 1}"]]
eNFA131_31_19607793[["εNFA131-31 char[1]"]]
eNFA131_33_42252410[["εNFA131-33 regex end"]]
eNFA131_34_44727375[["εNFA131-34 post-regex start"]]
eNFA131_35_67002055[\"εNFA131-35 post-regex end"/]
eNFA131_32_61770902 -.->|"ε"|eNFA131_0_19067212
eNFA131_0_19067212 -->|"s"|eNFA131_1_37387180
eNFA131_1_37387180 -.->|"ε"|eNFA131_2_940305
eNFA131_2_940305 -->|"a"|eNFA131_3_8462746
eNFA131_3_8462746 -.->|"ε"|eNFA131_4_9055858
eNFA131_4_9055858 -->|"m"|eNFA131_5_14393865
eNFA131_5_14393865 -.->|"ε"|eNFA131_6_62435929
eNFA131_6_62435929 -->|"p"|eNFA131_7_25052449
eNFA131_7_25052449 -.->|"ε"|eNFA131_8_24145451
eNFA131_8_24145451 -->|"l"|eNFA131_9_15982473
eNFA131_9_15982473 -.->|"ε"|eNFA131_10_9624530
eNFA131_10_9624530 -->|"e"|eNFA131_11_19511913
eNFA131_11_19511913 -.->|"ε"|eNFA131_12_41389494
eNFA131_12_41389494 -->|"r"|eNFA131_13_36961130
eNFA131_13_36961130 -.->|"ε"|eNFA131_14_64214718
eNFA131_14_64214718 -->|"C"|eNFA131_15_41061555
eNFA131_15_41061555 -.->|"ε"|eNFA131_16_34009683
eNFA131_16_34009683 -->|"u"|eNFA131_17_37651693
eNFA131_17_37651693 -.->|"ε"|eNFA131_18_3320924
eNFA131_18_3320924 -->|"b"|eNFA131_19_29888320
eNFA131_19_29888320 -.->|"ε"|eNFA131_20_559426
eNFA131_20_559426 -->|"e"|eNFA131_21_5034835
eNFA131_21_5034835 -.->|"ε"|eNFA131_22_45313516
eNFA131_22_45313516 -->|"A"|eNFA131_23_5168462
eNFA131_23_5168462 -.->|"ε"|eNFA131_24_46516162
eNFA131_24_46516162 -->|"r"|eNFA131_25_15992282
eNFA131_25_15992282 -.->|"ε"|eNFA131_26_9712814
eNFA131_26_9712814 -->|"r"|eNFA131_27_20306462
eNFA131_27_20306462 -.->|"ε"|eNFA131_28_48540437
eNFA131_28_48540437 -->|"a"|eNFA131_29_34210755
eNFA131_29_34210755 -.->|"ε"|eNFA131_30_39461345
eNFA131_30_39461345 -->|"y"|eNFA131_31_19607793
eNFA131_31_19607793 -.->|"ε"|eNFA131_33_42252410
eNFA131_33_42252410 -.->|"ε"|eNFA131_34_44727375
eNFA131_34_44727375 -.->|"ε"|eNFA131_35_67002055
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
eNFA131_32_66147589[["εNFA131-32 regex start"]]
eNFA131_0_58457393[["εNFA131-0 char{1, 1}"]]
eNFA131_1_56354492[["εNFA131-1 char[1]"]]
eNFA131_2_37428383[["εNFA131-2 char{1, 1}"]]
eNFA131_3_1311131[["εNFA131-3 char[1]"]]
eNFA131_4_11800186[["εNFA131-4 char{1, 1}"]]
eNFA131_5_39092811[["εNFA131-5 char[1]"]]
eNFA131_6_16290985[["εNFA131-6 char{1, 1}"]]
eNFA131_7_12401140[["εNFA131-7 char[1]"]]
eNFA131_8_44501397[["εNFA131-8 char{1, 1}"]]
eNFA131_9_64968253[["εNFA131-9 char[1]"]]
eNFA131_10_47843365[["εNFA131-10 char{1, 1}"]]
eNFA131_11_27937102[["εNFA131-11 char[1]"]]
eNFA131_12_50107329[["εNFA131-12 char{1, 1}"]]
eNFA131_13_48312784[["εNFA131-13 char[1]"]]
eNFA131_14_32161874[["εNFA131-14 char{1, 1}"]]
eNFA131_15_21021418[["εNFA131-15 char[1]"]]
eNFA131_16_54975040[["εNFA131-16 char{1, 1}"]]
eNFA131_17_25013317[["εNFA131-17 char[1]"]]
eNFA131_18_23793266[["εNFA131-18 char{1, 1}"]]
eNFA131_19_12812809[["εNFA131-19 char[1]"]]
eNFA131_20_48206417[["εNFA131-20 char{1, 1}"]]
eNFA131_21_31204572[["εNFA131-21 char[1]"]]
eNFA131_22_12405700[["εNFA131-22 char{1, 1}"]]
eNFA131_23_44542441[["εNFA131-23 char[1]"]]
eNFA131_24_65337652[["εNFA131-24 char{1, 1}"]]
eNFA131_25_51167958[["εNFA131-25 char[1]"]]
eNFA131_26_57858440[["εNFA131-26 char{1, 1}"]]
eNFA131_27_50963915[["εNFA131-27 char[1]"]]
eNFA131_28_56022057[["εNFA131-28 char{1, 1}"]]
eNFA131_29_34436465[["εNFA131-29 char[1]"]]
eNFA131_30_41492734[["εNFA131-30 char{1, 1}"]]
eNFA131_31_37890287[\"εNFA131-31 char[1]"/]
eNFA131_33_5468271[\"εNFA131-33 regex end"/]
eNFA131_34_49214446[\"εNFA131-34 post-regex start"/]
eNFA131_35_40276838[\"εNFA131-35 post-regex end"/]
eNFA131_32_66147589 -.->|"ε"|eNFA131_0_58457393
eNFA131_32_66147589 -->|"s"|eNFA131_1_56354492
eNFA131_0_58457393 -->|"s"|eNFA131_1_56354492
eNFA131_1_56354492 -.->|"ε"|eNFA131_2_37428383
eNFA131_1_56354492 -->|"a"|eNFA131_3_1311131
eNFA131_2_37428383 -->|"a"|eNFA131_3_1311131
eNFA131_3_1311131 -.->|"ε"|eNFA131_4_11800186
eNFA131_3_1311131 -->|"m"|eNFA131_5_39092811
eNFA131_4_11800186 -->|"m"|eNFA131_5_39092811
eNFA131_5_39092811 -.->|"ε"|eNFA131_6_16290985
eNFA131_5_39092811 -->|"p"|eNFA131_7_12401140
eNFA131_6_16290985 -->|"p"|eNFA131_7_12401140
eNFA131_7_12401140 -.->|"ε"|eNFA131_8_44501397
eNFA131_7_12401140 -->|"l"|eNFA131_9_64968253
eNFA131_8_44501397 -->|"l"|eNFA131_9_64968253
eNFA131_9_64968253 -.->|"ε"|eNFA131_10_47843365
eNFA131_9_64968253 -->|"e"|eNFA131_11_27937102
eNFA131_10_47843365 -->|"e"|eNFA131_11_27937102
eNFA131_11_27937102 -.->|"ε"|eNFA131_12_50107329
eNFA131_11_27937102 -->|"r"|eNFA131_13_48312784
eNFA131_12_50107329 -->|"r"|eNFA131_13_48312784
eNFA131_13_48312784 -.->|"ε"|eNFA131_14_32161874
eNFA131_13_48312784 -->|"C"|eNFA131_15_21021418
eNFA131_14_32161874 -->|"C"|eNFA131_15_21021418
eNFA131_15_21021418 -.->|"ε"|eNFA131_16_54975040
eNFA131_15_21021418 -->|"u"|eNFA131_17_25013317
eNFA131_16_54975040 -->|"u"|eNFA131_17_25013317
eNFA131_17_25013317 -.->|"ε"|eNFA131_18_23793266
eNFA131_17_25013317 -->|"b"|eNFA131_19_12812809
eNFA131_18_23793266 -->|"b"|eNFA131_19_12812809
eNFA131_19_12812809 -.->|"ε"|eNFA131_20_48206417
eNFA131_19_12812809 -->|"e"|eNFA131_21_31204572
eNFA131_20_48206417 -->|"e"|eNFA131_21_31204572
eNFA131_21_31204572 -.->|"ε"|eNFA131_22_12405700
eNFA131_21_31204572 -->|"A"|eNFA131_23_44542441
eNFA131_22_12405700 -->|"A"|eNFA131_23_44542441
eNFA131_23_44542441 -.->|"ε"|eNFA131_24_65337652
eNFA131_23_44542441 -->|"r"|eNFA131_25_51167958
eNFA131_24_65337652 -->|"r"|eNFA131_25_51167958
eNFA131_25_51167958 -.->|"ε"|eNFA131_26_57858440
eNFA131_25_51167958 -->|"r"|eNFA131_27_50963915
eNFA131_26_57858440 -->|"r"|eNFA131_27_50963915
eNFA131_27_50963915 -.->|"ε"|eNFA131_28_56022057
eNFA131_27_50963915 -->|"a"|eNFA131_29_34436465
eNFA131_28_56022057 -->|"a"|eNFA131_29_34436465
eNFA131_29_34436465 -.->|"ε"|eNFA131_30_41492734
eNFA131_29_34436465 -->|"y"|eNFA131_31_37890287
eNFA131_30_41492734 -->|"y"|eNFA131_31_37890287
eNFA131_31_37890287 -.->|"ε"|eNFA131_33_5468271
eNFA131_31_37890287 -.->|"ε"|eNFA131_34_49214446
eNFA131_31_37890287 -.->|"ε"|eNFA131_35_40276838
eNFA131_33_5468271 -.->|"ε"|eNFA131_34_49214446
eNFA131_33_5468271 -.->|"ε"|eNFA131_35_40276838
eNFA131_34_49214446 -.->|"ε"|eNFA131_35_40276838
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
NFA131_32_26947222("NFA131-32 regex start")
NFA131_1_41198408("NFA131-1 char[1]")
NFA131_3_35241358("NFA131-3 char[1]")
NFA131_5_48736767("NFA131-5 char[1]")
NFA131_7_35977726("NFA131-7 char[1]")
NFA131_9_55364083("NFA131-9 char[1]")
NFA131_11_28514703("NFA131-11 char[1]")
NFA131_13_55305739("NFA131-13 char[1]")
NFA131_15_27989608("NFA131-15 char[1]")
NFA131_17_50579888("NFA131-17 char[1]")
NFA131_19_52565810("NFA131-19 char[1]")
NFA131_21_3330249("NFA131-21 char[1]")
NFA131_23_29972245("NFA131-23 char[1]")
NFA131_25_1314751("NFA131-25 char[1]")
NFA131_27_11832760("NFA131-27 char[1]")
NFA131_29_39385977("NFA131-29 char[1]")
NFA131_31_18929475[\"NFA131-31 char[1]"/]
NFA131_32_26947222 -->|"s"|NFA131_1_41198408
NFA131_1_41198408 -->|"a"|NFA131_3_35241358
NFA131_3_35241358 -->|"m"|NFA131_5_48736767
NFA131_5_48736767 -->|"p"|NFA131_7_35977726
NFA131_7_35977726 -->|"l"|NFA131_9_55364083
NFA131_9_55364083 -->|"e"|NFA131_11_28514703
NFA131_11_28514703 -->|"r"|NFA131_13_55305739
NFA131_13_55305739 -->|"C"|NFA131_15_27989608
NFA131_15_27989608 -->|"u"|NFA131_17_50579888
NFA131_17_50579888 -->|"b"|NFA131_19_52565810
NFA131_19_52565810 -->|"e"|NFA131_21_3330249
NFA131_21_3330249 -->|"A"|NFA131_23_29972245
NFA131_23_29972245 -->|"r"|NFA131_25_1314751
NFA131_25_1314751 -->|"r"|NFA131_27_11832760
NFA131_27_11832760 -->|"a"|NFA131_29_39385977
NFA131_29_39385977 -->|"y"|NFA131_31_18929475
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
subgraph DFA0_328253352["DFA0 regex start"]
NFA131_32_26947222_0("NFA131-32 regex start")
end
subgraph DFA1_-1775933762["DFA1 {1}"]
NFA131_1_41198408_1("NFA131-1 char[1]")
end
subgraph DFA2_-969478200["DFA2 {1}"]
NFA131_3_35241358_2("NFA131-3 char[1]")
end
subgraph DFA3_897060794["DFA3 {1}"]
NFA131_5_48736767_3("NFA131-5 char[1]")
end
subgraph DFA4_726670079["DFA4 {1}"]
NFA131_7_35977726_4("NFA131-7 char[1]")
end
subgraph DFA5_-1946568132["DFA5 {1}"]
NFA131_9_55364083_5("NFA131-9 char[1]")
end
subgraph DFA6_-1029884332["DFA6 {1}"]
NFA131_11_28514703_6("NFA131-11 char[1]")
end
subgraph DFA7_647358237["DFA7 {1}"]
NFA131_13_55305739_7("NFA131-13 char[1]")
end
subgraph DFA8_1029557338["DFA8 {1}"]
NFA131_15_27989608_8("NFA131-15 char[1]")
end
subgraph DFA9_-1901332481["DFA9 {1}"]
NFA131_17_50579888_9("NFA131-17 char[1]")
end
subgraph DFA10_228960925["DFA10 {1}"]
NFA131_19_52565810_10("NFA131-19 char[1]")
end
subgraph DFA11_-1839231304["DFA11 {1}"]
NFA131_21_3330249_11("NFA131-21 char[1]")
end
subgraph DFA12_1583585022["DFA12 {1}"]
NFA131_23_29972245_12("NFA131-23 char[1]")
end
subgraph DFA13_-1400060043["DFA13 {1}"]
NFA131_25_1314751_13("NFA131-25 char[1]")
end
subgraph DFA14_-1623303102["DFA14 {1}"]
NFA131_27_11832760_14("NFA131-27 char[1]")
end
subgraph DFA15_-1650721452["DFA15 {1}"]
NFA131_29_39385977_15("NFA131-29 char[1]")
end
subgraph DFA16_-27280738["DFA16 {1}"]
NFA131_31_18929475_16[\"NFA131-31 char[1]"/]
end
DFA0_328253352 -->|"s"|DFA1_-1775933762
DFA1_-1775933762 -->|"a"|DFA2_-969478200
DFA2_-969478200 -->|"m"|DFA3_897060794
DFA3_897060794 -->|"p"|DFA4_726670079
DFA4_726670079 -->|"l"|DFA5_-1946568132
DFA5_-1946568132 -->|"e"|DFA6_-1029884332
DFA6_-1029884332 -->|"r"|DFA7_647358237
DFA7_647358237 -->|"C"|DFA8_1029557338
DFA8_1029557338 -->|"u"|DFA9_-1901332481
DFA9_-1901332481 -->|"b"|DFA10_228960925
DFA10_228960925 -->|"e"|DFA11_-1839231304
DFA11_-1839231304 -->|"A"|DFA12_1583585022
DFA12_1583585022 -->|"r"|DFA13_-1400060043
DFA13_-1400060043 -->|"r"|DFA14_-1623303102
DFA14_-1623303102 -->|"a"|DFA15_-1650721452
DFA15_-1650721452 -->|"y"|DFA16_-27280738
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
DFA0_328253352{{"DFA0 regex start"}}
DFA1_-1775933762{{"DFA1 {1}"}}
DFA2_-969478200{{"DFA2 {1}"}}
DFA3_897060794{{"DFA3 {1}"}}
DFA4_726670079{{"DFA4 {1}"}}
DFA5_-1946568132{{"DFA5 {1}"}}
DFA6_-1029884332{{"DFA6 {1}"}}
DFA7_647358237{{"DFA7 {1}"}}
DFA8_1029557338{{"DFA8 {1}"}}
DFA9_-1901332481{{"DFA9 {1}"}}
DFA10_228960925{{"DFA10 {1}"}}
DFA11_-1839231304{{"DFA11 {1}"}}
DFA12_1583585022{{"DFA12 {1}"}}
DFA13_-1400060043{{"DFA13 {1}"}}
DFA14_-1623303102{{"DFA14 {1}"}}
DFA15_-1650721452{{"DFA15 {1}"}}
DFA16_-27280738[\"DFA16 {1}"/]
DFA0_328253352 -->|"s"|DFA1_-1775933762
DFA1_-1775933762 -->|"a"|DFA2_-969478200
DFA2_-969478200 -->|"m"|DFA3_897060794
DFA3_897060794 -->|"p"|DFA4_726670079
DFA4_726670079 -->|"l"|DFA5_-1946568132
DFA5_-1946568132 -->|"e"|DFA6_-1029884332
DFA6_-1029884332 -->|"r"|DFA7_647358237
DFA7_647358237 -->|"C"|DFA8_1029557338
DFA8_1029557338 -->|"u"|DFA9_-1901332481
DFA9_-1901332481 -->|"b"|DFA10_228960925
DFA10_228960925 -->|"e"|DFA11_-1839231304
DFA11_-1839231304 -->|"A"|DFA12_1583585022
DFA12_1583585022 -->|"r"|DFA13_-1400060043
DFA13_-1400060043 -->|"r"|DFA14_-1623303102
DFA14_-1623303102 -->|"a"|DFA15_-1650721452
DFA15_-1650721452 -->|"y"|DFA16_-27280738
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
subgraph MiniDFA0_2111363723["MiniDFA0 {1}"]
DFA0_328253352_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_682121670["MiniDFA1 {1}"]
DFA1_-1775933762_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-1187961837["MiniDFA3 {1}"]
DFA2_-969478200_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-1265294678["MiniDFA4 {1}"]
DFA3_897060794_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_1508513796["MiniDFA5 {1}"]
DFA4_726670079_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_808067301["MiniDFA6 {1}"]
DFA5_-1946568132_5{{"DFA5 {1}"}}
end
subgraph MiniDFA8_-1152992627["MiniDFA8 {1}"]
DFA6_-1029884332_6{{"DFA6 {1}"}}
end
subgraph MiniDFA11_132331798["MiniDFA11 {1}"]
DFA7_647358237_7{{"DFA7 {1}"}}
end
subgraph MiniDFA12_-871433418["MiniDFA12 {1}"]
DFA8_1029557338_8{{"DFA8 {1}"}}
end
subgraph MiniDFA13_-193716778["MiniDFA13 {1}"]
DFA9_-1901332481_9{{"DFA9 {1}"}}
end
subgraph MiniDFA7_-236396527["MiniDFA7 {1}"]
DFA10_228960925_10{{"DFA10 {1}"}}
end
subgraph MiniDFA14_1471005309["MiniDFA14 {1}"]
DFA11_-1839231304_11{{"DFA11 {1}"}}
end
subgraph MiniDFA9_-878701693["MiniDFA9 {1}"]
DFA12_1583585022_12{{"DFA12 {1}"}}
end
subgraph MiniDFA10_485291148["MiniDFA10 {1}"]
DFA13_-1400060043_13{{"DFA13 {1}"}}
end
subgraph MiniDFA2_-923406052["MiniDFA2 {1}"]
DFA14_-1623303102_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_611007718["MiniDFA15 {1}"]
DFA15_-1650721452_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_35104262["MiniDFA16 {1}"]
DFA16_-27280738_16[\"DFA16 {1}"/]
end
MiniDFA0_2111363723 -->|"s"|MiniDFA1_682121670
MiniDFA1_682121670 -->|"a"|MiniDFA3_-1187961837
MiniDFA3_-1187961837 -->|"m"|MiniDFA4_-1265294678
MiniDFA4_-1265294678 -->|"p"|MiniDFA5_1508513796
MiniDFA5_1508513796 -->|"l"|MiniDFA6_808067301
MiniDFA6_808067301 -->|"e"|MiniDFA8_-1152992627
MiniDFA8_-1152992627 -->|"r"|MiniDFA11_132331798
MiniDFA11_132331798 -->|"C"|MiniDFA12_-871433418
MiniDFA12_-871433418 -->|"u"|MiniDFA13_-193716778
MiniDFA13_-193716778 -->|"b"|MiniDFA7_-236396527
MiniDFA7_-236396527 -->|"e"|MiniDFA14_1471005309
MiniDFA14_1471005309 -->|"A"|MiniDFA9_-878701693
MiniDFA9_-878701693 -->|"r"|MiniDFA10_485291148
MiniDFA10_485291148 -->|"r"|MiniDFA2_-923406052
MiniDFA2_-923406052 -->|"a"|MiniDFA15_611007718
MiniDFA15_611007718 -->|"y"|MiniDFA16_35104262
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
MiniDFA0_2111363723(["MiniDFA0 {1}"])
MiniDFA1_682121670(["MiniDFA1 {1}"])
MiniDFA3_-1187961837(["MiniDFA3 {1}"])
MiniDFA4_-1265294678(["MiniDFA4 {1}"])
MiniDFA5_1508513796(["MiniDFA5 {1}"])
MiniDFA6_808067301(["MiniDFA6 {1}"])
MiniDFA8_-1152992627(["MiniDFA8 {1}"])
MiniDFA11_132331798(["MiniDFA11 {1}"])
MiniDFA12_-871433418(["MiniDFA12 {1}"])
MiniDFA13_-193716778(["MiniDFA13 {1}"])
MiniDFA7_-236396527(["MiniDFA7 {1}"])
MiniDFA14_1471005309(["MiniDFA14 {1}"])
MiniDFA9_-878701693(["MiniDFA9 {1}"])
MiniDFA10_485291148(["MiniDFA10 {1}"])
MiniDFA2_-923406052(["MiniDFA2 {1}"])
MiniDFA15_611007718(["MiniDFA15 {1}"])
MiniDFA16_35104262[\"MiniDFA16 {1}"/]
MiniDFA0_2111363723 -->|"s"|MiniDFA1_682121670
MiniDFA1_682121670 -->|"a"|MiniDFA3_-1187961837
MiniDFA3_-1187961837 -->|"m"|MiniDFA4_-1265294678
MiniDFA4_-1265294678 -->|"p"|MiniDFA5_1508513796
MiniDFA5_1508513796 -->|"l"|MiniDFA6_808067301
MiniDFA6_808067301 -->|"e"|MiniDFA8_-1152992627
MiniDFA8_-1152992627 -->|"r"|MiniDFA11_132331798
MiniDFA11_132331798 -->|"C"|MiniDFA12_-871433418
MiniDFA12_-871433418 -->|"u"|MiniDFA13_-193716778
MiniDFA13_-193716778 -->|"b"|MiniDFA7_-236396527
MiniDFA7_-236396527 -->|"e"|MiniDFA14_1471005309
MiniDFA14_1471005309 -->|"A"|MiniDFA9_-878701693
MiniDFA9_-878701693 -->|"r"|MiniDFA10_485291148
MiniDFA10_485291148 -->|"r"|MiniDFA2_-923406052
MiniDFA2_-923406052 -->|"a"|MiniDFA15_611007718
MiniDFA15_611007718 -->|"y"|MiniDFA16_35104262
```
-------------------------------
