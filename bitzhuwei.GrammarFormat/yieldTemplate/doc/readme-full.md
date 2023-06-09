# Compiler of `{GrammarName}`

The C# source code of the compiler `{GrammarName}` is generated by `bitzhuwei.GrammarFormat`.

# Grammar

```
{Grammar}
```

## Lexical Analyzer States

```Mermaid
{LexicalAnalyerStates(DFA)}
```
## nullable

```
{nullable}
```

## FIRST

```
{FirstList}
```

## FOLLOW

```
{FollowList}
```

## LL(1) Syntax Machine

{LL(1)SyntaxTable}

## LR(0) Syntax Machine

{LR(0)SyntaxTable}

```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
{LR(0)SyntaxDiagram}
```

## SLR(1) Syntax Machine

{SLR(1)SyntaxTable}

```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
{SLR(1)SyntaxDiagram}
```

## LALR(1) Syntax Machine

{LALR(1)SyntaxTable}

```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
{LALR(1)SyntaxDiagram}
```

## LR(1) Syntax Machine

{LR(1)SyntaxTable}

```Mermaid
flowchart
classDef default fill:#C7EDCC,stroke:#993399,stroke-width:0px,text-align:left;
classDef titlebarStyle fill:gold;
titlebar>"LR(1) syntax states"]
class titlebar titlebarStyle
{LR(1)SyntaxDiagram}
```

# End

