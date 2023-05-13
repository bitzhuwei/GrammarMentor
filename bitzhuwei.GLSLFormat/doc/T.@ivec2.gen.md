# 'ivec2'

pattern: `ivec2`

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
eNFA89_10_9424035[["εNFA89-10 regex start"]]
eNFA89_0_17707452[["εNFA89-0 char{1, 1}"]]
eNFA89_1_25149347[["εNFA89-1 char[1]"]]
eNFA89_2_25017536[["εNFA89-2 char{1, 1}"]]
eNFA89_3_23831236[["εNFA89-3 char[1]"]]
eNFA89_4_13154536[["εNFA89-4 char{1, 1}"]]
eNFA89_5_51281965[["εNFA89-5 char[1]"]]
eNFA89_6_58884509[["εNFA89-6 char{1, 1}"]]
eNFA89_7_60198535[["εNFA89-7 char[1]"]]
eNFA89_8_4915910[["εNFA89-8 char{1, 1}"]]
eNFA89_9_44243194[["εNFA89-9 char[1]"]]
eNFA89_11_62644428[["εNFA89-11 regex end"]]
eNFA89_12_26928941[["εNFA89-12 post-regex start"]]
eNFA89_13_41033878[\"εNFA89-13 post-regex end"/]
eNFA89_10_9424035 -.->|"ε"|eNFA89_0_17707452
eNFA89_0_17707452 -->|"i"|eNFA89_1_25149347
eNFA89_1_25149347 -.->|"ε"|eNFA89_2_25017536
eNFA89_2_25017536 -->|"v"|eNFA89_3_23831236
eNFA89_3_23831236 -.->|"ε"|eNFA89_4_13154536
eNFA89_4_13154536 -->|"e"|eNFA89_5_51281965
eNFA89_5_51281965 -.->|"ε"|eNFA89_6_58884509
eNFA89_6_58884509 -->|"c"|eNFA89_7_60198535
eNFA89_7_60198535 -.->|"ε"|eNFA89_8_4915910
eNFA89_8_4915910 -->|"2"|eNFA89_9_44243194
eNFA89_9_44243194 -.->|"ε"|eNFA89_11_62644428
eNFA89_11_62644428 -.->|"ε"|eNFA89_12_26928941
eNFA89_12_26928941 -.->|"ε"|eNFA89_13_41033878
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
eNFA89_10_33760584[["εNFA89-10 regex start"]]
eNFA89_0_35409804[["εNFA89-0 char{1, 1}"]]
eNFA89_1_50252788[["εNFA89-1 char[1]"]]
eNFA89_2_49621912[["εNFA89-2 char{1, 1}"]]
eNFA89_3_43944024[["εNFA89-3 char[1]"]]
eNFA89_4_59951903[["εNFA89-4 char{1, 1}"]]
eNFA89_5_2696221[["εNFA89-5 char[1]"]]
eNFA89_6_24265995[["εNFA89-6 char{1, 1}"]]
eNFA89_7_17067371[["εNFA89-7 char[1]"]]
eNFA89_8_19388612[["εNFA89-8 char{1, 1}"]]
eNFA89_9_40279785[\"εNFA89-9 char[1]"/]
eNFA89_11_26973745[\"εNFA89-11 regex end"/]
eNFA89_12_41437119[\"εNFA89-12 post-regex start"/]
eNFA89_13_37389755[\"εNFA89-13 post-regex end"/]
eNFA89_10_33760584 -.->|"ε"|eNFA89_0_35409804
eNFA89_10_33760584 -->|"i"|eNFA89_1_50252788
eNFA89_0_35409804 -->|"i"|eNFA89_1_50252788
eNFA89_1_50252788 -.->|"ε"|eNFA89_2_49621912
eNFA89_1_50252788 -->|"v"|eNFA89_3_43944024
eNFA89_2_49621912 -->|"v"|eNFA89_3_43944024
eNFA89_3_43944024 -.->|"ε"|eNFA89_4_59951903
eNFA89_3_43944024 -->|"e"|eNFA89_5_2696221
eNFA89_4_59951903 -->|"e"|eNFA89_5_2696221
eNFA89_5_2696221 -.->|"ε"|eNFA89_6_24265995
eNFA89_5_2696221 -->|"c"|eNFA89_7_17067371
eNFA89_6_24265995 -->|"c"|eNFA89_7_17067371
eNFA89_7_17067371 -.->|"ε"|eNFA89_8_19388612
eNFA89_7_17067371 -->|"2"|eNFA89_9_40279785
eNFA89_8_19388612 -->|"2"|eNFA89_9_40279785
eNFA89_9_40279785 -.->|"ε"|eNFA89_11_26973745
eNFA89_9_40279785 -.->|"ε"|eNFA89_12_41437119
eNFA89_9_40279785 -.->|"ε"|eNFA89_13_37389755
eNFA89_11_26973745 -.->|"ε"|eNFA89_12_41437119
eNFA89_11_26973745 -.->|"ε"|eNFA89_13_37389755
eNFA89_12_41437119 -.->|"ε"|eNFA89_13_37389755
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
NFA89_10_963478("NFA89-10 regex start")
NFA89_1_8671305("NFA89-1 char[1]")
NFA89_3_10932885("NFA89-3 char[1]")
NFA89_5_31287108("NFA89-5 char[1]")
NFA89_7_13148517("NFA89-7 char[1]")
NFA89_9_51227795[\"NFA89-9 char[1]"/]
NFA89_10_963478 -->|"i"|NFA89_1_8671305
NFA89_1_8671305 -->|"v"|NFA89_3_10932885
NFA89_3_10932885 -->|"e"|NFA89_5_31287108
NFA89_5_31287108 -->|"c"|NFA89_7_13148517
NFA89_7_13148517 -->|"2"|NFA89_9_51227795
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
subgraph DFA0_1537522118["DFA0 regex start"]
NFA89_10_963478_0("NFA89-10 regex start")
end
subgraph DFA1_1949685236["DFA1 {1}"]
NFA89_1_8671305_1("NFA89-1 char[1]")
end
subgraph DFA2_-1366120529["DFA2 {1}"]
NFA89_3_10932885_2("NFA89-3 char[1]")
end
subgraph DFA3_-320503722["DFA3 {1}"]
NFA89_5_31287108_3("NFA89-5 char[1]")
end
subgraph DFA4_-525301433["DFA4 {1}"]
NFA89_7_13148517_4("NFA89-7 char[1]")
end
subgraph DFA5_646038227["DFA5 {1}"]
NFA89_9_51227795_5[\"NFA89-9 char[1]"/]
end
DFA0_1537522118 -->|"i"|DFA1_1949685236
DFA1_1949685236 -->|"v"|DFA2_-1366120529
DFA2_-1366120529 -->|"e"|DFA3_-320503722
DFA3_-320503722 -->|"c"|DFA4_-525301433
DFA4_-525301433 -->|"2"|DFA5_646038227
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
DFA0_1537522118{{"DFA0 regex start"}}
DFA1_1949685236{{"DFA1 {1}"}}
DFA2_-1366120529{{"DFA2 {1}"}}
DFA3_-320503722{{"DFA3 {1}"}}
DFA4_-525301433{{"DFA4 {1}"}}
DFA5_646038227[\"DFA5 {1}"/]
DFA0_1537522118 -->|"i"|DFA1_1949685236
DFA1_1949685236 -->|"v"|DFA2_-1366120529
DFA2_-1366120529 -->|"e"|DFA3_-320503722
DFA3_-320503722 -->|"c"|DFA4_-525301433
DFA4_-525301433 -->|"2"|DFA5_646038227
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
subgraph MiniDFA0_1652013015["MiniDFA0 {1}"]
DFA0_1537522118_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1384204805["MiniDFA1 {1}"]
DFA1_1949685236_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_4018801["MiniDFA2 {1}"]
DFA2_-1366120529_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-537601478["MiniDFA3 {1}"]
DFA3_-320503722_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1351931876["MiniDFA4 {1}"]
DFA4_-525301433_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1424889348["MiniDFA5 {1}"]
DFA5_646038227_5[\"DFA5 {1}"/]
end
MiniDFA0_1652013015 -->|"i"|MiniDFA1_-1384204805
MiniDFA1_-1384204805 -->|"v"|MiniDFA2_4018801
MiniDFA2_4018801 -->|"e"|MiniDFA3_-537601478
MiniDFA3_-537601478 -->|"c"|MiniDFA4_-1351931876
MiniDFA4_-1351931876 -->|"2"|MiniDFA5_-1424889348
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
MiniDFA0_1652013015(["MiniDFA0 {1}"])
MiniDFA1_-1384204805(["MiniDFA1 {1}"])
MiniDFA2_4018801(["MiniDFA2 {1}"])
MiniDFA3_-537601478(["MiniDFA3 {1}"])
MiniDFA4_-1351931876(["MiniDFA4 {1}"])
MiniDFA5_-1424889348[\"MiniDFA5 {1}"/]
MiniDFA0_1652013015 -->|"i"|MiniDFA1_-1384204805
MiniDFA1_-1384204805 -->|"v"|MiniDFA2_4018801
MiniDFA2_4018801 -->|"e"|MiniDFA3_-537601478
MiniDFA3_-537601478 -->|"c"|MiniDFA4_-1351931876
MiniDFA4_-1351931876 -->|"2"|MiniDFA5_-1424889348
```
-------------------------------
