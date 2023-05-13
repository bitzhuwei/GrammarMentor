// GrammarName = Scope
// ExtractedType = ResolvedScope
Scope : '[' 'firstItem1' RangeItems ']' ;
Scope : '[^' 'firstItem2' RangeItems ']' ;
Scope : '[' 'firstItem1' ']' ;
Scope : '[^' 'firstItem2' ']' ;
RangeItems : RangeItems RangeItem | RangeItem ;
RangeItem : 'char' ;

// \uNNNN \t \n \r 口 ! " # $ % & '
// ( ) * + , - . /
// 0 1 2 3 4 5 6 7 8 9
// : ; < = > ? @
// A B C D E F G H I J K L M
// N O P Q R S T U V W X Y Z
// [ \ ] ^ _ `
// a b c d e f g h i j k l m
// n o p q r s t u v w x y z
// { | } ~

// escape: \ ^
'firstItem1' : %%<'['>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~]%% ;
// escape: \
'firstItem2' : %%<'[^'>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~]%% ;
// escape: [ \ ]
'char' : %%\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~]%% ;