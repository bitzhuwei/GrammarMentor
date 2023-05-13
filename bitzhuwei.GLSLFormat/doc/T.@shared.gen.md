# 'shared'

pattern: `shared`

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
eNFA67_12_45081147[["εNFA67-12 regex start"]]
eNFA67_0_3077144[["εNFA67-0 char{1, 1}"]]
eNFA67_1_27694303[["εNFA67-1 char[1]"]]
eNFA67_2_47922135[["εNFA67-2 char{1, 1}"]]
eNFA67_3_28646034[["εNFA67-3 char[1]"]]
eNFA67_4_56487722[["εNFA67-4 char{1, 1}"]]
eNFA67_5_38627455[["εNFA67-5 char[1]"]]
eNFA67_6_12102778[["εNFA67-6 char{1, 1}"]]
eNFA67_7_41816140[["εNFA67-7 char[1]"]]
eNFA67_8_40800942[["εNFA67-8 char{1, 1}"]]
eNFA67_9_31664161[["εNFA67-9 char[1]"]]
eNFA67_10_16541999[["εNFA67-10 char{1, 1}"]]
eNFA67_11_14660263[["εNFA67-11 char[1]"]]
eNFA67_13_64833508[["εNFA67-13 regex end"]]
eNFA67_14_46630661[["εNFA67-14 post-regex start"]]
eNFA67_15_17022773[\"εNFA67-15 post-regex end"/]
eNFA67_12_45081147 -.->|"ε"|eNFA67_0_3077144
eNFA67_0_3077144 -->|"s"|eNFA67_1_27694303
eNFA67_1_27694303 -.->|"ε"|eNFA67_2_47922135
eNFA67_2_47922135 -->|"h"|eNFA67_3_28646034
eNFA67_3_28646034 -.->|"ε"|eNFA67_4_56487722
eNFA67_4_56487722 -->|"a"|eNFA67_5_38627455
eNFA67_5_38627455 -.->|"ε"|eNFA67_6_12102778
eNFA67_6_12102778 -->|"r"|eNFA67_7_41816140
eNFA67_7_41816140 -.->|"ε"|eNFA67_8_40800942
eNFA67_8_40800942 -->|"e"|eNFA67_9_31664161
eNFA67_9_31664161 -.->|"ε"|eNFA67_10_16541999
eNFA67_10_16541999 -->|"d"|eNFA67_11_14660263
eNFA67_11_14660263 -.->|"ε"|eNFA67_13_64833508
eNFA67_13_64833508 -.->|"ε"|eNFA67_14_46630661
eNFA67_14_46630661 -.->|"ε"|eNFA67_15_17022773
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
eNFA67_12_18987236[["εNFA67-12 regex start"]]
eNFA67_0_36667404[["εNFA67-0 char{1, 1}"]]
eNFA67_1_61571180[["εNFA67-1 char[1]"]]
eNFA67_2_17269710[["εNFA67-2 char{1, 1}"]]
eNFA67_3_21209668[["εNFA67-3 char[1]"]]
eNFA67_4_56669285[["εNFA67-4 char{1, 1}"]]
eNFA67_5_40261524[["εNFA67-5 char[1]"]]
eNFA67_6_26809401[["εNFA67-6 char{1, 1}"]]
eNFA67_7_39958021[["εNFA67-7 char[1]"]]
eNFA67_8_24077873[["εNFA67-8 char{1, 1}"]]
eNFA67_9_15374270[["εNFA67-9 char[1]"]]
eNFA67_10_4150710[["εNFA67-10 char{1, 1}"]]
eNFA67_11_37356392[\"εNFA67-11 char[1]"/]
eNFA67_13_663215[\"εNFA67-13 regex end"/]
eNFA67_14_5968939[\"εNFA67-14 post-regex start"/]
eNFA67_15_53720453[\"εNFA67-15 post-regex end"/]
eNFA67_12_18987236 -.->|"ε"|eNFA67_0_36667404
eNFA67_12_18987236 -->|"s"|eNFA67_1_61571180
eNFA67_0_36667404 -->|"s"|eNFA67_1_61571180
eNFA67_1_61571180 -.->|"ε"|eNFA67_2_17269710
eNFA67_1_61571180 -->|"h"|eNFA67_3_21209668
eNFA67_2_17269710 -->|"h"|eNFA67_3_21209668
eNFA67_3_21209668 -.->|"ε"|eNFA67_4_56669285
eNFA67_3_21209668 -->|"a"|eNFA67_5_40261524
eNFA67_4_56669285 -->|"a"|eNFA67_5_40261524
eNFA67_5_40261524 -.->|"ε"|eNFA67_6_26809401
eNFA67_5_40261524 -->|"r"|eNFA67_7_39958021
eNFA67_6_26809401 -->|"r"|eNFA67_7_39958021
eNFA67_7_39958021 -.->|"ε"|eNFA67_8_24077873
eNFA67_7_39958021 -->|"e"|eNFA67_9_15374270
eNFA67_8_24077873 -->|"e"|eNFA67_9_15374270
eNFA67_9_15374270 -.->|"ε"|eNFA67_10_4150710
eNFA67_9_15374270 -->|"d"|eNFA67_11_37356392
eNFA67_10_4150710 -->|"d"|eNFA67_11_37356392
eNFA67_11_37356392 -.->|"ε"|eNFA67_13_663215
eNFA67_11_37356392 -.->|"ε"|eNFA67_14_5968939
eNFA67_11_37356392 -.->|"ε"|eNFA67_15_53720453
eNFA67_13_663215 -.->|"ε"|eNFA67_14_5968939
eNFA67_13_663215 -.->|"ε"|eNFA67_15_53720453
eNFA67_14_5968939 -.->|"ε"|eNFA67_15_53720453
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
NFA67_12_13722030("NFA67-12 regex start")
NFA67_1_56389407("NFA67-1 char[1]")
NFA67_3_37742617("NFA67-3 char[1]")
NFA67_5_4139237("NFA67-5 char[1]")
NFA67_7_37253141("NFA67-7 char[1]")
NFA67_9_66842817("NFA67-9 char[1]")
NFA67_11_64714441[\"NFA67-11 char[1]"/]
NFA67_12_13722030 -->|"s"|NFA67_1_56389407
NFA67_1_56389407 -->|"h"|NFA67_3_37742617
NFA67_3_37742617 -->|"a"|NFA67_5_4139237
NFA67_5_4139237 -->|"r"|NFA67_7_37253141
NFA67_7_37253141 -->|"e"|NFA67_9_66842817
NFA67_9_66842817 -->|"d"|NFA67_11_64714441
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
subgraph DFA0_915992264["DFA0 regex start"]
NFA67_12_13722030_0("NFA67-12 regex start")
end
subgraph DFA1_2028417932["DFA1 {1}"]
NFA67_1_56389407_1("NFA67-1 char[1]")
end
subgraph DFA2_1531034229["DFA2 {1}"]
NFA67_3_37742617_2("NFA67-3 char[1]")
end
subgraph DFA3_-528382328["DFA3 {1}"]
NFA67_5_4139237_3("NFA67-5 char[1]")
end
subgraph DFA4_-28897352["DFA4 {1}"]
NFA67_7_37253141_4("NFA67-7 char[1]")
end
subgraph DFA5_1421466925["DFA5 {1}"]
NFA67_9_66842817_5("NFA67-9 char[1]")
end
subgraph DFA6_987790314["DFA6 {1}"]
NFA67_11_64714441_6[\"NFA67-11 char[1]"/]
end
DFA0_915992264 -->|"s"|DFA1_2028417932
DFA1_2028417932 -->|"h"|DFA2_1531034229
DFA2_1531034229 -->|"a"|DFA3_-528382328
DFA3_-528382328 -->|"r"|DFA4_-28897352
DFA4_-28897352 -->|"e"|DFA5_1421466925
DFA5_1421466925 -->|"d"|DFA6_987790314
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
DFA0_915992264{{"DFA0 regex start"}}
DFA1_2028417932{{"DFA1 {1}"}}
DFA2_1531034229{{"DFA2 {1}"}}
DFA3_-528382328{{"DFA3 {1}"}}
DFA4_-28897352{{"DFA4 {1}"}}
DFA5_1421466925{{"DFA5 {1}"}}
DFA6_987790314[\"DFA6 {1}"/]
DFA0_915992264 -->|"s"|DFA1_2028417932
DFA1_2028417932 -->|"h"|DFA2_1531034229
DFA2_1531034229 -->|"a"|DFA3_-528382328
DFA3_-528382328 -->|"r"|DFA4_-28897352
DFA4_-28897352 -->|"e"|DFA5_1421466925
DFA5_1421466925 -->|"d"|DFA6_987790314
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
subgraph MiniDFA0_-861300806["MiniDFA0 {1}"]
DFA0_915992264_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1314059409["MiniDFA1 {1}"]
DFA1_2028417932_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1024009066["MiniDFA2 {1}"]
DFA2_1531034229_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_565233599["MiniDFA3 {1}"]
DFA3_-528382328_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1071902005["MiniDFA4 {1}"]
DFA4_-28897352_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1701270817["MiniDFA5 {1}"]
DFA5_1421466925_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_-863713600["MiniDFA6 {1}"]
DFA6_987790314_6[\"DFA6 {1}"/]
end
MiniDFA0_-861300806 -->|"s"|MiniDFA1_1314059409
MiniDFA1_1314059409 -->|"h"|MiniDFA2_-1024009066
MiniDFA2_-1024009066 -->|"a"|MiniDFA3_565233599
MiniDFA3_565233599 -->|"r"|MiniDFA4_1071902005
MiniDFA4_1071902005 -->|"e"|MiniDFA5_-1701270817
MiniDFA5_-1701270817 -->|"d"|MiniDFA6_-863713600
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
MiniDFA0_-861300806(["MiniDFA0 {1}"])
MiniDFA1_1314059409(["MiniDFA1 {1}"])
MiniDFA2_-1024009066(["MiniDFA2 {1}"])
MiniDFA3_565233599(["MiniDFA3 {1}"])
MiniDFA4_1071902005(["MiniDFA4 {1}"])
MiniDFA5_-1701270817(["MiniDFA5 {1}"])
MiniDFA6_-863713600[\"MiniDFA6 {1}"/]
MiniDFA0_-861300806 -->|"s"|MiniDFA1_1314059409
MiniDFA1_1314059409 -->|"h"|MiniDFA2_-1024009066
MiniDFA2_-1024009066 -->|"a"|MiniDFA3_565233599
MiniDFA3_565233599 -->|"r"|MiniDFA4_1071902005
MiniDFA4_1071902005 -->|"e"|MiniDFA5_-1701270817
MiniDFA5_-1701270817 -->|"d"|MiniDFA6_-863713600
```
-------------------------------
