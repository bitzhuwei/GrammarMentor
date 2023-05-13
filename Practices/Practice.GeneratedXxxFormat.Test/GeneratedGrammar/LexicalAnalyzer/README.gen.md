# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Grammar`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（32个State）。

## 'Vn'
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
eNFA0_3_47644174[["εNFA0-3 regex start"]]
eNFA0_0_26144382[["εNFA0-0 scope{1, 1}"]]
eNFA0_1_48911576[["εNFA0-1 scope[1]"]]
eNFA0_2_37551006[["εNFA0-2 scope{0, ∞}"]]
eNFA0_4_2414735[["εNFA0-4 regex end"]]
eNFA0_3_47644174 -.->|"ε"|eNFA0_0_26144382
eNFA0_0_26144382 -->|"[a-zA-Z_]"|eNFA0_1_48911576
eNFA0_1_48911576 -.->|"ε"|eNFA0_2_37551006
eNFA0_2_37551006 -->|"[a-zA-Z0-9_]"|eNFA0_2_37551006
eNFA0_2_37551006 -.->|"ε"|eNFA0_4_2414735
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
eNFA0_5_3036801[["εNFA0-5 post-regex start"]]
eNFA0_6_27331211[\"εNFA0-6 post-regex end"/]
eNFA0_5_3036801 -.->|"ε"|eNFA0_6_27331211
```


## 'Vt'
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
eNFA0_20_31683520[["εNFA0-20 regex start"]]
eNFA0_0_16716228[["εNFA0-0 char{1, 1}"]]
eNFA0_1_16228328[["εNFA0-1 char[1]"]]
eNFA0_4_61375875[["εNFA0-4 regex start"]]
eNFA0_2_5389979[["εNFA0-2 scope{1, 1}"]]
eNFA0_6_15511967[["εNFA0-6 char{1, 1}"]]
eNFA0_10_64394073[["εNFA0-10 scope{1, 1}"]]
eNFA0_12_48537423[["εNFA0-12 char{1, 1}"]]
eNFA0_16_39217161[["εNFA0-16 scope{1, 1}"]]
eNFA0_3_36981058[["εNFA0-3 scope[1]"]]
eNFA0_7_18480702[["εNFA0-7 char[1]"]]
eNFA0_11_42675749[["εNFA0-11 scope[1]"]]
eNFA0_13_32108598[["εNFA0-13 char[1]"]]
eNFA0_17_17410131[["εNFA0-17 scope[1]"]]
eNFA0_5_33935168[["εNFA0-5 regex end"]]
eNFA0_8_20541927[["εNFA0-8 char{1, 1}"]]
eNFA0_14_20987838[["εNFA0-14 char{1, 1}"]]
eNFA0_4_22473455[["εNFA0-4 regex start"]]
eNFA0_9_48509816[["εNFA0-9 char[1]"]]
eNFA0_15_34183624[["εNFA0-15 char[1]"]]
eNFA0_2_8410603[["εNFA0-2 scope{1, 1}"]]
eNFA0_6_934511[["εNFA0-6 char{1, 1}"]]
eNFA0_10_8586563[["εNFA0-10 scope{1, 1}"]]
eNFA0_12_10170210[["εNFA0-12 char{1, 1}"]]
eNFA0_16_24423032[["εNFA0-16 scope{1, 1}"]]
eNFA0_5_53283396[["εNFA0-5 regex end"]]
eNFA0_3_9788522[["εNFA0-3 scope[1]"]]
eNFA0_7_33512753[["εNFA0-7 char[1]"]]
eNFA0_11_50659620[["εNFA0-11 scope[1]"]]
eNFA0_13_33179327[["εNFA0-13 char[1]"]]
eNFA0_17_54672817[["εNFA0-17 scope[1]"]]
eNFA0_18_60927527[["εNFA0-18 char{1, 1}"]]
eNFA0_8_28538697[["εNFA0-8 char{1, 1}"]]
eNFA0_14_29933124[["εNFA0-14 char{1, 1}"]]
eNFA0_19_8663955[["εNFA0-19 char[1]"]]
eNFA0_9_22293308[["εNFA0-9 char[1]"]]
eNFA0_15_66422048[["εNFA0-15 char[1]"]]
eNFA0_21_10866734[["εNFA0-21 regex end"]]
eNFA0_20_31683520 -.->|"ε"|eNFA0_0_16716228
eNFA0_0_16716228 -->|"'"|eNFA0_1_16228328
eNFA0_1_16228328 -.->|"ε"|eNFA0_4_61375875
eNFA0_4_61375875 -.->|"ε"|eNFA0_2_5389979
eNFA0_4_61375875 -.->|"ε"|eNFA0_6_15511967
eNFA0_4_61375875 -.->|"ε"|eNFA0_10_64394073
eNFA0_4_61375875 -.->|"ε"|eNFA0_12_48537423
eNFA0_4_61375875 -.->|"ε"|eNFA0_16_39217161
eNFA0_2_5389979 -->|"[#32;-&]"|eNFA0_3_36981058
eNFA0_6_15511967 -->|"#92;"|eNFA0_7_18480702
eNFA0_10_64394073 -->|"[(-[]"|eNFA0_11_42675749
eNFA0_12_48537423 -->|"#92;"|eNFA0_13_32108598
eNFA0_16_39217161 -->|"[]-~]"|eNFA0_17_17410131
eNFA0_3_36981058 -.->|"ε"|eNFA0_5_33935168
eNFA0_7_18480702 -.->|"ε"|eNFA0_8_20541927
eNFA0_11_42675749 -.->|"ε"|eNFA0_5_33935168
eNFA0_13_32108598 -.->|"ε"|eNFA0_14_20987838
eNFA0_17_17410131 -.->|"ε"|eNFA0_5_33935168
eNFA0_5_33935168 -.->|"ε"|eNFA0_4_22473455
eNFA0_8_20541927 -->|"'"|eNFA0_9_48509816
eNFA0_14_20987838 -->|"#92;"|eNFA0_15_34183624
eNFA0_4_22473455 -.->|"ε"|eNFA0_2_8410603
eNFA0_4_22473455 -.->|"ε"|eNFA0_6_934511
eNFA0_4_22473455 -.->|"ε"|eNFA0_10_8586563
eNFA0_4_22473455 -.->|"ε"|eNFA0_12_10170210
eNFA0_4_22473455 -.->|"ε"|eNFA0_16_24423032
eNFA0_4_22473455 -.->|"ε"|eNFA0_5_53283396
eNFA0_9_48509816 -.->|"ε"|eNFA0_5_33935168
eNFA0_15_34183624 -.->|"ε"|eNFA0_5_33935168
eNFA0_2_8410603 -->|"[#32;-&]"|eNFA0_3_9788522
eNFA0_6_934511 -->|"#92;"|eNFA0_7_33512753
eNFA0_10_8586563 -->|"[(-[]"|eNFA0_11_50659620
eNFA0_12_10170210 -->|"#92;"|eNFA0_13_33179327
eNFA0_16_24423032 -->|"[]-~]"|eNFA0_17_54672817
eNFA0_5_53283396 -.->|"ε"|eNFA0_4_22473455
eNFA0_5_53283396 -.->|"ε"|eNFA0_18_60927527
eNFA0_3_9788522 -.->|"ε"|eNFA0_5_53283396
eNFA0_7_33512753 -.->|"ε"|eNFA0_8_28538697
eNFA0_11_50659620 -.->|"ε"|eNFA0_5_53283396
eNFA0_13_33179327 -.->|"ε"|eNFA0_14_29933124
eNFA0_17_54672817 -.->|"ε"|eNFA0_5_53283396
eNFA0_18_60927527 -->|"'"|eNFA0_19_8663955
eNFA0_8_28538697 -->|"'"|eNFA0_9_22293308
eNFA0_14_29933124 -->|"#92;"|eNFA0_15_66422048
eNFA0_19_8663955 -.->|"ε"|eNFA0_21_10866734
eNFA0_9_22293308 -.->|"ε"|eNFA0_5_53283396
eNFA0_15_66422048 -.->|"ε"|eNFA0_5_53283396
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
eNFA0_22_3003215[["εNFA0-22 post-regex start"]]
eNFA0_23_27028936[\"εNFA0-23 post-regex end"/]
eNFA0_22_3003215 -.->|"ε"|eNFA0_23_27028936
```


## 'pattern'
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
eNFA0_16_19401144[["εNFA0-16 regex start"]]
eNFA0_0_40392571[["εNFA0-0 scope{2, 2}"]]
eNFA0_1_27988827[["εNFA0-1 scope[1]"]]
eNFA0_2_50572856[["εNFA0-2 scope[2]"]]
eNFA0_3_52502523[["εNFA0-3 scope{1, 1}"]]
eNFA0_4_29125038[["εNFA0-4 scope[1]"]]
eNFA0_7_36182630[["εNFA0-7 regex start"]]
eNFA0_5_45111906[["εNFA0-5 scope{1, 1}"]]
eNFA0_9_57208217[["εNFA0-9 char{1, 1}"]]
eNFA0_8_30185730[["εNFA0-8 regex end"]]
eNFA0_6_3236115[["εNFA0-6 scope[1]"]]
eNFA0_10_60414160[["εNFA0-10 char[1]"]]
eNFA0_13_60798757[["εNFA0-13 scope{2, 2}"]]
eNFA0_11_32356781[["εNFA0-11 scope{1, 1}"]]
eNFA0_14_22775581[["εNFA0-14 scope[1]"]]
eNFA0_12_3353970[["εNFA0-12 scope[1]"]]
eNFA0_15_3653637[["εNFA0-15 scope[2]"]]
eNFA0_17_27509165[["εNFA0-17 regex end"]]
eNFA0_16_19401144 -.->|"ε"|eNFA0_0_40392571
eNFA0_0_40392571 -->|"[%]"|eNFA0_1_27988827
eNFA0_1_27988827 -->|"[%]"|eNFA0_2_50572856
eNFA0_2_50572856 -.->|"ε"|eNFA0_3_52502523
eNFA0_3_52502523 -->|"[#32;-~]"|eNFA0_4_29125038
eNFA0_4_29125038 -.->|"ε"|eNFA0_7_36182630
eNFA0_7_36182630 -.->|"ε"|eNFA0_5_45111906
eNFA0_7_36182630 -.->|"ε"|eNFA0_9_57208217
eNFA0_7_36182630 -.->|"ε"|eNFA0_8_30185730
eNFA0_5_45111906 -->|"[^%]"|eNFA0_6_3236115
eNFA0_9_57208217 -->|"%"|eNFA0_10_60414160
eNFA0_8_30185730 -.->|"ε"|eNFA0_7_36182630
eNFA0_8_30185730 -.->|"ε"|eNFA0_13_60798757
eNFA0_6_3236115 -.->|"ε"|eNFA0_8_30185730
eNFA0_10_60414160 -.->|"ε"|eNFA0_11_32356781
eNFA0_13_60798757 -->|"[%]"|eNFA0_14_22775581
eNFA0_11_32356781 -->|"[^%]"|eNFA0_12_3353970
eNFA0_14_22775581 -->|"[%]"|eNFA0_15_3653637
eNFA0_12_3353970 -.->|"ε"|eNFA0_8_30185730
eNFA0_15_3653637 -.->|"ε"|eNFA0_17_27509165
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
eNFA0_18_46255894[["εNFA0-18 post-regex start"]]
eNFA0_19_13649869[\"εNFA0-19 post-regex end"/]
eNFA0_18_46255894 -.->|"ε"|eNFA0_19_13649869
```


## ':'
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
eNFA0_2_60514793[["εNFA0-2 regex start"]]
eNFA0_0_7762230[["εNFA0-0 char{1, 1}"]]
eNFA0_1_2751213[["εNFA0-1 char[1]"]]
eNFA0_3_24760917[["εNFA0-3 regex end"]]
eNFA0_2_60514793 -.->|"ε"|eNFA0_0_7762230
eNFA0_0_7762230 -->|":"|eNFA0_1_2751213
eNFA0_1_2751213 -.->|"ε"|eNFA0_3_24760917
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
eNFA0_4_21521664[["εNFA0-4 post-regex start"]]
eNFA0_5_59477256[\"εNFA0-5 post-regex end"/]
eNFA0_4_21521664 -.->|"ε"|eNFA0_5_59477256
```


## ';'
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
eNFA0_2_57067442[["εNFA0-2 regex start"]]
eNFA0_0_43844931[["εNFA0-0 char{1, 1}"]]
eNFA0_1_59060066[["εNFA0-1 char[1]"]]
eNFA0_3_61778551[["εNFA0-3 regex end"]]
eNFA0_2_57067442 -.->|"ε"|eNFA0_0_43844931
eNFA0_0_43844931 -->|";"|eNFA0_1_59060066
eNFA0_1_59060066 -.->|"ε"|eNFA0_3_61778551
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
eNFA0_4_19136051[["εNFA0-4 post-regex start"]]
eNFA0_5_38006735[\"εNFA0-5 post-regex end"/]
eNFA0_4_19136051 -.->|"ε"|eNFA0_5_38006735
```


## '|'
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
eNFA0_2_53877004[["εNFA0-2 regex start"]]
eNFA0_0_15130994[["εNFA0-0 char{1, 1}"]]
eNFA0_1_1961226[["εNFA0-1 char[1]"]]
eNFA0_3_17651035[["εNFA0-3 regex end"]]
eNFA0_2_53877004 -.->|"ε"|eNFA0_0_15130994
eNFA0_0_15130994 -->|"|"|eNFA0_1_1961226
eNFA0_1_1961226 -.->|"ε"|eNFA0_3_17651035
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
eNFA0_4_24641592[["εNFA0-4 post-regex start"]]
eNFA0_5_20447736[\"εNFA0-5 post-regex end"/]
eNFA0_4_24641592 -.->|"ε"|eNFA0_5_20447736
```


## 'empty'
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
eNFA0_10_28383289[["εNFA0-10 regex start"]]
eNFA0_0_54123011[["εNFA0-0 char{1, 1}"]]
eNFA0_1_17345059[["εNFA0-1 char[1]"]]
eNFA0_2_21887809[["εNFA0-2 char{1, 1}"]]
eNFA0_3_62772558[["εNFA0-3 char[1]"]]
eNFA0_4_28082115[["εNFA0-4 char{1, 1}"]]
eNFA0_5_51412450[["εNFA0-5 char[1]"]]
eNFA0_6_60058866[["εNFA0-6 char{1, 1}"]]
eNFA0_7_3658885[["εNFA0-7 char[1]"]]
eNFA0_8_32929973[["εNFA0-8 char{1, 1}"]]
eNFA0_9_27934306[["εNFA0-9 char[1]"]]
eNFA0_11_50082165[["εNFA0-11 regex end"]]
eNFA0_10_28383289 -.->|"ε"|eNFA0_0_54123011
eNFA0_0_54123011 -->|"e"|eNFA0_1_17345059
eNFA0_1_17345059 -.->|"ε"|eNFA0_2_21887809
eNFA0_2_21887809 -->|"m"|eNFA0_3_62772558
eNFA0_3_62772558 -.->|"ε"|eNFA0_4_28082115
eNFA0_4_28082115 -->|"p"|eNFA0_5_51412450
eNFA0_5_51412450 -.->|"ε"|eNFA0_6_60058866
eNFA0_6_60058866 -->|"t"|eNFA0_7_3658885
eNFA0_7_3658885 -.->|"ε"|eNFA0_8_32929973
eNFA0_8_32929973 -->|"y"|eNFA0_9_27934306
eNFA0_9_27934306 -.->|"ε"|eNFA0_11_50082165
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
eNFA0_12_48086303[["εNFA0-12 post-regex start"]]
eNFA0_13_30123545[\"εNFA0-13 post-regex end"/]
eNFA0_12_48086303 -.->|"ε"|eNFA0_13_30123545
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
eNFA0_0_1696799[["εNFA0-0 wholeStart"]]
eNFA1_3_45556911[["εNFA1-3 regex start"]]
class eNFA1_3_45556911 c1000;
eNFA2_20_15271196[["εNFA2-20 regex start"]]
class eNFA2_20_15271196 c1000;
eNFA3_16_43516128[["εNFA3-16 regex start"]]
class eNFA3_16_43516128 c1000;
eNFA4_2_3616273[["εNFA4-2 regex start"]]
class eNFA4_2_3616273 c1000;
eNFA5_2_39492694[["εNFA5-2 regex start"]]
class eNFA5_2_39492694 c1000;
eNFA6_2_8419432[["εNFA6-2 regex start"]]
class eNFA6_2_8419432 c1000;
eNFA7_10_15221630[["εNFA7-10 regex start"]]
class eNFA7_10_15221630 c1000;
eNFA1_0_7359018[["εNFA1-0 scope{1, 1}"]]
eNFA2_0_59739484[["εNFA2-0 char{1, 1}"]]
eNFA3_0_35145507[["εNFA3-0 scope{2, 2}"]]
eNFA4_0_24482701[["εNFA4-0 char{1, 1}"]]
eNFA5_0_44791668[["εNFA5-0 char{1, 1}"]]
eNFA6_0_10885391[["εNFA6-0 char{1, 1}"]]
eNFA7_0_24992535[["εNFA7-0 char{1, 1}"]]
eNFA1_1_38673637[["εNFA1-1 scope[1]"]]
eNFA2_1_54905292[["εNFA2-1 char[1]"]]
eNFA3_1_24385580[["εNFA3-1 scope[1]"]]
eNFA4_1_19017721[["εNFA4-1 char[1]"]]
eNFA5_1_471829[["εNFA5-1 char[1]"]]
eNFA6_1_30859658[["εNFA6-1 char[1]"]]
eNFA7_1_18143631[["εNFA7-1 char[1]"]]
eNFA1_2_41579773[["εNFA1-2 scope{0, ∞}"]]
eNFA2_4_63124152[["εNFA2-4 regex start"]]
eNFA3_2_29074959[["εNFA3-2 scope[2]"]]
eNFA4_3_36941761[["εNFA4-3 regex end"]]
class eNFA4_3_36941761 c0100;
eNFA5_3_4246466[["εNFA5-3 regex end"]]
class eNFA5_3_4246466 c0100;
eNFA6_3_9301470[["εNFA6-3 regex end"]]
class eNFA6_3_9301470 c0100;
eNFA7_2_60348044[["εNFA7-2 char{1, 1}"]]
eNFA1_4_12518419[["εNFA1-4 regex end"]]
class eNFA1_4_12518419 c0100;
eNFA2_2_12782663[["εNFA2-2 scope{1, 1}"]]
eNFA2_6_31246457[["εNFA2-6 char{1, 1}"]]
eNFA2_10_47935106[["εNFA2-10 scope{1, 1}"]]
eNFA2_12_28762771[["εNFA2-12 char{1, 1}"]]
eNFA2_16_57538347[["εNFA2-16 scope{1, 1}"]]
eNFA3_3_54160705[["εNFA3-3 scope{1, 1}"]]
eNFA4_4_64040400[["εNFA4-4 post-regex start"]]
class eNFA4_4_64040400 c0010;
eNFA5_4_38218194[["εNFA5-4 post-regex start"]]
class eNFA5_4_38218194 c0010;
eNFA6_4_16604373[["εNFA6-4 post-regex start"]]
class eNFA6_4_16604373 c0010;
eNFA7_3_17684305[["εNFA7-3 char[1]"]]
eNFA1_5_66231165[["εNFA1-5 post-regex start"]]
class eNFA1_5_66231165 c0010;
eNFA2_3_2414975[["εNFA2-3 scope[1]"]]
eNFA2_7_24941017[["εNFA2-7 char[1]"]]
eNFA2_11_48083075[["εNFA2-11 scope[1]"]]
eNFA2_13_23142563[["εNFA2-13 char[1]"]]
eNFA2_17_21734782[["εNFA2-17 scope[1]"]]
eNFA3_4_20279421[["εNFA3-4 scope[1]"]]
eNFA4_5_32546461[\"εNFA4-5 post-regex end"/]
class eNFA4_5_32546461 c0001;
eNFA5_5_19889932[\"εNFA5-5 post-regex end"/]
class eNFA5_5_19889932 c0001;
eNFA6_5_8666028[\"εNFA6-5 post-regex end"/]
class eNFA6_5_8666028 c0001;
eNFA7_4_6956481[["εNFA7-4 char{1, 1}"]]
eNFA1_6_59209577[\"εNFA1-6 post-regex end"/]
class eNFA1_6_59209577 c0001;
eNFA2_5_30094492[["εNFA2-5 regex end"]]
eNFA2_8_62608330[["εNFA2-8 char{1, 1}"]]
eNFA2_14_67010998[["εNFA2-14 char{1, 1}"]]
eNFA3_7_34994620[["εNFA3-7 regex start"]]
eNFA0_1_29007341[\"εNFA0-1 wholeEnd"/]
eNFA7_5_66823354[["εNFA7-5 char[1]"]]
eNFA2_4_61395312[["εNFA2-4 regex start"]]
eNFA2_9_65709578[["εNFA2-9 char[1]"]]
eNFA2_15_54515298[["εNFA2-15 char[1]"]]
eNFA3_5_15991948[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_46516125[["εNFA3-9 char{1, 1}"]]
eNFA3_8_9709809[["εNFA3-8 regex end"]]
eNFA7_6_1489062[["εNFA7-6 char{1, 1}"]]
eNFA2_2_6964414[["εNFA2-2 scope{1, 1}"]]
eNFA2_6_15686904[["εNFA2-6 char{1, 1}"]]
eNFA2_10_62679731[["εNFA2-10 scope{1, 1}"]]
eNFA2_12_27246672[["εNFA2-12 char{1, 1}"]]
eNFA2_16_43893463[["εNFA2-16 scope{1, 1}"]]
eNFA2_5_59496847[["εNFA2-5 regex end"]]
eNFA3_6_32020406[["εNFA3-6 scope[1]"]]
eNFA3_10_28566697[["εNFA3-10 char[1]"]]
eNFA3_13_48297065[["εNFA3-13 scope{2, 2}"]]
eNFA7_7_21374547[["εNFA7-7 char[1]"]]
eNFA2_3_53663026[["εNFA2-3 scope[1]"]]
eNFA2_7_58153202[["εNFA2-7 char[1]"]]
eNFA2_11_13205188[["εNFA2-11 scope[1]"]]
eNFA2_13_53616771[["εNFA2-13 char[1]"]]
eNFA2_17_51737830[["εNFA2-17 scope[1]"]]
eNFA2_18_20875639[["εNFA2-18 char{1, 1}"]]
eNFA3_11_29267725[["εNFA3-11 scope{1, 1}"]]
eNFA3_14_62082933[["εNFA3-14 scope[1]"]]
eNFA7_8_21875485[["εNFA7-8 char{1, 1}"]]
eNFA2_8_27083833[["εNFA2-8 char{1, 1}"]]
eNFA2_14_46306890[["εNFA2-14 char{1, 1}"]]
eNFA2_19_784452[["εNFA2-19 char[1]"]]
eNFA3_12_19748206[["εNFA3-12 scope[1]"]]
eNFA3_15_47874109[["εNFA3-15 scope[2]"]]
eNFA7_9_23606224[["εNFA7-9 char[1]"]]
eNFA2_9_62987289[["εNFA2-9 char[1]"]]
eNFA2_15_30014695[["εNFA2-15 char[1]"]]
eNFA2_21_7060068[["εNFA2-21 regex end"]]
class eNFA2_21_7060068 c0100;
eNFA3_17_28213798[["εNFA3-17 regex end"]]
class eNFA3_17_28213798 c0100;
eNFA7_11_11129424[["εNFA7-11 regex end"]]
class eNFA7_11_11129424 c0100;
eNFA2_22_63540614[["εNFA2-22 post-regex start"]]
class eNFA2_22_63540614 c0010;
eNFA3_18_52597591[["εNFA3-18 post-regex start"]]
class eNFA3_18_52597591 c0010;
eNFA7_12_33055952[["εNFA7-12 post-regex start"]]
class eNFA7_12_33055952 c0010;
eNFA2_23_3223037[\"εNFA2-23 post-regex end"/]
class eNFA2_23_3223037 c0001;
eNFA3_19_56100839[\"εNFA3-19 post-regex end"/]
class eNFA3_19_56100839 c0001;
eNFA7_13_2776948[\"εNFA7-13 post-regex end"/]
class eNFA7_13_2776948 c0001;
eNFA0_0_1696799 -.->|"ε"|eNFA1_3_45556911
eNFA0_0_1696799 -.->|"ε"|eNFA2_20_15271196
eNFA0_0_1696799 -.->|"ε"|eNFA3_16_43516128
eNFA0_0_1696799 -.->|"ε"|eNFA4_2_3616273
eNFA0_0_1696799 -.->|"ε"|eNFA5_2_39492694
eNFA0_0_1696799 -.->|"ε"|eNFA6_2_8419432
eNFA0_0_1696799 -.->|"ε"|eNFA7_10_15221630
eNFA1_3_45556911 -.->|"ε
BeginToken 'Vn'"|eNFA1_0_7359018
eNFA2_20_15271196 -.->|"ε
BeginToken 'Vt'"|eNFA2_0_59739484
eNFA3_16_43516128 -.->|"ε
BeginToken 'pattern'"|eNFA3_0_35145507
eNFA4_2_3616273 -.->|"ε
BeginToken ':'"|eNFA4_0_24482701
eNFA5_2_39492694 -.->|"ε
BeginToken ';'"|eNFA5_0_44791668
eNFA6_2_8419432 -.->|"ε
BeginToken '|'"|eNFA6_0_10885391
eNFA7_10_15221630 -.->|"ε
BeginToken 'empty'"|eNFA7_0_24992535
eNFA1_0_7359018 -->|"[a-zA-Z_]"|eNFA1_1_38673637
eNFA2_0_59739484 -->|"'"|eNFA2_1_54905292
eNFA3_0_35145507 -->|"[%]"|eNFA3_1_24385580
eNFA4_0_24482701 -->|":"|eNFA4_1_19017721
eNFA5_0_44791668 -->|";"|eNFA5_1_471829
eNFA6_0_10885391 -->|"|"|eNFA6_1_30859658
eNFA7_0_24992535 -->|"e"|eNFA7_1_18143631
eNFA1_1_38673637 -.->|"ε"|eNFA1_2_41579773
eNFA2_1_54905292 -.->|"ε"|eNFA2_4_63124152
eNFA3_1_24385580 -->|"[%]"|eNFA3_2_29074959
eNFA4_1_19017721 -.->|"ε
ExtendToken ':'"|eNFA4_3_36941761
eNFA5_1_471829 -.->|"ε
ExtendToken ';'"|eNFA5_3_4246466
eNFA6_1_30859658 -.->|"ε
ExtendToken '|'"|eNFA6_3_9301470
eNFA7_1_18143631 -.->|"ε"|eNFA7_2_60348044
eNFA1_2_41579773 -->|"[a-zA-Z0-9_]"|eNFA1_2_41579773
eNFA1_2_41579773 -.->|"ε
ExtendToken 'Vn'"|eNFA1_4_12518419
eNFA2_4_63124152 -.->|"ε"|eNFA2_2_12782663
eNFA2_4_63124152 -.->|"ε"|eNFA2_6_31246457
eNFA2_4_63124152 -.->|"ε"|eNFA2_10_47935106
eNFA2_4_63124152 -.->|"ε"|eNFA2_12_28762771
eNFA2_4_63124152 -.->|"ε"|eNFA2_16_57538347
eNFA3_2_29074959 -.->|"ε"|eNFA3_3_54160705
eNFA4_3_36941761 -.->|"ε"|eNFA4_4_64040400
eNFA5_3_4246466 -.->|"ε"|eNFA5_4_38218194
eNFA6_3_9301470 -.->|"ε"|eNFA6_4_16604373
eNFA7_2_60348044 -->|"m"|eNFA7_3_17684305
eNFA1_4_12518419 -.->|"ε"|eNFA1_5_66231165
eNFA2_2_12782663 -->|"[#32;-&]"|eNFA2_3_2414975
eNFA2_6_31246457 -->|"#92;"|eNFA2_7_24941017
eNFA2_10_47935106 -->|"[(-[]"|eNFA2_11_48083075
eNFA2_12_28762771 -->|"#92;"|eNFA2_13_23142563
eNFA2_16_57538347 -->|"[]-~]"|eNFA2_17_21734782
eNFA3_3_54160705 -->|"[#32;-~]"|eNFA3_4_20279421
eNFA4_4_64040400 -.->|"ε
CheckToken ':'
AcceptToken ':'"|eNFA4_5_32546461
eNFA5_4_38218194 -.->|"ε
CheckToken ';'
AcceptToken ';'"|eNFA5_5_19889932
eNFA6_4_16604373 -.->|"ε
CheckToken '|'
AcceptToken '|'"|eNFA6_5_8666028
eNFA7_3_17684305 -.->|"ε"|eNFA7_4_6956481
eNFA1_5_66231165 -.->|"ε
CheckToken 'Vn'
AcceptToken 'Vn'"|eNFA1_6_59209577
eNFA2_3_2414975 -.->|"ε"|eNFA2_5_30094492
eNFA2_7_24941017 -.->|"ε"|eNFA2_8_62608330
eNFA2_11_48083075 -.->|"ε"|eNFA2_5_30094492
eNFA2_13_23142563 -.->|"ε"|eNFA2_14_67010998
eNFA2_17_21734782 -.->|"ε"|eNFA2_5_30094492
eNFA3_4_20279421 -.->|"ε"|eNFA3_7_34994620
eNFA4_5_32546461 -.->|"ε"|eNFA0_1_29007341
eNFA5_5_19889932 -.->|"ε"|eNFA0_1_29007341
eNFA6_5_8666028 -.->|"ε"|eNFA0_1_29007341
eNFA7_4_6956481 -->|"p"|eNFA7_5_66823354
eNFA1_6_59209577 -.->|"ε"|eNFA0_1_29007341
eNFA2_5_30094492 -.->|"ε"|eNFA2_4_61395312
eNFA2_8_62608330 -->|"'"|eNFA2_9_65709578
eNFA2_14_67010998 -->|"#92;"|eNFA2_15_54515298
eNFA3_7_34994620 -.->|"ε"|eNFA3_5_15991948
eNFA3_7_34994620 -.->|"ε"|eNFA3_9_46516125
eNFA3_7_34994620 -.->|"ε"|eNFA3_8_9709809
eNFA7_5_66823354 -.->|"ε"|eNFA7_6_1489062
eNFA2_4_61395312 -.->|"ε"|eNFA2_2_6964414
eNFA2_4_61395312 -.->|"ε"|eNFA2_6_15686904
eNFA2_4_61395312 -.->|"ε"|eNFA2_10_62679731
eNFA2_4_61395312 -.->|"ε"|eNFA2_12_27246672
eNFA2_4_61395312 -.->|"ε"|eNFA2_16_43893463
eNFA2_4_61395312 -.->|"ε"|eNFA2_5_59496847
eNFA2_9_65709578 -.->|"ε"|eNFA2_5_30094492
eNFA2_15_54515298 -.->|"ε"|eNFA2_5_30094492
eNFA3_5_15991948 -->|"[^%]"|eNFA3_6_32020406
eNFA3_9_46516125 -->|"%"|eNFA3_10_28566697
eNFA3_8_9709809 -.->|"ε"|eNFA3_7_34994620
eNFA3_8_9709809 -.->|"ε"|eNFA3_13_48297065
eNFA7_6_1489062 -->|"t"|eNFA7_7_21374547
eNFA2_2_6964414 -->|"[#32;-&]"|eNFA2_3_53663026
eNFA2_6_15686904 -->|"#92;"|eNFA2_7_58153202
eNFA2_10_62679731 -->|"[(-[]"|eNFA2_11_13205188
eNFA2_12_27246672 -->|"#92;"|eNFA2_13_53616771
eNFA2_16_43893463 -->|"[]-~]"|eNFA2_17_51737830
eNFA2_5_59496847 -.->|"ε"|eNFA2_4_61395312
eNFA2_5_59496847 -.->|"ε"|eNFA2_18_20875639
eNFA3_6_32020406 -.->|"ε"|eNFA3_8_9709809
eNFA3_10_28566697 -.->|"ε"|eNFA3_11_29267725
eNFA3_13_48297065 -->|"[%]"|eNFA3_14_62082933
eNFA7_7_21374547 -.->|"ε"|eNFA7_8_21875485
eNFA2_3_53663026 -.->|"ε"|eNFA2_5_59496847
eNFA2_7_58153202 -.->|"ε"|eNFA2_8_27083833
eNFA2_11_13205188 -.->|"ε"|eNFA2_5_59496847
eNFA2_13_53616771 -.->|"ε"|eNFA2_14_46306890
eNFA2_17_51737830 -.->|"ε"|eNFA2_5_59496847
eNFA2_18_20875639 -->|"'"|eNFA2_19_784452
eNFA3_11_29267725 -->|"[^%]"|eNFA3_12_19748206
eNFA3_14_62082933 -->|"[%]"|eNFA3_15_47874109
eNFA7_8_21875485 -->|"y"|eNFA7_9_23606224
eNFA2_8_27083833 -->|"'"|eNFA2_9_62987289
eNFA2_14_46306890 -->|"#92;"|eNFA2_15_30014695
eNFA2_19_784452 -.->|"ε
ExtendToken 'Vt'"|eNFA2_21_7060068
eNFA3_12_19748206 -.->|"ε"|eNFA3_8_9709809
eNFA3_15_47874109 -.->|"ε
ExtendToken 'pattern'"|eNFA3_17_28213798
eNFA7_9_23606224 -.->|"ε
ExtendToken 'empty'"|eNFA7_11_11129424
eNFA2_9_62987289 -.->|"ε"|eNFA2_5_59496847
eNFA2_15_30014695 -.->|"ε"|eNFA2_5_59496847
eNFA2_21_7060068 -.->|"ε"|eNFA2_22_63540614
eNFA3_17_28213798 -.->|"ε"|eNFA3_18_52597591
eNFA7_11_11129424 -.->|"ε"|eNFA7_12_33055952
eNFA2_22_63540614 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA2_23_3223037
eNFA3_18_52597591 -.->|"ε
CheckToken 'pattern'
AcceptToken 'pattern'"|eNFA3_19_56100839
eNFA7_12_33055952 -.->|"ε
CheckToken 'empty'
AcceptToken 'empty'"|eNFA7_13_2776948
eNFA2_23_3223037 -.->|"ε"|eNFA0_1_29007341
eNFA3_19_56100839 -.->|"ε"|eNFA0_1_29007341
eNFA7_13_2776948 -.->|"ε"|eNFA0_1_29007341

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
eNFA0_0_29068113[["εNFA0-0 wholeStart"]]
class eNFA0_0_29068113 c1000;
eNFA1_3_5706947[["εNFA1-3 regex start"]]
class eNFA1_3_5706947 c1000;
eNFA2_20_60286428[["εNFA2-20 regex start"]]
class eNFA2_20_60286428 c1000;
eNFA3_16_51362525[["εNFA3-16 regex start"]]
class eNFA3_16_51362525 c1000;
eNFA4_2_59609549[["εNFA4-2 regex start"]]
class eNFA4_2_59609549 c1000;
eNFA5_2_66723899[["εNFA5-2 regex start"]]
class eNFA5_2_66723899 c1000;
eNFA6_2_63644184[["εNFA6-2 regex start"]]
class eNFA6_2_63644184 c1000;
eNFA7_10_35926749[["εNFA7-10 regex start"]]
class eNFA7_10_35926749 c1000;
eNFA1_0_62777276[["εNFA1-0 scope{1, 1}"]]
class eNFA1_0_62777276 c1000;
eNFA2_0_51794604[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_51794604 c1000;
eNFA3_0_52220065[["εNFA3-0 scope{2, 2}"]]
class eNFA3_0_52220065 c1000;
eNFA4_0_25096167[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_25096167 c1000;
eNFA5_0_37914048[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_37914048 c1000;
eNFA6_0_48623467[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_48623467 c1000;
eNFA7_0_50139688[["εNFA7-0 char{1, 1}"]]
class eNFA7_0_50139688 c1000;
eNFA1_1_56353385[\"εNFA1-1 scope[1]
AcceptToken 'Vn'"/]
class eNFA1_1_56353385 c0111;
eNFA2_1_65952567[["εNFA2-1 char[1]"]]
eNFA3_1_56702192[["εNFA3-1 scope[1]"]]
eNFA4_1_24538918[\"εNFA4-1 char[1]
AcceptToken ':'"/]
class eNFA4_1_24538918 c0111;
eNFA5_1_5682118[\"εNFA5-1 char[1]
AcceptToken ';'"/]
class eNFA5_1_5682118 c0111;
eNFA6_1_34958023[\"εNFA6-1 char[1]
AcceptToken '|'"/]
class eNFA6_1_34958023 c0111;
eNFA7_1_29474811[["εNFA7-1 char[1]"]]
eNFA1_2_6261487[\"εNFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class eNFA1_2_6261487 c0111;
eNFA1_4_37418419[\"εNFA1-4 regex end
AcceptToken 'Vn'"/]
class eNFA1_4_37418419 c0111;
eNFA1_5_28124577[\"εNFA1-5 post-regex start
AcceptToken 'Vn'"/]
class eNFA1_5_28124577 c0011;
eNFA1_6_64539275[\"εNFA1-6 post-regex end"/]
class eNFA1_6_64539275 c0011;
eNFA0_1_62873893[\"εNFA0-1 wholeEnd"/]
eNFA2_4_1221454[["εNFA2-4 regex start"]]
eNFA2_2_31828964[["εNFA2-2 scope{1, 1}"]]
eNFA2_6_10993092[["εNFA2-6 char{1, 1}"]]
eNFA2_10_18025225[["εNFA2-10 scope{1, 1}"]]
eNFA2_12_28009298[["εNFA2-12 char{1, 1}"]]
eNFA2_16_50757098[["εNFA2-16 scope{1, 1}"]]
eNFA2_3_7445666[["εNFA2-3 scope[1]"]]
eNFA2_7_42919078[["εNFA2-7 char[1]"]]
eNFA2_11_26604065[["εNFA2-11 scope[1]"]]
eNFA2_13_53893327[["εNFA2-13 char[1]"]]
eNFA2_17_66228075[["εNFA2-17 scope[1]"]]
eNFA3_2_12301139[["εNFA3-2 scope[2]"]]
eNFA4_3_19523678[\"εNFA4-3 regex end
AcceptToken ':'"/]
class eNFA4_3_19523678 c0111;
eNFA4_4_41495374[\"εNFA4-4 post-regex start
AcceptToken ':'"/]
class eNFA4_4_41495374 c0011;
eNFA4_5_28994132[\"εNFA4-5 post-regex end"/]
class eNFA4_5_28994132 c0011;
eNFA5_3_51139063[\"εNFA5-3 regex end
AcceptToken ';'"/]
class eNFA5_3_51139063 c0111;
eNFA5_4_57598390[\"εNFA5-4 post-regex start
AcceptToken ';'"/]
class eNFA5_4_57598390 c0011;
eNFA5_5_59181771[\"εNFA5-5 post-regex end"/]
class eNFA5_5_59181771 c0011;
eNFA6_3_46186755[\"εNFA6-3 regex end
AcceptToken '|'"/]
class eNFA6_3_46186755 c0111;
eNFA6_4_13027616[\"εNFA6-4 post-regex start
AcceptToken '|'"/]
class eNFA6_4_13027616 c0011;
eNFA6_5_59620600[\"εNFA6-5 post-regex end"/]
class eNFA6_5_59620600 c0011;
eNFA7_2_38649495[["εNFA7-2 char{1, 1}"]]
eNFA7_3_56868170[["εNFA7-3 char[1]"]]
eNFA2_5_38109998[["εNFA2-5 regex end"]]
eNFA2_4_13401558[["εNFA2-4 regex start"]]
eNFA2_2_11784443[["εNFA2-2 scope{1, 1}"]]
eNFA2_6_53505165[["εNFA2-6 char{1, 1}"]]
eNFA2_10_38951129[["εNFA2-10 scope{1, 1}"]]
eNFA2_12_15015849[["εNFA2-12 char{1, 1}"]]
eNFA2_16_924914[["εNFA2-16 scope{1, 1}"]]
eNFA2_5_8324231[["εNFA2-5 regex end"]]
eNFA2_3_62661638[["εNFA2-3 scope[1]"]]
eNFA2_7_2367688[["εNFA2-7 char[1]"]]
eNFA2_11_42427912[["εNFA2-11 scope[1]"]]
eNFA2_13_57565064[["εNFA2-13 char[1]"]]
eNFA2_17_14108834[["εNFA2-17 scope[1]"]]
eNFA2_18_12788897[["εNFA2-18 char{1, 1}"]]
eNFA2_19_63498254[\"εNFA2-19 char[1]
AcceptToken 'Vt'"/]
class eNFA2_19_63498254 c0111;
eNFA2_8_50727390[["εNFA2-8 char{1, 1}"]]
eNFA2_9_7809215[["εNFA2-9 char[1]"]]
eNFA2_14_15277900[["εNFA2-14 char{1, 1}"]]
eNFA2_15_3174077[["εNFA2-15 char[1]"]]
eNFA3_3_43601387[["εNFA3-3 scope{1, 1}"]]
eNFA3_4_55773684[["εNFA3-4 scope[1]"]]
eNFA7_4_42051488[["εNFA7-4 char{1, 1}"]]
eNFA7_5_3283372[["εNFA7-5 char[1]"]]
eNFA2_8_21309199[["εNFA2-8 char{1, 1}"]]
eNFA2_9_1964925[["εNFA2-9 char[1]"]]
eNFA2_14_48323534[["εNFA2-14 char{1, 1}"]]
eNFA2_15_17684330[["εNFA2-15 char[1]"]]
eNFA2_21_34613376[\"εNFA2-21 regex end
AcceptToken 'Vt'"/]
class eNFA2_21_34613376 c0111;
eNFA2_22_43084931[\"εNFA2-22 post-regex start
AcceptToken 'Vt'"/]
class eNFA2_22_43084931 c0011;
eNFA2_23_24941249[\"εNFA2-23 post-regex end"/]
class eNFA2_23_24941249 c0011;
eNFA3_7_43982564[["εNFA3-7 regex start"]]
eNFA3_5_5817914[["εNFA3-5 scope{1, 1}"]]
eNFA3_9_60298758[["εNFA3-9 char{1, 1}"]]
eNFA3_8_52361234[["εNFA3-8 regex end"]]
eNFA3_6_47991212[["εNFA3-6 scope[1]"]]
eNFA3_10_64626598[["εNFA3-10 char[1]"]]
eNFA3_13_32201111[["εNFA3-13 scope{2, 2}"]]
eNFA3_14_40557681[["εNFA3-14 scope[1]"]]
eNFA7_6_29550354[["εNFA7-6 char{1, 1}"]]
eNFA7_7_263076[["εNFA7-7 char[1]"]]
eNFA3_11_44768473[["εNFA3-11 scope{1, 1}"]]
eNFA3_12_59870648[["εNFA3-12 scope[1]"]]
eNFA3_15_218537[\"εNFA3-15 scope[2]
AcceptToken 'pattern'"/]
class eNFA3_15_218537 c0111;
eNFA7_8_63946711[["εNFA7-8 char{1, 1}"]]
eNFA7_9_48604010[\"εNFA7-9 char[1]
AcceptToken 'empty'"/]
class eNFA7_9_48604010 c0111;
eNFA3_17_1966838[\"εNFA3-17 regex end
AcceptToken 'pattern'"/]
class eNFA3_17_1966838 c0111;
eNFA3_18_17701543[\"εNFA3-18 post-regex start
AcceptToken 'pattern'"/]
class eNFA3_18_17701543 c0011;
eNFA3_19_23144649[\"εNFA3-19 post-regex end"/]
class eNFA3_19_23144649 c0011;
eNFA7_11_34782913[\"εNFA7-11 regex end
AcceptToken 'empty'"/]
class eNFA7_11_34782913 c0111;
eNFA7_12_44610765[\"εNFA7-12 post-regex start
AcceptToken 'empty'"/]
class eNFA7_12_44610765 c0011;
eNFA7_13_6975252[\"εNFA7-13 post-regex end"/]
class eNFA7_13_6975252 c0011;
eNFA0_0_29068113 -.->|"ε"|eNFA1_3_5706947
eNFA0_0_29068113 -.->|"ε"|eNFA2_20_60286428
eNFA0_0_29068113 -.->|"ε"|eNFA3_16_51362525
eNFA0_0_29068113 -.->|"ε"|eNFA4_2_59609549
eNFA0_0_29068113 -.->|"ε"|eNFA5_2_66723899
eNFA0_0_29068113 -.->|"ε"|eNFA6_2_63644184
eNFA0_0_29068113 -.->|"ε"|eNFA7_10_35926749
eNFA0_0_29068113 -.->|"ε
BeginToken 'Vn'"|eNFA1_0_62777276
eNFA0_0_29068113 -.->|"ε
BeginToken 'Vt'"|eNFA2_0_51794604
eNFA0_0_29068113 -.->|"ε
BeginToken 'pattern'"|eNFA3_0_52220065
eNFA0_0_29068113 -.->|"ε
BeginToken ':'"|eNFA4_0_25096167
eNFA0_0_29068113 -.->|"ε
BeginToken ';'"|eNFA5_0_37914048
eNFA0_0_29068113 -.->|"ε
BeginToken '|'"|eNFA6_0_48623467
eNFA0_0_29068113 -.->|"ε
BeginToken 'empty'"|eNFA7_0_50139688
eNFA0_0_29068113 -->|"[a-zA-Z_]
BeginToken 'Vn'
ExtendToken 'Vn'"|eNFA1_1_56353385
eNFA0_0_29068113 -->|"'
BeginToken 'Vt'"|eNFA2_1_65952567
eNFA0_0_29068113 -->|"[%]
BeginToken 'pattern'"|eNFA3_1_56702192
eNFA0_0_29068113 -->|":
BeginToken ':'
ExtendToken ':'"|eNFA4_1_24538918
eNFA0_0_29068113 -->|";
BeginToken ';'
ExtendToken ';'"|eNFA5_1_5682118
eNFA0_0_29068113 -->|"|
BeginToken '|'
ExtendToken '|'"|eNFA6_1_34958023
eNFA0_0_29068113 -->|"e
BeginToken 'empty'"|eNFA7_1_29474811
eNFA1_3_5706947 -.->|"ε
BeginToken 'Vn'"|eNFA1_0_62777276
eNFA1_3_5706947 -->|"[a-zA-Z_]
BeginToken 'Vn'
ExtendToken 'Vn'"|eNFA1_1_56353385
eNFA2_20_60286428 -.->|"ε
BeginToken 'Vt'"|eNFA2_0_51794604
eNFA2_20_60286428 -->|"'
BeginToken 'Vt'"|eNFA2_1_65952567
eNFA3_16_51362525 -.->|"ε
BeginToken 'pattern'"|eNFA3_0_52220065
eNFA3_16_51362525 -->|"[%]
BeginToken 'pattern'"|eNFA3_1_56702192
eNFA4_2_59609549 -.->|"ε
BeginToken ':'"|eNFA4_0_25096167
eNFA4_2_59609549 -->|":
BeginToken ':'
ExtendToken ':'"|eNFA4_1_24538918
eNFA5_2_66723899 -.->|"ε
BeginToken ';'"|eNFA5_0_37914048
eNFA5_2_66723899 -->|";
BeginToken ';'
ExtendToken ';'"|eNFA5_1_5682118
eNFA6_2_63644184 -.->|"ε
BeginToken '|'"|eNFA6_0_48623467
eNFA6_2_63644184 -->|"|
BeginToken '|'
ExtendToken '|'"|eNFA6_1_34958023
eNFA7_10_35926749 -.->|"ε
BeginToken 'empty'"|eNFA7_0_50139688
eNFA7_10_35926749 -->|"e
BeginToken 'empty'"|eNFA7_1_29474811
eNFA1_0_62777276 -->|"[a-zA-Z_]
BeginToken 'Vn'
ExtendToken 'Vn'"|eNFA1_1_56353385
eNFA2_0_51794604 -->|"'
BeginToken 'Vt'"|eNFA2_1_65952567
eNFA3_0_52220065 -->|"[%]
BeginToken 'pattern'"|eNFA3_1_56702192
eNFA4_0_25096167 -->|":
BeginToken ':'
ExtendToken ':'"|eNFA4_1_24538918
eNFA5_0_37914048 -->|";
BeginToken ';'
ExtendToken ';'"|eNFA5_1_5682118
eNFA6_0_48623467 -->|"|
BeginToken '|'
ExtendToken '|'"|eNFA6_1_34958023
eNFA7_0_50139688 -->|"e
BeginToken 'empty'"|eNFA7_1_29474811
eNFA1_1_56353385 -.->|"ε
ExtendToken 'Vn'"|eNFA1_2_6261487
eNFA1_1_56353385 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|eNFA1_2_6261487
eNFA1_1_56353385 -.->|"ε
ExtendToken 'Vn'"|eNFA1_4_37418419
eNFA1_1_56353385 -.->|"ε"|eNFA1_5_28124577
eNFA1_1_56353385 -.->|"ε
CheckToken 'Vn'
AcceptToken 'Vn'"|eNFA1_6_64539275
eNFA1_1_56353385 -.->|"ε
CheckToken 'Vn'"|eNFA0_1_62873893
eNFA2_1_65952567 -.->|"ε"|eNFA2_4_1221454
eNFA2_1_65952567 -.->|"ε"|eNFA2_2_31828964
eNFA2_1_65952567 -.->|"ε"|eNFA2_6_10993092
eNFA2_1_65952567 -.->|"ε"|eNFA2_10_18025225
eNFA2_1_65952567 -.->|"ε"|eNFA2_12_28009298
eNFA2_1_65952567 -.->|"ε"|eNFA2_16_50757098
eNFA2_1_65952567 -->|"[#32;-&]"|eNFA2_3_7445666
eNFA2_1_65952567 -->|"#92;"|eNFA2_7_42919078
eNFA2_1_65952567 -->|"[(-[]"|eNFA2_11_26604065
eNFA2_1_65952567 -->|"#92;"|eNFA2_13_53893327
eNFA2_1_65952567 -->|"[]-~]"|eNFA2_17_66228075
eNFA3_1_56702192 -->|"[%]"|eNFA3_2_12301139
eNFA4_1_24538918 -.->|"ε
ExtendToken ':'"|eNFA4_3_19523678
eNFA4_1_24538918 -.->|"ε"|eNFA4_4_41495374
eNFA4_1_24538918 -.->|"ε
CheckToken ':'
AcceptToken ':'"|eNFA4_5_28994132
eNFA4_1_24538918 -.->|"ε
CheckToken ':'"|eNFA0_1_62873893
eNFA5_1_5682118 -.->|"ε
ExtendToken ';'"|eNFA5_3_51139063
eNFA5_1_5682118 -.->|"ε"|eNFA5_4_57598390
eNFA5_1_5682118 -.->|"ε
CheckToken ';'
AcceptToken ';'"|eNFA5_5_59181771
eNFA5_1_5682118 -.->|"ε
CheckToken ';'"|eNFA0_1_62873893
eNFA6_1_34958023 -.->|"ε
ExtendToken '|'"|eNFA6_3_46186755
eNFA6_1_34958023 -.->|"ε"|eNFA6_4_13027616
eNFA6_1_34958023 -.->|"ε
CheckToken '|'
AcceptToken '|'"|eNFA6_5_59620600
eNFA6_1_34958023 -.->|"ε
CheckToken '|'"|eNFA0_1_62873893
eNFA7_1_29474811 -.->|"ε"|eNFA7_2_38649495
eNFA7_1_29474811 -->|"m"|eNFA7_3_56868170
eNFA1_2_6261487 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|eNFA1_2_6261487
eNFA1_2_6261487 -.->|"ε
ExtendToken 'Vn'"|eNFA1_4_37418419
eNFA1_2_6261487 -.->|"ε"|eNFA1_5_28124577
eNFA1_2_6261487 -.->|"ε
CheckToken 'Vn'
AcceptToken 'Vn'"|eNFA1_6_64539275
eNFA1_2_6261487 -.->|"ε
CheckToken 'Vn'"|eNFA0_1_62873893
eNFA1_4_37418419 -.->|"ε"|eNFA1_5_28124577
eNFA1_4_37418419 -.->|"ε
CheckToken 'Vn'
AcceptToken 'Vn'"|eNFA1_6_64539275
eNFA1_4_37418419 -.->|"ε
CheckToken 'Vn'"|eNFA0_1_62873893
eNFA1_5_28124577 -.->|"ε
CheckToken 'Vn'
AcceptToken 'Vn'"|eNFA1_6_64539275
eNFA1_5_28124577 -.->|"ε
CheckToken 'Vn'"|eNFA0_1_62873893
eNFA1_6_64539275 -.->|"ε
CheckToken 'Vn'"|eNFA0_1_62873893
eNFA2_4_1221454 -.->|"ε"|eNFA2_2_31828964
eNFA2_4_1221454 -.->|"ε"|eNFA2_6_10993092
eNFA2_4_1221454 -.->|"ε"|eNFA2_10_18025225
eNFA2_4_1221454 -.->|"ε"|eNFA2_12_28009298
eNFA2_4_1221454 -.->|"ε"|eNFA2_16_50757098
eNFA2_4_1221454 -->|"[#32;-&]"|eNFA2_3_7445666
eNFA2_4_1221454 -->|"#92;"|eNFA2_7_42919078
eNFA2_4_1221454 -->|"[(-[]"|eNFA2_11_26604065
eNFA2_4_1221454 -->|"#92;"|eNFA2_13_53893327
eNFA2_4_1221454 -->|"[]-~]"|eNFA2_17_66228075
eNFA2_2_31828964 -->|"[#32;-&]"|eNFA2_3_7445666
eNFA2_6_10993092 -->|"#92;"|eNFA2_7_42919078
eNFA2_10_18025225 -->|"[(-[]"|eNFA2_11_26604065
eNFA2_12_28009298 -->|"#92;"|eNFA2_13_53893327
eNFA2_16_50757098 -->|"[]-~]"|eNFA2_17_66228075
eNFA2_3_7445666 -.->|"ε"|eNFA2_5_38109998
eNFA2_3_7445666 -.->|"ε"|eNFA2_4_13401558
eNFA2_3_7445666 -.->|"ε"|eNFA2_2_11784443
eNFA2_3_7445666 -.->|"ε"|eNFA2_6_53505165
eNFA2_3_7445666 -.->|"ε"|eNFA2_10_38951129
eNFA2_3_7445666 -.->|"ε"|eNFA2_12_15015849
eNFA2_3_7445666 -.->|"ε"|eNFA2_16_924914
eNFA2_3_7445666 -.->|"ε"|eNFA2_5_8324231
eNFA2_3_7445666 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_3_7445666 -->|"#92;"|eNFA2_7_2367688
eNFA2_3_7445666 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_3_7445666 -->|"#92;"|eNFA2_13_57565064
eNFA2_3_7445666 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_3_7445666 -.->|"ε"|eNFA2_18_12788897
eNFA2_3_7445666 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_7_42919078 -.->|"ε"|eNFA2_8_50727390
eNFA2_7_42919078 -->|"'"|eNFA2_9_7809215
eNFA2_11_26604065 -.->|"ε"|eNFA2_5_38109998
eNFA2_11_26604065 -.->|"ε"|eNFA2_4_13401558
eNFA2_11_26604065 -.->|"ε"|eNFA2_2_11784443
eNFA2_11_26604065 -.->|"ε"|eNFA2_6_53505165
eNFA2_11_26604065 -.->|"ε"|eNFA2_10_38951129
eNFA2_11_26604065 -.->|"ε"|eNFA2_12_15015849
eNFA2_11_26604065 -.->|"ε"|eNFA2_16_924914
eNFA2_11_26604065 -.->|"ε"|eNFA2_5_8324231
eNFA2_11_26604065 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_11_26604065 -->|"#92;"|eNFA2_7_2367688
eNFA2_11_26604065 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_11_26604065 -->|"#92;"|eNFA2_13_57565064
eNFA2_11_26604065 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_11_26604065 -.->|"ε"|eNFA2_18_12788897
eNFA2_11_26604065 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_13_53893327 -.->|"ε"|eNFA2_14_15277900
eNFA2_13_53893327 -->|"#92;"|eNFA2_15_3174077
eNFA2_17_66228075 -.->|"ε"|eNFA2_5_38109998
eNFA2_17_66228075 -.->|"ε"|eNFA2_4_13401558
eNFA2_17_66228075 -.->|"ε"|eNFA2_2_11784443
eNFA2_17_66228075 -.->|"ε"|eNFA2_6_53505165
eNFA2_17_66228075 -.->|"ε"|eNFA2_10_38951129
eNFA2_17_66228075 -.->|"ε"|eNFA2_12_15015849
eNFA2_17_66228075 -.->|"ε"|eNFA2_16_924914
eNFA2_17_66228075 -.->|"ε"|eNFA2_5_8324231
eNFA2_17_66228075 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_17_66228075 -->|"#92;"|eNFA2_7_2367688
eNFA2_17_66228075 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_17_66228075 -->|"#92;"|eNFA2_13_57565064
eNFA2_17_66228075 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_17_66228075 -.->|"ε"|eNFA2_18_12788897
eNFA2_17_66228075 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA3_2_12301139 -.->|"ε"|eNFA3_3_43601387
eNFA3_2_12301139 -->|"[#32;-~]"|eNFA3_4_55773684
eNFA4_3_19523678 -.->|"ε"|eNFA4_4_41495374
eNFA4_3_19523678 -.->|"ε
CheckToken ':'
AcceptToken ':'"|eNFA4_5_28994132
eNFA4_3_19523678 -.->|"ε
CheckToken ':'"|eNFA0_1_62873893
eNFA4_4_41495374 -.->|"ε
CheckToken ':'
AcceptToken ':'"|eNFA4_5_28994132
eNFA4_4_41495374 -.->|"ε
CheckToken ':'"|eNFA0_1_62873893
eNFA4_5_28994132 -.->|"ε
CheckToken ':'"|eNFA0_1_62873893
eNFA5_3_51139063 -.->|"ε"|eNFA5_4_57598390
eNFA5_3_51139063 -.->|"ε
CheckToken ';'
AcceptToken ';'"|eNFA5_5_59181771
eNFA5_3_51139063 -.->|"ε
CheckToken ';'"|eNFA0_1_62873893
eNFA5_4_57598390 -.->|"ε
CheckToken ';'
AcceptToken ';'"|eNFA5_5_59181771
eNFA5_4_57598390 -.->|"ε
CheckToken ';'"|eNFA0_1_62873893
eNFA5_5_59181771 -.->|"ε
CheckToken ';'"|eNFA0_1_62873893
eNFA6_3_46186755 -.->|"ε"|eNFA6_4_13027616
eNFA6_3_46186755 -.->|"ε
CheckToken '|'
AcceptToken '|'"|eNFA6_5_59620600
eNFA6_3_46186755 -.->|"ε
CheckToken '|'"|eNFA0_1_62873893
eNFA6_4_13027616 -.->|"ε
CheckToken '|'
AcceptToken '|'"|eNFA6_5_59620600
eNFA6_4_13027616 -.->|"ε
CheckToken '|'"|eNFA0_1_62873893
eNFA6_5_59620600 -.->|"ε
CheckToken '|'"|eNFA0_1_62873893
eNFA7_2_38649495 -->|"m"|eNFA7_3_56868170
eNFA7_3_56868170 -.->|"ε"|eNFA7_4_42051488
eNFA7_3_56868170 -->|"p"|eNFA7_5_3283372
eNFA2_5_38109998 -.->|"ε"|eNFA2_4_13401558
eNFA2_5_38109998 -.->|"ε"|eNFA2_2_11784443
eNFA2_5_38109998 -.->|"ε"|eNFA2_6_53505165
eNFA2_5_38109998 -.->|"ε"|eNFA2_10_38951129
eNFA2_5_38109998 -.->|"ε"|eNFA2_12_15015849
eNFA2_5_38109998 -.->|"ε"|eNFA2_16_924914
eNFA2_5_38109998 -.->|"ε"|eNFA2_5_8324231
eNFA2_5_38109998 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_5_38109998 -->|"#92;"|eNFA2_7_2367688
eNFA2_5_38109998 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_5_38109998 -->|"#92;"|eNFA2_13_57565064
eNFA2_5_38109998 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_5_38109998 -.->|"ε"|eNFA2_18_12788897
eNFA2_5_38109998 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_4_13401558 -.->|"ε"|eNFA2_2_11784443
eNFA2_4_13401558 -.->|"ε"|eNFA2_6_53505165
eNFA2_4_13401558 -.->|"ε"|eNFA2_10_38951129
eNFA2_4_13401558 -.->|"ε"|eNFA2_12_15015849
eNFA2_4_13401558 -.->|"ε"|eNFA2_16_924914
eNFA2_4_13401558 -.->|"ε"|eNFA2_5_8324231
eNFA2_4_13401558 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_4_13401558 -->|"#92;"|eNFA2_7_2367688
eNFA2_4_13401558 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_4_13401558 -->|"#92;"|eNFA2_13_57565064
eNFA2_4_13401558 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_4_13401558 -.->|"ε"|eNFA2_4_13401558
eNFA2_4_13401558 -.->|"ε"|eNFA2_18_12788897
eNFA2_4_13401558 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_2_11784443 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_6_53505165 -->|"#92;"|eNFA2_7_2367688
eNFA2_10_38951129 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_12_15015849 -->|"#92;"|eNFA2_13_57565064
eNFA2_16_924914 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_5_8324231 -.->|"ε"|eNFA2_4_13401558
eNFA2_5_8324231 -.->|"ε"|eNFA2_18_12788897
eNFA2_5_8324231 -.->|"ε"|eNFA2_2_11784443
eNFA2_5_8324231 -.->|"ε"|eNFA2_6_53505165
eNFA2_5_8324231 -.->|"ε"|eNFA2_10_38951129
eNFA2_5_8324231 -.->|"ε"|eNFA2_12_15015849
eNFA2_5_8324231 -.->|"ε"|eNFA2_16_924914
eNFA2_5_8324231 -.->|"ε"|eNFA2_5_8324231
eNFA2_5_8324231 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_5_8324231 -->|"#92;"|eNFA2_7_2367688
eNFA2_5_8324231 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_5_8324231 -->|"#92;"|eNFA2_13_57565064
eNFA2_5_8324231 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_5_8324231 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_3_62661638 -.->|"ε"|eNFA2_5_8324231
eNFA2_3_62661638 -.->|"ε"|eNFA2_4_13401558
eNFA2_3_62661638 -.->|"ε"|eNFA2_18_12788897
eNFA2_3_62661638 -.->|"ε"|eNFA2_2_11784443
eNFA2_3_62661638 -.->|"ε"|eNFA2_6_53505165
eNFA2_3_62661638 -.->|"ε"|eNFA2_10_38951129
eNFA2_3_62661638 -.->|"ε"|eNFA2_12_15015849
eNFA2_3_62661638 -.->|"ε"|eNFA2_16_924914
eNFA2_3_62661638 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_3_62661638 -->|"#92;"|eNFA2_7_2367688
eNFA2_3_62661638 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_3_62661638 -->|"#92;"|eNFA2_13_57565064
eNFA2_3_62661638 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_3_62661638 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_7_2367688 -.->|"ε"|eNFA2_8_21309199
eNFA2_7_2367688 -->|"'"|eNFA2_9_1964925
eNFA2_11_42427912 -.->|"ε"|eNFA2_5_8324231
eNFA2_11_42427912 -.->|"ε"|eNFA2_4_13401558
eNFA2_11_42427912 -.->|"ε"|eNFA2_18_12788897
eNFA2_11_42427912 -.->|"ε"|eNFA2_2_11784443
eNFA2_11_42427912 -.->|"ε"|eNFA2_6_53505165
eNFA2_11_42427912 -.->|"ε"|eNFA2_10_38951129
eNFA2_11_42427912 -.->|"ε"|eNFA2_12_15015849
eNFA2_11_42427912 -.->|"ε"|eNFA2_16_924914
eNFA2_11_42427912 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_11_42427912 -->|"#92;"|eNFA2_7_2367688
eNFA2_11_42427912 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_11_42427912 -->|"#92;"|eNFA2_13_57565064
eNFA2_11_42427912 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_11_42427912 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_13_57565064 -.->|"ε"|eNFA2_14_48323534
eNFA2_13_57565064 -->|"#92;"|eNFA2_15_17684330
eNFA2_17_14108834 -.->|"ε"|eNFA2_5_8324231
eNFA2_17_14108834 -.->|"ε"|eNFA2_4_13401558
eNFA2_17_14108834 -.->|"ε"|eNFA2_18_12788897
eNFA2_17_14108834 -.->|"ε"|eNFA2_2_11784443
eNFA2_17_14108834 -.->|"ε"|eNFA2_6_53505165
eNFA2_17_14108834 -.->|"ε"|eNFA2_10_38951129
eNFA2_17_14108834 -.->|"ε"|eNFA2_12_15015849
eNFA2_17_14108834 -.->|"ε"|eNFA2_16_924914
eNFA2_17_14108834 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_17_14108834 -->|"#92;"|eNFA2_7_2367688
eNFA2_17_14108834 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_17_14108834 -->|"#92;"|eNFA2_13_57565064
eNFA2_17_14108834 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_17_14108834 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_18_12788897 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_19_63498254 -.->|"ε
ExtendToken 'Vt'"|eNFA2_21_34613376
eNFA2_19_63498254 -.->|"ε"|eNFA2_22_43084931
eNFA2_19_63498254 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA2_23_24941249
eNFA2_19_63498254 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62873893
eNFA2_8_50727390 -->|"'"|eNFA2_9_7809215
eNFA2_9_7809215 -.->|"ε"|eNFA2_5_38109998
eNFA2_9_7809215 -.->|"ε"|eNFA2_4_13401558
eNFA2_9_7809215 -.->|"ε"|eNFA2_2_11784443
eNFA2_9_7809215 -.->|"ε"|eNFA2_6_53505165
eNFA2_9_7809215 -.->|"ε"|eNFA2_10_38951129
eNFA2_9_7809215 -.->|"ε"|eNFA2_12_15015849
eNFA2_9_7809215 -.->|"ε"|eNFA2_16_924914
eNFA2_9_7809215 -.->|"ε"|eNFA2_5_8324231
eNFA2_9_7809215 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_9_7809215 -->|"#92;"|eNFA2_7_2367688
eNFA2_9_7809215 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_9_7809215 -->|"#92;"|eNFA2_13_57565064
eNFA2_9_7809215 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_9_7809215 -.->|"ε"|eNFA2_18_12788897
eNFA2_9_7809215 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_14_15277900 -->|"#92;"|eNFA2_15_3174077
eNFA2_15_3174077 -.->|"ε"|eNFA2_5_38109998
eNFA2_15_3174077 -.->|"ε"|eNFA2_4_13401558
eNFA2_15_3174077 -.->|"ε"|eNFA2_2_11784443
eNFA2_15_3174077 -.->|"ε"|eNFA2_6_53505165
eNFA2_15_3174077 -.->|"ε"|eNFA2_10_38951129
eNFA2_15_3174077 -.->|"ε"|eNFA2_12_15015849
eNFA2_15_3174077 -.->|"ε"|eNFA2_16_924914
eNFA2_15_3174077 -.->|"ε"|eNFA2_5_8324231
eNFA2_15_3174077 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_15_3174077 -->|"#92;"|eNFA2_7_2367688
eNFA2_15_3174077 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_15_3174077 -->|"#92;"|eNFA2_13_57565064
eNFA2_15_3174077 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_15_3174077 -.->|"ε"|eNFA2_18_12788897
eNFA2_15_3174077 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA3_3_43601387 -->|"[#32;-~]"|eNFA3_4_55773684
eNFA3_4_55773684 -.->|"ε"|eNFA3_7_43982564
eNFA3_4_55773684 -.->|"ε"|eNFA3_5_5817914
eNFA3_4_55773684 -.->|"ε"|eNFA3_9_60298758
eNFA3_4_55773684 -.->|"ε"|eNFA3_8_52361234
eNFA3_4_55773684 -->|"[^%]"|eNFA3_6_47991212
eNFA3_4_55773684 -->|"%"|eNFA3_10_64626598
eNFA3_4_55773684 -.->|"ε"|eNFA3_13_32201111
eNFA3_4_55773684 -->|"[%]"|eNFA3_14_40557681
eNFA7_4_42051488 -->|"p"|eNFA7_5_3283372
eNFA7_5_3283372 -.->|"ε"|eNFA7_6_29550354
eNFA7_5_3283372 -->|"t"|eNFA7_7_263076
eNFA2_8_21309199 -->|"'"|eNFA2_9_1964925
eNFA2_9_1964925 -.->|"ε"|eNFA2_5_8324231
eNFA2_9_1964925 -.->|"ε"|eNFA2_4_13401558
eNFA2_9_1964925 -.->|"ε"|eNFA2_18_12788897
eNFA2_9_1964925 -.->|"ε"|eNFA2_2_11784443
eNFA2_9_1964925 -.->|"ε"|eNFA2_6_53505165
eNFA2_9_1964925 -.->|"ε"|eNFA2_10_38951129
eNFA2_9_1964925 -.->|"ε"|eNFA2_12_15015849
eNFA2_9_1964925 -.->|"ε"|eNFA2_16_924914
eNFA2_9_1964925 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_9_1964925 -->|"#92;"|eNFA2_7_2367688
eNFA2_9_1964925 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_9_1964925 -->|"#92;"|eNFA2_13_57565064
eNFA2_9_1964925 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_9_1964925 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_14_48323534 -->|"#92;"|eNFA2_15_17684330
eNFA2_15_17684330 -.->|"ε"|eNFA2_5_8324231
eNFA2_15_17684330 -.->|"ε"|eNFA2_4_13401558
eNFA2_15_17684330 -.->|"ε"|eNFA2_18_12788897
eNFA2_15_17684330 -.->|"ε"|eNFA2_2_11784443
eNFA2_15_17684330 -.->|"ε"|eNFA2_6_53505165
eNFA2_15_17684330 -.->|"ε"|eNFA2_10_38951129
eNFA2_15_17684330 -.->|"ε"|eNFA2_12_15015849
eNFA2_15_17684330 -.->|"ε"|eNFA2_16_924914
eNFA2_15_17684330 -->|"[#32;-&]"|eNFA2_3_62661638
eNFA2_15_17684330 -->|"#92;"|eNFA2_7_2367688
eNFA2_15_17684330 -->|"[(-[]"|eNFA2_11_42427912
eNFA2_15_17684330 -->|"#92;"|eNFA2_13_57565064
eNFA2_15_17684330 -->|"[]-~]"|eNFA2_17_14108834
eNFA2_15_17684330 -->|"'
ExtendToken 'Vt'"|eNFA2_19_63498254
eNFA2_21_34613376 -.->|"ε"|eNFA2_22_43084931
eNFA2_21_34613376 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA2_23_24941249
eNFA2_21_34613376 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62873893
eNFA2_22_43084931 -.->|"ε
CheckToken 'Vt'
AcceptToken 'Vt'"|eNFA2_23_24941249
eNFA2_22_43084931 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62873893
eNFA2_23_24941249 -.->|"ε
CheckToken 'Vt'"|eNFA0_1_62873893
eNFA3_7_43982564 -.->|"ε"|eNFA3_5_5817914
eNFA3_7_43982564 -.->|"ε"|eNFA3_9_60298758
eNFA3_7_43982564 -.->|"ε"|eNFA3_8_52361234
eNFA3_7_43982564 -->|"[^%]"|eNFA3_6_47991212
eNFA3_7_43982564 -->|"%"|eNFA3_10_64626598
eNFA3_7_43982564 -.->|"ε"|eNFA3_7_43982564
eNFA3_7_43982564 -.->|"ε"|eNFA3_13_32201111
eNFA3_7_43982564 -->|"[%]"|eNFA3_14_40557681
eNFA3_5_5817914 -->|"[^%]"|eNFA3_6_47991212
eNFA3_9_60298758 -->|"%"|eNFA3_10_64626598
eNFA3_8_52361234 -.->|"ε"|eNFA3_7_43982564
eNFA3_8_52361234 -.->|"ε"|eNFA3_13_32201111
eNFA3_8_52361234 -.->|"ε"|eNFA3_5_5817914
eNFA3_8_52361234 -.->|"ε"|eNFA3_9_60298758
eNFA3_8_52361234 -.->|"ε"|eNFA3_8_52361234
eNFA3_8_52361234 -->|"[^%]"|eNFA3_6_47991212
eNFA3_8_52361234 -->|"%"|eNFA3_10_64626598
eNFA3_8_52361234 -->|"[%]"|eNFA3_14_40557681
eNFA3_6_47991212 -.->|"ε"|eNFA3_8_52361234
eNFA3_6_47991212 -.->|"ε"|eNFA3_7_43982564
eNFA3_6_47991212 -.->|"ε"|eNFA3_13_32201111
eNFA3_6_47991212 -.->|"ε"|eNFA3_5_5817914
eNFA3_6_47991212 -.->|"ε"|eNFA3_9_60298758
eNFA3_6_47991212 -->|"[^%]"|eNFA3_6_47991212
eNFA3_6_47991212 -->|"%"|eNFA3_10_64626598
eNFA3_6_47991212 -->|"[%]"|eNFA3_14_40557681
eNFA3_10_64626598 -.->|"ε"|eNFA3_11_44768473
eNFA3_10_64626598 -->|"[^%]"|eNFA3_12_59870648
eNFA3_13_32201111 -->|"[%]"|eNFA3_14_40557681
eNFA3_14_40557681 -->|"[%]
ExtendToken 'pattern'"|eNFA3_15_218537
eNFA7_6_29550354 -->|"t"|eNFA7_7_263076
eNFA7_7_263076 -.->|"ε"|eNFA7_8_63946711
eNFA7_7_263076 -->|"y
ExtendToken 'empty'"|eNFA7_9_48604010
eNFA3_11_44768473 -->|"[^%]"|eNFA3_12_59870648
eNFA3_12_59870648 -.->|"ε"|eNFA3_8_52361234
eNFA3_12_59870648 -.->|"ε"|eNFA3_7_43982564
eNFA3_12_59870648 -.->|"ε"|eNFA3_13_32201111
eNFA3_12_59870648 -.->|"ε"|eNFA3_5_5817914
eNFA3_12_59870648 -.->|"ε"|eNFA3_9_60298758
eNFA3_12_59870648 -->|"[^%]"|eNFA3_6_47991212
eNFA3_12_59870648 -->|"%"|eNFA3_10_64626598
eNFA3_12_59870648 -->|"[%]"|eNFA3_14_40557681
eNFA3_15_218537 -.->|"ε
ExtendToken 'pattern'"|eNFA3_17_1966838
eNFA3_15_218537 -.->|"ε"|eNFA3_18_17701543
eNFA3_15_218537 -.->|"ε
CheckToken 'pattern'
AcceptToken 'pattern'"|eNFA3_19_23144649
eNFA3_15_218537 -.->|"ε
CheckToken 'pattern'"|eNFA0_1_62873893
eNFA7_8_63946711 -->|"y
ExtendToken 'empty'"|eNFA7_9_48604010
eNFA7_9_48604010 -.->|"ε
ExtendToken 'empty'"|eNFA7_11_34782913
eNFA7_9_48604010 -.->|"ε"|eNFA7_12_44610765
eNFA7_9_48604010 -.->|"ε
CheckToken 'empty'
AcceptToken 'empty'"|eNFA7_13_6975252
eNFA7_9_48604010 -.->|"ε
CheckToken 'empty'"|eNFA0_1_62873893
eNFA3_17_1966838 -.->|"ε"|eNFA3_18_17701543
eNFA3_17_1966838 -.->|"ε
CheckToken 'pattern'
AcceptToken 'pattern'"|eNFA3_19_23144649
eNFA3_17_1966838 -.->|"ε
CheckToken 'pattern'"|eNFA0_1_62873893
eNFA3_18_17701543 -.->|"ε
CheckToken 'pattern'
AcceptToken 'pattern'"|eNFA3_19_23144649
eNFA3_18_17701543 -.->|"ε
CheckToken 'pattern'"|eNFA0_1_62873893
eNFA3_19_23144649 -.->|"ε
CheckToken 'pattern'"|eNFA0_1_62873893
eNFA7_11_34782913 -.->|"ε"|eNFA7_12_44610765
eNFA7_11_34782913 -.->|"ε
CheckToken 'empty'
AcceptToken 'empty'"|eNFA7_13_6975252
eNFA7_11_34782913 -.->|"ε
CheckToken 'empty'"|eNFA0_1_62873893
eNFA7_12_44610765 -.->|"ε
CheckToken 'empty'
AcceptToken 'empty'"|eNFA7_13_6975252
eNFA7_12_44610765 -.->|"ε
CheckToken 'empty'"|eNFA0_1_62873893
eNFA7_13_6975252 -.->|"ε
CheckToken 'empty'"|eNFA0_1_62873893

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
NFA0_0_21892170("NFA0-0 wholeStart")
class NFA0_0_21892170 c1000;
NFA1_1_32258625[\"NFA1-1 scope[1]
AcceptToken 'Vn'"/]
class NFA1_1_32258625 c0101;
NFA2_1_62811802("NFA2-1 char[1]")
NFA3_1_28435306("NFA3-1 scope[1]")
NFA4_1_54591163[\"NFA4-1 char[1]
AcceptToken ':'"/]
class NFA4_1_54591163 c0101;
NFA5_1_21558422[\"NFA5-1 char[1]
AcceptToken ';'"/]
class NFA5_1_21558422 c0101;
NFA6_1_59808077[\"NFA6-1 char[1]
AcceptToken '|'"/]
class NFA6_1_59808077 c0101;
NFA7_1_1401783("NFA7-1 char[1]")
NFA1_2_12616055[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055 c0101;
NFA2_3_15267554("NFA2-3 scope[1]")
NFA2_7_46435637("NFA2-7 char[1]")
NFA2_11_3190263("NFA2-11 scope[1]")
NFA2_13_28712374("NFA2-13 char[1]")
NFA2_17_57084774("NFA2-17 scope[1]")
NFA3_2_17395112("NFA3-2 scope[2]")
NFA7_3_24302411("NFA7-3 char[1]")
NFA2_3_60463977("NFA2-3 scope[1]")
NFA2_7_44000921("NFA2-7 char[1]")
NFA2_11_7304886("NFA2-11 scope[1]")
NFA2_13_65743977("NFA2-13 char[1]")
NFA2_17_54824883("NFA2-17 scope[1]")
NFA2_19_23661901[\"NFA2-19 char[1]
AcceptToken 'Vt'"/]
class NFA2_19_23661901 c0101;
NFA2_9_11630520("NFA2-9 char[1]")
NFA2_15_37565822("NFA2-15 char[1]")
NFA3_4_2548078("NFA3-4 scope[1]")
NFA7_5_22338284("NFA7-5 char[1]")
NFA2_9_7836427("NFA2-9 char[1]")
NFA2_15_3418987("NFA2-15 char[1]")
NFA3_6_5067772("NFA3-6 scope[1]")
NFA3_10_22932707("NFA3-10 char[1]")
NFA3_14_45609956("NFA3-14 scope[1]")
NFA7_7_9413579("NFA7-7 char[1]")
NFA3_12_17613348("NFA3-12 scope[1]")
NFA3_15_30770883[\"NFA3-15 scope[2]
AcceptToken 'pattern'"/]
class NFA3_15_30770883 c0101;
NFA7_9_8502493[\"NFA7-9 char[1]
AcceptToken 'empty'"/]
class NFA7_9_8502493 c0101;
NFA0_0_21892170 -->|"[a-zA-Z_]
BeginToken 'Vn'
ExtendToken 'Vn'"|NFA1_1_32258625
NFA0_0_21892170 -->|"'
BeginToken 'Vt'"|NFA2_1_62811802
NFA0_0_21892170 -->|"[%]
BeginToken 'pattern'"|NFA3_1_28435306
NFA0_0_21892170 -->|":
BeginToken ':'
ExtendToken ':'"|NFA4_1_54591163
NFA0_0_21892170 -->|";
BeginToken ';'
ExtendToken ';'"|NFA5_1_21558422
NFA0_0_21892170 -->|"|
BeginToken '|'
ExtendToken '|'"|NFA6_1_59808077
NFA0_0_21892170 -->|"e
BeginToken 'empty'"|NFA7_1_1401783
NFA1_1_32258625 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|NFA1_2_12616055
NFA2_1_62811802 -->|"[#32;-&]"|NFA2_3_15267554
NFA2_1_62811802 -->|"#92;"|NFA2_7_46435637
NFA2_1_62811802 -->|"[(-[]"|NFA2_11_3190263
NFA2_1_62811802 -->|"#92;"|NFA2_13_28712374
NFA2_1_62811802 -->|"[]-~]"|NFA2_17_57084774
NFA3_1_28435306 -->|"[%]"|NFA3_2_17395112
NFA7_1_1401783 -->|"m"|NFA7_3_24302411
NFA1_2_12616055 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|NFA1_2_12616055
NFA2_3_15267554 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_3_15267554 -->|"#92;"|NFA2_7_44000921
NFA2_3_15267554 -->|"[(-[]"|NFA2_11_7304886
NFA2_3_15267554 -->|"#92;"|NFA2_13_65743977
NFA2_3_15267554 -->|"[]-~]"|NFA2_17_54824883
NFA2_3_15267554 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_7_46435637 -->|"'"|NFA2_9_11630520
NFA2_11_3190263 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_11_3190263 -->|"#92;"|NFA2_7_44000921
NFA2_11_3190263 -->|"[(-[]"|NFA2_11_7304886
NFA2_11_3190263 -->|"#92;"|NFA2_13_65743977
NFA2_11_3190263 -->|"[]-~]"|NFA2_17_54824883
NFA2_11_3190263 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_13_28712374 -->|"#92;"|NFA2_15_37565822
NFA2_17_57084774 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_17_57084774 -->|"#92;"|NFA2_7_44000921
NFA2_17_57084774 -->|"[(-[]"|NFA2_11_7304886
NFA2_17_57084774 -->|"#92;"|NFA2_13_65743977
NFA2_17_57084774 -->|"[]-~]"|NFA2_17_54824883
NFA2_17_57084774 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA3_2_17395112 -->|"[#32;-~]"|NFA3_4_2548078
NFA7_3_24302411 -->|"p"|NFA7_5_22338284
NFA2_3_60463977 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_3_60463977 -->|"#92;"|NFA2_7_44000921
NFA2_3_60463977 -->|"[(-[]"|NFA2_11_7304886
NFA2_3_60463977 -->|"#92;"|NFA2_13_65743977
NFA2_3_60463977 -->|"[]-~]"|NFA2_17_54824883
NFA2_3_60463977 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_7_44000921 -->|"'"|NFA2_9_7836427
NFA2_11_7304886 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_11_7304886 -->|"#92;"|NFA2_7_44000921
NFA2_11_7304886 -->|"[(-[]"|NFA2_11_7304886
NFA2_11_7304886 -->|"#92;"|NFA2_13_65743977
NFA2_11_7304886 -->|"[]-~]"|NFA2_17_54824883
NFA2_11_7304886 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_13_65743977 -->|"#92;"|NFA2_15_3418987
NFA2_17_54824883 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_17_54824883 -->|"#92;"|NFA2_7_44000921
NFA2_17_54824883 -->|"[(-[]"|NFA2_11_7304886
NFA2_17_54824883 -->|"#92;"|NFA2_13_65743977
NFA2_17_54824883 -->|"[]-~]"|NFA2_17_54824883
NFA2_17_54824883 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_9_11630520 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_9_11630520 -->|"#92;"|NFA2_7_44000921
NFA2_9_11630520 -->|"[(-[]"|NFA2_11_7304886
NFA2_9_11630520 -->|"#92;"|NFA2_13_65743977
NFA2_9_11630520 -->|"[]-~]"|NFA2_17_54824883
NFA2_9_11630520 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_15_37565822 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_15_37565822 -->|"#92;"|NFA2_7_44000921
NFA2_15_37565822 -->|"[(-[]"|NFA2_11_7304886
NFA2_15_37565822 -->|"#92;"|NFA2_13_65743977
NFA2_15_37565822 -->|"[]-~]"|NFA2_17_54824883
NFA2_15_37565822 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA3_4_2548078 -->|"[^%]"|NFA3_6_5067772
NFA3_4_2548078 -->|"%"|NFA3_10_22932707
NFA3_4_2548078 -->|"[%]"|NFA3_14_45609956
NFA7_5_22338284 -->|"t"|NFA7_7_9413579
NFA2_9_7836427 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_9_7836427 -->|"#92;"|NFA2_7_44000921
NFA2_9_7836427 -->|"[(-[]"|NFA2_11_7304886
NFA2_9_7836427 -->|"#92;"|NFA2_13_65743977
NFA2_9_7836427 -->|"[]-~]"|NFA2_17_54824883
NFA2_9_7836427 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA2_15_3418987 -->|"[#32;-&]"|NFA2_3_60463977
NFA2_15_3418987 -->|"#92;"|NFA2_7_44000921
NFA2_15_3418987 -->|"[(-[]"|NFA2_11_7304886
NFA2_15_3418987 -->|"#92;"|NFA2_13_65743977
NFA2_15_3418987 -->|"[]-~]"|NFA2_17_54824883
NFA2_15_3418987 -->|"'
ExtendToken 'Vt'"|NFA2_19_23661901
NFA3_6_5067772 -->|"[^%]"|NFA3_6_5067772
NFA3_6_5067772 -->|"%"|NFA3_10_22932707
NFA3_6_5067772 -->|"[%]"|NFA3_14_45609956
NFA3_10_22932707 -->|"[^%]"|NFA3_12_17613348
NFA3_14_45609956 -->|"[%]
ExtendToken 'pattern'"|NFA3_15_30770883
NFA7_7_9413579 -->|"y
ExtendToken 'empty'"|NFA7_9_8502493
NFA3_12_17613348 -->|"[^%]"|NFA3_6_5067772
NFA3_12_17613348 -->|"%"|NFA3_10_22932707
NFA3_12_17613348 -->|"[%]"|NFA3_14_45609956

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
subgraph DFA0_1077753945["DFA0 wholeStart"]
NFA0_0_21892170_0("NFA0-0 wholeStart")
class NFA0_0_21892170_0 c1000;
end
class DFA0_1077753945 c1000;
subgraph DFA1_-876304576["DFA1 {1}"]
NFA1_1_32258625_1[\"NFA1-1 scope[1]
AcceptToken 'Vn'"/]
class NFA1_1_32258625_1 c0101;
end
class DFA1_-876304576 c0101;
subgraph DFA2_-1491621934["DFA2 {2}"]
NFA1_1_32258625_2[\"NFA1-1 scope[1]
AcceptToken 'Vn'"/]
class NFA1_1_32258625_2 c0101;
NFA7_1_1401783_3("NFA7-1 char[1]")
end
class DFA2_-1491621934 c0101;
subgraph DFA3_246635843["DFA3 {1}"]
NFA2_1_62811802_4("NFA2-1 char[1]")
end
subgraph DFA4_-822484634["DFA4 {1}"]
NFA3_1_28435306_5("NFA3-1 scope[1]")
end
subgraph DFA5_-115393077["DFA5 {1}"]
NFA4_1_54591163_6[\"NFA4-1 char[1]
AcceptToken ':'"/]
class NFA4_1_54591163_6 c0101;
end
class DFA5_-115393077 c0101;
subgraph DFA6_935475077["DFA6 {1}"]
NFA5_1_21558422_7[\"NFA5-1 char[1]
AcceptToken ';'"/]
class NFA5_1_21558422_7 c0101;
end
class DFA6_935475077 c0101;
subgraph DFA7_1077856482["DFA7 {1}"]
NFA6_1_59808077_8[\"NFA6-1 char[1]
AcceptToken '|'"/]
class NFA6_1_59808077_8 c0101;
end
class DFA7_1077856482 c0101;
subgraph DFA8_-1736449168["DFA8 {1}"]
NFA1_2_12616055_9[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055_9 c0101;
end
class DFA8_-1736449168 c0101;
subgraph DFA9_-1677404000["DFA9 {2}"]
NFA1_2_12616055_10[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055_10 c0101;
NFA7_3_24302411_11("NFA7-3 char[1]")
end
class DFA9_-1677404000 c0101;
subgraph DFA10_1198449475["DFA10 {1}"]
NFA2_3_15267554_12("NFA2-3 scope[1]")
end
subgraph DFA11_1366882291["DFA11 {2}"]
NFA2_7_46435637_13("NFA2-7 char[1]")
NFA2_13_28712374_14("NFA2-13 char[1]")
end
subgraph DFA12_629474317["DFA12 {1}"]
NFA2_11_3190263_15("NFA2-11 scope[1]")
end
subgraph DFA13_673446079["DFA13 {1}"]
NFA2_17_57084774_16("NFA2-17 scope[1]")
end
subgraph DFA14_-673120867["DFA14 {1}"]
NFA3_2_17395112_17("NFA3-2 scope[2]")
end
subgraph DFA15_1029764596["DFA15 {2}"]
NFA1_2_12616055_18[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055_18 c0101;
NFA7_5_22338284_19("NFA7-5 char[1]")
end
class DFA15_1029764596 c0101;
subgraph DFA16_1343741417["DFA16 {1}"]
NFA2_3_60463977_20("NFA2-3 scope[1]")
end
subgraph DFA17_-119342801["DFA17 {2}"]
NFA2_7_44000921_21("NFA2-7 char[1]")
NFA2_13_65743977_22("NFA2-13 char[1]")
end
subgraph DFA18_1127486788["DFA18 {1}"]
NFA2_11_7304886_23("NFA2-11 scope[1]")
end
subgraph DFA19_-509411227["DFA19 {1}"]
NFA2_17_54824883_24("NFA2-17 scope[1]")
end
subgraph DFA20_-623473881["DFA20 {1}"]
NFA2_19_23661901_25[\"NFA2-19 char[1]
AcceptToken 'Vt'"/]
class NFA2_19_23661901_25 c0101;
end
class DFA20_-623473881 c0101;
subgraph DFA21_746850879["DFA21 {1}"]
NFA2_9_11630520_26("NFA2-9 char[1]")
end
subgraph DFA22_732341553["DFA22 {1}"]
NFA2_15_37565822_27("NFA2-15 char[1]")
end
subgraph DFA23_-607975463["DFA23 {1}"]
NFA3_4_2548078_28("NFA3-4 scope[1]")
end
subgraph DFA24_-519554121["DFA24 {2}"]
NFA1_2_12616055_29[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055_29 c0101;
NFA7_7_9413579_30("NFA7-7 char[1]")
end
class DFA24_-519554121 c0101;
subgraph DFA25_-1471708991["DFA25 {1}"]
NFA2_9_7836427_31("NFA2-9 char[1]")
end
subgraph DFA26_1737880891["DFA26 {1}"]
NFA2_15_3418987_32("NFA2-15 char[1]")
end
subgraph DFA27_-1455822610["DFA27 {1}"]
NFA3_6_5067772_33("NFA3-6 scope[1]")
end
subgraph DFA28_2020037024["DFA28 {2}"]
NFA3_10_22932707_34("NFA3-10 char[1]")
NFA3_14_45609956_35("NFA3-14 scope[1]")
end
subgraph DFA29_1979392533["DFA29 {2}"]
NFA1_2_12616055_36[\"NFA1-2 scope{0, ∞}
AcceptToken 'Vn'"/]
class NFA1_2_12616055_36 c0101;
NFA7_9_8502493_37[\"NFA7-9 char[1]
AcceptToken 'empty'"/]
class NFA7_9_8502493_37 c0101;
end
class DFA29_1979392533 c0101;
subgraph DFA30_667219841["DFA30 {1}"]
NFA3_12_17613348_38("NFA3-12 scope[1]")
end
subgraph DFA31_392514856["DFA31 {1}"]
NFA3_15_30770883_39[\"NFA3-15 scope[2]
AcceptToken 'pattern'"/]
class NFA3_15_30770883_39 c0101;
end
class DFA31_392514856 c0101;
DFA0_1077753945 -->|"[A-Z_a-df-z]
BeginToken 'Vn'
ExtendToken 'Vn'"|DFA1_-876304576
DFA0_1077753945 -->|"e
BeginToken 'Vn''empty'
ExtendToken 'Vn'"|DFA2_-1491621934
DFA0_1077753945 -->|"'
BeginToken 'Vt'"|DFA3_246635843
DFA0_1077753945 -->|"[%]
BeginToken 'pattern'"|DFA4_-822484634
DFA0_1077753945 -->|":
BeginToken ':'
ExtendToken ':'"|DFA5_-115393077
DFA0_1077753945 -->|";
BeginToken ';'
ExtendToken ';'"|DFA6_935475077
DFA0_1077753945 -->|"|
BeginToken '|'
ExtendToken '|'"|DFA7_1077856482
DFA1_-876304576 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA2_-1491621934 -->|"[0-9A-Z_a-ln-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA2_-1491621934 -->|"m
ExtendToken 'Vn'"|DFA9_-1677404000
DFA3_246635843 -->|"[#32;-&]"|DFA10_1198449475
DFA3_246635843 -->|"#92;"|DFA11_1366882291
DFA3_246635843 -->|"[(-[]"|DFA12_629474317
DFA3_246635843 -->|"[]-~]"|DFA13_673446079
DFA4_-822484634 -->|"[%]"|DFA14_-673120867
DFA8_-1736449168 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA9_-1677404000 -->|"[0-9A-Z_a-oq-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA9_-1677404000 -->|"p
ExtendToken 'Vn'"|DFA15_1029764596
DFA10_1198449475 -->|"[#32;-&]"|DFA16_1343741417
DFA10_1198449475 -->|"#92;"|DFA17_-119342801
DFA10_1198449475 -->|"[(-[]"|DFA18_1127486788
DFA10_1198449475 -->|"[]-~]"|DFA19_-509411227
DFA10_1198449475 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA11_1366882291 -->|"'"|DFA21_746850879
DFA11_1366882291 -->|"#92;"|DFA22_732341553
DFA12_629474317 -->|"[#32;-&]"|DFA16_1343741417
DFA12_629474317 -->|"#92;"|DFA17_-119342801
DFA12_629474317 -->|"[(-[]"|DFA18_1127486788
DFA12_629474317 -->|"[]-~]"|DFA19_-509411227
DFA12_629474317 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA13_673446079 -->|"[#32;-&]"|DFA16_1343741417
DFA13_673446079 -->|"#92;"|DFA17_-119342801
DFA13_673446079 -->|"[(-[]"|DFA18_1127486788
DFA13_673446079 -->|"[]-~]"|DFA19_-509411227
DFA13_673446079 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA14_-673120867 -->|"[#32;-~]"|DFA23_-607975463
DFA15_1029764596 -->|"[0-9A-Z_a-su-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA15_1029764596 -->|"t
ExtendToken 'Vn'"|DFA24_-519554121
DFA16_1343741417 -->|"[#32;-&]"|DFA16_1343741417
DFA16_1343741417 -->|"#92;"|DFA17_-119342801
DFA16_1343741417 -->|"[(-[]"|DFA18_1127486788
DFA16_1343741417 -->|"[]-~]"|DFA19_-509411227
DFA16_1343741417 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA17_-119342801 -->|"'"|DFA25_-1471708991
DFA17_-119342801 -->|"#92;"|DFA26_1737880891
DFA18_1127486788 -->|"[#32;-&]"|DFA16_1343741417
DFA18_1127486788 -->|"#92;"|DFA17_-119342801
DFA18_1127486788 -->|"[(-[]"|DFA18_1127486788
DFA18_1127486788 -->|"[]-~]"|DFA19_-509411227
DFA18_1127486788 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA19_-509411227 -->|"[#32;-&]"|DFA16_1343741417
DFA19_-509411227 -->|"#92;"|DFA17_-119342801
DFA19_-509411227 -->|"[(-[]"|DFA18_1127486788
DFA19_-509411227 -->|"[]-~]"|DFA19_-509411227
DFA19_-509411227 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA21_746850879 -->|"[#32;-&]"|DFA16_1343741417
DFA21_746850879 -->|"#92;"|DFA17_-119342801
DFA21_746850879 -->|"[(-[]"|DFA18_1127486788
DFA21_746850879 -->|"[]-~]"|DFA19_-509411227
DFA21_746850879 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA22_732341553 -->|"[#32;-&]"|DFA16_1343741417
DFA22_732341553 -->|"#92;"|DFA17_-119342801
DFA22_732341553 -->|"[(-[]"|DFA18_1127486788
DFA22_732341553 -->|"[]-~]"|DFA19_-509411227
DFA22_732341553 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA23_-607975463 -->|"[^%]"|DFA27_-1455822610
DFA23_-607975463 -->|"%"|DFA28_2020037024
DFA24_-519554121 -->|"[0-9A-Z_a-xz]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA24_-519554121 -->|"y
ExtendToken 'Vn''empty'"|DFA29_1979392533
DFA25_-1471708991 -->|"[#32;-&]"|DFA16_1343741417
DFA25_-1471708991 -->|"#92;"|DFA17_-119342801
DFA25_-1471708991 -->|"[(-[]"|DFA18_1127486788
DFA25_-1471708991 -->|"[]-~]"|DFA19_-509411227
DFA25_-1471708991 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA26_1737880891 -->|"[#32;-&]"|DFA16_1343741417
DFA26_1737880891 -->|"#92;"|DFA17_-119342801
DFA26_1737880891 -->|"[(-[]"|DFA18_1127486788
DFA26_1737880891 -->|"[]-~]"|DFA19_-509411227
DFA26_1737880891 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA27_-1455822610 -->|"[^%]"|DFA27_-1455822610
DFA27_-1455822610 -->|"%"|DFA28_2020037024
DFA28_2020037024 -->|"[^%]"|DFA30_667219841
DFA28_2020037024 -->|"[%]
ExtendToken 'pattern'"|DFA31_392514856
DFA29_1979392533 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA30_667219841 -->|"[^%]"|DFA27_-1455822610
DFA30_667219841 -->|"%"|DFA28_2020037024

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
DFA0_1077753945{{"DFA0 wholeStart"}}
class DFA0_1077753945 c1000;
DFA1_-876304576[\"DFA1 {1}
AcceptToken 'Vn'"/]
class DFA1_-876304576 c0101;
DFA2_-1491621934[\"DFA2 {2}
AcceptToken 'Vn'"/]
class DFA2_-1491621934 c0101;
DFA3_246635843{{"DFA3 {1}"}}
DFA4_-822484634{{"DFA4 {1}"}}
DFA5_-115393077[\"DFA5 {1}
AcceptToken ':'"/]
class DFA5_-115393077 c0101;
DFA6_935475077[\"DFA6 {1}
AcceptToken ';'"/]
class DFA6_935475077 c0101;
DFA7_1077856482[\"DFA7 {1}
AcceptToken '|'"/]
class DFA7_1077856482 c0101;
DFA8_-1736449168[\"DFA8 {1}
AcceptToken 'Vn'"/]
class DFA8_-1736449168 c0101;
DFA9_-1677404000[\"DFA9 {2}
AcceptToken 'Vn'"/]
class DFA9_-1677404000 c0101;
DFA10_1198449475{{"DFA10 {1}"}}
DFA11_1366882291{{"DFA11 {2}"}}
DFA12_629474317{{"DFA12 {1}"}}
DFA13_673446079{{"DFA13 {1}"}}
DFA14_-673120867{{"DFA14 {1}"}}
DFA15_1029764596[\"DFA15 {2}
AcceptToken 'Vn'"/]
class DFA15_1029764596 c0101;
DFA16_1343741417{{"DFA16 {1}"}}
DFA17_-119342801{{"DFA17 {2}"}}
DFA18_1127486788{{"DFA18 {1}"}}
DFA19_-509411227{{"DFA19 {1}"}}
DFA20_-623473881[\"DFA20 {1}
AcceptToken 'Vt'"/]
class DFA20_-623473881 c0101;
DFA21_746850879{{"DFA21 {1}"}}
DFA22_732341553{{"DFA22 {1}"}}
DFA23_-607975463{{"DFA23 {1}"}}
DFA24_-519554121[\"DFA24 {2}
AcceptToken 'Vn'"/]
class DFA24_-519554121 c0101;
DFA25_-1471708991{{"DFA25 {1}"}}
DFA26_1737880891{{"DFA26 {1}"}}
DFA27_-1455822610{{"DFA27 {1}"}}
DFA28_2020037024{{"DFA28 {2}"}}
DFA29_1979392533[\"DFA29 {2}
AcceptToken 'Vn'
AcceptToken 'empty'"/]
class DFA29_1979392533 c0101;
DFA30_667219841{{"DFA30 {1}"}}
DFA31_392514856[\"DFA31 {1}
AcceptToken 'pattern'"/]
class DFA31_392514856 c0101;
DFA0_1077753945 -->|"[A-Z_a-df-z]
BeginToken 'Vn'
ExtendToken 'Vn'"|DFA1_-876304576
DFA0_1077753945 -->|"e
BeginToken 'Vn''empty'
ExtendToken 'Vn'"|DFA2_-1491621934
DFA0_1077753945 -->|"'
BeginToken 'Vt'"|DFA3_246635843
DFA0_1077753945 -->|"[%]
BeginToken 'pattern'"|DFA4_-822484634
DFA0_1077753945 -->|":
BeginToken ':'
ExtendToken ':'"|DFA5_-115393077
DFA0_1077753945 -->|";
BeginToken ';'
ExtendToken ';'"|DFA6_935475077
DFA0_1077753945 -->|"|
BeginToken '|'
ExtendToken '|'"|DFA7_1077856482
DFA1_-876304576 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA2_-1491621934 -->|"[0-9A-Z_a-ln-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA2_-1491621934 -->|"m
ExtendToken 'Vn'"|DFA9_-1677404000
DFA3_246635843 -->|"[#32;-&]"|DFA10_1198449475
DFA3_246635843 -->|"#92;"|DFA11_1366882291
DFA3_246635843 -->|"[(-[]"|DFA12_629474317
DFA3_246635843 -->|"[]-~]"|DFA13_673446079
DFA4_-822484634 -->|"[%]"|DFA14_-673120867
DFA8_-1736449168 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA9_-1677404000 -->|"[0-9A-Z_a-oq-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA9_-1677404000 -->|"p
ExtendToken 'Vn'"|DFA15_1029764596
DFA10_1198449475 -->|"[#32;-&]"|DFA16_1343741417
DFA10_1198449475 -->|"#92;"|DFA17_-119342801
DFA10_1198449475 -->|"[(-[]"|DFA18_1127486788
DFA10_1198449475 -->|"[]-~]"|DFA19_-509411227
DFA10_1198449475 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA11_1366882291 -->|"'"|DFA21_746850879
DFA11_1366882291 -->|"#92;"|DFA22_732341553
DFA12_629474317 -->|"[#32;-&]"|DFA16_1343741417
DFA12_629474317 -->|"#92;"|DFA17_-119342801
DFA12_629474317 -->|"[(-[]"|DFA18_1127486788
DFA12_629474317 -->|"[]-~]"|DFA19_-509411227
DFA12_629474317 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA13_673446079 -->|"[#32;-&]"|DFA16_1343741417
DFA13_673446079 -->|"#92;"|DFA17_-119342801
DFA13_673446079 -->|"[(-[]"|DFA18_1127486788
DFA13_673446079 -->|"[]-~]"|DFA19_-509411227
DFA13_673446079 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA14_-673120867 -->|"[#32;-~]"|DFA23_-607975463
DFA15_1029764596 -->|"[0-9A-Z_a-su-z]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA15_1029764596 -->|"t
ExtendToken 'Vn'"|DFA24_-519554121
DFA16_1343741417 -->|"[#32;-&]"|DFA16_1343741417
DFA16_1343741417 -->|"#92;"|DFA17_-119342801
DFA16_1343741417 -->|"[(-[]"|DFA18_1127486788
DFA16_1343741417 -->|"[]-~]"|DFA19_-509411227
DFA16_1343741417 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA17_-119342801 -->|"'"|DFA25_-1471708991
DFA17_-119342801 -->|"#92;"|DFA26_1737880891
DFA18_1127486788 -->|"[#32;-&]"|DFA16_1343741417
DFA18_1127486788 -->|"#92;"|DFA17_-119342801
DFA18_1127486788 -->|"[(-[]"|DFA18_1127486788
DFA18_1127486788 -->|"[]-~]"|DFA19_-509411227
DFA18_1127486788 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA19_-509411227 -->|"[#32;-&]"|DFA16_1343741417
DFA19_-509411227 -->|"#92;"|DFA17_-119342801
DFA19_-509411227 -->|"[(-[]"|DFA18_1127486788
DFA19_-509411227 -->|"[]-~]"|DFA19_-509411227
DFA19_-509411227 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA21_746850879 -->|"[#32;-&]"|DFA16_1343741417
DFA21_746850879 -->|"#92;"|DFA17_-119342801
DFA21_746850879 -->|"[(-[]"|DFA18_1127486788
DFA21_746850879 -->|"[]-~]"|DFA19_-509411227
DFA21_746850879 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA22_732341553 -->|"[#32;-&]"|DFA16_1343741417
DFA22_732341553 -->|"#92;"|DFA17_-119342801
DFA22_732341553 -->|"[(-[]"|DFA18_1127486788
DFA22_732341553 -->|"[]-~]"|DFA19_-509411227
DFA22_732341553 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA23_-607975463 -->|"[^%]"|DFA27_-1455822610
DFA23_-607975463 -->|"%"|DFA28_2020037024
DFA24_-519554121 -->|"[0-9A-Z_a-xz]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA24_-519554121 -->|"y
ExtendToken 'Vn''empty'"|DFA29_1979392533
DFA25_-1471708991 -->|"[#32;-&]"|DFA16_1343741417
DFA25_-1471708991 -->|"#92;"|DFA17_-119342801
DFA25_-1471708991 -->|"[(-[]"|DFA18_1127486788
DFA25_-1471708991 -->|"[]-~]"|DFA19_-509411227
DFA25_-1471708991 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA26_1737880891 -->|"[#32;-&]"|DFA16_1343741417
DFA26_1737880891 -->|"#92;"|DFA17_-119342801
DFA26_1737880891 -->|"[(-[]"|DFA18_1127486788
DFA26_1737880891 -->|"[]-~]"|DFA19_-509411227
DFA26_1737880891 -->|"'
ExtendToken 'Vt'"|DFA20_-623473881
DFA27_-1455822610 -->|"[^%]"|DFA27_-1455822610
DFA27_-1455822610 -->|"%"|DFA28_2020037024
DFA28_2020037024 -->|"[^%]"|DFA30_667219841
DFA28_2020037024 -->|"[%]
ExtendToken 'pattern'"|DFA31_392514856
DFA29_1979392533 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|DFA8_-1736449168
DFA30_667219841 -->|"[^%]"|DFA27_-1455822610
DFA30_667219841 -->|"%"|DFA28_2020037024

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
subgraph MiniDFA0_-339152269["MiniDFA0 {1}"]
DFA0_1077753945_0{{"DFA0 wholeStart"}}
class DFA0_1077753945_0 c1000;
end
class MiniDFA0_-339152269 c1000;
subgraph MiniDFA8_1794100827["MiniDFA8 {1}"]
DFA1_-876304576_1[\"DFA1 {1}
AcceptToken 'Vn'"/]
class DFA1_-876304576_1 c0101;
end
class MiniDFA8_1794100827 c0101;
subgraph MiniDFA9_553554605["MiniDFA9 {1}"]
DFA2_-1491621934_2[\"DFA2 {2}
AcceptToken 'Vn'"/]
class DFA2_-1491621934_2 c0101;
end
class MiniDFA9_553554605 c0101;
subgraph MiniDFA1_-1189134655["MiniDFA1 {1}"]
DFA3_246635843_3{{"DFA3 {1}"}}
end
subgraph MiniDFA2_215997034["MiniDFA2 {1}"]
DFA4_-822484634_4{{"DFA4 {1}"}}
end
subgraph MiniDFA10_-925134283["MiniDFA10 {1}"]
DFA5_-115393077_5[\"DFA5 {1}
AcceptToken ':'"/]
class DFA5_-115393077_5 c0101;
end
class MiniDFA10_-925134283 c0101;
subgraph MiniDFA11_1289570263["MiniDFA11 {1}"]
DFA6_935475077_6[\"DFA6 {1}
AcceptToken ';'"/]
class DFA6_935475077_6 c0101;
end
class MiniDFA11_1289570263 c0101;
subgraph MiniDFA12_-1201688988["MiniDFA12 {1}"]
DFA7_1077856482_7[\"DFA7 {1}
AcceptToken '|'"/]
class DFA7_1077856482_7 c0101;
end
class MiniDFA12_-1201688988 c0101;
subgraph MiniDFA13_-1062044516["MiniDFA13 {1}"]
DFA8_-1736449168_8[\"DFA8 {1}
AcceptToken 'Vn'"/]
class DFA8_-1736449168_8 c0101;
end
class MiniDFA13_-1062044516 c0101;
subgraph MiniDFA14_-772034862["MiniDFA14 {1}"]
DFA9_-1677404000_9[\"DFA9 {2}
AcceptToken 'Vn'"/]
class DFA9_-1677404000_9 c0101;
end
class MiniDFA14_-772034862 c0101;
subgraph MiniDFA3_742957008["MiniDFA3 {10}"]
DFA10_1198449475_10{{"DFA10 {1}"}}
DFA12_629474317_11{{"DFA12 {1}"}}
DFA13_673446079_12{{"DFA13 {1}"}}
DFA16_1343741417_13{{"DFA16 {1}"}}
DFA18_1127486788_14{{"DFA18 {1}"}}
DFA19_-509411227_15{{"DFA19 {1}"}}
DFA21_746850879_16{{"DFA21 {1}"}}
DFA22_732341553_17{{"DFA22 {1}"}}
DFA25_-1471708991_18{{"DFA25 {1}"}}
DFA26_1737880891_19{{"DFA26 {1}"}}
end
subgraph MiniDFA4_2001254085["MiniDFA4 {2}"]
DFA11_1366882291_20{{"DFA11 {2}"}}
DFA17_-119342801_21{{"DFA17 {2}"}}
end
subgraph MiniDFA5_7543543["MiniDFA5 {1}"]
DFA14_-673120867_22{{"DFA14 {1}"}}
end
subgraph MiniDFA15_1367419142["MiniDFA15 {1}"]
DFA15_1029764596_23[\"DFA15 {2}
AcceptToken 'Vn'"/]
class DFA15_1029764596_23 c0101;
end
class MiniDFA15_1367419142 c0101;
subgraph MiniDFA16_667520748["MiniDFA16 {1}"]
DFA20_-623473881_24[\"DFA20 {1}
AcceptToken 'Vt'"/]
class DFA20_-623473881_24 c0101;
end
class MiniDFA16_667520748 c0101;
subgraph MiniDFA6_-1460448968["MiniDFA6 {3}"]
DFA23_-607975463_25{{"DFA23 {1}"}}
DFA27_-1455822610_26{{"DFA27 {1}"}}
DFA30_667219841_27{{"DFA30 {1}"}}
end
subgraph MiniDFA17_-1358450166["MiniDFA17 {1}"]
DFA24_-519554121_28[\"DFA24 {2}
AcceptToken 'Vn'"/]
class DFA24_-519554121_28 c0101;
end
class MiniDFA17_-1358450166 c0101;
subgraph MiniDFA7_1744683586["MiniDFA7 {1}"]
DFA28_2020037024_29{{"DFA28 {2}"}}
end
subgraph MiniDFA18_-1113869385["MiniDFA18 {1}"]
DFA29_1979392533_30[\"DFA29 {2}
AcceptToken 'Vn'
AcceptToken 'empty'"/]
class DFA29_1979392533_30 c0101;
end
class MiniDFA18_-1113869385 c0101;
subgraph MiniDFA19_-541931836["MiniDFA19 {1}"]
DFA31_392514856_31[\"DFA31 {1}
AcceptToken 'pattern'"/]
class DFA31_392514856_31 c0101;
end
class MiniDFA19_-541931836 c0101;
MiniDFA0_-339152269 -->|"[A-Z_a-df-z]
BeginToken 'Vn'
ExtendToken 'Vn'"|MiniDFA8_1794100827
MiniDFA0_-339152269 -->|"e
BeginToken 'Vn''empty'
ExtendToken 'Vn'"|MiniDFA9_553554605
MiniDFA0_-339152269 -->|"'
BeginToken 'Vt'"|MiniDFA1_-1189134655
MiniDFA0_-339152269 -->|"[%]
BeginToken 'pattern'"|MiniDFA2_215997034
MiniDFA0_-339152269 -->|":
BeginToken ':'
ExtendToken ':'"|MiniDFA10_-925134283
MiniDFA0_-339152269 -->|";
BeginToken ';'
ExtendToken ';'"|MiniDFA11_1289570263
MiniDFA0_-339152269 -->|"|
BeginToken '|'
ExtendToken '|'"|MiniDFA12_-1201688988
MiniDFA8_1794100827 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA9_553554605 -->|"[0-9A-Z_a-ln-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA9_553554605 -->|"m
ExtendToken 'Vn'"|MiniDFA14_-772034862
MiniDFA1_-1189134655 -->|"[#32;-&]"|MiniDFA3_742957008
MiniDFA1_-1189134655 -->|"#92;"|MiniDFA4_2001254085
MiniDFA1_-1189134655 -->|"[(-[]"|MiniDFA3_742957008
MiniDFA1_-1189134655 -->|"[]-~]"|MiniDFA3_742957008
MiniDFA2_215997034 -->|"[%]"|MiniDFA5_7543543
MiniDFA13_-1062044516 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA14_-772034862 -->|"[0-9A-Z_a-oq-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA14_-772034862 -->|"p
ExtendToken 'Vn'"|MiniDFA15_1367419142
MiniDFA3_742957008 -->|"[#32;-&]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"#92;"|MiniDFA4_2001254085
MiniDFA3_742957008 -->|"[(-[]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"[]-~]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"'
ExtendToken 'Vt'"|MiniDFA16_667520748
MiniDFA4_2001254085 -->|"'"|MiniDFA3_742957008
MiniDFA4_2001254085 -->|"#92;"|MiniDFA3_742957008
MiniDFA5_7543543 -->|"[#32;-~]"|MiniDFA6_-1460448968
MiniDFA15_1367419142 -->|"[0-9A-Z_a-su-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA15_1367419142 -->|"t
ExtendToken 'Vn'"|MiniDFA17_-1358450166
MiniDFA6_-1460448968 -->|"[^%]"|MiniDFA6_-1460448968
MiniDFA6_-1460448968 -->|"%"|MiniDFA7_1744683586
MiniDFA17_-1358450166 -->|"[0-9A-Z_a-xz]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA17_-1358450166 -->|"y
ExtendToken 'Vn''empty'"|MiniDFA18_-1113869385
MiniDFA7_1744683586 -->|"[^%]"|MiniDFA6_-1460448968
MiniDFA7_1744683586 -->|"[%]
ExtendToken 'pattern'"|MiniDFA19_-541931836
MiniDFA18_-1113869385 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516

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
MiniDFA0_-339152269(["MiniDFA0 {1}"])
class MiniDFA0_-339152269 c1000;
MiniDFA8_1794100827[\"MiniDFA8 {1}
AcceptToken 'Vn'"/]
class MiniDFA8_1794100827 c0101;
MiniDFA9_553554605[\"MiniDFA9 {1}
AcceptToken 'Vn'"/]
class MiniDFA9_553554605 c0101;
MiniDFA1_-1189134655(["MiniDFA1 {1}"])
MiniDFA2_215997034(["MiniDFA2 {1}"])
MiniDFA10_-925134283[\"MiniDFA10 {1}
AcceptToken ':'"/]
class MiniDFA10_-925134283 c0101;
MiniDFA11_1289570263[\"MiniDFA11 {1}
AcceptToken ';'"/]
class MiniDFA11_1289570263 c0101;
MiniDFA12_-1201688988[\"MiniDFA12 {1}
AcceptToken '|'"/]
class MiniDFA12_-1201688988 c0101;
MiniDFA13_-1062044516[\"MiniDFA13 {1}
AcceptToken 'Vn'"/]
class MiniDFA13_-1062044516 c0101;
MiniDFA14_-772034862[\"MiniDFA14 {1}
AcceptToken 'Vn'"/]
class MiniDFA14_-772034862 c0101;
MiniDFA3_742957008(["MiniDFA3 {10}"])
MiniDFA4_2001254085(["MiniDFA4 {2}"])
MiniDFA5_7543543(["MiniDFA5 {1}"])
MiniDFA15_1367419142[\"MiniDFA15 {1}
AcceptToken 'Vn'"/]
class MiniDFA15_1367419142 c0101;
MiniDFA16_667520748[\"MiniDFA16 {1}
AcceptToken 'Vt'"/]
class MiniDFA16_667520748 c0101;
MiniDFA6_-1460448968(["MiniDFA6 {3}"])
MiniDFA17_-1358450166[\"MiniDFA17 {1}
AcceptToken 'Vn'"/]
class MiniDFA17_-1358450166 c0101;
MiniDFA7_1744683586(["MiniDFA7 {1}"])
MiniDFA18_-1113869385[\"MiniDFA18 {1}
AcceptToken 'Vn'
AcceptToken 'empty'"/]
class MiniDFA18_-1113869385 c0101;
MiniDFA19_-541931836[\"MiniDFA19 {1}
AcceptToken 'pattern'"/]
class MiniDFA19_-541931836 c0101;
MiniDFA0_-339152269 -->|"[A-Z_a-df-z]
BeginToken 'Vn'
ExtendToken 'Vn'"|MiniDFA8_1794100827
MiniDFA0_-339152269 -->|"e
BeginToken 'Vn''empty'
ExtendToken 'Vn'"|MiniDFA9_553554605
MiniDFA0_-339152269 -->|"'
BeginToken 'Vt'"|MiniDFA1_-1189134655
MiniDFA0_-339152269 -->|"[%]
BeginToken 'pattern'"|MiniDFA2_215997034
MiniDFA0_-339152269 -->|":
BeginToken ':'
ExtendToken ':'"|MiniDFA10_-925134283
MiniDFA0_-339152269 -->|";
BeginToken ';'
ExtendToken ';'"|MiniDFA11_1289570263
MiniDFA0_-339152269 -->|"|
BeginToken '|'
ExtendToken '|'"|MiniDFA12_-1201688988
MiniDFA8_1794100827 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA9_553554605 -->|"[0-9A-Z_a-ln-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA9_553554605 -->|"m
ExtendToken 'Vn'"|MiniDFA14_-772034862
MiniDFA1_-1189134655 -->|"[#32;-&]"|MiniDFA3_742957008
MiniDFA1_-1189134655 -->|"#92;"|MiniDFA4_2001254085
MiniDFA1_-1189134655 -->|"[(-[]"|MiniDFA3_742957008
MiniDFA1_-1189134655 -->|"[]-~]"|MiniDFA3_742957008
MiniDFA2_215997034 -->|"[%]"|MiniDFA5_7543543
MiniDFA13_-1062044516 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA14_-772034862 -->|"[0-9A-Z_a-oq-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA14_-772034862 -->|"p
ExtendToken 'Vn'"|MiniDFA15_1367419142
MiniDFA3_742957008 -->|"[#32;-&]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"#92;"|MiniDFA4_2001254085
MiniDFA3_742957008 -->|"[(-[]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"[]-~]"|MiniDFA3_742957008
MiniDFA3_742957008 -->|"'
ExtendToken 'Vt'"|MiniDFA16_667520748
MiniDFA4_2001254085 -->|"'"|MiniDFA3_742957008
MiniDFA4_2001254085 -->|"#92;"|MiniDFA3_742957008
MiniDFA5_7543543 -->|"[#32;-~]"|MiniDFA6_-1460448968
MiniDFA15_1367419142 -->|"[0-9A-Z_a-su-z]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA15_1367419142 -->|"t
ExtendToken 'Vn'"|MiniDFA17_-1358450166
MiniDFA6_-1460448968 -->|"[^%]"|MiniDFA6_-1460448968
MiniDFA6_-1460448968 -->|"%"|MiniDFA7_1744683586
MiniDFA17_-1358450166 -->|"[0-9A-Z_a-xz]
ExtendToken 'Vn'"|MiniDFA13_-1062044516
MiniDFA17_-1358450166 -->|"y
ExtendToken 'Vn''empty'"|MiniDFA18_-1113869385
MiniDFA7_1744683586 -->|"[^%]"|MiniDFA6_-1460448968
MiniDFA7_1744683586 -->|"[%]
ExtendToken 'pattern'"|MiniDFA19_-541931836
MiniDFA18_-1113869385 -->|"[a-zA-Z0-9_]
ExtendToken 'Vn'"|MiniDFA13_-1062044516

```

# 总结

无。

