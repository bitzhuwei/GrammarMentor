# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `SES`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（7个State）。

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
eNFA0_2_43233365[["εNFA0-2 regex start"]]
eNFA0_0_53555971[["εNFA0-0 char{1, 1}"]]
eNFA0_1_12241696[["εNFA0-1 char[1]"]]
eNFA0_3_43066405[["εNFA0-3 regex end"]]
eNFA0_2_43233365 -.->|"ε"|eNFA0_0_53555971
eNFA0_0_53555971 -->|"s"|eNFA0_1_12241696
eNFA0_1_12241696 -.->|"ε"|eNFA0_3_43066405
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
eNFA0_4_52053332[["εNFA0-4 post-regex start"]]
eNFA0_5_65826804[\"εNFA0-5 post-regex end"/]
eNFA0_4_52053332 -.->|"ε"|eNFA0_5_65826804
```


## 't'
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
eNFA0_2_57262433[["εNFA0-2 regex start"]]
eNFA0_0_45599851[["εNFA0-0 char{1, 1}"]]
eNFA0_1_7745481[["εNFA0-1 char[1]"]]
eNFA0_3_2600466[["εNFA0-3 regex end"]]
eNFA0_2_57262433 -.->|"ε"|eNFA0_0_45599851
eNFA0_0_45599851 -->|"t"|eNFA0_1_7745481
eNFA0_1_7745481 -.->|"ε"|eNFA0_3_2600466
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
eNFA0_4_23404201[["εNFA0-4 post-regex start"]]
eNFA0_5_9311222[\"εNFA0-5 post-regex end"/]
eNFA0_4_23404201 -.->|"ε"|eNFA0_5_9311222
```


## 'g'
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
eNFA0_2_15392350[["εNFA0-2 regex start"]]
eNFA0_0_4313429[["εNFA0-0 char{1, 1}"]]
eNFA0_1_38820867[["εNFA0-1 char[1]"]]
eNFA0_3_13843489[["εNFA0-3 regex end"]]
eNFA0_2_15392350 -.->|"ε"|eNFA0_0_4313429
eNFA0_0_4313429 -->|"g"|eNFA0_1_38820867
eNFA0_1_38820867 -.->|"ε"|eNFA0_3_13843489
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
eNFA0_4_57482545[["εNFA0-4 post-regex start"]]
eNFA0_5_47580858[\"εNFA0-5 post-regex end"/]
eNFA0_4_57482545 -.->|"ε"|eNFA0_5_47580858
```


## 'w'
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
eNFA0_2_60413326[["εNFA0-2 regex start"]]
eNFA0_0_6849025[["εNFA0-0 char{1, 1}"]]
eNFA0_1_61641232[["εNFA0-1 char[1]"]]
eNFA0_3_17900178[["εNFA0-3 regex end"]]
eNFA0_2_60413326 -.->|"ε"|eNFA0_0_6849025
eNFA0_0_6849025 -->|"w"|eNFA0_1_61641232
eNFA0_1_61641232 -.->|"ε"|eNFA0_3_17900178
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
eNFA0_4_26883882[["εNFA0-4 post-regex start"]]
eNFA0_5_40628352[\"εNFA0-5 post-regex end"/]
eNFA0_4_26883882 -.->|"ε"|eNFA0_5_40628352
```


## 'e'
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
eNFA0_2_16596271[["εNFA0-2 regex start"]]
eNFA0_0_15148719[["εNFA0-0 char{1, 1}"]]
eNFA0_1_2120750[["εNFA0-1 char[1]"]]
eNFA0_3_19086758[["εNFA0-3 regex end"]]
eNFA0_2_16596271 -.->|"ε"|eNFA0_0_15148719
eNFA0_0_15148719 -->|"e"|eNFA0_1_2120750
eNFA0_1_2120750 -.->|"ε"|eNFA0_3_19086758
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
eNFA0_4_37563094[["εNFA0-4 post-regex start"]]
eNFA0_5_2523528[\"εNFA0-5 post-regex end"/]
eNFA0_4_37563094 -.->|"ε"|eNFA0_5_2523528
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
eNFA0_2_22573955[["εNFA0-2 regex start"]]
eNFA0_0_1839007[["εNFA0-0 char{1, 1}"]]
eNFA0_1_16551071[["εNFA0-1 char[1]"]]
eNFA0_3_14741915[["εNFA0-3 regex end"]]
eNFA0_2_22573955 -.->|"ε"|eNFA0_0_1839007
eNFA0_0_1839007 -->|"d"|eNFA0_1_16551071
eNFA0_1_16551071 -.->|"ε"|eNFA0_3_14741915
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
eNFA0_4_65568371[["εNFA0-4 post-regex start"]]
eNFA0_5_53244434[\"εNFA0-5 post-regex end"/]
eNFA0_4_65568371 -.->|"ε"|eNFA0_5_53244434
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
eNFA0_0_65115477[["εNFA0-0 wholeStart"]]
eNFA1_2_8691401[["εNFA1-2 regex start"]]
class eNFA1_2_8691401 c1000;
eNFA2_2_49168383[["εNFA2-2 regex start"]]
class eNFA2_2_49168383 c1000;
eNFA3_2_56237217[["εNFA3-2 regex start"]]
class eNFA3_2_56237217 c1000;
eNFA4_2_32091456[["εNFA4-2 regex start"]]
class eNFA4_2_32091456 c1000;
eNFA5_2_4673555[["εNFA5-2 regex start"]]
class eNFA5_2_4673555 c1000;
eNFA6_2_20160467[["εNFA6-2 regex start"]]
class eNFA6_2_20160467 c1000;
eNFA1_0_11113746[["εNFA1-0 char{1, 1}"]]
eNFA2_0_7618538[["εNFA2-0 char{1, 1}"]]
eNFA3_0_58920766[["εNFA3-0 char{1, 1}"]]
eNFA4_0_49271158[["εNFA4-0 char{1, 1}"]]
eNFA5_0_43013707[["εNFA5-0 char{1, 1}"]]
eNFA6_0_22385140[["εNFA6-0 char{1, 1}"]]
eNFA1_1_32914850[["εNFA1-1 char[1]"]]
eNFA2_1_1457983[["εNFA2-1 char[1]"]]
eNFA3_1_60524849[["εNFA3-1 char[1]"]]
eNFA4_1_40787243[["εNFA4-1 char[1]"]]
eNFA5_1_51579045[["εNFA5-1 char[1]"]]
eNFA6_1_139672[["εNFA6-1 char[1]"]]
eNFA1_3_27798194[["εNFA1-3 regex end"]]
class eNFA1_3_27798194 c0100;
eNFA2_3_13121854[["εNFA2-3 regex end"]]
class eNFA2_3_13121854 c0100;
eNFA3_3_7852731[["εNFA3-3 regex end"]]
class eNFA3_3_7852731 c0100;
eNFA4_3_31540868[["εNFA4-3 regex end"]]
class eNFA4_3_31540868 c0100;
eNFA5_3_61558227[["εNFA5-3 regex end"]]
class eNFA5_3_61558227 c0100;
eNFA6_3_1257053[["εNFA6-3 regex end"]]
class eNFA6_3_1257053 c0100;
eNFA1_4_48857155[["εNFA1-4 post-regex start"]]
class eNFA1_4_48857155 c0010;
eNFA2_4_50987822[["εNFA2-4 post-regex start"]]
class eNFA2_4_50987822 c0010;
eNFA3_4_3565717[["εNFA3-4 post-regex start"]]
class eNFA3_4_3565717 c0010;
eNFA4_4_15432364[["εNFA4-4 post-regex start"]]
class eNFA4_4_15432364 c0010;
eNFA5_4_17153132[["εNFA5-4 post-regex start"]]
class eNFA5_4_17153132 c0010;
eNFA6_4_11313485[["εNFA6-4 post-regex start"]]
class eNFA6_4_11313485 c0010;
eNFA1_5_37061214[\"εNFA1-5 post-regex end"/]
class eNFA1_5_37061214 c0001;
eNFA2_5_39862271[\"εNFA2-5 post-regex end"/]
class eNFA2_5_39862271 c0001;
eNFA3_5_36372913[\"εNFA3-5 post-regex end"/]
class eNFA3_5_36372913 c0001;
eNFA4_5_20387654[\"εNFA4-5 post-regex end"/]
class eNFA4_5_20387654 c0001;
eNFA5_5_42062003[\"εNFA5-5 post-regex end"/]
class eNFA5_5_42062003 c0001;
eNFA6_5_47226480[\"εNFA6-5 post-regex end"/]
class eNFA6_5_47226480 c0001;
eNFA0_1_23216125[\"εNFA0-1 wholeEnd"/]
eNFA0_0_65115477 -.->|"ε"|eNFA1_2_8691401
eNFA0_0_65115477 -.->|"ε"|eNFA2_2_49168383
eNFA0_0_65115477 -.->|"ε"|eNFA3_2_56237217
eNFA0_0_65115477 -.->|"ε"|eNFA4_2_32091456
eNFA0_0_65115477 -.->|"ε"|eNFA5_2_4673555
eNFA0_0_65115477 -.->|"ε"|eNFA6_2_20160467
eNFA1_2_8691401 -.->|"ε
BeginToken 's'"|eNFA1_0_11113746
eNFA2_2_49168383 -.->|"ε
BeginToken 't'"|eNFA2_0_7618538
eNFA3_2_56237217 -.->|"ε
BeginToken 'g'"|eNFA3_0_58920766
eNFA4_2_32091456 -.->|"ε
BeginToken 'w'"|eNFA4_0_49271158
eNFA5_2_4673555 -.->|"ε
BeginToken 'e'"|eNFA5_0_43013707
eNFA6_2_20160467 -.->|"ε
BeginToken 'd'"|eNFA6_0_22385140
eNFA1_0_11113746 -->|"s"|eNFA1_1_32914850
eNFA2_0_7618538 -->|"t"|eNFA2_1_1457983
eNFA3_0_58920766 -->|"g"|eNFA3_1_60524849
eNFA4_0_49271158 -->|"w"|eNFA4_1_40787243
eNFA5_0_43013707 -->|"e"|eNFA5_1_51579045
eNFA6_0_22385140 -->|"d"|eNFA6_1_139672
eNFA1_1_32914850 -.->|"ε
ExtendToken 's'"|eNFA1_3_27798194
eNFA2_1_1457983 -.->|"ε
ExtendToken 't'"|eNFA2_3_13121854
eNFA3_1_60524849 -.->|"ε
ExtendToken 'g'"|eNFA3_3_7852731
eNFA4_1_40787243 -.->|"ε
ExtendToken 'w'"|eNFA4_3_31540868
eNFA5_1_51579045 -.->|"ε
ExtendToken 'e'"|eNFA5_3_61558227
eNFA6_1_139672 -.->|"ε
ExtendToken 'd'"|eNFA6_3_1257053
eNFA1_3_27798194 -.->|"ε"|eNFA1_4_48857155
eNFA2_3_13121854 -.->|"ε"|eNFA2_4_50987822
eNFA3_3_7852731 -.->|"ε"|eNFA3_4_3565717
eNFA4_3_31540868 -.->|"ε"|eNFA4_4_15432364
eNFA5_3_61558227 -.->|"ε"|eNFA5_4_17153132
eNFA6_3_1257053 -.->|"ε"|eNFA6_4_11313485
eNFA1_4_48857155 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_37061214
eNFA2_4_50987822 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_39862271
eNFA3_4_3565717 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_36372913
eNFA4_4_15432364 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_20387654
eNFA5_4_17153132 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_42062003
eNFA6_4_11313485 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_47226480
eNFA1_5_37061214 -.->|"ε"|eNFA0_1_23216125
eNFA2_5_39862271 -.->|"ε"|eNFA0_1_23216125
eNFA3_5_36372913 -.->|"ε"|eNFA0_1_23216125
eNFA4_5_20387654 -.->|"ε"|eNFA0_1_23216125
eNFA5_5_42062003 -.->|"ε"|eNFA0_1_23216125
eNFA6_5_47226480 -.->|"ε"|eNFA0_1_23216125

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
eNFA0_0_34712503[["εNFA0-0 wholeStart"]]
class eNFA0_0_34712503 c1000;
eNFA1_2_60249386[["εNFA1-2 regex start"]]
class eNFA1_2_60249386 c1000;
eNFA2_2_43977078[["εNFA2-2 regex start"]]
class eNFA2_2_43977078 c1000;
eNFA3_2_5373564[["εNFA3-2 regex start"]]
class eNFA3_2_5373564 c1000;
eNFA4_2_48362077[["εNFA4-2 regex start"]]
class eNFA4_2_48362077 c1000;
eNFA5_2_32605510[["εNFA5-2 regex start"]]
class eNFA5_2_32605510 c1000;
eNFA6_2_25014136[["εNFA6-2 regex start"]]
class eNFA6_2_25014136 c1000;
eNFA1_0_3134363[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_3134363 c1000;
eNFA2_0_29244399[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_29244399 c1000;
eNFA3_0_8262853[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_8262853 c1000;
eNFA4_0_55730526[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_55730526 c1000;
eNFA5_0_38890744[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_38890744 c1000;
eNFA6_0_14273236[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_14273236 c1000;
eNFA1_1_28209268[\"εNFA1-1 char[1]
AcceptToken 's'"/]
class eNFA1_1_28209268 c0111;
eNFA2_1_61873003[\"εNFA2-1 char[1]
AcceptToken 't'"/]
class eNFA2_1_61873003 c0111;
eNFA3_1_7256820[\"εNFA3-1 char[1]
AcceptToken 'g'"/]
class eNFA3_1_7256820 c0111;
eNFA4_1_31812687[\"εNFA4-1 char[1]
AcceptToken 'w'"/]
class eNFA4_1_31812687 c0111;
eNFA5_1_14472379[\"εNFA5-1 char[1]
AcceptToken 'e'"/]
class eNFA5_1_14472379 c0111;
eNFA6_1_61350266[\"εNFA6-1 char[1]
AcceptToken 'd'"/]
class eNFA6_1_61350266 c0111;
eNFA1_3_52556825[\"εNFA1-3 regex end
AcceptToken 's'"/]
class eNFA1_3_52556825 c0111;
eNFA1_4_3249377[\"εNFA1-4 post-regex start
AcceptToken 's'"/]
class eNFA1_4_3249377 c0011;
eNFA1_5_48803400[\"εNFA1-5 post-regex end"/]
class eNFA1_5_48803400 c0011;
eNFA0_1_12879140[\"εNFA0-1 wholeEnd"/]
eNFA2_3_19986118[\"εNFA2-3 regex end
AcceptToken 't'"/]
class eNFA2_3_19986118 c0111;
eNFA2_4_45657337[\"εNFA2-4 post-regex start
AcceptToken 't'"/]
class eNFA2_4_45657337 c0011;
eNFA2_5_23800636[\"εNFA2-5 post-regex end"/]
class eNFA2_5_23800636 c0011;
eNFA3_3_65311381[\"εNFA3-3 regex end
AcceptToken 'g'"/]
class eNFA3_3_65311381 c0111;
eNFA3_4_50931523[\"εNFA3-4 post-regex start
AcceptToken 'g'"/]
class eNFA3_4_50931523 c0011;
eNFA3_5_36577416[\"εNFA3-5 post-regex end"/]
class eNFA3_5_36577416 c0011;
eNFA4_3_17878727[\"εNFA4-3 regex end
AcceptToken 'w'"/]
class eNFA4_3_17878727 c0111;
eNFA4_4_26690815[\"εNFA4-4 post-regex start
AcceptToken 'w'"/]
class eNFA4_4_26690815 c0011;
eNFA4_5_60761295[\"εNFA4-5 post-regex end"/]
class eNFA4_5_60761295 c0011;
eNFA5_3_63142554[\"εNFA5-3 regex end
AcceptToken 'e'"/]
class eNFA5_3_63142554 c0111;
eNFA5_4_31412076[\"εNFA5-4 post-regex start
AcceptToken 'e'"/]
class eNFA5_4_31412076 c0011;
eNFA5_5_9980749[\"εNFA5-5 post-regex end"/]
class eNFA5_5_9980749 c0011;
eNFA6_3_15281487[\"εNFA6-3 regex end
AcceptToken 'd'"/]
class eNFA6_3_15281487 c0111;
eNFA6_4_3315660[\"εNFA6-4 post-regex start
AcceptToken 'd'"/]
class eNFA6_4_3315660 c0011;
eNFA6_5_22717883[\"εNFA6-5 post-regex end"/]
class eNFA6_5_22717883 c0011;
eNFA0_0_34712503 -.->|"ε"|eNFA1_2_60249386
eNFA0_0_34712503 -.->|"ε"|eNFA2_2_43977078
eNFA0_0_34712503 -.->|"ε"|eNFA3_2_5373564
eNFA0_0_34712503 -.->|"ε"|eNFA4_2_48362077
eNFA0_0_34712503 -.->|"ε"|eNFA5_2_32605510
eNFA0_0_34712503 -.->|"ε"|eNFA6_2_25014136
eNFA0_0_34712503 -.->|"ε
BeginToken 's'"|eNFA1_0_3134363
eNFA0_0_34712503 -.->|"ε
BeginToken 't'"|eNFA2_0_29244399
eNFA0_0_34712503 -.->|"ε
BeginToken 'g'"|eNFA3_0_8262853
eNFA0_0_34712503 -.->|"ε
BeginToken 'w'"|eNFA4_0_55730526
eNFA0_0_34712503 -.->|"ε
BeginToken 'e'"|eNFA5_0_38890744
eNFA0_0_34712503 -.->|"ε
BeginToken 'd'"|eNFA6_0_14273236
eNFA0_0_34712503 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_28209268
eNFA0_0_34712503 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_61873003
eNFA0_0_34712503 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_7256820
eNFA0_0_34712503 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_31812687
eNFA0_0_34712503 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_14472379
eNFA0_0_34712503 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_61350266
eNFA1_2_60249386 -.->|"ε
BeginToken 's'"|eNFA1_0_3134363
eNFA1_2_60249386 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_28209268
eNFA2_2_43977078 -.->|"ε
BeginToken 't'"|eNFA2_0_29244399
eNFA2_2_43977078 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_61873003
eNFA3_2_5373564 -.->|"ε
BeginToken 'g'"|eNFA3_0_8262853
eNFA3_2_5373564 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_7256820
eNFA4_2_48362077 -.->|"ε
BeginToken 'w'"|eNFA4_0_55730526
eNFA4_2_48362077 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_31812687
eNFA5_2_32605510 -.->|"ε
BeginToken 'e'"|eNFA5_0_38890744
eNFA5_2_32605510 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_14472379
eNFA6_2_25014136 -.->|"ε
BeginToken 'd'"|eNFA6_0_14273236
eNFA6_2_25014136 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_61350266
eNFA1_0_3134363 -->|"s
BeginToken 's'
ExtendToken 's'"|eNFA1_1_28209268
eNFA2_0_29244399 -->|"t
BeginToken 't'
ExtendToken 't'"|eNFA2_1_61873003
eNFA3_0_8262853 -->|"g
BeginToken 'g'
ExtendToken 'g'"|eNFA3_1_7256820
eNFA4_0_55730526 -->|"w
BeginToken 'w'
ExtendToken 'w'"|eNFA4_1_31812687
eNFA5_0_38890744 -->|"e
BeginToken 'e'
ExtendToken 'e'"|eNFA5_1_14472379
eNFA6_0_14273236 -->|"d
BeginToken 'd'
ExtendToken 'd'"|eNFA6_1_61350266
eNFA1_1_28209268 -.->|"ε
ExtendToken 's'"|eNFA1_3_52556825
eNFA1_1_28209268 -.->|"ε"|eNFA1_4_3249377
eNFA1_1_28209268 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_48803400
eNFA1_1_28209268 -.->|"ε
CheckToken 's'"|eNFA0_1_12879140
eNFA2_1_61873003 -.->|"ε
ExtendToken 't'"|eNFA2_3_19986118
eNFA2_1_61873003 -.->|"ε"|eNFA2_4_45657337
eNFA2_1_61873003 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_23800636
eNFA2_1_61873003 -.->|"ε
CheckToken 't'"|eNFA0_1_12879140
eNFA3_1_7256820 -.->|"ε
ExtendToken 'g'"|eNFA3_3_65311381
eNFA3_1_7256820 -.->|"ε"|eNFA3_4_50931523
eNFA3_1_7256820 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_36577416
eNFA3_1_7256820 -.->|"ε
CheckToken 'g'"|eNFA0_1_12879140
eNFA4_1_31812687 -.->|"ε
ExtendToken 'w'"|eNFA4_3_17878727
eNFA4_1_31812687 -.->|"ε"|eNFA4_4_26690815
eNFA4_1_31812687 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_60761295
eNFA4_1_31812687 -.->|"ε
CheckToken 'w'"|eNFA0_1_12879140
eNFA5_1_14472379 -.->|"ε
ExtendToken 'e'"|eNFA5_3_63142554
eNFA5_1_14472379 -.->|"ε"|eNFA5_4_31412076
eNFA5_1_14472379 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_9980749
eNFA5_1_14472379 -.->|"ε
CheckToken 'e'"|eNFA0_1_12879140
eNFA6_1_61350266 -.->|"ε
ExtendToken 'd'"|eNFA6_3_15281487
eNFA6_1_61350266 -.->|"ε"|eNFA6_4_3315660
eNFA6_1_61350266 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_22717883
eNFA6_1_61350266 -.->|"ε
CheckToken 'd'"|eNFA0_1_12879140
eNFA1_3_52556825 -.->|"ε"|eNFA1_4_3249377
eNFA1_3_52556825 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_48803400
eNFA1_3_52556825 -.->|"ε
CheckToken 's'"|eNFA0_1_12879140
eNFA1_4_3249377 -.->|"ε
CheckToken 's'
AcceptToken 's'"|eNFA1_5_48803400
eNFA1_4_3249377 -.->|"ε
CheckToken 's'"|eNFA0_1_12879140
eNFA1_5_48803400 -.->|"ε
CheckToken 's'"|eNFA0_1_12879140
eNFA2_3_19986118 -.->|"ε"|eNFA2_4_45657337
eNFA2_3_19986118 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_23800636
eNFA2_3_19986118 -.->|"ε
CheckToken 't'"|eNFA0_1_12879140
eNFA2_4_45657337 -.->|"ε
CheckToken 't'
AcceptToken 't'"|eNFA2_5_23800636
eNFA2_4_45657337 -.->|"ε
CheckToken 't'"|eNFA0_1_12879140
eNFA2_5_23800636 -.->|"ε
CheckToken 't'"|eNFA0_1_12879140
eNFA3_3_65311381 -.->|"ε"|eNFA3_4_50931523
eNFA3_3_65311381 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_36577416
eNFA3_3_65311381 -.->|"ε
CheckToken 'g'"|eNFA0_1_12879140
eNFA3_4_50931523 -.->|"ε
CheckToken 'g'
AcceptToken 'g'"|eNFA3_5_36577416
eNFA3_4_50931523 -.->|"ε
CheckToken 'g'"|eNFA0_1_12879140
eNFA3_5_36577416 -.->|"ε
CheckToken 'g'"|eNFA0_1_12879140
eNFA4_3_17878727 -.->|"ε"|eNFA4_4_26690815
eNFA4_3_17878727 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_60761295
eNFA4_3_17878727 -.->|"ε
CheckToken 'w'"|eNFA0_1_12879140
eNFA4_4_26690815 -.->|"ε
CheckToken 'w'
AcceptToken 'w'"|eNFA4_5_60761295
eNFA4_4_26690815 -.->|"ε
CheckToken 'w'"|eNFA0_1_12879140
eNFA4_5_60761295 -.->|"ε
CheckToken 'w'"|eNFA0_1_12879140
eNFA5_3_63142554 -.->|"ε"|eNFA5_4_31412076
eNFA5_3_63142554 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_9980749
eNFA5_3_63142554 -.->|"ε
CheckToken 'e'"|eNFA0_1_12879140
eNFA5_4_31412076 -.->|"ε
CheckToken 'e'
AcceptToken 'e'"|eNFA5_5_9980749
eNFA5_4_31412076 -.->|"ε
CheckToken 'e'"|eNFA0_1_12879140
eNFA5_5_9980749 -.->|"ε
CheckToken 'e'"|eNFA0_1_12879140
eNFA6_3_15281487 -.->|"ε"|eNFA6_4_3315660
eNFA6_3_15281487 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_22717883
eNFA6_3_15281487 -.->|"ε
CheckToken 'd'"|eNFA0_1_12879140
eNFA6_4_3315660 -.->|"ε
CheckToken 'd'
AcceptToken 'd'"|eNFA6_5_22717883
eNFA6_4_3315660 -.->|"ε
CheckToken 'd'"|eNFA0_1_12879140
eNFA6_5_22717883 -.->|"ε
CheckToken 'd'"|eNFA0_1_12879140

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
NFA0_0_133067("NFA0-0 wholeStart")
class NFA0_0_133067 c1000;
NFA1_1_29840947[\"NFA1-1 char[1]
AcceptToken 's'"/]
class NFA1_1_29840947 c0101;
NFA2_1_1197606[\"NFA2-1 char[1]
AcceptToken 't'"/]
class NFA2_1_1197606 c0101;
NFA3_1_10778462[\"NFA3-1 char[1]
AcceptToken 'g'"/]
class NFA3_1_10778462 c0101;
NFA4_1_29897299[\"NFA4-1 char[1]
AcceptToken 'w'"/]
class NFA4_1_29897299 c0101;
NFA5_1_640238[\"NFA5-1 char[1]
AcceptToken 'e'"/]
class NFA5_1_640238 c0101;
NFA6_1_5762144[\"NFA6-1 char[1]
AcceptToken 'd'"/]
class NFA6_1_5762144 c0101;
NFA0_0_133067 -->|"s
BeginToken 's'
ExtendToken 's'"|NFA1_1_29840947
NFA0_0_133067 -->|"t
BeginToken 't'
ExtendToken 't'"|NFA2_1_1197606
NFA0_0_133067 -->|"g
BeginToken 'g'
ExtendToken 'g'"|NFA3_1_10778462
NFA0_0_133067 -->|"w
BeginToken 'w'
ExtendToken 'w'"|NFA4_1_29897299
NFA0_0_133067 -->|"e
BeginToken 'e'
ExtendToken 'e'"|NFA5_1_640238
NFA0_0_133067 -->|"d
BeginToken 'd'
ExtendToken 'd'"|NFA6_1_5762144

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
subgraph DFA0_1716080415["DFA0 wholeStart"]
NFA0_0_133067_0("NFA0-0 wholeStart")
class NFA0_0_133067_0 c1000;
end
class DFA0_1716080415 c1000;
subgraph DFA1_-240143629["DFA1 {1}"]
NFA1_1_29840947_1[\"NFA1-1 char[1]
AcceptToken 's'"/]
class NFA1_1_29840947_1 c0101;
end
class DFA1_-240143629 c0101;
subgraph DFA2_301028278["DFA2 {1}"]
NFA2_1_1197606_2[\"NFA2-1 char[1]
AcceptToken 't'"/]
class NFA2_1_1197606_2 c0101;
end
class DFA2_301028278 c0101;
subgraph DFA3_-386939718["DFA3 {1}"]
NFA3_1_10778462_3[\"NFA3-1 char[1]
AcceptToken 'g'"/]
class NFA3_1_10778462_3 c0101;
end
class DFA3_-386939718 c0101;
subgraph DFA4_-1306490502["DFA4 {1}"]
NFA4_1_29897299_4[\"NFA4-1 char[1]
AcceptToken 'w'"/]
class NFA4_1_29897299_4 c0101;
end
class DFA4_-1306490502 c0101;
subgraph DFA5_-1787280378["DFA5 {1}"]
NFA5_1_640238_5[\"NFA5-1 char[1]
AcceptToken 'e'"/]
class NFA5_1_640238_5 c0101;
end
class DFA5_-1787280378 c0101;
subgraph DFA6_-1886935679["DFA6 {1}"]
NFA6_1_5762144_6[\"NFA6-1 char[1]
AcceptToken 'd'"/]
class NFA6_1_5762144_6 c0101;
end
class DFA6_-1886935679 c0101;
DFA0_1716080415 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA1_-240143629
DFA0_1716080415 -->|"t
BeginToken 't'
ExtendToken 't'"|DFA2_301028278
DFA0_1716080415 -->|"g
BeginToken 'g'
ExtendToken 'g'"|DFA3_-386939718
DFA0_1716080415 -->|"w
BeginToken 'w'
ExtendToken 'w'"|DFA4_-1306490502
DFA0_1716080415 -->|"e
BeginToken 'e'
ExtendToken 'e'"|DFA5_-1787280378
DFA0_1716080415 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA6_-1886935679

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
DFA0_1716080415{{"DFA0 wholeStart"}}
class DFA0_1716080415 c1000;
DFA1_-240143629[\"DFA1 {1}
AcceptToken 's'"/]
class DFA1_-240143629 c0101;
DFA2_301028278[\"DFA2 {1}
AcceptToken 't'"/]
class DFA2_301028278 c0101;
DFA3_-386939718[\"DFA3 {1}
AcceptToken 'g'"/]
class DFA3_-386939718 c0101;
DFA4_-1306490502[\"DFA4 {1}
AcceptToken 'w'"/]
class DFA4_-1306490502 c0101;
DFA5_-1787280378[\"DFA5 {1}
AcceptToken 'e'"/]
class DFA5_-1787280378 c0101;
DFA6_-1886935679[\"DFA6 {1}
AcceptToken 'd'"/]
class DFA6_-1886935679 c0101;
DFA0_1716080415 -->|"s
BeginToken 's'
ExtendToken 's'"|DFA1_-240143629
DFA0_1716080415 -->|"t
BeginToken 't'
ExtendToken 't'"|DFA2_301028278
DFA0_1716080415 -->|"g
BeginToken 'g'
ExtendToken 'g'"|DFA3_-386939718
DFA0_1716080415 -->|"w
BeginToken 'w'
ExtendToken 'w'"|DFA4_-1306490502
DFA0_1716080415 -->|"e
BeginToken 'e'
ExtendToken 'e'"|DFA5_-1787280378
DFA0_1716080415 -->|"d
BeginToken 'd'
ExtendToken 'd'"|DFA6_-1886935679

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
subgraph MiniDFA0_585917162["MiniDFA0 {1}"]
DFA0_1716080415_0{{"DFA0 wholeStart"}}
class DFA0_1716080415_0 c1000;
end
class MiniDFA0_585917162 c1000;
subgraph MiniDFA1_-240199859["MiniDFA1 {1}"]
DFA1_-240143629_1[\"DFA1 {1}
AcceptToken 's'"/]
class DFA1_-240143629_1 c0101;
end
class MiniDFA1_-240199859 c0101;
subgraph MiniDFA2_1028159909["MiniDFA2 {1}"]
DFA2_301028278_2[\"DFA2 {1}
AcceptToken 't'"/]
class DFA2_301028278_2 c0101;
end
class MiniDFA2_1028159909 c0101;
subgraph MiniDFA3_566924018["MiniDFA3 {1}"]
DFA3_-386939718_3[\"DFA3 {1}
AcceptToken 'g'"/]
class DFA3_-386939718_3 c0101;
end
class MiniDFA3_566924018 c0101;
subgraph MiniDFA4_1609187585["MiniDFA4 {1}"]
DFA4_-1306490502_4[\"DFA4 {1}
AcceptToken 'w'"/]
class DFA4_-1306490502_4 c0101;
end
class MiniDFA4_1609187585 c0101;
subgraph MiniDFA5_1522998107["MiniDFA5 {1}"]
DFA5_-1787280378_5[\"DFA5 {1}
AcceptToken 'e'"/]
class DFA5_-1787280378_5 c0101;
end
class MiniDFA5_1522998107 c0101;
subgraph MiniDFA6_1977924070["MiniDFA6 {1}"]
DFA6_-1886935679_6[\"DFA6 {1}
AcceptToken 'd'"/]
class DFA6_-1886935679_6 c0101;
end
class MiniDFA6_1977924070 c0101;
MiniDFA0_585917162 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA1_-240199859
MiniDFA0_585917162 -->|"t
BeginToken 't'
ExtendToken 't'"|MiniDFA2_1028159909
MiniDFA0_585917162 -->|"g
BeginToken 'g'
ExtendToken 'g'"|MiniDFA3_566924018
MiniDFA0_585917162 -->|"w
BeginToken 'w'
ExtendToken 'w'"|MiniDFA4_1609187585
MiniDFA0_585917162 -->|"e
BeginToken 'e'
ExtendToken 'e'"|MiniDFA5_1522998107
MiniDFA0_585917162 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA6_1977924070

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
MiniDFA0_585917162(["MiniDFA0 {1}"])
class MiniDFA0_585917162 c1000;
MiniDFA1_-240199859[\"MiniDFA1 {1}
AcceptToken 's'"/]
class MiniDFA1_-240199859 c0101;
MiniDFA2_1028159909[\"MiniDFA2 {1}
AcceptToken 't'"/]
class MiniDFA2_1028159909 c0101;
MiniDFA3_566924018[\"MiniDFA3 {1}
AcceptToken 'g'"/]
class MiniDFA3_566924018 c0101;
MiniDFA4_1609187585[\"MiniDFA4 {1}
AcceptToken 'w'"/]
class MiniDFA4_1609187585 c0101;
MiniDFA5_1522998107[\"MiniDFA5 {1}
AcceptToken 'e'"/]
class MiniDFA5_1522998107 c0101;
MiniDFA6_1977924070[\"MiniDFA6 {1}
AcceptToken 'd'"/]
class MiniDFA6_1977924070 c0101;
MiniDFA0_585917162 -->|"s
BeginToken 's'
ExtendToken 's'"|MiniDFA1_-240199859
MiniDFA0_585917162 -->|"t
BeginToken 't'
ExtendToken 't'"|MiniDFA2_1028159909
MiniDFA0_585917162 -->|"g
BeginToken 'g'
ExtendToken 'g'"|MiniDFA3_566924018
MiniDFA0_585917162 -->|"w
BeginToken 'w'
ExtendToken 'w'"|MiniDFA4_1609187585
MiniDFA0_585917162 -->|"e
BeginToken 'e'
ExtendToken 'e'"|MiniDFA5_1522998107
MiniDFA0_585917162 -->|"d
BeginToken 'd'
ExtendToken 'd'"|MiniDFA6_1977924070

```

# 总结

无。

