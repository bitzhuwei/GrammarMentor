# 'dmat2x3'

pattern: `dmat2x3`

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
eNFA111_14_61372619[["εNFA111-14 regex start"]]
eNFA111_0_15482662[["εNFA111-0 char{1, 1}"]]
eNFA111_1_5126234[["εNFA111-1 char[1]"]]
eNFA111_2_46136113[["εNFA111-2 char{1, 1}"]]
eNFA111_3_12571834[["εNFA111-3 char[1]"]]
eNFA111_4_46037648[["εNFA111-4 char{1, 1}"]]
eNFA111_5_11685651[["εNFA111-5 char[1]"]]
eNFA111_6_38061996[["εNFA111-6 char{1, 1}"]]
eNFA111_7_7013644[["εNFA111-7 char[1]"]]
eNFA111_8_63122796[["εNFA111-8 char{1, 1}"]]
eNFA111_9_31234253[["εNFA111-9 char[1]"]]
eNFA111_10_12672824[["εNFA111-10 char{1, 1}"]]
eNFA111_11_46946559[["εNFA111-11 char[1]"]]
eNFA111_12_19865849[["εNFA111-12 char{1, 1}"]]
eNFA111_13_44574921[["εNFA111-13 char[1]"]]
eNFA111_15_65629975[["εNFA111-15 regex end"]]
eNFA111_16_53798868[["εNFA111-16 post-regex start"]]
eNFA111_17_14427769[\"εNFA111-17 post-regex end"/]
eNFA111_14_61372619 -.->|"ε"|eNFA111_0_15482662
eNFA111_0_15482662 -->|"d"|eNFA111_1_5126234
eNFA111_1_5126234 -.->|"ε"|eNFA111_2_46136113
eNFA111_2_46136113 -->|"m"|eNFA111_3_12571834
eNFA111_3_12571834 -.->|"ε"|eNFA111_4_46037648
eNFA111_4_46037648 -->|"a"|eNFA111_5_11685651
eNFA111_5_11685651 -.->|"ε"|eNFA111_6_38061996
eNFA111_6_38061996 -->|"t"|eNFA111_7_7013644
eNFA111_7_7013644 -.->|"ε"|eNFA111_8_63122796
eNFA111_8_63122796 -->|"2"|eNFA111_9_31234253
eNFA111_9_31234253 -.->|"ε"|eNFA111_10_12672824
eNFA111_10_12672824 -->|"x"|eNFA111_11_46946559
eNFA111_11_46946559 -.->|"ε"|eNFA111_12_19865849
eNFA111_12_19865849 -->|"3"|eNFA111_13_44574921
eNFA111_13_44574921 -.->|"ε"|eNFA111_15_65629975
eNFA111_15_65629975 -.->|"ε"|eNFA111_16_53798868
eNFA111_16_53798868 -.->|"ε"|eNFA111_17_14427769
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
eNFA111_14_62741064[["εNFA111-14 regex start"]]
eNFA111_0_27798664[["εNFA111-0 char{1, 1}"]]
eNFA111_1_48861387[["εNFA111-1 char[1]"]]
eNFA111_2_37099307[["εNFA111-2 char{1, 1}"]]
eNFA111_3_65458312[["εNFA111-3 char[1]"]]
eNFA111_4_52253899[["εNFA111-4 char{1, 1}"]]
eNFA111_5_523045[["εNFA111-5 char[1]"]]
eNFA111_6_4707407[["εNFA111-6 char{1, 1}"]]
eNFA111_7_42366666[["εNFA111-7 char[1]"]]
eNFA111_8_45755680[["εNFA111-8 char{1, 1}"]]
eNFA111_9_9147936[["εNFA111-9 char[1]"]]
eNFA111_10_15222565[["εNFA111-10 char{1, 1}"]]
eNFA111_11_2785358[["εNFA111-11 char[1]"]]
eNFA111_12_25068230[["εNFA111-12 char{1, 1}"]]
eNFA111_13_24287485[\"εNFA111-13 char[1]"/]
eNFA111_15_17260781[\"εNFA111-15 regex end"/]
eNFA111_16_21129301[\"εNFA111-16 post-regex start"/]
eNFA111_17_55945983[\"εNFA111-17 post-regex end"/]
eNFA111_14_62741064 -.->|"ε"|eNFA111_0_27798664
eNFA111_14_62741064 -->|"d"|eNFA111_1_48861387
eNFA111_0_27798664 -->|"d"|eNFA111_1_48861387
eNFA111_1_48861387 -.->|"ε"|eNFA111_2_37099307
eNFA111_1_48861387 -->|"m"|eNFA111_3_65458312
eNFA111_2_37099307 -->|"m"|eNFA111_3_65458312
eNFA111_3_65458312 -.->|"ε"|eNFA111_4_52253899
eNFA111_3_65458312 -->|"a"|eNFA111_5_523045
eNFA111_4_52253899 -->|"a"|eNFA111_5_523045
eNFA111_5_523045 -.->|"ε"|eNFA111_6_4707407
eNFA111_5_523045 -->|"t"|eNFA111_7_42366666
eNFA111_6_4707407 -->|"t"|eNFA111_7_42366666
eNFA111_7_42366666 -.->|"ε"|eNFA111_8_45755680
eNFA111_7_42366666 -->|"2"|eNFA111_9_9147936
eNFA111_8_45755680 -->|"2"|eNFA111_9_9147936
eNFA111_9_9147936 -.->|"ε"|eNFA111_10_15222565
eNFA111_9_9147936 -->|"x"|eNFA111_11_2785358
eNFA111_10_15222565 -->|"x"|eNFA111_11_2785358
eNFA111_11_2785358 -.->|"ε"|eNFA111_12_25068230
eNFA111_11_2785358 -->|"3"|eNFA111_13_24287485
eNFA111_12_25068230 -->|"3"|eNFA111_13_24287485
eNFA111_13_24287485 -.->|"ε"|eNFA111_15_17260781
eNFA111_13_24287485 -.->|"ε"|eNFA111_16_21129301
eNFA111_13_24287485 -.->|"ε"|eNFA111_17_55945983
eNFA111_15_17260781 -.->|"ε"|eNFA111_16_21129301
eNFA111_15_17260781 -.->|"ε"|eNFA111_17_55945983
eNFA111_16_21129301 -.->|"ε"|eNFA111_17_55945983
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
NFA111_14_33751805("NFA111-14 regex start")
NFA111_1_35330790("NFA111-1 char[1]")
NFA111_3_49541661("NFA111-3 char[1]")
NFA111_5_43221770("NFA111-5 char[1]")
NFA111_7_53451614("NFA111-7 char[1]")
NFA111_9_11302482("NFA111-9 char[1]")
NFA111_11_34613479("NFA111-11 char[1]")
NFA111_13_43085863[\"NFA111-13 char[1]"/]
NFA111_14_33751805 -->|"d"|NFA111_1_35330790
NFA111_1_35330790 -->|"m"|NFA111_3_49541661
NFA111_3_49541661 -->|"a"|NFA111_5_43221770
NFA111_5_43221770 -->|"t"|NFA111_7_53451614
NFA111_7_53451614 -->|"2"|NFA111_9_11302482
NFA111_9_11302482 -->|"x"|NFA111_11_34613479
NFA111_11_34613479 -->|"3"|NFA111_13_43085863
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
subgraph DFA0_-983099454["DFA0 regex start"]
NFA111_14_33751805_0("NFA111-14 regex start")
end
subgraph DFA1_-1722591900["DFA1 {1}"]
NFA111_1_35330790_1("NFA111-1 char[1]")
end
subgraph DFA2_-355638212["DFA2 {1}"]
NFA111_3_49541661_2("NFA111-3 char[1]")
end
subgraph DFA3_-1925040923["DFA3 {1}"]
NFA111_5_43221770_3("NFA111-5 char[1]")
end
subgraph DFA4_-1393852294["DFA4 {1}"]
NFA111_7_53451614_4("NFA111-7 char[1]")
end
subgraph DFA5_1732721888["DFA5 {1}"]
NFA111_9_11302482_5("NFA111-9 char[1]")
end
subgraph DFA6_1536702985["DFA6 {1}"]
NFA111_11_34613479_6("NFA111-11 char[1]")
end
subgraph DFA7_-419159707["DFA7 {1}"]
NFA111_13_43085863_7[\"NFA111-13 char[1]"/]
end
DFA0_-983099454 -->|"d"|DFA1_-1722591900
DFA1_-1722591900 -->|"m"|DFA2_-355638212
DFA2_-355638212 -->|"a"|DFA3_-1925040923
DFA3_-1925040923 -->|"t"|DFA4_-1393852294
DFA4_-1393852294 -->|"2"|DFA5_1732721888
DFA5_1732721888 -->|"x"|DFA6_1536702985
DFA6_1536702985 -->|"3"|DFA7_-419159707
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
DFA0_-983099454{{"DFA0 regex start"}}
DFA1_-1722591900{{"DFA1 {1}"}}
DFA2_-355638212{{"DFA2 {1}"}}
DFA3_-1925040923{{"DFA3 {1}"}}
DFA4_-1393852294{{"DFA4 {1}"}}
DFA5_1732721888{{"DFA5 {1}"}}
DFA6_1536702985{{"DFA6 {1}"}}
DFA7_-419159707[\"DFA7 {1}"/]
DFA0_-983099454 -->|"d"|DFA1_-1722591900
DFA1_-1722591900 -->|"m"|DFA2_-355638212
DFA2_-355638212 -->|"a"|DFA3_-1925040923
DFA3_-1925040923 -->|"t"|DFA4_-1393852294
DFA4_-1393852294 -->|"2"|DFA5_1732721888
DFA5_1732721888 -->|"x"|DFA6_1536702985
DFA6_1536702985 -->|"3"|DFA7_-419159707
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
subgraph MiniDFA0_-1034291235["MiniDFA0 {1}"]
DFA0_-983099454_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_684546569["MiniDFA1 {1}"]
DFA1_-1722591900_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1604262048["MiniDFA2 {1}"]
DFA2_-355638212_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1726929000["MiniDFA3 {1}"]
DFA3_-1925040923_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_677240749["MiniDFA4 {1}"]
DFA4_-1393852294_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1274004810["MiniDFA5 {1}"]
DFA5_1732721888_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_788716035["MiniDFA6 {1}"]
DFA6_1536702985_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1946807071["MiniDFA7 {1}"]
DFA7_-419159707_7[\"DFA7 {1}"/]
end
MiniDFA0_-1034291235 -->|"d"|MiniDFA1_684546569
MiniDFA1_684546569 -->|"m"|MiniDFA2_-1604262048
MiniDFA2_-1604262048 -->|"a"|MiniDFA3_1726929000
MiniDFA3_1726929000 -->|"t"|MiniDFA4_677240749
MiniDFA4_677240749 -->|"2"|MiniDFA5_-1274004810
MiniDFA5_-1274004810 -->|"x"|MiniDFA6_788716035
MiniDFA6_788716035 -->|"3"|MiniDFA7_-1946807071
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
MiniDFA0_-1034291235(["MiniDFA0 {1}"])
MiniDFA1_684546569(["MiniDFA1 {1}"])
MiniDFA2_-1604262048(["MiniDFA2 {1}"])
MiniDFA3_1726929000(["MiniDFA3 {1}"])
MiniDFA4_677240749(["MiniDFA4 {1}"])
MiniDFA5_-1274004810(["MiniDFA5 {1}"])
MiniDFA6_788716035(["MiniDFA6 {1}"])
MiniDFA7_-1946807071[\"MiniDFA7 {1}"/]
MiniDFA0_-1034291235 -->|"d"|MiniDFA1_684546569
MiniDFA1_684546569 -->|"m"|MiniDFA2_-1604262048
MiniDFA2_-1604262048 -->|"a"|MiniDFA3_1726929000
MiniDFA3_1726929000 -->|"t"|MiniDFA4_677240749
MiniDFA4_677240749 -->|"2"|MiniDFA5_-1274004810
MiniDFA5_-1274004810 -->|"x"|MiniDFA6_788716035
MiniDFA6_788716035 -->|"3"|MiniDFA7_-1946807071
```
-------------------------------
