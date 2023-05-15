# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Ints2`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（11个State）。

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
eNFA0_2_39434786[["εNFA0-2 regex start"]]
eNFA0_0_61642077[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_21762200[["εNFA0-1 scope[1]"]]
eNFA0_3_17907785[["εNFA0-3 regex end"]]
eNFA0_2_39434786 -.->|"ε"|eNFA0_0_61642077
eNFA0_0_61642077 -->|"[0-9]"|eNFA0_1_21762200
eNFA0_1_21762200 -->|"[0-9]"|eNFA0_1_21762200
eNFA0_1_21762200 -.->|"ε"|eNFA0_3_17907785
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
eNFA0_4_26965262[["εNFA0-4 post-regex start"]]
eNFA0_5_41360766[\"εNFA0-5 post-regex end"/]
eNFA0_4_26965262 -.->|"ε"|eNFA0_5_41360766
```


## ','
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
eNFA0_2_34680572[["εNFA0-2 regex start"]]
eNFA0_0_43689693[["εNFA0-0 char{1, 1}"]]
eNFA0_1_57662920[["εNFA0-1 char[1]"]]
eNFA0_3_49204239[["εNFA0-3 regex end"]]
eNFA0_2_34680572 -.->|"ε"|eNFA0_0_43689693
eNFA0_0_43689693 -->|","|eNFA0_1_57662920
eNFA0_1_57662920 -.->|"ε"|eNFA0_3_49204239
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
eNFA0_4_40184969[["εNFA0-4 post-regex start"]]
eNFA0_5_26120409[\"εNFA0-5 post-regex end"/]
eNFA0_4_40184969 -.->|"ε"|eNFA0_5_26120409
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
eNFA0_16_47250101[["εNFA0-16 regex start"]]
eNFA0_0_22597726[["εNFA0-0 char{1, 1}"]]
eNFA0_1_2052950[["εNFA0-1 char[1]"]]
eNFA0_2_18476557[["εNFA0-2 char{1, 1}"]]
eNFA0_3_14114947[["εNFA0-3 char[1]"]]
eNFA0_6_35656026[["εNFA0-6 regex start"]]
eNFA0_4_2456979[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_52468780[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_64797609[["εNFA0-7 regex end"]]
eNFA0_5_46307570[["εNFA0-5 scope[1]"]]
eNFA0_9_33464950[["εNFA0-9 scope[1]"]]
eNFA0_12_59925661[["εNFA0-12 char{1, 1}"]]
eNFA0_10_50448354[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_51382007[["εNFA0-13 char[1]"]]
eNFA0_11_22112815[["εNFA0-11 scope[1]"]]
eNFA0_14_59784887[["εNFA0-14 char{1, 1}"]]
eNFA0_15_10737664[["εNFA0-15 char[1]"]]
eNFA0_17_29530116[["εNFA0-17 regex end"]]
eNFA0_16_47250101 -.->|"ε"|eNFA0_0_22597726
eNFA0_0_22597726 -->|"/"|eNFA0_1_2052950
eNFA0_1_2052950 -.->|"ε"|eNFA0_2_18476557
eNFA0_2_18476557 -->|"*"|eNFA0_3_14114947
eNFA0_3_14114947 -.->|"ε"|eNFA0_6_35656026
eNFA0_6_35656026 -.->|"ε"|eNFA0_4_2456979
eNFA0_6_35656026 -.->|"ε"|eNFA0_8_52468780
eNFA0_6_35656026 -.->|"ε"|eNFA0_7_64797609
eNFA0_4_2456979 -->|"[^*]"|eNFA0_5_46307570
eNFA0_8_52468780 -->|"[*]"|eNFA0_9_33464950
eNFA0_7_64797609 -.->|"ε"|eNFA0_6_35656026
eNFA0_7_64797609 -.->|"ε"|eNFA0_12_59925661
eNFA0_5_46307570 -.->|"ε"|eNFA0_7_64797609
eNFA0_9_33464950 -.->|"ε"|eNFA0_10_50448354
eNFA0_12_59925661 -->|"*"|eNFA0_13_51382007
eNFA0_10_50448354 -->|"[^/]"|eNFA0_11_22112815
eNFA0_13_51382007 -.->|"ε"|eNFA0_14_59784887
eNFA0_11_22112815 -.->|"ε"|eNFA0_7_64797609
eNFA0_14_59784887 -->|"/"|eNFA0_15_10737664
eNFA0_15_10737664 -.->|"ε"|eNFA0_17_29530116
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
eNFA0_18_64444454[["εNFA0-18 post-regex start"]]
eNFA0_19_43129175[\"εNFA0-19 post-regex end"/]
eNFA0_18_64444454 -.->|"ε"|eNFA0_19_43129175
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
eNFA0_5_10070188[["εNFA0-5 regex start"]]
eNFA0_0_23522831[["εNFA0-0 char{1, 1}"]]
eNFA0_1_10378893[["εNFA0-1 char[1]"]]
eNFA0_2_26301173[["εNFA0-2 char{1, 1}"]]
eNFA0_3_22140377[["εNFA0-3 char[1]"]]
eNFA0_4_65045669[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_48540109[["εNFA0-6 regex end"]]
eNFA0_5_10070188 -.->|"ε"|eNFA0_0_23522831
eNFA0_0_23522831 -->|"/"|eNFA0_1_10378893
eNFA0_1_10378893 -.->|"ε"|eNFA0_2_26301173
eNFA0_2_26301173 -->|"/"|eNFA0_3_22140377
eNFA0_3_22140377 -.->|"ε"|eNFA0_4_65045669
eNFA0_4_65045669 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_65045669
eNFA0_4_65045669 -.->|"ε"|eNFA0_6_48540109
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
eNFA0_7_25110514[["εNFA0-7 post-regex start"]]
eNFA0_8_24668042[\"εNFA0-8 post-regex end"/]
eNFA0_7_25110514 -.->|"ε"|eNFA0_8_24668042
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
eNFA0_0_10953403[["εNFA0-0 wholeStart"]]
eNFA1_2_19346796[["εNFA1-2 regex start"]]
class eNFA1_2_19346796 c1000;
eNFA2_2_31471768[["εNFA2-2 regex start"]]
class eNFA2_2_31471768 c1000;
eNFA3_16_28171394[["εNFA3-16 regex start"]]
class eNFA3_16_28171394 c1000;
eNFA4_5_16135397[["εNFA4-5 regex start"]]
class eNFA4_5_16135397 c1000;
eNFA1_0_64862199[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_58796306[["εNFA2-0 char{1, 1}"]]
eNFA3_0_181603[["εNFA3-0 char{1, 1}"]]
eNFA4_0_31898818[["εNFA4-0 char{1, 1}"]]
eNFA1_1_7206911[["εNFA1-1 scope[1]"]]
eNFA2_1_59404709[["εNFA2-1 char[1]"]]
eNFA3_1_63687823[["εNFA3-1 char[1]"]]
eNFA4_1_36319496[["εNFA4-1 char[1]"]]
eNFA1_3_46888886[["εNFA1-3 regex end"]]
class eNFA1_3_46888886 c0100;
eNFA2_3_64880336[["εNFA2-3 regex end"]]
class eNFA2_3_64880336 c0100;
eNFA3_2_55752527[["εNFA3-2 char{1, 1}"]]
eNFA4_2_32010697[["εNFA4-2 char{1, 1}"]]
eNFA1_4_39903442[["εNFA1-4 post-regex start"]]
class eNFA1_4_39903442 c0010;
eNFA2_4_47052116[["εNFA2-4 post-regex start"]]
class eNFA2_4_47052116 c0010;
eNFA3_3_6366390[["εNFA3-3 char[1]"]]
eNFA4_3_53223490[["εNFA4-3 char[1]"]]
eNFA1_5_23586666[\"εNFA1-5 post-regex end"/]
class eNFA1_5_23586666 c0001;
eNFA2_5_14810456[\"εNFA2-5 post-regex end"/]
class eNFA2_5_14810456 c0001;
eNFA3_6_20815867[["εNFA3-6 regex start"]]
eNFA4_4_50652963[["εNFA4-4 char{0, ∞}"]]
eNFA0_1_66185246[\"εNFA0-1 wholeEnd"/]
eNFA3_4_8363642[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_53125076[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_8163917[["εNFA3-7 regex end"]]
eNFA4_6_9249362[["εNFA4-6 regex end"]]
class eNFA4_6_9249362 c0100;
eNFA3_5_45915542[["εNFA3-5 scope[1]"]]
eNFA3_9_10058158[["εNFA3-9 scope[1]"]]
eNFA3_12_57297510[["εNFA3-12 char{1, 1}"]]
eNFA4_7_18653909[["εNFA4-7 post-regex start"]]
class eNFA4_7_18653909 c0010;
eNFA3_10_23562876[["εNFA3-10 scope{1, 1}"]]
eNFA3_13_10739296[["εNFA3-13 char[1]"]]
eNFA4_8_11000853[\"εNFA4-8 post-regex end"/]
class eNFA4_8_11000853 c0001;
eNFA3_11_10586695[["εNFA3-11 scope[1]"]]
eNFA3_14_29544808[["εNFA3-14 char{1, 1}"]]
eNFA3_15_1634435[["εNFA3-15 char[1]"]]
eNFA3_17_14709921[["εNFA3-17 regex end"]]
class eNFA3_17_14709921 c0100;
eNFA3_18_65280430[["εNFA3-18 post-regex start"]]
class eNFA3_18_65280430 c0010;
eNFA3_19_52215961[\"εNFA3-19 post-regex end"/]
class eNFA3_19_52215961 c0001;
eNFA0_0_10953403 -.->|"ε"|eNFA1_2_19346796
eNFA0_0_10953403 -.->|"ε"|eNFA2_2_31471768
eNFA0_0_10953403 -.->|"ε"|eNFA3_16_28171394
eNFA0_0_10953403 -.->|"ε"|eNFA4_5_16135397
eNFA1_2_19346796 -.->|"ε
BeginToken 'integer'"|eNFA1_0_64862199
eNFA2_2_31471768 -.->|"ε
BeginToken ','"|eNFA2_0_58796306
eNFA3_16_28171394 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_181603
eNFA4_5_16135397 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_31898818
eNFA1_0_64862199 -->|"[0-9]"|eNFA1_1_7206911
eNFA2_0_58796306 -->|","|eNFA2_1_59404709
eNFA3_0_181603 -->|"/"|eNFA3_1_63687823
eNFA4_0_31898818 -->|"/"|eNFA4_1_36319496
eNFA1_1_7206911 -->|"[0-9]"|eNFA1_1_7206911
eNFA1_1_7206911 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_46888886
eNFA2_1_59404709 -.->|"ε
ExtendToken ','"|eNFA2_3_64880336
eNFA3_1_63687823 -.->|"ε"|eNFA3_2_55752527
eNFA4_1_36319496 -.->|"ε"|eNFA4_2_32010697
eNFA1_3_46888886 -.->|"ε"|eNFA1_4_39903442
eNFA2_3_64880336 -.->|"ε"|eNFA2_4_47052116
eNFA3_2_55752527 -->|"*"|eNFA3_3_6366390
eNFA4_2_32010697 -->|"/"|eNFA4_3_53223490
eNFA1_4_39903442 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_23586666
eNFA2_4_47052116 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_14810456
eNFA3_3_6366390 -.->|"ε"|eNFA3_6_20815867
eNFA4_3_53223490 -.->|"ε"|eNFA4_4_50652963
eNFA1_5_23586666 -.->|"ε"|eNFA0_1_66185246
eNFA2_5_14810456 -.->|"ε"|eNFA0_1_66185246
eNFA3_6_20815867 -.->|"ε"|eNFA3_4_8363642
eNFA3_6_20815867 -.->|"ε"|eNFA3_8_53125076
eNFA3_6_20815867 -.->|"ε"|eNFA3_7_8163917
eNFA4_4_50652963 -->|"[#92;t#92;r#32;-~]"|eNFA4_4_50652963
eNFA4_4_50652963 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_9249362
eNFA3_4_8363642 -->|"[^*]"|eNFA3_5_45915542
eNFA3_8_53125076 -->|"[*]"|eNFA3_9_10058158
eNFA3_7_8163917 -.->|"ε"|eNFA3_6_20815867
eNFA3_7_8163917 -.->|"ε"|eNFA3_12_57297510
eNFA4_6_9249362 -.->|"ε"|eNFA4_7_18653909
eNFA3_5_45915542 -.->|"ε"|eNFA3_7_8163917
eNFA3_9_10058158 -.->|"ε"|eNFA3_10_23562876
eNFA3_12_57297510 -->|"*"|eNFA3_13_10739296
eNFA4_7_18653909 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_11000853
eNFA3_10_23562876 -->|"[^/]"|eNFA3_11_10586695
eNFA3_13_10739296 -.->|"ε"|eNFA3_14_29544808
eNFA4_8_11000853 -.->|"ε"|eNFA0_1_66185246
eNFA3_11_10586695 -.->|"ε"|eNFA3_7_8163917
eNFA3_14_29544808 -->|"/"|eNFA3_15_1634435
eNFA3_15_1634435 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_14709921
eNFA3_17_14709921 -.->|"ε"|eNFA3_18_65280430
eNFA3_18_65280430 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_52215961
eNFA3_19_52215961 -.->|"ε"|eNFA0_1_66185246

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
eNFA0_0_33667455[["εNFA0-0 wholeStart"]]
class eNFA0_0_33667455 c1000;
eNFA1_2_42709316[["εNFA1-2 regex start"]]
class eNFA1_2_42709316 c1000;
eNFA2_2_34571641[["εNFA2-2 regex start"]]
class eNFA2_2_34571641 c1000;
eNFA3_16_48839530[["εNFA3-16 regex start"]]
class eNFA3_16_48839530 c1000;
eNFA4_5_36902586[["εNFA4-5 regex start"]]
class eNFA4_5_36902586 c1000;
eNFA1_0_56198103[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_56198103 c1000;
eNFA2_0_29365919[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_29365919 c1000;
eNFA3_0_251973[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_251973 c1000;
eNFA4_0_42586845[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_42586845 c1000;
eNFA1_1_58440016[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_58440016 c0111;
eNFA2_1_62966687[\"εNFA2-1 char[1]
AcceptToken ','"/]
class eNFA2_1_62966687 c0111;
eNFA3_1_26982424[["εNFA3-1 char[1]"]]
eNFA4_1_38092711[["εNFA4-1 char[1]"]]
eNFA1_3_36020887[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_36020887 c0111;
eNFA1_4_33089041[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_33089041 c0011;
eNFA1_5_49022807[\"εNFA1-5 post-regex end"/]
class eNFA1_5_49022807 c0011;
eNFA0_1_42729680[\"εNFA0-1 wholeEnd"/]
eNFA2_3_29829272[\"εNFA2-3 regex end
AcceptToken ','"/]
class eNFA2_3_29829272 c0111;
eNFA2_4_27997[\"εNFA2-4 post-regex start
AcceptToken ','"/]
class eNFA2_4_27997 c0011;
eNFA2_5_19660823[\"εNFA2-5 post-regex end"/]
class eNFA2_5_19660823 c0011;
eNFA3_2_65610739[["εNFA3-2 char{1, 1}"]]
eNFA3_3_23414560[["εNFA3-3 char[1]"]]
eNFA4_2_7290082[["εNFA4-2 char{1, 1}"]]
eNFA4_3_62262011[\"εNFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA4_3_62262011 c0111;
eNFA3_6_38552084[["εNFA3-6 regex start"]]
eNFA3_4_35711100[["εNFA3-4 scope{1, 1}"]]
eNFA3_8_11424440[["εNFA3-8 scope{1, 1}"]]
eNFA3_7_52964449[["εNFA3-7 regex end"]]
eNFA3_5_17531178[["εNFA3-5 scope[1]"]]
eNFA3_9_53625739[["εNFA3-9 scope[1]"]]
eNFA3_12_9404449[["εNFA3-12 char{1, 1}"]]
eNFA3_13_48717564[["εNFA3-13 char[1]"]]
eNFA4_4_6918001[\"εNFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA4_4_6918001 c0111;
eNFA4_6_23487194[\"εNFA4-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA4_6_23487194 c0111;
eNFA4_7_47737289[\"εNFA4-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA4_7_47737289 c0011;
eNFA4_8_64576684[\"εNFA4-8 post-regex end"/]
class eNFA4_8_64576684 c0011;
eNFA3_10_12869603[["εNFA3-10 scope{1, 1}"]]
eNFA3_11_44319244[["εNFA3-11 scope[1]"]]
eNFA3_14_41515225[["εNFA3-14 char{1, 1}"]]
eNFA3_15_2267763[\"εNFA3-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA3_15_2267763 c0111;
eNFA3_17_20409871[\"εNFA3-17 regex end
AcceptToken 'blockComment'"/]
class eNFA3_17_20409871 c0111;
eNFA3_18_49471114[\"εNFA3-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA3_18_49471114 c0011;
eNFA3_19_63328883[\"εNFA3-19 post-regex end"/]
class eNFA3_19_63328883 c0011;
eNFA0_0_33667455 -.->|"ε"|eNFA1_2_42709316
eNFA0_0_33667455 -.->|"ε"|eNFA2_2_34571641
eNFA0_0_33667455 -.->|"ε"|eNFA3_16_48839530
eNFA0_0_33667455 -.->|"ε"|eNFA4_5_36902586
eNFA0_0_33667455 -.->|"ε
BeginToken 'integer'"|eNFA1_0_56198103
eNFA0_0_33667455 -.->|"ε
BeginToken ','"|eNFA2_0_29365919
eNFA0_0_33667455 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_251973
eNFA0_0_33667455 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_42586845
eNFA0_0_33667455 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_58440016
eNFA0_0_33667455 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_62966687
eNFA0_0_33667455 -->|"/
BeginToken 'blockComment'"|eNFA3_1_26982424
eNFA0_0_33667455 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_38092711
eNFA1_2_42709316 -.->|"ε
BeginToken 'integer'"|eNFA1_0_56198103
eNFA1_2_42709316 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_58440016
eNFA2_2_34571641 -.->|"ε
BeginToken ','"|eNFA2_0_29365919
eNFA2_2_34571641 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_62966687
eNFA3_16_48839530 -.->|"ε
BeginToken 'blockComment'"|eNFA3_0_251973
eNFA3_16_48839530 -->|"/
BeginToken 'blockComment'"|eNFA3_1_26982424
eNFA4_5_36902586 -.->|"ε
BeginToken 'inlineComment'"|eNFA4_0_42586845
eNFA4_5_36902586 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_38092711
eNFA1_0_56198103 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_58440016
eNFA2_0_29365919 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_62966687
eNFA3_0_251973 -->|"/
BeginToken 'blockComment'"|eNFA3_1_26982424
eNFA4_0_42586845 -->|"/
BeginToken 'inlineComment'"|eNFA4_1_38092711
eNFA1_1_58440016 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_58440016
eNFA1_1_58440016 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_36020887
eNFA1_1_58440016 -.->|"ε"|eNFA1_4_33089041
eNFA1_1_58440016 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_49022807
eNFA1_1_58440016 -.->|"ε
CheckToken 'integer'"|eNFA0_1_42729680
eNFA2_1_62966687 -.->|"ε
ExtendToken ','"|eNFA2_3_29829272
eNFA2_1_62966687 -.->|"ε"|eNFA2_4_27997
eNFA2_1_62966687 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_19660823
eNFA2_1_62966687 -.->|"ε
CheckToken ','"|eNFA0_1_42729680
eNFA3_1_26982424 -.->|"ε"|eNFA3_2_65610739
eNFA3_1_26982424 -->|"*"|eNFA3_3_23414560
eNFA4_1_38092711 -.->|"ε"|eNFA4_2_7290082
eNFA4_1_38092711 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_62262011
eNFA1_3_36020887 -.->|"ε"|eNFA1_4_33089041
eNFA1_3_36020887 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_49022807
eNFA1_3_36020887 -.->|"ε
CheckToken 'integer'"|eNFA0_1_42729680
eNFA1_4_33089041 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_49022807
eNFA1_4_33089041 -.->|"ε
CheckToken 'integer'"|eNFA0_1_42729680
eNFA1_5_49022807 -.->|"ε
CheckToken 'integer'"|eNFA0_1_42729680
eNFA2_3_29829272 -.->|"ε"|eNFA2_4_27997
eNFA2_3_29829272 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_19660823
eNFA2_3_29829272 -.->|"ε
CheckToken ','"|eNFA0_1_42729680
eNFA2_4_27997 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_19660823
eNFA2_4_27997 -.->|"ε
CheckToken ','"|eNFA0_1_42729680
eNFA2_5_19660823 -.->|"ε
CheckToken ','"|eNFA0_1_42729680
eNFA3_2_65610739 -->|"*"|eNFA3_3_23414560
eNFA3_3_23414560 -.->|"ε"|eNFA3_6_38552084
eNFA3_3_23414560 -.->|"ε"|eNFA3_4_35711100
eNFA3_3_23414560 -.->|"ε"|eNFA3_8_11424440
eNFA3_3_23414560 -.->|"ε"|eNFA3_7_52964449
eNFA3_3_23414560 -->|"[^*]"|eNFA3_5_17531178
eNFA3_3_23414560 -->|"[*]"|eNFA3_9_53625739
eNFA3_3_23414560 -.->|"ε"|eNFA3_12_9404449
eNFA3_3_23414560 -->|"*"|eNFA3_13_48717564
eNFA4_2_7290082 -->|"/
ExtendToken 'inlineComment'"|eNFA4_3_62262011
eNFA4_3_62262011 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_4_6918001
eNFA4_3_62262011 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_6918001
eNFA4_3_62262011 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_23487194
eNFA4_3_62262011 -.->|"ε"|eNFA4_7_47737289
eNFA4_3_62262011 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_64576684
eNFA4_3_62262011 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_42729680
eNFA3_6_38552084 -.->|"ε"|eNFA3_4_35711100
eNFA3_6_38552084 -.->|"ε"|eNFA3_8_11424440
eNFA3_6_38552084 -.->|"ε"|eNFA3_7_52964449
eNFA3_6_38552084 -->|"[^*]"|eNFA3_5_17531178
eNFA3_6_38552084 -->|"[*]"|eNFA3_9_53625739
eNFA3_6_38552084 -.->|"ε"|eNFA3_6_38552084
eNFA3_6_38552084 -.->|"ε"|eNFA3_12_9404449
eNFA3_6_38552084 -->|"*"|eNFA3_13_48717564
eNFA3_4_35711100 -->|"[^*]"|eNFA3_5_17531178
eNFA3_8_11424440 -->|"[*]"|eNFA3_9_53625739
eNFA3_7_52964449 -.->|"ε"|eNFA3_6_38552084
eNFA3_7_52964449 -.->|"ε"|eNFA3_12_9404449
eNFA3_7_52964449 -.->|"ε"|eNFA3_4_35711100
eNFA3_7_52964449 -.->|"ε"|eNFA3_8_11424440
eNFA3_7_52964449 -.->|"ε"|eNFA3_7_52964449
eNFA3_7_52964449 -->|"[^*]"|eNFA3_5_17531178
eNFA3_7_52964449 -->|"[*]"|eNFA3_9_53625739
eNFA3_7_52964449 -->|"*"|eNFA3_13_48717564
eNFA3_5_17531178 -.->|"ε"|eNFA3_7_52964449
eNFA3_5_17531178 -.->|"ε"|eNFA3_6_38552084
eNFA3_5_17531178 -.->|"ε"|eNFA3_12_9404449
eNFA3_5_17531178 -.->|"ε"|eNFA3_4_35711100
eNFA3_5_17531178 -.->|"ε"|eNFA3_8_11424440
eNFA3_5_17531178 -->|"[^*]"|eNFA3_5_17531178
eNFA3_5_17531178 -->|"[*]"|eNFA3_9_53625739
eNFA3_5_17531178 -->|"*"|eNFA3_13_48717564
eNFA3_9_53625739 -.->|"ε"|eNFA3_10_12869603
eNFA3_9_53625739 -->|"[^/]"|eNFA3_11_44319244
eNFA3_12_9404449 -->|"*"|eNFA3_13_48717564
eNFA3_13_48717564 -.->|"ε"|eNFA3_14_41515225
eNFA3_13_48717564 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_2267763
eNFA4_4_6918001 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA4_4_6918001
eNFA4_4_6918001 -.->|"ε
ExtendToken 'inlineComment'"|eNFA4_6_23487194
eNFA4_4_6918001 -.->|"ε"|eNFA4_7_47737289
eNFA4_4_6918001 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_64576684
eNFA4_4_6918001 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_42729680
eNFA4_6_23487194 -.->|"ε"|eNFA4_7_47737289
eNFA4_6_23487194 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_64576684
eNFA4_6_23487194 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_42729680
eNFA4_7_47737289 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA4_8_64576684
eNFA4_7_47737289 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_42729680
eNFA4_8_64576684 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_42729680
eNFA3_10_12869603 -->|"[^/]"|eNFA3_11_44319244
eNFA3_11_44319244 -.->|"ε"|eNFA3_7_52964449
eNFA3_11_44319244 -.->|"ε"|eNFA3_6_38552084
eNFA3_11_44319244 -.->|"ε"|eNFA3_12_9404449
eNFA3_11_44319244 -.->|"ε"|eNFA3_4_35711100
eNFA3_11_44319244 -.->|"ε"|eNFA3_8_11424440
eNFA3_11_44319244 -->|"[^*]"|eNFA3_5_17531178
eNFA3_11_44319244 -->|"[*]"|eNFA3_9_53625739
eNFA3_11_44319244 -->|"*"|eNFA3_13_48717564
eNFA3_14_41515225 -->|"/
ExtendToken 'blockComment'"|eNFA3_15_2267763
eNFA3_15_2267763 -.->|"ε
ExtendToken 'blockComment'"|eNFA3_17_20409871
eNFA3_15_2267763 -.->|"ε"|eNFA3_18_49471114
eNFA3_15_2267763 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_63328883
eNFA3_15_2267763 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_42729680
eNFA3_17_20409871 -.->|"ε"|eNFA3_18_49471114
eNFA3_17_20409871 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_63328883
eNFA3_17_20409871 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_42729680
eNFA3_18_49471114 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA3_19_63328883
eNFA3_18_49471114 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_42729680
eNFA3_19_63328883 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_42729680

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
NFA0_0_53808606("NFA0-0 wholeStart")
class NFA0_0_53808606 c1000;
NFA1_1_35804895[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_35804895 c0101;
NFA2_1_14515408[\"NFA2-1 char[1]
AcceptToken ','"/]
class NFA2_1_14515408 c0101;
NFA3_1_63529816("NFA3-1 char[1]")
NFA4_1_34897438("NFA4-1 char[1]")
NFA3_3_8120240("NFA3-3 char[1]")
NFA4_3_45641491[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_45641491 c0101;
NFA3_5_53759727("NFA3-5 scope[1]")
NFA3_9_5973303("NFA3-9 scope[1]")
NFA3_13_14075498("NFA3-13 char[1]")
NFA4_4_59570626[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_59570626 c0101;
NFA3_11_60491410("NFA3-11 scope[1]")
NFA3_15_66373591[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_66373591 c0101;
NFA0_0_53808606 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_35804895
NFA0_0_53808606 -->|",
BeginToken ','
ExtendToken ','"|NFA2_1_14515408
NFA0_0_53808606 -->|"/
BeginToken 'blockComment'"|NFA3_1_63529816
NFA0_0_53808606 -->|"/
BeginToken 'inlineComment'"|NFA4_1_34897438
NFA1_1_35804895 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_35804895
NFA3_1_63529816 -->|"*"|NFA3_3_8120240
NFA4_1_34897438 -->|"/
ExtendToken 'inlineComment'"|NFA4_3_45641491
NFA3_3_8120240 -->|"[^*]"|NFA3_5_53759727
NFA3_3_8120240 -->|"[*]"|NFA3_9_5973303
NFA3_3_8120240 -->|"*"|NFA3_13_14075498
NFA4_3_45641491 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_59570626
NFA3_5_53759727 -->|"[^*]"|NFA3_5_53759727
NFA3_5_53759727 -->|"[*]"|NFA3_9_5973303
NFA3_5_53759727 -->|"*"|NFA3_13_14075498
NFA3_9_5973303 -->|"[^/]"|NFA3_11_60491410
NFA3_13_14075498 -->|"/
ExtendToken 'blockComment'"|NFA3_15_66373591
NFA4_4_59570626 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA4_4_59570626
NFA3_11_60491410 -->|"[^*]"|NFA3_5_53759727
NFA3_11_60491410 -->|"[*]"|NFA3_9_5973303
NFA3_11_60491410 -->|"*"|NFA3_13_14075498

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
subgraph DFA0_2038251495["DFA0 wholeStart"]
NFA0_0_53808606_0("NFA0-0 wholeStart")
class NFA0_0_53808606_0 c1000;
end
class DFA0_2038251495 c1000;
subgraph DFA1_1487296350["DFA1 {1}"]
NFA1_1_35804895_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_35804895_1 c0101;
end
class DFA1_1487296350 c0101;
subgraph DFA2_-1392431268["DFA2 {1}"]
NFA2_1_14515408_2[\"NFA2-1 char[1]
AcceptToken ','"/]
class NFA2_1_14515408_2 c0101;
end
class DFA2_-1392431268 c0101;
subgraph DFA3_1205905158["DFA3 {2}"]
NFA3_1_63529816_3("NFA3-1 char[1]")
NFA4_1_34897438_4("NFA4-1 char[1]")
end
subgraph DFA4_1973535163["DFA4 {1}"]
NFA3_3_8120240_5("NFA3-3 char[1]")
end
subgraph DFA5_-1142252594["DFA5 {1}"]
NFA4_3_45641491_6[\"NFA4-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA4_3_45641491_6 c0101;
end
class DFA5_-1142252594 c0101;
subgraph DFA6_-1142954445["DFA6 {1}"]
NFA3_5_53759727_7("NFA3-5 scope[1]")
end
subgraph DFA7_-1142139582["DFA7 {2}"]
NFA3_9_5973303_8("NFA3-9 scope[1]")
NFA3_13_14075498_9("NFA3-13 char[1]")
end
subgraph DFA8_385616071["DFA8 {1}"]
NFA4_4_59570626_10[\"NFA4-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA4_4_59570626_10 c0101;
end
class DFA8_385616071 c0101;
subgraph DFA9_-521944197["DFA9 {1}"]
NFA3_11_60491410_11("NFA3-11 scope[1]")
end
subgraph DFA10_75909841["DFA10 {1}"]
NFA3_15_66373591_12[\"NFA3-15 char[1]
AcceptToken 'blockComment'"/]
class NFA3_15_66373591_12 c0101;
end
class DFA10_75909841 c0101;
DFA0_2038251495 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1487296350
DFA0_2038251495 -->|",
BeginToken ','
ExtendToken ','"|DFA2_-1392431268
DFA0_2038251495 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_1205905158
DFA1_1487296350 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1487296350
DFA3_1205905158 -->|"*"|DFA4_1973535163
DFA3_1205905158 -->|"/
ExtendToken 'inlineComment'"|DFA5_-1142252594
DFA4_1973535163 -->|"[^*]"|DFA6_-1142954445
DFA4_1973535163 -->|"*"|DFA7_-1142139582
DFA5_-1142252594 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA8_385616071
DFA6_-1142954445 -->|"[^*]"|DFA6_-1142954445
DFA6_-1142954445 -->|"*"|DFA7_-1142139582
DFA7_-1142139582 -->|"[^/]"|DFA9_-521944197
DFA7_-1142139582 -->|"/
ExtendToken 'blockComment'"|DFA10_75909841
DFA8_385616071 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA8_385616071
DFA9_-521944197 -->|"[^*]"|DFA6_-1142954445
DFA9_-521944197 -->|"*"|DFA7_-1142139582

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
DFA0_2038251495{{"DFA0 wholeStart"}}
class DFA0_2038251495 c1000;
DFA1_1487296350[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1487296350 c0101;
DFA2_-1392431268[\"DFA2 {1}
AcceptToken ','"/]
class DFA2_-1392431268 c0101;
DFA3_1205905158{{"DFA3 {2}"}}
DFA4_1973535163{{"DFA4 {1}"}}
DFA5_-1142252594[\"DFA5 {1}
AcceptToken 'inlineComment'"/]
class DFA5_-1142252594 c0101;
DFA6_-1142954445{{"DFA6 {1}"}}
DFA7_-1142139582{{"DFA7 {2}"}}
DFA8_385616071[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_385616071 c0101;
DFA9_-521944197{{"DFA9 {1}"}}
DFA10_75909841[\"DFA10 {1}
AcceptToken 'blockComment'"/]
class DFA10_75909841 c0101;
DFA0_2038251495 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1487296350
DFA0_2038251495 -->|",
BeginToken ','
ExtendToken ','"|DFA2_-1392431268
DFA0_2038251495 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_1205905158
DFA1_1487296350 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1487296350
DFA3_1205905158 -->|"*"|DFA4_1973535163
DFA3_1205905158 -->|"/
ExtendToken 'inlineComment'"|DFA5_-1142252594
DFA4_1973535163 -->|"[^*]"|DFA6_-1142954445
DFA4_1973535163 -->|"*"|DFA7_-1142139582
DFA5_-1142252594 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA8_385616071
DFA6_-1142954445 -->|"[^*]"|DFA6_-1142954445
DFA6_-1142954445 -->|"*"|DFA7_-1142139582
DFA7_-1142139582 -->|"[^/]"|DFA9_-521944197
DFA7_-1142139582 -->|"/
ExtendToken 'blockComment'"|DFA10_75909841
DFA8_385616071 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA8_385616071
DFA9_-521944197 -->|"[^*]"|DFA6_-1142954445
DFA9_-521944197 -->|"*"|DFA7_-1142139582

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
subgraph MiniDFA0_-1927124090["MiniDFA0 {1}"]
DFA0_2038251495_0{{"DFA0 wholeStart"}}
class DFA0_2038251495_0 c1000;
end
class MiniDFA0_-1927124090 c1000;
subgraph MiniDFA4_197586790["MiniDFA4 {1}"]
DFA1_1487296350_1[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1487296350_1 c0101;
end
class MiniDFA4_197586790 c0101;
subgraph MiniDFA5_-1818913402["MiniDFA5 {1}"]
DFA2_-1392431268_2[\"DFA2 {1}
AcceptToken ','"/]
class DFA2_-1392431268_2 c0101;
end
class MiniDFA5_-1818913402 c0101;
subgraph MiniDFA1_-1621108429["MiniDFA1 {1}"]
DFA3_1205905158_3{{"DFA3 {2}"}}
end
subgraph MiniDFA2_729083013["MiniDFA2 {3}"]
DFA4_1973535163_4{{"DFA4 {1}"}}
DFA6_-1142954445_5{{"DFA6 {1}"}}
DFA9_-521944197_6{{"DFA9 {1}"}}
end
subgraph MiniDFA6_1259046490["MiniDFA6 {1}"]
DFA5_-1142252594_7[\"DFA5 {1}
AcceptToken 'inlineComment'"/]
class DFA5_-1142252594_7 c0101;
end
class MiniDFA6_1259046490 c0101;
subgraph MiniDFA3_1123870596["MiniDFA3 {1}"]
DFA7_-1142139582_8{{"DFA7 {2}"}}
end
subgraph MiniDFA7_-1447067160["MiniDFA7 {1}"]
DFA8_385616071_9[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_385616071_9 c0101;
end
class MiniDFA7_-1447067160 c0101;
subgraph MiniDFA8_-60327706["MiniDFA8 {1}"]
DFA10_75909841_10[\"DFA10 {1}
AcceptToken 'blockComment'"/]
class DFA10_75909841_10 c0101;
end
class MiniDFA8_-60327706 c0101;
MiniDFA0_-1927124090 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA4_197586790
MiniDFA0_-1927124090 -->|",
BeginToken ','
ExtendToken ','"|MiniDFA5_-1818913402
MiniDFA0_-1927124090 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1621108429
MiniDFA4_197586790 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA4_197586790
MiniDFA1_-1621108429 -->|"*"|MiniDFA2_729083013
MiniDFA1_-1621108429 -->|"/
ExtendToken 'inlineComment'"|MiniDFA6_1259046490
MiniDFA2_729083013 -->|"[^*]"|MiniDFA2_729083013
MiniDFA2_729083013 -->|"*"|MiniDFA3_1123870596
MiniDFA6_1259046490 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA7_-1447067160
MiniDFA3_1123870596 -->|"[^/]"|MiniDFA2_729083013
MiniDFA3_1123870596 -->|"/
ExtendToken 'blockComment'"|MiniDFA8_-60327706
MiniDFA7_-1447067160 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA7_-1447067160

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
MiniDFA0_-1927124090(["MiniDFA0 {1}"])
class MiniDFA0_-1927124090 c1000;
MiniDFA4_197586790[\"MiniDFA4 {1}
AcceptToken 'integer'"/]
class MiniDFA4_197586790 c0101;
MiniDFA5_-1818913402[\"MiniDFA5 {1}
AcceptToken ','"/]
class MiniDFA5_-1818913402 c0101;
MiniDFA1_-1621108429(["MiniDFA1 {1}"])
MiniDFA2_729083013(["MiniDFA2 {3}"])
MiniDFA6_1259046490[\"MiniDFA6 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA6_1259046490 c0101;
MiniDFA3_1123870596(["MiniDFA3 {1}"])
MiniDFA7_-1447067160[\"MiniDFA7 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA7_-1447067160 c0101;
MiniDFA8_-60327706[\"MiniDFA8 {1}
AcceptToken 'blockComment'"/]
class MiniDFA8_-60327706 c0101;
MiniDFA0_-1927124090 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA4_197586790
MiniDFA0_-1927124090 -->|",
BeginToken ','
ExtendToken ','"|MiniDFA5_-1818913402
MiniDFA0_-1927124090 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-1621108429
MiniDFA4_197586790 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA4_197586790
MiniDFA1_-1621108429 -->|"*"|MiniDFA2_729083013
MiniDFA1_-1621108429 -->|"/
ExtendToken 'inlineComment'"|MiniDFA6_1259046490
MiniDFA2_729083013 -->|"[^*]"|MiniDFA2_729083013
MiniDFA2_729083013 -->|"*"|MiniDFA3_1123870596
MiniDFA6_1259046490 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA7_-1447067160
MiniDFA3_1123870596 -->|"[^/]"|MiniDFA2_729083013
MiniDFA3_1123870596 -->|"/
ExtendToken 'blockComment'"|MiniDFA8_-60327706
MiniDFA7_-1447067160 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA7_-1447067160

```

# 总结

无。

