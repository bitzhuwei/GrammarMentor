using System.Collections.Generic;
using System.IO;
using System.Text;

namespace bitzhuwei.StepFormat
{
    /// <summary>
    /// TypeName( Arg, Arg, ... )
    /// </summary>
    public class StepTypeObj : IStepPrinter
    {
        public readonly string typeName;
        public readonly List<StepArg> argList;

        /// <summary>
        /// TypeName( Arg, Arg, ... )
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="argList"></param>
        public StepTypeObj(string typeName, List<StepArg> argList)
        {
            this.typeName = typeName;
            this.argList = argList;
        }

        public override string ToString()
        {
            var b = new StringBuilder();
            using (var w = new StringWriter(b))
            {
                this.Print(w);
            }
            return b.ToString();
        }

        public void Print(TextWriter w)
        {
            w.Write($"{typeName}");
            //w.Write($"{CompilerStep.EType.LeftParenthesis} ");
            w.Write("(");
            for (int i = 0; i < argList.Count - 1; i++)
            {
                var arg = argList[i];
                arg.Print(w); w.Write(", ");
            }
            if (argList.Count > 0)
            {
                var arg = argList[argList.Count - 1];
                arg.Print(w);
            }
            //w.Write($"{CompilerStep.EType.RightParenthesis}");
            w.Write(")");
        }
    }
}