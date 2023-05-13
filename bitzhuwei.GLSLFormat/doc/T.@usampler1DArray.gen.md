# 'usampler1DArray'

pattern: `usampler1DArray`

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
eNFA144_30_42941906[["εNFA144-30 regex start"]]
eNFA144_0_50932842[["εNFA144-0 char{1, 1}"]]
eNFA144_1_55742394[["εNFA144-1 char[1]"]]
eNFA144_2_31919500[["εNFA144-2 char{1, 1}"]]
eNFA144_3_18840050[["εNFA144-3 char[1]"]]
eNFA144_4_35342723[["εNFA144-4 char{1, 1}"]]
eNFA144_5_49649058[["εNFA144-5 char[1]"]]
eNFA144_6_44188343[["εNFA144-6 char{1, 1}"]]
eNFA144_7_62150771[["εNFA144-7 char[1]"]]
eNFA144_8_22486031[["εNFA144-8 char{1, 1}"]]
eNFA144_9_1047692[["εNFA144-9 char[1]"]]
eNFA144_10_9429236[["εNFA144-10 char{1, 1}"]]
eNFA144_11_17754262[["εNFA144-11 char[1]"]]
eNFA144_12_25570637[["εNFA144-12 char{1, 1}"]]
eNFA144_13_28809145[["εNFA144-13 char[1]"]]
eNFA144_14_57955715[["εNFA144-14 char{1, 1}"]]
eNFA144_15_51839388[["εNFA144-15 char[1]"]]
eNFA144_16_63901309[["εNFA144-16 char{1, 1}"]]
eNFA144_17_38240871[["εNFA144-17 char[1]"]]
eNFA144_18_8623523[["εNFA144-18 char{1, 1}"]]
eNFA144_19_10502851[["εNFA144-19 char[1]"]]
eNFA144_20_27416799[["εNFA144-20 char{1, 1}"]]
eNFA144_21_45424599[["εNFA144-21 char[1]"]]
eNFA144_22_6168214[["εNFA144-22 char{1, 1}"]]
eNFA144_23_55513932[["εNFA144-23 char[1]"]]
eNFA144_24_29863346[["εNFA144-24 char{1, 1}"]]
eNFA144_25_334666[["εNFA144-25 char[1]"]]
eNFA144_26_3011995[["εNFA144-26 char{1, 1}"]]
eNFA144_27_27107960[["εNFA144-27 char[1]"]]
eNFA144_28_42645048[["εNFA144-28 char{1, 1}"]]
eNFA144_29_48261118[["εNFA144-29 char[1]"]]
eNFA144_31_31696882[["εNFA144-31 regex end"]]
eNFA144_32_16836485[["εNFA144-32 post-regex start"]]
eNFA144_33_17310640[\"εNFA144-33 post-regex end"/]
eNFA144_30_42941906 -.->|"ε"|eNFA144_0_50932842
eNFA144_0_50932842 -->|"u"|eNFA144_1_55742394
eNFA144_1_55742394 -.->|"ε"|eNFA144_2_31919500
eNFA144_2_31919500 -->|"s"|eNFA144_3_18840050
eNFA144_3_18840050 -.->|"ε"|eNFA144_4_35342723
eNFA144_4_35342723 -->|"a"|eNFA144_5_49649058
eNFA144_5_49649058 -.->|"ε"|eNFA144_6_44188343
eNFA144_6_44188343 -->|"m"|eNFA144_7_62150771
eNFA144_7_62150771 -.->|"ε"|eNFA144_8_22486031
eNFA144_8_22486031 -->|"p"|eNFA144_9_1047692
eNFA144_9_1047692 -.->|"ε"|eNFA144_10_9429236
eNFA144_10_9429236 -->|"l"|eNFA144_11_17754262
eNFA144_11_17754262 -.->|"ε"|eNFA144_12_25570637
eNFA144_12_25570637 -->|"e"|eNFA144_13_28809145
eNFA144_13_28809145 -.->|"ε"|eNFA144_14_57955715
eNFA144_14_57955715 -->|"r"|eNFA144_15_51839388
eNFA144_15_51839388 -.->|"ε"|eNFA144_16_63901309
eNFA144_16_63901309 -->|"1"|eNFA144_17_38240871
eNFA144_17_38240871 -.->|"ε"|eNFA144_18_8623523
eNFA144_18_8623523 -->|"D"|eNFA144_19_10502851
eNFA144_19_10502851 -.->|"ε"|eNFA144_20_27416799
eNFA144_20_27416799 -->|"A"|eNFA144_21_45424599
eNFA144_21_45424599 -.->|"ε"|eNFA144_22_6168214
eNFA144_22_6168214 -->|"r"|eNFA144_23_55513932
eNFA144_23_55513932 -.->|"ε"|eNFA144_24_29863346
eNFA144_24_29863346 -->|"r"|eNFA144_25_334666
eNFA144_25_334666 -.->|"ε"|eNFA144_26_3011995
eNFA144_26_3011995 -->|"a"|eNFA144_27_27107960
eNFA144_27_27107960 -.->|"ε"|eNFA144_28_42645048
eNFA144_28_42645048 -->|"y"|eNFA144_29_48261118
eNFA144_29_48261118 -.->|"ε"|eNFA144_31_31696882
eNFA144_31_31696882 -.->|"ε"|eNFA144_32_16836485
eNFA144_32_16836485 -.->|"ε"|eNFA144_33_17310640
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
eNFA144_30_21578036[["εNFA144-30 regex start"]]
eNFA144_0_59984603[["εNFA144-0 char{1, 1}"]]
eNFA144_1_2990516[["εNFA144-1 char[1]"]]
eNFA144_2_26914650[["εNFA144-2 char{1, 1}"]]
eNFA144_3_40905261[["εNFA144-3 char[1]"]]
eNFA144_4_32603030[["εNFA144-4 char{1, 1}"]]
eNFA144_5_24991814[["εNFA144-5 char[1]"]]
eNFA144_6_23599734[["εNFA144-6 char{1, 1}"]]
eNFA144_7_11071015[["εNFA144-7 char[1]"]]
eNFA144_8_32530274[["εNFA144-8 char{1, 1}"]]
eNFA144_9_24337017[["εNFA144-9 char[1]"]]
eNFA144_10_17706563[["εNFA144-10 char{1, 1}"]]
eNFA144_11_25141347[["εNFA144-11 char[1]"]]
eNFA144_12_24945537[["εNFA144-12 char{1, 1}"]]
eNFA144_13_23183246[["εNFA144-13 char[1]"]]
eNFA144_14_7322627[["εNFA144-14 char{1, 1}"]]
eNFA144_15_65903650[["εNFA144-15 char[1]"]]
eNFA144_16_56261938[["εNFA144-16 char{1, 1}"]]
eNFA144_17_36595397[["εNFA144-17 char[1]"]]
eNFA144_18_60923125[["εNFA144-18 char{1, 1}"]]
eNFA144_19_11437218[["εNFA144-19 char[1]"]]
eNFA144_20_35826101[["εNFA144-20 char{1, 1}"]]
eNFA144_21_53999455[["εNFA144-21 char[1]"]]
eNFA144_22_16233049[["εNFA144-22 char{1, 1}"]]
eNFA144_23_11879716[["εNFA144-23 char[1]"]]
eNFA144_24_39808586[["εNFA144-24 char{1, 1}"]]
eNFA144_25_22732954[["εNFA144-25 char[1]"]]
eNFA144_26_3269999[["εNFA144-26 char{1, 1}"]]
eNFA144_27_29429992[["εNFA144-27 char[1]"]]
eNFA144_28_63543344[["εNFA144-28 char{1, 1}"]]
eNFA144_29_35019191[\"εNFA144-29 char[1]"/]
eNFA144_31_46737271[\"εNFA144-31 regex end"/]
eNFA144_32_17982255[\"εNFA144-32 post-regex start"/]
eNFA144_33_27622569[\"εNFA144-33 post-regex end"/]
eNFA144_30_21578036 -.->|"ε"|eNFA144_0_59984603
eNFA144_30_21578036 -->|"u"|eNFA144_1_2990516
eNFA144_0_59984603 -->|"u"|eNFA144_1_2990516
eNFA144_1_2990516 -.->|"ε"|eNFA144_2_26914650
eNFA144_1_2990516 -->|"s"|eNFA144_3_40905261
eNFA144_2_26914650 -->|"s"|eNFA144_3_40905261
eNFA144_3_40905261 -.->|"ε"|eNFA144_4_32603030
eNFA144_3_40905261 -->|"a"|eNFA144_5_24991814
eNFA144_4_32603030 -->|"a"|eNFA144_5_24991814
eNFA144_5_24991814 -.->|"ε"|eNFA144_6_23599734
eNFA144_5_24991814 -->|"m"|eNFA144_7_11071015
eNFA144_6_23599734 -->|"m"|eNFA144_7_11071015
eNFA144_7_11071015 -.->|"ε"|eNFA144_8_32530274
eNFA144_7_11071015 -->|"p"|eNFA144_9_24337017
eNFA144_8_32530274 -->|"p"|eNFA144_9_24337017
eNFA144_9_24337017 -.->|"ε"|eNFA144_10_17706563
eNFA144_9_24337017 -->|"l"|eNFA144_11_25141347
eNFA144_10_17706563 -->|"l"|eNFA144_11_25141347
eNFA144_11_25141347 -.->|"ε"|eNFA144_12_24945537
eNFA144_11_25141347 -->|"e"|eNFA144_13_23183246
eNFA144_12_24945537 -->|"e"|eNFA144_13_23183246
eNFA144_13_23183246 -.->|"ε"|eNFA144_14_7322627
eNFA144_13_23183246 -->|"r"|eNFA144_15_65903650
eNFA144_14_7322627 -->|"r"|eNFA144_15_65903650
eNFA144_15_65903650 -.->|"ε"|eNFA144_16_56261938
eNFA144_15_65903650 -->|"1"|eNFA144_17_36595397
eNFA144_16_56261938 -->|"1"|eNFA144_17_36595397
eNFA144_17_36595397 -.->|"ε"|eNFA144_18_60923125
eNFA144_17_36595397 -->|"D"|eNFA144_19_11437218
eNFA144_18_60923125 -->|"D"|eNFA144_19_11437218
eNFA144_19_11437218 -.->|"ε"|eNFA144_20_35826101
eNFA144_19_11437218 -->|"A"|eNFA144_21_53999455
eNFA144_20_35826101 -->|"A"|eNFA144_21_53999455
eNFA144_21_53999455 -.->|"ε"|eNFA144_22_16233049
eNFA144_21_53999455 -->|"r"|eNFA144_23_11879716
eNFA144_22_16233049 -->|"r"|eNFA144_23_11879716
eNFA144_23_11879716 -.->|"ε"|eNFA144_24_39808586
eNFA144_23_11879716 -->|"r"|eNFA144_25_22732954
eNFA144_24_39808586 -->|"r"|eNFA144_25_22732954
eNFA144_25_22732954 -.->|"ε"|eNFA144_26_3269999
eNFA144_25_22732954 -->|"a"|eNFA144_27_29429992
eNFA144_26_3269999 -->|"a"|eNFA144_27_29429992
eNFA144_27_29429992 -.->|"ε"|eNFA144_28_63543344
eNFA144_27_29429992 -->|"y"|eNFA144_29_35019191
eNFA144_28_63543344 -->|"y"|eNFA144_29_35019191
eNFA144_29_35019191 -.->|"ε"|eNFA144_31_46737271
eNFA144_29_35019191 -.->|"ε"|eNFA144_32_17982255
eNFA144_29_35019191 -.->|"ε"|eNFA144_33_27622569
eNFA144_31_46737271 -.->|"ε"|eNFA144_32_17982255
eNFA144_31_46737271 -.->|"ε"|eNFA144_33_27622569
eNFA144_32_17982255 -.->|"ε"|eNFA144_33_27622569
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
NFA144_30_47276535("NFA144-30 regex start")
NFA144_1_22835632("NFA144-1 char[1]")
NFA144_3_4194103("NFA144-3 char[1]")
NFA144_5_37746932("NFA144-5 char[1]")
NFA144_7_4178072("NFA144-7 char[1]")
NFA144_9_37602652("NFA144-9 char[1]")
NFA144_11_2879553("NFA144-11 char[1]")
NFA144_13_25915985("NFA144-13 char[1]")
NFA144_15_31917275("NFA144-15 char[1]")
NFA144_17_18820026("NFA144-17 char[1]")
NFA144_19_35162510("NFA144-19 char[1]")
NFA144_21_48027136("NFA144-21 char[1]")
NFA144_23_29591041("NFA144-23 char[1]")
NFA144_25_64992778("NFA144-25 char[1]")
NFA144_27_48064092("NFA144-27 char[1]")
NFA144_29_29923648[\"NFA144-29 char[1]"/]
NFA144_30_47276535 -->|"u"|NFA144_1_22835632
NFA144_1_22835632 -->|"s"|NFA144_3_4194103
NFA144_3_4194103 -->|"a"|NFA144_5_37746932
NFA144_5_37746932 -->|"m"|NFA144_7_4178072
NFA144_7_4178072 -->|"p"|NFA144_9_37602652
NFA144_9_37602652 -->|"l"|NFA144_11_2879553
NFA144_11_2879553 -->|"e"|NFA144_13_25915985
NFA144_13_25915985 -->|"r"|NFA144_15_31917275
NFA144_15_31917275 -->|"1"|NFA144_17_18820026
NFA144_17_18820026 -->|"D"|NFA144_19_35162510
NFA144_19_35162510 -->|"A"|NFA144_21_48027136
NFA144_21_48027136 -->|"r"|NFA144_23_29591041
NFA144_23_29591041 -->|"r"|NFA144_25_64992778
NFA144_25_64992778 -->|"a"|NFA144_27_48064092
NFA144_27_48064092 -->|"y"|NFA144_29_29923648
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
subgraph DFA0_-1585495711["DFA0 regex start"]
NFA144_30_47276535_0("NFA144-30 regex start")
end
subgraph DFA1_-1723215379["DFA1 {1}"]
NFA144_1_22835632_1("NFA144-1 char[1]")
end
subgraph DFA2_395497067["DFA2 {1}"]
NFA144_3_4194103_2("NFA144-3 char[1]")
end
subgraph DFA3_-540937478["DFA3 {1}"]
NFA144_5_37746932_3("NFA144-5 char[1]")
end
subgraph DFA4_1491448767["DFA4 {1}"]
NFA144_7_4178072_4("NFA144-7 char[1]")
end
subgraph DFA5_-32091412["DFA5 {1}"]
NFA144_9_37602652_5("NFA144-9 char[1]")
end
subgraph DFA6_-1456793661["DFA6 {1}"]
NFA144_11_2879553_6("NFA144-11 char[1]")
end
subgraph DFA7_-487072762["DFA7 {1}"]
NFA144_13_25915985_7("NFA144-13 char[1]")
end
subgraph DFA8_1350503696["DFA8 {1}"]
NFA144_15_31917275_8("NFA144-15 char[1]")
end
subgraph DFA9_-1226968672["DFA9 {1}"]
NFA144_17_18820026_9("NFA144-17 char[1]")
end
subgraph DFA10_683371921["DFA10 {1}"]
NFA144_19_35162510_10("NFA144-19 char[1]")
end
subgraph DFA11_1477832229["DFA11 {1}"]
NFA144_21_48027136_11("NFA144-21 char[1]")
end
subgraph DFA12_1162478238["DFA12 {1}"]
NFA144_23_29591041_12("NFA144-23 char[1]")
end
subgraph DFA13_1098099996["DFA13 {1}"]
NFA144_25_64992778_13("NFA144-25 char[1]")
end
subgraph DFA14_221854237["DFA14 {1}"]
NFA144_27_48064092_14("NFA144-27 char[1]")
end
subgraph DFA15_-458700434["DFA15 {1}"]
NFA144_29_29923648_15[\"NFA144-29 char[1]"/]
end
DFA0_-1585495711 -->|"u"|DFA1_-1723215379
DFA1_-1723215379 -->|"s"|DFA2_395497067
DFA2_395497067 -->|"a"|DFA3_-540937478
DFA3_-540937478 -->|"m"|DFA4_1491448767
DFA4_1491448767 -->|"p"|DFA5_-32091412
DFA5_-32091412 -->|"l"|DFA6_-1456793661
DFA6_-1456793661 -->|"e"|DFA7_-487072762
DFA7_-487072762 -->|"r"|DFA8_1350503696
DFA8_1350503696 -->|"1"|DFA9_-1226968672
DFA9_-1226968672 -->|"D"|DFA10_683371921
DFA10_683371921 -->|"A"|DFA11_1477832229
DFA11_1477832229 -->|"r"|DFA12_1162478238
DFA12_1162478238 -->|"r"|DFA13_1098099996
DFA13_1098099996 -->|"a"|DFA14_221854237
DFA14_221854237 -->|"y"|DFA15_-458700434
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
DFA0_-1585495711{{"DFA0 regex start"}}
DFA1_-1723215379{{"DFA1 {1}"}}
DFA2_395497067{{"DFA2 {1}"}}
DFA3_-540937478{{"DFA3 {1}"}}
DFA4_1491448767{{"DFA4 {1}"}}
DFA5_-32091412{{"DFA5 {1}"}}
DFA6_-1456793661{{"DFA6 {1}"}}
DFA7_-487072762{{"DFA7 {1}"}}
DFA8_1350503696{{"DFA8 {1}"}}
DFA9_-1226968672{{"DFA9 {1}"}}
DFA10_683371921{{"DFA10 {1}"}}
DFA11_1477832229{{"DFA11 {1}"}}
DFA12_1162478238{{"DFA12 {1}"}}
DFA13_1098099996{{"DFA13 {1}"}}
DFA14_221854237{{"DFA14 {1}"}}
DFA15_-458700434[\"DFA15 {1}"/]
DFA0_-1585495711 -->|"u"|DFA1_-1723215379
DFA1_-1723215379 -->|"s"|DFA2_395497067
DFA2_395497067 -->|"a"|DFA3_-540937478
DFA3_-540937478 -->|"m"|DFA4_1491448767
DFA4_1491448767 -->|"p"|DFA5_-32091412
DFA5_-32091412 -->|"l"|DFA6_-1456793661
DFA6_-1456793661 -->|"e"|DFA7_-487072762
DFA7_-487072762 -->|"r"|DFA8_1350503696
DFA8_1350503696 -->|"1"|DFA9_-1226968672
DFA9_-1226968672 -->|"D"|DFA10_683371921
DFA10_683371921 -->|"A"|DFA11_1477832229
DFA11_1477832229 -->|"r"|DFA12_1162478238
DFA12_1162478238 -->|"r"|DFA13_1098099996
DFA13_1098099996 -->|"a"|DFA14_221854237
DFA14_221854237 -->|"y"|DFA15_-458700434
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
subgraph MiniDFA0_1358039849["MiniDFA0 {1}"]
DFA0_-1585495711_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_178674153["MiniDFA1 {1}"]
DFA1_-1723215379_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1061623947["MiniDFA2 {1}"]
DFA2_395497067_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1213751760["MiniDFA4 {1}"]
DFA3_-540937478_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1542877564["MiniDFA5 {1}"]
DFA4_1491448767_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1540540232["MiniDFA6 {1}"]
DFA5_-32091412_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-1629912031["MiniDFA7 {1}"]
DFA6_-1456793661_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1597658995["MiniDFA8 {1}"]
DFA7_-487072762_7{{"DFA7 {1}"}}
end
subgraph MiniDFA11_-1452338551["MiniDFA11 {1}"]
DFA8_1350503696_8{{"DFA8 {1}"}}
end
subgraph MiniDFA12_-1621698240["MiniDFA12 {1}"]
DFA9_-1226968672_9{{"DFA9 {1}"}}
end
subgraph MiniDFA13_-1397753641["MiniDFA13 {1}"]
DFA10_683371921_10{{"DFA10 {1}"}}
end
subgraph MiniDFA9_637084719["MiniDFA9 {1}"]
DFA11_1477832229_11{{"DFA11 {1}"}}
end
subgraph MiniDFA10_229244368["MiniDFA10 {1}"]
DFA12_1162478238_12{{"DFA12 {1}"}}
end
subgraph MiniDFA3_-925167702["MiniDFA3 {1}"]
DFA13_1098099996_13{{"DFA13 {1}"}}
end
subgraph MiniDFA14_1441035139["MiniDFA14 {1}"]
DFA14_221854237_14{{"DFA14 {1}"}}
end
subgraph MiniDFA15_706110361["MiniDFA15 {1}"]
DFA15_-458700434_15[\"DFA15 {1}"/]
end
MiniDFA0_1358039849 -->|"u"|MiniDFA1_178674153
MiniDFA1_178674153 -->|"s"|MiniDFA2_-1061623947
MiniDFA2_-1061623947 -->|"a"|MiniDFA4_1213751760
MiniDFA4_1213751760 -->|"m"|MiniDFA5_-1542877564
MiniDFA5_-1542877564 -->|"p"|MiniDFA6_1540540232
MiniDFA6_1540540232 -->|"l"|MiniDFA7_-1629912031
MiniDFA7_-1629912031 -->|"e"|MiniDFA8_1597658995
MiniDFA8_1597658995 -->|"r"|MiniDFA11_-1452338551
MiniDFA11_-1452338551 -->|"1"|MiniDFA12_-1621698240
MiniDFA12_-1621698240 -->|"D"|MiniDFA13_-1397753641
MiniDFA13_-1397753641 -->|"A"|MiniDFA9_637084719
MiniDFA9_637084719 -->|"r"|MiniDFA10_229244368
MiniDFA10_229244368 -->|"r"|MiniDFA3_-925167702
MiniDFA3_-925167702 -->|"a"|MiniDFA14_1441035139
MiniDFA14_1441035139 -->|"y"|MiniDFA15_706110361
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
MiniDFA0_1358039849(["MiniDFA0 {1}"])
MiniDFA1_178674153(["MiniDFA1 {1}"])
MiniDFA2_-1061623947(["MiniDFA2 {1}"])
MiniDFA4_1213751760(["MiniDFA4 {1}"])
MiniDFA5_-1542877564(["MiniDFA5 {1}"])
MiniDFA6_1540540232(["MiniDFA6 {1}"])
MiniDFA7_-1629912031(["MiniDFA7 {1}"])
MiniDFA8_1597658995(["MiniDFA8 {1}"])
MiniDFA11_-1452338551(["MiniDFA11 {1}"])
MiniDFA12_-1621698240(["MiniDFA12 {1}"])
MiniDFA13_-1397753641(["MiniDFA13 {1}"])
MiniDFA9_637084719(["MiniDFA9 {1}"])
MiniDFA10_229244368(["MiniDFA10 {1}"])
MiniDFA3_-925167702(["MiniDFA3 {1}"])
MiniDFA14_1441035139(["MiniDFA14 {1}"])
MiniDFA15_706110361[\"MiniDFA15 {1}"/]
MiniDFA0_1358039849 -->|"u"|MiniDFA1_178674153
MiniDFA1_178674153 -->|"s"|MiniDFA2_-1061623947
MiniDFA2_-1061623947 -->|"a"|MiniDFA4_1213751760
MiniDFA4_1213751760 -->|"m"|MiniDFA5_-1542877564
MiniDFA5_-1542877564 -->|"p"|MiniDFA6_1540540232
MiniDFA6_1540540232 -->|"l"|MiniDFA7_-1629912031
MiniDFA7_-1629912031 -->|"e"|MiniDFA8_1597658995
MiniDFA8_1597658995 -->|"r"|MiniDFA11_-1452338551
MiniDFA11_-1452338551 -->|"1"|MiniDFA12_-1621698240
MiniDFA12_-1621698240 -->|"D"|MiniDFA13_-1397753641
MiniDFA13_-1397753641 -->|"A"|MiniDFA9_637084719
MiniDFA9_637084719 -->|"r"|MiniDFA10_229244368
MiniDFA10_229244368 -->|"r"|MiniDFA3_-925167702
MiniDFA3_-925167702 -->|"a"|MiniDFA14_1441035139
MiniDFA14_1441035139 -->|"y"|MiniDFA15_706110361
```
-------------------------------
