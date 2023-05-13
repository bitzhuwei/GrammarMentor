# 'usampler1D'

pattern: `usampler1D`

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
eNFA140_20_5337050[["εNFA140-20 regex start"]]
eNFA140_0_48033450[["εNFA140-0 char{1, 1}"]]
eNFA140_1_29647872[["εNFA140-1 char[1]"]]
eNFA140_2_65504260[["εNFA140-2 char{1, 1}"]]
eNFA140_3_52667431[["εNFA140-3 char[1]"]]
eNFA140_4_4244834[["εNFA140-4 char{1, 1}"]]
eNFA140_5_38203510[["εNFA140-5 char[1]"]]
eNFA140_6_8287277[["εNFA140-6 char{1, 1}"]]
eNFA140_7_7476630[["εNFA140-7 char[1]"]]
eNFA140_8_180812[["εNFA140-8 char{1, 1}"]]
eNFA140_9_1627311[["εNFA140-9 char[1]"]]
eNFA140_10_14645800[["εNFA140-10 char{1, 1}"]]
eNFA140_11_64703336[["εNFA140-11 char[1]"]]
eNFA140_12_45459112[["εNFA140-12 char{1, 1}"]]
eNFA140_13_6478825[["εNFA140-13 char[1]"]]
eNFA140_14_58309428[["εNFA140-14 char{1, 1}"]]
eNFA140_15_55022811[["εNFA140-15 char[1]"]]
eNFA140_16_25443253[["εNFA140-16 char{1, 1}"]]
eNFA140_17_27662693[["εNFA140-17 char[1]"]]
eNFA140_18_47637651[["εNFA140-18 char{1, 1}"]]
eNFA140_19_26085680[["εNFA140-19 char[1]"]]
eNFA140_21_33444533[["εNFA140-21 regex end"]]
eNFA140_22_32565348[["εNFA140-22 post-regex start"]]
eNFA140_23_24652676[\"εNFA140-23 post-regex end"/]
eNFA140_20_5337050 -.->|"ε"|eNFA140_0_48033450
eNFA140_0_48033450 -->|"u"|eNFA140_1_29647872
eNFA140_1_29647872 -.->|"ε"|eNFA140_2_65504260
eNFA140_2_65504260 -->|"s"|eNFA140_3_52667431
eNFA140_3_52667431 -.->|"ε"|eNFA140_4_4244834
eNFA140_4_4244834 -->|"a"|eNFA140_5_38203510
eNFA140_5_38203510 -.->|"ε"|eNFA140_6_8287277
eNFA140_6_8287277 -->|"m"|eNFA140_7_7476630
eNFA140_7_7476630 -.->|"ε"|eNFA140_8_180812
eNFA140_8_180812 -->|"p"|eNFA140_9_1627311
eNFA140_9_1627311 -.->|"ε"|eNFA140_10_14645800
eNFA140_10_14645800 -->|"l"|eNFA140_11_64703336
eNFA140_11_64703336 -.->|"ε"|eNFA140_12_45459112
eNFA140_12_45459112 -->|"e"|eNFA140_13_6478825
eNFA140_13_6478825 -.->|"ε"|eNFA140_14_58309428
eNFA140_14_58309428 -->|"r"|eNFA140_15_55022811
eNFA140_15_55022811 -.->|"ε"|eNFA140_16_25443253
eNFA140_16_25443253 -->|"1"|eNFA140_17_27662693
eNFA140_17_27662693 -.->|"ε"|eNFA140_18_47637651
eNFA140_18_47637651 -->|"D"|eNFA140_19_26085680
eNFA140_19_26085680 -.->|"ε"|eNFA140_21_33444533
eNFA140_21_33444533 -.->|"ε"|eNFA140_22_32565348
eNFA140_22_32565348 -.->|"ε"|eNFA140_23_24652676
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
eNFA140_20_20547495[["εNFA140-20 regex start"]]
eNFA140_0_50709735[["εNFA140-0 char{1, 1}"]]
eNFA140_1_53734436[["εNFA140-1 char[1]"]]
eNFA140_2_13847879[["εNFA140-2 char{1, 1}"]]
eNFA140_3_57522049[["εNFA140-3 char[1]"]]
eNFA140_4_47936395[["εNFA140-4 char{1, 1}"]]
eNFA140_5_28774374[["εNFA140-5 char[1]"]]
eNFA140_6_57642780[["εNFA140-6 char{1, 1}"]]
eNFA140_7_49022972[["εNFA140-7 char[1]"]]
eNFA140_8_38553569[["εNFA140-8 char{1, 1}"]]
eNFA140_9_11437802[["εNFA140-9 char[1]"]]
eNFA140_10_35831362[["εNFA140-10 char{1, 1}"]]
eNFA140_11_54046809[["εNFA140-11 char[1]"]]
eNFA140_12_16659241[["εNFA140-12 char{1, 1}"]]
eNFA140_13_15715441[["εNFA140-13 char[1]"]]
eNFA140_14_7221243[["εNFA140-14 char{1, 1}"]]
eNFA140_15_64991193[["εNFA140-15 char[1]"]]
eNFA140_16_48049826[["εNFA140-16 char{1, 1}"]]
eNFA140_17_29795257[["εNFA140-17 char[1]"]]
eNFA140_18_66830726[["εNFA140-18 char{1, 1}"]]
eNFA140_19_64605626[\"εNFA140-19 char[1]"/]
eNFA140_21_44579726[\"εNFA140-21 regex end"/]
eNFA140_22_65673219[\"εNFA140-22 post-regex start"/]
eNFA140_23_54188067[\"εNFA140-23 post-regex end"/]
eNFA140_20_20547495 -.->|"ε"|eNFA140_0_50709735
eNFA140_20_20547495 -->|"u"|eNFA140_1_53734436
eNFA140_0_50709735 -->|"u"|eNFA140_1_53734436
eNFA140_1_53734436 -.->|"ε"|eNFA140_2_13847879
eNFA140_1_53734436 -->|"s"|eNFA140_3_57522049
eNFA140_2_13847879 -->|"s"|eNFA140_3_57522049
eNFA140_3_57522049 -.->|"ε"|eNFA140_4_47936395
eNFA140_3_57522049 -->|"a"|eNFA140_5_28774374
eNFA140_4_47936395 -->|"a"|eNFA140_5_28774374
eNFA140_5_28774374 -.->|"ε"|eNFA140_6_57642780
eNFA140_5_28774374 -->|"m"|eNFA140_7_49022972
eNFA140_6_57642780 -->|"m"|eNFA140_7_49022972
eNFA140_7_49022972 -.->|"ε"|eNFA140_8_38553569
eNFA140_7_49022972 -->|"p"|eNFA140_9_11437802
eNFA140_8_38553569 -->|"p"|eNFA140_9_11437802
eNFA140_9_11437802 -.->|"ε"|eNFA140_10_35831362
eNFA140_9_11437802 -->|"l"|eNFA140_11_54046809
eNFA140_10_35831362 -->|"l"|eNFA140_11_54046809
eNFA140_11_54046809 -.->|"ε"|eNFA140_12_16659241
eNFA140_11_54046809 -->|"e"|eNFA140_13_15715441
eNFA140_12_16659241 -->|"e"|eNFA140_13_15715441
eNFA140_13_15715441 -.->|"ε"|eNFA140_14_7221243
eNFA140_13_15715441 -->|"r"|eNFA140_15_64991193
eNFA140_14_7221243 -->|"r"|eNFA140_15_64991193
eNFA140_15_64991193 -.->|"ε"|eNFA140_16_48049826
eNFA140_15_64991193 -->|"1"|eNFA140_17_29795257
eNFA140_16_48049826 -->|"1"|eNFA140_17_29795257
eNFA140_17_29795257 -.->|"ε"|eNFA140_18_66830726
eNFA140_17_29795257 -->|"D"|eNFA140_19_64605626
eNFA140_18_66830726 -->|"D"|eNFA140_19_64605626
eNFA140_19_64605626 -.->|"ε"|eNFA140_21_44579726
eNFA140_19_64605626 -.->|"ε"|eNFA140_22_65673219
eNFA140_19_64605626 -.->|"ε"|eNFA140_23_54188067
eNFA140_21_44579726 -.->|"ε"|eNFA140_22_65673219
eNFA140_21_44579726 -.->|"ε"|eNFA140_23_54188067
eNFA140_22_65673219 -.->|"ε"|eNFA140_23_54188067
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
NFA140_20_17930557("NFA140-20 regex start")
NFA140_1_27157292("NFA140-1 char[1]")
NFA140_3_43089040("NFA140-3 char[1]")
NFA140_5_52257042("NFA140-5 char[1]")
NFA140_7_551331("NFA140-7 char[1]")
NFA140_9_4961980("NFA140-9 char[1]")
NFA140_11_44657822("NFA140-11 char[1]")
NFA140_13_66376082("NFA140-13 char[1]")
NFA140_15_60513834("NFA140-15 char[1]")
NFA140_17_7753598("NFA140-17 char[1]")
NFA140_19_2673518[\"NFA140-19 char[1]"/]
NFA140_20_17930557 -->|"u"|NFA140_1_27157292
NFA140_1_27157292 -->|"s"|NFA140_3_43089040
NFA140_3_43089040 -->|"a"|NFA140_5_52257042
NFA140_5_52257042 -->|"m"|NFA140_7_551331
NFA140_7_551331 -->|"p"|NFA140_9_4961980
NFA140_9_4961980 -->|"l"|NFA140_11_44657822
NFA140_11_44657822 -->|"e"|NFA140_13_66376082
NFA140_13_66376082 -->|"r"|NFA140_15_60513834
NFA140_15_60513834 -->|"1"|NFA140_17_7753598
NFA140_17_7753598 -->|"D"|NFA140_19_2673518
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
subgraph DFA0_-710633858["DFA0 regex start"]
NFA140_20_17930557_0("NFA140-20 regex start")
end
subgraph DFA1_-1605992415["DFA1 {1}"]
NFA140_1_27157292_1("NFA140-1 char[1]")
end
subgraph DFA2_-604485933["DFA2 {1}"]
NFA140_3_43089040_2("NFA140-3 char[1]")
end
subgraph DFA3_1494828152["DFA3 {1}"]
NFA140_5_52257042_3("NFA140-5 char[1]")
end
subgraph DFA4_-1764486680["DFA4 {1}"]
NFA140_7_551331_4("NFA140-7 char[1]")
end
subgraph DFA5_-1150135330["DFA5 {1}"]
NFA140_9_4961980_5("NFA140-9 char[1]")
end
subgraph DFA6_1257045888["DFA6 {1}"]
NFA140_11_44657822_6("NFA140-11 char[1]")
end
subgraph DFA7_524284868["DFA7 {1}"]
NFA140_13_66376082_7("NFA140-13 char[1]")
end
subgraph DFA8_1885076140["DFA8 {1}"]
NFA140_15_60513834_8("NFA140-15 char[1]")
end
subgraph DFA9_-1400778774["DFA9 {1}"]
NFA140_17_7753598_9("NFA140-17 char[1]")
end
subgraph DFA10_408142439["DFA10 {1}"]
NFA140_19_2673518_10[\"NFA140-19 char[1]"/]
end
DFA0_-710633858 -->|"u"|DFA1_-1605992415
DFA1_-1605992415 -->|"s"|DFA2_-604485933
DFA2_-604485933 -->|"a"|DFA3_1494828152
DFA3_1494828152 -->|"m"|DFA4_-1764486680
DFA4_-1764486680 -->|"p"|DFA5_-1150135330
DFA5_-1150135330 -->|"l"|DFA6_1257045888
DFA6_1257045888 -->|"e"|DFA7_524284868
DFA7_524284868 -->|"r"|DFA8_1885076140
DFA8_1885076140 -->|"1"|DFA9_-1400778774
DFA9_-1400778774 -->|"D"|DFA10_408142439
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
DFA0_-710633858{{"DFA0 regex start"}}
DFA1_-1605992415{{"DFA1 {1}"}}
DFA2_-604485933{{"DFA2 {1}"}}
DFA3_1494828152{{"DFA3 {1}"}}
DFA4_-1764486680{{"DFA4 {1}"}}
DFA5_-1150135330{{"DFA5 {1}"}}
DFA6_1257045888{{"DFA6 {1}"}}
DFA7_524284868{{"DFA7 {1}"}}
DFA8_1885076140{{"DFA8 {1}"}}
DFA9_-1400778774{{"DFA9 {1}"}}
DFA10_408142439[\"DFA10 {1}"/]
DFA0_-710633858 -->|"u"|DFA1_-1605992415
DFA1_-1605992415 -->|"s"|DFA2_-604485933
DFA2_-604485933 -->|"a"|DFA3_1494828152
DFA3_1494828152 -->|"m"|DFA4_-1764486680
DFA4_-1764486680 -->|"p"|DFA5_-1150135330
DFA5_-1150135330 -->|"l"|DFA6_1257045888
DFA6_1257045888 -->|"e"|DFA7_524284868
DFA7_524284868 -->|"r"|DFA8_1885076140
DFA8_1885076140 -->|"1"|DFA9_-1400778774
DFA9_-1400778774 -->|"D"|DFA10_408142439
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
subgraph MiniDFA0_-95445830["MiniDFA0 {1}"]
DFA0_-710633858_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-841785134["MiniDFA1 {1}"]
DFA1_-1605992415_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1514331123["MiniDFA2 {1}"]
DFA2_-604485933_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1224221835["MiniDFA3 {1}"]
DFA3_1494828152_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1157994511["MiniDFA4 {1}"]
DFA4_-1764486680_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1431665629["MiniDFA5 {1}"]
DFA5_-1150135330_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-398947286["MiniDFA6 {1}"]
DFA6_1257045888_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_937631329["MiniDFA7 {1}"]
DFA7_524284868_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_2100613644["MiniDFA8 {1}"]
DFA8_1885076140_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_1639487572["MiniDFA9 {1}"]
DFA9_-1400778774_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-190822893["MiniDFA10 {1}"]
DFA10_408142439_10[\"DFA10 {1}"/]
end
MiniDFA0_-95445830 -->|"u"|MiniDFA1_-841785134
MiniDFA1_-841785134 -->|"s"|MiniDFA2_-1514331123
MiniDFA2_-1514331123 -->|"a"|MiniDFA3_1224221835
MiniDFA3_1224221835 -->|"m"|MiniDFA4_-1157994511
MiniDFA4_-1157994511 -->|"p"|MiniDFA5_1431665629
MiniDFA5_1431665629 -->|"l"|MiniDFA6_-398947286
MiniDFA6_-398947286 -->|"e"|MiniDFA7_937631329
MiniDFA7_937631329 -->|"r"|MiniDFA8_2100613644
MiniDFA8_2100613644 -->|"1"|MiniDFA9_1639487572
MiniDFA9_1639487572 -->|"D"|MiniDFA10_-190822893
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
MiniDFA0_-95445830(["MiniDFA0 {1}"])
MiniDFA1_-841785134(["MiniDFA1 {1}"])
MiniDFA2_-1514331123(["MiniDFA2 {1}"])
MiniDFA3_1224221835(["MiniDFA3 {1}"])
MiniDFA4_-1157994511(["MiniDFA4 {1}"])
MiniDFA5_1431665629(["MiniDFA5 {1}"])
MiniDFA6_-398947286(["MiniDFA6 {1}"])
MiniDFA7_937631329(["MiniDFA7 {1}"])
MiniDFA8_2100613644(["MiniDFA8 {1}"])
MiniDFA9_1639487572(["MiniDFA9 {1}"])
MiniDFA10_-190822893[\"MiniDFA10 {1}"/]
MiniDFA0_-95445830 -->|"u"|MiniDFA1_-841785134
MiniDFA1_-841785134 -->|"s"|MiniDFA2_-1514331123
MiniDFA2_-1514331123 -->|"a"|MiniDFA3_1224221835
MiniDFA3_1224221835 -->|"m"|MiniDFA4_-1157994511
MiniDFA4_-1157994511 -->|"p"|MiniDFA5_1431665629
MiniDFA5_1431665629 -->|"l"|MiniDFA6_-398947286
MiniDFA6_-398947286 -->|"e"|MiniDFA7_937631329
MiniDFA7_937631329 -->|"r"|MiniDFA8_2100613644
MiniDFA8_2100613644 -->|"1"|MiniDFA9_1639487572
MiniDFA9_1639487572 -->|"D"|MiniDFA10_-190822893
```
-------------------------------
