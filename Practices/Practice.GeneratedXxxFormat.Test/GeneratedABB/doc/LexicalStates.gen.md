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
eNFA0_0_57712780[["εNFA0-0 wholeStart"]]
eNFA1_2_20234383[["εNFA1-2 regex start"]]
class eNFA1_2_20234383 c1000;
eNFA2_2_49652976[["εNFA2-2 regex start"]]
class eNFA2_2_49652976 c1000;
eNFA3_2_41421720[["εNFA3-2 regex start"]]
class eNFA3_2_41421720 c1000;
eNFA1_0_47891719[["εNFA1-0 char{1, 1}"]]
eNFA2_0_25342185[["εNFA2-0 char{1, 1}"]]
eNFA3_0_66824994[["εNFA3-0 char{1, 1}"]]
eNFA1_1_28372289[["εNFA1-1 char[1]"]]
eNFA2_1_26753075[["εNFA2-1 char[1]"]]
eNFA3_1_64554036[["εNFA3-1 char[1]"]]
eNFA1_3_54024015[["εNFA1-3 regex end"]]
class eNFA1_3_54024015 c0100;
eNFA2_3_39451090[["εNFA2-3 regex end"]]
class eNFA2_3_39451090 c0100;
eNFA3_3_44115416[["εNFA3-3 regex end"]]
class eNFA3_3_44115416 c0100;
eNFA1_4_16454088[["εNFA1-4 post-regex start"]]
class eNFA1_4_16454088 c0010;
eNFA2_4_19515494[["εNFA2-4 post-regex start"]]
class eNFA2_4_19515494 c0010;
eNFA3_4_61494432[["εNFA3-4 post-regex start"]]
class eNFA3_4_61494432 c0010;
eNFA1_5_13869071[\"εNFA1-5 post-regex end"/]
class eNFA1_5_13869071 c0001;
eNFA2_5_44223604[\"εNFA2-5 post-regex end"/]
class eNFA2_5_44223604 c0001;
eNFA3_5_37251161[\"εNFA3-5 post-regex end"/]
class eNFA3_5_37251161 c0001;
eNFA0_1_62468121[\"εNFA0-1 wholeEnd"/]
eNFA0_0_57712780 -.->|"ε"|eNFA1_2_20234383
eNFA0_0_57712780 -.->|"ε"|eNFA2_2_49652976
eNFA0_0_57712780 -.->|"ε"|eNFA3_2_41421720
eNFA1_2_20234383 -.->|"ε
BeginToken '+'"|eNFA1_0_47891719
eNFA2_2_49652976 -.->|"ε
BeginToken 'a'"|eNFA2_0_25342185
eNFA3_2_41421720 -.->|"ε
BeginToken 'b'"|eNFA3_0_66824994
eNFA1_0_47891719 -->|"+"|eNFA1_1_28372289
eNFA2_0_25342185 -->|"a"|eNFA2_1_26753075
eNFA3_0_66824994 -->|"b"|eNFA3_1_64554036
eNFA1_1_28372289 -.->|"ε
ExtendToken '+'"|eNFA1_3_54024015
eNFA2_1_26753075 -.->|"ε
ExtendToken 'a'"|eNFA2_3_39451090
eNFA3_1_64554036 -.->|"ε
ExtendToken 'b'"|eNFA3_3_44115416
eNFA1_3_54024015 -.->|"ε"|eNFA1_4_16454088
eNFA2_3_39451090 -.->|"ε"|eNFA2_4_19515494
eNFA3_3_44115416 -.->|"ε"|eNFA3_4_61494432
eNFA1_4_16454088 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_13869071
eNFA2_4_19515494 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_44223604
eNFA3_4_61494432 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_37251161
eNFA1_5_13869071 -.->|"ε"|eNFA0_1_62468121
eNFA2_5_44223604 -.->|"ε"|eNFA0_1_62468121
eNFA3_5_37251161 -.->|"ε"|eNFA0_1_62468121
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
eNFA0_0_16578980[["εNFA0-0 wholeStart"]]
class eNFA0_0_16578980 c1000;
eNFA1_2_720107[["εNFA1-2 regex start"]]
class eNFA1_2_720107 c1000;
eNFA2_2_14993092[["εNFA2-2 regex start"]]
class eNFA2_2_14993092 c1000;
eNFA3_2_6480969[["εNFA3-2 regex start"]]
class eNFA3_2_6480969 c1000;
eNFA1_0_40041277[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_40041277 c1000;
eNFA2_0_46729429[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_46729429 c1000;
eNFA3_0_38496415[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_38496415 c1000;
eNFA1_1_24827179[\"εNFA1-1 char[1]
AcceptToken '+'"/]
class eNFA1_1_24827179 c0111;
eNFA2_1_17911681[\"εNFA2-1 char[1]
AcceptToken 'a'"/]
class eNFA2_1_17911681 c0111;
eNFA3_1_10923418[\"εNFA3-1 char[1]
AcceptToken 'b'"/]
class eNFA3_1_10923418 c0111;
eNFA1_3_22118023[\"εNFA1-3 regex end
AcceptToken '+'"/]
class eNFA1_3_22118023 c0111;
eNFA1_4_64844482[\"εNFA1-4 post-regex start
AcceptToken '+'"/]
class eNFA1_4_64844482 c0011;
eNFA1_5_27006480[\"εNFA1-5 post-regex end"/]
class eNFA1_5_27006480 c0011;
eNFA0_1_55196503[\"εNFA0-1 wholeEnd"/]
eNFA2_3_26987408[\"εNFA2-3 regex end
AcceptToken 'a'"/]
class eNFA2_3_26987408 c0111;
eNFA2_4_41560081[\"εNFA2-4 post-regex start
AcceptToken 'a'"/]
class eNFA2_4_41560081 c0011;
eNFA2_5_58328727[\"εNFA2-5 post-regex end"/]
class eNFA2_5_58328727 c0011;
eNFA3_3_31201899[\"εNFA3-3 regex end
AcceptToken 'b'"/]
class eNFA3_3_31201899 c0111;
eNFA3_4_12381635[\"εNFA3-4 post-regex start
AcceptToken 'b'"/]
class eNFA3_4_12381635 c0011;
eNFA3_5_41731733[\"εNFA3-5 post-regex end"/]
class eNFA3_5_41731733 c0011;
eNFA0_0_16578980 -.->|"ε"|eNFA1_2_720107
eNFA0_0_16578980 -.->|"ε"|eNFA2_2_14993092
eNFA0_0_16578980 -.->|"ε"|eNFA3_2_6480969
eNFA0_0_16578980 -.->|"ε
BeginToken '+'"|eNFA1_0_40041277
eNFA0_0_16578980 -.->|"ε
BeginToken 'a'"|eNFA2_0_46729429
eNFA0_0_16578980 -.->|"ε
BeginToken 'b'"|eNFA3_0_38496415
eNFA0_0_16578980 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_24827179
eNFA0_0_16578980 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_17911681
eNFA0_0_16578980 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_10923418
eNFA1_2_720107 -.->|"ε
BeginToken '+'"|eNFA1_0_40041277
eNFA1_2_720107 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_24827179
eNFA2_2_14993092 -.->|"ε
BeginToken 'a'"|eNFA2_0_46729429
eNFA2_2_14993092 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_17911681
eNFA3_2_6480969 -.->|"ε
BeginToken 'b'"|eNFA3_0_38496415
eNFA3_2_6480969 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_10923418
eNFA1_0_40041277 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_24827179
eNFA2_0_46729429 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_17911681
eNFA3_0_38496415 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_10923418
eNFA1_1_24827179 -.->|"ε
ExtendToken '+'"|eNFA1_3_22118023
eNFA1_1_24827179 -.->|"ε"|eNFA1_4_64844482
eNFA1_1_24827179 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_27006480
eNFA1_1_24827179 -.->|"ε
CheckToken '+'"|eNFA0_1_55196503
eNFA2_1_17911681 -.->|"ε
ExtendToken 'a'"|eNFA2_3_26987408
eNFA2_1_17911681 -.->|"ε"|eNFA2_4_41560081
eNFA2_1_17911681 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_58328727
eNFA2_1_17911681 -.->|"ε
CheckToken 'a'"|eNFA0_1_55196503
eNFA3_1_10923418 -.->|"ε
ExtendToken 'b'"|eNFA3_3_31201899
eNFA3_1_10923418 -.->|"ε"|eNFA3_4_12381635
eNFA3_1_10923418 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_41731733
eNFA3_1_10923418 -.->|"ε
CheckToken 'b'"|eNFA0_1_55196503
eNFA1_3_22118023 -.->|"ε"|eNFA1_4_64844482
eNFA1_3_22118023 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_27006480
eNFA1_3_22118023 -.->|"ε
CheckToken '+'"|eNFA0_1_55196503
eNFA1_4_64844482 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_27006480
eNFA1_4_64844482 -.->|"ε
CheckToken '+'"|eNFA0_1_55196503
eNFA1_5_27006480 -.->|"ε
CheckToken '+'"|eNFA0_1_55196503
eNFA2_3_26987408 -.->|"ε"|eNFA2_4_41560081
eNFA2_3_26987408 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_58328727
eNFA2_3_26987408 -.->|"ε
CheckToken 'a'"|eNFA0_1_55196503
eNFA2_4_41560081 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_58328727
eNFA2_4_41560081 -.->|"ε
CheckToken 'a'"|eNFA0_1_55196503
eNFA2_5_58328727 -.->|"ε
CheckToken 'a'"|eNFA0_1_55196503
eNFA3_3_31201899 -.->|"ε"|eNFA3_4_12381635
eNFA3_3_31201899 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_41731733
eNFA3_3_31201899 -.->|"ε
CheckToken 'b'"|eNFA0_1_55196503
eNFA3_4_12381635 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_41731733
eNFA3_4_12381635 -.->|"ε
CheckToken 'b'"|eNFA0_1_55196503
eNFA3_5_41731733 -.->|"ε
CheckToken 'b'"|eNFA0_1_55196503
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
NFA0_0_63388340("NFA0-0 wholeStart")
class NFA0_0_63388340 c1000;
NFA1_1_44325851[\"NFA1-1 char[1]
AcceptToken '+'"/]
class NFA1_1_44325851 c0101;
NFA2_1_33624151[\"NFA2-1 char[1]
AcceptToken 'a'"/]
class NFA2_1_33624151 c0101;
NFA3_1_34181910[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_34181910 c0101;
NFA0_0_63388340 -->|"+
BeginToken '+'
ExtendToken '+'"|NFA1_1_44325851
NFA0_0_63388340 -->|"a
BeginToken 'a'
ExtendToken 'a'"|NFA2_1_33624151
NFA0_0_63388340 -->|"b
BeginToken 'b'
ExtendToken 'b'"|NFA3_1_34181910
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
subgraph DFA0_1303046169["DFA0 wholeStart"]
NFA0_0_63388340_0("NFA0-0 wholeStart")
class NFA0_0_63388340_0 c1000;
end
class DFA0_1303046169 c1000;
subgraph DFA1_642929875["DFA1 {1}"]
NFA1_1_44325851_1[\"NFA1-1 char[1]
AcceptToken '+'"/]
class NFA1_1_44325851_1 c0101;
end
class DFA1_642929875 c0101;
subgraph DFA2_1083584447["DFA2 {1}"]
NFA2_1_33624151_2[\"NFA2-1 char[1]
AcceptToken 'a'"/]
class NFA2_1_33624151_2 c0101;
end
class DFA2_1083584447 c0101;
subgraph DFA3_924445311["DFA3 {1}"]
NFA3_1_34181910_3[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_34181910_3 c0101;
end
class DFA3_924445311 c0101;
DFA0_1303046169 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA1_642929875
DFA0_1303046169 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA2_1083584447
DFA0_1303046169 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_924445311
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
DFA0_1303046169{{"DFA0 wholeStart"}}
class DFA0_1303046169 c1000;
DFA1_642929875[\"DFA1 {1}
AcceptToken '+'"/]
class DFA1_642929875 c0101;
DFA2_1083584447[\"DFA2 {1}
AcceptToken 'a'"/]
class DFA2_1083584447 c0101;
DFA3_924445311[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_924445311 c0101;
DFA0_1303046169 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA1_642929875
DFA0_1303046169 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA2_1083584447
DFA0_1303046169 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_924445311
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
subgraph MiniDFA0_-1862349481["MiniDFA0 {1}"]
DFA0_1303046169_0{{"DFA0 wholeStart"}}
class DFA0_1303046169_0 c1000;
end
class MiniDFA0_-1862349481 c1000;
subgraph MiniDFA1_1915724728["MiniDFA1 {1}"]
DFA1_642929875_1[\"DFA1 {1}
AcceptToken '+'"/]
class DFA1_642929875_1 c0101;
end
class MiniDFA1_1915724728 c0101;
subgraph MiniDFA2_1654973960["MiniDFA2 {1}"]
DFA2_1083584447_2[\"DFA2 {1}
AcceptToken 'a'"/]
class DFA2_1083584447_2 c0101;
end
class MiniDFA2_1654973960 c0101;
subgraph MiniDFA3_2024588932["MiniDFA3 {1}"]
DFA3_924445311_3[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_924445311_3 c0101;
end
class MiniDFA3_2024588932 c0101;
MiniDFA0_-1862349481 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA1_1915724728
MiniDFA0_-1862349481 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA2_1654973960
MiniDFA0_-1862349481 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA3_2024588932
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
MiniDFA0_-1862349481(["MiniDFA0 {1}"])
class MiniDFA0_-1862349481 c1000;
MiniDFA1_1915724728[\"MiniDFA1 {1}
AcceptToken '+'"/]
class MiniDFA1_1915724728 c0101;
MiniDFA2_1654973960[\"MiniDFA2 {1}
AcceptToken 'a'"/]
class MiniDFA2_1654973960 c0101;
MiniDFA3_2024588932[\"MiniDFA3 {1}
AcceptToken 'b'"/]
class MiniDFA3_2024588932 c0101;
MiniDFA0_-1862349481 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA1_1915724728
MiniDFA0_-1862349481 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA2_1654973960
MiniDFA0_-1862349481 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA3_2024588932
```
-------------------------------
