# 'centroid'

pattern: `centroid`

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
eNFA62_16_55124180[["εNFA62-16 regex start"]]
eNFA62_0_26355580[["εNFA62-0 char{1, 1}"]]
eNFA62_1_35873632[["εNFA62-1 char[1]"]]
eNFA62_2_54427232[["εNFA62-2 char{1, 1}"]]
eNFA62_3_20083047[["εNFA62-3 char[1]"]]
eNFA62_4_46529701[["εNFA62-4 char{1, 1}"]]
eNFA62_5_16114131[["εNFA62-5 char[1]"]]
eNFA62_6_10809459[["εNFA62-6 char{1, 1}"]]
eNFA62_7_30176268[["εNFA62-7 char[1]"]]
eNFA62_8_3150961[["εNFA62-8 char{1, 1}"]]
eNFA62_9_28358649[["εNFA62-9 char[1]"]]
eNFA62_10_53901255[["εNFA62-10 char{1, 1}"]]
eNFA62_11_15349251[["εNFA62-11 char[1]"]]
eNFA62_12_3925534[["εNFA62-12 char{1, 1}"]]
eNFA62_13_35329809[["εNFA62-13 char[1]"]]
eNFA62_14_49532829[["εNFA62-14 char{1, 1}"]]
eNFA62_15_43142284[["εNFA62-15 char[1]"]]
eNFA62_17_52736237[["εNFA62-17 regex end"]]
eNFA62_18_4864091[["εNFA62-18 post-regex start"]]
eNFA62_19_43776822[\"εNFA62-19 post-regex end"/]
eNFA62_16_55124180 -.->|"ε"|eNFA62_0_26355580
eNFA62_0_26355580 -->|"c"|eNFA62_1_35873632
eNFA62_1_35873632 -.->|"ε"|eNFA62_2_54427232
eNFA62_2_54427232 -->|"e"|eNFA62_3_20083047
eNFA62_3_20083047 -.->|"ε"|eNFA62_4_46529701
eNFA62_4_46529701 -->|"n"|eNFA62_5_16114131
eNFA62_5_16114131 -.->|"ε"|eNFA62_6_10809459
eNFA62_6_10809459 -->|"t"|eNFA62_7_30176268
eNFA62_7_30176268 -.->|"ε"|eNFA62_8_3150961
eNFA62_8_3150961 -->|"r"|eNFA62_9_28358649
eNFA62_9_28358649 -.->|"ε"|eNFA62_10_53901255
eNFA62_10_53901255 -->|"o"|eNFA62_11_15349251
eNFA62_11_15349251 -.->|"ε"|eNFA62_12_3925534
eNFA62_12_3925534 -->|"i"|eNFA62_13_35329809
eNFA62_13_35329809 -.->|"ε"|eNFA62_14_49532829
eNFA62_14_49532829 -->|"d"|eNFA62_15_43142284
eNFA62_15_43142284 -.->|"ε"|eNFA62_17_52736237
eNFA62_17_52736237 -.->|"ε"|eNFA62_18_4864091
eNFA62_18_4864091 -.->|"ε"|eNFA62_19_43776822
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
eNFA62_16_58447079[["εNFA62-16 regex start"]]
eNFA62_0_56261663[["εNFA62-0 char{1, 1}"]]
eNFA62_1_36592919[["εNFA62-1 char[1]"]]
eNFA62_2_60900816[["εNFA62-2 char{1, 1}"]]
eNFA62_3_11236435[["εNFA62-3 char[1]"]]
eNFA62_4_34019058[["εNFA62-4 char{1, 1}"]]
eNFA62_5_37736068[["εNFA62-5 char[1]"]]
eNFA62_6_4080300[["εNFA62-6 char{1, 1}"]]
eNFA62_7_36722706[["εNFA62-7 char[1]"]]
eNFA62_8_62068903[["εNFA62-8 char{1, 1}"]]
eNFA62_9_21749220[["εNFA62-9 char[1]"]]
eNFA62_10_61525259[["εNFA62-10 char{1, 1}"]]
eNFA62_11_16856419[["εNFA62-11 char[1]"]]
eNFA62_12_17490046[["εNFA62-12 char{1, 1}"]]
eNFA62_13_23192694[["εNFA62-13 char[1]"]]
eNFA62_14_7407659[["εNFA62-14 char{1, 1}"]]
eNFA62_15_66668934[\"εNFA62-15 char[1]"/]
eNFA62_17_63149496[\"εNFA62-17 regex end"/]
eNFA62_18_31474554[\"εNFA62-18 post-regex start"/]
eNFA62_19_14835533[\"εNFA62-19 post-regex end"/]
eNFA62_16_58447079 -.->|"ε"|eNFA62_0_56261663
eNFA62_16_58447079 -->|"c"|eNFA62_1_36592919
eNFA62_0_56261663 -->|"c"|eNFA62_1_36592919
eNFA62_1_36592919 -.->|"ε"|eNFA62_2_60900816
eNFA62_1_36592919 -->|"e"|eNFA62_3_11236435
eNFA62_2_60900816 -->|"e"|eNFA62_3_11236435
eNFA62_3_11236435 -.->|"ε"|eNFA62_4_34019058
eNFA62_3_11236435 -->|"n"|eNFA62_5_37736068
eNFA62_4_34019058 -->|"n"|eNFA62_5_37736068
eNFA62_5_37736068 -.->|"ε"|eNFA62_6_4080300
eNFA62_5_37736068 -->|"t"|eNFA62_7_36722706
eNFA62_6_4080300 -->|"t"|eNFA62_7_36722706
eNFA62_7_36722706 -.->|"ε"|eNFA62_8_62068903
eNFA62_7_36722706 -->|"r"|eNFA62_9_21749220
eNFA62_8_62068903 -->|"r"|eNFA62_9_21749220
eNFA62_9_21749220 -.->|"ε"|eNFA62_10_61525259
eNFA62_9_21749220 -->|"o"|eNFA62_11_16856419
eNFA62_10_61525259 -->|"o"|eNFA62_11_16856419
eNFA62_11_16856419 -.->|"ε"|eNFA62_12_17490046
eNFA62_11_16856419 -->|"i"|eNFA62_13_23192694
eNFA62_12_17490046 -->|"i"|eNFA62_13_23192694
eNFA62_13_23192694 -.->|"ε"|eNFA62_14_7407659
eNFA62_13_23192694 -->|"d"|eNFA62_15_66668934
eNFA62_14_7407659 -->|"d"|eNFA62_15_66668934
eNFA62_15_66668934 -.->|"ε"|eNFA62_17_63149496
eNFA62_15_66668934 -.->|"ε"|eNFA62_18_31474554
eNFA62_15_66668934 -.->|"ε"|eNFA62_19_14835533
eNFA62_17_63149496 -.->|"ε"|eNFA62_18_31474554
eNFA62_17_63149496 -.->|"ε"|eNFA62_19_14835533
eNFA62_18_31474554 -.->|"ε"|eNFA62_19_14835533
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
NFA62_16_66410939("NFA62-16 regex start")
NFA62_1_60827539("NFA62-1 char[1]")
NFA62_3_10576944("NFA62-3 char[1]")
NFA62_5_28083633("NFA62-5 char[1]")
NFA62_7_51426113("NFA62-7 char[1]")
NFA62_9_60181840("NFA62-9 char[1]")
NFA62_11_4765656("NFA62-11 char[1]")
NFA62_13_42890904("NFA62-13 char[1]")
NFA62_15_50473818[\"NFA62-15 char[1]"/]
NFA62_16_66410939 -->|"c"|NFA62_1_60827539
NFA62_1_60827539 -->|"e"|NFA62_3_10576944
NFA62_3_10576944 -->|"n"|NFA62_5_28083633
NFA62_5_28083633 -->|"t"|NFA62_7_51426113
NFA62_7_51426113 -->|"r"|NFA62_9_60181840
NFA62_9_60181840 -->|"o"|NFA62_11_4765656
NFA62_11_4765656 -->|"i"|NFA62_13_42890904
NFA62_13_42890904 -->|"d"|NFA62_15_50473818
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
subgraph DFA0_-183484194["DFA0 regex start"]
NFA62_16_66410939_0("NFA62-16 regex start")
end
subgraph DFA1_-2127216824["DFA1 {1}"]
NFA62_1_60827539_1("NFA62-1 char[1]")
end
subgraph DFA2_-913666876["DFA2 {1}"]
NFA62_3_10576944_2("NFA62-3 char[1]")
end
subgraph DFA3_5733027["DFA3 {1}"]
NFA62_5_28083633_3("NFA62-5 char[1]")
end
subgraph DFA4_65103619["DFA4 {1}"]
NFA62_7_51426113_4("NFA62-7 char[1]")
end
subgraph DFA5_-436984169["DFA5 {1}"]
NFA62_9_60181840_5("NFA62-9 char[1]")
end
subgraph DFA6_1117366341["DFA6 {1}"]
NFA62_11_4765656_6("NFA62-11 char[1]")
end
subgraph DFA7_1915246050["DFA7 {1}"]
NFA62_13_42890904_7("NFA62-13 char[1]")
end
subgraph DFA8_-1389601564["DFA8 {1}"]
NFA62_15_50473818_8[\"NFA62-15 char[1]"/]
end
DFA0_-183484194 -->|"c"|DFA1_-2127216824
DFA1_-2127216824 -->|"e"|DFA2_-913666876
DFA2_-913666876 -->|"n"|DFA3_5733027
DFA3_5733027 -->|"t"|DFA4_65103619
DFA4_65103619 -->|"r"|DFA5_-436984169
DFA5_-436984169 -->|"o"|DFA6_1117366341
DFA6_1117366341 -->|"i"|DFA7_1915246050
DFA7_1915246050 -->|"d"|DFA8_-1389601564
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
DFA0_-183484194{{"DFA0 regex start"}}
DFA1_-2127216824{{"DFA1 {1}"}}
DFA2_-913666876{{"DFA2 {1}"}}
DFA3_5733027{{"DFA3 {1}"}}
DFA4_65103619{{"DFA4 {1}"}}
DFA5_-436984169{{"DFA5 {1}"}}
DFA6_1117366341{{"DFA6 {1}"}}
DFA7_1915246050{{"DFA7 {1}"}}
DFA8_-1389601564[\"DFA8 {1}"/]
DFA0_-183484194 -->|"c"|DFA1_-2127216824
DFA1_-2127216824 -->|"e"|DFA2_-913666876
DFA2_-913666876 -->|"n"|DFA3_5733027
DFA3_5733027 -->|"t"|DFA4_65103619
DFA4_65103619 -->|"r"|DFA5_-436984169
DFA5_-436984169 -->|"o"|DFA6_1117366341
DFA6_1117366341 -->|"i"|DFA7_1915246050
DFA7_1915246050 -->|"d"|DFA8_-1389601564
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
subgraph MiniDFA0_2129669051["MiniDFA0 {1}"]
DFA0_-183484194_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1739886929["MiniDFA1 {1}"]
DFA1_-2127216824_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-254430260["MiniDFA2 {1}"]
DFA2_-913666876_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1963808780["MiniDFA3 {1}"]
DFA3_5733027_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1714315200["MiniDFA4 {1}"]
DFA4_65103619_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_94343477["MiniDFA5 {1}"]
DFA5_-436984169_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-2126761036["MiniDFA6 {1}"]
DFA6_1117366341_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1716506534["MiniDFA7 {1}"]
DFA7_1915246050_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-602666709["MiniDFA8 {1}"]
DFA8_-1389601564_8[\"DFA8 {1}"/]
end
MiniDFA0_2129669051 -->|"c"|MiniDFA1_-1739886929
MiniDFA1_-1739886929 -->|"e"|MiniDFA2_-254430260
MiniDFA2_-254430260 -->|"n"|MiniDFA3_-1963808780
MiniDFA3_-1963808780 -->|"t"|MiniDFA4_-1714315200
MiniDFA4_-1714315200 -->|"r"|MiniDFA5_94343477
MiniDFA5_94343477 -->|"o"|MiniDFA6_-2126761036
MiniDFA6_-2126761036 -->|"i"|MiniDFA7_1716506534
MiniDFA7_1716506534 -->|"d"|MiniDFA8_-602666709
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
MiniDFA0_2129669051(["MiniDFA0 {1}"])
MiniDFA1_-1739886929(["MiniDFA1 {1}"])
MiniDFA2_-254430260(["MiniDFA2 {1}"])
MiniDFA3_-1963808780(["MiniDFA3 {1}"])
MiniDFA4_-1714315200(["MiniDFA4 {1}"])
MiniDFA5_94343477(["MiniDFA5 {1}"])
MiniDFA6_-2126761036(["MiniDFA6 {1}"])
MiniDFA7_1716506534(["MiniDFA7 {1}"])
MiniDFA8_-602666709[\"MiniDFA8 {1}"/]
MiniDFA0_2129669051 -->|"c"|MiniDFA1_-1739886929
MiniDFA1_-1739886929 -->|"e"|MiniDFA2_-254430260
MiniDFA2_-254430260 -->|"n"|MiniDFA3_-1963808780
MiniDFA3_-1963808780 -->|"t"|MiniDFA4_-1714315200
MiniDFA4_-1714315200 -->|"r"|MiniDFA5_94343477
MiniDFA5_94343477 -->|"o"|MiniDFA6_-2126761036
MiniDFA6_-2126761036 -->|"i"|MiniDFA7_1716506534
MiniDFA7_1716506534 -->|"d"|MiniDFA8_-602666709
```
-------------------------------
