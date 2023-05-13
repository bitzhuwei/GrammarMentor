# 'readonly'

pattern: `readonly`

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
eNFA71_16_7868661[["εNFA71-16 regex start"]]
eNFA71_0_3709091[["εNFA71-0 char{1, 1}"]]
eNFA71_1_33381819[["εNFA71-1 char[1]"]]
eNFA71_2_32000920[["εNFA71-2 char{1, 1}"]]
eNFA71_3_19572825[["εNFA71-3 char[1]"]]
eNFA71_4_41937705[["εNFA71-4 char{1, 1}"]]
eNFA71_5_41895032[["εNFA71-5 char[1]"]]
eNFA71_6_41510976[["εNFA71-6 char{1, 1}"]]
eNFA71_7_38054464[["εNFA71-7 char[1]"]]
eNFA71_8_6945858[["εNFA71-8 char{1, 1}"]]
eNFA71_9_62512728[["εNFA71-9 char[1]"]]
eNFA71_10_25743641[["εNFA71-10 char{1, 1}"]]
eNFA71_11_30366184[["εNFA71-11 char[1]"]]
eNFA71_12_4860205[["εNFA71-12 char{1, 1}"]]
eNFA71_13_43741849[["εNFA71-13 char[1]"]]
eNFA71_14_58132325[["εNFA71-14 char{1, 1}"]]
eNFA71_15_53428882[["εNFA71-15 char[1]"]]
eNFA71_17_11097898[["εNFA71-17 regex end"]]
eNFA71_18_32772220[["εNFA71-18 post-regex start"]]
eNFA71_19_26514531[\"εNFA71-19 post-regex end"/]
eNFA71_16_7868661 -.->|"ε"|eNFA71_0_3709091
eNFA71_0_3709091 -->|"r"|eNFA71_1_33381819
eNFA71_1_33381819 -.->|"ε"|eNFA71_2_32000920
eNFA71_2_32000920 -->|"e"|eNFA71_3_19572825
eNFA71_3_19572825 -.->|"ε"|eNFA71_4_41937705
eNFA71_4_41937705 -->|"a"|eNFA71_5_41895032
eNFA71_5_41895032 -.->|"ε"|eNFA71_6_41510976
eNFA71_6_41510976 -->|"d"|eNFA71_7_38054464
eNFA71_7_38054464 -.->|"ε"|eNFA71_8_6945858
eNFA71_8_6945858 -->|"o"|eNFA71_9_62512728
eNFA71_9_62512728 -.->|"ε"|eNFA71_10_25743641
eNFA71_10_25743641 -->|"n"|eNFA71_11_30366184
eNFA71_11_30366184 -.->|"ε"|eNFA71_12_4860205
eNFA71_12_4860205 -->|"l"|eNFA71_13_43741849
eNFA71_13_43741849 -.->|"ε"|eNFA71_14_58132325
eNFA71_14_58132325 -->|"y"|eNFA71_15_53428882
eNFA71_15_53428882 -.->|"ε"|eNFA71_17_11097898
eNFA71_17_11097898 -.->|"ε"|eNFA71_18_32772220
eNFA71_18_32772220 -.->|"ε"|eNFA71_19_26514531
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
eNFA71_16_37304191[["εNFA71-16 regex start"]]
eNFA71_0_193401[["εNFA71-0 char{1, 1}"]]
eNFA71_1_1740610[["εNFA71-1 char[1]"]]
eNFA71_2_15665491[["εNFA71-2 char{1, 1}"]]
eNFA71_3_6771693[["εNFA71-3 char[1]"]]
eNFA71_4_60945241[["εNFA71-4 char{1, 1}"]]
eNFA71_5_11636265[["εNFA71-5 char[1]"]]
eNFA71_6_37617525[["εNFA71-6 char{1, 1}"]]
eNFA71_7_3013405[["εNFA71-7 char[1]"]]
eNFA71_8_27120652[["εNFA71-8 char{1, 1}"]]
eNFA71_9_42759282[["εNFA71-9 char[1]"]]
eNFA71_10_49289224[["εNFA71-10 char{1, 1}"]]
eNFA71_11_40949840[["εNFA71-11 char[1]"]]
eNFA71_12_33004241[["εNFA71-12 char{1, 1}"]]
eNFA71_13_28602718[["εNFA71-13 char[1]"]]
eNFA71_14_56097870[["εNFA71-14 char{1, 1}"]]
eNFA71_15_35118788[\"εNFA71-15 char[1]"/]
eNFA71_17_47633640[\"εNFA71-17 regex end"/]
eNFA71_18_26049579[\"εNFA71-18 post-regex start"/]
eNFA71_19_33119622[\"εNFA71-19 post-regex end"/]
eNFA71_16_37304191 -.->|"ε"|eNFA71_0_193401
eNFA71_16_37304191 -->|"r"|eNFA71_1_1740610
eNFA71_0_193401 -->|"r"|eNFA71_1_1740610
eNFA71_1_1740610 -.->|"ε"|eNFA71_2_15665491
eNFA71_1_1740610 -->|"e"|eNFA71_3_6771693
eNFA71_2_15665491 -->|"e"|eNFA71_3_6771693
eNFA71_3_6771693 -.->|"ε"|eNFA71_4_60945241
eNFA71_3_6771693 -->|"a"|eNFA71_5_11636265
eNFA71_4_60945241 -->|"a"|eNFA71_5_11636265
eNFA71_5_11636265 -.->|"ε"|eNFA71_6_37617525
eNFA71_5_11636265 -->|"d"|eNFA71_7_3013405
eNFA71_6_37617525 -->|"d"|eNFA71_7_3013405
eNFA71_7_3013405 -.->|"ε"|eNFA71_8_27120652
eNFA71_7_3013405 -->|"o"|eNFA71_9_42759282
eNFA71_8_27120652 -->|"o"|eNFA71_9_42759282
eNFA71_9_42759282 -.->|"ε"|eNFA71_10_49289224
eNFA71_9_42759282 -->|"n"|eNFA71_11_40949840
eNFA71_10_49289224 -->|"n"|eNFA71_11_40949840
eNFA71_11_40949840 -.->|"ε"|eNFA71_12_33004241
eNFA71_11_40949840 -->|"l"|eNFA71_13_28602718
eNFA71_12_33004241 -->|"l"|eNFA71_13_28602718
eNFA71_13_28602718 -.->|"ε"|eNFA71_14_56097870
eNFA71_13_28602718 -->|"y"|eNFA71_15_35118788
eNFA71_14_56097870 -->|"y"|eNFA71_15_35118788
eNFA71_15_35118788 -.->|"ε"|eNFA71_17_47633640
eNFA71_15_35118788 -.->|"ε"|eNFA71_18_26049579
eNFA71_15_35118788 -.->|"ε"|eNFA71_19_33119622
eNFA71_17_47633640 -.->|"ε"|eNFA71_18_26049579
eNFA71_17_47633640 -.->|"ε"|eNFA71_19_33119622
eNFA71_18_26049579 -.->|"ε"|eNFA71_19_33119622
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
NFA71_16_29641146("NFA71-16 regex start")
NFA71_1_65443729("NFA71-1 char[1]")
NFA71_3_52122650("NFA71-3 char[1]")
NFA71_5_66450672("NFA71-5 char[1]")
NFA71_7_61185139("NFA71-7 char[1]")
NFA71_9_13795340("NFA71-9 char[1]")
NFA71_11_57049196("NFA71-11 char[1]")
NFA71_13_43680716("NFA71-13 char[1]")
NFA71_15_57582125[\"NFA71-15 char[1]"/]
NFA71_16_29641146 -->|"r"|NFA71_1_65443729
NFA71_1_65443729 -->|"e"|NFA71_3_52122650
NFA71_3_52122650 -->|"a"|NFA71_5_66450672
NFA71_5_66450672 -->|"d"|NFA71_7_61185139
NFA71_7_61185139 -->|"o"|NFA71_9_13795340
NFA71_9_13795340 -->|"n"|NFA71_11_57049196
NFA71_11_57049196 -->|"l"|NFA71_13_43680716
NFA71_13_43680716 -->|"y"|NFA71_15_57582125
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
subgraph DFA0_688241250["DFA0 regex start"]
NFA71_16_29641146_0("NFA71-16 regex start")
end
subgraph DFA1_1749333082["DFA1 {1}"]
NFA71_1_65443729_1("NFA71-1 char[1]")
end
subgraph DFA2_-686162261["DFA2 {1}"]
NFA71_3_52122650_2("NFA71-3 char[1]")
end
subgraph DFA3_1033640031["DFA3 {1}"]
NFA71_5_66450672_3("NFA71-5 char[1]")
end
subgraph DFA4_-308693276["DFA4 {1}"]
NFA71_7_61185139_4("NFA71-7 char[1]")
end
subgraph DFA5_-1642658479["DFA5 {1}"]
NFA71_9_13795340_5("NFA71-9 char[1]")
end
subgraph DFA6_1016840099["DFA6 {1}"]
NFA71_11_57049196_6("NFA71-11 char[1]")
end
subgraph DFA7_1721335259["DFA7 {1}"]
NFA71_13_43680716_7("NFA71-13 char[1]")
end
subgraph DFA8_1833415204["DFA8 {1}"]
NFA71_15_57582125_8[\"NFA71-15 char[1]"/]
end
DFA0_688241250 -->|"r"|DFA1_1749333082
DFA1_1749333082 -->|"e"|DFA2_-686162261
DFA2_-686162261 -->|"a"|DFA3_1033640031
DFA3_1033640031 -->|"d"|DFA4_-308693276
DFA4_-308693276 -->|"o"|DFA5_-1642658479
DFA5_-1642658479 -->|"n"|DFA6_1016840099
DFA6_1016840099 -->|"l"|DFA7_1721335259
DFA7_1721335259 -->|"y"|DFA8_1833415204
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
DFA0_688241250{{"DFA0 regex start"}}
DFA1_1749333082{{"DFA1 {1}"}}
DFA2_-686162261{{"DFA2 {1}"}}
DFA3_1033640031{{"DFA3 {1}"}}
DFA4_-308693276{{"DFA4 {1}"}}
DFA5_-1642658479{{"DFA5 {1}"}}
DFA6_1016840099{{"DFA6 {1}"}}
DFA7_1721335259{{"DFA7 {1}"}}
DFA8_1833415204[\"DFA8 {1}"/]
DFA0_688241250 -->|"r"|DFA1_1749333082
DFA1_1749333082 -->|"e"|DFA2_-686162261
DFA2_-686162261 -->|"a"|DFA3_1033640031
DFA3_1033640031 -->|"d"|DFA4_-308693276
DFA4_-308693276 -->|"o"|DFA5_-1642658479
DFA5_-1642658479 -->|"n"|DFA6_1016840099
DFA6_1016840099 -->|"l"|DFA7_1721335259
DFA7_1721335259 -->|"y"|DFA8_1833415204
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
subgraph MiniDFA0_-1659847074["MiniDFA0 {1}"]
DFA0_688241250_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1837862799["MiniDFA1 {1}"]
DFA1_1749333082_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1909286321["MiniDFA2 {1}"]
DFA2_-686162261_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-616303260["MiniDFA3 {1}"]
DFA3_1033640031_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1763580297["MiniDFA4 {1}"]
DFA4_-308693276_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1444043424["MiniDFA5 {1}"]
DFA5_-1642658479_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1010003914["MiniDFA6 {1}"]
DFA6_1016840099_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1036162729["MiniDFA7 {1}"]
DFA7_1721335259_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-1852219540["MiniDFA8 {1}"]
DFA8_1833415204_8[\"DFA8 {1}"/]
end
MiniDFA0_-1659847074 -->|"r"|MiniDFA1_1837862799
MiniDFA1_1837862799 -->|"e"|MiniDFA2_1909286321
MiniDFA2_1909286321 -->|"a"|MiniDFA3_-616303260
MiniDFA3_-616303260 -->|"d"|MiniDFA4_1763580297
MiniDFA4_1763580297 -->|"o"|MiniDFA5_-1444043424
MiniDFA5_-1444043424 -->|"n"|MiniDFA6_-1010003914
MiniDFA6_-1010003914 -->|"l"|MiniDFA7_1036162729
MiniDFA7_1036162729 -->|"y"|MiniDFA8_-1852219540
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
MiniDFA0_-1659847074(["MiniDFA0 {1}"])
MiniDFA1_1837862799(["MiniDFA1 {1}"])
MiniDFA2_1909286321(["MiniDFA2 {1}"])
MiniDFA3_-616303260(["MiniDFA3 {1}"])
MiniDFA4_1763580297(["MiniDFA4 {1}"])
MiniDFA5_-1444043424(["MiniDFA5 {1}"])
MiniDFA6_-1010003914(["MiniDFA6 {1}"])
MiniDFA7_1036162729(["MiniDFA7 {1}"])
MiniDFA8_-1852219540[\"MiniDFA8 {1}"/]
MiniDFA0_-1659847074 -->|"r"|MiniDFA1_1837862799
MiniDFA1_1837862799 -->|"e"|MiniDFA2_1909286321
MiniDFA2_1909286321 -->|"a"|MiniDFA3_-616303260
MiniDFA3_-616303260 -->|"d"|MiniDFA4_1763580297
MiniDFA4_1763580297 -->|"o"|MiniDFA5_-1444043424
MiniDFA5_-1444043424 -->|"n"|MiniDFA6_-1010003914
MiniDFA6_-1010003914 -->|"l"|MiniDFA7_1036162729
MiniDFA7_1036162729 -->|"y"|MiniDFA8_-1852219540
```
-------------------------------
