# `*.step`�ļ��Ĵʷ���������Analyzer��

![lexiAnalyzer.png](lexiAnalyzer.png)

�ʷ�������ԭ����״̬����State Machine�����ʷ������Ĺ��̾��ǣ�����һ��`char`��ʲô�������ж��������������ɸ�`char`���������һ����ļ����`Token`��Ȼ��һ��`char`һ��`char`��ƴ�ӳ����`Token`������ʱ��ָ�루`Cursor`����ָ������һ��`Token`�ĵ�һ��`char`���ظ��������̡�

�ʷ����������ÿ��Ժͼ��������7��Э�����������·���������ȡ�������·��ѿ��ܳ�������������ݴ����һ���������д��`���ݱ�`�����ϲ�Э������������ʷ������������ַ�����Դ������һ��������˳�����ͺ����ݵ�`Token`���������﷨�����ĸ����ԡ�

�����ͼ��״̬���ĸ������֡����Ǻ���һ�����Analyzer�ĺ��ġ�����״̬����

## ��ʼ״̬��

ͼ0�е�����ǡ��ʾ��ʼ״̬��Ҳ����Analyzer�ڷ�����һ��`char`֮ǰʱ��״̬��

![StateMachine0.jpg](StateMachine0.jpg)

��ͼ��ʾ�����ڡ�״̬�Ĵʷ�����������������`char`��`'('` `')'` `'='` `';'` `'$'` `'*'`�е�һ����������һ����Ӧ��`Token`�����󷵻ء�״̬��

```
class LexiRule {
    // ����trueʱ��ʾӦ��ʹ�ñ������е�function
    // Return true if current char matches this rule,
    // and that's when the function should be applied.
    public readonly Func<char, bool> matchingRule;
    // ������Ӧ�����еľ��������
    // ����ֵ����һ��State���󣬼�״̬������һ��״̬��
    // function of this rule.
    // It returns next State object.
    public readonly Func<LexiContext, State> function;

    public LexiRule(Func<char, bool> matchingRule, Func<LexiContext, State> function)
    {
        this.matchingRule = matchingRule;
        this.function = function;
    }
}
...
    var rule = new LexicalRule(
        currentChar => currentChar == '(',
        context =>
        {
		    // add a Token
            var token = new Token(context.Cursor, context.Line, context.Column);
            token.type = EType.LeftParenthesis;
            token.Value = "(";
            context.result.Add(token);
            return state0; // return back to state��
        });
```
����ʹ��������������anonymous method�������������`function`�ֶ����������š�

�����ʷ������ĳ���������£�

```
    public TokenList Analyze(string content)
    {
        var context = new LexiContext(content);
        while (!context.EOF)
        {
            char currentChar = context.CurrentChar;
            Func<LexiContext, State> function = context.state.GetAction(currentChar);
            State nextState = function(context);
            context.state = nextState;
            context.MoveForward(); // Cursor++
        }
        // finish lexical analyzing with external char('\0').
        {
            char currentChar = context.CurrentChar;
            Func<LexiContext, State> function = context.state.GetAction(currentChar);
            State nextState = function(context);
            context.state = nextState;
            context.MoveForward(); // actually not needed.
        }
    
        return context.result;
    }
```

## ʶ��ע��

������ʶ��ע�ͣ������Ϳ����ų����ĸ����ˡ�

![StateMachine1.jpg](StateMachine1.jpg)

����ͼ��ʾ����Ҳ�Գ�ʼ״̬�ʼ���Գ�ʼ״̬�������������ʶ����һ��ע�ͺ󣬾ͻָ��������״̬���Ϳ��Լ���ʶ����ȥ�ˡ�

ע�⣬ͼ1��ÿ���ڵ㶼��һ����ͬ��״̬���ҽ�ͼ1�еĺڵ�1������Ϊ״̬`1_1`���ڵ�2����Ϊ״̬`1_2`���ȵȡ�����ͼ0��ֻ��1����ʼ״̬��ҽ���������Ϊ״̬`0`��

״̬`1_1`��������`'*'`ʱ��Ӧ����״̬`1_2`��������`'/'`ʱ��Ӧ����״̬`1_4`������������`char`ʱ��Ӧ����״̬`0`������ʼ״̬�

״̬`1_2`����������`'*'`ʱ��Ӧ����״̬`1_3`������������`char`ʱ��Ӧ�ٴν���״̬`1_2`��ע��ͼ1�д�״̬`1_2`����״̬`1_2`�ļ�ͷ�����ϻ���һ��СԲȦ����������ʾ`��������char`�����˼��

Ч������ͼ��ʾ��

![lexiComment.png](lexiComment.png)

## ʶ���ַ���

`*.step`�ļ��е��ַ���Ҳ�Ƚϸ��ӣ�����Ӱ�������`Token`��ʶ�������ȴ�������

![StateMachine2.jpg](StateMachine2.jpg)

��`*.step`�ļ���`'John's bag',`��һ���ַ�������Ϊ���������`','`����`')'`����

�����˵��Ҫ�ڶ������Ǹ�`','`��ʱ�򣬲���ȷ���������õ���һ���������ַ�����`John's bag`�������Ҫ��������`function`�н����`Cursor`����һλ���Ա��´��ܴ������`','`��

```
    var rule = new LexicalRule(
        currentChar => currentChar == ',' || currentChar == ')' ,
        context =>
        {
            var token = context.result.Last();
            var str = context.Substring(token.index, context.Cursor - token.index);
            int length = str.Length;
            token.Value = str.TrimEnd();
            // read those ' ' '\n' '\r' ',' or ')' again.
            context.MoveBack(length - token.Value.Length + 1);
            return state0;
        }),
```

## ʶ��Entity��Identity

�����`*.step`�ļ���������һ�У�
```
#14 = PRODUCT_DEFINITION('design', ' ', #6, #3) ;
```
��ô��`#14`�Ǹ�`Entity`���͵�`Token`����`#6` `#3`��`Identity`���͵�`Token`��Ҳ����˵������������`=`�ģ����Ǹ�`Entity`������������`,`����`)`���ģ����Ǹ�`Identity`����Ͷ��ַ����Ĵ������ơ�

![StateMachine3.jpg](StateMachine3.jpg)

## ʶ����ֵ��

�����`*.step`�ļ��������������У�
```
#61 = CARTESIAN_POINT('Vertex', (-1.2, +3.E5, -.4E-6)) ;
#527 = B_SPLINE_CURVE_WITH_KNOTS('', 49, (#528,#529,#530,#531,#532), .002002. , .F., .U., (78, 91),(23., .74), .UNSPECIFIED. ) ;
```
��ô��`-1.2` `+3.E5` `-.4E-6` `23.` `.74`��`Float`���͵�`Token`��`49` `78` `91`��`Integer`���͵�`Token`��`.UNSPECIFIED.` `.002002.` `.F.` `.U.`��`Enum`���͵�`Token`��

Ҳ����˵����`Float` `Integer` `Enum`��ʶ���ǻ�������ģ�������һ��`.`�����һ�����֣�`[0-9]`)��ʱ���޷�ȷ����������һ��`Float`����`Enum`������`+` `-` ���һ�����֣�`[0-9]`)��ʱ���޷�ȷ����������һ��`Integer`����`Float`�������һ��ʶ����ǡ���ֵ�ȡ���

![StateMachine4.jpg](StateMachine4.jpg)

������Ը��ӵ�ͼ4��������3���򵥵�״̬���ϳɣ�

����`Float`�Ĳ��֣�

![StateMachine4-Float.jpg](StateMachine4-Float.jpg)

����`Integer`�Ĳ��֣���ͼ��`+` `-`֮���״̬����`4-1`�ں�Ϊһ������״̬�������ںϡ�

![StateMachine4-Integer.jpg](StateMachine4-Integer.jpg)

����`Enum`�Ĳ��֣�������`[A-Z0-9_]`���Ϊ����`[0-9]`��`[A-Z_]`���Ա��������״̬ͼ�ںϡ�

![StateMachine4-Enum.jpg](StateMachine4-Enum.jpg)

����3��״̬���ں�����������ͼ4�ˡ�����ںϹ��̣�������ʵ��lex����Ҫ���㷨��

## ʶ��keyword��Type

�����`*.step`�ļ����������ļ��У�
```

HEADER;
FILE_DESCRIPTION(('xxx'),'2;1');

FILE_NAME('C:\\xxx.step','2021-12-14T06:27:09+00:00',('none'),('none'),'xxxx','xxxx','none');

FILE_SCHEMA(('xxxx'));

ENDSEC;
DATA;
...
#61 = CARTESIAN_POINT('Vertex', (-1.2, +3.E5, -.4E-6)) ;
...
ENDSEC;

```
��ô`HEADER` `ENDSEC` `DATA`����step�ļ������Ĺؼ��֣�keyword��������ÿ������һ���������͵�`Token`����`CARTESIAN_POINT` `B_SPLINE_CURVE_WITH_KNOTS` ����`Type`���͵�`Token`��

![StateMachine5.jpg](StateMachine5.jpg)

�������Ƕ�����ĸ�����֡��»��ߵ���ϣ�����ֻ����ͼ5������`function`�����֡�

```
    var rule = new LexicalRule(
        // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
        currentChar => true,
        context =>
        {
            var token = context.result.Last();
            string str = context.Substring(token.index, context.Cursor - token.index);
            char c = context.CurrentChar;
            switch (str)
            {
                case "STEP": token.type = c == ';' ? EType.STEP : EType.Error; break;
                case "HEADER": token.type = c == ';' ? EType.HEADER : EType.Error; break;
                case "ENDSEC": token.type = c == ';' ? EType.ENDSEC : EType.Error; break;
                case "DATA": token.type = c == ';' ? EType.DATA : EType.Error; break;
                case "ENDSTEP": token.type = c == ';' ? EType.ENDSTEP : EType.Error; break;
                // TODO: ��һ����ϸ������ЩType��
                default: token.type = EType.Type; break;
            }
            if (token.type == EType.Error)
            {
                context.result.errorDict.Add(token, new TokenErrorInfo("Missing [;]"));
                token.Value = str;
                context.MoveBack(1);
            }
            else if (token.type == EType.Type)
            {
                token.Value = str;
                context.MoveBack(1);
            }
            else // some keywordXXX
            {
                token.Value = str;
            }
        
            return state0;
        }),
```

# �ܽ�

Ҫ��ĳ����ʽ���ļ�д�ʷ��������������ҵ�����lex�ļ�������lex���Rule��������ʽ�����ܽ����������Щ״̬����ͼ1-ͼ5���������ô���������Щͼ���ʷ��������ͳ��ˡ�

����д���﷨��������Syntax Parser����������дһ���Լ���lex+yacc�����ܻ�Ҫ����������ʽ���档
