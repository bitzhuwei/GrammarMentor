# 'sample'

pattern: `sample`

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
eNFA64_12_51313205[["εNFA64-12 regex start"]]
eNFA64_0_59165662[["εNFA64-0 char{1, 1}"]]
eNFA64_1_62728917[["εNFA64-1 char[1]"]]
eNFA64_2_27689346[["εNFA64-2 char{1, 1}"]]
eNFA64_3_47877526[["εNFA64-3 char[1]"]]
eNFA64_4_28244554[["εNFA64-4 char{1, 1}"]]
eNFA64_5_52874399[["εNFA64-5 char[1]"]]
eNFA64_6_6107551[["εNFA64-6 char{1, 1}"]]
eNFA64_7_54967961[["εNFA64-7 char[1]"]]
eNFA64_8_24949608[["εNFA64-8 char{1, 1}"]]
eNFA64_9_23219884[["εNFA64-9 char[1]"]]
eNFA64_10_7652366[["εNFA64-10 char{1, 1}"]]
eNFA64_11_1762431[["εNFA64-11 char[1]"]]
eNFA64_13_15861880[["εNFA64-13 regex end"]]
eNFA64_14_8539194[["εNFA64-14 post-regex start"]]
eNFA64_15_9743886[\"εNFA64-15 post-regex end"/]
eNFA64_12_51313205 -.->|"ε"|eNFA64_0_59165662
eNFA64_0_59165662 -->|"s"|eNFA64_1_62728917
eNFA64_1_62728917 -.->|"ε"|eNFA64_2_27689346
eNFA64_2_27689346 -->|"a"|eNFA64_3_47877526
eNFA64_3_47877526 -.->|"ε"|eNFA64_4_28244554
eNFA64_4_28244554 -->|"m"|eNFA64_5_52874399
eNFA64_5_52874399 -.->|"ε"|eNFA64_6_6107551
eNFA64_6_6107551 -->|"p"|eNFA64_7_54967961
eNFA64_7_54967961 -.->|"ε"|eNFA64_8_24949608
eNFA64_8_24949608 -->|"l"|eNFA64_9_23219884
eNFA64_9_23219884 -.->|"ε"|eNFA64_10_7652366
eNFA64_10_7652366 -->|"e"|eNFA64_11_1762431
eNFA64_11_1762431 -.->|"ε"|eNFA64_13_15861880
eNFA64_13_15861880 -.->|"ε"|eNFA64_14_8539194
eNFA64_14_8539194 -.->|"ε"|eNFA64_15_9743886
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
eNFA64_12_20586118[["εNFA64-12 regex start"]]
eNFA64_0_51057338[["εNFA64-0 char{1, 1}"]]
eNFA64_1_56862858[["εNFA64-1 char[1]"]]
eNFA64_2_42003681[["εNFA64-2 char{1, 1}"]]
eNFA64_3_42488815[["εNFA64-3 char[1]"]]
eNFA64_4_46855021[["εNFA64-4 char{1, 1}"]]
eNFA64_5_19042013[["εNFA64-5 char[1]"]]
eNFA64_6_37160390[["εNFA64-6 char{1, 1}"]]
eNFA64_7_66008059[["εNFA64-7 char[1]"]]
eNFA64_8_57201619[["εNFA64-8 char{1, 1}"]]
eNFA64_9_45052529[["εNFA64-9 char[1]"]]
eNFA64_10_2819581[["εNFA64-10 char{1, 1}"]]
eNFA64_11_25376232[\"εNFA64-11 char[1]"/]
eNFA64_13_27059499[\"εNFA64-13 regex end"/]
eNFA64_14_42208903[\"εNFA64-14 post-regex start"/]
eNFA64_15_44335814[\"εNFA64-15 post-regex end"/]
eNFA64_12_20586118 -.->|"ε"|eNFA64_0_51057338
eNFA64_12_20586118 -->|"s"|eNFA64_1_56862858
eNFA64_0_51057338 -->|"s"|eNFA64_1_56862858
eNFA64_1_56862858 -.->|"ε"|eNFA64_2_42003681
eNFA64_1_56862858 -->|"a"|eNFA64_3_42488815
eNFA64_2_42003681 -->|"a"|eNFA64_3_42488815
eNFA64_3_42488815 -.->|"ε"|eNFA64_4_46855021
eNFA64_3_42488815 -->|"m"|eNFA64_5_19042013
eNFA64_4_46855021 -->|"m"|eNFA64_5_19042013
eNFA64_5_19042013 -.->|"ε"|eNFA64_6_37160390
eNFA64_5_19042013 -->|"p"|eNFA64_7_66008059
eNFA64_6_37160390 -->|"p"|eNFA64_7_66008059
eNFA64_7_66008059 -.->|"ε"|eNFA64_8_57201619
eNFA64_7_66008059 -->|"l"|eNFA64_9_45052529
eNFA64_8_57201619 -->|"l"|eNFA64_9_45052529
eNFA64_9_45052529 -.->|"ε"|eNFA64_10_2819581
eNFA64_9_45052529 -->|"e"|eNFA64_11_25376232
eNFA64_10_2819581 -->|"e"|eNFA64_11_25376232
eNFA64_11_25376232 -.->|"ε"|eNFA64_13_27059499
eNFA64_11_25376232 -.->|"ε"|eNFA64_14_42208903
eNFA64_11_25376232 -.->|"ε"|eNFA64_15_44335814
eNFA64_13_27059499 -.->|"ε"|eNFA64_14_42208903
eNFA64_13_27059499 -.->|"ε"|eNFA64_15_44335814
eNFA64_14_42208903 -.->|"ε"|eNFA64_15_44335814
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
NFA64_12_63478007("NFA64-12 regex start")
NFA64_1_34431157("NFA64-1 char[1]")
NFA64_3_41444960("NFA64-3 char[1]")
NFA64_5_37460321("NFA64-5 char[1]")
NFA64_7_1598569("NFA64-7 char[1]")
NFA64_9_14387121("NFA64-9 char[1]")
NFA64_11_62375226[\"NFA64-11 char[1]"/]
NFA64_12_63478007 -->|"s"|NFA64_1_34431157
NFA64_1_34431157 -->|"a"|NFA64_3_41444960
NFA64_3_41444960 -->|"m"|NFA64_5_37460321
NFA64_5_37460321 -->|"p"|NFA64_7_1598569
NFA64_7_1598569 -->|"l"|NFA64_9_14387121
NFA64_9_14387121 -->|"e"|NFA64_11_62375226
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
subgraph DFA0_-1689371471["DFA0 regex start"]
NFA64_12_63478007_0("NFA64-12 regex start")
end
subgraph DFA1_-1747155881["DFA1 {1}"]
NFA64_1_34431157_1("NFA64-1 char[1]")
end
subgraph DFA2_-1542327992["DFA2 {1}"]
NFA64_3_41444960_2("NFA64-3 char[1]")
end
subgraph DFA3_-1879493929["DFA3 {1}"]
NFA64_5_37460321_3("NFA64-5 char[1]")
end
subgraph DFA4_-1014319598["DFA4 {1}"]
NFA64_7_1598569_4("NFA64-7 char[1]")
end
subgraph DFA5_273923956["DFA5 {1}"]
NFA64_9_14387121_5("NFA64-9 char[1]")
end
subgraph DFA6_514102069["DFA6 {1}"]
NFA64_11_62375226_6[\"NFA64-11 char[1]"/]
end
DFA0_-1689371471 -->|"s"|DFA1_-1747155881
DFA1_-1747155881 -->|"a"|DFA2_-1542327992
DFA2_-1542327992 -->|"m"|DFA3_-1879493929
DFA3_-1879493929 -->|"p"|DFA4_-1014319598
DFA4_-1014319598 -->|"l"|DFA5_273923956
DFA5_273923956 -->|"e"|DFA6_514102069
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
DFA0_-1689371471{{"DFA0 regex start"}}
DFA1_-1747155881{{"DFA1 {1}"}}
DFA2_-1542327992{{"DFA2 {1}"}}
DFA3_-1879493929{{"DFA3 {1}"}}
DFA4_-1014319598{{"DFA4 {1}"}}
DFA5_273923956{{"DFA5 {1}"}}
DFA6_514102069[\"DFA6 {1}"/]
DFA0_-1689371471 -->|"s"|DFA1_-1747155881
DFA1_-1747155881 -->|"a"|DFA2_-1542327992
DFA2_-1542327992 -->|"m"|DFA3_-1879493929
DFA3_-1879493929 -->|"p"|DFA4_-1014319598
DFA4_-1014319598 -->|"l"|DFA5_273923956
DFA5_273923956 -->|"e"|DFA6_514102069
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
subgraph MiniDFA0_-1275943097["MiniDFA0 {1}"]
DFA0_-1689371471_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-99479025["MiniDFA1 {1}"]
DFA1_-1747155881_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-479050532["MiniDFA2 {1}"]
DFA2_-1542327992_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_2068761652["MiniDFA3 {1}"]
DFA3_-1879493929_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1672951963["MiniDFA4 {1}"]
DFA4_-1014319598_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_579476771["MiniDFA5 {1}"]
DFA5_273923956_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-2048874676["MiniDFA6 {1}"]
DFA6_514102069_6[\"DFA6 {1}"/]
end
MiniDFA0_-1275943097 -->|"s"|MiniDFA1_-99479025
MiniDFA1_-99479025 -->|"a"|MiniDFA2_-479050532
MiniDFA2_-479050532 -->|"m"|MiniDFA3_2068761652
MiniDFA3_2068761652 -->|"p"|MiniDFA4_1672951963
MiniDFA4_1672951963 -->|"l"|MiniDFA5_579476771
MiniDFA5_579476771 -->|"e"|MiniDFA6_-2048874676
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
MiniDFA0_-1275943097(["MiniDFA0 {1}"])
MiniDFA1_-99479025(["MiniDFA1 {1}"])
MiniDFA2_-479050532(["MiniDFA2 {1}"])
MiniDFA3_2068761652(["MiniDFA3 {1}"])
MiniDFA4_1672951963(["MiniDFA4 {1}"])
MiniDFA5_579476771(["MiniDFA5 {1}"])
MiniDFA6_-2048874676[\"MiniDFA6 {1}"/]
MiniDFA0_-1275943097 -->|"s"|MiniDFA1_-99479025
MiniDFA1_-99479025 -->|"a"|MiniDFA2_-479050532
MiniDFA2_-479050532 -->|"m"|MiniDFA3_2068761652
MiniDFA3_2068761652 -->|"p"|MiniDFA4_1672951963
MiniDFA4_1672951963 -->|"l"|MiniDFA5_579476771
MiniDFA5_579476771 -->|"e"|MiniDFA6_-2048874676
```
-------------------------------
