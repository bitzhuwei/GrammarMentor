# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Error`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（13个State）。

## 'refVt'
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
eNFA0_6_53402119[["εNFA0-6 regex start"]]
eNFA0_2_52681125[["εNFA0-2 regex start"]]
eNFA0_0_39312736[["εNFA0-0 char{1, 1}"]]
eNFA0_4_4368081[["εNFA0-4 scope{1, 1}"]]
eNFA0_1_3499754[["εNFA0-1 char[1]"]]
eNFA0_5_18270305[["εNFA0-5 scope[1]"]]
eNFA0_3_30215023[["εNFA0-3 regex end"]]
eNFA0_2_31497787[["εNFA0-2 regex start"]]
eNFA0_0_1183915[["εNFA0-0 char{1, 1}"]]
eNFA0_4_15044627[["εNFA0-4 scope{1, 1}"]]
eNFA0_3_28788263[["εNFA0-3 regex end"]]
eNFA0_1_57767782[["εNFA0-1 char[1]"]]
eNFA0_5_10655236[["εNFA0-5 scope[1]"]]
eNFA0_7_50147992[["εNFA0-7 regex end"]]
eNFA0_6_53402119 -.->|"ε"|eNFA0_2_52681125
eNFA0_2_52681125 -.->|"ε"|eNFA0_0_39312736
eNFA0_2_52681125 -.->|"ε"|eNFA0_4_4368081
eNFA0_0_39312736 -->|"#92;"|eNFA0_1_3499754
eNFA0_4_4368081 -->|"[Y-#92;]"|eNFA0_5_18270305
eNFA0_1_3499754 -.->|"ε"|eNFA0_3_30215023
eNFA0_5_18270305 -.->|"ε"|eNFA0_3_30215023
eNFA0_3_30215023 -.->|"ε"|eNFA0_2_31497787
eNFA0_2_31497787 -.->|"ε"|eNFA0_0_1183915
eNFA0_2_31497787 -.->|"ε"|eNFA0_4_15044627
eNFA0_2_31497787 -.->|"ε"|eNFA0_3_28788263
eNFA0_0_1183915 -->|"#92;"|eNFA0_1_57767782
eNFA0_4_15044627 -->|"[Y-#92;]"|eNFA0_5_10655236
eNFA0_3_28788263 -.->|"ε"|eNFA0_2_31497787
eNFA0_3_28788263 -.->|"ε"|eNFA0_7_50147992
eNFA0_1_57767782 -.->|"ε"|eNFA0_3_28788263
eNFA0_5_10655236 -.->|"ε"|eNFA0_3_28788263
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
eNFA0_8_14270750[["εNFA0-8 post-regex start"]]
eNFA0_9_61327894[\"εNFA0-9 post-regex end"/]
eNFA0_8_14270750 -.->|"ε"|eNFA0_9_61327894
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
eNFA0_16_59167590[["εNFA0-16 regex start"]]
eNFA0_0_62746268[["εNFA0-0 char{1, 1}"]]
eNFA0_1_27845503[["εNFA0-1 char[1]"]]
eNFA0_2_49282936[["εNFA0-2 char{1, 1}"]]
eNFA0_3_63248778[["εNFA0-3 char[1]"]]
eNFA0_6_35455590[["εNFA0-6 regex start"]]
eNFA0_4_53330552[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_50664859[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_24807479[["εNFA0-7 regex end"]]
eNFA0_5_21940722[["εNFA0-5 scope[1]"]]
eNFA0_9_66418347[["εNFA0-9 scope[1]"]]
eNFA0_12_32368095[["εNFA0-12 char{1, 1}"]]
eNFA0_10_32922880[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_27870469[["εNFA0-13 char[1]"]]
eNFA0_11_10212927[["εNFA0-11 scope[1]"]]
eNFA0_14_49507636[["εNFA0-14 char{1, 1}"]]
eNFA0_15_50695543[["εNFA0-15 char[1]"]]
eNFA0_17_53606711[["εNFA0-17 regex end"]]
eNFA0_16_59167590 -.->|"ε"|eNFA0_0_62746268
eNFA0_0_62746268 -->|"/"|eNFA0_1_27845503
eNFA0_1_27845503 -.->|"ε"|eNFA0_2_49282936
eNFA0_2_49282936 -->|"*"|eNFA0_3_63248778
eNFA0_3_63248778 -.->|"ε"|eNFA0_6_35455590
eNFA0_6_35455590 -.->|"ε"|eNFA0_4_53330552
eNFA0_6_35455590 -.->|"ε"|eNFA0_8_50664859
eNFA0_6_35455590 -.->|"ε"|eNFA0_7_24807479
eNFA0_4_53330552 -->|"[^*]"|eNFA0_5_21940722
eNFA0_8_50664859 -->|"[*]"|eNFA0_9_66418347
eNFA0_7_24807479 -.->|"ε"|eNFA0_6_35455590
eNFA0_7_24807479 -.->|"ε"|eNFA0_12_32368095
eNFA0_5_21940722 -.->|"ε"|eNFA0_7_24807479
eNFA0_9_66418347 -.->|"ε"|eNFA0_10_32922880
eNFA0_12_32368095 -->|"*"|eNFA0_13_27870469
eNFA0_10_32922880 -->|"[^/]"|eNFA0_11_10212927
eNFA0_13_27870469 -.->|"ε"|eNFA0_14_49507636
eNFA0_11_10212927 -.->|"ε"|eNFA0_7_24807479
eNFA0_14_49507636 -->|"/"|eNFA0_15_50695543
eNFA0_15_50695543 -.->|"ε"|eNFA0_17_53606711
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
eNFA0_18_12698356[["εNFA0-18 post-regex start"]]
eNFA0_19_47176343[\"εNFA0-19 post-regex end"/]
eNFA0_18_12698356 -.->|"ε"|eNFA0_19_47176343
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
eNFA0_5_22098140[["εNFA0-5 regex start"]]
eNFA0_0_64665535[["εNFA0-0 char{1, 1}"]]
eNFA0_1_45118907[["εNFA0-1 char[1]"]]
eNFA0_2_3416986[["εNFA0-2 char{1, 1}"]]
eNFA0_3_4570028[["εNFA0-3 char[1]"]]
eNFA0_4_41130254[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_34627969[["εNFA0-6 regex end"]]
eNFA0_5_22098140 -.->|"ε"|eNFA0_0_64665535
eNFA0_0_64665535 -->|"/"|eNFA0_1_45118907
eNFA0_1_45118907 -.->|"ε"|eNFA0_2_3416986
eNFA0_2_3416986 -->|"/"|eNFA0_3_4570028
eNFA0_3_4570028 -.->|"ε"|eNFA0_4_41130254
eNFA0_4_41130254 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_41130254
eNFA0_4_41130254 -.->|"ε"|eNFA0_6_34627969
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
eNFA0_7_4485813[["εNFA0-7 post-regex start"]]
eNFA0_8_40372317[\"εNFA0-8 post-regex end"/]
eNFA0_7_4485813 -.->|"ε"|eNFA0_8_40372317
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
eNFA0_0_12405375[["εNFA0-0 wholeStart"]]
eNFA1_6_57198891[["εNFA1-6 regex start"]]
class eNFA1_6_57198891 c1000;
eNFA2_16_44539515[["εNFA2-16 regex start"]]
class eNFA2_16_44539515 c1000;
eNFA3_5_23562574[["εNFA3-5 regex start"]]
class eNFA3_5_23562574 c1000;
eNFA1_2_16346001[["εNFA1-2 regex start"]]
eNFA2_0_55725192[["εNFA2-0 char{1, 1}"]]
eNFA3_0_29520332[["εNFA3-0 char{1, 1}"]]
eNFA1_0_48957711[["εNFA1-0 char{1, 1}"]]
eNFA1_4_12896286[["εNFA1-4 scope{1, 1}"]]
eNFA2_1_9113635[["εNFA2-1 char[1]"]]
eNFA3_1_14913854[["εNFA3-1 char[1]"]]
eNFA1_1_55365254[["εNFA1-1 char[1]"]]
eNFA1_5_37966223[["εNFA1-5 scope[1]"]]
eNFA2_2_6965[["εNFA2-2 char{1, 1}"]]
eNFA3_2_62687[["εNFA3-2 char{1, 1}"]]
eNFA1_3_6151694[["εNFA1-3 regex end"]]
eNFA2_3_34359256[["εNFA2-3 char[1]"]]
eNFA3_3_35088084[["εNFA3-3 char[1]"]]
eNFA1_2_28525238[["εNFA1-2 regex start"]]
eNFA2_6_23387474[["εNFA2-6 regex start"]]
eNFA3_4_3898676[["εNFA3-4 char{0, ∞}"]]
eNFA1_0_28842926[["εNFA1-0 char{1, 1}"]]
eNFA1_4_55400552[["εNFA1-4 scope{1, 1}"]]
eNFA1_3_58259743[["εNFA1-3 regex end"]]
eNFA2_4_15337269[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_9160681[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_3817695[["εNFA2-7 regex end"]]
eNFA3_6_47357306[["εNFA3-6 regex end"]]
class eNFA3_6_47357306 c0100;
eNFA1_1_21418771[["εNFA1-1 char[1]"]]
eNFA1_5_58551215[["εNFA1-5 scope[1]"]]
eNFA1_7_54575646[["εNFA1-7 regex end"]]
class eNFA1_7_54575646 c0100;
eNFA2_5_31636323[["εNFA2-5 scope[1]"]]
eNFA2_9_48873995[["εNFA2-9 scope[1]"]]
eNFA2_12_40797849[["εNFA2-12 char{1, 1}"]]
eNFA3_7_64356400[["εNFA3-7 post-regex start"]]
class eNFA3_7_64356400 c0010;
eNFA1_8_45027976[["εNFA1-8 post-regex start"]]
class eNFA1_8_45027976 c0010;
eNFA2_10_31498117[["εNFA2-10 scope{1, 1}"]]
eNFA2_13_15047603[["εNFA2-13 char[1]"]]
eNFA3_8_10736577[\"εNFA3-8 post-regex end"/]
class eNFA3_8_10736577 c0001;
eNFA1_9_2598608[\"εNFA1-9 post-regex end"/]
class eNFA1_9_2598608 c0001;
eNFA2_11_16291455[["εNFA2-11 scope[1]"]]
eNFA2_14_1210700[["εNFA2-14 char{1, 1}"]]
eNFA0_1_50930930[\"εNFA0-1 wholeEnd"/]
eNFA2_15_31764686[["εNFA2-15 char[1]"]]
eNFA2_17_17446726[["εNFA2-17 regex end"]]
class eNFA2_17_17446726 c0100;
eNFA2_18_22802807[["εNFA2-18 post-regex start"]]
class eNFA2_18_22802807 c0010;
eNFA2_19_65311315[\"εNFA2-19 post-regex end"/]
class eNFA2_19_65311315 c0001;
eNFA0_0_12405375 -.->|"ε"|eNFA1_6_57198891
eNFA0_0_12405375 -.->|"ε"|eNFA2_16_44539515
eNFA0_0_12405375 -.->|"ε"|eNFA3_5_23562574
eNFA1_6_57198891 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_16346001
eNFA2_16_44539515 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_55725192
eNFA3_5_23562574 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_29520332
eNFA1_2_16346001 -.->|"ε"|eNFA1_0_48957711
eNFA1_2_16346001 -.->|"ε"|eNFA1_4_12896286
eNFA2_0_55725192 -->|"/"|eNFA2_1_9113635
eNFA3_0_29520332 -->|"/"|eNFA3_1_14913854
eNFA1_0_48957711 -->|"#92;"|eNFA1_1_55365254
eNFA1_4_12896286 -->|"[Y-#92;]"|eNFA1_5_37966223
eNFA2_1_9113635 -.->|"ε"|eNFA2_2_6965
eNFA3_1_14913854 -.->|"ε"|eNFA3_2_62687
eNFA1_1_55365254 -.->|"ε"|eNFA1_3_6151694
eNFA1_5_37966223 -.->|"ε"|eNFA1_3_6151694
eNFA2_2_6965 -->|"*"|eNFA2_3_34359256
eNFA3_2_62687 -->|"/"|eNFA3_3_35088084
eNFA1_3_6151694 -.->|"ε"|eNFA1_2_28525238
eNFA2_3_34359256 -.->|"ε"|eNFA2_6_23387474
eNFA3_3_35088084 -.->|"ε"|eNFA3_4_3898676
eNFA1_2_28525238 -.->|"ε"|eNFA1_0_28842926
eNFA1_2_28525238 -.->|"ε"|eNFA1_4_55400552
eNFA1_2_28525238 -.->|"ε"|eNFA1_3_58259743
eNFA2_6_23387474 -.->|"ε"|eNFA2_4_15337269
eNFA2_6_23387474 -.->|"ε"|eNFA2_8_9160681
eNFA2_6_23387474 -.->|"ε"|eNFA2_7_3817695
eNFA3_4_3898676 -->|"[#92;t#92;r#32;-~]"|eNFA3_4_3898676
eNFA3_4_3898676 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_47357306
eNFA1_0_28842926 -->|"#92;"|eNFA1_1_21418771
eNFA1_4_55400552 -->|"[Y-#92;]"|eNFA1_5_58551215
eNFA1_3_58259743 -.->|"ε"|eNFA1_2_28525238
eNFA1_3_58259743 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_54575646
eNFA2_4_15337269 -->|"[^*]"|eNFA2_5_31636323
eNFA2_8_9160681 -->|"[*]"|eNFA2_9_48873995
eNFA2_7_3817695 -.->|"ε"|eNFA2_6_23387474
eNFA2_7_3817695 -.->|"ε"|eNFA2_12_40797849
eNFA3_6_47357306 -.->|"ε"|eNFA3_7_64356400
eNFA1_1_21418771 -.->|"ε"|eNFA1_3_58259743
eNFA1_5_58551215 -.->|"ε"|eNFA1_3_58259743
eNFA1_7_54575646 -.->|"ε"|eNFA1_8_45027976
eNFA2_5_31636323 -.->|"ε"|eNFA2_7_3817695
eNFA2_9_48873995 -.->|"ε"|eNFA2_10_31498117
eNFA2_12_40797849 -->|"*"|eNFA2_13_15047603
eNFA3_7_64356400 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_10736577
eNFA1_8_45027976 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_2598608
eNFA2_10_31498117 -->|"[^/]"|eNFA2_11_16291455
eNFA2_13_15047603 -.->|"ε"|eNFA2_14_1210700
eNFA3_8_10736577 -.->|"ε"|eNFA0_1_50930930
eNFA1_9_2598608 -.->|"ε"|eNFA0_1_50930930
eNFA2_11_16291455 -.->|"ε"|eNFA2_7_3817695
eNFA2_14_1210700 -->|"/"|eNFA2_15_31764686
eNFA2_15_31764686 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_17446726
eNFA2_17_17446726 -.->|"ε"|eNFA2_18_22802807
eNFA2_18_22802807 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_65311315
eNFA2_19_65311315 -.->|"ε"|eNFA0_1_50930930

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
eNFA0_0_42336695[["εNFA0-0 wholeStart"]]
class eNFA0_0_42336695 c1000;
eNFA1_6_6720246[["εNFA1-6 regex start"]]
class eNFA1_6_6720246 c1000;
eNFA2_16_45485936[["εNFA2-16 regex start"]]
class eNFA2_16_45485936 c1000;
eNFA3_5_60482217[["εNFA3-5 regex start"]]
class eNFA3_5_60482217 c1000;
eNFA1_2_7469042[["εNFA1-2 regex start"]]
class eNFA1_2_7469042 c1000;
eNFA2_0_54956439[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_54956439 c1000;
eNFA3_0_60384317[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_60384317 c1000;
eNFA1_0_1012626[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_1012626 c1000;
eNFA1_4_112514[["εNFA1-4 scope{1, 1}"]]
class eNFA1_4_112514 c1000;
eNFA1_1_45699530[\"εNFA1-1 char[1]
AcceptToken 'refVt'"/]
class eNFA1_1_45699530 c0111;
eNFA1_5_564191[\"εNFA1-5 scope[1]
AcceptToken 'refVt'"/]
class eNFA1_5_564191 c0111;
eNFA2_1_59291480[["εNFA2-1 char[1]"]]
eNFA3_1_37880580[["εNFA3-1 char[1]"]]
eNFA1_3_5077725[\"εNFA1-3 regex end
AcceptToken 'refVt'"/]
class eNFA1_3_5077725 c0111;
eNFA1_2_8642591[\"εNFA1-2 regex start
AcceptToken 'refVt'"/]
class eNFA1_2_8642591 c0111;
eNFA1_0_28961294[\"εNFA1-0 char{1, 1}"/]
eNFA1_4_10674462[\"εNFA1-4 scope{1, 1}"/]
eNFA1_3_59325057[\"εNFA1-3 regex end
AcceptToken 'refVt'"/]
class eNFA1_3_59325057 c0111;
eNFA1_1_61444595[\"εNFA1-1 char[1]
AcceptToken 'refVt'"/]
class eNFA1_1_61444595 c0111;
eNFA1_5_16130451[\"εNFA1-5 scope[1]
AcceptToken 'refVt'"/]
class eNFA1_5_16130451 c0111;
eNFA1_7_50169686[\"εNFA1-7 regex end
AcceptToken 'refVt'"/]
class eNFA1_7_50169686 c0111;
eNFA1_8_43388973[\"εNFA1-8 post-regex start
AcceptToken 'refVt'"/]
class eNFA1_8_43388973 c0011;
eNFA1_9_10896307[\"εNFA1-9 post-regex end"/]
class eNFA1_9_10896307 c0011;
eNFA0_1_30957904[\"εNFA0-1 wholeEnd"/]
eNFA2_2_48428136[["εNFA2-2 char{1, 1}"]]
eNFA2_3_37212772[["εNFA2-3 char[1]"]]
eNFA3_2_5380904[["εNFA3-2 char{1, 1}"]]
eNFA3_3_23817504[\"εNFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA3_3_23817504 c0111;
eNFA2_6_64163473[["εNFA2-6 regex start"]]
eNFA2_4_29858833[["εNFA2-4 scope{1, 1}"]]
eNFA2_8_40600350[["εNFA2-8 scope{1, 1}"]]
eNFA2_7_294043[["εNFA2-7 regex end"]]
eNFA2_5_10956331[["εNFA2-5 scope[1]"]]
eNFA2_9_33200047[["εNFA2-9 scope[1]"]]
eNFA2_12_66479500[["εNFA2-12 char{1, 1}"]]
eNFA2_13_4849307[["εNFA2-13 char[1]"]]
eNFA3_4_2646389[\"εNFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA3_4_2646389 c0111;
eNFA3_6_13030950[\"εNFA3-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA3_6_13030950 c0111;
eNFA3_7_6587942[\"εNFA3-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA3_7_6587942 c0011;
eNFA3_8_10185684[\"εNFA3-8 post-regex end"/]
class eNFA3_8_10185684 c0011;
eNFA2_10_30364973[["εNFA2-10 scope{1, 1}"]]
eNFA2_11_24562296[["εNFA2-11 scope[1]"]]
eNFA2_14_63861276[["εNFA2-14 char{1, 1}"]]
eNFA2_15_24845910[\"εNFA2-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA2_15_24845910 c0111;
eNFA2_17_22286602[\"εNFA2-17 regex end
AcceptToken 'blockComment'"/]
class eNFA2_17_22286602 c0111;
eNFA2_18_66361692[\"εNFA2-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA2_18_66361692 c0011;
eNFA2_19_19734077[\"εNFA2-19 post-regex end"/]
class eNFA2_19_19734077 c0011;
eNFA0_0_42336695 -.->|"ε"|eNFA1_6_6720246
eNFA0_0_42336695 -.->|"ε"|eNFA2_16_45485936
eNFA0_0_42336695 -.->|"ε"|eNFA3_5_60482217
eNFA0_0_42336695 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_7469042
eNFA0_0_42336695 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_54956439
eNFA0_0_42336695 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_60384317
eNFA0_0_42336695 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_1012626
eNFA0_0_42336695 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_112514
eNFA0_0_42336695 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_45699530
eNFA0_0_42336695 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_564191
eNFA0_0_42336695 -->|"/
BeginToken 'blockComment'"|eNFA2_1_59291480
eNFA0_0_42336695 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_37880580
eNFA1_6_6720246 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_7469042
eNFA1_6_6720246 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_1012626
eNFA1_6_6720246 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_112514
eNFA1_6_6720246 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_45699530
eNFA1_6_6720246 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_564191
eNFA2_16_45485936 -.->|"ε
BeginToken 'blockComment'"|eNFA2_0_54956439
eNFA2_16_45485936 -->|"/
BeginToken 'blockComment'"|eNFA2_1_59291480
eNFA3_5_60482217 -.->|"ε
BeginToken 'inlineComment'"|eNFA3_0_60384317
eNFA3_5_60482217 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_37880580
eNFA1_2_7469042 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_1012626
eNFA1_2_7469042 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_112514
eNFA1_2_7469042 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_45699530
eNFA1_2_7469042 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_564191
eNFA2_0_54956439 -->|"/
BeginToken 'blockComment'"|eNFA2_1_59291480
eNFA3_0_60384317 -->|"/
BeginToken 'inlineComment'"|eNFA3_1_37880580
eNFA1_0_1012626 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_45699530
eNFA1_4_112514 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_564191
eNFA1_1_45699530 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_5077725
eNFA1_1_45699530 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_1_45699530 -.->|"ε"|eNFA1_0_28961294
eNFA1_1_45699530 -.->|"ε"|eNFA1_4_10674462
eNFA1_1_45699530 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_1_45699530 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_1_45699530 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_1_45699530 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_1_45699530 -.->|"ε"|eNFA1_8_43388973
eNFA1_1_45699530 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_1_45699530 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_5_564191 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_5077725
eNFA1_5_564191 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_5_564191 -.->|"ε"|eNFA1_0_28961294
eNFA1_5_564191 -.->|"ε"|eNFA1_4_10674462
eNFA1_5_564191 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_5_564191 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_5_564191 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_5_564191 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_5_564191 -.->|"ε"|eNFA1_8_43388973
eNFA1_5_564191 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_5_564191 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA2_1_59291480 -.->|"ε"|eNFA2_2_48428136
eNFA2_1_59291480 -->|"*"|eNFA2_3_37212772
eNFA3_1_37880580 -.->|"ε"|eNFA3_2_5380904
eNFA3_1_37880580 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_23817504
eNFA1_3_5077725 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_3_5077725 -.->|"ε"|eNFA1_0_28961294
eNFA1_3_5077725 -.->|"ε"|eNFA1_4_10674462
eNFA1_3_5077725 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_3_5077725 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_3_5077725 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_3_5077725 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_3_5077725 -.->|"ε"|eNFA1_8_43388973
eNFA1_3_5077725 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_3_5077725 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_2_8642591 -.->|"ε"|eNFA1_0_28961294
eNFA1_2_8642591 -.->|"ε"|eNFA1_4_10674462
eNFA1_2_8642591 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_2_8642591 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_2_8642591 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_2_8642591 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_2_8642591 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_2_8642591 -.->|"ε"|eNFA1_8_43388973
eNFA1_2_8642591 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_2_8642591 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_0_28961294 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_4_10674462 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_3_59325057 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_3_59325057 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_3_59325057 -.->|"ε"|eNFA1_0_28961294
eNFA1_3_59325057 -.->|"ε"|eNFA1_4_10674462
eNFA1_3_59325057 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_3_59325057 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_3_59325057 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_3_59325057 -.->|"ε"|eNFA1_8_43388973
eNFA1_3_59325057 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_3_59325057 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_1_61444595 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_1_61444595 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_1_61444595 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_1_61444595 -.->|"ε"|eNFA1_0_28961294
eNFA1_1_61444595 -.->|"ε"|eNFA1_4_10674462
eNFA1_1_61444595 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_1_61444595 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_1_61444595 -.->|"ε"|eNFA1_8_43388973
eNFA1_1_61444595 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_1_61444595 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_5_16130451 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_59325057
eNFA1_5_16130451 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_8642591
eNFA1_5_16130451 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_50169686
eNFA1_5_16130451 -.->|"ε"|eNFA1_0_28961294
eNFA1_5_16130451 -.->|"ε"|eNFA1_4_10674462
eNFA1_5_16130451 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_61444595
eNFA1_5_16130451 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_16130451
eNFA1_5_16130451 -.->|"ε"|eNFA1_8_43388973
eNFA1_5_16130451 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_5_16130451 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_7_50169686 -.->|"ε"|eNFA1_8_43388973
eNFA1_7_50169686 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_7_50169686 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_8_43388973 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10896307
eNFA1_8_43388973 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA1_9_10896307 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_30957904
eNFA2_2_48428136 -->|"*"|eNFA2_3_37212772
eNFA2_3_37212772 -.->|"ε"|eNFA2_6_64163473
eNFA2_3_37212772 -.->|"ε"|eNFA2_4_29858833
eNFA2_3_37212772 -.->|"ε"|eNFA2_8_40600350
eNFA2_3_37212772 -.->|"ε"|eNFA2_7_294043
eNFA2_3_37212772 -->|"[^*]"|eNFA2_5_10956331
eNFA2_3_37212772 -->|"[*]"|eNFA2_9_33200047
eNFA2_3_37212772 -.->|"ε"|eNFA2_12_66479500
eNFA2_3_37212772 -->|"*"|eNFA2_13_4849307
eNFA3_2_5380904 -->|"/
ExtendToken 'inlineComment'"|eNFA3_3_23817504
eNFA3_3_23817504 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_4_2646389
eNFA3_3_23817504 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_2646389
eNFA3_3_23817504 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_13030950
eNFA3_3_23817504 -.->|"ε"|eNFA3_7_6587942
eNFA3_3_23817504 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_10185684
eNFA3_3_23817504 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_30957904
eNFA2_6_64163473 -.->|"ε"|eNFA2_4_29858833
eNFA2_6_64163473 -.->|"ε"|eNFA2_8_40600350
eNFA2_6_64163473 -.->|"ε"|eNFA2_7_294043
eNFA2_6_64163473 -->|"[^*]"|eNFA2_5_10956331
eNFA2_6_64163473 -->|"[*]"|eNFA2_9_33200047
eNFA2_6_64163473 -.->|"ε"|eNFA2_6_64163473
eNFA2_6_64163473 -.->|"ε"|eNFA2_12_66479500
eNFA2_6_64163473 -->|"*"|eNFA2_13_4849307
eNFA2_4_29858833 -->|"[^*]"|eNFA2_5_10956331
eNFA2_8_40600350 -->|"[*]"|eNFA2_9_33200047
eNFA2_7_294043 -.->|"ε"|eNFA2_6_64163473
eNFA2_7_294043 -.->|"ε"|eNFA2_12_66479500
eNFA2_7_294043 -.->|"ε"|eNFA2_4_29858833
eNFA2_7_294043 -.->|"ε"|eNFA2_8_40600350
eNFA2_7_294043 -.->|"ε"|eNFA2_7_294043
eNFA2_7_294043 -->|"[^*]"|eNFA2_5_10956331
eNFA2_7_294043 -->|"[*]"|eNFA2_9_33200047
eNFA2_7_294043 -->|"*"|eNFA2_13_4849307
eNFA2_5_10956331 -.->|"ε"|eNFA2_7_294043
eNFA2_5_10956331 -.->|"ε"|eNFA2_6_64163473
eNFA2_5_10956331 -.->|"ε"|eNFA2_12_66479500
eNFA2_5_10956331 -.->|"ε"|eNFA2_4_29858833
eNFA2_5_10956331 -.->|"ε"|eNFA2_8_40600350
eNFA2_5_10956331 -->|"[^*]"|eNFA2_5_10956331
eNFA2_5_10956331 -->|"[*]"|eNFA2_9_33200047
eNFA2_5_10956331 -->|"*"|eNFA2_13_4849307
eNFA2_9_33200047 -.->|"ε"|eNFA2_10_30364973
eNFA2_9_33200047 -->|"[^/]"|eNFA2_11_24562296
eNFA2_12_66479500 -->|"*"|eNFA2_13_4849307
eNFA2_13_4849307 -.->|"ε"|eNFA2_14_63861276
eNFA2_13_4849307 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_24845910
eNFA3_4_2646389 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA3_4_2646389
eNFA3_4_2646389 -.->|"ε
ExtendToken 'inlineComment'"|eNFA3_6_13030950
eNFA3_4_2646389 -.->|"ε"|eNFA3_7_6587942
eNFA3_4_2646389 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_10185684
eNFA3_4_2646389 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_30957904
eNFA3_6_13030950 -.->|"ε"|eNFA3_7_6587942
eNFA3_6_13030950 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_10185684
eNFA3_6_13030950 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_30957904
eNFA3_7_6587942 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA3_8_10185684
eNFA3_7_6587942 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_30957904
eNFA3_8_10185684 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_30957904
eNFA2_10_30364973 -->|"[^/]"|eNFA2_11_24562296
eNFA2_11_24562296 -.->|"ε"|eNFA2_7_294043
eNFA2_11_24562296 -.->|"ε"|eNFA2_6_64163473
eNFA2_11_24562296 -.->|"ε"|eNFA2_12_66479500
eNFA2_11_24562296 -.->|"ε"|eNFA2_4_29858833
eNFA2_11_24562296 -.->|"ε"|eNFA2_8_40600350
eNFA2_11_24562296 -->|"[^*]"|eNFA2_5_10956331
eNFA2_11_24562296 -->|"[*]"|eNFA2_9_33200047
eNFA2_11_24562296 -->|"*"|eNFA2_13_4849307
eNFA2_14_63861276 -->|"/
ExtendToken 'blockComment'"|eNFA2_15_24845910
eNFA2_15_24845910 -.->|"ε
ExtendToken 'blockComment'"|eNFA2_17_22286602
eNFA2_15_24845910 -.->|"ε"|eNFA2_18_66361692
eNFA2_15_24845910 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_19734077
eNFA2_15_24845910 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_30957904
eNFA2_17_22286602 -.->|"ε"|eNFA2_18_66361692
eNFA2_17_22286602 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_19734077
eNFA2_17_22286602 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_30957904
eNFA2_18_66361692 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA2_19_19734077
eNFA2_18_66361692 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_30957904
eNFA2_19_19734077 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_30957904

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
NFA0_0_57249620("NFA0-0 wholeStart")
class NFA0_0_57249620 c1000;
NFA1_1_43643771[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_43643771 c0101;
NFA1_5_45484537[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_45484537 c0101;
NFA2_1_6707649("NFA2-1 char[1]")
NFA3_1_60368847("NFA3-1 char[1]")
NFA1_1_6448715[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_6448715 c0101;
NFA1_5_58038438[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_58038438 c0101;
NFA2_3_3493029("NFA2-3 char[1]")
NFA3_3_52583897[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_52583897 c0101;
NFA2_5_14499957("NFA2-5 scope[1]")
NFA2_9_31437268("NFA2-9 scope[1]")
NFA2_13_63390755("NFA2-13 char[1]")
NFA3_4_33645886[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_33645886 c0101;
NFA2_11_40962215("NFA2-11 scope[1]")
NFA2_15_34377519[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_34377519 c0101;
NFA0_0_57249620 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|NFA1_1_43643771
NFA0_0_57249620 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|NFA1_5_45484537
NFA0_0_57249620 -->|"/
BeginToken 'blockComment'"|NFA2_1_6707649
NFA0_0_57249620 -->|"/
BeginToken 'inlineComment'"|NFA3_1_60368847
NFA1_1_43643771 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_6448715
NFA1_1_43643771 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_58038438
NFA1_5_45484537 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_6448715
NFA1_5_45484537 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_58038438
NFA2_1_6707649 -->|"*"|NFA2_3_3493029
NFA3_1_60368847 -->|"/
ExtendToken 'inlineComment'"|NFA3_3_52583897
NFA1_1_6448715 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_6448715
NFA1_1_6448715 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_58038438
NFA1_5_58038438 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_6448715
NFA1_5_58038438 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_58038438
NFA2_3_3493029 -->|"[^*]"|NFA2_5_14499957
NFA2_3_3493029 -->|"[*]"|NFA2_9_31437268
NFA2_3_3493029 -->|"*"|NFA2_13_63390755
NFA3_3_52583897 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_33645886
NFA2_5_14499957 -->|"[^*]"|NFA2_5_14499957
NFA2_5_14499957 -->|"[*]"|NFA2_9_31437268
NFA2_5_14499957 -->|"*"|NFA2_13_63390755
NFA2_9_31437268 -->|"[^/]"|NFA2_11_40962215
NFA2_13_63390755 -->|"/
ExtendToken 'blockComment'"|NFA2_15_34377519
NFA3_4_33645886 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA3_4_33645886
NFA2_11_40962215 -->|"[^*]"|NFA2_5_14499957
NFA2_11_40962215 -->|"[*]"|NFA2_9_31437268
NFA2_11_40962215 -->|"*"|NFA2_13_63390755

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
subgraph DFA0_909752378["DFA0 wholeStart"]
NFA0_0_57249620_0("NFA0-0 wholeStart")
class NFA0_0_57249620_0 c1000;
end
class DFA0_909752378 c1000;
subgraph DFA1_1558677976["DFA1 {2}"]
NFA1_1_43643771_1[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_43643771_1 c0101;
NFA1_5_45484537_2[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_45484537_2 c0101;
end
class DFA1_1558677976 c0101;
subgraph DFA2_-1584841839["DFA2 {1}"]
NFA1_5_45484537_3[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_45484537_3 c0101;
end
class DFA2_-1584841839 c0101;
subgraph DFA3_-8839222["DFA3 {2}"]
NFA2_1_6707649_4("NFA2-1 char[1]")
NFA3_1_60368847_5("NFA3-1 char[1]")
end
subgraph DFA4_2050087193["DFA4 {2}"]
NFA1_1_6448715_6[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_6448715_6 c0101;
NFA1_5_58038438_7[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_58038438_7 c0101;
end
class DFA4_2050087193 c0101;
subgraph DFA5_-204658626["DFA5 {1}"]
NFA1_5_58038438_8[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_58038438_8 c0101;
end
class DFA5_-204658626 c0101;
subgraph DFA6_-908896648["DFA6 {1}"]
NFA2_3_3493029_9("NFA2-3 char[1]")
end
subgraph DFA7_10311414["DFA7 {1}"]
NFA3_3_52583897_10[\"NFA3-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA3_3_52583897_10 c0101;
end
class DFA7_10311414 c0101;
subgraph DFA8_660092950["DFA8 {1}"]
NFA2_5_14499957_11("NFA2-5 scope[1]")
end
subgraph DFA9_1664463598["DFA9 {2}"]
NFA2_9_31437268_12("NFA2-9 scope[1]")
NFA2_13_63390755_13("NFA2-13 char[1]")
end
subgraph DFA10_-1613046517["DFA10 {1}"]
NFA3_4_33645886_14[\"NFA3-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA3_4_33645886_14 c0101;
end
class DFA10_-1613046517 c0101;
subgraph DFA11_1311422151["DFA11 {1}"]
NFA2_11_40962215_15("NFA2-11 scope[1]")
end
subgraph DFA12_889295564["DFA12 {1}"]
NFA2_15_34377519_16[\"NFA2-15 char[1]
AcceptToken 'blockComment'"/]
class NFA2_15_34377519_16 c0101;
end
class DFA12_889295564 c0101;
DFA0_909752378 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA1_1558677976
DFA0_909752378 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA2_-1584841839
DFA0_909752378 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_-8839222
DFA1_1558677976 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA1_1558677976 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA2_-1584841839 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA2_-1584841839 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA3_-8839222 -->|"*"|DFA6_-908896648
DFA3_-8839222 -->|"/
ExtendToken 'inlineComment'"|DFA7_10311414
DFA4_2050087193 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA4_2050087193 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA5_-204658626 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA5_-204658626 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA6_-908896648 -->|"[^*]"|DFA8_660092950
DFA6_-908896648 -->|"*"|DFA9_1664463598
DFA7_10311414 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA10_-1613046517
DFA8_660092950 -->|"[^*]"|DFA8_660092950
DFA8_660092950 -->|"*"|DFA9_1664463598
DFA9_1664463598 -->|"[^/]"|DFA11_1311422151
DFA9_1664463598 -->|"/
ExtendToken 'blockComment'"|DFA12_889295564
DFA10_-1613046517 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA10_-1613046517
DFA11_1311422151 -->|"[^*]"|DFA8_660092950
DFA11_1311422151 -->|"*"|DFA9_1664463598

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
DFA0_909752378{{"DFA0 wholeStart"}}
class DFA0_909752378 c1000;
DFA1_1558677976[\"DFA1 {2}
AcceptToken 'refVt'"/]
class DFA1_1558677976 c0101;
DFA2_-1584841839[\"DFA2 {1}
AcceptToken 'refVt'"/]
class DFA2_-1584841839 c0101;
DFA3_-8839222{{"DFA3 {2}"}}
DFA4_2050087193[\"DFA4 {2}
AcceptToken 'refVt'"/]
class DFA4_2050087193 c0101;
DFA5_-204658626[\"DFA5 {1}
AcceptToken 'refVt'"/]
class DFA5_-204658626 c0101;
DFA6_-908896648{{"DFA6 {1}"}}
DFA7_10311414[\"DFA7 {1}
AcceptToken 'inlineComment'"/]
class DFA7_10311414 c0101;
DFA8_660092950{{"DFA8 {1}"}}
DFA9_1664463598{{"DFA9 {2}"}}
DFA10_-1613046517[\"DFA10 {1}
AcceptToken 'inlineComment'"/]
class DFA10_-1613046517 c0101;
DFA11_1311422151{{"DFA11 {1}"}}
DFA12_889295564[\"DFA12 {1}
AcceptToken 'blockComment'"/]
class DFA12_889295564 c0101;
DFA0_909752378 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA1_1558677976
DFA0_909752378 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA2_-1584841839
DFA0_909752378 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA3_-8839222
DFA1_1558677976 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA1_1558677976 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA2_-1584841839 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA2_-1584841839 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA3_-8839222 -->|"*"|DFA6_-908896648
DFA3_-8839222 -->|"/
ExtendToken 'inlineComment'"|DFA7_10311414
DFA4_2050087193 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA4_2050087193 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA5_-204658626 -->|"#92;
ExtendToken 'refVt'"|DFA4_2050087193
DFA5_-204658626 -->|"[Y-[]
ExtendToken 'refVt'"|DFA5_-204658626
DFA6_-908896648 -->|"[^*]"|DFA8_660092950
DFA6_-908896648 -->|"*"|DFA9_1664463598
DFA7_10311414 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA10_-1613046517
DFA8_660092950 -->|"[^*]"|DFA8_660092950
DFA8_660092950 -->|"*"|DFA9_1664463598
DFA9_1664463598 -->|"[^/]"|DFA11_1311422151
DFA9_1664463598 -->|"/
ExtendToken 'blockComment'"|DFA12_889295564
DFA10_-1613046517 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA10_-1613046517
DFA11_1311422151 -->|"[^*]"|DFA8_660092950
DFA11_1311422151 -->|"*"|DFA9_1664463598

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
subgraph MiniDFA0_-1043797824["MiniDFA0 {1}"]
DFA0_909752378_0{{"DFA0 wholeStart"}}
class DFA0_909752378_0 c1000;
end
class MiniDFA0_-1043797824 c1000;
subgraph MiniDFA4_600623006["MiniDFA4 {1}"]
DFA1_1558677976_1[\"DFA1 {2}
AcceptToken 'refVt'"/]
class DFA1_1558677976_1 c0101;
end
class MiniDFA4_600623006 c0101;
subgraph MiniDFA5_41406967["MiniDFA5 {1}"]
DFA2_-1584841839_2[\"DFA2 {1}
AcceptToken 'refVt'"/]
class DFA2_-1584841839_2 c0101;
end
class MiniDFA5_41406967 c0101;
subgraph MiniDFA1_370994852["MiniDFA1 {1}"]
DFA3_-8839222_3{{"DFA3 {2}"}}
end
subgraph MiniDFA6_-282460137["MiniDFA6 {1}"]
DFA4_2050087193_4[\"DFA4 {2}
AcceptToken 'refVt'"/]
class DFA4_2050087193_4 c0101;
end
class MiniDFA6_-282460137 c0101;
subgraph MiniDFA7_-1341645009["MiniDFA7 {1}"]
DFA5_-204658626_5[\"DFA5 {1}
AcceptToken 'refVt'"/]
class DFA5_-204658626_5 c0101;
end
class MiniDFA7_-1341645009 c0101;
subgraph MiniDFA2_-1216891790["MiniDFA2 {3}"]
DFA6_-908896648_6{{"DFA6 {1}"}}
DFA8_660092950_7{{"DFA8 {1}"}}
DFA11_1311422151_8{{"DFA11 {1}"}}
end
subgraph MiniDFA8_-1728827867["MiniDFA8 {1}"]
DFA7_10311414_9[\"DFA7 {1}
AcceptToken 'inlineComment'"/]
class DFA7_10311414_9 c0101;
end
class MiniDFA8_-1728827867 c0101;
subgraph MiniDFA3_871430878["MiniDFA3 {1}"]
DFA9_1664463598_10{{"DFA9 {2}"}}
end
subgraph MiniDFA9_-1497456789["MiniDFA9 {1}"]
DFA10_-1613046517_11[\"DFA10 {1}
AcceptToken 'inlineComment'"/]
class DFA10_-1613046517_11 c0101;
end
class MiniDFA9_-1497456789 c0101;
subgraph MiniDFA10_-1722059764["MiniDFA10 {1}"]
DFA12_889295564_12[\"DFA12 {1}
AcceptToken 'blockComment'"/]
class DFA12_889295564_12 c0101;
end
class MiniDFA10_-1722059764 c0101;
MiniDFA0_-1043797824 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA4_600623006
MiniDFA0_-1043797824 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA5_41406967
MiniDFA0_-1043797824 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_370994852
MiniDFA4_600623006 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA4_600623006 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA5_41406967 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA5_41406967 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA1_370994852 -->|"*"|MiniDFA2_-1216891790
MiniDFA1_370994852 -->|"/
ExtendToken 'inlineComment'"|MiniDFA8_-1728827867
MiniDFA6_-282460137 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA6_-282460137 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA7_-1341645009 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA7_-1341645009 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA2_-1216891790 -->|"[^*]"|MiniDFA2_-1216891790
MiniDFA2_-1216891790 -->|"*"|MiniDFA3_871430878
MiniDFA8_-1728827867 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1497456789
MiniDFA3_871430878 -->|"[^/]"|MiniDFA2_-1216891790
MiniDFA3_871430878 -->|"/
ExtendToken 'blockComment'"|MiniDFA10_-1722059764
MiniDFA9_-1497456789 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1497456789

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
MiniDFA0_-1043797824(["MiniDFA0 {1}"])
class MiniDFA0_-1043797824 c1000;
MiniDFA4_600623006[\"MiniDFA4 {1}
AcceptToken 'refVt'"/]
class MiniDFA4_600623006 c0101;
MiniDFA5_41406967[\"MiniDFA5 {1}
AcceptToken 'refVt'"/]
class MiniDFA5_41406967 c0101;
MiniDFA1_370994852(["MiniDFA1 {1}"])
MiniDFA6_-282460137[\"MiniDFA6 {1}
AcceptToken 'refVt'"/]
class MiniDFA6_-282460137 c0101;
MiniDFA7_-1341645009[\"MiniDFA7 {1}
AcceptToken 'refVt'"/]
class MiniDFA7_-1341645009 c0101;
MiniDFA2_-1216891790(["MiniDFA2 {3}"])
MiniDFA8_-1728827867[\"MiniDFA8 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA8_-1728827867 c0101;
MiniDFA3_871430878(["MiniDFA3 {1}"])
MiniDFA9_-1497456789[\"MiniDFA9 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA9_-1497456789 c0101;
MiniDFA10_-1722059764[\"MiniDFA10 {1}
AcceptToken 'blockComment'"/]
class MiniDFA10_-1722059764 c0101;
MiniDFA0_-1043797824 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA4_600623006
MiniDFA0_-1043797824 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA5_41406967
MiniDFA0_-1043797824 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_370994852
MiniDFA4_600623006 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA4_600623006 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA5_41406967 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA5_41406967 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA1_370994852 -->|"*"|MiniDFA2_-1216891790
MiniDFA1_370994852 -->|"/
ExtendToken 'inlineComment'"|MiniDFA8_-1728827867
MiniDFA6_-282460137 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA6_-282460137 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA7_-1341645009 -->|"#92;
ExtendToken 'refVt'"|MiniDFA6_-282460137
MiniDFA7_-1341645009 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA7_-1341645009
MiniDFA2_-1216891790 -->|"[^*]"|MiniDFA2_-1216891790
MiniDFA2_-1216891790 -->|"*"|MiniDFA3_871430878
MiniDFA8_-1728827867 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1497456789
MiniDFA3_871430878 -->|"[^/]"|MiniDFA2_-1216891790
MiniDFA3_871430878 -->|"/
ExtendToken 'blockComment'"|MiniDFA10_-1722059764
MiniDFA9_-1497456789 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA9_-1497456789

```

# 总结

无。

