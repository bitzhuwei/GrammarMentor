using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Practice.GeneratedXxxFormat.Test {
    static partial class Test {
        public static void Regexes() {
            // () [] {} | \ + - * / ^ $ . ? < >
            // （）【】{} | 、 + - * 、…… ￥ 。 ？ 《》
            // 在%%xxx%%中，我规定：不用^表示行的开始，不用$表示行的结尾。
            // 但为了与C#Regex的写法保持一致，我规定：在%%xxx%%中，需要表示^或$时，必须用\^或\$的转义写法，不能直接使用^或$。当然， 也可以用[\^]或[$]的转义写法。
            // when I want to say a char:
            // in memory: 口 ! " # $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @
            // A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \ ] ^ _ `
            // a b c d e f g h i j k l m n o p q r s t u v w x y z { | } ~
            // in file: 口 ! " # \$ % & ' \( \) \* \+ , - \- . \. \/ 0 1 2 3 4 5 6 7 8 9 : ; < \< = > \> \? @
            // A B C D E F G H I J K L M N O P Q R S T U V W X Y Z \[ \\ \] \^ _ `
            // a b c d e f g h i j k l m n o p q r s t u v w x y z \{ \| \} ~
            var charCase1 = new Regex(@" !""#\$%&'\(\)\*\+,"); // @"""" means "
            var charCase2 = new Regex(@"-\-.\.\/09:;<\<=>\>\?@AZ\[\\\]\^_`az\{\|\}~");
            // copy this: [ !"#%&',]|-|[.0-9:;<=>@A-Z_`a-z~]|\\[$()*+]|\\-|\\[./<>?]|\\\[|\\\\|\\\]|\\\^|\\\{|\\\||\\\}|\\u[0-9a-fA-F]{4}
            var Vtchar = new Regex(@"[ !""#%&',]|-|[.0-9:;<=>@A-Z_`a-z~]|\\[$()*+]|\\-|\\[./<>?]|\\\[|\\\\|\\\]|\\\^|\\\{|\\\||\\\}|\\u[0-9a-fA-F]{4}");
            // when I want to say a scope:
            // in memory: [^ !"#$%&'()*+,-./09:;<=>?@AZ[\]^_`az{|}~]
            // in file: [^ !"#$%&'()*+,-./09:;<=>?@AZ]
            // in file: [^\[\\\]]
            // in file: [^^]
            // in file: [^\^]
            // in file: [^_`az{|}~]
            // in file: [\uFFFF]
            var scopeCase1 = new Regex(@"[^ !#$%&'()*+,]|[^-]|[^./09:;<=>?@AZ\[\\\]]");
            var scopeCase2 = new Regex(@"[^^]");// 放弃此写法。
            var scopeCase3 = new Regex(@"[^\^]");
            var scopeCase4 = new Regex(@"[\^]"); // @"[^]" is wrong
            var scopeCase5 = new Regex(@"[^_`az{|}~]");
            // 我规定，在[]中表示 [ \ ] ^ 时，必须用 \[ \\ \] \^ 的转义写法。其他字符可以转义，也可以不转义。
            // copy this: \[\^?([ -Z]|\\\[|\\\\|\\\]|\\\^|[_`a-z{|}~]|\\u[0-9a-fA-F]{4})+\]
            //var Vtscope = new Regex(@"\[\^?([ -Z]|\\\[|\\\\|\\\]|\\\^|[_`a-z{|}~]|\\u[0-9a-fA-F]{4})+\]");
            var Vtscope = new Regex(@"\[((\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~])(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~])*|\^(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\^|\\\^|[_-~])(\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\\\[|\\\\|\\\]|\^|\\\^|[_-~])*)\]");
            using (var reader = new StreamReader("regex.inputs")) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line) || line.StartsWith("#")) {
                        continue;
                    }

                    var parts = line.Split(' ');
                    var pattern = parts[0];
                    var content = parts[1];

                    var regex = new Regex(pattern);
                    //var regex2 = new Regex(@"[\t\r --/-~]");
                    //var regex2 = new Regex(@"[\t-\r]");
                    //content = $"{(char)(11)}";
                    //var regex = new Regex(@"[a-c-[o-q]]");
                    //var content = "mopqrdaopqr";// only matches a
                    //var regex2 = new Regex(@"[\t-]");
                    //var regex2 = new Regex(@"['\u0013']");
                    //pattern = $"{'\u0013'}3";
                    //var regex2 = new Regex(@"[\u0031]");
                    //content = '\u0031'.ToString();
                    //var regex2 = new Regex("[\u0000-\u007F]");
                    //var regex = new Regex("[\u0000-\u007f]");
                    //var regex2 = new Regex("[^]1[2]");
                    //content = '\u0031'.ToString();
                    //var regex2 = new Regex(
                    //@"[\u0031\t\n\r !""#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\\]^_`abcdefghijklmnopqrstuvwxyz{|}~]");
                    //var regex2 = new Regex(@"[^-]");
                    //var regex2 = new Regex(@"[~]");
                    //var regex2 = new Regex(@"[a^\^]");
                    //var regex2 = new Regex(@"[N-zA-m]");
                    //var regex2 = new Regex(@"[\-]");
                    //var regex2 = new Regex(@"^");

                    var result = regex.Matches(content);
                    foreach (var item in result) {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("========");
                }

                Console.WriteLine("done");
            }
        }

        private static void Examples() {
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
            //var regex = new Regex[] {
            //    new Regex(@"[^]"),new Regex(@"[^]"),new Regex(@"[^]"),new Regex(@"[^]"),
            //    new Regex(@"[^\u0000]"),new Regex(@"[^\u0001]"),new Regex(@"[^\u0002]"),new Regex(@"[^\u0003]"),
            //    new Regex(@"[^\a]"),new Regex(@"[^\b]"),new Regex(@"[^\c]"),new Regex(@"[^\d]"),
            //    new Regex(@"[^\e]"),new Regex(@"[^\f]"),new Regex(@"[^\g]"),new Regex(@"[^\h]"),
            //    new Regex(@"[^\i]"),new Regex(@"[^\j]"),new Regex(@"[^\k]"),new Regex(@"[^\l]"),
            //    new Regex(@"[^\m]"),new Regex(@"[^\n]"),new Regex(@"[^\o]"),new Regex(@"[^\p]"),
            //    new Regex(@"[^\q]"),new Regex(@"[^\r]"),new Regex(@"[^\s]"),new Regex(@"[^\t]"),
            //    new Regex(@"[^\u]"),new Regex(@"[^\v]"),new Regex(@"[^\w]"),new Regex(@"[^\x]"),
            //    new Regex(@"[^\y]"),new Regex(@"[^\z]"),
            //    new Regex(@"[^\A]"),new Regex(@"[^\B]"),new Regex(@"[^\C]"),new Regex(@"[^\D]"),
            //    new Regex(@"[^\E]"),new Regex(@"[^\F]"),new Regex(@"[^\G]"),new Regex(@"[^\H]"),
            //    new Regex(@"[^\I]"),new Regex(@"[^\J]"),new Regex(@"[^\K]"),new Regex(@"[^\L]"),
            //    new Regex(@"[^\M]"),new Regex(@"[^\N]"),new Regex(@"[^\O]"),new Regex(@"[^\P]"),
            //    new Regex(@"[^\Q]"),new Regex(@"[^\R]"),new Regex(@"[^\S]"),new Regex(@"[^\T]"),
            //    new Regex(@"[^\U]"),new Regex(@"[^\V]"),new Regex(@"[^\W]"),new Regex(@"[^\X]"),
            //    new Regex(@"[^\Y]"),new Regex(@"[^\Z]"),
            //    new Regex(@"[^ ]"),new Regex(@"[^!]"),new Regex(@"[^""]"),new Regex(@"[^#]"),
            //    new Regex(@"[^$]"),new Regex(@"[^%]"),new Regex(@"[^&]"), new Regex(@"[^']"),
            //    new Regex(@"[^(]"),new Regex(@"[^)]"),new Regex(@"[^*]"), new Regex(@"[^+]"),
            //    new Regex(@"[^,]"),new Regex(@"[^-]"),new Regex(@"[^.]"), new Regex(@"[^/]"),
            //    new Regex(@"[^0]"),new Regex(@"[^1]"),new Regex(@"[^2]"), new Regex(@"[^3]"),
            //    new Regex(@"[^4]"),new Regex(@"[^5]"),new Regex(@"[^6]"), new Regex(@"[^7]"),
            //    new Regex(@"[^8]"),new Regex(@"[^9]"),new Regex(@"[^:]"), new Regex(@"[^;]"),
            //    new Regex(@"[^<]"),new Regex(@"[^=]"),new Regex(@"[^>]"), new Regex(@"[^?]"),
            //    new Regex(@"[^@]"),new Regex(@"[^A]"),new Regex(@"[^B]"), new Regex(@"[^C]"),
            //    new Regex(@"[^D]"),new Regex(@"[^E]"),new Regex(@"[^F]"), new Regex(@"[^G]"),
            //    new Regex(@"[^H]"),new Regex(@"[^I]"),new Regex(@"[^J]"), new Regex(@"[^K]"),
            //    new Regex(@"[^L]"),new Regex(@"[^M]"),new Regex(@"[^N]"), new Regex(@"[^O]"),
            //    new Regex(@"[^P]"),new Regex(@"[^Q]"),new Regex(@"[^R]"), new Regex(@"[^S]"),
            //    new Regex(@"[^T]"),new Regex(@"[^U]"),new Regex(@"[^V]"), new Regex(@"[^W]"),
            //    new Regex(@"[^X]"),new Regex(@"[^Y]"),new Regex(@"[^Z]"), new Regex(@"[^[]"),
            //    new Regex(@"[^\]"),new Regex(@"[^]]"),new Regex(@"[^^]"), new Regex(@"[^_]"),
            //    new Regex(@"[^`]"),new Regex(@"[^a]"),new Regex(@"[^b]"), new Regex(@"[^c]"),
            //    new Regex(@"[^d]"),new Regex(@"[^e]"),new Regex(@"[^f]"), new Regex(@"[^g]"),
            //    new Regex(@"[^h]"),new Regex(@"[^i]"),new Regex(@"[^j]"), new Regex(@"[^k]"),
            //    new Regex(@"[^l]"),new Regex(@"[^m]"),new Regex(@"[^n]"), new Regex(@"[^o]"),
            //    new Regex(@"[^p]"),new Regex(@"[^q]"),new Regex(@"[^r]"), new Regex(@"[^s]"),
            //    new Regex(@"[^t]"),new Regex(@"[^u]"),new Regex(@"[^v]"), new Regex(@"[^w]"),
            //    new Regex(@"[^x]"),new Regex(@"[^y]"),new Regex(@"[^z]"), new Regex(@"[^{]"),
            //    new Regex(@"[^|]"),new Regex(@"[^}]"),new Regex(@"[^~]"),
            //};
            //var regex2 = new Regex[] {
            //    new Regex(@"[]"),new Regex(@"[]"),new Regex(@"[]"),new Regex(@"[]"),
            //    new Regex(@"[\u0000]"),new Regex(@"[\u0001]"),new Regex(@"[\u0002]"),new Regex(@"[\u0003]"),
            //    new Regex(@"[\a]"),new Regex(@"[\b]"),new Regex(@"[\c]"),new Regex(@"[\d]"),
            //    new Regex(@"[\e]"),new Regex(@"[\f]"),new Regex(@"[\g]"),new Regex(@"[\h]"),
            //    new Regex(@"[\i]"),new Regex(@"[\j]"),new Regex(@"[\k]"),new Regex(@"[\l]"),
            //    new Regex(@"[\m]"),new Regex(@"[\n]"),new Regex(@"[\o]"),new Regex(@"[\p]"),
            //    new Regex(@"[\q]"),new Regex(@"[\r]"),new Regex(@"[\s]"),new Regex(@"[\t]"),
            //    new Regex(@"[\u]"),new Regex(@"[\v]"),new Regex(@"[\w]"),new Regex(@"[\x]"),
            //    new Regex(@"[\y]"),new Regex(@"[\z]"),
            //    new Regex(@"[\A]"),new Regex(@"[\B]"),new Regex(@"[\C]"),new Regex(@"[\D]"),
            //    new Regex(@"[\E]"),new Regex(@"[\F]"),new Regex(@"[\G]"),new Regex(@"[\H]"),
            //    new Regex(@"[\I]"),new Regex(@"[\J]"),new Regex(@"[\K]"),new Regex(@"[\L]"),
            //    new Regex(@"[\M]"),new Regex(@"[\N]"),new Regex(@"[\O]"),new Regex(@"[\P]"),
            //    new Regex(@"[\Q]"),new Regex(@"[\R]"),new Regex(@"[\S]"),new Regex(@"[\T]"),
            //    new Regex(@"[\U]"),new Regex(@"[\V]"),new Regex(@"[\W]"),new Regex(@"[\X]"),
            //    new Regex(@"[\Y]"),new Regex(@"[\Z]"),
            //    new Regex(@"[ ]"),new Regex(@"[!]"),new Regex(@"[""]"),new Regex(@"[#]"),
            //    new Regex(@"[$]"),new Regex(@"[%]"),new Regex(@"[&]"), new Regex(@"[']"),
            //    new Regex(@"[(]"),new Regex(@"[)]"),new Regex(@"[*]"), new Regex(@"[+]"),
            //    new Regex(@"[,]"),new Regex(@"[-]"),new Regex(@"[.]"), new Regex(@"[/]"),
            //    new Regex(@"[0]"),new Regex(@"[1]"),new Regex(@"[2]"), new Regex(@"[3]"),
            //    new Regex(@"[4]"),new Regex(@"[5]"),new Regex(@"[6]"), new Regex(@"[7]"),
            //    new Regex(@"[8]"),new Regex(@"[9]"),new Regex(@"[:]"), new Regex(@"[;]"),
            //    new Regex(@"[<]"),new Regex(@"[=]"),new Regex(@"[>]"), new Regex(@"[?]"),
            //    new Regex(@"[@]"),new Regex(@"[A]"),new Regex(@"[B]"), new Regex(@"[C]"),
            //    new Regex(@"[D]"),new Regex(@"[E]"),new Regex(@"[F]"), new Regex(@"[G]"),
            //    new Regex(@"[H]"),new Regex(@"[I]"),new Regex(@"[J]"), new Regex(@"[K]"),
            //    new Regex(@"[L]"),new Regex(@"[M]"),new Regex(@"[N]"), new Regex(@"[O]"),
            //    new Regex(@"[P]"),new Regex(@"[Q]"),new Regex(@"[R]"), new Regex(@"[S]"),
            //    new Regex(@"[T]"),new Regex(@"[U]"),new Regex(@"[V]"), new Regex(@"[W]"),
            //    new Regex(@"[X]"),new Regex(@"[Y]"),new Regex(@"[Z]"), new Regex(@"[[]"),
            //    new Regex(@"[\]"),new Regex(@"[]]"),new Regex(@"[^]"), new Regex(@"[_]"),
            //    new Regex(@"[`]"),new Regex(@"[a]"),new Regex(@"[b]"), new Regex(@"[c]"),
            //    new Regex(@"[d]"),new Regex(@"[e]"),new Regex(@"[f]"), new Regex(@"[g]"),
            //    new Regex(@"[h]"),new Regex(@"[i]"),new Regex(@"[j]"), new Regex(@"[k]"),
            //    new Regex(@"[l]"),new Regex(@"[m]"),new Regex(@"[n]"), new Regex(@"[o]"),
            //    new Regex(@"[p]"),new Regex(@"[q]"),new Regex(@"[r]"), new Regex(@"[s]"),
            //    new Regex(@"[t]"),new Regex(@"[u]"),new Regex(@"[v]"), new Regex(@"[w]"),
            //    new Regex(@"[x]"),new Regex(@"[y]"),new Regex(@"[z]"), new Regex(@"[{]"),
            //    new Regex(@"[|]"),new Regex(@"[}]"),new Regex(@"[~]"),
            //};

            //var regex3 = new Regex[] {
            //    new Regex(@"[a\u0000]"),new Regex(@"[a\u0001]"),new Regex(@"[a\u0002]"),new Regex(@"[a\u0003]"),
            //    new Regex(@"[a\a]"),new Regex(@"[a\b]"),new Regex(@"[a\c]"),new Regex(@"[a\d]"),
            //    new Regex(@"[a\e]"),new Regex(@"[a\f]"),new Regex(@"[a\g]"),new Regex(@"[a\h]"),
            //    new Regex(@"[a\i]"),new Regex(@"[a\j]"),new Regex(@"[a\k]"),new Regex(@"[a\l]"),
            //    new Regex(@"[a\m]"),new Regex(@"[a\n]"),new Regex(@"[a\o]"),new Regex(@"[a\p]"),
            //    new Regex(@"[a\q]"),new Regex(@"[a\r]"),new Regex(@"[a\s]"),new Regex(@"[a\t]"),
            //    new Regex(@"[a\u]"),new Regex(@"[a\v]"),new Regex(@"[a\w]"),new Regex(@"[a\x]"),
            //    new Regex(@"[a\y]"),new Regex(@"[a\z]"),
            //    new Regex(@"[a\A]"),new Regex(@"[a\B]"),new Regex(@"[a\C]"),new Regex(@"[a\D]"),
            //    new Regex(@"[a\E]"),new Regex(@"[a\F]"),new Regex(@"[a\G]"),new Regex(@"[a\H]"),
            //    new Regex(@"[a\I]"),new Regex(@"[a\J]"),new Regex(@"[a\K]"),new Regex(@"[a\L]"),
            //    new Regex(@"[a\M]"),new Regex(@"[a\N]"),new Regex(@"[a\O]"),new Regex(@"[a\P]"),
            //    new Regex(@"[a\Q]"),new Regex(@"[a\R]"),new Regex(@"[a\S]"),new Regex(@"[a\T]"),
            //    new Regex(@"[a\U]"),new Regex(@"[a\V]"),new Regex(@"[a\W]"),new Regex(@"[a\X]"),
            //    new Regex(@"[a\Y]"),new Regex(@"[a\Z]"),
            //    new Regex(@"[a ]"),new Regex(@"[a!]"),new Regex(@"[a""]"),new Regex(@"[a#]"),
            //    new Regex(@"[a$]"),new Regex(@"[a%]"),new Regex(@"[a&]"), new Regex(@"[a']"),
            //    new Regex(@"[a(]"),new Regex(@"[a)]"),new Regex(@"[a*]"), new Regex(@"[a+]"),
            //    new Regex(@"[a,]"),new Regex(@"[a-]"),new Regex(@"[a.]"), new Regex(@"[a/]"),
            //    new Regex(@"[a0]"),new Regex(@"[a1]"),new Regex(@"[a2]"), new Regex(@"[a3]"),
            //    new Regex(@"[a4]"),new Regex(@"[a5]"),new Regex(@"[a6]"), new Regex(@"[a7]"),
            //    new Regex(@"[a8]"),new Regex(@"[a9]"),new Regex(@"[a:]"), new Regex(@"[a;]"),
            //    new Regex(@"[a<]"),new Regex(@"[a=]"),new Regex(@"[a>]"), new Regex(@"[a?]"),
            //    new Regex(@"[a@]"),new Regex(@"[aA]"),new Regex(@"[aB]"), new Regex(@"[aC]"),
            //    new Regex(@"[aD]"),new Regex(@"[aE]"),new Regex(@"[aF]"), new Regex(@"[aG]"),
            //    new Regex(@"[aH]"),new Regex(@"[aI]"),new Regex(@"[aJ]"), new Regex(@"[aK]"),
            //    new Regex(@"[aL]"),new Regex(@"[aM]"),new Regex(@"[aN]"), new Regex(@"[aO]"),
            //    new Regex(@"[aP]"),new Regex(@"[aQ]"),new Regex(@"[aR]"), new Regex(@"[aS]"),
            //    new Regex(@"[aT]"),new Regex(@"[aU]"),new Regex(@"[aV]"), new Regex(@"[aW]"),
            //    new Regex(@"[aX]"),new Regex(@"[aY]"),new Regex(@"[aZ]"), new Regex(@"[a[]"),
            //    new Regex(@"[a\]"),new Regex(@"[a]]"),new Regex(@"[a^]"), new Regex(@"[a_]"),
            //    new Regex(@"[a`]"),new Regex(@"[aa]"),new Regex(@"[ab]"), new Regex(@"[ac]"),
            //    new Regex(@"[ad]"),new Regex(@"[ae]"),new Regex(@"[af]"), new Regex(@"[ag]"),
            //    new Regex(@"[ah]"),new Regex(@"[ai]"),new Regex(@"[aj]"), new Regex(@"[ak]"),
            //    new Regex(@"[al]"),new Regex(@"[am]"),new Regex(@"[an]"), new Regex(@"[ao]"),
            //    new Regex(@"[ap]"),new Regex(@"[aq]"),new Regex(@"[ar]"), new Regex(@"[as]"),
            //    new Regex(@"[at]"),new Regex(@"[au]"),new Regex(@"[av]"), new Regex(@"[aw]"),
            //    new Regex(@"[ax]"),new Regex(@"[ay]"),new Regex(@"[az]"), new Regex(@"[a{]"),
            //    new Regex(@"[a|]"),new Regex(@"[a}]"),new Regex(@"[a~]"),
            //};
            //var regex4 = new Regex[] {
            //    new Regex(@""),new Regex(@""),new Regex(@""),new Regex(@""),
            //    new Regex(@"\u0000"),new Regex(@"\u0001"),new Regex(@"\u0002"),new Regex(@"\u0003"),
            //    new Regex(@"\a"),new Regex(@"\b"),new Regex(@"\c"),new Regex(@"\d"),
            //    new Regex(@"\e"),new Regex(@"\f"),new Regex(@"\g"),new Regex(@"\h"),
            //    new Regex(@"\i"),new Regex(@"\j"),new Regex(@"\k"),new Regex(@"\l"),
            //    new Regex(@"\m"),new Regex(@"\n"),new Regex(@"\o"),new Regex(@"\p"),
            //    new Regex(@"\q"),new Regex(@"\r"),new Regex(@"\s"),new Regex(@"\t"),
            //    new Regex(@"\u"),new Regex(@"\v"),new Regex(@"\w"),new Regex(@"\x"),
            //    new Regex(@"\y"),new Regex(@"\z"),
            //    new Regex(@"\A"),new Regex(@"\B"),new Regex(@"\C"),new Regex(@"\D"),
            //    new Regex(@"\E"),new Regex(@"\F"),new Regex(@"\G"),new Regex(@"\H"),
            //    new Regex(@"\I"),new Regex(@"\J"),new Regex(@"\K"),new Regex(@"\L"),
            //    new Regex(@"\M"),new Regex(@"\N"),new Regex(@"\O"),new Regex(@"\P"),
            //    new Regex(@"\Q"),new Regex(@"\R"),new Regex(@"\S"),new Regex(@"\T"),
            //    new Regex(@"\U"),new Regex(@"\V"),new Regex(@"\W"),new Regex(@"\X"),
            //    new Regex(@"\Y"),new Regex(@"\Z"),
            //    new Regex(@" "),new Regex(@"!"),new Regex(@""""),new Regex(@"#"),
            //    new Regex(@"$"),new Regex(@"%"),new Regex(@"&"), new Regex(@"'"),
            //    new Regex(@"("),new Regex(@")"),new Regex(@"*"), new Regex(@"+"),
            //    new Regex(@","),new Regex(@"-"),new Regex(@"."), new Regex(@"/"),
            //    new Regex(@"0"),new Regex(@"1"),new Regex(@"2"), new Regex(@"3"),
            //    new Regex(@"4"),new Regex(@"5"),new Regex(@"6"), new Regex(@"7"),
            //    new Regex(@"8"),new Regex(@"9"),new Regex(@":"), new Regex(@";"),
            //    new Regex(@"<"),new Regex(@"="),new Regex(@">"), new Regex(@"?"),
            //    new Regex(@"@"),new Regex(@"A"),new Regex(@"B"), new Regex(@"C"),
            //    new Regex(@"D"),new Regex(@"E"),new Regex(@"F"), new Regex(@"G"),
            //    new Regex(@"H"),new Regex(@"I"),new Regex(@"J"), new Regex(@"K"),
            //    new Regex(@"L"),new Regex(@"M"),new Regex(@"N"), new Regex(@"O"),
            //    new Regex(@"P"),new Regex(@"Q"),new Regex(@"R"), new Regex(@"S"),
            //    new Regex(@"T"),new Regex(@"U"),new Regex(@"V"), new Regex(@"W"),
            //    new Regex(@"X"),new Regex(@"Y"),new Regex(@"Z"), new Regex(@"["),
            //    new Regex(@"\"),new Regex(@"]"),new Regex(@"^"), new Regex(@"_"),
            //    new Regex(@"`"),new Regex(@"a"),new Regex(@"b"), new Regex(@"c"),
            //    new Regex(@"d"),new Regex(@"e"),new Regex(@"f"), new Regex(@"g"),
            //    new Regex(@"h"),new Regex(@"i"),new Regex(@"j"), new Regex(@"k"),
            //    new Regex(@"l"),new Regex(@"m"),new Regex(@"n"), new Regex(@"o"),
            //    new Regex(@"p"),new Regex(@"q"),new Regex(@"r"), new Regex(@"s"),
            //    new Regex(@"t"),new Regex(@"u"),new Regex(@"v"), new Regex(@"w"),
            //    new Regex(@"x"),new Regex(@"y"),new Regex(@"z"), new Regex(@"{"),
            //    new Regex(@"|"),new Regex(@"}"),new Regex(@"~"),
            //};
        }
    }
}
