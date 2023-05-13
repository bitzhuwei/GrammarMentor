# 'mat2x4'

pattern: `mat2x4`

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
eNFA100_12_34745524[["εNFA100-12 regex start"]]
eNFA100_0_44274261[["εNFA100-0 char{1, 1}"]]
eNFA100_1_62924030[["εNFA100-1 char[1]"]]
eNFA100_2_29445360[["εNFA100-2 char{1, 1}"]]
eNFA100_3_63681652[["εNFA100-3 char[1]"]]
eNFA100_4_36263964[["εNFA100-4 char{1, 1}"]]
eNFA100_5_57940224[["εNFA100-5 char[1]"]]
eNFA100_6_51699968[["εNFA100-6 char{1, 1}"]]
eNFA100_7_62646535[["εNFA100-7 char[1]"]]
eNFA100_8_26947909[["εNFA100-8 char{1, 1}"]]
eNFA100_9_41204595[["εNFA100-9 char[1]"]]
eNFA100_10_35297043[["εNFA100-10 char{1, 1}"]]
eNFA100_11_49237932[["εNFA100-11 char[1]"]]
eNFA100_13_40488209[["εNFA100-13 regex end"]]
eNFA100_14_28849561[["εNFA100-14 post-regex start"]]
eNFA100_15_58319463[\"εNFA100-15 post-regex end"/]
eNFA100_12_34745524 -.->|"ε"|eNFA100_0_44274261
eNFA100_0_44274261 -->|"m"|eNFA100_1_62924030
eNFA100_1_62924030 -.->|"ε"|eNFA100_2_29445360
eNFA100_2_29445360 -->|"a"|eNFA100_3_63681652
eNFA100_3_63681652 -.->|"ε"|eNFA100_4_36263964
eNFA100_4_36263964 -->|"t"|eNFA100_5_57940224
eNFA100_5_57940224 -.->|"ε"|eNFA100_6_51699968
eNFA100_6_51699968 -->|"2"|eNFA100_7_62646535
eNFA100_7_62646535 -.->|"ε"|eNFA100_8_26947909
eNFA100_8_26947909 -->|"x"|eNFA100_9_41204595
eNFA100_9_41204595 -.->|"ε"|eNFA100_10_35297043
eNFA100_10_35297043 -->|"4"|eNFA100_11_49237932
eNFA100_11_49237932 -.->|"ε"|eNFA100_13_40488209
eNFA100_13_40488209 -.->|"ε"|eNFA100_14_28849561
eNFA100_14_28849561 -.->|"ε"|eNFA100_15_58319463
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
eNFA100_12_55113123[["εNFA100-12 regex start"]]
eNFA100_0_26256062[["εNFA100-0 char{1, 1}"]]
eNFA100_1_34977969[["εNFA100-1 char[1]"]]
eNFA100_2_46366269[["εNFA100-2 char{1, 1}"]]
eNFA100_3_14643244[["εNFA100-3 char[1]"]]
eNFA100_4_64680333[["εNFA100-4 char{1, 1}"]]
eNFA100_5_45252091[["εNFA100-5 char[1]"]]
eNFA100_6_4615638[["εNFA100-6 char{1, 1}"]]
eNFA100_7_41540743[["εNFA100-7 char[1]"]]
eNFA100_8_38322367[["εNFA100-8 char{1, 1}"]]
eNFA100_9_9356983[["εNFA100-9 char[1]"]]
eNFA100_10_17103984[["εNFA100-10 char{1, 1}"]]
eNFA100_11_19718131[\"εNFA100-11 char[1]"/]
eNFA100_13_43245458[\"εNFA100-13 regex end"/]
eNFA100_14_53664804[\"εNFA100-14 post-regex start"/]
eNFA100_15_13221196[\"εNFA100-15 post-regex end"/]
eNFA100_12_55113123 -.->|"ε"|eNFA100_0_26256062
eNFA100_12_55113123 -->|"m"|eNFA100_1_34977969
eNFA100_0_26256062 -->|"m"|eNFA100_1_34977969
eNFA100_1_34977969 -.->|"ε"|eNFA100_2_46366269
eNFA100_1_34977969 -->|"a"|eNFA100_3_14643244
eNFA100_2_46366269 -->|"a"|eNFA100_3_14643244
eNFA100_3_14643244 -.->|"ε"|eNFA100_4_64680333
eNFA100_3_14643244 -->|"t"|eNFA100_5_45252091
eNFA100_4_64680333 -->|"t"|eNFA100_5_45252091
eNFA100_5_45252091 -.->|"ε"|eNFA100_6_4615638
eNFA100_5_45252091 -->|"2"|eNFA100_7_41540743
eNFA100_6_4615638 -->|"2"|eNFA100_7_41540743
eNFA100_7_41540743 -.->|"ε"|eNFA100_8_38322367
eNFA100_7_41540743 -->|"x"|eNFA100_9_9356983
eNFA100_8_38322367 -->|"x"|eNFA100_9_9356983
eNFA100_9_9356983 -.->|"ε"|eNFA100_10_17103984
eNFA100_9_9356983 -->|"4"|eNFA100_11_19718131
eNFA100_10_17103984 -->|"4"|eNFA100_11_19718131
eNFA100_11_19718131 -.->|"ε"|eNFA100_13_43245458
eNFA100_11_19718131 -.->|"ε"|eNFA100_14_53664804
eNFA100_11_19718131 -.->|"ε"|eNFA100_15_13221196
eNFA100_13_43245458 -.->|"ε"|eNFA100_14_53664804
eNFA100_13_43245458 -.->|"ε"|eNFA100_15_13221196
eNFA100_14_53664804 -.->|"ε"|eNFA100_15_13221196
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
NFA100_12_51881906("NFA100-12 regex start")
NFA100_1_64283975("NFA100-1 char[1]")
NFA100_3_41684868("NFA100-3 char[1]")
NFA100_5_39619499("NFA100-5 char[1]")
NFA100_7_21031171("NFA100-7 char[1]")
NFA100_9_55062814("NFA100-9 char[1]")
NFA100_11_25803286[\"NFA100-11 char[1]"/]
NFA100_12_51881906 -->|"m"|NFA100_1_64283975
NFA100_1_64283975 -->|"a"|NFA100_3_41684868
NFA100_3_41684868 -->|"t"|NFA100_5_39619499
NFA100_5_39619499 -->|"2"|NFA100_7_21031171
NFA100_7_21031171 -->|"x"|NFA100_9_55062814
NFA100_9_55062814 -->|"4"|NFA100_11_25803286
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
subgraph DFA0_-1499118243["DFA0 regex start"]
NFA100_12_51881906_0("NFA100-12 regex start")
end
subgraph DFA1_-849455433["DFA1 {1}"]
NFA100_1_64283975_1("NFA100-1 char[1]")
end
subgraph DFA2_700129113["DFA2 {1}"]
NFA100_3_41684868_2("NFA100-3 char[1]")
end
subgraph DFA3_-251495911["DFA3 {1}"]
NFA100_5_39619499_3("NFA100-5 char[1]")
end
subgraph DFA4_530355727["DFA4 {1}"]
NFA100_7_21031171_4("NFA100-7 char[1]")
end
subgraph DFA5_-524066261["DFA5 {1}"]
NFA100_9_55062814_5("NFA100-9 char[1]")
end
subgraph DFA6_-938197635["DFA6 {1}"]
NFA100_11_25803286_6[\"NFA100-11 char[1]"/]
end
DFA0_-1499118243 -->|"m"|DFA1_-849455433
DFA1_-849455433 -->|"a"|DFA2_700129113
DFA2_700129113 -->|"t"|DFA3_-251495911
DFA3_-251495911 -->|"2"|DFA4_530355727
DFA4_530355727 -->|"x"|DFA5_-524066261
DFA5_-524066261 -->|"4"|DFA6_-938197635
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
DFA0_-1499118243{{"DFA0 regex start"}}
DFA1_-849455433{{"DFA1 {1}"}}
DFA2_700129113{{"DFA2 {1}"}}
DFA3_-251495911{{"DFA3 {1}"}}
DFA4_530355727{{"DFA4 {1}"}}
DFA5_-524066261{{"DFA5 {1}"}}
DFA6_-938197635[\"DFA6 {1}"/]
DFA0_-1499118243 -->|"m"|DFA1_-849455433
DFA1_-849455433 -->|"a"|DFA2_700129113
DFA2_700129113 -->|"t"|DFA3_-251495911
DFA3_-251495911 -->|"2"|DFA4_530355727
DFA4_530355727 -->|"x"|DFA5_-524066261
DFA5_-524066261 -->|"4"|DFA6_-938197635
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
subgraph MiniDFA0_-1196186130["MiniDFA0 {1}"]
DFA0_-1499118243_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1733883822["MiniDFA1 {1}"]
DFA1_-849455433_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_2114495596["MiniDFA2 {1}"]
DFA2_700129113_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-2046258053["MiniDFA3 {1}"]
DFA3_-251495911_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_213013215["MiniDFA4 {1}"]
DFA4_530355727_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1050012618["MiniDFA5 {1}"]
DFA5_-524066261_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-301685103["MiniDFA6 {1}"]
DFA6_-938197635_6[\"DFA6 {1}"/]
end
MiniDFA0_-1196186130 -->|"m"|MiniDFA1_-1733883822
MiniDFA1_-1733883822 -->|"a"|MiniDFA2_2114495596
MiniDFA2_2114495596 -->|"t"|MiniDFA3_-2046258053
MiniDFA3_-2046258053 -->|"2"|MiniDFA4_213013215
MiniDFA4_213013215 -->|"x"|MiniDFA5_-1050012618
MiniDFA5_-1050012618 -->|"4"|MiniDFA6_-301685103
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
MiniDFA0_-1196186130(["MiniDFA0 {1}"])
MiniDFA1_-1733883822(["MiniDFA1 {1}"])
MiniDFA2_2114495596(["MiniDFA2 {1}"])
MiniDFA3_-2046258053(["MiniDFA3 {1}"])
MiniDFA4_213013215(["MiniDFA4 {1}"])
MiniDFA5_-1050012618(["MiniDFA5 {1}"])
MiniDFA6_-301685103[\"MiniDFA6 {1}"/]
MiniDFA0_-1196186130 -->|"m"|MiniDFA1_-1733883822
MiniDFA1_-1733883822 -->|"a"|MiniDFA2_2114495596
MiniDFA2_2114495596 -->|"t"|MiniDFA3_-2046258053
MiniDFA3_-2046258053 -->|"2"|MiniDFA4_213013215
MiniDFA4_213013215 -->|"x"|MiniDFA5_-1050012618
MiniDFA5_-1050012618 -->|"4"|MiniDFA6_-301685103
```
-------------------------------
