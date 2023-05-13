# 注意

在DFA和MiniDFA文件夹中选择一个使用。

# `{GrammarName}`的词法分析器（Analyzer）

词法分析的原理是状态机（State Machine）。词法分析的过程就是：看第一个`char`是什么，就能判定它和它后面若干个`char`可能组成哪一类或哪几类的`Token`；然后一个`char`一个`char`地拼接出这个`Token`来。这时候指针（`Cursor`）就指到了下一个`Token`的第一个`char`，重复上述过程。

词法分析的作用可以和计算机网络7层协议里的数据链路层的作用类比。数据链路层把可能出错的物理层的数据打包成一个个不会有错的`数据报`，供上层协议继续分析。词法分析器将纯字符串的源代码变成一个个具有顺序、类型和内容的`Token`，减轻了语法分析的复杂性。

下面各图是状态机的各个部分。它们合在一起就是Analyzer的核心——总状态机（{LexicalStateCount}个State）。

{VtRegexList}

# 总状态机

## 1/5: extracted ε-NFA

```Mermaid
{extracted ε-NFA}
```

## 2/5: completed ε-NFA

```Mermaid
{completed ε-NFA}
```

## 3/5: NFA

```Mermaid
{NFA}
```

## 4/5: DFA

```Mermaid
{DFA}
```

## 4/5: DFA.simple

```Mermaid
{DFA.simple}
```

## 5/5: miniDFA

```Mermaid
{miniDFA}
```
## 5/5: miniDFA.simple

```Mermaid
{miniDFA.simple}
```

# 总结

无。

