# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Ints2`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（3个State）。

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
eNFA0_2_32588056[["εNFA0-2 regex start"]]
eNFA0_0_2582536[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_22656569[["εNFA0-1 scope[1]"]]
eNFA0_3_23242828[["εNFA0-3 regex end"]]
eNFA0_2_32588056 -.->|"ε"|eNFA0_0_2582536
eNFA0_0_2582536 -->|"[0-9]"|eNFA0_1_22656569
eNFA0_1_22656569 -->|"[0-9]"|eNFA0_1_22656569
eNFA0_1_22656569 -.->|"ε"|eNFA0_3_23242828
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
eNFA0_4_1396570[["εNFA0-4 post-regex start"]]
eNFA0_5_12569130[\"εNFA0-5 post-regex end"/]
eNFA0_4_1396570 -.->|"ε"|eNFA0_5_12569130
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
eNFA0_2_36215847[["εNFA0-2 regex start"]]
eNFA0_0_57507174[["εNFA0-0 char{1, 1}"]]
eNFA0_1_47802519[["εNFA0-1 char[1]"]]
eNFA0_3_27569493[["εNFA0-3 regex end"]]
eNFA0_2_36215847 -.->|"ε"|eNFA0_0_57507174
eNFA0_0_57507174 -->|","|eNFA0_1_47802519
eNFA0_1_47802519 -.->|"ε"|eNFA0_3_27569493
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
eNFA0_4_46798848[["εNFA0-4 post-regex start"]]
eNFA0_5_18536449[\"εNFA0-5 post-regex end"/]
eNFA0_4_46798848 -.->|"ε"|eNFA0_5_18536449
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
eNFA0_0_29151421[["εNFA0-0 wholeStart"]]
eNFA1_2_13756340[["εNFA1-2 regex start"]]
class eNFA1_2_13756340 c1000;
eNFA2_2_61036202[["εNFA2-2 regex start"]]
class eNFA2_2_61036202 c1000;
eNFA1_0_15082912[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_2214586[["εNFA2-0 char{1, 1}"]]
eNFA1_1_38958581[["εNFA1-1 scope[1]"]]
eNFA2_1_19931282[["εNFA2-1 char[1]"]]
eNFA1_3_1528482[["εNFA1-3 regex end"]]
class eNFA1_3_1528482 c0100;
eNFA2_3_45163810[["εNFA2-3 regex end"]]
class eNFA2_3_45163810 c0100;
eNFA1_4_56698199[["εNFA1-4 post-regex start"]]
class eNFA1_4_56698199 c0010;
eNFA2_4_3821108[["εNFA2-4 post-regex start"]]
class eNFA2_4_3821108 c0010;
eNFA1_5_40521749[\"εNFA1-5 post-regex end"/]
class eNFA1_5_40521749 c0001;
eNFA2_5_12454907[\"εNFA2-5 post-regex end"/]
class eNFA2_5_12454907 c0001;
eNFA0_1_44985307[\"εNFA0-1 wholeEnd"/]
eNFA0_0_29151421 -.->|"ε"|eNFA1_2_13756340
eNFA0_0_29151421 -.->|"ε"|eNFA2_2_61036202
eNFA1_2_13756340 -.->|"ε
BeginToken 'integer'"|eNFA1_0_15082912
eNFA2_2_61036202 -.->|"ε
BeginToken ','"|eNFA2_0_2214586
eNFA1_0_15082912 -->|"[0-9]"|eNFA1_1_38958581
eNFA2_0_2214586 -->|","|eNFA2_1_19931282
eNFA1_1_38958581 -->|"[0-9]"|eNFA1_1_38958581
eNFA1_1_38958581 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_1528482
eNFA2_1_19931282 -.->|"ε
ExtendToken ','"|eNFA2_3_45163810
eNFA1_3_1528482 -.->|"ε"|eNFA1_4_56698199
eNFA2_3_45163810 -.->|"ε"|eNFA2_4_3821108
eNFA1_4_56698199 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_40521749
eNFA2_4_3821108 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_12454907
eNFA1_5_40521749 -.->|"ε"|eNFA0_1_44985307
eNFA2_5_12454907 -.->|"ε"|eNFA0_1_44985307

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
eNFA0_0_34389978[["εNFA0-0 wholeStart"]]
class eNFA0_0_34389978 c1000;
eNFA1_2_34124810[["εNFA1-2 regex start"]]
class eNFA1_2_34124810 c1000;
eNFA2_2_41074347[["εNFA2-2 regex start"]]
class eNFA2_2_41074347 c1000;
eNFA1_0_12646235[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_12646235 c1000;
eNFA2_0_43755553[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_43755553 c1000;
eNFA1_1_38687839[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_38687839 c0111;
eNFA2_1_58255659[\"εNFA2-1 char[1]
AcceptToken ','"/]
class eNFA2_1_58255659 c0111;
eNFA1_3_46707255[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_46707255 c0111;
eNFA1_4_27231349[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_27231349 c0011;
eNFA1_5_25395326[\"εNFA1-5 post-regex end"/]
class eNFA1_5_25395326 c0011;
eNFA0_1_25191324[\"εNFA0-1 wholeEnd"/]
eNFA2_3_54538884[\"εNFA2-3 regex end
AcceptToken ','"/]
class eNFA2_3_54538884 c0111;
eNFA2_4_21087909[\"εNFA2-4 post-regex start
AcceptToken ','"/]
class eNFA2_4_21087909 c0011;
eNFA2_5_17712116[\"εNFA2-5 post-regex end"/]
class eNFA2_5_17712116 c0011;
eNFA0_0_34389978 -.->|"ε"|eNFA1_2_34124810
eNFA0_0_34389978 -.->|"ε"|eNFA2_2_41074347
eNFA0_0_34389978 -.->|"ε
BeginToken 'integer'"|eNFA1_0_12646235
eNFA0_0_34389978 -.->|"ε
BeginToken ','"|eNFA2_0_43755553
eNFA0_0_34389978 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_38687839
eNFA0_0_34389978 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_58255659
eNFA1_2_34124810 -.->|"ε
BeginToken 'integer'"|eNFA1_0_12646235
eNFA1_2_34124810 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_38687839
eNFA2_2_41074347 -.->|"ε
BeginToken ','"|eNFA2_0_43755553
eNFA2_2_41074347 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_58255659
eNFA1_0_12646235 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_38687839
eNFA2_0_43755553 -->|",
BeginToken ','
ExtendToken ','"|eNFA2_1_58255659
eNFA1_1_38687839 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_38687839
eNFA1_1_38687839 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_46707255
eNFA1_1_38687839 -.->|"ε"|eNFA1_4_27231349
eNFA1_1_38687839 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_25395326
eNFA1_1_38687839 -.->|"ε
CheckToken 'integer'"|eNFA0_1_25191324
eNFA2_1_58255659 -.->|"ε
ExtendToken ','"|eNFA2_3_54538884
eNFA2_1_58255659 -.->|"ε"|eNFA2_4_21087909
eNFA2_1_58255659 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_17712116
eNFA2_1_58255659 -.->|"ε
CheckToken ','"|eNFA0_1_25191324
eNFA1_3_46707255 -.->|"ε"|eNFA1_4_27231349
eNFA1_3_46707255 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_25395326
eNFA1_3_46707255 -.->|"ε
CheckToken 'integer'"|eNFA0_1_25191324
eNFA1_4_27231349 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_25395326
eNFA1_4_27231349 -.->|"ε
CheckToken 'integer'"|eNFA0_1_25191324
eNFA1_5_25395326 -.->|"ε
CheckToken 'integer'"|eNFA0_1_25191324
eNFA2_3_54538884 -.->|"ε"|eNFA2_4_21087909
eNFA2_3_54538884 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_17712116
eNFA2_3_54538884 -.->|"ε
CheckToken ','"|eNFA0_1_25191324
eNFA2_4_21087909 -.->|"ε
CheckToken ','
AcceptToken ','"|eNFA2_5_17712116
eNFA2_4_21087909 -.->|"ε
CheckToken ','"|eNFA0_1_25191324
eNFA2_5_17712116 -.->|"ε
CheckToken ','"|eNFA0_1_25191324

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
NFA0_0_30399051("NFA0-0 wholeStart")
class NFA0_0_30399051 c1000;
NFA1_1_55573455[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_55573455 c0101;
NFA2_1_5156011[\"NFA2-1 char[1]
AcceptToken ','"/]
class NFA2_1_5156011 c0101;
NFA0_0_30399051 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_55573455
NFA0_0_30399051 -->|",
BeginToken ','
ExtendToken ','"|NFA2_1_5156011
NFA1_1_55573455 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_55573455

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
subgraph DFA0_585978999["DFA0 wholeStart"]
NFA0_0_30399051_0("NFA0-0 wholeStart")
class NFA0_0_30399051_0 c1000;
end
class DFA0_585978999 c1000;
subgraph DFA1_1120076600["DFA1 {1}"]
NFA1_1_55573455_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_55573455_1 c0101;
end
class DFA1_1120076600 c0101;
subgraph DFA2_-1955808288["DFA2 {1}"]
NFA2_1_5156011_2[\"NFA2-1 char[1]
AcceptToken ','"/]
class NFA2_1_5156011_2 c0101;
end
class DFA2_-1955808288 c0101;
DFA0_585978999 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1120076600
DFA0_585978999 -->|",
BeginToken ','
ExtendToken ','"|DFA2_-1955808288
DFA1_1120076600 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1120076600

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
DFA0_585978999{{"DFA0 wholeStart"}}
class DFA0_585978999 c1000;
DFA1_1120076600[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1120076600 c0101;
DFA2_-1955808288[\"DFA2 {1}
AcceptToken ','"/]
class DFA2_-1955808288 c0101;
DFA0_585978999 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|DFA1_1120076600
DFA0_585978999 -->|",
BeginToken ','
ExtendToken ','"|DFA2_-1955808288
DFA1_1120076600 -->|"[0-9]
ExtendToken 'integer'"|DFA1_1120076600

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
subgraph MiniDFA0_96068073["MiniDFA0 {1}"]
DFA0_585978999_0{{"DFA0 wholeStart"}}
class DFA0_585978999_0 c1000;
end
class MiniDFA0_96068073 c1000;
subgraph MiniDFA1_310322936["MiniDFA1 {1}"]
DFA1_1120076600_1[\"DFA1 {1}
AcceptToken 'integer'"/]
class DFA1_1120076600_1 c0101;
end
class MiniDFA1_310322936 c0101;
subgraph MiniDFA2_-1741180269["MiniDFA2 {1}"]
DFA2_-1955808288_2[\"DFA2 {1}
AcceptToken ','"/]
class DFA2_-1955808288_2 c0101;
end
class MiniDFA2_-1741180269 c0101;
MiniDFA0_96068073 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA1_310322936
MiniDFA0_96068073 -->|",
BeginToken ','
ExtendToken ','"|MiniDFA2_-1741180269
MiniDFA1_310322936 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA1_310322936

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
MiniDFA0_96068073(["MiniDFA0 {1}"])
class MiniDFA0_96068073 c1000;
MiniDFA1_310322936[\"MiniDFA1 {1}
AcceptToken 'integer'"/]
class MiniDFA1_310322936 c0101;
MiniDFA2_-1741180269[\"MiniDFA2 {1}
AcceptToken ','"/]
class MiniDFA2_-1741180269 c0101;
MiniDFA0_96068073 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|MiniDFA1_310322936
MiniDFA0_96068073 -->|",
BeginToken ','
ExtendToken ','"|MiniDFA2_-1741180269
MiniDFA1_310322936 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA1_310322936

```

# 总结

无。

