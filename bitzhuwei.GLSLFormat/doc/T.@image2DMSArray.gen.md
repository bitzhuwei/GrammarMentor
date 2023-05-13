# 'image2DMSArray'

pattern: `image2DMSArray`

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
eNFA190_28_14126311[["εNFA190-28 regex start"]]
eNFA190_0_60027939[["εNFA190-0 char{1, 1}"]]
eNFA190_1_3380542[["εNFA190-1 char[1]"]]
eNFA190_2_30424881[["εNFA190-2 char{1, 1}"]]
eNFA190_3_5388477[["εNFA190-3 char[1]"]]
eNFA190_4_48496300[["εNFA190-4 char{1, 1}"]]
eNFA190_5_33813517[["εNFA190-5 char[1]"]]
eNFA190_6_35886203[["εNFA190-6 char{1, 1}"]]
eNFA190_7_54540374[["εNFA190-7 char[1]"]]
eNFA190_8_21101319[["εNFA190-8 char{1, 1}"]]
eNFA190_9_55694143[["εNFA190-9 char[1]"]]
eNFA190_10_31485239[["εNFA190-10 char{1, 1}"]]
eNFA190_11_14931696[["εNFA190-11 char[1]"]]
eNFA190_12_167539[["εNFA190-12 char{1, 1}"]]
eNFA190_13_1507858[["εNFA190-13 char[1]"]]
eNFA190_14_13570724[["εNFA190-14 char{1, 1}"]]
eNFA190_15_55027660[["εNFA190-15 char[1]"]]
eNFA190_16_25486898[["εNFA190-16 char{1, 1}"]]
eNFA190_17_28055495[["εNFA190-17 char[1]"]]
eNFA190_18_51172868[["εNFA190-18 char{1, 1}"]]
eNFA190_19_57902635[["εNFA190-19 char[1]"]]
eNFA190_20_51361667[["εNFA190-20 char{1, 1}"]]
eNFA190_21_59601822[["εNFA190-21 char[1]"]]
eNFA190_22_66654358[["εNFA190-22 char{1, 1}"]]
eNFA190_23_63018315[["εNFA190-23 char[1]"]]
eNFA190_24_30293926[["εNFA190-24 char{1, 1}"]]
eNFA190_25_4209880[["εNFA190-25 char[1]"]]
eNFA190_26_37888922[["εNFA190-26 char{1, 1}"]]
eNFA190_27_5455981[["εNFA190-27 char[1]"]]
eNFA190_29_49103835[["εNFA190-29 regex end"]]
eNFA190_30_39281331[["εNFA190-30 post-regex start"]]
eNFA190_31_17987664[\"εNFA190-31 post-regex end"/]
eNFA190_28_14126311 -.->|"ε"|eNFA190_0_60027939
eNFA190_0_60027939 -->|"i"|eNFA190_1_3380542
eNFA190_1_3380542 -.->|"ε"|eNFA190_2_30424881
eNFA190_2_30424881 -->|"m"|eNFA190_3_5388477
eNFA190_3_5388477 -.->|"ε"|eNFA190_4_48496300
eNFA190_4_48496300 -->|"a"|eNFA190_5_33813517
eNFA190_5_33813517 -.->|"ε"|eNFA190_6_35886203
eNFA190_6_35886203 -->|"g"|eNFA190_7_54540374
eNFA190_7_54540374 -.->|"ε"|eNFA190_8_21101319
eNFA190_8_21101319 -->|"e"|eNFA190_9_55694143
eNFA190_9_55694143 -.->|"ε"|eNFA190_10_31485239
eNFA190_10_31485239 -->|"2"|eNFA190_11_14931696
eNFA190_11_14931696 -.->|"ε"|eNFA190_12_167539
eNFA190_12_167539 -->|"D"|eNFA190_13_1507858
eNFA190_13_1507858 -.->|"ε"|eNFA190_14_13570724
eNFA190_14_13570724 -->|"M"|eNFA190_15_55027660
eNFA190_15_55027660 -.->|"ε"|eNFA190_16_25486898
eNFA190_16_25486898 -->|"S"|eNFA190_17_28055495
eNFA190_17_28055495 -.->|"ε"|eNFA190_18_51172868
eNFA190_18_51172868 -->|"A"|eNFA190_19_57902635
eNFA190_19_57902635 -.->|"ε"|eNFA190_20_51361667
eNFA190_20_51361667 -->|"r"|eNFA190_21_59601822
eNFA190_21_59601822 -.->|"ε"|eNFA190_22_66654358
eNFA190_22_66654358 -->|"r"|eNFA190_23_63018315
eNFA190_23_63018315 -.->|"ε"|eNFA190_24_30293926
eNFA190_24_30293926 -->|"a"|eNFA190_25_4209880
eNFA190_25_4209880 -.->|"ε"|eNFA190_26_37888922
eNFA190_26_37888922 -->|"y"|eNFA190_27_5455981
eNFA190_27_5455981 -.->|"ε"|eNFA190_29_49103835
eNFA190_29_49103835 -.->|"ε"|eNFA190_30_39281331
eNFA190_30_39281331 -.->|"ε"|eNFA190_31_17987664
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
eNFA190_28_27671249[["εNFA190-28 regex start"]]
eNFA190_0_47714657[["εNFA190-0 char{1, 1}"]]
eNFA190_1_26778736[["εNFA190-1 char[1]"]]
eNFA190_2_39682040[["εNFA190-2 char{1, 1}"]]
eNFA190_3_21594040[["εNFA190-3 char[1]"]]
eNFA190_4_60128634[["εNFA190-4 char{1, 1}"]]
eNFA190_5_4286800[["εNFA190-5 char[1]"]]
eNFA190_6_38581201[["εNFA190-6 char{1, 1}"]]
eNFA190_7_11686496[["εNFA190-7 char[1]"]]
eNFA190_8_38069605[["εNFA190-8 char{1, 1}"]]
eNFA190_9_7082129[["εNFA190-9 char[1]"]]
eNFA190_10_63739165[["εNFA190-10 char{1, 1}"]]
eNFA190_11_36781578[["εNFA190-11 char[1]"]]
eNFA190_12_62598754[["εNFA190-12 char{1, 1}"]]
eNFA190_13_26517876[["εNFA190-13 char[1]"]]
eNFA190_14_37334299[["εNFA190-14 char{1, 1}"]]
eNFA190_15_464375[["εNFA190-15 char[1]"]]
eNFA190_16_4179377[["εNFA190-16 char{1, 1}"]]
eNFA190_17_37614394[["εNFA190-17 char[1]"]]
eNFA190_18_2985227[["εNFA190-18 char{1, 1}"]]
eNFA190_19_26867045[["εNFA190-19 char[1]"]]
eNFA190_20_40476817[["εNFA190-20 char{1, 1}"]]
eNFA190_21_28747041[["εNFA190-21 char[1]"]]
eNFA190_22_57396781[["εNFA190-22 char{1, 1}"]]
eNFA190_23_46808981[["εNFA190-23 char[1]"]]
eNFA190_24_18627652[["εNFA190-24 char{1, 1}"]]
eNFA190_25_33431146[["εNFA190-25 char[1]"]]
eNFA190_26_32444864[["εNFA190-26 char{1, 1}"]]
eNFA190_27_23568328[\"εNFA190-27 char[1]"/]
eNFA190_29_10788361[\"εNFA190-29 regex end"/]
eNFA190_30_29986390[\"εNFA190-30 post-regex start"/]
eNFA190_31_1442054[\"εNFA190-31 post-regex end"/]
eNFA190_28_27671249 -.->|"ε"|eNFA190_0_47714657
eNFA190_28_27671249 -->|"i"|eNFA190_1_26778736
eNFA190_0_47714657 -->|"i"|eNFA190_1_26778736
eNFA190_1_26778736 -.->|"ε"|eNFA190_2_39682040
eNFA190_1_26778736 -->|"m"|eNFA190_3_21594040
eNFA190_2_39682040 -->|"m"|eNFA190_3_21594040
eNFA190_3_21594040 -.->|"ε"|eNFA190_4_60128634
eNFA190_3_21594040 -->|"a"|eNFA190_5_4286800
eNFA190_4_60128634 -->|"a"|eNFA190_5_4286800
eNFA190_5_4286800 -.->|"ε"|eNFA190_6_38581201
eNFA190_5_4286800 -->|"g"|eNFA190_7_11686496
eNFA190_6_38581201 -->|"g"|eNFA190_7_11686496
eNFA190_7_11686496 -.->|"ε"|eNFA190_8_38069605
eNFA190_7_11686496 -->|"e"|eNFA190_9_7082129
eNFA190_8_38069605 -->|"e"|eNFA190_9_7082129
eNFA190_9_7082129 -.->|"ε"|eNFA190_10_63739165
eNFA190_9_7082129 -->|"2"|eNFA190_11_36781578
eNFA190_10_63739165 -->|"2"|eNFA190_11_36781578
eNFA190_11_36781578 -.->|"ε"|eNFA190_12_62598754
eNFA190_11_36781578 -->|"D"|eNFA190_13_26517876
eNFA190_12_62598754 -->|"D"|eNFA190_13_26517876
eNFA190_13_26517876 -.->|"ε"|eNFA190_14_37334299
eNFA190_13_26517876 -->|"M"|eNFA190_15_464375
eNFA190_14_37334299 -->|"M"|eNFA190_15_464375
eNFA190_15_464375 -.->|"ε"|eNFA190_16_4179377
eNFA190_15_464375 -->|"S"|eNFA190_17_37614394
eNFA190_16_4179377 -->|"S"|eNFA190_17_37614394
eNFA190_17_37614394 -.->|"ε"|eNFA190_18_2985227
eNFA190_17_37614394 -->|"A"|eNFA190_19_26867045
eNFA190_18_2985227 -->|"A"|eNFA190_19_26867045
eNFA190_19_26867045 -.->|"ε"|eNFA190_20_40476817
eNFA190_19_26867045 -->|"r"|eNFA190_21_28747041
eNFA190_20_40476817 -->|"r"|eNFA190_21_28747041
eNFA190_21_28747041 -.->|"ε"|eNFA190_22_57396781
eNFA190_21_28747041 -->|"r"|eNFA190_23_46808981
eNFA190_22_57396781 -->|"r"|eNFA190_23_46808981
eNFA190_23_46808981 -.->|"ε"|eNFA190_24_18627652
eNFA190_23_46808981 -->|"a"|eNFA190_25_33431146
eNFA190_24_18627652 -->|"a"|eNFA190_25_33431146
eNFA190_25_33431146 -.->|"ε"|eNFA190_26_32444864
eNFA190_25_33431146 -->|"y"|eNFA190_27_23568328
eNFA190_26_32444864 -->|"y"|eNFA190_27_23568328
eNFA190_27_23568328 -.->|"ε"|eNFA190_29_10788361
eNFA190_27_23568328 -.->|"ε"|eNFA190_30_29986390
eNFA190_27_23568328 -.->|"ε"|eNFA190_31_1442054
eNFA190_29_10788361 -.->|"ε"|eNFA190_30_29986390
eNFA190_29_10788361 -.->|"ε"|eNFA190_31_1442054
eNFA190_30_29986390 -.->|"ε"|eNFA190_31_1442054
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
NFA190_28_12978492("NFA190-28 regex start")
NFA190_1_49697568("NFA190-1 char[1]")
NFA190_3_44624931("NFA190-3 char[1]")
NFA190_5_66080062("NFA190-5 char[1]")
NFA190_7_57849650("NFA190-7 char[1]")
NFA190_9_50884809("NFA190-9 char[1]")
NFA190_11_55310098("NFA190-11 char[1]")
NFA190_13_28028840("NFA190-13 char[1]")
NFA190_15_50932971("NFA190-15 char[1]")
NFA190_17_55743556("NFA190-17 char[1]")
NFA190_19_31929956("NFA190-19 char[1]")
NFA190_21_18934148("NFA190-21 char[1]")
NFA190_23_36189605("NFA190-23 char[1]")
NFA190_25_57270992("NFA190-25 char[1]")
NFA190_27_45676887[\"NFA190-27 char[1]"/]
NFA190_28_12978492 -->|"i"|NFA190_1_49697568
NFA190_1_49697568 -->|"m"|NFA190_3_44624931
NFA190_3_44624931 -->|"a"|NFA190_5_66080062
NFA190_5_66080062 -->|"g"|NFA190_7_57849650
NFA190_7_57849650 -->|"e"|NFA190_9_50884809
NFA190_9_50884809 -->|"2"|NFA190_11_55310098
NFA190_11_55310098 -->|"D"|NFA190_13_28028840
NFA190_13_28028840 -->|"M"|NFA190_15_50932971
NFA190_15_50932971 -->|"S"|NFA190_17_55743556
NFA190_17_55743556 -->|"A"|NFA190_19_31929956
NFA190_19_31929956 -->|"r"|NFA190_21_18934148
NFA190_21_18934148 -->|"r"|NFA190_23_36189605
NFA190_23_36189605 -->|"a"|NFA190_25_57270992
NFA190_25_57270992 -->|"y"|NFA190_27_45676887
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
subgraph DFA0_-1668884161["DFA0 regex start"]
NFA190_28_12978492_0("NFA190-28 regex start")
end
subgraph DFA1_1413880321["DFA1 {1}"]
NFA190_1_49697568_1("NFA190-1 char[1]")
end
subgraph DFA2_1302295931["DFA2 {1}"]
NFA190_3_44624931_2("NFA190-3 char[1]")
end
subgraph DFA3_1902922639["DFA3 {1}"]
NFA190_5_66080062_3("NFA190-5 char[1]")
end
subgraph DFA4_1547336348["DFA4 {1}"]
NFA190_7_57849650_4("NFA190-7 char[1]")
end
subgraph DFA5_1734137078["DFA5 {1}"]
NFA190_9_50884809_5("NFA190-9 char[1]")
end
subgraph DFA6_-1731483978["DFA6 {1}"]
NFA190_11_55310098_6("NFA190-11 char[1]")
end
subgraph DFA7_-148179286["DFA7 {1}"]
NFA190_13_28028840_7("NFA190-13 char[1]")
end
subgraph DFA8_-1581985631["DFA8 {1}"]
NFA190_15_50932971_8("NFA190-15 char[1]")
end
subgraph DFA9_-728775687["DFA9 {1}"]
NFA190_17_55743556_9("NFA190-17 char[1]")
end
subgraph DFA10_-401946163["DFA10 {1}"]
NFA190_19_31929956_10("NFA190-19 char[1]")
end
subgraph DFA11_957450885["DFA11 {1}"]
NFA190_21_18934148_11("NFA190-21 char[1]")
end
subgraph DFA12_-1644417092["DFA12 {1}"]
NFA190_23_36189605_12("NFA190-23 char[1]")
end
subgraph DFA13_329415564["DFA13 {1}"]
NFA190_25_57270992_13("NFA190-25 char[1]")
end
subgraph DFA14_-313435322["DFA14 {1}"]
NFA190_27_45676887_14[\"NFA190-27 char[1]"/]
end
DFA0_-1668884161 -->|"i"|DFA1_1413880321
DFA1_1413880321 -->|"m"|DFA2_1302295931
DFA2_1302295931 -->|"a"|DFA3_1902922639
DFA3_1902922639 -->|"g"|DFA4_1547336348
DFA4_1547336348 -->|"e"|DFA5_1734137078
DFA5_1734137078 -->|"2"|DFA6_-1731483978
DFA6_-1731483978 -->|"D"|DFA7_-148179286
DFA7_-148179286 -->|"M"|DFA8_-1581985631
DFA8_-1581985631 -->|"S"|DFA9_-728775687
DFA9_-728775687 -->|"A"|DFA10_-401946163
DFA10_-401946163 -->|"r"|DFA11_957450885
DFA11_957450885 -->|"r"|DFA12_-1644417092
DFA12_-1644417092 -->|"a"|DFA13_329415564
DFA13_329415564 -->|"y"|DFA14_-313435322
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
DFA0_-1668884161{{"DFA0 regex start"}}
DFA1_1413880321{{"DFA1 {1}"}}
DFA2_1302295931{{"DFA2 {1}"}}
DFA3_1902922639{{"DFA3 {1}"}}
DFA4_1547336348{{"DFA4 {1}"}}
DFA5_1734137078{{"DFA5 {1}"}}
DFA6_-1731483978{{"DFA6 {1}"}}
DFA7_-148179286{{"DFA7 {1}"}}
DFA8_-1581985631{{"DFA8 {1}"}}
DFA9_-728775687{{"DFA9 {1}"}}
DFA10_-401946163{{"DFA10 {1}"}}
DFA11_957450885{{"DFA11 {1}"}}
DFA12_-1644417092{{"DFA12 {1}"}}
DFA13_329415564{{"DFA13 {1}"}}
DFA14_-313435322[\"DFA14 {1}"/]
DFA0_-1668884161 -->|"i"|DFA1_1413880321
DFA1_1413880321 -->|"m"|DFA2_1302295931
DFA2_1302295931 -->|"a"|DFA3_1902922639
DFA3_1902922639 -->|"g"|DFA4_1547336348
DFA4_1547336348 -->|"e"|DFA5_1734137078
DFA5_1734137078 -->|"2"|DFA6_-1731483978
DFA6_-1731483978 -->|"D"|DFA7_-148179286
DFA7_-148179286 -->|"M"|DFA8_-1581985631
DFA8_-1581985631 -->|"S"|DFA9_-728775687
DFA9_-728775687 -->|"A"|DFA10_-401946163
DFA10_-401946163 -->|"r"|DFA11_957450885
DFA11_957450885 -->|"r"|DFA12_-1644417092
DFA12_-1644417092 -->|"a"|DFA13_329415564
DFA13_329415564 -->|"y"|DFA14_-313435322
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
subgraph MiniDFA0_-624944059["MiniDFA0 {1}"]
DFA0_-1668884161_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_2112873476["MiniDFA1 {1}"]
DFA1_1413880321_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1978263667["MiniDFA2 {1}"]
DFA2_1302295931_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_929381837["MiniDFA4 {1}"]
DFA3_1902922639_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-2141732225["MiniDFA5 {1}"]
DFA4_1547336348_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_385628100["MiniDFA6 {1}"]
DFA5_1734137078_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-402391370["MiniDFA7 {1}"]
DFA6_-1731483978_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_636936052["MiniDFA8 {1}"]
DFA7_-148179286_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_408085534["MiniDFA9 {1}"]
DFA8_-1581985631_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-1159562848["MiniDFA10 {1}"]
DFA9_-728775687_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_-253207477["MiniDFA11 {1}"]
DFA10_-401946163_10{{"DFA10 {1}"}}
end
subgraph MiniDFA12_1936852883["MiniDFA12 {1}"]
DFA11_957450885_11{{"DFA11 {1}"}}
end
subgraph MiniDFA3_-1413697014["MiniDFA3 {1}"]
DFA12_-1644417092_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-765766469["MiniDFA13 {1}"]
DFA13_329415564_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1316399612["MiniDFA14 {1}"]
DFA14_-313435322_14[\"DFA14 {1}"/]
end
MiniDFA0_-624944059 -->|"i"|MiniDFA1_2112873476
MiniDFA1_2112873476 -->|"m"|MiniDFA2_1978263667
MiniDFA2_1978263667 -->|"a"|MiniDFA4_929381837
MiniDFA4_929381837 -->|"g"|MiniDFA5_-2141732225
MiniDFA5_-2141732225 -->|"e"|MiniDFA6_385628100
MiniDFA6_385628100 -->|"2"|MiniDFA7_-402391370
MiniDFA7_-402391370 -->|"D"|MiniDFA8_636936052
MiniDFA8_636936052 -->|"M"|MiniDFA9_408085534
MiniDFA9_408085534 -->|"S"|MiniDFA10_-1159562848
MiniDFA10_-1159562848 -->|"A"|MiniDFA11_-253207477
MiniDFA11_-253207477 -->|"r"|MiniDFA12_1936852883
MiniDFA12_1936852883 -->|"r"|MiniDFA3_-1413697014
MiniDFA3_-1413697014 -->|"a"|MiniDFA13_-765766469
MiniDFA13_-765766469 -->|"y"|MiniDFA14_1316399612
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
MiniDFA0_-624944059(["MiniDFA0 {1}"])
MiniDFA1_2112873476(["MiniDFA1 {1}"])
MiniDFA2_1978263667(["MiniDFA2 {1}"])
MiniDFA4_929381837(["MiniDFA4 {1}"])
MiniDFA5_-2141732225(["MiniDFA5 {1}"])
MiniDFA6_385628100(["MiniDFA6 {1}"])
MiniDFA7_-402391370(["MiniDFA7 {1}"])
MiniDFA8_636936052(["MiniDFA8 {1}"])
MiniDFA9_408085534(["MiniDFA9 {1}"])
MiniDFA10_-1159562848(["MiniDFA10 {1}"])
MiniDFA11_-253207477(["MiniDFA11 {1}"])
MiniDFA12_1936852883(["MiniDFA12 {1}"])
MiniDFA3_-1413697014(["MiniDFA3 {1}"])
MiniDFA13_-765766469(["MiniDFA13 {1}"])
MiniDFA14_1316399612[\"MiniDFA14 {1}"/]
MiniDFA0_-624944059 -->|"i"|MiniDFA1_2112873476
MiniDFA1_2112873476 -->|"m"|MiniDFA2_1978263667
MiniDFA2_1978263667 -->|"a"|MiniDFA4_929381837
MiniDFA4_929381837 -->|"g"|MiniDFA5_-2141732225
MiniDFA5_-2141732225 -->|"e"|MiniDFA6_385628100
MiniDFA6_385628100 -->|"2"|MiniDFA7_-402391370
MiniDFA7_-402391370 -->|"D"|MiniDFA8_636936052
MiniDFA8_636936052 -->|"M"|MiniDFA9_408085534
MiniDFA9_408085534 -->|"S"|MiniDFA10_-1159562848
MiniDFA10_-1159562848 -->|"A"|MiniDFA11_-253207477
MiniDFA11_-253207477 -->|"r"|MiniDFA12_1936852883
MiniDFA12_1936852883 -->|"r"|MiniDFA3_-1413697014
MiniDFA3_-1413697014 -->|"a"|MiniDFA13_-765766469
MiniDFA13_-765766469 -->|"y"|MiniDFA14_1316399612
```
-------------------------------
