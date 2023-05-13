# '>>='

pattern: `\>\>=`

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
eNFA44_6_6637886[["εNFA44-6 regex start"]]
eNFA44_0_59740974[["εNFA44-0 char{1, 1}"]]
eNFA44_1_797855[["εNFA44-1 char[1]"]]
eNFA44_2_7180698[["εNFA44-2 char{1, 1}"]]
eNFA44_3_64626289[["εNFA44-3 char[1]"]]
eNFA44_4_44765691[["εNFA44-4 char{1, 1}"]]
eNFA44_5_238043[["εNFA44-5 char[1]"]]
eNFA44_7_2142393[["εNFA44-7 regex end"]]
eNFA44_8_19281542[["εNFA44-8 post-regex start"]]
eNFA44_9_39316155[\"εNFA44-9 post-regex end"/]
eNFA44_6_6637886 -.->|"ε"|eNFA44_0_59740974
eNFA44_0_59740974 -->|">"|eNFA44_1_797855
eNFA44_1_797855 -.->|"ε"|eNFA44_2_7180698
eNFA44_2_7180698 -->|">"|eNFA44_3_64626289
eNFA44_3_64626289 -.->|"ε"|eNFA44_4_44765691
eNFA44_4_44765691 -->|"="|eNFA44_5_238043
eNFA44_5_238043 -.->|"ε"|eNFA44_7_2142393
eNFA44_7_2142393 -.->|"ε"|eNFA44_8_19281542
eNFA44_8_19281542 -.->|"ε"|eNFA44_9_39316155
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
eNFA44_6_18301082[["εNFA44-6 regex start"]]
eNFA44_0_30492010[["εNFA44-0 char{1, 1}"]]
eNFA44_1_5992637[["εNFA44-1 char[1]"]]
eNFA44_2_53933741[["εNFA44-2 char{1, 1}"]]
eNFA44_3_15641626[["εNFA44-3 char[1]"]]
eNFA44_4_6556909[["εNFA44-4 char{1, 1}"]]
eNFA44_5_59012183[\"εNFA44-5 char[1]"/]
eNFA44_7_61347601[\"εNFA44-7 regex end"/]
eNFA44_8_15257500[\"εNFA44-8 post-regex start"/]
eNFA44_9_3099778[\"εNFA44-9 post-regex end"/]
eNFA44_6_18301082 -.->|"ε"|eNFA44_0_30492010
eNFA44_6_18301082 -->|">"|eNFA44_1_5992637
eNFA44_0_30492010 -->|">"|eNFA44_1_5992637
eNFA44_1_5992637 -.->|"ε"|eNFA44_2_53933741
eNFA44_1_5992637 -->|">"|eNFA44_3_15641626
eNFA44_2_53933741 -->|">"|eNFA44_3_15641626
eNFA44_3_15641626 -.->|"ε"|eNFA44_4_6556909
eNFA44_3_15641626 -->|"="|eNFA44_5_59012183
eNFA44_4_6556909 -->|"="|eNFA44_5_59012183
eNFA44_5_59012183 -.->|"ε"|eNFA44_7_61347601
eNFA44_5_59012183 -.->|"ε"|eNFA44_8_15257500
eNFA44_5_59012183 -.->|"ε"|eNFA44_9_3099778
eNFA44_7_61347601 -.->|"ε"|eNFA44_8_15257500
eNFA44_7_61347601 -.->|"ε"|eNFA44_9_3099778
eNFA44_8_15257500 -.->|"ε"|eNFA44_9_3099778
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
NFA44_6_27898002("NFA44-6 regex start")
NFA44_1_49755431("NFA44-1 char[1]")
NFA44_3_45145696("NFA44-3 char[1]")
NFA44_5_3658088[\"NFA44-5 char[1]"/]
NFA44_6_27898002 -->|">"|NFA44_1_49755431
NFA44_1_49755431 -->|">"|NFA44_3_45145696
NFA44_3_45145696 -->|"="|NFA44_5_3658088
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
subgraph DFA0_90469185["DFA0 regex start"]
NFA44_6_27898002_0("NFA44-6 regex start")
end
subgraph DFA1_-1884142798["DFA1 {1}"]
NFA44_1_49755431_1("NFA44-1 char[1]")
end
subgraph DFA2_-738224412["DFA2 {1}"]
NFA44_3_45145696_2("NFA44-3 char[1]")
end
subgraph DFA3_-609496938["DFA3 {1}"]
NFA44_5_3658088_3[\"NFA44-5 char[1]"/]
end
DFA0_90469185 -->|">"|DFA1_-1884142798
DFA1_-1884142798 -->|">"|DFA2_-738224412
DFA2_-738224412 -->|"="|DFA3_-609496938
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
DFA0_90469185{{"DFA0 regex start"}}
DFA1_-1884142798{{"DFA1 {1}"}}
DFA2_-738224412{{"DFA2 {1}"}}
DFA3_-609496938[\"DFA3 {1}"/]
DFA0_90469185 -->|">"|DFA1_-1884142798
DFA1_-1884142798 -->|">"|DFA2_-738224412
DFA2_-738224412 -->|"="|DFA3_-609496938
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
subgraph MiniDFA0_945933772["MiniDFA0 {1}"]
DFA0_90469185_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_394836827["MiniDFA1 {1}"]
DFA1_-1884142798_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_105926155["MiniDFA2 {1}"]
DFA2_-738224412_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_255991549["MiniDFA3 {1}"]
DFA3_-609496938_3[\"DFA3 {1}"/]
end
MiniDFA0_945933772 -->|">"|MiniDFA1_394836827
MiniDFA1_394836827 -->|">"|MiniDFA2_105926155
MiniDFA2_105926155 -->|"="|MiniDFA3_255991549
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
MiniDFA0_945933772(["MiniDFA0 {1}"])
MiniDFA1_394836827(["MiniDFA1 {1}"])
MiniDFA2_105926155(["MiniDFA2 {1}"])
MiniDFA3_255991549[\"MiniDFA3 {1}"/]
MiniDFA0_945933772 -->|">"|MiniDFA1_394836827
MiniDFA1_394836827 -->|">"|MiniDFA2_105926155
MiniDFA2_105926155 -->|"="|MiniDFA3_255991549
```
-------------------------------
