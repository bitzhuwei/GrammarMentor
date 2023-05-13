// GrammarName = SLR
// ExtractedType = SLR2
S : L '=' R | R ;
L : '*' R | 'id' ;
R : L ;
