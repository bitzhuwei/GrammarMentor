# 'sampler3D'

pattern: `sampler3D`

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
eNFA122_18_29012868[["εNFA122-18 regex start"]]
eNFA122_0_59789225[["εNFA122-0 char{1, 1}"]]
eNFA122_1_1232117[["εNFA122-1 char[1]"]]
eNFA122_2_11089057[["εNFA122-2 char{1, 1}"]]
eNFA122_3_32692654[["εNFA122-3 char[1]"]]
eNFA122_4_25798438[["εNFA122-4 char{1, 1}"]]
eNFA122_5_30859352[["εNFA122-5 char[1]"]]
eNFA122_6_9298719[["εNFA122-6 char{1, 1}"]]
eNFA122_7_16579611[["εNFA122-7 char[1]"]]
eNFA122_8_14998773[["εNFA122-8 char{1, 1}"]]
eNFA122_9_771230[["εNFA122-9 char[1]"]]
eNFA122_10_6941071[["εNFA122-10 char{1, 1}"]]
eNFA122_11_62469641[["εNFA122-11 char[1]"]]
eNFA122_12_25355861[["εNFA122-12 char{1, 1}"]]
eNFA122_13_26876165[["εNFA122-13 char[1]"]]
eNFA122_14_40558897[["εNFA122-14 char{1, 1}"]]
eNFA122_15_29485753[["εNFA122-15 char[1]"]]
eNFA122_16_64045192[["εNFA122-16 char{1, 1}"]]
eNFA122_17_39535822[["εNFA122-17 char[1]"]]
eNFA122_19_20278084[["εNFA122-19 regex end"]]
eNFA122_20_48285036[["εNFA122-20 post-regex start"]]
eNFA122_21_31912141[\"εNFA122-21 post-regex end"/]
eNFA122_18_29012868 -.->|"ε"|eNFA122_0_59789225
eNFA122_0_59789225 -->|"s"|eNFA122_1_1232117
eNFA122_1_1232117 -.->|"ε"|eNFA122_2_11089057
eNFA122_2_11089057 -->|"a"|eNFA122_3_32692654
eNFA122_3_32692654 -.->|"ε"|eNFA122_4_25798438
eNFA122_4_25798438 -->|"m"|eNFA122_5_30859352
eNFA122_5_30859352 -.->|"ε"|eNFA122_6_9298719
eNFA122_6_9298719 -->|"p"|eNFA122_7_16579611
eNFA122_7_16579611 -.->|"ε"|eNFA122_8_14998773
eNFA122_8_14998773 -->|"l"|eNFA122_9_771230
eNFA122_9_771230 -.->|"ε"|eNFA122_10_6941071
eNFA122_10_6941071 -->|"e"|eNFA122_11_62469641
eNFA122_11_62469641 -.->|"ε"|eNFA122_12_25355861
eNFA122_12_25355861 -->|"r"|eNFA122_13_26876165
eNFA122_13_26876165 -.->|"ε"|eNFA122_14_40558897
eNFA122_14_40558897 -->|"3"|eNFA122_15_29485753
eNFA122_15_29485753 -.->|"ε"|eNFA122_16_64045192
eNFA122_16_64045192 -->|"D"|eNFA122_17_39535822
eNFA122_17_39535822 -.->|"ε"|eNFA122_19_20278084
eNFA122_19_20278084 -.->|"ε"|eNFA122_20_48285036
eNFA122_20_48285036 -.->|"ε"|eNFA122_21_31912141
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
eNFA122_18_18773818[["εNFA122-18 regex start"]]
eNFA122_0_34746634[["εNFA122-0 char{1, 1}"]]
eNFA122_1_44284256[["εNFA122-1 char[1]"]]
eNFA122_2_63013988[["εNFA122-2 char{1, 1}"]]
eNFA122_3_30254983[["εNFA122-3 char[1]"]]
eNFA122_4_3859394[["εNFA122-4 char{1, 1}"]]
eNFA122_5_34734550[["εNFA122-5 char[1]"]]
eNFA122_6_44175501[["εNFA122-6 char{1, 1}"]]
eNFA122_7_62035190[["εNFA122-7 char[1]"]]
eNFA122_8_21445804[["εNFA122-8 char{1, 1}"]]
eNFA122_9_58794511[["εNFA122-9 char[1]"]]
eNFA122_10_59388552[["εNFA122-10 char{1, 1}"]]
eNFA122_11_64734920[["εNFA122-11 char[1]"]]
eNFA122_12_45743368[["εNFA122-12 char{1, 1}"]]
eNFA122_13_9037129[["εNFA122-13 char[1]"]]
eNFA122_14_14225300[["εNFA122-14 char{1, 1}"]]
eNFA122_15_60918843[["εNFA122-15 char[1]"]]
eNFA122_16_11398677[["εNFA122-16 char{1, 1}"]]
eNFA122_17_35479237[\"εNFA122-17 char[1]"/]
eNFA122_19_50877683[\"εNFA122-19 regex end"/]
eNFA122_20_55245968[\"εNFA122-20 post-regex start"/]
eNFA122_21_27451669[\"εNFA122-21 post-regex end"/]
eNFA122_18_18773818 -.->|"ε"|eNFA122_0_34746634
eNFA122_18_18773818 -->|"s"|eNFA122_1_44284256
eNFA122_0_34746634 -->|"s"|eNFA122_1_44284256
eNFA122_1_44284256 -.->|"ε"|eNFA122_2_63013988
eNFA122_1_44284256 -->|"a"|eNFA122_3_30254983
eNFA122_2_63013988 -->|"a"|eNFA122_3_30254983
eNFA122_3_30254983 -.->|"ε"|eNFA122_4_3859394
eNFA122_3_30254983 -->|"m"|eNFA122_5_34734550
eNFA122_4_3859394 -->|"m"|eNFA122_5_34734550
eNFA122_5_34734550 -.->|"ε"|eNFA122_6_44175501
eNFA122_5_34734550 -->|"p"|eNFA122_7_62035190
eNFA122_6_44175501 -->|"p"|eNFA122_7_62035190
eNFA122_7_62035190 -.->|"ε"|eNFA122_8_21445804
eNFA122_7_62035190 -->|"l"|eNFA122_9_58794511
eNFA122_8_21445804 -->|"l"|eNFA122_9_58794511
eNFA122_9_58794511 -.->|"ε"|eNFA122_10_59388552
eNFA122_9_58794511 -->|"e"|eNFA122_11_64734920
eNFA122_10_59388552 -->|"e"|eNFA122_11_64734920
eNFA122_11_64734920 -.->|"ε"|eNFA122_12_45743368
eNFA122_11_64734920 -->|"r"|eNFA122_13_9037129
eNFA122_12_45743368 -->|"r"|eNFA122_13_9037129
eNFA122_13_9037129 -.->|"ε"|eNFA122_14_14225300
eNFA122_13_9037129 -->|"3"|eNFA122_15_60918843
eNFA122_14_14225300 -->|"3"|eNFA122_15_60918843
eNFA122_15_60918843 -.->|"ε"|eNFA122_16_11398677
eNFA122_15_60918843 -->|"D"|eNFA122_17_35479237
eNFA122_16_11398677 -->|"D"|eNFA122_17_35479237
eNFA122_17_35479237 -.->|"ε"|eNFA122_19_50877683
eNFA122_17_35479237 -.->|"ε"|eNFA122_20_55245968
eNFA122_17_35479237 -.->|"ε"|eNFA122_21_27451669
eNFA122_19_50877683 -.->|"ε"|eNFA122_20_55245968
eNFA122_19_50877683 -.->|"ε"|eNFA122_21_27451669
eNFA122_20_55245968 -.->|"ε"|eNFA122_21_27451669
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
NFA122_18_45738436("NFA122-18 regex start")
NFA122_1_8992740("NFA122-1 char[1]")
NFA122_3_13825799("NFA122-3 char[1]")
NFA122_5_57323335("NFA122-5 char[1]")
NFA122_7_46147972("NFA122-7 char[1]")
NFA122_9_12678567("NFA122-9 char[1]")
NFA122_11_46998241("NFA122-11 char[1]")
NFA122_13_20330987("NFA122-13 char[1]")
NFA122_15_48761158("NFA122-15 char[1]")
NFA122_17_36197244[\"NFA122-17 char[1]"/]
NFA122_18_45738436 -->|"s"|NFA122_1_8992740
NFA122_1_8992740 -->|"a"|NFA122_3_13825799
NFA122_3_13825799 -->|"m"|NFA122_5_57323335
NFA122_5_57323335 -->|"p"|NFA122_7_46147972
NFA122_7_46147972 -->|"l"|NFA122_9_12678567
NFA122_9_12678567 -->|"e"|NFA122_11_46998241
NFA122_11_46998241 -->|"r"|NFA122_13_20330987
NFA122_13_20330987 -->|"3"|NFA122_15_48761158
NFA122_15_48761158 -->|"D"|NFA122_17_36197244
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
subgraph DFA0_1749293122["DFA0 regex start"]
NFA122_18_45738436_0("NFA122-18 regex start")
end
subgraph DFA1_1694221742["DFA1 {1}"]
NFA122_1_8992740_1("NFA122-1 char[1]")
end
subgraph DFA2_881581801["DFA2 {1}"]
NFA122_3_13825799_2("NFA122-3 char[1]")
end
subgraph DFA3_954997219["DFA3 {1}"]
NFA122_5_57323335_3("NFA122-5 char[1]")
end
subgraph DFA4_1024355989["DFA4 {1}"]
NFA122_7_46147972_4("NFA122-7 char[1]")
end
subgraph DFA5_-883078401["DFA5 {1}"]
NFA122_9_12678567_5("NFA122-9 char[1]")
end
subgraph DFA6_-397849550["DFA6 {1}"]
NFA122_11_46998241_6("NFA122-11 char[1]")
end
subgraph DFA7_1789639311["DFA7 {1}"]
NFA122_13_20330987_7("NFA122-13 char[1]")
end
subgraph DFA8_1890186621["DFA8 {1}"]
NFA122_15_48761158_8("NFA122-15 char[1]")
end
subgraph DFA9_-518210503["DFA9 {1}"]
NFA122_17_36197244_9[\"NFA122-17 char[1]"/]
end
DFA0_1749293122 -->|"s"|DFA1_1694221742
DFA1_1694221742 -->|"a"|DFA2_881581801
DFA2_881581801 -->|"m"|DFA3_954997219
DFA3_954997219 -->|"p"|DFA4_1024355989
DFA4_1024355989 -->|"l"|DFA5_-883078401
DFA5_-883078401 -->|"e"|DFA6_-397849550
DFA6_-397849550 -->|"r"|DFA7_1789639311
DFA7_1789639311 -->|"3"|DFA8_1890186621
DFA8_1890186621 -->|"D"|DFA9_-518210503
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
DFA0_1749293122{{"DFA0 regex start"}}
DFA1_1694221742{{"DFA1 {1}"}}
DFA2_881581801{{"DFA2 {1}"}}
DFA3_954997219{{"DFA3 {1}"}}
DFA4_1024355989{{"DFA4 {1}"}}
DFA5_-883078401{{"DFA5 {1}"}}
DFA6_-397849550{{"DFA6 {1}"}}
DFA7_1789639311{{"DFA7 {1}"}}
DFA8_1890186621{{"DFA8 {1}"}}
DFA9_-518210503[\"DFA9 {1}"/]
DFA0_1749293122 -->|"s"|DFA1_1694221742
DFA1_1694221742 -->|"a"|DFA2_881581801
DFA2_881581801 -->|"m"|DFA3_954997219
DFA3_954997219 -->|"p"|DFA4_1024355989
DFA4_1024355989 -->|"l"|DFA5_-883078401
DFA5_-883078401 -->|"e"|DFA6_-397849550
DFA6_-397849550 -->|"r"|DFA7_1789639311
DFA7_1789639311 -->|"3"|DFA8_1890186621
DFA8_1890186621 -->|"D"|DFA9_-518210503
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
subgraph MiniDFA0_-1879234696["MiniDFA0 {1}"]
DFA0_1749293122_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1977757448["MiniDFA1 {1}"]
DFA1_1694221742_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_863062564["MiniDFA2 {1}"]
DFA2_881581801_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_1616590080["MiniDFA3 {1}"]
DFA3_954997219_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1840015845["MiniDFA4 {1}"]
DFA4_1024355989_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-642989610["MiniDFA5 {1}"]
DFA5_-883078401_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1185029076["MiniDFA6 {1}"]
DFA6_-397849550_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_-1950630828["MiniDFA7 {1}"]
DFA7_1789639311_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1959691960["MiniDFA8 {1}"]
DFA8_1890186621_8{{"DFA8 {1}"}}
end
subgraph MiniDFA9_-301834155["MiniDFA9 {1}"]
DFA9_-518210503_9[\"DFA9 {1}"/]
end
MiniDFA0_-1879234696 -->|"s"|MiniDFA1_-1977757448
MiniDFA1_-1977757448 -->|"a"|MiniDFA2_863062564
MiniDFA2_863062564 -->|"m"|MiniDFA3_1616590080
MiniDFA3_1616590080 -->|"p"|MiniDFA4_-1840015845
MiniDFA4_-1840015845 -->|"l"|MiniDFA5_-642989610
MiniDFA5_-642989610 -->|"e"|MiniDFA6_-1185029076
MiniDFA6_-1185029076 -->|"r"|MiniDFA7_-1950630828
MiniDFA7_-1950630828 -->|"3"|MiniDFA8_-1959691960
MiniDFA8_-1959691960 -->|"D"|MiniDFA9_-301834155
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
MiniDFA0_-1879234696(["MiniDFA0 {1}"])
MiniDFA1_-1977757448(["MiniDFA1 {1}"])
MiniDFA2_863062564(["MiniDFA2 {1}"])
MiniDFA3_1616590080(["MiniDFA3 {1}"])
MiniDFA4_-1840015845(["MiniDFA4 {1}"])
MiniDFA5_-642989610(["MiniDFA5 {1}"])
MiniDFA6_-1185029076(["MiniDFA6 {1}"])
MiniDFA7_-1950630828(["MiniDFA7 {1}"])
MiniDFA8_-1959691960(["MiniDFA8 {1}"])
MiniDFA9_-301834155[\"MiniDFA9 {1}"/]
MiniDFA0_-1879234696 -->|"s"|MiniDFA1_-1977757448
MiniDFA1_-1977757448 -->|"a"|MiniDFA2_863062564
MiniDFA2_863062564 -->|"m"|MiniDFA3_1616590080
MiniDFA3_1616590080 -->|"p"|MiniDFA4_-1840015845
MiniDFA4_-1840015845 -->|"l"|MiniDFA5_-642989610
MiniDFA5_-642989610 -->|"e"|MiniDFA6_-1185029076
MiniDFA6_-1185029076 -->|"r"|MiniDFA7_-1950630828
MiniDFA7_-1950630828 -->|"3"|MiniDFA8_-1959691960
MiniDFA8_-1959691960 -->|"D"|MiniDFA9_-301834155
```
-------------------------------
