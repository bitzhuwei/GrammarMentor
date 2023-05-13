# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Prefix`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（4个State）。

## 'entityId'
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
eNFA0_2_53072404[["εNFA0-2 regex start"]]
eNFA0_0_12526030[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_38674483[["εNFA0-1 scope[1]"]]
eNFA0_3_45625410[["εNFA0-3 regex end"]]
eNFA0_2_53072404 -.->|"ε"|eNFA0_0_12526030
eNFA0_0_12526030 -->|"[0-9]"|eNFA0_1_38674483
eNFA0_1_38674483 -->|"[0-9]"|eNFA0_1_38674483
eNFA0_1_38674483 -.->|"ε"|eNFA0_3_45625410
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
eNFA0_4_47257249[["εNFA0-4 post-regex start"]]
eNFA0_5_22662065[\"εNFA0-5 post-regex end"/]
eNFA0_4_47257249 -.->|"ε"|eNFA0_5_22662065
```


## 'refEntity'
1/3: pre-regex `'='`

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
eNFA0_2_52257970[["εNFA0-2 regex start"]]
eNFA0_0_42036792[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_4670754[["εNFA0-1 scope[1]"]]
eNFA0_3_42786811[["εNFA0-3 regex end"]]
eNFA0_2_52257970 -.->|"ε"|eNFA0_0_42036792
eNFA0_0_42036792 -->|"[0-9]"|eNFA0_1_4670754
eNFA0_1_4670754 -->|"[0-9]"|eNFA0_1_4670754
eNFA0_1_4670754 -.->|"ε"|eNFA0_3_42786811
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
eNFA0_4_5359414[["εNFA0-4 post-regex start"]]
eNFA0_5_48234734[\"εNFA0-5 post-regex end"/]
eNFA0_4_5359414 -.->|"ε"|eNFA0_5_48234734
```


## '='
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
eNFA0_2_5116239[["εNFA0-2 regex start"]]
eNFA0_0_46046153[["εNFA0-0 char{1, 1}"]]
eNFA0_1_11762200[["εNFA0-1 char[1]"]]
eNFA0_3_38750940[["εNFA0-3 regex end"]]
eNFA0_2_5116239 -.->|"ε"|eNFA0_0_46046153
eNFA0_0_46046153 -->|"="|eNFA0_1_11762200
eNFA0_1_11762200 -.->|"ε"|eNFA0_3_38750940
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
eNFA0_4_13214142[["εNFA0-4 post-regex start"]]
eNFA0_5_51818415[\"εNFA0-5 post-regex end"/]
eNFA0_4_13214142 -.->|"ε"|eNFA0_5_51818415
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
eNFA0_0_45849445[["εNFA0-0 wholeStart"]]
eNFA1_2_57413815[["εNFA1-2 regex start"]]
class eNFA1_2_57413815 c1000;
eNFA2_2_9991824[["εNFA2-2 regex start"]]
class eNFA2_2_9991824 c1000;
eNFA1_0_20592920[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_36282465[["εNFA2-0 char{1, 1}"]]
eNFA1_1_54483885[["εNFA1-1 scope[1]"]]
eNFA2_1_58106730[["εNFA2-1 char[1]"]]
eNFA1_3_51118555[["εNFA1-3 regex end"]]
class eNFA1_3_51118555 c0100;
eNFA2_3_53198525[["εNFA2-3 regex end"]]
class eNFA2_3_53198525 c0100;
eNFA1_4_46962294[["εNFA1-4 post-regex start"]]
class eNFA1_4_46962294 c0010;
eNFA2_4_9024684[["εNFA2-4 post-regex start"]]
class eNFA2_4_9024684 c0010;
eNFA3_2_20935841[["εNFA3-2 regex start"]]
class eNFA3_2_20935841 c1000;
eNFA1_5_20007463[\"εNFA1-5 post-regex end"/]
class eNFA1_5_20007463 c0001;
eNFA2_5_22817553[\"εNFA2-5 post-regex end"/]
class eNFA2_5_22817553 c0001;
eNFA3_0_59910790[["εNFA3-0 scope{1, ∞}"]]
eNFA0_1_4031385[\"εNFA0-1 wholeEnd"/]
eNFA3_1_14113294[["εNFA3-1 scope[1]"]]
eNFA3_3_2326204[["εNFA3-3 regex end"]]
class eNFA3_3_2326204 c0100;
eNFA3_4_18081573[["εNFA3-4 post-regex start"]]
class eNFA3_4_18081573 c0010;
eNFA3_5_54204846[\"εNFA3-5 post-regex end"/]
class eNFA3_5_54204846 c0001;
eNFA0_0_45849445 -.->|"ε"|eNFA1_2_57413815
eNFA0_0_45849445 -.->|"ε"|eNFA2_2_9991824
eNFA1_2_57413815 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_20592920
eNFA2_2_9991824 -.->|"ε
BeginToken '='"|eNFA2_0_36282465
eNFA1_0_20592920 -->|"[0-9]"|eNFA1_1_54483885
eNFA2_0_36282465 -->|"="|eNFA2_1_58106730
eNFA1_1_54483885 -->|"[0-9]"|eNFA1_1_54483885
eNFA1_1_54483885 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_51118555
eNFA2_1_58106730 -.->|"ε
ExtendToken '='"|eNFA2_3_53198525
eNFA1_3_51118555 -.->|"ε"|eNFA1_4_46962294
eNFA2_3_53198525 -.->|"ε"|eNFA2_4_9024684
eNFA2_3_53198525 -.->|"ε
AcceptPrevious '='"|eNFA3_2_20935841
eNFA1_4_46962294 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_20007463
eNFA2_4_9024684 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_22817553
eNFA3_2_20935841 -.->|"ε
BeginToken 'refEntity'"|eNFA3_0_59910790
eNFA1_5_20007463 -.->|"ε"|eNFA0_1_4031385
eNFA2_5_22817553 -.->|"ε"|eNFA0_1_4031385
eNFA3_0_59910790 -->|"[0-9]"|eNFA3_1_14113294
eNFA3_1_14113294 -->|"[0-9]"|eNFA3_1_14113294
eNFA3_1_14113294 -.->|"ε
ExtendToken 'refEntity'"|eNFA3_3_2326204
eNFA3_3_2326204 -.->|"ε"|eNFA3_4_18081573
eNFA3_4_18081573 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA3_5_54204846
eNFA3_5_54204846 -.->|"ε"|eNFA0_1_4031385

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
eNFA0_0_28516429[["εNFA0-0 wholeStart"]]
class eNFA0_0_28516429 c1000;
eNFA1_2_28129408[["εNFA1-2 regex start"]]
class eNFA1_2_28129408 c1000;
eNFA2_2_55321272[["εNFA2-2 regex start"]]
class eNFA2_2_55321272 c1000;
eNFA1_0_63889584[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_63889584 c1000;
eNFA2_0_46920042[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_46920042 c1000;
eNFA1_1_51838085[\"εNFA1-1 scope[1]
AcceptToken 'entityId'"/]
class eNFA1_1_51838085 c0111;
eNFA2_1_19627195[\"εNFA2-1 char[1]
AcceptToken '='"/]
class eNFA2_1_19627195 c1111;
eNFA1_3_38135346[\"εNFA1-3 regex end
AcceptToken 'entityId'"/]
class eNFA1_3_38135346 c0111;
eNFA1_4_49952580[\"εNFA1-4 post-regex start
AcceptToken 'entityId'"/]
class eNFA1_4_49952580 c0011;
eNFA1_5_10954379[\"εNFA1-5 post-regex end"/]
class eNFA1_5_10954379 c0011;
eNFA0_1_16130234[\"εNFA0-1 wholeEnd"/]
eNFA2_3_7673796[\"εNFA2-3 regex end
AcceptToken '='"/]
class eNFA2_3_7673796 c1111;
eNFA2_4_17597733[\"εNFA2-4 post-regex start
AcceptToken '='"/]
class eNFA2_4_17597733 c0011;
eNFA3_2_1955303[\"εNFA3-2 regex start"/]
class eNFA3_2_1955303 c1000;
eNFA2_5_24161869[\"εNFA2-5 post-regex end"/]
class eNFA2_5_24161869 c0011;
eNFA3_0_14889546[\"εNFA3-0 scope{1, ∞}"/]
class eNFA3_0_14889546 c1000;
eNFA3_1_31480555[\"εNFA3-1 scope[1]
AcceptToken 'refEntity'"/]
class eNFA3_1_31480555 c0111;
eNFA3_3_66897058[\"εNFA3-3 regex end
AcceptToken 'refEntity'"/]
class eNFA3_3_66897058 c0111;
eNFA3_4_42427034[\"εNFA3-4 post-regex start
AcceptToken 'refEntity'"/]
class eNFA3_4_42427034 c0011;
eNFA3_5_65202610[\"εNFA3-5 post-regex end"/]
class eNFA3_5_65202610 c0011;
eNFA0_0_28516429 -.->|"ε"|eNFA1_2_28129408
eNFA0_0_28516429 -.->|"ε"|eNFA2_2_55321272
eNFA0_0_28516429 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_63889584
eNFA0_0_28516429 -.->|"ε
BeginToken '='"|eNFA2_0_46920042
eNFA0_0_28516429 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_51838085
eNFA0_0_28516429 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_19627195
eNFA1_2_28129408 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_63889584
eNFA1_2_28129408 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_51838085
eNFA2_2_55321272 -.->|"ε
BeginToken '='"|eNFA2_0_46920042
eNFA2_2_55321272 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_19627195
eNFA1_0_63889584 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_51838085
eNFA2_0_46920042 -->|"=
BeginToken '='
ExtendToken '='"|eNFA2_1_19627195
eNFA1_1_51838085 -->|"[0-9]
ExtendToken 'entityId'"|eNFA1_1_51838085
eNFA1_1_51838085 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_38135346
eNFA1_1_51838085 -.->|"ε"|eNFA1_4_49952580
eNFA1_1_51838085 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_10954379
eNFA1_1_51838085 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_16130234
eNFA2_1_19627195 -.->|"ε
ExtendToken '='"|eNFA2_3_7673796
eNFA2_1_19627195 -.->|"ε"|eNFA2_4_17597733
eNFA2_1_19627195 -.->|"ε
AcceptPrevious '='"|eNFA3_2_1955303
eNFA2_1_19627195 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_24161869
eNFA2_1_19627195 -.->|"ε
CheckToken '='"|eNFA0_1_16130234
eNFA2_1_19627195 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA3_0_14889546
eNFA2_1_19627195 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA3_1_31480555
eNFA1_3_38135346 -.->|"ε"|eNFA1_4_49952580
eNFA1_3_38135346 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_10954379
eNFA1_3_38135346 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_16130234
eNFA1_4_49952580 -.->|"ε
CheckToken 'entityId'
AcceptToken 'entityId'"|eNFA1_5_10954379
eNFA1_4_49952580 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_16130234
eNFA1_5_10954379 -.->|"ε
CheckToken 'entityId'"|eNFA0_1_16130234
eNFA2_3_7673796 -.->|"ε"|eNFA2_4_17597733
eNFA2_3_7673796 -.->|"ε
AcceptPrevious '='"|eNFA3_2_1955303
eNFA2_3_7673796 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_24161869
eNFA2_3_7673796 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA3_0_14889546
eNFA2_3_7673796 -.->|"ε
CheckToken '='"|eNFA0_1_16130234
eNFA2_3_7673796 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA3_1_31480555
eNFA2_4_17597733 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA2_5_24161869
eNFA2_4_17597733 -.->|"ε
CheckToken '='"|eNFA0_1_16130234
eNFA3_2_1955303 -.->|"ε
AcceptPrevious '='
BeginToken 'refEntity'"|eNFA3_0_14889546
eNFA3_2_1955303 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA3_1_31480555
eNFA2_5_24161869 -.->|"ε
CheckToken '='"|eNFA0_1_16130234
eNFA3_0_14889546 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA3_1_31480555
eNFA3_1_31480555 -->|"[0-9]
ExtendToken 'refEntity'"|eNFA3_1_31480555
eNFA3_1_31480555 -.->|"ε
ExtendToken 'refEntity'"|eNFA3_3_66897058
eNFA3_1_31480555 -.->|"ε"|eNFA3_4_42427034
eNFA3_1_31480555 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA3_5_65202610
eNFA3_1_31480555 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_16130234
eNFA3_3_66897058 -.->|"ε"|eNFA3_4_42427034
eNFA3_3_66897058 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA3_5_65202610
eNFA3_3_66897058 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_16130234
eNFA3_4_42427034 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA3_5_65202610
eNFA3_4_42427034 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_16130234
eNFA3_5_65202610 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_16130234

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
NFA0_0_14037739("NFA0-0 wholeStart")
class NFA0_0_14037739 c1000;
NFA1_1_46298991[\"NFA1-1 scope[1]
AcceptToken 'entityId'"/]
class NFA1_1_46298991 c0101;
NFA2_1_59230791[\"NFA2-1 char[1]
AcceptToken '='"/]
class NFA2_1_59230791 c1101;
NFA3_1_63315076[\"NFA3-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA3_1_63315076 c0101;
NFA0_0_14037739 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|NFA1_1_46298991
NFA0_0_14037739 -->|"=
BeginToken '='
ExtendToken '='"|NFA2_1_59230791
NFA1_1_46298991 -->|"[0-9]
ExtendToken 'entityId'"|NFA1_1_46298991
NFA2_1_59230791 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|NFA3_1_63315076
NFA3_1_63315076 -->|"[0-9]
ExtendToken 'refEntity'"|NFA3_1_63315076

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
subgraph DFA0_1011348769["DFA0 wholeStart"]
NFA0_0_14037739_0("NFA0-0 wholeStart")
class NFA0_0_14037739_0 c1000;
end
class DFA0_1011348769 c1000;
subgraph DFA1_1532792217["DFA1 {1}"]
NFA1_1_46298991_1[\"NFA1-1 scope[1]
AcceptToken 'entityId'"/]
class NFA1_1_46298991_1 c0101;
end
class DFA1_1532792217 c0101;
subgraph DFA2_-348809668["DFA2 {1}"]
NFA2_1_59230791_2[\"NFA2-1 char[1]
AcceptToken '='"/]
class NFA2_1_59230791_2 c1101;
end
class DFA2_-348809668 c1101;
subgraph DFA3_1100400324["DFA3 {1}"]
NFA3_1_63315076_3[\"NFA3-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA3_1_63315076_3 c0101;
end
class DFA3_1100400324 c0101;
DFA0_1011348769 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|DFA1_1532792217
DFA0_1011348769 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-348809668
DFA1_1532792217 -->|"[0-9]
ExtendToken 'entityId'"|DFA1_1532792217
DFA2_-348809668 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|DFA3_1100400324
DFA3_1100400324 -->|"[0-9]
ExtendToken 'refEntity'"|DFA3_1100400324

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
DFA0_1011348769{{"DFA0 wholeStart"}}
class DFA0_1011348769 c1000;
DFA1_1532792217[\"DFA1 {1}
AcceptToken 'entityId'"/]
class DFA1_1532792217 c0101;
DFA2_-348809668[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-348809668 c1101;
DFA3_1100400324[\"DFA3 {1}
AcceptToken 'refEntity'"/]
class DFA3_1100400324 c0101;
DFA0_1011348769 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|DFA1_1532792217
DFA0_1011348769 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-348809668
DFA1_1532792217 -->|"[0-9]
ExtendToken 'entityId'"|DFA1_1532792217
DFA2_-348809668 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|DFA3_1100400324
DFA3_1100400324 -->|"[0-9]
ExtendToken 'refEntity'"|DFA3_1100400324

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
subgraph MiniDFA0_126819603["MiniDFA0 {1}"]
DFA0_1011348769_0{{"DFA0 wholeStart"}}
class DFA0_1011348769_0 c1000;
end
class MiniDFA0_126819603 c1000;
subgraph MiniDFA1_580070143["MiniDFA1 {1}"]
DFA1_1532792217_1[\"DFA1 {1}
AcceptToken 'entityId'"/]
class DFA1_1532792217_1 c0101;
end
class MiniDFA1_580070143 c0101;
subgraph MiniDFA2_1465815517["MiniDFA2 {1}"]
DFA2_-348809668_2[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-348809668_2 c1101;
end
class MiniDFA2_1465815517 c1101;
subgraph MiniDFA3_-122244134["MiniDFA3 {1}"]
DFA3_1100400324_3[\"DFA3 {1}
AcceptToken 'refEntity'"/]
class DFA3_1100400324_3 c0101;
end
class MiniDFA3_-122244134 c0101;
MiniDFA0_126819603 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|MiniDFA1_580070143
MiniDFA0_126819603 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA2_1465815517
MiniDFA1_580070143 -->|"[0-9]
ExtendToken 'entityId'"|MiniDFA1_580070143
MiniDFA2_1465815517 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|MiniDFA3_-122244134
MiniDFA3_-122244134 -->|"[0-9]
ExtendToken 'refEntity'"|MiniDFA3_-122244134

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
MiniDFA0_126819603(["MiniDFA0 {1}"])
class MiniDFA0_126819603 c1000;
MiniDFA1_580070143[\"MiniDFA1 {1}
AcceptToken 'entityId'"/]
class MiniDFA1_580070143 c0101;
MiniDFA2_1465815517[\"MiniDFA2 {1}
AcceptToken '='"/]
class MiniDFA2_1465815517 c1101;
MiniDFA3_-122244134[\"MiniDFA3 {1}
AcceptToken 'refEntity'"/]
class MiniDFA3_-122244134 c0101;
MiniDFA0_126819603 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|MiniDFA1_580070143
MiniDFA0_126819603 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA2_1465815517
MiniDFA1_580070143 -->|"[0-9]
ExtendToken 'entityId'"|MiniDFA1_580070143
MiniDFA2_1465815517 -->|"[0-9]
AcceptPrevious '='
BeginToken 'refEntity'
ExtendToken 'refEntity'"|MiniDFA3_-122244134
MiniDFA3_-122244134 -->|"[0-9]
ExtendToken 'refEntity'"|MiniDFA3_-122244134

```

# 总结

无。

