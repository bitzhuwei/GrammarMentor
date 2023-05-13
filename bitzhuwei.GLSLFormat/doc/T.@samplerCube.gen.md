# 'samplerCube'

pattern: `samplerCube`

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
eNFA123_22_38070478[["εNFA123-22 regex start"]]
eNFA123_0_7089989[["εNFA123-0 char{1, 1}"]]
eNFA123_1_63809907[["εNFA123-1 char[1]"]]
eNFA123_2_37418257[["εNFA123-2 char{1, 1}"]]
eNFA123_3_1220001[["εNFA123-3 char[1]"]]
eNFA123_4_10980010[["εNFA123-4 char{1, 1}"]]
eNFA123_5_31711231[["εNFA123-5 char[1]"]]
eNFA123_6_16965623[["εNFA123-6 char{1, 1}"]]
eNFA123_7_18472885[["εNFA123-7 char[1]"]]
eNFA123_8_32038241[["εNFA123-8 char{1, 1}"]]
eNFA123_9_19908716[["εNFA123-9 char[1]"]]
eNFA123_10_44960719[["εNFA123-10 char{1, 1}"]]
eNFA123_11_1993291[["εNFA123-11 char[1]"]]
eNFA123_12_17939626[["εNFA123-12 char{1, 1}"]]
eNFA123_13_27238907[["εNFA123-13 char[1]"]]
eNFA123_14_43823577[["εNFA123-14 char{1, 1}"]]
eNFA123_15_58867876[["εNFA123-15 char[1]"]]
eNFA123_16_60048837[["εNFA123-16 char{1, 1}"]]
eNFA123_17_3568621[["εNFA123-17 char[1]"]]
eNFA123_18_32117589[["εNFA123-18 char{1, 1}"]]
eNFA123_19_20622846[["εNFA123-19 char[1]"]]
eNFA123_20_51387889[["εNFA123-20 char{1, 1}"]]
eNFA123_21_59837824[["εNFA123-21 char[1]"]]
eNFA123_23_1669506[["εNFA123-23 regex end"]]
eNFA123_24_15025562[["εNFA123-24 post-regex start"]]
eNFA123_25_1012336[\"εNFA123-25 post-regex end"/]
eNFA123_22_38070478 -.->|"ε"|eNFA123_0_7089989
eNFA123_0_7089989 -->|"s"|eNFA123_1_63809907
eNFA123_1_63809907 -.->|"ε"|eNFA123_2_37418257
eNFA123_2_37418257 -->|"a"|eNFA123_3_1220001
eNFA123_3_1220001 -.->|"ε"|eNFA123_4_10980010
eNFA123_4_10980010 -->|"m"|eNFA123_5_31711231
eNFA123_5_31711231 -.->|"ε"|eNFA123_6_16965623
eNFA123_6_16965623 -->|"p"|eNFA123_7_18472885
eNFA123_7_18472885 -.->|"ε"|eNFA123_8_32038241
eNFA123_8_32038241 -->|"l"|eNFA123_9_19908716
eNFA123_9_19908716 -.->|"ε"|eNFA123_10_44960719
eNFA123_10_44960719 -->|"e"|eNFA123_11_1993291
eNFA123_11_1993291 -.->|"ε"|eNFA123_12_17939626
eNFA123_12_17939626 -->|"r"|eNFA123_13_27238907
eNFA123_13_27238907 -.->|"ε"|eNFA123_14_43823577
eNFA123_14_43823577 -->|"C"|eNFA123_15_58867876
eNFA123_15_58867876 -.->|"ε"|eNFA123_16_60048837
eNFA123_16_60048837 -->|"u"|eNFA123_17_3568621
eNFA123_17_3568621 -.->|"ε"|eNFA123_18_32117589
eNFA123_18_32117589 -->|"b"|eNFA123_19_20622846
eNFA123_19_20622846 -.->|"ε"|eNFA123_20_51387889
eNFA123_20_51387889 -->|"e"|eNFA123_21_59837824
eNFA123_21_59837824 -.->|"ε"|eNFA123_23_1669506
eNFA123_23_1669506 -.->|"ε"|eNFA123_24_15025562
eNFA123_24_15025562 -.->|"ε"|eNFA123_25_1012336
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
eNFA123_22_9111029[["εNFA123-22 regex start"]]
eNFA123_0_14890402[["εNFA123-0 char{1, 1}"]]
eNFA123_1_66904761[["εNFA123-1 char[1]"]]
eNFA123_2_65271937[["εNFA123-2 char{1, 1}"]]
eNFA123_3_50576524[["εNFA123-3 char[1]"]]
eNFA123_4_52535540[["εNFA123-4 char{1, 1}"]]
eNFA123_5_3057817[["εNFA123-5 char[1]"]]
eNFA123_6_27520356[["εNFA123-6 char{1, 1}"]]
eNFA123_7_46356614[["εNFA123-7 char[1]"]]
eNFA123_8_14556344[["εNFA123-8 char{1, 1}"]]
eNFA123_9_63898235[["εNFA123-9 char[1]"]]
eNFA123_10_38213209[["εNFA123-10 char{1, 1}"]]
eNFA123_11_8374561[["εNFA123-11 char[1]"]]
eNFA123_12_8262190[["εNFA123-12 char{1, 1}"]]
eNFA123_13_7250847[["εNFA123-13 char[1]"]]
eNFA123_14_65257631[["εNFA123-14 char{1, 1}"]]
eNFA123_15_50447774[["εNFA123-15 char[1]"]]
eNFA123_16_51376790[["εNFA123-16 char{1, 1}"]]
eNFA123_17_59737926[["εNFA123-17 char[1]"]]
eNFA123_18_770424[["εNFA123-18 char{1, 1}"]]
eNFA123_19_6933822[["εNFA123-19 char[1]"]]
eNFA123_20_62404399[["εNFA123-20 char{1, 1}"]]
eNFA123_21_24768686[\"εNFA123-21 char[1]"/]
eNFA123_23_21591587[\"εNFA123-23 regex end"/]
eNFA123_24_60106559[\"εNFA123-24 post-regex start"/]
eNFA123_25_4088123[\"εNFA123-25 post-regex end"/]
eNFA123_22_9111029 -.->|"ε"|eNFA123_0_14890402
eNFA123_22_9111029 -->|"s"|eNFA123_1_66904761
eNFA123_0_14890402 -->|"s"|eNFA123_1_66904761
eNFA123_1_66904761 -.->|"ε"|eNFA123_2_65271937
eNFA123_1_66904761 -->|"a"|eNFA123_3_50576524
eNFA123_2_65271937 -->|"a"|eNFA123_3_50576524
eNFA123_3_50576524 -.->|"ε"|eNFA123_4_52535540
eNFA123_3_50576524 -->|"m"|eNFA123_5_3057817
eNFA123_4_52535540 -->|"m"|eNFA123_5_3057817
eNFA123_5_3057817 -.->|"ε"|eNFA123_6_27520356
eNFA123_5_3057817 -->|"p"|eNFA123_7_46356614
eNFA123_6_27520356 -->|"p"|eNFA123_7_46356614
eNFA123_7_46356614 -.->|"ε"|eNFA123_8_14556344
eNFA123_7_46356614 -->|"l"|eNFA123_9_63898235
eNFA123_8_14556344 -->|"l"|eNFA123_9_63898235
eNFA123_9_63898235 -.->|"ε"|eNFA123_10_38213209
eNFA123_9_63898235 -->|"e"|eNFA123_11_8374561
eNFA123_10_38213209 -->|"e"|eNFA123_11_8374561
eNFA123_11_8374561 -.->|"ε"|eNFA123_12_8262190
eNFA123_11_8374561 -->|"r"|eNFA123_13_7250847
eNFA123_12_8262190 -->|"r"|eNFA123_13_7250847
eNFA123_13_7250847 -.->|"ε"|eNFA123_14_65257631
eNFA123_13_7250847 -->|"C"|eNFA123_15_50447774
eNFA123_14_65257631 -->|"C"|eNFA123_15_50447774
eNFA123_15_50447774 -.->|"ε"|eNFA123_16_51376790
eNFA123_15_50447774 -->|"u"|eNFA123_17_59737926
eNFA123_16_51376790 -->|"u"|eNFA123_17_59737926
eNFA123_17_59737926 -.->|"ε"|eNFA123_18_770424
eNFA123_17_59737926 -->|"b"|eNFA123_19_6933822
eNFA123_18_770424 -->|"b"|eNFA123_19_6933822
eNFA123_19_6933822 -.->|"ε"|eNFA123_20_62404399
eNFA123_19_6933822 -->|"e"|eNFA123_21_24768686
eNFA123_20_62404399 -->|"e"|eNFA123_21_24768686
eNFA123_21_24768686 -.->|"ε"|eNFA123_23_21591587
eNFA123_21_24768686 -.->|"ε"|eNFA123_24_60106559
eNFA123_21_24768686 -.->|"ε"|eNFA123_25_4088123
eNFA123_23_21591587 -.->|"ε"|eNFA123_24_60106559
eNFA123_23_21591587 -.->|"ε"|eNFA123_25_4088123
eNFA123_24_60106559 -.->|"ε"|eNFA123_25_4088123
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
NFA123_22_36793112("NFA123-22 regex start")
NFA123_1_62702560("NFA123-1 char[1]")
NFA123_3_27452130("NFA123-3 char[1]")
NFA123_5_45742585("NFA123-5 char[1]")
NFA123_7_9030085("NFA123-7 char[1]")
NFA123_9_14161903("NFA123-9 char[1]")
NFA123_11_60348264("NFA123-11 char[1]")
NFA123_13_6263465("NFA123-13 char[1]")
NFA123_15_56371187("NFA123-15 char[1]")
NFA123_17_37578639("NFA123-17 char[1]")
NFA123_19_2663439("NFA123-19 char[1]")
NFA123_21_23970955[\"NFA123-21 char[1]"/]
NFA123_22_36793112 -->|"s"|NFA123_1_62702560
NFA123_1_62702560 -->|"a"|NFA123_3_27452130
NFA123_3_27452130 -->|"m"|NFA123_5_45742585
NFA123_5_45742585 -->|"p"|NFA123_7_9030085
NFA123_7_9030085 -->|"l"|NFA123_9_14161903
NFA123_9_14161903 -->|"e"|NFA123_11_60348264
NFA123_11_60348264 -->|"r"|NFA123_13_6263465
NFA123_13_6263465 -->|"C"|NFA123_15_56371187
NFA123_15_56371187 -->|"u"|NFA123_17_37578639
NFA123_17_37578639 -->|"b"|NFA123_19_2663439
NFA123_19_2663439 -->|"e"|NFA123_21_23970955
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
subgraph DFA0_15705987["DFA0 regex start"]
NFA123_22_36793112_0("NFA123-22 regex start")
end
subgraph DFA1_713353894["DFA1 {1}"]
NFA123_1_62702560_1("NFA123-1 char[1]")
end
subgraph DFA2_1131759356["DFA2 {1}"]
NFA123_3_27452130_2("NFA123-3 char[1]")
end
subgraph DFA3_-79658257["DFA3 {1}"]
NFA123_5_45742585_3("NFA123-5 char[1]")
end
subgraph DFA4_2012649864["DFA4 {1}"]
NFA123_7_9030085_4("NFA123-7 char[1]")
end
subgraph DFA5_-873464018["DFA5 {1}"]
NFA123_9_14161903_5("NFA123-9 char[1]")
end
subgraph DFA6_415836962["DFA6 {1}"]
NFA123_11_60348264_6("NFA123-11 char[1]")
end
subgraph DFA7_-1908772392["DFA7 {1}"]
NFA123_13_6263465_7("NFA123-13 char[1]")
end
subgraph DFA8_1359172186["DFA8 {1}"]
NFA123_15_56371187_8("NFA123-15 char[1]")
end
subgraph DFA9_-1485277794["DFA9 {1}"]
NFA123_17_37578639_9("NFA123-17 char[1]")
end
subgraph DFA10_-471382205["DFA10 {1}"]
NFA123_19_2663439_10("NFA123-19 char[1]")
end
subgraph DFA11_-296195495["DFA11 {1}"]
NFA123_21_23970955_11[\"NFA123-21 char[1]"/]
end
DFA0_15705987 -->|"s"|DFA1_713353894
DFA1_713353894 -->|"a"|DFA2_1131759356
DFA2_1131759356 -->|"m"|DFA3_-79658257
DFA3_-79658257 -->|"p"|DFA4_2012649864
DFA4_2012649864 -->|"l"|DFA5_-873464018
DFA5_-873464018 -->|"e"|DFA6_415836962
DFA6_415836962 -->|"r"|DFA7_-1908772392
DFA7_-1908772392 -->|"C"|DFA8_1359172186
DFA8_1359172186 -->|"u"|DFA9_-1485277794
DFA9_-1485277794 -->|"b"|DFA10_-471382205
DFA10_-471382205 -->|"e"|DFA11_-296195495
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
DFA0_15705987{{"DFA0 regex start"}}
DFA1_713353894{{"DFA1 {1}"}}
DFA2_1131759356{{"DFA2 {1}"}}
DFA3_-79658257{{"DFA3 {1}"}}
DFA4_2012649864{{"DFA4 {1}"}}
DFA5_-873464018{{"DFA5 {1}"}}
DFA6_415836962{{"DFA6 {1}"}}
DFA7_-1908772392{{"DFA7 {1}"}}
DFA8_1359172186{{"DFA8 {1}"}}
DFA9_-1485277794{{"DFA9 {1}"}}
DFA10_-471382205{{"DFA10 {1}"}}
DFA11_-296195495[\"DFA11 {1}"/]
DFA0_15705987 -->|"s"|DFA1_713353894
DFA1_713353894 -->|"a"|DFA2_1131759356
DFA2_1131759356 -->|"m"|DFA3_-79658257
DFA3_-79658257 -->|"p"|DFA4_2012649864
DFA4_2012649864 -->|"l"|DFA5_-873464018
DFA5_-873464018 -->|"e"|DFA6_415836962
DFA6_415836962 -->|"r"|DFA7_-1908772392
DFA7_-1908772392 -->|"C"|DFA8_1359172186
DFA8_1359172186 -->|"u"|DFA9_-1485277794
DFA9_-1485277794 -->|"b"|DFA10_-471382205
DFA10_-471382205 -->|"e"|DFA11_-296195495
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
subgraph MiniDFA0_1720200116["MiniDFA0 {1}"]
DFA0_15705987_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-2111216258["MiniDFA1 {1}"]
DFA1_713353894_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_9259013["MiniDFA2 {1}"]
DFA2_1131759356_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1055522036["MiniDFA3 {1}"]
DFA3_-79658257_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1944267208["MiniDFA4 {1}"]
DFA4_2012649864_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1700317693["MiniDFA5 {1}"]
DFA5_-873464018_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1501298191["MiniDFA6 {1}"]
DFA6_415836962_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1306624355["MiniDFA7 {1}"]
DFA7_-1908772392_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1625249749["MiniDFA8 {1}"]
DFA8_1359172186_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-947347813["MiniDFA9 {1}"]
DFA9_-1485277794_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_57042070["MiniDFA10 {1}"]
DFA10_-471382205_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-518098413["MiniDFA11 {1}"]
DFA11_-296195495_11[\"DFA11 {1}"/]
end
MiniDFA0_1720200116 -->|"s"|MiniDFA1_-2111216258
MiniDFA1_-2111216258 -->|"a"|MiniDFA2_9259013
MiniDFA2_9259013 -->|"m"|MiniDFA3_-1055522036
MiniDFA3_-1055522036 -->|"p"|MiniDFA4_1944267208
MiniDFA4_1944267208 -->|"l"|MiniDFA5_1700317693
MiniDFA5_1700317693 -->|"e"|MiniDFA6_1501298191
MiniDFA6_1501298191 -->|"r"|MiniDFA7_1306624355
MiniDFA7_1306624355 -->|"C"|MiniDFA8_-1625249749
MiniDFA8_-1625249749 -->|"u"|MiniDFA9_-947347813
MiniDFA9_-947347813 -->|"b"|MiniDFA10_57042070
MiniDFA10_57042070 -->|"e"|MiniDFA11_-518098413
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
MiniDFA0_1720200116(["MiniDFA0 {1}"])
MiniDFA1_-2111216258(["MiniDFA1 {1}"])
MiniDFA2_9259013(["MiniDFA2 {1}"])
MiniDFA3_-1055522036(["MiniDFA3 {1}"])
MiniDFA4_1944267208(["MiniDFA4 {1}"])
MiniDFA5_1700317693(["MiniDFA5 {1}"])
MiniDFA6_1501298191(["MiniDFA6 {1}"])
MiniDFA7_1306624355(["MiniDFA7 {1}"])
MiniDFA8_-1625249749(["MiniDFA8 {1}"])
MiniDFA9_-947347813(["MiniDFA9 {1}"])
MiniDFA10_57042070(["MiniDFA10 {1}"])
MiniDFA11_-518098413[\"MiniDFA11 {1}"/]
MiniDFA0_1720200116 -->|"s"|MiniDFA1_-2111216258
MiniDFA1_-2111216258 -->|"a"|MiniDFA2_9259013
MiniDFA2_9259013 -->|"m"|MiniDFA3_-1055522036
MiniDFA3_-1055522036 -->|"p"|MiniDFA4_1944267208
MiniDFA4_1944267208 -->|"l"|MiniDFA5_1700317693
MiniDFA5_1700317693 -->|"e"|MiniDFA6_1501298191
MiniDFA6_1501298191 -->|"r"|MiniDFA7_1306624355
MiniDFA7_1306624355 -->|"C"|MiniDFA8_-1625249749
MiniDFA8_-1625249749 -->|"u"|MiniDFA9_-947347813
MiniDFA9_-947347813 -->|"b"|MiniDFA10_57042070
MiniDFA10_57042070 -->|"e"|MiniDFA11_-518098413
```
-------------------------------
