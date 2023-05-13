# 'bool'

pattern: `bool`

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
eNFA79_8_29969153[["εNFA79-8 regex start"]]
eNFA79_0_1286929[["εNFA79-0 char{1, 1}"]]
eNFA79_1_11582368[["εNFA79-1 char[1]"]]
eNFA79_2_37132456[["εNFA79-2 char{1, 1}"]]
eNFA79_3_65756648[["εNFA79-3 char[1]"]]
eNFA79_4_54938922[["εNFA79-4 char{1, 1}"]]
eNFA79_5_24688256[["εNFA79-5 char[1]"]]
eNFA79_6_20867713[["εNFA79-6 char{1, 1}"]]
eNFA79_7_53591696[["εNFA79-7 char[1]"]]
eNFA79_9_12563221[["εNFA79-9 regex end"]]
eNFA79_10_45960129[["εNFA79-10 post-regex start"]]
eNFA79_11_10987981[\"εNFA79-11 post-regex end"/]
eNFA79_8_29969153 -.->|"ε"|eNFA79_0_1286929
eNFA79_0_1286929 -->|"b"|eNFA79_1_11582368
eNFA79_1_11582368 -.->|"ε"|eNFA79_2_37132456
eNFA79_2_37132456 -->|"o"|eNFA79_3_65756648
eNFA79_3_65756648 -.->|"ε"|eNFA79_4_54938922
eNFA79_4_54938922 -->|"o"|eNFA79_5_24688256
eNFA79_5_24688256 -.->|"ε"|eNFA79_6_20867713
eNFA79_6_20867713 -->|"l"|eNFA79_7_53591696
eNFA79_7_53591696 -.->|"ε"|eNFA79_9_12563221
eNFA79_9_12563221 -.->|"ε"|eNFA79_10_45960129
eNFA79_10_45960129 -.->|"ε"|eNFA79_11_10987981
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
eNFA79_8_31782970[["εNFA79-8 regex start"]]
eNFA79_0_17611282[["εNFA79-0 char{1, 1}"]]
eNFA79_1_24283812[["εNFA79-1 char[1]"]]
eNFA79_2_17227723[["εNFA79-2 char{1, 1}"]]
eNFA79_3_20831783[["εNFA79-3 char[1]"]]
eNFA79_4_53268321[["εNFA79-4 char{1, 1}"]]
eNFA79_5_9652842[["εNFA79-5 char[1]"]]
eNFA79_6_19766715[["εNFA79-6 char{1, 1}"]]
eNFA79_7_43682709[\"εNFA79-7 char[1]"/]
eNFA79_9_57600065[\"εNFA79-9 regex end"/]
eNFA79_10_48638545[\"εNFA79-10 post-regex start"/]
eNFA79_11_35093725[\"εNFA79-11 post-regex end"/]
eNFA79_8_31782970 -.->|"ε"|eNFA79_0_17611282
eNFA79_8_31782970 -->|"b"|eNFA79_1_24283812
eNFA79_0_17611282 -->|"b"|eNFA79_1_24283812
eNFA79_1_24283812 -.->|"ε"|eNFA79_2_17227723
eNFA79_1_24283812 -->|"o"|eNFA79_3_20831783
eNFA79_2_17227723 -->|"o"|eNFA79_3_20831783
eNFA79_3_20831783 -.->|"ε"|eNFA79_4_53268321
eNFA79_3_20831783 -->|"o"|eNFA79_5_9652842
eNFA79_4_53268321 -->|"o"|eNFA79_5_9652842
eNFA79_5_9652842 -.->|"ε"|eNFA79_6_19766715
eNFA79_5_9652842 -->|"l"|eNFA79_7_43682709
eNFA79_6_19766715 -->|"l"|eNFA79_7_43682709
eNFA79_7_43682709 -.->|"ε"|eNFA79_9_57600065
eNFA79_7_43682709 -.->|"ε"|eNFA79_10_48638545
eNFA79_7_43682709 -.->|"ε"|eNFA79_11_35093725
eNFA79_9_57600065 -.->|"ε"|eNFA79_10_48638545
eNFA79_9_57600065 -.->|"ε"|eNFA79_11_35093725
eNFA79_10_48638545 -.->|"ε"|eNFA79_11_35093725
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
NFA79_8_47408069("NFA79-8 regex start")
NFA79_1_24019444("NFA79-1 char[1]")
NFA79_3_14848410("NFA79-3 char[1]")
NFA79_5_66526832("NFA79-5 char[1]")
NFA79_7_61870584[\"NFA79-7 char[1]"/]
NFA79_8_47408069 -->|"b"|NFA79_1_24019444
NFA79_1_24019444 -->|"o"|NFA79_3_14848410
NFA79_3_14848410 -->|"o"|NFA79_5_66526832
NFA79_5_66526832 -->|"l"|NFA79_7_61870584
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
subgraph DFA0_1751417252["DFA0 regex start"]
NFA79_8_47408069_0("NFA79-8 regex start")
end
subgraph DFA1_-140745034["DFA1 {1}"]
NFA79_1_24019444_1("NFA79-1 char[1]")
end
subgraph DFA2_-1233142701["DFA2 {1}"]
NFA79_3_14848410_2("NFA79-3 char[1]")
end
subgraph DFA3_349530122["DFA3 {1}"]
NFA79_5_66526832_3("NFA79-5 char[1]")
end
subgraph DFA4_88772043["DFA4 {1}"]
NFA79_7_61870584_4[\"NFA79-7 char[1]"/]
end
DFA0_1751417252 -->|"b"|DFA1_-140745034
DFA1_-140745034 -->|"o"|DFA2_-1233142701
DFA2_-1233142701 -->|"o"|DFA3_349530122
DFA3_349530122 -->|"l"|DFA4_88772043
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
DFA0_1751417252{{"DFA0 regex start"}}
DFA1_-140745034{{"DFA1 {1}"}}
DFA2_-1233142701{{"DFA2 {1}"}}
DFA3_349530122{{"DFA3 {1}"}}
DFA4_88772043[\"DFA4 {1}"/]
DFA0_1751417252 -->|"b"|DFA1_-140745034
DFA1_-140745034 -->|"o"|DFA2_-1233142701
DFA2_-1233142701 -->|"o"|DFA3_349530122
DFA3_349530122 -->|"l"|DFA4_88772043
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
subgraph MiniDFA0_-1861824342["MiniDFA0 {1}"]
DFA0_1751417252_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1046780846["MiniDFA1 {1}"]
DFA1_-140745034_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1558655289["MiniDFA2 {1}"]
DFA2_-1233142701_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_813588066["MiniDFA3 {1}"]
DFA3_349530122_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-744785818["MiniDFA4 {1}"]
DFA4_88772043_4[\"DFA4 {1}"/]
end
MiniDFA0_-1861824342 -->|"b"|MiniDFA1_-1046780846
MiniDFA1_-1046780846 -->|"o"|MiniDFA2_1558655289
MiniDFA2_1558655289 -->|"o"|MiniDFA3_813588066
MiniDFA3_813588066 -->|"l"|MiniDFA4_-744785818
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
MiniDFA0_-1861824342(["MiniDFA0 {1}"])
MiniDFA1_-1046780846(["MiniDFA1 {1}"])
MiniDFA2_1558655289(["MiniDFA2 {1}"])
MiniDFA3_813588066(["MiniDFA3 {1}"])
MiniDFA4_-744785818[\"MiniDFA4 {1}"/]
MiniDFA0_-1861824342 -->|"b"|MiniDFA1_-1046780846
MiniDFA1_-1046780846 -->|"o"|MiniDFA2_1558655289
MiniDFA2_1558655289 -->|"o"|MiniDFA3_813588066
MiniDFA3_813588066 -->|"l"|MiniDFA4_-744785818
```
-------------------------------
