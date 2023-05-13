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
eNFA1_6_39501348[["εNFA1-6 regex start"]]
eNFA1_2_44407631[["εNFA1-2 regex start"]]
eNFA1_0_40248354[["εNFA1-0 char{1, 1}"]]
eNFA1_4_64124362[["εNFA1-4 scope{1, 1}"]]
eNFA1_1_14476932[["εNFA1-1 char[1]"]]
eNFA1_5_26690871[["εNFA1-5 scope[1]"]]
eNFA1_3_38891250[["εNFA1-3 regex end"]]
eNFA1_2_63183526[["εNFA1-2 regex start"]]
eNFA1_0_17591975[["εNFA1-0 char{1, 1}"]]
eNFA1_4_31780825[["εNFA1-4 scope{1, 1}"]]
eNFA1_3_24110047[["εNFA1-3 regex end"]]
eNFA1_1_6756797[["εNFA1-1 char[1]"]]
eNFA1_5_60811181[["εNFA1-5 scope[1]"]]
eNFA1_7_15663836[["εNFA1-7 regex end"]]
eNFA1_8_30046694[["εNFA1-8 post-regex start"]]
eNFA1_9_1984791[\"εNFA1-9 post-regex end"/]
eNFA1_6_39501348 -.->|"ε"|eNFA1_2_44407631
eNFA1_2_44407631 -.->|"ε"|eNFA1_0_40248354
eNFA1_2_44407631 -.->|"ε"|eNFA1_4_64124362
eNFA1_0_40248354 -->|"#92;"|eNFA1_1_14476932
eNFA1_4_64124362 -->|"[Y-#92;]"|eNFA1_5_26690871
eNFA1_1_14476932 -.->|"ε"|eNFA1_3_38891250
eNFA1_5_26690871 -.->|"ε"|eNFA1_3_38891250
eNFA1_3_38891250 -.->|"ε"|eNFA1_2_63183526
eNFA1_2_63183526 -.->|"ε"|eNFA1_0_17591975
eNFA1_2_63183526 -.->|"ε"|eNFA1_4_31780825
eNFA1_2_63183526 -.->|"ε"|eNFA1_3_24110047
eNFA1_0_17591975 -->|"#92;"|eNFA1_1_6756797
eNFA1_4_31780825 -->|"[Y-#92;]"|eNFA1_5_60811181
eNFA1_3_24110047 -.->|"ε"|eNFA1_2_63183526
eNFA1_3_24110047 -.->|"ε"|eNFA1_7_15663836
eNFA1_1_6756797 -.->|"ε"|eNFA1_3_24110047
eNFA1_5_60811181 -.->|"ε"|eNFA1_3_24110047
eNFA1_7_15663836 -.->|"ε"|eNFA1_8_30046694
eNFA1_8_30046694 -.->|"ε"|eNFA1_9_1984791
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
eNFA1_6_17863121[["εNFA1-6 regex start"]]
eNFA1_2_19967814[["εNFA1-2 regex start"]]
eNFA1_0_6780253[["εNFA1-0 char{1, 1}"]]
eNFA1_4_45492604[["εNFA1-4 scope{1, 1}"]]
eNFA1_1_43857981[\"εNFA1-1 char[1]"/]
eNFA1_5_61022284[\"εNFA1-5 scope[1]"/]
eNFA1_3_12329649[\"εNFA1-3 regex end"/]
eNFA1_2_59177513[\"εNFA1-2 regex start"/]
eNFA1_0_28649262[\"εNFA1-0 char{1, 1}"/]
eNFA1_4_62835574[\"εNFA1-4 scope{1, 1}"/]
eNFA1_3_56516768[\"εNFA1-3 regex end"/]
eNFA1_1_14455523[\"εNFA1-1 char[1]"/]
eNFA1_5_62990845[\"εNFA1-5 scope[1]"/]
eNFA1_7_38888871[\"εNFA1-7 regex end"/]
eNFA1_8_26550365[\"εNFA1-8 post-regex start"/]
eNFA1_9_37626701[\"εNFA1-9 post-regex end"/]
eNFA1_6_17863121 -.->|"ε"|eNFA1_2_19967814
eNFA1_6_17863121 -.->|"ε"|eNFA1_0_6780253
eNFA1_6_17863121 -.->|"ε"|eNFA1_4_45492604
eNFA1_6_17863121 -->|"#92;"|eNFA1_1_43857981
eNFA1_6_17863121 -->|"[Y-#92;]"|eNFA1_5_61022284
eNFA1_2_19967814 -.->|"ε"|eNFA1_0_6780253
eNFA1_2_19967814 -.->|"ε"|eNFA1_4_45492604
eNFA1_2_19967814 -->|"#92;"|eNFA1_1_43857981
eNFA1_2_19967814 -->|"[Y-#92;]"|eNFA1_5_61022284
eNFA1_0_6780253 -->|"#92;"|eNFA1_1_43857981
eNFA1_4_45492604 -->|"[Y-#92;]"|eNFA1_5_61022284
eNFA1_1_43857981 -.->|"ε"|eNFA1_3_12329649
eNFA1_1_43857981 -.->|"ε"|eNFA1_2_59177513
eNFA1_1_43857981 -.->|"ε"|eNFA1_0_28649262
eNFA1_1_43857981 -.->|"ε"|eNFA1_4_62835574
eNFA1_1_43857981 -.->|"ε"|eNFA1_3_56516768
eNFA1_1_43857981 -->|"#92;"|eNFA1_1_14455523
eNFA1_1_43857981 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_1_43857981 -.->|"ε"|eNFA1_7_38888871
eNFA1_1_43857981 -.->|"ε"|eNFA1_8_26550365
eNFA1_1_43857981 -.->|"ε"|eNFA1_9_37626701
eNFA1_5_61022284 -.->|"ε"|eNFA1_3_12329649
eNFA1_5_61022284 -.->|"ε"|eNFA1_2_59177513
eNFA1_5_61022284 -.->|"ε"|eNFA1_0_28649262
eNFA1_5_61022284 -.->|"ε"|eNFA1_4_62835574
eNFA1_5_61022284 -.->|"ε"|eNFA1_3_56516768
eNFA1_5_61022284 -->|"#92;"|eNFA1_1_14455523
eNFA1_5_61022284 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_5_61022284 -.->|"ε"|eNFA1_7_38888871
eNFA1_5_61022284 -.->|"ε"|eNFA1_8_26550365
eNFA1_5_61022284 -.->|"ε"|eNFA1_9_37626701
eNFA1_3_12329649 -.->|"ε"|eNFA1_2_59177513
eNFA1_3_12329649 -.->|"ε"|eNFA1_0_28649262
eNFA1_3_12329649 -.->|"ε"|eNFA1_4_62835574
eNFA1_3_12329649 -.->|"ε"|eNFA1_3_56516768
eNFA1_3_12329649 -->|"#92;"|eNFA1_1_14455523
eNFA1_3_12329649 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_3_12329649 -.->|"ε"|eNFA1_7_38888871
eNFA1_3_12329649 -.->|"ε"|eNFA1_8_26550365
eNFA1_3_12329649 -.->|"ε"|eNFA1_9_37626701
eNFA1_2_59177513 -.->|"ε"|eNFA1_0_28649262
eNFA1_2_59177513 -.->|"ε"|eNFA1_4_62835574
eNFA1_2_59177513 -.->|"ε"|eNFA1_3_56516768
eNFA1_2_59177513 -->|"#92;"|eNFA1_1_14455523
eNFA1_2_59177513 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_2_59177513 -.->|"ε"|eNFA1_2_59177513
eNFA1_2_59177513 -.->|"ε"|eNFA1_7_38888871
eNFA1_2_59177513 -.->|"ε"|eNFA1_8_26550365
eNFA1_2_59177513 -.->|"ε"|eNFA1_9_37626701
eNFA1_0_28649262 -->|"#92;"|eNFA1_1_14455523
eNFA1_4_62835574 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_3_56516768 -.->|"ε"|eNFA1_2_59177513
eNFA1_3_56516768 -.->|"ε"|eNFA1_7_38888871
eNFA1_3_56516768 -.->|"ε"|eNFA1_0_28649262
eNFA1_3_56516768 -.->|"ε"|eNFA1_4_62835574
eNFA1_3_56516768 -.->|"ε"|eNFA1_3_56516768
eNFA1_3_56516768 -->|"#92;"|eNFA1_1_14455523
eNFA1_3_56516768 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_3_56516768 -.->|"ε"|eNFA1_8_26550365
eNFA1_3_56516768 -.->|"ε"|eNFA1_9_37626701
eNFA1_1_14455523 -.->|"ε"|eNFA1_3_56516768
eNFA1_1_14455523 -.->|"ε"|eNFA1_2_59177513
eNFA1_1_14455523 -.->|"ε"|eNFA1_7_38888871
eNFA1_1_14455523 -.->|"ε"|eNFA1_0_28649262
eNFA1_1_14455523 -.->|"ε"|eNFA1_4_62835574
eNFA1_1_14455523 -->|"#92;"|eNFA1_1_14455523
eNFA1_1_14455523 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_1_14455523 -.->|"ε"|eNFA1_8_26550365
eNFA1_1_14455523 -.->|"ε"|eNFA1_9_37626701
eNFA1_5_62990845 -.->|"ε"|eNFA1_3_56516768
eNFA1_5_62990845 -.->|"ε"|eNFA1_2_59177513
eNFA1_5_62990845 -.->|"ε"|eNFA1_7_38888871
eNFA1_5_62990845 -.->|"ε"|eNFA1_0_28649262
eNFA1_5_62990845 -.->|"ε"|eNFA1_4_62835574
eNFA1_5_62990845 -->|"#92;"|eNFA1_1_14455523
eNFA1_5_62990845 -->|"[Y-#92;]"|eNFA1_5_62990845
eNFA1_5_62990845 -.->|"ε"|eNFA1_8_26550365
eNFA1_5_62990845 -.->|"ε"|eNFA1_9_37626701
eNFA1_7_38888871 -.->|"ε"|eNFA1_8_26550365
eNFA1_7_38888871 -.->|"ε"|eNFA1_9_37626701
eNFA1_8_26550365 -.->|"ε"|eNFA1_9_37626701
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
NFA1_6_3095993("NFA1-6 regex start")
NFA1_1_49448848[\"NFA1-1 char[1]"/]
NFA1_5_27863937[\"NFA1-5 scope[1]"/]
NFA1_1_45933772[\"NFA1-1 char[1]"/]
NFA1_5_42386454[\"NFA1-5 scope[1]"/]
NFA1_6_3095993 -->|"#92;"|NFA1_1_49448848
NFA1_6_3095993 -->|"[Y-#92;]"|NFA1_5_27863937
NFA1_1_49448848 -->|"#92;"|NFA1_1_45933772
NFA1_1_49448848 -->|"[Y-#92;]"|NFA1_5_42386454
NFA1_5_27863937 -->|"#92;"|NFA1_1_45933772
NFA1_5_27863937 -->|"[Y-#92;]"|NFA1_5_42386454
NFA1_1_45933772 -->|"#92;"|NFA1_1_45933772
NFA1_1_45933772 -->|"[Y-#92;]"|NFA1_5_42386454
NFA1_5_42386454 -->|"#92;"|NFA1_1_45933772
NFA1_5_42386454 -->|"[Y-#92;]"|NFA1_5_42386454
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
subgraph DFA0_695916029["DFA0 regex start"]
NFA1_6_3095993_0("NFA1-6 regex start")
end
subgraph DFA1_-2050537718["DFA1 {2}"]
NFA1_1_49448848_1[\"NFA1-1 char[1]"/]
NFA1_5_27863937_2[\"NFA1-5 scope[1]"/]
end
subgraph DFA2_722523981["DFA2 {1}"]
NFA1_5_27863937_3[\"NFA1-5 scope[1]"/]
end
subgraph DFA3_297059357["DFA3 {2}"]
NFA1_1_45933772_4[\"NFA1-1 char[1]"/]
NFA1_5_42386454_5[\"NFA1-5 scope[1]"/]
end
subgraph DFA4_1000023991["DFA4 {1}"]
NFA1_5_42386454_6[\"NFA1-5 scope[1]"/]
end
DFA0_695916029 -->|"#92;"|DFA1_-2050537718
DFA0_695916029 -->|"[Y-[]"|DFA2_722523981
DFA1_-2050537718 -->|"#92;"|DFA3_297059357
DFA1_-2050537718 -->|"[Y-[]"|DFA4_1000023991
DFA2_722523981 -->|"#92;"|DFA3_297059357
DFA2_722523981 -->|"[Y-[]"|DFA4_1000023991
DFA3_297059357 -->|"#92;"|DFA3_297059357
DFA3_297059357 -->|"[Y-[]"|DFA4_1000023991
DFA4_1000023991 -->|"#92;"|DFA3_297059357
DFA4_1000023991 -->|"[Y-[]"|DFA4_1000023991
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
DFA0_695916029{{"DFA0 regex start"}}
DFA1_-2050537718[\"DFA1 {2}"/]
DFA2_722523981[\"DFA2 {1}"/]
DFA3_297059357[\"DFA3 {2}"/]
DFA4_1000023991[\"DFA4 {1}"/]
DFA0_695916029 -->|"#92;"|DFA1_-2050537718
DFA0_695916029 -->|"[Y-[]"|DFA2_722523981
DFA1_-2050537718 -->|"#92;"|DFA3_297059357
DFA1_-2050537718 -->|"[Y-[]"|DFA4_1000023991
DFA2_722523981 -->|"#92;"|DFA3_297059357
DFA2_722523981 -->|"[Y-[]"|DFA4_1000023991
DFA3_297059357 -->|"#92;"|DFA3_297059357
DFA3_297059357 -->|"[Y-[]"|DFA4_1000023991
DFA4_1000023991 -->|"#92;"|DFA3_297059357
DFA4_1000023991 -->|"[Y-[]"|DFA4_1000023991
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
subgraph MiniDFA0_-1318178915["MiniDFA0 {1}"]
DFA0_695916029_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-159763295["MiniDFA1 {1}"]
DFA1_-2050537718_1[\"DFA1 {2}"/]
end
subgraph MiniDFA2_822585770["MiniDFA2 {1}"]
DFA2_722523981_2[\"DFA2 {1}"/]
end
subgraph MiniDFA3_-1590090453["MiniDFA3 {1}"]
DFA3_297059357_3[\"DFA3 {2}"/]
end
subgraph MiniDFA4_-2049551057["MiniDFA4 {1}"]
DFA4_1000023991_4[\"DFA4 {1}"/]
end
MiniDFA0_-1318178915 -->|"#92;"|MiniDFA1_-159763295
MiniDFA0_-1318178915 -->|"[Y-[]"|MiniDFA2_822585770
MiniDFA1_-159763295 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA1_-159763295 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA2_822585770 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA2_822585770 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA3_-1590090453 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA3_-1590090453 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA4_-2049551057 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA4_-2049551057 -->|"[Y-[]"|MiniDFA4_-2049551057
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
MiniDFA0_-1318178915(["MiniDFA0 {1}"])
MiniDFA1_-159763295[\"MiniDFA1 {1}"/]
MiniDFA2_822585770[\"MiniDFA2 {1}"/]
MiniDFA3_-1590090453[\"MiniDFA3 {1}"/]
MiniDFA4_-2049551057[\"MiniDFA4 {1}"/]
MiniDFA0_-1318178915 -->|"#92;"|MiniDFA1_-159763295
MiniDFA0_-1318178915 -->|"[Y-[]"|MiniDFA2_822585770
MiniDFA1_-159763295 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA1_-159763295 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA2_822585770 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA2_822585770 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA3_-1590090453 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA3_-1590090453 -->|"[Y-[]"|MiniDFA4_-2049551057
MiniDFA4_-2049551057 -->|"#92;"|MiniDFA3_-1590090453
MiniDFA4_-2049551057 -->|"[Y-[]"|MiniDFA4_-2049551057
```
-------------------------------
