# 'image1DArray'

pattern: `image1DArray`

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
eNFA178_24_23603084[["εNFA178-24 regex start"]]
eNFA178_0_11101171[["εNFA178-0 char{1, 1}"]]
eNFA178_1_32801677[["εNFA178-1 char[1]"]]
eNFA178_2_26779645[["εNFA178-2 char{1, 1}"]]
eNFA178_3_39690219[["εNFA178-3 char[1]"]]
eNFA178_4_21667656[["εNFA178-4 char{1, 1}"]]
eNFA178_5_60791181[["εNFA178-5 char[1]"]]
eNFA178_6_10249724[["εNFA178-6 char{1, 1}"]]
eNFA178_7_25138652[["εNFA178-7 char[1]"]]
eNFA178_8_24921279[["εNFA178-8 char{1, 1}"]]
eNFA178_9_22964927[["εNFA178-9 char[1]"]]
eNFA178_10_5357756[["εNFA178-10 char{1, 1}"]]
eNFA178_11_48219807[["εNFA178-11 char[1]"]]
eNFA178_12_31325081[["εNFA178-12 char{1, 1}"]]
eNFA178_13_13490275[["εNFA178-13 char[1]"]]
eNFA178_14_54303614[["εNFA178-14 char{1, 1}"]]
eNFA178_15_18970484[["εNFA178-15 char[1]"]]
eNFA178_16_36516628[["εNFA178-16 char{1, 1}"]]
eNFA178_17_60214201[["εNFA178-17 char[1]"]]
eNFA178_18_5056898[["εNFA178-18 char{1, 1}"]]
eNFA178_19_45512090[["εNFA178-19 char[1]"]]
eNFA178_20_6955633[["εNFA178-20 char{1, 1}"]]
eNFA178_21_62600705[["εNFA178-21 char[1]"]]
eNFA178_22_26535433[["εNFA178-22 char{1, 1}"]]
eNFA178_23_37492307[["εNFA178-23 char[1]"]]
eNFA178_25_1886449[["εNFA178-25 regex end"]]
eNFA178_26_16978042[["εNFA178-26 post-regex start"]]
eNFA178_27_18584657[\"εNFA178-27 post-regex end"/]
eNFA178_24_23603084 -.->|"ε"|eNFA178_0_11101171
eNFA178_0_11101171 -->|"i"|eNFA178_1_32801677
eNFA178_1_32801677 -.->|"ε"|eNFA178_2_26779645
eNFA178_2_26779645 -->|"m"|eNFA178_3_39690219
eNFA178_3_39690219 -.->|"ε"|eNFA178_4_21667656
eNFA178_4_21667656 -->|"a"|eNFA178_5_60791181
eNFA178_5_60791181 -.->|"ε"|eNFA178_6_10249724
eNFA178_6_10249724 -->|"g"|eNFA178_7_25138652
eNFA178_7_25138652 -.->|"ε"|eNFA178_8_24921279
eNFA178_8_24921279 -->|"e"|eNFA178_9_22964927
eNFA178_9_22964927 -.->|"ε"|eNFA178_10_5357756
eNFA178_10_5357756 -->|"1"|eNFA178_11_48219807
eNFA178_11_48219807 -.->|"ε"|eNFA178_12_31325081
eNFA178_12_31325081 -->|"D"|eNFA178_13_13490275
eNFA178_13_13490275 -.->|"ε"|eNFA178_14_54303614
eNFA178_14_54303614 -->|"A"|eNFA178_15_18970484
eNFA178_15_18970484 -.->|"ε"|eNFA178_16_36516628
eNFA178_16_36516628 -->|"r"|eNFA178_17_60214201
eNFA178_17_60214201 -.->|"ε"|eNFA178_18_5056898
eNFA178_18_5056898 -->|"r"|eNFA178_19_45512090
eNFA178_19_45512090 -.->|"ε"|eNFA178_20_6955633
eNFA178_20_6955633 -->|"a"|eNFA178_21_62600705
eNFA178_21_62600705 -.->|"ε"|eNFA178_22_26535433
eNFA178_22_26535433 -->|"y"|eNFA178_23_37492307
eNFA178_23_37492307 -.->|"ε"|eNFA178_25_1886449
eNFA178_25_1886449 -.->|"ε"|eNFA178_26_16978042
eNFA178_26_16978042 -.->|"ε"|eNFA178_27_18584657
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
eNFA178_24_33044190[["εNFA178-24 regex start"]]
eNFA178_0_28962258[["εNFA178-0 char{1, 1}"]]
eNFA178_1_59333734[["εNFA178-1 char[1]"]]
eNFA178_2_64241563[["εNFA178-2 char{1, 1}"]]
eNFA178_3_41303163[["εNFA178-3 char[1]"]]
eNFA178_4_36184149[["εNFA178-4 char{1, 1}"]]
eNFA178_5_57221892[["εNFA178-5 char[1]"]]
eNFA178_6_45234984[["εNFA178-6 char{1, 1}"]]
eNFA178_7_4461674[["εNFA178-7 char[1]"]]
eNFA178_8_40155067[["εNFA178-8 char{1, 1}"]]
eNFA178_9_25851284[["εNFA178-9 char[1]"]]
eNFA178_10_31334966[["εNFA178-10 char{1, 1}"]]
eNFA178_11_13579242[["εNFA178-11 char[1]"]]
eNFA178_12_55104322[["εNFA178-12 char{1, 1}"]]
eNFA178_13_26176854[["εNFA178-13 char[1]"]]
eNFA178_14_34265094[["εNFA178-14 char{1, 1}"]]
eNFA178_15_39950397[["εNFA178-15 char[1]"]]
eNFA178_16_24009259[["εNFA178-16 char{1, 1}"]]
eNFA178_17_14756745[["εNFA178-17 char[1]"]]
eNFA178_18_65701849[["εNFA178-18 char{1, 1}"]]
eNFA178_19_54445730[["εNFA178-19 char[1]"]]
eNFA178_20_20249527[["εNFA178-20 char{1, 1}"]]
eNFA178_21_48028015[["εNFA178-21 char[1]"]]
eNFA178_22_29598957[["εNFA178-22 char{1, 1}"]]
eNFA178_23_65064025[\"εNFA178-23 char[1]"/]
eNFA178_25_48705316[\"εNFA178-25 regex end"/]
eNFA178_26_35694663[\"εNFA178-26 post-regex start"/]
eNFA178_27_52816515[\"εNFA178-27 post-regex end"/]
eNFA178_24_33044190 -.->|"ε"|eNFA178_0_28962258
eNFA178_24_33044190 -->|"i"|eNFA178_1_59333734
eNFA178_0_28962258 -->|"i"|eNFA178_1_59333734
eNFA178_1_59333734 -.->|"ε"|eNFA178_2_64241563
eNFA178_1_59333734 -->|"m"|eNFA178_3_41303163
eNFA178_2_64241563 -->|"m"|eNFA178_3_41303163
eNFA178_3_41303163 -.->|"ε"|eNFA178_4_36184149
eNFA178_3_41303163 -->|"a"|eNFA178_5_57221892
eNFA178_4_36184149 -->|"a"|eNFA178_5_57221892
eNFA178_5_57221892 -.->|"ε"|eNFA178_6_45234984
eNFA178_5_57221892 -->|"g"|eNFA178_7_4461674
eNFA178_6_45234984 -->|"g"|eNFA178_7_4461674
eNFA178_7_4461674 -.->|"ε"|eNFA178_8_40155067
eNFA178_7_4461674 -->|"e"|eNFA178_9_25851284
eNFA178_8_40155067 -->|"e"|eNFA178_9_25851284
eNFA178_9_25851284 -.->|"ε"|eNFA178_10_31334966
eNFA178_9_25851284 -->|"1"|eNFA178_11_13579242
eNFA178_10_31334966 -->|"1"|eNFA178_11_13579242
eNFA178_11_13579242 -.->|"ε"|eNFA178_12_55104322
eNFA178_11_13579242 -->|"D"|eNFA178_13_26176854
eNFA178_12_55104322 -->|"D"|eNFA178_13_26176854
eNFA178_13_26176854 -.->|"ε"|eNFA178_14_34265094
eNFA178_13_26176854 -->|"A"|eNFA178_15_39950397
eNFA178_14_34265094 -->|"A"|eNFA178_15_39950397
eNFA178_15_39950397 -.->|"ε"|eNFA178_16_24009259
eNFA178_15_39950397 -->|"r"|eNFA178_17_14756745
eNFA178_16_24009259 -->|"r"|eNFA178_17_14756745
eNFA178_17_14756745 -.->|"ε"|eNFA178_18_65701849
eNFA178_17_14756745 -->|"r"|eNFA178_19_54445730
eNFA178_18_65701849 -->|"r"|eNFA178_19_54445730
eNFA178_19_54445730 -.->|"ε"|eNFA178_20_20249527
eNFA178_19_54445730 -->|"a"|eNFA178_21_48028015
eNFA178_20_20249527 -->|"a"|eNFA178_21_48028015
eNFA178_21_48028015 -.->|"ε"|eNFA178_22_29598957
eNFA178_21_48028015 -->|"y"|eNFA178_23_65064025
eNFA178_22_29598957 -->|"y"|eNFA178_23_65064025
eNFA178_23_65064025 -.->|"ε"|eNFA178_25_48705316
eNFA178_23_65064025 -.->|"ε"|eNFA178_26_35694663
eNFA178_23_65064025 -.->|"ε"|eNFA178_27_52816515
eNFA178_25_48705316 -.->|"ε"|eNFA178_26_35694663
eNFA178_25_48705316 -.->|"ε"|eNFA178_27_52816515
eNFA178_26_35694663 -.->|"ε"|eNFA178_27_52816515
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
NFA178_24_5586594("NFA178-24 regex start")
NFA178_1_50279347("NFA178-1 char[1]")
NFA178_3_49860945("NFA178-3 char[1]")
NFA178_5_46095324("NFA178-5 char[1]")
NFA178_7_12204733("NFA178-7 char[1]")
NFA178_9_42733733("NFA178-9 char[1]")
NFA178_11_49059277("NFA178-11 char[1]")
NFA178_13_38880310("NFA178-13 char[1]")
NFA178_15_14378473("NFA178-15 char[1]")
NFA178_17_62297400("NFA178-17 char[1]")
NFA178_19_23805690("NFA178-19 char[1]")
NFA178_21_12924626("NFA178-21 char[1]")
NFA178_23_49212776[\"NFA178-23 char[1]"/]
NFA178_24_5586594 -->|"i"|NFA178_1_50279347
NFA178_1_50279347 -->|"m"|NFA178_3_49860945
NFA178_3_49860945 -->|"a"|NFA178_5_46095324
NFA178_5_46095324 -->|"g"|NFA178_7_12204733
NFA178_7_12204733 -->|"e"|NFA178_9_42733733
NFA178_9_42733733 -->|"1"|NFA178_11_49059277
NFA178_11_49059277 -->|"D"|NFA178_13_38880310
NFA178_13_38880310 -->|"A"|NFA178_15_14378473
NFA178_15_14378473 -->|"r"|NFA178_17_62297400
NFA178_17_62297400 -->|"r"|NFA178_19_23805690
NFA178_19_23805690 -->|"a"|NFA178_21_12924626
NFA178_21_12924626 -->|"y"|NFA178_23_49212776
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
subgraph DFA0_-1531579942["DFA0 regex start"]
NFA178_24_5586594_0("NFA178-24 regex start")
end
subgraph DFA1_-2016441542["DFA1 {1}"]
NFA178_1_50279347_1("NFA178-1 char[1]")
end
subgraph DFA2_-206587218["DFA2 {1}"]
NFA178_3_49860945_2("NFA178-3 char[1]")
end
subgraph DFA3_287721226["DFA3 {1}"]
NFA178_5_46095324_3("NFA178-5 char[1]")
end
subgraph DFA4_-761259501["DFA4 {1}"]
NFA178_7_12204733_4("NFA178-7 char[1]")
end
subgraph DFA5_-1230285502["DFA5 {1}"]
NFA178_9_42733733_5("NFA178-9 char[1]")
end
subgraph DFA6_-887279854["DFA6 {1}"]
NFA178_11_49059277_6("NFA178-11 char[1]")
end
subgraph DFA7_619779369["DFA7 {1}"]
NFA178_13_38880310_7("NFA178-13 char[1]")
end
subgraph DFA8_492496742["DFA8 {1}"]
NFA178_15_14378473_8("NFA178-15 char[1]")
end
subgraph DFA9_-1058783725["DFA9 {1}"]
NFA178_17_62297400_9("NFA178-17 char[1]")
end
subgraph DFA10_-1332885588["DFA10 {1}"]
NFA178_19_23805690_10("NFA178-19 char[1]")
end
subgraph DFA11_1216918407["DFA11 {1}"]
NFA178_21_12924626_11("NFA178-21 char[1]")
end
subgraph DFA12_1286361862["DFA12 {1}"]
NFA178_23_49212776_12[\"NFA178-23 char[1]"/]
end
DFA0_-1531579942 -->|"i"|DFA1_-2016441542
DFA1_-2016441542 -->|"m"|DFA2_-206587218
DFA2_-206587218 -->|"a"|DFA3_287721226
DFA3_287721226 -->|"g"|DFA4_-761259501
DFA4_-761259501 -->|"e"|DFA5_-1230285502
DFA5_-1230285502 -->|"1"|DFA6_-887279854
DFA6_-887279854 -->|"D"|DFA7_619779369
DFA7_619779369 -->|"A"|DFA8_492496742
DFA8_492496742 -->|"r"|DFA9_-1058783725
DFA9_-1058783725 -->|"r"|DFA10_-1332885588
DFA10_-1332885588 -->|"a"|DFA11_1216918407
DFA11_1216918407 -->|"y"|DFA12_1286361862
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
DFA0_-1531579942{{"DFA0 regex start"}}
DFA1_-2016441542{{"DFA1 {1}"}}
DFA2_-206587218{{"DFA2 {1}"}}
DFA3_287721226{{"DFA3 {1}"}}
DFA4_-761259501{{"DFA4 {1}"}}
DFA5_-1230285502{{"DFA5 {1}"}}
DFA6_-887279854{{"DFA6 {1}"}}
DFA7_619779369{{"DFA7 {1}"}}
DFA8_492496742{{"DFA8 {1}"}}
DFA9_-1058783725{{"DFA9 {1}"}}
DFA10_-1332885588{{"DFA10 {1}"}}
DFA11_1216918407{{"DFA11 {1}"}}
DFA12_1286361862[\"DFA12 {1}"/]
DFA0_-1531579942 -->|"i"|DFA1_-2016441542
DFA1_-2016441542 -->|"m"|DFA2_-206587218
DFA2_-206587218 -->|"a"|DFA3_287721226
DFA3_287721226 -->|"g"|DFA4_-761259501
DFA4_-761259501 -->|"e"|DFA5_-1230285502
DFA5_-1230285502 -->|"1"|DFA6_-887279854
DFA6_-887279854 -->|"D"|DFA7_619779369
DFA7_619779369 -->|"A"|DFA8_492496742
DFA8_492496742 -->|"r"|DFA9_-1058783725
DFA9_-1058783725 -->|"r"|DFA10_-1332885588
DFA10_-1332885588 -->|"a"|DFA11_1216918407
DFA11_1216918407 -->|"y"|DFA12_1286361862
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
subgraph MiniDFA0_1602587094["MiniDFA0 {1}"]
DFA0_-1531579942_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_394498033["MiniDFA1 {1}"]
DFA1_-2016441542_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1230100956["MiniDFA2 {1}"]
DFA2_-206587218_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1766578131["MiniDFA4 {1}"]
DFA3_287721226_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_336728127["MiniDFA5 {1}"]
DFA4_-761259501_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_1083582784["MiniDFA6 {1}"]
DFA5_-1230285502_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-263438187["MiniDFA7 {1}"]
DFA6_-887279854_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_48472724["MiniDFA8 {1}"]
DFA7_619779369_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_1785661982["MiniDFA9 {1}"]
DFA8_492496742_8{{"DFA8 {1}"}}
end
subgraph MiniDFA10_-239183828["MiniDFA10 {1}"]
DFA9_-1058783725_9{{"DFA9 {1}"}}
end
subgraph MiniDFA3_1197909921["MiniDFA3 {1}"]
DFA10_-1332885588_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-1130160153["MiniDFA11 {1}"]
DFA11_1216918407_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1248476157["MiniDFA12 {1}"]
DFA12_1286361862_12[\"DFA12 {1}"/]
end
MiniDFA0_1602587094 -->|"i"|MiniDFA1_394498033
MiniDFA1_394498033 -->|"m"|MiniDFA2_-1230100956
MiniDFA2_-1230100956 -->|"a"|MiniDFA4_1766578131
MiniDFA4_1766578131 -->|"g"|MiniDFA5_336728127
MiniDFA5_336728127 -->|"e"|MiniDFA6_1083582784
MiniDFA6_1083582784 -->|"1"|MiniDFA7_-263438187
MiniDFA7_-263438187 -->|"D"|MiniDFA8_48472724
MiniDFA8_48472724 -->|"A"|MiniDFA9_1785661982
MiniDFA9_1785661982 -->|"r"|MiniDFA10_-239183828
MiniDFA10_-239183828 -->|"r"|MiniDFA3_1197909921
MiniDFA3_1197909921 -->|"a"|MiniDFA11_-1130160153
MiniDFA11_-1130160153 -->|"y"|MiniDFA12_1248476157
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
MiniDFA0_1602587094(["MiniDFA0 {1}"])
MiniDFA1_394498033(["MiniDFA1 {1}"])
MiniDFA2_-1230100956(["MiniDFA2 {1}"])
MiniDFA4_1766578131(["MiniDFA4 {1}"])
MiniDFA5_336728127(["MiniDFA5 {1}"])
MiniDFA6_1083582784(["MiniDFA6 {1}"])
MiniDFA7_-263438187(["MiniDFA7 {1}"])
MiniDFA8_48472724(["MiniDFA8 {1}"])
MiniDFA9_1785661982(["MiniDFA9 {1}"])
MiniDFA10_-239183828(["MiniDFA10 {1}"])
MiniDFA3_1197909921(["MiniDFA3 {1}"])
MiniDFA11_-1130160153(["MiniDFA11 {1}"])
MiniDFA12_1248476157[\"MiniDFA12 {1}"/]
MiniDFA0_1602587094 -->|"i"|MiniDFA1_394498033
MiniDFA1_394498033 -->|"m"|MiniDFA2_-1230100956
MiniDFA2_-1230100956 -->|"a"|MiniDFA4_1766578131
MiniDFA4_1766578131 -->|"g"|MiniDFA5_336728127
MiniDFA5_336728127 -->|"e"|MiniDFA6_1083582784
MiniDFA6_1083582784 -->|"1"|MiniDFA7_-263438187
MiniDFA7_-263438187 -->|"D"|MiniDFA8_48472724
MiniDFA8_48472724 -->|"A"|MiniDFA9_1785661982
MiniDFA9_1785661982 -->|"r"|MiniDFA10_-239183828
MiniDFA10_-239183828 -->|"r"|MiniDFA3_1197909921
MiniDFA3_1197909921 -->|"a"|MiniDFA11_-1130160153
MiniDFA11_-1130160153 -->|"y"|MiniDFA12_1248476157
```
-------------------------------
