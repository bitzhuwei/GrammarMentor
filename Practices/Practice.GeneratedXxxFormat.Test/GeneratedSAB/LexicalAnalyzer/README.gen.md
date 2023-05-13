# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `SAB`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（6个State）。

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
eNFA0_2_64940127[["εNFA0-2 regex start"]]
eNFA0_0_47590235[["εNFA0-0 char{1, 1}"]]
eNFA0_1_25658939[["εNFA0-1 char[1]"]]
eNFA0_3_29603863[["εNFA0-3 regex end"]]
eNFA0_2_64940127 -.->|"ε"|eNFA0_0_47590235
eNFA0_0_47590235 -->|"a"|eNFA0_1_25658939
eNFA0_1_25658939 -.->|"ε"|eNFA0_3_29603863
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
eNFA0_4_65108175[["εNFA0-4 post-regex start"]]
eNFA0_5_49102670[\"εNFA0-5 post-regex end"/]
eNFA0_4_65108175 -.->|"ε"|eNFA0_5_49102670
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
eNFA0_2_6623013[["εNFA0-2 regex start"]]
eNFA0_0_59607118[["εNFA0-0 char{1, 1}"]]
eNFA0_1_66702014[["εNFA0-1 char[1]"]]
eNFA0_3_63447214[["εNFA0-3 regex end"]]
eNFA0_2_6623013 -.->|"ε"|eNFA0_0_59607118
eNFA0_0_59607118 -->|"s"|eNFA0_1_66702014
eNFA0_1_66702014 -.->|"ε"|eNFA0_3_63447214
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
eNFA0_4_34154015[["εNFA0-4 post-regex start"]]
eNFA0_5_38950682[\"εNFA0-5 post-regex end"/]
eNFA0_4_34154015 -.->|"ε"|eNFA0_5_38950682
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
eNFA0_2_47155484[["εNFA0-2 regex start"]]
eNFA0_0_21746178[["εNFA0-0 char{1, 1}"]]
eNFA0_1_61497874[["εNFA0-1 char[1]"]]
eNFA0_3_16609959[["εNFA0-3 regex end"]]
eNFA0_2_47155484 -.->|"ε"|eNFA0_0_21746178
eNFA0_0_21746178 -->|"b"|eNFA0_1_61497874
eNFA0_1_61497874 -.->|"ε"|eNFA0_3_16609959
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
eNFA0_4_15271904[["εNFA0-4 post-regex start"]]
eNFA0_5_3229416[\"εNFA0-5 post-regex end"/]
eNFA0_4_15271904 -.->|"ε"|eNFA0_5_3229416
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
eNFA0_2_1838214[["εNFA0-2 regex start"]]
eNFA0_0_16543928[["εNFA0-0 char{1, 1}"]]
eNFA0_1_14677625[["εNFA0-1 char[1]"]]
eNFA0_3_64989762[["εNFA0-3 regex end"]]
eNFA0_2_1838214 -.->|"ε"|eNFA0_0_16543928
eNFA0_0_16543928 -->|"d"|eNFA0_1_14677625
eNFA0_1_14677625 -.->|"ε"|eNFA0_3_64989762
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
eNFA0_4_48036948[["εNFA0-4 post-regex start"]]
eNFA0_5_29679352[\"εNFA0-5 post-regex end"/]
eNFA0_4_48036948 -.->|"ε"|eNFA0_5_29679352
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
eNFA0_2_65607585[["εNFA0-2 regex start"]]
eNFA0_0_53597360[["εNFA0-0 char{1, 1}"]]
eNFA0_1_12614193[["εNFA0-1 char[1]"]]
eNFA0_3_46418879[["εNFA0-3 regex end"]]
eNFA0_2_65607585 -.->|"ε"|eNFA0_0_53597360
eNFA0_0_53597360 -->|"c"|eNFA0_1_12614193
eNFA0_1_12614193 -.->|"ε"|eNFA0_3_46418879
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
eNFA0_4_15116730[["εNFA0-4 post-regex start"]]
eNFA0_5_1832843[\"εNFA0-5 post-regex end"/]
eNFA0_4_15116730 -.->|"ε"|eNFA0_5_1832843
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
eNFA0_0_11401175[["εNFA0-0 wholeStart"]]
eNFA1_2_30339247[["εNFA1-2 regex start"]]
class eNFA1_2_30339247 c1000;
eNFA2_2_35501716[["εNFA2-2 regex start"]]
class eNFA2_2_35501716 c1000;
eNFA3_2_62817140[["εNFA3-2 regex start"]]
class eNFA3_2_62817140 c1000;
eNFA4_2_30975470[["εNFA4-2 regex start"]]
class eNFA4_2_30975470 c1000;
eNFA5_2_32230622[["εNFA5-2 regex start"]]
class eNFA5_2_32230622 c1000;
eNFA1_0_4617770[["εNFA1-0 char{1, 1}"]]
eNFA2_0_43838484[["εNFA2-0 char{1, 1}"]]
eNFA3_0_55023556[["εNFA3-0 char{1, 1}"]]
eNFA4_0_25985176[["εNFA4-0 char{1, 1}"]]
eNFA5_0_60543561[["εNFA5-0 char{1, 1}"]]
eNFA1_1_41559932[["εNFA1-1 char[1]"]]
eNFA2_1_59002044[["εNFA2-1 char[1]"]]
eNFA3_1_25449961[["εNFA3-1 char[1]"]]
eNFA4_1_32539999[["εNFA4-1 char[1]"]]
eNFA5_1_8021141[["εNFA5-1 char[1]"]]
eNFA1_3_38495070[["εNFA1-3 regex end"]]
class eNFA1_3_38495070 c0100;
eNFA2_3_61256348[["εNFA2-3 regex end"]]
class eNFA2_3_61256348 c0100;
eNFA3_3_27723061[["εNFA3-3 regex end"]]
class eNFA3_3_27723061 c0100;
eNFA4_3_24424539[["εNFA4-3 regex end"]]
class eNFA4_3_24424539 c0100;
eNFA5_3_5081413[["εNFA5-3 regex end"]]
class eNFA5_3_5081413 c0100;
eNFA1_4_10911313[["εNFA1-4 post-regex start"]]
class eNFA1_4_10911313 c0010;
eNFA2_4_14436222[["εNFA2-4 post-regex start"]]
class eNFA2_4_14436222 c0010;
eNFA3_4_48180961[["εNFA3-4 post-regex start"]]
class eNFA3_4_48180961 c0010;
eNFA4_4_18494261[["εNFA4-4 post-regex start"]]
class eNFA4_4_18494261 c0010;
eNFA5_4_45732721[["εNFA5-4 post-regex start"]]
class eNFA5_4_45732721 c0010;
eNFA1_5_31092959[\"εNFA1-5 post-regex end"/]
class eNFA1_5_31092959 c0001;
eNFA2_5_51079989[\"εNFA2-5 post-regex end"/]
class eNFA2_5_51079989 c0001;
eNFA3_5_28483349[\"εNFA3-5 post-regex end"/]
class eNFA3_5_28483349 c0001;
eNFA4_5_10343782[\"εNFA4-5 post-regex end"/]
class eNFA4_5_10343782 c0001;
eNFA5_5_21640143[\"εNFA5-5 post-regex end"/]
class eNFA5_5_21640143 c0001;
eNFA0_1_57066725[\"εNFA0-1 wholeEnd"/]
eNFA0_0_11401175 -.->|"ε"|eNFA1_2_30339247
eNFA0_0_11401175 -.->|"ε"|eNFA2_2_35501716
eNFA0_0_11401175 -.->|"ε"|eNFA3_2_62817140
eNFA0_0_11401175 -.->|"ε"|eNFA4_2_30975470
eNFA0_0_11401175 -.->|"ε"|eNFA5_2_32230622
eNFA1_2_30339247 -.->|"ε
BeginToken 'a'"|eNFA1_0_4617770
eNFA2_2_35501716 -.->|"ε
BeginToken 's'"|eNFA2_0_43838484
eNFA3_2_62817140 -.->|"ε
BeginToken 'b'"|eNFA3_0_55023556
eNFA4_2_30975470 -.->|"ε
BeginToken 'd'"|eNFA4_0_25985176
eNFA5_2_32230622 -.->|"ε
BeginToken 'c'"|eNFA5_0_60543561
eNFA1_0_4617770 -->|"a"|eNFA1_1_41559932
eNFA2_0_43838484 -->|"s"|eNFA2_1_59002044
eNFA3_0_55023556 -->|"b"|eNFA3_1_25449961
eNFA4_0_25985176 -->|"d"|eNFA4_1_32539999
eNFA5_0_60543561 -->|"c"|eNFA5_1_8021141
eNFA1_1_41559932 -.->|"ε
ExtendToken 'a'"|eNFA1_3_38495070
eNFA2_1_59002044 -.->|"ε
ExtendToken 's'"|eNFA2_3_61256348
eNFA3_1_25449961 -.->|"ε
ExtendToken 'b'"|eNFA3_3_27723061
eNFA4_1_32539999 -.->|"ε
ExtendToken 'd'"|eNFA4_3_24424539
eNFA5_1_8021141 -.->|"ε
ExtendToken 'c'"|eNFA5_3_5081413
eNFA1_3_38495070 -.->|"ε"|eNFA1_4_10911313
eNFA2_3_61256348 -.->|"ε"|eNFA2_4_14436222
eNFA3_3_27723061 -.->|"ε"|eNFA3_4_48180961
eNFA4_3_24424539 -.->|"ε"|eNFA4_4_18494261
eNFA5_3_5081413 -.->|"ε"|eNFA5_4_45732721
eNFA1_4_10911313 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_31092959
eNFA2_4_14436222 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_51079989
eNFA3_4_48180961 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_28483349
eNFA4_4_18494261 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_10343782
eNFA5_4_45732721 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_21640143
eNFA1_5_31092959 -.->|"ε"|eNFA0_1_57066725
eNFA2_5_51079989 -.->|"ε"|eNFA0_1_57066725
eNFA3_5_28483349 -.->|"ε"|eNFA0_1_57066725
eNFA4_5_10343782 -.->|"ε"|eNFA0_1_57066725
eNFA5_5_21640143 -.->|"ε"|eNFA0_1_57066725

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
eNFA0_0_8941305[["εNFA0-0 wholeStart"]]
class eNFA0_0_8941305 c1000;
eNFA1_2_53157134[["εNFA1-2 regex start"]]
class eNFA1_2_53157134 c1000;
eNFA2_2_13362888[["εNFA2-2 regex start"]]
class eNFA2_2_13362888 c1000;
eNFA3_2_8652164[["εNFA3-2 regex start"]]
class eNFA3_2_8652164 c1000;
eNFA4_2_10760620[["εNFA4-2 regex start"]]
class eNFA4_2_10760620 c1000;
eNFA5_2_29736717[["εNFA5-2 regex start"]]
class eNFA5_2_29736717 c1000;
eNFA1_0_10108438[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_10108438 c1000;
eNFA2_0_17909327[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_17909327 c1000;
eNFA3_0_62583177[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_62583177 c1000;
eNFA4_0_36197125[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_36197125 c1000;
eNFA5_0_58181124[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_58181124 c1000;
eNFA1_1_23867085[\"εNFA1-1 char[1]
AcceptToken 'a'"/]
class eNFA1_1_23867085 c0111;
eNFA2_1_26966216[\"εNFA2-1 char[1]
AcceptToken 's'"/]
class eNFA2_1_26966216 c0111;
eNFA3_1_26377684[\"εNFA3-1 char[1]
AcceptToken 'b'"/]
class eNFA3_1_26377684 c0111;
eNFA4_1_57338675[\"εNFA4-1 char[1]
AcceptToken 'd'"/]
class eNFA4_1_57338675 c0111;
eNFA5_1_53868068[\"εNFA5-1 char[1]
AcceptToken 'c'"/]
class eNFA5_1_53868068 c0111;
eNFA1_3_13477174[\"εNFA1-3 regex end
AcceptToken 'a'"/]
class eNFA1_3_13477174 c0111;
eNFA1_4_54185708[\"εNFA1-4 post-regex start
AcceptToken 'a'"/]
class eNFA1_4_54185708 c0011;
eNFA1_5_1904032[\"εNFA1-5 post-regex end"/]
class eNFA1_5_1904032 c0011;
eNFA0_1_59863882[\"εNFA0-1 wholeEnd"/]
eNFA2_3_41369352[\"εNFA2-3 regex end
AcceptToken 's'"/]
class eNFA2_3_41369352 c0111;
eNFA2_4_36779848[\"εNFA2-4 post-regex start
AcceptToken 's'"/]
class eNFA2_4_36779848 c0011;
eNFA2_5_66303866[\"εNFA2-5 post-regex end"/]
class eNFA2_5_66303866 c0011;
eNFA3_3_36072571[\"εNFA3-3 regex end
AcceptToken 'b'"/]
class eNFA3_3_36072571 c0111;
eNFA3_4_56217685[\"εNFA3-4 post-regex start
AcceptToken 'b'"/]
class eNFA3_4_56217685 c0011;
eNFA3_5_17136292[\"εNFA3-5 post-regex end"/]
class eNFA3_5_17136292 c0011;
eNFA4_3_46286032[\"εNFA4-3 regex end
AcceptToken 'd'"/]
class eNFA4_3_46286032 c0111;
eNFA4_4_13921109[\"εNFA4-4 post-regex start
AcceptToken 'd'"/]
class eNFA4_4_13921109 c0011;
eNFA4_5_20008903[\"εNFA4-5 post-regex end"/]
class eNFA4_5_20008903 c0011;
eNFA5_3_15050567[\"εNFA5-3 regex end
AcceptToken 'c'"/]
class eNFA5_3_15050567 c0111;
eNFA5_4_1237383[\"εNFA5-4 post-regex start
AcceptToken 'c'"/]
class eNFA5_4_1237383 c0011;
eNFA5_5_45862402[\"εNFA5-5 post-regex end"/]
class eNFA5_5_45862402 c0011;
eNFA0_0_8941305 -.->|"ε"|eNFA1_2_53157134
eNFA0_0_8941305 -.->|"ε"|eNFA2_2_13362888
eNFA0_0_8941305 -.->|"ε"|eNFA3_2_8652164
eNFA0_0_8941305 -.->|"ε"|eNFA4_2_10760620
eNFA0_0_8941305 -.->|"ε"|eNFA5_2_29736717
eNFA0_0_8941305 -.->|"ε
BeginToken 'a'"|eNFA1_0_10108438
eNFA0_0_8941305 -.->|"ε
BeginToken 's'"|eNFA2_0_17909327
eNFA0_0_8941305 -.->|"ε
BeginToken 'b'"|eNFA3_0_62583177
eNFA0_0_8941305 -.->|"ε
BeginToken 'd'"|eNFA4_0_36197125
eNFA0_0_8941305 -.->|"ε
BeginToken 'c'"|eNFA5_0_58181124
eNFA0_0_8941305 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_23867085
eNFA0_0_8941305 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_26966216
eNFA0_0_8941305 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_26377684
eNFA0_0_8941305 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_57338675
eNFA0_0_8941305 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_53868068
eNFA1_2_53157134 -.->|"ε
BeginToken 'a'"|eNFA1_0_10108438
eNFA1_2_53157134 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_23867085
eNFA2_2_13362888 -.->|"ε
BeginToken 's'"|eNFA2_0_17909327
eNFA2_2_13362888 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_26966216
eNFA3_2_8652164 -.->|"ε
BeginToken 'b'"|eNFA3_0_62583177
eNFA3_2_8652164 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_26377684
eNFA4_2_10760620 -.->|"ε
BeginToken 'd'"|eNFA4_0_36197125
eNFA4_2_10760620 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_57338675
eNFA5_2_29736717 -.->|"ε
BeginToken 'c'"|eNFA5_0_58181124
eNFA5_2_29736717 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_53868068
eNFA1_0_10108438 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA1_1_23867085
eNFA2_0_17909327 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA2_1_26966216
eNFA3_0_62583177 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_26377684
eNFA4_0_36197125 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA4_1_57338675
eNFA5_0_58181124 -->|"c
BeginToken 'c'
ExtendToken 'c'"|eNFA5_1_53868068
eNFA1_1_23867085 -.->|"ε
ExtendToken 'a'"|eNFA1_3_13477174
eNFA1_1_23867085 -.->|"ε"|eNFA1_4_54185708
eNFA1_1_23867085 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_1904032
eNFA1_1_23867085 -.->|"ε
CheckToken 'a'"|eNFA0_1_59863882
eNFA2_1_26966216 -.->|"ε
ExtendToken 's'"|eNFA2_3_41369352
eNFA2_1_26966216 -.->|"ε"|eNFA2_4_36779848
eNFA2_1_26966216 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_66303866
eNFA2_1_26966216 -.->|"ε
CheckToken 's'"|eNFA0_1_59863882
eNFA3_1_26377684 -.->|"ε
ExtendToken 'b'"|eNFA3_3_36072571
eNFA3_1_26377684 -.->|"ε"|eNFA3_4_56217685
eNFA3_1_26377684 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_17136292
eNFA3_1_26377684 -.->|"ε
CheckToken 'b'"|eNFA0_1_59863882
eNFA4_1_57338675 -.->|"ε
ExtendToken 'd'"|eNFA4_3_46286032
eNFA4_1_57338675 -.->|"ε"|eNFA4_4_13921109
eNFA4_1_57338675 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_20008903
eNFA4_1_57338675 -.->|"ε
CheckToken 'd'"|eNFA0_1_59863882
eNFA5_1_53868068 -.->|"ε
ExtendToken 'c'"|eNFA5_3_15050567
eNFA5_1_53868068 -.->|"ε"|eNFA5_4_1237383
eNFA5_1_53868068 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_45862402
eNFA5_1_53868068 -.->|"ε
CheckToken 'c'"|eNFA0_1_59863882
eNFA1_3_13477174 -.->|"ε"|eNFA1_4_54185708
eNFA1_3_13477174 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_1904032
eNFA1_3_13477174 -.->|"ε
CheckToken 'a'"|eNFA0_1_59863882
eNFA1_4_54185708 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA1_5_1904032
eNFA1_4_54185708 -.->|"ε
CheckToken 'a'"|eNFA0_1_59863882
eNFA1_5_1904032 -.->|"ε
CheckToken 'a'"|eNFA0_1_59863882
eNFA2_3_41369352 -.->|"ε"|eNFA2_4_36779848
eNFA2_3_41369352 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_66303866
eNFA2_3_41369352 -.->|"ε
CheckToken 's'"|eNFA0_1_59863882
eNFA2_4_36779848 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA2_5_66303866
eNFA2_4_36779848 -.->|"ε
CheckToken 's'"|eNFA0_1_59863882
eNFA2_5_66303866 -.->|"ε
CheckToken 's'"|eNFA0_1_59863882
eNFA3_3_36072571 -.->|"ε"|eNFA3_4_56217685
eNFA3_3_36072571 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_17136292
eNFA3_3_36072571 -.->|"ε
CheckToken 'b'"|eNFA0_1_59863882
eNFA3_4_56217685 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_17136292
eNFA3_4_56217685 -.->|"ε
CheckToken 'b'"|eNFA0_1_59863882
eNFA3_5_17136292 -.->|"ε
CheckToken 'b'"|eNFA0_1_59863882
eNFA4_3_46286032 -.->|"ε"|eNFA4_4_13921109
eNFA4_3_46286032 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_20008903
eNFA4_3_46286032 -.->|"ε
CheckToken 'd'"|eNFA0_1_59863882
eNFA4_4_13921109 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA4_5_20008903
eNFA4_4_13921109 -.->|"ε
CheckToken 'd'"|eNFA0_1_59863882
eNFA4_5_20008903 -.->|"ε
CheckToken 'd'"|eNFA0_1_59863882
eNFA5_3_15050567 -.->|"ε"|eNFA5_4_1237383
eNFA5_3_15050567 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_45862402
eNFA5_3_15050567 -.->|"ε
CheckToken 'c'"|eNFA0_1_59863882
eNFA5_4_1237383 -.->|"ε
CheckToken 'c'
AcceptToken 'c'"|eNFA5_5_45862402
eNFA5_4_1237383 -.->|"ε
CheckToken 'c'"|eNFA0_1_59863882
eNFA5_5_45862402 -.->|"ε
CheckToken 'c'"|eNFA0_1_59863882

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
NFA0_0_33119207("NFA0-0 wholeStart")
class NFA0_0_33119207 c1000;
NFA1_1_11136452[\"NFA1-1 char[1]
AcceptToken 'a'"/]
class NFA1_1_11136452 c0101;
NFA2_1_29637409[\"NFA2-1 char[1]
AcceptToken 's'"/]
class NFA2_1_29637409 c0101;
NFA3_1_65410091[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_65410091 c0101;
NFA4_1_51819910[\"NFA4-1 char[1]
AcceptToken 'd'"/]
class NFA4_1_51819910 c0101;
NFA5_1_63726012[\"NFA5-1 char[1]
AcceptToken 'c'"/]
class NFA5_1_63726012 c0101;
NFA0_0_33119207 -->|"a
BeginToken 'a'
ExtendToken 'a'"|NFA1_1_11136452
NFA0_0_33119207 -->|"s
BeginToken 's'
ExtendToken 's'"|NFA2_1_29637409
NFA0_0_33119207 -->|"b
BeginToken 'b'
ExtendToken 'b'"|NFA3_1_65410091
NFA0_0_33119207 -->|"d
BeginToken 'd'
ExtendToken 'd'"|NFA4_1_51819910
NFA0_0_33119207 -->|"c
BeginToken 'c'
ExtendToken 'c'"|NFA5_1_63726012

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
subgraph DFA0_1923463421["DFA0 wholeStart"]
NFA0_0_33119207_0("NFA0-0 wholeStart")
class NFA0_0_33119207_0 c1000;
end
class DFA0_1923463421 c1000;
subgraph DFA1_-694928352["DFA1 {1}"]
NFA1_1_11136452_1[\"NFA1-1 char[1]
AcceptToken 'a'"/]
class NFA1_1_11136452_1 c0101;
end
class DFA1_-694928352 c0101;
subgraph DFA2_1430363654["DFA2 {1}"]
NFA2_1_29637409_2[\"NFA2-1 char[1]
AcceptToken 's'"/]
class NFA2_1_29637409_2 c0101;
end
class DFA2_1430363654 c0101;
subgraph DFA3_-1559980011["DFA3 {1}"]
NFA3_1_65410091_3[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_65410091_3 c0101;
end
class DFA3_-1559980011 c0101;
subgraph DFA4_1206467762["DFA4 {1}"]
NFA4_1_51819910_4[\"NFA4-1 char[1]
AcceptToken 'd'"/]
class NFA4_1_51819910_4 c0101;
end
class DFA4_1206467762 c0101;
subgraph DFA5_-1793880414["DFA5 {1}"]
NFA5_1_63726012_5[\"NFA5-1 char[1]
AcceptToken 'c'"/]
class NFA5_1_63726012_5 c0101;
end
class DFA5_-1793880414 c0101;
DFA0_1923463421 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA1_-694928352
DFA0_1923463421 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA2_1430363654
DFA0_1923463421 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_-1559980011
DFA0_1923463421 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA4_1206467762
DFA0_1923463421 -->|"c
BeginToken 'c'
ExtendToken 'c'"|DFA5_-1793880414

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
DFA0_1923463421{{"DFA0 wholeStart"}}
class DFA0_1923463421 c1000;
DFA1_-694928352[\"DFA1 {1}
AcceptToken 'a'"/]
class DFA1_-694928352 c0101;
DFA2_1430363654[\"DFA2 {1}
AcceptToken 's'"/]
class DFA2_1430363654 c0101;
DFA3_-1559980011[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_-1559980011 c0101;
DFA4_1206467762[\"DFA4 {1}
AcceptToken 'd'"/]
class DFA4_1206467762 c0101;
DFA5_-1793880414[\"DFA5 {1}
AcceptToken 'c'"/]
class DFA5_-1793880414 c0101;
DFA0_1923463421 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA1_-694928352
DFA0_1923463421 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA2_1430363654
DFA0_1923463421 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_-1559980011
DFA0_1923463421 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA4_1206467762
DFA0_1923463421 -->|"c
BeginToken 'c'
ExtendToken 'c'"|DFA5_-1793880414

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
subgraph MiniDFA0_1624780686["MiniDFA0 {1}"]
DFA0_1923463421_0{{"DFA0 wholeStart"}}
class DFA0_1923463421_0 c1000;
end
class MiniDFA0_1624780686 c1000;
subgraph MiniDFA1_-194746031["MiniDFA1 {1}"]
DFA1_-694928352_1[\"DFA1 {1}
AcceptToken 'a'"/]
class DFA1_-694928352_1 c0101;
end
class MiniDFA1_-194746031 c0101;
subgraph MiniDFA2_1371428703["MiniDFA2 {1}"]
DFA2_1430363654_2[\"DFA2 {1}
AcceptToken 's'"/]
class DFA2_1430363654_2 c0101;
end
class MiniDFA2_1371428703 c0101;
subgraph MiniDFA3_-2016048439["MiniDFA3 {1}"]
DFA3_-1559980011_3[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_-1559980011_3 c0101;
end
class MiniDFA3_-2016048439 c0101;
subgraph MiniDFA4_-7959560["MiniDFA4 {1}"]
DFA4_1206467762_4[\"DFA4 {1}
AcceptToken 'd'"/]
class DFA4_1206467762_4 c0101;
end
class MiniDFA4_-7959560 c0101;
subgraph MiniDFA5_1506712241["MiniDFA5 {1}"]
DFA5_-1793880414_5[\"DFA5 {1}
AcceptToken 'c'"/]
class DFA5_-1793880414_5 c0101;
end
class MiniDFA5_1506712241 c0101;
MiniDFA0_1624780686 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA1_-194746031
MiniDFA0_1624780686 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA2_1371428703
MiniDFA0_1624780686 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA3_-2016048439
MiniDFA0_1624780686 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA4_-7959560
MiniDFA0_1624780686 -->|"c
BeginToken 'c'
ExtendToken 'c'"|MiniDFA5_1506712241

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
MiniDFA0_1624780686(["MiniDFA0 {1}"])
class MiniDFA0_1624780686 c1000;
MiniDFA1_-194746031[\"MiniDFA1 {1}
AcceptToken 'a'"/]
class MiniDFA1_-194746031 c0101;
MiniDFA2_1371428703[\"MiniDFA2 {1}
AcceptToken 's'"/]
class MiniDFA2_1371428703 c0101;
MiniDFA3_-2016048439[\"MiniDFA3 {1}
AcceptToken 'b'"/]
class MiniDFA3_-2016048439 c0101;
MiniDFA4_-7959560[\"MiniDFA4 {1}
AcceptToken 'd'"/]
class MiniDFA4_-7959560 c0101;
MiniDFA5_1506712241[\"MiniDFA5 {1}
AcceptToken 'c'"/]
class MiniDFA5_1506712241 c0101;
MiniDFA0_1624780686 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA1_-194746031
MiniDFA0_1624780686 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA2_1371428703
MiniDFA0_1624780686 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA3_-2016048439
MiniDFA0_1624780686 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA4_-7959560
MiniDFA0_1624780686 -->|"c
BeginToken 'c'
ExtendToken 'c'"|MiniDFA5_1506712241

```

# 总结

无。

