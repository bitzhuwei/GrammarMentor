# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Numbers`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（4个State）。

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
eNFA0_2_64837129[["εNFA0-2 regex start"]]
eNFA0_0_59044826[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_21473617[["εNFA0-1 scope[1]"]]
eNFA0_3_61641391[["εNFA0-3 regex end"]]
eNFA0_2_64837129 -.->|"ε"|eNFA0_0_59044826
eNFA0_0_59044826 -->|"[0-9]"|eNFA0_1_21473617
eNFA0_1_21473617 -->|"[0-9]"|eNFA0_1_21473617
eNFA0_1_21473617 -.->|"ε"|eNFA0_3_61641391
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
eNFA0_4_60425605[["εNFA0-4 post-regex start"]]
eNFA0_5_6959534[\"εNFA0-5 post-regex end"/]
eNFA0_4_60425605 -.->|"ε"|eNFA0_5_6959534
```


## 'float'
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
eNFA0_6_47703625[["εNFA0-6 regex start"]]
eNFA0_0_40744081[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_26896741[["εNFA0-1 scope[1]"]]
eNFA0_2_31152412[["εNFA0-2 char{1, 1}"]]
eNFA0_3_54853163[["εNFA0-3 char[1]"]]
eNFA0_4_40317435[["εNFA0-4 scope{1, ∞}"]]
eNFA0_5_11936255[["εNFA0-5 scope[1]"]]
eNFA0_7_27312602[["εNFA0-7 regex end"]]
eNFA0_6_47703625 -.->|"ε"|eNFA0_0_40744081
eNFA0_0_40744081 -->|"[0-9]"|eNFA0_1_26896741
eNFA0_1_26896741 -->|"[0-9]"|eNFA0_1_26896741
eNFA0_1_26896741 -.->|"ε"|eNFA0_2_31152412
eNFA0_2_31152412 -->|"."|eNFA0_3_54853163
eNFA0_3_54853163 -.->|"ε"|eNFA0_4_40317435
eNFA0_4_40317435 -->|"[0-9]"|eNFA0_5_11936255
eNFA0_5_11936255 -->|"[0-9]"|eNFA0_5_11936255
eNFA0_5_11936255 -.->|"ε"|eNFA0_7_27312602
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
eNFA0_8_53878095[["εNFA0-8 post-regex start"]]
eNFA0_9_15140815[\"εNFA0-9 post-regex end"/]
eNFA0_8_53878095 -.->|"ε"|eNFA0_9_15140815
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
eNFA0_0_9499066[["εNFA0-0 wholeStart"]]
eNFA1_2_34836667[["εNFA1-2 regex start"]]
class eNFA1_2_34836667 c1000;
eNFA2_6_18382734[["εNFA2-6 regex start"]]
class eNFA2_6_18382734 c1000;
eNFA1_0_50140351[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_57690894[["εNFA2-0 scope{1, ∞}"]]
eNFA1_1_27940771[["εNFA1-1 scope[1]"]]
eNFA2_1_28779720[["εNFA2-1 scope[1]"]]
eNFA1_3_48609983[["εNFA1-3 regex end"]]
class eNFA1_3_48609983 c0100;
eNFA2_2_49456006[["εNFA2-2 char{1, 1}"]]
eNFA1_4_45094547[["εNFA1-4 post-regex start"]]
class eNFA1_4_45094547 c0010;
eNFA2_3_45742965[["εNFA2-3 char[1]"]]
eNFA1_5_3197746[\"εNFA1-5 post-regex end"/]
class eNFA1_5_3197746 c0001;
eNFA2_4_46513524[["εNFA2-4 scope{1, ∞}"]]
eNFA0_1_12606476[\"εNFA0-1 wholeEnd"/]
eNFA2_5_42450871[["εNFA2-5 scope[1]"]]
eNFA2_7_15968532[["εNFA2-7 regex end"]]
class eNFA2_7_15968532 c0100;
eNFA2_8_46349424[["εNFA2-8 post-regex start"]]
class eNFA2_8_46349424 c0010;
eNFA2_9_31226881[\"εNFA2-9 post-regex end"/]
class eNFA2_9_31226881 c0001;
eNFA0_0_9499066 -.->|"ε"|eNFA1_2_34836667
eNFA0_0_9499066 -.->|"ε"|eNFA2_6_18382734
eNFA1_2_34836667 -.->|"ε
BeginToken 'integer'"|eNFA1_0_50140351
eNFA2_6_18382734 -.->|"ε
BeginToken 'float'"|eNFA2_0_57690894
eNFA1_0_50140351 -->|"[0-9]"|eNFA1_1_27940771
eNFA2_0_57690894 -->|"[0-9]"|eNFA2_1_28779720
eNFA1_1_27940771 -->|"[0-9]"|eNFA1_1_27940771
eNFA1_1_27940771 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_48609983
eNFA2_1_28779720 -->|"[0-9]"|eNFA2_1_28779720
eNFA2_1_28779720 -.->|"ε"|eNFA2_2_49456006
eNFA1_3_48609983 -.->|"ε"|eNFA1_4_45094547
eNFA2_2_49456006 -->|"."|eNFA2_3_45742965
eNFA1_4_45094547 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_3197746
eNFA2_3_45742965 -.->|"ε"|eNFA2_4_46513524
eNFA1_5_3197746 -.->|"ε"|eNFA0_1_12606476
eNFA2_4_46513524 -->|"[0-9]"|eNFA2_5_42450871
eNFA2_5_42450871 -->|"[0-9]"|eNFA2_5_42450871
eNFA2_5_42450871 -.->|"ε
ExtendToken 'float'"|eNFA2_7_15968532
eNFA2_7_15968532 -.->|"ε"|eNFA2_8_46349424
eNFA2_8_46349424 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_31226881
eNFA2_9_31226881 -.->|"ε"|eNFA0_1_12606476

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
eNFA0_0_14491639[["εNFA0-0 wholeStart"]]
class eNFA0_0_14491639 c1000;
eNFA1_2_32972086[["εNFA1-2 regex start"]]
class eNFA1_2_32972086 c1000;
eNFA2_6_63315888[["εNFA2-6 regex start"]]
class eNFA2_6_63315888 c1000;
eNFA1_0_53493298[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_53493298 c1000;
eNFA2_0_6364259[["εNFA2-0 scope{1, ∞}"]]
class eNFA2_0_6364259 c1000;
eNFA1_1_28313321[\"εNFA1-1 scope[1]
AcceptToken 'integer'"/]
class eNFA1_1_28313321 c0111;
eNFA2_1_37989842[["εNFA2-1 scope[1]"]]
eNFA1_3_11677634[\"εNFA1-3 regex end
AcceptToken 'integer'"/]
class eNFA1_3_11677634 c0111;
eNFA1_4_7579726[\"εNFA1-4 post-regex start
AcceptToken 'integer'"/]
class eNFA1_4_7579726 c0011;
eNFA1_5_38124894[\"εNFA1-5 post-regex end"/]
class eNFA1_5_38124894 c0011;
eNFA0_1_11692639[\"εNFA0-1 wholeEnd"/]
eNFA2_2_57278334[["εNFA2-2 char{1, 1}"]]
eNFA2_3_9978065[["εNFA2-3 char[1]"]]
eNFA2_4_14192671[["εNFA2-4 scope{1, ∞}"]]
eNFA2_5_9033503[\"εNFA2-5 scope[1]
AcceptToken 'float'"/]
class eNFA2_5_9033503 c0111;
eNFA2_7_60625181[\"εNFA2-7 regex end
AcceptToken 'float'"/]
class eNFA2_7_60625181 c0111;
eNFA2_8_1108673[\"εNFA2-8 post-regex start
AcceptToken 'float'"/]
class eNFA2_8_1108673 c0011;
eNFA2_9_8755722[\"εNFA2-9 post-regex end"/]
class eNFA2_9_8755722 c0011;
eNFA0_0_14491639 -.->|"ε"|eNFA1_2_32972086
eNFA0_0_14491639 -.->|"ε"|eNFA2_6_63315888
eNFA0_0_14491639 -.->|"ε
BeginToken 'integer'"|eNFA1_0_53493298
eNFA0_0_14491639 -.->|"ε
BeginToken 'float'"|eNFA2_0_6364259
eNFA0_0_14491639 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_28313321
eNFA0_0_14491639 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_37989842
eNFA1_2_32972086 -.->|"ε
BeginToken 'integer'"|eNFA1_0_53493298
eNFA1_2_32972086 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_28313321
eNFA2_6_63315888 -.->|"ε
BeginToken 'float'"|eNFA2_0_6364259
eNFA2_6_63315888 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_37989842
eNFA1_0_53493298 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|eNFA1_1_28313321
eNFA2_0_6364259 -->|"[0-9]
BeginToken 'float'"|eNFA2_1_37989842
eNFA1_1_28313321 -->|"[0-9]
ExtendToken 'integer'"|eNFA1_1_28313321
eNFA1_1_28313321 -.->|"ε
ExtendToken 'integer'"|eNFA1_3_11677634
eNFA1_1_28313321 -.->|"ε"|eNFA1_4_7579726
eNFA1_1_28313321 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_38124894
eNFA1_1_28313321 -.->|"ε
CheckToken 'integer'"|eNFA0_1_11692639
eNFA2_1_37989842 -->|"[0-9]"|eNFA2_1_37989842
eNFA2_1_37989842 -.->|"ε"|eNFA2_2_57278334
eNFA2_1_37989842 -->|"."|eNFA2_3_9978065
eNFA1_3_11677634 -.->|"ε"|eNFA1_4_7579726
eNFA1_3_11677634 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_38124894
eNFA1_3_11677634 -.->|"ε
CheckToken 'integer'"|eNFA0_1_11692639
eNFA1_4_7579726 -.->|"ε
CheckToken 'integer'
AcceptToken 'integer'"|eNFA1_5_38124894
eNFA1_4_7579726 -.->|"ε
CheckToken 'integer'"|eNFA0_1_11692639
eNFA1_5_38124894 -.->|"ε
CheckToken 'integer'"|eNFA0_1_11692639
eNFA2_2_57278334 -->|"."|eNFA2_3_9978065
eNFA2_3_9978065 -.->|"ε"|eNFA2_4_14192671
eNFA2_3_9978065 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_9033503
eNFA2_4_14192671 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_9033503
eNFA2_5_9033503 -->|"[0-9]
ExtendToken 'float'"|eNFA2_5_9033503
eNFA2_5_9033503 -.->|"ε
ExtendToken 'float'"|eNFA2_7_60625181
eNFA2_5_9033503 -.->|"ε"|eNFA2_8_1108673
eNFA2_5_9033503 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_8755722
eNFA2_5_9033503 -.->|"ε
CheckToken 'float'"|eNFA0_1_11692639
eNFA2_7_60625181 -.->|"ε"|eNFA2_8_1108673
eNFA2_7_60625181 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_8755722
eNFA2_7_60625181 -.->|"ε
CheckToken 'float'"|eNFA0_1_11692639
eNFA2_8_1108673 -.->|"ε
CheckToken 'float'
AcceptToken 'float'"|eNFA2_9_8755722
eNFA2_8_1108673 -.->|"ε
CheckToken 'float'"|eNFA0_1_11692639
eNFA2_9_8755722 -.->|"ε
CheckToken 'float'"|eNFA0_1_11692639

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
NFA0_0_2916945("NFA0-0 wholeStart")
class NFA0_0_2916945 c1000;
NFA1_1_22693726[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_22693726 c0101;
NFA2_1_26252507("NFA2-1 scope[1]")
NFA2_3_34945973("NFA2-3 char[1]")
NFA2_5_46078304[\"NFA2-5 scope[1]
AcceptToken 'float'"/]
class NFA2_5_46078304 c0101;
NFA0_0_2916945 -->|"[0-9]
BeginToken 'integer'
ExtendToken 'integer'"|NFA1_1_22693726
NFA0_0_2916945 -->|"[0-9]
BeginToken 'float'"|NFA2_1_26252507
NFA1_1_22693726 -->|"[0-9]
ExtendToken 'integer'"|NFA1_1_22693726
NFA2_1_26252507 -->|"[0-9]"|NFA2_1_26252507
NFA2_1_26252507 -->|"."|NFA2_3_34945973
NFA2_3_34945973 -->|"[0-9]
ExtendToken 'float'"|NFA2_5_46078304
NFA2_5_46078304 -->|"[0-9]
ExtendToken 'float'"|NFA2_5_46078304

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
subgraph DFA0_-719760743["DFA0 wholeStart"]
NFA0_0_2916945_0("NFA0-0 wholeStart")
class NFA0_0_2916945_0 c1000;
end
class DFA0_-719760743 c1000;
subgraph DFA1_-1749208652["DFA1 {2}"]
NFA1_1_22693726_1[\"NFA1-1 scope[1]
AcceptToken 'integer'"/]
class NFA1_1_22693726_1 c0101;
NFA2_1_26252507_2("NFA2-1 scope[1]")
end
class DFA1_-1749208652 c0101;
subgraph DFA2_-646656898["DFA2 {1}"]
NFA2_3_34945973_3("NFA2-3 char[1]")
end
subgraph DFA3_-496823011["DFA3 {1}"]
NFA2_5_46078304_4[\"NFA2-5 scope[1]
AcceptToken 'float'"/]
class NFA2_5_46078304_4 c0101;
end
class DFA3_-496823011 c0101;
DFA0_-719760743 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|DFA1_-1749208652
DFA1_-1749208652 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1749208652
DFA1_-1749208652 -->|"."|DFA2_-646656898
DFA2_-646656898 -->|"[0-9]
ExtendToken 'float'"|DFA3_-496823011
DFA3_-496823011 -->|"[0-9]
ExtendToken 'float'"|DFA3_-496823011

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
DFA0_-719760743{{"DFA0 wholeStart"}}
class DFA0_-719760743 c1000;
DFA1_-1749208652[\"DFA1 {2}
AcceptToken 'integer'"/]
class DFA1_-1749208652 c0101;
DFA2_-646656898{{"DFA2 {1}"}}
DFA3_-496823011[\"DFA3 {1}
AcceptToken 'float'"/]
class DFA3_-496823011 c0101;
DFA0_-719760743 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|DFA1_-1749208652
DFA1_-1749208652 -->|"[0-9]
ExtendToken 'integer'"|DFA1_-1749208652
DFA1_-1749208652 -->|"."|DFA2_-646656898
DFA2_-646656898 -->|"[0-9]
ExtendToken 'float'"|DFA3_-496823011
DFA3_-496823011 -->|"[0-9]
ExtendToken 'float'"|DFA3_-496823011

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
subgraph MiniDFA0_569336601["MiniDFA0 {1}"]
DFA0_-719760743_0{{"DFA0 wholeStart"}}
class DFA0_-719760743_0 c1000;
end
class MiniDFA0_569336601 c1000;
subgraph MiniDFA2_-164932217["MiniDFA2 {1}"]
DFA1_-1749208652_1[\"DFA1 {2}
AcceptToken 'integer'"/]
class DFA1_-1749208652_1 c0101;
end
class MiniDFA2_-164932217 c0101;
subgraph MiniDFA1_-292777981["MiniDFA1 {1}"]
DFA2_-646656898_2{{"DFA2 {1}"}}
end
subgraph MiniDFA3_-406947756["MiniDFA3 {1}"]
DFA3_-496823011_3[\"DFA3 {1}
AcceptToken 'float'"/]
class DFA3_-496823011_3 c0101;
end
class MiniDFA3_-406947756 c0101;
MiniDFA0_569336601 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|MiniDFA2_-164932217
MiniDFA2_-164932217 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA2_-164932217
MiniDFA2_-164932217 -->|"."|MiniDFA1_-292777981
MiniDFA1_-292777981 -->|"[0-9]
ExtendToken 'float'"|MiniDFA3_-406947756
MiniDFA3_-406947756 -->|"[0-9]
ExtendToken 'float'"|MiniDFA3_-406947756

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
MiniDFA0_569336601(["MiniDFA0 {1}"])
class MiniDFA0_569336601 c1000;
MiniDFA2_-164932217[\"MiniDFA2 {1}
AcceptToken 'integer'"/]
class MiniDFA2_-164932217 c0101;
MiniDFA1_-292777981(["MiniDFA1 {1}"])
MiniDFA3_-406947756[\"MiniDFA3 {1}
AcceptToken 'float'"/]
class MiniDFA3_-406947756 c0101;
MiniDFA0_569336601 -->|"[0-9]
BeginToken 'integer''float'
ExtendToken 'integer'"|MiniDFA2_-164932217
MiniDFA2_-164932217 -->|"[0-9]
ExtendToken 'integer'"|MiniDFA2_-164932217
MiniDFA2_-164932217 -->|"."|MiniDFA1_-292777981
MiniDFA1_-292777981 -->|"[0-9]
ExtendToken 'float'"|MiniDFA3_-406947756
MiniDFA3_-406947756 -->|"[0-9]
ExtendToken 'float'"|MiniDFA3_-406947756

```

# 总结

无。

