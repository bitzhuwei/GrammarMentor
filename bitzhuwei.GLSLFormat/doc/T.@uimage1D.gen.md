# 'uimage1D'

pattern: `uimage1D`

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
eNFA162_16_9311818[["εNFA162-16 regex start"]]
eNFA162_0_16697504[["εNFA162-0 char{1, 1}"]]
eNFA162_1_16059811[["εNFA162-1 char[1]"]]
eNFA162_2_10320572[["εNFA162-2 char{1, 1}"]]
eNFA162_3_25776284[["εNFA162-3 char[1]"]]
eNFA162_4_30659964[["εNFA162-4 char{1, 1}"]]
eNFA162_5_7504221[["εNFA162-5 char[1]"]]
eNFA162_6_429128[["εNFA162-6 char{1, 1}"]]
eNFA162_7_3862159[["εNFA162-7 char[1]"]]
eNFA162_8_34759433[["εNFA162-8 char{1, 1}"]]
eNFA162_9_44399449[["εNFA162-9 char[1]"]]
eNFA162_10_64050727[["εNFA162-10 char{1, 1}"]]
eNFA162_11_39585636[["εNFA162-11 char[1]"]]
eNFA162_12_20726409[["εNFA162-12 char{1, 1}"]]
eNFA162_13_52319960[["εNFA162-13 char[1]"]]
eNFA162_14_1117592[["εNFA162-14 char{1, 1}"]]
eNFA162_15_10058331[["εNFA162-15 char[1]"]]
eNFA162_17_23416123[["εNFA162-17 regex end"]]
eNFA162_18_9418520[["εNFA162-18 post-regex start"]]
eNFA162_19_17657819[\"εNFA162-19 post-regex end"/]
eNFA162_16_9311818 -.->|"ε"|eNFA162_0_16697504
eNFA162_0_16697504 -->|"u"|eNFA162_1_16059811
eNFA162_1_16059811 -.->|"ε"|eNFA162_2_10320572
eNFA162_2_10320572 -->|"i"|eNFA162_3_25776284
eNFA162_3_25776284 -.->|"ε"|eNFA162_4_30659964
eNFA162_4_30659964 -->|"m"|eNFA162_5_7504221
eNFA162_5_7504221 -.->|"ε"|eNFA162_6_429128
eNFA162_6_429128 -->|"a"|eNFA162_7_3862159
eNFA162_7_3862159 -.->|"ε"|eNFA162_8_34759433
eNFA162_8_34759433 -->|"g"|eNFA162_9_44399449
eNFA162_9_44399449 -.->|"ε"|eNFA162_10_64050727
eNFA162_10_64050727 -->|"e"|eNFA162_11_39585636
eNFA162_11_39585636 -.->|"ε"|eNFA162_12_20726409
eNFA162_12_20726409 -->|"1"|eNFA162_13_52319960
eNFA162_13_52319960 -.->|"ε"|eNFA162_14_1117592
eNFA162_14_1117592 -->|"D"|eNFA162_15_10058331
eNFA162_15_10058331 -.->|"ε"|eNFA162_17_23416123
eNFA162_17_23416123 -.->|"ε"|eNFA162_18_9418520
eNFA162_18_9418520 -.->|"ε"|eNFA162_19_17657819
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
eNFA162_16_24702645[["εNFA162-16 regex start"]]
eNFA162_0_20997215[["εNFA162-0 char{1, 1}"]]
eNFA162_1_54757210[["εNFA162-1 char[1]"]]
eNFA162_2_23052848[["εNFA162-2 char{1, 1}"]]
eNFA162_3_6149040[["εNFA162-3 char[1]"]]
eNFA162_4_55341365[["εNFA162-4 char{1, 1}"]]
eNFA162_5_28310238[["εNFA162-5 char[1]"]]
eNFA162_6_53465558[["εNFA162-6 char{1, 1}"]]
eNFA162_7_11427981[["εNFA162-7 char[1]"]]
eNFA162_8_35742973[["εNFA162-8 char{1, 1}"]]
eNFA162_9_53251301[["εNFA162-9 char[1]"]]
eNFA162_10_9499663[["εNFA162-10 char{1, 1}"]]
eNFA162_11_18388109[["εNFA162-11 char[1]"]]
eNFA162_12_31275254[["εNFA162-12 char{1, 1}"]]
eNFA162_13_13041837[["εNFA162-13 char[1]"]]
eNFA162_14_50267674[["εNFA162-14 char{1, 1}"]]
eNFA162_15_49755886[\"εNFA162-15 char[1]"/]
eNFA162_17_45149794[\"εNFA162-17 regex end"/]
eNFA162_18_3694967[\"εNFA162-18 post-regex start"/]
eNFA162_19_33254711[\"εNFA162-19 post-regex end"/]
eNFA162_16_24702645 -.->|"ε"|eNFA162_0_20997215
eNFA162_16_24702645 -->|"u"|eNFA162_1_54757210
eNFA162_0_20997215 -->|"u"|eNFA162_1_54757210
eNFA162_1_54757210 -.->|"ε"|eNFA162_2_23052848
eNFA162_1_54757210 -->|"i"|eNFA162_3_6149040
eNFA162_2_23052848 -->|"i"|eNFA162_3_6149040
eNFA162_3_6149040 -.->|"ε"|eNFA162_4_55341365
eNFA162_3_6149040 -->|"m"|eNFA162_5_28310238
eNFA162_4_55341365 -->|"m"|eNFA162_5_28310238
eNFA162_5_28310238 -.->|"ε"|eNFA162_6_53465558
eNFA162_5_28310238 -->|"a"|eNFA162_7_11427981
eNFA162_6_53465558 -->|"a"|eNFA162_7_11427981
eNFA162_7_11427981 -.->|"ε"|eNFA162_8_35742973
eNFA162_7_11427981 -->|"g"|eNFA162_9_53251301
eNFA162_8_35742973 -->|"g"|eNFA162_9_53251301
eNFA162_9_53251301 -.->|"ε"|eNFA162_10_9499663
eNFA162_9_53251301 -->|"e"|eNFA162_11_18388109
eNFA162_10_9499663 -->|"e"|eNFA162_11_18388109
eNFA162_11_18388109 -.->|"ε"|eNFA162_12_31275254
eNFA162_11_18388109 -->|"1"|eNFA162_13_13041837
eNFA162_12_31275254 -->|"1"|eNFA162_13_13041837
eNFA162_13_13041837 -.->|"ε"|eNFA162_14_50267674
eNFA162_13_13041837 -->|"D"|eNFA162_15_49755886
eNFA162_14_50267674 -->|"D"|eNFA162_15_49755886
eNFA162_15_49755886 -.->|"ε"|eNFA162_17_45149794
eNFA162_15_49755886 -.->|"ε"|eNFA162_18_3694967
eNFA162_15_49755886 -.->|"ε"|eNFA162_19_33254711
eNFA162_17_45149794 -.->|"ε"|eNFA162_18_3694967
eNFA162_17_45149794 -.->|"ε"|eNFA162_19_33254711
eNFA162_18_3694967 -.->|"ε"|eNFA162_19_33254711
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
NFA162_16_30856945("NFA162-16 regex start")
NFA162_1_9277056("NFA162-1 char[1]")
NFA162_3_16384644("NFA162-3 char[1]")
NFA162_5_13244070("NFA162-5 char[1]")
NFA162_7_52087767("NFA162-7 char[1]")
NFA162_9_66136720("NFA162-9 char[1]")
NFA162_11_58359570("NFA162-11 char[1]")
NFA162_13_55474086("NFA162-13 char[1]")
NFA162_15_29504734[\"NFA162-15 char[1]"/]
NFA162_16_30856945 -->|"u"|NFA162_1_9277056
NFA162_1_9277056 -->|"i"|NFA162_3_16384644
NFA162_3_16384644 -->|"m"|NFA162_5_13244070
NFA162_5_13244070 -->|"a"|NFA162_7_52087767
NFA162_7_52087767 -->|"g"|NFA162_9_66136720
NFA162_9_66136720 -->|"e"|NFA162_11_58359570
NFA162_11_58359570 -->|"1"|NFA162_13_55474086
NFA162_13_55474086 -->|"D"|NFA162_15_29504734
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
subgraph DFA0_340860507["DFA0 regex start"]
NFA162_16_30856945_0("NFA162-16 regex start")
end
subgraph DFA1_-811364328["DFA1 {1}"]
NFA162_1_9277056_1("NFA162-1 char[1]")
end
subgraph DFA2_1388930731["DFA2 {1}"]
NFA162_3_16384644_2("NFA162-3 char[1]")
end
subgraph DFA3_-1989318940["DFA3 {1}"]
NFA162_5_13244070_3("NFA162-5 char[1]")
end
subgraph DFA4_-729584721["DFA4 {1}"]
NFA162_7_52087767_4("NFA162-7 char[1]")
end
subgraph DFA5_-136967214["DFA5 {1}"]
NFA162_9_66136720_5("NFA162-9 char[1]")
end
subgraph DFA6_509100502["DFA6 {1}"]
NFA162_11_58359570_6("NFA162-11 char[1]")
end
subgraph DFA7_-601096452["DFA7 {1}"]
NFA162_13_55474086_7("NFA162-13 char[1]")
end
subgraph DFA8_49624400["DFA8 {1}"]
NFA162_15_29504734_8[\"NFA162-15 char[1]"/]
end
DFA0_340860507 -->|"u"|DFA1_-811364328
DFA1_-811364328 -->|"i"|DFA2_1388930731
DFA2_1388930731 -->|"m"|DFA3_-1989318940
DFA3_-1989318940 -->|"a"|DFA4_-729584721
DFA4_-729584721 -->|"g"|DFA5_-136967214
DFA5_-136967214 -->|"e"|DFA6_509100502
DFA6_509100502 -->|"1"|DFA7_-601096452
DFA7_-601096452 -->|"D"|DFA8_49624400
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
DFA0_340860507{{"DFA0 regex start"}}
DFA1_-811364328{{"DFA1 {1}"}}
DFA2_1388930731{{"DFA2 {1}"}}
DFA3_-1989318940{{"DFA3 {1}"}}
DFA4_-729584721{{"DFA4 {1}"}}
DFA5_-136967214{{"DFA5 {1}"}}
DFA6_509100502{{"DFA6 {1}"}}
DFA7_-601096452{{"DFA7 {1}"}}
DFA8_49624400[\"DFA8 {1}"/]
DFA0_340860507 -->|"u"|DFA1_-811364328
DFA1_-811364328 -->|"i"|DFA2_1388930731
DFA2_1388930731 -->|"m"|DFA3_-1989318940
DFA3_-1989318940 -->|"a"|DFA4_-729584721
DFA4_-729584721 -->|"g"|DFA5_-136967214
DFA5_-136967214 -->|"e"|DFA6_509100502
DFA6_509100502 -->|"1"|DFA7_-601096452
DFA7_-601096452 -->|"D"|DFA8_49624400
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
subgraph MiniDFA0_-2002050870["MiniDFA0 {1}"]
DFA0_340860507_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1046061405["MiniDFA1 {1}"]
DFA1_-811364328_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1406384637["MiniDFA2 {1}"]
DFA2_1388930731_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1229014430["MiniDFA3 {1}"]
DFA3_-1989318940_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_912710054["MiniDFA4 {1}"]
DFA4_-729584721_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-945432971["MiniDFA5 {1}"]
DFA5_-136967214_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1376178021["MiniDFA6 {1}"]
DFA6_509100502_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1722742433["MiniDFA7 {1}"]
DFA7_-601096452_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_354750053["MiniDFA8 {1}"]
DFA8_49624400_8[\"DFA8 {1}"/]
end
MiniDFA0_-2002050870 -->|"u"|MiniDFA1_-1046061405
MiniDFA1_-1046061405 -->|"i"|MiniDFA2_-1406384637
MiniDFA2_-1406384637 -->|"m"|MiniDFA3_1229014430
MiniDFA3_1229014430 -->|"a"|MiniDFA4_912710054
MiniDFA4_912710054 -->|"g"|MiniDFA5_-945432971
MiniDFA5_-945432971 -->|"e"|MiniDFA6_-1376178021
MiniDFA6_-1376178021 -->|"1"|MiniDFA7_1722742433
MiniDFA7_1722742433 -->|"D"|MiniDFA8_354750053
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
MiniDFA0_-2002050870(["MiniDFA0 {1}"])
MiniDFA1_-1046061405(["MiniDFA1 {1}"])
MiniDFA2_-1406384637(["MiniDFA2 {1}"])
MiniDFA3_1229014430(["MiniDFA3 {1}"])
MiniDFA4_912710054(["MiniDFA4 {1}"])
MiniDFA5_-945432971(["MiniDFA5 {1}"])
MiniDFA6_-1376178021(["MiniDFA6 {1}"])
MiniDFA7_1722742433(["MiniDFA7 {1}"])
MiniDFA8_354750053[\"MiniDFA8 {1}"/]
MiniDFA0_-2002050870 -->|"u"|MiniDFA1_-1046061405
MiniDFA1_-1046061405 -->|"i"|MiniDFA2_-1406384637
MiniDFA2_-1406384637 -->|"m"|MiniDFA3_1229014430
MiniDFA3_1229014430 -->|"a"|MiniDFA4_912710054
MiniDFA4_912710054 -->|"g"|MiniDFA5_-945432971
MiniDFA5_-945432971 -->|"e"|MiniDFA6_-1376178021
MiniDFA6_-1376178021 -->|"1"|MiniDFA7_1722742433
MiniDFA7_1722742433 -->|"D"|MiniDFA8_354750053
```
-------------------------------
