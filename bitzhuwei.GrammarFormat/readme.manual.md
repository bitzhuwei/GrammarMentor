# 以`四则运算`为例

## `四则运算`的文法

```
//-----------Syntax Statements----------------
Additive              : Additive '+' Multiplicative 
                      | Additive '-' Multiplicative 
                      | Multiplicative ;
Multiplicative        : Multiplicative '*' Primary 
                      | Multiplicative '/' Primary 
                      | Primary ;
Primary               : '(' Additive ')' 
                      | 'number' ;
//------------Lexi Statements-----------------
'+'                   : %+% ; // totally omissible
'-'                   : %-% ; // totally omissible
'*'                   : %*% ; // totally omissible
'/'                   : %/% ; // totally omissible
'('                   : %(% ; // totally omissible
')'                   : %)% ; // totally omissible
// if 'number' is not specified as follows, 
// its literal meaning will be applied to 
// the lexical analyzer code just like above cases.
'number'              : %[+-]?[0-9]+([.][0-9]+)?% ;
'MultipleLineComment' : %"/*".*"*/"% ; // omissible
'SingleLineComment'   : %"//".*% ; // omissible
```
## 文法涉及的概念

![文法涉及的概念](Grammar.jpg)

## `四则运算`的文法（旧样式备查）

```
<Additive>       ::= <Additive> "+" <Multiplicative> 
                 | <Additive> "-" <Multiplicative> 
                 | <Multiplicative> ;
<Multiplicative> ::= <Multiplicative> "*" <Primary> 
                 | <Multiplicative> "/" <Primary> 
                 | <Primary> ;
<Primary>        ::= identifier 
                 | "(" <Additive> ")" 
                 | number ;
```

# 文法（即`Grammar`）

## `Grammar`的文法

```
//-------------Syntax Statements-----------------
StatementList         : StatementList Statement | Statement ;
Statement             : SyntaxProduction | LexiProduction ;
SyntaxProduction      : 'Identifier' ':' CandidateList ';' ;
CandidateList         : CandidateList '|' Candidate | Candidate ;
Candidate             : Candidate V | V ;
V                     : 'Identifier' | 'String' | 'empty' ; // V is Vn or Vt or the keyword(null).
LexiProduction        : 'String' ':' 'RegularExpresion' ';' ;
//--------------Lexi Statements------------------
':'                   : %%:%% ;
';'                   : %%;%% ;
'|'                   : %%|%% ;
'Identifier'          : %%[a-zA-Z_][a-zA-Z0-9_]*%% ;
'String'              : %%'[a-zA-Z_][a-zA-Z0-9_]*'%% ;
'empty'               : %%empty%% ;
'RegularExpresion'    : %%[%][%][.]+[%][%]%% ;
'MultipleLineComment' : %%/[*].*[*]/"%% ; // omissible
'SingleLineComment'   : %%//.*%% ; // omissible
```

实现编译器的编译器`bitzhuwei.GrammarFormat.CompilerGrammar`的步骤，简述如下：

1. 做几个简单的文法（例如`四则运算`等）示例。

2. 根据编译原理理论，手动编写这些示例文法的编译器。

3. 根据对例子的体会，掌握词法分析器`LexiAnalyzer`、语法分析器`SyntaxParser`、内容提取器`TExtracter`的一般规则，整理出编译器通用的基础类库`bitzhuwei.Compiler.dll`。

4. 在上一步的实践基础上，整理出文法（即`Grammar`）的文法。

5. 根据编译原理理论，手动编写`Grammar`的编译器（即`class CompilerGrammar { ... }`）。

6. 用`CompilerGrammar`输出的数据结构（即`Regulation[]`），根据编译原理理论，实现相关算法（计算LR1项、FIRST集、FOLLOW集、LR1分析表等）。

7. 用上述算法，将`Regulation[]`转化为编译器的C#源代码。（★☆一键自动生成☆★）

8. 用1.中的示例文法验证，一键自动生成的编译器源代码，是否与2.中手动编写的源代码相同。

9. 用`Grammar`文法，一键自动生成`Grammar`文法的编译器`CompilerGrammar`。

## `Grammar`的注意事项

> `'Identifier'`和`'String'`的内容不可相同（吗？）

## `Grammar`的文法（旧样式备查）

```
<StatementList>    ::= <StatementList> <Statement> | <Statement> ;
<Statement>        ::= <SyntaxProduction> | <LexiProduction> ;
<SyntaxProduction> ::= "Identifier" ":" <CandidateList> ";" ;
<CandidateList>    ::= <CandidateList> "|" <Candidate> | <Candidate> ;
<Candidate>        ::= <Candidate> <V> | <V> ;
<V>                ::= "Identifier" | "String" | "null" ; // V is Vn or Vt
<LexiProduction>   ::= "String" ":" "RegularExpresion" ";" ;
```


