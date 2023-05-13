# 'usamplerCube'

pattern: `usamplerCube`

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
eNFA143_24_21551128[["εNFA143-24 regex start"]]
eNFA143_0_59742432[["εNFA143-0 char{1, 1}"]]
eNFA143_1_810977[["εNFA143-1 char[1]"]]
eNFA143_2_7298798[["εNFA143-2 char{1, 1}"]]
eNFA143_3_65689182[["εNFA143-3 char[1]"]]
eNFA143_4_54331732[["εNFA143-4 char{1, 1}"]]
eNFA143_5_19223544[["εNFA143-5 char[1]"]]
eNFA143_6_38794171[["εNFA143-6 char{1, 1}"]]
eNFA143_7_13603222[["εNFA143-7 char[1]"]]
eNFA143_8_55320138[["εNFA143-8 char{1, 1}"]]
eNFA143_9_28119201[["εNFA143-9 char[1]"]]
eNFA143_10_51746218[["εNFA143-10 char{1, 1}"]]
eNFA143_11_63062784[["εNFA143-11 char[1]"]]
eNFA143_12_30694147[["εNFA143-12 char{1, 1}"]]
eNFA143_13_7811868[["εNFA143-13 char[1]"]]
eNFA143_14_3197948[["εNFA143-14 char{1, 1}"]]
eNFA143_15_28781532[["εNFA143-15 char[1]"]]
eNFA143_16_57707197[["εNFA143-16 char{1, 1}"]]
eNFA143_17_49602728[["εNFA143-17 char[1]"]]
eNFA143_18_43771375[["εNFA143-18 char{1, 1}"]]
eNFA143_19_58398057[["εNFA143-19 char[1]"]]
eNFA143_20_55820473[["εNFA143-20 char{1, 1}"]]
eNFA143_21_32622215[["εNFA143-21 char[1]"]]
eNFA143_22_25164484[["εNFA143-22 char{1, 1}"]]
eNFA143_23_25153769[["εNFA143-23 char[1]"]]
eNFA143_25_25057336[["εNFA143-25 regex end"]]
eNFA143_26_24189432[["εNFA143-26 post-regex start"]]
eNFA143_27_16378299[\"εNFA143-27 post-regex end"/]
eNFA143_24_21551128 -.->|"ε"|eNFA143_0_59742432
eNFA143_0_59742432 -->|"u"|eNFA143_1_810977
eNFA143_1_810977 -.->|"ε"|eNFA143_2_7298798
eNFA143_2_7298798 -->|"s"|eNFA143_3_65689182
eNFA143_3_65689182 -.->|"ε"|eNFA143_4_54331732
eNFA143_4_54331732 -->|"a"|eNFA143_5_19223544
eNFA143_5_19223544 -.->|"ε"|eNFA143_6_38794171
eNFA143_6_38794171 -->|"m"|eNFA143_7_13603222
eNFA143_7_13603222 -.->|"ε"|eNFA143_8_55320138
eNFA143_8_55320138 -->|"p"|eNFA143_9_28119201
eNFA143_9_28119201 -.->|"ε"|eNFA143_10_51746218
eNFA143_10_51746218 -->|"l"|eNFA143_11_63062784
eNFA143_11_63062784 -.->|"ε"|eNFA143_12_30694147
eNFA143_12_30694147 -->|"e"|eNFA143_13_7811868
eNFA143_13_7811868 -.->|"ε"|eNFA143_14_3197948
eNFA143_14_3197948 -->|"r"|eNFA143_15_28781532
eNFA143_15_28781532 -.->|"ε"|eNFA143_16_57707197
eNFA143_16_57707197 -->|"C"|eNFA143_17_49602728
eNFA143_17_49602728 -.->|"ε"|eNFA143_18_43771375
eNFA143_18_43771375 -->|"u"|eNFA143_19_58398057
eNFA143_19_58398057 -.->|"ε"|eNFA143_20_55820473
eNFA143_20_55820473 -->|"b"|eNFA143_21_32622215
eNFA143_21_32622215 -.->|"ε"|eNFA143_22_25164484
eNFA143_22_25164484 -->|"e"|eNFA143_23_25153769
eNFA143_23_25153769 -.->|"ε"|eNFA143_25_25057336
eNFA143_25_25057336 -.->|"ε"|eNFA143_26_24189432
eNFA143_26_24189432 -.->|"ε"|eNFA143_27_16378299
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
eNFA143_24_13186971[["εNFA143-24 regex start"]]
eNFA143_0_51573880[["εNFA143-0 char{1, 1}"]]
eNFA143_1_61511739[["εNFA143-1 char[1]"]]
eNFA143_2_16734741[["εNFA143-2 char{1, 1}"]]
eNFA143_3_16394943[["εNFA143-3 char[1]"]]
eNFA143_4_13336762[["εNFA143-4 char{1, 1}"]]
eNFA143_5_52922000[["εNFA143-5 char[1]"]]
eNFA143_6_6535952[["εNFA143-6 char{1, 1}"]]
eNFA143_7_58823573[["εNFA143-7 char[1]"]]
eNFA143_8_59650110[["εNFA143-8 char{1, 1}"]]
eNFA143_9_67088950[["εNFA143-9 char[1]"]]
eNFA143_10_66929645[["εNFA143-10 char{1, 1}"]]
eNFA143_11_65495901[["εNFA143-11 char[1]"]]
eNFA143_12_52592197[["εNFA143-12 char{1, 1}"]]
eNFA143_13_3567727[["εNFA143-13 char[1]"]]
eNFA143_14_32109549[["εNFA143-14 char{1, 1}"]]
eNFA143_15_20550486[["εNFA143-15 char[1]"]]
eNFA143_16_50736653[["εNFA143-16 char{1, 1}"]]
eNFA143_17_53976698[["εNFA143-17 char[1]"]]
eNFA143_18_16028238[["εNFA143-18 char{1, 1}"]]
eNFA143_19_10036418[["εNFA143-19 char[1]"]]
eNFA143_20_23218903[["εNFA143-20 char{1, 1}"]]
eNFA143_21_7643543[["εNFA143-21 char[1]"]]
eNFA143_22_1683025[["εNFA143-22 char{1, 1}"]]
eNFA143_23_15147232[\"εNFA143-23 char[1]"/]
eNFA143_25_2107364[\"εNFA143-25 regex end"/]
eNFA143_26_18966278[\"εNFA143-26 post-regex start"/]
eNFA143_27_36478775[\"εNFA143-27 post-regex end"/]
eNFA143_24_13186971 -.->|"ε"|eNFA143_0_51573880
eNFA143_24_13186971 -->|"u"|eNFA143_1_61511739
eNFA143_0_51573880 -->|"u"|eNFA143_1_61511739
eNFA143_1_61511739 -.->|"ε"|eNFA143_2_16734741
eNFA143_1_61511739 -->|"s"|eNFA143_3_16394943
eNFA143_2_16734741 -->|"s"|eNFA143_3_16394943
eNFA143_3_16394943 -.->|"ε"|eNFA143_4_13336762
eNFA143_3_16394943 -->|"a"|eNFA143_5_52922000
eNFA143_4_13336762 -->|"a"|eNFA143_5_52922000
eNFA143_5_52922000 -.->|"ε"|eNFA143_6_6535952
eNFA143_5_52922000 -->|"m"|eNFA143_7_58823573
eNFA143_6_6535952 -->|"m"|eNFA143_7_58823573
eNFA143_7_58823573 -.->|"ε"|eNFA143_8_59650110
eNFA143_7_58823573 -->|"p"|eNFA143_9_67088950
eNFA143_8_59650110 -->|"p"|eNFA143_9_67088950
eNFA143_9_67088950 -.->|"ε"|eNFA143_10_66929645
eNFA143_9_67088950 -->|"l"|eNFA143_11_65495901
eNFA143_10_66929645 -->|"l"|eNFA143_11_65495901
eNFA143_11_65495901 -.->|"ε"|eNFA143_12_52592197
eNFA143_11_65495901 -->|"e"|eNFA143_13_3567727
eNFA143_12_52592197 -->|"e"|eNFA143_13_3567727
eNFA143_13_3567727 -.->|"ε"|eNFA143_14_32109549
eNFA143_13_3567727 -->|"r"|eNFA143_15_20550486
eNFA143_14_32109549 -->|"r"|eNFA143_15_20550486
eNFA143_15_20550486 -.->|"ε"|eNFA143_16_50736653
eNFA143_15_20550486 -->|"C"|eNFA143_17_53976698
eNFA143_16_50736653 -->|"C"|eNFA143_17_53976698
eNFA143_17_53976698 -.->|"ε"|eNFA143_18_16028238
eNFA143_17_53976698 -->|"u"|eNFA143_19_10036418
eNFA143_18_16028238 -->|"u"|eNFA143_19_10036418
eNFA143_19_10036418 -.->|"ε"|eNFA143_20_23218903
eNFA143_19_10036418 -->|"b"|eNFA143_21_7643543
eNFA143_20_23218903 -->|"b"|eNFA143_21_7643543
eNFA143_21_7643543 -.->|"ε"|eNFA143_22_1683025
eNFA143_21_7643543 -->|"e"|eNFA143_23_15147232
eNFA143_22_1683025 -->|"e"|eNFA143_23_15147232
eNFA143_23_15147232 -.->|"ε"|eNFA143_25_2107364
eNFA143_23_15147232 -.->|"ε"|eNFA143_26_18966278
eNFA143_23_15147232 -.->|"ε"|eNFA143_27_36478775
eNFA143_25_2107364 -.->|"ε"|eNFA143_26_18966278
eNFA143_25_2107364 -.->|"ε"|eNFA143_27_36478775
eNFA143_26_18966278 -.->|"ε"|eNFA143_27_36478775
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
NFA143_24_59873520("NFA143-24 regex start")
NFA143_1_1990770("NFA143-1 char[1]")
NFA143_3_17916934("NFA143-3 char[1]")
NFA143_5_27034686("NFA143-5 char[1]")
NFA143_7_41985586("NFA143-7 char[1]")
NFA143_9_42325954("NFA143-9 char[1]")
NFA143_11_45389273("NFA143-11 char[1]")
NFA143_13_5850279("NFA143-13 char[1]")
NFA143_15_52652517("NFA143-15 char[1]")
NFA143_17_4110613("NFA143-17 char[1]")
NFA143_19_36995518("NFA143-19 char[1]")
NFA143_21_64524211("NFA143-21 char[1]")
NFA143_23_43846987[\"NFA143-23 char[1]"/]
NFA143_24_59873520 -->|"u"|NFA143_1_1990770
NFA143_1_1990770 -->|"s"|NFA143_3_17916934
NFA143_3_17916934 -->|"a"|NFA143_5_27034686
NFA143_5_27034686 -->|"m"|NFA143_7_41985586
NFA143_7_41985586 -->|"p"|NFA143_9_42325954
NFA143_9_42325954 -->|"l"|NFA143_11_45389273
NFA143_11_45389273 -->|"e"|NFA143_13_5850279
NFA143_13_5850279 -->|"r"|NFA143_15_52652517
NFA143_15_52652517 -->|"C"|NFA143_17_4110613
NFA143_17_4110613 -->|"u"|NFA143_19_36995518
NFA143_19_36995518 -->|"b"|NFA143_21_64524211
NFA143_21_64524211 -->|"e"|NFA143_23_43846987
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
subgraph DFA0_-1854737376["DFA0 regex start"]
NFA143_24_59873520_0("NFA143-24 regex start")
end
subgraph DFA1_2021838301["DFA1 {1}"]
NFA143_1_1990770_1("NFA143-1 char[1]")
end
subgraph DFA2_-1115637921["DFA2 {1}"]
NFA143_3_17916934_2("NFA143-3 char[1]")
end
subgraph DFA3_-1269476880["DFA3 {1}"]
NFA143_5_27034686_3("NFA143-5 char[1]")
end
subgraph DFA4_1164276085["DFA4 {1}"]
NFA143_7_41985586_4("NFA143-7 char[1]")
end
subgraph DFA5_1992679311["DFA5 {1}"]
NFA143_9_42325954_5("NFA143-9 char[1]")
end
subgraph DFA6_-2053772456["DFA6 {1}"]
NFA143_11_45389273_6("NFA143-11 char[1]")
end
subgraph DFA7_1837991895["DFA7 {1}"]
NFA143_13_5850279_7("NFA143-13 char[1]")
end
subgraph DFA8_-1512277709["DFA8 {1}"]
NFA143_15_52652517_8("NFA143-15 char[1]")
end
subgraph DFA9_-1522190334["DFA9 {1}"]
NFA143_17_4110613_9("NFA143-17 char[1]")
end
subgraph DFA10_1569630644["DFA10 {1}"]
NFA143_19_36995518_10("NFA143-19 char[1]")
end
subgraph DFA11_130185918["DFA11 {1}"]
NFA143_21_64524211_11("NFA143-21 char[1]")
end
subgraph DFA12_1952907060["DFA12 {1}"]
NFA143_23_43846987_12[\"NFA143-23 char[1]"/]
end
DFA0_-1854737376 -->|"u"|DFA1_2021838301
DFA1_2021838301 -->|"s"|DFA2_-1115637921
DFA2_-1115637921 -->|"a"|DFA3_-1269476880
DFA3_-1269476880 -->|"m"|DFA4_1164276085
DFA4_1164276085 -->|"p"|DFA5_1992679311
DFA5_1992679311 -->|"l"|DFA6_-2053772456
DFA6_-2053772456 -->|"e"|DFA7_1837991895
DFA7_1837991895 -->|"r"|DFA8_-1512277709
DFA8_-1512277709 -->|"C"|DFA9_-1522190334
DFA9_-1522190334 -->|"u"|DFA10_1569630644
DFA10_1569630644 -->|"b"|DFA11_130185918
DFA11_130185918 -->|"e"|DFA12_1952907060
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
DFA0_-1854737376{{"DFA0 regex start"}}
DFA1_2021838301{{"DFA1 {1}"}}
DFA2_-1115637921{{"DFA2 {1}"}}
DFA3_-1269476880{{"DFA3 {1}"}}
DFA4_1164276085{{"DFA4 {1}"}}
DFA5_1992679311{{"DFA5 {1}"}}
DFA6_-2053772456{{"DFA6 {1}"}}
DFA7_1837991895{{"DFA7 {1}"}}
DFA8_-1512277709{{"DFA8 {1}"}}
DFA9_-1522190334{{"DFA9 {1}"}}
DFA10_1569630644{{"DFA10 {1}"}}
DFA11_130185918{{"DFA11 {1}"}}
DFA12_1952907060[\"DFA12 {1}"/]
DFA0_-1854737376 -->|"u"|DFA1_2021838301
DFA1_2021838301 -->|"s"|DFA2_-1115637921
DFA2_-1115637921 -->|"a"|DFA3_-1269476880
DFA3_-1269476880 -->|"m"|DFA4_1164276085
DFA4_1164276085 -->|"p"|DFA5_1992679311
DFA5_1992679311 -->|"l"|DFA6_-2053772456
DFA6_-2053772456 -->|"e"|DFA7_1837991895
DFA7_1837991895 -->|"r"|DFA8_-1512277709
DFA8_-1512277709 -->|"C"|DFA9_-1522190334
DFA9_-1522190334 -->|"u"|DFA10_1569630644
DFA10_1569630644 -->|"b"|DFA11_130185918
DFA11_130185918 -->|"e"|DFA12_1952907060
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
subgraph MiniDFA0_1541597316["MiniDFA0 {1}"]
DFA0_-1854737376_0{{"DFA0 regex start"}}
end
subgraph MiniDFA2_-1740118178["MiniDFA2 {1}"]
DFA1_2021838301_1{{"DFA1 {1}"}}
end
subgraph MiniDFA3_117896412["MiniDFA3 {1}"]
DFA2_-1115637921_2{{"DFA2 {1}"}}
end
subgraph MiniDFA4_1918269580["MiniDFA4 {1}"]
DFA3_-1269476880_3{{"DFA3 {1}"}}
end
subgraph MiniDFA5_-1694447753["MiniDFA5 {1}"]
DFA4_1164276085_4{{"DFA4 {1}"}}
end
subgraph MiniDFA6_-2088100352["MiniDFA6 {1}"]
DFA5_1992679311_5{{"DFA5 {1}"}}
end
subgraph MiniDFA7_-82193601["MiniDFA7 {1}"]
DFA6_-2053772456_6{{"DFA6 {1}"}}
end
subgraph MiniDFA8_-1799634595["MiniDFA8 {1}"]
DFA7_1837991895_7{{"DFA7 {1}"}}
end
subgraph MiniDFA9_-1332906453["MiniDFA9 {1}"]
DFA8_-1512277709_8{{"DFA8 {1}"}}
end
subgraph MiniDFA1_1414505606["MiniDFA1 {1}"]
DFA9_-1522190334_9{{"DFA9 {1}"}}
end
subgraph MiniDFA10_1576644787["MiniDFA10 {1}"]
DFA10_1569630644_10{{"DFA10 {1}"}}
end
subgraph MiniDFA11_-1948165818["MiniDFA11 {1}"]
DFA11_130185918_11{{"DFA11 {1}"}}
end
subgraph MiniDFA12_1404084497["MiniDFA12 {1}"]
DFA12_1952907060_12[\"DFA12 {1}"/]
end
MiniDFA0_1541597316 -->|"u"|MiniDFA2_-1740118178
MiniDFA2_-1740118178 -->|"s"|MiniDFA3_117896412
MiniDFA3_117896412 -->|"a"|MiniDFA4_1918269580
MiniDFA4_1918269580 -->|"m"|MiniDFA5_-1694447753
MiniDFA5_-1694447753 -->|"p"|MiniDFA6_-2088100352
MiniDFA6_-2088100352 -->|"l"|MiniDFA7_-82193601
MiniDFA7_-82193601 -->|"e"|MiniDFA8_-1799634595
MiniDFA8_-1799634595 -->|"r"|MiniDFA9_-1332906453
MiniDFA9_-1332906453 -->|"C"|MiniDFA1_1414505606
MiniDFA1_1414505606 -->|"u"|MiniDFA10_1576644787
MiniDFA10_1576644787 -->|"b"|MiniDFA11_-1948165818
MiniDFA11_-1948165818 -->|"e"|MiniDFA12_1404084497
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
MiniDFA0_1541597316(["MiniDFA0 {1}"])
MiniDFA2_-1740118178(["MiniDFA2 {1}"])
MiniDFA3_117896412(["MiniDFA3 {1}"])
MiniDFA4_1918269580(["MiniDFA4 {1}"])
MiniDFA5_-1694447753(["MiniDFA5 {1}"])
MiniDFA6_-2088100352(["MiniDFA6 {1}"])
MiniDFA7_-82193601(["MiniDFA7 {1}"])
MiniDFA8_-1799634595(["MiniDFA8 {1}"])
MiniDFA9_-1332906453(["MiniDFA9 {1}"])
MiniDFA1_1414505606(["MiniDFA1 {1}"])
MiniDFA10_1576644787(["MiniDFA10 {1}"])
MiniDFA11_-1948165818(["MiniDFA11 {1}"])
MiniDFA12_1404084497[\"MiniDFA12 {1}"/]
MiniDFA0_1541597316 -->|"u"|MiniDFA2_-1740118178
MiniDFA2_-1740118178 -->|"s"|MiniDFA3_117896412
MiniDFA3_117896412 -->|"a"|MiniDFA4_1918269580
MiniDFA4_1918269580 -->|"m"|MiniDFA5_-1694447753
MiniDFA5_-1694447753 -->|"p"|MiniDFA6_-2088100352
MiniDFA6_-2088100352 -->|"l"|MiniDFA7_-82193601
MiniDFA7_-82193601 -->|"e"|MiniDFA8_-1799634595
MiniDFA8_-1799634595 -->|"r"|MiniDFA9_-1332906453
MiniDFA9_-1332906453 -->|"C"|MiniDFA1_1414505606
MiniDFA1_1414505606 -->|"u"|MiniDFA10_1576644787
MiniDFA10_1576644787 -->|"b"|MiniDFA11_-1948165818
MiniDFA11_-1948165818 -->|"e"|MiniDFA12_1404084497
```
-------------------------------
