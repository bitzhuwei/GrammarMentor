# 'isampler2D'

pattern: `isampler2D`

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
eNFA134_20_41495690[["εNFA134-20 regex start"]]
eNFA134_0_37916893[["εNFA134-0 char{1, 1}"]]
eNFA134_1_5707718[["εNFA134-1 char[1]"]]
eNFA134_2_51369462[["εNFA134-2 char{1, 1}"]]
eNFA134_3_59671974[["εNFA134-3 char[1]"]]
eNFA134_4_176855[["εNFA134-4 char{1, 1}"]]
eNFA134_5_1591698[["εNFA134-5 char[1]"]]
eNFA134_6_14325289[["εNFA134-6 char{1, 1}"]]
eNFA134_7_61818739[["εNFA134-7 char[1]"]]
eNFA134_8_19497747[["εNFA134-8 char{1, 1}"]]
eNFA134_9_41262001[["εNFA134-9 char[1]"]]
eNFA134_10_35813694[["εNFA134-10 char{1, 1}"]]
eNFA134_11_53887795[["εNFA134-11 char[1]"]]
eNFA134_12_15228114[["εNFA134-12 char{1, 1}"]]
eNFA134_13_2835298[["εNFA134-13 char[1]"]]
eNFA134_14_25517685[["εNFA134-14 char{1, 1}"]]
eNFA134_15_28332581[["εNFA134-15 char[1]"]]
eNFA134_16_53666642[["εNFA134-16 char{1, 1}"]]
eNFA134_17_13237733[["εNFA134-17 char[1]"]]
eNFA134_18_52030735[["εNFA134-18 char{1, 1}"]]
eNFA134_19_65623433[["εNFA134-19 char[1]"]]
eNFA134_21_53739988[["εNFA134-21 regex end"]]
eNFA134_22_13897850[["εNFA134-22 post-regex start"]]
eNFA134_23_57971786[\"εNFA134-23 post-regex end"/]
eNFA134_20_41495690 -.->|"ε"|eNFA134_0_37916893
eNFA134_0_37916893 -->|"i"|eNFA134_1_5707718
eNFA134_1_5707718 -.->|"ε"|eNFA134_2_51369462
eNFA134_2_51369462 -->|"s"|eNFA134_3_59671974
eNFA134_3_59671974 -.->|"ε"|eNFA134_4_176855
eNFA134_4_176855 -->|"a"|eNFA134_5_1591698
eNFA134_5_1591698 -.->|"ε"|eNFA134_6_14325289
eNFA134_6_14325289 -->|"m"|eNFA134_7_61818739
eNFA134_7_61818739 -.->|"ε"|eNFA134_8_19497747
eNFA134_8_19497747 -->|"p"|eNFA134_9_41262001
eNFA134_9_41262001 -.->|"ε"|eNFA134_10_35813694
eNFA134_10_35813694 -->|"l"|eNFA134_11_53887795
eNFA134_11_53887795 -.->|"ε"|eNFA134_12_15228114
eNFA134_12_15228114 -->|"e"|eNFA134_13_2835298
eNFA134_13_2835298 -.->|"ε"|eNFA134_14_25517685
eNFA134_14_25517685 -->|"r"|eNFA134_15_28332581
eNFA134_15_28332581 -.->|"ε"|eNFA134_16_53666642
eNFA134_16_53666642 -->|"2"|eNFA134_17_13237733
eNFA134_17_13237733 -.->|"ε"|eNFA134_18_52030735
eNFA134_18_52030735 -->|"D"|eNFA134_19_65623433
eNFA134_19_65623433 -.->|"ε"|eNFA134_21_53739988
eNFA134_21_53739988 -.->|"ε"|eNFA134_22_13897850
eNFA134_22_13897850 -.->|"ε"|eNFA134_23_57971786
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
eNFA134_20_51984031[["εNFA134-20 regex start"]]
eNFA134_0_65203096[["εNFA134-0 char{1, 1}"]]
eNFA134_1_49956960[["εNFA134-1 char[1]"]]
eNFA134_2_46959463[["εNFA134-2 char{1, 1}"]]
eNFA134_3_19981991[["εNFA134-3 char[1]"]]
eNFA134_4_45620191[["εNFA134-4 char{1, 1}"]]
eNFA134_5_7928537[["εNFA134-5 char[1]"]]
eNFA134_6_4247975[["εNFA134-6 char{1, 1}"]]
eNFA134_7_38231776[["εNFA134-7 char[1]"]]
eNFA134_8_8541671[["εNFA134-8 char{1, 1}"]]
eNFA134_9_9766180[["εNFA134-9 char[1]"]]
eNFA134_10_20786760[["εNFA134-10 char{1, 1}"]]
eNFA134_11_52863116[["εNFA134-11 char[1]"]]
eNFA134_12_6006001[["εNFA134-12 char{1, 1}"]]
eNFA134_13_54054017[["εNFA134-13 char[1]"]]
eNFA134_14_16724107[["εNFA134-14 char{1, 1}"]]
eNFA134_15_16299242[["εNFA134-15 char[1]"]]
eNFA134_16_12475454[["εNFA134-16 char{1, 1}"]]
eNFA134_17_45170224[["εNFA134-17 char[1]"]]
eNFA134_18_3878833[["εNFA134-18 char{1, 1}"]]
eNFA134_19_34909498[\"εNFA134-19 char[1]"/]
eNFA134_21_45750028[\"εNFA134-21 regex end"/]
eNFA134_22_9097072[\"εNFA134-22 post-regex start"/]
eNFA134_23_14764792[\"εNFA134-23 post-regex end"/]
eNFA134_20_51984031 -.->|"ε"|eNFA134_0_65203096
eNFA134_20_51984031 -->|"i"|eNFA134_1_49956960
eNFA134_0_65203096 -->|"i"|eNFA134_1_49956960
eNFA134_1_49956960 -.->|"ε"|eNFA134_2_46959463
eNFA134_1_49956960 -->|"s"|eNFA134_3_19981991
eNFA134_2_46959463 -->|"s"|eNFA134_3_19981991
eNFA134_3_19981991 -.->|"ε"|eNFA134_4_45620191
eNFA134_3_19981991 -->|"a"|eNFA134_5_7928537
eNFA134_4_45620191 -->|"a"|eNFA134_5_7928537
eNFA134_5_7928537 -.->|"ε"|eNFA134_6_4247975
eNFA134_5_7928537 -->|"m"|eNFA134_7_38231776
eNFA134_6_4247975 -->|"m"|eNFA134_7_38231776
eNFA134_7_38231776 -.->|"ε"|eNFA134_8_8541671
eNFA134_7_38231776 -->|"p"|eNFA134_9_9766180
eNFA134_8_8541671 -->|"p"|eNFA134_9_9766180
eNFA134_9_9766180 -.->|"ε"|eNFA134_10_20786760
eNFA134_9_9766180 -->|"l"|eNFA134_11_52863116
eNFA134_10_20786760 -->|"l"|eNFA134_11_52863116
eNFA134_11_52863116 -.->|"ε"|eNFA134_12_6006001
eNFA134_11_52863116 -->|"e"|eNFA134_13_54054017
eNFA134_12_6006001 -->|"e"|eNFA134_13_54054017
eNFA134_13_54054017 -.->|"ε"|eNFA134_14_16724107
eNFA134_13_54054017 -->|"r"|eNFA134_15_16299242
eNFA134_14_16724107 -->|"r"|eNFA134_15_16299242
eNFA134_15_16299242 -.->|"ε"|eNFA134_16_12475454
eNFA134_15_16299242 -->|"2"|eNFA134_17_45170224
eNFA134_16_12475454 -->|"2"|eNFA134_17_45170224
eNFA134_17_45170224 -.->|"ε"|eNFA134_18_3878833
eNFA134_17_45170224 -->|"D"|eNFA134_19_34909498
eNFA134_18_3878833 -->|"D"|eNFA134_19_34909498
eNFA134_19_34909498 -.->|"ε"|eNFA134_21_45750028
eNFA134_19_34909498 -.->|"ε"|eNFA134_22_9097072
eNFA134_19_34909498 -.->|"ε"|eNFA134_23_14764792
eNFA134_21_45750028 -.->|"ε"|eNFA134_22_9097072
eNFA134_21_45750028 -.->|"ε"|eNFA134_23_14764792
eNFA134_22_9097072 -.->|"ε"|eNFA134_23_14764792
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
NFA134_20_65774268("NFA134-20 regex start")
NFA134_1_55097500("NFA134-1 char[1]")
NFA134_3_26115459("NFA134-3 char[1]")
NFA134_5_33712545("NFA134-5 char[1]")
NFA134_7_34977455("NFA134-7 char[1]")
NFA134_9_46361647("NFA134-9 char[1]")
NFA134_11_14601640("NFA134-11 char[1]")
NFA134_13_64305901("NFA134-13 char[1]")
NFA134_15_41882197("NFA134-15 char[1]")
NFA134_17_41395459("NFA134-17 char[1]")
NFA134_19_37014815[\"NFA134-19 char[1]"/]
NFA134_20_65774268 -->|"i"|NFA134_1_55097500
NFA134_1_55097500 -->|"s"|NFA134_3_26115459
NFA134_3_26115459 -->|"a"|NFA134_5_33712545
NFA134_5_33712545 -->|"m"|NFA134_7_34977455
NFA134_7_34977455 -->|"p"|NFA134_9_46361647
NFA134_9_46361647 -->|"l"|NFA134_11_14601640
NFA134_11_14601640 -->|"e"|NFA134_13_64305901
NFA134_13_64305901 -->|"r"|NFA134_15_41882197
NFA134_15_41882197 -->|"2"|NFA134_17_41395459
NFA134_17_41395459 -->|"D"|NFA134_19_37014815
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
subgraph DFA0_629019127["DFA0 regex start"]
NFA134_20_65774268_0("NFA134-20 regex start")
end
subgraph DFA1_1151216059["DFA1 {1}"]
NFA134_1_55097500_1("NFA134-1 char[1]")
end
subgraph DFA2_115503934["DFA2 {1}"]
NFA134_3_26115459_2("NFA134-3 char[1]")
end
subgraph DFA3_-553323402["DFA3 {1}"]
NFA134_5_33712545_3("NFA134-5 char[1]")
end
subgraph DFA4_275079582["DFA4 {1}"]
NFA134_7_34977455_4("NFA134-7 char[1]")
end
subgraph DFA5_-1775973["DFA5 {1}"]
NFA134_9_46361647_5("NFA134-9 char[1]")
end
subgraph DFA6_686807483["DFA6 {1}"]
NFA134_11_14601640_6("NFA134-11 char[1]")
end
subgraph DFA7_-745266114["DFA7 {1}"]
NFA134_13_64305901_7("NFA134-13 char[1]")
end
subgraph DFA8_-79482475["DFA8 {1}"]
NFA134_15_41882197_8("NFA134-15 char[1]")
end
subgraph DFA9_-828751645["DFA9 {1}"]
NFA134_17_41395459_9("NFA134-17 char[1]")
end
subgraph DFA10_-1314528590["DFA10 {1}"]
NFA134_19_37014815_10[\"NFA134-19 char[1]"/]
end
DFA0_629019127 -->|"i"|DFA1_1151216059
DFA1_1151216059 -->|"s"|DFA2_115503934
DFA2_115503934 -->|"a"|DFA3_-553323402
DFA3_-553323402 -->|"m"|DFA4_275079582
DFA4_275079582 -->|"p"|DFA5_-1775973
DFA5_-1775973 -->|"l"|DFA6_686807483
DFA6_686807483 -->|"e"|DFA7_-745266114
DFA7_-745266114 -->|"r"|DFA8_-79482475
DFA8_-79482475 -->|"2"|DFA9_-828751645
DFA9_-828751645 -->|"D"|DFA10_-1314528590
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
DFA0_629019127{{"DFA0 regex start"}}
DFA1_1151216059{{"DFA1 {1}"}}
DFA2_115503934{{"DFA2 {1}"}}
DFA3_-553323402{{"DFA3 {1}"}}
DFA4_275079582{{"DFA4 {1}"}}
DFA5_-1775973{{"DFA5 {1}"}}
DFA6_686807483{{"DFA6 {1}"}}
DFA7_-745266114{{"DFA7 {1}"}}
DFA8_-79482475{{"DFA8 {1}"}}
DFA9_-828751645{{"DFA9 {1}"}}
DFA10_-1314528590[\"DFA10 {1}"/]
DFA0_629019127 -->|"i"|DFA1_1151216059
DFA1_1151216059 -->|"s"|DFA2_115503934
DFA2_115503934 -->|"a"|DFA3_-553323402
DFA3_-553323402 -->|"m"|DFA4_275079582
DFA4_275079582 -->|"p"|DFA5_-1775973
DFA5_-1775973 -->|"l"|DFA6_686807483
DFA6_686807483 -->|"e"|DFA7_-745266114
DFA7_-745266114 -->|"r"|DFA8_-79482475
DFA8_-79482475 -->|"2"|DFA9_-828751645
DFA9_-828751645 -->|"D"|DFA10_-1314528590
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
subgraph MiniDFA0_840711658["MiniDFA0 {1}"]
DFA0_629019127_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_903435828["MiniDFA1 {1}"]
DFA1_1151216059_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1487599755["MiniDFA2 {1}"]
DFA2_115503934_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1123444674["MiniDFA3 {1}"]
DFA3_-553323402_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_706922318["MiniDFA4 {1}"]
DFA4_275079582_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1625042625["MiniDFA5 {1}"]
DFA5_-1775973_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1698663268["MiniDFA6 {1}"]
DFA6_686807483_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_391914652["MiniDFA7 {1}"]
DFA7_-745266114_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1210859062["MiniDFA8 {1}"]
DFA8_-79482475_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_1784495014["MiniDFA9 {1}"]
DFA9_-828751645_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-597900011["MiniDFA10 {1}"]
DFA10_-1314528590_10[\"DFA10 {1}"/]
end
MiniDFA0_840711658 -->|"i"|MiniDFA1_903435828
MiniDFA1_903435828 -->|"s"|MiniDFA2_-1487599755
MiniDFA2_-1487599755 -->|"a"|MiniDFA3_-1123444674
MiniDFA3_-1123444674 -->|"m"|MiniDFA4_706922318
MiniDFA4_706922318 -->|"p"|MiniDFA5_-1625042625
MiniDFA5_-1625042625 -->|"l"|MiniDFA6_1698663268
MiniDFA6_1698663268 -->|"e"|MiniDFA7_391914652
MiniDFA7_391914652 -->|"r"|MiniDFA8_1210859062
MiniDFA8_1210859062 -->|"2"|MiniDFA9_1784495014
MiniDFA9_1784495014 -->|"D"|MiniDFA10_-597900011
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
MiniDFA0_840711658(["MiniDFA0 {1}"])
MiniDFA1_903435828(["MiniDFA1 {1}"])
MiniDFA2_-1487599755(["MiniDFA2 {1}"])
MiniDFA3_-1123444674(["MiniDFA3 {1}"])
MiniDFA4_706922318(["MiniDFA4 {1}"])
MiniDFA5_-1625042625(["MiniDFA5 {1}"])
MiniDFA6_1698663268(["MiniDFA6 {1}"])
MiniDFA7_391914652(["MiniDFA7 {1}"])
MiniDFA8_1210859062(["MiniDFA8 {1}"])
MiniDFA9_1784495014(["MiniDFA9 {1}"])
MiniDFA10_-597900011[\"MiniDFA10 {1}"/]
MiniDFA0_840711658 -->|"i"|MiniDFA1_903435828
MiniDFA1_903435828 -->|"s"|MiniDFA2_-1487599755
MiniDFA2_-1487599755 -->|"a"|MiniDFA3_-1123444674
MiniDFA3_-1123444674 -->|"m"|MiniDFA4_706922318
MiniDFA4_706922318 -->|"p"|MiniDFA5_-1625042625
MiniDFA5_-1625042625 -->|"l"|MiniDFA6_1698663268
MiniDFA6_1698663268 -->|"e"|MiniDFA7_391914652
MiniDFA7_391914652 -->|"r"|MiniDFA8_1210859062
MiniDFA8_1210859062 -->|"2"|MiniDFA9_1784495014
MiniDFA9_1784495014 -->|"D"|MiniDFA10_-597900011
```
-------------------------------
