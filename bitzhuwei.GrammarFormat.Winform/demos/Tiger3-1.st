// the tiger book 3-1
S : S ';' S ;
S : 'identifier' ':=' E ;
S : 'print' '(' L ')' ;
E : '(' S ',' E ')' ;
E : E '+' E ;
E : 'identifier' ;
E : 'number' ;
L : L ',' E;
L : E ;
