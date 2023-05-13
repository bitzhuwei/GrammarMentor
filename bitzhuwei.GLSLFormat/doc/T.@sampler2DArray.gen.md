# 'sampler2DArray'

pattern: `sampler2DArray`

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
eNFA128_28_57352691[["εNFA128-28 regex start"]]
eNFA128_0_46412171[["εNFA128-0 char{1, 1}"]]
eNFA128_1_15056362[["εNFA128-1 char[1]"]]
eNFA128_2_1289536[["εNFA128-2 char{1, 1}"]]
eNFA128_3_11605830[["εNFA128-3 char[1]"]]
eNFA128_4_37343614[["εNFA128-4 char{1, 1}"]]
eNFA128_5_548207[["εNFA128-5 char[1]"]]
eNFA128_6_4933868[["εNFA128-6 char{1, 1}"]]
eNFA128_7_44404812[["εNFA128-7 char[1]"]]
eNFA128_8_64098994[["εNFA128-8 char{1, 1}"]]
eNFA128_9_40020038[["εNFA128-9 char[1]"]]
eNFA128_10_24636025[["εNFA128-10 char{1, 1}"]]
eNFA128_11_20397636[["εNFA128-11 char[1]"]]
eNFA128_12_49361000[["εNFA128-12 char{1, 1}"]]
eNFA128_13_41595823[["εNFA128-13 char[1]"]]
eNFA128_14_38818088[["εNFA128-14 char{1, 1}"]]
eNFA128_15_13818478[["εNFA128-15 char[1]"]]
eNFA128_16_57257441[["εNFA128-16 char{1, 1}"]]
eNFA128_17_45554922[["εNFA128-17 char[1]"]]
eNFA128_18_7341114[["εNFA128-18 char{1, 1}"]]
eNFA128_19_66070026[["εNFA128-19 char[1]"]]
eNFA128_20_57759323[["εNFA128-20 char{1, 1}"]]
eNFA128_21_50071862[["εNFA128-21 char[1]"]]
eNFA128_22_47993581[["εNFA128-22 char{1, 1}"]]
eNFA128_23_29289047[["εNFA128-23 char[1]"]]
eNFA128_24_62274839[["εNFA128-24 char{1, 1}"]]
eNFA128_25_23602645[["εNFA128-25 char[1]"]]
eNFA128_26_11097218[["εNFA128-26 char{1, 1}"]]
eNFA128_27_32766103[["εNFA128-27 char[1]"]]
eNFA128_29_26459478[["εNFA128-29 regex end"]]
eNFA128_30_36808710[["εNFA128-30 post-regex start"]]
eNFA128_31_62842937[\"εNFA128-31 post-regex end"/]
eNFA128_28_57352691 -.->|"ε"|eNFA128_0_46412171
eNFA128_0_46412171 -->|"s"|eNFA128_1_15056362
eNFA128_1_15056362 -.->|"ε"|eNFA128_2_1289536
eNFA128_2_1289536 -->|"a"|eNFA128_3_11605830
eNFA128_3_11605830 -.->|"ε"|eNFA128_4_37343614
eNFA128_4_37343614 -->|"m"|eNFA128_5_548207
eNFA128_5_548207 -.->|"ε"|eNFA128_6_4933868
eNFA128_6_4933868 -->|"p"|eNFA128_7_44404812
eNFA128_7_44404812 -.->|"ε"|eNFA128_8_64098994
eNFA128_8_64098994 -->|"l"|eNFA128_9_40020038
eNFA128_9_40020038 -.->|"ε"|eNFA128_10_24636025
eNFA128_10_24636025 -->|"e"|eNFA128_11_20397636
eNFA128_11_20397636 -.->|"ε"|eNFA128_12_49361000
eNFA128_12_49361000 -->|"r"|eNFA128_13_41595823
eNFA128_13_41595823 -.->|"ε"|eNFA128_14_38818088
eNFA128_14_38818088 -->|"2"|eNFA128_15_13818478
eNFA128_15_13818478 -.->|"ε"|eNFA128_16_57257441
eNFA128_16_57257441 -->|"D"|eNFA128_17_45554922
eNFA128_17_45554922 -.->|"ε"|eNFA128_18_7341114
eNFA128_18_7341114 -->|"A"|eNFA128_19_66070026
eNFA128_19_66070026 -.->|"ε"|eNFA128_20_57759323
eNFA128_20_57759323 -->|"r"|eNFA128_21_50071862
eNFA128_21_50071862 -.->|"ε"|eNFA128_22_47993581
eNFA128_22_47993581 -->|"r"|eNFA128_23_29289047
eNFA128_23_29289047 -.->|"ε"|eNFA128_24_62274839
eNFA128_24_62274839 -->|"a"|eNFA128_25_23602645
eNFA128_25_23602645 -.->|"ε"|eNFA128_26_11097218
eNFA128_26_11097218 -->|"y"|eNFA128_27_32766103
eNFA128_27_32766103 -.->|"ε"|eNFA128_29_26459478
eNFA128_29_26459478 -.->|"ε"|eNFA128_30_36808710
eNFA128_30_36808710 -.->|"ε"|eNFA128_31_62842937
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
eNFA128_28_28715529[["εNFA128-28 regex start"]]
eNFA128_0_57113174[["εNFA128-0 char{1, 1}"]]
eNFA128_1_44256521[["εNFA128-1 char[1]"]]
eNFA128_2_62764371[["εNFA128-2 char{1, 1}"]]
eNFA128_3_28008429[["εNFA128-3 char[1]"]]
eNFA128_4_50749272[["εNFA128-4 char{1, 1}"]]
eNFA128_5_54090270[["εNFA128-5 char[1]"]]
eNFA128_6_17050382[["εNFA128-6 char{1, 1}"]]
eNFA128_7_19235715[["εNFA128-7 char[1]"]]
eNFA128_8_38903708[["εNFA128-8 char{1, 1}"]]
eNFA128_9_14589060[["εNFA128-9 char[1]"]]
eNFA128_10_64192683[["εNFA128-10 char{1, 1}"]]
eNFA128_11_40863243[["εNFA128-11 char[1]"]]
eNFA128_12_32224867[["εNFA128-12 char{1, 1}"]]
eNFA128_13_21588349[["εNFA128-13 char[1]"]]
eNFA128_14_60077419[["εNFA128-14 char{1, 1}"]]
eNFA128_15_3825860[["εNFA128-15 char[1]"]]
eNFA128_16_34432747[["εNFA128-16 char{1, 1}"]]
eNFA128_17_41459272[["εNFA128-17 char[1]"]]
eNFA128_18_37589132[["εNFA128-18 char{1, 1}"]]
eNFA128_19_2757872[["εNFA128-19 char[1]"]]
eNFA128_20_24820853[["εNFA128-20 char{1, 1}"]]
eNFA128_21_22061093[["εNFA128-21 char[1]"]]
eNFA128_22_64332111[["εNFA128-22 char{1, 1}"]]
eNFA128_23_42118094[["εNFA128-23 char[1]"]]
eNFA128_24_43518530[["εNFA128-24 char{1, 1}"]]
eNFA128_25_56122452[["εNFA128-25 char[1]"]]
eNFA128_26_35340021[["εNFA128-26 char{1, 1}"]]
eNFA128_27_49624734[\"εNFA128-27 char[1]"/]
eNFA128_29_43969424[\"εNFA128-29 regex end"/]
eNFA128_30_60180500[\"εNFA128-30 post-regex start"/]
eNFA128_31_4753596[\"εNFA128-31 post-regex end"/]
eNFA128_28_28715529 -.->|"ε"|eNFA128_0_57113174
eNFA128_28_28715529 -->|"s"|eNFA128_1_44256521
eNFA128_0_57113174 -->|"s"|eNFA128_1_44256521
eNFA128_1_44256521 -.->|"ε"|eNFA128_2_62764371
eNFA128_1_44256521 -->|"a"|eNFA128_3_28008429
eNFA128_2_62764371 -->|"a"|eNFA128_3_28008429
eNFA128_3_28008429 -.->|"ε"|eNFA128_4_50749272
eNFA128_3_28008429 -->|"m"|eNFA128_5_54090270
eNFA128_4_50749272 -->|"m"|eNFA128_5_54090270
eNFA128_5_54090270 -.->|"ε"|eNFA128_6_17050382
eNFA128_5_54090270 -->|"p"|eNFA128_7_19235715
eNFA128_6_17050382 -->|"p"|eNFA128_7_19235715
eNFA128_7_19235715 -.->|"ε"|eNFA128_8_38903708
eNFA128_7_19235715 -->|"l"|eNFA128_9_14589060
eNFA128_8_38903708 -->|"l"|eNFA128_9_14589060
eNFA128_9_14589060 -.->|"ε"|eNFA128_10_64192683
eNFA128_9_14589060 -->|"e"|eNFA128_11_40863243
eNFA128_10_64192683 -->|"e"|eNFA128_11_40863243
eNFA128_11_40863243 -.->|"ε"|eNFA128_12_32224867
eNFA128_11_40863243 -->|"r"|eNFA128_13_21588349
eNFA128_12_32224867 -->|"r"|eNFA128_13_21588349
eNFA128_13_21588349 -.->|"ε"|eNFA128_14_60077419
eNFA128_13_21588349 -->|"2"|eNFA128_15_3825860
eNFA128_14_60077419 -->|"2"|eNFA128_15_3825860
eNFA128_15_3825860 -.->|"ε"|eNFA128_16_34432747
eNFA128_15_3825860 -->|"D"|eNFA128_17_41459272
eNFA128_16_34432747 -->|"D"|eNFA128_17_41459272
eNFA128_17_41459272 -.->|"ε"|eNFA128_18_37589132
eNFA128_17_41459272 -->|"A"|eNFA128_19_2757872
eNFA128_18_37589132 -->|"A"|eNFA128_19_2757872
eNFA128_19_2757872 -.->|"ε"|eNFA128_20_24820853
eNFA128_19_2757872 -->|"r"|eNFA128_21_22061093
eNFA128_20_24820853 -->|"r"|eNFA128_21_22061093
eNFA128_21_22061093 -.->|"ε"|eNFA128_22_64332111
eNFA128_21_22061093 -->|"r"|eNFA128_23_42118094
eNFA128_22_64332111 -->|"r"|eNFA128_23_42118094
eNFA128_23_42118094 -.->|"ε"|eNFA128_24_43518530
eNFA128_23_42118094 -->|"a"|eNFA128_25_56122452
eNFA128_24_43518530 -->|"a"|eNFA128_25_56122452
eNFA128_25_56122452 -.->|"ε"|eNFA128_26_35340021
eNFA128_25_56122452 -->|"y"|eNFA128_27_49624734
eNFA128_26_35340021 -->|"y"|eNFA128_27_49624734
eNFA128_27_49624734 -.->|"ε"|eNFA128_29_43969424
eNFA128_27_49624734 -.->|"ε"|eNFA128_30_60180500
eNFA128_27_49624734 -.->|"ε"|eNFA128_31_4753596
eNFA128_29_43969424 -.->|"ε"|eNFA128_30_60180500
eNFA128_29_43969424 -.->|"ε"|eNFA128_31_4753596
eNFA128_30_60180500 -.->|"ε"|eNFA128_31_4753596
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
NFA128_28_42782368("NFA128-28 regex start")
NFA128_1_49496992("NFA128-1 char[1]")
NFA128_3_42819751("NFA128-3 char[1]")
NFA128_5_49833445("NFA128-5 char[1]")
NFA128_7_45847827("NFA128-7 char[1]")
NFA128_9_9977267("NFA128-9 char[1]")
NFA128_11_22686540("NFA128-11 char[1]")
NFA128_13_2852273("NFA128-13 char[1]")
NFA128_15_25670457("NFA128-15 char[1]")
NFA128_17_29707527("NFA128-17 char[1]")
NFA128_19_66041155("NFA128-19 char[1]")
NFA128_21_57499486("NFA128-21 char[1]")
NFA128_23_47733329("NFA128-23 char[1]")
NFA128_25_26946781("NFA128-25 char[1]")
NFA128_27_41194444[\"NFA128-27 char[1]"/]
NFA128_28_42782368 -->|"s"|NFA128_1_49496992
NFA128_1_49496992 -->|"a"|NFA128_3_42819751
NFA128_3_42819751 -->|"m"|NFA128_5_49833445
NFA128_5_49833445 -->|"p"|NFA128_7_45847827
NFA128_7_45847827 -->|"l"|NFA128_9_9977267
NFA128_9_9977267 -->|"e"|NFA128_11_22686540
NFA128_11_22686540 -->|"r"|NFA128_13_2852273
NFA128_13_2852273 -->|"2"|NFA128_15_25670457
NFA128_15_25670457 -->|"D"|NFA128_17_29707527
NFA128_17_29707527 -->|"A"|NFA128_19_66041155
NFA128_19_66041155 -->|"r"|NFA128_21_57499486
NFA128_21_57499486 -->|"r"|NFA128_23_47733329
NFA128_23_47733329 -->|"a"|NFA128_25_26946781
NFA128_25_26946781 -->|"y"|NFA128_27_41194444
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
subgraph DFA0_-1161207177["DFA0 regex start"]
NFA128_28_42782368_0("NFA128-28 regex start")
end
subgraph DFA1_1886889316["DFA1 {1}"]
NFA128_1_49496992_1("NFA128-1 char[1]")
end
subgraph DFA2_-999449730["DFA2 {1}"]
NFA128_3_42819751_2("NFA128-3 char[1]")
end
subgraph DFA3_51058504["DFA3 {1}"]
NFA128_5_49833445_3("NFA128-5 char[1]")
end
subgraph DFA4_-94302070["DFA4 {1}"]
NFA128_7_45847827_4("NFA128-7 char[1]")
end
subgraph DFA5_137089687["DFA5 {1}"]
NFA128_9_9977267_5("NFA128-9 char[1]")
end
subgraph DFA6_425875352["DFA6 {1}"]
NFA128_11_22686540_6("NFA128-11 char[1]")
end
subgraph DFA7_-298894018["DFA7 {1}"]
NFA128_13_2852273_7("NFA128-13 char[1]")
end
subgraph DFA8_-1243854625["DFA8 {1}"]
NFA128_15_25670457_8("NFA128-15 char[1]")
end
subgraph DFA9_-1430160665["DFA9 {1}"]
NFA128_17_29707527_9("NFA128-17 char[1]")
end
subgraph DFA10_1813215269["DFA10 {1}"]
NFA128_19_66041155_10("NFA128-19 char[1]")
end
subgraph DFA11_-347577209["DFA11 {1}"]
NFA128_21_57499486_11("NFA128-21 char[1]")
end
subgraph DFA12_1772416085["DFA12 {1}"]
NFA128_23_47733329_12("NFA128-23 char[1]")
end
subgraph DFA13_-847826890["DFA13 {1}"]
NFA128_25_26946781_13("NFA128-25 char[1]")
end
subgraph DFA14_115135535["DFA14 {1}"]
NFA128_27_41194444_14[\"NFA128-27 char[1]"/]
end
DFA0_-1161207177 -->|"s"|DFA1_1886889316
DFA1_1886889316 -->|"a"|DFA2_-999449730
DFA2_-999449730 -->|"m"|DFA3_51058504
DFA3_51058504 -->|"p"|DFA4_-94302070
DFA4_-94302070 -->|"l"|DFA5_137089687
DFA5_137089687 -->|"e"|DFA6_425875352
DFA6_425875352 -->|"r"|DFA7_-298894018
DFA7_-298894018 -->|"2"|DFA8_-1243854625
DFA8_-1243854625 -->|"D"|DFA9_-1430160665
DFA9_-1430160665 -->|"A"|DFA10_1813215269
DFA10_1813215269 -->|"r"|DFA11_-347577209
DFA11_-347577209 -->|"r"|DFA12_1772416085
DFA12_1772416085 -->|"a"|DFA13_-847826890
DFA13_-847826890 -->|"y"|DFA14_115135535
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
DFA0_-1161207177{{"DFA0 regex start"}}
DFA1_1886889316{{"DFA1 {1}"}}
DFA2_-999449730{{"DFA2 {1}"}}
DFA3_51058504{{"DFA3 {1}"}}
DFA4_-94302070{{"DFA4 {1}"}}
DFA5_137089687{{"DFA5 {1}"}}
DFA6_425875352{{"DFA6 {1}"}}
DFA7_-298894018{{"DFA7 {1}"}}
DFA8_-1243854625{{"DFA8 {1}"}}
DFA9_-1430160665{{"DFA9 {1}"}}
DFA10_1813215269{{"DFA10 {1}"}}
DFA11_-347577209{{"DFA11 {1}"}}
DFA12_1772416085{{"DFA12 {1}"}}
DFA13_-847826890{{"DFA13 {1}"}}
DFA14_115135535[\"DFA14 {1}"/]
DFA0_-1161207177 -->|"s"|DFA1_1886889316
DFA1_1886889316 -->|"a"|DFA2_-999449730
DFA2_-999449730 -->|"m"|DFA3_51058504
DFA3_51058504 -->|"p"|DFA4_-94302070
DFA4_-94302070 -->|"l"|DFA5_137089687
DFA5_137089687 -->|"e"|DFA6_425875352
DFA6_425875352 -->|"r"|DFA7_-298894018
DFA7_-298894018 -->|"2"|DFA8_-1243854625
DFA8_-1243854625 -->|"D"|DFA9_-1430160665
DFA9_-1430160665 -->|"A"|DFA10_1813215269
DFA10_1813215269 -->|"r"|DFA11_-347577209
DFA11_-347577209 -->|"r"|DFA12_1772416085
DFA12_1772416085 -->|"a"|DFA13_-847826890
DFA13_-847826890 -->|"y"|DFA14_115135535
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
subgraph MiniDFA0_-625205682["MiniDFA0 {1}"]
DFA0_-1161207177_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1823854634["MiniDFA1 {1}"]
DFA1_1886889316_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_-1397260920["MiniDFA3 {1}"]
DFA2_-999449730_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_77423032["MiniDFA4 {1}"]
DFA3_51058504_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-2139848956["MiniDFA5 {1}"]
DFA4_-94302070_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-250295043["MiniDFA6 {1}"]
DFA5_137089687_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1034487593["MiniDFA7 {1}"]
DFA6_425875352_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_-814987576["MiniDFA10 {1}"]
DFA7_-298894018_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_-1779568955["MiniDFA11 {1}"]
DFA8_-1243854625_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_995763955["MiniDFA12 {1}"]
DFA9_-1430160665_9{{"DFA9 {1}"}}
end
subgraph MiniDFA8_1424412601["MiniDFA8 {1}"]
DFA10_1813215269_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_796247443["MiniDFA9 {1}"]
DFA11_-347577209_11{{"DFA11 {1}"}}
end
subgraph MiniDFA2_-1194786950["MiniDFA2 {1}"]
DFA12_1772416085_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-679833182["MiniDFA13 {1}"]
DFA13_-847826890_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-386657775["MiniDFA14 {1}"]
DFA14_115135535_14[\"DFA14 {1}"/]
end
MiniDFA0_-625205682 -->|"s"|MiniDFA1_1823854634
MiniDFA1_1823854634 -->|"a"|MiniDFA3_-1397260920
MiniDFA3_-1397260920 -->|"m"|MiniDFA4_77423032
MiniDFA4_77423032 -->|"p"|MiniDFA5_-2139848956
MiniDFA5_-2139848956 -->|"l"|MiniDFA6_-250295043
MiniDFA6_-250295043 -->|"e"|MiniDFA7_-1034487593
MiniDFA7_-1034487593 -->|"r"|MiniDFA10_-814987576
MiniDFA10_-814987576 -->|"2"|MiniDFA11_-1779568955
MiniDFA11_-1779568955 -->|"D"|MiniDFA12_995763955
MiniDFA12_995763955 -->|"A"|MiniDFA8_1424412601
MiniDFA8_1424412601 -->|"r"|MiniDFA9_796247443
MiniDFA9_796247443 -->|"r"|MiniDFA2_-1194786950
MiniDFA2_-1194786950 -->|"a"|MiniDFA13_-679833182
MiniDFA13_-679833182 -->|"y"|MiniDFA14_-386657775
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
MiniDFA0_-625205682(["MiniDFA0 {1}"])
MiniDFA1_1823854634(["MiniDFA1 {1}"])
MiniDFA3_-1397260920(["MiniDFA3 {1}"])
MiniDFA4_77423032(["MiniDFA4 {1}"])
MiniDFA5_-2139848956(["MiniDFA5 {1}"])
MiniDFA6_-250295043(["MiniDFA6 {1}"])
MiniDFA7_-1034487593(["MiniDFA7 {1}"])
MiniDFA10_-814987576(["MiniDFA10 {1}"])
MiniDFA11_-1779568955(["MiniDFA11 {1}"])
MiniDFA12_995763955(["MiniDFA12 {1}"])
MiniDFA8_1424412601(["MiniDFA8 {1}"])
MiniDFA9_796247443(["MiniDFA9 {1}"])
MiniDFA2_-1194786950(["MiniDFA2 {1}"])
MiniDFA13_-679833182(["MiniDFA13 {1}"])
MiniDFA14_-386657775[\"MiniDFA14 {1}"/]
MiniDFA0_-625205682 -->|"s"|MiniDFA1_1823854634
MiniDFA1_1823854634 -->|"a"|MiniDFA3_-1397260920
MiniDFA3_-1397260920 -->|"m"|MiniDFA4_77423032
MiniDFA4_77423032 -->|"p"|MiniDFA5_-2139848956
MiniDFA5_-2139848956 -->|"l"|MiniDFA6_-250295043
MiniDFA6_-250295043 -->|"e"|MiniDFA7_-1034487593
MiniDFA7_-1034487593 -->|"r"|MiniDFA10_-814987576
MiniDFA10_-814987576 -->|"2"|MiniDFA11_-1779568955
MiniDFA11_-1779568955 -->|"D"|MiniDFA12_995763955
MiniDFA12_995763955 -->|"A"|MiniDFA8_1424412601
MiniDFA8_1424412601 -->|"r"|MiniDFA9_796247443
MiniDFA9_796247443 -->|"r"|MiniDFA2_-1194786950
MiniDFA2_-1194786950 -->|"a"|MiniDFA13_-679833182
MiniDFA13_-679833182 -->|"y"|MiniDFA14_-386657775
```
-------------------------------
