# 'imageCube'

pattern: `imageCube`

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
eNFA172_18_28969880[["εNFA172-18 regex start"]]
eNFA172_0_59402334[["εNFA172-0 char{1, 1}"]]
eNFA172_1_64858964[["εNFA172-1 char[1]"]]
eNFA172_2_46859772[["εNFA172-2 char{1, 1}"]]
eNFA172_3_19084765[["εNFA172-3 char[1]"]]
eNFA172_4_37545162[["εNFA172-4 char{1, 1}"]]
eNFA172_5_2362138[["εNFA172-5 char[1]"]]
eNFA172_6_21259248[["εNFA172-6 char{1, 1}"]]
eNFA172_7_57115508[["εNFA172-7 char[1]"]]
eNFA172_8_44277527[["εNFA172-8 char{1, 1}"]]
eNFA172_9_62953426[["εNFA172-9 char[1]"]]
eNFA172_10_29709926[["εNFA172-10 char{1, 1}"]]
eNFA172_11_66062749[["εNFA172-11 char[1]"]]
eNFA172_12_57693830[["εNFA172-12 char{1, 1}"]]
eNFA172_13_49482428[["εNFA172-13 char[1]"]]
eNFA172_14_42688671[["εNFA172-14 char{1, 1}"]]
eNFA172_15_48653720[["εNFA172-15 char[1]"]]
eNFA172_16_35230296[["εNFA172-16 char{1, 1}"]]
eNFA172_17_48637208[["εNFA172-17 char[1]"]]
eNFA172_19_35081689[["εNFA172-19 regex end"]]
eNFA172_20_47299748[["εNFA172-20 post-regex start"]]
eNFA172_21_23044555[\"εNFA172-21 post-regex end"/]
eNFA172_18_28969880 -.->|"ε"|eNFA172_0_59402334
eNFA172_0_59402334 -->|"i"|eNFA172_1_64858964
eNFA172_1_64858964 -.->|"ε"|eNFA172_2_46859772
eNFA172_2_46859772 -->|"m"|eNFA172_3_19084765
eNFA172_3_19084765 -.->|"ε"|eNFA172_4_37545162
eNFA172_4_37545162 -->|"a"|eNFA172_5_2362138
eNFA172_5_2362138 -.->|"ε"|eNFA172_6_21259248
eNFA172_6_21259248 -->|"g"|eNFA172_7_57115508
eNFA172_7_57115508 -.->|"ε"|eNFA172_8_44277527
eNFA172_8_44277527 -->|"e"|eNFA172_9_62953426
eNFA172_9_62953426 -.->|"ε"|eNFA172_10_29709926
eNFA172_10_29709926 -->|"C"|eNFA172_11_66062749
eNFA172_11_66062749 -.->|"ε"|eNFA172_12_57693830
eNFA172_12_57693830 -->|"u"|eNFA172_13_49482428
eNFA172_13_49482428 -.->|"ε"|eNFA172_14_42688671
eNFA172_14_42688671 -->|"b"|eNFA172_15_48653720
eNFA172_15_48653720 -.->|"ε"|eNFA172_16_35230296
eNFA172_16_35230296 -->|"e"|eNFA172_17_48637208
eNFA172_17_48637208 -.->|"ε"|eNFA172_19_35081689
eNFA172_19_35081689 -.->|"ε"|eNFA172_20_47299748
eNFA172_20_47299748 -.->|"ε"|eNFA172_21_23044555
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
eNFA172_18_6074405[["εNFA172-18 regex start"]]
eNFA172_0_54669653[["εNFA172-0 char{1, 1}"]]
eNFA172_1_22264835[["εNFA172-1 char[1]"]]
eNFA172_2_66165792[["εNFA172-2 char{1, 1}"]]
eNFA172_3_58621221[["εNFA172-3 char[1]"]]
eNFA172_4_57828948[["εNFA172-4 char{1, 1}"]]
eNFA172_5_50698484[["εNFA172-5 char[1]"]]
eNFA172_6_53633175[["εNFA172-6 char{1, 1}"]]
eNFA172_7_12936535[["εNFA172-7 char[1]"]]
eNFA172_8_49319956[["εNFA172-8 char{1, 1}"]]
eNFA172_9_41226423[["εNFA172-9 char[1]"]]
eNFA172_10_35493489[["εNFA172-10 char{1, 1}"]]
eNFA172_11_51005947[["εNFA172-11 char[1]"]]
eNFA172_12_56400342[["εNFA172-12 char{1, 1}"]]
eNFA172_13_37841036[["εNFA172-13 char[1]"]]
eNFA172_14_5025004[["εNFA172-14 char{1, 1}"]]
eNFA172_15_45225041[["εNFA172-15 char[1]"]]
eNFA172_16_4372186[["εNFA172-16 char{1, 1}"]]
eNFA172_17_39349682[\"εNFA172-17 char[1]"/]
eNFA172_19_18602825[\"εNFA172-19 regex end"/]
eNFA172_20_33207705[\"εNFA172-20 post-regex start"/]
eNFA172_21_30433889[\"εNFA172-21 post-regex end"/]
eNFA172_18_6074405 -.->|"ε"|eNFA172_0_54669653
eNFA172_18_6074405 -->|"i"|eNFA172_1_22264835
eNFA172_0_54669653 -->|"i"|eNFA172_1_22264835
eNFA172_1_22264835 -.->|"ε"|eNFA172_2_66165792
eNFA172_1_22264835 -->|"m"|eNFA172_3_58621221
eNFA172_2_66165792 -->|"m"|eNFA172_3_58621221
eNFA172_3_58621221 -.->|"ε"|eNFA172_4_57828948
eNFA172_3_58621221 -->|"a"|eNFA172_5_50698484
eNFA172_4_57828948 -->|"a"|eNFA172_5_50698484
eNFA172_5_50698484 -.->|"ε"|eNFA172_6_53633175
eNFA172_5_50698484 -->|"g"|eNFA172_7_12936535
eNFA172_6_53633175 -->|"g"|eNFA172_7_12936535
eNFA172_7_12936535 -.->|"ε"|eNFA172_8_49319956
eNFA172_7_12936535 -->|"e"|eNFA172_9_41226423
eNFA172_8_49319956 -->|"e"|eNFA172_9_41226423
eNFA172_9_41226423 -.->|"ε"|eNFA172_10_35493489
eNFA172_9_41226423 -->|"C"|eNFA172_11_51005947
eNFA172_10_35493489 -->|"C"|eNFA172_11_51005947
eNFA172_11_51005947 -.->|"ε"|eNFA172_12_56400342
eNFA172_11_51005947 -->|"u"|eNFA172_13_37841036
eNFA172_12_56400342 -->|"u"|eNFA172_13_37841036
eNFA172_13_37841036 -.->|"ε"|eNFA172_14_5025004
eNFA172_13_37841036 -->|"b"|eNFA172_15_45225041
eNFA172_14_5025004 -->|"b"|eNFA172_15_45225041
eNFA172_15_45225041 -.->|"ε"|eNFA172_16_4372186
eNFA172_15_45225041 -->|"e"|eNFA172_17_39349682
eNFA172_16_4372186 -->|"e"|eNFA172_17_39349682
eNFA172_17_39349682 -.->|"ε"|eNFA172_19_18602825
eNFA172_17_39349682 -.->|"ε"|eNFA172_20_33207705
eNFA172_17_39349682 -.->|"ε"|eNFA172_21_30433889
eNFA172_19_18602825 -.->|"ε"|eNFA172_20_33207705
eNFA172_19_18602825 -.->|"ε"|eNFA172_21_30433889
eNFA172_20_33207705 -.->|"ε"|eNFA172_21_30433889
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
NFA172_18_5469547("NFA172-18 regex start")
NFA172_1_49225929("NFA172-1 char[1]")
NFA172_3_40380178("NFA172-3 char[1]")
NFA172_5_27877289("NFA172-5 char[1]")
NFA172_7_49569014("NFA172-7 char[1]")
NFA172_9_43467946("NFA172-9 char[1]")
NFA172_11_55667198("NFA172-11 char[1]")
NFA172_13_31242739("NFA172-13 char[1]")
NFA172_15_12749203("NFA172-15 char[1]")
NFA172_17_47633965[\"NFA172-17 char[1]"/]
NFA172_18_5469547 -->|"i"|NFA172_1_49225929
NFA172_1_49225929 -->|"m"|NFA172_3_40380178
NFA172_3_40380178 -->|"a"|NFA172_5_27877289
NFA172_5_27877289 -->|"g"|NFA172_7_49569014
NFA172_7_49569014 -->|"e"|NFA172_9_43467946
NFA172_9_43467946 -->|"C"|NFA172_11_55667198
NFA172_11_55667198 -->|"u"|NFA172_13_31242739
NFA172_13_31242739 -->|"b"|NFA172_15_12749203
NFA172_15_12749203 -->|"e"|NFA172_17_47633965
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
subgraph DFA0_-1180282142["DFA0 regex start"]
NFA172_18_5469547_0("NFA172-18 regex start")
end
subgraph DFA1_1667165405["DFA1 {1}"]
NFA172_1_49225929_1("NFA172-1 char[1]")
end
subgraph DFA2_-783915422["DFA2 {1}"]
NFA172_3_40380178_2("NFA172-3 char[1]")
end
subgraph DFA3_307271714["DFA3 {1}"]
NFA172_5_27877289_3("NFA172-5 char[1]")
end
subgraph DFA4_2078398905["DFA4 {1}"]
NFA172_7_49569014_4("NFA172-7 char[1]")
end
subgraph DFA5_-1335430717["DFA5 {1}"]
NFA172_9_43467946_5("NFA172-9 char[1]")
end
subgraph DFA6_880055364["DFA6 {1}"]
NFA172_11_55667198_6("NFA172-11 char[1]")
end
subgraph DFA7_1583399163["DFA7 {1}"]
NFA172_13_31242739_7("NFA172-13 char[1]")
end
subgraph DFA8_-1131163112["DFA8 {1}"]
NFA172_15_12749203_8("NFA172-15 char[1]")
end
subgraph DFA9_1689480676["DFA9 {1}"]
NFA172_17_47633965_9[\"NFA172-17 char[1]"/]
end
DFA0_-1180282142 -->|"i"|DFA1_1667165405
DFA1_1667165405 -->|"m"|DFA2_-783915422
DFA2_-783915422 -->|"a"|DFA3_307271714
DFA3_307271714 -->|"g"|DFA4_2078398905
DFA4_2078398905 -->|"e"|DFA5_-1335430717
DFA5_-1335430717 -->|"C"|DFA6_880055364
DFA6_880055364 -->|"u"|DFA7_1583399163
DFA7_1583399163 -->|"b"|DFA8_-1131163112
DFA8_-1131163112 -->|"e"|DFA9_1689480676
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
DFA0_-1180282142{{"DFA0 regex start"}}
DFA1_1667165405{{"DFA1 {1}"}}
DFA2_-783915422{{"DFA2 {1}"}}
DFA3_307271714{{"DFA3 {1}"}}
DFA4_2078398905{{"DFA4 {1}"}}
DFA5_-1335430717{{"DFA5 {1}"}}
DFA6_880055364{{"DFA6 {1}"}}
DFA7_1583399163{{"DFA7 {1}"}}
DFA8_-1131163112{{"DFA8 {1}"}}
DFA9_1689480676[\"DFA9 {1}"/]
DFA0_-1180282142 -->|"i"|DFA1_1667165405
DFA1_1667165405 -->|"m"|DFA2_-783915422
DFA2_-783915422 -->|"a"|DFA3_307271714
DFA3_307271714 -->|"g"|DFA4_2078398905
DFA4_2078398905 -->|"e"|DFA5_-1335430717
DFA5_-1335430717 -->|"C"|DFA6_880055364
DFA6_880055364 -->|"u"|DFA7_1583399163
DFA7_1583399163 -->|"b"|DFA8_-1131163112
DFA8_-1131163112 -->|"e"|DFA9_1689480676
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
subgraph MiniDFA0_275401182["MiniDFA0 {1}"]
DFA0_-1180282142_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-459391142["MiniDFA1 {1}"]
DFA1_1667165405_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-490648053["MiniDFA2 {1}"]
DFA2_-783915422_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-382510132["MiniDFA3 {1}"]
DFA3_307271714_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_422666453["MiniDFA4 {1}"]
DFA4_2078398905_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-886396465["MiniDFA5 {1}"]
DFA5_-1335430717_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-749903370["MiniDFA6 {1}"]
DFA6_880055364_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-456625655["MiniDFA7 {1}"]
DFA7_1583399163_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-162328457["MiniDFA8 {1}"]
DFA8_-1131163112_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_2010003770["MiniDFA9 {1}"]
DFA9_1689480676_9[\"DFA9 {1}"/]
end
MiniDFA0_275401182 -->|"i"|MiniDFA1_-459391142
MiniDFA1_-459391142 -->|"m"|MiniDFA2_-490648053
MiniDFA2_-490648053 -->|"a"|MiniDFA3_-382510132
MiniDFA3_-382510132 -->|"g"|MiniDFA4_422666453
MiniDFA4_422666453 -->|"e"|MiniDFA5_-886396465
MiniDFA5_-886396465 -->|"C"|MiniDFA6_-749903370
MiniDFA6_-749903370 -->|"u"|MiniDFA7_-456625655
MiniDFA7_-456625655 -->|"b"|MiniDFA8_-162328457
MiniDFA8_-162328457 -->|"e"|MiniDFA9_2010003770
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
MiniDFA0_275401182(["MiniDFA0 {1}"])
MiniDFA1_-459391142(["MiniDFA1 {1}"])
MiniDFA2_-490648053(["MiniDFA2 {1}"])
MiniDFA3_-382510132(["MiniDFA3 {1}"])
MiniDFA4_422666453(["MiniDFA4 {1}"])
MiniDFA5_-886396465(["MiniDFA5 {1}"])
MiniDFA6_-749903370(["MiniDFA6 {1}"])
MiniDFA7_-456625655(["MiniDFA7 {1}"])
MiniDFA8_-162328457(["MiniDFA8 {1}"])
MiniDFA9_2010003770[\"MiniDFA9 {1}"/]
MiniDFA0_275401182 -->|"i"|MiniDFA1_-459391142
MiniDFA1_-459391142 -->|"m"|MiniDFA2_-490648053
MiniDFA2_-490648053 -->|"a"|MiniDFA3_-382510132
MiniDFA3_-382510132 -->|"g"|MiniDFA4_422666453
MiniDFA4_422666453 -->|"e"|MiniDFA5_-886396465
MiniDFA5_-886396465 -->|"C"|MiniDFA6_-749903370
MiniDFA6_-749903370 -->|"u"|MiniDFA7_-456625655
MiniDFA7_-456625655 -->|"b"|MiniDFA8_-162328457
MiniDFA8_-162328457 -->|"e"|MiniDFA9_2010003770
```
-------------------------------
