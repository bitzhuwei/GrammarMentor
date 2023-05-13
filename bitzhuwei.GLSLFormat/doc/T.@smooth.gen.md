# 'smooth'

pattern: `smooth`

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
eNFA53_12_14626574[["εNFA53-12 regex start"]]
eNFA53_0_64530307[["εNFA53-0 char{1, 1}"]]
eNFA53_1_43901854[["εNFA53-1 char[1]"]]
eNFA53_2_59572368[["εNFA53-2 char{1, 1}"]]
eNFA53_3_66389266[["εNFA53-3 char[1]"]]
eNFA53_4_60632485[["εNFA53-4 char{1, 1}"]]
eNFA53_5_8821459[["εNFA53-5 char[1]"]]
eNFA53_6_12284267[["εNFA53-6 char{1, 1}"]]
eNFA53_7_43449544[["εNFA53-7 char[1]"]]
eNFA53_8_55501577[["εNFA53-8 char{1, 1}"]]
eNFA53_9_29752153[["εNFA53-9 char[1]"]]
eNFA53_10_66442792[["εNFA53-10 char{1, 1}"]]
eNFA53_11_61114224[["εNFA53-11 char[1]"]]
eNFA53_13_13157104[["εNFA53-13 regex end"]]
eNFA53_14_51305074[["εNFA53-14 post-regex start"]]
eNFA53_15_59092488[\"εNFA53-15 post-regex end"/]
eNFA53_12_14626574 -.->|"ε"|eNFA53_0_64530307
eNFA53_0_64530307 -->|"s"|eNFA53_1_43901854
eNFA53_1_43901854 -.->|"ε"|eNFA53_2_59572368
eNFA53_2_59572368 -->|"m"|eNFA53_3_66389266
eNFA53_3_66389266 -.->|"ε"|eNFA53_4_60632485
eNFA53_4_60632485 -->|"o"|eNFA53_5_8821459
eNFA53_5_8821459 -.->|"ε"|eNFA53_6_12284267
eNFA53_6_12284267 -->|"o"|eNFA53_7_43449544
eNFA53_7_43449544 -.->|"ε"|eNFA53_8_55501577
eNFA53_8_55501577 -->|"t"|eNFA53_9_29752153
eNFA53_9_29752153 -.->|"ε"|eNFA53_10_66442792
eNFA53_10_66442792 -->|"h"|eNFA53_11_61114224
eNFA53_11_61114224 -.->|"ε"|eNFA53_13_13157104
eNFA53_13_13157104 -.->|"ε"|eNFA53_14_51305074
eNFA53_14_51305074 -.->|"ε"|eNFA53_15_59092488
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
eNFA53_12_62070345[["εNFA53-12 regex start"]]
eNFA53_0_21762200[["εNFA53-0 char{1, 1}"]]
eNFA53_1_61642077[["εNFA53-1 char[1]"]]
eNFA53_2_17907785[["εNFA53-2 char{1, 1}"]]
eNFA53_3_26952341[["εNFA53-3 char[1]"]]
eNFA53_4_41244482[["εNFA53-4 char{1, 1}"]]
eNFA53_5_35656026[["εNFA53-5 char[1]"]]
eNFA53_6_52468780[["εNFA53-6 char{1, 1}"]]
eNFA53_7_2456979[["εNFA53-7 char[1]"]]
eNFA53_8_22112815[["εNFA53-8 char{1, 1}"]]
eNFA53_9_64797609[["εNFA53-9 char[1]"]]
eNFA53_10_46307570[["εNFA53-10 char{1, 1}"]]
eNFA53_11_14114947[\"εNFA53-11 char[1]"/]
eNFA53_13_59925661[\"εNFA53-13 regex end"/]
eNFA53_14_2460041[\"εNFA53-14 post-regex start"/]
eNFA53_15_22140377[\"εNFA53-15 post-regex end"/]
eNFA53_12_62070345 -.->|"ε"|eNFA53_0_21762200
eNFA53_12_62070345 -->|"s"|eNFA53_1_61642077
eNFA53_0_21762200 -->|"s"|eNFA53_1_61642077
eNFA53_1_61642077 -.->|"ε"|eNFA53_2_17907785
eNFA53_1_61642077 -->|"m"|eNFA53_3_26952341
eNFA53_2_17907785 -->|"m"|eNFA53_3_26952341
eNFA53_3_26952341 -.->|"ε"|eNFA53_4_41244482
eNFA53_3_26952341 -->|"o"|eNFA53_5_35656026
eNFA53_4_41244482 -->|"o"|eNFA53_5_35656026
eNFA53_5_35656026 -.->|"ε"|eNFA53_6_52468780
eNFA53_5_35656026 -->|"o"|eNFA53_7_2456979
eNFA53_6_52468780 -->|"o"|eNFA53_7_2456979
eNFA53_7_2456979 -.->|"ε"|eNFA53_8_22112815
eNFA53_7_2456979 -->|"t"|eNFA53_9_64797609
eNFA53_8_22112815 -->|"t"|eNFA53_9_64797609
eNFA53_9_64797609 -.->|"ε"|eNFA53_10_46307570
eNFA53_9_64797609 -->|"h"|eNFA53_11_14114947
eNFA53_10_46307570 -->|"h"|eNFA53_11_14114947
eNFA53_11_14114947 -.->|"ε"|eNFA53_13_59925661
eNFA53_11_14114947 -.->|"ε"|eNFA53_14_2460041
eNFA53_11_14114947 -.->|"ε"|eNFA53_15_22140377
eNFA53_13_59925661 -.->|"ε"|eNFA53_14_2460041
eNFA53_13_59925661 -.->|"ε"|eNFA53_15_22140377
eNFA53_14_2460041 -.->|"ε"|eNFA53_15_22140377
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
NFA53_12_65045669("NFA53-12 regex start")
NFA53_1_48540109("NFA53-1 char[1]")
NFA53_3_34207804("NFA53-3 char[1]")
NFA53_5_39434786("NFA53-5 char[1]")
NFA53_7_19368760("NFA53-7 char[1]")
NFA53_9_40101120("NFA53-9 char[1]")
NFA53_11_25365761[\"NFA53-11 char[1]"/]
NFA53_12_65045669 -->|"s"|NFA53_1_48540109
NFA53_1_48540109 -->|"m"|NFA53_3_34207804
NFA53_3_34207804 -->|"o"|NFA53_5_39434786
NFA53_5_39434786 -->|"o"|NFA53_7_19368760
NFA53_7_19368760 -->|"t"|NFA53_9_40101120
NFA53_9_40101120 -->|"h"|NFA53_11_25365761
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
subgraph DFA0_-778044937["DFA0 regex start"]
NFA53_12_65045669_0("NFA53-12 regex start")
end
subgraph DFA1_-1526922236["DFA1 {1}"]
NFA53_1_48540109_1("NFA53-1 char[1]")
end
subgraph DFA2_1568217519["DFA2 {1}"]
NFA53_3_34207804_2("NFA53-3 char[1]")
end
subgraph DFA3_-1801389972["DFA3 {1}"]
NFA53_5_39434786_3("NFA53-5 char[1]")
end
subgraph DFA4_844830728["DFA4 {1}"]
NFA53_7_19368760_4("NFA53-7 char[1]")
end
subgraph DFA5_1064384784["DFA5 {1}"]
NFA53_9_40101120_5("NFA53-9 char[1]")
end
subgraph DFA6_-1837583066["DFA6 {1}"]
NFA53_11_25365761_6[\"NFA53-11 char[1]"/]
end
DFA0_-778044937 -->|"s"|DFA1_-1526922236
DFA1_-1526922236 -->|"m"|DFA2_1568217519
DFA2_1568217519 -->|"o"|DFA3_-1801389972
DFA3_-1801389972 -->|"o"|DFA4_844830728
DFA4_844830728 -->|"t"|DFA5_1064384784
DFA5_1064384784 -->|"h"|DFA6_-1837583066
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
DFA0_-778044937{{"DFA0 regex start"}}
DFA1_-1526922236{{"DFA1 {1}"}}
DFA2_1568217519{{"DFA2 {1}"}}
DFA3_-1801389972{{"DFA3 {1}"}}
DFA4_844830728{{"DFA4 {1}"}}
DFA5_1064384784{{"DFA5 {1}"}}
DFA6_-1837583066[\"DFA6 {1}"/]
DFA0_-778044937 -->|"s"|DFA1_-1526922236
DFA1_-1526922236 -->|"m"|DFA2_1568217519
DFA2_1568217519 -->|"o"|DFA3_-1801389972
DFA3_-1801389972 -->|"o"|DFA4_844830728
DFA4_844830728 -->|"t"|DFA5_1064384784
DFA5_1064384784 -->|"h"|DFA6_-1837583066
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
subgraph MiniDFA0_1867021983["MiniDFA0 {1}"]
DFA0_-778044937_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-436454046["MiniDFA1 {1}"]
DFA1_-1526922236_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_754817420["MiniDFA2 {1}"]
DFA2_1568217519_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-736436465["MiniDFA3 {1}"]
DFA3_-1801389972_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-283795466["MiniDFA4 {1}"]
DFA4_844830728_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1082289015["MiniDFA5 {1}"]
DFA5_1064384784_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_45894674["MiniDFA6 {1}"]
DFA6_-1837583066_6[\"DFA6 {1}"/]
end
MiniDFA0_1867021983 -->|"s"|MiniDFA1_-436454046
MiniDFA1_-436454046 -->|"m"|MiniDFA2_754817420
MiniDFA2_754817420 -->|"o"|MiniDFA3_-736436465
MiniDFA3_-736436465 -->|"o"|MiniDFA4_-283795466
MiniDFA4_-283795466 -->|"t"|MiniDFA5_1082289015
MiniDFA5_1082289015 -->|"h"|MiniDFA6_45894674
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
MiniDFA0_1867021983(["MiniDFA0 {1}"])
MiniDFA1_-436454046(["MiniDFA1 {1}"])
MiniDFA2_754817420(["MiniDFA2 {1}"])
MiniDFA3_-736436465(["MiniDFA3 {1}"])
MiniDFA4_-283795466(["MiniDFA4 {1}"])
MiniDFA5_1082289015(["MiniDFA5 {1}"])
MiniDFA6_45894674[\"MiniDFA6 {1}"/]
MiniDFA0_1867021983 -->|"s"|MiniDFA1_-436454046
MiniDFA1_-436454046 -->|"m"|MiniDFA2_754817420
MiniDFA2_754817420 -->|"o"|MiniDFA3_-736436465
MiniDFA3_-736436465 -->|"o"|MiniDFA4_-283795466
MiniDFA4_-283795466 -->|"t"|MiniDFA5_1082289015
MiniDFA5_1082289015 -->|"h"|MiniDFA6_45894674
```
-------------------------------
