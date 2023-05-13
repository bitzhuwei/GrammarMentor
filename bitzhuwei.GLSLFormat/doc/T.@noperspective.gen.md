# 'noperspective'

pattern: `noperspective`

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
eNFA55_26_58153438[["εNFA55-26 regex start"]]
eNFA55_0_53618895[["εNFA55-0 char{1, 1}"]]
eNFA55_1_12808013[["εNFA55-1 char[1]"]]
eNFA55_2_48163256[["εNFA55-2 char{1, 1}"]]
eNFA55_3_30816121[["εNFA55-3 char[1]"]]
eNFA55_4_8909633[["εNFA55-4 char{1, 1}"]]
eNFA55_5_13077833[["εNFA55-5 char[1]"]]
eNFA55_6_50591634[["εNFA55-6 char{1, 1}"]]
eNFA55_7_52671525[["εNFA55-7 char[1]"]]
eNFA55_8_4281684[["εNFA55-8 char{1, 1}"]]
eNFA55_9_38535158[["εNFA55-9 char[1]"]]
eNFA55_10_11272110[["εNFA55-10 char{1, 1}"]]
eNFA55_11_34340132[["εNFA55-11 char[1]"]]
eNFA55_12_40625737[["εNFA55-12 char{1, 1}"]]
eNFA55_13_30087318[["εNFA55-13 char[1]"]]
eNFA55_14_2350413[["εNFA55-14 char{1, 1}"]]
eNFA55_15_21153717[["εNFA55-15 char[1]"]]
eNFA55_16_56165728[["εNFA55-16 char{1, 1}"]]
eNFA55_17_35729512[["εNFA55-17 char[1]"]]
eNFA55_18_53130157[["εNFA55-18 char{1, 1}"]]
eNFA55_19_8409368[["εNFA55-19 char[1]"]]
eNFA55_20_8575450[["εNFA55-20 char{1, 1}"]]
eNFA55_21_10070188[["εNFA55-21 char[1]"]]
eNFA55_22_23522831[["εNFA55-22 char{1, 1}"]]
eNFA55_23_10378893[["εNFA55-23 char[1]"]]
eNFA55_24_26301173[["εNFA55-24 char{1, 1}"]]
eNFA55_25_35383970[["εNFA55-25 char[1]"]]
eNFA55_27_50020275[["εNFA55-27 regex end"]]
eNFA55_28_47529299[["εNFA55-28 post-regex start"]]
eNFA55_29_25110514[\"εNFA55-29 post-regex end"/]
eNFA55_26_58153438 -.->|"ε"|eNFA55_0_53618895
eNFA55_0_53618895 -->|"n"|eNFA55_1_12808013
eNFA55_1_12808013 -.->|"ε"|eNFA55_2_48163256
eNFA55_2_48163256 -->|"o"|eNFA55_3_30816121
eNFA55_3_30816121 -.->|"ε"|eNFA55_4_8909633
eNFA55_4_8909633 -->|"p"|eNFA55_5_13077833
eNFA55_5_13077833 -.->|"ε"|eNFA55_6_50591634
eNFA55_6_50591634 -->|"e"|eNFA55_7_52671525
eNFA55_7_52671525 -.->|"ε"|eNFA55_8_4281684
eNFA55_8_4281684 -->|"r"|eNFA55_9_38535158
eNFA55_9_38535158 -.->|"ε"|eNFA55_10_11272110
eNFA55_10_11272110 -->|"s"|eNFA55_11_34340132
eNFA55_11_34340132 -.->|"ε"|eNFA55_12_40625737
eNFA55_12_40625737 -->|"p"|eNFA55_13_30087318
eNFA55_13_30087318 -.->|"ε"|eNFA55_14_2350413
eNFA55_14_2350413 -->|"e"|eNFA55_15_21153717
eNFA55_15_21153717 -.->|"ε"|eNFA55_16_56165728
eNFA55_16_56165728 -->|"c"|eNFA55_17_35729512
eNFA55_17_35729512 -.->|"ε"|eNFA55_18_53130157
eNFA55_18_53130157 -->|"t"|eNFA55_19_8409368
eNFA55_19_8409368 -.->|"ε"|eNFA55_20_8575450
eNFA55_20_8575450 -->|"i"|eNFA55_21_10070188
eNFA55_21_10070188 -.->|"ε"|eNFA55_22_23522831
eNFA55_22_23522831 -->|"v"|eNFA55_23_10378893
eNFA55_23_10378893 -.->|"ε"|eNFA55_24_26301173
eNFA55_24_26301173 -->|"e"|eNFA55_25_35383970
eNFA55_25_35383970 -.->|"ε"|eNFA55_27_50020275
eNFA55_27_50020275 -.->|"ε"|eNFA55_28_47529299
eNFA55_28_47529299 -.->|"ε"|eNFA55_29_25110514
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
eNFA55_26_24668042[["εNFA55-26 regex start"]]
eNFA55_0_20685786[["εNFA55-0 char{1, 1}"]]
eNFA55_1_51954348[["εNFA55-1 char[1]"]]
eNFA55_2_64935954[["εNFA55-2 char{1, 1}"]]
eNFA55_3_47552675[["εNFA55-3 char[1]"]]
eNFA55_4_25320898[["εNFA55-4 char{1, 1}"]]
eNFA55_5_26561495[["εNFA55-5 char[1]"]]
eNFA55_6_37726867[["εNFA55-6 char{1, 1}"]]
eNFA55_7_3997487[["εNFA55-7 char[1]"]]
eNFA55_8_35977388[["εNFA55-8 char{1, 1}"]]
eNFA55_9_55361044[["εNFA55-9 char[1]"]]
eNFA55_10_28487350[["εNFA55-10 char{1, 1}"]]
eNFA55_11_55059565[["εNFA55-11 char[1]"]]
eNFA55_12_25774041[["εNFA55-12 char{1, 1}"]]
eNFA55_13_30639779[["εNFA55-13 char[1]"]]
eNFA55_14_7322556[["εNFA55-14 char{1, 1}"]]
eNFA55_15_65903005[["εNFA55-15 char[1]"]]
eNFA55_16_56256135[["εNFA55-16 char{1, 1}"]]
eNFA55_17_36543171[["εNFA55-17 char[1]"]]
eNFA55_18_60453091[["εNFA55-18 char{1, 1}"]]
eNFA55_19_7206911[["εNFA55-19 char[1]"]]
eNFA55_20_64862199[["εNFA55-20 char{1, 1}"]]
eNFA55_21_46888886[["εNFA55-21 char[1]"]]
eNFA55_22_19346796[["εNFA55-22 char{1, 1}"]]
eNFA55_23_39903442[["εNFA55-23 char[1]"]]
eNFA55_24_23586666[["εNFA55-24 char{1, 1}"]]
eNFA55_25_10953403[\"εNFA55-25 char[1]"/]
eNFA55_27_31471768[\"εNFA55-27 regex end"/]
eNFA55_28_14810456[\"εNFA55-28 post-regex start"/]
eNFA55_29_66185246[\"εNFA55-29 post-regex end"/]
eNFA55_26_24668042 -.->|"ε"|eNFA55_0_20685786
eNFA55_26_24668042 -->|"n"|eNFA55_1_51954348
eNFA55_0_20685786 -->|"n"|eNFA55_1_51954348
eNFA55_1_51954348 -.->|"ε"|eNFA55_2_64935954
eNFA55_1_51954348 -->|"o"|eNFA55_3_47552675
eNFA55_2_64935954 -->|"o"|eNFA55_3_47552675
eNFA55_3_47552675 -.->|"ε"|eNFA55_4_25320898
eNFA55_3_47552675 -->|"p"|eNFA55_5_26561495
eNFA55_4_25320898 -->|"p"|eNFA55_5_26561495
eNFA55_5_26561495 -.->|"ε"|eNFA55_6_37726867
eNFA55_5_26561495 -->|"e"|eNFA55_7_3997487
eNFA55_6_37726867 -->|"e"|eNFA55_7_3997487
eNFA55_7_3997487 -.->|"ε"|eNFA55_8_35977388
eNFA55_7_3997487 -->|"r"|eNFA55_9_55361044
eNFA55_8_35977388 -->|"r"|eNFA55_9_55361044
eNFA55_9_55361044 -.->|"ε"|eNFA55_10_28487350
eNFA55_9_55361044 -->|"s"|eNFA55_11_55059565
eNFA55_10_28487350 -->|"s"|eNFA55_11_55059565
eNFA55_11_55059565 -.->|"ε"|eNFA55_12_25774041
eNFA55_11_55059565 -->|"p"|eNFA55_13_30639779
eNFA55_12_25774041 -->|"p"|eNFA55_13_30639779
eNFA55_13_30639779 -.->|"ε"|eNFA55_14_7322556
eNFA55_13_30639779 -->|"e"|eNFA55_15_65903005
eNFA55_14_7322556 -->|"e"|eNFA55_15_65903005
eNFA55_15_65903005 -.->|"ε"|eNFA55_16_56256135
eNFA55_15_65903005 -->|"c"|eNFA55_17_36543171
eNFA55_16_56256135 -->|"c"|eNFA55_17_36543171
eNFA55_17_36543171 -.->|"ε"|eNFA55_18_60453091
eNFA55_17_36543171 -->|"t"|eNFA55_19_7206911
eNFA55_18_60453091 -->|"t"|eNFA55_19_7206911
eNFA55_19_7206911 -.->|"ε"|eNFA55_20_64862199
eNFA55_19_7206911 -->|"i"|eNFA55_21_46888886
eNFA55_20_64862199 -->|"i"|eNFA55_21_46888886
eNFA55_21_46888886 -.->|"ε"|eNFA55_22_19346796
eNFA55_21_46888886 -->|"v"|eNFA55_23_39903442
eNFA55_22_19346796 -->|"v"|eNFA55_23_39903442
eNFA55_23_39903442 -.->|"ε"|eNFA55_24_23586666
eNFA55_23_39903442 -->|"e"|eNFA55_25_10953403
eNFA55_24_23586666 -->|"e"|eNFA55_25_10953403
eNFA55_25_10953403 -.->|"ε"|eNFA55_27_31471768
eNFA55_25_10953403 -.->|"ε"|eNFA55_28_14810456
eNFA55_25_10953403 -.->|"ε"|eNFA55_29_66185246
eNFA55_27_31471768 -.->|"ε"|eNFA55_28_14810456
eNFA55_27_31471768 -.->|"ε"|eNFA55_29_66185246
eNFA55_28_14810456 -.->|"ε"|eNFA55_29_66185246
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
NFA55_26_58796306("NFA55-26 regex start")
NFA55_1_59404709("NFA55-1 char[1]")
NFA55_3_64880336("NFA55-3 char[1]")
NFA55_5_47052116("NFA55-5 char[1]")
NFA55_7_20815867("NFA55-7 char[1]")
NFA55_9_53125076("NFA55-9 char[1]")
NFA55_11_8363642("NFA55-11 char[1]")
NFA55_13_8163917("NFA55-13 char[1]")
NFA55_15_6366390("NFA55-15 char[1]")
NFA55_17_57297510("NFA55-17 char[1]")
NFA55_19_45915542("NFA55-19 char[1]")
NFA55_21_10586695("NFA55-21 char[1]")
NFA55_23_28171394("NFA55-23 char[1]")
NFA55_25_52215961[\"NFA55-25 char[1]"/]
NFA55_26_58796306 -->|"n"|NFA55_1_59404709
NFA55_1_59404709 -->|"o"|NFA55_3_64880336
NFA55_3_64880336 -->|"p"|NFA55_5_47052116
NFA55_5_47052116 -->|"e"|NFA55_7_20815867
NFA55_7_20815867 -->|"r"|NFA55_9_53125076
NFA55_9_53125076 -->|"s"|NFA55_11_8363642
NFA55_11_8363642 -->|"p"|NFA55_13_8163917
NFA55_13_8163917 -->|"e"|NFA55_15_6366390
NFA55_15_6366390 -->|"c"|NFA55_17_57297510
NFA55_17_57297510 -->|"t"|NFA55_19_45915542
NFA55_19_45915542 -->|"i"|NFA55_21_10586695
NFA55_21_10586695 -->|"v"|NFA55_23_28171394
NFA55_23_28171394 -->|"e"|NFA55_25_52215961
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
subgraph DFA0_-770424108["DFA0 regex start"]
NFA55_26_58796306_0("NFA55-26 regex start")
end
subgraph DFA1_-281216932["DFA1 {1}"]
NFA55_1_59404709_1("NFA55-1 char[1]")
end
subgraph DFA2_1832312260["DFA2 {1}"]
NFA55_3_64880336_2("NFA55-3 char[1]")
end
subgraph DFA3_1488575013["DFA3 {1}"]
NFA55_5_47052116_3("NFA55-5 char[1]")
end
subgraph DFA4_-513068740["DFA4 {1}"]
NFA55_7_20815867_4("NFA55-7 char[1]")
end
subgraph DFA5_-145332599["DFA5 {1}"]
NFA55_9_53125076_5("NFA55-9 char[1]")
end
subgraph DFA6_34881644["DFA6 {1}"]
NFA55_11_8363642_6("NFA55-11 char[1]")
end
subgraph DFA7_-2121861161["DFA7 {1}"]
NFA55_13_8163917_7("NFA55-13 char[1]")
end
subgraph DFA8_2013330551["DFA8 {1}"]
NFA55_15_6366390_8("NFA55-15 char[1]")
end
subgraph DFA9_1010429113["DFA9 {1}"]
NFA55_17_57297510_9("NFA55-17 char[1]")
end
subgraph DFA10_238568699["DFA10 {1}"]
NFA55_19_45915542_10("NFA55-19 char[1]")
end
subgraph DFA11_2034838807["DFA11 {1}"]
NFA55_21_10586695_11("NFA55-21 char[1]")
end
subgraph DFA12_228680694["DFA12 {1}"]
NFA55_23_28171394_12("NFA55-23 char[1]")
end
subgraph DFA13_-171455862["DFA13 {1}"]
NFA55_25_52215961_13[\"NFA55-25 char[1]"/]
end
DFA0_-770424108 -->|"n"|DFA1_-281216932
DFA1_-281216932 -->|"o"|DFA2_1832312260
DFA2_1832312260 -->|"p"|DFA3_1488575013
DFA3_1488575013 -->|"e"|DFA4_-513068740
DFA4_-513068740 -->|"r"|DFA5_-145332599
DFA5_-145332599 -->|"s"|DFA6_34881644
DFA6_34881644 -->|"p"|DFA7_-2121861161
DFA7_-2121861161 -->|"e"|DFA8_2013330551
DFA8_2013330551 -->|"c"|DFA9_1010429113
DFA9_1010429113 -->|"t"|DFA10_238568699
DFA10_238568699 -->|"i"|DFA11_2034838807
DFA11_2034838807 -->|"v"|DFA12_228680694
DFA12_228680694 -->|"e"|DFA13_-171455862
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
DFA0_-770424108{{"DFA0 regex start"}}
DFA1_-281216932{{"DFA1 {1}"}}
DFA2_1832312260{{"DFA2 {1}"}}
DFA3_1488575013{{"DFA3 {1}"}}
DFA4_-513068740{{"DFA4 {1}"}}
DFA5_-145332599{{"DFA5 {1}"}}
DFA6_34881644{{"DFA6 {1}"}}
DFA7_-2121861161{{"DFA7 {1}"}}
DFA8_2013330551{{"DFA8 {1}"}}
DFA9_1010429113{{"DFA9 {1}"}}
DFA10_238568699{{"DFA10 {1}"}}
DFA11_2034838807{{"DFA11 {1}"}}
DFA12_228680694{{"DFA12 {1}"}}
DFA13_-171455862[\"DFA13 {1}"/]
DFA0_-770424108 -->|"n"|DFA1_-281216932
DFA1_-281216932 -->|"o"|DFA2_1832312260
DFA2_1832312260 -->|"p"|DFA3_1488575013
DFA3_1488575013 -->|"e"|DFA4_-513068740
DFA4_-513068740 -->|"r"|DFA5_-145332599
DFA5_-145332599 -->|"s"|DFA6_34881644
DFA6_34881644 -->|"p"|DFA7_-2121861161
DFA7_-2121861161 -->|"e"|DFA8_2013330551
DFA8_2013330551 -->|"c"|DFA9_1010429113
DFA9_1010429113 -->|"t"|DFA10_238568699
DFA10_238568699 -->|"i"|DFA11_2034838807
DFA11_2034838807 -->|"v"|DFA12_228680694
DFA12_228680694 -->|"e"|DFA13_-171455862
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
subgraph MiniDFA0_1974974591["MiniDFA0 {1}"]
DFA0_-770424108_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-803061083["MiniDFA1 {1}"]
DFA1_-281216932_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1689147071["MiniDFA2 {1}"]
DFA2_1832312260_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-323042595["MiniDFA4 {1}"]
DFA3_1488575013_3{{"DFA3 {1}"}}
end
subgraph MiniDFA6_-2006338968["MiniDFA6 {1}"]
DFA4_-513068740_4{{"DFA4 {1}"}}
end
subgraph MiniDFA7_941756594["MiniDFA7 {1}"]
DFA5_-145332599_5{{"DFA5 {1}"}}
end
subgraph MiniDFA3_819106738["MiniDFA3 {1}"]
DFA6_34881644_6{{"DFA6 {1}"}}
end
subgraph MiniDFA5_-2102083114["MiniDFA5 {1}"]
DFA7_-2121861161_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_1365018974["MiniDFA8 {1}"]
DFA8_2013330551_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-628321857["MiniDFA9 {1}"]
DFA9_1010429113_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-1275027341["MiniDFA10 {1}"]
DFA10_238568699_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-1830500733["MiniDFA11 {1}"]
DFA11_2034838807_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1282580042["MiniDFA12 {1}"]
DFA12_228680694_12{{"DFA12 {1}"}}
end
subgraph MiniDFA13_-1061195796["MiniDFA13 {1}"]
DFA13_-171455862_13[\"DFA13 {1}"/]
end
MiniDFA0_1974974591 -->|"n"|MiniDFA1_-803061083
MiniDFA1_-803061083 -->|"o"|MiniDFA2_-1689147071
MiniDFA2_-1689147071 -->|"p"|MiniDFA4_-323042595
MiniDFA4_-323042595 -->|"e"|MiniDFA6_-2006338968
MiniDFA6_-2006338968 -->|"r"|MiniDFA7_941756594
MiniDFA7_941756594 -->|"s"|MiniDFA3_819106738
MiniDFA3_819106738 -->|"p"|MiniDFA5_-2102083114
MiniDFA5_-2102083114 -->|"e"|MiniDFA8_1365018974
MiniDFA8_1365018974 -->|"c"|MiniDFA9_-628321857
MiniDFA9_-628321857 -->|"t"|MiniDFA10_-1275027341
MiniDFA10_-1275027341 -->|"i"|MiniDFA11_-1830500733
MiniDFA11_-1830500733 -->|"v"|MiniDFA12_-1282580042
MiniDFA12_-1282580042 -->|"e"|MiniDFA13_-1061195796
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
MiniDFA0_1974974591(["MiniDFA0 {1}"])
MiniDFA1_-803061083(["MiniDFA1 {1}"])
MiniDFA2_-1689147071(["MiniDFA2 {1}"])
MiniDFA4_-323042595(["MiniDFA4 {1}"])
MiniDFA6_-2006338968(["MiniDFA6 {1}"])
MiniDFA7_941756594(["MiniDFA7 {1}"])
MiniDFA3_819106738(["MiniDFA3 {1}"])
MiniDFA5_-2102083114(["MiniDFA5 {1}"])
MiniDFA8_1365018974(["MiniDFA8 {1}"])
MiniDFA9_-628321857(["MiniDFA9 {1}"])
MiniDFA10_-1275027341(["MiniDFA10 {1}"])
MiniDFA11_-1830500733(["MiniDFA11 {1}"])
MiniDFA12_-1282580042(["MiniDFA12 {1}"])
MiniDFA13_-1061195796[\"MiniDFA13 {1}"/]
MiniDFA0_1974974591 -->|"n"|MiniDFA1_-803061083
MiniDFA1_-803061083 -->|"o"|MiniDFA2_-1689147071
MiniDFA2_-1689147071 -->|"p"|MiniDFA4_-323042595
MiniDFA4_-323042595 -->|"e"|MiniDFA6_-2006338968
MiniDFA6_-2006338968 -->|"r"|MiniDFA7_941756594
MiniDFA7_941756594 -->|"s"|MiniDFA3_819106738
MiniDFA3_819106738 -->|"p"|MiniDFA5_-2102083114
MiniDFA5_-2102083114 -->|"e"|MiniDFA8_1365018974
MiniDFA8_1365018974 -->|"c"|MiniDFA9_-628321857
MiniDFA9_-628321857 -->|"t"|MiniDFA10_-1275027341
MiniDFA10_-1275027341 -->|"i"|MiniDFA11_-1830500733
MiniDFA11_-1830500733 -->|"v"|MiniDFA12_-1282580042
MiniDFA12_-1282580042 -->|"e"|MiniDFA13_-1061195796
```
-------------------------------
