# 'usampler2DArray'

pattern: `usampler2DArray`

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
eNFA145_30_54349751[["εNFA145-30 regex start"]]
eNFA145_0_19385714[["εNFA145-0 char{1, 1}"]]
eNFA145_1_40253700[["εNFA145-1 char[1]"]]
eNFA145_2_26738982[["εNFA145-2 char{1, 1}"]]
eNFA145_3_39324249[["εNFA145-3 char[1]"]]
eNFA145_4_18373927[["εNFA145-4 char{1, 1}"]]
eNFA145_5_31147615[["εNFA145-5 char[1]"]]
eNFA145_6_11893084[["εNFA145-6 char{1, 1}"]]
eNFA145_7_39928893[["εNFA145-7 char[1]"]]
eNFA145_8_23815725[["εNFA145-8 char{1, 1}"]]
eNFA145_9_13014940[["εNFA145-9 char[1]"]]
eNFA145_10_50025604[["εNFA145-10 char{1, 1}"]]
eNFA145_11_47577252[["εNFA145-11 char[1]"]]
eNFA145_12_25542086[["εNFA145-12 char{1, 1}"]]
eNFA145_13_28552188[["εNFA145-13 char[1]"]]
eNFA145_14_55643101[["εNFA145-14 char{1, 1}"]]
eNFA145_15_31025868[["εNFA145-15 char[1]"]]
eNFA145_16_10797361[["εNFA145-16 char{1, 1}"]]
eNFA145_17_30067389[["εNFA145-17 char[1]"]]
eNFA145_18_2171049[["εNFA145-18 char{1, 1}"]]
eNFA145_19_19539446[["εNFA145-19 char[1]"]]
eNFA145_20_41637294[["εNFA145-20 char{1, 1}"]]
eNFA145_21_39191328[["εNFA145-21 char[1]"]]
eNFA145_22_17177639[["εNFA145-22 char{1, 1}"]]
eNFA145_23_20381027[["εNFA145-23 char[1]"]]
eNFA145_24_49211517[["εNFA145-24 char{1, 1}"]]
eNFA145_25_40250470[["εNFA145-25 char[1]"]]
eNFA145_26_26709911[["εNFA145-26 char{1, 1}"]]
eNFA145_27_39062609[["εNFA145-27 char[1]"]]
eNFA145_28_16019165[["εNFA145-28 char{1, 1}"]]
eNFA145_29_9954765[["εNFA145-29 char[1]"]]
eNFA145_31_22484025[["εNFA145-31 regex end"]]
eNFA145_32_1029633[["εNFA145-32 post-regex start"]]
eNFA145_33_9266704[\"εNFA145-33 post-regex end"/]
eNFA145_30_54349751 -.->|"ε"|eNFA145_0_19385714
eNFA145_0_19385714 -->|"u"|eNFA145_1_40253700
eNFA145_1_40253700 -.->|"ε"|eNFA145_2_26738982
eNFA145_2_26738982 -->|"s"|eNFA145_3_39324249
eNFA145_3_39324249 -.->|"ε"|eNFA145_4_18373927
eNFA145_4_18373927 -->|"a"|eNFA145_5_31147615
eNFA145_5_31147615 -.->|"ε"|eNFA145_6_11893084
eNFA145_6_11893084 -->|"m"|eNFA145_7_39928893
eNFA145_7_39928893 -.->|"ε"|eNFA145_8_23815725
eNFA145_8_23815725 -->|"p"|eNFA145_9_13014940
eNFA145_9_13014940 -.->|"ε"|eNFA145_10_50025604
eNFA145_10_50025604 -->|"l"|eNFA145_11_47577252
eNFA145_11_47577252 -.->|"ε"|eNFA145_12_25542086
eNFA145_12_25542086 -->|"e"|eNFA145_13_28552188
eNFA145_13_28552188 -.->|"ε"|eNFA145_14_55643101
eNFA145_14_55643101 -->|"r"|eNFA145_15_31025868
eNFA145_15_31025868 -.->|"ε"|eNFA145_16_10797361
eNFA145_16_10797361 -->|"2"|eNFA145_17_30067389
eNFA145_17_30067389 -.->|"ε"|eNFA145_18_2171049
eNFA145_18_2171049 -->|"D"|eNFA145_19_19539446
eNFA145_19_19539446 -.->|"ε"|eNFA145_20_41637294
eNFA145_20_41637294 -->|"A"|eNFA145_21_39191328
eNFA145_21_39191328 -.->|"ε"|eNFA145_22_17177639
eNFA145_22_17177639 -->|"r"|eNFA145_23_20381027
eNFA145_23_20381027 -.->|"ε"|eNFA145_24_49211517
eNFA145_24_49211517 -->|"r"|eNFA145_25_40250470
eNFA145_25_40250470 -.->|"ε"|eNFA145_26_26709911
eNFA145_26_26709911 -->|"a"|eNFA145_27_39062609
eNFA145_27_39062609 -.->|"ε"|eNFA145_28_16019165
eNFA145_28_16019165 -->|"y"|eNFA145_29_9954765
eNFA145_29_9954765 -.->|"ε"|eNFA145_31_22484025
eNFA145_31_22484025 -.->|"ε"|eNFA145_32_1029633
eNFA145_32_1029633 -.->|"ε"|eNFA145_33_9266704
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
eNFA145_30_16291478[["εNFA145-30 regex start"]]
eNFA145_0_12405580[["εNFA145-0 char{1, 1}"]]
eNFA145_1_44541364[["εNFA145-1 char[1]"]]
eNFA145_2_65327957[["εNFA145-2 char{1, 1}"]]
eNFA145_3_51080706[["εNFA145-3 char[1]"]]
eNFA145_4_57073170[["εNFA145-4 char{1, 1}"]]
eNFA145_5_43896488[["εNFA145-5 char[1]"]]
eNFA145_6_59524076[["εNFA145-6 char{1, 1}"]]
eNFA145_7_65954639[["εNFA145-7 char[1]"]]
eNFA145_8_56720842[["εNFA145-8 char{1, 1}"]]
eNFA145_9_40725534[["εNFA145-9 char[1]"]]
eNFA145_10_30985493[["εNFA145-10 char{1, 1}"]]
eNFA145_11_10433982[["εNFA145-11 char[1]"]]
eNFA145_12_26796980[["εNFA145-12 char{1, 1}"]]
eNFA145_13_39846231[["εNFA145-13 char[1]"]]
eNFA145_14_23071760[["εNFA145-14 char{1, 1}"]]
eNFA145_15_6319248[["εNFA145-15 char[1]"]]
eNFA145_16_56873232[["εNFA145-16 char{1, 1}"]]
eNFA145_17_42097041[["εNFA145-17 char[1]"]]
eNFA145_18_43329052[["εNFA145-18 char{1, 1}"]]
eNFA145_19_54417155[["εNFA145-19 char[1]"]]
eNFA145_20_19992349[["εNFA145-20 char{1, 1}"]]
eNFA145_21_45713421[["εNFA145-21 char[1]"]]
eNFA145_22_8767611[["εNFA145-22 char{1, 1}"]]
eNFA145_23_11799640[["εNFA145-23 char[1]"]]
eNFA145_24_39087901[["εNFA145-24 char{1, 1}"]]
eNFA145_25_16246796[["εNFA145-25 char[1]"]]
eNFA145_26_12003436[["εNFA145-26 char{1, 1}"]]
eNFA145_27_40922063[["εNFA145-27 char[1]"]]
eNFA145_28_32754255[["εNFA145-28 char{1, 1}"]]
eNFA145_29_26352844[\"εNFA145-29 char[1]"/]
eNFA145_31_35849007[\"εNFA145-31 regex end"/]
eNFA145_32_54205609[\"εNFA145-32 post-regex start"/]
eNFA145_33_18088435[\"εNFA145-33 post-regex end"/]
eNFA145_30_16291478 -.->|"ε"|eNFA145_0_12405580
eNFA145_30_16291478 -->|"u"|eNFA145_1_44541364
eNFA145_0_12405580 -->|"u"|eNFA145_1_44541364
eNFA145_1_44541364 -.->|"ε"|eNFA145_2_65327957
eNFA145_1_44541364 -->|"s"|eNFA145_3_51080706
eNFA145_2_65327957 -->|"s"|eNFA145_3_51080706
eNFA145_3_51080706 -.->|"ε"|eNFA145_4_57073170
eNFA145_3_51080706 -->|"a"|eNFA145_5_43896488
eNFA145_4_57073170 -->|"a"|eNFA145_5_43896488
eNFA145_5_43896488 -.->|"ε"|eNFA145_6_59524076
eNFA145_5_43896488 -->|"m"|eNFA145_7_65954639
eNFA145_6_59524076 -->|"m"|eNFA145_7_65954639
eNFA145_7_65954639 -.->|"ε"|eNFA145_8_56720842
eNFA145_7_65954639 -->|"p"|eNFA145_9_40725534
eNFA145_8_56720842 -->|"p"|eNFA145_9_40725534
eNFA145_9_40725534 -.->|"ε"|eNFA145_10_30985493
eNFA145_9_40725534 -->|"l"|eNFA145_11_10433982
eNFA145_10_30985493 -->|"l"|eNFA145_11_10433982
eNFA145_11_10433982 -.->|"ε"|eNFA145_12_26796980
eNFA145_11_10433982 -->|"e"|eNFA145_13_39846231
eNFA145_12_26796980 -->|"e"|eNFA145_13_39846231
eNFA145_13_39846231 -.->|"ε"|eNFA145_14_23071760
eNFA145_13_39846231 -->|"r"|eNFA145_15_6319248
eNFA145_14_23071760 -->|"r"|eNFA145_15_6319248
eNFA145_15_6319248 -.->|"ε"|eNFA145_16_56873232
eNFA145_15_6319248 -->|"2"|eNFA145_17_42097041
eNFA145_16_56873232 -->|"2"|eNFA145_17_42097041
eNFA145_17_42097041 -.->|"ε"|eNFA145_18_43329052
eNFA145_17_42097041 -->|"D"|eNFA145_19_54417155
eNFA145_18_43329052 -->|"D"|eNFA145_19_54417155
eNFA145_19_54417155 -.->|"ε"|eNFA145_20_19992349
eNFA145_19_54417155 -->|"A"|eNFA145_21_45713421
eNFA145_20_19992349 -->|"A"|eNFA145_21_45713421
eNFA145_21_45713421 -.->|"ε"|eNFA145_22_8767611
eNFA145_21_45713421 -->|"r"|eNFA145_23_11799640
eNFA145_22_8767611 -->|"r"|eNFA145_23_11799640
eNFA145_23_11799640 -.->|"ε"|eNFA145_24_39087901
eNFA145_23_11799640 -->|"r"|eNFA145_25_16246796
eNFA145_24_39087901 -->|"r"|eNFA145_25_16246796
eNFA145_25_16246796 -.->|"ε"|eNFA145_26_12003436
eNFA145_25_16246796 -->|"a"|eNFA145_27_40922063
eNFA145_26_12003436 -->|"a"|eNFA145_27_40922063
eNFA145_27_40922063 -.->|"ε"|eNFA145_28_32754255
eNFA145_27_40922063 -->|"y"|eNFA145_29_26352844
eNFA145_28_32754255 -->|"y"|eNFA145_29_26352844
eNFA145_29_26352844 -.->|"ε"|eNFA145_31_35849007
eNFA145_29_26352844 -.->|"ε"|eNFA145_32_54205609
eNFA145_29_26352844 -.->|"ε"|eNFA145_33_18088435
eNFA145_31_35849007 -.->|"ε"|eNFA145_32_54205609
eNFA145_31_35849007 -.->|"ε"|eNFA145_33_18088435
eNFA145_32_54205609 -.->|"ε"|eNFA145_33_18088435
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
NFA145_30_28578190("NFA145-30 regex start")
NFA145_1_55877124("NFA145-1 char[1]")
NFA145_3_33132068("NFA145-3 char[1]")
NFA145_5_29753161("NFA145-5 char[1]")
NFA145_7_66451858("NFA145-7 char[1]")
NFA145_9_61195818("NFA145-9 char[1]")
NFA145_11_13891457("NFA145-11 char[1]")
NFA145_13_57914257("NFA145-13 char[1]")
NFA145_15_51466265("NFA145-15 char[1]")
NFA145_17_60543203("NFA145-17 char[1]")
NFA145_19_8017921("NFA145-19 char[1]")
NFA145_21_5052426("NFA145-21 char[1]")
NFA145_23_45471841("NFA145-23 char[1]")
NFA145_25_6593390("NFA145-25 char[1]")
NFA145_27_59340514("NFA145-27 char[1]")
NFA145_29_64302582[\"NFA145-29 char[1]"/]
NFA145_30_28578190 -->|"u"|NFA145_1_55877124
NFA145_1_55877124 -->|"s"|NFA145_3_33132068
NFA145_3_33132068 -->|"a"|NFA145_5_29753161
NFA145_5_29753161 -->|"m"|NFA145_7_66451858
NFA145_7_66451858 -->|"p"|NFA145_9_61195818
NFA145_9_61195818 -->|"l"|NFA145_11_13891457
NFA145_11_13891457 -->|"e"|NFA145_13_57914257
NFA145_13_57914257 -->|"r"|NFA145_15_51466265
NFA145_15_51466265 -->|"2"|NFA145_17_60543203
NFA145_17_60543203 -->|"D"|NFA145_19_8017921
NFA145_19_8017921 -->|"A"|NFA145_21_5052426
NFA145_21_5052426 -->|"r"|NFA145_23_45471841
NFA145_23_45471841 -->|"r"|NFA145_25_6593390
NFA145_25_6593390 -->|"a"|NFA145_27_59340514
NFA145_27_59340514 -->|"y"|NFA145_29_64302582
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
subgraph DFA0_-633468856["DFA0 regex start"]
NFA145_30_28578190_0("NFA145-30 regex start")
end
subgraph DFA1_679709768["DFA1 {1}"]
NFA145_1_55877124_1("NFA145-1 char[1]")
end
subgraph DFA2_1027943403["DFA2 {1}"]
NFA145_3_33132068_2("NFA145-3 char[1]")
end
subgraph DFA3_-1944309519["DFA3 {1}"]
NFA145_5_29753161_3("NFA145-5 char[1]")
end
subgraph DFA4_-2085262183["DFA4 {1}"]
NFA145_7_66451858_4("NFA145-7 char[1]")
end
subgraph DFA5_-698212645["DFA5 {1}"]
NFA145_9_61195818_5("NFA145-9 char[1]")
end
subgraph DFA6_1902851["DFA6 {1}"]
NFA145_11_13891457_6("NFA145-11 char[1]")
end
subgraph DFA7_-1160186186["DFA7 {1}"]
NFA145_13_57914257_7("NFA145-13 char[1]")
end
subgraph DFA8_-1165363945["DFA8 {1}"]
NFA145_15_51466265_8("NFA145-15 char[1]")
end
subgraph DFA9_701202827["DFA9 {1}"]
NFA145_17_60543203_9("NFA145-17 char[1]")
end
subgraph DFA10_-44476127["DFA10 {1}"]
NFA145_19_8017921_10("NFA145-19 char[1]")
end
subgraph DFA11_-1190100252["DFA11 {1}"]
NFA145_21_5052426_11("NFA145-21 char[1]")
end
subgraph DFA12_-3207167["DFA12 {1}"]
NFA145_23_45471841_12("NFA145-23 char[1]")
end
subgraph DFA13_1758726982["DFA13 {1}"]
NFA145_25_6593390_13("NFA145-25 char[1]")
end
subgraph DFA14_-2084530300["DFA14 {1}"]
NFA145_27_59340514_14("NFA145-27 char[1]")
end
subgraph DFA15_1181614205["DFA15 {1}"]
NFA145_29_64302582_15[\"NFA145-29 char[1]"/]
end
DFA0_-633468856 -->|"u"|DFA1_679709768
DFA1_679709768 -->|"s"|DFA2_1027943403
DFA2_1027943403 -->|"a"|DFA3_-1944309519
DFA3_-1944309519 -->|"m"|DFA4_-2085262183
DFA4_-2085262183 -->|"p"|DFA5_-698212645
DFA5_-698212645 -->|"l"|DFA6_1902851
DFA6_1902851 -->|"e"|DFA7_-1160186186
DFA7_-1160186186 -->|"r"|DFA8_-1165363945
DFA8_-1165363945 -->|"2"|DFA9_701202827
DFA9_701202827 -->|"D"|DFA10_-44476127
DFA10_-44476127 -->|"A"|DFA11_-1190100252
DFA11_-1190100252 -->|"r"|DFA12_-3207167
DFA12_-3207167 -->|"r"|DFA13_1758726982
DFA13_1758726982 -->|"a"|DFA14_-2084530300
DFA14_-2084530300 -->|"y"|DFA15_1181614205
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
DFA0_-633468856{{"DFA0 regex start"}}
DFA1_679709768{{"DFA1 {1}"}}
DFA2_1027943403{{"DFA2 {1}"}}
DFA3_-1944309519{{"DFA3 {1}"}}
DFA4_-2085262183{{"DFA4 {1}"}}
DFA5_-698212645{{"DFA5 {1}"}}
DFA6_1902851{{"DFA6 {1}"}}
DFA7_-1160186186{{"DFA7 {1}"}}
DFA8_-1165363945{{"DFA8 {1}"}}
DFA9_701202827{{"DFA9 {1}"}}
DFA10_-44476127{{"DFA10 {1}"}}
DFA11_-1190100252{{"DFA11 {1}"}}
DFA12_-3207167{{"DFA12 {1}"}}
DFA13_1758726982{{"DFA13 {1}"}}
DFA14_-2084530300{{"DFA14 {1}"}}
DFA15_1181614205[\"DFA15 {1}"/]
DFA0_-633468856 -->|"u"|DFA1_679709768
DFA1_679709768 -->|"s"|DFA2_1027943403
DFA2_1027943403 -->|"a"|DFA3_-1944309519
DFA3_-1944309519 -->|"m"|DFA4_-2085262183
DFA4_-2085262183 -->|"p"|DFA5_-698212645
DFA5_-698212645 -->|"l"|DFA6_1902851
DFA6_1902851 -->|"e"|DFA7_-1160186186
DFA7_-1160186186 -->|"r"|DFA8_-1165363945
DFA8_-1165363945 -->|"2"|DFA9_701202827
DFA9_701202827 -->|"D"|DFA10_-44476127
DFA10_-44476127 -->|"A"|DFA11_-1190100252
DFA11_-1190100252 -->|"r"|DFA12_-3207167
DFA12_-3207167 -->|"r"|DFA13_1758726982
DFA13_1758726982 -->|"a"|DFA14_-2084530300
DFA14_-2084530300 -->|"y"|DFA15_1181614205
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
subgraph MiniDFA0_-884480728["MiniDFA0 {1}"]
DFA0_-633468856_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-133932118["MiniDFA1 {1}"]
DFA1_679709768_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_822478987["MiniDFA2 {1}"]
DFA2_1027943403_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1802669347["MiniDFA4 {1}"]
DFA3_-1944309519_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1109438312["MiniDFA5 {1}"]
DFA4_-2085262183_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_342385180["MiniDFA6 {1}"]
DFA5_-698212645_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_1267106558["MiniDFA7 {1}"]
DFA6_1902851_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-986771057["MiniDFA8 {1}"]
DFA7_-1160186186_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_-1849562868["MiniDFA11 {1}"]
DFA8_-1165363945_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_82013085["MiniDFA12 {1}"]
DFA9_701202827_9{{"DFA9 {1}"}}
end
subgraph MiniDFA13_-1752000780["MiniDFA13 {1}"]
DFA10_-44476127_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_-1060581916["MiniDFA9 {1}"]
DFA11_-1190100252_11{{"DFA11 {1}"}}
end
subgraph MiniDFA10_2015945354["MiniDFA10 {1}"]
DFA12_-3207167_12{{"DFA12 {1}"}}
end
subgraph MiniDFA3_-2009657304["MiniDFA3 {1}"]
DFA13_1758726982_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_683007015["MiniDFA14 {1}"]
DFA14_-2084530300_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_-694210532["MiniDFA15 {1}"]
DFA15_1181614205_15[\"DFA15 {1}"/]
end
MiniDFA0_-884480728 -->|"u"|MiniDFA1_-133932118
MiniDFA1_-133932118 -->|"s"|MiniDFA2_822478987
MiniDFA2_822478987 -->|"a"|MiniDFA4_1802669347
MiniDFA4_1802669347 -->|"m"|MiniDFA5_-1109438312
MiniDFA5_-1109438312 -->|"p"|MiniDFA6_342385180
MiniDFA6_342385180 -->|"l"|MiniDFA7_1267106558
MiniDFA7_1267106558 -->|"e"|MiniDFA8_-986771057
MiniDFA8_-986771057 -->|"r"|MiniDFA11_-1849562868
MiniDFA11_-1849562868 -->|"2"|MiniDFA12_82013085
MiniDFA12_82013085 -->|"D"|MiniDFA13_-1752000780
MiniDFA13_-1752000780 -->|"A"|MiniDFA9_-1060581916
MiniDFA9_-1060581916 -->|"r"|MiniDFA10_2015945354
MiniDFA10_2015945354 -->|"r"|MiniDFA3_-2009657304
MiniDFA3_-2009657304 -->|"a"|MiniDFA14_683007015
MiniDFA14_683007015 -->|"y"|MiniDFA15_-694210532
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
MiniDFA0_-884480728(["MiniDFA0 {1}"])
MiniDFA1_-133932118(["MiniDFA1 {1}"])
MiniDFA2_822478987(["MiniDFA2 {1}"])
MiniDFA4_1802669347(["MiniDFA4 {1}"])
MiniDFA5_-1109438312(["MiniDFA5 {1}"])
MiniDFA6_342385180(["MiniDFA6 {1}"])
MiniDFA7_1267106558(["MiniDFA7 {1}"])
MiniDFA8_-986771057(["MiniDFA8 {1}"])
MiniDFA11_-1849562868(["MiniDFA11 {1}"])
MiniDFA12_82013085(["MiniDFA12 {1}"])
MiniDFA13_-1752000780(["MiniDFA13 {1}"])
MiniDFA9_-1060581916(["MiniDFA9 {1}"])
MiniDFA10_2015945354(["MiniDFA10 {1}"])
MiniDFA3_-2009657304(["MiniDFA3 {1}"])
MiniDFA14_683007015(["MiniDFA14 {1}"])
MiniDFA15_-694210532[\"MiniDFA15 {1}"/]
MiniDFA0_-884480728 -->|"u"|MiniDFA1_-133932118
MiniDFA1_-133932118 -->|"s"|MiniDFA2_822478987
MiniDFA2_822478987 -->|"a"|MiniDFA4_1802669347
MiniDFA4_1802669347 -->|"m"|MiniDFA5_-1109438312
MiniDFA5_-1109438312 -->|"p"|MiniDFA6_342385180
MiniDFA6_342385180 -->|"l"|MiniDFA7_1267106558
MiniDFA7_1267106558 -->|"e"|MiniDFA8_-986771057
MiniDFA8_-986771057 -->|"r"|MiniDFA11_-1849562868
MiniDFA11_-1849562868 -->|"2"|MiniDFA12_82013085
MiniDFA12_82013085 -->|"D"|MiniDFA13_-1752000780
MiniDFA13_-1752000780 -->|"A"|MiniDFA9_-1060581916
MiniDFA9_-1060581916 -->|"r"|MiniDFA10_2015945354
MiniDFA10_2015945354 -->|"r"|MiniDFA3_-2009657304
MiniDFA3_-2009657304 -->|"a"|MiniDFA14_683007015
MiniDFA14_683007015 -->|"y"|MiniDFA15_-694210532
```
-------------------------------
