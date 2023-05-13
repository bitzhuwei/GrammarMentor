# 'sampler2DRect'

pattern: `sampler2DRect`

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
eNFA147_26_38105298[["εNFA147-26 regex start"]]
eNFA147_0_7403364[["εNFA147-0 char{1, 1}"]]
eNFA147_1_66630284[["εNFA147-1 char[1]"]]
eNFA147_2_62801650[["εNFA147-2 char{1, 1}"]]
eNFA147_3_28343943[["εNFA147-3 char[1]"]]
eNFA147_4_53768900[["εNFA147-4 char{1, 1}"]]
eNFA147_5_14158059[["εNFA147-5 char[1]"]]
eNFA147_6_60313667[["εNFA147-6 char{1, 1}"]]
eNFA147_7_5952094[["εNFA147-7 char[1]"]]
eNFA147_8_53568854[["εNFA147-8 char{1, 1}"]]
eNFA147_9_12357643[["εNFA147-9 char[1]"]]
eNFA147_10_44109926[["εNFA147-10 char{1, 1}"]]
eNFA147_11_61445016[["εNFA147-11 char[1]"]]
eNFA147_12_16134234[["εNFA147-12 char{1, 1}"]]
eNFA147_13_10990381[["εNFA147-13 char[1]"]]
eNFA147_14_31804571[["εNFA147-14 char{1, 1}"]]
eNFA147_15_17805683[["εNFA147-15 char[1]"]]
eNFA147_16_26033424[["εNFA147-16 char{1, 1}"]]
eNFA147_17_32974225[["εNFA147-17 char[1]"]]
eNFA147_18_28332577[["εNFA147-18 char{1, 1}"]]
eNFA147_19_53666608[["εNFA147-19 char[1]"]]
eNFA147_20_13237432[["εNFA147-20 char{1, 1}"]]
eNFA147_21_52028024[["εNFA147-21 char[1]"]]
eNFA147_22_65599034[["εNFA147-22 char{1, 1}"]]
eNFA147_23_53520400[["εNFA147-23 char[1]"]]
eNFA147_24_11921553[["εNFA147-24 char{1, 1}"]]
eNFA147_25_40185120[["εNFA147-25 char[1]"]]
eNFA147_27_26121765[["εNFA147-27 regex end"]]
eNFA147_28_33769297[["εNFA147-28 post-regex start"]]
eNFA147_29_35488221[\"εNFA147-29 post-regex end"/]
eNFA147_26_38105298 -.->|"ε"|eNFA147_0_7403364
eNFA147_0_7403364 -->|"s"|eNFA147_1_66630284
eNFA147_1_66630284 -.->|"ε"|eNFA147_2_62801650
eNFA147_2_62801650 -->|"a"|eNFA147_3_28343943
eNFA147_3_28343943 -.->|"ε"|eNFA147_4_53768900
eNFA147_4_53768900 -->|"m"|eNFA147_5_14158059
eNFA147_5_14158059 -.->|"ε"|eNFA147_6_60313667
eNFA147_6_60313667 -->|"p"|eNFA147_7_5952094
eNFA147_7_5952094 -.->|"ε"|eNFA147_8_53568854
eNFA147_8_53568854 -->|"l"|eNFA147_9_12357643
eNFA147_9_12357643 -.->|"ε"|eNFA147_10_44109926
eNFA147_10_44109926 -->|"e"|eNFA147_11_61445016
eNFA147_11_61445016 -.->|"ε"|eNFA147_12_16134234
eNFA147_12_16134234 -->|"r"|eNFA147_13_10990381
eNFA147_13_10990381 -.->|"ε"|eNFA147_14_31804571
eNFA147_14_31804571 -->|"2"|eNFA147_15_17805683
eNFA147_15_17805683 -.->|"ε"|eNFA147_16_26033424
eNFA147_16_26033424 -->|"D"|eNFA147_17_32974225
eNFA147_17_32974225 -.->|"ε"|eNFA147_18_28332577
eNFA147_18_28332577 -->|"R"|eNFA147_19_53666608
eNFA147_19_53666608 -.->|"ε"|eNFA147_20_13237432
eNFA147_20_13237432 -->|"e"|eNFA147_21_52028024
eNFA147_21_52028024 -.->|"ε"|eNFA147_22_65599034
eNFA147_22_65599034 -->|"c"|eNFA147_23_53520400
eNFA147_23_53520400 -.->|"ε"|eNFA147_24_11921553
eNFA147_24_11921553 -->|"t"|eNFA147_25_40185120
eNFA147_25_40185120 -.->|"ε"|eNFA147_27_26121765
eNFA147_27_26121765 -.->|"ε"|eNFA147_28_33769297
eNFA147_28_33769297 -.->|"ε"|eNFA147_29_35488221
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
eNFA147_26_50958538[["εNFA147-26 regex start"]]
eNFA147_0_55973666[["εNFA147-0 char{1, 1}"]]
eNFA147_1_34000948[["εNFA147-1 char[1]"]]
eNFA147_2_37573083[["εNFA147-2 char{1, 1}"]]
eNFA147_3_2613431[["εNFA147-3 char[1]"]]
eNFA147_4_23520881[["εNFA147-4 char{1, 1}"]]
eNFA147_5_10361338[["εNFA147-5 char[1]"]]
eNFA147_6_26143179[["εNFA147-6 char{1, 1}"]]
eNFA147_7_33962021[["εNFA147-7 char[1]"]]
eNFA147_8_37222737[["εNFA147-8 char{1, 1}"]]
eNFA147_9_66569185[["εNFA147-9 char[1]"]]
eNFA147_10_62251757[["εNFA147-10 char{1, 1}"]]
eNFA147_11_23394901[["εNFA147-11 char[1]"]]
eNFA147_12_9227524[["εNFA147-12 char{1, 1}"]]
eNFA147_13_15938858[["εNFA147-13 char[1]"]]
eNFA147_14_9232000[["εNFA147-14 char{1, 1}"]]
eNFA147_15_15979144[["εNFA147-15 char[1]"]]
eNFA147_16_9594569[["εNFA147-16 char{1, 1}"]]
eNFA147_17_19242262[["εNFA147-17 char[1]"]]
eNFA147_18_38962630[["εNFA147-18 char{1, 1}"]]
eNFA147_19_15119356[["εNFA147-19 char[1]"]]
eNFA147_20_1856480[["εNFA147-20 char{1, 1}"]]
eNFA147_21_16708323[["εNFA147-21 char[1]"]]
eNFA147_22_16157182[["εNFA147-22 char{1, 1}"]]
eNFA147_23_11196914[["εNFA147-23 char[1]"]]
eNFA147_24_33663369[["εNFA147-24 char{1, 1}"]]
eNFA147_25_34534866[\"εNFA147-25 char[1]"/]
eNFA147_27_42378344[\"εNFA147-27 regex end"/]
eNFA147_28_45860779[\"εNFA147-28 post-regex start"/]
eNFA147_29_10093828[\"εNFA147-29 post-regex end"/]
eNFA147_26_50958538 -.->|"ε"|eNFA147_0_55973666
eNFA147_26_50958538 -->|"s"|eNFA147_1_34000948
eNFA147_0_55973666 -->|"s"|eNFA147_1_34000948
eNFA147_1_34000948 -.->|"ε"|eNFA147_2_37573083
eNFA147_1_34000948 -->|"a"|eNFA147_3_2613431
eNFA147_2_37573083 -->|"a"|eNFA147_3_2613431
eNFA147_3_2613431 -.->|"ε"|eNFA147_4_23520881
eNFA147_3_2613431 -->|"m"|eNFA147_5_10361338
eNFA147_4_23520881 -->|"m"|eNFA147_5_10361338
eNFA147_5_10361338 -.->|"ε"|eNFA147_6_26143179
eNFA147_5_10361338 -->|"p"|eNFA147_7_33962021
eNFA147_6_26143179 -->|"p"|eNFA147_7_33962021
eNFA147_7_33962021 -.->|"ε"|eNFA147_8_37222737
eNFA147_7_33962021 -->|"l"|eNFA147_9_66569185
eNFA147_8_37222737 -->|"l"|eNFA147_9_66569185
eNFA147_9_66569185 -.->|"ε"|eNFA147_10_62251757
eNFA147_9_66569185 -->|"e"|eNFA147_11_23394901
eNFA147_10_62251757 -->|"e"|eNFA147_11_23394901
eNFA147_11_23394901 -.->|"ε"|eNFA147_12_9227524
eNFA147_11_23394901 -->|"r"|eNFA147_13_15938858
eNFA147_12_9227524 -->|"r"|eNFA147_13_15938858
eNFA147_13_15938858 -.->|"ε"|eNFA147_14_9232000
eNFA147_13_15938858 -->|"2"|eNFA147_15_15979144
eNFA147_14_9232000 -->|"2"|eNFA147_15_15979144
eNFA147_15_15979144 -.->|"ε"|eNFA147_16_9594569
eNFA147_15_15979144 -->|"D"|eNFA147_17_19242262
eNFA147_16_9594569 -->|"D"|eNFA147_17_19242262
eNFA147_17_19242262 -.->|"ε"|eNFA147_18_38962630
eNFA147_17_19242262 -->|"R"|eNFA147_19_15119356
eNFA147_18_38962630 -->|"R"|eNFA147_19_15119356
eNFA147_19_15119356 -.->|"ε"|eNFA147_20_1856480
eNFA147_19_15119356 -->|"e"|eNFA147_21_16708323
eNFA147_20_1856480 -->|"e"|eNFA147_21_16708323
eNFA147_21_16708323 -.->|"ε"|eNFA147_22_16157182
eNFA147_21_16708323 -->|"c"|eNFA147_23_11196914
eNFA147_22_16157182 -->|"c"|eNFA147_23_11196914
eNFA147_23_11196914 -.->|"ε"|eNFA147_24_33663369
eNFA147_23_11196914 -->|"t"|eNFA147_25_34534866
eNFA147_24_33663369 -->|"t"|eNFA147_25_34534866
eNFA147_25_34534866 -.->|"ε"|eNFA147_27_42378344
eNFA147_25_34534866 -.->|"ε"|eNFA147_28_45860779
eNFA147_25_34534866 -.->|"ε"|eNFA147_29_10093828
eNFA147_27_42378344 -.->|"ε"|eNFA147_28_45860779
eNFA147_27_42378344 -.->|"ε"|eNFA147_29_10093828
eNFA147_28_45860779 -.->|"ε"|eNFA147_29_10093828
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
NFA147_26_23735588("NFA147-26 regex start")
NFA147_1_12293700("NFA147-1 char[1]")
NFA147_3_43534437("NFA147-3 char[1]")
NFA147_5_56265616("NFA147-5 char[1]")
NFA147_7_36628503("NFA147-7 char[1]")
NFA147_9_61221073("NFA147-9 char[1]")
NFA147_11_14118753("NFA147-11 char[1]")
NFA147_13_59959919("NFA147-13 char[1]")
NFA147_15_2768364("NFA147-15 char[1]")
NFA147_17_24915281("NFA147-17 char[1]")
NFA147_19_22910944("NFA147-19 char[1]")
NFA147_21_4871904("NFA147-21 char[1]")
NFA147_23_43847139("NFA147-23 char[1]")
NFA147_25_59079939[\"NFA147-25 char[1]"/]
NFA147_26_23735588 -->|"s"|NFA147_1_12293700
NFA147_1_12293700 -->|"a"|NFA147_3_43534437
NFA147_3_43534437 -->|"m"|NFA147_5_56265616
NFA147_5_56265616 -->|"p"|NFA147_7_36628503
NFA147_7_36628503 -->|"l"|NFA147_9_61221073
NFA147_9_61221073 -->|"e"|NFA147_11_14118753
NFA147_11_14118753 -->|"r"|NFA147_13_59959919
NFA147_13_59959919 -->|"2"|NFA147_15_2768364
NFA147_15_2768364 -->|"D"|NFA147_17_24915281
NFA147_17_24915281 -->|"R"|NFA147_19_22910944
NFA147_19_22910944 -->|"e"|NFA147_21_4871904
NFA147_21_4871904 -->|"c"|NFA147_23_43847139
NFA147_23_43847139 -->|"t"|NFA147_25_59079939
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
subgraph DFA0_-235056228["DFA0 regex start"]
NFA147_26_23735588_0("NFA147-26 regex start")
end
subgraph DFA1_-1013915695["DFA1 {1}"]
NFA147_1_12293700_1("NFA147-1 char[1]")
end
subgraph DFA2_-1893600331["DFA2 {1}"]
NFA147_3_43534437_2("NFA147-3 char[1]")
end
subgraph DFA3_-865051483["DFA3 {1}"]
NFA147_5_56265616_3("NFA147-5 char[1]")
end
subgraph DFA4_-1881268250["DFA4 {1}"]
NFA147_7_36628503_4("NFA147-7 char[1]")
end
subgraph DFA5_-1941829821["DFA5 {1}"]
NFA147_9_61221073_5("NFA147-9 char[1]")
end
subgraph DFA6_-462366901["DFA6 {1}"]
NFA147_11_14118753_6("NFA147-11 char[1]")
end
subgraph DFA7_2139098746["DFA7 {1}"]
NFA147_13_59959919_7("NFA147-13 char[1]")
end
subgraph DFA8_2134287092["DFA8 {1}"]
NFA147_15_2768364_8("NFA147-15 char[1]")
end
subgraph DFA9_-178131587["DFA9 {1}"]
NFA147_17_24915281_9("NFA147-17 char[1]")
end
subgraph DFA10_-984750520["DFA10 {1}"]
NFA147_19_22910944_10("NFA147-19 char[1]")
end
subgraph DFA11_1646467077["DFA11 {1}"]
NFA147_21_4871904_11("NFA147-21 char[1]")
end
subgraph DFA12_224607196["DFA12 {1}"]
NFA147_23_43847139_12("NFA147-23 char[1]")
end
subgraph DFA13_1917250737["DFA13 {1}"]
NFA147_25_59079939_13[\"NFA147-25 char[1]"/]
end
DFA0_-235056228 -->|"s"|DFA1_-1013915695
DFA1_-1013915695 -->|"a"|DFA2_-1893600331
DFA2_-1893600331 -->|"m"|DFA3_-865051483
DFA3_-865051483 -->|"p"|DFA4_-1881268250
DFA4_-1881268250 -->|"l"|DFA5_-1941829821
DFA5_-1941829821 -->|"e"|DFA6_-462366901
DFA6_-462366901 -->|"r"|DFA7_2139098746
DFA7_2139098746 -->|"2"|DFA8_2134287092
DFA8_2134287092 -->|"D"|DFA9_-178131587
DFA9_-178131587 -->|"R"|DFA10_-984750520
DFA10_-984750520 -->|"e"|DFA11_1646467077
DFA11_1646467077 -->|"c"|DFA12_224607196
DFA12_224607196 -->|"t"|DFA13_1917250737
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
DFA0_-235056228{{"DFA0 regex start"}}
DFA1_-1013915695{{"DFA1 {1}"}}
DFA2_-1893600331{{"DFA2 {1}"}}
DFA3_-865051483{{"DFA3 {1}"}}
DFA4_-1881268250{{"DFA4 {1}"}}
DFA5_-1941829821{{"DFA5 {1}"}}
DFA6_-462366901{{"DFA6 {1}"}}
DFA7_2139098746{{"DFA7 {1}"}}
DFA8_2134287092{{"DFA8 {1}"}}
DFA9_-178131587{{"DFA9 {1}"}}
DFA10_-984750520{{"DFA10 {1}"}}
DFA11_1646467077{{"DFA11 {1}"}}
DFA12_224607196{{"DFA12 {1}"}}
DFA13_1917250737[\"DFA13 {1}"/]
DFA0_-235056228 -->|"s"|DFA1_-1013915695
DFA1_-1013915695 -->|"a"|DFA2_-1893600331
DFA2_-1893600331 -->|"m"|DFA3_-865051483
DFA3_-865051483 -->|"p"|DFA4_-1881268250
DFA4_-1881268250 -->|"l"|DFA5_-1941829821
DFA5_-1941829821 -->|"e"|DFA6_-462366901
DFA6_-462366901 -->|"r"|DFA7_2139098746
DFA7_2139098746 -->|"2"|DFA8_2134287092
DFA8_2134287092 -->|"D"|DFA9_-178131587
DFA9_-178131587 -->|"R"|DFA10_-984750520
DFA10_-984750520 -->|"e"|DFA11_1646467077
DFA11_1646467077 -->|"c"|DFA12_224607196
DFA12_224607196 -->|"t"|DFA13_1917250737
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
subgraph MiniDFA0_1476073061["MiniDFA0 {1}"]
DFA0_-235056228_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-182389522["MiniDFA1 {1}"]
DFA1_-1013915695_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_106886649["MiniDFA2 {1}"]
DFA2_-1893600331_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1001611447["MiniDFA3 {1}"]
DFA3_-865051483_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-2043186664["MiniDFA4 {1}"]
DFA4_-1881268250_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1914776633["MiniDFA5 {1}"]
DFA5_-1941829821_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_483803219["MiniDFA7 {1}"]
DFA6_-462366901_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1897863703["MiniDFA8 {1}"]
DFA7_2139098746_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_2055501355["MiniDFA9 {1}"]
DFA8_2134287092_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-1384103962["MiniDFA10 {1}"]
DFA9_-178131587_9{{"DFA9 {1}"}}
end
subgraph MiniDFA6_2068539578["MiniDFA6 {1}"]
DFA10_-984750520_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_1163859170["MiniDFA11 {1}"]
DFA11_1646467077_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1112218999["MiniDFA12 {1}"]
DFA12_224607196_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_450034283["MiniDFA13 {1}"]
DFA13_1917250737_13[\"DFA13 {1}"/]
end
MiniDFA0_1476073061 -->|"s"|MiniDFA1_-182389522
MiniDFA1_-182389522 -->|"a"|MiniDFA2_106886649
MiniDFA2_106886649 -->|"m"|MiniDFA3_1001611447
MiniDFA3_1001611447 -->|"p"|MiniDFA4_-2043186664
MiniDFA4_-2043186664 -->|"l"|MiniDFA5_-1914776633
MiniDFA5_-1914776633 -->|"e"|MiniDFA7_483803219
MiniDFA7_483803219 -->|"r"|MiniDFA8_-1897863703
MiniDFA8_-1897863703 -->|"2"|MiniDFA9_2055501355
MiniDFA9_2055501355 -->|"D"|MiniDFA10_-1384103962
MiniDFA10_-1384103962 -->|"R"|MiniDFA6_2068539578
MiniDFA6_2068539578 -->|"e"|MiniDFA11_1163859170
MiniDFA11_1163859170 -->|"c"|MiniDFA12_-1112218999
MiniDFA12_-1112218999 -->|"t"|MiniDFA13_450034283
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
MiniDFA0_1476073061(["MiniDFA0 {1}"])
MiniDFA1_-182389522(["MiniDFA1 {1}"])
MiniDFA2_106886649(["MiniDFA2 {1}"])
MiniDFA3_1001611447(["MiniDFA3 {1}"])
MiniDFA4_-2043186664(["MiniDFA4 {1}"])
MiniDFA5_-1914776633(["MiniDFA5 {1}"])
MiniDFA7_483803219(["MiniDFA7 {1}"])
MiniDFA8_-1897863703(["MiniDFA8 {1}"])
MiniDFA9_2055501355(["MiniDFA9 {1}"])
MiniDFA10_-1384103962(["MiniDFA10 {1}"])
MiniDFA6_2068539578(["MiniDFA6 {1}"])
MiniDFA11_1163859170(["MiniDFA11 {1}"])
MiniDFA12_-1112218999(["MiniDFA12 {1}"])
MiniDFA13_450034283[\"MiniDFA13 {1}"/]
MiniDFA0_1476073061 -->|"s"|MiniDFA1_-182389522
MiniDFA1_-182389522 -->|"a"|MiniDFA2_106886649
MiniDFA2_106886649 -->|"m"|MiniDFA3_1001611447
MiniDFA3_1001611447 -->|"p"|MiniDFA4_-2043186664
MiniDFA4_-2043186664 -->|"l"|MiniDFA5_-1914776633
MiniDFA5_-1914776633 -->|"e"|MiniDFA7_483803219
MiniDFA7_483803219 -->|"r"|MiniDFA8_-1897863703
MiniDFA8_-1897863703 -->|"2"|MiniDFA9_2055501355
MiniDFA9_2055501355 -->|"D"|MiniDFA10_-1384103962
MiniDFA10_-1384103962 -->|"R"|MiniDFA6_2068539578
MiniDFA6_2068539578 -->|"e"|MiniDFA11_1163859170
MiniDFA11_1163859170 -->|"c"|MiniDFA12_-1112218999
MiniDFA12_-1112218999 -->|"t"|MiniDFA13_450034283
```
-------------------------------
