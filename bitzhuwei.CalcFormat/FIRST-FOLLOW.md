# Compiler of `Calc`

The C# source code of the compiler `Calc` is generated by `bitzhuwei.GrammarFormat` at 2023-04-29 06:37:19.

## FIRST

```
[0]: FIRST( Additive ) = { '(' 'number' }
[1]: FIRST( Multiplicative ) = { '(' 'number' }
[2]: FIRST( Primary ) = { '(' 'number' }
[3]: FIRST( '+' ) = { '+' }
[4]: FIRST( '-' ) = { '-' }
[5]: FIRST( '*' ) = { '*' }
[6]: FIRST( '/' ) = { '/' }
[7]: FIRST( '(' ) = { '(' }
[8]: FIRST( ')' ) = { ')' }
[9]: FIRST( 'number' ) = { 'number' }
[10]: FIRST(  ) = { empty }
[11]: FIRST( Additive '+' Multiplicative ) = { '(' 'number' }
[12]: FIRST( Additive '-' Multiplicative ) = { '(' 'number' }
[13]: FIRST( Multiplicative '*' Primary ) = { '(' 'number' }
[14]: FIRST( Multiplicative '/' Primary ) = { '(' 'number' }
[15]: FIRST( '(' Additive ')' ) = { '(' }

```

## FOLLOW

```
[0]: FOLLOW( Additive ) = { '+' '-' ')' }
[1]: FOLLOW( Multiplicative ) = { '+' '-' '*' '/' ')' }
[2]: FOLLOW( Primary ) = { '+' '-' '*' '/' ')' }

```

