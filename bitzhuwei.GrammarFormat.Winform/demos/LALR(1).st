// LALR(1):
S : L '=' R ;
S : R ;
L : '*' R ;
L : 'id' ;
R : L ;
