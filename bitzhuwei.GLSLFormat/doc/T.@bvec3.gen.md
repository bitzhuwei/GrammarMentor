# 'bvec3'

pattern: `bvec3`

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
eNFA87_10_56353115[["εNFA87-10 regex start"]]
eNFA87_0_37415993[["εNFA87-0 char{1, 1}"]]
eNFA87_1_1199620[["εNFA87-1 char[1]"]]
eNFA87_2_10796581[["εNFA87-2 char{1, 1}"]]
eNFA87_3_30060365[["εNFA87-3 char[1]"]]
eNFA87_4_2107829[["εNFA87-4 char{1, 1}"]]
eNFA87_5_18970462[["εNFA87-5 char[1]"]]
eNFA87_6_36516433[["εNFA87-6 char{1, 1}"]]
eNFA87_7_60212448[["εNFA87-7 char[1]"]]
eNFA87_8_5041122[["εNFA87-8 char{1, 1}"]]
eNFA87_9_45370106[["εNFA87-9 char[1]"]]
eNFA87_11_5677776[["εNFA87-11 regex end"]]
eNFA87_12_51099989[["εNFA87-12 post-regex start"]]
eNFA87_13_57246722[\"εNFA87-13 post-regex end"/]
eNFA87_10_56353115 -.->|"ε"|eNFA87_0_37415993
eNFA87_0_37415993 -->|"b"|eNFA87_1_1199620
eNFA87_1_1199620 -.->|"ε"|eNFA87_2_10796581
eNFA87_2_10796581 -->|"v"|eNFA87_3_30060365
eNFA87_3_30060365 -.->|"ε"|eNFA87_4_2107829
eNFA87_4_2107829 -->|"e"|eNFA87_5_18970462
eNFA87_5_18970462 -.->|"ε"|eNFA87_6_36516433
eNFA87_6_36516433 -->|"c"|eNFA87_7_60212448
eNFA87_7_60212448 -.->|"ε"|eNFA87_8_5041122
eNFA87_8_5041122 -->|"3"|eNFA87_9_45370106
eNFA87_9_45370106 -.->|"ε"|eNFA87_11_5677776
eNFA87_11_5677776 -.->|"ε"|eNFA87_12_51099989
eNFA87_12_51099989 -.->|"ε"|eNFA87_13_57246722
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
eNFA87_10_45458457[["εNFA87-10 regex start"]]
eNFA87_0_6472929[["εNFA87-0 char{1, 1}"]]
eNFA87_1_58256364[["εNFA87-1 char[1]"]]
eNFA87_2_54545236[["εNFA87-2 char{1, 1}"]]
eNFA87_3_21145081[["εNFA87-3 char[1]"]]
eNFA87_4_56088004[["εNFA87-4 char{1, 1}"]]
eNFA87_5_35029990[["εNFA87-5 char[1]"]]
eNFA87_6_46834456[["εNFA87-6 char{1, 1}"]]
eNFA87_7_18856923[["εNFA87-7 char[1]"]]
eNFA87_8_35494585[["εNFA87-8 char{1, 1}"]]
eNFA87_9_51015809[\"εNFA87-9 char[1]"/]
eNFA87_11_56489102[\"εNFA87-11 regex end"/]
eNFA87_12_38639871[\"εNFA87-12 post-regex start"/]
eNFA87_13_12214527[\"εNFA87-13 post-regex end"/]
eNFA87_10_45458457 -.->|"ε"|eNFA87_0_6472929
eNFA87_10_45458457 -->|"b"|eNFA87_1_58256364
eNFA87_0_6472929 -->|"b"|eNFA87_1_58256364
eNFA87_1_58256364 -.->|"ε"|eNFA87_2_54545236
eNFA87_1_58256364 -->|"v"|eNFA87_3_21145081
eNFA87_2_54545236 -->|"v"|eNFA87_3_21145081
eNFA87_3_21145081 -.->|"ε"|eNFA87_4_56088004
eNFA87_3_21145081 -->|"e"|eNFA87_5_35029990
eNFA87_4_56088004 -->|"e"|eNFA87_5_35029990
eNFA87_5_35029990 -.->|"ε"|eNFA87_6_46834456
eNFA87_5_35029990 -->|"c"|eNFA87_7_18856923
eNFA87_6_46834456 -->|"c"|eNFA87_7_18856923
eNFA87_7_18856923 -.->|"ε"|eNFA87_8_35494585
eNFA87_7_18856923 -->|"3"|eNFA87_9_51015809
eNFA87_8_35494585 -->|"3"|eNFA87_9_51015809
eNFA87_9_51015809 -.->|"ε"|eNFA87_11_56489102
eNFA87_9_51015809 -.->|"ε"|eNFA87_12_38639871
eNFA87_9_51015809 -.->|"ε"|eNFA87_13_12214527
eNFA87_11_56489102 -.->|"ε"|eNFA87_12_38639871
eNFA87_11_56489102 -.->|"ε"|eNFA87_13_12214527
eNFA87_12_38639871 -.->|"ε"|eNFA87_13_12214527
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
NFA87_10_42821886("NFA87-10 regex start")
NFA87_1_49852662("NFA87-1 char[1]")
NFA87_3_46020774("NFA87-3 char[1]")
NFA87_5_11533784("NFA87-5 char[1]")
NFA87_7_36695198("NFA87-7 char[1]")
NFA87_9_61821327[\"NFA87-9 char[1]"/]
NFA87_10_42821886 -->|"b"|NFA87_1_49852662
NFA87_1_49852662 -->|"v"|NFA87_3_46020774
NFA87_3_46020774 -->|"e"|NFA87_5_11533784
NFA87_5_11533784 -->|"c"|NFA87_7_36695198
NFA87_7_36695198 -->|"3"|NFA87_9_61821327
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
subgraph DFA0_1469456904["DFA0 regex start"]
NFA87_10_42821886_0("NFA87-10 regex start")
end
subgraph DFA1_-1055243798["DFA1 {1}"]
NFA87_1_49852662_1("NFA87-1 char[1]")
end
subgraph DFA2_239731683["DFA2 {1}"]
NFA87_3_46020774_2("NFA87-3 char[1]")
end
subgraph DFA3_517345406["DFA3 {1}"]
NFA87_5_11533784_3("NFA87-5 char[1]")
end
subgraph DFA4_1639976702["DFA4 {1}"]
NFA87_7_36695198_4("NFA87-7 char[1]")
end
subgraph DFA5_-2134583778["DFA5 {1}"]
NFA87_9_61821327_5[\"NFA87-9 char[1]"/]
end
DFA0_1469456904 -->|"b"|DFA1_-1055243798
DFA1_-1055243798 -->|"v"|DFA2_239731683
DFA2_239731683 -->|"e"|DFA3_517345406
DFA3_517345406 -->|"c"|DFA4_1639976702
DFA4_1639976702 -->|"3"|DFA5_-2134583778
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
DFA0_1469456904{{"DFA0 regex start"}}
DFA1_-1055243798{{"DFA1 {1}"}}
DFA2_239731683{{"DFA2 {1}"}}
DFA3_517345406{{"DFA3 {1}"}}
DFA4_1639976702{{"DFA4 {1}"}}
DFA5_-2134583778[\"DFA5 {1}"/]
DFA0_1469456904 -->|"b"|DFA1_-1055243798
DFA1_-1055243798 -->|"v"|DFA2_239731683
DFA2_239731683 -->|"e"|DFA3_517345406
DFA3_517345406 -->|"c"|DFA4_1639976702
DFA4_1639976702 -->|"3"|DFA5_-2134583778
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
subgraph MiniDFA0_563695898["MiniDFA0 {1}"]
DFA0_1469456904_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1403276906["MiniDFA1 {1}"]
DFA1_-1055243798_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1729883169["MiniDFA2 {1}"]
DFA2_239731683_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_2143440828["MiniDFA3 {1}"]
DFA3_517345406_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1514624342["MiniDFA4 {1}"]
DFA4_1639976702_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1709786726["MiniDFA5 {1}"]
DFA5_-2134583778_5[\"DFA5 {1}"/]
end
MiniDFA0_563695898 -->|"b"|MiniDFA1_1403276906
MiniDFA1_1403276906 -->|"v"|MiniDFA2_1729883169
MiniDFA2_1729883169 -->|"e"|MiniDFA3_2143440828
MiniDFA3_2143440828 -->|"c"|MiniDFA4_-1514624342
MiniDFA4_-1514624342 -->|"3"|MiniDFA5_1709786726
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
MiniDFA0_563695898(["MiniDFA0 {1}"])
MiniDFA1_1403276906(["MiniDFA1 {1}"])
MiniDFA2_1729883169(["MiniDFA2 {1}"])
MiniDFA3_2143440828(["MiniDFA3 {1}"])
MiniDFA4_-1514624342(["MiniDFA4 {1}"])
MiniDFA5_1709786726[\"MiniDFA5 {1}"/]
MiniDFA0_563695898 -->|"b"|MiniDFA1_1403276906
MiniDFA1_1403276906 -->|"v"|MiniDFA2_1729883169
MiniDFA2_1729883169 -->|"e"|MiniDFA3_2143440828
MiniDFA3_2143440828 -->|"c"|MiniDFA4_-1514624342
MiniDFA4_-1514624342 -->|"3"|MiniDFA5_1709786726
```
-------------------------------
