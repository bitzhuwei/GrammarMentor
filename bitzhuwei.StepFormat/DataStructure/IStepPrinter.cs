using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;

namespace bitzhuwei.StepFormat
{
    public interface IStepPrinter
    {
        void Print(TextWriter w);
    }
}