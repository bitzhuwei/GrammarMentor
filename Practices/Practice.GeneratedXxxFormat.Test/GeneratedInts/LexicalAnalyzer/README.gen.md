# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Ints`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（10个State）。

## 'integer'
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
eNFA0_2_37996203[["εNFA0-2 regex start"]]
eNFA0_0_52079048[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_57982344[["εNFA0-1 scope[1]"]]
eNFA0_3_66058249[["εNFA0-3 regex end"]]
eNFA0_2_37996203 -.->|"ε"|eNFA0_0_52079048
eNFA0_0_52079048 -->|"[0-9]"|eNFA0_1_57982344
eNFA0_1_57982344 -->|"[0-9]"|eNFA0_1_57982344
eNFA0_1_57982344 -.->|"ε"|eNFA0_3_66058249
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
eNFA0_4_50769665[["εNFA0-4 post-regex start"]]
eNFA0_5_54273802[\"εNFA0-5 post-regex end"/]
eNFA0_4_50769665 -.->|"ε"|eNFA0_5_54273802
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
eNFA0_16_16438307[["εNFA0-16 regex start"]]
eNFA0_0_13727043[["εNFA0-0 char{1, 1}"]]
eNFA0_1_56434525[["εNFA0-1 char[1]"]]
eNFA0_2_38148684[["εNFA0-2 char{1, 1}"]]
eNFA0_3_23325828[["εNFA0-3 char[1]"]]
eNFA0_6_49117947[["εNFA0-6 regex start"]]
eNFA0_4_19130757[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_39408341[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_6087504[["εNFA0-7 regex end"]]
eNFA0_5_54787541[["εNFA0-5 scope[1]"]]
eNFA0_9_65540286[["εNFA0-9 scope[1]"]]
eNFA0_12_8605860[["εNFA0-12 char{1, 1}"]]
eNFA0_10_43328398[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_54411269[["εNFA0-13 char[1]"]]
eNFA0_11_37959091[["εNFA0-11 scope[1]"]]
eNFA0_14_19939379[["εNFA0-14 char{1, 1}"]]
eNFA0_15_4477025[["εNFA0-15 char[1]"]]
eNFA0_17_40293226[["εNFA0-17 regex end"]]
eNFA0_16_16438307 -.->|"ε"|eNFA0_0_13727043
eNFA0_0_13727043 -->|"/"|eNFA0_1_56434525
eNFA0_1_56434525 -.->|"ε"|eNFA0_2_38148684
eNFA0_2_38148684 -->|"*"|eNFA0_3_23325828
eNFA0_3_23325828 -.->|"ε"|eNFA0_6_49117947
eNFA0_6_49117947 -.->|"ε"|eNFA0_4_19130757
eNFA0_6_49117947 -.->|"ε"|eNFA0_8_39408341
eNFA0_6_49117947 -.->|"ε"|eNFA0_7_6087504
eNFA0_4_19130757 -->|"[^*]"|eNFA0_5_54787541
eNFA0_8_39408341 -->|"[*]"|eNFA0_9_65540286
eNFA0_7_6087504 -.->|"ε"|eNFA0_6_49117947
eNFA0_7_6087504 -.->|"ε"|eNFA0_12_8605860
eNFA0_5_54787541 -.->|"ε"|eNFA0_7_6087504
eNFA0_9_65540286 -.->|"ε"|eNFA0_10_43328398
eNFA0_12_8605860 -->|"*"|eNFA0_13_54411269
eNFA0_10_43328398 -->|"[^/]"|eNFA0_11_37959091
eNFA0_13_54411269 -.->|"ε"|eNFA0_14_19939379
eNFA0_11_37959091 -.->|"ε"|eNFA0_7_6087504
eNFA0_14_19939379 -->|"/"|eNFA0_15_4477025
eNFA0_15_4477025 -.->|"ε"|eNFA0_17_40293226
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
eNFA0_18_27094719[["εNFA0-18 post-regex start"]]
eNFA0_19_42525879[\"εNFA0-19 post-regex end"/]
eNFA0_18_27094719 -.->|"ε"|eNFA0_19_42525879
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
eNFA0_5_14797678[["εNFA0-5 regex start"]]
eNFA0_0_66070243[["εNFA0-0 char{1, 1}"]]
eNFA0_1_57761279[["εNFA0-1 char[1]"]]
eNFA0_2_50089467[["εNFA0-2 char{1, 1}"]]
eNFA0_3_25986055[["εNFA0-3 char[1]"]]
eNFA0_4_32547908[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_24495719[["εNFA0-6 regex end"]]
eNFA0_5_14797678 -.->|"ε"|eNFA0_0_66070243
eNFA0_0_66070243 -->|"/"|eNFA0_1_57761279
eNFA0_1_57761279 -.->|"ε"|eNFA0_2_50089467
eNFA0_2_50089467 -->|"/"|eNFA0_3_25986055
eNFA0_3_25986055 -.->|"ε"|eNFA0_4_32547908
eNFA0_4_32547908 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_32547908
eNFA0_4_32547908 -.->|"ε"|eNFA0_6_24495719
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
eNFA0_7_4890297[["εNFA0-7 post-regex start"]]
eNFA0_8_44012677[\"εNFA0-8 post-regex end"/]
eNFA0_7_4890297 -.->|"ε"|eNFA0_8_44012677
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
eNFA0_0_2365466[["εNFA0-0 wholeStart"]]
eNFA1_2_41913798[["εNFA1-2 regex start"]]
class eNFA1_2_41913798 c1000;
eNFA2_16_21289199[["εNFA2-16 regex start"]]
class eNFA2_16_21289199 c1000;
eNFA3_5_9548790[["εNFA3-5 regex start"]]
class eNFA3_5_9548790 c1000;
eNFA1_0_15430535[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_17679057[["εNFA2-0 char{1, 1}"]]
eNFA3_0_35254491[["εNFA3-0 char{1, 1}"]]
eNFA1_1_16627584[["εNFA1-1 scope[1]"]]
eNFA2_1_28090709[["εNFA2-1 char[1]"]]
eNFA3_1_51489795[["εNFA3-1 char[1]"]]
eNFA1_3_4657088[["εNFA1-3 regex end"]]
class eNFA1_3_4657088 c0100;
eNFA2_2_65633828[["εNFA2-2 char{1, 1}"]]
eNFA3_2_53833544[["εNFA3-2 char{1, 1}"]]
eNFA1_4_41679865[["εNFA1-4 post-regex start"]]
class eNFA1_4_41679865 c0010;
eNFA2_3_34889605[["εNFA2-3 char[1]"]]
eNFA3_3_52313669[["εNFA3-3 char[1]"]]
eNFA1_5_39574466[\"εNFA1-5 post-regex end"/]
class eNFA1_5_39574466 c0001;
eNFA2_6_20625874[["εNFA2-6 regex start"]]
eNFA3_4_28182251[["εNFA3-4 char{0, ∞}"]]
eNFA0_1_46703582[\"εNFA0-1 wholeEnd"/]
eNFA2_4_60083059[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_51415138[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_3876622[["εNFA2-7 regex end"]]
eNFA3_6_1060976[["εNFA3-6 regex end"]]
class eNFA3_6_1060976 c0100;
eNFA2_5_7485743[["εNFA2-5 scope[1]"]]
eNFA2_9_53939958[["εNFA2-9 scope[1]"]]
eNFA2_12_45570991[["εNFA2-12 char{1, 1}"]]
eNFA3_7_48854964[["εNFA3-7 post-regex start"]]
class eNFA3_7_48854964 c0010;
eNFA2_10_35026424[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_46802360[["εNFA2-13 char[1]"]]
eNFA3_8_18830246[\"εNFA3-8 post-regex end"/]
class eNFA3_8_18830246 c0001;
eNFA2_11_262829[["εNFA2-11 scope[1]"]]
eNFA2_14_18568063[["εNFA2-14 char{1, 1}"]]
eNFA2_15_24893793[["εNFA2-15 char[1]"]]
eNFA2_17_22717550[["εNFA2-17 regex end"]]
class eNFA2_17_22717550 c0100;
eNFA2_18_3131361[["εNFA2-18 post-regex start"]]
class eNFA2_18_3131361 c0010;
eNFA2_19_57385070[\"εNFA2-19 post-regex end"/]
class eNFA2_19_57385070 c0001;
eNFA0_0_2365466 -.->|"ε"|eNFA1_2_41913798
eNFA0_0_2365466 -.->|"ε"|eNFA2_16_21289199
eNFA0_0_2365466 -.->|"ε"|eNFA3_5_9548790
eNFA1_2_41913798 -.->|"ε
BeginToken 'integer'"|eNFA1_0_15430535
eNFA2_16_21289199 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_17679057
eNFA3_5_9548790 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_35254491
eNFA1_0_15430535 -->|"[0-9]"|eNFA1_1_16627584
eNFA2_0_17679057 -->|"/"|eNFA2_1_28090709
eNFA3_0_35254491 -->|"/"|eNFA3_1_51489795
eNFA1_1_16627584 -->|"[0-9]"|eNFA1_1_16627584
eNFA1_1_16627584 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_4657088
eNFA2_1_28090709 -.->|"ε"|eNFA2_2_65633828
eNFA3_1_51489795 -.->|"ε"|eNFA3_2_53833544
eNFA1_3_4657088 -.->|"ε"|eNFA1_4_41679865
eNFA2_2_65633828 -->|"*"|eNFA2_3_34889605
eNFA3_2_53833544 -->|"/"|eNFA3_3_52313669
eNFA1_4_41679865 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_39574466
eNFA2_3_34889605 -.->|"ε"|eNFA2_6_20625874
eNFA3_3_52313669 -.->|"ε"|eNFA3_4_28182251
eNFA1_5_39574466 -.->|"ε"|eNFA0_1_46703582
eNFA2_6_20625874 -.->|"ε"|eNFA2_4_60083059
eNFA2_6_20625874 -.->|"ε"|eNFA2_8_51415138
eNFA2_6_20625874 -.->|"ε"|eNFA2_7_3876622
eNFA3_4_28182251 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_28182251
eNFA3_4_28182251 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_1060976
eNFA2_4_60083059 -->|"[^*]"|eNFA2_5_7485743
eNFA2_8_51415138 -->|"[*]"|eNFA2_9_53939958
eNFA2_7_3876622 -.->|"ε"|eNFA2_6_20625874
eNFA2_7_3876622 -.->|"ε"|eNFA2_12_45570991
eNFA3_6_1060976 -.->|"ε"|eNFA3_7_48854964
eNFA2_5_7485743 -.->|"ε"|eNFA2_7_3876622
eNFA2_9_53939958 -.->|"ε"|eNFA2_10_35026424
eNFA2_12_45570991 -->|"*"|eNFA2_13_46802360
eNFA3_7_48854964 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_18830246
eNFA2_10_35026424 -->|"[^/]"|eNFA2_11_262829
eNFA2_13_46802360 -.->|"ε"|eNFA2_14_18568063
eNFA3_8_18830246 -.->|"ε"|eNFA0_1_46703582
eNFA2_11_262829 -.->|"ε"|eNFA2_7_3876622
eNFA2_14_18568063 -->|"/"|eNFA2_15_24893793
eNFA2_15_24893793 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_22717550
eNFA2_17_22717550 -.->|"ε"|eNFA2_18_3131361
eNFA2_18_3131361 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_57385070
eNFA2_19_57385070 -.->|"ε"|eNFA0_1_46703582

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
eNFA0_0_37041500[["εNFA0-0 wholeStart"]]
class eNFA0_0_37041500 c1000;
eNFA1_2_47571555[["εNFA1-2 regex start"]]
class eNFA1_2_47571555 c1000;
eNFA2_16_64938051[["εNFA2-16 regex start"]]
class eNFA2_16_64938051 c1000;
eNFA3_5_25490811[["εNFA3-5 regex start"]]
class eNFA3_5_25490811 c1000;
eNFA1_0_9923843[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_9923843 c1000;
eNFA2_0_11984159[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_11984159 c1000;
eNFA3_0_43590645[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_43590645 c1000;
eNFA1_1_60754972[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_60754972 c0111;
eNFA2_1_41181381[["εNFA2-1 char[1]"]]
eNFA3_1_47357582[["εNFA3-1 char[1]"]]
eNFA1_3_22205728[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_22205728 c0111;
eNFA1_4_8788113[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_8788113 c0011;
eNFA1_5_47236811[\"εNFA1-5 post-regex end"/]
class eNFA1_5_47236811 c0011;
eNFA0_1_27618155[\"εNFA0-1 wholeEnd"/]
eNFA2_2_10758903[["εNFA2-2 char{1, 1}"]]
eNFA2_3_15697576[["εNFA2-3 char[1]"]]
eNFA3_2_23565055[["εNFA3-2 char{1, 1}"]]
eNFA3_3_38777132[\"εNFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA3_3_38777132 c0111;
eNFA2_6_14739853[["εNFA2-6 regex start"]]
eNFA2_4_53077479[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_65549821[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_7935270[["εNFA2-7 regex end"]]
eNFA2_5_63544148[["εNFA2-5 scope[1]"]]
eNFA2_9_29721263[["εNFA2-9 scope[1]"]]
eNFA2_12_7060460[["εNFA2-12 char{1, 1}"]]
eNFA2_13_58612075[["εNFA2-13 char[1]"]]
eNFA3_4_4308570[\"εNFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA3_4_4308570 c0111;
eNFA3_6_13449869[\"εNFA3-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA3_6_13449869 c0111;
eNFA3_7_56771492[\"εNFA3-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA3_7_56771492 c0011;
eNFA3_8_32894845[\"εNFA3-8 post-regex end"/]
class eNFA3_8_32894845 c0011;
eNFA2_10_66164776[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_22478116[["εNFA2-11 scope[1]"]]
eNFA2_14_35088115[["εNFA2-14 char{1, 1}"]]
eNFA2_15_40748571[\"εNFA2-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA2_15_40748571 c0111;
eNFA2_17_31192822[\"εNFA2-17 regex end
AcceptToken 'blockComment'"/]
class eNFA2_17_31192822 c0111;
eNFA2_18_12299945[\"εNFA2-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA2_18_12299945 c0011;
eNFA2_19_976457[\"εNFA2-19 post-regex end"/]
class eNFA2_19_976457 c0011;
eNFA0_0_37041500 -.->|"ε"|eNFA1_2_47571555
eNFA0_0_37041500 -.->|"ε"|eNFA2_16_64938051
eNFA0_0_37041500 -.->|"ε"|eNFA3_5_25490811
eNFA0_0_37041500 -.->|"ε
BeginToken 'integer'"|eNFA1_0_9923843
eNFA0_0_37041500 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_11984159
eNFA0_0_37041500 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_43590645
eNFA0_0_37041500 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_60754972
eNFA0_0_37041500 -->|"/
BeginToken 'blockComment'"|eNFA2_1_41181381
eNFA0_0_37041500 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_47357582
eNFA1_2_47571555 -.->|"ε
BeginToken 'integer'"|eNFA1_0_9923843
eNFA1_2_47571555 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_60754972
eNFA2_16_64938051 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_11984159
eNFA2_16_64938051 -->|"/
BeginToken 'blockComment'"|eNFA2_1_41181381
eNFA3_5_25490811 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_43590645
eNFA3_5_25490811 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_47357582
eNFA1_0_9923843 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_60754972
eNFA2_0_11984159 -->|"/
BeginToken 'blockComment'"|eNFA2_1_41181381
eNFA3_0_43590645 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_47357582
eNFA1_1_60754972 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_60754972
eNFA1_1_60754972 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_22205728
eNFA1_1_60754972 -.->|"ε"|eNFA1_4_8788113
eNFA1_1_60754972 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_47236811
eNFA1_1_60754972 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27618155
eNFA2_1_41181381 -.->|"ε"|eNFA2_2_10758903
eNFA2_1_41181381 -->|"*"|eNFA2_3_15697576
eNFA3_1_47357582 -.->|"ε"|eNFA3_2_23565055
eNFA3_1_47357582 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_38777132
eNFA1_3_22205728 -.->|"ε"|eNFA1_4_8788113
eNFA1_3_22205728 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_47236811
eNFA1_3_22205728 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27618155
eNFA1_4_8788113 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_47236811
eNFA1_4_8788113 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27618155
eNFA1_5_47236811 -.->|"ε
CheckToken 'integer'"|eNFA0_1_27618155
eNFA2_2_10758903 -->|"*"|eNFA2_3_15697576
eNFA2_3_15697576 -.->|"ε"|eNFA2_6_14739853
eNFA2_3_15697576 -.->|"ε"|eNFA2_4_53077479
eNFA2_3_15697576 -.->|"ε"|eNFA2_8_65549821
eNFA2_3_15697576 -.->|"ε"|eNFA2_7_7935270
eNFA2_3_15697576 -->|"[^*]"|eNFA2_5_63544148
eNFA2_3_15697576 -->|"[*]"|eNFA2_9_29721263
eNFA2_3_15697576 -.->|"ε"|eNFA2_12_7060460
eNFA2_3_15697576 -->|"*"|eNFA2_13_58612075
eNFA3_2_23565055 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_38777132
eNFA3_3_38777132 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_4_4308570
eNFA3_3_38777132 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_4308570
eNFA3_3_38777132 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_13449869
eNFA3_3_38777132 -.->|"ε"|eNFA3_7_56771492
eNFA3_3_38777132 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_32894845
eNFA3_3_38777132 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_27618155
eNFA2_6_14739853 -.->|"ε"|eNFA2_4_53077479
eNFA2_6_14739853 -.->|"ε"|eNFA2_8_65549821
eNFA2_6_14739853 -.->|"ε"|eNFA2_7_7935270
eNFA2_6_14739853 -->|"[^*]"|eNFA2_5_63544148
eNFA2_6_14739853 -->|"[*]"|eNFA2_9_29721263
eNFA2_6_14739853 -.->|"ε"|eNFA2_6_14739853
eNFA2_6_14739853 -.->|"ε"|eNFA2_12_7060460
eNFA2_6_14739853 -->|"*"|eNFA2_13_58612075
eNFA2_4_53077479 -->|"[^*]"|eNFA2_5_63544148
eNFA2_8_65549821 -->|"[*]"|eNFA2_9_29721263
eNFA2_7_7935270 -.->|"ε"|eNFA2_6_14739853
eNFA2_7_7935270 -.->|"ε"|eNFA2_12_7060460
eNFA2_7_7935270 -.->|"ε"|eNFA2_4_53077479
eNFA2_7_7935270 -.->|"ε"|eNFA2_8_65549821
eNFA2_7_7935270 -.->|"ε"|eNFA2_7_7935270
eNFA2_7_7935270 -->|"[^*]"|eNFA2_5_63544148
eNFA2_7_7935270 -->|"[*]"|eNFA2_9_29721263
eNFA2_7_7935270 -->|"*"|eNFA2_13_58612075
eNFA2_5_63544148 -.->|"ε"|eNFA2_7_7935270
eNFA2_5_63544148 -.->|"ε"|eNFA2_6_14739853
eNFA2_5_63544148 -.->|"ε"|eNFA2_12_7060460
eNFA2_5_63544148 -.->|"ε"|eNFA2_4_53077479
eNFA2_5_63544148 -.->|"ε"|eNFA2_8_65549821
eNFA2_5_63544148 -->|"[^*]"|eNFA2_5_63544148
eNFA2_5_63544148 -->|"[*]"|eNFA2_9_29721263
eNFA2_5_63544148 -->|"*"|eNFA2_13_58612075
eNFA2_9_29721263 -.->|"ε"|eNFA2_10_66164776
eNFA2_9_29721263 -->|"[^/]"|eNFA2_11_22478116
eNFA2_12_7060460 -->|"*"|eNFA2_13_58612075
eNFA2_13_58612075 -.->|"ε"|eNFA2_14_35088115
eNFA2_13_58612075 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_40748571
eNFA3_4_4308570 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_4308570
eNFA3_4_4308570 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_13449869
eNFA3_4_4308570 -.->|"ε"|eNFA3_7_56771492
eNFA3_4_4308570 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_32894845
eNFA3_4_4308570 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_27618155
eNFA3_6_13449869 -.->|"ε"|eNFA3_7_56771492
eNFA3_6_13449869 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_32894845
eNFA3_6_13449869 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_27618155
eNFA3_7_56771492 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_32894845
eNFA3_7_56771492 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_27618155
eNFA3_8_32894845 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_27618155
eNFA2_10_66164776 -->|"[^/]"|eNFA2_11_22478116
eNFA2_11_22478116 -.->|"ε"|eNFA2_7_7935270
eNFA2_11_22478116 -.->|"ε"|eNFA2_6_14739853
eNFA2_11_22478116 -.->|"ε"|eNFA2_12_7060460
eNFA2_11_22478116 -.->|"ε"|eNFA2_4_53077479
eNFA2_11_22478116 -.->|"ε"|eNFA2_8_65549821
eNFA2_11_22478116 -->|"[^*]"|eNFA2_5_63544148
eNFA2_11_22478116 -->|"[*]"|eNFA2_9_29721263
eNFA2_11_22478116 -->|"*"|eNFA2_13_58612075
eNFA2_14_35088115 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_40748571
eNFA2_15_40748571 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_31192822
eNFA2_15_40748571 -.->|"ε"|eNFA2_18_12299945
eNFA2_15_40748571 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_976457
eNFA2_15_40748571 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_27618155
eNFA2_17_31192822 -.->|"ε"|eNFA2_18_12299945
eNFA2_17_31192822 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_976457
eNFA2_17_31192822 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_27618155
eNFA2_18_12299945 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_976457
eNFA2_18_12299945 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_27618155
eNFA2_19_976457 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_27618155

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
NFA0_0_49957660("NFA0-0 wholeStart")
class NFA0_0_49957660 c1000;
NFA1_1_57746634[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_57746634 c0101;
NFA2_1_46965764("NFA2-1 char[1]")
NFA3_1_20038698("NFA3-1 char[1]")
NFA2_3_12521852("NFA2-3 char[1]")
NFA3_3_46130559[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_46130559 c0101;
NFA2_5_7637115("NFA2-5 scope[1]")
NFA2_9_45587811("NFA2-9 scope[1]")
NFA2_13_1625174("NFA2-13 char[1]")
NFA3_4_14626574[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_14626574 c0101;
NFA2_11_43901854("NFA2-11 scope[1]")
NFA2_15_64530307[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_64530307 c0101;
NFA0_0_49957660 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_57746634
NFA0_0_49957660 -->|"/
BeginToken 'blockComment'"|NFA2_1_46965764
NFA0_0_49957660 -->|"/
BeginToken 'inlineComment'"|NFA3_1_20038698
NFA1_1_57746634 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_57746634
NFA2_1_46965764 -->|"*"|NFA2_3_12521852
NFA3_1_20038698 -->|"/
ExtendToken 'inlineComment'"|NFA3_3_46130559
NFA2_3_12521852 -->|"[^*]"|NFA2_5_7637115
NFA2_3_12521852 -->|"[*]"|NFA2_9_45587811
NFA2_3_12521852 -->|"*"|NFA2_13_1625174
NFA3_3_46130559 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_14626574
NFA2_5_7637115 -->|"[^*]"|NFA2_5_7637115
NFA2_5_7637115 -->|"[*]"|NFA2_9_45587811
NFA2_5_7637115 -->|"*"|NFA2_13_1625174
NFA2_9_45587811 -->|"[^/]"|NFA2_11_43901854
NFA2_13_1625174 -->|"/
ExtendToken 'blockComment'"|NFA2_15_64530307
NFA3_4_14626574 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_14626574
NFA2_11_43901854 -->|"[^*]"|NFA2_5_7637115
NFA2_11_43901854 -->|"[*]"|NFA2_9_45587811
NFA2_11_43901854 -->|"*"|NFA2_13_1625174

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
subgraph DFA0_879766078["DFA0 wholeStart"]
NFA0_0_49957660_0("NFA0-0 wholeStart")
class NFA0_0_49957660_0 c1000;
end
class DFA0_879766078 c1000;
subgraph DFA1_-1410976644["DFA1 {1}"]
NFA1_1_57746634_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_57746634_1 c0101;
end
class DFA1_-1410976644 c0101;
subgraph DFA2_320235872["DFA2 {2}"]
NFA2_1_46965764_2("NFA2-1 char[1]")
NFA3_1_20038698_3("NFA3-1 char[1]")
end
subgraph DFA3_1968006229["DFA3 {1}"]
NFA2_3_12521852_4("NFA2-3 char[1]")
end
subgraph DFA4_-322686605["DFA4 {1}"]
NFA3_3_46130559_5[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_46130559_5 c0101;
end
class DFA4_-322686605 c0101;
subgraph DFA5_-2052777702["DFA5 {1}"]
NFA2_5_7637115_6("NFA2-5 scope[1]")
end
subgraph DFA6_820711853["DFA6 {2}"]
NFA2_9_45587811_7("NFA2-9 scope[1]")
NFA2_13_1625174_8("NFA2-13 char[1]")
end
subgraph DFA7_-2085538696["DFA7 {1}"]
NFA3_4_14626574_9[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_14626574_9 c0101;
end
class DFA7_-2085538696 c0101;
subgraph DFA8_-897030992["DFA8 {1}"]
NFA2_11_43901854_10("NFA2-11 scope[1]")
end
subgraph DFA9_-122808567["DFA9 {1}"]
NFA2_15_64530307_11[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_64530307_11 c0101;
end
class DFA9_-122808567 c0101;
DFA0_879766078 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_-1410976644
DFA0_879766078 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_320235872
DFA1_-1410976644 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1410976644
DFA2_320235872 -->|"*"|DFA3_1968006229
DFA2_320235872 -->|"/
ExtendToken 'inlineComment'"|DFA4_-322686605
DFA3_1968006229 -->|"[^*]"|DFA5_-2052777702
DFA3_1968006229 -->|"*"|DFA6_820711853
DFA4_-322686605 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA7_-2085538696
DFA5_-2052777702 -->|"[^*]"|DFA5_-2052777702
DFA5_-2052777702 -->|"*"|DFA6_820711853
DFA6_820711853 -->|"[^/]"|DFA8_-897030992
DFA6_820711853 -->|"/
ExtendToken 'blockComment'"|DFA9_-122808567
DFA7_-2085538696 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA7_-2085538696
DFA8_-897030992 -->|"[^*]"|DFA5_-2052777702
DFA8_-897030992 -->|"*"|DFA6_820711853

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
DFA0_879766078{{"DFA0 wholeStart"}}
class DFA0_879766078 c1000;
DFA1_-1410976644[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_-1410976644 c0101;
DFA2_320235872{{"DFA2 {2}"}}
DFA3_1968006229{{"DFA3 {1}"}}
DFA4_-322686605[\"DFA4 {1}
AcceptToken 'inlineComment'"/]
class DFA4_-322686605 c0101;
DFA5_-2052777702{{"DFA5 {1}"}}
DFA6_820711853{{"DFA6 {2}"}}
DFA7_-2085538696[\"DFA7 {1}
AcceptToken 'inlineComment'"/]
class DFA7_-2085538696 c0101;
DFA8_-897030992{{"DFA8 {1}"}}
DFA9_-122808567[\"DFA9 {1}
AcceptToken 'blockComment'"/]
class DFA9_-122808567 c0101;
DFA0_879766078 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_-1410976644
DFA0_879766078 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA2_320235872
DFA1_-1410976644 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1410976644
DFA2_320235872 -->|"*"|DFA3_1968006229
DFA2_320235872 -->|"/
ExtendToken 'inlineComment'"|DFA4_-322686605
DFA3_1968006229 -->|"[^*]"|DFA5_-2052777702
DFA3_1968006229 -->|"*"|DFA6_820711853
DFA4_-322686605 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA7_-2085538696
DFA5_-2052777702 -->|"[^*]"|DFA5_-2052777702
DFA5_-2052777702 -->|"*"|DFA6_820711853
DFA6_820711853 -->|"[^/]"|DFA8_-897030992
DFA6_820711853 -->|"/
ExtendToken 'blockComment'"|DFA9_-122808567
DFA7_-2085538696 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA7_-2085538696
DFA8_-897030992 -->|"[^*]"|DFA5_-2052777702
DFA8_-897030992 -->|"*"|DFA6_820711853

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
subgraph MiniDFA0_1689043295["MiniDFA0 {1}"]
DFA0_879766078_0{{"DFA0 wholeStart"}}
class DFA0_879766078_0 c1000;
end
class MiniDFA0_1689043295 c1000;
subgraph MiniDFA4_1589456906["MiniDFA4 {1}"]
DFA1_-1410976644_1[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_-1410976644_1 c0101;
end
class MiniDFA4_1589456906 c0101;
subgraph MiniDFA1_-712178828["MiniDFA1 {1}"]
DFA2_320235872_2{{"DFA2 {2}"}}
end
subgraph MiniDFA2_905090704["MiniDFA2 {3}"]
DFA3_1968006229_3{{"DFA3 {1}"}}
DFA5_-2052777702_4{{"DFA5 {1}"}}
DFA8_-897030992_5{{"DFA8 {1}"}}
end
subgraph MiniDFA5_-503631591["MiniDFA5 {1}"]
DFA4_-322686605_6[\"DFA4 {1}
AcceptToken 'inlineComment'"/]
class DFA4_-322686605_6 c0101;
end
class MiniDFA5_-503631591 c0101;
subgraph MiniDFA3_1163369074["MiniDFA3 {1}"]
DFA6_820711853_7{{"DFA6 {2}"}}
end
subgraph MiniDFA6_53766736["MiniDFA6 {1}"]
DFA7_-2085538696_8[\"DFA7 {1}
AcceptToken 'inlineComment'"/]
class DFA7_-2085538696_8 c0101;
end
class MiniDFA6_53766736 c0101;
subgraph MiniDFA7_-1375809239["MiniDFA7 {1}"]
DFA9_-122808567_9[\"DFA9 {1}
AcceptToken 'blockComment'"/]
class DFA9_-122808567_9 c0101;
end
class MiniDFA7_-1375809239 c0101;
MiniDFA0_1689043295 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA4_1589456906
MiniDFA0_1689043295 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-712178828
MiniDFA4_1589456906 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA4_1589456906
MiniDFA1_-712178828 -->|"*"|MiniDFA2_905090704
MiniDFA1_-712178828 -->|"/
ExtendToken 'inlineComment'"|MiniDFA5_-503631591
MiniDFA2_905090704 -->|"[^*]"|MiniDFA2_905090704
MiniDFA2_905090704 -->|"*"|MiniDFA3_1163369074
MiniDFA5_-503631591 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA6_53766736
MiniDFA3_1163369074 -->|"[^/]"|MiniDFA2_905090704
MiniDFA3_1163369074 -->|"/
ExtendToken 'blockComment'"|MiniDFA7_-1375809239
MiniDFA6_53766736 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA6_53766736

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
MiniDFA0_1689043295(["MiniDFA0 {1}"])
class MiniDFA0_1689043295 c1000;
MiniDFA4_1589456906[\"MiniDFA4 {1}
AcceptToken 'integer'"/]
class MiniDFA4_1589456906 c0101;
MiniDFA1_-712178828(["MiniDFA1 {1}"])
MiniDFA2_905090704(["MiniDFA2 {3}"])
MiniDFA5_-503631591[\"MiniDFA5 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA5_-503631591 c0101;
MiniDFA3_1163369074(["MiniDFA3 {1}"])
MiniDFA6_53766736[\"MiniDFA6 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA6_53766736 c0101;
MiniDFA7_-1375809239[\"MiniDFA7 {1}
AcceptToken 'blockComment'"/]
class MiniDFA7_-1375809239 c0101;
MiniDFA0_1689043295 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA4_1589456906
MiniDFA0_1689043295 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-712178828
MiniDFA4_1589456906 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA4_1589456906
MiniDFA1_-712178828 -->|"*"|MiniDFA2_905090704
MiniDFA1_-712178828 -->|"/
ExtendToken 'inlineComment'"|MiniDFA5_-503631591
MiniDFA2_905090704 -->|"[^*]"|MiniDFA2_905090704
MiniDFA2_905090704 -->|"*"|MiniDFA3_1163369074
MiniDFA5_-503631591 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA6_53766736
MiniDFA3_1163369074 -->|"[^/]"|MiniDFA2_905090704
MiniDFA3_1163369074 -->|"/
ExtendToken 'blockComment'"|MiniDFA7_-1375809239
MiniDFA6_53766736 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA6_53766736

```

# 总结

无。

