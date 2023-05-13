# 'bvec4'

pattern: `bvec4`

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
eNFA88_10_30913391[["εNFA88-10 regex start"]]
eNFA88_0_9785067[["εNFA88-0 char{1, 1}"]]
eNFA88_1_20956739[["εNFA88-1 char[1]"]]
eNFA88_2_54392930[["εNFA88-2 char{1, 1}"]]
eNFA88_3_19774328[["εNFA88-3 char[1]"]]
eNFA88_4_43751230[["εNFA88-4 char{1, 1}"]]
eNFA88_5_58216758[["εNFA88-5 char[1]"]]
eNFA88_6_54188775[["εNFA88-6 char{1, 1}"]]
eNFA88_7_17936932[["εNFA88-7 char[1]"]]
eNFA88_8_27214660[["εNFA88-8 char{1, 1}"]]
eNFA88_9_43605354[["εNFA88-9 char[1]"]]
eNFA88_11_56903870[["εNFA88-11 regex end"]]
eNFA88_12_42372785[["εNFA88-12 post-regex start"]]
eNFA88_13_45810748[\"εNFA88-13 post-regex end"/]
eNFA88_10_30913391 -.->|"ε"|eNFA88_0_9785067
eNFA88_0_9785067 -->|"b"|eNFA88_1_20956739
eNFA88_1_20956739 -.->|"ε"|eNFA88_2_54392930
eNFA88_2_54392930 -->|"v"|eNFA88_3_19774328
eNFA88_3_19774328 -.->|"ε"|eNFA88_4_43751230
eNFA88_4_43751230 -->|"e"|eNFA88_5_58216758
eNFA88_5_58216758 -.->|"ε"|eNFA88_6_54188775
eNFA88_6_54188775 -->|"c"|eNFA88_7_17936932
eNFA88_7_17936932 -.->|"ε"|eNFA88_8_27214660
eNFA88_8_27214660 -->|"4"|eNFA88_9_43605354
eNFA88_9_43605354 -.->|"ε"|eNFA88_11_56903870
eNFA88_11_56903870 -.->|"ε"|eNFA88_12_42372785
eNFA88_12_42372785 -.->|"ε"|eNFA88_13_45810748
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
eNFA88_10_9643552[["εNFA88-10 regex start"]]
eNFA88_0_19683111[["εNFA88-0 char{1, 1}"]]
eNFA88_1_42930272[["εNFA88-1 char[1]"]]
eNFA88_2_50828134[["εNFA88-2 char{1, 1}"]]
eNFA88_3_54800025[["εNFA88-3 char[1]"]]
eNFA88_4_23438178[["εNFA88-4 char{1, 1}"]]
eNFA88_5_9617010[["εNFA88-5 char[1]"]]
eNFA88_6_19444226[["εNFA88-6 char{1, 1}"]]
eNFA88_7_40780307[["εNFA88-7 char[1]"]]
eNFA88_8_31478446[["εNFA88-8 char{1, 1}"]]
eNFA88_9_14870565[\"εNFA88-9 char[1]"/]
eNFA88_11_66726223[\"εNFA88-11 regex end"/]
eNFA88_12_63665103[\"εNFA88-12 post-regex start"/]
eNFA88_13_36115021[\"εNFA88-13 post-regex end"/]
eNFA88_10_9643552 -.->|"ε"|eNFA88_0_19683111
eNFA88_10_9643552 -->|"b"|eNFA88_1_42930272
eNFA88_0_19683111 -->|"b"|eNFA88_1_42930272
eNFA88_1_42930272 -.->|"ε"|eNFA88_2_50828134
eNFA88_1_42930272 -->|"v"|eNFA88_3_54800025
eNFA88_2_50828134 -->|"v"|eNFA88_3_54800025
eNFA88_3_54800025 -.->|"ε"|eNFA88_4_23438178
eNFA88_3_54800025 -->|"e"|eNFA88_5_9617010
eNFA88_4_23438178 -->|"e"|eNFA88_5_9617010
eNFA88_5_9617010 -.->|"ε"|eNFA88_6_19444226
eNFA88_5_9617010 -->|"c"|eNFA88_7_40780307
eNFA88_6_19444226 -->|"c"|eNFA88_7_40780307
eNFA88_7_40780307 -.->|"ε"|eNFA88_8_31478446
eNFA88_7_40780307 -->|"4"|eNFA88_9_14870565
eNFA88_8_31478446 -->|"4"|eNFA88_9_14870565
eNFA88_9_14870565 -.->|"ε"|eNFA88_11_66726223
eNFA88_9_14870565 -.->|"ε"|eNFA88_12_63665103
eNFA88_9_14870565 -.->|"ε"|eNFA88_13_36115021
eNFA88_11_66726223 -.->|"ε"|eNFA88_12_63665103
eNFA88_11_66726223 -.->|"ε"|eNFA88_13_36115021
eNFA88_12_63665103 -.->|"ε"|eNFA88_13_36115021
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
NFA88_10_56599738("NFA88-10 regex start")
NFA88_1_39635599("NFA88-1 char[1]")
NFA88_3_21176078("NFA88-3 char[1]")
NFA88_5_56366974("NFA88-5 char[1]")
NFA88_7_37540721("NFA88-7 char[1]")
NFA88_9_2322177[\"NFA88-9 char[1]"/]
NFA88_10_56599738 -->|"b"|NFA88_1_39635599
NFA88_1_39635599 -->|"v"|NFA88_3_21176078
NFA88_3_21176078 -->|"e"|NFA88_5_56366974
NFA88_5_56366974 -->|"c"|NFA88_7_37540721
NFA88_7_37540721 -->|"4"|NFA88_9_2322177
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
subgraph DFA0_-1714618593["DFA0 regex start"]
NFA88_10_56599738_0("NFA88-10 regex start")
end
subgraph DFA1_-1993290518["DFA1 {1}"]
NFA88_1_39635599_1("NFA88-1 char[1]")
end
subgraph DFA2_-1800939635["DFA2 {1}"]
NFA88_3_21176078_2("NFA88-3 char[1]")
end
subgraph DFA3_1701034782["DFA3 {1}"]
NFA88_5_56366974_3("NFA88-5 char[1]")
end
subgraph DFA4_-1470150081["DFA4 {1}"]
NFA88_7_37540721_4("NFA88-7 char[1]")
end
subgraph DFA5_-394056997["DFA5 {1}"]
NFA88_9_2322177_5[\"NFA88-9 char[1]"/]
end
DFA0_-1714618593 -->|"b"|DFA1_-1993290518
DFA1_-1993290518 -->|"v"|DFA2_-1800939635
DFA2_-1800939635 -->|"e"|DFA3_1701034782
DFA3_1701034782 -->|"c"|DFA4_-1470150081
DFA4_-1470150081 -->|"4"|DFA5_-394056997
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
DFA0_-1714618593{{"DFA0 regex start"}}
DFA1_-1993290518{{"DFA1 {1}"}}
DFA2_-1800939635{{"DFA2 {1}"}}
DFA3_1701034782{{"DFA3 {1}"}}
DFA4_-1470150081{{"DFA4 {1}"}}
DFA5_-394056997[\"DFA5 {1}"/]
DFA0_-1714618593 -->|"b"|DFA1_-1993290518
DFA1_-1993290518 -->|"v"|DFA2_-1800939635
DFA2_-1800939635 -->|"e"|DFA3_1701034782
DFA3_1701034782 -->|"c"|DFA4_-1470150081
DFA4_-1470150081 -->|"4"|DFA5_-394056997
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
subgraph MiniDFA0_-2018022587["MiniDFA0 {1}"]
DFA0_-1714618593_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1123572993["MiniDFA1 {1}"]
DFA1_-1993290518_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1964236925["MiniDFA2 {1}"]
DFA2_-1800939635_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1867695820["MiniDFA3 {1}"]
DFA3_1701034782_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_-1332356793["MiniDFA4 {1}"]
DFA4_-1470150081_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_1633729005["MiniDFA5 {1}"]
DFA5_-394056997_5[\"DFA5 {1}"/]
end
MiniDFA0_-2018022587 -->|"b"|MiniDFA1_1123572993
MiniDFA1_1123572993 -->|"v"|MiniDFA2_-1964236925
MiniDFA2_-1964236925 -->|"e"|MiniDFA3_-1867695820
MiniDFA3_-1867695820 -->|"c"|MiniDFA4_-1332356793
MiniDFA4_-1332356793 -->|"4"|MiniDFA5_1633729005
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
MiniDFA0_-2018022587(["MiniDFA0 {1}"])
MiniDFA1_1123572993(["MiniDFA1 {1}"])
MiniDFA2_-1964236925(["MiniDFA2 {1}"])
MiniDFA3_-1867695820(["MiniDFA3 {1}"])
MiniDFA4_-1332356793(["MiniDFA4 {1}"])
MiniDFA5_1633729005[\"MiniDFA5 {1}"/]
MiniDFA0_-2018022587 -->|"b"|MiniDFA1_1123572993
MiniDFA1_1123572993 -->|"v"|MiniDFA2_-1964236925
MiniDFA2_-1964236925 -->|"e"|MiniDFA3_-1867695820
MiniDFA3_-1867695820 -->|"c"|MiniDFA4_-1332356793
MiniDFA4_-1332356793 -->|"4"|MiniDFA5_1633729005
```
-------------------------------
