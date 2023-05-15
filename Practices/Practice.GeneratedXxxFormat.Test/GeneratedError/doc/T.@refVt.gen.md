# 'refVt'

pattern: `(\\|[Y-\\])+`

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
eNFA1_6_15080136[["εNFA1-6 regex start"]]
eNFA1_2_10857028[["εNFA1-2 regex start"]]
eNFA1_0_7004053[["εNFA1-0 char{1, 1}"]]
eNFA1_4_30604389[["εNFA1-4 scope{1, 1}"]]
eNFA1_1_5681612[["εNFA1-1 char[1]"]]
eNFA1_5_63036484[["εNFA1-5 scope[1]"]]
eNFA1_3_30457452[["εNFA1-3 regex end"]]
eNFA1_2_51134510[["εNFA1-2 regex start"]]
eNFA1_0_48254661[["εNFA1-0 char{1, 1}"]]
eNFA1_4_57557412[["εNFA1-4 scope{1, 1}"]]
eNFA1_3_31638772[["εNFA1-3 regex end"]]
eNFA1_1_12603749[["εNFA1-1 char[1]"]]
eNFA1_5_46324881[["εNFA1-5 scope[1]"]]
eNFA1_7_16313497[["εNFA1-7 regex end"]]
eNFA1_8_6849756[["εNFA1-8 post-regex start"]]
eNFA1_9_61647805[\"εNFA1-9 post-regex end"/]
eNFA1_6_15080136 -.->|"ε"|eNFA1_2_10857028
eNFA1_2_10857028 -.->|"ε"|eNFA1_0_7004053
eNFA1_2_10857028 -.->|"ε"|eNFA1_4_30604389
eNFA1_0_7004053 -->|"#92;"|eNFA1_1_5681612
eNFA1_4_30604389 -->|"[Y-#92;]"|eNFA1_5_63036484
eNFA1_1_5681612 -.->|"ε"|eNFA1_3_30457452
eNFA1_5_63036484 -.->|"ε"|eNFA1_3_30457452
eNFA1_3_30457452 -.->|"ε"|eNFA1_2_51134510
eNFA1_2_51134510 -.->|"ε"|eNFA1_0_48254661
eNFA1_2_51134510 -.->|"ε"|eNFA1_4_57557412
eNFA1_2_51134510 -.->|"ε"|eNFA1_3_31638772
eNFA1_0_48254661 -->|"#92;"|eNFA1_1_12603749
eNFA1_4_57557412 -->|"[Y-#92;]"|eNFA1_5_46324881
eNFA1_3_31638772 -.->|"ε"|eNFA1_2_51134510
eNFA1_3_31638772 -.->|"ε"|eNFA1_7_16313497
eNFA1_1_12603749 -.->|"ε"|eNFA1_3_31638772
eNFA1_5_46324881 -.->|"ε"|eNFA1_3_31638772
eNFA1_7_16313497 -.->|"ε"|eNFA1_8_6849756
eNFA1_8_6849756 -.->|"ε"|eNFA1_9_61647805
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
eNFA1_6_17959338[["εNFA1-6 regex start"]]
eNFA1_2_1503503[["εNFA1-2 regex start"]]
eNFA1_0_54674917[["εNFA1-0 char{1, 1}"]]
eNFA1_4_13531531[["εNFA1-4 scope{1, 1}"]]
eNFA1_1_62458233[\"εNFA1-1 char[1]"/]
eNFA1_5_22312206[\"εNFA1-5 scope[1]"/]
eNFA1_3_66592127[\"εNFA1-3 regex end"/]
eNFA1_2_25253189[\"εNFA1-2 regex start"/]
eNFA1_0_32242465[\"εNFA1-0 char{1, 1}"/]
eNFA1_4_25952117[\"εNFA1-4 scope{1, 1}"/]
eNFA1_3_21746729[\"εNFA1-3 regex end"/]
eNFA1_1_16654654[\"εNFA1-1 char[1]"/]
eNFA1_5_15674164[\"εNFA1-5 scope[1]"/]
eNFA1_7_61502840[\"εNFA1-7 regex end"/]
eNFA1_8_27416314[\"εNFA1-8 post-regex start"/]
eNFA1_9_45420240[\"εNFA1-9 post-regex end"/]
eNFA1_6_17959338 -.->|"ε"|eNFA1_2_1503503
eNFA1_6_17959338 -.->|"ε"|eNFA1_0_54674917
eNFA1_6_17959338 -.->|"ε"|eNFA1_4_13531531
eNFA1_6_17959338 -->|"#92;"|eNFA1_1_62458233
eNFA1_6_17959338 -->|"[Y-#92;]"|eNFA1_5_22312206
eNFA1_2_1503503 -.->|"ε"|eNFA1_0_54674917
eNFA1_2_1503503 -.->|"ε"|eNFA1_4_13531531
eNFA1_2_1503503 -->|"#92;"|eNFA1_1_62458233
eNFA1_2_1503503 -->|"[Y-#92;]"|eNFA1_5_22312206
eNFA1_0_54674917 -->|"#92;"|eNFA1_1_62458233
eNFA1_4_13531531 -->|"[Y-#92;]"|eNFA1_5_22312206
eNFA1_1_62458233 -.->|"ε"|eNFA1_3_66592127
eNFA1_1_62458233 -.->|"ε"|eNFA1_2_25253189
eNFA1_1_62458233 -.->|"ε"|eNFA1_0_32242465
eNFA1_1_62458233 -.->|"ε"|eNFA1_4_25952117
eNFA1_1_62458233 -.->|"ε"|eNFA1_3_21746729
eNFA1_1_62458233 -->|"#92;"|eNFA1_1_16654654
eNFA1_1_62458233 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_1_62458233 -.->|"ε"|eNFA1_7_61502840
eNFA1_1_62458233 -.->|"ε"|eNFA1_8_27416314
eNFA1_1_62458233 -.->|"ε"|eNFA1_9_45420240
eNFA1_5_22312206 -.->|"ε"|eNFA1_3_66592127
eNFA1_5_22312206 -.->|"ε"|eNFA1_2_25253189
eNFA1_5_22312206 -.->|"ε"|eNFA1_0_32242465
eNFA1_5_22312206 -.->|"ε"|eNFA1_4_25952117
eNFA1_5_22312206 -.->|"ε"|eNFA1_3_21746729
eNFA1_5_22312206 -->|"#92;"|eNFA1_1_16654654
eNFA1_5_22312206 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_5_22312206 -.->|"ε"|eNFA1_7_61502840
eNFA1_5_22312206 -.->|"ε"|eNFA1_8_27416314
eNFA1_5_22312206 -.->|"ε"|eNFA1_9_45420240
eNFA1_3_66592127 -.->|"ε"|eNFA1_2_25253189
eNFA1_3_66592127 -.->|"ε"|eNFA1_0_32242465
eNFA1_3_66592127 -.->|"ε"|eNFA1_4_25952117
eNFA1_3_66592127 -.->|"ε"|eNFA1_3_21746729
eNFA1_3_66592127 -->|"#92;"|eNFA1_1_16654654
eNFA1_3_66592127 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_3_66592127 -.->|"ε"|eNFA1_7_61502840
eNFA1_3_66592127 -.->|"ε"|eNFA1_8_27416314
eNFA1_3_66592127 -.->|"ε"|eNFA1_9_45420240
eNFA1_2_25253189 -.->|"ε"|eNFA1_0_32242465
eNFA1_2_25253189 -.->|"ε"|eNFA1_4_25952117
eNFA1_2_25253189 -.->|"ε"|eNFA1_3_21746729
eNFA1_2_25253189 -->|"#92;"|eNFA1_1_16654654
eNFA1_2_25253189 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_2_25253189 -.->|"ε"|eNFA1_2_25253189
eNFA1_2_25253189 -.->|"ε"|eNFA1_7_61502840
eNFA1_2_25253189 -.->|"ε"|eNFA1_8_27416314
eNFA1_2_25253189 -.->|"ε"|eNFA1_9_45420240
eNFA1_0_32242465 -->|"#92;"|eNFA1_1_16654654
eNFA1_4_25952117 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_3_21746729 -.->|"ε"|eNFA1_2_25253189
eNFA1_3_21746729 -.->|"ε"|eNFA1_7_61502840
eNFA1_3_21746729 -.->|"ε"|eNFA1_0_32242465
eNFA1_3_21746729 -.->|"ε"|eNFA1_4_25952117
eNFA1_3_21746729 -.->|"ε"|eNFA1_3_21746729
eNFA1_3_21746729 -->|"#92;"|eNFA1_1_16654654
eNFA1_3_21746729 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_3_21746729 -.->|"ε"|eNFA1_8_27416314
eNFA1_3_21746729 -.->|"ε"|eNFA1_9_45420240
eNFA1_1_16654654 -.->|"ε"|eNFA1_3_21746729
eNFA1_1_16654654 -.->|"ε"|eNFA1_2_25253189
eNFA1_1_16654654 -.->|"ε"|eNFA1_7_61502840
eNFA1_1_16654654 -.->|"ε"|eNFA1_0_32242465
eNFA1_1_16654654 -.->|"ε"|eNFA1_4_25952117
eNFA1_1_16654654 -->|"#92;"|eNFA1_1_16654654
eNFA1_1_16654654 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_1_16654654 -.->|"ε"|eNFA1_8_27416314
eNFA1_1_16654654 -.->|"ε"|eNFA1_9_45420240
eNFA1_5_15674164 -.->|"ε"|eNFA1_3_21746729
eNFA1_5_15674164 -.->|"ε"|eNFA1_2_25253189
eNFA1_5_15674164 -.->|"ε"|eNFA1_7_61502840
eNFA1_5_15674164 -.->|"ε"|eNFA1_0_32242465
eNFA1_5_15674164 -.->|"ε"|eNFA1_4_25952117
eNFA1_5_15674164 -->|"#92;"|eNFA1_1_16654654
eNFA1_5_15674164 -->|"[Y-#92;]"|eNFA1_5_15674164
eNFA1_5_15674164 -.->|"ε"|eNFA1_8_27416314
eNFA1_5_15674164 -.->|"ε"|eNFA1_9_45420240
eNFA1_7_61502840 -.->|"ε"|eNFA1_8_27416314
eNFA1_7_61502840 -.->|"ε"|eNFA1_9_45420240
eNFA1_8_27416314 -.->|"ε"|eNFA1_9_45420240
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
NFA1_6_6128980("NFA1-6 regex start")
NFA1_1_26685362[\"NFA1-1 char[1]"/]
NFA1_5_55160823[\"NFA1-5 scope[1]"/]
NFA1_1_14030717[\"NFA1-1 char[1]"/]
NFA1_5_38841670[\"NFA1-5 scope[1]"/]
NFA1_6_6128980 -->|"#92;"|NFA1_1_26685362
NFA1_6_6128980 -->|"[Y-#92;]"|NFA1_5_55160823
NFA1_1_26685362 -->|"#92;"|NFA1_1_14030717
NFA1_1_26685362 -->|"[Y-#92;]"|NFA1_5_38841670
NFA1_5_55160823 -->|"#92;"|NFA1_1_14030717
NFA1_5_55160823 -->|"[Y-#92;]"|NFA1_5_38841670
NFA1_1_14030717 -->|"#92;"|NFA1_1_14030717
NFA1_1_14030717 -->|"[Y-#92;]"|NFA1_5_38841670
NFA1_5_38841670 -->|"#92;"|NFA1_1_14030717
NFA1_5_38841670 -->|"[Y-#92;]"|NFA1_5_38841670
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
subgraph DFA0_-1634467619["DFA0 regex start"]
NFA1_6_6128980_0("NFA1-6 regex start")
end
subgraph DFA1_208241424["DFA1 {2}"]
NFA1_1_26685362_1[\"NFA1-1 char[1]"/]
NFA1_5_55160823_2[\"NFA1-5 scope[1]"/]
end
subgraph DFA2_2071661458["DFA2 {1}"]
NFA1_5_55160823_3[\"NFA1-5 scope[1]"/]
end
subgraph DFA3_-643608291["DFA3 {2}"]
NFA1_1_14030717_4[\"NFA1-1 char[1]"/]
NFA1_5_38841670_5[\"NFA1-5 scope[1]"/]
end
subgraph DFA4_465365747["DFA4 {1}"]
NFA1_5_38841670_6[\"NFA1-5 scope[1]"/]
end
DFA0_-1634467619 -->|"#92;"|DFA1_208241424
DFA0_-1634467619 -->|"[Y-[]"|DFA2_2071661458
DFA1_208241424 -->|"#92;"|DFA3_-643608291
DFA1_208241424 -->|"[Y-[]"|DFA4_465365747
DFA2_2071661458 -->|"#92;"|DFA3_-643608291
DFA2_2071661458 -->|"[Y-[]"|DFA4_465365747
DFA3_-643608291 -->|"#92;"|DFA3_-643608291
DFA3_-643608291 -->|"[Y-[]"|DFA4_465365747
DFA4_465365747 -->|"#92;"|DFA3_-643608291
DFA4_465365747 -->|"[Y-[]"|DFA4_465365747
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
DFA0_-1634467619{{"DFA0 regex start"}}
DFA1_208241424[\"DFA1 {2}"/]
DFA2_2071661458[\"DFA2 {1}"/]
DFA3_-643608291[\"DFA3 {2}"/]
DFA4_465365747[\"DFA4 {1}"/]
DFA0_-1634467619 -->|"#92;"|DFA1_208241424
DFA0_-1634467619 -->|"[Y-[]"|DFA2_2071661458
DFA1_208241424 -->|"#92;"|DFA3_-643608291
DFA1_208241424 -->|"[Y-[]"|DFA4_465365747
DFA2_2071661458 -->|"#92;"|DFA3_-643608291
DFA2_2071661458 -->|"[Y-[]"|DFA4_465365747
DFA3_-643608291 -->|"#92;"|DFA3_-643608291
DFA3_-643608291 -->|"[Y-[]"|DFA4_465365747
DFA4_465365747 -->|"#92;"|DFA3_-643608291
DFA4_465365747 -->|"[Y-[]"|DFA4_465365747
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
subgraph MiniDFA0_-688934704["MiniDFA0 {1}"]
DFA0_-1634467619_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_39597994["MiniDFA1 {1}"]
DFA1_208241424_1[\"DFA1 {2}"/]
end
subgraph MiniDFA2_-1718417228["MiniDFA2 {1}"]
DFA2_2071661458_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_862120099["MiniDFA3 {1}"]
DFA3_-643608291_3[\"DFA3 {2}"/]
end
subgraph MiniDFA4_-1229322445["MiniDFA4 {1}"]
DFA4_465365747_4[\"DFA4 {1}"/]
end
MiniDFA0_-688934704 -->|"#92;"|MiniDFA1_39597994
MiniDFA0_-688934704 -->|"[Y-[]"|MiniDFA2_-1718417228
MiniDFA1_39597994 -->|"#92;"|MiniDFA3_862120099
MiniDFA1_39597994 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA2_-1718417228 -->|"#92;"|MiniDFA3_862120099
MiniDFA2_-1718417228 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA3_862120099 -->|"#92;"|MiniDFA3_862120099
MiniDFA3_862120099 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA4_-1229322445 -->|"#92;"|MiniDFA3_862120099
MiniDFA4_-1229322445 -->|"[Y-[]"|MiniDFA4_-1229322445
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
MiniDFA0_-688934704(["MiniDFA0 {1}"])
MiniDFA1_39597994[\"MiniDFA1 {1}"/]
MiniDFA2_-1718417228[\"MiniDFA2 {1}"/]
MiniDFA3_862120099[\"MiniDFA3 {1}"/]
MiniDFA4_-1229322445[\"MiniDFA4 {1}"/]
MiniDFA0_-688934704 -->|"#92;"|MiniDFA1_39597994
MiniDFA0_-688934704 -->|"[Y-[]"|MiniDFA2_-1718417228
MiniDFA1_39597994 -->|"#92;"|MiniDFA3_862120099
MiniDFA1_39597994 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA2_-1718417228 -->|"#92;"|MiniDFA3_862120099
MiniDFA2_-1718417228 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA3_862120099 -->|"#92;"|MiniDFA3_862120099
MiniDFA3_862120099 -->|"[Y-[]"|MiniDFA4_-1229322445
MiniDFA4_-1229322445 -->|"#92;"|MiniDFA3_862120099
MiniDFA4_-1229322445 -->|"[Y-[]"|MiniDFA4_-1229322445
```
-------------------------------
