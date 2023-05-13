# 'switch'

pattern: `switch`

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
eNFA199_12_7146644[["εNFA199-12 regex start"]]
eNFA199_0_64319798[["εNFA199-0 char{1, 1}"]]
eNFA199_1_42007273[["εNFA199-1 char[1]"]]
eNFA199_2_42521143[["εNFA199-2 char{1, 1}"]]
eNFA199_3_47145967[["εNFA199-3 char[1]"]]
eNFA199_4_21660524[["εNFA199-4 char{1, 1}"]]
eNFA199_5_60726989[["εNFA199-5 char[1]"]]
eNFA199_6_9671997[["εNFA199-6 char{1, 1}"]]
eNFA199_7_19939116[["εNFA199-7 char[1]"]]
eNFA199_8_45234324[["εNFA199-8 char{1, 1}"]]
eNFA199_9_4455732[["εNFA199-9 char[1]"]]
eNFA199_10_40101590[["εNFA199-10 char{1, 1}"]]
eNFA199_11_25369996[["εNFA199-11 char[1]"]]
eNFA199_13_27003373[["εNFA199-13 regex end"]]
eNFA199_14_41703772[["εNFA199-14 post-regex start"]]
eNFA199_15_39789633[\"εNFA199-15 post-regex end"/]
eNFA199_12_7146644 -.->|"ε"|eNFA199_0_64319798
eNFA199_0_64319798 -->|"s"|eNFA199_1_42007273
eNFA199_1_42007273 -.->|"ε"|eNFA199_2_42521143
eNFA199_2_42521143 -->|"w"|eNFA199_3_47145967
eNFA199_3_47145967 -.->|"ε"|eNFA199_4_21660524
eNFA199_4_21660524 -->|"i"|eNFA199_5_60726989
eNFA199_5_60726989 -.->|"ε"|eNFA199_6_9671997
eNFA199_6_9671997 -->|"t"|eNFA199_7_19939116
eNFA199_7_19939116 -.->|"ε"|eNFA199_8_45234324
eNFA199_8_45234324 -->|"c"|eNFA199_9_4455732
eNFA199_9_4455732 -.->|"ε"|eNFA199_10_40101590
eNFA199_10_40101590 -->|"h"|eNFA199_11_25369996
eNFA199_11_25369996 -.->|"ε"|eNFA199_13_27003373
eNFA199_13_27003373 -.->|"ε"|eNFA199_14_41703772
eNFA199_14_41703772 -.->|"ε"|eNFA199_15_39789633
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
eNFA199_12_22562381[["εNFA199-12 regex start"]]
eNFA199_0_1734841[["εNFA199-0 char{1, 1}"]]
eNFA199_1_15613574[["εNFA199-1 char[1]"]]
eNFA199_2_6304446[["εNFA199-2 char{1, 1}"]]
eNFA199_3_56740016[["εNFA199-3 char[1]"]]
eNFA199_4_40898103[["εNFA199-4 char{1, 1}"]]
eNFA199_5_32538611[["εNFA199-5 char[1]"]]
eNFA199_6_24412045[["εNFA199-6 char{1, 1}"]]
eNFA199_7_18381814[["εNFA199-7 char[1]"]]
eNFA199_8_31218599[["εNFA199-8 char{1, 1}"]]
eNFA199_9_12531937[["εNFA199-9 char[1]"]]
eNFA199_10_45678573[["εNFA199-10 char{1, 1}"]]
eNFA199_11_8453981[\"εNFA199-11 char[1]"/]
eNFA199_13_8976969[\"εNFA199-13 regex end"/]
eNFA199_14_13683857[\"εNFA199-14 post-regex start"/]
eNFA199_15_56045856[\"εNFA199-15 post-regex end"/]
eNFA199_12_22562381 -.->|"ε"|eNFA199_0_1734841
eNFA199_12_22562381 -->|"s"|eNFA199_1_15613574
eNFA199_0_1734841 -->|"s"|eNFA199_1_15613574
eNFA199_1_15613574 -.->|"ε"|eNFA199_2_6304446
eNFA199_1_15613574 -->|"w"|eNFA199_3_56740016
eNFA199_2_6304446 -->|"w"|eNFA199_3_56740016
eNFA199_3_56740016 -.->|"ε"|eNFA199_4_40898103
eNFA199_3_56740016 -->|"i"|eNFA199_5_32538611
eNFA199_4_40898103 -->|"i"|eNFA199_5_32538611
eNFA199_5_32538611 -.->|"ε"|eNFA199_6_24412045
eNFA199_5_32538611 -->|"t"|eNFA199_7_18381814
eNFA199_6_24412045 -->|"t"|eNFA199_7_18381814
eNFA199_7_18381814 -.->|"ε"|eNFA199_8_31218599
eNFA199_7_18381814 -->|"c"|eNFA199_9_12531937
eNFA199_8_31218599 -->|"c"|eNFA199_9_12531937
eNFA199_9_12531937 -.->|"ε"|eNFA199_10_45678573
eNFA199_9_12531937 -->|"h"|eNFA199_11_8453981
eNFA199_10_45678573 -->|"h"|eNFA199_11_8453981
eNFA199_11_8453981 -.->|"ε"|eNFA199_13_8976969
eNFA199_11_8453981 -.->|"ε"|eNFA199_14_13683857
eNFA199_11_8453981 -.->|"ε"|eNFA199_15_56045856
eNFA199_13_8976969 -.->|"ε"|eNFA199_14_13683857
eNFA199_13_8976969 -.->|"ε"|eNFA199_15_56045856
eNFA199_14_13683857 -.->|"ε"|eNFA199_15_56045856
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
NFA199_12_34650662("NFA199-12 regex start")
NFA199_1_43420508("NFA199-1 char[1]")
NFA199_3_55240260("NFA199-3 char[1]")
NFA199_5_27400293("NFA199-5 char[1]")
NFA199_7_45276050("NFA199-7 char[1]")
NFA199_9_4831266("NFA199-9 char[1]")
NFA199_11_43481400[\"NFA199-11 char[1]"/]
NFA199_12_34650662 -->|"s"|NFA199_1_43420508
NFA199_1_43420508 -->|"w"|NFA199_3_55240260
NFA199_3_55240260 -->|"i"|NFA199_5_27400293
NFA199_5_27400293 -->|"t"|NFA199_7_45276050
NFA199_7_45276050 -->|"c"|NFA199_9_4831266
NFA199_9_4831266 -->|"h"|NFA199_11_43481400
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
subgraph DFA0_2001074177["DFA0 regex start"]
NFA199_12_34650662_0("NFA199-12 regex start")
end
subgraph DFA1_-1735343787["DFA1 {1}"]
NFA199_1_43420508_1("NFA199-1 char[1]")
end
subgraph DFA2_-96743762["DFA2 {1}"]
NFA199_3_55240260_2("NFA199-3 char[1]")
end
subgraph DFA3_1182652517["DFA3 {1}"]
NFA199_5_27400293_3("NFA199-5 char[1]")
end
subgraph DFA4_-2098329430["DFA4 {1}"]
NFA199_7_45276050_4("NFA199-7 char[1]")
end
subgraph DFA5_-1508415528["DFA5 {1}"]
NFA199_9_4831266_5("NFA199-9 char[1]")
end
subgraph DFA6_-62478441["DFA6 {1}"]
NFA199_11_43481400_6[\"NFA199-11 char[1]"/]
end
DFA0_2001074177 -->|"s"|DFA1_-1735343787
DFA1_-1735343787 -->|"w"|DFA2_-96743762
DFA2_-96743762 -->|"i"|DFA3_1182652517
DFA3_1182652517 -->|"t"|DFA4_-2098329430
DFA4_-2098329430 -->|"c"|DFA5_-1508415528
DFA5_-1508415528 -->|"h"|DFA6_-62478441
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
DFA0_2001074177{{"DFA0 regex start"}}
DFA1_-1735343787{{"DFA1 {1}"}}
DFA2_-96743762{{"DFA2 {1}"}}
DFA3_1182652517{{"DFA3 {1}"}}
DFA4_-2098329430{{"DFA4 {1}"}}
DFA5_-1508415528{{"DFA5 {1}"}}
DFA6_-62478441[\"DFA6 {1}"/]
DFA0_2001074177 -->|"s"|DFA1_-1735343787
DFA1_-1735343787 -->|"w"|DFA2_-96743762
DFA2_-96743762 -->|"i"|DFA3_1182652517
DFA3_1182652517 -->|"t"|DFA4_-2098329430
DFA4_-2098329430 -->|"c"|DFA5_-1508415528
DFA5_-1508415528 -->|"h"|DFA6_-62478441
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
subgraph MiniDFA0_-513168451["MiniDFA0 {1}"]
DFA0_2001074177_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-453448968["MiniDFA1 {1}"]
DFA1_-1735343787_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1271113327["MiniDFA2 {1}"]
DFA2_-96743762_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_546443660["MiniDFA3 {1}"]
DFA3_1182652517_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_680625377["MiniDFA4 {1}"]
DFA4_-2098329430_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-2104257727["MiniDFA5 {1}"]
DFA5_-1508415528_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-1669302342["MiniDFA6 {1}"]
DFA6_-62478441_6[\"DFA6 {1}"/]
end
MiniDFA0_-513168451 -->|"s"|MiniDFA1_-453448968
MiniDFA1_-453448968 -->|"w"|MiniDFA2_-1271113327
MiniDFA2_-1271113327 -->|"i"|MiniDFA3_546443660
MiniDFA3_546443660 -->|"t"|MiniDFA4_680625377
MiniDFA4_680625377 -->|"c"|MiniDFA5_-2104257727
MiniDFA5_-2104257727 -->|"h"|MiniDFA6_-1669302342
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
MiniDFA0_-513168451(["MiniDFA0 {1}"])
MiniDFA1_-453448968(["MiniDFA1 {1}"])
MiniDFA2_-1271113327(["MiniDFA2 {1}"])
MiniDFA3_546443660(["MiniDFA3 {1}"])
MiniDFA4_680625377(["MiniDFA4 {1}"])
MiniDFA5_-2104257727(["MiniDFA5 {1}"])
MiniDFA6_-1669302342[\"MiniDFA6 {1}"/]
MiniDFA0_-513168451 -->|"s"|MiniDFA1_-453448968
MiniDFA1_-453448968 -->|"w"|MiniDFA2_-1271113327
MiniDFA2_-1271113327 -->|"i"|MiniDFA3_546443660
MiniDFA3_546443660 -->|"t"|MiniDFA4_680625377
MiniDFA4_680625377 -->|"c"|MiniDFA5_-2104257727
MiniDFA5_-2104257727 -->|"h"|MiniDFA6_-1669302342
```
-------------------------------
