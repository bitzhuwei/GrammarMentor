# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Error`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（5个State）。

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
eNFA0_6_34760343[["εNFA0-6 regex start"]]
eNFA0_2_8140857[["εNFA0-2 regex start"]]
eNFA0_0_55429698[["εNFA0-0 char{1, 1}"]]
eNFA0_4_6158855[["εNFA0-4 scope{1, 1}"]]
eNFA0_1_8713795[["εNFA0-1 char[1]"]]
eNFA0_5_29105235[["εNFA0-5 scope[1]"]]
eNFA0_3_60620523[["εNFA0-3 regex end"]]
eNFA0_2_11315292[["εNFA0-2 regex start"]]
eNFA0_0_44123454[["εNFA0-0 char{1, 1}"]]
eNFA0_4_34728767[["εNFA0-4 scope{1, 1}"]]
eNFA0_3_17230008[["εNFA0-3 regex end"]]
eNFA0_1_20852350[["εNFA0-1 char[1]"]]
eNFA0_5_61566768[["εNFA0-5 scope[1]"]]
eNFA0_7_53453427[["εNFA0-7 regex end"]]
eNFA0_6_34760343 -.->|"ε"|eNFA0_2_8140857
eNFA0_2_8140857 -.->|"ε"|eNFA0_0_55429698
eNFA0_2_8140857 -.->|"ε"|eNFA0_4_6158855
eNFA0_0_55429698 -->|"#92;"|eNFA0_1_8713795
eNFA0_4_6158855 -->|"[Y-#92;]"|eNFA0_5_29105235
eNFA0_1_8713795 -.->|"ε"|eNFA0_3_60620523
eNFA0_5_29105235 -.->|"ε"|eNFA0_3_60620523
eNFA0_3_60620523 -.->|"ε"|eNFA0_2_11315292
eNFA0_2_11315292 -.->|"ε"|eNFA0_0_44123454
eNFA0_2_11315292 -.->|"ε"|eNFA0_4_34728767
eNFA0_2_11315292 -.->|"ε"|eNFA0_3_17230008
eNFA0_0_44123454 -->|"#92;"|eNFA0_1_20852350
eNFA0_4_34728767 -->|"[Y-#92;]"|eNFA0_5_61566768
eNFA0_3_17230008 -.->|"ε"|eNFA0_2_11315292
eNFA0_3_17230008 -.->|"ε"|eNFA0_7_53453427
eNFA0_1_20852350 -.->|"ε"|eNFA0_3_17230008
eNFA0_5_61566768 -.->|"ε"|eNFA0_3_17230008
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
eNFA0_8_10429724[["εNFA0-8 post-regex start"]]
eNFA0_9_26758660[\"εNFA0-9 post-regex end"/]
eNFA0_8_10429724 -.->|"ε"|eNFA0_9_26758660
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
eNFA0_0_4620049[["εNFA0-0 wholeStart"]]
eNFA1_6_24309136[["εNFA1-6 regex start"]]
class eNFA1_6_24309136 c1000;
eNFA1_2_10750772[["εNFA1-2 regex start"]]
eNFA1_0_65506178[["εNFA1-0 char{1, 1}"]]
eNFA1_4_29648085[["εNFA1-4 scope{1, 1}"]]
eNFA1_1_39601516[["εNFA1-1 char[1]"]]
eNFA1_5_52684690[["εNFA1-5 scope[1]"]]
eNFA1_3_4400168[["εNFA1-3 regex end"]]
eNFA1_2_20869327[["εNFA1-2 regex start"]]
eNFA1_0_12693918[["εNFA1-0 char{1, 1}"]]
eNFA1_4_53606218[["εNFA1-4 scope{1, 1}"]]
eNFA1_3_47136405[["εNFA1-3 regex end"]]
eNFA1_1_59952436[["εNFA1-1 char[1]"]]
eNFA1_5_2701015[["εNFA1-5 scope[1]"]]
eNFA1_7_21574462[["εNFA1-7 regex end"]]
class eNFA1_7_21574462 c0100;
eNFA1_8_17455632[["εNFA1-8 post-regex start"]]
class eNFA1_8_17455632 c0010;
eNFA1_9_22882960[\"εNFA1-9 post-regex end"/]
class eNFA1_9_22882960 c0001;
eNFA0_1_23120425[\"εNFA0-1 wholeEnd"/]
eNFA0_0_4620049 -.->|"ε"|eNFA1_6_24309136
eNFA1_6_24309136 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_10750772
eNFA1_2_10750772 -.->|"ε"|eNFA1_0_65506178
eNFA1_2_10750772 -.->|"ε"|eNFA1_4_29648085
eNFA1_0_65506178 -->|"#92;"|eNFA1_1_39601516
eNFA1_4_29648085 -->|"[Y-#92;]"|eNFA1_5_52684690
eNFA1_1_39601516 -.->|"ε"|eNFA1_3_4400168
eNFA1_5_52684690 -.->|"ε"|eNFA1_3_4400168
eNFA1_3_4400168 -.->|"ε"|eNFA1_2_20869327
eNFA1_2_20869327 -.->|"ε"|eNFA1_0_12693918
eNFA1_2_20869327 -.->|"ε"|eNFA1_4_53606218
eNFA1_2_20869327 -.->|"ε"|eNFA1_3_47136405
eNFA1_0_12693918 -->|"#92;"|eNFA1_1_59952436
eNFA1_4_53606218 -->|"[Y-#92;]"|eNFA1_5_2701015
eNFA1_3_47136405 -.->|"ε"|eNFA1_2_20869327
eNFA1_3_47136405 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_21574462
eNFA1_1_59952436 -.->|"ε"|eNFA1_3_47136405
eNFA1_5_2701015 -.->|"ε"|eNFA1_3_47136405
eNFA1_7_21574462 -.->|"ε"|eNFA1_8_17455632
eNFA1_8_17455632 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_22882960
eNFA1_9_22882960 -.->|"ε"|eNFA0_1_23120425

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
eNFA0_0_42371273[["εNFA0-0 wholeStart"]]
class eNFA0_0_42371273 c1000;
eNFA1_6_6757235[["εNFA1-6 regex start"]]
class eNFA1_6_6757235 c1000;
eNFA1_2_41580444[["εNFA1-2 regex start"]]
class eNFA1_2_41580444 c1000;
eNFA1_0_12572829[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_12572829 c1000;
eNFA1_4_38679683[["εNFA1-4 scope{1, 1}"]]
class eNFA1_4_38679683 c1000;
eNFA1_1_38787544[\"εNFA1-1 char[1]
AcceptToken 'refVt'"/]
class eNFA1_1_38787544 c0111;
eNFA1_5_46046605[\"εNFA1-5 scope[1]
AcceptToken 'refVt'"/]
class eNFA1_5_46046605 c0111;
eNFA1_3_11766267[\"εNFA1-3 regex end
AcceptToken 'refVt'"/]
class eNFA1_3_11766267 c0111;
eNFA1_2_13543581[\"εNFA1-2 regex start
AcceptToken 'refVt'"/]
class eNFA1_2_13543581 c0111;
eNFA1_0_23288300[\"εNFA1-0 char{1, 1}"/]
eNFA1_4_54783372[\"εNFA1-4 scope{1, 1}"/]
eNFA1_3_8268111[\"εNFA1-3 regex end
AcceptToken 'refVt'"/]
class eNFA1_3_8268111 c0111;
eNFA1_1_65737292[\"εNFA1-1 char[1]
AcceptToken 'refVt'"/]
class eNFA1_1_65737292 c0111;
eNFA1_5_54764719[\"εNFA1-5 scope[1]
AcceptToken 'refVt'"/]
class eNFA1_5_54764719 c0111;
eNFA1_7_7304143[\"εNFA1-7 regex end
AcceptToken 'refVt'"/]
class eNFA1_7_7304143 c0111;
eNFA1_8_60815118[\"εNFA1-8 post-regex start
AcceptToken 'refVt'"/]
class eNFA1_8_60815118 c0011;
eNFA1_9_10465156[\"εNFA1-9 post-regex end"/]
class eNFA1_9_10465156 c0011;
eNFA0_1_27077540[\"εNFA0-1 wholeEnd"/]
eNFA0_0_42371273 -.->|"ε"|eNFA1_6_6757235
eNFA0_0_42371273 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_41580444
eNFA0_0_42371273 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_12572829
eNFA0_0_42371273 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_38679683
eNFA0_0_42371273 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_38787544
eNFA0_0_42371273 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_46046605
eNFA1_6_6757235 -.->|"ε
BeginToken 'refVt'"|eNFA1_2_41580444
eNFA1_6_6757235 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_12572829
eNFA1_6_6757235 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_38679683
eNFA1_6_6757235 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_38787544
eNFA1_6_6757235 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_46046605
eNFA1_2_41580444 -.->|"ε
BeginToken 'refVt'"|eNFA1_0_12572829
eNFA1_2_41580444 -.->|"ε
BeginToken 'refVt'"|eNFA1_4_38679683
eNFA1_2_41580444 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_38787544
eNFA1_2_41580444 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_46046605
eNFA1_0_12572829 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_1_38787544
eNFA1_4_38679683 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|eNFA1_5_46046605
eNFA1_1_38787544 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_11766267
eNFA1_1_38787544 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_1_38787544 -.->|"ε"|eNFA1_0_23288300
eNFA1_1_38787544 -.->|"ε"|eNFA1_4_54783372
eNFA1_1_38787544 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_1_38787544 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_1_38787544 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_1_38787544 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_1_38787544 -.->|"ε"|eNFA1_8_60815118
eNFA1_1_38787544 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_1_38787544 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_5_46046605 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_11766267
eNFA1_5_46046605 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_5_46046605 -.->|"ε"|eNFA1_0_23288300
eNFA1_5_46046605 -.->|"ε"|eNFA1_4_54783372
eNFA1_5_46046605 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_5_46046605 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_5_46046605 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_5_46046605 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_5_46046605 -.->|"ε"|eNFA1_8_60815118
eNFA1_5_46046605 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_5_46046605 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_3_11766267 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_3_11766267 -.->|"ε"|eNFA1_0_23288300
eNFA1_3_11766267 -.->|"ε"|eNFA1_4_54783372
eNFA1_3_11766267 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_3_11766267 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_3_11766267 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_3_11766267 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_3_11766267 -.->|"ε"|eNFA1_8_60815118
eNFA1_3_11766267 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_3_11766267 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_2_13543581 -.->|"ε"|eNFA1_0_23288300
eNFA1_2_13543581 -.->|"ε"|eNFA1_4_54783372
eNFA1_2_13543581 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_2_13543581 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_2_13543581 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_2_13543581 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_2_13543581 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_2_13543581 -.->|"ε"|eNFA1_8_60815118
eNFA1_2_13543581 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_2_13543581 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_0_23288300 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_4_54783372 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_3_8268111 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_3_8268111 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_3_8268111 -.->|"ε"|eNFA1_0_23288300
eNFA1_3_8268111 -.->|"ε"|eNFA1_4_54783372
eNFA1_3_8268111 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_3_8268111 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_3_8268111 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_3_8268111 -.->|"ε"|eNFA1_8_60815118
eNFA1_3_8268111 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_3_8268111 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_1_65737292 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_1_65737292 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_1_65737292 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_1_65737292 -.->|"ε"|eNFA1_0_23288300
eNFA1_1_65737292 -.->|"ε"|eNFA1_4_54783372
eNFA1_1_65737292 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_1_65737292 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_1_65737292 -.->|"ε"|eNFA1_8_60815118
eNFA1_1_65737292 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_1_65737292 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_5_54764719 -.->|"ε
ExtendToken 'refVt'"|eNFA1_3_8268111
eNFA1_5_54764719 -.->|"ε
ExtendToken 'refVt'"|eNFA1_2_13543581
eNFA1_5_54764719 -.->|"ε
ExtendToken 'refVt'"|eNFA1_7_7304143
eNFA1_5_54764719 -.->|"ε"|eNFA1_0_23288300
eNFA1_5_54764719 -.->|"ε"|eNFA1_4_54783372
eNFA1_5_54764719 -->|"#92;
ExtendToken 'refVt'"|eNFA1_1_65737292
eNFA1_5_54764719 -->|"[Y-#92;]
ExtendToken 'refVt'"|eNFA1_5_54764719
eNFA1_5_54764719 -.->|"ε"|eNFA1_8_60815118
eNFA1_5_54764719 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_5_54764719 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_7_7304143 -.->|"ε"|eNFA1_8_60815118
eNFA1_7_7304143 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_7_7304143 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_8_60815118 -.->|"ε
CheckToken 'refVt'
AcceptToken 'refVt'"|eNFA1_9_10465156
eNFA1_8_60815118 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540
eNFA1_9_10465156 -.->|"ε
CheckToken 'refVt'"|eNFA0_1_27077540

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
NFA0_0_9521066("NFA0-0 wholeStart")
class NFA0_0_9521066 c1000;
NFA1_1_45797138[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_45797138 c0101;
NFA1_5_18580737[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_18580737 c0101;
NFA1_1_33008913[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_33008913 c0101;
NFA1_5_28644761[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_28644761 c0101;
NFA0_0_9521066 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|NFA1_1_45797138
NFA0_0_9521066 -->|"[Y-#92;]
BeginToken 'refVt'
ExtendToken 'refVt'"|NFA1_5_18580737
NFA1_1_45797138 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_33008913
NFA1_1_45797138 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_28644761
NFA1_5_18580737 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_33008913
NFA1_5_18580737 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_28644761
NFA1_1_33008913 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_33008913
NFA1_1_33008913 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_28644761
NFA1_5_28644761 -->|"#92;
ExtendToken 'refVt'"|NFA1_1_33008913
NFA1_5_28644761 -->|"[Y-#92;]
ExtendToken 'refVt'"|NFA1_5_28644761

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
subgraph DFA0_-992434304["DFA0 wholeStart"]
NFA0_0_9521066_0("NFA0-0 wholeStart")
class NFA0_0_9521066_0 c1000;
end
class DFA0_-992434304 c1000;
subgraph DFA1_1229971353["DFA1 {2}"]
NFA1_1_45797138_1[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_45797138_1 c0101;
NFA1_5_18580737_2[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_18580737_2 c0101;
end
class DFA1_1229971353 c0101;
subgraph DFA2_2023701841["DFA2 {1}"]
NFA1_5_18580737_3[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_18580737_3 c0101;
end
class DFA2_2023701841 c0101;
subgraph DFA3_-1429252716["DFA3 {2}"]
NFA1_1_33008913_4[\"NFA1-1 char[1]
AcceptToken 'refVt'"/]
class NFA1_1_33008913_4 c0101;
NFA1_5_28644761_5[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_28644761_5 c0101;
end
class DFA3_-1429252716 c0101;
subgraph DFA4_-548496545["DFA4 {1}"]
NFA1_5_28644761_6[\"NFA1-5 scope[1]
AcceptToken 'refVt'"/]
class NFA1_5_28644761_6 c0101;
end
class DFA4_-548496545 c0101;
DFA0_-992434304 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA1_1229971353
DFA0_-992434304 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA2_2023701841
DFA1_1229971353 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA1_1229971353 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA2_2023701841 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA2_2023701841 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA3_-1429252716 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA3_-1429252716 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA4_-548496545 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA4_-548496545 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545

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
DFA0_-992434304{{"DFA0 wholeStart"}}
class DFA0_-992434304 c1000;
DFA1_1229971353[\"DFA1 {2}
AcceptToken 'refVt'"/]
class DFA1_1229971353 c0101;
DFA2_2023701841[\"DFA2 {1}
AcceptToken 'refVt'"/]
class DFA2_2023701841 c0101;
DFA3_-1429252716[\"DFA3 {2}
AcceptToken 'refVt'"/]
class DFA3_-1429252716 c0101;
DFA4_-548496545[\"DFA4 {1}
AcceptToken 'refVt'"/]
class DFA4_-548496545 c0101;
DFA0_-992434304 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA1_1229971353
DFA0_-992434304 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|DFA2_2023701841
DFA1_1229971353 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA1_1229971353 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA2_2023701841 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA2_2023701841 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA3_-1429252716 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA3_-1429252716 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545
DFA4_-548496545 -->|"#92;
ExtendToken 'refVt'"|DFA3_-1429252716
DFA4_-548496545 -->|"[Y-[]
ExtendToken 'refVt'"|DFA4_-548496545

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
subgraph MiniDFA0_1314395133["MiniDFA0 {1}"]
DFA0_-992434304_0{{"DFA0 wholeStart"}}
class DFA0_-992434304_0 c1000;
end
class MiniDFA0_1314395133 c1000;
subgraph MiniDFA1_1661446366["MiniDFA1 {1}"]
DFA1_1229971353_1[\"DFA1 {2}
AcceptToken 'refVt'"/]
class DFA1_1229971353_1 c0101;
end
class MiniDFA1_1661446366 c0101;
subgraph MiniDFA2_-284544133["MiniDFA2 {1}"]
DFA2_2023701841_2[\"DFA2 {1}
AcceptToken 'refVt'"/]
class DFA2_2023701841_2 c0101;
end
class MiniDFA2_-284544133 c0101;
subgraph MiniDFA3_-1132809715["MiniDFA3 {1}"]
DFA3_-1429252716_3[\"DFA3 {2}
AcceptToken 'refVt'"/]
class DFA3_-1429252716_3 c0101;
end
class MiniDFA3_-1132809715 c0101;
subgraph MiniDFA4_1134719931["MiniDFA4 {1}"]
DFA4_-548496545_4[\"DFA4 {1}
AcceptToken 'refVt'"/]
class DFA4_-548496545_4 c0101;
end
class MiniDFA4_1134719931 c0101;
MiniDFA0_1314395133 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA1_1661446366
MiniDFA0_1314395133 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA2_-284544133
MiniDFA1_1661446366 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA1_1661446366 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA2_-284544133 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA2_-284544133 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA3_-1132809715 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA3_-1132809715 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA4_1134719931 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA4_1134719931 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931

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
MiniDFA0_1314395133(["MiniDFA0 {1}"])
class MiniDFA0_1314395133 c1000;
MiniDFA1_1661446366[\"MiniDFA1 {1}
AcceptToken 'refVt'"/]
class MiniDFA1_1661446366 c0101;
MiniDFA2_-284544133[\"MiniDFA2 {1}
AcceptToken 'refVt'"/]
class MiniDFA2_-284544133 c0101;
MiniDFA3_-1132809715[\"MiniDFA3 {1}
AcceptToken 'refVt'"/]
class MiniDFA3_-1132809715 c0101;
MiniDFA4_1134719931[\"MiniDFA4 {1}
AcceptToken 'refVt'"/]
class MiniDFA4_1134719931 c0101;
MiniDFA0_1314395133 -->|"#92;
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA1_1661446366
MiniDFA0_1314395133 -->|"[Y-[]
BeginToken 'refVt'
ExtendToken 'refVt'"|MiniDFA2_-284544133
MiniDFA1_1661446366 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA1_1661446366 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA2_-284544133 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA2_-284544133 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA3_-1132809715 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA3_-1132809715 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931
MiniDFA4_1134719931 -->|"#92;
ExtendToken 'refVt'"|MiniDFA3_-1132809715
MiniDFA4_1134719931 -->|"[Y-[]
ExtendToken 'refVt'"|MiniDFA4_1134719931

```

# 总结

无。

