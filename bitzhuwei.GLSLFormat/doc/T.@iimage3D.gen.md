# 'iimage3D'

pattern: `iimage3D`

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
eNFA167_16_61244824[["εNFA167-16 regex start"]]
eNFA167_0_14332509[["εNFA167-0 char{1, 1}"]]
eNFA167_1_61883722[["εNFA167-1 char[1]"]]
eNFA167_2_20082593[["εNFA167-2 char{1, 1}"]]
eNFA167_3_46525609[["εNFA167-3 char[1]"]]
eNFA167_4_16077300[["εNFA167-4 char{1, 1}"]]
eNFA167_5_10477980[["εNFA167-5 char[1]"]]
eNFA167_6_27192961[["εNFA167-6 char{1, 1}"]]
eNFA167_7_43410060[["εNFA167-7 char[1]"]]
eNFA167_8_55146222[["εNFA167-8 char{1, 1}"]]
eNFA167_9_26553952[["εNFA167-9 char[1]"]]
eNFA167_10_37658979[["εNFA167-10 char{1, 1}"]]
eNFA167_11_3386497[["εNFA167-11 char[1]"]]
eNFA167_12_30478473[["εNFA167-12 char{1, 1}"]]
eNFA167_13_5870806[["εNFA167-13 char[1]"]]
eNFA167_14_52837255[["εNFA167-14 char{1, 1}"]]
eNFA167_15_5773255[["εNFA167-15 char[1]"]]
eNFA167_17_51959302[["εNFA167-17 regex end"]]
eNFA167_18_64980542[["εNFA167-18 post-regex start"]]
eNFA167_19_47953966[\"εNFA167-19 post-regex end"/]
eNFA167_16_61244824 -.->|"ε"|eNFA167_0_14332509
eNFA167_0_14332509 -->|"i"|eNFA167_1_61883722
eNFA167_1_61883722 -.->|"ε"|eNFA167_2_20082593
eNFA167_2_20082593 -->|"i"|eNFA167_3_46525609
eNFA167_3_46525609 -.->|"ε"|eNFA167_4_16077300
eNFA167_4_16077300 -->|"m"|eNFA167_5_10477980
eNFA167_5_10477980 -.->|"ε"|eNFA167_6_27192961
eNFA167_6_27192961 -->|"a"|eNFA167_7_43410060
eNFA167_7_43410060 -.->|"ε"|eNFA167_8_55146222
eNFA167_8_55146222 -->|"g"|eNFA167_9_26553952
eNFA167_9_26553952 -.->|"ε"|eNFA167_10_37658979
eNFA167_10_37658979 -->|"e"|eNFA167_11_3386497
eNFA167_11_3386497 -.->|"ε"|eNFA167_12_30478473
eNFA167_12_30478473 -->|"3"|eNFA167_13_5870806
eNFA167_13_5870806 -.->|"ε"|eNFA167_14_52837255
eNFA167_14_52837255 -->|"D"|eNFA167_15_5773255
eNFA167_15_5773255 -.->|"ε"|eNFA167_17_51959302
eNFA167_17_51959302 -.->|"ε"|eNFA167_18_64980542
eNFA167_18_64980542 -.->|"ε"|eNFA167_19_47953966
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
eNFA167_16_28932512[["εNFA167-16 regex start"]]
eNFA167_0_59066022[["εNFA167-0 char{1, 1}"]]
eNFA167_1_61832151[["εNFA167-1 char[1]"]]
eNFA167_2_19618454[["εNFA167-2 char{1, 1}"]]
eNFA167_3_42348363[["εNFA167-3 char[1]"]]
eNFA167_4_45590951[["εNFA167-4 char{1, 1}"]]
eNFA167_5_7665379[["εNFA167-5 char[1]"]]
eNFA167_6_1879552[["εNFA167-6 char{1, 1}"]]
eNFA167_7_16915976[["εNFA167-7 char[1]"]]
eNFA167_8_18026058[["εNFA167-8 char{1, 1}"]]
eNFA167_9_28016801[["εNFA167-9 char[1]"]]
eNFA167_10_50824621[["εNFA167-10 char{1, 1}"]]
eNFA167_11_54768407[["εNFA167-11 char[1]"]]
eNFA167_12_23153616[["εNFA167-12 char{1, 1}"]]
eNFA167_13_7055953[["εNFA167-13 char[1]"]]
eNFA167_14_63503579[["εNFA167-14 char{1, 1}"]]
eNFA167_15_34661303[\"εNFA167-15 char[1]"/]
eNFA167_17_43516279[\"εNFA167-17 regex end"/]
eNFA167_18_56102195[\"εNFA167-18 post-regex start"/]
eNFA167_19_35157707[\"εNFA167-19 post-regex end"/]
eNFA167_16_28932512 -.->|"ε"|eNFA167_0_59066022
eNFA167_16_28932512 -->|"i"|eNFA167_1_61832151
eNFA167_0_59066022 -->|"i"|eNFA167_1_61832151
eNFA167_1_61832151 -.->|"ε"|eNFA167_2_19618454
eNFA167_1_61832151 -->|"i"|eNFA167_3_42348363
eNFA167_2_19618454 -->|"i"|eNFA167_3_42348363
eNFA167_3_42348363 -.->|"ε"|eNFA167_4_45590951
eNFA167_3_42348363 -->|"m"|eNFA167_5_7665379
eNFA167_4_45590951 -->|"m"|eNFA167_5_7665379
eNFA167_5_7665379 -.->|"ε"|eNFA167_6_1879552
eNFA167_5_7665379 -->|"a"|eNFA167_7_16915976
eNFA167_6_1879552 -->|"a"|eNFA167_7_16915976
eNFA167_7_16915976 -.->|"ε"|eNFA167_8_18026058
eNFA167_7_16915976 -->|"g"|eNFA167_9_28016801
eNFA167_8_18026058 -->|"g"|eNFA167_9_28016801
eNFA167_9_28016801 -.->|"ε"|eNFA167_10_50824621
eNFA167_9_28016801 -->|"e"|eNFA167_11_54768407
eNFA167_10_50824621 -->|"e"|eNFA167_11_54768407
eNFA167_11_54768407 -.->|"ε"|eNFA167_12_23153616
eNFA167_11_54768407 -->|"3"|eNFA167_13_7055953
eNFA167_12_23153616 -->|"3"|eNFA167_13_7055953
eNFA167_13_7055953 -.->|"ε"|eNFA167_14_63503579
eNFA167_13_7055953 -->|"D"|eNFA167_15_34661303
eNFA167_14_63503579 -->|"D"|eNFA167_15_34661303
eNFA167_15_34661303 -.->|"ε"|eNFA167_17_43516279
eNFA167_15_34661303 -.->|"ε"|eNFA167_18_56102195
eNFA167_15_34661303 -.->|"ε"|eNFA167_19_35157707
eNFA167_17_43516279 -.->|"ε"|eNFA167_18_56102195
eNFA167_17_43516279 -.->|"ε"|eNFA167_19_35157707
eNFA167_18_56102195 -.->|"ε"|eNFA167_19_35157707
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
NFA167_16_47983914("NFA167-16 regex start")
NFA167_1_29202048("NFA167-1 char[1]")
NFA167_3_61491846("NFA167-3 char[1]")
NFA167_5_16555710("NFA167-5 char[1]")
NFA167_7_14783663("NFA167-7 char[1]")
NFA167_9_65944108("NFA167-9 char[1]")
NFA167_11_56626060("NFA167-11 char[1]")
NFA167_13_39872498("NFA167-13 char[1]")
NFA167_15_23308166[\"NFA167-15 char[1]"/]
NFA167_16_47983914 -->|"i"|NFA167_1_29202048
NFA167_1_29202048 -->|"i"|NFA167_3_61491846
NFA167_3_61491846 -->|"m"|NFA167_5_16555710
NFA167_5_16555710 -->|"a"|NFA167_7_14783663
NFA167_7_14783663 -->|"g"|NFA167_9_65944108
NFA167_9_65944108 -->|"e"|NFA167_11_56626060
NFA167_11_56626060 -->|"3"|NFA167_13_39872498
NFA167_13_39872498 -->|"D"|NFA167_15_23308166
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
subgraph DFA0_218119197["DFA0 regex start"]
NFA167_16_47983914_0("NFA167-16 regex start")
end
subgraph DFA1_-534696056["DFA1 {1}"]
NFA167_1_29202048_1("NFA167-1 char[1]")
end
subgraph DFA2_-824982610["DFA2 {1}"]
NFA167_3_61491846_2("NFA167-3 char[1]")
end
subgraph DFA3_-706319198["DFA3 {1}"]
NFA167_5_16555710_3("NFA167-5 char[1]")
end
subgraph DFA4_-41433768["DFA4 {1}"]
NFA167_7_14783663_4("NFA167-7 char[1]")
end
subgraph DFA5_727456002["DFA5 {1}"]
NFA167_9_65944108_5("NFA167-9 char[1]")
end
subgraph DFA6_708612885["DFA6 {1}"]
NFA167_11_56626060_6("NFA167-11 char[1]")
end
subgraph DFA7_740729206["DFA7 {1}"]
NFA167_13_39872498_7("NFA167-13 char[1]")
end
subgraph DFA8_536574535["DFA8 {1}"]
NFA167_15_23308166_8[\"NFA167-15 char[1]"/]
end
DFA0_218119197 -->|"i"|DFA1_-534696056
DFA1_-534696056 -->|"i"|DFA2_-824982610
DFA2_-824982610 -->|"m"|DFA3_-706319198
DFA3_-706319198 -->|"a"|DFA4_-41433768
DFA4_-41433768 -->|"g"|DFA5_727456002
DFA5_727456002 -->|"e"|DFA6_708612885
DFA6_708612885 -->|"3"|DFA7_740729206
DFA7_740729206 -->|"D"|DFA8_536574535
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
DFA0_218119197{{"DFA0 regex start"}}
DFA1_-534696056{{"DFA1 {1}"}}
DFA2_-824982610{{"DFA2 {1}"}}
DFA3_-706319198{{"DFA3 {1}"}}
DFA4_-41433768{{"DFA4 {1}"}}
DFA5_727456002{{"DFA5 {1}"}}
DFA6_708612885{{"DFA6 {1}"}}
DFA7_740729206{{"DFA7 {1}"}}
DFA8_536574535[\"DFA8 {1}"/]
DFA0_218119197 -->|"i"|DFA1_-534696056
DFA1_-534696056 -->|"i"|DFA2_-824982610
DFA2_-824982610 -->|"m"|DFA3_-706319198
DFA3_-706319198 -->|"a"|DFA4_-41433768
DFA4_-41433768 -->|"g"|DFA5_727456002
DFA5_727456002 -->|"e"|DFA6_708612885
DFA6_708612885 -->|"3"|DFA7_740729206
DFA7_740729206 -->|"D"|DFA8_536574535
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
subgraph MiniDFA0_-263927472["MiniDFA0 {1}"]
DFA0_218119197_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1634009154["MiniDFA1 {1}"]
DFA1_-534696056_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-114837569["MiniDFA2 {1}"]
DFA2_-824982610_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1439455482["MiniDFA3 {1}"]
DFA3_-706319198_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_97605759["MiniDFA4 {1}"]
DFA4_-41433768_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_218894224["MiniDFA5 {1}"]
DFA5_727456002_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1822536627["MiniDFA6 {1}"]
DFA6_708612885_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_31403766["MiniDFA7 {1}"]
DFA7_740729206_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-983350909["MiniDFA8 {1}"]
DFA8_536574535_8[\"DFA8 {1}"/]
end
MiniDFA0_-263927472 -->|"i"|MiniDFA1_-1634009154
MiniDFA1_-1634009154 -->|"i"|MiniDFA2_-114837569
MiniDFA2_-114837569 -->|"m"|MiniDFA3_1439455482
MiniDFA3_1439455482 -->|"a"|MiniDFA4_97605759
MiniDFA4_97605759 -->|"g"|MiniDFA5_218894224
MiniDFA5_218894224 -->|"e"|MiniDFA6_-1822536627
MiniDFA6_-1822536627 -->|"3"|MiniDFA7_31403766
MiniDFA7_31403766 -->|"D"|MiniDFA8_-983350909
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
MiniDFA0_-263927472(["MiniDFA0 {1}"])
MiniDFA1_-1634009154(["MiniDFA1 {1}"])
MiniDFA2_-114837569(["MiniDFA2 {1}"])
MiniDFA3_1439455482(["MiniDFA3 {1}"])
MiniDFA4_97605759(["MiniDFA4 {1}"])
MiniDFA5_218894224(["MiniDFA5 {1}"])
MiniDFA6_-1822536627(["MiniDFA6 {1}"])
MiniDFA7_31403766(["MiniDFA7 {1}"])
MiniDFA8_-983350909[\"MiniDFA8 {1}"/]
MiniDFA0_-263927472 -->|"i"|MiniDFA1_-1634009154
MiniDFA1_-1634009154 -->|"i"|MiniDFA2_-114837569
MiniDFA2_-114837569 -->|"m"|MiniDFA3_1439455482
MiniDFA3_1439455482 -->|"a"|MiniDFA4_97605759
MiniDFA4_97605759 -->|"g"|MiniDFA5_218894224
MiniDFA5_218894224 -->|"e"|MiniDFA6_-1822536627
MiniDFA6_-1822536627 -->|"3"|MiniDFA7_31403766
MiniDFA7_31403766 -->|"D"|MiniDFA8_-983350909
```
-------------------------------
