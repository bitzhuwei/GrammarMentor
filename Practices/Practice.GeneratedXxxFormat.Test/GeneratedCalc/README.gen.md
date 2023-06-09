# Compiler of `Calc`

The C# source code of the compiler `Calc` is generated by `bitzhuwei.GrammarFormat`.

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
// 8 VnRegulations:
Additive : Additive '+' Multiplicative // [0]
         | Additive '-' Multiplicative // [1]
         | Multiplicative ; // [2]
Multiplicative : Multiplicative '*' Primary // [3]
               | Multiplicative '/' Primary // [4]
               | Primary ; // [5]
Primary : '(' Additive ')' // [6]
        | 'number' ; // [7]
// 1 VtPatterns:
'number' : %%[0-9]+%% ; // [0]

```

# End

