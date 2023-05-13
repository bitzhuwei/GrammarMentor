# 'mat4x3'

pattern: `mat4x3`

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
eNFA105_12_43779089[["εNFA105-12 regex start"]]
eNFA105_0_58467488[["εNFA105-0 char{1, 1}"]]
eNFA105_1_56445345[["εNFA105-1 char[1]"]]
eNFA105_2_38246063[["εNFA105-2 char{1, 1}"]]
eNFA105_3_8670250[["εNFA105-3 char[1]"]]
eNFA105_4_10923387[["εNFA105-4 char{1, 1}"]]
eNFA105_5_31201619[["εNFA105-5 char[1]"]]
eNFA105_6_12379115[["εNFA105-6 char{1, 1}"]]
eNFA105_7_44303172[["εNFA105-7 char[1]"]]
eNFA105_8_63184231[["εNFA105-8 char{1, 1}"]]
eNFA105_9_31787174[["εNFA105-9 char[1]"]]
eNFA105_10_17649112[["εNFA105-10 char{1, 1}"]]
eNFA105_11_24624288[["εNFA105-11 char[1]"]]
eNFA105_13_20292006[["εNFA105-13 regex end"]]
eNFA105_14_48410331[["εNFA105-14 post-regex start"]]
eNFA105_15_33039800[\"εNFA105-15 post-regex end"/]
eNFA105_12_43779089 -.->|"ε"|eNFA105_0_58467488
eNFA105_0_58467488 -->|"m"|eNFA105_1_56445345
eNFA105_1_56445345 -.->|"ε"|eNFA105_2_38246063
eNFA105_2_38246063 -->|"a"|eNFA105_3_8670250
eNFA105_3_8670250 -.->|"ε"|eNFA105_4_10923387
eNFA105_4_10923387 -->|"t"|eNFA105_5_31201619
eNFA105_5_31201619 -.->|"ε"|eNFA105_6_12379115
eNFA105_6_12379115 -->|"4"|eNFA105_7_44303172
eNFA105_7_44303172 -.->|"ε"|eNFA105_8_63184231
eNFA105_8_63184231 -->|"x"|eNFA105_9_31787174
eNFA105_9_31787174 -.->|"ε"|eNFA105_10_17649112
eNFA105_10_17649112 -->|"3"|eNFA105_11_24624288
eNFA105_11_24624288 -.->|"ε"|eNFA105_13_20292006
eNFA105_13_20292006 -.->|"ε"|eNFA105_14_48410331
eNFA105_14_48410331 -.->|"ε"|eNFA105_15_33039800
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
eNFA105_12_28922751[["εNFA105-12 regex start"]]
eNFA105_0_58978167[["εNFA105-0 char{1, 1}"]]
eNFA105_1_61041458[["εNFA105-1 char[1]"]]
eNFA105_2_12502218[["εNFA105-2 char{1, 1}"]]
eNFA105_3_45411103[["εNFA105-3 char[1]"]]
eNFA105_4_6046746[["εNFA105-4 char{1, 1}"]]
eNFA105_5_54420716[["εNFA105-5 char[1]"]]
eNFA105_6_20024398[["εNFA105-6 char{1, 1}"]]
eNFA105_7_46001857[["εNFA105-7 char[1]"]]
eNFA105_8_11363535[["εNFA105-8 char{1, 1}"]]
eNFA105_9_35162951[["εNFA105-9 char[1]"]]
eNFA105_10_48031108[["εNFA105-10 char{1, 1}"]]
eNFA105_11_29626789[\"εNFA105-11 char[1]"/]
eNFA105_13_65314517[\"εNFA105-13 regex end"/]
eNFA105_14_50959748[\"εNFA105-14 post-regex start"/]
eNFA105_15_55984556[\"εNFA105-15 post-regex end"/]
eNFA105_12_28922751 -.->|"ε"|eNFA105_0_58978167
eNFA105_12_28922751 -->|"m"|eNFA105_1_61041458
eNFA105_0_58978167 -->|"m"|eNFA105_1_61041458
eNFA105_1_61041458 -.->|"ε"|eNFA105_2_12502218
eNFA105_1_61041458 -->|"a"|eNFA105_3_45411103
eNFA105_2_12502218 -->|"a"|eNFA105_3_45411103
eNFA105_3_45411103 -.->|"ε"|eNFA105_4_6046746
eNFA105_3_45411103 -->|"t"|eNFA105_5_54420716
eNFA105_4_6046746 -->|"t"|eNFA105_5_54420716
eNFA105_5_54420716 -.->|"ε"|eNFA105_6_20024398
eNFA105_5_54420716 -->|"4"|eNFA105_7_46001857
eNFA105_6_20024398 -->|"4"|eNFA105_7_46001857
eNFA105_7_46001857 -.->|"ε"|eNFA105_8_11363535
eNFA105_7_46001857 -->|"x"|eNFA105_9_35162951
eNFA105_8_11363535 -->|"x"|eNFA105_9_35162951
eNFA105_9_35162951 -.->|"ε"|eNFA105_10_48031108
eNFA105_9_35162951 -->|"3"|eNFA105_11_29626789
eNFA105_10_48031108 -->|"3"|eNFA105_11_29626789
eNFA105_11_29626789 -.->|"ε"|eNFA105_13_65314517
eNFA105_11_29626789 -.->|"ε"|eNFA105_14_50959748
eNFA105_11_29626789 -.->|"ε"|eNFA105_15_55984556
eNFA105_13_65314517 -.->|"ε"|eNFA105_14_50959748
eNFA105_13_65314517 -.->|"ε"|eNFA105_15_55984556
eNFA105_14_50959748 -.->|"ε"|eNFA105_15_55984556
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
NFA105_12_34098956("NFA105-12 regex start")
NFA105_1_38455150("NFA105-1 char[1]")
NFA105_3_10552036("NFA105-3 char[1]")
NFA105_5_27859461("NFA105-5 char[1]")
NFA105_7_49408564("NFA105-7 char[1]")
NFA105_9_42023897("NFA105-9 char[1]")
NFA105_11_42670757[\"NFA105-11 char[1]"/]
NFA105_12_34098956 -->|"m"|NFA105_1_38455150
NFA105_1_38455150 -->|"a"|NFA105_3_10552036
NFA105_3_10552036 -->|"t"|NFA105_5_27859461
NFA105_5_27859461 -->|"4"|NFA105_7_49408564
NFA105_7_49408564 -->|"x"|NFA105_9_42023897
NFA105_9_42023897 -->|"3"|NFA105_11_42670757
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
subgraph DFA0_10782333["DFA0 regex start"]
NFA105_12_34098956_0("NFA105-12 regex start")
end
subgraph DFA1_-185078187["DFA1 {1}"]
NFA105_1_38455150_1("NFA105-1 char[1]")
end
subgraph DFA2_-313718967["DFA2 {1}"]
NFA105_3_10552036_2("NFA105-3 char[1]")
end
subgraph DFA3_-2055738151["DFA3 {1}"]
NFA105_5_27859461_3("NFA105-5 char[1]")
end
subgraph DFA4_-1077162675["DFA4 {1}"]
NFA105_7_49408564_4("NFA105-7 char[1]")
end
subgraph DFA5_620281963["DFA5 {1}"]
NFA105_9_42023897_5("NFA105-9 char[1]")
end
subgraph DFA6_-1455690303["DFA6 {1}"]
NFA105_11_42670757_6[\"NFA105-11 char[1]"/]
end
DFA0_10782333 -->|"m"|DFA1_-185078187
DFA1_-185078187 -->|"a"|DFA2_-313718967
DFA2_-313718967 -->|"t"|DFA3_-2055738151
DFA3_-2055738151 -->|"4"|DFA4_-1077162675
DFA4_-1077162675 -->|"x"|DFA5_620281963
DFA5_620281963 -->|"3"|DFA6_-1455690303
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
DFA0_10782333{{"DFA0 regex start"}}
DFA1_-185078187{{"DFA1 {1}"}}
DFA2_-313718967{{"DFA2 {1}"}}
DFA3_-2055738151{{"DFA3 {1}"}}
DFA4_-1077162675{{"DFA4 {1}"}}
DFA5_620281963{{"DFA5 {1}"}}
DFA6_-1455690303[\"DFA6 {1}"/]
DFA0_10782333 -->|"m"|DFA1_-185078187
DFA1_-185078187 -->|"a"|DFA2_-313718967
DFA2_-313718967 -->|"t"|DFA3_-2055738151
DFA3_-2055738151 -->|"4"|DFA4_-1077162675
DFA4_-1077162675 -->|"x"|DFA5_620281963
DFA5_620281963 -->|"3"|DFA6_-1455690303
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
subgraph MiniDFA0_1526369698["MiniDFA0 {1}"]
DFA0_10782333_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-410851437["MiniDFA1 {1}"]
DFA1_-185078187_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1188742831["MiniDFA2 {1}"]
DFA2_-313718967_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_243753369["MiniDFA3 {1}"]
DFA3_-2055738151_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-74515586["MiniDFA4 {1}"]
DFA4_-1077162675_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-577138831["MiniDFA5 {1}"]
DFA5_620281963_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_1657814996["MiniDFA6 {1}"]
DFA6_-1455690303_6[\"DFA6 {1}"/]
end
MiniDFA0_1526369698 -->|"m"|MiniDFA1_-410851437
MiniDFA1_-410851437 -->|"a"|MiniDFA2_-1188742831
MiniDFA2_-1188742831 -->|"t"|MiniDFA3_243753369
MiniDFA3_243753369 -->|"4"|MiniDFA4_-74515586
MiniDFA4_-74515586 -->|"x"|MiniDFA5_-577138831
MiniDFA5_-577138831 -->|"3"|MiniDFA6_1657814996
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
MiniDFA0_1526369698(["MiniDFA0 {1}"])
MiniDFA1_-410851437(["MiniDFA1 {1}"])
MiniDFA2_-1188742831(["MiniDFA2 {1}"])
MiniDFA3_243753369(["MiniDFA3 {1}"])
MiniDFA4_-74515586(["MiniDFA4 {1}"])
MiniDFA5_-577138831(["MiniDFA5 {1}"])
MiniDFA6_1657814996[\"MiniDFA6 {1}"/]
MiniDFA0_1526369698 -->|"m"|MiniDFA1_-410851437
MiniDFA1_-410851437 -->|"a"|MiniDFA2_-1188742831
MiniDFA2_-1188742831 -->|"t"|MiniDFA3_243753369
MiniDFA3_243753369 -->|"4"|MiniDFA4_-74515586
MiniDFA4_-74515586 -->|"x"|MiniDFA5_-577138831
MiniDFA5_-577138831 -->|"3"|MiniDFA6_1657814996
```
-------------------------------
