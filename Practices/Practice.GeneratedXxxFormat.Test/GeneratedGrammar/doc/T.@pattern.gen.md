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
eNFA3_16_55739962[["εNFA3-16 regex start"]]
eNFA3_0_31897614[["εNFA3-0 scope{2, 2}"]]
eNFA3_1_18643074[["εNFA3-1 scope[1]"]]
eNFA3_2_33569943[["εNFA3-2 scope[2]"]]
eNFA3_3_33694039[["εNFA3-3 scope{1, 1}"]]
eNFA3_4_6856533[["εNFA3-4 scope[1]"]]
eNFA3_7_2760661[["εNFA3-7 regex start"]]
eNFA3_5_22286970[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_24845951[["εNFA3-9 char{1, 1}"]]
eNFA3_8_66365008[["εNFA3-8 regex end"]]
eNFA3_6_18508278[["εNFA3-6 scope[1]"]]
eNFA3_10_22836471[["εNFA3-10 char[1]"]]
eNFA3_13_61708798[["εNFA3-13 scope{2, 2}"]]
eNFA3_11_43102718[["εNFA3-11 scope{1, 1}"]]
eNFA3_14_52380146[["εNFA3-14 scope[1]"]]
eNFA3_12_32882735[["εNFA3-12 scope[1]"]]
eNFA3_15_1659266[["εNFA3-15 scope[2]"]]
eNFA3_17_182887[["εNFA3-17 regex end"]]
eNFA3_18_1645989[["εNFA3-18 post-regex start"]]
eNFA3_19_14813909[\"εNFA3-19 post-regex end"/]
eNFA3_16_55739962 -.->|"ε"|eNFA3_0_31897614
eNFA3_0_31897614 -->|"[%]"|eNFA3_1_18643074
eNFA3_1_18643074 -->|"[%]"|eNFA3_2_33569943
eNFA3_2_33569943 -.->|"ε"|eNFA3_3_33694039
eNFA3_3_33694039 -->|"[#32;-~]"|eNFA3_4_6856533
eNFA3_4_6856533 -.->|"ε"|eNFA3_7_2760661
eNFA3_7_2760661 -.->|"ε"|eNFA3_5_22286970
eNFA3_7_2760661 -.->|"ε"|eNFA3_9_24845951
eNFA3_7_2760661 -.->|"ε"|eNFA3_8_66365008
eNFA3_5_22286970 -->|"[^%]"|eNFA3_6_18508278
eNFA3_9_24845951 -->|"%"|eNFA3_10_22836471
eNFA3_8_66365008 -.->|"ε"|eNFA3_7_2760661
eNFA3_8_66365008 -.->|"ε"|eNFA3_13_61708798
eNFA3_6_18508278 -.->|"ε"|eNFA3_8_66365008
eNFA3_10_22836471 -.->|"ε"|eNFA3_11_43102718
eNFA3_13_61708798 -->|"[%]"|eNFA3_14_52380146
eNFA3_11_43102718 -->|"[^%]"|eNFA3_12_32882735
eNFA3_14_52380146 -->|"[%]"|eNFA3_15_1659266
eNFA3_12_32882735 -.->|"ε"|eNFA3_8_66365008
eNFA3_15_1659266 -.->|"ε"|eNFA3_17_182887
eNFA3_17_182887 -.->|"ε"|eNFA3_18_1645989
eNFA3_18_1645989 -.->|"ε"|eNFA3_19_14813909
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
eNFA3_16_66216318[["εNFA3-16 regex start"]]
eNFA3_0_59075955[["εNFA3-0 scope{2, 2}"]]
eNFA3_1_3718125[["εNFA3-1 scope[1]"]]
eNFA3_2_61921547[["εNFA3-2 scope[2]"]]
eNFA3_3_20423017[["εNFA3-3 scope{1, 1}"]]
eNFA3_4_4201648[["εNFA3-4 scope[1]"]]
eNFA3_7_34810897[["εNFA3-7 regex start"]]
eNFA3_5_1110436[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_44862624[["εNFA3-9 char{1, 1}"]]
eNFA3_8_9993926[["εNFA3-8 regex end"]]
eNFA3_6_4789190[["εNFA3-6 scope[1]"]]
eNFA3_10_49589429[["εNFA3-10 char[1]"]]
eNFA3_13_37814834[["εNFA3-13 scope{2, 2}"]]
eNFA3_14_33463128[["εNFA3-14 scope[1]"]]
eNFA3_11_43651680[["εNFA3-11 scope{1, 1}"]]
eNFA3_12_14933401[["εNFA3-12 scope[1]"]]
eNFA3_15_57320803[\"εNFA3-15 scope[2]"/]
eNFA3_17_46125183[\"εNFA3-17 regex end"/]
eNFA3_18_12473470[\"εNFA3-18 post-regex start"/]
eNFA3_19_45152367[\"εNFA3-19 post-regex end"/]
eNFA3_16_66216318 -.->|"ε"|eNFA3_0_59075955
eNFA3_16_66216318 -->|"[%]"|eNFA3_1_3718125
eNFA3_0_59075955 -->|"[%]"|eNFA3_1_3718125
eNFA3_1_3718125 -->|"[%]"|eNFA3_2_61921547
eNFA3_2_61921547 -.->|"ε"|eNFA3_3_20423017
eNFA3_2_61921547 -->|"[#32;-~]"|eNFA3_4_4201648
eNFA3_3_20423017 -->|"[#32;-~]"|eNFA3_4_4201648
eNFA3_4_4201648 -.->|"ε"|eNFA3_7_34810897
eNFA3_4_4201648 -.->|"ε"|eNFA3_5_1110436
eNFA3_4_4201648 -.->|"ε"|eNFA3_9_44862624
eNFA3_4_4201648 -.->|"ε"|eNFA3_8_9993926
eNFA3_4_4201648 -->|"[^%]"|eNFA3_6_4789190
eNFA3_4_4201648 -->|"%"|eNFA3_10_49589429
eNFA3_4_4201648 -.->|"ε"|eNFA3_13_37814834
eNFA3_4_4201648 -->|"[%]"|eNFA3_14_33463128
eNFA3_7_34810897 -.->|"ε"|eNFA3_5_1110436
eNFA3_7_34810897 -.->|"ε"|eNFA3_9_44862624
eNFA3_7_34810897 -.->|"ε"|eNFA3_8_9993926
eNFA3_7_34810897 -->|"[^%]"|eNFA3_6_4789190
eNFA3_7_34810897 -->|"%"|eNFA3_10_49589429
eNFA3_7_34810897 -.->|"ε"|eNFA3_7_34810897
eNFA3_7_34810897 -.->|"ε"|eNFA3_13_37814834
eNFA3_7_34810897 -->|"[%]"|eNFA3_14_33463128
eNFA3_5_1110436 -->|"[^%]"|eNFA3_6_4789190
eNFA3_9_44862624 -->|"%"|eNFA3_10_49589429
eNFA3_8_9993926 -.->|"ε"|eNFA3_7_34810897
eNFA3_8_9993926 -.->|"ε"|eNFA3_13_37814834
eNFA3_8_9993926 -.->|"ε"|eNFA3_5_1110436
eNFA3_8_9993926 -.->|"ε"|eNFA3_9_44862624
eNFA3_8_9993926 -.->|"ε"|eNFA3_8_9993926
eNFA3_8_9993926 -->|"[^%]"|eNFA3_6_4789190
eNFA3_8_9993926 -->|"%"|eNFA3_10_49589429
eNFA3_8_9993926 -->|"[%]"|eNFA3_14_33463128
eNFA3_6_4789190 -.->|"ε"|eNFA3_8_9993926
eNFA3_6_4789190 -.->|"ε"|eNFA3_7_34810897
eNFA3_6_4789190 -.->|"ε"|eNFA3_13_37814834
eNFA3_6_4789190 -.->|"ε"|eNFA3_5_1110436
eNFA3_6_4789190 -.->|"ε"|eNFA3_9_44862624
eNFA3_6_4789190 -->|"[^%]"|eNFA3_6_4789190
eNFA3_6_4789190 -->|"%"|eNFA3_10_49589429
eNFA3_6_4789190 -->|"[%]"|eNFA3_14_33463128
eNFA3_10_49589429 -.->|"ε"|eNFA3_11_43651680
eNFA3_10_49589429 -->|"[^%]"|eNFA3_12_14933401
eNFA3_13_37814834 -->|"[%]"|eNFA3_14_33463128
eNFA3_14_33463128 -->|"[%]"|eNFA3_15_57320803
eNFA3_11_43651680 -->|"[^%]"|eNFA3_12_14933401
eNFA3_12_14933401 -.->|"ε"|eNFA3_8_9993926
eNFA3_12_14933401 -.->|"ε"|eNFA3_7_34810897
eNFA3_12_14933401 -.->|"ε"|eNFA3_13_37814834
eNFA3_12_14933401 -.->|"ε"|eNFA3_5_1110436
eNFA3_12_14933401 -.->|"ε"|eNFA3_9_44862624
eNFA3_12_14933401 -->|"[^%]"|eNFA3_6_4789190
eNFA3_12_14933401 -->|"%"|eNFA3_10_49589429
eNFA3_12_14933401 -->|"[%]"|eNFA3_14_33463128
eNFA3_15_57320803 -.->|"ε"|eNFA3_17_46125183
eNFA3_15_57320803 -.->|"ε"|eNFA3_18_12473470
eNFA3_15_57320803 -.->|"ε"|eNFA3_19_45152367
eNFA3_17_46125183 -.->|"ε"|eNFA3_18_12473470
eNFA3_17_46125183 -.->|"ε"|eNFA3_19_45152367
eNFA3_18_12473470 -.->|"ε"|eNFA3_19_45152367
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
NFA3_16_30633204("NFA3-16 regex start")
NFA3_1_7263382("NFA3-1 scope[1]")
NFA3_2_65370446("NFA3-2 scope[2]")
NFA3_4_32732697("NFA3-4 scope[1]")
NFA3_6_34102761("NFA3-6 scope[1]")
NFA3_10_26158817("NFA3-10 char[1]")
NFA3_14_38489394("NFA3-14 scope[1]")
NFA3_12_10860229("NFA3-12 scope[1]")
NFA3_15_51463108[\"NFA3-15 scope[2]"/]
NFA3_16_30633204 -->|"[%]"|NFA3_1_7263382
NFA3_1_7263382 -->|"[%]"|NFA3_2_65370446
NFA3_2_65370446 -->|"[#32;-~]"|NFA3_4_32732697
NFA3_4_32732697 -->|"[^%]"|NFA3_6_34102761
NFA3_4_32732697 -->|"%"|NFA3_10_26158817
NFA3_4_32732697 -->|"[%]"|NFA3_14_38489394
NFA3_6_34102761 -->|"[^%]"|NFA3_6_34102761
NFA3_6_34102761 -->|"%"|NFA3_10_26158817
NFA3_6_34102761 -->|"[%]"|NFA3_14_38489394
NFA3_10_26158817 -->|"[^%]"|NFA3_12_10860229
NFA3_14_38489394 -->|"[%]"|NFA3_15_51463108
NFA3_12_10860229 -->|"[^%]"|NFA3_6_34102761
NFA3_12_10860229 -->|"%"|NFA3_10_26158817
NFA3_12_10860229 -->|"[%]"|NFA3_14_38489394
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
subgraph DFA0_-1175382468["DFA0 regex start"]
NFA3_16_30633204_0("NFA3-16 regex start")
end
subgraph DFA1_-505745257["DFA1 {1}"]
NFA3_1_7263382_1("NFA3-1 scope[1]")
end
subgraph DFA2_1000280880["DFA2 {1}"]
NFA3_2_65370446_2("NFA3-2 scope[2]")
end
subgraph DFA3_-303096162["DFA3 {1}"]
NFA3_4_32732697_3("NFA3-4 scope[1]")
end
subgraph DFA4_-798901775["DFA4 {1}"]
NFA3_6_34102761_4("NFA3-6 scope[1]")
end
subgraph DFA5_164880022["DFA5 {2}"]
NFA3_10_26158817_5("NFA3-10 char[1]")
NFA3_14_38489394_6("NFA3-14 scope[1]")
end
subgraph DFA6_-231261627["DFA6 {1}"]
NFA3_12_10860229_7("NFA3-12 scope[1]")
end
subgraph DFA7_-361159416["DFA7 {1}"]
NFA3_15_51463108_8[\"NFA3-15 scope[2]"/]
end
DFA0_-1175382468 -->|"[%]"|DFA1_-505745257
DFA1_-505745257 -->|"[%]"|DFA2_1000280880
DFA2_1000280880 -->|"[#32;-~]"|DFA3_-303096162
DFA3_-303096162 -->|"[^%]"|DFA4_-798901775
DFA3_-303096162 -->|"%"|DFA5_164880022
DFA4_-798901775 -->|"[^%]"|DFA4_-798901775
DFA4_-798901775 -->|"%"|DFA5_164880022
DFA5_164880022 -->|"[^%]"|DFA6_-231261627
DFA5_164880022 -->|"[%]"|DFA7_-361159416
DFA6_-231261627 -->|"[^%]"|DFA4_-798901775
DFA6_-231261627 -->|"%"|DFA5_164880022
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
DFA0_-1175382468{{"DFA0 regex start"}}
DFA1_-505745257{{"DFA1 {1}"}}
DFA2_1000280880{{"DFA2 {1}"}}
DFA3_-303096162{{"DFA3 {1}"}}
DFA4_-798901775{{"DFA4 {1}"}}
DFA5_164880022{{"DFA5 {2}"}}
DFA6_-231261627{{"DFA6 {1}"}}
DFA7_-361159416[\"DFA7 {1}"/]
DFA0_-1175382468 -->|"[%]"|DFA1_-505745257
DFA1_-505745257 -->|"[%]"|DFA2_1000280880
DFA2_1000280880 -->|"[#32;-~]"|DFA3_-303096162
DFA3_-303096162 -->|"[^%]"|DFA4_-798901775
DFA3_-303096162 -->|"%"|DFA5_164880022
DFA4_-798901775 -->|"[^%]"|DFA4_-798901775
DFA4_-798901775 -->|"%"|DFA5_164880022
DFA5_164880022 -->|"[^%]"|DFA6_-231261627
DFA5_164880022 -->|"[%]"|DFA7_-361159416
DFA6_-231261627 -->|"[^%]"|DFA4_-798901775
DFA6_-231261627 -->|"%"|DFA5_164880022
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
subgraph MiniDFA0_135877489["MiniDFA0 {1}"]
DFA0_-1175382468_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_1222504663["MiniDFA1 {1}"]
DFA1_-505745257_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1067986510["MiniDFA2 {1}"]
DFA2_1000280880_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-625163522["MiniDFA3 {3}"]
DFA3_-303096162_3{{"DFA3 {1}"}}
DFA4_-798901775_4{{"DFA4 {1}"}}
DFA6_-231261627_5{{"DFA6 {1}"}}
end
subgraph MiniDFA4_-169386572["MiniDFA4 {1}"]
DFA5_164880022_6{{"DFA5 {2}"}}
end
subgraph MiniDFA5_-1067488674["MiniDFA5 {1}"]
DFA7_-361159416_7[\"DFA7 {1}"/]
end
MiniDFA0_135877489 -->|"[%]"|MiniDFA1_1222504663
MiniDFA1_1222504663 -->|"[%]"|MiniDFA2_-1067986510
MiniDFA2_-1067986510 -->|"[#32;-~]"|MiniDFA3_-625163522
MiniDFA3_-625163522 -->|"[^%]"|MiniDFA3_-625163522
MiniDFA3_-625163522 -->|"%"|MiniDFA4_-169386572
MiniDFA4_-169386572 -->|"[^%]"|MiniDFA3_-625163522
MiniDFA4_-169386572 -->|"[%]"|MiniDFA5_-1067488674
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
MiniDFA0_135877489(["MiniDFA0 {1}"])
MiniDFA1_1222504663(["MiniDFA1 {1}"])
MiniDFA2_-1067986510(["MiniDFA2 {1}"])
MiniDFA3_-625163522(["MiniDFA3 {3}"])
MiniDFA4_-169386572(["MiniDFA4 {1}"])
MiniDFA5_-1067488674[\"MiniDFA5 {1}"/]
MiniDFA0_135877489 -->|"[%]"|MiniDFA1_1222504663
MiniDFA1_1222504663 -->|"[%]"|MiniDFA2_-1067986510
MiniDFA2_-1067986510 -->|"[#32;-~]"|MiniDFA3_-625163522
MiniDFA3_-625163522 -->|"[^%]"|MiniDFA3_-625163522
MiniDFA3_-625163522 -->|"%"|MiniDFA4_-169386572
MiniDFA4_-169386572 -->|"[^%]"|MiniDFA3_-625163522
MiniDFA4_-169386572 -->|"[%]"|MiniDFA5_-1067488674
```
-------------------------------
