using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace bitzhuwei.StepFormat
{
    public class StepModel : IStepPrinter
    {
        /// <summary>
        /// ISO-nnn-nnn
        /// </summary>
        public readonly string step;
        /// <summary>
        /// a list of <see cref="StepTypeObj"/>
        /// </summary>
        public readonly List<StepTypeObj> headlineList;
        /// <summary>
        /// <see cref="StepEntity.entityId"/> -&gt; <see cref="StepEntity"/>
        /// </summary>
        public readonly Dictionary<string/*EntityId*/, StepEntity> entityDict;

        /// <summary>
        /// END-ISO-nnn-nnn
        /// </summary>
        public readonly string endStep;

        public StepModel(string step, List<StepTypeObj> headlineList, Dictionary<string, StepEntity> entityDict, string endStep)
        {
            this.step = step;
            this.headlineList = headlineList;
            this.entityDict = entityDict;
            this.endStep = endStep;
        }

        public override string ToString()
        {
            return $"{entityDict.Count} entitys, {headlineList.Count} headlines";
        }

        public void Print(TextWriter w)
        {
            w.WriteLine($"{step};");
            // header
            //w.WriteLine($"{CompilerStep.EType.HEADER};");
            w.WriteLine("HEADER;");
            {
                foreach (var item in headlineList)
                {
                    item.Print(w);
                    //w.WriteLine($"{CompilerStep.EType.Semicolon}");
                    w.WriteLine(";");
                }
            }
            //w.WriteLine($"{CompilerStep.EType.ENDSEC};");
            w.WriteLine("ENDSEC;");
            // entitys
            //w.WriteLine($"{CompilerStep.EType.DATA};");
            w.WriteLine("DATA;");
            {
                var query = from item in entityDict
                            orderby int.Parse(item.Key.Substring(1)) ascending
                            select item;
                foreach (var item in query)
                {
                    item.Value.Print(w);
                    w.WriteLine();
                }
            }
            //w.WriteLine($"{CompilerStep.EType.ENDSEC};");
            w.WriteLine("ENDSEC;");
            w.WriteLine($"{endStep};");
        }
    }
}