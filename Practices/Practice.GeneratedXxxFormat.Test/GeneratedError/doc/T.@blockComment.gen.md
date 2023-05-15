# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA2_16_21933905[["εNFA2-16 regex start"]]
eNFA2_0_63187419[["εNFA2-0 char{1, 1}"]]
eNFA2_1_31815862[["εNFA2-1 char[1]"]]
eNFA2_2_17907308[["εNFA2-2 char{1, 1}"]]
eNFA2_3_60894213[["εNFA2-3 char[1]"]]
eNFA2_6_40893240[["εNFA2-6 regex start"]]
eNFA2_4_24018105[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_32494840[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_14836356[["εNFA2-7 regex end"]]
eNFA2_5_33484259[["εNFA2-5 scope[1]"]]
eNFA2_9_41372713[["εNFA2-9 scope[1]"]]
eNFA2_12_11177013[["εNFA2-12 char{1, 1}"]]
eNFA2_10_58129833[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_53406450[["εNFA2-13 char[1]"]]
eNFA2_11_42915540[["εNFA2-11 scope[1]"]]
eNFA2_14_10896009[["εNFA2-14 char{1, 1}"]]
eNFA2_15_10161546[["εNFA2-15 char[1]"]]
eNFA2_17_24345054[["εNFA2-17 regex end"]]
eNFA2_18_17778899[["εNFA2-18 post-regex start"]]
eNFA2_19_25792371[\"εNFA2-19 post-regex end"/]
eNFA2_16_21933905 -.->|"ε"|eNFA2_0_63187419
eNFA2_0_63187419 -->|"/"|eNFA2_1_31815862
eNFA2_1_31815862 -.->|"ε"|eNFA2_2_17907308
eNFA2_2_17907308 -->|"*"|eNFA2_3_60894213
eNFA2_3_60894213 -.->|"ε"|eNFA2_6_40893240
eNFA2_6_40893240 -.->|"ε"|eNFA2_4_24018105
eNFA2_6_40893240 -.->|"ε"|eNFA2_8_32494840
eNFA2_6_40893240 -.->|"ε"|eNFA2_7_14836356
eNFA2_4_24018105 -->|"[^*]"|eNFA2_5_33484259
eNFA2_8_32494840 -->|"[*]"|eNFA2_9_41372713
eNFA2_7_14836356 -.->|"ε"|eNFA2_6_40893240
eNFA2_7_14836356 -.->|"ε"|eNFA2_12_11177013
eNFA2_5_33484259 -.->|"ε"|eNFA2_7_14836356
eNFA2_9_41372713 -.->|"ε"|eNFA2_10_58129833
eNFA2_12_11177013 -->|"*"|eNFA2_13_53406450
eNFA2_10_58129833 -->|"[^/]"|eNFA2_11_42915540
eNFA2_13_53406450 -.->|"ε"|eNFA2_14_10896009
eNFA2_11_42915540 -.->|"ε"|eNFA2_7_14836356
eNFA2_14_10896009 -->|"/"|eNFA2_15_10161546
eNFA2_15_10161546 -.->|"ε"|eNFA2_17_24345054
eNFA2_17_24345054 -.->|"ε"|eNFA2_18_17778899
eNFA2_18_17778899 -.->|"ε"|eNFA2_19_25792371
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
eNFA2_16_30804749[["εNFA2-16 regex start"]]
eNFA2_0_8807292[["εNFA2-0 char{1, 1}"]]
eNFA2_1_12156768[["εNFA2-1 char[1]"]]
eNFA2_2_42302050[["εNFA2-2 char{1, 1}"]]
eNFA2_3_36810105[["εNFA2-3 char[1]"]]
eNFA2_6_26948044[["εNFA2-6 regex start"]]
eNFA2_4_35307962[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_41205809[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_49336210[["εNFA2-7 regex end"]]
eNFA2_5_28828491[["εNFA2-5 scope[1]"]]
eNFA2_9_45174131[["εNFA2-9 scope[1]"]]
eNFA2_12_62855489[["εNFA2-12 char{1, 1}"]]
eNFA2_13_35225966[["εNFA2-13 char[1]"]]
eNFA2_10_3913996[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_30955222[["εNFA2-11 scope[1]"]]
eNFA2_14_48598242[["εNFA2-14 char{1, 1}"]]
eNFA2_15_34731002[\"εNFA2-15 char[1]"/]
eNFA2_17_44143566[\"εNFA2-17 regex end"/]
eNFA2_18_61747774[\"εNFA2-18 post-regex start"/]
eNFA2_19_18859061[\"εNFA2-19 post-regex end"/]
eNFA2_16_30804749 -.->|"ε"|eNFA2_0_8807292
eNFA2_16_30804749 -->|"/"|eNFA2_1_12156768
eNFA2_0_8807292 -->|"/"|eNFA2_1_12156768
eNFA2_1_12156768 -.->|"ε"|eNFA2_2_42302050
eNFA2_1_12156768 -->|"*"|eNFA2_3_36810105
eNFA2_2_42302050 -->|"*"|eNFA2_3_36810105
eNFA2_3_36810105 -.->|"ε"|eNFA2_6_26948044
eNFA2_3_36810105 -.->|"ε"|eNFA2_4_35307962
eNFA2_3_36810105 -.->|"ε"|eNFA2_8_41205809
eNFA2_3_36810105 -.->|"ε"|eNFA2_7_49336210
eNFA2_3_36810105 -->|"[^*]"|eNFA2_5_28828491
eNFA2_3_36810105 -->|"[*]"|eNFA2_9_45174131
eNFA2_3_36810105 -.->|"ε"|eNFA2_12_62855489
eNFA2_3_36810105 -->|"*"|eNFA2_13_35225966
eNFA2_6_26948044 -.->|"ε"|eNFA2_4_35307962
eNFA2_6_26948044 -.->|"ε"|eNFA2_8_41205809
eNFA2_6_26948044 -.->|"ε"|eNFA2_7_49336210
eNFA2_6_26948044 -->|"[^*]"|eNFA2_5_28828491
eNFA2_6_26948044 -->|"[*]"|eNFA2_9_45174131
eNFA2_6_26948044 -.->|"ε"|eNFA2_6_26948044
eNFA2_6_26948044 -.->|"ε"|eNFA2_12_62855489
eNFA2_6_26948044 -->|"*"|eNFA2_13_35225966
eNFA2_4_35307962 -->|"[^*]"|eNFA2_5_28828491
eNFA2_8_41205809 -->|"[*]"|eNFA2_9_45174131
eNFA2_7_49336210 -.->|"ε"|eNFA2_6_26948044
eNFA2_7_49336210 -.->|"ε"|eNFA2_12_62855489
eNFA2_7_49336210 -.->|"ε"|eNFA2_4_35307962
eNFA2_7_49336210 -.->|"ε"|eNFA2_8_41205809
eNFA2_7_49336210 -.->|"ε"|eNFA2_7_49336210
eNFA2_7_49336210 -->|"[^*]"|eNFA2_5_28828491
eNFA2_7_49336210 -->|"[*]"|eNFA2_9_45174131
eNFA2_7_49336210 -->|"*"|eNFA2_13_35225966
eNFA2_5_28828491 -.->|"ε"|eNFA2_7_49336210
eNFA2_5_28828491 -.->|"ε"|eNFA2_6_26948044
eNFA2_5_28828491 -.->|"ε"|eNFA2_12_62855489
eNFA2_5_28828491 -.->|"ε"|eNFA2_4_35307962
eNFA2_5_28828491 -.->|"ε"|eNFA2_8_41205809
eNFA2_5_28828491 -->|"[^*]"|eNFA2_5_28828491
eNFA2_5_28828491 -->|"[*]"|eNFA2_9_45174131
eNFA2_5_28828491 -->|"*"|eNFA2_13_35225966
eNFA2_9_45174131 -.->|"ε"|eNFA2_10_3913996
eNFA2_9_45174131 -->|"[^/]"|eNFA2_11_30955222
eNFA2_12_62855489 -->|"*"|eNFA2_13_35225966
eNFA2_13_35225966 -.->|"ε"|eNFA2_14_48598242
eNFA2_13_35225966 -->|"/"|eNFA2_15_34731002
eNFA2_10_3913996 -->|"[^/]"|eNFA2_11_30955222
eNFA2_11_30955222 -.->|"ε"|eNFA2_7_49336210
eNFA2_11_30955222 -.->|"ε"|eNFA2_6_26948044
eNFA2_11_30955222 -.->|"ε"|eNFA2_12_62855489
eNFA2_11_30955222 -.->|"ε"|eNFA2_4_35307962
eNFA2_11_30955222 -.->|"ε"|eNFA2_8_41205809
eNFA2_11_30955222 -->|"[^*]"|eNFA2_5_28828491
eNFA2_11_30955222 -->|"[*]"|eNFA2_9_45174131
eNFA2_11_30955222 -->|"*"|eNFA2_13_35225966
eNFA2_14_48598242 -->|"/"|eNFA2_15_34731002
eNFA2_15_34731002 -.->|"ε"|eNFA2_17_44143566
eNFA2_15_34731002 -.->|"ε"|eNFA2_18_61747774
eNFA2_15_34731002 -.->|"ε"|eNFA2_19_18859061
eNFA2_17_44143566 -.->|"ε"|eNFA2_18_61747774
eNFA2_17_44143566 -.->|"ε"|eNFA2_19_18859061
eNFA2_18_61747774 -.->|"ε"|eNFA2_19_18859061
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
NFA2_16_38233575("NFA2-16 regex start")
NFA2_1_8557861("NFA2-1 char[1]")
NFA2_3_35513827("NFA2-3 char[1]")
NFA2_5_58047761("NFA2-5 scope[1]")
NFA2_9_51188993("NFA2-9 scope[1]")
NFA2_13_52667802("NFA2-13 char[1]")
NFA2_11_4248175("NFA2-11 scope[1]")
NFA2_15_9911889[\"NFA2-15 char[1]"/]
NFA2_16_38233575 -->|"/"|NFA2_1_8557861
NFA2_1_8557861 -->|"*"|NFA2_3_35513827
NFA2_3_35513827 -->|"[^*]"|NFA2_5_58047761
NFA2_3_35513827 -->|"[*]"|NFA2_9_51188993
NFA2_3_35513827 -->|"*"|NFA2_13_52667802
NFA2_5_58047761 -->|"[^*]"|NFA2_5_58047761
NFA2_5_58047761 -->|"[*]"|NFA2_9_51188993
NFA2_5_58047761 -->|"*"|NFA2_13_52667802
NFA2_9_51188993 -->|"[^/]"|NFA2_11_4248175
NFA2_13_52667802 -->|"/"|NFA2_15_9911889
NFA2_11_4248175 -->|"[^*]"|NFA2_5_58047761
NFA2_11_4248175 -->|"[*]"|NFA2_9_51188993
NFA2_11_4248175 -->|"*"|NFA2_13_52667802
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
subgraph DFA0_1346386168["DFA0 regex start"]
NFA2_16_38233575_0("NFA2-16 regex start")
end
subgraph DFA1_-1052091488["DFA1 {1}"]
NFA2_1_8557861_1("NFA2-1 char[1]")
end
subgraph DFA2_-2073637688["DFA2 {1}"]
NFA2_3_35513827_2("NFA2-3 char[1]")
end
subgraph DFA3_902102256["DFA3 {1}"]
NFA2_5_58047761_3("NFA2-5 scope[1]")
end
subgraph DFA4_-775875555["DFA4 {2}"]
NFA2_9_51188993_4("NFA2-9 scope[1]")
NFA2_13_52667802_5("NFA2-13 char[1]")
end
subgraph DFA5_-2128534851["DFA5 {1}"]
NFA2_11_4248175_6("NFA2-11 scope[1]")
end
subgraph DFA6_829346741["DFA6 {1}"]
NFA2_15_9911889_7[\"NFA2-15 char[1]"/]
end
DFA0_1346386168 -->|"/"|DFA1_-1052091488
DFA1_-1052091488 -->|"*"|DFA2_-2073637688
DFA2_-2073637688 -->|"[^*]"|DFA3_902102256
DFA2_-2073637688 -->|"*"|DFA4_-775875555
DFA3_902102256 -->|"[^*]"|DFA3_902102256
DFA3_902102256 -->|"*"|DFA4_-775875555
DFA4_-775875555 -->|"[^/]"|DFA5_-2128534851
DFA4_-775875555 -->|"/"|DFA6_829346741
DFA5_-2128534851 -->|"[^*]"|DFA3_902102256
DFA5_-2128534851 -->|"*"|DFA4_-775875555
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
DFA0_1346386168{{"DFA0 regex start"}}
DFA1_-1052091488{{"DFA1 {1}"}}
DFA2_-2073637688{{"DFA2 {1}"}}
DFA3_902102256{{"DFA3 {1}"}}
DFA4_-775875555{{"DFA4 {2}"}}
DFA5_-2128534851{{"DFA5 {1}"}}
DFA6_829346741[\"DFA6 {1}"/]
DFA0_1346386168 -->|"/"|DFA1_-1052091488
DFA1_-1052091488 -->|"*"|DFA2_-2073637688
DFA2_-2073637688 -->|"[^*]"|DFA3_902102256
DFA2_-2073637688 -->|"*"|DFA4_-775875555
DFA3_902102256 -->|"[^*]"|DFA3_902102256
DFA3_902102256 -->|"*"|DFA4_-775875555
DFA4_-775875555 -->|"[^/]"|DFA5_-2128534851
DFA4_-775875555 -->|"/"|DFA6_829346741
DFA5_-2128534851 -->|"[^*]"|DFA3_902102256
DFA5_-2128534851 -->|"*"|DFA4_-775875555
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
subgraph MiniDFA0_-327383842["MiniDFA0 {1}"]
DFA0_1346386168_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-78969964["MiniDFA1 {1}"]
DFA1_-1052091488_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1862657080["MiniDFA2 {3}"]
DFA2_-2073637688_2{{"DFA2 {1}"}}
DFA3_902102256_3{{"DFA3 {1}"}}
DFA5_-2128534851_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_273203159["MiniDFA3 {1}"]
DFA4_-775875555_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_2029308886["MiniDFA4 {1}"]
DFA6_829346741_6[\"DFA6 {1}"/]
end
MiniDFA0_-327383842 -->|"/"|MiniDFA1_-78969964
MiniDFA1_-78969964 -->|"*"|MiniDFA2_1862657080
MiniDFA2_1862657080 -->|"[^*]"|MiniDFA2_1862657080
MiniDFA2_1862657080 -->|"*"|MiniDFA3_273203159
MiniDFA3_273203159 -->|"[^/]"|MiniDFA2_1862657080
MiniDFA3_273203159 -->|"/"|MiniDFA4_2029308886
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
MiniDFA0_-327383842(["MiniDFA0 {1}"])
MiniDFA1_-78969964(["MiniDFA1 {1}"])
MiniDFA2_1862657080(["MiniDFA2 {3}"])
MiniDFA3_273203159(["MiniDFA3 {1}"])
MiniDFA4_2029308886[\"MiniDFA4 {1}"/]
MiniDFA0_-327383842 -->|"/"|MiniDFA1_-78969964
MiniDFA1_-78969964 -->|"*"|MiniDFA2_1862657080
MiniDFA2_1862657080 -->|"[^*]"|MiniDFA2_1862657080
MiniDFA2_1862657080 -->|"*"|MiniDFA3_273203159
MiniDFA3_273203159 -->|"[^/]"|MiniDFA2_1862657080
MiniDFA3_273203159 -->|"/"|MiniDFA4_2029308886
```
-------------------------------
