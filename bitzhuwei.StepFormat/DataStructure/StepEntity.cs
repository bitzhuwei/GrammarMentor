using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Xml.Serialization;

namespace bitzhuwei.StepFormat
{
    /// <summary>
    /// #nnn = ... ;
    /// </summary>
    public class StepEntity : IStepPrinter
    {
        /// <summary>
        /// #nnn followed by = ...
        /// </summary>
        public readonly string entityId;
        /// <summary>
        /// true: SCOPE ... ENDSCOPE ... exists.
        /// </summary>
        public readonly bool scope;
        /// <summary>
        /// SCOPE ... ENDSCOPE
        /// </summary>
        public readonly List<StepEntity> entityList;
        /// <summary>
        /// / #nnn, #nnn, ... /
        /// </summary>
        public readonly List<string> idList;
        /// <summary>
        /// when one element: TypeName( Arg, Arg, ... )
        /// <para>when more elements: ( TypeName( Arg, Arg, ... ) TypeName( ... ) ... )</para>
        /// </summary>
        public readonly List<StepTypeObj> typeObjList;


        const int indent = 4;

        /// <summary>
        /// #nnn = ... ;
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="scope"></param>
        /// <param name="entityList"></param>
        /// <param name="idList"></param>
        /// <param name="typeObjList"></param>
        public StepEntity(string entityId, bool scope, List<StepEntity> entityList, List<string> idList, List<StepTypeObj> typeObjList)
        {
            this.entityId = entityId;
            this.scope = scope;
            this.entityList = entityList;
            this.idList = idList;
            this.typeObjList = typeObjList;
        }

        public void Print(TextWriter w)
        {
            Print(w, 0);
        }

        private void Print(TextWriter w, int indent)
        {
            var scope = this.scope;
            var entityList = this.entityList;
            var idList = this.idList;
            var typeObjList = this.typeObjList;

            w.Write($"{this.entityId} = ");
            if (scope)
            {
                Utility.PrintTab(w, indent);
                //w.WriteLine($"{CompilerStep.EType.SCOPE}");
                w.WriteLine("SCOPE");
                foreach (var entity in entityList)
                {
                    entity.Print(w, indent + StepEntity.indent);
                }
                Utility.PrintTab(w, indent);
                //w.WriteLine($"{CompilerStep.EType.ENDSCOPE}");
                w.WriteLine($"ENDSCOPE");

                if (idList.Count > 0)
                {
                    Utility.PrintTab(w, indent);
                    //w.Write($"{CompilerStep.EType.Slash} ");
                    w.Write("/ ");
                    for (int i = 0; i < idList.Count - 1; i++)
                    {
                        string identity = idList[i];
                        w.Write($"{identity}, ");
                    }
                    {
                        string identity = idList[idList.Count - 1];
                        w.Write($"{identity}");
                    }
                    //w.Write($"{CompilerStep.EType.Slash}");
                    w.Write(" /");
                    w.WriteLine();
                }
            }

            if (typeObjList.Count > 1)
            {
                Utility.PrintTab(w, indent);
                //w.Write($"{CompilerStep.EType.LeftParenthesis} ");
                w.Write("(");
                for (int i = 0; i < typeObjList.Count - 1; i++)
                {
                    var typeObj = typeObjList[i];
                    typeObj.Print(w); w.Write(" ");
                }
                if (typeObjList.Count > 0)
                {
                    var typeObj = typeObjList[typeObjList.Count - 1];
                    typeObj.Print(w);
                }
                //w.Write($"{CompilerStep.EType.RightParenthesis}");
                w.Write(")");
            }
            else
            {
                Utility.PrintTab(w, indent);
                foreach (var typeObj in typeObjList)
                {
                    typeObj.Print(w);
                }
            }
            w.Write(";");
        }


    }
}