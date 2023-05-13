using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Utility {
        internal const string hashCodeSeparator = "¥¥";
        /// <summary>
        /// ⌕⌖⌗⌘]⌚⌛⏳⏩∙∎⁂。⊳[▶]#9654;[▷]#9655;[▸]#9656;[▹]#9657;[►]#9658;[▻]#9659;[☛]#9755;[☞]#9758;
        /// [➔]#10132;[➙]#10137;[➛]#10139;[➜]#10140;[➝]#10141;[➞]#10142;[➟]#10143;[➠]#10144;
        /// [➡]#10145;[➢]#10146;[➣]#10147;[➤]#10148;[➥]#10149;[➦]#10150;[➧]#10151;[➨]#10152;
        /// [➩]#10153;[➪]#10154;[➫]#10155;[➬]#10156;[➭]#10157;[➮]#10158;[➯]#10159;[➱]#10161;[➲]#10162;
        /// [➳]#10163;[➵]#10165;[➸]#10168;[➺]#10170;[➻]#10171;[➼]#10172;[➽]#10173;[➾]#10174;
        /// [⤀]#10496;[⤁]#10497;[⤃]#10499;[⤅]#10501;[⤇]#10503;[⤍]#10509;[⤏]#10511;[⤐]#10512;[⤑]#10513;
        /// [⤔]#10516;[⤕]#10517;[⤖]#10518;[⤗]#10519; [⤘]#10520;[⤜]#10524;[⤞]#10526;[⤠]#10528;
        /// [⥤]#10596;[⥬]#10604;[⥭]#10605;[⦊]#10634;
        /// </summary>
        internal const string dot = "⏳";

        private static int lastOutputLength = 0;
        /// <summary>
        /// erase content written the last time and write something new.
        /// </summary>
        /// <param name="content"></param>
        public static void Rewrite(string content) {
            if (content == null) { content = string.Empty; }

            var currentLength = content.Length;
            var delta = lastOutputLength - currentLength;
            for (int t = 0; t < delta; t++) { Console.Write('\u0008'); } // move back
            for (int t = 0; t < delta; t++) { Console.Write(' '); } // space
            for (int t = 0; t < lastOutputLength; t++) { Console.Write('\u0008'); } // move back 
            Console.Write(content);
            lastOutputLength = content.Length;
        }
    }
}
