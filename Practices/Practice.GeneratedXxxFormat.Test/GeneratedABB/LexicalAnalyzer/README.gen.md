# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `ABB`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（12个State）。

## '+'
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
eNFA0_2_25773083[["εNFA0-2 regex start"]]
eNFA0_0_30631159[["εNFA0-0 char{1, 1}"]]
eNFA0_1_7244975[["εNFA0-1 char[1]"]]
eNFA0_3_65204782[["εNFA0-3 regex end"]]
eNFA0_2_25773083 -.->|"ε"|eNFA0_0_30631159
eNFA0_0_30631159 -->|"+"|eNFA0_1_7244975
eNFA0_1_7244975 -.->|"ε"|eNFA0_3_65204782
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
eNFA0_4_49972132[["εNFA0-4 post-regex start"]]
eNFA0_5_47096010[\"εNFA0-5 post-regex end"/]
eNFA0_4_49972132 -.->|"ε"|eNFA0_5_47096010
```


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
eNFA0_2_40256670[["εNFA0-2 regex start"]]
eNFA0_0_26765710[["εNFA0-0 char{1, 1}"]]
eNFA0_1_39564799[["εNFA0-1 char[1]"]]
eNFA0_3_20538874[["εNFA0-3 regex end"]]
eNFA0_2_40256670 -.->|"ε"|eNFA0_0_26765710
eNFA0_0_26765710 -->|"a"|eNFA0_1_39564799
eNFA0_1_39564799 -.->|"ε"|eNFA0_3_20538874
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
eNFA0_4_50632145[["εNFA0-4 post-regex start"]]
eNFA0_5_53036123[\"εNFA0-5 post-regex end"/]
eNFA0_4_50632145 -.->|"ε"|eNFA0_5_53036123
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
eNFA0_2_3741682[["εNFA0-2 regex start"]]
eNFA0_0_33675143[["εNFA0-0 char{1, 1}"]]
eNFA0_1_34640832[["εNFA0-1 char[1]"]]
eNFA0_3_43332040[["εNFA0-3 regex end"]]
eNFA0_2_3741682 -.->|"ε"|eNFA0_0_33675143
eNFA0_0_33675143 -->|"b"|eNFA0_1_34640832
eNFA0_1_34640832 -.->|"ε"|eNFA0_3_43332040
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
eNFA0_4_54444047[["εNFA0-4 post-regex start"]]
eNFA0_5_20234383[\"εNFA0-5 post-regex end"/]
eNFA0_4_54444047 -.->|"ε"|eNFA0_5_20234383
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
eNFA0_16_37251161[["εNFA0-16 regex start"]]
eNFA0_0_66824994[["εNFA0-0 char{1, 1}"]]
eNFA0_1_64554036[["εNFA0-1 char[1]"]]
eNFA0_2_44115416[["εNFA0-2 char{1, 1}"]]
eNFA0_3_56200037[["εNFA0-3 char[1]"]]
eNFA0_6_63208015[["εNFA0-6 regex start"]]
eNFA0_4_19575591[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_32001227[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_42119052[["εNFA0-7 regex end"]]
eNFA0_5_43527150[["εNFA0-5 scope[1]"]]
eNFA0_9_6480969[["εNFA0-9 scope[1]"]]
eNFA0_12_36038289[["εNFA0-12 char{1, 1}"]]
eNFA0_10_41731733[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_40041277[["εNFA0-13 char[1]"]]
eNFA0_11_41962596[["εNFA0-11 scope[1]"]]
eNFA0_14_24827179[["εNFA0-14 char{1, 1}"]]
eNFA0_15_64844482[["εNFA0-15 char[1]"]]
eNFA0_17_46729429[["εNFA0-17 regex end"]]
eNFA0_16_37251161 -.->|"ε"|eNFA0_0_66824994
eNFA0_0_66824994 -->|"/"|eNFA0_1_64554036
eNFA0_1_64554036 -.->|"ε"|eNFA0_2_44115416
eNFA0_2_44115416 -->|"*"|eNFA0_3_56200037
eNFA0_3_56200037 -.->|"ε"|eNFA0_6_63208015
eNFA0_6_63208015 -.->|"ε"|eNFA0_4_19575591
eNFA0_6_63208015 -.->|"ε"|eNFA0_8_32001227
eNFA0_6_63208015 -.->|"ε"|eNFA0_7_42119052
eNFA0_4_19575591 -->|"[^*]"|eNFA0_5_43527150
eNFA0_8_32001227 -->|"[*]"|eNFA0_9_6480969
eNFA0_7_42119052 -.->|"ε"|eNFA0_6_63208015
eNFA0_7_42119052 -.->|"ε"|eNFA0_12_36038289
eNFA0_5_43527150 -.->|"ε"|eNFA0_7_42119052
eNFA0_9_6480969 -.->|"ε"|eNFA0_10_41731733
eNFA0_12_36038289 -->|"*"|eNFA0_13_40041277
eNFA0_10_41731733 -->|"[^/]"|eNFA0_11_41962596
eNFA0_13_40041277 -.->|"ε"|eNFA0_14_24827179
eNFA0_11_41962596 -.->|"ε"|eNFA0_7_42119052
eNFA0_14_24827179 -->|"/"|eNFA0_15_64844482
eNFA0_15_64844482 -.->|"ε"|eNFA0_17_46729429
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
eNFA0_18_17911681[["εNFA0-18 post-regex start"]]
eNFA0_19_26987408[\"εNFA0-19 post-regex end"/]
eNFA0_18_17911681 -.->|"ε"|eNFA0_19_26987408
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
eNFA0_5_9381496[["εNFA0-5 regex start"]]
eNFA0_0_17324607[["εNFA0-0 char{1, 1}"]]
eNFA0_1_21703739[["εNFA0-1 char[1]"]]
eNFA0_2_61115925[["εNFA0-2 char{1, 1}"]]
eNFA0_3_33420276[["εNFA0-3 char[1]"]]
eNFA0_4_32347029[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_22687807[["εNFA0-6 regex end"]]
eNFA0_5_9381496 -.->|"ε"|eNFA0_0_17324607
eNFA0_0_17324607 -->|"/"|eNFA0_1_21703739
eNFA0_1_21703739 -.->|"ε"|eNFA0_2_61115925
eNFA0_2_61115925 -->|"/"|eNFA0_3_33420276
eNFA0_3_33420276 -.->|"ε"|eNFA0_4_32347029
eNFA0_4_32347029 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_32347029
eNFA0_4_32347029 -.->|"ε"|eNFA0_6_22687807
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
eNFA0_7_6122357[["εNFA0-7 post-regex start"]]
eNFA0_8_55101221[\"εNFA0-8 post-regex end"/]
eNFA0_7_6122357 -.->|"ε"|eNFA0_8_55101221
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
eNFA0_0_62074597[["εNFA0-0 wholeStart"]]
eNFA1_2_51198184[["εNFA1-2 regex start"]]
class eNFA1_2_51198184 c1000;
eNFA2_2_21800467[["εNFA2-2 regex start"]]
class eNFA2_2_21800467 c1000;
eNFA3_2_26534308[["εNFA3-2 regex start"]]
class eNFA3_2_26534308 c1000;
eNFA4_16_54078809[["εNFA4-16 regex start"]]
class eNFA4_16_54078809 c1000;
eNFA5_5_12102828[["εNFA5-5 regex start"]]
class eNFA5_5_12102828 c1000;
eNFA1_0_58130472[["εNFA1-0 char{1, 1}"]]
eNFA2_0_54848996[["εNFA2-0 char{1, 1}"]]
eNFA3_0_1795329[["εNFA3-0 char{1, 1}"]]
eNFA4_0_18307385[["εNFA4-0 char{1, 1}"]]
eNFA5_0_40805010[["εNFA5-0 char{1, 1}"]]
eNFA1_1_53412201[["εNFA1-1 char[1]"]]
eNFA2_1_23878916[["εNFA2-1 char[1]"]]
eNFA3_1_16157963[["εNFA3-1 char[1]"]]
eNFA4_1_51595365[["εNFA4-1 char[1]"]]
eNFA5_1_61705107[["εNFA5-1 char[1]"]]
eNFA1_3_10947764[["εNFA1-3 regex end"]]
class eNFA1_3_10947764 c0100;
eNFA2_3_13583655[["εNFA2-3 regex end"]]
class eNFA2_3_13583655 c0100;
eNFA3_3_11203942[["εNFA3-3 regex end"]]
class eNFA3_3_11203942 c0100;
eNFA4_2_18475057[["εNFA4-2 char{1, 1}"]]
eNFA5_2_32057793[["εNFA5-2 char{1, 1}"]]
eNFA1_4_31421019[["εNFA1-4 post-regex start"]]
class eNFA1_4_31421019 c0010;
eNFA2_4_55144039[["εNFA2-4 post-regex start"]]
class eNFA2_4_55144039 c0010;
eNFA3_4_33726620[["εNFA3-4 post-regex start"]]
class eNFA3_4_33726620 c0010;
eNFA4_3_540121[["εNFA4-3 char[1]"]]
eNFA5_3_43231651[["εNFA5-3 char[1]"]]
eNFA1_5_14353717[\"εNFA1-5 post-regex end"/]
class eNFA1_5_14353717 c0001;
eNFA2_5_61986480[\"εNFA2-5 post-regex end"/]
class eNFA2_5_61986480 c0001;
eNFA3_5_37482183[\"εNFA3-5 post-regex end"/]
class eNFA3_5_37482183 c0001;
eNFA4_6_35104124[["εNFA4-6 regex start"]]
eNFA5_4_56999299[["εNFA5-4 char{0, ∞}"]]
eNFA0_1_21007413[\"εNFA0-1 wholeEnd"/]
eNFA4_4_24861802[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_47501665[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_22429634[["εNFA4-7 regex end"]]
eNFA5_6_53540541[["εNFA5-6 regex end"]]
class eNFA5_6_53540541 c0100;
eNFA4_5_43749873[["εNFA4-5 scope[1]"]]
eNFA4_9_21653700[["εNFA4-9 scope[1]"]]
eNFA4_12_4861097[["εNFA4-12 char{1, 1}"]]
eNFA5_7_31700771[["εNFA5-7 post-regex start"]]
class eNFA5_7_31700771 c0010;
eNFA4_10_461342[["εNFA4-10 scope{1, 1}"]]
eNFA4_13_4152081[["εNFA4-13 char[1]"]]
eNFA5_8_41816592[\"εNFA5-8 post-regex end"/]
class eNFA5_8_41816592 c0001;
eNFA4_11_58204539[["εNFA4-11 scope[1]"]]
eNFA4_14_37368736[["εNFA4-14 char{1, 1}"]]
eNFA4_15_30548742[["εNFA4-15 char[1]"]]
eNFA4_17_6503226[["εNFA4-17 regex end"]]
class eNFA4_17_6503226 c0100;
eNFA4_18_58529038[["εNFA4-18 post-regex start"]]
class eNFA4_18_58529038 c0010;
eNFA4_19_16947234[\"εNFA4-19 post-regex end"/]
class eNFA4_19_16947234 c0001;
eNFA0_0_62074597 -.->|"ε"|eNFA1_2_51198184
eNFA0_0_62074597 -.->|"ε"|eNFA2_2_21800467
eNFA0_0_62074597 -.->|"ε"|eNFA3_2_26534308
eNFA0_0_62074597 -.->|"ε"|eNFA4_16_54078809
eNFA0_0_62074597 -.->|"ε"|eNFA5_5_12102828
eNFA1_2_51198184 -.->|"ε
BeginToken '+'"|eNFA1_0_58130472
eNFA2_2_21800467 -.->|"ε
BeginToken 'a'"|eNFA2_0_54848996
eNFA3_2_26534308 -.->|"ε
BeginToken 'b'"|eNFA3_0_1795329
eNFA4_16_54078809 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_18307385
eNFA5_5_12102828 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_40805010
eNFA1_0_58130472 -->|"+"|eNFA1_1_53412201
eNFA2_0_54848996 -->|"a"|eNFA2_1_23878916
eNFA3_0_1795329 -->|"b"|eNFA3_1_16157963
eNFA4_0_18307385 -->|"/"|eNFA4_1_51595365
eNFA5_0_40805010 -->|"/"|eNFA5_1_61705107
eNFA1_1_53412201 -.->|"ε
ExtendToken '+'"|eNFA1_3_10947764
eNFA2_1_23878916 -.->|"ε
ExtendToken 'a'"|eNFA2_3_13583655
eNFA3_1_16157963 -.->|"ε
ExtendToken 'b'"|eNFA3_3_11203942
eNFA4_1_51595365 -.->|"ε"|eNFA4_2_18475057
eNFA5_1_61705107 -.->|"ε"|eNFA5_2_32057793
eNFA1_3_10947764 -.->|"ε"|eNFA1_4_31421019
eNFA2_3_13583655 -.->|"ε"|eNFA2_4_55144039
eNFA3_3_11203942 -.->|"ε"|eNFA3_4_33726620
eNFA4_2_18475057 -->|"*"|eNFA4_3_540121
eNFA5_2_32057793 -->|"/"|eNFA5_3_43231651
eNFA1_4_31421019 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_14353717
eNFA2_4_55144039 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_61986480
eNFA3_4_33726620 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_37482183
eNFA4_3_540121 -.->|"ε"|eNFA4_6_35104124
eNFA5_3_43231651 -.->|"ε"|eNFA5_4_56999299
eNFA1_5_14353717 -.->|"ε"|eNFA0_1_21007413
eNFA2_5_61986480 -.->|"ε"|eNFA0_1_21007413
eNFA3_5_37482183 -.->|"ε"|eNFA0_1_21007413
eNFA4_6_35104124 -.->|"ε"|eNFA4_4_24861802
eNFA4_6_35104124 -.->|"ε"|eNFA4_8_47501665
eNFA4_6_35104124 -.->|"ε"|eNFA4_7_22429634
eNFA5_4_56999299 -->|"[#92;t#92;r#32;-~]"|eNFA5_4_56999299
eNFA5_4_56999299 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_53540541
eNFA4_4_24861802 -->|"[^*]"|eNFA4_5_43749873
eNFA4_8_47501665 -->|"[*]"|eNFA4_9_21653700
eNFA4_7_22429634 -.->|"ε"|eNFA4_6_35104124
eNFA4_7_22429634 -.->|"ε"|eNFA4_12_4861097
eNFA5_6_53540541 -.->|"ε"|eNFA5_7_31700771
eNFA4_5_43749873 -.->|"ε"|eNFA4_7_22429634
eNFA4_9_21653700 -.->|"ε"|eNFA4_10_461342
eNFA4_12_4861097 -->|"*"|eNFA4_13_4152081
eNFA5_7_31700771 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_41816592
eNFA4_10_461342 -->|"[^/]"|eNFA4_11_58204539
eNFA4_13_4152081 -.->|"ε"|eNFA4_14_37368736
eNFA5_8_41816592 -.->|"ε"|eNFA0_1_21007413
eNFA4_11_58204539 -.->|"ε"|eNFA4_7_22429634
eNFA4_14_37368736 -->|"/"|eNFA4_15_30548742
eNFA4_15_30548742 -.->|"ε
ExtendToken 'blockComment'"|eNFA4_17_6503226
eNFA4_17_6503226 -.->|"ε"|eNFA4_18_58529038
eNFA4_18_58529038 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_16947234
eNFA4_19_16947234 -.->|"ε"|eNFA0_1_21007413

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
eNFA0_0_16871484[["εNFA0-0 wholeStart"]]
class eNFA0_0_16871484 c1000;
eNFA1_2_24412946[["εNFA1-2 regex start"]]
class eNFA1_2_24412946 c1000;
eNFA2_2_17625630[["εNFA2-2 regex start"]]
class eNFA2_2_17625630 c1000;
eNFA3_2_18389930[["εNFA3-2 regex start"]]
class eNFA3_2_18389930 c1000;
eNFA4_16_31291646[["εNFA4-16 regex start"]]
class eNFA4_16_31291646 c1000;
eNFA5_5_13189358[["εNFA5-5 regex start"]]
class eNFA5_5_13189358 c1000;
eNFA1_0_27598869[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_27598869 c1000;
eNFA2_0_16468652[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_16468652 c1000;
eNFA3_0_5560998[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_5560998 c1000;
eNFA4_0_45596481[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_45596481 c1000;
eNFA5_0_54308798[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_54308798 c1000;
eNFA1_1_47063234[\"εNFA1-1 char[1]
AcceptToken '+'"/]
class eNFA1_1_47063234 c0111;
eNFA2_1_14000148[\"εNFA2-1 char[1]
AcceptToken 'a'"/]
class eNFA2_1_14000148 c0111;
eNFA3_1_50048984[\"εNFA3-1 char[1]
AcceptToken 'b'"/]
class eNFA3_1_50048984 c0111;
eNFA4_1_36936550[["εNFA4-1 char[1]"]]
eNFA5_1_39070558[["εNFA5-1 char[1]"]]
eNFA1_3_20915929[\"εNFA1-3 regex end
AcceptToken '+'"/]
class eNFA1_3_20915929 c0111;
eNFA1_4_54025633[\"εNFA1-4 post-regex start
AcceptToken '+'"/]
class eNFA1_4_54025633 c0011;
eNFA1_5_16246551[\"εNFA1-5 post-regex end"/]
class eNFA1_5_16246551 c0011;
eNFA0_1_46544415[\"εNFA0-1 wholeEnd"/]
eNFA2_3_58892473[\"εNFA2-3 regex end
AcceptToken 'a'"/]
class eNFA2_3_58892473 c0111;
eNFA2_4_60270212[\"εNFA2-4 post-regex start
AcceptToken 'a'"/]
class eNFA2_4_60270212 c0011;
eNFA2_5_20084682[\"εNFA2-5 post-regex end"/]
class eNFA2_5_20084682 c0011;
eNFA3_3_47787675[\"εNFA3-3 regex end
AcceptToken 'b'"/]
class eNFA3_3_47787675 c0111;
eNFA3_4_27435897[\"εNFA3-4 post-regex start
AcceptToken 'b'"/]
class eNFA3_4_27435897 c0011;
eNFA3_5_12001237[\"εNFA3-5 post-regex end"/]
class eNFA3_5_12001237 c0011;
eNFA4_2_10598606[["εNFA4-2 char{1, 1}"]]
eNFA4_3_60665573[["εNFA4-3 char[1]"]]
eNFA5_2_16090703[["εNFA5-2 char{1, 1}"]]
eNFA5_3_57434139[\"εNFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA5_3_57434139 c0111;
eNFA4_6_40902273[["εNFA4-6 regex start"]]
eNFA4_4_24749807[["εNFA4-4 scope{1, 1}"]]
eNFA4_8_32576140[["εNFA4-8 scope{1, 1}"]]
eNFA4_7_21421675[["εNFA4-7 regex end"]]
eNFA4_5_14964341[["εNFA4-5 scope[1]"]]
eNFA4_9_28278595[["εNFA4-9 scope[1]"]]
eNFA4_12_9119245[["εNFA4-12 char{1, 1}"]]
eNFA4_13_8864859[["εNFA4-13 char[1]"]]
eNFA5_4_58577354[\"εNFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA5_4_58577354 c0111;
eNFA5_6_47145209[\"εNFA5-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA5_6_47145209 c0111;
eNFA5_7_19017142[\"εNFA5-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA5_7_19017142 c0011;
eNFA5_8_774306[\"εNFA5-8 post-regex end"/]
class eNFA5_8_774306 c0011;
eNFA4_10_53180767[["εNFA4-10 scope{1, 1}"]]
eNFA4_11_6968762[["εNFA4-11 scope[1]"]]
eNFA4_14_63993496[["εNFA4-14 char{1, 1}"]]
eNFA4_15_7715150[\"εNFA4-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA4_15_7715150 c0111;
eNFA4_17_2327487[\"εNFA4-17 regex end
AcceptToken 'blockComment'"/]
class eNFA4_17_2327487 c0111;
eNFA4_18_20947391[\"εNFA4-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA4_18_20947391 c0011;
eNFA4_19_62718864[\"εNFA4-19 post-regex end"/]
class eNFA4_19_62718864 c0011;
eNFA0_0_16871484 -.->|"ε"|eNFA1_2_24412946
eNFA0_0_16871484 -.->|"ε"|eNFA2_2_17625630
eNFA0_0_16871484 -.->|"ε"|eNFA3_2_18389930
eNFA0_0_16871484 -.->|"ε"|eNFA4_16_31291646
eNFA0_0_16871484 -.->|"ε"|eNFA5_5_13189358
eNFA0_0_16871484 -.->|"ε
BeginToken '+'"|eNFA1_0_27598869
eNFA0_0_16871484 -.->|"ε
BeginToken 'a'"|eNFA2_0_16468652
eNFA0_0_16871484 -.->|"ε
BeginToken 'b'"|eNFA3_0_5560998
eNFA0_0_16871484 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_45596481
eNFA0_0_16871484 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_54308798
eNFA0_0_16871484 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_47063234
eNFA0_0_16871484 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_14000148
eNFA0_0_16871484 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_50048984
eNFA0_0_16871484 -->|"/
BeginToken 'blockComment'"|eNFA4_1_36936550
eNFA0_0_16871484 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_39070558
eNFA1_2_24412946 -.->|"ε
BeginToken '+'"|eNFA1_0_27598869
eNFA1_2_24412946 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_47063234
eNFA2_2_17625630 -.->|"ε
BeginToken 'a'"|eNFA2_0_16468652
eNFA2_2_17625630 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_14000148
eNFA3_2_18389930 -.->|"ε
BeginToken 'b'"|eNFA3_0_5560998
eNFA3_2_18389930 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_50048984
eNFA4_16_31291646 -.->|"ε
BeginToken 'blockComment'"|eNFA4_0_45596481
eNFA4_16_31291646 -->|"/
BeginToken 'blockComment'"|eNFA4_1_36936550
eNFA5_5_13189358 -.->|"ε
BeginToken 'inlineComment'"|eNFA5_0_54308798
eNFA5_5_13189358 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_39070558
eNFA1_0_27598869 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA1_1_47063234
eNFA2_0_16468652 -->|"a
BeginToken 'a'
ExtendToken 'a'"|eNFA2_1_14000148
eNFA3_0_5560998 -->|"b
BeginToken 'b'
ExtendToken 'b'"|eNFA3_1_50048984
eNFA4_0_45596481 -->|"/
BeginToken 'blockComment'"|eNFA4_1_36936550
eNFA5_0_54308798 -->|"/
BeginToken 'inlineComment'"|eNFA5_1_39070558
eNFA1_1_47063234 -.->|"ε
ExtendToken '+'"|eNFA1_3_20915929
eNFA1_1_47063234 -.->|"ε"|eNFA1_4_54025633
eNFA1_1_47063234 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_16246551
eNFA1_1_47063234 -.->|"ε
CheckToken '+'"|eNFA0_1_46544415
eNFA2_1_14000148 -.->|"ε
ExtendToken 'a'"|eNFA2_3_58892473
eNFA2_1_14000148 -.->|"ε"|eNFA2_4_60270212
eNFA2_1_14000148 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_20084682
eNFA2_1_14000148 -.->|"ε
CheckToken 'a'"|eNFA0_1_46544415
eNFA3_1_50048984 -.->|"ε
ExtendToken 'b'"|eNFA3_3_47787675
eNFA3_1_50048984 -.->|"ε"|eNFA3_4_27435897
eNFA3_1_50048984 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_12001237
eNFA3_1_50048984 -.->|"ε
CheckToken 'b'"|eNFA0_1_46544415
eNFA4_1_36936550 -.->|"ε"|eNFA4_2_10598606
eNFA4_1_36936550 -->|"*"|eNFA4_3_60665573
eNFA5_1_39070558 -.->|"ε"|eNFA5_2_16090703
eNFA5_1_39070558 -->|"/
ExtendToken 'inlineComment'"|eNFA5_3_57434139
eNFA1_3_20915929 -.->|"ε"|eNFA1_4_54025633
eNFA1_3_20915929 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_16246551
eNFA1_3_20915929 -.->|"ε
CheckToken '+'"|eNFA0_1_46544415
eNFA1_4_54025633 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA1_5_16246551
eNFA1_4_54025633 -.->|"ε
CheckToken '+'"|eNFA0_1_46544415
eNFA1_5_16246551 -.->|"ε
CheckToken '+'"|eNFA0_1_46544415
eNFA2_3_58892473 -.->|"ε"|eNFA2_4_60270212
eNFA2_3_58892473 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_20084682
eNFA2_3_58892473 -.->|"ε
CheckToken 'a'"|eNFA0_1_46544415
eNFA2_4_60270212 -.->|"ε
CheckToken 'a'
AcceptToken 'a'"|eNFA2_5_20084682
eNFA2_4_60270212 -.->|"ε
CheckToken 'a'"|eNFA0_1_46544415
eNFA2_5_20084682 -.->|"ε
CheckToken 'a'"|eNFA0_1_46544415
eNFA3_3_47787675 -.->|"ε"|eNFA3_4_27435897
eNFA3_3_47787675 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_12001237
eNFA3_3_47787675 -.->|"ε
CheckToken 'b'"|eNFA0_1_46544415
eNFA3_4_27435897 -.->|"ε
CheckToken 'b'
AcceptToken 'b'"|eNFA3_5_12001237
eNFA3_4_27435897 -.->|"ε
CheckToken 'b'"|eNFA0_1_46544415
eNFA3_5_12001237 -.->|"ε
CheckToken 'b'"|eNFA0_1_46544415
eNFA4_2_10598606 -->|"*"|eNFA4_3_60665573
eNFA4_3_60665573 -.->|"ε"|eNFA4_6_40902273
eNFA4_3_60665573 -.->|"ε"|eNFA4_4_24749807
eNFA4_3_60665573 -.->|"ε"|eNFA4_8_32576140
eNFA4_3_60665573 -.->|"ε"|eNFA4_7_21421675
eNFA4_3_60665573 -->|"[^*]"|eNFA4_5_14964341
eNFA4_3_60665573 -->|"[*]"|eNFA4_9_28278595
eNFA4_3_60665573 -.->|"ε"|eNFA4_12_9119245
eNFA4_3_60665573 -->|"*"|eNFA4_13_8864859
eNFA5_2_16090703 -->|"/
ExtendToken 'inlineComment'"|eNFA5_3_57434139
eNFA5_3_57434139 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_4_58577354
eNFA5_3_57434139 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA5_4_58577354
eNFA5_3_57434139 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_47145209
eNFA5_3_57434139 -.->|"ε"|eNFA5_7_19017142
eNFA5_3_57434139 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_774306
eNFA5_3_57434139 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_46544415
eNFA4_6_40902273 -.->|"ε"|eNFA4_4_24749807
eNFA4_6_40902273 -.->|"ε"|eNFA4_8_32576140
eNFA4_6_40902273 -.->|"ε"|eNFA4_7_21421675
eNFA4_6_40902273 -->|"[^*]"|eNFA4_5_14964341
eNFA4_6_40902273 -->|"[*]"|eNFA4_9_28278595
eNFA4_6_40902273 -.->|"ε"|eNFA4_6_40902273
eNFA4_6_40902273 -.->|"ε"|eNFA4_12_9119245
eNFA4_6_40902273 -->|"*"|eNFA4_13_8864859
eNFA4_4_24749807 -->|"[^*]"|eNFA4_5_14964341
eNFA4_8_32576140 -->|"[*]"|eNFA4_9_28278595
eNFA4_7_21421675 -.->|"ε"|eNFA4_6_40902273
eNFA4_7_21421675 -.->|"ε"|eNFA4_12_9119245
eNFA4_7_21421675 -.->|"ε"|eNFA4_4_24749807
eNFA4_7_21421675 -.->|"ε"|eNFA4_8_32576140
eNFA4_7_21421675 -.->|"ε"|eNFA4_7_21421675
eNFA4_7_21421675 -->|"[^*]"|eNFA4_5_14964341
eNFA4_7_21421675 -->|"[*]"|eNFA4_9_28278595
eNFA4_7_21421675 -->|"*"|eNFA4_13_8864859
eNFA4_5_14964341 -.->|"ε"|eNFA4_7_21421675
eNFA4_5_14964341 -.->|"ε"|eNFA4_6_40902273
eNFA4_5_14964341 -.->|"ε"|eNFA4_12_9119245
eNFA4_5_14964341 -.->|"ε"|eNFA4_4_24749807
eNFA4_5_14964341 -.->|"ε"|eNFA4_8_32576140
eNFA4_5_14964341 -->|"[^*]"|eNFA4_5_14964341
eNFA4_5_14964341 -->|"[*]"|eNFA4_9_28278595
eNFA4_5_14964341 -->|"*"|eNFA4_13_8864859
eNFA4_9_28278595 -.->|"ε"|eNFA4_10_53180767
eNFA4_9_28278595 -->|"[^/]"|eNFA4_11_6968762
eNFA4_12_9119245 -->|"*"|eNFA4_13_8864859
eNFA4_13_8864859 -.->|"ε"|eNFA4_14_63993496
eNFA4_13_8864859 -->|"/
ExtendToken 'blockComment'"|eNFA4_15_7715150
eNFA5_4_58577354 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA5_4_58577354
eNFA5_4_58577354 -.->|"ε
ExtendToken 'inlineComment'"|eNFA5_6_47145209
eNFA5_4_58577354 -.->|"ε"|eNFA5_7_19017142
eNFA5_4_58577354 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_774306
eNFA5_4_58577354 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_46544415
eNFA5_6_47145209 -.->|"ε"|eNFA5_7_19017142
eNFA5_6_47145209 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_774306
eNFA5_6_47145209 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_46544415
eNFA5_7_19017142 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA5_8_774306
eNFA5_7_19017142 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_46544415
eNFA5_8_774306 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_46544415
eNFA4_10_53180767 -->|"[^/]"|eNFA4_11_6968762
eNFA4_11_6968762 -.->|"ε"|eNFA4_7_21421675
eNFA4_11_6968762 -.->|"ε"|eNFA4_6_40902273
eNFA4_11_6968762 -.->|"ε"|eNFA4_12_9119245
eNFA4_11_6968762 -.->|"ε"|eNFA4_4_24749807
eNFA4_11_6968762 -.->|"ε"|eNFA4_8_32576140
eNFA4_11_6968762 -->|"[^*]"|eNFA4_5_14964341
eNFA4_11_6968762 -->|"[*]"|eNFA4_9_28278595
eNFA4_11_6968762 -->|"*"|eNFA4_13_8864859
eNFA4_14_63993496 -->|"/
ExtendToken 'blockComment'"|eNFA4_15_7715150
eNFA4_15_7715150 -.->|"ε
ExtendToken 'blockComment'"|eNFA4_17_2327487
eNFA4_15_7715150 -.->|"ε"|eNFA4_18_20947391
eNFA4_15_7715150 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_62718864
eNFA4_15_7715150 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_46544415
eNFA4_17_2327487 -.->|"ε"|eNFA4_18_20947391
eNFA4_17_2327487 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_62718864
eNFA4_17_2327487 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_46544415
eNFA4_18_20947391 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA4_19_62718864
eNFA4_18_20947391 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_46544415
eNFA4_19_62718864 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_46544415

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
NFA0_0_46964992("NFA0-0 wholeStart")
class NFA0_0_46964992 c1000;
NFA1_1_12674872[\"NFA1-1 char[1]
AcceptToken '+'"/]
class NFA1_1_12674872 c0101;
NFA2_1_20031746[\"NFA2-1 char[1]
AcceptToken 'a'"/]
class NFA2_1_20031746 c0101;
NFA3_1_46067993[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_46067993 c0101;
NFA4_1_11958757("NFA4-1 char[1]")
NFA5_1_40519951("NFA5-1 char[1]")
NFA4_3_60890569("NFA4-3 char[1]")
NFA5_3_29135240[\"NFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA5_3_29135240 c0101;
NFA4_5_33189039("NFA4-5 scope[1]")
NFA4_9_11144211("NFA4-9 scope[1]")
NFA4_13_30265903("NFA4-13 char[1]")
NFA5_4_3957675[\"NFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA5_4_3957675 c0101;
NFA4_11_52136226("NFA4-11 scope[1]")
NFA4_15_35619075[\"NFA4-15 char[1]
AcceptToken 'blockComment'"/]
class NFA4_15_35619075 c0101;
NFA0_0_46964992 -->|"+
BeginToken '+'
ExtendToken '+'"|NFA1_1_12674872
NFA0_0_46964992 -->|"a
BeginToken 'a'
ExtendToken 'a'"|NFA2_1_20031746
NFA0_0_46964992 -->|"b
BeginToken 'b'
ExtendToken 'b'"|NFA3_1_46067993
NFA0_0_46964992 -->|"/
BeginToken 'blockComment'"|NFA4_1_11958757
NFA0_0_46964992 -->|"/
BeginToken 'inlineComment'"|NFA5_1_40519951
NFA4_1_11958757 -->|"*"|NFA4_3_60890569
NFA5_1_40519951 -->|"/
ExtendToken 'inlineComment'"|NFA5_3_29135240
NFA4_3_60890569 -->|"[^*]"|NFA4_5_33189039
NFA4_3_60890569 -->|"[*]"|NFA4_9_11144211
NFA4_3_60890569 -->|"*"|NFA4_13_30265903
NFA5_3_29135240 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA5_4_3957675
NFA4_5_33189039 -->|"[^*]"|NFA4_5_33189039
NFA4_5_33189039 -->|"[*]"|NFA4_9_11144211
NFA4_5_33189039 -->|"*"|NFA4_13_30265903
NFA4_9_11144211 -->|"[^/]"|NFA4_11_52136226
NFA4_13_30265903 -->|"/
ExtendToken 'blockComment'"|NFA4_15_35619075
NFA5_4_3957675 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA5_4_3957675
NFA4_11_52136226 -->|"[^*]"|NFA4_5_33189039
NFA4_11_52136226 -->|"[*]"|NFA4_9_11144211
NFA4_11_52136226 -->|"*"|NFA4_13_30265903

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
subgraph DFA0_-145138233["DFA0 wholeStart"]
NFA0_0_46964992_0("NFA0-0 wholeStart")
class NFA0_0_46964992_0 c1000;
end
class DFA0_-145138233 c1000;
subgraph DFA1_858262531["DFA1 {1}"]
NFA1_1_12674872_1[\"NFA1-1 char[1]
AcceptToken '+'"/]
class NFA1_1_12674872_1 c0101;
end
class DFA1_858262531 c0101;
subgraph DFA2_-1456802818["DFA2 {1}"]
NFA2_1_20031746_2[\"NFA2-1 char[1]
AcceptToken 'a'"/]
class NFA2_1_20031746_2 c0101;
end
class DFA2_-1456802818 c0101;
subgraph DFA3_-1846132672["DFA3 {1}"]
NFA3_1_46067993_3[\"NFA3-1 char[1]
AcceptToken 'b'"/]
class NFA3_1_46067993_3 c0101;
end
class DFA3_-1846132672 c0101;
subgraph DFA4_1647248238["DFA4 {2}"]
NFA4_1_11958757_4("NFA4-1 char[1]")
NFA5_1_40519951_5("NFA5-1 char[1]")
end
subgraph DFA5_-1056910773["DFA5 {1}"]
NFA4_3_60890569_6("NFA4-3 char[1]")
end
subgraph DFA6_1888404948["DFA6 {1}"]
NFA5_3_29135240_7[\"NFA5-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA5_3_29135240_7 c0101;
end
class DFA6_1888404948 c0101;
subgraph DFA7_-1533072777["DFA7 {1}"]
NFA4_5_33189039_8("NFA4-5 scope[1]")
end
subgraph DFA8_608653625["DFA8 {2}"]
NFA4_9_11144211_9("NFA4-9 scope[1]")
NFA4_13_30265903_10("NFA4-13 char[1]")
end
subgraph DFA9_-1539186643["DFA9 {1}"]
NFA5_4_3957675_11[\"NFA5-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA5_4_3957675_11 c0101;
end
class DFA9_-1539186643 c0101;
subgraph DFA10_249229384["DFA10 {1}"]
NFA4_11_52136226_12("NFA4-11 scope[1]")
end
subgraph DFA11_-1148494017["DFA11 {1}"]
NFA4_15_35619075_13[\"NFA4-15 char[1]
AcceptToken 'blockComment'"/]
class NFA4_15_35619075_13 c0101;
end
class DFA11_-1148494017 c0101;
DFA0_-145138233 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA1_858262531
DFA0_-145138233 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA2_-1456802818
DFA0_-145138233 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_-1846132672
DFA0_-145138233 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA4_1647248238
DFA4_1647248238 -->|"*"|DFA5_-1056910773
DFA4_1647248238 -->|"/
ExtendToken 'inlineComment'"|DFA6_1888404948
DFA5_-1056910773 -->|"[^*]"|DFA7_-1533072777
DFA5_-1056910773 -->|"*"|DFA8_608653625
DFA6_1888404948 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1539186643
DFA7_-1533072777 -->|"[^*]"|DFA7_-1533072777
DFA7_-1533072777 -->|"*"|DFA8_608653625
DFA8_608653625 -->|"[^/]"|DFA10_249229384
DFA8_608653625 -->|"/
ExtendToken 'blockComment'"|DFA11_-1148494017
DFA9_-1539186643 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1539186643
DFA10_249229384 -->|"[^*]"|DFA7_-1533072777
DFA10_249229384 -->|"*"|DFA8_608653625

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
DFA0_-145138233{{"DFA0 wholeStart"}}
class DFA0_-145138233 c1000;
DFA1_858262531[\"DFA1 {1}
AcceptToken '+'"/]
class DFA1_858262531 c0101;
DFA2_-1456802818[\"DFA2 {1}
AcceptToken 'a'"/]
class DFA2_-1456802818 c0101;
DFA3_-1846132672[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_-1846132672 c0101;
DFA4_1647248238{{"DFA4 {2}"}}
DFA5_-1056910773{{"DFA5 {1}"}}
DFA6_1888404948[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_1888404948 c0101;
DFA7_-1533072777{{"DFA7 {1}"}}
DFA8_608653625{{"DFA8 {2}"}}
DFA9_-1539186643[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1539186643 c0101;
DFA10_249229384{{"DFA10 {1}"}}
DFA11_-1148494017[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_-1148494017 c0101;
DFA0_-145138233 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA1_858262531
DFA0_-145138233 -->|"a
BeginToken 'a'
ExtendToken 'a'"|DFA2_-1456802818
DFA0_-145138233 -->|"b
BeginToken 'b'
ExtendToken 'b'"|DFA3_-1846132672
DFA0_-145138233 -->|"/
BeginToken 'blockComment''inlineComment'"|DFA4_1647248238
DFA4_1647248238 -->|"*"|DFA5_-1056910773
DFA4_1647248238 -->|"/
ExtendToken 'inlineComment'"|DFA6_1888404948
DFA5_-1056910773 -->|"[^*]"|DFA7_-1533072777
DFA5_-1056910773 -->|"*"|DFA8_608653625
DFA6_1888404948 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1539186643
DFA7_-1533072777 -->|"[^*]"|DFA7_-1533072777
DFA7_-1533072777 -->|"*"|DFA8_608653625
DFA8_608653625 -->|"[^/]"|DFA10_249229384
DFA8_608653625 -->|"/
ExtendToken 'blockComment'"|DFA11_-1148494017
DFA9_-1539186643 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA9_-1539186643
DFA10_249229384 -->|"[^*]"|DFA7_-1533072777
DFA10_249229384 -->|"*"|DFA8_608653625

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
subgraph MiniDFA0_1649433290["MiniDFA0 {1}"]
DFA0_-145138233_0{{"DFA0 wholeStart"}}
class DFA0_-145138233_0 c1000;
end
class MiniDFA0_1649433290 c1000;
subgraph MiniDFA4_1318974021["MiniDFA4 {1}"]
DFA1_858262531_1[\"DFA1 {1}
AcceptToken '+'"/]
class DFA1_858262531_1 c0101;
end
class MiniDFA4_1318974021 c0101;
subgraph MiniDFA5_947620026["MiniDFA5 {1}"]
DFA2_-1456802818_2[\"DFA2 {1}
AcceptToken 'a'"/]
class DFA2_-1456802818_2 c0101;
end
class MiniDFA5_947620026 c0101;
subgraph MiniDFA6_2049842652["MiniDFA6 {1}"]
DFA3_-1846132672_3[\"DFA3 {1}
AcceptToken 'b'"/]
class DFA3_-1846132672_3 c0101;
end
class MiniDFA6_2049842652 c0101;
subgraph MiniDFA1_-290412782["MiniDFA1 {1}"]
DFA4_1647248238_4{{"DFA4 {2}"}}
end
subgraph MiniDFA2_383063715["MiniDFA2 {3}"]
DFA5_-1056910773_5{{"DFA5 {1}"}}
DFA7_-1533072777_6{{"DFA7 {1}"}}
DFA10_249229384_7{{"DFA10 {1}"}}
end
subgraph MiniDFA7_1691174574["MiniDFA7 {1}"]
DFA6_1888404948_8[\"DFA6 {1}
AcceptToken 'inlineComment'"/]
class DFA6_1888404948_8 c0101;
end
class MiniDFA7_1691174574 c0101;
subgraph MiniDFA3_-1850936065["MiniDFA3 {1}"]
DFA8_608653625_9{{"DFA8 {2}"}}
end
subgraph MiniDFA8_882993668["MiniDFA8 {1}"]
DFA9_-1539186643_10[\"DFA9 {1}
AcceptToken 'inlineComment'"/]
class DFA9_-1539186643_10 c0101;
end
class MiniDFA8_882993668 c0101;
subgraph MiniDFA9_-1869296671["MiniDFA9 {1}"]
DFA11_-1148494017_11[\"DFA11 {1}
AcceptToken 'blockComment'"/]
class DFA11_-1148494017_11 c0101;
end
class MiniDFA9_-1869296671 c0101;
MiniDFA0_1649433290 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA4_1318974021
MiniDFA0_1649433290 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA5_947620026
MiniDFA0_1649433290 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA6_2049842652
MiniDFA0_1649433290 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-290412782
MiniDFA1_-290412782 -->|"*"|MiniDFA2_383063715
MiniDFA1_-290412782 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_1691174574
MiniDFA2_383063715 -->|"[^*]"|MiniDFA2_383063715
MiniDFA2_383063715 -->|"*"|MiniDFA3_-1850936065
MiniDFA7_1691174574 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_882993668
MiniDFA3_-1850936065 -->|"[^/]"|MiniDFA2_383063715
MiniDFA3_-1850936065 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_-1869296671
MiniDFA8_882993668 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_882993668

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
MiniDFA0_1649433290(["MiniDFA0 {1}"])
class MiniDFA0_1649433290 c1000;
MiniDFA4_1318974021[\"MiniDFA4 {1}
AcceptToken '+'"/]
class MiniDFA4_1318974021 c0101;
MiniDFA5_947620026[\"MiniDFA5 {1}
AcceptToken 'a'"/]
class MiniDFA5_947620026 c0101;
MiniDFA6_2049842652[\"MiniDFA6 {1}
AcceptToken 'b'"/]
class MiniDFA6_2049842652 c0101;
MiniDFA1_-290412782(["MiniDFA1 {1}"])
MiniDFA2_383063715(["MiniDFA2 {3}"])
MiniDFA7_1691174574[\"MiniDFA7 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA7_1691174574 c0101;
MiniDFA3_-1850936065(["MiniDFA3 {1}"])
MiniDFA8_882993668[\"MiniDFA8 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA8_882993668 c0101;
MiniDFA9_-1869296671[\"MiniDFA9 {1}
AcceptToken 'blockComment'"/]
class MiniDFA9_-1869296671 c0101;
MiniDFA0_1649433290 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA4_1318974021
MiniDFA0_1649433290 -->|"a
BeginToken 'a'
ExtendToken 'a'"|MiniDFA5_947620026
MiniDFA0_1649433290 -->|"b
BeginToken 'b'
ExtendToken 'b'"|MiniDFA6_2049842652
MiniDFA0_1649433290 -->|"/
BeginToken 'blockComment''inlineComment'"|MiniDFA1_-290412782
MiniDFA1_-290412782 -->|"*"|MiniDFA2_383063715
MiniDFA1_-290412782 -->|"/
ExtendToken 'inlineComment'"|MiniDFA7_1691174574
MiniDFA2_383063715 -->|"[^*]"|MiniDFA2_383063715
MiniDFA2_383063715 -->|"*"|MiniDFA3_-1850936065
MiniDFA7_1691174574 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_882993668
MiniDFA3_-1850936065 -->|"[^/]"|MiniDFA2_383063715
MiniDFA3_-1850936065 -->|"/
ExtendToken 'blockComment'"|MiniDFA9_-1869296671
MiniDFA8_882993668 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA8_882993668

```

# 总结

无。

