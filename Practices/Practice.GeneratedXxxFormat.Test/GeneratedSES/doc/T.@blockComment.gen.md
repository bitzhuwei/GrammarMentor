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
eNFA7_16_65178831[["εNFA7-16 regex start"]]
eNFA7_0_49738569[["εNFA7-0 char{1, 1}"]]
eNFA7_1_44993941[["εNFA7-1 char[1]"]]
eNFA7_2_2292293[["εNFA7-2 char{1, 1}"]]
eNFA7_3_49404100[["εNFA7-3 char[1]"]]
eNFA7_6_44180924[["εNFA7-6 regex start"]]
eNFA7_4_21885054[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_62083996[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_62747764[["εNFA7-7 regex end"]]
eNFA7_5_42309173[["εNFA7-5 scope[1]"]]
eNFA7_9_66166404[["εNFA7-9 scope[1]"]]
eNFA7_12_41983721[["εNFA7-12 char{1, 1}"]]
eNFA7_10_57650250[["εNFA7-10 scope{1, 1}"]]
eNFA7_13_49090208[["εNFA7-13 char[1]"]]
eNFA7_11_28225944[["εNFA7-11 scope[1]"]]
eNFA7_14_39158692[["εNFA7-14 char{1, 1}"]]
eNFA7_15_17737474[["εNFA7-15 char[1]"]]
eNFA7_17_25419542[["εNFA7-17 regex end"]]
eNFA7_18_27449293[["εNFA7-18 post-regex start"]]
eNFA7_19_45717046[\"εNFA7-19 post-regex end"/]
eNFA7_16_65178831 -.->|"ε"|eNFA7_0_49738569
eNFA7_0_49738569 -->|"/"|eNFA7_1_44993941
eNFA7_1_44993941 -.->|"ε"|eNFA7_2_2292293
eNFA7_2_2292293 -->|"*"|eNFA7_3_49404100
eNFA7_3_49404100 -.->|"ε"|eNFA7_6_44180924
eNFA7_6_44180924 -.->|"ε"|eNFA7_4_21885054
eNFA7_6_44180924 -.->|"ε"|eNFA7_8_62083996
eNFA7_6_44180924 -.->|"ε"|eNFA7_7_62747764
eNFA7_4_21885054 -->|"[^*]"|eNFA7_5_42309173
eNFA7_8_62083996 -->|"[*]"|eNFA7_9_66166404
eNFA7_7_62747764 -.->|"ε"|eNFA7_6_44180924
eNFA7_7_62747764 -.->|"ε"|eNFA7_12_41983721
eNFA7_5_42309173 -.->|"ε"|eNFA7_7_62747764
eNFA7_9_66166404 -.->|"ε"|eNFA7_10_57650250
eNFA7_12_41983721 -->|"*"|eNFA7_13_49090208
eNFA7_10_57650250 -->|"[^/]"|eNFA7_11_28225944
eNFA7_13_49090208 -.->|"ε"|eNFA7_14_39158692
eNFA7_11_28225944 -.->|"ε"|eNFA7_7_62747764
eNFA7_14_39158692 -->|"/"|eNFA7_15_17737474
eNFA7_15_17737474 -.->|"ε"|eNFA7_17_25419542
eNFA7_17_25419542 -.->|"ε"|eNFA7_18_27449293
eNFA7_18_27449293 -.->|"ε"|eNFA7_19_45717046
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
eNFA7_16_8800236[["εNFA7-16 regex start"]]
eNFA7_0_12093263[["εNFA7-0 char{1, 1}"]]
eNFA7_1_41730504[["εNFA7-1 char[1]"]]
eNFA7_2_40030216[["εNFA7-2 char{1, 1}"]]
eNFA7_3_58626732[["εNFA7-3 char[1]"]]
eNFA7_6_20630641[["εNFA7-6 regex start"]]
eNFA7_4_60469192[["εNFA7-4 scope{1, 1}"]]
eNFA7_8_51458041[["εNFA7-8 scope{1, 1}"]]
eNFA7_7_7351822[["εNFA7-7 regex end"]]
eNFA7_5_51144826[["εNFA7-5 scope[1]"]]
eNFA7_9_24727624[["εNFA7-9 scope[1]"]]
eNFA7_12_57878541[["εNFA7-12 char{1, 1}"]]
eNFA7_13_56780500[["εNFA7-13 char[1]"]]
eNFA7_10_21222025[["εNFA7-10 scope{1, 1}"]]
eNFA7_11_16883911[["εNFA7-11 scope[1]"]]
eNFA7_14_41262459[["εNFA7-14 char{1, 1}"]]
eNFA7_15_35817813[\"εNFA7-15 char[1]"/]
eNFA7_17_53924869[\"εNFA7-17 regex end"/]
eNFA7_18_15561779[\"εNFA7-18 post-regex start"/]
eNFA7_19_5838288[\"εNFA7-19 post-regex end"/]
eNFA7_16_8800236 -.->|"ε"|eNFA7_0_12093263
eNFA7_16_8800236 -->|"/"|eNFA7_1_41730504
eNFA7_0_12093263 -->|"/"|eNFA7_1_41730504
eNFA7_1_41730504 -.->|"ε"|eNFA7_2_40030216
eNFA7_1_41730504 -->|"*"|eNFA7_3_58626732
eNFA7_2_40030216 -->|"*"|eNFA7_3_58626732
eNFA7_3_58626732 -.->|"ε"|eNFA7_6_20630641
eNFA7_3_58626732 -.->|"ε"|eNFA7_4_60469192
eNFA7_3_58626732 -.->|"ε"|eNFA7_8_51458041
eNFA7_3_58626732 -.->|"ε"|eNFA7_7_7351822
eNFA7_3_58626732 -->|"[^*]"|eNFA7_5_51144826
eNFA7_3_58626732 -->|"[*]"|eNFA7_9_24727624
eNFA7_3_58626732 -.->|"ε"|eNFA7_12_57878541
eNFA7_3_58626732 -->|"*"|eNFA7_13_56780500
eNFA7_6_20630641 -.->|"ε"|eNFA7_4_60469192
eNFA7_6_20630641 -.->|"ε"|eNFA7_8_51458041
eNFA7_6_20630641 -.->|"ε"|eNFA7_7_7351822
eNFA7_6_20630641 -->|"[^*]"|eNFA7_5_51144826
eNFA7_6_20630641 -->|"[*]"|eNFA7_9_24727624
eNFA7_6_20630641 -.->|"ε"|eNFA7_6_20630641
eNFA7_6_20630641 -.->|"ε"|eNFA7_12_57878541
eNFA7_6_20630641 -->|"*"|eNFA7_13_56780500
eNFA7_4_60469192 -->|"[^*]"|eNFA7_5_51144826
eNFA7_8_51458041 -->|"[*]"|eNFA7_9_24727624
eNFA7_7_7351822 -.->|"ε"|eNFA7_6_20630641
eNFA7_7_7351822 -.->|"ε"|eNFA7_12_57878541
eNFA7_7_7351822 -.->|"ε"|eNFA7_4_60469192
eNFA7_7_7351822 -.->|"ε"|eNFA7_8_51458041
eNFA7_7_7351822 -.->|"ε"|eNFA7_7_7351822
eNFA7_7_7351822 -->|"[^*]"|eNFA7_5_51144826
eNFA7_7_7351822 -->|"[*]"|eNFA7_9_24727624
eNFA7_7_7351822 -->|"*"|eNFA7_13_56780500
eNFA7_5_51144826 -.->|"ε"|eNFA7_7_7351822
eNFA7_5_51144826 -.->|"ε"|eNFA7_6_20630641
eNFA7_5_51144826 -.->|"ε"|eNFA7_12_57878541
eNFA7_5_51144826 -.->|"ε"|eNFA7_4_60469192
eNFA7_5_51144826 -.->|"ε"|eNFA7_8_51458041
eNFA7_5_51144826 -->|"[^*]"|eNFA7_5_51144826
eNFA7_5_51144826 -->|"[*]"|eNFA7_9_24727624
eNFA7_5_51144826 -->|"*"|eNFA7_13_56780500
eNFA7_9_24727624 -.->|"ε"|eNFA7_10_21222025
eNFA7_9_24727624 -->|"[^/]"|eNFA7_11_16883911
eNFA7_12_57878541 -->|"*"|eNFA7_13_56780500
eNFA7_13_56780500 -.->|"ε"|eNFA7_14_41262459
eNFA7_13_56780500 -->|"/"|eNFA7_15_35817813
eNFA7_10_21222025 -->|"[^/]"|eNFA7_11_16883911
eNFA7_11_16883911 -.->|"ε"|eNFA7_7_7351822
eNFA7_11_16883911 -.->|"ε"|eNFA7_6_20630641
eNFA7_11_16883911 -.->|"ε"|eNFA7_12_57878541
eNFA7_11_16883911 -.->|"ε"|eNFA7_4_60469192
eNFA7_11_16883911 -.->|"ε"|eNFA7_8_51458041
eNFA7_11_16883911 -->|"[^*]"|eNFA7_5_51144826
eNFA7_11_16883911 -->|"[*]"|eNFA7_9_24727624
eNFA7_11_16883911 -->|"*"|eNFA7_13_56780500
eNFA7_14_41262459 -->|"/"|eNFA7_15_35817813
eNFA7_15_35817813 -.->|"ε"|eNFA7_17_53924869
eNFA7_15_35817813 -.->|"ε"|eNFA7_18_15561779
eNFA7_15_35817813 -.->|"ε"|eNFA7_19_5838288
eNFA7_17_53924869 -.->|"ε"|eNFA7_18_15561779
eNFA7_17_53924869 -.->|"ε"|eNFA7_19_5838288
eNFA7_18_15561779 -.->|"ε"|eNFA7_19_5838288
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
NFA7_16_61845188("NFA7-16 regex start")
NFA7_1_19735783("NFA7-1 char[1]")
NFA7_3_52544597("NFA7-3 char[1]")
NFA7_5_28253988("NFA7-5 scope[1]")
NFA7_9_3139332("NFA7-9 scope[1]")
NFA7_13_52959303("NFA7-13 char[1]")
NFA7_11_6871687("NFA7-11 scope[1]")
NFA7_15_43404321[\"NFA7-15 char[1]"/]
NFA7_16_61845188 -->|"/"|NFA7_1_19735783
NFA7_1_19735783 -->|"*"|NFA7_3_52544597
NFA7_3_52544597 -->|"[^*]"|NFA7_5_28253988
NFA7_3_52544597 -->|"[*]"|NFA7_9_3139332
NFA7_3_52544597 -->|"*"|NFA7_13_52959303
NFA7_5_28253988 -->|"[^*]"|NFA7_5_28253988
NFA7_5_28253988 -->|"[*]"|NFA7_9_3139332
NFA7_5_28253988 -->|"*"|NFA7_13_52959303
NFA7_9_3139332 -->|"[^/]"|NFA7_11_6871687
NFA7_13_52959303 -->|"/"|NFA7_15_43404321
NFA7_11_6871687 -->|"[^*]"|NFA7_5_28253988
NFA7_11_6871687 -->|"[*]"|NFA7_9_3139332
NFA7_11_6871687 -->|"*"|NFA7_13_52959303
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
subgraph DFA0_1913500168["DFA0 regex start"]
NFA7_16_61845188_0("NFA7-16 regex start")
end
subgraph DFA1_-1956898735["DFA1 {1}"]
NFA7_1_19735783_1("NFA7-1 char[1]")
end
subgraph DFA2_800627232["DFA2 {1}"]
NFA7_3_52544597_2("NFA7-3 char[1]")
end
subgraph DFA3_1331402735["DFA3 {1}"]
NFA7_5_28253988_3("NFA7-5 scope[1]")
end
subgraph DFA4_1729851083["DFA4 {2}"]
NFA7_9_3139332_4("NFA7-9 scope[1]")
NFA7_13_52959303_5("NFA7-13 char[1]")
end
subgraph DFA5_-1586947344["DFA5 {1}"]
NFA7_11_6871687_6("NFA7-11 scope[1]")
end
subgraph DFA6_1096598491["DFA6 {1}"]
NFA7_15_43404321_7[\"NFA7-15 char[1]"/]
end
DFA0_1913500168 -->|"/"|DFA1_-1956898735
DFA1_-1956898735 -->|"*"|DFA2_800627232
DFA2_800627232 -->|"[^*]"|DFA3_1331402735
DFA2_800627232 -->|"*"|DFA4_1729851083
DFA3_1331402735 -->|"[^*]"|DFA3_1331402735
DFA3_1331402735 -->|"*"|DFA4_1729851083
DFA4_1729851083 -->|"[^/]"|DFA5_-1586947344
DFA4_1729851083 -->|"/"|DFA6_1096598491
DFA5_-1586947344 -->|"[^*]"|DFA3_1331402735
DFA5_-1586947344 -->|"*"|DFA4_1729851083
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
DFA0_1913500168{{"DFA0 regex start"}}
DFA1_-1956898735{{"DFA1 {1}"}}
DFA2_800627232{{"DFA2 {1}"}}
DFA3_1331402735{{"DFA3 {1}"}}
DFA4_1729851083{{"DFA4 {2}"}}
DFA5_-1586947344{{"DFA5 {1}"}}
DFA6_1096598491[\"DFA6 {1}"/]
DFA0_1913500168 -->|"/"|DFA1_-1956898735
DFA1_-1956898735 -->|"*"|DFA2_800627232
DFA2_800627232 -->|"[^*]"|DFA3_1331402735
DFA2_800627232 -->|"*"|DFA4_1729851083
DFA3_1331402735 -->|"[^*]"|DFA3_1331402735
DFA3_1331402735 -->|"*"|DFA4_1729851083
DFA4_1729851083 -->|"[^/]"|DFA5_-1586947344
DFA4_1729851083 -->|"/"|DFA6_1096598491
DFA5_-1586947344 -->|"[^*]"|DFA3_1331402735
DFA5_-1586947344 -->|"*"|DFA4_1729851083
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
subgraph MiniDFA0_-1185011322["MiniDFA0 {1}"]
DFA0_1913500168_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1587917933["MiniDFA1 {1}"]
DFA1_-1956898735_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-979544238["MiniDFA2 {3}"]
DFA2_800627232_2{{"DFA2 {1}"}}
DFA3_1331402735_3{{"DFA3 {1}"}}
DFA5_-1586947344_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_-2056918105["MiniDFA3 {1}"]
DFA4_1729851083_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_-1943603951["MiniDFA4 {1}"]
DFA6_1096598491_6[\"DFA6 {1}"/]
end
MiniDFA0_-1185011322 -->|"/"|MiniDFA1_1587917933
MiniDFA1_1587917933 -->|"*"|MiniDFA2_-979544238
MiniDFA2_-979544238 -->|"[^*]"|MiniDFA2_-979544238
MiniDFA2_-979544238 -->|"*"|MiniDFA3_-2056918105
MiniDFA3_-2056918105 -->|"[^/]"|MiniDFA2_-979544238
MiniDFA3_-2056918105 -->|"/"|MiniDFA4_-1943603951
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
MiniDFA0_-1185011322(["MiniDFA0 {1}"])
MiniDFA1_1587917933(["MiniDFA1 {1}"])
MiniDFA2_-979544238(["MiniDFA2 {3}"])
MiniDFA3_-2056918105(["MiniDFA3 {1}"])
MiniDFA4_-1943603951[\"MiniDFA4 {1}"/]
MiniDFA0_-1185011322 -->|"/"|MiniDFA1_1587917933
MiniDFA1_1587917933 -->|"*"|MiniDFA2_-979544238
MiniDFA2_-979544238 -->|"[^*]"|MiniDFA2_-979544238
MiniDFA2_-979544238 -->|"*"|MiniDFA3_-2056918105
MiniDFA3_-2056918105 -->|"[^/]"|MiniDFA2_-979544238
MiniDFA3_-2056918105 -->|"/"|MiniDFA4_-1943603951
```
-------------------------------
