# ��`��������`Ϊ��

## `��������`���ķ�

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
## �ķ��漰�ĸ���

![�ķ��漰�ĸ���](Grammar.jpg)

## `��������`���ķ�������ʽ���飩

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

# �ķ�����`Grammar`��

## `Grammar`���ķ�

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

ʵ�ֱ������ı�����`bitzhuwei.GrammarFormat.CompilerGrammar`�Ĳ��裬�������£�

1. �������򵥵��ķ�������`��������`�ȣ�ʾ����

2. ���ݱ���ԭ�����ۣ��ֶ���д��Щʾ���ķ��ı�������

3. ���ݶ����ӵ���ᣬ���մʷ�������`LexiAnalyzer`���﷨������`SyntaxParser`��������ȡ��`TExtracter`��һ����������������ͨ�õĻ������`bitzhuwei.Compiler.dll`��

4. ����һ����ʵ�������ϣ�������ķ�����`Grammar`�����ķ���

5. ���ݱ���ԭ�����ۣ��ֶ���д`Grammar`�ı���������`class CompilerGrammar { ... }`����

6. ��`CompilerGrammar`��������ݽṹ����`Regulation[]`�������ݱ���ԭ�����ۣ�ʵ������㷨������LR1�FIRST����FOLLOW����LR1������ȣ���

7. �������㷨����`Regulation[]`ת��Ϊ��������C#Դ���롣�����һ���Զ����ɡ�

8. ��1.�е�ʾ���ķ���֤��һ���Զ����ɵı�����Դ���룬�Ƿ���2.���ֶ���д��Դ������ͬ��

9. ��`Grammar`�ķ���һ���Զ�����`Grammar`�ķ��ı�����`CompilerGrammar`��

## `Grammar`��ע������

> `'Identifier'`��`'String'`�����ݲ�����ͬ���𣿣�

## `Grammar`���ķ�������ʽ���飩

```
<StatementList>    ::= <StatementList> <Statement> | <Statement> ;
<Statement>        ::= <SyntaxProduction> | <LexiProduction> ;
<SyntaxProduction> ::= "Identifier" ":" <CandidateList> ";" ;
<CandidateList>    ::= <CandidateList> "|" <Candidate> | <Candidate> ;
<Candidate>        ::= <Candidate> <V> | <V> ;
<V>                ::= "Identifier" | "String" | "null" ; // V is Vn or Vt
<LexiProduction>   ::= "String" ":" "RegularExpresion" ";" ;
```


