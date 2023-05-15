# 'pattern'

pattern: `[%]{2}[ -~]([^%]|%[^%])*[%]{2}`

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
eNFA3_16_60344938[["εNFA3-16 regex start"]]
eNFA3_0_6233535[["εNFA3-0 scope{2, 2}"]]
eNFA3_1_56101816[["εNFA3-1 scope[1]"]]
eNFA3_2_35154304[["εNFA3-2 scope[2]"]]
eNFA3_3_47953287[["εNFA3-3 scope{1, 1}"]]
eNFA3_4_11722994[["εNFA3-4 scope[1]"]]
eNFA3_7_38788755[["εNFA3-7 regex start"]]
eNFA3_5_54881489[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_13554483[["εNFA3-9 char{1, 1}"]]
eNFA3_8_24171358[["εNFA3-8 regex end"]]
eNFA3_6_10038421[["εNFA3-6 scope[1]"]]
eNFA3_10_2289152[["εNFA3-10 char[1]"]]
eNFA3_13_38398082[["εNFA3-13 scope{2, 2}"]]
eNFA3_11_53855148[["εNFA3-11 scope{1, 1}"]]
eNFA3_14_14934289[["εNFA3-14 scope[1]"]]
eNFA3_12_28290863[["εNFA3-12 scope[1]"]]
eNFA3_15_190881[["εNFA3-15 scope[2]"]]
eNFA3_17_15461386[["εNFA3-17 regex end"]]
eNFA3_18_4934750[["εNFA3-18 post-regex start"]]
eNFA3_19_44412752[\"εNFA3-19 post-regex end"/]
eNFA3_16_60344938 -.->|"ε"|eNFA3_0_6233535
eNFA3_0_6233535 -->|"[%]"|eNFA3_1_56101816
eNFA3_1_56101816 -->|"[%]"|eNFA3_2_35154304
eNFA3_2_35154304 -.->|"ε"|eNFA3_3_47953287
eNFA3_3_47953287 -->|"[#32;-~]"|eNFA3_4_11722994
eNFA3_4_11722994 -.->|"ε"|eNFA3_7_38788755
eNFA3_7_38788755 -.->|"ε"|eNFA3_5_54881489
eNFA3_7_38788755 -.->|"ε"|eNFA3_9_13554483
eNFA3_7_38788755 -.->|"ε"|eNFA3_8_24171358
eNFA3_5_54881489 -->|"[^%]"|eNFA3_6_10038421
eNFA3_9_13554483 -->|"%"|eNFA3_10_2289152
eNFA3_8_24171358 -.->|"ε"|eNFA3_7_38788755
eNFA3_8_24171358 -.->|"ε"|eNFA3_13_38398082
eNFA3_6_10038421 -.->|"ε"|eNFA3_8_24171358
eNFA3_10_2289152 -.->|"ε"|eNFA3_11_53855148
eNFA3_13_38398082 -->|"[%]"|eNFA3_14_14934289
eNFA3_11_53855148 -->|"[^%]"|eNFA3_12_28290863
eNFA3_14_14934289 -->|"[%]"|eNFA3_15_190881
eNFA3_12_28290863 -.->|"ε"|eNFA3_8_24171358
eNFA3_15_190881 -.->|"ε"|eNFA3_17_15461386
eNFA3_17_15461386 -.->|"ε"|eNFA3_18_4934750
eNFA3_18_4934750 -.->|"ε"|eNFA3_19_44412752
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
eNFA3_16_64170449[["εNFA3-16 regex start"]]
eNFA3_0_40663130[["εNFA3-0 scope{2, 2}"]]
eNFA3_1_28932175[["εNFA3-1 scope[1]"]]
eNFA3_2_30423852[["εNFA3-2 scope[2]"]]
eNFA3_3_5379216[["εNFA3-3 scope{1, 1}"]]
eNFA3_4_20602375[["εNFA3-4 scope[1]"]]
eNFA3_7_28926407[["εNFA3-7 regex start"]]
eNFA3_5_61337593[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_59011071[["εNFA3-9 char{1, 1}"]]
eNFA3_8_15167431[["εNFA3-8 regex end"]]
eNFA3_6_58179688[["εNFA3-6 scope[1]"]]
eNFA3_10_48412952[["εNFA3-10 char[1]"]]
eNFA3_13_51203652[["εNFA3-13 scope{2, 2}"]]
eNFA3_14_59062984[["εNFA3-14 scope[1]"]]
eNFA3_11_33063388[["εNFA3-11 scope{1, 1}"]]
eNFA3_12_1717931[["εNFA3-12 scope[1]"]]
eNFA3_15_29135036[\"εNFA3-15 scope[2]"/]
eNFA3_17_60888739[\"εNFA3-17 regex end"/]
eNFA3_18_11127745[\"εNFA3-18 post-regex start"/]
eNFA3_19_33040847[\"εNFA3-19 post-regex end"/]
eNFA3_16_64170449 -.->|"ε"|eNFA3_0_40663130
eNFA3_16_64170449 -->|"[%]"|eNFA3_1_28932175
eNFA3_0_40663130 -->|"[%]"|eNFA3_1_28932175
eNFA3_1_28932175 -->|"[%]"|eNFA3_2_30423852
eNFA3_2_30423852 -.->|"ε"|eNFA3_3_5379216
eNFA3_2_30423852 -->|"[#32;-~]"|eNFA3_4_20602375
eNFA3_3_5379216 -->|"[#32;-~]"|eNFA3_4_20602375
eNFA3_4_20602375 -.->|"ε"|eNFA3_7_28926407
eNFA3_4_20602375 -.->|"ε"|eNFA3_5_61337593
eNFA3_4_20602375 -.->|"ε"|eNFA3_9_59011071
eNFA3_4_20602375 -.->|"ε"|eNFA3_8_15167431
eNFA3_4_20602375 -->|"[^%]"|eNFA3_6_58179688
eNFA3_4_20602375 -->|"%"|eNFA3_10_48412952
eNFA3_4_20602375 -.->|"ε"|eNFA3_13_51203652
eNFA3_4_20602375 -->|"[%]"|eNFA3_14_59062984
eNFA3_7_28926407 -.->|"ε"|eNFA3_5_61337593
eNFA3_7_28926407 -.->|"ε"|eNFA3_9_59011071
eNFA3_7_28926407 -.->|"ε"|eNFA3_8_15167431
eNFA3_7_28926407 -->|"[^%]"|eNFA3_6_58179688
eNFA3_7_28926407 -->|"%"|eNFA3_10_48412952
eNFA3_7_28926407 -.->|"ε"|eNFA3_7_28926407
eNFA3_7_28926407 -.->|"ε"|eNFA3_13_51203652
eNFA3_7_28926407 -->|"[%]"|eNFA3_14_59062984
eNFA3_5_61337593 -->|"[^%]"|eNFA3_6_58179688
eNFA3_9_59011071 -->|"%"|eNFA3_10_48412952
eNFA3_8_15167431 -.->|"ε"|eNFA3_7_28926407
eNFA3_8_15167431 -.->|"ε"|eNFA3_13_51203652
eNFA3_8_15167431 -.->|"ε"|eNFA3_5_61337593
eNFA3_8_15167431 -.->|"ε"|eNFA3_9_59011071
eNFA3_8_15167431 -.->|"ε"|eNFA3_8_15167431
eNFA3_8_15167431 -->|"[^%]"|eNFA3_6_58179688
eNFA3_8_15167431 -->|"%"|eNFA3_10_48412952
eNFA3_8_15167431 -->|"[%]"|eNFA3_14_59062984
eNFA3_6_58179688 -.->|"ε"|eNFA3_8_15167431
eNFA3_6_58179688 -.->|"ε"|eNFA3_7_28926407
eNFA3_6_58179688 -.->|"ε"|eNFA3_13_51203652
eNFA3_6_58179688 -.->|"ε"|eNFA3_5_61337593
eNFA3_6_58179688 -.->|"ε"|eNFA3_9_59011071
eNFA3_6_58179688 -->|"[^%]"|eNFA3_6_58179688
eNFA3_6_58179688 -->|"%"|eNFA3_10_48412952
eNFA3_6_58179688 -->|"[%]"|eNFA3_14_59062984
eNFA3_10_48412952 -.->|"ε"|eNFA3_11_33063388
eNFA3_10_48412952 -->|"[^%]"|eNFA3_12_1717931
eNFA3_13_51203652 -->|"[%]"|eNFA3_14_59062984
eNFA3_14_59062984 -->|"[%]"|eNFA3_15_29135036
eNFA3_11_33063388 -->|"[^%]"|eNFA3_12_1717931
eNFA3_12_1717931 -.->|"ε"|eNFA3_8_15167431
eNFA3_12_1717931 -.->|"ε"|eNFA3_7_28926407
eNFA3_12_1717931 -.->|"ε"|eNFA3_13_51203652
eNFA3_12_1717931 -.->|"ε"|eNFA3_5_61337593
eNFA3_12_1717931 -.->|"ε"|eNFA3_9_59011071
eNFA3_12_1717931 -->|"[^%]"|eNFA3_6_58179688
eNFA3_12_1717931 -->|"%"|eNFA3_10_48412952
eNFA3_12_1717931 -->|"[%]"|eNFA3_14_59062984
eNFA3_15_29135036 -.->|"ε"|eNFA3_17_60888739
eNFA3_15_29135036 -.->|"ε"|eNFA3_18_11127745
eNFA3_15_29135036 -.->|"ε"|eNFA3_19_33040847
eNFA3_17_60888739 -.->|"ε"|eNFA3_18_11127745
eNFA3_17_60888739 -.->|"ε"|eNFA3_19_33040847
eNFA3_18_11127745 -.->|"ε"|eNFA3_19_33040847
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
NFA3_16_65274381("NFA3-16 regex start")
NFA3_1_50598521("NFA3-1 scope[1]")
NFA3_2_52733512("NFA3-2 scope[2]")
NFA3_4_61804813("NFA3-4 scope[1]")
NFA3_6_40133923("NFA3-6 scope[1]")
NFA3_10_19372405("NFA3-10 char[1]")
NFA3_14_25660991("NFA3-14 scope[1]")
NFA3_12_29622330("NFA3-12 scope[1]")
NFA3_15_4839561[\"NFA3-15 scope[2]"/]
NFA3_16_65274381 -->|"[%]"|NFA3_1_50598521
NFA3_1_50598521 -->|"[%]"|NFA3_2_52733512
NFA3_2_52733512 -->|"[#32;-~]"|NFA3_4_61804813
NFA3_4_61804813 -->|"[^%]"|NFA3_6_40133923
NFA3_4_61804813 -->|"%"|NFA3_10_19372405
NFA3_4_61804813 -->|"[%]"|NFA3_14_25660991
NFA3_6_40133923 -->|"[^%]"|NFA3_6_40133923
NFA3_6_40133923 -->|"%"|NFA3_10_19372405
NFA3_6_40133923 -->|"[%]"|NFA3_14_25660991
NFA3_10_19372405 -->|"[^%]"|NFA3_12_29622330
NFA3_14_25660991 -->|"[%]"|NFA3_15_4839561
NFA3_12_29622330 -->|"[^%]"|NFA3_6_40133923
NFA3_12_29622330 -->|"%"|NFA3_10_19372405
NFA3_12_29622330 -->|"[%]"|NFA3_14_25660991
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
subgraph DFA0_-2140381830["DFA0 regex start"]
NFA3_16_65274381_0("NFA3-16 regex start")
end
subgraph DFA1_790476049["DFA1 {1}"]
NFA3_1_50598521_1("NFA3-1 scope[1]")
end
subgraph DFA2_1510743162["DFA2 {1}"]
NFA3_2_52733512_2("NFA3-2 scope[2]")
end
subgraph DFA3_1918653140["DFA3 {1}"]
NFA3_4_61804813_3("NFA3-4 scope[1]")
end
subgraph DFA4_-7609773["DFA4 {1}"]
NFA3_6_40133923_4("NFA3-6 scope[1]")
end
subgraph DFA5_-80016272["DFA5 {2}"]
NFA3_10_19372405_5("NFA3-10 char[1]")
NFA3_14_25660991_6("NFA3-14 scope[1]")
end
subgraph DFA6_1824253538["DFA6 {1}"]
NFA3_12_29622330_7("NFA3-12 scope[1]")
end
subgraph DFA7_961836274["DFA7 {1}"]
NFA3_15_4839561_8[\"NFA3-15 scope[2]"/]
end
DFA0_-2140381830 -->|"[%]"|DFA1_790476049
DFA1_790476049 -->|"[%]"|DFA2_1510743162
DFA2_1510743162 -->|"[#32;-~]"|DFA3_1918653140
DFA3_1918653140 -->|"[^%]"|DFA4_-7609773
DFA3_1918653140 -->|"%"|DFA5_-80016272
DFA4_-7609773 -->|"[^%]"|DFA4_-7609773
DFA4_-7609773 -->|"%"|DFA5_-80016272
DFA5_-80016272 -->|"[^%]"|DFA6_1824253538
DFA5_-80016272 -->|"[%]"|DFA7_961836274
DFA6_1824253538 -->|"[^%]"|DFA4_-7609773
DFA6_1824253538 -->|"%"|DFA5_-80016272
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
DFA0_-2140381830{{"DFA0 regex start"}}
DFA1_790476049{{"DFA1 {1}"}}
DFA2_1510743162{{"DFA2 {1}"}}
DFA3_1918653140{{"DFA3 {1}"}}
DFA4_-7609773{{"DFA4 {1}"}}
DFA5_-80016272{{"DFA5 {2}"}}
DFA6_1824253538{{"DFA6 {1}"}}
DFA7_961836274[\"DFA7 {1}"/]
DFA0_-2140381830 -->|"[%]"|DFA1_790476049
DFA1_790476049 -->|"[%]"|DFA2_1510743162
DFA2_1510743162 -->|"[#32;-~]"|DFA3_1918653140
DFA3_1918653140 -->|"[^%]"|DFA4_-7609773
DFA3_1918653140 -->|"%"|DFA5_-80016272
DFA4_-7609773 -->|"[^%]"|DFA4_-7609773
DFA4_-7609773 -->|"%"|DFA5_-80016272
DFA5_-80016272 -->|"[^%]"|DFA6_1824253538
DFA5_-80016272 -->|"[%]"|DFA7_961836274
DFA6_1824253538 -->|"[^%]"|DFA4_-7609773
DFA6_1824253538 -->|"%"|DFA5_-80016272
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
subgraph MiniDFA0_1825254114["MiniDFA0 {1}"]
DFA0_-2140381830_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1273252072["MiniDFA1 {1}"]
DFA1_790476049_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_1041398138["MiniDFA2 {1}"]
DFA2_1510743162_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-1429172368["MiniDFA3 {3}"]
DFA3_1918653140_3{{"DFA3 {1}"}}
DFA4_-7609773_4{{"DFA4 {1}"}}
DFA6_1824253538_5{{"DFA6 {1}"}}
end
subgraph MiniDFA4_-1276556399["MiniDFA4 {1}"]
DFA5_-80016272_6{{"DFA5 {2}"}}
end
subgraph MiniDFA5_1830885249["MiniDFA5 {1}"]
DFA7_961836274_7[\"DFA7 {1}"/]
end
MiniDFA0_1825254114 -->|"[%]"|MiniDFA1_1273252072
MiniDFA1_1273252072 -->|"[%]"|MiniDFA2_1041398138
MiniDFA2_1041398138 -->|"[#32;-~]"|MiniDFA3_-1429172368
MiniDFA3_-1429172368 -->|"[^%]"|MiniDFA3_-1429172368
MiniDFA3_-1429172368 -->|"%"|MiniDFA4_-1276556399
MiniDFA4_-1276556399 -->|"[^%]"|MiniDFA3_-1429172368
MiniDFA4_-1276556399 -->|"[%]"|MiniDFA5_1830885249
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
MiniDFA0_1825254114(["MiniDFA0 {1}"])
MiniDFA1_1273252072(["MiniDFA1 {1}"])
MiniDFA2_1041398138(["MiniDFA2 {1}"])
MiniDFA3_-1429172368(["MiniDFA3 {3}"])
MiniDFA4_-1276556399(["MiniDFA4 {1}"])
MiniDFA5_1830885249[\"MiniDFA5 {1}"/]
MiniDFA0_1825254114 -->|"[%]"|MiniDFA1_1273252072
MiniDFA1_1273252072 -->|"[%]"|MiniDFA2_1041398138
MiniDFA2_1041398138 -->|"[#32;-~]"|MiniDFA3_-1429172368
MiniDFA3_-1429172368 -->|"[^%]"|MiniDFA3_-1429172368
MiniDFA3_-1429172368 -->|"%"|MiniDFA4_-1276556399
MiniDFA4_-1276556399 -->|"[^%]"|MiniDFA3_-1429172368
MiniDFA4_-1276556399 -->|"[%]"|MiniDFA5_1830885249
```
-------------------------------
