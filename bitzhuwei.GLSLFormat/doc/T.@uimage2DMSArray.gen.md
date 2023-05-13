# 'uimage2DMSArray'

pattern: `uimage2DMSArray`

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
eNFA192_30_31327832[["εNFA192-30 regex start"]]
eNFA192_0_13515039[["εNFA192-0 char{1, 1}"]]
eNFA192_1_54526492[["εNFA192-1 char[1]"]]
eNFA192_2_20976384[["εNFA192-2 char{1, 1}"]]
eNFA192_3_54569732[["εNFA192-3 char[1]"]]
eNFA192_4_21365545[["εNFA192-4 char{1, 1}"]]
eNFA192_5_58072185[["εNFA192-5 char[1]"]]
eNFA192_6_52887619[["εNFA192-6 char{1, 1}"]]
eNFA192_7_6226530[["εNFA192-7 char[1]"]]
eNFA192_8_56038774[["εNFA192-8 char{1, 1}"]]
eNFA192_9_34586920[["εNFA192-9 char[1]"]]
eNFA192_10_42846825[["εNFA192-10 char{1, 1}"]]
eNFA192_11_50077106[["εNFA192-11 char[1]"]]
eNFA192_12_48040772[["εNFA192-12 char{1, 1}"]]
eNFA192_13_29713768[["εNFA192-13 char[1]"]]
eNFA192_14_66097328[["εNFA192-14 char{1, 1}"]]
eNFA192_15_58005044[["εNFA192-15 char[1]"]]
eNFA192_16_52283348[["εNFA192-16 char{1, 1}"]]
eNFA192_17_788091[["εNFA192-17 char[1]"]]
eNFA192_18_7092825[["εNFA192-18 char{1, 1}"]]
eNFA192_19_63835431[["εNFA192-19 char[1]"]]
eNFA192_20_37647975[["εNFA192-20 char{1, 1}"]]
eNFA192_21_3287456[["εNFA192-21 char[1]"]]
eNFA192_22_29587109[["εNFA192-22 char{1, 1}"]]
eNFA192_23_64957389[["εNFA192-23 char[1]"]]
eNFA192_24_47745595[["εNFA192-24 char{1, 1}"]]
eNFA192_25_27057175[["εNFA192-25 char[1]"]]
eNFA192_26_42187986[["εNFA192-26 char{1, 1}"]]
eNFA192_27_44147557[["εNFA192-27 char[1]"]]
eNFA192_28_61783697[["εNFA192-28 char{1, 1}"]]
eNFA192_29_19182368[["εNFA192-29 char[1]"]]
eNFA192_31_38423585[["εNFA192-31 regex end"]]
eNFA192_32_10267951[["εNFA192-32 post-regex start"]]
eNFA192_33_25302698[\"εNFA192-33 post-regex end"/]
eNFA192_30_31327832 -.->|"ε"|eNFA192_0_13515039
eNFA192_0_13515039 -->|"u"|eNFA192_1_54526492
eNFA192_1_54526492 -.->|"ε"|eNFA192_2_20976384
eNFA192_2_20976384 -->|"i"|eNFA192_3_54569732
eNFA192_3_54569732 -.->|"ε"|eNFA192_4_21365545
eNFA192_4_21365545 -->|"m"|eNFA192_5_58072185
eNFA192_5_58072185 -.->|"ε"|eNFA192_6_52887619
eNFA192_6_52887619 -->|"a"|eNFA192_7_6226530
eNFA192_7_6226530 -.->|"ε"|eNFA192_8_56038774
eNFA192_8_56038774 -->|"g"|eNFA192_9_34586920
eNFA192_9_34586920 -.->|"ε"|eNFA192_10_42846825
eNFA192_10_42846825 -->|"e"|eNFA192_11_50077106
eNFA192_11_50077106 -.->|"ε"|eNFA192_12_48040772
eNFA192_12_48040772 -->|"2"|eNFA192_13_29713768
eNFA192_13_29713768 -.->|"ε"|eNFA192_14_66097328
eNFA192_14_66097328 -->|"D"|eNFA192_15_58005044
eNFA192_15_58005044 -.->|"ε"|eNFA192_16_52283348
eNFA192_16_52283348 -->|"M"|eNFA192_17_788091
eNFA192_17_788091 -.->|"ε"|eNFA192_18_7092825
eNFA192_18_7092825 -->|"S"|eNFA192_19_63835431
eNFA192_19_63835431 -.->|"ε"|eNFA192_20_37647975
eNFA192_20_37647975 -->|"A"|eNFA192_21_3287456
eNFA192_21_3287456 -.->|"ε"|eNFA192_22_29587109
eNFA192_22_29587109 -->|"r"|eNFA192_23_64957389
eNFA192_23_64957389 -.->|"ε"|eNFA192_24_47745595
eNFA192_24_47745595 -->|"r"|eNFA192_25_27057175
eNFA192_25_27057175 -.->|"ε"|eNFA192_26_42187986
eNFA192_26_42187986 -->|"a"|eNFA192_27_44147557
eNFA192_27_44147557 -.->|"ε"|eNFA192_28_61783697
eNFA192_28_61783697 -->|"y"|eNFA192_29_19182368
eNFA192_29_19182368 -.->|"ε"|eNFA192_31_38423585
eNFA192_31_38423585 -.->|"ε"|eNFA192_32_10267951
eNFA192_32_10267951 -.->|"ε"|eNFA192_33_25302698
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
eNFA192_30_26397691[["εNFA192-30 regex start"]]
eNFA192_0_36252627[["εNFA192-0 char{1, 1}"]]
eNFA192_1_57838187[["εNFA192-1 char[1]"]]
eNFA192_2_50781636[["εNFA192-2 char{1, 1}"]]
eNFA192_3_54381543[["εNFA192-3 char[1]"]]
eNFA192_4_19671846[["εNFA192-4 char{1, 1}"]]
eNFA192_5_42828888[["εNFA192-5 char[1]"]]
eNFA192_6_49915680[["εNFA192-6 char{1, 1}"]]
eNFA192_7_46587942[["εNFA192-7 char[1]"]]
eNFA192_8_16638299[["εNFA192-8 char{1, 1}"]]
eNFA192_9_15526968[["εNFA192-9 char[1]"]]
eNFA192_10_5524991[["εNFA192-10 char{1, 1}"]]
eNFA192_11_49724919[["εNFA192-11 char[1]"]]
eNFA192_12_44871090[["εNFA192-12 char{1, 1}"]]
eNFA192_13_1186634[["εNFA192-13 char[1]"]]
eNFA192_14_10679711[["εNFA192-14 char{1, 1}"]]
eNFA192_15_29008538[["εNFA192-15 char[1]"]]
eNFA192_16_59750252[["εNFA192-16 char{1, 1}"]]
eNFA192_17_881358[["εNFA192-17 char[1]"]]
eNFA192_18_7932225[["εNFA192-18 char{1, 1}"]]
eNFA192_19_4281167[["εNFA192-19 char[1]"]]
eNFA192_20_38530503[["εNFA192-20 char{1, 1}"]]
eNFA192_21_11230212[["εNFA192-21 char[1]"]]
eNFA192_22_33963045[["εNFA192-22 char{1, 1}"]]
eNFA192_23_37231957[["εNFA192-23 char[1]"]]
eNFA192_24_66652164[["εNFA192-24 char{1, 1}"]]
eNFA192_25_62998572[["εNFA192-25 char[1]"]]
eNFA192_26_30116236[["εNFA192-26 char{1, 1}"]]
eNFA192_27_2610670[["εNFA192-27 char[1]"]]
eNFA192_28_23496036[["εNFA192-28 char{1, 1}"]]
eNFA192_29_10137733[\"εNFA192-29 char[1]"/]
eNFA192_31_24130740[\"εNFA192-31 regex end"/]
eNFA192_32_15850073[\"εNFA192-32 post-regex start"/]
eNFA192_33_8432933[\"εNFA192-33 post-regex end"/]
eNFA192_30_26397691 -.->|"ε"|eNFA192_0_36252627
eNFA192_30_26397691 -->|"u"|eNFA192_1_57838187
eNFA192_0_36252627 -->|"u"|eNFA192_1_57838187
eNFA192_1_57838187 -.->|"ε"|eNFA192_2_50781636
eNFA192_1_57838187 -->|"i"|eNFA192_3_54381543
eNFA192_2_50781636 -->|"i"|eNFA192_3_54381543
eNFA192_3_54381543 -.->|"ε"|eNFA192_4_19671846
eNFA192_3_54381543 -->|"m"|eNFA192_5_42828888
eNFA192_4_19671846 -->|"m"|eNFA192_5_42828888
eNFA192_5_42828888 -.->|"ε"|eNFA192_6_49915680
eNFA192_5_42828888 -->|"a"|eNFA192_7_46587942
eNFA192_6_49915680 -->|"a"|eNFA192_7_46587942
eNFA192_7_46587942 -.->|"ε"|eNFA192_8_16638299
eNFA192_7_46587942 -->|"g"|eNFA192_9_15526968
eNFA192_8_16638299 -->|"g"|eNFA192_9_15526968
eNFA192_9_15526968 -.->|"ε"|eNFA192_10_5524991
eNFA192_9_15526968 -->|"e"|eNFA192_11_49724919
eNFA192_10_5524991 -->|"e"|eNFA192_11_49724919
eNFA192_11_49724919 -.->|"ε"|eNFA192_12_44871090
eNFA192_11_49724919 -->|"2"|eNFA192_13_1186634
eNFA192_12_44871090 -->|"2"|eNFA192_13_1186634
eNFA192_13_1186634 -.->|"ε"|eNFA192_14_10679711
eNFA192_13_1186634 -->|"D"|eNFA192_15_29008538
eNFA192_14_10679711 -->|"D"|eNFA192_15_29008538
eNFA192_15_29008538 -.->|"ε"|eNFA192_16_59750252
eNFA192_15_29008538 -->|"M"|eNFA192_17_881358
eNFA192_16_59750252 -->|"M"|eNFA192_17_881358
eNFA192_17_881358 -.->|"ε"|eNFA192_18_7932225
eNFA192_17_881358 -->|"S"|eNFA192_19_4281167
eNFA192_18_7932225 -->|"S"|eNFA192_19_4281167
eNFA192_19_4281167 -.->|"ε"|eNFA192_20_38530503
eNFA192_19_4281167 -->|"A"|eNFA192_21_11230212
eNFA192_20_38530503 -->|"A"|eNFA192_21_11230212
eNFA192_21_11230212 -.->|"ε"|eNFA192_22_33963045
eNFA192_21_11230212 -->|"r"|eNFA192_23_37231957
eNFA192_22_33963045 -->|"r"|eNFA192_23_37231957
eNFA192_23_37231957 -.->|"ε"|eNFA192_24_66652164
eNFA192_23_37231957 -->|"r"|eNFA192_25_62998572
eNFA192_24_66652164 -->|"r"|eNFA192_25_62998572
eNFA192_25_62998572 -.->|"ε"|eNFA192_26_30116236
eNFA192_25_62998572 -->|"a"|eNFA192_27_2610670
eNFA192_26_30116236 -->|"a"|eNFA192_27_2610670
eNFA192_27_2610670 -.->|"ε"|eNFA192_28_23496036
eNFA192_27_2610670 -->|"y"|eNFA192_29_10137733
eNFA192_28_23496036 -->|"y"|eNFA192_29_10137733
eNFA192_29_10137733 -.->|"ε"|eNFA192_31_24130740
eNFA192_29_10137733 -.->|"ε"|eNFA192_32_15850073
eNFA192_29_10137733 -.->|"ε"|eNFA192_33_8432933
eNFA192_31_24130740 -.->|"ε"|eNFA192_32_15850073
eNFA192_31_24130740 -.->|"ε"|eNFA192_33_8432933
eNFA192_32_15850073 -.->|"ε"|eNFA192_33_8432933
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
NFA192_30_8787537("NFA192-30 regex start")
NFA192_1_11978974("NFA192-1 char[1]")
NFA192_3_40701910("NFA192-3 char[1]")
NFA192_5_30772872("NFA192-5 char[1]")
NFA192_7_8520399("NFA192-7 char[1]")
NFA192_9_9574731("NFA192-9 char[1]")
NFA192_11_19063717("NFA192-11 char[1]")
NFA192_13_37355726("NFA192-13 char[1]")
NFA192_15_657215("NFA192-15 char[1]")
NFA192_17_5914937("NFA192-17 char[1]")
NFA192_19_53234437("NFA192-19 char[1]")
NFA192_21_9347893("NFA192-21 char[1]")
NFA192_23_17022177("NFA192-23 char[1]")
NFA192_25_18981865("NFA192-25 char[1]")
NFA192_27_36619064("NFA192-27 char[1]")
NFA192_29_61136126[\"NFA192-29 char[1]"/]
NFA192_30_8787537 -->|"u"|NFA192_1_11978974
NFA192_1_11978974 -->|"i"|NFA192_3_40701910
NFA192_3_40701910 -->|"m"|NFA192_5_30772872
NFA192_5_30772872 -->|"a"|NFA192_7_8520399
NFA192_7_8520399 -->|"g"|NFA192_9_9574731
NFA192_9_9574731 -->|"e"|NFA192_11_19063717
NFA192_11_19063717 -->|"2"|NFA192_13_37355726
NFA192_13_37355726 -->|"D"|NFA192_15_657215
NFA192_15_657215 -->|"M"|NFA192_17_5914937
NFA192_17_5914937 -->|"S"|NFA192_19_53234437
NFA192_19_53234437 -->|"A"|NFA192_21_9347893
NFA192_21_9347893 -->|"r"|NFA192_23_17022177
NFA192_23_17022177 -->|"r"|NFA192_25_18981865
NFA192_25_18981865 -->|"a"|NFA192_27_36619064
NFA192_27_36619064 -->|"y"|NFA192_29_61136126
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
subgraph DFA0_-1173538092["DFA0 regex start"]
NFA192_30_8787537_0("NFA192-30 regex start")
end
subgraph DFA1_-1543637862["DFA1 {1}"]
NFA192_1_11978974_1("NFA192-1 char[1]")
end
subgraph DFA2_-2146960592["DFA2 {1}"]
NFA192_3_40701910_2("NFA192-3 char[1]")
end
subgraph DFA3_1842936529["DFA3 {1}"]
NFA192_5_30772872_3("NFA192-5 char[1]")
end
subgraph DFA4_-1669560356["DFA4 {1}"]
NFA192_7_8520399_4("NFA192-7 char[1]")
end
subgraph DFA5_-696759137["DFA5 {1}"]
NFA192_9_9574731_5("NFA192-9 char[1]")
end
subgraph DFA6_-828818713["DFA6 {1}"]
NFA192_11_19063717_6("NFA192-11 char[1]")
end
subgraph DFA7_-1527576384["DFA7 {1}"]
NFA192_13_37355726_7("NFA192-13 char[1]")
end
subgraph DFA8_-1461922264["DFA8 {1}"]
NFA192_15_657215_8("NFA192-15 char[1]")
end
subgraph DFA9_1571203663["DFA9 {1}"]
NFA192_17_5914937_9("NFA192-17 char[1]")
end
subgraph DFA10_-401270366["DFA10 {1}"]
NFA192_19_53234437_10("NFA192-19 char[1]")
end
subgraph DFA11_-66351522["DFA11 {1}"]
NFA192_21_9347893_11("NFA192-21 char[1]")
end
subgraph DFA12_1795752160["DFA12 {1}"]
NFA192_23_17022177_12("NFA192-23 char[1]")
end
subgraph DFA13_-1492854479["DFA13 {1}"]
NFA192_25_18981865_13("NFA192-25 char[1]")
end
subgraph DFA14_-1262177534["DFA14 {1}"]
NFA192_27_36619064_14("NFA192-27 char[1]")
end
subgraph DFA15_-1369328396["DFA15 {1}"]
NFA192_29_61136126_15[\"NFA192-29 char[1]"/]
end
DFA0_-1173538092 -->|"u"|DFA1_-1543637862
DFA1_-1543637862 -->|"i"|DFA2_-2146960592
DFA2_-2146960592 -->|"m"|DFA3_1842936529
DFA3_1842936529 -->|"a"|DFA4_-1669560356
DFA4_-1669560356 -->|"g"|DFA5_-696759137
DFA5_-696759137 -->|"e"|DFA6_-828818713
DFA6_-828818713 -->|"2"|DFA7_-1527576384
DFA7_-1527576384 -->|"D"|DFA8_-1461922264
DFA8_-1461922264 -->|"M"|DFA9_1571203663
DFA9_1571203663 -->|"S"|DFA10_-401270366
DFA10_-401270366 -->|"A"|DFA11_-66351522
DFA11_-66351522 -->|"r"|DFA12_1795752160
DFA12_1795752160 -->|"r"|DFA13_-1492854479
DFA13_-1492854479 -->|"a"|DFA14_-1262177534
DFA14_-1262177534 -->|"y"|DFA15_-1369328396
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
DFA0_-1173538092{{"DFA0 regex start"}}
DFA1_-1543637862{{"DFA1 {1}"}}
DFA2_-2146960592{{"DFA2 {1}"}}
DFA3_1842936529{{"DFA3 {1}"}}
DFA4_-1669560356{{"DFA4 {1}"}}
DFA5_-696759137{{"DFA5 {1}"}}
DFA6_-828818713{{"DFA6 {1}"}}
DFA7_-1527576384{{"DFA7 {1}"}}
DFA8_-1461922264{{"DFA8 {1}"}}
DFA9_1571203663{{"DFA9 {1}"}}
DFA10_-401270366{{"DFA10 {1}"}}
DFA11_-66351522{{"DFA11 {1}"}}
DFA12_1795752160{{"DFA12 {1}"}}
DFA13_-1492854479{{"DFA13 {1}"}}
DFA14_-1262177534{{"DFA14 {1}"}}
DFA15_-1369328396[\"DFA15 {1}"/]
DFA0_-1173538092 -->|"u"|DFA1_-1543637862
DFA1_-1543637862 -->|"i"|DFA2_-2146960592
DFA2_-2146960592 -->|"m"|DFA3_1842936529
DFA3_1842936529 -->|"a"|DFA4_-1669560356
DFA4_-1669560356 -->|"g"|DFA5_-696759137
DFA5_-696759137 -->|"e"|DFA6_-828818713
DFA6_-828818713 -->|"2"|DFA7_-1527576384
DFA7_-1527576384 -->|"D"|DFA8_-1461922264
DFA8_-1461922264 -->|"M"|DFA9_1571203663
DFA9_1571203663 -->|"S"|DFA10_-401270366
DFA10_-401270366 -->|"A"|DFA11_-66351522
DFA11_-66351522 -->|"r"|DFA12_1795752160
DFA12_1795752160 -->|"r"|DFA13_-1492854479
DFA13_-1492854479 -->|"a"|DFA14_-1262177534
DFA14_-1262177534 -->|"y"|DFA15_-1369328396
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
subgraph MiniDFA0_2137623338["MiniDFA0 {1}"]
DFA0_-1173538092_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-809282189["MiniDFA1 {1}"]
DFA1_-1543637862_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_140577246["MiniDFA2 {1}"]
DFA2_-2146960592_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_675690427["MiniDFA3 {1}"]
DFA3_1842936529_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_2127249559["MiniDFA5 {1}"]
DFA4_-1669560356_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1672642460["MiniDFA6 {1}"]
DFA5_-696759137_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1050075488["MiniDFA7 {1}"]
DFA6_-828818713_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1717960391["MiniDFA8 {1}"]
DFA7_-1527576384_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_1709077364["MiniDFA9 {1}"]
DFA8_-1461922264_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_1377502785["MiniDFA10 {1}"]
DFA9_1571203663_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_2059449535["MiniDFA11 {1}"]
DFA10_-401270366_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_-500676141["MiniDFA12 {1}"]
DFA11_-66351522_11{{"DFA11 {1}"}}
end
subgraph MiniDFA13_-2031905764["MiniDFA13 {1}"]
DFA12_1795752160_12{{"DFA12 {1}"}}
end
subgraph MiniDFA4_1655104798["MiniDFA4 {1}"]
DFA13_-1492854479_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-607811249["MiniDFA14 {1}"]
DFA14_-1262177534_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_2013344259["MiniDFA15 {1}"]
DFA15_-1369328396_15[\"DFA15 {1}"/]
end
MiniDFA0_2137623338 -->|"u"|MiniDFA1_-809282189
MiniDFA1_-809282189 -->|"i"|MiniDFA2_140577246
MiniDFA2_140577246 -->|"m"|MiniDFA3_675690427
MiniDFA3_675690427 -->|"a"|MiniDFA5_2127249559
MiniDFA5_2127249559 -->|"g"|MiniDFA6_-1672642460
MiniDFA6_-1672642460 -->|"e"|MiniDFA7_1050075488
MiniDFA7_1050075488 -->|"2"|MiniDFA8_-1717960391
MiniDFA8_-1717960391 -->|"D"|MiniDFA9_1709077364
MiniDFA9_1709077364 -->|"M"|MiniDFA10_1377502785
MiniDFA10_1377502785 -->|"S"|MiniDFA11_2059449535
MiniDFA11_2059449535 -->|"A"|MiniDFA12_-500676141
MiniDFA12_-500676141 -->|"r"|MiniDFA13_-2031905764
MiniDFA13_-2031905764 -->|"r"|MiniDFA4_1655104798
MiniDFA4_1655104798 -->|"a"|MiniDFA14_-607811249
MiniDFA14_-607811249 -->|"y"|MiniDFA15_2013344259
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
MiniDFA0_2137623338(["MiniDFA0 {1}"])
MiniDFA1_-809282189(["MiniDFA1 {1}"])
MiniDFA2_140577246(["MiniDFA2 {1}"])
MiniDFA3_675690427(["MiniDFA3 {1}"])
MiniDFA5_2127249559(["MiniDFA5 {1}"])
MiniDFA6_-1672642460(["MiniDFA6 {1}"])
MiniDFA7_1050075488(["MiniDFA7 {1}"])
MiniDFA8_-1717960391(["MiniDFA8 {1}"])
MiniDFA9_1709077364(["MiniDFA9 {1}"])
MiniDFA10_1377502785(["MiniDFA10 {1}"])
MiniDFA11_2059449535(["MiniDFA11 {1}"])
MiniDFA12_-500676141(["MiniDFA12 {1}"])
MiniDFA13_-2031905764(["MiniDFA13 {1}"])
MiniDFA4_1655104798(["MiniDFA4 {1}"])
MiniDFA14_-607811249(["MiniDFA14 {1}"])
MiniDFA15_2013344259[\"MiniDFA15 {1}"/]
MiniDFA0_2137623338 -->|"u"|MiniDFA1_-809282189
MiniDFA1_-809282189 -->|"i"|MiniDFA2_140577246
MiniDFA2_140577246 -->|"m"|MiniDFA3_675690427
MiniDFA3_675690427 -->|"a"|MiniDFA5_2127249559
MiniDFA5_2127249559 -->|"g"|MiniDFA6_-1672642460
MiniDFA6_-1672642460 -->|"e"|MiniDFA7_1050075488
MiniDFA7_1050075488 -->|"2"|MiniDFA8_-1717960391
MiniDFA8_-1717960391 -->|"D"|MiniDFA9_1709077364
MiniDFA9_1709077364 -->|"M"|MiniDFA10_1377502785
MiniDFA10_1377502785 -->|"S"|MiniDFA11_2059449535
MiniDFA11_2059449535 -->|"A"|MiniDFA12_-500676141
MiniDFA12_-500676141 -->|"r"|MiniDFA13_-2031905764
MiniDFA13_-2031905764 -->|"r"|MiniDFA4_1655104798
MiniDFA4_1655104798 -->|"a"|MiniDFA14_-607811249
MiniDFA14_-607811249 -->|"y"|MiniDFA15_2013344259
```
-------------------------------
