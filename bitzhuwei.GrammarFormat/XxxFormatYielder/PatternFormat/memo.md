﻿一般来说，比较高性能的DFA的实现是一张二维的表。行代表字符，列代表DFA的状态，单元格代表该状态经输入某个字符之后进行转移的目标状态。此外还有一张表用来记录哪些状态对应哪些规则的结束状态。笔者的词法分析器是基于UTF-16编码的字符串，一张表一共有65535行显然是不现实的，因此还有另一张表把字符转换成字符类。字符类是这样定义的：假设现在已经存在了65535行的一张大表，如果在某个字符区间所对应的子表内，任意一列的单元格的数据都一样的话，那么这个区间内的所有字符就可以被视为是等价的，这些字符就属于同一个字符类。于是仅需要另外一张65535个单元的表用来把一个字符映射到字符类。这种做法可以大大的压缩DFA所需要的空间。在笔者的程序里，识别字符类的算法被融入了DFA的构造算法中

deterministic finite automation
确定有穷自动机
deterministic finite automaton
确定性有限自动机
nondeterministic finite automaton
非确定性有限自动机
