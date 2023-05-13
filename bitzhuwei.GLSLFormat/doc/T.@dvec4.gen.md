# 'dvec4'

pattern: `dvec4`

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
eNFA85_10_46224020[["εNFA85-10 regex start"]]
eNFA85_0_13362997[["εNFA85-0 char{1, 1}"]]
eNFA85_1_53158116[["εNFA85-1 char[1]"]]
eNFA85_2_8661001[["εNFA85-2 char{1, 1}"]]
eNFA85_3_10840149[["εNFA85-3 char[1]"]]
eNFA85_4_30452481[["εNFA85-4 char{1, 1}"]]
eNFA85_5_5636878[["εNFA85-5 char[1]"]]
eNFA85_6_50731910[["εNFA85-6 char{1, 1}"]]
eNFA85_7_53934008[["εNFA85-7 char[1]"]]
eNFA85_8_15644031[["εNFA85-8 char{1, 1}"]]
eNFA85_9_6578555[["εNFA85-9 char[1]"]]
eNFA85_11_59206997[["εNFA85-11 regex end"]]
eNFA85_12_63100926[["εNFA85-12 post-regex start"]]
eNFA85_13_31037423[\"εNFA85-13 post-regex end"/]
eNFA85_10_46224020 -.->|"ε"|eNFA85_0_13362997
eNFA85_0_13362997 -->|"d"|eNFA85_1_53158116
eNFA85_1_53158116 -.->|"ε"|eNFA85_2_8661001
eNFA85_2_8661001 -->|"v"|eNFA85_3_10840149
eNFA85_3_10840149 -.->|"ε"|eNFA85_4_30452481
eNFA85_4_30452481 -->|"e"|eNFA85_5_5636878
eNFA85_5_5636878 -.->|"ε"|eNFA85_6_50731910
eNFA85_6_50731910 -->|"c"|eNFA85_7_53934008
eNFA85_7_53934008 -.->|"ε"|eNFA85_8_15644031
eNFA85_8_15644031 -->|"4"|eNFA85_9_6578555
eNFA85_9_6578555 -.->|"ε"|eNFA85_11_59206997
eNFA85_11_59206997 -.->|"ε"|eNFA85_12_63100926
eNFA85_12_63100926 -.->|"ε"|eNFA85_13_31037423
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
eNFA85_10_10901353[["εNFA85-10 regex start"]]
eNFA85_0_31003317[["εNFA85-0 char{1, 1}"]]
eNFA85_1_10594405[["εNFA85-1 char[1]"]]
eNFA85_2_28240785[["εNFA85-2 char{1, 1}"]]
eNFA85_3_52840473[["εNFA85-3 char[1]"]]
eNFA85_4_5802216[["εNFA85-4 char{1, 1}"]]
eNFA85_5_52219950[["εNFA85-5 char[1]"]]
eNFA85_6_217508[["εNFA85-6 char{1, 1}"]]
eNFA85_7_1957580[["εNFA85-7 char[1]"]]
eNFA85_8_17618221[["εNFA85-8 char{1, 1}"]]
eNFA85_9_24346266[\"εNFA85-9 char[1]"/]
eNFA85_11_17789802[\"εNFA85-11 regex end"/]
eNFA85_12_25890496[\"εNFA85-12 post-regex start"/]
eNFA85_13_31687876[\"εNFA85-13 post-regex end"/]
eNFA85_10_10901353 -.->|"ε"|eNFA85_0_31003317
eNFA85_10_10901353 -->|"d"|eNFA85_1_10594405
eNFA85_0_31003317 -->|"d"|eNFA85_1_10594405
eNFA85_1_10594405 -.->|"ε"|eNFA85_2_28240785
eNFA85_1_10594405 -->|"v"|eNFA85_3_52840473
eNFA85_2_28240785 -->|"v"|eNFA85_3_52840473
eNFA85_3_52840473 -.->|"ε"|eNFA85_4_5802216
eNFA85_3_52840473 -->|"e"|eNFA85_5_52219950
eNFA85_4_5802216 -->|"e"|eNFA85_5_52219950
eNFA85_5_52219950 -.->|"ε"|eNFA85_6_217508
eNFA85_5_52219950 -->|"c"|eNFA85_7_1957580
eNFA85_6_217508 -->|"c"|eNFA85_7_1957580
eNFA85_7_1957580 -.->|"ε"|eNFA85_8_17618221
eNFA85_7_1957580 -->|"4"|eNFA85_9_24346266
eNFA85_8_17618221 -->|"4"|eNFA85_9_24346266
eNFA85_9_24346266 -.->|"ε"|eNFA85_11_17789802
eNFA85_9_24346266 -.->|"ε"|eNFA85_12_25890496
eNFA85_9_24346266 -.->|"ε"|eNFA85_13_31687876
eNFA85_11_17789802 -.->|"ε"|eNFA85_12_25890496
eNFA85_11_17789802 -.->|"ε"|eNFA85_13_31687876
eNFA85_12_25890496 -.->|"ε"|eNFA85_13_31687876
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
NFA85_10_16755431("NFA85-10 regex start")
NFA85_1_16581154("NFA85-1 char[1]")
NFA85_3_15012662("NFA85-3 char[1]")
NFA85_5_896237("NFA85-5 char[1]")
NFA85_7_8066134("NFA85-7 char[1]")
NFA85_9_5486348[\"NFA85-9 char[1]"/]
NFA85_10_16755431 -->|"d"|NFA85_1_16581154
NFA85_1_16581154 -->|"v"|NFA85_3_15012662
NFA85_3_15012662 -->|"e"|NFA85_5_896237
NFA85_5_896237 -->|"c"|NFA85_7_8066134
NFA85_7_8066134 -->|"4"|NFA85_9_5486348
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
subgraph DFA0_-669732222["DFA0 regex start"]
NFA85_10_16755431_0("NFA85-10 regex start")
end
subgraph DFA1_-744491275["DFA1 {1}"]
NFA85_1_16581154_1("NFA85-1 char[1]")
end
subgraph DFA2_-230498320["DFA2 {1}"]
NFA85_3_15012662_2("NFA85-3 char[1]")
end
subgraph DFA3_-730706719["DFA3 {1}"]
NFA85_5_896237_3("NFA85-5 char[1]")
end
subgraph DFA4_-2097987549["DFA4 {1}"]
NFA85_7_8066134_4("NFA85-7 char[1]")
end
subgraph DFA5_-898137832["DFA5 {1}"]
NFA85_9_5486348_5[\"NFA85-9 char[1]"/]
end
DFA0_-669732222 -->|"d"|DFA1_-744491275
DFA1_-744491275 -->|"v"|DFA2_-230498320
DFA2_-230498320 -->|"e"|DFA3_-730706719
DFA3_-730706719 -->|"c"|DFA4_-2097987549
DFA4_-2097987549 -->|"4"|DFA5_-898137832
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
DFA0_-669732222{{"DFA0 regex start"}}
DFA1_-744491275{{"DFA1 {1}"}}
DFA2_-230498320{{"DFA2 {1}"}}
DFA3_-730706719{{"DFA3 {1}"}}
DFA4_-2097987549{{"DFA4 {1}"}}
DFA5_-898137832[\"DFA5 {1}"/]
DFA0_-669732222 -->|"d"|DFA1_-744491275
DFA1_-744491275 -->|"v"|DFA2_-230498320
DFA2_-230498320 -->|"e"|DFA3_-730706719
DFA3_-730706719 -->|"c"|DFA4_-2097987549
DFA4_-2097987549 -->|"4"|DFA5_-898137832
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
subgraph MiniDFA0_-755853741["MiniDFA0 {1}"]
DFA0_-669732222_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_121222861["MiniDFA1 {1}"]
DFA1_-744491275_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-819832582["MiniDFA2 {1}"]
DFA2_-230498320_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_410942544["MiniDFA3 {1}"]
DFA3_-730706719_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1607678908["MiniDFA4 {1}"]
DFA4_-2097987549_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_738955797["MiniDFA5 {1}"]
DFA5_-898137832_5[\"DFA5 {1}"/]
end
MiniDFA0_-755853741 -->|"d"|MiniDFA1_121222861
MiniDFA1_121222861 -->|"v"|MiniDFA2_-819832582
MiniDFA2_-819832582 -->|"e"|MiniDFA3_410942544
MiniDFA3_410942544 -->|"c"|MiniDFA4_1607678908
MiniDFA4_1607678908 -->|"4"|MiniDFA5_738955797
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
MiniDFA0_-755853741(["MiniDFA0 {1}"])
MiniDFA1_121222861(["MiniDFA1 {1}"])
MiniDFA2_-819832582(["MiniDFA2 {1}"])
MiniDFA3_410942544(["MiniDFA3 {1}"])
MiniDFA4_1607678908(["MiniDFA4 {1}"])
MiniDFA5_738955797[\"MiniDFA5 {1}"/]
MiniDFA0_-755853741 -->|"d"|MiniDFA1_121222861
MiniDFA1_121222861 -->|"v"|MiniDFA2_-819832582
MiniDFA2_-819832582 -->|"e"|MiniDFA3_410942544
MiniDFA3_410942544 -->|"c"|MiniDFA4_1607678908
MiniDFA4_1607678908 -->|"4"|MiniDFA5_738955797
```
-------------------------------
