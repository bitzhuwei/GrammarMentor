# Compiler of `Calc`

The C# source code of the compiler `Calc` is generated by `bitzhuwei.GrammarFormat`.

## LL(1) Syntax Machine

| 状态 | \'\+\' | \'\-\' | \'\*\' | \'/\' | \'\(\' | \'\)\' | \'number\' |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| Additive |   |   |   |   | R[0] R[1] R[2] |   | R[0] R[1] R[2] |
| Multiplicative |   |   |   |   | R[3] R[4] R[5] |   | R[3] R[4] R[5] |
| Primary |   |   |   |   | R[6] |   | R[7] |


