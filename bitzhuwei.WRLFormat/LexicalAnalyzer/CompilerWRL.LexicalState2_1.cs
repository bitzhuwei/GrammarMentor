using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        private static readonly LexicalState lexicalState2_1 = new LexicalState($"{nameof(CompilerWRL)}.LexiStates[2_1]",
            new LexicalRule(
            currentChar => (('a' <= currentChar && currentChar <= 'z')
                || ('A' <= currentChar && currentChar <= 'Z')
                || ('0' <= currentChar && currentChar <= '9')
                || (currentChar == '_')),
            context => lexicalState2_1),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                if (str == "ambientColor") { token.type = EType.ambientColor; }
                else if (str == "Separator") { token.type = EType.Separator; }
                else if (str == "diffuseColor") { token.type = EType.diffuseColor; }
                else if (str == "emissiveColor") { token.type = EType.emissiveColor; }
                else if (str == "specularColor") { token.type = EType.specularColor; }
                else if (str == "shininess") { token.type = EType.shininess; }
                else if (str == "transparency") { token.type = EType.transparency; }
                else if (str == "point") { token.type = EType.point; }
                else if (str == "coordIndex") { token.type = EType.coordIndex; }
                else { token.type = EType.identifier; }
                token.value = str;
                context.MoveBack(1);
                return lexicalState0;
            }));

    }
}
