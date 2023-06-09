# Compiler of `Numbers`

The C# source code of the compiler `Numbers` is generated by `bitzhuwei.GrammarFormat`.

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
// 4 VnRegulations:
Numbers : Numbers Number // [0]
        | Number ; // [1]
Number : 'integer' // [2]
       | 'float' ; // [3]
// 2 VtPatterns:
'integer' : %%[0-9]+%% ; // [0]
'float' : %%[0-9]+\.[0-9]+%% ; // [1]

```

# End

