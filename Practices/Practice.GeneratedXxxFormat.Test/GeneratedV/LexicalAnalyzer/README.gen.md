# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `V`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（23个State）。

## 'Vt'
1/3: pre-regex `'@Initial'`

2/3: regex
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
eNFA0_20_14439320[["εNFA0-20 regex start"]]
eNFA0_0_62845019[["εNFA0-0 char{1, 1}"]]
eNFA0_1_28734262[["εNFA0-1 char[1]"]]
eNFA0_4_11931350[["εNFA0-4 regex start"]]
eNFA0_2_26915331[["εNFA0-2 scope{1, 1}"]]
eNFA0_6_40273294[["εNFA0-6 char{1, 1}"]]
eNFA0_10_28067877[["εNFA0-10 scope{1, 1}"]]
eNFA0_12_58905579[["εNFA0-12 char{1, 1}"]]
eNFA0_16_6622601[["εNFA0-16 scope{1, 1}"]]
eNFA0_3_25488274[["εNFA0-3 scope[1]"]]
eNFA0_7_27155224[["εNFA0-7 char[1]"]]
eNFA0_11_51284307[["εNFA0-11 scope[1]"]]
eNFA0_13_43070429[["εNFA0-13 char[1]"]]
eNFA0_17_59603417[["εNFA0-17 scope[1]"]]
eNFA0_5_32658192[["εNFA0-5 regex end"]]
eNFA0_8_52089545[["εNFA0-8 char{1, 1}"]]
eNFA0_14_41172652[["εNFA0-14 char{1, 1}"]]
eNFA0_4_66668712[["εNFA0-4 regex start"]]
eNFA0_9_40911390[["εNFA0-9 char[1]"]]
eNFA0_15_60388168[["εNFA0-15 char[1]"]]
eNFA0_2_31456624[["εNFA0-2 scope{1, 1}"]]
eNFA0_6_63147504[["εNFA0-6 char{1, 1}"]]
eNFA0_10_14674162[["εNFA0-10 scope{1, 1}"]]
eNFA0_12_64958600[["εNFA0-12 char{1, 1}"]]
eNFA0_16_47756489[["εNFA0-16 scope{1, 1}"]]
eNFA0_5_58503618[["εNFA0-5 regex end"]]
eNFA0_3_56770522[["εNFA0-3 scope[1]"]]
eNFA0_7_23416123[["εNFA0-7 char[1]"]]
eNFA0_11_66152725[["εNFA0-11 scope[1]"]]
eNFA0_13_9418520[["εNFA0-13 char[1]"]]
eNFA0_17_35009555[["εNFA0-17 scope[1]"]]
eNFA0_18_20597618[["εNFA0-18 char{1, 1}"]]
eNFA0_8_20997215[["εNFA0-8 char{1, 1}"]]
eNFA0_14_23052848[["εNFA0-14 char{1, 1}"]]
eNFA0_19_55341365[["εNFA0-19 char[1]"]]
eNFA0_9_46650543[["εNFA0-9 char[1]"]]
eNFA0_15_17201705[["εNFA0-15 char[1]"]]
eNFA0_21_28310238[["εNFA0-21 regex end"]]
eNFA0_20_14439320 -.->|"ε"|eNFA0_0_62845019
eNFA0_0_62845019 -->|"'"|eNFA0_1_28734262
eNFA0_1_28734262 -.->|"ε"|eNFA0_4_11931350
eNFA0_4_11931350 -.->|"ε"|eNFA0_2_26915331
eNFA0_4_11931350 -.->|"ε"|eNFA0_6_40273294
eNFA0_4_11931350 -.->|"ε"|eNFA0_10_28067877
eNFA0_4_11931350 -.->|"ε"|eNFA0_12_58905579
eNFA0_4_11931350 -.->|"ε"|eNFA0_16_6622601
eNFA0_2_26915331 -->|"[#32;-&]"|eNFA0_3_25488274
eNFA0_6_40273294 -->|"#92;"|eNFA0_7_27155224
eNFA0_10_28067877 -->|"[(-[]"|eNFA0_11_51284307
eNFA0_12_58905579 -->|"#92;"|eNFA0_13_43070429
eNFA0_16_6622601 -->|"[]-~]"|eNFA0_17_59603417
eNFA0_3_25488274 -.->|"ε"|eNFA0_5_32658192
eNFA0_7_27155224 -.->|"ε"|eNFA0_8_52089545
eNFA0_11_51284307 -.->|"ε"|eNFA0_5_32658192
eNFA0_13_43070429 -.->|"ε"|eNFA0_14_41172652
eNFA0_17_59603417 -.->|"ε"|eNFA0_5_32658192
eNFA0_5_32658192 -.->|"ε"|eNFA0_4_66668712
eNFA0_8_52089545 -->|"'"|eNFA0_9_40911390
eNFA0_14_41172652 -->|"#92;"|eNFA0_15_60388168
eNFA0_4_66668712 -.->|"ε"|eNFA0_2_31456624
eNFA0_4_66668712 -.->|"ε"|eNFA0_6_63147504
eNFA0_4_66668712 -.->|"ε"|eNFA0_10_14674162
eNFA0_4_66668712 -.->|"ε"|eNFA0_12_64958600
eNFA0_4_66668712 -.->|"ε"|eNFA0_16_47756489
eNFA0_4_66668712 -.->|"ε"|eNFA0_5_58503618
eNFA0_9_40911390 -.->|"ε"|eNFA0_5_32658192
eNFA0_15_60388168 -.->|"ε"|eNFA0_5_32658192
eNFA0_2_31456624 -->|"[#32;-&]"|eNFA0_3_56770522
eNFA0_6_63147504 -->|"#92;"|eNFA0_7_23416123
eNFA0_10_14674162 -->|"[(-[]"|eNFA0_11_66152725
eNFA0_12_64958600 -->|"#92;"|eNFA0_13_9418520
eNFA0_16_47756489 -->|"[]-~]"|eNFA0_17_35009555
eNFA0_5_58503618 -.->|"ε"|eNFA0_4_66668712
eNFA0_5_58503618 -.->|"ε"|eNFA0_18_20597618
eNFA0_3_56770522 -.->|"ε"|eNFA0_5_58503618
eNFA0_7_23416123 -.->|"ε"|eNFA0_8_20997215
eNFA0_11_66152725 -.->|"ε"|eNFA0_5_58503618
eNFA0_13_9418520 -.->|"ε"|eNFA0_14_23052848
eNFA0_17_35009555 -.->|"ε"|eNFA0_5_58503618
eNFA0_18_20597618 -->|"'"|eNFA0_19_55341365
eNFA0_8_20997215 -->|"'"|eNFA0_9_46650543
eNFA0_14_23052848 -->|"#92;"|eNFA0_15_17201705
eNFA0_19_55341365 -.->|"ε"|eNFA0_21_28310238
eNFA0_9_46650543 -.->|"ε"|eNFA0_5_58503618
eNFA0_15_17201705 -.->|"ε"|eNFA0_5_58503618
```

3/3: post-regex
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
eNFA0_22_35742973[["εNFA0-22 post-regex start"]]
eNFA0_23_53251301[\"εNFA0-23 post-regex end"/]
eNFA0_22_35742973 -.->|"ε"|eNFA0_23_53251301
```


## 'blockComment'
1/3: pre-regex `'@Initial'`

2/3: regex
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
eNFA0_16_14740628[["εNFA0-16 regex start"]]
eNFA0_0_65556790[["εNFA0-0 char{1, 1}"]]
eNFA0_1_53140205[["εNFA0-1 char[1]"]]
eNFA0_2_8499801[["εNFA0-2 char{1, 1}"]]
eNFA0_3_27757730[["εNFA0-3 char[1]"]]
eNFA0_6_57794333[["εNFA0-6 regex start"]]
eNFA0_4_50829401[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_50386953[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_23540813[["εNFA0-7 regex end"]]
eNFA0_5_10540732[["εNFA0-5 scope[1]"]]
eNFA0_9_64678211[["εNFA0-9 scope[1]"]]
eNFA0_12_48492984[["εNFA0-12 char{1, 1}"]]
eNFA0_10_24401462[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_18286572[["εNFA0-13 char[1]"]]
eNFA0_11_54811429[["εNFA0-11 scope[1]"]]
eNFA0_14_30361426[["εNFA0-14 char{1, 1}"]]
eNFA0_15_43356475[["εNFA0-15 char[1]"]]
eNFA0_17_54663960[["εNFA0-17 regex end"]]
eNFA0_16_14740628 -.->|"ε"|eNFA0_0_65556790
eNFA0_0_65556790 -->|"/"|eNFA0_1_53140205
eNFA0_1_53140205 -.->|"ε"|eNFA0_2_8499801
eNFA0_2_8499801 -->|"*"|eNFA0_3_27757730
eNFA0_3_27757730 -.->|"ε"|eNFA0_6_57794333
eNFA0_6_57794333 -.->|"ε"|eNFA0_4_50829401
eNFA0_6_57794333 -.->|"ε"|eNFA0_8_50386953
eNFA0_6_57794333 -.->|"ε"|eNFA0_7_23540813
eNFA0_4_50829401 -->|"[^*]"|eNFA0_5_10540732
eNFA0_8_50386953 -->|"[*]"|eNFA0_9_64678211
eNFA0_7_23540813 -.->|"ε"|eNFA0_6_57794333
eNFA0_7_23540813 -.->|"ε"|eNFA0_12_48492984
eNFA0_5_10540732 -.->|"ε"|eNFA0_7_23540813
eNFA0_9_64678211 -.->|"ε"|eNFA0_10_24401462
eNFA0_12_48492984 -->|"*"|eNFA0_13_18286572
eNFA0_10_24401462 -->|"[^/]"|eNFA0_11_54811429
eNFA0_13_18286572 -.->|"ε"|eNFA0_14_30361426
eNFA0_11_54811429 -.->|"ε"|eNFA0_7_23540813
eNFA0_14_30361426 -->|"/"|eNFA0_15_43356475
eNFA0_15_43356475 -.->|"ε"|eNFA0_17_54663960
```

3/3: post-regex
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
eNFA0_18_22213592[["εNFA0-18 post-regex start"]]
eNFA0_19_65704606[\"εNFA0-19 post-regex end"/]
eNFA0_18_22213592 -.->|"ε"|eNFA0_19_65704606
```


## 'inlineComment'
1/3: pre-regex `'@Initial'`

2/3: regex
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
eNFA0_5_46915732[["εNFA0-5 regex start"]]
eNFA0_0_19588408[["εNFA0-0 char{1, 1}"]]
eNFA0_1_42077948[["εNFA0-1 char[1]"]]
eNFA0_2_43157217[["εNFA0-2 char{1, 1}"]]
eNFA0_3_35617665[["εNFA0-3 char[1]"]]
eNFA0_4_52123534[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_66458622[["εNFA0-6 regex end"]]
eNFA0_5_46915732 -.->|"ε"|eNFA0_0_19588408
eNFA0_0_19588408 -->|"/"|eNFA0_1_42077948
eNFA0_1_42077948 -.->|"ε"|eNFA0_2_43157217
eNFA0_2_43157217 -->|"/"|eNFA0_3_35617665
eNFA0_3_35617665 -.->|"ε"|eNFA0_4_52123534
eNFA0_4_52123534 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_52123534
eNFA0_4_52123534 -.->|"ε"|eNFA0_6_66458622
```

3/3: post-regex
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
eNFA0_7_22209582[["εNFA0-7 post-regex start"]]
eNFA0_8_65668512[\"εNFA0-8 post-regex end"/]
eNFA0_7_22209582 -.->|"ε"|eNFA0_8_65668512
```




# 总状态机

## 1/5: extracted ε-NFA

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
eNFA0_0_51969174[["εNFA0-0 wholeStart"]]
eNFA1_20_63577855[["εNFA1-20 regex start"]]
class eNFA1_20_63577855 c1000;
eNFA2_16_65069390[["εNFA2-16 regex start"]]
class eNFA2_16_65069390 c1000;
eNFA3_5_34933209[["εNFA3-5 regex start"]]
class eNFA3_5_34933209 c1000;
eNFA1_0_35329788[["εNFA1-0 char{1, 1}"]]
eNFA2_0_56727555[["εNFA2-0 char{1, 1}"]]
eNFA3_0_11017648[["εNFA3-0 char{1, 1}"]]
eNFA1_1_48995250[["εNFA1-1 char[1]"]]
eNFA2_1_38304072[["εNFA2-1 char[1]"]]
eNFA3_1_9192332[["εNFA3-1 char[1]"]]
eNFA1_4_47990424[["εNFA1-4 regex start"]]
eNFA2_2_15622127[["εNFA2-2 char{1, 1}"]]
eNFA3_2_6381418[["εNFA3-2 char{1, 1}"]]
eNFA1_2_62019111[["εNFA1-2 scope{1, 1}"]]
eNFA1_6_29260633[["εNFA1-6 char{1, 1}"]]
eNFA1_10_21301090[["εNFA1-10 scope{1, 1}"]]
eNFA1_12_57492083[["εNFA1-12 char{1, 1}"]]
eNFA1_16_47666699[["εNFA1-16 scope{1, 1}"]]
eNFA2_3_58391916[["εNFA2-3 char[1]"]]
eNFA3_3_33571453[["εNFA3-3 char[1]"]]
eNFA1_3_53740895[["εNFA1-3 scope[1]"]]
eNFA1_7_9040176[["εNFA1-7 char[1]"]]
eNFA1_11_26347107[["εNFA1-11 scope[1]"]]
eNFA1_13_14252720[["εNFA1-13 char[1]"]]
eNFA1_17_13906014[["εNFA1-17 scope[1]"]]
eNFA2_6_42518340[["εNFA2-6 regex start"]]
eNFA3_4_3730161[["εNFA3-4 char{0, ∞}"]]
eNFA1_5_35797372[["εNFA1-5 regex end"]]
eNFA1_8_61165617[["εNFA1-8 char{1, 1}"]]
eNFA1_14_63718061[["εNFA1-14 char{1, 1}"]]
eNFA2_4_21433500[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_47120742[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_58683773[["εNFA2-7 regex end"]]
eNFA3_6_33707629[["εNFA3-6 regex end"]]
class eNFA3_6_33707629 c0100;
eNFA1_4_58045264[["εNFA1-4 regex start"]]
eNFA1_9_3672298[["εNFA1-9 char[1]"]]
eNFA1_15_33050690[["εNFA1-15 char[1]"]]
eNFA2_5_32124765[["εNFA2-5 scope[1]"]]
eNFA2_9_9362127[["εNFA2-9 scope[1]"]]
eNFA2_12_55765201[["εNFA2-12 char{1, 1}"]]
eNFA3_7_32049974[["εNFA3-7 post-regex start"]]
class eNFA3_7_32049974 c0010;
eNFA1_2_4045982[["εNFA1-2 scope{1, 1}"]]
eNFA1_6_52645336[["εNFA1-6 char{1, 1}"]]
eNFA1_10_36413843[["εNFA1-10 scope{1, 1}"]]
eNFA1_12_59289136[["εNFA1-12 char{1, 1}"]]
eNFA1_16_63840183[["εNFA1-16 scope{1, 1}"]]
eNFA1_5_37690735[["εNFA1-5 regex end"]]
eNFA2_10_64616609[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_44678570[["εNFA2-13 char[1]"]]
eNFA3_8_45963425[\"εNFA3-8 post-regex end"/]
class eNFA3_8_45963425 c0001;
eNFA1_3_59860242[["εNFA1-3 scope[1]"]]
eNFA1_7_66562817[["εNFA1-7 char[1]"]]
eNFA1_11_1871268[["εNFA1-11 scope[1]"]]
eNFA1_13_62194446[["εNFA1-13 char[1]"]]
eNFA1_17_16841414[["εNFA1-17 scope[1]"]]
eNFA1_18_29020759[["εNFA1-18 char{1, 1}"]]
eNFA2_11_20687433[["εNFA2-11 scope[1]"]]
eNFA2_14_4585366[["εNFA2-14 char{1, 1}"]]
eNFA0_1_36129223[\"εNFA0-1 wholeEnd"/]
eNFA1_8_35870379[["εNFA1-8 char{1, 1}"]]
eNFA1_14_19819572[["εNFA1-14 char{1, 1}"]]
eNFA1_19_49532637[["εNFA1-19 char[1]"]]
eNFA2_15_40785949[["εNFA2-15 char[1]"]]
eNFA1_9_17355001[["εNFA1-9 char[1]"]]
eNFA1_15_21977287[["εNFA1-15 char[1]"]]
eNFA1_21_43140557[["εNFA1-21 regex end"]]
class eNFA1_21_43140557 c0100;
eNFA2_17_31529222[["εNFA2-17 regex end"]]
class eNFA2_17_31529222 c0100;
eNFA1_22_52720700[["εNFA1-22 post-regex start"]]
class eNFA1_22_52720700 c0010;
eNFA2_18_15327543[["εNFA2-18 post-regex start"]]
class eNFA2_18_15327543 c0010;
eNFA1_23_4724260[\"εNFA1-23 post-regex end"/]
class eNFA1_23_4724260 c0001;
eNFA2_19_48753600[\"εNFA2-19 post-regex end"/]
class eNFA2_19_48753600 c0001;
eNFA0_0_51969174 -.->|"ε"|eNFA1_20_63577855
eNFA0_0_51969174 -.->|"ε"|eNFA2_16_65069390
eNFA0_0_51969174 -.->|"ε"|eNFA3_5_34933209
eNFA1_20_63577855 -.->|"ε
BeginToken 'Vt'"|eNFA1_0_35329788
eNFA2_16_65069390 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_56727555
eNFA3_5_34933209 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_11017648
eNFA1_0_35329788 -->|"'"|eNFA1_1_48995250
eNFA2_0_56727555 -->|"/"|eNFA2_1_38304072
eNFA3_0_11017648 -->|"/"|eNFA3_1_9192332
eNFA1_1_48995250 -.->|"ε"|eNFA1_4_47990424
eNFA2_1_38304072 -.->|"ε"|eNFA2_2_15622127
eNFA3_1_9192332 -.->|"ε"|eNFA3_2_6381418
eNFA1_4_47990424 -.->|"ε"|eNFA1_2_62019111
eNFA1_4_47990424 -.->|"ε"|eNFA1_6_29260633
eNFA1_4_47990424 -.->|"ε"|eNFA1_10_21301090
eNFA1_4_47990424 -.->|"ε"|eNFA1_12_57492083
eNFA1_4_47990424 -.->|"ε"|eNFA1_16_47666699
eNFA2_2_15622127 -->|"*"|eNFA2_3_58391916
eNFA3_2_6381418 -->|"/"|eNFA3_3_33571453
eNFA1_2_62019111 -->|"[#32;-&]"|eNFA1_3_53740895
eNFA1_6_29260633 -->|"#92;"|eNFA1_7_9040176
eNFA1_10_21301090 -->|"[(-[]"|eNFA1_11_26347107
eNFA1_12_57492083 -->|"#92;"|eNFA1_13_14252720
eNFA1_16_47666699 -->|"[]-~]"|eNFA1_17_13906014
eNFA2_3_58391916 -.->|"ε"|eNFA2_6_42518340
eNFA3_3_33571453 -.->|"ε"|eNFA3_4_3730161
eNFA1_3_53740895 -.->|"ε"|eNFA1_5_35797372
eNFA1_7_9040176 -.->|"ε"|eNFA1_8_61165617
eNFA1_11_26347107 -.->|"ε"|eNFA1_5_35797372
eNFA1_13_14252720 -.->|"ε"|eNFA1_14_63718061
eNFA1_17_13906014 -.->|"ε"|eNFA1_5_35797372
eNFA2_6_42518340 -.->|"ε"|eNFA2_4_21433500
eNFA2_6_42518340 -.->|"ε"|eNFA2_8_47120742
eNFA2_6_42518340 -.->|"ε"|eNFA2_7_58683773
eNFA3_4_3730161 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_3730161
eNFA3_4_3730161 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_33707629
eNFA1_5_35797372 -.->|"ε"|eNFA1_4_58045264
eNFA1_8_61165617 -->|"'"|eNFA1_9_3672298
eNFA1_14_63718061 -->|"#92;"|eNFA1_15_33050690
eNFA2_4_21433500 -->|"[^*]"|eNFA2_5_32124765
eNFA2_8_47120742 -->|"[*]"|eNFA2_9_9362127
eNFA2_7_58683773 -.->|"ε"|eNFA2_6_42518340
eNFA2_7_58683773 -.->|"ε"|eNFA2_12_55765201
eNFA3_6_33707629 -.->|"ε"|eNFA3_7_32049974
eNFA1_4_58045264 -.->|"ε"|eNFA1_2_4045982
eNFA1_4_58045264 -.->|"ε"|eNFA1_6_52645336
eNFA1_4_58045264 -.->|"ε"|eNFA1_10_36413843
eNFA1_4_58045264 -.->|"ε"|eNFA1_12_59289136
eNFA1_4_58045264 -.->|"ε"|eNFA1_16_63840183
eNFA1_4_58045264 -.->|"ε"|eNFA1_5_37690735
eNFA1_9_3672298 -.->|"ε"|eNFA1_5_35797372
eNFA1_15_33050690 -.->|"ε"|eNFA1_5_35797372
eNFA2_5_32124765 -.->|"ε"|eNFA2_7_58683773
eNFA2_9_9362127 -.->|"ε"|eNFA2_10_64616609
eNFA2_12_55765201 -->|"*"|eNFA2_13_44678570
eNFA3_7_32049974 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_45963425
eNFA1_2_4045982 -->|"[#32;-&]"|eNFA1_3_59860242
eNFA1_6_52645336 -->|"#92;"|eNFA1_7_66562817
eNFA1_10_36413843 -->|"[(-[]"|eNFA1_11_1871268
eNFA1_12_59289136 -->|"#92;"|eNFA1_13_62194446
eNFA1_16_63840183 -->|"[]-~]"|eNFA1_17_16841414
eNFA1_5_37690735 -.->|"ε"|eNFA1_4_58045264
eNFA1_5_37690735 -.->|"ε"|eNFA1_18_29020759
eNFA2_10_64616609 -->|"[^/]"|eNFA2_11_20687433
eNFA2_13_44678570 -.->|"ε"|eNFA2_14_4585366
eNFA3_8_45963425 -.->|"ε"|eNFA0_1_36129223
eNFA1_3_59860242 -.->|"ε"|eNFA1_5_37690735
eNFA1_7_66562817 -.->|"ε"|eNFA1_8_35870379
eNFA1_11_1871268 -.->|"ε"|eNFA1_5_37690735
eNFA1_13_62194446 -.->|"ε"|eNFA1_14_19819572
eNFA1_17_16841414 -.->|"ε"|eNFA1_5_37690735
eNFA1_18_29020759 -->|"'"|eNFA1_19_49532637
eNFA2_11_20687433 -.->|"ε"|eNFA2_7_58683773
eNFA2_14_4585366 -->|"/"|eNFA2_15_40785949
eNFA1_8_35870379 -->|"'"|eNFA1_9_17355001
eNFA1_14_19819572 -->|"#92;"|eNFA1_15_21977287
eNFA1_19_49532637 -.->|"ε
ExtendToken 'Vt'"|eNFA1_21_43140557
eNFA2_15_40785949 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_31529222
eNFA1_9_17355001 -.->|"ε"|eNFA1_5_37690735
eNFA1_15_21977287 -.->|"ε"|eNFA1_5_37690735
eNFA1_21_43140557 -.->|"ε"|eNFA1_22_52720700
eNFA2_17_31529222 -.->|"ε"|eNFA2_18_15327543
eNFA1_22_52720700 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA1_23_4724260
eNFA2_18_15327543 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_48753600
eNFA1_23_4724260 -.->|"ε"|eNFA0_1_36129223
eNFA2_19_48753600 -.->|"ε"|eNFA0_1_36129223

```

## 2/5: completed ε-NFA

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
eNFA0_0_20014316[["εNFA0-0 wholeStart"]]
class eNFA0_0_20014316 c1000;
eNFA1_20_10546933[["εNFA1-20 regex start"]]
class eNFA1_20_10546933 c1000;
eNFA2_16_45911124[["εNFA2-16 regex start"]]
class eNFA2_16_45911124 c1000;
eNFA3_5_27813538[["εNFA3-5 regex start"]]
class eNFA3_5_27813538 c1000;
eNFA1_0_17884854[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_17884854 c1000;
eNFA2_0_36238473[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_36238473 c1000;
eNFA3_0_61026205[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_61026205 c1000;
eNFA1_1_44175572[["εNFA1-1 char[1]"]]
eNFA2_1_62035831[["εNFA2-1 char[1]"]]
eNFA3_1_58846418[["εNFA3-1 char[1]"]]
eNFA1_4_57432766[["εNFA1-4 regex start"]]
eNFA1_2_21542494[["εNFA1-2 scope{1, 1}"]]
eNFA1_6_47132853[["εNFA1-6 char{1, 1}"]]
eNFA1_10_59664724[["εNFA1-10 scope{1, 1}"]]
eNFA1_12_111607[["εNFA1-12 char{1, 1}"]]
eNFA1_16_1004464[["εNFA1-16 scope{1, 1}"]]
eNFA1_3_29449405[["εNFA1-3 scope[1]"]]
eNFA1_7_16474764[["εNFA1-7 char[1]"]]
eNFA1_11_13619644[["εNFA1-11 scope[1]"]]
eNFA1_13_59387477[["εNFA1-13 char[1]"]]
eNFA1_17_36591643[["εNFA1-17 scope[1]"]]
eNFA2_2_1830529[["εNFA2-2 char{1, 1}"]]
eNFA2_3_17150281[["εNFA2-3 char[1]"]]
eNFA3_2_59855715[["εNFA3-2 char{1, 1}"]]
eNFA3_3_29941743[\"εNFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA3_3_29941743 c0111;
eNFA1_5_55467939[["εNFA1-5 regex end"]]
eNFA1_4_46995502[["εNFA1-4 regex start"]]
eNFA1_2_48539332[["εNFA1-2 scope{1, 1}"]]
eNFA1_6_20306340[["εNFA1-6 char{1, 1}"]]
eNFA1_10_34200809[["εNFA1-10 scope{1, 1}"]]
eNFA1_12_39371826[["εNFA1-12 char{1, 1}"]]
eNFA1_16_18802122[["εNFA1-16 scope{1, 1}"]]
eNFA1_5_35001377[["εNFA1-5 regex end"]]
eNFA1_3_41268299[["εNFA1-3 scope[1]"]]
eNFA1_7_64550954[["εNFA1-7 char[1]"]]
eNFA1_11_54397957[["εNFA1-11 scope[1]"]]
eNFA1_13_61244824[["εNFA1-13 char[1]"]]
eNFA1_17_44158424[["εNFA1-17 scope[1]"]]
eNFA1_18_22879106[["εNFA1-18 char{1, 1}"]]
eNFA1_19_26745965[\"εNFA1-19 char[1]
AcceptToken 'Vt'"/]
class eNFA1_19_26745965 c0111;
eNFA1_8_14055149[["εNFA1-8 char{1, 1}"]]
eNFA1_9_46576945[["εNFA1-9 char[1]"]]
eNFA1_14_64725245[["εNFA1-14 char{1, 1}"]]
eNFA1_15_16539321[["εNFA1-15 char[1]"]]
eNFA2_6_60889336[["εNFA2-6 regex start"]]
eNFA2_4_33089196[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_11133117[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_29367308[["εNFA2-7 regex end"]]
eNFA2_5_14636163[["εNFA2-5 scope[1]"]]
eNFA2_9_45656294[["εNFA2-9 scope[1]"]]
eNFA2_12_20134803[["εNFA2-12 char{1, 1}"]]
eNFA2_13_7172328[["εNFA2-13 char[1]"]]
eNFA3_4_62979183[\"εNFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA3_4_62979183 c0111;
eNFA3_6_1040236[\"εNFA3-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA3_6_1040236 c0111;
eNFA3_7_12364937[\"εNFA3-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA3_7_12364937 c0011;
eNFA3_8_30046962[\"εNFA3-8 post-regex end"/]
class eNFA3_8_30046962 c0011;
eNFA0_1_62990874[\"εNFA0-1 wholeEnd"/]
eNFA1_8_44087682[["εNFA1-8 char{1, 1}"]]
eNFA1_9_20062571[["εNFA1-9 char[1]"]]
eNFA1_14_14332509[["εNFA1-14 char{1, 1}"]]
eNFA1_15_46345412[["εNFA1-15 char[1]"]]
eNFA1_21_39387099[\"εNFA1-21 regex end
AcceptToken 'Vt'"/]
class eNFA1_21_39387099 c0111;
eNFA1_22_18939577[\"εNFA1-22 post-regex start
AcceptToken 'Vt'"/]
class eNFA1_22_18939577 c0011;
eNFA1_23_14455526[\"εNFA1-23 post-regex end"/]
class eNFA1_23_14455526 c0011;
eNFA2_10_8253465[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_61881498[["εNFA2-11 scope[1]"]]
eNFA2_14_21451571[["εNFA2-14 char{1, 1}"]]
eNFA2_15_57710802[\"εNFA2-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA2_15_57710802 c0111;
eNFA2_17_49635175[\"εNFA2-17 regex end
AcceptToken 'blockComment'"/]
class eNFA2_17_49635175 c0111;
eNFA2_18_44063391[\"εNFA2-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA2_18_44063391 c0011;
eNFA2_19_1987206[\"εNFA2-19 post-regex end"/]
class eNFA2_19_1987206 c0011;
eNFA0_0_20014316 -.->|"ε"|eNFA1_20_10546933
eNFA0_0_20014316 -.->|"ε"|eNFA2_16_45911124
eNFA0_0_20014316 -.->|"ε"|eNFA3_5_27813538
eNFA0_0_20014316 -.->|"ε
BeginToken 'Vt'"|eNFA1_0_17884854
eNFA0_0_20014316 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_36238473
eNFA0_0_20014316 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_61026205
eNFA0_0_20014316 -->|"'
BeginToken 'Vt'"|eNFA1_1_44175572
eNFA0_0_20014316 -->|"/
BeginToken 'blockComment'"|eNFA2_1_62035831
eNFA0_0_20014316 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_58846418
eNFA1_20_10546933 -.->|"ε
BeginToken 'Vt'"|eNFA1_0_17884854
eNFA1_20_10546933 -->|"'
BeginToken 'Vt'"|eNFA1_1_44175572
eNFA2_16_45911124 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_36238473
eNFA2_16_45911124 -->|"/
BeginToken 'blockComment'"|eNFA2_1_62035831
eNFA3_5_27813538 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_61026205
eNFA3_5_27813538 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_58846418
eNFA1_0_17884854 -->|"'
BeginToken 'Vt'"|eNFA1_1_44175572
eNFA2_0_36238473 -->|"/
BeginToken 'blockComment'"|eNFA2_1_62035831
eNFA3_0_61026205 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_58846418
eNFA1_1_44175572 -.->|"ε"|eNFA1_4_57432766
eNFA1_1_44175572 -.->|"ε"|eNFA1_2_21542494
eNFA1_1_44175572 -.->|"ε"|eNFA1_6_47132853
eNFA1_1_44175572 -.->|"ε"|eNFA1_10_59664724
eNFA1_1_44175572 -.->|"ε"|eNFA1_12_111607
eNFA1_1_44175572 -.->|"ε"|eNFA1_16_1004464
eNFA1_1_44175572 -->|"[#32;-&]"|eNFA1_3_29449405
eNFA1_1_44175572 -->|"#92;"|eNFA1_7_16474764
eNFA1_1_44175572 -->|"[(-[]"|eNFA1_11_13619644
eNFA1_1_44175572 -->|"#92;"|eNFA1_13_59387477
eNFA1_1_44175572 -->|"[]-~]"|eNFA1_17_36591643
eNFA2_1_62035831 -.->|"ε"|eNFA2_2_1830529
eNFA2_1_62035831 -->|"*"|eNFA2_3_17150281
eNFA3_1_58846418 -.->|"ε"|eNFA3_2_59855715
eNFA3_1_58846418 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_29941743
eNFA1_4_57432766 -.->|"ε"|eNFA1_2_21542494
eNFA1_4_57432766 -.->|"ε"|eNFA1_6_47132853
eNFA1_4_57432766 -.->|"ε"|eNFA1_10_59664724
eNFA1_4_57432766 -.->|"ε"|eNFA1_12_111607
eNFA1_4_57432766 -.->|"ε"|eNFA1_16_1004464
eNFA1_4_57432766 -->|"[#32;-&]"|eNFA1_3_29449405
eNFA1_4_57432766 -->|"#92;"|eNFA1_7_16474764
eNFA1_4_57432766 -->|"[(-[]"|eNFA1_11_13619644
eNFA1_4_57432766 -->|"#92;"|eNFA1_13_59387477
eNFA1_4_57432766 -->|"[]-~]"|eNFA1_17_36591643
eNFA1_2_21542494 -->|"[#32;-&]"|eNFA1_3_29449405
eNFA1_6_47132853 -->|"#92;"|eNFA1_7_16474764
eNFA1_10_59664724 -->|"[(-[]"|eNFA1_11_13619644
eNFA1_12_111607 -->|"#92;"|eNFA1_13_59387477
eNFA1_16_1004464 -->|"[]-~]"|eNFA1_17_36591643
eNFA1_3_29449405 -.->|"ε"|eNFA1_5_55467939
eNFA1_3_29449405 -.->|"ε"|eNFA1_4_46995502
eNFA1_3_29449405 -.->|"ε"|eNFA1_2_48539332
eNFA1_3_29449405 -.->|"ε"|eNFA1_6_20306340
eNFA1_3_29449405 -.->|"ε"|eNFA1_10_34200809
eNFA1_3_29449405 -.->|"ε"|eNFA1_12_39371826
eNFA1_3_29449405 -.->|"ε"|eNFA1_16_18802122
eNFA1_3_29449405 -.->|"ε"|eNFA1_5_35001377
eNFA1_3_29449405 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_3_29449405 -->|"#92;"|eNFA1_7_64550954
eNFA1_3_29449405 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_3_29449405 -->|"#92;"|eNFA1_13_61244824
eNFA1_3_29449405 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_3_29449405 -.->|"ε"|eNFA1_18_22879106
eNFA1_3_29449405 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_7_16474764 -.->|"ε"|eNFA1_8_14055149
eNFA1_7_16474764 -->|"'"|eNFA1_9_46576945
eNFA1_11_13619644 -.->|"ε"|eNFA1_5_55467939
eNFA1_11_13619644 -.->|"ε"|eNFA1_4_46995502
eNFA1_11_13619644 -.->|"ε"|eNFA1_2_48539332
eNFA1_11_13619644 -.->|"ε"|eNFA1_6_20306340
eNFA1_11_13619644 -.->|"ε"|eNFA1_10_34200809
eNFA1_11_13619644 -.->|"ε"|eNFA1_12_39371826
eNFA1_11_13619644 -.->|"ε"|eNFA1_16_18802122
eNFA1_11_13619644 -.->|"ε"|eNFA1_5_35001377
eNFA1_11_13619644 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_11_13619644 -->|"#92;"|eNFA1_7_64550954
eNFA1_11_13619644 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_11_13619644 -->|"#92;"|eNFA1_13_61244824
eNFA1_11_13619644 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_11_13619644 -.->|"ε"|eNFA1_18_22879106
eNFA1_11_13619644 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_13_59387477 -.->|"ε"|eNFA1_14_64725245
eNFA1_13_59387477 -->|"#92;"|eNFA1_15_16539321
eNFA1_17_36591643 -.->|"ε"|eNFA1_5_55467939
eNFA1_17_36591643 -.->|"ε"|eNFA1_4_46995502
eNFA1_17_36591643 -.->|"ε"|eNFA1_2_48539332
eNFA1_17_36591643 -.->|"ε"|eNFA1_6_20306340
eNFA1_17_36591643 -.->|"ε"|eNFA1_10_34200809
eNFA1_17_36591643 -.->|"ε"|eNFA1_12_39371826
eNFA1_17_36591643 -.->|"ε"|eNFA1_16_18802122
eNFA1_17_36591643 -.->|"ε"|eNFA1_5_35001377
eNFA1_17_36591643 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_17_36591643 -->|"#92;"|eNFA1_7_64550954
eNFA1_17_36591643 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_17_36591643 -->|"#92;"|eNFA1_13_61244824
eNFA1_17_36591643 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_17_36591643 -.->|"ε"|eNFA1_18_22879106
eNFA1_17_36591643 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA2_2_1830529 -->|"*"|eNFA2_3_17150281
eNFA2_3_17150281 -.->|"ε"|eNFA2_6_60889336
eNFA2_3_17150281 -.->|"ε"|eNFA2_4_33089196
eNFA2_3_17150281 -.->|"ε"|eNFA2_8_11133117
eNFA2_3_17150281 -.->|"ε"|eNFA2_7_29367308
eNFA2_3_17150281 -->|"[^*]"|eNFA2_5_14636163
eNFA2_3_17150281 -->|"[*]"|eNFA2_9_45656294
eNFA2_3_17150281 -.->|"ε"|eNFA2_12_20134803
eNFA2_3_17150281 -->|"*"|eNFA2_13_7172328
eNFA3_2_59855715 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_29941743
eNFA3_3_29941743 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_4_62979183
eNFA3_3_29941743 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_62979183
eNFA3_3_29941743 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_1040236
eNFA3_3_29941743 -.->|"ε"|eNFA3_7_12364937
eNFA3_3_29941743 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_30046962
eNFA3_3_29941743 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_62990874
eNFA1_5_55467939 -.->|"ε"|eNFA1_4_46995502
eNFA1_5_55467939 -.->|"ε"|eNFA1_2_48539332
eNFA1_5_55467939 -.->|"ε"|eNFA1_6_20306340
eNFA1_5_55467939 -.->|"ε"|eNFA1_10_34200809
eNFA1_5_55467939 -.->|"ε"|eNFA1_12_39371826
eNFA1_5_55467939 -.->|"ε"|eNFA1_16_18802122
eNFA1_5_55467939 -.->|"ε"|eNFA1_5_35001377
eNFA1_5_55467939 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_5_55467939 -->|"#92;"|eNFA1_7_64550954
eNFA1_5_55467939 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_5_55467939 -->|"#92;"|eNFA1_13_61244824
eNFA1_5_55467939 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_5_55467939 -.->|"ε"|eNFA1_18_22879106
eNFA1_5_55467939 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_4_46995502 -.->|"ε"|eNFA1_2_48539332
eNFA1_4_46995502 -.->|"ε"|eNFA1_6_20306340
eNFA1_4_46995502 -.->|"ε"|eNFA1_10_34200809
eNFA1_4_46995502 -.->|"ε"|eNFA1_12_39371826
eNFA1_4_46995502 -.->|"ε"|eNFA1_16_18802122
eNFA1_4_46995502 -.->|"ε"|eNFA1_5_35001377
eNFA1_4_46995502 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_4_46995502 -->|"#92;"|eNFA1_7_64550954
eNFA1_4_46995502 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_4_46995502 -->|"#92;"|eNFA1_13_61244824
eNFA1_4_46995502 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_4_46995502 -.->|"ε"|eNFA1_4_46995502
eNFA1_4_46995502 -.->|"ε"|eNFA1_18_22879106
eNFA1_4_46995502 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_2_48539332 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_6_20306340 -->|"#92;"|eNFA1_7_64550954
eNFA1_10_34200809 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_12_39371826 -->|"#92;"|eNFA1_13_61244824
eNFA1_16_18802122 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_5_35001377 -.->|"ε"|eNFA1_4_46995502
eNFA1_5_35001377 -.->|"ε"|eNFA1_18_22879106
eNFA1_5_35001377 -.->|"ε"|eNFA1_2_48539332
eNFA1_5_35001377 -.->|"ε"|eNFA1_6_20306340
eNFA1_5_35001377 -.->|"ε"|eNFA1_10_34200809
eNFA1_5_35001377 -.->|"ε"|eNFA1_12_39371826
eNFA1_5_35001377 -.->|"ε"|eNFA1_16_18802122
eNFA1_5_35001377 -.->|"ε"|eNFA1_5_35001377
eNFA1_5_35001377 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_5_35001377 -->|"#92;"|eNFA1_7_64550954
eNFA1_5_35001377 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_5_35001377 -->|"#92;"|eNFA1_13_61244824
eNFA1_5_35001377 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_5_35001377 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_3_41268299 -.->|"ε"|eNFA1_5_35001377
eNFA1_3_41268299 -.->|"ε"|eNFA1_4_46995502
eNFA1_3_41268299 -.->|"ε"|eNFA1_18_22879106
eNFA1_3_41268299 -.->|"ε"|eNFA1_2_48539332
eNFA1_3_41268299 -.->|"ε"|eNFA1_6_20306340
eNFA1_3_41268299 -.->|"ε"|eNFA1_10_34200809
eNFA1_3_41268299 -.->|"ε"|eNFA1_12_39371826
eNFA1_3_41268299 -.->|"ε"|eNFA1_16_18802122
eNFA1_3_41268299 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_3_41268299 -->|"#92;"|eNFA1_7_64550954
eNFA1_3_41268299 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_3_41268299 -->|"#92;"|eNFA1_13_61244824
eNFA1_3_41268299 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_3_41268299 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_7_64550954 -.->|"ε"|eNFA1_8_44087682
eNFA1_7_64550954 -->|"'"|eNFA1_9_20062571
eNFA1_11_54397957 -.->|"ε"|eNFA1_5_35001377
eNFA1_11_54397957 -.->|"ε"|eNFA1_4_46995502
eNFA1_11_54397957 -.->|"ε"|eNFA1_18_22879106
eNFA1_11_54397957 -.->|"ε"|eNFA1_2_48539332
eNFA1_11_54397957 -.->|"ε"|eNFA1_6_20306340
eNFA1_11_54397957 -.->|"ε"|eNFA1_10_34200809
eNFA1_11_54397957 -.->|"ε"|eNFA1_12_39371826
eNFA1_11_54397957 -.->|"ε"|eNFA1_16_18802122
eNFA1_11_54397957 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_11_54397957 -->|"#92;"|eNFA1_7_64550954
eNFA1_11_54397957 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_11_54397957 -->|"#92;"|eNFA1_13_61244824
eNFA1_11_54397957 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_11_54397957 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_13_61244824 -.->|"ε"|eNFA1_14_14332509
eNFA1_13_61244824 -->|"#92;"|eNFA1_15_46345412
eNFA1_17_44158424 -.->|"ε"|eNFA1_5_35001377
eNFA1_17_44158424 -.->|"ε"|eNFA1_4_46995502
eNFA1_17_44158424 -.->|"ε"|eNFA1_18_22879106
eNFA1_17_44158424 -.->|"ε"|eNFA1_2_48539332
eNFA1_17_44158424 -.->|"ε"|eNFA1_6_20306340
eNFA1_17_44158424 -.->|"ε"|eNFA1_10_34200809
eNFA1_17_44158424 -.->|"ε"|eNFA1_12_39371826
eNFA1_17_44158424 -.->|"ε"|eNFA1_16_18802122
eNFA1_17_44158424 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_17_44158424 -->|"#92;"|eNFA1_7_64550954
eNFA1_17_44158424 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_17_44158424 -->|"#92;"|eNFA1_13_61244824
eNFA1_17_44158424 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_17_44158424 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_18_22879106 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_19_26745965 -.->|"ε
ExtendToken 'Vt'"|eNFA1_21_39387099
eNFA1_19_26745965 -.->|"ε"|eNFA1_22_18939577
eNFA1_19_26745965 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA1_23_14455526
eNFA1_19_26745965 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62990874
eNFA1_8_14055149 -->|"'"|eNFA1_9_46576945
eNFA1_9_46576945 -.->|"ε"|eNFA1_5_55467939
eNFA1_9_46576945 -.->|"ε"|eNFA1_4_46995502
eNFA1_9_46576945 -.->|"ε"|eNFA1_2_48539332
eNFA1_9_46576945 -.->|"ε"|eNFA1_6_20306340
eNFA1_9_46576945 -.->|"ε"|eNFA1_10_34200809
eNFA1_9_46576945 -.->|"ε"|eNFA1_12_39371826
eNFA1_9_46576945 -.->|"ε"|eNFA1_16_18802122
eNFA1_9_46576945 -.->|"ε"|eNFA1_5_35001377
eNFA1_9_46576945 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_9_46576945 -->|"#92;"|eNFA1_7_64550954
eNFA1_9_46576945 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_9_46576945 -->|"#92;"|eNFA1_13_61244824
eNFA1_9_46576945 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_9_46576945 -.->|"ε"|eNFA1_18_22879106
eNFA1_9_46576945 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_14_64725245 -->|"#92;"|eNFA1_15_16539321
eNFA1_15_16539321 -.->|"ε"|eNFA1_5_55467939
eNFA1_15_16539321 -.->|"ε"|eNFA1_4_46995502
eNFA1_15_16539321 -.->|"ε"|eNFA1_2_48539332
eNFA1_15_16539321 -.->|"ε"|eNFA1_6_20306340
eNFA1_15_16539321 -.->|"ε"|eNFA1_10_34200809
eNFA1_15_16539321 -.->|"ε"|eNFA1_12_39371826
eNFA1_15_16539321 -.->|"ε"|eNFA1_16_18802122
eNFA1_15_16539321 -.->|"ε"|eNFA1_5_35001377
eNFA1_15_16539321 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_15_16539321 -->|"#92;"|eNFA1_7_64550954
eNFA1_15_16539321 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_15_16539321 -->|"#92;"|eNFA1_13_61244824
eNFA1_15_16539321 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_15_16539321 -.->|"ε"|eNFA1_18_22879106
eNFA1_15_16539321 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA2_6_60889336 -.->|"ε"|eNFA2_4_33089196
eNFA2_6_60889336 -.->|"ε"|eNFA2_8_11133117
eNFA2_6_60889336 -.->|"ε"|eNFA2_7_29367308
eNFA2_6_60889336 -->|"[^*]"|eNFA2_5_14636163
eNFA2_6_60889336 -->|"[*]"|eNFA2_9_45656294
eNFA2_6_60889336 -.->|"ε"|eNFA2_6_60889336
eNFA2_6_60889336 -.->|"ε"|eNFA2_12_20134803
eNFA2_6_60889336 -->|"*"|eNFA2_13_7172328
eNFA2_4_33089196 -->|"[^*]"|eNFA2_5_14636163
eNFA2_8_11133117 -->|"[*]"|eNFA2_9_45656294
eNFA2_7_29367308 -.->|"ε"|eNFA2_6_60889336
eNFA2_7_29367308 -.->|"ε"|eNFA2_12_20134803
eNFA2_7_29367308 -.->|"ε"|eNFA2_4_33089196
eNFA2_7_29367308 -.->|"ε"|eNFA2_8_11133117
eNFA2_7_29367308 -.->|"ε"|eNFA2_7_29367308
eNFA2_7_29367308 -->|"[^*]"|eNFA2_5_14636163
eNFA2_7_29367308 -->|"[*]"|eNFA2_9_45656294
eNFA2_7_29367308 -->|"*"|eNFA2_13_7172328
eNFA2_5_14636163 -.->|"ε"|eNFA2_7_29367308
eNFA2_5_14636163 -.->|"ε"|eNFA2_6_60889336
eNFA2_5_14636163 -.->|"ε"|eNFA2_12_20134803
eNFA2_5_14636163 -.->|"ε"|eNFA2_4_33089196
eNFA2_5_14636163 -.->|"ε"|eNFA2_8_11133117
eNFA2_5_14636163 -->|"[^*]"|eNFA2_5_14636163
eNFA2_5_14636163 -->|"[*]"|eNFA2_9_45656294
eNFA2_5_14636163 -->|"*"|eNFA2_13_7172328
eNFA2_9_45656294 -.->|"ε"|eNFA2_10_8253465
eNFA2_9_45656294 -->|"[^/]"|eNFA2_11_61881498
eNFA2_12_20134803 -->|"*"|eNFA2_13_7172328
eNFA2_13_7172328 -.->|"ε"|eNFA2_14_21451571
eNFA2_13_7172328 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_57710802
eNFA3_4_62979183 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_62979183
eNFA3_4_62979183 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_1040236
eNFA3_4_62979183 -.->|"ε"|eNFA3_7_12364937
eNFA3_4_62979183 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_30046962
eNFA3_4_62979183 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_62990874
eNFA3_6_1040236 -.->|"ε"|eNFA3_7_12364937
eNFA3_6_1040236 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_30046962
eNFA3_6_1040236 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_62990874
eNFA3_7_12364937 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_30046962
eNFA3_7_12364937 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_62990874
eNFA3_8_30046962 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_62990874
eNFA1_8_44087682 -->|"'"|eNFA1_9_20062571
eNFA1_9_20062571 -.->|"ε"|eNFA1_5_35001377
eNFA1_9_20062571 -.->|"ε"|eNFA1_4_46995502
eNFA1_9_20062571 -.->|"ε"|eNFA1_18_22879106
eNFA1_9_20062571 -.->|"ε"|eNFA1_2_48539332
eNFA1_9_20062571 -.->|"ε"|eNFA1_6_20306340
eNFA1_9_20062571 -.->|"ε"|eNFA1_10_34200809
eNFA1_9_20062571 -.->|"ε"|eNFA1_12_39371826
eNFA1_9_20062571 -.->|"ε"|eNFA1_16_18802122
eNFA1_9_20062571 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_9_20062571 -->|"#92;"|eNFA1_7_64550954
eNFA1_9_20062571 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_9_20062571 -->|"#92;"|eNFA1_13_61244824
eNFA1_9_20062571 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_9_20062571 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_14_14332509 -->|"#92;"|eNFA1_15_46345412
eNFA1_15_46345412 -.->|"ε"|eNFA1_5_35001377
eNFA1_15_46345412 -.->|"ε"|eNFA1_4_46995502
eNFA1_15_46345412 -.->|"ε"|eNFA1_18_22879106
eNFA1_15_46345412 -.->|"ε"|eNFA1_2_48539332
eNFA1_15_46345412 -.->|"ε"|eNFA1_6_20306340
eNFA1_15_46345412 -.->|"ε"|eNFA1_10_34200809
eNFA1_15_46345412 -.->|"ε"|eNFA1_12_39371826
eNFA1_15_46345412 -.->|"ε"|eNFA1_16_18802122
eNFA1_15_46345412 -->|"[#32;-&]"|eNFA1_3_41268299
eNFA1_15_46345412 -->|"#92;"|eNFA1_7_64550954
eNFA1_15_46345412 -->|"[(-[]"|eNFA1_11_54397957
eNFA1_15_46345412 -->|"#92;"|eNFA1_13_61244824
eNFA1_15_46345412 -->|"[]-~]"|eNFA1_17_44158424
eNFA1_15_46345412 -->|"'
ExtendToken 'Vt'"|eNFA1_19_26745965
eNFA1_21_39387099 -.->|"ε"|eNFA1_22_18939577
eNFA1_21_39387099 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA1_23_14455526
eNFA1_21_39387099 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62990874
eNFA1_22_18939577 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA1_23_14455526
eNFA1_22_18939577 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62990874
eNFA1_23_14455526 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62990874
eNFA2_10_8253465 -->|"[^/]"|eNFA2_11_61881498
eNFA2_11_61881498 -.->|"ε"|eNFA2_7_29367308
eNFA2_11_61881498 -.->|"ε"|eNFA2_6_60889336
eNFA2_11_61881498 -.->|"ε"|eNFA2_12_20134803
eNFA2_11_61881498 -.->|"ε"|eNFA2_4_33089196
eNFA2_11_61881498 -.->|"ε"|eNFA2_8_11133117
eNFA2_11_61881498 -->|"[^*]"|eNFA2_5_14636163
eNFA2_11_61881498 -->|"[*]"|eNFA2_9_45656294
eNFA2_11_61881498 -->|"*"|eNFA2_13_7172328
eNFA2_14_21451571 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_57710802
eNFA2_15_57710802 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_49635175
eNFA2_15_57710802 -.->|"ε"|eNFA2_18_44063391
eNFA2_15_57710802 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_1987206
eNFA2_15_57710802 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_62990874
eNFA2_17_49635175 -.->|"ε"|eNFA2_18_44063391
eNFA2_17_49635175 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_1987206
eNFA2_17_49635175 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_62990874
eNFA2_18_44063391 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_1987206
eNFA2_18_44063391 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_62990874
eNFA2_19_1987206 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_62990874

```

## 3/5: NFA

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
NFA0_0_61883722("NFA0-0 wholeStart")
class NFA0_0_61883722 c1000;
NFA1_1_20082593("NFA1-1 char[1]")
NFA2_1_46525609("NFA2-1 char[1]")
NFA3_1_16077300("NFA3-1 char[1]")
NFA1_3_27192961("NFA1-3 scope[1]")
NFA1_7_10477980("NFA1-7 char[1]")
NFA1_11_43410060("NFA1-11 scope[1]")
NFA1_13_55146222("NFA1-13 char[1]")
NFA1_17_26553952("NFA1-17 scope[1]")
NFA2_3_64980542("NFA2-3 char[1]")
NFA3_3_37658979[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_37658979 c0101;
NFA1_3_30478473("NFA1-3 scope[1]")
NFA1_7_3386497("NFA1-7 char[1]")
NFA1_11_5870806("NFA1-11 scope[1]")
NFA1_13_52837255("NFA1-13 char[1]")
NFA1_17_5773255("NFA1-17 scope[1]")
NFA1_19_51959302[\"NFA1-19 char[1]
AcceptToken 'Vt'"/]
class NFA1_19_51959302 c0101;
NFA1_9_19618454("NFA1-9 char[1]")
NFA1_15_42348363("NFA1-15 char[1]")
NFA2_5_28932512("NFA2-5 scope[1]")
NFA2_9_47953966("NFA2-9 scope[1]")
NFA2_13_59066022("NFA2-13 char[1]")
NFA3_4_61832151[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_61832151 c0101;
NFA1_9_7665379("NFA1-9 char[1]")
NFA1_15_1879552("NFA1-15 char[1]")
NFA2_11_16915976("NFA2-11 scope[1]")
NFA2_15_45590951[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_45590951 c0101;
NFA0_0_61883722 -->|"'
BeginToken 'Vt'"|NFA1_1_20082593
NFA0_0_61883722 -->|"/
BeginToken 'blockComment'"|NFA2_1_46525609
NFA0_0_61883722 -->|"/
BeginToken 'inlineComment'"|NFA3_1_16077300
NFA1_1_20082593 -->|"[#32;-&]"|NFA1_3_27192961
NFA1_1_20082593 -->|"#92;"|NFA1_7_10477980
NFA1_1_20082593 -->|"[(-[]"|NFA1_11_43410060
NFA1_1_20082593 -->|"#92;"|NFA1_13_55146222
NFA1_1_20082593 -->|"[]-~]"|NFA1_17_26553952
NFA2_1_46525609 -->|"*"|NFA2_3_64980542
NFA3_1_16077300 -->|"/
ExtendToken 'inlineComment'"|NFA3_3_37658979
NFA1_3_27192961 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_3_27192961 -->|"#92;"|NFA1_7_3386497
NFA1_3_27192961 -->|"[(-[]"|NFA1_11_5870806
NFA1_3_27192961 -->|"#92;"|NFA1_13_52837255
NFA1_3_27192961 -->|"[]-~]"|NFA1_17_5773255
NFA1_3_27192961 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_7_10477980 -->|"'"|NFA1_9_19618454
NFA1_11_43410060 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_11_43410060 -->|"#92;"|NFA1_7_3386497
NFA1_11_43410060 -->|"[(-[]"|NFA1_11_5870806
NFA1_11_43410060 -->|"#92;"|NFA1_13_52837255
NFA1_11_43410060 -->|"[]-~]"|NFA1_17_5773255
NFA1_11_43410060 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_13_55146222 -->|"#92;"|NFA1_15_42348363
NFA1_17_26553952 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_17_26553952 -->|"#92;"|NFA1_7_3386497
NFA1_17_26553952 -->|"[(-[]"|NFA1_11_5870806
NFA1_17_26553952 -->|"#92;"|NFA1_13_52837255
NFA1_17_26553952 -->|"[]-~]"|NFA1_17_5773255
NFA1_17_26553952 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA2_3_64980542 -->|"[^*]"|NFA2_5_28932512
NFA2_3_64980542 -->|"[*]"|NFA2_9_47953966
NFA2_3_64980542 -->|"*"|NFA2_13_59066022
NFA3_3_37658979 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_61832151
NFA1_3_30478473 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_3_30478473 -->|"#92;"|NFA1_7_3386497
NFA1_3_30478473 -->|"[(-[]"|NFA1_11_5870806
NFA1_3_30478473 -->|"#92;"|NFA1_13_52837255
NFA1_3_30478473 -->|"[]-~]"|NFA1_17_5773255
NFA1_3_30478473 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_7_3386497 -->|"'"|NFA1_9_7665379
NFA1_11_5870806 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_11_5870806 -->|"#92;"|NFA1_7_3386497
NFA1_11_5870806 -->|"[(-[]"|NFA1_11_5870806
NFA1_11_5870806 -->|"#92;"|NFA1_13_52837255
NFA1_11_5870806 -->|"[]-~]"|NFA1_17_5773255
NFA1_11_5870806 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_13_52837255 -->|"#92;"|NFA1_15_1879552
NFA1_17_5773255 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_17_5773255 -->|"#92;"|NFA1_7_3386497
NFA1_17_5773255 -->|"[(-[]"|NFA1_11_5870806
NFA1_17_5773255 -->|"#92;"|NFA1_13_52837255
NFA1_17_5773255 -->|"[]-~]"|NFA1_17_5773255
NFA1_17_5773255 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_9_19618454 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_9_19618454 -->|"#92;"|NFA1_7_3386497
NFA1_9_19618454 -->|"[(-[]"|NFA1_11_5870806
NFA1_9_19618454 -->|"#92;"|NFA1_13_52837255
NFA1_9_19618454 -->|"[]-~]"|NFA1_17_5773255
NFA1_9_19618454 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_15_42348363 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_15_42348363 -->|"#92;"|NFA1_7_3386497
NFA1_15_42348363 -->|"[(-[]"|NFA1_11_5870806
NFA1_15_42348363 -->|"#92;"|NFA1_13_52837255
NFA1_15_42348363 -->|"[]-~]"|NFA1_17_5773255
NFA1_15_42348363 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA2_5_28932512 -->|"[^*]"|NFA2_5_28932512
NFA2_5_28932512 -->|"[*]"|NFA2_9_47953966
NFA2_5_28932512 -->|"*"|NFA2_13_59066022
NFA2_9_47953966 -->|"[^/]"|NFA2_11_16915976
NFA2_13_59066022 -->|"/
ExtendToken 'blockComment'"|NFA2_15_45590951
NFA3_4_61832151 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_61832151
NFA1_9_7665379 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_9_7665379 -->|"#92;"|NFA1_7_3386497
NFA1_9_7665379 -->|"[(-[]"|NFA1_11_5870806
NFA1_9_7665379 -->|"#92;"|NFA1_13_52837255
NFA1_9_7665379 -->|"[]-~]"|NFA1_17_5773255
NFA1_9_7665379 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA1_15_1879552 -->|"[#32;-&]"|NFA1_3_30478473
NFA1_15_1879552 -->|"#92;"|NFA1_7_3386497
NFA1_15_1879552 -->|"[(-[]"|NFA1_11_5870806
NFA1_15_1879552 -->|"#92;"|NFA1_13_52837255
NFA1_15_1879552 -->|"[]-~]"|NFA1_17_5773255
NFA1_15_1879552 -->|"'
ExtendToken 'Vt'"|NFA1_19_51959302
NFA2_11_16915976 -->|"[^*]"|NFA2_5_28932512
NFA2_11_16915976 -->|"[*]"|NFA2_9_47953966
NFA2_11_16915976 -->|"*"|NFA2_13_59066022

```

## 4/5: DFA

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
subgraph DFA0_-1886755368["DFA0 wholeStart"]
NFA0_0_61883722_0("NFA0-0 wholeStart")
class NFA0_0_61883722_0 c1000;
end
class DFA0_-1886755368 c1000;
subgraph DFA1_1956429315["DFA1 {1}"]
NFA1_1_20082593_1("NFA1-1 char[1]")
end
subgraph DFA2_1421118946["DFA2 {2}"]
NFA2_1_46525609_2("NFA2-1 char[1]")
NFA3_1_16077300_3("NFA3-1 char[1]")
end
subgraph DFA3_-415452416["DFA3 {1}"]
NFA1_3_27192961_4("NFA1-3 scope[1]")
end
subgraph DFA4_95198903["DFA4 {2}"]
NFA1_7_10477980_5("NFA1-7 char[1]")
NFA1_13_55146222_6("NFA1-13 char[1]")
end
subgraph DFA5_1948330881["DFA5 {1}"]
NFA1_11_43410060_7("NFA1-11 scope[1]")
end
subgraph DFA6_905451214["DFA6 {1}"]
NFA1_17_26553952_8("NFA1-17 scope[1]")
end
subgraph DFA7_-538425657["DFA7 {1}"]
NFA2_3_64980542_9("NFA2-3 char[1]")
end
subgraph DFA8_-1701333853["DFA8 {1}"]
NFA3_3_37658979_10[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_37658979_10 c0101;
end
class DFA8_-1701333853 c0101;
subgraph DFA9_-1311747221["DFA9 {1}"]
NFA1_3_30478473_11("NFA1-3 scope[1]")
end
subgraph DFA10_-254751849["DFA10 {2}"]
NFA1_7_3386497_12("NFA1-7 char[1]")
NFA1_13_52837255_13("NFA1-13 char[1]")
end
subgraph DFA11_-449682177["DFA11 {1}"]
NFA1_11_5870806_14("NFA1-11 scope[1]")
end
subgraph DFA12_-1033233929["DFA12 {1}"]
NFA1_17_5773255_15("NFA1-17 scope[1]")
end
subgraph DFA13_690596106["DFA13 {1}"]
NFA1_19_51959302_16[\"NFA1-19 char[1]
AcceptToken 'Vt'"/]
class NFA1_19_51959302_16 c0101;
end
class DFA13_690596106 c0101;
subgraph DFA14_1430090931["DFA14 {1}"]
NFA1_9_19618454_17("NFA1-9 char[1]")
end
subgraph DFA15_-648423267["DFA15 {1}"]
NFA1_15_42348363_18("NFA1-15 char[1]")
end
subgraph DFA16_1342029314["DFA16 {1}"]
NFA2_5_28932512_19("NFA2-5 scope[1]")
end
subgraph DFA17_1146355159["DFA17 {2}"]
NFA2_9_47953966_20("NFA2-9 scope[1]")
NFA2_13_59066022_21("NFA2-13 char[1]")
end
subgraph DFA18_1669777229["DFA18 {1}"]
NFA3_4_61832151_22[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_61832151_22 c0101;
end
class DFA18_1669777229 c0101;
subgraph DFA19_-2073531689["DFA19 {1}"]
NFA1_9_7665379_23("NFA1-9 char[1]")
end
subgraph DFA20_1157014439["DFA20 {1}"]
NFA1_15_1879552_24("NFA1-15 char[1]")
end
subgraph DFA21_244242361["DFA21 {1}"]
NFA2_11_16915976_25("NFA2-11 scope[1]")
end
subgraph DFA22_1486256129["DFA22 {1}"]
NFA2_15_45590951_26[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_45590951_26 c0101;
end
class DFA22_1486256129 c0101;
DFA0_-1886755368 -->|"'
BeginToken 'Vt'"|DFA1_1956429315
DFA0_-1886755368 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_1421118946
DFA1_1956429315 -->|"[#32;-&]"|DFA3_-415452416
DFA1_1956429315 -->|"#92;"|DFA4_95198903
DFA1_1956429315 -->|"[(-[]"|DFA5_1948330881
DFA1_1956429315 -->|"[]-~]"|DFA6_905451214
DFA2_1421118946 -->|"*"|DFA7_-538425657
DFA2_1421118946 -->|"/
ExtendToken 'inlineComment'"|DFA8_-1701333853
DFA3_-415452416 -->|"[#32;-&]"|DFA9_-1311747221
DFA3_-415452416 -->|"#92;"|DFA10_-254751849
DFA3_-415452416 -->|"[(-[]"|DFA11_-449682177
DFA3_-415452416 -->|"[]-~]"|DFA12_-1033233929
DFA3_-415452416 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA4_95198903 -->|"'"|DFA14_1430090931
DFA4_95198903 -->|"#92;"|DFA15_-648423267
DFA5_1948330881 -->|"[#32;-&]"|DFA9_-1311747221
DFA5_1948330881 -->|"#92;"|DFA10_-254751849
DFA5_1948330881 -->|"[(-[]"|DFA11_-449682177
DFA5_1948330881 -->|"[]-~]"|DFA12_-1033233929
DFA5_1948330881 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA6_905451214 -->|"[#32;-&]"|DFA9_-1311747221
DFA6_905451214 -->|"#92;"|DFA10_-254751849
DFA6_905451214 -->|"[(-[]"|DFA11_-449682177
DFA6_905451214 -->|"[]-~]"|DFA12_-1033233929
DFA6_905451214 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA7_-538425657 -->|"[^*]"|DFA16_1342029314
DFA7_-538425657 -->|"*"|DFA17_1146355159
DFA8_-1701333853 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA18_1669777229
DFA9_-1311747221 -->|"[#32;-&]"|DFA9_-1311747221
DFA9_-1311747221 -->|"#92;"|DFA10_-254751849
DFA9_-1311747221 -->|"[(-[]"|DFA11_-449682177
DFA9_-1311747221 -->|"[]-~]"|DFA12_-1033233929
DFA9_-1311747221 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA10_-254751849 -->|"'"|DFA19_-2073531689
DFA10_-254751849 -->|"#92;"|DFA20_1157014439
DFA11_-449682177 -->|"[#32;-&]"|DFA9_-1311747221
DFA11_-449682177 -->|"#92;"|DFA10_-254751849
DFA11_-449682177 -->|"[(-[]"|DFA11_-449682177
DFA11_-449682177 -->|"[]-~]"|DFA12_-1033233929
DFA11_-449682177 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA12_-1033233929 -->|"[#32;-&]"|DFA9_-1311747221
DFA12_-1033233929 -->|"#92;"|DFA10_-254751849
DFA12_-1033233929 -->|"[(-[]"|DFA11_-449682177
DFA12_-1033233929 -->|"[]-~]"|DFA12_-1033233929
DFA12_-1033233929 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA14_1430090931 -->|"[#32;-&]"|DFA9_-1311747221
DFA14_1430090931 -->|"#92;"|DFA10_-254751849
DFA14_1430090931 -->|"[(-[]"|DFA11_-449682177
DFA14_1430090931 -->|"[]-~]"|DFA12_-1033233929
DFA14_1430090931 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA15_-648423267 -->|"[#32;-&]"|DFA9_-1311747221
DFA15_-648423267 -->|"#92;"|DFA10_-254751849
DFA15_-648423267 -->|"[(-[]"|DFA11_-449682177
DFA15_-648423267 -->|"[]-~]"|DFA12_-1033233929
DFA15_-648423267 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA16_1342029314 -->|"[^*]"|DFA16_1342029314
DFA16_1342029314 -->|"*"|DFA17_1146355159
DFA17_1146355159 -->|"[^/]"|DFA21_244242361
DFA17_1146355159 -->|"/
ExtendToken 'blockComment'"|DFA22_1486256129
DFA18_1669777229 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA18_1669777229
DFA19_-2073531689 -->|"[#32;-&]"|DFA9_-1311747221
DFA19_-2073531689 -->|"#92;"|DFA10_-254751849
DFA19_-2073531689 -->|"[(-[]"|DFA11_-449682177
DFA19_-2073531689 -->|"[]-~]"|DFA12_-1033233929
DFA19_-2073531689 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA20_1157014439 -->|"[#32;-&]"|DFA9_-1311747221
DFA20_1157014439 -->|"#92;"|DFA10_-254751849
DFA20_1157014439 -->|"[(-[]"|DFA11_-449682177
DFA20_1157014439 -->|"[]-~]"|DFA12_-1033233929
DFA20_1157014439 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA21_244242361 -->|"[^*]"|DFA16_1342029314
DFA21_244242361 -->|"*"|DFA17_1146355159

```

## 4/5: DFA.simple

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
DFA0_-1886755368{{"DFA0 wholeStart"}}
class DFA0_-1886755368 c1000;
DFA1_1956429315{{"DFA1 {1}"}}
DFA2_1421118946{{"DFA2 {2}"}}
DFA3_-415452416{{"DFA3 {1}"}}
DFA4_95198903{{"DFA4 {2}"}}
DFA5_1948330881{{"DFA5 {1}"}}
DFA6_905451214{{"DFA6 {1}"}}
DFA7_-538425657{{"DFA7 {1}"}}
DFA8_-1701333853[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_-1701333853 c0101;
DFA9_-1311747221{{"DFA9 {1}"}}
DFA10_-254751849{{"DFA10 {2}"}}
DFA11_-449682177{{"DFA11 {1}"}}
DFA12_-1033233929{{"DFA12 {1}"}}
DFA13_690596106[\"DFA13 {1}
AcceptToken 'Vt'"/]
class DFA13_690596106 c0101;
DFA14_1430090931{{"DFA14 {1}"}}
DFA15_-648423267{{"DFA15 {1}"}}
DFA16_1342029314{{"DFA16 {1}"}}
DFA17_1146355159{{"DFA17 {2}"}}
DFA18_1669777229[\"DFA18 {1}
AcceptToken 'inlineComment'"/]
class DFA18_1669777229 c0101;
DFA19_-2073531689{{"DFA19 {1}"}}
DFA20_1157014439{{"DFA20 {1}"}}
DFA21_244242361{{"DFA21 {1}"}}
DFA22_1486256129[\"DFA22 {1}
AcceptToken 'blockComment'"/]
class DFA22_1486256129 c0101;
DFA0_-1886755368 -->|"'
BeginToken 'Vt'"|DFA1_1956429315
DFA0_-1886755368 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_1421118946
DFA1_1956429315 -->|"[#32;-&]"|DFA3_-415452416
DFA1_1956429315 -->|"#92;"|DFA4_95198903
DFA1_1956429315 -->|"[(-[]"|DFA5_1948330881
DFA1_1956429315 -->|"[]-~]"|DFA6_905451214
DFA2_1421118946 -->|"*"|DFA7_-538425657
DFA2_1421118946 -->|"/
ExtendToken 'inlineComment'"|DFA8_-1701333853
DFA3_-415452416 -->|"[#32;-&]"|DFA9_-1311747221
DFA3_-415452416 -->|"#92;"|DFA10_-254751849
DFA3_-415452416 -->|"[(-[]"|DFA11_-449682177
DFA3_-415452416 -->|"[]-~]"|DFA12_-1033233929
DFA3_-415452416 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA4_95198903 -->|"'"|DFA14_1430090931
DFA4_95198903 -->|"#92;"|DFA15_-648423267
DFA5_1948330881 -->|"[#32;-&]"|DFA9_-1311747221
DFA5_1948330881 -->|"#92;"|DFA10_-254751849
DFA5_1948330881 -->|"[(-[]"|DFA11_-449682177
DFA5_1948330881 -->|"[]-~]"|DFA12_-1033233929
DFA5_1948330881 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA6_905451214 -->|"[#32;-&]"|DFA9_-1311747221
DFA6_905451214 -->|"#92;"|DFA10_-254751849
DFA6_905451214 -->|"[(-[]"|DFA11_-449682177
DFA6_905451214 -->|"[]-~]"|DFA12_-1033233929
DFA6_905451214 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA7_-538425657 -->|"[^*]"|DFA16_1342029314
DFA7_-538425657 -->|"*"|DFA17_1146355159
DFA8_-1701333853 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA18_1669777229
DFA9_-1311747221 -->|"[#32;-&]"|DFA9_-1311747221
DFA9_-1311747221 -->|"#92;"|DFA10_-254751849
DFA9_-1311747221 -->|"[(-[]"|DFA11_-449682177
DFA9_-1311747221 -->|"[]-~]"|DFA12_-1033233929
DFA9_-1311747221 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA10_-254751849 -->|"'"|DFA19_-2073531689
DFA10_-254751849 -->|"#92;"|DFA20_1157014439
DFA11_-449682177 -->|"[#32;-&]"|DFA9_-1311747221
DFA11_-449682177 -->|"#92;"|DFA10_-254751849
DFA11_-449682177 -->|"[(-[]"|DFA11_-449682177
DFA11_-449682177 -->|"[]-~]"|DFA12_-1033233929
DFA11_-449682177 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA12_-1033233929 -->|"[#32;-&]"|DFA9_-1311747221
DFA12_-1033233929 -->|"#92;"|DFA10_-254751849
DFA12_-1033233929 -->|"[(-[]"|DFA11_-449682177
DFA12_-1033233929 -->|"[]-~]"|DFA12_-1033233929
DFA12_-1033233929 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA14_1430090931 -->|"[#32;-&]"|DFA9_-1311747221
DFA14_1430090931 -->|"#92;"|DFA10_-254751849
DFA14_1430090931 -->|"[(-[]"|DFA11_-449682177
DFA14_1430090931 -->|"[]-~]"|DFA12_-1033233929
DFA14_1430090931 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA15_-648423267 -->|"[#32;-&]"|DFA9_-1311747221
DFA15_-648423267 -->|"#92;"|DFA10_-254751849
DFA15_-648423267 -->|"[(-[]"|DFA11_-449682177
DFA15_-648423267 -->|"[]-~]"|DFA12_-1033233929
DFA15_-648423267 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA16_1342029314 -->|"[^*]"|DFA16_1342029314
DFA16_1342029314 -->|"*"|DFA17_1146355159
DFA17_1146355159 -->|"[^/]"|DFA21_244242361
DFA17_1146355159 -->|"/
ExtendToken 'blockComment'"|DFA22_1486256129
DFA18_1669777229 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA18_1669777229
DFA19_-2073531689 -->|"[#32;-&]"|DFA9_-1311747221
DFA19_-2073531689 -->|"#92;"|DFA10_-254751849
DFA19_-2073531689 -->|"[(-[]"|DFA11_-449682177
DFA19_-2073531689 -->|"[]-~]"|DFA12_-1033233929
DFA19_-2073531689 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA20_1157014439 -->|"[#32;-&]"|DFA9_-1311747221
DFA20_1157014439 -->|"#92;"|DFA10_-254751849
DFA20_1157014439 -->|"[(-[]"|DFA11_-449682177
DFA20_1157014439 -->|"[]-~]"|DFA12_-1033233929
DFA20_1157014439 -->|"'
ExtendToken 'Vt'"|DFA13_690596106
DFA21_244242361 -->|"[^*]"|DFA16_1342029314
DFA21_244242361 -->|"*"|DFA17_1146355159

```

## 5/5: miniDFA

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
subgraph MiniDFA0_-167276511["MiniDFA0 {1}"]
DFA0_-1886755368_0{{"DFA0 wholeStart"}}
class DFA0_-1886755368_0 c1000;
end
class MiniDFA0_-167276511 c1000;
subgraph MiniDFA1_-1726103805["MiniDFA1 {1}"]
DFA1_1956429315_1{{"DFA1 {1}"}}
end
subgraph MiniDFA2_-455443324["MiniDFA2 {1}"]
DFA2_1421118946_2{{"DFA2 {2}"}}
end
subgraph MiniDFA3_233301716["MiniDFA3 {10}"]
DFA3_-415452416_3{{"DFA3 {1}"}}
DFA5_1948330881_4{{"DFA5 {1}"}}
DFA6_905451214_5{{"DFA6 {1}"}}
DFA9_-1311747221_6{{"DFA9 {1}"}}
DFA11_-449682177_7{{"DFA11 {1}"}}
DFA12_-1033233929_8{{"DFA12 {1}"}}
DFA14_1430090931_9{{"DFA14 {1}"}}
DFA15_-648423267_10{{"DFA15 {1}"}}
DFA19_-2073531689_11{{"DFA19 {1}"}}
DFA20_1157014439_12{{"DFA20 {1}"}}
end
subgraph MiniDFA4_130157675["MiniDFA4 {2}"]
DFA4_95198903_13{{"DFA4 {2}"}}
DFA10_-254751849_14{{"DFA10 {2}"}}
end
subgraph MiniDFA5_2143378522["MiniDFA5 {3}"]
DFA7_-538425657_15{{"DFA7 {1}"}}
DFA16_1342029314_16{{"DFA16 {1}"}}
DFA21_244242361_17{{"DFA21 {1}"}}
end
subgraph MiniDFA7_-1098229020["MiniDFA7 {1}"]
DFA8_-1701333853_18[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_-1701333853_18 c0101;
end
class MiniDFA7_-1098229020 c0101;
subgraph MiniDFA8_-1042464762["MiniDFA8 {1}"]
DFA13_690596106_19[\"DFA13 {1}
AcceptToken 'Vt'"/]
class DFA13_690596106_19 c0101;
end
class MiniDFA8_-1042464762 c0101;
subgraph MiniDFA6_-1206441414["MiniDFA6 {1}"]
DFA17_1146355159_20{{"DFA17 {2}"}}
end
subgraph MiniDFA9_-1517473471["MiniDFA9 {1}"]
DFA18_1669777229_21[\"DFA18 {1}
AcceptToken 'inlineComment'"/]
class DFA18_1669777229_21 c0101;
end
class MiniDFA9_-1517473471 c0101;
subgraph MiniDFA10_632201962["MiniDFA10 {1}"]
DFA22_1486256129_22[\"DFA22 {1}
AcceptToken 'blockComment'"/]
class DFA22_1486256129_22 c0101;
end
class MiniDFA10_632201962 c0101;
MiniDFA0_-167276511 -->|"'
BeginToken 'Vt'"|MiniDFA1_-1726103805
MiniDFA0_-167276511 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA2_-455443324
MiniDFA1_-1726103805 -->|"[#32;-&]"|MiniDFA3_233301716
MiniDFA1_-1726103805 -->|"#92;"|MiniDFA4_130157675
MiniDFA1_-1726103805 -->|"[(-[]"|MiniDFA3_233301716
MiniDFA1_-1726103805 -->|"[]-~]"|MiniDFA3_233301716
MiniDFA2_-455443324 -->|"*"|MiniDFA5_2143378522
MiniDFA2_-455443324 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-1098229020
MiniDFA3_233301716 -->|"[#32;-&]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"#92;"|MiniDFA4_130157675
MiniDFA3_233301716 -->|"[(-[]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"[]-~]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"'
ExtendToken 'Vt'"|MiniDFA8_-1042464762
MiniDFA4_130157675 -->|"'"|MiniDFA3_233301716
MiniDFA4_130157675 -->|"#92;"|MiniDFA3_233301716
MiniDFA5_2143378522 -->|"[^*]"|MiniDFA5_2143378522
MiniDFA5_2143378522 -->|"*"|MiniDFA6_-1206441414
MiniDFA7_-1098229020 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1517473471
MiniDFA6_-1206441414 -->|"[^/]"|MiniDFA5_2143378522
MiniDFA6_-1206441414 -->|"/
ExtendToken 'blockComment'"|MiniDFA10_632201962
MiniDFA9_-1517473471 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1517473471

```
## 5/5: miniDFA.simple

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
MiniDFA0_-167276511(["MiniDFA0 {1}"])
class MiniDFA0_-167276511 c1000;
MiniDFA1_-1726103805(["MiniDFA1 {1}"])
MiniDFA2_-455443324(["MiniDFA2 {1}"])
MiniDFA3_233301716(["MiniDFA3 {10}"])
MiniDFA4_130157675(["MiniDFA4 {2}"])
MiniDFA5_2143378522(["MiniDFA5 {3}"])
MiniDFA7_-1098229020[\"MiniDFA7 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA7_-1098229020 c0101;
MiniDFA8_-1042464762[\"MiniDFA8 {1}
AcceptToken 'Vt'"/]
class MiniDFA8_-1042464762 c0101;
MiniDFA6_-1206441414(["MiniDFA6 {1}"])
MiniDFA9_-1517473471[\"MiniDFA9 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA9_-1517473471 c0101;
MiniDFA10_632201962[\"MiniDFA10 {1}
AcceptToken 'blockComment'"/]
class MiniDFA10_632201962 c0101;
MiniDFA0_-167276511 -->|"'
BeginToken 'Vt'"|MiniDFA1_-1726103805
MiniDFA0_-167276511 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA2_-455443324
MiniDFA1_-1726103805 -->|"[#32;-&]"|MiniDFA3_233301716
MiniDFA1_-1726103805 -->|"#92;"|MiniDFA4_130157675
MiniDFA1_-1726103805 -->|"[(-[]"|MiniDFA3_233301716
MiniDFA1_-1726103805 -->|"[]-~]"|MiniDFA3_233301716
MiniDFA2_-455443324 -->|"*"|MiniDFA5_2143378522
MiniDFA2_-455443324 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_-1098229020
MiniDFA3_233301716 -->|"[#32;-&]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"#92;"|MiniDFA4_130157675
MiniDFA3_233301716 -->|"[(-[]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"[]-~]"|MiniDFA3_233301716
MiniDFA3_233301716 -->|"'
ExtendToken 'Vt'"|MiniDFA8_-1042464762
MiniDFA4_130157675 -->|"'"|MiniDFA3_233301716
MiniDFA4_130157675 -->|"#92;"|MiniDFA3_233301716
MiniDFA5_2143378522 -->|"[^*]"|MiniDFA5_2143378522
MiniDFA5_2143378522 -->|"*"|MiniDFA6_-1206441414
MiniDFA7_-1098229020 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1517473471
MiniDFA6_-1206441414 -->|"[^/]"|MiniDFA5_2143378522
MiniDFA6_-1206441414 -->|"/
ExtendToken 'blockComment'"|MiniDFA10_632201962
MiniDFA9_-1517473471 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1517473471

```

# 总结

无。

