# 'sampler1DShadow'

pattern: `sampler1DShadow`

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
eNFA124_30_44576811[["εNFA124-30 regex start"]]
eNFA124_0_65646981[["εNFA124-0 char{1, 1}"]]
eNFA124_1_53951920[["εNFA124-1 char[1]"]]
eNFA124_2_15805238[["εNFA124-2 char{1, 1}"]]
eNFA124_3_8029414[["εNFA124-3 char[1]"]]
eNFA124_4_5155867[["εNFA124-4 char{1, 1}"]]
eNFA124_5_46402804[["εNFA124-5 char[1]"]]
eNFA124_6_14972060[["εNFA124-6 char{1, 1}"]]
eNFA124_7_530819[["εNFA124-7 char[1]"]]
eNFA124_8_4777379[["εNFA124-8 char{1, 1}"]]
eNFA124_9_42996411[["εNFA124-9 char[1]"]]
eNFA124_10_51423381[["εNFA124-10 char{1, 1}"]]
eNFA124_11_60157251[["εNFA124-11 char[1]"]]
eNFA124_12_4544348[["εNFA124-12 char{1, 1}"]]
eNFA124_13_40899139[["εNFA124-13 char[1]"]]
eNFA124_14_32547936[["εNFA124-14 char{1, 1}"]]
eNFA124_15_24495972[["εNFA124-15 char[1]"]]
eNFA124_16_19137160[["εNFA124-16 char{1, 1}"]]
eNFA124_17_38016717[["εNFA124-17 char[1]"]]
eNFA124_18_6606141[["εNFA124-18 char{1, 1}"]]
eNFA124_19_59455271[["εNFA124-19 char[1]"]]
eNFA124_20_65335398[["εNFA124-20 char{1, 1}"]]
eNFA124_21_51147674[["εNFA124-21 char[1]"]]
eNFA124_22_57675884[["εNFA124-22 char{1, 1}"]]
eNFA124_23_49320909[["εNFA124-23 char[1]"]]
eNFA124_24_41234998[["εNFA124-24 char{1, 1}"]]
eNFA124_25_35570664[["εNFA124-25 char[1]"]]
eNFA124_26_51700524[["εNFA124-26 char{1, 1}"]]
eNFA124_27_62651540[["εNFA124-27 char[1]"]]
eNFA124_28_26992952[["εNFA124-28 char{1, 1}"]]
eNFA124_29_41609976[["εNFA124-29 char[1]"]]
eNFA124_31_38945471[["εNFA124-31 regex end"]]
eNFA124_32_14964925[["εNFA124-32 post-regex start"]]
eNFA124_33_466603[\"εNFA124-33 post-regex end"/]
eNFA124_30_44576811 -.->|"ε"|eNFA124_0_65646981
eNFA124_0_65646981 -->|"s"|eNFA124_1_53951920
eNFA124_1_53951920 -.->|"ε"|eNFA124_2_15805238
eNFA124_2_15805238 -->|"a"|eNFA124_3_8029414
eNFA124_3_8029414 -.->|"ε"|eNFA124_4_5155867
eNFA124_4_5155867 -->|"m"|eNFA124_5_46402804
eNFA124_5_46402804 -.->|"ε"|eNFA124_6_14972060
eNFA124_6_14972060 -->|"p"|eNFA124_7_530819
eNFA124_7_530819 -.->|"ε"|eNFA124_8_4777379
eNFA124_8_4777379 -->|"l"|eNFA124_9_42996411
eNFA124_9_42996411 -.->|"ε"|eNFA124_10_51423381
eNFA124_10_51423381 -->|"e"|eNFA124_11_60157251
eNFA124_11_60157251 -.->|"ε"|eNFA124_12_4544348
eNFA124_12_4544348 -->|"r"|eNFA124_13_40899139
eNFA124_13_40899139 -.->|"ε"|eNFA124_14_32547936
eNFA124_14_32547936 -->|"1"|eNFA124_15_24495972
eNFA124_15_24495972 -.->|"ε"|eNFA124_16_19137160
eNFA124_16_19137160 -->|"D"|eNFA124_17_38016717
eNFA124_17_38016717 -.->|"ε"|eNFA124_18_6606141
eNFA124_18_6606141 -->|"S"|eNFA124_19_59455271
eNFA124_19_59455271 -.->|"ε"|eNFA124_20_65335398
eNFA124_20_65335398 -->|"h"|eNFA124_21_51147674
eNFA124_21_51147674 -.->|"ε"|eNFA124_22_57675884
eNFA124_22_57675884 -->|"a"|eNFA124_23_49320909
eNFA124_23_49320909 -.->|"ε"|eNFA124_24_41234998
eNFA124_24_41234998 -->|"d"|eNFA124_25_35570664
eNFA124_25_35570664 -.->|"ε"|eNFA124_26_51700524
eNFA124_26_51700524 -->|"o"|eNFA124_27_62651540
eNFA124_27_62651540 -.->|"ε"|eNFA124_28_26992952
eNFA124_28_26992952 -->|"w"|eNFA124_29_41609976
eNFA124_29_41609976 -.->|"ε"|eNFA124_31_38945471
eNFA124_31_38945471 -.->|"ε"|eNFA124_32_14964925
eNFA124_32_14964925 -.->|"ε"|eNFA124_33_466603
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
eNFA124_30_4199435[["εNFA124-30 regex start"]]
eNFA124_0_37794916[["εNFA124-0 char{1, 1}"]]
eNFA124_1_4609929[["εNFA124-1 char[1]"]]
eNFA124_2_41489361[["εNFA124-2 char{1, 1}"]]
eNFA124_3_37859935[["εNFA124-3 char[1]"]]
eNFA124_4_5195099[["εNFA124-4 char{1, 1}"]]
eNFA124_5_46755894[["εNFA124-5 char[1]"]]
eNFA124_6_18149865[["εNFA124-6 char{1, 1}"]]
eNFA124_7_29131061[["εNFA124-7 char[1]"]]
eNFA124_8_60852964[["εNFA124-8 char{1, 1}"]]
eNFA124_9_10805765[["εNFA124-9 char[1]"]]
eNFA124_10_30143027[["εNFA124-10 char{1, 1}"]]
eNFA124_11_2851790[["εNFA124-11 char[1]"]]
eNFA124_12_25666111[["εNFA124-12 char{1, 1}"]]
eNFA124_13_29668407[["εNFA124-13 char[1]"]]
eNFA124_14_65689071[["εNFA124-14 char{1, 1}"]]
eNFA124_15_54330728[["εNFA124-15 char[1]"]]
eNFA124_16_19214507[["εNFA124-16 char{1, 1}"]]
eNFA124_17_38712842[["εNFA124-17 char[1]"]]
eNFA124_18_12871260[["εNFA124-18 char{1, 1}"]]
eNFA124_19_48732484[["εNFA124-19 char[1]"]]
eNFA124_20_35939178[["εNFA124-20 char{1, 1}"]]
eNFA124_21_55017151[["εNFA124-21 char[1]"]]
eNFA124_22_25392316[["εNFA124-22 char{1, 1}"]]
eNFA124_23_27204259[["εNFA124-23 char[1]"]]
eNFA124_24_43511739[["εNFA124-24 char{1, 1}"]]
eNFA124_25_56061334[["εNFA124-25 char[1]"]]
eNFA124_26_34789966[["εNFA124-26 char{1, 1}"]]
eNFA124_27_44674243[["εNFA124-27 char[1]"]]
eNFA124_28_66523870[["εNFA124-28 char{1, 1}"]]
eNFA124_29_61843920[\"εNFA124-29 char[1]"/]
eNFA124_31_19724370[\"εNFA124-31 regex end"/]
eNFA124_32_43301605[\"εNFA124-32 post-regex start"/]
eNFA124_33_54170131[\"εNFA124-33 post-regex end"/]
eNFA124_30_4199435 -.->|"ε"|eNFA124_0_37794916
eNFA124_30_4199435 -->|"s"|eNFA124_1_4609929
eNFA124_0_37794916 -->|"s"|eNFA124_1_4609929
eNFA124_1_4609929 -.->|"ε"|eNFA124_2_41489361
eNFA124_1_4609929 -->|"a"|eNFA124_3_37859935
eNFA124_2_41489361 -->|"a"|eNFA124_3_37859935
eNFA124_3_37859935 -.->|"ε"|eNFA124_4_5195099
eNFA124_3_37859935 -->|"m"|eNFA124_5_46755894
eNFA124_4_5195099 -->|"m"|eNFA124_5_46755894
eNFA124_5_46755894 -.->|"ε"|eNFA124_6_18149865
eNFA124_5_46755894 -->|"p"|eNFA124_7_29131061
eNFA124_6_18149865 -->|"p"|eNFA124_7_29131061
eNFA124_7_29131061 -.->|"ε"|eNFA124_8_60852964
eNFA124_7_29131061 -->|"l"|eNFA124_9_10805765
eNFA124_8_60852964 -->|"l"|eNFA124_9_10805765
eNFA124_9_10805765 -.->|"ε"|eNFA124_10_30143027
eNFA124_9_10805765 -->|"e"|eNFA124_11_2851790
eNFA124_10_30143027 -->|"e"|eNFA124_11_2851790
eNFA124_11_2851790 -.->|"ε"|eNFA124_12_25666111
eNFA124_11_2851790 -->|"r"|eNFA124_13_29668407
eNFA124_12_25666111 -->|"r"|eNFA124_13_29668407
eNFA124_13_29668407 -.->|"ε"|eNFA124_14_65689071
eNFA124_13_29668407 -->|"1"|eNFA124_15_54330728
eNFA124_14_65689071 -->|"1"|eNFA124_15_54330728
eNFA124_15_54330728 -.->|"ε"|eNFA124_16_19214507
eNFA124_15_54330728 -->|"D"|eNFA124_17_38712842
eNFA124_16_19214507 -->|"D"|eNFA124_17_38712842
eNFA124_17_38712842 -.->|"ε"|eNFA124_18_12871260
eNFA124_17_38712842 -->|"S"|eNFA124_19_48732484
eNFA124_18_12871260 -->|"S"|eNFA124_19_48732484
eNFA124_19_48732484 -.->|"ε"|eNFA124_20_35939178
eNFA124_19_48732484 -->|"h"|eNFA124_21_55017151
eNFA124_20_35939178 -->|"h"|eNFA124_21_55017151
eNFA124_21_55017151 -.->|"ε"|eNFA124_22_25392316
eNFA124_21_55017151 -->|"a"|eNFA124_23_27204259
eNFA124_22_25392316 -->|"a"|eNFA124_23_27204259
eNFA124_23_27204259 -.->|"ε"|eNFA124_24_43511739
eNFA124_23_27204259 -->|"d"|eNFA124_25_56061334
eNFA124_24_43511739 -->|"d"|eNFA124_25_56061334
eNFA124_25_56061334 -.->|"ε"|eNFA124_26_34789966
eNFA124_25_56061334 -->|"o"|eNFA124_27_44674243
eNFA124_26_34789966 -->|"o"|eNFA124_27_44674243
eNFA124_27_44674243 -.->|"ε"|eNFA124_28_66523870
eNFA124_27_44674243 -->|"w"|eNFA124_29_61843920
eNFA124_28_66523870 -->|"w"|eNFA124_29_61843920
eNFA124_29_61843920 -.->|"ε"|eNFA124_31_19724370
eNFA124_29_61843920 -.->|"ε"|eNFA124_32_43301605
eNFA124_29_61843920 -.->|"ε"|eNFA124_33_54170131
eNFA124_31_19724370 -.->|"ε"|eNFA124_32_43301605
eNFA124_31_19724370 -.->|"ε"|eNFA124_33_54170131
eNFA124_32_43301605 -.->|"ε"|eNFA124_33_54170131
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
NFA124_30_17769131("NFA124-30 regex start")
NFA124_1_25704456("NFA124-1 char[1]")
NFA124_3_30013513("NFA124-3 char[1]")
NFA124_5_1686169("NFA124-5 char[1]")
NFA124_7_15175528("NFA124-7 char[1]")
NFA124_9_2362032("NFA124-9 char[1]")
NFA124_11_21258288("NFA124-11 char[1]")
NFA124_13_57106866("NFA124-13 char[1]")
NFA124_15_44199752("NFA124-15 char[1]")
NFA124_17_62253449("NFA124-17 char[1]")
NFA124_19_23410136("NFA124-19 char[1]")
NFA124_21_9364637("NFA124-21 char[1]")
NFA124_23_17172873("NFA124-23 char[1]")
NFA124_25_20338133("NFA124-25 char[1]")
NFA124_27_48825474("NFA124-27 char[1]")
NFA124_29_36776090[\"NFA124-29 char[1]"/]
NFA124_30_17769131 -->|"s"|NFA124_1_25704456
NFA124_1_25704456 -->|"a"|NFA124_3_30013513
NFA124_3_30013513 -->|"m"|NFA124_5_1686169
NFA124_5_1686169 -->|"p"|NFA124_7_15175528
NFA124_7_15175528 -->|"l"|NFA124_9_2362032
NFA124_9_2362032 -->|"e"|NFA124_11_21258288
NFA124_11_21258288 -->|"r"|NFA124_13_57106866
NFA124_13_57106866 -->|"1"|NFA124_15_44199752
NFA124_15_44199752 -->|"D"|NFA124_17_62253449
NFA124_17_62253449 -->|"S"|NFA124_19_23410136
NFA124_19_23410136 -->|"h"|NFA124_21_9364637
NFA124_21_9364637 -->|"a"|NFA124_23_17172873
NFA124_23_17172873 -->|"d"|NFA124_25_20338133
NFA124_25_20338133 -->|"o"|NFA124_27_48825474
NFA124_27_48825474 -->|"w"|NFA124_29_36776090
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
subgraph DFA0_-1779360156["DFA0 regex start"]
NFA124_30_17769131_0("NFA124-30 regex start")
end
subgraph DFA1_1149251241["DFA1 {1}"]
NFA124_1_25704456_1("NFA124-1 char[1]")
end
subgraph DFA2_1236089109["DFA2 {1}"]
NFA124_3_30013513_2("NFA124-3 char[1]")
end
subgraph DFA3_326592["DFA3 {1}"]
NFA124_5_1686169_3("NFA124-5 char[1]")
end
subgraph DFA4_-1328536412["DFA4 {1}"]
NFA124_7_15175528_4("NFA124-7 char[1]")
end
subgraph DFA5_-86567115["DFA5 {1}"]
NFA124_9_2362032_5("NFA124-9 char[1]")
end
subgraph DFA6_-150343555["DFA6 {1}"]
NFA124_11_21258288_6("NFA124-11 char[1]")
end
subgraph DFA7_-1259190518["DFA7 {1}"]
NFA124_13_57106866_7("NFA124-13 char[1]")
end
subgraph DFA8_1003836608["DFA8 {1}"]
NFA124_15_44199752_8("NFA124-15 char[1]")
end
subgraph DFA9_1673153364["DFA9 {1}"]
NFA124_17_62253449_9("NFA124-17 char[1]")
end
subgraph DFA10_1188606898["DFA10 {1}"]
NFA124_19_23410136_10("NFA124-19 char[1]")
end
subgraph DFA11_234147187["DFA11 {1}"]
NFA124_21_9364637_11("NFA124-21 char[1]")
end
subgraph DFA12_-919187142["DFA12 {1}"]
NFA124_23_17172873_12("NFA124-23 char[1]")
end
subgraph DFA13_430000649["DFA13 {1}"]
NFA124_25_20338133_13("NFA124-25 char[1]")
end
subgraph DFA14_45978559["DFA14 {1}"]
NFA124_27_48825474_14("NFA124-27 char[1]")
end
subgraph DFA15_-1515918017["DFA15 {1}"]
NFA124_29_36776090_15[\"NFA124-29 char[1]"/]
end
DFA0_-1779360156 -->|"s"|DFA1_1149251241
DFA1_1149251241 -->|"a"|DFA2_1236089109
DFA2_1236089109 -->|"m"|DFA3_326592
DFA3_326592 -->|"p"|DFA4_-1328536412
DFA4_-1328536412 -->|"l"|DFA5_-86567115
DFA5_-86567115 -->|"e"|DFA6_-150343555
DFA6_-150343555 -->|"r"|DFA7_-1259190518
DFA7_-1259190518 -->|"1"|DFA8_1003836608
DFA8_1003836608 -->|"D"|DFA9_1673153364
DFA9_1673153364 -->|"S"|DFA10_1188606898
DFA10_1188606898 -->|"h"|DFA11_234147187
DFA11_234147187 -->|"a"|DFA12_-919187142
DFA12_-919187142 -->|"d"|DFA13_430000649
DFA13_430000649 -->|"o"|DFA14_45978559
DFA14_45978559 -->|"w"|DFA15_-1515918017
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
DFA0_-1779360156{{"DFA0 regex start"}}
DFA1_1149251241{{"DFA1 {1}"}}
DFA2_1236089109{{"DFA2 {1}"}}
DFA3_326592{{"DFA3 {1}"}}
DFA4_-1328536412{{"DFA4 {1}"}}
DFA5_-86567115{{"DFA5 {1}"}}
DFA6_-150343555{{"DFA6 {1}"}}
DFA7_-1259190518{{"DFA7 {1}"}}
DFA8_1003836608{{"DFA8 {1}"}}
DFA9_1673153364{{"DFA9 {1}"}}
DFA10_1188606898{{"DFA10 {1}"}}
DFA11_234147187{{"DFA11 {1}"}}
DFA12_-919187142{{"DFA12 {1}"}}
DFA13_430000649{{"DFA13 {1}"}}
DFA14_45978559{{"DFA14 {1}"}}
DFA15_-1515918017[\"DFA15 {1}"/]
DFA0_-1779360156 -->|"s"|DFA1_1149251241
DFA1_1149251241 -->|"a"|DFA2_1236089109
DFA2_1236089109 -->|"m"|DFA3_326592
DFA3_326592 -->|"p"|DFA4_-1328536412
DFA4_-1328536412 -->|"l"|DFA5_-86567115
DFA5_-86567115 -->|"e"|DFA6_-150343555
DFA6_-150343555 -->|"r"|DFA7_-1259190518
DFA7_-1259190518 -->|"1"|DFA8_1003836608
DFA8_1003836608 -->|"D"|DFA9_1673153364
DFA9_1673153364 -->|"S"|DFA10_1188606898
DFA10_1188606898 -->|"h"|DFA11_234147187
DFA11_234147187 -->|"a"|DFA12_-919187142
DFA12_-919187142 -->|"d"|DFA13_430000649
DFA13_430000649 -->|"o"|DFA14_45978559
DFA14_45978559 -->|"w"|DFA15_-1515918017
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
subgraph MiniDFA0_1578788314["MiniDFA0 {1}"]
DFA0_-1779360156_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1715769684["MiniDFA1 {1}"]
DFA1_1149251241_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_1440181205["MiniDFA3 {1}"]
DFA2_1236089109_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_957204240["MiniDFA4 {1}"]
DFA3_326592_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_670813166["MiniDFA5 {1}"]
DFA4_-1328536412_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-279507846["MiniDFA6 {1}"]
DFA5_-86567115_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_217331311["MiniDFA7 {1}"]
DFA6_-150343555_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1276100989["MiniDFA8 {1}"]
DFA7_-1259190518_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-2012722726["MiniDFA9 {1}"]
DFA8_1003836608_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-137811558["MiniDFA10 {1}"]
DFA9_1673153364_9{{"DFA9 {1}"}}
end
subgraph MiniDFA11_1396612339["MiniDFA11 {1}"]
DFA10_1188606898_10{{"DFA10 {1}"}}
end
subgraph MiniDFA2_509571760["MiniDFA2 {1}"]
DFA11_234147187_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-2086721574["MiniDFA12 {1}"]
DFA12_-919187142_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1211422020["MiniDFA13 {1}"]
DFA13_430000649_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_590924447["MiniDFA14 {1}"]
DFA14_45978559_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_-189678870["MiniDFA15 {1}"]
DFA15_-1515918017_15[\"DFA15 {1}"/]
end
MiniDFA0_1578788314 -->|"s"|MiniDFA1_-1715769684
MiniDFA1_-1715769684 -->|"a"|MiniDFA3_1440181205
MiniDFA3_1440181205 -->|"m"|MiniDFA4_957204240
MiniDFA4_957204240 -->|"p"|MiniDFA5_670813166
MiniDFA5_670813166 -->|"l"|MiniDFA6_-279507846
MiniDFA6_-279507846 -->|"e"|MiniDFA7_217331311
MiniDFA7_217331311 -->|"r"|MiniDFA8_-1276100989
MiniDFA8_-1276100989 -->|"1"|MiniDFA9_-2012722726
MiniDFA9_-2012722726 -->|"D"|MiniDFA10_-137811558
MiniDFA10_-137811558 -->|"S"|MiniDFA11_1396612339
MiniDFA11_1396612339 -->|"h"|MiniDFA2_509571760
MiniDFA2_509571760 -->|"a"|MiniDFA12_-2086721574
MiniDFA12_-2086721574 -->|"d"|MiniDFA13_-1211422020
MiniDFA13_-1211422020 -->|"o"|MiniDFA14_590924447
MiniDFA14_590924447 -->|"w"|MiniDFA15_-189678870
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
MiniDFA0_1578788314(["MiniDFA0 {1}"])
MiniDFA1_-1715769684(["MiniDFA1 {1}"])
MiniDFA3_1440181205(["MiniDFA3 {1}"])
MiniDFA4_957204240(["MiniDFA4 {1}"])
MiniDFA5_670813166(["MiniDFA5 {1}"])
MiniDFA6_-279507846(["MiniDFA6 {1}"])
MiniDFA7_217331311(["MiniDFA7 {1}"])
MiniDFA8_-1276100989(["MiniDFA8 {1}"])
MiniDFA9_-2012722726(["MiniDFA9 {1}"])
MiniDFA10_-137811558(["MiniDFA10 {1}"])
MiniDFA11_1396612339(["MiniDFA11 {1}"])
MiniDFA2_509571760(["MiniDFA2 {1}"])
MiniDFA12_-2086721574(["MiniDFA12 {1}"])
MiniDFA13_-1211422020(["MiniDFA13 {1}"])
MiniDFA14_590924447(["MiniDFA14 {1}"])
MiniDFA15_-189678870[\"MiniDFA15 {1}"/]
MiniDFA0_1578788314 -->|"s"|MiniDFA1_-1715769684
MiniDFA1_-1715769684 -->|"a"|MiniDFA3_1440181205
MiniDFA3_1440181205 -->|"m"|MiniDFA4_957204240
MiniDFA4_957204240 -->|"p"|MiniDFA5_670813166
MiniDFA5_670813166 -->|"l"|MiniDFA6_-279507846
MiniDFA6_-279507846 -->|"e"|MiniDFA7_217331311
MiniDFA7_217331311 -->|"r"|MiniDFA8_-1276100989
MiniDFA8_-1276100989 -->|"1"|MiniDFA9_-2012722726
MiniDFA9_-2012722726 -->|"D"|MiniDFA10_-137811558
MiniDFA10_-137811558 -->|"S"|MiniDFA11_1396612339
MiniDFA11_1396612339 -->|"h"|MiniDFA2_509571760
MiniDFA2_509571760 -->|"a"|MiniDFA12_-2086721574
MiniDFA12_-2086721574 -->|"d"|MiniDFA13_-1211422020
MiniDFA13_-1211422020 -->|"o"|MiniDFA14_590924447
MiniDFA14_590924447 -->|"w"|MiniDFA15_-189678870
```
-------------------------------
