# 'iimage2DRect'

pattern: `iimage2DRect`

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
eNFA170_24_63206470[["εNFA170-24 regex start"]]
eNFA170_0_31987323[["εNFA170-0 char{1, 1}"]]
eNFA170_1_19450451[["εNFA170-1 char[1]"]]
eNFA170_2_40836337[["εNFA170-2 char{1, 1}"]]
eNFA170_3_31982717[["εNFA170-3 char[1]"]]
eNFA170_4_19409000[["εNFA170-4 char{1, 1}"]]
eNFA170_5_40463275[["εNFA170-5 char[1]"]]
eNFA170_6_28625159[["εNFA170-6 char{1, 1}"]]
eNFA170_7_56299846[["εNFA170-7 char[1]"]]
eNFA170_8_36936567[["εNFA170-8 char{1, 1}"]]
eNFA170_9_63993653[["εNFA170-9 char[1]"]]
eNFA170_10_39071968[["εNFA170-10 char{1, 1}"]]
eNFA170_11_16103393[["εNFA170-11 char[1]"]]
eNFA170_12_10712809[["εNFA170-12 char{1, 1}"]]
eNFA170_13_29306417[["εNFA170-13 char[1]"]]
eNFA170_14_62431162[["εNFA170-14 char{1, 1}"]]
eNFA170_15_25009549[["εNFA170-15 char[1]"]]
eNFA170_16_23759356[["εNFA170-16 char{1, 1}"]]
eNFA170_17_12507614[["εNFA170-17 char[1]"]]
eNFA170_18_45459670[["εNFA170-18 char{1, 1}"]]
eNFA170_19_6483852[["εNFA170-19 char[1]"]]
eNFA170_20_58354673[["εNFA170-20 char{1, 1}"]]
eNFA170_21_55430014[["εNFA170-21 char[1]"]]
eNFA170_22_29108085[["εNFA170-22 char{1, 1}"]]
eNFA170_23_60646173[["εNFA170-23 char[1]"]]
eNFA170_25_8944648[["εNFA170-25 regex end"]]
eNFA170_26_13392976[["εNFA170-26 post-regex start"]]
eNFA170_27_53427925[\"εNFA170-27 post-regex end"/]
eNFA170_24_63206470 -.->|"ε"|eNFA170_0_31987323
eNFA170_0_31987323 -->|"i"|eNFA170_1_19450451
eNFA170_1_19450451 -.->|"ε"|eNFA170_2_40836337
eNFA170_2_40836337 -->|"i"|eNFA170_3_31982717
eNFA170_3_31982717 -.->|"ε"|eNFA170_4_19409000
eNFA170_4_19409000 -->|"m"|eNFA170_5_40463275
eNFA170_5_40463275 -.->|"ε"|eNFA170_6_28625159
eNFA170_6_28625159 -->|"a"|eNFA170_7_56299846
eNFA170_7_56299846 -.->|"ε"|eNFA170_8_36936567
eNFA170_8_36936567 -->|"g"|eNFA170_9_63993653
eNFA170_9_63993653 -.->|"ε"|eNFA170_10_39071968
eNFA170_10_39071968 -->|"e"|eNFA170_11_16103393
eNFA170_11_16103393 -.->|"ε"|eNFA170_12_10712809
eNFA170_12_10712809 -->|"2"|eNFA170_13_29306417
eNFA170_13_29306417 -.->|"ε"|eNFA170_14_62431162
eNFA170_14_62431162 -->|"D"|eNFA170_15_25009549
eNFA170_15_25009549 -.->|"ε"|eNFA170_16_23759356
eNFA170_16_23759356 -->|"R"|eNFA170_17_12507614
eNFA170_17_12507614 -.->|"ε"|eNFA170_18_45459670
eNFA170_18_45459670 -->|"e"|eNFA170_19_6483852
eNFA170_19_6483852 -.->|"ε"|eNFA170_20_58354673
eNFA170_20_58354673 -->|"c"|eNFA170_21_55430014
eNFA170_21_55430014 -.->|"ε"|eNFA170_22_29108085
eNFA170_22_29108085 -->|"t"|eNFA170_23_60646173
eNFA170_23_60646173 -.->|"ε"|eNFA170_25_8944648
eNFA170_25_8944648 -.->|"ε"|eNFA170_26_13392976
eNFA170_26_13392976 -.->|"ε"|eNFA170_27_53427925
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
eNFA170_24_11089280[["εNFA170-24 regex start"]]
eNFA170_0_32694658[["εNFA170-0 char{1, 1}"]]
eNFA170_1_25816468[["εNFA170-1 char[1]"]]
eNFA170_2_31021623[["εNFA170-2 char{1, 1}"]]
eNFA170_3_10759157[["εNFA170-3 char[1]"]]
eNFA170_4_29723549[["εNFA170-4 char{1, 1}"]]
eNFA170_5_66185354[["εNFA170-5 char[1]"]]
eNFA170_6_58797275[["εNFA170-6 char{1, 1}"]]
eNFA170_7_59413435[["εNFA170-7 char[1]"]]
eNFA170_8_64958874[["εNFA170-8 char{1, 1}"]]
eNFA170_9_47758962[["εNFA170-9 char[1]"]]
eNFA170_10_27177474[["εNFA170-10 char{1, 1}"]]
eNFA170_11_43270676[["εNFA170-11 char[1]"]]
eNFA170_12_53891770[["εNFA170-12 char{1, 1}"]]
eNFA170_13_15263883[["εNFA170-13 char[1]"]]
eNFA170_14_3157226[["εNFA170-14 char{1, 1}"]]
eNFA170_15_28415039[["εNFA170-15 char[1]"]]
eNFA170_16_54408763[["εNFA170-16 char{1, 1}"]]
eNFA170_17_19916823[["εNFA170-17 char[1]"]]
eNFA170_18_45033684[["εNFA170-18 char{1, 1}"]]
eNFA170_19_2649980[["εNFA170-19 char[1]"]]
eNFA170_20_23849822[["εNFA170-20 char{1, 1}"]]
eNFA170_21_13321813[["εNFA170-21 char[1]"]]
eNFA170_22_52787457[["εNFA170-22 char{1, 1}"]]
eNFA170_23_5325067[\"εNFA170-23 char[1]"/]
eNFA170_25_47925604[\"εNFA170-25 regex end"/]
eNFA170_26_28677253[\"εNFA170-26 post-regex start"/]
eNFA170_27_56768687[\"εNFA170-27 post-regex end"/]
eNFA170_24_11089280 -.->|"ε"|eNFA170_0_32694658
eNFA170_24_11089280 -->|"i"|eNFA170_1_25816468
eNFA170_0_32694658 -->|"i"|eNFA170_1_25816468
eNFA170_1_25816468 -.->|"ε"|eNFA170_2_31021623
eNFA170_1_25816468 -->|"i"|eNFA170_3_10759157
eNFA170_2_31021623 -->|"i"|eNFA170_3_10759157
eNFA170_3_10759157 -.->|"ε"|eNFA170_4_29723549
eNFA170_3_10759157 -->|"m"|eNFA170_5_66185354
eNFA170_4_29723549 -->|"m"|eNFA170_5_66185354
eNFA170_5_66185354 -.->|"ε"|eNFA170_6_58797275
eNFA170_5_66185354 -->|"a"|eNFA170_7_59413435
eNFA170_6_58797275 -->|"a"|eNFA170_7_59413435
eNFA170_7_59413435 -.->|"ε"|eNFA170_8_64958874
eNFA170_7_59413435 -->|"g"|eNFA170_9_47758962
eNFA170_8_64958874 -->|"g"|eNFA170_9_47758962
eNFA170_9_47758962 -.->|"ε"|eNFA170_10_27177474
eNFA170_9_47758962 -->|"e"|eNFA170_11_43270676
eNFA170_10_27177474 -->|"e"|eNFA170_11_43270676
eNFA170_11_43270676 -.->|"ε"|eNFA170_12_53891770
eNFA170_11_43270676 -->|"2"|eNFA170_13_15263883
eNFA170_12_53891770 -->|"2"|eNFA170_13_15263883
eNFA170_13_15263883 -.->|"ε"|eNFA170_14_3157226
eNFA170_13_15263883 -->|"D"|eNFA170_15_28415039
eNFA170_14_3157226 -->|"D"|eNFA170_15_28415039
eNFA170_15_28415039 -.->|"ε"|eNFA170_16_54408763
eNFA170_15_28415039 -->|"R"|eNFA170_17_19916823
eNFA170_16_54408763 -->|"R"|eNFA170_17_19916823
eNFA170_17_19916823 -.->|"ε"|eNFA170_18_45033684
eNFA170_17_19916823 -->|"e"|eNFA170_19_2649980
eNFA170_18_45033684 -->|"e"|eNFA170_19_2649980
eNFA170_19_2649980 -.->|"ε"|eNFA170_20_23849822
eNFA170_19_2649980 -->|"c"|eNFA170_21_13321813
eNFA170_20_23849822 -->|"c"|eNFA170_21_13321813
eNFA170_21_13321813 -.->|"ε"|eNFA170_22_52787457
eNFA170_21_13321813 -->|"t"|eNFA170_23_5325067
eNFA170_22_52787457 -->|"t"|eNFA170_23_5325067
eNFA170_23_5325067 -.->|"ε"|eNFA170_25_47925604
eNFA170_23_5325067 -.->|"ε"|eNFA170_26_28677253
eNFA170_23_5325067 -.->|"ε"|eNFA170_27_56768687
eNFA170_25_47925604 -.->|"ε"|eNFA170_26_28677253
eNFA170_25_47925604 -.->|"ε"|eNFA170_27_56768687
eNFA170_26_28677253 -.->|"ε"|eNFA170_27_56768687
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
NFA170_24_41156139("NFA170-24 regex start")
NFA170_1_34860939("NFA170-1 char[1]")
NFA170_3_45312999("NFA170-3 char[1]")
NFA170_5_5163807("NFA170-5 char[1]")
NFA170_7_46474270("NFA170-7 char[1]")
NFA170_9_15615252("NFA170-9 char[1]")
NFA170_11_6319546("NFA170-11 char[1]")
NFA170_13_56875922("NFA170-13 char[1]")
NFA170_15_42121251("NFA170-15 char[1]")
NFA170_17_43546944("NFA170-17 char[1]")
NFA170_19_56378176("NFA170-19 char[1]")
NFA170_21_37641542("NFA170-21 char[1]")
NFA170_23_3229562[\"NFA170-23 char[1]"/]
NFA170_24_41156139 -->|"i"|NFA170_1_34860939
NFA170_1_34860939 -->|"i"|NFA170_3_45312999
NFA170_3_45312999 -->|"m"|NFA170_5_5163807
NFA170_5_5163807 -->|"a"|NFA170_7_46474270
NFA170_7_46474270 -->|"g"|NFA170_9_15615252
NFA170_9_15615252 -->|"e"|NFA170_11_6319546
NFA170_11_6319546 -->|"2"|NFA170_13_56875922
NFA170_13_56875922 -->|"D"|NFA170_15_42121251
NFA170_15_42121251 -->|"R"|NFA170_17_43546944
NFA170_17_43546944 -->|"e"|NFA170_19_56378176
NFA170_19_56378176 -->|"c"|NFA170_21_37641542
NFA170_21_37641542 -->|"t"|NFA170_23_3229562
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
subgraph DFA0_-708732393["DFA0 regex start"]
NFA170_24_41156139_0("NFA170-24 regex start")
end
subgraph DFA1_1784350216["DFA1 {1}"]
NFA170_1_34860939_1("NFA170-1 char[1]")
end
subgraph DFA2_-1027532163["DFA2 {1}"]
NFA170_3_45312999_2("NFA170-3 char[1]")
end
subgraph DFA3_-236613809["DFA3 {1}"]
NFA170_5_5163807_3("NFA170-5 char[1]")
end
subgraph DFA4_1816196368["DFA4 {1}"]
NFA170_7_46474270_4("NFA170-7 char[1]")
end
subgraph DFA5_-1167336114["DFA5 {1}"]
NFA170_9_15615252_5("NFA170-9 char[1]")
end
subgraph DFA6_1386270035["DFA6 {1}"]
NFA170_11_6319546_6("NFA170-11 char[1]")
end
subgraph DFA7_-54574557["DFA7 {1}"]
NFA170_13_56875922_7("NFA170-13 char[1]")
end
subgraph DFA8_1727949894["DFA8 {1}"]
NFA170_15_42121251_8("NFA170-15 char[1]")
end
subgraph DFA9_-1411434412["DFA9 {1}"]
NFA170_17_43546944_9("NFA170-17 char[1]")
end
subgraph DFA10_-1666465736["DFA10 {1}"]
NFA170_19_56378176_10("NFA170-19 char[1]")
end
subgraph DFA11_1870730749["DFA11 {1}"]
NFA170_21_37641542_11("NFA170-21 char[1]")
end
subgraph DFA12_1257430350["DFA12 {1}"]
NFA170_23_3229562_12[\"NFA170-23 char[1]"/]
end
DFA0_-708732393 -->|"i"|DFA1_1784350216
DFA1_1784350216 -->|"i"|DFA2_-1027532163
DFA2_-1027532163 -->|"m"|DFA3_-236613809
DFA3_-236613809 -->|"a"|DFA4_1816196368
DFA4_1816196368 -->|"g"|DFA5_-1167336114
DFA5_-1167336114 -->|"e"|DFA6_1386270035
DFA6_1386270035 -->|"2"|DFA7_-54574557
DFA7_-54574557 -->|"D"|DFA8_1727949894
DFA8_1727949894 -->|"R"|DFA9_-1411434412
DFA9_-1411434412 -->|"e"|DFA10_-1666465736
DFA10_-1666465736 -->|"c"|DFA11_1870730749
DFA11_1870730749 -->|"t"|DFA12_1257430350
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
DFA0_-708732393{{"DFA0 regex start"}}
DFA1_1784350216{{"DFA1 {1}"}}
DFA2_-1027532163{{"DFA2 {1}"}}
DFA3_-236613809{{"DFA3 {1}"}}
DFA4_1816196368{{"DFA4 {1}"}}
DFA5_-1167336114{{"DFA5 {1}"}}
DFA6_1386270035{{"DFA6 {1}"}}
DFA7_-54574557{{"DFA7 {1}"}}
DFA8_1727949894{{"DFA8 {1}"}}
DFA9_-1411434412{{"DFA9 {1}"}}
DFA10_-1666465736{{"DFA10 {1}"}}
DFA11_1870730749{{"DFA11 {1}"}}
DFA12_1257430350[\"DFA12 {1}"/]
DFA0_-708732393 -->|"i"|DFA1_1784350216
DFA1_1784350216 -->|"i"|DFA2_-1027532163
DFA2_-1027532163 -->|"m"|DFA3_-236613809
DFA3_-236613809 -->|"a"|DFA4_1816196368
DFA4_1816196368 -->|"g"|DFA5_-1167336114
DFA5_-1167336114 -->|"e"|DFA6_1386270035
DFA6_1386270035 -->|"2"|DFA7_-54574557
DFA7_-54574557 -->|"D"|DFA8_1727949894
DFA8_1727949894 -->|"R"|DFA9_-1411434412
DFA9_-1411434412 -->|"e"|DFA10_-1666465736
DFA10_-1666465736 -->|"c"|DFA11_1870730749
DFA11_1870730749 -->|"t"|DFA12_1257430350
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
subgraph MiniDFA0_-1023531079["MiniDFA0 {1}"]
DFA0_-708732393_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1802472119["MiniDFA1 {1}"]
DFA1_1784350216_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_672525628["MiniDFA2 {1}"]
DFA2_-1027532163_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1476102480["MiniDFA3 {1}"]
DFA3_-236613809_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-196073261["MiniDFA4 {1}"]
DFA4_1816196368_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_2118709824["MiniDFA5 {1}"]
DFA5_-1167336114_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1043526713["MiniDFA7 {1}"]
DFA6_1386270035_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-290648040["MiniDFA8 {1}"]
DFA7_-54574557_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-633482133["MiniDFA9 {1}"]
DFA8_1727949894_8{{"DFA8 {1}"}}
end
subgraph MiniDFA6_148832447["MiniDFA6 {1}"]
DFA9_-1411434412_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1795726615["MiniDFA10 {1}"]
DFA10_-1666465736_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-1008585360["MiniDFA11 {1}"]
DFA11_1870730749_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1296897494["MiniDFA12 {1}"]
DFA12_1257430350_12[\"DFA12 {1}"/]
end
MiniDFA0_-1023531079 -->|"i"|MiniDFA1_-1802472119
MiniDFA1_-1802472119 -->|"i"|MiniDFA2_672525628
MiniDFA2_672525628 -->|"m"|MiniDFA3_1476102480
MiniDFA3_1476102480 -->|"a"|MiniDFA4_-196073261
MiniDFA4_-196073261 -->|"g"|MiniDFA5_2118709824
MiniDFA5_2118709824 -->|"e"|MiniDFA7_-1043526713
MiniDFA7_-1043526713 -->|"2"|MiniDFA8_-290648040
MiniDFA8_-290648040 -->|"D"|MiniDFA9_-633482133
MiniDFA9_-633482133 -->|"R"|MiniDFA6_148832447
MiniDFA6_148832447 -->|"e"|MiniDFA10_-1795726615
MiniDFA10_-1795726615 -->|"c"|MiniDFA11_-1008585360
MiniDFA11_-1008585360 -->|"t"|MiniDFA12_1296897494
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
MiniDFA0_-1023531079(["MiniDFA0 {1}"])
MiniDFA1_-1802472119(["MiniDFA1 {1}"])
MiniDFA2_672525628(["MiniDFA2 {1}"])
MiniDFA3_1476102480(["MiniDFA3 {1}"])
MiniDFA4_-196073261(["MiniDFA4 {1}"])
MiniDFA5_2118709824(["MiniDFA5 {1}"])
MiniDFA7_-1043526713(["MiniDFA7 {1}"])
MiniDFA8_-290648040(["MiniDFA8 {1}"])
MiniDFA9_-633482133(["MiniDFA9 {1}"])
MiniDFA6_148832447(["MiniDFA6 {1}"])
MiniDFA10_-1795726615(["MiniDFA10 {1}"])
MiniDFA11_-1008585360(["MiniDFA11 {1}"])
MiniDFA12_1296897494[\"MiniDFA12 {1}"/]
MiniDFA0_-1023531079 -->|"i"|MiniDFA1_-1802472119
MiniDFA1_-1802472119 -->|"i"|MiniDFA2_672525628
MiniDFA2_672525628 -->|"m"|MiniDFA3_1476102480
MiniDFA3_1476102480 -->|"a"|MiniDFA4_-196073261
MiniDFA4_-196073261 -->|"g"|MiniDFA5_2118709824
MiniDFA5_2118709824 -->|"e"|MiniDFA7_-1043526713
MiniDFA7_-1043526713 -->|"2"|MiniDFA8_-290648040
MiniDFA8_-290648040 -->|"D"|MiniDFA9_-633482133
MiniDFA9_-633482133 -->|"R"|MiniDFA6_148832447
MiniDFA6_148832447 -->|"e"|MiniDFA10_-1795726615
MiniDFA10_-1795726615 -->|"c"|MiniDFA11_-1008585360
MiniDFA11_-1008585360 -->|"t"|MiniDFA12_1296897494
```
-------------------------------
