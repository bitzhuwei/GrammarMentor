# '<<='

pattern: `\<\<=`

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
eNFA43_6_15816986[["εNFA43-6 regex start"]]
eNFA43_0_8135151[["εNFA43-0 char{1, 1}"]]
eNFA43_1_6107499[["εNFA43-1 char[1]"]]
eNFA43_2_54967495[["εNFA43-2 char{1, 1}"]]
eNFA43_3_24945412[["εNFA43-3 char[1]"]]
eNFA43_4_23182124[["εNFA43-4 char{1, 1}"]]
eNFA43_5_7312526[["εNFA43-5 char[1]"]]
eNFA43_7_65812741[["εNFA43-7 regex end"]]
eNFA43_8_55443761[["εNFA43-8 post-regex start"]]
eNFA43_9_29231803[\"εNFA43-9 post-regex end"/]
eNFA43_6_15816986 -.->|"ε"|eNFA43_0_8135151
eNFA43_0_8135151 -->|"<"|eNFA43_1_6107499
eNFA43_1_6107499 -.->|"ε"|eNFA43_2_54967495
eNFA43_2_54967495 -->|"<"|eNFA43_3_24945412
eNFA43_3_24945412 -.->|"ε"|eNFA43_4_23182124
eNFA43_4_23182124 -->|"="|eNFA43_5_7312526
eNFA43_5_7312526 -.->|"ε"|eNFA43_7_65812741
eNFA43_7_65812741 -.->|"ε"|eNFA43_8_55443761
eNFA43_8_55443761 -.->|"ε"|eNFA43_9_29231803
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
eNFA43_6_61759636[["εNFA43-6 regex start"]]
eNFA43_0_18965813[["εNFA43-0 char{1, 1}"]]
eNFA43_1_36474591[["εNFA43-1 char[1]"]]
eNFA43_2_59835867[["εNFA43-2 char{1, 1}"]]
eNFA43_3_1651899[["εNFA43-3 char[1]"]]
eNFA43_4_14867095[["εNFA43-4 char{1, 1}"]]
eNFA43_5_66694991[\"εNFA43-5 char[1]"/]
eNFA43_7_63384014[\"εNFA43-7 regex end"/]
eNFA43_8_33585220[\"εNFA43-8 post-regex start"/]
eNFA43_9_33831530[\"εNFA43-9 post-regex end"/]
eNFA43_6_61759636 -.->|"ε"|eNFA43_0_18965813
eNFA43_6_61759636 -->|"<"|eNFA43_1_36474591
eNFA43_0_18965813 -->|"<"|eNFA43_1_36474591
eNFA43_1_36474591 -.->|"ε"|eNFA43_2_59835867
eNFA43_1_36474591 -->|"<"|eNFA43_3_1651899
eNFA43_2_59835867 -->|"<"|eNFA43_3_1651899
eNFA43_3_1651899 -.->|"ε"|eNFA43_4_14867095
eNFA43_3_1651899 -->|"="|eNFA43_5_66694991
eNFA43_4_14867095 -->|"="|eNFA43_5_66694991
eNFA43_5_66694991 -.->|"ε"|eNFA43_7_63384014
eNFA43_5_66694991 -.->|"ε"|eNFA43_8_33585220
eNFA43_5_66694991 -.->|"ε"|eNFA43_9_33831530
eNFA43_7_63384014 -.->|"ε"|eNFA43_8_33585220
eNFA43_7_63384014 -.->|"ε"|eNFA43_9_33831530
eNFA43_8_33585220 -.->|"ε"|eNFA43_9_33831530
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
NFA43_6_36048322("NFA43-6 regex start")
NFA43_1_55999443("NFA43-1 char[1]")
NFA43_3_34232944("NFA43-3 char[1]")
NFA43_5_39661040[\"NFA43-5 char[1]"/]
NFA43_6_36048322 -->|"<"|NFA43_1_55999443
NFA43_1_55999443 -->|"<"|NFA43_3_34232944
NFA43_3_34232944 -->|"="|NFA43_5_39661040
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
subgraph DFA0_1499697663["DFA0 regex start"]
NFA43_6_36048322_0("NFA43-6 regex start")
end
subgraph DFA1_1024542511["DFA1 {1}"]
NFA43_1_55999443_1("NFA43-1 char[1]")
end
subgraph DFA2_1477687350["DFA2 {1}"]
NFA43_3_34232944_2("NFA43-3 char[1]")
end
subgraph DFA3_-1161433443["DFA3 {1}"]
NFA43_5_39661040_3[\"NFA43-5 char[1]"/]
end
DFA0_1499697663 -->|"<"|DFA1_1024542511
DFA1_1024542511 -->|"<"|DFA2_1477687350
DFA2_1477687350 -->|"="|DFA3_-1161433443
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
DFA0_1499697663{{"DFA0 regex start"}}
DFA1_1024542511{{"DFA1 {1}"}}
DFA2_1477687350{{"DFA2 {1}"}}
DFA3_-1161433443[\"DFA3 {1}"/]
DFA0_1499697663 -->|"<"|DFA1_1024542511
DFA1_1024542511 -->|"<"|DFA2_1477687350
DFA2_1477687350 -->|"="|DFA3_-1161433443
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
subgraph MiniDFA0_-297768061["MiniDFA0 {1}"]
DFA0_1499697663_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-408040059["MiniDFA1 {1}"]
DFA1_1024542511_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1189589971["MiniDFA2 {1}"]
DFA2_1477687350_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-112191547["MiniDFA3 {1}"]
DFA3_-1161433443_3[\"DFA3 {1}"/]
end
MiniDFA0_-297768061 -->|"<"|MiniDFA1_-408040059
MiniDFA1_-408040059 -->|"<"|MiniDFA2_-1189589971
MiniDFA2_-1189589971 -->|"="|MiniDFA3_-112191547
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
MiniDFA0_-297768061(["MiniDFA0 {1}"])
MiniDFA1_-408040059(["MiniDFA1 {1}"])
MiniDFA2_-1189589971(["MiniDFA2 {1}"])
MiniDFA3_-112191547[\"MiniDFA3 {1}"/]
MiniDFA0_-297768061 -->|"<"|MiniDFA1_-408040059
MiniDFA1_-408040059 -->|"<"|MiniDFA2_-1189589971
MiniDFA2_-1189589971 -->|"="|MiniDFA3_-112191547
```
-------------------------------
