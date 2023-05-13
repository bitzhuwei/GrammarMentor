// 有左递归
Additive       : Additive '+' Multiplicative 
               | Additive '-' Multiplicative 
               | Multiplicative ;
Multiplicative : Multiplicative '*' Primary 
               | Multiplicative '/' Primary 
               | Primary ;
Primary        : '(' Additive ')' 
               | 'number' ;
//--------------------------------------------
'number'       : %%[0-9]+([.][0-9]+)?%% ; // 暂时只处理非负数的四则运算


// 旧样式
<Additive>       ::= <Additive> "+" <Multiplicative> 
                 | <Additive> "-" <Multiplicative> 
                 | <Multiplicative> ;
<Multiplicative> ::= <Multiplicative> "*" <Primary> 
                 | <Multiplicative> "/" <Primary> 
                 | <Primary> ;
<Primary>        ::= identifier 
                 | "(" <Additive> ")" 
                 | number ;

a+(a+1)+(a+2)+(a+3)
Additive = Additive "+" Multiplicative = ...
= Multiplicative "+" Multiplicative "+" Multiplicative "+" Multiplicative
= Primary "+" Primary "+" Primary "+" Primary
= variable_identifier "+" "(" Additive ")" "+" "(" Additive ")" "+" "(" Additive ")" 
= variable_identifier "+" "(" Multiplicative "+" Multiplicative ")" "+" "(" Multiplicative "+" Multiplicative ")" "+" "(" Multiplicative "+" Multiplicative ")" 
= variable_identifier "+" "(" Primary "+" Primary ")" "+" "(" Primary "+" Primary ")" "+" "(" Primary "+" Primary ")" 
= variable_identifier "+" "(" variable_identifier "+" number ")" "+" "(" variable_identifier "+" number ")" "+" "(" variable_identifier "+" number ")" 

// 消除了左递归
Additive        : Multiplicative Additive2 ;
Additive2       : "+" Multiplicative Additive2
                | "-" Multiplicative Additive2
                | empty ;
Multiplicative  : Primary Multiplicative2 ;
Multiplicative2 : "*" Primary Multiplicative2
                | "/" Primary Multiplicative2
                | empty ;
Primary         : variable_identifier ;
                | "(" Additive ")" ;
                | number ;


消除左递归：
P  -> P α1 | P α2 | ... | P αn | β1 | β2 | ... | βm ;
==>
P  -> β1 P’ | β2 P’ | ... | βm P’ ;
P’ -> α1 P’ | α2 P’ | ... | αn P’ | empty ;
==>
P  -> β1 α1 P’ | β1 α2 P’ | β1 ... | β1 αn P’ | β1 P’
    | β2 α1 P’ | β2 α2 P’ | β2 ... | β2 αn P’ | β2 P’
    | ...
    | βm α1 P’ | βm α2 P’ | βm ... | βm αn P’ | βm P’ ;
结论：无法消除P’

以2个左递归1个非递归为例：
P  -> P α1 | P α2 | β1 ;
==>
P  -> β1 P’ ;
P’ -> α1 P’ | α2 P’ | empty ;
==>
P  -> β1 α1 P’ | β1 α2 P’ | β1 P’
P’ -> α1 P’ | α2 P’ | empty ;







