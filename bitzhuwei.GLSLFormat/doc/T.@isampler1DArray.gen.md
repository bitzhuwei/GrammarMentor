# 'isampler1DArray'

pattern: `isampler1DArray`

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
eNFA137_30_23174054[["εNFA137-30 regex start"]]
eNFA137_0_7239897[["εNFA137-0 char{1, 1}"]]
eNFA137_1_65159075[["εNFA137-1 char[1]"]]
eNFA137_2_49560765[["εNFA137-2 char{1, 1}"]]
eNFA137_3_43393704[["εNFA137-3 char[1]"]]
eNFA137_4_54999022[["εNFA137-4 char{1, 1}"]]
eNFA137_5_25229150[["εNFA137-5 char[1]"]]
eNFA137_6_25735763[["εNFA137-6 char{1, 1}"]]
eNFA137_7_30295276[["εNFA137-7 char[1]"]]
eNFA137_8_4222036[["εNFA137-8 char{1, 1}"]]
eNFA137_9_37998331[["εNFA137-9 char[1]"]]
eNFA137_10_6440667[["εNFA137-10 char{1, 1}"]]
eNFA137_11_57966003[["εNFA137-11 char[1]"]]
eNFA137_12_51931981[["εNFA137-12 char{1, 1}"]]
eNFA137_13_64734651[["εNFA137-13 char[1]"]]
eNFA137_14_45740948[["εNFA137-14 char{1, 1}"]]
eNFA137_15_9015355[["εNFA137-15 char[1]"]]
eNFA137_16_14029336[["εNFA137-16 char{1, 1}"]]
eNFA137_17_59155164[["εNFA137-17 char[1]"]]
eNFA137_18_62634432[["εNFA137-18 char{1, 1}"]]
eNFA137_19_26838981[["εNFA137-19 char[1]"]]
eNFA137_20_40224245[["εNFA137-20 char{1, 1}"]]
eNFA137_21_26473887[["εNFA137-21 char[1]"]]
eNFA137_22_36938398[["εNFA137-22 char{1, 1}"]]
eNFA137_23_64010130[["εNFA137-23 char[1]"]]
eNFA137_24_39220260[["εNFA137-24 char{1, 1}"]]
eNFA137_25_17438021[["εNFA137-25 char[1]"]]
eNFA137_26_22724462[["εNFA137-26 char{1, 1}"]]
eNFA137_27_3193568[["εNFA137-27 char[1]"]]
eNFA137_28_28742116[["εNFA137-28 char{1, 1}"]]
eNFA137_29_57352460[["εNFA137-29 char[1]"]]
eNFA137_31_46410096[["εNFA137-31 regex end"]]
eNFA137_32_15037680[["εNFA137-32 post-regex start"]]
eNFA137_33_1121399[\"εNFA137-33 post-regex end"/]
eNFA137_30_23174054 -.->|"ε"|eNFA137_0_7239897
eNFA137_0_7239897 -->|"i"|eNFA137_1_65159075
eNFA137_1_65159075 -.->|"ε"|eNFA137_2_49560765
eNFA137_2_49560765 -->|"s"|eNFA137_3_43393704
eNFA137_3_43393704 -.->|"ε"|eNFA137_4_54999022
eNFA137_4_54999022 -->|"a"|eNFA137_5_25229150
eNFA137_5_25229150 -.->|"ε"|eNFA137_6_25735763
eNFA137_6_25735763 -->|"m"|eNFA137_7_30295276
eNFA137_7_30295276 -.->|"ε"|eNFA137_8_4222036
eNFA137_8_4222036 -->|"p"|eNFA137_9_37998331
eNFA137_9_37998331 -.->|"ε"|eNFA137_10_6440667
eNFA137_10_6440667 -->|"l"|eNFA137_11_57966003
eNFA137_11_57966003 -.->|"ε"|eNFA137_12_51931981
eNFA137_12_51931981 -->|"e"|eNFA137_13_64734651
eNFA137_13_64734651 -.->|"ε"|eNFA137_14_45740948
eNFA137_14_45740948 -->|"r"|eNFA137_15_9015355
eNFA137_15_9015355 -.->|"ε"|eNFA137_16_14029336
eNFA137_16_14029336 -->|"1"|eNFA137_17_59155164
eNFA137_17_59155164 -.->|"ε"|eNFA137_18_62634432
eNFA137_18_62634432 -->|"D"|eNFA137_19_26838981
eNFA137_19_26838981 -.->|"ε"|eNFA137_20_40224245
eNFA137_20_40224245 -->|"A"|eNFA137_21_26473887
eNFA137_21_26473887 -.->|"ε"|eNFA137_22_36938398
eNFA137_22_36938398 -->|"r"|eNFA137_23_64010130
eNFA137_23_64010130 -.->|"ε"|eNFA137_24_39220260
eNFA137_24_39220260 -->|"r"|eNFA137_25_17438021
eNFA137_25_17438021 -.->|"ε"|eNFA137_26_22724462
eNFA137_26_22724462 -->|"a"|eNFA137_27_3193568
eNFA137_27_3193568 -.->|"ε"|eNFA137_28_28742116
eNFA137_28_28742116 -->|"y"|eNFA137_29_57352460
eNFA137_29_57352460 -.->|"ε"|eNFA137_31_46410096
eNFA137_31_46410096 -.->|"ε"|eNFA137_32_15037680
eNFA137_32_15037680 -.->|"ε"|eNFA137_33_1121399
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
eNFA137_30_10092597[["εNFA137-30 regex start"]]
eNFA137_0_23724515[["εNFA137-0 char{1, 1}"]]
eNFA137_1_12194051[["εNFA137-1 char[1]"]]
eNFA137_2_42637596[["εNFA137-2 char{1, 1}"]]
eNFA137_3_48194049[["εNFA137-3 char[1]"]]
eNFA137_4_31093257[["εNFA137-4 char{1, 1}"]]
eNFA137_5_11403863[["εNFA137-5 char[1]"]]
eNFA137_6_35525907[["εNFA137-6 char{1, 1}"]]
eNFA137_7_51297710[["εNFA137-7 char[1]"]]
eNFA137_8_59026209[["εNFA137-8 char{1, 1}"]]
eNFA137_9_61473837[["εNFA137-9 char[1]"]]
eNFA137_10_16393628[["εNFA137-10 char{1, 1}"]]
eNFA137_11_13324925[["εNFA137-11 char[1]"]]
eNFA137_12_52815467[["εNFA137-12 char{1, 1}"]]
eNFA137_13_5577158[["εNFA137-13 char[1]"]]
eNFA137_14_50194423[["εNFA137-14 char{1, 1}"]]
eNFA137_15_49096623[["εNFA137-15 char[1]"]]
eNFA137_16_39216423[["εNFA137-16 char{1, 1}"]]
eNFA137_17_17403488[["εNFA137-17 char[1]"]]
eNFA137_18_22413667[["εNFA137-18 char{1, 1}"]]
eNFA137_19_396418[["εNFA137-19 char[1]"]]
eNFA137_20_3567764[["εNFA137-20 char{1, 1}"]]
eNFA137_21_32109884[["εNFA137-21 char[1]"]]
eNFA137_22_20553506[["εNFA137-22 char{1, 1}"]]
eNFA137_23_50763831[["εNFA137-23 char[1]"]]
eNFA137_24_54221300[["εNFA137-24 char{1, 1}"]]
eNFA137_25_18229659[["εNFA137-25 char[1]"]]
eNFA137_26_29849203[["εNFA137-26 char{1, 1}"]]
eNFA137_27_207374[["εNFA137-27 char[1]"]]
eNFA137_28_1866374[["εNFA137-28 char{1, 1}"]]
eNFA137_29_16797371[\"εNFA137-29 char[1]"/]
eNFA137_31_16958614[\"εNFA137-31 regex end"/]
eNFA137_32_18409800[\"εNFA137-32 post-regex start"/]
eNFA137_33_31470474[\"εNFA137-33 post-regex end"/]
eNFA137_30_10092597 -.->|"ε"|eNFA137_0_23724515
eNFA137_30_10092597 -->|"i"|eNFA137_1_12194051
eNFA137_0_23724515 -->|"i"|eNFA137_1_12194051
eNFA137_1_12194051 -.->|"ε"|eNFA137_2_42637596
eNFA137_1_12194051 -->|"s"|eNFA137_3_48194049
eNFA137_2_42637596 -->|"s"|eNFA137_3_48194049
eNFA137_3_48194049 -.->|"ε"|eNFA137_4_31093257
eNFA137_3_48194049 -->|"a"|eNFA137_5_11403863
eNFA137_4_31093257 -->|"a"|eNFA137_5_11403863
eNFA137_5_11403863 -.->|"ε"|eNFA137_6_35525907
eNFA137_5_11403863 -->|"m"|eNFA137_7_51297710
eNFA137_6_35525907 -->|"m"|eNFA137_7_51297710
eNFA137_7_51297710 -.->|"ε"|eNFA137_8_59026209
eNFA137_7_51297710 -->|"p"|eNFA137_9_61473837
eNFA137_8_59026209 -->|"p"|eNFA137_9_61473837
eNFA137_9_61473837 -.->|"ε"|eNFA137_10_16393628
eNFA137_9_61473837 -->|"l"|eNFA137_11_13324925
eNFA137_10_16393628 -->|"l"|eNFA137_11_13324925
eNFA137_11_13324925 -.->|"ε"|eNFA137_12_52815467
eNFA137_11_13324925 -->|"e"|eNFA137_13_5577158
eNFA137_12_52815467 -->|"e"|eNFA137_13_5577158
eNFA137_13_5577158 -.->|"ε"|eNFA137_14_50194423
eNFA137_13_5577158 -->|"r"|eNFA137_15_49096623
eNFA137_14_50194423 -->|"r"|eNFA137_15_49096623
eNFA137_15_49096623 -.->|"ε"|eNFA137_16_39216423
eNFA137_15_49096623 -->|"1"|eNFA137_17_17403488
eNFA137_16_39216423 -->|"1"|eNFA137_17_17403488
eNFA137_17_17403488 -.->|"ε"|eNFA137_18_22413667
eNFA137_17_17403488 -->|"D"|eNFA137_19_396418
eNFA137_18_22413667 -->|"D"|eNFA137_19_396418
eNFA137_19_396418 -.->|"ε"|eNFA137_20_3567764
eNFA137_19_396418 -->|"A"|eNFA137_21_32109884
eNFA137_20_3567764 -->|"A"|eNFA137_21_32109884
eNFA137_21_32109884 -.->|"ε"|eNFA137_22_20553506
eNFA137_21_32109884 -->|"r"|eNFA137_23_50763831
eNFA137_22_20553506 -->|"r"|eNFA137_23_50763831
eNFA137_23_50763831 -.->|"ε"|eNFA137_24_54221300
eNFA137_23_50763831 -->|"r"|eNFA137_25_18229659
eNFA137_24_54221300 -->|"r"|eNFA137_25_18229659
eNFA137_25_18229659 -.->|"ε"|eNFA137_26_29849203
eNFA137_25_18229659 -->|"a"|eNFA137_27_207374
eNFA137_26_29849203 -->|"a"|eNFA137_27_207374
eNFA137_27_207374 -.->|"ε"|eNFA137_28_1866374
eNFA137_27_207374 -->|"y"|eNFA137_29_16797371
eNFA137_28_1866374 -->|"y"|eNFA137_29_16797371
eNFA137_29_16797371 -.->|"ε"|eNFA137_31_16958614
eNFA137_29_16797371 -.->|"ε"|eNFA137_32_18409800
eNFA137_29_16797371 -.->|"ε"|eNFA137_33_31470474
eNFA137_31_16958614 -.->|"ε"|eNFA137_32_18409800
eNFA137_31_16958614 -.->|"ε"|eNFA137_33_31470474
eNFA137_32_18409800 -.->|"ε"|eNFA137_33_31470474
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
NFA137_30_14798813("NFA137-30 regex start")
NFA137_1_66080459("NFA137-1 char[1]")
NFA137_3_57853219("NFA137-3 char[1]")
NFA137_5_50916928("NFA137-5 char[1]")
NFA137_7_55599169("NFA137-7 char[1]")
NFA137_9_30630481("NFA137-9 char[1]")
NFA137_11_7238880("NFA137-11 char[1]")
NFA137_13_65149928("NFA137-13 char[1]")
NFA137_15_49478440("NFA137-15 char[1]")
NFA137_17_42652778("NFA137-17 char[1]")
NFA137_19_48330688("NFA137-19 char[1]")
NFA137_21_32323009("NFA137-21 char[1]")
NFA137_23_22471632("NFA137-23 char[1]")
NFA137_25_918101("NFA137-25 char[1]")
NFA137_27_8262913("NFA137-27 char[1]")
NFA137_29_7257357[\"NFA137-29 char[1]"/]
NFA137_30_14798813 -->|"i"|NFA137_1_66080459
NFA137_1_66080459 -->|"s"|NFA137_3_57853219
NFA137_3_57853219 -->|"a"|NFA137_5_50916928
NFA137_5_50916928 -->|"m"|NFA137_7_55599169
NFA137_7_55599169 -->|"p"|NFA137_9_30630481
NFA137_9_30630481 -->|"l"|NFA137_11_7238880
NFA137_11_7238880 -->|"e"|NFA137_13_65149928
NFA137_13_65149928 -->|"r"|NFA137_15_49478440
NFA137_15_49478440 -->|"1"|NFA137_17_42652778
NFA137_17_42652778 -->|"D"|NFA137_19_48330688
NFA137_19_48330688 -->|"A"|NFA137_21_32323009
NFA137_21_32323009 -->|"r"|NFA137_23_22471632
NFA137_23_22471632 -->|"r"|NFA137_25_918101
NFA137_25_918101 -->|"a"|NFA137_27_8262913
NFA137_27_8262913 -->|"y"|NFA137_29_7257357
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
subgraph DFA0_1236075542["DFA0 regex start"]
NFA137_30_14798813_0("NFA137-30 regex start")
end
subgraph DFA1_1432571839["DFA1 {1}"]
NFA137_1_66080459_1("NFA137-1 char[1]")
end
subgraph DFA2_976042422["DFA2 {1}"]
NFA137_3_57853219_2("NFA137-3 char[1]")
end
subgraph DFA3_-1770736169["DFA3 {1}"]
NFA137_5_50916928_3("NFA137-5 char[1]")
end
subgraph DFA4_-8741222["DFA4 {1}"]
NFA137_7_55599169_4("NFA137-7 char[1]")
end
subgraph DFA5_964486606["DFA5 {1}"]
NFA137_9_30630481_5("NFA137-9 char[1]")
end
subgraph DFA6_572615030["DFA6 {1}"]
NFA137_11_7238880_6("NFA137-11 char[1]")
end
subgraph DFA7_2021678156["DFA7 {1}"]
NFA137_13_65149928_7("NFA137-13 char[1]")
end
subgraph DFA8_-1556640408["DFA8 {1}"]
NFA137_15_49478440_8("NFA137-15 char[1]")
end
subgraph DFA9_-1824780948["DFA9 {1}"]
NFA137_17_42652778_9("NFA137-17 char[1]")
end
subgraph DFA10_-872930737["DFA10 {1}"]
NFA137_19_48330688_10("NFA137-19 char[1]")
end
subgraph DFA11_34647460["DFA11 {1}"]
NFA137_21_32323009_11("NFA137-21 char[1]")
end
subgraph DFA12_-1302777583["DFA12 {1}"]
NFA137_23_22471632_12("NFA137-23 char[1]")
end
subgraph DFA13_1232832894["DFA13 {1}"]
NFA137_25_918101_13("NFA137-25 char[1]")
end
subgraph DFA14_2048971027["DFA14 {1}"]
NFA137_27_8262913_14("NFA137-27 char[1]")
end
subgraph DFA15_2107293529["DFA15 {1}"]
NFA137_29_7257357_15[\"NFA137-29 char[1]"/]
end
DFA0_1236075542 -->|"i"|DFA1_1432571839
DFA1_1432571839 -->|"s"|DFA2_976042422
DFA2_976042422 -->|"a"|DFA3_-1770736169
DFA3_-1770736169 -->|"m"|DFA4_-8741222
DFA4_-8741222 -->|"p"|DFA5_964486606
DFA5_964486606 -->|"l"|DFA6_572615030
DFA6_572615030 -->|"e"|DFA7_2021678156
DFA7_2021678156 -->|"r"|DFA8_-1556640408
DFA8_-1556640408 -->|"1"|DFA9_-1824780948
DFA9_-1824780948 -->|"D"|DFA10_-872930737
DFA10_-872930737 -->|"A"|DFA11_34647460
DFA11_34647460 -->|"r"|DFA12_-1302777583
DFA12_-1302777583 -->|"r"|DFA13_1232832894
DFA13_1232832894 -->|"a"|DFA14_2048971027
DFA14_2048971027 -->|"y"|DFA15_2107293529
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
DFA0_1236075542{{"DFA0 regex start"}}
DFA1_1432571839{{"DFA1 {1}"}}
DFA2_976042422{{"DFA2 {1}"}}
DFA3_-1770736169{{"DFA3 {1}"}}
DFA4_-8741222{{"DFA4 {1}"}}
DFA5_964486606{{"DFA5 {1}"}}
DFA6_572615030{{"DFA6 {1}"}}
DFA7_2021678156{{"DFA7 {1}"}}
DFA8_-1556640408{{"DFA8 {1}"}}
DFA9_-1824780948{{"DFA9 {1}"}}
DFA10_-872930737{{"DFA10 {1}"}}
DFA11_34647460{{"DFA11 {1}"}}
DFA12_-1302777583{{"DFA12 {1}"}}
DFA13_1232832894{{"DFA13 {1}"}}
DFA14_2048971027{{"DFA14 {1}"}}
DFA15_2107293529[\"DFA15 {1}"/]
DFA0_1236075542 -->|"i"|DFA1_1432571839
DFA1_1432571839 -->|"s"|DFA2_976042422
DFA2_976042422 -->|"a"|DFA3_-1770736169
DFA3_-1770736169 -->|"m"|DFA4_-8741222
DFA4_-8741222 -->|"p"|DFA5_964486606
DFA5_964486606 -->|"l"|DFA6_572615030
DFA6_572615030 -->|"e"|DFA7_2021678156
DFA7_2021678156 -->|"r"|DFA8_-1556640408
DFA8_-1556640408 -->|"1"|DFA9_-1824780948
DFA9_-1824780948 -->|"D"|DFA10_-872930737
DFA10_-872930737 -->|"A"|DFA11_34647460
DFA11_34647460 -->|"r"|DFA12_-1302777583
DFA12_-1302777583 -->|"r"|DFA13_1232832894
DFA13_1232832894 -->|"a"|DFA14_2048971027
DFA14_2048971027 -->|"y"|DFA15_2107293529
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
subgraph MiniDFA0_352279346["MiniDFA0 {1}"]
DFA0_1236075542_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-459498929["MiniDFA1 {1}"]
DFA1_1432571839_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-457890476["MiniDFA2 {1}"]
DFA2_976042422_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-1171385229["MiniDFA4 {1}"]
DFA3_-1770736169_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1316212708["MiniDFA5 {1}"]
DFA4_-8741222_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-1908915181["MiniDFA6 {1}"]
DFA5_964486606_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_648928181["MiniDFA7 {1}"]
DFA6_572615030_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_751320052["MiniDFA8 {1}"]
DFA7_2021678156_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_1922666212["MiniDFA11 {1}"]
DFA8_-1556640408_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_163977791["MiniDFA12 {1}"]
DFA9_-1824780948_9{{"DFA9 {1}"}}
end
subgraph MiniDFA13_-1711908444["MiniDFA13 {1}"]
DFA10_-872930737_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_-2101603756["MiniDFA9 {1}"]
DFA11_34647460_11{{"DFA11 {1}"}}
end
subgraph MiniDFA10_-612819710["MiniDFA10 {1}"]
DFA12_-1302777583_12{{"DFA12 {1}"}}
end
subgraph MiniDFA3_-1688071878["MiniDFA3 {1}"]
DFA13_1232832894_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_-1897409275["MiniDFA14 {1}"]
DFA14_2048971027_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_-913840705["MiniDFA15 {1}"]
DFA15_2107293529_15[\"DFA15 {1}"/]
end
MiniDFA0_352279346 -->|"i"|MiniDFA1_-459498929
MiniDFA1_-459498929 -->|"s"|MiniDFA2_-457890476
MiniDFA2_-457890476 -->|"a"|MiniDFA4_-1171385229
MiniDFA4_-1171385229 -->|"m"|MiniDFA5_-1316212708
MiniDFA5_-1316212708 -->|"p"|MiniDFA6_-1908915181
MiniDFA6_-1908915181 -->|"l"|MiniDFA7_648928181
MiniDFA7_648928181 -->|"e"|MiniDFA8_751320052
MiniDFA8_751320052 -->|"r"|MiniDFA11_1922666212
MiniDFA11_1922666212 -->|"1"|MiniDFA12_163977791
MiniDFA12_163977791 -->|"D"|MiniDFA13_-1711908444
MiniDFA13_-1711908444 -->|"A"|MiniDFA9_-2101603756
MiniDFA9_-2101603756 -->|"r"|MiniDFA10_-612819710
MiniDFA10_-612819710 -->|"r"|MiniDFA3_-1688071878
MiniDFA3_-1688071878 -->|"a"|MiniDFA14_-1897409275
MiniDFA14_-1897409275 -->|"y"|MiniDFA15_-913840705
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
MiniDFA0_352279346(["MiniDFA0 {1}"])
MiniDFA1_-459498929(["MiniDFA1 {1}"])
MiniDFA2_-457890476(["MiniDFA2 {1}"])
MiniDFA4_-1171385229(["MiniDFA4 {1}"])
MiniDFA5_-1316212708(["MiniDFA5 {1}"])
MiniDFA6_-1908915181(["MiniDFA6 {1}"])
MiniDFA7_648928181(["MiniDFA7 {1}"])
MiniDFA8_751320052(["MiniDFA8 {1}"])
MiniDFA11_1922666212(["MiniDFA11 {1}"])
MiniDFA12_163977791(["MiniDFA12 {1}"])
MiniDFA13_-1711908444(["MiniDFA13 {1}"])
MiniDFA9_-2101603756(["MiniDFA9 {1}"])
MiniDFA10_-612819710(["MiniDFA10 {1}"])
MiniDFA3_-1688071878(["MiniDFA3 {1}"])
MiniDFA14_-1897409275(["MiniDFA14 {1}"])
MiniDFA15_-913840705[\"MiniDFA15 {1}"/]
MiniDFA0_352279346 -->|"i"|MiniDFA1_-459498929
MiniDFA1_-459498929 -->|"s"|MiniDFA2_-457890476
MiniDFA2_-457890476 -->|"a"|MiniDFA4_-1171385229
MiniDFA4_-1171385229 -->|"m"|MiniDFA5_-1316212708
MiniDFA5_-1316212708 -->|"p"|MiniDFA6_-1908915181
MiniDFA6_-1908915181 -->|"l"|MiniDFA7_648928181
MiniDFA7_648928181 -->|"e"|MiniDFA8_751320052
MiniDFA8_751320052 -->|"r"|MiniDFA11_1922666212
MiniDFA11_1922666212 -->|"1"|MiniDFA12_163977791
MiniDFA12_163977791 -->|"D"|MiniDFA13_-1711908444
MiniDFA13_-1711908444 -->|"A"|MiniDFA9_-2101603756
MiniDFA9_-2101603756 -->|"r"|MiniDFA10_-612819710
MiniDFA10_-612819710 -->|"r"|MiniDFA3_-1688071878
MiniDFA3_-1688071878 -->|"a"|MiniDFA14_-1897409275
MiniDFA14_-1897409275 -->|"y"|MiniDFA15_-913840705
```
-------------------------------
