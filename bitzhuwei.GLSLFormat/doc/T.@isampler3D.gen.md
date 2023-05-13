# 'isampler3D'

pattern: `isampler3D`

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
eNFA135_20_58592948[["εNFA135-20 regex start"]]
eNFA135_0_57574486[["εNFA135-0 char{1, 1}"]]
eNFA135_1_48408329[["εNFA135-1 char[1]"]]
eNFA135_2_33021783[["εNFA135-2 char{1, 1}"]]
eNFA135_3_28760591[["εNFA135-3 char[1]"]]
eNFA135_4_57518732[["εNFA135-4 char{1, 1}"]]
eNFA135_5_47906541[["εNFA135-5 char[1]"]]
eNFA135_6_28505693[["εNFA135-6 char{1, 1}"]]
eNFA135_7_55224652[["εNFA135-7 char[1]"]]
eNFA135_8_27259828[["εNFA135-8 char{1, 1}"]]
eNFA135_9_44011860[["εNFA135-9 char[1]"]]
eNFA135_10_60562422[["εNFA135-10 char{1, 1}"]]
eNFA135_11_8190892[["εNFA135-11 char[1]"]]
eNFA135_12_6609165[["εNFA135-12 char{1, 1}"]]
eNFA135_13_59482492[["εNFA135-13 char[1]"]]
eNFA135_14_65580385[["εNFA135-14 char{1, 1}"]]
eNFA135_15_53352557[["εNFA135-15 char[1]"]]
eNFA135_16_10410969[["εNFA135-16 char{1, 1}"]]
eNFA135_17_26589862[["εNFA135-17 char[1]"]]
eNFA135_18_37982174[["εNFA135-18 char{1, 1}"]]
eNFA135_19_6295248[["εNFA135-19 char[1]"]]
eNFA135_21_56657239[["εNFA135-21 regex end"]]
eNFA135_22_40153107[["εNFA135-22 post-regex start"]]
eNFA135_23_25833645[\"εNFA135-23 post-regex end"/]
eNFA135_20_58592948 -.->|"ε"|eNFA135_0_57574486
eNFA135_0_57574486 -->|"i"|eNFA135_1_48408329
eNFA135_1_48408329 -.->|"ε"|eNFA135_2_33021783
eNFA135_2_33021783 -->|"s"|eNFA135_3_28760591
eNFA135_3_28760591 -.->|"ε"|eNFA135_4_57518732
eNFA135_4_57518732 -->|"a"|eNFA135_5_47906541
eNFA135_5_47906541 -.->|"ε"|eNFA135_6_28505693
eNFA135_6_28505693 -->|"m"|eNFA135_7_55224652
eNFA135_7_55224652 -.->|"ε"|eNFA135_8_27259828
eNFA135_8_27259828 -->|"p"|eNFA135_9_44011860
eNFA135_9_44011860 -.->|"ε"|eNFA135_10_60562422
eNFA135_10_60562422 -->|"l"|eNFA135_11_8190892
eNFA135_11_8190892 -.->|"ε"|eNFA135_12_6609165
eNFA135_12_6609165 -->|"e"|eNFA135_13_59482492
eNFA135_13_59482492 -.->|"ε"|eNFA135_14_65580385
eNFA135_14_65580385 -->|"r"|eNFA135_15_53352557
eNFA135_15_53352557 -.->|"ε"|eNFA135_16_10410969
eNFA135_16_10410969 -->|"3"|eNFA135_17_26589862
eNFA135_17_26589862 -.->|"ε"|eNFA135_18_37982174
eNFA135_18_37982174 -->|"D"|eNFA135_19_6295248
eNFA135_19_6295248 -.->|"ε"|eNFA135_21_56657239
eNFA135_21_56657239 -.->|"ε"|eNFA135_22_40153107
eNFA135_22_40153107 -.->|"ε"|eNFA135_23_25833645
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
eNFA135_20_31176214[["εNFA135-20 regex start"]]
eNFA135_0_12150471[["εNFA135-0 char{1, 1}"]]
eNFA135_1_42245377[["εNFA135-1 char[1]"]]
eNFA135_2_44664077[["εNFA135-2 char{1, 1}"]]
eNFA135_3_66432381[["εNFA135-3 char[1]"]]
eNFA135_4_61020521[["εNFA135-4 char{1, 1}"]]
eNFA135_5_12313777[["εNFA135-5 char[1]"]]
eNFA135_6_43715136[["εNFA135-6 char{1, 1}"]]
eNFA135_7_57891910[["εNFA135-7 char[1]"]]
eNFA135_8_51265148[["εNFA135-8 char{1, 1}"]]
eNFA135_9_58733156[["εNFA135-9 char[1]"]]
eNFA135_10_58836357[["εNFA135-10 char{1, 1}"]]
eNFA135_11_59765170[["εNFA135-11 char[1]"]]
eNFA135_12_1015618[["εNFA135-12 char{1, 1}"]]
eNFA135_13_9140568[["εNFA135-13 char[1]"]]
eNFA135_14_15156252[["εNFA135-14 char{1, 1}"]]
eNFA135_15_2188543[["εNFA135-15 char[1]"]]
eNFA135_16_19696890[["εNFA135-16 char{1, 1}"]]
eNFA135_17_43054286[["εNFA135-17 char[1]"]]
eNFA135_18_51944261[["εNFA135-18 char{1, 1}"]]
eNFA135_19_64845166[\"εNFA135-19 char[1]"/]
eNFA135_21_46735588[\"εNFA135-21 regex end"/]
eNFA135_22_17967111[\"εNFA135-22 post-regex start"/]
eNFA135_23_27486272[\"εNFA135-23 post-regex end"/]
eNFA135_20_31176214 -.->|"ε"|eNFA135_0_12150471
eNFA135_20_31176214 -->|"i"|eNFA135_1_42245377
eNFA135_0_12150471 -->|"i"|eNFA135_1_42245377
eNFA135_1_42245377 -.->|"ε"|eNFA135_2_44664077
eNFA135_1_42245377 -->|"s"|eNFA135_3_66432381
eNFA135_2_44664077 -->|"s"|eNFA135_3_66432381
eNFA135_3_66432381 -.->|"ε"|eNFA135_4_61020521
eNFA135_3_66432381 -->|"a"|eNFA135_5_12313777
eNFA135_4_61020521 -->|"a"|eNFA135_5_12313777
eNFA135_5_12313777 -.->|"ε"|eNFA135_6_43715136
eNFA135_5_12313777 -->|"m"|eNFA135_7_57891910
eNFA135_6_43715136 -->|"m"|eNFA135_7_57891910
eNFA135_7_57891910 -.->|"ε"|eNFA135_8_51265148
eNFA135_7_57891910 -->|"p"|eNFA135_9_58733156
eNFA135_8_51265148 -->|"p"|eNFA135_9_58733156
eNFA135_9_58733156 -.->|"ε"|eNFA135_10_58836357
eNFA135_9_58733156 -->|"l"|eNFA135_11_59765170
eNFA135_10_58836357 -->|"l"|eNFA135_11_59765170
eNFA135_11_59765170 -.->|"ε"|eNFA135_12_1015618
eNFA135_11_59765170 -->|"e"|eNFA135_13_9140568
eNFA135_12_1015618 -->|"e"|eNFA135_13_9140568
eNFA135_13_9140568 -.->|"ε"|eNFA135_14_15156252
eNFA135_13_9140568 -->|"r"|eNFA135_15_2188543
eNFA135_14_15156252 -->|"r"|eNFA135_15_2188543
eNFA135_15_2188543 -.->|"ε"|eNFA135_16_19696890
eNFA135_15_2188543 -->|"3"|eNFA135_17_43054286
eNFA135_16_19696890 -->|"3"|eNFA135_17_43054286
eNFA135_17_43054286 -.->|"ε"|eNFA135_18_51944261
eNFA135_17_43054286 -->|"D"|eNFA135_19_64845166
eNFA135_18_51944261 -->|"D"|eNFA135_19_64845166
eNFA135_19_64845166 -.->|"ε"|eNFA135_21_46735588
eNFA135_19_64845166 -.->|"ε"|eNFA135_22_17967111
eNFA135_19_64845166 -.->|"ε"|eNFA135_23_27486272
eNFA135_21_46735588 -.->|"ε"|eNFA135_22_17967111
eNFA135_21_46735588 -.->|"ε"|eNFA135_23_27486272
eNFA135_22_17967111 -.->|"ε"|eNFA135_23_27486272
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
NFA135_20_46049856("NFA135-20 regex start")
NFA135_1_11795520("NFA135-1 char[1]")
NFA135_3_39050817("NFA135-3 char[1]")
NFA135_5_15913036("NFA135-5 char[1]")
NFA135_7_8999603("NFA135-7 char[1]")
NFA135_9_13887565("NFA135-9 char[1]")
NFA135_11_57879229("NFA135-11 char[1]")
NFA135_13_51151019("NFA135-13 char[1]")
NFA135_15_57705992("NFA135-15 char[1]")
NFA135_17_49591885("NFA135-17 char[1]")
NFA135_19_43673788[\"NFA135-19 char[1]"/]
NFA135_20_46049856 -->|"i"|NFA135_1_11795520
NFA135_1_11795520 -->|"s"|NFA135_3_39050817
NFA135_3_39050817 -->|"a"|NFA135_5_15913036
NFA135_5_15913036 -->|"m"|NFA135_7_8999603
NFA135_7_8999603 -->|"p"|NFA135_9_13887565
NFA135_9_13887565 -->|"l"|NFA135_11_57879229
NFA135_11_57879229 -->|"e"|NFA135_13_51151019
NFA135_13_51151019 -->|"r"|NFA135_15_57705992
NFA135_15_57705992 -->|"3"|NFA135_17_49591885
NFA135_17_49591885 -->|"D"|NFA135_19_43673788
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
subgraph DFA0_-2135622305["DFA0 regex start"]
NFA135_20_46049856_0("NFA135-20 regex start")
end
subgraph DFA1_2008580966["DFA1 {1}"]
NFA135_1_11795520_1("NFA135-1 char[1]")
end
subgraph DFA2_1456198372["DFA2 {1}"]
NFA135_3_39050817_2("NFA135-3 char[1]")
end
subgraph DFA3_679360654["DFA3 {1}"]
NFA135_5_15913036_3("NFA135-5 char[1]")
end
subgraph DFA4_-517969778["DFA4 {1}"]
NFA135_7_8999603_4("NFA135-7 char[1]")
end
subgraph DFA5_-696300860["DFA5 {1}"]
NFA135_9_13887565_5("NFA135-9 char[1]")
end
subgraph DFA6_-444596819["DFA6 {1}"]
NFA135_11_57879229_6("NFA135-11 char[1]")
end
subgraph DFA7_-1471108352["DFA7 {1}"]
NFA135_13_51151019_7("NFA135-13 char[1]")
end
subgraph DFA8_1289394368["DFA8 {1}"]
NFA135_15_57705992_8("NFA135-15 char[1]")
end
subgraph DFA9_-1074939141["DFA9 {1}"]
NFA135_17_49591885_9("NFA135-17 char[1]")
end
subgraph DFA10_-1692406204["DFA10 {1}"]
NFA135_19_43673788_10[\"NFA135-19 char[1]"/]
end
DFA0_-2135622305 -->|"i"|DFA1_2008580966
DFA1_2008580966 -->|"s"|DFA2_1456198372
DFA2_1456198372 -->|"a"|DFA3_679360654
DFA3_679360654 -->|"m"|DFA4_-517969778
DFA4_-517969778 -->|"p"|DFA5_-696300860
DFA5_-696300860 -->|"l"|DFA6_-444596819
DFA6_-444596819 -->|"e"|DFA7_-1471108352
DFA7_-1471108352 -->|"r"|DFA8_1289394368
DFA8_1289394368 -->|"3"|DFA9_-1074939141
DFA9_-1074939141 -->|"D"|DFA10_-1692406204
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
DFA0_-2135622305{{"DFA0 regex start"}}
DFA1_2008580966{{"DFA1 {1}"}}
DFA2_1456198372{{"DFA2 {1}"}}
DFA3_679360654{{"DFA3 {1}"}}
DFA4_-517969778{{"DFA4 {1}"}}
DFA5_-696300860{{"DFA5 {1}"}}
DFA6_-444596819{{"DFA6 {1}"}}
DFA7_-1471108352{{"DFA7 {1}"}}
DFA8_1289394368{{"DFA8 {1}"}}
DFA9_-1074939141{{"DFA9 {1}"}}
DFA10_-1692406204[\"DFA10 {1}"/]
DFA0_-2135622305 -->|"i"|DFA1_2008580966
DFA1_2008580966 -->|"s"|DFA2_1456198372
DFA2_1456198372 -->|"a"|DFA3_679360654
DFA3_679360654 -->|"m"|DFA4_-517969778
DFA4_-517969778 -->|"p"|DFA5_-696300860
DFA5_-696300860 -->|"l"|DFA6_-444596819
DFA6_-444596819 -->|"e"|DFA7_-1471108352
DFA7_-1471108352 -->|"r"|DFA8_1289394368
DFA8_1289394368 -->|"3"|DFA9_-1074939141
DFA9_-1074939141 -->|"D"|DFA10_-1692406204
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
subgraph MiniDFA0_-1322337920["MiniDFA0 {1}"]
DFA0_-2135622305_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1497647456["MiniDFA1 {1}"]
DFA1_2008580966_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_778116728["MiniDFA2 {1}"]
DFA2_1456198372_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_648510403["MiniDFA3 {1}"]
DFA3_679360654_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1847503044["MiniDFA4 {1}"]
DFA4_-517969778_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_2041501676["MiniDFA5 {1}"]
DFA5_-696300860_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1696905574["MiniDFA6 {1}"]
DFA6_-444596819_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-470146333["MiniDFA7 {1}"]
DFA7_-1471108352_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1223997481["MiniDFA8 {1}"]
DFA8_1289394368_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-40248897["MiniDFA9 {1}"]
DFA9_-1074939141_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_787057795["MiniDFA10 {1}"]
DFA10_-1692406204_10[\"DFA10 {1}"/]
end
MiniDFA0_-1322337920 -->|"i"|MiniDFA1_-1497647456
MiniDFA1_-1497647456 -->|"s"|MiniDFA2_778116728
MiniDFA2_778116728 -->|"a"|MiniDFA3_648510403
MiniDFA3_648510403 -->|"m"|MiniDFA4_-1847503044
MiniDFA4_-1847503044 -->|"p"|MiniDFA5_2041501676
MiniDFA5_2041501676 -->|"l"|MiniDFA6_1696905574
MiniDFA6_1696905574 -->|"e"|MiniDFA7_-470146333
MiniDFA7_-470146333 -->|"r"|MiniDFA8_-1223997481
MiniDFA8_-1223997481 -->|"3"|MiniDFA9_-40248897
MiniDFA9_-40248897 -->|"D"|MiniDFA10_787057795
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
MiniDFA0_-1322337920(["MiniDFA0 {1}"])
MiniDFA1_-1497647456(["MiniDFA1 {1}"])
MiniDFA2_778116728(["MiniDFA2 {1}"])
MiniDFA3_648510403(["MiniDFA3 {1}"])
MiniDFA4_-1847503044(["MiniDFA4 {1}"])
MiniDFA5_2041501676(["MiniDFA5 {1}"])
MiniDFA6_1696905574(["MiniDFA6 {1}"])
MiniDFA7_-470146333(["MiniDFA7 {1}"])
MiniDFA8_-1223997481(["MiniDFA8 {1}"])
MiniDFA9_-40248897(["MiniDFA9 {1}"])
MiniDFA10_787057795[\"MiniDFA10 {1}"/]
MiniDFA0_-1322337920 -->|"i"|MiniDFA1_-1497647456
MiniDFA1_-1497647456 -->|"s"|MiniDFA2_778116728
MiniDFA2_778116728 -->|"a"|MiniDFA3_648510403
MiniDFA3_648510403 -->|"m"|MiniDFA4_-1847503044
MiniDFA4_-1847503044 -->|"p"|MiniDFA5_2041501676
MiniDFA5_2041501676 -->|"l"|MiniDFA6_1696905574
MiniDFA6_1696905574 -->|"e"|MiniDFA7_-470146333
MiniDFA7_-470146333 -->|"r"|MiniDFA8_-1223997481
MiniDFA8_-1223997481 -->|"3"|MiniDFA9_-40248897
MiniDFA9_-40248897 -->|"D"|MiniDFA10_787057795
```
-------------------------------
