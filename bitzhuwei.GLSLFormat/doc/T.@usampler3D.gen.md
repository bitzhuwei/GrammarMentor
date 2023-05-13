# 'usampler3D'

pattern: `usampler3D`

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
eNFA142_20_27369819[["εNFA142-20 regex start"]]
eNFA142_0_45001781[["εNFA142-0 char{1, 1}"]]
eNFA142_1_2362851[["εNFA142-1 char[1]"]]
eNFA142_2_21265660[["εNFA142-2 char{1, 1}"]]
eNFA142_3_57173219[["εNFA142-3 char[1]"]]
eNFA142_4_44796928[["εNFA142-4 char{1, 1}"]]
eNFA142_5_519172[["εNFA142-5 char[1]"]]
eNFA142_6_4672552[["εNFA142-6 char{1, 1}"]]
eNFA142_7_42052973[["εNFA142-7 char[1]"]]
eNFA142_8_42932445[["εNFA142-8 char{1, 1}"]]
eNFA142_9_50847687[["εNFA142-9 char[1]"]]
eNFA142_10_54976006[["εNFA142-10 char{1, 1}"]]
eNFA142_11_25022010[["εNFA142-11 char[1]"]]
eNFA142_12_23871500[["εNFA142-12 char{1, 1}"]]
eNFA142_13_13516909[["εNFA142-13 char[1]"]]
eNFA142_14_54543318[["εNFA142-14 char{1, 1}"]]
eNFA142_15_21127816[["εNFA142-15 char[1]"]]
eNFA142_16_55932620[["εNFA142-16 char{1, 1}"]]
eNFA142_17_33631540[["εNFA142-17 char[1]"]]
eNFA142_18_34248408[["εNFA142-18 char{1, 1}"]]
eNFA142_19_39800216[["εNFA142-19 char[1]"]]
eNFA142_21_22657631[["εNFA142-21 regex end"]]
eNFA142_22_2592093[["εNFA142-22 post-regex start"]]
eNFA142_23_23328843[\"εNFA142-23 post-regex end"/]
eNFA142_20_27369819 -.->|"ε"|eNFA142_0_45001781
eNFA142_0_45001781 -->|"u"|eNFA142_1_2362851
eNFA142_1_2362851 -.->|"ε"|eNFA142_2_21265660
eNFA142_2_21265660 -->|"s"|eNFA142_3_57173219
eNFA142_3_57173219 -.->|"ε"|eNFA142_4_44796928
eNFA142_4_44796928 -->|"a"|eNFA142_5_519172
eNFA142_5_519172 -.->|"ε"|eNFA142_6_4672552
eNFA142_6_4672552 -->|"m"|eNFA142_7_42052973
eNFA142_7_42052973 -.->|"ε"|eNFA142_8_42932445
eNFA142_8_42932445 -->|"p"|eNFA142_9_50847687
eNFA142_9_50847687 -.->|"ε"|eNFA142_10_54976006
eNFA142_10_54976006 -->|"l"|eNFA142_11_25022010
eNFA142_11_25022010 -.->|"ε"|eNFA142_12_23871500
eNFA142_12_23871500 -->|"e"|eNFA142_13_13516909
eNFA142_13_13516909 -.->|"ε"|eNFA142_14_54543318
eNFA142_14_54543318 -->|"r"|eNFA142_15_21127816
eNFA142_15_21127816 -.->|"ε"|eNFA142_16_55932620
eNFA142_16_55932620 -->|"3"|eNFA142_17_33631540
eNFA142_17_33631540 -.->|"ε"|eNFA142_18_34248408
eNFA142_18_34248408 -->|"D"|eNFA142_19_39800216
eNFA142_19_39800216 -.->|"ε"|eNFA142_21_22657631
eNFA142_21_22657631 -.->|"ε"|eNFA142_22_2592093
eNFA142_22_2592093 -.->|"ε"|eNFA142_23_23328843
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
eNFA142_20_8633003[["εNFA142-20 regex start"]]
eNFA142_0_10588164[["εNFA142-0 char{1, 1}"]]
eNFA142_1_28184617[["εNFA142-1 char[1]"]]
eNFA142_2_52334961[["εNFA142-2 char{1, 1}"]]
eNFA142_3_1252607[["εNFA142-3 char[1]"]]
eNFA142_4_11273467[["εNFA142-4 char{1, 1}"]]
eNFA142_5_34352342[["εNFA142-5 char[1]"]]
eNFA142_6_40735625[["εNFA142-6 char{1, 1}"]]
eNFA142_7_31076309[["εNFA142-7 char[1]"]]
eNFA142_8_11251332[["εNFA142-8 char{1, 1}"]]
eNFA142_9_34153125[["εNFA142-9 char[1]"]]
eNFA142_10_38942675[["εNFA142-10 char{1, 1}"]]
eNFA142_11_14939758[["εNFA142-11 char[1]"]]
eNFA142_12_240095[["εNFA142-12 char{1, 1}"]]
eNFA142_13_2160855[["εNFA142-13 char[1]"]]
eNFA142_14_19447695[["εNFA142-14 char{1, 1}"]]
eNFA142_15_40811528[["εNFA142-15 char[1]"]]
eNFA142_16_31759435[["εNFA142-16 char{1, 1}"]]
eNFA142_17_17399466[["εNFA142-17 char[1]"]]
eNFA142_18_22377468[["εNFA142-18 char{1, 1}"]]
eNFA142_19_70628[\"εNFA142-19 char[1]"/]
eNFA142_21_635658[\"εNFA142-21 regex end"/]
eNFA142_22_5720927[\"εNFA142-22 post-regex start"/]
eNFA142_23_51488348[\"εNFA142-23 post-regex end"/]
eNFA142_20_8633003 -.->|"ε"|eNFA142_0_10588164
eNFA142_20_8633003 -->|"u"|eNFA142_1_28184617
eNFA142_0_10588164 -->|"u"|eNFA142_1_28184617
eNFA142_1_28184617 -.->|"ε"|eNFA142_2_52334961
eNFA142_1_28184617 -->|"s"|eNFA142_3_1252607
eNFA142_2_52334961 -->|"s"|eNFA142_3_1252607
eNFA142_3_1252607 -.->|"ε"|eNFA142_4_11273467
eNFA142_3_1252607 -->|"a"|eNFA142_5_34352342
eNFA142_4_11273467 -->|"a"|eNFA142_5_34352342
eNFA142_5_34352342 -.->|"ε"|eNFA142_6_40735625
eNFA142_5_34352342 -->|"m"|eNFA142_7_31076309
eNFA142_6_40735625 -->|"m"|eNFA142_7_31076309
eNFA142_7_31076309 -.->|"ε"|eNFA142_8_11251332
eNFA142_7_31076309 -->|"p"|eNFA142_9_34153125
eNFA142_8_11251332 -->|"p"|eNFA142_9_34153125
eNFA142_9_34153125 -.->|"ε"|eNFA142_10_38942675
eNFA142_9_34153125 -->|"l"|eNFA142_11_14939758
eNFA142_10_38942675 -->|"l"|eNFA142_11_14939758
eNFA142_11_14939758 -.->|"ε"|eNFA142_12_240095
eNFA142_11_14939758 -->|"e"|eNFA142_13_2160855
eNFA142_12_240095 -->|"e"|eNFA142_13_2160855
eNFA142_13_2160855 -.->|"ε"|eNFA142_14_19447695
eNFA142_13_2160855 -->|"r"|eNFA142_15_40811528
eNFA142_14_19447695 -->|"r"|eNFA142_15_40811528
eNFA142_15_40811528 -.->|"ε"|eNFA142_16_31759435
eNFA142_15_40811528 -->|"3"|eNFA142_17_17399466
eNFA142_16_31759435 -->|"3"|eNFA142_17_17399466
eNFA142_17_17399466 -.->|"ε"|eNFA142_18_22377468
eNFA142_17_17399466 -->|"D"|eNFA142_19_70628
eNFA142_18_22377468 -->|"D"|eNFA142_19_70628
eNFA142_19_70628 -.->|"ε"|eNFA142_21_635658
eNFA142_19_70628 -.->|"ε"|eNFA142_22_5720927
eNFA142_19_70628 -.->|"ε"|eNFA142_23_51488348
eNFA142_21_635658 -.->|"ε"|eNFA142_22_5720927
eNFA142_21_635658 -.->|"ε"|eNFA142_23_51488348
eNFA142_22_5720927 -.->|"ε"|eNFA142_23_51488348
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
NFA142_20_60741955("NFA142-20 regex start")
NFA142_1_9806683("NFA142-1 char[1]")
NFA142_3_21151286("NFA142-3 char[1]")
NFA142_5_56143854("NFA142-5 char[1]")
NFA142_7_35532643("NFA142-7 char[1]")
NFA142_9_51358334("NFA142-9 char[1]")
NFA142_11_59571824("NFA142-11 char[1]")
NFA142_13_66384370("NFA142-13 char[1]")
NFA142_15_60588421("NFA142-15 char[1]")
NFA142_17_8424883("NFA142-17 char[1]")
NFA142_19_8715083[\"NFA142-19 char[1]"/]
NFA142_20_60741955 -->|"u"|NFA142_1_9806683
NFA142_1_9806683 -->|"s"|NFA142_3_21151286
NFA142_3_21151286 -->|"a"|NFA142_5_56143854
NFA142_5_56143854 -->|"m"|NFA142_7_35532643
NFA142_7_35532643 -->|"p"|NFA142_9_51358334
NFA142_9_51358334 -->|"l"|NFA142_11_59571824
NFA142_11_59571824 -->|"e"|NFA142_13_66384370
NFA142_13_66384370 -->|"r"|NFA142_15_60588421
NFA142_15_60588421 -->|"3"|NFA142_17_8424883
NFA142_17_8424883 -->|"D"|NFA142_19_8715083
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
subgraph DFA0_-490337724["DFA0 regex start"]
NFA142_20_60741955_0("NFA142-20 regex start")
end
subgraph DFA1_49972413["DFA1 {1}"]
NFA142_1_9806683_1("NFA142-1 char[1]")
end
subgraph DFA2_1073972679["DFA2 {1}"]
NFA142_3_21151286_2("NFA142-3 char[1]")
end
subgraph DFA3_-965150740["DFA3 {1}"]
NFA142_5_56143854_3("NFA142-5 char[1]")
end
subgraph DFA4_-1204380963["DFA4 {1}"]
NFA142_7_35532643_4("NFA142-7 char[1]")
end
subgraph DFA5_-91988384["DFA5 {1}"]
NFA142_9_51358334_5("NFA142-9 char[1]")
end
subgraph DFA6_-1920475730["DFA6 {1}"]
NFA142_11_59571824_6("NFA142-11 char[1]")
end
subgraph DFA7_568726280["DFA7 {1}"]
NFA142_13_66384370_7("NFA142-13 char[1]")
end
subgraph DFA8_9803305["DFA8 {1}"]
NFA142_15_60588421_8("NFA142-15 char[1]")
end
subgraph DFA9_-111522763["DFA9 {1}"]
NFA142_17_8424883_9("NFA142-17 char[1]")
end
subgraph DFA10_503739057["DFA10 {1}"]
NFA142_19_8715083_10[\"NFA142-19 char[1]"/]
end
DFA0_-490337724 -->|"u"|DFA1_49972413
DFA1_49972413 -->|"s"|DFA2_1073972679
DFA2_1073972679 -->|"a"|DFA3_-965150740
DFA3_-965150740 -->|"m"|DFA4_-1204380963
DFA4_-1204380963 -->|"p"|DFA5_-91988384
DFA5_-91988384 -->|"l"|DFA6_-1920475730
DFA6_-1920475730 -->|"e"|DFA7_568726280
DFA7_568726280 -->|"r"|DFA8_9803305
DFA8_9803305 -->|"3"|DFA9_-111522763
DFA9_-111522763 -->|"D"|DFA10_503739057
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
DFA0_-490337724{{"DFA0 regex start"}}
DFA1_49972413{{"DFA1 {1}"}}
DFA2_1073972679{{"DFA2 {1}"}}
DFA3_-965150740{{"DFA3 {1}"}}
DFA4_-1204380963{{"DFA4 {1}"}}
DFA5_-91988384{{"DFA5 {1}"}}
DFA6_-1920475730{{"DFA6 {1}"}}
DFA7_568726280{{"DFA7 {1}"}}
DFA8_9803305{{"DFA8 {1}"}}
DFA9_-111522763{{"DFA9 {1}"}}
DFA10_503739057[\"DFA10 {1}"/]
DFA0_-490337724 -->|"u"|DFA1_49972413
DFA1_49972413 -->|"s"|DFA2_1073972679
DFA2_1073972679 -->|"a"|DFA3_-965150740
DFA3_-965150740 -->|"m"|DFA4_-1204380963
DFA4_-1204380963 -->|"p"|DFA5_-91988384
DFA5_-91988384 -->|"l"|DFA6_-1920475730
DFA6_-1920475730 -->|"e"|DFA7_568726280
DFA7_568726280 -->|"r"|DFA8_9803305
DFA8_9803305 -->|"3"|DFA9_-111522763
DFA9_-111522763 -->|"D"|DFA10_503739057
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
subgraph MiniDFA0_87021770["MiniDFA0 {1}"]
DFA0_-490337724_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2081460149["MiniDFA1 {1}"]
DFA1_49972413_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_624432673["MiniDFA2 {1}"]
DFA2_1073972679_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_320374368["MiniDFA3 {1}"]
DFA3_-965150740_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_299585725["MiniDFA4 {1}"]
DFA4_-1204380963_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-52767551["MiniDFA5 {1}"]
DFA5_-91988384_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1464457935["MiniDFA6 {1}"]
DFA6_-1920475730_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-790763159["MiniDFA7 {1}"]
DFA7_568726280_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1276944024["MiniDFA8 {1}"]
DFA8_9803305_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-413827859["MiniDFA9 {1}"]
DFA9_-111522763_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_412167803["MiniDFA10 {1}"]
DFA10_503739057_10[\"DFA10 {1}"/]
end
MiniDFA0_87021770 -->|"u"|MiniDFA1_2081460149
MiniDFA1_2081460149 -->|"s"|MiniDFA2_624432673
MiniDFA2_624432673 -->|"a"|MiniDFA3_320374368
MiniDFA3_320374368 -->|"m"|MiniDFA4_299585725
MiniDFA4_299585725 -->|"p"|MiniDFA5_-52767551
MiniDFA5_-52767551 -->|"l"|MiniDFA6_-1464457935
MiniDFA6_-1464457935 -->|"e"|MiniDFA7_-790763159
MiniDFA7_-790763159 -->|"r"|MiniDFA8_1276944024
MiniDFA8_1276944024 -->|"3"|MiniDFA9_-413827859
MiniDFA9_-413827859 -->|"D"|MiniDFA10_412167803
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
MiniDFA0_87021770(["MiniDFA0 {1}"])
MiniDFA1_2081460149(["MiniDFA1 {1}"])
MiniDFA2_624432673(["MiniDFA2 {1}"])
MiniDFA3_320374368(["MiniDFA3 {1}"])
MiniDFA4_299585725(["MiniDFA4 {1}"])
MiniDFA5_-52767551(["MiniDFA5 {1}"])
MiniDFA6_-1464457935(["MiniDFA6 {1}"])
MiniDFA7_-790763159(["MiniDFA7 {1}"])
MiniDFA8_1276944024(["MiniDFA8 {1}"])
MiniDFA9_-413827859(["MiniDFA9 {1}"])
MiniDFA10_412167803[\"MiniDFA10 {1}"/]
MiniDFA0_87021770 -->|"u"|MiniDFA1_2081460149
MiniDFA1_2081460149 -->|"s"|MiniDFA2_624432673
MiniDFA2_624432673 -->|"a"|MiniDFA3_320374368
MiniDFA3_320374368 -->|"m"|MiniDFA4_299585725
MiniDFA4_299585725 -->|"p"|MiniDFA5_-52767551
MiniDFA5_-52767551 -->|"l"|MiniDFA6_-1464457935
MiniDFA6_-1464457935 -->|"e"|MiniDFA7_-790763159
MiniDFA7_-790763159 -->|"r"|MiniDFA8_1276944024
MiniDFA8_1276944024 -->|"3"|MiniDFA9_-413827859
MiniDFA9_-413827859 -->|"D"|MiniDFA10_412167803
```
-------------------------------
