using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace bitzhuwei.StepFormat
{
    public abstract class StepArg : IStepPrinter
    {
        public abstract void Print(TextWriter w);
    }

    /// <summary>
    /// 23: Arg : "Identity" ;
    /// </summary>
    public class StepArg23 : StepArg
    {
        /// <summary>
        /// #nnn followed by ',' or ')'
        /// </summary>
        public readonly string identity;

        /// <summary>
        /// 23: Arg : "Identity" ;
        /// </summary>
        /// <param name="identity"></param>
        public StepArg23(string identity)
        {
            this.identity = identity;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{identity}");
        }
    }


    /// <summary>
    /// 24: Arg : "Dollar" ;
    /// </summary>
    public class StepArg24 : StepArg
    {
        public readonly string dollar;

        public StepArg24(string dollar)
        {
            this.dollar = dollar;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{dollar}");
        }
    }

    public class StepArg25 : StepArg
    {
        public readonly string asterisk;

        public StepArg25(string asterisk)
        {
            this.asterisk = asterisk;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{asterisk}");
        }
    }


    public class StepArg26 : StepArg
    {
        public readonly string string_;

        public StepArg26(string string_)
        {
            this.string_ = string_;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{string_}");
        }
    }


    public class StepArg27 : StepArg
    {
        public readonly string integer;

        public StepArg27(string integer)
        {
            this.integer = integer;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{integer}");
        }
    }


    public class StepArg28 : StepArg
    {
        public readonly string float_;

        public StepArg28(string float_)
        {
            this.float_ = float_;
        }

        public override void Print(TextWriter w)
        {
            w.Write($"{float_}");
        }
    }

    public class StepArg29 : StepArg
    {
        public readonly string hexadecimal;

        public StepArg29(string hexadecimal)
        {
            this.hexadecimal = hexadecimal;
        }
        public override void Print(TextWriter w)
        {
            w.Write($"{hexadecimal}");
        }
    }

    public class StepArg30 : StepArg
    {
        public readonly string Enum_;

        public StepArg30(string Enum_)
        {
            this.Enum_ = Enum_;
        }
        public override void Print(TextWriter w)
        {
            w.Write($"{Enum_}");
        }
    }

    public class StepArg31 : StepArg
    {
        public readonly List<StepArg> argList;

        public StepArg31(List<StepArg> argList)
        {
            this.argList = argList;
        }

        public override void Print(TextWriter w)
        {
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

    public class StepArg32 : StepArg
    {
        public readonly StepTypeObj typeObj;

        public StepArg32(StepTypeObj typeObj)
        {
            this.typeObj = typeObj;
        }

        public override void Print(TextWriter w)
        {
            typeObj.Print(w);
        }
    }
}