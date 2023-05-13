# 'uimage2DRect'

pattern: `uimage2DRect`

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
eNFA171_24_22503266[["εNFA171-24 regex start"]]
eNFA171_0_1202807[["εNFA171-0 char{1, 1}"]]
eNFA171_1_10825264[["εNFA171-1 char[1]"]]
eNFA171_2_30318520[["εNFA171-2 char{1, 1}"]]
eNFA171_3_4431231[["εNFA171-3 char[1]"]]
eNFA171_4_39881087[["εNFA171-4 char{1, 1}"]]
eNFA171_5_23385463[["εNFA171-5 char[1]"]]
eNFA171_6_9142577[["εNFA171-6 char{1, 1}"]]
eNFA171_7_15174335[["εNFA171-7 char[1]"]]
eNFA171_8_2351288[["εNFA171-8 char{1, 1}"]]
eNFA171_9_21161599[["εNFA171-9 char[1]"]]
eNFA171_10_56236668[["εNFA171-10 char{1, 1}"]]
eNFA171_11_36367968[["εNFA171-11 char[1]"]]
eNFA171_12_58876260[["εNFA171-12 char{1, 1}"]]
eNFA171_13_60124297[["εNFA171-13 char[1]"]]
eNFA171_14_4247769[["εNFA171-14 char{1, 1}"]]
eNFA171_15_38229923[["εNFA171-15 char[1]"]]
eNFA171_16_8524994[["εNFA171-16 char{1, 1}"]]
eNFA171_17_9616086[["εNFA171-17 char[1]"]]
eNFA171_18_19435912[["εNFA171-18 char{1, 1}"]]
eNFA171_19_40705481[["εNFA171-19 char[1]"]]
eNFA171_20_30805010[["εNFA171-20 char{1, 1}"]]
eNFA171_21_8809636[["εNFA171-21 char[1]"]]
eNFA171_22_12177864[["εNFA171-22 char{1, 1}"]]
eNFA171_23_42491920[["εNFA171-23 char[1]"]]
eNFA171_25_46882964[["εNFA171-25 regex end"]]
eNFA171_26_19293492[["εNFA171-26 post-regex start"]]
eNFA171_27_39423707[\"εNFA171-27 post-regex end"/]
eNFA171_24_22503266 -.->|"ε"|eNFA171_0_1202807
eNFA171_0_1202807 -->|"u"|eNFA171_1_10825264
eNFA171_1_10825264 -.->|"ε"|eNFA171_2_30318520
eNFA171_2_30318520 -->|"i"|eNFA171_3_4431231
eNFA171_3_4431231 -.->|"ε"|eNFA171_4_39881087
eNFA171_4_39881087 -->|"m"|eNFA171_5_23385463
eNFA171_5_23385463 -.->|"ε"|eNFA171_6_9142577
eNFA171_6_9142577 -->|"a"|eNFA171_7_15174335
eNFA171_7_15174335 -.->|"ε"|eNFA171_8_2351288
eNFA171_8_2351288 -->|"g"|eNFA171_9_21161599
eNFA171_9_21161599 -.->|"ε"|eNFA171_10_56236668
eNFA171_10_56236668 -->|"e"|eNFA171_11_36367968
eNFA171_11_36367968 -.->|"ε"|eNFA171_12_58876260
eNFA171_12_58876260 -->|"2"|eNFA171_13_60124297
eNFA171_13_60124297 -.->|"ε"|eNFA171_14_4247769
eNFA171_14_4247769 -->|"D"|eNFA171_15_38229923
eNFA171_15_38229923 -.->|"ε"|eNFA171_16_8524994
eNFA171_16_8524994 -->|"R"|eNFA171_17_9616086
eNFA171_17_9616086 -.->|"ε"|eNFA171_18_19435912
eNFA171_18_19435912 -->|"e"|eNFA171_19_40705481
eNFA171_19_40705481 -.->|"ε"|eNFA171_20_30805010
eNFA171_20_30805010 -->|"c"|eNFA171_21_8809636
eNFA171_21_8809636 -.->|"ε"|eNFA171_22_12177864
eNFA171_22_12177864 -->|"t"|eNFA171_23_42491920
eNFA171_23_42491920 -.->|"ε"|eNFA171_25_46882964
eNFA171_25_46882964 -.->|"ε"|eNFA171_26_19293492
eNFA171_26_19293492 -.->|"ε"|eNFA171_27_39423707
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
eNFA171_24_19269049[["εNFA171-24 regex start"]]
eNFA171_0_39203719[["εNFA171-0 char{1, 1}"]]
eNFA171_1_17289159[["εNFA171-1 char[1]"]]
eNFA171_2_21384704[["εNFA171-2 char{1, 1}"]]
eNFA171_3_58244613[["εNFA171-3 char[1]"]]
eNFA171_4_54439469[["εNFA171-4 char{1, 1}"]]
eNFA171_5_20193179[["εNFA171-5 char[1]"]]
eNFA171_6_47520887[["εNFA171-6 char{1, 1}"]]
eNFA171_7_25034802[["εNFA171-7 char[1]"]]
eNFA171_8_23986629[["εNFA171-8 char{1, 1}"]]
eNFA171_9_14553073[["εNFA171-9 char[1]"]]
eNFA171_10_63868800[["εNFA171-10 char{1, 1}"]]
eNFA171_11_37948289[["εNFA171-11 char[1]"]]
eNFA171_12_5990287[["εNFA171-12 char{1, 1}"]]
eNFA171_13_53912586[["εNFA171-13 char[1]"]]
eNFA171_14_15451227[["εNFA171-14 char{1, 1}"]]
eNFA171_15_4843315[["εNFA171-15 char[1]"]]
eNFA171_16_43589835[["εNFA171-16 char{1, 1}"]]
eNFA171_17_56764196[["εNFA171-17 char[1]"]]
eNFA171_18_41115719[["εNFA171-18 char{1, 1}"]]
eNFA171_19_34497158[["εNFA171-19 char[1]"]]
eNFA171_20_42038968[["εNFA171-20 char{1, 1}"]]
eNFA171_21_42806400[["εNFA171-21 char[1]"]]
eNFA171_22_49713286[["εNFA171-22 char{1, 1}"]]
eNFA171_23_44766395[\"εNFA171-23 char[1]"/]
eNFA171_25_244376[\"εNFA171-25 regex end"/]
eNFA171_26_2199391[\"εNFA171-26 post-regex start"/]
eNFA171_27_19794519[\"εNFA171-27 post-regex end"/]
eNFA171_24_19269049 -.->|"ε"|eNFA171_0_39203719
eNFA171_24_19269049 -->|"u"|eNFA171_1_17289159
eNFA171_0_39203719 -->|"u"|eNFA171_1_17289159
eNFA171_1_17289159 -.->|"ε"|eNFA171_2_21384704
eNFA171_1_17289159 -->|"i"|eNFA171_3_58244613
eNFA171_2_21384704 -->|"i"|eNFA171_3_58244613
eNFA171_3_58244613 -.->|"ε"|eNFA171_4_54439469
eNFA171_3_58244613 -->|"m"|eNFA171_5_20193179
eNFA171_4_54439469 -->|"m"|eNFA171_5_20193179
eNFA171_5_20193179 -.->|"ε"|eNFA171_6_47520887
eNFA171_5_20193179 -->|"a"|eNFA171_7_25034802
eNFA171_6_47520887 -->|"a"|eNFA171_7_25034802
eNFA171_7_25034802 -.->|"ε"|eNFA171_8_23986629
eNFA171_7_25034802 -->|"g"|eNFA171_9_14553073
eNFA171_8_23986629 -->|"g"|eNFA171_9_14553073
eNFA171_9_14553073 -.->|"ε"|eNFA171_10_63868800
eNFA171_9_14553073 -->|"e"|eNFA171_11_37948289
eNFA171_10_63868800 -->|"e"|eNFA171_11_37948289
eNFA171_11_37948289 -.->|"ε"|eNFA171_12_5990287
eNFA171_11_37948289 -->|"2"|eNFA171_13_53912586
eNFA171_12_5990287 -->|"2"|eNFA171_13_53912586
eNFA171_13_53912586 -.->|"ε"|eNFA171_14_15451227
eNFA171_13_53912586 -->|"D"|eNFA171_15_4843315
eNFA171_14_15451227 -->|"D"|eNFA171_15_4843315
eNFA171_15_4843315 -.->|"ε"|eNFA171_16_43589835
eNFA171_15_4843315 -->|"R"|eNFA171_17_56764196
eNFA171_16_43589835 -->|"R"|eNFA171_17_56764196
eNFA171_17_56764196 -.->|"ε"|eNFA171_18_41115719
eNFA171_17_56764196 -->|"e"|eNFA171_19_34497158
eNFA171_18_41115719 -->|"e"|eNFA171_19_34497158
eNFA171_19_34497158 -.->|"ε"|eNFA171_20_42038968
eNFA171_19_34497158 -->|"c"|eNFA171_21_42806400
eNFA171_20_42038968 -->|"c"|eNFA171_21_42806400
eNFA171_21_42806400 -.->|"ε"|eNFA171_22_49713286
eNFA171_21_42806400 -->|"t"|eNFA171_23_44766395
eNFA171_22_49713286 -->|"t"|eNFA171_23_44766395
eNFA171_23_44766395 -.->|"ε"|eNFA171_25_244376
eNFA171_23_44766395 -.->|"ε"|eNFA171_26_2199391
eNFA171_23_44766395 -.->|"ε"|eNFA171_27_19794519
eNFA171_25_244376 -.->|"ε"|eNFA171_26_2199391
eNFA171_25_244376 -.->|"ε"|eNFA171_27_19794519
eNFA171_26_2199391 -.->|"ε"|eNFA171_27_19794519
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
NFA171_24_43932946("NFA171-24 regex start")
NFA171_1_59852202("NFA171-1 char[1]")
NFA171_3_1798911("NFA171-3 char[1]")
NFA171_5_16190202("NFA171-5 char[1]")
NFA171_7_11494092("NFA171-7 char[1]")
NFA171_9_36337966("NFA171-9 char[1]")
NFA171_11_58606241("NFA171-11 char[1]")
NFA171_13_57694127("NFA171-13 char[1]")
NFA171_15_49485095("NFA171-15 char[1]")
NFA171_17_42712676("NFA171-17 char[1]")
NFA171_19_48869765("NFA171-19 char[1]")
NFA171_21_37174709("NFA171-21 char[1]")
NFA171_23_66136932[\"NFA171-23 char[1]"/]
NFA171_24_43932946 -->|"u"|NFA171_1_59852202
NFA171_1_59852202 -->|"i"|NFA171_3_1798911
NFA171_3_1798911 -->|"m"|NFA171_5_16190202
NFA171_5_16190202 -->|"a"|NFA171_7_11494092
NFA171_7_11494092 -->|"g"|NFA171_9_36337966
NFA171_9_36337966 -->|"e"|NFA171_11_58606241
NFA171_11_58606241 -->|"2"|NFA171_13_57694127
NFA171_13_57694127 -->|"D"|NFA171_15_49485095
NFA171_15_49485095 -->|"R"|NFA171_17_42712676
NFA171_17_42712676 -->|"e"|NFA171_19_48869765
NFA171_19_48869765 -->|"c"|NFA171_21_37174709
NFA171_21_37174709 -->|"t"|NFA171_23_66136932
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
subgraph DFA0_1775339840["DFA0 regex start"]
NFA171_24_43932946_0("NFA171-24 regex start")
end
subgraph DFA1_-1348511558["DFA1 {1}"]
NFA171_1_59852202_1("NFA171-1 char[1]")
end
subgraph DFA2_868408461["DFA2 {1}"]
NFA171_3_1798911_2("NFA171-3 char[1]")
end
subgraph DFA3_-1585679817["DFA3 {1}"]
NFA171_5_16190202_3("NFA171-5 char[1]")
end
subgraph DFA4_227673917["DFA4 {1}"]
NFA171_7_11494092_4("NFA171-7 char[1]")
end
subgraph DFA5_39314680["DFA5 {1}"]
NFA171_9_36337966_5("NFA171-9 char[1]")
end
subgraph DFA6_-1771102478["DFA6 {1}"]
NFA171_11_58606241_6("NFA171-11 char[1]")
end
subgraph DFA7_-708871["DFA7 {1}"]
NFA171_13_57694127_7("NFA171-13 char[1]")
end
subgraph DFA8_1514778946["DFA8 {1}"]
NFA171_15_49485095_8("NFA171-15 char[1]")
end
subgraph DFA9_-40923433["DFA9 {1}"]
NFA171_17_42712676_9("NFA171-17 char[1]")
end
subgraph DFA10_-1949538373["DFA10 {1}"]
NFA171_19_48869765_10("NFA171-19 char[1]")
end
subgraph DFA11_-1637075226["DFA11 {1}"]
NFA171_21_37174709_11("NFA171-21 char[1]")
end
subgraph DFA12_-1040338036["DFA12 {1}"]
NFA171_23_66136932_12[\"NFA171-23 char[1]"/]
end
DFA0_1775339840 -->|"u"|DFA1_-1348511558
DFA1_-1348511558 -->|"i"|DFA2_868408461
DFA2_868408461 -->|"m"|DFA3_-1585679817
DFA3_-1585679817 -->|"a"|DFA4_227673917
DFA4_227673917 -->|"g"|DFA5_39314680
DFA5_39314680 -->|"e"|DFA6_-1771102478
DFA6_-1771102478 -->|"2"|DFA7_-708871
DFA7_-708871 -->|"D"|DFA8_1514778946
DFA8_1514778946 -->|"R"|DFA9_-40923433
DFA9_-40923433 -->|"e"|DFA10_-1949538373
DFA10_-1949538373 -->|"c"|DFA11_-1637075226
DFA11_-1637075226 -->|"t"|DFA12_-1040338036
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
DFA0_1775339840{{"DFA0 regex start"}}
DFA1_-1348511558{{"DFA1 {1}"}}
DFA2_868408461{{"DFA2 {1}"}}
DFA3_-1585679817{{"DFA3 {1}"}}
DFA4_227673917{{"DFA4 {1}"}}
DFA5_39314680{{"DFA5 {1}"}}
DFA6_-1771102478{{"DFA6 {1}"}}
DFA7_-708871{{"DFA7 {1}"}}
DFA8_1514778946{{"DFA8 {1}"}}
DFA9_-40923433{{"DFA9 {1}"}}
DFA10_-1949538373{{"DFA10 {1}"}}
DFA11_-1637075226{{"DFA11 {1}"}}
DFA12_-1040338036[\"DFA12 {1}"/]
DFA0_1775339840 -->|"u"|DFA1_-1348511558
DFA1_-1348511558 -->|"i"|DFA2_868408461
DFA2_868408461 -->|"m"|DFA3_-1585679817
DFA3_-1585679817 -->|"a"|DFA4_227673917
DFA4_227673917 -->|"g"|DFA5_39314680
DFA5_39314680 -->|"e"|DFA6_-1771102478
DFA6_-1771102478 -->|"2"|DFA7_-708871
DFA7_-708871 -->|"D"|DFA8_1514778946
DFA8_1514778946 -->|"R"|DFA9_-40923433
DFA9_-40923433 -->|"e"|DFA10_-1949538373
DFA10_-1949538373 -->|"c"|DFA11_-1637075226
DFA11_-1637075226 -->|"t"|DFA12_-1040338036
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
subgraph MiniDFA0_2075351135["MiniDFA0 {1}"]
DFA0_1775339840_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-707028562["MiniDFA1 {1}"]
DFA1_-1348511558_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1757033718["MiniDFA2 {1}"]
DFA2_868408461_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_403696526["MiniDFA3 {1}"]
DFA3_-1585679817_3{{"DFA3 {1}"}}
end
subgraph MiniDFA4_1560633898["MiniDFA4 {1}"]
DFA4_227673917_4{{"DFA4 {1}"}}
end
subgraph MiniDFA5_2122779450["MiniDFA5 {1}"]
DFA5_39314680_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_145291803["MiniDFA7 {1}"]
DFA6_-1771102478_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_1080770384["MiniDFA8 {1}"]
DFA7_-708871_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-16652534["MiniDFA9 {1}"]
DFA8_1514778946_8{{"DFA8 {1}"}}
end
subgraph MiniDFA6_-1441109195["MiniDFA6 {1}"]
DFA9_-40923433_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_-276280930["MiniDFA10 {1}"]
DFA10_-1949538373_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-1631569616["MiniDFA11 {1}"]
DFA11_-1637075226_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_-1295292548["MiniDFA12 {1}"]
DFA12_-1040338036_12[\"DFA12 {1}"/]
end
MiniDFA0_2075351135 -->|"u"|MiniDFA1_-707028562
MiniDFA1_-707028562 -->|"i"|MiniDFA2_-1757033718
MiniDFA2_-1757033718 -->|"m"|MiniDFA3_403696526
MiniDFA3_403696526 -->|"a"|MiniDFA4_1560633898
MiniDFA4_1560633898 -->|"g"|MiniDFA5_2122779450
MiniDFA5_2122779450 -->|"e"|MiniDFA7_145291803
MiniDFA7_145291803 -->|"2"|MiniDFA8_1080770384
MiniDFA8_1080770384 -->|"D"|MiniDFA9_-16652534
MiniDFA9_-16652534 -->|"R"|MiniDFA6_-1441109195
MiniDFA6_-1441109195 -->|"e"|MiniDFA10_-276280930
MiniDFA10_-276280930 -->|"c"|MiniDFA11_-1631569616
MiniDFA11_-1631569616 -->|"t"|MiniDFA12_-1295292548
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
MiniDFA0_2075351135(["MiniDFA0 {1}"])
MiniDFA1_-707028562(["MiniDFA1 {1}"])
MiniDFA2_-1757033718(["MiniDFA2 {1}"])
MiniDFA3_403696526(["MiniDFA3 {1}"])
MiniDFA4_1560633898(["MiniDFA4 {1}"])
MiniDFA5_2122779450(["MiniDFA5 {1}"])
MiniDFA7_145291803(["MiniDFA7 {1}"])
MiniDFA8_1080770384(["MiniDFA8 {1}"])
MiniDFA9_-16652534(["MiniDFA9 {1}"])
MiniDFA6_-1441109195(["MiniDFA6 {1}"])
MiniDFA10_-276280930(["MiniDFA10 {1}"])
MiniDFA11_-1631569616(["MiniDFA11 {1}"])
MiniDFA12_-1295292548[\"MiniDFA12 {1}"/]
MiniDFA0_2075351135 -->|"u"|MiniDFA1_-707028562
MiniDFA1_-707028562 -->|"i"|MiniDFA2_-1757033718
MiniDFA2_-1757033718 -->|"m"|MiniDFA3_403696526
MiniDFA3_403696526 -->|"a"|MiniDFA4_1560633898
MiniDFA4_1560633898 -->|"g"|MiniDFA5_2122779450
MiniDFA5_2122779450 -->|"e"|MiniDFA7_145291803
MiniDFA7_145291803 -->|"2"|MiniDFA8_1080770384
MiniDFA8_1080770384 -->|"D"|MiniDFA9_-16652534
MiniDFA9_-16652534 -->|"R"|MiniDFA6_-1441109195
MiniDFA6_-1441109195 -->|"e"|MiniDFA10_-276280930
MiniDFA10_-276280930 -->|"c"|MiniDFA11_-1631569616
MiniDFA11_-1631569616 -->|"t"|MiniDFA12_-1295292548
```
-------------------------------
