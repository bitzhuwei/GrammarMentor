# Compiler of `SES`

The C# source code of the compiler `SES` is generated by `bitzhuwei.GrammarFormat`.

# Grammar

[Lexical Analyzer States](doc/LexicalStates.md)

[FIRST & FOLLOW](doc/FIRST-FOLLOW.md)

[LL(1) Syntax Machine](doc/SyntaxMachineLL(1).md)

[LR(0) Syntax Machine](doc/SyntaxMachineLR(0).md)

[SLR(1) Syntax Machine](doc/SyntaxMachineSLR(1).md)

[LALR(1) Syntax Machine](doc/SyntaxMachineLALR(1).md)

[LR(1) Syntax Machine](doc/SyntaxMachineLR(1).md)

The grammar is as follows:

```
// 7 VnRegulations:
S : N V N ; // [0]
N : 's' // [1]
  | 't' // [2]
  | 'g' // [3]
  | 'w' ; // [4]
V : 'e' // [5]
  | 'd' ; // [6]
// 0 VtPatterns:

```

# End

