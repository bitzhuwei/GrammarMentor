# 'iimage1DArray'

pattern: `iimage1DArray`

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
eNFA179_26_51385085[["εNFA179-26 regex start"]]
eNFA179_0_59812583[["εNFA179-0 char{1, 1}"]]
eNFA179_1_1442336[["εNFA179-1 char[1]"]]
eNFA179_2_12981025[["εNFA179-2 char{1, 1}"]]
eNFA179_3_49720363[["εNFA179-3 char[1]"]]
eNFA179_4_44830087[["εNFA179-4 char{1, 1}"]]
eNFA179_5_817607[["εNFA179-5 char[1]"]]
eNFA179_6_7358467[["εNFA179-6 char{1, 1}"]]
eNFA179_7_66226203[["εNFA179-7 char[1]"]]
eNFA179_8_59164922[["εNFA179-8 char{1, 1}"]]
eNFA179_9_62722256[["εNFA179-9 char[1]"]]
eNFA179_10_27629398[["εNFA179-10 char{1, 1}"]]
eNFA179_11_47337998[["εNFA179-11 char[1]"]]
eNFA179_12_23388799[["εNFA179-12 char{1, 1}"]]
eNFA179_13_9172604[["εNFA179-13 char[1]"]]
eNFA179_14_15444572[["εNFA179-14 char{1, 1}"]]
eNFA179_15_4783426[["εNFA179-15 char[1]"]]
eNFA179_16_43050838[["εNFA179-16 char{1, 1}"]]
eNFA179_17_51913225[["εNFA179-17 char[1]"]]
eNFA179_18_64565844[["εNFA179-18 char{1, 1}"]]
eNFA179_19_44221688[["εNFA179-19 char[1]"]]
eNFA179_20_62450879[["εNFA179-20 char{1, 1}"]]
eNFA179_21_25187000[["εNFA179-21 char[1]"]]
eNFA179_22_25356414[["εNFA179-22 char{1, 1}"]]
eNFA179_23_26881137[["εNFA179-23 char[1]"]]
eNFA179_24_40603642[["εNFA179-24 char{1, 1}"]]
eNFA179_25_29888458[["εNFA179-25 char[1]"]]
eNFA179_27_560666[["εNFA179-27 regex end"]]
eNFA179_28_5045995[["εNFA179-28 post-regex start"]]
eNFA179_29_45413958[\"εNFA179-29 post-regex end"/]
eNFA179_26_51385085 -.->|"ε"|eNFA179_0_59812583
eNFA179_0_59812583 -->|"i"|eNFA179_1_1442336
eNFA179_1_1442336 -.->|"ε"|eNFA179_2_12981025
eNFA179_2_12981025 -->|"i"|eNFA179_3_49720363
eNFA179_3_49720363 -.->|"ε"|eNFA179_4_44830087
eNFA179_4_44830087 -->|"m"|eNFA179_5_817607
eNFA179_5_817607 -.->|"ε"|eNFA179_6_7358467
eNFA179_6_7358467 -->|"a"|eNFA179_7_66226203
eNFA179_7_66226203 -.->|"ε"|eNFA179_8_59164922
eNFA179_8_59164922 -->|"g"|eNFA179_9_62722256
eNFA179_9_62722256 -.->|"ε"|eNFA179_10_27629398
eNFA179_10_27629398 -->|"e"|eNFA179_11_47337998
eNFA179_11_47337998 -.->|"ε"|eNFA179_12_23388799
eNFA179_12_23388799 -->|"1"|eNFA179_13_9172604
eNFA179_13_9172604 -.->|"ε"|eNFA179_14_15444572
eNFA179_14_15444572 -->|"D"|eNFA179_15_4783426
eNFA179_15_4783426 -.->|"ε"|eNFA179_16_43050838
eNFA179_16_43050838 -->|"A"|eNFA179_17_51913225
eNFA179_17_51913225 -.->|"ε"|eNFA179_18_64565844
eNFA179_18_64565844 -->|"r"|eNFA179_19_44221688
eNFA179_19_44221688 -.->|"ε"|eNFA179_20_62450879
eNFA179_20_62450879 -->|"r"|eNFA179_21_25187000
eNFA179_21_25187000 -.->|"ε"|eNFA179_22_25356414
eNFA179_22_25356414 -->|"a"|eNFA179_23_26881137
eNFA179_23_26881137 -.->|"ε"|eNFA179_24_40603642
eNFA179_24_40603642 -->|"y"|eNFA179_25_29888458
eNFA179_25_29888458 -.->|"ε"|eNFA179_27_560666
eNFA179_27_560666 -.->|"ε"|eNFA179_28_5045995
eNFA179_28_5045995 -.->|"ε"|eNFA179_29_45413958
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
eNFA179_26_6072445[["εNFA179-26 regex start"]]
eNFA179_0_54652007[["εNFA179-0 char{1, 1}"]]
eNFA179_1_22106023[["εNFA179-1 char[1]"]]
eNFA179_2_64736485[["εNFA179-2 char{1, 1}"]]
eNFA179_3_45757458[["εNFA179-3 char[1]"]]
eNFA179_4_9163943[["εNFA179-4 char{1, 1}"]]
eNFA179_5_15366630[["εNFA179-5 char[1]"]]
eNFA179_6_4081942[["εNFA179-6 char{1, 1}"]]
eNFA179_7_36737481[["εNFA179-7 char[1]"]]
eNFA179_8_62201881[["εNFA179-8 char{1, 1}"]]
eNFA179_9_22946022[["εNFA179-9 char[1]"]]
eNFA179_10_5187609[["εNFA179-10 char{1, 1}"]]
eNFA179_11_46688483[["εNFA179-11 char[1]"]]
eNFA179_12_17543165[["εNFA179-12 char{1, 1}"]]
eNFA179_13_23670760[["εNFA179-13 char[1]"]]
eNFA179_14_11710254[["εNFA179-14 char{1, 1}"]]
eNFA179_15_38283422[["εNFA179-15 char[1]"]]
eNFA179_16_9006483[["εNFA179-16 char{1, 1}"]]
eNFA179_17_13949484[["εNFA179-17 char[1]"]]
eNFA179_18_58436500[["εNFA179-18 char{1, 1}"]]
eNFA179_19_56166459[["εNFA179-19 char[1]"]]
eNFA179_20_35736091[["εNFA179-20 char{1, 1}"]]
eNFA179_21_53189363[["εNFA179-21 char[1]"]]
eNFA179_22_8942221[["εNFA179-22 char{1, 1}"]]
eNFA179_23_13371131[["εNFA179-23 char[1]"]]
eNFA179_24_53231316[["εNFA179-24 char{1, 1}"]]
eNFA179_25_9319803[\"εNFA179-25 char[1]"/]
eNFA179_27_16769368[\"εNFA179-27 regex end"/]
eNFA179_28_16706588[\"εNFA179-28 post-regex start"/]
eNFA179_29_16141568[\"εNFA179-29 post-regex end"/]
eNFA179_26_6072445 -.->|"ε"|eNFA179_0_54652007
eNFA179_26_6072445 -->|"i"|eNFA179_1_22106023
eNFA179_0_54652007 -->|"i"|eNFA179_1_22106023
eNFA179_1_22106023 -.->|"ε"|eNFA179_2_64736485
eNFA179_1_22106023 -->|"i"|eNFA179_3_45757458
eNFA179_2_64736485 -->|"i"|eNFA179_3_45757458
eNFA179_3_45757458 -.->|"ε"|eNFA179_4_9163943
eNFA179_3_45757458 -->|"m"|eNFA179_5_15366630
eNFA179_4_9163943 -->|"m"|eNFA179_5_15366630
eNFA179_5_15366630 -.->|"ε"|eNFA179_6_4081942
eNFA179_5_15366630 -->|"a"|eNFA179_7_36737481
eNFA179_6_4081942 -->|"a"|eNFA179_7_36737481
eNFA179_7_36737481 -.->|"ε"|eNFA179_8_62201881
eNFA179_7_36737481 -->|"g"|eNFA179_9_22946022
eNFA179_8_62201881 -->|"g"|eNFA179_9_22946022
eNFA179_9_22946022 -.->|"ε"|eNFA179_10_5187609
eNFA179_9_22946022 -->|"e"|eNFA179_11_46688483
eNFA179_10_5187609 -->|"e"|eNFA179_11_46688483
eNFA179_11_46688483 -.->|"ε"|eNFA179_12_17543165
eNFA179_11_46688483 -->|"1"|eNFA179_13_23670760
eNFA179_12_17543165 -->|"1"|eNFA179_13_23670760
eNFA179_13_23670760 -.->|"ε"|eNFA179_14_11710254
eNFA179_13_23670760 -->|"D"|eNFA179_15_38283422
eNFA179_14_11710254 -->|"D"|eNFA179_15_38283422
eNFA179_15_38283422 -.->|"ε"|eNFA179_16_9006483
eNFA179_15_38283422 -->|"A"|eNFA179_17_13949484
eNFA179_16_9006483 -->|"A"|eNFA179_17_13949484
eNFA179_17_13949484 -.->|"ε"|eNFA179_18_58436500
eNFA179_17_13949484 -->|"r"|eNFA179_19_56166459
eNFA179_18_58436500 -->|"r"|eNFA179_19_56166459
eNFA179_19_56166459 -.->|"ε"|eNFA179_20_35736091
eNFA179_19_56166459 -->|"r"|eNFA179_21_53189363
eNFA179_20_35736091 -->|"r"|eNFA179_21_53189363
eNFA179_21_53189363 -.->|"ε"|eNFA179_22_8942221
eNFA179_21_53189363 -->|"a"|eNFA179_23_13371131
eNFA179_22_8942221 -->|"a"|eNFA179_23_13371131
eNFA179_23_13371131 -.->|"ε"|eNFA179_24_53231316
eNFA179_23_13371131 -->|"y"|eNFA179_25_9319803
eNFA179_24_53231316 -->|"y"|eNFA179_25_9319803
eNFA179_25_9319803 -.->|"ε"|eNFA179_27_16769368
eNFA179_25_9319803 -.->|"ε"|eNFA179_28_16706588
eNFA179_25_9319803 -.->|"ε"|eNFA179_29_16141568
eNFA179_27_16769368 -.->|"ε"|eNFA179_28_16706588
eNFA179_27_16769368 -.->|"ε"|eNFA179_29_16141568
eNFA179_28_16706588 -.->|"ε"|eNFA179_29_16141568
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
NFA179_26_11056389("NFA179-26 regex start")
NFA179_1_32398645("NFA179-1 char[1]")
NFA179_3_23152351("NFA179-3 char[1]")
NFA179_5_7044574("NFA179-5 char[1]")
NFA179_7_63401170("NFA179-7 char[1]")
NFA179_9_33739620("NFA179-9 char[1]")
NFA179_11_35221125("NFA179-11 char[1]")
NFA179_13_48554670("NFA179-13 char[1]")
NFA179_15_34338848("NFA179-15 char[1]")
NFA179_17_40614180("NFA179-17 char[1]")
NFA179_19_29983308("NFA179-19 char[1]")
NFA179_21_1414320("NFA179-21 char[1]")
NFA179_23_12728880("NFA179-23 char[1]")
NFA179_25_47451063[\"NFA179-25 char[1]"/]
NFA179_26_11056389 -->|"i"|NFA179_1_32398645
NFA179_1_32398645 -->|"i"|NFA179_3_23152351
NFA179_3_23152351 -->|"m"|NFA179_5_7044574
NFA179_5_7044574 -->|"a"|NFA179_7_63401170
NFA179_7_63401170 -->|"g"|NFA179_9_33739620
NFA179_9_33739620 -->|"e"|NFA179_11_35221125
NFA179_11_35221125 -->|"1"|NFA179_13_48554670
NFA179_13_48554670 -->|"D"|NFA179_15_34338848
NFA179_15_34338848 -->|"A"|NFA179_17_40614180
NFA179_17_40614180 -->|"r"|NFA179_19_29983308
NFA179_19_29983308 -->|"r"|NFA179_21_1414320
NFA179_21_1414320 -->|"a"|NFA179_23_12728880
NFA179_23_12728880 -->|"y"|NFA179_25_47451063
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
subgraph DFA0_-936153121["DFA0 regex start"]
NFA179_26_11056389_0("NFA179-26 regex start")
end
subgraph DFA1_-1306126178["DFA1 {1}"]
NFA179_1_32398645_1("NFA179-1 char[1]")
end
subgraph DFA2_1059269078["DFA2 {1}"]
NFA179_3_23152351_2("NFA179-3 char[1]")
end
subgraph DFA3_224582340["DFA3 {1}"]
NFA179_5_7044574_3("NFA179-5 char[1]")
end
subgraph DFA4_1534389681["DFA4 {1}"]
NFA179_7_63401170_4("NFA179-7 char[1]")
end
subgraph DFA5_-500184748["DFA5 {1}"]
NFA179_9_33739620_5("NFA179-9 char[1]")
end
subgraph DFA6_-1516925380["DFA6 {1}"]
NFA179_11_35221125_6("NFA179-11 char[1]")
end
subgraph DFA7_1489940277["DFA7 {1}"]
NFA179_13_48554670_7("NFA179-13 char[1]")
end
subgraph DFA8_-861517597["DFA8 {1}"]
NFA179_15_34338848_8("NFA179-15 char[1]")
end
subgraph DFA9_-130899276["DFA9 {1}"]
NFA179_17_40614180_9("NFA179-17 char[1]")
end
subgraph DFA10_-2146862042["DFA10 {1}"]
NFA179_19_29983308_10("NFA179-19 char[1]")
end
subgraph DFA11_1026481679["DFA11 {1}"]
NFA179_21_1414320_11("NFA179-21 char[1]")
end
subgraph DFA12_1185945407["DFA12 {1}"]
NFA179_23_12728880_12("NFA179-23 char[1]")
end
subgraph DFA13_-1570084634["DFA13 {1}"]
NFA179_25_47451063_13[\"NFA179-25 char[1]"/]
end
DFA0_-936153121 -->|"i"|DFA1_-1306126178
DFA1_-1306126178 -->|"i"|DFA2_1059269078
DFA2_1059269078 -->|"m"|DFA3_224582340
DFA3_224582340 -->|"a"|DFA4_1534389681
DFA4_1534389681 -->|"g"|DFA5_-500184748
DFA5_-500184748 -->|"e"|DFA6_-1516925380
DFA6_-1516925380 -->|"1"|DFA7_1489940277
DFA7_1489940277 -->|"D"|DFA8_-861517597
DFA8_-861517597 -->|"A"|DFA9_-130899276
DFA9_-130899276 -->|"r"|DFA10_-2146862042
DFA10_-2146862042 -->|"r"|DFA11_1026481679
DFA11_1026481679 -->|"a"|DFA12_1185945407
DFA12_1185945407 -->|"y"|DFA13_-1570084634
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
DFA0_-936153121{{"DFA0 regex start"}}
DFA1_-1306126178{{"DFA1 {1}"}}
DFA2_1059269078{{"DFA2 {1}"}}
DFA3_224582340{{"DFA3 {1}"}}
DFA4_1534389681{{"DFA4 {1}"}}
DFA5_-500184748{{"DFA5 {1}"}}
DFA6_-1516925380{{"DFA6 {1}"}}
DFA7_1489940277{{"DFA7 {1}"}}
DFA8_-861517597{{"DFA8 {1}"}}
DFA9_-130899276{{"DFA9 {1}"}}
DFA10_-2146862042{{"DFA10 {1}"}}
DFA11_1026481679{{"DFA11 {1}"}}
DFA12_1185945407{{"DFA12 {1}"}}
DFA13_-1570084634[\"DFA13 {1}"/]
DFA0_-936153121 -->|"i"|DFA1_-1306126178
DFA1_-1306126178 -->|"i"|DFA2_1059269078
DFA2_1059269078 -->|"m"|DFA3_224582340
DFA3_224582340 -->|"a"|DFA4_1534389681
DFA4_1534389681 -->|"g"|DFA5_-500184748
DFA5_-500184748 -->|"e"|DFA6_-1516925380
DFA6_-1516925380 -->|"1"|DFA7_1489940277
DFA7_1489940277 -->|"D"|DFA8_-861517597
DFA8_-861517597 -->|"A"|DFA9_-130899276
DFA9_-130899276 -->|"r"|DFA10_-2146862042
DFA10_-2146862042 -->|"r"|DFA11_1026481679
DFA11_1026481679 -->|"a"|DFA12_1185945407
DFA12_1185945407 -->|"y"|DFA13_-1570084634
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
subgraph MiniDFA0_-1888049349["MiniDFA0 {1}"]
DFA0_-936153121_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-663805979["MiniDFA1 {1}"]
DFA1_-1306126178_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1691210672["MiniDFA2 {1}"]
DFA2_1059269078_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-50579901["MiniDFA3 {1}"]
DFA3_224582340_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1035288602["MiniDFA5 {1}"]
DFA4_1534389681_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1175796769["MiniDFA6 {1}"]
DFA5_-500184748_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-2085978643["MiniDFA7 {1}"]
DFA6_-1516925380_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-333529327["MiniDFA8 {1}"]
DFA7_1489940277_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1911714351["MiniDFA9 {1}"]
DFA8_-861517597_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-513580411["MiniDFA10 {1}"]
DFA9_-130899276_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_142178249["MiniDFA11 {1}"]
DFA10_-2146862042_10{{"DFA10 {1}"}}
end
subgraph MiniDFA4_1510542816["MiniDFA4 {1}"]
DFA11_1026481679_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_2056399031["MiniDFA12 {1}"]
DFA12_1185945407_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-583831325["MiniDFA13 {1}"]
DFA13_-1570084634_13[\"DFA13 {1}"/]
end
MiniDFA0_-1888049349 -->|"i"|MiniDFA1_-663805979
MiniDFA1_-663805979 -->|"i"|MiniDFA2_1691210672
MiniDFA2_1691210672 -->|"m"|MiniDFA3_-50579901
MiniDFA3_-50579901 -->|"a"|MiniDFA5_-1035288602
MiniDFA5_-1035288602 -->|"g"|MiniDFA6_-1175796769
MiniDFA6_-1175796769 -->|"e"|MiniDFA7_-2085978643
MiniDFA7_-2085978643 -->|"1"|MiniDFA8_-333529327
MiniDFA8_-333529327 -->|"D"|MiniDFA9_-1911714351
MiniDFA9_-1911714351 -->|"A"|MiniDFA10_-513580411
MiniDFA10_-513580411 -->|"r"|MiniDFA11_142178249
MiniDFA11_142178249 -->|"r"|MiniDFA4_1510542816
MiniDFA4_1510542816 -->|"a"|MiniDFA12_2056399031
MiniDFA12_2056399031 -->|"y"|MiniDFA13_-583831325
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
MiniDFA0_-1888049349(["MiniDFA0 {1}"])
MiniDFA1_-663805979(["MiniDFA1 {1}"])
MiniDFA2_1691210672(["MiniDFA2 {1}"])
MiniDFA3_-50579901(["MiniDFA3 {1}"])
MiniDFA5_-1035288602(["MiniDFA5 {1}"])
MiniDFA6_-1175796769(["MiniDFA6 {1}"])
MiniDFA7_-2085978643(["MiniDFA7 {1}"])
MiniDFA8_-333529327(["MiniDFA8 {1}"])
MiniDFA9_-1911714351(["MiniDFA9 {1}"])
MiniDFA10_-513580411(["MiniDFA10 {1}"])
MiniDFA11_142178249(["MiniDFA11 {1}"])
MiniDFA4_1510542816(["MiniDFA4 {1}"])
MiniDFA12_2056399031(["MiniDFA12 {1}"])
MiniDFA13_-583831325[\"MiniDFA13 {1}"/]
MiniDFA0_-1888049349 -->|"i"|MiniDFA1_-663805979
MiniDFA1_-663805979 -->|"i"|MiniDFA2_1691210672
MiniDFA2_1691210672 -->|"m"|MiniDFA3_-50579901
MiniDFA3_-50579901 -->|"a"|MiniDFA5_-1035288602
MiniDFA5_-1035288602 -->|"g"|MiniDFA6_-1175796769
MiniDFA6_-1175796769 -->|"e"|MiniDFA7_-2085978643
MiniDFA7_-2085978643 -->|"1"|MiniDFA8_-333529327
MiniDFA8_-333529327 -->|"D"|MiniDFA9_-1911714351
MiniDFA9_-1911714351 -->|"A"|MiniDFA10_-513580411
MiniDFA10_-513580411 -->|"r"|MiniDFA11_142178249
MiniDFA11_142178249 -->|"r"|MiniDFA4_1510542816
MiniDFA4_1510542816 -->|"a"|MiniDFA12_2056399031
MiniDFA12_2056399031 -->|"y"|MiniDFA13_-583831325
```
-------------------------------
