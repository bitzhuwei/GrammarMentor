# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Scope`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（54个State）。

## 'firstItem1'
1/3: pre-regex `'['`

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
eNFA0_9_5388817[["εNFA0-9 regex start"]]
eNFA0_0_33841017[["εNFA0-0 char{1, 1}"]]
eNFA0_11_48499355[["εNFA0-11 char{1, 1}"]]
eNFA0_15_34791770[["εNFA0-15 char{1, 1}"]]
eNFA0_19_66669987[["εNFA0-19 char{1, 1}"]]
eNFA0_23_31559901[["εNFA0-23 char{1, 1}"]]
eNFA0_27_6215216[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_33670467[["εNFA0-29 char{1, 1}"]]
eNFA0_31_42953278[["εNFA0-31 char{1, 1}"]]
eNFA0_35_56663498[["εNFA0-35 char{1, 1}"]]
eNFA0_37_26340622[["εNFA0-37 char{1, 1}"]]
eNFA0_41_53215667[["εNFA0-41 scope{1, 1}"]]
eNFA0_1_31306641[["εNFA0-1 char[1]"]]
eNFA0_12_13324316[["εNFA0-12 char[1]"]]
eNFA0_16_52809984[["εNFA0-16 char[1]"]]
eNFA0_20_5527815[["εNFA0-20 char[1]"]]
eNFA0_24_49750336[["εNFA0-24 char[1]"]]
eNFA0_28_55936946[["εNFA0-28 scope[1]"]]
eNFA0_30_34598748[["εNFA0-30 char[1]"]]
eNFA0_32_45099846[["εNFA0-32 char[1]"]]
eNFA0_36_40209438[["εNFA0-36 char[1]"]]
eNFA0_38_3245433[["εNFA0-38 char[1]"]]
eNFA0_42_9178961[["εNFA0-42 scope[1]"]]
eNFA0_2_29208898[["εNFA0-2 char{1, 1}"]]
eNFA0_13_61553490[["εNFA0-13 char{1, 1}"]]
eNFA0_17_17110498[["εNFA0-17 char{1, 1}"]]
eNFA0_21_19776755[["εNFA0-21 char{1, 1}"]]
eNFA0_25_43773070[["εNFA0-25 char{1, 1}"]]
eNFA0_10_56767833[["εNFA0-10 regex end"]]
eNFA0_33_36288557[["εNFA0-33 char{1, 1}"]]
eNFA0_39_53692015[["εNFA0-39 char{1, 1}"]]
eNFA0_3_54085982[["εNFA0-3 char[1]"]]
eNFA0_14_36133698[["εNFA0-14 char[1]"]]
eNFA0_18_44690478[["εNFA0-18 char[1]"]]
eNFA0_22_63158979[["εNFA0-22 char[1]"]]
eNFA0_26_15603660[["εNFA0-26 char[1]"]]
eNFA0_34_51035186[["εNFA0-34 char[1]"]]
eNFA0_40_35739013[["εNFA0-40 char[1]"]]
eNFA0_4_17011793[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_2767222[["εNFA0-5 scope[1]"]]
eNFA0_6_24904998[["εNFA0-6 scope[2]"]]
eNFA0_7_22818395[["εNFA0-7 scope[3]"]]
eNFA0_8_41148454[["εNFA0-8 scope[4]"]]
eNFA0_9_5388817 -.->|"ε"|eNFA0_0_33841017
eNFA0_9_5388817 -.->|"ε"|eNFA0_11_48499355
eNFA0_9_5388817 -.->|"ε"|eNFA0_15_34791770
eNFA0_9_5388817 -.->|"ε"|eNFA0_19_66669987
eNFA0_9_5388817 -.->|"ε"|eNFA0_23_31559901
eNFA0_9_5388817 -.->|"ε"|eNFA0_27_6215216
eNFA0_9_5388817 -.->|"ε"|eNFA0_29_33670467
eNFA0_9_5388817 -.->|"ε"|eNFA0_31_42953278
eNFA0_9_5388817 -.->|"ε"|eNFA0_35_56663498
eNFA0_9_5388817 -.->|"ε"|eNFA0_37_26340622
eNFA0_9_5388817 -.->|"ε"|eNFA0_41_53215667
eNFA0_0_33841017 -->|"#92;"|eNFA0_1_31306641
eNFA0_11_48499355 -->|"#92;"|eNFA0_12_13324316
eNFA0_15_34791770 -->|"#92;"|eNFA0_16_52809984
eNFA0_19_66669987 -->|"#92;"|eNFA0_20_5527815
eNFA0_23_31559901 -->|"#92;"|eNFA0_24_49750336
eNFA0_27_6215216 -->|"[#32;-Z]"|eNFA0_28_55936946
eNFA0_29_33670467 -->|"["|eNFA0_30_34598748
eNFA0_31_42953278 -->|"#92;"|eNFA0_32_45099846
eNFA0_35_56663498 -->|"]"|eNFA0_36_40209438
eNFA0_37_26340622 -->|"#92;"|eNFA0_38_3245433
eNFA0_41_53215667 -->|"[_-~]"|eNFA0_42_9178961
eNFA0_1_31306641 -.->|"ε"|eNFA0_2_29208898
eNFA0_12_13324316 -.->|"ε"|eNFA0_13_61553490
eNFA0_16_52809984 -.->|"ε"|eNFA0_17_17110498
eNFA0_20_5527815 -.->|"ε"|eNFA0_21_19776755
eNFA0_24_49750336 -.->|"ε"|eNFA0_25_43773070
eNFA0_28_55936946 -.->|"ε"|eNFA0_10_56767833
eNFA0_30_34598748 -.->|"ε"|eNFA0_10_56767833
eNFA0_32_45099846 -.->|"ε"|eNFA0_33_36288557
eNFA0_36_40209438 -.->|"ε"|eNFA0_10_56767833
eNFA0_38_3245433 -.->|"ε"|eNFA0_39_53692015
eNFA0_42_9178961 -.->|"ε"|eNFA0_10_56767833
eNFA0_2_29208898 -->|"u"|eNFA0_3_54085982
eNFA0_13_61553490 -->|"t"|eNFA0_14_36133698
eNFA0_17_17110498 -->|"n"|eNFA0_18_44690478
eNFA0_21_19776755 -->|"r"|eNFA0_22_63158979
eNFA0_25_43773070 -->|"-"|eNFA0_26_15603660
eNFA0_33_36288557 -->|"#92;"|eNFA0_34_51035186
eNFA0_39_53692015 -->|"^"|eNFA0_40_35739013
eNFA0_3_54085982 -.->|"ε"|eNFA0_4_17011793
eNFA0_14_36133698 -.->|"ε"|eNFA0_10_56767833
eNFA0_18_44690478 -.->|"ε"|eNFA0_10_56767833
eNFA0_22_63158979 -.->|"ε"|eNFA0_10_56767833
eNFA0_26_15603660 -.->|"ε"|eNFA0_10_56767833
eNFA0_34_51035186 -.->|"ε"|eNFA0_10_56767833
eNFA0_40_35739013 -.->|"ε"|eNFA0_10_56767833
eNFA0_4_17011793 -->|"[0-9]"|eNFA0_5_2767222
eNFA0_5_2767222 -->|"[0-9]"|eNFA0_6_24904998
eNFA0_6_24904998 -->|"[0-9]"|eNFA0_7_22818395
eNFA0_7_22818395 -->|"[0-9]"|eNFA0_8_41148454
eNFA0_8_41148454 -.->|"ε"|eNFA0_10_56767833
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
eNFA0_43_36350684[["εNFA0-43 post-regex start"]]
eNFA0_44_58720707[\"εNFA0-44 post-regex end"/]
eNFA0_43_36350684 -.->|"ε"|eNFA0_44_58720707
```


## 'firstItem2'
1/3: pre-regex `'[^'`

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
eNFA0_9_5298410[["εNFA0-9 regex start"]]
eNFA0_0_26518071[["εNFA0-0 char{1, 1}"]]
eNFA0_11_47685695[["εNFA0-11 char{1, 1}"]]
eNFA0_15_38893071[["εNFA0-15 char{1, 1}"]]
eNFA0_19_63331050[["εNFA0-19 char{1, 1}"]]
eNFA0_23_29541401[["εNFA0-23 char{1, 1}"]]
eNFA0_27_44043269[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_10734997[["εNFA0-29 char{1, 1}"]]
eNFA0_31_64228401[["εNFA0-31 char{1, 1}"]]
eNFA0_35_35118018[["εNFA0-35 char{1, 1}"]]
eNFA0_37_25987248[["εNFA0-37 char{1, 1}"]]
eNFA0_39_24592354[["εNFA0-39 char{1, 1}"]]
eNFA0_43_45823681[["εNFA0-43 scope{1, 1}"]]
eNFA0_1_9712060[["εNFA0-1 char[1]"]]
eNFA0_12_20299676[["εNFA0-12 char[1]"]]
eNFA0_16_48479356[["εNFA0-16 char[1]"]]
eNFA0_20_33661021[["εNFA0-20 char[1]"]]
eNFA0_24_34513736[["εNFA0-24 char[1]"]]
eNFA0_28_60845101[["εNFA0-28 scope[1]"]]
eNFA0_30_29506110[["εNFA0-30 char[1]"]]
eNFA0_32_42188175[["εNFA0-32 char[1]"]]
eNFA0_36_47626714[["εNFA0-36 char[1]"]]
eNFA0_38_32558645[["εNFA0-38 char[1]"]]
eNFA0_40_44149257[["εNFA0-40 char[1]"]]
eNFA0_44_9759948[["εNFA0-44 scope[1]"]]
eNFA0_2_61799001[["εNFA0-2 char{1, 1}"]]
eNFA0_13_19320103[["εNFA0-13 char{1, 1}"]]
eNFA0_17_39663204[["εNFA0-17 char{1, 1}"]]
eNFA0_21_21424521[["εNFA0-21 char{1, 1}"]]
eNFA0_25_58602968[["εNFA0-25 char{1, 1}"]]
eNFA0_10_480161[["εNFA0-10 regex end"]]
eNFA0_33_27391512[["εNFA0-33 char{1, 1}"]]
eNFA0_41_37079903[["εNFA0-41 char{1, 1}"]]
eNFA0_3_50682160[["εNFA0-3 char[1]"]]
eNFA0_14_37336053[["εNFA0-14 char[1]"]]
eNFA0_18_14493323[["εNFA0-18 char[1]"]]
eNFA0_22_33108539[["εNFA0-22 char[1]"]]
eNFA0_26_64546020[["εNFA0-26 char[1]"]]
eNFA0_34_41184704[["εNFA0-34 char[1]"]]
eNFA0_42_20004601[["εNFA0-42 char[1]"]]
eNFA0_4_53486256[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_23939855[["εNFA0-5 scope[1]"]]
eNFA0_6_14132109[["εNFA0-6 scope[2]"]]
eNFA0_7_60080118[["εNFA0-7 scope[3]"]]
eNFA0_8_4321452[["εNFA0-8 scope[4]"]]
eNFA0_9_5298410 -.->|"ε"|eNFA0_0_26518071
eNFA0_9_5298410 -.->|"ε"|eNFA0_11_47685695
eNFA0_9_5298410 -.->|"ε"|eNFA0_15_38893071
eNFA0_9_5298410 -.->|"ε"|eNFA0_19_63331050
eNFA0_9_5298410 -.->|"ε"|eNFA0_23_29541401
eNFA0_9_5298410 -.->|"ε"|eNFA0_27_44043269
eNFA0_9_5298410 -.->|"ε"|eNFA0_29_10734997
eNFA0_9_5298410 -.->|"ε"|eNFA0_31_64228401
eNFA0_9_5298410 -.->|"ε"|eNFA0_35_35118018
eNFA0_9_5298410 -.->|"ε"|eNFA0_37_25987248
eNFA0_9_5298410 -.->|"ε"|eNFA0_39_24592354
eNFA0_9_5298410 -.->|"ε"|eNFA0_43_45823681
eNFA0_0_26518071 -->|"#92;"|eNFA0_1_9712060
eNFA0_11_47685695 -->|"#92;"|eNFA0_12_20299676
eNFA0_15_38893071 -->|"#92;"|eNFA0_16_48479356
eNFA0_19_63331050 -->|"#92;"|eNFA0_20_33661021
eNFA0_23_29541401 -->|"#92;"|eNFA0_24_34513736
eNFA0_27_44043269 -->|"[#32;-Z]"|eNFA0_28_60845101
eNFA0_29_10734997 -->|"["|eNFA0_30_29506110
eNFA0_31_64228401 -->|"#92;"|eNFA0_32_42188175
eNFA0_35_35118018 -->|"]"|eNFA0_36_47626714
eNFA0_37_25987248 -->|"^"|eNFA0_38_32558645
eNFA0_39_24592354 -->|"#92;"|eNFA0_40_44149257
eNFA0_43_45823681 -->|"[_-~]"|eNFA0_44_9759948
eNFA0_1_9712060 -.->|"ε"|eNFA0_2_61799001
eNFA0_12_20299676 -.->|"ε"|eNFA0_13_19320103
eNFA0_16_48479356 -.->|"ε"|eNFA0_17_39663204
eNFA0_20_33661021 -.->|"ε"|eNFA0_21_21424521
eNFA0_24_34513736 -.->|"ε"|eNFA0_25_58602968
eNFA0_28_60845101 -.->|"ε"|eNFA0_10_480161
eNFA0_30_29506110 -.->|"ε"|eNFA0_10_480161
eNFA0_32_42188175 -.->|"ε"|eNFA0_33_27391512
eNFA0_36_47626714 -.->|"ε"|eNFA0_10_480161
eNFA0_38_32558645 -.->|"ε"|eNFA0_10_480161
eNFA0_40_44149257 -.->|"ε"|eNFA0_41_37079903
eNFA0_44_9759948 -.->|"ε"|eNFA0_10_480161
eNFA0_2_61799001 -->|"u"|eNFA0_3_50682160
eNFA0_13_19320103 -->|"t"|eNFA0_14_37336053
eNFA0_17_39663204 -->|"n"|eNFA0_18_14493323
eNFA0_21_21424521 -->|"r"|eNFA0_22_33108539
eNFA0_25_58602968 -->|"-"|eNFA0_26_64546020
eNFA0_33_27391512 -->|"#92;"|eNFA0_34_41184704
eNFA0_41_37079903 -->|"^"|eNFA0_42_20004601
eNFA0_3_50682160 -.->|"ε"|eNFA0_4_53486256
eNFA0_14_37336053 -.->|"ε"|eNFA0_10_480161
eNFA0_18_14493323 -.->|"ε"|eNFA0_10_480161
eNFA0_22_33108539 -.->|"ε"|eNFA0_10_480161
eNFA0_26_64546020 -.->|"ε"|eNFA0_10_480161
eNFA0_34_41184704 -.->|"ε"|eNFA0_10_480161
eNFA0_42_20004601 -.->|"ε"|eNFA0_10_480161
eNFA0_4_53486256 -->|"[0-9]"|eNFA0_5_23939855
eNFA0_5_23939855 -->|"[0-9]"|eNFA0_6_14132109
eNFA0_6_14132109 -->|"[0-9]"|eNFA0_7_60080118
eNFA0_7_60080118 -->|"[0-9]"|eNFA0_8_4321452
eNFA0_8_4321452 -.->|"ε"|eNFA0_10_480161
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
eNFA0_45_34651418[["εNFA0-45 post-regex start"]]
eNFA0_46_43427310[\"εNFA0-46 post-regex end"/]
eNFA0_45_34651418 -.->|"ε"|eNFA0_46_43427310
```


## 'char'
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
eNFA0_9_52358361[["εNFA0-9 regex start"]]
eNFA0_0_13168838[["εNFA0-0 char{1, 1}"]]
eNFA0_11_1463204[["εNFA0-11 char{1, 1}"]]
eNFA0_15_31639905[["εNFA0-15 char{1, 1}"]]
eNFA0_19_12695519[["εNFA0-19 char{1, 1}"]]
eNFA0_23_21704158[["εNFA0-23 char{1, 1}"]]
eNFA0_27_13206406[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_63085950[["εNFA0-29 char{1, 1}"]]
eNFA0_33_9688302[["εNFA0-33 char{1, 1}"]]
eNFA0_37_46555007[["εNFA0-37 char{1, 1}"]]
eNFA0_41_12859224[["εNFA0-41 char{1, 1}"]]
eNFA0_43_34964258[["εNFA0-43 char{1, 1}"]]
eNFA0_47_13532677[["εNFA0-47 scope{1, 1}"]]
eNFA0_1_53082562[["εNFA0-1 char[1]"]]
eNFA0_12_7981010[["εNFA0-12 char[1]"]]
eNFA0_16_4720229[["εNFA0-16 char[1]"]]
eNFA0_20_42482069[["εNFA0-20 char[1]"]]
eNFA0_24_46794306[["εNFA0-24 char[1]"]]
eNFA0_28_51748792[["εNFA0-28 scope[1]"]]
eNFA0_30_18495573[["εNFA0-30 char[1]"]]
eNFA0_34_32242431[["εNFA0-34 char[1]"]]
eNFA0_38_21746425[["εNFA0-38 char[1]"]]
eNFA0_42_48624160[["εNFA0-42 char[1]"]]
eNFA0_44_61500100[["εNFA0-44 char[1]"]]
eNFA0_48_54685231[["εNFA0-48 scope[1]"]]
eNFA0_2_16629994[["εNFA0-2 char{1, 1}"]]
eNFA0_13_15452218[["εNFA0-13 char{1, 1}"]]
eNFA0_17_4852239[["εNFA0-17 char{1, 1}"]]
eNFA0_21_43670152[["εNFA0-21 char{1, 1}"]]
eNFA0_25_57487056[["εNFA0-25 char{1, 1}"]]
eNFA0_10_60042939[["εNFA0-10 regex end"]]
eNFA0_31_47621463[["εNFA0-31 char{1, 1}"]]
eNFA0_35_25939991[["εNFA0-35 char{1, 1}"]]
eNFA0_39_32133327[["εNFA0-39 char{1, 1}"]]
eNFA0_45_37818583[["εNFA0-45 char{1, 1}"]]
eNFA0_3_43406392[["εNFA0-3 char[1]"]]
eNFA0_14_51410680[["εNFA0-14 char[1]"]]
eNFA0_18_16323694[["εNFA0-18 char[1]"]]
eNFA0_22_47150815[["εNFA0-22 char[1]"]]
eNFA0_26_61119702[["εNFA0-26 char[1]"]]
eNFA0_32_30902639[["εNFA0-32 char[1]"]]
eNFA0_36_20085859[["εNFA0-36 char[1]"]]
eNFA0_40_16341883[["εNFA0-40 char[1]"]]
eNFA0_46_46242873[["εNFA0-46 char[1]"]]
eNFA0_4_55113212[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_66642940[["εNFA0-5 scope[1]"]]
eNFA0_6_62915552[["εNFA0-6 scope[2]"]]
eNFA0_7_29369064[["εNFA0-7 scope[3]"]]
eNFA0_8_3515545[["εNFA0-8 scope[4]"]]
eNFA0_9_52358361 -.->|"ε"|eNFA0_0_13168838
eNFA0_9_52358361 -.->|"ε"|eNFA0_11_1463204
eNFA0_9_52358361 -.->|"ε"|eNFA0_15_31639905
eNFA0_9_52358361 -.->|"ε"|eNFA0_19_12695519
eNFA0_9_52358361 -.->|"ε"|eNFA0_23_21704158
eNFA0_9_52358361 -.->|"ε"|eNFA0_27_13206406
eNFA0_9_52358361 -.->|"ε"|eNFA0_29_63085950
eNFA0_9_52358361 -.->|"ε"|eNFA0_33_9688302
eNFA0_9_52358361 -.->|"ε"|eNFA0_37_46555007
eNFA0_9_52358361 -.->|"ε"|eNFA0_41_12859224
eNFA0_9_52358361 -.->|"ε"|eNFA0_43_34964258
eNFA0_9_52358361 -.->|"ε"|eNFA0_47_13532677
eNFA0_0_13168838 -->|"#92;"|eNFA0_1_53082562
eNFA0_11_1463204 -->|"#92;"|eNFA0_12_7981010
eNFA0_15_31639905 -->|"#92;"|eNFA0_16_4720229
eNFA0_19_12695519 -->|"#92;"|eNFA0_20_42482069
eNFA0_23_21704158 -->|"#92;"|eNFA0_24_46794306
eNFA0_27_13206406 -->|"[#32;-Z]"|eNFA0_28_51748792
eNFA0_29_63085950 -->|"#92;"|eNFA0_30_18495573
eNFA0_33_9688302 -->|"#92;"|eNFA0_34_32242431
eNFA0_37_46555007 -->|"#92;"|eNFA0_38_21746425
eNFA0_41_12859224 -->|"^"|eNFA0_42_48624160
eNFA0_43_34964258 -->|"#92;"|eNFA0_44_61500100
eNFA0_47_13532677 -->|"[_-~]"|eNFA0_48_54685231
eNFA0_1_53082562 -.->|"ε"|eNFA0_2_16629994
eNFA0_12_7981010 -.->|"ε"|eNFA0_13_15452218
eNFA0_16_4720229 -.->|"ε"|eNFA0_17_4852239
eNFA0_20_42482069 -.->|"ε"|eNFA0_21_43670152
eNFA0_24_46794306 -.->|"ε"|eNFA0_25_57487056
eNFA0_28_51748792 -.->|"ε"|eNFA0_10_60042939
eNFA0_30_18495573 -.->|"ε"|eNFA0_31_47621463
eNFA0_34_32242431 -.->|"ε"|eNFA0_35_25939991
eNFA0_38_21746425 -.->|"ε"|eNFA0_39_32133327
eNFA0_42_48624160 -.->|"ε"|eNFA0_10_60042939
eNFA0_44_61500100 -.->|"ε"|eNFA0_45_37818583
eNFA0_48_54685231 -.->|"ε"|eNFA0_10_60042939
eNFA0_2_16629994 -->|"u"|eNFA0_3_43406392
eNFA0_13_15452218 -->|"t"|eNFA0_14_51410680
eNFA0_17_4852239 -->|"n"|eNFA0_18_16323694
eNFA0_21_43670152 -->|"r"|eNFA0_22_47150815
eNFA0_25_57487056 -->|"-"|eNFA0_26_61119702
eNFA0_31_47621463 -->|"["|eNFA0_32_30902639
eNFA0_35_25939991 -->|"#92;"|eNFA0_36_20085859
eNFA0_39_32133327 -->|"]"|eNFA0_40_16341883
eNFA0_45_37818583 -->|"^"|eNFA0_46_46242873
eNFA0_3_43406392 -.->|"ε"|eNFA0_4_55113212
eNFA0_14_51410680 -.->|"ε"|eNFA0_10_60042939
eNFA0_18_16323694 -.->|"ε"|eNFA0_10_60042939
eNFA0_22_47150815 -.->|"ε"|eNFA0_10_60042939
eNFA0_26_61119702 -.->|"ε"|eNFA0_10_60042939
eNFA0_32_30902639 -.->|"ε"|eNFA0_10_60042939
eNFA0_36_20085859 -.->|"ε"|eNFA0_10_60042939
eNFA0_40_16341883 -.->|"ε"|eNFA0_10_60042939
eNFA0_46_46242873 -.->|"ε"|eNFA0_10_60042939
eNFA0_4_55113212 -->|"[0-9]"|eNFA0_5_66642940
eNFA0_5_66642940 -->|"[0-9]"|eNFA0_6_62915552
eNFA0_6_62915552 -->|"[0-9]"|eNFA0_7_29369064
eNFA0_7_29369064 -->|"[0-9]"|eNFA0_8_3515545
eNFA0_8_3515545 -.->|"ε"|eNFA0_10_60042939
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
eNFA0_49_30083980[["εNFA0-49 post-regex start"]]
eNFA0_50_2320371[\"εNFA0-50 post-regex end"/]
eNFA0_49_30083980 -.->|"ε"|eNFA0_50_2320371
```


## '['
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
eNFA0_2_16499506[["εNFA0-2 regex start"]]
eNFA0_0_14277834[["εNFA0-0 char{1, 1}"]]
eNFA0_1_61391649[["εNFA0-1 char[1]"]]
eNFA0_3_15653937[["εNFA0-3 regex end"]]
eNFA0_2_16499506 -.->|"ε"|eNFA0_0_14277834
eNFA0_0_14277834 -->|"["|eNFA0_1_61391649
eNFA0_1_61391649 -.->|"ε"|eNFA0_3_15653937
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
eNFA0_4_6667705[["εNFA0-4 post-regex start"]]
eNFA0_5_60009347[\"εNFA0-5 post-regex end"/]
eNFA0_4_6667705 -.->|"ε"|eNFA0_5_60009347
```


## ']'
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
eNFA0_2_66548198[["εNFA0-2 regex start"]]
eNFA0_0_62062874[["εNFA0-0 char{1, 1}"]]
eNFA0_1_21694962[["εNFA0-1 char[1]"]]
eNFA0_3_61036934[["εNFA0-3 regex end"]]
eNFA0_2_66548198 -.->|"ε"|eNFA0_0_62062874
eNFA0_0_62062874 -->|"]"|eNFA0_1_21694962
eNFA0_1_21694962 -.->|"ε"|eNFA0_3_61036934
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
eNFA0_4_12461494[["εNFA0-4 post-regex start"]]
eNFA0_5_45044589[\"εNFA0-5 post-regex end"/]
eNFA0_4_12461494 -.->|"ε"|eNFA0_5_45044589
```


## '[^'
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
eNFA0_4_42606988[["εNFA0-4 regex start"]]
eNFA0_0_47918573[["εNFA0-0 char{1, 1}"]]
eNFA0_1_28613973[["εNFA0-1 char[1]"]]
eNFA0_2_56199165[["εNFA0-2 char{1, 1}"]]
eNFA0_3_36030438[["εNFA0-3 char[1]"]]
eNFA0_5_55838489[["εNFA0-5 regex end"]]
eNFA0_4_42606988 -.->|"ε"|eNFA0_0_47918573
eNFA0_0_47918573 -->|"["|eNFA0_1_28613973
eNFA0_1_28613973 -.->|"ε"|eNFA0_2_56199165
eNFA0_2_56199165 -->|"^"|eNFA0_3_36030438
eNFA0_3_36030438 -.->|"ε"|eNFA0_5_55838489
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
eNFA0_6_32784360[["εNFA0-6 post-regex start"]]
eNFA0_7_26623786[\"εNFA0-7 post-regex end"/]
eNFA0_6_32784360 -.->|"ε"|eNFA0_7_26623786
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
eNFA0_0_64869004[["εNFA0-0 wholeStart"]]
eNFA1_9_43887934[["εNFA1-9 regex start"]]
class eNFA1_9_43887934 c1000;
eNFA2_2_46950130[["εNFA2-2 regex start"]]
class eNFA2_2_46950130 c1000;
eNFA3_2_62876846[["εNFA3-2 regex start"]]
class eNFA3_2_62876846 c1000;
eNFA4_4_18773878[["εNFA4-4 regex start"]]
class eNFA4_4_18773878 c1000;
eNFA1_0_65261728[["εNFA1-0 char{1, 1}"]]
eNFA1_11_59447086[["εNFA1-11 char{1, 1}"]]
eNFA1_15_50484646[["εNFA1-15 char{1, 1}"]]
eNFA1_19_51708631[["εNFA1-19 char{1, 1}"]]
eNFA1_23_62724502[["εNFA1-23 char{1, 1}"]]
eNFA1_27_27649611[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_47519911[["εNFA1-29 char{1, 1}"]]
eNFA1_33_25026019[["εNFA1-33 char{1, 1}"]]
eNFA1_37_23907584[["εNFA1-37 char{1, 1}"]]
eNFA1_41_13841672[["εNFA1-41 char{1, 1}"]]
eNFA1_43_57466186[["εNFA1-43 char{1, 1}"]]
eNFA1_47_47433633[["εNFA1-47 scope{1, 1}"]]
eNFA2_0_1124484[["εNFA2-0 char{1, 1}"]]
eNFA3_0_59859754[["εNFA3-0 char{1, 1}"]]
eNFA4_0_44289175[["εNFA4-0 char{1, 1}"]]
eNFA1_1_12638008[["εNFA1-1 char[1]"]]
eNFA1_12_46633210[["εNFA1-12 char[1]"]]
eNFA1_16_17045709[["εNFA1-16 char[1]"]]
eNFA1_20_19193659[["εNFA1-20 char[1]"]]
eNFA1_24_38525203[["εNFA1-24 char[1]"]]
eNFA1_28_18053840[["εNFA1-28 scope[1]"]]
eNFA1_30_11182512[["εNFA1-30 char[1]"]]
eNFA1_34_33533745[["εNFA1-34 char[1]"]]
eNFA1_38_33368257[["εNFA1-38 char[1]"]]
eNFA1_42_24249517[["εNFA1-42 char[1]"]]
eNFA1_44_31878864[["εNFA1-44 char[1]"]]
eNFA1_48_28266833[["εNFA1-48 scope[1]"]]
eNFA2_1_10120360[["εNFA2-1 char[1]"]]
eNFA3_1_1866874[["εNFA3-1 char[1]"]]
eNFA4_1_18474328[["εNFA4-1 char[1]"]]
eNFA1_2_32051224[["εNFA1-2 char{1, 1}"]]
eNFA1_13_20025562[["εNFA1-13 char{1, 1}"]]
eNFA1_17_46012336[["εNFA1-17 char{1, 1}"]]
eNFA1_21_11457841[["εNFA1-21 char{1, 1}"]]
eNFA1_25_36011712[["εNFA1-25 char{1, 1}"]]
eNFA1_10_16919063[["εNFA1-10 regex end"]]
class eNFA1_10_16919063 c0100;
eNFA1_31_55669957[["εNFA1-31 char{1, 1}"]]
eNFA1_35_31267569[["εNFA1-35 char{1, 1}"]]
eNFA1_39_12972669[["εNFA1-39 char{1, 1}"]]
eNFA1_45_19646075[["εNFA1-45 char{1, 1}"]]
eNFA2_3_23974383[["εNFA2-3 regex end"]]
class eNFA2_3_23974383 c0100;
eNFA3_3_16801866[["εNFA3-3 regex end"]]
class eNFA3_3_16801866 c0100;
eNFA4_2_47828241[["εNFA4-2 char{1, 1}"]]
eNFA1_3_27800986[["εNFA1-3 char[1]"]]
eNFA1_14_53074907[["εNFA1-14 char[1]"]]
eNFA1_18_7912119[["εNFA1-18 char[1]"]]
eNFA1_22_4100215[["εNFA1-22 char[1]"]]
eNFA1_26_36901939[["εNFA1-26 char[1]"]]
eNFA1_49_47197103[["εNFA1-49 post-regex start"]]
class eNFA1_49_47197103 c0010;
eNFA1_32_63681995[["εNFA1-32 char[1]"]]
eNFA1_36_36267050[["εNFA1-36 char[1]"]]
eNFA1_40_57968000[["εNFA1-40 char[1]"]]
eNFA1_46_51949958[["εNFA1-46 char[1]"]]
eNFA2_4_14442856[["εNFA2-4 post-regex start"]]
class eNFA2_4_14442856 c0010;
eNFA5_9_67011287[["εNFA5-9 regex start"]]
class eNFA5_9_67011287 c1000;
eNFA3_4_16999067[["εNFA3-4 post-regex start"]]
class eNFA3_4_16999067 c0010;
eNFA4_3_63058263[["εNFA4-3 char[1]"]]
eNFA1_4_377729[["εNFA1-4 scope{4, 4}"]]
eNFA1_50_22120748[\"εNFA1-50 post-regex end"/]
class eNFA1_50_22120748 c0001;
eNFA2_5_19897990[\"εNFA2-5 post-regex end"/]
class eNFA2_5_19897990 c0001;
eNFA5_0_59205190[["εNFA5-0 char{1, 1}"]]
eNFA5_11_66230678[["εNFA5-11 char{1, 1}"]]
eNFA5_15_63084665[["εNFA5-15 char{1, 1}"]]
eNFA5_19_30891081[["εNFA5-19 char{1, 1}"]]
eNFA5_23_9584278[["εNFA5-23 char{1, 1}"]]
eNFA5_27_19149641[["εNFA5-27 scope{1, 1}"]]
eNFA5_29_38129043[["εNFA5-29 char{1, 1}"]]
eNFA5_31_7617069[["εNFA5-31 char{1, 1}"]]
eNFA5_35_1444760[["εNFA5-35 char{1, 1}"]]
eNFA5_37_13002846[["εNFA5-37 char{1, 1}"]]
eNFA5_41_49916750[["εNFA5-41 scope{1, 1}"]]
eNFA3_5_29020705[\"εNFA3-5 post-regex end"/]
class eNFA3_5_29020705 c0001;
eNFA4_5_30653461[["εNFA4-5 regex end"]]
class eNFA4_5_30653461 c0100;
eNFA1_5_54599876[["εNFA1-5 scope[1]"]]
eNFA0_1_44864185[\"εNFA0-1 wholeEnd"/]
eNFA5_1_2670519[["εNFA5-1 char[1]"]]
eNFA5_12_24034673[["εNFA5-12 char[1]"]]
eNFA5_16_14985473[["εNFA5-16 char[1]"]]
eNFA5_20_651535[["εNFA5-20 char[1]"]]
eNFA5_24_5863820[["εNFA5-24 char[1]"]]
eNFA5_28_16306884[["εNFA5-28 scope[1]"]]
eNFA5_30_46597571[["εNFA5-30 char[1]"]]
eNFA5_32_52774385[["εNFA5-32 char[1]"]]
eNFA5_36_12544235[["εNFA5-36 char[1]"]]
eNFA5_38_5207424[["εNFA5-38 char[1]"]]
eNFA5_42_45789259[["εNFA5-42 scope[1]"]]
eNFA4_6_7445698[["εNFA4-6 post-regex start"]]
class eNFA4_6_7445698 c0010;
eNFA6_9_39341669[["εNFA6-9 regex start"]]
class eNFA6_9_39341669 c1000;
eNFA1_6_367811[["εNFA1-6 scope[2]"]]
eNFA5_2_3310301[["εNFA5-2 char{1, 1}"]]
eNFA5_13_29792711[["εNFA5-13 char{1, 1}"]]
eNFA5_17_66807810[["εNFA5-17 char{1, 1}"]]
eNFA5_21_64399384[["εNFA5-21 char{1, 1}"]]
eNFA5_25_42723544[["εNFA5-25 char{1, 1}"]]
eNFA5_10_16724956[["εNFA5-10 regex end"]]
class eNFA5_10_16724956 c0100;
eNFA5_33_62559925[["εNFA5-33 char{1, 1}"]]
eNFA5_39_34189197[["εNFA5-39 char{1, 1}"]]
eNFA4_7_34747181[\"εNFA4-7 post-regex end"/]
class eNFA4_7_34747181 c0001;
eNFA6_0_32558606[["εNFA6-0 char{1, 1}"]]
eNFA6_11_18530703[["εNFA6-11 char{1, 1}"]]
eNFA6_15_24592002[["εNFA6-15 char{1, 1}"]]
eNFA6_19_20001428[["εNFA6-19 char{1, 1}"]]
eNFA6_23_45795125[["εNFA6-23 char{1, 1}"]]
eNFA6_27_9502942[["εNFA6-27 scope{1, 1}"]]
eNFA6_29_18417616[["εNFA6-29 char{1, 1}"]]
eNFA6_31_31540820[["εNFA6-31 char{1, 1}"]]
eNFA6_35_15431932[["εNFA6-35 char{1, 1}"]]
eNFA6_37_4669664[["εNFA6-37 char{1, 1}"]]
eNFA6_39_42026976[["εNFA6-39 char{1, 1}"]]
eNFA6_43_42698471[["εNFA6-43 scope{1, 1}"]]
eNFA1_7_34588159[["εNFA1-7 scope[3]"]]
eNFA5_3_42857976[["εNFA5-3 char[1]"]]
eNFA5_14_9450147[["εNFA5-14 char[1]"]]
eNFA5_18_17942461[["εNFA5-18 char[1]"]]
eNFA5_22_27264427[["εNFA5-22 char[1]"]]
eNFA5_26_44053252[["εNFA5-26 char[1]"]]
eNFA5_43_26740917[["εNFA5-43 post-regex start"]]
class eNFA5_43_26740917 c0010;
eNFA5_34_60934955[["εNFA5-34 char[1]"]]
eNFA5_40_11543688[["εNFA5-40 char[1]"]]
eNFA6_1_48944014[["εNFA6-1 char[1]"]]
eNFA6_12_37842950[["εNFA6-12 char[1]"]]
eNFA6_16_5042234[["εNFA6-16 char[1]"]]
eNFA6_20_45380106[["εNFA6-20 char[1]"]]
eNFA6_24_5767777[["εNFA6-24 char[1]"]]
eNFA6_28_55781875[["εNFA6-28 scope[1]"]]
eNFA6_30_48741925[["εNFA6-30 char[1]"]]
eNFA6_32_51909999[["εNFA6-32 char[1]"]]
eNFA6_36_32274828[["εNFA6-36 char[1]"]]
eNFA6_38_22038001[["εNFA6-38 char[1]"]]
eNFA6_40_64536813[["εNFA6-40 char[1]"]]
eNFA6_44_64124281[["εNFA6-44 scope[1]"]]
eNFA1_8_64896446[["εNFA1-8 scope[4]"]]
eNFA5_4_43960413[["εNFA5-4 scope{4, 4}"]]
eNFA5_44_62623536[\"εNFA5-44 post-regex end"/]
class eNFA5_44_62623536 c0001;
eNFA6_2_28611243[["εNFA6-2 char{1, 1}"]]
eNFA6_13_56174599[["εNFA6-13 char{1, 1}"]]
eNFA6_17_35809350[["εNFA6-17 char{1, 1}"]]
eNFA6_21_53848695[["εNFA6-21 char{1, 1}"]]
eNFA6_25_14876213[["εNFA6-25 char{1, 1}"]]
eNFA6_10_36024147[["εNFA6-10 regex end"]]
class eNFA6_10_36024147 c0100;
eNFA6_33_26547505[["εNFA6-33 char{1, 1}"]]
eNFA6_41_25778428[["εNFA6-41 char{1, 1}"]]
eNFA5_5_1992332[["εNFA5-5 scope[1]"]]
eNFA6_3_27161214[["εNFA6-3 char[1]"]]
eNFA6_14_40247623[["εNFA6-14 char[1]"]]
eNFA6_18_26684291[["εNFA6-18 char[1]"]]
eNFA6_22_38832030[["εNFA6-22 char[1]"]]
eNFA6_26_13943953[["εNFA6-26 char[1]"]]
eNFA6_45_17859766[["εNFA6-45 post-regex start"]]
class eNFA6_45_17859766 c0010;
eNFA6_34_58386717[["εNFA6-34 char[1]"]]
eNFA6_42_55718412[["εNFA6-42 char[1]"]]
eNFA5_6_43124341[["εNFA5-6 scope[2]"]]
eNFA6_4_52574749[["εNFA6-4 scope{4, 4}"]]
eNFA6_46_16897499[\"εNFA6-46 post-regex end"/]
class eNFA6_46_16897499 c0001;
eNFA5_7_40892727[["εNFA5-7 scope[3]"]]
eNFA6_5_32490229[["εNFA6-5 scope[1]"]]
eNFA5_8_36784332[["εNFA5-8 scope[4]"]]
eNFA6_6_14462858[["εNFA6-6 scope[2]"]]
eNFA6_7_30640827[["εNFA6-7 scope[3]"]]
eNFA6_8_31703661[["εNFA6-8 scope[4]"]]
eNFA0_0_64869004 -.->|"ε"|eNFA1_9_43887934
eNFA0_0_64869004 -.->|"ε"|eNFA2_2_46950130
eNFA0_0_64869004 -.->|"ε"|eNFA3_2_62876846
eNFA0_0_64869004 -.->|"ε"|eNFA4_4_18773878
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_0_65261728
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_11_59447086
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_15_50484646
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_19_51708631
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_23_62724502
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_27_27649611
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_29_47519911
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_33_25026019
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_37_23907584
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_41_13841672
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_43_57466186
eNFA1_9_43887934 -.->|"ε
BeginToken 'char'"|eNFA1_47_47433633
eNFA2_2_46950130 -.->|"ε
BeginToken '['"|eNFA2_0_1124484
eNFA3_2_62876846 -.->|"ε
BeginToken ']'"|eNFA3_0_59859754
eNFA4_4_18773878 -.->|"ε
BeginToken '[^'"|eNFA4_0_44289175
eNFA1_0_65261728 -->|"#92;"|eNFA1_1_12638008
eNFA1_11_59447086 -->|"#92;"|eNFA1_12_46633210
eNFA1_15_50484646 -->|"#92;"|eNFA1_16_17045709
eNFA1_19_51708631 -->|"#92;"|eNFA1_20_19193659
eNFA1_23_62724502 -->|"#92;"|eNFA1_24_38525203
eNFA1_27_27649611 -->|"[#32;-Z]"|eNFA1_28_18053840
eNFA1_29_47519911 -->|"#92;"|eNFA1_30_11182512
eNFA1_33_25026019 -->|"#92;"|eNFA1_34_33533745
eNFA1_37_23907584 -->|"#92;"|eNFA1_38_33368257
eNFA1_41_13841672 -->|"^"|eNFA1_42_24249517
eNFA1_43_57466186 -->|"#92;"|eNFA1_44_31878864
eNFA1_47_47433633 -->|"[_-~]"|eNFA1_48_28266833
eNFA2_0_1124484 -->|"["|eNFA2_1_10120360
eNFA3_0_59859754 -->|"]"|eNFA3_1_1866874
eNFA4_0_44289175 -->|"["|eNFA4_1_18474328
eNFA1_1_12638008 -.->|"ε"|eNFA1_2_32051224
eNFA1_12_46633210 -.->|"ε"|eNFA1_13_20025562
eNFA1_16_17045709 -.->|"ε"|eNFA1_17_46012336
eNFA1_20_19193659 -.->|"ε"|eNFA1_21_11457841
eNFA1_24_38525203 -.->|"ε"|eNFA1_25_36011712
eNFA1_28_18053840 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_30_11182512 -.->|"ε"|eNFA1_31_55669957
eNFA1_34_33533745 -.->|"ε"|eNFA1_35_31267569
eNFA1_38_33368257 -.->|"ε"|eNFA1_39_12972669
eNFA1_42_24249517 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_44_31878864 -.->|"ε"|eNFA1_45_19646075
eNFA1_48_28266833 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA2_1_10120360 -.->|"ε
ExtendToken '['"|eNFA2_3_23974383
eNFA3_1_1866874 -.->|"ε
ExtendToken ']'"|eNFA3_3_16801866
eNFA4_1_18474328 -.->|"ε"|eNFA4_2_47828241
eNFA1_2_32051224 -->|"u"|eNFA1_3_27800986
eNFA1_13_20025562 -->|"t"|eNFA1_14_53074907
eNFA1_17_46012336 -->|"n"|eNFA1_18_7912119
eNFA1_21_11457841 -->|"r"|eNFA1_22_4100215
eNFA1_25_36011712 -->|"-"|eNFA1_26_36901939
eNFA1_10_16919063 -.->|"ε"|eNFA1_49_47197103
eNFA1_31_55669957 -->|"["|eNFA1_32_63681995
eNFA1_35_31267569 -->|"#92;"|eNFA1_36_36267050
eNFA1_39_12972669 -->|"]"|eNFA1_40_57968000
eNFA1_45_19646075 -->|"^"|eNFA1_46_51949958
eNFA2_3_23974383 -.->|"ε"|eNFA2_4_14442856
eNFA2_3_23974383 -.->|"ε
AcceptPrevious '['"|eNFA5_9_67011287
eNFA3_3_16801866 -.->|"ε"|eNFA3_4_16999067
eNFA4_2_47828241 -->|"^"|eNFA4_3_63058263
eNFA1_3_27800986 -.->|"ε"|eNFA1_4_377729
eNFA1_14_53074907 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_18_7912119 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_22_4100215 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_26_36901939 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_49_47197103 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_22120748
eNFA1_32_63681995 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_36_36267050 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_40_57968000 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA1_46_51949958 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA2_4_14442856 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_19897990
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_0_59205190
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_11_66230678
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_15_63084665
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_19_30891081
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_23_9584278
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_27_19149641
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_29_38129043
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_31_7617069
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_35_1444760
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_37_13002846
eNFA5_9_67011287 -.->|"ε
BeginToken 'firstItem1'"|eNFA5_41_49916750
eNFA3_4_16999067 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_29020705
eNFA4_3_63058263 -.->|"ε
ExtendToken '[^'"|eNFA4_5_30653461
eNFA1_4_377729 -->|"[0-9]"|eNFA1_5_54599876
eNFA1_50_22120748 -.->|"ε"|eNFA0_1_44864185
eNFA2_5_19897990 -.->|"ε"|eNFA0_1_44864185
eNFA5_0_59205190 -->|"#92;"|eNFA5_1_2670519
eNFA5_11_66230678 -->|"#92;"|eNFA5_12_24034673
eNFA5_15_63084665 -->|"#92;"|eNFA5_16_14985473
eNFA5_19_30891081 -->|"#92;"|eNFA5_20_651535
eNFA5_23_9584278 -->|"#92;"|eNFA5_24_5863820
eNFA5_27_19149641 -->|"[#32;-Z]"|eNFA5_28_16306884
eNFA5_29_38129043 -->|"["|eNFA5_30_46597571
eNFA5_31_7617069 -->|"#92;"|eNFA5_32_52774385
eNFA5_35_1444760 -->|"]"|eNFA5_36_12544235
eNFA5_37_13002846 -->|"#92;"|eNFA5_38_5207424
eNFA5_41_49916750 -->|"[_-~]"|eNFA5_42_45789259
eNFA3_5_29020705 -.->|"ε"|eNFA0_1_44864185
eNFA4_5_30653461 -.->|"ε"|eNFA4_6_7445698
eNFA4_5_30653461 -.->|"ε
AcceptPrevious '[^'"|eNFA6_9_39341669
eNFA1_5_54599876 -->|"[0-9]"|eNFA1_6_367811
eNFA5_1_2670519 -.->|"ε"|eNFA5_2_3310301
eNFA5_12_24034673 -.->|"ε"|eNFA5_13_29792711
eNFA5_16_14985473 -.->|"ε"|eNFA5_17_66807810
eNFA5_20_651535 -.->|"ε"|eNFA5_21_64399384
eNFA5_24_5863820 -.->|"ε"|eNFA5_25_42723544
eNFA5_28_16306884 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_30_46597571 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_32_52774385 -.->|"ε"|eNFA5_33_62559925
eNFA5_36_12544235 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_38_5207424 -.->|"ε"|eNFA5_39_34189197
eNFA5_42_45789259 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA4_6_7445698 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_34747181
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_0_32558606
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_11_18530703
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_15_24592002
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_19_20001428
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_23_45795125
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_27_9502942
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_29_18417616
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_31_31540820
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_35_15431932
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_37_4669664
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_39_42026976
eNFA6_9_39341669 -.->|"ε
BeginToken 'firstItem2'"|eNFA6_43_42698471
eNFA1_6_367811 -->|"[0-9]"|eNFA1_7_34588159
eNFA5_2_3310301 -->|"u"|eNFA5_3_42857976
eNFA5_13_29792711 -->|"t"|eNFA5_14_9450147
eNFA5_17_66807810 -->|"n"|eNFA5_18_17942461
eNFA5_21_64399384 -->|"r"|eNFA5_22_27264427
eNFA5_25_42723544 -->|"-"|eNFA5_26_44053252
eNFA5_10_16724956 -.->|"ε"|eNFA5_43_26740917
eNFA5_33_62559925 -->|"#92;"|eNFA5_34_60934955
eNFA5_39_34189197 -->|"^"|eNFA5_40_11543688
eNFA4_7_34747181 -.->|"ε"|eNFA0_1_44864185
eNFA6_0_32558606 -->|"#92;"|eNFA6_1_48944014
eNFA6_11_18530703 -->|"#92;"|eNFA6_12_37842950
eNFA6_15_24592002 -->|"#92;"|eNFA6_16_5042234
eNFA6_19_20001428 -->|"#92;"|eNFA6_20_45380106
eNFA6_23_45795125 -->|"#92;"|eNFA6_24_5767777
eNFA6_27_9502942 -->|"[#32;-Z]"|eNFA6_28_55781875
eNFA6_29_18417616 -->|"["|eNFA6_30_48741925
eNFA6_31_31540820 -->|"#92;"|eNFA6_32_51909999
eNFA6_35_15431932 -->|"]"|eNFA6_36_32274828
eNFA6_37_4669664 -->|"^"|eNFA6_38_22038001
eNFA6_39_42026976 -->|"#92;"|eNFA6_40_64536813
eNFA6_43_42698471 -->|"[_-~]"|eNFA6_44_64124281
eNFA1_7_34588159 -->|"[0-9]"|eNFA1_8_64896446
eNFA5_3_42857976 -.->|"ε"|eNFA5_4_43960413
eNFA5_14_9450147 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_18_17942461 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_22_27264427 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_26_44053252 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_43_26740917 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_62623536
eNFA5_34_60934955 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA5_40_11543688 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA6_1_48944014 -.->|"ε"|eNFA6_2_28611243
eNFA6_12_37842950 -.->|"ε"|eNFA6_13_56174599
eNFA6_16_5042234 -.->|"ε"|eNFA6_17_35809350
eNFA6_20_45380106 -.->|"ε"|eNFA6_21_53848695
eNFA6_24_5767777 -.->|"ε"|eNFA6_25_14876213
eNFA6_28_55781875 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_30_48741925 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_32_51909999 -.->|"ε"|eNFA6_33_26547505
eNFA6_36_32274828 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_38_22038001 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_40_64536813 -.->|"ε"|eNFA6_41_25778428
eNFA6_44_64124281 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA1_8_64896446 -.->|"ε
ExtendToken 'char'"|eNFA1_10_16919063
eNFA5_4_43960413 -->|"[0-9]"|eNFA5_5_1992332
eNFA5_44_62623536 -.->|"ε"|eNFA0_1_44864185
eNFA6_2_28611243 -->|"u"|eNFA6_3_27161214
eNFA6_13_56174599 -->|"t"|eNFA6_14_40247623
eNFA6_17_35809350 -->|"n"|eNFA6_18_26684291
eNFA6_21_53848695 -->|"r"|eNFA6_22_38832030
eNFA6_25_14876213 -->|"-"|eNFA6_26_13943953
eNFA6_10_36024147 -.->|"ε"|eNFA6_45_17859766
eNFA6_33_26547505 -->|"#92;"|eNFA6_34_58386717
eNFA6_41_25778428 -->|"^"|eNFA6_42_55718412
eNFA5_5_1992332 -->|"[0-9]"|eNFA5_6_43124341
eNFA6_3_27161214 -.->|"ε"|eNFA6_4_52574749
eNFA6_14_40247623 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_18_26684291 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_22_38832030 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_26_13943953 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_45_17859766 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_16897499
eNFA6_34_58386717 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA6_42_55718412 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147
eNFA5_6_43124341 -->|"[0-9]"|eNFA5_7_40892727
eNFA6_4_52574749 -->|"[0-9]"|eNFA6_5_32490229
eNFA6_46_16897499 -.->|"ε"|eNFA0_1_44864185
eNFA5_7_40892727 -->|"[0-9]"|eNFA5_8_36784332
eNFA6_5_32490229 -->|"[0-9]"|eNFA6_6_14462858
eNFA5_8_36784332 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_16724956
eNFA6_6_14462858 -->|"[0-9]"|eNFA6_7_30640827
eNFA6_7_30640827 -->|"[0-9]"|eNFA6_8_31703661
eNFA6_8_31703661 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_36024147

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
eNFA0_0_26520167[["εNFA0-0 wholeStart"]]
class eNFA0_0_26520167 c1000;
eNFA1_9_649879[["εNFA1-9 regex start"]]
class eNFA1_9_649879 c1000;
eNFA2_2_37354911[["εNFA2-2 regex start"]]
class eNFA2_2_37354911 c1000;
eNFA3_2_5848912[["εNFA3-2 regex start"]]
class eNFA3_2_5848912 c1000;
eNFA4_4_52640211[["εNFA4-4 regex start"]]
class eNFA4_4_52640211 c1000;
eNFA1_0_35998724[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_35998724 c1000;
eNFA1_11_3999858[["εNFA1-11 char{1, 1}"]]
class eNFA1_11_3999858 c1000;
eNFA1_15_55553068[["εNFA1-15 char{1, 1}"]]
class eNFA1_15_55553068 c1000;
eNFA1_19_30215570[["εNFA1-19 char{1, 1}"]]
class eNFA1_19_30215570 c1000;
eNFA1_23_3504679[["εNFA1-23 char{1, 1}"]]
class eNFA1_23_3504679 c1000;
eNFA1_27_31542116[["εNFA1-27 scope{1, 1}"]]
class eNFA1_27_31542116 c1000;
eNFA1_29_15443595[["εNFA1-29 char{1, 1}"]]
class eNFA1_29_15443595 c1000;
eNFA1_33_4774627[["εNFA1-33 char{1, 1}"]]
class eNFA1_33_4774627 c1000;
eNFA1_37_42971646[["εNFA1-37 char{1, 1}"]]
class eNFA1_37_42971646 c1000;
eNFA1_41_51200502[["εNFA1-41 char{1, 1}"]]
class eNFA1_41_51200502 c1000;
eNFA1_43_58151339[["εNFA1-43 char{1, 1}"]]
class eNFA1_43_58151339 c1000;
eNFA1_47_53600006[["εNFA1-47 scope{1, 1}"]]
class eNFA1_47_53600006 c1000;
eNFA2_0_57020674[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_57020674 c1000;
eNFA3_0_55271866[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_55271866 c1000;
eNFA4_0_49521979[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_49521979 c1000;
eNFA1_1_39696990[["εNFA1-1 char[1]"]]
eNFA1_12_21728597[["εNFA1-12 char[1]"]]
eNFA1_16_61339649[["εNFA1-16 char[1]"]]
eNFA1_20_15185931[["εNFA1-20 char[1]"]]
eNFA1_24_2455652[["εNFA1-24 char[1]"]]
eNFA1_28_61835220[\"εNFA1-28 scope[1]
AcceptToken 'char'"/]
class eNFA1_28_61835220 c0111;
eNFA1_30_22100869[["εNFA1-30 char[1]"]]
eNFA1_34_64690095[["εNFA1-34 char[1]"]]
eNFA1_38_45339947[["εNFA1-38 char[1]"]]
eNFA1_42_49645162[\"εNFA1-42 char[1]
AcceptToken 'char'"/]
class eNFA1_42_49645162 c0111;
eNFA1_44_5406347[["εNFA1-44 char[1]"]]
eNFA1_48_42596951[\"εNFA1-48 scope[1]
AcceptToken 'char'"/]
class eNFA1_48_42596951 c0111;
eNFA2_1_43424020[\"εNFA2-1 char[1]
AcceptToken '['"/]
class eNFA2_1_43424020 c1111;
eNFA3_1_27684747[\"εNFA3-1 char[1]
AcceptToken ']'"/]
class eNFA3_1_27684747 c0111;
eNFA4_1_12737606[["εNFA4-1 char[1]"]]
eNFA1_2_10858082[["εNFA1-2 char{1, 1}"]]
eNFA1_3_30613879[["εNFA1-3 char[1]"]]
eNFA1_13_48657127[["εNFA1-13 char{1, 1}"]]
eNFA1_14_3399565[\"εNFA1-14 char[1]
AcceptToken 'char'"/]
class eNFA1_14_3399565 c0111;
eNFA1_17_35260959[["εNFA1-17 char{1, 1}"]]
eNFA1_18_30596085[\"εNFA1-18 char[1]
AcceptToken 'char'"/]
class eNFA1_18_30596085 c0111;
eNFA1_21_48913182[["εNFA1-21 char{1, 1}"]]
eNFA1_22_6929316[\"εNFA1-22 char[1]
AcceptToken 'char'"/]
class eNFA1_22_6929316 c0111;
eNFA1_25_37565460[["εNFA1-25 char{1, 1}"]]
eNFA1_26_62363850[\"εNFA1-26 char[1]
AcceptToken 'char'"/]
class eNFA1_26_62363850 c0111;
eNFA1_10_44153282[\"εNFA1-10 regex end
AcceptToken 'char'"/]
class eNFA1_10_44153282 c0111;
eNFA1_49_65987954[\"εNFA1-49 post-regex start
AcceptToken 'char'"/]
class eNFA1_49_65987954 c0011;
eNFA1_50_7753264[\"εNFA1-50 post-regex end"/]
class eNFA1_50_7753264 c0011;
eNFA0_1_60513797[\"εNFA0-1 wholeEnd"/]
eNFA1_31_2544826[["εNFA1-31 char{1, 1}"]]
eNFA1_32_24403744[\"εNFA1-32 char[1]
AcceptToken 'char'"/]
class eNFA1_32_24403744 c0111;
eNFA1_35_22903442[["εNFA1-35 char{1, 1}"]]
eNFA1_36_18307112[\"εNFA1-36 char[1]
AcceptToken 'char'"/]
class eNFA1_36_18307112 c0111;
eNFA1_39_4804387[["εNFA1-39 char{1, 1}"]]
eNFA1_40_30546281[\"εNFA1-40 char[1]
AcceptToken 'char'"/]
class eNFA1_40_30546281 c0111;
eNFA1_45_43239488[["εNFA1-45 char{1, 1}"]]
eNFA1_46_6481078[\"εNFA1-46 char[1]
AcceptToken 'char'"/]
class eNFA1_46_6481078 c0111;
eNFA2_3_48882283[\"εNFA2-3 regex end
AcceptToken '['"/]
class eNFA2_3_48882283 c1111;
eNFA2_4_41969[\"εNFA2-4 post-regex start
AcceptToken '['"/]
class eNFA2_4_41969 c0011;
eNFA5_9_37287365[\"εNFA5-9 regex start"/]
class eNFA5_9_37287365 c1000;
eNFA2_5_21636836[\"εNFA2-5 post-regex end"/]
class eNFA2_5_21636836 c0011;
eNFA5_0_55205276[\"εNFA5-0 char{1, 1}"/]
class eNFA5_0_55205276 c1000;
eNFA5_11_58329702[\"εNFA5-11 char{1, 1}"/]
class eNFA5_11_58329702 c1000;
eNFA5_15_27085440[\"εNFA5-15 char{1, 1}"/]
class eNFA5_15_27085440 c1000;
eNFA5_19_42442371[\"εNFA5-19 char{1, 1}"/]
class eNFA5_19_42442371 c1000;
eNFA5_23_46437022[\"εNFA5-23 char{1, 1}"/]
class eNFA5_23_46437022 c1000;
eNFA5_27_15280018[\"εNFA5-27 scope{1, 1}"/]
class eNFA5_27_15280018 c1000;
eNFA5_29_3302441[\"εNFA5-29 char{1, 1}"/]
class eNFA5_29_3302441 c1000;
eNFA5_31_29721970[\"εNFA5-31 char{1, 1}"/]
class eNFA5_31_29721970 c1000;
eNFA5_35_66171144[\"εNFA5-35 char{1, 1}"/]
class eNFA5_35_66171144 c1000;
eNFA5_37_58669387[\"εNFA5-37 char{1, 1}"/]
class eNFA5_37_58669387 c1000;
eNFA5_41_58262436[\"εNFA5-41 scope{1, 1}"/]
class eNFA5_41_58262436 c1000;
eNFA5_1_25113165[["εNFA5-1 char[1]"]]
eNFA5_12_24691896[["εNFA5-12 char[1]"]]
eNFA5_16_20900476[["εNFA5-16 char[1]"]]
eNFA5_20_53886563[["εNFA5-20 char[1]"]]
eNFA5_24_15217020[["εNFA5-24 char[1]"]]
eNFA5_28_6951102[\"εNFA5-28 scope[1]
AcceptToken 'firstItem1'"/]
class eNFA5_28_6951102 c0111;
eNFA5_30_48967581[\"εNFA5-30 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_30_48967581 c0111;
eNFA5_32_2735458[["εNFA5-32 char[1]"]]
eNFA5_36_26168421[\"εNFA5-36 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_36_26168421 c0111;
eNFA5_38_24619125[["εNFA5-38 char[1]"]]
eNFA5_42_39267319[\"εNFA5-42 scope[1]
AcceptToken 'firstItem1'"/]
class eNFA5_42_39267319 c0111;
eNFA3_3_47836138[\"εNFA3-3 regex end
AcceptToken ']'"/]
class eNFA3_3_47836138 c0111;
eNFA3_4_27872063[\"εNFA3-4 post-regex start
AcceptToken ']'"/]
class eNFA3_4_27872063 c0011;
eNFA3_5_46866816[\"εNFA3-5 post-regex end"/]
class eNFA3_5_46866816 c0011;
eNFA4_2_47529594[["εNFA4-2 char{1, 1}"]]
eNFA4_3_43044631[\"εNFA4-3 char[1]
AcceptToken '[^'"/]
class eNFA4_3_43044631 c1111;
eNFA1_4_7089456[["εNFA1-4 scope{4, 4}"]]
eNFA1_5_20408248[["εNFA1-5 scope[1]"]]
eNFA5_2_63805112[["εNFA5-2 char{1, 1}"]]
eNFA5_3_37375103[["εNFA5-3 char[1]"]]
eNFA5_13_20245534[["εNFA5-13 char{1, 1}"]]
eNFA5_14_60099398[\"εNFA5-14 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_14_60099398 c0111;
eNFA5_17_47992078[["εNFA5-17 char{1, 1}"]]
eNFA5_18_4023675[\"εNFA5-18 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_18_4023675 c0111;
eNFA5_21_29275518[["εNFA5-21 char{1, 1}"]]
eNFA5_22_36213075[\"εNFA5-22 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_22_36213075 c0111;
eNFA5_25_62153071[["εNFA5-25 char{1, 1}"]]
eNFA5_26_57482225[\"εNFA5-26 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_26_57482225 c0111;
eNFA5_10_38055046[\"εNFA5-10 regex end
AcceptToken 'firstItem1'"/]
class eNFA5_10_38055046 c0111;
eNFA5_43_51857364[\"εNFA5-43 post-regex start
AcceptToken 'firstItem1'"/]
class eNFA5_43_51857364 c0011;
eNFA5_44_17930993[\"εNFA5-44 post-regex end"/]
class eNFA5_44_17930993 c0011;
eNFA5_33_22506730[["εNFA5-33 char{1, 1}"]]
eNFA5_34_47577981[\"εNFA5-34 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_34_47577981 c0111;
eNFA5_39_1233985[["εNFA5-39 char{1, 1}"]]
eNFA5_40_25548648[\"εNFA5-40 char[1]
AcceptToken 'firstItem1'"/]
class eNFA5_40_25548648 c0111;
eNFA4_5_19148163[\"εNFA4-5 regex end
AcceptToken '[^'"/]
class eNFA4_5_19148163 c1111;
eNFA4_6_7497408[\"εNFA4-6 post-regex start
AcceptToken '[^'"/]
class eNFA4_6_7497408 c0011;
eNFA6_9_38115747[\"εNFA6-9 regex start"/]
class eNFA6_9_38115747 c1000;
eNFA4_7_50177466[\"εNFA4-7 post-regex end"/]
class eNFA4_7_50177466 c0011;
eNFA6_0_26536286[\"εNFA6-0 char{1, 1}"/]
class eNFA6_0_26536286 c1000;
eNFA6_11_17861557[\"εNFA6-11 char{1, 1}"/]
class eNFA6_11_17861557 c1000;
eNFA6_15_37499989[\"εNFA6-15 char{1, 1}"/]
class eNFA6_15_37499989 c1000;
eNFA6_19_1955586[\"εNFA6-19 char{1, 1}"/]
class eNFA6_19_1955586 c1000;
eNFA6_23_17600278[\"εNFA6-23 char{1, 1}"/]
class eNFA6_23_17600278 c1000;
eNFA6_27_24184778[\"εNFA6-27 scope{1, 1}"/]
class eNFA6_27_24184778 c1000;
eNFA6_29_16336415[\"εNFA6-29 char{1, 1}"/]
class eNFA6_29_16336415 c1000;
eNFA6_31_12810015[\"εNFA6-31 char{1, 1}"/]
class eNFA6_31_12810015 c1000;
eNFA6_35_48181273[\"εNFA6-35 char{1, 1}"/]
class eNFA6_35_48181273 c1000;
eNFA6_37_30978280[\"εNFA6-37 char{1, 1}"/]
class eNFA6_37_30978280 c1000;
eNFA6_39_10369068[\"εNFA6-39 char{1, 1}"/]
class eNFA6_39_10369068 c1000;
eNFA6_43_26212750[\"εNFA6-43 scope{1, 1}"/]
class eNFA6_43_26212750 c1000;
eNFA6_1_32843947[["εNFA6-1 char[1]"]]
eNFA6_12_27160073[["εNFA6-12 char[1]"]]
eNFA6_16_43114070[["εNFA6-16 char[1]"]]
eNFA6_20_52482315[["εNFA6-20 char[1]"]]
eNFA6_24_2578794[["εNFA6-24 char[1]"]]
eNFA6_28_40232425[\"εNFA6-28 scope[1]
AcceptToken 'firstItem2'"/]
class eNFA6_28_40232425 c0111;
eNFA6_30_66777056[\"εNFA6-30 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_30_66777056 c0111;
eNFA6_32_23209146[["εNFA6-32 char[1]"]]
eNFA6_36_37600954[\"εNFA6-36 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_36_37600954 c0111;
eNFA6_38_2864269[\"εNFA6-38 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_38_2864269 c0111;
eNFA6_40_7555725[["εNFA6-40 char[1]"]]
eNFA6_44_30679262[\"εNFA6-44 scope[1]
AcceptToken 'firstItem2'"/]
class eNFA6_44_30679262 c0111;
eNFA1_6_37138565[["εNFA1-6 scope[2]"]]
eNFA5_4_831615[["εNFA5-4 scope{4, 4}"]]
eNFA5_5_49456511[["εNFA5-5 scope[1]"]]
eNFA6_2_7484535[["εNFA6-2 char{1, 1}"]]
eNFA6_3_251953[["εNFA6-3 char[1]"]]
eNFA6_13_892669[["εNFA6-13 char{1, 1}"]]
eNFA6_14_3410696[\"εNFA6-14 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_14_3410696 c0111;
eNFA6_17_8034026[["εNFA6-17 char{1, 1}"]]
eNFA6_18_30696272[\"εNFA6-18 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_18_30696272 c0111;
eNFA6_21_5197373[["εNFA6-21 char{1, 1}"]]
eNFA6_22_7830997[\"εNFA6-22 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_22_7830997 c0111;
eNFA6_25_46776359[["εNFA6-25 char{1, 1}"]]
eNFA6_26_3370112[\"εNFA6-26 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_26_3370112 c0111;
eNFA6_10_64122593[\"εNFA6-10 regex end
AcceptToken 'firstItem2'"/]
class eNFA6_10_64122593 c0111;
eNFA6_45_64063100[\"εNFA6-45 post-regex start
AcceptToken 'firstItem2'"/]
class eNFA6_45_64063100 c0011;
eNFA6_46_23976605[\"εNFA6-46 post-regex end"/]
class eNFA6_46_23976605 c0011;
eNFA6_33_18334049[["εNFA6-33 char{1, 1}"]]
eNFA6_34_30331010[\"εNFA6-34 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_34_30331010 c0111;
eNFA6_41_30788716[["εNFA6-41 char{1, 1}"]]
eNFA6_42_4543636[\"εNFA6-42 char[1]
AcceptToken 'firstItem2'"/]
class eNFA6_42_4543636 c0111;
eNFA1_7_53611072[["εNFA1-7 scope[3]"]]
eNFA5_6_10211813[["εNFA5-6 scope[2]"]]
eNFA6_4_2267583[["εNFA6-4 scope{4, 4}"]]
eNFA6_5_42455420[["εNFA6-5 scope[1]"]]
eNFA1_8_7677910[\"εNFA1-8 scope[4]
AcceptToken 'char'"/]
class eNFA1_8_7677910 c0111;
eNFA5_7_11105867[["εNFA5-7 scope[3]"]]
eNFA6_6_62437253[["εNFA6-6 scope[2]"]]
eNFA5_8_63056859[\"εNFA5-8 scope[4]
AcceptToken 'firstItem1'"/]
class eNFA5_8_63056859 c0111;
eNFA6_7_8662994[["εNFA6-7 scope[3]"]]
eNFA6_8_7331994[\"εNFA6-8 scope[4]
AcceptToken 'firstItem2'"/]
class eNFA6_8_7331994 c0111;
eNFA0_0_26520167 -.->|"ε"|eNFA1_9_649879
eNFA0_0_26520167 -.->|"ε"|eNFA2_2_37354911
eNFA0_0_26520167 -.->|"ε"|eNFA3_2_5848912
eNFA0_0_26520167 -.->|"ε"|eNFA4_4_52640211
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_0_35998724
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_11_3999858
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_15_55553068
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_19_30215570
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_23_3504679
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_27_31542116
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_29_15443595
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_33_4774627
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_37_42971646
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_41_51200502
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_43_58151339
eNFA0_0_26520167 -.->|"ε
BeginToken 'char'"|eNFA1_47_53600006
eNFA0_0_26520167 -.->|"ε
BeginToken '['"|eNFA2_0_57020674
eNFA0_0_26520167 -.->|"ε
BeginToken ']'"|eNFA3_0_55271866
eNFA0_0_26520167 -.->|"ε
BeginToken '[^'"|eNFA4_0_49521979
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_1_39696990
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_12_21728597
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_16_61339649
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_20_15185931
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_24_2455652
eNFA0_0_26520167 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_61835220
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_30_22100869
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_34_64690095
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_38_45339947
eNFA0_0_26520167 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_49645162
eNFA0_0_26520167 -->|"#92;
BeginToken 'char'"|eNFA1_44_5406347
eNFA0_0_26520167 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_42596951
eNFA0_0_26520167 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_43424020
eNFA0_0_26520167 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_27684747
eNFA0_0_26520167 -->|"[
BeginToken '[^'"|eNFA4_1_12737606
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_0_35998724
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_11_3999858
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_15_55553068
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_19_30215570
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_23_3504679
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_27_31542116
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_29_15443595
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_33_4774627
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_37_42971646
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_41_51200502
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_43_58151339
eNFA1_9_649879 -.->|"ε
BeginToken 'char'"|eNFA1_47_53600006
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_1_39696990
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_12_21728597
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_16_61339649
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_20_15185931
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_24_2455652
eNFA1_9_649879 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_61835220
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_30_22100869
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_34_64690095
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_38_45339947
eNFA1_9_649879 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_49645162
eNFA1_9_649879 -->|"#92;
BeginToken 'char'"|eNFA1_44_5406347
eNFA1_9_649879 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_42596951
eNFA2_2_37354911 -.->|"ε
BeginToken '['"|eNFA2_0_57020674
eNFA2_2_37354911 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_43424020
eNFA3_2_5848912 -.->|"ε
BeginToken ']'"|eNFA3_0_55271866
eNFA3_2_5848912 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_27684747
eNFA4_4_52640211 -.->|"ε
BeginToken '[^'"|eNFA4_0_49521979
eNFA4_4_52640211 -->|"[
BeginToken '[^'"|eNFA4_1_12737606
eNFA1_0_35998724 -->|"#92;
BeginToken 'char'"|eNFA1_1_39696990
eNFA1_11_3999858 -->|"#92;
BeginToken 'char'"|eNFA1_12_21728597
eNFA1_15_55553068 -->|"#92;
BeginToken 'char'"|eNFA1_16_61339649
eNFA1_19_30215570 -->|"#92;
BeginToken 'char'"|eNFA1_20_15185931
eNFA1_23_3504679 -->|"#92;
BeginToken 'char'"|eNFA1_24_2455652
eNFA1_27_31542116 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_61835220
eNFA1_29_15443595 -->|"#92;
BeginToken 'char'"|eNFA1_30_22100869
eNFA1_33_4774627 -->|"#92;
BeginToken 'char'"|eNFA1_34_64690095
eNFA1_37_42971646 -->|"#92;
BeginToken 'char'"|eNFA1_38_45339947
eNFA1_41_51200502 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_49645162
eNFA1_43_58151339 -->|"#92;
BeginToken 'char'"|eNFA1_44_5406347
eNFA1_47_53600006 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_42596951
eNFA2_0_57020674 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_43424020
eNFA3_0_55271866 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_27684747
eNFA4_0_49521979 -->|"[
BeginToken '[^'"|eNFA4_1_12737606
eNFA1_1_39696990 -.->|"ε"|eNFA1_2_10858082
eNFA1_1_39696990 -->|"u"|eNFA1_3_30613879
eNFA1_12_21728597 -.->|"ε"|eNFA1_13_48657127
eNFA1_12_21728597 -->|"t
ExtendToken 'char'"|eNFA1_14_3399565
eNFA1_16_61339649 -.->|"ε"|eNFA1_17_35260959
eNFA1_16_61339649 -->|"n
ExtendToken 'char'"|eNFA1_18_30596085
eNFA1_20_15185931 -.->|"ε"|eNFA1_21_48913182
eNFA1_20_15185931 -->|"r
ExtendToken 'char'"|eNFA1_22_6929316
eNFA1_24_2455652 -.->|"ε"|eNFA1_25_37565460
eNFA1_24_2455652 -->|"-
ExtendToken 'char'"|eNFA1_26_62363850
eNFA1_28_61835220 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_28_61835220 -.->|"ε"|eNFA1_49_65987954
eNFA1_28_61835220 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_28_61835220 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_30_22100869 -.->|"ε"|eNFA1_31_2544826
eNFA1_30_22100869 -->|"[
ExtendToken 'char'"|eNFA1_32_24403744
eNFA1_34_64690095 -.->|"ε"|eNFA1_35_22903442
eNFA1_34_64690095 -->|"#92;
ExtendToken 'char'"|eNFA1_36_18307112
eNFA1_38_45339947 -.->|"ε"|eNFA1_39_4804387
eNFA1_38_45339947 -->|"]
ExtendToken 'char'"|eNFA1_40_30546281
eNFA1_42_49645162 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_42_49645162 -.->|"ε"|eNFA1_49_65987954
eNFA1_42_49645162 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_42_49645162 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_44_5406347 -.->|"ε"|eNFA1_45_43239488
eNFA1_44_5406347 -->|"^
ExtendToken 'char'"|eNFA1_46_6481078
eNFA1_48_42596951 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_48_42596951 -.->|"ε"|eNFA1_49_65987954
eNFA1_48_42596951 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_48_42596951 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA2_1_43424020 -.->|"ε
ExtendToken '['"|eNFA2_3_48882283
eNFA2_1_43424020 -.->|"ε"|eNFA2_4_41969
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['"|eNFA5_9_37287365
eNFA2_1_43424020 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_21636836
eNFA2_1_43424020 -.->|"ε
CheckToken '['"|eNFA0_1_60513797
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_0_55205276
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_11_58329702
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_15_27085440
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_19_42442371
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_23_46437022
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_27_15280018
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_29_3302441
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_31_29721970
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_35_66171144
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_37_58669387
eNFA2_1_43424020 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_41_58262436
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_1_25113165
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_12_24691896
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_16_20900476
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_20_53886563
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_24_15217020
eNFA2_1_43424020 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_28_6951102
eNFA2_1_43424020 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_30_48967581
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_32_2735458
eNFA2_1_43424020 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_36_26168421
eNFA2_1_43424020 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_38_24619125
eNFA2_1_43424020 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_42_39267319
eNFA3_1_27684747 -.->|"ε
ExtendToken ']'"|eNFA3_3_47836138
eNFA3_1_27684747 -.->|"ε"|eNFA3_4_27872063
eNFA3_1_27684747 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_46866816
eNFA3_1_27684747 -.->|"ε
CheckToken ']'"|eNFA0_1_60513797
eNFA4_1_12737606 -.->|"ε"|eNFA4_2_47529594
eNFA4_1_12737606 -->|"^
ExtendToken '[^'"|eNFA4_3_43044631
eNFA1_2_10858082 -->|"u"|eNFA1_3_30613879
eNFA1_3_30613879 -.->|"ε"|eNFA1_4_7089456
eNFA1_3_30613879 -->|"[0-9]"|eNFA1_5_20408248
eNFA1_13_48657127 -->|"t
ExtendToken 'char'"|eNFA1_14_3399565
eNFA1_14_3399565 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_14_3399565 -.->|"ε"|eNFA1_49_65987954
eNFA1_14_3399565 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_14_3399565 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_17_35260959 -->|"n
ExtendToken 'char'"|eNFA1_18_30596085
eNFA1_18_30596085 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_18_30596085 -.->|"ε"|eNFA1_49_65987954
eNFA1_18_30596085 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_18_30596085 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_21_48913182 -->|"r
ExtendToken 'char'"|eNFA1_22_6929316
eNFA1_22_6929316 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_22_6929316 -.->|"ε"|eNFA1_49_65987954
eNFA1_22_6929316 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_22_6929316 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_25_37565460 -->|"-
ExtendToken 'char'"|eNFA1_26_62363850
eNFA1_26_62363850 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_26_62363850 -.->|"ε"|eNFA1_49_65987954
eNFA1_26_62363850 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_26_62363850 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_10_44153282 -.->|"ε"|eNFA1_49_65987954
eNFA1_10_44153282 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_10_44153282 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_49_65987954 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_49_65987954 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_50_7753264 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_31_2544826 -->|"[
ExtendToken 'char'"|eNFA1_32_24403744
eNFA1_32_24403744 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_32_24403744 -.->|"ε"|eNFA1_49_65987954
eNFA1_32_24403744 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_32_24403744 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_35_22903442 -->|"#92;
ExtendToken 'char'"|eNFA1_36_18307112
eNFA1_36_18307112 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_36_18307112 -.->|"ε"|eNFA1_49_65987954
eNFA1_36_18307112 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_36_18307112 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_39_4804387 -->|"]
ExtendToken 'char'"|eNFA1_40_30546281
eNFA1_40_30546281 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_40_30546281 -.->|"ε"|eNFA1_49_65987954
eNFA1_40_30546281 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_40_30546281 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA1_45_43239488 -->|"^
ExtendToken 'char'"|eNFA1_46_6481078
eNFA1_46_6481078 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_46_6481078 -.->|"ε"|eNFA1_49_65987954
eNFA1_46_6481078 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_46_6481078 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA2_3_48882283 -.->|"ε"|eNFA2_4_41969
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['"|eNFA5_9_37287365
eNFA2_3_48882283 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_21636836
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_0_55205276
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_11_58329702
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_15_27085440
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_19_42442371
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_23_46437022
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_27_15280018
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_29_3302441
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_31_29721970
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_35_66171144
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_37_58669387
eNFA2_3_48882283 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_41_58262436
eNFA2_3_48882283 -.->|"ε
CheckToken '['"|eNFA0_1_60513797
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_1_25113165
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_12_24691896
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_16_20900476
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_20_53886563
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_24_15217020
eNFA2_3_48882283 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_28_6951102
eNFA2_3_48882283 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_30_48967581
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_32_2735458
eNFA2_3_48882283 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_36_26168421
eNFA2_3_48882283 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_38_24619125
eNFA2_3_48882283 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_42_39267319
eNFA2_4_41969 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_21636836
eNFA2_4_41969 -.->|"ε
CheckToken '['"|eNFA0_1_60513797
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_0_55205276
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_11_58329702
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_15_27085440
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_19_42442371
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_23_46437022
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_27_15280018
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_29_3302441
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_31_29721970
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_35_66171144
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_37_58669387
eNFA5_9_37287365 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_41_58262436
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_1_25113165
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_12_24691896
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_16_20900476
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_20_53886563
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_24_15217020
eNFA5_9_37287365 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_28_6951102
eNFA5_9_37287365 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_30_48967581
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_32_2735458
eNFA5_9_37287365 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_36_26168421
eNFA5_9_37287365 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_38_24619125
eNFA5_9_37287365 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_42_39267319
eNFA2_5_21636836 -.->|"ε
CheckToken '['"|eNFA0_1_60513797
eNFA5_0_55205276 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_1_25113165
eNFA5_11_58329702 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_12_24691896
eNFA5_15_27085440 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_16_20900476
eNFA5_19_42442371 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_20_53886563
eNFA5_23_46437022 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_24_15217020
eNFA5_27_15280018 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_28_6951102
eNFA5_29_3302441 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_30_48967581
eNFA5_31_29721970 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_32_2735458
eNFA5_35_66171144 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_36_26168421
eNFA5_37_58669387 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA5_38_24619125
eNFA5_41_58262436 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA5_42_39267319
eNFA5_1_25113165 -.->|"ε"|eNFA5_2_63805112
eNFA5_1_25113165 -->|"u"|eNFA5_3_37375103
eNFA5_12_24691896 -.->|"ε"|eNFA5_13_20245534
eNFA5_12_24691896 -->|"t
ExtendToken 'firstItem1'"|eNFA5_14_60099398
eNFA5_16_20900476 -.->|"ε"|eNFA5_17_47992078
eNFA5_16_20900476 -->|"n
ExtendToken 'firstItem1'"|eNFA5_18_4023675
eNFA5_20_53886563 -.->|"ε"|eNFA5_21_29275518
eNFA5_20_53886563 -->|"r
ExtendToken 'firstItem1'"|eNFA5_22_36213075
eNFA5_24_15217020 -.->|"ε"|eNFA5_25_62153071
eNFA5_24_15217020 -->|"-
ExtendToken 'firstItem1'"|eNFA5_26_57482225
eNFA5_28_6951102 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_28_6951102 -.->|"ε"|eNFA5_43_51857364
eNFA5_28_6951102 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_28_6951102 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_30_48967581 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_30_48967581 -.->|"ε"|eNFA5_43_51857364
eNFA5_30_48967581 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_30_48967581 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_32_2735458 -.->|"ε"|eNFA5_33_22506730
eNFA5_32_2735458 -->|"#92;
ExtendToken 'firstItem1'"|eNFA5_34_47577981
eNFA5_36_26168421 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_36_26168421 -.->|"ε"|eNFA5_43_51857364
eNFA5_36_26168421 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_36_26168421 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_38_24619125 -.->|"ε"|eNFA5_39_1233985
eNFA5_38_24619125 -->|"^
ExtendToken 'firstItem1'"|eNFA5_40_25548648
eNFA5_42_39267319 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_42_39267319 -.->|"ε"|eNFA5_43_51857364
eNFA5_42_39267319 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_42_39267319 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA3_3_47836138 -.->|"ε"|eNFA3_4_27872063
eNFA3_3_47836138 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_46866816
eNFA3_3_47836138 -.->|"ε
CheckToken ']'"|eNFA0_1_60513797
eNFA3_4_27872063 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_46866816
eNFA3_4_27872063 -.->|"ε
CheckToken ']'"|eNFA0_1_60513797
eNFA3_5_46866816 -.->|"ε
CheckToken ']'"|eNFA0_1_60513797
eNFA4_2_47529594 -->|"^
ExtendToken '[^'"|eNFA4_3_43044631
eNFA4_3_43044631 -.->|"ε
ExtendToken '[^'"|eNFA4_5_19148163
eNFA4_3_43044631 -.->|"ε"|eNFA4_6_7497408
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'"|eNFA6_9_38115747
eNFA4_3_43044631 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_50177466
eNFA4_3_43044631 -.->|"ε
CheckToken '[^'"|eNFA0_1_60513797
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_0_26536286
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_11_17861557
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_15_37499989
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_19_1955586
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_23_17600278
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_27_24184778
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_29_16336415
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_31_12810015
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_35_48181273
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_37_30978280
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_39_10369068
eNFA4_3_43044631 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_43_26212750
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_1_32843947
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_12_27160073
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_16_43114070
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_20_52482315
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_24_2578794
eNFA4_3_43044631 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_28_40232425
eNFA4_3_43044631 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_30_66777056
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_32_23209146
eNFA4_3_43044631 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_36_37600954
eNFA4_3_43044631 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_38_2864269
eNFA4_3_43044631 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_40_7555725
eNFA4_3_43044631 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_44_30679262
eNFA1_4_7089456 -->|"[0-9]"|eNFA1_5_20408248
eNFA1_5_20408248 -->|"[0-9]"|eNFA1_6_37138565
eNFA5_2_63805112 -->|"u"|eNFA5_3_37375103
eNFA5_3_37375103 -.->|"ε"|eNFA5_4_831615
eNFA5_3_37375103 -->|"[0-9]"|eNFA5_5_49456511
eNFA5_13_20245534 -->|"t
ExtendToken 'firstItem1'"|eNFA5_14_60099398
eNFA5_14_60099398 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_14_60099398 -.->|"ε"|eNFA5_43_51857364
eNFA5_14_60099398 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_14_60099398 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_17_47992078 -->|"n
ExtendToken 'firstItem1'"|eNFA5_18_4023675
eNFA5_18_4023675 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_18_4023675 -.->|"ε"|eNFA5_43_51857364
eNFA5_18_4023675 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_18_4023675 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_21_29275518 -->|"r
ExtendToken 'firstItem1'"|eNFA5_22_36213075
eNFA5_22_36213075 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_22_36213075 -.->|"ε"|eNFA5_43_51857364
eNFA5_22_36213075 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_22_36213075 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_25_62153071 -->|"-
ExtendToken 'firstItem1'"|eNFA5_26_57482225
eNFA5_26_57482225 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_26_57482225 -.->|"ε"|eNFA5_43_51857364
eNFA5_26_57482225 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_26_57482225 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_10_38055046 -.->|"ε"|eNFA5_43_51857364
eNFA5_10_38055046 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_10_38055046 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_43_51857364 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_43_51857364 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_44_17930993 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_33_22506730 -->|"#92;
ExtendToken 'firstItem1'"|eNFA5_34_47577981
eNFA5_34_47577981 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_34_47577981 -.->|"ε"|eNFA5_43_51857364
eNFA5_34_47577981 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_34_47577981 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA5_39_1233985 -->|"^
ExtendToken 'firstItem1'"|eNFA5_40_25548648
eNFA5_40_25548648 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_40_25548648 -.->|"ε"|eNFA5_43_51857364
eNFA5_40_25548648 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_40_25548648 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA4_5_19148163 -.->|"ε"|eNFA4_6_7497408
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'"|eNFA6_9_38115747
eNFA4_5_19148163 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_50177466
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_0_26536286
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_11_17861557
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_15_37499989
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_19_1955586
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_23_17600278
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_27_24184778
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_29_16336415
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_31_12810015
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_35_48181273
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_37_30978280
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_39_10369068
eNFA4_5_19148163 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_43_26212750
eNFA4_5_19148163 -.->|"ε
CheckToken '[^'"|eNFA0_1_60513797
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_1_32843947
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_12_27160073
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_16_43114070
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_20_52482315
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_24_2578794
eNFA4_5_19148163 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_28_40232425
eNFA4_5_19148163 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_30_66777056
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_32_23209146
eNFA4_5_19148163 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_36_37600954
eNFA4_5_19148163 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_38_2864269
eNFA4_5_19148163 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_40_7555725
eNFA4_5_19148163 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_44_30679262
eNFA4_6_7497408 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_50177466
eNFA4_6_7497408 -.->|"ε
CheckToken '[^'"|eNFA0_1_60513797
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_0_26536286
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_11_17861557
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_15_37499989
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_19_1955586
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_23_17600278
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_27_24184778
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_29_16336415
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_31_12810015
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_35_48181273
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_37_30978280
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_39_10369068
eNFA6_9_38115747 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_43_26212750
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_1_32843947
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_12_27160073
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_16_43114070
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_20_52482315
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_24_2578794
eNFA6_9_38115747 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_28_40232425
eNFA6_9_38115747 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_30_66777056
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_32_23209146
eNFA6_9_38115747 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_36_37600954
eNFA6_9_38115747 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_38_2864269
eNFA6_9_38115747 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_40_7555725
eNFA6_9_38115747 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_44_30679262
eNFA4_7_50177466 -.->|"ε
CheckToken '[^'"|eNFA0_1_60513797
eNFA6_0_26536286 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_1_32843947
eNFA6_11_17861557 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_12_27160073
eNFA6_15_37499989 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_16_43114070
eNFA6_19_1955586 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_20_52482315
eNFA6_23_17600278 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_24_2578794
eNFA6_27_24184778 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_28_40232425
eNFA6_29_16336415 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_30_66777056
eNFA6_31_12810015 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_32_23209146
eNFA6_35_48181273 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_36_37600954
eNFA6_37_30978280 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_38_2864269
eNFA6_39_10369068 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA6_40_7555725
eNFA6_43_26212750 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA6_44_30679262
eNFA6_1_32843947 -.->|"ε"|eNFA6_2_7484535
eNFA6_1_32843947 -->|"u"|eNFA6_3_251953
eNFA6_12_27160073 -.->|"ε"|eNFA6_13_892669
eNFA6_12_27160073 -->|"t
ExtendToken 'firstItem2'"|eNFA6_14_3410696
eNFA6_16_43114070 -.->|"ε"|eNFA6_17_8034026
eNFA6_16_43114070 -->|"n
ExtendToken 'firstItem2'"|eNFA6_18_30696272
eNFA6_20_52482315 -.->|"ε"|eNFA6_21_5197373
eNFA6_20_52482315 -->|"r
ExtendToken 'firstItem2'"|eNFA6_22_7830997
eNFA6_24_2578794 -.->|"ε"|eNFA6_25_46776359
eNFA6_24_2578794 -->|"-
ExtendToken 'firstItem2'"|eNFA6_26_3370112
eNFA6_28_40232425 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_28_40232425 -.->|"ε"|eNFA6_45_64063100
eNFA6_28_40232425 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_28_40232425 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_30_66777056 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_30_66777056 -.->|"ε"|eNFA6_45_64063100
eNFA6_30_66777056 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_30_66777056 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_32_23209146 -.->|"ε"|eNFA6_33_18334049
eNFA6_32_23209146 -->|"#92;
ExtendToken 'firstItem2'"|eNFA6_34_30331010
eNFA6_36_37600954 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_36_37600954 -.->|"ε"|eNFA6_45_64063100
eNFA6_36_37600954 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_36_37600954 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_38_2864269 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_38_2864269 -.->|"ε"|eNFA6_45_64063100
eNFA6_38_2864269 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_38_2864269 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_40_7555725 -.->|"ε"|eNFA6_41_30788716
eNFA6_40_7555725 -->|"^
ExtendToken 'firstItem2'"|eNFA6_42_4543636
eNFA6_44_30679262 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_44_30679262 -.->|"ε"|eNFA6_45_64063100
eNFA6_44_30679262 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_44_30679262 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA1_6_37138565 -->|"[0-9]"|eNFA1_7_53611072
eNFA5_4_831615 -->|"[0-9]"|eNFA5_5_49456511
eNFA5_5_49456511 -->|"[0-9]"|eNFA5_6_10211813
eNFA6_2_7484535 -->|"u"|eNFA6_3_251953
eNFA6_3_251953 -.->|"ε"|eNFA6_4_2267583
eNFA6_3_251953 -->|"[0-9]"|eNFA6_5_42455420
eNFA6_13_892669 -->|"t
ExtendToken 'firstItem2'"|eNFA6_14_3410696
eNFA6_14_3410696 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_14_3410696 -.->|"ε"|eNFA6_45_64063100
eNFA6_14_3410696 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_14_3410696 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_17_8034026 -->|"n
ExtendToken 'firstItem2'"|eNFA6_18_30696272
eNFA6_18_30696272 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_18_30696272 -.->|"ε"|eNFA6_45_64063100
eNFA6_18_30696272 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_18_30696272 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_21_5197373 -->|"r
ExtendToken 'firstItem2'"|eNFA6_22_7830997
eNFA6_22_7830997 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_22_7830997 -.->|"ε"|eNFA6_45_64063100
eNFA6_22_7830997 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_22_7830997 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_25_46776359 -->|"-
ExtendToken 'firstItem2'"|eNFA6_26_3370112
eNFA6_26_3370112 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_26_3370112 -.->|"ε"|eNFA6_45_64063100
eNFA6_26_3370112 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_26_3370112 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_10_64122593 -.->|"ε"|eNFA6_45_64063100
eNFA6_10_64122593 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_10_64122593 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_45_64063100 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_45_64063100 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_46_23976605 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_33_18334049 -->|"#92;
ExtendToken 'firstItem2'"|eNFA6_34_30331010
eNFA6_34_30331010 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_34_30331010 -.->|"ε"|eNFA6_45_64063100
eNFA6_34_30331010 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_34_30331010 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA6_41_30788716 -->|"^
ExtendToken 'firstItem2'"|eNFA6_42_4543636
eNFA6_42_4543636 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_42_4543636 -.->|"ε"|eNFA6_45_64063100
eNFA6_42_4543636 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_42_4543636 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797
eNFA1_7_53611072 -->|"[0-9]
ExtendToken 'char'"|eNFA1_8_7677910
eNFA5_6_10211813 -->|"[0-9]"|eNFA5_7_11105867
eNFA6_4_2267583 -->|"[0-9]"|eNFA6_5_42455420
eNFA6_5_42455420 -->|"[0-9]"|eNFA6_6_62437253
eNFA1_8_7677910 -.->|"ε
ExtendToken 'char'"|eNFA1_10_44153282
eNFA1_8_7677910 -.->|"ε"|eNFA1_49_65987954
eNFA1_8_7677910 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_7753264
eNFA1_8_7677910 -.->|"ε
CheckToken 'char'"|eNFA0_1_60513797
eNFA5_7_11105867 -->|"[0-9]
ExtendToken 'firstItem1'"|eNFA5_8_63056859
eNFA6_6_62437253 -->|"[0-9]"|eNFA6_7_8662994
eNFA5_8_63056859 -.->|"ε
ExtendToken 'firstItem1'"|eNFA5_10_38055046
eNFA5_8_63056859 -.->|"ε"|eNFA5_43_51857364
eNFA5_8_63056859 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA5_44_17930993
eNFA5_8_63056859 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_60513797
eNFA6_7_8662994 -->|"[0-9]
ExtendToken 'firstItem2'"|eNFA6_8_7331994
eNFA6_8_7331994 -.->|"ε
ExtendToken 'firstItem2'"|eNFA6_10_64122593
eNFA6_8_7331994 -.->|"ε"|eNFA6_45_64063100
eNFA6_8_7331994 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA6_46_23976605
eNFA6_8_7331994 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_60513797

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
NFA0_0_46554464("NFA0-0 wholeStart")
class NFA0_0_46554464 c1000;
NFA1_1_16336996("NFA1-1 char[1]")
NFA1_12_12815241("NFA1-12 char[1]")
NFA1_16_48228313("NFA1-16 char[1]")
NFA1_20_31401635("NFA1-20 char[1]")
NFA1_24_14179266("NFA1-24 char[1]")
NFA1_28_60504534[\"NFA1-28 scope[1]
AcceptToken 'char'"/]
class NFA1_28_60504534 c0101;
NFA1_30_7669896("NFA1-30 char[1]")
NFA1_34_1920201("NFA1-34 char[1]")
NFA1_38_17281810("NFA1-38 char[1]")
NFA1_42_21318564[\"NFA1-42 char[1]
AcceptToken 'char'"/]
class NFA1_42_21318564 c0101;
NFA1_44_57649352("NFA1-44 char[1]")
NFA1_48_49082128[\"NFA1-48 scope[1]
AcceptToken 'char'"/]
class NFA1_48_49082128 c0101;
NFA2_1_39085972[\"NFA2-1 char[1]
AcceptToken '['"/]
class NFA2_1_39085972 c1101;
NFA3_1_16229428[\"NFA3-1 char[1]
AcceptToken ']'"/]
class NFA3_1_16229428 c0101;
NFA4_1_11847131("NFA4-1 char[1]")
NFA1_3_30612527("NFA1-3 char[1]")
NFA1_14_39515321[\"NFA1-14 char[1]
AcceptToken 'char'"/]
class NFA1_14_39515321 c0101;
NFA1_18_20093575[\"NFA1-18 char[1]
AcceptToken 'char'"/]
class NFA1_18_20093575 c0101;
NFA1_22_46624455[\"NFA1-22 char[1]
AcceptToken 'char'"/]
class NFA1_22_46624455 c0101;
NFA1_26_16966912[\"NFA1-26 char[1]
AcceptToken 'char'"/]
class NFA1_26_16966912 c0101;
NFA1_32_18484485[\"NFA1-32 char[1]
AcceptToken 'char'"/]
class NFA1_32_18484485 c0101;
NFA1_36_32142637[\"NFA1-36 char[1]
AcceptToken 'char'"/]
class NFA1_36_32142637 c0101;
NFA1_40_20848283[\"NFA1-40 char[1]
AcceptToken 'char'"/]
class NFA1_40_20848283 c0101;
NFA1_46_53416823[\"NFA1-46 char[1]
AcceptToken 'char'"/]
class NFA1_46_53416823 c0101;
NFA5_1_10989362("NFA5-1 char[1]")
NFA5_12_31795397("NFA5-12 char[1]")
NFA5_16_17723121("NFA5-16 char[1]")
NFA5_20_25290368("NFA5-20 char[1]")
NFA5_24_26286721("NFA5-24 char[1]")
NFA5_28_35253903[\"NFA5-28 scope[1]
AcceptToken 'firstItem1'"/]
class NFA5_28_35253903 c0101;
NFA5_30_48849674[\"NFA5-30 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_30_48849674 c0101;
NFA5_32_36993883("NFA5-32 char[1]")
NFA5_36_64509491[\"NFA5-36 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_36_64509491 c0101;
NFA5_38_43714507("NFA5-38 char[1]")
NFA5_42_57886244[\"NFA5-42 scope[1]
AcceptToken 'firstItem1'"/]
class NFA5_42_57886244 c0101;
NFA4_3_51214151[\"NFA4-3 char[1]
AcceptToken '[^'"/]
class NFA4_3_51214151 c1101;
NFA1_5_7077291("NFA1-5 scope[1]")
NFA5_3_63695621("NFA5-3 char[1]")
NFA5_14_58274182[\"NFA5-14 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_14_58274182 c0101;
NFA5_18_54705592[\"NFA5-18 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_18_54705592 c0101;
NFA5_22_22588288[\"NFA5-22 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_22_22588288 c0101;
NFA5_26_1968006[\"NFA5-26 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_26_1968006 c0101;
NFA5_34_17712059[\"NFA5-34 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_34_17712059 c0101;
NFA5_40_25190808[\"NFA5-40 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_40_25190808 c0101;
NFA6_1_25390687("NFA6-1 char[1]")
NFA6_12_27189591("NFA6-12 char[1]")
NFA6_16_43379730("NFA6-16 char[1]")
NFA6_20_54873258("NFA6-20 char[1]")
NFA6_24_24097279("NFA6-24 char[1]")
NFA6_28_15548922[\"NFA6-28 scope[1]
AcceptToken 'firstItem2'"/]
class NFA6_28_15548922 c0101;
NFA6_30_5722572[\"NFA6-30 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_30_5722572 c0101;
NFA6_32_51503150("NFA6-32 char[1]")
NFA6_36_60875169[\"NFA6-36 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_36_60875169 c0101;
NFA6_38_11005615[\"NFA6-38 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_38_11005615 c0101;
NFA6_40_31941671("NFA6-40 char[1]")
NFA6_44_19039588[\"NFA6-44 scope[1]
AcceptToken 'firstItem2'"/]
class NFA6_44_19039588 c0101;
NFA1_6_36389678("NFA1-6 scope[2]")
NFA5_5_59071647("NFA5-5 scope[1]")
NFA6_3_61882777("NFA6-3 char[1]")
NFA6_14_65811637[\"NFA6-14 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_14_65811637 c0101;
NFA6_18_55433828[\"NFA6-18 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_18_55433828 c0101;
NFA6_22_29142412[\"NFA6-22 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_22_29142412 c0101;
NFA6_26_60955116[\"NFA6-26 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_26_60955116 c0101;
NFA6_34_11725134[\"NFA6-34 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_34_11725134 c0101;
NFA6_42_38417348[\"NFA6-42 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_42_38417348 c0101;
NFA1_7_21850553("NFA1-7 scope[3]")
NFA5_6_20074085("NFA5-6 scope[2]")
NFA6_5_46449045("NFA6-5 scope[1]")
NFA1_8_24797460[\"NFA1-8 scope[4]
AcceptToken 'char'"/]
class NFA1_8_24797460 c0101;
NFA5_7_24252734("NFA5-7 scope[3]")
NFA6_6_15388225("NFA6-6 scope[2]")
NFA5_8_25064369[\"NFA5-8 scope[4]
AcceptToken 'firstItem1'"/]
class NFA5_8_25064369 c0101;
NFA6_7_18314472("NFA6-7 scope[3]")
NFA6_8_16948022[\"NFA6-8 scope[4]
AcceptToken 'firstItem2'"/]
class NFA6_8_16948022 c0101;
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_1_16336996
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_12_12815241
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_16_48228313
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_20_31401635
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_24_14179266
NFA0_0_46554464 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|NFA1_28_60504534
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_30_7669896
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_34_1920201
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_38_17281810
NFA0_0_46554464 -->|"^
BeginToken 'char'
ExtendToken 'char'"|NFA1_42_21318564
NFA0_0_46554464 -->|"#92;
BeginToken 'char'"|NFA1_44_57649352
NFA0_0_46554464 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|NFA1_48_49082128
NFA0_0_46554464 -->|"[
BeginToken '['
ExtendToken '['"|NFA2_1_39085972
NFA0_0_46554464 -->|"]
BeginToken ']'
ExtendToken ']'"|NFA3_1_16229428
NFA0_0_46554464 -->|"[
BeginToken '[^'"|NFA4_1_11847131
NFA1_1_16336996 -->|"u"|NFA1_3_30612527
NFA1_12_12815241 -->|"t
ExtendToken 'char'"|NFA1_14_39515321
NFA1_16_48228313 -->|"n
ExtendToken 'char'"|NFA1_18_20093575
NFA1_20_31401635 -->|"r
ExtendToken 'char'"|NFA1_22_46624455
NFA1_24_14179266 -->|"-
ExtendToken 'char'"|NFA1_26_16966912
NFA1_30_7669896 -->|"[
ExtendToken 'char'"|NFA1_32_18484485
NFA1_34_1920201 -->|"#92;
ExtendToken 'char'"|NFA1_36_32142637
NFA1_38_17281810 -->|"]
ExtendToken 'char'"|NFA1_40_20848283
NFA1_44_57649352 -->|"^
ExtendToken 'char'"|NFA1_46_53416823
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_1_10989362
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_12_31795397
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_16_17723121
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_20_25290368
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_24_26286721
NFA2_1_39085972 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA5_28_35253903
NFA2_1_39085972 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA5_30_48849674
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_32_36993883
NFA2_1_39085972 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA5_36_64509491
NFA2_1_39085972 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA5_38_43714507
NFA2_1_39085972 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA5_42_57886244
NFA4_1_11847131 -->|"^
ExtendToken '[^'"|NFA4_3_51214151
NFA1_3_30612527 -->|"[0-9]"|NFA1_5_7077291
NFA5_1_10989362 -->|"u"|NFA5_3_63695621
NFA5_12_31795397 -->|"t
ExtendToken 'firstItem1'"|NFA5_14_58274182
NFA5_16_17723121 -->|"n
ExtendToken 'firstItem1'"|NFA5_18_54705592
NFA5_20_25290368 -->|"r
ExtendToken 'firstItem1'"|NFA5_22_22588288
NFA5_24_26286721 -->|"-
ExtendToken 'firstItem1'"|NFA5_26_1968006
NFA5_32_36993883 -->|"#92;
ExtendToken 'firstItem1'"|NFA5_34_17712059
NFA5_38_43714507 -->|"^
ExtendToken 'firstItem1'"|NFA5_40_25190808
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_1_25390687
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_12_27189591
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_16_43379730
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_20_54873258
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_24_24097279
NFA4_3_51214151 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA6_28_15548922
NFA4_3_51214151 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA6_30_5722572
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_32_51503150
NFA4_3_51214151 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA6_36_60875169
NFA4_3_51214151 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA6_38_11005615
NFA4_3_51214151 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA6_40_31941671
NFA4_3_51214151 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA6_44_19039588
NFA1_5_7077291 -->|"[0-9]"|NFA1_6_36389678
NFA5_3_63695621 -->|"[0-9]"|NFA5_5_59071647
NFA6_1_25390687 -->|"u"|NFA6_3_61882777
NFA6_12_27189591 -->|"t
ExtendToken 'firstItem2'"|NFA6_14_65811637
NFA6_16_43379730 -->|"n
ExtendToken 'firstItem2'"|NFA6_18_55433828
NFA6_20_54873258 -->|"r
ExtendToken 'firstItem2'"|NFA6_22_29142412
NFA6_24_24097279 -->|"-
ExtendToken 'firstItem2'"|NFA6_26_60955116
NFA6_32_51503150 -->|"#92;
ExtendToken 'firstItem2'"|NFA6_34_11725134
NFA6_40_31941671 -->|"^
ExtendToken 'firstItem2'"|NFA6_42_38417348
NFA1_6_36389678 -->|"[0-9]"|NFA1_7_21850553
NFA5_5_59071647 -->|"[0-9]"|NFA5_6_20074085
NFA6_3_61882777 -->|"[0-9]"|NFA6_5_46449045
NFA1_7_21850553 -->|"[0-9]
ExtendToken 'char'"|NFA1_8_24797460
NFA5_6_20074085 -->|"[0-9]"|NFA5_7_24252734
NFA6_5_46449045 -->|"[0-9]"|NFA6_6_15388225
NFA5_7_24252734 -->|"[0-9]
ExtendToken 'firstItem1'"|NFA5_8_25064369
NFA6_6_15388225 -->|"[0-9]"|NFA6_7_18314472
NFA6_7_18314472 -->|"[0-9]
ExtendToken 'firstItem2'"|NFA6_8_16948022

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
subgraph DFA0_178694530["DFA0 wholeStart"]
NFA0_0_46554464_0("NFA0-0 wholeStart")
class NFA0_0_46554464_0 c1000;
end
class DFA0_178694530 c1000;
subgraph DFA1_-772889398["DFA1 {9}"]
NFA1_1_16336996_1("NFA1-1 char[1]")
NFA1_12_12815241_2("NFA1-12 char[1]")
NFA1_16_48228313_3("NFA1-16 char[1]")
NFA1_20_31401635_4("NFA1-20 char[1]")
NFA1_24_14179266_5("NFA1-24 char[1]")
NFA1_30_7669896_6("NFA1-30 char[1]")
NFA1_34_1920201_7("NFA1-34 char[1]")
NFA1_38_17281810_8("NFA1-38 char[1]")
NFA1_44_57649352_9("NFA1-44 char[1]")
end
subgraph DFA2_-183236595["DFA2 {1}"]
NFA1_28_60504534_10[\"NFA1-28 scope[1]
AcceptToken 'char'"/]
class NFA1_28_60504534_10 c0101;
end
class DFA2_-183236595 c0101;
subgraph DFA3_987753403["DFA3 {1}"]
NFA1_42_21318564_11[\"NFA1-42 char[1]
AcceptToken 'char'"/]
class NFA1_42_21318564_11 c0101;
end
class DFA3_987753403 c0101;
subgraph DFA4_-678760965["DFA4 {1}"]
NFA1_48_49082128_12[\"NFA1-48 scope[1]
AcceptToken 'char'"/]
class NFA1_48_49082128_12 c0101;
end
class DFA4_-678760965 c0101;
subgraph DFA5_-55324813["DFA5 {2}"]
NFA2_1_39085972_13[\"NFA2-1 char[1]
AcceptToken '['"/]
class NFA2_1_39085972_13 c1101;
NFA4_1_11847131_14("NFA4-1 char[1]")
end
class DFA5_-55324813 c1101;
subgraph DFA6_1405897005["DFA6 {1}"]
NFA3_1_16229428_15[\"NFA3-1 char[1]
AcceptToken ']'"/]
class NFA3_1_16229428_15 c0101;
end
class DFA6_1405897005 c0101;
subgraph DFA7_-526014914["DFA7 {1}"]
NFA1_3_30612527_16("NFA1-3 char[1]")
end
subgraph DFA8_-77729058["DFA8 {1}"]
NFA1_14_39515321_17[\"NFA1-14 char[1]
AcceptToken 'char'"/]
class NFA1_14_39515321_17 c0101;
end
class DFA8_-77729058 c0101;
subgraph DFA9_-1969299243["DFA9 {1}"]
NFA1_18_20093575_18[\"NFA1-18 char[1]
AcceptToken 'char'"/]
class NFA1_18_20093575_18 c0101;
end
class DFA9_-1969299243 c0101;
subgraph DFA10_1210241937["DFA10 {1}"]
NFA1_22_46624455_19[\"NFA1-22 char[1]
AcceptToken 'char'"/]
class NFA1_22_46624455_19 c0101;
end
class DFA10_1210241937 c0101;
subgraph DFA11_757152697["DFA11 {1}"]
NFA1_26_16966912_20[\"NFA1-26 char[1]
AcceptToken 'char'"/]
class NFA1_26_16966912_20 c0101;
end
class DFA11_757152697 c0101;
subgraph DFA12_-598210763["DFA12 {1}"]
NFA1_32_18484485_21[\"NFA1-32 char[1]
AcceptToken 'char'"/]
class NFA1_32_18484485_21 c0101;
end
class DFA12_-598210763 c0101;
subgraph DFA13_288695511["DFA13 {1}"]
NFA1_36_32142637_22[\"NFA1-36 char[1]
AcceptToken 'char'"/]
class NFA1_36_32142637_22 c0101;
end
class DFA13_288695511 c0101;
subgraph DFA14_1527739253["DFA14 {1}"]
NFA1_40_20848283_23[\"NFA1-40 char[1]
AcceptToken 'char'"/]
class NFA1_40_20848283_23 c0101;
end
class DFA14_1527739253 c0101;
subgraph DFA15_690638386["DFA15 {1}"]
NFA1_46_53416823_24[\"NFA1-46 char[1]
AcceptToken 'char'"/]
class NFA1_46_53416823_24 c0101;
end
class DFA15_690638386 c0101;
subgraph DFA16_695270034["DFA16 {7}"]
NFA5_1_10989362_25("NFA5-1 char[1]")
NFA5_12_31795397_26("NFA5-12 char[1]")
NFA5_16_17723121_27("NFA5-16 char[1]")
NFA5_20_25290368_28("NFA5-20 char[1]")
NFA5_24_26286721_29("NFA5-24 char[1]")
NFA5_32_36993883_30("NFA5-32 char[1]")
NFA5_38_43714507_31("NFA5-38 char[1]")
end
subgraph DFA17_-1125009235["DFA17 {1}"]
NFA5_28_35253903_32[\"NFA5-28 scope[1]
AcceptToken 'firstItem1'"/]
class NFA5_28_35253903_32 c0101;
end
class DFA17_-1125009235 c0101;
subgraph DFA18_-1824766574["DFA18 {1}"]
NFA5_30_48849674_33[\"NFA5-30 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_30_48849674_33 c0101;
end
class DFA18_-1824766574 c0101;
subgraph DFA19_-346729537["DFA19 {1}"]
NFA5_36_64509491_34[\"NFA5-36 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_36_64509491_34 c0101;
end
class DFA19_-346729537 c0101;
subgraph DFA20_832646392["DFA20 {1}"]
NFA5_42_57886244_35[\"NFA5-42 scope[1]
AcceptToken 'firstItem1'"/]
class NFA5_42_57886244_35 c0101;
end
class DFA20_832646392 c0101;
subgraph DFA21_348735340["DFA21 {1}"]
NFA4_3_51214151_36[\"NFA4-3 char[1]
AcceptToken '[^'"/]
class NFA4_3_51214151_36 c1101;
end
class DFA21_348735340 c1101;
subgraph DFA22_1623355910["DFA22 {1}"]
NFA1_5_7077291_37("NFA1-5 scope[1]")
end
subgraph DFA23_-966956886["DFA23 {1}"]
NFA5_3_63695621_38("NFA5-3 char[1]")
end
subgraph DFA24_-1306082567["DFA24 {1}"]
NFA5_14_58274182_39[\"NFA5-14 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_14_58274182_39 c0101;
end
class DFA24_-1306082567 c0101;
subgraph DFA25_-1931548102["DFA25 {1}"]
NFA5_18_54705592_40[\"NFA5-18 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_18_54705592_40 c0101;
end
class DFA25_-1931548102 c0101;
subgraph DFA26_481872213["DFA26 {1}"]
NFA5_22_22588288_41[\"NFA5-22 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_22_22588288_41 c0101;
end
class DFA26_481872213 c0101;
subgraph DFA27_-113939776["DFA27 {1}"]
NFA5_26_1968006_42[\"NFA5-26 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_26_1968006_42 c0101;
end
class DFA27_-113939776 c0101;
subgraph DFA28_1197184386["DFA28 {1}"]
NFA5_34_17712059_43[\"NFA5-34 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_34_17712059_43 c0101;
end
class DFA28_1197184386 c0101;
subgraph DFA29_1158683928["DFA29 {1}"]
NFA5_40_25190808_44[\"NFA5-40 char[1]
AcceptToken 'firstItem1'"/]
class NFA5_40_25190808_44 c0101;
end
class DFA29_1158683928 c0101;
subgraph DFA30_1122838131["DFA30 {7}"]
NFA6_1_25390687_45("NFA6-1 char[1]")
NFA6_12_27189591_46("NFA6-12 char[1]")
NFA6_16_43379730_47("NFA6-16 char[1]")
NFA6_20_54873258_48("NFA6-20 char[1]")
NFA6_24_24097279_49("NFA6-24 char[1]")
NFA6_32_51503150_50("NFA6-32 char[1]")
NFA6_40_31941671_51("NFA6-40 char[1]")
end
subgraph DFA31_-380737881["DFA31 {1}"]
NFA6_28_15548922_52[\"NFA6-28 scope[1]
AcceptToken 'firstItem2'"/]
class NFA6_28_15548922_52 c0101;
end
class DFA31_-380737881 c0101;
subgraph DFA32_1297990935["DFA32 {1}"]
NFA6_30_5722572_53[\"NFA6-30 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_30_5722572_53 c0101;
end
class DFA32_1297990935 c0101;
subgraph DFA33_314935890["DFA33 {1}"]
NFA6_36_60875169_54[\"NFA6-36 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_36_60875169_54 c0101;
end
class DFA33_314935890 c0101;
subgraph DFA34_656572424["DFA34 {1}"]
NFA6_38_11005615_55[\"NFA6-38 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_38_11005615_55 c0101;
end
class DFA34_656572424 c0101;
subgraph DFA35_-1581529229["DFA35 {1}"]
NFA6_44_19039588_56[\"NFA6-44 scope[1]
AcceptToken 'firstItem2'"/]
class NFA6_44_19039588_56 c0101;
end
class DFA35_-1581529229 c0101;
subgraph DFA36_88598524["DFA36 {1}"]
NFA1_6_36389678_57("NFA1-6 scope[2]")
end
subgraph DFA37_-697564398["DFA37 {1}"]
NFA5_5_59071647_58("NFA5-5 scope[1]")
end
subgraph DFA38_1602077691["DFA38 {1}"]
NFA6_3_61882777_59("NFA6-3 char[1]")
end
subgraph DFA39_-1400035845["DFA39 {1}"]
NFA6_14_65811637_60[\"NFA6-14 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_14_65811637_60 c0101;
end
class DFA39_-1400035845 c0101;
subgraph DFA40_-309823494["DFA40 {1}"]
NFA6_18_55433828_61[\"NFA6-18 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_18_55433828_61 c0101;
end
class DFA40_-309823494 c0101;
subgraph DFA41_-1920122602["DFA41 {1}"]
NFA6_22_29142412_62[\"NFA6-22 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_22_29142412_62 c0101;
end
class DFA41_-1920122602 c0101;
subgraph DFA42_-367677254["DFA42 {1}"]
NFA6_26_60955116_63[\"NFA6-26 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_26_60955116_63 c0101;
end
class DFA42_-367677254 c0101;
subgraph DFA43_-24807432["DFA43 {1}"]
NFA6_34_11725134_64[\"NFA6-34 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_34_11725134_64 c0101;
end
class DFA43_-24807432 c0101;
subgraph DFA44_533188336["DFA44 {1}"]
NFA6_42_38417348_65[\"NFA6-42 char[1]
AcceptToken 'firstItem2'"/]
class NFA6_42_38417348_65 c0101;
end
class DFA44_533188336 c0101;
subgraph DFA45_-1262852157["DFA45 {1}"]
NFA1_7_21850553_66("NFA1-7 scope[3]")
end
subgraph DFA46_-428432942["DFA46 {1}"]
NFA5_6_20074085_67("NFA5-6 scope[2]")
end
subgraph DFA47_-1789142534["DFA47 {1}"]
NFA6_5_46449045_68("NFA6-5 scope[1]")
end
subgraph DFA48_334064317["DFA48 {1}"]
NFA1_8_24797460_69[\"NFA1-8 scope[4]
AcceptToken 'char'"/]
class NFA1_8_24797460_69 c0101;
end
class DFA48_334064317 c0101;
subgraph DFA49_-2137454313["DFA49 {1}"]
NFA5_7_24252734_70("NFA5-7 scope[3]")
end
subgraph DFA50_1290846263["DFA50 {1}"]
NFA6_6_15388225_71("NFA6-6 scope[2]")
end
subgraph DFA51_-851077430["DFA51 {1}"]
NFA5_8_25064369_72[\"NFA5-8 scope[4]
AcceptToken 'firstItem1'"/]
class NFA5_8_25064369_72 c0101;
end
class DFA51_-851077430 c0101;
subgraph DFA52_-1969594929["DFA52 {1}"]
NFA6_7_18314472_73("NFA6-7 scope[3]")
end
subgraph DFA53_1051069287["DFA53 {1}"]
NFA6_8_16948022_74[\"NFA6-8 scope[4]
AcceptToken 'firstItem2'"/]
class NFA6_8_16948022_74 c0101;
end
class DFA53_1051069287 c0101;
DFA0_178694530 -->|"#92;
BeginToken 'char'"|DFA1_-772889398
DFA0_178694530 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|DFA2_-183236595
DFA0_178694530 -->|"^
BeginToken 'char'
ExtendToken 'char'"|DFA3_987753403
DFA0_178694530 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|DFA4_-678760965
DFA0_178694530 -->|"[
BeginToken '[''[^'
ExtendToken '['"|DFA5_-55324813
DFA0_178694530 -->|"]
BeginToken ']'
ExtendToken ']'"|DFA6_1405897005
DFA1_-772889398 -->|"u"|DFA7_-526014914
DFA1_-772889398 -->|"t
ExtendToken 'char'"|DFA8_-77729058
DFA1_-772889398 -->|"n
ExtendToken 'char'"|DFA9_-1969299243
DFA1_-772889398 -->|"r
ExtendToken 'char'"|DFA10_1210241937
DFA1_-772889398 -->|"-
ExtendToken 'char'"|DFA11_757152697
DFA1_-772889398 -->|"[
ExtendToken 'char'"|DFA12_-598210763
DFA1_-772889398 -->|"#92;
ExtendToken 'char'"|DFA13_288695511
DFA1_-772889398 -->|"]
ExtendToken 'char'"|DFA14_1527739253
DFA1_-772889398 -->|"^
ExtendToken 'char'"|DFA15_690638386
DFA5_-55324813 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|DFA16_695270034
DFA5_-55324813 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA17_-1125009235
DFA5_-55324813 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA18_-1824766574
DFA5_-55324813 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA19_-346729537
DFA5_-55324813 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA20_832646392
DFA5_-55324813 -->|"^
ExtendToken '[^'"|DFA21_348735340
DFA7_-526014914 -->|"[0-9]"|DFA22_1623355910
DFA16_695270034 -->|"u"|DFA23_-966956886
DFA16_695270034 -->|"t
ExtendToken 'firstItem1'"|DFA24_-1306082567
DFA16_695270034 -->|"n
ExtendToken 'firstItem1'"|DFA25_-1931548102
DFA16_695270034 -->|"r
ExtendToken 'firstItem1'"|DFA26_481872213
DFA16_695270034 -->|"-
ExtendToken 'firstItem1'"|DFA27_-113939776
DFA16_695270034 -->|"#92;
ExtendToken 'firstItem1'"|DFA28_1197184386
DFA16_695270034 -->|"^
ExtendToken 'firstItem1'"|DFA29_1158683928
DFA21_348735340 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|DFA30_1122838131
DFA21_348735340 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA31_-380737881
DFA21_348735340 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA32_1297990935
DFA21_348735340 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA33_314935890
DFA21_348735340 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA34_656572424
DFA21_348735340 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA35_-1581529229
DFA22_1623355910 -->|"[0-9]"|DFA36_88598524
DFA23_-966956886 -->|"[0-9]"|DFA37_-697564398
DFA30_1122838131 -->|"u"|DFA38_1602077691
DFA30_1122838131 -->|"t
ExtendToken 'firstItem2'"|DFA39_-1400035845
DFA30_1122838131 -->|"n
ExtendToken 'firstItem2'"|DFA40_-309823494
DFA30_1122838131 -->|"r
ExtendToken 'firstItem2'"|DFA41_-1920122602
DFA30_1122838131 -->|"-
ExtendToken 'firstItem2'"|DFA42_-367677254
DFA30_1122838131 -->|"#92;
ExtendToken 'firstItem2'"|DFA43_-24807432
DFA30_1122838131 -->|"^
ExtendToken 'firstItem2'"|DFA44_533188336
DFA36_88598524 -->|"[0-9]"|DFA45_-1262852157
DFA37_-697564398 -->|"[0-9]"|DFA46_-428432942
DFA38_1602077691 -->|"[0-9]"|DFA47_-1789142534
DFA45_-1262852157 -->|"[0-9]
ExtendToken 'char'"|DFA48_334064317
DFA46_-428432942 -->|"[0-9]"|DFA49_-2137454313
DFA47_-1789142534 -->|"[0-9]"|DFA50_1290846263
DFA49_-2137454313 -->|"[0-9]
ExtendToken 'firstItem1'"|DFA51_-851077430
DFA50_1290846263 -->|"[0-9]"|DFA52_-1969594929
DFA52_-1969594929 -->|"[0-9]
ExtendToken 'firstItem2'"|DFA53_1051069287

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
DFA0_178694530{{"DFA0 wholeStart"}}
class DFA0_178694530 c1000;
DFA1_-772889398{{"DFA1 {9}"}}
DFA2_-183236595[\"DFA2 {1}
AcceptToken 'char'"/]
class DFA2_-183236595 c0101;
DFA3_987753403[\"DFA3 {1}
AcceptToken 'char'"/]
class DFA3_987753403 c0101;
DFA4_-678760965[\"DFA4 {1}
AcceptToken 'char'"/]
class DFA4_-678760965 c0101;
DFA5_-55324813[\"DFA5 {2}
AcceptToken '['"/]
class DFA5_-55324813 c1101;
DFA6_1405897005[\"DFA6 {1}
AcceptToken ']'"/]
class DFA6_1405897005 c0101;
DFA7_-526014914{{"DFA7 {1}"}}
DFA8_-77729058[\"DFA8 {1}
AcceptToken 'char'"/]
class DFA8_-77729058 c0101;
DFA9_-1969299243[\"DFA9 {1}
AcceptToken 'char'"/]
class DFA9_-1969299243 c0101;
DFA10_1210241937[\"DFA10 {1}
AcceptToken 'char'"/]
class DFA10_1210241937 c0101;
DFA11_757152697[\"DFA11 {1}
AcceptToken 'char'"/]
class DFA11_757152697 c0101;
DFA12_-598210763[\"DFA12 {1}
AcceptToken 'char'"/]
class DFA12_-598210763 c0101;
DFA13_288695511[\"DFA13 {1}
AcceptToken 'char'"/]
class DFA13_288695511 c0101;
DFA14_1527739253[\"DFA14 {1}
AcceptToken 'char'"/]
class DFA14_1527739253 c0101;
DFA15_690638386[\"DFA15 {1}
AcceptToken 'char'"/]
class DFA15_690638386 c0101;
DFA16_695270034{{"DFA16 {7}"}}
DFA17_-1125009235[\"DFA17 {1}
AcceptToken 'firstItem1'"/]
class DFA17_-1125009235 c0101;
DFA18_-1824766574[\"DFA18 {1}
AcceptToken 'firstItem1'"/]
class DFA18_-1824766574 c0101;
DFA19_-346729537[\"DFA19 {1}
AcceptToken 'firstItem1'"/]
class DFA19_-346729537 c0101;
DFA20_832646392[\"DFA20 {1}
AcceptToken 'firstItem1'"/]
class DFA20_832646392 c0101;
DFA21_348735340[\"DFA21 {1}
AcceptToken '[^'"/]
class DFA21_348735340 c1101;
DFA22_1623355910{{"DFA22 {1}"}}
DFA23_-966956886{{"DFA23 {1}"}}
DFA24_-1306082567[\"DFA24 {1}
AcceptToken 'firstItem1'"/]
class DFA24_-1306082567 c0101;
DFA25_-1931548102[\"DFA25 {1}
AcceptToken 'firstItem1'"/]
class DFA25_-1931548102 c0101;
DFA26_481872213[\"DFA26 {1}
AcceptToken 'firstItem1'"/]
class DFA26_481872213 c0101;
DFA27_-113939776[\"DFA27 {1}
AcceptToken 'firstItem1'"/]
class DFA27_-113939776 c0101;
DFA28_1197184386[\"DFA28 {1}
AcceptToken 'firstItem1'"/]
class DFA28_1197184386 c0101;
DFA29_1158683928[\"DFA29 {1}
AcceptToken 'firstItem1'"/]
class DFA29_1158683928 c0101;
DFA30_1122838131{{"DFA30 {7}"}}
DFA31_-380737881[\"DFA31 {1}
AcceptToken 'firstItem2'"/]
class DFA31_-380737881 c0101;
DFA32_1297990935[\"DFA32 {1}
AcceptToken 'firstItem2'"/]
class DFA32_1297990935 c0101;
DFA33_314935890[\"DFA33 {1}
AcceptToken 'firstItem2'"/]
class DFA33_314935890 c0101;
DFA34_656572424[\"DFA34 {1}
AcceptToken 'firstItem2'"/]
class DFA34_656572424 c0101;
DFA35_-1581529229[\"DFA35 {1}
AcceptToken 'firstItem2'"/]
class DFA35_-1581529229 c0101;
DFA36_88598524{{"DFA36 {1}"}}
DFA37_-697564398{{"DFA37 {1}"}}
DFA38_1602077691{{"DFA38 {1}"}}
DFA39_-1400035845[\"DFA39 {1}
AcceptToken 'firstItem2'"/]
class DFA39_-1400035845 c0101;
DFA40_-309823494[\"DFA40 {1}
AcceptToken 'firstItem2'"/]
class DFA40_-309823494 c0101;
DFA41_-1920122602[\"DFA41 {1}
AcceptToken 'firstItem2'"/]
class DFA41_-1920122602 c0101;
DFA42_-367677254[\"DFA42 {1}
AcceptToken 'firstItem2'"/]
class DFA42_-367677254 c0101;
DFA43_-24807432[\"DFA43 {1}
AcceptToken 'firstItem2'"/]
class DFA43_-24807432 c0101;
DFA44_533188336[\"DFA44 {1}
AcceptToken 'firstItem2'"/]
class DFA44_533188336 c0101;
DFA45_-1262852157{{"DFA45 {1}"}}
DFA46_-428432942{{"DFA46 {1}"}}
DFA47_-1789142534{{"DFA47 {1}"}}
DFA48_334064317[\"DFA48 {1}
AcceptToken 'char'"/]
class DFA48_334064317 c0101;
DFA49_-2137454313{{"DFA49 {1}"}}
DFA50_1290846263{{"DFA50 {1}"}}
DFA51_-851077430[\"DFA51 {1}
AcceptToken 'firstItem1'"/]
class DFA51_-851077430 c0101;
DFA52_-1969594929{{"DFA52 {1}"}}
DFA53_1051069287[\"DFA53 {1}
AcceptToken 'firstItem2'"/]
class DFA53_1051069287 c0101;
DFA0_178694530 -->|"#92;
BeginToken 'char'"|DFA1_-772889398
DFA0_178694530 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|DFA2_-183236595
DFA0_178694530 -->|"^
BeginToken 'char'
ExtendToken 'char'"|DFA3_987753403
DFA0_178694530 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|DFA4_-678760965
DFA0_178694530 -->|"[
BeginToken '[''[^'
ExtendToken '['"|DFA5_-55324813
DFA0_178694530 -->|"]
BeginToken ']'
ExtendToken ']'"|DFA6_1405897005
DFA1_-772889398 -->|"u"|DFA7_-526014914
DFA1_-772889398 -->|"t
ExtendToken 'char'"|DFA8_-77729058
DFA1_-772889398 -->|"n
ExtendToken 'char'"|DFA9_-1969299243
DFA1_-772889398 -->|"r
ExtendToken 'char'"|DFA10_1210241937
DFA1_-772889398 -->|"-
ExtendToken 'char'"|DFA11_757152697
DFA1_-772889398 -->|"[
ExtendToken 'char'"|DFA12_-598210763
DFA1_-772889398 -->|"#92;
ExtendToken 'char'"|DFA13_288695511
DFA1_-772889398 -->|"]
ExtendToken 'char'"|DFA14_1527739253
DFA1_-772889398 -->|"^
ExtendToken 'char'"|DFA15_690638386
DFA5_-55324813 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|DFA16_695270034
DFA5_-55324813 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA17_-1125009235
DFA5_-55324813 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA18_-1824766574
DFA5_-55324813 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA19_-346729537
DFA5_-55324813 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA20_832646392
DFA5_-55324813 -->|"^
ExtendToken '[^'"|DFA21_348735340
DFA7_-526014914 -->|"[0-9]"|DFA22_1623355910
DFA16_695270034 -->|"u"|DFA23_-966956886
DFA16_695270034 -->|"t
ExtendToken 'firstItem1'"|DFA24_-1306082567
DFA16_695270034 -->|"n
ExtendToken 'firstItem1'"|DFA25_-1931548102
DFA16_695270034 -->|"r
ExtendToken 'firstItem1'"|DFA26_481872213
DFA16_695270034 -->|"-
ExtendToken 'firstItem1'"|DFA27_-113939776
DFA16_695270034 -->|"#92;
ExtendToken 'firstItem1'"|DFA28_1197184386
DFA16_695270034 -->|"^
ExtendToken 'firstItem1'"|DFA29_1158683928
DFA21_348735340 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|DFA30_1122838131
DFA21_348735340 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA31_-380737881
DFA21_348735340 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA32_1297990935
DFA21_348735340 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA33_314935890
DFA21_348735340 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA34_656572424
DFA21_348735340 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA35_-1581529229
DFA22_1623355910 -->|"[0-9]"|DFA36_88598524
DFA23_-966956886 -->|"[0-9]"|DFA37_-697564398
DFA30_1122838131 -->|"u"|DFA38_1602077691
DFA30_1122838131 -->|"t
ExtendToken 'firstItem2'"|DFA39_-1400035845
DFA30_1122838131 -->|"n
ExtendToken 'firstItem2'"|DFA40_-309823494
DFA30_1122838131 -->|"r
ExtendToken 'firstItem2'"|DFA41_-1920122602
DFA30_1122838131 -->|"-
ExtendToken 'firstItem2'"|DFA42_-367677254
DFA30_1122838131 -->|"#92;
ExtendToken 'firstItem2'"|DFA43_-24807432
DFA30_1122838131 -->|"^
ExtendToken 'firstItem2'"|DFA44_533188336
DFA36_88598524 -->|"[0-9]"|DFA45_-1262852157
DFA37_-697564398 -->|"[0-9]"|DFA46_-428432942
DFA38_1602077691 -->|"[0-9]"|DFA47_-1789142534
DFA45_-1262852157 -->|"[0-9]
ExtendToken 'char'"|DFA48_334064317
DFA46_-428432942 -->|"[0-9]"|DFA49_-2137454313
DFA47_-1789142534 -->|"[0-9]"|DFA50_1290846263
DFA49_-2137454313 -->|"[0-9]
ExtendToken 'firstItem1'"|DFA51_-851077430
DFA50_1290846263 -->|"[0-9]"|DFA52_-1969594929
DFA52_-1969594929 -->|"[0-9]
ExtendToken 'firstItem2'"|DFA53_1051069287

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
subgraph MiniDFA0_-1598698416["MiniDFA0 {1}"]
DFA0_178694530_0{{"DFA0 wholeStart"}}
class DFA0_178694530_0 c1000;
end
class MiniDFA0_-1598698416 c1000;
subgraph MiniDFA1_1709522984["MiniDFA1 {1}"]
DFA1_-772889398_1{{"DFA1 {9}"}}
end
subgraph MiniDFA16_829239316["MiniDFA16 {1}"]
DFA2_-183236595_2[\"DFA2 {1}
AcceptToken 'char'"/]
class DFA2_-183236595_2 c0101;
end
class MiniDFA16_829239316 c0101;
subgraph MiniDFA17_-1540748001["MiniDFA17 {1}"]
DFA3_987753403_3[\"DFA3 {1}
AcceptToken 'char'"/]
class DFA3_987753403_3 c0101;
end
class MiniDFA17_-1540748001 c0101;
subgraph MiniDFA18_-829650891["MiniDFA18 {1}"]
DFA4_-678760965_4[\"DFA4 {1}
AcceptToken 'char'"/]
class DFA4_-678760965_4 c0101;
end
class MiniDFA18_-829650891 c0101;
subgraph MiniDFA19_1895575115["MiniDFA19 {1}"]
DFA5_-55324813_5[\"DFA5 {2}
AcceptToken '['"/]
class DFA5_-55324813_5 c1101;
end
class MiniDFA19_1895575115 c1101;
subgraph MiniDFA20_1347270970["MiniDFA20 {1}"]
DFA6_1405897005_6[\"DFA6 {1}
AcceptToken ']'"/]
class DFA6_1405897005_6 c0101;
end
class MiniDFA20_1347270970 c0101;
subgraph MiniDFA2_-1485731032["MiniDFA2 {1}"]
DFA7_-526014914_7{{"DFA7 {1}"}}
end
subgraph MiniDFA21_718644212["MiniDFA21 {1}"]
DFA8_-77729058_8[\"DFA8 {1}
AcceptToken 'char'"/]
class DFA8_-77729058_8 c0101;
end
class MiniDFA21_718644212 c0101;
subgraph MiniDFA22_-300477139["MiniDFA22 {1}"]
DFA9_-1969299243_9[\"DFA9 {1}
AcceptToken 'char'"/]
class DFA9_-1969299243_9 c0101;
end
class MiniDFA22_-300477139 c0101;
subgraph MiniDFA23_-1898055659["MiniDFA23 {1}"]
DFA10_1210241937_10[\"DFA10 {1}
AcceptToken 'char'"/]
class DFA10_1210241937_10 c0101;
end
class MiniDFA23_-1898055659 c0101;
subgraph MiniDFA24_-740909074["MiniDFA24 {1}"]
DFA11_757152697_11[\"DFA11 {1}
AcceptToken 'char'"/]
class DFA11_757152697_11 c0101;
end
class MiniDFA24_-740909074 c0101;
subgraph MiniDFA25_1913534607["MiniDFA25 {1}"]
DFA12_-598210763_12[\"DFA12 {1}
AcceptToken 'char'"/]
class DFA12_-598210763_12 c0101;
end
class MiniDFA25_1913534607 c0101;
subgraph MiniDFA26_811121392["MiniDFA26 {1}"]
DFA13_288695511_13[\"DFA13 {1}
AcceptToken 'char'"/]
class DFA13_288695511_13 c0101;
end
class MiniDFA26_811121392 c0101;
subgraph MiniDFA27_-1358571324["MiniDFA27 {1}"]
DFA14_1527739253_14[\"DFA14 {1}
AcceptToken 'char'"/]
class DFA14_1527739253_14 c0101;
end
class MiniDFA27_-1358571324 c0101;
subgraph MiniDFA28_1846829681["MiniDFA28 {1}"]
DFA15_690638386_15[\"DFA15 {1}
AcceptToken 'char'"/]
class DFA15_690638386_15 c0101;
end
class MiniDFA28_1846829681 c0101;
subgraph MiniDFA11_157963389["MiniDFA11 {1}"]
DFA16_695270034_16{{"DFA16 {7}"}}
end
subgraph MiniDFA29_882298322["MiniDFA29 {1}"]
DFA17_-1125009235_17[\"DFA17 {1}
AcceptToken 'firstItem1'"/]
class DFA17_-1125009235_17 c0101;
end
class MiniDFA29_882298322 c0101;
subgraph MiniDFA30_-631267067["MiniDFA30 {1}"]
DFA18_-1824766574_18[\"DFA18 {1}
AcceptToken 'firstItem1'"/]
class DFA18_-1824766574_18 c0101;
end
class MiniDFA30_-631267067 c0101;
subgraph MiniDFA31_1944258923["MiniDFA31 {1}"]
DFA19_-346729537_19[\"DFA19 {1}
AcceptToken 'firstItem1'"/]
class DFA19_-346729537_19 c0101;
end
class MiniDFA31_1944258923 c0101;
subgraph MiniDFA32_-1267335330["MiniDFA32 {1}"]
DFA20_832646392_20[\"DFA20 {1}
AcceptToken 'firstItem1'"/]
class DFA20_832646392_20 c0101;
end
class MiniDFA32_-1267335330 c0101;
subgraph MiniDFA33_1084664971["MiniDFA33 {1}"]
DFA21_348735340_21[\"DFA21 {1}
AcceptToken '[^'"/]
class DFA21_348735340_21 c1101;
end
class MiniDFA33_1084664971 c1101;
subgraph MiniDFA5_-1501076448["MiniDFA5 {1}"]
DFA22_1623355910_22{{"DFA22 {1}"}}
end
subgraph MiniDFA3_260574151["MiniDFA3 {1}"]
DFA23_-966956886_23{{"DFA23 {1}"}}
end
subgraph MiniDFA34_-202900956["MiniDFA34 {1}"]
DFA24_-1306082567_24[\"DFA24 {1}
AcceptToken 'firstItem1'"/]
class DFA24_-1306082567_24 c0101;
end
class MiniDFA34_-202900956 c0101;
subgraph MiniDFA35_-1716582198["MiniDFA35 {1}"]
DFA25_-1931548102_25[\"DFA25 {1}
AcceptToken 'firstItem1'"/]
class DFA25_-1931548102_25 c0101;
end
class MiniDFA35_-1716582198 c0101;
subgraph MiniDFA36_1637916823["MiniDFA36 {1}"]
DFA26_481872213_26[\"DFA26 {1}
AcceptToken 'firstItem1'"/]
class DFA26_481872213_26 c0101;
end
class MiniDFA36_1637916823 c0101;
subgraph MiniDFA37_1076040990["MiniDFA37 {1}"]
DFA27_-113939776_27[\"DFA27 {1}
AcceptToken 'firstItem1'"/]
class DFA27_-113939776_27 c0101;
end
class MiniDFA37_1076040990 c0101;
subgraph MiniDFA38_971114975["MiniDFA38 {1}"]
DFA28_1197184386_28[\"DFA28 {1}
AcceptToken 'firstItem1'"/]
class DFA28_1197184386_28 c0101;
end
class MiniDFA38_971114975 c0101;
subgraph MiniDFA39_1928364039["MiniDFA39 {1}"]
DFA29_1158683928_29[\"DFA29 {1}
AcceptToken 'firstItem1'"/]
class DFA29_1158683928_29 c0101;
end
class MiniDFA39_1928364039 c0101;
subgraph MiniDFA12_882784311["MiniDFA12 {1}"]
DFA30_1122838131_30{{"DFA30 {7}"}}
end
subgraph MiniDFA40_983298140["MiniDFA40 {1}"]
DFA31_-380737881_31[\"DFA31 {1}
AcceptToken 'firstItem2'"/]
class DFA31_-380737881_31 c0101;
end
class MiniDFA40_983298140 c0101;
subgraph MiniDFA41_-148878662["MiniDFA41 {1}"]
DFA32_1297990935_32[\"DFA32 {1}
AcceptToken 'firstItem2'"/]
class DFA32_1297990935_32 c0101;
end
class MiniDFA41_-148878662 c0101;
subgraph MiniDFA42_1774635322["MiniDFA42 {1}"]
DFA33_314935890_33[\"DFA33 {1}
AcceptToken 'firstItem2'"/]
class DFA33_314935890_33 c0101;
end
class MiniDFA42_1774635322 c0101;
subgraph MiniDFA43_-888236193["MiniDFA43 {1}"]
DFA34_656572424_34[\"DFA34 {1}
AcceptToken 'firstItem2'"/]
class DFA34_656572424_34 c0101;
end
class MiniDFA43_-888236193 c0101;
subgraph MiniDFA44_1153357833["MiniDFA44 {1}"]
DFA35_-1581529229_35[\"DFA35 {1}
AcceptToken 'firstItem2'"/]
class DFA35_-1581529229_35 c0101;
end
class MiniDFA44_1153357833 c0101;
subgraph MiniDFA8_1052350996["MiniDFA8 {1}"]
DFA36_88598524_36{{"DFA36 {1}"}}
end
subgraph MiniDFA6_-745590573["MiniDFA6 {1}"]
DFA37_-697564398_37{{"DFA37 {1}"}}
end
subgraph MiniDFA4_-936000833["MiniDFA4 {1}"]
DFA38_1602077691_38{{"DFA38 {1}"}}
end
subgraph MiniDFA45_1814777571["MiniDFA45 {1}"]
DFA39_-1400035845_39[\"DFA39 {1}
AcceptToken 'firstItem2'"/]
class DFA39_-1400035845_39 c0101;
end
class MiniDFA45_1814777571 c0101;
subgraph MiniDFA46_-326717903["MiniDFA46 {1}"]
DFA40_-309823494_40[\"DFA40 {1}
AcceptToken 'firstItem2'"/]
class DFA40_-309823494_40 c0101;
end
class MiniDFA46_-326717903 c0101;
subgraph MiniDFA47_2112305326["MiniDFA47 {1}"]
DFA41_-1920122602_41[\"DFA41 {1}
AcceptToken 'firstItem2'"/]
class DFA41_-1920122602_41 c0101;
end
class MiniDFA47_2112305326 c0101;
subgraph MiniDFA48_-1089194710["MiniDFA48 {1}"]
DFA42_-367677254_42[\"DFA42 {1}
AcceptToken 'firstItem2'"/]
class DFA42_-367677254_42 c0101;
end
class MiniDFA48_-1089194710 c0101;
subgraph MiniDFA49_-1659177635["MiniDFA49 {1}"]
DFA43_-24807432_43[\"DFA43 {1}
AcceptToken 'firstItem2'"/]
class DFA43_-24807432_43 c0101;
end
class MiniDFA49_-1659177635 c0101;
subgraph MiniDFA50_234026938["MiniDFA50 {1}"]
DFA44_533188336_44[\"DFA44 {1}
AcceptToken 'firstItem2'"/]
class DFA44_533188336_44 c0101;
end
class MiniDFA50_234026938 c0101;
subgraph MiniDFA13_-805951098["MiniDFA13 {1}"]
DFA45_-1262852157_45{{"DFA45 {1}"}}
end
subgraph MiniDFA9_1129701067["MiniDFA9 {1}"]
DFA46_-428432942_46{{"DFA46 {1}"}}
end
subgraph MiniDFA7_1669435006["MiniDFA7 {1}"]
DFA47_-1789142534_47{{"DFA47 {1}"}}
end
subgraph MiniDFA51_1316239270["MiniDFA51 {1}"]
DFA48_334064317_48[\"DFA48 {1}
AcceptToken 'char'"/]
class DFA48_334064317_48 c0101;
end
class MiniDFA51_1316239270 c0101;
subgraph MiniDFA14_945990719["MiniDFA14 {1}"]
DFA49_-2137454313_49{{"DFA49 {1}"}}
end
subgraph MiniDFA10_-876014922["MiniDFA10 {1}"]
DFA50_1290846263_50{{"DFA50 {1}"}}
end
subgraph MiniDFA52_-248145067["MiniDFA52 {1}"]
DFA51_-851077430_51[\"DFA51 {1}
AcceptToken 'firstItem1'"/]
class DFA51_-851077430_51 c0101;
end
class MiniDFA52_-248145067 c0101;
subgraph MiniDFA15_-153120073["MiniDFA15 {1}"]
DFA52_-1969594929_52{{"DFA52 {1}"}}
end
subgraph MiniDFA53_-2043493099["MiniDFA53 {1}"]
DFA53_1051069287_53[\"DFA53 {1}
AcceptToken 'firstItem2'"/]
class DFA53_1051069287_53 c0101;
end
class MiniDFA53_-2043493099 c0101;
MiniDFA0_-1598698416 -->|"#92;
BeginToken 'char'"|MiniDFA1_1709522984
MiniDFA0_-1598698416 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA16_829239316
MiniDFA0_-1598698416 -->|"^
BeginToken 'char'
ExtendToken 'char'"|MiniDFA17_-1540748001
MiniDFA0_-1598698416 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA18_-829650891
MiniDFA0_-1598698416 -->|"[
BeginToken '[''[^'
ExtendToken '['"|MiniDFA19_1895575115
MiniDFA0_-1598698416 -->|"]
BeginToken ']'
ExtendToken ']'"|MiniDFA20_1347270970
MiniDFA1_1709522984 -->|"u"|MiniDFA2_-1485731032
MiniDFA1_1709522984 -->|"t
ExtendToken 'char'"|MiniDFA21_718644212
MiniDFA1_1709522984 -->|"n
ExtendToken 'char'"|MiniDFA22_-300477139
MiniDFA1_1709522984 -->|"r
ExtendToken 'char'"|MiniDFA23_-1898055659
MiniDFA1_1709522984 -->|"-
ExtendToken 'char'"|MiniDFA24_-740909074
MiniDFA1_1709522984 -->|"[
ExtendToken 'char'"|MiniDFA25_1913534607
MiniDFA1_1709522984 -->|"#92;
ExtendToken 'char'"|MiniDFA26_811121392
MiniDFA1_1709522984 -->|"]
ExtendToken 'char'"|MiniDFA27_-1358571324
MiniDFA1_1709522984 -->|"^
ExtendToken 'char'"|MiniDFA28_1846829681
MiniDFA19_1895575115 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|MiniDFA11_157963389
MiniDFA19_1895575115 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA29_882298322
MiniDFA19_1895575115 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA30_-631267067
MiniDFA19_1895575115 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA31_1944258923
MiniDFA19_1895575115 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA32_-1267335330
MiniDFA19_1895575115 -->|"^
ExtendToken '[^'"|MiniDFA33_1084664971
MiniDFA2_-1485731032 -->|"[0-9]"|MiniDFA5_-1501076448
MiniDFA11_157963389 -->|"u"|MiniDFA3_260574151
MiniDFA11_157963389 -->|"t
ExtendToken 'firstItem1'"|MiniDFA34_-202900956
MiniDFA11_157963389 -->|"n
ExtendToken 'firstItem1'"|MiniDFA35_-1716582198
MiniDFA11_157963389 -->|"r
ExtendToken 'firstItem1'"|MiniDFA36_1637916823
MiniDFA11_157963389 -->|"-
ExtendToken 'firstItem1'"|MiniDFA37_1076040990
MiniDFA11_157963389 -->|"#92;
ExtendToken 'firstItem1'"|MiniDFA38_971114975
MiniDFA11_157963389 -->|"^
ExtendToken 'firstItem1'"|MiniDFA39_1928364039
MiniDFA33_1084664971 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|MiniDFA12_882784311
MiniDFA33_1084664971 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA40_983298140
MiniDFA33_1084664971 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA41_-148878662
MiniDFA33_1084664971 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA42_1774635322
MiniDFA33_1084664971 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA43_-888236193
MiniDFA33_1084664971 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA44_1153357833
MiniDFA5_-1501076448 -->|"[0-9]"|MiniDFA8_1052350996
MiniDFA3_260574151 -->|"[0-9]"|MiniDFA6_-745590573
MiniDFA12_882784311 -->|"u"|MiniDFA4_-936000833
MiniDFA12_882784311 -->|"t
ExtendToken 'firstItem2'"|MiniDFA45_1814777571
MiniDFA12_882784311 -->|"n
ExtendToken 'firstItem2'"|MiniDFA46_-326717903
MiniDFA12_882784311 -->|"r
ExtendToken 'firstItem2'"|MiniDFA47_2112305326
MiniDFA12_882784311 -->|"-
ExtendToken 'firstItem2'"|MiniDFA48_-1089194710
MiniDFA12_882784311 -->|"#92;
ExtendToken 'firstItem2'"|MiniDFA49_-1659177635
MiniDFA12_882784311 -->|"^
ExtendToken 'firstItem2'"|MiniDFA50_234026938
MiniDFA8_1052350996 -->|"[0-9]"|MiniDFA13_-805951098
MiniDFA6_-745590573 -->|"[0-9]"|MiniDFA9_1129701067
MiniDFA4_-936000833 -->|"[0-9]"|MiniDFA7_1669435006
MiniDFA13_-805951098 -->|"[0-9]
ExtendToken 'char'"|MiniDFA51_1316239270
MiniDFA9_1129701067 -->|"[0-9]"|MiniDFA14_945990719
MiniDFA7_1669435006 -->|"[0-9]"|MiniDFA10_-876014922
MiniDFA14_945990719 -->|"[0-9]
ExtendToken 'firstItem1'"|MiniDFA52_-248145067
MiniDFA10_-876014922 -->|"[0-9]"|MiniDFA15_-153120073
MiniDFA15_-153120073 -->|"[0-9]
ExtendToken 'firstItem2'"|MiniDFA53_-2043493099

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
MiniDFA0_-1598698416(["MiniDFA0 {1}"])
class MiniDFA0_-1598698416 c1000;
MiniDFA1_1709522984(["MiniDFA1 {1}"])
MiniDFA16_829239316[\"MiniDFA16 {1}
AcceptToken 'char'"/]
class MiniDFA16_829239316 c0101;
MiniDFA17_-1540748001[\"MiniDFA17 {1}
AcceptToken 'char'"/]
class MiniDFA17_-1540748001 c0101;
MiniDFA18_-829650891[\"MiniDFA18 {1}
AcceptToken 'char'"/]
class MiniDFA18_-829650891 c0101;
MiniDFA19_1895575115[\"MiniDFA19 {1}
AcceptToken '['"/]
class MiniDFA19_1895575115 c1101;
MiniDFA20_1347270970[\"MiniDFA20 {1}
AcceptToken ']'"/]
class MiniDFA20_1347270970 c0101;
MiniDFA2_-1485731032(["MiniDFA2 {1}"])
MiniDFA21_718644212[\"MiniDFA21 {1}
AcceptToken 'char'"/]
class MiniDFA21_718644212 c0101;
MiniDFA22_-300477139[\"MiniDFA22 {1}
AcceptToken 'char'"/]
class MiniDFA22_-300477139 c0101;
MiniDFA23_-1898055659[\"MiniDFA23 {1}
AcceptToken 'char'"/]
class MiniDFA23_-1898055659 c0101;
MiniDFA24_-740909074[\"MiniDFA24 {1}
AcceptToken 'char'"/]
class MiniDFA24_-740909074 c0101;
MiniDFA25_1913534607[\"MiniDFA25 {1}
AcceptToken 'char'"/]
class MiniDFA25_1913534607 c0101;
MiniDFA26_811121392[\"MiniDFA26 {1}
AcceptToken 'char'"/]
class MiniDFA26_811121392 c0101;
MiniDFA27_-1358571324[\"MiniDFA27 {1}
AcceptToken 'char'"/]
class MiniDFA27_-1358571324 c0101;
MiniDFA28_1846829681[\"MiniDFA28 {1}
AcceptToken 'char'"/]
class MiniDFA28_1846829681 c0101;
MiniDFA11_157963389(["MiniDFA11 {1}"])
MiniDFA29_882298322[\"MiniDFA29 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA29_882298322 c0101;
MiniDFA30_-631267067[\"MiniDFA30 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA30_-631267067 c0101;
MiniDFA31_1944258923[\"MiniDFA31 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA31_1944258923 c0101;
MiniDFA32_-1267335330[\"MiniDFA32 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA32_-1267335330 c0101;
MiniDFA33_1084664971[\"MiniDFA33 {1}
AcceptToken '[^'"/]
class MiniDFA33_1084664971 c1101;
MiniDFA5_-1501076448(["MiniDFA5 {1}"])
MiniDFA3_260574151(["MiniDFA3 {1}"])
MiniDFA34_-202900956[\"MiniDFA34 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA34_-202900956 c0101;
MiniDFA35_-1716582198[\"MiniDFA35 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA35_-1716582198 c0101;
MiniDFA36_1637916823[\"MiniDFA36 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA36_1637916823 c0101;
MiniDFA37_1076040990[\"MiniDFA37 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA37_1076040990 c0101;
MiniDFA38_971114975[\"MiniDFA38 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA38_971114975 c0101;
MiniDFA39_1928364039[\"MiniDFA39 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA39_1928364039 c0101;
MiniDFA12_882784311(["MiniDFA12 {1}"])
MiniDFA40_983298140[\"MiniDFA40 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA40_983298140 c0101;
MiniDFA41_-148878662[\"MiniDFA41 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA41_-148878662 c0101;
MiniDFA42_1774635322[\"MiniDFA42 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA42_1774635322 c0101;
MiniDFA43_-888236193[\"MiniDFA43 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA43_-888236193 c0101;
MiniDFA44_1153357833[\"MiniDFA44 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA44_1153357833 c0101;
MiniDFA8_1052350996(["MiniDFA8 {1}"])
MiniDFA6_-745590573(["MiniDFA6 {1}"])
MiniDFA4_-936000833(["MiniDFA4 {1}"])
MiniDFA45_1814777571[\"MiniDFA45 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA45_1814777571 c0101;
MiniDFA46_-326717903[\"MiniDFA46 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA46_-326717903 c0101;
MiniDFA47_2112305326[\"MiniDFA47 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA47_2112305326 c0101;
MiniDFA48_-1089194710[\"MiniDFA48 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA48_-1089194710 c0101;
MiniDFA49_-1659177635[\"MiniDFA49 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA49_-1659177635 c0101;
MiniDFA50_234026938[\"MiniDFA50 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA50_234026938 c0101;
MiniDFA13_-805951098(["MiniDFA13 {1}"])
MiniDFA9_1129701067(["MiniDFA9 {1}"])
MiniDFA7_1669435006(["MiniDFA7 {1}"])
MiniDFA51_1316239270[\"MiniDFA51 {1}
AcceptToken 'char'"/]
class MiniDFA51_1316239270 c0101;
MiniDFA14_945990719(["MiniDFA14 {1}"])
MiniDFA10_-876014922(["MiniDFA10 {1}"])
MiniDFA52_-248145067[\"MiniDFA52 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA52_-248145067 c0101;
MiniDFA15_-153120073(["MiniDFA15 {1}"])
MiniDFA53_-2043493099[\"MiniDFA53 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA53_-2043493099 c0101;
MiniDFA0_-1598698416 -->|"#92;
BeginToken 'char'"|MiniDFA1_1709522984
MiniDFA0_-1598698416 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA16_829239316
MiniDFA0_-1598698416 -->|"^
BeginToken 'char'
ExtendToken 'char'"|MiniDFA17_-1540748001
MiniDFA0_-1598698416 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA18_-829650891
MiniDFA0_-1598698416 -->|"[
BeginToken '[''[^'
ExtendToken '['"|MiniDFA19_1895575115
MiniDFA0_-1598698416 -->|"]
BeginToken ']'
ExtendToken ']'"|MiniDFA20_1347270970
MiniDFA1_1709522984 -->|"u"|MiniDFA2_-1485731032
MiniDFA1_1709522984 -->|"t
ExtendToken 'char'"|MiniDFA21_718644212
MiniDFA1_1709522984 -->|"n
ExtendToken 'char'"|MiniDFA22_-300477139
MiniDFA1_1709522984 -->|"r
ExtendToken 'char'"|MiniDFA23_-1898055659
MiniDFA1_1709522984 -->|"-
ExtendToken 'char'"|MiniDFA24_-740909074
MiniDFA1_1709522984 -->|"[
ExtendToken 'char'"|MiniDFA25_1913534607
MiniDFA1_1709522984 -->|"#92;
ExtendToken 'char'"|MiniDFA26_811121392
MiniDFA1_1709522984 -->|"]
ExtendToken 'char'"|MiniDFA27_-1358571324
MiniDFA1_1709522984 -->|"^
ExtendToken 'char'"|MiniDFA28_1846829681
MiniDFA19_1895575115 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|MiniDFA11_157963389
MiniDFA19_1895575115 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA29_882298322
MiniDFA19_1895575115 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA30_-631267067
MiniDFA19_1895575115 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA31_1944258923
MiniDFA19_1895575115 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA32_-1267335330
MiniDFA19_1895575115 -->|"^
ExtendToken '[^'"|MiniDFA33_1084664971
MiniDFA2_-1485731032 -->|"[0-9]"|MiniDFA5_-1501076448
MiniDFA11_157963389 -->|"u"|MiniDFA3_260574151
MiniDFA11_157963389 -->|"t
ExtendToken 'firstItem1'"|MiniDFA34_-202900956
MiniDFA11_157963389 -->|"n
ExtendToken 'firstItem1'"|MiniDFA35_-1716582198
MiniDFA11_157963389 -->|"r
ExtendToken 'firstItem1'"|MiniDFA36_1637916823
MiniDFA11_157963389 -->|"-
ExtendToken 'firstItem1'"|MiniDFA37_1076040990
MiniDFA11_157963389 -->|"#92;
ExtendToken 'firstItem1'"|MiniDFA38_971114975
MiniDFA11_157963389 -->|"^
ExtendToken 'firstItem1'"|MiniDFA39_1928364039
MiniDFA33_1084664971 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|MiniDFA12_882784311
MiniDFA33_1084664971 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA40_983298140
MiniDFA33_1084664971 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA41_-148878662
MiniDFA33_1084664971 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA42_1774635322
MiniDFA33_1084664971 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA43_-888236193
MiniDFA33_1084664971 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA44_1153357833
MiniDFA5_-1501076448 -->|"[0-9]"|MiniDFA8_1052350996
MiniDFA3_260574151 -->|"[0-9]"|MiniDFA6_-745590573
MiniDFA12_882784311 -->|"u"|MiniDFA4_-936000833
MiniDFA12_882784311 -->|"t
ExtendToken 'firstItem2'"|MiniDFA45_1814777571
MiniDFA12_882784311 -->|"n
ExtendToken 'firstItem2'"|MiniDFA46_-326717903
MiniDFA12_882784311 -->|"r
ExtendToken 'firstItem2'"|MiniDFA47_2112305326
MiniDFA12_882784311 -->|"-
ExtendToken 'firstItem2'"|MiniDFA48_-1089194710
MiniDFA12_882784311 -->|"#92;
ExtendToken 'firstItem2'"|MiniDFA49_-1659177635
MiniDFA12_882784311 -->|"^
ExtendToken 'firstItem2'"|MiniDFA50_234026938
MiniDFA8_1052350996 -->|"[0-9]"|MiniDFA13_-805951098
MiniDFA6_-745590573 -->|"[0-9]"|MiniDFA9_1129701067
MiniDFA4_-936000833 -->|"[0-9]"|MiniDFA7_1669435006
MiniDFA13_-805951098 -->|"[0-9]
ExtendToken 'char'"|MiniDFA51_1316239270
MiniDFA9_1129701067 -->|"[0-9]"|MiniDFA14_945990719
MiniDFA7_1669435006 -->|"[0-9]"|MiniDFA10_-876014922
MiniDFA14_945990719 -->|"[0-9]
ExtendToken 'firstItem1'"|MiniDFA52_-248145067
MiniDFA10_-876014922 -->|"[0-9]"|MiniDFA15_-153120073
MiniDFA15_-153120073 -->|"[0-9]
ExtendToken 'firstItem2'"|MiniDFA53_-2043493099

```

# 总结

无。

