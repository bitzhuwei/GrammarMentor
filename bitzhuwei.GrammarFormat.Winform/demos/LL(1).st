// LL(1):
S : 'c' T | R T ;
T : D R | empty ;
R : 'd' R | empty ;
D : 'a' | 'b' 'd' ;
