Additive       : Additive '+' Multiplicative 
               | Additive '-' Multiplicative 
               | Multiplicative ;
Multiplicative : Multiplicative '*' Primary 
               | Multiplicative '/' Primary 
               | Primary ;
Primary        : '(' Additive ')' 
               | 'number' ;
//--------------------------------------------
'number'       : %[0-9]+([.][0-9]+)?% ; // 暂时只处理非负数的四则运算
