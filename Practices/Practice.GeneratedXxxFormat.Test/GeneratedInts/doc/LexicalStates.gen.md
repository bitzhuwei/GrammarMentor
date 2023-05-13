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
eNFA0_0_33651104[["εNFA0-0 wholeStart"]]
eNFA1_2_38617647[["εNFA1-2 regex start"]]
class eNFA1_2_38617647 c1000;
eNFA1_0_15389841[["εNFA1-0 scope{1, ∞}"]]
eNFA1_1_16623063[["εNFA1-1 scope[1]"]]
eNFA1_3_4290849[["εNFA1-3 regex end"]]
class eNFA1_3_4290849 c0100;
eNFA1_4_12014508[["εNFA1-4 post-regex start"]]
class eNFA1_4_12014508 c0010;
eNFA1_5_41021713[\"εNFA1-5 post-regex end"/]
class eNFA1_5_41021713 c0001;
eNFA0_1_63839968[\"εNFA0-1 wholeEnd"/]
eNFA0_0_33651104 -.->|"ε"|eNFA1_2_38617647
eNFA1_2_38617647 -.->|"ε
BeginToken 'integer'"|eNFA1_0_15389841
eNFA1_0_15389841 -->|"[0-9]"|eNFA1_1_16623063
eNFA1_1_16623063 -->|"[0-9]"|eNFA1_1_16623063
eNFA1_1_16623063 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_4290849
eNFA1_3_4290849 -.->|"ε"|eNFA1_4_12014508
eNFA1_4_12014508 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_41021713
eNFA1_5_41021713 -.->|"ε"|eNFA0_1_63839968
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
eNFA0_0_47183160[["εNFA0-0 wholeStart"]]
class eNFA0_0_47183160 c1000;
eNFA1_2_37688803[["εNFA1-2 regex start"]]
class eNFA1_2_37688803 c1000;
eNFA1_0_41384867[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_41384867 c1000;
eNFA1_1_34424480[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_34424480 c0111;
eNFA1_3_36919491[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_36919491 c0111;
eNFA1_4_3654909[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_3654909 c0011;
eNFA1_5_32894183[\"εNFA1-5 post-regex end"/]
class eNFA1_5_32894183 c0011;
eNFA0_1_27612194[\"εNFA0-1 wholeEnd"/]
eNFA0_0_47183160 -.->|"ε"|eNFA1_2_37688803
eNFA0_0_47183160 -.->|"ε
BeginToken 'integer'"|eNFA1_0_41384867
eNFA0_0_47183160 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_34424480
eNFA1_2_37688803 -.->|"ε
BeginToken 'integer'"|eNFA1_0_41384867
eNFA1_2_37688803 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_34424480
eNFA1_0_41384867 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_34424480
eNFA1_1_34424480 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_34424480
eNFA1_1_34424480 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_36919491
eNFA1_1_34424480 -.->|"ε"|eNFA1_4_3654909
eNFA1_1_34424480 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_32894183
eNFA1_1_34424480 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27612194
eNFA1_3_36919491 -.->|"ε"|eNFA1_4_3654909
eNFA1_3_36919491 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_32894183
eNFA1_3_36919491 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27612194
eNFA1_4_3654909 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_32894183
eNFA1_4_3654909 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27612194
eNFA1_5_32894183 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27612194
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
NFA0_0_63739581("NFA0-0 wholeStart")
class NFA0_0_63739581 c1000;
NFA1_1_21995256[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_21995256 c0101;
NFA0_0_63739581 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_21995256
NFA1_1_21995256 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_21995256
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
subgraph DFA0_774839393["DFA0 wholeStart"]
NFA0_0_63739581_0("NFA0-0 wholeStart")
class NFA0_0_63739581_0 c1000;
end
class DFA0_774839393 c1000;
subgraph DFA1_1542509584["DFA1 {1}"]
NFA1_1_21995256_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_21995256_1 c0101;
end
class DFA1_1542509584 c0101;
DFA0_774839393 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1542509584
DFA1_1542509584 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1542509584
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
DFA0_774839393{{"DFA0 wholeStart"}}
class DFA0_774839393 c1000;
DFA1_1542509584[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1542509584 c0101;
DFA0_774839393 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1542509584
DFA1_1542509584 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1542509584
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
subgraph MiniDFA0_-471964189["MiniDFA0 {1}"]
DFA0_774839393_0{{"DFA0 wholeStart"}}
class DFA0_774839393_0 c1000;
end
class MiniDFA0_-471964189 c1000;
subgraph MiniDFA1_-1553326227["MiniDFA1 {1}"]
DFA1_1542509584_1[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1542509584_1 c0101;
end
class MiniDFA1_-1553326227 c0101;
MiniDFA0_-471964189 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA1_-1553326227
MiniDFA1_-1553326227 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA1_-1553326227
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
MiniDFA0_-471964189(["MiniDFA0 {1}"])
class MiniDFA0_-471964189 c1000;
MiniDFA1_-1553326227[\"MiniDFA1 {1}
AcceptToken 'integer'"/]
class MiniDFA1_-1553326227 c0101;
MiniDFA0_-471964189 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA1_-1553326227
MiniDFA1_-1553326227 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA1_-1553326227
```
-------------------------------
