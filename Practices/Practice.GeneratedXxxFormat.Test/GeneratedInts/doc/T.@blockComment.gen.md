# 'blockComment'

pattern: `\/\*([^*]|[*][^\/])*\*\/`

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
eNFA2_16_47188597[["εNFA2-16 regex start"]]
eNFA2_0_22044193[["εNFA2-0 char{1, 1}"]]
eNFA2_1_64180012[["εNFA2-1 char[1]"]]
eNFA2_2_40749199[["εNFA2-2 char{1, 1}"]]
eNFA2_3_52991666[["εNFA2-3 char[1]"]]
eNFA2_6_7793840[["εNFA2-6 regex start"]]
eNFA2_4_27321283[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_3035698[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_44564956[["εNFA2-7 regex end"]]
eNFA2_5_64466590[["εNFA2-5 scope[1]"]]
eNFA2_9_11164516[["εNFA2-9 scope[1]"]]
eNFA2_12_7162954[["εNFA2-12 char{1, 1}"]]
eNFA2_10_34619582[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_43140785[["εNFA2-13 char[1]"]]
eNFA2_11_45236689[["εNFA2-11 scope[1]"]]
eNFA2_14_52722752[["εNFA2-14 char{1, 1}"]]
eNFA2_15_42684506[["εNFA2-15 char[1]"]]
eNFA2_17_48616240[["εNFA2-17 regex end"]]
eNFA2_18_34892981[["εNFA2-18 post-regex start"]]
eNFA2_19_45601378[\"εNFA2-19 post-regex end"/]
eNFA2_16_47188597 -.->|"ε"|eNFA2_0_22044193
eNFA2_0_22044193 -->|"/"|eNFA2_1_64180012
eNFA2_1_64180012 -.->|"ε"|eNFA2_2_40749199
eNFA2_2_40749199 -->|"*"|eNFA2_3_52991666
eNFA2_3_52991666 -.->|"ε"|eNFA2_6_7793840
eNFA2_6_7793840 -.->|"ε"|eNFA2_4_27321283
eNFA2_6_7793840 -.->|"ε"|eNFA2_8_3035698
eNFA2_6_7793840 -.->|"ε"|eNFA2_7_44564956
eNFA2_4_27321283 -->|"[^*]"|eNFA2_5_64466590
eNFA2_8_3035698 -->|"[*]"|eNFA2_9_11164516
eNFA2_7_44564956 -.->|"ε"|eNFA2_6_7793840
eNFA2_7_44564956 -.->|"ε"|eNFA2_12_7162954
eNFA2_5_64466590 -.->|"ε"|eNFA2_7_44564956
eNFA2_9_11164516 -.->|"ε"|eNFA2_10_34619582
eNFA2_12_7162954 -->|"*"|eNFA2_13_43140785
eNFA2_10_34619582 -->|"[^/]"|eNFA2_11_45236689
eNFA2_13_43140785 -.->|"ε"|eNFA2_14_52722752
eNFA2_11_45236689 -.->|"ε"|eNFA2_7_44564956
eNFA2_14_52722752 -->|"/"|eNFA2_15_42684506
eNFA2_15_42684506 -.->|"ε"|eNFA2_17_48616240
eNFA2_17_48616240 -.->|"ε"|eNFA2_18_34892981
eNFA2_18_34892981 -.->|"ε"|eNFA2_19_45601378
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
eNFA2_16_7759225[["εNFA2-16 regex start"]]
eNFA2_0_2724161[["εNFA2-0 char{1, 1}"]]
eNFA2_1_24517452[["εNFA2-1 char[1]"]]
eNFA2_2_19330484[["εNFA2-2 char{1, 1}"]]
eNFA2_3_33371781[["εNFA2-3 char[1]"]]
eNFA2_6_31198475[["εNFA2-6 regex start"]]
eNFA2_4_44048571[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_12350826[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_60892825[["εNFA2-7 regex end"]]
eNFA2_5_18759701[["εNFA2-5 scope[1]"]]
eNFA2_9_39756633[["εNFA2-9 scope[1]"]]
eNFA2_12_31910573[["εNFA2-12 char{1, 1}"]]
eNFA2_13_66170694[["εNFA2-13 char[1]"]]
eNFA2_10_22265380[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_4742722[["εNFA2-11 scope[1]"]]
eNFA2_14_58665336[["εNFA2-14 char{1, 1}"]]
eNFA2_15_58225979[\"εNFA2-15 char[1]"/]
eNFA2_17_54271769[\"εNFA2-17 regex end"/]
eNFA2_18_18683873[\"εNFA2-18 post-regex start"/]
eNFA2_19_33937134[\"εNFA2-19 post-regex end"/]
eNFA2_16_7759225 -.->|"ε"|eNFA2_0_2724161
eNFA2_16_7759225 -->|"/"|eNFA2_1_24517452
eNFA2_0_2724161 -->|"/"|eNFA2_1_24517452
eNFA2_1_24517452 -.->|"ε"|eNFA2_2_19330484
eNFA2_1_24517452 -->|"*"|eNFA2_3_33371781
eNFA2_2_19330484 -->|"*"|eNFA2_3_33371781
eNFA2_3_33371781 -.->|"ε"|eNFA2_6_31198475
eNFA2_3_33371781 -.->|"ε"|eNFA2_4_44048571
eNFA2_3_33371781 -.->|"ε"|eNFA2_8_12350826
eNFA2_3_33371781 -.->|"ε"|eNFA2_7_60892825
eNFA2_3_33371781 -->|"[^*]"|eNFA2_5_18759701
eNFA2_3_33371781 -->|"[*]"|eNFA2_9_39756633
eNFA2_3_33371781 -.->|"ε"|eNFA2_12_31910573
eNFA2_3_33371781 -->|"*"|eNFA2_13_66170694
eNFA2_6_31198475 -.->|"ε"|eNFA2_4_44048571
eNFA2_6_31198475 -.->|"ε"|eNFA2_8_12350826
eNFA2_6_31198475 -.->|"ε"|eNFA2_7_60892825
eNFA2_6_31198475 -->|"[^*]"|eNFA2_5_18759701
eNFA2_6_31198475 -->|"[*]"|eNFA2_9_39756633
eNFA2_6_31198475 -.->|"ε"|eNFA2_6_31198475
eNFA2_6_31198475 -.->|"ε"|eNFA2_12_31910573
eNFA2_6_31198475 -->|"*"|eNFA2_13_66170694
eNFA2_4_44048571 -->|"[^*]"|eNFA2_5_18759701
eNFA2_8_12350826 -->|"[*]"|eNFA2_9_39756633
eNFA2_7_60892825 -.->|"ε"|eNFA2_6_31198475
eNFA2_7_60892825 -.->|"ε"|eNFA2_12_31910573
eNFA2_7_60892825 -.->|"ε"|eNFA2_4_44048571
eNFA2_7_60892825 -.->|"ε"|eNFA2_8_12350826
eNFA2_7_60892825 -.->|"ε"|eNFA2_7_60892825
eNFA2_7_60892825 -->|"[^*]"|eNFA2_5_18759701
eNFA2_7_60892825 -->|"[*]"|eNFA2_9_39756633
eNFA2_7_60892825 -->|"*"|eNFA2_13_66170694
eNFA2_5_18759701 -.->|"ε"|eNFA2_7_60892825
eNFA2_5_18759701 -.->|"ε"|eNFA2_6_31198475
eNFA2_5_18759701 -.->|"ε"|eNFA2_12_31910573
eNFA2_5_18759701 -.->|"ε"|eNFA2_4_44048571
eNFA2_5_18759701 -.->|"ε"|eNFA2_8_12350826
eNFA2_5_18759701 -->|"[^*]"|eNFA2_5_18759701
eNFA2_5_18759701 -->|"[*]"|eNFA2_9_39756633
eNFA2_5_18759701 -->|"*"|eNFA2_13_66170694
eNFA2_9_39756633 -.->|"ε"|eNFA2_10_22265380
eNFA2_9_39756633 -->|"[^/]"|eNFA2_11_4742722
eNFA2_12_31910573 -->|"*"|eNFA2_13_66170694
eNFA2_13_66170694 -.->|"ε"|eNFA2_14_58665336
eNFA2_13_66170694 -->|"/"|eNFA2_15_58225979
eNFA2_10_22265380 -->|"[^/]"|eNFA2_11_4742722
eNFA2_11_4742722 -.->|"ε"|eNFA2_7_60892825
eNFA2_11_4742722 -.->|"ε"|eNFA2_6_31198475
eNFA2_11_4742722 -.->|"ε"|eNFA2_12_31910573
eNFA2_11_4742722 -.->|"ε"|eNFA2_4_44048571
eNFA2_11_4742722 -.->|"ε"|eNFA2_8_12350826
eNFA2_11_4742722 -->|"[^*]"|eNFA2_5_18759701
eNFA2_11_4742722 -->|"[*]"|eNFA2_9_39756633
eNFA2_11_4742722 -->|"*"|eNFA2_13_66170694
eNFA2_14_58665336 -->|"/"|eNFA2_15_58225979
eNFA2_15_58225979 -.->|"ε"|eNFA2_17_54271769
eNFA2_15_58225979 -.->|"ε"|eNFA2_18_18683873
eNFA2_15_58225979 -.->|"ε"|eNFA2_19_33937134
eNFA2_17_54271769 -.->|"ε"|eNFA2_18_18683873
eNFA2_17_54271769 -.->|"ε"|eNFA2_19_33937134
eNFA2_18_18683873 -.->|"ε"|eNFA2_19_33937134
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
NFA2_16_10238520("NFA2-16 regex start")
NFA2_1_25037822("NFA2-1 char[1]")
NFA2_3_36998751("NFA2-3 char[1]")
NFA2_5_44108894("NFA2-5 scope[1]")
NFA2_9_64553311("NFA2-9 scope[1]")
NFA2_13_61435734("NFA2-13 char[1]")
NFA2_11_16050694("NFA2-11 scope[1]")
NFA2_15_24013807[\"NFA2-15 char[1]"/]
NFA2_16_10238520 -->|"/"|NFA2_1_25037822
NFA2_1_25037822 -->|"*"|NFA2_3_36998751
NFA2_3_36998751 -->|"[^*]"|NFA2_5_44108894
NFA2_3_36998751 -->|"[*]"|NFA2_9_64553311
NFA2_3_36998751 -->|"*"|NFA2_13_61435734
NFA2_5_44108894 -->|"[^*]"|NFA2_5_44108894
NFA2_5_44108894 -->|"[*]"|NFA2_9_64553311
NFA2_5_44108894 -->|"*"|NFA2_13_61435734
NFA2_9_64553311 -->|"[^/]"|NFA2_11_16050694
NFA2_13_61435734 -->|"/"|NFA2_15_24013807
NFA2_11_16050694 -->|"[^*]"|NFA2_5_44108894
NFA2_11_16050694 -->|"[*]"|NFA2_9_64553311
NFA2_11_16050694 -->|"*"|NFA2_13_61435734
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
subgraph DFA0_325949127["DFA0 regex start"]
NFA2_16_10238520_0("NFA2-16 regex start")
end
subgraph DFA1_-1816265523["DFA1 {1}"]
NFA2_1_25037822_1("NFA2-1 char[1]")
end
subgraph DFA2_1166191737["DFA2 {1}"]
NFA2_3_36998751_2("NFA2-3 char[1]")
end
subgraph DFA3_-342291627["DFA3 {1}"]
NFA2_5_44108894_3("NFA2-5 scope[1]")
end
subgraph DFA4_-665218375["DFA4 {2}"]
NFA2_9_64553311_4("NFA2-9 scope[1]")
NFA2_13_61435734_5("NFA2-13 char[1]")
end
subgraph DFA5_-824288994["DFA5 {1}"]
NFA2_11_16050694_6("NFA2-11 scope[1]")
end
subgraph DFA6_-2013149378["DFA6 {1}"]
NFA2_15_24013807_7[\"NFA2-15 char[1]"/]
end
DFA0_325949127 -->|"/"|DFA1_-1816265523
DFA1_-1816265523 -->|"*"|DFA2_1166191737
DFA2_1166191737 -->|"[^*]"|DFA3_-342291627
DFA2_1166191737 -->|"*"|DFA4_-665218375
DFA3_-342291627 -->|"[^*]"|DFA3_-342291627
DFA3_-342291627 -->|"*"|DFA4_-665218375
DFA4_-665218375 -->|"[^/]"|DFA5_-824288994
DFA4_-665218375 -->|"/"|DFA6_-2013149378
DFA5_-824288994 -->|"[^*]"|DFA3_-342291627
DFA5_-824288994 -->|"*"|DFA4_-665218375
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
DFA0_325949127{{"DFA0 regex start"}}
DFA1_-1816265523{{"DFA1 {1}"}}
DFA2_1166191737{{"DFA2 {1}"}}
DFA3_-342291627{{"DFA3 {1}"}}
DFA4_-665218375{{"DFA4 {2}"}}
DFA5_-824288994{{"DFA5 {1}"}}
DFA6_-2013149378[\"DFA6 {1}"/]
DFA0_325949127 -->|"/"|DFA1_-1816265523
DFA1_-1816265523 -->|"*"|DFA2_1166191737
DFA2_1166191737 -->|"[^*]"|DFA3_-342291627
DFA2_1166191737 -->|"*"|DFA4_-665218375
DFA3_-342291627 -->|"[^*]"|DFA3_-342291627
DFA3_-342291627 -->|"*"|DFA4_-665218375
DFA4_-665218375 -->|"[^/]"|DFA5_-824288994
DFA4_-665218375 -->|"/"|DFA6_-2013149378
DFA5_-824288994 -->|"[^*]"|DFA3_-342291627
DFA5_-824288994 -->|"*"|DFA4_-665218375
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
subgraph MiniDFA0_345973600["MiniDFA0 {1}"]
DFA0_325949127_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_645292023["MiniDFA1 {1}"]
DFA1_-1816265523_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-1411054640["MiniDFA2 {3}"]
DFA2_1166191737_2{{"DFA2 {1}"}}
DFA3_-342291627_3{{"DFA3 {1}"}}
DFA5_-824288994_4{{"DFA5 {1}"}}
end
subgraph MiniDFA3_1626263679["MiniDFA3 {1}"]
DFA4_-665218375_5{{"DFA4 {2}"}}
end
subgraph MiniDFA4_1634028076["MiniDFA4 {1}"]
DFA6_-2013149378_6[\"DFA6 {1}"/]
end
MiniDFA0_345973600 -->|"/"|MiniDFA1_645292023
MiniDFA1_645292023 -->|"*"|MiniDFA2_-1411054640
MiniDFA2_-1411054640 -->|"[^*]"|MiniDFA2_-1411054640
MiniDFA2_-1411054640 -->|"*"|MiniDFA3_1626263679
MiniDFA3_1626263679 -->|"[^/]"|MiniDFA2_-1411054640
MiniDFA3_1626263679 -->|"/"|MiniDFA4_1634028076
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
MiniDFA0_345973600(["MiniDFA0 {1}"])
MiniDFA1_645292023(["MiniDFA1 {1}"])
MiniDFA2_-1411054640(["MiniDFA2 {3}"])
MiniDFA3_1626263679(["MiniDFA3 {1}"])
MiniDFA4_1634028076[\"MiniDFA4 {1}"/]
MiniDFA0_345973600 -->|"/"|MiniDFA1_645292023
MiniDFA1_645292023 -->|"*"|MiniDFA2_-1411054640
MiniDFA2_-1411054640 -->|"[^*]"|MiniDFA2_-1411054640
MiniDFA2_-1411054640 -->|"*"|MiniDFA3_1626263679
MiniDFA3_1626263679 -->|"[^/]"|MiniDFA2_-1411054640
MiniDFA3_1626263679 -->|"/"|MiniDFA4_1634028076
```
-------------------------------
