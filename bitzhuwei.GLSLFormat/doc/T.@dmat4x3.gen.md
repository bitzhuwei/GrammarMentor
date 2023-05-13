# 'dmat4x3'

pattern: `dmat4x3`

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
eNFA117_14_1026023[["εNFA117-14 regex start"]]
eNFA117_0_9234211[["εNFA117-0 char{1, 1}"]]
eNFA117_1_15999035[["εNFA117-1 char[1]"]]
eNFA117_2_9773594[["εNFA117-2 char{1, 1}"]]
eNFA117_3_20853488[["εNFA117-3 char[1]"]]
eNFA117_4_53463670[["εNFA117-4 char{1, 1}"]]
eNFA117_5_11410990[["εNFA117-5 char[1]"]]
eNFA117_6_35590047[["εNFA117-6 char{1, 1}"]]
eNFA117_7_51874972[["εNFA117-7 char[1]"]]
eNFA117_8_64221564[["εNFA117-8 char{1, 1}"]]
eNFA117_9_41123170[["εNFA117-9 char[1]"]]
eNFA117_10_34564214[["εNFA117-10 char{1, 1}"]]
eNFA117_11_42642473[["εNFA117-11 char[1]"]]
eNFA117_12_48237940[["εNFA117-12 char{1, 1}"]]
eNFA117_13_31488280[["εNFA117-13 char[1]"]]
eNFA117_15_14959071[["εNFA117-15 regex end"]]
eNFA117_16_413912[["εNFA117-16 post-regex start"]]
eNFA117_17_3725214[\"εNFA117-17 post-regex end"/]
eNFA117_14_1026023 -.->|"ε"|eNFA117_0_9234211
eNFA117_0_9234211 -->|"d"|eNFA117_1_15999035
eNFA117_1_15999035 -.->|"ε"|eNFA117_2_9773594
eNFA117_2_9773594 -->|"m"|eNFA117_3_20853488
eNFA117_3_20853488 -.->|"ε"|eNFA117_4_53463670
eNFA117_4_53463670 -->|"a"|eNFA117_5_11410990
eNFA117_5_11410990 -.->|"ε"|eNFA117_6_35590047
eNFA117_6_35590047 -->|"t"|eNFA117_7_51874972
eNFA117_7_51874972 -.->|"ε"|eNFA117_8_64221564
eNFA117_8_64221564 -->|"4"|eNFA117_9_41123170
eNFA117_9_41123170 -.->|"ε"|eNFA117_10_34564214
eNFA117_10_34564214 -->|"x"|eNFA117_11_42642473
eNFA117_11_42642473 -.->|"ε"|eNFA117_12_48237940
eNFA117_12_48237940 -->|"3"|eNFA117_13_31488280
eNFA117_13_31488280 -.->|"ε"|eNFA117_15_14959071
eNFA117_15_14959071 -.->|"ε"|eNFA117_16_413912
eNFA117_16_413912 -.->|"ε"|eNFA117_17_3725214
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
eNFA117_14_33526929[["εNFA117-14 regex start"]]
eNFA117_0_33306906[["εNFA117-0 char{1, 1}"]]
eNFA117_1_31326698[["εNFA117-1 char[1]"]]
eNFA117_2_13504826[["εNFA117-2 char{1, 1}"]]
eNFA117_3_54434571[["εNFA117-3 char[1]"]]
eNFA117_4_20149094[["εNFA117-4 char{1, 1}"]]
eNFA117_5_47124125[["εNFA117-5 char[1]"]]
eNFA117_6_21463943[["εNFA117-6 char{1, 1}"]]
eNFA117_7_58957767[["εNFA117-7 char[1]"]]
eNFA117_8_60857861[["εNFA117-8 char{1, 1}"]]
eNFA117_9_10849842[["εNFA117-9 char[1]"]]
eNFA117_10_30539719[["εNFA117-10 char{1, 1}"]]
eNFA117_11_6422022[["εNFA117-11 char[1]"]]
eNFA117_12_57798198[["εNFA117-12 char{1, 1}"]]
eNFA117_13_50421737[\"εNFA117-13 char[1]"/]
eNFA117_15_51142457[\"εNFA117-15 regex end"/]
eNFA117_16_57628934[\"εNFA117-16 post-regex start"/]
eNFA117_17_48898361[\"εNFA117-17 post-regex end"/]
eNFA117_14_33526929 -.->|"ε"|eNFA117_0_33306906
eNFA117_14_33526929 -->|"d"|eNFA117_1_31326698
eNFA117_0_33306906 -->|"d"|eNFA117_1_31326698
eNFA117_1_31326698 -.->|"ε"|eNFA117_2_13504826
eNFA117_1_31326698 -->|"m"|eNFA117_3_54434571
eNFA117_2_13504826 -->|"m"|eNFA117_3_54434571
eNFA117_3_54434571 -.->|"ε"|eNFA117_4_20149094
eNFA117_3_54434571 -->|"a"|eNFA117_5_47124125
eNFA117_4_20149094 -->|"a"|eNFA117_5_47124125
eNFA117_5_47124125 -.->|"ε"|eNFA117_6_21463943
eNFA117_5_47124125 -->|"t"|eNFA117_7_58957767
eNFA117_6_21463943 -->|"t"|eNFA117_7_58957767
eNFA117_7_58957767 -.->|"ε"|eNFA117_8_60857861
eNFA117_7_58957767 -->|"4"|eNFA117_9_10849842
eNFA117_8_60857861 -->|"4"|eNFA117_9_10849842
eNFA117_9_10849842 -.->|"ε"|eNFA117_10_30539719
eNFA117_9_10849842 -->|"x"|eNFA117_11_6422022
eNFA117_10_30539719 -->|"x"|eNFA117_11_6422022
eNFA117_11_6422022 -.->|"ε"|eNFA117_12_57798198
eNFA117_11_6422022 -->|"3"|eNFA117_13_50421737
eNFA117_12_57798198 -->|"3"|eNFA117_13_50421737
eNFA117_13_50421737 -.->|"ε"|eNFA117_15_51142457
eNFA117_13_50421737 -.->|"ε"|eNFA117_16_57628934
eNFA117_13_50421737 -.->|"ε"|eNFA117_17_48898361
eNFA117_15_51142457 -.->|"ε"|eNFA117_16_57628934
eNFA117_15_51142457 -.->|"ε"|eNFA117_17_48898361
eNFA117_16_57628934 -.->|"ε"|eNFA117_17_48898361
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
NFA117_14_37432067("NFA117-14 regex start")
NFA117_1_1344285("NFA117-1 char[1]")
NFA117_3_12098568("NFA117-3 char[1]")
NFA117_5_41778254("NFA117-5 char[1]")
NFA117_7_40459966("NFA117-7 char[1]")
NFA117_9_28595379("NFA117-9 char[1]")
NFA117_11_56031820("NFA117-11 char[1]")
NFA117_13_34524340[\"NFA117-13 char[1]"/]
NFA117_14_37432067 -->|"d"|NFA117_1_1344285
NFA117_1_1344285 -->|"m"|NFA117_3_12098568
NFA117_3_12098568 -->|"a"|NFA117_5_41778254
NFA117_5_41778254 -->|"t"|NFA117_7_40459966
NFA117_7_40459966 -->|"4"|NFA117_9_28595379
NFA117_9_28595379 -->|"x"|NFA117_11_56031820
NFA117_11_56031820 -->|"3"|NFA117_13_34524340
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
subgraph DFA0_-646499736["DFA0 regex start"]
NFA117_14_37432067_0("NFA117-14 regex start")
end
subgraph DFA1_-634977928["DFA1 {1}"]
NFA117_1_1344285_1("NFA117-1 char[1]")
end
subgraph DFA2_907324192["DFA2 {1}"]
NFA117_3_12098568_2("NFA117-3 char[1]")
end
subgraph DFA3_-2149754["DFA3 {1}"]
NFA117_5_41778254_3("NFA117-5 char[1]")
end
subgraph DFA4_-1067697436["DFA4 {1}"]
NFA117_7_40459966_4("NFA117-7 char[1]")
end
subgraph DFA5_-1535830827["DFA5 {1}"]
NFA117_9_28595379_5("NFA117-9 char[1]")
end
subgraph DFA6_-247270676["DFA6 {1}"]
NFA117_11_56031820_6("NFA117-11 char[1]")
end
subgraph DFA7_685493958["DFA7 {1}"]
NFA117_13_34524340_7[\"NFA117-13 char[1]"/]
end
DFA0_-646499736 -->|"d"|DFA1_-634977928
DFA1_-634977928 -->|"m"|DFA2_907324192
DFA2_907324192 -->|"a"|DFA3_-2149754
DFA3_-2149754 -->|"t"|DFA4_-1067697436
DFA4_-1067697436 -->|"4"|DFA5_-1535830827
DFA5_-1535830827 -->|"x"|DFA6_-247270676
DFA6_-247270676 -->|"3"|DFA7_685493958
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
DFA0_-646499736{{"DFA0 regex start"}}
DFA1_-634977928{{"DFA1 {1}"}}
DFA2_907324192{{"DFA2 {1}"}}
DFA3_-2149754{{"DFA3 {1}"}}
DFA4_-1067697436{{"DFA4 {1}"}}
DFA5_-1535830827{{"DFA5 {1}"}}
DFA6_-247270676{{"DFA6 {1}"}}
DFA7_685493958[\"DFA7 {1}"/]
DFA0_-646499736 -->|"d"|DFA1_-634977928
DFA1_-634977928 -->|"m"|DFA2_907324192
DFA2_907324192 -->|"a"|DFA3_-2149754
DFA3_-2149754 -->|"t"|DFA4_-1067697436
DFA4_-1067697436 -->|"4"|DFA5_-1535830827
DFA5_-1535830827 -->|"x"|DFA6_-247270676
DFA6_-247270676 -->|"3"|DFA7_685493958
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
subgraph MiniDFA0_-1438988935["MiniDFA0 {1}"]
DFA0_-646499736_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1862424188["MiniDFA1 {1}"]
DFA1_-634977928_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1545654871["MiniDFA2 {1}"]
DFA2_907324192_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1256437202["MiniDFA3 {1}"]
DFA3_-2149754_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_2009543539["MiniDFA4 {1}"]
DFA4_-1067697436_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-384112760["MiniDFA5 {1}"]
DFA5_-1535830827_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1401539731["MiniDFA6 {1}"]
DFA6_-247270676_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_863548948["MiniDFA7 {1}"]
DFA7_685493958_7[\"DFA7 {1}"/]
end
MiniDFA0_-1438988935 -->|"d"|MiniDFA1_-1862424188
MiniDFA1_-1862424188 -->|"m"|MiniDFA2_1545654871
MiniDFA2_1545654871 -->|"a"|MiniDFA3_-1256437202
MiniDFA3_-1256437202 -->|"t"|MiniDFA4_2009543539
MiniDFA4_2009543539 -->|"4"|MiniDFA5_-384112760
MiniDFA5_-384112760 -->|"x"|MiniDFA6_1401539731
MiniDFA6_1401539731 -->|"3"|MiniDFA7_863548948
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
MiniDFA0_-1438988935(["MiniDFA0 {1}"])
MiniDFA1_-1862424188(["MiniDFA1 {1}"])
MiniDFA2_1545654871(["MiniDFA2 {1}"])
MiniDFA3_-1256437202(["MiniDFA3 {1}"])
MiniDFA4_2009543539(["MiniDFA4 {1}"])
MiniDFA5_-384112760(["MiniDFA5 {1}"])
MiniDFA6_1401539731(["MiniDFA6 {1}"])
MiniDFA7_863548948[\"MiniDFA7 {1}"/]
MiniDFA0_-1438988935 -->|"d"|MiniDFA1_-1862424188
MiniDFA1_-1862424188 -->|"m"|MiniDFA2_1545654871
MiniDFA2_1545654871 -->|"a"|MiniDFA3_-1256437202
MiniDFA3_-1256437202 -->|"t"|MiniDFA4_2009543539
MiniDFA4_2009543539 -->|"4"|MiniDFA5_-384112760
MiniDFA5_-384112760 -->|"x"|MiniDFA6_1401539731
MiniDFA6_1401539731 -->|"3"|MiniDFA7_863548948
```
-------------------------------
