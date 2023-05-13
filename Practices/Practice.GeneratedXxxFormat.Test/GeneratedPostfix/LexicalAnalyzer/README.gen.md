# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `Postfix`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（4个State）。

## 'entityId'
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
eNFA0_2_44720408[["εNFA0-2 regex start"]]
eNFA0_0_37080284[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_4120031[["εNFA0-1 scope[1]"]]
eNFA0_3_65287100[["εNFA0-3 regex end"]]
eNFA0_2_44720408 -.->|"ε"|eNFA0_0_37080284
eNFA0_0_37080284 -->|"[0-9]"|eNFA0_1_4120031
eNFA0_1_4120031 -->|"[0-9]"|eNFA0_1_4120031
eNFA0_1_4120031 -.->|"ε"|eNFA0_3_65287100
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
eNFA0_6_10648106[["εNFA0-6 regex start"]]
eNFA0_4_28724090[["εNFA0-4 char{1, 1}"]]
eNFA0_5_57190219[["εNFA0-5 char[1]"]]
eNFA0_7_44949926[\"εNFA0-7 regex end"/]
eNFA0_6_10648106 -.->|"ε"|eNFA0_4_28724090
eNFA0_4_28724090 -->|"="|eNFA0_5_57190219
eNFA0_5_57190219 -.->|"ε"|eNFA0_7_44949926
```


## 'refEntity'
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
eNFA0_2_41344766[["εNFA0-2 regex start"]]
eNFA0_0_14111849[["εNFA0-0 scope{1, ∞}"]]
eNFA0_1_53763766[["εNFA0-1 scope[1]"]]
eNFA0_3_59897780[["εNFA0-3 regex end"]]
eNFA0_2_41344766 -.->|"ε"|eNFA0_0_14111849
eNFA0_0_14111849 -->|"[0-9]"|eNFA0_1_53763766
eNFA0_1_53763766 -->|"[0-9]"|eNFA0_1_53763766
eNFA0_1_53763766 -.->|"ε"|eNFA0_3_59897780
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
eNFA0_4_8985243[["εNFA0-4 post-regex start"]]
eNFA0_5_13758331[\"εNFA0-5 post-regex end"/]
eNFA0_4_8985243 -.->|"ε"|eNFA0_5_13758331
```


## '='
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
eNFA0_2_50976574[["εNFA0-2 regex start"]]
eNFA0_0_56135986[["εNFA0-0 char{1, 1}"]]
eNFA0_1_35461828[["εNFA0-1 char[1]"]]
eNFA0_3_50720997[["εNFA0-3 regex end"]]
eNFA0_2_50976574 -.->|"ε"|eNFA0_0_56135986
eNFA0_0_56135986 -->|"="|eNFA0_1_35461828
eNFA0_1_35461828 -.->|"ε"|eNFA0_3_50720997
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
eNFA0_4_53835790[["εNFA0-4 post-regex start"]]
eNFA0_5_14760064[\"εNFA0-5 post-regex end"/]
eNFA0_4_53835790 -.->|"ε"|eNFA0_5_14760064
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
eNFA0_0_31040546[["εNFA0-0 wholeStart"]]
eNFA1_2_28025373[["εNFA1-2 regex start"]]
class eNFA1_2_28025373 c1000;
eNFA2_2_10929460[["εNFA2-2 regex start"]]
class eNFA2_2_10929460 c1000;
eNFA3_2_35926676[["εNFA3-2 regex start"]]
class eNFA3_2_35926676 c1000;
eNFA1_0_63312333[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_26895360[["εNFA2-0 scope{1, ∞}"]]
eNFA3_0_24379667[["εNFA3-0 char{1, 1}"]]
eNFA1_1_36860865[["εNFA1-1 scope[1]"]]
eNFA2_1_32814535[["εNFA2-1 scope[1]"]]
eNFA3_1_18090414[["εNFA3-1 char[1]"]]
eNFA1_3_32940092[["εNFA1-3 regex end"]]
class eNFA1_3_32940092 c0100;
eNFA2_3_40731651[["εNFA2-3 regex end"]]
class eNFA2_3_40731651 c0100;
eNFA3_3_28596006[["εNFA3-3 regex end"]]
class eNFA3_3_28596006 c0100;
eNFA1_6_50901771[["εNFA1-6 regex start"]]
class eNFA1_6_50901771 c0010;
eNFA2_4_48731095[["εNFA2-4 post-regex start"]]
class eNFA2_4_48731095 c0010;
eNFA3_4_56037467[["εNFA3-4 post-regex start"]]
class eNFA3_4_56037467 c0010;
eNFA1_4_55462758[["εNFA1-4 char{1, 1}"]]
eNFA2_5_31256284[\"εNFA2-5 post-regex end"/]
class eNFA2_5_31256284 c0001;
eNFA3_5_54904635[\"εNFA3-5 post-regex end"/]
class eNFA3_5_54904635 c0001;
eNFA1_5_29402775[["εNFA1-5 char[1]"]]
eNFA0_1_12871106[\"εNFA0-1 wholeEnd"/]
eNFA1_7_63298383[\"εNFA1-7 regex end"/]
class eNFA1_7_63298383 c0001;
eNFA0_0_31040546 -.->|"ε"|eNFA1_2_28025373
eNFA0_0_31040546 -.->|"ε"|eNFA2_2_10929460
eNFA0_0_31040546 -.->|"ε"|eNFA3_2_35926676
eNFA1_2_28025373 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_63312333
eNFA2_2_10929460 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_26895360
eNFA3_2_35926676 -.->|"ε
BeginToken '='"|eNFA3_0_24379667
eNFA1_0_63312333 -->|"[0-9]"|eNFA1_1_36860865
eNFA2_0_26895360 -->|"[0-9]"|eNFA2_1_32814535
eNFA3_0_24379667 -->|"="|eNFA3_1_18090414
eNFA1_1_36860865 -->|"[0-9]"|eNFA1_1_36860865
eNFA1_1_36860865 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_32940092
eNFA2_1_32814535 -->|"[0-9]"|eNFA2_1_32814535
eNFA2_1_32814535 -.->|"ε
ExtendToken 'refEntity'"|eNFA2_3_40731651
eNFA3_1_18090414 -.->|"ε
ExtendToken '='"|eNFA3_3_28596006
eNFA1_3_32940092 -.->|"ε"|eNFA1_6_50901771
eNFA2_3_40731651 -.->|"ε"|eNFA2_4_48731095
eNFA3_3_28596006 -.->|"ε"|eNFA3_4_56037467
eNFA1_6_50901771 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_55462758
eNFA2_4_48731095 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_31256284
eNFA3_4_56037467 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_54904635
eNFA1_4_55462758 -->|"="|eNFA1_5_29402775
eNFA2_5_31256284 -.->|"ε"|eNFA0_1_12871106
eNFA3_5_54904635 -.->|"ε"|eNFA0_1_12871106
eNFA1_5_29402775 -.->|"ε
AcceptToken 'entityId'"|eNFA1_7_63298383
eNFA1_7_63298383 -.->|"ε"|eNFA0_1_12871106

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
eNFA0_0_34575158[["εNFA0-0 wholeStart"]]
class eNFA0_0_34575158 c1000;
eNFA1_2_49124394[["εNFA1-2 regex start"]]
class eNFA1_2_49124394 c1000;
eNFA2_2_42740968[["εNFA2-2 regex start"]]
class eNFA2_2_42740968 c1000;
eNFA3_2_39466365[["εNFA3-2 regex start"]]
class eNFA3_2_39466365 c1000;
eNFA1_0_42659011[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_42659011 c1000;
eNFA2_0_27015409[["εNFA2-0 scope{1, ∞}"]]
class eNFA2_0_27015409 c1000;
eNFA3_0_5451181[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_5451181 c1000;
eNFA1_1_19652971[["εNFA1-1 scope[1]"]]
class eNFA1_1_19652971 c0110;
eNFA2_1_32827873[\"εNFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class eNFA2_1_32827873 c0111;
eNFA3_1_49060634[\"εNFA3-1 char[1]
AcceptToken '='"/]
class eNFA3_1_49060634 c0111;
eNFA1_3_48386784[["εNFA1-3 regex end"]]
class eNFA1_3_48386784 c0110;
eNFA1_6_27402849[["εNFA1-6 regex start"]]
class eNFA1_6_27402849 c0010;
eNFA1_4_45299056[["εNFA1-4 char{1, 1}"]]
class eNFA1_4_45299056 c0010;
eNFA1_5_5038325[\"εNFA1-5 char[1]
AcceptToken 'entityId'"/]
class eNFA1_5_5038325 c0001;
eNFA2_3_41812096[\"εNFA2-3 regex end
AcceptToken 'refEntity'"/]
class eNFA2_3_41812096 c0111;
eNFA2_4_45344929[\"εNFA2-4 post-regex start
AcceptToken 'refEntity'"/]
class eNFA2_4_45344929 c0011;
eNFA2_5_13594378[\"εNFA2-5 post-regex end"/]
class eNFA2_5_13594378 c0011;
eNFA0_1_31336648[\"εNFA0-1 wholeEnd"/]
eNFA3_3_38892530[\"εNFA3-3 regex end
AcceptToken '='"/]
class eNFA3_3_38892530 c0111;
eNFA3_4_14488452[\"εNFA3-4 post-regex start
AcceptToken '='"/]
class eNFA3_4_14488452 c0011;
eNFA3_5_40764552[\"εNFA3-5 post-regex end"/]
class eNFA3_5_40764552 c0011;
eNFA1_7_55240544[\"εNFA1-7 regex end"/]
class eNFA1_7_55240544 c0001;
eNFA0_0_34575158 -.->|"ε"|eNFA1_2_49124394
eNFA0_0_34575158 -.->|"ε"|eNFA2_2_42740968
eNFA0_0_34575158 -.->|"ε"|eNFA3_2_39466365
eNFA0_0_34575158 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_42659011
eNFA0_0_34575158 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_27015409
eNFA0_0_34575158 -.->|"ε
BeginToken '='"|eNFA3_0_5451181
eNFA0_0_34575158 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_19652971
eNFA0_0_34575158 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_32827873
eNFA0_0_34575158 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_49060634
eNFA1_2_49124394 -.->|"ε
BeginToken 'entityId'"|eNFA1_0_42659011
eNFA1_2_49124394 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_19652971
eNFA2_2_42740968 -.->|"ε
BeginToken 'refEntity'"|eNFA2_0_27015409
eNFA2_2_42740968 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_32827873
eNFA3_2_39466365 -.->|"ε
BeginToken '='"|eNFA3_0_5451181
eNFA3_2_39466365 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_49060634
eNFA1_0_42659011 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|eNFA1_1_19652971
eNFA2_0_27015409 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|eNFA2_1_32827873
eNFA3_0_5451181 -->|"=
BeginToken '='
ExtendToken '='"|eNFA3_1_49060634
eNFA1_1_19652971 -->|"[0-9]
ExtendToken 'entityId'"|eNFA1_1_19652971
eNFA1_1_19652971 -.->|"ε
ExtendToken 'entityId'"|eNFA1_3_48386784
eNFA1_1_19652971 -.->|"ε"|eNFA1_6_27402849
eNFA1_1_19652971 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_45299056
eNFA1_1_19652971 -->|"=
CheckToken 'entityId'"|eNFA1_5_5038325
eNFA2_1_32827873 -->|"[0-9]
ExtendToken 'refEntity'"|eNFA2_1_32827873
eNFA2_1_32827873 -.->|"ε
ExtendToken 'refEntity'"|eNFA2_3_41812096
eNFA2_1_32827873 -.->|"ε"|eNFA2_4_45344929
eNFA2_1_32827873 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_13594378
eNFA2_1_32827873 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_31336648
eNFA3_1_49060634 -.->|"ε
ExtendToken '='"|eNFA3_3_38892530
eNFA3_1_49060634 -.->|"ε"|eNFA3_4_14488452
eNFA3_1_49060634 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_40764552
eNFA3_1_49060634 -.->|"ε
CheckToken '='"|eNFA0_1_31336648
eNFA1_3_48386784 -.->|"ε"|eNFA1_6_27402849
eNFA1_3_48386784 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_45299056
eNFA1_3_48386784 -->|"=
CheckToken 'entityId'"|eNFA1_5_5038325
eNFA1_6_27402849 -.->|"ε
CheckToken 'entityId'"|eNFA1_4_45299056
eNFA1_6_27402849 -->|"=
CheckToken 'entityId'"|eNFA1_5_5038325
eNFA1_4_45299056 -->|"=
CheckToken 'entityId'"|eNFA1_5_5038325
eNFA1_5_5038325 -.->|"ε
AcceptToken 'entityId'"|eNFA1_7_55240544
eNFA1_5_5038325 -.->|"ε"|eNFA0_1_31336648
eNFA2_3_41812096 -.->|"ε"|eNFA2_4_45344929
eNFA2_3_41812096 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_13594378
eNFA2_3_41812096 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_31336648
eNFA2_4_45344929 -.->|"ε
CheckToken 'refEntity'
AcceptToken 'refEntity'"|eNFA2_5_13594378
eNFA2_4_45344929 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_31336648
eNFA2_5_13594378 -.->|"ε
CheckToken 'refEntity'"|eNFA0_1_31336648
eNFA3_3_38892530 -.->|"ε"|eNFA3_4_14488452
eNFA3_3_38892530 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_40764552
eNFA3_3_38892530 -.->|"ε
CheckToken '='"|eNFA0_1_31336648
eNFA3_4_14488452 -.->|"ε
CheckToken '='
AcceptToken '='"|eNFA3_5_40764552
eNFA3_4_14488452 -.->|"ε
CheckToken '='"|eNFA0_1_31336648
eNFA3_5_40764552 -.->|"ε
CheckToken '='"|eNFA0_1_31336648
eNFA1_7_55240544 -.->|"ε"|eNFA0_1_31336648

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
NFA0_0_63287211("NFA0-0 wholeStart")
class NFA0_0_63287211 c1000;
NFA1_1_32713991("NFA1-1 scope[1]")
class NFA1_1_32713991 c0110;
NFA2_1_25990465[\"NFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA2_1_25990465 c0101;
NFA3_1_32587594[\"NFA3-1 char[1]
AcceptToken '='"/]
class NFA3_1_32587594 c0101;
NFA1_5_24852891[\"NFA1-5 char[1]
AcceptToken 'entityId'"/]
class NFA1_5_24852891 c0001;
NFA0_0_63287211 -->|"[0-9]
BeginToken 'entityId'
ExtendToken 'entityId'"|NFA1_1_32713991
NFA0_0_63287211 -->|"[0-9]
BeginToken 'refEntity'
ExtendToken 'refEntity'"|NFA2_1_25990465
NFA0_0_63287211 -->|"=
BeginToken '='
ExtendToken '='"|NFA3_1_32587594
NFA1_1_32713991 -->|"[0-9]
ExtendToken 'entityId'"|NFA1_1_32713991
NFA1_1_32713991 -->|"=
CheckToken 'entityId'"|NFA1_5_24852891
NFA2_1_25990465 -->|"[0-9]
ExtendToken 'refEntity'"|NFA2_1_25990465

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
subgraph DFA0_-1191917276["DFA0 wholeStart"]
NFA0_0_63287211_0("NFA0-0 wholeStart")
class NFA0_0_63287211_0 c1000;
end
class DFA0_-1191917276 c1000;
subgraph DFA1_635551321["DFA1 {2}"]
NFA1_1_32713991_1("NFA1-1 scope[1]")
class NFA1_1_32713991_1 c0110;
NFA2_1_25990465_2[\"NFA2-1 scope[1]
AcceptToken 'refEntity'"/]
class NFA2_1_25990465_2 c0101;
end
class DFA1_635551321 c0111;
subgraph DFA2_-740525413["DFA2 {1}"]
NFA3_1_32587594_3[\"NFA3-1 char[1]
AcceptToken '='"/]
class NFA3_1_32587594_3 c0101;
end
class DFA2_-740525413 c0101;
subgraph DFA3_-374645365["DFA3 {1}"]
NFA1_5_24852891_4[\"NFA1-5 char[1]
AcceptToken 'entityId'"/]
class NFA1_5_24852891_4 c0001;
end
class DFA3_-374645365 c0001;
DFA0_-1191917276 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|DFA1_635551321
DFA0_-1191917276 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-740525413
DFA1_635551321 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|DFA1_635551321
DFA1_635551321 -->|"=
CheckToken 'entityId'"|DFA3_-374645365

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
DFA0_-1191917276{{"DFA0 wholeStart"}}
class DFA0_-1191917276 c1000;
DFA1_635551321[\"DFA1 {2}
AcceptToken 'refEntity'"/]
class DFA1_635551321 c0111;
DFA2_-740525413[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-740525413 c0101;
DFA3_-374645365[\"DFA3 {1}
AcceptToken 'entityId'"/]
class DFA3_-374645365 c0001;
DFA0_-1191917276 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|DFA1_635551321
DFA0_-1191917276 -->|"=
BeginToken '='
ExtendToken '='"|DFA2_-740525413
DFA1_635551321 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|DFA1_635551321
DFA1_635551321 -->|"=
CheckToken 'entityId'"|DFA3_-374645365

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
subgraph MiniDFA0_311938007["MiniDFA0 {1}"]
DFA0_-1191917276_0{{"DFA0 wholeStart"}}
class DFA0_-1191917276_0 c1000;
end
class MiniDFA0_311938007 c1000;
subgraph MiniDFA1_-1890775779["MiniDFA1 {1}"]
DFA1_635551321_1[\"DFA1 {2}
AcceptToken 'refEntity'"/]
class DFA1_635551321_1 c0111;
end
class MiniDFA1_-1890775779 c0111;
subgraph MiniDFA2_-954786735["MiniDFA2 {1}"]
DFA2_-740525413_2[\"DFA2 {1}
AcceptToken '='"/]
class DFA2_-740525413_2 c0101;
end
class MiniDFA2_-954786735 c0101;
subgraph MiniDFA3_-21938112["MiniDFA3 {1}"]
DFA3_-374645365_3[\"DFA3 {1}
AcceptToken 'entityId'"/]
class DFA3_-374645365_3 c0001;
end
class MiniDFA3_-21938112 c0001;
MiniDFA0_311938007 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|MiniDFA1_-1890775779
MiniDFA0_311938007 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA2_-954786735
MiniDFA1_-1890775779 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|MiniDFA1_-1890775779
MiniDFA1_-1890775779 -->|"=
CheckToken 'entityId'"|MiniDFA3_-21938112

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
MiniDFA0_311938007(["MiniDFA0 {1}"])
class MiniDFA0_311938007 c1000;
MiniDFA1_-1890775779[\"MiniDFA1 {1}
AcceptToken 'refEntity'"/]
class MiniDFA1_-1890775779 c0111;
MiniDFA2_-954786735[\"MiniDFA2 {1}
AcceptToken '='"/]
class MiniDFA2_-954786735 c0101;
MiniDFA3_-21938112[\"MiniDFA3 {1}
AcceptToken 'entityId'"/]
class MiniDFA3_-21938112 c0001;
MiniDFA0_311938007 -->|"[0-9]
BeginToken 'entityId''refEntity'
ExtendToken 'entityId''refEntity'"|MiniDFA1_-1890775779
MiniDFA0_311938007 -->|"=
BeginToken '='
ExtendToken '='"|MiniDFA2_-954786735
MiniDFA1_-1890775779 -->|"[0-9]
ExtendToken 'entityId''refEntity'"|MiniDFA1_-1890775779
MiniDFA1_-1890775779 -->|"=
CheckToken 'entityId'"|MiniDFA3_-21938112

```

# 总结

无。

