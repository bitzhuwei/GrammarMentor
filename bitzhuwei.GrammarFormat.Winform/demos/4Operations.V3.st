L  : E ';' L | empty ;
E  : T E2 ;
E2 : '+' T E2 | '-' T E2 | empty ;
T  : F T2 ;
T2 : '*' F T2 | '/' F T2 | '%' F T2 | empty ;
F  : '(' E ')' | id | 'number' ;
