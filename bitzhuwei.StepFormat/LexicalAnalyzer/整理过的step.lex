
%x Comment End Text
%%
// 0 MultipleLineComment, SingleLineComment, Slash
/* start of comment - put the scanner in the "Comment" state */
"/*"               { BEGIN(Comment); }     
/* in comment, skip any characters except asterisk (and newline, handled by its own rule) */
<Comment>[^*\n]*       {;}                 
/* in comment, skip any sequence of asterisks followed by other symbols (except slash or newline) */
<Comment>[*]+[^*/\n]*  {;}                 
/* end of comment - reset the scanner to initial state */
<Comment>[*]+[/]       { BEGIN(INITIAL); } 
[/]            { return ('/'); }

// 1 LeftParenthesis, RightParenthesis, Equal, Semicolon, Comma, Dollar
[(]		{ return ('('); }
[)]		{ return (')'); }
[=]		{ return ('='); }
[;]		{ return (';'); }
[,]		{ myDataModel->PrepareNewArg(); return (','); }
[$]		{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamVoid); return(token::QUID); }
    缺少了对 [*] 的识别

// 2 String_
/* start of quoted text string - put the scanner in the "Text" state, but keep ' as part of yytext */
[']                { BEGIN(Text); yymore(); }   
/* newline in text string - increment line counter and keep collecting yytext */
<Text>[\n]         { yymore(); yylineno ++; }   
/* single ' inside text string - keep collecting yytext*/
<Text>[']          { yymore(); }                
/* a sequence of any characters except ' and \n - keep collecting yytext */
<Text>[^\n']+      { yymore(); }                
/* end of string (apostrophe followed by comma or closing parenthesis) 
        - reset the scanner to initial state, record the value of all yytext collected */
<Text>[']/[" "\n\r]*[\)\,]    {
    BEGIN(INITIAL); 
	CreateNewText(YYText(),YYLeng()); 
	SetTypeArg(Interface_ParamText); 
	return(token::QUID); 
} 

// 3 Entity, Identity
#[0-9]+/=		{ CreateNewText(YYText(),YYLeng()); return(token::ENTITY); }
#[0-9]+/[ 	]*=	{ CreateNewText(YYText(),YYLeng()); return(token::ENTITY); }
#[0-9]+			{ CreateNewText(YYText(),YYLeng()); return(token::IDENT); }

// 4 Integer, Float, Hexadecimal, Enum
[-+0-9][0-9]*	{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamInteger); return(token::QUID); }
[-+\.0-9][\.0-9]+	{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamReal); return(token::QUID); }
[-+\.0-9][\.0-9]+E[-+0-9][0-9]*	{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamReal); return(token::QUID); }
["][0-9A-F]+["] 	{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamHexa); return(token::QUID); }
[.]*[A-Z0-9_]+[.]	{ CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamEnum); return(token::QUID); }
    // fix:
    整数： [-+]?[0-9]+[.]?[0-9]*
    实数： [-+]?[0-9]+[.]?[0-9]*E[-+]?[0-9]+
    省略小数点后的尾数0： [-+]?[0-9]+[.][^0-9]
    没有发现这样的情况：以小数点开头（省略了0）的小数（ [^0-9][.][0-9]+ ）
    [.]*[A-Z0-9_]+[.] 应该是 .T. 这样的东西吧，我猜。那就应该改为 [.][A-Z0-9_]+[.]

// 5 STEP, HEADER, ENDSEC, DATA, ENDSTEP
(?i:STEP);            { return(token::STEP); }
(?i:HEADER);          { return(token::HEADER); }
(?i:ENDSEC);          { return(token::ENDSEC); }
(?i:DATA);            { return(token::DATA); }
(?i:ENDSTEP);         { return(token::ENDSTEP); }
(?i:ENDSTEP);.*       { return(token::ENDSTEP); }
 /* at the end of the STEP data, enter dedicated start condition "End" to skip everything that follows */
(?i:END-ISO)[0-9\-]*; { BEGIN(End); return(token::ENDSTEP); } 
(?i:ISO)[0-9\-]*;     { return(token::STEP); }
    [^A-Za-z]END[^(\n]+
        END-ISO-10303-21;
[a-zA-Z0-9_]+  { CreateNewText(YYText(),YYLeng()); return(token::TYPE); }
![a-zA-Z0-9_]+ { CreateNewText(YYText(),YYLeng()); return(token::TYPE); }
    什么破表达式，应该是[a-zA-Z_][a-zA-Z0-9_-]*

// 尚未找到包含 SCOPE 或 ENDSCOPE 的例子
&(?i:SCOPE)	   { return(token::SCOPE); }
(?i:ENDSCOPE)  { return(token::ENDSCOPE); }

    [^A-Z]SCOPE[^A-Z]
	[^A-Z]ENDSCOPE[^A-Z]

// 下述情形，忽略即可
[^)]           { CreateNewText(YYText(),YYLeng()); SetTypeArg(Interface_ParamMisc); return(token::QUID); }
    
<End>[^\n]     {;} /* skip any characters (except newlines) */

// 6 not need to deal with it:
"	"	{;}
" "		{;}
 /* count lines (one rule for all start conditions) */
<*>[\n]		{ yylineno ++; } 
 /* abv 30.06.00: for reading DOS files */
[\r]    	{;} 
 /* fix from C21. for test load e3i file with line 15 with null symbols */
[\0]+		{;} 


%%
