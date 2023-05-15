# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA3_16_52618256[["εNFA3-16 regex start"]]
eNFA3_0_3802258[["εNFA3-0 char{1, 1}"]]
eNFA3_1_34220326[["εNFA3-1 char[1]"]]
eNFA3_2_39547486[["εNFA3-2 char{1, 1}"]]
eNFA3_3_32749101[["εNFA3-3 char[1]"]]
eNFA3_6_32071293[["εNFA3-6 regex start"]]
eNFA3_4_47637903[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_20206181[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_26087949[["εNFA3-7 regex end"]]
eNFA3_5_35431534[["εNFA3-5 scope[1]"]]
eNFA3_9_52387077[["εNFA3-9 scope[1]"]]
eNFA3_12_26306458[["εNFA3-12 char{1, 1}"]]
eNFA3_10_47125611[["εNFA3-10 scope{1, 1}"]]
eNFA3_13_21477321[["εNFA3-13 char[1]"]]
eNFA3_11_1193073[["εNFA3-11 scope[1]"]]
eNFA3_14_59078165[["εNFA3-14 char{1, 1}"]]
eNFA3_15_20602051[["εNFA3-15 char[1]"]]
eNFA3_17_51200735[["εNFA3-17 regex end"]]
eNFA3_18_58153438[["εNFA3-18 post-regex start"]]
eNFA3_19_53618895[\"εNFA3-19 post-regex end"/]
eNFA3_16_52618256 -.->|"ε"|eNFA3_0_3802258
eNFA3_0_3802258 -->|"/"|eNFA3_1_34220326
eNFA3_1_34220326 -.->|"ε"|eNFA3_2_39547486
eNFA3_2_39547486 -->|"*"|eNFA3_3_32749101
eNFA3_3_32749101 -.->|"ε"|eNFA3_6_32071293
eNFA3_6_32071293 -.->|"ε"|eNFA3_4_47637903
eNFA3_6_32071293 -.->|"ε"|eNFA3_8_20206181
eNFA3_6_32071293 -.->|"ε"|eNFA3_7_26087949
eNFA3_4_47637903 -->|"[^*]"|eNFA3_5_35431534
eNFA3_8_20206181 -->|"[*]"|eNFA3_9_52387077
eNFA3_7_26087949 -.->|"ε"|eNFA3_6_32071293
eNFA3_7_26087949 -.->|"ε"|eNFA3_12_26306458
eNFA3_5_35431534 -.->|"ε"|eNFA3_7_26087949
eNFA3_9_52387077 -.->|"ε"|eNFA3_10_47125611
eNFA3_12_26306458 -->|"*"|eNFA3_13_21477321
eNFA3_10_47125611 -->|"[^/]"|eNFA3_11_1193073
eNFA3_13_21477321 -.->|"ε"|eNFA3_14_59078165
eNFA3_11_1193073 -.->|"ε"|eNFA3_7_26087949
eNFA3_14_59078165 -->|"/"|eNFA3_15_20602051
eNFA3_15_20602051 -.->|"ε"|eNFA3_17_51200735
eNFA3_17_51200735 -.->|"ε"|eNFA3_18_58153438
eNFA3_18_58153438 -.->|"ε"|eNFA3_19_53618895
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
eNFA3_16_12808013[["εNFA3-16 regex start"]]
eNFA3_0_48163256[["εNFA3-0 char{1, 1}"]]
eNFA3_1_30816121[["εNFA3-1 char[1]"]]
eNFA3_2_8909633[["εNFA3-2 char{1, 1}"]]
eNFA3_3_1721653[["εNFA3-3 char[1]"]]
eNFA3_6_20383058[["εNFA3-6 regex start"]]
eNFA3_4_40414969[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_49229794[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_28190407[["εNFA3-7 regex end"]]
eNFA3_5_5236179[["εNFA3-5 scope[1]"]]
eNFA3_9_13077833[["εNFA3-9 scope[1]"]]
eNFA3_12_15494878[["εNFA3-12 char{1, 1}"]]
eNFA3_13_52671525[["εNFA3-13 char[1]"]]
eNFA3_10_50591634[["εNFA3-10 scope{1, 1}"]]
eNFA3_11_61941440[["εNFA3-11 scope[1]"]]
eNFA3_14_4281684[["εNFA3-14 char{1, 1}"]]
eNFA3_15_38535158[\"εNFA3-15 char[1]"/]
eNFA3_17_11272110[\"εNFA3-17 regex end"/]
eNFA3_18_34340132[\"εNFA3-18 post-regex start"/]
eNFA3_19_40625737[\"εNFA3-19 post-regex end"/]
eNFA3_16_12808013 -.->|"ε"|eNFA3_0_48163256
eNFA3_16_12808013 -->|"/"|eNFA3_1_30816121
eNFA3_0_48163256 -->|"/"|eNFA3_1_30816121
eNFA3_1_30816121 -.->|"ε"|eNFA3_2_8909633
eNFA3_1_30816121 -->|"*"|eNFA3_3_1721653
eNFA3_2_8909633 -->|"*"|eNFA3_3_1721653
eNFA3_3_1721653 -.->|"ε"|eNFA3_6_20383058
eNFA3_3_1721653 -.->|"ε"|eNFA3_4_40414969
eNFA3_3_1721653 -.->|"ε"|eNFA3_8_49229794
eNFA3_3_1721653 -.->|"ε"|eNFA3_7_28190407
eNFA3_3_1721653 -->|"[^*]"|eNFA3_5_5236179
eNFA3_3_1721653 -->|"[*]"|eNFA3_9_13077833
eNFA3_3_1721653 -.->|"ε"|eNFA3_12_15494878
eNFA3_3_1721653 -->|"*"|eNFA3_13_52671525
eNFA3_6_20383058 -.->|"ε"|eNFA3_4_40414969
eNFA3_6_20383058 -.->|"ε"|eNFA3_8_49229794
eNFA3_6_20383058 -.->|"ε"|eNFA3_7_28190407
eNFA3_6_20383058 -->|"[^*]"|eNFA3_5_5236179
eNFA3_6_20383058 -->|"[*]"|eNFA3_9_13077833
eNFA3_6_20383058 -.->|"ε"|eNFA3_6_20383058
eNFA3_6_20383058 -.->|"ε"|eNFA3_12_15494878
eNFA3_6_20383058 -->|"*"|eNFA3_13_52671525
eNFA3_4_40414969 -->|"[^*]"|eNFA3_5_5236179
eNFA3_8_49229794 -->|"[*]"|eNFA3_9_13077833
eNFA3_7_28190407 -.->|"ε"|eNFA3_6_20383058
eNFA3_7_28190407 -.->|"ε"|eNFA3_12_15494878
eNFA3_7_28190407 -.->|"ε"|eNFA3_4_40414969
eNFA3_7_28190407 -.->|"ε"|eNFA3_8_49229794
eNFA3_7_28190407 -.->|"ε"|eNFA3_7_28190407
eNFA3_7_28190407 -->|"[^*]"|eNFA3_5_5236179
eNFA3_7_28190407 -->|"[*]"|eNFA3_9_13077833
eNFA3_7_28190407 -->|"*"|eNFA3_13_52671525
eNFA3_5_5236179 -.->|"ε"|eNFA3_7_28190407
eNFA3_5_5236179 -.->|"ε"|eNFA3_6_20383058
eNFA3_5_5236179 -.->|"ε"|eNFA3_12_15494878
eNFA3_5_5236179 -.->|"ε"|eNFA3_4_40414969
eNFA3_5_5236179 -.->|"ε"|eNFA3_8_49229794
eNFA3_5_5236179 -->|"[^*]"|eNFA3_5_5236179
eNFA3_5_5236179 -->|"[*]"|eNFA3_9_13077833
eNFA3_5_5236179 -->|"*"|eNFA3_13_52671525
eNFA3_9_13077833 -.->|"ε"|eNFA3_10_50591634
eNFA3_9_13077833 -->|"[^/]"|eNFA3_11_61941440
eNFA3_12_15494878 -->|"*"|eNFA3_13_52671525
eNFA3_13_52671525 -.->|"ε"|eNFA3_14_4281684
eNFA3_13_52671525 -->|"/"|eNFA3_15_38535158
eNFA3_10_50591634 -->|"[^/]"|eNFA3_11_61941440
eNFA3_11_61941440 -.->|"ε"|eNFA3_7_28190407
eNFA3_11_61941440 -.->|"ε"|eNFA3_6_20383058
eNFA3_11_61941440 -.->|"ε"|eNFA3_12_15494878
eNFA3_11_61941440 -.->|"ε"|eNFA3_4_40414969
eNFA3_11_61941440 -.->|"ε"|eNFA3_8_49229794
eNFA3_11_61941440 -->|"[^*]"|eNFA3_5_5236179
eNFA3_11_61941440 -->|"[*]"|eNFA3_9_13077833
eNFA3_11_61941440 -->|"*"|eNFA3_13_52671525
eNFA3_14_4281684 -->|"/"|eNFA3_15_38535158
eNFA3_15_38535158 -.->|"ε"|eNFA3_17_11272110
eNFA3_15_38535158 -.->|"ε"|eNFA3_18_34340132
eNFA3_15_38535158 -.->|"ε"|eNFA3_19_40625737
eNFA3_17_11272110 -.->|"ε"|eNFA3_18_34340132
eNFA3_17_11272110 -.->|"ε"|eNFA3_19_40625737
eNFA3_18_34340132 -.->|"ε"|eNFA3_19_40625737
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
NFA3_16_53130157("NFA3-16 regex start")
NFA3_1_8409368("NFA3-1 char[1]")
NFA3_3_30087318("NFA3-3 char[1]")
NFA3_5_21153717("NFA3-5 scope[1]")
NFA3_9_2350413("NFA3-9 scope[1]")
NFA3_13_56165728("NFA3-13 char[1]")
NFA3_11_35729512("NFA3-11 scope[1]")
NFA3_15_8575450[\"NFA3-15 char[1]"/]
NFA3_16_53130157 -->|"/"|NFA3_1_8409368
NFA3_1_8409368 -->|"*"|NFA3_3_30087318
NFA3_3_30087318 -->|"[^*]"|NFA3_5_21153717
NFA3_3_30087318 -->|"[*]"|NFA3_9_2350413
NFA3_3_30087318 -->|"*"|NFA3_13_56165728
NFA3_5_21153717 -->|"[^*]"|NFA3_5_21153717
NFA3_5_21153717 -->|"[*]"|NFA3_9_2350413
NFA3_5_21153717 -->|"*"|NFA3_13_56165728
NFA3_9_2350413 -->|"[^/]"|NFA3_11_35729512
NFA3_13_56165728 -->|"/"|NFA3_15_8575450
NFA3_11_35729512 -->|"[^*]"|NFA3_5_21153717
NFA3_11_35729512 -->|"[*]"|NFA3_9_2350413
NFA3_11_35729512 -->|"*"|NFA3_13_56165728
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
subgraph DFA0_-1995853062["DFA0 regex start"]
NFA3_16_53130157_0("NFA3-16 regex start")
end
subgraph DFA1_-1029170523["DFA1 {1}"]
NFA3_1_8409368_1("NFA3-1 char[1]")
end
subgraph DFA2_2083740925["DFA2 {1}"]
NFA3_3_30087318_2("NFA3-3 char[1]")
end
subgraph DFA3_2121742708["DFA3 {1}"]
NFA3_5_21153717_3("NFA3-5 scope[1]")
end
subgraph DFA4_359616669["DFA4 {2}"]
NFA3_9_2350413_4("NFA3-9 scope[1]")
NFA3_13_56165728_5("NFA3-13 char[1]")
end
subgraph DFA5_-700493661["DFA5 {1}"]
NFA3_11_35729512_6("NFA3-11 scope[1]")
end
subgraph DFA6_698936744["DFA6 {1}"]
NFA3_15_8575450_7[\"NFA3-15 char[1]"/]
end
DFA0_-1995853062 -->|"/"|DFA1_-1029170523
DFA1_-1029170523 -->|"*"|DFA2_2083740925
DFA2_2083740925 -->|"[^*]"|DFA3_2121742708
DFA2_2083740925 -->|"*"|DFA4_359616669
DFA3_2121742708 -->|"[^*]"|DFA3_2121742708
DFA3_2121742708 -->|"*"|DFA4_359616669
DFA4_359616669 -->|"[^/]"|DFA5_-700493661
DFA4_359616669 -->|"/"|DFA6_698936744
DFA5_-700493661 -->|"[^*]"|DFA3_2121742708
DFA5_-700493661 -->|"*"|DFA4_359616669
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
DFA0_-1995853062{{"DFA0 regex start"}}
DFA1_-1029170523{{"DFA1 {1}"}}
DFA2_2083740925{{"DFA2 {1}"}}
DFA3_2121742708{{"DFA3 {1}"}}
DFA4_359616669{{"DFA4 {2}"}}
DFA5_-700493661{{"DFA5 {1}"}}
DFA6_698936744[\"DFA6 {1}"/]
DFA0_-1995853062 -->|"/"|DFA1_-1029170523
DFA1_-1029170523 -->|"*"|DFA2_2083740925
DFA2_2083740925 -->|"[^*]"|DFA3_2121742708
DFA2_2083740925 -->|"*"|DFA4_359616669
DFA3_2121742708 -->|"[^*]"|DFA3_2121742708
DFA3_2121742708 -->|"*"|DFA4_359616669
DFA4_359616669 -->|"[^/]"|DFA5_-700493661
DFA4_359616669 -->|"/"|DFA6_698936744
DFA5_-700493661 -->|"[^*]"|DFA3_2121742708
DFA5_-700493661 -->|"*"|DFA4_359616669
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
subgraph MiniDFA0_1483923769["MiniDFA0 {1}"]
DFA0_-1995853062_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1884260212["MiniDFA1 {1}"]
DFA1_-1029170523_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_2053371024["MiniDFA2 {3}"]
DFA2_2083740925_2{{"DFA2 {1}"}}
DFA3_2121742708_3{{"DFA3 {1}"}}
DFA5_-700493661_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_660020242["MiniDFA3 {1}"]
DFA4_359616669_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_235540433["MiniDFA4 {1}"]
DFA6_698936744_6[\"DFA6 {1}"/]
end
MiniDFA0_1483923769 -->|"/"|MiniDFA1_1884260212
MiniDFA1_1884260212 -->|"*"|MiniDFA2_2053371024
MiniDFA2_2053371024 -->|"[^*]"|MiniDFA2_2053371024
MiniDFA2_2053371024 -->|"*"|MiniDFA3_660020242
MiniDFA3_660020242 -->|"[^/]"|MiniDFA2_2053371024
MiniDFA3_660020242 -->|"/"|MiniDFA4_235540433
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
MiniDFA0_1483923769(["MiniDFA0 {1}"])
MiniDFA1_1884260212(["MiniDFA1 {1}"])
MiniDFA2_2053371024(["MiniDFA2 {3}"])
MiniDFA3_660020242(["MiniDFA3 {1}"])
MiniDFA4_235540433[\"MiniDFA4 {1}"/]
MiniDFA0_1483923769 -->|"/"|MiniDFA1_1884260212
MiniDFA1_1884260212 -->|"*"|MiniDFA2_2053371024
MiniDFA2_2053371024 -->|"[^*]"|MiniDFA2_2053371024
MiniDFA2_2053371024 -->|"*"|MiniDFA3_660020242
MiniDFA3_660020242 -->|"[^/]"|MiniDFA2_2053371024
MiniDFA3_660020242 -->|"/"|MiniDFA4_235540433
```
-------------------------------
