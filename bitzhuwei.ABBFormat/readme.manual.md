﻿这个文法很简单，适宜拿来调试代码。

# 示例：构造LR1分析表

以下述文法为例：

```
A : A '+' B ;
A : 'a' ;
B : 'b' ;
```

这个文法可以推导出a，a+b，a+b+b之类的字符串。

它是左递归的，因而不能用LL分析。在LL分析中，`A : A '+' B ;`会使语法树向左下无限生长。

我们只能用LR分析。要构造LR分析表，我们需要先添加一个额外的产生式：

```
S : A ;
```

我们来手动构造DFA。

# 造表

第一个状态是`S : A ;`。

一个LR(1)项看起来长这样：`[A : α。β ; Vt]`。其中`Vt`是一个终结符（所谓的lookAhead），非终结符用`Vn`表示。`。`标志着我们现在的位置（已经读了α，正在找β）。

对后面的每一个状态，它只要依次考虑以下几点：

1. 我在哪？（`。`在哪？）

2. 我的闭包（Closure）是什么？

3. 我需要规约（Ruduce）吗？

4. 我需要转移（Shift）吗？

# State0

我们从`[S : 。A ; '¥']`开始，构造这个状态的闭包，也就是加上所有能从这个产生式推出的表项。

首先，我们看看，`。`后面是不是紧跟着一个`Vn`？是的，这个`。`后面跟着`A`。此时，我们要找出由`A : ...`推出的全部产生式，将它们加入闭包里。这加入了`[A : 。A '+' B ; '¥']`和`[A : 。'a' ; '¥']`。

然后，针对新加入的项，我们继续求闭包。在`[A : 。A '+' B ; '¥']`中，`。`在`A`前面，所以，我们在这里继续展开它，得到`[A : 。A '+' B ; '+']`和`[A : 。'a' ; '+']`。

然后，针对新加入的项，我们继续求闭包。这次，针对`。A '+'`，我们应当用另一个项来表达它引入的产生式，不过实际上这个项就是`[A : 。A '+' B ; '+']` ;所以并没有增加新的项。

这样，State0的闭包就求解完毕了。

现在State0包含的项有：

```
[S : 。A ; '¥']
[A : 。A '+' B ; '¥']
[A : 。'a' ; '¥']
[A : 。A '+' B ; '+']
[A : 。'a' ; '+']
```

下一步，就是为这个状态添加转移了。对于`。`后面紧随的每个符号（`Vn`或`Vt`），都可以从State0过渡到其他状态。看一下这5个项，共有`。A`和`。a`这两种情况。我们姑且把通过`A`转移到的状态称为State1，通过`a`转移到的状态称为State2。

# State1

先看看State1中出现了哪些项。我们从State0通过`A`转移到这里，所以我们找出State0中所有包含`。A`的项，这包括：

```
[S : 。A ; '¥']
[A : 。A '+' B ; '¥']
[A : 。A '+' B ; '+']
```

此时，将`。`向后移动一格，就得到了State1的项：

```
[S : A。 ; '¥']
[A : A。 '+' B ; '¥']
[A : A。 '+' B ; '+']
```

现在，求State1的闭包。由于不存在`。Vn`这样的项，所以这就是全部的项了。闭包求解完毕。

最后，从State1出发，可以去哪里呢？

在这个状态的`[S : A。 ; '¥']`中，`。`已经移动到了产生式尾部，因此我们应当用`S : A '¥';`这个规则来进行规约。除此之外，对每个前面有`。`的状态，都有对应转移出去的状态，这里就是`'+'`。我们姑且称通过`'+'`转移到了State3。

# State2

我们在State0通过`'a'`来到了State2。所以我们从State0中所有包含`。'a'`的项开始。

```
[A : 。'a' ; '¥']
[A : 。'a' ; '+']
```

将`。`后移得到：
```
[A : 'a'。 ; '¥']
[A : 'a'。 ; '+']
```

现在，`。`后面没有`Vn`了，因而State2的闭包也就求解完毕。

下面就是规约了。显然，此时应当根据`A : 'a' ;`这条规则进行规约。

最后，在State2的每一项中，`。`后面都没有符号了，因而State2是不转移到其他状态的。

# State3

如果我们在State1中遇到`'+'`，就会转移到State3。仿照处理State2的方法，我们先找出State1中所有符合要求的项。

```
[A : A。 '+' B ; '¥']
[A : A。 '+' B ; '+']
```

把`。`后移一格，得到：
```
[A : A '+'。 B ; '¥']
[A : A '+'。 B ; '+']
```

现在，`。`出现在了`B`前面，由于`B`是一个`Vn`，我们必须继续求State3的闭包。

先从`[A : A '+'。 B ; '¥']`开始，找出所有`B : ...`的产生式（注意，lookAhead是`'¥'`）。这会加入`[B  :  。'b' ; '¥']`。再对`[A : A '+'。 B ; '+']`做同样的操作，这会加入`[B  :  。'b' ; '+']`。新加入的项，不会推出新项。这样，闭包就完成了。

构造好的State3如下：

```
[A : A '+'。 B ; '¥']
[A : A '+'。 B ; '+']
[B  :  。'b' ; '¥']
[B  :  。'b' ; '+']
```

没有以`。`结束的产生式，因而不能规约。有`。B`和`。b`，因而有2个转移状态。我们姑且称通过`B`转移到State4，通过`b`转移到State5。

# State4

根据State3，对应的State4的项包括：

```
[A : A '+' B。 ; '¥']
[A : A '+' B。 ; '+']
```

现在，`。`之后没有`Vn`，这说明闭包已经完备。这个状态不能转移，但要规约，显然，我们应当用`A : A '+' B ;`这个规则来规约。

# State5

我们在State3中通过`b`来到State5。列出State3中对应的项：

```
[B  :  。'b' ; '¥']
[B  :  。'b' ; '+']
```

那么，State5中对应的项目包括:

```
[B  :  'b'。 ; '¥']
[B  :  'b'。 ; '+']
```

现在，`。`之后没有`Vn`，这说明闭包已经完备。这个状态不能转移，但要规约，显然，我们应当用`B : 'b' ;`这个规则来规约。

# 结果

现在，已经推导不出新的State了，DFA就完成了。根据我们的结果，可得LR分析表：

```
S : A ; // R[-1]
A : A '+' B ; // R[0]
A : 'a' ; // R[1]
B : 'b' ; // R[2]
```

|   状态  | 'a' | 'b' |  '+'  |  '¥'   | A | B |
|--------|-----|-----|------|--------|---|---|
| State0 | S2  |     |      |        | 1 |   |
| State1 |     |     | S3   | accept |   |   |
| State2 |     |     | R[1] | R[1]   |   |   |
| State3 |     | S5  |      |        |   | 4 |
| State4 |     |     | R[0] | R[0]   |   |   |
| State5 |     |     | R[2] | R[2]   |   |   |

# Compiler of `ABB`

The C# source code of the compiler `ABB` is generated by `bitzhuwei.GrammarFormat` at 2023-04-18 18:41:54.

# Grammar

```
// 3 VnRegulations:
A : A '+' B // [0]
  | 'a' ; // [1]
B : 'b' ; // [2]
// 0 VtRegex:

```

## Lexical Analyzer States

{To be continued..}

## FIRST

```
[0]: FIRST( A ) = { 'a' }
[1]: FIRST( B ) = { 'b' }
[2]: FIRST( '+' ) = { '+' }
[3]: FIRST( 'a' ) = { 'a' }
[4]: FIRST( 'b' ) = { 'b' }
[5]: FIRST( empty ) = { empty }
[6]: FIRST( A '+' B ) = { 'a' }

```

## FOLLOW

```
[0]: FOLLOW( A ) = { '+' }
[1]: FOLLOW( B ) = { '+' }

```

## LL(1) Syntax Machine

| 状态 | \'\+\' | \'a\' | \'b\' |
|:---:|:---:|:---:|:---:|
| A |   | R0 R1 |   |
| B |   |   | R2 |


## LR(0) Syntax Machine

| 状态 | \'\+\' | \'a\' | \'b\' | \'￥\' | A | B |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 |   | S2 |   |   | G1 |   |
| 1 | S3 |   |   | 完成 |   |   |
| 2 | R[1] | R[1] | R[1] | R[1] |   |   |
| 3 |   |   | S5 |   |   | G4 |
| 4 | R[0] | R[0] | R[0] | R[0] |   |   |
| 5 | R[2] | R[2] | R[2] | R[2] |   |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] BCounter> : • A ; 
[0] A : • A '+' B ; 
[1] A : • 'a' ; ")
syntaxState1("syntaxState1
[-1] BCounter> : A • ; 
[0] A : A • '+' B ; ")
syntaxState2("syntaxState2
[1] A : 'a' • ; ")
syntaxState3("syntaxState3
[0] A : A '+' • B ; 
[2] B : • 'b' ; ")
syntaxState4("syntaxState4
[0] A : A '+' B • ; ")
syntaxState5("syntaxState5
[2] B : 'b' • ; ")
syntaxState0 -.-> |"A"| syntaxState1
syntaxState0 --> |"'a'"| syntaxState2
syntaxState1 --> |"'#43;'"| syntaxState3
syntaxState3 -.-> |"B"| syntaxState4
syntaxState3 --> |"'b'"| syntaxState5
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'#43;' 'a' 'b' '￥' 
R[1]= A : 'a' ;"| syntaxState2
syntaxState4 x==x |"'#43;' 'a' 'b' '￥' 
R[0]= A : A '+' B ;"| syntaxState4
syntaxState5 x==x |"'#43;' 'a' 'b' '￥' 
R[2]= B : 'b' ;"| syntaxState5


```

## SLR(1) Syntax Machine

| 状态 | \'\+\' | \'a\' | \'b\' | \'￥\' | A | B |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 |   | S2 |   |   | G1 |   |
| 1 | S3 |   |   | 完成 |   |   |
| 2 | R[1] |   |   | R[1] |   |   |
| 3 |   |   | S5 |   |   | G4 |
| 4 | R[0] |   |   | R[0] |   |   |
| 5 | R[2] |   |   |   |   |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] BCounter> : • A ; 
[0] A : • A '+' B ; 
[1] A : • 'a' ; ")
syntaxState1("syntaxState1
[-1] BCounter> : A • ; 
[0] A : A • '+' B ; ")
syntaxState2("syntaxState2
[1] A : 'a' • ; ")
syntaxState3("syntaxState3
[0] A : A '+' • B ; 
[2] B : • 'b' ; ")
syntaxState4("syntaxState4
[0] A : A '+' B • ; ")
syntaxState5("syntaxState5
[2] B : 'b' • ; ")
syntaxState0 -.-> |"A"| syntaxState1
syntaxState0 --> |"'a'"| syntaxState2
syntaxState1 --> |"'#43;'"| syntaxState3
syntaxState3 -.-> |"B"| syntaxState4
syntaxState3 --> |"'b'"| syntaxState5
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'#43;' '￥' 
R[1]= A : 'a' ;"| syntaxState2
syntaxState4 x==x |"'#43;' '￥' 
R[0]= A : A '+' B ;"| syntaxState4
syntaxState5 x==x |"'#43;' 
R[2]= B : 'b' ;"| syntaxState5


```

## LALR(1) Syntax Machine

| 状态 | \'\+\' | \'a\' | \'b\' | \'￥\' | A | B |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 |   | S2 |   |   | G1 |   |
| 1 | S3 |   |   | 完成 |   |   |
| 2 | R[1] |   |   | R[1] |   |   |
| 3 |   |   | S5 |   |   | G4 |
| 4 | R[0] |   |   | R[0] |   |   |
| 5 | R[2] |   |   | R[2] |   |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] BCounter> : • A ; '￥' 
[0] A : • A '+' B ; '￥' '+' 
[1] A : • 'a' ; '￥' '+' ")
syntaxState1("syntaxState1
[-1] BCounter> : A • ; '￥' 
[0] A : A • '+' B ; '￥' '+' ")
syntaxState2("syntaxState2
[1] A : 'a' • ; '￥' '+' ")
syntaxState3("syntaxState3
[0] A : A '+' • B ; '￥' '+' 
[2] B : • 'b' ; '￥' '+' ")
syntaxState4("syntaxState4
[0] A : A '+' B • ; '￥' '+' ")
syntaxState5("syntaxState5
[2] B : 'b' • ; '￥' '+' ")
syntaxState0 -.-> |"A"| syntaxState1
syntaxState0 --> |"'a'"| syntaxState2
syntaxState1 --> |"'#43;'"| syntaxState3
syntaxState3 -.-> |"B"| syntaxState4
syntaxState3 --> |"'b'"| syntaxState5
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'￥' '#43;' 
R[1]= A : 'a' ;"| syntaxState2
syntaxState4 x==x |"'￥' '#43;' 
R[0]= A : A '+' B ;"| syntaxState4
syntaxState5 x==x |"'￥' '#43;' 
R[2]= B : 'b' ;"| syntaxState5


```

## LR(1) Syntax Machine

| 状态 | \'\+\' | \'a\' | \'b\' | \'￥\' | A | B |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 |   | S2 |   |   | G1 |   |
| 1 | S3 |   |   | 完成 |   |   |
| 2 | R[1] |   |   | R[1] |   |   |
| 3 |   |   | S5 |   |   | G4 |
| 4 | R[0] |   |   | R[0] |   |   |
| 5 | R[2] |   |   | R[2] |   |   |


```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
syntaxState0("syntaxState0
[-1] BCounter> : • A ; '￥' 
[0] A : • A '+' B ; '￥' '+' 
[1] A : • 'a' ; '￥' '+' ")
syntaxState1("syntaxState1
[-1] BCounter> : A • ; '￥' 
[0] A : A • '+' B ; '￥' '+' ")
syntaxState2("syntaxState2
[1] A : 'a' • ; '￥' '+' ")
syntaxState3("syntaxState3
[0] A : A '+' • B ; '￥' '+' 
[2] B : • 'b' ; '￥' '+' ")
syntaxState4("syntaxState4
[0] A : A '+' B • ; '￥' '+' ")
syntaxState5("syntaxState5
[2] B : 'b' • ; '￥' '+' ")
syntaxState0 -.-> |"A"| syntaxState1
syntaxState0 --> |"'a'"| syntaxState2
syntaxState1 --> |"'#43;'"| syntaxState3
syntaxState3 -.-> |"B"| syntaxState4
syntaxState3 --> |"'b'"| syntaxState5
syntaxState1 o--o |"'￥'"| syntaxState1
syntaxState2 x==x |"'￥' '#43;' 
R[1]= A : 'a' ;"| syntaxState2
syntaxState4 x==x |"'￥' '#43;' 
R[0]= A : A '+' B ;"| syntaxState4
syntaxState5 x==x |"'￥' '#43;' 
R[2]= B : 'b' ;"| syntaxState5


```

# End


