// SLR(1):
E : E '+' T | T ;
T : T '*' F | F ;
F : '(' E ')' | 'id' ;
