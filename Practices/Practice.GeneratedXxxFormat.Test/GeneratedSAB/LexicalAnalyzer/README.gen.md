# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `SAB`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（14个State）。

## 'a'
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
eNFA0_2_6168214[["εNFA0-2 regex start"]]
eNFA0_0_55513932[["εNFA0-0 char{1, 1}"]]
eNFA0_1_29863346[["εNFA0-1 char[1]"]]
eNFA0_3_334666[["εNFA0-3 regex end"]]
eNFA0_2_6168214 -.->|"ε"|eNFA0_0_55513932
eNFA0_0_55513932 -->|"a"|eNFA0_1_29863346
eNFA0_1_29863346 -.->|"ε"|eNFA0_3_334666
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
eNFA0_4_3011995[["εNFA0-4 post-regex start"]]
eNFA0_5_27107960[\"εNFA0-5 post-regex end"/]
eNFA0_4_3011995 -.->|"ε"|eNFA0_5_27107960
```


## 's'
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
eNFA0_2_32530274[["εNFA0-2 regex start"]]
eNFA0_0_24337017[["εNFA0-0 char{1, 1}"]]
eNFA0_1_17706563[["εNFA0-1 char[1]"]]
eNFA0_3_25141347[["εNFA0-3 regex end"]]
eNFA0_2_32530274 -.->|"ε"|eNFA0_0_24337017
eNFA0_0_24337017 -->|"s"|eNFA0_1_17706563
eNFA0_1_17706563 -.->|"ε"|eNFA0_3_25141347
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
eNFA0_4_24945537[["εNFA0-4 post-regex start"]]
eNFA0_5_23183246[\"εNFA0-5 post-regex end"/]
eNFA0_4_24945537 -.->|"ε"|eNFA0_5_23183246
```


## 'b'
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
eNFA0_2_63543344[["εNFA0-2 regex start"]]
eNFA0_0_35019191[["εNFA0-0 char{1, 1}"]]
eNFA0_1_46737271[["εNFA0-1 char[1]"]]
eNFA0_3_17982255[["εNFA0-3 regex end"]]
eNFA0_2_63543344 -.->|"ε"|eNFA0_0_35019191
eNFA0_0_35019191 -->|"b"|eNFA0_1_46737271
eNFA0_1_46737271 -.->|"ε"|eNFA0_3_17982255
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
eNFA0_4_27622569[["εNFA0-4 post-regex start"]]
eNFA0_5_47276535[\"εNFA0-5 post-regex end"/]
eNFA0_4_27622569 -.->|"ε"|eNFA0_5_47276535
```


## 'd'
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
eNFA0_2_29923648[["εNFA0-2 regex start"]]
eNFA0_0_877384[["εNFA0-0 char{1, 1}"]]
eNFA0_1_7896460[["εNFA0-1 char[1]"]]
eNFA0_3_3959276[["εNFA0-3 regex end"]]
eNFA0_2_29923648 -.->|"ε"|eNFA0_0_877384
eNFA0_0_877384 -->|"d"|eNFA0_1_7896460
eNFA0_1_7896460 -.->|"ε"|eNFA0_3_3959276
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
eNFA0_4_35633491[["εNFA0-4 post-regex start"]]
eNFA0_5_52265969[\"εNFA0-5 post-regex end"/]
eNFA0_4_35633491 -.->|"ε"|eNFA0_5_52265969
```


## 'c'
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
eNFA0_2_2112211[["εNFA0-2 regex start"]]
eNFA0_0_19009899[["εNFA0-0 char{1, 1}"]]
eNFA0_1_36871363[["εNFA0-1 char[1]"]]
eNFA0_3_63406812[["εNFA0-3 regex end"]]
eNFA0_2_2112211 -.->|"ε"|eNFA0_0_19009899
eNFA0_0_19009899 -->|"c"|eNFA0_1_36871363
eNFA0_1_36871363 -.->|"ε"|eNFA0_3_63406812
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
eNFA0_4_33790399[["εNFA0-4 post-regex start"]]
eNFA0_5_35678142[\"εNFA0-5 post-regex end"/]
eNFA0_4_33790399 -.->|"ε"|eNFA0_5_35678142
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
eNFA0_16_18373927[["εNFA0-16 regex start"]]
eNFA0_0_31147615[["εNFA0-0 char{1, 1}"]]
eNFA0_1_11893084[["εNFA0-1 char[1]"]]
eNFA0_2_39928893[["εNFA0-2 char{1, 1}"]]
eNFA0_3_51839388[["εNFA0-3 char[1]"]]
eNFA0_6_1047692[["εNFA0-6 regex start"]]
eNFA0_4_17754262[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_9429236[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_28809145[["εNFA0-7 regex end"]]
eNFA0_5_57955715[["εNFA0-5 scope[1]"]]
eNFA0_9_25542086[["εNFA0-9 scope[1]"]]
eNFA0_12_63901309[["εNFA0-12 char{1, 1}"]]
eNFA0_10_10797361[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_30067389[["εNFA0-13 char[1]"]]
eNFA0_11_25570637[["εNFA0-11 scope[1]"]]
eNFA0_14_2171049[["εNFA0-14 char{1, 1}"]]
eNFA0_15_41637294[["εNFA0-15 char[1]"]]
eNFA0_17_39191328[["εNFA0-17 regex end"]]
eNFA0_16_18373927 -.->|"ε"|eNFA0_0_31147615
eNFA0_0_31147615 -->|"/"|eNFA0_1_11893084
eNFA0_1_11893084 -.->|"ε"|eNFA0_2_39928893
eNFA0_2_39928893 -->|"*"|eNFA0_3_51839388
eNFA0_3_51839388 -.->|"ε"|eNFA0_6_1047692
eNFA0_6_1047692 -.->|"ε"|eNFA0_4_17754262
eNFA0_6_1047692 -.->|"ε"|eNFA0_8_9429236
eNFA0_6_1047692 -.->|"ε"|eNFA0_7_28809145
eNFA0_4_17754262 -->|"[^*]"|eNFA0_5_57955715
eNFA0_8_9429236 -->|"[*]"|eNFA0_9_25542086
eNFA0_7_28809145 -.->|"ε"|eNFA0_6_1047692
eNFA0_7_28809145 -.->|"ε"|eNFA0_12_63901309
eNFA0_5_57955715 -.->|"ε"|eNFA0_7_28809145
eNFA0_9_25542086 -.->|"ε"|eNFA0_10_10797361
eNFA0_12_63901309 -->|"*"|eNFA0_13_30067389
eNFA0_10_10797361 -->|"[^/]"|eNFA0_11_25570637
eNFA0_13_30067389 -.->|"ε"|eNFA0_14_2171049
eNFA0_11_25570637 -.->|"ε"|eNFA0_7_28809145
eNFA0_14_2171049 -->|"/"|eNFA0_15_41637294
eNFA0_15_41637294 -.->|"ε"|eNFA0_17_39191328
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
eNFA0_18_17177639[["εNFA0-18 post-regex start"]]
eNFA0_19_20381027[\"εNFA0-19 post-regex end"/]
eNFA0_18_17177639 -.->|"ε"|eNFA0_19_20381027
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
eNFA0_5_35849007[["εNFA0-5 regex start"]]
eNFA0_0_54205609[["εNFA0-0 char{1, 1}"]]
eNFA0_1_18088435[["εNFA0-1 char[1]"]]
eNFA0_2_28578190[["εNFA0-2 char{1, 1}"]]
eNFA0_3_8623523[["εNFA0-3 char[1]"]]
eNFA0_4_10502851[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_27416799[["εNFA0-6 regex end"]]
eNFA0_5_35849007 -.->|"ε"|eNFA0_0_54205609
eNFA0_0_54205609 -->|"/"|eNFA0_1_18088435
eNFA0_1_18088435 -.->|"ε"|eNFA0_2_28578190
eNFA0_2_28578190 -->|"/"|eNFA0_3_8623523
eNFA0_3_8623523 -.->|"ε"|eNFA0_4_10502851
eNFA0_4_10502851 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_10502851
eNFA0_4_10502851 -.->|"ε"|eNFA0_6_27416799
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
eNFA0_7_66451858[["εNFA0-7 post-regex start"]]
eNFA0_8_61195818[\"εNFA0-8 post-regex end"/]
eNFA0_7_66451858 -.->|"ε"|eNFA0_8_61195818
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
eNFA0_0_45524249[["εNFA0-0 wholeStart"]]
eNFA1_2_35329658[["εNFA1-2 regex start"]]
class eNFA1_2_35329658 c1000;
eNFA2_2_7065065[["εNFA2-2 regex start"]]
class eNFA2_2_7065065 c1000;
eNFA3_2_57439703[["εNFA3-2 regex start"]]
class eNFA3_2_57439703 c1000;
eNFA4_2_4517709[["εNFA4-2 regex start"]]
class eNFA4_2_4517709 c1000;
eNFA5_2_9071242[["εNFA5-2 regex start"]]
class eNFA5_2_9071242 c1000;
eNFA6_16_36188385[["εNFA6-16 regex start"]]
class eNFA6_16_36188385 c1000;
eNFA7_5_31024646[["εNFA7-5 regex start"]]
class eNFA7_5_31024646 c1000;
eNFA1_0_49531474[["εNFA1-0 char{1, 1}"]]
eNFA2_0_50158847[["εNFA2-0 char{1, 1}"]]
eNFA3_0_22104370[["εNFA3-0 char{1, 1}"]]
eNFA4_0_30390109[["εNFA4-0 char{1, 1}"]]
eNFA5_0_63682040[["εNFA5-0 char{1, 1}"]]
eNFA6_0_45578038[["εNFA6-0 char{1, 1}"]]
eNFA7_0_29968374[["εNFA7-0 char{1, 1}"]]
eNFA1_1_43130086[["εNFA1-1 char[1]"]]
eNFA2_1_48776445[["εNFA2-1 char[1]"]]
eNFA3_1_64721603[["εNFA3-1 char[1]"]]
eNFA4_1_5075526[["εNFA4-1 char[1]"]]
eNFA5_1_36267453[["εNFA5-1 char[1]"]]
eNFA6_1_39706416[["εNFA6-1 char[1]"]]
eNFA7_1_21813425[["εNFA7-1 char[1]"]]
eNFA1_3_52626454[["εNFA1-3 regex end"]]
class eNFA1_3_52626454 c0100;
eNFA2_3_36334825[["εNFA2-3 regex end"]]
class eNFA2_3_36334825 c0100;
eNFA3_3_45623521[["εNFA3-3 regex end"]]
class eNFA3_3_45623521 c0100;
eNFA4_3_45679737[["εNFA4-3 regex end"]]
class eNFA4_3_45679737 c0100;
eNFA5_3_57971626[["εNFA5-3 regex end"]]
class eNFA5_3_57971626 c0100;
eNFA6_2_62103099[["εNFA6-2 char{1, 1}"]]
eNFA7_2_22056983[["εNFA7-2 char{1, 1}"]]
eNFA1_4_3876045[["εNFA1-4 post-regex start"]]
class eNFA1_4_3876045 c0010;
eNFA2_4_58577972[["εNFA2-4 post-regex start"]]
class eNFA2_4_58577972 c0010;
eNFA3_4_7958508[["εNFA3-4 post-regex start"]]
class eNFA3_4_7958508 c0010;
eNFA4_4_8464456[["εNFA4-4 post-regex start"]]
class eNFA4_4_8464456 c0010;
eNFA5_4_51982593[["εNFA5-4 post-regex start"]]
class eNFA5_4_51982593 c0010;
eNFA6_3_27806444[["εNFA6-3 char[1]"]]
eNFA7_3_3697038[["εNFA7-3 char[1]"]]
eNFA1_5_34884411[\"εNFA1-5 post-regex end"/]
class eNFA1_5_34884411 c0001;
eNFA2_5_63585586[\"εNFA2-5 post-regex end"/]
class eNFA2_5_63585586 c0001;
eNFA3_5_47195283[\"εNFA3-5 post-regex end"/]
class eNFA3_5_47195283 c0001;
eNFA4_5_40659381[\"εNFA4-5 post-regex end"/]
class eNFA4_5_40659381 c0001;
eNFA5_5_14532322[\"εNFA5-5 post-regex end"/]
class eNFA5_5_14532322 c0001;
eNFA6_6_65190153[["εNFA6-6 regex start"]]
eNFA7_4_410782[["εNFA7-4 char{0, ∞}"]]
eNFA0_1_35399367[\"εNFA0-1 wholeEnd"/]
eNFA6_4_45911036[["εNFA6-4 scope{1, 1}"]]
eNFA6_8_49840468[["εNFA6-8 scope{1, 1}"]]
eNFA6_7_10546145[["εNFA6-7 regex end"]]
eNFA7_6_33273344[["εNFA7-6 regex end"]]
class eNFA7_6_33273344 c0100;
eNFA6_5_37729472[["εNFA6-5 scope[1]"]]
eNFA6_9_41656292[["εNFA6-9 scope[1]"]]
eNFA6_12_48931406[["εNFA6-12 char{1, 1}"]]
eNFA7_7_1279915[["εNFA7-7 post-regex start"]]
class eNFA7_7_1279915 c0010;
eNFA6_10_39641102[["εNFA6-10 scope{1, 1}"]]
eNFA6_13_21225601[["εNFA6-13 char[1]"]]
eNFA7_8_10786359[\"εNFA7-8 post-regex end"/]
class eNFA7_8_10786359 c0001;
eNFA6_11_4020931[["εNFA6-11 scope[1]"]]
eNFA6_14_56812682[["εNFA6-14 char{1, 1}"]]
eNFA6_15_7549159[["εNFA6-15 char[1]"]]
eNFA6_17_833575[["εNFA6-17 regex end"]]
class eNFA6_17_833575 c0100;
eNFA6_18_7502182[["εNFA6-18 post-regex start"]]
class eNFA6_18_7502182 c0010;
eNFA6_19_57260009[\"εNFA6-19 post-regex end"/]
class eNFA6_19_57260009 c0001;
eNFA0_0_45524249 -.->|"ε"|eNFA1_2_35329658
eNFA0_0_45524249 -.->|"ε"|eNFA2_2_7065065
eNFA0_0_45524249 -.->|"ε"|eNFA3_2_57439703
eNFA0_0_45524249 -.->|"ε"|eNFA4_2_4517709
eNFA0_0_45524249 -.->|"ε"|eNFA5_2_9071242
eNFA0_0_45524249 -.->|"ε"|eNFA6_16_36188385
eNFA0_0_45524249 -.->|"ε"|eNFA7_5_31024646
eNFA1_2_35329658 -.->|"ε
BeginToken 'a'"|eNFA1_0_49531474
eNFA2_2_7065065 -.->|"ε
BeginToken 's'"|eNFA2_0_50158847
eNFA3_2_57439703 -.->|"ε
BeginToken 'b'"|eNFA3_0_22104370
eNFA4_2_4517709 -.->|"ε
BeginToken 'd'"|eNFA4_0_30390109
eNFA5_2_9071242 -.->|"ε
BeginToken 'c'"|eNFA5_0_63682040
eNFA6_16_36188385 -.->|"ε
BeginToken 'blockComment'"|eNFA6_0_45578038
eNFA7_5_31024646 -.->|"ε
BeginToken 'inlineComment'"|eNFA7_0_29968374
eNFA1_0_49531474 -->|"a"|eNFA1_1_43130086
eNFA2_0_50158847 -->|"s"|eNFA2_1_48776445
eNFA3_0_22104370 -->|"b"|eNFA3_1_64721603
eNFA4_0_30390109 -->|"d"|eNFA4_1_5075526
eNFA5_0_63682040 -->|"c"|eNFA5_1_36267453
eNFA6_0_45578038 -->|"/"|eNFA6_1_39706416
eNFA7_0_29968374 -->|"/"|eNFA7_1_21813425
eNFA1_1_43130086 -.->|"ε
ExtendToken 'a'"|eNFA1_3_52626454
eNFA2_1_48776445 -.->|"ε
ExtendToken 's'"|eNFA2_3_36334825
eNFA3_1_64721603 -.->|"ε
ExtendToken 'b'"|eNFA3_3_45623521
eNFA4_1_5075526 -.->|"ε
ExtendToken 'd'"|eNFA4_3_45679737
eNFA5_1_36267453 -.->|"ε
ExtendToken 'c'"|eNFA5_3_57971626
eNFA6_1_39706416 -.->|"ε"|eNFA6_2_62103099
eNFA7_1_21813425 -.->|"ε"|eNFA7_2_22056983
eNFA1_3_52626454 -.->|"ε"|eNFA1_4_3876045
eNFA2_3_36334825 -.->|"ε"|eNFA2_4_58577972
eNFA3_3_45623521 -.->|"ε"|eNFA3_4_7958508
eNFA4_3_45679737 -.->|"ε"|eNFA4_4_8464456
eNFA5_3_57971626 -.->|"ε"|eNFA5_4_51982593
eNFA6_2_62103099 -->|"*"|eNFA6_3_27806444
eNFA7_2_22056983 -->|"/"|eNFA7_3_3697038
eNFA1_4_3876045 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_34884411
eNFA2_4_58577972 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_63585586
eNFA3_4_7958508 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_47195283
eNFA4_4_8464456 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_40659381
eNFA5_4_51982593 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_14532322
eNFA6_3_27806444 -.->|"ε"|eNFA6_6_65190153
eNFA7_3_3697038 -.->|"ε"|eNFA7_4_410782
eNFA1_5_34884411 -.->|"ε"|eNFA0_1_35399367
eNFA2_5_63585586 -.->|"ε"|eNFA0_1_35399367
eNFA3_5_47195283 -.->|"ε"|eNFA0_1_35399367
eNFA4_5_40659381 -.->|"ε"|eNFA0_1_35399367
eNFA5_5_14532322 -.->|"ε"|eNFA0_1_35399367
eNFA6_6_65190153 -.->|"ε"|eNFA6_4_45911036
eNFA6_6_65190153 -.->|"ε"|eNFA6_8_49840468
eNFA6_6_65190153 -.->|"ε"|eNFA6_7_10546145
eNFA7_4_410782 -->|"[#92;t#92;r#32;-~]"|eNFA7_4_410782
eNFA7_4_410782 -.->|"ε
ExtendToken 'inlineComment'"|eNFA7_6_33273344
eNFA6_4_45911036 -->|"[^*]"|eNFA6_5_37729472
eNFA6_8_49840468 -->|"[*]"|eNFA6_9_41656292
eNFA6_7_10546145 -.->|"ε"|eNFA6_6_65190153
eNFA6_7_10546145 -.->|"ε"|eNFA6_12_48931406
eNFA7_6_33273344 -.->|"ε"|eNFA7_7_1279915
eNFA6_5_37729472 -.->|"ε"|eNFA6_7_10546145
eNFA6_9_41656292 -.->|"ε"|eNFA6_10_39641102
eNFA6_12_48931406 -->|"*"|eNFA6_13_21225601
eNFA7_7_1279915 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA7_8_10786359
eNFA6_10_39641102 -->|"[^/]"|eNFA6_11_4020931
eNFA6_13_21225601 -.->|"ε"|eNFA6_14_56812682
eNFA7_8_10786359 -.->|"ε"|eNFA0_1_35399367
eNFA6_11_4020931 -.->|"ε"|eNFA6_7_10546145
eNFA6_14_56812682 -->|"/"|eNFA6_15_7549159
eNFA6_15_7549159 -.->|"ε
ExtendToken 'blockComment'"|eNFA6_17_833575
eNFA6_17_833575 -.->|"ε"|eNFA6_18_7502182
eNFA6_18_7502182 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA6_19_57260009
eNFA6_19_57260009 -.->|"ε"|eNFA0_1_35399367

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
eNFA0_0_11519239[["εNFA0-0 wholeStart"]]
class eNFA0_0_11519239 c1000;
eNFA1_2_60643168[["εNFA1-2 regex start"]]
class eNFA1_2_60643168 c1000;
eNFA2_2_36564291[["εNFA2-2 regex start"]]
class eNFA2_2_36564291 c1000;
eNFA3_2_8917608[["εNFA3-2 regex start"]]
class eNFA3_2_8917608 c1000;
eNFA4_2_13149610[["εNFA4-2 regex start"]]
class eNFA4_2_13149610 c1000;
eNFA5_2_51237633[["εNFA5-2 regex start"]]
class eNFA5_2_51237633 c1000;
eNFA6_16_58485517[["εNFA6-16 regex start"]]
class eNFA6_16_58485517 c1000;
eNFA7_5_56607607[["εNFA7-5 regex start"]]
class eNFA7_5_56607607 c1000;
eNFA1_0_25375958[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_25375958 c1000;
eNFA2_0_61683061[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_61683061 c1000;
eNFA3_0_36117414[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_36117414 c1000;
eNFA4_0_4957353[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_4957353 c1000;
eNFA5_0_44504510[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_44504510 c1000;
eNFA6_0_3423268[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_3423268 c1000;
eNFA7_0_45706525[["εNFA7-0 char{1, 1}"]]
class eNFA7_0_45706525 c1000;
eNFA1_1_27057037[\"εNFA1-1 char[1]
AcceptToken 'a'"/]
class eNFA1_1_27057037 c0111;
eNFA2_1_18276642[\"εNFA2-1 char[1]
AcceptToken 's'"/]
class eNFA2_1_18276642 c0111;
eNFA3_1_56621273[\"εNFA3-1 char[1]
AcceptToken 'b'"/]
class eNFA3_1_56621273 c0111;
eNFA4_1_44616179[\"εNFA4-1 char[1]
AcceptToken 'd'"/]
class eNFA4_1_44616179 c0111;
eNFA5_1_64996270[\"εNFA5-1 char[1]
AcceptToken 'c'"/]
class eNFA5_1_64996270 c0111;
eNFA6_1_11241060[["εNFA6-1 char[1]"]]
eNFA7_1_38110696[["εNFA7-1 char[1]"]]
eNFA1_3_42186743[\"εNFA1-3 regex end
AcceptToken 'a'"/]
class eNFA1_3_42186743 c0111;
eNFA1_4_44136375[\"εNFA1-4 post-regex start
AcceptToken 'a'"/]
class eNFA1_4_44136375 c0011;
eNFA1_5_40522795[\"εNFA1-5 post-regex end"/]
class eNFA1_5_40522795 c0011;
eNFA0_1_41785235[\"εNFA0-1 wholeEnd"/]
eNFA2_3_30272055[\"εNFA2-3 regex end
AcceptToken 's'"/]
class eNFA2_3_30272055 c0111;
eNFA2_4_4013046[\"εNFA2-4 post-regex start
AcceptToken 's'"/]
class eNFA2_4_4013046 c0011;
eNFA2_5_64295127[\"εNFA2-5 post-regex end"/]
class eNFA2_5_64295127 c0011;
eNFA3_3_39829417[\"εNFA3-3 regex end
AcceptToken 'b'"/]
class eNFA3_3_39829417 c0111;
eNFA3_4_22920438[\"εNFA3-4 post-regex start
AcceptToken 'b'"/]
class eNFA3_4_22920438 c0011;
eNFA3_5_29160842[\"εNFA3-5 post-regex end"/]
class eNFA3_5_29160842 c0011;
eNFA4_3_66001293[\"εNFA4-3 regex end
AcceptToken 'd'"/]
class eNFA4_3_66001293 c0111;
eNFA4_4_57140728[\"εNFA4-4 post-regex start
AcceptToken 'd'"/]
class eNFA4_4_57140728 c0011;
eNFA4_5_61120992[\"εNFA4-5 post-regex end"/]
class eNFA4_5_61120992 c0011;
eNFA5_3_48095523[\"εNFA5-3 regex end
AcceptToken 'c'"/]
class eNFA5_3_48095523 c0111;
eNFA5_4_30206524[\"εNFA5-4 post-regex start
AcceptToken 'c'"/]
class eNFA5_4_30206524 c0011;
eNFA5_5_13218022[\"εNFA5-5 post-regex end"/]
class eNFA5_5_13218022 c0011;
eNFA6_2_67067536[["εNFA6-2 char{1, 1}"]]
eNFA6_3_39362312[["εNFA6-3 char[1]"]]
eNFA7_2_7451948[["εNFA7-2 char{1, 1}"]]
eNFA7_3_46082022[\"εNFA7-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA7_3_46082022 c0111;
eNFA6_6_51853342[["εNFA6-6 regex start"]]
eNFA6_4_39371148[["εNFA6-4 scope{1, 1}"]]
eNFA6_8_64026895[["εNFA6-8 scope{1, 1}"]]
eNFA6_7_18796012[["εNFA6-7 regex end"]]
eNFA6_5_34230728[["εNFA6-5 scope[1]"]]
eNFA6_9_66736917[["εNFA6-9 scope[1]"]]
eNFA6_12_18716495[["εNFA6-12 char{1, 1}"]]
eNFA6_13_36981231[["εNFA6-13 char[1]"]]
eNFA7_4_34946386[\"εNFA7-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA7_4_34946386 c0111;
eNFA7_6_12085017[\"εNFA7-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA7_6_12085017 c0111;
eNFA7_7_8705547[\"εNFA7-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA7_7_8705547 c0011;
eNFA7_8_41552090[\"εNFA7-8 post-regex end"/]
class eNFA7_8_41552090 c0011;
eNFA6_10_63761349[["εNFA6-10 scope{1, 1}"]]
eNFA6_11_38424490[["εNFA6-11 scope[1]"]]
eNFA6_14_34060683[["εNFA6-14 char{1, 1}"]]
eNFA6_15_30809419[\"εNFA6-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA6_15_30809419 c0111;
eNFA6_17_8849323[\"εNFA6-17 regex end
AcceptToken 'blockComment'"/]
class eNFA6_17_8849323 c0111;
eNFA6_18_12535043[\"εNFA6-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA6_18_12535043 c0011;
eNFA6_19_10276091[\"εNFA6-19 post-regex end"/]
class eNFA6_19_10276091 c0011;
eNFA0_0_11519239 -.->|"ε"|eNFA1_2_60643168
eNFA0_0_11519239 -.->|"ε"|eNFA2_2_36564291
eNFA0_0_11519239 -.->|"ε"|eNFA3_2_8917608
eNFA0_0_11519239 -.->|"ε"|eNFA4_2_13149610
eNFA0_0_11519239 -.->|"ε"|eNFA5_2_51237633
eNFA0_0_11519239 -.->|"ε"|eNFA6_16_58485517
eNFA0_0_11519239 -.->|"ε"|eNFA7_5_56607607
eNFA0_0_11519239 -.->|"ε
BeginToken 'a'"|eNFA1_0_25375958
eNFA0_0_11519239 -.->|"ε
BeginToken 's'"|eNFA2_0_61683061
eNFA0_0_11519239 -.->|"ε
BeginToken 'b'"|eNFA3_0_36117414
eNFA0_0_11519239 -.->|"ε
BeginToken 'd'"|eNFA4_0_4957353
eNFA0_0_11519239 -.->|"ε
BeginToken 'c'"|eNFA5_0_44504510
eNFA0_0_11519239 -.->|"ε
BeginToken 'blockComment'"|eNFA6_0_3423268
eNFA0_0_11519239 -.->|"ε
BeginToken 'inlineComment'"|eNFA7_0_45706525
eNFA0_0_11519239 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_27057037
eNFA0_0_11519239 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_18276642
eNFA0_0_11519239 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_56621273
eNFA0_0_11519239 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_44616179
eNFA0_0_11519239 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_64996270
eNFA0_0_11519239 -->|"/
BeginToken 'blockComment'"|eNFA6_1_11241060
eNFA0_0_11519239 -->|"/
BeginToken 'inlineComment'"|eNFA7_1_38110696
eNFA1_2_60643168 -.->|"ε
BeginToken 'a'"|eNFA1_0_25375958
eNFA1_2_60643168 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_27057037
eNFA2_2_36564291 -.->|"ε
BeginToken 's'"|eNFA2_0_61683061
eNFA2_2_36564291 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_18276642
eNFA3_2_8917608 -.->|"ε
BeginToken 'b'"|eNFA3_0_36117414
eNFA3_2_8917608 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_56621273
eNFA4_2_13149610 -.->|"ε
BeginToken 'd'"|eNFA4_0_4957353
eNFA4_2_13149610 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_44616179
eNFA5_2_51237633 -.->|"ε
BeginToken 'c'"|eNFA5_0_44504510
eNFA5_2_51237633 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_64996270
eNFA6_16_58485517 -.->|"ε
BeginToken 'blockComment'"|eNFA6_0_3423268
eNFA6_16_58485517 -->|"/
BeginToken 'blockComment'"|eNFA6_1_11241060
eNFA7_5_56607607 -.->|"ε
BeginToken 'inlineComment'"|eNFA7_0_45706525
eNFA7_5_56607607 -->|"/
BeginToken 'inlineComment'"|eNFA7_1_38110696
eNFA1_0_25375958 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_27057037
eNFA2_0_61683061 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_18276642
eNFA3_0_36117414 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_56621273
eNFA4_0_4957353 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_44616179
eNFA5_0_44504510 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_64996270
eNFA6_0_3423268 -->|"/
BeginToken 'blockComment'"|eNFA6_1_11241060
eNFA7_0_45706525 -->|"/
BeginToken 'inlineComment'"|eNFA7_1_38110696
eNFA1_1_27057037 -.->|"ε
ExtendToken 'a'"|eNFA1_3_42186743
eNFA1_1_27057037 -.->|"ε"|eNFA1_4_44136375
eNFA1_1_27057037 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_40522795
eNFA1_1_27057037 -.->|"ε
CheckToken 'a'"|eNFA0_1_41785235
eNFA2_1_18276642 -.->|"ε
ExtendToken 's'"|eNFA2_3_30272055
eNFA2_1_18276642 -.->|"ε"|eNFA2_4_4013046
eNFA2_1_18276642 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_64295127
eNFA2_1_18276642 -.->|"ε
CheckToken 's'"|eNFA0_1_41785235
eNFA3_1_56621273 -.->|"ε
ExtendToken 'b'"|eNFA3_3_39829417
eNFA3_1_56621273 -.->|"ε"|eNFA3_4_22920438
eNFA3_1_56621273 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_29160842
eNFA3_1_56621273 -.->|"ε
CheckToken 'b'"|eNFA0_1_41785235
eNFA4_1_44616179 -.->|"ε
ExtendToken 'd'"|eNFA4_3_66001293
eNFA4_1_44616179 -.->|"ε"|eNFA4_4_57140728
eNFA4_1_44616179 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_61120992
eNFA4_1_44616179 -.->|"ε
CheckToken 'd'"|eNFA0_1_41785235
eNFA5_1_64996270 -.->|"ε
ExtendToken 'c'"|eNFA5_3_48095523
eNFA5_1_64996270 -.->|"ε"|eNFA5_4_30206524
eNFA5_1_64996270 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_13218022
eNFA5_1_64996270 -.->|"ε
CheckToken 'c'"|eNFA0_1_41785235
eNFA6_1_11241060 -.->|"ε"|eNFA6_2_67067536
eNFA6_1_11241060 -->|"*"|eNFA6_3_39362312
eNFA7_1_38110696 -.->|"ε"|eNFA7_2_7451948
eNFA7_1_38110696 -->|"/
ExtendToken 'inlineComment'"|eNFA7_3_46082022
eNFA1_3_42186743 -.->|"ε"|eNFA1_4_44136375
eNFA1_3_42186743 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_40522795
eNFA1_3_42186743 -.->|"ε
CheckToken 'a'"|eNFA0_1_41785235
eNFA1_4_44136375 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_40522795
eNFA1_4_44136375 -.->|"ε
CheckToken 'a'"|eNFA0_1_41785235
eNFA1_5_40522795 -.->|"ε
CheckToken 'a'"|eNFA0_1_41785235
eNFA2_3_30272055 -.->|"ε"|eNFA2_4_4013046
eNFA2_3_30272055 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_64295127
eNFA2_3_30272055 -.->|"ε
CheckToken 's'"|eNFA0_1_41785235
eNFA2_4_4013046 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_64295127
eNFA2_4_4013046 -.->|"ε
CheckToken 's'"|eNFA0_1_41785235
eNFA2_5_64295127 -.->|"ε
CheckToken 's'"|eNFA0_1_41785235
eNFA3_3_39829417 -.->|"ε"|eNFA3_4_22920438
eNFA3_3_39829417 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_29160842
eNFA3_3_39829417 -.->|"ε
CheckToken 'b'"|eNFA0_1_41785235
eNFA3_4_22920438 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_29160842
eNFA3_4_22920438 -.->|"ε
CheckToken 'b'"|eNFA0_1_41785235
eNFA3_5_29160842 -.->|"ε
CheckToken 'b'"|eNFA0_1_41785235
eNFA4_3_66001293 -.->|"ε"|eNFA4_4_57140728
eNFA4_3_66001293 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_61120992
eNFA4_3_66001293 -.->|"ε
CheckToken 'd'"|eNFA0_1_41785235
eNFA4_4_57140728 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_61120992
eNFA4_4_57140728 -.->|"ε
CheckToken 'd'"|eNFA0_1_41785235
eNFA4_5_61120992 -.->|"ε
CheckToken 'd'"|eNFA0_1_41785235
eNFA5_3_48095523 -.->|"ε"|eNFA5_4_30206524
eNFA5_3_48095523 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_13218022
eNFA5_3_48095523 -.->|"ε
CheckToken 'c'"|eNFA0_1_41785235
eNFA5_4_30206524 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_13218022
eNFA5_4_30206524 -.->|"ε
CheckToken 'c'"|eNFA0_1_41785235
eNFA5_5_13218022 -.->|"ε
CheckToken 'c'"|eNFA0_1_41785235
eNFA6_2_67067536 -->|"*"|eNFA6_3_39362312
eNFA6_3_39362312 -.->|"ε"|eNFA6_6_51853342
eNFA6_3_39362312 -.->|"ε"|eNFA6_4_39371148
eNFA6_3_39362312 -.->|"ε"|eNFA6_8_64026895
eNFA6_3_39362312 -.->|"ε"|eNFA6_7_18796012
eNFA6_3_39362312 -->|"[^*]"|eNFA6_5_34230728
eNFA6_3_39362312 -->|"[*]"|eNFA6_9_66736917
eNFA6_3_39362312 -.->|"ε"|eNFA6_12_18716495
eNFA6_3_39362312 -->|"*"|eNFA6_13_36981231
eNFA7_2_7451948 -->|"/
ExtendToken 'inlineComment'"|eNFA7_3_46082022
eNFA7_3_46082022 -.->|"ε
ExtendToken 'inlineComment'"|eNFA7_4_34946386
eNFA7_3_46082022 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA7_4_34946386
eNFA7_3_46082022 -.->|"ε
ExtendToken 'inlineComment'"|eNFA7_6_12085017
eNFA7_3_46082022 -.->|"ε"|eNFA7_7_8705547
eNFA7_3_46082022 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA7_8_41552090
eNFA7_3_46082022 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_41785235
eNFA6_6_51853342 -.->|"ε"|eNFA6_4_39371148
eNFA6_6_51853342 -.->|"ε"|eNFA6_8_64026895
eNFA6_6_51853342 -.->|"ε"|eNFA6_7_18796012
eNFA6_6_51853342 -->|"[^*]"|eNFA6_5_34230728
eNFA6_6_51853342 -->|"[*]"|eNFA6_9_66736917
eNFA6_6_51853342 -.->|"ε"|eNFA6_6_51853342
eNFA6_6_51853342 -.->|"ε"|eNFA6_12_18716495
eNFA6_6_51853342 -->|"*"|eNFA6_13_36981231
eNFA6_4_39371148 -->|"[^*]"|eNFA6_5_34230728
eNFA6_8_64026895 -->|"[*]"|eNFA6_9_66736917
eNFA6_7_18796012 -.->|"ε"|eNFA6_6_51853342
eNFA6_7_18796012 -.->|"ε"|eNFA6_12_18716495
eNFA6_7_18796012 -.->|"ε"|eNFA6_4_39371148
eNFA6_7_18796012 -.->|"ε"|eNFA6_8_64026895
eNFA6_7_18796012 -.->|"ε"|eNFA6_7_18796012
eNFA6_7_18796012 -->|"[^*]"|eNFA6_5_34230728
eNFA6_7_18796012 -->|"[*]"|eNFA6_9_66736917
eNFA6_7_18796012 -->|"*"|eNFA6_13_36981231
eNFA6_5_34230728 -.->|"ε"|eNFA6_7_18796012
eNFA6_5_34230728 -.->|"ε"|eNFA6_6_51853342
eNFA6_5_34230728 -.->|"ε"|eNFA6_12_18716495
eNFA6_5_34230728 -.->|"ε"|eNFA6_4_39371148
eNFA6_5_34230728 -.->|"ε"|eNFA6_8_64026895
eNFA6_5_34230728 -->|"[^*]"|eNFA6_5_34230728
eNFA6_5_34230728 -->|"[*]"|eNFA6_9_66736917
eNFA6_5_34230728 -->|"*"|eNFA6_13_36981231
eNFA6_9_66736917 -.->|"ε"|eNFA6_10_63761349
eNFA6_9_66736917 -->|"[^/]"|eNFA6_11_38424490
eNFA6_12_18716495 -->|"*"|eNFA6_13_36981231
eNFA6_13_36981231 -.->|"ε"|eNFA6_14_34060683
eNFA6_13_36981231 -->|"/
ExtendToken 'blockComment'"|eNFA6_15_30809419
eNFA7_4_34946386 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA7_4_34946386
eNFA7_4_34946386 -.->|"ε
ExtendToken 'inlineComment'"|eNFA7_6_12085017
eNFA7_4_34946386 -.->|"ε"|eNFA7_7_8705547
eNFA7_4_34946386 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA7_8_41552090
eNFA7_4_34946386 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_41785235
eNFA7_6_12085017 -.->|"ε"|eNFA7_7_8705547
eNFA7_6_12085017 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA7_8_41552090
eNFA7_6_12085017 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_41785235
eNFA7_7_8705547 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA7_8_41552090
eNFA7_7_8705547 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_41785235
eNFA7_8_41552090 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_41785235
eNFA6_10_63761349 -->|"[^/]"|eNFA6_11_38424490
eNFA6_11_38424490 -.->|"ε"|eNFA6_7_18796012
eNFA6_11_38424490 -.->|"ε"|eNFA6_6_51853342
eNFA6_11_38424490 -.->|"ε"|eNFA6_12_18716495
eNFA6_11_38424490 -.->|"ε"|eNFA6_4_39371148
eNFA6_11_38424490 -.->|"ε"|eNFA6_8_64026895
eNFA6_11_38424490 -->|"[^*]"|eNFA6_5_34230728
eNFA6_11_38424490 -->|"[*]"|eNFA6_9_66736917
eNFA6_11_38424490 -->|"*"|eNFA6_13_36981231
eNFA6_14_34060683 -->|"/
ExtendToken 'blockComment'"|eNFA6_15_30809419
eNFA6_15_30809419 -.->|"ε
ExtendToken 'blockComment'"|eNFA6_17_8849323
eNFA6_15_30809419 -.->|"ε"|eNFA6_18_12535043
eNFA6_15_30809419 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA6_19_10276091
eNFA6_15_30809419 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_41785235
eNFA6_17_8849323 -.->|"ε"|eNFA6_18_12535043
eNFA6_17_8849323 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA6_19_10276091
eNFA6_17_8849323 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_41785235
eNFA6_18_12535043 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA6_19_10276091
eNFA6_18_12535043 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_41785235
eNFA6_19_10276091 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_41785235

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
NFA0_0_42689762("NFA0-0 wholeStart")
class NFA0_0_42689762 c1000;
NFA1_1_64395630[\"NFA1-1 char[1]
AcceptToken 'a'"/]
class NFA1_1_64395630 c0101;
NFA2_1_48663540[\"NFA2-1 char[1]
AcceptToken 's'"/]
class NFA2_1_48663540 c0101;
NFA3_1_35318677[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_35318677 c0101;
NFA4_1_49432638[\"NFA4-1 char[1]
AcceptToken 'd'"/]
class NFA4_1_49432638 c0101;
NFA5_1_42240560[\"NFA5-1 char[1]
AcceptToken 'c'"/]
class NFA5_1_42240560 c0101;
NFA6_1_44620724("NFA6-1 char[1]")
NFA7_1_66042204("NFA7-1 char[1]")
NFA6_3_47818304("NFA6-3 char[1]")
NFA7_3_57508928[\"NFA7-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA7_3_57508928 c0101;
NFA6_5_48077445("NFA6-5 scope[1]")
NFA6_9_27711559("NFA6-9 scope[1]")
NFA6_13_30043827("NFA6-13 char[1]")
NFA7_4_1958995[\"NFA7-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA7_4_1958995 c0101;
NFA6_11_24460881("NFA6-11 scope[1]")
NFA6_15_17630956[\"NFA6-15 char[1]
AcceptToken 'blockComment'"/]
class NFA6_15_17630956 c0101;
NFA0_0_42689762 -->|"a
BeginToken 'a'
ExtendToken 'a'"|NFA1_1_64395630
NFA0_0_42689762 -->|"s
BeginToken 's'
ExtendToken 's'"|NFA2_1_48663540
NFA0_0_42689762 -->|"b
BeginToken 'b'
ExtendToken 'b'"|NFA3_1_35318677
NFA0_0_42689762 -->|"d
BeginToken 'd'
ExtendToken 'd'"|NFA4_1_49432638
NFA0_0_42689762 -->|"c
BeginToken 'c'
ExtendToken 'c'"|NFA5_1_42240560
NFA0_0_42689762 -->|"/
BeginToken 'blockComment'"|NFA6_1_44620724
NFA0_0_42689762 -->|"/
BeginToken 'inlineComment'"|NFA7_1_66042204
NFA6_1_44620724 -->|"*"|NFA6_3_47818304
NFA7_1_66042204 -->|"/
ExtendToken 'inlineComment'"|NFA7_3_57508928
NFA6_3_47818304 -->|"[^*]"|NFA6_5_48077445
NFA6_3_47818304 -->|"[*]"|NFA6_9_27711559
NFA6_3_47818304 -->|"*"|NFA6_13_30043827
NFA7_3_57508928 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA7_4_1958995
NFA6_5_48077445 -->|"[^*]"|NFA6_5_48077445
NFA6_5_48077445 -->|"[*]"|NFA6_9_27711559
NFA6_5_48077445 -->|"*"|NFA6_13_30043827
NFA6_9_27711559 -->|"[^/]"|NFA6_11_24460881
NFA6_13_30043827 -->|"/
ExtendToken 'blockComment'"|NFA6_15_17630956
NFA7_4_1958995 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA7_4_1958995
NFA6_11_24460881 -->|"[^*]"|NFA6_5_48077445
NFA6_11_24460881 -->|"[*]"|NFA6_9_27711559
NFA6_11_24460881 -->|"*"|NFA6_13_30043827

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
subgraph DFA0_-2011742570["DFA0 wholeStart"]
NFA0_0_42689762_0("NFA0-0 wholeStart")
class NFA0_0_42689762_0 c1000;
end
class DFA0_-2011742570 c1000;
subgraph DFA1_965118415["DFA1 {1}"]
NFA1_1_64395630_1[\"NFA1-1 char[1]
AcceptToken 'a'"/]
class NFA1_1_64395630_1 c0101;
end
class DFA1_965118415 c0101;
subgraph DFA2_-1841752797["DFA2 {1}"]
NFA2_1_48663540_2[\"NFA2-1 char[1]
AcceptToken 's'"/]
class NFA2_1_48663540_2 c0101;
end
class DFA2_-1841752797 c0101;
subgraph DFA3_1913146111["DFA3 {1}"]
NFA3_1_35318677_3[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_35318677_3 c0101;
end
class DFA3_1913146111 c0101;
subgraph DFA4_1623093623["DFA4 {1}"]
NFA4_1_49432638_4[\"NFA4-1 char[1]
AcceptToken 'd'"/]
class NFA4_1_49432638_4 c0101;
end
class DFA4_1623093623 c0101;
subgraph DFA5_1525692439["DFA5 {1}"]
NFA5_1_42240560_5[\"NFA5-1 char[1]
AcceptToken 'c'"/]
class NFA5_1_42240560_5 c0101;
end
class DFA5_1525692439 c0101;
subgraph DFA6_1862687141["DFA6 {2}"]
NFA6_1_44620724_6("NFA6-1 char[1]")
NFA7_1_66042204_7("NFA7-1 char[1]")
end
subgraph DFA7_1742648909["DFA7 {1}"]
NFA6_3_47818304_8("NFA6-3 char[1]")
end
subgraph DFA8_-988443997["DFA8 {1}"]
NFA7_3_57508928_9[\"NFA7-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA7_3_57508928_9 c0101;
end
class DFA8_-988443997 c0101;
subgraph DFA9_-354726560["DFA9 {1}"]
NFA6_5_48077445_10("NFA6-5 scope[1]")
end
subgraph DFA10_323920158["DFA10 {2}"]
NFA6_9_27711559_11("NFA6-9 scope[1]")
NFA6_13_30043827_12("NFA6-13 char[1]")
end
subgraph DFA11_-378200846["DFA11 {1}"]
NFA7_4_1958995_13[\"NFA7-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA7_4_1958995_13 c0101;
end
class DFA11_-378200846 c0101;
subgraph DFA12_-1735644823["DFA12 {1}"]
NFA6_11_24460881_14("NFA6-11 scope[1]")
end
subgraph DFA13_1233218362["DFA13 {1}"]
NFA6_15_17630956_15[\"NFA6-15 char[1]
AcceptToken 'blockComment'"/]
class NFA6_15_17630956_15 c0101;
end
class DFA13_1233218362 c0101;
DFA0_-2011742570 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA1_965118415
DFA0_-2011742570 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA2_-1841752797
DFA0_-2011742570 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_1913146111
DFA0_-2011742570 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA4_1623093623
DFA0_-2011742570 -->|"c
BeginToken 'c'
ExtendToken 'c'"|DFA5_1525692439
DFA0_-2011742570 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA6_1862687141
DFA6_1862687141 -->|"*"|DFA7_1742648909
DFA6_1862687141 -->|"/
ExtendToken 'inlineComment'"|DFA8_-988443997
DFA7_1742648909 -->|"[^*]"|DFA9_-354726560
DFA7_1742648909 -->|"*"|DFA10_323920158
DFA8_-988443997 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA11_-378200846
DFA9_-354726560 -->|"[^*]"|DFA9_-354726560
DFA9_-354726560 -->|"*"|DFA10_323920158
DFA10_323920158 -->|"[^/]"|DFA12_-1735644823
DFA10_323920158 -->|"/
ExtendToken 'blockComment'"|DFA13_1233218362
DFA11_-378200846 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA11_-378200846
DFA12_-1735644823 -->|"[^*]"|DFA9_-354726560
DFA12_-1735644823 -->|"*"|DFA10_323920158

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
DFA0_-2011742570{{"DFA0 wholeStart"}}
class DFA0_-2011742570 c1000;
DFA1_965118415[\"DFA1 {1}
AcceptToken 'a'"/]
class DFA1_965118415 c0101;
DFA2_-1841752797[\"DFA2 {1}
AcceptToken 's'"/]
class DFA2_-1841752797 c0101;
DFA3_1913146111[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_1913146111 c0101;
DFA4_1623093623[\"DFA4 {1}
AcceptToken 'd'"/]
class DFA4_1623093623 c0101;
DFA5_1525692439[\"DFA5 {1}
AcceptToken 'c'"/]
class DFA5_1525692439 c0101;
DFA6_1862687141{{"DFA6 {2}"}}
DFA7_1742648909{{"DFA7 {1}"}}
DFA8_-988443997[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_-988443997 c0101;
DFA9_-354726560{{"DFA9 {1}"}}
DFA10_323920158{{"DFA10 {2}"}}
DFA11_-378200846[\"DFA11 {1}
AcceptToken 'inlineComment'"/]
class DFA11_-378200846 c0101;
DFA12_-1735644823{{"DFA12 {1}"}}
DFA13_1233218362[\"DFA13 {1}
AcceptToken 'blockComment'"/]
class DFA13_1233218362 c0101;
DFA0_-2011742570 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA1_965118415
DFA0_-2011742570 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA2_-1841752797
DFA0_-2011742570 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_1913146111
DFA0_-2011742570 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA4_1623093623
DFA0_-2011742570 -->|"c
BeginToken 'c'
ExtendToken 'c'"|DFA5_1525692439
DFA0_-2011742570 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA6_1862687141
DFA6_1862687141 -->|"*"|DFA7_1742648909
DFA6_1862687141 -->|"/
ExtendToken 'inlineComment'"|DFA8_-988443997
DFA7_1742648909 -->|"[^*]"|DFA9_-354726560
DFA7_1742648909 -->|"*"|DFA10_323920158
DFA8_-988443997 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA11_-378200846
DFA9_-354726560 -->|"[^*]"|DFA9_-354726560
DFA9_-354726560 -->|"*"|DFA10_323920158
DFA10_323920158 -->|"[^/]"|DFA12_-1735644823
DFA10_323920158 -->|"/
ExtendToken 'blockComment'"|DFA13_1233218362
DFA11_-378200846 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA11_-378200846
DFA12_-1735644823 -->|"[^*]"|DFA9_-354726560
DFA12_-1735644823 -->|"*"|DFA10_323920158

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
subgraph MiniDFA0_266130706["MiniDFA0 {1}"]
DFA0_-2011742570_0{{"DFA0 wholeStart"}}
class DFA0_-2011742570_0 c1000;
end
class MiniDFA0_266130706 c1000;
subgraph MiniDFA4_1173141555["MiniDFA4 {1}"]
DFA1_965118415_1[\"DFA1 {1}
AcceptToken 'a'"/]
class DFA1_965118415_1 c0101;
end
class MiniDFA4_1173141555 c0101;
subgraph MiniDFA5_1460028246["MiniDFA5 {1}"]
DFA2_-1841752797_2[\"DFA2 {1}
AcceptToken 's'"/]
class DFA2_-1841752797_2 c0101;
end
class MiniDFA5_1460028246 c0101;
subgraph MiniDFA6_-2120954286["MiniDFA6 {1}"]
DFA3_1913146111_3[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_1913146111_3 c0101;
end
class MiniDFA6_-2120954286 c0101;
subgraph MiniDFA7_-329204845["MiniDFA7 {1}"]
DFA4_1623093623_4[\"DFA4 {1}
AcceptToken 'd'"/]
class DFA4_1623093623_4 c0101;
end
class MiniDFA7_-329204845 c0101;
subgraph MiniDFA8_2134578056["MiniDFA8 {1}"]
DFA5_1525692439_5[\"DFA5 {1}
AcceptToken 'c'"/]
class DFA5_1525692439_5 c0101;
end
class MiniDFA8_2134578056 c0101;
subgraph MiniDFA1_1733509379["MiniDFA1 {1}"]
DFA6_1862687141_6{{"DFA6 {2}"}}
end
subgraph MiniDFA2_-340209735["MiniDFA2 {3}"]
DFA7_1742648909_7{{"DFA7 {1}"}}
DFA9_-354726560_8{{"DFA9 {1}"}}
DFA12_-1735644823_9{{"DFA12 {1}"}}
end
subgraph MiniDFA9_52617251["MiniDFA9 {1}"]
DFA8_-988443997_10[\"DFA8 {1}
AcceptToken 'inlineComment'"/]
class DFA8_-988443997_10 c0101;
end
class MiniDFA9_52617251 c0101;
subgraph MiniDFA3_736710712["MiniDFA3 {1}"]
DFA10_323920158_11{{"DFA10 {2}"}}
end
subgraph MiniDFA10_1666738974["MiniDFA10 {1}"]
DFA11_-378200846_12[\"DFA11 {1}
AcceptToken 'inlineComment'"/]
class DFA11_-378200846_12 c0101;
end
class MiniDFA10_1666738974 c0101;
subgraph MiniDFA11_821581297["MiniDFA11 {1}"]
DFA13_1233218362_13[\"DFA13 {1}
AcceptToken 'blockComment'"/]
class DFA13_1233218362_13 c0101;
end
class MiniDFA11_821581297 c0101;
MiniDFA0_266130706 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA4_1173141555
MiniDFA0_266130706 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA5_1460028246
MiniDFA0_266130706 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA6_-2120954286
MiniDFA0_266130706 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA7_-329204845
MiniDFA0_266130706 -->|"c
BeginToken 'c'
ExtendToken 'c'"|MiniDFA8_2134578056
MiniDFA0_266130706 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_1733509379
MiniDFA1_1733509379 -->|"*"|MiniDFA2_-340209735
MiniDFA1_1733509379 -->|"/
ExtendToken 'inlineComment'"|MiniDFA9_52617251
MiniDFA2_-340209735 -->|"[^*]"|MiniDFA2_-340209735
MiniDFA2_-340209735 -->|"*"|MiniDFA3_736710712
MiniDFA9_52617251 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA10_1666738974
MiniDFA3_736710712 -->|"[^/]"|MiniDFA2_-340209735
MiniDFA3_736710712 -->|"/
ExtendToken 'blockComment'"|MiniDFA11_821581297
MiniDFA10_1666738974 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA10_1666738974

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
MiniDFA0_266130706(["MiniDFA0 {1}"])
class MiniDFA0_266130706 c1000;
MiniDFA4_1173141555[\"MiniDFA4 {1}
AcceptToken 'a'"/]
class MiniDFA4_1173141555 c0101;
MiniDFA5_1460028246[\"MiniDFA5 {1}
AcceptToken 's'"/]
class MiniDFA5_1460028246 c0101;
MiniDFA6_-2120954286[\"MiniDFA6 {1}
AcceptToken 'b'"/]
class MiniDFA6_-2120954286 c0101;
MiniDFA7_-329204845[\"MiniDFA7 {1}
AcceptToken 'd'"/]
class MiniDFA7_-329204845 c0101;
MiniDFA8_2134578056[\"MiniDFA8 {1}
AcceptToken 'c'"/]
class MiniDFA8_2134578056 c0101;
MiniDFA1_1733509379(["MiniDFA1 {1}"])
MiniDFA2_-340209735(["MiniDFA2 {3}"])
MiniDFA9_52617251[\"MiniDFA9 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA9_52617251 c0101;
MiniDFA3_736710712(["MiniDFA3 {1}"])
MiniDFA10_1666738974[\"MiniDFA10 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA10_1666738974 c0101;
MiniDFA11_821581297[\"MiniDFA11 {1}
AcceptToken 'blockComment'"/]
class MiniDFA11_821581297 c0101;
MiniDFA0_266130706 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA4_1173141555
MiniDFA0_266130706 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA5_1460028246
MiniDFA0_266130706 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA6_-2120954286
MiniDFA0_266130706 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA7_-329204845
MiniDFA0_266130706 -->|"c
BeginToken 'c'
ExtendToken 'c'"|MiniDFA8_2134578056
MiniDFA0_266130706 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_1733509379
MiniDFA1_1733509379 -->|"*"|MiniDFA2_-340209735
MiniDFA1_1733509379 -->|"/
ExtendToken 'inlineComment'"|MiniDFA9_52617251
MiniDFA2_-340209735 -->|"[^*]"|MiniDFA2_-340209735
MiniDFA2_-340209735 -->|"*"|MiniDFA3_736710712
MiniDFA9_52617251 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA10_1666738974
MiniDFA3_736710712 -->|"[^/]"|MiniDFA2_-340209735
MiniDFA3_736710712 -->|"/
ExtendToken 'blockComment'"|MiniDFA11_821581297
MiniDFA10_1666738974 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA10_1666738974

```

# 总结

无。

