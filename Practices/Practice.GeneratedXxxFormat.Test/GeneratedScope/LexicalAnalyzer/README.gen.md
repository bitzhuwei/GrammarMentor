# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Scope`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（62个State）。

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
eNFA0_9_55687020[["εNFA0-9 regex start"]]
eNFA0_0_14354747[["εNFA0-0 char{1, 1}"]]
eNFA0_11_31421133[["εNFA0-11 char{1, 1}"]]
eNFA0_15_27761143[["εNFA0-15 char{1, 1}"]]
eNFA0_19_34060083[["εNFA0-19 char{1, 1}"]]
eNFA0_23_7403364[["εNFA0-23 char{1, 1}"]]
eNFA0_27_62801650[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_53768900[["εNFA0-29 char{1, 1}"]]
eNFA0_31_60313667[["εNFA0-31 char{1, 1}"]]
eNFA0_35_53568854[["εNFA0-35 char{1, 1}"]]
eNFA0_37_44109926[["εNFA0-37 char{1, 1}"]]
eNFA0_41_16134234[["εNFA0-41 scope{1, 1}"]]
eNFA0_1_4578956[["εNFA0-1 char[1]"]]
eNFA0_12_41210606[["εNFA0-12 char[1]"]]
eNFA0_16_35351135[["εNFA0-16 char[1]"]]
eNFA0_20_49724760[["εNFA0-20 char[1]"]]
eNFA0_24_44869658[["εNFA0-24 char[1]"]]
eNFA0_28_28343943[["εNFA0-28 scope[1]"]]
eNFA0_30_14158059[["εNFA0-30 char[1]"]]
eNFA0_32_1173742[["εNFA0-32 char[1]"]]
eNFA0_36_12357643[["εNFA0-36 char[1]"]]
eNFA0_38_10563686[["εNFA0-38 char[1]"]]
eNFA0_42_10990381[["εNFA0-42 scope[1]"]]
eNFA0_2_27964314[["εNFA0-2 char{1, 1}"]]
eNFA0_13_50352234[["εNFA0-13 char{1, 1}"]]
eNFA0_17_50516929[["εNFA0-17 char{1, 1}"]]
eNFA0_21_51999183[["εNFA0-21 char{1, 1}"]]
eNFA0_25_65339469[["εNFA0-25 char{1, 1}"]]
eNFA0_10_21883847[["εNFA0-10 regex end"]]
eNFA0_33_838835[["εNFA0-33 char{1, 1}"]]
eNFA0_39_836829[["εNFA0-39 char{1, 1}"]]
eNFA0_3_674315[["εNFA0-3 char[1]"]]
eNFA0_14_62083862[["εNFA0-14 char[1]"]]
eNFA0_18_48523696[["εNFA0-18 char[1]"]]
eNFA0_22_38105298[["εNFA0-22 char[1]"]]
eNFA0_26_66630284[["εNFA0-26 char[1]"]]
eNFA0_34_5952094[["εNFA0-34 char[1]"]]
eNFA0_40_61445016[["εNFA0-40 char[1]"]]
eNFA0_4_6068839[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_5915793[["εNFA0-5 scope[1]"]]
eNFA0_6_53242138[["εNFA0-6 scope[2]"]]
eNFA0_7_9417197[["εNFA0-7 scope[3]"]]
eNFA0_8_62736895[["εNFA0-8 scope[4]"]]
eNFA0_9_55687020 -.->|"ε"|eNFA0_0_14354747
eNFA0_9_55687020 -.->|"ε"|eNFA0_11_31421133
eNFA0_9_55687020 -.->|"ε"|eNFA0_15_27761143
eNFA0_9_55687020 -.->|"ε"|eNFA0_19_34060083
eNFA0_9_55687020 -.->|"ε"|eNFA0_23_7403364
eNFA0_9_55687020 -.->|"ε"|eNFA0_27_62801650
eNFA0_9_55687020 -.->|"ε"|eNFA0_29_53768900
eNFA0_9_55687020 -.->|"ε"|eNFA0_31_60313667
eNFA0_9_55687020 -.->|"ε"|eNFA0_35_53568854
eNFA0_9_55687020 -.->|"ε"|eNFA0_37_44109926
eNFA0_9_55687020 -.->|"ε"|eNFA0_41_16134234
eNFA0_0_14354747 -->|"#92;"|eNFA0_1_4578956
eNFA0_11_31421133 -->|"#92;"|eNFA0_12_41210606
eNFA0_15_27761143 -->|"#92;"|eNFA0_16_35351135
eNFA0_19_34060083 -->|"#92;"|eNFA0_20_49724760
eNFA0_23_7403364 -->|"#92;"|eNFA0_24_44869658
eNFA0_27_62801650 -->|"[#32;-Z]"|eNFA0_28_28343943
eNFA0_29_53768900 -->|"["|eNFA0_30_14158059
eNFA0_31_60313667 -->|"#92;"|eNFA0_32_1173742
eNFA0_35_53568854 -->|"]"|eNFA0_36_12357643
eNFA0_37_44109926 -->|"#92;"|eNFA0_38_10563686
eNFA0_41_16134234 -->|"[_-~]"|eNFA0_42_10990381
eNFA0_1_4578956 -.->|"ε"|eNFA0_2_27964314
eNFA0_12_41210606 -.->|"ε"|eNFA0_13_50352234
eNFA0_16_35351135 -.->|"ε"|eNFA0_17_50516929
eNFA0_20_49724760 -.->|"ε"|eNFA0_21_51999183
eNFA0_24_44869658 -.->|"ε"|eNFA0_25_65339469
eNFA0_28_28343943 -.->|"ε"|eNFA0_10_21883847
eNFA0_30_14158059 -.->|"ε"|eNFA0_10_21883847
eNFA0_32_1173742 -.->|"ε"|eNFA0_33_838835
eNFA0_36_12357643 -.->|"ε"|eNFA0_10_21883847
eNFA0_38_10563686 -.->|"ε"|eNFA0_39_836829
eNFA0_42_10990381 -.->|"ε"|eNFA0_10_21883847
eNFA0_2_27964314 -->|"u"|eNFA0_3_674315
eNFA0_13_50352234 -->|"t"|eNFA0_14_62083862
eNFA0_17_50516929 -->|"n"|eNFA0_18_48523696
eNFA0_21_51999183 -->|"r"|eNFA0_22_38105298
eNFA0_25_65339469 -->|"-"|eNFA0_26_66630284
eNFA0_33_838835 -->|"#92;"|eNFA0_34_5952094
eNFA0_39_836829 -->|"^"|eNFA0_40_61445016
eNFA0_3_674315 -.->|"ε"|eNFA0_4_6068839
eNFA0_14_62083862 -.->|"ε"|eNFA0_10_21883847
eNFA0_18_48523696 -.->|"ε"|eNFA0_10_21883847
eNFA0_22_38105298 -.->|"ε"|eNFA0_10_21883847
eNFA0_26_66630284 -.->|"ε"|eNFA0_10_21883847
eNFA0_34_5952094 -.->|"ε"|eNFA0_10_21883847
eNFA0_40_61445016 -.->|"ε"|eNFA0_10_21883847
eNFA0_4_6068839 -->|"[0-9]"|eNFA0_5_5915793
eNFA0_5_5915793 -->|"[0-9]"|eNFA0_6_53242138
eNFA0_6_53242138 -->|"[0-9]"|eNFA0_7_9417197
eNFA0_7_9417197 -->|"[0-9]"|eNFA0_8_62736895
eNFA0_8_62736895 -.->|"ε"|eNFA0_10_21883847
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
eNFA0_43_24595518[["εNFA0-43 post-regex start"]]
eNFA0_44_20033078[\"εNFA0-44 post-regex end"/]
eNFA0_43_24595518 -.->|"ε"|eNFA0_44_20033078
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
eNFA0_9_17805683[["εNFA0-9 regex start"]]
eNFA0_0_32974225[["εNFA0-0 char{1, 1}"]]
eNFA0_11_26033424[["εNFA0-11 char{1, 1}"]]
eNFA0_15_52028024[["εNFA0-15 char{1, 1}"]]
eNFA0_19_53520400[["εNFA0-19 char{1, 1}"]]
eNFA0_23_40185120[["εNFA0-23 char{1, 1}"]]
eNFA0_27_33769297[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_50958538[["εNFA0-29 char{1, 1}"]]
eNFA0_31_34000948[["εNFA0-31 char{1, 1}"]]
eNFA0_35_2613431[["εNFA0-35 char{1, 1}"]]
eNFA0_37_10361338[["εNFA0-37 char{1, 1}"]]
eNFA0_39_33962021[["εNFA0-39 char{1, 1}"]]
eNFA0_43_66569185[["εNFA0-43 scope{1, 1}"]]
eNFA0_1_65645300[["εNFA0-1 char[1]"]]
eNFA0_12_53936788[["εNFA0-12 char[1]"]]
eNFA0_16_15669051[["εNFA0-16 char[1]"]]
eNFA0_20_6803737[["εNFA0-20 char[1]"]]
eNFA0_24_61233639[["εNFA0-24 char[1]"]]
eNFA0_28_35488221[["εNFA0-28 scope[1]"]]
eNFA0_30_55973666[["εNFA0-30 char[1]"]]
eNFA0_32_14231847[["εNFA0-32 char[1]"]]
eNFA0_36_23520881[["εNFA0-36 char[1]"]]
eNFA0_38_26143179[["εNFA0-38 char[1]"]]
eNFA0_40_60977760[["εNFA0-40 char[1]"]]
eNFA0_44_62251757[["εNFA0-44 scope[1]"]]
eNFA0_2_11928933[["εNFA0-2 char{1, 1}"]]
eNFA0_13_40251533[["εNFA0-13 char{1, 1}"]]
eNFA0_17_26719483[["εNFA0-17 char{1, 1}"]]
eNFA0_21_39148759[["εNFA0-21 char{1, 1}"]]
eNFA0_25_16794514[["εNFA0-25 char{1, 1}"]]
eNFA0_10_53666608[["εNFA0-10 regex end"]]
eNFA0_33_63163105[["εNFA0-33 char{1, 1}"]]
eNFA0_41_9223355[["εNFA0-41 char{1, 1}"]]
eNFA0_3_8894251[["εNFA0-3 char[1]"]]
eNFA0_14_28332577[["εNFA0-14 char[1]"]]
eNFA0_18_65599034[["εNFA0-18 char[1]"]]
eNFA0_22_11921553[["εNFA0-22 char[1]"]]
eNFA0_26_26121765[["εNFA0-26 char[1]"]]
eNFA0_34_37573083[["εNFA0-34 char[1]"]]
eNFA0_42_37222737[["εNFA0-42 char[1]"]]
eNFA0_4_12939396[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_65177848[["εNFA0-5 scope[1]"]]
eNFA0_6_49729727[["εNFA0-6 scope[2]"]]
eNFA0_7_44914359[["εNFA0-7 scope[3]"]]
eNFA0_8_13237432[["εNFA0-8 scope[4]"]]
eNFA0_9_17805683 -.->|"ε"|eNFA0_0_32974225
eNFA0_9_17805683 -.->|"ε"|eNFA0_11_26033424
eNFA0_9_17805683 -.->|"ε"|eNFA0_15_52028024
eNFA0_9_17805683 -.->|"ε"|eNFA0_19_53520400
eNFA0_9_17805683 -.->|"ε"|eNFA0_23_40185120
eNFA0_9_17805683 -.->|"ε"|eNFA0_27_33769297
eNFA0_9_17805683 -.->|"ε"|eNFA0_29_50958538
eNFA0_9_17805683 -.->|"ε"|eNFA0_31_34000948
eNFA0_9_17805683 -.->|"ε"|eNFA0_35_2613431
eNFA0_9_17805683 -.->|"ε"|eNFA0_37_10361338
eNFA0_9_17805683 -.->|"ε"|eNFA0_39_33962021
eNFA0_9_17805683 -.->|"ε"|eNFA0_43_66569185
eNFA0_0_32974225 -->|"#92;"|eNFA0_1_65645300
eNFA0_11_26033424 -->|"#92;"|eNFA0_12_53936788
eNFA0_15_52028024 -->|"#92;"|eNFA0_16_15669051
eNFA0_19_53520400 -->|"#92;"|eNFA0_20_6803737
eNFA0_23_40185120 -->|"#92;"|eNFA0_24_61233639
eNFA0_27_33769297 -->|"[#32;-Z]"|eNFA0_28_35488221
eNFA0_29_50958538 -->|"["|eNFA0_30_55973666
eNFA0_31_34000948 -->|"#92;"|eNFA0_32_14231847
eNFA0_35_2613431 -->|"]"|eNFA0_36_23520881
eNFA0_37_10361338 -->|"^"|eNFA0_38_26143179
eNFA0_39_33962021 -->|"#92;"|eNFA0_40_60977760
eNFA0_43_66569185 -->|"[_-~]"|eNFA0_44_62251757
eNFA0_1_65645300 -.->|"ε"|eNFA0_2_11928933
eNFA0_12_53936788 -.->|"ε"|eNFA0_13_40251533
eNFA0_16_15669051 -.->|"ε"|eNFA0_17_26719483
eNFA0_20_6803737 -.->|"ε"|eNFA0_21_39148759
eNFA0_24_61233639 -.->|"ε"|eNFA0_25_16794514
eNFA0_28_35488221 -.->|"ε"|eNFA0_10_53666608
eNFA0_30_55973666 -.->|"ε"|eNFA0_10_53666608
eNFA0_32_14231847 -.->|"ε"|eNFA0_33_63163105
eNFA0_36_23520881 -.->|"ε"|eNFA0_10_53666608
eNFA0_38_26143179 -.->|"ε"|eNFA0_10_53666608
eNFA0_40_60977760 -.->|"ε"|eNFA0_41_9223355
eNFA0_44_62251757 -.->|"ε"|eNFA0_10_53666608
eNFA0_2_11928933 -->|"u"|eNFA0_3_8894251
eNFA0_13_40251533 -->|"t"|eNFA0_14_28332577
eNFA0_17_26719483 -->|"n"|eNFA0_18_65599034
eNFA0_21_39148759 -->|"r"|eNFA0_22_11921553
eNFA0_25_16794514 -->|"-"|eNFA0_26_26121765
eNFA0_33_63163105 -->|"#92;"|eNFA0_34_37573083
eNFA0_41_9223355 -->|"^"|eNFA0_42_37222737
eNFA0_3_8894251 -.->|"ε"|eNFA0_4_12939396
eNFA0_14_28332577 -.->|"ε"|eNFA0_10_53666608
eNFA0_18_65599034 -.->|"ε"|eNFA0_10_53666608
eNFA0_22_11921553 -.->|"ε"|eNFA0_10_53666608
eNFA0_26_26121765 -.->|"ε"|eNFA0_10_53666608
eNFA0_34_37573083 -.->|"ε"|eNFA0_10_53666608
eNFA0_42_37222737 -.->|"ε"|eNFA0_10_53666608
eNFA0_4_12939396 -->|"[0-9]"|eNFA0_5_65177848
eNFA0_5_65177848 -->|"[0-9]"|eNFA0_6_49729727
eNFA0_6_49729727 -->|"[0-9]"|eNFA0_7_44914359
eNFA0_7_44914359 -->|"[0-9]"|eNFA0_8_13237432
eNFA0_8_13237432 -.->|"ε"|eNFA0_10_53666608
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
eNFA0_45_14184458[["εNFA0-45 post-regex start"]]
eNFA0_46_60551263[\"εNFA0-46 post-regex end"/]
eNFA0_45_14184458 -.->|"ε"|eNFA0_46_60551263
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
eNFA0_9_9227524[["εNFA0-9 regex start"]]
eNFA0_0_9232000[["εNFA0-0 char{1, 1}"]]
eNFA0_11_15938858[["εNFA0-11 char{1, 1}"]]
eNFA0_15_38962630[["εNFA0-15 char{1, 1}"]]
eNFA0_19_1856480[["εNFA0-19 char{1, 1}"]]
eNFA0_23_16157182[["εNFA0-23 char{1, 1}"]]
eNFA0_27_33663369[["εNFA0-27 scope{1, 1}"]]
eNFA0_29_42378344[["εNFA0-29 char{1, 1}"]]
eNFA0_33_10093828[["εNFA0-33 char{1, 1}"]]
eNFA0_37_12293700[["εNFA0-37 char{1, 1}"]]
eNFA0_41_56265616[["εNFA0-41 char{1, 1}"]]
eNFA0_43_61221073[["εNFA0-43 char{1, 1}"]]
eNFA0_47_59959919[["εNFA0-47 scope{1, 1}"]]
eNFA0_1_18490204[["εNFA0-1 char[1]"]]
eNFA0_12_32194111[["εNFA0-12 char[1]"]]
eNFA0_16_21311547[["εNFA0-16 char[1]"]]
eNFA0_20_57586202[["εNFA0-20 char[1]"]]
eNFA0_24_48513771[["εNFA0-24 char[1]"]]
eNFA0_28_34534866[["εNFA0-28 scope[1]"]]
eNFA0_30_33970761[["εNFA0-30 char[1]"]]
eNFA0_34_37301396[["εNFA0-34 char[1]"]]
eNFA0_38_168245[["εNFA0-38 char[1]"]]
eNFA0_42_36628503[["εNFA0-42 char[1]"]]
eNFA0_44_1514205[["εNFA0-44 char[1]"]]
eNFA0_48_2768364[["εNFA0-48 scope[1]"]]
eNFA0_2_13627845[["εNFA0-2 char{1, 1}"]]
eNFA0_13_55541742[["εNFA0-13 char{1, 1}"]]
eNFA0_17_30113633[["εNFA0-17 char{1, 1}"]]
eNFA0_21_2587248[["εNFA0-21 char{1, 1}"]]
eNFA0_25_23285234[["εNFA0-25 char{1, 1}"]]
eNFA0_10_9594569[["εNFA0-10 regex end"]]
eNFA0_31_8240522[["εNFA0-31 char{1, 1}"]]
eNFA0_35_7055840[["εNFA0-35 char{1, 1}"]]
eNFA0_39_63502565[["εNFA0-39 char{1, 1}"]]
eNFA0_45_28505468[["εNFA0-45 char{1, 1}"]]
eNFA0_3_27241609[["εNFA0-3 char[1]"]]
eNFA0_14_15979144[["εNFA0-14 char[1]"]]
eNFA0_18_15119356[["εNFA0-18 char[1]"]]
eNFA0_22_16708323[["εNFA0-22 char[1]"]]
eNFA0_26_11196914[["εNFA0-26 char[1]"]]
eNFA0_32_45860779[["εNFA0-32 char[1]"]]
eNFA0_36_23735588[["εNFA0-36 char[1]"]]
eNFA0_40_43534437[["εNFA0-40 char[1]"]]
eNFA0_46_14118753[["εNFA0-46 char[1]"]]
eNFA0_4_43847892[["εNFA0-4 scope{4, 4}"]]
eNFA0_5_36655246[["εNFA0-5 scope[1]"]]
eNFA0_6_61461766[["εNFA0-6 scope[2]"]]
eNFA0_7_16284982[["εNFA0-7 scope[3]"]]
eNFA0_8_19242262[["εNFA0-8 scope[4]"]]
eNFA0_9_9227524 -.->|"ε"|eNFA0_0_9232000
eNFA0_9_9227524 -.->|"ε"|eNFA0_11_15938858
eNFA0_9_9227524 -.->|"ε"|eNFA0_15_38962630
eNFA0_9_9227524 -.->|"ε"|eNFA0_19_1856480
eNFA0_9_9227524 -.->|"ε"|eNFA0_23_16157182
eNFA0_9_9227524 -.->|"ε"|eNFA0_27_33663369
eNFA0_9_9227524 -.->|"ε"|eNFA0_29_42378344
eNFA0_9_9227524 -.->|"ε"|eNFA0_33_10093828
eNFA0_9_9227524 -.->|"ε"|eNFA0_37_12293700
eNFA0_9_9227524 -.->|"ε"|eNFA0_41_56265616
eNFA0_9_9227524 -.->|"ε"|eNFA0_43_61221073
eNFA0_9_9227524 -.->|"ε"|eNFA0_47_59959919
eNFA0_0_9232000 -->|"#92;"|eNFA0_1_18490204
eNFA0_11_15938858 -->|"#92;"|eNFA0_12_32194111
eNFA0_15_38962630 -->|"#92;"|eNFA0_16_21311547
eNFA0_19_1856480 -->|"#92;"|eNFA0_20_57586202
eNFA0_23_16157182 -->|"#92;"|eNFA0_24_48513771
eNFA0_27_33663369 -->|"[#32;-Z]"|eNFA0_28_34534866
eNFA0_29_42378344 -->|"#92;"|eNFA0_30_33970761
eNFA0_33_10093828 -->|"#92;"|eNFA0_34_37301396
eNFA0_37_12293700 -->|"#92;"|eNFA0_38_168245
eNFA0_41_56265616 -->|"^"|eNFA0_42_36628503
eNFA0_43_61221073 -->|"#92;"|eNFA0_44_1514205
eNFA0_47_59959919 -->|"[_-~]"|eNFA0_48_2768364
eNFA0_1_18490204 -.->|"ε"|eNFA0_2_13627845
eNFA0_12_32194111 -.->|"ε"|eNFA0_13_55541742
eNFA0_16_21311547 -.->|"ε"|eNFA0_17_30113633
eNFA0_20_57586202 -.->|"ε"|eNFA0_21_2587248
eNFA0_24_48513771 -.->|"ε"|eNFA0_25_23285234
eNFA0_28_34534866 -.->|"ε"|eNFA0_10_9594569
eNFA0_30_33970761 -.->|"ε"|eNFA0_31_8240522
eNFA0_34_37301396 -.->|"ε"|eNFA0_35_7055840
eNFA0_38_168245 -.->|"ε"|eNFA0_39_63502565
eNFA0_42_36628503 -.->|"ε"|eNFA0_10_9594569
eNFA0_44_1514205 -.->|"ε"|eNFA0_45_28505468
eNFA0_48_2768364 -.->|"ε"|eNFA0_10_9594569
eNFA0_2_13627845 -->|"u"|eNFA0_3_27241609
eNFA0_13_55541742 -->|"t"|eNFA0_14_15979144
eNFA0_17_30113633 -->|"n"|eNFA0_18_15119356
eNFA0_21_2587248 -->|"r"|eNFA0_22_16708323
eNFA0_25_23285234 -->|"-"|eNFA0_26_11196914
eNFA0_31_8240522 -->|"["|eNFA0_32_45860779
eNFA0_35_7055840 -->|"#92;"|eNFA0_36_23735588
eNFA0_39_63502565 -->|"]"|eNFA0_40_43534437
eNFA0_45_28505468 -->|"^"|eNFA0_46_14118753
eNFA0_3_27241609 -.->|"ε"|eNFA0_4_43847892
eNFA0_14_15979144 -.->|"ε"|eNFA0_10_9594569
eNFA0_18_15119356 -.->|"ε"|eNFA0_10_9594569
eNFA0_22_16708323 -.->|"ε"|eNFA0_10_9594569
eNFA0_26_11196914 -.->|"ε"|eNFA0_10_9594569
eNFA0_32_45860779 -.->|"ε"|eNFA0_10_9594569
eNFA0_36_23735588 -.->|"ε"|eNFA0_10_9594569
eNFA0_40_43534437 -.->|"ε"|eNFA0_10_9594569
eNFA0_46_14118753 -.->|"ε"|eNFA0_10_9594569
eNFA0_4_43847892 -->|"[0-9]"|eNFA0_5_36655246
eNFA0_5_36655246 -->|"[0-9]"|eNFA0_6_61461766
eNFA0_6_61461766 -->|"[0-9]"|eNFA0_7_16284982
eNFA0_7_16284982 -->|"[0-9]"|eNFA0_8_19242262
eNFA0_8_19242262 -.->|"ε"|eNFA0_10_9594569
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
eNFA0_49_44015150[["εNFA0-49 post-regex start"]]
eNFA0_50_60592031[\"εNFA0-50 post-regex end"/]
eNFA0_49_44015150 -.->|"ε"|eNFA0_50_60592031
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
eNFA0_2_62513914[["εNFA0-2 regex start"]]
eNFA0_0_25754316[["εNFA0-0 char{1, 1}"]]
eNFA0_1_30462260[["εNFA0-1 char[1]"]]
eNFA0_3_5724890[["εNFA0-3 regex end"]]
eNFA0_2_62513914 -.->|"ε"|eNFA0_0_25754316
eNFA0_0_25754316 -->|"["|eNFA0_1_30462260
eNFA0_1_30462260 -.->|"ε"|eNFA0_3_5724890
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
eNFA0_4_51524015[["εNFA0-4 post-regex start"]]
eNFA0_5_61062956[\"εNFA0-5 post-regex end"/]
eNFA0_4_51524015 -.->|"ε"|eNFA0_5_61062956
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
eNFA0_2_25287256[["εNFA0-2 regex start"]]
eNFA0_0_26258720[["εNFA0-0 char{1, 1}"]]
eNFA0_1_35001888[["εNFA0-1 char[1]"]]
eNFA0_3_46581538[["εNFA0-3 regex end"]]
eNFA0_2_25287256 -.->|"ε"|eNFA0_0_26258720
eNFA0_0_26258720 -->|"]"|eNFA0_1_35001888
eNFA0_1_35001888 -.->|"ε"|eNFA0_3_46581538
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
eNFA0_4_16580664[["εNFA0-4 post-regex start"]]
eNFA0_5_15008249[\"εNFA0-5 post-regex end"/]
eNFA0_4_16580664 -.->|"ε"|eNFA0_5_15008249
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
eNFA0_4_33153033[["εNFA0-4 regex start"]]
eNFA0_0_29941845[["εNFA0-0 char{1, 1}"]]
eNFA0_1_1041149[["εNFA0-1 char[1]"]]
eNFA0_2_9370348[["εNFA0-2 char{1, 1}"]]
eNFA0_3_17224274[["εNFA0-3 char[1]"]]
eNFA0_5_20800744[["εNFA0-5 regex end"]]
eNFA0_4_33153033 -.->|"ε"|eNFA0_0_29941845
eNFA0_0_29941845 -->|"["|eNFA0_1_1041149
eNFA0_1_1041149 -.->|"ε"|eNFA0_2_9370348
eNFA0_2_9370348 -->|"^"|eNFA0_3_17224274
eNFA0_3_17224274 -.->|"ε"|eNFA0_5_20800744
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
eNFA0_6_52988976[["εNFA0-6 post-regex start"]]
eNFA0_7_7138737[\"εNFA0-7 post-regex end"/]
eNFA0_6_52988976 -.->|"ε"|eNFA0_7_7138737
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
eNFA0_16_51940951[["εNFA0-16 regex start"]]
eNFA0_0_64815380[["εNFA0-0 char{1, 1}"]]
eNFA0_1_46467513[["εNFA0-1 char[1]"]]
eNFA0_2_15554440[["εNFA0-2 char{1, 1}"]]
eNFA0_3_16176504[["εNFA0-3 char[1]"]]
eNFA0_6_59079939[["εNFA0-6 regex start"]]
eNFA0_4_20745763[["εNFA0-4 scope{1, 1}"]]
eNFA0_8_61957408[["εNFA0-8 scope{1, 1}"]]
eNFA0_7_2685223[["εNFA0-7 regex end"]]
eNFA0_5_24167010[["εNFA0-5 scope[1]"]]
eNFA0_9_22217739[["εNFA0-9 scope[1]"]]
eNFA0_12_11370808[["εNFA0-12 char{1, 1}"]]
eNFA0_10_10134624[["εNFA0-10 scope{1, 1}"]]
eNFA0_13_24102752[["εNFA0-13 char[1]"]]
eNFA0_11_52494141[["εNFA0-11 scope[1]"]]
eNFA0_14_15598181[["εNFA0-14 char{1, 1}"]]
eNFA0_15_55493126[["εNFA0-15 char[1]"]]
eNFA0_17_29676093[["εNFA0-17 regex end"]]
eNFA0_16_51940951 -.->|"ε"|eNFA0_0_64815380
eNFA0_0_64815380 -->|"/"|eNFA0_1_46467513
eNFA0_1_46467513 -.->|"ε"|eNFA0_2_15554440
eNFA0_2_15554440 -->|"*"|eNFA0_3_16176504
eNFA0_3_16176504 -.->|"ε"|eNFA0_6_59079939
eNFA0_6_59079939 -.->|"ε"|eNFA0_4_20745763
eNFA0_6_59079939 -.->|"ε"|eNFA0_8_61957408
eNFA0_6_59079939 -.->|"ε"|eNFA0_7_2685223
eNFA0_4_20745763 -->|"[^*]"|eNFA0_5_24167010
eNFA0_8_61957408 -->|"[*]"|eNFA0_9_22217739
eNFA0_7_2685223 -.->|"ε"|eNFA0_6_59079939
eNFA0_7_2685223 -.->|"ε"|eNFA0_12_11370808
eNFA0_5_24167010 -.->|"ε"|eNFA0_7_2685223
eNFA0_9_22217739 -.->|"ε"|eNFA0_10_10134624
eNFA0_12_11370808 -->|"*"|eNFA0_13_24102752
eNFA0_10_10134624 -->|"[^/]"|eNFA0_11_52494141
eNFA0_13_24102752 -.->|"ε"|eNFA0_14_15598181
eNFA0_11_52494141 -.->|"ε"|eNFA0_7_2685223
eNFA0_14_15598181 -->|"/"|eNFA0_15_55493126
eNFA0_15_55493126 -.->|"ε"|eNFA0_17_29676093
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
eNFA0_18_65758253[["εNFA0-18 post-regex start"]]
eNFA0_19_54953365[\"εNFA0-19 post-regex end"/]
eNFA0_18_65758253 -.->|"ε"|eNFA0_19_54953365
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
eNFA0_5_57437397[["εNFA0-5 regex start"]]
eNFA0_0_47174532[["εNFA0-0 char{1, 1}"]]
eNFA0_1_21917606[["εNFA0-1 char[1]"]]
eNFA0_2_63040734[["εNFA0-2 char{1, 1}"]]
eNFA0_3_48620262[["εNFA0-3 char[1]"]]
eNFA0_4_34929182[["εNFA0-4 char{0, ∞}"]]
eNFA0_6_45927189[["εNFA0-6 regex end"]]
eNFA0_5_57437397 -.->|"ε"|eNFA0_0_47174532
eNFA0_0_47174532 -->|"/"|eNFA0_1_21917606
eNFA0_1_21917606 -.->|"ε"|eNFA0_2_63040734
eNFA0_2_63040734 -->|"/"|eNFA0_3_48620262
eNFA0_3_48620262 -.->|"ε"|eNFA0_4_34929182
eNFA0_4_34929182 -->|"[#92;t#92;r#32;-~]"|eNFA0_4_34929182
eNFA0_4_34929182 -.->|"ε"|eNFA0_6_45927189
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
eNFA0_7_18331773[["εNFA0-7 post-regex start"]]
eNFA0_8_30768229[\"εNFA0-8 post-regex end"/]
eNFA0_7_18331773 -.->|"ε"|eNFA0_8_30768229
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
eNFA0_0_11222187[["εNFA0-0 wholeStart"]]
eNFA1_9_26089095[["εNFA1-9 regex start"]]
class eNFA1_9_26089095 c1000;
eNFA2_2_33890820[["εNFA2-2 regex start"]]
class eNFA2_2_33890820 c1000;
eNFA3_2_35288370[["εNFA3-2 regex start"]]
class eNFA3_2_35288370 c1000;
eNFA4_4_47920339[["εNFA4-4 regex start"]]
class eNFA4_4_47920339 c1000;
eNFA5_16_19589120[["εNFA5-16 regex start"]]
class eNFA5_16_19589120 c1000;
eNFA6_5_48517864[["εNFA6-5 regex start"]]
class eNFA6_5_48517864 c1000;
eNFA1_0_32841951[["εNFA1-0 char{1, 1}"]]
eNFA1_11_33475267[["εNFA1-11 char{1, 1}"]]
eNFA1_15_27142108[["εNFA1-15 char{1, 1}"]]
eNFA1_19_42952388[["εNFA1-19 char{1, 1}"]]
eNFA1_23_51027174[["εNFA1-23 char{1, 1}"]]
eNFA1_27_56591389[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_39560457[["εNFA1-29 char{1, 1}"]]
eNFA1_33_20499795[["εNFA1-33 char{1, 1}"]]
eNFA1_37_50280428[["εNFA1-37 char{1, 1}"]]
eNFA1_41_49870669[["εNFA1-41 char{1, 1}"]]
eNFA1_43_46182839[["εNFA1-43 char{1, 1}"]]
eNFA1_47_12992371[["εNFA1-47 scope{1, 1}"]]
eNFA2_0_10346342[["εNFA2-0 char{1, 1}"]]
eNFA3_0_39785747[["εNFA3-0 char{1, 1}"]]
eNFA4_0_56342274[["εNFA4-0 char{1, 1}"]]
eNFA5_0_43214919[["εNFA5-0 char{1, 1}"]]
eNFA6_0_37632913[["εNFA6-0 char{1, 1}"]]
eNFA1_1_58527497[["εNFA1-1 char[1]"]]
eNFA1_12_56985425[["εNFA1-12 char[1]"]]
eNFA1_16_43106784[["εNFA1-16 char[1]"]]
eNFA1_20_52416742[["εNFA1-20 char[1]"]]
eNFA1_24_1988636[["εNFA1-24 char[1]"]]
eNFA1_28_9089319[["εNFA1-28 scope[1]"]]
eNFA1_30_17897732[["εNFA1-30 char[1]"]]
eNFA1_34_26861861[["εNFA1-34 char[1]"]]
eNFA1_38_40430162[["εNFA1-38 char[1]"]]
eNFA1_42_49822483[["εNFA1-42 char[1]"]]
eNFA1_44_28327138[["εNFA1-44 char[1]"]]
eNFA1_48_14695014[["εNFA1-48 scope[1]"]]
eNFA2_1_26008214[["εNFA2-1 char[1]"]]
eNFA3_1_22527411[["εNFA3-1 char[1]"]]
eNFA4_1_53617656[["εNFA4-1 char[1]"]]
eNFA5_1_12796860[["εNFA5-1 char[1]"]]
eNFA6_1_48062879[["εNFA6-1 char[1]"]]
eNFA1_2_29912730[["εNFA1-2 char{1, 1}"]]
eNFA1_13_779118[["εNFA1-13 char{1, 1}"]]
eNFA1_17_7012069[["εNFA1-17 char{1, 1}"]]
eNFA1_21_63108622[["εNFA1-21 char{1, 1}"]]
eNFA1_25_31106692[["εNFA1-25 char{1, 1}"]]
eNFA1_10_45749167[["εNFA1-10 regex end"]]
class eNFA1_10_45749167 c0100;
eNFA1_31_11524775[["εNFA1-31 char{1, 1}"]]
eNFA1_35_36614112[["εNFA1-35 char{1, 1}"]]
eNFA1_39_61091552[["εNFA1-39 char{1, 1}"]]
eNFA1_45_47536979[["εNFA1-45 char{1, 1}"]]
eNFA2_3_32747334[["εNFA2-3 regex end"]]
class eNFA2_3_32747334 c0100;
eNFA3_3_1420113[["εNFA3-3 regex end"]]
class eNFA3_3_1420113 c0100;
eNFA4_2_25290077[["εNFA4-2 char{1, 1}"]]
eNFA5_2_26284107[["εNFA5-2 char{1, 1}"]]
eNFA6_2_35230376[["εNFA6-2 char{1, 1}"]]
eNFA1_3_48637933[["εNFA1-3 char[1]"]]
eNFA1_14_65146268[["εNFA1-14 char[1]"]]
eNFA1_18_49445506[["εNFA1-18 char[1]"]]
eNFA1_22_42356378[["εNFA1-22 char[1]"]]
eNFA1_26_45663083[["εNFA1-26 char[1]"]]
eNFA1_49_65590400[["εNFA1-49 post-regex start"]]
class eNFA1_49_65590400 c0010;
eNFA1_32_8314568[["εNFA1-32 char[1]"]]
eNFA1_36_7722248[["εNFA1-36 char[1]"]]
eNFA1_40_2391374[["εNFA1-40 char[1]"]]
eNFA1_46_21522370[["εNFA1-46 char[1]"]]
eNFA2_4_26290551[["εNFA2-4 post-regex start"]]
class eNFA2_4_26290551 c0010;
eNFA7_9_28367147[["εNFA7-9 regex start"]]
class eNFA7_9_28367147 c1000;
eNFA3_4_12781022[["εNFA3-4 post-regex start"]]
class eNFA3_4_12781022 c0010;
eNFA4_3_37318421[["εNFA4-3 char[1]"]]
eNFA5_3_54316058[["εNFA5-3 char[1]"]]
eNFA6_3_50309255[["εNFA6-3 char[1]"]]
eNFA1_4_10835231[["εNFA1-4 scope{4, 4}"]]
eNFA1_50_53442692[\"εNFA1-50 post-regex end"/]
class eNFA1_50_53442692 c0001;
eNFA2_5_36581930[\"εNFA2-5 post-regex end"/]
class eNFA2_5_36581930 c0001;
eNFA7_0_16037598[["εNFA7-0 char{1, 1}"]]
eNFA7_11_53977738[["εNFA7-11 char{1, 1}"]]
eNFA7_15_10120656[["εNFA7-15 char{1, 1}"]]
eNFA7_19_23977041[["εNFA7-19 char{1, 1}"]]
eNFA7_23_14466778[["εNFA7-23 char{1, 1}"]]
eNFA7_27_63092140[["εNFA7-27 scope{1, 1}"]]
eNFA7_29_30958352[["εNFA7-29 char{1, 1}"]]
eNFA7_31_10189720[["εNFA7-31 char{1, 1}"]]
eNFA7_35_24598620[["εNFA7-35 char{1, 1}"]]
eNFA7_37_20060988[["εNFA7-37 char{1, 1}"]]
eNFA7_41_46331171[["εNFA7-41 scope{1, 1}"]]
eNFA3_5_49159881[\"εNFA3-5 post-regex end"/]
class eNFA3_5_49159881 c0001;
eNFA4_5_321477[["εNFA4-5 regex end"]]
class eNFA4_5_321477 c0100;
eNFA5_6_26039685[["εNFA5-6 regex start"]]
eNFA6_4_65242240[["εNFA6-4 char{0, ∞}"]]
eNFA1_5_28611270[["εNFA1-5 scope[1]"]]
eNFA0_1_60801917[\"εNFA0-1 wholeEnd"/]
eNFA7_1_15054180[["εNFA7-1 char[1]"]]
eNFA7_12_1269896[["εNFA7-12 char[1]"]]
eNFA7_16_11429066[["εNFA7-16 char[1]"]]
eNFA7_20_35752731[["εNFA7-20 char[1]"]]
eNFA7_24_53339124[["εNFA7-24 char[1]"]]
eNFA7_28_19665615[["εNFA7-28 scope[1]"]]
eNFA7_30_14327361[["εNFA7-30 char[1]"]]
eNFA7_32_10290070[["εNFA7-32 char[1]"]]
eNFA7_36_42772808[["εNFA7-36 char[1]"]]
eNFA7_38_25501770[["εNFA7-38 char[1]"]]
eNFA7_42_49410957[["εNFA7-42 scope[1]"]]
eNFA4_6_2893298[["εNFA4-6 post-regex start"]]
class eNFA4_6_2893298 c0010;
eNFA8_9_2313746[["εNFA8-9 regex start"]]
class eNFA8_9_2313746 c1000;
eNFA5_4_28839721[["εNFA5-4 scope{1, 1}"]]
eNFA5_8_33030575[["εNFA5-8 scope{1, 1}"]]
eNFA5_7_58230900[["εNFA5-7 regex end"]]
eNFA6_6_50130116[["εNFA6-6 regex end"]]
class eNFA6_6_50130116 c0100;
eNFA1_6_2788537[["εNFA1-6 scope[2]"]]
eNFA7_2_25096836[["εNFA7-2 char{1, 1}"]]
eNFA7_13_24544935[["εNFA7-13 char{1, 1}"]]
eNFA7_17_19577827[["εNFA7-17 char{1, 1}"]]
eNFA7_21_41982722[["εNFA7-21 char{1, 1}"]]
eNFA7_25_42300179[["εNFA7-25 char{1, 1}"]]
eNFA7_10_61837391[["εNFA7-10 regex end"]]
class eNFA7_10_61837391 c0100;
eNFA7_33_36326405[["εNFA7-33 char{1, 1}"]]
eNFA7_39_56757654[["εNFA7-39 char{1, 1}"]]
eNFA4_7_28629874[\"εNFA4-7 post-regex end"/]
class eNFA4_7_28629874 c0001;
eNFA8_0_53195707[["εNFA8-0 char{1, 1}"]]
eNFA8_11_20823715[["εNFA8-11 char{1, 1}"]]
eNFA8_15_8999315[["εNFA8-15 char{1, 1}"]]
eNFA8_19_13884972[["εNFA8-19 char{1, 1}"]]
eNFA8_23_57855887[["εNFA8-23 char{1, 1}"]]
eNFA8_27_50940942[["εNFA8-27 scope{1, 1}"]]
eNFA8_29_55815296[["εNFA8-29 char{1, 1}"]]
eNFA8_31_32575624[["εNFA8-31 char{1, 1}"]]
eNFA8_35_24745166[["εNFA8-35 char{1, 1}"]]
eNFA8_37_21379907[["εNFA8-37 char{1, 1}"]]
eNFA8_39_58201440[["εNFA8-39 char{1, 1}"]]
eNFA8_43_54050919[["εNFA8-43 scope{1, 1}"]]
eNFA5_5_37524543[["εNFA5-5 scope[1]"]]
eNFA5_9_63507614[["εNFA5-9 scope[1]"]]
eNFA5_12_19082474[["εNFA5-12 char{1, 1}"]]
eNFA6_7_3151905[["εNFA6-7 post-regex start"]]
class eNFA6_7_3151905 c0010;
eNFA1_7_59043505[["εNFA1-7 scope[3]"]]
eNFA7_3_61629497[["εNFA7-3 char[1]"]]
eNFA7_14_42045429[["εNFA7-14 char[1]"]]
eNFA7_18_42864547[["εNFA7-18 char[1]"]]
eNFA7_22_50236607[["εNFA7-22 char[1]"]]
eNFA7_26_49476282[["εNFA7-26 char[1]"]]
eNFA7_43_7713623[["εNFA7-43 post-regex start"]]
class eNFA7_43_7713623 c0010;
eNFA7_34_42633357[["εNFA7-34 char[1]"]]
eNFA7_40_48155897[["εNFA7-40 char[1]"]]
eNFA8_1_25933367[["εNFA8-1 char[1]"]]
eNFA8_12_32073719[["εNFA8-12 char[1]"]]
eNFA8_16_20228022[["εNFA8-16 char[1]"]]
eNFA8_20_47834478[["εNFA8-20 char[1]"]]
eNFA8_24_27857118[["εNFA8-24 char[1]"]]
eNFA8_28_10216818[["εNFA8-28 scope[1]"]]
eNFA8_30_16696223[["εNFA8-30 char[1]"]]
eNFA8_32_49387472[["εNFA8-32 char[1]"]]
eNFA8_36_24842503[["εNFA8-36 char[1]"]]
eNFA8_38_22255938[["εNFA8-38 char[1]"]]
eNFA8_40_41834070[["εNFA8-40 char[1]"]]
eNFA8_44_66085716[["εNFA8-44 scope[1]"]]
eNFA5_10_33116486[["εNFA5-10 scope{1, 1}"]]
eNFA5_13_29612923[["εNFA5-13 char[1]"]]
eNFA6_8_34007596[\"εNFA6-8 post-regex end"/]
class eNFA6_8_34007596 c0001;
eNFA1_8_59483605[["εNFA1-8 scope[4]"]]
eNFA7_4_65189719[["εNFA7-4 scope{4, 4}"]]
eNFA7_44_8313609[\"εNFA7-44 post-regex end"/]
class eNFA7_44_8313609 c0001;
eNFA8_2_8960839[["εNFA8-2 char{1, 1}"]]
eNFA8_13_13538688[["εNFA8-13 char{1, 1}"]]
eNFA8_17_54739329[["εNFA8-17 char{1, 1}"]]
eNFA8_21_22891915[["εNFA8-21 char{1, 1}"]]
eNFA8_25_4700647[["εNFA8-25 char{1, 1}"]]
eNFA8_10_16048282[["εNFA8-10 regex end"]]
class eNFA8_10_16048282 c0100;
eNFA8_33_37982554[["εNFA8-33 char{1, 1}"]]
eNFA8_41_40430446[["εNFA8-41 char{1, 1}"]]
eNFA5_11_2176568[["εNFA5-11 scope[1]"]]
eNFA5_14_53640668[["εNFA5-14 char{1, 1}"]]
eNFA7_5_46688182[["εNFA7-5 scope[1]"]]
eNFA8_3_23646388[["εNFA8-3 char[1]"]]
eNFA8_14_57900534[["εNFA8-14 char[1]"]]
eNFA8_18_51342761[["εNFA8-18 char[1]"]]
eNFA8_22_59431671[["εNFA8-22 char[1]"]]
eNFA8_26_65122991[["εNFA8-26 char[1]"]]
eNFA8_45_42513748[["εNFA8-45 post-regex start"]]
class eNFA8_45_42513748 c0010;
eNFA8_34_49236012[["εNFA8-34 char[1]"]]
eNFA8_42_40470925[["εNFA8-42 char[1]"]]
eNFA5_15_53389951[["εNFA5-15 char[1]"]]
eNFA7_6_36309279[["εNFA7-6 scope[2]"]]
eNFA8_4_58348056[["εNFA8-4 scope{4, 4}"]]
eNFA8_46_56919532[\"εNFA8-46 post-regex end"/]
class eNFA8_46_56919532 c0001;
eNFA5_17_10747513[["εNFA5-17 regex end"]]
class eNFA5_17_10747513 c0100;
eNFA7_7_37866150[["εNFA7-7 scope[3]"]]
eNFA8_5_5251037[["εNFA8-5 scope[1]"]]
eNFA5_18_29618759[["εNFA5-18 post-regex start"]]
class eNFA5_18_29618759 c0010;
eNFA7_8_30749896[["εNFA7-8 scope[4]"]]
eNFA8_6_22680839[["εNFA8-6 scope[2]"]]
eNFA5_19_42084359[\"εNFA5-19 post-regex end"/]
class eNFA5_19_42084359 c0001;
eNFA8_7_25208690[["εNFA8-7 scope[3]"]]
eNFA8_8_28694013[["εNFA8-8 scope[4]"]]
eNFA0_0_11222187 -.->|"ε"|eNFA1_9_26089095
eNFA0_0_11222187 -.->|"ε"|eNFA2_2_33890820
eNFA0_0_11222187 -.->|"ε"|eNFA3_2_35288370
eNFA0_0_11222187 -.->|"ε"|eNFA4_4_47920339
eNFA0_0_11222187 -.->|"ε"|eNFA5_16_19589120
eNFA0_0_11222187 -.->|"ε"|eNFA6_5_48517864
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_0_32841951
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_11_33475267
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_15_27142108
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_19_42952388
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_23_51027174
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_27_56591389
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_29_39560457
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_33_20499795
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_37_50280428
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_41_49870669
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_43_46182839
eNFA1_9_26089095 -.->|"ε
BeginToken 'char'"|eNFA1_47_12992371
eNFA2_2_33890820 -.->|"ε
BeginToken '['"|eNFA2_0_10346342
eNFA3_2_35288370 -.->|"ε
BeginToken ']'"|eNFA3_0_39785747
eNFA4_4_47920339 -.->|"ε
BeginToken '[^'"|eNFA4_0_56342274
eNFA5_16_19589120 -.->|"ε
BeginToken 'blockComment'"|eNFA5_0_43214919
eNFA6_5_48517864 -.->|"ε
BeginToken 'inlineComment'"|eNFA6_0_37632913
eNFA1_0_32841951 -->|"#92;"|eNFA1_1_58527497
eNFA1_11_33475267 -->|"#92;"|eNFA1_12_56985425
eNFA1_15_27142108 -->|"#92;"|eNFA1_16_43106784
eNFA1_19_42952388 -->|"#92;"|eNFA1_20_52416742
eNFA1_23_51027174 -->|"#92;"|eNFA1_24_1988636
eNFA1_27_56591389 -->|"[#32;-Z]"|eNFA1_28_9089319
eNFA1_29_39560457 -->|"#92;"|eNFA1_30_17897732
eNFA1_33_20499795 -->|"#92;"|eNFA1_34_26861861
eNFA1_37_50280428 -->|"#92;"|eNFA1_38_40430162
eNFA1_41_49870669 -->|"^"|eNFA1_42_49822483
eNFA1_43_46182839 -->|"#92;"|eNFA1_44_28327138
eNFA1_47_12992371 -->|"[_-~]"|eNFA1_48_14695014
eNFA2_0_10346342 -->|"["|eNFA2_1_26008214
eNFA3_0_39785747 -->|"]"|eNFA3_1_22527411
eNFA4_0_56342274 -->|"["|eNFA4_1_53617656
eNFA5_0_43214919 -->|"/"|eNFA5_1_12796860
eNFA6_0_37632913 -->|"/"|eNFA6_1_48062879
eNFA1_1_58527497 -.->|"ε"|eNFA1_2_29912730
eNFA1_12_56985425 -.->|"ε"|eNFA1_13_779118
eNFA1_16_43106784 -.->|"ε"|eNFA1_17_7012069
eNFA1_20_52416742 -.->|"ε"|eNFA1_21_63108622
eNFA1_24_1988636 -.->|"ε"|eNFA1_25_31106692
eNFA1_28_9089319 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_30_17897732 -.->|"ε"|eNFA1_31_11524775
eNFA1_34_26861861 -.->|"ε"|eNFA1_35_36614112
eNFA1_38_40430162 -.->|"ε"|eNFA1_39_61091552
eNFA1_42_49822483 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_44_28327138 -.->|"ε"|eNFA1_45_47536979
eNFA1_48_14695014 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA2_1_26008214 -.->|"ε
ExtendToken '['"|eNFA2_3_32747334
eNFA3_1_22527411 -.->|"ε
ExtendToken ']'"|eNFA3_3_1420113
eNFA4_1_53617656 -.->|"ε"|eNFA4_2_25290077
eNFA5_1_12796860 -.->|"ε"|eNFA5_2_26284107
eNFA6_1_48062879 -.->|"ε"|eNFA6_2_35230376
eNFA1_2_29912730 -->|"u"|eNFA1_3_48637933
eNFA1_13_779118 -->|"t"|eNFA1_14_65146268
eNFA1_17_7012069 -->|"n"|eNFA1_18_49445506
eNFA1_21_63108622 -->|"r"|eNFA1_22_42356378
eNFA1_25_31106692 -->|"-"|eNFA1_26_45663083
eNFA1_10_45749167 -.->|"ε"|eNFA1_49_65590400
eNFA1_31_11524775 -->|"["|eNFA1_32_8314568
eNFA1_35_36614112 -->|"#92;"|eNFA1_36_7722248
eNFA1_39_61091552 -->|"]"|eNFA1_40_2391374
eNFA1_45_47536979 -->|"^"|eNFA1_46_21522370
eNFA2_3_32747334 -.->|"ε"|eNFA2_4_26290551
eNFA2_3_32747334 -.->|"ε
AcceptPrevious '['"|eNFA7_9_28367147
eNFA3_3_1420113 -.->|"ε"|eNFA3_4_12781022
eNFA4_2_25290077 -->|"^"|eNFA4_3_37318421
eNFA5_2_26284107 -->|"*"|eNFA5_3_54316058
eNFA6_2_35230376 -->|"/"|eNFA6_3_50309255
eNFA1_3_48637933 -.->|"ε"|eNFA1_4_10835231
eNFA1_14_65146268 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_18_49445506 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_22_42356378 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_26_45663083 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_49_65590400 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53442692
eNFA1_32_8314568 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_36_7722248 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_40_2391374 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA1_46_21522370 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA2_4_26290551 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_36581930
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_0_16037598
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_11_53977738
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_15_10120656
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_19_23977041
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_23_14466778
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_27_63092140
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_29_30958352
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_31_10189720
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_35_24598620
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_37_20060988
eNFA7_9_28367147 -.->|"ε
BeginToken 'firstItem1'"|eNFA7_41_46331171
eNFA3_4_12781022 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_49159881
eNFA4_3_37318421 -.->|"ε
ExtendToken '[^'"|eNFA4_5_321477
eNFA5_3_54316058 -.->|"ε"|eNFA5_6_26039685
eNFA6_3_50309255 -.->|"ε"|eNFA6_4_65242240
eNFA1_4_10835231 -->|"[0-9]"|eNFA1_5_28611270
eNFA1_50_53442692 -.->|"ε"|eNFA0_1_60801917
eNFA2_5_36581930 -.->|"ε"|eNFA0_1_60801917
eNFA7_0_16037598 -->|"#92;"|eNFA7_1_15054180
eNFA7_11_53977738 -->|"#92;"|eNFA7_12_1269896
eNFA7_15_10120656 -->|"#92;"|eNFA7_16_11429066
eNFA7_19_23977041 -->|"#92;"|eNFA7_20_35752731
eNFA7_23_14466778 -->|"#92;"|eNFA7_24_53339124
eNFA7_27_63092140 -->|"[#32;-Z]"|eNFA7_28_19665615
eNFA7_29_30958352 -->|"["|eNFA7_30_14327361
eNFA7_31_10189720 -->|"#92;"|eNFA7_32_10290070
eNFA7_35_24598620 -->|"]"|eNFA7_36_42772808
eNFA7_37_20060988 -->|"#92;"|eNFA7_38_25501770
eNFA7_41_46331171 -->|"[_-~]"|eNFA7_42_49410957
eNFA3_5_49159881 -.->|"ε"|eNFA0_1_60801917
eNFA4_5_321477 -.->|"ε"|eNFA4_6_2893298
eNFA4_5_321477 -.->|"ε
AcceptPrevious '[^'"|eNFA8_9_2313746
eNFA5_6_26039685 -.->|"ε"|eNFA5_4_28839721
eNFA5_6_26039685 -.->|"ε"|eNFA5_8_33030575
eNFA5_6_26039685 -.->|"ε"|eNFA5_7_58230900
eNFA6_4_65242240 -->|"[#92;t#92;r#32;-~]"|eNFA6_4_65242240
eNFA6_4_65242240 -.->|"ε
ExtendToken 'inlineComment'"|eNFA6_6_50130116
eNFA1_5_28611270 -->|"[0-9]"|eNFA1_6_2788537
eNFA7_1_15054180 -.->|"ε"|eNFA7_2_25096836
eNFA7_12_1269896 -.->|"ε"|eNFA7_13_24544935
eNFA7_16_11429066 -.->|"ε"|eNFA7_17_19577827
eNFA7_20_35752731 -.->|"ε"|eNFA7_21_41982722
eNFA7_24_53339124 -.->|"ε"|eNFA7_25_42300179
eNFA7_28_19665615 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_30_14327361 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_32_10290070 -.->|"ε"|eNFA7_33_36326405
eNFA7_36_42772808 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_38_25501770 -.->|"ε"|eNFA7_39_56757654
eNFA7_42_49410957 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA4_6_2893298 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_28629874
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_0_53195707
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_11_20823715
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_15_8999315
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_19_13884972
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_23_57855887
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_27_50940942
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_29_55815296
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_31_32575624
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_35_24745166
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_37_21379907
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_39_58201440
eNFA8_9_2313746 -.->|"ε
BeginToken 'firstItem2'"|eNFA8_43_54050919
eNFA5_4_28839721 -->|"[^*]"|eNFA5_5_37524543
eNFA5_8_33030575 -->|"[*]"|eNFA5_9_63507614
eNFA5_7_58230900 -.->|"ε"|eNFA5_6_26039685
eNFA5_7_58230900 -.->|"ε"|eNFA5_12_19082474
eNFA6_6_50130116 -.->|"ε"|eNFA6_7_3151905
eNFA1_6_2788537 -->|"[0-9]"|eNFA1_7_59043505
eNFA7_2_25096836 -->|"u"|eNFA7_3_61629497
eNFA7_13_24544935 -->|"t"|eNFA7_14_42045429
eNFA7_17_19577827 -->|"n"|eNFA7_18_42864547
eNFA7_21_41982722 -->|"r"|eNFA7_22_50236607
eNFA7_25_42300179 -->|"-"|eNFA7_26_49476282
eNFA7_10_61837391 -.->|"ε"|eNFA7_43_7713623
eNFA7_33_36326405 -->|"#92;"|eNFA7_34_42633357
eNFA7_39_56757654 -->|"^"|eNFA7_40_48155897
eNFA4_7_28629874 -.->|"ε"|eNFA0_1_60801917
eNFA8_0_53195707 -->|"#92;"|eNFA8_1_25933367
eNFA8_11_20823715 -->|"#92;"|eNFA8_12_32073719
eNFA8_15_8999315 -->|"#92;"|eNFA8_16_20228022
eNFA8_19_13884972 -->|"#92;"|eNFA8_20_47834478
eNFA8_23_57855887 -->|"#92;"|eNFA8_24_27857118
eNFA8_27_50940942 -->|"[#32;-Z]"|eNFA8_28_10216818
eNFA8_29_55815296 -->|"["|eNFA8_30_16696223
eNFA8_31_32575624 -->|"#92;"|eNFA8_32_49387472
eNFA8_35_24745166 -->|"]"|eNFA8_36_24842503
eNFA8_37_21379907 -->|"^"|eNFA8_38_22255938
eNFA8_39_58201440 -->|"#92;"|eNFA8_40_41834070
eNFA8_43_54050919 -->|"[_-~]"|eNFA8_44_66085716
eNFA5_5_37524543 -.->|"ε"|eNFA5_7_58230900
eNFA5_9_63507614 -.->|"ε"|eNFA5_10_33116486
eNFA5_12_19082474 -->|"*"|eNFA5_13_29612923
eNFA6_7_3151905 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA6_8_34007596
eNFA1_7_59043505 -->|"[0-9]"|eNFA1_8_59483605
eNFA7_3_61629497 -.->|"ε"|eNFA7_4_65189719
eNFA7_14_42045429 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_18_42864547 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_22_50236607 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_26_49476282 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_43_7713623 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_8313609
eNFA7_34_42633357 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA7_40_48155897 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA8_1_25933367 -.->|"ε"|eNFA8_2_8960839
eNFA8_12_32073719 -.->|"ε"|eNFA8_13_13538688
eNFA8_16_20228022 -.->|"ε"|eNFA8_17_54739329
eNFA8_20_47834478 -.->|"ε"|eNFA8_21_22891915
eNFA8_24_27857118 -.->|"ε"|eNFA8_25_4700647
eNFA8_28_10216818 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_30_16696223 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_32_49387472 -.->|"ε"|eNFA8_33_37982554
eNFA8_36_24842503 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_38_22255938 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_40_41834070 -.->|"ε"|eNFA8_41_40430446
eNFA8_44_66085716 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA5_10_33116486 -->|"[^/]"|eNFA5_11_2176568
eNFA5_13_29612923 -.->|"ε"|eNFA5_14_53640668
eNFA6_8_34007596 -.->|"ε"|eNFA0_1_60801917
eNFA1_8_59483605 -.->|"ε
ExtendToken 'char'"|eNFA1_10_45749167
eNFA7_4_65189719 -->|"[0-9]"|eNFA7_5_46688182
eNFA7_44_8313609 -.->|"ε"|eNFA0_1_60801917
eNFA8_2_8960839 -->|"u"|eNFA8_3_23646388
eNFA8_13_13538688 -->|"t"|eNFA8_14_57900534
eNFA8_17_54739329 -->|"n"|eNFA8_18_51342761
eNFA8_21_22891915 -->|"r"|eNFA8_22_59431671
eNFA8_25_4700647 -->|"-"|eNFA8_26_65122991
eNFA8_10_16048282 -.->|"ε"|eNFA8_45_42513748
eNFA8_33_37982554 -->|"#92;"|eNFA8_34_49236012
eNFA8_41_40430446 -->|"^"|eNFA8_42_40470925
eNFA5_11_2176568 -.->|"ε"|eNFA5_7_58230900
eNFA5_14_53640668 -->|"/"|eNFA5_15_53389951
eNFA7_5_46688182 -->|"[0-9]"|eNFA7_6_36309279
eNFA8_3_23646388 -.->|"ε"|eNFA8_4_58348056
eNFA8_14_57900534 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_18_51342761 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_22_59431671 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_26_65122991 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_45_42513748 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_56919532
eNFA8_34_49236012 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA8_42_40470925 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282
eNFA5_15_53389951 -.->|"ε
ExtendToken 'blockComment'"|eNFA5_17_10747513
eNFA7_6_36309279 -->|"[0-9]"|eNFA7_7_37866150
eNFA8_4_58348056 -->|"[0-9]"|eNFA8_5_5251037
eNFA8_46_56919532 -.->|"ε"|eNFA0_1_60801917
eNFA5_17_10747513 -.->|"ε"|eNFA5_18_29618759
eNFA7_7_37866150 -->|"[0-9]"|eNFA7_8_30749896
eNFA8_5_5251037 -->|"[0-9]"|eNFA8_6_22680839
eNFA5_18_29618759 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA5_19_42084359
eNFA7_8_30749896 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_61837391
eNFA8_6_22680839 -->|"[0-9]"|eNFA8_7_25208690
eNFA5_19_42084359 -.->|"ε"|eNFA0_1_60801917
eNFA8_7_25208690 -->|"[0-9]"|eNFA8_8_28694013
eNFA8_8_28694013 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_16048282

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
eNFA0_0_47079412[["εNFA0-0 wholeStart"]]
class eNFA0_0_47079412 c1000;
eNFA1_9_55336012[["εNFA1-9 regex start"]]
class eNFA1_9_55336012 c1000;
eNFA2_2_21061526[["εNFA2-2 regex start"]]
class eNFA2_2_21061526 c1000;
eNFA3_2_28262061[["εNFA3-2 regex start"]]
class eNFA3_2_28262061 c1000;
eNFA4_4_53031964[["εNFA4-4 regex start"]]
class eNFA4_4_53031964 c1000;
eNFA5_16_7525633[["εNFA5-16 regex start"]]
class eNFA5_16_7525633 c1000;
eNFA6_5_621837[["εNFA6-5 regex start"]]
class eNFA6_5_621837 c1000;
eNFA1_0_50368838[["εNFA1-0 char{1, 1}"]]
class eNFA1_0_50368838 c1000;
eNFA1_11_5596537[["εNFA1-11 char{1, 1}"]]
class eNFA1_11_5596537 c1000;
eNFA1_15_50666366[["εNFA1-15 char{1, 1}"]]
class eNFA1_15_50666366 c1000;
eNFA1_19_53344112[["εNFA1-19 char{1, 1}"]]
class eNFA1_19_53344112 c1000;
eNFA1_23_10334967[["εNFA1-23 char{1, 1}"]]
class eNFA1_23_10334967 c1000;
eNFA1_27_25905843[["εNFA1-27 scope{1, 1}"]]
class eNFA1_27_25905843 c1000;
eNFA1_29_31825997[["εNFA1-29 char{1, 1}"]]
class eNFA1_29_31825997 c1000;
eNFA1_33_17998518[["εNFA1-33 char{1, 1}"]]
class eNFA1_33_17998518 c1000;
eNFA1_37_27768935[["εNFA1-37 char{1, 1}"]]
class eNFA1_37_27768935 c1000;
eNFA1_41_48593825[["εNFA1-41 char{1, 1}"]]
class eNFA1_41_48593825 c1000;
eNFA1_43_34691245[["εNFA1-43 char{1, 1}"]]
class eNFA1_43_34691245 c1000;
eNFA1_47_43785757[["εNFA1-47 scope{1, 1}"]]
class eNFA1_47_43785757 c1000;
eNFA2_0_37978409[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_37978409 c1000;
eNFA3_0_56352326[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_56352326 c1000;
eNFA4_0_24881480[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_24881480 c1000;
eNFA5_0_2134014[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_2134014 c1000;
eNFA6_0_42625947[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_42625947 c1000;
eNFA1_1_26207835[["εNFA1-1 char[1]"]]
eNFA1_12_34543924[["εNFA1-12 char[1]"]]
eNFA1_16_42459867[["εNFA1-16 char[1]"]]
eNFA1_20_46594488[["εNFA1-20 char[1]"]]
eNFA1_24_16697212[["εNFA1-24 char[1]"]]
eNFA1_28_42564588[\"εNFA1-28 scope[1]
AcceptToken 'char'"/]
class eNFA1_28_42564588 c0111;
eNFA1_30_16057184[["εNFA1-30 char[1]"]]
eNFA1_34_10296933[["εNFA1-34 char[1]"]]
eNFA1_38_25563541[["εNFA1-38 char[1]"]]
eNFA1_42_12953056[\"εNFA1-42 char[1]
AcceptToken 'char'"/]
class eNFA1_42_12953056 c0111;
eNFA1_44_28745279[["εNFA1-44 char[1]"]]
eNFA1_48_25179629[\"εNFA1-48 scope[1]
AcceptToken 'char'"/]
class eNFA1_48_25179629 c0111;
eNFA2_1_6261369[\"εNFA2-1 char[1]
AcceptToken '['"/]
class eNFA2_1_6261369 c1111;
eNFA3_1_37408889[\"εNFA3-1 char[1]
AcceptToken ']'"/]
class eNFA3_1_37408889 c0111;
eNFA4_1_13621136[["εNFA4-1 char[1]"]]
eNFA5_1_29570261[["εNFA5-1 char[1]"]]
eNFA6_1_46380963[["εNFA6-1 char[1]"]]
eNFA1_2_14433768[["εNFA1-2 char{1, 1}"]]
eNFA1_3_28284541[["εNFA1-3 char[1]"]]
eNFA1_13_57380926[["εNFA1-13 char{1, 1}"]]
eNFA1_14_30408220[\"εNFA1-14 char[1]
AcceptToken 'char'"/]
class eNFA1_14_30408220 c0111;
eNFA1_17_46666290[["εNFA1-17 char{1, 1}"]]
eNFA1_18_5238527[\"εNFA1-18 char[1]
AcceptToken 'char'"/]
class eNFA1_18_5238527 c0111;
eNFA1_21_17343428[["εNFA1-21 char{1, 1}"]]
eNFA1_22_47146745[\"εNFA1-22 char[1]
AcceptToken 'char'"/]
class eNFA1_22_47146745 c0111;
eNFA1_25_21873125[["εNFA1-25 char{1, 1}"]]
eNFA1_26_21667523[\"εNFA1-26 char[1]
AcceptToken 'char'"/]
class eNFA1_26_21667523 c0111;
eNFA1_10_49468641[\"εNFA1-10 regex end
AcceptToken 'char'"/]
class eNFA1_10_49468641 c0111;
eNFA1_49_56415606[\"εNFA1-49 post-regex start
AcceptToken 'char'"/]
class eNFA1_49_56415606 c0011;
eNFA1_50_53868469[\"εNFA1-50 post-regex end"/]
class eNFA1_50_53868469 c0011;
eNFA0_1_35811547[\"εNFA0-1 wholeEnd"/]
eNFA1_31_62640398[["εNFA1-31 char{1, 1}"]]
eNFA1_32_60789982[\"εNFA1-32 char[1]
AcceptToken 'char'"/]
class eNFA1_32_60789982 c0111;
eNFA1_35_26892672[["εNFA1-35 char{1, 1}"]]
eNFA1_36_10238932[\"εNFA1-36 char[1]
AcceptToken 'char'"/]
class eNFA1_36_10238932 c0111;
eNFA1_39_40707460[["εNFA1-39 char{1, 1}"]]
eNFA1_40_25041524[\"εNFA1-40 char[1]
AcceptToken 'char'"/]
class eNFA1_40_25041524 c0111;
eNFA1_45_30822828[["εNFA1-45 char{1, 1}"]]
eNFA1_46_24047129[\"εNFA1-46 char[1]
AcceptToken 'char'"/]
class eNFA1_46_24047129 c0111;
eNFA2_3_35088220[\"εNFA2-3 regex end
AcceptToken '['"/]
class eNFA2_3_35088220 c1111;
eNFA2_4_23573535[\"εNFA2-4 post-regex start
AcceptToken '['"/]
class eNFA2_4_23573535 c0011;
eNFA7_9_47358524[\"εNFA7-9 regex start"/]
class eNFA7_9_47358524 c1000;
eNFA2_5_56174843[\"εNFA2-5 post-regex end"/]
class eNFA2_5_56174843 c0011;
eNFA7_0_1660410[\"εNFA7-0 char{1, 1}"/]
class eNFA7_0_1660410 c1000;
eNFA7_11_15097570[\"εNFA7-11 char{1, 1}"/]
class eNFA7_11_15097570 c1000;
eNFA7_15_14943697[\"εNFA7-15 char{1, 1}"/]
class eNFA7_15_14943697 c1000;
eNFA7_19_275553[\"εNFA7-19 char{1, 1}"/]
class eNFA7_19_275553 c1000;
eNFA7_23_2479977[\"εNFA7-23 char{1, 1}"/]
class eNFA7_23_2479977 c1000;
eNFA7_27_22319795[\"εNFA7-27 scope{1, 1}"/]
class eNFA7_27_22319795 c1000;
eNFA7_29_66660433[\"εNFA7-29 char{1, 1}"/]
class eNFA7_29_66660433 c1000;
eNFA7_31_63072986[\"εNFA7-31 char{1, 1}"/]
class eNFA7_31_63072986 c1000;
eNFA7_35_30785969[\"εNFA7-35 char{1, 1}"/]
class eNFA7_35_30785969 c1000;
eNFA7_37_8638270[\"εNFA7-37 char{1, 1}"/]
class eNFA7_37_8638270 c1000;
eNFA7_41_10635570[\"εNFA7-41 scope{1, 1}"/]
class eNFA7_41_10635570 c1000;
eNFA7_1_65870497[["εNFA7-1 char[1]"]]
eNFA7_12_55963561[["εNFA7-12 char[1]"]]
eNFA7_16_33910007[["εNFA7-16 char[1]"]]
eNFA7_20_36754611[["εNFA7-20 char[1]"]]
eNFA7_24_62356046[["εNFA7-24 char[1]"]]
eNFA7_28_33862429[\"εNFA7-28 scope[1]
AcceptToken 'firstItem1'"/]
class eNFA7_28_33862429 c0111;
eNFA7_30_45157297[\"εNFA7-30 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_30_45157297 c0111;
eNFA7_32_24333505[["εNFA7-32 char[1]"]]
eNFA7_36_58502189[\"εNFA7-36 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_36_58502189 c0111;
eNFA7_38_17674957[["εNFA7-38 char[1]"]]
eNFA7_42_41056841[\"εNFA7-42 scope[1]
AcceptToken 'firstItem1'"/]
class eNFA7_42_41056841 c0111;
eNFA3_3_1135683[\"εNFA3-3 regex end
AcceptToken ']'"/]
class eNFA3_3_1135683 c0111;
eNFA3_4_10221149[\"εNFA3-4 post-regex start
AcceptToken ']'"/]
class eNFA3_4_10221149 c0011;
eNFA3_5_28189346[\"εNFA3-5 post-regex end"/]
class eNFA3_5_28189346 c0011;
eNFA4_2_55481367[["εNFA4-2 char{1, 1}"]]
eNFA4_3_22606734[\"εNFA4-3 char[1]
AcceptToken '[^'"/]
class eNFA4_3_22606734 c1111;
eNFA5_2_62795050[["εNFA5-2 char{1, 1}"]]
eNFA5_3_34697616[["εNFA5-3 char[1]"]]
eNFA6_2_14775484[["εNFA6-2 char{1, 1}"]]
eNFA6_3_22404047[\"εNFA6-3 char[1]
AcceptToken 'inlineComment'"/]
class eNFA6_3_22404047 c0111;
eNFA1_4_53234283[["εNFA1-4 scope{4, 4}"]]
eNFA1_5_49322849[["εNFA1-5 scope[1]"]]
eNFA7_2_9346499[["εNFA7-2 char{1, 1}"]]
eNFA7_3_35602929[["εNFA7-3 char[1]"]]
eNFA7_13_24856892[["εNFA7-13 char{1, 1}"]]
eNFA7_14_49836563[\"εNFA7-14 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_14_49836563 c0111;
eNFA7_17_22385437[["εNFA7-17 char{1, 1}"]]
eNFA7_18_45875888[\"εNFA7-18 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_18_45875888 c0111;
eNFA7_21_142347[["εNFA7-21 char{1, 1}"]]
eNFA7_22_10229816[\"εNFA7-22 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_22_10229816 c0111;
eNFA7_25_1281126[["εNFA7-25 char{1, 1}"]]
eNFA7_26_24959482[\"εNFA7-26 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_26_24959482 c0111;
eNFA7_10_3762492[\"εNFA7-10 regex end
AcceptToken 'firstItem1'"/]
class eNFA7_10_3762492 c0111;
eNFA7_43_30149715[\"εNFA7-43 post-regex start
AcceptToken 'firstItem1'"/]
class eNFA7_43_30149715 c0011;
eNFA7_44_17540457[\"εNFA7-44 post-regex end"/]
class eNFA7_44_17540457 c0011;
eNFA7_33_11530135[["εNFA7-33 char{1, 1}"]]
eNFA7_34_23308753[\"εNFA7-34 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_34_23308753 c0111;
eNFA7_39_36662351[["εNFA7-39 char{1, 1}"]]
eNFA7_40_8452189[\"εNFA7-40 char[1]
AcceptToken 'firstItem1'"/]
class eNFA7_40_8452189 c0111;
eNFA4_5_52377526[\"εNFA4-5 regex end
AcceptToken '[^'"/]
class eNFA4_5_52377526 c1111;
eNFA4_6_14721181[\"εNFA4-6 post-regex start
AcceptToken '[^'"/]
class eNFA4_6_14721181 c0011;
eNFA8_9_1635686[\"εNFA8-9 regex start"/]
class eNFA8_9_1635686 c1000;
eNFA4_7_17794566[\"εNFA4-7 post-regex end"/]
class eNFA4_7_17794566 c0011;
eNFA8_0_37269850[\"εNFA8-0 char{1, 1}"/]
class eNFA8_0_37269850 c1000;
eNFA8_11_33967256[\"εNFA8-11 char{1, 1}"/]
class eNFA8_11_33967256 c1000;
eNFA8_15_66993202[\"εNFA8-15 char{1, 1}"/]
class eNFA8_15_66993202 c1000;
eNFA8_19_66067912[\"εNFA8-19 char{1, 1}"/]
class eNFA8_19_66067912 c1000;
eNFA8_23_57740301[\"εNFA8-23 char{1, 1}"/]
class eNFA8_23_57740301 c1000;
eNFA8_27_49900666[\"εNFA8-27 scope{1, 1}"/]
class eNFA8_27_49900666 c1000;
eNFA8_29_46452817[\"εNFA8-29 char{1, 1}"/]
class eNFA8_29_46452817 c1000;
eNFA8_31_15422169[\"εNFA8-31 char{1, 1}"/]
class eNFA8_31_15422169 c1000;
eNFA8_35_4581796[\"εNFA8-35 char{1, 1}"/]
class eNFA8_35_4581796 c1000;
eNFA8_37_41236172[\"εNFA8-37 char{1, 1}"/]
class eNFA8_37_41236172 c1000;
eNFA8_39_35581233[\"εNFA8-39 char{1, 1}"/]
class eNFA8_39_35581233 c1000;
eNFA8_43_51795644[\"εNFA8-43 scope{1, 1}"/]
class eNFA8_43_51795644 c1000;
eNFA8_1_16860416[["εNFA8-1 char[1]"]]
eNFA8_12_17526019[["εNFA8-12 char[1]"]]
eNFA8_16_23516450[["εNFA8-16 char[1]"]]
eNFA8_20_10321460[["εNFA8-20 char[1]"]]
eNFA8_24_25784284[["εNFA8-24 char[1]"]]
eNFA8_28_4220283[\"εNFA8-28 scope[1]
AcceptToken 'firstItem2'"/]
class eNFA8_28_4220283 c0111;
eNFA8_30_42305831[\"εNFA8-30 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_30_42305831 c0111;
eNFA8_32_30731970[["εNFA8-32 char[1]"]]
eNFA8_36_6298672[\"εNFA8-36 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_36_6298672 c0111;
eNFA8_38_56688054[\"εNFA8-38 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_38_56688054 c0111;
eNFA8_40_8152279[["εNFA8-40 char[1]"]]
eNFA8_44_28329695[\"εNFA8-44 scope[1]
AcceptToken 'firstItem2'"/]
class eNFA8_44_28329695 c0111;
eNFA5_6_65381771[["εNFA5-6 regex start"]]
eNFA5_4_61432121[["εNFA5-4 scope{1, 1}"]]
eNFA5_8_51565033[["εNFA5-8 scope{1, 1}"]]
eNFA5_7_16018178[["εNFA5-7 regex end"]]
eNFA5_5_40962311[["εNFA5-5 scope[1]"]]
eNFA5_9_17009632[["εNFA5-9 scope[1]"]]
eNFA5_12_43843091[["εNFA5-12 char{1, 1}"]]
eNFA5_13_50514376[["εNFA5-13 char[1]"]]
eNFA6_4_9945879[\"εNFA6-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class eNFA6_4_9945879 c0111;
eNFA6_6_309837[\"εNFA6-6 regex end
AcceptToken 'inlineComment'"/]
class eNFA6_6_309837 c0111;
eNFA6_7_48089211[\"εNFA6-7 post-regex start
AcceptToken 'inlineComment'"/]
class eNFA6_7_48089211 c0011;
eNFA6_8_13003964[\"εNFA6-8 post-regex end"/]
class eNFA6_8_13003964 c0011;
eNFA1_6_11930629[["εNFA1-6 scope[2]"]]
eNFA7_4_51990912[["εNFA7-4 scope{4, 4}"]]
eNFA7_5_41252464[["εNFA7-5 scope[1]"]]
eNFA8_2_65265032[["εNFA8-2 char{1, 1}"]]
eNFA8_3_51976202[["εNFA8-3 char[1]"]]
eNFA8_13_6261652[["εNFA8-13 char{1, 1}"]]
eNFA8_14_55370462[\"εNFA8-14 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_14_55370462 c0111;
eNFA8_17_56354875[["εNFA8-17 char{1, 1}"]]
eNFA8_18_28572113[\"εNFA8-18 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_18_28572113 c0111;
eNFA8_21_37431827[["εNFA8-21 char{1, 1}"]]
eNFA8_22_55822426[\"εNFA8-22 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_22_55822426 c0111;
eNFA8_25_1342126[["εNFA8-25 char{1, 1}"]]
eNFA8_26_32639786[\"εNFA8-26 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_26_32639786 c0111;
eNFA8_10_45208163[\"εNFA8-10 regex end
AcceptToken 'firstItem2'"/]
class eNFA8_10_45208163 c0111;
eNFA8_45_2911981[\"εNFA8-45 post-regex start
AcceptToken 'firstItem2'"/]
class eNFA8_45_2911981 c0011;
eNFA8_46_47259335[\"εNFA8-46 post-regex end"/]
class eNFA8_46_47259335 c0011;
eNFA8_33_12079142[["εNFA8-33 char{1, 1}"]]
eNFA8_34_25322618[\"εNFA8-34 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_34_25322618 c0111;
eNFA8_41_41603419[["εNFA8-41 char{1, 1}"]]
eNFA8_42_26576971[\"εNFA8-42 char[1]
AcceptToken 'firstItem2'"/]
class eNFA8_42_26576971 c0111;
eNFA5_10_18868961[["εNFA5-10 scope{1, 1}"]]
eNFA5_11_11490904[["εNFA5-11 scope[1]"]]
eNFA5_14_64805763[["εNFA5-14 char{1, 1}"]]
eNFA5_15_19206131[\"εNFA5-15 char[1]
AcceptToken 'blockComment'"/]
class eNFA5_15_19206131 c0111;
eNFA1_7_8970000[["εNFA1-7 scope[3]"]]
eNFA7_6_11717596[["εNFA7-6 scope[2]"]]
eNFA8_4_65132640[["εNFA8-4 scope{4, 4}"]]
eNFA8_5_35727861[["εNFA8-5 scope[1]"]]
eNFA5_17_38637452[\"εNFA5-17 regex end
AcceptToken 'blockComment'"/]
class eNFA5_17_38637452 c0111;
eNFA5_18_12192756[\"εNFA5-18 post-regex start
AcceptToken 'blockComment'"/]
class eNFA5_18_12192756 c0011;
eNFA5_19_25551623[\"εNFA5-19 post-regex end"/]
class eNFA5_19_25551623 c0011;
eNFA1_8_49926818[\"εNFA1-8 scope[4]
AcceptToken 'char'"/]
class eNFA1_8_49926818 c0111;
eNFA7_7_61525703[["εNFA7-7 scope[3]"]]
eNFA8_6_39499626[["εNFA8-6 scope[2]"]]
eNFA7_8_2800965[\"εNFA7-8 scope[4]
AcceptToken 'firstItem1'"/]
class eNFA7_8_2800965 c0111;
eNFA8_7_38886454[["εNFA8-7 scope[3]"]]
eNFA8_8_28638022[\"εNFA8-8 scope[4]
AcceptToken 'firstItem2'"/]
class eNFA8_8_28638022 c0111;
eNFA0_0_47079412 -.->|"ε"|eNFA1_9_55336012
eNFA0_0_47079412 -.->|"ε"|eNFA2_2_21061526
eNFA0_0_47079412 -.->|"ε"|eNFA3_2_28262061
eNFA0_0_47079412 -.->|"ε"|eNFA4_4_53031964
eNFA0_0_47079412 -.->|"ε"|eNFA5_16_7525633
eNFA0_0_47079412 -.->|"ε"|eNFA6_5_621837
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_0_50368838
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_11_5596537
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_15_50666366
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_19_53344112
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_23_10334967
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_27_25905843
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_29_31825997
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_33_17998518
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_37_27768935
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_41_48593825
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_43_34691245
eNFA0_0_47079412 -.->|"ε
BeginToken 'char'"|eNFA1_47_43785757
eNFA0_0_47079412 -.->|"ε
BeginToken '['"|eNFA2_0_37978409
eNFA0_0_47079412 -.->|"ε
BeginToken ']'"|eNFA3_0_56352326
eNFA0_0_47079412 -.->|"ε
BeginToken '[^'"|eNFA4_0_24881480
eNFA0_0_47079412 -.->|"ε
BeginToken 'blockComment'"|eNFA5_0_2134014
eNFA0_0_47079412 -.->|"ε
BeginToken 'inlineComment'"|eNFA6_0_42625947
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_1_26207835
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_12_34543924
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_16_42459867
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_20_46594488
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_24_16697212
eNFA0_0_47079412 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_42564588
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_30_16057184
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_34_10296933
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_38_25563541
eNFA0_0_47079412 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_12953056
eNFA0_0_47079412 -->|"#92;
BeginToken 'char'"|eNFA1_44_28745279
eNFA0_0_47079412 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_25179629
eNFA0_0_47079412 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_6261369
eNFA0_0_47079412 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_37408889
eNFA0_0_47079412 -->|"[
BeginToken '[^'"|eNFA4_1_13621136
eNFA0_0_47079412 -->|"/
BeginToken 'blockComment'"|eNFA5_1_29570261
eNFA0_0_47079412 -->|"/
BeginToken 'inlineComment'"|eNFA6_1_46380963
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_0_50368838
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_11_5596537
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_15_50666366
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_19_53344112
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_23_10334967
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_27_25905843
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_29_31825997
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_33_17998518
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_37_27768935
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_41_48593825
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_43_34691245
eNFA1_9_55336012 -.->|"ε
BeginToken 'char'"|eNFA1_47_43785757
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_1_26207835
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_12_34543924
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_16_42459867
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_20_46594488
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_24_16697212
eNFA1_9_55336012 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_42564588
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_30_16057184
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_34_10296933
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_38_25563541
eNFA1_9_55336012 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_12953056
eNFA1_9_55336012 -->|"#92;
BeginToken 'char'"|eNFA1_44_28745279
eNFA1_9_55336012 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_25179629
eNFA2_2_21061526 -.->|"ε
BeginToken '['"|eNFA2_0_37978409
eNFA2_2_21061526 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_6261369
eNFA3_2_28262061 -.->|"ε
BeginToken ']'"|eNFA3_0_56352326
eNFA3_2_28262061 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_37408889
eNFA4_4_53031964 -.->|"ε
BeginToken '[^'"|eNFA4_0_24881480
eNFA4_4_53031964 -->|"[
BeginToken '[^'"|eNFA4_1_13621136
eNFA5_16_7525633 -.->|"ε
BeginToken 'blockComment'"|eNFA5_0_2134014
eNFA5_16_7525633 -->|"/
BeginToken 'blockComment'"|eNFA5_1_29570261
eNFA6_5_621837 -.->|"ε
BeginToken 'inlineComment'"|eNFA6_0_42625947
eNFA6_5_621837 -->|"/
BeginToken 'inlineComment'"|eNFA6_1_46380963
eNFA1_0_50368838 -->|"#92;
BeginToken 'char'"|eNFA1_1_26207835
eNFA1_11_5596537 -->|"#92;
BeginToken 'char'"|eNFA1_12_34543924
eNFA1_15_50666366 -->|"#92;
BeginToken 'char'"|eNFA1_16_42459867
eNFA1_19_53344112 -->|"#92;
BeginToken 'char'"|eNFA1_20_46594488
eNFA1_23_10334967 -->|"#92;
BeginToken 'char'"|eNFA1_24_16697212
eNFA1_27_25905843 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_28_42564588
eNFA1_29_31825997 -->|"#92;
BeginToken 'char'"|eNFA1_30_16057184
eNFA1_33_17998518 -->|"#92;
BeginToken 'char'"|eNFA1_34_10296933
eNFA1_37_27768935 -->|"#92;
BeginToken 'char'"|eNFA1_38_25563541
eNFA1_41_48593825 -->|"^
BeginToken 'char'
ExtendToken 'char'"|eNFA1_42_12953056
eNFA1_43_34691245 -->|"#92;
BeginToken 'char'"|eNFA1_44_28745279
eNFA1_47_43785757 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|eNFA1_48_25179629
eNFA2_0_37978409 -->|"[
BeginToken '['
ExtendToken '['"|eNFA2_1_6261369
eNFA3_0_56352326 -->|"]
BeginToken ']'
ExtendToken ']'"|eNFA3_1_37408889
eNFA4_0_24881480 -->|"[
BeginToken '[^'"|eNFA4_1_13621136
eNFA5_0_2134014 -->|"/
BeginToken 'blockComment'"|eNFA5_1_29570261
eNFA6_0_42625947 -->|"/
BeginToken 'inlineComment'"|eNFA6_1_46380963
eNFA1_1_26207835 -.->|"ε"|eNFA1_2_14433768
eNFA1_1_26207835 -->|"u"|eNFA1_3_28284541
eNFA1_12_34543924 -.->|"ε"|eNFA1_13_57380926
eNFA1_12_34543924 -->|"t
ExtendToken 'char'"|eNFA1_14_30408220
eNFA1_16_42459867 -.->|"ε"|eNFA1_17_46666290
eNFA1_16_42459867 -->|"n
ExtendToken 'char'"|eNFA1_18_5238527
eNFA1_20_46594488 -.->|"ε"|eNFA1_21_17343428
eNFA1_20_46594488 -->|"r
ExtendToken 'char'"|eNFA1_22_47146745
eNFA1_24_16697212 -.->|"ε"|eNFA1_25_21873125
eNFA1_24_16697212 -->|"-
ExtendToken 'char'"|eNFA1_26_21667523
eNFA1_28_42564588 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_28_42564588 -.->|"ε"|eNFA1_49_56415606
eNFA1_28_42564588 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_28_42564588 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_30_16057184 -.->|"ε"|eNFA1_31_62640398
eNFA1_30_16057184 -->|"[
ExtendToken 'char'"|eNFA1_32_60789982
eNFA1_34_10296933 -.->|"ε"|eNFA1_35_26892672
eNFA1_34_10296933 -->|"#92;
ExtendToken 'char'"|eNFA1_36_10238932
eNFA1_38_25563541 -.->|"ε"|eNFA1_39_40707460
eNFA1_38_25563541 -->|"]
ExtendToken 'char'"|eNFA1_40_25041524
eNFA1_42_12953056 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_42_12953056 -.->|"ε"|eNFA1_49_56415606
eNFA1_42_12953056 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_42_12953056 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_44_28745279 -.->|"ε"|eNFA1_45_30822828
eNFA1_44_28745279 -->|"^
ExtendToken 'char'"|eNFA1_46_24047129
eNFA1_48_25179629 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_48_25179629 -.->|"ε"|eNFA1_49_56415606
eNFA1_48_25179629 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_48_25179629 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA2_1_6261369 -.->|"ε
ExtendToken '['"|eNFA2_3_35088220
eNFA2_1_6261369 -.->|"ε"|eNFA2_4_23573535
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['"|eNFA7_9_47358524
eNFA2_1_6261369 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_56174843
eNFA2_1_6261369 -.->|"ε
CheckToken '['"|eNFA0_1_35811547
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_0_1660410
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_11_15097570
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_15_14943697
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_19_275553
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_23_2479977
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_27_22319795
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_29_66660433
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_31_63072986
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_35_30785969
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_37_8638270
eNFA2_1_6261369 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_41_10635570
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_1_65870497
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_12_55963561
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_16_33910007
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_20_36754611
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_24_62356046
eNFA2_1_6261369 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_28_33862429
eNFA2_1_6261369 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_30_45157297
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_32_24333505
eNFA2_1_6261369 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_36_58502189
eNFA2_1_6261369 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_38_17674957
eNFA2_1_6261369 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_42_41056841
eNFA3_1_37408889 -.->|"ε
ExtendToken ']'"|eNFA3_3_1135683
eNFA3_1_37408889 -.->|"ε"|eNFA3_4_10221149
eNFA3_1_37408889 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_28189346
eNFA3_1_37408889 -.->|"ε
CheckToken ']'"|eNFA0_1_35811547
eNFA4_1_13621136 -.->|"ε"|eNFA4_2_55481367
eNFA4_1_13621136 -->|"^
ExtendToken '[^'"|eNFA4_3_22606734
eNFA5_1_29570261 -.->|"ε"|eNFA5_2_62795050
eNFA5_1_29570261 -->|"*"|eNFA5_3_34697616
eNFA6_1_46380963 -.->|"ε"|eNFA6_2_14775484
eNFA6_1_46380963 -->|"/
ExtendToken 'inlineComment'"|eNFA6_3_22404047
eNFA1_2_14433768 -->|"u"|eNFA1_3_28284541
eNFA1_3_28284541 -.->|"ε"|eNFA1_4_53234283
eNFA1_3_28284541 -->|"[0-9]"|eNFA1_5_49322849
eNFA1_13_57380926 -->|"t
ExtendToken 'char'"|eNFA1_14_30408220
eNFA1_14_30408220 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_14_30408220 -.->|"ε"|eNFA1_49_56415606
eNFA1_14_30408220 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_14_30408220 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_17_46666290 -->|"n
ExtendToken 'char'"|eNFA1_18_5238527
eNFA1_18_5238527 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_18_5238527 -.->|"ε"|eNFA1_49_56415606
eNFA1_18_5238527 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_18_5238527 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_21_17343428 -->|"r
ExtendToken 'char'"|eNFA1_22_47146745
eNFA1_22_47146745 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_22_47146745 -.->|"ε"|eNFA1_49_56415606
eNFA1_22_47146745 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_22_47146745 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_25_21873125 -->|"-
ExtendToken 'char'"|eNFA1_26_21667523
eNFA1_26_21667523 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_26_21667523 -.->|"ε"|eNFA1_49_56415606
eNFA1_26_21667523 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_26_21667523 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_10_49468641 -.->|"ε"|eNFA1_49_56415606
eNFA1_10_49468641 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_10_49468641 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_49_56415606 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_49_56415606 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_50_53868469 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_31_62640398 -->|"[
ExtendToken 'char'"|eNFA1_32_60789982
eNFA1_32_60789982 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_32_60789982 -.->|"ε"|eNFA1_49_56415606
eNFA1_32_60789982 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_32_60789982 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_35_26892672 -->|"#92;
ExtendToken 'char'"|eNFA1_36_10238932
eNFA1_36_10238932 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_36_10238932 -.->|"ε"|eNFA1_49_56415606
eNFA1_36_10238932 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_36_10238932 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_39_40707460 -->|"]
ExtendToken 'char'"|eNFA1_40_25041524
eNFA1_40_25041524 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_40_25041524 -.->|"ε"|eNFA1_49_56415606
eNFA1_40_25041524 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_40_25041524 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA1_45_30822828 -->|"^
ExtendToken 'char'"|eNFA1_46_24047129
eNFA1_46_24047129 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_46_24047129 -.->|"ε"|eNFA1_49_56415606
eNFA1_46_24047129 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_46_24047129 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA2_3_35088220 -.->|"ε"|eNFA2_4_23573535
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['"|eNFA7_9_47358524
eNFA2_3_35088220 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_56174843
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_0_1660410
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_11_15097570
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_15_14943697
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_19_275553
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_23_2479977
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_27_22319795
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_29_66660433
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_31_63072986
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_35_30785969
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_37_8638270
eNFA2_3_35088220 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_41_10635570
eNFA2_3_35088220 -.->|"ε
CheckToken '['"|eNFA0_1_35811547
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_1_65870497
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_12_55963561
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_16_33910007
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_20_36754611
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_24_62356046
eNFA2_3_35088220 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_28_33862429
eNFA2_3_35088220 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_30_45157297
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_32_24333505
eNFA2_3_35088220 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_36_58502189
eNFA2_3_35088220 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_38_17674957
eNFA2_3_35088220 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_42_41056841
eNFA2_4_23573535 -.->|"ε
CheckToken '['
AcceptToken '['"|eNFA2_5_56174843
eNFA2_4_23573535 -.->|"ε
CheckToken '['"|eNFA0_1_35811547
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_0_1660410
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_11_15097570
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_15_14943697
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_19_275553
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_23_2479977
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_27_22319795
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_29_66660433
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_31_63072986
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_35_30785969
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_37_8638270
eNFA7_9_47358524 -.->|"ε
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_41_10635570
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_1_65870497
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_12_55963561
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_16_33910007
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_20_36754611
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_24_62356046
eNFA7_9_47358524 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_28_33862429
eNFA7_9_47358524 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_30_45157297
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_32_24333505
eNFA7_9_47358524 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_36_58502189
eNFA7_9_47358524 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_38_17674957
eNFA7_9_47358524 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_42_41056841
eNFA2_5_56174843 -.->|"ε
CheckToken '['"|eNFA0_1_35811547
eNFA7_0_1660410 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_1_65870497
eNFA7_11_15097570 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_12_55963561
eNFA7_15_14943697 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_16_33910007
eNFA7_19_275553 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_20_36754611
eNFA7_23_2479977 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_24_62356046
eNFA7_27_22319795 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_28_33862429
eNFA7_29_66660433 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_30_45157297
eNFA7_31_63072986 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_32_24333505
eNFA7_35_30785969 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_36_58502189
eNFA7_37_8638270 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|eNFA7_38_17674957
eNFA7_41_10635570 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|eNFA7_42_41056841
eNFA7_1_65870497 -.->|"ε"|eNFA7_2_9346499
eNFA7_1_65870497 -->|"u"|eNFA7_3_35602929
eNFA7_12_55963561 -.->|"ε"|eNFA7_13_24856892
eNFA7_12_55963561 -->|"t
ExtendToken 'firstItem1'"|eNFA7_14_49836563
eNFA7_16_33910007 -.->|"ε"|eNFA7_17_22385437
eNFA7_16_33910007 -->|"n
ExtendToken 'firstItem1'"|eNFA7_18_45875888
eNFA7_20_36754611 -.->|"ε"|eNFA7_21_142347
eNFA7_20_36754611 -->|"r
ExtendToken 'firstItem1'"|eNFA7_22_10229816
eNFA7_24_62356046 -.->|"ε"|eNFA7_25_1281126
eNFA7_24_62356046 -->|"-
ExtendToken 'firstItem1'"|eNFA7_26_24959482
eNFA7_28_33862429 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_28_33862429 -.->|"ε"|eNFA7_43_30149715
eNFA7_28_33862429 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_28_33862429 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_30_45157297 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_30_45157297 -.->|"ε"|eNFA7_43_30149715
eNFA7_30_45157297 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_30_45157297 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_32_24333505 -.->|"ε"|eNFA7_33_11530135
eNFA7_32_24333505 -->|"#92;
ExtendToken 'firstItem1'"|eNFA7_34_23308753
eNFA7_36_58502189 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_36_58502189 -.->|"ε"|eNFA7_43_30149715
eNFA7_36_58502189 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_36_58502189 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_38_17674957 -.->|"ε"|eNFA7_39_36662351
eNFA7_38_17674957 -->|"^
ExtendToken 'firstItem1'"|eNFA7_40_8452189
eNFA7_42_41056841 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_42_41056841 -.->|"ε"|eNFA7_43_30149715
eNFA7_42_41056841 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_42_41056841 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA3_3_1135683 -.->|"ε"|eNFA3_4_10221149
eNFA3_3_1135683 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_28189346
eNFA3_3_1135683 -.->|"ε
CheckToken ']'"|eNFA0_1_35811547
eNFA3_4_10221149 -.->|"ε
CheckToken ']'
AcceptToken ']'"|eNFA3_5_28189346
eNFA3_4_10221149 -.->|"ε
CheckToken ']'"|eNFA0_1_35811547
eNFA3_5_28189346 -.->|"ε
CheckToken ']'"|eNFA0_1_35811547
eNFA4_2_55481367 -->|"^
ExtendToken '[^'"|eNFA4_3_22606734
eNFA4_3_22606734 -.->|"ε
ExtendToken '[^'"|eNFA4_5_52377526
eNFA4_3_22606734 -.->|"ε"|eNFA4_6_14721181
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'"|eNFA8_9_1635686
eNFA4_3_22606734 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_17794566
eNFA4_3_22606734 -.->|"ε
CheckToken '[^'"|eNFA0_1_35811547
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_0_37269850
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_11_33967256
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_15_66993202
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_19_66067912
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_23_57740301
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_27_49900666
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_29_46452817
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_31_15422169
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_35_4581796
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_37_41236172
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_39_35581233
eNFA4_3_22606734 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_43_51795644
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_1_16860416
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_12_17526019
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_16_23516450
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_20_10321460
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_24_25784284
eNFA4_3_22606734 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_28_4220283
eNFA4_3_22606734 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_30_42305831
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_32_30731970
eNFA4_3_22606734 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_36_6298672
eNFA4_3_22606734 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_38_56688054
eNFA4_3_22606734 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_40_8152279
eNFA4_3_22606734 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_44_28329695
eNFA5_2_62795050 -->|"*"|eNFA5_3_34697616
eNFA5_3_34697616 -.->|"ε"|eNFA5_6_65381771
eNFA5_3_34697616 -.->|"ε"|eNFA5_4_61432121
eNFA5_3_34697616 -.->|"ε"|eNFA5_8_51565033
eNFA5_3_34697616 -.->|"ε"|eNFA5_7_16018178
eNFA5_3_34697616 -->|"[^*]"|eNFA5_5_40962311
eNFA5_3_34697616 -->|"[*]"|eNFA5_9_17009632
eNFA5_3_34697616 -.->|"ε"|eNFA5_12_43843091
eNFA5_3_34697616 -->|"*"|eNFA5_13_50514376
eNFA6_2_14775484 -->|"/
ExtendToken 'inlineComment'"|eNFA6_3_22404047
eNFA6_3_22404047 -.->|"ε
ExtendToken 'inlineComment'"|eNFA6_4_9945879
eNFA6_3_22404047 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA6_4_9945879
eNFA6_3_22404047 -.->|"ε
ExtendToken 'inlineComment'"|eNFA6_6_309837
eNFA6_3_22404047 -.->|"ε"|eNFA6_7_48089211
eNFA6_3_22404047 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA6_8_13003964
eNFA6_3_22404047 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_35811547
eNFA1_4_53234283 -->|"[0-9]"|eNFA1_5_49322849
eNFA1_5_49322849 -->|"[0-9]"|eNFA1_6_11930629
eNFA7_2_9346499 -->|"u"|eNFA7_3_35602929
eNFA7_3_35602929 -.->|"ε"|eNFA7_4_51990912
eNFA7_3_35602929 -->|"[0-9]"|eNFA7_5_41252464
eNFA7_13_24856892 -->|"t
ExtendToken 'firstItem1'"|eNFA7_14_49836563
eNFA7_14_49836563 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_14_49836563 -.->|"ε"|eNFA7_43_30149715
eNFA7_14_49836563 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_14_49836563 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_17_22385437 -->|"n
ExtendToken 'firstItem1'"|eNFA7_18_45875888
eNFA7_18_45875888 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_18_45875888 -.->|"ε"|eNFA7_43_30149715
eNFA7_18_45875888 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_18_45875888 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_21_142347 -->|"r
ExtendToken 'firstItem1'"|eNFA7_22_10229816
eNFA7_22_10229816 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_22_10229816 -.->|"ε"|eNFA7_43_30149715
eNFA7_22_10229816 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_22_10229816 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_25_1281126 -->|"-
ExtendToken 'firstItem1'"|eNFA7_26_24959482
eNFA7_26_24959482 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_26_24959482 -.->|"ε"|eNFA7_43_30149715
eNFA7_26_24959482 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_26_24959482 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_10_3762492 -.->|"ε"|eNFA7_43_30149715
eNFA7_10_3762492 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_10_3762492 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_43_30149715 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_43_30149715 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_44_17540457 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_33_11530135 -->|"#92;
ExtendToken 'firstItem1'"|eNFA7_34_23308753
eNFA7_34_23308753 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_34_23308753 -.->|"ε"|eNFA7_43_30149715
eNFA7_34_23308753 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_34_23308753 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA7_39_36662351 -->|"^
ExtendToken 'firstItem1'"|eNFA7_40_8452189
eNFA7_40_8452189 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_40_8452189 -.->|"ε"|eNFA7_43_30149715
eNFA7_40_8452189 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_40_8452189 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA4_5_52377526 -.->|"ε"|eNFA4_6_14721181
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'"|eNFA8_9_1635686
eNFA4_5_52377526 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_17794566
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_0_37269850
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_11_33967256
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_15_66993202
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_19_66067912
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_23_57740301
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_27_49900666
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_29_46452817
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_31_15422169
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_35_4581796
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_37_41236172
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_39_35581233
eNFA4_5_52377526 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_43_51795644
eNFA4_5_52377526 -.->|"ε
CheckToken '[^'"|eNFA0_1_35811547
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_1_16860416
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_12_17526019
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_16_23516450
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_20_10321460
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_24_25784284
eNFA4_5_52377526 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_28_4220283
eNFA4_5_52377526 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_30_42305831
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_32_30731970
eNFA4_5_52377526 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_36_6298672
eNFA4_5_52377526 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_38_56688054
eNFA4_5_52377526 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_40_8152279
eNFA4_5_52377526 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_44_28329695
eNFA4_6_14721181 -.->|"ε
CheckToken '[^'
AcceptToken '[^'"|eNFA4_7_17794566
eNFA4_6_14721181 -.->|"ε
CheckToken '[^'"|eNFA0_1_35811547
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_0_37269850
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_11_33967256
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_15_66993202
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_19_66067912
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_23_57740301
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_27_49900666
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_29_46452817
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_31_15422169
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_35_4581796
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_37_41236172
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_39_35581233
eNFA8_9_1635686 -.->|"ε
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_43_51795644
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_1_16860416
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_12_17526019
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_16_23516450
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_20_10321460
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_24_25784284
eNFA8_9_1635686 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_28_4220283
eNFA8_9_1635686 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_30_42305831
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_32_30731970
eNFA8_9_1635686 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_36_6298672
eNFA8_9_1635686 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_38_56688054
eNFA8_9_1635686 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_40_8152279
eNFA8_9_1635686 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_44_28329695
eNFA4_7_17794566 -.->|"ε
CheckToken '[^'"|eNFA0_1_35811547
eNFA8_0_37269850 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_1_16860416
eNFA8_11_33967256 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_12_17526019
eNFA8_15_66993202 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_16_23516450
eNFA8_19_66067912 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_20_10321460
eNFA8_23_57740301 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_24_25784284
eNFA8_27_49900666 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_28_4220283
eNFA8_29_46452817 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_30_42305831
eNFA8_31_15422169 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_32_30731970
eNFA8_35_4581796 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_36_6298672
eNFA8_37_41236172 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_38_56688054
eNFA8_39_35581233 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|eNFA8_40_8152279
eNFA8_43_51795644 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|eNFA8_44_28329695
eNFA8_1_16860416 -.->|"ε"|eNFA8_2_65265032
eNFA8_1_16860416 -->|"u"|eNFA8_3_51976202
eNFA8_12_17526019 -.->|"ε"|eNFA8_13_6261652
eNFA8_12_17526019 -->|"t
ExtendToken 'firstItem2'"|eNFA8_14_55370462
eNFA8_16_23516450 -.->|"ε"|eNFA8_17_56354875
eNFA8_16_23516450 -->|"n
ExtendToken 'firstItem2'"|eNFA8_18_28572113
eNFA8_20_10321460 -.->|"ε"|eNFA8_21_37431827
eNFA8_20_10321460 -->|"r
ExtendToken 'firstItem2'"|eNFA8_22_55822426
eNFA8_24_25784284 -.->|"ε"|eNFA8_25_1342126
eNFA8_24_25784284 -->|"-
ExtendToken 'firstItem2'"|eNFA8_26_32639786
eNFA8_28_4220283 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_28_4220283 -.->|"ε"|eNFA8_45_2911981
eNFA8_28_4220283 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_28_4220283 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_30_42305831 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_30_42305831 -.->|"ε"|eNFA8_45_2911981
eNFA8_30_42305831 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_30_42305831 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_32_30731970 -.->|"ε"|eNFA8_33_12079142
eNFA8_32_30731970 -->|"#92;
ExtendToken 'firstItem2'"|eNFA8_34_25322618
eNFA8_36_6298672 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_36_6298672 -.->|"ε"|eNFA8_45_2911981
eNFA8_36_6298672 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_36_6298672 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_38_56688054 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_38_56688054 -.->|"ε"|eNFA8_45_2911981
eNFA8_38_56688054 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_38_56688054 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_40_8152279 -.->|"ε"|eNFA8_41_41603419
eNFA8_40_8152279 -->|"^
ExtendToken 'firstItem2'"|eNFA8_42_26576971
eNFA8_44_28329695 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_44_28329695 -.->|"ε"|eNFA8_45_2911981
eNFA8_44_28329695 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_44_28329695 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA5_6_65381771 -.->|"ε"|eNFA5_4_61432121
eNFA5_6_65381771 -.->|"ε"|eNFA5_8_51565033
eNFA5_6_65381771 -.->|"ε"|eNFA5_7_16018178
eNFA5_6_65381771 -->|"[^*]"|eNFA5_5_40962311
eNFA5_6_65381771 -->|"[*]"|eNFA5_9_17009632
eNFA5_6_65381771 -.->|"ε"|eNFA5_6_65381771
eNFA5_6_65381771 -.->|"ε"|eNFA5_12_43843091
eNFA5_6_65381771 -->|"*"|eNFA5_13_50514376
eNFA5_4_61432121 -->|"[^*]"|eNFA5_5_40962311
eNFA5_8_51565033 -->|"[*]"|eNFA5_9_17009632
eNFA5_7_16018178 -.->|"ε"|eNFA5_6_65381771
eNFA5_7_16018178 -.->|"ε"|eNFA5_12_43843091
eNFA5_7_16018178 -.->|"ε"|eNFA5_4_61432121
eNFA5_7_16018178 -.->|"ε"|eNFA5_8_51565033
eNFA5_7_16018178 -.->|"ε"|eNFA5_7_16018178
eNFA5_7_16018178 -->|"[^*]"|eNFA5_5_40962311
eNFA5_7_16018178 -->|"[*]"|eNFA5_9_17009632
eNFA5_7_16018178 -->|"*"|eNFA5_13_50514376
eNFA5_5_40962311 -.->|"ε"|eNFA5_7_16018178
eNFA5_5_40962311 -.->|"ε"|eNFA5_6_65381771
eNFA5_5_40962311 -.->|"ε"|eNFA5_12_43843091
eNFA5_5_40962311 -.->|"ε"|eNFA5_4_61432121
eNFA5_5_40962311 -.->|"ε"|eNFA5_8_51565033
eNFA5_5_40962311 -->|"[^*]"|eNFA5_5_40962311
eNFA5_5_40962311 -->|"[*]"|eNFA5_9_17009632
eNFA5_5_40962311 -->|"*"|eNFA5_13_50514376
eNFA5_9_17009632 -.->|"ε"|eNFA5_10_18868961
eNFA5_9_17009632 -->|"[^/]"|eNFA5_11_11490904
eNFA5_12_43843091 -->|"*"|eNFA5_13_50514376
eNFA5_13_50514376 -.->|"ε"|eNFA5_14_64805763
eNFA5_13_50514376 -->|"/
ExtendToken 'blockComment'"|eNFA5_15_19206131
eNFA6_4_9945879 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|eNFA6_4_9945879
eNFA6_4_9945879 -.->|"ε
ExtendToken 'inlineComment'"|eNFA6_6_309837
eNFA6_4_9945879 -.->|"ε"|eNFA6_7_48089211
eNFA6_4_9945879 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA6_8_13003964
eNFA6_4_9945879 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_35811547
eNFA6_6_309837 -.->|"ε"|eNFA6_7_48089211
eNFA6_6_309837 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA6_8_13003964
eNFA6_6_309837 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_35811547
eNFA6_7_48089211 -.->|"ε
CheckToken 'inlineComment'
AcceptToken 'inlineComment'"|eNFA6_8_13003964
eNFA6_7_48089211 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_35811547
eNFA6_8_13003964 -.->|"ε
CheckToken 'inlineComment'"|eNFA0_1_35811547
eNFA1_6_11930629 -->|"[0-9]"|eNFA1_7_8970000
eNFA7_4_51990912 -->|"[0-9]"|eNFA7_5_41252464
eNFA7_5_41252464 -->|"[0-9]"|eNFA7_6_11717596
eNFA8_2_65265032 -->|"u"|eNFA8_3_51976202
eNFA8_3_51976202 -.->|"ε"|eNFA8_4_65132640
eNFA8_3_51976202 -->|"[0-9]"|eNFA8_5_35727861
eNFA8_13_6261652 -->|"t
ExtendToken 'firstItem2'"|eNFA8_14_55370462
eNFA8_14_55370462 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_14_55370462 -.->|"ε"|eNFA8_45_2911981
eNFA8_14_55370462 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_14_55370462 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_17_56354875 -->|"n
ExtendToken 'firstItem2'"|eNFA8_18_28572113
eNFA8_18_28572113 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_18_28572113 -.->|"ε"|eNFA8_45_2911981
eNFA8_18_28572113 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_18_28572113 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_21_37431827 -->|"r
ExtendToken 'firstItem2'"|eNFA8_22_55822426
eNFA8_22_55822426 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_22_55822426 -.->|"ε"|eNFA8_45_2911981
eNFA8_22_55822426 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_22_55822426 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_25_1342126 -->|"-
ExtendToken 'firstItem2'"|eNFA8_26_32639786
eNFA8_26_32639786 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_26_32639786 -.->|"ε"|eNFA8_45_2911981
eNFA8_26_32639786 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_26_32639786 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_10_45208163 -.->|"ε"|eNFA8_45_2911981
eNFA8_10_45208163 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_10_45208163 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_45_2911981 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_45_2911981 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_46_47259335 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_33_12079142 -->|"#92;
ExtendToken 'firstItem2'"|eNFA8_34_25322618
eNFA8_34_25322618 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_34_25322618 -.->|"ε"|eNFA8_45_2911981
eNFA8_34_25322618 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_34_25322618 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA8_41_41603419 -->|"^
ExtendToken 'firstItem2'"|eNFA8_42_26576971
eNFA8_42_26576971 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_42_26576971 -.->|"ε"|eNFA8_45_2911981
eNFA8_42_26576971 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_42_26576971 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547
eNFA5_10_18868961 -->|"[^/]"|eNFA5_11_11490904
eNFA5_11_11490904 -.->|"ε"|eNFA5_7_16018178
eNFA5_11_11490904 -.->|"ε"|eNFA5_6_65381771
eNFA5_11_11490904 -.->|"ε"|eNFA5_12_43843091
eNFA5_11_11490904 -.->|"ε"|eNFA5_4_61432121
eNFA5_11_11490904 -.->|"ε"|eNFA5_8_51565033
eNFA5_11_11490904 -->|"[^*]"|eNFA5_5_40962311
eNFA5_11_11490904 -->|"[*]"|eNFA5_9_17009632
eNFA5_11_11490904 -->|"*"|eNFA5_13_50514376
eNFA5_14_64805763 -->|"/
ExtendToken 'blockComment'"|eNFA5_15_19206131
eNFA5_15_19206131 -.->|"ε
ExtendToken 'blockComment'"|eNFA5_17_38637452
eNFA5_15_19206131 -.->|"ε"|eNFA5_18_12192756
eNFA5_15_19206131 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA5_19_25551623
eNFA5_15_19206131 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_35811547
eNFA1_7_8970000 -->|"[0-9]
ExtendToken 'char'"|eNFA1_8_49926818
eNFA7_6_11717596 -->|"[0-9]"|eNFA7_7_61525703
eNFA8_4_65132640 -->|"[0-9]"|eNFA8_5_35727861
eNFA8_5_35727861 -->|"[0-9]"|eNFA8_6_39499626
eNFA5_17_38637452 -.->|"ε"|eNFA5_18_12192756
eNFA5_17_38637452 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA5_19_25551623
eNFA5_17_38637452 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_35811547
eNFA5_18_12192756 -.->|"ε
CheckToken 'blockComment'
AcceptToken 'blockComment'"|eNFA5_19_25551623
eNFA5_18_12192756 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_35811547
eNFA5_19_25551623 -.->|"ε
CheckToken 'blockComment'"|eNFA0_1_35811547
eNFA1_8_49926818 -.->|"ε
ExtendToken 'char'"|eNFA1_10_49468641
eNFA1_8_49926818 -.->|"ε"|eNFA1_49_56415606
eNFA1_8_49926818 -.->|"ε
CheckToken 'char'
AcceptToken 'char'"|eNFA1_50_53868469
eNFA1_8_49926818 -.->|"ε
CheckToken 'char'"|eNFA0_1_35811547
eNFA7_7_61525703 -->|"[0-9]
ExtendToken 'firstItem1'"|eNFA7_8_2800965
eNFA8_6_39499626 -->|"[0-9]"|eNFA8_7_38886454
eNFA7_8_2800965 -.->|"ε
ExtendToken 'firstItem1'"|eNFA7_10_3762492
eNFA7_8_2800965 -.->|"ε"|eNFA7_43_30149715
eNFA7_8_2800965 -.->|"ε
CheckToken 'firstItem1'
AcceptToken 'firstItem1'"|eNFA7_44_17540457
eNFA7_8_2800965 -.->|"ε
CheckToken 'firstItem1'"|eNFA0_1_35811547
eNFA8_7_38886454 -->|"[0-9]
ExtendToken 'firstItem2'"|eNFA8_8_28638022
eNFA8_8_28638022 -.->|"ε
ExtendToken 'firstItem2'"|eNFA8_10_45208163
eNFA8_8_28638022 -.->|"ε"|eNFA8_45_2911981
eNFA8_8_28638022 -.->|"ε
CheckToken 'firstItem2'
AcceptToken 'firstItem2'"|eNFA8_46_47259335
eNFA8_8_28638022 -.->|"ε
CheckToken 'firstItem2'"|eNFA0_1_35811547

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
NFA0_0_53115297("NFA0-0 wholeStart")
class NFA0_0_53115297 c1000;
NFA1_1_8275629("NFA1-1 char[1]")
NFA1_12_7371802("NFA1-12 char[1]")
NFA1_16_66346226("NFA1-16 char[1]")
NFA1_20_60245124("NFA1-20 char[1]")
NFA1_24_5335211("NFA1-24 char[1]")
NFA1_28_48016903[\"NFA1-28 scope[1]
AcceptToken 'char'"/]
class NFA1_28_48016903 c0101;
NFA1_30_29498945("NFA1-30 char[1]")
NFA1_34_64163914("NFA1-34 char[1]")
NFA1_38_40604315("NFA1-38 char[1]")
NFA1_42_29894517[\"NFA1-42 char[1]
AcceptToken 'char'"/]
class NFA1_42_29894517 c0101;
NFA1_44_615201("NFA1-44 char[1]")
NFA1_48_5536817[\"NFA1-48 scope[1]
AcceptToken 'char'"/]
class NFA1_48_5536817 c0101;
NFA2_1_49831357[\"NFA2-1 char[1]
AcceptToken '['"/]
class NFA2_1_49831357 c1101;
NFA3_1_45829029[\"NFA3-1 char[1]
AcceptToken ']'"/]
class NFA3_1_45829029 c0101;
NFA4_1_9808084("NFA4-1 char[1]")
NFA5_1_21163898("NFA5-1 char[1]")
NFA6_1_56257360("NFA6-1 char[1]")
NFA1_3_44879761("NFA1-3 char[1]")
NFA1_14_36554200[\"NFA1-14 char[1]
AcceptToken 'char'"/]
class NFA1_14_36554200 c0101;
NFA1_18_60552345[\"NFA1-18 char[1]
AcceptToken 'char'"/]
class NFA1_18_60552345 c0101;
NFA1_22_8100198[\"NFA1-22 char[1]
AcceptToken 'char'"/]
class NFA1_22_8100198 c0101;
NFA1_26_5792918[\"NFA1-26 char[1]
AcceptToken 'char'"/]
class NFA1_26_5792918 c0101;
NFA1_32_52136268[\"NFA1-32 char[1]
AcceptToken 'char'"/]
class NFA1_32_52136268 c0101;
NFA1_36_66573232[\"NFA1-36 char[1]
AcceptToken 'char'"/]
class NFA1_36_66573232 c0101;
NFA1_40_62288179[\"NFA1-40 char[1]
AcceptToken 'char'"/]
class NFA1_40_62288179 c0101;
NFA1_46_23722702[\"NFA1-46 char[1]
AcceptToken 'char'"/]
class NFA1_46_23722702 c0101;
NFA7_1_12177730("NFA7-1 char[1]")
NFA7_12_42490713("NFA7-12 char[1]")
NFA7_16_46872098("NFA7-16 char[1]")
NFA7_20_19195704("NFA7-20 char[1]")
NFA7_24_38543611("NFA7-24 char[1]")
NFA7_28_11348180[\"NFA7-28 scope[1]
AcceptToken 'firstItem1'"/]
class NFA7_28_11348180 c0101;
NFA7_30_35024756[\"NFA7-30 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_30_35024756 c0101;
NFA7_32_46787348("NFA7-32 char[1]")
NFA7_36_18432949[\"NFA7-36 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_36_18432949 c0101;
NFA7_38_31678816("NFA7-38 char[1]")
NFA7_42_16673895[\"NFA7-42 scope[1]
AcceptToken 'firstItem1'"/]
class NFA7_42_16673895 c0101;
NFA4_3_15847329[\"NFA4-3 char[1]
AcceptToken '[^'"/]
class NFA4_3_15847329 c1101;
NFA5_3_29369493("NFA5-3 char[1]")
NFA6_3_8408241[\"NFA6-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA6_3_8408241 c0101;
NFA1_5_1264671("NFA1-5 scope[1]")
NFA7_3_11382045("NFA7-3 char[1]")
NFA7_14_8565311[\"NFA7-14 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_14_8565311 c0101;
NFA7_18_9978940[\"NFA7-18 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_18_9978940 c0101;
NFA7_22_22701601[\"NFA7-22 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_22_22701601 c0101;
NFA7_26_2987824[\"NFA7-26 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_26_2987824 c0101;
NFA7_34_26890416[\"NFA7-34 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_34_26890416 c0101;
NFA7_40_40687155[\"NFA7-40 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_40_40687155 c0101;
NFA8_1_30640083("NFA8-1 char[1]")
NFA8_12_7325296("NFA8-12 char[1]")
NFA8_16_65927667("NFA8-16 char[1]")
NFA8_20_56478093("NFA8-20 char[1]")
NFA8_24_38540791("NFA8-24 char[1]")
NFA8_28_11322802[\"NFA8-28 scope[1]
AcceptToken 'firstItem2'"/]
class NFA8_28_11322802 c0101;
NFA8_30_34796360[\"NFA8-30 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_30_34796360 c0101;
NFA8_32_44731784("NFA8-32 char[1]")
NFA8_36_67041741[\"NFA8-36 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_36_67041741 c0101;
NFA8_38_66504758[\"NFA8-38 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_38_66504758 c0101;
NFA8_40_61671918("NFA8-40 char[1]")
NFA8_44_18176357[\"NFA8-44 scope[1]
AcceptToken 'firstItem2'"/]
class NFA8_44_18176357 c0101;
NFA5_5_30118695("NFA5-5 scope[1]")
NFA5_9_62998845("NFA5-9 scope[1]")
NFA5_13_2632805("NFA5-13 char[1]")
NFA6_4_23695246[\"NFA6-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA6_4_23695246 c0101;
NFA1_6_35329549("NFA1-6 scope[2]")
NFA7_5_49530486("NFA7-5 scope[1]")
NFA8_3_43121195("NFA8-3 char[1]")
NFA8_14_40266802[\"NFA8-14 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_14_40266802 c0101;
NFA8_18_26856902[\"NFA8-18 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_18_26856902 c0101;
NFA8_22_40385530[\"NFA8-22 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_22_40385530 c0101;
NFA8_26_27925455[\"NFA8-26 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_26_27925455 c0101;
NFA8_34_50002511[\"NFA8-34 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_34_50002511 c0101;
NFA8_42_47369417[\"NFA8-42 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_42_47369417 c0101;
NFA5_11_38349502("NFA5-11 scope[1]")
NFA5_15_23671576[\"NFA5-15 char[1]
AcceptToken 'blockComment'"/]
class NFA5_15_23671576 c0101;
NFA1_7_19301928("NFA1-7 scope[3]")
NFA7_6_52546435("NFA7-6 scope[2]")
NFA8_5_3155873("NFA8-5 scope[1]")
NFA1_8_9601199[\"NFA1-8 scope[4]
AcceptToken 'char'"/]
class NFA1_8_9601199 c0101;
NFA7_7_45353142("NFA7-7 scope[3]")
NFA8_6_28402861("NFA8-6 scope[2]")
NFA7_8_19952318[\"NFA7-8 scope[4]
AcceptToken 'firstItem1'"/]
class NFA7_8_19952318 c0101;
NFA8_7_49725882("NFA8-7 scope[3]")
NFA8_8_5525098[\"NFA8-8 scope[4]
AcceptToken 'firstItem2'"/]
class NFA8_8_5525098 c0101;
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_1_8275629
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_12_7371802
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_16_66346226
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_20_60245124
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_24_5335211
NFA0_0_53115297 -->|"[#32;-Z]
BeginToken 'char'
ExtendToken 'char'"|NFA1_28_48016903
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_30_29498945
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_34_64163914
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_38_40604315
NFA0_0_53115297 -->|"^
BeginToken 'char'
ExtendToken 'char'"|NFA1_42_29894517
NFA0_0_53115297 -->|"#92;
BeginToken 'char'"|NFA1_44_615201
NFA0_0_53115297 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|NFA1_48_5536817
NFA0_0_53115297 -->|"[
BeginToken '['
ExtendToken '['"|NFA2_1_49831357
NFA0_0_53115297 -->|"]
BeginToken ']'
ExtendToken ']'"|NFA3_1_45829029
NFA0_0_53115297 -->|"[
BeginToken '[^'"|NFA4_1_9808084
NFA0_0_53115297 -->|"/
BeginToken 'blockComment'"|NFA5_1_21163898
NFA0_0_53115297 -->|"/
BeginToken 'inlineComment'"|NFA6_1_56257360
NFA1_1_8275629 -->|"u"|NFA1_3_44879761
NFA1_12_7371802 -->|"t
ExtendToken 'char'"|NFA1_14_36554200
NFA1_16_66346226 -->|"n
ExtendToken 'char'"|NFA1_18_60552345
NFA1_20_60245124 -->|"r
ExtendToken 'char'"|NFA1_22_8100198
NFA1_24_5335211 -->|"-
ExtendToken 'char'"|NFA1_26_5792918
NFA1_30_29498945 -->|"[
ExtendToken 'char'"|NFA1_32_52136268
NFA1_34_64163914 -->|"#92;
ExtendToken 'char'"|NFA1_36_66573232
NFA1_38_40604315 -->|"]
ExtendToken 'char'"|NFA1_40_62288179
NFA1_44_615201 -->|"^
ExtendToken 'char'"|NFA1_46_23722702
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_1_12177730
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_12_42490713
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_16_46872098
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_20_19195704
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_24_38543611
NFA2_1_49831357 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA7_28_11348180
NFA2_1_49831357 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA7_30_35024756
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_32_46787348
NFA2_1_49831357 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA7_36_18432949
NFA2_1_49831357 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|NFA7_38_31678816
NFA2_1_49831357 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|NFA7_42_16673895
NFA4_1_9808084 -->|"^
ExtendToken '[^'"|NFA4_3_15847329
NFA5_1_21163898 -->|"*"|NFA5_3_29369493
NFA6_1_56257360 -->|"/
ExtendToken 'inlineComment'"|NFA6_3_8408241
NFA1_3_44879761 -->|"[0-9]"|NFA1_5_1264671
NFA7_1_12177730 -->|"u"|NFA7_3_11382045
NFA7_12_42490713 -->|"t
ExtendToken 'firstItem1'"|NFA7_14_8565311
NFA7_16_46872098 -->|"n
ExtendToken 'firstItem1'"|NFA7_18_9978940
NFA7_20_19195704 -->|"r
ExtendToken 'firstItem1'"|NFA7_22_22701601
NFA7_24_38543611 -->|"-
ExtendToken 'firstItem1'"|NFA7_26_2987824
NFA7_32_46787348 -->|"#92;
ExtendToken 'firstItem1'"|NFA7_34_26890416
NFA7_38_31678816 -->|"^
ExtendToken 'firstItem1'"|NFA7_40_40687155
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_1_30640083
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_12_7325296
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_16_65927667
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_20_56478093
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_24_38540791
NFA4_3_15847329 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA8_28_11322802
NFA4_3_15847329 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA8_30_34796360
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_32_44731784
NFA4_3_15847329 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA8_36_67041741
NFA4_3_15847329 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA8_38_66504758
NFA4_3_15847329 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|NFA8_40_61671918
NFA4_3_15847329 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|NFA8_44_18176357
NFA5_3_29369493 -->|"[^*]"|NFA5_5_30118695
NFA5_3_29369493 -->|"[*]"|NFA5_9_62998845
NFA5_3_29369493 -->|"*"|NFA5_13_2632805
NFA6_3_8408241 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA6_4_23695246
NFA1_5_1264671 -->|"[0-9]"|NFA1_6_35329549
NFA7_3_11382045 -->|"[0-9]"|NFA7_5_49530486
NFA8_1_30640083 -->|"u"|NFA8_3_43121195
NFA8_12_7325296 -->|"t
ExtendToken 'firstItem2'"|NFA8_14_40266802
NFA8_16_65927667 -->|"n
ExtendToken 'firstItem2'"|NFA8_18_26856902
NFA8_20_56478093 -->|"r
ExtendToken 'firstItem2'"|NFA8_22_40385530
NFA8_24_38540791 -->|"-
ExtendToken 'firstItem2'"|NFA8_26_27925455
NFA8_32_44731784 -->|"#92;
ExtendToken 'firstItem2'"|NFA8_34_50002511
NFA8_40_61671918 -->|"^
ExtendToken 'firstItem2'"|NFA8_42_47369417
NFA5_5_30118695 -->|"[^*]"|NFA5_5_30118695
NFA5_5_30118695 -->|"[*]"|NFA5_9_62998845
NFA5_5_30118695 -->|"*"|NFA5_13_2632805
NFA5_9_62998845 -->|"[^/]"|NFA5_11_38349502
NFA5_13_2632805 -->|"/
ExtendToken 'blockComment'"|NFA5_15_23671576
NFA6_4_23695246 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|NFA6_4_23695246
NFA1_6_35329549 -->|"[0-9]"|NFA1_7_19301928
NFA7_5_49530486 -->|"[0-9]"|NFA7_6_52546435
NFA8_3_43121195 -->|"[0-9]"|NFA8_5_3155873
NFA5_11_38349502 -->|"[^*]"|NFA5_5_30118695
NFA5_11_38349502 -->|"[*]"|NFA5_9_62998845
NFA5_11_38349502 -->|"*"|NFA5_13_2632805
NFA1_7_19301928 -->|"[0-9]
ExtendToken 'char'"|NFA1_8_9601199
NFA7_6_52546435 -->|"[0-9]"|NFA7_7_45353142
NFA8_5_3155873 -->|"[0-9]"|NFA8_6_28402861
NFA7_7_45353142 -->|"[0-9]
ExtendToken 'firstItem1'"|NFA7_8_19952318
NFA8_6_28402861 -->|"[0-9]"|NFA8_7_49725882
NFA8_7_49725882 -->|"[0-9]
ExtendToken 'firstItem2'"|NFA8_8_5525098

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
subgraph DFA0_959717059["DFA0 wholeStart"]
NFA0_0_53115297_0("NFA0-0 wholeStart")
class NFA0_0_53115297_0 c1000;
end
class DFA0_959717059 c1000;
subgraph DFA1_1108858292["DFA1 {9}"]
NFA1_1_8275629_1("NFA1-1 char[1]")
NFA1_12_7371802_2("NFA1-12 char[1]")
NFA1_16_66346226_3("NFA1-16 char[1]")
NFA1_20_60245124_4("NFA1-20 char[1]")
NFA1_24_5335211_5("NFA1-24 char[1]")
NFA1_30_29498945_6("NFA1-30 char[1]")
NFA1_34_64163914_7("NFA1-34 char[1]")
NFA1_38_40604315_8("NFA1-38 char[1]")
NFA1_44_615201_9("NFA1-44 char[1]")
end
subgraph DFA2_-1682253378["DFA2 {1}"]
NFA1_28_48016903_10[\"NFA1-28 scope[1]
AcceptToken 'char'"/]
class NFA1_28_48016903_10 c0101;
end
class DFA2_-1682253378 c0101;
subgraph DFA3_1901332768["DFA3 {3}"]
NFA1_28_48016903_11[\"NFA1-28 scope[1]
AcceptToken 'char'"/]
class NFA1_28_48016903_11 c0101;
NFA5_1_21163898_12("NFA5-1 char[1]")
NFA6_1_56257360_13("NFA6-1 char[1]")
end
class DFA3_1901332768 c0101;
subgraph DFA4_-783341220["DFA4 {1}"]
NFA1_42_29894517_14[\"NFA1-42 char[1]
AcceptToken 'char'"/]
class NFA1_42_29894517_14 c0101;
end
class DFA4_-783341220 c0101;
subgraph DFA5_-1289131532["DFA5 {1}"]
NFA1_48_5536817_15[\"NFA1-48 scope[1]
AcceptToken 'char'"/]
class NFA1_48_5536817_15 c0101;
end
class DFA5_-1289131532 c0101;
subgraph DFA6_-618929247["DFA6 {2}"]
NFA2_1_49831357_16[\"NFA2-1 char[1]
AcceptToken '['"/]
class NFA2_1_49831357_16 c1101;
NFA4_1_9808084_17("NFA4-1 char[1]")
end
class DFA6_-618929247 c1101;
subgraph DFA7_-1961732557["DFA7 {1}"]
NFA3_1_45829029_18[\"NFA3-1 char[1]
AcceptToken ']'"/]
class NFA3_1_45829029_18 c0101;
end
class DFA7_-1961732557 c0101;
subgraph DFA8_1569233356["DFA8 {1}"]
NFA1_3_44879761_19("NFA1-3 char[1]")
end
subgraph DFA9_-1344796577["DFA9 {1}"]
NFA1_14_36554200_20[\"NFA1-14 char[1]
AcceptToken 'char'"/]
class NFA1_14_36554200_20 c0101;
end
class DFA9_-1344796577 c0101;
subgraph DFA10_2034109769["DFA10 {1}"]
NFA1_18_60552345_21[\"NFA1-18 char[1]
AcceptToken 'char'"/]
class NFA1_18_60552345_21 c0101;
end
class DFA10_2034109769 c0101;
subgraph DFA11_1608650861["DFA11 {1}"]
NFA1_22_8100198_22[\"NFA1-22 char[1]
AcceptToken 'char'"/]
class NFA1_22_8100198_22 c0101;
end
class DFA11_1608650861 c0101;
subgraph DFA12_1146874116["DFA12 {1}"]
NFA1_26_5792918_23[\"NFA1-26 char[1]
AcceptToken 'char'"/]
class NFA1_26_5792918_23 c0101;
end
class DFA12_1146874116 c0101;
subgraph DFA13_1999389059["DFA13 {1}"]
NFA1_32_52136268_24[\"NFA1-32 char[1]
AcceptToken 'char'"/]
class NFA1_32_52136268_24 c0101;
end
class DFA13_1999389059 c0101;
subgraph DFA14_307894127["DFA14 {1}"]
NFA1_36_66573232_25[\"NFA1-36 char[1]
AcceptToken 'char'"/]
class NFA1_36_66573232_25 c0101;
end
class DFA14_307894127 c0101;
subgraph DFA15_849971840["DFA15 {1}"]
NFA1_40_62288179_26[\"NFA1-40 char[1]
AcceptToken 'char'"/]
class NFA1_40_62288179_26 c0101;
end
class DFA15_849971840 c0101;
subgraph DFA16_1913010798["DFA16 {1}"]
NFA1_46_23722702_27[\"NFA1-46 char[1]
AcceptToken 'char'"/]
class NFA1_46_23722702_27 c0101;
end
class DFA16_1913010798 c0101;
subgraph DFA17_1590941627["DFA17 {1}"]
NFA5_3_29369493_28("NFA5-3 char[1]")
end
subgraph DFA18_1658321644["DFA18 {1}"]
NFA6_3_8408241_29[\"NFA6-3 char[1]
AcceptToken 'inlineComment'"/]
class NFA6_3_8408241_29 c0101;
end
class DFA18_1658321644 c0101;
subgraph DFA19_1320486412["DFA19 {7}"]
NFA7_1_12177730_30("NFA7-1 char[1]")
NFA7_12_42490713_31("NFA7-12 char[1]")
NFA7_16_46872098_32("NFA7-16 char[1]")
NFA7_20_19195704_33("NFA7-20 char[1]")
NFA7_24_38543611_34("NFA7-24 char[1]")
NFA7_32_46787348_35("NFA7-32 char[1]")
NFA7_38_31678816_36("NFA7-38 char[1]")
end
subgraph DFA20_485462897["DFA20 {1}"]
NFA7_28_11348180_37[\"NFA7-28 scope[1]
AcceptToken 'firstItem1'"/]
class NFA7_28_11348180_37 c0101;
end
class DFA20_485462897 c0101;
subgraph DFA21_992789378["DFA21 {1}"]
NFA7_30_35024756_38[\"NFA7-30 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_30_35024756_38 c0101;
end
class DFA21_992789378 c0101;
subgraph DFA22_-805790856["DFA22 {1}"]
NFA7_36_18432949_39[\"NFA7-36 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_36_18432949_39 c0101;
end
class DFA22_-805790856 c0101;
subgraph DFA23_-1072474476["DFA23 {1}"]
NFA7_42_16673895_40[\"NFA7-42 scope[1]
AcceptToken 'firstItem1'"/]
class NFA7_42_16673895_40 c0101;
end
class DFA23_-1072474476 c0101;
subgraph DFA24_-463280789["DFA24 {1}"]
NFA4_3_15847329_41[\"NFA4-3 char[1]
AcceptToken '[^'"/]
class NFA4_3_15847329_41 c1101;
end
class DFA24_-463280789 c1101;
subgraph DFA25_1756501868["DFA25 {1}"]
NFA1_5_1264671_42("NFA1-5 scope[1]")
end
subgraph DFA26_12329540["DFA26 {1}"]
NFA5_5_30118695_43("NFA5-5 scope[1]")
end
subgraph DFA27_747149639["DFA27 {2}"]
NFA5_9_62998845_44("NFA5-9 scope[1]")
NFA5_13_2632805_45("NFA5-13 char[1]")
end
subgraph DFA28_-1765574440["DFA28 {1}"]
NFA6_4_23695246_46[\"NFA6-4 char{0, ∞}
AcceptToken 'inlineComment'"/]
class NFA6_4_23695246_46 c0101;
end
class DFA28_-1765574440 c0101;
subgraph DFA29_-1646634684["DFA29 {1}"]
NFA7_3_11382045_47("NFA7-3 char[1]")
end
subgraph DFA30_-878426081["DFA30 {1}"]
NFA7_14_8565311_48[\"NFA7-14 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_14_8565311_48 c0101;
end
class DFA30_-878426081 c0101;
subgraph DFA31_480366072["DFA31 {1}"]
NFA7_18_9978940_49[\"NFA7-18 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_18_9978940_49 c0101;
end
class DFA31_480366072 c0101;
subgraph DFA32_-310690225["DFA32 {1}"]
NFA7_22_22701601_50[\"NFA7-22 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_22_22701601_50 c0101;
end
class DFA32_-310690225 c0101;
subgraph DFA33_2143711214["DFA33 {1}"]
NFA7_26_2987824_51[\"NFA7-26 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_26_2987824_51 c0101;
end
class DFA33_2143711214 c0101;
subgraph DFA34_-817145312["DFA34 {1}"]
NFA7_34_26890416_52[\"NFA7-34 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_34_26890416_52 c0101;
end
class DFA34_-817145312 c0101;
subgraph DFA35_-765141552["DFA35 {1}"]
NFA7_40_40687155_53[\"NFA7-40 char[1]
AcceptToken 'firstItem1'"/]
class NFA7_40_40687155_53 c0101;
end
class DFA35_-765141552 c0101;
subgraph DFA36_179686296["DFA36 {7}"]
NFA8_1_30640083_54("NFA8-1 char[1]")
NFA8_12_7325296_55("NFA8-12 char[1]")
NFA8_16_65927667_56("NFA8-16 char[1]")
NFA8_20_56478093_57("NFA8-20 char[1]")
NFA8_24_38540791_58("NFA8-24 char[1]")
NFA8_32_44731784_59("NFA8-32 char[1]")
NFA8_40_61671918_60("NFA8-40 char[1]")
end
subgraph DFA37_-1055837632["DFA37 {1}"]
NFA8_28_11322802_61[\"NFA8-28 scope[1]
AcceptToken 'firstItem2'"/]
class NFA8_28_11322802_61 c0101;
end
class DFA37_-1055837632 c0101;
subgraph DFA38_858719256["DFA38 {1}"]
NFA8_30_34796360_62[\"NFA8-30 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_30_34796360_62 c0101;
end
class DFA38_858719256 c0101;
subgraph DFA39_-1097942182["DFA39 {1}"]
NFA8_36_67041741_63[\"NFA8-36 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_36_67041741_63 c0101;
end
class DFA39_-1097942182 c0101;
subgraph DFA40_1969019325["DFA40 {1}"]
NFA8_38_66504758_64[\"NFA8-38 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_38_66504758_64 c0101;
end
class DFA40_1969019325 c0101;
subgraph DFA41_-683148455["DFA41 {1}"]
NFA8_44_18176357_65[\"NFA8-44 scope[1]
AcceptToken 'firstItem2'"/]
class NFA8_44_18176357_65 c0101;
end
class DFA41_-683148455 c0101;
subgraph DFA42_-2119505283["DFA42 {1}"]
NFA1_6_35329549_66("NFA1-6 scope[2]")
end
subgraph DFA43_-749309628["DFA43 {1}"]
NFA5_11_38349502_67("NFA5-11 scope[1]")
end
subgraph DFA44_-985280593["DFA44 {1}"]
NFA5_15_23671576_68[\"NFA5-15 char[1]
AcceptToken 'blockComment'"/]
class NFA5_15_23671576_68 c0101;
end
class DFA44_-985280593 c0101;
subgraph DFA45_-1520087334["DFA45 {1}"]
NFA7_5_49530486_69("NFA7-5 scope[1]")
end
subgraph DFA46_1586969767["DFA46 {1}"]
NFA8_3_43121195_70("NFA8-3 char[1]")
end
subgraph DFA47_37479767["DFA47 {1}"]
NFA8_14_40266802_71[\"NFA8-14 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_14_40266802_71 c0101;
end
class DFA47_37479767 c0101;
subgraph DFA48_-1494279640["DFA48 {1}"]
NFA8_18_26856902_72[\"NFA8-18 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_18_26856902_72 c0101;
end
class DFA48_-1494279640 c0101;
subgraph DFA49_-1099556351["DFA49 {1}"]
NFA8_22_40385530_73[\"NFA8-22 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_22_40385530_73 c0101;
end
class DFA49_-1099556351 c0101;
subgraph DFA50_-1561269722["DFA50 {1}"]
NFA8_26_27925455_74[\"NFA8-26 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_26_27925455_74 c0101;
end
class DFA50_-1561269722 c0101;
subgraph DFA51_804655689["DFA51 {1}"]
NFA8_34_50002511_75[\"NFA8-34 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_34_50002511_75 c0101;
end
class DFA51_804655689 c0101;
subgraph DFA52_-1738388977["DFA52 {1}"]
NFA8_42_47369417_76[\"NFA8-42 char[1]
AcceptToken 'firstItem2'"/]
class NFA8_42_47369417_76 c0101;
end
class DFA52_-1738388977 c0101;
subgraph DFA53_701415575["DFA53 {1}"]
NFA1_7_19301928_77("NFA1-7 scope[3]")
end
subgraph DFA54_891763813["DFA54 {1}"]
NFA7_6_52546435_78("NFA7-6 scope[2]")
end
subgraph DFA55_-703828649["DFA55 {1}"]
NFA8_5_3155873_79("NFA8-5 scope[1]")
end
subgraph DFA56_624096528["DFA56 {1}"]
NFA1_8_9601199_80[\"NFA1-8 scope[4]
AcceptToken 'char'"/]
class NFA1_8_9601199_80 c0101;
end
class DFA56_624096528 c0101;
subgraph DFA57_-1468880640["DFA57 {1}"]
NFA7_7_45353142_81("NFA7-7 scope[3]")
end
subgraph DFA58_-180427778["DFA58 {1}"]
NFA8_6_28402861_82("NFA8-6 scope[2]")
end
subgraph DFA59_-574655011["DFA59 {1}"]
NFA7_8_19952318_83[\"NFA7-8 scope[4]
AcceptToken 'firstItem1'"/]
class NFA7_8_19952318_83 c0101;
end
class DFA59_-574655011 c0101;
subgraph DFA60_1044473259["DFA60 {1}"]
NFA8_7_49725882_84("NFA8-7 scope[3]")
end
subgraph DFA61_690348051["DFA61 {1}"]
NFA8_8_5525098_85[\"NFA8-8 scope[4]
AcceptToken 'firstItem2'"/]
class NFA8_8_5525098_85 c0101;
end
class DFA61_690348051 c0101;
DFA0_959717059 -->|"#92;
BeginToken 'char'"|DFA1_1108858292
DFA0_959717059 -->|"[#32;-.0-Z]
BeginToken 'char'
ExtendToken 'char'"|DFA2_-1682253378
DFA0_959717059 -->|"/
BeginToken 'char''blockComment''inlineComment'
ExtendToken 'char'"|DFA3_1901332768
DFA0_959717059 -->|"^
BeginToken 'char'
ExtendToken 'char'"|DFA4_-783341220
DFA0_959717059 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|DFA5_-1289131532
DFA0_959717059 -->|"[
BeginToken '[''[^'
ExtendToken '['"|DFA6_-618929247
DFA0_959717059 -->|"]
BeginToken ']'
ExtendToken ']'"|DFA7_-1961732557
DFA1_1108858292 -->|"u"|DFA8_1569233356
DFA1_1108858292 -->|"t
ExtendToken 'char'"|DFA9_-1344796577
DFA1_1108858292 -->|"n
ExtendToken 'char'"|DFA10_2034109769
DFA1_1108858292 -->|"r
ExtendToken 'char'"|DFA11_1608650861
DFA1_1108858292 -->|"-
ExtendToken 'char'"|DFA12_1146874116
DFA1_1108858292 -->|"[
ExtendToken 'char'"|DFA13_1999389059
DFA1_1108858292 -->|"#92;
ExtendToken 'char'"|DFA14_307894127
DFA1_1108858292 -->|"]
ExtendToken 'char'"|DFA15_849971840
DFA1_1108858292 -->|"^
ExtendToken 'char'"|DFA16_1913010798
DFA3_1901332768 -->|"*"|DFA17_1590941627
DFA3_1901332768 -->|"/
ExtendToken 'inlineComment'"|DFA18_1658321644
DFA6_-618929247 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|DFA19_1320486412
DFA6_-618929247 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA20_485462897
DFA6_-618929247 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA21_992789378
DFA6_-618929247 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA22_-805790856
DFA6_-618929247 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA23_-1072474476
DFA6_-618929247 -->|"^
ExtendToken '[^'"|DFA24_-463280789
DFA8_1569233356 -->|"[0-9]"|DFA25_1756501868
DFA17_1590941627 -->|"[^*]"|DFA26_12329540
DFA17_1590941627 -->|"*"|DFA27_747149639
DFA18_1658321644 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA28_-1765574440
DFA19_1320486412 -->|"u"|DFA29_-1646634684
DFA19_1320486412 -->|"t
ExtendToken 'firstItem1'"|DFA30_-878426081
DFA19_1320486412 -->|"n
ExtendToken 'firstItem1'"|DFA31_480366072
DFA19_1320486412 -->|"r
ExtendToken 'firstItem1'"|DFA32_-310690225
DFA19_1320486412 -->|"-
ExtendToken 'firstItem1'"|DFA33_2143711214
DFA19_1320486412 -->|"#92;
ExtendToken 'firstItem1'"|DFA34_-817145312
DFA19_1320486412 -->|"^
ExtendToken 'firstItem1'"|DFA35_-765141552
DFA24_-463280789 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|DFA36_179686296
DFA24_-463280789 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA37_-1055837632
DFA24_-463280789 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA38_858719256
DFA24_-463280789 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA39_-1097942182
DFA24_-463280789 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA40_1969019325
DFA24_-463280789 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA41_-683148455
DFA25_1756501868 -->|"[0-9]"|DFA42_-2119505283
DFA26_12329540 -->|"[^*]"|DFA26_12329540
DFA26_12329540 -->|"*"|DFA27_747149639
DFA27_747149639 -->|"[^/]"|DFA43_-749309628
DFA27_747149639 -->|"/
ExtendToken 'blockComment'"|DFA44_-985280593
DFA28_-1765574440 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA28_-1765574440
DFA29_-1646634684 -->|"[0-9]"|DFA45_-1520087334
DFA36_179686296 -->|"u"|DFA46_1586969767
DFA36_179686296 -->|"t
ExtendToken 'firstItem2'"|DFA47_37479767
DFA36_179686296 -->|"n
ExtendToken 'firstItem2'"|DFA48_-1494279640
DFA36_179686296 -->|"r
ExtendToken 'firstItem2'"|DFA49_-1099556351
DFA36_179686296 -->|"-
ExtendToken 'firstItem2'"|DFA50_-1561269722
DFA36_179686296 -->|"#92;
ExtendToken 'firstItem2'"|DFA51_804655689
DFA36_179686296 -->|"^
ExtendToken 'firstItem2'"|DFA52_-1738388977
DFA42_-2119505283 -->|"[0-9]"|DFA53_701415575
DFA43_-749309628 -->|"[^*]"|DFA26_12329540
DFA43_-749309628 -->|"*"|DFA27_747149639
DFA45_-1520087334 -->|"[0-9]"|DFA54_891763813
DFA46_1586969767 -->|"[0-9]"|DFA55_-703828649
DFA53_701415575 -->|"[0-9]
ExtendToken 'char'"|DFA56_624096528
DFA54_891763813 -->|"[0-9]"|DFA57_-1468880640
DFA55_-703828649 -->|"[0-9]"|DFA58_-180427778
DFA57_-1468880640 -->|"[0-9]
ExtendToken 'firstItem1'"|DFA59_-574655011
DFA58_-180427778 -->|"[0-9]"|DFA60_1044473259
DFA60_1044473259 -->|"[0-9]
ExtendToken 'firstItem2'"|DFA61_690348051

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
DFA0_959717059{{"DFA0 wholeStart"}}
class DFA0_959717059 c1000;
DFA1_1108858292{{"DFA1 {9}"}}
DFA2_-1682253378[\"DFA2 {1}
AcceptToken 'char'"/]
class DFA2_-1682253378 c0101;
DFA3_1901332768[\"DFA3 {3}
AcceptToken 'char'"/]
class DFA3_1901332768 c0101;
DFA4_-783341220[\"DFA4 {1}
AcceptToken 'char'"/]
class DFA4_-783341220 c0101;
DFA5_-1289131532[\"DFA5 {1}
AcceptToken 'char'"/]
class DFA5_-1289131532 c0101;
DFA6_-618929247[\"DFA6 {2}
AcceptToken '['"/]
class DFA6_-618929247 c1101;
DFA7_-1961732557[\"DFA7 {1}
AcceptToken ']'"/]
class DFA7_-1961732557 c0101;
DFA8_1569233356{{"DFA8 {1}"}}
DFA9_-1344796577[\"DFA9 {1}
AcceptToken 'char'"/]
class DFA9_-1344796577 c0101;
DFA10_2034109769[\"DFA10 {1}
AcceptToken 'char'"/]
class DFA10_2034109769 c0101;
DFA11_1608650861[\"DFA11 {1}
AcceptToken 'char'"/]
class DFA11_1608650861 c0101;
DFA12_1146874116[\"DFA12 {1}
AcceptToken 'char'"/]
class DFA12_1146874116 c0101;
DFA13_1999389059[\"DFA13 {1}
AcceptToken 'char'"/]
class DFA13_1999389059 c0101;
DFA14_307894127[\"DFA14 {1}
AcceptToken 'char'"/]
class DFA14_307894127 c0101;
DFA15_849971840[\"DFA15 {1}
AcceptToken 'char'"/]
class DFA15_849971840 c0101;
DFA16_1913010798[\"DFA16 {1}
AcceptToken 'char'"/]
class DFA16_1913010798 c0101;
DFA17_1590941627{{"DFA17 {1}"}}
DFA18_1658321644[\"DFA18 {1}
AcceptToken 'inlineComment'"/]
class DFA18_1658321644 c0101;
DFA19_1320486412{{"DFA19 {7}"}}
DFA20_485462897[\"DFA20 {1}
AcceptToken 'firstItem1'"/]
class DFA20_485462897 c0101;
DFA21_992789378[\"DFA21 {1}
AcceptToken 'firstItem1'"/]
class DFA21_992789378 c0101;
DFA22_-805790856[\"DFA22 {1}
AcceptToken 'firstItem1'"/]
class DFA22_-805790856 c0101;
DFA23_-1072474476[\"DFA23 {1}
AcceptToken 'firstItem1'"/]
class DFA23_-1072474476 c0101;
DFA24_-463280789[\"DFA24 {1}
AcceptToken '[^'"/]
class DFA24_-463280789 c1101;
DFA25_1756501868{{"DFA25 {1}"}}
DFA26_12329540{{"DFA26 {1}"}}
DFA27_747149639{{"DFA27 {2}"}}
DFA28_-1765574440[\"DFA28 {1}
AcceptToken 'inlineComment'"/]
class DFA28_-1765574440 c0101;
DFA29_-1646634684{{"DFA29 {1}"}}
DFA30_-878426081[\"DFA30 {1}
AcceptToken 'firstItem1'"/]
class DFA30_-878426081 c0101;
DFA31_480366072[\"DFA31 {1}
AcceptToken 'firstItem1'"/]
class DFA31_480366072 c0101;
DFA32_-310690225[\"DFA32 {1}
AcceptToken 'firstItem1'"/]
class DFA32_-310690225 c0101;
DFA33_2143711214[\"DFA33 {1}
AcceptToken 'firstItem1'"/]
class DFA33_2143711214 c0101;
DFA34_-817145312[\"DFA34 {1}
AcceptToken 'firstItem1'"/]
class DFA34_-817145312 c0101;
DFA35_-765141552[\"DFA35 {1}
AcceptToken 'firstItem1'"/]
class DFA35_-765141552 c0101;
DFA36_179686296{{"DFA36 {7}"}}
DFA37_-1055837632[\"DFA37 {1}
AcceptToken 'firstItem2'"/]
class DFA37_-1055837632 c0101;
DFA38_858719256[\"DFA38 {1}
AcceptToken 'firstItem2'"/]
class DFA38_858719256 c0101;
DFA39_-1097942182[\"DFA39 {1}
AcceptToken 'firstItem2'"/]
class DFA39_-1097942182 c0101;
DFA40_1969019325[\"DFA40 {1}
AcceptToken 'firstItem2'"/]
class DFA40_1969019325 c0101;
DFA41_-683148455[\"DFA41 {1}
AcceptToken 'firstItem2'"/]
class DFA41_-683148455 c0101;
DFA42_-2119505283{{"DFA42 {1}"}}
DFA43_-749309628{{"DFA43 {1}"}}
DFA44_-985280593[\"DFA44 {1}
AcceptToken 'blockComment'"/]
class DFA44_-985280593 c0101;
DFA45_-1520087334{{"DFA45 {1}"}}
DFA46_1586969767{{"DFA46 {1}"}}
DFA47_37479767[\"DFA47 {1}
AcceptToken 'firstItem2'"/]
class DFA47_37479767 c0101;
DFA48_-1494279640[\"DFA48 {1}
AcceptToken 'firstItem2'"/]
class DFA48_-1494279640 c0101;
DFA49_-1099556351[\"DFA49 {1}
AcceptToken 'firstItem2'"/]
class DFA49_-1099556351 c0101;
DFA50_-1561269722[\"DFA50 {1}
AcceptToken 'firstItem2'"/]
class DFA50_-1561269722 c0101;
DFA51_804655689[\"DFA51 {1}
AcceptToken 'firstItem2'"/]
class DFA51_804655689 c0101;
DFA52_-1738388977[\"DFA52 {1}
AcceptToken 'firstItem2'"/]
class DFA52_-1738388977 c0101;
DFA53_701415575{{"DFA53 {1}"}}
DFA54_891763813{{"DFA54 {1}"}}
DFA55_-703828649{{"DFA55 {1}"}}
DFA56_624096528[\"DFA56 {1}
AcceptToken 'char'"/]
class DFA56_624096528 c0101;
DFA57_-1468880640{{"DFA57 {1}"}}
DFA58_-180427778{{"DFA58 {1}"}}
DFA59_-574655011[\"DFA59 {1}
AcceptToken 'firstItem1'"/]
class DFA59_-574655011 c0101;
DFA60_1044473259{{"DFA60 {1}"}}
DFA61_690348051[\"DFA61 {1}
AcceptToken 'firstItem2'"/]
class DFA61_690348051 c0101;
DFA0_959717059 -->|"#92;
BeginToken 'char'"|DFA1_1108858292
DFA0_959717059 -->|"[#32;-.0-Z]
BeginToken 'char'
ExtendToken 'char'"|DFA2_-1682253378
DFA0_959717059 -->|"/
BeginToken 'char''blockComment''inlineComment'
ExtendToken 'char'"|DFA3_1901332768
DFA0_959717059 -->|"^
BeginToken 'char'
ExtendToken 'char'"|DFA4_-783341220
DFA0_959717059 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|DFA5_-1289131532
DFA0_959717059 -->|"[
BeginToken '[''[^'
ExtendToken '['"|DFA6_-618929247
DFA0_959717059 -->|"]
BeginToken ']'
ExtendToken ']'"|DFA7_-1961732557
DFA1_1108858292 -->|"u"|DFA8_1569233356
DFA1_1108858292 -->|"t
ExtendToken 'char'"|DFA9_-1344796577
DFA1_1108858292 -->|"n
ExtendToken 'char'"|DFA10_2034109769
DFA1_1108858292 -->|"r
ExtendToken 'char'"|DFA11_1608650861
DFA1_1108858292 -->|"-
ExtendToken 'char'"|DFA12_1146874116
DFA1_1108858292 -->|"[
ExtendToken 'char'"|DFA13_1999389059
DFA1_1108858292 -->|"#92;
ExtendToken 'char'"|DFA14_307894127
DFA1_1108858292 -->|"]
ExtendToken 'char'"|DFA15_849971840
DFA1_1108858292 -->|"^
ExtendToken 'char'"|DFA16_1913010798
DFA3_1901332768 -->|"*"|DFA17_1590941627
DFA3_1901332768 -->|"/
ExtendToken 'inlineComment'"|DFA18_1658321644
DFA6_-618929247 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|DFA19_1320486412
DFA6_-618929247 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA20_485462897
DFA6_-618929247 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA21_992789378
DFA6_-618929247 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA22_-805790856
DFA6_-618929247 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|DFA23_-1072474476
DFA6_-618929247 -->|"^
ExtendToken '[^'"|DFA24_-463280789
DFA8_1569233356 -->|"[0-9]"|DFA25_1756501868
DFA17_1590941627 -->|"[^*]"|DFA26_12329540
DFA17_1590941627 -->|"*"|DFA27_747149639
DFA18_1658321644 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA28_-1765574440
DFA19_1320486412 -->|"u"|DFA29_-1646634684
DFA19_1320486412 -->|"t
ExtendToken 'firstItem1'"|DFA30_-878426081
DFA19_1320486412 -->|"n
ExtendToken 'firstItem1'"|DFA31_480366072
DFA19_1320486412 -->|"r
ExtendToken 'firstItem1'"|DFA32_-310690225
DFA19_1320486412 -->|"-
ExtendToken 'firstItem1'"|DFA33_2143711214
DFA19_1320486412 -->|"#92;
ExtendToken 'firstItem1'"|DFA34_-817145312
DFA19_1320486412 -->|"^
ExtendToken 'firstItem1'"|DFA35_-765141552
DFA24_-463280789 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|DFA36_179686296
DFA24_-463280789 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA37_-1055837632
DFA24_-463280789 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA38_858719256
DFA24_-463280789 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA39_-1097942182
DFA24_-463280789 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA40_1969019325
DFA24_-463280789 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|DFA41_-683148455
DFA25_1756501868 -->|"[0-9]"|DFA42_-2119505283
DFA26_12329540 -->|"[^*]"|DFA26_12329540
DFA26_12329540 -->|"*"|DFA27_747149639
DFA27_747149639 -->|"[^/]"|DFA43_-749309628
DFA27_747149639 -->|"/
ExtendToken 'blockComment'"|DFA44_-985280593
DFA28_-1765574440 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|DFA28_-1765574440
DFA29_-1646634684 -->|"[0-9]"|DFA45_-1520087334
DFA36_179686296 -->|"u"|DFA46_1586969767
DFA36_179686296 -->|"t
ExtendToken 'firstItem2'"|DFA47_37479767
DFA36_179686296 -->|"n
ExtendToken 'firstItem2'"|DFA48_-1494279640
DFA36_179686296 -->|"r
ExtendToken 'firstItem2'"|DFA49_-1099556351
DFA36_179686296 -->|"-
ExtendToken 'firstItem2'"|DFA50_-1561269722
DFA36_179686296 -->|"#92;
ExtendToken 'firstItem2'"|DFA51_804655689
DFA36_179686296 -->|"^
ExtendToken 'firstItem2'"|DFA52_-1738388977
DFA42_-2119505283 -->|"[0-9]"|DFA53_701415575
DFA43_-749309628 -->|"[^*]"|DFA26_12329540
DFA43_-749309628 -->|"*"|DFA27_747149639
DFA45_-1520087334 -->|"[0-9]"|DFA54_891763813
DFA46_1586969767 -->|"[0-9]"|DFA55_-703828649
DFA53_701415575 -->|"[0-9]
ExtendToken 'char'"|DFA56_624096528
DFA54_891763813 -->|"[0-9]"|DFA57_-1468880640
DFA55_-703828649 -->|"[0-9]"|DFA58_-180427778
DFA57_-1468880640 -->|"[0-9]
ExtendToken 'firstItem1'"|DFA59_-574655011
DFA58_-180427778 -->|"[0-9]"|DFA60_1044473259
DFA60_1044473259 -->|"[0-9]
ExtendToken 'firstItem2'"|DFA61_690348051

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
subgraph MiniDFA0_-1511606937["MiniDFA0 {1}"]
DFA0_959717059_0{{"DFA0 wholeStart"}}
class DFA0_959717059_0 c1000;
end
class MiniDFA0_-1511606937 c1000;
subgraph MiniDFA1_928821900["MiniDFA1 {1}"]
DFA1_1108858292_1{{"DFA1 {9}"}}
end
subgraph MiniDFA18_695223713["MiniDFA18 {1}"]
DFA2_-1682253378_2[\"DFA2 {1}
AcceptToken 'char'"/]
class DFA2_-1682253378_2 c0101;
end
class MiniDFA18_695223713 c0101;
subgraph MiniDFA19_1638225134["MiniDFA19 {1}"]
DFA3_1901332768_3[\"DFA3 {3}
AcceptToken 'char'"/]
class DFA3_1901332768_3 c0101;
end
class MiniDFA19_1638225134 c0101;
subgraph MiniDFA20_1086171722["MiniDFA20 {1}"]
DFA4_-783341220_4[\"DFA4 {1}
AcceptToken 'char'"/]
class DFA4_-783341220_4 c0101;
end
class MiniDFA20_1086171722 c0101;
subgraph MiniDFA21_-840854781["MiniDFA21 {1}"]
DFA5_-1289131532_5[\"DFA5 {1}
AcceptToken 'char'"/]
class DFA5_-1289131532_5 c0101;
end
class MiniDFA21_-840854781 c0101;
subgraph MiniDFA22_-789683293["MiniDFA22 {1}"]
DFA6_-618929247_6[\"DFA6 {2}
AcceptToken '['"/]
class DFA6_-618929247_6 c1101;
end
class MiniDFA22_-789683293 c1101;
subgraph MiniDFA23_-1539532783["MiniDFA23 {1}"]
DFA7_-1961732557_7[\"DFA7 {1}
AcceptToken ']'"/]
class DFA7_-1961732557_7 c0101;
end
class MiniDFA23_-1539532783 c0101;
subgraph MiniDFA2_-528271078["MiniDFA2 {1}"]
DFA8_1569233356_8{{"DFA8 {1}"}}
end
subgraph MiniDFA24_1900661343["MiniDFA24 {1}"]
DFA9_-1344796577_9[\"DFA9 {1}
AcceptToken 'char'"/]
class DFA9_-1344796577_9 c0101;
end
class MiniDFA24_1900661343 c0101;
subgraph MiniDFA25_274056698["MiniDFA25 {1}"]
DFA10_2034109769_10[\"DFA10 {1}
AcceptToken 'char'"/]
class DFA10_2034109769_10 c0101;
end
class MiniDFA25_274056698 c0101;
subgraph MiniDFA26_842265739["MiniDFA26 {1}"]
DFA11_1608650861_11[\"DFA11 {1}
AcceptToken 'char'"/]
class DFA11_1608650861_11 c0101;
end
class MiniDFA26_842265739 c0101;
subgraph MiniDFA27_-678579426["MiniDFA27 {1}"]
DFA12_1146874116_12[\"DFA12 {1}
AcceptToken 'char'"/]
class DFA12_1146874116_12 c0101;
end
class MiniDFA27_-678579426 c0101;
subgraph MiniDFA28_-919092941["MiniDFA28 {1}"]
DFA13_1999389059_13[\"DFA13 {1}
AcceptToken 'char'"/]
class DFA13_1999389059_13 c0101;
end
class MiniDFA28_-919092941 c0101;
subgraph MiniDFA29_-1732484616["MiniDFA29 {1}"]
DFA14_307894127_14[\"DFA14 {1}
AcceptToken 'char'"/]
class DFA14_307894127_14 c0101;
end
class MiniDFA29_-1732484616 c0101;
subgraph MiniDFA30_1923459326["MiniDFA30 {1}"]
DFA15_849971840_15[\"DFA15 {1}
AcceptToken 'char'"/]
class DFA15_849971840_15 c0101;
end
class MiniDFA30_1923459326 c0101;
subgraph MiniDFA31_-1020973830["MiniDFA31 {1}"]
DFA16_1913010798_16[\"DFA16 {1}
AcceptToken 'char'"/]
class DFA16_1913010798_16 c0101;
end
class MiniDFA31_-1020973830 c0101;
subgraph MiniDFA11_1928273863["MiniDFA11 {3}"]
DFA17_1590941627_17{{"DFA17 {1}"}}
DFA26_12329540_18{{"DFA26 {1}"}}
DFA43_-749309628_19{{"DFA43 {1}"}}
end
subgraph MiniDFA32_-884742192["MiniDFA32 {1}"]
DFA18_1658321644_20[\"DFA18 {1}
AcceptToken 'inlineComment'"/]
class DFA18_1658321644_20 c0101;
end
class MiniDFA32_-884742192 c0101;
subgraph MiniDFA12_-1586440930["MiniDFA12 {1}"]
DFA19_1320486412_21{{"DFA19 {7}"}}
end
subgraph MiniDFA33_1638846289["MiniDFA33 {1}"]
DFA20_485462897_22[\"DFA20 {1}
AcceptToken 'firstItem1'"/]
class DFA20_485462897_22 c0101;
end
class MiniDFA33_1638846289 c0101;
subgraph MiniDFA34_735615519["MiniDFA34 {1}"]
DFA21_992789378_23[\"DFA21 {1}
AcceptToken 'firstItem1'"/]
class DFA21_992789378_23 c0101;
end
class MiniDFA34_735615519 c0101;
subgraph MiniDFA35_-960754399["MiniDFA35 {1}"]
DFA22_-805790856_24[\"DFA22 {1}
AcceptToken 'firstItem1'"/]
class DFA22_-805790856_24 c0101;
end
class MiniDFA35_-960754399 c0101;
subgraph MiniDFA36_-1388926702["MiniDFA36 {1}"]
DFA23_-1072474476_25[\"DFA23 {1}
AcceptToken 'firstItem1'"/]
class DFA23_-1072474476_25 c0101;
end
class MiniDFA36_-1388926702 c0101;
subgraph MiniDFA37_1668393521["MiniDFA37 {1}"]
DFA24_-463280789_26[\"DFA24 {1}
AcceptToken '[^'"/]
class DFA24_-463280789_26 c1101;
end
class MiniDFA37_1668393521 c1101;
subgraph MiniDFA5_-418848687["MiniDFA5 {1}"]
DFA25_1756501868_27{{"DFA25 {1}"}}
end
subgraph MiniDFA13_-58615332["MiniDFA13 {1}"]
DFA27_747149639_28{{"DFA27 {2}"}}
end
subgraph MiniDFA38_-2007412343["MiniDFA38 {1}"]
DFA28_-1765574440_29[\"DFA28 {1}
AcceptToken 'inlineComment'"/]
class DFA28_-1765574440_29 c0101;
end
class MiniDFA38_-2007412343 c0101;
subgraph MiniDFA3_1920001639["MiniDFA3 {1}"]
DFA29_-1646634684_30{{"DFA29 {1}"}}
end
subgraph MiniDFA39_-1413402411["MiniDFA39 {1}"]
DFA30_-878426081_31[\"DFA30 {1}
AcceptToken 'firstItem1'"/]
class DFA30_-878426081_31 c0101;
end
class MiniDFA39_-1413402411 c0101;
subgraph MiniDFA40_1274647712["MiniDFA40 {1}"]
DFA31_480366072_32[\"DFA31 {1}
AcceptToken 'firstItem1'"/]
class DFA31_480366072_32 c0101;
end
class MiniDFA40_1274647712 c0101;
subgraph MiniDFA41_648126257["MiniDFA41 {1}"]
DFA32_-310690225_33[\"DFA32 {1}
AcceptToken 'firstItem1'"/]
class DFA32_-310690225_33 c0101;
end
class MiniDFA41_648126257 c0101;
subgraph MiniDFA42_699688471["MiniDFA42 {1}"]
DFA33_2143711214_34[\"DFA33 {1}
AcceptToken 'firstItem1'"/]
class DFA33_2143711214_34 c0101;
end
class MiniDFA42_699688471 c0101;
subgraph MiniDFA43_2069189802["MiniDFA43 {1}"]
DFA34_-817145312_35[\"DFA34 {1}
AcceptToken 'firstItem1'"/]
class DFA34_-817145312_35 c0101;
end
class MiniDFA43_2069189802 c0101;
subgraph MiniDFA44_-1534768809["MiniDFA44 {1}"]
DFA35_-765141552_36[\"DFA35 {1}
AcceptToken 'firstItem1'"/]
class DFA35_-765141552_36 c0101;
end
class MiniDFA44_-1534768809 c0101;
subgraph MiniDFA14_-1072034541["MiniDFA14 {1}"]
DFA36_179686296_37{{"DFA36 {7}"}}
end
subgraph MiniDFA45_602225456["MiniDFA45 {1}"]
DFA37_-1055837632_38[\"DFA37 {1}
AcceptToken 'firstItem2'"/]
class DFA37_-1055837632_38 c0101;
end
class MiniDFA45_602225456 c0101;
subgraph MiniDFA46_-1754287716["MiniDFA46 {1}"]
DFA38_858719256_39[\"DFA38 {1}
AcceptToken 'firstItem2'"/]
class DFA38_858719256_39 c0101;
end
class MiniDFA46_-1754287716 c0101;
subgraph MiniDFA47_1524168998["MiniDFA47 {1}"]
DFA39_-1097942182_40[\"DFA39 {1}
AcceptToken 'firstItem2'"/]
class DFA39_-1097942182_40 c0101;
end
class MiniDFA47_1524168998 c0101;
subgraph MiniDFA48_49247994["MiniDFA48 {1}"]
DFA40_1969019325_41[\"DFA40 {1}
AcceptToken 'firstItem2'"/]
class DFA40_1969019325_41 c0101;
end
class MiniDFA48_49247994 c0101;
subgraph MiniDFA49_-1082548369["MiniDFA49 {1}"]
DFA41_-683148455_42[\"DFA41 {1}
AcceptToken 'firstItem2'"/]
class DFA41_-683148455_42 c0101;
end
class MiniDFA49_-1082548369 c0101;
subgraph MiniDFA8_-1837822121["MiniDFA8 {1}"]
DFA42_-2119505283_43{{"DFA42 {1}"}}
end
subgraph MiniDFA50_737786748["MiniDFA50 {1}"]
DFA44_-985280593_44[\"DFA44 {1}
AcceptToken 'blockComment'"/]
class DFA44_-985280593_44 c0101;
end
class MiniDFA50_737786748 c0101;
subgraph MiniDFA6_-1439188881["MiniDFA6 {1}"]
DFA45_-1520087334_45{{"DFA45 {1}"}}
end
subgraph MiniDFA4_647489505["MiniDFA4 {1}"]
DFA46_1586969767_46{{"DFA46 {1}"}}
end
subgraph MiniDFA51_1418159902["MiniDFA51 {1}"]
DFA47_37479767_47[\"DFA47 {1}
AcceptToken 'firstItem2'"/]
class DFA47_37479767_47 c0101;
end
class MiniDFA51_1418159902 c0101;
subgraph MiniDFA52_1734609358["MiniDFA52 {1}"]
DFA48_-1494279640_48[\"DFA48 {1}
AcceptToken 'firstItem2'"/]
class DFA48_-1494279640_48 c0101;
end
class MiniDFA52_1734609358 c0101;
subgraph MiniDFA53_1678115819["MiniDFA53 {1}"]
DFA49_-1099556351_49[\"DFA49 {1}
AcceptToken 'firstItem2'"/]
class DFA49_-1099556351_49 c0101;
end
class MiniDFA53_1678115819 c0101;
subgraph MiniDFA54_717060595["MiniDFA54 {1}"]
DFA50_-1561269722_50[\"DFA50 {1}
AcceptToken 'firstItem2'"/]
class DFA50_-1561269722_50 c0101;
end
class MiniDFA54_717060595 c0101;
subgraph MiniDFA55_1411981931["MiniDFA55 {1}"]
DFA51_804655689_51[\"DFA51 {1}
AcceptToken 'firstItem2'"/]
class DFA51_804655689_51 c0101;
end
class MiniDFA55_1411981931 c0101;
subgraph MiniDFA56_-2086715468["MiniDFA56 {1}"]
DFA52_-1738388977_52[\"DFA52 {1}
AcceptToken 'firstItem2'"/]
class DFA52_-1738388977_52 c0101;
end
class MiniDFA56_-2086715468 c0101;
subgraph MiniDFA15_-326530136["MiniDFA15 {1}"]
DFA53_701415575_53{{"DFA53 {1}"}}
end
subgraph MiniDFA9_-2037670625["MiniDFA9 {1}"]
DFA54_891763813_54{{"DFA54 {1}"}}
end
subgraph MiniDFA7_-981845464["MiniDFA7 {1}"]
DFA55_-703828649_55{{"DFA55 {1}"}}
end
subgraph MiniDFA57_-1805133534["MiniDFA57 {1}"]
DFA56_624096528_56[\"DFA56 {1}
AcceptToken 'char'"/]
class DFA56_624096528_56 c0101;
end
class MiniDFA57_-1805133534 c0101;
subgraph MiniDFA16_-885742503["MiniDFA16 {1}"]
DFA57_-1468880640_57{{"DFA57 {1}"}}
end
subgraph MiniDFA10_673082317["MiniDFA10 {1}"]
DFA58_-180427778_58{{"DFA58 {1}"}}
end
subgraph MiniDFA58_-1129008417["MiniDFA58 {1}"]
DFA59_-574655011_59[\"DFA59 {1}
AcceptToken 'firstItem1'"/]
class DFA59_-574655011_59 c0101;
end
class MiniDFA58_-1129008417 c0101;
subgraph MiniDFA17_1445658353["MiniDFA17 {1}"]
DFA60_1044473259_60{{"DFA60 {1}"}}
end
subgraph MiniDFA59_1217907974["MiniDFA59 {1}"]
DFA61_690348051_61[\"DFA61 {1}
AcceptToken 'firstItem2'"/]
class DFA61_690348051_61 c0101;
end
class MiniDFA59_1217907974 c0101;
MiniDFA0_-1511606937 -->|"#92;
BeginToken 'char'"|MiniDFA1_928821900
MiniDFA0_-1511606937 -->|"[#32;-.0-Z]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA18_695223713
MiniDFA0_-1511606937 -->|"/
BeginToken 'char''blockComment''inlineComment'
ExtendToken 'char'"|MiniDFA19_1638225134
MiniDFA0_-1511606937 -->|"^
BeginToken 'char'
ExtendToken 'char'"|MiniDFA20_1086171722
MiniDFA0_-1511606937 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA21_-840854781
MiniDFA0_-1511606937 -->|"[
BeginToken '[''[^'
ExtendToken '['"|MiniDFA22_-789683293
MiniDFA0_-1511606937 -->|"]
BeginToken ']'
ExtendToken ']'"|MiniDFA23_-1539532783
MiniDFA1_928821900 -->|"u"|MiniDFA2_-528271078
MiniDFA1_928821900 -->|"t
ExtendToken 'char'"|MiniDFA24_1900661343
MiniDFA1_928821900 -->|"n
ExtendToken 'char'"|MiniDFA25_274056698
MiniDFA1_928821900 -->|"r
ExtendToken 'char'"|MiniDFA26_842265739
MiniDFA1_928821900 -->|"-
ExtendToken 'char'"|MiniDFA27_-678579426
MiniDFA1_928821900 -->|"[
ExtendToken 'char'"|MiniDFA28_-919092941
MiniDFA1_928821900 -->|"#92;
ExtendToken 'char'"|MiniDFA29_-1732484616
MiniDFA1_928821900 -->|"]
ExtendToken 'char'"|MiniDFA30_1923459326
MiniDFA1_928821900 -->|"^
ExtendToken 'char'"|MiniDFA31_-1020973830
MiniDFA19_1638225134 -->|"*"|MiniDFA11_1928273863
MiniDFA19_1638225134 -->|"/
ExtendToken 'inlineComment'"|MiniDFA32_-884742192
MiniDFA22_-789683293 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|MiniDFA12_-1586440930
MiniDFA22_-789683293 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA33_1638846289
MiniDFA22_-789683293 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA34_735615519
MiniDFA22_-789683293 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA35_-960754399
MiniDFA22_-789683293 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA36_-1388926702
MiniDFA22_-789683293 -->|"^
ExtendToken '[^'"|MiniDFA37_1668393521
MiniDFA2_-528271078 -->|"[0-9]"|MiniDFA5_-418848687
MiniDFA11_1928273863 -->|"[^*]"|MiniDFA11_1928273863
MiniDFA11_1928273863 -->|"*"|MiniDFA13_-58615332
MiniDFA32_-884742192 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA38_-2007412343
MiniDFA12_-1586440930 -->|"u"|MiniDFA3_1920001639
MiniDFA12_-1586440930 -->|"t
ExtendToken 'firstItem1'"|MiniDFA39_-1413402411
MiniDFA12_-1586440930 -->|"n
ExtendToken 'firstItem1'"|MiniDFA40_1274647712
MiniDFA12_-1586440930 -->|"r
ExtendToken 'firstItem1'"|MiniDFA41_648126257
MiniDFA12_-1586440930 -->|"-
ExtendToken 'firstItem1'"|MiniDFA42_699688471
MiniDFA12_-1586440930 -->|"#92;
ExtendToken 'firstItem1'"|MiniDFA43_2069189802
MiniDFA12_-1586440930 -->|"^
ExtendToken 'firstItem1'"|MiniDFA44_-1534768809
MiniDFA37_1668393521 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|MiniDFA14_-1072034541
MiniDFA37_1668393521 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA45_602225456
MiniDFA37_1668393521 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA46_-1754287716
MiniDFA37_1668393521 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA47_1524168998
MiniDFA37_1668393521 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA48_49247994
MiniDFA37_1668393521 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA49_-1082548369
MiniDFA5_-418848687 -->|"[0-9]"|MiniDFA8_-1837822121
MiniDFA13_-58615332 -->|"[^/]"|MiniDFA11_1928273863
MiniDFA13_-58615332 -->|"/
ExtendToken 'blockComment'"|MiniDFA50_737786748
MiniDFA38_-2007412343 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA38_-2007412343
MiniDFA3_1920001639 -->|"[0-9]"|MiniDFA6_-1439188881
MiniDFA14_-1072034541 -->|"u"|MiniDFA4_647489505
MiniDFA14_-1072034541 -->|"t
ExtendToken 'firstItem2'"|MiniDFA51_1418159902
MiniDFA14_-1072034541 -->|"n
ExtendToken 'firstItem2'"|MiniDFA52_1734609358
MiniDFA14_-1072034541 -->|"r
ExtendToken 'firstItem2'"|MiniDFA53_1678115819
MiniDFA14_-1072034541 -->|"-
ExtendToken 'firstItem2'"|MiniDFA54_717060595
MiniDFA14_-1072034541 -->|"#92;
ExtendToken 'firstItem2'"|MiniDFA55_1411981931
MiniDFA14_-1072034541 -->|"^
ExtendToken 'firstItem2'"|MiniDFA56_-2086715468
MiniDFA8_-1837822121 -->|"[0-9]"|MiniDFA15_-326530136
MiniDFA6_-1439188881 -->|"[0-9]"|MiniDFA9_-2037670625
MiniDFA4_647489505 -->|"[0-9]"|MiniDFA7_-981845464
MiniDFA15_-326530136 -->|"[0-9]
ExtendToken 'char'"|MiniDFA57_-1805133534
MiniDFA9_-2037670625 -->|"[0-9]"|MiniDFA16_-885742503
MiniDFA7_-981845464 -->|"[0-9]"|MiniDFA10_673082317
MiniDFA16_-885742503 -->|"[0-9]
ExtendToken 'firstItem1'"|MiniDFA58_-1129008417
MiniDFA10_673082317 -->|"[0-9]"|MiniDFA17_1445658353
MiniDFA17_1445658353 -->|"[0-9]
ExtendToken 'firstItem2'"|MiniDFA59_1217907974

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
MiniDFA0_-1511606937(["MiniDFA0 {1}"])
class MiniDFA0_-1511606937 c1000;
MiniDFA1_928821900(["MiniDFA1 {1}"])
MiniDFA18_695223713[\"MiniDFA18 {1}
AcceptToken 'char'"/]
class MiniDFA18_695223713 c0101;
MiniDFA19_1638225134[\"MiniDFA19 {1}
AcceptToken 'char'"/]
class MiniDFA19_1638225134 c0101;
MiniDFA20_1086171722[\"MiniDFA20 {1}
AcceptToken 'char'"/]
class MiniDFA20_1086171722 c0101;
MiniDFA21_-840854781[\"MiniDFA21 {1}
AcceptToken 'char'"/]
class MiniDFA21_-840854781 c0101;
MiniDFA22_-789683293[\"MiniDFA22 {1}
AcceptToken '['"/]
class MiniDFA22_-789683293 c1101;
MiniDFA23_-1539532783[\"MiniDFA23 {1}
AcceptToken ']'"/]
class MiniDFA23_-1539532783 c0101;
MiniDFA2_-528271078(["MiniDFA2 {1}"])
MiniDFA24_1900661343[\"MiniDFA24 {1}
AcceptToken 'char'"/]
class MiniDFA24_1900661343 c0101;
MiniDFA25_274056698[\"MiniDFA25 {1}
AcceptToken 'char'"/]
class MiniDFA25_274056698 c0101;
MiniDFA26_842265739[\"MiniDFA26 {1}
AcceptToken 'char'"/]
class MiniDFA26_842265739 c0101;
MiniDFA27_-678579426[\"MiniDFA27 {1}
AcceptToken 'char'"/]
class MiniDFA27_-678579426 c0101;
MiniDFA28_-919092941[\"MiniDFA28 {1}
AcceptToken 'char'"/]
class MiniDFA28_-919092941 c0101;
MiniDFA29_-1732484616[\"MiniDFA29 {1}
AcceptToken 'char'"/]
class MiniDFA29_-1732484616 c0101;
MiniDFA30_1923459326[\"MiniDFA30 {1}
AcceptToken 'char'"/]
class MiniDFA30_1923459326 c0101;
MiniDFA31_-1020973830[\"MiniDFA31 {1}
AcceptToken 'char'"/]
class MiniDFA31_-1020973830 c0101;
MiniDFA11_1928273863(["MiniDFA11 {3}"])
MiniDFA32_-884742192[\"MiniDFA32 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA32_-884742192 c0101;
MiniDFA12_-1586440930(["MiniDFA12 {1}"])
MiniDFA33_1638846289[\"MiniDFA33 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA33_1638846289 c0101;
MiniDFA34_735615519[\"MiniDFA34 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA34_735615519 c0101;
MiniDFA35_-960754399[\"MiniDFA35 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA35_-960754399 c0101;
MiniDFA36_-1388926702[\"MiniDFA36 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA36_-1388926702 c0101;
MiniDFA37_1668393521[\"MiniDFA37 {1}
AcceptToken '[^'"/]
class MiniDFA37_1668393521 c1101;
MiniDFA5_-418848687(["MiniDFA5 {1}"])
MiniDFA13_-58615332(["MiniDFA13 {1}"])
MiniDFA38_-2007412343[\"MiniDFA38 {1}
AcceptToken 'inlineComment'"/]
class MiniDFA38_-2007412343 c0101;
MiniDFA3_1920001639(["MiniDFA3 {1}"])
MiniDFA39_-1413402411[\"MiniDFA39 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA39_-1413402411 c0101;
MiniDFA40_1274647712[\"MiniDFA40 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA40_1274647712 c0101;
MiniDFA41_648126257[\"MiniDFA41 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA41_648126257 c0101;
MiniDFA42_699688471[\"MiniDFA42 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA42_699688471 c0101;
MiniDFA43_2069189802[\"MiniDFA43 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA43_2069189802 c0101;
MiniDFA44_-1534768809[\"MiniDFA44 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA44_-1534768809 c0101;
MiniDFA14_-1072034541(["MiniDFA14 {1}"])
MiniDFA45_602225456[\"MiniDFA45 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA45_602225456 c0101;
MiniDFA46_-1754287716[\"MiniDFA46 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA46_-1754287716 c0101;
MiniDFA47_1524168998[\"MiniDFA47 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA47_1524168998 c0101;
MiniDFA48_49247994[\"MiniDFA48 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA48_49247994 c0101;
MiniDFA49_-1082548369[\"MiniDFA49 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA49_-1082548369 c0101;
MiniDFA8_-1837822121(["MiniDFA8 {1}"])
MiniDFA50_737786748[\"MiniDFA50 {1}
AcceptToken 'blockComment'"/]
class MiniDFA50_737786748 c0101;
MiniDFA6_-1439188881(["MiniDFA6 {1}"])
MiniDFA4_647489505(["MiniDFA4 {1}"])
MiniDFA51_1418159902[\"MiniDFA51 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA51_1418159902 c0101;
MiniDFA52_1734609358[\"MiniDFA52 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA52_1734609358 c0101;
MiniDFA53_1678115819[\"MiniDFA53 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA53_1678115819 c0101;
MiniDFA54_717060595[\"MiniDFA54 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA54_717060595 c0101;
MiniDFA55_1411981931[\"MiniDFA55 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA55_1411981931 c0101;
MiniDFA56_-2086715468[\"MiniDFA56 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA56_-2086715468 c0101;
MiniDFA15_-326530136(["MiniDFA15 {1}"])
MiniDFA9_-2037670625(["MiniDFA9 {1}"])
MiniDFA7_-981845464(["MiniDFA7 {1}"])
MiniDFA57_-1805133534[\"MiniDFA57 {1}
AcceptToken 'char'"/]
class MiniDFA57_-1805133534 c0101;
MiniDFA16_-885742503(["MiniDFA16 {1}"])
MiniDFA10_673082317(["MiniDFA10 {1}"])
MiniDFA58_-1129008417[\"MiniDFA58 {1}
AcceptToken 'firstItem1'"/]
class MiniDFA58_-1129008417 c0101;
MiniDFA17_1445658353(["MiniDFA17 {1}"])
MiniDFA59_1217907974[\"MiniDFA59 {1}
AcceptToken 'firstItem2'"/]
class MiniDFA59_1217907974 c0101;
MiniDFA0_-1511606937 -->|"#92;
BeginToken 'char'"|MiniDFA1_928821900
MiniDFA0_-1511606937 -->|"[#32;-.0-Z]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA18_695223713
MiniDFA0_-1511606937 -->|"/
BeginToken 'char''blockComment''inlineComment'
ExtendToken 'char'"|MiniDFA19_1638225134
MiniDFA0_-1511606937 -->|"^
BeginToken 'char'
ExtendToken 'char'"|MiniDFA20_1086171722
MiniDFA0_-1511606937 -->|"[_-~]
BeginToken 'char'
ExtendToken 'char'"|MiniDFA21_-840854781
MiniDFA0_-1511606937 -->|"[
BeginToken '[''[^'
ExtendToken '['"|MiniDFA22_-789683293
MiniDFA0_-1511606937 -->|"]
BeginToken ']'
ExtendToken ']'"|MiniDFA23_-1539532783
MiniDFA1_928821900 -->|"u"|MiniDFA2_-528271078
MiniDFA1_928821900 -->|"t
ExtendToken 'char'"|MiniDFA24_1900661343
MiniDFA1_928821900 -->|"n
ExtendToken 'char'"|MiniDFA25_274056698
MiniDFA1_928821900 -->|"r
ExtendToken 'char'"|MiniDFA26_842265739
MiniDFA1_928821900 -->|"-
ExtendToken 'char'"|MiniDFA27_-678579426
MiniDFA1_928821900 -->|"[
ExtendToken 'char'"|MiniDFA28_-919092941
MiniDFA1_928821900 -->|"#92;
ExtendToken 'char'"|MiniDFA29_-1732484616
MiniDFA1_928821900 -->|"]
ExtendToken 'char'"|MiniDFA30_1923459326
MiniDFA1_928821900 -->|"^
ExtendToken 'char'"|MiniDFA31_-1020973830
MiniDFA19_1638225134 -->|"*"|MiniDFA11_1928273863
MiniDFA19_1638225134 -->|"/
ExtendToken 'inlineComment'"|MiniDFA32_-884742192
MiniDFA22_-789683293 -->|"#92;
AcceptPrevious '['
BeginToken 'firstItem1'"|MiniDFA12_-1586440930
MiniDFA22_-789683293 -->|"[#32;-Z]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA33_1638846289
MiniDFA22_-789683293 -->|"[
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA34_735615519
MiniDFA22_-789683293 -->|"]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA35_-960754399
MiniDFA22_-789683293 -->|"[_-~]
AcceptPrevious '['
BeginToken 'firstItem1'
ExtendToken 'firstItem1'"|MiniDFA36_-1388926702
MiniDFA22_-789683293 -->|"^
ExtendToken '[^'"|MiniDFA37_1668393521
MiniDFA2_-528271078 -->|"[0-9]"|MiniDFA5_-418848687
MiniDFA11_1928273863 -->|"[^*]"|MiniDFA11_1928273863
MiniDFA11_1928273863 -->|"*"|MiniDFA13_-58615332
MiniDFA32_-884742192 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA38_-2007412343
MiniDFA12_-1586440930 -->|"u"|MiniDFA3_1920001639
MiniDFA12_-1586440930 -->|"t
ExtendToken 'firstItem1'"|MiniDFA39_-1413402411
MiniDFA12_-1586440930 -->|"n
ExtendToken 'firstItem1'"|MiniDFA40_1274647712
MiniDFA12_-1586440930 -->|"r
ExtendToken 'firstItem1'"|MiniDFA41_648126257
MiniDFA12_-1586440930 -->|"-
ExtendToken 'firstItem1'"|MiniDFA42_699688471
MiniDFA12_-1586440930 -->|"#92;
ExtendToken 'firstItem1'"|MiniDFA43_2069189802
MiniDFA12_-1586440930 -->|"^
ExtendToken 'firstItem1'"|MiniDFA44_-1534768809
MiniDFA37_1668393521 -->|"#92;
AcceptPrevious '[^'
BeginToken 'firstItem2'"|MiniDFA14_-1072034541
MiniDFA37_1668393521 -->|"[#32;-Z]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA45_602225456
MiniDFA37_1668393521 -->|"[
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA46_-1754287716
MiniDFA37_1668393521 -->|"]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA47_1524168998
MiniDFA37_1668393521 -->|"^
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA48_49247994
MiniDFA37_1668393521 -->|"[_-~]
AcceptPrevious '[^'
BeginToken 'firstItem2'
ExtendToken 'firstItem2'"|MiniDFA49_-1082548369
MiniDFA5_-418848687 -->|"[0-9]"|MiniDFA8_-1837822121
MiniDFA13_-58615332 -->|"[^/]"|MiniDFA11_1928273863
MiniDFA13_-58615332 -->|"/
ExtendToken 'blockComment'"|MiniDFA50_737786748
MiniDFA38_-2007412343 -->|"[#92;t#92;r#32;-~]
ExtendToken 'inlineComment'"|MiniDFA38_-2007412343
MiniDFA3_1920001639 -->|"[0-9]"|MiniDFA6_-1439188881
MiniDFA14_-1072034541 -->|"u"|MiniDFA4_647489505
MiniDFA14_-1072034541 -->|"t
ExtendToken 'firstItem2'"|MiniDFA51_1418159902
MiniDFA14_-1072034541 -->|"n
ExtendToken 'firstItem2'"|MiniDFA52_1734609358
MiniDFA14_-1072034541 -->|"r
ExtendToken 'firstItem2'"|MiniDFA53_1678115819
MiniDFA14_-1072034541 -->|"-
ExtendToken 'firstItem2'"|MiniDFA54_717060595
MiniDFA14_-1072034541 -->|"#92;
ExtendToken 'firstItem2'"|MiniDFA55_1411981931
MiniDFA14_-1072034541 -->|"^
ExtendToken 'firstItem2'"|MiniDFA56_-2086715468
MiniDFA8_-1837822121 -->|"[0-9]"|MiniDFA15_-326530136
MiniDFA6_-1439188881 -->|"[0-9]"|MiniDFA9_-2037670625
MiniDFA4_647489505 -->|"[0-9]"|MiniDFA7_-981845464
MiniDFA15_-326530136 -->|"[0-9]
ExtendToken 'char'"|MiniDFA57_-1805133534
MiniDFA9_-2037670625 -->|"[0-9]"|MiniDFA16_-885742503
MiniDFA7_-981845464 -->|"[0-9]"|MiniDFA10_673082317
MiniDFA16_-885742503 -->|"[0-9]
ExtendToken 'firstItem1'"|MiniDFA58_-1129008417
MiniDFA10_673082317 -->|"[0-9]"|MiniDFA17_1445658353
MiniDFA17_1445658353 -->|"[0-9]
ExtendToken 'firstItem2'"|MiniDFA59_1217907974

```

# 总结

无。

