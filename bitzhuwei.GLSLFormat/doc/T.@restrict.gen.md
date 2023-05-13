# 'restrict'

pattern: `restrict`

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
eNFA70_16_26649649[["εNFA70-16 regex start"]]
eNFA70_0_38520254[["εNFA70-0 char{1, 1}"]]
eNFA70_1_11137969[["εNFA70-1 char[1]"]]
eNFA70_2_33132859[["εNFA70-2 char{1, 1}"]]
eNFA70_3_29760277[["εNFA70-3 char[1]"]]
eNFA70_4_66515904[["εNFA70-4 char{1, 1}"]]
eNFA70_5_61772230[["εNFA70-5 char[1]"]]
eNFA70_6_19079158[["εNFA70-6 char{1, 1}"]]
eNFA70_7_37494699[["εNFA70-7 char[1]"]]
eNFA70_8_1907972[["εNFA70-8 char{1, 1}"]]
eNFA70_9_17171756[["εNFA70-9 char[1]"]]
eNFA70_10_20328083[["εNFA70-10 char{1, 1}"]]
eNFA70_11_48735027[["εNFA70-11 char[1]"]]
eNFA70_12_35962059[["εNFA70-12 char{1, 1}"]]
eNFA70_13_55223077[["εNFA70-13 char[1]"]]
eNFA70_14_27245651[["εNFA70-14 char{1, 1}"]]
eNFA70_15_43884268[["εNFA70-15 char[1]"]]
eNFA70_17_59414099[["εNFA70-17 regex end"]]
eNFA70_18_64964848[["εNFA70-18 post-regex start"]]
eNFA70_19_47812724[\"εNFA70-19 post-regex end"/]
eNFA70_16_26649649 -.->|"ε"|eNFA70_0_38520254
eNFA70_0_38520254 -->|"r"|eNFA70_1_11137969
eNFA70_1_11137969 -.->|"ε"|eNFA70_2_33132859
eNFA70_2_33132859 -->|"e"|eNFA70_3_29760277
eNFA70_3_29760277 -.->|"ε"|eNFA70_4_66515904
eNFA70_4_66515904 -->|"s"|eNFA70_5_61772230
eNFA70_5_61772230 -.->|"ε"|eNFA70_6_19079158
eNFA70_6_19079158 -->|"t"|eNFA70_7_37494699
eNFA70_7_37494699 -.->|"ε"|eNFA70_8_1907972
eNFA70_8_1907972 -->|"r"|eNFA70_9_17171756
eNFA70_9_17171756 -.->|"ε"|eNFA70_10_20328083
eNFA70_10_20328083 -->|"i"|eNFA70_11_48735027
eNFA70_11_48735027 -.->|"ε"|eNFA70_12_35962059
eNFA70_12_35962059 -->|"c"|eNFA70_13_55223077
eNFA70_13_55223077 -.->|"ε"|eNFA70_14_27245651
eNFA70_14_27245651 -->|"t"|eNFA70_15_43884268
eNFA70_15_43884268 -.->|"ε"|eNFA70_17_59414099
eNFA70_17_59414099 -.->|"ε"|eNFA70_18_64964848
eNFA70_18_64964848 -.->|"ε"|eNFA70_19_47812724
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
eNFA70_16_27661336[["εNFA70-16 regex start"]]
eNFA70_0_47625437[["εNFA70-0 char{1, 1}"]]
eNFA70_1_25975757[["εNFA70-1 char[1]"]]
eNFA70_2_32455223[["εNFA70-2 char{1, 1}"]]
eNFA70_3_23661558[["εNFA70-3 char[1]"]]
eNFA70_4_11627434[["εNFA70-4 char{1, 1}"]]
eNFA70_5_37538044[["εNFA70-5 char[1]"]]
eNFA70_6_2298077[["εNFA70-6 char{1, 1}"]]
eNFA70_7_20682694[["εNFA70-7 char[1]"]]
eNFA70_8_51926520[["εNFA70-8 char{1, 1}"]]
eNFA70_9_64685500[["εNFA70-9 char[1]"]]
eNFA70_10_45298596[["εNFA70-10 char{1, 1}"]]
eNFA70_11_5034184[["εNFA70-11 char[1]"]]
eNFA70_12_45307656[["εNFA70-12 char{1, 1}"]]
eNFA70_13_5115727[["εNFA70-13 char[1]"]]
eNFA70_14_46041549[["εNFA70-14 char{1, 1}"]]
eNFA70_15_11720763[\"εNFA70-15 char[1]"/]
eNFA70_17_38378011[\"εNFA70-17 regex end"/]
eNFA70_18_9857780[\"εNFA70-18 post-regex start"/]
eNFA70_19_21611161[\"εNFA70-19 post-regex end"/]
eNFA70_16_27661336 -.->|"ε"|eNFA70_0_47625437
eNFA70_16_27661336 -->|"r"|eNFA70_1_25975757
eNFA70_0_47625437 -->|"r"|eNFA70_1_25975757
eNFA70_1_25975757 -.->|"ε"|eNFA70_2_32455223
eNFA70_1_25975757 -->|"e"|eNFA70_3_23661558
eNFA70_2_32455223 -->|"e"|eNFA70_3_23661558
eNFA70_3_23661558 -.->|"ε"|eNFA70_4_11627434
eNFA70_3_23661558 -->|"s"|eNFA70_5_37538044
eNFA70_4_11627434 -->|"s"|eNFA70_5_37538044
eNFA70_5_37538044 -.->|"ε"|eNFA70_6_2298077
eNFA70_5_37538044 -->|"t"|eNFA70_7_20682694
eNFA70_6_2298077 -->|"t"|eNFA70_7_20682694
eNFA70_7_20682694 -.->|"ε"|eNFA70_8_51926520
eNFA70_7_20682694 -->|"r"|eNFA70_9_64685500
eNFA70_8_51926520 -->|"r"|eNFA70_9_64685500
eNFA70_9_64685500 -.->|"ε"|eNFA70_10_45298596
eNFA70_9_64685500 -->|"i"|eNFA70_11_5034184
eNFA70_10_45298596 -->|"i"|eNFA70_11_5034184
eNFA70_11_5034184 -.->|"ε"|eNFA70_12_45307656
eNFA70_11_5034184 -->|"c"|eNFA70_13_5115727
eNFA70_12_45307656 -->|"c"|eNFA70_13_5115727
eNFA70_13_5115727 -.->|"ε"|eNFA70_14_46041549
eNFA70_13_5115727 -->|"t"|eNFA70_15_11720763
eNFA70_14_46041549 -->|"t"|eNFA70_15_11720763
eNFA70_15_11720763 -.->|"ε"|eNFA70_17_38378011
eNFA70_15_11720763 -.->|"ε"|eNFA70_18_9857780
eNFA70_15_11720763 -.->|"ε"|eNFA70_19_21611161
eNFA70_17_38378011 -.->|"ε"|eNFA70_18_9857780
eNFA70_17_38378011 -.->|"ε"|eNFA70_19_21611161
eNFA70_18_9857780 -.->|"ε"|eNFA70_19_21611161
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
NFA70_16_60282721("NFA70-16 regex start")
NFA70_1_5673583("NFA70-1 char[1]")
NFA70_3_51062251("NFA70-3 char[1]")
NFA70_5_56907078("NFA70-5 char[1]")
NFA70_7_42401657("NFA70-7 char[1]")
NFA70_9_46070597("NFA70-9 char[1]")
NFA70_11_11982196("NFA70-11 char[1]")
NFA70_13_40730901("NFA70-13 char[1]")
NFA70_15_31033795[\"NFA70-15 char[1]"/]
NFA70_16_60282721 -->|"r"|NFA70_1_5673583
NFA70_1_5673583 -->|"e"|NFA70_3_51062251
NFA70_3_51062251 -->|"s"|NFA70_5_56907078
NFA70_5_56907078 -->|"t"|NFA70_7_42401657
NFA70_7_42401657 -->|"r"|NFA70_9_46070597
NFA70_9_46070597 -->|"i"|NFA70_11_11982196
NFA70_11_11982196 -->|"c"|NFA70_13_40730901
NFA70_13_40730901 -->|"t"|NFA70_15_31033795
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
subgraph DFA0_-213390304["DFA0 regex start"]
NFA70_16_60282721_0("NFA70-16 regex start")
end
subgraph DFA1_874573348["DFA1 {1}"]
NFA70_1_5673583_1("NFA70-1 char[1]")
end
subgraph DFA2_-1108705310["DFA2 {1}"]
NFA70_3_51062251_2("NFA70-3 char[1]")
end
subgraph DFA3_-1471920376["DFA3 {1}"]
NFA70_5_56907078_3("NFA70-5 char[1]")
end
subgraph DFA4_1833050390["DFA4 {1}"]
NFA70_7_42401657_4("NFA70-7 char[1]")
end
subgraph DFA5_-1965311843["DFA5 {1}"]
NFA70_9_46070597_5("NFA70-9 char[1]")
end
subgraph DFA6_1071339858["DFA6 {1}"]
NFA70_11_11982196_6("NFA70-11 char[1]")
end
subgraph DFA7_-275326975["DFA7 {1}"]
NFA70_13_40730901_7("NFA70-13 char[1]")
end
subgraph DFA8_299666528["DFA8 {1}"]
NFA70_15_31033795_8[\"NFA70-15 char[1]"/]
end
DFA0_-213390304 -->|"r"|DFA1_874573348
DFA1_874573348 -->|"e"|DFA2_-1108705310
DFA2_-1108705310 -->|"s"|DFA3_-1471920376
DFA3_-1471920376 -->|"t"|DFA4_1833050390
DFA4_1833050390 -->|"r"|DFA5_-1965311843
DFA5_-1965311843 -->|"i"|DFA6_1071339858
DFA6_1071339858 -->|"c"|DFA7_-275326975
DFA7_-275326975 -->|"t"|DFA8_299666528
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
DFA0_-213390304{{"DFA0 regex start"}}
DFA1_874573348{{"DFA1 {1}"}}
DFA2_-1108705310{{"DFA2 {1}"}}
DFA3_-1471920376{{"DFA3 {1}"}}
DFA4_1833050390{{"DFA4 {1}"}}
DFA5_-1965311843{{"DFA5 {1}"}}
DFA6_1071339858{{"DFA6 {1}"}}
DFA7_-275326975{{"DFA7 {1}"}}
DFA8_299666528[\"DFA8 {1}"/]
DFA0_-213390304 -->|"r"|DFA1_874573348
DFA1_874573348 -->|"e"|DFA2_-1108705310
DFA2_-1108705310 -->|"s"|DFA3_-1471920376
DFA3_-1471920376 -->|"t"|DFA4_1833050390
DFA4_1833050390 -->|"r"|DFA5_-1965311843
DFA5_-1965311843 -->|"i"|DFA6_1071339858
DFA6_1071339858 -->|"c"|DFA7_-275326975
DFA7_-275326975 -->|"t"|DFA8_299666528
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
subgraph MiniDFA0_1724966005["MiniDFA0 {1}"]
DFA0_-213390304_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_258583945["MiniDFA2 {1}"]
DFA1_874573348_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_913683197["MiniDFA3 {1}"]
DFA2_-1108705310_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_-466927552["MiniDFA4 {1}"]
DFA3_-1471920376_3{{"DFA3 {1}"}}
end
subgraph MiniDFA1_-575346507["MiniDFA1 {1}"]
DFA4_1833050390_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_-1422385358["MiniDFA5 {1}"]
DFA5_-1965311843_5{{"DFA5 {1}"}}
end
subgraph MiniDFA6_464150222["MiniDFA6 {1}"]
DFA6_1071339858_6{{"DFA6 {1}"}}
end
subgraph MiniDFA7_1460269656["MiniDFA7 {1}"]
DFA7_-275326975_7{{"DFA7 {1}"}}
end
subgraph MiniDFA8_-87189486["MiniDFA8 {1}"]
DFA8_299666528_8[\"DFA8 {1}"/]
end
MiniDFA0_1724966005 -->|"r"|MiniDFA2_258583945
MiniDFA2_258583945 -->|"e"|MiniDFA3_913683197
MiniDFA3_913683197 -->|"s"|MiniDFA4_-466927552
MiniDFA4_-466927552 -->|"t"|MiniDFA1_-575346507
MiniDFA1_-575346507 -->|"r"|MiniDFA5_-1422385358
MiniDFA5_-1422385358 -->|"i"|MiniDFA6_464150222
MiniDFA6_464150222 -->|"c"|MiniDFA7_1460269656
MiniDFA7_1460269656 -->|"t"|MiniDFA8_-87189486
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
MiniDFA0_1724966005(["MiniDFA0 {1}"])
MiniDFA2_258583945(["MiniDFA2 {1}"])
MiniDFA3_913683197(["MiniDFA3 {1}"])
MiniDFA4_-466927552(["MiniDFA4 {1}"])
MiniDFA1_-575346507(["MiniDFA1 {1}"])
MiniDFA5_-1422385358(["MiniDFA5 {1}"])
MiniDFA6_464150222(["MiniDFA6 {1}"])
MiniDFA7_1460269656(["MiniDFA7 {1}"])
MiniDFA8_-87189486[\"MiniDFA8 {1}"/]
MiniDFA0_1724966005 -->|"r"|MiniDFA2_258583945
MiniDFA2_258583945 -->|"e"|MiniDFA3_913683197
MiniDFA3_913683197 -->|"s"|MiniDFA4_-466927552
MiniDFA4_-466927552 -->|"t"|MiniDFA1_-575346507
MiniDFA1_-575346507 -->|"r"|MiniDFA5_-1422385358
MiniDFA5_-1422385358 -->|"i"|MiniDFA6_464150222
MiniDFA6_464150222 -->|"c"|MiniDFA7_1460269656
MiniDFA7_1460269656 -->|"t"|MiniDFA8_-87189486
```
-------------------------------
