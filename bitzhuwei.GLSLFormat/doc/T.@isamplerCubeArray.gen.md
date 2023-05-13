# 'isamplerCubeArray'

pattern: `isamplerCubeArray`

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
eNFA139_34_62463365[["εNFA139-34 regex start"]]
eNFA139_0_25299374[["εNFA139-0 char{1, 1}"]]
eNFA139_1_26367774[["εNFA139-1 char[1]"]]
eNFA139_2_35983374[["εNFA139-2 char{1, 1}"]]
eNFA139_3_55414911[["εNFA139-3 char[1]"]]
eNFA139_4_28972154[["εNFA139-4 char{1, 1}"]]
eNFA139_5_59422801[["εNFA139-5 char[1]"]]
eNFA139_6_65043163[["εNFA139-6 char{1, 1}"]]
eNFA139_7_48517563[["εNFA139-7 char[1]"]]
eNFA139_8_34004889[["εNFA139-8 char{1, 1}"]]
eNFA139_9_37608550[["εNFA139-9 char[1]"]]
eNFA139_10_2932635[["εNFA139-10 char{1, 1}"]]
eNFA139_11_26393722[["εNFA139-11 char[1]"]]
eNFA139_12_36216906[["εNFA139-12 char{1, 1}"]]
eNFA139_13_57516701[["εNFA139-13 char[1]"]]
eNFA139_14_47888269[["εNFA139-14 char{1, 1}"]]
eNFA139_15_28341242[["εNFA139-15 char[1]"]]
eNFA139_16_53744589[["εNFA139-16 char{1, 1}"]]
eNFA139_17_13939255[["εNFA139-17 char[1]"]]
eNFA139_18_58344433[["εNFA139-18 char{1, 1}"]]
eNFA139_19_55337852[["εNFA139-19 char[1]"]]
eNFA139_20_28278626[["εNFA139-20 char{1, 1}"]]
eNFA139_21_53181042[["εNFA139-21 char[1]"]]
eNFA139_22_8867335[["εNFA139-22 char{1, 1}"]]
eNFA139_23_12697152[["εNFA139-23 char[1]"]]
eNFA139_24_47165512[["εNFA139-24 char{1, 1}"]]
eNFA139_25_21836431[["εNFA139-25 char[1]"]]
eNFA139_26_62310159[["εNFA139-26 char{1, 1}"]]
eNFA139_27_23920519[["εNFA139-27 char[1]"]]
eNFA139_28_13958081[["εNFA139-28 char{1, 1}"]]
eNFA139_29_58513871[["εNFA139-29 char[1]"]]
eNFA139_30_56862792[["εNFA139-30 char{1, 1}"]]
eNFA139_31_42003087[["εNFA139-31 char[1]"]]
eNFA139_32_42483468[["εNFA139-32 char{1, 1}"]]
eNFA139_33_46806896[["εNFA139-33 char[1]"]]
eNFA139_35_18608884[["εNFA139-35 regex end"]]
eNFA139_36_33262233[["εNFA139-36 post-regex start"]]
eNFA139_37_30924649[\"εNFA139-37 post-regex end"/]
eNFA139_34_62463365 -.->|"ε"|eNFA139_0_25299374
eNFA139_0_25299374 -->|"i"|eNFA139_1_26367774
eNFA139_1_26367774 -.->|"ε"|eNFA139_2_35983374
eNFA139_2_35983374 -->|"s"|eNFA139_3_55414911
eNFA139_3_55414911 -.->|"ε"|eNFA139_4_28972154
eNFA139_4_28972154 -->|"a"|eNFA139_5_59422801
eNFA139_5_59422801 -.->|"ε"|eNFA139_6_65043163
eNFA139_6_65043163 -->|"m"|eNFA139_7_48517563
eNFA139_7_48517563 -.->|"ε"|eNFA139_8_34004889
eNFA139_8_34004889 -->|"p"|eNFA139_9_37608550
eNFA139_9_37608550 -.->|"ε"|eNFA139_10_2932635
eNFA139_10_2932635 -->|"l"|eNFA139_11_26393722
eNFA139_11_26393722 -.->|"ε"|eNFA139_12_36216906
eNFA139_12_36216906 -->|"e"|eNFA139_13_57516701
eNFA139_13_57516701 -.->|"ε"|eNFA139_14_47888269
eNFA139_14_47888269 -->|"r"|eNFA139_15_28341242
eNFA139_15_28341242 -.->|"ε"|eNFA139_16_53744589
eNFA139_16_53744589 -->|"C"|eNFA139_17_13939255
eNFA139_17_13939255 -.->|"ε"|eNFA139_18_58344433
eNFA139_18_58344433 -->|"u"|eNFA139_19_55337852
eNFA139_19_55337852 -.->|"ε"|eNFA139_20_28278626
eNFA139_20_28278626 -->|"b"|eNFA139_21_53181042
eNFA139_21_53181042 -.->|"ε"|eNFA139_22_8867335
eNFA139_22_8867335 -->|"e"|eNFA139_23_12697152
eNFA139_23_12697152 -.->|"ε"|eNFA139_24_47165512
eNFA139_24_47165512 -->|"A"|eNFA139_25_21836431
eNFA139_25_21836431 -.->|"ε"|eNFA139_26_62310159
eNFA139_26_62310159 -->|"r"|eNFA139_27_23920519
eNFA139_27_23920519 -.->|"ε"|eNFA139_28_13958081
eNFA139_28_13958081 -->|"r"|eNFA139_29_58513871
eNFA139_29_58513871 -.->|"ε"|eNFA139_30_56862792
eNFA139_30_56862792 -->|"a"|eNFA139_31_42003087
eNFA139_31_42003087 -.->|"ε"|eNFA139_32_42483468
eNFA139_32_42483468 -->|"y"|eNFA139_33_46806896
eNFA139_33_46806896 -.->|"ε"|eNFA139_35_18608884
eNFA139_35_18608884 -.->|"ε"|eNFA139_36_33262233
eNFA139_36_33262233 -.->|"ε"|eNFA139_37_30924649
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
eNFA139_34_9886387[["εNFA139-34 regex start"]]
eNFA139_0_21868626[["εNFA139-0 char{1, 1}"]]
eNFA139_1_62599910[["εNFA139-1 char[1]"]]
eNFA139_2_26528280[["εNFA139-2 char{1, 1}"]]
eNFA139_3_37427929[["εNFA139-3 char[1]"]]
eNFA139_4_1307042[["εNFA139-4 char{1, 1}"]]
eNFA139_5_11763380[["εNFA139-5 char[1]"]]
eNFA139_6_38761560[["εNFA139-6 char{1, 1}"]]
eNFA139_7_13309728[["εNFA139-7 char[1]"]]
eNFA139_8_52678692[["εNFA139-8 char{1, 1}"]]
eNFA139_9_4346180[["εNFA139-9 char[1]"]]
eNFA139_10_39115627[["εNFA139-10 char{1, 1}"]]
eNFA139_11_16496329[["εNFA139-11 char[1]"]]
eNFA139_12_14249239[["εNFA139-12 char{1, 1}"]]
eNFA139_13_61134295[["εNFA139-13 char[1]"]]
eNFA139_14_13337744[["εNFA139-14 char{1, 1}"]]
eNFA139_15_52930837[["εNFA139-15 char[1]"]]
eNFA139_16_6615485[["εNFA139-16 char{1, 1}"]]
eNFA139_17_59539371[["εNFA139-17 char[1]"]]
eNFA139_18_66092295[["εNFA139-18 char{1, 1}"]]
eNFA139_19_57959746[["εNFA139-19 char[1]"]]
eNFA139_20_51875669[["εNFA139-20 char{1, 1}"]]
eNFA139_21_64227841[["εNFA139-21 char[1]"]]
eNFA139_22_41179664[["εNFA139-22 char{1, 1}"]]
eNFA139_23_35072657[["εNFA139-23 char[1]"]]
eNFA139_24_47218463[["εNFA139-24 char{1, 1}"]]
eNFA139_25_22312986[["εNFA139-25 char[1]"]]
eNFA139_26_66599147[["εNFA139-26 char{1, 1}"]]
eNFA139_27_62521411[["εNFA139-27 char[1]"]]
eNFA139_28_25821787[["εNFA139-28 char{1, 1}"]]
eNFA139_29_31069492[["εNFA139-29 char[1]"]]
eNFA139_30_11189975[["εNFA139-30 char{1, 1}"]]
eNFA139_31_33600918[["εNFA139-31 char[1]"]]
eNFA139_32_33972808[["εNFA139-32 char{1, 1}"]]
eNFA139_33_37319824[\"εNFA139-33 char[1]"/]
eNFA139_35_334102[\"εNFA139-35 regex end"/]
eNFA139_36_3006923[\"εNFA139-36 post-regex start"/]
eNFA139_37_27062312[\"εNFA139-37 post-regex end"/]
eNFA139_34_9886387 -.->|"ε"|eNFA139_0_21868626
eNFA139_34_9886387 -->|"i"|eNFA139_1_62599910
eNFA139_0_21868626 -->|"i"|eNFA139_1_62599910
eNFA139_1_62599910 -.->|"ε"|eNFA139_2_26528280
eNFA139_1_62599910 -->|"s"|eNFA139_3_37427929
eNFA139_2_26528280 -->|"s"|eNFA139_3_37427929
eNFA139_3_37427929 -.->|"ε"|eNFA139_4_1307042
eNFA139_3_37427929 -->|"a"|eNFA139_5_11763380
eNFA139_4_1307042 -->|"a"|eNFA139_5_11763380
eNFA139_5_11763380 -.->|"ε"|eNFA139_6_38761560
eNFA139_5_11763380 -->|"m"|eNFA139_7_13309728
eNFA139_6_38761560 -->|"m"|eNFA139_7_13309728
eNFA139_7_13309728 -.->|"ε"|eNFA139_8_52678692
eNFA139_7_13309728 -->|"p"|eNFA139_9_4346180
eNFA139_8_52678692 -->|"p"|eNFA139_9_4346180
eNFA139_9_4346180 -.->|"ε"|eNFA139_10_39115627
eNFA139_9_4346180 -->|"l"|eNFA139_11_16496329
eNFA139_10_39115627 -->|"l"|eNFA139_11_16496329
eNFA139_11_16496329 -.->|"ε"|eNFA139_12_14249239
eNFA139_11_16496329 -->|"e"|eNFA139_13_61134295
eNFA139_12_14249239 -->|"e"|eNFA139_13_61134295
eNFA139_13_61134295 -.->|"ε"|eNFA139_14_13337744
eNFA139_13_61134295 -->|"r"|eNFA139_15_52930837
eNFA139_14_13337744 -->|"r"|eNFA139_15_52930837
eNFA139_15_52930837 -.->|"ε"|eNFA139_16_6615485
eNFA139_15_52930837 -->|"C"|eNFA139_17_59539371
eNFA139_16_6615485 -->|"C"|eNFA139_17_59539371
eNFA139_17_59539371 -.->|"ε"|eNFA139_18_66092295
eNFA139_17_59539371 -->|"u"|eNFA139_19_57959746
eNFA139_18_66092295 -->|"u"|eNFA139_19_57959746
eNFA139_19_57959746 -.->|"ε"|eNFA139_20_51875669
eNFA139_19_57959746 -->|"b"|eNFA139_21_64227841
eNFA139_20_51875669 -->|"b"|eNFA139_21_64227841
eNFA139_21_64227841 -.->|"ε"|eNFA139_22_41179664
eNFA139_21_64227841 -->|"e"|eNFA139_23_35072657
eNFA139_22_41179664 -->|"e"|eNFA139_23_35072657
eNFA139_23_35072657 -.->|"ε"|eNFA139_24_47218463
eNFA139_23_35072657 -->|"A"|eNFA139_25_22312986
eNFA139_24_47218463 -->|"A"|eNFA139_25_22312986
eNFA139_25_22312986 -.->|"ε"|eNFA139_26_66599147
eNFA139_25_22312986 -->|"r"|eNFA139_27_62521411
eNFA139_26_66599147 -->|"r"|eNFA139_27_62521411
eNFA139_27_62521411 -.->|"ε"|eNFA139_28_25821787
eNFA139_27_62521411 -->|"r"|eNFA139_29_31069492
eNFA139_28_25821787 -->|"r"|eNFA139_29_31069492
eNFA139_29_31069492 -.->|"ε"|eNFA139_30_11189975
eNFA139_29_31069492 -->|"a"|eNFA139_31_33600918
eNFA139_30_11189975 -->|"a"|eNFA139_31_33600918
eNFA139_31_33600918 -.->|"ε"|eNFA139_32_33972808
eNFA139_31_33600918 -->|"y"|eNFA139_33_37319824
eNFA139_32_33972808 -->|"y"|eNFA139_33_37319824
eNFA139_33_37319824 -.->|"ε"|eNFA139_35_334102
eNFA139_33_37319824 -.->|"ε"|eNFA139_36_3006923
eNFA139_33_37319824 -.->|"ε"|eNFA139_37_27062312
eNFA139_35_334102 -.->|"ε"|eNFA139_36_3006923
eNFA139_35_334102 -.->|"ε"|eNFA139_37_27062312
eNFA139_36_3006923 -.->|"ε"|eNFA139_37_27062312
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
NFA139_34_42234223("NFA139-34 regex start")
NFA139_1_44563687("NFA139-1 char[1]")
NFA139_3_65528866("NFA139-3 char[1]")
NFA139_5_52888890("NFA139-5 char[1]")
NFA139_7_6237967("NFA139-7 char[1]")
NFA139_9_56141706("NFA139-9 char[1]")
NFA139_11_35513308("NFA139-11 char[1]")
NFA139_13_51184318("NFA139-13 char[1]")
NFA139_15_58005681("NFA139-15 char[1]")
NFA139_17_52289087("NFA139-17 char[1]")
NFA139_19_839735("NFA139-19 char[1]")
NFA139_21_7557620("NFA139-21 char[1]")
NFA139_23_909717("NFA139-23 char[1]")
NFA139_25_8187461("NFA139-25 char[1]")
NFA139_27_6578292("NFA139-27 char[1]")
NFA139_29_59204636("NFA139-29 char[1]")
NFA139_31_63079676("NFA139-31 char[1]")
NFA139_33_30846174[\"NFA139-33 char[1]"/]
NFA139_34_42234223 -->|"i"|NFA139_1_44563687
NFA139_1_44563687 -->|"s"|NFA139_3_65528866
NFA139_3_65528866 -->|"a"|NFA139_5_52888890
NFA139_5_52888890 -->|"m"|NFA139_7_6237967
NFA139_7_6237967 -->|"p"|NFA139_9_56141706
NFA139_9_56141706 -->|"l"|NFA139_11_35513308
NFA139_11_35513308 -->|"e"|NFA139_13_51184318
NFA139_13_51184318 -->|"r"|NFA139_15_58005681
NFA139_15_58005681 -->|"C"|NFA139_17_52289087
NFA139_17_52289087 -->|"u"|NFA139_19_839735
NFA139_19_839735 -->|"b"|NFA139_21_7557620
NFA139_21_7557620 -->|"e"|NFA139_23_909717
NFA139_23_909717 -->|"A"|NFA139_25_8187461
NFA139_25_8187461 -->|"r"|NFA139_27_6578292
NFA139_27_6578292 -->|"r"|NFA139_29_59204636
NFA139_29_59204636 -->|"a"|NFA139_31_63079676
NFA139_31_63079676 -->|"y"|NFA139_33_30846174
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
subgraph DFA0_495186163["DFA0 regex start"]
NFA139_34_42234223_0("NFA139-34 regex start")
end
subgraph DFA1_1420605915["DFA1 {1}"]
NFA139_1_44563687_1("NFA139-1 char[1]")
end
subgraph DFA2_-545742529["DFA2 {1}"]
NFA139_3_65528866_2("NFA139-3 char[1]")
end
subgraph DFA3_-1804144022["DFA3 {1}"]
NFA139_5_52888890_3("NFA139-5 char[1]")
end
subgraph DFA4_-1342006446["DFA4 {1}"]
NFA139_7_6237967_4("NFA139-7 char[1]")
end
subgraph DFA5_-1114918140["DFA5 {1}"]
NFA139_9_56141706_5("NFA139-9 char[1]")
end
subgraph DFA6_-1278182545["DFA6 {1}"]
NFA139_11_35513308_6("NFA139-11 char[1]")
end
subgraph DFA7_-214189934["DFA7 {1}"]
NFA139_13_51184318_7("NFA139-13 char[1]")
end
subgraph DFA8_1293489638["DFA8 {1}"]
NFA139_15_58005681_8("NFA139-15 char[1]")
end
subgraph DFA9_543891271["DFA9 {1}"]
NFA139_17_52289087_9("NFA139-17 char[1]")
end
subgraph DFA10_-1935089846["DFA10 {1}"]
NFA139_19_839735_10("NFA139-19 char[1]")
end
subgraph DFA11_1301402748["DFA11 {1}"]
NFA139_21_7557620_11("NFA139-21 char[1]")
end
subgraph DFA12_377073063["DFA12 {1}"]
NFA139_23_909717_12("NFA139-23 char[1]")
end
subgraph DFA13_-493320774["DFA13 {1}"]
NFA139_25_8187461_13("NFA139-25 char[1]")
end
subgraph DFA14_-294468779["DFA14 {1}"]
NFA139_27_6578292_14("NFA139-27 char[1]")
end
subgraph DFA15_-693751363["DFA15 {1}"]
NFA139_29_59204636_15("NFA139-29 char[1]")
end
subgraph DFA16_1934320728["DFA16 {1}"]
NFA139_31_63079676_16("NFA139-31 char[1]")
end
subgraph DFA17_-381058106["DFA17 {1}"]
NFA139_33_30846174_17[\"NFA139-33 char[1]"/]
end
DFA0_495186163 -->|"i"|DFA1_1420605915
DFA1_1420605915 -->|"s"|DFA2_-545742529
DFA2_-545742529 -->|"a"|DFA3_-1804144022
DFA3_-1804144022 -->|"m"|DFA4_-1342006446
DFA4_-1342006446 -->|"p"|DFA5_-1114918140
DFA5_-1114918140 -->|"l"|DFA6_-1278182545
DFA6_-1278182545 -->|"e"|DFA7_-214189934
DFA7_-214189934 -->|"r"|DFA8_1293489638
DFA8_1293489638 -->|"C"|DFA9_543891271
DFA9_543891271 -->|"u"|DFA10_-1935089846
DFA10_-1935089846 -->|"b"|DFA11_1301402748
DFA11_1301402748 -->|"e"|DFA12_377073063
DFA12_377073063 -->|"A"|DFA13_-493320774
DFA13_-493320774 -->|"r"|DFA14_-294468779
DFA14_-294468779 -->|"r"|DFA15_-693751363
DFA15_-693751363 -->|"a"|DFA16_1934320728
DFA16_1934320728 -->|"y"|DFA17_-381058106
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
DFA0_495186163{{"DFA0 regex start"}}
DFA1_1420605915{{"DFA1 {1}"}}
DFA2_-545742529{{"DFA2 {1}"}}
DFA3_-1804144022{{"DFA3 {1}"}}
DFA4_-1342006446{{"DFA4 {1}"}}
DFA5_-1114918140{{"DFA5 {1}"}}
DFA6_-1278182545{{"DFA6 {1}"}}
DFA7_-214189934{{"DFA7 {1}"}}
DFA8_1293489638{{"DFA8 {1}"}}
DFA9_543891271{{"DFA9 {1}"}}
DFA10_-1935089846{{"DFA10 {1}"}}
DFA11_1301402748{{"DFA11 {1}"}}
DFA12_377073063{{"DFA12 {1}"}}
DFA13_-493320774{{"DFA13 {1}"}}
DFA14_-294468779{{"DFA14 {1}"}}
DFA15_-693751363{{"DFA15 {1}"}}
DFA16_1934320728{{"DFA16 {1}"}}
DFA17_-381058106[\"DFA17 {1}"/]
DFA0_495186163 -->|"i"|DFA1_1420605915
DFA1_1420605915 -->|"s"|DFA2_-545742529
DFA2_-545742529 -->|"a"|DFA3_-1804144022
DFA3_-1804144022 -->|"m"|DFA4_-1342006446
DFA4_-1342006446 -->|"p"|DFA5_-1114918140
DFA5_-1114918140 -->|"l"|DFA6_-1278182545
DFA6_-1278182545 -->|"e"|DFA7_-214189934
DFA7_-214189934 -->|"r"|DFA8_1293489638
DFA8_1293489638 -->|"C"|DFA9_543891271
DFA9_543891271 -->|"u"|DFA10_-1935089846
DFA10_-1935089846 -->|"b"|DFA11_1301402748
DFA11_1301402748 -->|"e"|DFA12_377073063
DFA12_377073063 -->|"A"|DFA13_-493320774
DFA13_-493320774 -->|"r"|DFA14_-294468779
DFA14_-294468779 -->|"r"|DFA15_-693751363
DFA15_-693751363 -->|"a"|DFA16_1934320728
DFA16_1934320728 -->|"y"|DFA17_-381058106
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
subgraph MiniDFA0_1769072607["MiniDFA0 {1}"]
DFA0_495186163_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2067475226["MiniDFA1 {1}"]
DFA1_1420605915_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_517904739["MiniDFA2 {1}"]
DFA2_-545742529_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1998159951["MiniDFA4 {1}"]
DFA3_-1804144022_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1747808268["MiniDFA5 {1}"]
DFA4_-1342006446_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1724846268["MiniDFA6 {1}"]
DFA5_-1114918140_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-47788751["MiniDFA7 {1}"]
DFA6_-1278182545_6{{"DFA6 {1}"}}
end
subgraph MiniDFA9_-321769582["MiniDFA9 {1}"]
DFA7_-214189934_7{{"DFA7 {1}"}}
end
subgraph MiniDFA12_-197753859["MiniDFA12 {1}"]
DFA8_1293489638_8{{"DFA8 {1}"}}
end
subgraph MiniDFA13_1105750892["MiniDFA13 {1}"]
DFA9_543891271_9{{"DFA9 {1}"}}
end
subgraph MiniDFA14_752666421["MiniDFA14 {1}"]
DFA10_-1935089846_10{{"DFA10 {1}"}}
end
subgraph MiniDFA8_-1622507420["MiniDFA8 {1}"]
DFA11_1301402748_11{{"DFA11 {1}"}}
end
subgraph MiniDFA15_-1705879910["MiniDFA15 {1}"]
DFA12_377073063_12{{"DFA12 {1}"}}
end
subgraph MiniDFA10_-697507698["MiniDFA10 {1}"]
DFA13_-493320774_13{{"DFA13 {1}"}}
end
subgraph MiniDFA11_-1636511162["MiniDFA11 {1}"]
DFA14_-294468779_14{{"DFA14 {1}"}}
end
subgraph MiniDFA3_1921046738["MiniDFA3 {1}"]
DFA15_-693751363_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_-1294959230["MiniDFA16 {1}"]
DFA16_1934320728_16{{"DFA16 {1}"}}
end
subgraph MiniDFA17_-1931576230["MiniDFA17 {1}"]
DFA17_-381058106_17[\"DFA17 {1}"/]
end
MiniDFA0_1769072607 -->|"i"|MiniDFA1_-2067475226
MiniDFA1_-2067475226 -->|"s"|MiniDFA2_517904739
MiniDFA2_517904739 -->|"a"|MiniDFA4_1998159951
MiniDFA4_1998159951 -->|"m"|MiniDFA5_-1747808268
MiniDFA5_-1747808268 -->|"p"|MiniDFA6_1724846268
MiniDFA6_1724846268 -->|"l"|MiniDFA7_-47788751
MiniDFA7_-47788751 -->|"e"|MiniDFA9_-321769582
MiniDFA9_-321769582 -->|"r"|MiniDFA12_-197753859
MiniDFA12_-197753859 -->|"C"|MiniDFA13_1105750892
MiniDFA13_1105750892 -->|"u"|MiniDFA14_752666421
MiniDFA14_752666421 -->|"b"|MiniDFA8_-1622507420
MiniDFA8_-1622507420 -->|"e"|MiniDFA15_-1705879910
MiniDFA15_-1705879910 -->|"A"|MiniDFA10_-697507698
MiniDFA10_-697507698 -->|"r"|MiniDFA11_-1636511162
MiniDFA11_-1636511162 -->|"r"|MiniDFA3_1921046738
MiniDFA3_1921046738 -->|"a"|MiniDFA16_-1294959230
MiniDFA16_-1294959230 -->|"y"|MiniDFA17_-1931576230
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
MiniDFA0_1769072607(["MiniDFA0 {1}"])
MiniDFA1_-2067475226(["MiniDFA1 {1}"])
MiniDFA2_517904739(["MiniDFA2 {1}"])
MiniDFA4_1998159951(["MiniDFA4 {1}"])
MiniDFA5_-1747808268(["MiniDFA5 {1}"])
MiniDFA6_1724846268(["MiniDFA6 {1}"])
MiniDFA7_-47788751(["MiniDFA7 {1}"])
MiniDFA9_-321769582(["MiniDFA9 {1}"])
MiniDFA12_-197753859(["MiniDFA12 {1}"])
MiniDFA13_1105750892(["MiniDFA13 {1}"])
MiniDFA14_752666421(["MiniDFA14 {1}"])
MiniDFA8_-1622507420(["MiniDFA8 {1}"])
MiniDFA15_-1705879910(["MiniDFA15 {1}"])
MiniDFA10_-697507698(["MiniDFA10 {1}"])
MiniDFA11_-1636511162(["MiniDFA11 {1}"])
MiniDFA3_1921046738(["MiniDFA3 {1}"])
MiniDFA16_-1294959230(["MiniDFA16 {1}"])
MiniDFA17_-1931576230[\"MiniDFA17 {1}"/]
MiniDFA0_1769072607 -->|"i"|MiniDFA1_-2067475226
MiniDFA1_-2067475226 -->|"s"|MiniDFA2_517904739
MiniDFA2_517904739 -->|"a"|MiniDFA4_1998159951
MiniDFA4_1998159951 -->|"m"|MiniDFA5_-1747808268
MiniDFA5_-1747808268 -->|"p"|MiniDFA6_1724846268
MiniDFA6_1724846268 -->|"l"|MiniDFA7_-47788751
MiniDFA7_-47788751 -->|"e"|MiniDFA9_-321769582
MiniDFA9_-321769582 -->|"r"|MiniDFA12_-197753859
MiniDFA12_-197753859 -->|"C"|MiniDFA13_1105750892
MiniDFA13_1105750892 -->|"u"|MiniDFA14_752666421
MiniDFA14_752666421 -->|"b"|MiniDFA8_-1622507420
MiniDFA8_-1622507420 -->|"e"|MiniDFA15_-1705879910
MiniDFA15_-1705879910 -->|"A"|MiniDFA10_-697507698
MiniDFA10_-697507698 -->|"r"|MiniDFA11_-1636511162
MiniDFA11_-1636511162 -->|"r"|MiniDFA3_1921046738
MiniDFA3_1921046738 -->|"a"|MiniDFA16_-1294959230
MiniDFA16_-1294959230 -->|"y"|MiniDFA17_-1931576230
```
-------------------------------
