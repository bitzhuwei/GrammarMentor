# 'inlineComment'

pattern: `\/\/.*`

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
eNFA5_5_2911240[["εNFA5-5 regex start"]]
eNFA5_0_26201168[["εNFA5-0 char{1, 1}"]]
eNFA5_1_34483920[["εNFA5-1 char[1]"]]
eNFA5_2_41919826[["εNFA5-2 char{1, 1}"]]
eNFA5_3_8715083[["εNFA5-3 char[1]"]]
eNFA5_4_8424883[["εNFA5-4 char{0, ∞}"]]
eNFA5_6_11326888[["εNFA5-6 regex end"]]
eNFA5_7_23858237[["εNFA5-7 post-regex start"]]
eNFA5_8_13397545[\"εNFA5-8 post-regex end"/]
eNFA5_5_2911240 -.->|"ε"|eNFA5_0_26201168
eNFA5_0_26201168 -->|"/"|eNFA5_1_34483920
eNFA5_1_34483920 -.->|"ε"|eNFA5_2_41919826
eNFA5_2_41919826 -->|"/"|eNFA5_3_8715083
eNFA5_3_8715083 -.->|"ε"|eNFA5_4_8424883
eNFA5_4_8424883 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_8424883
eNFA5_4_8424883 -.->|"ε"|eNFA5_6_11326888
eNFA5_6_11326888 -.->|"ε"|eNFA5_7_23858237
eNFA5_7_23858237 -.->|"ε"|eNFA5_8_13397545
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
eNFA5_5_53469045[["εNFA5-5 regex start"]]
eNFA5_0_11459362[["εNFA5-0 char{1, 1}"]]
eNFA5_1_36025402[["εNFA5-1 char[1]"]]
eNFA5_2_55793164[["εNFA5-2 char{1, 1}"]]
eNFA5_3_40062761[\"εNFA5-3 char[1]"/]
eNFA5_4_41734120[\"εNFA5-4 char{0, ∞}"/]
eNFA5_6_25020536[\"εNFA5-6 regex end"/]
eNFA5_7_32376435[\"εNFA5-7 post-regex start"/]
eNFA5_8_22952463[\"εNFA5-8 post-regex end"/]
eNFA5_5_53469045 -.->|"ε"|eNFA5_0_11459362
eNFA5_5_53469045 -->|"/"|eNFA5_1_36025402
eNFA5_0_11459362 -->|"/"|eNFA5_1_36025402
eNFA5_1_36025402 -.->|"ε"|eNFA5_2_55793164
eNFA5_1_36025402 -->|"/"|eNFA5_3_40062761
eNFA5_2_55793164 -->|"/"|eNFA5_3_40062761
eNFA5_3_40062761 -.->|"ε"|eNFA5_4_41734120
eNFA5_3_40062761 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_41734120
eNFA5_3_40062761 -.->|"ε"|eNFA5_6_25020536
eNFA5_3_40062761 -.->|"ε"|eNFA5_7_32376435
eNFA5_3_40062761 -.->|"ε"|eNFA5_8_22952463
eNFA5_4_41734120 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_41734120
eNFA5_4_41734120 -.->|"ε"|eNFA5_6_25020536
eNFA5_4_41734120 -.->|"ε"|eNFA5_7_32376435
eNFA5_4_41734120 -.->|"ε"|eNFA5_8_22952463
eNFA5_6_25020536 -.->|"ε"|eNFA5_7_32376435
eNFA5_6_25020536 -.->|"ε"|eNFA5_8_22952463
eNFA5_7_32376435 -.->|"ε"|eNFA5_8_22952463
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
NFA5_5_22238563("NFA5-5 regex start")
NFA5_1_65929341("NFA5-1 char[1]")
NFA5_3_47210194[\"NFA5-3 char[1]"/]
NFA5_4_5245577[\"NFA5-4 char{0, ∞}"/]
NFA5_5_22238563 -->|"/"|NFA5_1_65929341
NFA5_1_65929341 -->|"/"|NFA5_3_47210194
NFA5_3_47210194 -->|"[#92;t#92;r#32;-~]"|NFA5_4_5245577
NFA5_4_5245577 -->|"[#92;t#92;r#32;-~]"|NFA5_4_5245577
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
subgraph DFA0_-562537813["DFA0 regex start"]
NFA5_5_22238563_0("NFA5-5 regex start")
end
subgraph DFA1_1393246361["DFA1 {1}"]
NFA5_1_65929341_1("NFA5-1 char[1]")
end
subgraph DFA2_-516419379["DFA2 {1}"]
NFA5_3_47210194_2[\"NFA5-3 char[1]"/]
end
subgraph DFA3_900763289["DFA3 {1}"]
NFA5_4_5245577_3[\"NFA5-4 char{0, ∞}"/]
end
DFA0_-562537813 -->|"/"|DFA1_1393246361
DFA1_1393246361 -->|"/"|DFA2_-516419379
DFA2_-516419379 -->|"[#92;t#92;r#32;-~]"|DFA3_900763289
DFA3_900763289 -->|"[#92;t#92;r#32;-~]"|DFA3_900763289
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
DFA0_-562537813{{"DFA0 regex start"}}
DFA1_1393246361{{"DFA1 {1}"}}
DFA2_-516419379[\"DFA2 {1}"/]
DFA3_900763289[\"DFA3 {1}"/]
DFA0_-562537813 -->|"/"|DFA1_1393246361
DFA1_1393246361 -->|"/"|DFA2_-516419379
DFA2_-516419379 -->|"[#92;t#92;r#32;-~]"|DFA3_900763289
DFA3_900763289 -->|"[#92;t#92;r#32;-~]"|DFA3_900763289
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
subgraph MiniDFA0_586225822["MiniDFA0 {1}"]
DFA0_-562537813_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-798073864["MiniDFA1 {1}"]
DFA1_1393246361_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-617387128["MiniDFA2 {1}"]
DFA2_-516419379_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_628916632["MiniDFA3 {1}"]
DFA3_900763289_3[\"DFA3 {1}"/]
end
MiniDFA0_586225822 -->|"/"|MiniDFA1_-798073864
MiniDFA1_-798073864 -->|"/"|MiniDFA2_-617387128
MiniDFA2_-617387128 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_628916632
MiniDFA3_628916632 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_628916632
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
MiniDFA0_586225822(["MiniDFA0 {1}"])
MiniDFA1_-798073864(["MiniDFA1 {1}"])
MiniDFA2_-617387128[\"MiniDFA2 {1}"/]
MiniDFA3_628916632[\"MiniDFA3 {1}"/]
MiniDFA0_586225822 -->|"/"|MiniDFA1_-798073864
MiniDFA1_-798073864 -->|"/"|MiniDFA2_-617387128
MiniDFA2_-617387128 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_628916632
MiniDFA3_628916632 -->|"[#92;t#92;r#32;-~]"|MiniDFA3_628916632
```
-------------------------------
