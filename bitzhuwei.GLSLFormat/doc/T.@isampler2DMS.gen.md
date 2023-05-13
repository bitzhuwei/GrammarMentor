# 'isampler2DMS'

pattern: `isampler2DMS`

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
eNFA155_24_19577827[["εNFA155-24 regex start"]]
eNFA155_0_41982722[["εNFA155-0 char{1, 1}"]]
eNFA155_1_42300179[["εNFA155-1 char[1]"]]
eNFA155_2_45157297[["εNFA155-2 char{1, 1}"]]
eNFA155_3_3762492[["εNFA155-3 char[1]"]]
eNFA155_4_33862429[["εNFA155-4 char{1, 1}"]]
eNFA155_5_36326405[["εNFA155-5 char[1]"]]
eNFA155_6_58502189[["εNFA155-6 char{1, 1}"]]
eNFA155_7_56757654[["εNFA155-7 char[1]"]]
eNFA155_8_41056841[["εNFA155-8 char{1, 1}"]]
eNFA155_9_33967256[["εNFA155-9 char[1]"]]
eNFA155_10_37269850[["εNFA155-10 char{1, 1}"]]
eNFA155_11_66993202[["εNFA155-11 char[1]"]]
eNFA155_12_66067912[["εNFA155-12 char{1, 1}"]]
eNFA155_13_57740301[["εNFA155-13 char[1]"]]
eNFA155_14_49900666[["εNFA155-14 char{1, 1}"]]
eNFA155_15_46452817[["εNFA155-15 char[1]"]]
eNFA155_16_15422169[["εNFA155-16 char{1, 1}"]]
eNFA155_17_4581796[["εNFA155-17 char[1]"]]
eNFA155_18_41236172[["εNFA155-18 char{1, 1}"]]
eNFA155_19_35581233[["εNFA155-19 char[1]"]]
eNFA155_20_51795644[["εNFA155-20 char{1, 1}"]]
eNFA155_21_63507614[["εNFA155-21 char[1]"]]
eNFA155_22_34697616[["εNFA155-22 char{1, 1}"]]
eNFA155_23_43843091[["εNFA155-23 char[1]"]]
eNFA155_25_59043505[["εNFA155-25 regex end"]]
eNFA155_26_61629497[["εNFA155-26 post-regex start"]]
eNFA155_27_17794566[\"εNFA155-27 post-regex end"/]
eNFA155_24_19577827 -.->|"ε"|eNFA155_0_41982722
eNFA155_0_41982722 -->|"i"|eNFA155_1_42300179
eNFA155_1_42300179 -.->|"ε"|eNFA155_2_45157297
eNFA155_2_45157297 -->|"s"|eNFA155_3_3762492
eNFA155_3_3762492 -.->|"ε"|eNFA155_4_33862429
eNFA155_4_33862429 -->|"a"|eNFA155_5_36326405
eNFA155_5_36326405 -.->|"ε"|eNFA155_6_58502189
eNFA155_6_58502189 -->|"m"|eNFA155_7_56757654
eNFA155_7_56757654 -.->|"ε"|eNFA155_8_41056841
eNFA155_8_41056841 -->|"p"|eNFA155_9_33967256
eNFA155_9_33967256 -.->|"ε"|eNFA155_10_37269850
eNFA155_10_37269850 -->|"l"|eNFA155_11_66993202
eNFA155_11_66993202 -.->|"ε"|eNFA155_12_66067912
eNFA155_12_66067912 -->|"e"|eNFA155_13_57740301
eNFA155_13_57740301 -.->|"ε"|eNFA155_14_49900666
eNFA155_14_49900666 -->|"r"|eNFA155_15_46452817
eNFA155_15_46452817 -.->|"ε"|eNFA155_16_15422169
eNFA155_16_15422169 -->|"2"|eNFA155_17_4581796
eNFA155_17_4581796 -.->|"ε"|eNFA155_18_41236172
eNFA155_18_41236172 -->|"D"|eNFA155_19_35581233
eNFA155_19_35581233 -.->|"ε"|eNFA155_20_51795644
eNFA155_20_51795644 -->|"M"|eNFA155_21_63507614
eNFA155_21_63507614 -.->|"ε"|eNFA155_22_34697616
eNFA155_22_34697616 -->|"S"|eNFA155_23_43843091
eNFA155_23_43843091 -.->|"ε"|eNFA155_25_59043505
eNFA155_25_59043505 -.->|"ε"|eNFA155_26_61629497
eNFA155_26_61629497 -.->|"ε"|eNFA155_27_17794566
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
eNFA155_24_25933367[["εNFA155-24 regex start"]]
eNFA155_0_32073719[["εNFA155-0 char{1, 1}"]]
eNFA155_1_20228022[["εNFA155-1 char[1]"]]
eNFA155_2_47834478[["εNFA155-2 char{1, 1}"]]
eNFA155_3_27857118[["εNFA155-3 char[1]"]]
eNFA155_4_49387472[["εNFA155-4 char{1, 1}"]]
eNFA155_5_41834070[["εNFA155-5 char[1]"]]
eNFA155_6_40962311[["εNFA155-6 char{1, 1}"]]
eNFA155_7_33116486[["εNFA155-7 char[1]"]]
eNFA155_8_29612923[["εNFA155-8 char{1, 1}"]]
eNFA155_9_65189719[["εNFA155-9 char[1]"]]
eNFA155_10_49836563[["εNFA155-10 char{1, 1}"]]
eNFA155_11_45875888[["εNFA155-11 char[1]"]]
eNFA155_12_10229816[["εNFA155-12 char{1, 1}"]]
eNFA155_13_24959482[["εNFA155-13 char[1]"]]
eNFA155_14_23308753[["εNFA155-14 char{1, 1}"]]
eNFA155_15_8452189[["εNFA155-15 char[1]"]]
eNFA155_16_8960839[["εNFA155-16 char{1, 1}"]]
eNFA155_17_13538688[["εNFA155-17 char[1]"]]
eNFA155_18_54739329[["εNFA155-18 char{1, 1}"]]
eNFA155_19_22891915[["εNFA155-19 char[1]"]]
eNFA155_20_4700647[["εNFA155-20 char{1, 1}"]]
eNFA155_21_42305831[["εNFA155-21 char[1]"]]
eNFA155_22_45208163[["εNFA155-22 char{1, 1}"]]
eNFA155_23_4220283[\"εNFA155-23 char[1]"/]
eNFA155_25_37982554[\"εNFA155-25 regex end"/]
eNFA155_26_6298672[\"εNFA155-26 post-regex start"/]
eNFA155_27_56688054[\"εNFA155-27 post-regex end"/]
eNFA155_24_25933367 -.->|"ε"|eNFA155_0_32073719
eNFA155_24_25933367 -->|"i"|eNFA155_1_20228022
eNFA155_0_32073719 -->|"i"|eNFA155_1_20228022
eNFA155_1_20228022 -.->|"ε"|eNFA155_2_47834478
eNFA155_1_20228022 -->|"s"|eNFA155_3_27857118
eNFA155_2_47834478 -->|"s"|eNFA155_3_27857118
eNFA155_3_27857118 -.->|"ε"|eNFA155_4_49387472
eNFA155_3_27857118 -->|"a"|eNFA155_5_41834070
eNFA155_4_49387472 -->|"a"|eNFA155_5_41834070
eNFA155_5_41834070 -.->|"ε"|eNFA155_6_40962311
eNFA155_5_41834070 -->|"m"|eNFA155_7_33116486
eNFA155_6_40962311 -->|"m"|eNFA155_7_33116486
eNFA155_7_33116486 -.->|"ε"|eNFA155_8_29612923
eNFA155_7_33116486 -->|"p"|eNFA155_9_65189719
eNFA155_8_29612923 -->|"p"|eNFA155_9_65189719
eNFA155_9_65189719 -.->|"ε"|eNFA155_10_49836563
eNFA155_9_65189719 -->|"l"|eNFA155_11_45875888
eNFA155_10_49836563 -->|"l"|eNFA155_11_45875888
eNFA155_11_45875888 -.->|"ε"|eNFA155_12_10229816
eNFA155_11_45875888 -->|"e"|eNFA155_13_24959482
eNFA155_12_10229816 -->|"e"|eNFA155_13_24959482
eNFA155_13_24959482 -.->|"ε"|eNFA155_14_23308753
eNFA155_13_24959482 -->|"r"|eNFA155_15_8452189
eNFA155_14_23308753 -->|"r"|eNFA155_15_8452189
eNFA155_15_8452189 -.->|"ε"|eNFA155_16_8960839
eNFA155_15_8452189 -->|"2"|eNFA155_17_13538688
eNFA155_16_8960839 -->|"2"|eNFA155_17_13538688
eNFA155_17_13538688 -.->|"ε"|eNFA155_18_54739329
eNFA155_17_13538688 -->|"D"|eNFA155_19_22891915
eNFA155_18_54739329 -->|"D"|eNFA155_19_22891915
eNFA155_19_22891915 -.->|"ε"|eNFA155_20_4700647
eNFA155_19_22891915 -->|"M"|eNFA155_21_42305831
eNFA155_20_4700647 -->|"M"|eNFA155_21_42305831
eNFA155_21_42305831 -.->|"ε"|eNFA155_22_45208163
eNFA155_21_42305831 -->|"S"|eNFA155_23_4220283
eNFA155_22_45208163 -->|"S"|eNFA155_23_4220283
eNFA155_23_4220283 -.->|"ε"|eNFA155_25_37982554
eNFA155_23_4220283 -.->|"ε"|eNFA155_26_6298672
eNFA155_23_4220283 -.->|"ε"|eNFA155_27_56688054
eNFA155_25_37982554 -.->|"ε"|eNFA155_26_6298672
eNFA155_25_37982554 -.->|"ε"|eNFA155_27_56688054
eNFA155_26_6298672 -.->|"ε"|eNFA155_27_56688054
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
NFA155_24_40430446("NFA155-24 regex start")
NFA155_1_28329695("NFA155-1 char[1]")
NFA155_3_53640668("NFA155-3 char[1]")
NFA155_5_13003964("NFA155-5 char[1]")
NFA155_7_49926818("NFA155-7 char[1]")
NFA155_9_46688182("NFA155-9 char[1]")
NFA155_11_17540457("NFA155-11 char[1]")
NFA155_13_23646388("NFA155-13 char[1]")
NFA155_15_11490904("NFA155-15 char[1]")
NFA155_17_36309279("NFA155-17 char[1]")
NFA155_19_58348056("NFA155-19 char[1]")
NFA155_21_55370462("NFA155-21 char[1]")
NFA155_23_28572113[\"NFA155-23 char[1]"/]
NFA155_24_40430446 -->|"i"|NFA155_1_28329695
NFA155_1_28329695 -->|"s"|NFA155_3_53640668
NFA155_3_53640668 -->|"a"|NFA155_5_13003964
NFA155_5_13003964 -->|"m"|NFA155_7_49926818
NFA155_7_49926818 -->|"p"|NFA155_9_46688182
NFA155_9_46688182 -->|"l"|NFA155_11_17540457
NFA155_11_17540457 -->|"e"|NFA155_13_23646388
NFA155_13_23646388 -->|"r"|NFA155_15_11490904
NFA155_15_11490904 -->|"2"|NFA155_17_36309279
NFA155_17_36309279 -->|"D"|NFA155_19_58348056
NFA155_19_58348056 -->|"M"|NFA155_21_55370462
NFA155_21_55370462 -->|"S"|NFA155_23_28572113
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
subgraph DFA0_-890168422["DFA0 regex start"]
NFA155_24_40430446_0("NFA155-24 regex start")
end
subgraph DFA1_462431283["DFA1 {1}"]
NFA155_1_28329695_1("NFA155-1 char[1]")
end
subgraph DFA2_1184772515["DFA2 {1}"]
NFA155_3_53640668_2("NFA155-3 char[1]")
end
subgraph DFA3_1733458553["DFA3 {1}"]
NFA155_5_13003964_3("NFA155-5 char[1]")
end
subgraph DFA4_-617126721["DFA4 {1}"]
NFA155_7_49926818_4("NFA155-7 char[1]")
end
subgraph DFA5_1112623447["DFA5 {1}"]
NFA155_9_46688182_5("NFA155-9 char[1]")
end
subgraph DFA6_-885478072["DFA6 {1}"]
NFA155_11_17540457_6("NFA155-11 char[1]")
end
subgraph DFA7_460392737["DFA7 {1}"]
NFA155_13_23646388_7("NFA155-13 char[1]")
end
subgraph DFA8_-1190934777["DFA8 {1}"]
NFA155_15_11490904_8("NFA155-15 char[1]")
end
subgraph DFA9_1132730488["DFA9 {1}"]
NFA155_17_36309279_9("NFA155-17 char[1]")
end
subgraph DFA10_-1337167644["DFA10 {1}"]
NFA155_19_58348056_10("NFA155-19 char[1]")
end
subgraph DFA11_-547546654["DFA11 {1}"]
NFA155_21_55370462_11("NFA155-21 char[1]")
end
subgraph DFA12_903618397["DFA12 {1}"]
NFA155_23_28572113_12[\"NFA155-23 char[1]"/]
end
DFA0_-890168422 -->|"i"|DFA1_462431283
DFA1_462431283 -->|"s"|DFA2_1184772515
DFA2_1184772515 -->|"a"|DFA3_1733458553
DFA3_1733458553 -->|"m"|DFA4_-617126721
DFA4_-617126721 -->|"p"|DFA5_1112623447
DFA5_1112623447 -->|"l"|DFA6_-885478072
DFA6_-885478072 -->|"e"|DFA7_460392737
DFA7_460392737 -->|"r"|DFA8_-1190934777
DFA8_-1190934777 -->|"2"|DFA9_1132730488
DFA9_1132730488 -->|"D"|DFA10_-1337167644
DFA10_-1337167644 -->|"M"|DFA11_-547546654
DFA11_-547546654 -->|"S"|DFA12_903618397
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
DFA0_-890168422{{"DFA0 regex start"}}
DFA1_462431283{{"DFA1 {1}"}}
DFA2_1184772515{{"DFA2 {1}"}}
DFA3_1733458553{{"DFA3 {1}"}}
DFA4_-617126721{{"DFA4 {1}"}}
DFA5_1112623447{{"DFA5 {1}"}}
DFA6_-885478072{{"DFA6 {1}"}}
DFA7_460392737{{"DFA7 {1}"}}
DFA8_-1190934777{{"DFA8 {1}"}}
DFA9_1132730488{{"DFA9 {1}"}}
DFA10_-1337167644{{"DFA10 {1}"}}
DFA11_-547546654{{"DFA11 {1}"}}
DFA12_903618397[\"DFA12 {1}"/]
DFA0_-890168422 -->|"i"|DFA1_462431283
DFA1_462431283 -->|"s"|DFA2_1184772515
DFA2_1184772515 -->|"a"|DFA3_1733458553
DFA3_1733458553 -->|"m"|DFA4_-617126721
DFA4_-617126721 -->|"p"|DFA5_1112623447
DFA5_1112623447 -->|"l"|DFA6_-885478072
DFA6_-885478072 -->|"e"|DFA7_460392737
DFA7_460392737 -->|"r"|DFA8_-1190934777
DFA8_-1190934777 -->|"2"|DFA9_1132730488
DFA9_1132730488 -->|"D"|DFA10_-1337167644
DFA10_-1337167644 -->|"M"|DFA11_-547546654
DFA11_-547546654 -->|"S"|DFA12_903618397
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
subgraph MiniDFA0_-1457580575["MiniDFA0 {1}"]
DFA0_-890168422_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1300000122["MiniDFA1 {1}"]
DFA1_462431283_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1702005036["MiniDFA2 {1}"]
DFA2_1184772515_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-570851489["MiniDFA3 {1}"]
DFA3_1733458553_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_567228752["MiniDFA4 {1}"]
DFA4_-617126721_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_631549159["MiniDFA5 {1}"]
DFA5_1112623447_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_784153440["MiniDFA6 {1}"]
DFA6_-885478072_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1951524736["MiniDFA7 {1}"]
DFA7_460392737_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1851376195["MiniDFA8 {1}"]
DFA8_-1190934777_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-977410244["MiniDFA9 {1}"]
DFA9_1132730488_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_130512825["MiniDFA10 {1}"]
DFA10_-1337167644_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_307160978["MiniDFA11 {1}"]
DFA11_-547546654_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1205241661["MiniDFA12 {1}"]
DFA12_903618397_12[\"DFA12 {1}"/]
end
MiniDFA0_-1457580575 -->|"i"|MiniDFA1_-1300000122
MiniDFA1_-1300000122 -->|"s"|MiniDFA2_-1702005036
MiniDFA2_-1702005036 -->|"a"|MiniDFA3_-570851489
MiniDFA3_-570851489 -->|"m"|MiniDFA4_567228752
MiniDFA4_567228752 -->|"p"|MiniDFA5_631549159
MiniDFA5_631549159 -->|"l"|MiniDFA6_784153440
MiniDFA6_784153440 -->|"e"|MiniDFA7_-1951524736
MiniDFA7_-1951524736 -->|"r"|MiniDFA8_-1851376195
MiniDFA8_-1851376195 -->|"2"|MiniDFA9_-977410244
MiniDFA9_-977410244 -->|"D"|MiniDFA10_130512825
MiniDFA10_130512825 -->|"M"|MiniDFA11_307160978
MiniDFA11_307160978 -->|"S"|MiniDFA12_1205241661
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
MiniDFA0_-1457580575(["MiniDFA0 {1}"])
MiniDFA1_-1300000122(["MiniDFA1 {1}"])
MiniDFA2_-1702005036(["MiniDFA2 {1}"])
MiniDFA3_-570851489(["MiniDFA3 {1}"])
MiniDFA4_567228752(["MiniDFA4 {1}"])
MiniDFA5_631549159(["MiniDFA5 {1}"])
MiniDFA6_784153440(["MiniDFA6 {1}"])
MiniDFA7_-1951524736(["MiniDFA7 {1}"])
MiniDFA8_-1851376195(["MiniDFA8 {1}"])
MiniDFA9_-977410244(["MiniDFA9 {1}"])
MiniDFA10_130512825(["MiniDFA10 {1}"])
MiniDFA11_307160978(["MiniDFA11 {1}"])
MiniDFA12_1205241661[\"MiniDFA12 {1}"/]
MiniDFA0_-1457580575 -->|"i"|MiniDFA1_-1300000122
MiniDFA1_-1300000122 -->|"s"|MiniDFA2_-1702005036
MiniDFA2_-1702005036 -->|"a"|MiniDFA3_-570851489
MiniDFA3_-570851489 -->|"m"|MiniDFA4_567228752
MiniDFA4_567228752 -->|"p"|MiniDFA5_631549159
MiniDFA5_631549159 -->|"l"|MiniDFA6_784153440
MiniDFA6_784153440 -->|"e"|MiniDFA7_-1951524736
MiniDFA7_-1951524736 -->|"r"|MiniDFA8_-1851376195
MiniDFA8_-1851376195 -->|"2"|MiniDFA9_-977410244
MiniDFA9_-977410244 -->|"D"|MiniDFA10_130512825
MiniDFA10_130512825 -->|"M"|MiniDFA11_307160978
MiniDFA11_307160978 -->|"S"|MiniDFA12_1205241661
```
-------------------------------
